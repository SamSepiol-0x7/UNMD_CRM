using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using ASC.Common.Interfaces;
using ASC.Extensions.Pinpad;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Options;
using ASC.Properties;
using ASC.RepairCard;
using ASC.RepairCard.WorksAndParts;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using ASC.View;
using ASC.ViewModels;
using ASC.Workspace.Repairs;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Xpf.Editors;
using DevExpress.XtraReports.UI;

namespace ASC.NewRepair
{
	// Token: 0x02000190 RID: 400
	public class NewRepairViewModel : AcceptNewViewModelBase, IVendorSelect, IImagesEdit, IRepairSelect, ICustomerSelect
	{
		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x060017EF RID: 6127 RVA: 0x0003FD44 File Offset: 0x0003DF44
		// (set) Token: 0x060017F0 RID: 6128 RVA: 0x0003FD58 File Offset: 0x0003DF58
		private ClientsModel _customerModel
		{
			[CompilerGenerated]
			get
			{
				return this.<_customerModel>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<_customerModel>k__BackingField, value))
				{
					return;
				}
				this.<_customerModel>k__BackingField = value;
				this.RaisePropertyChanged("_customerModel");
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x060017F1 RID: 6129 RVA: 0x0003FD88 File Offset: 0x0003DF88
		// (set) Token: 0x060017F2 RID: 6130 RVA: 0x0003FD9C File Offset: 0x0003DF9C
		public workshop Repair
		{
			[CompilerGenerated]
			get
			{
				return this.<Repair>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Repair>k__BackingField, value))
				{
					return;
				}
				this.<Repair>k__BackingField = value;
				this.RaisePropertyChanged("Repair");
			}
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x060017F3 RID: 6131 RVA: 0x0003FDCC File Offset: 0x0003DFCC
		// (set) Token: 0x060017F4 RID: 6132 RVA: 0x0003FDE0 File Offset: 0x0003DFE0
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

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x060017F5 RID: 6133 RVA: 0x0003FE10 File Offset: 0x0003E010
		// (set) Token: 0x060017F6 RID: 6134 RVA: 0x0003FE24 File Offset: 0x0003E024
		public List<IPrepaidType> PrePaidTypes
		{
			[CompilerGenerated]
			get
			{
				return this.<PrePaidTypes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<PrePaidTypes>k__BackingField, value))
				{
					return;
				}
				this.<PrePaidTypes>k__BackingField = value;
				this.RaisePropertyChanged("PrePaidTypes");
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x060017F7 RID: 6135 RVA: 0x0003FE54 File Offset: 0x0003E054
		// (set) Token: 0x060017F8 RID: 6136 RVA: 0x0003FE68 File Offset: 0x0003E068
		public ObservableCollection<device_models> MakerModels
		{
			[CompilerGenerated]
			get
			{
				return this.<MakerModels>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<MakerModels>k__BackingField, value))
				{
					return;
				}
				this.<MakerModels>k__BackingField = value;
				this.RaisePropertyChanged("MakerModels");
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x060017F9 RID: 6137 RVA: 0x0003FE98 File Offset: 0x0003E098
		// (set) Token: 0x060017FA RID: 6138 RVA: 0x0003FEAC File Offset: 0x0003E0AC
		public int StickerCount
		{
			[CompilerGenerated]
			get
			{
				return this.<StickerCount>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<StickerCount>k__BackingField == value)
				{
					return;
				}
				this.<StickerCount>k__BackingField = value;
				this.RaisePropertyChanged("StickerCount");
			}
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x060017FB RID: 6139 RVA: 0x0003FED8 File Offset: 0x0003E0D8
		// (set) Token: 0x060017FC RID: 6140 RVA: 0x0003FEEC File Offset: 0x0003E0EC
		public WpExpressViewModel WPExpress
		{
			[CompilerGenerated]
			get
			{
				return this.<WPExpress>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<WPExpress>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 2147210546;
				IL_13:
				switch ((num ^ 183162732) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					IL_32:
					this.<WPExpress>k__BackingField = value;
					num = 259993415;
					goto IL_13;
				case 2:
					return;
				}
				this.RaisePropertyChanged("WPExpress");
			}
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x060017FD RID: 6141 RVA: 0x0003FF48 File Offset: 0x0003E148
		public bool ValidateMaker
		{
			get
			{
				return !Auth.Config.manual_maker;
			}
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x060017FE RID: 6142 RVA: 0x0003FF64 File Offset: 0x0003E164
		public bool AllowQuickRepair
		{
			get
			{
				return OfflineData.Instance.Employee.Can(73, 0);
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x060017FF RID: 6143 RVA: 0x0003FF84 File Offset: 0x0003E184
		public bool OfficeReadOnly
		{
			get
			{
				return !OfflineData.Instance.Employee.Can(72, 0);
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06001800 RID: 6144 RVA: 0x0003FFA8 File Offset: 0x0003E1A8
		// (set) Token: 0x06001801 RID: 6145 RVA: 0x0003FFBC File Offset: 0x0003E1BC
		public bool DeviceMatchFound
		{
			[CompilerGenerated]
			get
			{
				return this.<DeviceMatchFound>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<DeviceMatchFound>k__BackingField == value)
				{
					return;
				}
				this.<DeviceMatchFound>k__BackingField = value;
				this.RaisePropertyChanged("DeviceMatchFound");
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06001802 RID: 6146 RVA: 0x0003FFE8 File Offset: 0x0003E1E8
		// (set) Token: 0x06001803 RID: 6147 RVA: 0x0003FFFC File Offset: 0x0003E1FC
		public bool DeviceMatchVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<DeviceMatchVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<DeviceMatchVisible>k__BackingField == value)
				{
					return;
				}
				this.<DeviceMatchVisible>k__BackingField = value;
				this.RaisePropertyChanged("DeviceMatchVisible");
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06001804 RID: 6148 RVA: 0x00040028 File Offset: 0x0003E228
		// (set) Token: 0x06001805 RID: 6149 RVA: 0x0004003C File Offset: 0x0003E23C
		public bool PayCheck
		{
			[CompilerGenerated]
			get
			{
				return this.<PayCheck>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PayCheck>k__BackingField == value)
				{
					return;
				}
				this.<PayCheck>k__BackingField = value;
				this.RaisePropertyChanged("PayCheck");
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06001806 RID: 6150 RVA: 0x00040068 File Offset: 0x0003E268
		// (set) Token: 0x06001807 RID: 6151 RVA: 0x0004007C File Offset: 0x0003E27C
		public bool ExtEarlyVis
		{
			[CompilerGenerated]
			get
			{
				return this.<ExtEarlyVis>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ExtEarlyVis>k__BackingField == value)
				{
					return;
				}
				this.<ExtEarlyVis>k__BackingField = value;
				this.RaisePropertyChanged("ExtEarlyVis");
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06001808 RID: 6152 RVA: 0x000400A8 File Offset: 0x0003E2A8
		// (set) Token: 0x06001809 RID: 6153 RVA: 0x000400BC File Offset: 0x0003E2BC
		public decimal TotalAmount
		{
			[CompilerGenerated]
			get
			{
				return this.<TotalAmount>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<TotalAmount>k__BackingField, value))
				{
					return;
				}
				this.<TotalAmount>k__BackingField = value;
				this.RaisePropertyChanged("TotalAmount");
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x0600180A RID: 6154 RVA: 0x000400EC File Offset: 0x0003E2EC
		// (set) Token: 0x0600180B RID: 6155 RVA: 0x00040100 File Offset: 0x0003E300
		public bool PrintCheque
		{
			[CompilerGenerated]
			get
			{
				return this.<PrintCheque>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PrintCheque>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -1706292165;
				IL_10:
				switch ((num ^ -1908897032) % 4)
				{
				case 0:
					goto IL_0B;
				case 2:
					IL_2F:
					this.<PrintCheque>k__BackingField = value;
					this.RaisePropertyChanged("PrintCheque");
					num = -1890331635;
					goto IL_10;
				case 3:
					return;
				}
			}
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x0600180C RID: 6156 RVA: 0x00040158 File Offset: 0x0003E358
		// (set) Token: 0x0600180D RID: 6157 RVA: 0x0004016C File Offset: 0x0003E36C
		public ICommand MakersChangedCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<MakersChangedCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<MakersChangedCommand>k__BackingField, value))
				{
					return;
				}
				this.<MakersChangedCommand>k__BackingField = value;
				this.RaisePropertyChanged("MakersChangedCommand");
			}
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x0600180E RID: 6158 RVA: 0x0004019C File Offset: 0x0003E39C
		// (set) Token: 0x0600180F RID: 6159 RVA: 0x000401B0 File Offset: 0x0003E3B0
		public ICommand SerialNumberChangedCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<SerialNumberChangedCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SerialNumberChangedCommand>k__BackingField, value))
				{
					return;
				}
				this.<SerialNumberChangedCommand>k__BackingField = value;
				this.RaisePropertyChanged("SerialNumberChangedCommand");
			}
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06001810 RID: 6160 RVA: 0x000401E0 File Offset: 0x0003E3E0
		// (set) Token: 0x06001811 RID: 6161 RVA: 0x000401F4 File Offset: 0x0003E3F4
		public ICommand CompanySelectionChangedCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<CompanySelectionChangedCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<CompanySelectionChangedCommand>k__BackingField, value))
				{
					return;
				}
				this.<CompanySelectionChangedCommand>k__BackingField = value;
				this.RaisePropertyChanged("CompanySelectionChangedCommand");
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06001812 RID: 6162 RVA: 0x00040224 File Offset: 0x0003E424
		// (set) Token: 0x06001813 RID: 6163 RVA: 0x00040238 File Offset: 0x0003E438
		public ICommand NewModelInputCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<NewModelInputCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<NewModelInputCommand>k__BackingField, value))
				{
					return;
				}
				this.<NewModelInputCommand>k__BackingField = value;
				this.RaisePropertyChanged("NewModelInputCommand");
			}
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06001814 RID: 6164 RVA: 0x00040268 File Offset: 0x0003E468
		// (set) Token: 0x06001815 RID: 6165 RVA: 0x0004027C File Offset: 0x0003E47C
		public ICommand SelectEarlyRepairCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectEarlyRepairCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectEarlyRepairCommand>k__BackingField, value))
				{
					return;
				}
				this.<SelectEarlyRepairCommand>k__BackingField = value;
				this.RaisePropertyChanged("SelectEarlyRepairCommand");
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06001816 RID: 6166 RVA: 0x000402AC File Offset: 0x0003E4AC
		// (set) Token: 0x06001817 RID: 6167 RVA: 0x000402C0 File Offset: 0x0003E4C0
		public ICommand OpenRepairCardCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<OpenRepairCardCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<OpenRepairCardCommand>k__BackingField, value))
				{
					return;
				}
				this.<OpenRepairCardCommand>k__BackingField = value;
				this.RaisePropertyChanged("OpenRepairCardCommand");
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06001818 RID: 6168 RVA: 0x000402F0 File Offset: 0x0003E4F0
		// (set) Token: 0x06001819 RID: 6169 RVA: 0x00040304 File Offset: 0x0003E504
		public ICommand ClosingCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<ClosingCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ClosingCommand>k__BackingField, value))
				{
					return;
				}
				this.<ClosingCommand>k__BackingField = value;
				this.RaisePropertyChanged("ClosingCommand");
			}
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x00040334 File Offset: 0x0003E534
		private void InitCommands()
		{
			this.MakersChangedCommand = new RelayCommand(new Action<object>(this.MakersChanged));
			this.SerialNumberChangedCommand = new RelayCommand(new Action<object>(this.SerialNumberChanged));
			this.CompanySelectionChangedCommand = new RelayCommand(new Action<object>(this.CompanySelectionChanged));
			this.NewModelInputCommand = new RelayCommand(new Action<object>(this.NewModelInput));
			this.SelectEarlyRepairCommand = new RelayCommand(new Action<object>(this.SelectEarlyRepair));
			this.OpenRepairCardCommand = new RelayCommand(new Action<object>(this.OpenRepairCard));
			this.ClosingCommand = new RelayCommand(new Action<object>(this.Closing));
		}

		// Token: 0x0600181B RID: 6171 RVA: 0x000403E4 File Offset: 0x0003E5E4
		private bool CanClick()
		{
			return !this._disableCommand;
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x0600181C RID: 6172 RVA: 0x000403FC File Offset: 0x0003E5FC
		// (set) Token: 0x0600181D RID: 6173 RVA: 0x00040410 File Offset: 0x0003E610
		public bool PrintPko
		{
			[CompilerGenerated]
			get
			{
				return this.<PrintPko>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PrintPko>k__BackingField == value)
				{
					return;
				}
				this.<PrintPko>k__BackingField = value;
				this.RaisePropertyChanged("PrintPko");
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x0600181E RID: 6174 RVA: 0x0004043C File Offset: 0x0003E63C
		// (set) Token: 0x0600181F RID: 6175 RVA: 0x00040450 File Offset: 0x0003E650
		public ReportTemplateSelectorViewModel ReportTemplateSelector
		{
			[CompilerGenerated]
			get
			{
				return this.<ReportTemplateSelector>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ReportTemplateSelector>k__BackingField, value))
				{
					return;
				}
				this.<ReportTemplateSelector>k__BackingField = value;
				this.RaisePropertyChanged("ReportTemplateSelector");
			}
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06001820 RID: 6176 RVA: 0x00040480 File Offset: 0x0003E680
		// (set) Token: 0x06001821 RID: 6177 RVA: 0x00040494 File Offset: 0x0003E694
		public ObservableCollection<ClientAndDevices> DevicesMatch
		{
			[CompilerGenerated]
			get
			{
				return this.<DevicesMatch>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<DevicesMatch>k__BackingField, value))
				{
					return;
				}
				this.<DevicesMatch>k__BackingField = value;
				this.RaisePropertyChanged("DevicesMatch");
			}
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06001822 RID: 6178 RVA: 0x000404C4 File Offset: 0x0003E6C4
		// (set) Token: 0x06001823 RID: 6179 RVA: 0x000404D8 File Offset: 0x0003E6D8
		public string[] FaultList
		{
			[CompilerGenerated]
			get
			{
				return this.<FaultList>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<FaultList>k__BackingField, value))
				{
					return;
				}
				this.<FaultList>k__BackingField = value;
				this.RaisePropertyChanged("FaultList");
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06001824 RID: 6180 RVA: 0x00040508 File Offset: 0x0003E708
		// (set) Token: 0x06001825 RID: 6181 RVA: 0x0004051C File Offset: 0x0003E71C
		public string[] ComplectList
		{
			[CompilerGenerated]
			get
			{
				return this.<ComplectList>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ComplectList>k__BackingField, value))
				{
					return;
				}
				this.<ComplectList>k__BackingField = value;
				this.RaisePropertyChanged("ComplectList");
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06001826 RID: 6182 RVA: 0x0004054C File Offset: 0x0003E74C
		// (set) Token: 0x06001827 RID: 6183 RVA: 0x00040560 File Offset: 0x0003E760
		public string[] LookList
		{
			[CompilerGenerated]
			get
			{
				return this.<LookList>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<LookList>k__BackingField, value))
				{
					return;
				}
				this.<LookList>k__BackingField = value;
				this.RaisePropertyChanged("LookList");
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06001828 RID: 6184 RVA: 0x00040590 File Offset: 0x0003E790
		// (set) Token: 0x06001829 RID: 6185 RVA: 0x000405A4 File Offset: 0x0003E7A4
		public List<object> SelectedLook
		{
			get
			{
				return this._selectedLook;
			}
			set
			{
				if (object.Equals(this._selectedLook, value))
				{
					return;
				}
				this._selectedLook = this.TokenBoxConverter(value);
				this.RaisePropertyChanged("SelectedLook");
			}
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x000405D8 File Offset: 0x0003E7D8
		private List<object> TokenBoxConverter(List<object> value)
		{
			List<object> list = new List<object>();
			if (value != null)
			{
				foreach (object obj in value)
				{
					if (obj != null)
					{
						string[] collection = obj.ToString().Split(NewRepairViewModel.Separators);
						list.AddRange(collection);
					}
				}
			}
			return list;
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x0600182B RID: 6187 RVA: 0x0004064C File Offset: 0x0003E84C
		// (set) Token: 0x0600182C RID: 6188 RVA: 0x00040660 File Offset: 0x0003E860
		public List<object> SelectedComplect
		{
			get
			{
				return this._selectedComplect;
			}
			set
			{
				if (object.Equals(this._selectedComplect, value))
				{
					return;
				}
				this._selectedComplect = this.TokenBoxConverter(value);
				this.RaisePropertyChanged("SelectedComplect");
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x0600182D RID: 6189 RVA: 0x00040694 File Offset: 0x0003E894
		// (set) Token: 0x0600182E RID: 6190 RVA: 0x000406A8 File Offset: 0x0003E8A8
		public List<object> SelectedFaults
		{
			get
			{
				return this._selectedFaults;
			}
			set
			{
				if (object.Equals(this._selectedFaults, value))
				{
					return;
				}
				this._selectedFaults = this.TokenBoxConverter(value);
				this.RaisePropertyChanged("SelectedFaults");
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x0600182F RID: 6191 RVA: 0x000406DC File Offset: 0x0003E8DC
		// (set) Token: 0x06001830 RID: 6192 RVA: 0x000406F0 File Offset: 0x0003E8F0
		public string IntComment
		{
			[CompilerGenerated]
			get
			{
				return this.<IntComment>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<IntComment>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<IntComment>k__BackingField = value;
				this.RaisePropertyChanged("IntComment");
			}
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x00040720 File Offset: 0x0003E920
		public NewRepairViewModel(IToasterService toasterService, IWindowedDocumentService windowedDocumentService, IAdditionalFieldsService additionalFieldsService, IReportPrintService reportPrintService)
		{
			this._toasterService = toasterService;
			this._windowedDocumentService = windowedDocumentService;
			this._additionalFieldsService = additionalFieldsService;
			this._reportPrintService = reportPrintService;
			this.SetViewName("ReceptionRepair");
			this.StickerCount = Auth.Config.rep_stickers_copy;
			this.PrintParts = true;
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x000407B4 File Offset: 0x0003E9B4
		private void CompanySelectionChanged(object obj)
		{
			Settings.Default.NewRepairLastCompany = this.Repair.company;
		}

		// Token: 0x06001833 RID: 6195 RVA: 0x000407D8 File Offset: 0x0003E9D8
		private void Closing(object obj)
		{
			Settings.Default.Save();
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x000407F0 File Offset: 0x0003E9F0
		private void SerialNumberChanged(object obj)
		{
			NewRepairViewModel.<SerialNumberChanged>d__141 <SerialNumberChanged>d__;
			<SerialNumberChanged>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SerialNumberChanged>d__.<>4__this = this;
			<SerialNumberChanged>d__.<>1__state = -1;
			<SerialNumberChanged>d__.<>t__builder.Start<NewRepairViewModel.<SerialNumberChanged>d__141>(ref <SerialNumberChanged>d__);
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x00040828 File Offset: 0x0003EA28
		private void MakersChanged(object obj)
		{
			if (this.Repair.maker != 0)
			{
				goto IL_31;
			}
			IL_0D:
			int num = -821678463;
			IL_12:
			switch ((num ^ -1490194820) % 4)
			{
			case 1:
				return;
			case 2:
				goto IL_0D;
			case 3:
				IL_31:
				base.ShowWait();
				num = -1189003488;
				goto IL_12;
			}
			Task.Run<List<device_models>>(() => this._repairModel.LoadModels(this.Repair.maker, this.Repair.type)).ContinueWith(delegate(Task<List<device_models>> t)
			{
				this.MakerModels = new ObservableCollection<device_models>(t.Result);
				base.HideWait();
			}, TaskScheduler.FromCurrentSynchronizationContext());
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x0004089C File Offset: 0x0003EA9C
		public override void EndInit()
		{
			this.Repair = RepairModel.DefaultRepair();
			this.WPExpress = new WpExpressViewModel(this.Repair);
			this.WPExpress.SetParentViewModel(this);
			if (base.CompaniesVisible)
			{
				this.Repair.company = Auth.User.offices1.default_company;
			}
			if (OfflineData.Instance.CountCompanies() != 1)
			{
				if (Auth.Config.rep_auto_company)
				{
					this.Repair.company = ((Settings.Default.NewRepairLastCompany == 0) ? Auth.User.offices1.default_company : Settings.Default.NewRepairLastCompany);
				}
			}
			else
			{
				this.Repair.company = OfflineData.Instance.GetSelectedCompany();
			}
			this.BgInit();
			base.PhoneOptions = new PhoneOptions().GetAllOptions();
			this.ReportTemplateSelector = new ReportTemplateSelectorViewModel("new_rep");
			this.ReportTemplateSelector.SetParentViewModel(this);
			this.InitCommands();
		}

		// Token: 0x06001837 RID: 6199 RVA: 0x00040990 File Offset: 0x0003EB90
		private void LoadAdditionalFields()
		{
			NewRepairViewModel.<LoadAdditionalFields>d__144 <LoadAdditionalFields>d__;
			<LoadAdditionalFields>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadAdditionalFields>d__.<>4__this = this;
			<LoadAdditionalFields>d__.<>1__state = -1;
			<LoadAdditionalFields>d__.<>t__builder.Start<NewRepairViewModel.<LoadAdditionalFields>d__144>(ref <LoadAdditionalFields>d__);
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x000409C8 File Offset: 0x0003EBC8
		private void BgInit()
		{
			NewRepairViewModel.<BgInit>d__145 <BgInit>d__;
			<BgInit>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<BgInit>d__.<>4__this = this;
			<BgInit>d__.<>1__state = -1;
			<BgInit>d__.<>t__builder.Start<NewRepairViewModel.<BgInit>d__145>(ref <BgInit>d__);
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x00040A00 File Offset: 0x0003EC00
		[Command]
		public void SetNoSn()
		{
			if (this.Repair != null)
			{
				goto IL_2C;
			}
			IL_08:
			int num = 950418798;
			IL_0D:
			switch ((num ^ 1158619417) % 4)
			{
			case 0:
				goto IL_08;
			case 1:
				IL_2C:
				this.Repair.serial_number = Lang.t("NoSn");
				num = 697681287;
				goto IL_0D;
			case 3:
				return;
			}
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x00040A58 File Offset: 0x0003EC58
		[Command]
		public void RepairTypeChanged()
		{
			NewRepairViewModel.<RepairTypeChanged>d__147 <RepairTypeChanged>d__;
			<RepairTypeChanged>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<RepairTypeChanged>d__.<>4__this = this;
			<RepairTypeChanged>d__.<>1__state = -1;
			<RepairTypeChanged>d__.<>t__builder.Start<NewRepairViewModel.<RepairTypeChanged>d__147>(ref <RepairTypeChanged>d__);
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x00040A90 File Offset: 0x0003EC90
		private void CreateNewMakerIfNeeded()
		{
			if (this.Repair.type != 0 && this.Repair.maker == 0 && !string.IsNullOrEmpty(this.Repair.MakerName))
			{
				int num = this._repairModel.CreateNewMaker(this.Repair.type, this.Repair.MakerName);
				if (num == 0)
				{
					this._toasterService.Error("CreateMakerFail");
					return;
				}
				this.Repair.maker = num;
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x0600183C RID: 6204 RVA: 0x00040B10 File Offset: 0x0003ED10
		// (set) Token: 0x0600183D RID: 6205 RVA: 0x00040B24 File Offset: 0x0003ED24
		public bool PrintParts
		{
			[CompilerGenerated]
			get
			{
				return this.<PrintParts>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PrintParts>k__BackingField == value)
				{
					return;
				}
				this.<PrintParts>k__BackingField = value;
				this.RaisePropertyChanged("PrintParts");
			}
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x00040B50 File Offset: 0x0003ED50
		private Task<bool> CreateOrder()
		{
			NewRepairViewModel.<CreateOrder>d__153 <CreateOrder>d__;
			<CreateOrder>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<CreateOrder>d__.<>4__this = this;
			<CreateOrder>d__.<>1__state = -1;
			<CreateOrder>d__.<>t__builder.Start<NewRepairViewModel.<CreateOrder>d__153>(ref <CreateOrder>d__);
			return <CreateOrder>d__.<>t__builder.Task;
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x00040B94 File Offset: 0x0003ED94
		public bool CheckRequiredFields(IEnumerable<object> fields)
		{
			using (IEnumerator<object> enumerator = fields.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					IAttribute attribute = enumerator.Current as IAttribute;
					if (attribute != null && attribute.Required && string.IsNullOrEmpty(attribute.Text))
					{
						this._toasterService.Error(string.Format(Lang.t("AdditionalFieldWarning"), attribute.FieldName));
						return false;
					}
				}
				return true;
			}
			bool result;
			return result;
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x00040C1C File Offset: 0x0003EE1C
		private void CreatePko(IPinpadResult ppResult)
		{
			CashInOrder cashInOrder = new CashInOrder(this.Repair, this.Repair.prepaid_summ, Kassa.Types.partsPrePayment);
			cashInOrder.SetOffice(OfflineData.Instance.Employee.OfficeId);
			cashInOrder.SetEmployee(OfflineData.Instance.Employee.Id);
			if (ppResult != null)
			{
				cashInOrder.SetPinpadData(ppResult);
			}
			IAscResult ascResult = KassaModel.CreateCashOrder(cashInOrder, false);
			this.Repair.prepaid_order = new int?(ascResult.Id);
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x00040C94 File Offset: 0x0003EE94
		[Command]
		public void MakeQuickOrder()
		{
			NewRepairViewModel.<MakeQuickOrder>d__156 <MakeQuickOrder>d__;
			<MakeQuickOrder>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<MakeQuickOrder>d__.<>4__this = this;
			<MakeQuickOrder>d__.<>1__state = -1;
			<MakeQuickOrder>d__.<>t__builder.Start<NewRepairViewModel.<MakeQuickOrder>d__156>(ref <MakeQuickOrder>d__);
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x00040CCC File Offset: 0x0003EECC
		public bool CanMakeQuickOrder()
		{
			return !this._disableCommand && OfflineData.Instance.Employee.Can(73, 0) && this.Repair.quick_repair;
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x00040D04 File Offset: 0x0003EF04
		private void AddTelToList(string phone, int mask)
		{
			base.Customer.AddTelToList(phone, mask);
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x00040D20 File Offset: 0x0003EF20
		[AsyncCommand]
		public Task MakeOrder()
		{
			NewRepairViewModel.<MakeOrder>d__159 <MakeOrder>d__;
			<MakeOrder>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<MakeOrder>d__.<>4__this = this;
			<MakeOrder>d__.<>1__state = -1;
			<MakeOrder>d__.<>t__builder.Start<NewRepairViewModel.<MakeOrder>d__159>(ref <MakeOrder>d__);
			return <MakeOrder>d__.<>t__builder.Task;
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x000403E4 File Offset: 0x0003E5E4
		public bool CanMakeOrder()
		{
			return !this._disableCommand;
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x00040D64 File Offset: 0x0003EF64
		[AsyncCommand]
		public Task MakeManyOrders()
		{
			NewRepairViewModel.<MakeManyOrders>d__161 <MakeManyOrders>d__;
			<MakeManyOrders>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<MakeManyOrders>d__.<>4__this = this;
			<MakeManyOrders>d__.<>1__state = -1;
			<MakeManyOrders>d__.<>t__builder.Start<NewRepairViewModel.<MakeManyOrders>d__161>(ref <MakeManyOrders>d__);
			return <MakeManyOrders>d__.<>t__builder.Task;
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x000403E4 File Offset: 0x0003E5E4
		public bool CanMakeManyOrders()
		{
			return !this._disableCommand;
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x00040DA8 File Offset: 0x0003EFA8
		private void PrintDocuments()
		{
			NewRepairViewModel.<PrintDocuments>d__163 <PrintDocuments>d__;
			<PrintDocuments>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<PrintDocuments>d__.<>4__this = this;
			<PrintDocuments>d__.<>1__state = -1;
			<PrintDocuments>d__.<>t__builder.Start<NewRepairViewModel.<PrintDocuments>d__163>(ref <PrintDocuments>d__);
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x00040DE0 File Offset: 0x0003EFE0
		private void AddIntComment()
		{
			NewRepairViewModel.<AddIntComment>d__164 <AddIntComment>d__;
			<AddIntComment>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<AddIntComment>d__.<>4__this = this;
			<AddIntComment>d__.<>1__state = -1;
			<AddIntComment>d__.<>t__builder.Start<NewRepairViewModel.<AddIntComment>d__164>(ref <AddIntComment>d__);
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x00040E18 File Offset: 0x0003F018
		private string GetFaults()
		{
			if (this.SelectedFaults != null)
			{
				return string.Join(", ", this.SelectedFaults.ToArray());
			}
			return string.Empty;
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x00040E48 File Offset: 0x0003F048
		private string GetComplect()
		{
			if (this.SelectedComplect != null)
			{
				return string.Join(", ", this.SelectedComplect.ToArray());
			}
			return string.Empty;
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x00040E78 File Offset: 0x0003F078
		private string GetLook()
		{
			if (this.SelectedLook != null)
			{
				return string.Join(", ", this.SelectedLook.ToArray());
			}
			return string.Empty;
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x00040EA8 File Offset: 0x0003F0A8
		private bool CheckFinanceFields()
		{
			if (this.Repair.is_prepaid)
			{
				if (this.Repair.prepaid_type == 0)
				{
					this._toasterService.Info(Lang.t("SelectPrepaidReason"));
					return false;
				}
				if (this.Repair.prepaid_summ == 0m)
				{
					this._toasterService.Info(Lang.t("CheckPrepaidSumm"));
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x00040F18 File Offset: 0x0003F118
		private bool CheckFields()
		{
			if (this.Repair.type == 0)
			{
				this._toasterService.Info(Lang.t("SelectDeviceType"));
				return false;
			}
			if (this.Repair.maker == 0)
			{
				this._toasterService.Info(Lang.t("SelectDeviceMaker"));
				return false;
			}
			int? num = this.Repair.model;
			if ((num.GetValueOrDefault() == 0 & num != null) && string.IsNullOrEmpty(this.Repair.ModelName))
			{
				this._toasterService.Info(Lang.t("SelectDeviceModel"));
				return false;
			}
			if (this.Repair.company == 0)
			{
				this._toasterService.Info(Lang.t("SelectCompany"));
				return false;
			}
			if (Auth.Config.is_sn_req && string.IsNullOrEmpty(this.Repair.serial_number))
			{
				this._toasterService.Info(Lang.t("InputSerialNumber"));
				return false;
			}
			if (this.NoSelected(this.SelectedFaults))
			{
				this._toasterService.Info(Lang.t("InputDeviceFault"));
				return false;
			}
			if (this.NoSelected(this.SelectedLook))
			{
				this._toasterService.Info(Lang.t("InputDeviceLook"));
				return false;
			}
			if (Auth.Config.visit_source_force && base.Customer.Id == 0)
			{
				if (base.Customer.VisitSource != null)
				{
					num = base.Customer.VisitSource;
					if (!(num.GetValueOrDefault() == 0 & num != null))
					{
						goto IL_171;
					}
				}
				this._toasterService.Info(Lang.t("SelectVisitSource"));
				return false;
			}
			IL_171:
			if (Auth.Config.is_master_set_on_new && !this.Repair.quick_repair)
			{
				if (this.Repair.master != null)
				{
					num = this.Repair.master;
					if (!(num.GetValueOrDefault() == 0 & num != null))
					{
						goto IL_1D6;
					}
				}
				this._toasterService.Info(Lang.t("SelectMaster"));
				return false;
			}
			IL_1D6:
			if (this.Repair.early == null && string.IsNullOrEmpty(this.Repair.ext_early) && this.RepeatOrWarranty())
			{
				this._toasterService.Info(Lang.t("SelectEarlyRepair"));
				return false;
			}
			if (Auth.Config.is_photo_required && (this._photoIds == null || this._photoIds.Count < 1))
			{
				this._toasterService.Info(Lang.t("PhotoInRequired"));
				return false;
			}
			if (base.Customer.Id > 0 && !string.IsNullOrEmpty(base.Customer.Phone) && base.Customer.Phones.All((Tel c) => c.Phone != base.Customer.Phone))
			{
				if (this._ascMessageBoxService.ShowMessageBox(Lang.t("SaveChanges"), Lang.t("PhoneChanged"), MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
				{
					base.Customer.SetMainTel();
				}
			}
			if (this.GetFaults().Length > 254)
			{
				this._toasterService.Info("Превышено максимальное кол-во символов в описании неисправности");
				return false;
			}
			if (this.GetLook().Length > 254)
			{
				this._toasterService.Info("Превышено максимальное кол-во символов в описании внешнего вида устройства");
				return false;
			}
			if (this.GetComplect().Length <= 254)
			{
				return true;
			}
			this._toasterService.Info("Превышено максимальное кол-во символов в описании комплектности");
			return false;
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x00041288 File Offset: 0x0003F488
		private bool RepeatOrWarranty()
		{
			return this.Repair.is_repeat || this.Repair.is_warranty;
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x000412B0 File Offset: 0x0003F4B0
		public bool NoSelected(List<object> input)
		{
			return input == null || input.Count == 0;
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x000412CC File Offset: 0x0003F4CC
		public void SelectCustomerFromList(ICustomer customer)
		{
			NewRepairViewModel.<SelectCustomerFromList>d__175 <SelectCustomerFromList>d__;
			<SelectCustomerFromList>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SelectCustomerFromList>d__.<>4__this = this;
			<SelectCustomerFromList>d__.customer = customer;
			<SelectCustomerFromList>d__.<>1__state = -1;
			<SelectCustomerFromList>d__.<>t__builder.Start<NewRepairViewModel.<SelectCustomerFromList>d__175>(ref <SelectCustomerFromList>d__);
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x0004130C File Offset: 0x0003F50C
		public override void UseClientData()
		{
			this.Repair.payment_system = (base.Customer.PreferCashless ? 1 : 0);
			base.UseClientData();
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x0004133C File Offset: 0x0003F53C
		public override void AfterClientSelect()
		{
			if (base.Customer != null)
			{
				for (;;)
				{
					IL_46:
					int num = 1980388870;
					for (;;)
					{
						switch ((num ^ 1592613963) % 3)
						{
						case 0:
							goto IL_46;
						case 1:
							this.Repair.payment_system = (base.Customer.PreferCashless ? 1 : 0);
							num = 1645570966;
							continue;
						}
						goto Block_3;
					}
				}
				Block_3:;
			}
			base.AfterClientSelect();
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x0004139C File Offset: 0x0003F59C
		[Command]
		public void MatchClick(object obj)
		{
			NewRepairViewModel.<MatchClick>d__178 <MatchClick>d__;
			<MatchClick>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<MatchClick>d__.<>4__this = this;
			<MatchClick>d__.obj = obj;
			<MatchClick>d__.<>1__state = -1;
			<MatchClick>d__.<>t__builder.Start<NewRepairViewModel.<MatchClick>d__178>(ref <MatchClick>d__);
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x000413DC File Offset: 0x0003F5DC
		[Command]
		public void UnsetMaster()
		{
			if (this.Repair == null)
			{
				return;
			}
			this.Repair.master = null;
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x00041408 File Offset: 0x0003F608
		[Command]
		public void NewMakerInput(object obj)
		{
			if (!Auth.Config.manual_maker)
			{
				return;
			}
			ProcessNewValueEventArgs processNewValueEventArgs = obj as ProcessNewValueEventArgs;
			if (processNewValueEventArgs != null)
			{
				if (base.Makers == null)
				{
					base.Makers = new ObservableCollection<IManufacturer>();
				}
				base.Makers.Add(new Manufacturer(0, processNewValueEventArgs.DisplayText));
				this.Repair.MakerName = processNewValueEventArgs.DisplayText;
				this.MakerModels = new ObservableCollection<device_models>();
				return;
			}
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x00041474 File Offset: 0x0003F674
		private void NewModelInput(object obj)
		{
			ProcessNewValueEventArgs processNewValueEventArgs = obj as ProcessNewValueEventArgs;
			if (processNewValueEventArgs == null)
			{
				return;
			}
			if (this.MakerModels == null)
			{
				this.MakerModels = new ObservableCollection<device_models>();
			}
			this.MakerModels.Add(new device_models
			{
				id = 0,
				name = processNewValueEventArgs.DisplayText
			});
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x000414C4 File Offset: 0x0003F6C4
		private void SelectEarlyRepair(object obj)
		{
			RepairsViewModel repairsViewModel = new RepairsViewModel();
			repairsViewModel.MakeReturnOnSelect();
			this._navigationService.Navigate("RepairsView", repairsViewModel, this);
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x000414F0 File Offset: 0x0003F6F0
		public void SelectRepairFromList(WorkshopLite _repair)
		{
			NewRepairViewModel.<SelectRepairFromList>d__183 <SelectRepairFromList>d__;
			<SelectRepairFromList>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SelectRepairFromList>d__.<>4__this = this;
			<SelectRepairFromList>d__._repair = _repair;
			<SelectRepairFromList>d__.<>1__state = -1;
			<SelectRepairFromList>d__.<>t__builder.Start<NewRepairViewModel.<SelectRepairFromList>d__183>(ref <SelectRepairFromList>d__);
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x00041530 File Offset: 0x0003F730
		public override bool CanSearchClientMatch()
		{
			return this.Repair != null && this.Repair.early == null;
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x00041560 File Offset: 0x0003F760
		private void OpenRepairCard(object obj)
		{
			NewRepairViewModel.<OpenRepairCard>d__185 <OpenRepairCard>d__;
			<OpenRepairCard>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OpenRepairCard>d__.<>4__this = this;
			<OpenRepairCard>d__.<>1__state = -1;
			<OpenRepairCard>d__.<>t__builder.Start<NewRepairViewModel.<OpenRepairCard>d__185>(ref <OpenRepairCard>d__);
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x00041598 File Offset: 0x0003F798
		[Command]
		public void MakeOrderPhoto()
		{
			NewRepairViewModel.<MakeOrderPhoto>d__186 <MakeOrderPhoto>d__;
			<MakeOrderPhoto>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<MakeOrderPhoto>d__.<>4__this = this;
			<MakeOrderPhoto>d__.<>1__state = -1;
			<MakeOrderPhoto>d__.<>t__builder.Start<NewRepairViewModel.<MakeOrderPhoto>d__186>(ref <MakeOrderPhoto>d__);
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x000415D0 File Offset: 0x0003F7D0
		public void ImagesCallBack(List<int> imageIds, int itemId)
		{
			this._photoIds = imageIds;
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x00023150 File Offset: 0x00021350
		[Command]
		public void TokenBoxChanged()
		{
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x000415E4 File Offset: 0x0003F7E4
		[Command]
		public void WorksAndParts()
		{
			this._navigationService.Navigate("WpView", new WpViewModel());
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x00041608 File Offset: 0x0003F808
		[Command]
		public void UnsetBox()
		{
			if (this.Repair != null)
			{
				goto IL_2C;
			}
			IL_08:
			int num = 985193757;
			IL_0D:
			switch ((num ^ 836165764) % 4)
			{
			case 0:
				goto IL_08;
			case 1:
				return;
			case 2:
				IL_2C:
				this.Repair.box = null;
				num = 277858835;
				goto IL_0D;
			}
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x00041660 File Offset: 0x0003F860
		[Command]
		public void ShowDeviceMatches()
		{
			this.DeviceMatchVisible = true;
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x00041674 File Offset: 0x0003F874
		[Command]
		public void HideDeviceMatch()
		{
			this.DeviceMatchVisible = false;
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x00041688 File Offset: 0x0003F888
		[Command]
		public void ToggleExtEarlyVis()
		{
			this.ExtEarlyVis = !this.ExtEarlyVis;
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x000416A4 File Offset: 0x0003F8A4
		[Command]
		public void Loaded()
		{
			if (this.Repair != null)
			{
				this.Repair.clients = null;
			}
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x000416C8 File Offset: 0x0003F8C8
		public void SetVendor(int? vendorId)
		{
			if (this.Repair != null)
			{
				goto IL_2C;
			}
			IL_08:
			int num = -1287703601;
			IL_0D:
			switch ((num ^ -1184189040) % 4)
			{
			case 0:
				goto IL_08;
			case 2:
				IL_2C:
				this.Repair.vendor_id = vendorId;
				num = -2091689831;
				goto IL_0D;
			case 3:
				return;
			}
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x00041718 File Offset: 0x0003F918
		// Note: this type is marked as 'beforefieldinit'.
		static NewRepairViewModel()
		{
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x0004173C File Offset: 0x0003F93C
		[CompilerGenerated]
		private Task<List<device_models>> <MakersChanged>b__142_0()
		{
			return this._repairModel.LoadModels(this.Repair.maker, this.Repair.type);
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x0004176C File Offset: 0x0003F96C
		[CompilerGenerated]
		private void <MakersChanged>b__142_1(Task<List<device_models>> t)
		{
			this.MakerModels = new ObservableCollection<device_models>(t.Result);
			base.HideWait();
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x00041790 File Offset: 0x0003F990
		[CompilerGenerated]
		private Task<IEnumerable<IDevice>> <BgInit>b__145_0()
		{
			return this._workshopService.GetActiveDevices();
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x000417A8 File Offset: 0x0003F9A8
		[CompilerGenerated]
		private bool <RepairTypeChanged>b__147_0(IDevice d)
		{
			return d.Id == this.Repair.type;
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x000417C8 File Offset: 0x0003F9C8
		[CompilerGenerated]
		private Task<IRepairCard> <MakeQuickOrder>b__156_4()
		{
			return RepairModel.GetRepairCard(this.Repair.id);
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x000417E8 File Offset: 0x0003F9E8
		[CompilerGenerated]
		private void <MakeQuickOrder>b__156_2()
		{
			this._disableCommand = false;
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x000417FC File Offset: 0x0003F9FC
		[CompilerGenerated]
		private bool <CheckFields>b__172_0(Tel c)
		{
			return c.Phone != base.Customer.Phone;
		}

		// Token: 0x04000C07 RID: 3079
		private readonly RepairModel _repairModel = new RepairModel();

		// Token: 0x04000C08 RID: 3080
		[CompilerGenerated]
		private ClientsModel <_customerModel>k__BackingField = new ClientsModel();

		// Token: 0x04000C09 RID: 3081
		[CompilerGenerated]
		private workshop <Repair>k__BackingField;

		// Token: 0x04000C0A RID: 3082
		[CompilerGenerated]
		private List<IDevice> <Devices>k__BackingField;

		// Token: 0x04000C0B RID: 3083
		[CompilerGenerated]
		private List<IPrepaidType> <PrePaidTypes>k__BackingField;

		// Token: 0x04000C0C RID: 3084
		[CompilerGenerated]
		private ObservableCollection<device_models> <MakerModels>k__BackingField;

		// Token: 0x04000C0D RID: 3085
		[CompilerGenerated]
		private int <StickerCount>k__BackingField;

		// Token: 0x04000C0E RID: 3086
		private List<int> _photoIds;

		// Token: 0x04000C0F RID: 3087
		[CompilerGenerated]
		private WpExpressViewModel <WPExpress>k__BackingField;

		// Token: 0x04000C10 RID: 3088
		[CompilerGenerated]
		private bool <DeviceMatchFound>k__BackingField;

		// Token: 0x04000C11 RID: 3089
		[CompilerGenerated]
		private bool <DeviceMatchVisible>k__BackingField;

		// Token: 0x04000C12 RID: 3090
		[CompilerGenerated]
		private bool <PayCheck>k__BackingField;

		// Token: 0x04000C13 RID: 3091
		[CompilerGenerated]
		private bool <ExtEarlyVis>k__BackingField;

		// Token: 0x04000C14 RID: 3092
		[CompilerGenerated]
		private decimal <TotalAmount>k__BackingField;

		// Token: 0x04000C15 RID: 3093
		[CompilerGenerated]
		private bool <PrintCheque>k__BackingField;

		// Token: 0x04000C16 RID: 3094
		public ObservableCollection<WorkPartObject> WpPartObjects;

		// Token: 0x04000C17 RID: 3095
		[CompilerGenerated]
		private ICommand <MakersChangedCommand>k__BackingField;

		// Token: 0x04000C18 RID: 3096
		[CompilerGenerated]
		private ICommand <SerialNumberChangedCommand>k__BackingField;

		// Token: 0x04000C19 RID: 3097
		[CompilerGenerated]
		private ICommand <CompanySelectionChangedCommand>k__BackingField;

		// Token: 0x04000C1A RID: 3098
		[CompilerGenerated]
		private ICommand <NewModelInputCommand>k__BackingField;

		// Token: 0x04000C1B RID: 3099
		[CompilerGenerated]
		private ICommand <SelectEarlyRepairCommand>k__BackingField;

		// Token: 0x04000C1C RID: 3100
		[CompilerGenerated]
		private ICommand <OpenRepairCardCommand>k__BackingField;

		// Token: 0x04000C1D RID: 3101
		[CompilerGenerated]
		private ICommand <ClosingCommand>k__BackingField;

		// Token: 0x04000C1E RID: 3102
		private bool _disableCommand;

		// Token: 0x04000C1F RID: 3103
		private List<object> _selectedLook = new List<object>();

		// Token: 0x04000C20 RID: 3104
		private List<object> _selectedComplect = new List<object>();

		// Token: 0x04000C21 RID: 3105
		private List<object> _selectedFaults = new List<object>();

		// Token: 0x04000C22 RID: 3106
		[CompilerGenerated]
		private bool <PrintPko>k__BackingField;

		// Token: 0x04000C23 RID: 3107
		[CompilerGenerated]
		private ReportTemplateSelectorViewModel <ReportTemplateSelector>k__BackingField;

		// Token: 0x04000C24 RID: 3108
		[CompilerGenerated]
		private ObservableCollection<ClientAndDevices> <DevicesMatch>k__BackingField = new ObservableCollection<ClientAndDevices>();

		// Token: 0x04000C25 RID: 3109
		[CompilerGenerated]
		private string[] <FaultList>k__BackingField;

		// Token: 0x04000C26 RID: 3110
		[CompilerGenerated]
		private string[] <ComplectList>k__BackingField;

		// Token: 0x04000C27 RID: 3111
		[CompilerGenerated]
		private string[] <LookList>k__BackingField;

		// Token: 0x04000C28 RID: 3112
		private static readonly char[] Separators = new char[]
		{
			',',
			';'
		};

		// Token: 0x04000C29 RID: 3113
		private readonly IToasterService _toasterService;

		// Token: 0x04000C2A RID: 3114
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04000C2B RID: 3115
		private readonly IAdditionalFieldsService _additionalFieldsService;

		// Token: 0x04000C2C RID: 3116
		private readonly IReportPrintService _reportPrintService;

		// Token: 0x04000C2D RID: 3117
		[CompilerGenerated]
		private string <IntComment>k__BackingField;

		// Token: 0x04000C2E RID: 3118
		[CompilerGenerated]
		private bool <PrintParts>k__BackingField;

		// Token: 0x04000C2F RID: 3119
		private const int FaultsMaxLength = 254;

		// Token: 0x04000C30 RID: 3120
		private const int ComplectMaxLength = 254;

		// Token: 0x04000C31 RID: 3121
		private const int LookMaxLength = 254;

		// Token: 0x02000191 RID: 401
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SerialNumberChanged>d__141 : IAsyncStateMachine
		{
			// Token: 0x0600186E RID: 6254 RVA: 0x00041820 File Offset: 0x0003FA20
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NewRepairViewModel newRepairViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<ClientAndDevices>> awaiter;
					if (num != 0)
					{
						awaiter = newRepairViewModel._repairModel.SearchDeviceMatch(newRepairViewModel.Repair).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<ClientAndDevices>>, NewRepairViewModel.<SerialNumberChanged>d__141>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<ClientAndDevices>>);
						this.<>1__state = -1;
					}
					List<ClientAndDevices> result = awaiter.GetResult();
					newRepairViewModel.DevicesMatch = new ObservableCollection<ClientAndDevices>(result);
					newRepairViewModel.DeviceMatchFound = (newRepairViewModel.DevicesMatch.Count > 0);
					newRepairViewModel.DeviceMatchVisible = newRepairViewModel.DeviceMatchFound;
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

			// Token: 0x0600186F RID: 6255 RVA: 0x0004190C File Offset: 0x0003FB0C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000C32 RID: 3122
			public int <>1__state;

			// Token: 0x04000C33 RID: 3123
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000C34 RID: 3124
			public NewRepairViewModel <>4__this;

			// Token: 0x04000C35 RID: 3125
			private TaskAwaiter<List<ClientAndDevices>> <>u__1;
		}

		// Token: 0x02000192 RID: 402
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadAdditionalFields>d__144 : IAsyncStateMachine
		{
			// Token: 0x06001870 RID: 6256 RVA: 0x00041928 File Offset: 0x0003FB28
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NewRepairViewModel newRepairViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<object>> awaiter;
					if (num != 0)
					{
						this.<>7__wrap1 = newRepairViewModel.Repair;
						awaiter = newRepairViewModel._additionalFieldsService.GetDeviceFields(newRepairViewModel.Repair.type).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<object>>, NewRepairViewModel.<LoadAdditionalFields>d__144>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<object>>);
						this.<>1__state = -1;
					}
					List<object> result = awaiter.GetResult();
					this.<>7__wrap1.AdditionalFields = new ObservableCollection<object>(result);
					this.<>7__wrap1 = null;
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

			// Token: 0x06001871 RID: 6257 RVA: 0x00041A14 File Offset: 0x0003FC14
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000C36 RID: 3126
			public int <>1__state;

			// Token: 0x04000C37 RID: 3127
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000C38 RID: 3128
			public NewRepairViewModel <>4__this;

			// Token: 0x04000C39 RID: 3129
			private workshop <>7__wrap1;

			// Token: 0x04000C3A RID: 3130
			private TaskAwaiter<List<object>> <>u__1;
		}

		// Token: 0x02000193 RID: 403
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001872 RID: 6258 RVA: 0x00041A30 File Offset: 0x0003FC30
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06001873 RID: 6259 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06001874 RID: 6260 RVA: 0x00041A48 File Offset: 0x0003FC48
			internal bool <BgInit>b__145_1(IDevice d)
			{
				return !d.Refill;
			}

			// Token: 0x06001875 RID: 6261 RVA: 0x00041A60 File Offset: 0x0003FC60
			internal IEnumerable<UserMaster> <BgInit>b__145_2()
			{
				return UsersModel.LoadMasters(false);
			}

			// Token: 0x06001876 RID: 6262 RVA: 0x00041A74 File Offset: 0x0003FC74
			internal bool <MakeQuickOrder>b__156_0(WorkPartObject w)
			{
				return string.IsNullOrEmpty(w.Name);
			}

			// Token: 0x04000C3B RID: 3131
			public static readonly NewRepairViewModel.<>c <>9 = new NewRepairViewModel.<>c();

			// Token: 0x04000C3C RID: 3132
			public static Func<IDevice, bool> <>9__145_1;

			// Token: 0x04000C3D RID: 3133
			public static Func<IEnumerable<UserMaster>> <>9__145_2;

			// Token: 0x04000C3E RID: 3134
			public static Func<WorkPartObject, bool> <>9__156_0;
		}

		// Token: 0x02000194 RID: 404
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <BgInit>d__145 : IAsyncStateMachine
		{
			// Token: 0x06001877 RID: 6263 RVA: 0x00041A8C File Offset: 0x0003FC8C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NewRepairViewModel newRepairViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<UserMaster>> awaiter;
					TaskAwaiter<IEnumerable<IDevice>> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<IEnumerable<UserMaster>>);
							this.<>1__state = -1;
							goto IL_12D;
						}
						newRepairViewModel.ShowWait();
						if (newRepairViewModel.OfficesVisible)
						{
							newRepairViewModel.Repair.office = Auth.User.office;
						}
						awaiter2 = Task.Run<IEnumerable<IDevice>>(() => newRepairViewModel._workshopService.GetActiveDevices()).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<IDevice>>, NewRepairViewModel.<BgInit>d__145>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<IDevice>>);
						this.<>1__state = -1;
					}
					IEnumerable<IDevice> result = awaiter2.GetResult();
					newRepairViewModel.Devices = new List<IDevice>(result).Where(new Func<IDevice, bool>(NewRepairViewModel.<>c.<>9.<BgInit>b__145_1)).ToList<IDevice>();
					awaiter = Task.Run<IEnumerable<UserMaster>>(new Func<IEnumerable<UserMaster>>(NewRepairViewModel.<>c.<>9.<BgInit>b__145_2)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<UserMaster>>, NewRepairViewModel.<BgInit>d__145>(ref awaiter, ref this);
						return;
					}
					IL_12D:
					IEnumerable<UserMaster> result2 = awaiter.GetResult();
					newRepairViewModel.Masters = new List<UserMaster>(result2);
					newRepairViewModel.PrePaidTypes = newRepairViewModel._repairModel.GetPrePaidTypes();
					newRepairViewModel.HideWait();
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

			// Token: 0x06001878 RID: 6264 RVA: 0x00041C60 File Offset: 0x0003FE60
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000C3F RID: 3135
			public int <>1__state;

			// Token: 0x04000C40 RID: 3136
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000C41 RID: 3137
			public NewRepairViewModel <>4__this;

			// Token: 0x04000C42 RID: 3138
			private TaskAwaiter<IEnumerable<IDevice>> <>u__1;

			// Token: 0x04000C43 RID: 3139
			private TaskAwaiter<IEnumerable<UserMaster>> <>u__2;
		}

		// Token: 0x02000195 RID: 405
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <RepairTypeChanged>d__147 : IAsyncStateMachine
		{
			// Token: 0x06001879 RID: 6265 RVA: 0x00041C7C File Offset: 0x0003FE7C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NewRepairViewModel newRepairViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<IManufacturer>> awaiter;
					if (num != 0)
					{
						if (newRepairViewModel.Repair.type == 0)
						{
							goto IL_124;
						}
						IDevice device = newRepairViewModel.Devices.FirstOrDefault((IDevice d) => d.Id == base.Repair.type);
						newRepairViewModel.FaultList = newRepairViewModel._repairModel.SplitString(device.FaultList);
						newRepairViewModel.ComplectList = newRepairViewModel._repairModel.SplitString(device.ComplectList);
						newRepairViewModel.LookList = newRepairViewModel._repairModel.SplitString(device.LookList);
						if (string.IsNullOrEmpty(device.CompanyList))
						{
							goto IL_103;
						}
						awaiter = newRepairViewModel._workshopService.GetManufacturers(device.CompanyList).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<IManufacturer>>, NewRepairViewModel.<RepairTypeChanged>d__147>(ref awaiter, ref this);
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
					newRepairViewModel.Makers = new ObservableCollection<IManufacturer>(result);
					IL_103:
					newRepairViewModel.LoadAdditionalFields();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_124:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x0600187A RID: 6266 RVA: 0x00041DD0 File Offset: 0x0003FFD0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000C44 RID: 3140
			public int <>1__state;

			// Token: 0x04000C45 RID: 3141
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000C46 RID: 3142
			public NewRepairViewModel <>4__this;

			// Token: 0x04000C47 RID: 3143
			private TaskAwaiter<IEnumerable<IManufacturer>> <>u__1;
		}

		// Token: 0x02000196 RID: 406
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateOrder>d__153 : IAsyncStateMachine
		{
			// Token: 0x0600187B RID: 6267 RVA: 0x00041DEC File Offset: 0x0003FFEC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NewRepairViewModel newRepairViewModel = this.<>4__this;
				bool result;
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter<int> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter);
							this.<>1__state = -1;
							goto IL_3B3;
						}
						newRepairViewModel.CreateNewMakerIfNeeded();
						if (!newRepairViewModel.CheckFields())
						{
							result = false;
							goto IL_45C;
						}
						if (!newRepairViewModel.CheckFields(newRepairViewModel.Customer))
						{
							result = false;
							goto IL_45C;
						}
						if (!newRepairViewModel.CheckFinanceFields())
						{
							result = false;
							goto IL_45C;
						}
						if (!newRepairViewModel.CheckRequiredFields(newRepairViewModel.Repair.AdditionalFields))
						{
							result = false;
							goto IL_45C;
						}
						this.<ppResult>5__2 = null;
						if (newRepairViewModel.Repair.payment_system == -1)
						{
							if (newRepairViewModel.Repair.is_prepaid && !newRepairViewModel.Repair.quick_repair && OfflineData.Instance.Employee.PinpadReady())
							{
								SBRFPinpad sbrfpinpad = new SBRFPinpad();
								this.<ppResult>5__2 = sbrfpinpad.Purchase(newRepairViewModel.Repair.prepaid_summ);
								if (this.<ppResult>5__2.ErrorCode != 0)
								{
									newRepairViewModel._toasterService.Error(this.<ppResult>5__2.ResultText);
									result = false;
									goto IL_45C;
								}
							}
						}
						if (newRepairViewModel.Customer.Id == 0)
						{
							if (!string.IsNullOrEmpty(newRepairViewModel.Customer.Phone))
							{
								newRepairViewModel.AddTelToList(newRepairViewModel.Customer.Phone, newRepairViewModel.Customer.PhoneMask);
							}
							if (!string.IsNullOrEmpty(newRepairViewModel.Customer.Phone2))
							{
								newRepairViewModel.AddTelToList(newRepairViewModel.Customer.Phone2, newRepairViewModel.Customer.Phone2Mask);
							}
							string text = newRepairViewModel._customerModel.CheckFields(newRepairViewModel.Customer);
							if (!string.IsNullOrEmpty(text))
							{
								newRepairViewModel._toasterService.Info(text);
								result = false;
								goto IL_45C;
							}
							newRepairViewModel.Customer.Id = newRepairViewModel._customerModel.CreateNewClient(newRepairViewModel.Customer);
							if (newRepairViewModel.Customer == null || newRepairViewModel.Customer.Id == 0)
							{
								result = false;
								goto IL_45C;
							}
						}
						newRepairViewModel.Repair.client = newRepairViewModel.Customer.Id;
						newRepairViewModel.Repair.model = new int?(newRepairViewModel._repairModel.CreateDeviceModel(newRepairViewModel.Repair, true));
						newRepairViewModel.Repair.fault = newRepairViewModel.GetFaults();
						newRepairViewModel.Repair.complect = newRepairViewModel.GetComplect();
						newRepairViewModel.Repair.look = newRepairViewModel.GetLook();
						newRepairViewModel.Repair.image_ids = newRepairViewModel._repairModel.SerializeImageIds(newRepairViewModel._photoIds);
						newRepairViewModel.ShowWait();
						awaiter2 = newRepairViewModel._workshopService.CreateRepair(newRepairViewModel.Repair).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, NewRepairViewModel.<CreateOrder>d__153>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<int>);
						this.<>1__state = -1;
					}
					int result2 = awaiter2.GetResult();
					this.<repairId>5__3 = result2;
					newRepairViewModel.HideWait();
					if (this.<repairId>5__3 <= 0)
					{
						result = false;
						goto IL_45C;
					}
					if (newRepairViewModel.Repair.is_prepaid && !newRepairViewModel.Repair.quick_repair)
					{
						newRepairViewModel.CreatePko(this.<ppResult>5__2);
					}
					if (!string.IsNullOrEmpty(newRepairViewModel.IntComment))
					{
						newRepairViewModel.AddIntComment();
					}
					if (newRepairViewModel.Repair.AdditionalFields == null || newRepairViewModel.Repair.AdditionalFields.Count <= 0)
					{
						goto IL_3BA;
					}
					awaiter = newRepairViewModel._additionalFieldsService.UpdateAdditionalFields(newRepairViewModel.Repair.id, newRepairViewModel.Repair.AdditionalFields).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, NewRepairViewModel.<CreateOrder>d__153>(ref awaiter, ref this);
						return;
					}
					IL_3B3:
					awaiter.GetResult();
					IL_3BA:
					if (OfflineData.Instance.Settings.PrintNewRepairReport && !newRepairViewModel.Repair.quick_repair)
					{
						newRepairViewModel.PrintDocuments();
					}
					if (!newRepairViewModel.Repair.quick_repair)
					{
						newRepairViewModel._repairModel.TaskTrigger(newRepairViewModel.Repair);
					}
					if (OfflineData.Instance.Settings.AutoMasterAssign)
					{
						newRepairViewModel._windowedDocumentService.ShowNewDocument(typeof(AutoMasterAssignView).FullName, new AutoMasterAssignViewModel(this.<repairId>5__3), null, null);
					}
					result = true;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<ppResult>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_45C:
				this.<>1__state = -2;
				this.<ppResult>5__2 = null;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x0600187C RID: 6268 RVA: 0x0004228C File Offset: 0x0004048C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000C48 RID: 3144
			public int <>1__state;

			// Token: 0x04000C49 RID: 3145
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x04000C4A RID: 3146
			public NewRepairViewModel <>4__this;

			// Token: 0x04000C4B RID: 3147
			private IPinpadResult <ppResult>5__2;

			// Token: 0x04000C4C RID: 3148
			private int <repairId>5__3;

			// Token: 0x04000C4D RID: 3149
			private TaskAwaiter<int> <>u__1;

			// Token: 0x04000C4E RID: 3150
			private TaskAwaiter <>u__2;
		}

		// Token: 0x02000197 RID: 407
		[CompilerGenerated]
		private sealed class <>c__DisplayClass156_0
		{
			// Token: 0x0600187D RID: 6269 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass156_0()
			{
			}

			// Token: 0x0600187E RID: 6270 RVA: 0x000422A8 File Offset: 0x000404A8
			internal Task<XtraReport> <MakeQuickOrder>b__5()
			{
				return ((RepairCard)this.card).CreateReport("warranty", 1);
			}

			// Token: 0x0600187F RID: 6271 RVA: 0x000422CC File Offset: 0x000404CC
			internal Task<XtraReport> <MakeQuickOrder>b__6()
			{
				return ((RepairCard)this.card).CreateReport("works", 1);
			}

			// Token: 0x04000C4F RID: 3151
			public IRepairCard card;
		}

		// Token: 0x02000198 RID: 408
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <MakeQuickOrder>d__156 : IAsyncStateMachine
		{
			// Token: 0x06001880 RID: 6272 RVA: 0x000422F0 File Offset: 0x000404F0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NewRepairViewModel newRepairViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<bool> awaiter;
					TaskAwaiter<IAscResult> awaiter3;
					TaskAwaiter<IRepairCard> awaiter4;
					TaskAwaiter<XtraReport> awaiter5;
					switch (num)
					{
					case 0:
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<bool>);
						int num2 = -1;
						num = -1;
						this.<>1__state = num2;
						break;
					}
					case 1:
					{
						IL_219:
						try
						{
							TaskAwaiter awaiter2;
							if (num != 1)
							{
								awaiter2 = newRepairViewModel._repairModel.FinishQuickRepair(newRepairViewModel.Repair, newRepairViewModel.WpPartObjects, newRepairViewModel.TotalAmount).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									this.<>1__state = 1;
									this.<>u__2 = awaiter2;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, NewRepairViewModel.<MakeQuickOrder>d__156>(ref awaiter2, ref this);
									return;
								}
							}
							else
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter);
								this.<>1__state = -1;
							}
							awaiter2.GetResult();
						}
						catch (Exception ex)
						{
							newRepairViewModel._toasterService.Error(ex.Message);
						}
						CashInOrder cashInOrder = new CashInOrder(newRepairViewModel.Repair, newRepairViewModel.TotalAmount, Kassa.Types.repairPayment);
						cashInOrder.SetOffice(OfflineData.Instance.Employee.OfficeId);
						cashInOrder.SetEmployee(OfflineData.Instance.Employee.Id);
						if (this.<ppResult>5__2 != null)
						{
							cashInOrder.SetPinpadData(this.<ppResult>5__2);
						}
						IAscResult ascResult = KassaModel.CreateCashOrder(cashInOrder, false);
						if (!newRepairViewModel.PrintCheque || ascResult.Id <= 0 || !OfflineData.Instance.Employee.KktReady())
						{
							goto IL_3BB;
						}
						awaiter3 = OfflineData.Instance.Employee.Kkt.RepairCheck(newRepairViewModel.Repair.id, ascResult.Id, "").GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							this.<>1__state = 2;
							this.<>u__3 = awaiter3;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IAscResult>, NewRepairViewModel.<MakeQuickOrder>d__156>(ref awaiter3, ref this);
							return;
						}
						goto IL_3B3;
					}
					case 2:
						awaiter3 = this.<>u__3;
						this.<>u__3 = default(TaskAwaiter<IAscResult>);
						this.<>1__state = -1;
						goto IL_3B3;
					case 3:
						awaiter4 = this.<>u__4;
						this.<>u__4 = default(TaskAwaiter<IRepairCard>);
						this.<>1__state = -1;
						goto IL_42E;
					case 4:
						awaiter5 = this.<>u__5;
						this.<>u__5 = default(TaskAwaiter<XtraReport>);
						this.<>1__state = -1;
						goto IL_4AB;
					case 5:
						awaiter5 = this.<>u__5;
						this.<>u__5 = default(TaskAwaiter<XtraReport>);
						this.<>1__state = -1;
						goto IL_532;
					default:
						if (newRepairViewModel.PayCheck)
						{
							if (newRepairViewModel.WpPartObjects.Any<WorkPartObject>())
							{
								if (!newRepairViewModel.WpPartObjects.Any(new Func<WorkPartObject, bool>(NewRepairViewModel.<>c.<>9.<MakeQuickOrder>b__156_0)))
								{
									newRepairViewModel._disableCommand = true;
									newRepairViewModel.RaiseCanExecuteChanged(() => newRepairViewModel.MakeQuickOrder());
									this.<ppResult>5__2 = null;
									if (newRepairViewModel.Repair.payment_system == -1 && OfflineData.Instance.Employee.PinpadReady())
									{
										SBRFPinpad sbrfpinpad = new SBRFPinpad();
										this.<ppResult>5__2 = sbrfpinpad.Purchase(newRepairViewModel.TotalAmount);
										if (this.<ppResult>5__2.ErrorCode != 0)
										{
											newRepairViewModel._toasterService.Error(this.<ppResult>5__2.ResultText);
											goto IL_597;
										}
									}
									awaiter = newRepairViewModel.CreateOrder().GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										this.<>1__state = 0;
										this.<>u__1 = awaiter;
										this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, NewRepairViewModel.<MakeQuickOrder>d__156>(ref awaiter, ref this);
										return;
									}
									break;
								}
							}
							newRepairViewModel._toasterService.Info(Lang.t("InputWorkName"));
							goto IL_597;
						}
						newRepairViewModel._toasterService.Info(Lang.t("ConfirmPayment"));
						goto IL_597;
					}
					if (awaiter.GetResult())
					{
						this.<>8__1 = new NewRepairViewModel.<>c__DisplayClass156_0();
						goto IL_219;
					}
					Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Input, new Action(delegate()
					{
						newRepairViewModel._disableCommand = false;
					}));
					newRepairViewModel.RaiseCanExecuteChanged(() => newRepairViewModel.MakeQuickOrder());
					goto IL_597;
					IL_3B3:
					awaiter3.GetResult();
					IL_3BB:
					this.<report>5__3 = new XtraReport();
					newRepairViewModel.ShowWait();
					awaiter4 = Task.Run<IRepairCard>(() => RepairModel.GetRepairCard(base.Repair.id)).GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__4 = awaiter4;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IRepairCard>, NewRepairViewModel.<MakeQuickOrder>d__156>(ref awaiter4, ref this);
						return;
					}
					IL_42E:
					IRepairCard result = awaiter4.GetResult();
					this.<>8__1.card = result;
					awaiter5 = Task.Run<XtraReport>(new Func<Task<XtraReport>>(this.<>8__1.<MakeQuickOrder>b__5)).GetAwaiter();
					if (!awaiter5.IsCompleted)
					{
						this.<>1__state = 4;
						this.<>u__5 = awaiter5;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XtraReport>, NewRepairViewModel.<MakeQuickOrder>d__156>(ref awaiter5, ref this);
						return;
					}
					IL_4AB:
					XtraReport result2 = awaiter5.GetResult();
					this.<report>5__3.Pages.AddRange(result2.Pages);
					awaiter5 = Task.Run<XtraReport>(new Func<Task<XtraReport>>(this.<>8__1.<MakeQuickOrder>b__6)).GetAwaiter();
					if (!awaiter5.IsCompleted)
					{
						this.<>1__state = 5;
						this.<>u__5 = awaiter5;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XtraReport>, NewRepairViewModel.<MakeQuickOrder>d__156>(ref awaiter5, ref this);
						return;
					}
					IL_532:
					XtraReport result3 = awaiter5.GetResult();
					this.<report>5__3.Pages.AddRange(result3.Pages);
					newRepairViewModel.HideWait();
					newRepairViewModel._reportPrintService.PrintPreview(this.<report>5__3, PrinterModel.Printer.Documents);
					newRepairViewModel._navigationService.CloseCurrentTab();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<ppResult>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_597:
				this.<>1__state = -2;
				this.<ppResult>5__2 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06001881 RID: 6273 RVA: 0x000428E4 File Offset: 0x00040AE4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000C50 RID: 3152
			public int <>1__state;

			// Token: 0x04000C51 RID: 3153
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000C52 RID: 3154
			public NewRepairViewModel <>4__this;

			// Token: 0x04000C53 RID: 3155
			private NewRepairViewModel.<>c__DisplayClass156_0 <>8__1;

			// Token: 0x04000C54 RID: 3156
			private IPinpadResult <ppResult>5__2;

			// Token: 0x04000C55 RID: 3157
			private TaskAwaiter<bool> <>u__1;

			// Token: 0x04000C56 RID: 3158
			private XtraReport <report>5__3;

			// Token: 0x04000C57 RID: 3159
			private TaskAwaiter <>u__2;

			// Token: 0x04000C58 RID: 3160
			private TaskAwaiter<IAscResult> <>u__3;

			// Token: 0x04000C59 RID: 3161
			private TaskAwaiter<IRepairCard> <>u__4;

			// Token: 0x04000C5A RID: 3162
			private TaskAwaiter<XtraReport> <>u__5;
		}

		// Token: 0x02000199 RID: 409
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <MakeOrder>d__159 : IAsyncStateMachine
		{
			// Token: 0x06001882 RID: 6274 RVA: 0x00042900 File Offset: 0x00040B00
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NewRepairViewModel newRepairViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						newRepairViewModel._disableCommand = true;
						newRepairViewModel.RaiseCanExecuteChanged(() => newRepairViewModel.MakeOrder());
					}
					try
					{
						TaskAwaiter<bool> awaiter;
						if (num != 0)
						{
							awaiter = newRepairViewModel.CreateOrder().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, NewRepairViewModel.<MakeOrder>d__159>(ref awaiter, ref this);
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
						if (awaiter.GetResult())
						{
							newRepairViewModel._navigationService.NavigateRepairs();
							newRepairViewModel._navigationService.CloseCurrentTab();
						}
					}
					catch (Exception ex)
					{
						newRepairViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							newRepairViewModel._disableCommand = false;
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

			// Token: 0x06001883 RID: 6275 RVA: 0x00042A54 File Offset: 0x00040C54
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000C5B RID: 3163
			public int <>1__state;

			// Token: 0x04000C5C RID: 3164
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000C5D RID: 3165
			public NewRepairViewModel <>4__this;

			// Token: 0x04000C5E RID: 3166
			private TaskAwaiter<bool> <>u__1;
		}

		// Token: 0x0200019A RID: 410
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <MakeManyOrders>d__161 : IAsyncStateMachine
		{
			// Token: 0x06001884 RID: 6276 RVA: 0x00042A70 File Offset: 0x00040C70
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NewRepairViewModel newRepairViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						newRepairViewModel._disableCommand = true;
						newRepairViewModel.RaiseCanExecuteChanged(() => newRepairViewModel.MakeManyOrders());
						this.<company>5__2 = newRepairViewModel.Repair.company;
						this.<type>5__3 = newRepairViewModel.Repair.type;
					}
					try
					{
						TaskAwaiter<bool> awaiter;
						if (num != 0)
						{
							awaiter = newRepairViewModel.CreateOrder().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, NewRepairViewModel.<MakeManyOrders>d__161>(ref awaiter, ref this);
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
						if (awaiter.GetResult())
						{
							newRepairViewModel.SelectedFaults = new List<object>();
							newRepairViewModel.SelectedLook = new List<object>();
							newRepairViewModel.SelectedComplect = new List<object>();
							newRepairViewModel._photoIds = new List<int>();
							newRepairViewModel.Repair = RepairModel.DefaultRepair();
							newRepairViewModel.LoadAdditionalFields();
							newRepairViewModel.Repair.company = this.<company>5__2;
							newRepairViewModel.Repair.type = this.<type>5__3;
						}
					}
					catch (Exception ex)
					{
						newRepairViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							newRepairViewModel._disableCommand = false;
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

			// Token: 0x06001885 RID: 6277 RVA: 0x00042C50 File Offset: 0x00040E50
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000C5F RID: 3167
			public int <>1__state;

			// Token: 0x04000C60 RID: 3168
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000C61 RID: 3169
			public NewRepairViewModel <>4__this;

			// Token: 0x04000C62 RID: 3170
			private int <company>5__2;

			// Token: 0x04000C63 RID: 3171
			private int <type>5__3;

			// Token: 0x04000C64 RID: 3172
			private TaskAwaiter<bool> <>u__1;
		}

		// Token: 0x0200019B RID: 411
		[CompilerGenerated]
		private sealed class <>c__DisplayClass163_0
		{
			// Token: 0x06001886 RID: 6278 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass163_0()
			{
			}

			// Token: 0x06001887 RID: 6279 RVA: 0x00042C6C File Offset: 0x00040E6C
			internal Task<IRepairCard> <PrintDocuments>b__0()
			{
				return RepairModel.GetRepairCard(this.<>4__this.Repair.id);
			}

			// Token: 0x06001888 RID: 6280 RVA: 0x00042C90 File Offset: 0x00040E90
			internal Task<XtraReport> <PrintDocuments>b__1()
			{
				return ((RepairCard)this.card).CreateReport(this.<>4__this.ReportTemplateSelector.GetSelected(), 1);
			}

			// Token: 0x06001889 RID: 6281 RVA: 0x00042CC0 File Offset: 0x00040EC0
			internal Task<CashInOrder> <PrintDocuments>b__2()
			{
				return KassaModel.GetCashInOrder(this.<>4__this.Repair.prepaid_order.Value);
			}

			// Token: 0x0600188A RID: 6282 RVA: 0x00042CEC File Offset: 0x00040EEC
			internal Task<XtraReport> <PrintDocuments>b__4()
			{
				return ((RepairCard)this.card).CreateReport("rep_label", this.<>4__this.StickerCount);
			}

			// Token: 0x04000C65 RID: 3173
			public NewRepairViewModel <>4__this;

			// Token: 0x04000C66 RID: 3174
			public IRepairCard card;
		}

		// Token: 0x0200019C RID: 412
		[CompilerGenerated]
		private sealed class <>c__DisplayClass163_1
		{
			// Token: 0x0600188B RID: 6283 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass163_1()
			{
			}

			// Token: 0x0600188C RID: 6284 RVA: 0x00042D1C File Offset: 0x00040F1C
			internal Task<XtraReport> <PrintDocuments>b__3()
			{
				return this.pko.CreateReport();
			}

			// Token: 0x04000C67 RID: 3175
			public CashInOrder pko;
		}

		// Token: 0x0200019D RID: 413
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <PrintDocuments>d__163 : IAsyncStateMachine
		{
			// Token: 0x0600188D RID: 6285 RVA: 0x00042D34 File Offset: 0x00040F34
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NewRepairViewModel newRepairViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IRepairCard> awaiter;
					TaskAwaiter<XtraReport> awaiter2;
					TaskAwaiter<CashInOrder> awaiter3;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IRepairCard>);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<XtraReport>);
						this.<>1__state = -1;
						goto IL_137;
					case 2:
						awaiter3 = this.<>u__3;
						this.<>u__3 = default(TaskAwaiter<CashInOrder>);
						this.<>1__state = -1;
						goto IL_1FB;
					case 3:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<XtraReport>);
						this.<>1__state = -1;
						goto IL_278;
					case 4:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<XtraReport>);
						this.<>1__state = -1;
						goto IL_32C;
					default:
						this.<>8__1 = new NewRepairViewModel.<>c__DisplayClass163_0();
						this.<>8__1.<>4__this = this.<>4__this;
						newRepairViewModel.ShowWait();
						this.<report>5__2 = new XtraReport();
						awaiter = Task.Run<IRepairCard>(new Func<Task<IRepairCard>>(this.<>8__1.<PrintDocuments>b__0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IRepairCard>, NewRepairViewModel.<PrintDocuments>d__163>(ref awaiter, ref this);
							return;
						}
						break;
					}
					IRepairCard result = awaiter.GetResult();
					this.<>8__1.card = result;
					awaiter2 = Task.Run<XtraReport>(new Func<Task<XtraReport>>(this.<>8__1.<PrintDocuments>b__1)).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XtraReport>, NewRepairViewModel.<PrintDocuments>d__163>(ref awaiter2, ref this);
						return;
					}
					IL_137:
					XtraReport result2 = awaiter2.GetResult();
					this.<report>5__2.Pages.AddRange(result2.Pages);
					if (!newRepairViewModel.Repair.is_prepaid || !newRepairViewModel.PrintPko || newRepairViewModel.Repair.prepaid_order == null)
					{
						goto IL_29F;
					}
					this.<>8__2 = new NewRepairViewModel.<>c__DisplayClass163_1();
					awaiter3 = Task.Run<CashInOrder>(new Func<Task<CashInOrder>>(this.<>8__1.<PrintDocuments>b__2)).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__3 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<CashInOrder>, NewRepairViewModel.<PrintDocuments>d__163>(ref awaiter3, ref this);
						return;
					}
					IL_1FB:
					CashInOrder result3 = awaiter3.GetResult();
					this.<>8__2.pko = result3;
					awaiter2 = Task.Run<XtraReport>(new Func<Task<XtraReport>>(this.<>8__2.<PrintDocuments>b__3)).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XtraReport>, NewRepairViewModel.<PrintDocuments>d__163>(ref awaiter2, ref this);
						return;
					}
					IL_278:
					XtraReport result4 = awaiter2.GetResult();
					this.<report>5__2.Pages.AddRange(result4.Pages);
					this.<>8__2 = null;
					IL_29F:
					newRepairViewModel.HideWait();
					newRepairViewModel._reportPrintService.PrintPreview(this.<report>5__2, PrinterModel.Printer.Documents);
					if (!OfflineData.Instance.Settings.PrintRepStickers)
					{
						goto IL_343;
					}
					awaiter2 = Task.Run<XtraReport>(new Func<Task<XtraReport>>(this.<>8__1.<PrintDocuments>b__4)).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 4;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XtraReport>, NewRepairViewModel.<PrintDocuments>d__163>(ref awaiter2, ref this);
						return;
					}
					IL_32C:
					XtraReport result5 = awaiter2.GetResult();
					newRepairViewModel._reportPrintService.PrintPreview(result5, PrinterModel.Printer.Stickers);
					IL_343:;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<report>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<report>5__2 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x0600188E RID: 6286 RVA: 0x000430EC File Offset: 0x000412EC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000C68 RID: 3176
			public int <>1__state;

			// Token: 0x04000C69 RID: 3177
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000C6A RID: 3178
			public NewRepairViewModel <>4__this;

			// Token: 0x04000C6B RID: 3179
			private NewRepairViewModel.<>c__DisplayClass163_0 <>8__1;

			// Token: 0x04000C6C RID: 3180
			private NewRepairViewModel.<>c__DisplayClass163_1 <>8__2;

			// Token: 0x04000C6D RID: 3181
			private XtraReport <report>5__2;

			// Token: 0x04000C6E RID: 3182
			private TaskAwaiter<IRepairCard> <>u__1;

			// Token: 0x04000C6F RID: 3183
			private TaskAwaiter<XtraReport> <>u__2;

			// Token: 0x04000C70 RID: 3184
			private TaskAwaiter<CashInOrder> <>u__3;
		}

		// Token: 0x0200019E RID: 414
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <AddIntComment>d__164 : IAsyncStateMachine
		{
			// Token: 0x0600188F RID: 6287 RVA: 0x00043108 File Offset: 0x00041308
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NewRepairViewModel newRepairViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Bootstrapper.Container.Resolve<IIntCommentsService>().CreateRepairComment(newRepairViewModel.Repair.id, newRepairViewModel.IntComment).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, NewRepairViewModel.<AddIntComment>d__164>(ref awaiter, ref this);
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

			// Token: 0x06001890 RID: 6288 RVA: 0x000431D4 File Offset: 0x000413D4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000C71 RID: 3185
			public int <>1__state;

			// Token: 0x04000C72 RID: 3186
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000C73 RID: 3187
			public NewRepairViewModel <>4__this;

			// Token: 0x04000C74 RID: 3188
			private TaskAwaiter <>u__1;
		}

		// Token: 0x0200019F RID: 415
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SelectCustomerFromList>d__175 : IAsyncStateMachine
		{
			// Token: 0x06001891 RID: 6289 RVA: 0x000431F0 File Offset: 0x000413F0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NewRepairViewModel newRepairViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						newRepairViewModel.SwithEnableSearch();
						awaiter = newRepairViewModel.SetCustomer(this.customer.Id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, NewRepairViewModel.<SelectCustomerFromList>d__175>(ref awaiter, ref this);
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
					newRepairViewModel.UseClientData();
					newRepairViewModel.HideMatchShowOpenCard();
					newRepairViewModel.SwithEnableSearch();
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

			// Token: 0x06001892 RID: 6290 RVA: 0x000432C8 File Offset: 0x000414C8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000C75 RID: 3189
			public int <>1__state;

			// Token: 0x04000C76 RID: 3190
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000C77 RID: 3191
			public NewRepairViewModel <>4__this;

			// Token: 0x04000C78 RID: 3192
			public ICustomer customer;

			// Token: 0x04000C79 RID: 3193
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020001A0 RID: 416
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <MatchClick>d__178 : IAsyncStateMachine
		{
			// Token: 0x06001893 RID: 6291 RVA: 0x000432E4 File Offset: 0x000414E4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NewRepairViewModel newRepairViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (newRepairViewModel.SelectedMatch == null)
						{
							goto IL_175;
						}
						string text = this.obj as string;
						if (text != null && text == "True")
						{
							newRepairViewModel.Repair.type = newRepairViewModel.SelectedMatch.TypeId;
							newRepairViewModel.Repair.maker = newRepairViewModel.SelectedMatch.MakerId;
							newRepairViewModel.MakersChanged(null);
							newRepairViewModel.Repair.model = new int?(newRepairViewModel.SelectedMatch.ModelId);
							newRepairViewModel.Repair.serial_number = newRepairViewModel.SelectedMatch.SerialNumber;
							newRepairViewModel.Repair.ModelName = newRepairViewModel.SelectedMatch.DeviceModel;
							newRepairViewModel.Repair.is_repeat = true;
							newRepairViewModel.Repair.early = new int?(newRepairViewModel.SelectedMatch.Id);
						}
						newRepairViewModel.ClearClientStat();
						awaiter = newRepairViewModel.SetCustomer(newRepairViewModel.SelectedMatch.ClientId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, NewRepairViewModel.<MatchClick>d__178>(ref awaiter, ref this);
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
					newRepairViewModel.AfterClientSelect();
					newRepairViewModel.DeviceMatchVisible = false;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_175:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06001894 RID: 6292 RVA: 0x00043498 File Offset: 0x00041698
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000C7A RID: 3194
			public int <>1__state;

			// Token: 0x04000C7B RID: 3195
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000C7C RID: 3196
			public NewRepairViewModel <>4__this;

			// Token: 0x04000C7D RID: 3197
			public object obj;

			// Token: 0x04000C7E RID: 3198
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020001A1 RID: 417
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SelectRepairFromList>d__183 : IAsyncStateMachine
		{
			// Token: 0x06001895 RID: 6293 RVA: 0x000434B4 File Offset: 0x000416B4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NewRepairViewModel newRepairViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<PreviousRepair> awaiter;
					TaskAwaiter awaiter2;
					TaskAwaiter<List<IAttribute>> awaiter3;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<PreviousRepair>);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_17A;
					case 2:
						awaiter3 = this.<>u__3;
						this.<>u__3 = default(TaskAwaiter<List<IAttribute>>);
						this.<>1__state = -1;
						goto IL_208;
					default:
						awaiter = newRepairViewModel._workshopService.GetRepairInfo(this._repair.RepairId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<PreviousRepair>, NewRepairViewModel.<SelectRepairFromList>d__183>(ref awaiter, ref this);
							return;
						}
						break;
					}
					PreviousRepair result = awaiter.GetResult();
					this.<previousRepair>5__2 = result;
					if (this.<previousRepair>5__2 == null)
					{
						goto IL_22A;
					}
					newRepairViewModel.Repair.early = new int?(this.<previousRepair>5__2.Id);
					newRepairViewModel.Repair.type = this.<previousRepair>5__2.TypeId;
					newRepairViewModel.Repair.maker = this.<previousRepair>5__2.MakerId;
					newRepairViewModel.MakersChanged(null);
					newRepairViewModel.Repair.serial_number = this.<previousRepair>5__2.SerialNumber;
					newRepairViewModel.Repair.ModelName = this.<previousRepair>5__2.ModelName;
					awaiter2 = newRepairViewModel.SetCustomer(this.<previousRepair>5__2.CustomerId).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, NewRepairViewModel.<SelectRepairFromList>d__183>(ref awaiter2, ref this);
						return;
					}
					IL_17A:
					awaiter2.GetResult();
					newRepairViewModel.UseClientData();
					newRepairViewModel.HideMatchShowOpenCard();
					this.<>7__wrap2 = newRepairViewModel.Repair;
					awaiter3 = newRepairViewModel._additionalFieldsService.GetDeviceUiFields(this.<previousRepair>5__2.AdditionalFields, this.<previousRepair>5__2.TypeId).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__3 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<IAttribute>>, NewRepairViewModel.<SelectRepairFromList>d__183>(ref awaiter3, ref this);
						return;
					}
					IL_208:
					List<IAttribute> result2 = awaiter3.GetResult();
					this.<>7__wrap2.AdditionalFields = new ObservableCollection<object>(result2);
					this.<>7__wrap2 = null;
					IL_22A:;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<previousRepair>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<previousRepair>5__2 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06001896 RID: 6294 RVA: 0x00043744 File Offset: 0x00041944
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000C7F RID: 3199
			public int <>1__state;

			// Token: 0x04000C80 RID: 3200
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000C81 RID: 3201
			public NewRepairViewModel <>4__this;

			// Token: 0x04000C82 RID: 3202
			public WorkshopLite _repair;

			// Token: 0x04000C83 RID: 3203
			private PreviousRepair <previousRepair>5__2;

			// Token: 0x04000C84 RID: 3204
			private TaskAwaiter<PreviousRepair> <>u__1;

			// Token: 0x04000C85 RID: 3205
			private TaskAwaiter <>u__2;

			// Token: 0x04000C86 RID: 3206
			private workshop <>7__wrap2;

			// Token: 0x04000C87 RID: 3207
			private TaskAwaiter<List<IAttribute>> <>u__3;
		}

		// Token: 0x020001A2 RID: 418
		[CompilerGenerated]
		private sealed class <>c__DisplayClass185_0
		{
			// Token: 0x06001897 RID: 6295 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass185_0()
			{
			}

			// Token: 0x06001898 RID: 6296 RVA: 0x00043760 File Offset: 0x00041960
			internal Task<bool> <OpenRepairCard>b__0()
			{
				return this.permissionController.CanOpenRepairCard(this.<>4__this.SelectedMatch.Id);
			}

			// Token: 0x04000C88 RID: 3208
			public PermissionsController permissionController;

			// Token: 0x04000C89 RID: 3209
			public NewRepairViewModel <>4__this;
		}

		// Token: 0x020001A3 RID: 419
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OpenRepairCard>d__185 : IAsyncStateMachine
		{
			// Token: 0x06001899 RID: 6297 RVA: 0x00043788 File Offset: 0x00041988
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NewRepairViewModel newRepairViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						NewRepairViewModel.<>c__DisplayClass185_0 CS$<>8__locals1 = new NewRepairViewModel.<>c__DisplayClass185_0();
						CS$<>8__locals1.<>4__this = this.<>4__this;
						if (newRepairViewModel.SelectedMatch == null)
						{
							goto IL_EB;
						}
						CS$<>8__locals1.permissionController = new PermissionsController();
						awaiter = Task.Run<bool>(new Func<Task<bool>>(CS$<>8__locals1.<OpenRepairCard>b__0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, NewRepairViewModel.<OpenRepairCard>d__185>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<bool>);
						this.<>1__state = -1;
					}
					if (!awaiter.GetResult())
					{
						newRepairViewModel._toasterService.Info(Lang.t("NoPermission"));
					}
					else
					{
						newRepairViewModel._navigationService.NavigateRepairCard(newRepairViewModel.SelectedMatch.Id);
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_EB:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x0600189A RID: 6298 RVA: 0x000438A4 File Offset: 0x00041AA4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000C8A RID: 3210
			public int <>1__state;

			// Token: 0x04000C8B RID: 3211
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000C8C RID: 3212
			public NewRepairViewModel <>4__this;

			// Token: 0x04000C8D RID: 3213
			private TaskAwaiter<bool> <>u__1;
		}

		// Token: 0x020001A4 RID: 420
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <MakeOrderPhoto>d__186 : IAsyncStateMachine
		{
			// Token: 0x0600189B RID: 6299 RVA: 0x000438C0 File Offset: 0x00041AC0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NewRepairViewModel newRepairViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						this.<vm>5__2 = Bootstrapper.Container.Resolve<PhotoViewAddModel>();
						this.<vm>5__2.SetLimit(Auth.Config.rep_img_limit);
						if (newRepairViewModel._photoIds == null || newRepairViewModel._photoIds.Count <= 0)
						{
							goto IL_BE;
						}
						newRepairViewModel.ShowWait();
						awaiter = this.<vm>5__2.LoadData(newRepairViewModel._photoIds).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, NewRepairViewModel.<MakeOrderPhoto>d__186>(ref awaiter, ref this);
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
					newRepairViewModel.HideWait();
					IL_BE:
					newRepairViewModel._windowedDocumentService.ShowNewDocument("PhotoAddView", this.<vm>5__2, newRepairViewModel, null);
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<vm>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<vm>5__2 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x0600189C RID: 6300 RVA: 0x000439F0 File Offset: 0x00041BF0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000C8E RID: 3214
			public int <>1__state;

			// Token: 0x04000C8F RID: 3215
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000C90 RID: 3216
			public NewRepairViewModel <>4__this;

			// Token: 0x04000C91 RID: 3217
			private PhotoViewAddModel <vm>5__2;

			// Token: 0x04000C92 RID: 3218
			private TaskAwaiter <>u__1;
		}
	}
}
