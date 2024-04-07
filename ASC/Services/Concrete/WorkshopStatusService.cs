using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Extensions.EpochtaSms;
using ASC.Extensions.SmsRu;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Options;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using Autofac;

namespace ASC.Services.Concrete
{
	// Token: 0x020007D0 RID: 2000
	public class WorkshopStatusService : IWorkshopStatusService
	{
		// Token: 0x06003C59 RID: 15449 RVA: 0x000F1C48 File Offset: 0x000EFE48
		public WorkshopStatusService(ILoggerService<WorkshopStatusService> loggerService, IWorkshopHistoryService workshopHistoryService)
		{
			this._loggerService = loggerService;
			this._workshopHistoryService = workshopHistoryService;
		}

		// Token: 0x06003C5A RID: 15450 RVA: 0x000F1C6C File Offset: 0x000EFE6C
		public Task<workshop> UpdateStatus(workshop repair)
		{
			WorkshopStatusService.<UpdateStatus>d__3 <UpdateStatus>d__;
			<UpdateStatus>d__.<>t__builder = AsyncTaskMethodBuilder<workshop>.Create();
			<UpdateStatus>d__.<>4__this = this;
			<UpdateStatus>d__.repair = repair;
			<UpdateStatus>d__.<>1__state = -1;
			<UpdateStatus>d__.<>t__builder.Start<WorkshopStatusService.<UpdateStatus>d__3>(ref <UpdateStatus>d__);
			return <UpdateStatus>d__.<>t__builder.Task;
		}

		// Token: 0x06003C5B RID: 15451 RVA: 0x000F1CB8 File Offset: 0x000EFEB8
		public Task AdminUpdateStatus(int repairId, int nextStatus)
		{
			WorkshopStatusService.<AdminUpdateStatus>d__4 <AdminUpdateStatus>d__;
			<AdminUpdateStatus>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<AdminUpdateStatus>d__.<>4__this = this;
			<AdminUpdateStatus>d__.repairId = repairId;
			<AdminUpdateStatus>d__.nextStatus = nextStatus;
			<AdminUpdateStatus>d__.<>1__state = -1;
			<AdminUpdateStatus>d__.<>t__builder.Start<WorkshopStatusService.<AdminUpdateStatus>d__4>(ref <AdminUpdateStatus>d__);
			return <AdminUpdateStatus>d__.<>t__builder.Task;
		}

		// Token: 0x06003C5C RID: 15452 RVA: 0x000F1D0C File Offset: 0x000EFF0C
		private bool OutOfServiceCenter(int status)
		{
			return status == 8 || status == 12;
		}

		// Token: 0x06003C5D RID: 15453 RVA: 0x000F1D24 File Offset: 0x000EFF24
		public Task UpdateStatusLog(auseceEntities ctx, RepairStatusLogModel repairStatusLogModel)
		{
			WorkshopStatusService.<UpdateStatusLog>d__6 <UpdateStatusLog>d__;
			<UpdateStatusLog>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<UpdateStatusLog>d__.ctx = ctx;
			<UpdateStatusLog>d__.repairStatusLogModel = repairStatusLogModel;
			<UpdateStatusLog>d__.<>1__state = -1;
			<UpdateStatusLog>d__.<>t__builder.Start<WorkshopStatusService.<UpdateStatusLog>d__6>(ref <UpdateStatusLog>d__);
			return <UpdateStatusLog>d__.<>t__builder.Task;
		}

		// Token: 0x06003C5E RID: 15454 RVA: 0x000F1D70 File Offset: 0x000EFF70
		private static void AssignMasterOnNewRepair(workshop repair, IHistoryV2 history)
		{
			repair.master = new int?(OfflineData.Instance.Employee.Id);
			history.AddRepairLog("masterChanged", repair.id, Auth.User, null, null, null, null, null);
		}

		// Token: 0x06003C5F RID: 15455 RVA: 0x000F1DB4 File Offset: 0x000EFFB4
		private static void CreateNotifications(workshop repair, WorkshopOptions workshopOptions)
		{
			WorkshopOptions option = workshopOptions.GetOption(repair.new_state);
			List<int> list = new List<int>();
			if (workshopOptions.InformManager(repair.new_state))
			{
				list.Add(repair.current_manager);
			}
			if (workshopOptions.InformMaster(repair.new_state) && repair.master != null)
			{
				list.Add(repair.master.Value);
			}
			if (list.Any<int>())
			{
				foreach (int employeeId in list.Distinct<int>().ToList<int>())
				{
					NotificationService.CreateStatusNotification(repair.id, repair.Title, (option != null) ? option.Name : null, employeeId);
				}
			}
		}

