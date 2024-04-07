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
using ASC.RequestsManager;
using ASC.Services.Abstract;
using ASC.ViewModels;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.TaskManager
{
	// Token: 0x020002CC RID: 716
	public class EmployeeTaskViewModel : BaseViewModel
	{
		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x060023B0 RID: 9136 RVA: 0x0006A02C File Offset: 0x0006822C
		// (set) Token: 0x060023B1 RID: 9137 RVA: 0x0006A040 File Offset: 0x00068240
		public int TaskId
		{
			[CompilerGenerated]
			get
			{
				return this.<TaskId>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<TaskId>k__BackingField == value)
				{
					return;
				}
				this.<TaskId>k__BackingField = value;
				this.RaisePropertyChanged("TaskId");
			}
		}

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x060023B2 RID: 9138 RVA: 0x0006A06C File Offset: 0x0006826C
		// (set) Token: 0x060023B3 RID: 9139 RVA: 0x0006A080 File Offset: 0x00068280
		public Dictionary<TaskType, string> TaskTypes
		{
			[CompilerGenerated]
			get
			{
				return this.<TaskTypes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<TaskTypes>k__BackingField, value))
				{
					return;
				}
				this.<TaskTypes>k__BackingField = value;
				this.RaisePropertyChanged("TaskTypes");
			}
		}

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x060023B4 RID: 9140 RVA: 0x0006A0B0 File Offset: 0x000682B0
		// (set) Token: 0x060023B5 RID: 9141 RVA: 0x0006A0C4 File Offset: 0x000682C4
		public List<KeyValuePair<AscTaskStatus, string>> TaskStatuses
		{
			[CompilerGenerated]
			get
			{
				return this.<TaskStatuses>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<TaskStatuses>k__BackingField, value))
				{
					return;
				}
				this.<TaskStatuses>k__BackingField = value;
				this.RaisePropertyChanged("TaskStatuses");
			}
		}

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x060023B6 RID: 9142 RVA: 0x0006A0F4 File Offset: 0x000682F4
		// (set) Token: 0x060023B7 RID: 9143 RVA: 0x0006A108 File Offset: 0x00068308
		public List<KeyValuePair<AscTaskPriority, string>> Priorities
		{
			[CompilerGenerated]
			get
			{
				return this.<Priorities>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Priorities>k__BackingField, value))
				{
					return;
				}
				this.<Priorities>k__BackingField = value;
				this.RaisePropertyChanged("Priorities");
			}
		}

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x060023B8 RID: 9144 RVA: 0x0006A138 File Offset: 0x00068338
		// (set) Token: 0x060023B9 RID: 9145 RVA: 0x0006A14C File Offset: 0x0006834C
		public List<IDevice> Devices
		{
			[CompilerGenerated]
			get
			{
				return this.<Devices>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Devices>k__BackingField, value))
				{
					return;
				}
				this.<Devices>k__BackingField = value;
				this.RaisePropertyChanged("Devices");
			}
		}

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x060023BA RID: 9146 RVA: 0x0006A17C File Offset: 0x0006837C
		// (set) Token: 0x060023BB RID: 9147 RVA: 0x0006A190 File Offset: 0x00068390
		public List<IManufacturer> Makers
		{
			[CompilerGenerated]
			get
			{
				return this.<Makers>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Makers>k__BackingField, value))
				{
					return;
				}
				this.<Makers>k__BackingField = value;
				this.RaisePropertyChanged("Makers");
			}
		}

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x060023BC RID: 9148 RVA: 0x0006A1C0 File Offset: 0x000683C0
		// (set) Token: 0x060023BD RID: 9149 RVA: 0x0006A1D4 File Offset: 0x000683D4
		public IAscTask Task
		{
			[CompilerGenerated]
			get
			{
				return this.<Task>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Task>k__BackingField, value))
				{
					return;
				}
				this.<Task>k__BackingField = value;
				this.RaisePropertyChanged("ExistTask");
				this.RaisePropertyChanged("ExistTaskInvert");
				this.RaisePropertyChanged("TaskIsPartsRequest");
				this.RaisePropertyChanged("DeviceMatchVisible");
				this.RaisePropertyChanged("Task");
			}
		}

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x060023BE RID: 9150 RVA: 0x0006A230 File Offset: 0x00068430
		public bool ExistTask
		{
			get
			{
				return this.Task != null && this.Task.Id != 0;
			}
		}

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x060023BF RID: 9151 RVA: 0x0006A258 File Offset: 0x00068458
		public bool ExistTaskInvert
		{
			get
			{
				return !this.ExistTask;
			}
		}

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x060023C0 RID: 9152 RVA: 0x0006A270 File Offset: 0x00068470
		public bool TaskIsPartsRequest
		{
			get
			{
				IAscTask task = this.Task;
				return task != null && task.PartRequest != null;
			}
		}

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x060023C1 RID: 9153 RVA: 0x0006A298 File Offset: 0x00068498
		public bool DeviceMatchVisible
		{
			get
			{
				return this.Task != null && this.Task.Type == TaskType.DeviceMatch;
			}
		}

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x060023C2 RID: 9154 RVA: 0x0006A2C0 File Offset: 0x000684C0
		// (set) Token: 0x060023C3 RID: 9155 RVA: 0x0006A2D4 File Offset: 0x000684D4
		public bool OwnerVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<OwnerVisible>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<OwnerVisible>k__BackingField == value)
				{
					return;
				}
				this.<OwnerVisible>k__BackingField = value;
				this.RaisePropertyChanged("OwnerVisible");
			}
		}

		// Token: 0x060023C4 RID: 9156 RVA: 0x0006A300 File Offset: 0x00068500
		private void IoC()
		{
			this._workshopService = Bootstrapper.Container.Resolve<IWorkshopService>();
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
			this._taskService = Bootstrapper.Container.Resolve<ITaskService>();
		}

		// Token: 0x060023C5 RID: 9157 RVA: 0x0006A360 File Offset: 0x00068560
		public EmployeeTaskViewModel()
		{
			this.IoC();
			this.SetViewName("NewTask");
			this.TaskTypes = new Dictionary<TaskType, string>
			{
				{
					TaskType.CustomTask,
					Lang.t("CustomTask")
				},
				{
					TaskType.DeviceMatch,
					Lang.t("DeviceMatch")
				}
			};
			this.Task = new AscTask();
			this.Task.SetDefaultValues();
			this.Task.TopEmployee = OfflineData.Instance.Employee.Id;
			this.Task.Type = TaskType.CustomTask;
		}

		// Token: 0x060023C6 RID: 9158 RVA: 0x0006A3F0 File Offset: 0x000685F0
		public EmployeeTaskViewModel(workshop repair) : this()
		{
			this.Task.RepairId = new int?(repair.id);
			this.Task.AddResponsibleUser(repair.current_manager);
			if (repair.master != null)
			{
				this.Task.AddResponsibleUser(repair.master.Value);
			}
			this.Task.Subject = string.Format("{0} {1:d6}", Lang.t("Repair"), repair.id);
		}

		// Token: 0x060023C7 RID: 9159 RVA: 0x0006A480 File Offset: 0x00068680
		public EmployeeTaskViewModel(int taskId)
		{
			this.IoC();
			this.TaskId = taskId;
			this.SetViewName("TaskCard", taskId);
			this.LoadTask();
		}

		// Token: 0x060023C8 RID: 9160 RVA: 0x0006A4B4 File Offset: 0x000686B4
		private void SetOwnerVisible()
		{
			this.OwnerVisible = (this.Task.Type != TaskType.SitePartsRequest);
		}

		// Token: 0x060023C9 RID: 9161 RVA: 0x0006A4DC File Offset: 0x000686DC
		private void LoadTask()
		{
			EmployeeTaskViewModel.<LoadTask>d__50 <LoadTask>d__;
			<LoadTask>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadTask>d__.<>4__this = this;
			<LoadTask>d__.<>1__state = -1;
			<LoadTask>d__.<>t__builder.Start<EmployeeTaskViewModel.<LoadTask>d__50>(ref <LoadTask>d__);
		}

		// Token: 0x060023CA RID: 9162 RVA: 0x0006A514 File Offset: 0x00068714
		private void RefreshFields()
		{
			base.RaisePropertyChanged<bool>(() => this.ExistTask);
			base.RaisePropertyChanged<bool>(() => this.ExistTaskInvert);
			base.RaisePropertyChanged<bool>(() => this.TaskIsPartsRequest);
			base.RaisePropertyChanged<bool>(() => this.DeviceMatchVisible);
		}

		// Token: 0x060023CB RID: 9163 RVA: 0x0006A5F8 File Offset: 0x000687F8
		private void RefreshCommands()
		{
			base.RaiseCanExecuteChanged(() => this.Save());
		}

		// Token: 0x060023CC RID: 9164 RVA: 0x0006A640 File Offset: 0x00068840
		[Command]
		public virtual void OnLoaded()
		{
			this.SetOwnerVisible();
			this.SetOwnerUser();
			this.LoadCommon();
			base.SetViewLoaded(true);
			this.RefreshCommands();
			this.RefreshFields();
		}

		// Token: 0x060023CD RID: 9165 RVA: 0x0006A674 File Offset: 0x00068874
		private void LoadCommon()
		{
			EmployeeTaskViewModel.<LoadCommon>d__54 <LoadCommon>d__;
			<LoadCommon>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadCommon>d__.<>4__this = this;
			<LoadCommon>d__.<>1__state = -1;
			<LoadCommon>d__.<>t__builder.Start<EmployeeTaskViewModel.<LoadCommon>d__54>(ref <LoadCommon>d__);
		}

		// Token: 0x060023CE RID: 9166 RVA: 0x0006A6AC File Offset: 0x000688AC
		private void SetOwnerUser()
		{
			if (this.Task == null || this.Task.Id != 0)
			{
				return;
			}
			Employee employee = OfflineData.Instance.ActiveUsers.FirstOrDefault((Employee u) => u.Id == Auth.User.id);
			if (employee != null)
			{
				this.Task.CreatorId = new int?(employee.Id);
				return;
			}
		}

		// Token: 0x060023CF RID: 9167 RVA: 0x0006A718 File Offset: 0x00068918
		private void LoadDevices()
		{
			EmployeeTaskViewModel.<LoadDevices>d__56 <LoadDevices>d__;
			<LoadDevices>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadDevices>d__.<>4__this = this;
			<LoadDevices>d__.<>1__state = -1;
			<LoadDevices>d__.<>t__builder.Start<EmployeeTaskViewModel.<LoadDevices>d__56>(ref <LoadDevices>d__);
		}

		// Token: 0x060023D0 RID: 9168 RVA: 0x0006A750 File Offset: 0x00068950
		[Command]
		public void TaskTypeChanged()
		{
			if (this.Task.Type == TaskType.DeviceMatch)
			{
				this.LoadDevices();
			}
			base.RaisePropertyChanged<bool>(() => this.DeviceMatchVisible);
		}

		// Token: 0x060023D1 RID: 9169 RVA: 0x0006A7A8 File Offset: 0x000689A8
		[Command]
		public void DeviceChanged()
		{
			EmployeeTaskViewModel.<DeviceChanged>d__58 <DeviceChanged>d__;
			<DeviceChanged>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<DeviceChanged>d__.<>4__this = this;
			<DeviceChanged>d__.<>1__state = -1;
			<DeviceChanged>d__.<>t__builder.Start<EmployeeTaskViewModel.<DeviceChanged>d__58>(ref <DeviceChanged>d__);
		}

		// Token: 0x060023D2 RID: 9170 RVA: 0x0006A7E0 File Offset: 0x000689E0
		[Command]
		public void CreateAndClose()
		{
			EmployeeTaskViewModel.<CreateAndClose>d__59 <CreateAndClose>d__;
			<CreateAndClose>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<CreateAndClose>d__.<>4__this = this;
			<CreateAndClose>d__.<>1__state = -1;
			<CreateAndClose>d__.<>t__builder.Start<EmployeeTaskViewModel.<CreateAndClose>d__59>(ref <CreateAndClose>d__);
		}

		// Token: 0x060023D3 RID: 9171 RVA: 0x0006A818 File Offset: 0x00068A18
		public bool CanCreateAndClose()
		{
			return OfflineData.Instance.Employee.Can(67, 0) && !this.ExistTask;
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x0006A5F8 File Offset: 0x000687F8
		[Command]
		public void StatusChanged()
		{
			base.RaiseCanExecuteChanged(() => this.Save());
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x0006A844 File Offset: 0x00068A44
		public bool CanStatusChanged()
		{
			return base.ViewLoaded;
		}

		// Token: 0x060023D6 RID: 9174 RVA: 0x0006A858 File Offset: 0x00068A58
		[Command]
		public virtual void Save()
		{
			EmployeeTaskViewModel.<Save>d__63 <Save>d__;
			<Save>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Save>d__.<>4__this = this;
			<Save>d__.<>1__state = -1;
			<Save>d__.<>t__builder.Start<EmployeeTaskViewModel.<Save>d__63>(ref <Save>d__);
		}

		// Token: 0x060023D7 RID: 9175 RVA: 0x0006A890 File Offset: 0x00068A90
		public bool CanSave()
		{
			if (this.Task == null)
			{
				return false;
			}
			if (this.Task.Status == AscTaskStatus.Cancelled)
			{
				int? creatorId = this.Task.CreatorId;
				int id = OfflineData.Instance.Employee.Id;
				if (!(creatorId.GetValueOrDefault() == id & creatorId != null))
				{
					return false;
				}
			}
			return this.Task.Id > 0 && this.Task.Type != TaskType.BuyPartsRequest && base.ViewLoaded;
		}

		// Token: 0x060023D8 RID: 9176 RVA: 0x0006A910 File Offset: 0x00068B10
		[Command]
		public void MailTo()
		{
			this._windowedDocumentService.ShowNewDocument("EmailView", new EmailViewModel(this.Task.Email, this.Task.Message), null, null);
		}

		// Token: 0x060023D9 RID: 9177 RVA: 0x0006A94C File Offset: 0x00068B4C
		[Command]
		public void CallTo()
		{
			Core.Instance.VoIP.Callback(OfflineData.Instance.Employee.Tel.ToString(), this.Task.Tel);
		}

		// Token: 0x060023DA RID: 9178 RVA: 0x0006A994 File Offset: 0x00068B94
		public bool CanCallTo()
		{
			return Core.Instance.CanCall();
		}

		// Token: 0x060023DB RID: 9179 RVA: 0x0006A9AC File Offset: 0x00068BAC
		[Command]
		public void SmsTo()
		{
			this._windowedDocumentService.ShowNewDocument("SmsSendView", new SmsSendViewModel(this.Task.Tel), null, null);
		}

		// Token: 0x060023DC RID: 9180 RVA: 0x0006A9DC File Offset: 0x00068BDC
		[Command]
		public void ItemCardOpen()
		{
			if (this.Task.ItemId == null)
			{
				return;
			}
			this._navigationService.NavigateToStoreItem(this.Task.ItemId.Value, 0);
		}

		// Token: 0x060023DD RID: 9181 RVA: 0x0006AA20 File Offset: 0x00068C20
		[Command]
		public void PartRequestOpen()
		{
			if (this.Task.PartRequest != null)
			{
				this._navigationService.Navigate("RequestCardView", new RequestCardViewModel(this.Task.PartRequest.Value));
				return;
			}
		}

		// Token: 0x060023DE RID: 9182 RVA: 0x0006AA6C File Offset: 0x00068C6C
		[Command]
		public void RepairCardOpen()
		{
			if (this.Task.RepairId == null)
			{
				return;
			}
			this._navigationService.NavigateRepairCard(this.Task.RepairId.Value);
		}

		// Token: 0x060023DF RID: 9183 RVA: 0x0006AAB0 File Offset: 0x00068CB0
		[CompilerGenerated]
		private bool <LoadCommon>b__54_0(IDevice d)
		{
			int id = d.Id;
			int? matchDevice = this.Task.MatchDevice;
			return id == matchDevice.GetValueOrDefault() & matchDevice != null;
		}

		// Token: 0x060023E0 RID: 9184 RVA: 0x0006AAB0 File Offset: 0x00068CB0
		[CompilerGenerated]
		private bool <DeviceChanged>b__58_0(IDevice d)
		{
			int id = d.Id;
			int? matchDevice = this.Task.MatchDevice;
			return id == matchDevice.GetValueOrDefault() & matchDevice != null;
		}

		// Token: 0x060023E1 RID: 9185 RVA: 0x0006AAE0 File Offset: 0x00068CE0
		[CompilerGenerated]
		private int <CreateAndClose>b__59_0()
		{
			return this._taskService.CreateTask(this.Task);
		}

		// Token: 0x060023E2 RID: 9186 RVA: 0x00069A84 File Offset: 0x00067C84
		[CompilerGenerated]
		private Task<bool> <Save>b__63_0()
		{
			return this._taskService.UpdateTask(this.Task);
		}

		// Token: 0x040012A3 RID: 4771
		protected IWorkshopService _workshopService;

		// Token: 0x040012A4 RID: 4772
		protected INavigationService _navigationService;

		// Token: 0x040012A5 RID: 4773
		protected IToasterService _toasterService;

		// Token: 0x040012A6 RID: 4774
		private IWindowedDocumentService _windowedDocumentService;

		// Token: 0x040012A7 RID: 4775
		protected ITaskService _taskService;

		// Token: 0x040012A8 RID: 4776
		[CompilerGenerated]
		private int <TaskId>k__BackingField;

		// Token: 0x040012A9 RID: 4777
		[CompilerGenerated]
		private Dictionary<TaskType, string> <TaskTypes>k__BackingField;

		// Token: 0x040012AA RID: 4778
		[CompilerGenerated]
		private List<KeyValuePair<AscTaskStatus, string>> <TaskStatuses>k__BackingField;

		// Token: 0x040012AB RID: 4779
		[CompilerGenerated]
		private List<KeyValuePair<AscTaskPriority, string>> <Priorities>k__BackingField;

		// Token: 0x040012AC RID: 4780
		[CompilerGenerated]
		private List<IDevice> <Devices>k__BackingField;

		// Token: 0x040012AD RID: 4781
		[CompilerGenerated]
		private List<IManufacturer> <Makers>k__BackingField;

		// Token: 0x040012AE RID: 4782
		[CompilerGenerated]
		private IAscTask <Task>k__BackingField;

		// Token: 0x040012AF RID: 4783
		[CompilerGenerated]
		private bool <OwnerVisible>k__BackingField;

		// Token: 0x020002CD RID: 717
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadTask>d__50 : IAsyncStateMachine
		{
			// Token: 0x060023E3 RID: 9187 RVA: 0x0006AB00 File Offset: 0x00068D00
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				EmployeeTaskViewModel employeeTaskViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IAscTask> awaiter;
					if (num != 0)
					{
						awaiter = employeeTaskViewModel._taskService.GetTask(employeeTaskViewModel.TaskId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IAscTask>, EmployeeTaskViewModel.<LoadTask>d__50>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IAscTask>);
						this.<>1__state = -1;
					}
					IAscTask result = awaiter.GetResult();
					employeeTaskViewModel.Task = result;
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

			// Token: 0x060023E4 RID: 9188 RVA: 0x0006ABC8 File Offset: 0x00068DC8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040012B0 RID: 4784
			public int <>1__state;

			// Token: 0x040012B1 RID: 4785
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040012B2 RID: 4786
			public EmployeeTaskViewModel <>4__this;

			// Token: 0x040012B3 RID: 4787
			private TaskAwaiter<IAscTask> <>u__1;
		}

		// Token: 0x020002CE RID: 718
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadCommon>d__54 : IAsyncStateMachine
		{
			// Token: 0x060023E5 RID: 9189 RVA: 0x0006ABE4 File Offset: 0x00068DE4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				EmployeeTaskViewModel employeeTaskViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<IManufacturer>> awaiter;
					if (num != 0)
					{
						employeeTaskViewModel.Priorities = employeeTaskViewModel._taskService.GetTaskPriorities();
						if (employeeTaskViewModel.Task.Type != TaskType.DeviceMatch)
						{
							employeeTaskViewModel.TaskStatuses = employeeTaskViewModel._taskService.GetTaskStatuses();
							goto IL_133;
						}
						if (employeeTaskViewModel.Task.CreatorId != null)
						{
							employeeTaskViewModel.TaskStatuses = employeeTaskViewModel._taskService.GetTaskDeviceMatchStatuses(employeeTaskViewModel.Task.CreatorId.Value);
						}
						employeeTaskViewModel.LoadDevices();
						IDevice device = employeeTaskViewModel.Devices.FirstOrDefault(delegate(IDevice d)
						{
							int id = d.Id;
							int? matchDevice = base.Task.MatchDevice;
							return id == matchDevice.GetValueOrDefault() & matchDevice != null;
						});
						if (device == null)
						{
							goto IL_118;
						}
						awaiter = employeeTaskViewModel._workshopService.GetManufacturers(device.CompanyList).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<IManufacturer>>, EmployeeTaskViewModel.<LoadCommon>d__54>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<IManufacturer>>);
						this.<>1__state = -1;
					}
					IEnumerable<IManufacturer> result = awaiter.GetResult();
					employeeTaskViewModel.Makers = new List<IManufacturer>(result);
					IL_118:;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_133:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060023E6 RID: 9190 RVA: 0x0006AD54 File Offset: 0x00068F54
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040012B4 RID: 4788
			public int <>1__state;

			// Token: 0x040012B5 RID: 4789
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040012B6 RID: 4790
			public EmployeeTaskViewModel <>4__this;

			// Token: 0x040012B7 RID: 4791
			private TaskAwaiter<IEnumerable<IManufacturer>> <>u__1;
		}

		// Token: 0x020002CF RID: 719
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060023E7 RID: 9191 RVA: 0x0006AD70 File Offset: 0x00068F70
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060023E8 RID: 9192 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x060023E9 RID: 9193 RVA: 0x0006AD88 File Offset: 0x00068F88
			internal bool <SetOwnerUser>b__55_0(Employee u)
			{
				return u.Id == Auth.User.id;
			}

			// Token: 0x040012B8 RID: 4792
			public static readonly EmployeeTaskViewModel.<>c <>9 = new EmployeeTaskViewModel.<>c();

			// Token: 0x040012B9 RID: 4793
			public static Func<Employee, bool> <>9__55_0;
		}

		// Token: 0x020002D0 RID: 720
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadDevices>d__56 : IAsyncStateMachine
		{
			// Token: 0x060023EA RID: 9194 RVA: 0x0006ADA8 File Offset: 0x00068FA8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				EmployeeTaskViewModel employeeTaskViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<IDevice>> awaiter;
					if (num != 0)
					{
						awaiter = employeeTaskViewModel._workshopService.GetActiveDevices().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<IDevice>>, EmployeeTaskViewModel.<LoadDevices>d__56>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<IDevice>>);
						this.<>1__state = -1;
					}
					IEnumerable<IDevice> result = awaiter.GetResult();
					employeeTaskViewModel.Devices = new List<IDevice>(result);
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

			// Token: 0x060023EB RID: 9195 RVA: 0x0006AE70 File Offset: 0x00069070
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040012BA RID: 4794
			public int <>1__state;

			// Token: 0x040012BB RID: 4795
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040012BC RID: 4796
			public EmployeeTaskViewModel <>4__this;

			// Token: 0x040012BD RID: 4797
			private TaskAwaiter<IEnumerable<IDevice>> <>u__1;
		}

		// Token: 0x020002D1 RID: 721
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <DeviceChanged>d__58 : IAsyncStateMachine
		{
			// Token: 0x060023EC RID: 9196 RVA: 0x0006AE8C File Offset: 0x0006908C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				EmployeeTaskViewModel employeeTaskViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<IManufacturer>> awaiter;
					if (num != 0)
					{
						if (employeeTaskViewModel.Devices == null || employeeTaskViewModel.Task == null)
						{
							goto IL_D1;
						}
						IDevice device = employeeTaskViewModel.Devices.FirstOrDefault(delegate(IDevice d)
						{
							int id = d.Id;
							int? matchDevice = base.Task.MatchDevice;
							return id == matchDevice.GetValueOrDefault() & matchDevice != null;
						});
						if (device == null)
						{
							goto IL_D1;
						}
						awaiter = employeeTaskViewModel._workshopService.GetManufacturers(device.CompanyList).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<IManufacturer>>, EmployeeTaskViewModel.<DeviceChanged>d__58>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<IManufacturer>>);
						this.<>1__state = -1;
					}
					IEnumerable<IManufacturer> result = awaiter.GetResult();
					employeeTaskViewModel.Makers = new List<IManufacturer>(result);
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_D1:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060023ED RID: 9197 RVA: 0x0006AF90 File Offset: 0x00069190
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040012BE RID: 4798
			public int <>1__state;

			// Token: 0x040012BF RID: 4799
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040012C0 RID: 4800
			public EmployeeTaskViewModel <>4__this;

			// Token: 0x040012C1 RID: 4801
			private TaskAwaiter<IEnumerable<IManufacturer>> <>u__1;
		}

		// Token: 0x020002D2 RID: 722
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateAndClose>d__59 : IAsyncStateMachine
		{
			// Token: 0x060023EE RID: 9198 RVA: 0x0006AFAC File Offset: 0x000691AC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				EmployeeTaskViewModel employeeTaskViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						if (!employeeTaskViewModel.CheckFields(employeeTaskViewModel.Task))
						{
							goto IL_F9;
						}
						employeeTaskViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter<int> awaiter;
						if (num != 0)
						{
							awaiter = System.Threading.Tasks.Task.Run<int>(() => employeeTaskViewModel._taskService.CreateTask(base.Task)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, EmployeeTaskViewModel.<CreateAndClose>d__59>(ref awaiter, ref this);
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
						int result = awaiter.GetResult();
						employeeTaskViewModel.TaskId = result;
						employeeTaskViewModel.LoadTask();
						employeeTaskViewModel._toasterService.Success(Lang.t("Saved"));
					}
					catch (Exception ex)
					{
						employeeTaskViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							employeeTaskViewModel.HideWait();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_F9:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060023EF RID: 9199 RVA: 0x0006B0F0 File Offset: 0x000692F0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040012C2 RID: 4802
			public int <>1__state;

			// Token: 0x040012C3 RID: 4803
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040012C4 RID: 4804
			public EmployeeTaskViewModel <>4__this;

			// Token: 0x040012C5 RID: 4805
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x020002D3 RID: 723
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Save>d__63 : IAsyncStateMachine
		{
			// Token: 0x060023F0 RID: 9200 RVA: 0x0006B10C File Offset: 0x0006930C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				EmployeeTaskViewModel employeeTaskViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						employeeTaskViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter<bool> awaiter;
						if (num != 0)
						{
							awaiter = System.Threading.Tasks.Task.Run<bool>(() => employeeTaskViewModel._taskService.UpdateTask(base.Task)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, EmployeeTaskViewModel.<Save>d__63>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<bool>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						awaiter.GetResult();
					}
					catch (Exception ex)
					{
						employeeTaskViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							employeeTaskViewModel.HideWait();
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

			// Token: 0x060023F1 RID: 9201 RVA: 0x0006B214 File Offset: 0x00069414
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040012C6 RID: 4806
			public int <>1__state;

			// Token: 0x040012C7 RID: 4807
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040012C8 RID: 4808
			public EmployeeTaskViewModel <>4__this;

			// Token: 0x040012C9 RID: 4809
			private TaskAwaiter<bool> <>u__1;
		}
	}
}
