using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Objects;
using ASC.Options;
using ASC.Salary;
using ASC.SimpleClasses;
using DevExpress.DataProcessing;
using DevExpress.Mvvm;

namespace ASC.ViewModels.Charts
{
	// Token: 0x0200050D RID: 1293
	public class FinancesFlowReport : BindableBase, IFinancesFlowReport
	{
		// Token: 0x17000F1D RID: 3869
		// (get) Token: 0x060030BF RID: 12479 RVA: 0x000A0BCC File Offset: 0x0009EDCC
		// (set) Token: 0x060030C0 RID: 12480 RVA: 0x000A0BE0 File Offset: 0x0009EDE0
		public decimal Profit
		{
			[CompilerGenerated]
			get
			{
				return this.<Profit>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (decimal.Equals(this.<Profit>k__BackingField, value))
				{
					return;
				}
				this.<Profit>k__BackingField = value;
				this.RaisePropertyChanged("Profit");
			}
		}

		// Token: 0x17000F1E RID: 3870
		// (get) Token: 0x060030C1 RID: 12481 RVA: 0x000A0C10 File Offset: 0x0009EE10
		// (set) Token: 0x060030C2 RID: 12482 RVA: 0x000A0C24 File Offset: 0x0009EE24
		public decimal CurrentPeriodSalary
		{
			[CompilerGenerated]
			get
			{
				return this.<CurrentPeriodSalary>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (decimal.Equals(this.<CurrentPeriodSalary>k__BackingField, value))
				{
					return;
				}
				this.<CurrentPeriodSalary>k__BackingField = value;
				this.RaisePropertyChanged("CurrentPeriodSalary");
			}
		}

		// Token: 0x17000F1F RID: 3871
		// (get) Token: 0x060030C3 RID: 12483 RVA: 0x000A0C54 File Offset: 0x0009EE54
		public IFinancesFlowReportGroup Income
		{
			[CompilerGenerated]
			get
			{
				return this.<Income>k__BackingField;
			}
		}

		// Token: 0x17000F20 RID: 3872
		// (get) Token: 0x060030C4 RID: 12484 RVA: 0x000A0C68 File Offset: 0x0009EE68
		public IFinancesFlowReportGroup Outcome
		{
			[CompilerGenerated]
			get
			{
				return this.<Outcome>k__BackingField;
			}
		}

		// Token: 0x17000F21 RID: 3873
		// (get) Token: 0x060030C5 RID: 12485 RVA: 0x000A0C7C File Offset: 0x0009EE7C
		// (set) Token: 0x060030C6 RID: 12486 RVA: 0x000A0C90 File Offset: 0x0009EE90
		public ObservableCollection<IFinancesFlowReportItem> Overview
		{
			[CompilerGenerated]
			get
			{
				return this.<Overview>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(this.<Overview>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 991414228;
				IL_13:
				switch ((num ^ 1653879961) % 4)
				{
				case 0:
					IL_32:
					this.<Overview>k__BackingField = value;
					num = 1029009966;
					goto IL_13;
				case 1:
					return;
				case 2:
					goto IL_0E;
				}
				this.RaisePropertyChanged("Overview");
			}
		}

		// Token: 0x17000F22 RID: 3874
		// (get) Token: 0x060030C7 RID: 12487 RVA: 0x000A0CEC File Offset: 0x0009EEEC
		// (set) Token: 0x060030C8 RID: 12488 RVA: 0x000A0D00 File Offset: 0x0009EF00
		public ObservableCollection<IFinancesFlowReportItem> Salary
		{
			[CompilerGenerated]
			get
			{
				return this.<Salary>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Salary>k__BackingField, value))
				{
					return;
				}
				this.<Salary>k__BackingField = value;
				this.RaisePropertyChanged("Salary");
			}
		}

		// Token: 0x060030C9 RID: 12489 RVA: 0x000A0D30 File Offset: 0x0009EF30
		public FinancesFlowReport()
		{
			this.Income = new FinancesFlowReportGroup("Доходы");
			this.Outcome = new FinancesFlowReportGroup("Расходы");
			this.Overview = new ObservableCollection<IFinancesFlowReportItem>();
			this.Salary = new ObservableCollection<IFinancesFlowReportItem>();
			this._model = new SalaryModel();
		}

		// Token: 0x060030CA RID: 12490 RVA: 0x000A0D84 File Offset: 0x0009EF84
		public Task LoadData()
		{
			FinancesFlowReport.<LoadData>d__27 <LoadData>d__;
			<LoadData>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadData>d__.<>4__this = this;
			<LoadData>d__.<>1__state = -1;
			<LoadData>d__.<>t__builder.Start<FinancesFlowReport.<LoadData>d__27>(ref <LoadData>d__);
			return <LoadData>d__.<>t__builder.Task;
		}

		// Token: 0x060030CB RID: 12491 RVA: 0x000A0DC8 File Offset: 0x0009EFC8
		protected virtual void CalcProfit()
		{
			this.Profit = this.Income.Total + this.Outcome.Total;
		}

		// Token: 0x060030CC RID: 12492 RVA: 0x000A0DF8 File Offset: 0x0009EFF8
		protected virtual void CalcOverview()
		{
			FinancesFlowReportItem item = new FinancesFlowReportItem("Доходы", this.Income.Total);
			FinancesFlowReportItem item2 = new FinancesFlowReportItem(Lang.t("Costs"), Math.Abs(this.Outcome.Total));
			this.Overview.Clear();
			this.Overview.Add(item);
			this.Overview.Add(item2);
		}

