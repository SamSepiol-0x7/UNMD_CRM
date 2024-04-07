using System;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Common.Models;
using ASC.DAL;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Services.Abstract;

namespace ASC.Services.Concrete
{
	// Token: 0x020007DA RID: 2010
	public class WorkshopWorkService : IWorkshopWorkService
	{
		// Token: 0x06003C76 RID: 15478 RVA: 0x000F2F94 File Offset: 0x000F1194
		public WorkshopWorkService(ILoggerService<WorkshopWorkService> logger, IWorkshopService workshopService, IContextFactory contextFactory)
		{
			this._logger = logger;
			this._workshopService = workshopService;
			this._contextFactory = contextFactory;
		}

		// Token: 0x06003C77 RID: 15479 RVA: 0x000F2FBC File Offset: 0x000F11BC
		public Task<int> CreateWork(WorkPartObject work)
		{
			WorkshopWorkService.<CreateWork>d__4 <CreateWork>d__;
			<CreateWork>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<CreateWork>d__.<>4__this = this;
			<CreateWork>d__.work = work;
			<CreateWork>d__.<>1__state = -1;
			<CreateWork>d__.<>t__builder.Start<WorkshopWorkService.<CreateWork>d__4>(ref <CreateWork>d__);
			return <CreateWork>d__.<>t__builder.Task;
		}

		// Token: 0x06003C78 RID: 15480 RVA: 0x000F3008 File Offset: 0x000F1208
		private Task<IEmployeeWorksPercent> GetEmployeePercents(auseceEntities ctx, int employeeId)
		{
			WorkshopWorkService.<GetEmployeePercents>d__5 <GetEmployeePercents>d__;
			<GetEmployeePercents>d__.<>t__builder = AsyncTaskMethodBuilder<IEmployeeWorksPercent>.Create();
			<GetEmployeePercents>d__.ctx = ctx;
			<GetEmployeePercents>d__.employeeId = employeeId;
			<GetEmployeePercents>d__.<>1__state = -1;
			<GetEmployeePercents>d__.<>t__builder.Start<WorkshopWorkService.<GetEmployeePercents>d__5>(ref <GetEmployeePercents>d__);
			return <GetEmployeePercents>d__.<>t__builder.Task;
		}

		// Token: 0x06003C79 RID: 15481 RVA: 0x000F3054 File Offset: 0x000F1254
		public Task UpdateWorks(WorkPartObject item)
		{
			WorkshopWorkService.<UpdateWorks>d__6 <UpdateWorks>d__;
			<UpdateWorks>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<UpdateWorks>d__.<>4__this = this;
			<UpdateWorks>d__.item = item;
			<UpdateWorks>d__.<>1__state = -1;
			<UpdateWorks>d__.<>t__builder.Start<WorkshopWorkService.<UpdateWorks>d__6>(ref <UpdateWorks>d__);
			return <UpdateWorks>d__.<>t__builder.Task;
		}

		// Token: 0x06003C7A RID: 15482 RVA: 0x000F30A0 File Offset: 0x000F12A0
		private Task LogWorkChanges(works original, WorkPartObject current)
		{
			WorkshopWorkService.<LogWorkChanges>d__7 <LogWorkChanges>d__;
			<LogWorkChanges>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LogWorkChanges>d__.original = original;
			<LogWorkChanges>d__.current = current;
			<LogWorkChanges>d__.<>1__state = -1;
			<LogWorkChanges>d__.<>t__builder.Start<WorkshopWorkService.<LogWorkChanges>d__7>(ref <LogWorkChanges>d__);
			return <LogWorkChanges>d__.<>t__builder.Task;
		}

		// Token: 0x06003C7B RID: 15483 RVA: 0x000F30EC File Offset: 0x000F12EC
		public Task RemoveWork(IWorkPartObject item)
		{
			WorkshopWorkService.<RemoveWork>d__8 <RemoveWork>d__;
			<RemoveWork>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<RemoveWork>d__.<>4__this = this;
			<RemoveWork>d__.item = item;
			<RemoveWork>d__.<>1__state = -1;
			<RemoveWork>d__.<>t__builder.Start<WorkshopWorkService.<RemoveWork>d__8>(ref <RemoveWork>d__);
			return <RemoveWork>d__.<>t__builder.Task;
		}

		// Token: 0x040027FC RID: 10236
		private ILoggerService<WorkshopWorkService> _logger;

		// Token: 0x040027FD RID: 10237
		private readonly IWorkshopService _workshopService;

		// Token: 0x040027FE RID: 10238
		private readonly IContextFactory _contextFactory;

