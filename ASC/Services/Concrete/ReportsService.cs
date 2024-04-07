using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.DAL;
using ASC.Services.Abstract;

namespace ASC.Services.Concrete
{
	// Token: 0x02000790 RID: 1936
	public class ReportsService : IReportsService
	{
		// Token: 0x06003B9B RID: 15259 RVA: 0x000EAD20 File Offset: 0x000E8F20
		public ReportsService(IContextFactory contextFactory)
		{
			this._contextFactory = contextFactory;
		}

		// Token: 0x06003B9C RID: 15260 RVA: 0x000EAD3C File Offset: 0x000E8F3C
		public Task<IList<cash_orders>> LoadWithdrawFundsTableData(IPeriod period, int officeId)
		{
			ReportsService.<LoadWithdrawFundsTableData>d__2 <LoadWithdrawFundsTableData>d__;
			<LoadWithdrawFundsTableData>d__.<>t__builder = AsyncTaskMethodBuilder<IList<cash_orders>>.Create();
			<LoadWithdrawFundsTableData>d__.<>4__this = this;
			<LoadWithdrawFundsTableData>d__.period = period;
			<LoadWithdrawFundsTableData>d__.officeId = officeId;
			<LoadWithdrawFundsTableData>d__.<>1__state = -1;
			<LoadWithdrawFundsTableData>d__.<>t__builder.Start<ReportsService.<LoadWithdrawFundsTableData>d__2>(ref <LoadWithdrawFundsTableData>d__);
			return <LoadWithdrawFundsTableData>d__.<>t__builder.Task;
		}

		// Token: 0x040026D0 RID: 9936
		private readonly IContextFactory _contextFactory;

		// Token: 0x02000791 RID: 1937
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x06003B9D RID: 15261 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x040026D1 RID: 9937
			public DateTime from;

			// Token: 0x040026D2 RID: 9938
			public DateTime to;

			// Token: 0x040026D3 RID: 9939
			public int officeId;
		}

		// Token: 0x02000792 RID: 1938
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003B9E RID: 15262 RVA: 0x000EAD90 File Offset: 0x000E8F90
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003B9F RID: 15263 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x040026D4 RID: 9940
			public static readonly ReportsService.<>c <>9 = new ReportsService.<>c();
		}

		// Token: 0x02000793 RID: 1939
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadWithdrawFundsTableData>d__2 : IAsyncStateMachine
		{
			// Token: 0x06003BA0 RID: 15264 RVA: 0x000EADA8 File Offset: 0x000E8FA8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ReportsService reportsService = this.<>4__this;
				IList<cash_orders> result;
				try
				{
					ReportsService.<>c__DisplayClass2_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new ReportsService.<>c__DisplayClass2_0();
						CS$<>8__locals1.officeId = this.officeId;
						CS$<>8__locals1.from = this.period.From.Date;
						CS$<>8__locals1.to = this.period.To.Date.AddDays(1.0).AddSeconds(-1.0);
						this.<ctx>5__2 = reportsService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<List<cash_orders>> awaiter;
						if (num != 0)
						{
							IQueryable<cash_orders> source = from o in this.<ctx>5__2.cash_orders.AsNoTracking().Include((cash_orders i) => i.users).Include((cash_orders i) => i.users1).Include((cash_orders i) => i.offices)
							where o.type == 7
							where o.created >= CS$<>8__locals1.@from && o.created <= CS$<>8__locals1.to
							select o;
							if (CS$<>8__locals1.officeId != 0)
							{
								source = from o in source
								where o.office == CS$<>8__locals1.officeId
								select o;
							}
							awaiter = source.ToListAsync<cash_orders>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<cash_orders>>, ReportsService.<LoadWithdrawFundsTableData>d__2>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<cash_orders>>);
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

			// Token: 0x06003BA1 RID: 15265 RVA: 0x000EB188 File Offset: 0x000E9388
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040026D5 RID: 9941
			public int <>1__state;

			// Token: 0x040026D6 RID: 9942
			public AsyncTaskMethodBuilder<IList<cash_orders>> <>t__builder;

			// Token: 0x040026D7 RID: 9943
			public int officeId;

			// Token: 0x040026D8 RID: 9944
			public IPeriod period;

			// Token: 0x040026D9 RID: 9945
			public ReportsService <>4__this;

			// Token: 0x040026DA RID: 9946
			private auseceEntities <ctx>5__2;

			// Token: 0x040026DB RID: 9947
			private TaskAwaiter<List<cash_orders>> <>u__1;
		}
	}
}
