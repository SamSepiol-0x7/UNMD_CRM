using System;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using NLog;

namespace ASC.Models
{
	// Token: 0x0200094C RID: 2380
	public class DealerModel
	{
		// Token: 0x0600490E RID: 18702 RVA: 0x0011E3B8 File Offset: 0x0011C5B8
		public Task<int> GetReservedDealerItems(auseceEntities ctx, int dealerId)
		{
			return (from i in ctx.store_items
			where i.dealer == dealerId && i.is_realization
			select i.reserved).DefaultIfEmpty(0).SumAsync((int i) => i);
		}

		// Token: 0x0600490F RID: 18703 RVA: 0x0011E4C4 File Offset: 0x0011C6C4
		public Task<int> GetLockDealerItems(auseceEntities ctx, int dealerId)
		{
			return (from i in ctx.store_items
			where i.dealer == dealerId && i.is_realization
			select i.dealer_lock).DefaultIfEmpty<int>().SumAsync();
		}

		// Token: 0x06004910 RID: 18704 RVA: 0x0011E5A8 File Offset: 0x0011C7A8
		public Task<int> GetCanceledDealerItems(auseceEntities ctx, int dealerId)
		{
			return (from i in ctx.store_sales
			where i.dealer == dealerId && i.is_realization && i.docs.state == (int?)6
			select i.count).DefaultIfEmpty<int>().SumAsync();
		}

		// Token: 0x06004911 RID: 18705 RVA: 0x0011E6E4 File Offset: 0x0011C8E4
		public Task<int> GetNotSoldDealerItems(auseceEntities ctx, int dealerId)
		{
			return (from i in ctx.store_items
			where i.dealer == dealerId && i.is_realization
			select i.count).DefaultIfEmpty<int>().SumAsync();
		}

		// Token: 0x06004912 RID: 18706 RVA: 0x0011E7C8 File Offset: 0x0011C9C8
		public Task<decimal> GetSoldSummDealerItems(auseceEntities ctx, int dealerId)
		{
			return (from i in ctx.store_sales
			where i.docs.state == (int?)5 && i.dealer == dealerId && i.is_realization
			select (decimal)i.count * i.price).DefaultIfEmpty(0m).SumAsync();
		}

		// Token: 0x06004913 RID: 18707 RVA: 0x0011E940 File Offset: 0x0011CB40
		public Task<decimal> GetMonthSoldSummDealerItems(auseceEntities ctx, int dealerId)
		{
			return (from i in ctx.store_sales
			where i.docs.state == (int?)5 && i.dealer == dealerId && i.is_realization && i.docs.created.Year == DateTime.Now.Year && i.docs.created.Month >= DateTime.Now.Month && i.docs.created <= DateTime.Now
			select (decimal)i.count * i.price).DefaultIfEmpty(0m).SumAsync();
		}

		// Token: 0x06004914 RID: 18708 RVA: 0x0011EBF0 File Offset: 0x0011CDF0
		public Task<RealizatorStat> GetDealerStat(int dealerId)
		{
			DealerModel.<GetDealerStat>d__7 <GetDealerStat>d__;
			<GetDealerStat>d__.<>t__builder = AsyncTaskMethodBuilder<RealizatorStat>.Create();
			<GetDealerStat>d__.<>4__this = this;
			<GetDealerStat>d__.dealerId = dealerId;
			<GetDealerStat>d__.<>1__state = -1;
			<GetDealerStat>d__.<>t__builder.Start<DealerModel.<GetDealerStat>d__7>(ref <GetDealerStat>d__);
			return <GetDealerStat>d__.<>t__builder.Task;
		}

		// Token: 0x06004915 RID: 18709 RVA: 0x0011EC3C File Offset: 0x0011CE3C
		public Task<decimal> GetNotSoldSummDealerItems(auseceEntities ctx, int dealerId)
		{
			return (from i in ctx.store_items
			where i.dealer == dealerId && i.is_realization
			select (decimal)(i.count - i.sold) * i.in_price).DefaultIfEmpty(0m).SumAsync();
		}

