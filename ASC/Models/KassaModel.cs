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
using ASC.Objects;
using ASC.Objects.Converters;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using Autofac;
using NLog;

namespace ASC.Models
{
	// Token: 0x02000ACB RID: 2763
	public class KassaModel : Kassa, IKassa
	{
		// Token: 0x17001496 RID: 5270
		// (get) Token: 0x06004E8E RID: 20110 RVA: 0x001513E4 File Offset: 0x0014F5E4
		// (set) Token: 0x06004E8F RID: 20111 RVA: 0x001513F8 File Offset: 0x0014F5F8
		public cash_orders Order
		{
			[CompilerGenerated]
			get
			{
				return this.<Order>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Order>k__BackingField = value;
			}
		}

		// Token: 0x06004E90 RID: 20112 RVA: 0x0015140C File Offset: 0x0014F60C
		public static cash_orders DefaultOrder()
		{
			Localization localization = new Localization("UTC");
			return new cash_orders
			{
				office = Auth.User.office,
				user = Auth.User.id,
				summa = 0m,
				client = new int?(0),
				created = localization.Now,
				payment_system = 0,
				is_backdate = false
			};
		}

		// Token: 0x06004E91 RID: 20113 RVA: 0x0015147C File Offset: 0x0014F67C
		public static Expression<Func<cash_orders, CashOrdersLite>> OrdersLite()
		{
			ParameterExpression parameterExpression;
			return System.Linq.Expressions.Expression.Lambda<Func<cash_orders, CashOrdersLite>>(System.Linq.Expressions.Expression.MemberInit(System.Linq.Expressions.Expression.New(typeof(CashOrdersLite)), new MemberBinding[]
			{
				System.Linq.Expressions.Expression.Bind(methodof(CashOrdersLite.set_id(int)), System.Linq.Expressions.Expression.Property(parameterExpression, methodof(cash_orders.get_id()))),
				System.Linq.Expressions.Expression.Bind(methodof(CashOrdersLite.set_CompanyId(int)), System.Linq.Expressions.Expression.Property(parameterExpression, methodof(cash_orders.get_company()))),
				System.Linq.Expressions.Expression.Bind(methodof(CashOrdersLite.set_OfficeId(int)), System.Linq.Expressions.Expression.Property(parameterExpression, methodof(cash_orders.get_office()))),
				System.Linq.Expressions.Expression.Bind(methodof(CashOrdersLite.set_OfficeName(string)), System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(cash_orders.get_offices())), methodof(offices.get_name()))),
				System.Linq.Expressions.Expression.Bind(methodof(CashOrdersLite.set_created(DateTime)), System.Linq.Expressions.Expression.Property(parameterExpression, methodof(cash_orders.get_created()))),
				System.Linq.Expressions.Expression.Bind(methodof(CashOrdersLite.set_type(int)), System.Linq.Expressions.Expression.Property(parameterExpression, methodof(cash_orders.get_type()))),
				System.Linq.Expressions.Expression.Bind(methodof(CashOrdersLite.set_ClientId(int?)), System.Linq.Expressions.Expression.Property(parameterExpression, methodof(cash_orders.get_client()))),
				System.Linq.Expressions.Expression.Bind(methodof(CashOrdersLite.set_RepairId(int?)), System.Linq.Expressions.Expression.Property(parameterExpression, methodof(cash_orders.get_repair()))),
				System.Linq.Expressions.Expression.Bind(methodof(CashOrdersLite.set_DocumentId(int?)), System.Linq.Expressions.Expression.Property(parameterExpression, methodof(cash_orders.get_document()))),
				System.Linq.Expressions.Expression.Bind(methodof(CashOrdersLite.set_ClientLastName(string)), System.Linq.Expressions.Expression.Condition(System.Linq.Expressions.Expression.Equal(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(cash_orders.get_clients())), System.Linq.Expressions.Expression.Constant(null, typeof(object))), System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(cash_orders.get_users1())), methodof(users.get_surname())), System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(cash_orders.get_clients())), methodof(clients.get_surname())))),
				System.Linq.Expressions.Expression.Bind(methodof(CashOrdersLite.set_ClientFirstName(string)), System.Linq.Expressions.Expression.Condition(System.Linq.Expressions.Expression.Equal(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(cash_orders.get_clients())), System.Linq.Expressions.Expression.Constant(null, typeof(object))), System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(cash_orders.get_users1())), methodof(users.get_name())), System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(cash_orders.get_clients())), methodof(clients.get_name())))),
				System.Linq.Expressions.Expression.Bind(methodof(CashOrdersLite.set_ClientPatronymic(string)), System.Linq.Expressions.Expression.Condition(System.Linq.Expressions.Expression.Equal(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(cash_orders.get_clients())), System.Linq.Expressions.Expression.Constant(null, typeof(object))), System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(cash_orders.get_users1())), methodof(users.get_patronymic())), System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(cash_orders.get_clients())), methodof(clients.get_patronymic())))),
				System.Linq.Expressions.Expression.Bind(methodof(CashOrdersLite.set_ClientType(int)), System.Linq.Expressions.Expression.Condition(System.Linq.Expressions.Expression.Equal(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(cash_orders.get_clients())), System.Linq.Expressions.Expression.Constant(null, typeof(object))), System.Linq.Expressions.Expression.Constant(0, typeof(int)), System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(cash_orders.get_clients())), methodof(clients.get_type())))),
				System.Linq.Expressions.Expression.Bind(methodof(CashOrdersLite.set_ClientUrName(string)), System.Linq.Expressions.Expression.Condition(System.Linq.Expressions.Expression.Equal(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(cash_orders.get_clients())), System.Linq.Expressions.Expression.Constant(null, typeof(object))), System.Linq.Expressions.Expression.Constant("", typeof(string)), System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(cash_orders.get_clients())), methodof(clients.get_ur_name())))),
				System.Linq.Expressions.Expression.Bind(methodof(CashOrdersLite.set_UserLastName(string)), System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(cash_orders.get_users())), methodof(users.get_surname()))),
				System.Linq.Expressions.Expression.Bind(methodof(CashOrdersLite.set_UserFirstName(string)), System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(cash_orders.get_users())), methodof(users.get_name()))),
				System.Linq.Expressions.Expression.Bind(methodof(CashOrdersLite.set_UserPatronymic(string)), System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(cash_orders.get_users())), methodof(users.get_patronymic()))),
				System.Linq.Expressions.Expression.Bind(methodof(CashOrdersLite.set_username(string)), System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(cash_orders.get_users())), methodof(users.get_username()))),
				System.Linq.Expressions.Expression.Bind(methodof(CashOrdersLite.set_notes(string)), System.Linq.Expressions.Expression.Property(parameterExpression, methodof(cash_orders.get_notes()))),
				System.Linq.Expressions.Expression.Bind(methodof(CashOrdersLite.set_payment_system(int)), System.Linq.Expressions.Expression.Property(parameterExpression, methodof(cash_orders.get_payment_system()))),
				System.Linq.Expressions.Expression.Bind(methodof(CashOrdersLite.set_summa(decimal)), System.Linq.Expressions.Expression.Property(parameterExpression, methodof(cash_orders.get_summa()))),
				System.Linq.Expressions.Expression.Bind(methodof(CashOrdersLite.set_IsBackDate(bool)), System.Linq.Expressions.Expression.Property(parameterExpression, methodof(cash_orders.get_is_backdate()))),
				System.Linq.Expressions.Expression.Bind(methodof(CashOrdersLite.set_InvoiceId(int?)), System.Linq.Expressions.Expression.Property(parameterExpression, methodof(cash_orders.get_invoice())))
			}), new ParameterExpression[]
			{
				parameterExpression
			});
		}

		// Token: 0x06004E92 RID: 20114 RVA: 0x00151B24 File Offset: 0x0014FD24
		public static Task<cash_orders> GetOrder(int orderId)
		{
			KassaModel.<GetOrder>d__8 <GetOrder>d__;
			<GetOrder>d__.<>t__builder = AsyncTaskMethodBuilder<cash_orders>.Create();
			<GetOrder>d__.orderId = orderId;
			<GetOrder>d__.<>1__state = -1;
			<GetOrder>d__.<>t__builder.Start<KassaModel.<GetOrder>d__8>(ref <GetOrder>d__);
			return <GetOrder>d__.<>t__builder.Task;
		}

		// Token: 0x06004E93 RID: 20115 RVA: 0x00151B68 File Offset: 0x0014FD68
		public static Task<CashInOrder> GetCashInOrder(int orderId)
		{
			KassaModel.<GetCashInOrder>d__9 <GetCashInOrder>d__;
			<GetCashInOrder>d__.<>t__builder = AsyncTaskMethodBuilder<CashInOrder>.Create();
			<GetCashInOrder>d__.orderId = orderId;
			<GetCashInOrder>d__.<>1__state = -1;
			<GetCashInOrder>d__.<>t__builder.Start<KassaModel.<GetCashInOrder>d__9>(ref <GetCashInOrder>d__);
			return <GetCashInOrder>d__.<>t__builder.Task;
		}

		// Token: 0x06004E94 RID: 20116 RVA: 0x00151BAC File Offset: 0x0014FDAC
		public static Task<CashOutOrder> GetCashOutOrder(int orderId)
		{
			KassaModel.<GetCashOutOrder>d__10 <GetCashOutOrder>d__;
			<GetCashOutOrder>d__.<>t__builder = AsyncTaskMethodBuilder<CashOutOrder>.Create();
			<GetCashOutOrder>d__.orderId = orderId;
			<GetCashOutOrder>d__.<>1__state = -1;
			<GetCashOutOrder>d__.<>t__builder.Start<KassaModel.<GetCashOutOrder>d__10>(ref <GetCashOutOrder>d__);
			return <GetCashOutOrder>d__.<>t__builder.Task;
		}

		// Token: 0x06004E95 RID: 20117 RVA: 0x00151BF0 File Offset: 0x0014FDF0
		public void NewCashOrder()
		{
			this.Order = KassaModel.DefaultOrder();
		}

		// Token: 0x06004E96 RID: 20118 RVA: 0x00151C08 File Offset: 0x0014FE08
		public void NewCashOrder(Kassa.Types type)
		{
			this.Order = KassaModel.DefaultOrder();
			this.Order.type = (int)type;
		}

		// Token: 0x06004E97 RID: 20119 RVA: 0x00151C2C File Offset: 0x0014FE2C
		public void NewCashOrder(docs document, int type, int? clientId = null, bool autocomplete = true)
		{
			this.Order = KassaModel.DefaultOrder();
			this.Order.company = document.company;
			this.Order.type = type;
			this.Order.summa = document.total;
			this.Order.document = new int?(document.id);
			cash_orders order = this.Order;
			int? num = clientId;
			order.client = ((num != null) ? num : document.dealer);
			this.Autocomplete(autocomplete);
			this.SetPaymentSystem(document.payment_system);
		}

		// Token: 0x06004E98 RID: 20120 RVA: 0x00151CBC File Offset: 0x0014FEBC
		public void NewCashOrder(int type, int clientId, decimal summa, int? repairId = null)
		{
			this.Order = KassaModel.DefaultOrder();
			this.Order.company = Auth.User.offices1.default_company;
			this.Order.type = type;
			this.Order.summa = summa;
			this.Order.client = new int?(clientId);
			this.Order.repair = repairId;
			this.Autocomplete(true);
		}

		// Token: 0x06004E99 RID: 20121 RVA: 0x00151D2C File Offset: 0x0014FF2C
		public void SetPaymentSystem(int systemId)
		{
			this.Order.payment_system = systemId;
			if (OfflineData.Instance.Employee.Pinpad != null && this.Order.payment_system == -1 && OfflineData.Instance.Employee.Pinpad.Fee > 0.0)
			{
				decimal num = this.Order.summa / 100m * (decimal)OfflineData.Instance.Employee.Pinpad.Fee;
				this.Order.summa = this.Order.summa - num;
				this.Order.card_fee = num;
			}
		}

		// Token: 0x06004E9A RID: 20122 RVA: 0x00151DE4 File Offset: 0x0014FFE4
		public Task Widthraw(int officeId, int toUserId, int paymentSystemId, decimal summa)
		{
			KassaModel.<Widthraw>d__16 <Widthraw>d__;
			<Widthraw>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Widthraw>d__.<>4__this = this;
			<Widthraw>d__.officeId = officeId;
			<Widthraw>d__.toUserId = toUserId;
			<Widthraw>d__.paymentSystemId = paymentSystemId;
			<Widthraw>d__.summa = summa;
			<Widthraw>d__.<>1__state = -1;
			<Widthraw>d__.<>t__builder.Start<KassaModel.<Widthraw>d__16>(ref <Widthraw>d__);
			return <Widthraw>d__.<>t__builder.Task;
		}

		// Token: 0x06004E9B RID: 20123 RVA: 0x00151E48 File Offset: 0x00150048
		public void NewCashOrder(workshop repair, decimal totalSumm)
		{
			this.Order = KassaModel.DefaultOrder();
			this.Order.company = Auth.User.offices1.default_company;
			this.Order.type = 15;
			this.Order.summa = totalSumm;
			this.Order.client = new int?(repair.client);
			this.Order.repair = new int?(repair.id);
			this.Autocomplete(true);
			this.SetPaymentSystem(repair.payment_system);
		}

		// Token: 0x06004E9C RID: 20124 RVA: 0x00151ED4 File Offset: 0x001500D4
		public int GetOrderId()
		{
			return this.Order.id;
		}

		// Token: 0x06004E9D RID: 20125 RVA: 0x00151EEC File Offset: 0x001500EC
		public void SetOrderCompany(int companyId)
		{
			this.Order.company = companyId;
		}

		// Token: 0x06004E9E RID: 20126 RVA: 0x00151F08 File Offset: 0x00150108
		public void SetOrderClient(int clientId)
		{
			this.Order.client = new int?(clientId);
		}

		// Token: 0x06004E9F RID: 20127 RVA: 0x00151F28 File Offset: 0x00150128
		private static void SetRnPayed(auseceEntities ctx, int documentId, int cashOrderId)
		{
			docs docs = ctx.docs.Find(new object[]
			{
				documentId
			});
			if (docs != null)
			{
				docs.order_id = new int?(cashOrderId);
				docs.state = new int?(5);
				ctx.SaveChanges();
				return;
			}
		}

		// Token: 0x06004EA0 RID: 20128 RVA: 0x00151F74 File Offset: 0x00150174
		public Task<int> SalaryPay(int userId, decimal summ, int paymentOption, DateTime date)
		{
			KassaModel.<SalaryPay>d__22 <SalaryPay>d__;
			<SalaryPay>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<SalaryPay>d__.<>4__this = this;
			<SalaryPay>d__.userId = userId;
			<SalaryPay>d__.summ = summ;
			<SalaryPay>d__.paymentOption = paymentOption;
			<SalaryPay>d__.date = date;
			<SalaryPay>d__.<>1__state = -1;
			<SalaryPay>d__.<>t__builder.Start<KassaModel.<SalaryPay>d__22>(ref <SalaryPay>d__);
			return <SalaryPay>d__.<>t__builder.Task;
		}

		// Token: 0x06004EA1 RID: 20129 RVA: 0x00151FD8 File Offset: 0x001501D8
		private void InvertOrderSumma()
		{
			this.Order.summa = -this.Order.summa;
		}

		// Token: 0x06004EA2 RID: 20130 RVA: 0x00152000 File Offset: 0x00150200
		public void MakeRko()
		{
			this.SetSummaString();
			this.Order.summa = Math.Abs(this.Order.summa);
			decimal summa = this.Order.summa;
			this.InvertOrderSumma();
			try
			{
				HistoryV2 historyV = new HistoryV2();
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					auseceEntities.cash_orders.Attach(this.Order);
					auseceEntities.Entry<cash_orders>(this.Order).State = EntityState.Added;
					auseceEntities.SaveChanges();
					if (this.Order.type == 4)
					{
						KassaModel.SubstractCustomerBalance(this.Order.client.Value, this.Order.summa, Kassa.Balance.SubstractBalance, null, 0);
						historyV.AddClientLog("PayFromBalance", this.Order.client.GetValueOrDefault(), summa, 0);
					}
					if (this.Order.type == 2 && this.Order.document != null)
					{
						auseceEntities.docs.Find(new object[]
						{
							this.Order.document
						}).order_id = new int?(this.Order.id);
						auseceEntities.SaveChanges();
					}
					historyV.AddKassaLog(this.Order);
					historyV.Save();
				}
			}
			catch (Exception exception)
			{
				KassaModel.Log.Error(exception, "Make Rko fail");
			}
		}

		// Token: 0x06004EA3 RID: 20131 RVA: 0x001521A4 File Offset: 0x001503A4
		public int MakeRko(auseceEntities ctx, HistoryV2 history, bool isSaleViaBalance = false, int dealerPaymentId = 0)
		{
			this.SetSummaString();
			decimal summa = this.Order.summa;
			this.InvertOrderSumma();
			ctx.cash_orders.Add(this.Order);
			ctx.SaveChanges();
			if (this.Order.type == 4)
			{
				if (isSaleViaBalance)
				{
					KassaModel.SetRnPayed(ctx, this.Order.document.Value, this.Order.id);
				}
				KassaModel.SubstractCustomerBalance(this.Order.client.Value, this.Order.summa, Kassa.Balance.SubstractBalance, null, dealerPaymentId);
				history.AddClientLog("PayFromBalance", this.Order.client.GetValueOrDefault(), summa, 0);
			}
			history.AddKassaLog(this.Order);
			return this.Order.id;
		}

		// Token: 0x06004EA4 RID: 20132 RVA: 0x00152280 File Offset: 0x00150480
		[Obsolete("Use CreateCashInOrder")]
		public void MakePko(bool forNewRepair = false)
		{
			this.SetSummaString();
			try
			{
				HistoryV2 historyV = new HistoryV2();
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					auseceEntities.cash_orders.Attach(this.Order);
					auseceEntities.Entry<cash_orders>(this.Order).State = EntityState.Added;
					auseceEntities.SaveChanges();
					if (this.Order.type == 13)
					{
						KassaModel.ChargeCustomerBalance(this.Order.client.Value, this.Order.summa, Kassa.Balance.ChargeBalance, this.Order.repair);
						historyV.AddClientLog("filllUpBalance", this.Order.client.GetValueOrDefault(), this.Order.summa, 0);
					}
					if (this.Order.type == 14)
					{
						KassaModel.SetRnPayed(auseceEntities, this.Order.document.Value, this.Order.id);
					}
					if (this.Order.type == 15)
					{
						if (this.Order.repair != null)
						{
							KassaModel.CloseRepairDebt(this.Order.repair.Value, this.Order.summa);
						}
					}
					if (this.Order.type == 12)
					{
						if (!forNewRepair && this.Order.repair != null)
						{
							KassaModel.UpdateRepairPrepaidSumm(auseceEntities, this.Order.repair.Value, this.Order.summa);
						}
					}
					historyV.AddKassaLog(this.Order);
					historyV.Save();
				}
			}
			catch (Exception exception)
			{
				KassaModel.Log.Error(exception, "Make Pko fail");
			}
		}

		// Token: 0x06004EA5 RID: 20133 RVA: 0x00152464 File Offset: 0x00150664
		public static void CloseRepairDebt(int repairId, decimal summ)
		{
			KassaModel.<CloseRepairDebt>d__27 <CloseRepairDebt>d__;
			<CloseRepairDebt>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<CloseRepairDebt>d__.repairId = repairId;
			<CloseRepairDebt>d__.summ = summ;
			<CloseRepairDebt>d__.<>1__state = -1;
			<CloseRepairDebt>d__.<>t__builder.Start<KassaModel.<CloseRepairDebt>d__27>(ref <CloseRepairDebt>d__);
		}

		// Token: 0x06004EA6 RID: 20134 RVA: 0x001524A4 File Offset: 0x001506A4
		public static bool SubstractCustomerBalance(int clientId, decimal summ, Kassa.Balance reason, int? documentOrRepairId, int dealerPaymentId = 0)
		{
			summ = Math.Abs(summ);
			bool result;
			try
			{
				Localization localization = new Localization("UTC");
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					auseceEntities.Configuration.ValidateOnSaveEnabled = false;
					using (DbContextTransaction dbContextTransaction = auseceEntities.Database.BeginTransaction())
					{
						try
						{
							auseceEntities.clients.Find(new object[]
							{
								clientId
							}).balance -= summ;
							auseceEntities.SaveChanges();
							balance balance = new balance
							{
								client = clientId,
								summ = -summ,
								direction = false,
								created = localization.Now,
								office = Auth.User.office,
								uid = Auth.User.id,
								reason = KassaModel.GetBalanceChangeReason(reason, documentOrRepairId)
							};
							if (dealerPaymentId != 0)
							{
								balance.dealer_payment = new int?(dealerPaymentId);
							}
							auseceEntities.balance.Add(balance);
							auseceEntities.SaveChanges();
							dbContextTransaction.Commit();
							result = true;
						}
						catch (Exception exception)
						{
							KassaModel.Log.Error(exception, "Substract Customer Balance fail, transaction rollback");
							dbContextTransaction.Rollback();
							result = false;
						}
					}
				}
			}
			catch (Exception exception2)
			{
				KassaModel.Log.Error(exception2, "Substract client balance fail");
				result = false;
			}
			return result;
		}

		// Token: 0x06004EA7 RID: 20135 RVA: 0x00152650 File Offset: 0x00150850
		private static bool ChargeCustomerBalance(int clientId, decimal summ, Kassa.Balance reason, int? positionId)
		{
			summ = Math.Abs(summ);
			bool result;
			try
			{
				Localization localization = new Localization("UTC");
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					using (DbContextTransaction dbContextTransaction = auseceEntities.Database.BeginTransaction())
					{
						try
						{
							clients clients = auseceEntities.clients.Find(new object[]
							{
								clientId
							});
							if (clients == null)
							{
								result = false;
							}
							else
							{
								clients.balance += summ;
								auseceEntities.SaveChanges();
								auseceEntities.balance.Add(new balance
								{
									client = clientId,
									summ = summ,
									direction = true,
									created = localization.Now,
									office = Auth.User.office,
									uid = Auth.User.id,
									reason = KassaModel.GetBalanceChangeReason(reason, positionId)
								});
								auseceEntities.SaveChanges();
								dbContextTransaction.Commit();
								result = true;
							}
						}
						catch (Exception exception)
						{
							KassaModel.Log.Error(exception, "Charge client balance fail, transaction rollback");
							dbContextTransaction.Rollback();
							result = false;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ILogger log = KassaModel.Log;
				string str = "Charge client balance error ";
				Exception ex2 = ex;
				log.Error(str + ((ex2 != null) ? ex2.ToString() : null));
				result = false;
			}
			return result;
		}

		// Token: 0x06004EA8 RID: 20136 RVA: 0x001527F4 File Offset: 0x001509F4
		private static string GetBalanceChangeReason(Kassa.Balance reasonId, int? id)
		{
			switch (reasonId)
			{
			case Kassa.Balance.RepairDebtOpen:
				return string.Format((string)Application.Current.TryFindResource("RepairDebtOpen"), id);
			case Kassa.Balance.RepairDebtClose:
				return string.Format((string)Application.Current.TryFindResource("RepairDebtClose"), id);
			case Kassa.Balance.ChargeBalance:
				return (string)Application.Current.TryFindResource("ChargeBalance");
			case Kassa.Balance.SubstractBalance:
				return (string)Application.Current.TryFindResource("SubstractBalance");
			case Kassa.Balance.RealizSale:
				return string.Format((string)Application.Current.TryFindResource("RealizSaleBalance"), id);
			case Kassa.Balance.ItemsSale:
				return string.Format((string)Application.Current.TryFindResource("ItemsSaleBalance"), id);
			case Kassa.Balance.RepairFromBalance:
				return string.Format((string)Application.Current.TryFindResource("RepairFromBalance"), id);
			case Kassa.Balance.CancellRn:
				return string.Format((string)Application.Current.TryFindResource("CancelRnBalance"), id);
			default:
				return string.Empty;
			}
		}

		// Token: 0x06004EA9 RID: 20137 RVA: 0x00152918 File Offset: 0x00150B18
		private static void UpdateRepairPrepaidSumm(auseceEntities ctx, int repairId, decimal summ)
		{
			workshop workshop = ctx.workshop.Find(new object[]
			{
				repairId
			});
			if (workshop == null)
			{
				return;
			}
			workshop.is_prepaid = true;
			workshop.prepaid_summ += summ;
			ctx.SaveChanges();
		}

		// Token: 0x06004EAA RID: 20138 RVA: 0x00152964 File Offset: 0x00150B64
		public void Autocomplete(bool autocomplete)
		{
			if (this.Order != null && this.Order.id <= 0)
			{
				this.Order.notes = this.Autocomplete(autocomplete, this.Order.type);
				return;
			}
		}

		// Token: 0x06004EAB RID: 20139 RVA: 0x001529A8 File Offset: 0x00150BA8
		public void Autocomplete(bool autocomplete, IPaymentType type)
		{
			if (this.Order == null)
			{
				return;
			}
			string text = this.Autocomplete(autocomplete, type.Id);
			if (string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(type.Reason))
			{
				text = string.Format(Lang.t("RkoReason1"), this.Order.summa, Auth.CurrencyModel.SelectedCurrency.ShortName + ", " + type.Reason);
			}
			this.Order.notes = text;
		}

		// Token: 0x06004EAC RID: 20140 RVA: 0x00152A2C File Offset: 0x00150C2C
		public string Autocomplete(bool autocompleteEnable, int orderType)
		{
			string shortName = Auth.CurrencyModel.SelectedCurrency.ShortName;
			uint num;
			switch (orderType)
			{
			case 1:
				IL_11C:
				num = ((!autocompleteEnable) ? 3879634053U : 2150671768U);
				break;
			case 2:
				IL_3B5:
				return string.Format(this.Resource("RkoReason2"), this.Order.document, Math.Abs(this.Order.summa), shortName);
			case 3:
				IL_BB:
				num = (autocompleteEnable ? 2241948023U : 2800311955U);
				break;
			case 4:
				IL_471:
				return string.Format(this.Resource("RkoReason4"), Math.Abs(this.Order.summa), shortName);
			case 5:
				IL_3EC:
				return string.Format(this.Resource("RkoReason5"), Math.Abs(this.Order.summa), shortName);
			case 6:
				IL_388:
				return string.Format(this.Resource("RkoReason6"), Math.Abs(this.Order.summa), shortName);
			case 7:
			case 10:
			case 18:
			case 19:
				IL_574:
				return "";
			case 8:
				IL_243:
				return string.Format(this.Resource("RkoReason8"), Math.Abs(this.Order.summa), shortName, this.Order.repair);
			case 9:
				IL_147:
				num = ((!autocompleteEnable) ? 3115929559U : 2226622672U);
				break;
			case 11:
				IL_100:
				num = ((!autocompleteEnable) ? 3938521249U : 3647794307U);
				break;
			case 12:
				IL_34B:
				return string.Format(this.Resource("PkoReason12"), this.Order.repair, Math.Abs(this.Order.summa), shortName);
			case 13:
				IL_7D:
				num = ((!autocompleteEnable) ? 2970632350U : 2242515528U);
				break;
			case 14:
				IL_DA:
				num = ((!autocompleteEnable) ? 2728017685U : 3717290237U);
				break;
			case 15:
				IL_9C:
				num = (autocompleteEnable ? 2430514164U : 3606420704U);
				break;
			case 16:
				IL_163:
				num = ((!autocompleteEnable) ? 3187680443U : 3408228062U);
				break;
			case 17:
				IL_235:
				num = ((!autocompleteEnable) ? 2463157915U : 4257113927U);
				break;
			case 20:
				IL_57A:
				return string.Format(this.Resource("RkoReason20"), Math.Abs(this.Order.summa), shortName);
			default:
				goto IL_F9;
			}
			for (;;)
			{
				IL_17D:
				uint num2;
				switch ((num2 = (num ^ 2482011952U)) % 37U)
				{
				case 0U:
					goto IL_23D;
				case 1U:
					goto IL_243;
				case 2U:
					goto IL_27A;
				case 3U:
					goto IL_2BB;
				case 4U:
					goto IL_235;
				case 5U:
					goto IL_2C1;
				case 6U:
					goto IL_2C7;
				case 7U:
					goto IL_163;
				case 8U:
					goto IL_147;
				case 9U:
					goto IL_2FE;
				case 10U:
					goto IL_33F;
				case 11U:
					num = (num2 * 1946023207U ^ 4117754698U);
					continue;
				case 12U:
					goto IL_345;
				case 13U:
					goto IL_34B;
				case 15U:
					goto IL_57A;
				case 16U:
					goto IL_11C;
				case 17U:
					goto IL_382;
				case 18U:
					goto IL_100;
				case 19U:
					goto IL_388;
				case 20U:
					goto IL_3AF;
				case 21U:
					goto IL_F9;
				case 22U:
					goto IL_3B5;
				case 23U:
					goto IL_3EC;
				case 24U:
					goto IL_413;
				case 25U:
					goto IL_DA;
				case 26U:
					goto IL_44A;
				case 27U:
					goto IL_471;
				case 28U:
					goto IL_498;
				case 29U:
					goto IL_4D9;
				case 30U:
					goto IL_BB;
				case 31U:
					goto IL_500;
				case 32U:
					goto IL_506;
				case 33U:
					goto IL_9C;
				case 34U:
					goto IL_52D;
				case 35U:
					goto IL_7D;
				case 36U:
					goto IL_533;
				}
				break;
			}
			goto IL_574;
			IL_23D:
			return "";
			IL_27A:
			return string.Format(this.Resource("PkoReason14"), Math.Abs(this.Order.summa), shortName, string.Format("{0:D6}", this.Order.document));
			IL_2BB:
			return "";
			IL_2C1:
			return "";
			IL_2C7:
			return string.Format(this.Resource("RkoReason9"), Math.Abs(this.Order.summa), shortName, this.Order.document);
			IL_2FE:
			return string.Format(this.Resource("PkoReason13"), Math.Abs(this.Order.summa), shortName, string.Format("{0:D6}", this.Order.client));
			IL_33F:
			return "";
			IL_345:
			return "";
			IL_382:
			return "";
			IL_3AF:
			return "";
			IL_413:
			return string.Format(this.Resource("RkoReason16"), Math.Abs(this.Order.summa), shortName, this.Order.document);
			IL_44A:
			return string.Format(this.Resource("RkoReason1"), Math.Abs(this.Order.summa), shortName);
			IL_498:
			return string.Format(this.Resource("PkoReason15"), Math.Abs(this.Order.summa), shortName, string.Format("{0:D6}", this.Order.repair));
			IL_4D9:
			return string.Format(this.Resource("RkoReason3"), Math.Abs(this.Order.summa), shortName);
			IL_500:
			return "";
			IL_506:
			return string.Format(this.Resource("PkoReason11"), Math.Abs(this.Order.summa), shortName);
			IL_52D:
			return "";
			IL_533:
			return string.Format(this.Resource("PkoReason17"), Math.Abs(this.Order.summa), shortName, string.Format("{0:D6}", this.Order.invoice));
			IL_F9:
			num = 4161716971U;
			goto IL_17D;
		}

		// Token: 0x06004EAD RID: 20141 RVA: 0x00152FDC File Offset: 0x001511DC
		public void Autocomplete(IInvoice document)
		{
			string shortName = Auth.CurrencyModel.SelectedCurrency.ShortName;
			for (;;)
			{
				IL_72:
				int num = -985119032;
				for (;;)
				{
					switch ((num ^ -841920747) % 3)
					{
					case 1:
						this.Order.notes = string.Format(this.Resource("PkoReason17"), Math.Abs(this.Order.summa), shortName, document.Num ?? "");
						num = -525548326;
						continue;
					case 2:
						goto IL_72;
					}
					return;
				}
			}
		}

		// Token: 0x06004EAE RID: 20142 RVA: 0x00106854 File Offset: 0x00104A54
		private string Resource(string resource)
		{
			return (string)Application.Current.TryFindResource(resource);
		}

		// Token: 0x06004EAF RID: 20143 RVA: 0x00153064 File Offset: 0x00151264
		public void FillOrderFromDoc(DocsList d)
		{
			this.Order.document = new int?(d.id);
			this.Order.summa = d.total;
			this.Order.client = d.dealer;
		}

		// Token: 0x06004EB0 RID: 20144 RVA: 0x001530AC File Offset: 0x001512AC
		private void SetSummaString()
		{
			if (!(this.Order.card_fee > 0m))
			{
				goto IL_60;
			}
			decimal num = this.Order.summa + this.Order.card_fee;
			IL_3F:
			decimal summ = num;
			int num2 = 1183495927;
			IL_45:
			switch ((num2 ^ 1123042701) % 3)
			{
			case 0:
				IL_60:
				num2 = 1955862024;
				goto IL_45;
			case 1:
				num = this.Order.summa;
				goto IL_3F;
			}
			this.Order.summa_str = ConvertersStack.SummToString(summ, Auth.Config.currency);
		}

		// Token: 0x06004EB1 RID: 20145 RVA: 0x0015313C File Offset: 0x0015133C
		public void RealizatorItems2Balance(store_items item, HistoryV2 history)
		{
			decimal num = 0m;
			if (item.is_realization && item.in_price > 0m)
			{
				num = item.in_price * item.BuyCount;
			}
			if (item.is_realization && item.in_price == 0m)
			{
				num = item.BuyCost / 100m * item.return_percent * item.BuyCount;
			}
			if (num > 0m)
			{
				KassaModel.ChargeCustomerBalance(item.dealer, num, Kassa.Balance.RealizSale, new int?(item.id));
				history.AddClientLog("balancePlus", item.dealer, num, 0);
			}
		}

		// Token: 0x06004EB2 RID: 20146 RVA: 0x00153208 File Offset: 0x00151408
		public int AdvancePay(auseceEntities ctx, int userId, decimal summ, int paymentOption, DateTime date)
		{
			this.Order = KassaModel.DefaultOrder();
			this.Order.company = Auth.User.offices1.default_company;
			this.Order.client = null;
			this.Order.type = 5;
			this.Order.summa = summ;
			this.Order.to_user = new int?(userId);
			this.Order.payment_system = paymentOption;
			this.Order.created = date;
			this.Autocomplete(true);
			this.SetSummaString();
			decimal summa = this.Order.summa;
			this.InvertOrderSumma();
			int id;
			try
			{
				HistoryV2 historyV = new HistoryV2();
				ctx.cash_orders.Attach(this.Order);
				ctx.Entry<cash_orders>(this.Order).State = EntityState.Added;
				historyV.AddUserLog("advancePay", userId, new string[]
				{
					summa.ToString("N2")
				});
				ctx.SaveChanges();
				historyV.Save();
				id = this.Order.id;
			}
			catch (Exception exception)
			{
				KassaModel.Log.Error(exception, "Advance pay fail");
				throw;
			}
			return id;
		}

		// Token: 0x06004EB3 RID: 20147 RVA: 0x0015333C File Offset: 0x0015153C
		public override bool IsUserTypeRko(int type)
		{
			bool result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					result = ((from t in auseceEntities.payment_types
					where t.id == type - 50
					select t.type).FirstOrDefault<int>() == 1);
				}
			}
			catch (Exception exception)
			{
				KassaModel.Log.Error(exception, "Detect type of user type fail");
				result = false;
			}
			return result;
		}

		// Token: 0x06004EB4 RID: 20148 RVA: 0x00153468 File Offset: 0x00151668
		public override Task<int> MakePko(IInvoice invoice)
		{
			KassaModel.<MakePko>d__42 <MakePko>d__;
			<MakePko>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<MakePko>d__.<>4__this = this;
			<MakePko>d__.invoice = invoice;
			<MakePko>d__.<>1__state = -1;
			<MakePko>d__.<>t__builder.Start<KassaModel.<MakePko>d__42>(ref <MakePko>d__);
			return <MakePko>d__.<>t__builder.Task;
		}

		// Token: 0x06004EB5 RID: 20149 RVA: 0x001534B4 File Offset: 0x001516B4
		public override Dictionary<int, string> GetWithdrawModes()
		{
			return new Dictionary<int, string>
			{
				{
					0,
					Lang.t("WithdrawFunds")
				},
				{
					1,
					Lang.t("DepositFunds")
				}
			};
		}

		// Token: 0x06004EB6 RID: 20150 RVA: 0x001534E8 File Offset: 0x001516E8
		public static Task<IEnumerable<payment_systems>> LoadPaymentSystems(bool showArchive = false)
		{
			KassaModel.<LoadPaymentSystems>d__44 <LoadPaymentSystems>d__;
			<LoadPaymentSystems>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<payment_systems>>.Create();
			<LoadPaymentSystems>d__.showArchive = showArchive;
			<LoadPaymentSystems>d__.<>1__state = -1;
			<LoadPaymentSystems>d__.<>t__builder.Start<KassaModel.<LoadPaymentSystems>d__44>(ref <LoadPaymentSystems>d__);
			return <LoadPaymentSystems>d__.<>t__builder.Task;
		}

		// Token: 0x06004EB7 RID: 20151 RVA: 0x0015352C File Offset: 0x0015172C
		public static Task<IEnumerable<kkt>> GetAllKkt()
		{
			KassaModel.<GetAllKkt>d__45 <GetAllKkt>d__;
			<GetAllKkt>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<kkt>>.Create();
			<GetAllKkt>d__.<>1__state = -1;
			<GetAllKkt>d__.<>t__builder.Start<KassaModel.<GetAllKkt>d__45>(ref <GetAllKkt>d__);
			return <GetAllKkt>d__.<>t__builder.Task;
		}

		// Token: 0x06004EB8 RID: 20152 RVA: 0x00153568 File Offset: 0x00151768
		public static Task<IEnumerable<pinpad>> GetAllPinpads()
		{
			KassaModel.<GetAllPinpads>d__46 <GetAllPinpads>d__;
			<GetAllPinpads>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<pinpad>>.Create();
			<GetAllPinpads>d__.<>1__state = -1;
			<GetAllPinpads>d__.<>t__builder.Start<KassaModel.<GetAllPinpads>d__46>(ref <GetAllPinpads>d__);
			return <GetAllPinpads>d__.<>t__builder.Task;
		}

		// Token: 0x06004EB9 RID: 20153 RVA: 0x001535A4 File Offset: 0x001517A4
		public static Task<bool> UpdateKkt(kkt i)
		{
			KassaModel.<UpdateKkt>d__47 <UpdateKkt>d__;
			<UpdateKkt>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<UpdateKkt>d__.i = i;
			<UpdateKkt>d__.<>1__state = -1;
			<UpdateKkt>d__.<>t__builder.Start<KassaModel.<UpdateKkt>d__47>(ref <UpdateKkt>d__);
			return <UpdateKkt>d__.<>t__builder.Task;
		}

		// Token: 0x06004EBA RID: 20154 RVA: 0x001535E8 File Offset: 0x001517E8
		public static Task<bool> CreateKkt(kkt i)
		{
			KassaModel.<CreateKkt>d__48 <CreateKkt>d__;
			<CreateKkt>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<CreateKkt>d__.i = i;
			<CreateKkt>d__.<>1__state = -1;
			<CreateKkt>d__.<>t__builder.Start<KassaModel.<CreateKkt>d__48>(ref <CreateKkt>d__);
			return <CreateKkt>d__.<>t__builder.Task;
		}

		// Token: 0x06004EBB RID: 20155 RVA: 0x0015362C File Offset: 0x0015182C
		public static Task<bool> DeleteKkt(kkt i)
		{
			KassaModel.<DeleteKkt>d__49 <DeleteKkt>d__;
			<DeleteKkt>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<DeleteKkt>d__.i = i;
			<DeleteKkt>d__.<>1__state = -1;
			<DeleteKkt>d__.<>t__builder.Start<KassaModel.<DeleteKkt>d__49>(ref <DeleteKkt>d__);
			return <DeleteKkt>d__.<>t__builder.Task;
		}

		// Token: 0x06004EBC RID: 20156 RVA: 0x00153670 File Offset: 0x00151870
		public static Task<bool> CreatePaymentSystem(payment_systems i)
		{
			KassaModel.<CreatePaymentSystem>d__50 <CreatePaymentSystem>d__;
			<CreatePaymentSystem>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<CreatePaymentSystem>d__.i = i;
			<CreatePaymentSystem>d__.<>1__state = -1;
			<CreatePaymentSystem>d__.<>t__builder.Start<KassaModel.<CreatePaymentSystem>d__50>(ref <CreatePaymentSystem>d__);
			return <CreatePaymentSystem>d__.<>t__builder.Task;
		}

		// Token: 0x06004EBD RID: 20157 RVA: 0x001536B4 File Offset: 0x001518B4
		public static Task<bool> UpdatePaymentSystem(payment_systems i)
		{
			KassaModel.<UpdatePaymentSystem>d__51 <UpdatePaymentSystem>d__;
			<UpdatePaymentSystem>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<UpdatePaymentSystem>d__.i = i;
			<UpdatePaymentSystem>d__.<>1__state = -1;
			<UpdatePaymentSystem>d__.<>t__builder.Start<KassaModel.<UpdatePaymentSystem>d__51>(ref <UpdatePaymentSystem>d__);
			return <UpdatePaymentSystem>d__.<>t__builder.Task;
		}

		// Token: 0x06004EBE RID: 20158 RVA: 0x001536F8 File Offset: 0x001518F8
		public static IAscResult CreateCashOrder(ICashOrder o, bool updatePrepaidSumm = true)
		{
			Result result = new Result();
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					return KassaModel.CreateCashOrder(auseceEntities, o, updatePrepaidSumm, true);
				}
			}
			catch (Exception ex)
			{
				KassaModel.Log.Error(ex, ex.Message);
				result.Message = ex.Message;
			}
			return result;
		}

		// Token: 0x06004EBF RID: 20159 RVA: 0x00153768 File Offset: 0x00151968
		public static IAscResult CreateCashOrder(auseceEntities ctx, ICashOrder o, bool updateRepairPrepaidSumm = true, bool setRnPayed = true)
		{
			Result result = new Result();
			DateTime serverUtcTime = Localization.GetServerUtcTime(ctx);
			cash_orders cash_orders = new cash_orders
			{
				created = serverUtcTime,
				company = o.CompanyId,
				office = o.OfficeId,
				type = o.Type,
				user = o.EmployeeId,
				summa = o.Summ,
				summa_str = o.SummStr,
				invoice = o.InvoiceId,
				client = o.CustomerId,
				to_user = o.ToEmployeeId,
				notes = o.Reason,
				repair = o.RepairId,
				document = o.DocumentId,
				img = o.PhotoId,
				payment_system = o.PaymentSystem,
				card_fee = o.CardFee,
				is_backdate = o.IsBackdate,
				customer_email = o.CustomerEmail,
				payment_item_sign = o.PaymentItemSign
			};
			ctx.cash_orders.Add(cash_orders);
			ctx.SaveChanges();
			if (o.PaymentSystem == -1 && o.PinpadId != 0)
			{
				pinpad_logs pinpad_logs = new pinpad_logs
				{
					pinpad = o.PinpadId,
					created = serverUtcTime,
					amount = o.Amount,
					TermNum = o.TermNum,
					ClientCard = o.ClientCard,
					ClientExpiryDate = o.ClientExpiryDate,
					AuthCode = o.AuthCode,
					CardName = o.CardName
				};
				ctx.pinpad_logs.Add(pinpad_logs);
				ctx.SaveChanges();
				cash_orders.card_info = new int?(pinpad_logs.id);
				ctx.SaveChanges();
			}
			HistoryV2 historyV = new HistoryV2();
			if (cash_orders.type == 13)
			{
				KassaModel.ChargeCustomerBalance(cash_orders.client.Value, cash_orders.summa, Kassa.Balance.ChargeBalance, cash_orders.repair);
				historyV.AddClientLog("filllUpBalance", cash_orders.client.Value, cash_orders.summa, 0);
			}
			if (cash_orders.type == 14 && setRnPayed)
			{
				KassaModel.SetRnPayed(ctx, cash_orders.document.Value, cash_orders.id);
			}
			if (cash_orders.repair != null)
			{
				if (cash_orders.type == 15)
				{
					KassaModel.CloseRepairDebt(cash_orders.repair.Value, cash_orders.id);
				}
				if (cash_orders.type == 12)
				{
					if (updateRepairPrepaidSumm)
					{
						KassaModel.UpdateRepairPrepaidSumm(ctx, cash_orders.repair.Value, cash_orders.summa);
					}
					historyV.AddRepairLog("RepairPrePayment", cash_orders.repair.Value, cash_orders.summa, cash_orders.payment_system);
				}
			}
			result.Id = cash_orders.id;
			result.SetSuccess();
			historyV.AddKassaLog(cash_orders);
			historyV.Save();
			return result;
		}

		// Token: 0x06004EC0 RID: 20160 RVA: 0x00153A44 File Offset: 0x00151C44
		public static Task<bool> CreatePinpad(pinpad selectedPinpad)
		{
			KassaModel.<CreatePinpad>d__54 <CreatePinpad>d__;
			<CreatePinpad>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<CreatePinpad>d__.selectedPinpad = selectedPinpad;
			<CreatePinpad>d__.<>1__state = -1;
			<CreatePinpad>d__.<>t__builder.Start<KassaModel.<CreatePinpad>d__54>(ref <CreatePinpad>d__);
			return <CreatePinpad>d__.<>t__builder.Task;
		}

		// Token: 0x06004EC1 RID: 20161 RVA: 0x00153A88 File Offset: 0x00151C88
		public static Task<bool> UpdatePinpad(pinpad p)
		{
			KassaModel.<UpdatePinpad>d__55 <UpdatePinpad>d__;
			<UpdatePinpad>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<UpdatePinpad>d__.p = p;
			<UpdatePinpad>d__.<>1__state = -1;
			<UpdatePinpad>d__.<>t__builder.Start<KassaModel.<UpdatePinpad>d__55>(ref <UpdatePinpad>d__);
			return <UpdatePinpad>d__.<>t__builder.Task;
		}

		// Token: 0x06004EC2 RID: 20162 RVA: 0x00153ACC File Offset: 0x00151CCC
		public static IAscResult UpdateOrderPaymentSystem(int orderId, int paymentSystem)
		{
			IAscResult result;
			using (GenericRepository<cash_orders> genericRepository = new GenericRepository<cash_orders>())
			{
				cash_orders firstOrDefault = genericRepository.GetFirstOrDefault((cash_orders o) => o.id == orderId, "");
				firstOrDefault.payment_system = paymentSystem;
				result = genericRepository.Update(firstOrDefault);
			}
			return result;
		}

		// Token: 0x06004EC3 RID: 20163 RVA: 0x00153B84 File Offset: 0x00151D84
		public KassaModel()
		{
		}

		// Token: 0x06004EC4 RID: 20164 RVA: 0x00153BA8 File Offset: 0x00151DA8
		// Note: this type is marked as 'beforefieldinit'.
		static KassaModel()
		{
		}

		// Token: 0x040033FC RID: 13308
		private static readonly ILogger Log = LogManager.GetCurrentClassLogger();

		// Token: 0x040033FD RID: 13309
		[CompilerGenerated]
		private cash_orders <Order>k__BackingField;

		// Token: 0x040033FE RID: 13310
		private Localization _localization = new Localization("UTC");

		// Token: 0x02000ACC RID: 2764
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004EC5 RID: 20165 RVA: 0x00153BC0 File Offset: 0x00151DC0
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004EC6 RID: 20166 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x040033FF RID: 13311
			public static readonly KassaModel.<>c <>9 = new KassaModel.<>c();
		}

		// Token: 0x02000ACD RID: 2765
		[CompilerGenerated]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x06004EC7 RID: 20167 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x04003400 RID: 13312
			public int orderId;
		}

		// Token: 0x02000ACE RID: 2766
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetOrder>d__8 : IAsyncStateMachine
		{
			// Token: 0x06004EC8 RID: 20168 RVA: 0x00153BD8 File Offset: 0x00151DD8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				cash_orders result;
				try
				{
					KassaModel.<>c__DisplayClass8_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new KassaModel.<>c__DisplayClass8_0();
						CS$<>8__locals1.orderId = this.orderId;
						this.<repo>5__2 = new GenericRepository<cash_orders>();
					}
					try
					{
						TaskAwaiter<cash_orders> awaiter;
						if (num != 0)
						{
							awaiter = this.<repo>5__2.GetFirstOrDefaultAsync((cash_orders o) => o.id == CS$<>8__locals1.orderId, "companies,companies.users1,clients,docs,invoice1").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<cash_orders>, KassaModel.<GetOrder>d__8>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<cash_orders>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult();
					}
					finally
					{
						if (num < 0 && this.<repo>5__2 != null)
						{
							((IDisposable)this.<repo>5__2).Dispose();
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

			// Token: 0x06004EC9 RID: 20169 RVA: 0x00153D54 File Offset: 0x00151F54
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003401 RID: 13313
			public int <>1__state;

			// Token: 0x04003402 RID: 13314
			public AsyncTaskMethodBuilder<cash_orders> <>t__builder;

			// Token: 0x04003403 RID: 13315
			public int orderId;

			// Token: 0x04003404 RID: 13316
			private GenericRepository<cash_orders> <repo>5__2;

			// Token: 0x04003405 RID: 13317
			private TaskAwaiter<cash_orders> <>u__1;
		}

		// Token: 0x02000ACF RID: 2767
		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x06004ECA RID: 20170 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x04003406 RID: 13318
			public int orderId;
		}

		// Token: 0x02000AD0 RID: 2768
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCashInOrder>d__9 : IAsyncStateMachine
		{
			// Token: 0x06004ECB RID: 20171 RVA: 0x00153D70 File Offset: 0x00151F70
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CashInOrder result;
				try
				{
					KassaModel.<>c__DisplayClass9_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new KassaModel.<>c__DisplayClass9_0();
						CS$<>8__locals1.orderId = this.orderId;
						this.<repo>5__2 = new GenericRepository<cash_orders>();
					}
					try
					{
						TaskAwaiter<cash_orders> awaiter;
						if (num != 0)
						{
							awaiter = this.<repo>5__2.GetFirstOrDefaultAsync((cash_orders o) => o.id == CS$<>8__locals1.orderId, "clients,invoice1,pinpad_logs").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<cash_orders>, KassaModel.<GetCashInOrder>d__9>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<cash_orders>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult().ToCashInOrder();
					}
					finally
					{
						if (num < 0 && this.<repo>5__2 != null)
						{
							((IDisposable)this.<repo>5__2).Dispose();
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

			// Token: 0x06004ECC RID: 20172 RVA: 0x00153EF0 File Offset: 0x001520F0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003407 RID: 13319
			public int <>1__state;

			// Token: 0x04003408 RID: 13320
			public AsyncTaskMethodBuilder<CashInOrder> <>t__builder;

			// Token: 0x04003409 RID: 13321
			public int orderId;

			// Token: 0x0400340A RID: 13322
			private GenericRepository<cash_orders> <repo>5__2;

			// Token: 0x0400340B RID: 13323
			private TaskAwaiter<cash_orders> <>u__1;
		}

		// Token: 0x02000AD1 RID: 2769
		[CompilerGenerated]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x06004ECD RID: 20173 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x0400340C RID: 13324
			public int orderId;
		}

		// Token: 0x02000AD2 RID: 2770
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCashOutOrder>d__10 : IAsyncStateMachine
		{
			// Token: 0x06004ECE RID: 20174 RVA: 0x00153F0C File Offset: 0x0015210C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CashOutOrder result;
				try
				{
					KassaModel.<>c__DisplayClass10_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new KassaModel.<>c__DisplayClass10_0();
						CS$<>8__locals1.orderId = this.orderId;
						this.<repo>5__2 = new GenericRepository<cash_orders>();
					}
					try
					{
						TaskAwaiter<cash_orders> awaiter;
						if (num != 0)
						{
							awaiter = this.<repo>5__2.GetFirstOrDefaultAsync((cash_orders o) => o.id == CS$<>8__locals1.orderId, "clients,pinpad_logs").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<cash_orders>, KassaModel.<GetCashOutOrder>d__10>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<cash_orders>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult().ToCashOutOrder();
					}
					finally
					{
						if (num < 0 && this.<repo>5__2 != null)
						{
							((IDisposable)this.<repo>5__2).Dispose();
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

			// Token: 0x06004ECF RID: 20175 RVA: 0x0015408C File Offset: 0x0015228C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400340D RID: 13325
			public int <>1__state;

			// Token: 0x0400340E RID: 13326
			public AsyncTaskMethodBuilder<CashOutOrder> <>t__builder;

			// Token: 0x0400340F RID: 13327
			public int orderId;

			// Token: 0x04003410 RID: 13328
			private GenericRepository<cash_orders> <repo>5__2;

			// Token: 0x04003411 RID: 13329
			private TaskAwaiter<cash_orders> <>u__1;
		}

		// Token: 0x02000AD3 RID: 2771
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Widthraw>d__16 : IAsyncStateMachine
		{
			// Token: 0x06004ED0 RID: 20176 RVA: 0x001540A8 File Offset: 0x001522A8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				KassaModel kassaModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						kassaModel.Order = KassaModel.DefaultOrder();
						kassaModel.Order.office = this.officeId;
						kassaModel.Order.company = Auth.User.offices1.default_company;
						kassaModel.Order.type = 7;
						kassaModel.Order.summa = this.summa;
						kassaModel.Order.client = null;
						kassaModel.Order.to_user = new int?(this.toUserId);
						kassaModel.Order.payment_system = this.paymentSystemId;
						kassaModel.SetSummaString();
						kassaModel.InvertOrderSumma();
						this.<history>5__2 = new HistoryV2();
						this.<ctx>5__3 = new auseceEntities(true);
					}
					try
					{
						ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							this.<ctx>5__3.cash_orders.Add(kassaModel.Order);
							awaiter = this.<ctx>5__3.SaveChangesAsync().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter, KassaModel.<Widthraw>d__16>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						awaiter.GetResult();
						this.<history>5__2.AddKassaLog(kassaModel.Order);
						this.<history>5__2.Save();
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
					this.<history>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<history>5__2 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06004ED1 RID: 20177 RVA: 0x001542B0 File Offset: 0x001524B0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003412 RID: 13330
			public int <>1__state;

			// Token: 0x04003413 RID: 13331
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04003414 RID: 13332
			public KassaModel <>4__this;

			// Token: 0x04003415 RID: 13333
			public int officeId;

			// Token: 0x04003416 RID: 13334
			public decimal summa;

			// Token: 0x04003417 RID: 13335
			public int toUserId;

			// Token: 0x04003418 RID: 13336
			public int paymentSystemId;

			// Token: 0x04003419 RID: 13337
			private HistoryV2 <history>5__2;

			// Token: 0x0400341A RID: 13338
			private auseceEntities <ctx>5__3;

			// Token: 0x0400341B RID: 13339
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000AD4 RID: 2772
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SalaryPay>d__22 : IAsyncStateMachine
		{
			// Token: 0x06004ED2 RID: 20178 RVA: 0x001542CC File Offset: 0x001524CC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				KassaModel kassaModel = this.<>4__this;
				int id;
				try
				{
					if (num != 0)
					{
						kassaModel.Order = KassaModel.DefaultOrder();
						kassaModel.Order.client = null;
						kassaModel.Order.company = Auth.User.offices1.default_company;
						kassaModel.Order.type = 6;
						kassaModel.Order.summa = this.summ;
						kassaModel.Order.to_user = new int?(this.userId);
						kassaModel.Order.created = this.date;
						kassaModel.SetPaymentSystem(this.paymentOption);
						kassaModel.Autocomplete(true);
						kassaModel.SetSummaString();
						this.<orderSumm>5__2 = kassaModel.Order.summa;
						kassaModel.InvertOrderSumma();
						this.<history>5__3 = new HistoryV2();
						this.<ctx>5__4 = new auseceEntities(true);
					}
					try
					{
						ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							DateTime serverUtcTime = Localization.GetServerUtcTime(this.<ctx>5__4);
							if (this.date.Date < serverUtcTime.Date)
							{
								kassaModel.Order.is_backdate = true;
							}
							this.<ctx>5__4.cash_orders.Add(kassaModel.Order);
							awaiter = this.<ctx>5__4.SaveChangesAsync().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter, KassaModel.<SalaryPay>d__22>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						awaiter.GetResult();
						this.<history>5__3.AddUserLog("SalaryPay", this.userId, new string[]
						{
							this.<orderSumm>5__2.ToString("N2")
						});
						this.<history>5__3.Save();
						id = kassaModel.Order.id;
					}
					finally
					{
						if (num < 0 && this.<ctx>5__4 != null)
						{
							((IDisposable)this.<ctx>5__4).Dispose();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<history>5__3 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<history>5__3 = null;
				this.<>t__builder.SetResult(id);
			}

			// Token: 0x06004ED3 RID: 20179 RVA: 0x00154540 File Offset: 0x00152740
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400341C RID: 13340
			public int <>1__state;

			// Token: 0x0400341D RID: 13341
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x0400341E RID: 13342
			public KassaModel <>4__this;

			// Token: 0x0400341F RID: 13343
			public decimal summ;

			// Token: 0x04003420 RID: 13344
			public int userId;

			// Token: 0x04003421 RID: 13345
			public DateTime date;

			// Token: 0x04003422 RID: 13346
			public int paymentOption;

			// Token: 0x04003423 RID: 13347
			private decimal <orderSumm>5__2;

			// Token: 0x04003424 RID: 13348
			private HistoryV2 <history>5__3;

			// Token: 0x04003425 RID: 13349
			private auseceEntities <ctx>5__4;

			// Token: 0x04003426 RID: 13350
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000AD5 RID: 2773
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CloseRepairDebt>d__27 : IAsyncStateMachine
		{
			// Token: 0x06004ED4 RID: 20180 RVA: 0x0015455C File Offset: 0x0015275C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					try
					{
						if (num != 0)
						{
							this.<history>5__2 = new HistoryV2();
							this.<ctx>5__3 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<workshop> awaiter;
							if (num != 0)
							{
								this.<repair>5__4 = this.<ctx>5__3.workshop.Find(new object[]
								{
									this.repairId
								});
								if (this.<repair>5__4 == null || this.<repair>5__4.state != 16)
								{
									goto IL_159;
								}
								this.<repair>5__4.new_state = 8;
								awaiter = Bootstrapper.Container.Resolve<IWorkshopStatusService>().UpdateStatus(this.<repair>5__4).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop>, KassaModel.<CloseRepairDebt>d__27>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<workshop>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							awaiter.GetResult();
							this.<repair>5__4.is_debt = false;
							this.<ctx>5__3.SaveChanges();
							KassaModel.ChargeCustomerBalance(this.<repair>5__4.client, this.summ, Kassa.Balance.RepairDebtClose, new int?(this.repairId));
							this.<history>5__2.AddClientLog("RepairDebtClose", this.<repair>5__4.client, this.summ, this.<repair>5__4.id);
							this.<history>5__2.Save();
							IL_159:
							this.<repair>5__4 = null;
						}
						finally
						{
							if (num < 0 && this.<ctx>5__3 != null)
							{
								((IDisposable)this.<ctx>5__3).Dispose();
							}
						}
						this.<ctx>5__3 = null;
						this.<history>5__2 = null;
					}
					catch (Exception exception)
					{
						KassaModel.Log.Error(exception, "Close repair debt fail");
					}
				}
				catch (Exception exception2)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception2);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06004ED5 RID: 20181 RVA: 0x00154780 File Offset: 0x00152980
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003427 RID: 13351
			public int <>1__state;

			// Token: 0x04003428 RID: 13352
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04003429 RID: 13353
			public int repairId;

			// Token: 0x0400342A RID: 13354
			public decimal summ;

			// Token: 0x0400342B RID: 13355
			private HistoryV2 <history>5__2;

			// Token: 0x0400342C RID: 13356
			private auseceEntities <ctx>5__3;

			// Token: 0x0400342D RID: 13357
			private workshop <repair>5__4;

			// Token: 0x0400342E RID: 13358
			private TaskAwaiter<workshop> <>u__1;
		}

		// Token: 0x02000AD6 RID: 2774
		[CompilerGenerated]
		private sealed class <>c__DisplayClass41_0
		{
			// Token: 0x06004ED6 RID: 20182 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass41_0()
			{
			}

			// Token: 0x0400342F RID: 13359
			public int type;
		}

		// Token: 0x02000AD7 RID: 2775
		[CompilerGenerated]
		private sealed class <>c__DisplayClass42_0
		{
			// Token: 0x06004ED7 RID: 20183 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass42_0()
			{
			}

			// Token: 0x04003430 RID: 13360
			public invoice inv;
		}

		// Token: 0x02000AD8 RID: 2776
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <MakePko>d__42 : IAsyncStateMachine
		{
			// Token: 0x06004ED8 RID: 20184 RVA: 0x0015479C File Offset: 0x0015299C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				KassaModel kassaModel = this.<>4__this;
				int result;
				try
				{
					if (num > 1)
					{
						kassaModel.NewCashOrder(Kassa.Types.InvoicePayment);
						kassaModel.SetPaymentSystem(1);
						kassaModel.Order.company = this.invoice.Seller.CompanyId;
						kassaModel.Order.summa = this.invoice.Total;
						kassaModel.SetSummaString();
						kassaModel.Order.invoice = new int?(this.invoice.Id);
						kassaModel.Order.client = new int?(this.invoice.Customer.CustomerId);
						kassaModel.Autocomplete(this.invoice);
					}
					try
					{
						if (num > 1)
						{
							this.<history>5__2 = new HistoryV2();
							this.<ctx>5__3 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<int> awaiter;
							if (num != 0)
							{
								if (num == 1)
								{
									awaiter = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter<int>);
									int num2 = -1;
									num = -1;
									this.<>1__state = num2;
									goto IL_4A3;
								}
								this.<>8__1 = new KassaModel.<>c__DisplayClass42_0();
								this.<ctx>5__3.cash_orders.Add(kassaModel.Order);
								awaiter = this.<ctx>5__3.SaveChangesAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num3 = 0;
									num = 0;
									this.<>1__state = num3;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, KassaModel.<MakePko>d__42>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<int>);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
							}
							awaiter.GetResult();
							this.<history>5__2.AddKassaLog(kassaModel.Order);
							this.<>8__1.inv = this.<ctx>5__3.invoice.FirstOrDefault((invoice i) => (int?)i.id == kassaModel.Order.invoice);
							if (this.<>8__1.inv != null)
							{
								this.<>8__1.inv.state = 2;
								this.<>8__1.inv.paid = new DateTime?(kassaModel._localization.Now);
								List<docs> list = (from d in this.<ctx>5__3.docs
								where d.invoice == (int?)this.<>8__1.inv.id
								select d).ToList<docs>();
								if (list.Any<docs>())
								{
									List<docs>.Enumerator enumerator = list.GetEnumerator();
									try
									{
										while (enumerator.MoveNext())
										{
											docs docs = enumerator.Current;
											this.<history>5__2.AddDocumentLog("InvoicePaid", docs.id, this.<>8__1.inv.num);
										}
									}
									finally
									{
										if (num < 0)
										{
											((IDisposable)enumerator).Dispose();
										}
									}
								}
								List<workshop> list2 = (from r in this.<ctx>5__3.workshop
								where r.invoice == (int?)this.<>8__1.inv.id
								select r).ToList<workshop>();
								if (list2.Any<workshop>())
								{
									List<workshop>.Enumerator enumerator2 = list2.GetEnumerator();
									try
									{
										while (enumerator2.MoveNext())
										{
											workshop workshop = enumerator2.Current;
											this.<history>5__2.AddRepairLog("InvoicePaidRepair", workshop.id, this.<>8__1.inv.num, "");
										}
									}
									finally
									{
										if (num < 0)
										{
											((IDisposable)enumerator2).Dispose();
										}
									}
								}
							}
							awaiter = this.<ctx>5__3.SaveChangesAsync().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num5 = 1;
								num = 1;
								this.<>1__state = num5;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, KassaModel.<MakePko>d__42>(ref awaiter, ref this);
								return;
							}
							IL_4A3:
							awaiter.GetResult();
							this.<history>5__2.Save();
							result = kassaModel.Order.id;
						}
						finally
						{
							if (num < 0 && this.<ctx>5__3 != null)
							{
								((IDisposable)this.<ctx>5__3).Dispose();
							}
						}
					}
					catch (Exception ex)
					{
						KassaModel.Log.Error(ex, ex.Message);
						result = -1;
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

			// Token: 0x06004ED9 RID: 20185 RVA: 0x00154D48 File Offset: 0x00152F48
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003431 RID: 13361
			public int <>1__state;

			// Token: 0x04003432 RID: 13362
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x04003433 RID: 13363
			public KassaModel <>4__this;

			// Token: 0x04003434 RID: 13364
			public IInvoice invoice;

			// Token: 0x04003435 RID: 13365
			private KassaModel.<>c__DisplayClass42_0 <>8__1;

			// Token: 0x04003436 RID: 13366
			private HistoryV2 <history>5__2;

			// Token: 0x04003437 RID: 13367
			private auseceEntities <ctx>5__3;

			// Token: 0x04003438 RID: 13368
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x02000AD9 RID: 2777
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadPaymentSystems>d__44 : IAsyncStateMachine
		{
			// Token: 0x06004EDA RID: 20186 RVA: 0x00154D64 File Offset: 0x00152F64
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IEnumerable<payment_systems> result2;
				try
				{
					if (num > 1)
					{
						this.<repo>5__2 = new GenericRepository<payment_systems>();
					}
					try
					{
						TaskAwaiter<IEnumerable<payment_systems>> awaiter;
						IEnumerable<payment_systems> result;
						if (num != 0)
						{
							if (num != 1)
							{
								if (!this.showArchive)
								{
									awaiter = this.<repo>5__2.GetAllAsync((payment_systems p) => p.system_id > 1 && p.is_enable, null, "").GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										int num2 = 1;
										num = 1;
										this.<>1__state = num2;
										this.<>u__1 = awaiter;
										this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<payment_systems>>, KassaModel.<LoadPaymentSystems>d__44>(ref awaiter, ref this);
										return;
									}
								}
								else
								{
									awaiter = this.<repo>5__2.GetAllAsync((payment_systems p) => p.system_id > 1, null, "").GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										int num3 = 0;
										num = 0;
										this.<>1__state = num3;
										this.<>u__1 = awaiter;
										this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<payment_systems>>, KassaModel.<LoadPaymentSystems>d__44>(ref awaiter, ref this);
										return;
									}
									goto IL_1C1;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<IEnumerable<payment_systems>>);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
							}
							result = awaiter.GetResult();
							goto IL_1C9;
						}
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<payment_systems>>);
						int num5 = -1;
						num = -1;
						this.<>1__state = num5;
						IL_1C1:
						result = awaiter.GetResult();
						IL_1C9:
						result2 = result;
					}
					finally
					{
						if (num < 0 && this.<repo>5__2 != null)
						{
							((IDisposable)this.<repo>5__2).Dispose();
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
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06004EDB RID: 20187 RVA: 0x00154FB8 File Offset: 0x001531B8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003439 RID: 13369
			public int <>1__state;

			// Token: 0x0400343A RID: 13370
			public AsyncTaskMethodBuilder<IEnumerable<payment_systems>> <>t__builder;

			// Token: 0x0400343B RID: 13371
			public bool showArchive;

			// Token: 0x0400343C RID: 13372
			private GenericRepository<payment_systems> <repo>5__2;

			// Token: 0x0400343D RID: 13373
			private TaskAwaiter<IEnumerable<payment_systems>> <>u__1;
		}

		// Token: 0x02000ADA RID: 2778
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetAllKkt>d__45 : IAsyncStateMachine
		{
			// Token: 0x06004EDC RID: 20188 RVA: 0x00154FD4 File Offset: 0x001531D4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IEnumerable<kkt> result;
				try
				{
					if (num != 0)
					{
						this.<repo>5__2 = new GenericRepository<kkt>();
					}
					try
					{
						TaskAwaiter<IEnumerable<kkt>> awaiter;
						if (num != 0)
						{
							awaiter = this.<repo>5__2.GetAllAsync(null, null, "").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<kkt>>, KassaModel.<GetAllKkt>d__45>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IEnumerable<kkt>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult();
					}
					finally
					{
						if (num < 0 && this.<repo>5__2 != null)
						{
							((IDisposable)this.<repo>5__2).Dispose();
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

			// Token: 0x06004EDD RID: 20189 RVA: 0x001550C0 File Offset: 0x001532C0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400343E RID: 13374
			public int <>1__state;

			// Token: 0x0400343F RID: 13375
			public AsyncTaskMethodBuilder<IEnumerable<kkt>> <>t__builder;

			// Token: 0x04003440 RID: 13376
			private GenericRepository<kkt> <repo>5__2;

			// Token: 0x04003441 RID: 13377
			private TaskAwaiter<IEnumerable<kkt>> <>u__1;
		}

		// Token: 0x02000ADB RID: 2779
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetAllPinpads>d__46 : IAsyncStateMachine
		{
			// Token: 0x06004EDE RID: 20190 RVA: 0x001550DC File Offset: 0x001532DC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IEnumerable<pinpad> result;
				try
				{
					if (num != 0)
					{
						this.<repo>5__2 = new GenericRepository<pinpad>();
					}
					try
					{
						TaskAwaiter<IEnumerable<pinpad>> awaiter;
						if (num != 0)
						{
							awaiter = this.<repo>5__2.GetAllAsync(null, null, "").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<pinpad>>, KassaModel.<GetAllPinpads>d__46>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IEnumerable<pinpad>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult();
					}
					finally
					{
						if (num < 0 && this.<repo>5__2 != null)
						{
							((IDisposable)this.<repo>5__2).Dispose();
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

			// Token: 0x06004EDF RID: 20191 RVA: 0x001551C8 File Offset: 0x001533C8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003442 RID: 13378
			public int <>1__state;

			// Token: 0x04003443 RID: 13379
			public AsyncTaskMethodBuilder<IEnumerable<pinpad>> <>t__builder;

			// Token: 0x04003444 RID: 13380
			private GenericRepository<pinpad> <repo>5__2;

			// Token: 0x04003445 RID: 13381
			private TaskAwaiter<IEnumerable<pinpad>> <>u__1;
		}

		// Token: 0x02000ADC RID: 2780
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateKkt>d__47 : IAsyncStateMachine
		{
			// Token: 0x06004EE0 RID: 20192 RVA: 0x001551E4 File Offset: 0x001533E4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				bool result2;
				try
				{
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<kkt> awaiter;
							if (num != 0)
							{
								awaiter = this.<ctx>5__2.kkt.FindAsync(new object[]
								{
									this.i.id
								}).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<kkt>, KassaModel.<UpdateKkt>d__47>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<kkt>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							kkt result = awaiter.GetResult();
							result.name = this.i.name;
							result.office = this.i.office;
							result.protocol = this.i.protocol;
							result.ip = this.i.ip;
							result.port = this.i.port;
							result.tax_type = this.i.tax_type;
							result.tax = this.i.tax;
							result.r_simple = this.i.r_simple;
							result.s_simple = this.i.s_simple;
							result.s_tpl = this.i.s_tpl;
							result.r_tpl = this.i.r_tpl;
							result.footer = this.i.footer;
							result.order_payment_item_sign = this.i.order_payment_item_sign;
							result.product_payment_item_sign = this.i.product_payment_item_sign;
							result.@operator = this.i.@operator;
							result.operator_inn = this.i.operator_inn;
							this.<ctx>5__2.SaveChanges();
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
					catch (Exception ex)
					{
						KassaModel.Log.Error(ex, ex.Message);
						result2 = false;
						goto IL_20A;
					}
					result2 = true;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_20A:
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06004EE1 RID: 20193 RVA: 0x0015545C File Offset: 0x0015365C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003446 RID: 13382
			public int <>1__state;

			// Token: 0x04003447 RID: 13383
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x04003448 RID: 13384
			public kkt i;

			// Token: 0x04003449 RID: 13385
			private auseceEntities <ctx>5__2;

			// Token: 0x0400344A RID: 13386
			private TaskAwaiter<kkt> <>u__1;
		}

		// Token: 0x02000ADD RID: 2781
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateKkt>d__48 : IAsyncStateMachine
		{
			// Token: 0x06004EE2 RID: 20194 RVA: 0x00155478 File Offset: 0x00153678
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				bool result;
				try
				{
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<int> awaiter;
							if (num != 0)
							{
								this.<ctx>5__2.kkt.Add(this.i);
								awaiter = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, KassaModel.<CreateKkt>d__48>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<int>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							awaiter.GetResult();
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
					catch (Exception ex)
					{
						KassaModel.Log.Error(ex, ex.Message);
						result = false;
						goto IL_E9;
					}
					result = true;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_E9:
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06004EE3 RID: 20195 RVA: 0x001555AC File Offset: 0x001537AC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400344B RID: 13387
			public int <>1__state;

			// Token: 0x0400344C RID: 13388
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x0400344D RID: 13389
			public kkt i;

			// Token: 0x0400344E RID: 13390
			private auseceEntities <ctx>5__2;

			// Token: 0x0400344F RID: 13391
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x02000ADE RID: 2782
		[CompilerGenerated]
		private sealed class <>c__DisplayClass49_0
		{
			// Token: 0x06004EE4 RID: 20196 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass49_0()
			{
			}

			// Token: 0x04003450 RID: 13392
			public kkt i;
		}

		// Token: 0x02000ADF RID: 2783
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <DeleteKkt>d__49 : IAsyncStateMachine
		{
			// Token: 0x06004EE5 RID: 20197 RVA: 0x001555C8 File Offset: 0x001537C8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				bool result4;
				try
				{
					if (num > 2)
					{
						this.<>8__1 = new KassaModel.<>c__DisplayClass49_0();
						this.<>8__1.i = this.i;
					}
					try
					{
						if (num > 2)
						{
							this.<ctx>5__2 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<List<users>> awaiter;
							TaskAwaiter<List<pinpad>> awaiter2;
							TaskAwaiter<kkt> awaiter3;
							switch (num)
							{
							case 0:
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<List<users>>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								break;
							}
							case 1:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<List<pinpad>>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
								goto IL_292;
							}
							case 2:
							{
								awaiter3 = this.<>u__3;
								this.<>u__3 = default(TaskAwaiter<kkt>);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
								goto IL_36B;
							}
							default:
								this.<ctx>5__2.Configuration.ProxyCreationEnabled = false;
								awaiter = (from k in this.<ctx>5__2.users
								where k.kkt == (int?)this.<>8__1.i.id
								select k).ToListAsync<users>().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num5 = 0;
									num = 0;
									this.<>1__state = num5;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<users>>, KassaModel.<DeleteKkt>d__49>(ref awaiter, ref this);
									return;
								}
								break;
							}
							List<users> result = awaiter.GetResult();
							if (result.Any<users>())
							{
								List<users>.Enumerator enumerator = result.GetEnumerator();
								try
								{
									while (enumerator.MoveNext())
									{
										users users = enumerator.Current;
										users.kkt = null;
									}
								}
								finally
								{
									if (num < 0)
									{
										((IDisposable)enumerator).Dispose();
									}
								}
								this.<ctx>5__2.SaveChanges();
							}
							awaiter2 = (from p in this.<ctx>5__2.pinpad
							where p.kkt == (int?)this.<>8__1.i.id
							select p).ToListAsync<pinpad>().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num6 = 1;
								num = 1;
								this.<>1__state = num6;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<pinpad>>, KassaModel.<DeleteKkt>d__49>(ref awaiter2, ref this);
								return;
							}
							IL_292:
							List<pinpad> result2 = awaiter2.GetResult();
							if (result2.Any<pinpad>())
							{
								List<pinpad>.Enumerator enumerator2 = result2.GetEnumerator();
								try
								{
									while (enumerator2.MoveNext())
									{
										pinpad pinpad = enumerator2.Current;
										pinpad.kkt = null;
									}
								}
								finally
								{
									if (num < 0)
									{
										((IDisposable)enumerator2).Dispose();
									}
								}
								this.<ctx>5__2.SaveChanges();
							}
							awaiter3 = this.<ctx>5__2.kkt.FindAsync(new object[]
							{
								this.<>8__1.i.id
							}).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								int num7 = 2;
								num = 2;
								this.<>1__state = num7;
								this.<>u__3 = awaiter3;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<kkt>, KassaModel.<DeleteKkt>d__49>(ref awaiter3, ref this);
								return;
							}
							IL_36B:
							kkt result3 = awaiter3.GetResult();
							this.<ctx>5__2.kkt.Remove(result3);
							this.<ctx>5__2.SaveChanges();
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
					catch (Exception ex)
					{
						KassaModel.Log.Error(ex, ex.Message);
						result4 = false;
						goto IL_3F3;
					}
					result4 = true;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_3F3:
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult(result4);
			}

			// Token: 0x06004EE6 RID: 20198 RVA: 0x00155A60 File Offset: 0x00153C60
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003451 RID: 13393
			public int <>1__state;

			// Token: 0x04003452 RID: 13394
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x04003453 RID: 13395
			public kkt i;

			// Token: 0x04003454 RID: 13396
			private KassaModel.<>c__DisplayClass49_0 <>8__1;

			// Token: 0x04003455 RID: 13397
			private auseceEntities <ctx>5__2;

			// Token: 0x04003456 RID: 13398
			private TaskAwaiter<List<users>> <>u__1;

			// Token: 0x04003457 RID: 13399
			private TaskAwaiter<List<pinpad>> <>u__2;

			// Token: 0x04003458 RID: 13400
			private TaskAwaiter<kkt> <>u__3;
		}

		// Token: 0x02000AE0 RID: 2784
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreatePaymentSystem>d__50 : IAsyncStateMachine
		{
			// Token: 0x06004EE7 RID: 20199 RVA: 0x00155A7C File Offset: 0x00153C7C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				bool result;
				try
				{
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<int> awaiter;
							if (num != 0)
							{
								int num2 = this.<ctx>5__2.payment_systems.Max((payment_systems s) => s.system_id);
								this.i.system_id = num2 + 1;
								this.<ctx>5__2.payment_systems.Add(this.i);
								awaiter = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num3 = 0;
									num = 0;
									this.<>1__state = num3;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, KassaModel.<CreatePaymentSystem>d__50>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<int>);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
							}
							awaiter.GetResult();
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
					catch (Exception ex)
					{
						KassaModel.Log.Error(ex, ex.Message);
						result = false;
						goto IL_14A;
					}
					result = true;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_14A:
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06004EE8 RID: 20200 RVA: 0x00155C34 File Offset: 0x00153E34
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003459 RID: 13401
			public int <>1__state;

			// Token: 0x0400345A RID: 13402
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x0400345B RID: 13403
			public payment_systems i;

			// Token: 0x0400345C RID: 13404
			private auseceEntities <ctx>5__2;

			// Token: 0x0400345D RID: 13405
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x02000AE1 RID: 2785
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdatePaymentSystem>d__51 : IAsyncStateMachine
		{
			// Token: 0x06004EE9 RID: 20201 RVA: 0x00155C50 File Offset: 0x00153E50
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				bool result2;
				try
				{
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<payment_systems> awaiter;
							if (num != 0)
							{
								awaiter = this.<ctx>5__2.payment_systems.FindAsync(new object[]
								{
									this.i.id
								}).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<payment_systems>, KassaModel.<UpdatePaymentSystem>d__51>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<payment_systems>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							payment_systems result = awaiter.GetResult();
							result.name = this.i.name;
							result.system_data = this.i.system_data;
							result.is_enable = this.i.is_enable;
							this.<ctx>5__2.SaveChanges();
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
					catch (Exception ex)
					{
						KassaModel.Log.Error(ex, ex.Message);
						result2 = false;
						goto IL_12D;
					}
					result2 = true;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_12D:
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06004EEA RID: 20202 RVA: 0x00155DEC File Offset: 0x00153FEC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400345E RID: 13406
			public int <>1__state;

			// Token: 0x0400345F RID: 13407
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x04003460 RID: 13408
			public payment_systems i;

			// Token: 0x04003461 RID: 13409
			private auseceEntities <ctx>5__2;

			// Token: 0x04003462 RID: 13410
			private TaskAwaiter<payment_systems> <>u__1;
		}

		// Token: 0x02000AE2 RID: 2786
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreatePinpad>d__54 : IAsyncStateMachine
		{
			// Token: 0x06004EEB RID: 20203 RVA: 0x00155E08 File Offset: 0x00154008
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				bool result;
				try
				{
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<int> awaiter;
							if (num != 0)
							{
								this.<ctx>5__2.pinpad.Add(this.selectedPinpad);
								awaiter = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, KassaModel.<CreatePinpad>d__54>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<int>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							awaiter.GetResult();
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
					catch (Exception ex)
					{
						KassaModel.Log.Error(ex, ex.Message);
						result = false;
						goto IL_E9;
					}
					result = true;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_E9:
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06004EEC RID: 20204 RVA: 0x00155F3C File Offset: 0x0015413C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003463 RID: 13411
			public int <>1__state;

			// Token: 0x04003464 RID: 13412
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x04003465 RID: 13413
			public pinpad selectedPinpad;

			// Token: 0x04003466 RID: 13414
			private auseceEntities <ctx>5__2;

			// Token: 0x04003467 RID: 13415
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x02000AE3 RID: 2787
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdatePinpad>d__55 : IAsyncStateMachine
		{
			// Token: 0x06004EED RID: 20205 RVA: 0x00155F58 File Offset: 0x00154158
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				bool result2;
				try
				{
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<pinpad> awaiter;
							if (num != 0)
							{
								awaiter = this.<ctx>5__2.pinpad.FindAsync(new object[]
								{
									this.p.id
								}).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<pinpad>, KassaModel.<UpdatePinpad>d__55>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<pinpad>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							pinpad result = awaiter.GetResult();
							result.name = this.p.name;
							result.kkt = this.p.kkt;
							result.office = this.p.office;
							result.fee = this.p.fee;
							result.fee_mode = this.p.fee_mode;
							this.<ctx>5__2.SaveChanges();
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
					catch (Exception ex)
					{
						KassaModel.Log.Error(ex, ex.Message);
						result2 = false;
						goto IL_14F;
					}
					result2 = true;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_14F:
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06004EEE RID: 20206 RVA: 0x00156114 File Offset: 0x00154314
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003468 RID: 13416
			public int <>1__state;

			// Token: 0x04003469 RID: 13417
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x0400346A RID: 13418
			public pinpad p;

			// Token: 0x0400346B RID: 13419
			private auseceEntities <ctx>5__2;

			// Token: 0x0400346C RID: 13420
			private TaskAwaiter<pinpad> <>u__1;
		}

		// Token: 0x02000AE4 RID: 2788
		[CompilerGenerated]
		private sealed class <>c__DisplayClass56_0
		{
			// Token: 0x06004EEF RID: 20207 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass56_0()
			{
			}

			// Token: 0x0400346D RID: 13421
			public int orderId;
		}
	}
}
