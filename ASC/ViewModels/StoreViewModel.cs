using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using ASC.Common.Interfaces;
using ASC.Converters;
using ASC.Interfaces;
using ASC.ItemsCancellation;
using ASC.ItemsSale;
using ASC.Models;
using ASC.Objects;
using ASC.Objects.Converters;
using ASC.Options;
using ASC.PartsRequest;
using ASC.Properties;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using ASC.Stickers;
using ASC.ViewModel;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Xpf.Grid;

namespace ASC.ViewModels
{
	// Token: 0x020004A5 RID: 1189
	public class StoreViewModel : BaseViewModel, IReturnOnSelect
	{
		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x06002E37 RID: 11831 RVA: 0x00096860 File Offset: 0x00094A60
		// (set) Token: 0x06002E38 RID: 11832 RVA: 0x00096874 File Offset: 0x00094A74
		public StoreCategoriesViewModel StoreCategoriesViewModel
		{
			[CompilerGenerated]
			get
			{
				return this.<StoreCategoriesViewModel>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<StoreCategoriesViewModel>k__BackingField, value))
				{
					return;
				}
				this.<StoreCategoriesViewModel>k__BackingField = value;
				this.RaisePropertyChanged("StoreCategoriesViewModel");
			}
		}

		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x06002E39 RID: 11833 RVA: 0x000968A4 File Offset: 0x00094AA4
		// (set) Token: 0x06002E3A RID: 11834 RVA: 0x000968B8 File Offset: 0x00094AB8
		public OnUserItemsViewModel OnUserItems
		{
			[CompilerGenerated]
			get
			{
				return this.<OnUserItems>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<OnUserItems>k__BackingField, value))
				{
					return;
				}
				this.<OnUserItems>k__BackingField = value;
				this.RaisePropertyChanged("OnUserItems");
			}
		}

		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x06002E3B RID: 11835 RVA: 0x000968E8 File Offset: 0x00094AE8
		// (set) Token: 0x06002E3C RID: 11836 RVA: 0x000968FC File Offset: 0x00094AFC
		public int LoadedItems
		{
			[CompilerGenerated]
			get
			{
				return this.<LoadedItems>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<LoadedItems>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = 461184652;
				IL_10:
				switch ((num ^ 215746761) % 4)
				{
				case 0:
					IL_2F:
					this.<LoadedItems>k__BackingField = value;
					this.RaisePropertyChanged("LoadedItems");
					num = 1069250547;
					goto IL_10;
				case 1:
					return;
				case 3:
					goto IL_0B;
				}
			}
		}

		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x06002E3D RID: 11837 RVA: 0x00096954 File Offset: 0x00094B54
		// (set) Token: 0x06002E3E RID: 11838 RVA: 0x00096968 File Offset: 0x00094B68
		public PhotoGroupSource Images
		{
			[CompilerGenerated]
			get
			{
				return this.<Images>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Images>k__BackingField, value))
				{
					return;
				}
				this.<Images>k__BackingField = value;
				this.RaisePropertyChanged("Images");
			}
		}

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x06002E3F RID: 11839 RVA: 0x00096998 File Offset: 0x00094B98
		// (set) Token: 0x06002E40 RID: 11840 RVA: 0x000969DC File Offset: 0x00094BDC
		public Product SelectedItem
		{
			get
			{
				return base.GetProperty<Product>(() => this.SelectedItem);
			}
			set
			{
				if (object.Equals(this.SelectedItem, value))
				{
					return;
				}
				base.SetProperty<Product>(() => this.SelectedItem, value, new Action(this.OnSelectedItemChanged));
				this.RaisePropertyChanged("SelectedItem");
			}
		}

		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x06002E41 RID: 11841 RVA: 0x00096A48 File Offset: 0x00094C48
		// (set) Token: 0x06002E42 RID: 11842 RVA: 0x00096A5C File Offset: 0x00094C5C
		public bool ReturnSelectedItems
		{
			[CompilerGenerated]
			get
			{
				return this.<ReturnSelectedItems>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ReturnSelectedItems>k__BackingField == value)
				{
					return;
				}
				this.<ReturnSelectedItems>k__BackingField = value;
				this.RaisePropertyChanged("ReturnSelectedItems");
			}
		}

		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x06002E43 RID: 11843 RVA: 0x00096A88 File Offset: 0x00094C88
		// (set) Token: 0x06002E44 RID: 11844 RVA: 0x00096A9C File Offset: 0x00094C9C
		public ObservableCollection<StoreGroup> MasterItems
		{
			[CompilerGenerated]
			get
			{
				return this.<MasterItems>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<MasterItems>k__BackingField, value))
				{
					return;
				}
				this.<MasterItems>k__BackingField = value;
				this.RaisePropertyChanged("MasterItems");
			}
		}

		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x06002E45 RID: 11845 RVA: 0x00096ACC File Offset: 0x00094CCC
		// (set) Token: 0x06002E46 RID: 11846 RVA: 0x00096AE0 File Offset: 0x00094CE0
		public List<boxes> ItemBoxes
		{
			[CompilerGenerated]
			get
			{
				return this.<ItemBoxes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ItemBoxes>k__BackingField, value))
				{
					return;
				}
				this.<ItemBoxes>k__BackingField = value;
				this.RaisePropertyChanged("ItemBoxes");
			}
		}

		// Token: 0x17000EAD RID: 3757
		// (get) Token: 0x06002E47 RID: 11847 RVA: 0x00096B10 File Offset: 0x00094D10
		// (set) Token: 0x06002E48 RID: 11848 RVA: 0x00096B54 File Offset: 0x00094D54
		public int SelectedItemBox
		{
			get
			{
				return base.GetProperty<int>(() => this.SelectedItemBox);
			}
			set
			{
				if (this.SelectedItemBox == value)
				{
					return;
				}
				base.SetProperty<int>(() => this.SelectedItemBox, value, new Action(this.ReloadItems));
				this.RaisePropertyChanged("SelectedItemBox");
			}
		}

		// Token: 0x17000EAE RID: 3758
		// (get) Token: 0x06002E49 RID: 11849 RVA: 0x00096BBC File Offset: 0x00094DBC
		// (set) Token: 0x06002E4A RID: 11850 RVA: 0x00096C00 File Offset: 0x00094E00
		public string Query
		{
			get
			{
				return base.GetProperty<string>(() => this.Query);
			}
			set
			{
				if (string.Equals(this.Query, value, StringComparison.Ordinal))
				{
					return;
				}
				base.SetProperty<string>(() => this.Query, value, new Action(this.ReloadItems));
				this.RaisePropertyChanged("Query");
			}
		}

		// Token: 0x17000EAF RID: 3759
		// (get) Token: 0x06002E4B RID: 11851 RVA: 0x00096C6C File Offset: 0x00094E6C
		// (set) Token: 0x06002E4C RID: 11852 RVA: 0x00096C80 File Offset: 0x00094E80
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
				if (!object.Equals(this.<States>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1245769923;
				IL_13:
				switch ((num ^ 1635509822) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					return;
				case 3:
					IL_32:
					this.<States>k__BackingField = value;
					num = 1231825556;
					goto IL_13;
				}
				this.RaisePropertyChanged("States");
			}
		}

		// Token: 0x17000EB0 RID: 3760
		// (get) Token: 0x06002E4D RID: 11853 RVA: 0x00096CDC File Offset: 0x00094EDC
		// (set) Token: 0x06002E4E RID: 11854 RVA: 0x00096CF0 File Offset: 0x00094EF0
		public List<Product> SelectedItems
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedItems>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedItems>k__BackingField, value))
				{
					return;
				}
				this.<SelectedItems>k__BackingField = value;
				this.RaisePropertyChanged("SelectedItems");
			}
		}

		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x06002E4F RID: 11855 RVA: 0x00096D20 File Offset: 0x00094F20
		// (set) Token: 0x06002E50 RID: 11856 RVA: 0x00096D34 File Offset: 0x00094F34
		public int SelectedItemsCount
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedItemsCount>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedItemsCount>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -585138585;
				IL_10:
				switch ((num ^ -2035960299) % 4)
				{
				case 1:
					IL_2F:
					this.<SelectedItemsCount>k__BackingField = value;
					this.RaisePropertyChanged("SelectedItemsCount");
					num = -1028900975;
					goto IL_10;
				case 2:
					return;
				case 3:
					goto IL_0B;
				}
			}
		}

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x06002E51 RID: 11857 RVA: 0x00096D8C File Offset: 0x00094F8C
		// (set) Token: 0x06002E52 RID: 11858 RVA: 0x00096DA0 File Offset: 0x00094FA0
		public List<ItemsOptions> ItemsOptionses
		{
			[CompilerGenerated]
			get
			{
				return this.<ItemsOptionses>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<ItemsOptionses>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1844353691;
				IL_13:
				switch ((num ^ -1026116357) % 4)
				{
				case 1:
					IL_32:
					num = -1945472701;
					goto IL_13;
				case 2:
					return;
				case 3:
					goto IL_0E;
				}
				this.<ItemsOptionses>k__BackingField = value;
				this.RaisePropertyChanged("ItemsOptionses");
			}
		}

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x06002E53 RID: 11859 RVA: 0x00096DFC File Offset: 0x00094FFC
		// (set) Token: 0x06002E54 RID: 11860 RVA: 0x00096E10 File Offset: 0x00095010
		public int SelectedTab
		{
			get
			{
				return this._selectedTab;
			}
			set
			{
				if (this._selectedTab != value)
				{
					goto IL_14;
				}
				goto IL_62;
				IL_0D:
				int num = 229313301;
				goto IL_3F;
				IL_14:
				this._selectedTab = value;
				this.RaisePropertyChanged("SelectedTab");
				StoreCategoriesViewModel storeCategoriesViewModel = this.StoreCategoriesViewModel;
				if (storeCategoriesViewModel == null)
				{
					goto IL_0D;
				}
				storeCategoriesViewModel.ModeChanged((CategoriesMode)value);
				num = 2079022203;
				IL_3F:
				switch ((num ^ 539748657) % 5)
				{
				case 1:
					return;
				case 2:
					goto IL_14;
				case 3:
					goto IL_0D;
				case 4:
					IL_62:
					num = 1635129564;
					goto IL_3F;
				}
			}
		}

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x06002E55 RID: 11861 RVA: 0x00096E88 File Offset: 0x00095088
		// (set) Token: 0x06002E56 RID: 11862 RVA: 0x00096E9C File Offset: 0x0009509C
		public bool OnlyMyParts
		{
			get
			{
				return this._onlyMyParts;
			}
			set
			{
				if (this._onlyMyParts == value)
				{
					return;
				}
				this._onlyMyParts = value;
				this.RaisePropertyChanged("OnlyMyParts");
				this.SelectedTab = 1;
			}
		}

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x06002E57 RID: 11863 RVA: 0x00096ED0 File Offset: 0x000950D0
		// (set) Token: 0x06002E58 RID: 11864 RVA: 0x00096EE8 File Offset: 0x000950E8
		public int SelectedItemOption
		{
			get
			{
				return Settings.Default.StoreLastOption;
			}
			set
			{
				if (this.SelectedItemOption == value)
				{
					return;
				}
				Settings.Default.StoreLastOption = value;
				this.Refresh();
				this.RaisePropertyChanged("SelectedItemOption");
			}
		}

		// Token: 0x06002E59 RID: 11865 RVA: 0x00096F20 File Offset: 0x00095120
		public StoreViewModel()
		{
			this.SetViewName("Items");
			this._storeService = Bootstrapper.Container.Resolve<IStoreService>();
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
			this._ascMessageBoxService = Bootstrapper.Container.Resolve<IAscMessageBoxService>();
			this._returnAction = StoreViewModel.ReturnAction.None;
		}

		// Token: 0x06002E5A RID: 11866 RVA: 0x00096FA8 File Offset: 0x000951A8
		public StoreViewModel(bool returnSelected, int itemsOption) : this()
		{
			this.SetViewName("Select", "Items");
			this.SetReturnSelected(returnSelected);
			this.SelectedItems = new List<Product>();
			this.SetItemOption(itemsOption);
		}

		// Token: 0x06002E5B RID: 11867 RVA: 0x00096FE4 File Offset: 0x000951E4
		public StoreViewModel(StoreViewModel.ReturnAction action, int repairId, bool warrantyRepair) : this()
		{
			this.SetViewName("Select", "Items");
			this.SetReturnAction(action);
			this._forWarantyRepair = warrantyRepair;
			this._repairId = repairId;
			this.SetMyPartsState(1);
		}

		// Token: 0x06002E5C RID: 11868 RVA: 0x00097024 File Offset: 0x00095224
		protected virtual void SelectedCategoryChanged(object sender, ICategory e)
		{
			StoreViewModel.<SelectedCategoryChanged>d__76 <SelectedCategoryChanged>d__;
			<SelectedCategoryChanged>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SelectedCategoryChanged>d__.<>4__this = this;
			<SelectedCategoryChanged>d__.e = e;
			<SelectedCategoryChanged>d__.<>1__state = -1;
			<SelectedCategoryChanged>d__.<>t__builder.Start<StoreViewModel.<SelectedCategoryChanged>d__76>(ref <SelectedCategoryChanged>d__);
		}

		// Token: 0x06002E5D RID: 11869 RVA: 0x00097064 File Offset: 0x00095264
		private void SetReturnAction(StoreViewModel.ReturnAction action)
		{
			if (action != StoreViewModel.ReturnAction.None)
			{
				this.ReturnOnSelect = true;
			}
			this._returnAction = action;
		}

		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x06002E5E RID: 11870 RVA: 0x00097084 File Offset: 0x00095284
		// (set) Token: 0x06002E5F RID: 11871 RVA: 0x00097098 File Offset: 0x00095298
		public bool ReturnOnSelect
		{
			[CompilerGenerated]
			get
			{
				return this.<ReturnOnSelect>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ReturnOnSelect>k__BackingField == value)
				{
					return;
				}
				this.<ReturnOnSelect>k__BackingField = value;
				this.RaisePropertyChanged("ReturnOnSelect");
			}
		}

		// Token: 0x06002E60 RID: 11872 RVA: 0x000970C4 File Offset: 0x000952C4
		public void SetMyPartsState(int state)
		{
			this.MyPartsState = state;
		}

		// Token: 0x06002E61 RID: 11873 RVA: 0x000970D8 File Offset: 0x000952D8
		public void SetItemOption(int option)
		{
			this.SelectedItemOption = option;
		}

		// Token: 0x06002E62 RID: 11874 RVA: 0x000970EC File Offset: 0x000952EC
		public void SetReturnSelected(bool value)
		{
			this.ReturnSelectedItems = value;
		}

		// Token: 0x06002E63 RID: 11875 RVA: 0x00097100 File Offset: 0x00095300
		private void OnSelectedItemChanged()
		{
			StoreViewModel.<OnSelectedItemChanged>d__85 <OnSelectedItemChanged>d__;
			<OnSelectedItemChanged>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnSelectedItemChanged>d__.<>4__this = this;
			<OnSelectedItemChanged>d__.<>1__state = -1;
			<OnSelectedItemChanged>d__.<>t__builder.Start<StoreViewModel.<OnSelectedItemChanged>d__85>(ref <OnSelectedItemChanged>d__);
		}

		// Token: 0x06002E64 RID: 11876 RVA: 0x00097138 File Offset: 0x00095338
		[Command]
		public void ItemDoubleClick()
		{
			if (this.SelectedItem == null)
			{
				return;
			}
			if (this._returnAction != StoreViewModel.ReturnAction.InsertToRepair)
			{
				if (!this.ReturnSelectedItems)
				{
					this._navigationService.NavigateToStoreItem(this.SelectedItem.Id, 0);
					return;
				}
				this.Close();
				return;
			}
			else
			{
				if (this.SelectedItem.Available < 1)
				{
					this._toasterService.Info(Lang.t("ItemSubstractWarning"));
					return;
				}
				if (OfflineData.Instance.Employee.Can(69, 0))
				{
					this.LoadItemPrices();
					this.SetDefaultPrice();
					this._windowedDocumentService.ShowNewDocument("StorePartCountView", this, null, null);
					return;
				}
				if (this._repairId > 0)
				{
					this._navigationService.Navigate("PartsRequestView", new PartsRequestViewModel(this.SelectedItem.Id, this._repairId));
				}
				return;
			}
		}

		// Token: 0x06002E65 RID: 11877 RVA: 0x00097208 File Offset: 0x00095408
		private void SetDefaultPrice()
		{
			if (Auth.Config.it_vis_price_for_sc)
			{
				goto IL_6A;
			}
			IL_0C:
			this.AddPrice = (from p in this.ItemPrices
			select p.Key).DefaultIfEmpty<decimal>().Max();
			int num = 1276343184;
			IL_4B:
			switch ((num ^ 1294164692) % 4)
			{
			case 1:
				this.AddPrice = this.SelectedItem.Price1Raw;
				return;
			case 2:
				IL_6A:
				num = 1810006381;
				goto IL_4B;
			case 3:
				goto IL_0C;
			}
		}

		// Token: 0x06002E66 RID: 11878 RVA: 0x00097298 File Offset: 0x00095498
		private void LoadItemPrices()
		{
			this.ItemPrices = new List<KeyValuePair<decimal, string>>();
			if (Auth.Config.it_vis_price_for_sc)
			{
				this.ItemPrices.Add(new KeyValuePair<decimal, string>(this.SelectedItem.Price1Raw, Lang.t("PriceForSc")));
			}
			if (Auth.Config.it_vis_rozn)
			{
				this.ItemPrices.Add(new KeyValuePair<decimal, string>(this.SelectedItem.Price2Raw, Lang.t("Retail")));
			}
			if (Auth.Config.it_vis_opt)
			{
				this.ItemPrices.Add(new KeyValuePair<decimal, string>(this.SelectedItem.Price3Raw, Lang.t("Opt")));
			}
			if (Auth.Config.it_vis_opt2)
			{
				this.ItemPrices.Add(new KeyValuePair<decimal, string>(this.SelectedItem.Price4Raw, Lang.t("PriceOpt2")));
			}
			if (Auth.Config.it_vis_opt3)
			{
				this.ItemPrices.Add(new KeyValuePair<decimal, string>(this.SelectedItem.Price5Raw, Lang.t("PriceOpt3")));
			}
			if (this._forWarantyRepair)
			{
				this.ItemPrices.Add(new KeyValuePair<decimal, string>(0m, Lang.t("Warranty")));
			}
		}

		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x06002E67 RID: 11879 RVA: 0x000973CC File Offset: 0x000955CC
		// (set) Token: 0x06002E68 RID: 11880 RVA: 0x000973E0 File Offset: 0x000955E0
		public int AddCount
		{
			[CompilerGenerated]
			get
			{
				return this.<AddCount>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<AddCount>k__BackingField == value)
				{
					return;
				}
				this.<AddCount>k__BackingField = value;
				this.RaisePropertyChanged("AddCount");
			}
		}

		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x06002E69 RID: 11881 RVA: 0x0009740C File Offset: 0x0009560C
		// (set) Token: 0x06002E6A RID: 11882 RVA: 0x00097420 File Offset: 0x00095620
		public decimal AddPrice
		{
			[CompilerGenerated]
			get
			{
				return this.<AddPrice>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<AddPrice>k__BackingField, value))
				{
					return;
				}
				this.<AddPrice>k__BackingField = value;
				this.RaisePropertyChanged("AddPrice");
			}
		}

		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x06002E6B RID: 11883 RVA: 0x00097450 File Offset: 0x00095650
		// (set) Token: 0x06002E6C RID: 11884 RVA: 0x00097464 File Offset: 0x00095664
		public List<KeyValuePair<decimal, string>> ItemPrices
		{
			[CompilerGenerated]
			get
			{
				return this.<ItemPrices>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ItemPrices>k__BackingField, value))
				{
					return;
				}
				this.<ItemPrices>k__BackingField = value;
				this.RaisePropertyChanged("ItemPrices");
			}
		}

		// Token: 0x06002E6D RID: 11885 RVA: 0x00097494 File Offset: 0x00095694
		private void Close()
		{
			IItemsSelect parentViewModel = this._parentViewModel;
			if (parentViewModel != null)
			{
				parentViewModel.AddItemsFromStore(this.SelectedItems, this.SelectedItem);
				goto IL_4A;
			}
			IL_1F:
			this._navigationService.CloseCurrentTab();
			int num = 317527251;
			IL_2F:
			switch ((num ^ 2110353398) % 3)
			{
			case 0:
				IL_4A:
				num = 1403059866;
				goto IL_2F;
			case 2:
				goto IL_1F;
			}
		}

		// Token: 0x06002E6E RID: 11886 RVA: 0x000974F4 File Offset: 0x000956F4
		[Command]
		public void CountOk()
		{
			this._windowedDocumentService.CloseActiveDocument();
			IMyItemSelect parentViewModelMyItemSelect = this._parentViewModelMyItemSelect;
			if (parentViewModelMyItemSelect != null)
			{
				parentViewModelMyItemSelect.AddProductDirectFromStore(this.SelectedItem.BackToStoreItem(), this.AddCount, this.AddPrice);
			}
			this._navigationService.CloseCurrentTab();
		}

		// Token: 0x06002E6F RID: 11887 RVA: 0x00097540 File Offset: 0x00095740
		[Command]
		public void CountClose()
		{
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x06002E70 RID: 11888 RVA: 0x00097558 File Offset: 0x00095758
		protected override void OnParentViewModelChanged(object parentViewModel)
		{
			base.OnParentViewModelChanged(parentViewModel);
			this._parentViewModel = (parentViewModel as IItemsSelect);
			if (this._parentViewModel == null)
			{
				this._parentViewModelMyItemSelect = (parentViewModel as IMyItemSelect);
				return;
			}
			this.SelectedItems = new List<Product>();
			this.SelectedItem = null;
			this.SetReturnSelected(true);
		}

		// Token: 0x06002E71 RID: 11889 RVA: 0x000975A8 File Offset: 0x000957A8
		[Command]
		public void GiveItem()
		{
			if (!this.CheckItemOffice())
			{
				goto IL_2C;
			}
			IL_08:
			int num = 336196222;
			IL_0D:
			switch ((num ^ 859489616) % 4)
			{
			case 0:
				goto IL_08;
			case 1:
				IL_2C:
				this.PartRequest(false);
				num = 1984356915;
				goto IL_0D;
			case 2:
				return;
			}
		}

		// Token: 0x06002E72 RID: 11890 RVA: 0x000975F0 File Offset: 0x000957F0
		public bool CanGiveItem()
		{
			return this.IsItemsAvailable() && OfflineData.Instance.Employee.Can(45, 0);
		}

		// Token: 0x06002E73 RID: 11891 RVA: 0x0009761C File Offset: 0x0009581C
		private bool CheckItemOffice()
		{
			if (!StoreModel.ItemInUserOffice(this.SelectedItem.StoreId))
			{
				this._toasterService.Info(Lang.t("ItemInForeignOffice"));
				return true;
			}
			return false;
		}

		// Token: 0x06002E74 RID: 11892 RVA: 0x00097654 File Offset: 0x00095854
		private void PartRequest(bool isRequest)
		{
			if (this.SelectedItem == null)
			{
				return;
			}
			this._navigationService.Navigate("PartsRequestView", new PartsRequestViewModel(this.SelectedItem.Id, isRequest));
		}

		// Token: 0x06002E75 RID: 11893 RVA: 0x0009768C File Offset: 0x0009588C
		private bool IsItemsAvailable()
		{
			return this.SelectedItem != null && this._initOk && this.SelectedItem.Available > 0;
		}

		// Token: 0x06002E76 RID: 11894 RVA: 0x000976BC File Offset: 0x000958BC
		private bool IsAvailableAndForSale()
		{
			return this.SelectedItem != null && this._initOk && this.SelectedItem.Available > 0 && !this.SelectedItem.NotForSale;
		}

		// Token: 0x06002E77 RID: 11895 RVA: 0x000976FC File Offset: 0x000958FC
		[Command]
		public void RequestItem()
		{
			this.PartRequest(true);
		}

		// Token: 0x06002E78 RID: 11896 RVA: 0x00097710 File Offset: 0x00095910
		public bool CanRequestItem()
		{
			return this.IsItemsAvailable();
		}

		// Token: 0x06002E79 RID: 11897 RVA: 0x00097724 File Offset: 0x00095924
		[Command]
		public void OpenDealerCard()
		{
			if (this.SelectedItem != null)
			{
				goto IL_2C;
			}
			IL_08:
			int num = 794679896;
			IL_0D:
			switch ((num ^ 680330089) % 4)
			{
			case 1:
				return;
			case 2:
				IL_2C:
				this._navigationService.NavigateToCustomerCard(this.SelectedItem.DealerId, null);
				num = 1834712133;
				goto IL_0D;
			case 3:
				goto IL_08;
			}
		}

		// Token: 0x06002E7A RID: 11898 RVA: 0x0001D588 File Offset: 0x0001B788
		public bool CanOpenDealerCard()
		{
			return OfflineData.Instance.Employee.Can(7, 0);
		}

		// Token: 0x06002E7B RID: 11899 RVA: 0x0009777C File Offset: 0x0009597C
		[Command]
		public void EditItem()
		{
			if (this.SelectedItem == null)
			{
				return;
			}
			this._navigationService.NavigateToStoreItem(this.SelectedItem.Id, 1);
		}

		// Token: 0x06002E7C RID: 11900 RVA: 0x000977AC File Offset: 0x000959AC
		public bool CanEditItem()
		{
			return OfflineData.Instance.Employee.Can(21, 0);
		}

		// Token: 0x06002E7D RID: 11901 RVA: 0x000977CC File Offset: 0x000959CC
		[Command]
		public void ReserveItem()
		{
			if (this.SelectedItem == null)
			{
				return;
			}
			if (this.SelectedItems != null)
			{
				List<Product> items = (from i in this.SelectedItems
				where i.Available > 0
				select i).ToList<Product>();
				this._navigationService.Navigate("ItemsSaleView", new ItemsSaleViewModel(items));
				return;
			}
			this._navigationService.Navigate("ItemsSaleView", new ItemsSaleViewModel(this.SelectedItem));
		}

		// Token: 0x06002E7E RID: 11902 RVA: 0x0009784C File Offset: 0x00095A4C
		public bool CanReserveItem()
		{
			return this.IsAvailableAndForSale() && OfflineData.Instance.Employee.Can(5, 0);
		}

		// Token: 0x06002E7F RID: 11903 RVA: 0x00097874 File Offset: 0x00095A74
		[Command]
		public void CancellItem()
		{
			this._windowedDocumentService.ShowNewDocument("ItemsCancellationView", new ItemsCancellationViewModel(this.GetSelected()), null, null);
		}

		// Token: 0x06002E80 RID: 11904 RVA: 0x000978A0 File Offset: 0x00095AA0
		public bool CanCancellItem()
		{
			return this.IsItemsAvailable() && OfflineData.Instance.Employee.Can(9, 0);
		}

		// Token: 0x06002E81 RID: 11905 RVA: 0x000978CC File Offset: 0x00095ACC
		[Command]
		public void PrintSticker4Item()
		{
			if (this.SelectedItem == null && this.SelectedItems.Count == 0)
			{
				this._toasterService.Info(Lang.t("AddItem"));
				return;
			}
			this._windowedDocumentService.ShowNewDocument("StickersView", new StickersViewModel(this.GetSelected()), null, null);
		}

		// Token: 0x06002E82 RID: 11906 RVA: 0x00097924 File Offset: 0x00095B24
		public bool CanPrintSticker4Item()
		{
			return OfflineData.Instance.Employee.Can(3, 0);
		}

		// Token: 0x06002E83 RID: 11907 RVA: 0x00097944 File Offset: 0x00095B44
		private List<int> GetSelected()
		{
			List<int> list;
			if (this.SelectedItem == null)
			{
				list = new List<int>();
			}
			else
			{
				(list = new List<int>()).Add(this.SelectedItem.Id);
			}
			List<int> result = list;
			if (!this.SelectedItems.Any<Product>())
			{
				return result;
			}
			return (from i in this.SelectedItems
			select i.Id).ToList<int>();
		}

		// Token: 0x06002E84 RID: 11908 RVA: 0x000979B8 File Offset: 0x00095BB8
		[Command]
		public void SaleItem()
		{
			if (this.SelectedItem == null)
			{
				goto IL_17;
			}
			goto IL_71;
			int num;
			for (;;)
			{
				IL_3E:
				switch ((num ^ 1648107429) % 6)
				{
				case 1:
					goto IL_71;
				case 2:
					return;
				case 3:
					return;
				case 4:
					this._navigationService.Navigate("ItemsSaleView", new ItemsSaleViewModel(this.SelectedItem));
					num = 228826223;
					continue;
				case 5:
					goto IL_17;
				}
				break;
			}
			return;
			IL_17:
			num = 766873133;
			goto IL_3E;
			IL_71:
			num = ((!this.CheckItemOffice()) ? 80209399 : 898168686);
			goto IL_3E;
		}

		// Token: 0x06002E85 RID: 11909 RVA: 0x00097A44 File Offset: 0x00095C44
		public bool CanSaleItem()
		{
			return base.IsValid() && this.IsAvailableAndForSale() && OfflineData.Instance.Employee.Can(5, 0);
		}

		// Token: 0x06002E86 RID: 11910 RVA: 0x00097A74 File Offset: 0x00095C74
		[Command]
		public void SelectComplete()
		{
			this.Close();
		}

		// Token: 0x06002E87 RID: 11911 RVA: 0x00097A88 File Offset: 0x00095C88
		[Command]
		public void SelectionAdd(object obj)
		{
			Product item = obj as Product;
			if (item == null)
			{
				return;
			}
			if (!item.Selected)
			{
				return;
			}
			if (this.SelectedItems.Any((Product i) => i.Id == item.Id))
			{
				return;
			}
			this.SelectedItems.Add(item);
			this.CountSelected();
		}

		// Token: 0x06002E88 RID: 11912 RVA: 0x00097AF0 File Offset: 0x00095CF0
		[Command]
		public void SelectionRemove(object obj)
		{
			store_items item = obj as store_items;
			if (item == null)
			{
				return;
			}
			if (item.Selected)
			{
				return;
			}
			Product product = this.SelectedItems.FirstOrDefault((Product i) => i.Id == item.id);
			if (product != null)
			{
				this.SelectedItems.Remove(product);
			}
			this.CountSelected();
		}

		// Token: 0x06002E89 RID: 11913 RVA: 0x00097B54 File Offset: 0x00095D54
		public void CountSelected()
		{
			if (this.SelectedItems != null)
			{
				this.SelectedItemsCount = this.SelectedItems.Count;
			}
		}

		// Token: 0x06002E8A RID: 11914 RVA: 0x00097B7C File Offset: 0x00095D7C
		public StoreViewModel.ReturnAction GetReturnAction()
		{
			return this._returnAction;
		}

		// Token: 0x06002E8B RID: 11915 RVA: 0x00097B90 File Offset: 0x00095D90
		public IMyItemSelect GetParentViewModelMyItemSelect()
		{
			return this._parentViewModelMyItemSelect;
		}

		// Token: 0x06002E8C RID: 11916 RVA: 0x00097BA4 File Offset: 0x00095DA4
		private void ClearItemsSelection()
		{
			this.SelectedItem = null;
			this.OnUserItems.ClearSelectedItem();
		}

		// Token: 0x06002E8D RID: 11917 RVA: 0x00097BC4 File Offset: 0x00095DC4
		[Command]
		public void Refresh()
		{
			this.ClearItemsSelection();
			this.ReloadItems();
		}

		// Token: 0x06002E8E RID: 11918 RVA: 0x00097BE0 File Offset: 0x00095DE0
		private void ReloadItems()
		{
			if (this.SelectedTab == 0)
			{
				this.BgLoadItems(this.Query);
			}
			if (this.SelectedTab == 1)
			{
				this.OnUserItems.LoadOnUserItems();
			}
		}

		// Token: 0x06002E8F RID: 11919 RVA: 0x00097C18 File Offset: 0x00095E18
		protected virtual void BgLoadItems(string filter)
		{
			StoreViewModel.<BgLoadItems>d__138 <BgLoadItems>d__;
			<BgLoadItems>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<BgLoadItems>d__.<>4__this = this;
			<BgLoadItems>d__.filter = filter;
			<BgLoadItems>d__.<>1__state = -1;
			<BgLoadItems>d__.<>t__builder.Start<StoreViewModel.<BgLoadItems>d__138>(ref <BgLoadItems>d__);
		}

		// Token: 0x06002E90 RID: 11920 RVA: 0x00097C58 File Offset: 0x00095E58
		public int GetSelectedCategory()
		{
			return this.StoreCategoriesViewModel.GetSelectedCategory();
		}

		// Token: 0x06002E91 RID: 11921 RVA: 0x00097C70 File Offset: 0x00095E70
		public void SetLoadedItems(int value)
		{
			this.LoadedItems = value;
		}

		// Token: 0x06002E92 RID: 11922 RVA: 0x00097C84 File Offset: 0x00095E84
		public override void OnLoad()
		{
			StoreViewModel.<OnLoad>d__141 <OnLoad>d__;
			<OnLoad>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnLoad>d__.<>4__this = this;
			<OnLoad>d__.<>1__state = -1;
			<OnLoad>d__.<>t__builder.Start<StoreViewModel.<OnLoad>d__141>(ref <OnLoad>d__);
		}

		// Token: 0x06002E93 RID: 11923 RVA: 0x0004FE88 File Offset: 0x0004E088
		[Command]
		public void ZoomImage(object obj)
		{
			int valueOrDefault = (obj as int?).GetValueOrDefault();
			if (valueOrDefault != 0)
			{
				new PhotoView(valueOrDefault).Show();
				return;
			}
		}

		// Token: 0x06002E94 RID: 11924 RVA: 0x00097CBC File Offset: 0x00095EBC
		[Command]
		public void ItemMovement()
		{
			ProductsMoveViewModel productsMoveViewModel = Bootstrapper.Container.Resolve<ProductsMoveViewModel>();
			productsMoveViewModel.SetParentViewModel(this);
			if (this.SelectedItems != null && this.SelectedItems.Any<Product>())
			{
				using (List<Product>.Enumerator enumerator = this.SelectedItems.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Product product = enumerator.Current;
						productsMoveViewModel.LoadAndAddItem(product.Id);
					}
					goto IL_75;
				}
			}
			productsMoveViewModel.LoadAndAddItem(this.SelectedItem.Id);
			IL_75:
			this._navigationService.Navigate("ProductsMoveView", productsMoveViewModel);
		}

		// Token: 0x06002E95 RID: 11925 RVA: 0x00097D60 File Offset: 0x00095F60
		public bool CanItemMovement()
		{
			return this.SelectedItem != null && OfflineData.Instance.Employee.Can(6, 0);
		}

		// Token: 0x06002E96 RID: 11926 RVA: 0x00097D88 File Offset: 0x00095F88
		[AsyncCommand]
		public Task ItemDelete()
		{
			StoreViewModel.<ItemDelete>d__145 <ItemDelete>d__;
			<ItemDelete>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ItemDelete>d__.<>4__this = this;
			<ItemDelete>d__.<>1__state = -1;
			<ItemDelete>d__.<>t__builder.Start<StoreViewModel.<ItemDelete>d__145>(ref <ItemDelete>d__);
			return <ItemDelete>d__.<>t__builder.Task;
		}

		// Token: 0x06002E97 RID: 11927 RVA: 0x00097DCC File Offset: 0x00095FCC
		public bool CanItemDelete()
		{
			return this.SelectedItem != null && !this.ReturnOnSelect;
		}

		// Token: 0x06002E98 RID: 11928 RVA: 0x00097DEC File Offset: 0x00095FEC
		[Command]
		public virtual void GridLoaded(object obj)
		{
			StoreViewModel.<GridLoaded>d__147 <GridLoaded>d__;
			<GridLoaded>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<GridLoaded>d__.<>4__this = this;
			<GridLoaded>d__.obj = obj;
			<GridLoaded>d__.<>1__state = -1;
			<GridLoaded>d__.<>t__builder.Start<StoreViewModel.<GridLoaded>d__147>(ref <GridLoaded>d__);
		}

		// Token: 0x06002E99 RID: 11929 RVA: 0x00097E2C File Offset: 0x0009602C
		[Command]
		public override void GridUnloaded(object obj)
		{
			if (!(obj is DataControlBase))
			{
				return;
			}
			this.SaveGridLayout(this.GetSelectedCategory());
		}

		// Token: 0x06002E9A RID: 11930 RVA: 0x00097E50 File Offset: 0x00096050
		protected void SaveGridLayout(int categoryId)
		{
			try
			{
				string path = base.SetCfgFileName(string.Format("{0}-{1}", this._grid.Tag, categoryId));
				this._grid.SaveLayoutToXml(path);
			}
			catch (Exception ex)
			{
				this._toasterService.Error(ex.Message);
			}
		}

		// Token: 0x06002E9B RID: 11931 RVA: 0x00097EB4 File Offset: 0x000960B4
		protected void RestoreGridLayout()
		{
			try
			{
				string cfgFileName = base.GetCfgFileName(string.Format("{0}-{1}", this._grid.Tag, this.GetSelectedCategory()));
				if (File.Exists(cfgFileName))
				{
					goto IL_53;
				}
				IL_2F:
				int num = -801613848;
				IL_34:
				switch ((num ^ -1908899251) % 4)
				{
				case 0:
					IL_53:
					this._grid.RestoreLayoutFromXml(cfgFileName);
					num = -1974598129;
					goto IL_34;
				case 1:
					return;
				case 3:
					goto IL_2F;
				}
				this._gridLoaded = true;
			}
			catch (Exception ex)
			{
				this._toasterService.Error(ex.Message);
			}
		}

		// Token: 0x06002E9C RID: 11932 RVA: 0x00097F58 File Offset: 0x00096158
		protected void RemoveAllAttributeColumns()
		{
			List<GridColumn> list = (from i in this._grid.Columns
			where i.Name.Contains("usercol_")
			select i).ToList<GridColumn>();
			this._grid.Columns.BeginUpdate();
			using (List<GridColumn>.Enumerator enumerator = list.GetEnumerator())
			{
				for (;;)
				{
					IL_AB:
					int num = enumerator.MoveNext() ? 1671056671 : 1702690997;
					for (;;)
					{
						switch ((num ^ 1044387461) % 4)
						{
						case 1:
							goto IL_AB;
						case 2:
						{
							GridColumn item = enumerator.Current;
							this._grid.Columns.Remove(item);
							num = 1935680388;
							continue;
						}
						case 3:
							num = 1671056671;
							continue;
						}
						goto Block_4;
					}
				}
				Block_4:;
			}
			this._grid.Columns.EndUpdate();
		}

		// Token: 0x06002E9D RID: 11933 RVA: 0x0009804C File Offset: 0x0009624C
		protected virtual Task ProductGridAttributeCols()
		{
			StoreViewModel.<ProductGridAttributeCols>d__154 <ProductGridAttributeCols>d__;
			<ProductGridAttributeCols>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ProductGridAttributeCols>d__.<>4__this = this;
			<ProductGridAttributeCols>d__.<>1__state = -1;
			<ProductGridAttributeCols>d__.<>t__builder.Start<StoreViewModel.<ProductGridAttributeCols>d__154>(ref <ProductGridAttributeCols>d__);
			return <ProductGridAttributeCols>d__.<>t__builder.Task;
		}

		// Token: 0x06002E9E RID: 11934 RVA: 0x00098090 File Offset: 0x00096290
		[CompilerGenerated]
		private Task<List<AscImage>> <OnSelectedItemChanged>b__85_0()
		{
			return MediaModel.GetThumbs(this.SelectedItem);
		}

		// Token: 0x06002E9F RID: 11935 RVA: 0x000980A8 File Offset: 0x000962A8
		[CompilerGenerated]
		private Task<List<boxes>> <OnLoad>b__141_0()
		{
			return StoreModel.LoadBoxes(this.StoreCategoriesViewModel.SelectedStore, true);
		}

		// Token: 0x06002EA0 RID: 11936 RVA: 0x0003401C File Offset: 0x0003221C
		[CompilerGenerated]
		[DebuggerHidden]
		private void <>n__0()
		{
			base.OnLoad();
		}

		// Token: 0x04001A00 RID: 6656
		private StoreViewModel.ReturnAction _returnAction;

		// Token: 0x04001A01 RID: 6657
		protected IStoreService _storeService;

		// Token: 0x04001A02 RID: 6658
		private readonly INavigationService _navigationService;

		// Token: 0x04001A03 RID: 6659
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04001A04 RID: 6660
		private readonly IAscMessageBoxService _ascMessageBoxService;

		// Token: 0x04001A05 RID: 6661
		[CompilerGenerated]
		private StoreCategoriesViewModel <StoreCategoriesViewModel>k__BackingField;

		// Token: 0x04001A06 RID: 6662
		[CompilerGenerated]
		private OnUserItemsViewModel <OnUserItems>k__BackingField;

		// Token: 0x04001A07 RID: 6663
		[CompilerGenerated]
		private int <LoadedItems>k__BackingField;

		// Token: 0x04001A08 RID: 6664
		[CompilerGenerated]
		private PhotoGroupSource <Images>k__BackingField;

		// Token: 0x04001A09 RID: 6665
		[CompilerGenerated]
		private bool <ReturnSelectedItems>k__BackingField;

		// Token: 0x04001A0A RID: 6666
		[CompilerGenerated]
		private ObservableCollection<StoreGroup> <MasterItems>k__BackingField;

		// Token: 0x04001A0B RID: 6667
		[CompilerGenerated]
		private List<boxes> <ItemBoxes>k__BackingField;

		// Token: 0x04001A0C RID: 6668
		private int _selectedTab;

		// Token: 0x04001A0D RID: 6669
		private bool _onlyMyParts;

		// Token: 0x04001A0E RID: 6670
		[CompilerGenerated]
		private ObservableCollection<items_state> <States>k__BackingField;

		// Token: 0x04001A0F RID: 6671
		[CompilerGenerated]
		private List<Product> <SelectedItems>k__BackingField = new List<Product>();

		// Token: 0x04001A10 RID: 6672
		[CompilerGenerated]
		private int <SelectedItemsCount>k__BackingField;

		// Token: 0x04001A11 RID: 6673
		[CompilerGenerated]
		private List<ItemsOptions> <ItemsOptionses>k__BackingField;

		// Token: 0x04001A12 RID: 6674
		public int MyPartsState;

		// Token: 0x04001A13 RID: 6675
		private bool _initOk;

		// Token: 0x04001A14 RID: 6676
		public int _repairId;

		// Token: 0x04001A15 RID: 6677
		[CompilerGenerated]
		private bool <ReturnOnSelect>k__BackingField;

		// Token: 0x04001A16 RID: 6678
		[CompilerGenerated]
		private int <AddCount>k__BackingField = 1;

		// Token: 0x04001A17 RID: 6679
		[CompilerGenerated]
		private decimal <AddPrice>k__BackingField;

		// Token: 0x04001A18 RID: 6680
		[CompilerGenerated]
		private List<KeyValuePair<decimal, string>> <ItemPrices>k__BackingField;

		// Token: 0x04001A19 RID: 6681
		private bool _forWarantyRepair;

		// Token: 0x04001A1A RID: 6682
		private IItemsSelect _parentViewModel;

		// Token: 0x04001A1B RID: 6683
		private IMyItemSelect _parentViewModelMyItemSelect;

		// Token: 0x04001A1C RID: 6684
		protected GridControl _grid;

		// Token: 0x04001A1D RID: 6685
		private IToasterService _toasterService;

		// Token: 0x020004A6 RID: 1190
		public enum ReturnAction
		{
			// Token: 0x04001A1F RID: 6687
			None,
			// Token: 0x04001A20 RID: 6688
			InsertToRepair
		}

		// Token: 0x020004A7 RID: 1191
		[CompilerGenerated]
		private sealed class <>c__DisplayClass76_0
		{
			// Token: 0x06002EA1 RID: 11937 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass76_0()
			{
			}

			// Token: 0x06002EA2 RID: 11938 RVA: 0x000980C8 File Offset: 0x000962C8
			internal Task <SelectedCategoryChanged>b__0()
			{
				StoreViewModel.<>c__DisplayClass76_0.<<SelectedCategoryChanged>b__0>d <<SelectedCategoryChanged>b__0>d;
				<<SelectedCategoryChanged>b__0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<SelectedCategoryChanged>b__0>d.<>4__this = this;
				<<SelectedCategoryChanged>b__0>d.<>1__state = -1;
				<<SelectedCategoryChanged>b__0>d.<>t__builder.Start<StoreViewModel.<>c__DisplayClass76_0.<<SelectedCategoryChanged>b__0>d>(ref <<SelectedCategoryChanged>b__0>d);
				return <<SelectedCategoryChanged>b__0>d.<>t__builder.Task;
			}

			// Token: 0x04001A21 RID: 6689
			public StoreViewModel <>4__this;

			// Token: 0x04001A22 RID: 6690
			public ICategory e;

			// Token: 0x020004A8 RID: 1192
			[StructLayout(LayoutKind.Auto)]
			private struct <<SelectedCategoryChanged>b__0>d : IAsyncStateMachine
			{
				// Token: 0x06002EA3 RID: 11939 RVA: 0x0009810C File Offset: 0x0009630C
				void IAsyncStateMachine.MoveNext()
				{
					int num = this.<>1__state;
					StoreViewModel.<>c__DisplayClass76_0 CS$<>8__locals1 = this.<>4__this;
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							if (CS$<>8__locals1.<>4__this.SelectedTab != 0)
							{
								goto IL_DD;
							}
							CS$<>8__locals1.<>4__this.BgLoadItems(CS$<>8__locals1.<>4__this.Query);
							if (CS$<>8__locals1.<>4__this._grid == null)
							{
								goto IL_DD;
							}
							StoreViewModel storeViewModel = CS$<>8__locals1.<>4__this;
							ICategory e = CS$<>8__locals1.e;
							storeViewModel.SaveGridLayout((e != null) ? e.Id : 0);
							CS$<>8__locals1.<>4__this.RemoveAllAttributeColumns();
							awaiter = CS$<>8__locals1.<>4__this.ProductGridAttributeCols().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, StoreViewModel.<>c__DisplayClass76_0.<<SelectedCategoryChanged>b__0>d>(ref awaiter, ref this);
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
						CS$<>8__locals1.<>4__this.RestoreGridLayout();
						IL_DD:
						if (CS$<>8__locals1.<>4__this.SelectedTab == 1)
						{
							OnUserItemsViewModel onUserItems = CS$<>8__locals1.<>4__this.OnUserItems;
							if (onUserItems != null)
							{
								onUserItems.LoadOnUserItems();
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

				// Token: 0x06002EA4 RID: 11940 RVA: 0x00098258 File Offset: 0x00096458
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04001A23 RID: 6691
				public int <>1__state;

				// Token: 0x04001A24 RID: 6692
				public AsyncTaskMethodBuilder <>t__builder;

				// Token: 0x04001A25 RID: 6693
				public StoreViewModel.<>c__DisplayClass76_0 <>4__this;

				// Token: 0x04001A26 RID: 6694
				private TaskAwaiter <>u__1;
			}
		}

		// Token: 0x020004A9 RID: 1193
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SelectedCategoryChanged>d__76 : IAsyncStateMachine
		{
			// Token: 0x06002EA5 RID: 11941 RVA: 0x00098274 File Offset: 0x00096474
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					TaskAwaiter<Task> awaiter;
					if (num != 0)
					{
						StoreViewModel.<>c__DisplayClass76_0 CS$<>8__locals1 = new StoreViewModel.<>c__DisplayClass76_0();
						CS$<>8__locals1.<>4__this = this.<>4__this;
						CS$<>8__locals1.e = this.e;
						awaiter = Application.Current.Dispatcher.InvokeAsync<Task>(new Func<Task>(CS$<>8__locals1.<SelectedCategoryChanged>b__0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Task>, StoreViewModel.<SelectedCategoryChanged>d__76>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<Task>);
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

			// Token: 0x06002EA6 RID: 11942 RVA: 0x00098354 File Offset: 0x00096554
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001A27 RID: 6695
			public int <>1__state;

			// Token: 0x04001A28 RID: 6696
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001A29 RID: 6697
			public StoreViewModel <>4__this;

			// Token: 0x04001A2A RID: 6698
			public ICategory e;

			// Token: 0x04001A2B RID: 6699
			private TaskAwaiter<Task> <>u__1;
		}

		// Token: 0x020004AA RID: 1194
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnSelectedItemChanged>d__85 : IAsyncStateMachine
		{
			// Token: 0x06002EA7 RID: 11943 RVA: 0x00098370 File Offset: 0x00096570
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				StoreViewModel storeViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						if (storeViewModel.SelectedItem == null)
						{
							goto IL_172;
						}
						if (storeViewModel.Images == null)
						{
							storeViewModel.Images = new PhotoGroupSource();
						}
						storeViewModel.Images.Clear();
					}
					try
					{
						TaskAwaiter<List<AscImage>> awaiter;
						if (num != 0)
						{
							this.<photoGroup>5__2 = new PhotoGroup(Lang.t("Photos"), new PhotoSource());
							awaiter = Task.Run<List<AscImage>>(() => MediaModel.GetThumbs(base.SelectedItem)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<AscImage>>, StoreViewModel.<OnSelectedItemChanged>d__85>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<AscImage>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						List<AscImage> result = awaiter.GetResult();
						int num4 = 1;
						List<AscImage>.Enumerator enumerator = result.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								AscImage image = enumerator.Current;
								this.<photoGroup>5__2.Photos.Add(new PhotoInfo(image, string.Format("{0} {1}", Lang.t("Foto"), num4)));
								num4++;
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)enumerator).Dispose();
							}
						}
						storeViewModel.Images.Add(this.<photoGroup>5__2);
						this.<photoGroup>5__2 = null;
					}
					catch (Exception ex)
					{
						storeViewModel._toasterService.Error(ex.Message);
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_172:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002EA8 RID: 11944 RVA: 0x00098550 File Offset: 0x00096750
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001A2C RID: 6700
			public int <>1__state;

			// Token: 0x04001A2D RID: 6701
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001A2E RID: 6702
			public StoreViewModel <>4__this;

			// Token: 0x04001A2F RID: 6703
			private PhotoGroup <photoGroup>5__2;

			// Token: 0x04001A30 RID: 6704
			private TaskAwaiter<List<AscImage>> <>u__1;
		}

		// Token: 0x020004AB RID: 1195
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002EA9 RID: 11945 RVA: 0x0009856C File Offset: 0x0009676C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06002EAA RID: 11946 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06002EAB RID: 11947 RVA: 0x00098584 File Offset: 0x00096784
			internal decimal <SetDefaultPrice>b__87_0(KeyValuePair<decimal, string> p)
			{
				return p.Key;
			}

			// Token: 0x06002EAC RID: 11948 RVA: 0x00098598 File Offset: 0x00096798
			internal bool <ReserveItem>b__120_0(Product i)
			{
				return i.Available > 0;
			}

			// Token: 0x06002EAD RID: 11949 RVA: 0x0004DAF0 File Offset: 0x0004BCF0
			internal int <GetSelected>b__126_0(Product i)
			{
				return i.Id;
			}

			// Token: 0x06002EAE RID: 11950 RVA: 0x000985B0 File Offset: 0x000967B0
			internal Task<List<items_state>> <OnLoad>b__141_1()
			{
				return ItemsModel.LoadItemStates(false);
			}

			// Token: 0x06002EAF RID: 11951 RVA: 0x000985C4 File Offset: 0x000967C4
			internal bool <RemoveAllAttributeColumns>b__153_0(GridColumn i)
			{
				return i.Name.Contains("usercol_");
			}

			// Token: 0x04001A31 RID: 6705
			public static readonly StoreViewModel.<>c <>9 = new StoreViewModel.<>c();

			// Token: 0x04001A32 RID: 6706
			public static Func<KeyValuePair<decimal, string>, decimal> <>9__87_0;

			// Token: 0x04001A33 RID: 6707
			public static Func<Product, bool> <>9__120_0;

			// Token: 0x04001A34 RID: 6708
			public static Func<Product, int> <>9__126_0;

			// Token: 0x04001A35 RID: 6709
			public static Func<Task<List<items_state>>> <>9__141_1;

			// Token: 0x04001A36 RID: 6710
			public static Func<GridColumn, bool> <>9__153_0;
		}

		// Token: 0x020004AC RID: 1196
		[CompilerGenerated]
		private sealed class <>c__DisplayClass130_0
		{
			// Token: 0x06002EB0 RID: 11952 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass130_0()
			{
			}

			// Token: 0x06002EB1 RID: 11953 RVA: 0x000985E4 File Offset: 0x000967E4
			internal bool <SelectionAdd>b__0(Product i)
			{
				return i.Id == this.item.Id;
			}

			// Token: 0x04001A37 RID: 6711
			public Product item;
		}

		// Token: 0x020004AD RID: 1197
		[CompilerGenerated]
		private sealed class <>c__DisplayClass131_0
		{
			// Token: 0x06002EB2 RID: 11954 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass131_0()
			{
			}

			// Token: 0x06002EB3 RID: 11955 RVA: 0x00098604 File Offset: 0x00096804
			internal bool <SelectionRemove>b__0(Product i)
			{
				return i.Id == this.item.id;
			}

			// Token: 0x04001A38 RID: 6712
			public store_items item;
		}

		// Token: 0x020004AE RID: 1198
		[CompilerGenerated]
		private sealed class <>c__DisplayClass138_0
		{
			// Token: 0x06002EB4 RID: 11956 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass138_0()
			{
			}

			// Token: 0x06002EB5 RID: 11957 RVA: 0x00098624 File Offset: 0x00096824
			internal Task<List<StoreGroup>> <BgLoadItems>b__0()
			{
				return StoreModel.LoadMasterItemsV2Async(this.<>4__this.StoreCategoriesViewModel.SelectedStore, this.catId, this.<>4__this.SelectedItemOption, this.<>4__this.SelectedItemBox, this.filter);
			}

			// Token: 0x04001A39 RID: 6713
			public StoreViewModel <>4__this;

			// Token: 0x04001A3A RID: 6714
			public int catId;

			// Token: 0x04001A3B RID: 6715
			public string filter;
		}

		// Token: 0x020004AF RID: 1199
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <BgLoadItems>d__138 : IAsyncStateMachine
		{
			// Token: 0x06002EB6 RID: 11958 RVA: 0x00098668 File Offset: 0x00096868
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				StoreViewModel storeViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<StoreGroup>> awaiter;
					if (num != 0)
					{
						this.<>8__1 = new StoreViewModel.<>c__DisplayClass138_0();
						this.<>8__1.<>4__this = this.<>4__this;
						this.<>8__1.filter = this.filter;
						storeViewModel.ShowWait();
						this.<>8__1.catId = storeViewModel.GetSelectedCategory();
						awaiter = Task.Run<List<StoreGroup>>(new Func<Task<List<StoreGroup>>>(this.<>8__1.<BgLoadItems>b__0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<StoreGroup>>, StoreViewModel.<BgLoadItems>d__138>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<StoreGroup>>);
						this.<>1__state = -1;
					}
					List<StoreGroup> result = awaiter.GetResult();
					if (storeViewModel.Query == this.<>8__1.filter)
					{
						storeViewModel.MasterItems = new ObservableCollection<StoreGroup>(result);
						storeViewModel.SetLoadedItems(storeViewModel.MasterItems.Count);
					}
					storeViewModel.HideWait();
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

			// Token: 0x06002EB7 RID: 11959 RVA: 0x000987C0 File Offset: 0x000969C0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001A3C RID: 6716
			public int <>1__state;

			// Token: 0x04001A3D RID: 6717
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001A3E RID: 6718
			public StoreViewModel <>4__this;

			// Token: 0x04001A3F RID: 6719
			public string filter;

			// Token: 0x04001A40 RID: 6720
			private StoreViewModel.<>c__DisplayClass138_0 <>8__1;

			// Token: 0x04001A41 RID: 6721
			private TaskAwaiter<List<StoreGroup>> <>u__1;
		}

		// Token: 0x020004B0 RID: 1200
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnLoad>d__141 : IAsyncStateMachine
		{
			// Token: 0x06002EB8 RID: 11960 RVA: 0x000987DC File Offset: 0x000969DC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				StoreViewModel storeViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<items_state>> awaiter;
					TaskAwaiter<List<boxes>> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<List<items_state>>);
							this.<>1__state = -1;
							goto IL_147;
						}
						storeViewModel.<>n__0();
						if (storeViewModel.StoreCategoriesViewModel == null)
						{
							storeViewModel.StoreCategoriesViewModel = new StoreCategoriesViewModel(storeViewModel);
							StoreCategoriesViewModel storeCategoriesViewModel = storeViewModel.StoreCategoriesViewModel;
							storeCategoriesViewModel.SelectedItemChanged = (EventHandler<ICategory>)Delegate.Combine(storeCategoriesViewModel.SelectedItemChanged, new EventHandler<ICategory>(storeViewModel.SelectedCategoryChanged));
						}
						if (storeViewModel.OnUserItems == null)
						{
							storeViewModel.OnUserItems = new OnUserItemsViewModel(storeViewModel);
						}
						if (storeViewModel.StoreCategoriesViewModel.SelectedStore == 0)
						{
							goto IL_10B;
						}
						awaiter2 = Task.Run<List<boxes>>(() => StoreModel.LoadBoxes(base.StoreCategoriesViewModel.SelectedStore, true)).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<boxes>>, StoreViewModel.<OnLoad>d__141>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<boxes>>);
						this.<>1__state = -1;
					}
					List<boxes> result = awaiter2.GetResult();
					storeViewModel.ItemBoxes = result;
					IL_10B:
					if (storeViewModel.States != null)
					{
						goto IL_180;
					}
					awaiter = Task.Run<List<items_state>>(new Func<Task<List<items_state>>>(StoreViewModel.<>c.<>9.<OnLoad>b__141_1)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<items_state>>, StoreViewModel.<OnLoad>d__141>(ref awaiter, ref this);
						return;
					}
					IL_147:
					List<items_state> result2 = awaiter.GetResult();
					storeViewModel.States = new ObservableCollection<items_state>(result2);
					IL_180:
					if (storeViewModel.ItemsOptionses == null)
					{
						storeViewModel.ItemsOptionses = StoreModel.LoadItemsOptionses();
					}
					storeViewModel._initOk = true;
					if (storeViewModel._selectedTab == 1)
					{
						storeViewModel.OnUserItems.LoadOnUserItems();
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

			// Token: 0x06002EB9 RID: 11961 RVA: 0x000989E4 File Offset: 0x00096BE4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001A42 RID: 6722
			public int <>1__state;

			// Token: 0x04001A43 RID: 6723
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001A44 RID: 6724
			public StoreViewModel <>4__this;

			// Token: 0x04001A45 RID: 6725
			private TaskAwaiter<List<boxes>> <>u__1;

			// Token: 0x04001A46 RID: 6726
			private TaskAwaiter<List<items_state>> <>u__2;
		}

		// Token: 0x020004B1 RID: 1201
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ItemDelete>d__145 : IAsyncStateMachine
		{
			// Token: 0x06002EBA RID: 11962 RVA: 0x00098A00 File Offset: 0x00096C00
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				StoreViewModel storeViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						if (storeViewModel._ascMessageBoxService.ShowMessageBox(Lang.t("ConfirmDelete") + "?", Lang.t("Attention"), MessageBoxButton.YesNo, MessageBoxImage.Exclamation) != MessageBoxResult.Yes)
						{
							goto IL_113;
						}
						storeViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = storeViewModel._storeService.DeleteProductAsync(storeViewModel.SelectedItem.Id).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, StoreViewModel.<ItemDelete>d__145>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						awaiter.GetResult();
						storeViewModel._toasterService.Info(Lang.t("Removed"));
						storeViewModel.ReloadItems();
					}
					catch (Exception ex)
					{
						storeViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							storeViewModel.HideWait();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_113:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002EBB RID: 11963 RVA: 0x00098B5C File Offset: 0x00096D5C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001A47 RID: 6727
			public int <>1__state;

			// Token: 0x04001A48 RID: 6728
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001A49 RID: 6729
			public StoreViewModel <>4__this;

			// Token: 0x04001A4A RID: 6730
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020004B2 RID: 1202
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GridLoaded>d__147 : IAsyncStateMachine
		{
			// Token: 0x06002EBC RID: 11964 RVA: 0x00098B78 File Offset: 0x00096D78
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				StoreViewModel storeViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						GridControl gridControl = this.obj as GridControl;
						if (gridControl == null)
						{
							goto IL_AB;
						}
						storeViewModel._grid = gridControl;
						storeViewModel.RemoveAllAttributeColumns();
						awaiter = storeViewModel.ProductGridAttributeCols().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, StoreViewModel.<GridLoaded>d__147>(ref awaiter, ref this);
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
					storeViewModel.RestoreGridLayout();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_AB:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002EBD RID: 11965 RVA: 0x00098C54 File Offset: 0x00096E54
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001A4B RID: 6731
			public int <>1__state;

			// Token: 0x04001A4C RID: 6732
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001A4D RID: 6733
			public object obj;

			// Token: 0x04001A4E RID: 6734
			public StoreViewModel <>4__this;

			// Token: 0x04001A4F RID: 6735
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020004B3 RID: 1203
		[CompilerGenerated]
		private sealed class <>c__DisplayClass154_0
		{
			// Token: 0x06002EBE RID: 11966 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass154_0()
			{
			}

			// Token: 0x06002EBF RID: 11967 RVA: 0x00098C70 File Offset: 0x00096E70
			internal bool <ProductGridAttributeCols>b__0(GridColumn c)
			{
				return c.FieldName == this.field.name;
			}

			// Token: 0x04001A50 RID: 6736
			public fields field;
		}

		// Token: 0x020004B4 RID: 1204
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ProductGridAttributeCols>d__154 : IAsyncStateMachine
		{
			// Token: 0x06002EC0 RID: 11968 RVA: 0x00098C94 File Offset: 0x00096E94
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				StoreViewModel storeViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<fields>> awaiter;
					if (num != 0)
					{
						awaiter = storeViewModel._storeService.GetCategoryFieldsAsync(storeViewModel.GetSelectedCategory()).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.<>1__state = num2;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<fields>>, StoreViewModel.<ProductGridAttributeCols>d__154>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<fields>>);
						int num3 = -1;
						num = -1;
						this.<>1__state = num3;
					}
					List<fields> result = awaiter.GetResult();
					if (result != null && result.Count != 0)
					{
						ProductsConverter converter = new ProductsConverter();
						storeViewModel._grid.Columns.BeginUpdate();
						List<fields>.Enumerator enumerator = result.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								StoreViewModel.<>c__DisplayClass154_0 CS$<>8__locals1 = new StoreViewModel.<>c__DisplayClass154_0();
								CS$<>8__locals1.field = enumerator.Current;
								if (!storeViewModel._grid.Columns.Any(new Func<GridColumn, bool>(CS$<>8__locals1.<ProductGridAttributeCols>b__0)))
								{
									Binding binding = new Binding("Attributes")
									{
										ConverterParameter = CS$<>8__locals1.field.id,
										Converter = converter,
										Mode = BindingMode.OneWay
									};
									GridColumn item = BaseViewModel.AttributeCol(CS$<>8__locals1.field, binding);
									try
									{
										storeViewModel._grid.Columns.Add(item);
									}
									catch (Exception)
									{
									}
								}
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)enumerator).Dispose();
							}
						}
						storeViewModel._grid.Columns.EndUpdate();
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

			// Token: 0x06002EC1 RID: 11969 RVA: 0x00098E8C File Offset: 0x0009708C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001A51 RID: 6737
			public int <>1__state;

			// Token: 0x04001A52 RID: 6738
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001A53 RID: 6739
			public StoreViewModel <>4__this;

			// Token: 0x04001A54 RID: 6740
			private TaskAwaiter<List<fields>> <>u__1;
		}
	}
}
