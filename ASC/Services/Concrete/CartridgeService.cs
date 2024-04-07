using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.DAL;
using ASC.Models;
using ASC.Objects;
using ASC.Objects.Converters;
using ASC.Services.Abstract;
using Autofac;

namespace ASC.Services.Concrete
{
	// Token: 0x020006FC RID: 1788
	public class CartridgeService : ICartridgeService
	{
		// Token: 0x060039D3 RID: 14803 RVA: 0x000D9D1C File Offset: 0x000D7F1C
		public CartridgeService(ILoggerService<CartridgeService> loggerService, IOfficeService officeService, IContextFactory contextFactory)
		{
			this._loggerService = loggerService;
			this._officeService = officeService;
			this._contextFactory = contextFactory;
		}

		// Token: 0x060039D4 RID: 14804 RVA: 0x000D9D44 File Offset: 0x000D7F44
		public Dictionary<int, string> GetHistoryOptions()
		{
			return new Dictionary<int, string>
			{
				{
					1,
					Lang.t("WarrantyRepair")
				},
				{
					2,
					Lang.t("WasInService")
				}
			};
		}

		// Token: 0x060039D5 RID: 14805 RVA: 0x000D9D78 File Offset: 0x000D7F78
		public Task UpdateBox(int cartridgeId, int? boxId)
		{
			CartridgeService.<UpdateBox>d__5 <UpdateBox>d__;
			<UpdateBox>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<UpdateBox>d__.<>4__this = this;
			<UpdateBox>d__.cartridgeId = cartridgeId;
			<UpdateBox>d__.boxId = boxId;
			<UpdateBox>d__.<>1__state = -1;
			<UpdateBox>d__.<>t__builder.Start<CartridgeService.<UpdateBox>d__5>(ref <UpdateBox>d__);
			return <UpdateBox>d__.<>t__builder.Task;
		}

		// Token: 0x060039D6 RID: 14806 RVA: 0x000D9DCC File Offset: 0x000D7FCC
		public Task<List<Cartridge>> GetCartridges(List<int> ids)
		{
			CartridgeService.<GetCartridges>d__6 <GetCartridges>d__;
			<GetCartridges>d__.<>t__builder = AsyncTaskMethodBuilder<List<Cartridge>>.Create();
			<GetCartridges>d__.<>4__this = this;
			<GetCartridges>d__.ids = ids;
			<GetCartridges>d__.<>1__state = -1;
			<GetCartridges>d__.<>t__builder.Start<CartridgeService.<GetCartridges>d__6>(ref <GetCartridges>d__);
			return <GetCartridges>d__.<>t__builder.Task;
		}

		// Token: 0x060039D7 RID: 14807 RVA: 0x000D9E18 File Offset: 0x000D8018
		public Task<List<CartridgeEx>> GetCartridgesEx(List<int> ids)
		{
			CartridgeService.<GetCartridgesEx>d__7 <GetCartridgesEx>d__;
			<GetCartridgesEx>d__.<>t__builder = AsyncTaskMethodBuilder<List<CartridgeEx>>.Create();
			<GetCartridgesEx>d__.<>4__this = this;
			<GetCartridgesEx>d__.ids = ids;
			<GetCartridgesEx>d__.<>1__state = -1;
			<GetCartridgesEx>d__.<>t__builder.Start<CartridgeService.<GetCartridgesEx>d__7>(ref <GetCartridgesEx>d__);
			return <GetCartridgesEx>d__.<>t__builder.Task;
		}

		// Token: 0x060039D8 RID: 14808 RVA: 0x000D9E64 File Offset: 0x000D8064
		public Task<CartridgeReport> GetCartgidgesReport(int companyId, int officeId, int customerId, List<int> ids)
		{
			CartridgeService.<GetCartgidgesReport>d__8 <GetCartgidgesReport>d__;
			<GetCartgidgesReport>d__.<>t__builder = AsyncTaskMethodBuilder<CartridgeReport>.Create();
			<GetCartgidgesReport>d__.<>4__this = this;
			<GetCartgidgesReport>d__.companyId = companyId;
			<GetCartgidgesReport>d__.officeId = officeId;
			<GetCartgidgesReport>d__.customerId = customerId;
			<GetCartgidgesReport>d__.ids = ids;
			<GetCartgidgesReport>d__.<>1__state = -1;
			<GetCartgidgesReport>d__.<>t__builder.Start<CartridgeService.<GetCartgidgesReport>d__8>(ref <GetCartgidgesReport>d__);
			return <GetCartgidgesReport>d__.<>t__builder.Task;
		}

		// Token: 0x060039D9 RID: 14809 RVA: 0x000D9EC8 File Offset: 0x000D80C8
		public Task<CartridgeReport> GetCartgidgeReport(int repairId)
		{
			CartridgeService.<GetCartgidgeReport>d__9 <GetCartgidgeReport>d__;
			<GetCartgidgeReport>d__.<>t__builder = AsyncTaskMethodBuilder<CartridgeReport>.Create();
			<GetCartgidgeReport>d__.<>4__this = this;
			<GetCartgidgeReport>d__.repairId = repairId;
			<GetCartgidgeReport>d__.<>1__state = -1;
			<GetCartgidgeReport>d__.<>t__builder.Start<CartridgeService.<GetCartgidgeReport>d__9>(ref <GetCartgidgeReport>d__);
			return <GetCartgidgeReport>d__.<>t__builder.Task;
		}

		// Token: 0x060039DA RID: 14810 RVA: 0x000D9F14 File Offset: 0x000D8114
		public Task<CartridgeIssueReport> GetIssueCartridgeReport(List<int> ids)
		{
			CartridgeService.<GetIssueCartridgeReport>d__10 <GetIssueCartridgeReport>d__;
			<GetIssueCartridgeReport>d__.<>t__builder = AsyncTaskMethodBuilder<CartridgeIssueReport>.Create();
			<GetIssueCartridgeReport>d__.<>4__this = this;
			<GetIssueCartridgeReport>d__.ids = ids;
			<GetIssueCartridgeReport>d__.<>1__state = -1;
			<GetIssueCartridgeReport>d__.<>t__builder.Start<CartridgeService.<GetIssueCartridgeReport>d__10>(ref <GetIssueCartridgeReport>d__);
			return <GetIssueCartridgeReport>d__.<>t__builder.Task;
		}

		// Token: 0x060039DB RID: 14811 RVA: 0x000D9F60 File Offset: 0x000D8160
		public Task<CartridgeIssueReport> GetIssueCartridgeReport(int repairId)
		{
			CartridgeService.<GetIssueCartridgeReport>d__11 <GetIssueCartridgeReport>d__;
			<GetIssueCartridgeReport>d__.<>t__builder = AsyncTaskMethodBuilder<CartridgeIssueReport>.Create();
			<GetIssueCartridgeReport>d__.<>4__this = this;
			<GetIssueCartridgeReport>d__.repairId = repairId;
			<GetIssueCartridgeReport>d__.<>1__state = -1;
			<GetIssueCartridgeReport>d__.<>t__builder.Start<CartridgeService.<GetIssueCartridgeReport>d__11>(ref <GetIssueCartridgeReport>d__);
			return <GetIssueCartridgeReport>d__.<>t__builder.Task;
		}

		// Token: 0x060039DC RID: 14812 RVA: 0x000D9FAC File Offset: 0x000D81AC
		public Task<Cartridge> GetCartridge(int id)
		{
			CartridgeService.<GetCartridge>d__12 <GetCartridge>d__;
			<GetCartridge>d__.<>t__builder = AsyncTaskMethodBuilder<Cartridge>.Create();
			<GetCartridge>d__.<>4__this = this;
			<GetCartridge>d__.id = id;
			<GetCartridge>d__.<>1__state = -1;
			<GetCartridge>d__.<>t__builder.Start<CartridgeService.<GetCartridge>d__12>(ref <GetCartridge>d__);
			return <GetCartridge>d__.<>t__builder.Task;
		}

