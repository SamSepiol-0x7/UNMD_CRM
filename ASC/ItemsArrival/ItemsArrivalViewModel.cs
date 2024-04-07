using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using ASC.Clients;
using ASC.Common.Interfaces;
using ASC.Common.Objects;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Objects.Converters;
using ASC.Options;
using ASC.RKO;
using ASC.Services.Abstract;
using ASC.Stickers;
using ASC.ViewModels;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.XtraReports.UI;
using Microsoft.Win32;

namespace ASC.ItemsArrival
{
	// Token: 0x020001D5 RID: 469
	public class ItemsArrivalViewModel : CollectionViewModel<Product>, ICustomerSelect
	{
		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06001A25 RID: 6693 RVA: 0x0004BEB4 File Offset: 0x0004A0B4
		// (set) Token: 0x06001A26 RID: 6694 RVA: 0x0004BEC8 File Offset: 0x0004A0C8
		public ObservableCollection<boxes> Boxes
		{
			[CompilerGenerated]
			get
			{
				return this.<Boxes>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Boxes>k__BackingField, value))
				{
					return;
				}
				this.<Boxes>k__BackingField = value;
				this.RaisePropertyChanged("Boxes");
			}
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06001A27 RID: 6695 RVA: 0x0004BEF8 File Offset: 0x0004A0F8
		// (set) Token: 0x06001A28 RID: 6696 RVA: 0x0004BF0C File Offset: 0x0004A10C
		public List<stores> Stores
		{
			[CompilerGenerated]
			get
			{
				return this.<Stores>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Stores>k__BackingField, value))
				{
					return;
				}
				this.<Stores>k__BackingField = value;
				this.RaisePropertyChanged("Stores");
			}
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06001A29 RID: 6697 RVA: 0x0004BF3C File Offset: 0x0004A13C
		// (set) Token: 0x06001A2A RID: 6698 RVA: 0x0004BF50 File Offset: 0x0004A150
		public bool PrintRko
		{
			[CompilerGenerated]
			get
			{
				return this.<PrintRko>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PrintRko>k__BackingField == value)
				{
					return;
				}
				this.<PrintRko>k__BackingField = value;
				this.RaisePropertyChanged("PrintRko");
			}
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06001A2B RID: 6699 RVA: 0x0004BF7C File Offset: 0x0004A17C
		// (set) Token: 0x06001A2C RID: 6700 RVA: 0x0004BF90 File Offset: 0x0004A190
		public int PaymentOption
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentOption>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PaymentOption>k__BackingField == value)
				{
					return;
				}
				this.<PaymentOption>k__BackingField = value;
				this.RaisePropertyChanged("PaymentOption");
			}
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06001A2D RID: 6701 RVA: 0x0004BFBC File Offset: 0x0004A1BC
		// (set) Token: 0x06001A2E RID: 6702 RVA: 0x0004BFD0 File Offset: 0x0004A1D0
		public List<ItemUnits> Units
		{
			[CompilerGenerated]
			get
			{
				return this.<Units>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Units>k__BackingField, value))
				{
					return;
				}
				this.<Units>k__BackingField = value;
				this.RaisePropertyChanged("Units");
			}
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06001A2F RID: 6703 RVA: 0x0004C000 File Offset: 0x0004A200
		// (set) Token: 0x06001A30 RID: 6704 RVA: 0x0004C044 File Offset: 0x0004A244
		public stores SelectedStore
		{
			get
			{
				return base.GetProperty<stores>(() => this.SelectedStore);
			}
			set
			{
				if (object.Equals(this.SelectedStore, value))
				{
					return;
				}
				base.SetProperty<stores>(() => this.SelectedStore, value, new Action(this.OnStoreChange));
				this.RaisePropertyChanged("SelectedStore");
			}
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06001A31 RID: 6705 RVA: 0x0004C0B0 File Offset: 0x0004A2B0
		// (set) Token: 0x06001A32 RID: 6706 RVA: 0x0004C0C4 File Offset: 0x0004A2C4
		public List<PriceOptions> PriceOptionses
		{
			[CompilerGenerated]
			get
			{
				return this.<PriceOptionses>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<PriceOptionses>k__BackingField, value))
				{
					return;
				}
				this.<PriceOptionses>k__BackingField = value;
				this.RaisePropertyChanged("PriceOptionses");
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06001A33 RID: 6707 RVA: 0x0004C0F4 File Offset: 0x0004A2F4
		// (set) Token: 0x06001A34 RID: 6708 RVA: 0x0004C108 File Offset: 0x0004A308
		public ICustomer Dealer
		{
			[CompilerGenerated]
			get
			{
				return this.<Dealer>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Dealer>k__BackingField, value))
				{
					return;
				}
				this.<Dealer>k__BackingField = value;
				this.RaisePropertyChanged("Dealer");
			}
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06001A35 RID: 6709 RVA: 0x0004C138 File Offset: 0x0004A338
		// (set) Token: 0x06001A36 RID: 6710 RVA: 0x0004C17C File Offset: 0x0004A37C
		public int TabIndex
		{
			get
			{
				return base.GetProperty<int>(() => this.TabIndex);
			}
			set
			{
				if (this._tabIndex != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = 683906790;
				IL_10:
				switch ((num ^ 1415315011) % 4)
				{
				case 1:
					return;
				case 2:
					IL_2F:
					base.SetProperty<int>(() => this.TabIndex, value, new Action(this.OnTabChanged));
					num = 1195257499;
					goto IL_10;
				case 3:
					goto IL_0B;
				}
				this.RaisePropertyChanged("TabIndex");
			}
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06001A37 RID: 6711 RVA: 0x0004C210 File Offset: 0x0004A410
		// (set) Token: 0x06001A38 RID: 6712 RVA: 0x0004C224 File Offset: 0x0004A424
		public cash_orders SelectedPkoRko
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedPkoRko>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedPkoRko>k__BackingField, value))
				{
					return;
				}
				this.<SelectedPkoRko>k__BackingField = value;
				this.RaisePropertyChanged("SelectedPkoRko");
			}
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06001A39 RID: 6713 RVA: 0x0004C254 File Offset: 0x0004A454
		// (set) Token: 0x06001A3A RID: 6714 RVA: 0x0004C268 File Offset: 0x0004A468
		public bool OnlyForSc
		{
			get
			{
				return this._onlyForSc;
			}
			set
			{
				if (this._onlyForSc != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -895698644;
				IL_10:
				switch ((num ^ -1509498145) % 4)
				{
				case 0:
					goto IL_0B;
				case 1:
					IL_2F:
					this._onlyForSc = value;
					this.RaisePropertyChanged("OnlyForSc");
					this.SetNotForSale();
					num = -1975953667;
					goto IL_10;
				case 3:
					return;
				}
			}
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06001A3B RID: 6715 RVA: 0x0004C2C4 File Offset: 0x0004A4C4
		// (set) Token: 0x06001A3C RID: 6716 RVA: 0x0004C2D8 File Offset: 0x0004A4D8
		public bool ZeroPrice
		{
			[CompilerGenerated]
			get
			{
				return this.<ZeroPrice>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ZeroPrice>k__BackingField == value)
				{
					return;
				}
				this.<ZeroPrice>k__BackingField = value;
				this.RaisePropertyChanged("ZeroPrice");
			}
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06001A3D RID: 6717 RVA: 0x0004C304 File Offset: 0x0004A504
		// (set) Token: 0x06001A3E RID: 6718 RVA: 0x0004C318 File Offset: 0x0004A518
		public List<store_cats> Categories
		{
			[CompilerGenerated]
			get
			{
				return this.<Categories>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Categories>k__BackingField, value))
				{
					return;
				}
				this.<Categories>k__BackingField = value;
				this.RaisePropertyChanged("Categories");
			}
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x06001A3F RID: 6719 RVA: 0x0004C348 File Offset: 0x0004A548
		// (set) Token: 0x06001A40 RID: 6720 RVA: 0x0004C35C File Offset: 0x0004A55C
		public List<cash_orders> RkoOrders
		{
			[CompilerGenerated]
			get
			{
				return this.<RkoOrders>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<RkoOrders>k__BackingField, value))
				{
					return;
				}
				this.<RkoOrders>k__BackingField = value;
				this.RaisePropertyChanged("RkoOrders");
			}
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x06001A41 RID: 6721 RVA: 0x0004C38C File Offset: 0x0004A58C
		// (set) Token: 0x06001A42 RID: 6722 RVA: 0x0004C3A0 File Offset: 0x0004A5A0
		public List<logs> Logses
		{
			[CompilerGenerated]
			get
			{
				return this.<Logses>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Logses>k__BackingField, value))
				{
					return;
				}
				this.<Logses>k__BackingField = value;
				this.RaisePropertyChanged("Logses");
			}
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x06001A43 RID: 6723 RVA: 0x0004C3D0 File Offset: 0x0004A5D0
		// (set) Token: 0x06001A44 RID: 6724 RVA: 0x0004C3E4 File Offset: 0x0004A5E4
		public decimal CurrencyRateDifference
		{
			[CompilerGenerated]
			get
			{
				return this.<CurrencyRateDifference>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<CurrencyRateDifference>k__BackingField, value))
				{
					return;
				}
				this.<CurrencyRateDifference>k__BackingField = value;
				this.RaisePropertyChanged("CurrencyRateDifference");
			}
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x06001A45 RID: 6725 RVA: 0x0004C414 File Offset: 0x0004A614
		// (set) Token: 0x06001A46 RID: 6726 RVA: 0x0004C428 File Offset: 0x0004A628
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

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06001A47 RID: 6727 RVA: 0x0004C458 File Offset: 0x0004A658
		// (set) Token: 0x06001A48 RID: 6728 RVA: 0x0004C46C File Offset: 0x0004A66C
		public bool CreateRko
		{
			get
			{
				return this._createRko;
			}
			set
			{
				if (this._createRko == value)
				{
					return;
				}
				this._createRko = value;
				this.RaisePropertyChanged("CreateRko");
				if (!value)
				{
					this.PrintRko = false;
				}
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x06001A49 RID: 6729 RVA: 0x0004C4A4 File Offset: 0x0004A6A4
		// (set) Token: 0x06001A4A RID: 6730 RVA: 0x0004C4B8 File Offset: 0x0004A6B8
		public bool PrintPrihodNakl
		{
			[CompilerGenerated]
			get
			{
				return this.<PrintPrihodNakl>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PrintPrihodNakl>k__BackingField == value)
				{
					return;
				}
				this.<PrintPrihodNakl>k__BackingField = value;
				this.RaisePropertyChanged("PrintPrihodNakl");
			}
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x06001A4B RID: 6731 RVA: 0x0004C4E4 File Offset: 0x0004A6E4
		// (set) Token: 0x06001A4C RID: 6732 RVA: 0x0004C4F8 File Offset: 0x0004A6F8
		public bool IsEditable
		{
			[CompilerGenerated]
			get
			{
				return this.<IsEditable>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IsEditable>k__BackingField == value)
				{
					return;
				}
				this.<IsEditable>k__BackingField = value;
				this.RaisePropertyChanged("IsEditableInverse");
				this.RaisePropertyChanged("IsEditable");
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x06001A4D RID: 6733 RVA: 0x0004C530 File Offset: 0x0004A730
		public bool IsEditableInverse
		{
			get
			{
				return !this.IsEditable;
			}
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06001A4E RID: 6734 RVA: 0x0004C548 File Offset: 0x0004A748
		// (set) Token: 0x06001A4F RID: 6735 RVA: 0x0004C55C File Offset: 0x0004A75C
		public bool All2IStore
		{
			get
			{
				return this._all2IStore;
			}
			set
			{
				if (this._all2IStore == value)
				{
					return;
				}
				this._all2IStore = value;
				this.RaisePropertyChanged("All2IStore");
				this.ToIStore(this._all2IStore);
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x06001A50 RID: 6736 RVA: 0x0004C594 File Offset: 0x0004A794
		// (set) Token: 0x06001A51 RID: 6737 RVA: 0x0004C5A8 File Offset: 0x0004A7A8
		public int ItemState4All
		{
			get
			{
				return this._itemState4All;
			}
			set
			{
				if (this._itemState4All == value)
				{
					return;
				}
				this._itemState4All = value;
				this.RaisePropertyChanged("ItemState4All");
				this.SetStateToAll(this._itemState4All);
			}
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x06001A52 RID: 6738 RVA: 0x0004C5E0 File Offset: 0x0004A7E0
		// (set) Token: 0x06001A53 RID: 6739 RVA: 0x0004C5F4 File Offset: 0x0004A7F4
		public int CategoryForAll
		{
			get
			{
				return this._categoryForAll;
			}
			set
			{
				if (this._categoryForAll == value)
				{
					return;
				}
				this._categoryForAll = value;
				this.RaisePropertyChanged("CategoryForAll");
				ObservableCollection<Product> items = base.Items;
				if (items != null && items.Count > 0)
				{
					foreach (Product product in base.Items)
					{
						product.CategoryId = value;
					}
				}
			}
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06001A54 RID: 6740 RVA: 0x0004C678 File Offset: 0x0004A878
		// (set) Token: 0x06001A55 RID: 6741 RVA: 0x0004C68C File Offset: 0x0004A88C
		public docs Document
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
				this.RaisePropertyChanged("Document");
			}
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06001A56 RID: 6742 RVA: 0x0004C6BC File Offset: 0x0004A8BC
		// (set) Token: 0x06001A57 RID: 6743 RVA: 0x0004C6D0 File Offset: 0x0004A8D0
		public ObservableCollection<items_state> States
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

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06001A58 RID: 6744 RVA: 0x0004C700 File Offset: 0x0004A900
		// (set) Token: 0x06001A59 RID: 6745 RVA: 0x0004C714 File Offset: 0x0004A914
		public int TotalItems
		{
			[CompilerGenerated]
			get
			{
				return this.<TotalItems>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<TotalItems>k__BackingField == value)
				{
					return;
				}
				this.<TotalItems>k__BackingField = value;
				this.RaisePropertyChanged("TotalItems");
			}
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x0004C740 File Offset: 0x0004A940
		private void IoC()
		{
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
			this.StoreService = Bootstrapper.Container.Resolve<IStoreService>();
			this._ascMessageBoxService = Bootstrapper.Container.Resolve<IAscMessageBoxService>();
			this._reportPrintService = Bootstrapper.Container.Resolve<IReportPrintService>();
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x0004C7B0 File Offset: 0x0004A9B0
		public ItemsArrivalViewModel()
		{
			this.IoC();
			this.SetViewName("ItemsArrival");
			this.LoadCommonData();
			this.Document = new docs(true)
			{
				id = 0,
				type = 1,
				price_option = 1,
				is_realization = false
			};
			if (Auth.User.offices1 != null)
			{
				this.Document.company = Auth.User.offices1.default_company;
			}
			this.Init();
			this.BgInitDoWork();
			this.ItemsChanged();
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x0004C8A4 File Offset: 0x0004AAA4
		public ItemsArrivalViewModel(int documentId)
		{
			this.IoC();
			this.SetViewName("Pn", documentId);
			this.LoadCommonData();
			this.IsEditable = false;
			this.Init();
			this.BgInitDoWork(documentId);
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x0004C94C File Offset: 0x0004AB4C
		public ItemsArrivalViewModel(IEnumerable<parts_request> requestItems) : this()
		{
			foreach (parts_request parts_request in requestItems)
			{
				store_items store_items = new store_items
				{
					in_count = parts_request.count,
					part_request = new int?(parts_request.id)
				};
				if (parts_request.summ != null && parts_request.count > 0)
				{
					store_items.in_price = parts_request.summ.Value / parts_request.count;
				}
				if (parts_request.item_id == null)
				{
					store_items.name = parts_request.item_name;
					store_items.state = 1;
				}
				else
				{
					store_items.name = parts_request.store_items.name;
					store_items.category = parts_request.store_items.category;
					store_items.state = parts_request.store_items.state;
				}
				base.Items.Add(store_items.ToStoreItem());
			}
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x0004CA64 File Offset: 0x0004AC64
		private void LoadCommonData()
		{
			this.Units = this.StoreService.GetUnits();
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x0004CA84 File Offset: 0x0004AC84
		private void ItemsChanged()
		{
			base.Items.CollectionChanged += delegate(object sender, NotifyCollectionChangedEventArgs e)
			{
				this.CountTotal();
			};
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x0004CAA8 File Offset: 0x0004ACA8
		private void OnTabChanged()
		{
			if (this.TabIndex == 1)
			{
				this.LoadHistory();
			}
		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x0004CAC4 File Offset: 0x0004ACC4
		private void SetNotForSale()
		{
			foreach (Product product in base.Items)
			{
				product.NotForSale = this._onlyForSc;
			}
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x0004CB18 File Offset: 0x0004AD18
		private void OnStoreChange()
		{
			if (this.SelectedStore != null && this.Document != null)
			{
				this.Document.store = new int?(this.SelectedStore.id);
				this.LoadCategories(this.Document.store.Value);
				this.LoadBoxes();
				return;
			}
		}

		// Token: 0x06001A63 RID: 6755 RVA: 0x0004CB70 File Offset: 0x0004AD70
		[Command]
		public void RowDoubleClick()
		{
			if (base.SelectedItem == null)
			{
				goto IL_35;
			}
			goto IL_6D;
			int num;
			for (;;)
			{
				IL_3A:
				switch ((num ^ 1274434647) % 6)
				{
				case 0:
					goto IL_6D;
				case 1:
					goto IL_7C;
				case 2:
					goto IL_35;
				case 3:
					return;
				case 4:
					this._navigationService.NavigateToStoreItem(base.SelectedItem.Id, 0);
					num = 1516662034;
					continue;
				}
				break;
			}
			return;
			IL_7C:
			this._windowedDocumentService.ShowNewDocument("NewStoreItemView", new NewProductViewModel(this.SelectedStore, this.Categories, this.Boxes, this.Document.price_option, base.SelectedItem), this, null);
			return;
			IL_35:
			num = 1046889252;
			goto IL_3A;
			IL_6D:
			num = ((this.Document.id != 0) ? 1605138125 : 1627471532);
			goto IL_3A;
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x0004CC38 File Offset: 0x0004AE38
		[Command]
		public void ExcelImport()
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = "Excel  (*.XLS, *.XLSX) | *.XLS; *.XLSX"
			};
			bool? flag = openFileDialog.ShowDialog();
			if (flag.GetValueOrDefault() & flag != null)
			{
				try
				{
					List<Product> list = new List<Product>(this._itemsArrivalModel.ImportFromExcel(openFileDialog.FileName));
					List<boxes> list2 = (from i in list
					select new boxes
					{
						id = 0,
						name = i.BoxName
					}).ToList<boxes>();
					if (list2.Any<boxes>())
					{
						if (this.Boxes == null)
						{
							this.Boxes = new ObservableCollection<boxes>();
						}
						this.Boxes = new ObservableCollection<boxes>(this.Boxes.Union(list2));
					}
					foreach (Product product in list)
					{
						product.State = this.ItemState4All;
						product.Warranty = WarrantyOptions.State2DefaultWarrany(this.ItemState4All);
						product.ShopEnable = new bool?(this.All2IStore);
						product.NotForSale = this.OnlyForSc;
						base.Items.Add(product);
					}
				}
				catch (IOException ex)
				{
					this._toasterService.Error(ex.Message);
				}
				catch (Exception ex2)
				{
					this._toasterService.Error(ex2.Message);
				}
			}
		}

		// Token: 0x06001A65 RID: 6757 RVA: 0x0004CDB4 File Offset: 0x0004AFB4
		[Command]
		public void OpenDealerCard()
		{
			if (this.Document.dealer != null)
			{
				this._navigationService.NavigateToCustomerCard(this.Document.dealer.Value, null);
			}
		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x0004CDF8 File Offset: 0x0004AFF8
		private void Init()
		{
			ItemsArrivalViewModel.<Init>d__123 <Init>d__;
			<Init>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<ItemsArrivalViewModel.<Init>d__123>(ref <Init>d__);
		}

		// Token: 0x06001A67 RID: 6759 RVA: 0x0004CE30 File Offset: 0x0004B030
		private void SetLoaded(bool value)
		{
			this._loaded = value;
			base.RaiseCanExecuteChanged(() => this.AddItem());
		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x0004CE80 File Offset: 0x0004B080
		private void BgInitDoWork(int documentId)
		{
			ItemsArrivalViewModel.<BgInitDoWork>d__125 <BgInitDoWork>d__;
			<BgInitDoWork>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<BgInitDoWork>d__.<>4__this = this;
			<BgInitDoWork>d__.documentId = documentId;
			<BgInitDoWork>d__.<>1__state = -1;
			<BgInitDoWork>d__.<>t__builder.Start<ItemsArrivalViewModel.<BgInitDoWork>d__125>(ref <BgInitDoWork>d__);
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x0004CEC0 File Offset: 0x0004B0C0
		private Task LoadDocument(int documentId)
		{
			ItemsArrivalViewModel.<LoadDocument>d__126 <LoadDocument>d__;
			<LoadDocument>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadDocument>d__.<>4__this = this;
			<LoadDocument>d__.documentId = documentId;
			<LoadDocument>d__.<>1__state = -1;
			<LoadDocument>d__.<>t__builder.Start<ItemsArrivalViewModel.<LoadDocument>d__126>(ref <LoadDocument>d__);
			return <LoadDocument>d__.<>t__builder.Task;
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x0004CF0C File Offset: 0x0004B10C
		private void BgInitDoWork()
		{
			if (this.Document.store != null)
			{
				this.LoadCategories(this.Document.store.Value);
			}
			if (this.Document != null && this.Boxes == null)
			{
				this.LoadBoxes();
			}
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x0004CF60 File Offset: 0x0004B160
		private void LoadCategories(int storeId)
		{
			ItemsArrivalViewModel.<LoadCategories>d__128 <LoadCategories>d__;
			<LoadCategories>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadCategories>d__.<>4__this = this;
			<LoadCategories>d__.storeId = storeId;
			<LoadCategories>d__.<>1__state = -1;
			<LoadCategories>d__.<>t__builder.Start<ItemsArrivalViewModel.<LoadCategories>d__128>(ref <LoadCategories>d__);
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x0004CFA0 File Offset: 0x0004B1A0
		public void LoadBoxes()
		{
			ItemsArrivalViewModel.<LoadBoxes>d__129 <LoadBoxes>d__;
			<LoadBoxes>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadBoxes>d__.<>4__this = this;
			<LoadBoxes>d__.<>1__state = -1;
			<LoadBoxes>d__.<>t__builder.Start<ItemsArrivalViewModel.<LoadBoxes>d__129>(ref <LoadBoxes>d__);
		}

		// Token: 0x06001A6D RID: 6765 RVA: 0x0004CFD8 File Offset: 0x0004B1D8
		[Command]
		public void AddItem()
		{
			int? store = this.Document.store;
			if (store.GetValueOrDefault() <= 0 & store != null)
			{
				this._toasterService.Info(Lang.t("SelectStore"));
				return;
			}
			Product item = this.AddNewItem();
			this._windowedDocumentService.ShowNewDocument("NewStoreItemView", new NewProductViewModel(this.SelectedStore, this.Categories, this.Boxes, this.Document.price_option, item), this, null);
		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x0004D05C File Offset: 0x0004B25C
		public bool CanAddItem()
		{
			if (this.Document != null && this._loaded)
			{
				int? store = this.Document.store;
				return store.GetValueOrDefault() > 0 & store != null;
			}
			return false;
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x0004D09C File Offset: 0x0004B29C
		public Product AddNewItem()
		{
			Product product = ItemsModel.DefaultItem().ToStoreItem();
			product.State = this.ItemState4All;
			product.Warranty = WarrantyOptions.State2DefaultWarrany(this.ItemState4All);
			product.NotForSale = this.OnlyForSc;
			product.ShopEnable = new bool?(this.All2IStore);
			product.InCount = 1;
			if (this.CategoryForAll != 0)
			{
				product.CategoryId = this.CategoryForAll;
			}
			base.Items.Add(product);
			return product;
		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x0004D118 File Offset: 0x0004B318
		public void ToIStore(bool enable)
		{
			ObservableCollection<Product> items = base.Items;
			if (items != null && items.Count > 0)
			{
				foreach (Product product in base.Items)
				{
					product.ShopEnable = new bool?(enable);
				}
			}
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x0004D180 File Offset: 0x0004B380
		public void SetStateToAll(int state)
		{
			ObservableCollection<Product> items = base.Items;
			if (items != null && items.Count > 0)
			{
				foreach (Product product in base.Items)
				{
					product.State = state;
				}
			}
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x0004D1E4 File Offset: 0x0004B3E4
		public void CountTotal()
		{
			this.Document.total = (from i in base.Items
			select i.InSumm).DefaultIfEmpty<decimal>().Sum();
			this.TotalItems = (from i in base.Items
			select i.InCount).DefaultIfEmpty<int>().Sum();
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x0004D26C File Offset: 0x0004B46C
		[Command]
		public void RemoveItem(object obj)
		{
			Product product = obj as Product;
			if (product != null)
			{
				base.Items.Remove(product);
			}
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x0004D290 File Offset: 0x0004B490
		public bool CanRemoveItem(object obj)
		{
			return base.Items != null;
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x0004D2A8 File Offset: 0x0004B4A8
		[AsyncCommand]
		public Task MakeItems()
		{
			ItemsArrivalViewModel.<MakeItems>d__140 <MakeItems>d__;
			<MakeItems>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<MakeItems>d__.<>4__this = this;
			<MakeItems>d__.<>1__state = -1;
			<MakeItems>d__.<>t__builder.Start<ItemsArrivalViewModel.<MakeItems>d__140>(ref <MakeItems>d__);
			return <MakeItems>d__.<>t__builder.Task;
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x0004D2EC File Offset: 0x0004B4EC
		public bool CanMakeItems()
		{
			return this.Document != null && this.Document.id == 0;
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x0004D314 File Offset: 0x0004B514
		private void PrintDocuments()
		{
			ItemsArrivalViewModel.<PrintDocuments>d__142 <PrintDocuments>d__;
			<PrintDocuments>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<PrintDocuments>d__.<>4__this = this;
			<PrintDocuments>d__.<>1__state = -1;
			<PrintDocuments>d__.<>t__builder.Start<ItemsArrivalViewModel.<PrintDocuments>d__142>(ref <PrintDocuments>d__);
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x0004D34C File Offset: 0x0004B54C
		[Command]
		public void PrintStickers()
		{
			this._windowedDocumentService.ShowNewDocument("StickersView", new StickersViewModel((from i in base.Items
			select i.Id).ToList<int>()), null, null);
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x0004D3A0 File Offset: 0x0004B5A0
		public bool CanPrintStickers()
		{
			return base.Items.Any((Product i) => i.Id > 0);
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x0004D3D8 File Offset: 0x0004B5D8
		[Command]
		public void PrintPn()
		{
			ItemsArrivalViewModel.<PrintPn>d__145 <PrintPn>d__;
			<PrintPn>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<PrintPn>d__.<>4__this = this;
			<PrintPn>d__.<>1__state = -1;
			<PrintPn>d__.<>t__builder.Start<ItemsArrivalViewModel.<PrintPn>d__145>(ref <PrintPn>d__);
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x0004D410 File Offset: 0x0004B610
		private bool CheckItemFields(Product item)
		{
			if (!base.CheckFields(item))
			{
				return false;
			}
			if (this.Document.is_realization)
			{
				if (this.Document.price_option == 1)
				{
					if (item.InPrice == 0m)
					{
						this._toasterService.Info(Lang.t("ItemPriceError"));
						return false;
					}
				}
			}
			if (this.ZeroPrice || !(item.InPrice == 0m) || this.Document.is_realization)
			{
				return true;
			}
			this._toasterService.Info(Lang.t("ItemPriceError"));
			return false;
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x0004D4B0 File Offset: 0x0004B6B0
		private bool CheckFields()
		{
			if (base.Items == null || !base.Items.Any<Product>())
			{
				this._toasterService.Info(Lang.t("AddItem"));
				return false;
			}
			if (this.Document.price_option == 2)
			{
				if (this.CurrencyRate == 0m)
				{
					this._toasterService.Info(Lang.t("CurrencyWarning"));
					return false;
				}
			}
			if (!this.Document.is_realization && this.Document.price_option == 3)
			{
				this._toasterService.Info(Lang.t("WrongType"));
				return false;
			}
			if (this.Document.is_realization && this.Document.price_option == 3 && this.Document.return_percent == 0)
			{
				this._toasterService.Info(Lang.t("InputRealizatorPercent"));
				return false;
			}
			if (!this.Document.is_realization || this.Dealer == null || this.Dealer.IsRealizator)
			{
				if (this.Document.dealer != null)
				{
					int? num = this.Document.dealer;
					if (!(num.GetValueOrDefault() == 0 & num != null))
					{
						if (this.Document.store != null)
						{
							num = this.Document.store;
							if (!(num.GetValueOrDefault() == 0 & num != null))
							{
								if (Auth.Config.is_reason_req && string.IsNullOrEmpty(this.Document.reason))
								{
									this._toasterService.Info(Lang.t("PnReasonRequired"));
									return false;
								}
								return !base.Items.Any((Product item) => !this.CheckItemFields(item));
							}
						}
						this._toasterService.Info(Lang.t("SelectStore"));
						return false;
					}
				}
				this._toasterService.Info(Lang.t("SelectDealer"));
				return false;
			}
			if (this._ascMessageBoxService.ShowMessageBox(Lang.t("ClientNotDealer"), Lang.t("ClientNotDealerTitle"), MessageBoxButton.YesNo, MessageBoxImage.Exclamation) != MessageBoxResult.Yes)
			{
				return false;
			}
			ClientsModel.MakeCustomerDealer(this.Dealer.Id);
			return true;
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x0004D6EC File Offset: 0x0004B8EC
		[Command]
		public void SelectDealer()
		{
			if (this.Document.id != 0)
			{
				return;
			}
			this._navigationService.Navigate("ClientsView", new ClientsViewModel("selectDealer"), this);
		}

		// Token: 0x06001A7E RID: 6782 RVA: 0x0004D724 File Offset: 0x0004B924
		public void SelectCustomerFromList(ICustomer customer)
		{
			this.Document.dealer = new int?(customer.Id);
			this.Dealer = customer;
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x0004D750 File Offset: 0x0004B950
		public void LoadHistory()
		{
			ItemsArrivalViewModel.<LoadHistory>d__150 <LoadHistory>d__;
			<LoadHistory>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadHistory>d__.<>4__this = this;
			<LoadHistory>d__.<>1__state = -1;
			<LoadHistory>d__.<>t__builder.Start<ItemsArrivalViewModel.<LoadHistory>d__150>(ref <LoadHistory>d__);
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x0004D788 File Offset: 0x0004B988
		[Command]
		public void RefreshCategories()
		{
			if (this.Document.store != null)
			{
				this.LoadCategories(this.Document.store.Value);
			}
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x0004D7C4 File Offset: 0x0004B9C4
		[Command]
		public void PkoRkoItemDoubleClick()
		{
			if (this.SelectedPkoRko != null)
			{
				goto IL_2C;
			}
			IL_08:
			int num = 860238527;
			IL_0D:
			switch ((num ^ 162329002) % 4)
			{
			case 1:
				return;
			case 2:
				IL_2C:
				this._navigationService.Navigate("RkoView", new RkoViewModel(this.SelectedPkoRko.id));
				num = 880990850;
				goto IL_0D;
			case 3:
				goto IL_08;
			}
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x0004D828 File Offset: 0x0004BA28
		[Command]
		public void CancellPn()
		{
			if (this.Document != null && this.Document.id != 0)
			{
				if (this._ascMessageBoxService.ShowMessageBox(Lang.t("CancellPn"), Lang.t("CancellPn"), MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
				{
					string text = this._itemsArrivalModel.CancellPn(this.Document.id);
					if (text == Lang.t("Complete"))
					{
						this._toasterService.Success(Lang.t("Complete"));
						if (this.Document != null)
						{
							this.BgInitDoWork(this.Document.id);
							return;
						}
					}
					else
					{
						this._toasterService.Error(text);
					}
				}
				return;
			}
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x0004D8DC File Offset: 0x0004BADC
		public bool CanCancellPn()
		{
			if (this.Document == null || !OfflineData.Instance.Employee.Can(56, 0))
			{
				return false;
			}
			int? state = this.Document.state;
			if (state.GetValueOrDefault() == 2 & state != null)
			{
				return true;
			}
			state = this.Document.state;
			return state.GetValueOrDefault() == 1 & state != null;
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x0004D948 File Offset: 0x0004BB48
		[CompilerGenerated]
		private void <ItemsChanged>b__116_0(object sender, NotifyCollectionChangedEventArgs e)
		{
			this.CountTotal();
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x0004D95C File Offset: 0x0004BB5C
		[CompilerGenerated]
		private Task<List<items_state>> <Init>b__123_2()
		{
			return this.StoreService.GetProductStatesAsync();
		}

		// Token: 0x06001A86 RID: 6790 RVA: 0x0004D974 File Offset: 0x0004BB74
		[CompilerGenerated]
		private Task<int> <MakeItems>b__140_0()
		{
			return this._itemsArrivalModel.CreateArrivalDocument(this.Document, new List<Product>(base.Items), this.CreateRko, this.PaymentOption);
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x0004D9AC File Offset: 0x0004BBAC
		[CompilerGenerated]
		private Task<StoreDocument> <PrintDocuments>b__142_0()
		{
			return DocumentsModel.GetDocument(this.Document.id);
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x0004D9CC File Offset: 0x0004BBCC
		[CompilerGenerated]
		private Task<CashInOrder> <PrintDocuments>b__142_2()
		{
			return KassaModel.GetCashInOrder(this.Document.order_id.Value);
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x0004D9F4 File Offset: 0x0004BBF4
		[CompilerGenerated]
		private bool <CheckFields>b__147_0(Product item)
		{
			return !this.CheckItemFields(item);
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x0004DA0C File Offset: 0x0004BC0C
		[CompilerGenerated]
		private Task<List<cash_orders>> <LoadHistory>b__150_0()
		{
			return this._itemsArrivalModel.LoadCashOrders(this.Document.id);
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x0004DA30 File Offset: 0x0004BC30
		[CompilerGenerated]
		private Task<List<logs>> <LoadHistory>b__150_1()
		{
			return DocumentsModel.LoadHistory(this.Document.id);
		}

		// Token: 0x04000D9C RID: 3484
		private INavigationService _navigationService;

		// Token: 0x04000D9D RID: 3485
		private IToasterService _toasterService;

		// Token: 0x04000D9E RID: 3486
		protected IStoreService StoreService;

		// Token: 0x04000D9F RID: 3487
		private IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04000DA0 RID: 3488
		private IAscMessageBoxService _ascMessageBoxService;

		// Token: 0x04000DA1 RID: 3489
		private ItemsArrivalModel _itemsArrivalModel = new ItemsArrivalModel();

		// Token: 0x04000DA2 RID: 3490
		[CompilerGenerated]
		private ObservableCollection<boxes> <Boxes>k__BackingField;

		// Token: 0x04000DA3 RID: 3491
		[CompilerGenerated]
		private List<stores> <Stores>k__BackingField;

		// Token: 0x04000DA4 RID: 3492
		[CompilerGenerated]
		private bool <PrintRko>k__BackingField = Auth.Config.qs_print_rko;

		// Token: 0x04000DA5 RID: 3493
		[CompilerGenerated]
		private int <PaymentOption>k__BackingField;

		// Token: 0x04000DA6 RID: 3494
		[CompilerGenerated]
		private List<ItemUnits> <Units>k__BackingField;

		// Token: 0x04000DA7 RID: 3495
		[CompilerGenerated]
		private List<PriceOptions> <PriceOptionses>k__BackingField = new PriceOptions().GetAllOptions();

		// Token: 0x04000DA8 RID: 3496
		[CompilerGenerated]
		private ICustomer <Dealer>k__BackingField;

		// Token: 0x04000DA9 RID: 3497
		[CompilerGenerated]
		private cash_orders <SelectedPkoRko>k__BackingField;

		// Token: 0x04000DAA RID: 3498
		[CompilerGenerated]
		private bool <ZeroPrice>k__BackingField;

		// Token: 0x04000DAB RID: 3499
		[CompilerGenerated]
		private List<store_cats> <Categories>k__BackingField;

		// Token: 0x04000DAC RID: 3500
		[CompilerGenerated]
		private List<cash_orders> <RkoOrders>k__BackingField;

		// Token: 0x04000DAD RID: 3501
		[CompilerGenerated]
		private List<logs> <Logses>k__BackingField;

		// Token: 0x04000DAE RID: 3502
		[CompilerGenerated]
		private decimal <CurrencyRateDifference>k__BackingField;

		// Token: 0x04000DAF RID: 3503
		[CompilerGenerated]
		private decimal <CurrencyRate>k__BackingField = Auth.CurrencyModel.Rate;

		// Token: 0x04000DB0 RID: 3504
		[CompilerGenerated]
		private bool <PrintPrihodNakl>k__BackingField = Auth.Config.qs_print_pn;

		// Token: 0x04000DB1 RID: 3505
		[CompilerGenerated]
		private bool <IsEditable>k__BackingField = true;

		// Token: 0x04000DB2 RID: 3506
		private int _categoryForAll;

		// Token: 0x04000DB3 RID: 3507
		private bool _all2IStore;

		// Token: 0x04000DB4 RID: 3508
		private int _itemState4All = 1;

		// Token: 0x04000DB5 RID: 3509
		private bool _onlyForSc;

		// Token: 0x04000DB6 RID: 3510
		private int _tabIndex;

		// Token: 0x04000DB7 RID: 3511
		private bool _createRko = Auth.Config.rko_on_pn;

		// Token: 0x04000DB8 RID: 3512
		[CompilerGenerated]
		private docs <Document>k__BackingField;

		// Token: 0x04000DB9 RID: 3513
		[CompilerGenerated]
		private ObservableCollection<items_state> <States>k__BackingField;

		// Token: 0x04000DBA RID: 3514
		[CompilerGenerated]
		private int <TotalItems>k__BackingField;

		// Token: 0x04000DBB RID: 3515
		private bool _loaded;

		// Token: 0x04000DBC RID: 3516
		private IReportPrintService _reportPrintService;

		// Token: 0x020001D6 RID: 470
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001A8C RID: 6796 RVA: 0x0004DA50 File Offset: 0x0004BC50
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06001A8D RID: 6797 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06001A8E RID: 6798 RVA: 0x0004DA68 File Offset: 0x0004BC68
			internal boxes <ExcelImport>b__121_0(Product i)
			{
				return new boxes
				{
					id = 0,
					name = i.BoxName
				};
			}

			// Token: 0x06001A8F RID: 6799 RVA: 0x0004DA90 File Offset: 0x0004BC90
			internal Task<List<stores>> <Init>b__123_0()
			{
				return StoreModel.LoadStores(false, false);
			}

			// Token: 0x06001A90 RID: 6800 RVA: 0x0004DAA4 File Offset: 0x0004BCA4
			internal bool <Init>b__123_1(stores s)
			{
				return s.id == OfflineData.Instance.Employee.StoreDefault;
			}

			// Token: 0x06001A91 RID: 6801 RVA: 0x0004DAC8 File Offset: 0x0004BCC8
			internal decimal <CountTotal>b__137_0(Product i)
			{
				return i.InSumm;
			}

			// Token: 0x06001A92 RID: 6802 RVA: 0x0004DADC File Offset: 0x0004BCDC
			internal int <CountTotal>b__137_1(Product i)
			{
				return i.InCount;
			}

			// Token: 0x06001A93 RID: 6803 RVA: 0x0004DAF0 File Offset: 0x0004BCF0
			internal int <PrintStickers>b__143_0(Product i)
			{
				return i.Id;
			}

			// Token: 0x06001A94 RID: 6804 RVA: 0x0004DB04 File Offset: 0x0004BD04
			internal bool <CanPrintStickers>b__144_0(Product i)
			{
				return i.Id > 0;
			}

			// Token: 0x04000DBD RID: 3517
			public static readonly ItemsArrivalViewModel.<>c <>9 = new ItemsArrivalViewModel.<>c();

			// Token: 0x04000DBE RID: 3518
			public static Func<Product, boxes> <>9__121_0;

			// Token: 0x04000DBF RID: 3519
			public static Func<Task<List<stores>>> <>9__123_0;

			// Token: 0x04000DC0 RID: 3520
			public static Func<stores, bool> <>9__123_1;

			// Token: 0x04000DC1 RID: 3521
			public static Func<Product, decimal> <>9__137_0;

			// Token: 0x04000DC2 RID: 3522
			public static Func<Product, int> <>9__137_1;

			// Token: 0x04000DC3 RID: 3523
			public static Func<Product, int> <>9__143_0;

			// Token: 0x04000DC4 RID: 3524
			public static Func<Product, bool> <>9__144_0;
		}

		// Token: 0x020001D7 RID: 471
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Init>d__123 : IAsyncStateMachine
		{
			// Token: 0x06001A95 RID: 6805 RVA: 0x0004DB1C File Offset: 0x0004BD1C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsArrivalViewModel itemsArrivalViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<items_state>> awaiter;
					TaskAwaiter<List<stores>> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<List<items_state>>);
							this.<>1__state = -1;
							goto IL_149;
						}
						itemsArrivalViewModel.SetLoaded(false);
						awaiter2 = Task.Run<List<stores>>(new Func<Task<List<stores>>>(ItemsArrivalViewModel.<>c.<>9.<Init>b__123_0)).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<stores>>, ItemsArrivalViewModel.<Init>d__123>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<stores>>);
						this.<>1__state = -1;
					}
					List<stores> result = awaiter2.GetResult();
					itemsArrivalViewModel.Stores = result;
					if (OfflineData.Instance.Employee.StoreDefault != 0)
					{
						stores selectedStore = itemsArrivalViewModel.Stores.FirstOrDefault(new Func<stores, bool>(ItemsArrivalViewModel.<>c.<>9.<Init>b__123_1));
						itemsArrivalViewModel.SelectedStore = selectedStore;
					}
					awaiter = Task.Run<List<items_state>>(() => itemsArrivalViewModel.StoreService.GetProductStatesAsync()).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<items_state>>, ItemsArrivalViewModel.<Init>d__123>(ref awaiter, ref this);
						return;
					}
					IL_149:
					List<items_state> result2 = awaiter.GetResult();
					itemsArrivalViewModel.States = new ObservableCollection<items_state>(result2);
					itemsArrivalViewModel.SetLoaded(true);
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

			// Token: 0x06001A96 RID: 6806 RVA: 0x0004DCDC File Offset: 0x0004BEDC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000DC5 RID: 3525
			public int <>1__state;

			// Token: 0x04000DC6 RID: 3526
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000DC7 RID: 3527
			public ItemsArrivalViewModel <>4__this;

			// Token: 0x04000DC8 RID: 3528
			private TaskAwaiter<List<stores>> <>u__1;

			// Token: 0x04000DC9 RID: 3529
			private TaskAwaiter<List<items_state>> <>u__2;
		}

		// Token: 0x020001D8 RID: 472
		[CompilerGenerated]
		private sealed class <>c__DisplayClass125_0
		{
			// Token: 0x06001A97 RID: 6807 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass125_0()
			{
			}

			// Token: 0x06001A98 RID: 6808 RVA: 0x0004DCF8 File Offset: 0x0004BEF8
			internal Task<List<Product>> <BgInitDoWork>b__0()
			{
				return this.<>4__this.StoreService.GetProductsOfDocumentAsync(this.documentId);
			}

			// Token: 0x06001A99 RID: 6809 RVA: 0x0004DD1C File Offset: 0x0004BF1C
			internal Task<ASC.Objects.CustomerCard> <BgInitDoWork>b__1()
			{
				return ClientsModel.GetCustomerCard(this.<>4__this.Document.dealer.Value);
			}

			// Token: 0x04000DCA RID: 3530
			public ItemsArrivalViewModel <>4__this;

			// Token: 0x04000DCB RID: 3531
			public int documentId;
		}

		// Token: 0x020001D9 RID: 473
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <BgInitDoWork>d__125 : IAsyncStateMachine
		{
			// Token: 0x06001A9A RID: 6810 RVA: 0x0004DD48 File Offset: 0x0004BF48
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsArrivalViewModel itemsArrivalViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter<List<Product>> awaiter2;
					TaskAwaiter<ASC.Objects.CustomerCard> awaiter3;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<List<Product>>);
						this.<>1__state = -1;
						goto IL_120;
					case 2:
						awaiter3 = this.<>u__3;
						this.<>u__3 = default(TaskAwaiter<ASC.Objects.CustomerCard>);
						this.<>1__state = -1;
						goto IL_1B7;
					default:
						this.<>8__1 = new ItemsArrivalViewModel.<>c__DisplayClass125_0();
						this.<>8__1.<>4__this = this.<>4__this;
						this.<>8__1.documentId = this.documentId;
						itemsArrivalViewModel.ShowWait();
						awaiter = itemsArrivalViewModel.LoadDocument(this.<>8__1.documentId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ItemsArrivalViewModel.<BgInitDoWork>d__125>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					awaiter2 = Task.Run<List<Product>>(new Func<Task<List<Product>>>(this.<>8__1.<BgInitDoWork>b__0)).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<Product>>, ItemsArrivalViewModel.<BgInitDoWork>d__125>(ref awaiter2, ref this);
						return;
					}
					IL_120:
					List<Product> result = awaiter2.GetResult();
					itemsArrivalViewModel.SetItems(result);
					if (itemsArrivalViewModel.Document == null)
					{
						goto IL_237;
					}
					if (itemsArrivalViewModel.Document.dealer == null)
					{
						goto IL_1C8;
					}
					awaiter3 = Task.Run<ASC.Objects.CustomerCard>(new Func<Task<ASC.Objects.CustomerCard>>(this.<>8__1.<BgInitDoWork>b__1)).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__3 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ASC.Objects.CustomerCard>, ItemsArrivalViewModel.<BgInitDoWork>d__125>(ref awaiter3, ref this);
						return;
					}
					IL_1B7:
					ASC.Objects.CustomerCard result2 = awaiter3.GetResult();
					itemsArrivalViewModel.Dealer = result2;
					IL_1C8:
					itemsArrivalViewModel.CurrencyRateDifference = (itemsArrivalViewModel.CurrencyRate - itemsArrivalViewModel.Document.currency_rate).GetValueOrDefault();
					if (itemsArrivalViewModel.Document.cash_orders1 != null)
					{
						itemsArrivalViewModel.PaymentOption = itemsArrivalViewModel.Document.cash_orders1.payment_system;
					}
					IL_237:
					itemsArrivalViewModel.CountTotal();
					itemsArrivalViewModel.BgInitDoWork();
					itemsArrivalViewModel.HideWait();
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

			// Token: 0x06001A9B RID: 6811 RVA: 0x0004DFF8 File Offset: 0x0004C1F8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000DCC RID: 3532
			public int <>1__state;

			// Token: 0x04000DCD RID: 3533
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000DCE RID: 3534
			public ItemsArrivalViewModel <>4__this;

			// Token: 0x04000DCF RID: 3535
			public int documentId;

			// Token: 0x04000DD0 RID: 3536
			private ItemsArrivalViewModel.<>c__DisplayClass125_0 <>8__1;

			// Token: 0x04000DD1 RID: 3537
			private TaskAwaiter <>u__1;

			// Token: 0x04000DD2 RID: 3538
			private TaskAwaiter<List<Product>> <>u__2;

			// Token: 0x04000DD3 RID: 3539
			private TaskAwaiter<ASC.Objects.CustomerCard> <>u__3;
		}

		// Token: 0x020001DA RID: 474
		[CompilerGenerated]
		private sealed class <>c__DisplayClass126_0
		{
			// Token: 0x06001A9C RID: 6812 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass126_0()
			{
			}

			// Token: 0x06001A9D RID: 6813 RVA: 0x0004E014 File Offset: 0x0004C214
			internal Task<docs> <LoadDocument>b__2()
			{
				return this.<>4__this._itemsArrivalModel.LoadDocument(this.documentId);
			}

			// Token: 0x04000DD4 RID: 3540
			public ItemsArrivalViewModel <>4__this;

			// Token: 0x04000DD5 RID: 3541
			public int documentId;
		}

		// Token: 0x020001DB RID: 475
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadDocument>d__126 : IAsyncStateMachine
		{
			// Token: 0x06001A9E RID: 6814 RVA: 0x0004E038 File Offset: 0x0004C238
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsArrivalViewModel itemsArrivalViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<docs> awaiter;
					if (num != 0)
					{
						awaiter = Task.Run<docs>(new Func<Task<docs>>(new ItemsArrivalViewModel.<>c__DisplayClass126_0
						{
							<>4__this = this.<>4__this,
							documentId = this.documentId
						}.<LoadDocument>b__2)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<docs>, ItemsArrivalViewModel.<LoadDocument>d__126>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<docs>);
						this.<>1__state = -1;
					}
					docs result = awaiter.GetResult();
					itemsArrivalViewModel.Document = result;
					itemsArrivalViewModel.RaiseCanExecuteChanged(() => itemsArrivalViewModel.AddItem());
					itemsArrivalViewModel.RaiseCanExecuteChanged(() => itemsArrivalViewModel.CancellPn());
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

			// Token: 0x06001A9F RID: 6815 RVA: 0x0004E1A0 File Offset: 0x0004C3A0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000DD6 RID: 3542
			public int <>1__state;

			// Token: 0x04000DD7 RID: 3543
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000DD8 RID: 3544
			public ItemsArrivalViewModel <>4__this;

			// Token: 0x04000DD9 RID: 3545
			public int documentId;

			// Token: 0x04000DDA RID: 3546
			private TaskAwaiter<docs> <>u__1;
		}

		// Token: 0x020001DC RID: 476
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadCategories>d__128 : IAsyncStateMachine
		{
			// Token: 0x06001AA0 RID: 6816 RVA: 0x0004E1BC File Offset: 0x0004C3BC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsArrivalViewModel itemsArrivalViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<store_cats>> awaiter;
					if (num != 0)
					{
						awaiter = itemsArrivalViewModel.StoreService.GetCategoriesAsync(this.storeId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_cats>>, ItemsArrivalViewModel.<LoadCategories>d__128>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<store_cats>>);
						this.<>1__state = -1;
					}
					List<store_cats> result = awaiter.GetResult();
					itemsArrivalViewModel.Categories = result;
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

			// Token: 0x06001AA1 RID: 6817 RVA: 0x0004E284 File Offset: 0x0004C484
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000DDB RID: 3547
			public int <>1__state;

			// Token: 0x04000DDC RID: 3548
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000DDD RID: 3549
			public ItemsArrivalViewModel <>4__this;

			// Token: 0x04000DDE RID: 3550
			public int storeId;

			// Token: 0x04000DDF RID: 3551
			private TaskAwaiter<List<store_cats>> <>u__1;
		}

		// Token: 0x020001DD RID: 477
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadBoxes>d__129 : IAsyncStateMachine
		{
			// Token: 0x06001AA2 RID: 6818 RVA: 0x0004E2A0 File Offset: 0x0004C4A0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsArrivalViewModel itemsArrivalViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<boxes>> awaiter;
					if (num != 0)
					{
						docs document = itemsArrivalViewModel.Document;
						if (document == null || document.store == null)
						{
							goto IL_B0;
						}
						awaiter = itemsArrivalViewModel.StoreService.GetBoxesAsync(itemsArrivalViewModel.Document.store.Value).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<boxes>>, ItemsArrivalViewModel.<LoadBoxes>d__129>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<boxes>>);
						this.<>1__state = -1;
					}
					List<boxes> result = awaiter.GetResult();
					itemsArrivalViewModel.Boxes = new ObservableCollection<boxes>(result);
					IL_B0:;
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

			// Token: 0x06001AA3 RID: 6819 RVA: 0x0004E39C File Offset: 0x0004C59C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000DE0 RID: 3552
			public int <>1__state;

			// Token: 0x04000DE1 RID: 3553
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000DE2 RID: 3554
			public ItemsArrivalViewModel <>4__this;

			// Token: 0x04000DE3 RID: 3555
			private TaskAwaiter<List<boxes>> <>u__1;
		}

		// Token: 0x020001DE RID: 478
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <MakeItems>d__140 : IAsyncStateMachine
		{
			// Token: 0x06001AA4 RID: 6820 RVA: 0x0004E3B8 File Offset: 0x0004C5B8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsArrivalViewModel itemsArrivalViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						if (!itemsArrivalViewModel.CheckFields())
						{
							goto IL_122;
						}
						itemsArrivalViewModel.Document.currency_rate = new decimal?(itemsArrivalViewModel.CurrencyRate);
						itemsArrivalViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter<int> awaiter;
						if (num != 0)
						{
							this.<>7__wrap1 = itemsArrivalViewModel.Document;
							awaiter = Task.Run<int>(() => itemsArrivalViewModel._itemsArrivalModel.CreateArrivalDocument(base.Document, new List<Product>(base.Items), base.CreateRko, base.PaymentOption)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, ItemsArrivalViewModel.<MakeItems>d__140>(ref awaiter, ref this);
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
						this.<>7__wrap1.id = result;
						this.<>7__wrap1 = null;
						itemsArrivalViewModel.IsEditable = false;
						itemsArrivalViewModel.PrintDocuments();
						itemsArrivalViewModel.BgInitDoWork(itemsArrivalViewModel.Document.id);
					}
					catch (Exception ex)
					{
						itemsArrivalViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							itemsArrivalViewModel.HideWait();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_122:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06001AA5 RID: 6821 RVA: 0x0004E524 File Offset: 0x0004C724
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000DE4 RID: 3556
			public int <>1__state;

			// Token: 0x04000DE5 RID: 3557
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000DE6 RID: 3558
			public ItemsArrivalViewModel <>4__this;

			// Token: 0x04000DE7 RID: 3559
			private docs <>7__wrap1;

			// Token: 0x04000DE8 RID: 3560
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x020001DF RID: 479
		[CompilerGenerated]
		private sealed class <>c__DisplayClass142_0
		{
			// Token: 0x06001AA6 RID: 6822 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass142_0()
			{
			}

			// Token: 0x06001AA7 RID: 6823 RVA: 0x0004E540 File Offset: 0x0004C740
			internal XtraReport <PrintDocuments>b__1()
			{
				return this.doc.CreateReport("pn", false);
			}

			// Token: 0x04000DE9 RID: 3561
			public StoreDocument doc;
		}

		// Token: 0x020001E0 RID: 480
		[CompilerGenerated]
		private sealed class <>c__DisplayClass142_1
		{
			// Token: 0x06001AA8 RID: 6824 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass142_1()
			{
			}

			// Token: 0x06001AA9 RID: 6825 RVA: 0x0004E560 File Offset: 0x0004C760
			internal Task<XtraReport> <PrintDocuments>b__3()
			{
				return this.order.CreateReport();
			}

			// Token: 0x04000DEA RID: 3562
			public CashInOrder order;
		}

		// Token: 0x020001E1 RID: 481
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <PrintDocuments>d__142 : IAsyncStateMachine
		{
			// Token: 0x06001AAA RID: 6826 RVA: 0x0004E578 File Offset: 0x0004C778
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsArrivalViewModel itemsArrivalViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<StoreDocument> awaiter;
					TaskAwaiter<XtraReport> awaiter2;
					TaskAwaiter<CashInOrder> awaiter3;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<StoreDocument>);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<XtraReport>);
						this.<>1__state = -1;
						goto IL_13B;
					case 2:
						awaiter3 = this.<>u__3;
						this.<>u__3 = default(TaskAwaiter<CashInOrder>);
						this.<>1__state = -1;
						goto IL_1F1;
					case 3:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<XtraReport>);
						this.<>1__state = -1;
						goto IL_26E;
					default:
						if (!itemsArrivalViewModel.PrintRko && !itemsArrivalViewModel.PrintPrihodNakl)
						{
							goto IL_2B4;
						}
						itemsArrivalViewModel.ShowWait();
						this.<report>5__2 = new XtraReport();
						if (!itemsArrivalViewModel.PrintPrihodNakl)
						{
							goto IL_160;
						}
						this.<>8__1 = new ItemsArrivalViewModel.<>c__DisplayClass142_0();
						awaiter = Task.Run<StoreDocument>(() => DocumentsModel.GetDocument(base.Document.id)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<StoreDocument>, ItemsArrivalViewModel.<PrintDocuments>d__142>(ref awaiter, ref this);
							return;
						}
						break;
					}
					StoreDocument result = awaiter.GetResult();
					this.<>8__1.doc = result;
					awaiter2 = Task.Run<XtraReport>(new Func<XtraReport>(this.<>8__1.<PrintDocuments>b__1)).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XtraReport>, ItemsArrivalViewModel.<PrintDocuments>d__142>(ref awaiter2, ref this);
						return;
					}
					IL_13B:
					XtraReport result2 = awaiter2.GetResult();
					this.<report>5__2.Pages.AddRange(result2.Pages);
					this.<>8__1 = null;
					IL_160:
					if (!itemsArrivalViewModel.PrintRko || itemsArrivalViewModel.Document.order_id == null)
					{
						goto IL_295;
					}
					this.<>8__2 = new ItemsArrivalViewModel.<>c__DisplayClass142_1();
					awaiter3 = Task.Run<CashInOrder>(() => KassaModel.GetCashInOrder(base.Document.order_id.Value)).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__3 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<CashInOrder>, ItemsArrivalViewModel.<PrintDocuments>d__142>(ref awaiter3, ref this);
						return;
					}
					IL_1F1:
					CashInOrder result3 = awaiter3.GetResult();
					this.<>8__2.order = result3;
					awaiter2 = Task.Run<XtraReport>(new Func<Task<XtraReport>>(this.<>8__2.<PrintDocuments>b__3)).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XtraReport>, ItemsArrivalViewModel.<PrintDocuments>d__142>(ref awaiter2, ref this);
						return;
					}
					IL_26E:
					XtraReport result4 = awaiter2.GetResult();
					this.<report>5__2.Pages.AddRange(result4.Pages);
					this.<>8__2 = null;
					IL_295:
					itemsArrivalViewModel.HideWait();
					itemsArrivalViewModel._reportPrintService.PrintPreview(this.<report>5__2, PrinterModel.Printer.Documents);
					this.<report>5__2 = null;
					IL_2B4:;
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

			// Token: 0x06001AAB RID: 6827 RVA: 0x0004E884 File Offset: 0x0004CA84
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000DEB RID: 3563
			public int <>1__state;

			// Token: 0x04000DEC RID: 3564
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000DED RID: 3565
			public ItemsArrivalViewModel <>4__this;

			// Token: 0x04000DEE RID: 3566
			private ItemsArrivalViewModel.<>c__DisplayClass142_0 <>8__1;

			// Token: 0x04000DEF RID: 3567
			private ItemsArrivalViewModel.<>c__DisplayClass142_1 <>8__2;

			// Token: 0x04000DF0 RID: 3568
			private XtraReport <report>5__2;

			// Token: 0x04000DF1 RID: 3569
			private TaskAwaiter<StoreDocument> <>u__1;

			// Token: 0x04000DF2 RID: 3570
			private TaskAwaiter<XtraReport> <>u__2;

			// Token: 0x04000DF3 RID: 3571
			private TaskAwaiter<CashInOrder> <>u__3;
		}

		// Token: 0x020001E2 RID: 482
		[CompilerGenerated]
		private sealed class <>c__DisplayClass145_0
		{
			// Token: 0x06001AAC RID: 6828 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass145_0()
			{
			}

			// Token: 0x06001AAD RID: 6829 RVA: 0x0004E8A0 File Offset: 0x0004CAA0
			internal Task<StoreDocument> <PrintPn>b__0()
			{
				return DocumentsModel.GetDocument(this.<>4__this.Document.id);
			}

			// Token: 0x06001AAE RID: 6830 RVA: 0x0004E8C4 File Offset: 0x0004CAC4
			internal XtraReport <PrintPn>b__1()
			{
				return this.doc.CreateReport("pn", false);
			}

			// Token: 0x04000DF4 RID: 3572
			public ItemsArrivalViewModel <>4__this;

			// Token: 0x04000DF5 RID: 3573
			public StoreDocument doc;
		}

		// Token: 0x020001E3 RID: 483
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <PrintPn>d__145 : IAsyncStateMachine
		{
			// Token: 0x06001AAF RID: 6831 RVA: 0x0004E8E4 File Offset: 0x0004CAE4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsArrivalViewModel itemsArrivalViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<XtraReport> awaiter;
					TaskAwaiter<StoreDocument> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<XtraReport>);
							this.<>1__state = -1;
							goto IL_FD;
						}
						this.<>8__1 = new ItemsArrivalViewModel.<>c__DisplayClass145_0();
						this.<>8__1.<>4__this = this.<>4__this;
						itemsArrivalViewModel.ShowWait();
						awaiter2 = Task.Run<StoreDocument>(new Func<Task<StoreDocument>>(this.<>8__1.<PrintPn>b__0)).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<StoreDocument>, ItemsArrivalViewModel.<PrintPn>d__145>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<StoreDocument>);
						this.<>1__state = -1;
					}
					StoreDocument result = awaiter2.GetResult();
					this.<>8__1.doc = result;
					awaiter = Task.Run<XtraReport>(new Func<XtraReport>(this.<>8__1.<PrintPn>b__1)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XtraReport>, ItemsArrivalViewModel.<PrintPn>d__145>(ref awaiter, ref this);
						return;
					}
					IL_FD:
					XtraReport result2 = awaiter.GetResult();
					itemsArrivalViewModel.HideWait();
					itemsArrivalViewModel._reportPrintService.PrintPreview(result2, PrinterModel.Printer.Documents);
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

			// Token: 0x06001AB0 RID: 6832 RVA: 0x0004EA84 File Offset: 0x0004CC84
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000DF6 RID: 3574
			public int <>1__state;

			// Token: 0x04000DF7 RID: 3575
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000DF8 RID: 3576
			public ItemsArrivalViewModel <>4__this;

			// Token: 0x04000DF9 RID: 3577
			private ItemsArrivalViewModel.<>c__DisplayClass145_0 <>8__1;

			// Token: 0x04000DFA RID: 3578
			private TaskAwaiter<StoreDocument> <>u__1;

			// Token: 0x04000DFB RID: 3579
			private TaskAwaiter<XtraReport> <>u__2;
		}

		// Token: 0x020001E4 RID: 484
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadHistory>d__150 : IAsyncStateMachine
		{
			// Token: 0x06001AB1 RID: 6833 RVA: 0x0004EAA0 File Offset: 0x0004CCA0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsArrivalViewModel itemsArrivalViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<logs>> awaiter;
					TaskAwaiter<List<cash_orders>> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<List<logs>>);
							this.<>1__state = -1;
							goto IL_107;
						}
						if (itemsArrivalViewModel.Document == null || itemsArrivalViewModel.Document.id == 0)
						{
							goto IL_139;
						}
						itemsArrivalViewModel.ShowWait();
						awaiter2 = Task.Run<List<cash_orders>>(() => itemsArrivalViewModel._itemsArrivalModel.LoadCashOrders(base.Document.id)).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<cash_orders>>, ItemsArrivalViewModel.<LoadHistory>d__150>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<cash_orders>>);
						this.<>1__state = -1;
					}
					List<cash_orders> result = awaiter2.GetResult();
					itemsArrivalViewModel.RkoOrders = result;
					awaiter = Task.Run<List<logs>>(() => DocumentsModel.LoadHistory(base.Document.id)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<logs>>, ItemsArrivalViewModel.<LoadHistory>d__150>(ref awaiter, ref this);
						return;
					}
					IL_107:
					List<logs> result2 = awaiter.GetResult();
					itemsArrivalViewModel.Logses = result2;
					itemsArrivalViewModel.HideWait();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_139:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06001AB2 RID: 6834 RVA: 0x0004EC18 File Offset: 0x0004CE18
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000DFC RID: 3580
			public int <>1__state;

			// Token: 0x04000DFD RID: 3581
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000DFE RID: 3582
			public ItemsArrivalViewModel <>4__this;

			// Token: 0x04000DFF RID: 3583
			private TaskAwaiter<List<cash_orders>> <>u__1;

			// Token: 0x04000E00 RID: 3584
			private TaskAwaiter<List<logs>> <>u__2;
		}
	}
}
