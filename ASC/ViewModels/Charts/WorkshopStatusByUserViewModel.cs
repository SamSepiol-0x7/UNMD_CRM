using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Models;
using ASC.Options;
using ASC.Services.Abstract;
using DevExpress.Data;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Xpf.Grid;

namespace ASC.ViewModels.Charts
{
	// Token: 0x020004FB RID: 1275
	public class WorkshopStatusByUserViewModel : BaseViewModel
	{
		// Token: 0x17000EFE RID: 3838
		// (get) Token: 0x0600305E RID: 12382 RVA: 0x0009F660 File Offset: 0x0009D860
		// (set) Token: 0x0600305F RID: 12383 RVA: 0x0009F674 File Offset: 0x0009D874
		public ObservableCollection<Column> MasterColumns
		{
			[CompilerGenerated]
			get
			{
				return this.<MasterColumns>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(this.<MasterColumns>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 968084527;
				IL_13:
				switch ((num ^ 39057352) % 4)
				{
				case 0:
					goto IL_0E;
				case 2:
					IL_32:
					this.<MasterColumns>k__BackingField = value;
					this.RaisePropertyChanged("MasterColumns");
					num = 316563569;
					goto IL_13;
				case 3:
					return;
				}
			}
		}

		// Token: 0x17000EFF RID: 3839
		// (get) Token: 0x06003060 RID: 12384 RVA: 0x0009F6D0 File Offset: 0x0009D8D0
		// (set) Token: 0x06003061 RID: 12385 RVA: 0x0009F6E4 File Offset: 0x0009D8E4
		public ObservableCollection<Column> DetailColumns
		{
			[CompilerGenerated]
			get
			{
				return this.<DetailColumns>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<DetailColumns>k__BackingField, value))
				{
					return;
				}
				this.<DetailColumns>k__BackingField = value;
				this.RaisePropertyChanged("DetailColumns");
			}
		}

