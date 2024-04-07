using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using ASC.Options;
using ASC.Services.Abstract;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Xpf.WindowsUI.Navigation;

namespace ASC.ViewModels.ItemCard
{
	// Token: 0x020004BF RID: 1215
	public class ProductEditViewModel : BaseViewModel, INavigationAware, IIsDataLoading, ICustomerSelect
	{
		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x06002EF1 RID: 12017 RVA: 0x000999B8 File Offset: 0x00097BB8
		// (set) Token: 0x06002EF2 RID: 12018 RVA: 0x000999CC File Offset: 0x00097BCC
		public store_items Item
		{
			[CompilerGenerated]
			get
			{
				return this.<Item>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Item>k__BackingField, value))
				{
					return;
				}
				this.<Item>k__BackingField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x06002EF3 RID: 12019 RVA: 0x000999FC File Offset: 0x00097BFC
		public bool CanQuantityEdit
		{
			get
			{
				return OfflineData.Instance.Employee.Login == "admin";
			}
		}

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x06002EF4 RID: 12020 RVA: 0x00099A24 File Offset: 0x00097C24
		// (set) Token: 0x06002EF5 RID: 12021 RVA: 0x00099A38 File Offset: 0x00097C38
		public decimal InPriceAdmin
		{
			[CompilerGenerated]
			get
			{
				return this.<InPriceAdmin>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<InPriceAdmin>k__BackingField, value))
				{
					return;
				}
				this.<InPriceAdmin>k__BackingField = value;
				this.RaisePropertyChanged("InPriceAdmin");
			}
		}

		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x06002EF6 RID: 12022 RVA: 0x00099A68 File Offset: 0x00097C68
		// (set) Token: 0x06002EF7 RID: 12023 RVA: 0x00099A7C File Offset: 0x00097C7C
		public List<int> Articuls
		{
			[CompilerGenerated]
			get
			{
				return this.<Articuls>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Articuls>k__BackingField, value))
				{
					return;
				}
				this.<Articuls>k__BackingField = value;
				this.RaisePropertyChanged("Articuls");
			}
		}

		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x06002EF8 RID: 12024 RVA: 0x00099AAC File Offset: 0x00097CAC
		// (set) Token: 0x06002EF9 RID: 12025 RVA: 0x00099AC0 File Offset: 0x00097CC0
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
				if (object.Equals(this.<StoreCategories>k__BackingField, value))
				{
					return;
				}
				this.<StoreCategories>k__BackingField = value;
				this.RaisePropertyChanged("StoreCategories");
			}
		}

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x06002EFA RID: 12026 RVA: 0x00099AF0 File Offset: 0x00097CF0
		// (set) Token: 0x06002EFB RID: 12027 RVA: 0x00099B04 File Offset: 0x00097D04
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

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x06002EFC RID: 12028 RVA: 0x00099B34 File Offset: 0x00097D34
		// (set) Token: 0x06002EFD RID: 12029 RVA: 0x00099B48 File Offset: 0x00097D48
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

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x06002EFE RID: 12030 RVA: 0x00099B78 File Offset: 0x00097D78
		// (set) Token: 0x06002EFF RID: 12031 RVA: 0x00099B8C File Offset: 0x00097D8C
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

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x06002F00 RID: 12032 RVA: 0x00099BBC File Offset: 0x00097DBC
		// (set) Token: 0x06002F01 RID: 12033 RVA: 0x00099BD0 File Offset: 0x00097DD0
		public IProductAttributesViewModel ProductAttributesVM
		{
			[CompilerGenerated]
			get
			{
				return this.<ProductAttributesVM>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ProductAttributesVM>k__BackingField, value))
				{
					return;
				}
				this.<ProductAttributesVM>k__BackingField = value;
				this.RaisePropertyChanged("ProductAttributesVM");
			}
		}

		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x06002F02 RID: 12034 RVA: 0x00099C00 File Offset: 0x00097E00
		// (set) Token: 0x06002F03 RID: 12035 RVA: 0x00099C14 File Offset: 0x00097E14
		public ICustomer Dealer
		{
			[CompilerGenerated]
			get
			{
				return this.<Dealer>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(this.<Dealer>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1928174510;
				IL_13:
				switch ((num ^ -650336741) % 4)
				{
				case 1:
					return;
				case 2:
					IL_32:
					num = -605468861;
					goto IL_13;
				case 3:
					goto IL_0E;
				}
				this.<Dealer>k__BackingField = value;
				this.RaisePropertyChanged("Dealer");
			}
		}

		// Token: 0x17000ECB RID: 3787
		// (get) Token: 0x06002F04 RID: 12036 RVA: 0x000977AC File Offset: 0x000959AC
		public bool CanEdit
		{
			get
			{
				return OfflineData.Instance.Employee.Can(21, 0);
			}
		}

		// Token: 0x17000ECC RID: 3788
		// (get) Token: 0x06002F05 RID: 12037 RVA: 0x00099C70 File Offset: 0x00097E70
		// (set) Token: 0x06002F06 RID: 12038 RVA: 0x00099C84 File Offset: 0x00097E84
		public ImagesAddlViewModel ImagesAddlViewModel
		{
			[CompilerGenerated]
			get
			{
				return this.<ImagesAddlViewModel>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<ImagesAddlViewModel>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1365191193;
				IL_13:
				switch ((num ^ 1108955384) % 4)
				{
				case 0:
					IL_32:
					this.<ImagesAddlViewModel>k__BackingField = value;
					this.RaisePropertyChanged("ImagesAddlViewModel");
					num = 1962879854;
					goto IL_13;
				case 1:
					return;
				case 3:
					goto IL_0E;
				}
			}
		}

		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x06002F07 RID: 12039 RVA: 0x00099CE0 File Offset: 0x00097EE0
		// (set) Token: 0x06002F08 RID: 12040 RVA: 0x00099CF4 File Offset: 0x00097EF4
		public List<items_state> States
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

		// Token: 0x06002F09 RID: 12041 RVA: 0x00099D24 File Offset: 0x00097F24
		public ProductEditViewModel(IProductService productService, IStoreService storeService, IProductAttributesViewModel productAttributesViewModel, ICustomerService customerService, INavigationService navigationService, IToasterService toasterService, IAscMessageBoxService ascMessageBoxService, IWindowedDocumentService windowedDocumentService)
		{
			this.ProductService = productService;
			this.StoreService = storeService;
			this._customerService = customerService;
			this._navigationService = navigationService;
			this._toasterService = toasterService;
			this._ascMessageBoxService = ascMessageBoxService;
			this._windowedDocumentService = windowedDocumentService;
			this.ProductAttributesVM = productAttributesViewModel;
			this.ProductAttributesVM.SetParentViewModel(this);
			this.WarrantyOptionses = WarrantyOptions.GetAll();
			this.Units = this.StoreService.GetUnits();
		}

		// Token: 0x06002F0A RID: 12042 RVA: 0x00099DA0 File Offset: 0x00097FA0
		protected virtual void LoadData()
		{
			ProductEditViewModel.<LoadData>d__57 <LoadData>d__;
			<LoadData>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadData>d__.<>4__this = this;
			<LoadData>d__.<>1__state = -1;
			<LoadData>d__.<>t__builder.Start<ProductEditViewModel.<LoadData>d__57>(ref <LoadData>d__);
		}

		// Token: 0x06002F0B RID: 12043 RVA: 0x00099DD8 File Offset: 0x00097FD8
		private Task LoadBoxes()
		{
			ProductEditViewModel.<LoadBoxes>d__58 <LoadBoxes>d__;
			<LoadBoxes>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadBoxes>d__.<>4__this = this;
			<LoadBoxes>d__.<>1__state = -1;
			<LoadBoxes>d__.<>t__builder.Start<ProductEditViewModel.<LoadBoxes>d__58>(ref <LoadBoxes>d__);
			return <LoadBoxes>d__.<>t__builder.Task;
		}

		// Token: 0x06002F0C RID: 12044 RVA: 0x00099E1C File Offset: 0x0009801C
		[Command]
		public void ShowCreateBox()
		{
			CreateBoxViewModel createBoxViewModel = new CreateBoxViewModel();
			createBoxViewModel.SetStore(this.Item.store);
			this._windowedDocumentService.ShowNewDocument("CreateBoxView", createBoxViewModel, null, null);
		}

		// Token: 0x06002F0D RID: 12045 RVA: 0x00099E54 File Offset: 0x00098054
		public bool CanShowCreateBox()
		{
			return this.Item != null;
		}

		// Token: 0x06002F0E RID: 12046 RVA: 0x00099E6C File Offset: 0x0009806C
		public void SetBox(IBox box)
		{
			ProductEditViewModel.<SetBox>d__61 <SetBox>d__;
			<SetBox>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SetBox>d__.<>4__this = this;
			<SetBox>d__.box = box;
			<SetBox>d__.<>1__state = -1;
			<SetBox>d__.<>t__builder.Start<ProductEditViewModel.<SetBox>d__61>(ref <SetBox>d__);
		}

		// Token: 0x06002F0F RID: 12047 RVA: 0x00099EAC File Offset: 0x000980AC
		public void UpdateProduct()
		{
			ProductEditViewModel.<UpdateProduct>d__62 <UpdateProduct>d__;
			<UpdateProduct>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<UpdateProduct>d__.<>4__this = this;
			<UpdateProduct>d__.<>1__state = -1;
			<UpdateProduct>d__.<>t__builder.Start<ProductEditViewModel.<UpdateProduct>d__62>(ref <UpdateProduct>d__);
		}

		// Token: 0x06002F10 RID: 12048 RVA: 0x00099EE4 File Offset: 0x000980E4
		private bool CheckFields()
		{
			if (this.Item.is_realization && this.Item.in_price != 0m && this.IsOutLessInPrice())
			{
				this._toasterService.Info(Lang.t("RealizationOutLessIn"));
				return false;
			}
			if (this.IsOutLessInPrice())
			{
				if (this._ascMessageBoxService.ShowMessageBox(Lang.t("OutLessIn"), Lang.t("Price"), MessageBoxButton.YesNo, MessageBoxImage.Exclamation) != MessageBoxResult.Yes)
				{
					return false;
				}
				HistoryV2 historyV = new HistoryV2();
				historyV.AddItemLog("PriceLessIn", this.Item.id, null, null);
				historyV.Save();
			}
			return true;
		}

		// Token: 0x06002F11 RID: 12049 RVA: 0x00099F88 File Offset: 0x00098188
		private void SaveOriginalPrices()
		{
			this.price1 = this.Item.price;
			this.price2 = this.Item.price2;
			this.price3 = this.Item.price3;
			this.price4 = this.Item.price4;
			this.price5 = this.Item.price5;
		}

		// Token: 0x06002F12 RID: 12050 RVA: 0x00099FEC File Offset: 0x000981EC
		private bool IsOutLessInPrice()
		{
			decimal in_price = this.Item.in_price;
			bool flag = !this.Item.not_for_sale;
			return (this.price1 != this.Item.price && flag && Auth.Config.it_vis_price_for_sc && this.Item.price < in_price) || (this.price2 != this.Item.price2 && flag && Auth.Config.it_vis_rozn && this.Item.price2 < in_price) || (this.price3 != this.Item.price3 && flag && Auth.Config.it_vis_opt && this.Item.price3 < in_price) || (this.price4 != this.Item.price4 && flag && Auth.Config.it_vis_opt2 && this.Item.price4 < in_price) || (this.price5 != this.Item.price5 && flag && Auth.Config.it_vis_opt3 && this.Item.price5 < in_price);
		}

		// Token: 0x06002F13 RID: 12051 RVA: 0x0009A13C File Offset: 0x0009833C
		[Command]
		public void DealerChange()
		{
			this._navigationService.Navigate("ClientsView", new ClientsViewModel("selectDealer"), this);
		}

		// Token: 0x06002F14 RID: 12052 RVA: 0x0001D588 File Offset: 0x0001B788
		public bool CanDealerChange()
		{
			return OfflineData.Instance.Employee.Can(7, 0);
		}

		// Token: 0x06002F15 RID: 12053 RVA: 0x0009A164 File Offset: 0x00098364
		public void SelectCustomerFromList(ICustomer customer)
		{
			if (customer != null && this.Item.dealer != customer.Id)
			{
				this.Item.dealer = customer.Id;
				this.UpdateProduct();
				return;
			}
		}

		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x06002F16 RID: 12054 RVA: 0x0009A1A0 File Offset: 0x000983A0
		// (set) Token: 0x06002F17 RID: 12055 RVA: 0x0009A1B4 File Offset: 0x000983B4
		public bool IsLoadingData
		{
			[CompilerGenerated]
			get
			{
				return this.<IsLoadingData>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<IsLoadingData>k__BackingField == value)
				{
					return;
				}
				this.<IsLoadingData>k__BackingField = value;
				this.RaisePropertyChanged("IsLoadingData");
			}
		}

		// Token: 0x06002F18 RID: 12056 RVA: 0x0009A1E0 File Offset: 0x000983E0
		public void SetIsDataLoading(bool value)
		{
			this.IsLoadingData = value;
		}

		// Token: 0x06002F19 RID: 12057 RVA: 0x0009A1F4 File Offset: 0x000983F4
		public void NavigatedTo(NavigationEventArgs e)
		{
			this.ProductId = (int)e.Parameter;
			this.ImagesAddlViewModel = new ImagesAddlViewModel(this.ProductId);
			this.LoadData();
		}

		// Token: 0x06002F1A RID: 12058 RVA: 0x00023150 File Offset: 0x00021350
		public void NavigatingFrom(NavigatingEventArgs e)
		{
		}

		// Token: 0x06002F1B RID: 12059 RVA: 0x00023150 File Offset: 0x00021350
		public void NavigatedFrom(NavigationEventArgs e)
		{
		}

		// Token: 0x06002F1C RID: 12060 RVA: 0x0009A22C File Offset: 0x0009842C
		protected override void OnParentViewModelChanged(object obj)
		{
			ItemCardViewModel itemCardViewModel = obj as ItemCardViewModel;
			if (itemCardViewModel != null)
			{
				itemCardViewModel.RefProductEditViewModel(this);
			}
		}

		// Token: 0x06002F1D RID: 12061 RVA: 0x0009A24C File Offset: 0x0009844C
		[CompilerGenerated]
		private Task<store_items> <LoadData>b__57_0()
		{
			return this.StoreService.GetProduct(this.ProductId);
		}

		// Token: 0x06002F1E RID: 12062 RVA: 0x0009A26C File Offset: 0x0009846C
		[CompilerGenerated]
		private Task<ICustomer> <LoadData>b__57_1()
		{
			return this._customerService.GetCustomerCardAsync(this.Item.dealer);
		}

		// Token: 0x06002F1F RID: 12063 RVA: 0x0009A290 File Offset: 0x00098490
		[CompilerGenerated]
		private Task<List<store_cats>> <LoadData>b__57_2()
		{
			return this.StoreService.GetCategoriesAsync(this.Item.store);
		}

		// Token: 0x04001A79 RID: 6777
		protected int ProductId;

		// Token: 0x04001A7A RID: 6778
		protected IProductService ProductService;

		// Token: 0x04001A7B RID: 6779
		protected IStoreService StoreService;

		// Token: 0x04001A7C RID: 6780
		protected ICustomerService _customerService;

		// Token: 0x04001A7D RID: 6781
		private readonly IAscMessageBoxService _ascMessageBoxService;

		// Token: 0x04001A7E RID: 6782
		private readonly INavigationService _navigationService;

		// Token: 0x04001A7F RID: 6783
		private readonly IToasterService _toasterService;

		// Token: 0x04001A80 RID: 6784
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04001A81 RID: 6785
		[CompilerGenerated]
		private store_items <Item>k__BackingField;

		// Token: 0x04001A82 RID: 6786
		[CompilerGenerated]
		private decimal <InPriceAdmin>k__BackingField;

		// Token: 0x04001A83 RID: 6787
		[CompilerGenerated]
		private List<int> <Articuls>k__BackingField;

		// Token: 0x04001A84 RID: 6788
		[CompilerGenerated]
		private List<store_cats> <StoreCategories>k__BackingField;

		// Token: 0x04001A85 RID: 6789
		[CompilerGenerated]
		private List<ItemUnits> <Units>k__BackingField;

		// Token: 0x04001A86 RID: 6790
		[CompilerGenerated]
		private List<Warranty> <WarrantyOptionses>k__BackingField;

		// Token: 0x04001A87 RID: 6791
		[CompilerGenerated]
		private List<boxes> <Boxes>k__BackingField;

		// Token: 0x04001A88 RID: 6792
		[CompilerGenerated]
		private IProductAttributesViewModel <ProductAttributesVM>k__BackingField;

		// Token: 0x04001A89 RID: 6793
		[CompilerGenerated]
		private ICustomer <Dealer>k__BackingField;

		// Token: 0x04001A8A RID: 6794
		[CompilerGenerated]
		private ImagesAddlViewModel <ImagesAddlViewModel>k__BackingField;

		// Token: 0x04001A8B RID: 6795
		[CompilerGenerated]
		private List<items_state> <States>k__BackingField;

		// Token: 0x04001A8C RID: 6796
		private decimal price1;

		// Token: 0x04001A8D RID: 6797
		private decimal price2;

		// Token: 0x04001A8E RID: 6798
		private decimal price3;

		// Token: 0x04001A8F RID: 6799
		private decimal price4;

		// Token: 0x04001A90 RID: 6800
		private decimal price5;

		// Token: 0x04001A91 RID: 6801
		[CompilerGenerated]
		private bool <IsLoadingData>k__BackingField;

		// Token: 0x020004C0 RID: 1216
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadData>d__57 : IAsyncStateMachine
		{
			// Token: 0x06002F20 RID: 12064 RVA: 0x0009A2B4 File Offset: 0x000984B4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ProductEditViewModel productEditViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<items_state>> awaiter;
					TaskAwaiter<store_items> awaiter2;
					TaskAwaiter<ICustomer> awaiter3;
					TaskAwaiter<List<store_cats>> awaiter4;
					TaskAwaiter awaiter5;
					TaskAwaiter<List<int>> awaiter6;
					TaskAwaiter<IEnumerable<images>> awaiter7;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<items_state>>);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<store_items>);
						this.<>1__state = -1;
						goto IL_104;
					case 2:
						awaiter3 = this.<>u__3;
						this.<>u__3 = default(TaskAwaiter<ICustomer>);
						this.<>1__state = -1;
						goto IL_177;
					case 3:
						awaiter4 = this.<>u__4;
						this.<>u__4 = default(TaskAwaiter<List<store_cats>>);
						this.<>1__state = -1;
						goto IL_1EA;
					case 4:
						awaiter5 = this.<>u__5;
						this.<>u__5 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_252;
					case 5:
						awaiter6 = this.<>u__6;
						this.<>u__6 = default(TaskAwaiter<List<int>>);
						this.<>1__state = -1;
						goto IL_2DA;
					case 6:
						awaiter7 = this.<>u__7;
						this.<>u__7 = default(TaskAwaiter<IEnumerable<images>>);
						this.<>1__state = -1;
						goto IL_361;
					default:
						productEditViewModel.SetIsDataLoading(true);
						awaiter = productEditViewModel.StoreService.GetProductStatesAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<items_state>>, ProductEditViewModel.<LoadData>d__57>(ref awaiter, ref this);
							return;
						}
						break;
					}
					List<items_state> result = awaiter.GetResult();
					productEditViewModel.States = result;
					awaiter2 = Task.Run<store_items>(() => productEditViewModel.StoreService.GetProduct(productEditViewModel.ProductId)).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<store_items>, ProductEditViewModel.<LoadData>d__57>(ref awaiter2, ref this);
						return;
					}
					IL_104:
					store_items result2 = awaiter2.GetResult();
					productEditViewModel.Item = result2;
					awaiter3 = Task.Run<ICustomer>(() => productEditViewModel._customerService.GetCustomerCardAsync(base.Item.dealer)).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__3 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ICustomer>, ProductEditViewModel.<LoadData>d__57>(ref awaiter3, ref this);
						return;
					}
					IL_177:
					ICustomer result3 = awaiter3.GetResult();
					productEditViewModel.Dealer = result3;
					awaiter4 = Task.Run<List<store_cats>>(() => productEditViewModel.StoreService.GetCategoriesAsync(base.Item.store)).GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__4 = awaiter4;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_cats>>, ProductEditViewModel.<LoadData>d__57>(ref awaiter4, ref this);
						return;
					}
					IL_1EA:
					List<store_cats> result4 = awaiter4.GetResult();
					productEditViewModel.StoreCategories = result4;
					awaiter5 = productEditViewModel.LoadBoxes().GetAwaiter();
					if (!awaiter5.IsCompleted)
					{
						this.<>1__state = 4;
						this.<>u__5 = awaiter5;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ProductEditViewModel.<LoadData>d__57>(ref awaiter5, ref this);
						return;
					}
					IL_252:
					awaiter5.GetResult();
					if (productEditViewModel.CanQuantityEdit)
					{
						productEditViewModel.InPriceAdmin = productEditViewModel.Item.in_price;
					}
					productEditViewModel.SaveOriginalPrices();
					awaiter6 = Task.Run<List<int>>(new Func<Task<List<int>>>(StoreModel.GetArticuls)).GetAwaiter();
					if (!awaiter6.IsCompleted)
					{
						this.<>1__state = 5;
						this.<>u__6 = awaiter6;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<int>>, ProductEditViewModel.<LoadData>d__57>(ref awaiter6, ref this);
						return;
					}
					IL_2DA:
					List<int> result5 = awaiter6.GetResult();
					productEditViewModel.Articuls = result5;
					productEditViewModel.ProductAttributesVM.LoadItems(productEditViewModel.ProductId, false);
					awaiter7 = productEditViewModel.ProductService.GetImages(productEditViewModel.Item.id).GetAwaiter();
					if (!awaiter7.IsCompleted)
					{
						this.<>1__state = 6;
						this.<>u__7 = awaiter7;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<images>>, ProductEditViewModel.<LoadData>d__57>(ref awaiter7, ref this);
						return;
					}
					IL_361:
					IEnumerable<images> result6 = awaiter7.GetResult();
					productEditViewModel.ImagesAddlViewModel.SetImages(result6);
					productEditViewModel.SetIsDataLoading(false);
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

			// Token: 0x06002F21 RID: 12065 RVA: 0x0009A688 File Offset: 0x00098888
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001A92 RID: 6802
			public int <>1__state;

			// Token: 0x04001A93 RID: 6803
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001A94 RID: 6804
			public ProductEditViewModel <>4__this;

			// Token: 0x04001A95 RID: 6805
			private TaskAwaiter<List<items_state>> <>u__1;

			// Token: 0x04001A96 RID: 6806
			private TaskAwaiter<store_items> <>u__2;

			// Token: 0x04001A97 RID: 6807
			private TaskAwaiter<ICustomer> <>u__3;

			// Token: 0x04001A98 RID: 6808
			private TaskAwaiter<List<store_cats>> <>u__4;

			// Token: 0x04001A99 RID: 6809
			private TaskAwaiter <>u__5;

			// Token: 0x04001A9A RID: 6810
			private TaskAwaiter<List<int>> <>u__6;

			// Token: 0x04001A9B RID: 6811
			private TaskAwaiter<IEnumerable<images>> <>u__7;
		}

		// Token: 0x020004C1 RID: 1217
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadBoxes>d__58 : IAsyncStateMachine
		{
			// Token: 0x06002F22 RID: 12066 RVA: 0x0009A6A4 File Offset: 0x000988A4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ProductEditViewModel productEditViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<boxes>> awaiter;
					if (num != 0)
					{
						awaiter = productEditViewModel.StoreService.GetBoxesAsync(productEditViewModel.Item.store).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<boxes>>, ProductEditViewModel.<LoadBoxes>d__58>(ref awaiter, ref this);
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
					productEditViewModel.Boxes = result;
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

			// Token: 0x06002F23 RID: 12067 RVA: 0x0009A770 File Offset: 0x00098970
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001A9C RID: 6812
			public int <>1__state;

			// Token: 0x04001A9D RID: 6813
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001A9E RID: 6814
			public ProductEditViewModel <>4__this;

			// Token: 0x04001A9F RID: 6815
			private TaskAwaiter<List<boxes>> <>u__1;
		}

		// Token: 0x020004C2 RID: 1218
		[CompilerGenerated]
		private sealed class <>c__DisplayClass61_0
		{
			// Token: 0x06002F24 RID: 12068 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass61_0()
			{
			}

			// Token: 0x06002F25 RID: 12069 RVA: 0x0009A78C File Offset: 0x0009898C
			internal void <SetBox>b__0()
			{
				this.<>4__this.Item.box = new int?(this.box.Id);
				this.<>4__this.UpdateProduct();
			}

			// Token: 0x04001AA0 RID: 6816
			public ProductEditViewModel <>4__this;

			// Token: 0x04001AA1 RID: 6817
			public IBox box;
		}

		// Token: 0x020004C3 RID: 1219
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SetBox>d__61 : IAsyncStateMachine
		{
			// Token: 0x06002F26 RID: 12070 RVA: 0x0009A7C4 File Offset: 0x000989C4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ProductEditViewModel productEditViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						this.<>8__1 = new ProductEditViewModel.<>c__DisplayClass61_0();
						this.<>8__1.<>4__this = this.<>4__this;
						this.<>8__1.box = this.box;
						awaiter = productEditViewModel.LoadBoxes().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ProductEditViewModel.<SetBox>d__61>(ref awaiter, ref this);
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
					Application.Current.Dispatcher.Invoke(new Action(this.<>8__1.<SetBox>b__0));
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

			// Token: 0x06002F27 RID: 12071 RVA: 0x0009A8D4 File Offset: 0x00098AD4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001AA2 RID: 6818
			public int <>1__state;

			// Token: 0x04001AA3 RID: 6819
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001AA4 RID: 6820
			public ProductEditViewModel <>4__this;

			// Token: 0x04001AA5 RID: 6821
			public IBox box;

			// Token: 0x04001AA6 RID: 6822
			private ProductEditViewModel.<>c__DisplayClass61_0 <>8__1;

			// Token: 0x04001AA7 RID: 6823
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020004C4 RID: 1220
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateProduct>d__62 : IAsyncStateMachine
		{
			// Token: 0x06002F28 RID: 12072 RVA: 0x0009A8F0 File Offset: 0x00098AF0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ProductEditViewModel productEditViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						if (!productEditViewModel.CheckFields())
						{
							goto IL_12A;
						}
						if (productEditViewModel.CanQuantityEdit)
						{
							if (productEditViewModel.InPriceAdmin < 0m)
							{
								productEditViewModel.InPriceAdmin = 0m;
							}
							productEditViewModel.Item.in_price = productEditViewModel.InPriceAdmin;
						}
					}
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = productEditViewModel.ProductService.UpdateProduct(productEditViewModel.Item, productEditViewModel.ProductAttributesVM.Items).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ProductEditViewModel.<UpdateProduct>d__62>(ref awaiter, ref this);
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
						productEditViewModel._toasterService.Success(Lang.t("Saved"));
					}
					catch (Exception ex)
					{
						string message = (ex.InnerException == null) ? ex.Message : ex.InnerException.Message;
						productEditViewModel._toasterService.Error(message);
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_12A:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002F29 RID: 12073 RVA: 0x0009AA70 File Offset: 0x00098C70
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001AA8 RID: 6824
			public int <>1__state;

			// Token: 0x04001AA9 RID: 6825
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001AAA RID: 6826
			public ProductEditViewModel <>4__this;

			// Token: 0x04001AAB RID: 6827
			private TaskAwaiter <>u__1;
		}
	}
}
