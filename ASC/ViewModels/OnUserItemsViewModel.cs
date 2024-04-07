using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using ASC.Interfaces;
using ASC.Models;
using ASC.PartsRequest;
using ASC.Services.Abstract;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels
{
	// Token: 0x02000438 RID: 1080
	public class OnUserItemsViewModel : CollectionViewModel<store_int_reserve>, IRefreshable
	{
		// Token: 0x06002AF2 RID: 10994 RVA: 0x000883A4 File Offset: 0x000865A4
		public OnUserItemsViewModel()
		{
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
		}

		// Token: 0x06002AF3 RID: 10995 RVA: 0x000883E8 File Offset: 0x000865E8
		public OnUserItemsViewModel(StoreViewModel storeViewModel) : this()
		{
			this._storeViewModel = storeViewModel;
		}

		// Token: 0x06002AF4 RID: 10996 RVA: 0x00088404 File Offset: 0x00086604
		public void LoadOnUserItems()
		{
			base.ShowWait();
			int category = this._storeViewModel.GetSelectedCategory();
			Task.Run<IEnumerable<store_int_reserve>>(() => StoreModel.LoadMyItems(category, this._storeViewModel.Query, this._storeViewModel.MyPartsState)).ContinueWith(delegate(Task<IEnumerable<store_int_reserve>> t)
			{
				this.SetItems(t.Result);
				this.HideWait();
			});
		}

		// Token: 0x06002AF5 RID: 10997 RVA: 0x00088458 File Offset: 0x00086658
		[Command]
		public void MyItemClick()
		{
			if (base.SelectedItem == null || this._storeViewModel == null)
			{
				return;
			}
			if (this._storeViewModel.GetReturnAction() != StoreViewModel.ReturnAction.InsertToRepair)
			{
				this._navigationService.Navigate("PartsRequestView", new PartsRequestViewModel(base.SelectedItem.id));
				return;
			}
			if (base.SelectedItem.repair_id != null)
			{
				int repairId = this._storeViewModel._repairId;
				int? repair_id = base.SelectedItem.repair_id;
				if (!(repairId == repair_id.GetValueOrDefault() & repair_id != null))
				{
					string message = string.Format("{0}: {1:d6}", Lang.t("ItemInsertWarning"), base.SelectedItem.repair_id);
					this._toasterService.Error(message);
					return;
				}
			}
			int count = base.SelectedItem.count;
			if (count <= 1)
			{
				IMyItemSelect parentViewModelMyItemSelect = this._storeViewModel.GetParentViewModelMyItemSelect();
				if (parentViewModelMyItemSelect != null)
				{
					parentViewModelMyItemSelect.AddProductFromEmployeeCart(base.SelectedItem, count);
				}
				this._navigationService.CloseCurrentTab();
				return;
			}
			this._windowedDocumentService.ShowNewDocument("OnUserCountView", new OnUserCountViewModel(this._storeViewModel, base.SelectedItem), this, null);
		}

		// Token: 0x06002AF6 RID: 10998 RVA: 0x00088578 File Offset: 0x00086778
		[Command]
		public void NavigateRepairCard()
		{
			if (base.SelectedItem.repair_id != null)
			{
				this._navigationService.NavigateRepairCard(base.SelectedItem.repair_id.Value);
			}
		}

		// Token: 0x06002AF7 RID: 10999 RVA: 0x000885B8 File Offset: 0x000867B8
		public bool CanNavigateRepairCard()
		{
			store_int_reserve selectedItem = base.SelectedItem;
			return selectedItem != null && selectedItem.repair_id != null;
		}

		// Token: 0x06002AF8 RID: 11000 RVA: 0x00023150 File Offset: 0x00021350
		public override void OnSelectedItemChanged(store_int_reserve item)
		{
		}

		// Token: 0x06002AF9 RID: 11001 RVA: 0x000885E0 File Offset: 0x000867E0
		public void ClearSelectedItem()
		{
			base.SelectedItem = null;
		}

		// Token: 0x06002AFA RID: 11002 RVA: 0x000885F4 File Offset: 0x000867F4
		public void DataRefresh()
		{
			this.LoadOnUserItems();
		}

		// Token: 0x040017EC RID: 6124
		private StoreViewModel _storeViewModel;

		// Token: 0x040017ED RID: 6125
		private readonly INavigationService _navigationService;

		// Token: 0x040017EE RID: 6126
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x040017EF RID: 6127
		private readonly IToasterService _toasterService;

		// Token: 0x02000439 RID: 1081
		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x06002AFB RID: 11003 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x06002AFC RID: 11004 RVA: 0x00088608 File Offset: 0x00086808
			internal Task<IEnumerable<store_int_reserve>> <LoadOnUserItems>b__0()
			{
				return StoreModel.LoadMyItems(this.category, this.<>4__this._storeViewModel.Query, this.<>4__this._storeViewModel.MyPartsState);
			}

			// Token: 0x06002AFD RID: 11005 RVA: 0x00088640 File Offset: 0x00086840
			internal void <LoadOnUserItems>b__1(Task<IEnumerable<store_int_reserve>> t)
			{
				this.<>4__this.SetItems(t.Result);
				this.<>4__this.HideWait();
			}

			// Token: 0x040017F0 RID: 6128
			public int category;

			// Token: 0x040017F1 RID: 6129
			public OnUserItemsViewModel <>4__this;
		}
	}
}