		// Token: 0x17000F00 RID: 3840
		// (get) Token: 0x06003062 RID: 12386 RVA: 0x0009F714 File Offset: 0x0009D914
		// (set) Token: 0x06003063 RID: 12387 RVA: 0x0009F728 File Offset: 0x0009D928
		public ObservableCollection<Summary> TotalSummary
		{
			[CompilerGenerated]
			get
			{
				return this.<TotalSummary>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<TotalSummary>k__BackingField, value))
				{
					return;
				}
				this.<TotalSummary>k__BackingField = value;
				this.RaisePropertyChanged("TotalSummary");
			}
		}

		// Token: 0x17000F01 RID: 3841
		// (get) Token: 0x06003064 RID: 12388 RVA: 0x0009F758 File Offset: 0x0009D958
		// (set) Token: 0x06003065 RID: 12389 RVA: 0x0009F76C File Offset: 0x0009D96C
		public List<users> Employees
		{
			[CompilerGenerated]
			get
			{
				return this.<Employees>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Employees>k__BackingField, value))
				{
					return;
				}
				this.<Employees>k__BackingField = value;
				this.RaisePropertyChanged("Employees");
			}
		}

		// Token: 0x17000F02 RID: 3842
		// (get) Token: 0x06003066 RID: 12390 RVA: 0x0009F79C File Offset: 0x0009D99C
		// (set) Token: 0x06003067 RID: 12391 RVA: 0x0009F7B0 File Offset: 0x0009D9B0
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
				if (!object.Equals(this.<Statuses>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -54223770;
				IL_13:
				switch ((num ^ -657240105) % 4)
				{
				case 1:
					return;
				case 2:
					IL_32:
					this.<Statuses>k__BackingField = value;
					num = -223159841;
					goto IL_13;
				case 3:
					goto IL_0E;
				}
				this.RaisePropertyChanged("Statuses");
			}
		}

		// Token: 0x17000F03 RID: 3843
		// (get) Token: 0x06003068 RID: 12392 RVA: 0x0009F80C File Offset: 0x0009DA0C
		public IPeriod Period
		{
			[CompilerGenerated]
			get
			{
				return this.<Period>k__BackingField;
			}
		}

		// Token: 0x17000F04 RID: 3844
		// (get) Token: 0x06003069 RID: 12393 RVA: 0x0009F820 File Offset: 0x0009DA20
		// (set) Token: 0x0600306A RID: 12394 RVA: 0x0009F834 File Offset: 0x0009DA34
		public List<int> SelectedEmployees
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedEmployees>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<SelectedEmployees>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1317553666;
				IL_13:
				switch ((num ^ 812369724) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					IL_32:
					this.<SelectedEmployees>k__BackingField = value;
					num = 1305263719;
					goto IL_13;
				case 2:
					return;
				}
				this.RaisePropertyChanged("SelectedEmployees");
			}
		}

		// Token: 0x17000F05 RID: 3845
		// (get) Token: 0x0600306B RID: 12395 RVA: 0x0009F890 File Offset: 0x0009DA90
		// (set) Token: 0x0600306C RID: 12396 RVA: 0x0009F8A4 File Offset: 0x0009DAA4
		public List<int> SelectedStatuses
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedStatuses>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<SelectedStatuses>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -687948114;
				IL_13:
				switch ((num ^ -1152575660) % 4)
				{
				case 0:
					goto IL_0E;
				case 2:
					return;
				case 3:
					IL_32:
					this.<SelectedStatuses>k__BackingField = value;
					this.RaisePropertyChanged("SelectedStatuses");
					num = -1119860967;
					goto IL_13;
				}
			}
		}

		// Token: 0x17000F06 RID: 3846
		// (get) Token: 0x0600306D RID: 12397 RVA: 0x0009F900 File Offset: 0x0009DB00
		// (set) Token: 0x0600306E RID: 12398 RVA: 0x0009F914 File Offset: 0x0009DB14
		public ObservableCollection<UserRepairStatusLogsModel> Source
		{
			[CompilerGenerated]
			get
			{
				return this.<Source>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<Source>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1231547386;
				IL_13:
				switch ((num ^ 2021971360) % 4)
				{
				case 0:
					goto IL_0E;
				case 2:
					return;
				case 3:
					IL_32:
					num = 1611539793;
					goto IL_13;
				}
				this.<Source>k__BackingField = value;
				this.RaisePropertyChanged("Source");
			}
		}

		// Token: 0x0600306F RID: 12399 RVA: 0x0009F970 File Offset: 0x0009DB70
		public WorkshopStatusByUserViewModel(INavigationService navigationService, IRepairStatusLogsService repairStatusLogsService, IToasterService toasterService, IEmployeeService employeeService, WorkshopOptions workshopOptions)
		{
			this.SetViewName(Lang.t("WorkshopStatusByUser"));
			this._navigationService = navigationService;
			this._repairStatusLogsService = repairStatusLogsService;
			this._toasterService = toasterService;
			this._employeeService = employeeService;
			this._workshopOptions = workshopOptions;
			this.Period = new Period();
			this.SelectedEmployees = new List<int>();
			this.SelectedStatuses = new List<int>();
		}

		// Token: 0x06003070 RID: 12400 RVA: 0x0009F9DC File Offset: 0x0009DBDC
		[AsyncCommand]
		public Task Refresh()
		{
			WorkshopStatusByUserViewModel.<Refresh>d__41 <Refresh>d__;
			<Refresh>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Refresh>d__.<>4__this = this;
			<Refresh>d__.<>1__state = -1;
			<Refresh>d__.<>t__builder.Start<WorkshopStatusByUserViewModel.<Refresh>d__41>(ref <Refresh>d__);
			return <Refresh>d__.<>t__builder.Task;
		}

		// Token: 0x06003071 RID: 12401 RVA: 0x0009FA20 File Offset: 0x0009DC20
		private void GenerateColumnsAndTotalSummary()
		{
			ObservableCollection<Summary> observableCollection = new ObservableCollection<Summary>();
			List<Column> list = new List<Column>
			{
				new BindingColumn(SettingsType.Binding, "UserFioShort", Lang.t("CoWorker"))
			};
			List<Column> list2 = new List<Column>
			{
				new BindingColumn(SettingsType.Binding, "Date", Lang.t("Date"))
			};
			using (List<int>.Enumerator enumerator = this.SelectedStatuses.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					int statusId = enumerator.Current;
					list.Add(new BindingColumn(SettingsType.Binding, string.Format("Total.StatusId_{0}", statusId), this.Statuses.Single((WorkshopOptions i) => i.Id == statusId).Name));
					list2.Add(new BindingColumn(SettingsType.Binding, string.Format("Id_{0}.Count", statusId), this.Statuses.Single((WorkshopOptions i) => i.Id == statusId).Name));
					observableCollection.Add(new Summary
					{
						Type = SummaryItemType.Sum,
						FieldName = string.Format("RowData.Row.Id_{0}.Count", statusId)
					});
				}
			}
			this.MasterColumns = new ObservableCollection<Column>(list);
			this.DetailColumns = new ObservableCollection<Column>(list2);
			this.TotalSummary = new ObservableCollection<Summary>(observableCollection);
		}

		// Token: 0x06003072 RID: 12402 RVA: 0x0009FB98 File Offset: 0x0009DD98
		private Task GetData()
		{
			WorkshopStatusByUserViewModel.<GetData>d__43 <GetData>d__;
			<GetData>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<GetData>d__.<>4__this = this;
			<GetData>d__.<>1__state = -1;
			<GetData>d__.<>t__builder.Start<WorkshopStatusByUserViewModel.<GetData>d__43>(ref <GetData>d__);
			return <GetData>d__.<>t__builder.Task;
		}

		// Token: 0x06003073 RID: 12403 RVA: 0x0009FBDC File Offset: 0x0009DDDC
		private bool InputValidationError()
		{
			if (this.SelectedEmployees == null || !this.SelectedEmployees.Any<int>())
			{
				this._toasterService.Info("Не выбран сотрудник");
				return true;
			}
			if (this.SelectedStatuses != null && this.SelectedStatuses.Any<int>())
			{
				return false;
			}
			this._toasterService.Info("Не выбран статус");
			return true;
		}

		// Token: 0x06003074 RID: 12404 RVA: 0x0009FC38 File Offset: 0x0009DE38
		public override void OnLoad()
		{
			WorkshopStatusByUserViewModel.<OnLoad>d__45 <OnLoad>d__;
			<OnLoad>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnLoad>d__.<>4__this = this;
			<OnLoad>d__.<>1__state = -1;
			<OnLoad>d__.<>t__builder.Start<WorkshopStatusByUserViewModel.<OnLoad>d__45>(ref <OnLoad>d__);
		}

		// Token: 0x17000F07 RID: 3847
		// (get) Token: 0x06003075 RID: 12405 RVA: 0x0009FC70 File Offset: 0x0009DE70
		// (set) Token: 0x06003076 RID: 12406 RVA: 0x0009FC84 File Offset: 0x0009DE84
		public virtual object CurrentItem
		{
			[CompilerGenerated]
			get
			{
				return this.<CurrentItem>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<CurrentItem>k__BackingField, value))
				{
					return;
				}
				this.<CurrentItem>k__BackingField = value;
				this.RaisePropertyChanged("CurrentItem");
			}
		}

		// Token: 0x17000F08 RID: 3848
		// (get) Token: 0x06003077 RID: 12407 RVA: 0x0009FCB4 File Offset: 0x0009DEB4
		// (set) Token: 0x06003078 RID: 12408 RVA: 0x0009FCC8 File Offset: 0x0009DEC8
		public virtual object RepairIds
		{
			[CompilerGenerated]
			get
			{
				return this.<RepairIds>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<RepairIds>k__BackingField, value))
				{
					return;
				}
				this.<RepairIds>k__BackingField = value;
				this.RaisePropertyChanged("RepairIds");
			}
		}

		// Token: 0x17000F09 RID: 3849
		// (get) Token: 0x06003079 RID: 12409 RVA: 0x0009FCF8 File Offset: 0x0009DEF8
		// (set) Token: 0x0600307A RID: 12410 RVA: 0x0009FD0C File Offset: 0x0009DF0C
		public virtual bool IsOpen
		{
			[CompilerGenerated]
			get
			{
				return this.<IsOpen>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IsOpen>k__BackingField == value)
				{
					return;
				}
				this.<IsOpen>k__BackingField = value;
				this.RaisePropertyChanged("IsOpen");
			}
		}

		// Token: 0x17000F0A RID: 3850
		// (get) Token: 0x0600307B RID: 12411 RVA: 0x0009FD38 File Offset: 0x0009DF38
		// (set) Token: 0x0600307C RID: 12412 RVA: 0x0009FD4C File Offset: 0x0009DF4C
		public virtual UIElement PlacementTarget
		{
			[CompilerGenerated]
			get
			{
				return this.<PlacementTarget>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<PlacementTarget>k__BackingField, value))
				{
					return;
				}
				this.<PlacementTarget>k__BackingField = value;
				this.RaisePropertyChanged("PlacementTarget");
			}
		}

		// Token: 0x0600307D RID: 12413 RVA: 0x0009FD7C File Offset: 0x0009DF7C
		[Command]
		public void ShownEditor(EditorEventArgs e)
		{
			if (e.Column.FieldName.EndsWith(".Count"))
			{
				string statusField = e.Column.FieldName.Replace("RowData.Row.", "").Replace(".Count", "");
				UserRepairStatusLogsModel.StatusData statusData = (this.CurrentItem as IDictionary<string, object>).FirstOrDefault((KeyValuePair<string, object> i) => i.Key == statusField).Value as UserRepairStatusLogsModel.StatusData;
				if (statusData != null)
				{
					this.RepairIds = statusData.RepairIds;
					if (statusData.RepairIds.Any<int>())
					{
						this.PlacementTarget = (FrameworkElement)e.Editor;
						Application.Current.Dispatcher.BeginInvoke(new Action(delegate()
						{
							this.IsOpen = true;
						}), DispatcherPriority.Input, new object[0]);
					}
				}
				return;
			}
		}

		// Token: 0x0600307E RID: 12414 RVA: 0x0009FE5C File Offset: 0x0009E05C
		[Command]
		public void NavigateToRepairCard(object parameter)
		{
			if (parameter is int)
			{
				int repairId = (int)parameter;
				this._navigationService.NavigateRepairCard(repairId);
			}
		}

		// Token: 0x0600307F RID: 12415 RVA: 0x0003401C File Offset: 0x0003221C
		[CompilerGenerated]
		[DebuggerHidden]
		private void <>n__0()
		{
			base.OnLoad();
		}

		// Token: 0x04001B83 RID: 7043
		private readonly INavigationService _navigationService;

		// Token: 0x04001B84 RID: 7044
		private readonly IRepairStatusLogsService _repairStatusLogsService;

		// Token: 0x04001B85 RID: 7045
		private readonly IToasterService _toasterService;

		// Token: 0x04001B86 RID: 7046
		private readonly IEmployeeService _employeeService;

		// Token: 0x04001B87 RID: 7047
		private readonly WorkshopOptions _workshopOptions;

		// Token: 0x04001B88 RID: 7048
		[CompilerGenerated]
		private ObservableCollection<Column> <MasterColumns>k__BackingField;

		// Token: 0x04001B89 RID: 7049
		[CompilerGenerated]
		private ObservableCollection<Column> <DetailColumns>k__BackingField;

		// Token: 0x04001B8A RID: 7050
		[CompilerGenerated]
		private ObservableCollection<Summary> <TotalSummary>k__BackingField;

		// Token: 0x04001B8B RID: 7051
		[CompilerGenerated]
		private List<users> <Employees>k__BackingField;

		// Token: 0x04001B8C RID: 7052
		[CompilerGenerated]
		private List<WorkshopOptions> <Statuses>k__BackingField;

		// Token: 0x04001B8D RID: 7053
		[CompilerGenerated]
		private readonly IPeriod <Period>k__BackingField;

		// Token: 0x04001B8E RID: 7054
		[CompilerGenerated]
		private List<int> <SelectedEmployees>k__BackingField;

		// Token: 0x04001B8F RID: 7055
		[CompilerGenerated]
		private List<int> <SelectedStatuses>k__BackingField;

		// Token: 0x04001B90 RID: 7056
		[CompilerGenerated]
		private ObservableCollection<UserRepairStatusLogsModel> <Source>k__BackingField;

		// Token: 0x04001B91 RID: 7057
		[CompilerGenerated]
		private object <CurrentItem>k__BackingField;

		// Token: 0x04001B92 RID: 7058
		[CompilerGenerated]
		private object <RepairIds>k__BackingField;

		// Token: 0x04001B93 RID: 7059
		[CompilerGenerated]
		private bool <IsOpen>k__BackingField;

		// Token: 0x04001B94 RID: 7060
		[CompilerGenerated]
		private UIElement <PlacementTarget>k__BackingField;

		// Token: 0x020004FC RID: 1276
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Refresh>d__41 : IAsyncStateMachine
		{
			// Token: 0x06003080 RID: 12416 RVA: 0x0009FE84 File Offset: 0x0009E084
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopStatusByUserViewModel workshopStatusByUserViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = workshopStatusByUserViewModel.GetData().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopStatusByUserViewModel.<Refresh>d__41>(ref awaiter, ref this);
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

			// Token: 0x06003081 RID: 12417 RVA: 0x0009FF38 File Offset: 0x0009E138
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001B95 RID: 7061
			public int <>1__state;

			// Token: 0x04001B96 RID: 7062
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001B97 RID: 7063
			public WorkshopStatusByUserViewModel <>4__this;

			// Token: 0x04001B98 RID: 7064
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020004FD RID: 1277
		[CompilerGenerated]
		private sealed class <>c__DisplayClass42_0
		{
			// Token: 0x06003082 RID: 12418 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass42_0()
			{
			}

			// Token: 0x06003083 RID: 12419 RVA: 0x0009FF54 File Offset: 0x0009E154
			internal bool <GenerateColumnsAndTotalSummary>b__0(WorkshopOptions i)
			{
				return i.Id == this.statusId;
			}

			// Token: 0x06003084 RID: 12420 RVA: 0x0009FF54 File Offset: 0x0009E154
			internal bool <GenerateColumnsAndTotalSummary>b__1(WorkshopOptions i)
			{
				return i.Id == this.statusId;
			}

			// Token: 0x04001B99 RID: 7065
			public int statusId;
		}

		// Token: 0x020004FE RID: 1278
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetData>d__43 : IAsyncStateMachine
		{
			// Token: 0x06003085 RID: 12421 RVA: 0x0009FF70 File Offset: 0x0009E170
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopStatusByUserViewModel workshopStatusByUserViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						if (workshopStatusByUserViewModel.InputValidationError())
						{
							goto IL_EF;
						}
						workshopStatusByUserViewModel.GenerateColumnsAndTotalSummary();
						workshopStatusByUserViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter<List<UserRepairStatusLogsModel>> awaiter;
						if (num != 0)
						{
							awaiter = workshopStatusByUserViewModel._repairStatusLogsService.GetData(workshopStatusByUserViewModel.Period, workshopStatusByUserViewModel.SelectedStatuses, workshopStatusByUserViewModel.SelectedEmployees).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<UserRepairStatusLogsModel>>, WorkshopStatusByUserViewModel.<GetData>d__43>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<UserRepairStatusLogsModel>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						List<UserRepairStatusLogsModel> result = awaiter.GetResult();
						workshopStatusByUserViewModel.Source = new ObservableCollection<UserRepairStatusLogsModel>(result);
					}
					catch (Exception ex)
					{
						workshopStatusByUserViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							workshopStatusByUserViewModel.HideWait();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_EF:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003086 RID: 12422 RVA: 0x000A00A8 File Offset: 0x0009E2A8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001B9A RID: 7066
			public int <>1__state;

			// Token: 0x04001B9B RID: 7067
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001B9C RID: 7068
			public WorkshopStatusByUserViewModel <>4__this;

			// Token: 0x04001B9D RID: 7069
			private TaskAwaiter<List<UserRepairStatusLogsModel>> <>u__1;
		}

		// Token: 0x020004FF RID: 1279
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnLoad>d__45 : IAsyncStateMachine
		{
			// Token: 0x06003087 RID: 12423 RVA: 0x000A00C4 File Offset: 0x0009E2C4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopStatusByUserViewModel workshopStatusByUserViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<users>> awaiter;
					if (num != 0)
					{
						if (workshopStatusByUserViewModel.ViewLoaded)
						{
							goto IL_B9;
						}
						awaiter = workshopStatusByUserViewModel._employeeService.GetEmployees().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<users>>, WorkshopStatusByUserViewModel.<OnLoad>d__45>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<users>>);
						this.<>1__state = -1;
					}
					List<users> result = awaiter.GetResult();
					workshopStatusByUserViewModel.Employees = result;
					workshopStatusByUserViewModel.Statuses = workshopStatusByUserViewModel._workshopOptions.GetAllOptions();
					workshopStatusByUserViewModel.SetViewLoaded(true);
					workshopStatusByUserViewModel.<>n__0();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_B9:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003088 RID: 12424 RVA: 0x000A01B0 File Offset: 0x0009E3B0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001B9E RID: 7070
			public int <>1__state;

			// Token: 0x04001B9F RID: 7071
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001BA0 RID: 7072
			public WorkshopStatusByUserViewModel <>4__this;

			// Token: 0x04001BA1 RID: 7073
			private TaskAwaiter<List<users>> <>u__1;
		}

		// Token: 0x02000500 RID: 1280
		[CompilerGenerated]
		private sealed class <>c__DisplayClass62_0
		{
			// Token: 0x06003089 RID: 12425 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass62_0()
			{
			}

			// Token: 0x0600308A RID: 12426 RVA: 0x000A01CC File Offset: 0x0009E3CC
			internal bool <ShownEditor>b__1(KeyValuePair<string, object> i)
			{
				return i.Key == this.statusField;
			}

			// Token: 0x0600308B RID: 12427 RVA: 0x000A01EC File Offset: 0x0009E3EC
			internal void <ShownEditor>b__0()
			{
				this.<>4__this.IsOpen = true;
			}

			// Token: 0x04001BA2 RID: 7074
			public string statusField;

			// Token: 0x04001BA3 RID: 7075
			public WorkshopStatusByUserViewModel <>4__this;
		}
	}
}
