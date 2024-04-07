using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Objects;
using ASC.PriceWorks.ItemEditor;
using ASC.Services;
using ASC.Services.Abstract;
using ASC.ViewModels;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;

namespace ASC.PriceWorks
{
	// Token: 0x0200016B RID: 363
	public class PriceWorksViewModel : CollectionViewModel<workshop_price>, IReturnOnSelect
	{
		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x06001714 RID: 5908 RVA: 0x0003B368 File Offset: 0x00039568
		public PriceWorksCategoryViewModel PriceWorksCategoryViewModel
		{
			[CompilerGenerated]
			get
			{
				return this.<PriceWorksCategoryViewModel>k__BackingField;
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06001715 RID: 5909 RVA: 0x0003B37C File Offset: 0x0003957C
		// (set) Token: 0x06001716 RID: 5910 RVA: 0x0003B390 File Offset: 0x00039590
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

		// Token: 0x06001717 RID: 5911 RVA: 0x0003B3BC File Offset: 0x000395BC
		public PriceWorksViewModel(IWorkshopPriceService workshopPriceService, INavigationService navigationService, IWindowedDocumentService windowedDocumentService)
		{
			this.SetViewName("PriceWorks");
			this._workshopPriceService = workshopPriceService;
			this._navigationService = navigationService;
			this._windowedDocumentService = windowedDocumentService;
			this.PriceWorksCategoryViewModel = Bootstrapper.Container.Resolve<PriceWorksCategoryViewModel>();
			this.PriceWorksCategoryViewModel.SetParentViewModel(this);
			PriceWorksCategoryViewModel priceWorksCategoryViewModel = this.PriceWorksCategoryViewModel;
			priceWorksCategoryViewModel.SelectedItemChanged = (EventHandler<ICategory>)Delegate.Combine(priceWorksCategoryViewModel.SelectedItemChanged, new EventHandler<ICategory>(this.SelectedItemChanged));
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x0003B434 File Offset: 0x00039634
		private new void SelectedItemChanged(object sender, ICategory e)
		{
			Application.Current.Dispatcher.Invoke(delegate()
			{
				this.BgLoadItems();
			});
		}

		// Token: 0x06001719 RID: 5913 RVA: 0x0003B45C File Offset: 0x0003965C
		public void SetReturnSelected(bool value)
		{
			this.ReturnOnSelect = value;
			this.PriceWorksCategoryViewModel.SetIsReadOnly(this.ReturnOnSelect);
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x0003B484 File Offset: 0x00039684
		[Command]
		public void AddItem()
		{
			this.OpenItemCard();
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x0003B498 File Offset: 0x00039698
		public bool CanAddItem()
		{
			return Auth.User != null && !this.ReturnOnSelect && OfflineData.Instance.Employee.Can(38, 0);
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x0003B4CC File Offset: 0x000396CC
		private void BgLoadItems()
		{
			PriceWorksViewModel.<>c__DisplayClass16_0 CS$<>8__locals1 = new PriceWorksViewModel.<>c__DisplayClass16_0();
			CS$<>8__locals1.<>4__this = this;
			if (base.ViewLoaded)
			{
				PriceWorksViewModel.<>c__DisplayClass16_0 CS$<>8__locals2 = CS$<>8__locals1;
				ICategory selectedItem = this.PriceWorksCategoryViewModel.SelectedItem;
				CS$<>8__locals2.catId = ((selectedItem != null) ? selectedItem.Id : 0);
				base.ShowWait();
				Task.Run<List<workshop_price>>(() => CS$<>8__locals1.<>4__this._workshopPriceService.GetPriceItems(new int?(CS$<>8__locals1.<>4__this.PriceWorksCategoryViewModel.SelectedPrice), CS$<>8__locals1.catId)).ContinueWith(delegate(Task<List<workshop_price>> t)
				{
					CS$<>8__locals1.<>4__this.SetItems(t.Result);
					CS$<>8__locals1.<>4__this.HideWait();
				}, TaskScheduler.FromCurrentSynchronizationContext());
				return;
			}
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x0003B53C File Offset: 0x0003973C
		[Command]
		public void Refresh()
		{
			this.BgLoadItems();
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x0003B550 File Offset: 0x00039750
		private void OpenItemCard()
		{
			ICategory selectedItem = this.PriceWorksCategoryViewModel.SelectedItem;
			int category = (selectedItem != null) ? selectedItem.Id : -1;
			PriceItemViewModel priceItemViewModel = new PriceItemViewModel();
			priceItemViewModel.SetCategory(category);
			if (this.PriceWorksCategoryViewModel.SelectedPrice > 0)
			{
				priceItemViewModel.SetVendor(new int?(this.PriceWorksCategoryViewModel.SelectedPrice));
			}
			this._windowedDocumentService.ShowNewDocument("PriceItemView", priceItemViewModel, this, null);
		}

		// Token: 0x0600171F RID: 5919 RVA: 0x0003B5BC File Offset: 0x000397BC
		protected override void OnParentViewModelChanged(object parentViewModel)
		{
			base.OnParentViewModelChanged(parentViewModel);
			this._parentViewModel = (parentViewModel as IWorksSelect);
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x0003B5DC File Offset: 0x000397DC
		private void Close()
		{
			IWorksSelect parentViewModel = this._parentViewModel;
			if (parentViewModel != null)
			{
				parentViewModel.AddWorksFromPrice(base.SelectedItem);
			}
			this._navigationService.CloseCurrentTab();
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x0003B60C File Offset: 0x0003980C
		[Command]
		public void ItemDoubleClick()
		{
			if (!this.ReturnOnSelect)
			{
				goto IL_2C;
			}
			IL_08:
			int num = 1408741325;
			IL_0D:
			switch ((num ^ 953064411) % 4)
			{
			case 1:
				IL_2C:
				this._windowedDocumentService.ShowNewDocument("PriceItemView", new PriceItemViewModel(base.SelectedItem.id), this, null);
				num = 1811889495;
				goto IL_0D;
			case 2:
				this.Close();
				return;
			case 3:
				goto IL_08;
			}
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x0003B678 File Offset: 0x00039878
		public bool CanItemDoubleClick()
		{
			return base.SelectedItem != null;
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x0003B690 File Offset: 0x00039890
		[Command]
		public void OnLoaded()
		{
			base.SetViewLoaded(true);
			this.PriceWorksCategoryViewModel.LoadCategories(false);
			this.BgLoadItems();
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x0003B53C File Offset: 0x0003973C
		[CompilerGenerated]
		private void <SelectedItemChanged>b__12_0()
		{
			this.BgLoadItems();
		}

		// Token: 0x04000B73 RID: 2931
		private readonly IWorkshopPriceService _workshopPriceService;

		// Token: 0x04000B74 RID: 2932
		private readonly INavigationService _navigationService;

		// Token: 0x04000B75 RID: 2933
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04000B76 RID: 2934
		[CompilerGenerated]
		private readonly PriceWorksCategoryViewModel <PriceWorksCategoryViewModel>k__BackingField;

		// Token: 0x04000B77 RID: 2935
		[CompilerGenerated]
		private bool <ReturnOnSelect>k__BackingField;

		// Token: 0x04000B78 RID: 2936
		private IWorksSelect _parentViewModel;

		// Token: 0x0200016C RID: 364
		[CompilerGenerated]
		private sealed class <>c__DisplayClass16_0
		{
			// Token: 0x06001725 RID: 5925 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass16_0()
			{
			}

			// Token: 0x06001726 RID: 5926 RVA: 0x0003B6B8 File Offset: 0x000398B8
			internal Task<List<workshop_price>> <BgLoadItems>b__0()
			{
				return this.<>4__this._workshopPriceService.GetPriceItems(new int?(this.<>4__this.PriceWorksCategoryViewModel.SelectedPrice), this.catId);
			}

			// Token: 0x06001727 RID: 5927 RVA: 0x0003B6F0 File Offset: 0x000398F0
			internal void <BgLoadItems>b__1(Task<List<workshop_price>> t)
			{
				this.<>4__this.SetItems(t.Result);
				this.<>4__this.HideWait();
			}

			// Token: 0x04000B79 RID: 2937
			public PriceWorksViewModel <>4__this;

			// Token: 0x04000B7A RID: 2938
			public int catId;
		}
	}
}