		// Token: 0x06004916 RID: 18710 RVA: 0x0011ED78 File Offset: 0x0011CF78
		public Task<decimal> GetTotalDebtSummDealerItems(auseceEntities ctx, int dealerId)
		{
			DealerModel.<GetTotalDebtSummDealerItems>d__9 <GetTotalDebtSummDealerItems>d__;
			<GetTotalDebtSummDealerItems>d__.<>t__builder = AsyncTaskMethodBuilder<decimal>.Create();
			<GetTotalDebtSummDealerItems>d__.ctx = ctx;
			<GetTotalDebtSummDealerItems>d__.dealerId = dealerId;
			<GetTotalDebtSummDealerItems>d__.<>1__state = -1;
			<GetTotalDebtSummDealerItems>d__.<>t__builder.Start<DealerModel.<GetTotalDebtSummDealerItems>d__9>(ref <GetTotalDebtSummDealerItems>d__);
			return <GetTotalDebtSummDealerItems>d__.<>t__builder.Task;
		}

		// Token: 0x06004917 RID: 18711 RVA: 0x0011EDC4 File Offset: 0x0011CFC4
		public Task<decimal> GetIncomeSummDealerItems(auseceEntities ctx, int dealerId)
		{
			DealerModel.<GetIncomeSummDealerItems>d__10 <GetIncomeSummDealerItems>d__;
			<GetIncomeSummDealerItems>d__.<>t__builder = AsyncTaskMethodBuilder<decimal>.Create();
			<GetIncomeSummDealerItems>d__.ctx = ctx;
			<GetIncomeSummDealerItems>d__.dealerId = dealerId;
			<GetIncomeSummDealerItems>d__.<>1__state = -1;
			<GetIncomeSummDealerItems>d__.<>t__builder.Start<DealerModel.<GetIncomeSummDealerItems>d__10>(ref <GetIncomeSummDealerItems>d__);
			return <GetIncomeSummDealerItems>d__.<>t__builder.Task;
		}

		// Token: 0x06004918 RID: 18712 RVA: 0x0011EE10 File Offset: 0x0011D010
		public Task<decimal> GetMonthIncomeSummDealerItems(auseceEntities ctx, int dealerId)
		{
			DealerModel.<GetMonthIncomeSummDealerItems>d__11 <GetMonthIncomeSummDealerItems>d__;
			<GetMonthIncomeSummDealerItems>d__.<>t__builder = AsyncTaskMethodBuilder<decimal>.Create();
			<GetMonthIncomeSummDealerItems>d__.ctx = ctx;
			<GetMonthIncomeSummDealerItems>d__.dealerId = dealerId;
			<GetMonthIncomeSummDealerItems>d__.<>1__state = -1;
			<GetMonthIncomeSummDealerItems>d__.<>t__builder.Start<DealerModel.<GetMonthIncomeSummDealerItems>d__11>(ref <GetMonthIncomeSummDealerItems>d__);
			return <GetMonthIncomeSummDealerItems>d__.<>t__builder.Task;
		}

		// Token: 0x06004919 RID: 18713 RVA: 0x0011EE5C File Offset: 0x0011D05C
		public Task<int> GetSoldDealerItems(auseceEntities ctx, int dealerId, bool isPayed)
		{
			return (from i in ctx.store_sales
			where i.docs.state == (int?)5 && i.dealer == dealerId && i.is_realization && i.realizator_payed == isPayed
			select i.count).DefaultIfEmpty(0).SumAsync();
		}

		// Token: 0x0600491A RID: 18714 RVA: 0x000046B4 File Offset: 0x000028B4
		public DealerModel()
		{
		}

