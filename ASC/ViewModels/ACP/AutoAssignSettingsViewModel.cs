using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Enum;
using ASC.Interfaces;
using ASC.Objects;
using ASC.Options;
using ASC.Services.Abstract;
using ASC.Services.Concrete;
using Newtonsoft.Json;

namespace ASC.ViewModels.ACP
{
	// Token: 0x02000544 RID: 1348
	public class AutoAssignSettingsViewModel : BaseViewModel, IAcpModuleSettings
	{
		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x0600320B RID: 12811 RVA: 0x000A759C File Offset: 0x000A579C
		public string Name
		{
			get
			{
				return "Автоматическое распределение заказов между мастерами";
			}
		}

		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x0600320C RID: 12812 RVA: 0x000A75B0 File Offset: 0x000A57B0
		// (set) Token: 0x0600320D RID: 12813 RVA: 0x000A75C4 File Offset: 0x000A57C4
		public List<int> AutoAssignUsers
		{
			[CompilerGenerated]
			get
			{
				return this.<AutoAssignUsers>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<AutoAssignUsers>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -971932765;
				IL_13:
				switch ((num ^ -2073574327) % 4)
				{
				case 1:
					IL_32:
					this.<AutoAssignUsers>k__BackingField = value;
					this.RaisePropertyChanged("AutoAssignUsers");
					num = -62286579;
					goto IL_13;
				case 2:
					return;
				case 3:
					goto IL_0E;
				}
			}
		}

		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x0600320E RID: 12814 RVA: 0x000A7620 File Offset: 0x000A5820
		// (set) Token: 0x0600320F RID: 12815 RVA: 0x000A7634 File Offset: 0x000A5834
		public List<int> StatusList
		{
			[CompilerGenerated]
			get
			{
				return this.<StatusList>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<StatusList>k__BackingField, value))
				{
					return;
				}
				this.<StatusList>k__BackingField = value;
				this.RaisePropertyChanged("StatusList");
			}
		}

		// Token: 0x17000F65 RID: 3941
		// (get) Token: 0x06003210 RID: 12816 RVA: 0x000A7664 File Offset: 0x000A5864
		// (set) Token: 0x06003211 RID: 12817 RVA: 0x000A7678 File Offset: 0x000A5878
		public int DayLimit
		{
			[CompilerGenerated]
			get
			{
				return this.<DayLimit>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<DayLimit>k__BackingField == value)
				{
					return;
				}
				this.<DayLimit>k__BackingField = value;
				this.RaisePropertyChanged("DayLimit");
			}
		}

		// Token: 0x17000F66 RID: 3942
		// (get) Token: 0x06003212 RID: 12818 RVA: 0x000A76A4 File Offset: 0x000A58A4
		// (set) Token: 0x06003213 RID: 12819 RVA: 0x000A76B8 File Offset: 0x000A58B8
		public List<WorkshopOptions> Statuses
		{
			[CompilerGenerated]
			get
			{
				return this.<Statuses>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Statuses>k__BackingField, value))
				{
					return;
				}
				this.<Statuses>k__BackingField = value;
				this.RaisePropertyChanged("Statuses");
			}
		}

		// Token: 0x06003214 RID: 12820 RVA: 0x000A76E8 File Offset: 0x000A58E8
		public AutoAssignSettingsViewModel(ISettingsService settingsService, IWorkshopStatusService workshopStatusService)
		{
			this._settingsService = settingsService;
			this._workshopStatusService = workshopStatusService;
		}

		// Token: 0x06003215 RID: 12821 RVA: 0x000A770C File Offset: 0x000A590C
		public Task LoadSettings()
		{
			AutoAssignSettingsViewModel.<LoadSettings>d__21 <LoadSettings>d__;
			<LoadSettings>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadSettings>d__.<>4__this = this;
			<LoadSettings>d__.<>1__state = -1;
			<LoadSettings>d__.<>t__builder.Start<AutoAssignSettingsViewModel.<LoadSettings>d__21>(ref <LoadSettings>d__);
			return <LoadSettings>d__.<>t__builder.Task;
		}

		// Token: 0x06003216 RID: 12822 RVA: 0x000A7750 File Offset: 0x000A5950
		public Task SaveSettings()
		{
			AutoAssignSettingsViewModel.<SaveSettings>d__22 <SaveSettings>d__;
			<SaveSettings>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<SaveSettings>d__.<>4__this = this;
			<SaveSettings>d__.<>1__state = -1;
			<SaveSettings>d__.<>t__builder.Start<AutoAssignSettingsViewModel.<SaveSettings>d__22>(ref <SaveSettings>d__);
			return <SaveSettings>d__.<>t__builder.Task;
		}

		// Token: 0x04001CBE RID: 7358
		private readonly ISettingsService _settingsService;

		// Token: 0x04001CBF RID: 7359
		private readonly IWorkshopStatusService _workshopStatusService;

		// Token: 0x04001CC0 RID: 7360
		[CompilerGenerated]
		private List<int> <AutoAssignUsers>k__BackingField;

		// Token: 0x04001CC1 RID: 7361
		[CompilerGenerated]
		private List<int> <StatusList>k__BackingField;

		// Token: 0x04001CC2 RID: 7362
		[CompilerGenerated]
		private int <DayLimit>k__BackingField;

		// Token: 0x04001CC3 RID: 7363
		[CompilerGenerated]
		private List<WorkshopOptions> <Statuses>k__BackingField;

		// Token: 0x02000545 RID: 1349
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadSettings>d__21 : IAsyncStateMachine
		{
			// Token: 0x06003217 RID: 12823 RVA: 0x000A7794 File Offset: 0x000A5994
			void IAsyncStateMachine.MoveNext()
			{
				AutoAssignSettingsViewModel autoAssignSettingsViewModel = this.<>4__this;
				try
				{
					autoAssignSettingsViewModel.AutoAssignUsers = OfflineData.Instance.Settings.AutoAssignUsers;
					autoAssignSettingsViewModel.DayLimit = OfflineData.Instance.Settings.MasterAutoAssignCriteria.DayLimit;
					autoAssignSettingsViewModel.StatusList = OfflineData.Instance.Settings.MasterAutoAssignCriteria.StatusList;
					autoAssignSettingsViewModel.Statuses = autoAssignSettingsViewModel._workshopStatusService.GetStatusList();
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

			// Token: 0x06003218 RID: 12824 RVA: 0x000A7840 File Offset: 0x000A5A40
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001CC4 RID: 7364
			public int <>1__state;

			// Token: 0x04001CC5 RID: 7365
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001CC6 RID: 7366
			public AutoAssignSettingsViewModel <>4__this;
		}

		// Token: 0x02000546 RID: 1350
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SaveSettings>d__22 : IAsyncStateMachine
		{
			// Token: 0x06003219 RID: 12825 RVA: 0x000A785C File Offset: 0x000A5A5C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AutoAssignSettingsViewModel autoAssignSettingsViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = autoAssignSettingsViewModel._settingsService.UpdateSettingsAsync(new Dictionary<SettingsName, string>
						{
							{
								SettingsName.auto_assign_users,
								(autoAssignSettingsViewModel.AutoAssignUsers == null) ? JsonConvert.SerializeObject(new List<int>()) : JsonConvert.SerializeObject(autoAssignSettingsViewModel.AutoAssignUsers)
							},
							{
								SettingsName.auto_assign_criteria,
								JsonConvert.SerializeObject(new MasterAutoAssignService.MasterAutoAssignCriteria
								{
									StatusList = (autoAssignSettingsViewModel.StatusList ?? new List<int>()),
									DayLimit = autoAssignSettingsViewModel.DayLimit
								})
							}
						}).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, AutoAssignSettingsViewModel.<SaveSettings>d__22>(ref awaiter, ref this);
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

			// Token: 0x0600321A RID: 12826 RVA: 0x000A7978 File Offset: 0x000A5B78
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001CC7 RID: 7367
			public int <>1__state;

			// Token: 0x04001CC8 RID: 7368
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001CC9 RID: 7369
			public AutoAssignSettingsViewModel <>4__this;

			// Token: 0x04001CCA RID: 7370
			private TaskAwaiter <>u__1;
		}
	}
}