		// Token: 0x060039DD RID: 14813 RVA: 0x000D9FF8 File Offset: 0x000D81F8
		public Task<Cartridge> GetCartridge(string serialNumber)
		{
			CartridgeService.<GetCartridge>d__13 <GetCartridge>d__;
			<GetCartridge>d__.<>t__builder = AsyncTaskMethodBuilder<Cartridge>.Create();
			<GetCartridge>d__.<>4__this = this;
			<GetCartridge>d__.serialNumber = serialNumber;
			<GetCartridge>d__.<>1__state = -1;
			<GetCartridge>d__.<>t__builder.Start<CartridgeService.<GetCartridge>d__13>(ref <GetCartridge>d__);
			return <GetCartridge>d__.<>t__builder.Task;
		}

		// Token: 0x060039DE RID: 14814 RVA: 0x000DA044 File Offset: 0x000D8244
		public Task<Result> CreateCartridges(IEnumerable<Cartridge> cartridges, int companyId, int officeId, int paymentSystem, int customerId, int? masterId)
		{
			CartridgeService.<CreateCartridges>d__14 <CreateCartridges>d__;
			<CreateCartridges>d__.<>t__builder = AsyncTaskMethodBuilder<Result>.Create();
			<CreateCartridges>d__.cartridges = cartridges;
			<CreateCartridges>d__.companyId = companyId;
			<CreateCartridges>d__.officeId = officeId;
			<CreateCartridges>d__.paymentSystem = paymentSystem;
			<CreateCartridges>d__.customerId = customerId;
			<CreateCartridges>d__.masterId = masterId;
			<CreateCartridges>d__.<>1__state = -1;
			<CreateCartridges>d__.<>t__builder.Start<CartridgeService.<CreateCartridges>d__14>(ref <CreateCartridges>d__);
			return <CreateCartridges>d__.<>t__builder.Task;
		}

		// Token: 0x060039DF RID: 14815 RVA: 0x000DA0B4 File Offset: 0x000D82B4
		public Task<Result> IssueCartridges(IEnumerable<CartridgeEx> cartridges, int paymentSystem)
		{
			CartridgeService.<IssueCartridges>d__15 <IssueCartridges>d__;
			<IssueCartridges>d__.<>t__builder = AsyncTaskMethodBuilder<Result>.Create();
			<IssueCartridges>d__.cartridges = cartridges;
			<IssueCartridges>d__.paymentSystem = paymentSystem;
			<IssueCartridges>d__.<>1__state = -1;
			<IssueCartridges>d__.<>t__builder.Start<CartridgeService.<IssueCartridges>d__15>(ref <IssueCartridges>d__);
			return <IssueCartridges>d__.<>t__builder.Task;
		}

		// Token: 0x0400246E RID: 9326
		private readonly ILoggerService<CartridgeService> _loggerService;

		// Token: 0x0400246F RID: 9327
		private readonly IOfficeService _officeService;

		// Token: 0x04002470 RID: 9328
		private readonly IContextFactory _contextFactory;

		// Token: 0x020006FD RID: 1789
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x060039E0 RID: 14816 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x04002471 RID: 9329
			public int cartridgeId;
		}

		// Token: 0x020006FE RID: 1790
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateBox>d__5 : IAsyncStateMachine
		{
			// Token: 0x060039E1 RID: 14817 RVA: 0x000DA100 File Offset: 0x000D8300
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CartridgeService cartridgeService = this.<>4__this;
				try
				{
					CartridgeService.<>c__DisplayClass5_0 CS$<>8__locals1;
					if (num > 1)
					{
						CS$<>8__locals1 = new CartridgeService.<>c__DisplayClass5_0();
						CS$<>8__locals1.cartridgeId = this.cartridgeId;
					}
					try
					{
						if (num > 1)
						{
							this.<ctx>5__2 = cartridgeService._contextFactory.Create();
						}
						try
						{
							TaskAwaiter<int> awaiter;
							TaskAwaiter<workshop> awaiter2;
							if (num != 0)
							{
								if (num == 1)
								{
									awaiter = this.<>u__2;
									this.<>u__2 = default(TaskAwaiter<int>);
									int num2 = -1;
									num = -1;
									this.<>1__state = num2;
									goto IL_152;
								}
								awaiter2 = this.<ctx>5__2.workshop.SingleAsync((workshop i) => i.id == CS$<>8__locals1.cartridgeId).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									int num3 = 0;
									num = 0;
									this.<>1__state = num3;
									this.<>u__1 = awaiter2;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop>, CartridgeService.<UpdateBox>d__5>(ref awaiter2, ref this);
									return;
								}
							}
							else
							{
								awaiter2 = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<workshop>);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
							}
							awaiter2.GetResult().box = this.boxId;
							awaiter = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num5 = 1;
								num = 1;
								this.<>1__state = num5;
								this.<>u__2 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, CartridgeService.<UpdateBox>d__5>(ref awaiter, ref this);
								return;
							}
							IL_152:
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
						cartridgeService._loggerService.Error(ex, ex.Message);
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

			// Token: 0x060039E2 RID: 14818 RVA: 0x000DA340 File Offset: 0x000D8540
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002472 RID: 9330
			public int <>1__state;

			// Token: 0x04002473 RID: 9331
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002474 RID: 9332
			public int cartridgeId;

			// Token: 0x04002475 RID: 9333
			public CartridgeService <>4__this;

			// Token: 0x04002476 RID: 9334
			public int? boxId;

			// Token: 0x04002477 RID: 9335
			private auseceEntities <ctx>5__2;

			// Token: 0x04002478 RID: 9336
			private TaskAwaiter<workshop> <>u__1;

			// Token: 0x04002479 RID: 9337
			private TaskAwaiter<int> <>u__2;
		}

