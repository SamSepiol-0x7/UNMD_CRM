using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using ASC.Models;
using ASC.Objects;
using ASC.Salary;
using ASC.Services.Abstract;
using ASC.TaskManager;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Printing;

namespace ASC.ViewModels.Charts
{
	// Token: 0x02000533 RID: 1331
	public class EmployeesActivityChartViewModel : BaseViewModel
	{
		// Token: 0x17000F47 RID: 3911
		// (get) Token: 0x06003187 RID: 12679 RVA: 0x000A574C File Offset: 0x000A394C
		// (set) Token: 0x06003188 RID: 12680 RVA: 0x000A5760 File Offset: 0x000A3960
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

		// Token: 0x17000F48 RID: 3912
		// (get) Token: 0x06003189 RID: 12681 RVA: 0x000A5790 File Offset: 0x000A3990
		// (set) Token: 0x0600318A RID: 12682 RVA: 0x000A57A4 File Offset: 0x000A39A4
		public int SelectedOffice
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedOffice>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedOffice>k__BackingField == value)
				{
					return;
				}
				this.<SelectedOffice>k__BackingField = value;
				this.RaisePropertyChanged("SelectedOffice");
			}
		}

		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x0600318B RID: 12683 RVA: 0x000A57D0 File Offset: 0x000A39D0
		// (set) Token: 0x0600318C RID: 12684 RVA: 0x000A57E4 File Offset: 0x000A39E4
		public EmployeeActivityReport SelectedItem
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedItem>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedItem>k__BackingField, value))
				{
					return;
				}
				this.<SelectedItem>k__BackingField = value;
				this.RaisePropertyChanged("SelectedItem");
			}
		}

		// Token: 0x17000F4A RID: 3914
		// (get) Token: 0x0600318D RID: 12685 RVA: 0x000A5814 File Offset: 0x000A3A14
		// (set) Token: 0x0600318E RID: 12686 RVA: 0x000A5858 File Offset: 0x000A3A58
		public bool ShowArchive
		{
			get
			{
				return base.GetProperty<bool>(() => this.ShowArchive);
			}
			set
			{
				if (this.ShowArchive == value)
				{
					return;
				}
				base.SetProperty<bool>(() => this.ShowArchive, value, new Action(this.ArchiveChanged));
				this.RaisePropertyChanged("ShowArchive");
			}
		}

		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x0600318F RID: 12687 RVA: 0x000A58C0 File Offset: 0x000A3AC0
		// (set) Token: 0x06003190 RID: 12688 RVA: 0x000A58D4 File Offset: 0x000A3AD4
		public ObservableCollection<EmployeeActivityReport> Items
		{
			[CompilerGenerated]
			get
			{
				return this.<Items>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Items>k__BackingField, value))
				{
					return;
				}
				this.<Items>k__BackingField = value;
				this.RaisePropertyChanged("Items");
			}
		}

		// Token: 0x06003191 RID: 12689 RVA: 0x000A5904 File Offset: 0x000A3B04
		public EmployeesActivityChartViewModel(UsersModel usersModel, INavigationService navigationService, IWindowedDocumentService windowedDocumentService)
		{
			this._usersModel = usersModel;
			this._navigationService = navigationService;
			this._windowedDocumentService = windowedDocumentService;
			this.Period = new Period(DateTime.Now.AddMonths(-1), DateTime.Now);
			Period period = this.Period;
			period.RefreshEventHandler = (EventHandler)Delegate.Combine(period.RefreshEventHandler, new EventHandler(this.RefreshEventHandler));
			this.SetViewName("EmployeesActivity");
			this.LoadData();
		}

		// Token: 0x06003192 RID: 12690 RVA: 0x000A5984 File Offset: 0x000A3B84
		private void ArchiveChanged()
		{
			this.LoadData();
		}

		// Token: 0x06003193 RID: 12691 RVA: 0x000A5984 File Offset: 0x000A3B84
		private void RefreshEventHandler(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x06003194 RID: 12692 RVA: 0x000A5984 File Offset: 0x000A3B84
		[Command]
		public void Refresh()
		{
			this.LoadData();
		}

		// Token: 0x06003195 RID: 12693 RVA: 0x000A5998 File Offset: 0x000A3B98
		[Command]
		public void ItemDoubleClick()
		{
			if (this.SelectedItem != null)
			{
				goto IL_2C;
			}
			IL_08:
			int num = 158632848;
			IL_0D:
			switch ((num ^ 421929858) % 4)
			{
			case 0:
				goto IL_08;
			case 2:
				return;
			case 3:
				IL_2C:
				this._windowedDocumentService.ShowNewDocument("EmployeeActivityDetailsView", new EmployeeActivityDetailsViewModel(this.SelectedItem.Employee), null, null);
				num = 349824599;
				goto IL_0D;
			}
		}

		// Token: 0x06003196 RID: 12694 RVA: 0x000A59FC File Offset: 0x000A3BFC
		private void LoadData()
		{
			EmployeesActivityChartViewModel.<LoadData>d__27 <LoadData>d__;
			<LoadData>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadData>d__.<>4__this = this;
			<LoadData>d__.<>1__state = -1;
			<LoadData>d__.<>t__builder.Start<EmployeesActivityChartViewModel.<LoadData>d__27>(ref <LoadData>d__);
		}

		// Token: 0x06003197 RID: 12695 RVA: 0x000A5A34 File Offset: 0x000A3C34
		[Command]
		public void PrintTable(object obj)
		{
			TableView tableView = obj as TableView;
			if (tableView != null)
			{
				new PrintableControlLink(tableView)
				{
					PaperKind = PaperKind.A4,
					Landscape = true,
					Margins = new Margins(10, 10, 10, 10)
				}.ShowPrintPreview(Application.Current.MainWindow);
			}
		}

		// Token: 0x06003198 RID: 12696 RVA: 0x000A5A84 File Offset: 0x000A3C84
		[Command]
		public void CreateTask()
		{
			EmployeeTaskViewModel employeeTaskViewModel = new EmployeeTaskViewModel();
			employeeTaskViewModel.SetParentViewModel(this);
			employeeTaskViewModel.Task.AddResponsibleUser(this.SelectedItem.Employee.Id);
			this._navigationService.Navigate("EmployeeTaskView", employeeTaskViewModel);
		}

		// Token: 0x06003199 RID: 12697 RVA: 0x000A5ACC File Offset: 0x000A3CCC
		public bool CanCreateTask()
		{
			return this.SelectedItem != null;
		}

		// Token: 0x0600319A RID: 12698 RVA: 0x000A5AE4 File Offset: 0x000A3CE4
		[Command]
		public void SaralyReport()
		{
			SalaryViewModel salaryViewModel = new SalaryViewModel();
			salaryViewModel.SetParentViewModel(this);
			salaryViewModel.SetSelectedEmployee(this.SelectedItem.Employee.Id);
			salaryViewModel.LoadReport();
			this._navigationService.Navigate("SalaryView", salaryViewModel);
		}

		// Token: 0x0600319B RID: 12699 RVA: 0x000A5B2C File Offset: 0x000A3D2C
		public bool CanSalaryReport()
		{
			return this.SelectedItem != null && (this.SelectedItem.Employee.Id == OfflineData.Instance.Employee.Id || OfflineData.Instance.Employee.Can(12, 0));
		}

		// Token: 0x0600319C RID: 12700 RVA: 0x000A5B78 File Offset: 0x000A3D78
		[CompilerGenerated]
		private List<EmployeeActivityReport> <LoadData>b__27_0()
		{
			return this._usersModel.GetEmployeeActivityReport(this.Period, this.SelectedOffice, this.ShowArchive);
		}

		// Token: 0x04001C6C RID: 7276
		[CompilerGenerated]
		private Period <Period>k__BackingField;

		// Token: 0x04001C6D RID: 7277
		[CompilerGenerated]
		private int <SelectedOffice>k__BackingField;

		// Token: 0x04001C6E RID: 7278
		[CompilerGenerated]
		private EmployeeActivityReport <SelectedItem>k__BackingField;

		// Token: 0x04001C6F RID: 7279
		[CompilerGenerated]
		private ObservableCollection<EmployeeActivityReport> <Items>k__BackingField;

		// Token: 0x04001C70 RID: 7280
		private readonly UsersModel _usersModel;

		// Token: 0x04001C71 RID: 7281
		private readonly INavigationService _navigationService;

		// Token: 0x04001C72 RID: 7282
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x02000534 RID: 1332
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadData>d__27 : IAsyncStateMachine
		{
			// Token: 0x0600319D RID: 12701 RVA: 0x000A5BA4 File Offset: 0x000A3DA4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				EmployeesActivityChartViewModel employeesActivityChartViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<EmployeeActivityReport>> awaiter;
					if (num != 0)
					{
						employeesActivityChartViewModel.ShowWait();
						awaiter = Task.Run<List<EmployeeActivityReport>>(() => employeesActivityChartViewModel._usersModel.GetEmployeeActivityReport(base.Period, base.SelectedOffice, base.ShowArchive)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<EmployeeActivityReport>>, EmployeesActivityChartViewModel.<LoadData>d__27>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<EmployeeActivityReport>>);
						this.<>1__state = -1;
					}
					List<EmployeeActivityReport> result = awaiter.GetResult();
					employeesActivityChartViewModel.Items = new ObservableCollection<EmployeeActivityReport>(result);
					employeesActivityChartViewModel.HideWait();
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

			// Token: 0x0600319E RID: 12702 RVA: 0x000A5C7C File Offset: 0x000A3E7C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001C73 RID: 7283
			public int <>1__state;

			// Token: 0x04001C74 RID: 7284
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001C75 RID: 7285
			public EmployeesActivityChartViewModel <>4__this;

			// Token: 0x04001C76 RID: 7286
			private TaskAwaiter<List<EmployeeActivityReport>> <>u__1;
		}
	}
}
