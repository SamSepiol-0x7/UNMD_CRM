using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Common.SimpleClasses;
using ASC.DAL;
using ASC.Models;
using ASC.Objects;
using ASC.Objects.Converters;
using ASC.Options;
using ASC.SimpleClasses;

namespace ASC.Services
{
	// Token: 0x020005D2 RID: 1490
	public class KassaService : IKassaService
	{
		// Token: 0x0600370C RID: 14092 RVA: 0x000BC474 File Offset: 0x000BA674
		public KassaService(IContextFactory contextFactory)
		{
			this._contextFactory = contextFactory;
		}

		// Token: 0x0600370D RID: 14093 RVA: 0x000BC490 File Offset: 0x000BA690
		public Task<Saldo> GetThisMonthSaldo(int companyId, int officeId)
		{
			KassaService.<GetThisMonthSaldo>d__2 <GetThisMonthSaldo>d__;
			<GetThisMonthSaldo>d__.<>t__builder = AsyncTaskMethodBuilder<Saldo>.Create();
			<GetThisMonthSaldo>d__.<>4__this = this;
			<GetThisMonthSaldo>d__.companyId = companyId;
			<GetThisMonthSaldo>d__.officeId = officeId;
			<GetThisMonthSaldo>d__.<>1__state = -1;
			<GetThisMonthSaldo>d__.<>t__builder.Start<KassaService.<GetThisMonthSaldo>d__2>(ref <GetThisMonthSaldo>d__);
			return <GetThisMonthSaldo>d__.<>t__builder.Task;
		}

