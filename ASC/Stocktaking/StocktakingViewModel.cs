using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Media;
using ASC.ItemsCancellation;
using ASC.Models;
using ASC.Objects;
using ASC.Options;
using ASC.Services.Abstract;
using ASC.Stickers;
using ASC.ViewModels;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.Stocktaking
{
	// Token: 0x020001EB RID: 491
	public class StocktakingViewModel : CollectionViewModel<store_items>
	{
		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06001AEB RID: 6891 RVA: 0x0004F780 File Offset: 0x0004D980
		// (set) Token: 0x06001AEC RID: 6892 RVA: 0x0004F794 File Offset: 0x0004D994
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

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06001AED RID: 6893 RVA: 0x0004F7C4 File Offset: 0x0004D9C4
		// (set) Token: 0x06001AEE RID: 6894 RVA: 0x0004F7D8 File Offset: 0x0004D9D8
		public List<items_state> ItemStatesWithAll
		{
			[CompilerGenerated]
			get
			{
				return this.<ItemStatesWithAll>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ItemStatesWithAll>k__BackingField, value))
				{
					return;
				}
				this.<ItemStatesWithAll>k__BackingField = value;
				this.RaisePropertyChanged("ItemStatesWithAll");
			}
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06001AEF RID: 6895 RVA: 0x0004F808 File Offset: 0x0004DA08
		// (set) Token: 0x06001AF0 RID: 6896 RVA: 0x0004F81C File Offset: 0x0004DA1C
		public List<items_state> ItemStates
		{
			[CompilerGenerated]
			get
			{
				return this.<ItemStates>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ItemStates>k__BackingField, value))
				{
					return;
				}
				this.<ItemStates>k__BackingField = value;
				this.RaisePropertyChanged("ItemStates");
			}
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06001AF1 RID: 6897 RVA: 0x0004F84C File Offset: 0x0004DA4C
		// (set) Token: 0x06001AF2 RID: 6898 RVA: 0x0004F860 File Offset: 0x0004DA60
		public List<store_cats> StoreCategories
		{
			[CompilerGenerated]
			get
			{
				return this.<StoreCategories>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<StoreCategories>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -311263281;
				IL_13:
				switch ((num ^ -1612292947) % 4)
				{
				case 1:
					IL_32:
					this.<StoreCategories>k__BackingField = value;
					this.RaisePropertyChanged("StoreCategories");
					num = -844770323;
					goto IL_13;
				case 2:
					return;
				case 3:
					goto IL_0E;
				}
			}
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x06001AF3 RID: 6899 RVA: 0x0004F8BC File Offset: 0x0004DABC
		// (set) Token: 0x06001AF4 RID: 6900 RVA: 0x0004F8D0 File Offset: 0x0004DAD0
		public List<store_cats> ItemCategories
		{
			[CompilerGenerated]
			get
			{
				return this.<ItemCategories>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ItemCategories>k__BackingField, value))
				{
					return;
				}
				this.<ItemCategories>k__BackingField = value;
				this.RaisePropertyChanged("ItemCategories");
			}
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06001AF5 RID: 6901 RVA: 0x0004F900 File Offset: 0x0004DB00
		// (set) Token: 0x06001AF6 RID: 6902 RVA: 0x0004F914 File Offset: 0x0004DB14
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
				if (object.Equals(this.<ItemsOptionses>k__BackingField, value))
				{
					return;
				}
				this.<ItemsOptionses>k__BackingField = value;
				this.RaisePropertyChanged("ItemsOptionses");
			}
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06001AF7 RID: 6903 RVA: 0x0004F944 File Offset: 0x0004DB44
		// (set) Token: 0x06001AF8 RID: 6904 RVA: 0x0004F958 File Offset: 0x0004DB58
		public List<StockTakingOptions> StockTakingOptions
		{
			[CompilerGenerated]
			get
			{
				return this.<StockTakingOptions>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<StockTakingOptions>k__BackingField, value))
				{
					return;
				}
				this.<StockTakingOptions>k__BackingField = value;
				this.RaisePropertyChanged("StockTakingOptions");
			}
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06001AF9 RID: 6905 RVA: 0x0004F988 File Offset: 0x0004DB88
		// (set) Token: 0x06001AFA RID: 6906 RVA: 0x0004F99C File Offset: 0x0004DB9C
		public List<StockTakingOptions> AllStockTakingOptions
		{
			[CompilerGenerated]
			get
			{
				return this.<AllStockTakingOptions>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<AllStockTakingOptions>k__BackingField, value))
				{
					return;
				}
				this.<AllStockTakingOptions>k__BackingField = value;
				this.RaisePropertyChanged("AllStockTakingOptions");
			}
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x06001AFB RID: 6907 RVA: 0x0004F9CC File Offset: 0x0004DBCC
		// (set) Token: 0x06001AFC RID: 6908 RVA: 0x0004F9E0 File Offset: 0x0004DBE0
		public List<boxes> Boxes
		{
			[CompilerGenerated]
			get
			{
				return this.<Boxes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Boxes>k__BackingField, value))
				{
					return;
				}
				this.<Boxes>k__BackingField = value;
				this.RaisePropertyChanged("Boxes");
			}
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x06001AFD RID: 6909 RVA: 0x0004FA10 File Offset: 0x0004DC10
		// (set) Token: 0x06001AFE RID: 6910 RVA: 0x0004FA24 File Offset: 0x0004DC24
		public string Query
		{
			[CompilerGenerated]
			get
			{
				return this.<Query>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Query>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Query>k__BackingField = value;
				this.RaisePropertyChanged("Query");
			}
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x06001AFF RID: 6911 RVA: 0x0004FA54 File Offset: 0x0004DC54
		// (set) Token: 0x06001B00 RID: 6912 RVA: 0x0004FA68 File Offset: 0x0004DC68
		public bool SearchInDescription
		{
			[CompilerGenerated]
			get
			{
				return this.<SearchInDescription>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SearchInDescription>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = 783486240;
				IL_10:
				switch ((num ^ 488074290) % 4)
				{
				case 0:
					goto IL_0B;
				case 2:
					return;
				case 3:
					IL_2F:
					this.<SearchInDescription>k__BackingField = value;
					num = 730387671;
					goto IL_10;
				}
				this.RaisePropertyChanged("SearchInDescription");
			}
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x06001B01 RID: 6913 RVA: 0x0004FAC0 File Offset: 0x0004DCC0
		// (set) Token: 0x06001B02 RID: 6914 RVA: 0x0004FAD4 File Offset: 0x0004DCD4
		public List<int> SelectedBoxes
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedBoxes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedBoxes>k__BackingField, value))
				{
					return;
				}
				this.<SelectedBoxes>k__BackingField = value;
				this.RaisePropertyChanged("SelectedBoxes");
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06001B03 RID: 6915 RVA: 0x0004FB04 File Offset: 0x0004DD04
		// (set) Token: 0x06001B04 RID: 6916 RVA: 0x0004FB18 File Offset: 0x0004DD18
		public int SelectedStoreCategory
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedStoreCategory>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedStoreCategory>k__BackingField == value)
				{
					return;
				}
				this.<SelectedStoreCategory>k__BackingField = value;
				this.RaisePropertyChanged("SelectedStoreCategory");
			}
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06001B05 RID: 6917 RVA: 0x0004FB44 File Offset: 0x0004DD44
		// (set) Token: 0x06001B06 RID: 6918 RVA: 0x0004FB58 File Offset: 0x0004DD58
		public int SelectedItemOption
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedItemOption>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedItemOption>k__BackingField == value)
				{
					return;
				}
				this.<SelectedItemOption>k__BackingField = value;
				this.RaisePropertyChanged("SelectedItemOption");
			}
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06001B07 RID: 6919 RVA: 0x0004FB84 File Offset: 0x0004DD84
		// (set) Token: 0x06001B08 RID: 6920 RVA: 0x0004FB98 File Offset: 0x0004DD98
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

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06001B09 RID: 6921 RVA: 0x0004FBC4 File Offset: 0x0004DDC4
		// (set) Token: 0x06001B0A RID: 6922 RVA: 0x0004FBD8 File Offset: 0x0004DDD8
		public int SelectedStockTakingOption
		{
			get
			{
				return this._selectedStockTakingOption;
			}
			set
			{
				if (this._selectedStockTakingOption == value)
				{
					return;
				}
				this._selectedStockTakingOption = value;
				this.RaisePropertyChanged("SelectedStockTakingOption");
				if (base.Items != null)
				{
					foreach (store_items store_items in base.Items)
					{
						store_items.st_state = value;
					}
				}
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06001B0B RID: 6923 RVA: 0x0004FC4C File Offset: 0x0004DE4C
		// (set) Token: 0x06001B0C RID: 6924 RVA: 0x0004FC60 File Offset: 0x0004DE60
		public int SelectedStockTakingFilterOption
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedStockTakingFilterOption>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedStockTakingFilterOption>k__BackingField == value)
				{
					return;
				}
				this.<SelectedStockTakingFilterOption>k__BackingField = value;
				this.RaisePropertyChanged("SelectedStockTakingFilterOption");
			}
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06001B0D RID: 6925 RVA: 0x0004FC8C File Offset: 0x0004DE8C
		// (set) Token: 0x06001B0E RID: 6926 RVA: 0x0004FCA0 File Offset: 0x0004DEA0
		public stores SelectedStore
		{
			get
			{
				return this._selectedStore;
			}
			set
			{
				if (object.Equals(this._selectedStore, value))
				{
					return;
				}
				this._selectedStore = value;
				this.RaisePropertyChanged("SelectedStore");
				if (this._selectedStore != null && this._selectedStore.id == 0)
				{
					this.SelectedStoreCategory = 0;
				}
				this.LoadStoreCategories_();
				this.LoadStoreBoxes();
			}
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x0004FCF8 File Offset: 0x0004DEF8
		public StocktakingViewModel(INavigationService navigationService, IToasterService toasterService, IWindowedDocumentService windowedDocumentService)
		{
			this._navigationService = navigationService;
			this._toasterService = toasterService;
			this._windowedDocumentService = windowedDocumentService;
			this.SetViewName("Stocktaking");
			base.SelectedItems = new List<store_items>();
			this.StockTakingOptions = this.GetStockTakingOptionses(false);
			this.AllStockTakingOptions = this.GetStockTakingOptionses(true);
			this.LoadStores();
			List<stores> stores = this.Stores;
			stores selectedStore;
			if (stores == null)
			{
				selectedStore = null;
			}
			else
			{
				selectedStore = stores.FirstOrDefault((stores s) => s.id == OfflineData.Instance.Employee.StoreDefault);
			}
			this.SelectedStore = selectedStore;
			this.LoadItemStates();
			List<items_state> list = new List<items_state>(this.ItemStatesWithAll);
			list.RemoveAt(0);
			this.ItemStates = list;
			this.ItemsOptionses = ItemsOptions.GetStockTakingOptions();
		}

		// Token: 0x06001B10 RID: 6928 RVA: 0x0004FDD4 File Offset: 0x0004DFD4
		private List<StockTakingOptions> GetStockTakingOptionses(bool includeAll = false)
		{
			List<StockTakingOptions> list = new List<StockTakingOptions>
			{
				new StockTakingOptions(0, "Clear", new SolidColorBrush(Colors.Gray)),
				new StockTakingOptions(1, "Ok", new SolidColorBrush(Colors.LightGreen)),
				new StockTakingOptions(2, "Wait", new SolidColorBrush(Colors.Yellow)),
				new StockTakingOptions(3, "Err", new SolidColorBrush(Colors.LightCoral))
			};
			if (includeAll)
			{
				list.Add(new StockTakingOptions(-1, "All", new SolidColorBrush(Colors.White)));
			}
			return list;
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x0004FE74 File Offset: 0x0004E074
		[Command]
		public void Refresh()
		{
			this.BgLoadItems();
		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x0004FE88 File Offset: 0x0004E088
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

		// Token: 0x06001B13 RID: 6931 RVA: 0x0004FEB8 File Offset: 0x0004E0B8
		[AsyncCommand]
		public Task Save()
		{
			StocktakingViewModel.<Save>d__80 <Save>d__;
			<Save>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Save>d__.<>4__this = this;
			<Save>d__.<>1__state = -1;
			<Save>d__.<>t__builder.Start<StocktakingViewModel.<Save>d__80>(ref <Save>d__);
			return <Save>d__.<>t__builder.Task;
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x0004FEFC File Offset: 0x0004E0FC
		[Command]
		public void ItemDoubleClick()
		{
			if (base.SelectedItem != null)
			{
				goto IL_2C;
			}
			IL_08:
			int num = -1155790191;
			IL_0D:
			switch ((num ^ -1769939228) % 4)
			{
			case 1:
				return;
			case 2:
				goto IL_08;
			case 3:
				IL_2C:
				this._navigationService.NavigateToStoreItem(base.SelectedItem.id, 0);
				num = -521457968;
				goto IL_0D;
			}
		}

		// Token: 0x06001B15 RID: 6933 RVA: 0x0004FF54 File Offset: 0x0004E154
		private void BgLoadItems()
		{
			if (this.SelectedStore == null)
			{
				this._toasterService.Info(Lang.t("SelectStore2"));
				return;
			}
			base.ShowWait();
			this._storeModel.StockTakingItemsRollBack();
			Task.Run<List<store_items>>(() => this._storeModel.LoadStockTakingItems(this.SelectedStore.id, this.SelectedStoreCategory, this.SelectedItemOption, this.SelectedState, this.SelectedBoxes, this.Query, this.SearchInDescription, this.SelectedStockTakingFilterOption)).ContinueWith(delegate(Task<List<store_items>> t)
			{
				base.SetItems(t.Result);
				base.HideWait();
			}, TaskScheduler.FromCurrentSynchronizationContext());
		}

		// Token: 0x06001B16 RID: 6934 RVA: 0x0004FFB8 File Offset: 0x0004E1B8
		private void LoadStores()
		{
			StocktakingViewModel.<LoadStores>d__83 <LoadStores>d__;
			<LoadStores>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadStores>d__.<>4__this = this;
			<LoadStores>d__.<>1__state = -1;
			<LoadStores>d__.<>t__builder.Start<StocktakingViewModel.<LoadStores>d__83>(ref <LoadStores>d__);
		}

		// Token: 0x06001B17 RID: 6935 RVA: 0x0004FFF0 File Offset: 0x0004E1F0
		private void LoadStoreCategories_()
		{
			StocktakingViewModel.<LoadStoreCategories_>d__84 <LoadStoreCategories_>d__;
			<LoadStoreCategories_>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadStoreCategories_>d__.<>4__this = this;
			<LoadStoreCategories_>d__.<>1__state = -1;
			<LoadStoreCategories_>d__.<>t__builder.Start<StocktakingViewModel.<LoadStoreCategories_>d__84>(ref <LoadStoreCategories_>d__);
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x00050028 File Offset: 0x0004E228
		private void LoadStoreBoxes()
		{
			if (this.SelectedStore != null && this.SelectedStore.id != 0)
			{
				Boxes boxes = new Boxes(this.SelectedStore.id);
				this.Boxes = boxes.Boxeses;
				return;
			}
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x00050068 File Offset: 0x0004E268
		private void LoadItemStates()
		{
			StocktakingViewModel.<LoadItemStates>d__86 <LoadItemStates>d__;
			<LoadItemStates>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadItemStates>d__.<>4__this = this;
			<LoadItemStates>d__.<>1__state = -1;
			<LoadItemStates>d__.<>t__builder.Start<StocktakingViewModel.<LoadItemStates>d__86>(ref <LoadItemStates>d__);
		}

		// Token: 0x06001B1A RID: 6938 RVA: 0x000500A0 File Offset: 0x0004E2A0
		[Command]
		public void ItemCancellation()
		{
			if (base.SelectedItems != null && base.SelectedItems.Any<store_items>())
			{
				List<int> ids = (from i in base.SelectedItems
				select i.id).ToList<int>();
				this._windowedDocumentService.ShowNewDocument("ItemsCancellationView", new ItemsCancellationViewModel(ids), null, null);
				return;
			}
			this._windowedDocumentService.ShowNewDocument("ItemsCancellationView", new ItemsCancellationViewModel(new List<int>
			{
				base.SelectedItem.id
			}), null, null);
		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x00050138 File Offset: 0x0004E338
		public bool CanItemCancellation()
		{
			return base.SelectedItem != null || (base.SelectedItems != null && base.SelectedItems.Any<store_items>());
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x00050164 File Offset: 0x0004E364
		[Command]
		public void PrintStickers()
		{
			if (base.SelectedItems != null && base.SelectedItems.Any<store_items>())
			{
				List<int> itemIds = (from i in base.SelectedItems
				select i.id).ToList<int>();
				this._windowedDocumentService.ShowNewDocument("StickersView", new StickersViewModel(itemIds), null, null);
				return;
			}
			this._windowedDocumentService.ShowNewDocument("StickersView", new StickersViewModel(new List<int>
			{
				base.SelectedItem.id
			}), null, null);
		}

		// Token: 0x06001B1D RID: 6941 RVA: 0x000501FC File Offset: 0x0004E3FC
		public bool CanPrintStickers()
		{
			return base.SelectedItem != null || (base.SelectedItems != null && base.SelectedItems.Any<store_items>());
		}

		// Token: 0x06001B1E RID: 6942 RVA: 0x00050228 File Offset: 0x0004E428
		[Command]
		public void NavigateItemEdit()
		{
			if (base.SelectedItem == null)
			{
				return;
			}
			this._navigationService.NavigateToStoreItem(base.SelectedItem.id, 1);
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x00050258 File Offset: 0x0004E458
		public bool CanNavigateItemEdit()
		{
			return base.SelectedItem != null;
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x00050270 File Offset: 0x0004E470
		[Command]
		public void ItemMedia()
		{
			if (base.SelectedItem != null)
			{
				goto IL_2C;
			}
			IL_08:
			int num = 2076791427;
			IL_0D:
			switch ((num ^ 969606745) % 4)
			{
			case 0:
				goto IL_08;
			case 2:
				return;
			case 3:
				IL_2C:
				this._navigationService.NavigateToStoreItem(base.SelectedItem.id, 0);
				num = 1199710820;
				goto IL_0D;
			}
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x000502C8 File Offset: 0x0004E4C8
		[Command]
		public void NavigateItemCard()
		{
			if (base.SelectedItem != null)
			{
				goto IL_2C;
			}
			IL_08:
			int num = -785321251;
			IL_0D:
			switch ((num ^ -1259127733) % 4)
			{
			case 0:
				goto IL_08;
			case 1:
				IL_2C:
				this._navigationService.Navigate("ItemCardView", new ItemCardViewModel(base.SelectedItem.id, 0));
				num = -445282972;
				goto IL_0D;
			case 2:
				return;
			}
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x00050258 File Offset: 0x0004E458
		public bool CanNavigateItemCard()
		{
			return base.SelectedItem != null;
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x0005032C File Offset: 0x0004E52C
		[CompilerGenerated]
		private Task<List<store_items>> <BgLoadItems>b__82_0()
		{
			return this._storeModel.LoadStockTakingItems(this.SelectedStore.id, this.SelectedStoreCategory, this.SelectedItemOption, this.SelectedState, this.SelectedBoxes, this.Query, this.SearchInDescription, this.SelectedStockTakingFilterOption);
		}

		// Token: 0x06001B24 RID: 6948 RVA: 0x0005037C File Offset: 0x0004E57C
		[CompilerGenerated]
		private void <BgLoadItems>b__82_1(Task<List<store_items>> t)
		{
			base.SetItems(t.Result);
			base.HideWait();
		}

		// Token: 0x04000E1F RID: 3615
		private StoreModel _storeModel = new StoreModel();

		// Token: 0x04000E20 RID: 3616
		[CompilerGenerated]
		private List<stores> <Stores>k__BackingField;

		// Token: 0x04000E21 RID: 3617
		[CompilerGenerated]
		private List<items_state> <ItemStatesWithAll>k__BackingField;

		// Token: 0x04000E22 RID: 3618
		[CompilerGenerated]
		private List<items_state> <ItemStates>k__BackingField;

		// Token: 0x04000E23 RID: 3619
		[CompilerGenerated]
		private List<store_cats> <StoreCategories>k__BackingField;

		// Token: 0x04000E24 RID: 3620
		[CompilerGenerated]
		private List<store_cats> <ItemCategories>k__BackingField;

		// Token: 0x04000E25 RID: 3621
		[CompilerGenerated]
		private List<ItemsOptions> <ItemsOptionses>k__BackingField;

		// Token: 0x04000E26 RID: 3622
		[CompilerGenerated]
		private List<StockTakingOptions> <StockTakingOptions>k__BackingField;

		// Token: 0x04000E27 RID: 3623
		[CompilerGenerated]
		private List<StockTakingOptions> <AllStockTakingOptions>k__BackingField;

		// Token: 0x04000E28 RID: 3624
		[CompilerGenerated]
		private List<boxes> <Boxes>k__BackingField;

		// Token: 0x04000E29 RID: 3625
		[CompilerGenerated]
		private string <Query>k__BackingField;

		// Token: 0x04000E2A RID: 3626
		[CompilerGenerated]
		private bool <SearchInDescription>k__BackingField;

		// Token: 0x04000E2B RID: 3627
		[CompilerGenerated]
		private List<int> <SelectedBoxes>k__BackingField;

		// Token: 0x04000E2C RID: 3628
		[CompilerGenerated]
		private int <SelectedStoreCategory>k__BackingField;

		// Token: 0x04000E2D RID: 3629
		[CompilerGenerated]
		private int <SelectedItemOption>k__BackingField = 2;

		// Token: 0x04000E2E RID: 3630
		[CompilerGenerated]
		private int <SelectedState>k__BackingField;

		// Token: 0x04000E2F RID: 3631
		[CompilerGenerated]
		private int <SelectedStockTakingFilterOption>k__BackingField = -1;

		// Token: 0x04000E30 RID: 3632
		private stores _selectedStore;

		// Token: 0x04000E31 RID: 3633
		private int _selectedStockTakingOption;

		// Token: 0x04000E32 RID: 3634
		private readonly INavigationService _navigationService;

		// Token: 0x04000E33 RID: 3635
		private readonly IToasterService _toasterService;

		// Token: 0x04000E34 RID: 3636
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x020001EC RID: 492
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001B25 RID: 6949 RVA: 0x0005039C File Offset: 0x0004E59C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06001B26 RID: 6950 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06001B27 RID: 6951 RVA: 0x0004DAA4 File Offset: 0x0004BCA4
			internal bool <.ctor>b__76_0(stores s)
			{
				return s.id == OfflineData.Instance.Employee.StoreDefault;
			}

			// Token: 0x06001B28 RID: 6952 RVA: 0x000503B4 File Offset: 0x0004E5B4
			internal int <ItemCancellation>b__87_0(store_items i)
			{
				return i.id;
			}

			// Token: 0x06001B29 RID: 6953 RVA: 0x000503B4 File Offset: 0x0004E5B4
			internal int <PrintStickers>b__89_0(store_items i)
			{
				return i.id;
			}

			// Token: 0x04000E35 RID: 3637
			public static readonly StocktakingViewModel.<>c <>9 = new StocktakingViewModel.<>c();

			// Token: 0x04000E36 RID: 3638
			public static Func<stores, bool> <>9__76_0;

			// Token: 0x04000E37 RID: 3639
			public static Func<store_items, int> <>9__87_0;

			// Token: 0x04000E38 RID: 3640
			public static Func<store_items, int> <>9__89_0;
		}

		// Token: 0x020001ED RID: 493
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Save>d__80 : IAsyncStateMachine
		{
			// Token: 0x06001B2A RID: 6954 RVA: 0x000503C8 File Offset: 0x0004E5C8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				StocktakingViewModel stocktakingViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						stocktakingViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter<bool> awaiter;
						if (num != 0)
						{
							awaiter = stocktakingViewModel._storeModel.SaveStockTakingItems(stocktakingViewModel.Items).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, StocktakingViewModel.<Save>d__80>(ref awaiter, ref this);
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
					}
					catch (Exception ex)
					{
						stocktakingViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							stocktakingViewModel.HideWait();
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

			// Token: 0x06001B2B RID: 6955 RVA: 0x000504D0 File Offset: 0x0004E6D0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000E39 RID: 3641
			public int <>1__state;

			// Token: 0x04000E3A RID: 3642
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000E3B RID: 3643
			public StocktakingViewModel <>4__this;

			// Token: 0x04000E3C RID: 3644
			private TaskAwaiter<bool> <>u__1;
		}

		// Token: 0x020001EE RID: 494
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadStores>d__83 : IAsyncStateMachine
		{
			// Token: 0x06001B2C RID: 6956 RVA: 0x000504EC File Offset: 0x0004E6EC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				StocktakingViewModel stocktakingViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<stores>> awaiter;
					if (num != 0)
					{
						awaiter = StoreModel.LoadStores(false, true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<stores>>, StocktakingViewModel.<LoadStores>d__83>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<stores>>);
						this.<>1__state = -1;
					}
					List<stores> result = awaiter.GetResult();
					stocktakingViewModel.Stores = result;
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

			// Token: 0x06001B2D RID: 6957 RVA: 0x000505AC File Offset: 0x0004E7AC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000E3D RID: 3645
			public int <>1__state;

			// Token: 0x04000E3E RID: 3646
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000E3F RID: 3647
			public StocktakingViewModel <>4__this;

			// Token: 0x04000E40 RID: 3648
			private TaskAwaiter<List<stores>> <>u__1;
		}

		// Token: 0x020001EF RID: 495
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadStoreCategories_>d__84 : IAsyncStateMachine
		{
			// Token: 0x06001B2E RID: 6958 RVA: 0x000505C8 File Offset: 0x0004E7C8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				StocktakingViewModel stocktakingViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<store_cats>> awaiter;
					if (num != 0)
					{
						if (stocktakingViewModel.SelectedStore == null || stocktakingViewModel.SelectedStore.id == 0)
						{
							goto IL_DA;
						}
						awaiter = stocktakingViewModel._storeModel.LoadStoreCategories(stocktakingViewModel.SelectedStore.id, true, false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_cats>>, StocktakingViewModel.<LoadStoreCategories_>d__84>(ref awaiter, ref this);
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
					stocktakingViewModel.StoreCategories = new List<store_cats>(result);
					List<store_cats> list = new List<store_cats>(stocktakingViewModel.StoreCategories);
					list.RemoveAt(0);
					stocktakingViewModel.ItemCategories = list;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_DA:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06001B2F RID: 6959 RVA: 0x000506D4 File Offset: 0x0004E8D4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000E41 RID: 3649
			public int <>1__state;

			// Token: 0x04000E42 RID: 3650
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000E43 RID: 3651
			public StocktakingViewModel <>4__this;

			// Token: 0x04000E44 RID: 3652
			private TaskAwaiter<List<store_cats>> <>u__1;
		}

		// Token: 0x020001F0 RID: 496
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadItemStates>d__86 : IAsyncStateMachine
		{
			// Token: 0x06001B30 RID: 6960 RVA: 0x000506F0 File Offset: 0x0004E8F0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				StocktakingViewModel stocktakingViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<items_state>> awaiter;
					if (num != 0)
					{
						awaiter = ItemsModel.LoadItemStates(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<items_state>>, StocktakingViewModel.<LoadItemStates>d__86>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<items_state>>);
						this.<>1__state = -1;
					}
					List<items_state> result = awaiter.GetResult();
					stocktakingViewModel.ItemStatesWithAll = new List<items_state>(result);
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

			// Token: 0x06001B31 RID: 6961 RVA: 0x000507B4 File Offset: 0x0004E9B4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000E45 RID: 3653
			public int <>1__state;

			// Token: 0x04000E46 RID: 3654
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000E47 RID: 3655
			public StocktakingViewModel <>4__this;

			// Token: 0x04000E48 RID: 3656
			private TaskAwaiter<List<items_state>> <>u__1;
		}
	}
}
