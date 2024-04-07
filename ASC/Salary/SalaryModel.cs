using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using ASC.Common.Interfaces;
using ASC.Extensions;
using ASC.Models;
using ASC.SimpleClasses;

namespace ASC.Salary
{
	// Token: 0x0200013F RID: 319
	public class SalaryModel : UsersModel
	{
		// Token: 0x060015EA RID: 5610 RVA: 0x00034B64 File Offset: 0x00032D64
		public List<store_int_reserve> LoadMasterItems(int userId)
		{
			return (from i in this._context.store_int_reserve
			where i.to_user == userId && (i.state == 1 || i.state == 2)
			select i).ToListSafe<store_int_reserve>();
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x00034C58 File Offset: 0x00032E58
		public UserSalaryReport LoadUserReport(users user, IPeriod period, decimal? newSalaryRate)
		{
			UserSalaryReport userSalaryReport = new UserSalaryReport();
			userSalaryReport.MonthSalary = this.GetMonthSalaryRate(user, period, newSalaryRate);
			userSalaryReport.TotalPartsOnUser = this.CountTotalPartsOnUser(user);
			userSalaryReport.InstalledUserParts = this.CountInstalledUserParts(user);
			userSalaryReport.NotInstalledUserParts = this.CountNotInstalledUserParts(user);
			this.LoadSummPartsOnUser(user.id, userSalaryReport);
			this.LoadUserRepairs(user.id, userSalaryReport, period);
			this.LoadPayments(userSalaryReport, user.id, period);
			this.LoadInstalledUserPartsSumm(user.id, userSalaryReport);
			this.LoadNotInstalledUserPartsSumm(user.id, userSalaryReport);
			userSalaryReport.CalcSummPayWorksUser(user);
			userSalaryReport.CalcSummNonOutWorks(user);
			userSalaryReport.SetAdditionalPayments(this.LoadAdditionalPayments(period, user.id));
			this.LoadSales(user.id, userSalaryReport, period);
			SalaryModel.LoadInRepairSales(userSalaryReport, user, period);
			this.LoadAcceptedRepairs(userSalaryReport, user, period);
			this.LoadIssuedRepairs(userSalaryReport, user, period);
			this.LoadLastSalaryPayment(user.id, userSalaryReport, period);
			this.LoadAlreadyPayed(user.id, period, userSalaryReport);
			this.LoadPaySumm(userSalaryReport);
			return userSalaryReport;
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x00034D54 File Offset: 0x00032F54
		private decimal GetMonthSalaryRate(users user, IPeriod period, decimal? newSalaryRate)
		{
			DateTime? created = user.created;
			int year = (created != null) ? created.GetValueOrDefault().Year : DateTime.Now.Year;
			created = user.created;
			DateTime t = new DateTime(year, (created != null) ? created.GetValueOrDefault().Month : DateTime.Now.Month, 1);
			if (newSalaryRate != null)
			{
				return newSalaryRate.Value;
			}
			if (!(t > period.From.Date))
			{
				SalaryRate salaryRate = (from i in this._context.SalaryRates.AsNoTracking()
				where i.UserId == user.id
				where i.StartFrom <= period.From.Date
				orderby i.StartFrom descending
				select i).FirstOrDefault<SalaryRate>();
				return (salaryRate != null) ? salaryRate.Value : 0;
			}
			return 0m;
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x00034F98 File Offset: 0x00033198
		private int CountNotInstalledUserParts(users user)
		{
			return this._context.store_int_reserve.Count(SalaryModel.UserParts(user.id, 1));
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x00034FC4 File Offset: 0x000331C4
		private int CountInstalledUserParts(users user)
		{
			return this._context.store_int_reserve.Count(SalaryModel.UserParts(user.id, 2));
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x00034FF0 File Offset: 0x000331F0
		private int CountTotalPartsOnUser(users user)
		{
			return this._context.store_int_reserve.Count((store_int_reserve i) => i.to_user == user.id && (i.state == 1 || i.state == 2));
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x000350F4 File Offset: 0x000332F4
		private static void LoadInRepairSales(UserSalaryReport report, users user, IPeriod period)
		{
			if (!user.pay_4_sale_in_repair)
			{
				return;
			}
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					List<store_int_reserve> inRepairSales = (from r in auseceEntities.store_int_reserve.Include((store_int_reserve r) => r.users).Include((store_int_reserve r) => r.workshop).Include((store_int_reserve r) => r.workshop.devices).Include((store_int_reserve r) => r.workshop.device_makers).Include((store_int_reserve r) => r.workshop.device_models).Include((store_int_reserve r) => r.store_items)
					where r.to_user == user.id && r.state == 3 && r.workshop.out_date >= (DateTime?)period.From && r.workshop.out_date <= (DateTime?)period.To
					select r).ToList<store_int_reserve>();
					report.SetInRepairSales(inRepairSales);
				}
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Load in repair sales fail");
				report.SetInRepairSales(new List<store_int_reserve>());
			}
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x00035504 File Offset: 0x00033704
		private void LoadAcceptedRepairs(UserSalaryReport report, users user, IPeriod period)
		{
			List<workshop> acceptedRepairs = (from r in this._context.workshop.Include((workshop r) => r.devices).Include((workshop r) => r.device_makers).Include((workshop r) => r.device_models)
			where r.manager == user.id && r.in_date >= period.From && r.in_date <= period.To
			select r).ToList<workshop>();
			report.SetAcceptedRepairs(acceptedRepairs);
			report.CalcSummUserAccepted(user);
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x00035740 File Offset: 0x00033940
		private void LoadIssuedRepairs(UserSalaryReport report, users user, IPeriod period)
		{
			List<workshop> issuedRepairs = (from i in this._context.workshop_issued.AsNoTracking().Include((workshop_issued i) => i.workshop.devices).Include((workshop_issued i) => i.workshop.device_makers).Include((workshop_issued i) => i.workshop.device_models)
			where i.created_at >= period.From && i.created_at <= period.To && i.employee_id == user.id
			select i.workshop).ToList<workshop>();
			report.SetIssuedRepairs(issuedRepairs);
			report.CalcSummUserIssued(user);
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x000359F8 File Offset: 0x00033BF8
		private void LoadAlreadyPayed(int employeeId, IPeriod period, UserSalaryReport report)
		{
			report.Advance = (from p in this._context.salary
			where p.user_id == employeeId && p.period_from >= period.From && p.period_to <= period.To && (int)p.type == 1
			select p.summ).DefaultIfEmpty<decimal>().Sum();
			report.AlreadyPayed = (from p in this._context.salary
			where p.user_id == employeeId && p.period_from >= period.From && p.period_to <= period.To && (int)p.type == 0
			select p.summ).DefaultIfEmpty<decimal>().Sum();
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x00035DA0 File Offset: 0x00033FA0
		private void LoadLastSalaryPayment(int employeeId, UserSalaryReport report, IPeriod period)
		{
			report.LastSalary = (from p in this._context.salary
			orderby p.id descending
			select p).FirstOrDefault((salary p) => p.user_id == employeeId && (int)p.type == 0 && p.period_from < period.From);
			report.NoSalaryRecords = (report.LastSalary == null);
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x00035F28 File Offset: 0x00034128
		public Task<int> MakeSalaryPayment(int employeeId, UserSalaryReport report, Period period, int paymentOption, DateTime date)
		{
			SalaryModel.<MakeSalaryPayment>d__13 <MakeSalaryPayment>d__;
			<MakeSalaryPayment>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<MakeSalaryPayment>d__.<>4__this = this;
			<MakeSalaryPayment>d__.employeeId = employeeId;
			<MakeSalaryPayment>d__.report = report;
			<MakeSalaryPayment>d__.period = period;
			<MakeSalaryPayment>d__.paymentOption = paymentOption;
			<MakeSalaryPayment>d__.date = date;
			<MakeSalaryPayment>d__.<>1__state = -1;
			<MakeSalaryPayment>d__.<>t__builder.Start<SalaryModel.<MakeSalaryPayment>d__13>(ref <MakeSalaryPayment>d__);
			return <MakeSalaryPayment>d__.<>t__builder.Task;
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x00035F98 File Offset: 0x00034198
		private void LoadPaySumm(UserSalaryReport report)
		{
			report.TotalPlus = report.MonthSalary + report.SummPayWorksUser + report.TotalPaySale + report.AddtionalPlus + report.AddtionalMinus + report.SummIoDevices;
			report.PaySumm = report.TotalPlus - report.AlreadyPayed - report.Advance;
			if (report.LastSalary != null)
			{
				report.PaySumm += report.LastSalary.balance;
			}
			report.FinalPaySumm = report.PaySumm;
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x0003603C File Offset: 0x0003423C
		private void LoadSales(int userId, UserSalaryReport report, IPeriod period)
		{
			report.SetSales((from d in this._context.docs
			where d.state == (int?)5 && d.user == userId && d.created >= period.From && d.created <= period.To
			orderby d.created
			select d).ToListSafe<docs>());
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x0003621C File Offset: 0x0003441C
		private void LoadUserRepairs(int userId, UserSalaryReport report, IPeriod period)
		{
			report.SetRepairs((from r in this._context.workshop.AsNoTracking().Include((workshop i) => i.c_workshop.cartridge_cards).Where(SalaryModel.MatchParameters(userId, period))
			orderby r.out_date
			select r).ToListSafe<workshop>());
			report.SetNonOutRepairs((from r in this._context.workshop.AsNoTracking().Include((workshop i) => i.c_workshop.cartridge_cards)
			where r.state == 6 && r.master == (int?)userId
			orderby r.id
			select r).ToListSafe<workshop>());
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x00036444 File Offset: 0x00034644
		private static Expression<Func<workshop, bool>> MatchParameters(int userId, IPeriod period)
		{
			if (Auth.Config.debt_rep_2_salary)
			{
				return (workshop r) => (r.state == 8 || r.state == 16) && r.works.Any((works w) => w.user == userId) && r.out_date >= (DateTime?)period.From && r.out_date <= (DateTime?)period.To;
			}
			return (workshop r) => r.state == 8 && r.works.Any((works w) => w.user == userId) && r.out_date >= (DateTime?)period.From && r.out_date <= (DateTime?)period.To;
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x00036844 File Offset: 0x00034A44
		private void LoadSummPartsOnUser(int userId, UserSalaryReport report)
		{
			report.SummPartsOnUser = (from i in this._context.store_int_reserve
			where i.to_user == userId && (i.state == 1 || i.state == 2)
			select i).Select(SalaryModel.ItemSumm()).DefaultIfEmpty<decimal>().Sum();
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x00036950 File Offset: 0x00034B50
		private void LoadInstalledUserPartsSumm(int userId, UserSalaryReport report)
		{
			report.InstalledUserPartsSumm = this._context.store_int_reserve.Where(SalaryModel.UserParts(userId, 2)).Select(SalaryModel.ItemSumm()).DefaultIfEmpty<decimal>().Sum();
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x00036990 File Offset: 0x00034B90
		private void LoadNotInstalledUserPartsSumm(int userId, UserSalaryReport report)
		{
			report.NotInstalledUserPartsSumm = this._context.store_int_reserve.Where(SalaryModel.UserParts(userId, 1)).Select(SalaryModel.ItemSumm()).DefaultIfEmpty<decimal>().Sum();
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x000369D0 File Offset: 0x00034BD0
		private static Expression<Func<store_int_reserve, decimal>> ItemSumm()
		{
			return (store_int_reserve i) => (decimal)i.count * i.price;
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x00036A50 File Offset: 0x00034C50
		private static Expression<Func<store_int_reserve, bool>> UserParts(int userId, int state)
		{
			return (store_int_reserve i) => i.to_user == userId && i.state == state;
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x00036B0C File Offset: 0x00034D0C
		private void LoadPayments(UserSalaryReport report, int userId, IPeriod period)
		{
			ParameterExpression parameterExpression;
			report.SetPayments((from o in this._context.salary.Select(System.Linq.Expressions.Expression.Lambda<Func<salary, CashOrdersLite>>(System.Linq.Expressions.Expression.MemberInit(System.Linq.Expressions.Expression.New(typeof(CashOrdersLite)), new MemberBinding[]
			{
				System.Linq.Expressions.Expression.Bind(methodof(CashOrdersLite.set_id(int)), System.Linq.Expressions.Expression.Property(parameterExpression, methodof(salary.get_id()))),
				System.Linq.Expressions.Expression.Bind(methodof(CashOrdersLite.set_created(DateTime)), System.Linq.Expressions.Expression.Property(parameterExpression, methodof(salary.get_payment_date()))),
				System.Linq.Expressions.Expression.Bind(methodof(CashOrdersLite.set_ToUserId(int?)), System.Linq.Expressions.Expression.Convert(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(salary.get_user_id())), typeof(int?))),
				System.Linq.Expressions.Expression.Bind(methodof(CashOrdersLite.set_ToUserLastName(string)), System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(salary.get_users())), methodof(users.get_surname()))),
				System.Linq.Expressions.Expression.Bind(methodof(CashOrdersLite.set_ToUserFirstName(string)), System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(salary.get_users())), methodof(users.get_name()))),
				System.Linq.Expressions.Expression.Bind(methodof(CashOrdersLite.set_ToUserPatronymic(string)), System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(salary.get_users())), methodof(users.get_patronymic()))),
				System.Linq.Expressions.Expression.Bind(methodof(CashOrdersLite.set_UserLastName(string)), System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(salary.get_users1())), methodof(users.get_surname()))),
				System.Linq.Expressions.Expression.Bind(methodof(CashOrdersLite.set_UserFirstName(string)), System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(salary.get_users1())), methodof(users.get_name()))),
				System.Linq.Expressions.Expression.Bind(methodof(CashOrdersLite.set_UserPatronymic(string)), System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(salary.get_users1())), methodof(users.get_patronymic()))),
				System.Linq.Expressions.Expression.Bind(methodof(CashOrdersLite.set_username(string)), System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(salary.get_users())), methodof(users.get_username()))),
				System.Linq.Expressions.Expression.Bind(methodof(CashOrdersLite.set_notes(string)), System.Linq.Expressions.Expression.Property(parameterExpression, methodof(salary.get_notes()))),
				System.Linq.Expressions.Expression.Bind(methodof(CashOrdersLite.set_summa(decimal)), System.Linq.Expressions.Expression.Property(parameterExpression, methodof(salary.get_summ()))),
				System.Linq.Expressions.Expression.Bind(methodof(CashOrdersLite.set_PeriodFrom(DateTime)), System.Linq.Expressions.Expression.Property(parameterExpression, methodof(salary.get_period_from()))),
				System.Linq.Expressions.Expression.Bind(methodof(CashOrdersLite.set_PeriodTo(DateTime)), System.Linq.Expressions.Expression.Property(parameterExpression, methodof(salary.get_period_to())))
			}), new ParameterExpression[]
			{
				parameterExpression
			}))
			where o.ToUserId == (int?)userId && o.PeriodFrom >= period.From && o.PeriodTo <= period.To
			select o).ToListSafe<CashOrdersLite>());
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x00036FC4 File Offset: 0x000351C4
		public int MakeAdvance(int userId, decimal summ, int paymentOption, string notes, DateTime date)
		{
			salary entity = new salary
			{
				user_id = userId,
				from_user = Auth.User.id,
				summ = summ,
				balance = 0m,
				payment_date = date,
				notes = notes,
				period_from = date,
				period_to = date,
				type = 1
			};
			int result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					using (DbContextTransaction dbContextTransaction = auseceEntities.Database.BeginTransaction())
					{
						auseceEntities.salary.Add(entity);
						auseceEntities.SaveChanges();
						int num = this._kassaModel.AdvancePay(auseceEntities, userId, summ, paymentOption, date);
						dbContextTransaction.Commit();
						result = num;
					}
				}
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Make advance fail");
				throw;
			}
			return result;
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x000370BC File Offset: 0x000352BC
		public List<works> LoadRepairWorks(int repairId, int userId)
		{
			List<works> result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					result = (from w in auseceEntities.works
					where w.repair == (int?)repairId && w.user == userId
					select w).ToList<works>();
				}
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Load user works fial");
				result = new List<works>();
			}
			return result;
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x000371E4 File Offset: 0x000353E4
		public IEnumerable<store_int_reserve> LoadRepairParts(int repairId, IEnumerable<works> works)
		{
			int repairId;
			List<int> workIds;
			for (;;)
			{
				IL_82:
				int num = -381115193;
				for (;;)
				{
					switch ((num ^ -358006224) % 4)
					{
					case 0:
						goto IL_82;
					case 1:
						goto IL_89;
					case 3:
						repairId = repairId2;
						workIds = (from w in works
						select w.id).ToList<int>();
						num = ((!workIds.Any<int>()) ? -1748249883 : -1988881506);
						continue;
					}
					goto Block_3;
				}
			}
			Block_3:
			goto IL_8F;
			IL_89:
			return new List<store_int_reserve>();
			IL_8F:
			return (from i in this._context.store_int_reserve
			where i.repair_id == (int?)repairId && workIds.Contains(i.work_id.Value)
			select i).ToList<store_int_reserve>();
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x00037378 File Offset: 0x00035578
		public IEnumerable<additional_payments> LoadAdditionalPayments(IPeriod period, int userId)
		{
			return (from p in this._context.additional_payments.AsNoTracking()
			where p.payment_date >= period.From && p.payment_date <= period.To && p.to_user == userId
			select p).ToListSafe<additional_payments>();
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x000374D4 File Offset: 0x000356D4
		public bool SaveAdditionalPayments(IEnumerable<additional_payments> payments, int userId)
		{
			foreach (additional_payments additional_payments in (from p in payments
			where p.id == 0
			select p).ToList<additional_payments>())
			{
				additional_payments.payment_date = this._localization.Now;
				additional_payments.user = Auth.User.id;
				additional_payments.to_user = userId;
				this._context.additional_payments.Add(additional_payments);
			}
			return base.SaveContext(false);
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x00037588 File Offset: 0x00035788
		public SalaryModel()
		{
		}

		// Token: 0x04000AB8 RID: 2744
		private KassaModel _kassaModel = new KassaModel();

		// Token: 0x04000AB9 RID: 2745
		private Localization _localization = new Localization("UTC");

		// Token: 0x02000140 RID: 320
		public enum Type
		{
			// Token: 0x04000ABB RID: 2747
			Salary,
			// Token: 0x04000ABC RID: 2748
			Advance
		}

		// Token: 0x02000141 RID: 321
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x06001606 RID: 5638 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x04000ABD RID: 2749
			public int userId;
		}

		// Token: 0x02000142 RID: 322
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x06001607 RID: 5639 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x04000ABE RID: 2750
			public users user;

			// Token: 0x04000ABF RID: 2751
			public IPeriod period;
		}

		// Token: 0x02000143 RID: 323
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001608 RID: 5640 RVA: 0x000375B8 File Offset: 0x000357B8
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06001609 RID: 5641 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x0600160A RID: 5642 RVA: 0x000375D0 File Offset: 0x000357D0
			internal int <LoadRepairParts>b__26_0(works w)
			{
				return w.id;
			}

			// Token: 0x0600160B RID: 5643 RVA: 0x000375E4 File Offset: 0x000357E4
			internal bool <SaveAdditionalPayments>b__28_0(additional_payments p)
			{
				return p.id == 0;
			}

			// Token: 0x04000AC0 RID: 2752
			public static readonly SalaryModel.<>c <>9 = new SalaryModel.<>c();

			// Token: 0x04000AC1 RID: 2753
			public static Func<works, int> <>9__26_0;

			// Token: 0x04000AC2 RID: 2754
			public static Func<additional_payments, bool> <>9__28_0;
		}

		// Token: 0x02000144 RID: 324
		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x0600160C RID: 5644 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x04000AC3 RID: 2755
			public users user;
		}

		// Token: 0x02000145 RID: 325
		[CompilerGenerated]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x0600160D RID: 5645 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x04000AC4 RID: 2756
			public users user;

			// Token: 0x04000AC5 RID: 2757
			public IPeriod period;
		}

		// Token: 0x02000146 RID: 326
		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x0600160E RID: 5646 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x04000AC6 RID: 2758
			public users user;

			// Token: 0x04000AC7 RID: 2759
			public IPeriod period;
		}

