using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Input;
using ASC.Common.Objects;
using ASC.ItemsSale;
using ASC.Models;
using ASC.Objects;
using ASC.Options;
using ASC.PartsRequest;
using ASC.RKO;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using ASC.ViewModels;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Xpf.Core.Serialization;
using DevExpress.Xpf.Grid;

namespace ASC.Salary
{
	// Token: 0x02000154 RID: 340
	public class SalaryViewModel : BaseViewModel
	{
		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x0600161D RID: 5661 RVA: 0x0003789C File Offset: 0x00035A9C
		// (set) Token: 0x0600161E RID: 5662 RVA: 0x000378B0 File Offset: 0x00035AB0
		public bool AdvanceVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<AdvanceVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<AdvanceVisible>k__BackingField == value)
				{
					return;
				}
				this.<AdvanceVisible>k__BackingField = value;
				this.RaisePropertyChanged("AdvanceVisible");
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x0600161F RID: 5663 RVA: 0x000378DC File Offset: 0x00035ADC
		// (set) Token: 0x06001620 RID: 5664 RVA: 0x000378F0 File Offset: 0x00035AF0
		public int SelectedTabIndex
		{
			get
			{
				return this._selectedTabIndex;
			}
			set
			{
				if (this._selectedTabIndex == value)
				{
					return;
				}
				this._selectedTabIndex = value;
				this.RaisePropertyChanged("SelectedTabIndex");
				this.PrintVisible = (value == 1);
				base.RaiseCanExecuteChanged(() => this.SaveAdditionalPayment());
				base.RaiseCanExecuteChanged(() => this.NewAdditionalPayment());
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06001621 RID: 5665 RVA: 0x0003799C File Offset: 0x00035B9C
		// (set) Token: 0x06001622 RID: 5666 RVA: 0x000379B0 File Offset: 0x00035BB0
		public bool CanChangeEmployee
		{
			[CompilerGenerated]
			get
			{
				return this.<CanChangeEmployee>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CanChangeEmployee>k__BackingField == value)
				{
					return;
				}
				this.<CanChangeEmployee>k__BackingField = value;
				this.RaisePropertyChanged("CanChangeEmployee");
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06001623 RID: 5667 RVA: 0x000379DC File Offset: 0x00035BDC
		// (set) Token: 0x06001624 RID: 5668 RVA: 0x000379F0 File Offset: 0x00035BF0
		public ObservableCollection<works> ItemWorks
		{
			[CompilerGenerated]
			get
			{
				return this.<ItemWorks>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ItemWorks>k__BackingField, value))
				{
					return;
				}
				this.<ItemWorks>k__BackingField = value;
				this.RaisePropertyChanged("ItemWorks");
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06001625 RID: 5669 RVA: 0x00037A20 File Offset: 0x00035C20
		// (set) Token: 0x06001626 RID: 5670 RVA: 0x00037A34 File Offset: 0x00035C34
		public ObservableCollection<store_int_reserve> ItemParts
		{
			[CompilerGenerated]
			get
			{
				return this.<ItemParts>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ItemParts>k__BackingField, value))
				{
					return;
				}
				this.<ItemParts>k__BackingField = value;
				this.RaisePropertyChanged("ItemParts");
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06001627 RID: 5671 RVA: 0x00037A64 File Offset: 0x00035C64
		// (set) Token: 0x06001628 RID: 5672 RVA: 0x00037A78 File Offset: 0x00035C78
		public store_int_reserve SelectedPartOutRepair
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedPartOutRepair>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedPartOutRepair>k__BackingField, value))
				{
					return;
				}
				this.<SelectedPartOutRepair>k__BackingField = value;
				this.RaisePropertyChanged("SelectedPartOutRepair");
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06001629 RID: 5673 RVA: 0x00037AA8 File Offset: 0x00035CA8
		// (set) Token: 0x0600162A RID: 5674 RVA: 0x00037ABC File Offset: 0x00035CBC
		public List<Warranty> WarrantyOptionses
		{
			[CompilerGenerated]
			get
			{
				return this.<WarrantyOptionses>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<WarrantyOptionses>k__BackingField, value))
				{
					return;
				}
				this.<WarrantyOptionses>k__BackingField = value;
				this.RaisePropertyChanged("WarrantyOptionses");
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x0600162B RID: 5675 RVA: 0x00037AEC File Offset: 0x00035CEC
		// (set) Token: 0x0600162C RID: 5676 RVA: 0x00037B00 File Offset: 0x00035D00
		public List<PaymentOptions> PaymentOptionses
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentOptionses>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<PaymentOptionses>k__BackingField, value))
				{
					return;
				}
				this.<PaymentOptionses>k__BackingField = value;
				this.RaisePropertyChanged("PaymentOptionses");
			}
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x0600162D RID: 5677 RVA: 0x00037B30 File Offset: 0x00035D30
		// (set) Token: 0x0600162E RID: 5678 RVA: 0x00037B44 File Offset: 0x00035D44
		public bool ReportLoaded
		{
			[CompilerGenerated]
			get
			{
				return this.<ReportLoaded>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ReportLoaded>k__BackingField == value)
				{
					return;
				}
				this.<ReportLoaded>k__BackingField = value;
				this.RaisePropertyChanged("ReportLoaded");
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x0600162F RID: 5679 RVA: 0x00037B70 File Offset: 0x00035D70
		// (set) Token: 0x06001630 RID: 5680 RVA: 0x00037B84 File Offset: 0x00035D84
		public string AdvanceNotes
		{
			[CompilerGenerated]
			get
			{
				return this.<AdvanceNotes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<AdvanceNotes>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<AdvanceNotes>k__BackingField = value;
				this.RaisePropertyChanged("AdvanceNotes");
			}
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x06001631 RID: 5681 RVA: 0x00037BB4 File Offset: 0x00035DB4
		// (set) Token: 0x06001632 RID: 5682 RVA: 0x00037BC8 File Offset: 0x00035DC8
		public DateTime Period
		{
			get
			{
				return this._period;
			}
			set
			{
				this._period = value;
				DateTime from = new DateTime(value.Year, value.Month, 1);
				DateTime to = from.AddMonths(1).AddDays(-1.0).AddHours(23.0).AddMinutes(59.0).AddSeconds(59.0);
				this._Period = new Period(from, to);
				this.RaisePropertyChanged("CanAdditionalPayment");
				this.RaisePropertyChanged("Period");
				this.AdvanceVisible = (DateTime.Now.Year == value.Year && DateTime.Now.Month == value.Month);
			}
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06001633 RID: 5683 RVA: 0x00037C98 File Offset: 0x00035E98
		public bool CanAdditionalPayment
		{
			get
			{
				DateTime period = this.Period;
				return this._localization != null && this.Period.Month == this._localization.Now.Month;
			}
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06001634 RID: 5684 RVA: 0x00037CDC File Offset: 0x00035EDC
		// (set) Token: 0x06001635 RID: 5685 RVA: 0x00037CF0 File Offset: 0x00035EF0
		public bool SaveAdditionalOk
		{
			[CompilerGenerated]
			get
			{
				return this.<SaveAdditionalOk>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SaveAdditionalOk>k__BackingField == value)
				{
					return;
				}
				this.<SaveAdditionalOk>k__BackingField = value;
				this.RaisePropertyChanged("SaveAdditionalOk");
			}
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06001636 RID: 5686 RVA: 0x00037D1C File Offset: 0x00035F1C
		// (set) Token: 0x06001637 RID: 5687 RVA: 0x00037D30 File Offset: 0x00035F30
		public bool SaveAdditionalErr
		{
			[CompilerGenerated]
			get
			{
				return this.<SaveAdditionalErr>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SaveAdditionalErr>k__BackingField == value)
				{
					return;
				}
				this.<SaveAdditionalErr>k__BackingField = value;
				this.RaisePropertyChanged("SaveAdditionalErr");
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06001638 RID: 5688 RVA: 0x00037D5C File Offset: 0x00035F5C
		// (set) Token: 0x06001639 RID: 5689 RVA: 0x00037D70 File Offset: 0x00035F70
		public decimal? NewSalaryRate
		{
			[CompilerGenerated]
			get
			{
				return this.<NewSalaryRate>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!Nullable.Equals<decimal>(this.<NewSalaryRate>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 228649638;
				IL_13:
				switch ((num ^ 1302517471) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					return;
				case 3:
					IL_32:
					this.<NewSalaryRate>k__BackingField = value;
					num = 204871589;
					goto IL_13;
				}
				this.RaisePropertyChanged("NewSalaryRate");
			}
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x0600163A RID: 5690 RVA: 0x00037DCC File Offset: 0x00035FCC
		// (set) Token: 0x0600163B RID: 5691 RVA: 0x00037DE0 File Offset: 0x00035FE0
		public ICommand RepairClickCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<RepairClickCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<RepairClickCommand>k__BackingField, value))
				{
					return;
				}
				this.<RepairClickCommand>k__BackingField = value;
				this.RaisePropertyChanged("RepairClickCommand");
			}
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x0600163C RID: 5692 RVA: 0x00037E10 File Offset: 0x00036010
		// (set) Token: 0x0600163D RID: 5693 RVA: 0x00037E24 File Offset: 0x00036024
		public RelayCommand PayAdvanceCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<PayAdvanceCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<PayAdvanceCommand>k__BackingField, value))
				{
					return;
				}
				this.<PayAdvanceCommand>k__BackingField = value;
				this.RaisePropertyChanged("PayAdvanceCommand");
			}
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x0600163E RID: 5694 RVA: 0x00037E54 File Offset: 0x00036054
		// (set) Token: 0x0600163F RID: 5695 RVA: 0x00037E68 File Offset: 0x00036068
		public RelayCommand Back2StoreCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<Back2StoreCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<Back2StoreCommand>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1419361270;
				IL_13:
				switch ((num ^ -1820511547) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					IL_32:
					this.<Back2StoreCommand>k__BackingField = value;
					num = -62217993;
					goto IL_13;
				case 3:
					return;
				}
				this.RaisePropertyChanged("Back2StoreCommand");
			}
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06001640 RID: 5696 RVA: 0x00037EC4 File Offset: 0x000360C4
		// (set) Token: 0x06001641 RID: 5697 RVA: 0x00037ED8 File Offset: 0x000360D8
		public ICommand PartDoubleClickCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<PartDoubleClickCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<PartDoubleClickCommand>k__BackingField, value))
				{
					return;
				}
				this.<PartDoubleClickCommand>k__BackingField = value;
				this.RaisePropertyChanged("PartDoubleClickCommand");
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06001642 RID: 5698 RVA: 0x00037F08 File Offset: 0x00036108
		// (set) Token: 0x06001643 RID: 5699 RVA: 0x00037F1C File Offset: 0x0003611C
		public ICommand AcceptedRepairClickCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<AcceptedRepairClickCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<AcceptedRepairClickCommand>k__BackingField, value))
				{
					return;
				}
				this.<AcceptedRepairClickCommand>k__BackingField = value;
				this.RaisePropertyChanged("AcceptedRepairClickCommand");
			}
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06001644 RID: 5700 RVA: 0x00037F4C File Offset: 0x0003614C
		// (set) Token: 0x06001645 RID: 5701 RVA: 0x00037F60 File Offset: 0x00036160
		public ICommand IssuedRepairClickCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<IssuedRepairClickCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<IssuedRepairClickCommand>k__BackingField, value))
				{
					return;
				}
				this.<IssuedRepairClickCommand>k__BackingField = value;
				this.RaisePropertyChanged("IssuedRepairClickCommand");
			}
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06001646 RID: 5702 RVA: 0x00037F90 File Offset: 0x00036190
		// (set) Token: 0x06001647 RID: 5703 RVA: 0x00037FA4 File Offset: 0x000361A4
		public RelayCommand PaySalaryCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<PaySalaryCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<PaySalaryCommand>k__BackingField, value))
				{
					return;
				}
				this.<PaySalaryCommand>k__BackingField = value;
				this.RaisePropertyChanged("PaySalaryCommand");
			}
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06001648 RID: 5704 RVA: 0x00037FD4 File Offset: 0x000361D4
		// (set) Token: 0x06001649 RID: 5705 RVA: 0x00037FE8 File Offset: 0x000361E8
		public RelayCommand SaleClickCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<SaleClickCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SaleClickCommand>k__BackingField, value))
				{
					return;
				}
				this.<SaleClickCommand>k__BackingField = value;
				this.RaisePropertyChanged("SaleClickCommand");
			}
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x0600164A RID: 5706 RVA: 0x00038018 File Offset: 0x00036218
		// (set) Token: 0x0600164B RID: 5707 RVA: 0x0003802C File Offset: 0x0003622C
		public RelayCommand SalaryRateChangeCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<SalaryRateChangeCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<SalaryRateChangeCommand>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 475993870;
				IL_13:
				switch ((num ^ 1584844747) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					return;
				case 2:
					IL_32:
					this.<SalaryRateChangeCommand>k__BackingField = value;
					num = 1270248012;
					goto IL_13;
				}
				this.RaisePropertyChanged("SalaryRateChangeCommand");
			}
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x0600164C RID: 5708 RVA: 0x00038088 File Offset: 0x00036288
		// (set) Token: 0x0600164D RID: 5709 RVA: 0x0003809C File Offset: 0x0003629C
		public RelayCommand InRepairSaleClickCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<InRepairSaleClickCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<InRepairSaleClickCommand>k__BackingField, value))
				{
					return;
				}
				this.<InRepairSaleClickCommand>k__BackingField = value;
				this.RaisePropertyChanged("InRepairSaleClickCommand");
			}
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x000380CC File Offset: 0x000362CC
		private void InitCommands()
		{
			this.RepairClickCommand = new RelayCommand(new Action<object>(this.RepairClick));
			this.PayAdvanceCommand = new RelayCommand(new Action<object>(this.PayAdvance), new Func<bool>(this.CanPayAdvance));
			this.Back2StoreCommand = new RelayCommand(new Action<object>(this.Back2Store), new Func<bool>(this.CanBack2Store));
			this.PaySalaryCommand = new RelayCommand(new Action<object>(this.PaySalary), new Func<bool>(this.CanSalaryPay));
			this.PartDoubleClickCommand = new RelayCommand(new Action<object>(this.PartDoubleClick));
			this.SaleClickCommand = new RelayCommand(new Action<object>(this.SaleClick));
			this.SalaryRateChangeCommand = new RelayCommand(new Action<object>(this.SalaryRateChange), new Func<bool>(this.CanSalaryPay));
			this.AcceptedRepairClickCommand = new RelayCommand(new Action<object>(this.AcceptedRepairClick));
			this.IssuedRepairClickCommand = new RelayCommand(new Action<object>(this.IssuedRepairClick));
			this.InRepairSaleClickCommand = new RelayCommand(new Action<object>(this.InRepairSaleClick));
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x000381F0 File Offset: 0x000363F0
		private bool CanSalaryPay()
		{
			return Auth.User != null && OfflineData.Instance.Employee.Can(16, 0);
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x00038218 File Offset: 0x00036418
		private bool CanAdditionalPay()
		{
			return Auth.User != null && OfflineData.Instance.Employee.Can(52, 0) && this.SelectedTabIndex == 2;
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x0003824C File Offset: 0x0003644C
		private bool CanBack2Store()
		{
			return this.MasterSelectedItem != null && this.MasterSelectedItem.state == 1;
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x00038274 File Offset: 0x00036474
		private bool CanPayAdvance()
		{
			return Auth.User != null && OfflineData.Instance.Employee.Can(48, 0);
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06001653 RID: 5715 RVA: 0x0003829C File Offset: 0x0003649C
		// (set) Token: 0x06001654 RID: 5716 RVA: 0x000382B0 File Offset: 0x000364B0
		public UserSalaryReport UserSalaryReport
		{
			[CompilerGenerated]
			get
			{
				return this.<UserSalaryReport>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<UserSalaryReport>k__BackingField, value))
				{
					return;
				}
				this.<UserSalaryReport>k__BackingField = value;
				this.RaisePropertyChanged("UserSalaryReport");
			}
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06001655 RID: 5717 RVA: 0x000382E0 File Offset: 0x000364E0
		// (set) Token: 0x06001656 RID: 5718 RVA: 0x000382F4 File Offset: 0x000364F4
		public ObservableCollection<store_int_reserve> PartsOnMaster
		{
			[CompilerGenerated]
			get
			{
				return this.<PartsOnMaster>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<PartsOnMaster>k__BackingField, value))
				{
					return;
				}
				this.<PartsOnMaster>k__BackingField = value;
				this.RaisePropertyChanged("PartsOnMaster");
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06001657 RID: 5719 RVA: 0x00038324 File Offset: 0x00036524
		// (set) Token: 0x06001658 RID: 5720 RVA: 0x00038338 File Offset: 0x00036538
		public store_int_reserve MasterSelectedItem
		{
			get
			{
				return this._masterSelectedItem;
			}
			set
			{
				if (object.Equals(this._masterSelectedItem, value))
				{
					return;
				}
				this._masterSelectedItem = value;
				this.RaisePropertyChanged("MasterSelectedItem");
				this.Back2StoreCommand.RaiseCanExecuteChanged();
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06001659 RID: 5721 RVA: 0x00038374 File Offset: 0x00036574
		// (set) Token: 0x0600165A RID: 5722 RVA: 0x00038388 File Offset: 0x00036588
		public CashOrdersLite SelectedOrder
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedOrder>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedOrder>k__BackingField, value))
				{
					return;
				}
				this.<SelectedOrder>k__BackingField = value;
				this.RaisePropertyChanged("SelectedOrder");
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x0600165B RID: 5723 RVA: 0x000383B8 File Offset: 0x000365B8
		// (set) Token: 0x0600165C RID: 5724 RVA: 0x000383CC File Offset: 0x000365CC
		public docs SelectedSale
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedSale>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedSale>k__BackingField, value))
				{
					return;
				}
				this.<SelectedSale>k__BackingField = value;
				this.RaisePropertyChanged("SelectedSale");
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x0600165D RID: 5725 RVA: 0x000383FC File Offset: 0x000365FC
		// (set) Token: 0x0600165E RID: 5726 RVA: 0x00038410 File Offset: 0x00036610
		public workshop SelectedAcceptedRepair
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedAcceptedRepair>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedAcceptedRepair>k__BackingField, value))
				{
					return;
				}
				this.<SelectedAcceptedRepair>k__BackingField = value;
				this.RaisePropertyChanged("SelectedAcceptedRepair");
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x0600165F RID: 5727 RVA: 0x00038440 File Offset: 0x00036640
		// (set) Token: 0x06001660 RID: 5728 RVA: 0x00038454 File Offset: 0x00036654
		public workshop SelectedIssuedRepair
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedIssuedRepair>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedIssuedRepair>k__BackingField, value))
				{
					return;
				}
				this.<SelectedIssuedRepair>k__BackingField = value;
				this.RaisePropertyChanged("SelectedIssuedRepair");
			}
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06001661 RID: 5729 RVA: 0x00038484 File Offset: 0x00036684
		// (set) Token: 0x06001662 RID: 5730 RVA: 0x00038498 File Offset: 0x00036698
		public store_int_reserve SelectedInRepairSale
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedInRepairSale>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedInRepairSale>k__BackingField, value))
				{
					return;
				}
				this.<SelectedInRepairSale>k__BackingField = value;
				this.RaisePropertyChanged("SelectedInRepairSale");
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06001663 RID: 5731 RVA: 0x000384C8 File Offset: 0x000366C8
		// (set) Token: 0x06001664 RID: 5732 RVA: 0x000384DC File Offset: 0x000366DC
		public int SelectedAdvancePaymentOption
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedAdvancePaymentOption>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedAdvancePaymentOption>k__BackingField == value)
				{
					return;
				}
				this.<SelectedAdvancePaymentOption>k__BackingField = value;
				this.RaisePropertyChanged("SelectedAdvancePaymentOption");
			}
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06001665 RID: 5733 RVA: 0x00038508 File Offset: 0x00036708
		// (set) Token: 0x06001666 RID: 5734 RVA: 0x0003851C File Offset: 0x0003671C
		public int SelectedSalaryPaymentOption
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedSalaryPaymentOption>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedSalaryPaymentOption>k__BackingField == value)
				{
					return;
				}
				this.<SelectedSalaryPaymentOption>k__BackingField = value;
				this.RaisePropertyChanged("SelectedSalaryPaymentOption");
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06001667 RID: 5735 RVA: 0x00038548 File Offset: 0x00036748
		// (set) Token: 0x06001668 RID: 5736 RVA: 0x0003855C File Offset: 0x0003675C
		public bool PrintVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<PrintVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PrintVisible>k__BackingField == value)
				{
					return;
				}
				this.<PrintVisible>k__BackingField = value;
				this.RaisePropertyChanged("PrintVisible");
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06001669 RID: 5737 RVA: 0x00038588 File Offset: 0x00036788
		// (set) Token: 0x0600166A RID: 5738 RVA: 0x0003859C File Offset: 0x0003679C
		public workshop SelectedRepair
		{
			get
			{
				return this._selectedRepair;
			}
			set
			{
				if (object.Equals(this._selectedRepair, value))
				{
					return;
				}
				this._selectedRepair = value;
				this.RaisePropertyChanged("SelectedRepair");
				if (value != null)
				{
					if (this.SelectedUser != null)
					{
						this.ItemWorks = new ObservableCollection<works>(this._model.LoadRepairWorks(value.id, this.SelectedUser.id));
					}
					this.ItemParts = new ObservableCollection<store_int_reserve>(this._model.LoadRepairParts(value.id, this.ItemWorks));
				}
			}
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x0600166B RID: 5739 RVA: 0x00038620 File Offset: 0x00036820
		// (set) Token: 0x0600166C RID: 5740 RVA: 0x00038634 File Offset: 0x00036834
		public bool AdvanceCorrect
		{
			[CompilerGenerated]
			get
			{
				return this.<AdvanceCorrect>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<AdvanceCorrect>k__BackingField == value)
				{
					return;
				}
				this.<AdvanceCorrect>k__BackingField = value;
				this.RaisePropertyChanged("AdvanceCorrect");
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x0600166D RID: 5741 RVA: 0x00038660 File Offset: 0x00036860
		// (set) Token: 0x0600166E RID: 5742 RVA: 0x00038674 File Offset: 0x00036874
		public bool SalaryCorrect
		{
			[CompilerGenerated]
			get
			{
				return this.<SalaryCorrect>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SalaryCorrect>k__BackingField == value)
				{
					return;
				}
				this.<SalaryCorrect>k__BackingField = value;
				this.RaisePropertyChanged("SalaryCorrect");
			}
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x0600166F RID: 5743 RVA: 0x000386A0 File Offset: 0x000368A0
		// (set) Token: 0x06001670 RID: 5744 RVA: 0x000386B4 File Offset: 0x000368B4
		public decimal AdvanceSumm
		{
			[CompilerGenerated]
			get
			{
				return this.<AdvanceSumm>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<AdvanceSumm>k__BackingField, value))
				{
					return;
				}
				this.<AdvanceSumm>k__BackingField = value;
				this.RaisePropertyChanged("AdvanceSumm");
			}
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06001671 RID: 5745 RVA: 0x000386E4 File Offset: 0x000368E4
		// (set) Token: 0x06001672 RID: 5746 RVA: 0x000386F8 File Offset: 0x000368F8
		public DateTime AdvanceDate
		{
			[CompilerGenerated]
			get
			{
				return this.<AdvanceDate>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (DateTime.Equals(this.<AdvanceDate>k__BackingField, value))
				{
					return;
				}
				this.<AdvanceDate>k__BackingField = value;
				this.RaisePropertyChanged("AdvanceDate");
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06001673 RID: 5747 RVA: 0x00038728 File Offset: 0x00036928
		// (set) Token: 0x06001674 RID: 5748 RVA: 0x0003873C File Offset: 0x0003693C
		public DateTime SalaryDate
		{
			[CompilerGenerated]
			get
			{
				return this.<SalaryDate>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!DateTime.Equals(this.<SalaryDate>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 374201711;
				IL_13:
				switch ((num ^ 130359920) % 4)
				{
				case 0:
					goto IL_0E;
				case 2:
					IL_32:
					this.<SalaryDate>k__BackingField = value;
					this.RaisePropertyChanged("SalaryDate");
					num = 2125397849;
					goto IL_13;
				case 3:
					return;
				}
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06001675 RID: 5749 RVA: 0x00038798 File Offset: 0x00036998
		// (set) Token: 0x06001676 RID: 5750 RVA: 0x000387AC File Offset: 0x000369AC
		public List<users> Users
		{
			[CompilerGenerated]
			get
			{
				return this.<Users>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Users>k__BackingField, value))
				{
					return;
				}
				this.<Users>k__BackingField = value;
				this.RaisePropertyChanged("Users");
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06001677 RID: 5751 RVA: 0x000387DC File Offset: 0x000369DC
		// (set) Token: 0x06001678 RID: 5752 RVA: 0x000387F0 File Offset: 0x000369F0
		public users SelectedUser
		{
			get
			{
				return this._selectedUser;
			}
			set
			{
				if (object.Equals(this._selectedUser, value))
				{
					return;
				}
				this._selectedUser = value;
				this.RaisePropertyChanged("SelectedUser");
				this.NewSalaryRate = null;
				this.ReportLoaded = false;
			}
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x00038834 File Offset: 0x00036A34
		public SalaryViewModel()
		{
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this.SetViewName("SalaryCount");
			this.CanChangeEmployee = (OfflineData.Instance.Employee.Can(52, 0) || OfflineData.Instance.Employee.Can(48, 0) || OfflineData.Instance.Employee.Can(12, 0));
			this.WarrantyOptionses = WarrantyOptions.GetAll();
			this.Period = this._localization.Now;
			this.LoadPaymentOptions();
			this.BgInit();
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x00038910 File Offset: 0x00036B10
		private void LoadPaymentOptions()
		{
			PaymentOptions paymentOptions = new PaymentOptions();
			this.PaymentOptionses = paymentOptions.GetAllOptions();
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x00038930 File Offset: 0x00036B30
		private void SaleClick(object obj)
		{
			if (this.SelectedSale != null)
			{
				goto IL_2C;
			}
			IL_08:
			int num = -1363593265;
			IL_0D:
			switch ((num ^ -454152720) % 4)
			{
			case 0:
				goto IL_08;
			case 2:
				IL_2C:
				this._navigationService.Navigate("ItemsSaleView", new ItemsSaleViewModel(this.SelectedSale.id));
				num = -780428835;
				goto IL_0D;
			case 3:
				return;
			}
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x00038994 File Offset: 0x00036B94
		private void PartDoubleClick(object obj)
		{
			if (this.SelectedPartOutRepair == null)
			{
				return;
			}
			this._navigationService.NavigateToStoreItem(this.SelectedPartOutRepair.item_id, 0);
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x000389C4 File Offset: 0x00036BC4
		private bool CheckSalaryFields()
		{
			if (this.SelectedUser.salary_disable)
			{
				this._toasterService.Info("Выплата ЗП запрещена администратором");
				return false;
			}
			if (!this.SalaryCorrect)
			{
				this._toasterService.Info(Lang.t("ConfirmData"));
				return false;
			}
			if (this.UserSalaryReport.FinalPaySumm <= 0m)
			{
				this._toasterService.Info(Lang.t("SalaryPayError"));
				return false;
			}
			DateTime dateTime = new DateTime(this._localization.Now.Year, this._localization.Now.Month, 1);
			DateTime t = dateTime.AddMonths(1);
			if (this._Period.To > t)
			{
				this._toasterService.Info(Lang.t("SalaryPayError2"));
				return false;
			}
			if (this.UserSalaryReport.NoSalaryRecords)
			{
				Period period = new Period(this.SelectedUser.created.Value, this._Period.To);
				if (this._model.LoadUserReport(this.SelectedUser, period, this.NewSalaryRate).PaySumm != this.UserSalaryReport.PaySumm && !this.NewEmployee())
				{
					this._toasterService.Error("Есть невыплаченные средства в предыдущем периоде, выплата за выбранный период не возможна");
					return false;
				}
			}
			if (!this.UserSalaryReport.NoSalaryRecords && this.UserSalaryReport.LastSalary.period_from >= this._Period.From && this.UserSalaryReport.LastSalary.period_to <= this._Period.To)
			{
				this._toasterService.Error("Выплата ЗП за выбранный период уже была произведена, повторная выплата не возможна");
				return false;
			}
			return true;
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x00038B80 File Offset: 0x00036D80
		private bool NewEmployee()
		{
			return this.SelectedUser.created.Value.Date.Year == this._Period.From.Date.Year && this.SelectedUser.created.Value.Month == this._Period.From.Date.Month;
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x00038C08 File Offset: 0x00036E08
		private void PaySalary(object obj)
		{
			SalaryViewModel.<PaySalary>d__190 <PaySalary>d__;
			<PaySalary>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<PaySalary>d__.<>4__this = this;
			<PaySalary>d__.<>1__state = -1;
			<PaySalary>d__.<>t__builder.Start<SalaryViewModel.<PaySalary>d__190>(ref <PaySalary>d__);
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x00038C40 File Offset: 0x00036E40
		private void SalaryRateChange(object obj)
		{
			this.UserSalaryReport = this._model.LoadUserReport(this.SelectedUser, this._Period, this.NewSalaryRate);
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x00038C70 File Offset: 0x00036E70
		private bool CheckAdditionalPaymentFields(bool newItem = false)
		{
			if (!newItem && !this.UserSalaryReport.AdditionalPayments.Any<additional_payments>())
			{
				return false;
			}
			foreach (additional_payments additional_payments in (from i in this.UserSalaryReport.AdditionalPayments
			where i.id == 0
			select i).ToList<additional_payments>())
			{
				if (string.IsNullOrEmpty(additional_payments.name) || additional_payments.price == 0m)
				{
					this._toasterService.Error(Lang.t("ItemError"));
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x00038D40 File Offset: 0x00036F40
		[Command]
		public void SaveAdditionalPayment()
		{
			if (!this.CheckAdditionalPaymentFields(false))
			{
				return;
			}
			bool response;
			if (response = this._model.SaveAdditionalPayments(this.UserSalaryReport.AdditionalPayments, this.SelectedUser.id))
			{
				this.LoadReport();
			}
			base.ShowActionResponse(response, "");
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x00038D90 File Offset: 0x00036F90
		public bool CanSaveAdditionalPayment()
		{
			return this.CanAdditionalPay();
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x00038DA4 File Offset: 0x00036FA4
		[Command]
		public void NewAdditionalPayment()
		{
			if (!this.CheckAdditionalPaymentFields(true))
			{
				return;
			}
			this.UserSalaryReport.AdditionalPayments.Add(new additional_payments
			{
				payment_date = DateTime.UtcNow
			});
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x00038DDC File Offset: 0x00036FDC
		public bool CanNewAdditionalPayment()
		{
			return this.CanAdditionalPay() && this.CanAdditionalPayment && this.SelectedTabIndex == 2;
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x00038E04 File Offset: 0x00037004
		private void Back2Store(object obj)
		{
			this._toasterService.Error("TODO");
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x00038E24 File Offset: 0x00037024
		private bool CheckAdvanceFields()
		{
			if (this.SelectedUser.advance_disable)
			{
				this._toasterService.Info("Выплата аванса запрещена администратором");
				return false;
			}
			if (!this.AdvanceCorrect || this.AdvanceSumm <= 0m)
			{
				this._toasterService.Info(Lang.t("ConfirmData"));
				return false;
			}
			if (string.IsNullOrEmpty(this.AdvanceNotes))
			{
				this._toasterService.Info(Lang.t("NotesCantBeEmpty"));
				return false;
			}
			return true;
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x00038EA8 File Offset: 0x000370A8
		private void PayAdvance(object obj)
		{
			if (!this.CheckAdvanceFields())
			{
				return;
			}
			try
			{
				int orderId = this._model.MakeAdvance(this.SelectedUser.id, this.AdvanceSumm, this.SelectedAdvancePaymentOption, this.AdvanceNotes, this.AdvanceDate);
				this.AdvanceSumm = 0m;
				this._toasterService.Success("");
				this.LoadReport();
				this._navigationService.Navigate("RkoView", new RkoViewModel(orderId));
			}
			catch (Exception ex)
			{
				this._toasterService.Error(ex.Message);
			}
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x00038F4C File Offset: 0x0003714C
		private void LoadUsesData(users user)
		{
			if (user != null)
			{
				goto IL_27;
			}
			IL_03:
			int num = 734191442;
			IL_08:
			switch ((num ^ 341725112) % 4)
			{
			case 1:
				IL_27:
				this.PartsOnMaster = new ObservableCollection<store_int_reserve>(this._model.LoadMasterItems(user.id));
				this.UserSalaryReport = this._model.LoadUserReport(user, this._Period, this.NewSalaryRate);
				num = 1922047724;
				goto IL_08;
			case 2:
				return;
			case 3:
				goto IL_03;
			}
			this.NewSalaryRate = new decimal?(this.UserSalaryReport.MonthSalary);
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x00038FD8 File Offset: 0x000371D8
		private void RepairClick(object obj)
		{
			if (this.SelectedRepair != null)
			{
				goto IL_2C;
			}
			IL_08:
			int num = -196911423;
			IL_0D:
			switch ((num ^ -2068105556) % 4)
			{
			case 0:
				IL_2C:
				this._navigationService.NavigateRepairCard(this.SelectedRepair.id);
				num = -1913725582;
				goto IL_0D;
			case 1:
				return;
			case 3:
				goto IL_08;
			}
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x00039030 File Offset: 0x00037230
		[Command]
		public void MasterItemClick()
		{
			if (this.MasterSelectedItem != null)
			{
				goto IL_2C;
			}
			IL_08:
			int num = -416230752;
			IL_0D:
			switch ((num ^ -1769222487) % 4)
			{
			case 0:
				goto IL_08;
			case 1:
				return;
			case 3:
				IL_2C:
				this._navigationService.Navigate("PartsRequestView", new PartsRequestViewModel(this.MasterSelectedItem.id));
				num = -551794437;
				goto IL_0D;
			}
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x00039094 File Offset: 0x00037294
		private bool CheckFields()
		{
			if (this.SelectedUser == null)
			{
				this._toasterService.Info(Lang.t("SelectCoWorker"));
				return false;
			}
			return true;
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x000390C4 File Offset: 0x000372C4
		[Command]
		public void LoadReport()
		{
			if (!this.CheckFields())
			{
				return;
			}
			base.ShowWait();
			this.SelectedRepair = null;
			this.NewSalaryRate = null;
			this.SalaryCorrect = false;
			this.AdvanceCorrect = false;
			this.ItemParts = new ObservableCollection<store_int_reserve>();
			this.ItemWorks = new ObservableCollection<works>();
			Task.Run(delegate()
			{
				this.LoadUsesData(this.SelectedUser);
			}).ContinueWith(delegate(Task t)
			{
				this.ReportLoaded = true;
				this.AdvanceDate = this._localization.Now;
				this.SalaryDate = this._localization.Now;
				this.RefreshFields();
				base.HideWait();
				base.ShowActionResponse(true, Lang.t("ReportLoaded"));
			}, TaskScheduler.FromCurrentSynchronizationContext());
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x00039144 File Offset: 0x00037344
		private void BgInit()
		{
			SalaryViewModel.<BgInit>d__205 <BgInit>d__;
			<BgInit>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<BgInit>d__.<>4__this = this;
			<BgInit>d__.<>1__state = -1;
			<BgInit>d__.<>t__builder.Start<SalaryViewModel.<BgInit>d__205>(ref <BgInit>d__);
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x0003917C File Offset: 0x0003737C
		private void IssuedRepairClick(object obj)
		{
			if (this.SelectedIssuedRepair == null)
			{
				return;
			}
			this._navigationService.NavigateRepairCard(this.SelectedIssuedRepair.id);
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x000391A8 File Offset: 0x000373A8
		private void AcceptedRepairClick(object obj)
		{
			if (this.SelectedAcceptedRepair != null)
			{
				goto IL_2C;
			}
			IL_08:
			int num = -1488701779;
			IL_0D:
			switch ((num ^ -935033660) % 4)
			{
			case 0:
				IL_2C:
				this._navigationService.NavigateRepairCard(this.SelectedAcceptedRepair.id);
				num = -82650665;
				goto IL_0D;
			case 1:
				return;
			case 2:
				goto IL_08;
			}
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x00039200 File Offset: 0x00037400
		private void InRepairSaleClick(object obj)
		{
			if (this.SelectedInRepairSale == null)
			{
				return;
			}
			this._navigationService.Navigate("PartsRequestView", new PartsRequestViewModel(this.SelectedInRepairSale.id));
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x00039238 File Offset: 0x00037438
		private void RefreshFields()
		{
			base.RaisePropertyChanged<bool>(() => this.CanAdditionalPayment);
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x0003927C File Offset: 0x0003747C
		[Command]
		public void OnAllowPropertyAdditionalPayments(AllowPropertyEventArgs e)
		{
			if (e.Property.Name == "TotalSummary")
			{
				e.Allow = false;
			}
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x000392A8 File Offset: 0x000374A8
		public void SetSelectedEmployee(int employeeId)
		{
			this.SelectedUser = this.Users.FirstOrDefault((users u) => u.id == employeeId);
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x000392E0 File Offset: 0x000374E0
		[Command]
		public void RepairsCustomUnboundColumnData(GridColumnDataEventArgs e)
		{
			if (e.IsGetData && e.Column.FieldName.Equals("Percent"))
			{
				e.Value = (Convert.ToBoolean(e.GetListSourceFieldValue("IsQuick")) ? this.SelectedUser.pay_repair_quick : this.SelectedUser.pay_repair);
			}
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x00039344 File Offset: 0x00037544
		public bool CanRepairsCustomUnboundColumnData(GridColumnDataEventArgs e)
		{
			return this.SelectedUser != null;
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x0003935C File Offset: 0x0003755C
		[CompilerGenerated]
		private void <LoadReport>b__204_0()
		{
			this.LoadUsesData(this.SelectedUser);
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x00039378 File Offset: 0x00037578
		[CompilerGenerated]
		private void <LoadReport>b__204_1(Task t)
		{
			this.ReportLoaded = true;
			this.AdvanceDate = this._localization.Now;
			this.SalaryDate = this._localization.Now;
			this.RefreshFields();
			base.HideWait();
			base.ShowActionResponse(true, Lang.t("ReportLoaded"));
		}

		// Token: 0x04000AE9 RID: 2793
		private readonly IToasterService _toasterService;

		// Token: 0x04000AEA RID: 2794
		private SalaryModel _model = new SalaryModel();

		// Token: 0x04000AEB RID: 2795
		private store_int_reserve _masterSelectedItem;

		// Token: 0x04000AEC RID: 2796
		private workshop _selectedRepair;

		// Token: 0x04000AED RID: 2797
		private readonly Localization _localization = new Localization("UTC");

		// Token: 0x04000AEE RID: 2798
		[CompilerGenerated]
		private bool <AdvanceVisible>k__BackingField = true;

		// Token: 0x04000AEF RID: 2799
		[CompilerGenerated]
		private bool <CanChangeEmployee>k__BackingField;

		// Token: 0x04000AF0 RID: 2800
		[CompilerGenerated]
		private ObservableCollection<works> <ItemWorks>k__BackingField;

		// Token: 0x04000AF1 RID: 2801
		[CompilerGenerated]
		private ObservableCollection<store_int_reserve> <ItemParts>k__BackingField;

		// Token: 0x04000AF2 RID: 2802
		[CompilerGenerated]
		private store_int_reserve <SelectedPartOutRepair>k__BackingField;

		// Token: 0x04000AF3 RID: 2803
		[CompilerGenerated]
		private List<Warranty> <WarrantyOptionses>k__BackingField;

		// Token: 0x04000AF4 RID: 2804
		[CompilerGenerated]
		private List<PaymentOptions> <PaymentOptionses>k__BackingField;

		// Token: 0x04000AF5 RID: 2805
		[CompilerGenerated]
		private bool <ReportLoaded>k__BackingField;

		// Token: 0x04000AF6 RID: 2806
		[CompilerGenerated]
		private string <AdvanceNotes>k__BackingField = Lang.t("PayAdvance");

		// Token: 0x04000AF7 RID: 2807
		private Period _Period;

		// Token: 0x04000AF8 RID: 2808
		private DateTime _period;

		// Token: 0x04000AF9 RID: 2809
		private users _selectedUser;

		// Token: 0x04000AFA RID: 2810
		private int _selectedTabIndex;

		// Token: 0x04000AFB RID: 2811
		private readonly INavigationService _navigationService;

		// Token: 0x04000AFC RID: 2812
		[CompilerGenerated]
		private bool <SaveAdditionalOk>k__BackingField;

		// Token: 0x04000AFD RID: 2813
		[CompilerGenerated]
		private bool <SaveAdditionalErr>k__BackingField;

		// Token: 0x04000AFE RID: 2814
		[CompilerGenerated]
		private decimal? <NewSalaryRate>k__BackingField;

		// Token: 0x04000AFF RID: 2815
		[CompilerGenerated]
		private ICommand <RepairClickCommand>k__BackingField;

		// Token: 0x04000B00 RID: 2816
		[CompilerGenerated]
		private RelayCommand <PayAdvanceCommand>k__BackingField;

		// Token: 0x04000B01 RID: 2817
		[CompilerGenerated]
		private RelayCommand <Back2StoreCommand>k__BackingField;

		// Token: 0x04000B02 RID: 2818
		[CompilerGenerated]
		private ICommand <PartDoubleClickCommand>k__BackingField;

		// Token: 0x04000B03 RID: 2819
		[CompilerGenerated]
		private ICommand <AcceptedRepairClickCommand>k__BackingField;

		// Token: 0x04000B04 RID: 2820
		[CompilerGenerated]
		private ICommand <IssuedRepairClickCommand>k__BackingField;

		// Token: 0x04000B05 RID: 2821
		[CompilerGenerated]
		private RelayCommand <PaySalaryCommand>k__BackingField;

		// Token: 0x04000B06 RID: 2822
		[CompilerGenerated]
		private RelayCommand <SaleClickCommand>k__BackingField;

		// Token: 0x04000B07 RID: 2823
		[CompilerGenerated]
		private RelayCommand <SalaryRateChangeCommand>k__BackingField;

		// Token: 0x04000B08 RID: 2824
		[CompilerGenerated]
		private RelayCommand <InRepairSaleClickCommand>k__BackingField;

		// Token: 0x04000B09 RID: 2825
		[CompilerGenerated]
		private UserSalaryReport <UserSalaryReport>k__BackingField;

		// Token: 0x04000B0A RID: 2826
		[CompilerGenerated]
		private ObservableCollection<store_int_reserve> <PartsOnMaster>k__BackingField;

		// Token: 0x04000B0B RID: 2827
		[CompilerGenerated]
		private CashOrdersLite <SelectedOrder>k__BackingField;

		// Token: 0x04000B0C RID: 2828
		[CompilerGenerated]
		private docs <SelectedSale>k__BackingField;

		// Token: 0x04000B0D RID: 2829
		[CompilerGenerated]
		private workshop <SelectedAcceptedRepair>k__BackingField;

		// Token: 0x04000B0E RID: 2830
		[CompilerGenerated]
		private workshop <SelectedIssuedRepair>k__BackingField;

		// Token: 0x04000B0F RID: 2831
		[CompilerGenerated]
		private store_int_reserve <SelectedInRepairSale>k__BackingField;

		// Token: 0x04000B10 RID: 2832
		[CompilerGenerated]
		private int <SelectedAdvancePaymentOption>k__BackingField;

		// Token: 0x04000B11 RID: 2833
		[CompilerGenerated]
		private int <SelectedSalaryPaymentOption>k__BackingField;

		// Token: 0x04000B12 RID: 2834
		[CompilerGenerated]
		private bool <PrintVisible>k__BackingField;

		// Token: 0x04000B13 RID: 2835
		[CompilerGenerated]
		private bool <AdvanceCorrect>k__BackingField;

		// Token: 0x04000B14 RID: 2836
		[CompilerGenerated]
		private bool <SalaryCorrect>k__BackingField;

		// Token: 0x04000B15 RID: 2837
		[CompilerGenerated]
		private decimal <AdvanceSumm>k__BackingField;

		// Token: 0x04000B16 RID: 2838
		[CompilerGenerated]
		private DateTime <AdvanceDate>k__BackingField;

		// Token: 0x04000B17 RID: 2839
		[CompilerGenerated]
		private DateTime <SalaryDate>k__BackingField;

		// Token: 0x04000B18 RID: 2840
		[CompilerGenerated]
		private List<users> <Users>k__BackingField;

		// Token: 0x02000155 RID: 341
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <PaySalary>d__190 : IAsyncStateMachine
		{
			// Token: 0x06001699 RID: 5785 RVA: 0x000393CC File Offset: 0x000375CC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				SalaryViewModel salaryViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						if (!salaryViewModel.CheckSalaryFields())
						{
							goto IL_105;
						}
						salaryViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter<int> awaiter;
						if (num != 0)
						{
							awaiter = salaryViewModel._model.MakeSalaryPayment(salaryViewModel.SelectedUser.id, salaryViewModel.UserSalaryReport, salaryViewModel._Period, salaryViewModel.SelectedSalaryPaymentOption, salaryViewModel.SalaryDate).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, SalaryViewModel.<PaySalary>d__190>(ref awaiter, ref this);
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
						awaiter.GetResult();
						salaryViewModel._toasterService.Success(Lang.t("PaymentComplete"));
						salaryViewModel.LoadReport();
					}
					catch (Exception ex)
					{
						salaryViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							salaryViewModel.HideWait();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_105:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x0600169A RID: 5786 RVA: 0x0003951C File Offset: 0x0003771C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000B19 RID: 2841
			public int <>1__state;

			// Token: 0x04000B1A RID: 2842
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000B1B RID: 2843
			public SalaryViewModel <>4__this;

			// Token: 0x04000B1C RID: 2844
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x02000156 RID: 342
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600169B RID: 5787 RVA: 0x00039538 File Offset: 0x00037738
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600169C RID: 5788 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x0600169D RID: 5789 RVA: 0x000375E4 File Offset: 0x000357E4
			internal bool <CheckAdditionalPaymentFields>b__192_0(additional_payments i)
			{
				return i.id == 0;
			}

			// Token: 0x0600169E RID: 5790 RVA: 0x00039550 File Offset: 0x00037750
			internal bool <BgInit>b__205_0(users u)
			{
				return u.id == Auth.User.id;
			}

			// Token: 0x04000B1D RID: 2845
			public static readonly SalaryViewModel.<>c <>9 = new SalaryViewModel.<>c();

			// Token: 0x04000B1E RID: 2846
			public static Func<additional_payments, bool> <>9__192_0;

			// Token: 0x04000B1F RID: 2847
			public static Func<users, bool> <>9__205_0;
		}

		// Token: 0x02000157 RID: 343
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <BgInit>d__205 : IAsyncStateMachine
		{
			// Token: 0x0600169F RID: 5791 RVA: 0x00039570 File Offset: 0x00037770
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				SalaryViewModel salaryViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<users>> awaiter;
					if (num != 0)
					{
						awaiter = UsersModel.LoadUsers(false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<users>>, SalaryViewModel.<BgInit>d__205>(ref awaiter, ref this);
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
					salaryViewModel.Users = result;
					users users = salaryViewModel.Users.FirstOrDefault(new Func<users, bool>(SalaryViewModel.<>c.<>9.<BgInit>b__205_0));
					salaryViewModel.InitCommands();
					if (users != null)
					{
						if (Auth.User != null && !OfflineData.Instance.Employee.Can(12, 0))
						{
							salaryViewModel.SelectedUser = users;
						}
						if (salaryViewModel.SelectedUser == null)
						{
							salaryViewModel.SelectedUser = users;
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

			// Token: 0x060016A0 RID: 5792 RVA: 0x0003969C File Offset: 0x0003789C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000B20 RID: 2848
			public int <>1__state;

			// Token: 0x04000B21 RID: 2849
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000B22 RID: 2850
			public SalaryViewModel <>4__this;

			// Token: 0x04000B23 RID: 2851
			private TaskAwaiter<List<users>> <>u__1;
		}

		// Token: 0x02000158 RID: 344
		[CompilerGenerated]
		private sealed class <>c__DisplayClass211_0
		{
			// Token: 0x060016A1 RID: 5793 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass211_0()
			{
			}

			// Token: 0x060016A2 RID: 5794 RVA: 0x000396B8 File Offset: 0x000378B8
			internal bool <SetSelectedEmployee>b__0(users u)
			{
				return u.id == this.employeeId;
			}

			// Token: 0x04000B24 RID: 2852
			public int employeeId;
		}
	}
}
