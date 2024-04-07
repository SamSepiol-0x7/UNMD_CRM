using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.DAL;
using ASC.Services.Abstract;

namespace ASC.Services.Concrete
{
	// Token: 0x020006D2 RID: 1746
	public class AdditionalPaymentsService : IAdditionalPaymentsService
	{
		// Token: 0x06003969 RID: 14697 RVA: 0x000D5DA8 File Offset: 0x000D3FA8
		public AdditionalPaymentsService(IContextFactory contextFactory)
		{
			this._contextFactory = contextFactory;
		}

		// Token: 0x0600396A RID: 14698 RVA: 0x000D5DC4 File Offset: 0x000D3FC4
		public Task<IList<additional_payments>> ClearEmployeesProfit(int repairId)
		{
			AdditionalPaymentsService.<ClearEmployeesProfit>d__2 <ClearEmployeesProfit>d__;
			<ClearEmployeesProfit>d__.<>t__builder = AsyncTaskMethodBuilder<IList<additional_payments>>.Create();
			<ClearEmployeesProfit>d__.<>4__this = this;
			<ClearEmployeesProfit>d__.repairId = repairId;
			<ClearEmployeesProfit>d__.<>1__state = -1;
			<ClearEmployeesProfit>d__.<>t__builder.Start<AdditionalPaymentsService.<ClearEmployeesProfit>d__2>(ref <ClearEmployeesProfit>d__);
			return <ClearEmployeesProfit>d__.<>t__builder.Task;
		}

		// Token: 0x0600396B RID: 14699 RVA: 0x000D5E10 File Offset: 0x000D4010
		private Task<decimal> GetClearProfitSum(auseceEntities ctx, bool isQuickRepair, IGrouping<int, works> works)
		{
			AdditionalPaymentsService.<GetClearProfitSum>d__3 <GetClearProfitSum>d__;
			<GetClearProfitSum>d__.<>t__builder = AsyncTaskMethodBuilder<decimal>.Create();
			<GetClearProfitSum>d__.ctx = ctx;
			<GetClearProfitSum>d__.isQuickRepair = isQuickRepair;
			<GetClearProfitSum>d__.works = works;
			<GetClearProfitSum>d__.<>1__state = -1;
			<GetClearProfitSum>d__.<>t__builder.Start<AdditionalPaymentsService.<GetClearProfitSum>d__3>(ref <GetClearProfitSum>d__);
			return <GetClearProfitSum>d__.<>t__builder.Task;
		}

		// Token: 0x040023BA RID: 9146
		private readonly IContextFactory _contextFactory;

		// Token: 0x020006D3 RID: 1747
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x0600396C RID: 14700 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x040023BB RID: 9147
			public int repairId;

			// Token: 0x040023BC RID: 9148
			public AdditionalPaymentsService <>4__this;
		}