		// Token: 0x0600370E RID: 14094 RVA: 0x000BC4E4 File Offset: 0x000BA6E4
		private Task<decimal> SaldoSumAsync(IQueryable<cash_orders> query, Expression<Func<cash_orders, bool>> filter)
		{
			KassaService.<SaldoSumAsync>d__3 <SaldoSumAsync>d__;
			<SaldoSumAsync>d__.<>t__builder = AsyncTaskMethodBuilder<decimal>.Create();
			<SaldoSumAsync>d__.query = query;
			<SaldoSumAsync>d__.filter = filter;
			<SaldoSumAsync>d__.<>1__state = -1;
			<SaldoSumAsync>d__.<>t__builder.Start<KassaService.<SaldoSumAsync>d__3>(ref <SaldoSumAsync>d__);
			return <SaldoSumAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600370F RID: 14095 RVA: 0x000BC530 File Offset: 0x000BA730
		private Expression<Func<cash_orders, bool>> Predicate(PaymentOptions.Systems paymentSystem)
		{
			return (cash_orders o) => o.payment_system == (int)paymentSystem && o.summa > 0m;
		}

		// Token: 0x06003710 RID: 14096 RVA: 0x000BC5F0 File Offset: 0x000BA7F0
		public Task<decimal> GetCashSaldo(IPeriod period, int companyId, int officeId)
		{
			KassaService.<GetCashSaldo>d__5 <GetCashSaldo>d__;
			<GetCashSaldo>d__.<>t__builder = AsyncTaskMethodBuilder<decimal>.Create();
			<GetCashSaldo>d__.<>4__this = this;
			<GetCashSaldo>d__.period = period;
			<GetCashSaldo>d__.companyId = companyId;
			<GetCashSaldo>d__.officeId = officeId;
			<GetCashSaldo>d__.<>1__state = -1;
			<GetCashSaldo>d__.<>t__builder.Start<KassaService.<GetCashSaldo>d__5>(ref <GetCashSaldo>d__);
			return <GetCashSaldo>d__.<>t__builder.Task;
		}

		// Token: 0x06003711 RID: 14097 RVA: 0x000BC64C File Offset: 0x000BA84C
		public Task<decimal> GetCashlessSaldo(IPeriod period, int companyId, int officeId)
		{
			KassaService.<GetCashlessSaldo>d__6 <GetCashlessSaldo>d__;
			<GetCashlessSaldo>d__.<>t__builder = AsyncTaskMethodBuilder<decimal>.Create();
			<GetCashlessSaldo>d__.<>4__this = this;
			<GetCashlessSaldo>d__.period = period;
			<GetCashlessSaldo>d__.companyId = companyId;
			<GetCashlessSaldo>d__.officeId = officeId;
			<GetCashlessSaldo>d__.<>1__state = -1;
			<GetCashlessSaldo>d__.<>t__builder.Start<KassaService.<GetCashlessSaldo>d__6>(ref <GetCashlessSaldo>d__);
			return <GetCashlessSaldo>d__.<>t__builder.Task;
		}

		// Token: 0x06003712 RID: 14098 RVA: 0x000BC6A8 File Offset: 0x000BA8A8
		private Task<decimal> GetSaldo(IPeriod period, int companyId, int officeId, PaymentOptions.Systems paymentSystem)
		{
			KassaService.<GetSaldo>d__7 <GetSaldo>d__;
			<GetSaldo>d__.<>t__builder = AsyncTaskMethodBuilder<decimal>.Create();
			<GetSaldo>d__.period = period;
			<GetSaldo>d__.companyId = companyId;
			<GetSaldo>d__.officeId = officeId;
			<GetSaldo>d__.paymentSystem = paymentSystem;
			<GetSaldo>d__.<>1__state = -1;
			<GetSaldo>d__.<>t__builder.Start<KassaService.<GetSaldo>d__7>(ref <GetSaldo>d__);
			return <GetSaldo>d__.<>t__builder.Task;
		}

		// Token: 0x06003713 RID: 14099 RVA: 0x000BC704 File Offset: 0x000BA904
		public Task<CashInOrder> GetCashInOrderAsync(int orderId)
		{
			KassaService.<GetCashInOrderAsync>d__8 <GetCashInOrderAsync>d__;
			<GetCashInOrderAsync>d__.<>t__builder = AsyncTaskMethodBuilder<CashInOrder>.Create();
			<GetCashInOrderAsync>d__.orderId = orderId;
			<GetCashInOrderAsync>d__.<>1__state = -1;
			<GetCashInOrderAsync>d__.<>t__builder.Start<KassaService.<GetCashInOrderAsync>d__8>(ref <GetCashInOrderAsync>d__);
			return <GetCashInOrderAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06003714 RID: 14100 RVA: 0x000BC748 File Offset: 0x000BA948
		public Task<CashOutOrder> GetCashOutOrderAsync(int orderId)
		{
			KassaService.<GetCashOutOrderAsync>d__9 <GetCashOutOrderAsync>d__;
			<GetCashOutOrderAsync>d__.<>t__builder = AsyncTaskMethodBuilder<CashOutOrder>.Create();
			<GetCashOutOrderAsync>d__.orderId = orderId;
			<GetCashOutOrderAsync>d__.<>1__state = -1;
			<GetCashOutOrderAsync>d__.<>t__builder.Start<KassaService.<GetCashOutOrderAsync>d__9>(ref <GetCashOutOrderAsync>d__);
			return <GetCashOutOrderAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06003715 RID: 14101 RVA: 0x000BC78C File Offset: 0x000BA98C
		public Task<cash_orders> GetCashOrderAsync(int cashOrderId)
		{
			KassaService.<GetCashOrderAsync>d__10 <GetCashOrderAsync>d__;
			<GetCashOrderAsync>d__.<>t__builder = AsyncTaskMethodBuilder<cash_orders>.Create();
			<GetCashOrderAsync>d__.cashOrderId = cashOrderId;
			<GetCashOrderAsync>d__.<>1__state = -1;
			<GetCashOrderAsync>d__.<>t__builder.Start<KassaService.<GetCashOrderAsync>d__10>(ref <GetCashOrderAsync>d__);
			return <GetCashOrderAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06003716 RID: 14102 RVA: 0x000BC7D0 File Offset: 0x000BA9D0
		private static Expression<Func<CashOrdersLite, bool>> SearchCriteria(string searchQuery)
		{
			return (CashOrdersLite o) => searchQuery.Contains(o.id.ToString()) || o.ClientFirstName.Contains(searchQuery) || o.ClientLastName.Contains(searchQuery) || o.ClientPatronymic.Contains(searchQuery) || o.ClientUrName.Contains(searchQuery);
		}

		// Token: 0x06003717 RID: 14103 RVA: 0x000BC9D4 File Offset: 0x000BABD4
		private Expression<Func<CashOrdersLite, bool>> _Period2(IPeriod period)
		{
			DateTime from = period.From;
			DateTime to = period.To.Date.AddHours(23.0).AddMinutes(59.0).AddSeconds(59.0);
			return (CashOrdersLite o) => o.created >= from && o.created <= to;
		}

		// Token: 0x06003718 RID: 14104 RVA: 0x000BCAF8 File Offset: 0x000BACF8
		public Task<List<CashOrdersLite>> LoadOrdersAsync(int companyId, int office, Period period, int orderType, int paymentSystem, string searchQuery)
		{
			KassaService.<LoadOrdersAsync>d__13 <LoadOrdersAsync>d__;
			<LoadOrdersAsync>d__.<>t__builder = AsyncTaskMethodBuilder<List<CashOrdersLite>>.Create();
			<LoadOrdersAsync>d__.<>4__this = this;
			<LoadOrdersAsync>d__.companyId = companyId;
			<LoadOrdersAsync>d__.office = office;
			<LoadOrdersAsync>d__.period = period;
			<LoadOrdersAsync>d__.orderType = orderType;
			<LoadOrdersAsync>d__.paymentSystem = paymentSystem;
			<LoadOrdersAsync>d__.searchQuery = searchQuery;
			<LoadOrdersAsync>d__.<>1__state = -1;
			<LoadOrdersAsync>d__.<>t__builder.Start<KassaService.<LoadOrdersAsync>d__13>(ref <LoadOrdersAsync>d__);
			return <LoadOrdersAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06003719 RID: 14105 RVA: 0x000BCB70 File Offset: 0x000BAD70
		public Task<decimal> GetCashBalanceAsync(IPeriod period, int companyId, int officeId)
		{
			KassaService.<GetCashBalanceAsync>d__14 <GetCashBalanceAsync>d__;
			<GetCashBalanceAsync>d__.<>t__builder = AsyncTaskMethodBuilder<decimal>.Create();
			<GetCashBalanceAsync>d__.<>4__this = this;
			<GetCashBalanceAsync>d__.period = period;
			<GetCashBalanceAsync>d__.companyId = companyId;
			<GetCashBalanceAsync>d__.officeId = officeId;
			<GetCashBalanceAsync>d__.<>1__state = -1;
			<GetCashBalanceAsync>d__.<>t__builder.Start<KassaService.<GetCashBalanceAsync>d__14>(ref <GetCashBalanceAsync>d__);
			return <GetCashBalanceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600371A RID: 14106 RVA: 0x000BCBCC File Offset: 0x000BADCC
		public Task<decimal> GetCashLessBalanceAsync(IPeriod period, int companyId, int officeId)
		{
			KassaService.<GetCashLessBalanceAsync>d__15 <GetCashLessBalanceAsync>d__;
			<GetCashLessBalanceAsync>d__.<>t__builder = AsyncTaskMethodBuilder<decimal>.Create();
			<GetCashLessBalanceAsync>d__.<>4__this = this;
			<GetCashLessBalanceAsync>d__.period = period;
			<GetCashLessBalanceAsync>d__.companyId = companyId;
			<GetCashLessBalanceAsync>d__.officeId = officeId;
			<GetCashLessBalanceAsync>d__.<>1__state = -1;
			<GetCashLessBalanceAsync>d__.<>t__builder.Start<KassaService.<GetCashLessBalanceAsync>d__15>(ref <GetCashLessBalanceAsync>d__);
			return <GetCashLessBalanceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600371B RID: 14107 RVA: 0x000BCC28 File Offset: 0x000BAE28
		public Task<decimal> GetCardBalanceAsync(IPeriod period, int companyId, int officeId)
		{
			KassaService.<GetCardBalanceAsync>d__16 <GetCardBalanceAsync>d__;
			<GetCardBalanceAsync>d__.<>t__builder = AsyncTaskMethodBuilder<decimal>.Create();
			<GetCardBalanceAsync>d__.<>4__this = this;
			<GetCardBalanceAsync>d__.period = period;
			<GetCardBalanceAsync>d__.companyId = companyId;
			<GetCardBalanceAsync>d__.officeId = officeId;
			<GetCardBalanceAsync>d__.<>1__state = -1;
			<GetCardBalanceAsync>d__.<>t__builder.Start<KassaService.<GetCardBalanceAsync>d__16>(ref <GetCardBalanceAsync>d__);
			return <GetCardBalanceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04001FAF RID: 8111
		private readonly IContextFactory _contextFactory;

		// Token: 0x020005D3 RID: 1491
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x0600371C RID: 14108 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x04001FB0 RID: 8112
			public int companyId;

			// Token: 0x04001FB1 RID: 8113
			public int officeId;
		}

		// Token: 0x020005D4 RID: 1492
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_1
		{
			// Token: 0x0600371D RID: 14109 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass2_1()
			{
			}

			// Token: 0x04001FB2 RID: 8114
			public DateTime currentFrom;

			// Token: 0x04001FB3 RID: 8115
			public DateTime currentTo;
		}

		// Token: 0x020005D5 RID: 1493
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600371E RID: 14110 RVA: 0x000BCC84 File Offset: 0x000BAE84
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600371F RID: 14111 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06003720 RID: 14112 RVA: 0x000BCC9C File Offset: 0x000BAE9C
			internal string <LoadOrdersAsync>b__13_10(payment_systems p)
			{
				return p.name;
			}

			// Token: 0x04001FB4 RID: 8116
			public static readonly KassaService.<>c <>9 = new KassaService.<>c();

			// Token: 0x04001FB5 RID: 8117
			public static Func<payment_systems, string> <>9__13_10;
		}

		// Token: 0x020005D6 RID: 1494
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetThisMonthSaldo>d__2 : IAsyncStateMachine
		{
			// Token: 0x06003721 RID: 14113 RVA: 0x000BCCB0 File Offset: 0x000BAEB0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				KassaService kassaService = this.<>4__this;
				Saldo result9;
				try
				{
					KassaService.<>c__DisplayClass2_0 CS$<>8__locals1;
					if (num > 7)
					{
						CS$<>8__locals1 = new KassaService.<>c__DisplayClass2_0();
						CS$<>8__locals1.companyId = this.companyId;
						CS$<>8__locals1.officeId = this.officeId;
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
							goto IL_4D9;
						}
						case 2:
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<decimal>);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
							goto IL_5E8;
						}
						case 3:
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<decimal>);
							int num5 = -1;
							num = -1;
							this.<>1__state = num5;
							goto IL_6F7;
						}
						case 4:
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<decimal>);
							int num6 = -1;
							num = -1;
							this.<>1__state = num6;
							goto IL_806;
						}
						case 5:
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<decimal>);
							int num7 = -1;
							num = -1;
							this.<>1__state = num7;
							goto IL_915;
						}
						case 6:
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<decimal>);
							int num8 = -1;
							num = -1;
							this.<>1__state = num8;
							goto IL_A24;
						}
						case 7:
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<decimal>);
							int num9 = -1;
							num = -1;
							this.<>1__state = num9;
							goto IL_B33;
						}
						default:
						{
							KassaService.<>c__DisplayClass2_1 CS$<>8__locals2 = new KassaService.<>c__DisplayClass2_1();
							CS$<>8__locals2.currentFrom = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 1);
							CS$<>8__locals2.currentTo = DateTime.UtcNow.AddDays(1.0).AddSeconds(-1.0);
							this.<query>5__3 = from o in this.<ctx>5__2.cash_orders.AsNoTracking()
							where o.created >= CS$<>8__locals2.currentFrom && o.created <= CS$<>8__locals2.currentTo && o.type != 7
							select o;
							if (CS$<>8__locals1.companyId != 0)
							{
								this.<query>5__3 = from o in this.<query>5__3
								where o.company == CS$<>8__locals1.companyId
								select o;
							}
							if (CS$<>8__locals1.officeId != 0)
							{
								this.<query>5__3 = from o in this.<query>5__3
								where o.office == CS$<>8__locals1.officeId
								select o;
							}
							this.<>7__wrap11 = new Saldo();
							this.<>7__wrap3 = this.<>7__wrap11;
							awaiter = kassaService.SaldoSumAsync(this.<query>5__3, (cash_orders i) => i.summa > 0m && i.payment_system == 0).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num10 = 0;
								num = 0;
								this.<>1__state = num10;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, KassaService.<GetThisMonthSaldo>d__2>(ref awaiter, ref this);
								return;
							}
							break;
						}
						}
						decimal result = awaiter.GetResult();
						this.<>7__wrap3.ThisMonthInCash = result;
						this.<>7__wrap4 = this.<>7__wrap11;
						awaiter = kassaService.SaldoSumAsync(this.<query>5__3, (cash_orders i) => i.summa > 0m && i.payment_system == 1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num11 = 1;
							num = 1;
							this.<>1__state = num11;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, KassaService.<GetThisMonthSaldo>d__2>(ref awaiter, ref this);
							return;
						}
						IL_4D9:
						decimal result2 = awaiter.GetResult();
						this.<>7__wrap4.ThisMonthInCashless = result2;
						this.<>7__wrap5 = this.<>7__wrap11;
						awaiter = kassaService.SaldoSumAsync(this.<query>5__3, (cash_orders i) => i.summa > 0m && i.payment_system == -1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num12 = 2;
							num = 2;
							this.<>1__state = num12;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, KassaService.<GetThisMonthSaldo>d__2>(ref awaiter, ref this);
							return;
						}
						IL_5E8:
						decimal result3 = awaiter.GetResult();
						this.<>7__wrap5.ThisMonthInCard = result3;
						this.<>7__wrap6 = this.<>7__wrap11;
						awaiter = kassaService.SaldoSumAsync(this.<query>5__3, (cash_orders i) => i.summa > 0m && i.payment_system > 1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num13 = 3;
							num = 3;
							this.<>1__state = num13;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, KassaService.<GetThisMonthSaldo>d__2>(ref awaiter, ref this);
							return;
						}
						IL_6F7:
						decimal result4 = awaiter.GetResult();
						this.<>7__wrap6.ThisMonthInOther = result4;
						this.<>7__wrap7 = this.<>7__wrap11;
						awaiter = kassaService.SaldoSumAsync(this.<query>5__3, (cash_orders i) => i.summa < 0m && i.payment_system == 0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num14 = 4;
							num = 4;
							this.<>1__state = num14;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, KassaService.<GetThisMonthSaldo>d__2>(ref awaiter, ref this);
							return;
						}
						IL_806:
						decimal result5 = awaiter.GetResult();
						this.<>7__wrap7.ThisMonthOutCash = result5;
						this.<>7__wrap8 = this.<>7__wrap11;
						awaiter = kassaService.SaldoSumAsync(this.<query>5__3, (cash_orders i) => i.summa < 0m && i.payment_system == 1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num15 = 5;
							num = 5;
							this.<>1__state = num15;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, KassaService.<GetThisMonthSaldo>d__2>(ref awaiter, ref this);
							return;
						}
						IL_915:
						decimal result6 = awaiter.GetResult();
						this.<>7__wrap8.ThisMonthOutCashless = result6;
						this.<>7__wrap9 = this.<>7__wrap11;
						awaiter = kassaService.SaldoSumAsync(this.<query>5__3, (cash_orders i) => i.summa < 0m && i.payment_system == -1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num16 = 6;
							num = 6;
							this.<>1__state = num16;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, KassaService.<GetThisMonthSaldo>d__2>(ref awaiter, ref this);
							return;
						}
						IL_A24:
						decimal result7 = awaiter.GetResult();
						this.<>7__wrap9.ThisMonthOutCard = result7;
						this.<>7__wrap10 = this.<>7__wrap11;
						awaiter = kassaService.SaldoSumAsync(this.<query>5__3, (cash_orders i) => i.summa < 0m && i.payment_system > 1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num17 = 7;
							num = 7;
							this.<>1__state = num17;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, KassaService.<GetThisMonthSaldo>d__2>(ref awaiter, ref this);
							return;
						}
						IL_B33:
						decimal result8 = awaiter.GetResult();
						this.<>7__wrap10.ThisMonthOutOther = result8;
						Saldo saldo = this.<>7__wrap11;
						this.<>7__wrap3 = null;
						this.<>7__wrap4 = null;
						this.<>7__wrap5 = null;
						this.<>7__wrap6 = null;
						this.<>7__wrap7 = null;
						this.<>7__wrap8 = null;
						this.<>7__wrap9 = null;
						this.<>7__wrap10 = null;
						this.<>7__wrap11 = null;
						saldo.CalcTotal();
						result9 = saldo;
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
				this.<>t__builder.SetResult(result9);
			}

			// Token: 0x06003722 RID: 14114 RVA: 0x000BD8D0 File Offset: 0x000BBAD0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001FB6 RID: 8118
			public int <>1__state;

			// Token: 0x04001FB7 RID: 8119
			public AsyncTaskMethodBuilder<Saldo> <>t__builder;

			// Token: 0x04001FB8 RID: 8120
			public int companyId;

			// Token: 0x04001FB9 RID: 8121
			public int officeId;

			// Token: 0x04001FBA RID: 8122
			public KassaService <>4__this;

			// Token: 0x04001FBB RID: 8123
			private auseceEntities <ctx>5__2;

			// Token: 0x04001FBC RID: 8124
			private IQueryable<cash_orders> <query>5__3;

			// Token: 0x04001FBD RID: 8125
			private Saldo <>7__wrap3;

			// Token: 0x04001FBE RID: 8126
			private Saldo <>7__wrap4;

			// Token: 0x04001FBF RID: 8127
			private Saldo <>7__wrap5;

			// Token: 0x04001FC0 RID: 8128
			private Saldo <>7__wrap6;

			// Token: 0x04001FC1 RID: 8129
			private Saldo <>7__wrap7;

			// Token: 0x04001FC2 RID: 8130
			private Saldo <>7__wrap8;

			// Token: 0x04001FC3 RID: 8131
			private Saldo <>7__wrap9;

			// Token: 0x04001FC4 RID: 8132
			private Saldo <>7__wrap10;

			// Token: 0x04001FC5 RID: 8133
			private Saldo <>7__wrap11;

			// Token: 0x04001FC6 RID: 8134
			private TaskAwaiter<decimal> <>u__1;
		}

		// Token: 0x020005D7 RID: 1495
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SaldoSumAsync>d__3 : IAsyncStateMachine
		{
			// Token: 0x06003723 RID: 14115 RVA: 0x000BD8EC File Offset: 0x000BBAEC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				decimal result;
				try
				{
					ConfiguredTaskAwaitable<decimal>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = (from o in this.query.Where(this.filter)
						select o.summa).DefaultIfEmpty<decimal>().SumAsync().ConfigureAwait(false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<decimal>.ConfiguredTaskAwaiter, KassaService.<SaldoSumAsync>d__3>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(ConfiguredTaskAwaitable<decimal>.ConfiguredTaskAwaiter);
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

			// Token: 0x06003724 RID: 14116 RVA: 0x000BD9FC File Offset: 0x000BBBFC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001FC7 RID: 8135
			public int <>1__state;

			// Token: 0x04001FC8 RID: 8136
			public AsyncTaskMethodBuilder<decimal> <>t__builder;

			// Token: 0x04001FC9 RID: 8137
			public IQueryable<cash_orders> query;

			// Token: 0x04001FCA RID: 8138
			public Expression<Func<cash_orders, bool>> filter;

			// Token: 0x04001FCB RID: 8139
			private ConfiguredTaskAwaitable<decimal>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x020005D8 RID: 1496
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x06003725 RID: 14117 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x04001FCC RID: 8140
			public PaymentOptions.Systems paymentSystem;
		}

		// Token: 0x020005D9 RID: 1497
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCashSaldo>d__5 : IAsyncStateMachine
		{
			// Token: 0x06003726 RID: 14118 RVA: 0x000BDA18 File Offset: 0x000BBC18
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				KassaService kassaService = this.<>4__this;
				decimal result;
				try
				{
					TaskAwaiter<decimal> awaiter;
					if (num != 0)
					{
						awaiter = kassaService.GetSaldo(this.period, this.companyId, this.officeId, PaymentOptions.Systems.Cash).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, KassaService.<GetCashSaldo>d__5>(ref awaiter, ref this);
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

			// Token: 0x06003727 RID: 14119 RVA: 0x000BDAE4 File Offset: 0x000BBCE4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001FCD RID: 8141
			public int <>1__state;

			// Token: 0x04001FCE RID: 8142
			public AsyncTaskMethodBuilder<decimal> <>t__builder;

			// Token: 0x04001FCF RID: 8143
			public KassaService <>4__this;

			// Token: 0x04001FD0 RID: 8144
			public IPeriod period;

			// Token: 0x04001FD1 RID: 8145
			public int companyId;

			// Token: 0x04001FD2 RID: 8146
			public int officeId;

			// Token: 0x04001FD3 RID: 8147
			private TaskAwaiter<decimal> <>u__1;
		}

		// Token: 0x020005DA RID: 1498
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCashlessSaldo>d__6 : IAsyncStateMachine
		{
			// Token: 0x06003728 RID: 14120 RVA: 0x000BDB00 File Offset: 0x000BBD00
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				KassaService kassaService = this.<>4__this;
				decimal result;
				try
				{
					TaskAwaiter<decimal> awaiter;
					if (num != 0)
					{
						awaiter = kassaService.GetSaldo(this.period, this.companyId, this.officeId, PaymentOptions.Systems.CashLess).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, KassaService.<GetCashlessSaldo>d__6>(ref awaiter, ref this);
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

			// Token: 0x06003729 RID: 14121 RVA: 0x000BDBCC File Offset: 0x000BBDCC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001FD4 RID: 8148
			public int <>1__state;

			// Token: 0x04001FD5 RID: 8149
			public AsyncTaskMethodBuilder<decimal> <>t__builder;

			// Token: 0x04001FD6 RID: 8150
			public KassaService <>4__this;

			// Token: 0x04001FD7 RID: 8151
			public IPeriod period;

			// Token: 0x04001FD8 RID: 8152
			public int companyId;

			// Token: 0x04001FD9 RID: 8153
			public int officeId;

			// Token: 0x04001FDA RID: 8154
			private TaskAwaiter<decimal> <>u__1;
		}

		// Token: 0x020005DB RID: 1499
		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x0600372A RID: 14122 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x04001FDB RID: 8155
			public DateTime to;

			// Token: 0x04001FDC RID: 8156
			public PaymentOptions.Systems paymentSystem;

			// Token: 0x04001FDD RID: 8157
			public int companyId;

			// Token: 0x04001FDE RID: 8158
			public int officeId;
		}

		// Token: 0x020005DC RID: 1500
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetSaldo>d__7 : IAsyncStateMachine
		{
			// Token: 0x0600372B RID: 14123 RVA: 0x000BDBE8 File Offset: 0x000BBDE8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				decimal result;
				try
				{
					KassaService.<>c__DisplayClass7_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new KassaService.<>c__DisplayClass7_0();
						CS$<>8__locals1.paymentSystem = this.paymentSystem;
						CS$<>8__locals1.companyId = this.companyId;
						CS$<>8__locals1.officeId = this.officeId;
						CS$<>8__locals1.to = this.period.To.Date.AddDays(1.0).AddSeconds(-1.0);
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						ConfiguredTaskAwaitable<decimal>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							IQueryable<cash_orders> source = from o in this.<ctx>5__2.cash_orders
							where o.created <= CS$<>8__locals1.to && o.payment_system == (int)CS$<>8__locals1.paymentSystem
							select o;
							if (CS$<>8__locals1.companyId != 0)
							{
								source = from o in source
								where o.company == CS$<>8__locals1.companyId
								select o;
							}
							if (CS$<>8__locals1.officeId != 0)
							{
								source = from o in source
								where o.office == CS$<>8__locals1.officeId
								select o;
							}
							awaiter = source.SumAsync((cash_orders o) => o.summa).ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<decimal>.ConfiguredTaskAwaiter, KassaService.<GetSaldo>d__7>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<decimal>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
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

			// Token: 0x0600372C RID: 14124 RVA: 0x000BDF48 File Offset: 0x000BC148
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001FDF RID: 8159
			public int <>1__state;

			// Token: 0x04001FE0 RID: 8160
			public AsyncTaskMethodBuilder<decimal> <>t__builder;

			// Token: 0x04001FE1 RID: 8161
			public PaymentOptions.Systems paymentSystem;

			// Token: 0x04001FE2 RID: 8162
			public int companyId;

			// Token: 0x04001FE3 RID: 8163
			public int officeId;

			// Token: 0x04001FE4 RID: 8164
			public IPeriod period;

			// Token: 0x04001FE5 RID: 8165
			private auseceEntities <ctx>5__2;

			// Token: 0x04001FE6 RID: 8166
			private ConfiguredTaskAwaitable<decimal>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x020005DD RID: 1501
		[CompilerGenerated]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x0600372D RID: 14125 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x04001FE7 RID: 8167
			public int orderId;
		}

		// Token: 0x020005DE RID: 1502
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCashInOrderAsync>d__8 : IAsyncStateMachine
		{
			// Token: 0x0600372E RID: 14126 RVA: 0x000BDF64 File Offset: 0x000BC164
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CashInOrder result;
				try
				{
					KassaService.<>c__DisplayClass8_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new KassaService.<>c__DisplayClass8_0();
						CS$<>8__locals1.orderId = this.orderId;
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						ConfiguredTaskAwaitable<cash_orders>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = this.<ctx>5__2.cash_orders.AsNoTracking().Include((cash_orders i) => i.clients).Include((cash_orders i) => i.invoice1).Include((cash_orders i) => i.pinpad_logs).FirstOrDefaultAsync((cash_orders i) => i.id == CS$<>8__locals1.orderId).ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<cash_orders>.ConfiguredTaskAwaiter, KassaService.<GetCashInOrderAsync>d__8>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<cash_orders>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult().ToCashInOrder();
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

			// Token: 0x0600372F RID: 14127 RVA: 0x000BE1B8 File Offset: 0x000BC3B8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001FE8 RID: 8168
			public int <>1__state;

			// Token: 0x04001FE9 RID: 8169
			public AsyncTaskMethodBuilder<CashInOrder> <>t__builder;

			// Token: 0x04001FEA RID: 8170
			public int orderId;

			// Token: 0x04001FEB RID: 8171
			private auseceEntities <ctx>5__2;

			// Token: 0x04001FEC RID: 8172
			private ConfiguredTaskAwaitable<cash_orders>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x020005DF RID: 1503
		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x06003730 RID: 14128 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x04001FED RID: 8173
			public int orderId;
		}

		// Token: 0x020005E0 RID: 1504
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCashOutOrderAsync>d__9 : IAsyncStateMachine
		{
			// Token: 0x06003731 RID: 14129 RVA: 0x000BE1D4 File Offset: 0x000BC3D4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CashOutOrder result;
				try
				{
					KassaService.<>c__DisplayClass9_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new KassaService.<>c__DisplayClass9_0();
						CS$<>8__locals1.orderId = this.orderId;
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						ConfiguredTaskAwaitable<cash_orders>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = this.<ctx>5__2.cash_orders.AsNoTracking().Include((cash_orders i) => i.clients).Include((cash_orders i) => i.pinpad_logs).FirstOrDefaultAsync((cash_orders i) => i.id == CS$<>8__locals1.orderId).ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<cash_orders>.ConfiguredTaskAwaiter, KassaService.<GetCashOutOrderAsync>d__9>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<cash_orders>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult().ToCashOutOrder();
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

			// Token: 0x06003732 RID: 14130 RVA: 0x000BE3E4 File Offset: 0x000BC5E4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001FEE RID: 8174
			public int <>1__state;

			// Token: 0x04001FEF RID: 8175
			public AsyncTaskMethodBuilder<CashOutOrder> <>t__builder;

			// Token: 0x04001FF0 RID: 8176
			public int orderId;

			// Token: 0x04001FF1 RID: 8177
			private auseceEntities <ctx>5__2;

			// Token: 0x04001FF2 RID: 8178
			private ConfiguredTaskAwaitable<cash_orders>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x020005E1 RID: 1505
		[CompilerGenerated]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x06003733 RID: 14131 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x04001FF3 RID: 8179
			public int cashOrderId;
		}

		// Token: 0x020005E2 RID: 1506
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCashOrderAsync>d__10 : IAsyncStateMachine
		{
			// Token: 0x06003734 RID: 14132 RVA: 0x000BE400 File Offset: 0x000BC600
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				cash_orders result;
				try
				{
					KassaService.<>c__DisplayClass10_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new KassaService.<>c__DisplayClass10_0();
						CS$<>8__locals1.cashOrderId = this.cashOrderId;
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						ConfiguredTaskAwaitable<cash_orders>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = this.<ctx>5__2.cash_orders.AsNoTracking().Include((cash_orders i) => i.companies).Include((cash_orders i) => i.docs).Include((cash_orders i) => i.invoice1).FirstOrDefaultAsync((cash_orders i) => i.id == CS$<>8__locals1.cashOrderId).ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<cash_orders>.ConfiguredTaskAwaiter, KassaService.<GetCashOrderAsync>d__10>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<cash_orders>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
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

			// Token: 0x06003735 RID: 14133 RVA: 0x000BE64C File Offset: 0x000BC84C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001FF4 RID: 8180
			public int <>1__state;

			// Token: 0x04001FF5 RID: 8181
			public AsyncTaskMethodBuilder<cash_orders> <>t__builder;

			// Token: 0x04001FF6 RID: 8182
			public int cashOrderId;

			// Token: 0x04001FF7 RID: 8183
			private auseceEntities <ctx>5__2;

			// Token: 0x04001FF8 RID: 8184
			private ConfiguredTaskAwaitable<cash_orders>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x020005E3 RID: 1507
		[CompilerGenerated]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x06003736 RID: 14134 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass11_0()
			{
			}

			// Token: 0x04001FF9 RID: 8185
			public string searchQuery;
		}

		// Token: 0x020005E4 RID: 1508
		[CompilerGenerated]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x06003737 RID: 14135 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x04001FFA RID: 8186
			public DateTime from;

			// Token: 0x04001FFB RID: 8187
			public DateTime to;
		}

		// Token: 0x020005E5 RID: 1509
		[CompilerGenerated]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x06003738 RID: 14136 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass13_0()
			{
			}

			// Token: 0x04001FFC RID: 8188
			public int orderType;

			// Token: 0x04001FFD RID: 8189
			public int paymentSystem;

			// Token: 0x04001FFE RID: 8190
			public int companyId;

			// Token: 0x04001FFF RID: 8191
			public int office;
		}

		// Token: 0x020005E6 RID: 1510
		[CompilerGenerated]
		private sealed class <>c__DisplayClass13_1
		{
			// Token: 0x06003739 RID: 14137 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass13_1()
			{
			}

			// Token: 0x0600373A RID: 14138 RVA: 0x000BE668 File Offset: 0x000BC868
			internal bool <LoadOrdersAsync>b__9(payment_systems p)
			{
				return p.system_id == this.item.payment_system;
			}

			// Token: 0x04002000 RID: 8192
			public CashOrdersLite item;
		}

		// Token: 0x020005E7 RID: 1511
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadOrdersAsync>d__13 : IAsyncStateMachine
		{
			// Token: 0x0600373B RID: 14139 RVA: 0x000BE688 File Offset: 0x000BC888
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				KassaService kassaService = this.<>4__this;
				List<CashOrdersLite> result3;
				try
				{
					if (num > 1)
					{
						this.<>8__1 = new KassaService.<>c__DisplayClass13_0();
						this.<>8__1.orderType = this.orderType;
						this.<>8__1.paymentSystem = this.paymentSystem;
						this.<>8__1.companyId = this.companyId;
						this.<>8__1.office = this.office;
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						ConfiguredTaskAwaitable<List<CashOrdersLite>>.ConfiguredTaskAwaiter awaiter;
						ConfiguredTaskAwaitable<List<payment_systems>>.ConfiguredTaskAwaiter awaiter2;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = this.<>u__2;
								this.<>u__2 = default(ConfiguredTaskAwaitable<List<CashOrdersLite>>.ConfiguredTaskAwaiter);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								goto IL_580;
							}
							awaiter2 = (from i in this.<ctx>5__2.payment_systems
							where i.system_id > 1
							select i).ToListAsync<payment_systems>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num3 = 0;
								num = 0;
								this.<>1__state = num3;
								this.<>u__1 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<List<payment_systems>>.ConfiguredTaskAwaiter, KassaService.<LoadOrdersAsync>d__13>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<List<payment_systems>>.ConfiguredTaskAwaiter);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
						}
						List<payment_systems> result = awaiter2.GetResult();
						this.<paymentSystems>5__3 = result;
						IQueryable<CashOrdersLite> source = (from o in this.<ctx>5__2.cash_orders.AsNoTracking().Select(KassaModel.OrdersLite())
						orderby o.id
						select o).Where(kassaService._Period2(this.period));
						if (this.<>8__1.orderType != 7)
						{
							source = from o in source
							where o.type != 7
							select o;
						}
						if (this.<>8__1.orderType != 0)
						{
							if (this.<>8__1.orderType == -1)
							{
								source = from o in source
								where o.summa > 0m
								select o;
							}
							else if (this.<>8__1.orderType == -2)
							{
								source = from o in source
								where o.summa < 0m
								select o;
							}
							else
							{
								source = from o in source
								where o.type == this.<>8__1.orderType
								select o;
							}
						}
						if (this.<>8__1.paymentSystem != -100)
						{
							source = from o in source
							where o.payment_system == this.<>8__1.paymentSystem
							select o;
						}
						if (this.<>8__1.companyId != 0)
						{
							source = from o in source
							where o.CompanyId == this.<>8__1.companyId
							select o;
						}
						if (this.<>8__1.office != 0)
						{
							source = from o in source
							where o.OfficeId == this.<>8__1.office
							select o;
						}
						if (!string.IsNullOrEmpty(this.searchQuery))
						{
							source = source.Where(KassaService.SearchCriteria(this.searchQuery));
						}
						awaiter = source.ToListAsync<CashOrdersLite>().ConfigureAwait(false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num5 = 1;
							num = 1;
							this.<>1__state = num5;
							this.<>u__2 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<List<CashOrdersLite>>.ConfiguredTaskAwaiter, KassaService.<LoadOrdersAsync>d__13>(ref awaiter, ref this);
							return;
						}
						IL_580:
						List<CashOrdersLite> result2 = awaiter.GetResult();
						List<CashOrdersLite>.Enumerator enumerator = result2.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								KassaService.<>c__DisplayClass13_1 CS$<>8__locals1 = new KassaService.<>c__DisplayClass13_1();
								CS$<>8__locals1.item = enumerator.Current;
								if (CS$<>8__locals1.item.payment_system != 0 && CS$<>8__locals1.item.payment_system != 1)
								{
									CS$<>8__locals1.item.PaymentSystemName = this.<paymentSystems>5__3.Where(new Func<payment_systems, bool>(CS$<>8__locals1.<LoadOrdersAsync>b__9)).Select(new Func<payment_systems, string>(KassaService.<>c.<>9.<LoadOrdersAsync>b__13_10)).FirstOrDefault<string>();
								}
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)enumerator).Dispose();
							}
						}
						result3 = result2;
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
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult(result3);
			}

			// Token: 0x0600373C RID: 14140 RVA: 0x000BED70 File Offset: 0x000BCF70
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002001 RID: 8193
			public int <>1__state;

			// Token: 0x04002002 RID: 8194
			public AsyncTaskMethodBuilder<List<CashOrdersLite>> <>t__builder;

			// Token: 0x04002003 RID: 8195
			public int orderType;

			// Token: 0x04002004 RID: 8196
			public int paymentSystem;

			// Token: 0x04002005 RID: 8197
			public int companyId;

			// Token: 0x04002006 RID: 8198
			public int office;

			// Token: 0x04002007 RID: 8199
			public KassaService <>4__this;

			// Token: 0x04002008 RID: 8200
			public Period period;

			// Token: 0x04002009 RID: 8201
			private KassaService.<>c__DisplayClass13_0 <>8__1;

			// Token: 0x0400200A RID: 8202
			public string searchQuery;

			// Token: 0x0400200B RID: 8203
			private auseceEntities <ctx>5__2;

			// Token: 0x0400200C RID: 8204
			private List<payment_systems> <paymentSystems>5__3;

			// Token: 0x0400200D RID: 8205
			private ConfiguredTaskAwaitable<List<payment_systems>>.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x0400200E RID: 8206
			private ConfiguredTaskAwaitable<List<CashOrdersLite>>.ConfiguredTaskAwaiter <>u__2;
		}

		// Token: 0x020005E8 RID: 1512
		[CompilerGenerated]
		private sealed class <>c__DisplayClass14_0
		{
			// Token: 0x0600373D RID: 14141 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass14_0()
			{
			}

			// Token: 0x0400200F RID: 8207
			public DateTime to;

			// Token: 0x04002010 RID: 8208
			public int companyId;

			// Token: 0x04002011 RID: 8209
			public int officeId;
		}

		// Token: 0x020005E9 RID: 1513
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCashBalanceAsync>d__14 : IAsyncStateMachine
		{
			// Token: 0x0600373E RID: 14142 RVA: 0x000BED8C File Offset: 0x000BCF8C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				KassaService kassaService = this.<>4__this;
				decimal result;
				try
				{
					KassaService.<>c__DisplayClass14_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new KassaService.<>c__DisplayClass14_0();
						CS$<>8__locals1.companyId = this.companyId;
						CS$<>8__locals1.officeId = this.officeId;
						CS$<>8__locals1.to = this.period.To.Date.AddDays(1.0).AddSeconds(-1.0);
						this.<ctx>5__2 = kassaService._contextFactory.Create();
					}
					try
					{
						ConfiguredTaskAwaitable<decimal>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							IQueryable<cash_orders> source = from o in this.<ctx>5__2.cash_orders
							where o.created <= CS$<>8__locals1.to && o.payment_system == 0
							select o;
							if (CS$<>8__locals1.companyId != 0)
							{
								source = from o in source
								where o.company == CS$<>8__locals1.companyId
								select o;
							}
							if (CS$<>8__locals1.officeId != 0)
							{
								source = from o in source
								where o.office == CS$<>8__locals1.officeId
								select o;
							}
							awaiter = (from o in source
							select o.summa).DefaultIfEmpty<decimal>().SumAsync().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<decimal>.ConfiguredTaskAwaiter, KassaService.<GetCashBalanceAsync>d__14>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<decimal>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
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

			// Token: 0x0600373F RID: 14143 RVA: 0x000BF0E0 File Offset: 0x000BD2E0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002012 RID: 8210
			public int <>1__state;

			// Token: 0x04002013 RID: 8211
			public AsyncTaskMethodBuilder<decimal> <>t__builder;

			// Token: 0x04002014 RID: 8212
			public int companyId;

			// Token: 0x04002015 RID: 8213
			public int officeId;

			// Token: 0x04002016 RID: 8214
			public IPeriod period;

			// Token: 0x04002017 RID: 8215
			public KassaService <>4__this;

			// Token: 0x04002018 RID: 8216
			private auseceEntities <ctx>5__2;

			// Token: 0x04002019 RID: 8217
			private ConfiguredTaskAwaitable<decimal>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x020005EA RID: 1514
		[CompilerGenerated]
		private sealed class <>c__DisplayClass15_0
		{
			// Token: 0x06003740 RID: 14144 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass15_0()
			{
			}

			// Token: 0x0400201A RID: 8218
			public DateTime to;

			// Token: 0x0400201B RID: 8219
			public int companyId;

			// Token: 0x0400201C RID: 8220
			public int officeId;
		}

		// Token: 0x020005EB RID: 1515
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCashLessBalanceAsync>d__15 : IAsyncStateMachine
		{
			// Token: 0x06003741 RID: 14145 RVA: 0x000BF0FC File Offset: 0x000BD2FC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				KassaService kassaService = this.<>4__this;
				decimal result;
				try
				{
					KassaService.<>c__DisplayClass15_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new KassaService.<>c__DisplayClass15_0();
						CS$<>8__locals1.companyId = this.companyId;
						CS$<>8__locals1.officeId = this.officeId;
						CS$<>8__locals1.to = this.period.To.Date.AddDays(1.0).AddSeconds(-1.0);
						this.<ctx>5__2 = kassaService._contextFactory.Create();
					}
					try
					{
						ConfiguredTaskAwaitable<decimal>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							IQueryable<cash_orders> source = from o in this.<ctx>5__2.cash_orders
							where o.created <= CS$<>8__locals1.to && o.payment_system == 1
							select o;
							if (CS$<>8__locals1.companyId != 0)
							{
								source = from o in source
								where o.company == CS$<>8__locals1.companyId
								select o;
							}
							if (CS$<>8__locals1.officeId != 0)
							{
								source = from o in source
								where o.office == CS$<>8__locals1.officeId
								select o;
							}
							awaiter = (from o in source
							select o.summa).DefaultIfEmpty<decimal>().SumAsync().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<decimal>.ConfiguredTaskAwaiter, KassaService.<GetCashLessBalanceAsync>d__15>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<decimal>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
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

			// Token: 0x06003742 RID: 14146 RVA: 0x000BF450 File Offset: 0x000BD650
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400201D RID: 8221
			public int <>1__state;

			// Token: 0x0400201E RID: 8222
			public AsyncTaskMethodBuilder<decimal> <>t__builder;

			// Token: 0x0400201F RID: 8223
			public int companyId;

			// Token: 0x04002020 RID: 8224
			public int officeId;

			// Token: 0x04002021 RID: 8225
			public IPeriod period;

			// Token: 0x04002022 RID: 8226
			public KassaService <>4__this;

			// Token: 0x04002023 RID: 8227
			private auseceEntities <ctx>5__2;

			// Token: 0x04002024 RID: 8228
			private ConfiguredTaskAwaitable<decimal>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x020005EC RID: 1516
		[CompilerGenerated]
		private sealed class <>c__DisplayClass16_0
		{
			// Token: 0x06003743 RID: 14147 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass16_0()
			{
			}

			// Token: 0x04002025 RID: 8229
			public DateTime to;

			// Token: 0x04002026 RID: 8230
			public int companyId;

			// Token: 0x04002027 RID: 8231
			public int officeId;
		}

		// Token: 0x020005ED RID: 1517
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCardBalanceAsync>d__16 : IAsyncStateMachine
		{
			// Token: 0x06003744 RID: 14148 RVA: 0x000BF46C File Offset: 0x000BD66C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				KassaService kassaService = this.<>4__this;
				decimal result;
				try
				{
					KassaService.<>c__DisplayClass16_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new KassaService.<>c__DisplayClass16_0();
						CS$<>8__locals1.companyId = this.companyId;
						CS$<>8__locals1.officeId = this.officeId;
						CS$<>8__locals1.to = this.period.To.Date.AddDays(1.0).AddSeconds(-1.0);
						this.<ctx>5__2 = kassaService._contextFactory.Create();
					}
					try
					{
						ConfiguredTaskAwaitable<decimal>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							IQueryable<cash_orders> source = from o in this.<ctx>5__2.cash_orders
							where o.created <= CS$<>8__locals1.to && o.payment_system == -1
							select o;
							if (CS$<>8__locals1.companyId != 0)
							{
								source = from o in source
								where o.company == CS$<>8__locals1.companyId
								select o;
							}
							if (CS$<>8__locals1.officeId != 0)
							{
								source = from o in source
								where o.office == CS$<>8__locals1.officeId
								select o;
							}
							awaiter = (from o in source
							select o.summa).DefaultIfEmpty<decimal>().SumAsync().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<decimal>.ConfiguredTaskAwaiter, KassaService.<GetCardBalanceAsync>d__16>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<decimal>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
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

			// Token: 0x06003745 RID: 14149 RVA: 0x000BF7C0 File Offset: 0x000BD9C0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002028 RID: 8232
			public int <>1__state;

			// Token: 0x04002029 RID: 8233
			public AsyncTaskMethodBuilder<decimal> <>t__builder;

			// Token: 0x0400202A RID: 8234
			public int companyId;

			// Token: 0x0400202B RID: 8235
			public int officeId;

			// Token: 0x0400202C RID: 8236
			public IPeriod period;

			// Token: 0x0400202D RID: 8237
			public KassaService <>4__this;

			// Token: 0x0400202E RID: 8238
			private auseceEntities <ctx>5__2;

			// Token: 0x0400202F RID: 8239
			private ConfiguredTaskAwaitable<decimal>.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