		// Token: 0x020007DB RID: 2011
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateWork>d__4 : IAsyncStateMachine
		{
			// Token: 0x06003C7C RID: 15484 RVA: 0x000F3138 File Offset: 0x000F1338
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopWorkService workshopWorkService = this.<>4__this;
				int id;
				try
				{
					if (num > 3)
					{
						this.<history>5__2 = new HistoryV2();
						this.<ctx>5__3 = workshopWorkService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<IEmployeeWorksPercent> awaiter;
						if (num != 0)
						{
							if (num - 1 <= 2)
							{
								goto IL_9F;
							}
							awaiter = workshopWorkService.GetEmployeePercents(this.<ctx>5__3, this.work.EmployeeId).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								goto IL_351;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IEmployeeWorksPercent>);
							int num2 = -1;
							num = -1;
							this.<>1__state = num2;
						}
						IEmployeeWorksPercent result = awaiter.GetResult();
						this.<transaction>5__4 = this.<ctx>5__3.Database.BeginTransaction();
						IL_9F:
						try
						{
							TaskAwaiter<int> awaiter2;
							TaskAwaiter awaiter3;
							switch (num)
							{
							case 1:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<int>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
								break;
							}
							case 2:
							{
								awaiter3 = this.<>u__3;
								this.<>u__3 = default(TaskAwaiter);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
								goto IL_28A;
							}
							case 3:
							{
								awaiter3 = this.<>u__3;
								this.<>u__3 = default(TaskAwaiter);
								int num5 = -1;
								num = -1;
								this.<>1__state = num5;
								goto IL_2F8;
							}
							default:
								this.<w>5__5 = new works
								{
									user = this.work.EmployeeId,
									repair = new int?(this.work.RepairId),
									name = this.work.Name,
									price = this.work.Price,
									price_id = this.work.WorkPriceId,
									warranty = this.work.Warranty,
									added = new DateTime?(DateTime.UtcNow),
									type = 0,
									pay_repair = new int?(result.Repair),
									pay_repair_quick = new int?(result.QuickRepair),
									count = (long)this.work.Count
								};
								this.<ctx>5__3.works.Add(this.<w>5__5);
								awaiter2 = this.<ctx>5__3.SaveChangesAsync().GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									int num6 = 1;
									num = 1;
									this.<>1__state = num6;
									this.<>u__2 = awaiter2;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, WorkshopWorkService.<CreateWork>d__4>(ref awaiter2, ref this);
									return;
								}
								break;
							}
							awaiter2.GetResult();
							this.work.Id = this.<w>5__5.id;
							this.<history>5__2.AddRepairLog("workAdded", this.work);
							awaiter3 = workshopWorkService._workshopService.UpdateRepairCostAndWarranty(this.<ctx>5__3, this.work.RepairId).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								int num7 = 2;
								num = 2;
								this.<>1__state = num7;
								this.<>u__3 = awaiter3;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopWorkService.<CreateWork>d__4>(ref awaiter3, ref this);
								return;
							}
							IL_28A:
							awaiter3.GetResult();
							this.<transaction>5__4.Commit();
							awaiter3 = this.<history>5__2.SaveAsync().GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								int num8 = 3;
								num = 3;
								this.<>1__state = num8;
								this.<>u__3 = awaiter3;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopWorkService.<CreateWork>d__4>(ref awaiter3, ref this);
								return;
							}
							IL_2F8:
							awaiter3.GetResult();
							id = this.<w>5__5.id;
							goto IL_3AA;
						}
						catch (Exception ex)
						{
							workshopWorkService._logger.Error(ex, ex.Message);
							DbContextTransaction dbContextTransaction = this.<transaction>5__4;
							if (dbContextTransaction != null)
							{
								dbContextTransaction.Rollback();
							}
							throw;
						}
						finally
						{
							if (num < 0 && this.<transaction>5__4 != null)
							{
								((IDisposable)this.<transaction>5__4).Dispose();
							}
						}
						IL_351:
						int num9 = 0;
						num = 0;
						this.<>1__state = num9;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEmployeeWorksPercent>, WorkshopWorkService.<CreateWork>d__4>(ref awaiter, ref this);
						return;
					}
					finally
					{
						if (num < 0 && this.<ctx>5__3 != null)
						{
							((IDisposable)this.<ctx>5__3).Dispose();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<history>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_3AA:
				this.<>1__state = -2;
				this.<history>5__2 = null;
				this.<>t__builder.SetResult(id);
			}

			// Token: 0x06003C7D RID: 15485 RVA: 0x000F3570 File Offset: 0x000F1770
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040027FF RID: 10239
			public int <>1__state;

			// Token: 0x04002800 RID: 10240
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x04002801 RID: 10241
			public WorkshopWorkService <>4__this;

			// Token: 0x04002802 RID: 10242
			public WorkPartObject work;

			// Token: 0x04002803 RID: 10243
			private HistoryV2 <history>5__2;

			// Token: 0x04002804 RID: 10244
			private auseceEntities <ctx>5__3;

			// Token: 0x04002805 RID: 10245
			private TaskAwaiter<IEmployeeWorksPercent> <>u__1;

			// Token: 0x04002806 RID: 10246
			private DbContextTransaction <transaction>5__4;

			// Token: 0x04002807 RID: 10247
			private works <w>5__5;

			// Token: 0x04002808 RID: 10248
			private TaskAwaiter<int> <>u__2;

			// Token: 0x04002809 RID: 10249
			private TaskAwaiter <>u__3;
		}

		// Token: 0x020007DC RID: 2012
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06003C7E RID: 15486 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x0400280A RID: 10250
			public int employeeId;
		}

		// Token: 0x020007DD RID: 2013
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003C7F RID: 15487 RVA: 0x000F358C File Offset: 0x000F178C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003C80 RID: 15488 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x0400280B RID: 10251
			public static readonly WorkshopWorkService.<>c <>9 = new WorkshopWorkService.<>c();
		}

		// Token: 0x020007DE RID: 2014
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetEmployeePercents>d__5 : IAsyncStateMachine
		{
			// Token: 0x06003C81 RID: 15489 RVA: 0x000F35A4 File Offset: 0x000F17A4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IEmployeeWorksPercent result2;
				try
				{
					var awaiter;
					if (num != 0)
					{
						WorkshopWorkService.<>c__DisplayClass5_0 CS$<>8__locals1 = new WorkshopWorkService.<>c__DisplayClass5_0();
						CS$<>8__locals1.employeeId = this.employeeId;
						awaiter = (from i in this.ctx.users
						where i.id == CS$<>8__locals1.employeeId
						select new
						{
							i.pay_repair,
							i.pay_repair_quick
						}).SingleAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<<>f__AnonymousType3<int, int>>);
						this.<>1__state = -1;
					}
					var result = awaiter.GetResult();
					result2 = new EmployeeWorksPercent(result.pay_repair, result.pay_repair_quick);
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

			// Token: 0x06003C82 RID: 15490 RVA: 0x000F37A8 File Offset: 0x000F19A8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400280C RID: 10252
			public int <>1__state;

			// Token: 0x0400280D RID: 10253
			public AsyncTaskMethodBuilder<IEmployeeWorksPercent> <>t__builder;

			// Token: 0x0400280E RID: 10254
			public int employeeId;

			// Token: 0x0400280F RID: 10255
			public auseceEntities ctx;

			// Token: 0x04002810 RID: 10256
			private TaskAwaiter<<>f__AnonymousType3<int, int>> <>u__1;
		}

		// Token: 0x020007DF RID: 2015
		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x06003C83 RID: 15491 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x04002811 RID: 10257
			public WorkPartObject item;
		}

		// Token: 0x020007E0 RID: 2016
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateWorks>d__6 : IAsyncStateMachine
		{
			// Token: 0x06003C84 RID: 15492 RVA: 0x000F37C4 File Offset: 0x000F19C4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopWorkService workshopWorkService = this.<>4__this;
				try
				{
					if (num > 4)
					{
						this.<>8__1 = new WorkshopWorkService.<>c__DisplayClass6_0();
						this.<>8__1.item = this.item;
						this.<ctx>5__2 = workshopWorkService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<works> awaiter;
						if (num != 0)
						{
							if (num - 1 <= 3)
							{
								goto IL_14B;
							}
							awaiter = this.<ctx>5__2.works.FirstAsync((works i) => i.id == this.<>8__1.item.Id).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<works>, WorkshopWorkService.<UpdateWorks>d__6>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<works>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						works result = awaiter.GetResult();
						this.<work>5__3 = result;
						this.<transaction>5__4 = this.<ctx>5__2.Database.BeginTransaction();
						IL_14B:
						try
						{
							TaskAwaiter awaiter2;
							TaskAwaiter<IEmployeeWorksPercent> awaiter3;
							TaskAwaiter<int> awaiter4;
							switch (num)
							{
							case 1:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
								break;
							}
							case 2:
							{
								awaiter3 = this.<>u__3;
								this.<>u__3 = default(TaskAwaiter<IEmployeeWorksPercent>);
								int num5 = -1;
								num = -1;
								this.<>1__state = num5;
								goto IL_2EB;
							}
							case 3:
							{
								awaiter4 = this.<>u__4;
								this.<>u__4 = default(TaskAwaiter<int>);
								int num6 = -1;
								num = -1;
								this.<>1__state = num6;
								goto IL_37E;
							}
							case 4:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter);
								int num7 = -1;
								num = -1;
								this.<>1__state = num7;
								goto IL_3F8;
							}
							default:
								awaiter2 = workshopWorkService.LogWorkChanges(this.<work>5__3, this.<>8__1.item).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									int num8 = 1;
									num = 1;
									this.<>1__state = num8;
									this.<>u__2 = awaiter2;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopWorkService.<UpdateWorks>d__6>(ref awaiter2, ref this);
									return;
								}
								break;
							}
							awaiter2.GetResult();
							this.<work>5__3.name = this.<>8__1.item.Name;
							this.<work>5__3.price = this.<>8__1.item.Price;
							this.<work>5__3.warranty = this.<>8__1.item.Warranty;
							this.<work>5__3.count = (long)this.<>8__1.item.Count;
							if (this.<work>5__3.user == this.<>8__1.item.EmployeeId)
							{
								goto IL_322;
							}
							this.<work>5__3.user = this.<>8__1.item.EmployeeId;
							awaiter3 = workshopWorkService.GetEmployeePercents(this.<ctx>5__2, this.<>8__1.item.EmployeeId).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								int num9 = 2;
								num = 2;
								this.<>1__state = num9;
								this.<>u__3 = awaiter3;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEmployeeWorksPercent>, WorkshopWorkService.<UpdateWorks>d__6>(ref awaiter3, ref this);
								return;
							}
							IL_2EB:
							IEmployeeWorksPercent result2 = awaiter3.GetResult();
							this.<work>5__3.pay_repair = new int?(result2.Repair);
							this.<work>5__3.pay_repair_quick = new int?(result2.QuickRepair);
							IL_322:
							awaiter4 = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
							if (!awaiter4.IsCompleted)
							{
								int num10 = 3;
								num = 3;
								this.<>1__state = num10;
								this.<>u__4 = awaiter4;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, WorkshopWorkService.<UpdateWorks>d__6>(ref awaiter4, ref this);
								return;
							}
							IL_37E:
							awaiter4.GetResult();
							awaiter2 = workshopWorkService._workshopService.UpdateRepairCostAndWarranty(this.<ctx>5__2, this.<>8__1.item.RepairId).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num11 = 4;
								num = 4;
								this.<>1__state = num11;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopWorkService.<UpdateWorks>d__6>(ref awaiter2, ref this);
								return;
							}
							IL_3F8:
							awaiter2.GetResult();
							this.<transaction>5__4.Commit();
						}
						catch (Exception ex)
						{
							workshopWorkService._logger.Error(ex, ex.Message);
							DbContextTransaction dbContextTransaction = this.<transaction>5__4;
							if (dbContextTransaction != null)
							{
								dbContextTransaction.Rollback();
							}
							throw;
						}
						finally
						{
							if (num < 0 && this.<transaction>5__4 != null)
							{
								((IDisposable)this.<transaction>5__4).Dispose();
							}
						}
						this.<transaction>5__4 = null;
						this.<work>5__3 = null;
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
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003C85 RID: 15493 RVA: 0x000F3CF0 File Offset: 0x000F1EF0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002812 RID: 10258
			public int <>1__state;

			// Token: 0x04002813 RID: 10259
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002814 RID: 10260
			public WorkPartObject item;

			// Token: 0x04002815 RID: 10261
			public WorkshopWorkService <>4__this;

			// Token: 0x04002816 RID: 10262
			private WorkshopWorkService.<>c__DisplayClass6_0 <>8__1;

			// Token: 0x04002817 RID: 10263
			private auseceEntities <ctx>5__2;

			// Token: 0x04002818 RID: 10264
			private works <work>5__3;

			// Token: 0x04002819 RID: 10265
			private TaskAwaiter<works> <>u__1;

			// Token: 0x0400281A RID: 10266
			private DbContextTransaction <transaction>5__4;

			// Token: 0x0400281B RID: 10267
			private TaskAwaiter <>u__2;

			// Token: 0x0400281C RID: 10268
			private TaskAwaiter<IEmployeeWorksPercent> <>u__3;

			// Token: 0x0400281D RID: 10269
			private TaskAwaiter<int> <>u__4;
		}

		// Token: 0x020007E1 RID: 2017
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LogWorkChanges>d__7 : IAsyncStateMachine
		{
			// Token: 0x06003C86 RID: 15494 RVA: 0x000F3D0C File Offset: 0x000F1F0C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						HistoryV2 historyV = new HistoryV2();
						if (this.original.name != this.current.Name)
						{
							historyV.AddRepairLog("WorkNameChanged", this.current.RepairId, this.original.name, this.current.Name);
						}
						if (this.original.price != this.current.Price)
						{
							historyV.AddRepairLog("WorkPriceChanged", this.current.RepairId, this.original.price.ToString("N0"), this.current.Price.ToString("N0"));
						}
						if (this.original.warranty != this.current.Warranty)
						{
							historyV.AddRepairLog("WorkWarrantyChanged", this.current.RepairId, this.original.warranty.ToString(), this.current.Warranty.ToString());
						}
						if (this.original.user != this.current.EmployeeId)
						{
							this.current.Repairman = UsersModel.GetEmployeeForReport(this.current.EmployeeId);
							historyV.AddRepairLog("WorkEmployeeChanged", this.current.RepairId, this.original.name, this.current.Repairman.FioShort);
						}
						awaiter = historyV.SaveAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopWorkService.<LogWorkChanges>d__7>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
					}
					awaiter.GetResult();
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

			// Token: 0x06003C87 RID: 15495 RVA: 0x000F3F38 File Offset: 0x000F2138
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400281E RID: 10270
			public int <>1__state;

			// Token: 0x0400281F RID: 10271
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002820 RID: 10272
			public works original;

			// Token: 0x04002821 RID: 10273
			public WorkPartObject current;

			// Token: 0x04002822 RID: 10274
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020007E2 RID: 2018
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <RemoveWork>d__8 : IAsyncStateMachine
		{
			// Token: 0x06003C88 RID: 15496 RVA: 0x000F3F54 File Offset: 0x000F2154
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopWorkService workshopWorkService = this.<>4__this;
				try
				{
					if (num > 2)
					{
						if (this.item.Type != 1)
						{
							throw new ArgumentException("Not work");
						}
						this.<history>5__2 = new HistoryV2();
						this.<ctx>5__3 = workshopWorkService._contextFactory.Create();
					}
					try
					{
						if (num > 2)
						{
							this.<transaction>5__4 = this.<ctx>5__3.Database.BeginTransaction();
						}
						try
						{
							TaskAwaiter<int> awaiter;
							TaskAwaiter awaiter2;
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
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
								goto IL_195;
							}
							case 2:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
								goto IL_203;
							}
							default:
							{
								works entity = new works
								{
									id = this.item.Id
								};
								this.<ctx>5__3.works.Attach(entity);
								this.<ctx>5__3.works.Remove(entity);
								this.<history>5__2.AddRepairLog("workRemoved", this.item);
								awaiter = this.<ctx>5__3.SaveChangesAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num5 = 0;
									num = 0;
									this.<>1__state = num5;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, WorkshopWorkService.<RemoveWork>d__8>(ref awaiter, ref this);
									return;
								}
								break;
							}
							}
							awaiter.GetResult();
							awaiter2 = workshopWorkService._workshopService.UpdateRepairCostAndWarranty(this.<ctx>5__3, this.item.RepairId).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num6 = 1;
								num = 1;
								this.<>1__state = num6;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopWorkService.<RemoveWork>d__8>(ref awaiter2, ref this);
								return;
							}
							IL_195:
							awaiter2.GetResult();
							this.<transaction>5__4.Commit();
							awaiter2 = this.<history>5__2.SaveAsync().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num7 = 2;
								num = 2;
								this.<>1__state = num7;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopWorkService.<RemoveWork>d__8>(ref awaiter2, ref this);
								return;
							}
							IL_203:
							awaiter2.GetResult();
						}
						catch (Exception ex)
						{
							workshopWorkService._logger.Error(ex, ex.Message);
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

			// Token: 0x06003C89 RID: 15497 RVA: 0x000F427C File Offset: 0x000F247C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002823 RID: 10275
			public int <>1__state;

			// Token: 0x04002824 RID: 10276
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002825 RID: 10277
			public IWorkPartObject item;

			// Token: 0x04002826 RID: 10278
			public WorkshopWorkService <>4__this;

			// Token: 0x04002827 RID: 10279
			private HistoryV2 <history>5__2;

			// Token: 0x04002828 RID: 10280
			private auseceEntities <ctx>5__3;

			// Token: 0x04002829 RID: 10281
			private DbContextTransaction <transaction>5__4;

			// Token: 0x0400282A RID: 10282
			private TaskAwaiter<int> <>u__1;

			// Token: 0x0400282B RID: 10283
			private TaskAwaiter <>u__2;
		}
	}
}
