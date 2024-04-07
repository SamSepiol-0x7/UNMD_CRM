using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.DAL;
using ASC.Services.Abstract;

namespace ASC.Services.Concrete
{
	// Token: 0x02000766 RID: 1894
	public class PriceListService : IPriceListService
	{
		// Token: 0x06003B3E RID: 15166 RVA: 0x000E64F0 File Offset: 0x000E46F0
		public PriceListService(ILoggerService<PriceListService> loggerService, IContextFactory contextFactory)
		{
			this._loggerService = loggerService;
			this._contextFactory = contextFactory;
		}

		// Token: 0x06003B3F RID: 15167 RVA: 0x000E6514 File Offset: 0x000E4714
		public Task<workshop_price> GetItem(int optionId)
		{
			PriceListService.<GetItem>d__3 <GetItem>d__;
			<GetItem>d__.<>t__builder = AsyncTaskMethodBuilder<workshop_price>.Create();
			<GetItem>d__.<>4__this = this;
			<GetItem>d__.optionId = optionId;
			<GetItem>d__.<>1__state = -1;
			<GetItem>d__.<>t__builder.Start<PriceListService.<GetItem>d__3>(ref <GetItem>d__);
			return <GetItem>d__.<>t__builder.Task;
		}

		// Token: 0x06003B40 RID: 15168 RVA: 0x000E6560 File Offset: 0x000E4760
		public Task<int> CreateItem(workshop_price item)
		{
			PriceListService.<CreateItem>d__4 <CreateItem>d__;
			<CreateItem>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<CreateItem>d__.<>4__this = this;
			<CreateItem>d__.item = item;
			<CreateItem>d__.<>1__state = -1;
			<CreateItem>d__.<>t__builder.Start<PriceListService.<CreateItem>d__4>(ref <CreateItem>d__);
			return <CreateItem>d__.<>t__builder.Task;
		}

		// Token: 0x06003B41 RID: 15169 RVA: 0x000E65AC File Offset: 0x000E47AC
		public Task UpdateItem(workshop_price item)
		{
			PriceListService.<UpdateItem>d__5 <UpdateItem>d__;
			<UpdateItem>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<UpdateItem>d__.<>4__this = this;
			<UpdateItem>d__.item = item;
			<UpdateItem>d__.<>1__state = -1;
			<UpdateItem>d__.<>t__builder.Start<PriceListService.<UpdateItem>d__5>(ref <UpdateItem>d__);
			return <UpdateItem>d__.<>t__builder.Task;
		}

		// Token: 0x06003B42 RID: 15170 RVA: 0x000E65F8 File Offset: 0x000E47F8
		public string CheckFields(workshop_price item)
		{
			if (item.category == 0)
			{
				goto IL_42;
			}
			goto IL_7E;
			int num;
			for (;;)
			{
				IL_47:
				switch ((num ^ 714106821) % 7)
				{
				case 0:
					goto IL_7E;
				case 2:
					goto IL_42;
				case 3:
					goto IL_96;
				case 4:
					num = ((!(item.price1 == 0m)) ? 1569916406 : 639074337);
					continue;
				case 5:
					goto IL_A1;
				case 6:
					goto IL_AC;
				}
				break;
			}
			return "";
			IL_96:
			return Lang.t("InputCategory");
			IL_A1:
			return Lang.t("InputWorkName");
			IL_AC:
			return Lang.t("InputPrice");
			IL_42:
			num = 500743377;
			goto IL_47;
			IL_7E:
			num = ((!string.IsNullOrEmpty(item.name)) ? 616629061 : 1866144266);
			goto IL_47;
		}

