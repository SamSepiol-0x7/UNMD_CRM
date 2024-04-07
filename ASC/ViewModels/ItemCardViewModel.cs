using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Interfaces;
using ASC.ItemsCancellation;
using ASC.ItemsSale;
using ASC.Models;
using ASC.Objects;
using ASC.PartsRequest;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using ASC.Stickers;
using ASC.ViewModel;
using ASC.ViewModels.ItemCard;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels
{
	// Token: 0x020004A3 RID: 1187
	public class ItemCardViewModel : MenuViewModel, IIsDataLoading, IRefreshable
	{
		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x06002E15 RID: 11797 RVA: 0x00095E80 File Offset: 0x00094080
		// (set) Token: 0x06002E16 RID: 11798 RVA: 0x00095E94 File Offset: 0x00094094
		public Email Email
		{
			[CompilerGenerated]
			get
			{
				return this.<Email>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Email>k__BackingField, value))
				{
					return;
				}
				this.<Email>k__BackingField = value;
				this.RaisePropertyChanged("Email");
			}
		}

		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x06002E17 RID: 11799 RVA: 0x00095EC4 File Offset: 0x000940C4
		// (set) Token: 0x06002E18 RID: 11800 RVA: 0x00095ED8 File Offset: 0x000940D8
		private store_items Item
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

		// Token: 0x06002E19 RID: 11801 RVA: 0x00095F08 File Offset: 0x00094108
		public ItemCardViewModel()
		{
			this.StoreService = Bootstrapper.Container.Resolve<IStoreService>();
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
		}

		// Token: 0x06002E1A RID: 11802 RVA: 0x00095F5C File Offset: 0x0009415C
		public ItemCardViewModel(int id, int tabIndex = 0) : this()
		{
			this._productId = id;
			this._tabIndex = tabIndex;
			this.SetViewName("ItemCard", id);
		}

		// Token: 0x06002E1B RID: 11803 RVA: 0x00095F8C File Offset: 0x0009418C
		public void SetProductId(int value)
		{
			this._productId = value;
			this.SetViewName("ItemCard", value);
		}

		// Token: 0x06002E1C RID: 11804 RVA: 0x00095FAC File Offset: 0x000941AC
		public override void MenuItemChanged()
		{
			base.RaiseCanExecuteChanged(() => this.SaveItem());
			if (base.CurrentMenuItemCaption("SaleOrReserve"))
			{
				this.SaleSingleItem();
			}
			if (base.CurrentMenuItemCaption("ItemsCancellation"))
			{
				this.CancellItem();
			}
			if (base.CurrentMenuItemCaption("PrintStickers"))
			{
				this.PrintSticker4Item();
			}
			if (base.CurrentMenuItemCaption("GiveItem"))
			{
				this.Giveitem();
			}
			if (base.CurrentMenuItemCaption("DealerCard"))
			{
				this.OpenDealerCard();
			}
			if (base.CurrentMenuItemCaption("RequestItem"))
			{
				this.RequestItem();
			}
			if (base.CurrentMenuItemCaption("ItemsMovement"))
			{
				this.ItemMovement();
			}
		}

		// Token: 0x06002E1D RID: 11805 RVA: 0x0009607C File Offset: 0x0009427C
		[Command]
		public void Loaded()
		{
			this.Init();
		}

		// Token: 0x06002E1E RID: 11806 RVA: 0x00096090 File Offset: 0x00094290
		public sealed override void InitMenu()
		{
			base.InitMenu();
			base.ShowWait();
			base.AddMenuItem("Overview", "ItemOverviewView", "Home_32x32.png", this._productId);
			if (OfflineData.Instance.Employee.Can(21, 0))
			{
				base.AddMenuItem("Edit", "ItemEditView", "Edit_32x32.png", this._productId);
			}
			if (OfflineData.Instance.Employee.Can(6, 0))
			{
				base.AddMenuItem("History", "ProductHistoryView", "HistoryItem_32x32.png", this._productId);
			}
			if (OfflineData.Instance.Employee.Can(45, 0) && OfflineData.Instance.Employee.Can(6, 0))
			{
				base.AddMenuItem("Documents", "ItemDocumentsView", "Information_32x32.png", this._productId);
			}
			if (this.IsAvailableAndForSale() && OfflineData.Instance.Employee.Can(5, 0))
			{
				base.AddMenuItem("SaleOrReserve", "ItemOverviewView", "BOOrder_32x32.png", this._productId);
			}
			if (this.IsItemsAvailable() && OfflineData.Instance.Employee.Can(9, 0))
			{
				base.AddMenuItem("ItemsCancellation", "ItemOverviewView", "Trash_32x32.png", this._productId);
			}
			if (OfflineData.Instance.Employee.Can(3, 0))
			{
				base.AddMenuItem("PrintStickers", "ItemOverviewView", "Barcode_32x32.png", this._productId);
			}
			if (this.IsItemsAvailable() && OfflineData.Instance.Employee.Can(45, 0))
			{
				base.AddMenuItem("GiveItem", "ItemOverviewView", "AssignTo_32x32.png", this._productId);
			}
			if (OfflineData.Instance.Employee.Can(7, 0))
			{
				base.AddMenuItem("DealerCard", "ItemOverviewView", "BOCustomer_32x32.png", this._productId);
			}
			if (this.IsItemsAvailable())
			{
				base.AddMenuItem("RequestItem", "ItemOverviewView", "AssignToMe_32x32.png", this._productId);
			}
			if (this.IsItemsAvailable() && this.CanItemMovement())
			{
				base.AddMenuItem("ItemsMovement", "ItemOverviewView", "Group2_32x32.png", this._productId);
			}
			if (this._tabIndex == 1)
			{
				base.SelectMenuItebByCaption("Edit");
			}
			else
			{
				base.SelectFirstMenuItem();
			}
			base.HideWait();
		}

		// Token: 0x06002E1F RID: 11807 RVA: 0x0009630C File Offset: 0x0009450C
		private void Giveitem()
		{
			if (this.ItemInForeignOffice())
			{
				return;
			}
			this.PartRequest(false);
		}

		// Token: 0x06002E20 RID: 11808 RVA: 0x0009632C File Offset: 0x0009452C
		private void RequestItem()
		{
			this.PartRequest(true);
		}

		// Token: 0x06002E21 RID: 11809 RVA: 0x00096340 File Offset: 0x00094540
		private void PartRequest(bool isRequest)
		{
			if (this.Item != null)
			{
				goto IL_2C;
			}
			IL_08:
			int num = 975181609;
			IL_0D:
			switch ((num ^ 194429951) % 4)
			{
			case 1:
				IL_2C:
				this._navigationService.Navigate("PartsRequestView", new PartsRequestViewModel(this.Item.id, isRequest));
				num = 269310343;
				goto IL_0D;
			case 2:
				return;
			case 3:
				goto IL_08;
			}
		}

		// Token: 0x06002E22 RID: 11810 RVA: 0x000963A4 File Offset: 0x000945A4
		private bool IsItemsAvailable()
		{
			store_items item = this.Item;
			return item != null && item.Available > 0;
		}

		// Token: 0x06002E23 RID: 11811 RVA: 0x000963C8 File Offset: 0x000945C8
		private bool IsAvailableAndForSale()
		{
			if (this.Item != null)
			{
				goto IL_4B;
			}
			IL_17:
			int num = 404767143;
			IL_1C:
			switch ((num ^ 2052611097) % 5)
			{
			case 0:
				goto IL_17;
			case 1:
				return !this.Item.not_for_sale;
			case 2:
				return false;
			case 3:
				IL_4B:
				num = ((this.Item.Available > 0) ? 1884567722 : 201643101);
				goto IL_1C;
			}
			return false;
		}

		// Token: 0x06002E24 RID: 11812 RVA: 0x00096444 File Offset: 0x00094644
		public void PrintSticker4Item()
		{
			this._windowedDocumentService.ShowNewDocument("StickersView", new StickersViewModel(new List<int>
			{
				this.Item.id
			}), null, null);
		}

		// Token: 0x06002E25 RID: 11813 RVA: 0x00096480 File Offset: 0x00094680
		private void SaleSingleItem()
		{
			if (!this.ItemInForeignOffice())
			{
				goto IL_2C;
			}
			IL_08:
			int num = -903669322;
			IL_0D:
			switch ((num ^ -1722616337) % 4)
			{
			case 0:
				IL_2C:
				this._navigationService.Navigate("ItemsSaleView", new ItemsSaleViewModel(this.Item));
				num = -1479841756;
				goto IL_0D;
			case 1:
				return;
			case 2:
				goto IL_08;
			}
		}

		// Token: 0x06002E26 RID: 11814 RVA: 0x000964DC File Offset: 0x000946DC
		private bool ItemInForeignOffice()
		{
			if (!StoreModel.ItemInUserOffice(this.Item.store))
			{
				this._toasterService.Info(Lang.t("ItemInForeignOffice"));
				return true;
			}
			return false;
		}

		// Token: 0x06002E27 RID: 11815 RVA: 0x00096514 File Offset: 0x00094714
		private void Init()
		{
			ItemCardViewModel.<Init>d__27 <Init>d__;
			<Init>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<ItemCardViewModel.<Init>d__27>(ref <Init>d__);
		}

		// Token: 0x06002E28 RID: 11816 RVA: 0x0009654C File Offset: 0x0009474C
		private void OpenDealerCard()
		{
			this._navigationService.NavigateToCustomerCard(this.Item.dealer, null);
		}

		// Token: 0x06002E29 RID: 11817 RVA: 0x00096570 File Offset: 0x00094770
		private void CancellItem()
		{
			this._windowedDocumentService.ShowNewDocument("ItemsCancellationView", new ItemsCancellationViewModel(new List<int>
			{
				this.Item.id
			}), this, null);
		}

		// Token: 0x06002E2A RID: 11818 RVA: 0x000965AC File Offset: 0x000947AC
		public void RefProductEditViewModel(ProductEditViewModel vm)
		{
			this._productEditViewModel = vm;
		}

		// Token: 0x06002E2B RID: 11819 RVA: 0x000965C0 File Offset: 0x000947C0
		[Command]
		public void SaveItem()
		{
			this._productEditViewModel.UpdateProduct();
		}

		// Token: 0x06002E2C RID: 11820 RVA: 0x000965D8 File Offset: 0x000947D8
		public bool CanSaveItem()
		{
			return base.SelectedMenuItem != null && OfflineData.Instance.Employee.Can(21, 0) && base.SelectedMenuItem.Caption == Lang.t("Edit");
		}

		// Token: 0x06002E2D RID: 11821 RVA: 0x00096620 File Offset: 0x00094820
		public void ItemMovement()
		{
			ProductsMoveViewModel productsMoveViewModel = Bootstrapper.Container.Resolve<ProductsMoveViewModel>();
			productsMoveViewModel.LoadAndAddItem(this.Item.id);
			this._navigationService.Navigate("ProductsMoveView", productsMoveViewModel);
		}

		// Token: 0x06002E2E RID: 11822 RVA: 0x0009665C File Offset: 0x0009485C
		public bool CanItemMovement()
		{
			return OfflineData.Instance.Employee.Can(6, 0);
		}

		// Token: 0x06002E2F RID: 11823 RVA: 0x0009607C File Offset: 0x0009427C
		public void DataRefresh()
		{
			this.Init();
		}

		// Token: 0x06002E30 RID: 11824 RVA: 0x0009667C File Offset: 0x0009487C
		[Command]
		public void ShowSendPhotos()
		{
			this._windowedDocumentService.ShowNewDocument("EmailView", new EmailViewModel(this.Item), null, null);
		}

		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x06002E31 RID: 11825 RVA: 0x000966A8 File Offset: 0x000948A8
		// (set) Token: 0x06002E32 RID: 11826 RVA: 0x000966BC File Offset: 0x000948BC
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

		// Token: 0x06002E33 RID: 11827 RVA: 0x000966E8 File Offset: 0x000948E8
		public void SetIsDataLoading(bool value)
		{
			this.IsLoadingData = value;
		}

		// Token: 0x06002E34 RID: 11828 RVA: 0x000966FC File Offset: 0x000948FC
		[CompilerGenerated]
		private Task<store_items> <Init>b__27_1()
		{
			return this.StoreService.GetProduct(this._productId);
		}

		// Token: 0x040019F2 RID: 6642
		[CompilerGenerated]
		private Email <Email>k__BackingField;

		// Token: 0x040019F3 RID: 6643
		private int _productId;

		// Token: 0x040019F4 RID: 6644
		protected IStoreService StoreService;

		// Token: 0x040019F5 RID: 6645
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x040019F6 RID: 6646
		private readonly IToasterService _toasterService;

		// Token: 0x040019F7 RID: 6647
		[CompilerGenerated]
		private store_items <Item>k__BackingField;

		// Token: 0x040019F8 RID: 6648
		private int _tabIndex;

		// Token: 0x040019F9 RID: 6649
		private ProductEditViewModel _productEditViewModel;

		// Token: 0x040019FA RID: 6650
		private INavigationService _navigationService;

		// Token: 0x040019FB RID: 6651
		[CompilerGenerated]
		private bool <IsLoadingData>k__BackingField;

		// Token: 0x020004A4 RID: 1188
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Init>d__27 : IAsyncStateMachine
		{
			// Token: 0x06002E35 RID: 11829 RVA: 0x0009671C File Offset: 0x0009491C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemCardViewModel itemCardViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<store_items> awaiter;
					if (num != 0)
					{
						awaiter = Task.Run<store_items>(() => itemCardViewModel.StoreService.GetProduct(itemCardViewModel._productId)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<store_items>, ItemCardViewModel.<Init>d__27>(ref awaiter, ref this);
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
					itemCardViewModel.Item = result;
					if (itemCardViewModel.Item != null)
					{
						itemCardViewModel.RaiseCanExecuteChanged(() => itemCardViewModel.ShowSendPhotos());
						itemCardViewModel.InitMenu();
					}
					else
					{
						itemCardViewModel._toasterService.Error("");
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

			// Token: 0x06002E36 RID: 11830 RVA: 0x00096844 File Offset: 0x00094A44
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040019FC RID: 6652
			public int <>1__state;

			// Token: 0x040019FD RID: 6653
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040019FE RID: 6654
			public ItemCardViewModel <>4__this;

			// Token: 0x040019FF RID: 6655
			private TaskAwaiter<store_items> <>u__1;
		}
	}
}
