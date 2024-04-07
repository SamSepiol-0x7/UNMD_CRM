using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using ASC.Interfaces;
using ASC.Invoice;
using ASC.ItemsArrival;
using ASC.ItemsCancellation;
using ASC.ItemsSale;
using ASC.Models;
using ASC.Objects;
using ASC.Options;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using ASC.ViewModel;
using ASC.ViewModels;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.Documents
{
	// Token: 0x020001E9 RID: 489
	public class DocumentsViewModel : CollectionViewModel<DocsList>, IReturnOnSelect
	{
		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06001AC9 RID: 6857 RVA: 0x0004EF0C File Offset: 0x0004D10C
		// (set) Token: 0x06001ACA RID: 6858 RVA: 0x0004EF20 File Offset: 0x0004D120
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
				if (this.<ReturnOnSelect>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = 1756402615;
				IL_10:
				switch ((num ^ 863873205) % 4)
				{
				case 0:
					goto IL_0B;
				case 1:
					IL_2F:
					this.<ReturnOnSelect>k__BackingField = value;
					this.RaisePropertyChanged("ReturnOnSelect");
					num = 1320808770;
					goto IL_10;
				case 2:
					return;
				}
			}
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06001ACB RID: 6859 RVA: 0x0004EF78 File Offset: 0x0004D178
		// (set) Token: 0x06001ACC RID: 6860 RVA: 0x0004EF8C File Offset: 0x0004D18C
		public bool DocsInOffice
		{
			[CompilerGenerated]
			get
			{
				return this.<DocsInOffice>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<DocsInOffice>k__BackingField == value)
				{
					return;
				}
				this.<DocsInOffice>k__BackingField = value;
				this.RaisePropertyChanged("DocsInOffice");
			}
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06001ACD RID: 6861 RVA: 0x0004EFB8 File Offset: 0x0004D1B8
		// (set) Token: 0x06001ACE RID: 6862 RVA: 0x0004EFCC File Offset: 0x0004D1CC
		public int DocumentsType
		{
			get
			{
				return this._documentsType;
			}
			set
			{
				if (this._documentsType == value)
				{
					return;
				}
				this._documentsType = value;
				this.RaisePropertyChanged("DocumentsType");
				this.LoadDocuments();
			}
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06001ACF RID: 6863 RVA: 0x0004F000 File Offset: 0x0004D200
		// (set) Token: 0x06001AD0 RID: 6864 RVA: 0x0004F014 File Offset: 0x0004D214
		public List<DocumentOptions> Dt
		{
			[CompilerGenerated]
			get
			{
				return this.<Dt>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Dt>k__BackingField, value))
				{
					return;
				}
				this.<Dt>k__BackingField = value;
				this.RaisePropertyChanged("Dt");
			}
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06001AD1 RID: 6865 RVA: 0x0004F044 File Offset: 0x0004D244
		// (set) Token: 0x06001AD2 RID: 6866 RVA: 0x0004F088 File Offset: 0x0004D288
		public string SearchQuery
		{
			get
			{
				return base.GetProperty<string>(() => this.SearchQuery);
			}
			set
			{
				if (string.Equals(this.SearchQuery, value, StringComparison.Ordinal))
				{
					return;
				}
				base.SetProperty<string>(() => this.SearchQuery, value, new Action(this.SearchChanged));
				this.RaisePropertyChanged("SearchQuery");
			}
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x06001AD3 RID: 6867 RVA: 0x0004F0F4 File Offset: 0x0004D2F4
		// (set) Token: 0x06001AD4 RID: 6868 RVA: 0x0004F108 File Offset: 0x0004D308
		public Period Period
		{
			[CompilerGenerated]
			get
			{
				return this.<Period>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<Period>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 434878835;
				IL_13:
				switch ((num ^ 385676620) % 4)
				{
				case 0:
					IL_32:
					this.<Period>k__BackingField = value;
					this.RaisePropertyChanged("Period");
					num = 1008401705;
					goto IL_13;
				case 2:
					goto IL_0E;
				case 3:
					return;
				}
			}
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x0004F164 File Offset: 0x0004D364
		private void SearchChanged()
		{
			this.LoadDocuments();
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x0004F178 File Offset: 0x0004D378
		private void IoC()
		{
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x0004F1B8 File Offset: 0x0004D3B8
		public DocumentsViewModel()
		{
			this.IoC();
			this.SetViewName("Documents");
			Period period = this.Period;
			period.RefreshEventHandler = (EventHandler)Delegate.Combine(period.RefreshEventHandler, new EventHandler(this.Refresh));
			this.LoadDocuments();
		}

		// Token: 0x06001AD8 RID: 6872 RVA: 0x0004F238 File Offset: 0x0004D438
		public DocumentsViewModel(int type)
		{
			this.IoC();
			this.SetViewName("Documents");
			this.DocumentsType = type;
			this.ReturnOnSelect = true;
			Period period = this.Period;
			period.RefreshEventHandler = (EventHandler)Delegate.Combine(period.RefreshEventHandler, new EventHandler(this.Refresh));
			this.LoadDocuments();
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x0004F2C8 File Offset: 0x0004D4C8
		protected override void OnParentViewModelChanged(object parentViewModel)
		{
			base.OnParentViewModelChanged(parentViewModel);
			this._parentViewModel = (parentViewModel as IDocumentSelect);
			if (this._parentViewModel != null)
			{
				base.SelectedItem = null;
			}
		}

		// Token: 0x06001ADA RID: 6874 RVA: 0x0004F164 File Offset: 0x0004D364
		private void Refresh(object sender, EventArgs e)
		{
			this.LoadDocuments();
		}

		// Token: 0x06001ADB RID: 6875 RVA: 0x0004F2F8 File Offset: 0x0004D4F8
		private void LoadDocuments()
		{
			if (this.Dt == null)
			{
				DocumentOptions documentOptions = new DocumentOptions();
				this.Dt = documentOptions.GetAllOptions();
			}
			base.ShowWait();
			Task.Run<List<DocsList>>(() => DocumentsModel.GetDocs(this.Period, this.DocsInOffice, this.SearchQuery, this.DocumentsType)).ContinueWith(delegate(Task<List<DocsList>> t)
			{
				base.SetItems(t.Result);
				base.HideWait();
			}, TaskScheduler.FromCurrentSynchronizationContext());
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x0004F164 File Offset: 0x0004D364
		[Command]
		public void Refresh()
		{
			this.LoadDocuments();
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x0004F350 File Offset: 0x0004D550
		[Command]
		public void ItemDoubleClick()
		{
			if (base.SelectedItem == null)
			{
				return;
			}
			if (this.ReturnOnSelect)
			{
				if (this._parentViewModel != null)
				{
					this._parentViewModel.SelectDoc(base.SelectedItem);
					this._navigationService.CloseCurrentTab();
					return;
				}
			}
			else
			{
				if (base.SelectedItem.type != 1)
				{
					if (base.SelectedItem.type != 2)
					{
						if (base.SelectedItem.type != 6)
						{
							if (base.SelectedItem.type == 3)
							{
								this._windowedDocumentService.ShowNewDocument("ItemsCancellationView", new ItemsCancellationViewModel(base.SelectedItem.id), null, null);
								return;
							}
							if (base.SelectedItem.type == 8)
							{
								ItemsBuyoutViewModel itemsBuyoutViewModel = Bootstrapper.Container.Resolve<ItemsBuyoutViewModel>();
								itemsBuyoutViewModel.SetDocumentId(base.SelectedItem.id);
								this._navigationService.Navigate("ItemsBuyoutView", itemsBuyoutViewModel);
								return;
							}
							if (base.SelectedItem.type != 4)
							{
								return;
							}
							ProductsMoveViewModel productsMoveViewModel = Bootstrapper.Container.Resolve<ProductsMoveViewModel>();
							productsMoveViewModel.SetDocumentId(base.SelectedItem.id);
							this._navigationService.Navigate("ProductsMoveView", productsMoveViewModel);
							return;
						}
					}
					this._navigationService.Navigate("ItemsSaleView", new ItemsSaleViewModel(base.SelectedItem.id));
					return;
				}
				this._navigationService.Navigate("InItems", new ItemsArrivalViewModel(base.SelectedItem.id));
				return;
			}
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x0004F4B8 File Offset: 0x0004D6B8
		[Command]
		public void CreateInvoice()
		{
			if (base.SelectedItem == null)
			{
				return;
			}
			if (base.SelectedItem.dealer == null)
			{
				this._toasterService.Info(Lang.t("AnonCustomer"));
				return;
			}
			this._navigationService.Navigate("NewInvoiceView", new NewInvoiceViewModel(base.SelectedItem));
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x0004F514 File Offset: 0x0004D714
		public bool CanCreateInvoice()
		{
			return OfflineData.Instance.Employee.Can(65, 0);
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x0004F534 File Offset: 0x0004D734
		[Command]
		public void OpenCustomerCard()
		{
			this._navigationService.NavigateToCustomerCard(base.SelectedItem.Customer.Id, null);
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x0004F560 File Offset: 0x0004D760
		public bool CanOpenCustomerCard()
		{
			DocsList selectedItem = base.SelectedItem;
			return ((selectedItem != null) ? selectedItem.Customer : null) != null && (base.SelectedItem.type == 2 || base.SelectedItem.type == 6);
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x0004F5A4 File Offset: 0x0004D7A4
		[Command]
		public void OpenDealerCard()
		{
			this._navigationService.NavigateToCustomerCard(base.SelectedItem.dealer.Value, null);
		}

		// Token: 0x06001AE3 RID: 6883 RVA: 0x0004F5D0 File Offset: 0x0004D7D0
		public bool CanOpenDealerCard()
		{
			DocsList selectedItem = base.SelectedItem;
			return selectedItem != null && selectedItem.dealer != null && base.SelectedItem.type == 1;
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x0004F60C File Offset: 0x0004D80C
		// Note: this type is marked as 'beforefieldinit'.
		static DocumentsViewModel()
		{
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x0004F628 File Offset: 0x0004D828
		[CompilerGenerated]
		private Task<List<DocsList>> <LoadDocuments>b__34_0()
		{
			return DocumentsModel.GetDocs(this.Period, this.DocsInOffice, this.SearchQuery, this.DocumentsType);
		}

		// Token: 0x06001AE6 RID: 6886 RVA: 0x0004F654 File Offset: 0x0004D854
		[CompilerGenerated]
		private void <LoadDocuments>b__34_1(Task<List<DocsList>> t)
		{
			base.SetItems(t.Result);
			base.HideWait();
		}

		// Token: 0x04000E0C RID: 3596
		private IDocumentSelect _parentViewModel;

		// Token: 0x04000E0D RID: 3597
		private INavigationService _navigationService;

		// Token: 0x04000E0E RID: 3598
		private IToasterService _toasterService;

		// Token: 0x04000E0F RID: 3599
		private IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04000E10 RID: 3600
		private static Localization _localization = new Localization("UTC");

		// Token: 0x04000E11 RID: 3601
		[CompilerGenerated]
		private bool <ReturnOnSelect>k__BackingField;

		// Token: 0x04000E12 RID: 3602
		private int _documentsType;

		// Token: 0x04000E13 RID: 3603
		[CompilerGenerated]
		private bool <DocsInOffice>k__BackingField;

		// Token: 0x04000E14 RID: 3604
		[CompilerGenerated]
		private List<DocumentOptions> <Dt>k__BackingField;

		// Token: 0x04000E15 RID: 3605
		[CompilerGenerated]
		private Period <Period>k__BackingField = new Period(DocumentsViewModel._localization.Now.Date, DocumentsViewModel._localization.Now.Date);
	}
}
