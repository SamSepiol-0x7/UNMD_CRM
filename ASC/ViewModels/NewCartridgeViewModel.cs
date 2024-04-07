using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using ASC.Common.Interfaces;
using ASC.Common.SimpleClasses;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Objects.Converters;
using ASC.Options;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using Autofac;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.XtraReports.UI;

namespace ASC.ViewModels
{
	// Token: 0x02000479 RID: 1145
	public class NewCartridgeViewModel : AcceptNewViewModelBase, IRefreshable, ICustomerSelect
	{
		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x06002CE5 RID: 11493 RVA: 0x00090978 File Offset: 0x0008EB78
		// (set) Token: 0x06002CE6 RID: 11494 RVA: 0x0009098C File Offset: 0x0008EB8C
		public ICartridgeCard NewCartridge
		{
			[CompilerGenerated]
			get
			{
				return this.<NewCartridge>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<NewCartridge>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1850501322;
				IL_13:
				switch ((num ^ -1264502868) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					IL_32:
					num = -392627513;
					goto IL_13;
				case 2:
					return;
				}
				this.<NewCartridge>k__BackingField = value;
				this.RaisePropertyChanged("NewCartridge");
			}
		}

		// Token: 0x17000E71 RID: 3697
		// (get) Token: 0x06002CE7 RID: 11495 RVA: 0x000909E8 File Offset: 0x0008EBE8
		// (set) Token: 0x06002CE8 RID: 11496 RVA: 0x000909FC File Offset: 0x0008EBFC
		public int NewCount
		{
			get
			{
				return this._newCount;
			}
			set
			{
				if (this._newCount == value)
				{
					return;
				}
				this._newCount = value;
				this.RaisePropertyChanged("NewCount");
				if (value <= 1)
				{
					this.SnInputEnable = true;
				}
				else
				{
					this.NewSn = "";
					this.SnInputEnable = false;
				}
			}
		}

		// Token: 0x17000E72 RID: 3698
		// (get) Token: 0x06002CE9 RID: 11497 RVA: 0x00090A48 File Offset: 0x0008EC48
		// (set) Token: 0x06002CEA RID: 11498 RVA: 0x00090A5C File Offset: 0x0008EC5C
		public string NewSn
		{
			[CompilerGenerated]
			get
			{
				return this.<NewSn>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<NewSn>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<NewSn>k__BackingField = value;
				this.RaisePropertyChanged("NewSn");
			}
		}