		// Token: 0x06003B43 RID: 15171 RVA: 0x000E66BC File Offset: 0x000E48BC
		public Task<List<workshop_cats>> GetPriceCategories()
		{
			PriceListService.<GetPriceCategories>d__7 <GetPriceCategories>d__;
			<GetPriceCategories>d__.<>t__builder = AsyncTaskMethodBuilder<List<workshop_cats>>.Create();
			<GetPriceCategories>d__.<>4__this = this;
			<GetPriceCategories>d__.<>1__state = -1;
			<GetPriceCategories>d__.<>t__builder.Start<PriceListService.<GetPriceCategories>d__7>(ref <GetPriceCategories>d__);
			return <GetPriceCategories>d__.<>t__builder.Task;
		}

		// Token: 0x04002632 RID: 9778
		private readonly ILoggerService<PriceListService> _loggerService;

		// Token: 0x04002633 RID: 9779
		private readonly IContextFactory _contextFactory;

		// Token: 0x02000767 RID: 1895
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06003B44 RID: 15172 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x04002634 RID: 9780
			public int optionId;
		}

		// Token: 0x02000768 RID: 1896
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetItem>d__3 : IAsyncStateMachine
		{
			// Token: 0x06003B45 RID: 15173 RVA: 0x000E6700 File Offset: 0x000E4900
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PriceListService priceListService = this.<>4__this;
				workshop_price result;
				try
				{
					PriceListService.<>c__DisplayClass3_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new PriceListService.<>c__DisplayClass3_0();
						CS$<>8__locals1.optionId = this.optionId;
					}
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2 = priceListService._contextFactory.Create();
						}
						try
						{
							TaskAwaiter<workshop_price> awaiter;
							if (num != 0)
							{
								awaiter = this.<ctx>5__2.workshop_price.FirstOrDefaultAsync((workshop_price i) => i.id == CS$<>8__locals1.optionId).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop_price>, PriceListService.<GetItem>d__3>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<workshop_price>);
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
					catch (Exception ex)
					{
						priceListService._loggerService.Error(ex, ex.Message);
						throw;
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

			// Token: 0x06003B46 RID: 15174 RVA: 0x000E68C0 File Offset: 0x000E4AC0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002635 RID: 9781
			public int <>1__state;

			// Token: 0x04002636 RID: 9782
			public AsyncTaskMethodBuilder<workshop_price> <>t__builder;

			// Token: 0x04002637 RID: 9783
			public int optionId;

			// Token: 0x04002638 RID: 9784
			public PriceListService <>4__this;

			// Token: 0x04002639 RID: 9785
			private auseceEntities <ctx>5__2;

			// Token: 0x0400263A RID: 9786
			private TaskAwaiter<workshop_price> <>u__1;
		}

		// Token: 0x02000769 RID: 1897
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateItem>d__4 : IAsyncStateMachine
		{
			// Token: 0x06003B47 RID: 15175 RVA: 0x000E68DC File Offset: 0x000E4ADC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PriceListService priceListService = this.<>4__this;
				int id;
				try
				{
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2 = priceListService._contextFactory.Create();
						}
						try
						{
							TaskAwaiter<int> awaiter;
							if (num != 0)
							{
								this.<ctx>5__2.workshop_price.Attach(this.item);
								this.<ctx>5__2.Entry<workshop_price>(this.item).State = EntityState.Added;
								awaiter = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, PriceListService.<CreateItem>d__4>(ref awaiter, ref this);
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
							id = this.item.id;
						}
						finally
						{
							if (num < 0 && this.<ctx>5__2 != null)
							{
								((IDisposable)this.<ctx>5__2).Dispose();
							}
						}
					}
					catch (Exception ex)
					{
						priceListService._loggerService.Error(ex, ex.Message);
						throw;
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(id);
			}

			// Token: 0x06003B48 RID: 15176 RVA: 0x000E6A34 File Offset: 0x000E4C34
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400263B RID: 9787
			public int <>1__state;

			// Token: 0x0400263C RID: 9788
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x0400263D RID: 9789
			public PriceListService <>4__this;

			// Token: 0x0400263E RID: 9790
			public workshop_price item;

			// Token: 0x0400263F RID: 9791
			private auseceEntities <ctx>5__2;

			// Token: 0x04002640 RID: 9792
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x0200076A RID: 1898
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateItem>d__5 : IAsyncStateMachine
		{
			// Token: 0x06003B49 RID: 15177 RVA: 0x000E6A50 File Offset: 0x000E4C50
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PriceListService priceListService = this.<>4__this;
				try
				{
					try
					{
						if (num > 1)
						{
							this.<ctx>5__2 = priceListService._contextFactory.Create();
						}
						try
						{
							TaskAwaiter<int> awaiter;
							TaskAwaiter<workshop_price> awaiter2;
							if (num != 0)
							{
								if (num == 1)
								{
									awaiter = this.<>u__2;
									this.<>u__2 = default(TaskAwaiter<int>);
									int num2 = -1;
									num = -1;
									this.<>1__state = num2;
									goto IL_107;
								}
								awaiter2 = this.<ctx>5__2.workshop_price.FindAsync(new object[]
								{
									this.item.id
								}).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									int num3 = 0;
									num = 0;
									this.<>1__state = num3;
									this.<>u__1 = awaiter2;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop_price>, PriceListService.<UpdateItem>d__5>(ref awaiter2, ref this);
									return;
								}
							}
							else
							{
								awaiter2 = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<workshop_price>);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
							}
							workshop_price result = awaiter2.GetResult();
							this.<ctx>5__2.Entry<workshop_price>(result).CurrentValues.SetValues(this.item);
							awaiter = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num5 = 1;
								num = 1;
								this.<>1__state = num5;
								this.<>u__2 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, PriceListService.<UpdateItem>d__5>(ref awaiter, ref this);
								return;
							}
							IL_107:
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
						priceListService._loggerService.Error(ex, ex.Message);
						throw;
					}
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

			// Token: 0x06003B4A RID: 15178 RVA: 0x000E6C44 File Offset: 0x000E4E44
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002641 RID: 9793
			public int <>1__state;

			// Token: 0x04002642 RID: 9794
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002643 RID: 9795
			public PriceListService <>4__this;

			// Token: 0x04002644 RID: 9796
			public workshop_price item;

			// Token: 0x04002645 RID: 9797
			private auseceEntities <ctx>5__2;

			// Token: 0x04002646 RID: 9798
			private TaskAwaiter<workshop_price> <>u__1;

			// Token: 0x04002647 RID: 9799
			private TaskAwaiter<int> <>u__2;
		}

		// Token: 0x0200076B RID: 1899
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetPriceCategories>d__7 : IAsyncStateMachine
		{
			// Token: 0x06003B4B RID: 15179 RVA: 0x000E6C60 File Offset: 0x000E4E60
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PriceListService priceListService = this.<>4__this;
				List<workshop_cats> result;
				try
				{
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2 = priceListService._contextFactory.Create();
						}
						try
						{
							TaskAwaiter<List<workshop_cats>> awaiter;
							if (num != 0)
							{
								awaiter = this.<ctx>5__2.workshop_cats.ToListAsync<workshop_cats>().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<workshop_cats>>, PriceListService.<GetPriceCategories>d__7>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<List<workshop_cats>>);
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
					catch (Exception ex)
					{
						priceListService._loggerService.Error(ex, ex.Message);
						result = new List<workshop_cats>();
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

			// Token: 0x06003B4C RID: 15180 RVA: 0x000E6D88 File Offset: 0x000E4F88
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002648 RID: 9800
			public int <>1__state;

			// Token: 0x04002649 RID: 9801
			public AsyncTaskMethodBuilder<List<workshop_cats>> <>t__builder;

			// Token: 0x0400264A RID: 9802
			public PriceListService <>4__this;

			// Token: 0x0400264B RID: 9803
			private auseceEntities <ctx>5__2;

			// Token: 0x0400264C RID: 9804
			private TaskAwaiter<List<workshop_cats>> <>u__1;
		}
	}
}
