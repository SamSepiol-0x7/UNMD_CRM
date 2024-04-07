using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Interfaces;

namespace ASC.Services
{
	// Token: 0x0200064C RID: 1612
	public class CashOrderService : ICashOrderService
	{
		// Token: 0x06003827 RID: 14375 RVA: 0x000C8A54 File Offset: 0x000C6C54
		public Task<List<cash_orders>> GetCashOrders(IPeriod period, int paymentSystemId)
		{
			CashOrderService.<GetCashOrders>d__0 <GetCashOrders>d__;
			<GetCashOrders>d__.<>t__builder = AsyncTaskMethodBuilder<List<cash_orders>>.Create();
			<GetCashOrders>d__.period = period;
			<GetCashOrders>d__.paymentSystemId = paymentSystemId;
			<GetCashOrders>d__.<>1__state = -1;
			<GetCashOrders>d__.<>t__builder.Start<CashOrderService.<GetCashOrders>d__0>(ref <GetCashOrders>d__);
			return <GetCashOrders>d__.<>t__builder.Task;
		}

		// Token: 0x06003828 RID: 14376 RVA: 0x000046B4 File Offset: 0x000028B4
		public CashOrderService()
		{
		}

		// Token: 0x0200064D RID: 1613
		[CompilerGenerated]
		private sealed class <>c__DisplayClass0_0
		{
			// Token: 0x06003829 RID: 14377 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass0_0()
			{
			}

			// Token: 0x040021BA RID: 8634
			public int paymentSystemId;

			// Token: 0x040021BB RID: 8635
			public DateTime from;

			// Token: 0x040021BC RID: 8636
			public DateTime to;
		}

		// Token: 0x0200064E RID: 1614
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCashOrders>d__0 : IAsyncStateMachine
		{
			// Token: 0x0600382A RID: 14378 RVA: 0x000C8AA0 File Offset: 0x000C6CA0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<cash_orders> result;
				try
				{
					CashOrderService.<>c__DisplayClass0_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new CashOrderService.<>c__DisplayClass0_0();
						CS$<>8__locals1.paymentSystemId = this.paymentSystemId;
						CS$<>8__locals1.from = this.period.From.Date;
						CS$<>8__locals1.to = this.period.To.Date.AddHours(23.0).AddMinutes(59.0).AddSeconds(59.0);
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						ConfiguredTaskAwaitable<List<cash_orders>>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = (from o in this.<ctx>5__2.cash_orders.AsNoTracking()
							where o.type != 7 && o.payment_system == CS$<>8__locals1.paymentSystemId && o.created >= CS$<>8__locals1.@from && o.created <= CS$<>8__locals1.to
							select o).ToListAsync<cash_orders>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<List<cash_orders>>.ConfiguredTaskAwaiter, CashOrderService.<GetCashOrders>d__0>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<List<cash_orders>>.ConfiguredTaskAwaiter);
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

			// Token: 0x0600382B RID: 14379 RVA: 0x000C8D6C File Offset: 0x000C6F6C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040021BD RID: 8637
			public int <>1__state;

			// Token: 0x040021BE RID: 8638
			public AsyncTaskMethodBuilder<List<cash_orders>> <>t__builder;

			// Token: 0x040021BF RID: 8639
			public int paymentSystemId;

			// Token: 0x040021C0 RID: 8640
			public IPeriod period;

			// Token: 0x040021C1 RID: 8641
			private auseceEntities <ctx>5__2;

			// Token: 0x040021C2 RID: 8642
			private ConfiguredTaskAwaitable<List<cash_orders>>.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