		// Token: 0x020006FF RID: 1791
		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x060039E3 RID: 14819 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x0400247A RID: 9338
			public List<int> ids;
		}

		// Token: 0x02000700 RID: 1792
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060039E4 RID: 14820 RVA: 0x000DA35C File Offset: 0x000D855C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060039E5 RID: 14821 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x060039E6 RID: 14822 RVA: 0x000DA374 File Offset: 0x000D8574
			internal Cartridge <GetCartridges>b__6_0(workshop r)
			{
				return r.ToCartridge();
			}

			// Token: 0x060039E7 RID: 14823 RVA: 0x000DA388 File Offset: 0x000D8588
			internal Task<CartridgeEx> <GetCartridgesEx>b__7_0(workshop r)
			{
				CartridgeService.<>c.<<GetCartridgesEx>b__7_0>d <<GetCartridgesEx>b__7_0>d;
				<<GetCartridgesEx>b__7_0>d.<>t__builder = AsyncTaskMethodBuilder<CartridgeEx>.Create();
				<<GetCartridgesEx>b__7_0>d.r = r;
				<<GetCartridgesEx>b__7_0>d.<>1__state = -1;
				<<GetCartridgesEx>b__7_0>d.<>t__builder.Start<CartridgeService.<>c.<<GetCartridgesEx>b__7_0>d>(ref <<GetCartridgesEx>b__7_0>d);
				return <<GetCartridgesEx>b__7_0>d.<>t__builder.Task;
			}

			// Token: 0x060039E8 RID: 14824 RVA: 0x000DA3CC File Offset: 0x000D85CC
			internal CartridgeEx <GetCartridgesEx>b__7_1(Task<CartridgeEx> r)
			{
				return r.Result;
			}

			// Token: 0x060039E9 RID: 14825 RVA: 0x00082F2C File Offset: 0x0008112C
			internal bool <GetCartridgesEx>b__7_2(CartridgeEx i)
			{
				return i != null;
			}

			// Token: 0x0400247B RID: 9339
			public static readonly CartridgeService.<>c <>9 = new CartridgeService.<>c();

			// Token: 0x0400247C RID: 9340
			public static Func<workshop, Cartridge> <>9__6_0;

			// Token: 0x0400247D RID: 9341
			public static Func<workshop, Task<CartridgeEx>> <>9__7_0;

			// Token: 0x0400247E RID: 9342
			public static Func<Task<CartridgeEx>, CartridgeEx> <>9__7_1;

			// Token: 0x0400247F RID: 9343
			public static Func<CartridgeEx, bool> <>9__7_2;

			// Token: 0x02000701 RID: 1793
			[StructLayout(LayoutKind.Auto)]
			private struct <<GetCartridgesEx>b__7_0>d : IAsyncStateMachine
			{
				// Token: 0x060039EA RID: 14826 RVA: 0x000DA3E0 File Offset: 0x000D85E0
				void IAsyncStateMachine.MoveNext()
				{
					int num = this.<>1__state;
					CartridgeEx result;
					try
					{
						TaskAwaiter<CartridgeEx> awaiter;
						if (num != 0)
						{
							awaiter = this.r.ToCartridgeEx().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<CartridgeEx>, CartridgeService.<>c.<<GetCartridgesEx>b__7_0>d>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<CartridgeEx>);
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

				// Token: 0x060039EB RID: 14827 RVA: 0x000DA494 File Offset: 0x000D8694
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04002480 RID: 9344
				public int <>1__state;

				// Token: 0x04002481 RID: 9345
				public AsyncTaskMethodBuilder<CartridgeEx> <>t__builder;

				// Token: 0x04002482 RID: 9346
				public workshop r;

				// Token: 0x04002483 RID: 9347
				private TaskAwaiter<CartridgeEx> <>u__1;
			}
		}

		// Token: 0x02000702 RID: 1794
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCartridges>d__6 : IAsyncStateMachine
		{
			// Token: 0x060039EC RID: 14828 RVA: 0x000DA4B0 File Offset: 0x000D86B0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CartridgeService cartridgeService = this.<>4__this;
				List<Cartridge> result;
				try
				{
					CartridgeService.<>c__DisplayClass6_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new CartridgeService.<>c__DisplayClass6_0();
						CS$<>8__locals1.ids = this.ids;
						this.<ctx>5__2 = cartridgeService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<List<workshop>> awaiter;
						if (num != 0)
						{
							awaiter = (from i in this.<ctx>5__2.workshop.AsNoTracking().Include((workshop i) => i.device_makers).Include((workshop i) => i.c_workshop).Include((workshop i) => i.c_workshop.cartridge_cards).Include((workshop i) => i.c_workshop.cartridge_cards.materials)
							where CS$<>8__locals1.ids.Contains(i.id)
							select i).ToListAsync<workshop>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<workshop>>, CartridgeService.<GetCartridges>d__6>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<workshop>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult().Select(new Func<workshop, Cartridge>(CartridgeService.<>c.<>9.<GetCartridges>b__6_0)).ToList<Cartridge>();
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

			// Token: 0x060039ED RID: 14829 RVA: 0x000DA7CC File Offset: 0x000D89CC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002484 RID: 9348
			public int <>1__state;

			// Token: 0x04002485 RID: 9349
			public AsyncTaskMethodBuilder<List<Cartridge>> <>t__builder;

			// Token: 0x04002486 RID: 9350
			public List<int> ids;

			// Token: 0x04002487 RID: 9351
			public CartridgeService <>4__this;

			// Token: 0x04002488 RID: 9352
			private auseceEntities <ctx>5__2;

			// Token: 0x04002489 RID: 9353
			private TaskAwaiter<List<workshop>> <>u__1;
		}

		// Token: 0x02000703 RID: 1795
		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x060039EE RID: 14830 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x0400248A RID: 9354
			public List<int> ids;
		}

		// Token: 0x02000704 RID: 1796
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCartridgesEx>d__7 : IAsyncStateMachine
		{
			// Token: 0x060039EF RID: 14831 RVA: 0x000DA7E8 File Offset: 0x000D89E8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CartridgeService cartridgeService = this.<>4__this;
				List<CartridgeEx> result;
				try
				{
					CartridgeService.<>c__DisplayClass7_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new CartridgeService.<>c__DisplayClass7_0();
						CS$<>8__locals1.ids = this.ids;
						this.<ctx>5__2 = cartridgeService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<List<workshop>> awaiter;
						if (num != 0)
						{
							awaiter = (from i in this.<ctx>5__2.workshop.AsNoTracking().Include((workshop i) => i.works).Include((workshop i) => i.clients).Include((workshop i) => i.clients).Include((workshop i) => i.device_makers).Include((workshop i) => i.c_workshop).Include((workshop i) => i.c_workshop.cartridge_cards).Include((workshop i) => i.c_workshop.cartridge_cards.materials)
							where CS$<>8__locals1.ids.Contains(i.id)
							select i).ToListAsync<workshop>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<workshop>>, CartridgeService.<GetCartridgesEx>d__7>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<workshop>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult().Select(new Func<workshop, Task<CartridgeEx>>(CartridgeService.<>c.<>9.<GetCartridgesEx>b__7_0)).Select(new Func<Task<CartridgeEx>, CartridgeEx>(CartridgeService.<>c.<>9.<GetCartridgesEx>b__7_1)).Where(new Func<CartridgeEx, bool>(CartridgeService.<>c.<>9.<GetCartridgesEx>b__7_2)).ToList<CartridgeEx>();
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

			// Token: 0x060039F0 RID: 14832 RVA: 0x000DAC10 File Offset: 0x000D8E10
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400248B RID: 9355
			public int <>1__state;

			// Token: 0x0400248C RID: 9356
			public AsyncTaskMethodBuilder<List<CartridgeEx>> <>t__builder;

			// Token: 0x0400248D RID: 9357
			public List<int> ids;

			// Token: 0x0400248E RID: 9358
			public CartridgeService <>4__this;

			// Token: 0x0400248F RID: 9359
			private auseceEntities <ctx>5__2;

			// Token: 0x04002490 RID: 9360
			private TaskAwaiter<List<workshop>> <>u__1;
		}

		// Token: 0x02000705 RID: 1797
		[CompilerGenerated]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x060039F1 RID: 14833 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x060039F2 RID: 14834 RVA: 0x000DAC2C File Offset: 0x000D8E2C
			internal Task<companies> <GetCartgidgesReport>b__0()
			{
				return CompaniesModel.LoadCompany(this.companyId);
			}

			// Token: 0x060039F3 RID: 14835 RVA: 0x000DAC44 File Offset: 0x000D8E44
			internal void <GetCartgidgesReport>b__1(Task<companies> t)
			{
				this.result.Company = t.Result;
			}

			// Token: 0x060039F4 RID: 14836 RVA: 0x000DAC64 File Offset: 0x000D8E64
			internal Task<CustomerCard> <GetCartgidgesReport>b__2()
			{
				return ClientsModel.GetCustomerCard(this.customerId);
			}

			// Token: 0x060039F5 RID: 14837 RVA: 0x000DAC7C File Offset: 0x000D8E7C
			internal void <GetCartgidgesReport>b__3(Task<CustomerCard> t)
			{
				this.result.Customer = t.Result;
			}

			// Token: 0x060039F6 RID: 14838 RVA: 0x000DAC9C File Offset: 0x000D8E9C
			internal Task<List<Cartridge>> <GetCartgidgesReport>b__4()
			{
				return this.<>4__this.GetCartridges(this.ids);
			}

			// Token: 0x060039F7 RID: 14839 RVA: 0x000DACBC File Offset: 0x000D8EBC
			internal void <GetCartgidgesReport>b__5(Task<List<Cartridge>> t)
			{
				this.result.Cartridges = t.Result;
			}

			// Token: 0x04002491 RID: 9361
			public int companyId;

			// Token: 0x04002492 RID: 9362
			public CartridgeReport result;

			// Token: 0x04002493 RID: 9363
			public int customerId;

			// Token: 0x04002494 RID: 9364
			public CartridgeService <>4__this;

			// Token: 0x04002495 RID: 9365
			public List<int> ids;
		}

		// Token: 0x02000706 RID: 1798
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCartgidgesReport>d__8 : IAsyncStateMachine
		{
			// Token: 0x060039F8 RID: 14840 RVA: 0x000DACDC File Offset: 0x000D8EDC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CartridgeService cartridgeService = this.<>4__this;
				CartridgeReport result2;
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter<offices> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter);
							this.<>1__state = -1;
							goto IL_232;
						}
						this.<>8__1 = new CartridgeService.<>c__DisplayClass8_0();
						this.<>8__1.companyId = this.companyId;
						this.<>8__1.customerId = this.customerId;
						this.<>8__1.<>4__this = this.<>4__this;
						this.<>8__1.ids = this.ids;
						this.<tasks>5__2 = new List<Task>();
						this.<>8__1.result = new CartridgeReport
						{
							Manager = OfflineData.Instance.Employee
						};
						Task item = Task.Run<companies>(new Func<Task<companies>>(this.<>8__1.<GetCartgidgesReport>b__0)).ContinueWith(new Action<Task<companies>>(this.<>8__1.<GetCartgidgesReport>b__1));
						this.<tasks>5__2.Add(item);
						this.<>7__wrap2 = this.<>8__1.result;
						awaiter2 = cartridgeService._officeService.GetOfficeAsync(this.officeId).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<offices>, CartridgeService.<GetCartgidgesReport>d__8>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<offices>);
						this.<>1__state = -1;
					}
					offices result = awaiter2.GetResult();
					this.<>7__wrap2.Office = result;
					this.<>7__wrap2 = null;
					Task item2 = Task.Run<CustomerCard>(new Func<Task<CustomerCard>>(this.<>8__1.<GetCartgidgesReport>b__2)).ContinueWith(new Action<Task<CustomerCard>>(this.<>8__1.<GetCartgidgesReport>b__3));
					this.<tasks>5__2.Add(item2);
					Task item3 = Task.Run<List<Cartridge>>(new Func<Task<List<Cartridge>>>(this.<>8__1.<GetCartgidgesReport>b__4)).ContinueWith(new Action<Task<List<Cartridge>>>(this.<>8__1.<GetCartgidgesReport>b__5));
					this.<tasks>5__2.Add(item3);
					awaiter = Task.WhenAll(this.<tasks>5__2).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, CartridgeService.<GetCartgidgesReport>d__8>(ref awaiter, ref this);
						return;
					}
					IL_232:
					awaiter.GetResult();
					this.<>8__1.result.ConstrunctNum();
					result2 = this.<>8__1.result;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<tasks>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<tasks>5__2 = null;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x060039F9 RID: 14841 RVA: 0x000DAFA8 File Offset: 0x000D91A8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002496 RID: 9366
			public int <>1__state;

			// Token: 0x04002497 RID: 9367
			public AsyncTaskMethodBuilder<CartridgeReport> <>t__builder;

			// Token: 0x04002498 RID: 9368
			public int companyId;

			// Token: 0x04002499 RID: 9369
			public int customerId;

			// Token: 0x0400249A RID: 9370
			public CartridgeService <>4__this;

			// Token: 0x0400249B RID: 9371
			public List<int> ids;

			// Token: 0x0400249C RID: 9372
			public int officeId;

			// Token: 0x0400249D RID: 9373
			private CartridgeService.<>c__DisplayClass8_0 <>8__1;

			// Token: 0x0400249E RID: 9374
			private List<Task> <tasks>5__2;

			// Token: 0x0400249F RID: 9375
			private CartridgeReport <>7__wrap2;

			// Token: 0x040024A0 RID: 9376
			private TaskAwaiter<offices> <>u__1;

			// Token: 0x040024A1 RID: 9377
			private TaskAwaiter <>u__2;
		}

		// Token: 0x02000707 RID: 1799
		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x060039FA RID: 14842 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x060039FB RID: 14843 RVA: 0x000DAFC4 File Offset: 0x000D91C4
			internal Task<List<Cartridge>> <GetCartgidgeReport>b__0()
			{
				return this.<>4__this.GetCartridges(new List<int>
				{
					this.repairId
				});
			}

			// Token: 0x060039FC RID: 14844 RVA: 0x000DAFF0 File Offset: 0x000D91F0
			internal void <GetCartgidgeReport>b__1(Task<List<Cartridge>> t)
			{
				this.result.Cartridges = t.Result;
			}

			// Token: 0x060039FD RID: 14845 RVA: 0x000DB010 File Offset: 0x000D9210
			internal Task<companies> <GetCartgidgeReport>b__2()
			{
				return CompaniesModel.LoadCompany(this.first.CompanyId);
			}

			// Token: 0x060039FE RID: 14846 RVA: 0x000DB030 File Offset: 0x000D9230
			internal void <GetCartgidgeReport>b__3(Task<companies> t)
			{
				this.result.Company = t.Result;
			}

			// Token: 0x060039FF RID: 14847 RVA: 0x000DB050 File Offset: 0x000D9250
			internal Task<CustomerCard> <GetCartgidgeReport>b__4()
			{
				return ClientsModel.GetCustomerCard(this.first.CustomerId);
			}

			// Token: 0x06003A00 RID: 14848 RVA: 0x000DB070 File Offset: 0x000D9270
			internal void <GetCartgidgeReport>b__5(Task<CustomerCard> t)
			{
				this.result.Customer = t.Result;
			}

			// Token: 0x040024A2 RID: 9378
			public CartridgeService <>4__this;

			// Token: 0x040024A3 RID: 9379
			public int repairId;

			// Token: 0x040024A4 RID: 9380
			public CartridgeReport result;

			// Token: 0x040024A5 RID: 9381
			public Cartridge first;
		}

		// Token: 0x02000708 RID: 1800
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCartgidgeReport>d__9 : IAsyncStateMachine
		{
			// Token: 0x06003A01 RID: 14849 RVA: 0x000DB090 File Offset: 0x000D9290
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CartridgeService cartridgeService = this.<>4__this;
				CartridgeReport result2;
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter<offices> awaiter2;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<offices>);
						this.<>1__state = -1;
						goto IL_1E4;
					case 2:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_298;
					default:
					{
						this.<>8__1 = new CartridgeService.<>c__DisplayClass9_0();
						this.<>8__1.<>4__this = this.<>4__this;
						this.<>8__1.repairId = this.repairId;
						this.<>8__1.result = new CartridgeReport
						{
							Manager = OfflineData.Instance.Employee
						};
						Task task = Task.Run<List<Cartridge>>(new Func<Task<List<Cartridge>>>(this.<>8__1.<GetCartgidgeReport>b__0)).ContinueWith(new Action<Task<List<Cartridge>>>(this.<>8__1.<GetCartgidgeReport>b__1));
						this.<tasks>5__2 = new List<Task>();
						awaiter = Task.WhenAll(new Task[]
						{
							task
						}).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, CartridgeService.<GetCartgidgeReport>d__9>(ref awaiter, ref this);
							return;
						}
						break;
					}
					}
					awaiter.GetResult();
					this.<>8__1.first = this.<>8__1.result.Cartridges.FirstOrDefault<Cartridge>();
					Task item = Task.Run<companies>(new Func<Task<companies>>(this.<>8__1.<GetCartgidgeReport>b__2)).ContinueWith(new Action<Task<companies>>(this.<>8__1.<GetCartgidgeReport>b__3));
					this.<tasks>5__2.Add(item);
					this.<>7__wrap2 = this.<>8__1.result;
					awaiter2 = cartridgeService._officeService.GetOfficeAsync(this.<>8__1.first.CurrentOfficeId).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<offices>, CartridgeService.<GetCartgidgeReport>d__9>(ref awaiter2, ref this);
						return;
					}
					IL_1E4:
					offices result = awaiter2.GetResult();
					this.<>7__wrap2.Office = result;
					this.<>7__wrap2 = null;
					Task item2 = Task.Run<CustomerCard>(new Func<Task<CustomerCard>>(this.<>8__1.<GetCartgidgeReport>b__4)).ContinueWith(new Action<Task<CustomerCard>>(this.<>8__1.<GetCartgidgeReport>b__5));
					this.<tasks>5__2.Add(item2);
					awaiter = Task.WhenAll(this.<tasks>5__2).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, CartridgeService.<GetCartgidgeReport>d__9>(ref awaiter, ref this);
						return;
					}
					IL_298:
					awaiter.GetResult();
					this.<>8__1.result.ConstrunctNum();
					result2 = this.<>8__1.result;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<tasks>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<tasks>5__2 = null;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06003A02 RID: 14850 RVA: 0x000DB3C0 File Offset: 0x000D95C0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040024A6 RID: 9382
			public int <>1__state;

			// Token: 0x040024A7 RID: 9383
			public AsyncTaskMethodBuilder<CartridgeReport> <>t__builder;

			// Token: 0x040024A8 RID: 9384
			public CartridgeService <>4__this;

			// Token: 0x040024A9 RID: 9385
			public int repairId;

			// Token: 0x040024AA RID: 9386
			private CartridgeService.<>c__DisplayClass9_0 <>8__1;

			// Token: 0x040024AB RID: 9387
			private List<Task> <tasks>5__2;

			// Token: 0x040024AC RID: 9388
			private TaskAwaiter <>u__1;

			// Token: 0x040024AD RID: 9389
			private CartridgeReport <>7__wrap2;

			// Token: 0x040024AE RID: 9390
			private TaskAwaiter<offices> <>u__2;
		}

		// Token: 0x02000709 RID: 1801
		[CompilerGenerated]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x06003A03 RID: 14851 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x06003A04 RID: 14852 RVA: 0x000DB3DC File Offset: 0x000D95DC
			internal Task<List<CartridgeEx>> <GetIssueCartridgeReport>b__0()
			{
				return this.<>4__this.GetCartridgesEx(this.ids);
			}

			// Token: 0x06003A05 RID: 14853 RVA: 0x000DB3FC File Offset: 0x000D95FC
			internal void <GetIssueCartridgeReport>b__1(Task<List<CartridgeEx>> t)
			{
				this.result.Cartridges = t.Result;
			}

			// Token: 0x06003A06 RID: 14854 RVA: 0x000DB41C File Offset: 0x000D961C
			internal Task<companies> <GetIssueCartridgeReport>b__2()
			{
				return CompaniesModel.LoadCompany(this.first.CompanyId);
			}

			// Token: 0x06003A07 RID: 14855 RVA: 0x000DB43C File Offset: 0x000D963C
			internal void <GetIssueCartridgeReport>b__3(Task<companies> t)
			{
				this.result.Company = t.Result;
			}

			// Token: 0x06003A08 RID: 14856 RVA: 0x000DB45C File Offset: 0x000D965C
			internal Task<CustomerCard> <GetIssueCartridgeReport>b__4()
			{
				return ClientsModel.GetCustomerCard(this.first.CustomerId);
			}

			// Token: 0x06003A09 RID: 14857 RVA: 0x000DB47C File Offset: 0x000D967C
			internal void <GetIssueCartridgeReport>b__5(Task<CustomerCard> t)
			{
				this.result.Customer = t.Result;
			}

			// Token: 0x040024AF RID: 9391
			public CartridgeService <>4__this;

			// Token: 0x040024B0 RID: 9392
			public List<int> ids;

			// Token: 0x040024B1 RID: 9393
			public CartridgeIssueReport result;

			// Token: 0x040024B2 RID: 9394
			public CartridgeEx first;
		}

		// Token: 0x0200070A RID: 1802
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetIssueCartridgeReport>d__10 : IAsyncStateMachine
		{
			// Token: 0x06003A0A RID: 14858 RVA: 0x000DB49C File Offset: 0x000D969C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CartridgeService cartridgeService = this.<>4__this;
				CartridgeIssueReport result2;
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter<offices> awaiter2;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<offices>);
						this.<>1__state = -1;
						goto IL_1E4;
					case 2:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_298;
					default:
					{
						this.<>8__1 = new CartridgeService.<>c__DisplayClass10_0();
						this.<>8__1.<>4__this = this.<>4__this;
						this.<>8__1.ids = this.ids;
						this.<>8__1.result = new CartridgeIssueReport
						{
							Manager = OfflineData.Instance.Employee
						};
						Task task = Task.Run<List<CartridgeEx>>(new Func<Task<List<CartridgeEx>>>(this.<>8__1.<GetIssueCartridgeReport>b__0)).ContinueWith(new Action<Task<List<CartridgeEx>>>(this.<>8__1.<GetIssueCartridgeReport>b__1));
						this.<tasks>5__2 = new List<Task>();
						awaiter = Task.WhenAll(new Task[]
						{
							task
						}).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, CartridgeService.<GetIssueCartridgeReport>d__10>(ref awaiter, ref this);
							return;
						}
						break;
					}
					}
					awaiter.GetResult();
					this.<>8__1.first = this.<>8__1.result.Cartridges.FirstOrDefault<CartridgeEx>();
					Task item = Task.Run<companies>(new Func<Task<companies>>(this.<>8__1.<GetIssueCartridgeReport>b__2)).ContinueWith(new Action<Task<companies>>(this.<>8__1.<GetIssueCartridgeReport>b__3));
					this.<tasks>5__2.Add(item);
					this.<>7__wrap2 = this.<>8__1.result;
					awaiter2 = cartridgeService._officeService.GetOfficeAsync(this.<>8__1.first.CurrentOfficeId).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<offices>, CartridgeService.<GetIssueCartridgeReport>d__10>(ref awaiter2, ref this);
						return;
					}
					IL_1E4:
					offices result = awaiter2.GetResult();
					this.<>7__wrap2.Office = result;
					this.<>7__wrap2 = null;
					Task item2 = Task.Run<CustomerCard>(new Func<Task<CustomerCard>>(this.<>8__1.<GetIssueCartridgeReport>b__4)).ContinueWith(new Action<Task<CustomerCard>>(this.<>8__1.<GetIssueCartridgeReport>b__5));
					this.<tasks>5__2.Add(item2);
					awaiter = Task.WhenAll(this.<tasks>5__2).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, CartridgeService.<GetIssueCartridgeReport>d__10>(ref awaiter, ref this);
						return;
					}
					IL_298:
					awaiter.GetResult();
					this.<>8__1.result.ConstrunctNum();
					result2 = this.<>8__1.result;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<tasks>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<tasks>5__2 = null;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06003A0B RID: 14859 RVA: 0x000DB7CC File Offset: 0x000D99CC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040024B3 RID: 9395
			public int <>1__state;

			// Token: 0x040024B4 RID: 9396
			public AsyncTaskMethodBuilder<CartridgeIssueReport> <>t__builder;

			// Token: 0x040024B5 RID: 9397
			public CartridgeService <>4__this;

			// Token: 0x040024B6 RID: 9398
			public List<int> ids;

			// Token: 0x040024B7 RID: 9399
			private CartridgeService.<>c__DisplayClass10_0 <>8__1;

			// Token: 0x040024B8 RID: 9400
			private List<Task> <tasks>5__2;

			// Token: 0x040024B9 RID: 9401
			private TaskAwaiter <>u__1;

			// Token: 0x040024BA RID: 9402
			private CartridgeIssueReport <>7__wrap2;

			// Token: 0x040024BB RID: 9403
			private TaskAwaiter<offices> <>u__2;
		}

		// Token: 0x0200070B RID: 1803
		[CompilerGenerated]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x06003A0C RID: 14860 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass11_0()
			{
			}

			// Token: 0x06003A0D RID: 14861 RVA: 0x000DB7E8 File Offset: 0x000D99E8
			internal Task<List<CartridgeEx>> <GetIssueCartridgeReport>b__0()
			{
				return this.<>4__this.GetCartridgesEx(new List<int>
				{
					this.repairId
				});
			}

			// Token: 0x06003A0E RID: 14862 RVA: 0x000DB814 File Offset: 0x000D9A14
			internal void <GetIssueCartridgeReport>b__1(Task<List<CartridgeEx>> t)
			{
				this.result.Cartridges = t.Result;
			}

			// Token: 0x06003A0F RID: 14863 RVA: 0x000DB834 File Offset: 0x000D9A34
			internal Task<companies> <GetIssueCartridgeReport>b__2()
			{
				return CompaniesModel.LoadCompany(this.first.CompanyId);
			}

			// Token: 0x06003A10 RID: 14864 RVA: 0x000DB854 File Offset: 0x000D9A54
			internal void <GetIssueCartridgeReport>b__3(Task<companies> t)
			{
				this.result.Company = t.Result;
			}

			// Token: 0x06003A11 RID: 14865 RVA: 0x000DB874 File Offset: 0x000D9A74
			internal Task<CustomerCard> <GetIssueCartridgeReport>b__4()
			{
				return ClientsModel.GetCustomerCard(this.first.CustomerId);
			}

			// Token: 0x06003A12 RID: 14866 RVA: 0x000DB894 File Offset: 0x000D9A94
			internal void <GetIssueCartridgeReport>b__5(Task<CustomerCard> t)
			{
				this.result.Customer = t.Result;
			}

			// Token: 0x040024BC RID: 9404
			public CartridgeService <>4__this;

			// Token: 0x040024BD RID: 9405
			public int repairId;

			// Token: 0x040024BE RID: 9406
			public CartridgeIssueReport result;

			// Token: 0x040024BF RID: 9407
			public CartridgeEx first;
		}

		// Token: 0x0200070C RID: 1804
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetIssueCartridgeReport>d__11 : IAsyncStateMachine
		{
			// Token: 0x06003A13 RID: 14867 RVA: 0x000DB8B4 File Offset: 0x000D9AB4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CartridgeService cartridgeService = this.<>4__this;
				CartridgeIssueReport result2;
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter<offices> awaiter2;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<offices>);
						this.<>1__state = -1;
						goto IL_1E4;
					case 2:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_298;
					default:
					{
						this.<>8__1 = new CartridgeService.<>c__DisplayClass11_0();
						this.<>8__1.<>4__this = this.<>4__this;
						this.<>8__1.repairId = this.repairId;
						this.<>8__1.result = new CartridgeIssueReport
						{
							Manager = OfflineData.Instance.Employee
						};
						Task task = Task.Run<List<CartridgeEx>>(new Func<Task<List<CartridgeEx>>>(this.<>8__1.<GetIssueCartridgeReport>b__0)).ContinueWith(new Action<Task<List<CartridgeEx>>>(this.<>8__1.<GetIssueCartridgeReport>b__1));
						this.<tasks>5__2 = new List<Task>();
						awaiter = Task.WhenAll(new Task[]
						{
							task
						}).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, CartridgeService.<GetIssueCartridgeReport>d__11>(ref awaiter, ref this);
							return;
						}
						break;
					}
					}
					awaiter.GetResult();
					this.<>8__1.first = this.<>8__1.result.Cartridges.FirstOrDefault<CartridgeEx>();
					Task item = Task.Run<companies>(new Func<Task<companies>>(this.<>8__1.<GetIssueCartridgeReport>b__2)).ContinueWith(new Action<Task<companies>>(this.<>8__1.<GetIssueCartridgeReport>b__3));
					this.<tasks>5__2.Add(item);
					this.<>7__wrap2 = this.<>8__1.result;
					awaiter2 = cartridgeService._officeService.GetOfficeAsync(this.<>8__1.first.CurrentOfficeId).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<offices>, CartridgeService.<GetIssueCartridgeReport>d__11>(ref awaiter2, ref this);
						return;
					}
					IL_1E4:
					offices result = awaiter2.GetResult();
					this.<>7__wrap2.Office = result;
					this.<>7__wrap2 = null;
					Task item2 = Task.Run<CustomerCard>(new Func<Task<CustomerCard>>(this.<>8__1.<GetIssueCartridgeReport>b__4)).ContinueWith(new Action<Task<CustomerCard>>(this.<>8__1.<GetIssueCartridgeReport>b__5));
					this.<tasks>5__2.Add(item2);
					awaiter = Task.WhenAll(this.<tasks>5__2).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, CartridgeService.<GetIssueCartridgeReport>d__11>(ref awaiter, ref this);
						return;
					}
					IL_298:
					awaiter.GetResult();
					this.<>8__1.result.ConstrunctNum();
					result2 = this.<>8__1.result;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<tasks>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<tasks>5__2 = null;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06003A14 RID: 14868 RVA: 0x000DBBE4 File Offset: 0x000D9DE4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040024C0 RID: 9408
			public int <>1__state;

			// Token: 0x040024C1 RID: 9409
			public AsyncTaskMethodBuilder<CartridgeIssueReport> <>t__builder;

			// Token: 0x040024C2 RID: 9410
			public CartridgeService <>4__this;

			// Token: 0x040024C3 RID: 9411
			public int repairId;

			// Token: 0x040024C4 RID: 9412
			private CartridgeService.<>c__DisplayClass11_0 <>8__1;

			// Token: 0x040024C5 RID: 9413
			private List<Task> <tasks>5__2;

			// Token: 0x040024C6 RID: 9414
			private TaskAwaiter <>u__1;

			// Token: 0x040024C7 RID: 9415
			private CartridgeIssueReport <>7__wrap2;

			// Token: 0x040024C8 RID: 9416
			private TaskAwaiter<offices> <>u__2;
		}

		// Token: 0x0200070D RID: 1805
		[CompilerGenerated]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x06003A15 RID: 14869 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x040024C9 RID: 9417
			public int id;
		}

		// Token: 0x0200070E RID: 1806
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCartridge>d__12 : IAsyncStateMachine
		{
			// Token: 0x06003A16 RID: 14870 RVA: 0x000DBC00 File Offset: 0x000D9E00
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CartridgeService cartridgeService = this.<>4__this;
				Cartridge result;
				try
				{
					CartridgeService.<>c__DisplayClass12_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new CartridgeService.<>c__DisplayClass12_0();
						CS$<>8__locals1.id = this.id;
						this.<ctx>5__2 = cartridgeService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<workshop> awaiter;
						if (num != 0)
						{
							awaiter = this.<ctx>5__2.workshop.AsNoTracking().Include((workshop i) => i.device_makers).Include((workshop i) => i.c_workshop).Include((workshop i) => i.c_workshop.cartridge_cards).Include((workshop i) => i.c_workshop.cartridge_cards.materials).SingleAsync((workshop i) => i.id == CS$<>8__locals1.id).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop>, CartridgeService.<GetCartridge>d__12>(ref awaiter, ref this);
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
						result = awaiter.GetResult().ToCartridge();
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

			// Token: 0x06003A17 RID: 14871 RVA: 0x000DBED4 File Offset: 0x000DA0D4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040024CA RID: 9418
			public int <>1__state;

			// Token: 0x040024CB RID: 9419
			public AsyncTaskMethodBuilder<Cartridge> <>t__builder;

			// Token: 0x040024CC RID: 9420
			public int id;

			// Token: 0x040024CD RID: 9421
			public CartridgeService <>4__this;

			// Token: 0x040024CE RID: 9422
			private auseceEntities <ctx>5__2;

			// Token: 0x040024CF RID: 9423
			private TaskAwaiter<workshop> <>u__1;
		}

		// Token: 0x0200070F RID: 1807
		[CompilerGenerated]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x06003A18 RID: 14872 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass13_0()
			{
			}

			// Token: 0x040024D0 RID: 9424
			public string serialNumber;
		}

		// Token: 0x02000710 RID: 1808
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCartridge>d__13 : IAsyncStateMachine
		{
			// Token: 0x06003A19 RID: 14873 RVA: 0x000DBEF0 File Offset: 0x000DA0F0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CartridgeService cartridgeService = this.<>4__this;
				Cartridge result;
				try
				{
					CartridgeService.<>c__DisplayClass13_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new CartridgeService.<>c__DisplayClass13_0();
						CS$<>8__locals1.serialNumber = this.serialNumber;
						this.<ctx>5__2 = cartridgeService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<workshop> awaiter;
						if (num != 0)
						{
							awaiter = this.<ctx>5__2.workshop.AsNoTracking().Include((workshop i) => i.device_makers).Include((workshop i) => i.c_workshop).Include((workshop i) => i.c_workshop.cartridge_cards).Include((workshop i) => i.c_workshop.cartridge_cards.materials).SingleAsync((workshop i) => i.serial_number == CS$<>8__locals1.serialNumber).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop>, CartridgeService.<GetCartridge>d__13>(ref awaiter, ref this);
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
						result = awaiter.GetResult().ToCartridge();
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

			// Token: 0x06003A1A RID: 14874 RVA: 0x000DC1C4 File Offset: 0x000DA3C4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040024D1 RID: 9425
			public int <>1__state;

			// Token: 0x040024D2 RID: 9426
			public AsyncTaskMethodBuilder<Cartridge> <>t__builder;

			// Token: 0x040024D3 RID: 9427
			public string serialNumber;

			// Token: 0x040024D4 RID: 9428
			public CartridgeService <>4__this;

			// Token: 0x040024D5 RID: 9429
			private auseceEntities <ctx>5__2;

			// Token: 0x040024D6 RID: 9430
			private TaskAwaiter<workshop> <>u__1;
		}

		// Token: 0x02000711 RID: 1809
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateCartridges>d__14 : IAsyncStateMachine
		{
			// Token: 0x06003A1B RID: 14875 RVA: 0x000DC1E0 File Offset: 0x000DA3E0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Result result2;
				try
				{
					if (num > 6)
					{
						this.<result>5__2 = new Result();
						this.<history>5__3 = new HistoryV2();
						this.<barcode>5__4 = new Barcode(Barcode.Types.Cartridge);
					}
					try
					{
						if (num > 6)
						{
							this.<ctx>5__5 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<devices> awaiter;
							if (num != 0)
							{
								if (num - 1 <= 5)
								{
									goto IL_121;
								}
								awaiter = this.<ctx>5__5.devices.FirstOrDefaultAsync((devices d) => d.refill).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<devices>, CartridgeService.<CreateCartridges>d__14>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<devices>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							devices result = awaiter.GetResult();
							this.<dev>5__6 = result;
							if (this.<dev>5__6 == null)
							{
								result2 = this.<result>5__2;
								goto IL_75C;
							}
							this.<transaction>5__7 = this.<ctx>5__5.Database.BeginTransaction();
							IL_121:
							try
							{
								TaskAwaiter awaiter2;
								if (num - 1 > 4)
								{
									if (num == 6)
									{
										awaiter2 = this.<>u__3;
										this.<>u__3 = default(TaskAwaiter);
										int num4 = -1;
										num = -1;
										this.<>1__state = num4;
										goto IL_6A8;
									}
									this.<>7__wrap7 = this.cartridges.GetEnumerator();
								}
								try
								{
									TaskAwaiter<int> awaiter3;
									switch (num)
									{
									case 1:
									{
										awaiter3 = this.<>u__2;
										this.<>u__2 = default(TaskAwaiter<int>);
										int num5 = -1;
										num = -1;
										this.<>1__state = num5;
										goto IL_2E4;
									}
									case 2:
									{
										awaiter3 = this.<>u__2;
										this.<>u__2 = default(TaskAwaiter<int>);
										int num6 = -1;
										num = -1;
										this.<>1__state = num6;
										goto IL_47C;
									}
									case 3:
									{
										awaiter3 = this.<>u__2;
										this.<>u__2 = default(TaskAwaiter<int>);
										int num7 = -1;
										num = -1;
										this.<>1__state = num7;
										goto IL_4D9;
									}
									case 4:
									{
										awaiter2 = this.<>u__3;
										this.<>u__3 = default(TaskAwaiter);
										int num8 = -1;
										num = -1;
										this.<>1__state = num8;
										goto IL_505;
									}
									case 5:
									{
										awaiter2 = this.<>u__3;
										this.<>u__3 = default(TaskAwaiter);
										int num9 = -1;
										num = -1;
										this.<>1__state = num9;
										goto IL_55D;
									}
									}
									IL_22E:
									if (!this.<>7__wrap7.MoveNext())
									{
										goto IL_64C;
									}
									this.<c>5__9 = this.<>7__wrap7.Current;
									this.<cc>5__10 = new c_workshop
									{
										refill = this.<c>5__9.Refill,
										chip = this.<c>5__9.Chip,
										opc_drum = this.<c>5__9.OPCDrum,
										c_blade = this.<c>5__9.CleaningBlade,
										card_id = this.<c>5__9.CardId
									};
									this.<ctx>5__5.c_workshop.Add(this.<cc>5__10);
									awaiter3 = this.<ctx>5__5.SaveChangesAsync().GetAwaiter();
									if (!awaiter3.IsCompleted)
									{
										int num10 = 1;
										num = 1;
										this.<>1__state = num10;
										this.<>u__2 = awaiter3;
										this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, CartridgeService.<CreateCartridges>d__14>(ref awaiter3, ref this);
										return;
									}
									IL_2E4:
									awaiter3.GetResult();
									this.<w>5__11 = RepairModel.DefaultRepair();
									this.<w>5__11.type = this.<dev>5__6.id;
									this.<w>5__11.maker = this.<c>5__9.MakerId;
									this.<w>5__11.model = null;
									this.<w>5__11.pre_agreed_amount = new decimal?(this.<c>5__9.TotalCost);
									this.<w>5__11.ext_notes = this.<c>5__9.CartridgeNotes;
									this.<w>5__11.is_warranty = this.<c>5__9.IsWarranty;
									this.<w>5__11.is_repeat = this.<c>5__9.IsRepeat;
									this.<w>5__11.serial_number = this.<c>5__9.SerialNumber;
									this.<w>5__11.master = this.masterId;
									this.<w>5__11.payment_system = this.paymentSystem;
									this.<w>5__11.company = this.companyId;
									this.<w>5__11.office = this.officeId;
									this.<w>5__11.client = this.customerId;
									this.<w>5__11.fault = this.<c>5__9.GetFaults;
									this.<w>5__11.box = this.<c>5__9.BoxId;
									this.<w>5__11.cartridge = new int?(this.<cc>5__10.id);
									this.<ctx>5__5.workshop.Add(this.<w>5__11);
									awaiter3 = this.<ctx>5__5.SaveChangesAsync().GetAwaiter();
									if (!awaiter3.IsCompleted)
									{
										int num11 = 2;
										num = 2;
										this.<>1__state = num11;
										this.<>u__2 = awaiter3;
										this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, CartridgeService.<CreateCartridges>d__14>(ref awaiter3, ref this);
										return;
									}
									IL_47C:
									awaiter3.GetResult();
									this.<result>5__2.AddId(this.<w>5__11.id);
									this.<w>5__11.barcode = this.<barcode>5__4.GenerateCode(this.<w>5__11.id);
									awaiter3 = this.<ctx>5__5.SaveChangesAsync().GetAwaiter();
									if (!awaiter3.IsCompleted)
									{
										int num12 = 3;
										num = 3;
										this.<>1__state = num12;
										this.<>u__2 = awaiter3;
										this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, CartridgeService.<CreateCartridges>d__14>(ref awaiter3, ref this);
										return;
									}
									IL_4D9:
									awaiter3.GetResult();
									awaiter2 = WorkshopService.SetOrderTitle(this.<w>5__11, this.<ctx>5__5).GetAwaiter();
									if (!awaiter2.IsCompleted)
									{
										int num13 = 4;
										num = 4;
										this.<>1__state = num13;
										this.<>u__3 = awaiter2;
										this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, CartridgeService.<CreateCartridges>d__14>(ref awaiter2, ref this);
										return;
									}
									IL_505:
									awaiter2.GetResult();
									this.<history>5__3.AddRepairLog("newRepairCreated", this.<w>5__11.id, null, null, null, null, null, null);
									awaiter2 = Bootstrapper.Container.Resolve<IWorkshopStatusService>().UpdateStatusLog(this.<ctx>5__5, new RepairStatusLogModel(this.<w>5__11)).GetAwaiter();
									if (!awaiter2.IsCompleted)
									{
										int num14 = 5;
										num = 5;
										this.<>1__state = num14;
										this.<>u__3 = awaiter2;
										this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, CartridgeService.<CreateCartridges>d__14>(ref awaiter2, ref this);
										return;
									}
									IL_55D:
									awaiter2.GetResult();
									this.<cc>5__10 = null;
									this.<w>5__11 = null;
									this.<c>5__9 = null;
									goto IL_22E;
								}
								finally
								{
									if (num < 0 && this.<>7__wrap7 != null)
									{
										this.<>7__wrap7.Dispose();
									}
								}
								IL_64C:
								this.<>7__wrap7 = null;
								this.<transaction>5__7.Commit();
								this.<result>5__2.SetSuccess();
								awaiter2 = this.<history>5__3.SaveAsync().GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									int num15 = 6;
									num = 6;
									this.<>1__state = num15;
									this.<>u__3 = awaiter2;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, CartridgeService.<CreateCartridges>d__14>(ref awaiter2, ref this);
									return;
								}
								IL_6A8:
								awaiter2.GetResult();
							}
							catch (Exception)
							{
								this.<transaction>5__7.Rollback();
								this.<result>5__2.IsSucces = false;
							}
							finally
							{
								if (num < 0 && this.<transaction>5__7 != null)
								{
									((IDisposable)this.<transaction>5__7).Dispose();
								}
							}
							this.<transaction>5__7 = null;
							this.<dev>5__6 = null;
						}
						finally
						{
							if (num < 0 && this.<ctx>5__5 != null)
							{
								((IDisposable)this.<ctx>5__5).Dispose();
							}
						}
						this.<ctx>5__5 = null;
					}
					catch (Exception)
					{
						this.<result>5__2.IsSucces = false;
					}
					result2 = this.<result>5__2;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<result>5__2 = null;
					this.<history>5__3 = null;
					this.<barcode>5__4 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_75C:
				this.<>1__state = -2;
				this.<result>5__2 = null;
				this.<history>5__3 = null;
				this.<barcode>5__4 = null;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06003A1C RID: 14876 RVA: 0x000DCA08 File Offset: 0x000DAC08
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040024D7 RID: 9431
			public int <>1__state;

			// Token: 0x040024D8 RID: 9432
			public AsyncTaskMethodBuilder<Result> <>t__builder;

			// Token: 0x040024D9 RID: 9433
			public IEnumerable<Cartridge> cartridges;

			// Token: 0x040024DA RID: 9434
			public int? masterId;

			// Token: 0x040024DB RID: 9435
			public int paymentSystem;

			// Token: 0x040024DC RID: 9436
			public int companyId;

			// Token: 0x040024DD RID: 9437
			public int officeId;

			// Token: 0x040024DE RID: 9438
			public int customerId;

			// Token: 0x040024DF RID: 9439
			private Result <result>5__2;

			// Token: 0x040024E0 RID: 9440
			private HistoryV2 <history>5__3;

			// Token: 0x040024E1 RID: 9441
			private Barcode <barcode>5__4;

			// Token: 0x040024E2 RID: 9442
			private auseceEntities <ctx>5__5;

			// Token: 0x040024E3 RID: 9443
			private devices <dev>5__6;

			// Token: 0x040024E4 RID: 9444
			private TaskAwaiter<devices> <>u__1;

			// Token: 0x040024E5 RID: 9445
			private DbContextTransaction <transaction>5__7;

			// Token: 0x040024E6 RID: 9446
			private IEnumerator<Cartridge> <>7__wrap7;

			// Token: 0x040024E7 RID: 9447
			private Cartridge <c>5__9;

			// Token: 0x040024E8 RID: 9448
			private c_workshop <cc>5__10;

			// Token: 0x040024E9 RID: 9449
			private workshop <w>5__11;

			// Token: 0x040024EA RID: 9450
			private TaskAwaiter<int> <>u__2;

			// Token: 0x040024EB RID: 9451
			private TaskAwaiter <>u__3;
		}

		// Token: 0x02000712 RID: 1810
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <IssueCartridges>d__15 : IAsyncStateMachine
		{
			// Token: 0x06003A1D RID: 14877 RVA: 0x000DCA24 File Offset: 0x000DAC24
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Result result2;
				try
				{
					Result result = new Result();
					IEnumerator<CartridgeEx> enumerator = this.cartridges.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							CartridgeEx cartridgeEx = enumerator.Current;
							cartridgeEx.SetPaymentSystem(this.paymentSystem);
							cartridgeEx.Issue();
							result.AddId(cartridgeEx._cashOrderId);
						}
					}
					finally
					{
						if (num < 0 && enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					result.SetSuccess();
					result2 = result;
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

			// Token: 0x06003A1E RID: 14878 RVA: 0x000DCAE4 File Offset: 0x000DACE4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040024EC RID: 9452
			public int <>1__state;

			// Token: 0x040024ED RID: 9453
			public AsyncTaskMethodBuilder<Result> <>t__builder;

			// Token: 0x040024EE RID: 9454
			public IEnumerable<CartridgeEx> cartridges;

			// Token: 0x040024EF RID: 9455
			public int paymentSystem;
		}
	}
}
