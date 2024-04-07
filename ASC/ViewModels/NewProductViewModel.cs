using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Input;
using ASC.Common.Interfaces;
using ASC.Common.Objects;
using ASC.Interfaces;
using ASC.ItemsArrival;
using ASC.Objects;
using ASC.Options;
using ASC.Services.Abstract;
using ASC.ViewModels.ItemCard;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Grid.LookUp;
using Poly;

namespace ASC.ViewModels
{
	// Token: 0x02000406 RID: 1030
	public class NewProductViewModel : CollectionViewModel<Product>
	{
		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x06002983 RID: 10627 RVA: 0x00082240 File Offset: 0x00080440
		public IProductAttributesViewModel ProductAttributesViewModel
		{
			[CompilerGenerated]
			get
			{
				return this.<ProductAttributesViewModel>k__BackingField;
			}
		}

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x06002984 RID: 10628 RVA: 0x00082254 File Offset: 0x00080454
		public ObservableCollection<boxes> Boxes
		{
			[CompilerGenerated]
			get
			{
				return this.<Boxes>k__BackingField;
			}
		}

		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x06002985 RID: 10629 RVA: 0x00082268 File Offset: 0x00080468
		public List<ItemUnits> Units
		{
			[CompilerGenerated]
			get
			{
				return this.<Units>k__BackingField;
			}
		}

		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x06002986 RID: 10630 RVA: 0x0008227C File Offset: 0x0008047C
		// (set) Token: 0x06002987 RID: 10631 RVA: 0x00082290 File Offset: 0x00080490
		public Product Item
		{
			[CompilerGenerated]
			get
			{
				return this.<Item>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<Item>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1577061091;
				IL_13:
				switch ((num ^ -736750385) % 4)
				{
				case 0:
					goto IL_0E;
				case 2:
					return;
				case 3:
					IL_32:
					num = -721500366;
					goto IL_13;
				}
				this.<Item>k__BackingField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x06002988 RID: 10632 RVA: 0x000822EC File Offset: 0x000804EC
		// (set) Token: 0x06002989 RID: 10633 RVA: 0x00082330 File Offset: 0x00080530
		public string Name
		{
			get
			{
				return base.GetProperty<string>(() => this.Name);
			}
			set
			{
				if (string.Equals(this.Name, value, StringComparison.Ordinal))
				{
					return;
				}
				base.SetProperty<string>(() => this.Name, value, new Action(this.OnNameChanged));
				this.RaisePropertyChanged("Name");
			}
		}

		// Token: 0x0600298A RID: 10634 RVA: 0x0008239C File Offset: 0x0008059C
		private void OnNameChanged()
		{
			this._query = this.Name;
			this.Item.Name = this.Name;
			if (this.disallowItemNameDropdown)
			{
				this.disallowItemNameDropdown = false;
				return;
			}
			this.Search(this.Name);
		}

		// Token: 0x17000DD9 RID: 3545
		// (get) Token: 0x0600298B RID: 10635 RVA: 0x000823E4 File Offset: 0x000805E4
		// (set) Token: 0x0600298C RID: 10636 RVA: 0x000823F8 File Offset: 0x000805F8
		public int PriceOption
		{
			[CompilerGenerated]
			get
			{
				return this.<PriceOption>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PriceOption>k__BackingField == value)
				{
					return;
				}
				this.<PriceOption>k__BackingField = value;
				this.RaisePropertyChanged("PriceOption");
			}
		}

		// Token: 0x17000DDA RID: 3546
		// (get) Token: 0x0600298D RID: 10637 RVA: 0x00082424 File Offset: 0x00080624
		public ImagesAddlViewModel ImagesAddlViewModel
		{
			[CompilerGenerated]
			get
			{
				return this.<ImagesAddlViewModel>k__BackingField;
			}
		}

		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x0600298E RID: 10638 RVA: 0x00082438 File Offset: 0x00080638
		// (set) Token: 0x0600298F RID: 10639 RVA: 0x0008244C File Offset: 0x0008064C
		public List<items_state> States
		{
			[CompilerGenerated]
			get
			{
				return this.<States>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<States>k__BackingField, value))
				{
					return;
				}
				this.<States>k__BackingField = value;
				this.RaisePropertyChanged("States");
			}
		}

		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x06002990 RID: 10640 RVA: 0x0008247C File Offset: 0x0008067C
		public List<store_cats> Categories
		{
			[CompilerGenerated]
			get
			{
				return this.<Categories>k__BackingField;
			}
		}

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x06002991 RID: 10641 RVA: 0x00082490 File Offset: 0x00080690
		public List<Warranty> WarrantyOptionses
		{
			[CompilerGenerated]
			get
			{
				return this.<WarrantyOptionses>k__BackingField;
			}
		}

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x06002992 RID: 10642 RVA: 0x000824A4 File Offset: 0x000806A4
		// (set) Token: 0x06002993 RID: 10643 RVA: 0x000824B8 File Offset: 0x000806B8
		public string Title
		{
			[CompilerGenerated]
			get
			{
				return this.<Title>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!string.Equals(this.<Title>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = 252088537;
				IL_14:
				switch ((num ^ 212435463) % 4)
				{
				case 0:
					goto IL_0F;
				case 1:
					IL_33:
					this.<Title>k__BackingField = value;
					this.RaisePropertyChanged("Title");
					num = 217135708;
					goto IL_14;
				case 2:
					return;
				}
			}
		}

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x06002994 RID: 10644 RVA: 0x00082514 File Offset: 0x00080714
		public stores Store
		{
			[CompilerGenerated]
			get
			{
				return this.<Store>k__BackingField;
			}
		}

		// Token: 0x06002995 RID: 10645 RVA: 0x00082528 File Offset: 0x00080728
		public NewProductViewModel()
		{
			this.ProductService = Bootstrapper.Container.Resolve<IProductService>();
			this.StoreService = Bootstrapper.Container.Resolve<IStoreService>();
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
			this.ProductAttributesViewModel = Bootstrapper.Container.Resolve<IProductAttributesViewModel>();
			this._originalItem = new Product();
			this.ImagesAddlViewModel = new ImagesAddlViewModel();
			ImagesAddlViewModel imagesAddlViewModel = this.ImagesAddlViewModel;
			imagesAddlViewModel.WorkingEventHandler = (EventHandler)Delegate.Combine(imagesAddlViewModel.WorkingEventHandler, new EventHandler(this.OnImagesWorking));
			this.Item = new Product();
			this.Units = this.StoreService.GetUnits();
			this.WarrantyOptionses = WarrantyOptions.GetAll();
			this.LoadItemStates();
		}

		// Token: 0x06002996 RID: 10646 RVA: 0x000825E8 File Offset: 0x000807E8
		public NewProductViewModel(stores store, List<store_cats> categories, ObservableCollection<boxes> boxes, int priceOption, Product item) : this()
		{
			this.Store = store;
			this.Categories = categories;
			this.Boxes = boxes;
			if (this.Boxes == null)
			{
				this.Boxes = new ObservableCollection<boxes>();
			}
			this.PriceOption = priceOption;
			this.SetItem(item);
		}

		// Token: 0x06002997 RID: 10647 RVA: 0x00082634 File Offset: 0x00080834
		private void SetItem(Product item)
		{
			this._originalItem = item;
			item.CopyProperties(this.Item);
			this.SetItemName(this.Item.Name);
			this.ImagesAddlViewModel.SetImages(item.ImageIds);
			if (string.IsNullOrEmpty(this.Item.Name) && !item.Attributes.Any<IAttribute>() && this.Item.CategoryId > 0)
			{
				this.ProductAttributesViewModel.LoadItemsByCategory(this.Item.CategoryId);
				return;
			}
			this.ProductAttributesViewModel.SetAttributes(item.Attributes);
		}

		// Token: 0x06002998 RID: 10648 RVA: 0x000826CC File Offset: 0x000808CC
		private void SetItemName(string value)
		{
			this.disallowItemNameDropdown = true;
			this.Name = value;
		}

		// Token: 0x06002999 RID: 10649 RVA: 0x000826E8 File Offset: 0x000808E8
		[Command]
		public void CategoryChanged()
		{
			this.ProductAttributesViewModel.LoadItemsByCategory(this.Item.CategoryId);
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x0008270C File Offset: 0x0008090C
		public bool CanCategoryChanged()
		{
			return this.Item != null;
		}

		// Token: 0x0600299B RID: 10651 RVA: 0x00082724 File Offset: 0x00080924
		private void LoadItemStates()
		{
			NewProductViewModel.<LoadItemStates>d__53 <LoadItemStates>d__;
			<LoadItemStates>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadItemStates>d__.<>4__this = this;
			<LoadItemStates>d__.<>1__state = -1;
			<LoadItemStates>d__.<>t__builder.Start<NewProductViewModel.<LoadItemStates>d__53>(ref <LoadItemStates>d__);
		}

		// Token: 0x0600299C RID: 10652 RVA: 0x0008275C File Offset: 0x0008095C
		[Command]
		public void SetPriceForAll()
		{
			this.Item.SetInPriceForAll();
		}

		// Token: 0x0600299D RID: 10653 RVA: 0x00082774 File Offset: 0x00080974
		public bool CanSetPriceForAll()
		{
			return this.CanSave() && this.Item.InCount > 0;
		}

		// Token: 0x0600299E RID: 10654 RVA: 0x0008279C File Offset: 0x0008099C
		[Command]
		public void CountChanged()
		{
			this.Item.CalcInSumm();
		}

		// Token: 0x0600299F RID: 10655 RVA: 0x000827B4 File Offset: 0x000809B4
		private void OnImagesWorking(object sender, EventArgs e)
		{
			ImagesAddlViewModel imagesAddlViewModel = sender as ImagesAddlViewModel;
			if (imagesAddlViewModel != null)
			{
				this._busy = imagesAddlViewModel.LoadingShown;
				base.RaiseCanExecuteChanged(() => this.AddNext());
				base.RaiseCanExecuteChanged(() => this.Save());
				base.RaiseCanExecuteChanged(() => this.NextItem());
				base.RaiseCanExecuteChanged(() => this.PrevItem());
			}
		}

		// Token: 0x060029A0 RID: 10656 RVA: 0x000828C8 File Offset: 0x00080AC8
		[Command]
		public void Save()
		{
			base.ShowWait();
			this.SaveToOriginal();
			for (;;)
			{
				ItemsArrivalViewModel parentViewModel = this._parentViewModel;
				if (parentViewModel != null)
				{
					parentViewModel.CountTotal();
					uint num;
					switch ((num = (num * 2440220950U ^ 740645367U ^ 2637599429U)) % 4U)
					{
					case 0U:
						goto IL_49;
					case 1U:
					case 3U:
						continue;
					}
					break;
				}
				goto IL_48;
			}
			goto IL_4F;
			IL_48:
			IL_49:
			base.HideWait();
			IL_4F:
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x060029A1 RID: 10657 RVA: 0x00082930 File Offset: 0x00080B30
		private void SaveToOriginal()
		{
			this.Item.SetImageIds(this.ImagesAddlViewModel.GetImageIds());
			this.Item.SetAttributes(this.ProductAttributesViewModel.Items);
			this.Item.CopyProperties(this._originalItem);
		}

		// Token: 0x060029A2 RID: 10658 RVA: 0x0008297C File Offset: 0x00080B7C
		public bool CanSave()
		{
			return this.Item != null && this.Item.Id == 0 && !this._busy;
		}

		// Token: 0x060029A3 RID: 10659 RVA: 0x000829AC File Offset: 0x00080BAC
		[Command]
		public void AddNext()
		{
			base.ShowWait();
			this.SaveToOriginal();
			this._parentViewModel.CountTotal();
			Product product = this._parentViewModel.AddNewItem();
			this.SetItem(product);
			this.SetTitle();
			this.ImagesAddlViewModel.SetImages(product.ImageIds);
			base.HideWait();
		}

		// Token: 0x060029A4 RID: 10660 RVA: 0x0008297C File Offset: 0x00080B7C
		public bool CanAddNext()
		{
			return this.Item != null && this.Item.Id == 0 && !this._busy;
		}

		// Token: 0x060029A5 RID: 10661 RVA: 0x00082A00 File Offset: 0x00080C00
		[Command]
		public void Close()
		{
			this.ImagesAddlViewModel.Dispose();
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x060029A6 RID: 10662 RVA: 0x00082A24 File Offset: 0x00080C24
		protected override void OnParentViewModelChanged(object obj)
		{
			base.OnParentViewModelChanged(obj);
			ItemsArrivalViewModel itemsArrivalViewModel = obj as ItemsArrivalViewModel;
			if (itemsArrivalViewModel != null)
			{
				this._parentViewModel = itemsArrivalViewModel;
				this.SetTitle();
			}
		}

		// Token: 0x060029A7 RID: 10663 RVA: 0x00082A50 File Offset: 0x00080C50
		private void SetTitle()
		{
			try
			{
				this.CurrentItemIndex = this._parentViewModel.Items.IndexOf(this._originalItem);
				this.Title = string.Format("{0} {1} из {2}", Lang.t("Row"), this.CurrentItemIndex + 1, this._parentViewModel.Items.Count);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x060029A8 RID: 10664 RVA: 0x00082ACC File Offset: 0x00080CCC
		// (set) Token: 0x060029A9 RID: 10665 RVA: 0x00082B10 File Offset: 0x00080D10
		public int CurrentItemIndex
		{
			get
			{
				return base.GetProperty<int>(() => this.CurrentItemIndex);
			}
			set
			{
				if (this.CurrentItemIndex != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -744835778;
				IL_10:
				switch ((num ^ -1203177955) % 4)
				{
				case 0:
					IL_2F:
					base.SetProperty<int>(() => this.CurrentItemIndex, value, new Action(this.OnItemIndexChanged));
					num = -1884995240;
					goto IL_10;
				case 2:
					goto IL_0B;
				case 3:
					return;
				}
				this.RaisePropertyChanged("CurrentItemIndex");
			}
		}

		// Token: 0x060029AA RID: 10666 RVA: 0x00082BA4 File Offset: 0x00080DA4
		private void OnItemIndexChanged()
		{
			base.RaiseCanExecuteChanged(() => this.PrevItem());
			base.RaiseCanExecuteChanged(() => this.NextItem());
		}

		// Token: 0x060029AB RID: 10667 RVA: 0x00082C28 File Offset: 0x00080E28
		[Command]
		public void PrevItem()
		{
			this.CurrentItemIndex--;
			this.SetItemOnIndex(this.CurrentItemIndex);
		}

		// Token: 0x060029AC RID: 10668 RVA: 0x00082C50 File Offset: 0x00080E50
		public bool CanPrevItem()
		{
			return this.CurrentItemIndex > 0 && !this._busy;
		}

		// Token: 0x060029AD RID: 10669 RVA: 0x00082C74 File Offset: 0x00080E74
		[Command]
		public void NextItem()
		{
			this.CurrentItemIndex++;
			this.SetItemOnIndex(this.CurrentItemIndex);
		}

		// Token: 0x060029AE RID: 10670 RVA: 0x00082C9C File Offset: 0x00080E9C
		public bool CanNextItem()
		{
			bool result;
			try
			{
				if (this.CurrentItemIndex < this._parentViewModel.Items.Count - 1)
				{
					goto IL_47;
				}
				bool flag = false;
				IL_26:
				result = flag;
				int num = -1579430755;
				IL_2C:
				switch ((num ^ -1015064494) % 3)
				{
				case 0:
					IL_47:
					num = -1187566135;
					goto IL_2C;
				case 1:
					flag = !this._busy;
					goto IL_26;
				}
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060029AF RID: 10671 RVA: 0x00082D10 File Offset: 0x00080F10
		private void SetItemOnIndex(int index)
		{
			this.SaveToOriginal();
			Product item = this._parentViewModel.Items.ElementAt(index);
			this.SetItem(item);
			this.SetTitle();
		}

		// Token: 0x060029B0 RID: 10672 RVA: 0x00082D44 File Offset: 0x00080F44
		private void Search(string query)
		{
			NewProductViewModel.<Search>d__77 <Search>d__;
			<Search>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Search>d__.<>4__this = this;
			<Search>d__.query = query;
			<Search>d__.<>1__state = -1;
			<Search>d__.<>t__builder.Start<NewProductViewModel.<Search>d__77>(ref <Search>d__);
		}

		// Token: 0x060029B1 RID: 10673 RVA: 0x00082D84 File Offset: 0x00080F84
		[Command]
		public void NewBoxInput(object obj)
		{
			ProcessNewValueEventArgs processNewValueEventArgs = obj as ProcessNewValueEventArgs;
			if (processNewValueEventArgs == null)
			{
				return;
			}
			this.Boxes.Add(new boxes
			{
				id = 0,
				name = processNewValueEventArgs.DisplayText
			});
		}

		// Token: 0x060029B2 RID: 10674 RVA: 0x00082DC0 File Offset: 0x00080FC0
		[Command]
		public void CloseOnEscape(KeyEventArgs e)
		{
			if (e.Key == Key.Escape)
			{
				this.Close();
			}
		}

		// Token: 0x060029B3 RID: 10675 RVA: 0x00082DE0 File Offset: 0x00080FE0
		[Command]
		public void ItemNameSearchChanged(EditValueChangedEventArgs args)
		{
			NewProductViewModel.<ItemNameSearchChanged>d__80 <ItemNameSearchChanged>d__;
			<ItemNameSearchChanged>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<ItemNameSearchChanged>d__.<>4__this = this;
			<ItemNameSearchChanged>d__.args = args;
			<ItemNameSearchChanged>d__.<>1__state = -1;
			<ItemNameSearchChanged>d__.<>t__builder.Start<NewProductViewModel.<ItemNameSearchChanged>d__80>(ref <ItemNameSearchChanged>d__);
		}

		// Token: 0x060029B4 RID: 10676 RVA: 0x00082E20 File Offset: 0x00081020
		private void SetProductData(Product p)
		{
			this.Item.Description = p.Description;
			this.Item.Articul = p.Articul;
			this.Item.CategoryId = p.CategoryId;
			this.Item.State = p.State;
			this.Item.Pn = p.Pn;
			this.Item.Units = p.Units;
			this.Item.Warranty = p.Warranty;
			this.Item.DealerWarranty = p.DealerWarranty;
			this.Item.Price = p.Price;
			this.Item.Price2 = p.Price2;
			this.Item.Price3 = p.Price3;
			this.Item.Price4 = p.Price4;
			this.Item.Price5 = p.Price5;
			this.Item.ShopTitle = p.ShopTitle;
			this.Item.ShopDescription = p.ShopDescription;
		}

		// Token: 0x060029B5 RID: 10677 RVA: 0x00082F2C File Offset: 0x0008112C
		public bool CanItemNameSearchChanged(EditValueChangedEventArgs args)
		{
			return args != null;
		}

		// Token: 0x060029B6 RID: 10678 RVA: 0x00082F40 File Offset: 0x00081140
		[Command]
		public void ClearItem()
		{
			this.SetItemName("");
			if (this.Item.Articul > 0)
			{
				Product product = new Product();
				this.SetProductData(product);
				this.Item.SetImageIds(product.ImageIds);
				this.ImagesAddlViewModel.SetImages(this.Item.ImageIds);
			}
			ObservableCollection<Product> items = base.Items;
			if (items != null)
			{
				items.Clear();
				return;
			}
		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x00082FAC File Offset: 0x000811AC
		[Command]
		public void LookUpEditLoaded(LookUpEdit control)
		{
			this._lookUpEdit = control;
		}

		// Token: 0x060029B8 RID: 10680 RVA: 0x00082FC0 File Offset: 0x000811C0
		[Command]
		public void ToggleItemNamePopup()
		{
			if (this._lookUpEdit.IsPopupOpen)
			{
				this.CloseItemNamePopup();
				return;
			}
			this._lookUpEdit.ShowPopup();
		}

		// Token: 0x060029B9 RID: 10681 RVA: 0x00082FEC File Offset: 0x000811EC
		public bool CanToggleItemNamePopup()
		{
			return this._lookUpEdit != null;
		}

		// Token: 0x060029BA RID: 10682 RVA: 0x00083004 File Offset: 0x00081204
		private void ShowItemNamePopup()
		{
			this._lookUpEdit.ShowPopup();
		}

		// Token: 0x060029BB RID: 10683 RVA: 0x0008301C File Offset: 0x0008121C
		private void CloseItemNamePopup()
		{
			this._lookUpEdit.ClosePopup();
		}

		// Token: 0x060029BC RID: 10684 RVA: 0x00083034 File Offset: 0x00081234
		[CompilerGenerated]
		private Task<List<items_state>> <LoadItemStates>b__53_0()
		{
			return this.StoreService.GetProductStatesAsync();
		}

		// Token: 0x04001701 RID: 5889
		protected IProductService ProductService;

		// Token: 0x04001702 RID: 5890
		protected IStoreService StoreService;

		// Token: 0x04001703 RID: 5891
		[CompilerGenerated]
		private readonly IProductAttributesViewModel <ProductAttributesViewModel>k__BackingField;

		// Token: 0x04001704 RID: 5892
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04001705 RID: 5893
		private ItemsArrivalViewModel _parentViewModel;

		// Token: 0x04001706 RID: 5894
		[CompilerGenerated]
		private readonly ObservableCollection<boxes> <Boxes>k__BackingField;

		// Token: 0x04001707 RID: 5895
		[CompilerGenerated]
		private readonly List<ItemUnits> <Units>k__BackingField;

		// Token: 0x04001708 RID: 5896
		[CompilerGenerated]
		private Product <Item>k__BackingField;

		// Token: 0x04001709 RID: 5897
		private Product _originalItem;

		// Token: 0x0400170A RID: 5898
		[CompilerGenerated]
		private int <PriceOption>k__BackingField;

		// Token: 0x0400170B RID: 5899
		[CompilerGenerated]
		private readonly ImagesAddlViewModel <ImagesAddlViewModel>k__BackingField;

		// Token: 0x0400170C RID: 5900
		[CompilerGenerated]
		private List<items_state> <States>k__BackingField;

		// Token: 0x0400170D RID: 5901
		[CompilerGenerated]
		private readonly List<store_cats> <Categories>k__BackingField;

		// Token: 0x0400170E RID: 5902
		[CompilerGenerated]
		private readonly List<Warranty> <WarrantyOptionses>k__BackingField;

		// Token: 0x0400170F RID: 5903
		[CompilerGenerated]
		private string <Title>k__BackingField;

		// Token: 0x04001710 RID: 5904
		[CompilerGenerated]
		private readonly stores <Store>k__BackingField;

		// Token: 0x04001711 RID: 5905
		private bool _busy;

		// Token: 0x04001712 RID: 5906
		private string _query;

		// Token: 0x04001713 RID: 5907
		private bool disallowItemNameDropdown;

		// Token: 0x04001714 RID: 5908
		private LookUpEdit _lookUpEdit;

		// Token: 0x02000407 RID: 1031
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadItemStates>d__53 : IAsyncStateMachine
		{
			// Token: 0x060029BD RID: 10685 RVA: 0x0008304C File Offset: 0x0008124C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NewProductViewModel newProductViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<items_state>> awaiter;
					if (num != 0)
					{
						awaiter = Task.Run<List<items_state>>(() => newProductViewModel.StoreService.GetProductStatesAsync()).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<items_state>>, NewProductViewModel.<LoadItemStates>d__53>(ref awaiter, ref this);
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
					newProductViewModel.States = result;
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

			// Token: 0x060029BE RID: 10686 RVA: 0x00083114 File Offset: 0x00081314
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001715 RID: 5909
			public int <>1__state;

			// Token: 0x04001716 RID: 5910
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001717 RID: 5911
			public NewProductViewModel <>4__this;

			// Token: 0x04001718 RID: 5912
			private TaskAwaiter<List<items_state>> <>u__1;
		}

		// Token: 0x02000408 RID: 1032
		[CompilerGenerated]
		private sealed class <>c__DisplayClass77_0
		{
			// Token: 0x060029BF RID: 10687 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass77_0()
			{
			}

			// Token: 0x060029C0 RID: 10688 RVA: 0x00083130 File Offset: 0x00081330
			internal Task<IEnumerable<Product>> <Search>b__0()
			{
				return this.<>4__this.StoreService.GetProductsAsync(this.<>4__this.Item.CategoryId, this.query);
			}

			// Token: 0x04001719 RID: 5913
			public NewProductViewModel <>4__this;

			// Token: 0x0400171A RID: 5914
			public string query;
		}

		// Token: 0x02000409 RID: 1033
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Search>d__77 : IAsyncStateMachine
		{
			// Token: 0x060029C1 RID: 10689 RVA: 0x00083164 File Offset: 0x00081364
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NewProductViewModel newProductViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						this.<>8__1 = new NewProductViewModel.<>c__DisplayClass77_0();
						this.<>8__1.<>4__this = this.<>4__this;
						this.<>8__1.query = this.query;
						if (newProductViewModel._query == this.<>8__1.query && string.IsNullOrEmpty(this.<>8__1.query))
						{
							newProductViewModel.Items.Clear();
							goto IL_156;
						}
					}
					try
					{
						TaskAwaiter<IEnumerable<Product>> awaiter;
						if (num != 0)
						{
							awaiter = Task.Run<IEnumerable<Product>>(new Func<Task<IEnumerable<Product>>>(this.<>8__1.<Search>b__0)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<Product>>, NewProductViewModel.<Search>d__77>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IEnumerable<Product>>);
							this.<>1__state = -1;
						}
						IEnumerable<Product> result = awaiter.GetResult();
						if (this.<>8__1.query == newProductViewModel._query)
						{
							newProductViewModel.SetItems(result);
							if (newProductViewModel.Items.Any<Product>() && newProductViewModel.CanToggleItemNamePopup() && !newProductViewModel._lookUpEdit.IsPopupOpen)
							{
								newProductViewModel.ShowItemNamePopup();
							}
						}
					}
					catch (Exception)
					{
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_156:
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060029C2 RID: 10690 RVA: 0x00083318 File Offset: 0x00081518
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400171B RID: 5915
			public int <>1__state;

			// Token: 0x0400171C RID: 5916
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400171D RID: 5917
			public NewProductViewModel <>4__this;

			// Token: 0x0400171E RID: 5918
			public string query;

			// Token: 0x0400171F RID: 5919
			private NewProductViewModel.<>c__DisplayClass77_0 <>8__1;

			// Token: 0x04001720 RID: 5920
			private TaskAwaiter<IEnumerable<Product>> <>u__1;
		}

		// Token: 0x0200040A RID: 1034
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ItemNameSearchChanged>d__80 : IAsyncStateMachine
		{
			// Token: 0x060029C3 RID: 10691 RVA: 0x00083334 File Offset: 0x00081534
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NewProductViewModel newProductViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<int>> awaiter;
					if (num != 0)
					{
						Product product = this.args.NewValue as Product;
						if (product == null)
						{
							goto IL_E6;
						}
						newProductViewModel.SetItemName(product.Name);
						newProductViewModel.SetProductData(product);
						if (product.Id <= 0)
						{
							goto IL_D0;
						}
						this.<>7__wrap1 = newProductViewModel.Item;
						awaiter = newProductViewModel.ProductService.GetImageIds(product.Id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<int>>, NewProductViewModel.<ItemNameSearchChanged>d__80>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<int>>);
						this.<>1__state = -1;
					}
					IEnumerable<int> result = awaiter.GetResult();
					this.<>7__wrap1.SetImageIds(result);
					this.<>7__wrap1 = null;
					IL_D0:
					newProductViewModel.ImagesAddlViewModel.SetImages(newProductViewModel.Item.ImageIds);
					IL_E6:;
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

			// Token: 0x060029C4 RID: 10692 RVA: 0x00083468 File Offset: 0x00081668
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001721 RID: 5921
			public int <>1__state;

			// Token: 0x04001722 RID: 5922
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001723 RID: 5923
			public EditValueChangedEventArgs args;

			// Token: 0x04001724 RID: 5924
			public NewProductViewModel <>4__this;

			// Token: 0x04001725 RID: 5925
			private Product <>7__wrap1;

			// Token: 0x04001726 RID: 5926
			private TaskAwaiter<IEnumerable<int>> <>u__1;
		}
	}
}
