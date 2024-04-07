using System;
using System.Data.Entity;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Services.Abstract;

namespace ASC.Services.Concrete
{
	// Token: 0x020007C9 RID: 1993
	public class WorkshopPartService : IWorkshopPartService
	{
		// Token: 0x06003C4C RID: 15436 RVA: 0x000F1030 File Offset: 0x000EF230
		public WorkshopPartService(ILoggerService<WorkshopPartService> logger, IWorkshopService workshopService)
		{
			this._logger = logger;
			this._workshopService = workshopService;
		}

		// Token: 0x06003C4D RID: 15437 RVA: 0x000F1054 File Offset: 0x000EF254
		public Task AddPart(IWorkPartObject product)
		{
			WorkshopPartService.<AddPart>d__3 <AddPart>d__;
			<AddPart>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<AddPart>d__.<>4__this = this;
			<AddPart>d__.product = product;
			<AddPart>d__.<>1__state = -1;
			<AddPart>d__.<>t__builder.Start<WorkshopPartService.<AddPart>d__3>(ref <AddPart>d__);
			return <AddPart>d__.<>t__builder.Task;
		}

		// Token: 0x06003C4E RID: 15438 RVA: 0x000F10A0 File Offset: 0x000EF2A0
		public Task UpdatePart(IWorkPartObject item)
		{
			WorkshopPartService.<UpdatePart>d__4 <UpdatePart>d__;
			<UpdatePart>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<UpdatePart>d__.<>4__this = this;
			<UpdatePart>d__.item = item;
			<UpdatePart>d__.<>1__state = -1;
			<UpdatePart>d__.<>t__builder.Start<WorkshopPartService.<UpdatePart>d__4>(ref <UpdatePart>d__);
			return <UpdatePart>d__.<>t__builder.Task;
		}

		// Token: 0x06003C4F RID: 15439 RVA: 0x000F10EC File Offset: 0x000EF2EC
		public Task RemovePart(IWorkPartObject item)
		{
			WorkshopPartService.<RemovePart>d__5 <RemovePart>d__;
			<RemovePart>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<RemovePart>d__.<>4__this = this;
			<RemovePart>d__.item = item;
			<RemovePart>d__.<>1__state = -1;
			<RemovePart>d__.<>t__builder.Start<WorkshopPartService.<RemovePart>d__5>(ref <RemovePart>d__);
			return <RemovePart>d__.<>t__builder.Task;
		}

		// Token: 0x040027AF RID: 10159
		private readonly IWorkshopService _workshopService;

		// Token: 0x040027B0 RID: 10160
		private readonly ILoggerService<WorkshopPartService> _logger;

		// Token: 0x020007CA RID: 1994
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06003C50 RID: 15440 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x040027B1 RID: 10161
			public int id;
		}

