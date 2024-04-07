using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Extensions;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using ASC.ViewModels;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.Charts.Masters
{
	// Token: 0x02000293 RID: 659
	public class MastersChartViewModel : ChartBaseViewModel
	{
		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x06002263 RID: 8803 RVA: 0x00064AFC File Offset: 0x00062CFC
		// (set) Token: 0x06002264 RID: 8804 RVA: 0x00064B10 File Offset: 0x00062D10
		public List<UserMaster> Users
		{
			[CompilerGenerated]
			get
			{
				return this.<Users>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Users>k__BackingField, value))
				{
					return;
				}
				this.<Users>k__BackingField = value;
				this.RaisePropertyChanged("Users");
			}
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x06002265 RID: 8805 RVA: 0x00064B40 File Offset: 0x00062D40
		// (set) Token: 0x06002266 RID: 8806 RVA: 0x00064B54 File Offset: 0x00062D54
		public List<IDevice> Devices
		{
			[CompilerGenerated]
			get
			{
				return this.<Devices>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Devices>k__BackingField, value))
				{
					return;
				}
				this.<Devices>k__BackingField = value;
				this.RaisePropertyChanged("Devices");
			}
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x06002267 RID: 8807 RVA: 0x00064B84 File Offset: 0x00062D84
		// (set) Token: 0x06002268 RID: 8808 RVA: 0x00064B98 File Offset: 0x00062D98
		public List<visit_sources> VisitSources
		{
			[CompilerGenerated]
			get
			{
				return this.<VisitSources>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<VisitSources>k__BackingField, value))
				{
					return;
				}
				this.<VisitSources>k__BackingField = value;
				this.RaisePropertyChanged("VisitSources");
			}
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x06002269 RID: 8809 RVA: 0x00064BC8 File Offset: 0x00062DC8
		// (set) Token: 0x0600226A RID: 8810 RVA: 0x00064BDC File Offset: 0x00062DDC
		public int SelectedUser
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedUser>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedUser>k__BackingField == value)
				{
					return;
				}
				this.<SelectedUser>k__BackingField = value;
				this.RaisePropertyChanged("SelectedUser");
			}
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x0600226B RID: 8811 RVA: 0x00064C08 File Offset: 0x00062E08
		// (set) Token: 0x0600226C RID: 8812 RVA: 0x00064C1C File Offset: 0x00062E1C
		public int SelectedDeviceId
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedDeviceId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedDeviceId>k__BackingField == value)
				{
					return;
				}
				this.<SelectedDeviceId>k__BackingField = value;
				this.RaisePropertyChanged("SelectedDeviceId");
			}
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x0600226D RID: 8813 RVA: 0x00064C48 File Offset: 0x00062E48
		// (set) Token: 0x0600226E RID: 8814 RVA: 0x00064C5C File Offset: 0x00062E5C
		public int SelectedState
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedState>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedState>k__BackingField == value)
				{
					return;
				}
				this.<SelectedState>k__BackingField = value;
				this.RaisePropertyChanged("SelectedState");
			}
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x0600226F RID: 8815 RVA: 0x00064C88 File Offset: 0x00062E88
		// (set) Token: 0x06002270 RID: 8816 RVA: 0x00064C9C File Offset: 0x00062E9C
		public IRepairCardForReport SelectedRepair
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedRepair>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedRepair>k__BackingField, value))
				{
					return;
				}
				this.<SelectedRepair>k__BackingField = value;
				this.RaisePropertyChanged("SelectedRepair");
			}
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x06002271 RID: 8817 RVA: 0x00064CCC File Offset: 0x00062ECC
		// (set) Token: 0x06002272 RID: 8818 RVA: 0x00064CE0 File Offset: 0x00062EE0
		public EmployeeRepairsReport Report
		{
			[CompilerGenerated]
			get
			{
				return this.<Report>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Report>k__BackingField, value))
				{
					return;
				}
				this.<Report>k__BackingField = value;
				this.RaisePropertyChanged("Report");
			}
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x06002273 RID: 8819 RVA: 0x00064D10 File Offset: 0x00062F10
		// (set) Token: 0x06002274 RID: 8820 RVA: 0x00064D24 File Offset: 0x00062F24
		public Dictionary<int, string> States
		{
			[CompilerGenerated]
			get
			{
				return this.<States>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<States>k__BackingField, value))
				{
					return;
				}
				this.<States>k__BackingField = value;
				this.RaisePropertyChanged("States");
			}
		}

		// Token: 0x06002275 RID: 8821 RVA: 0x00064D54 File Offset: 0x00062F54
		public MastersChartViewModel()
		{
			this._workshopService = Bootstrapper.Container.Resolve<IWorkshopService>();
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
			this.SetViewName("MastersChart");
			this.Report = new EmployeeRepairsReport();
			Period period = base.Period;
			period.RefreshEventHandler = (EventHandler)Delegate.Combine(period.RefreshEventHandler, new EventHandler(this.Refresh));
			this.States = new Dictionary<int, string>
			{
				{
					0,
					Lang.t("All")
				},
				{
					1,
					Lang.t("IssuedPayed")
				},
				{
					2,
					Lang.t("OutWithoutRepair")
				},
				{
					3,
					Lang.t("RepeatZeroCostRepairs")
				}
			};
		}

		// Token: 0x06002276 RID: 8822 RVA: 0x00064E14 File Offset: 0x00063014
		private void Refresh(object sender, EventArgs e)
		{
			this.RefreshChart(null);
		}

		// Token: 0x06002277 RID: 8823 RVA: 0x00064E28 File Offset: 0x00063028
		private Task LoadData()
		{
			MastersChartViewModel.<LoadData>d__40 <LoadData>d__;
			<LoadData>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadData>d__.<>4__this = this;
			<LoadData>d__.<>1__state = -1;
			<LoadData>d__.<>t__builder.Start<MastersChartViewModel.<LoadData>d__40>(ref <LoadData>d__);
			return <LoadData>d__.<>t__builder.Task;
		}

		// Token: 0x06002278 RID: 8824 RVA: 0x00064E6C File Offset: 0x0006306C
		public override void RefreshChart(object obj)
		{
			MastersChartViewModel.<RefreshChart>d__41 <RefreshChart>d__;
			<RefreshChart>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<RefreshChart>d__.<>4__this = this;
			<RefreshChart>d__.<>1__state = -1;
			<RefreshChart>d__.<>t__builder.Start<MastersChartViewModel.<RefreshChart>d__41>(ref <RefreshChart>d__);
		}

		// Token: 0x06002279 RID: 8825 RVA: 0x00064EA4 File Offset: 0x000630A4
		[Command]
		public void RepairDoubleClick()
		{
			if (this.SelectedRepair != null)
			{
				goto IL_2C;
			}
			IL_08:
			int num = 1192366223;
			IL_0D:
			switch ((num ^ 416661761) % 4)
			{
			case 1:
				IL_2C:
				this._navigationService.NavigateRepairCard(this.SelectedRepair.Id);
				num = 362964993;
				goto IL_0D;
			case 2:
				return;
			case 3:
				goto IL_08;
			}
		}

		// Token: 0x0600227A RID: 8826 RVA: 0x00064EFC File Offset: 0x000630FC
		[Command]
		public void CriteriaChanged()
		{
			MastersChartViewModel.<CriteriaChanged>d__43 <CriteriaChanged>d__;
			<CriteriaChanged>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<CriteriaChanged>d__.<>4__this = this;
			<CriteriaChanged>d__.<>1__state = -1;
			<CriteriaChanged>d__.<>t__builder.Start<MastersChartViewModel.<CriteriaChanged>d__43>(ref <CriteriaChanged>d__);
		}

		// Token: 0x0600227B RID: 8827 RVA: 0x00064F34 File Offset: 0x00063134
		public override void OnLoad()
		{
			MastersChartViewModel.<OnLoad>d__44 <OnLoad>d__;
			<OnLoad>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnLoad>d__.<>4__this = this;
			<OnLoad>d__.<>1__state = -1;
			<OnLoad>d__.<>t__builder.Start<MastersChartViewModel.<OnLoad>d__44>(ref <OnLoad>d__);
		}

		// Token: 0x0600227C RID: 8828 RVA: 0x00064F6C File Offset: 0x0006316C
		[CompilerGenerated]
		private Task <LoadData>b__40_0()
		{
			return this.Report.LoadData(base.Period, base.SelectedOffice, this.SelectedUser, this.SelectedDeviceId, this.SelectedState);
		}

		// Token: 0x0600227D RID: 8829 RVA: 0x0003401C File Offset: 0x0003221C
		[CompilerGenerated]
		[DebuggerHidden]
		private void <>n__0()
		{
			base.OnLoad();
		}

		// Token: 0x040011B3 RID: 4531
		protected IWorkshopService _workshopService;

		// Token: 0x040011B4 RID: 4532
		private readonly INavigationService _navigationService;

		// Token: 0x040011B5 RID: 4533
		[CompilerGenerated]
		private List<UserMaster> <Users>k__BackingField;

		// Token: 0x040011B6 RID: 4534
		[CompilerGenerated]
		private List<IDevice> <Devices>k__BackingField;

		// Token: 0x040011B7 RID: 4535
		[CompilerGenerated]
		private List<visit_sources> <VisitSources>k__BackingField;

		// Token: 0x040011B8 RID: 4536
		[CompilerGenerated]
		private int <SelectedUser>k__BackingField;

		// Token: 0x040011B9 RID: 4537
		[CompilerGenerated]
		private int <SelectedDeviceId>k__BackingField;

		// Token: 0x040011BA RID: 4538
		[CompilerGenerated]
		private int <SelectedState>k__BackingField;

		// Token: 0x040011BB RID: 4539
		[CompilerGenerated]
		private IRepairCardForReport <SelectedRepair>k__BackingField;

		// Token: 0x040011BC RID: 4540
		[CompilerGenerated]
		private EmployeeRepairsReport <Report>k__BackingField;

		// Token: 0x040011BD RID: 4541
		[CompilerGenerated]
		private Dictionary<int, string> <States>k__BackingField;

		// Token: 0x02000294 RID: 660
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadData>d__40 : IAsyncStateMachine
		{
			// Token: 0x0600227E RID: 8830 RVA: 0x00064FA4 File Offset: 0x000631A4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				MastersChartViewModel mastersChartViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<IDevice>> awaiter;
					TaskAwaiter<List<visit_sources>> awaiter2;
					TaskAwaiter awaiter3;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<IDevice>>);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<List<visit_sources>>);
						this.<>1__state = -1;
						goto IL_137;
					case 2:
						awaiter3 = this.<>u__3;
						this.<>u__3 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1A7;
					default:
						mastersChartViewModel.ShowWait();
						if (mastersChartViewModel.Users == null)
						{
							mastersChartViewModel.Users = new List<UserMaster>(UsersModel.LoadMasters(true));
						}
						if (mastersChartViewModel.Devices != null)
						{
							goto IL_D8;
						}
						awaiter = mastersChartViewModel._workshopService.GetActiveDevices().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<IDevice>>, MastersChartViewModel.<LoadData>d__40>(ref awaiter, ref this);
							return;
						}
						break;
					}
					IEnumerable<IDevice> result = awaiter.GetResult();
					mastersChartViewModel.Devices = new List<IDevice>(result).WithIncludeAll<IDevice>();
					mastersChartViewModel.Devices.Insert(1, new Device(-1, Lang.t("WithoutCartridges")));
					IL_D8:
					if (mastersChartViewModel.VisitSources != null)
					{
						goto IL_148;
					}
					awaiter2 = ChartModel.LoadVisitSourcesesAsync(true).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<visit_sources>>, MastersChartViewModel.<LoadData>d__40>(ref awaiter2, ref this);
						return;
					}
					IL_137:
					List<visit_sources> result2 = awaiter2.GetResult();
					mastersChartViewModel.VisitSources = result2;
					IL_148:
					awaiter3 = Task.Run(() => base.Report.LoadData(base.Period, base.SelectedOffice, base.SelectedUser, base.SelectedDeviceId, base.SelectedState)).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__3 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, MastersChartViewModel.<LoadData>d__40>(ref awaiter3, ref this);
						return;
					}
					IL_1A7:
					awaiter3.GetResult();
					mastersChartViewModel.HideWait();
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

			// Token: 0x0600227F RID: 8831 RVA: 0x000651B0 File Offset: 0x000633B0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040011BE RID: 4542
			public int <>1__state;

			// Token: 0x040011BF RID: 4543
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040011C0 RID: 4544
			public MastersChartViewModel <>4__this;

			// Token: 0x040011C1 RID: 4545
			private TaskAwaiter<IEnumerable<IDevice>> <>u__1;

			// Token: 0x040011C2 RID: 4546
			private TaskAwaiter<List<visit_sources>> <>u__2;

			// Token: 0x040011C3 RID: 4547
			private TaskAwaiter <>u__3;
		}

		// Token: 0x02000295 RID: 661
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <RefreshChart>d__41 : IAsyncStateMachine
		{
			// Token: 0x06002280 RID: 8832 RVA: 0x000651CC File Offset: 0x000633CC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				MastersChartViewModel mastersChartViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = mastersChartViewModel.LoadData().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, MastersChartViewModel.<RefreshChart>d__41>(ref awaiter, ref this);
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

			// Token: 0x06002281 RID: 8833 RVA: 0x00065280 File Offset: 0x00063480
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040011C4 RID: 4548
			public int <>1__state;

			// Token: 0x040011C5 RID: 4549
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040011C6 RID: 4550
			public MastersChartViewModel <>4__this;

			// Token: 0x040011C7 RID: 4551
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000296 RID: 662
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CriteriaChanged>d__43 : IAsyncStateMachine
		{
			// Token: 0x06002282 RID: 8834 RVA: 0x0006529C File Offset: 0x0006349C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				MastersChartViewModel mastersChartViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = mastersChartViewModel.LoadData().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, MastersChartViewModel.<CriteriaChanged>d__43>(ref awaiter, ref this);
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

			// Token: 0x06002283 RID: 8835 RVA: 0x00065350 File Offset: 0x00063550
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040011C8 RID: 4552
			public int <>1__state;

			// Token: 0x040011C9 RID: 4553
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040011CA RID: 4554
			public MastersChartViewModel <>4__this;

			// Token: 0x040011CB RID: 4555
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000297 RID: 663
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnLoad>d__44 : IAsyncStateMachine
		{
			// Token: 0x06002284 RID: 8836 RVA: 0x0006536C File Offset: 0x0006356C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				MastersChartViewModel mastersChartViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (mastersChartViewModel.ViewLoaded)
						{
							goto IL_78;
						}
						awaiter = mastersChartViewModel.LoadData().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, MastersChartViewModel.<OnLoad>d__44>(ref awaiter, ref this);
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
					mastersChartViewModel.SetViewLoaded(true);
					IL_78:
					mastersChartViewModel.<>n__0();
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

			// Token: 0x06002285 RID: 8837 RVA: 0x00065434 File Offset: 0x00063634
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040011CC RID: 4556
			public int <>1__state;

			// Token: 0x040011CD RID: 4557
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040011CE RID: 4558
			public MastersChartViewModel <>4__this;

			// Token: 0x040011CF RID: 4559
			private TaskAwaiter <>u__1;
		}
	}
}
