using System;
using ASC.Common.Interfaces.Extensions.OpenCart;
using ASC.Services.Abstract;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels
{
	// Token: 0x02000417 RID: 1047
	public class SiteOrderProductsViewModel : CollectionViewModel<IProduct>
	{
		// Token: 0x06002A01 RID: 10753 RVA: 0x00084564 File Offset: 0x00082764
		public SiteOrderProductsViewModel()
		{
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
		}

		// Token: 0x06002A02 RID: 10754 RVA: 0x00084588 File Offset: 0x00082788
		public SiteOrderProductsViewModel(IOrder order) : this()
		{
			this._order = order;
			this.LoadItems();
		}

		// Token: 0x06002A03 RID: 10755 RVA: 0x000845A8 File Offset: 0x000827A8
		public void LoadItems()
		{
			if (this._order.Products == null)
			{
				return;
			}
			foreach (IProduct item in this._order.Products)
			{
				base.Items.Add(item);
			}
		}

		// Token: 0x06002A04 RID: 10756 RVA: 0x00084610 File Offset: 0x00082810
		[Command]
		public void ItemDoubleClick()
		{
			this._navigationService.Navigate("ItemCardView", new ItemCardViewModel(base.SelectedItem.Sku.Value, 0));
		}

		// Token: 0x06002A05 RID: 10757 RVA: 0x00084648 File Offset: 0x00082848
		public bool CanItemDoubleClick()
		{
			IProduct selectedItem = base.SelectedItem;
			return selectedItem != null && selectedItem.Sku != null;
		}

		// Token: 0x04001758 RID: 5976
		private IOrder _order;

		// Token: 0x04001759 RID: 5977
		private readonly INavigationService _navigationService;
	}
}
