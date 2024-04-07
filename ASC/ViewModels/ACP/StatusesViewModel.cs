using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Input;
using ASC.Interfaces;
using ASC.Options;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;
using Newtonsoft.Json;

namespace ASC.ViewModels.ACP
{
	// Token: 0x0200059E RID: 1438
	public class StatusesViewModel : BaseViewModel, ICVMActions
	{
		// Token: 0x17001011 RID: 4113
		// (get) Token: 0x0600351D RID: 13597 RVA: 0x000B4A08 File Offset: 0x000B2C08
		// (set) Token: 0x0600351E RID: 13598 RVA: 0x000B4A1C File Offset: 0x000B2C1C
		public ObservableCollection<WorkshopOptions> Statuses
		{
			[CompilerGenerated]
			get
			{
				return this.<Statuses>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<Statuses>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 574919624;
				IL_13:
				switch ((num ^ 1913665555) % 4)
				{
				case 0:
					goto IL_0E;
				case 2:
					IL_32:
					num = 1010962090;
					goto IL_13;
				case 3:
					return;
				}
				this.<Statuses>k__BackingField = value;
				this.RaisePropertyChanged("Statuses");
			}
		}

		// Token: 0x17001012 RID: 4114
		// (get) Token: 0x0600351F RID: 13599 RVA: 0x000B4A78 File Offset: 0x000B2C78
		// (set) Token: 0x06003520 RID: 13600 RVA: 0x000B4A8C File Offset: 0x000B2C8C
		public WorkshopOptions SelectedStatus
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedStatus>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedStatus>k__BackingField, value))
				{
					return;
				}
				this.<SelectedStatus>k__BackingField = value;
				this.RaisePropertyChanged("SelectedStatus");
			}
		}

		// Token: 0x17001013 RID: 4115
		// (get) Token: 0x06003521 RID: 13601 RVA: 0x000B4ABC File Offset: 0x000B2CBC
		// (set) Token: 0x06003522 RID: 13602 RVA: 0x000B4AD0 File Offset: 0x000B2CD0
		public List<StatusActions> Actions
		{
			[CompilerGenerated]
			get
			{
				return this.<Actions>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<Actions>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1060292959;
				IL_13:
				switch ((num ^ 1111078725) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					IL_32:
					num = 42626510;
					goto IL_13;
				case 2:
					return;
				}
				this.<Actions>k__BackingField = value;
				this.RaisePropertyChanged("Actions");
			}
		}

		// Token: 0x17001014 RID: 4116
		// (get) Token: 0x06003523 RID: 13603 RVA: 0x000B4B2C File Offset: 0x000B2D2C
		// (set) Token: 0x06003524 RID: 13604 RVA: 0x000B4B40 File Offset: 0x000B2D40
		public IList<roles> Roles
		{
			[CompilerGenerated]
			get
			{
				return this.<Roles>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Roles>k__BackingField, value))
				{
					return;
				}
				this.<Roles>k__BackingField = value;
				this.RaisePropertyChanged("Roles");
			}
		}

		// Token: 0x17001015 RID: 4117
		// (get) Token: 0x06003525 RID: 13605 RVA: 0x000B4B70 File Offset: 0x000B2D70
		// (set) Token: 0x06003526 RID: 13606 RVA: 0x000B4B84 File Offset: 0x000B2D84
		public string NewStatusName
		{
			[CompilerGenerated]
			get
			{
				return this.<NewStatusName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<NewStatusName>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<NewStatusName>k__BackingField = value;
				this.RaisePropertyChanged("NewStatusName");
			}
		}

		// Token: 0x17001016 RID: 4118
		// (get) Token: 0x06003527 RID: 13607 RVA: 0x000B4BB4 File Offset: 0x000B2DB4
		// (set) Token: 0x06003528 RID: 13608 RVA: 0x000B4BC8 File Offset: 0x000B2DC8
		public List<int> NewStatusActions
		{
			[CompilerGenerated]
			get
			{
				return this.<NewStatusActions>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<NewStatusActions>k__BackingField, value))
				{
					return;
				}
				this.<NewStatusActions>k__BackingField = value;
				this.RaisePropertyChanged("NewStatusActions");
			}
		}

		// Token: 0x17001017 RID: 4119
		// (get) Token: 0x06003529 RID: 13609 RVA: 0x000B4BF8 File Offset: 0x000B2DF8
		// (set) Token: 0x0600352A RID: 13610 RVA: 0x000B4C0C File Offset: 0x000B2E0C
		public ObservableCollection<WorkshopOptions> SortedStatuses
		{
			[CompilerGenerated]
			get
			{
				return this.<SortedStatuses>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<SortedStatuses>k__BackingField, value))
				{
					return;
				}
				this.<SortedStatuses>k__BackingField = value;
				this.RaisePropertyChanged("SortedStatuses");
			}
		}

		// Token: 0x17001018 RID: 4120
		// (get) Token: 0x0600352B RID: 13611 RVA: 0x000B4C3C File Offset: 0x000B2E3C
		// (set) Token: 0x0600352C RID: 13612 RVA: 0x000B4C50 File Offset: 0x000B2E50
		public ICommand RestoreCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<RestoreCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<RestoreCommand>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1445707428;
				IL_13:
				switch ((num ^ 1813834567) % 4)
				{
				case 0:
					IL_32:
					num = 703474914;
					goto IL_13;
				case 2:
					goto IL_0E;
				case 3:
					return;
				}
				this.<RestoreCommand>k__BackingField = value;
				this.RaisePropertyChanged("RestoreCommand");
			}
		}

		// Token: 0x17001019 RID: 4121
		// (get) Token: 0x0600352D RID: 13613 RVA: 0x000B4CAC File Offset: 0x000B2EAC
		// (set) Token: 0x0600352E RID: 13614 RVA: 0x000B4CC0 File Offset: 0x000B2EC0
		public ICommand AddNewStatusCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<AddNewStatusCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<AddNewStatusCommand>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1500369152;
				IL_13:
				switch ((num ^ 2006871913) % 4)
				{
				case 1:
					return;
				case 2:
					goto IL_0E;
				case 3:
					IL_32:
					this.<AddNewStatusCommand>k__BackingField = value;
					this.RaisePropertyChanged("AddNewStatusCommand");
					num = 899514717;
					goto IL_13;
				}
			}
		}

		// Token: 0x1700101A RID: 4122
		// (get) Token: 0x0600352F RID: 13615 RVA: 0x000B4D1C File Offset: 0x000B2F1C
		// (set) Token: 0x06003530 RID: 13616 RVA: 0x000B4D30 File Offset: 0x000B2F30
		public ICommand DeleteStatusCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<DeleteStatusCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<DeleteStatusCommand>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 306919383;
				IL_13:
				switch ((num ^ 1179286476) % 4)
				{
				case 0:
					goto IL_0E;
				case 2:
					IL_32:
					this.<DeleteStatusCommand>k__BackingField = value;
					this.RaisePropertyChanged("DeleteStatusCommand");
					num = 1956615997;
					goto IL_13;
				case 3:
					return;
				}
			}
		}

		// Token: 0x06003531 RID: 13617 RVA: 0x000B4D8C File Offset: 0x000B2F8C
		private void InitCommands()
		{
			this.RestoreCommand = new RelayCommand(new Action<object>(this.Restore));
			this.AddNewStatusCommand = new RelayCommand(new Action<object>(this.AddNewStatus));
			this.DeleteStatusCommand = new RelayCommand(new Action<object>(this.DeleteStatus));
		}

		// Token: 0x06003532 RID: 13618 RVA: 0x000B4DE0 File Offset: 0x000B2FE0
		public StatusesViewModel()
		{
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._rolesService = Bootstrapper.Container.Resolve<IRolesService>();
			this.InitCommands();
		}

		// Token: 0x06003533 RID: 13619 RVA: 0x000B4E24 File Offset: 0x000B3024
		public void Init()
		{
			StatusesViewModel.<Init>d__44 <Init>d__;
			<Init>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<StatusesViewModel.<Init>d__44>(ref <Init>d__);
		}

		// Token: 0x06003534 RID: 13620 RVA: 0x000B4E5C File Offset: 0x000B305C
		private void SetSortedStatuses(IEnumerable<WorkshopOptions> statuses)
		{
			this.SortedStatuses = new ObservableCollection<WorkshopOptions>(from i in statuses
			orderby i.Name
			select i);
		}

		// Token: 0x06003535 RID: 13621 RVA: 0x000B4E9C File Offset: 0x000B309C
		private bool Save2Db(IEnumerable<WorkshopOptions> statuses)
		{
			string statuses2 = JsonConvert.SerializeObject(statuses);
			bool result;
			using (auseceEntities auseceEntities = new auseceEntities(true))
			{
				config config = auseceEntities.config.FirstOrDefault((config c) => c.id == 1);
				if (config != null)
				{
					config.statuses = statuses2;
					try
					{
						auseceEntities.SaveChanges();
					}
					catch (Exception)
					{
						return false;
					}
					Auth.Config = config;
					WorkshopOptions.RefreshConfig();
					this.Init();
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06003536 RID: 13622 RVA: 0x000B4F74 File Offset: 0x000B3174
		private void Restore(object obj)
		{
			List<WorkshopOptions> defaults = new WorkshopOptions().GetDefaults();
			this.Save2Db(defaults);
			this.Init();
		}

		// Token: 0x06003537 RID: 13623 RVA: 0x000B4F9C File Offset: 0x000B319C
		private List<WorkshopOptions> LoadStatuses()
		{
			return new WorkshopOptions().GetAllOptions();
		}

		// Token: 0x06003538 RID: 13624 RVA: 0x000B4FB4 File Offset: 0x000B31B4
		private bool CheckNewStatusFields()
		{
			if (string.IsNullOrEmpty(this.NewStatusName))
			{
				this._toasterService.Info(Lang.t("InputStatusName"));
				return false;
			}
			return true;
		}

		// Token: 0x06003539 RID: 13625 RVA: 0x000B4FE8 File Offset: 0x000B31E8
		private void AddNewStatus(object obj)
		{
			if (this.CheckNewStatusFields())
			{
				int num = this.Statuses.Max((WorkshopOptions s) => s.Id);
				if (num <= 30)
				{
					num = 30;
				}
				WorkshopOptions item = new WorkshopOptions
				{
					Id = num + 1,
					Name = this.NewStatusName,
					Actions = this.NewStatusActions
				};
				this.Statuses.Add(item);
				this.SetSortedStatuses(this.Statuses);
				return;
			}
		}

		// Token: 0x0600353A RID: 13626 RVA: 0x000B5070 File Offset: 0x000B3270
		private void DeleteStatus(object obj)
		{
			if (this.SelectedStatus == null)
			{
				return;
			}
			if (this.IsStatusUsed())
			{
				this._toasterService.Error(Lang.t("StatusInUse"));
				return;
			}
			foreach (WorkshopOptions workshopOptions in this.Statuses)
			{
				if (workshopOptions.Contains != null && workshopOptions.Contains.Any<int>() && workshopOptions.Contains.Contains(this.SelectedStatus.Id))
				{
					workshopOptions.Contains.Remove(this.SelectedStatus.Id);
				}
			}
			this.Statuses.Remove(this.SelectedStatus);
			this.SetSortedStatuses(this.Statuses);
		}

		// Token: 0x0600353B RID: 13627 RVA: 0x000B5140 File Offset: 0x000B3340
		private bool IsStatusUsed()
		{
			bool result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					result = auseceEntities.workshop.Any((workshop w) => w.state == this.SelectedStatus.Id);
				}
			}
			catch (Exception)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x0600353C RID: 13628 RVA: 0x0009582C File Offset: 0x00093A2C
		protected override void OnParentViewModelChanged(object parentViewModel)
		{
			base.OnParentViewModelChanged(parentViewModel);
			ACPV2ViewModel acpv2ViewModel = parentViewModel as ACPV2ViewModel;
			if (acpv2ViewModel != null)
			{
				acpv2ViewModel.SetChildViewModel(this);
			}
		}

		// Token: 0x0600353D RID: 13629 RVA: 0x000B5204 File Offset: 0x000B3404
		[Command]
		public void Save()
		{
			base.ShowActionResponse(this.Save2Db(this.Statuses), "");
		}

		// Token: 0x0600353E RID: 13630 RVA: 0x0007E5F4 File Offset: 0x0007C7F4
		public bool CanSave()
		{
			return true;
		}

		// Token: 0x0600353F RID: 13631 RVA: 0x0007E558 File Offset: 0x0007C758
		public void Refresh()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06003540 RID: 13632 RVA: 0x000304B4 File Offset: 0x0002E6B4
		public bool CanRefresh()
		{
			return false;
		}

		// Token: 0x06003541 RID: 13633 RVA: 0x000B5228 File Offset: 0x000B3428
		public override void OnLoad()
		{
			this.Init();
			base.OnLoad();
		}

		// Token: 0x04001E9D RID: 7837
		private readonly IToasterService _toasterService;

		// Token: 0x04001E9E RID: 7838
		private readonly IRolesService _rolesService;

		// Token: 0x04001E9F RID: 7839
		[CompilerGenerated]
		private ObservableCollection<WorkshopOptions> <Statuses>k__BackingField;

		// Token: 0x04001EA0 RID: 7840
		[CompilerGenerated]
		private WorkshopOptions <SelectedStatus>k__BackingField;

		// Token: 0x04001EA1 RID: 7841
		[CompilerGenerated]
		private List<StatusActions> <Actions>k__BackingField;

		// Token: 0x04001EA2 RID: 7842
		[CompilerGenerated]
		private IList<roles> <Roles>k__BackingField;

		// Token: 0x04001EA3 RID: 7843
		[CompilerGenerated]
		private string <NewStatusName>k__BackingField;

		// Token: 0x04001EA4 RID: 7844
		[CompilerGenerated]
		private List<int> <NewStatusActions>k__BackingField = new List<int>();

		// Token: 0x04001EA5 RID: 7845
		[CompilerGenerated]
		private ObservableCollection<WorkshopOptions> <SortedStatuses>k__BackingField;

		// Token: 0x04001EA6 RID: 7846
		[CompilerGenerated]
		private ICommand <RestoreCommand>k__BackingField;

		// Token: 0x04001EA7 RID: 7847
		[CompilerGenerated]
		private ICommand <AddNewStatusCommand>k__BackingField;

		// Token: 0x04001EA8 RID: 7848
		[CompilerGenerated]
		private ICommand <DeleteStatusCommand>k__BackingField;

		// Token: 0x0200059F RID: 1439
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Init>d__44 : IAsyncStateMachine
		{
			// Token: 0x06003542 RID: 13634 RVA: 0x000B5244 File Offset: 0x000B3444
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				StatusesViewModel statusesViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IList<roles>> awaiter;
					if (num != 0)
					{
						WorkshopOptions workshopOptions = new WorkshopOptions();
						statusesViewModel.Statuses = new ObservableCollection<WorkshopOptions>(statusesViewModel.LoadStatuses());
						statusesViewModel.SetSortedStatuses(statusesViewModel.Statuses);
						statusesViewModel.Actions = workshopOptions.GetActions();
						awaiter = statusesViewModel._rolesService.GetRolesAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IList<roles>>, StatusesViewModel.<Init>d__44>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IList<roles>>);
						this.<>1__state = -1;
					}
					IList<roles> result = awaiter.GetResult();
					statusesViewModel.Roles = result;
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

			// Token: 0x06003543 RID: 13635 RVA: 0x000B5338 File Offset: 0x000B3538
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001EA9 RID: 7849
			public int <>1__state;

			// Token: 0x04001EAA RID: 7850
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001EAB RID: 7851
			public StatusesViewModel <>4__this;

			// Token: 0x04001EAC RID: 7852
			private TaskAwaiter<IList<roles>> <>u__1;
		}

		// Token: 0x020005A0 RID: 1440
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003544 RID: 13636 RVA: 0x000B5354 File Offset: 0x000B3554
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003545 RID: 13637 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06003546 RID: 13638 RVA: 0x000B536C File Offset: 0x000B356C
			internal string <SetSortedStatuses>b__45_0(WorkshopOptions i)
			{
				return i.Name;
			}

			// Token: 0x06003547 RID: 13639 RVA: 0x00061058 File Offset: 0x0005F258
			internal int <AddNewStatus>b__50_0(WorkshopOptions s)
			{
				return s.Id;
			}

			// Token: 0x04001EAD RID: 7853
			public static readonly StatusesViewModel.<>c <>9 = new StatusesViewModel.<>c();

			// Token: 0x04001EAE RID: 7854
			public static Func<WorkshopOptions, string> <>9__45_0;

			// Token: 0x04001EAF RID: 7855
			public static Func<WorkshopOptions, int> <>9__50_0;
		}
	}
}