		// Token: 0x020006D4 RID: 1748
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_1
		{
			// Token: 0x0600396D RID: 14701 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass2_1()
			{
			}

			// Token: 0x0600396E RID: 14702 RVA: 0x000D5E64 File Offset: 0x000D4064
			internal void <ClearEmployeesProfit>b__0(IGrouping<int, works> i)
			{
				AdditionalPaymentsService.<>c__DisplayClass2_1.<<ClearEmployeesProfit>b__0>d <<ClearEmployeesProfit>b__0>d;
				<<ClearEmployeesProfit>b__0>d.<>t__builder = AsyncVoidMethodBuilder.Create();
				<<ClearEmployeesProfit>b__0>d.<>4__this = this;
				<<ClearEmployeesProfit>b__0>d.i = i;
				<<ClearEmployeesProfit>b__0>d.<>1__state = -1;
				<<ClearEmployeesProfit>b__0>d.<>t__builder.Start<AdditionalPaymentsService.<>c__DisplayClass2_1.<<ClearEmployeesProfit>b__0>d>(ref <<ClearEmployeesProfit>b__0>d);
			}

			// Token: 0x040023BD RID: 9149
			public auseceEntities ctx;

			// Token: 0x040023BE RID: 9150
			public bool isQuickRepair;

			// Token: 0x040023BF RID: 9151
			public List<additional_payments> result;

			// Token: 0x040023C0 RID: 9152
			public AdditionalPaymentsService.<>c__DisplayClass2_0 CS$<>8__locals1;

			// Token: 0x020006D5 RID: 1749
			[StructLayout(LayoutKind.Auto)]
			private struct <<ClearEmployeesProfit>b__0>d : IAsyncStateMachine
			{
				// Token: 0x0600396F RID: 14703 RVA: 0x000D5EA4 File Offset: 0x000D40A4
				void IAsyncStateMachine.MoveNext()
				{
					int num = this.<>1__state;
					AdditionalPaymentsService.<>c__DisplayClass2_1 CS$<>8__locals1 = this.<>4__this;
					try
					{
						TaskAwaiter<decimal> awaiter;
						if (num != 0)
						{
							awaiter = CS$<>8__locals1.CS$<>8__locals1.<>4__this.GetClearProfitSum(CS$<>8__locals1.ctx, CS$<>8__locals1.isQuickRepair, this.i).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, AdditionalPaymentsService.<>c__DisplayClass2_1.<<ClearEmployeesProfit>b__0>d>(ref awaiter, ref this);
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
						additional_payments additional_payments = new additional_payments
						{
							payment_date = Localization.GetServerUtcTime(CS$<>8__locals1.ctx),
							user = Auth.User.id,
							to_user = this.i.Key,
							price = -Math.Abs(result),
							name = string.Format("Возврат ремонта {0:d6}", CS$<>8__locals1.CS$<>8__locals1.repairId)
						};
						CS$<>8__locals1.ctx.additional_payments.Add(additional_payments);
						CS$<>8__locals1.result.Add(additional_payments);
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

				// Token: 0x06003970 RID: 14704 RVA: 0x000D6010 File Offset: 0x000D4210
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x040023C1 RID: 9153
				public int <>1__state;

				// Token: 0x040023C2 RID: 9154
				public AsyncVoidMethodBuilder <>t__builder;

				// Token: 0x040023C3 RID: 9155
				public AdditionalPaymentsService.<>c__DisplayClass2_1 <>4__this;

				// Token: 0x040023C4 RID: 9156
				public IGrouping<int, works> i;

				// Token: 0x040023C5 RID: 9157
				private TaskAwaiter<decimal> <>u__1;
			}
		}

		// Token: 0x020006D6 RID: 1750
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003971 RID: 14705 RVA: 0x000D602C File Offset: 0x000D422C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003972 RID: 14706 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06003973 RID: 14707 RVA: 0x000375D0 File Offset: 0x000357D0
			internal int <GetClearProfitSum>b__3_2(works i)
			{
				return i.id;
			}

			// Token: 0x06003974 RID: 14708 RVA: 0x000D6044 File Offset: 0x000D4244
			internal decimal <GetClearProfitSum>b__3_0(works j)
			{
				decimal d = j.price * j.count / 100m;
				int? pay_repair_quick = j.pay_repair_quick;
				return (d * ((pay_repair_quick != null) ? new decimal?(pay_repair_quick.GetValueOrDefault()) : null)).GetValueOrDefault();
			}

			// Token: 0x06003975 RID: 14709 RVA: 0x000D60D0 File Offset: 0x000D42D0
			internal decimal <GetClearProfitSum>b__3_1(works j)
			{
				decimal d = j.price * j.count / 100m;
				int? pay_repair = j.pay_repair;
				return (d * ((pay_repair != null) ? new decimal?(pay_repair.GetValueOrDefault()) : null)).GetValueOrDefault();
			}

			// Token: 0x040023C6 RID: 9158
			public static readonly AdditionalPaymentsService.<>c <>9 = new AdditionalPaymentsService.<>c();

			// Token: 0x040023C7 RID: 9159
			public static Func<works, int> <>9__3_2;

			// Token: 0x040023C8 RID: 9160
			public static Func<works, decimal> <>9__3_0;

			// Token: 0x040023C9 RID: 9161
			public static Func<works, decimal> <>9__3_1;
		}

		// Token: 0x020006D7 RID: 1751
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ClearEmployeesProfit>d__2 : IAsyncStateMachine
		{
			// Token: 0x06003976 RID: 14710 RVA: 0x000D615C File Offset: 0x000D435C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AdditionalPaymentsService additionalPaymentsService = this.<>4__this;
				IList<additional_payments> result;
				try
				{
					if (num > 3)
					{
						AdditionalPaymentsService.<>c__DisplayClass2_0 CS$<>8__locals1 = new AdditionalPaymentsService.<>c__DisplayClass2_0();
						CS$<>8__locals1.repairId = this.repairId;
						CS$<>8__locals1.<>4__this = this.<>4__this;
						this.<>8__1 = new AdditionalPaymentsService.<>c__DisplayClass2_1();
						this.<>8__1.CS$<>8__locals1 = CS$<>8__locals1;
						this.<>8__1.ctx = additionalPaymentsService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<bool> awaiter;
						TaskAwaiter<List<IGrouping<int, works>>> awaiter2;
						TaskAwaiter<int> awaiter3;
						switch (num)
						{
						case 0:
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<bool>);
							int num2 = -1;
							num = -1;
							this.<>1__state = num2;
							break;
						}
						case 1:
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<List<IGrouping<int, works>>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
							goto IL_31F;
						}
						case 2:
						{
							awaiter3 = this.<>u__3;
							this.<>u__3 = default(TaskAwaiter<int>);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
							goto IL_3AD;
						}
						case 3:
							IL_3CB:
							try
							{
								TaskAwaiter awaiter4;
								if (num == 3)
								{
									awaiter4 = this.<>u__4;
									this.<>u__4 = default(TaskAwaiter);
									int num5 = -1;
									num = -1;
									this.<>1__state = num5;
									goto IL_479;
								}
								IL_3F4:
								if (!this.<>7__wrap1.MoveNext())
								{
									goto IL_4C1;
								}
								additional_payments entity = this.<>7__wrap1.Current;
								awaiter4 = this.<>8__1.ctx.Entry<additional_payments>(entity).Reference<users>((additional_payments i) => i.users1).LoadAsync().GetAwaiter();
								if (!awaiter4.IsCompleted)
								{
									int num6 = 3;
									num = 3;
									this.<>1__state = num6;
									this.<>u__4 = awaiter4;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, AdditionalPaymentsService.<ClearEmployeesProfit>d__2>(ref awaiter4, ref this);
									return;
								}
								IL_479:
								awaiter4.GetResult();
								goto IL_3F4;
							}
							finally
							{
								if (num < 0)
								{
									((IDisposable)this.<>7__wrap1).Dispose();
								}
							}
							IL_4C1:
							this.<>7__wrap1 = default(List<additional_payments>.Enumerator);
							result = this.<>8__1.result;
							goto IL_516;
						default:
							awaiter = (from i in this.<>8__1.ctx.workshop
							where i.id == this.<>8__1.CS$<>8__locals1.repairId
							select i.quick_repair).SingleAsync<bool>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num7 = 0;
								num = 0;
								this.<>1__state = num7;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, AdditionalPaymentsService.<ClearEmployeesProfit>d__2>(ref awaiter, ref this);
								return;
							}
							break;
						}
						bool result2 = awaiter.GetResult();
						this.<>8__1.isQuickRepair = result2;
						awaiter2 = (from i in this.<>8__1.ctx.works.AsNoTracking().Include((works i) => i.users)
						where i.repair == (int?)this.<>8__1.CS$<>8__locals1.repairId
						group i by i.user).ToListAsync<IGrouping<int, works>>().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num8 = 1;
							num = 1;
							this.<>1__state = num8;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<IGrouping<int, works>>>, AdditionalPaymentsService.<ClearEmployeesProfit>d__2>(ref awaiter2, ref this);
							return;
						}
						IL_31F:
						List<IGrouping<int, works>> result3 = awaiter2.GetResult();
						this.<>8__1.result = new List<additional_payments>();
						result3.ForEach(new Action<IGrouping<int, works>>(this.<>8__1.<ClearEmployeesProfit>b__0));
						awaiter3 = this.<>8__1.ctx.SaveChangesAsync().GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							int num9 = 2;
							num = 2;
							this.<>1__state = num9;
							this.<>u__3 = awaiter3;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, AdditionalPaymentsService.<ClearEmployeesProfit>d__2>(ref awaiter3, ref this);
							return;
						}
						IL_3AD:
						awaiter3.GetResult();
						this.<>7__wrap1 = this.<>8__1.result.GetEnumerator();
						goto IL_3CB;
					}
					finally
					{
						if (num < 0 && this.<>8__1.ctx != null)
						{
							((IDisposable)this.<>8__1.ctx).Dispose();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_516:
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06003977 RID: 14711 RVA: 0x000D66E0 File Offset: 0x000D48E0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040023CA RID: 9162
			public int <>1__state;

			// Token: 0x040023CB RID: 9163
			public AsyncTaskMethodBuilder<IList<additional_payments>> <>t__builder;

			// Token: 0x040023CC RID: 9164
			public int repairId;

			// Token: 0x040023CD RID: 9165
			public AdditionalPaymentsService <>4__this;

			// Token: 0x040023CE RID: 9166
			private AdditionalPaymentsService.<>c__DisplayClass2_1 <>8__1;

			// Token: 0x040023CF RID: 9167
			private TaskAwaiter<bool> <>u__1;

			// Token: 0x040023D0 RID: 9168
			private TaskAwaiter<List<IGrouping<int, works>>> <>u__2;

			// Token: 0x040023D1 RID: 9169
			private TaskAwaiter<int> <>u__3;

			// Token: 0x040023D2 RID: 9170
			private List<additional_payments>.Enumerator <>7__wrap1;

			// Token: 0x040023D3 RID: 9171
			private TaskAwaiter <>u__4;
		}

		// Token: 0x020006D8 RID: 1752
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06003978 RID: 14712 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x06003979 RID: 14713 RVA: 0x000D66FC File Offset: 0x000D48FC
			internal decimal <GetClearProfitSum>b__3(works j)
			{
				decimal d = (j.price * j.count - this.partsSum) / 100m;
				int? pay_repair_quick = j.pay_repair_quick;
				return (d * ((pay_repair_quick != null) ? new decimal?(pay_repair_quick.GetValueOrDefault()) : null)).GetValueOrDefault();
			}

			// Token: 0x0600397A RID: 14714 RVA: 0x000D6794 File Offset: 0x000D4994
			internal decimal <GetClearProfitSum>b__4(works j)
			{
				decimal d = (j.price * j.count - this.partsSum) / 100m;
				int? pay_repair = j.pay_repair;
				return (d * ((pay_repair != null) ? new decimal?(pay_repair.GetValueOrDefault()) : null)).GetValueOrDefault();
			}

			// Token: 0x040023D4 RID: 9172
			public List<int> workIds;

			// Token: 0x040023D5 RID: 9173
			public decimal partsSum;
		}

		// Token: 0x020006D9 RID: 1753
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetClearProfitSum>d__3 : IAsyncStateMachine
		{
			// Token: 0x0600397B RID: 14715 RVA: 0x000D682C File Offset: 0x000D4A2C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				decimal result;
				try
				{
					TaskAwaiter<decimal> awaiter;
					if (num != 0)
					{
						if (!Auth.Config.parts_included)
						{
							decimal num2;
							if (!this.isQuickRepair)
							{
								num2 = this.works.Sum(new Func<works, decimal>(AdditionalPaymentsService.<>c.<>9.<GetClearProfitSum>b__3_1));
							}
							else
							{
								num2 = this.works.Sum(new Func<works, decimal>(AdditionalPaymentsService.<>c.<>9.<GetClearProfitSum>b__3_0));
							}
							result = num2;
							goto IL_359;
						}
						this.<>8__1 = new AdditionalPaymentsService.<>c__DisplayClass3_0();
						this.<>8__1.workIds = this.works.Select(new Func<works, int>(AdditionalPaymentsService.<>c.<>9.<GetClearProfitSum>b__3_2)).ToList<int>();
						awaiter = (from p in this.ctx.store_int_reserve
						where p.work_id != null && this.<>8__1.workIds.Contains(p.work_id.Value) && (p.state == 2 || p.state == 3)
						select (decimal)p.count * p.price).DefaultIfEmpty<decimal>().SumAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, AdditionalPaymentsService.<GetClearProfitSum>d__3>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<decimal>);
						this.<>1__state = -1;
					}
					decimal result2 = awaiter.GetResult();
					this.<>8__1.partsSum = result2;
					result = (this.isQuickRepair ? this.works.Sum(new Func<works, decimal>(this.<>8__1.<GetClearProfitSum>b__3)) : this.works.Sum(new Func<works, decimal>(this.<>8__1.<GetClearProfitSum>b__4)));
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_359:
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x0600397C RID: 14716 RVA: 0x000D6BC4 File Offset: 0x000D4DC4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040023D6 RID: 9174
			public int <>1__state;

			// Token: 0x040023D7 RID: 9175
			public AsyncTaskMethodBuilder<decimal> <>t__builder;

			// Token: 0x040023D8 RID: 9176
			public IGrouping<int, works> works;

			// Token: 0x040023D9 RID: 9177
			public auseceEntities ctx;

			// Token: 0x040023DA RID: 9178
			private AdditionalPaymentsService.<>c__DisplayClass3_0 <>8__1;

			// Token: 0x040023DB RID: 9179
			public bool isQuickRepair;

			// Token: 0x040023DC RID: 9180
			private TaskAwaiter<decimal> <>u__1;
		}
	}
}
