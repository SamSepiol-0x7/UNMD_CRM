using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Objects;
using ASC.Services.Abstract;
using ASC.Services.Concrete;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels
{
	// Token: 0x020003A4 RID: 932
	public class AutoMasterAssignViewModel : CollectionViewModel<users>
	{
		// Token: 0x17000D79 RID: 3449
		// (get) Token: 0x06002748 RID: 10056 RVA: 0x00077BA0 File Offset: 0x00075DA0
		protected int RepairId
		{
			[CompilerGenerated]
			get
			{
				return this.<RepairId>k__BackingField;
			}
		}

		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x06002749 RID: 10057 RVA: 0x00077BB4 File Offset: 0x00075DB4
		// (set) Token: 0x0600274A RID: 10058 RVA: 0x00077BC8 File Offset: 0x00075DC8
		private protected workshop Repair
		{
			[CompilerGenerated]
			protected get
			{
				return this.<Repair>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Repair>k__BackingField, value))
				{
					return;
				}
				this.<Repair>k__BackingField = value;
				this.RaisePropertyChanged("Repair");
			}
		}

		// Token: 0x0600274B RID: 10059 RVA: 0x00077BF8 File Offset: 0x00075DF8
		public AutoMasterAssignViewModel(int repairId)
		{
			this.RepairId = repairId;
			this._employeeService = Bootstrapper.Container.Resolve<IEmployeeService>();
			this._workshopService = Bootstrapper.Container.Resolve<IWorkshopService>();
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._workshopStatusService = Bootstrapper.Container.Resolve<IWorkshopStatusService>();
			this._masterAutoAssignService = Bootstrapper.Container.Resolve<IMasterAutoAssignService>();
		}

		// Token: 0x0600274C RID: 10060 RVA: 0x00077C74 File Offset: 0x00075E74
		[AsyncCommand]
		public Task Assign()
		{
			AutoMasterAssignViewModel.<Assign>d__14 <Assign>d__;
			<Assign>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Assign>d__.<>4__this = this;
			<Assign>d__.<>1__state = -1;
			<Assign>d__.<>t__builder.Start<AutoMasterAssignViewModel.<Assign>d__14>(ref <Assign>d__);
			return <Assign>d__.<>t__builder.Task;
		}

		// Token: 0x0600274D RID: 10061 RVA: 0x00077CB8 File Offset: 0x00075EB8
		public bool CanAssign()
		{
			return base.SelectedItem != null;
		}

		// Token: 0x0600274E RID: 10062 RVA: 0x00077CD0 File Offset: 0x00075ED0
		[AsyncCommand]
		public Task NextMaster()
		{
			AutoMasterAssignViewModel.<NextMaster>d__16 <NextMaster>d__;
			<NextMaster>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<NextMaster>d__.<>4__this = this;
			<NextMaster>d__.<>1__state = -1;
			<NextMaster>d__.<>t__builder.Start<AutoMasterAssignViewModel.<NextMaster>d__16>(ref <NextMaster>d__);
			return <NextMaster>d__.<>t__builder.Task;
		}

		// Token: 0x0600274F RID: 10063 RVA: 0x00077CB8 File Offset: 0x00075EB8
		public bool CanNextMaster()
		{
			return base.SelectedItem != null;
		}

		// Token: 0x06002750 RID: 10064 RVA: 0x00077D14 File Offset: 0x00075F14
		[Command]
		public void Close()
		{
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x06002751 RID: 10065 RVA: 0x00077D2C File Offset: 0x00075F2C
		public override void OnLoad()
		{
			AutoMasterAssignViewModel.<OnLoad>d__19 <OnLoad>d__;
			<OnLoad>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnLoad>d__.<>4__this = this;
			<OnLoad>d__.<>1__state = -1;
			<OnLoad>d__.<>t__builder.Start<AutoMasterAssignViewModel.<OnLoad>d__19>(ref <OnLoad>d__);
		}

		// Token: 0x06002752 RID: 10066 RVA: 0x00077D64 File Offset: 0x00075F64
		private Task<users> GetMaster()
		{
			AutoMasterAssignViewModel.<GetMaster>d__20 <GetMaster>d__;
			<GetMaster>d__.<>t__builder = AsyncTaskMethodBuilder<users>.Create();
			<GetMaster>d__.<>4__this = this;
			<GetMaster>d__.<>1__state = -1;
			<GetMaster>d__.<>t__builder.Start<AutoMasterAssignViewModel.<GetMaster>d__20>(ref <GetMaster>d__);
			return <GetMaster>d__.<>t__builder.Task;
		}

		// Token: 0x06002753 RID: 10067 RVA: 0x00077DA8 File Offset: 0x00075FA8
		public override void OnSelectedItemChanged(users obj)
		{
			base.RaiseCanExecuteChanged(() => this.Assign());
			base.OnSelectedItemChanged(obj);
		}

		// Token: 0x06002754 RID: 10068 RVA: 0x00077DF8 File Offset: 0x00075FF8
		private IMasterAutoAssignCriteria GetAutoMasterAssignCriteria()
		{
			if (OfflineData.Instance.Settings.MasterAutoAssignCriteria != null)
			{
				return OfflineData.Instance.Settings.MasterAutoAssignCriteria;
			}
			MasterAutoAssignService.MasterAutoAssignCriteria masterAutoAssignCriteria = new MasterAutoAssignService.MasterAutoAssignCriteria();
			masterAutoAssignCriteria.StatusList.AddRange(new List<int>
			{
				1,
				4,
				36
			});
			masterAutoAssignCriteria.DayLimit = 4;
			return masterAutoAssignCriteria;
		}

		// Token: 0x06002755 RID: 10069 RVA: 0x0003401C File Offset: 0x0003221C
		[CompilerGenerated]
		[DebuggerHidden]
		private void <>n__0()
		{
			base.OnLoad();
		}

		// Token: 0x0400153C RID: 5436
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x0400153D RID: 5437
		private readonly IEmployeeService _employeeService;

		// Token: 0x0400153E RID: 5438
		private readonly IWorkshopService _workshopService;

		// Token: 0x0400153F RID: 5439
		private readonly IToasterService _toasterService;

		// Token: 0x04001540 RID: 5440
		private readonly IWorkshopStatusService _workshopStatusService;

		// Token: 0x04001541 RID: 5441
		private readonly IMasterAutoAssignService _masterAutoAssignService;

		// Token: 0x04001542 RID: 5442
		[CompilerGenerated]
		private readonly int <RepairId>k__BackingField;

		// Token: 0x04001543 RID: 5443
		[CompilerGenerated]
		private workshop <Repair>k__BackingField;

		// Token: 0x020003A5 RID: 933
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Assign>d__14 : IAsyncStateMachine
		{
			// Token: 0x06002756 RID: 10070 RVA: 0x00077E58 File Offset: 0x00076058
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AutoMasterAssignViewModel autoMasterAssignViewModel = this.<>4__this;
				try
				{
					if (num > 1)
					{
						autoMasterAssignViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter awaiter;
						TaskAwaiter<workshop> awaiter2;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								goto IL_FF;
							}
							autoMasterAssignViewModel.Repair.new_state = 1;
							autoMasterAssignViewModel.Repair.master = new int?(autoMasterAssignViewModel.SelectedItem.id);
							awaiter2 = autoMasterAssignViewModel._workshopStatusService.UpdateStatus(autoMasterAssignViewModel.Repair).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num3 = 0;
								num = 0;
								this.<>1__state = num3;
								this.<>u__1 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop>, AutoMasterAssignViewModel.<Assign>d__14>(ref awaiter2, ref this);
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
						awaiter2.GetResult();
						awaiter = autoMasterAssignViewModel._workshopService.ChangeMaster(autoMasterAssignViewModel.RepairId, new int?(autoMasterAssignViewModel.SelectedItem.id)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num5 = 1;
							num = 1;
							this.<>1__state = num5;
							this.<>u__2 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, AutoMasterAssignViewModel.<Assign>d__14>(ref awaiter, ref this);
							return;
						}
						IL_FF:
						awaiter.GetResult();
						autoMasterAssignViewModel._windowedDocumentService.CloseActiveDocument();
					}
					catch (Exception ex)
					{
						autoMasterAssignViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							autoMasterAssignViewModel.HideWait();
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
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002757 RID: 10071 RVA: 0x00078038 File Offset: 0x00076238
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001544 RID: 5444
			public int <>1__state;

			// Token: 0x04001545 RID: 5445
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001546 RID: 5446
			public AutoMasterAssignViewModel <>4__this;

			// Token: 0x04001547 RID: 5447
			private TaskAwaiter<workshop> <>u__1;

			// Token: 0x04001548 RID: 5448
			private TaskAwaiter <>u__2;
		}

		// Token: 0x020003A6 RID: 934
		[CompilerGenerated]
		private sealed class <>c__DisplayClass16_0
		{
			// Token: 0x06002758 RID: 10072 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass16_0()
			{
			}

			// Token: 0x06002759 RID: 10073 RVA: 0x00078054 File Offset: 0x00076254
			internal bool <NextMaster>b__0(users i)
			{
				int id = i.id;
				int? num = this.master;
				return id == num.GetValueOrDefault() & num != null;
			}

			// Token: 0x04001549 RID: 5449
			public int? master;
		}

		// Token: 0x020003A7 RID: 935
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <NextMaster>d__16 : IAsyncStateMachine
		{
			// Token: 0x0600275A RID: 10074 RVA: 0x00078080 File Offset: 0x00076280
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AutoMasterAssignViewModel autoMasterAssignViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<int?> awaiter;
					if (num != 0)
					{
						this.<>8__1 = new AutoMasterAssignViewModel.<>c__DisplayClass16_0();
						awaiter = autoMasterAssignViewModel._masterAutoAssignService.GetMaster(autoMasterAssignViewModel.GetAutoMasterAssignCriteria(), new int?(autoMasterAssignViewModel.SelectedItem.id)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int?>, AutoMasterAssignViewModel.<NextMaster>d__16>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<int?>);
						this.<>1__state = -1;
					}
					int? result = awaiter.GetResult();
					this.<>8__1.master = result;
					autoMasterAssignViewModel.SelectedItem = autoMasterAssignViewModel.Items.FirstOrDefault(new Func<users, bool>(this.<>8__1.<NextMaster>b__0));
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

			// Token: 0x0600275B RID: 10075 RVA: 0x0007819C File Offset: 0x0007639C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400154A RID: 5450
			public int <>1__state;

			// Token: 0x0400154B RID: 5451
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400154C RID: 5452
			public AutoMasterAssignViewModel <>4__this;

			// Token: 0x0400154D RID: 5453
			private AutoMasterAssignViewModel.<>c__DisplayClass16_0 <>8__1;

			// Token: 0x0400154E RID: 5454
			private TaskAwaiter<int?> <>u__1;
		}

		// Token: 0x020003A8 RID: 936
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600275C RID: 10076 RVA: 0x000781B8 File Offset: 0x000763B8
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600275D RID: 10077 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x0600275E RID: 10078 RVA: 0x000781D0 File Offset: 0x000763D0
			internal bool <OnLoad>b__19_0(users i)
			{
				return OfflineData.Instance.Settings.AutoAssignUsers.Contains(i.id);
			}

			// Token: 0x0400154F RID: 5455
			public static readonly AutoMasterAssignViewModel.<>c <>9 = new AutoMasterAssignViewModel.<>c();

			// Token: 0x04001550 RID: 5456
			public static Func<users, bool> <>9__19_0;
		}

		// Token: 0x020003A9 RID: 937
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnLoad>d__19 : IAsyncStateMachine
		{
			// Token: 0x0600275F RID: 10079 RVA: 0x000781F8 File Offset: 0x000763F8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AutoMasterAssignViewModel autoMasterAssignViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<users>> awaiter;
					TaskAwaiter<workshop> awaiter2;
					TaskAwaiter<users> awaiter3;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<users>>);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<workshop>);
						this.<>1__state = -1;
						goto IL_10E;
					case 2:
						awaiter3 = this.<>u__3;
						this.<>u__3 = default(TaskAwaiter<users>);
						this.<>1__state = -1;
						goto IL_173;
					default:
						awaiter = autoMasterAssignViewModel._employeeService.GetEmployees().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<users>>, AutoMasterAssignViewModel.<OnLoad>d__19>(ref awaiter, ref this);
							return;
						}
						break;
					}
					List<users> result = awaiter.GetResult();
					autoMasterAssignViewModel.SetItems(result.Where(new Func<users, bool>(AutoMasterAssignViewModel.<>c.<>9.<OnLoad>b__19_0)));
					awaiter2 = autoMasterAssignViewModel._workshopService.GetRepair(autoMasterAssignViewModel.RepairId).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop>, AutoMasterAssignViewModel.<OnLoad>d__19>(ref awaiter2, ref this);
						return;
					}
					IL_10E:
					workshop result2 = awaiter2.GetResult();
					autoMasterAssignViewModel.Repair = result2;
					awaiter3 = autoMasterAssignViewModel.GetMaster().GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__3 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<users>, AutoMasterAssignViewModel.<OnLoad>d__19>(ref awaiter3, ref this);
						return;
					}
					IL_173:
					users result3 = awaiter3.GetResult();
					autoMasterAssignViewModel.SelectedItem = result3;
					autoMasterAssignViewModel.<>n__0();
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

			// Token: 0x06002760 RID: 10080 RVA: 0x000783DC File Offset: 0x000765DC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001551 RID: 5457
			public int <>1__state;

			// Token: 0x04001552 RID: 5458
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001553 RID: 5459
			public AutoMasterAssignViewModel <>4__this;

			// Token: 0x04001554 RID: 5460
			private TaskAwaiter<List<users>> <>u__1;

			// Token: 0x04001555 RID: 5461
			private TaskAwaiter<workshop> <>u__2;

			// Token: 0x04001556 RID: 5462
			private TaskAwaiter<users> <>u__3;
		}

		// Token: 0x020003AA RID: 938
		[CompilerGenerated]
		private sealed class <>c__DisplayClass20_0
		{
			// Token: 0x06002761 RID: 10081 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass20_0()
			{
			}

			// Token: 0x06002762 RID: 10082 RVA: 0x000783F8 File Offset: 0x000765F8
			internal bool <GetMaster>b__0(users i)
			{
				int id = i.id;
				int? num = this.master;
				return id == num.GetValueOrDefault() & num != null;
			}

			// Token: 0x04001557 RID: 5463
			public int? master;
		}

		// Token: 0x020003AB RID: 939
		[CompilerGenerated]
		private sealed class <>c__DisplayClass20_1
		{
			// Token: 0x06002763 RID: 10083 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass20_1()
			{
			}

			// Token: 0x06002764 RID: 10084 RVA: 0x00078424 File Offset: 0x00076624
			internal bool <GetMaster>b__1(users i)
			{
				int id = i.id;
				int? master = this.earlyRepair.master;
				return id == master.GetValueOrDefault() & master != null;
			}

			// Token: 0x06002765 RID: 10085 RVA: 0x00078424 File Offset: 0x00076624
			internal bool <GetMaster>b__2(users i)
			{
				int id = i.id;
				int? master = this.earlyRepair.master;
				return id == master.GetValueOrDefault() & master != null;
			}

			// Token: 0x04001558 RID: 5464
			public workshop earlyRepair;
		}

		// Token: 0x020003AC RID: 940
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetMaster>d__20 : IAsyncStateMachine
		{
			// Token: 0x06002766 RID: 10086 RVA: 0x00078454 File Offset: 0x00076654
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AutoMasterAssignViewModel autoMasterAssignViewModel = this.<>4__this;
				users result2;
				try
				{
					TaskAwaiter<int?> awaiter;
					TaskAwaiter<workshop> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<int?>);
							this.<>1__state = -1;
							goto IL_15F;
						}
						this.<>8__2 = new AutoMasterAssignViewModel.<>c__DisplayClass20_0();
						if (autoMasterAssignViewModel.Repair.early == null)
						{
							goto IL_134;
						}
						this.<>8__1 = new AutoMasterAssignViewModel.<>c__DisplayClass20_1();
						awaiter2 = autoMasterAssignViewModel._workshopService.GetRepair(autoMasterAssignViewModel.Repair.early.Value).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop>, AutoMasterAssignViewModel.<GetMaster>d__20>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<workshop>);
						this.<>1__state = -1;
					}
					workshop result = awaiter2.GetResult();
					this.<>8__1.earlyRepair = result;
					if (autoMasterAssignViewModel.Items.Any(new Func<users, bool>(this.<>8__1.<GetMaster>b__1)))
					{
						result2 = autoMasterAssignViewModel.Items.FirstOrDefault(new Func<users, bool>(this.<>8__1.<GetMaster>b__2));
						goto IL_1D3;
					}
					this.<>8__1 = null;
					IL_134:
					awaiter = autoMasterAssignViewModel._masterAutoAssignService.GetMaster(autoMasterAssignViewModel.GetAutoMasterAssignCriteria(), null).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int?>, AutoMasterAssignViewModel.<GetMaster>d__20>(ref awaiter, ref this);
						return;
					}
					IL_15F:
					int? result3 = awaiter.GetResult();
					this.<>8__2.master = result3;
					result2 = autoMasterAssignViewModel.Items.FirstOrDefault(new Func<users, bool>(this.<>8__2.<GetMaster>b__0));
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_1D3:
				this.<>1__state = -2;
				this.<>8__2 = null;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06002767 RID: 10087 RVA: 0x0007866C File Offset: 0x0007686C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001559 RID: 5465
			public int <>1__state;

			// Token: 0x0400155A RID: 5466
			public AsyncTaskMethodBuilder<users> <>t__builder;

			// Token: 0x0400155B RID: 5467
			public AutoMasterAssignViewModel <>4__this;

			// Token: 0x0400155C RID: 5468
			private AutoMasterAssignViewModel.<>c__DisplayClass20_1 <>8__1;

			// Token: 0x0400155D RID: 5469
			private AutoMasterAssignViewModel.<>c__DisplayClass20_0 <>8__2;

			// Token: 0x0400155E RID: 5470
			private TaskAwaiter<workshop> <>u__1;

			// Token: 0x0400155F RID: 5471
			private TaskAwaiter<int?> <>u__2;
		}
	}
}