		// Token: 0x06003C60 RID: 15456 RVA: 0x000F1E90 File Offset: 0x000F0090
		private void SendSms(workshop repair, WorkshopOptions workshopOptions)
		{
			WorkshopStatusService.<SendSms>d__9 <SendSms>d__;
			<SendSms>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SendSms>d__.repair = repair;
			<SendSms>d__.workshopOptions = workshopOptions;
			<SendSms>d__.<>1__state = -1;
			<SendSms>d__.<>t__builder.Start<WorkshopStatusService.<SendSms>d__9>(ref <SendSms>d__);
		}

		// Token: 0x06003C61 RID: 15457 RVA: 0x000F1ED0 File Offset: 0x000F00D0
		private void ResetClientInformStatus(workshop repair)
		{
			try
			{
				HistoryV2 historyV = new HistoryV2();
				ClientInformOptions clientInformOptions = new ClientInformOptions();
				historyV.AddRepairLog("InformStatusReset", repair.id, clientInformOptions.GetOptionNameById(repair.informed_status), "");
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					auseceEntities.Configuration.ValidateOnSaveEnabled = false;
					workshop workshop = new workshop
					{
						id = repair.id,
						informed_status = repair.informed_status
					};
					auseceEntities.workshop.Attach(workshop);
					workshop.informed_status = 0;
					auseceEntities.SaveChanges();
					historyV.Save();
					repair.informed_status = 0;
				}
			}
			catch (Exception ex)
			{
				this._loggerService.Error(ex, ex.Message);
			}
		}

		// Token: 0x06003C62 RID: 15458 RVA: 0x000F1FA8 File Offset: 0x000F01A8
		public void SetWorksToZero(workshop repair)
		{
			if (repair.new_state == 7)
			{
				HistoryV2 historyV = new HistoryV2();
				try
				{
					using (auseceEntities auseceEntities = new auseceEntities(true))
					{
						List<works> list = (from w in auseceEntities.works
						where w.repair == (int?)repair.id
						select w).ToList<works>();
						if (list.Any<works>())
						{
							foreach (works works in list)
							{
								works.price = 0m;
							}
							auseceEntities.SaveChanges();
						}
						repair.repair_cost = 0m;
						historyV.AddRepairLog("SetRepairCostToZero", repair.id, repair.repair_cost.ToString("N0"), "");
						historyV.AddRepairLog("SetWorksToZero", repair.id, null, null, null, null, null, null);
						historyV.Save();
					}
				}
				catch (Exception ex)
				{
					this._loggerService.Error(ex, ex.Message);
				}
				return;
			}
		}

		// Token: 0x06003C63 RID: 15459 RVA: 0x000F2194 File Offset: 0x000F0394
		public List<WorkshopOptions> GetStatusList()
		{
			List<WorkshopOptions> allOptions = new WorkshopOptions().GetAllOptions();
			List<int> activeStatusIds = (from i in allOptions
			where i.Contains != null
			select i).SelectMany((WorkshopOptions i) => i.Contains).ToList<int>();
			activeStatusIds.Add(0);
			activeStatusIds = activeStatusIds.Distinct<int>().ToList<int>();
			return (from i in allOptions
			where activeStatusIds.Contains(i.Id)
			orderby i.Name
			select i).ToList<WorkshopOptions>();
		}

		// Token: 0x040027D0 RID: 10192
		private readonly ILoggerService<WorkshopStatusService> _loggerService;

		// Token: 0x040027D1 RID: 10193
		private readonly IWorkshopHistoryService _workshopHistoryService;