		// Token: 0x02000147 RID: 327
		[CompilerGenerated]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x0600160F RID: 5647 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x04000AC8 RID: 2760
			public IPeriod period;

			// Token: 0x04000AC9 RID: 2761
			public users user;
		}

		// Token: 0x02000148 RID: 328
		[CompilerGenerated]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x06001610 RID: 5648 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass11_0()
			{
			}

			// Token: 0x04000ACA RID: 2762
			public int employeeId;

			// Token: 0x04000ACB RID: 2763
			public IPeriod period;
		}

		// Token: 0x02000149 RID: 329
		[CompilerGenerated]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x06001611 RID: 5649 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x04000ACC RID: 2764
			public int employeeId;

			// Token: 0x04000ACD RID: 2765
			public IPeriod period;
		}

		// Token: 0x0200014A RID: 330
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <MakeSalaryPayment>d__13 : IAsyncStateMachine
		{
			// Token: 0x06001612 RID: 5650 RVA: 0x000375FC File Offset: 0x000357FC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				SalaryModel salaryModel = this.<>4__this;
				int result;
				try
				{
					if (num > 1)
					{
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<int> awaiter;
						ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter awaiter2;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<int>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								goto IL_1D0;
							}
							salary entity = new salary
							{
								type = 0,
								user_id = this.employeeId,
								from_user = Auth.User.id,
								summ = this.report.FinalPaySumm,
								payment_date = salaryModel._localization.Now,
								balance = this.report.PaySumm - this.report.FinalPaySumm,
								period_from = this.period.From,
								period_to = this.period.To,
								notes = string.Format((string)Application.Current.TryFindResource("SalaryPaymentNote"), this.period.From, this.period.To)
							};
							this.<ctx>5__2.salary.Add(entity);
							awaiter2 = this.<ctx>5__2.SaveChangesAsync().ConfigureAwait(false).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num3 = 0;
								num = 0;
								this.<>1__state = num3;
								this.<>u__1 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter, SalaryModel.<MakeSalaryPayment>d__13>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
						}
						awaiter2.GetResult();
						awaiter = salaryModel._kassaModel.SalaryPay(this.employeeId, this.report.FinalPaySumm, this.paymentOption, this.date).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num5 = 1;
							num = 1;
							this.<>1__state = num5;
							this.<>u__2 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, SalaryModel.<MakeSalaryPayment>d__13>(ref awaiter, ref this);
							return;
						}
						IL_1D0:
						result = awaiter.GetResult();
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06001613 RID: 5651 RVA: 0x00037880 File Offset: 0x00035A80
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000ACE RID: 2766
			public int <>1__state;

			// Token: 0x04000ACF RID: 2767
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x04000AD0 RID: 2768
			public int employeeId;

			// Token: 0x04000AD1 RID: 2769
			public UserSalaryReport report;

			// Token: 0x04000AD2 RID: 2770
			public SalaryModel <>4__this;

			// Token: 0x04000AD3 RID: 2771
			public Period period;

			// Token: 0x04000AD4 RID: 2772
			public int paymentOption;

			// Token: 0x04000AD5 RID: 2773
			public DateTime date;

			// Token: 0x04000AD6 RID: 2774
			private auseceEntities <ctx>5__2;

			// Token: 0x04000AD7 RID: 2775
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x04000AD8 RID: 2776
			private TaskAwaiter<int> <>u__2;
		}

		// Token: 0x0200014B RID: 331
		[CompilerGenerated]
		private sealed class <>c__DisplayClass15_0
		{
			// Token: 0x06001614 RID: 5652 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass15_0()
			{
			}

			// Token: 0x04000AD9 RID: 2777
			public int userId;

			// Token: 0x04000ADA RID: 2778
			public IPeriod period;
		}

		// Token: 0x0200014C RID: 332
		[CompilerGenerated]
		private sealed class <>c__DisplayClass16_0
		{
			// Token: 0x06001615 RID: 5653 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass16_0()
			{
			}

			// Token: 0x04000ADB RID: 2779
			public int userId;
		}

		// Token: 0x0200014D RID: 333
		[CompilerGenerated]
		private sealed class <>c__DisplayClass17_0
		{
			// Token: 0x06001616 RID: 5654 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass17_0()
			{
			}

			// Token: 0x04000ADC RID: 2780
			public int userId;

			// Token: 0x04000ADD RID: 2781
			public IPeriod period;
		}

		// Token: 0x0200014E RID: 334
		[CompilerGenerated]
		private sealed class <>c__DisplayClass18_0
		{
			// Token: 0x06001617 RID: 5655 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass18_0()
			{
			}

			// Token: 0x04000ADE RID: 2782
			public int userId;
		}

		// Token: 0x0200014F RID: 335
		[CompilerGenerated]
		private sealed class <>c__DisplayClass22_0
		{
			// Token: 0x06001618 RID: 5656 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass22_0()
			{
			}

			// Token: 0x04000ADF RID: 2783
			public int userId;

			// Token: 0x04000AE0 RID: 2784
			public int state;
		}

		// Token: 0x02000150 RID: 336
		[CompilerGenerated]
		private sealed class <>c__DisplayClass23_0
		{
			// Token: 0x06001619 RID: 5657 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass23_0()
			{
			}

			// Token: 0x04000AE1 RID: 2785
			public int userId;

			// Token: 0x04000AE2 RID: 2786
			public IPeriod period;
		}

		// Token: 0x02000151 RID: 337
		[CompilerGenerated]
		private sealed class <>c__DisplayClass25_0
		{
			// Token: 0x0600161A RID: 5658 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass25_0()
			{
			}

			// Token: 0x04000AE3 RID: 2787
			public int repairId;

			// Token: 0x04000AE4 RID: 2788
			public int userId;
		}

		// Token: 0x02000152 RID: 338
		[CompilerGenerated]
		private sealed class <>c__DisplayClass26_0
		{
			// Token: 0x0600161B RID: 5659 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass26_0()
			{
			}

			// Token: 0x04000AE5 RID: 2789
			public int repairId;

			// Token: 0x04000AE6 RID: 2790
			public List<int> workIds;
		}

		// Token: 0x02000153 RID: 339
		[CompilerGenerated]
		private sealed class <>c__DisplayClass27_0
		{
			// Token: 0x0600161C RID: 5660 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass27_0()
			{
			}

			// Token: 0x04000AE7 RID: 2791
			public IPeriod period;

			// Token: 0x04000AE8 RID: 2792
			public int userId;
		}
	}
}