		// Token: 0x060030CD RID: 12493 RVA: 0x000A0E60 File Offset: 0x0009F060
		protected virtual Task<List<IFinancesFlowReportItem>> GetCurrentPeriodSalary()
		{
			FinancesFlowReport.<GetCurrentPeriodSalary>d__30 <GetCurrentPeriodSalary>d__;
			<GetCurrentPeriodSalary>d__.<>t__builder = AsyncTaskMethodBuilder<List<IFinancesFlowReportItem>>.Create();
			<GetCurrentPeriodSalary>d__.<>4__this = this;
			<GetCurrentPeriodSalary>d__.<>1__state = -1;
			<GetCurrentPeriodSalary>d__.<>t__builder.Start<FinancesFlowReport.<GetCurrentPeriodSalary>d__30>(ref <GetCurrentPeriodSalary>d__);
			return <GetCurrentPeriodSalary>d__.<>t__builder.Task;
		}

		// Token: 0x060030CE RID: 12494 RVA: 0x000A0EA4 File Offset: 0x0009F0A4
		private Task LoadIncome()
		{
			FinancesFlowReport.<LoadIncome>d__31 <LoadIncome>d__;
			<LoadIncome>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadIncome>d__.<>4__this = this;
			<LoadIncome>d__.<>1__state = -1;
			<LoadIncome>d__.<>t__builder.Start<FinancesFlowReport.<LoadIncome>d__31>(ref <LoadIncome>d__);
			return <LoadIncome>d__.<>t__builder.Task;
		}

		// Token: 0x060030CF RID: 12495 RVA: 0x000A0EE8 File Offset: 0x0009F0E8
		protected virtual Task LoadOutcome()
		{
			FinancesFlowReport.<LoadOutcome>d__32 <LoadOutcome>d__;
			<LoadOutcome>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadOutcome>d__.<>4__this = this;
			<LoadOutcome>d__.<>1__state = -1;
			<LoadOutcome>d__.<>t__builder.Start<FinancesFlowReport.<LoadOutcome>d__32>(ref <LoadOutcome>d__);
			return <LoadOutcome>d__.<>t__builder.Task;
		}