		// Token: 0x020007D1 RID: 2001
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06003C64 RID: 15460 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x040027D2 RID: 10194
			public workshop repair;
		}

		// Token: 0x020007D2 RID: 2002
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateStatus>d__3 : IAsyncStateMachine
		{
			// Token: 0x06003C65 RID: 15461 RVA: 0x000F2264 File Offset: 0x000F0464
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopStatusService workshopStatusService = this.<>4__this;
				workshop result2;
				try
				{
					if (num > 3)
					{
						this.<>8__1 = new WorkshopStatusService.<>c__DisplayClass3_0();
						this.<>8__1.repair = this.repair;
						this.<workshopOptions>5__2 = new WorkshopOptions();
						this.<history>5__3 = new HistoryV2();
						this.<history>5__3.StateChangeLog(this.<>8__1.repair);
					}
					try
					{
						if (num > 3)
						{
							if (this.<>8__1.repair.master == null && this.<>8__1.repair.state == 0 && OfflineData.Instance.Employee.Can(57, 0))
							{
								WorkshopStatusService.AssignMasterOnNewRepair(this.<>8__1.repair, this.<history>5__3);
							}
							workshopStatusService.SetWorksToZero(this.<>8__1.repair);
							if (this.<>8__1.repair.informed_status != 0 && this.<workshopOptions>5__2.NeedInformStatusReset(this.<>8__1.repair.new_state))
							{
								workshopStatusService.ResetClientInformStatus(this.<>8__1.repair);
							}
							this.<ctx>5__4 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<workshop> awaiter;
							TaskAwaiter awaiter2;
							TaskAwaiter<int> awaiter3;
							switch (num)
							{
							case 0:
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<workshop>);
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
								goto IL_284;
							}
							case 2:
							{
								awaiter3 = this.<>u__3;
								this.<>u__3 = default(TaskAwaiter<int>);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
								goto IL_36E;
							}
							case 3:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter);
								int num5 = -1;
								num = -1;
								this.<>1__state = num5;
								goto IL_438;
							}
							default:
								awaiter = this.<ctx>5__4.workshop.SingleAsync((workshop i) => i.id == this.<>8__1.repair.id).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num6 = 0;
									num = 0;
									this.<>1__state = num6;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop>, WorkshopStatusService.<UpdateStatus>d__3>(ref awaiter, ref this);
									return;
								}
								break;
							}
							workshop result = awaiter.GetResult();
							this.<original>5__5 = result;
							awaiter2 = workshopStatusService._workshopHistoryService.LogRepairChanges(this.<original>5__5, this.<>8__1.repair).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num7 = 1;
								num = 1;
								this.<>1__state = num7;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopStatusService.<UpdateStatus>d__3>(ref awaiter2, ref this);
								return;
							}
							IL_284:
							awaiter2.GetResult();
							this.<original>5__5.state = this.<>8__1.repair.new_state;
							this.<original>5__5.last_status_changed = new DateTime?(Localization.GetServerUtcTime(this.<ctx>5__4));
							this.<original>5__5.diagnostic_result = this.<>8__1.repair.diagnostic_result;
							this.<original>5__5.repair_cost = this.<>8__1.repair.repair_cost;
							this.<original>5__5.master = this.<>8__1.repair.master;
							awaiter3 = this.<ctx>5__4.SaveChangesAsync().GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								int num8 = 2;
								num = 2;
								this.<>1__state = num8;
								this.<>u__3 = awaiter3;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, WorkshopStatusService.<UpdateStatus>d__3>(ref awaiter3, ref this);
								return;
							}
							IL_36E:
							awaiter3.GetResult();
							this.<>8__1.repair.real_repair_cost = this.<original>5__5.real_repair_cost;
							if (this.<>8__1.repair.sms_inform)
							{
								workshopStatusService.SendSms(this.<>8__1.repair, this.<workshopOptions>5__2);
							}
							WorkshopStatusService.CreateNotifications(this.<>8__1.repair, this.<workshopOptions>5__2);
							awaiter2 = workshopStatusService.UpdateStatusLog(this.<ctx>5__4, new RepairStatusLogModel(this.<original>5__5)).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num9 = 3;
								num = 3;
								this.<>1__state = num9;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopStatusService.<UpdateStatus>d__3>(ref awaiter2, ref this);
								return;
							}
							IL_438:
							awaiter2.GetResult();
							this.<original>5__5 = null;
						}
						finally
						{
							if (num < 0 && this.<ctx>5__4 != null)
							{
								((IDisposable)this.<ctx>5__4).Dispose();
							}
						}
						this.<ctx>5__4 = null;
					}
					catch (Exception ex)
					{
						workshopStatusService._loggerService.Error(ex, ex.Message);
						throw;
					}
					this.<history>5__3.Save();
					this.<>8__1.repair.state = this.<>8__1.repair.new_state;
					result2 = this.<>8__1.repair;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<workshopOptions>5__2 = null;
					this.<history>5__3 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<workshopOptions>5__2 = null;
				this.<history>5__3 = null;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06003C66 RID: 15462 RVA: 0x000F27D0 File Offset: 0x000F09D0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040027D3 RID: 10195
			public int <>1__state;

			// Token: 0x040027D4 RID: 10196
			public AsyncTaskMethodBuilder<workshop> <>t__builder;

			// Token: 0x040027D5 RID: 10197
			public workshop repair;

			// Token: 0x040027D6 RID: 10198
			public WorkshopStatusService <>4__this;

			// Token: 0x040027D7 RID: 10199
			private WorkshopStatusService.<>c__DisplayClass3_0 <>8__1;

			// Token: 0x040027D8 RID: 10200
			private WorkshopOptions <workshopOptions>5__2;

			// Token: 0x040027D9 RID: 10201
			private HistoryV2 <history>5__3;

			// Token: 0x040027DA RID: 10202
			private auseceEntities <ctx>5__4;

			// Token: 0x040027DB RID: 10203
			private workshop <original>5__5;

			// Token: 0x040027DC RID: 10204
			private TaskAwaiter<workshop> <>u__1;

			// Token: 0x040027DD RID: 10205
			private TaskAwaiter <>u__2;

			// Token: 0x040027DE RID: 10206
			private TaskAwaiter<int> <>u__3;
		}

		// Token: 0x020007D3 RID: 2003
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x06003C67 RID: 15463 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x040027DF RID: 10207
			public int repairId;
		}

		// Token: 0x020007D4 RID: 2004
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <AdminUpdateStatus>d__4 : IAsyncStateMachine
		{
			// Token: 0x06003C68 RID: 15464 RVA: 0x000F27EC File Offset: 0x000F09EC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopStatusService workshopStatusService = this.<>4__this;
				try
				{
					if (num > 3)
					{
						this.<>8__1 = new WorkshopStatusService.<>c__DisplayClass4_0();
						this.<>8__1.repairId = this.repairId;
					}
					try
					{
						if (num > 3)
						{
							this.<history>5__2 = new HistoryV2();
							this.<ctx>5__3 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<workshop> awaiter;
							TaskAwaiter<int> awaiter2;
							TaskAwaiter awaiter3;
							switch (num)
							{
							case 0:
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<workshop>);
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
								goto IL_1E3;
							}
							case 2:
							{
								awaiter3 = this.<>u__3;
								this.<>u__3 = default(TaskAwaiter);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
								goto IL_279;
							}
							case 3:
							{
								awaiter3 = this.<>u__3;
								this.<>u__3 = default(TaskAwaiter);
								int num5 = -1;
								num = -1;
								this.<>1__state = num5;
								goto IL_2E8;
							}
							default:
								awaiter = this.<ctx>5__3.workshop.SingleAsync((workshop i) => i.id == this.<>8__1.repairId).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num6 = 0;
									num = 0;
									this.<>1__state = num6;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop>, WorkshopStatusService.<AdminUpdateStatus>d__4>(ref awaiter, ref this);
									return;
								}
								break;
							}
							workshop result = awaiter.GetResult();
							this.<repair>5__4 = result;
							if (workshopStatusService.OutOfServiceCenter(this.<repair>5__4.state))
							{
								this.<repair>5__4.out_date = null;
							}
							this.<repair>5__4.state = this.nextStatus;
							this.<repair>5__4.last_status_changed = new DateTime?(Localization.GetServerUtcTime(this.<ctx>5__3));
							awaiter2 = this.<ctx>5__3.SaveChangesAsync().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num7 = 1;
								num = 1;
								this.<>1__state = num7;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, WorkshopStatusService.<AdminUpdateStatus>d__4>(ref awaiter2, ref this);
								return;
							}
							IL_1E3:
							awaiter2.GetResult();
							this.<history>5__2.AdminUpdateStatusLog(this.<>8__1.repairId, this.<repair>5__4.state, this.nextStatus, this.<repair>5__4.repair_cost);
							awaiter3 = this.<history>5__2.SaveAsync().GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								int num8 = 2;
								num = 2;
								this.<>1__state = num8;
								this.<>u__3 = awaiter3;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopStatusService.<AdminUpdateStatus>d__4>(ref awaiter3, ref this);
								return;
							}
							IL_279:
							awaiter3.GetResult();
							awaiter3 = workshopStatusService.UpdateStatusLog(this.<ctx>5__3, new RepairStatusLogModel(this.<repair>5__4)).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								int num9 = 3;
								num = 3;
								this.<>1__state = num9;
								this.<>u__3 = awaiter3;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopStatusService.<AdminUpdateStatus>d__4>(ref awaiter3, ref this);
								return;
							}
							IL_2E8:
							awaiter3.GetResult();
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
					catch (Exception ex)
					{
						workshopStatusService._loggerService.Error(ex, ex.Message);
						throw;
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
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003C69 RID: 15465 RVA: 0x000F2BBC File Offset: 0x000F0DBC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040027E0 RID: 10208
			public int <>1__state;

			// Token: 0x040027E1 RID: 10209
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040027E2 RID: 10210
			public int repairId;

			// Token: 0x040027E3 RID: 10211
			public WorkshopStatusService <>4__this;

			// Token: 0x040027E4 RID: 10212
			public int nextStatus;

			// Token: 0x040027E5 RID: 10213
			private WorkshopStatusService.<>c__DisplayClass4_0 <>8__1;

			// Token: 0x040027E6 RID: 10214
			private HistoryV2 <history>5__2;

			// Token: 0x040027E7 RID: 10215
			private auseceEntities <ctx>5__3;

			// Token: 0x040027E8 RID: 10216
			private workshop <repair>5__4;

			// Token: 0x040027E9 RID: 10217
			private TaskAwaiter<workshop> <>u__1;

			// Token: 0x040027EA RID: 10218
			private TaskAwaiter<int> <>u__2;

			// Token: 0x040027EB RID: 10219
			private TaskAwaiter <>u__3;
		}

		// Token: 0x020007D5 RID: 2005
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateStatusLog>d__6 : IAsyncStateMachine
		{
			// Token: 0x06003C6A RID: 15466 RVA: 0x000F2BD8 File Offset: 0x000F0DD8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					TaskAwaiter<int> awaiter;
					if (num != 0)
					{
						this.ctx.repair_status_logs.Add(new repair_status_logs
						{
							CreatedAt = Localization.GetServerUtcTime(this.ctx),
							RepairId = this.repairStatusLogModel.RepairId,
							StatusId = this.repairStatusLogModel.StatusId,
							UserId = this.repairStatusLogModel.UserId,
							ManagerId = this.repairStatusLogModel.ManagerId,
							MasterId = this.repairStatusLogModel.MasterId
						});
						awaiter = this.ctx.SaveChangesAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, WorkshopStatusService.<UpdateStatusLog>d__6>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<int>);
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

			// Token: 0x06003C6B RID: 15467 RVA: 0x000F2D08 File Offset: 0x000F0F08
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040027EC RID: 10220
			public int <>1__state;

			// Token: 0x040027ED RID: 10221
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040027EE RID: 10222
			public auseceEntities ctx;

			// Token: 0x040027EF RID: 10223
			public RepairStatusLogModel repairStatusLogModel;

			// Token: 0x040027F0 RID: 10224
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x020007D6 RID: 2006
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SendSms>d__9 : IAsyncStateMachine
		{
			// Token: 0x06003C6C RID: 15468 RVA: 0x000F2D24 File Offset: 0x000F0F24
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						int smsTemplateId;
						SmsClientConfig smsClientConfig;
						ISmsClient smsClient;
						for (;;)
						{
							IL_DE:
							smsTemplateId = this.workshopOptions.GetSmsTemplateId(this.repair.new_state);
							if (smsTemplateId == 0)
							{
								break;
							}
							for (;;)
							{
								IL_D6:
								smsClientConfig = SmsModel.GetSmsClientConfig();
								IL_CE:
								while (smsClientConfig != null)
								{
									for (;;)
									{
										IL_CA:
										smsClient = null;
										for (;;)
										{
											IL_C0:
											int provider = smsClientConfig.Provider;
											for (;;)
											{
												IL_A6:
												switch (provider)
												{
												case 1:
													goto IL_FD;
												case 2:
													goto IL_106;
												case 3:
													goto IL_10F;
												default:
												{
													uint num3;
													uint num2 = num3 * 451916942U ^ 615267577U;
													for (;;)
													{
														switch ((num3 = (num2 ^ 2743412856U)) % 24U)
														{
														case 0U:
															goto IL_10F;
														case 1U:
															goto IL_C0;
														case 2U:
														case 19U:
														case 21U:
															goto IL_11F;
														case 3U:
															num2 = (num3 * 2619725971U ^ 979047316U);
															continue;
														case 4U:
															goto IL_FD;
														case 5U:
															goto IL_163;
														case 6U:
															goto IL_CA;
														case 7U:
															goto IL_A6;
														case 8U:
															goto IL_125;
														case 9U:
															goto IL_1A6;
														case 10U:
															goto IL_106;
														case 11U:
															goto IL_152;
														case 12U:
														case 14U:
															goto IL_DE;
														case 13U:
															goto IL_15B;
														case 15U:
															goto IL_19D;
														case 16U:
															goto IL_189;
														case 17U:
															goto IL_191;
														case 18U:
															goto IL_D6;
														case 22U:
															goto IL_173;
														case 23U:
															goto IL_CE;
														}
														goto Block_4;
													}
													break;
												}
												}
											}
										}
									}
								}
								goto IL_173;
							}
						}
						Block_4:
						goto IL_1AD;
						IL_FD:
						smsClient = new SmsRuClient(smsClientConfig);
						goto IL_11F;
						IL_106:
						smsClient = new EpochtaSmsClient(smsClientConfig);
						goto IL_11F;
						IL_10F:
						smsClient = Bootstrapper.Container.ResolveKeyed("SMSC");
						IL_11F:
						if (smsClient == null)
						{
							goto IL_1AD;
						}
						IL_125:
						awaiter = smsClient.SendAsync(this.repair.id, this.repair.client, smsTemplateId).GetAwaiter();
						if (awaiter.IsCompleted)
						{
							goto IL_1A6;
						}
						IL_152:
						this.<>1__state = 0;
						IL_15B:
						this.<>u__1 = awaiter;
						IL_163:
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopStatusService.<SendSms>d__9>(ref awaiter, ref this);
						return;
						IL_173:
						Bootstrapper.Container.Resolve<IToasterService>().Info("Sms client not configured");
						goto IL_1C8;
					}
					IL_189:
					awaiter = this.<>u__1;
					IL_191:
					this.<>u__1 = default(TaskAwaiter);
					IL_19D:
					this.<>1__state = -1;
					IL_1A6:
					awaiter.GetResult();
					IL_1AD:;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_1C8:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003C6D RID: 15469 RVA: 0x000F2F28 File Offset: 0x000F1128
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040027F1 RID: 10225
			public int <>1__state;

			// Token: 0x040027F2 RID: 10226
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040027F3 RID: 10227
			public WorkshopOptions workshopOptions;

			// Token: 0x040027F4 RID: 10228
			public workshop repair;

			// Token: 0x040027F5 RID: 10229
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020007D7 RID: 2007
		[CompilerGenerated]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x06003C6E RID: 15470 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass11_0()
			{
			}

			// Token: 0x040027F6 RID: 10230
			public workshop repair;
		}

		// Token: 0x020007D8 RID: 2008
		[CompilerGenerated]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x06003C6F RID: 15471 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x06003C70 RID: 15472 RVA: 0x000F2F44 File Offset: 0x000F1144
			internal bool <GetStatusList>b__2(WorkshopOptions i)
			{
				return this.activeStatusIds.Contains(i.Id);
			}

			// Token: 0x040027F7 RID: 10231
			public List<int> activeStatusIds;
		}

		// Token: 0x020007D9 RID: 2009
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003C71 RID: 15473 RVA: 0x000F2F64 File Offset: 0x000F1164
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003C72 RID: 15474 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06003C73 RID: 15475 RVA: 0x000F2F7C File Offset: 0x000F117C
			internal bool <GetStatusList>b__12_0(WorkshopOptions i)
			{
				return i.Contains != null;
			}

			// Token: 0x06003C74 RID: 15476 RVA: 0x00060FF8 File Offset: 0x0005F1F8
			internal IEnumerable<int> <GetStatusList>b__12_1(WorkshopOptions i)
			{
				return i.Contains;
			}

			// Token: 0x06003C75 RID: 15477 RVA: 0x000B536C File Offset: 0x000B356C
			internal string <GetStatusList>b__12_3(WorkshopOptions i)
			{
				return i.Name;
			}

			// Token: 0x040027F8 RID: 10232
			public static readonly WorkshopStatusService.<>c <>9 = new WorkshopStatusService.<>c();

			// Token: 0x040027F9 RID: 10233
			public static Func<WorkshopOptions, bool> <>9__12_0;

			// Token: 0x040027FA RID: 10234
			public static Func<WorkshopOptions, IEnumerable<int>> <>9__12_1;

			// Token: 0x040027FB RID: 10235
			public static Func<WorkshopOptions, string> <>9__12_3;
		}
	}
}