		// Token: 0x0600491B RID: 18715 RVA: 0x0011EFE0 File Offset: 0x0011D1E0
		// Note: this type is marked as 'beforefieldinit'.
		static DealerModel()
		{
		}

		// Token: 0x04002E7A RID: 11898
		private static readonly ILogger Log = LogManager.GetCurrentClassLogger();

		// Token: 0x0200094D RID: 2381
		[CompilerGenerated]
		private sealed class <>c__DisplayClass1_0
		{
			// Token: 0x0600491C RID: 18716 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass1_0()
			{
			}

			// Token: 0x04002E7B RID: 11899
			public int dealerId;
		}

		// Token: 0x0200094E RID: 2382
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600491D RID: 18717 RVA: 0x0011EFF8 File Offset: 0x0011D1F8
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600491E RID: 18718 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x04002E7C RID: 11900
			public static readonly DealerModel.<>c <>9 = new DealerModel.<>c();
		}

		// Token: 0x0200094F RID: 2383
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x0600491F RID: 18719 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x04002E7D RID: 11901
			public int dealerId;
		}

		// Token: 0x02000950 RID: 2384
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06004920 RID: 18720 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x04002E7E RID: 11902
			public int dealerId;
		}

		// Token: 0x02000951 RID: 2385
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x06004921 RID: 18721 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x04002E7F RID: 11903
			public int dealerId;
		}

		// Token: 0x02000952 RID: 2386
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06004922 RID: 18722 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x04002E80 RID: 11904
			public int dealerId;
		}

		// Token: 0x02000953 RID: 2387
		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x06004923 RID: 18723 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x04002E81 RID: 11905
			public int dealerId;
		}

		// Token: 0x02000954 RID: 2388
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetDealerStat>d__7 : IAsyncStateMachine
		{
			// Token: 0x06004924 RID: 18724 RVA: 0x0011F010 File Offset: 0x0011D210
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				DealerModel dealerModel = this.<>4__this;
				RealizatorStat result3;
				try
				{
					if (num > 11)
					{
						this.<result>5__2 = new RealizatorStat();
					}
					try
					{
						if (num > 11)
						{
							this.<ctx>5__3 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<int> awaiter;
							TaskAwaiter<decimal> awaiter2;
							switch (num)
							{
							case 0:
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<int>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								break;
							}
							case 1:
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<int>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
								goto IL_161;
							}
							case 2:
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<int>);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
								goto IL_1EC;
							}
							case 3:
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<int>);
								int num5 = -1;
								num = -1;
								this.<>1__state = num5;
								goto IL_276;
							}
							case 4:
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<int>);
								int num6 = -1;
								num = -1;
								this.<>1__state = num6;
								goto IL_300;
							}
							case 5:
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<int>);
								int num7 = -1;
								num = -1;
								this.<>1__state = num7;
								goto IL_38A;
							}
							case 6:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<decimal>);
								int num8 = -1;
								num = -1;
								this.<>1__state = num8;
								goto IL_41F;
							}
							case 7:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<decimal>);
								int num9 = -1;
								num = -1;
								this.<>1__state = num9;
								goto IL_4AB;
							}
							case 8:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<decimal>);
								int num10 = -1;
								num = -1;
								this.<>1__state = num10;
								goto IL_537;
							}
							case 9:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<decimal>);
								int num11 = -1;
								num = -1;
								this.<>1__state = num11;
								goto IL_5C5;
							}
							case 10:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<decimal>);
								int num12 = -1;
								num = -1;
								this.<>1__state = num12;
								goto IL_653;
							}
							case 11:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<decimal>);
								int num13 = -1;
								num = -1;
								this.<>1__state = num13;
								goto IL_6E1;
							}
							default:
								this.<>7__wrap3 = this.<result>5__2;
								awaiter = dealerModel.GetNotSoldDealerItems(this.<ctx>5__3, this.dealerId).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num14 = 0;
									num = 0;
									this.<>1__state = num14;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, DealerModel.<GetDealerStat>d__7>(ref awaiter, ref this);
									return;
								}
								break;
							}
							int result = awaiter.GetResult();
							this.<>7__wrap3.NotSoldItems = result;
							this.<>7__wrap3 = null;
							this.<>7__wrap3 = this.<result>5__2;
							awaiter = dealerModel.GetSoldDealerItems(this.<ctx>5__3, this.dealerId, false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num15 = 1;
								num = 1;
								this.<>1__state = num15;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, DealerModel.<GetDealerStat>d__7>(ref awaiter, ref this);
								return;
							}
							IL_161:
							result = awaiter.GetResult();
							this.<>7__wrap3.SoldItemsNotPayed = result;
							this.<>7__wrap3 = null;
							this.<>7__wrap3 = this.<result>5__2;
							awaiter = dealerModel.GetSoldDealerItems(this.<ctx>5__3, this.dealerId, true).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num16 = 2;
								num = 2;
								this.<>1__state = num16;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, DealerModel.<GetDealerStat>d__7>(ref awaiter, ref this);
								return;
							}
							IL_1EC:
							result = awaiter.GetResult();
							this.<>7__wrap3.SoldItemsPayed = result;
							this.<>7__wrap3 = null;
							this.<>7__wrap3 = this.<result>5__2;
							awaiter = dealerModel.GetReservedDealerItems(this.<ctx>5__3, this.dealerId).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num17 = 3;
								num = 3;
								this.<>1__state = num17;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, DealerModel.<GetDealerStat>d__7>(ref awaiter, ref this);
								return;
							}
							IL_276:
							result = awaiter.GetResult();
							this.<>7__wrap3.ReservedItems = result;
							this.<>7__wrap3 = null;
							this.<>7__wrap3 = this.<result>5__2;
							awaiter = dealerModel.GetLockDealerItems(this.<ctx>5__3, this.dealerId).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num18 = 4;
								num = 4;
								this.<>1__state = num18;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, DealerModel.<GetDealerStat>d__7>(ref awaiter, ref this);
								return;
							}
							IL_300:
							result = awaiter.GetResult();
							this.<>7__wrap3.LockItems = result;
							this.<>7__wrap3 = null;
							this.<>7__wrap3 = this.<result>5__2;
							awaiter = dealerModel.GetCanceledDealerItems(this.<ctx>5__3, this.dealerId).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num19 = 5;
								num = 5;
								this.<>1__state = num19;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, DealerModel.<GetDealerStat>d__7>(ref awaiter, ref this);
								return;
							}
							IL_38A:
							result = awaiter.GetResult();
							this.<>7__wrap3.Canceled = result;
							this.<>7__wrap3 = null;
							this.<result>5__2.CaclTotalItems();
							this.<>7__wrap3 = this.<result>5__2;
							awaiter2 = dealerModel.GetSoldSummDealerItems(this.<ctx>5__3, this.dealerId).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num20 = 6;
								num = 6;
								this.<>1__state = num20;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, DealerModel.<GetDealerStat>d__7>(ref awaiter2, ref this);
								return;
							}
							IL_41F:
							decimal result2 = awaiter2.GetResult();
							this.<>7__wrap3.SoldSumm = result2;
							this.<>7__wrap3 = null;
							this.<>7__wrap3 = this.<result>5__2;
							awaiter2 = dealerModel.GetMonthSoldSummDealerItems(this.<ctx>5__3, this.dealerId).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num21 = 7;
								num = 7;
								this.<>1__state = num21;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, DealerModel.<GetDealerStat>d__7>(ref awaiter2, ref this);
								return;
							}
							IL_4AB:
							result2 = awaiter2.GetResult();
							this.<>7__wrap3.MonthSoldSumm = result2;
							this.<>7__wrap3 = null;
							this.<>7__wrap3 = this.<result>5__2;
							awaiter2 = dealerModel.GetNotSoldSummDealerItems(this.<ctx>5__3, this.dealerId).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num22 = 8;
								num = 8;
								this.<>1__state = num22;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, DealerModel.<GetDealerStat>d__7>(ref awaiter2, ref this);
								return;
							}
							IL_537:
							result2 = awaiter2.GetResult();
							this.<>7__wrap3.NotSoldSumm = result2;
							this.<>7__wrap3 = null;
							this.<>7__wrap3 = this.<result>5__2;
							awaiter2 = dealerModel.GetTotalDebtSummDealerItems(this.<ctx>5__3, this.dealerId).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num23 = 9;
								num = 9;
								this.<>1__state = num23;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, DealerModel.<GetDealerStat>d__7>(ref awaiter2, ref this);
								return;
							}
							IL_5C5:
							result2 = awaiter2.GetResult();
							this.<>7__wrap3.TotalDebtSumm = result2;
							this.<>7__wrap3 = null;
							this.<>7__wrap3 = this.<result>5__2;
							awaiter2 = dealerModel.GetIncomeSummDealerItems(this.<ctx>5__3, this.dealerId).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num24 = 10;
								num = 10;
								this.<>1__state = num24;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, DealerModel.<GetDealerStat>d__7>(ref awaiter2, ref this);
								return;
							}
							IL_653:
							result2 = awaiter2.GetResult();
							this.<>7__wrap3.IncomeSumm = result2;
							this.<>7__wrap3 = null;
							this.<>7__wrap3 = this.<result>5__2;
							awaiter2 = dealerModel.GetMonthIncomeSummDealerItems(this.<ctx>5__3, this.dealerId).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num25 = 11;
								num = 11;
								this.<>1__state = num25;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, DealerModel.<GetDealerStat>d__7>(ref awaiter2, ref this);
								return;
							}
							IL_6E1:
							result2 = awaiter2.GetResult();
							this.<>7__wrap3.MonthIncomeSumm = result2;
							this.<>7__wrap3 = null;
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
					catch (Exception ex)
					{
						DealerModel.Log.Error(ex, ex.Message);
					}
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

			// Token: 0x06004925 RID: 18725 RVA: 0x0011F7E8 File Offset: 0x0011D9E8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002E82 RID: 11906
			public int <>1__state;

			// Token: 0x04002E83 RID: 11907
			public AsyncTaskMethodBuilder<RealizatorStat> <>t__builder;

			// Token: 0x04002E84 RID: 11908
			public DealerModel <>4__this;

			// Token: 0x04002E85 RID: 11909
			public int dealerId;

			// Token: 0x04002E86 RID: 11910
			private RealizatorStat <result>5__2;

			// Token: 0x04002E87 RID: 11911
			private auseceEntities <ctx>5__3;

			// Token: 0x04002E88 RID: 11912
			private RealizatorStat <>7__wrap3;

			// Token: 0x04002E89 RID: 11913
			private TaskAwaiter<int> <>u__1;

			// Token: 0x04002E8A RID: 11914
			private TaskAwaiter<decimal> <>u__2;
		}

		// Token: 0x02000955 RID: 2389
		[CompilerGenerated]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x06004926 RID: 18726 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x04002E8B RID: 11915
			public int dealerId;
		}

		// Token: 0x02000956 RID: 2390
		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x06004927 RID: 18727 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x04002E8C RID: 11916
			public int dealerId;
		}

		// Token: 0x02000957 RID: 2391
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetTotalDebtSummDealerItems>d__9 : IAsyncStateMachine
		{
			// Token: 0x06004928 RID: 18728 RVA: 0x0011F804 File Offset: 0x0011DA04
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				decimal result3;
				try
				{
					TaskAwaiter<decimal> awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<decimal>);
							this.<>1__state = -1;
							goto IL_477;
						}
						this.<>8__1 = new DealerModel.<>c__DisplayClass9_0();
						this.<>8__1.dealerId = this.dealerId;
						awaiter = (from i in this.ctx.store_sales
						where i.docs.state == (int?)5 && i.dealer == this.<>8__1.dealerId && i.is_realization && !i.realizator_payed && i.in_price > 0m
						select i.in_price * (decimal)i.count).DefaultIfEmpty(0m).SumAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, DealerModel.<GetTotalDebtSummDealerItems>d__9>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<decimal>);
						this.<>1__state = -1;
					}
					decimal result = awaiter.GetResult();
					this.<debt1>5__2 = result;
					awaiter = (from i in this.ctx.store_sales
					where i.docs.state == (int?)5 && i.dealer == this.<>8__1.dealerId && i.is_realization && !i.realizator_payed
					select i.price * (decimal)i.count / 100m * (decimal)i.return_percent).DefaultIfEmpty(0m).SumAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, DealerModel.<GetTotalDebtSummDealerItems>d__9>(ref awaiter, ref this);
						return;
					}
					IL_477:
					decimal result2 = awaiter.GetResult();
					result3 = this.<debt1>5__2 + result2;
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

			// Token: 0x06004929 RID: 18729 RVA: 0x0011FD18 File Offset: 0x0011DF18
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002E8D RID: 11917
			public int <>1__state;

			// Token: 0x04002E8E RID: 11918
			public AsyncTaskMethodBuilder<decimal> <>t__builder;

			// Token: 0x04002E8F RID: 11919
			public int dealerId;

			// Token: 0x04002E90 RID: 11920
			public auseceEntities ctx;

			// Token: 0x04002E91 RID: 11921
			private DealerModel.<>c__DisplayClass9_0 <>8__1;

			// Token: 0x04002E92 RID: 11922
			private decimal <debt1>5__2;

			// Token: 0x04002E93 RID: 11923
			private TaskAwaiter<decimal> <>u__1;
		}

		// Token: 0x02000958 RID: 2392
		[CompilerGenerated]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x0600492A RID: 18730 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x04002E94 RID: 11924
			public int dealerId;
		}

		// Token: 0x02000959 RID: 2393
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetIncomeSummDealerItems>d__10 : IAsyncStateMachine
		{
			// Token: 0x0600492B RID: 18731 RVA: 0x0011FD34 File Offset: 0x0011DF34
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				decimal result3;
				try
				{
					TaskAwaiter<decimal> awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<decimal>);
							this.<>1__state = -1;
							goto IL_53A;
						}
						this.<>8__1 = new DealerModel.<>c__DisplayClass10_0();
						this.<>8__1.dealerId = this.dealerId;
						awaiter = (from i in this.ctx.store_sales
						where i.docs.state == (int?)5 && i.dealer == this.<>8__1.dealerId && i.is_realization && i.in_price > 0m
						select i.price * (decimal)i.count - i.in_price * (decimal)i.count).DefaultIfEmpty(0m).SumAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, DealerModel.<GetIncomeSummDealerItems>d__10>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<decimal>);
						this.<>1__state = -1;
					}
					decimal result = awaiter.GetResult();
					this.<inc1>5__2 = result;
					awaiter = (from i in this.ctx.store_sales
					where i.docs.state == (int?)5 && i.dealer == this.<>8__1.dealerId && i.is_realization && i.in_price == 0m
					select (i.price * (decimal)i.count - i.in_price * (decimal)i.count) / 100m * (decimal)i.return_percent).DefaultIfEmpty(0m).SumAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, DealerModel.<GetIncomeSummDealerItems>d__10>(ref awaiter, ref this);
						return;
					}
					IL_53A:
					decimal result2 = awaiter.GetResult();
					result3 = this.<inc1>5__2 + result2;
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

			// Token: 0x0600492C RID: 18732 RVA: 0x001202EC File Offset: 0x0011E4EC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002E95 RID: 11925
			public int <>1__state;

			// Token: 0x04002E96 RID: 11926
			public AsyncTaskMethodBuilder<decimal> <>t__builder;

			// Token: 0x04002E97 RID: 11927
			public int dealerId;

			// Token: 0x04002E98 RID: 11928
			public auseceEntities ctx;

			// Token: 0x04002E99 RID: 11929
			private DealerModel.<>c__DisplayClass10_0 <>8__1;

			// Token: 0x04002E9A RID: 11930
			private decimal <inc1>5__2;

			// Token: 0x04002E9B RID: 11931
			private TaskAwaiter<decimal> <>u__1;
		}

		// Token: 0x0200095A RID: 2394
		[CompilerGenerated]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x0600492D RID: 18733 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass11_0()
			{
			}

			// Token: 0x04002E9C RID: 11932
			public int dealerId;
		}

		// Token: 0x0200095B RID: 2395
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetMonthIncomeSummDealerItems>d__11 : IAsyncStateMachine
		{
			// Token: 0x0600492E RID: 18734 RVA: 0x00120308 File Offset: 0x0011E508
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				decimal result3;
				try
				{
					TaskAwaiter<decimal> awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<decimal>);
							this.<>1__state = -1;
							goto IL_7AD;
						}
						this.<>8__1 = new DealerModel.<>c__DisplayClass11_0();
						this.<>8__1.dealerId = this.dealerId;
						awaiter = (from i in this.ctx.store_sales
						where i.docs.state == (int?)5 && i.dealer == this.<>8__1.dealerId && i.is_realization && i.in_price > 0m && i.docs.created.Year == DateTime.Now.Year && i.docs.created.Month >= DateTime.Now.Month && i.docs.created <= DateTime.Now
						select i.price * (decimal)i.count - i.in_price * (decimal)i.count).DefaultIfEmpty(0m).SumAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, DealerModel.<GetMonthIncomeSummDealerItems>d__11>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<decimal>);
						this.<>1__state = -1;
					}
					decimal result = awaiter.GetResult();
					this.<monthInc1>5__2 = result;
					awaiter = (from i in this.ctx.store_sales
					where i.docs.state == (int?)5 && i.dealer == this.<>8__1.dealerId && i.is_realization && i.in_price == 0m && i.docs.created.Year == DateTime.Now.Year && i.docs.created.Month >= DateTime.Now.Month && i.docs.created <= DateTime.Now
					select (i.price * (decimal)i.count - i.in_price * (decimal)i.count) / 100m * (decimal)i.return_percent).DefaultIfEmpty(0m).SumAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, DealerModel.<GetMonthIncomeSummDealerItems>d__11>(ref awaiter, ref this);
						return;
					}
					IL_7AD:
					decimal result2 = awaiter.GetResult();
					result3 = this.<monthInc1>5__2 + result2;
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

			// Token: 0x0600492F RID: 18735 RVA: 0x00120B30 File Offset: 0x0011ED30
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002E9D RID: 11933
			public int <>1__state;

			// Token: 0x04002E9E RID: 11934
			public AsyncTaskMethodBuilder<decimal> <>t__builder;

			// Token: 0x04002E9F RID: 11935
			public int dealerId;

			// Token: 0x04002EA0 RID: 11936
			public auseceEntities ctx;

			// Token: 0x04002EA1 RID: 11937
			private DealerModel.<>c__DisplayClass11_0 <>8__1;

			// Token: 0x04002EA2 RID: 11938
			private decimal <monthInc1>5__2;

			// Token: 0x04002EA3 RID: 11939
			private TaskAwaiter<decimal> <>u__1;
		}

		// Token: 0x0200095C RID: 2396
		[CompilerGenerated]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x06004930 RID: 18736 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x04002EA4 RID: 11940
			public int dealerId;

			// Token: 0x04002EA5 RID: 11941
			public bool isPayed;
		}
	}
}