		// Token: 0x060030D0 RID: 12496 RVA: 0x000A0F2C File Offset: 0x0009F12C
		protected Task<decimal> GetSalarySumAsync(auseceEntities ctx)
		{
			FinancesFlowReport.<GetSalarySumAsync>d__33 <GetSalarySumAsync>d__;
			<GetSalarySumAsync>d__.<>t__builder = AsyncTaskMethodBuilder<decimal>.Create();
			<GetSalarySumAsync>d__.<>4__this = this;
			<GetSalarySumAsync>d__.ctx = ctx;
			<GetSalarySumAsync>d__.<>1__state = -1;
			<GetSalarySumAsync>d__.<>t__builder.Start<FinancesFlowReport.<GetSalarySumAsync>d__33>(ref <GetSalarySumAsync>d__);
			return <GetSalarySumAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060030D1 RID: 12497 RVA: 0x000A0F78 File Offset: 0x0009F178
		private IQueryable<salary> SalaryOfficeFilter(IQueryable<salary> query)
		{
			if (this._officeId != 0)
			{
				query = from o in query
				where o.users.def_office == this._officeId
				select o;
			}
			return query;
		}

		// Token: 0x060030D2 RID: 12498 RVA: 0x000A1008 File Offset: 0x0009F208
		private IQueryable<salary> SalaryCompanyFilter(IQueryable<salary> query)
		{
			if (this._companyId != 0)
			{
				query = from o in query
				where o.users.offices1.default_company == this._companyId
				select o;
			}
			return query;
		}

		// Token: 0x060030D3 RID: 12499 RVA: 0x000A10B0 File Offset: 0x0009F2B0
		private Task<decimal> GetSalaryDebtSumAsync(auseceEntities ctx)
		{
			FinancesFlowReport.<GetSalaryDebtSumAsync>d__36 <GetSalaryDebtSumAsync>d__;
			<GetSalaryDebtSumAsync>d__.<>t__builder = AsyncTaskMethodBuilder<decimal>.Create();
			<GetSalaryDebtSumAsync>d__.<>4__this = this;
			<GetSalaryDebtSumAsync>d__.ctx = ctx;
			<GetSalaryDebtSumAsync>d__.<>1__state = -1;
			<GetSalaryDebtSumAsync>d__.<>t__builder.Start<FinancesFlowReport.<GetSalaryDebtSumAsync>d__36>(ref <GetSalaryDebtSumAsync>d__);
			return <GetSalaryDebtSumAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060030D4 RID: 12500 RVA: 0x000A10FC File Offset: 0x0009F2FC
		private Task<decimal> GetPkoSumAsync(auseceEntities ctx, int type)
		{
			FinancesFlowReport.<GetPkoSumAsync>d__37 <GetPkoSumAsync>d__;
			<GetPkoSumAsync>d__.<>t__builder = AsyncTaskMethodBuilder<decimal>.Create();
			<GetPkoSumAsync>d__.<>4__this = this;
			<GetPkoSumAsync>d__.ctx = ctx;
			<GetPkoSumAsync>d__.type = type;
			<GetPkoSumAsync>d__.<>1__state = -1;
			<GetPkoSumAsync>d__.<>t__builder.Start<FinancesFlowReport.<GetPkoSumAsync>d__37>(ref <GetPkoSumAsync>d__);
			return <GetPkoSumAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060030D5 RID: 12501 RVA: 0x000A1150 File Offset: 0x0009F350
		private IQueryable<cash_orders> OfficeFilter(IQueryable<cash_orders> query)
		{
			if (this._officeId != 0)
			{
				query = from o in query
				where o.office == this._officeId
				select o;
			}
			return query;
		}

		// Token: 0x060030D6 RID: 12502 RVA: 0x000A11CC File Offset: 0x0009F3CC
		private IQueryable<cash_orders> CompanyFilter(IQueryable<cash_orders> query)
		{
			if (this._companyId != 0)
			{
				query = from o in query
				where o.company == this._companyId
				select o;
			}
			return query;
		}

		// Token: 0x060030D7 RID: 12503 RVA: 0x000A1248 File Offset: 0x0009F448
		public Task<decimal> GetRkoSumAsync(auseceEntities ctx, int type)
		{
			FinancesFlowReport.<GetRkoSumAsync>d__40 <GetRkoSumAsync>d__;
			<GetRkoSumAsync>d__.<>t__builder = AsyncTaskMethodBuilder<decimal>.Create();
			<GetRkoSumAsync>d__.<>4__this = this;
			<GetRkoSumAsync>d__.ctx = ctx;
			<GetRkoSumAsync>d__.type = type;
			<GetRkoSumAsync>d__.<>1__state = -1;
			<GetRkoSumAsync>d__.<>t__builder.Start<FinancesFlowReport.<GetRkoSumAsync>d__40>(ref <GetRkoSumAsync>d__);
			return <GetRkoSumAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060030D8 RID: 12504 RVA: 0x000A129C File Offset: 0x0009F49C
		public void SetPeriod(IPeriod period)
		{
			this._period = period;
			this._period.From = period.From.Date;
			this._period.To = period.To.Date.AddDays(1.0).AddSeconds(-1.0);
		}

		// Token: 0x060030D9 RID: 12505 RVA: 0x000A1304 File Offset: 0x0009F504
		public void SetCompany(int companyId)
		{
			this._companyId = companyId;
		}

		// Token: 0x060030DA RID: 12506 RVA: 0x000A1318 File Offset: 0x0009F518
		public void SetOffice(int officeId)
		{
			this._officeId = officeId;
		}

		// Token: 0x04001BC5 RID: 7109
		private int _companyId;

		// Token: 0x04001BC6 RID: 7110
		private int _officeId;

		// Token: 0x04001BC7 RID: 7111
		protected IPeriod _period;

		// Token: 0x04001BC8 RID: 7112
		[CompilerGenerated]
		private decimal <Profit>k__BackingField;

		// Token: 0x04001BC9 RID: 7113
		[CompilerGenerated]
		private decimal <CurrentPeriodSalary>k__BackingField;

		// Token: 0x04001BCA RID: 7114
		[CompilerGenerated]
		private readonly IFinancesFlowReportGroup <Income>k__BackingField;

		// Token: 0x04001BCB RID: 7115
		[CompilerGenerated]
		private readonly IFinancesFlowReportGroup <Outcome>k__BackingField;

		// Token: 0x04001BCC RID: 7116
		[CompilerGenerated]
		private ObservableCollection<IFinancesFlowReportItem> <Overview>k__BackingField;

		// Token: 0x04001BCD RID: 7117
		[CompilerGenerated]
		private ObservableCollection<IFinancesFlowReportItem> <Salary>k__BackingField;

		// Token: 0x04001BCE RID: 7118
		protected SalaryModel _model;

		// Token: 0x0200050E RID: 1294
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadData>d__27 : IAsyncStateMachine
		{
			// Token: 0x060030DB RID: 12507 RVA: 0x000A132C File Offset: 0x0009F52C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				FinancesFlowReport financesFlowReport = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter<List<IFinancesFlowReportItem>> awaiter2;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_CF;
					case 2:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<List<IFinancesFlowReportItem>>);
						this.<>1__state = -1;
						goto IL_136;
					default:
						awaiter = financesFlowReport.LoadIncome().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, FinancesFlowReport.<LoadData>d__27>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					awaiter = financesFlowReport.LoadOutcome().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, FinancesFlowReport.<LoadData>d__27>(ref awaiter, ref this);
						return;
					}
					IL_CF:
					awaiter.GetResult();
					financesFlowReport.CalcProfit();
					financesFlowReport.CalcOverview();
					awaiter2 = financesFlowReport.GetCurrentPeriodSalary().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<IFinancesFlowReportItem>>, FinancesFlowReport.<LoadData>d__27>(ref awaiter2, ref this);
						return;
					}
					IL_136:
					List<IFinancesFlowReportItem> result = awaiter2.GetResult();
					financesFlowReport.Salary.Clear();
					financesFlowReport.Salary.AddRange(result);
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060030DC RID: 12508 RVA: 0x000A14D8 File Offset: 0x0009F6D8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001BCF RID: 7119
			public int <>1__state;

			// Token: 0x04001BD0 RID: 7120
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001BD1 RID: 7121
			public FinancesFlowReport <>4__this;

			// Token: 0x04001BD2 RID: 7122
			private TaskAwaiter <>u__1;

			// Token: 0x04001BD3 RID: 7123
			private TaskAwaiter<List<IFinancesFlowReportItem>> <>u__2;
		}

		// Token: 0x0200050F RID: 1295
		[CompilerGenerated]
		private sealed class <>c__DisplayClass30_0
		{
			// Token: 0x060030DD RID: 12509 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass30_0()
			{
			}

			// Token: 0x060030DE RID: 12510 RVA: 0x000A14F4 File Offset: 0x0009F6F4
			internal UserSalaryReport <GetCurrentPeriodSalary>b__1()
			{
				SalaryModel model = this.<>4__this._model;
				users user = this.employee;
				IPeriod period = this.<>4__this._period;
				int? salary_rate = this.employee.salary_rate;
				return model.LoadUserReport(user, period, (salary_rate != null) ? new decimal?(salary_rate.GetValueOrDefault()) : null);
			}

			// Token: 0x04001BD4 RID: 7124
			public users employee;

			// Token: 0x04001BD5 RID: 7125
			public FinancesFlowReport <>4__this;
		}

		// Token: 0x02000510 RID: 1296
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060030DF RID: 12511 RVA: 0x000A1554 File Offset: 0x0009F754
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060030E0 RID: 12512 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x04001BD6 RID: 7126
			public static readonly FinancesFlowReport.<>c <>9 = new FinancesFlowReport.<>c();
		}

