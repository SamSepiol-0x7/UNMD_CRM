using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using ASC.Common.SimpleClasses;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Options;
using ASC.Services.Abstract;
using ASC.ViewModels;
using Autofac;
using DevExpress.DataProcessing;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.RepairCard
{
	// Token: 0x02000809 RID: 2057
	public class StatusViewModel : BaseViewModel, IStatusViewModel
	{
		// Token: 0x170010B4 RID: 4276
		// (get) Token: 0x06003D75 RID: 15733 RVA: 0x000F4298 File Offset: 0x000F2498
		// (set) Token: 0x06003D76 RID: 15734 RVA: 0x000F42AC File Offset: 0x000F24AC
		public ObservableCollection<WorkshopOptions> StatesList
		{
			[CompilerGenerated]
			get
			{
				return this.<StatesList>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<StatesList>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -692112532;
				IL_13:
				switch ((num ^ -1035712310) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					IL_32:
					this.<StatesList>k__BackingField = value;
					num = -486287835;
					goto IL_13;
				case 2:
					return;
				}
				this.RaisePropertyChanged("StatesList");
			}
		}

		// Token: 0x170010B5 RID: 4277
		// (get) Token: 0x06003D77 RID: 15735 RVA: 0x000F4308 File Offset: 0x000F2508
		public bool CanSaveStatus
		{
			get
			{
				return this.CanChangeState();
			}
		}

		// Token: 0x170010B6 RID: 4278
		// (get) Token: 0x06003D78 RID: 15736 RVA: 0x000F431C File Offset: 0x000F251C
		// (set) Token: 0x06003D79 RID: 15737 RVA: 0x000F4330 File Offset: 0x000F2530
		public WorkshopOptions SelectedOption
		{
			get
			{
				return this._selectedOption;
			}
			set
			{
				if (object.Equals(this._selectedOption, value))
				{
					return;
				}
				this._selectedOption = value;
				this.RaisePropertyChanged("CanSaveStatus");
				this.RaisePropertyChanged("SelectedOption");
				if (this._selectedOption != null)
				{
					if (this._repairCardViewModel.Repair != null)
					{
						this._repairCardViewModel.Repair.new_state = this._selectedOption.Id;
					}
					this._repairCardViewModel.RefreshCommands();
					base.RaisePropertyChanged<bool>(() => this.CanSaveStatus);
				}
			}
		}

		// Token: 0x06003D7A RID: 15738 RVA: 0x000F43DC File Offset: 0x000F25DC
		public StatusViewModel(RepairCardViewModel repairCardViewModel, RepairModel repairModel)
		{
			this._repairCardViewModel = repairCardViewModel;
			this._repairModel = repairModel;
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._ascMessageBoxService = Bootstrapper.Container.Resolve<IAscMessageBoxService>();
			this._workshopStatusService = Bootstrapper.Container.Resolve<IWorkshopStatusService>();
			this.StatesList = new ObservableCollection<WorkshopOptions>();
		}

		// Token: 0x06003D7B RID: 15739 RVA: 0x000F4438 File Offset: 0x000F2638
		public void LoadRepairStates(int state)
		{
			List<WorkshopOptions> itemsToAdd = this._repairCardViewModel._workshopOptions.OptionsByOption(state);
			this.StatesList.Clear();
			this.StatesList.AddRange(itemsToAdd);
			this.SetSelected(state);
		}

		// Token: 0x06003D7C RID: 15740 RVA: 0x000F4478 File Offset: 0x000F2678
		public void SetSelected(int statusId)
		{
			this.SelectedOption = this.StatesList.FirstOrDefault((WorkshopOptions s) => s.Id == statusId);
		}

		// Token: 0x06003D7D RID: 15741 RVA: 0x000F44B0 File Offset: 0x000F26B0
		[Command]
		public void ChangeStatePopupClosed()
		{
			this.ChangeState();
		}

		// Token: 0x06003D7E RID: 15742 RVA: 0x000F44C4 File Offset: 0x000F26C4
		public bool CanChangeStatePopupClosed()
		{
			return this.CanStatusSaveBase() && Auth.User.save_state_on_close;
		}

		// Token: 0x06003D7F RID: 15743 RVA: 0x000F44E8 File Offset: 0x000F26E8
		private bool StateChanged()
		{
			return this._repairCardViewModel.Repair.new_state != this._repairCardViewModel.Repair.state;
		}

		// Token: 0x06003D80 RID: 15744 RVA: 0x000F451C File Offset: 0x000F271C
		[Command]
		public void ChangeState()
		{
			StatusViewModel.<ChangeState>d__21 <ChangeState>d__;
			<ChangeState>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<ChangeState>d__.<>4__this = this;
			<ChangeState>d__.<>1__state = -1;
			<ChangeState>d__.<>t__builder.Start<StatusViewModel.<ChangeState>d__21>(ref <ChangeState>d__);
		}

		// Token: 0x06003D81 RID: 15745 RVA: 0x000F4554 File Offset: 0x000F2754
		public Task<bool> CheckFields(workshop repair)
		{
			StatusViewModel.<CheckFields>d__22 <CheckFields>d__;
			<CheckFields>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<CheckFields>d__.<>4__this = this;
			<CheckFields>d__.repair = repair;
			<CheckFields>d__.<>1__state = -1;
			<CheckFields>d__.<>t__builder.Start<StatusViewModel.<CheckFields>d__22>(ref <CheckFields>d__);
			return <CheckFields>d__.<>t__builder.Task;
		}

		// Token: 0x06003D82 RID: 15746 RVA: 0x000F45A0 File Offset: 0x000F27A0
		public bool CanChangeState()
		{
			return !Auth.User.save_state_on_close && this.CanStatusSaveBase();
		}

		// Token: 0x06003D83 RID: 15747 RVA: 0x000F45C4 File Offset: 0x000F27C4
		public bool CanStatusSaveBase()
		{
			return (this._repairCardViewModel.Repair != null && this._repairCardViewModel.Repair.master == null && this._repairCardViewModel.Repair.state == 0 && OfflineData.Instance.Employee.Can(57, 0)) || (this.SelectedOption != null && this._repairCardViewModel.IsUnlockedAndSameOffice() && this.StateChanged());
		}

		// Token: 0x0400282C RID: 10284
		private readonly IToasterService _toasterService;

		// Token: 0x0400282D RID: 10285
		private readonly IAscMessageBoxService _ascMessageBoxService;

		// Token: 0x0400282E RID: 10286
		private readonly IWorkshopStatusService _workshopStatusService;

		// Token: 0x0400282F RID: 10287
		private readonly RepairModel _repairModel;

		// Token: 0x04002830 RID: 10288
		private readonly RepairCardViewModel _repairCardViewModel;

		// Token: 0x04002831 RID: 10289
		[CompilerGenerated]
		private ObservableCollection<WorkshopOptions> <StatesList>k__BackingField;

		// Token: 0x04002832 RID: 10290
		private WorkshopOptions _selectedOption;

		// Token: 0x0200080A RID: 2058
		[CompilerGenerated]
		private sealed class <>c__DisplayClass17_0
		{
			// Token: 0x06003D84 RID: 15748 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass17_0()
			{
			}

			// Token: 0x06003D85 RID: 15749 RVA: 0x000F4640 File Offset: 0x000F2840
			internal bool <SetSelected>b__0(WorkshopOptions s)
			{
				return s.Id == this.statusId;
			}

			// Token: 0x04002833 RID: 10291
			public int statusId;
		}

		// Token: 0x0200080B RID: 2059
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ChangeState>d__21 : IAsyncStateMachine
		{
			// Token: 0x06003D86 RID: 15750 RVA: 0x000F465C File Offset: 0x000F285C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				StatusViewModel statusViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<bool> awaiter;
					TaskAwaiter<workshop> awaiter2;
					TaskAwaiter awaiter3;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<bool>);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<workshop>);
						this.<>1__state = -1;
						goto IL_1AA;
					case 2:
						awaiter3 = this.<>u__3;
						this.<>u__3 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_278;
					default:
						if (!OfflineData.Instance.Employee.Can(statusViewModel.SelectedOption))
						{
							statusViewModel._toasterService.Info(Lang.t("CheckPermissions"));
							goto IL_30F;
						}
						if (Auth.Config.diag_required)
						{
							if (statusViewModel._repairCardViewModel.Repair.new_state == 15 || statusViewModel._repairCardViewModel.Repair.new_state == 4 || statusViewModel._repairCardViewModel.Repair.new_state == 14)
							{
								string text = statusViewModel._repairModel.CheckDiagFields(statusViewModel._repairCardViewModel.Repair);
								if (!string.IsNullOrEmpty(text))
								{
									statusViewModel._toasterService.Info(text);
									goto IL_30F;
								}
							}
						}
						awaiter = statusViewModel.CheckFields(statusViewModel._repairCardViewModel.Repair).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, StatusViewModel.<ChangeState>d__21>(ref awaiter, ref this);
							return;
						}
						break;
					}
					if (!awaiter.GetResult())
					{
						goto IL_30F;
					}
					statusViewModel.ShowWait();
					awaiter2 = statusViewModel._workshopStatusService.UpdateStatus(statusViewModel._repairCardViewModel.Repair).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop>, StatusViewModel.<ChangeState>d__21>(ref awaiter2, ref this);
						return;
					}
					IL_1AA:
					workshop result = awaiter2.GetResult();
					statusViewModel.HideWait();
					if (result == null)
					{
						statusViewModel.SelectedOption = null;
						statusViewModel._toasterService.Error("");
						goto IL_30F;
					}
					statusViewModel._repairCardViewModel.Repair.master = result.master;
					statusViewModel._repairCardViewModel.RefreshFielsd();
					statusViewModel._repairCardViewModel.RefreshCommands();
					statusViewModel.LoadRepairStates(statusViewModel._repairCardViewModel.Repair.new_state);
					awaiter3 = statusViewModel._repairCardViewModel.CountRepairCost().GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__3 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, StatusViewModel.<ChangeState>d__21>(ref awaiter3, ref this);
						return;
					}
					IL_278:
					awaiter3.GetResult();
					statusViewModel._toasterService.Success(Lang.t("OrderStatusUpdated"));
					statusViewModel.RaiseCanExecuteChanged(() => statusViewModel.ChangeStatePopupClosed());
					Messenger.Default.Send(new Message(statusViewModel._repairCardViewModel.Repair.state, MessageType.OrderStatusChanged));
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_30F:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003D87 RID: 15751 RVA: 0x000F49A8 File Offset: 0x000F2BA8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002834 RID: 10292
			public int <>1__state;

			// Token: 0x04002835 RID: 10293
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04002836 RID: 10294
			public StatusViewModel <>4__this;

			// Token: 0x04002837 RID: 10295
			private TaskAwaiter<bool> <>u__1;

			// Token: 0x04002838 RID: 10296
			private TaskAwaiter<workshop> <>u__2;

			// Token: 0x04002839 RID: 10297
			private TaskAwaiter <>u__3;
		}

		// Token: 0x0200080C RID: 2060
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CheckFields>d__22 : IAsyncStateMachine
		{
			// Token: 0x06003D88 RID: 15752 RVA: 0x000F49C4 File Offset: 0x000F2BC4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				StatusViewModel statusViewModel = this.<>4__this;
				bool result;
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
							goto IL_2ED;
						}
						if (this.repair == null)
						{
							result = false;
							goto IL_34C;
						}
						if (this.repair.new_state == 0)
						{
							statusViewModel._toasterService.Info(Lang.t("InputState"));
							result = false;
							goto IL_34C;
						}
						if (!this.repair.is_debt)
						{
							if (this.repair.new_state != 8)
							{
								if (this.repair.new_state != 12)
								{
									if (this.repair.new_state != 16)
									{
										goto IL_AA;
									}
								}
							}
							statusViewModel._toasterService.Info(Lang.t("IssueWarning"));
							result = false;
							goto IL_34C;
						}
						IL_AA:
						if (this.repair.new_state != 2)
						{
							if (this.repair.new_state != 3)
							{
								if (this.repair.new_state != 4)
								{
									if (this.repair.new_state != 7)
									{
										goto IL_15E;
									}
								}
							}
						}
						if (string.IsNullOrEmpty(this.repair.diagnostic_result))
						{
							if (this.repair.new_state == 7)
							{
								if (statusViewModel._ascMessageBoxService.ShowMessageBox(Lang.t("IgnoreEmptyDiagnosticResult"), Lang.t("DiagnosticResult"), MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
								{
									result = true;
									goto IL_34C;
								}
							}
							if (Auth.Config.diag_required)
							{
								statusViewModel._toasterService.Info(Lang.t("InputDiagnosticResult"));
								result = false;
								goto IL_34C;
							}
						}
						IL_15E:
						if (this.repair.new_state == 3)
						{
							if (this.repair.repair_cost == 0m && !this.repair.is_warranty && !this.repair.is_repeat)
							{
								statusViewModel._toasterService.Info(Lang.t("RepairCostError"));
								result = false;
								goto IL_34C;
							}
						}
						awaiter = RepairModel.GetRepairCostTotal(this.repair.id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, StatusViewModel.<CheckFields>d__22>(ref awaiter, ref this);
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
					if (this.repair.new_state == 6)
					{
						if (result2 == 0m && !this.repair.is_warranty && !this.repair.is_repeat)
						{
							statusViewModel._toasterService.Info(Lang.t("RepairCostError"));
							result = false;
							goto IL_34C;
						}
					}
					bool flag;
					if (!(flag = (this.repair.new_state == 7)))
					{
						goto IL_300;
					}
					awaiter = RepairModel.TotalPartsCost(this.repair.id).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, StatusViewModel.<CheckFields>d__22>(ref awaiter, ref this);
						return;
					}
					IL_2ED:
					flag = (awaiter.GetResult() > 0m);
					IL_300:
					if (flag)
					{
						if (statusViewModel._ascMessageBoxService.ShowMessageBox(Lang.t("GiftPartsWarning"), Lang.t("Parts"), MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
						{
							result = false;
							goto IL_34C;
						}
					}
					result = true;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_34C:
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06003D89 RID: 15753 RVA: 0x000F4D50 File Offset: 0x000F2F50
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400283A RID: 10298
			public int <>1__state;

			// Token: 0x0400283B RID: 10299
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x0400283C RID: 10300
			public workshop repair;

			// Token: 0x0400283D RID: 10301
			public StatusViewModel <>4__this;

			// Token: 0x0400283E RID: 10302
			private TaskAwaiter<decimal> <>u__1;
		}
	}
}