		// Token: 0x020007CB RID: 1995
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <AddPart>d__3 : IAsyncStateMachine
		{
			// Token: 0x06003C51 RID: 15441 RVA: 0x000F1138 File Offset: 0x000EF338
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopPartService workshopPartService = this.<>4__this;
				try
				{
					WorkshopPartService.<>c__DisplayClass3_0 CS$<>8__locals1;
					if (num > 2)
					{
						CS$<>8__locals1 = new WorkshopPartService.<>c__DisplayClass3_0();
						CS$<>8__locals1.id = Math.Abs(this.product.Id);
						this.<history>5__2 = new HistoryV2();
						this.<ctx>5__3 = new auseceEntities(true);
					}
					try
					{
						if (num > 2)
						{
							this.<transaction>5__4 = this.<ctx>5__3.Database.BeginTransaction();
						}
						try
						{
							TaskAwaiter<store_int_reserve> awaiter;
							TaskAwaiter awaiter2;
							switch (num)
							{
							case 0:
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<store_int_reserve>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								break;
							}
							case 1:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
								goto IL_1F5;
							}
							case 2:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
								goto IL_263;
							}
							default:
								awaiter = this.<ctx>5__3.store_int_reserve.FirstAsync((store_int_reserve i) => i.id == CS$<>8__locals1.id).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num5 = 0;
									num = 0;
									this.<>1__state = num5;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<store_int_reserve>, WorkshopPartService.<AddPart>d__3>(ref awaiter, ref this);
									return;
								}
								break;
							}
							store_int_reserve result = awaiter.GetResult();
							result.state = 2;
							result.work_id = this.product.WorkId;
							result.repair_id = new int?(this.product.RepairId);
							this.<ctx>5__3.SaveChanges();
							this.<history>5__2.AddRepairLog("partAdded", this.product);
							awaiter2 = workshopPartService._workshopService.UpdateRepairCostAndWarranty(this.<ctx>5__3, this.product.RepairId).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num6 = 1;
								num = 1;
								this.<>1__state = num6;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopPartService.<AddPart>d__3>(ref awaiter2, ref this);
								return;
							}
							IL_1F5:
							awaiter2.GetResult();
							this.<transaction>5__4.Commit();
							awaiter2 = this.<history>5__2.SaveAsync().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num7 = 2;
								num = 2;
								this.<>1__state = num7;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopPartService.<AddPart>d__3>(ref awaiter2, ref this);
								return;
							}
							IL_263:
							awaiter2.GetResult();
						}
						catch (Exception ex)
						{
							workshopPartService._logger.Error(ex, ex.Message);
							DbContextTransaction dbContextTransaction = this.<transaction>5__4;
							if (dbContextTransaction != null)
							{
								dbContextTransaction.Rollback();
							}
							throw ex;
						}
						finally
						{
							if (num < 0 && this.<transaction>5__4 != null)
							{
								((IDisposable)this.<transaction>5__4).Dispose();
							}
						}
						this.<transaction>5__4 = null;
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

			// Token: 0x06003C52 RID: 15442 RVA: 0x000F14C0 File Offset: 0x000EF6C0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040027B2 RID: 10162
			public int <>1__state;

			// Token: 0x040027B3 RID: 10163
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040027B4 RID: 10164
			public IWorkPartObject product;

			// Token: 0x040027B5 RID: 10165
			public WorkshopPartService <>4__this;

			// Token: 0x040027B6 RID: 10166
			private HistoryV2 <history>5__2;

			// Token: 0x040027B7 RID: 10167
			private auseceEntities <ctx>5__3;

			// Token: 0x040027B8 RID: 10168
			private DbContextTransaction <transaction>5__4;

			// Token: 0x040027B9 RID: 10169
			private TaskAwaiter<store_int_reserve> <>u__1;

			// Token: 0x040027BA RID: 10170
			private TaskAwaiter <>u__2;
		}

		// Token: 0x020007CC RID: 1996
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x06003C53 RID: 15443 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x040027BB RID: 10171
			public int id;
		}

		// Token: 0x020007CD RID: 1997
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdatePart>d__4 : IAsyncStateMachine
		{
			// Token: 0x06003C54 RID: 15444 RVA: 0x000F14DC File Offset: 0x000EF6DC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopPartService workshopPartService = this.<>4__this;
				try
				{
					WorkshopPartService.<>c__DisplayClass4_0 CS$<>8__locals1;
					if (num > 2)
					{
						CS$<>8__locals1 = new WorkshopPartService.<>c__DisplayClass4_0();
						CS$<>8__locals1.id = Math.Abs(this.item.Id);
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						if (num > 2)
						{
							this.<transaction>5__3 = this.<ctx>5__2.Database.BeginTransaction();
						}
						try
						{
							TaskAwaiter<store_int_reserve> awaiter;
							TaskAwaiter<int> awaiter2;
							TaskAwaiter awaiter3;
							switch (num)
							{
							case 0:
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<store_int_reserve>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								break;
							}
							case 1:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<int>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
								goto IL_19A;
							}
							case 2:
							{
								awaiter3 = this.<>u__3;
								this.<>u__3 = default(TaskAwaiter);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
								goto IL_20F;
							}
							default:
								awaiter = this.<ctx>5__2.store_int_reserve.FirstAsync((store_int_reserve i) => i.id == CS$<>8__locals1.id).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num5 = 0;
									num = 0;
									this.<>1__state = num5;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<store_int_reserve>, WorkshopPartService.<UpdatePart>d__4>(ref awaiter, ref this);
									return;
								}
								break;
							}
							awaiter.GetResult().warranty = this.item.Warranty;
							awaiter2 = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num6 = 1;
								num = 1;
								this.<>1__state = num6;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, WorkshopPartService.<UpdatePart>d__4>(ref awaiter2, ref this);
								return;
							}
							IL_19A:
							awaiter2.GetResult();
							awaiter3 = workshopPartService._workshopService.UpdateRepairCostAndWarranty(this.<ctx>5__2, this.item.RepairId).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								int num7 = 2;
								num = 2;
								this.<>1__state = num7;
								this.<>u__3 = awaiter3;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopPartService.<UpdatePart>d__4>(ref awaiter3, ref this);
								return;
							}
							IL_20F:
							awaiter3.GetResult();
							this.<transaction>5__3.Commit();
						}
						catch (Exception ex)
						{
							workshopPartService._logger.Error(ex, ex.Message);
							DbContextTransaction dbContextTransaction = this.<transaction>5__3;
							if (dbContextTransaction != null)
							{
								dbContextTransaction.Rollback();
							}
							throw ex;
						}
						finally
						{
							if (num < 0 && this.<transaction>5__3 != null)
							{
								((IDisposable)this.<transaction>5__3).Dispose();
							}
						}
						this.<transaction>5__3 = null;
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

			// Token: 0x06003C55 RID: 15445 RVA: 0x000F180C File Offset: 0x000EFA0C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040027BC RID: 10172
			public int <>1__state;

			// Token: 0x040027BD RID: 10173
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040027BE RID: 10174
			public IWorkPartObject item;

			// Token: 0x040027BF RID: 10175
			public WorkshopPartService <>4__this;

			// Token: 0x040027C0 RID: 10176
			private auseceEntities <ctx>5__2;

			// Token: 0x040027C1 RID: 10177
			private DbContextTransaction <transaction>5__3;

			// Token: 0x040027C2 RID: 10178
			private TaskAwaiter<store_int_reserve> <>u__1;

			// Token: 0x040027C3 RID: 10179
			private TaskAwaiter<int> <>u__2;

			// Token: 0x040027C4 RID: 10180
			private TaskAwaiter <>u__3;
		}

		// Token: 0x020007CE RID: 1998
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06003C56 RID: 15446 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x040027C5 RID: 10181
			public int id;
		}

		// Token: 0x020007CF RID: 1999
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <RemovePart>d__5 : IAsyncStateMachine
		{
			// Token: 0x06003C57 RID: 15447 RVA: 0x000F1828 File Offset: 0x000EFA28
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopPartService workshopPartService = this.<>4__this;
				try
				{
					WorkshopPartService.<>c__DisplayClass5_0 CS$<>8__locals1;
					if (num > 3)
					{
						CS$<>8__locals1 = new WorkshopPartService.<>c__DisplayClass5_0();
						if (this.item.Type != 2)
						{
							throw new ArgumentException("Not part");
						}
						CS$<>8__locals1.id = Math.Abs(this.item.Id);
						this.<history>5__2 = new HistoryV2();
						this.<ctx>5__3 = new auseceEntities(true);
					}
					try
					{
						if (num > 3)
						{
							this.<transaction>5__4 = this.<ctx>5__3.Database.BeginTransaction();
						}
						try
						{
							TaskAwaiter<store_int_reserve> awaiter;
							TaskAwaiter<int> awaiter2;
							TaskAwaiter awaiter3;
							switch (num)
							{
							case 0:
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<store_int_reserve>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								break;
							}
							case 1:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<int>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
								goto IL_1FD;
							}
							case 2:
							{
								awaiter3 = this.<>u__3;
								this.<>u__3 = default(TaskAwaiter);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
								goto IL_272;
							}
							case 3:
							{
								awaiter3 = this.<>u__3;
								this.<>u__3 = default(TaskAwaiter);
								int num5 = -1;
								num = -1;
								this.<>1__state = num5;
								goto IL_2E0;
							}
							default:
								awaiter = this.<ctx>5__3.store_int_reserve.FirstAsync((store_int_reserve i) => i.id == CS$<>8__locals1.id).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num6 = 0;
									num = 0;
									this.<>1__state = num6;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<store_int_reserve>, WorkshopPartService.<RemovePart>d__5>(ref awaiter, ref this);
									return;
								}
								break;
							}
							store_int_reserve result = awaiter.GetResult();
							if (!result.r_lock)
							{
								result.repair_id = null;
							}
							result.work_id = null;
							result.state = 1;
							this.<history>5__2.AddRepairLog("partRemoved", this.item);
							awaiter2 = this.<ctx>5__3.SaveChangesAsync().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num7 = 1;
								num = 1;
								this.<>1__state = num7;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, WorkshopPartService.<RemovePart>d__5>(ref awaiter2, ref this);
								return;
							}
							IL_1FD:
							awaiter2.GetResult();
							awaiter3 = workshopPartService._workshopService.UpdateRepairCostAndWarranty(this.<ctx>5__3, this.item.RepairId).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								int num8 = 2;
								num = 2;
								this.<>1__state = num8;
								this.<>u__3 = awaiter3;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopPartService.<RemovePart>d__5>(ref awaiter3, ref this);
								return;
							}
							IL_272:
							awaiter3.GetResult();
							this.<transaction>5__4.Commit();
							awaiter3 = this.<history>5__2.SaveAsync().GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								int num9 = 3;
								num = 3;
								this.<>1__state = num9;
								this.<>u__3 = awaiter3;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopPartService.<RemovePart>d__5>(ref awaiter3, ref this);
								return;
							}
							IL_2E0:
							awaiter3.GetResult();
						}
						catch (Exception ex)
						{
							workshopPartService._logger.Error(ex, ex.Message);
							DbContextTransaction dbContextTransaction = this.<transaction>5__4;
							if (dbContextTransaction != null)
							{
								dbContextTransaction.Rollback();
							}
							throw ex;
						}
						finally
						{
							if (num < 0 && this.<transaction>5__4 != null)
							{
								((IDisposable)this.<transaction>5__4).Dispose();
							}
						}
						this.<transaction>5__4 = null;
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

			// Token: 0x06003C58 RID: 15448 RVA: 0x000F1C2C File Offset: 0x000EFE2C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040027C6 RID: 10182
			public int <>1__state;

			// Token: 0x040027C7 RID: 10183
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040027C8 RID: 10184
			public IWorkPartObject item;

			// Token: 0x040027C9 RID: 10185
			public WorkshopPartService <>4__this;

			// Token: 0x040027CA RID: 10186
			private HistoryV2 <history>5__2;

			// Token: 0x040027CB RID: 10187
			private auseceEntities <ctx>5__3;

			// Token: 0x040027CC RID: 10188
			private DbContextTransaction <transaction>5__4;

			// Token: 0x040027CD RID: 10189
			private TaskAwaiter<store_int_reserve> <>u__1;

			// Token: 0x040027CE RID: 10190
			private TaskAwaiter<int> <>u__2;

			// Token: 0x040027CF RID: 10191
			private TaskAwaiter <>u__3;
		}
	}
}
