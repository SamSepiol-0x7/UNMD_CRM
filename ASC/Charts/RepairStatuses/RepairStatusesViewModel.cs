using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using ASC.Models;
using ASC.Options;
using ASC.Properties;
using ASC.Services.Abstract;
using ASC.ViewModels;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.Charts.RepairStatuses
{
	// Token: 0x0200028C RID: 652
	public class RepairStatusesViewModel : BaseViewModel
	{
		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x06002222 RID: 8738 RVA: 0x00063D08 File Offset: 0x00061F08
		// (set) Token: 0x06002223 RID: 8739 RVA: 0x00063D20 File Offset: 0x00061F20
		public int IgnoreAfter
		{
			get
			{
				return Settings.Default.IgnoreAfter;
			}
			set
			{
				if (this.IgnoreAfter == value)
				{
					return;
				}
				Settings.Default.IgnoreAfter = value;
				Settings.Default.Save();
				this.RaisePropertyChanged("IgnoreAfter");
			}
		}

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x06002224 RID: 8740 RVA: 0x00063D5C File Offset: 0x00061F5C
		// (set) Token: 0x06002225 RID: 8741 RVA: 0x00063D70 File Offset: 0x00061F70
		public int SelectedOffice
		{
			get
			{
				return this._selectedOffice;
			}
			set
			{
				if (this._selectedOffice == value)
				{
					return;
				}
				this._selectedOffice = value;
				this.RaisePropertyChanged("SelectedOffice");
				this.Refresh();
			}
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x06002226 RID: 8742 RVA: 0x00063DA4 File Offset: 0x00061FA4
		// (set) Token: 0x06002227 RID: 8743 RVA: 0x00063DB8 File Offset: 0x00061FB8
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

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x06002228 RID: 8744 RVA: 0x00063DEC File Offset: 0x00061FEC
		// (set) Token: 0x06002229 RID: 8745 RVA: 0x00063E00 File Offset: 0x00062000
		public int SelectedStatus
		{
			get
			{
				return this._selectedStatus;
			}
			set
			{
				if (this._selectedStatus == value)
				{
					return;
				}
				this._selectedStatus = value;
				this.RaisePropertyChanged("SelectedStatus");
				this.Refresh();
			}
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x0600222A RID: 8746 RVA: 0x00063E34 File Offset: 0x00062034
		// (set) Token: 0x0600222B RID: 8747 RVA: 0x00063E48 File Offset: 0x00062048
		public workshop SelectedRepair
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

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x0600222C RID: 8748 RVA: 0x00063E78 File Offset: 0x00062078
		// (set) Token: 0x0600222D RID: 8749 RVA: 0x00063E8C File Offset: 0x0006208C
		public ObservableCollection<workshop> Repairs
		{
			[CompilerGenerated]
			get
			{
				return this.<Repairs>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Repairs>k__BackingField, value))
				{
					return;
				}
				this.<Repairs>k__BackingField = value;
				this.RaisePropertyChanged("Repairs");
			}
		}

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x0600222E RID: 8750 RVA: 0x00063EBC File Offset: 0x000620BC
		// (set) Token: 0x0600222F RID: 8751 RVA: 0x00063ED0 File Offset: 0x000620D0
		public ObservableCollection<StatusesChart> RepairStatuses
		{
			[CompilerGenerated]
			get
			{
				return this.<RepairStatuses>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<RepairStatuses>k__BackingField, value))
				{
					return;
				}
				this.<RepairStatuses>k__BackingField = value;
				this.RaisePropertyChanged("RepairStatuses");
			}
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x06002230 RID: 8752 RVA: 0x00063F00 File Offset: 0x00062100
		// (set) Token: 0x06002231 RID: 8753 RVA: 0x00063F14 File Offset: 0x00062114
		public List<WorkshopOptions> WorkshopOptionses
		{
			[CompilerGenerated]
			get
			{
				return this.<WorkshopOptionses>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<WorkshopOptionses>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1607188963;
				IL_13:
				switch ((num ^ -1662264512) % 4)
				{
				case 0:
					IL_32:
					this.<WorkshopOptionses>k__BackingField = value;
					this.RaisePropertyChanged("WorkshopOptionses");
					num = -4964353;
					goto IL_13;
				case 1:
					return;
				case 2:
					goto IL_0E;
				}
			}
		}

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x06002232 RID: 8754 RVA: 0x00063F70 File Offset: 0x00062170
		// (set) Token: 0x06002233 RID: 8755 RVA: 0x00063F84 File Offset: 0x00062184
		public int RepairsCount
		{
			[CompilerGenerated]
			get
			{
				return this.<RepairsCount>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<RepairsCount>k__BackingField == value)
				{
					return;
				}
				this.<RepairsCount>k__BackingField = value;
				this.RaisePropertyChanged("RepairsCount");
			}
		}

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x06002234 RID: 8756 RVA: 0x00063FB0 File Offset: 0x000621B0
		// (set) Token: 0x06002235 RID: 8757 RVA: 0x00063FC4 File Offset: 0x000621C4
		public decimal? RepairsCost
		{
			[CompilerGenerated]
			get
			{
				return this.<RepairsCost>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<decimal>(this.<RepairsCost>k__BackingField, value))
				{
					return;
				}
				this.<RepairsCost>k__BackingField = value;
				this.RaisePropertyChanged("RepairsCost");
			}
		}

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x06002236 RID: 8758 RVA: 0x00063FF4 File Offset: 0x000621F4
		// (set) Token: 0x06002237 RID: 8759 RVA: 0x00064008 File Offset: 0x00062208
		public decimal? Ready2IssueSumm
		{
			[CompilerGenerated]
			get
			{
				return this.<Ready2IssueSumm>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<decimal>(this.<Ready2IssueSumm>k__BackingField, value))
				{
					return;
				}
				this.<Ready2IssueSumm>k__BackingField = value;
				this.RaisePropertyChanged("Ready2IssueSumm");
			}
		}

		// Token: 0x06002238 RID: 8760 RVA: 0x00064038 File Offset: 0x00062238
		public RepairStatusesViewModel()
		{
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
			this.SetViewName("Report", "RepairStatuses");
			this.Init();
			this.LoadChartData();
		}

		// Token: 0x06002239 RID: 8761 RVA: 0x00064080 File Offset: 0x00062280
		private void Init()
		{
			List<WorkshopOptions> allOptionsWithDummy = new WorkshopOptions().GetAllOptionsWithDummy();
			List<WorkshopOptions> list = (from o in allOptionsWithDummy
			where o.Id == 8 || o.Id == 12
			select o).ToList<WorkshopOptions>();
			if (allOptionsWithDummy.Any<WorkshopOptions>())
			{
				foreach (WorkshopOptions item in list)
				{
					allOptionsWithDummy.Remove(item);
				}
				this.WorkshopOptionses = allOptionsWithDummy;
			}
		}

		// Token: 0x0600223A RID: 8762 RVA: 0x00064118 File Offset: 0x00062318
		private void LoadChartData()
		{
			base.ShowWait();
			Task.Run<IEnumerable<workshop>>(() => ChartModel.LoadRepairStatusesData(this.SelectedOffice, this.SelectedUser, this.SelectedStatus, this.IgnoreAfter)).ContinueWith(delegate(Task<IEnumerable<workshop>> t)
			{
				this.Repairs = new ObservableCollection<workshop>(t.Result);
				List<IGrouping<int, workshop>> list = (from r in this.Repairs
				group r by r.state).ToList<IGrouping<int, workshop>>();
				WorkshopOptions workshopOptions = new WorkshopOptions();
				ObservableCollection<StatusesChart> observableCollection = new ObservableCollection<StatusesChart>();
				decimal? num = new decimal?(0m);
				foreach (IGrouping<int, workshop> grouping in list)
				{
					WorkshopOptions option = workshopOptions.GetOption(grouping.Key);
					decimal? num2 = this.StatusSumma(option);
					if (option != null)
					{
						observableCollection.Add(new StatusesChart
						{
							Color = option.Color,
							Name = option.Name,
							Count = grouping.Count<workshop>(),
							Summa = num2
						});
					}
					if (option != null && option.Id == 6)
					{
						this.Ready2IssueSumm = num2;
					}
					num += num2;
				}
				this.RepairsCost = num;
				this.RepairStatuses = observableCollection;
				this.RepairsCount = this.Repairs.Count;
				base.HideWait();
			}, TaskScheduler.FromCurrentSynchronizationContext());
		}

		// Token: 0x0600223B RID: 8763 RVA: 0x00064154 File Offset: 0x00062354
		private decimal? StatusSumma(WorkshopOptions st)
		{
			if (this.Repairs != null)
			{
				return new decimal?((from r in this.Repairs
				where r.state == st.Id
				select r.ShowRepairCost).DefaultIfEmpty<decimal>().Sum());
			}
			return new decimal?(0m);
		}

		// Token: 0x0600223C RID: 8764 RVA: 0x000641D0 File Offset: 0x000623D0
		[Command]
		public void Refresh()
		{
			this.LoadChartData();
		}

		// Token: 0x0600223D RID: 8765 RVA: 0x000641E4 File Offset: 0x000623E4
		[Command]
		public void ItemClick()
		{
			if (this.SelectedRepair != null)
			{
				goto IL_2C;
			}
			IL_08:
			int num = 503171615;
			IL_0D:
			switch ((num ^ 1276873773) % 4)
			{
			case 0:
				goto IL_08;
			case 2:
				return;
			case 3:
				IL_2C:
				this._navigationService.NavigateRepairCard(this.SelectedRepair.id);
				num = 1045924264;
				goto IL_0D;
			}
		}

		// Token: 0x0600223E RID: 8766 RVA: 0x0006423C File Offset: 0x0006243C
		[CompilerGenerated]
		private Task<IEnumerable<workshop>> <LoadChartData>b__46_0()
		{
			return ChartModel.LoadRepairStatusesData(this.SelectedOffice, this.SelectedUser, this.SelectedStatus, this.IgnoreAfter);
		}

		// Token: 0x0600223F RID: 8767 RVA: 0x00064268 File Offset: 0x00062468
		[CompilerGenerated]
		private void <LoadChartData>b__46_1(Task<IEnumerable<workshop>> t)
		{
			this.Repairs = new ObservableCollection<workshop>(t.Result);
			List<IGrouping<int, workshop>> list = (from r in this.Repairs
			group r by r.state).ToList<IGrouping<int, workshop>>();
			WorkshopOptions workshopOptions = new WorkshopOptions();
			ObservableCollection<StatusesChart> observableCollection = new ObservableCollection<StatusesChart>();
			decimal? num = new decimal?(0m);
			foreach (IGrouping<int, workshop> grouping in list)
			{
				WorkshopOptions option = workshopOptions.GetOption(grouping.Key);
				decimal? num2 = this.StatusSumma(option);
				if (option != null)
				{
					observableCollection.Add(new StatusesChart
					{
						Color = option.Color,
						Name = option.Name,
						Count = grouping.Count<workshop>(),
						Summa = num2
					});
				}
				if (option != null && option.Id == 6)
				{
					this.Ready2IssueSumm = num2;
				}
				num += num2;
			}
			this.RepairsCost = num;
			this.RepairStatuses = observableCollection;
			this.RepairsCount = this.Repairs.Count;
			base.HideWait();
		}

		// Token: 0x04001190 RID: 4496
		private int _selectedUser;

		// Token: 0x04001191 RID: 4497
		private int _selectedOffice;

		// Token: 0x04001192 RID: 4498
		private int _selectedStatus = 99;

		// Token: 0x04001193 RID: 4499
		private INavigationService _navigationService;

		// Token: 0x04001194 RID: 4500
		[CompilerGenerated]
		private workshop <SelectedRepair>k__BackingField;

		// Token: 0x04001195 RID: 4501
		[CompilerGenerated]
		private ObservableCollection<workshop> <Repairs>k__BackingField;

		// Token: 0x04001196 RID: 4502
		[CompilerGenerated]
		private ObservableCollection<StatusesChart> <RepairStatuses>k__BackingField;

		// Token: 0x04001197 RID: 4503
		[CompilerGenerated]
		private List<WorkshopOptions> <WorkshopOptionses>k__BackingField;

		// Token: 0x04001198 RID: 4504
		[CompilerGenerated]
		private int <RepairsCount>k__BackingField;

		// Token: 0x04001199 RID: 4505
		[CompilerGenerated]
		private decimal? <RepairsCost>k__BackingField;

		// Token: 0x0400119A RID: 4506
		[CompilerGenerated]
		private decimal? <Ready2IssueSumm>k__BackingField;

		// Token: 0x0200028D RID: 653
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002240 RID: 8768 RVA: 0x000643E4 File Offset: 0x000625E4
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06002241 RID: 8769 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06002242 RID: 8770 RVA: 0x000643FC File Offset: 0x000625FC
			internal bool <Init>b__45_0(WorkshopOptions o)
			{
				return o.Id == 8 || o.Id == 12;
			}

			// Token: 0x06002243 RID: 8771 RVA: 0x00064420 File Offset: 0x00062620
			internal int <LoadChartData>b__46_2(workshop r)
			{
				return r.state;
			}

			// Token: 0x06002244 RID: 8772 RVA: 0x00064434 File Offset: 0x00062634
			internal decimal <StatusSumma>b__47_1(workshop r)
			{
				return r.ShowRepairCost;
			}

			// Token: 0x0400119B RID: 4507
			public static readonly RepairStatusesViewModel.<>c <>9 = new RepairStatusesViewModel.<>c();

			// Token: 0x0400119C RID: 4508
			public static Func<WorkshopOptions, bool> <>9__45_0;

			// Token: 0x0400119D RID: 4509
			public static Func<workshop, int> <>9__46_2;

			// Token: 0x0400119E RID: 4510
			public static Func<workshop, decimal> <>9__47_1;
		}

		// Token: 0x0200028E RID: 654
		[CompilerGenerated]
		private sealed class <>c__DisplayClass47_0
		{
			// Token: 0x06002245 RID: 8773 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass47_0()
			{
			}

			// Token: 0x06002246 RID: 8774 RVA: 0x00064448 File Offset: 0x00062648
			internal bool <StatusSumma>b__0(workshop r)
			{
				return r.state == this.st.Id;
			}

			// Token: 0x0400119F RID: 4511
			public WorkshopOptions st;
		}
	}
}