		// Token: 0x17000E73 RID: 3699
		// (get) Token: 0x06002CEB RID: 11499 RVA: 0x00090A8C File Offset: 0x0008EC8C
		// (set) Token: 0x06002CEC RID: 11500 RVA: 0x00090AA0 File Offset: 0x0008ECA0
		public int SelectedCompany
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedCompany>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedCompany>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -2113777901;
				IL_10:
				switch ((num ^ -2011967359) % 4)
				{
				case 0:
					goto IL_0B;
				case 2:
					return;
				case 3:
					IL_2F:
					num = -1367721596;
					goto IL_10;
				}
				this.<SelectedCompany>k__BackingField = value;
				this.RaisePropertyChanged("SelectedCompany");
			}
		}

		// Token: 0x17000E74 RID: 3700
		// (get) Token: 0x06002CED RID: 11501 RVA: 0x00090AF8 File Offset: 0x0008ECF8
		// (set) Token: 0x06002CEE RID: 11502 RVA: 0x00090B0C File Offset: 0x0008ED0C
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

		// Token: 0x17000E75 RID: 3701
		// (get) Token: 0x06002CEF RID: 11503 RVA: 0x00090B38 File Offset: 0x0008ED38
		// (set) Token: 0x06002CF0 RID: 11504 RVA: 0x00090B4C File Offset: 0x0008ED4C
		public int SelectedPaymentType
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedPaymentType>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedPaymentType>k__BackingField == value)
				{
					return;
				}
				this.<SelectedPaymentType>k__BackingField = value;
				this.RaisePropertyChanged("SelectedPaymentType");
			}
		}

		// Token: 0x17000E76 RID: 3702
		// (get) Token: 0x06002CF1 RID: 11505 RVA: 0x00090B78 File Offset: 0x0008ED78
		// (set) Token: 0x06002CF2 RID: 11506 RVA: 0x00090B8C File Offset: 0x0008ED8C
		public List<ICartridgeCard> CartridgeCards
		{
			[CompilerGenerated]
			get
			{
				return this.<CartridgeCards>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<CartridgeCards>k__BackingField, value))
				{
					return;
				}
				this.<CartridgeCards>k__BackingField = value;
				this.RaisePropertyChanged("CartridgeCards");
			}
		}

		// Token: 0x17000E77 RID: 3703
		// (get) Token: 0x06002CF3 RID: 11507 RVA: 0x00090BBC File Offset: 0x0008EDBC
		// (set) Token: 0x06002CF4 RID: 11508 RVA: 0x00090BD0 File Offset: 0x0008EDD0
		public IManufacturer SelectedMaker
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedMaker>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedMaker>k__BackingField, value))
				{
					return;
				}
				this.<SelectedMaker>k__BackingField = value;
				this.RaisePropertyChanged("ModelEnable");
				this.RaisePropertyChanged("SelectedMaker");
			}
		}

		// Token: 0x17000E78 RID: 3704
		// (get) Token: 0x06002CF5 RID: 11509 RVA: 0x00090C0C File Offset: 0x0008EE0C
		public bool ModelEnable
		{
			get
			{
				return this.SelectedMaker != null;
			}
		}

		// Token: 0x17000E79 RID: 3705
		// (get) Token: 0x06002CF6 RID: 11510 RVA: 0x00090C24 File Offset: 0x0008EE24
		// (set) Token: 0x06002CF7 RID: 11511 RVA: 0x00090C38 File Offset: 0x0008EE38
		public ObservableCollection<Cartridge> Cartridges
		{
			[CompilerGenerated]
			get
			{
				return this.<Cartridges>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Cartridges>k__BackingField, value))
				{
					return;
				}
				this.<Cartridges>k__BackingField = value;
				this.RaisePropertyChanged("Cartridges");
			}
		}

		// Token: 0x17000E7A RID: 3706
		// (get) Token: 0x06002CF8 RID: 11512 RVA: 0x00090C68 File Offset: 0x0008EE68
		// (set) Token: 0x06002CF9 RID: 11513 RVA: 0x00090C7C File Offset: 0x0008EE7C
		public Cartridge SelectedCartridge
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedCartridge>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<SelectedCartridge>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -903703127;
				IL_13:
				switch ((num ^ -453300849) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					IL_32:
					this.<SelectedCartridge>k__BackingField = value;
					this.RaisePropertyChanged("SelectedCartridge");
					num = -1891692984;
					goto IL_13;
				case 2:
					return;
				}
			}
		}

		// Token: 0x17000E7B RID: 3707
		// (get) Token: 0x06002CFA RID: 11514 RVA: 0x00090CD8 File Offset: 0x0008EED8
		// (set) Token: 0x06002CFB RID: 11515 RVA: 0x00090CEC File Offset: 0x0008EEEC
		public int? SelectedVisitSource
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedVisitSource>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<SelectedVisitSource>k__BackingField, value))
				{
					return;
				}
				this.<SelectedVisitSource>k__BackingField = value;
				this.RaisePropertyChanged("SelectedVisitSource");
			}
		}

		// Token: 0x17000E7C RID: 3708
		// (get) Token: 0x06002CFC RID: 11516 RVA: 0x00090D1C File Offset: 0x0008EF1C
		// (set) Token: 0x06002CFD RID: 11517 RVA: 0x00090D30 File Offset: 0x0008EF30
		public int? SelectedMaster
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedMaster>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<SelectedMaster>k__BackingField, value))
				{
					return;
				}
				this.<SelectedMaster>k__BackingField = value;
				this.RaisePropertyChanged("SelectedMaster");
			}
		}

		// Token: 0x17000E7D RID: 3709
		// (get) Token: 0x06002CFE RID: 11518 RVA: 0x00090D60 File Offset: 0x0008EF60
		// (set) Token: 0x06002CFF RID: 11519 RVA: 0x00090D74 File Offset: 0x0008EF74
		public bool ExpressRepair
		{
			[CompilerGenerated]
			get
			{
				return this.<ExpressRepair>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ExpressRepair>k__BackingField == value)
				{
					return;
				}
				this.<ExpressRepair>k__BackingField = value;
				this.RaisePropertyChanged("ExpressRepair");
			}
		}

		// Token: 0x17000E7E RID: 3710
		// (get) Token: 0x06002D00 RID: 11520 RVA: 0x00090DA0 File Offset: 0x0008EFA0
		// (set) Token: 0x06002D01 RID: 11521 RVA: 0x00090DB4 File Offset: 0x0008EFB4
		public Dictionary<int, string> HistoryOptions
		{
			[CompilerGenerated]
			get
			{
				return this.<HistoryOptions>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<HistoryOptions>k__BackingField, value))
				{
					return;
				}
				this.<HistoryOptions>k__BackingField = value;
				this.RaisePropertyChanged("HistoryOptions");
			}
		}

		// Token: 0x17000E7F RID: 3711
		// (get) Token: 0x06002D02 RID: 11522 RVA: 0x00090DE4 File Offset: 0x0008EFE4
		// (set) Token: 0x06002D03 RID: 11523 RVA: 0x00090DF8 File Offset: 0x0008EFF8
		public decimal Total
		{
			[CompilerGenerated]
			get
			{
				return this.<Total>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<Total>k__BackingField, value))
				{
					return;
				}
				this.<Total>k__BackingField = value;
				this.RaisePropertyChanged("Total");
			}
		}

		// Token: 0x17000E80 RID: 3712
		// (get) Token: 0x06002D04 RID: 11524 RVA: 0x00090E28 File Offset: 0x0008F028
		// (set) Token: 0x06002D05 RID: 11525 RVA: 0x00090E3C File Offset: 0x0008F03C
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

		// Token: 0x17000E81 RID: 3713
		// (get) Token: 0x06002D06 RID: 11526 RVA: 0x00090E68 File Offset: 0x0008F068
		// (set) Token: 0x06002D07 RID: 11527 RVA: 0x00090E7C File Offset: 0x0008F07C
		public bool SnInputEnable
		{
			[CompilerGenerated]
			get
			{
				return this.<SnInputEnable>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SnInputEnable>k__BackingField == value)
				{
					return;
				}
				this.<SnInputEnable>k__BackingField = value;
				this.RaisePropertyChanged("SnInputEnable");
			}
		}

		// Token: 0x06002D08 RID: 11528 RVA: 0x00090EA8 File Offset: 0x0008F0A8
		public NewCartridgeViewModel(ICartridgeService cartridgeService, IWindowedDocumentService windowedDocumentService, IToasterService toasterService, ICartridgeCardService cartridgeCardService, IReportPrintService reportPrintService)
		{
			this._cartridgeService = cartridgeService;
			this._windowedDocumentService = windowedDocumentService;
			this._toasterService = toasterService;
			this._cartridgeCardService = cartridgeCardService;
			this._reportPrintService = reportPrintService;
			this.HistoryOptions = cartridgeService.GetHistoryOptions();
			this.SetViewName("ReceptionOfCartridges");
			this.NewCount = 1;
			this.StickerCount = 1;
			this.NewCartridge = new Cartridge();
			base.PhoneOptions = new PhoneOptions().GetAllOptions();
			this.Cartridges = new ObservableCollection<Cartridge>();
			this.Cartridges.CollectionChanged += this.CartridgesOnCollectionChanged;
			this._searchTimer = new DispatcherTimer();
			this._searchTimer.Tick += this.searchTimer_Tick;
			this._searchTimer.Interval = TimeSpan.FromMilliseconds(300.0);
		}

		// Token: 0x06002D09 RID: 11529 RVA: 0x00090F80 File Offset: 0x0008F180
		private void CartridgesOnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			this.PriceChanged();
			if (e.OldItems != null)
			{
				foreach (object obj in e.OldItems)
				{
					((INotifyPropertyChanged)obj).PropertyChanged -= this.item_PropertyChanged;
				}
			}
			if (e.NewItems != null)
			{
				foreach (object obj2 in e.NewItems)
				{
					((INotifyPropertyChanged)obj2).PropertyChanged += this.item_PropertyChanged;
				}
			}
		}

		// Token: 0x06002D0A RID: 11530 RVA: 0x0009104C File Offset: 0x0008F24C
		public void item_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			this.PriceChanged();
		}

		// Token: 0x06002D0B RID: 11531 RVA: 0x00091060 File Offset: 0x0008F260
		public override void OnLoad()
		{
			base.OnLoad();
			if (!base.ViewLoaded)
			{
				this.BgInit();
				return;
			}
		}

		// Token: 0x06002D0C RID: 11532 RVA: 0x00091084 File Offset: 0x0008F284
		private void BgInit()
		{
			NewCartridgeViewModel.<BgInit>d__80 <BgInit>d__;
			<BgInit>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<BgInit>d__.<>4__this = this;
			<BgInit>d__.<>1__state = -1;
			<BgInit>d__.<>t__builder.Start<NewCartridgeViewModel.<BgInit>d__80>(ref <BgInit>d__);
		}

		// Token: 0x06002D0D RID: 11533 RVA: 0x000910BC File Offset: 0x0008F2BC
		[AsyncCommand]
		public Task MakeOrder()
		{
			NewCartridgeViewModel.<MakeOrder>d__81 <MakeOrder>d__;
			<MakeOrder>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<MakeOrder>d__.<>4__this = this;
			<MakeOrder>d__.<>1__state = -1;
			<MakeOrder>d__.<>t__builder.Start<NewCartridgeViewModel.<MakeOrder>d__81>(ref <MakeOrder>d__);
			return <MakeOrder>d__.<>t__builder.Task;
		}

		// Token: 0x06002D0E RID: 11534 RVA: 0x00091100 File Offset: 0x0008F300
		private void PrintDocument(List<int> ids)
		{
			NewCartridgeViewModel.<PrintDocument>d__82 <PrintDocument>d__;
			<PrintDocument>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<PrintDocument>d__.<>4__this = this;
			<PrintDocument>d__.ids = ids;
			<PrintDocument>d__.<>1__state = -1;
			<PrintDocument>d__.<>t__builder.Start<NewCartridgeViewModel.<PrintDocument>d__82>(ref <PrintDocument>d__);
		}

		// Token: 0x06002D0F RID: 11535 RVA: 0x00040D04 File Offset: 0x0003EF04
		private void AddTelToList(string phone, int mask)
		{
			base.Customer.AddTelToList(phone, mask);
		}

		// Token: 0x06002D10 RID: 11536 RVA: 0x00091140 File Offset: 0x0008F340
		private bool CheckManyFields()
		{
			if (this.SelectedCompany == 0)
			{
				this._toasterService.Info(Lang.t("SelectCompany"));
				return false;
			}
			if (!this.Cartridges.Any<Cartridge>())
			{
				this._toasterService.Info(Lang.t("AddItem"));
				return false;
			}
			using (IEnumerator<Cartridge> enumerator = this.Cartridges.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Cartridge cartridge = enumerator.Current;
					if (Auth.Config.is_cartridge_sn_req && string.IsNullOrEmpty(cartridge.SerialNumber))
					{
						this._toasterService.Info(Lang.t("InputSerialNumber") + " " + cartridge.Name);
						return false;
					}
					if (Auth.Config.is_cartridge_sn_req && this.Cartridges.Any((Cartridge i) => i.SerialNumber == cartridge.SerialNumber && i.CardId == cartridge.CardId && !i.Equals(cartridge)))
					{
						this._toasterService.Info("Обнаружены картриджи с одинаковыми серийными номерами");
						return false;
					}
				}
				return true;
			}
			bool result;
			return result;
		}

		// Token: 0x06002D11 RID: 11537 RVA: 0x00091260 File Offset: 0x0008F460
		[Command]
		public void AddCartridgeToList()
		{
			if (!this.CheckFields())
			{
				return;
			}
			for (int i = 0; i < this.NewCount; i++)
			{
				Cartridge cartridge = new Cartridge(this.NewCartridge);
				cartridge.SerialNumber = this.NewSn;
				IManufacturer selectedMaker = this.SelectedMaker;
				cartridge.MakerName = ((selectedMaker != null) ? selectedMaker.Name : null);
				Cartridge item = cartridge;
				this.Cartridges.Add(item);
			}
			this.NewCount = 1;
			this.NewSn = "";
			this.NewCartridge = new Cartridge();
		}

		// Token: 0x06002D12 RID: 11538 RVA: 0x000912E0 File Offset: 0x0008F4E0
		public bool CheckFields()
		{
			if (this.SelectedMaker == null)
			{
				this._toasterService.Info(Lang.t("SelectMaker"));
				return false;
			}
			if (this.NewCartridge == null || this.NewCartridge.CardId == 0)
			{
				this._toasterService.Info(Lang.t("SelectCartridge"));
				return false;
			}
			if (this.NewCount <= 0)
			{
				this._toasterService.Info(Lang.t("Count"));
				return false;
			}
			return true;
		}

		// Token: 0x06002D13 RID: 11539 RVA: 0x0009135C File Offset: 0x0008F55C
		[Command]
		public void CreateCartridgeCard()
		{
			CartridgeCardViewModel cartridgeCardViewModel = Bootstrapper.Container.Resolve<CartridgeCardViewModel>();
			cartridgeCardViewModel.SetMakerId(this.SelectedMaker.Id);
			cartridgeCardViewModel.SetRefreshOnClose(true);
			this._windowedDocumentService.ShowNewDocument("CartridgeCardView", cartridgeCardViewModel, this, null);
		}

		// Token: 0x06002D14 RID: 11540 RVA: 0x00090C0C File Offset: 0x0008EE0C
		public bool CanCreateCartridgeCard()
		{
			return this.SelectedMaker != null;
		}

		// Token: 0x06002D15 RID: 11541 RVA: 0x000913A0 File Offset: 0x0008F5A0
		[Command]
		public void EditCartridgeCard()
		{
			CartridgeCardViewModel cartridgeCardViewModel = Bootstrapper.Container.Resolve<CartridgeCardViewModel>();
			cartridgeCardViewModel.SetCardId(this.NewCartridge.CardId);
			cartridgeCardViewModel.SetRefreshOnClose(true);
			this._windowedDocumentService.ShowNewDocument("CartridgeCardView", cartridgeCardViewModel, this, null);
		}

		// Token: 0x06002D16 RID: 11542 RVA: 0x000913E4 File Offset: 0x0008F5E4
		public bool CanEditCartridgeCard()
		{
			ICartridgeCard newCartridge = this.NewCartridge;
			return newCartridge != null && newCartridge.CardId > 0;
		}

		// Token: 0x06002D17 RID: 11543 RVA: 0x00091408 File Offset: 0x0008F608
		[Command]
		public void CardIdChanged()
		{
			base.RaiseCanExecuteChanged(() => this.EditCartridgeCard());
		}

		// Token: 0x06002D18 RID: 11544 RVA: 0x00091450 File Offset: 0x0008F650
		[Command]
		public void NewMakerChanged()
		{
			if (this.SelectedMaker != null)
			{
				goto IL_2C;
			}
			IL_08:
			int num = 148870993;
			IL_0D:
			switch ((num ^ 733440082) % 4)
			{
			case 0:
				goto IL_08;
			case 2:
				IL_2C:
				base.ShowWait();
				num = 619341779;
				goto IL_0D;
			case 3:
				return;
			}
			Task.Run<IEnumerable<ICartridgeCard>>(() => this._cartridgeCardService.GetCards(this.SelectedMaker.Id, false, "")).ContinueWith(delegate(Task<IEnumerable<ICartridgeCard>> t)
			{
				this.CartridgeCards = new List<ICartridgeCard>(t.Result);
				base.RaisePropertyChanged<bool>(() => this.ModelEnable);
				base.HideWait();
			}, TaskScheduler.FromCurrentSynchronizationContext());
		}

		// Token: 0x06002D19 RID: 11545 RVA: 0x000914C0 File Offset: 0x0008F6C0
		public void DataRefresh()
		{
			this.NewMakerChanged();
		}

		// Token: 0x06002D1A RID: 11546 RVA: 0x000914D4 File Offset: 0x0008F6D4
		[Command]
		public void RemoveCartridge()
		{
			if (this.SelectedCartridge != null)
			{
				goto IL_2C;
			}
			IL_08:
			int num = -1637702003;
			IL_0D:
			switch ((num ^ -525890076) % 4)
			{
			case 1:
				return;
			case 2:
				goto IL_08;
			case 3:
				IL_2C:
				this.Cartridges.Remove(this.SelectedCartridge);
				num = -395125476;
				goto IL_0D;
			}
		}

		// Token: 0x06002D1B RID: 11547 RVA: 0x00091528 File Offset: 0x0008F728
		public void SelectCustomerFromList(ICustomer customer)
		{
			NewCartridgeViewModel.<SelectCustomerFromList>d__95 <SelectCustomerFromList>d__;
			<SelectCustomerFromList>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SelectCustomerFromList>d__.<>4__this = this;
			<SelectCustomerFromList>d__.customer = customer;
			<SelectCustomerFromList>d__.<>1__state = -1;
			<SelectCustomerFromList>d__.<>t__builder.Start<NewCartridgeViewModel.<SelectCustomerFromList>d__95>(ref <SelectCustomerFromList>d__);
		}

		// Token: 0x06002D1C RID: 11548 RVA: 0x00091568 File Offset: 0x0008F768
		[Command]
		public void UnsetMaster()
		{
			this.SelectedMaster = null;
		}

		// Token: 0x06002D1D RID: 11549 RVA: 0x00091584 File Offset: 0x0008F784
		[Command]
		public void PriceChanged()
		{
			this.Total = Fn.FormatSumm(this.Cartridges.Sum((Cartridge c) => c.TotalCost));
		}

		// Token: 0x06002D1E RID: 11550 RVA: 0x000915C8 File Offset: 0x0008F7C8
		[Command]
		public void SnGotFocus()
		{
			Messenger.Default.Send(new ASC.Common.SimpleClasses.Message(null, MessageType.StopBarcodeListen));
			if (Auth.Config.auto_switch_layout)
			{
				InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-US"));
			}
		}

		// Token: 0x06002D1F RID: 11551 RVA: 0x00091608 File Offset: 0x0008F808
		[Command]
		public void SnLostFocus()
		{
			Messenger.Default.Send(new ASC.Common.SimpleClasses.Message(null, MessageType.StartBarcodeListen));
		}

		// Token: 0x06002D20 RID: 11552 RVA: 0x00091628 File Offset: 0x0008F828
		[Command]
		public void SnKeyUp()
		{
			if (!string.IsNullOrEmpty(this.NewSn))
			{
				goto IL_31;
			}
			IL_0D:
			int num = 2102889094;
			IL_12:
			switch ((num ^ 2118594144) % 4)
			{
			case 0:
				goto IL_0D;
			case 2:
				return;
			case 3:
				IL_31:
				this.StopSearchTimer();
				this.StartSearchTimer();
				num = 2081634617;
				goto IL_12;
			}
		}

		// Token: 0x06002D21 RID: 11553 RVA: 0x0009167C File Offset: 0x0008F87C
		private void SearchBySn()
		{
			base.ShowWait();
			Task.Run<Cartridge>(() => this._cartridgeService.GetCartridge(this.NewSn)).ContinueWith(delegate(Task<Cartridge> t)
			{
				base.HideWait();
				if (t.Result == null)
				{
					return;
				}
				Cartridge result = t.Result;
				result.SelectedHistoryOption = new int?(2);
				this.Cartridges.Add(result);
				this.ClearNewSn();
			}, TaskScheduler.FromCurrentSynchronizationContext());
		}

		// Token: 0x06002D22 RID: 11554 RVA: 0x000916B8 File Offset: 0x0008F8B8
		private void ClearNewSn()
		{
			this.NewSn = "";
		}

		// Token: 0x06002D23 RID: 11555 RVA: 0x000916D0 File Offset: 0x0008F8D0
		private void searchTimer_Tick(object sender, EventArgs e)
		{
			this.StopSearchTimer();
			this.OnSearchTimer();
		}

		// Token: 0x06002D24 RID: 11556 RVA: 0x000916EC File Offset: 0x0008F8EC
		public void OnSearchTimer()
		{
			if (this.NewSn.Length != 12)
			{
				this.SearchBySn();
				return;
			}
			if (!Barcode.IsAscCode(this.NewSn))
			{
				this.SearchBySn();
				return;
			}
			if (Barcode.GetTypeFromCode(this.NewSn) == 3)
			{
				int id = Barcode.GetIdFromCode(this.NewSn);
				base.ShowWait();
				Task.Run<Cartridge>(() => this._cartridgeService.GetCartridge(id)).ContinueWith(delegate(Task<Cartridge> t)
				{
					base.HideWait();
					if (t.Result != null)
					{
						Cartridge result = t.Result;
						result.SelectedHistoryOption = new int?(2);
						this.Cartridges.Add(result);
						this.ClearNewSn();
						return;
					}
					this.SearchBySn();
				}, TaskScheduler.FromCurrentSynchronizationContext());
				return;
			}
			this.SearchBySn();
		}

		// Token: 0x06002D25 RID: 11557 RVA: 0x00091784 File Offset: 0x0008F984
		public void StopSearchTimer()
		{
			DispatcherTimer searchTimer = this._searchTimer;
			if (searchTimer == null)
			{
				return;
			}
			searchTimer.Stop();
		}

		// Token: 0x06002D26 RID: 11558 RVA: 0x000917A4 File Offset: 0x0008F9A4
		public void StartSearchTimer()
		{
			DispatcherTimer searchTimer = this._searchTimer;
			if (searchTimer == null)
			{
				return;
			}
			searchTimer.Start();
		}

		// Token: 0x06002D27 RID: 11559 RVA: 0x000917C4 File Offset: 0x0008F9C4
		[Command]
		public void SetEmptySn()
		{
			if (this.SelectedCartridge != null)
			{
				goto IL_2C;
			}
			IL_08:
			int num = 166104309;
			IL_0D:
			switch ((num ^ 692608026) % 4)
			{
			case 0:
				goto IL_08;
			case 1:
				IL_2C:
				this.SelectedCartridge.SerialNumber = Lang.t("NoSn");
				num = 459772772;
				goto IL_0D;
			case 3:
				return;
			}
		}

		// Token: 0x06002D28 RID: 11560 RVA: 0x0009181C File Offset: 0x0008FA1C
		[CompilerGenerated]
		private Task<IEnumerable<ICartridgeCard>> <NewMakerChanged>b__92_0()
		{
			return this._cartridgeCardService.GetCards(this.SelectedMaker.Id, false, "");
		}

		// Token: 0x06002D29 RID: 11561 RVA: 0x00091848 File Offset: 0x0008FA48
		[CompilerGenerated]
		private void <NewMakerChanged>b__92_1(Task<IEnumerable<ICartridgeCard>> t)
		{
			this.CartridgeCards = new List<ICartridgeCard>(t.Result);
			base.RaisePropertyChanged<bool>(() => this.ModelEnable);
			base.HideWait();
		}

		// Token: 0x06002D2A RID: 11562 RVA: 0x000918A4 File Offset: 0x0008FAA4
		[CompilerGenerated]
		private Task<Cartridge> <SearchBySn>b__101_0()
		{
			return this._cartridgeService.GetCartridge(this.NewSn);
		}

		// Token: 0x06002D2B RID: 11563 RVA: 0x000918C4 File Offset: 0x0008FAC4
		[CompilerGenerated]
		private void <SearchBySn>b__101_1(Task<Cartridge> t)
		{
			base.HideWait();
			if (t.Result == null)
			{
				return;
			}
			Cartridge result = t.Result;
			result.SelectedHistoryOption = new int?(2);
			this.Cartridges.Add(result);
			this.ClearNewSn();
		}

		// Token: 0x06002D2C RID: 11564 RVA: 0x00091908 File Offset: 0x0008FB08
		[CompilerGenerated]
		private void <OnSearchTimer>b__104_1(Task<Cartridge> t)
		{
			base.HideWait();
			if (t.Result != null)
			{
				Cartridge result = t.Result;
				result.SelectedHistoryOption = new int?(2);
				this.Cartridges.Add(result);
				this.ClearNewSn();
				return;
			}
			this.SearchBySn();
		}

		// Token: 0x04001919 RID: 6425
		private readonly ICartridgeService _cartridgeService;

		// Token: 0x0400191A RID: 6426
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x0400191B RID: 6427
		private readonly IToasterService _toasterService;

		// Token: 0x0400191C RID: 6428
		private readonly ICartridgeCardService _cartridgeCardService;

		// Token: 0x0400191D RID: 6429
		private readonly IReportPrintService _reportPrintService;

		// Token: 0x0400191E RID: 6430
		private DispatcherTimer _searchTimer;

		// Token: 0x0400191F RID: 6431
		private int _newCount;

		// Token: 0x04001920 RID: 6432
		[CompilerGenerated]
		private ICartridgeCard <NewCartridge>k__BackingField;

		// Token: 0x04001921 RID: 6433
		[CompilerGenerated]
		private string <NewSn>k__BackingField;

		// Token: 0x04001922 RID: 6434
		[CompilerGenerated]
		private int <SelectedCompany>k__BackingField;

		// Token: 0x04001923 RID: 6435
		[CompilerGenerated]
		private int <SelectedOffice>k__BackingField;

		// Token: 0x04001924 RID: 6436
		[CompilerGenerated]
		private int <SelectedPaymentType>k__BackingField;

		// Token: 0x04001925 RID: 6437
		[CompilerGenerated]
		private List<ICartridgeCard> <CartridgeCards>k__BackingField;

		// Token: 0x04001926 RID: 6438
		[CompilerGenerated]
		private IManufacturer <SelectedMaker>k__BackingField;

		// Token: 0x04001927 RID: 6439
		[CompilerGenerated]
		private ObservableCollection<Cartridge> <Cartridges>k__BackingField;

		// Token: 0x04001928 RID: 6440
		[CompilerGenerated]
		private Cartridge <SelectedCartridge>k__BackingField;

		// Token: 0x04001929 RID: 6441
		[CompilerGenerated]
		private int? <SelectedVisitSource>k__BackingField;

		// Token: 0x0400192A RID: 6442
		[CompilerGenerated]
		private int? <SelectedMaster>k__BackingField;

		// Token: 0x0400192B RID: 6443
		[CompilerGenerated]
		private bool <ExpressRepair>k__BackingField;

		// Token: 0x0400192C RID: 6444
		[CompilerGenerated]
		private Dictionary<int, string> <HistoryOptions>k__BackingField;

		// Token: 0x0400192D RID: 6445
		[CompilerGenerated]
		private decimal <Total>k__BackingField;

		// Token: 0x0400192E RID: 6446
		[CompilerGenerated]
		private int <StickerCount>k__BackingField;

		// Token: 0x0400192F RID: 6447
		[CompilerGenerated]
		private bool <SnInputEnable>k__BackingField;

		// Token: 0x0200047A RID: 1146
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <BgInit>d__80 : IAsyncStateMachine
		{
			// Token: 0x06002D2D RID: 11565 RVA: 0x00091950 File Offset: 0x0008FB50
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NewCartridgeViewModel newCartridgeViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<IManufacturer>> awaiter;
					TaskAwaiter<IDevice> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<IEnumerable<IManufacturer>>);
							this.<>1__state = -1;
							goto IL_E0;
						}
						newCartridgeViewModel.SetCustomer(ClientsModel.DefaultCustomer().Client2CustomerCard());
						awaiter2 = newCartridgeViewModel._workshopService.GetRefillDevice().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IDevice>, NewCartridgeViewModel.<BgInit>d__80>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IDevice>);
						this.<>1__state = -1;
					}
					IDevice result = awaiter2.GetResult();
					if (result == null)
					{
						newCartridgeViewModel._toasterService.Error(Lang.t("CartridgeMakersWarning"));
						goto IL_F6;
					}
					awaiter = newCartridgeViewModel._workshopService.GetManufacturers(result.CompanyList).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<IManufacturer>>, NewCartridgeViewModel.<BgInit>d__80>(ref awaiter, ref this);
						return;
					}
					IL_E0:
					IEnumerable<IManufacturer> result2 = awaiter.GetResult();
					newCartridgeViewModel.Makers = new ObservableCollection<IManufacturer>(result2);
					IL_F6:
					newCartridgeViewModel.Masters = new List<ASC.SimpleClasses.UserMaster>(UsersModel.LoadMasters(false));
					newCartridgeViewModel.SelectedOffice = OfflineData.Instance.Employee.OfficeId;
					newCartridgeViewModel.SelectedCompany = OfflineData.Instance.GetSelectedCompany();
					newCartridgeViewModel.SetViewLoaded(true);
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

			// Token: 0x06002D2E RID: 11566 RVA: 0x00091AFC File Offset: 0x0008FCFC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001930 RID: 6448
			public int <>1__state;

			// Token: 0x04001931 RID: 6449
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001932 RID: 6450
			public NewCartridgeViewModel <>4__this;

			// Token: 0x04001933 RID: 6451
			private TaskAwaiter<IDevice> <>u__1;

			// Token: 0x04001934 RID: 6452
			private TaskAwaiter<IEnumerable<IManufacturer>> <>u__2;
		}

		// Token: 0x0200047B RID: 1147
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <MakeOrder>d__81 : IAsyncStateMachine
		{
			// Token: 0x06002D2F RID: 11567 RVA: 0x00091B18 File Offset: 0x0008FD18
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NewCartridgeViewModel newCartridgeViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<Result> awaiter;
					if (num != 0)
					{
						if (!newCartridgeViewModel.CheckManyFields())
						{
							goto IL_1E4;
						}
						if (newCartridgeViewModel.Customer.Id == 0)
						{
							ClientsModel clientsModel = new ClientsModel();
							if (!string.IsNullOrEmpty(newCartridgeViewModel.Customer.Phone))
							{
								newCartridgeViewModel.AddTelToList(newCartridgeViewModel.Customer.Phone, newCartridgeViewModel.Customer.PhoneMask);
							}
							if (!string.IsNullOrEmpty(newCartridgeViewModel.Customer.Phone2))
							{
								newCartridgeViewModel.AddTelToList(newCartridgeViewModel.Customer.Phone2, newCartridgeViewModel.Customer.Phone2Mask);
							}
							string text = clientsModel.CheckFields(newCartridgeViewModel.Customer);
							if (!string.IsNullOrEmpty(text))
							{
								newCartridgeViewModel._toasterService.Info(text);
								goto IL_1E4;
							}
							newCartridgeViewModel.Customer.Id = clientsModel.CreateNewClient(newCartridgeViewModel.Customer);
							if (newCartridgeViewModel.Customer == null || newCartridgeViewModel.Customer.Id == 0)
							{
								goto IL_1E4;
							}
						}
						awaiter = newCartridgeViewModel._cartridgeService.CreateCartridges(newCartridgeViewModel.Cartridges, newCartridgeViewModel.SelectedCompany, newCartridgeViewModel.SelectedOffice, newCartridgeViewModel.SelectedPaymentType, newCartridgeViewModel.Customer.Id, newCartridgeViewModel.SelectedMaster).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Result>, NewCartridgeViewModel.<MakeOrder>d__81>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<Result>);
						this.<>1__state = -1;
					}
					Result result = awaiter.GetResult();
					if (result.IsSucces)
					{
						newCartridgeViewModel._navigationService.CloseCurrentTab();
						if (OfflineData.Instance.Settings.PrintNewCartridgeReport || OfflineData.Instance.Settings.PrintCartridgeStickers)
						{
							newCartridgeViewModel.PrintDocument(result.Ids);
						}
					}
					newCartridgeViewModel._navigationService.NavigateRepairs();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_1E4:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002D30 RID: 11568 RVA: 0x00091D38 File Offset: 0x0008FF38
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001935 RID: 6453
			public int <>1__state;

			// Token: 0x04001936 RID: 6454
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001937 RID: 6455
			public NewCartridgeViewModel <>4__this;

			// Token: 0x04001938 RID: 6456
			private TaskAwaiter<Result> <>u__1;
		}

		// Token: 0x0200047C RID: 1148
		[CompilerGenerated]
		private sealed class <>c__DisplayClass82_0
		{
			// Token: 0x06002D31 RID: 11569 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass82_0()
			{
			}

			// Token: 0x06002D32 RID: 11570 RVA: 0x00091D54 File Offset: 0x0008FF54
			internal Task<CartridgeReport> <PrintDocument>b__0()
			{
				return this.<>4__this._cartridgeService.GetCartgidgesReport(this.<>4__this.SelectedCompany, this.<>4__this.SelectedOffice, this.<>4__this.Customer.Id, this.ids);
			}

			// Token: 0x04001939 RID: 6457
			public NewCartridgeViewModel <>4__this;

			// Token: 0x0400193A RID: 6458
			public List<int> ids;
		}

		// Token: 0x0200047D RID: 1149
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <PrintDocument>d__82 : IAsyncStateMachine
		{
			// Token: 0x06002D33 RID: 11571 RVA: 0x00091DA0 File Offset: 0x0008FFA0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NewCartridgeViewModel newCartridgeViewModel = this.<>4__this;
				try
				{
					NewCartridgeViewModel.<>c__DisplayClass82_0 CS$<>8__locals1;
					if (num > 2)
					{
						CS$<>8__locals1 = new NewCartridgeViewModel.<>c__DisplayClass82_0();
						CS$<>8__locals1.<>4__this = this.<>4__this;
						CS$<>8__locals1.ids = this.ids;
						newCartridgeViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter<CartridgeReport> awaiter;
						TaskAwaiter<XtraReport> awaiter2;
						switch (num)
						{
						case 0:
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<CartridgeReport>);
							int num2 = -1;
							num = -1;
							this.<>1__state = num2;
							break;
						}
						case 1:
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<XtraReport>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
							goto IL_12C;
						}
						case 2:
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<XtraReport>);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
							goto IL_1B5;
						}
						default:
							awaiter = Task.Run<CartridgeReport>(new Func<Task<CartridgeReport>>(CS$<>8__locals1.<PrintDocument>b__0)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num5 = 0;
								num = 0;
								this.<>1__state = num5;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<CartridgeReport>, NewCartridgeViewModel.<PrintDocument>d__82>(ref awaiter, ref this);
								return;
							}
							break;
						}
						CartridgeReport result = awaiter.GetResult();
						this.<cartridgeReport>5__2 = result;
						if (!OfflineData.Instance.Settings.PrintNewCartridgeReport)
						{
							goto IL_143;
						}
						awaiter2 = ReportPrintModel.CreateReport("new_cartridge", this.<cartridgeReport>5__2).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num6 = 1;
							num = 1;
							this.<>1__state = num6;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XtraReport>, NewCartridgeViewModel.<PrintDocument>d__82>(ref awaiter2, ref this);
							return;
						}
						IL_12C:
						XtraReport result2 = awaiter2.GetResult();
						newCartridgeViewModel._reportPrintService.PrintPreview(result2, PrinterModel.Printer.Documents);
						IL_143:
						if (!OfflineData.Instance.Settings.PrintCartridgeStickers)
						{
							goto IL_1CC;
						}
						awaiter2 = ReportPrintModel.CreateReport("sticker_cartridge", this.<cartridgeReport>5__2).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num7 = 2;
							num = 2;
							this.<>1__state = num7;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XtraReport>, NewCartridgeViewModel.<PrintDocument>d__82>(ref awaiter2, ref this);
							return;
						}
						IL_1B5:
						XtraReport result3 = awaiter2.GetResult();
						newCartridgeViewModel._reportPrintService.PrintPreview(result3, PrinterModel.Printer.Stickers);
						IL_1CC:
						this.<cartridgeReport>5__2 = null;
					}
					catch (Exception ex)
					{
						newCartridgeViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							newCartridgeViewModel.HideWait();
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

			// Token: 0x06002D34 RID: 11572 RVA: 0x00092020 File Offset: 0x00090220
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400193B RID: 6459
			public int <>1__state;

			// Token: 0x0400193C RID: 6460
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400193D RID: 6461
			public NewCartridgeViewModel <>4__this;

			// Token: 0x0400193E RID: 6462
			public List<int> ids;

			// Token: 0x0400193F RID: 6463
			private CartridgeReport <cartridgeReport>5__2;

			// Token: 0x04001940 RID: 6464
			private TaskAwaiter<CartridgeReport> <>u__1;

			// Token: 0x04001941 RID: 6465
			private TaskAwaiter<XtraReport> <>u__2;
		}

		// Token: 0x0200047E RID: 1150
		[CompilerGenerated]
		private sealed class <>c__DisplayClass84_0
		{
			// Token: 0x06002D35 RID: 11573 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass84_0()
			{
			}

			// Token: 0x06002D36 RID: 11574 RVA: 0x0009203C File Offset: 0x0009023C
			internal bool <CheckManyFields>b__0(Cartridge i)
			{
				return i.SerialNumber == this.cartridge.SerialNumber && i.CardId == this.cartridge.CardId && !i.Equals(this.cartridge);
			}

			// Token: 0x04001942 RID: 6466
			public Cartridge cartridge;
		}

		// Token: 0x0200047F RID: 1151
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SelectCustomerFromList>d__95 : IAsyncStateMachine
		{
			// Token: 0x06002D37 RID: 11575 RVA: 0x00092088 File Offset: 0x00090288
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NewCartridgeViewModel newCartridgeViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						newCartridgeViewModel.SwithEnableSearch();
						awaiter = newCartridgeViewModel.SetCustomer(this.customer.Id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, NewCartridgeViewModel.<SelectCustomerFromList>d__95>(ref awaiter, ref this);
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
					newCartridgeViewModel.UseClientData();
					newCartridgeViewModel.HideMatchShowOpenCard();
					newCartridgeViewModel.SwithEnableSearch();
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

			// Token: 0x06002D38 RID: 11576 RVA: 0x00092160 File Offset: 0x00090360
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001943 RID: 6467
			public int <>1__state;

			// Token: 0x04001944 RID: 6468
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001945 RID: 6469
			public NewCartridgeViewModel <>4__this;

			// Token: 0x04001946 RID: 6470
			public ICustomer customer;

			// Token: 0x04001947 RID: 6471
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000480 RID: 1152
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002D39 RID: 11577 RVA: 0x0009217C File Offset: 0x0009037C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06002D3A RID: 11578 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06002D3B RID: 11579 RVA: 0x00092194 File Offset: 0x00090394
			internal decimal <PriceChanged>b__97_0(Cartridge c)
			{
				return c.TotalCost;
			}

			// Token: 0x04001948 RID: 6472
			public static readonly NewCartridgeViewModel.<>c <>9 = new NewCartridgeViewModel.<>c();

			// Token: 0x04001949 RID: 6473
			public static Func<Cartridge, decimal> <>9__97_0;
		}

		// Token: 0x02000481 RID: 1153
		[CompilerGenerated]
		private sealed class <>c__DisplayClass104_0
		{
			// Token: 0x06002D3C RID: 11580 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass104_0()
			{
			}

			// Token: 0x06002D3D RID: 11581 RVA: 0x000921A8 File Offset: 0x000903A8
			internal Task<Cartridge> <OnSearchTimer>b__0()
			{
				return this.<>4__this._cartridgeService.GetCartridge(this.id);
			}

			// Token: 0x0400194A RID: 6474
			public int id;

			// Token: 0x0400194B RID: 6475
			public NewCartridgeViewModel <>4__this;
		}
	}
}
