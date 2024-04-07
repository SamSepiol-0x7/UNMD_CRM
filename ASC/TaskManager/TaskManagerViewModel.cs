using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Input;
using ASC.Common.Interfaces;
using ASC.Objects;
using ASC.Services.Abstract;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.TaskManager
{
	// Token: 0x020002D6 RID: 726
	public class TaskManagerViewModel : TaskCommonViewModel
	{
		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x060023FC RID: 9212 RVA: 0x0006B384 File Offset: 0x00069584
		// (set) Token: 0x060023FD RID: 9213 RVA: 0x0006B398 File Offset: 0x00069598
		public Period Period
		{
			[CompilerGenerated]
			get
			{
				return this.<Period>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Period>k__BackingField, value))
				{
					return;
				}
				this.<Period>k__BackingField = value;
				this.RaisePropertyChanged("Period");
			}
		}

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x060023FE RID: 9214 RVA: 0x0006B3C8 File Offset: 0x000695C8
		// (set) Token: 0x060023FF RID: 9215 RVA: 0x0006B3DC File Offset: 0x000695DC
		public Dictionary<int, string> Direction
		{
			[CompilerGenerated]
			get
			{
				return this.<Direction>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Direction>k__BackingField, value))
				{
					return;
				}
				this.<Direction>k__BackingField = value;
				this.RaisePropertyChanged("Direction");
			}
		}

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x06002400 RID: 9216 RVA: 0x0006B40C File Offset: 0x0006960C
		// (set) Token: 0x06002401 RID: 9217 RVA: 0x0006B420 File Offset: 0x00069620
		public bool ShowCheckBoxSelectorColumn
		{
			[CompilerGenerated]
			get
			{
				return this.<ShowCheckBoxSelectorColumn>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ShowCheckBoxSelectorColumn>k__BackingField == value)
				{
					return;
				}
				this.<ShowCheckBoxSelectorColumn>k__BackingField = value;
				this.RaisePropertyChanged("ShowCheckBoxSelectorColumn");
			}
		}

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x06002402 RID: 9218 RVA: 0x0006B44C File Offset: 0x0006964C
		// (set) Token: 0x06002403 RID: 9219 RVA: 0x0006B490 File Offset: 0x00069690
		public string Query
		{
			get
			{
				return base.GetProperty<string>(() => this.Query);
			}
			set
			{
				if (string.Equals(this.Query, value, StringComparison.Ordinal))
				{
					return;
				}
				base.SetProperty<string>(() => this.Query, value, new Action(this.QueryChanged));
				this.RaisePropertyChanged("Query");
			}
		}

		// Token: 0x06002404 RID: 9220 RVA: 0x0006B4FC File Offset: 0x000696FC
		private void QueryChanged()
		{
			this.Refresh();
		}

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x06002405 RID: 9221 RVA: 0x0006B510 File Offset: 0x00069710
		// (set) Token: 0x06002406 RID: 9222 RVA: 0x0006B524 File Offset: 0x00069724
		public int SelectedTaskType
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedTaskType>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedTaskType>k__BackingField == value)
				{
					return;
				}
				this.<SelectedTaskType>k__BackingField = value;
				this.RaisePropertyChanged("SelectedTaskType");
			}
		}

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x06002407 RID: 9223 RVA: 0x0006B550 File Offset: 0x00069750
		// (set) Token: 0x06002408 RID: 9224 RVA: 0x0006B564 File Offset: 0x00069764
		public int SelectedTaskStatus
		{
			get
			{
				return this._selectedTaskStatus;
			}
			set
			{
				if (this._selectedTaskStatus != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = 129702510;
				IL_10:
				switch ((num ^ 362457351) % 4)
				{
				case 0:
					goto IL_0B;
				case 1:
					return;
				case 3:
					IL_2F:
					this._selectedTaskStatus = value;
					this.RaisePropertyChanged("SelectedTaskStatus");
					this.Refresh();
					num = 1775219629;
					goto IL_10;
				}
			}
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x06002409 RID: 9225 RVA: 0x0006B5C0 File Offset: 0x000697C0
		// (set) Token: 0x0600240A RID: 9226 RVA: 0x0006B5D4 File Offset: 0x000697D4
		public int SelectedUser
		{
			get
			{
				return this._selectedUser;
			}
			set
			{
				if (this._selectedUser == value)
				{
					return;
				}
				this._selectedUser = value;
				this.RaisePropertyChanged("SelectedUser");
				this.Refresh();
			}
		}

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x0600240B RID: 9227 RVA: 0x0006B608 File Offset: 0x00069808
		// (set) Token: 0x0600240C RID: 9228 RVA: 0x0006B61C File Offset: 0x0006981C
		public int SelectedPriority
		{
			get
			{
				return this._selectedPriority;
			}
			set
			{
				if (this._selectedPriority == value)
				{
					return;
				}
				this._selectedPriority = value;
				this.RaisePropertyChanged("SelectedPriority");
				this.Refresh();
			}
		}

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x0600240D RID: 9229 RVA: 0x0006B650 File Offset: 0x00069850
		// (set) Token: 0x0600240E RID: 9230 RVA: 0x0006B664 File Offset: 0x00069864
		public tasks SelectedTask
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedTask>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedTask>k__BackingField, value))
				{
					return;
				}
				this.<SelectedTask>k__BackingField = value;
				this.RaisePropertyChanged("SelectedTask");
			}
		}

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x0600240F RID: 9231 RVA: 0x0006B694 File Offset: 0x00069894
		// (set) Token: 0x06002410 RID: 9232 RVA: 0x0006B6D8 File Offset: 0x000698D8
		public List<tasks> SelectedTasks
		{
			get
			{
				return base.GetProperty<List<tasks>>(() => this.SelectedTasks);
			}
			set
			{
				if (!object.Equals(this.SelectedTasks, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -348132268;
				IL_13:
				switch ((num ^ -2041968066) % 4)
				{
				case 0:
					goto IL_0E;
				case 2:
					return;
				case 3:
					IL_32:
					base.SetProperty<List<tasks>>(() => this.SelectedTasks, value, new Action(this.SelectedTasksChanged));
					this.RaisePropertyChanged("SelectedTasks");
					num = -1056066117;
					goto IL_13;
				}
			}
		}

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x06002411 RID: 9233 RVA: 0x0006B770 File Offset: 0x00069970
		// (set) Token: 0x06002412 RID: 9234 RVA: 0x0006B7B4 File Offset: 0x000699B4
		public int SelectedDirection
		{
			get
			{
				return base.GetProperty<int>(() => this.SelectedDirection);
			}
			set
			{
				if (this.SelectedDirection == value)
				{
					return;
				}
				base.SetProperty<int>(() => this.SelectedDirection, value, new Action(this.OnSelectedDirectionChanged));
				this.RaisePropertyChanged("SelectedDirection");
			}
		}

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x06002413 RID: 9235 RVA: 0x0006B81C File Offset: 0x00069A1C
		// (set) Token: 0x06002414 RID: 9236 RVA: 0x0006B830 File Offset: 0x00069A30
		public bool IncomingFiltersVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<IncomingFiltersVisible>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<IncomingFiltersVisible>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -225197891;
				IL_10:
				switch ((num ^ -374290308) % 4)
				{
				case 0:
					goto IL_0B;
				case 1:
					return;
				case 3:
					IL_2F:
					this.<IncomingFiltersVisible>k__BackingField = value;
					this.RaisePropertyChanged("IncomingFiltersVisible");
					num = -1074153162;
					goto IL_10;
				}
			}
		}

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x06002415 RID: 9237 RVA: 0x0006B888 File Offset: 0x00069A88
		// (set) Token: 0x06002416 RID: 9238 RVA: 0x0006B89C File Offset: 0x00069A9C
		public bool AllowUserSelect
		{
			[CompilerGenerated]
			get
			{
				return this.<AllowUserSelect>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<AllowUserSelect>k__BackingField == value)
				{
					return;
				}
				this.<AllowUserSelect>k__BackingField = value;
				this.RaisePropertyChanged("AllowUserSelect");
			}
		}

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x06002417 RID: 9239 RVA: 0x0006B8C8 File Offset: 0x00069AC8
		// (set) Token: 0x06002418 RID: 9240 RVA: 0x0006B8DC File Offset: 0x00069ADC
		public ObservableCollection<tasks> Tasks
		{
			[CompilerGenerated]
			get
			{
				return this.<Tasks>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Tasks>k__BackingField, value))
				{
					return;
				}
				this.<Tasks>k__BackingField = value;
				this.RaisePropertyChanged("Tasks");
			}
		}

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x06002419 RID: 9241 RVA: 0x0006B90C File Offset: 0x00069B0C
		// (set) Token: 0x0600241A RID: 9242 RVA: 0x0006B920 File Offset: 0x00069B20
		public ICommand ItemDoubleClickCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<ItemDoubleClickCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ItemDoubleClickCommand>k__BackingField, value))
				{
					return;
				}
				this.<ItemDoubleClickCommand>k__BackingField = value;
				this.RaisePropertyChanged("ItemDoubleClickCommand");
			}
		}

		// Token: 0x0600241B RID: 9243 RVA: 0x0006B950 File Offset: 0x00069B50
		private void InitCommands()
		{
			this.ItemDoubleClickCommand = new RelayCommand(new Action<object>(this.ItemDoubleClick));
		}

		// Token: 0x0600241C RID: 9244 RVA: 0x0006B974 File Offset: 0x00069B74
		public TaskManagerViewModel()
		{
			this._taskService = Bootstrapper.Container.Resolve<ITaskService>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._localization = Bootstrapper.Container.Resolve<ILocalization>();
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
			this.SetViewName("Tasks");
			this.Direction = new Dictionary<int, string>
			{
				{
					1,
					Lang.t("Incoming")
				},
				{
					2,
					Lang.t("Outcoming")
				}
			};
			this.SelectedDirection = 1;
			this.Period = new Period(this._localization.Now.AddDays(-30.0), this._localization.Now);
			Period period = this.Period;
			period.RefreshEventHandler = (EventHandler)Delegate.Combine(period.RefreshEventHandler, new EventHandler(this.Refresh));
			this.SelectedUser = Auth.User.id;
			base.TaskTypes = this._taskService.LoadTaskTypes(true);
			base.TaskStatuses = this._taskService.LoadTaskStatuses(true);
			base.Priorities = this._taskService.LoadPriorities(true);
			if (OfflineData.Instance.Employee.Can(68, 0))
			{
				this.AllowUserSelect = true;
			}
			this.SelectedTasks = new List<tasks>();
			this.InitCommands();
		}

		// Token: 0x0600241D RID: 9245 RVA: 0x0006BAE0 File Offset: 0x00069CE0
		private void OnSelectedDirectionChanged()
		{
			this.IncomingFiltersVisible = (this.SelectedDirection == 1);
			this.Refresh();
		}

		// Token: 0x0600241E RID: 9246 RVA: 0x0006BB04 File Offset: 0x00069D04
		public override void OnLoad()
		{
			base.OnLoad();
			base.SetViewLoaded(true);
			base.RaiseCanExecuteChanged(() => this.Refresh());
			this.LoadTasksWithIndicator();
		}

		// Token: 0x0600241F RID: 9247 RVA: 0x0006BB60 File Offset: 0x00069D60
		private static bool GlobalOrOfficeAdministrator()
		{
			if (!OfflineData.Instance.Employee.Can(1, 0))
			{
				return OfflineData.Instance.Offices.Any((offices i) => i.administrator == OfflineData.Instance.Employee.Id);
			}
			return true;
		}

		// Token: 0x06002420 RID: 9248 RVA: 0x0006B4FC File Offset: 0x000696FC
		private void Refresh(object sender, EventArgs e)
		{
			this.Refresh();
		}

		// Token: 0x06002421 RID: 9249 RVA: 0x0006BBB0 File Offset: 0x00069DB0
		[Command]
		public void Refresh()
		{
			if (base.ViewLoaded)
			{
				goto IL_2C;
			}
			IL_08:
			int num = -1285773949;
			IL_0D:
			switch ((num ^ -368349838) % 4)
			{
			case 0:
				IL_2C:
				this.LoadTasksWithIndicator();
				num = -955545279;
				goto IL_0D;
			case 1:
				return;
			case 2:
				goto IL_08;
			}
		}

		// Token: 0x06002422 RID: 9250 RVA: 0x0006A844 File Offset: 0x00068A44
		public bool CanRefresh()
		{
			return base.ViewLoaded;
		}

		// Token: 0x06002423 RID: 9251 RVA: 0x0006BBF8 File Offset: 0x00069DF8
		private void LoadTasksWithIndicator()
		{
			TaskManagerViewModel.<LoadTasksWithIndicator>d__70 <LoadTasksWithIndicator>d__;
			<LoadTasksWithIndicator>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadTasksWithIndicator>d__.<>4__this = this;
			<LoadTasksWithIndicator>d__.<>1__state = -1;
			<LoadTasksWithIndicator>d__.<>t__builder.Start<TaskManagerViewModel.<LoadTasksWithIndicator>d__70>(ref <LoadTasksWithIndicator>d__);
		}

		// Token: 0x06002424 RID: 9252 RVA: 0x0006BC30 File Offset: 0x00069E30
		private Task LoadTasks()
		{
			TaskManagerViewModel.<LoadTasks>d__71 <LoadTasks>d__;
			<LoadTasks>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadTasks>d__.<>4__this = this;
			<LoadTasks>d__.<>1__state = -1;
			<LoadTasks>d__.<>t__builder.Start<TaskManagerViewModel.<LoadTasks>d__71>(ref <LoadTasks>d__);
			return <LoadTasks>d__.<>t__builder.Task;
		}

		// Token: 0x06002425 RID: 9253 RVA: 0x0006BC74 File Offset: 0x00069E74
		private void ItemDoubleClick(object obj)
		{
			if (this.SelectedTask == null)
			{
				goto IL_3E;
			}
			goto IL_76;
			int num;
			for (;;)
			{
				IL_43:
				switch ((num ^ -462548576) % 6)
				{
				case 1:
					goto IL_76;
				case 2:
					return;
				case 3:
					goto IL_3E;
				case 4:
					this._navigationService.Navigate("EmployeeTaskView", new EmployeeTaskViewModel(this.SelectedTask.idt));
					num = -1097862604;
					continue;
				case 5:
					goto IL_89;
				}
				break;
			}
			return;
			IL_89:
			this._navigationService.Navigate("SiteOrderTaskView", SiteOrderTaskViewModel.Create(this.SelectedTask.idt));
			return;
			IL_3E:
			num = -1165527554;
			goto IL_43;
			IL_76:
			num = ((this.SelectedTask.type != 10) ? -309331088 : -80677379);
			goto IL_43;
		}

		// Token: 0x06002426 RID: 9254 RVA: 0x0006BD2C File Offset: 0x00069F2C
		[Command]
		public void NewTask()
		{
			this._navigationService.Navigate("EmployeeTaskView", new EmployeeTaskViewModel());
		}

		// Token: 0x06002427 RID: 9255 RVA: 0x000306B8 File Offset: 0x0002E8B8
		public bool CanNewTask()
		{
			return base.IsValid();
		}

		// Token: 0x06002428 RID: 9256 RVA: 0x0006B4FC File Offset: 0x000696FC
		[Command]
		public void TaskTypeChanged()
		{
			this.Refresh();
		}

		// Token: 0x06002429 RID: 9257 RVA: 0x0006BD50 File Offset: 0x00069F50
		[AsyncCommand]
		public Task CancelSelectedTasks()
		{
			TaskManagerViewModel.<CancelSelectedTasks>d__76 <CancelSelectedTasks>d__;
			<CancelSelectedTasks>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<CancelSelectedTasks>d__.<>4__this = this;
			<CancelSelectedTasks>d__.<>1__state = -1;
			<CancelSelectedTasks>d__.<>t__builder.Start<TaskManagerViewModel.<CancelSelectedTasks>d__76>(ref <CancelSelectedTasks>d__);
			return <CancelSelectedTasks>d__.<>t__builder.Task;
		}

		// Token: 0x0600242A RID: 9258 RVA: 0x0006BD94 File Offset: 0x00069F94
		public bool CanCancelSelectedTasks()
		{
			return this.SelectedTasks != null && this.SelectedTasks.Count > 1 && TaskManagerViewModel.GlobalOrOfficeAdministrator();
		}

		// Token: 0x0600242B RID: 9259 RVA: 0x0006BDC0 File Offset: 0x00069FC0
		private void SelectedTasksChanged()
		{
			base.RaiseCanExecuteChanged(() => this.CancelSelectedTasks());
		}

		// Token: 0x0600242C RID: 9260 RVA: 0x0006BE08 File Offset: 0x0006A008
		[CompilerGenerated]
		private Task<IEnumerable<tasks>> <LoadTasks>b__71_0()
		{
			return this._taskService.GetTasks(this.Period, this.SelectedUser, this.SelectedTaskStatus, this.SelectedPriority, this.SelectedTaskType, this.Query, this.SelectedDirection);
		}

		// Token: 0x040012CF RID: 4815
		private readonly ITaskService _taskService;

		// Token: 0x040012D0 RID: 4816
		private ILocalization _localization;

		// Token: 0x040012D1 RID: 4817
		private int _selectedUser;

		// Token: 0x040012D2 RID: 4818
		private int _selectedTaskStatus = -1;

		// Token: 0x040012D3 RID: 4819
		private int _selectedPriority;

		// Token: 0x040012D4 RID: 4820
		private readonly INavigationService _navigationService;

		// Token: 0x040012D5 RID: 4821
		private readonly IToasterService _toasterService;

		// Token: 0x040012D6 RID: 4822
		[CompilerGenerated]
		private Period <Period>k__BackingField;

		// Token: 0x040012D7 RID: 4823
		[CompilerGenerated]
		private Dictionary<int, string> <Direction>k__BackingField;

		// Token: 0x040012D8 RID: 4824
		[CompilerGenerated]
		private bool <ShowCheckBoxSelectorColumn>k__BackingField;

		// Token: 0x040012D9 RID: 4825
		[CompilerGenerated]
		private int <SelectedTaskType>k__BackingField = -2;

		// Token: 0x040012DA RID: 4826
		[CompilerGenerated]
		private tasks <SelectedTask>k__BackingField;

		// Token: 0x040012DB RID: 4827
		[CompilerGenerated]
		private bool <IncomingFiltersVisible>k__BackingField;

		// Token: 0x040012DC RID: 4828
		[CompilerGenerated]
		private bool <AllowUserSelect>k__BackingField;

		// Token: 0x040012DD RID: 4829
		[CompilerGenerated]
		private ObservableCollection<tasks> <Tasks>k__BackingField;

		// Token: 0x040012DE RID: 4830
		[CompilerGenerated]
		private ICommand <ItemDoubleClickCommand>k__BackingField;

		// Token: 0x020002D7 RID: 727
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600242D RID: 9261 RVA: 0x0006BE4C File Offset: 0x0006A04C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600242E RID: 9262 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x0600242F RID: 9263 RVA: 0x0006BE64 File Offset: 0x0006A064
			internal bool <GlobalOrOfficeAdministrator>b__66_0(offices i)
			{
				return i.administrator == OfflineData.Instance.Employee.Id;
			}

			// Token: 0x06002430 RID: 9264 RVA: 0x0006BE88 File Offset: 0x0006A088
			internal int <CancelSelectedTasks>b__76_0(tasks i)
			{
				return i.idt;
			}

			// Token: 0x040012DF RID: 4831
			public static readonly TaskManagerViewModel.<>c <>9 = new TaskManagerViewModel.<>c();

			// Token: 0x040012E0 RID: 4832
			public static Func<offices, bool> <>9__66_0;

			// Token: 0x040012E1 RID: 4833
			public static Func<tasks, int> <>9__76_0;
		}

		// Token: 0x020002D8 RID: 728
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadTasksWithIndicator>d__70 : IAsyncStateMachine
		{
			// Token: 0x06002431 RID: 9265 RVA: 0x0006BE9C File Offset: 0x0006A09C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				TaskManagerViewModel taskManagerViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						taskManagerViewModel.ShowWait();
						awaiter = taskManagerViewModel.LoadTasks().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, TaskManagerViewModel.<LoadTasksWithIndicator>d__70>(ref awaiter, ref this);
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
					taskManagerViewModel.HideWait();
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

			// Token: 0x06002432 RID: 9266 RVA: 0x0006BF5C File Offset: 0x0006A15C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040012E2 RID: 4834
			public int <>1__state;

			// Token: 0x040012E3 RID: 4835
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040012E4 RID: 4836
			public TaskManagerViewModel <>4__this;

			// Token: 0x040012E5 RID: 4837
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020002D9 RID: 729
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadTasks>d__71 : IAsyncStateMachine
		{
			// Token: 0x06002433 RID: 9267 RVA: 0x0006BF78 File Offset: 0x0006A178
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				TaskManagerViewModel taskManagerViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<tasks>> awaiter;
					if (num != 0)
					{
						awaiter = Task.Run<IEnumerable<tasks>>(() => taskManagerViewModel._taskService.GetTasks(base.Period, base.SelectedUser, base.SelectedTaskStatus, base.SelectedPriority, base.SelectedTaskType, base.Query, base.SelectedDirection)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<tasks>>, TaskManagerViewModel.<LoadTasks>d__71>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<tasks>>);
						this.<>1__state = -1;
					}
					IEnumerable<tasks> result = awaiter.GetResult();
					taskManagerViewModel.Tasks = new ObservableCollection<tasks>(result);
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

			// Token: 0x06002434 RID: 9268 RVA: 0x0006C044 File Offset: 0x0006A244
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040012E6 RID: 4838
			public int <>1__state;

			// Token: 0x040012E7 RID: 4839
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040012E8 RID: 4840
			public TaskManagerViewModel <>4__this;

			// Token: 0x040012E9 RID: 4841
			private TaskAwaiter<IEnumerable<tasks>> <>u__1;
		}

		// Token: 0x020002DA RID: 730
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CancelSelectedTasks>d__76 : IAsyncStateMachine
		{
			// Token: 0x06002435 RID: 9269 RVA: 0x0006C060 File Offset: 0x0006A260
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				TaskManagerViewModel taskManagerViewModel = this.<>4__this;
				try
				{
					if (num > 1)
					{
						taskManagerViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								goto IL_E8;
							}
							awaiter = taskManagerViewModel._taskService.CancelTasks(taskManagerViewModel.SelectedTasks.Select(new Func<tasks, int>(TaskManagerViewModel.<>c.<>9.<CancelSelectedTasks>b__76_0)).ToList<int>()).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num3 = 0;
								num = 0;
								this.<>1__state = num3;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, TaskManagerViewModel.<CancelSelectedTasks>d__76>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
						}
						awaiter.GetResult();
						awaiter = taskManagerViewModel.LoadTasks().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num5 = 1;
							num = 1;
							this.<>1__state = num5;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, TaskManagerViewModel.<CancelSelectedTasks>d__76>(ref awaiter, ref this);
							return;
						}
						IL_E8:
						awaiter.GetResult();
						taskManagerViewModel._toasterService.Success(Lang.t("Complete"));
					}
					catch (Exception ex)
					{
						taskManagerViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							taskManagerViewModel.HideWait();
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

			// Token: 0x06002436 RID: 9270 RVA: 0x0006C230 File Offset: 0x0006A430
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040012EA RID: 4842
			public int <>1__state;

			// Token: 0x040012EB RID: 4843
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040012EC RID: 4844
			public TaskManagerViewModel <>4__this;

			// Token: 0x040012ED RID: 4845
			private TaskAwaiter <>u__1;
		}
	}
}
