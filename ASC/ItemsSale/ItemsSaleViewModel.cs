using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using ASC.Clients;
using ASC.Common.Interfaces;
using ASC.Common.Objects;
using ASC.EFExtensions;
using ASC.Extensions.Pinpad;
using ASC.Interfaces;
using ASC.Invoice;
using ASC.Models;
using ASC.Objects;
using ASC.Objects.Converters;
using ASC.Options;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using ASC.TaskManager;
using ASC.ViewModel;
using ASC.ViewModels;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Xpf.Grid;
using DevExpress.XtraReports.UI;

namespace ASC.ItemsSale
{
	// Token: 0x020001B6 RID: 438
	public class ItemsSaleViewModel : BaseViewModel, IItemsSelect, ICustomerSelect
	{
		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x0600191C RID: 6428 RVA: 0x00046ABC File Offset: 0x00044CBC
		// (set) Token: 0x0600191D RID: 6429 RVA: 0x00046AD0 File Offset: 0x00044CD0
		public SaleDocument Document
		{
			[CompilerGenerated]
			get
			{
				return this.<Document>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Document>k__BackingField, value))
				{
					return;
				}
				this.<Document>k__BackingField = value;
				this.RaisePropertyChanged("IsEditable");
				this.RaisePropertyChanged("IsReserve");
				this.RaisePropertyChanged("Document");
			}
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x0600191E RID: 6430 RVA: 0x00046B14 File Offset: 0x00044D14
		// (set) Token: 0x0600191F RID: 6431 RVA: 0x00046B28 File Offset: 0x00044D28
		public decimal CurrencyRate
		{
			[CompilerGenerated]
			get
			{
				return this.<CurrencyRate>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<CurrencyRate>k__BackingField, value))
				{
					return;
				}
				this.<CurrencyRate>k__BackingField = value;
				this.RaisePropertyChanged("CurrencyRate");
			}
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06001920 RID: 6432 RVA: 0x00046B58 File Offset: 0x00044D58
		// (set) Token: 0x06001921 RID: 6433 RVA: 0x00046B6C File Offset: 0x00044D6C
		public store_items SelectedItem
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

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06001922 RID: 6434 RVA: 0x00046B9C File Offset: 0x00044D9C
		// (set) Token: 0x06001923 RID: 6435 RVA: 0x00046BB0 File Offset: 0x00044DB0
		public decimal InputSumm
		{
			[CompilerGenerated]
			get
			{
				return this.<InputSumm>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<InputSumm>k__BackingField, value))
				{
					return;
				}
				this.<InputSumm>k__BackingField = value;
				this.RaisePropertyChanged("InputSumm");
			}
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06001924 RID: 6436 RVA: 0x00046BE0 File Offset: 0x00044DE0
		// (set) Token: 0x06001925 RID: 6437 RVA: 0x00046BF4 File Offset: 0x00044DF4
		public decimal OutSumm
		{
			[CompilerGenerated]
			get
			{
				return this.<OutSumm>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<OutSumm>k__BackingField, value))
				{
					return;
				}
				this.<OutSumm>k__BackingField = value;
				this.RaisePropertyChanged("OutSumm");
			}
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06001926 RID: 6438 RVA: 0x00046C24 File Offset: 0x00044E24
		// (set) Token: 0x06001927 RID: 6439 RVA: 0x00046C38 File Offset: 0x00044E38
		public List<Warranty> WarrantyOptionses
		{
			[CompilerGenerated]
			get
			{
				return this.<WarrantyOptionses>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(this.<WarrantyOptionses>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 993863751;
				IL_13:
				switch ((num ^ 1509713440) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					IL_32:
					this.<WarrantyOptionses>k__BackingField = value;
					num = 78532038;
					goto IL_13;
				case 3:
					return;
				}
				this.RaisePropertyChanged("WarrantyOptionses");
			}
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06001928 RID: 6440 RVA: 0x00046C94 File Offset: 0x00044E94
		// (set) Token: 0x06001929 RID: 6441 RVA: 0x00046CA8 File Offset: 0x00044EA8
		public List<PhoneOptions> PhoneOptions
		{
			[CompilerGenerated]
			get
			{
				return this.<PhoneOptions>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<PhoneOptions>k__BackingField, value))
				{
					return;
				}
				this.<PhoneOptions>k__BackingField = value;
				this.RaisePropertyChanged("PhoneOptions");
			}
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x0600192A RID: 6442 RVA: 0x00046CD8 File Offset: 0x00044ED8
		// (set) Token: 0x0600192B RID: 6443 RVA: 0x00046CEC File Offset: 0x00044EEC
		public List<PriceColumns> PriceColumnses
		{
			[CompilerGenerated]
			get
			{
				return this.<PriceColumnses>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<PriceColumnses>k__BackingField, value))
				{
					return;
				}
				this.<PriceColumnses>k__BackingField = value;
				this.RaisePropertyChanged("PriceColumnses");
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x0600192C RID: 6444 RVA: 0x00046D1C File Offset: 0x00044F1C
		// (set) Token: 0x0600192D RID: 6445 RVA: 0x00046D30 File Offset: 0x00044F30
		public string CancellRnReason
		{
			[CompilerGenerated]
			get
			{
				return this.<CancellRnReason>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<CancellRnReason>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<CancellRnReason>k__BackingField = value;
				this.RaisePropertyChanged("CancellRnReason");
			}
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x0600192E RID: 6446 RVA: 0x00046D60 File Offset: 0x00044F60
		public bool IsEditable
		{
			get
			{
				return this.Document != null && (this.Document.Id == 0 || this.Document.Status == DocStates.Reserve);
			}
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x0600192F RID: 6447 RVA: 0x00046D94 File Offset: 0x00044F94
		public bool IsReserve
		{
			get
			{
				return this.Document != null && this.Document.Status == DocStates.Reserve;
			}
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06001930 RID: 6448 RVA: 0x00046DBC File Offset: 0x00044FBC
		// (set) Token: 0x06001931 RID: 6449 RVA: 0x00046DD0 File Offset: 0x00044FD0
		public bool PayFromBalace
		{
			[CompilerGenerated]
			get
			{
				return this.<PayFromBalace>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PayFromBalace>k__BackingField == value)
				{
					return;
				}
				this.<PayFromBalace>k__BackingField = value;
				this.RaisePropertyChanged("PayFromBalace");
			}
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06001932 RID: 6450 RVA: 0x00046DFC File Offset: 0x00044FFC
		// (set) Token: 0x06001933 RID: 6451 RVA: 0x00046E10 File Offset: 0x00045010
		public bool PrintCheck
		{
			[CompilerGenerated]
			get
			{
				return this.<PrintCheck>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PrintCheck>k__BackingField == value)
				{
					return;
				}
				this.<PrintCheck>k__BackingField = value;
				this.RaisePropertyChanged("PrintCheck");
			}
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06001934 RID: 6452 RVA: 0x00046E3C File Offset: 0x0004503C
		// (set) Token: 0x06001935 RID: 6453 RVA: 0x00046E50 File Offset: 0x00045050
		public bool OpenClietcCardBtnVis
		{
			[CompilerGenerated]
			get
			{
				return this.<OpenClietcCardBtnVis>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<OpenClietcCardBtnVis>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -134151182;
				IL_10:
				switch ((num ^ -1464957519) % 4)
				{
				case 0:
					goto IL_0B;
				case 1:
					IL_2F:
					num = -1217045421;
					goto IL_10;
				case 3:
					return;
				}
				this.<OpenClietcCardBtnVis>k__BackingField = value;
				this.RaisePropertyChanged("OpenClietcCardBtnVis");
			}
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06001936 RID: 6454 RVA: 0x00046EA8 File Offset: 0x000450A8
		// (set) Token: 0x06001937 RID: 6455 RVA: 0x00046EBC File Offset: 0x000450BC
		public bool IsMatchClientVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<IsMatchClientVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IsMatchClientVisible>k__BackingField == value)
				{
					return;
				}
				this.<IsMatchClientVisible>k__BackingField = value;
				this.RaisePropertyChanged("IsMatchClientVisible");
			}
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06001938 RID: 6456 RVA: 0x00046EE8 File Offset: 0x000450E8
		// (set) Token: 0x06001939 RID: 6457 RVA: 0x00046EFC File Offset: 0x000450FC
		public ObservableCollection<ClientAndDevices> ClientsMatch
		{
			[CompilerGenerated]
			get
			{
				return this.<ClientsMatch>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ClientsMatch>k__BackingField, value))
				{
					return;
				}
				this.<ClientsMatch>k__BackingField = value;
				this.RaisePropertyChanged("ClientsMatch");
			}
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x0600193A RID: 6458 RVA: 0x00046F2C File Offset: 0x0004512C
		// (set) Token: 0x0600193B RID: 6459 RVA: 0x00046F40 File Offset: 0x00045140
		public ClientAndDevices SelectedMatch
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedMatch>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedMatch>k__BackingField, value))
				{
					return;
				}
				this.<SelectedMatch>k__BackingField = value;
				this.RaisePropertyChanged("SelectedMatch");
			}
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x0600193C RID: 6460 RVA: 0x00046F70 File Offset: 0x00045170
		public bool DisplayKktOptions
		{
			get
			{
				return OfflineData.Instance.Employee.KktReady();
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x0600193D RID: 6461 RVA: 0x00046F8C File Offset: 0x0004518C
		// (set) Token: 0x0600193E RID: 6462 RVA: 0x00046FA0 File Offset: 0x000451A0
		public bool IncludeDescriptionInName
		{
			[CompilerGenerated]
			get
			{
				return this.<IncludeDescriptionInName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IncludeDescriptionInName>k__BackingField == value)
				{
					return;
				}
				this.<IncludeDescriptionInName>k__BackingField = value;
				this.RaisePropertyChanged("IncludeDescriptionInName");
			}
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x0600193F RID: 6463 RVA: 0x00046FCC File Offset: 0x000451CC
		// (set) Token: 0x06001940 RID: 6464 RVA: 0x00046FE0 File Offset: 0x000451E0
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

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06001941 RID: 6465 RVA: 0x0004700C File Offset: 0x0004520C
		// (set) Token: 0x06001942 RID: 6466 RVA: 0x00047020 File Offset: 0x00045220
		public bool PrintRn
		{
			[CompilerGenerated]
			get
			{
				return this.<PrintRn>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PrintRn>k__BackingField == value)
				{
					return;
				}
				this.<PrintRn>k__BackingField = value;
				this.RaisePropertyChanged("PrintRn");
			}
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x0004704C File Offset: 0x0004524C
		private void IoC()
		{
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._ascMessageBoxService = Bootstrapper.Container.Resolve<IAscMessageBoxService>();
			this._reportPrintService = Bootstrapper.Container.Resolve<IReportPrintService>();
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x0004709C File Offset: 0x0004529C
		public ItemsSaleViewModel()
		{
			this.IoC();
			this.SetViewName("QuickSale");
			this.LoadCommonData();
			this.Document = DocumentsModel.DefaultSaleDocument();
			this.Document.CompanyId = OfflineData.Instance.Employee.Office.DefaultCompanyId;
			this.Document.SetPriceOption(2);
			this.EnableSearch = true;
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x0004714C File Offset: 0x0004534C
		public ItemsSaleViewModel(int documentId)
		{
			this.IoC();
			this.SetViewName("Rn", documentId);
			this.LoadCommonData();
			this.LoadDocument(documentId);
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x000471C4 File Offset: 0x000453C4
		public ItemsSaleViewModel(store_items item) : this()
		{
			this.LoadAndAddItem(item.id);
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x000471E4 File Offset: 0x000453E4
		public ItemsSaleViewModel(Product product) : this()
		{
			this.LoadAndAddItem(product.Id);
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x00047204 File Offset: 0x00045404
		public ItemsSaleViewModel(IEnumerable<store_items> items) : this()
		{
			foreach (store_items store_items in items)
			{
				this.LoadAndAddItem(store_items.id);
			}
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x00047258 File Offset: 0x00045458
		public ItemsSaleViewModel(IEnumerable<Product> items) : this()
		{
			foreach (Product product in items)
			{
				this.LoadAndAddItem(product.Id);
			}
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x000472AC File Offset: 0x000454AC
		public ItemsSaleViewModel(IEnumerable<store_items> items, bool returnOnCreate) : this(items)
		{
			this.ReturnOnCreate = returnOnCreate;
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x0600194B RID: 6475 RVA: 0x000472C8 File Offset: 0x000454C8
		// (set) Token: 0x0600194C RID: 6476 RVA: 0x000472DC File Offset: 0x000454DC
		public bool ReturnOnCreate
		{
			[CompilerGenerated]
			get
			{
				return this.<ReturnOnCreate>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ReturnOnCreate>k__BackingField == value)
				{
					return;
				}
				this.<ReturnOnCreate>k__BackingField = value;
				this.RaisePropertyChanged("ReturnOnCreate");
			}
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x00047308 File Offset: 0x00045508
		public void SetCustomer(int customerId)
		{
			this.Document.SetCustomer(customerId);
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x00047324 File Offset: 0x00045524
		private void LoadCommonData()
		{
			this.PriceColumnses = PriceColumns.GetPriceColumns();
			this.LoadPhoneOptions();
			this.WarrantyOptionses = WarrantyOptions.GetAll();
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x00047350 File Offset: 0x00045550
		private void LoadDocument(int documentId)
		{
			ItemsSaleViewModel.<LoadDocument>d__98 <LoadDocument>d__;
			<LoadDocument>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadDocument>d__.<>4__this = this;
			<LoadDocument>d__.documentId = documentId;
			<LoadDocument>d__.<>1__state = -1;
			<LoadDocument>d__.<>t__builder.Start<ItemsSaleViewModel.<LoadDocument>d__98>(ref <LoadDocument>d__);
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x00047390 File Offset: 0x00045590
		private void LoadAndAddItem(int itemId)
		{
			ItemsSaleViewModel.<LoadAndAddItem>d__99 <LoadAndAddItem>d__;
			<LoadAndAddItem>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadAndAddItem>d__.<>4__this = this;
			<LoadAndAddItem>d__.itemId = itemId;
			<LoadAndAddItem>d__.<>1__state = -1;
			<LoadAndAddItem>d__.<>t__builder.Start<ItemsSaleViewModel.<LoadAndAddItem>d__99>(ref <LoadAndAddItem>d__);
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x000473D0 File Offset: 0x000455D0
		private void LoadPhoneOptions()
		{
			this.PhoneOptions = new PhoneOptions().GetAllOptions();
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x000473F0 File Offset: 0x000455F0
		private bool CheckCancellRnFields()
		{
			if (string.IsNullOrEmpty(this.CancellRnReason))
			{
				this._toasterService.Info(Lang.t("InputReason"));
				return false;
			}
			return true;
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x00047424 File Offset: 0x00045624
		[Command]
		public void CancellRn()
		{
			ItemsSaleViewModel.<CancellRn>d__102 <CancellRn>d__;
			<CancellRn>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<CancellRn>d__.<>4__this = this;
			<CancellRn>d__.<>1__state = -1;
			<CancellRn>d__.<>t__builder.Start<ItemsSaleViewModel.<CancellRn>d__102>(ref <CancellRn>d__);
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x0004745C File Offset: 0x0004565C
		public bool CanCancellRn()
		{
			if (this.Document != null)
			{
				if (this.Document.Status == DocStates.RnMaked)
				{
					return OfflineData.Instance.Employee.Can(51, 0);
				}
			}
			return false;
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x00047498 File Offset: 0x00045698
		[Command]
		public void ItemDoubleClick()
		{
			if (this.Document.Id != 0 && this.SelectedItem != null)
			{
				this._navigationService.NavigateToStoreItem(this.SelectedItem.id, 0);
				return;
			}
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x000474D4 File Offset: 0x000456D4
		[Command]
		public void RemoveItem()
		{
			if (this.SelectedItem == null)
			{
				return;
			}
			this.Document.RemoveItem(this.SelectedItem);
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x000474FC File Offset: 0x000456FC
		public bool CanRemoveItem()
		{
			return this.Document != null && this.Document.CanRemoveItem();
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x00047520 File Offset: 0x00045720
		[Command]
		public void CancellReserve()
		{
			ItemsSaleViewModel.<CancellReserve>d__107 <CancellReserve>d__;
			<CancellReserve>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<CancellReserve>d__.<>4__this = this;
			<CancellReserve>d__.<>1__state = -1;
			<CancellReserve>d__.<>t__builder.Start<ItemsSaleViewModel.<CancellReserve>d__107>(ref <CancellReserve>d__);
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x00047558 File Offset: 0x00045758
		public bool CanCancellReserve()
		{
			return this.Document != null && (this.Document.InvoiceId == null || this.Document.Invoice.State != 2) && this.Document.Status == DocStates.Reserve;
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x000475A8 File Offset: 0x000457A8
		[Command]
		public void OpenCustomerCard()
		{
			if (this.Document.DealerId != null)
			{
				this._navigationService.NavigateToCustomerCard(this.Document.DealerId.Value, null);
			}
		}

		// Token: 0x0600195B RID: 6491 RVA: 0x000475EC File Offset: 0x000457EC
		public bool CanOpenCustomerCard()
		{
			if (OfflineData.Instance.Employee.Can(7, 0))
			{
				SaleDocument document = this.Document;
				return document == null || document.Id != 0;
			}
			return false;
		}

		// Token: 0x0600195C RID: 6492 RVA: 0x00047624 File Offset: 0x00045824
		private bool CreateNewClient()
		{
			ClientsModel clientsModel = new ClientsModel();
			ASC.Objects.CustomerCard customerCard = (ASC.Objects.CustomerCard)this.Document.Customer;
			if (!string.IsNullOrEmpty(customerCard.Phone))
			{
				customerCard.AddTelToList(customerCard.Phone, customerCard.PhoneMask);
			}
			string text = clientsModel.CheckFields(customerCard);
			if (!string.IsNullOrEmpty(text))
			{
				this._toasterService.Info(text);
				return false;
			}
			int num = clientsModel.CreateNewClient(customerCard);
			if (num > 0)
			{
				this.SetCustomer(num);
			}
			return num > 0;
		}

		// Token: 0x0600195D RID: 6493 RVA: 0x0004769C File Offset: 0x0004589C
		[Command]
		public void ReserveItems()
		{
			ItemsSaleViewModel.<ReserveItems>d__112 <ReserveItems>d__;
			<ReserveItems>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<ReserveItems>d__.<>4__this = this;
			<ReserveItems>d__.<>1__state = -1;
			<ReserveItems>d__.<>t__builder.Start<ItemsSaleViewModel.<ReserveItems>d__112>(ref <ReserveItems>d__);
		}

		// Token: 0x0600195E RID: 6494 RVA: 0x000476D4 File Offset: 0x000458D4
		protected override void OnParentViewModelChanged(object o)
		{
			this._parentViewModel = o;
		}

		// Token: 0x0600195F RID: 6495 RVA: 0x000476E8 File Offset: 0x000458E8
		public bool CanReserveItems()
		{
			return this.Document != null && this.Document.Id == 0;
		}

		// Token: 0x06001960 RID: 6496 RVA: 0x00047710 File Offset: 0x00045910
		[Command]
		public void SaleReserve()
		{
			ItemsSaleViewModel.<SaleReserve>d__116 <SaleReserve>d__;
			<SaleReserve>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SaleReserve>d__.<>4__this = this;
			<SaleReserve>d__.<>1__state = -1;
			<SaleReserve>d__.<>t__builder.Start<ItemsSaleViewModel.<SaleReserve>d__116>(ref <SaleReserve>d__);
		}

		// Token: 0x06001961 RID: 6497 RVA: 0x00047748 File Offset: 0x00045948
		public bool CanSaleReserve()
		{
			return !this._disableSaleReserve && (base.IsValid() && this.Document != null && this.Document.Id > 0 && this.Document.Status == DocStates.Reserve) && (this.Document.Invoice == null || this.Document.Invoice.State == 3);
		}

		// Token: 0x06001962 RID: 6498 RVA: 0x000477B0 File Offset: 0x000459B0
		private void DisableSale(bool value)
		{
			this._disableSale = value;
			base.RaiseCanExecuteChanged(() => this.SaleItems());
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x00047800 File Offset: 0x00045A00
		private void DisableSaleReserve(bool value)
		{
			this._disableSaleReserve = value;
			base.RaiseCanExecuteChanged(() => this.SaleReserve());
		}

		// Token: 0x06001964 RID: 6500 RVA: 0x00047850 File Offset: 0x00045A50
		[AsyncCommand]
		public Task SaleItems()
		{
			ItemsSaleViewModel.<SaleItems>d__124 <SaleItems>d__;
			<SaleItems>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<SaleItems>d__.<>4__this = this;
			<SaleItems>d__.<>1__state = -1;
			<SaleItems>d__.<>t__builder.Start<ItemsSaleViewModel.<SaleItems>d__124>(ref <SaleItems>d__);
			return <SaleItems>d__.<>t__builder.Task;
		}

		// Token: 0x06001965 RID: 6501 RVA: 0x00047894 File Offset: 0x00045A94
		public bool CanSaleItems()
		{
			return !this._disableSale && this.Document != null && this.Document.InvoiceId == null && base.IsValid() && this.Document.Id == 0;
		}

		// Token: 0x06001966 RID: 6502 RVA: 0x000478E4 File Offset: 0x00045AE4
		private IPinpadResult CardPayment()
		{
			if (this.Document.PaymentSystem == -1 && OfflineData.Instance.Employee.PinpadReady())
			{
				return new SBRFPinpad().Purchase(this.Document.Total);
			}
			return null;
		}

		// Token: 0x06001967 RID: 6503 RVA: 0x00047928 File Offset: 0x00045B28
		private void PrintCheque()
		{
			ItemsDocument document = new ItemsDocument
			{
				Id = this.Document.Id,
				PaymentSystem = this.Document.PaymentSystem,
				CustomerEmail = this.CustomerEmail,
				CashOrderId = this.Document.CashOrderId.Value
			};
			IAscResult ascResult = OfflineData.Instance.Employee.Kkt.SaleCheck(document);
			if (!ascResult.IsSucces)
			{
				this._toasterService.Error(ascResult.Message);
			}
		}

		// Token: 0x06001968 RID: 6504 RVA: 0x000479B4 File Offset: 0x00045BB4
		private void MinimumInStockCheck()
		{
			Task.Run<IEnumerable<store_items>>(() => this._itemsSaleModel.LoadFireItems()).ContinueWith(delegate(Task<IEnumerable<store_items>> t)
			{
				List<store_items> list = new List<store_items>(t.Result);
				if (list.Any<store_items>())
				{
					Bootstrapper.Container.Resolve<ITaskService>().Task4FireItems(list);
				}
			});
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x000479F8 File Offset: 0x00045BF8
		[Command]
		public void PrintPn()
		{
			ItemsSaleViewModel.<PrintPn>d__129 <PrintPn>d__;
			<PrintPn>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<PrintPn>d__.<>4__this = this;
			<PrintPn>d__.<>1__state = -1;
			<PrintPn>d__.<>t__builder.Start<ItemsSaleViewModel.<PrintPn>d__129>(ref <PrintPn>d__);
		}

		// Token: 0x0600196A RID: 6506 RVA: 0x00047A30 File Offset: 0x00045C30
		public bool CanPrintPn()
		{
			return this.Document != null && this.Document.CanPrintPn();
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x00047A54 File Offset: 0x00045C54
		private void PrintDocuments()
		{
			ItemsSaleViewModel.<PrintDocuments>d__131 <PrintDocuments>d__;
			<PrintDocuments>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<PrintDocuments>d__.<>4__this = this;
			<PrintDocuments>d__.<>1__state = -1;
			<PrintDocuments>d__.<>t__builder.Start<ItemsSaleViewModel.<PrintDocuments>d__131>(ref <PrintDocuments>d__);
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x00047A8C File Offset: 0x00045C8C
		private bool CheckFields(bool customerCheck = true)
		{
			if (customerCheck)
			{
				if (this.Document.DealerId == null && (string.IsNullOrEmpty(this.Document.Customer.LastName) || string.IsNullOrEmpty(this.Document.Customer.FirstName)))
				{
					this._toasterService.Info(Lang.t("SelectOrInputBuyer"));
					return false;
				}
				if (Auth.Config.is_patronymic_required && string.IsNullOrEmpty(this.Document.Customer.Patronymic))
				{
					this._toasterService.Info(Lang.t("InputPatronymic"));
					return false;
				}
			}
			return base.CheckFields(this.Document);
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x00047B40 File Offset: 0x00045D40
		public void AddItemsFromStore(List<Product> items, Product selectedItem)
		{
			if (items.Count > 0)
			{
				foreach (Product product in items)
				{
					if (!this.ItemInForeignOffice(product))
					{
						this.LoadAndAddItem(product.Id);
					}
				}
				return;
			}
			if (selectedItem != null)
			{
				if (this.ItemInForeignOffice(selectedItem))
				{
					return;
				}
				this.LoadAndAddItem(selectedItem.Id);
			}
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x00047BC4 File Offset: 0x00045DC4
		private bool ItemInForeignOffice(Product item)
		{
			if (!StoreModel.ItemInUserOffice(item.StoreId))
			{
				string messageBoxText = item.Name + " | " + Lang.t("ItemInForeignOffice");
				this._ascMessageBoxService.ShowMessageBox(messageBoxText);
				return true;
			}
			return false;
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x00047C08 File Offset: 0x00045E08
		[Command]
		public void AddItem()
		{
			this._navigationService.NavigateToStore(true, ItemsOptions.opName.inStock4Sale, this);
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x000476E8 File Offset: 0x000458E8
		public bool CanAddItem()
		{
			return this.Document != null && this.Document.Id == 0;
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x00047C24 File Offset: 0x00045E24
		public void AddItem(store_items item)
		{
			if (this.ItemAlreadyInList(item.id))
			{
				this._toasterService.Info(Lang.t("ItemAlreadyInList"));
				return;
			}
			if (item.NotInStock())
			{
				this._toasterService.Info(Lang.t("ItemSubstractWarning"));
				return;
			}
			if (!StoreModel.ItemInUserOffice(item.store))
			{
				this._toasterService.Info(Lang.t("ItemInForeignOffice"));
				return;
			}
			this.Document.AddItem(item);
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x00047CA4 File Offset: 0x00045EA4
		private bool ItemAlreadyInList(int itemId)
		{
			return this.Document.AnyItem(itemId);
		}

		// Token: 0x06001973 RID: 6515 RVA: 0x00047CC0 File Offset: 0x00045EC0
		public void InSummChanged()
		{
			this.OutSumm = this.InputSumm - this.Document.Total;
			if (this.InputSumm > this.Document.Total)
			{
				SystemSounds.Beep.Play();
			}
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x00047D0C File Offset: 0x00045F0C
		[Command]
		public void ItemChanged()
		{
			SaleDocument document = this.Document;
			if (document == null)
			{
				return;
			}
			document.CountTotal();
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x00047D2C File Offset: 0x00045F2C
		[Command]
		public void SelectCustomer()
		{
			this._navigationService.Navigate("ClientsView", new ClientsViewModel("selectClient"), this);
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x00047D54 File Offset: 0x00045F54
		public bool CanSelectCustomer()
		{
			return OfflineData.Instance.Employee.Can(7, 0) && this.Document != null && this.Document.CanSetCustomer();
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x00047D8C File Offset: 0x00045F8C
		public void SelectCustomerFromList(ICustomer customer)
		{
			this.SwithEnableSearch();
			this.SetCustomer(customer.Id);
			this.SwithEnableSearch();
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x00047DB4 File Offset: 0x00045FB4
		private void MakePkoOrder(IPinpadResult r)
		{
			CashInOrder cashInOrder = new CashInOrder(this.Document);
			cashInOrder.SetOffice(OfflineData.Instance.Employee.OfficeId);
			cashInOrder.SetEmployee(OfflineData.Instance.Employee.Id);
			cashInOrder.SetCustomerEmail(this.CustomerEmail);
			if (r != null)
			{
				cashInOrder.SetPinpadData(r);
			}
			IAscResult ascResult = KassaModel.CreateCashOrder(cashInOrder, true);
			if (ascResult.IsSucces)
			{
				this._itemsSaleModel.UpdateDocumentAfterPko(this.Document.Id, ascResult.Id);
				this.Document.CashOrderId = new int?(ascResult.Id);
			}
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x00047E50 File Offset: 0x00046050
		[Command]
		public void ClearCustomer()
		{
			this.Document.ClearCustomer();
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x00047E68 File Offset: 0x00046068
		public bool CanClearCustomer()
		{
			return this.CanSelectCustomer();
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x00047E7C File Offset: 0x0004607C
		[Command]
		public void KktPrintCheck()
		{
			ItemsDocument document = new ItemsDocument
			{
				Id = this.Document.Id,
				PaymentSystem = this.Document.PaymentSystem,
				CustomerEmail = this.CustomerEmail,
				CashOrderId = this.Document.CashOrderId.Value
			};
			IAscResult ascResult = OfflineData.Instance.Employee.Kkt.SaleCheck(document);
			if (!ascResult.IsSucces)
			{
				this._toasterService.Error(ascResult.Message);
				return;
			}
			this._toasterService.Success(Lang.t("Complete"));
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x00047F1C File Offset: 0x0004611C
		public bool CanKktPrintCheck()
		{
			if (this.Document != null && this.Document.Id != 0 && this.Document.Total > 0m)
			{
				int? cashOrderId = this.Document.CashOrderId;
				if (cashOrderId.GetValueOrDefault() > 0 & cashOrderId != null)
				{
					return OfflineData.Instance.Employee.KktReady();
				}
			}
			return false;
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x00047F88 File Offset: 0x00046188
		[Command]
		public void InputSummChanged()
		{
			this.InSummChanged();
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x00047F9C File Offset: 0x0004619C
		[Command]
		public void OpenInvoice()
		{
			this._navigationService.NavigateInvoice(this.Document.InvoiceId.Value);
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x00047FC8 File Offset: 0x000461C8
		public bool CanOpenInvoice()
		{
			return this.Document != null && this.Document.Invoice != null && OfflineData.Instance.Employee.Can(65, 0);
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x00048000 File Offset: 0x00046200
		[Command]
		public void OutByInvoice()
		{
			ItemsSaleViewModel.<OutByInvoice>d__152 <OutByInvoice>d__;
			<OutByInvoice>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OutByInvoice>d__.<>4__this = this;
			<OutByInvoice>d__.<>1__state = -1;
			<OutByInvoice>d__.<>t__builder.Start<ItemsSaleViewModel.<OutByInvoice>d__152>(ref <OutByInvoice>d__);
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x00048038 File Offset: 0x00046238
		public bool CanOutByInvoice()
		{
			SaleDocument document = this.Document;
			if (document != null && document.InvoiceId != null)
			{
				if (this.Document.Status == DocStates.Reserve)
				{
					return this.Document.Invoice.State == 2;
				}
			}
			return false;
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x00048088 File Offset: 0x00046288
		[Command]
		public void MakeInvoice()
		{
			this._navigationService.Navigate("NewInvoiceView", new NewInvoiceViewModel(this.Document));
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x000480B0 File Offset: 0x000462B0
		public bool CanMakeInvoice()
		{
			return OfflineData.Instance.Employee.Can(65, 0) && this.Document != null && this.Document.CanMakeInvoice() && base.IsValid();
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x000480F0 File Offset: 0x000462F0
		[Command]
		public void SaveTrack()
		{
			ItemsSaleViewModel.<SaveTrack>d__156 <SaveTrack>d__;
			<SaveTrack>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SaveTrack>d__.<>4__this = this;
			<SaveTrack>d__.<>1__state = -1;
			<SaveTrack>d__.<>t__builder.Start<ItemsSaleViewModel.<SaveTrack>d__156>(ref <SaveTrack>d__);
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x00048128 File Offset: 0x00046328
		public bool CanSaveTrack()
		{
			return this.Document != null && this.Document.Id > 0;
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x00048150 File Offset: 0x00046350
		[Command]
		public void SaveNotes()
		{
			ItemsSaleViewModel.<SaveNotes>d__158 <SaveNotes>d__;
			<SaveNotes>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SaveNotes>d__.<>4__this = this;
			<SaveNotes>d__.<>1__state = -1;
			<SaveNotes>d__.<>t__builder.Start<ItemsSaleViewModel.<SaveNotes>d__158>(ref <SaveNotes>d__);
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x00048128 File Offset: 0x00046328
		public bool CanSaveNotes()
		{
			return this.Document != null && this.Document.Id > 0;
		}

		// Token: 0x06001988 RID: 6536 RVA: 0x00048188 File Offset: 0x00046388
		[Command]
		public void ShowHistory()
		{
			this._navigationService.Navigate("HistoryView", new HistoryViewModel(this.Document));
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x00048128 File Offset: 0x00046328
		public bool CanShowHistory()
		{
			return this.Document != null && this.Document.Id > 0;
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x0600198A RID: 6538 RVA: 0x000481B0 File Offset: 0x000463B0
		// (set) Token: 0x0600198B RID: 6539 RVA: 0x000481C4 File Offset: 0x000463C4
		public bool SendChequeToEmail
		{
			[CompilerGenerated]
			get
			{
				return this.<SendChequeToEmail>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SendChequeToEmail>k__BackingField == value)
				{
					return;
				}
				this.<SendChequeToEmail>k__BackingField = value;
				this.RaisePropertyChanged("SendChequeToEmail");
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x0600198C RID: 6540 RVA: 0x000481F0 File Offset: 0x000463F0
		// (set) Token: 0x0600198D RID: 6541 RVA: 0x00048204 File Offset: 0x00046404
		public string CustomerEmail
		{
			[CompilerGenerated]
			get
			{
				return this.<CustomerEmail>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.<CustomerEmail>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = 893030567;
				IL_14:
				switch ((num ^ 1658280226) % 4)
				{
				case 0:
					IL_33:
					this.<CustomerEmail>k__BackingField = value;
					this.RaisePropertyChanged("CustomerEmail");
					num = 1495980236;
					goto IL_14;
				case 1:
					return;
				case 3:
					goto IL_0F;
				}
			}
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x00048260 File Offset: 0x00046460
		[Command]
		public void SendChequeChanged()
		{
			if (!this.SendChequeToEmail)
			{
				this.CustomerEmail = "";
			}
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x00047D0C File Offset: 0x00045F0C
		[Command]
		public void CellValueChanged(CellValueChangedEventArgs e)
		{
			SaleDocument document = this.Document;
			if (document == null)
			{
				return;
			}
			document.CountTotal();
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x00048280 File Offset: 0x00046480
		private void RefreshCommands()
		{
			base.RaisePropertyChanged<bool>(() => this.IsEditable);
			base.RaiseCanExecuteChanged(() => this.CancellRn());
			base.RaiseCanExecuteChanged(() => this.SaleItems());
			base.RaiseCanExecuteChanged(() => this.CancellReserve());
			base.RaiseCanExecuteChanged(() => this.SelectCustomer());
			base.RaiseCanExecuteChanged(() => this.ClearCustomer());
			base.RaiseCanExecuteChanged(() => this.ReserveItems());
			base.RaiseCanExecuteChanged(() => this.OutByInvoice());
			base.RaiseCanExecuteChanged(() => this.MakeInvoice());
			base.RaiseCanExecuteChanged(() => this.ShowHistory());
			base.RaiseCanExecuteChanged(() => this.AddItem());
			base.RaiseCanExecuteChanged(() => this.SaleReserve());
			base.RaiseCanExecuteChanged(() => this.RemoveItem());
			base.RaiseCanExecuteChanged(() => this.PrintPn());
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x000485C4 File Offset: 0x000467C4
		[Command]
		public void SearchClientMatch()
		{
			if (!this.EnableSearch)
			{
				return;
			}
			if (this.Document.Customer == null)
			{
				this.Document.Customer = ClientsModel.DefaultCustomer().Client2CustomerCard();
			}
			if (this.Document.Customer.Type == 0 && (this.Document.Customer.LastName == null || this.Document.Customer.LastName.Length < 3) && (this.Document.Customer.FirstName == null || this.Document.Customer.FirstName.Length < 3))
			{
				this.ClientsMatch = new ObservableCollection<ClientAndDevices>();
				this.HideClientMatch();
				return;
			}
			if (this.Document.Customer.Type == 1)
			{
				if (this.Document.Customer.UrName == null || this.Document.Customer.UrName.Length < 3)
				{
					this.ClientsMatch = new ObservableCollection<ClientAndDevices>();
					this.HideClientMatch();
					return;
				}
			}
			base.ShowWait();
			Task.Run<List<ClientAndDevices>>(() => RepairModel.SearchClientMatchV2(this.Document.Customer.Customer2Client())).ContinueWith(delegate(Task<List<ClientAndDevices>> t)
			{
				this.ClientsMatch = new ObservableCollection<ClientAndDevices>(t.Result);
				this.IsMatchClientVisible = (this.ClientsMatch.Count > 0);
				base.HideWait();
			}, TaskScheduler.FromCurrentSynchronizationContext());
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x000486F4 File Offset: 0x000468F4
		public void SwithEnableSearch()
		{
			this.EnableSearch = !this.EnableSearch;
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x00048710 File Offset: 0x00046910
		public void HideMatchShowOpenCard()
		{
			this.HideClientMatch();
			this.OpenClietcCardBtnVis = true;
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x0004872C File Offset: 0x0004692C
		[Command]
		public void HideClientMatch()
		{
			this.IsMatchClientVisible = false;
		}

		// Token: 0x06001995 RID: 6549 RVA: 0x00048740 File Offset: 0x00046940
		[Command]
		public void ClientMatchClick()
		{
			ItemsSaleViewModel.<ClientMatchClick>d__177 <ClientMatchClick>d__;
			<ClientMatchClick>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<ClientMatchClick>d__.<>4__this = this;
			<ClientMatchClick>d__.<>1__state = -1;
			<ClientMatchClick>d__.<>t__builder.Start<ItemsSaleViewModel.<ClientMatchClick>d__177>(ref <ClientMatchClick>d__);
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x00048778 File Offset: 0x00046978
		public virtual void AfterClientSelect()
		{
			this.OpenClietcCardBtnVis = true;
			this.DisplayCustomerNotes();
			this.IsMatchClientVisible = false;
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x0004879C File Offset: 0x0004699C
		public void DisplayCustomerNotes()
		{
			string text = "";
			int num = 1;
			if (!string.IsNullOrEmpty(((ASC.Objects.CustomerCard)this.Document.Customer).Notes))
			{
				text = text + num.ToString() + ". " + ((ASC.Objects.CustomerCard)this.Document.Customer).Notes;
				num++;
			}
			if (this.Document.Customer.BalanceEnabled && this.Document.Customer.Balance < 0m)
			{
				text += string.Format("{0}. {1} {2:N0}", num, Lang.t("Label10"), this.Document.Customer.Balance);
				num++;
			}
			if (!string.IsNullOrEmpty(text))
			{
				this._ascMessageBoxService.ShowMessageBox(text, Lang.t("Attention"), MessageBoxButton.OK, MessageBoxImage.Exclamation);
			}
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x00048884 File Offset: 0x00046A84
		[CompilerGenerated]
		private Task<bool> <CancellRn>b__102_0()
		{
			return this._itemsSaleModel.CancellRn(this.Document.Id, this.CancellRnReason);
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x000488B0 File Offset: 0x00046AB0
		[CompilerGenerated]
		private Task<bool> <CancellReserve>b__107_0()
		{
			return ItemsSaleModel.CancellReserve(this.Document.Items, new int?(this.Document.Id), false);
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x000488E0 File Offset: 0x00046AE0
		[CompilerGenerated]
		private IAscResult <ReserveItems>b__112_0()
		{
			return ItemsSaleModel.CreateDocument(this.Document.Items, this.Document, this.CurrencyRate, false);
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x0004890C File Offset: 0x00046B0C
		[CompilerGenerated]
		private IAscResult <SaleItems>b__124_0()
		{
			return ItemsSaleModel.CreateDocument(this.Document.Items, this.Document, this.CurrencyRate, true);
		}

		// Token: 0x0600199C RID: 6556 RVA: 0x00048938 File Offset: 0x00046B38
		[CompilerGenerated]
		private Task<IEnumerable<store_items>> <MinimumInStockCheck>b__128_0()
		{
			return this._itemsSaleModel.LoadFireItems();
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x00048950 File Offset: 0x00046B50
		[CompilerGenerated]
		private XtraReport <PrintPn>b__129_0()
		{
			return this.Document.CreateReport("rn", this.IncludeDescriptionInName);
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x00048974 File Offset: 0x00046B74
		[CompilerGenerated]
		private Task<CashInOrder> <PrintDocuments>b__131_0()
		{
			return KassaModel.GetCashInOrder(this.Document.CashOrderId.Value);
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x0004899C File Offset: 0x00046B9C
		[CompilerGenerated]
		private Task<SaleDocument> <PrintDocuments>b__131_2()
		{
			return DocumentsModel.GetStoreDocument(this.Document.Id);
		}

		// Token: 0x060019A0 RID: 6560 RVA: 0x000489BC File Offset: 0x00046BBC
		[CompilerGenerated]
		private Task<bool> <OutByInvoice>b__152_0()
		{
			return ItemsSaleModel.CancellReserve(this.Document.Items, null, true);
		}

		// Token: 0x060019A1 RID: 6561 RVA: 0x000489E4 File Offset: 0x00046BE4
		[CompilerGenerated]
		private IAscResult <SaveTrack>b__156_0()
		{
			return ItemsSaleModel.SaveTrack(this.Document);
		}

		// Token: 0x060019A2 RID: 6562 RVA: 0x000489FC File Offset: 0x00046BFC
		[CompilerGenerated]
		private IAscResult <SaveNotes>b__158_0()
		{
			return DocumentsModel.SaveNotes(this.Document);
		}

		// Token: 0x060019A3 RID: 6563 RVA: 0x00048A14 File Offset: 0x00046C14
		[CompilerGenerated]
		private Task<List<ClientAndDevices>> <SearchClientMatch>b__173_0()
		{
			return RepairModel.SearchClientMatchV2(this.Document.Customer.Customer2Client());
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x00048A38 File Offset: 0x00046C38
		[CompilerGenerated]
		private void <SearchClientMatch>b__173_1(Task<List<ClientAndDevices>> t)
		{
			this.ClientsMatch = new ObservableCollection<ClientAndDevices>(t.Result);
			this.IsMatchClientVisible = (this.ClientsMatch.Count > 0);
			base.HideWait();
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x00048A70 File Offset: 0x00046C70
		[CompilerGenerated]
		private void <ClientMatchClick>b__177_0()
		{
			this.Document.SetCustomer(this.SelectedMatch.ClientId);
		}

		// Token: 0x04000CEA RID: 3306
		private INavigationService _navigationService;

		// Token: 0x04000CEB RID: 3307
		private IAscMessageBoxService _ascMessageBoxService;

		// Token: 0x04000CEC RID: 3308
		private ItemsSaleModel _itemsSaleModel = new ItemsSaleModel();

		// Token: 0x04000CED RID: 3309
		private KassaModel _kassaModel = new KassaModel();

		// Token: 0x04000CEE RID: 3310
		[CompilerGenerated]
		private SaleDocument <Document>k__BackingField;

		// Token: 0x04000CEF RID: 3311
		[CompilerGenerated]
		private decimal <CurrencyRate>k__BackingField = Auth.CurrencyModel.Rate;

		// Token: 0x04000CF0 RID: 3312
		[CompilerGenerated]
		private store_items <SelectedItem>k__BackingField;

		// Token: 0x04000CF1 RID: 3313
		public List<store_items> SelectedItems;

		// Token: 0x04000CF2 RID: 3314
		[CompilerGenerated]
		private decimal <InputSumm>k__BackingField;

		// Token: 0x04000CF3 RID: 3315
		[CompilerGenerated]
		private decimal <OutSumm>k__BackingField;

		// Token: 0x04000CF4 RID: 3316
		[CompilerGenerated]
		private List<Warranty> <WarrantyOptionses>k__BackingField;

		// Token: 0x04000CF5 RID: 3317
		[CompilerGenerated]
		private List<PhoneOptions> <PhoneOptions>k__BackingField;

		// Token: 0x04000CF6 RID: 3318
		[CompilerGenerated]
		private List<PriceColumns> <PriceColumnses>k__BackingField;

		// Token: 0x04000CF7 RID: 3319
		[CompilerGenerated]
		private string <CancellRnReason>k__BackingField;

		// Token: 0x04000CF8 RID: 3320
		[CompilerGenerated]
		private bool <PayFromBalace>k__BackingField;

		// Token: 0x04000CF9 RID: 3321
		[CompilerGenerated]
		private bool <PrintCheck>k__BackingField;

		// Token: 0x04000CFA RID: 3322
		public bool EnableSearch;

		// Token: 0x04000CFB RID: 3323
		[CompilerGenerated]
		private bool <OpenClietcCardBtnVis>k__BackingField;

		// Token: 0x04000CFC RID: 3324
		[CompilerGenerated]
		private bool <IsMatchClientVisible>k__BackingField;

		// Token: 0x04000CFD RID: 3325
		[CompilerGenerated]
		private ObservableCollection<ClientAndDevices> <ClientsMatch>k__BackingField;

		// Token: 0x04000CFE RID: 3326
		[CompilerGenerated]
		private ClientAndDevices <SelectedMatch>k__BackingField;

		// Token: 0x04000CFF RID: 3327
		[CompilerGenerated]
		private bool <IncludeDescriptionInName>k__BackingField;

		// Token: 0x04000D00 RID: 3328
		[CompilerGenerated]
		private bool <PrintPko>k__BackingField = Auth.Config.qs_print_pko;

		// Token: 0x04000D01 RID: 3329
		[CompilerGenerated]
		private bool <PrintRn>k__BackingField = Auth.Config.qs_print_rn;

		// Token: 0x04000D02 RID: 3330
		[CompilerGenerated]
		private bool <ReturnOnCreate>k__BackingField;

		// Token: 0x04000D03 RID: 3331
		private object _parentViewModel;

		// Token: 0x04000D04 RID: 3332
		private bool _disableSale;

		// Token: 0x04000D05 RID: 3333
		private bool _disableSaleReserve;

		// Token: 0x04000D06 RID: 3334
		private IToasterService _toasterService;

		// Token: 0x04000D07 RID: 3335
		private IReportPrintService _reportPrintService;

		// Token: 0x04000D08 RID: 3336
		[CompilerGenerated]
		private bool <SendChequeToEmail>k__BackingField;

		// Token: 0x04000D09 RID: 3337
		[CompilerGenerated]
		private string <CustomerEmail>k__BackingField;

		// Token: 0x020001B7 RID: 439
		[CompilerGenerated]
		private sealed class <>c__DisplayClass98_0
		{
			// Token: 0x060019A6 RID: 6566 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass98_0()
			{
			}

			// Token: 0x060019A7 RID: 6567 RVA: 0x00048A94 File Offset: 0x00046C94
			internal Task<SaleDocument> <LoadDocument>b__1()
			{
				return DocumentsModel.GetStoreDocument(this.documentId);
			}

			// Token: 0x060019A8 RID: 6568 RVA: 0x00048AAC File Offset: 0x00046CAC
			internal void <LoadDocument>b__0()
			{
				this.<>4__this.Document.LoadItems();
			}

			// Token: 0x04000D0A RID: 3338
			public int documentId;

			// Token: 0x04000D0B RID: 3339
			public ItemsSaleViewModel <>4__this;
		}

		// Token: 0x020001B8 RID: 440
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadDocument>d__98 : IAsyncStateMachine
		{
			// Token: 0x060019A9 RID: 6569 RVA: 0x00048ACC File Offset: 0x00046CCC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsSaleViewModel itemsSaleViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter<SaleDocument> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter);
							this.<>1__state = -1;
							goto IL_124;
						}
						this.<>8__1 = new ItemsSaleViewModel.<>c__DisplayClass98_0();
						this.<>8__1.documentId = this.documentId;
						this.<>8__1.<>4__this = this.<>4__this;
						itemsSaleViewModel.ShowWait();
						awaiter2 = Task.Run<SaleDocument>(new Func<Task<SaleDocument>>(this.<>8__1.<LoadDocument>b__1)).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<SaleDocument>, ItemsSaleViewModel.<LoadDocument>d__98>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<SaleDocument>);
						this.<>1__state = -1;
					}
					SaleDocument result = awaiter2.GetResult();
					itemsSaleViewModel.Document = result;
					awaiter = Task.Run(new Action(this.<>8__1.<LoadDocument>b__0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ItemsSaleViewModel.<LoadDocument>d__98>(ref awaiter, ref this);
						return;
					}
					IL_124:
					awaiter.GetResult();
					itemsSaleViewModel.RefreshCommands();
					itemsSaleViewModel.HideWait();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060019AA RID: 6570 RVA: 0x00048C68 File Offset: 0x00046E68
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000D0C RID: 3340
			public int <>1__state;

			// Token: 0x04000D0D RID: 3341
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000D0E RID: 3342
			public int documentId;

			// Token: 0x04000D0F RID: 3343
			public ItemsSaleViewModel <>4__this;

			// Token: 0x04000D10 RID: 3344
			private ItemsSaleViewModel.<>c__DisplayClass98_0 <>8__1;

			// Token: 0x04000D11 RID: 3345
			private TaskAwaiter<SaleDocument> <>u__1;

			// Token: 0x04000D12 RID: 3346
			private TaskAwaiter <>u__2;
		}

		// Token: 0x020001B9 RID: 441
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadAndAddItem>d__99 : IAsyncStateMachine
		{
			// Token: 0x060019AB RID: 6571 RVA: 0x00048C84 File Offset: 0x00046E84
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsSaleViewModel itemsSaleViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<store_items> awaiter;
					if (num != 0)
					{
						itemsSaleViewModel.ShowWait();
						awaiter = itemsSaleViewModel._itemsSaleModel.LoadItem(this.itemId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<store_items>, ItemsSaleViewModel.<LoadAndAddItem>d__99>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<store_items>);
						this.<>1__state = -1;
					}
					store_items result = awaiter.GetResult();
					itemsSaleViewModel.Document.AddItem(result);
					itemsSaleViewModel.HideWait();
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

			// Token: 0x060019AC RID: 6572 RVA: 0x00048D5C File Offset: 0x00046F5C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000D13 RID: 3347
			public int <>1__state;

			// Token: 0x04000D14 RID: 3348
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000D15 RID: 3349
			public ItemsSaleViewModel <>4__this;

			// Token: 0x04000D16 RID: 3350
			public int itemId;

			// Token: 0x04000D17 RID: 3351
			private TaskAwaiter<store_items> <>u__1;
		}

		// Token: 0x020001BA RID: 442
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CancellRn>d__102 : IAsyncStateMachine
		{
			// Token: 0x060019AD RID: 6573 RVA: 0x00048D78 File Offset: 0x00046F78
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsSaleViewModel itemsSaleViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						if (!itemsSaleViewModel.CheckCancellRnFields())
						{
							goto IL_11B;
						}
						if (itemsSaleViewModel._ascMessageBoxService.ShowMessageBox(Lang.t("CancellRn"), Lang.t("CancellRn"), MessageBoxButton.YesNo, MessageBoxImage.Exclamation) != MessageBoxResult.Yes)
						{
							goto IL_100;
						}
						itemsSaleViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter<bool> awaiter;
						if (num != 0)
						{
							awaiter = Task.Run<bool>(() => itemsSaleViewModel._itemsSaleModel.CancellRn(base.Document.Id, base.CancellRnReason)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, ItemsSaleViewModel.<CancellRn>d__102>(ref awaiter, ref this);
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
						itemsSaleViewModel.LoadDocument(itemsSaleViewModel.Document.Id);
						itemsSaleViewModel._toasterService.Success(Lang.t("RnCancelled"));
					}
					catch (Exception ex)
					{
						itemsSaleViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							itemsSaleViewModel.HideWait();
						}
					}
					IL_100:;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_11B:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060019AE RID: 6574 RVA: 0x00048EDC File Offset: 0x000470DC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000D18 RID: 3352
			public int <>1__state;

			// Token: 0x04000D19 RID: 3353
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000D1A RID: 3354
			public ItemsSaleViewModel <>4__this;

			// Token: 0x04000D1B RID: 3355
			private TaskAwaiter<bool> <>u__1;
		}

		// Token: 0x020001BB RID: 443
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CancellReserve>d__107 : IAsyncStateMachine
		{
			// Token: 0x060019AF RID: 6575 RVA: 0x00048EF8 File Offset: 0x000470F8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsSaleViewModel itemsSaleViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						itemsSaleViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter<bool> awaiter;
						if (num != 0)
						{
							awaiter = Task.Run<bool>(() => ItemsSaleModel.CancellReserve(base.Document.Items, new int?(base.Document.Id), false)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, ItemsSaleViewModel.<CancellReserve>d__107>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<bool>);
							this.<>1__state = -1;
						}
						awaiter.GetResult();
						itemsSaleViewModel.LoadDocument(itemsSaleViewModel.Document.Id);
						itemsSaleViewModel._toasterService.Success(Lang.t("CancelledReserve"));
					}
					catch (Exception ex)
					{
						itemsSaleViewModel._toasterService.Error(ex.Message);
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

			// Token: 0x060019B0 RID: 6576 RVA: 0x00049010 File Offset: 0x00047210
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000D1C RID: 3356
			public int <>1__state;

			// Token: 0x04000D1D RID: 3357
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000D1E RID: 3358
			public ItemsSaleViewModel <>4__this;

			// Token: 0x04000D1F RID: 3359
			private TaskAwaiter<bool> <>u__1;
		}

		// Token: 0x020001BC RID: 444
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ReserveItems>d__112 : IAsyncStateMachine
		{
			// Token: 0x060019B1 RID: 6577 RVA: 0x0004902C File Offset: 0x0004722C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsSaleViewModel itemsSaleViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IAscResult> awaiter;
					if (num != 0)
					{
						if (!itemsSaleViewModel.CheckFields(true))
						{
							goto IL_182;
						}
						if (itemsSaleViewModel.Document.DealerId == null && !itemsSaleViewModel.CreateNewClient())
						{
							goto IL_182;
						}
						itemsSaleViewModel.ShowWait();
						awaiter = Task.Run<IAscResult>(() => ItemsSaleModel.CreateDocument(base.Document.Items, base.Document, base.CurrencyRate, false)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IAscResult>, ItemsSaleViewModel.<ReserveItems>d__112>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IAscResult>);
						this.<>1__state = -1;
					}
					IAscResult result = awaiter.GetResult();
					itemsSaleViewModel.HideWait();
					if (result.IsSucces)
					{
						itemsSaleViewModel.Document.Id = result.Id;
						if (itemsSaleViewModel._itemsSaleModel.MakeReserve(itemsSaleViewModel.Document.Items))
						{
							DocumentsModel.SetReserveState(result.Id, 3);
							itemsSaleViewModel.LoadDocument(result.Id);
							itemsSaleViewModel._navigationService.SetTabHeader("Reserve", itemsSaleViewModel.Document.Id);
							if (itemsSaleViewModel.ReturnOnCreate)
							{
								SiteOrderTaskViewModel siteOrderTaskViewModel = itemsSaleViewModel._parentViewModel as SiteOrderTaskViewModel;
								if (siteOrderTaskViewModel != null)
								{
									siteOrderTaskViewModel.SetDocument(itemsSaleViewModel.Document);
									itemsSaleViewModel._navigationService.CloseCurrentTab();
								}
							}
						}
					}
					else
					{
						itemsSaleViewModel._toasterService.Error(result.Message);
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_182:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060019B2 RID: 6578 RVA: 0x000491EC File Offset: 0x000473EC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000D20 RID: 3360
			public int <>1__state;

			// Token: 0x04000D21 RID: 3361
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000D22 RID: 3362
			public ItemsSaleViewModel <>4__this;

			// Token: 0x04000D23 RID: 3363
			private TaskAwaiter<IAscResult> <>u__1;
		}

		// Token: 0x020001BD RID: 445
		[CompilerGenerated]
		private sealed class <>c__DisplayClass116_0
		{
			// Token: 0x060019B3 RID: 6579 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass116_0()
			{
			}

			// Token: 0x060019B4 RID: 6580 RVA: 0x00049208 File Offset: 0x00047408
			internal IAscResult <SaleReserve>b__0()
			{
				return ItemsSaleModel.SaleReserve(this.<>4__this.Document.Id, this.<>4__this.Document.Items, this.ppResult, this.<>4__this.PayFromBalace, this.<>4__this.CustomerEmail);
			}

			// Token: 0x04000D24 RID: 3364
			public ItemsSaleViewModel <>4__this;

			// Token: 0x04000D25 RID: 3365
			public IPinpadResult ppResult;
		}

		// Token: 0x020001BE RID: 446
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SaleReserve>d__116 : IAsyncStateMachine
		{
			// Token: 0x060019B5 RID: 6581 RVA: 0x00049258 File Offset: 0x00047458
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsSaleViewModel itemsSaleViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IAscResult> awaiter;
					if (num != 0)
					{
						ItemsSaleViewModel.<>c__DisplayClass116_0 CS$<>8__locals1 = new ItemsSaleViewModel.<>c__DisplayClass116_0();
						CS$<>8__locals1.<>4__this = this.<>4__this;
						if (!itemsSaleViewModel.CheckFields(true))
						{
							goto IL_1B4;
						}
						IAscResult ascResult = itemsSaleViewModel.Document.CheckSumm(itemsSaleViewModel.InputSumm);
						if (!ascResult.IsSucces)
						{
							itemsSaleViewModel._toasterService.Info(Lang.t(ascResult.Message));
							goto IL_1B4;
						}
						CS$<>8__locals1.ppResult = itemsSaleViewModel.CardPayment();
						if (CS$<>8__locals1.ppResult != null && CS$<>8__locals1.ppResult.ErrorCode != 0)
						{
							itemsSaleViewModel._toasterService.Error(CS$<>8__locals1.ppResult.ResultText);
							goto IL_1B4;
						}
						itemsSaleViewModel.DisableSaleReserve(true);
						itemsSaleViewModel.ShowWait();
						awaiter = Task.Run<IAscResult>(new Func<IAscResult>(CS$<>8__locals1.<SaleReserve>b__0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IAscResult>, ItemsSaleViewModel.<SaleReserve>d__116>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IAscResult>);
						this.<>1__state = -1;
					}
					IAscResult result = awaiter.GetResult();
					itemsSaleViewModel.HideWait();
					itemsSaleViewModel.DisableSaleReserve(false);
					if (result.IsSucces)
					{
						itemsSaleViewModel.LoadDocument(itemsSaleViewModel.Document.Id);
						if (itemsSaleViewModel.PrintCheck)
						{
							int? cashOrderId = itemsSaleViewModel.Document.CashOrderId;
							if (cashOrderId.GetValueOrDefault() > 0 & cashOrderId != null)
							{
								itemsSaleViewModel.PrintCheque();
							}
						}
						itemsSaleViewModel.PrintDocuments();
						itemsSaleViewModel.MinimumInStockCheck();
					}
					else
					{
						itemsSaleViewModel._toasterService.Error(result.Message);
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_1B4:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060019B6 RID: 6582 RVA: 0x00049448 File Offset: 0x00047648
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000D26 RID: 3366
			public int <>1__state;

			// Token: 0x04000D27 RID: 3367
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000D28 RID: 3368
			public ItemsSaleViewModel <>4__this;

			// Token: 0x04000D29 RID: 3369
			private TaskAwaiter<IAscResult> <>u__1;
		}

		// Token: 0x020001BF RID: 447
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SaleItems>d__124 : IAsyncStateMachine
		{
			// Token: 0x060019B7 RID: 6583 RVA: 0x00049464 File Offset: 0x00047664
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsSaleViewModel itemsSaleViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IAscResult> awaiter;
					if (num != 0)
					{
						if (!itemsSaleViewModel.CheckFields(!itemsSaleViewModel.Document.AnonCustomer))
						{
							goto IL_2B3;
						}
						IAscResult ascResult = itemsSaleViewModel.Document.CheckSumm(itemsSaleViewModel.InputSumm);
						if (!ascResult.IsSucces)
						{
							itemsSaleViewModel._toasterService.Info(Lang.t(ascResult.Message));
							goto IL_2B3;
						}
						this.<ppResult>5__2 = itemsSaleViewModel.CardPayment();
						if (this.<ppResult>5__2 != null && this.<ppResult>5__2.ErrorCode != 0)
						{
							itemsSaleViewModel._toasterService.Error(this.<ppResult>5__2.ResultText);
							goto IL_2B3;
						}
						if (!itemsSaleViewModel.Document.AnonCustomer && itemsSaleViewModel.Document.DealerId == null && !itemsSaleViewModel.CreateNewClient())
						{
							goto IL_2B3;
						}
						itemsSaleViewModel.DisableSale(true);
						itemsSaleViewModel.ShowWait();
						awaiter = Task.Run<IAscResult>(() => ItemsSaleModel.CreateDocument(base.Document.Items, base.Document, base.CurrencyRate, true)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IAscResult>, ItemsSaleViewModel.<SaleItems>d__124>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IAscResult>);
						this.<>1__state = -1;
					}
					IAscResult result = awaiter.GetResult();
					itemsSaleViewModel.HideWait();
					if (!result.IsSucces)
					{
						itemsSaleViewModel._toasterService.Error(result.Message);
						itemsSaleViewModel.DisableSale(false);
					}
					else
					{
						itemsSaleViewModel.Document.Id = result.Id;
						DocumentsModel.SetDocStateAndTypeRn(result.Id, DocStates.RnMaked);
						ItemsModel.SubstractItems(itemsSaleViewModel.Document.Items, false);
						if (itemsSaleViewModel.Document.Total > 0m)
						{
							if (itemsSaleViewModel.PayFromBalace && !itemsSaleViewModel.Document.AnonCustomer && itemsSaleViewModel.Document.DealerId != null)
							{
								KassaModel.SubstractCustomerBalance(itemsSaleViewModel.Document.DealerId.Value, itemsSaleViewModel.Document.Total, Kassa.Balance.ItemsSale, new int?(result.Id), 0);
							}
							else
							{
								itemsSaleViewModel.MakePkoOrder(this.<ppResult>5__2);
							}
						}
						itemsSaleViewModel.DisableSale(false);
						itemsSaleViewModel._navigationService.SetTabHeader("Rn", itemsSaleViewModel.Document.Id);
						if (itemsSaleViewModel.PrintCheck)
						{
							int? cashOrderId = itemsSaleViewModel.Document.CashOrderId;
							if (cashOrderId.GetValueOrDefault() > 0 & cashOrderId != null)
							{
								itemsSaleViewModel.PrintCheque();
							}
						}
						itemsSaleViewModel.PrintDocuments();
						itemsSaleViewModel.LoadDocument(result.Id);
						itemsSaleViewModel.MinimumInStockCheck();
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<ppResult>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_2B3:
				this.<>1__state = -2;
				this.<ppResult>5__2 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060019B8 RID: 6584 RVA: 0x0004975C File Offset: 0x0004795C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000D2A RID: 3370
			public int <>1__state;

			// Token: 0x04000D2B RID: 3371
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000D2C RID: 3372
			public ItemsSaleViewModel <>4__this;

			// Token: 0x04000D2D RID: 3373
			private IPinpadResult <ppResult>5__2;

			// Token: 0x04000D2E RID: 3374
			private TaskAwaiter<IAscResult> <>u__1;
		}

		// Token: 0x020001C0 RID: 448
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060019B9 RID: 6585 RVA: 0x00049778 File Offset: 0x00047978
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060019BA RID: 6586 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x060019BB RID: 6587 RVA: 0x00049790 File Offset: 0x00047990
			internal void <MinimumInStockCheck>b__128_1(Task<IEnumerable<store_items>> t)
			{
				List<store_items> list = new List<store_items>(t.Result);
				if (list.Any<store_items>())
				{
					Bootstrapper.Container.Resolve<ITaskService>().Task4FireItems(list);
				}
			}

			// Token: 0x04000D2F RID: 3375
			public static readonly ItemsSaleViewModel.<>c <>9 = new ItemsSaleViewModel.<>c();

			// Token: 0x04000D30 RID: 3376
			public static Action<Task<IEnumerable<store_items>>> <>9__128_1;
		}

		// Token: 0x020001C1 RID: 449
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <PrintPn>d__129 : IAsyncStateMachine
		{
			// Token: 0x060019BC RID: 6588 RVA: 0x000497C4 File Offset: 0x000479C4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsSaleViewModel itemsSaleViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<XtraReport> awaiter;
					if (num != 0)
					{
						itemsSaleViewModel.ShowWait();
						awaiter = Task.Run<XtraReport>(() => base.Document.CreateReport("rn", base.IncludeDescriptionInName)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XtraReport>, ItemsSaleViewModel.<PrintPn>d__129>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<XtraReport>);
						this.<>1__state = -1;
					}
					XtraReport result = awaiter.GetResult();
					itemsSaleViewModel.HideWait();
					itemsSaleViewModel._reportPrintService.PrintPreview(result, PrinterModel.Printer.Documents);
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

			// Token: 0x060019BD RID: 6589 RVA: 0x000498A0 File Offset: 0x00047AA0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000D31 RID: 3377
			public int <>1__state;

			// Token: 0x04000D32 RID: 3378
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000D33 RID: 3379
			public ItemsSaleViewModel <>4__this;

			// Token: 0x04000D34 RID: 3380
			private TaskAwaiter<XtraReport> <>u__1;
		}

		// Token: 0x020001C2 RID: 450
		[CompilerGenerated]
		private sealed class <>c__DisplayClass131_0
		{
			// Token: 0x060019BE RID: 6590 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass131_0()
			{
			}

			// Token: 0x060019BF RID: 6591 RVA: 0x000498BC File Offset: 0x00047ABC
			internal Task<XtraReport> <PrintDocuments>b__1()
			{
				return this.order.CreateReport();
			}

			// Token: 0x04000D35 RID: 3381
			public CashInOrder order;
		}

		// Token: 0x020001C3 RID: 451
		[CompilerGenerated]
		private sealed class <>c__DisplayClass131_1
		{
			// Token: 0x060019C0 RID: 6592 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass131_1()
			{
			}

			// Token: 0x060019C1 RID: 6593 RVA: 0x000498D4 File Offset: 0x00047AD4
			internal XtraReport <PrintDocuments>b__3()
			{
				return this.doc.CreateReport("rn", this.<>4__this.IncludeDescriptionInName);
			}

			// Token: 0x04000D36 RID: 3382
			public SaleDocument doc;

			// Token: 0x04000D37 RID: 3383
			public ItemsSaleViewModel <>4__this;
		}

		// Token: 0x020001C4 RID: 452
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <PrintDocuments>d__131 : IAsyncStateMachine
		{
			// Token: 0x060019C2 RID: 6594 RVA: 0x000498FC File Offset: 0x00047AFC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsSaleViewModel itemsSaleViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<CashInOrder> awaiter;
					TaskAwaiter<XtraReport> awaiter2;
					TaskAwaiter<SaleDocument> awaiter3;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<CashInOrder>);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<XtraReport>);
						this.<>1__state = -1;
						goto IL_157;
					case 2:
						awaiter3 = this.<>u__3;
						this.<>u__3 = default(TaskAwaiter<SaleDocument>);
						this.<>1__state = -1;
						goto IL_200;
					case 3:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<XtraReport>);
						this.<>1__state = -1;
						goto IL_27D;
					default:
						if (!itemsSaleViewModel.PrintPko && !itemsSaleViewModel.PrintRn)
						{
							goto IL_2DE;
						}
						itemsSaleViewModel.ShowWait();
						this.<report>5__2 = new XtraReport();
						if (!itemsSaleViewModel.PrintPko || itemsSaleViewModel.Document.CashOrderId == null)
						{
							goto IL_17C;
						}
						this.<>8__1 = new ItemsSaleViewModel.<>c__DisplayClass131_0();
						awaiter = Task.Run<CashInOrder>(() => KassaModel.GetCashInOrder(base.Document.CashOrderId.Value)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<CashInOrder>, ItemsSaleViewModel.<PrintDocuments>d__131>(ref awaiter, ref this);
							return;
						}
						break;
					}
					CashInOrder result = awaiter.GetResult();
					this.<>8__1.order = result;
					awaiter2 = Task.Run<XtraReport>(new Func<Task<XtraReport>>(this.<>8__1.<PrintDocuments>b__1)).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XtraReport>, ItemsSaleViewModel.<PrintDocuments>d__131>(ref awaiter2, ref this);
						return;
					}
					IL_157:
					XtraReport result2 = awaiter2.GetResult();
					this.<report>5__2.Pages.AddRange(result2.Pages);
					this.<>8__1 = null;
					IL_17C:
					if (!itemsSaleViewModel.PrintRn)
					{
						goto IL_2A4;
					}
					this.<>8__2 = new ItemsSaleViewModel.<>c__DisplayClass131_1();
					this.<>8__2.<>4__this = itemsSaleViewModel;
					awaiter3 = Task.Run<SaleDocument>(() => DocumentsModel.GetStoreDocument(base.Document.Id)).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__3 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<SaleDocument>, ItemsSaleViewModel.<PrintDocuments>d__131>(ref awaiter3, ref this);
						return;
					}
					IL_200:
					SaleDocument result3 = awaiter3.GetResult();
					this.<>8__2.doc = result3;
					awaiter2 = Task.Run<XtraReport>(new Func<XtraReport>(this.<>8__2.<PrintDocuments>b__3)).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XtraReport>, ItemsSaleViewModel.<PrintDocuments>d__131>(ref awaiter2, ref this);
						return;
					}
					IL_27D:
					XtraReport result4 = awaiter2.GetResult();
					this.<report>5__2.Pages.AddRange(result4.Pages);
					this.<>8__2 = null;
					IL_2A4:
					itemsSaleViewModel.HideWait();
					itemsSaleViewModel._reportPrintService.PrintPreview(this.<report>5__2, PrinterModel.Printer.Documents);
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<report>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_2DE:
				this.<>1__state = -2;
				this.<report>5__2 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060019C3 RID: 6595 RVA: 0x00049C20 File Offset: 0x00047E20
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000D38 RID: 3384
			public int <>1__state;

			// Token: 0x04000D39 RID: 3385
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000D3A RID: 3386
			public ItemsSaleViewModel <>4__this;

			// Token: 0x04000D3B RID: 3387
			private ItemsSaleViewModel.<>c__DisplayClass131_0 <>8__1;

			// Token: 0x04000D3C RID: 3388
			private ItemsSaleViewModel.<>c__DisplayClass131_1 <>8__2;

			// Token: 0x04000D3D RID: 3389
			private XtraReport <report>5__2;

			// Token: 0x04000D3E RID: 3390
			private TaskAwaiter<CashInOrder> <>u__1;

			// Token: 0x04000D3F RID: 3391
			private TaskAwaiter<XtraReport> <>u__2;

			// Token: 0x04000D40 RID: 3392
			private TaskAwaiter<SaleDocument> <>u__3;
		}

		// Token: 0x020001C5 RID: 453
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OutByInvoice>d__152 : IAsyncStateMachine
		{
			// Token: 0x060019C4 RID: 6596 RVA: 0x00049C3C File Offset: 0x00047E3C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsSaleViewModel itemsSaleViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						itemsSaleViewModel.ShowWait();
						awaiter = Task.Run<bool>(() => ItemsSaleModel.CancellReserve(base.Document.Items, null, true)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.<>1__state = num2;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, ItemsSaleViewModel.<OutByInvoice>d__152>(ref awaiter, ref this);
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
					DocumentsModel.SetDocStateAndTypeRn(itemsSaleViewModel.Document.Id, DocStates.RnMaked);
					ItemsModel.SubstractItems(itemsSaleViewModel.Document.Items, false);
					HistoryV2 historyV = new HistoryV2();
					IEnumerator<store_items> enumerator = itemsSaleViewModel.Document.Items.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							store_items item = enumerator.Current;
							itemsSaleViewModel._kassaModel.RealizatorItems2Balance(item, historyV);
						}
					}
					finally
					{
						if (num < 0 && enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					historyV.AddDocumentLog("InvoiceItemsIssued", itemsSaleViewModel.Document.Id, "");
					historyV.Save();
					itemsSaleViewModel.MinimumInStockCheck();
					itemsSaleViewModel.LoadDocument(itemsSaleViewModel.Document.Id);
					itemsSaleViewModel.HideWait();
					itemsSaleViewModel._toasterService.Success("");
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

			// Token: 0x060019C5 RID: 6597 RVA: 0x00049DE8 File Offset: 0x00047FE8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000D41 RID: 3393
			public int <>1__state;

			// Token: 0x04000D42 RID: 3394
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000D43 RID: 3395
			public ItemsSaleViewModel <>4__this;

			// Token: 0x04000D44 RID: 3396
			private TaskAwaiter<bool> <>u__1;
		}

		// Token: 0x020001C6 RID: 454
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SaveTrack>d__156 : IAsyncStateMachine
		{
			// Token: 0x060019C6 RID: 6598 RVA: 0x00049E04 File Offset: 0x00048004
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsSaleViewModel itemsSaleViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						itemsSaleViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter<IAscResult> awaiter;
						if (num != 0)
						{
							awaiter = Task.Run<IAscResult>(() => ItemsSaleModel.SaveTrack(base.Document)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IAscResult>, ItemsSaleViewModel.<SaveTrack>d__156>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IAscResult>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						awaiter.GetResult();
						itemsSaleViewModel._toasterService.Success(Lang.t("Saved"));
					}
					catch (Exception ex)
					{
						itemsSaleViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							itemsSaleViewModel.HideWait();
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

			// Token: 0x060019C7 RID: 6599 RVA: 0x00049F24 File Offset: 0x00048124
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000D45 RID: 3397
			public int <>1__state;

			// Token: 0x04000D46 RID: 3398
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000D47 RID: 3399
			public ItemsSaleViewModel <>4__this;

			// Token: 0x04000D48 RID: 3400
			private TaskAwaiter<IAscResult> <>u__1;
		}

		// Token: 0x020001C7 RID: 455
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SaveNotes>d__158 : IAsyncStateMachine
		{
			// Token: 0x060019C8 RID: 6600 RVA: 0x00049F40 File Offset: 0x00048140
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsSaleViewModel itemsSaleViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						itemsSaleViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter<IAscResult> awaiter;
						if (num != 0)
						{
							awaiter = Task.Run<IAscResult>(() => DocumentsModel.SaveNotes(base.Document)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IAscResult>, ItemsSaleViewModel.<SaveNotes>d__158>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IAscResult>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						awaiter.GetResult();
						itemsSaleViewModel._toasterService.Success(Lang.t("Saved"));
					}
					catch (Exception ex)
					{
						itemsSaleViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							itemsSaleViewModel.HideWait();
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

			// Token: 0x060019C9 RID: 6601 RVA: 0x0004A060 File Offset: 0x00048260
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000D49 RID: 3401
			public int <>1__state;

			// Token: 0x04000D4A RID: 3402
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000D4B RID: 3403
			public ItemsSaleViewModel <>4__this;

			// Token: 0x04000D4C RID: 3404
			private TaskAwaiter<IAscResult> <>u__1;
		}

		// Token: 0x020001C8 RID: 456
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ClientMatchClick>d__177 : IAsyncStateMachine
		{
			// Token: 0x060019CA RID: 6602 RVA: 0x0004A07C File Offset: 0x0004827C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsSaleViewModel itemsSaleViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (itemsSaleViewModel.SelectedMatch == null)
						{
							goto IL_BA;
						}
						itemsSaleViewModel.EnableSearch = false;
						itemsSaleViewModel.ShowWait();
						awaiter = Task.Run(delegate()
						{
							base.Document.SetCustomer(base.SelectedMatch.ClientId);
						}).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ItemsSaleViewModel.<ClientMatchClick>d__177>(ref awaiter, ref this);
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
					itemsSaleViewModel.HideWait();
					itemsSaleViewModel.AfterClientSelect();
					itemsSaleViewModel.EnableSearch = true;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_BA:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060019CB RID: 6603 RVA: 0x0004A168 File Offset: 0x00048368
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000D4D RID: 3405
			public int <>1__state;

			// Token: 0x04000D4E RID: 3406
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000D4F RID: 3407
			public ItemsSaleViewModel <>4__this;

			// Token: 0x04000D50 RID: 3408
			private TaskAwaiter <>u__1;
		}
	}
}