		// Token: 0x02000511 RID: 1297
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCurrentPeriodSalary>d__30 : IAsyncStateMachine
		{
			// Token: 0x060030E1 RID: 12513 RVA: 0x000A156C File Offset: 0x0009F76C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				FinancesFlowReport financesFlowReport = this.<>4__this;
				List<IFinancesFlowReportItem> result3;
				try
				{
					if (num > 1)
					{
						this.<result>5__2 = new List<IFinancesFlowReportItem>();
						this.<ctx>5__3 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<List<users>> awaiter;
						if (num != 0)
						{
							if (num == 1)
							{
								goto IL_116;
							}
							awaiter = (from u in this.<ctx>5__3.users
							where u.state == (int?)1
							select u).ToListAsync<users>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<users>>, FinancesFlowReport.<GetCurrentPeriodSalary>d__30>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<users>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						List<users> result = awaiter.GetResult();
						this.<>7__wrap3 = result.GetEnumerator();
						IL_116:
						try
						{
							TaskAwaiter<UserSalaryReport> awaiter2;
							if (num == 1)
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<UserSalaryReport>);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
								goto IL_19F;
							}
							IL_13C:
							if (!this.<>7__wrap3.MoveNext())
							{
								goto IL_21B;
							}
							this.<>8__1 = new FinancesFlowReport.<>c__DisplayClass30_0();
							this.<>8__1.<>4__this = financesFlowReport;
							this.<>8__1.employee = this.<>7__wrap3.Current;
							awaiter2 = Task.Run<UserSalaryReport>(new Func<UserSalaryReport>(this.<>8__1.<GetCurrentPeriodSalary>b__1)).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num5 = 1;
								num = 1;
								this.<>1__state = num5;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<UserSalaryReport>, FinancesFlowReport.<GetCurrentPeriodSalary>d__30>(ref awaiter2, ref this);
								return;
							}
							IL_19F:
							UserSalaryReport result2 = awaiter2.GetResult();
							FinancesFlowReportItem item = new FinancesFlowReportItem(this.<>8__1.employee.FioShort, result2.FinalPaySumm);
							this.<result>5__2.Add(item);
							this.<>8__1 = null;
							goto IL_13C;
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)this.<>7__wrap3).Dispose();
							}
						}
						IL_21B:
						this.<>7__wrap3 = default(List<users>.Enumerator);
					}
					finally
					{
						if (num < 0 && this.<ctx>5__3 != null)
						{
							((IDisposable)this.<ctx>5__3).Dispose();
						}
					}
					this.<ctx>5__3 = null;
					result3 = this.<result>5__2;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<result>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<result>5__2 = null;
				this.<>t__builder.SetResult(result3);
			}

			// Token: 0x060030E2 RID: 12514 RVA: 0x000A1854 File Offset: 0x0009FA54
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001BD7 RID: 7127
			public int <>1__state;

			// Token: 0x04001BD8 RID: 7128
			public AsyncTaskMethodBuilder<List<IFinancesFlowReportItem>> <>t__builder;

			// Token: 0x04001BD9 RID: 7129
			public FinancesFlowReport <>4__this;

			// Token: 0x04001BDA RID: 7130
			private FinancesFlowReport.<>c__DisplayClass30_0 <>8__1;

			// Token: 0x04001BDB RID: 7131
			private List<IFinancesFlowReportItem> <result>5__2;

			// Token: 0x04001BDC RID: 7132
			private auseceEntities <ctx>5__3;

			// Token: 0x04001BDD RID: 7133
			private TaskAwaiter<List<users>> <>u__1;

			// Token: 0x04001BDE RID: 7134
			private List<users>.Enumerator <>7__wrap3;

			// Token: 0x04001BDF RID: 7135
			private TaskAwaiter<UserSalaryReport> <>u__2;
		}

		// Token: 0x02000512 RID: 1298
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadIncome>d__31 : IAsyncStateMachine
		{
			// Token: 0x060030E3 RID: 12515 RVA: 0x000A1870 File Offset: 0x0009FA70
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				FinancesFlowReport financesFlowReport = this.<>4__this;
				try
				{
					if (num > 5)
					{
						financesFlowReport.Income.ClearItems();
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<decimal> awaiter;
						switch (num)
						{
						case 0:
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<decimal>);
							int num2 = -1;
							num = -1;
							this.<>1__state = num2;
							break;
						}
						case 1:
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<decimal>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
							goto IL_12B;
						}
						case 2:
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<decimal>);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
							goto IL_1AF;
						}
						case 3:
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<decimal>);
							int num5 = -1;
							num = -1;
							this.<>1__state = num5;
							goto IL_235;
						}
						case 4:
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<decimal>);
							int num6 = -1;
							num = -1;
							this.<>1__state = num6;
							goto IL_2BB;
						}
						case 5:
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<decimal>);
							int num7 = -1;
							num = -1;
							this.<>1__state = num7;
							goto IL_341;
						}
						default:
							awaiter = financesFlowReport.GetPkoSumAsync(this.<ctx>5__2, 15).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num8 = 0;
								num = 0;
								this.<>1__state = num8;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, FinancesFlowReport.<LoadIncome>d__31>(ref awaiter, ref this);
								return;
							}
							break;
						}
						decimal result = awaiter.GetResult();
						financesFlowReport.Income.AddItem(new FinancesFlowReportItem(Lang.t("Repairs"), result, 15));
						awaiter = financesFlowReport.GetPkoSumAsync(this.<ctx>5__2, 14).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num9 = 1;
							num = 1;
							this.<>1__state = num9;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, FinancesFlowReport.<LoadIncome>d__31>(ref awaiter, ref this);
							return;
						}
						IL_12B:
						decimal result2 = awaiter.GetResult();
						financesFlowReport.Income.AddItem(new FinancesFlowReportItem(Lang.t("Sales"), result2, 14));
						awaiter = financesFlowReport.GetPkoSumAsync(this.<ctx>5__2, 13).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num10 = 2;
							num = 2;
							this.<>1__state = num10;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, FinancesFlowReport.<LoadIncome>d__31>(ref awaiter, ref this);
							return;
						}
						IL_1AF:
						decimal result3 = awaiter.GetResult();
						financesFlowReport.Income.AddItem(new FinancesFlowReportItem(Lang.t("ChargeBalance"), result3, 13));
						awaiter = financesFlowReport.GetPkoSumAsync(this.<ctx>5__2, 12).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num11 = 3;
							num = 3;
							this.<>1__state = num11;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, FinancesFlowReport.<LoadIncome>d__31>(ref awaiter, ref this);
							return;
						}
						IL_235:
						decimal result4 = awaiter.GetResult();
						financesFlowReport.Income.AddItem(new FinancesFlowReportItem(Lang.t("partsPrePayment"), result4, 12));
						awaiter = financesFlowReport.GetPkoSumAsync(this.<ctx>5__2, 17).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num12 = 4;
							num = 4;
							this.<>1__state = num12;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, FinancesFlowReport.<LoadIncome>d__31>(ref awaiter, ref this);
							return;
						}
						IL_2BB:
						decimal result5 = awaiter.GetResult();
						financesFlowReport.Income.AddItem(new FinancesFlowReportItem(Lang.t("InvoicePayment"), result5, 17));
						awaiter = financesFlowReport.GetPkoSumAsync(this.<ctx>5__2, 11).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num13 = 5;
							num = 5;
							this.<>1__state = num13;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, FinancesFlowReport.<LoadIncome>d__31>(ref awaiter, ref this);
							return;
						}
						IL_341:
						decimal result6 = awaiter.GetResult();
						financesFlowReport.Income.AddItem(new FinancesFlowReportItem(Lang.t("OtherV2"), result6, 11));
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
						}
					}
					this.<ctx>5__2 = null;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060030E4 RID: 12516 RVA: 0x000A1C68 File Offset: 0x0009FE68
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001BE0 RID: 7136
			public int <>1__state;

			// Token: 0x04001BE1 RID: 7137
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001BE2 RID: 7138
			public FinancesFlowReport <>4__this;

			// Token: 0x04001BE3 RID: 7139
			private auseceEntities <ctx>5__2;

			// Token: 0x04001BE4 RID: 7140
			private TaskAwaiter<decimal> <>u__1;
		}

		// Token: 0x02000513 RID: 1299
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadOutcome>d__32 : IAsyncStateMachine
		{
			// Token: 0x060030E5 RID: 12517 RVA: 0x000A1C84 File Offset: 0x0009FE84
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				FinancesFlowReport financesFlowReport = this.<>4__this;
				try
				{
					TaskAwaiter<List<payment_types>> awaiter;
					if (num != 0)
					{
						if (num - 1 <= 7)
						{
							goto IL_9D;
						}
						financesFlowReport.Outcome.ClearItems();
						awaiter = new OrderOptions().LoadUserPaymentTypes().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.<>1__state = num2;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<payment_types>>, FinancesFlowReport.<LoadOutcome>d__32>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<payment_types>>);
						int num3 = -1;
						num = -1;
						this.<>1__state = num3;
					}
					List<payment_types> result = awaiter.GetResult();
					this.<userTypes>5__2 = new List<IPaymentType>(result);
					this.<ctx>5__3 = new auseceEntities(true);
					IL_9D:
					try
					{
						TaskAwaiter<decimal> awaiter2;
						switch (num)
						{
						case 1:
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<decimal>);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
							break;
						}
						case 2:
							IL_15B:
							try
							{
								if (num == 2)
								{
									awaiter2 = this.<>u__2;
									this.<>u__2 = default(TaskAwaiter<decimal>);
									int num5 = -1;
									num = -1;
									this.<>1__state = num5;
									goto IL_1C9;
								}
								IL_181:
								if (!this.<>7__wrap3.MoveNext())
								{
									goto IL_242;
								}
								this.<type>5__5 = this.<>7__wrap3.Current;
								awaiter2 = financesFlowReport.GetRkoSumAsync(this.<ctx>5__3, this.<type>5__5.Id).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									int num6 = 2;
									num = 2;
									this.<>1__state = num6;
									this.<>u__2 = awaiter2;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, FinancesFlowReport.<LoadOutcome>d__32>(ref awaiter2, ref this);
									return;
								}
								IL_1C9:
								decimal result2 = awaiter2.GetResult();
								financesFlowReport.Outcome.AddItem(new FinancesFlowReportItem(this.<type>5__5.Name, result2, this.<type>5__5.Id));
								this.<type>5__5 = null;
								goto IL_181;
							}
							finally
							{
								if (num < 0)
								{
									((IDisposable)this.<>7__wrap3).Dispose();
								}
							}
							IL_242:
							this.<>7__wrap3 = default(List<IPaymentType>.Enumerator);
							awaiter2 = financesFlowReport.GetRkoSumAsync(this.<ctx>5__3, 5).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num7 = 3;
								num = 3;
								this.<>1__state = num7;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, FinancesFlowReport.<LoadOutcome>d__32>(ref awaiter2, ref this);
								return;
							}
							goto IL_2AC;
						case 3:
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<decimal>);
							int num8 = -1;
							num = -1;
							this.<>1__state = num8;
							goto IL_2AC;
						}
						case 4:
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<decimal>);
							int num9 = -1;
							num = -1;
							this.<>1__state = num9;
							goto IL_32F;
						}
						case 5:
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<decimal>);
							int num10 = -1;
							num = -1;
							this.<>1__state = num10;
							goto IL_3BB;
						}
						case 6:
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<decimal>);
							int num11 = -1;
							num = -1;
							this.<>1__state = num11;
							goto IL_448;
						}
						case 7:
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<decimal>);
							int num12 = -1;
							num = -1;
							this.<>1__state = num12;
							goto IL_4CD;
						}
						case 8:
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<decimal>);
							int num13 = -1;
							num = -1;
							this.<>1__state = num13;
							goto IL_552;
						}
						default:
							awaiter2 = financesFlowReport.GetRkoSumAsync(this.<ctx>5__3, 2).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num14 = 1;
								num = 1;
								this.<>1__state = num14;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, FinancesFlowReport.<LoadOutcome>d__32>(ref awaiter2, ref this);
								return;
							}
							break;
						}
						decimal result3 = awaiter2.GetResult();
						financesFlowReport.Outcome.AddItem(new FinancesFlowReportItem(Lang.t("PnPayment"), result3, 2));
						this.<>7__wrap3 = this.<userTypes>5__2.GetEnumerator();
						goto IL_15B;
						IL_2AC:
						decimal result4 = awaiter2.GetResult();
						financesFlowReport.Outcome.AddItem(new FinancesFlowReportItem(Lang.t("PayAdvance"), result4, 5));
						awaiter2 = financesFlowReport.GetSalarySumAsync(this.<ctx>5__3).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num15 = 4;
							num = 4;
							this.<>1__state = num15;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, FinancesFlowReport.<LoadOutcome>d__32>(ref awaiter2, ref this);
							return;
						}
						IL_32F:
						decimal num16 = awaiter2.GetResult();
						num16 = -Math.Abs(num16);
						financesFlowReport.Outcome.AddItem(new FinancesFlowReportItem("З/П за текущий период", num16, -1));
						awaiter2 = financesFlowReport.GetSalaryDebtSumAsync(this.<ctx>5__3).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num17 = 5;
							num = 5;
							this.<>1__state = num17;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, FinancesFlowReport.<LoadOutcome>d__32>(ref awaiter2, ref this);
							return;
						}
						IL_3BB:
						decimal num18 = awaiter2.GetResult();
						num18 = -Math.Abs(num18);
						financesFlowReport.Outcome.AddItem(new FinancesFlowReportItem("З/П долг", num18, -1));
						awaiter2 = financesFlowReport.GetRkoSumAsync(this.<ctx>5__3, 8).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num19 = 6;
							num = 6;
							this.<>1__state = num19;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, FinancesFlowReport.<LoadOutcome>d__32>(ref awaiter2, ref this);
							return;
						}
						IL_448:
						decimal result5 = awaiter2.GetResult();
						financesFlowReport.Outcome.AddItem(new FinancesFlowReportItem(Lang.t("RepairRefund"), result5, 8));
						awaiter2 = financesFlowReport.GetRkoSumAsync(this.<ctx>5__3, 9).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num20 = 7;
							num = 7;
							this.<>1__state = num20;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, FinancesFlowReport.<LoadOutcome>d__32>(ref awaiter2, ref this);
							return;
						}
						IL_4CD:
						decimal result6 = awaiter2.GetResult();
						financesFlowReport.Outcome.AddItem(new FinancesFlowReportItem(Lang.t("SaleRefund"), result6, 9));
						awaiter2 = financesFlowReport.GetRkoSumAsync(this.<ctx>5__3, 1).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num21 = 8;
							num = 8;
							this.<>1__state = num21;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, FinancesFlowReport.<LoadOutcome>d__32>(ref awaiter2, ref this);
							return;
						}
						IL_552:
						decimal result7 = awaiter2.GetResult();
						financesFlowReport.Outcome.AddItem(new FinancesFlowReportItem(Lang.t("OtherV2"), result7, 1));
					}
					finally
					{
						if (num < 0 && this.<ctx>5__3 != null)
						{
							((IDisposable)this.<ctx>5__3).Dispose();
						}
					}
					this.<ctx>5__3 = null;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<userTypes>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<userTypes>5__2 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060030E6 RID: 12518 RVA: 0x000A22B4 File Offset: 0x000A04B4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001BE5 RID: 7141
			public int <>1__state;

			// Token: 0x04001BE6 RID: 7142
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001BE7 RID: 7143
			public FinancesFlowReport <>4__this;

			// Token: 0x04001BE8 RID: 7144
			private List<IPaymentType> <userTypes>5__2;

			// Token: 0x04001BE9 RID: 7145
			private TaskAwaiter<List<payment_types>> <>u__1;

			// Token: 0x04001BEA RID: 7146
			private auseceEntities <ctx>5__3;

			// Token: 0x04001BEB RID: 7147
			private TaskAwaiter<decimal> <>u__2;

			// Token: 0x04001BEC RID: 7148
			private List<IPaymentType>.Enumerator <>7__wrap3;

			// Token: 0x04001BED RID: 7149
			private IPaymentType <type>5__5;
		}

		// Token: 0x02000514 RID: 1300
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetSalarySumAsync>d__33 : IAsyncStateMachine
		{
			// Token: 0x060030E7 RID: 12519 RVA: 0x000A22D0 File Offset: 0x000A04D0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				FinancesFlowReport financesFlowReport = this.<>4__this;
				decimal result;
				try
				{
					TaskAwaiter<decimal> awaiter;
					if (num != 0)
					{
						IQueryable<salary> queryable = from s in this.ctx.salary
						where s.payment_date >= financesFlowReport._period.From && s.payment_date <= financesFlowReport._period.To && s.period_from >= financesFlowReport._period.From && s.period_to <= financesFlowReport._period.To && (int)s.type == 0
						select s;
						queryable = financesFlowReport.SalaryCompanyFilter(queryable);
						queryable = financesFlowReport.SalaryOfficeFilter(queryable);
						awaiter = (from s in queryable
						select s.summ).DefaultIfEmpty<decimal>().SumAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, FinancesFlowReport.<GetSalarySumAsync>d__33>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<decimal>);
						this.<>1__state = -1;
					}
					result = awaiter.GetResult();
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

			// Token: 0x060030E8 RID: 12520 RVA: 0x000A25F0 File Offset: 0x000A07F0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001BEE RID: 7150
			public int <>1__state;

			// Token: 0x04001BEF RID: 7151
			public AsyncTaskMethodBuilder<decimal> <>t__builder;

			// Token: 0x04001BF0 RID: 7152
			public auseceEntities ctx;

			// Token: 0x04001BF1 RID: 7153
			public FinancesFlowReport <>4__this;

			// Token: 0x04001BF2 RID: 7154
			private TaskAwaiter<decimal> <>u__1;
		}

		// Token: 0x02000515 RID: 1301
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetSalaryDebtSumAsync>d__36 : IAsyncStateMachine
		{
			// Token: 0x060030E9 RID: 12521 RVA: 0x000A260C File Offset: 0x000A080C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				FinancesFlowReport financesFlowReport = this.<>4__this;
				decimal result;
				try
				{
					TaskAwaiter<decimal> awaiter;
					if (num != 0)
					{
						IQueryable<salary> queryable = from s in this.ctx.salary
						where s.payment_date >= financesFlowReport._period.From && s.payment_date <= financesFlowReport._period.To && s.period_to < financesFlowReport._period.From && (int)s.type == 0
						select s;
						queryable = financesFlowReport.SalaryCompanyFilter(queryable);
						queryable = financesFlowReport.SalaryOfficeFilter(queryable);
						awaiter = (from s in queryable
						select s.summ).DefaultIfEmpty<decimal>().SumAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, FinancesFlowReport.<GetSalaryDebtSumAsync>d__36>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<decimal>);
						this.<>1__state = -1;
					}
					result = awaiter.GetResult();
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

			// Token: 0x060030EA RID: 12522 RVA: 0x000A28CC File Offset: 0x000A0ACC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001BF3 RID: 7155
			public int <>1__state;

			// Token: 0x04001BF4 RID: 7156
			public AsyncTaskMethodBuilder<decimal> <>t__builder;

			// Token: 0x04001BF5 RID: 7157
			public auseceEntities ctx;

			// Token: 0x04001BF6 RID: 7158
			public FinancesFlowReport <>4__this;

			// Token: 0x04001BF7 RID: 7159
			private TaskAwaiter<decimal> <>u__1;
		}

		// Token: 0x02000516 RID: 1302
		[CompilerGenerated]
		private sealed class <>c__DisplayClass37_0
		{
			// Token: 0x060030EB RID: 12523 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass37_0()
			{
			}

			// Token: 0x04001BF8 RID: 7160
			public FinancesFlowReport <>4__this;

			// Token: 0x04001BF9 RID: 7161
			public int type;
		}

		// Token: 0x02000517 RID: 1303
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetPkoSumAsync>d__37 : IAsyncStateMachine
		{
			// Token: 0x060030EC RID: 12524 RVA: 0x000A28E8 File Offset: 0x000A0AE8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				FinancesFlowReport financesFlowReport = this.<>4__this;
				decimal result;
				try
				{
					TaskAwaiter<decimal> awaiter;
					if (num != 0)
					{
						FinancesFlowReport.<>c__DisplayClass37_0 CS$<>8__locals1 = new FinancesFlowReport.<>c__DisplayClass37_0();
						CS$<>8__locals1.<>4__this = this.<>4__this;
						CS$<>8__locals1.type = this.type;
						IQueryable<cash_orders> queryable = from o in this.ctx.cash_orders
						where o.created >= financesFlowReport._period.From && o.created <= financesFlowReport._period.To && o.type == CS$<>8__locals1.type && o.summa > 0m
						select o;
						queryable = financesFlowReport.CompanyFilter(queryable);
						queryable = financesFlowReport.OfficeFilter(queryable);
						awaiter = (from o in queryable
						select o.summa).DefaultIfEmpty<decimal>().SumAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, FinancesFlowReport.<GetPkoSumAsync>d__37>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<decimal>);
						this.<>1__state = -1;
					}
					result = awaiter.GetResult();
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

			// Token: 0x060030ED RID: 12525 RVA: 0x000A2B9C File Offset: 0x000A0D9C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001BFA RID: 7162
			public int <>1__state;

			// Token: 0x04001BFB RID: 7163
			public AsyncTaskMethodBuilder<decimal> <>t__builder;

			// Token: 0x04001BFC RID: 7164
			public FinancesFlowReport <>4__this;

			// Token: 0x04001BFD RID: 7165
			public int type;

			// Token: 0x04001BFE RID: 7166
			public auseceEntities ctx;

			// Token: 0x04001BFF RID: 7167
			private TaskAwaiter<decimal> <>u__1;
		}

		// Token: 0x02000518 RID: 1304
		[CompilerGenerated]
		private sealed class <>c__DisplayClass40_0
		{
			// Token: 0x060030EE RID: 12526 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass40_0()
			{
			}

			// Token: 0x04001C00 RID: 7168
			public FinancesFlowReport <>4__this;

			// Token: 0x04001C01 RID: 7169
			public int type;
		}

		// Token: 0x02000519 RID: 1305
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetRkoSumAsync>d__40 : IAsyncStateMachine
		{
			// Token: 0x060030EF RID: 12527 RVA: 0x000A2BB8 File Offset: 0x000A0DB8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				FinancesFlowReport financesFlowReport = this.<>4__this;
				decimal result;
				try
				{
					TaskAwaiter<decimal> awaiter;
					if (num != 0)
					{
						FinancesFlowReport.<>c__DisplayClass40_0 CS$<>8__locals1 = new FinancesFlowReport.<>c__DisplayClass40_0();
						CS$<>8__locals1.<>4__this = this.<>4__this;
						CS$<>8__locals1.type = this.type;
						IQueryable<cash_orders> queryable = from o in this.ctx.cash_orders
						where o.created >= financesFlowReport._period.From && o.created <= financesFlowReport._period.To && o.type == CS$<>8__locals1.type && o.summa < 0m
						select o;
						queryable = financesFlowReport.CompanyFilter(queryable);
						queryable = financesFlowReport.OfficeFilter(queryable);
						awaiter = (from o in queryable
						select o.summa).DefaultIfEmpty<decimal>().SumAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, FinancesFlowReport.<GetRkoSumAsync>d__40>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<decimal>);
						this.<>1__state = -1;
					}
					result = awaiter.GetResult();
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

			// Token: 0x060030F0 RID: 12528 RVA: 0x000A2E6C File Offset: 0x000A106C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001C02 RID: 7170
			public int <>1__state;

			// Token: 0x04001C03 RID: 7171
			public AsyncTaskMethodBuilder<decimal> <>t__builder;

			// Token: 0x04001C04 RID: 7172
			public FinancesFlowReport <>4__this;

			// Token: 0x04001C05 RID: 7173
			public int type;

			// Token: 0x04001C06 RID: 7174
			public auseceEntities ctx;

			// Token: 0x04001C07 RID: 7175
			private TaskAwaiter<decimal> <>u__1;
		}
	}
}
