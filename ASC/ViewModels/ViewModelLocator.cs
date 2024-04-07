using System;
using ASC.ViewModel;
using ASC.ViewModels.ACP;
using ASC.ViewModels.Charts;
using ASC.ViewModels.Controls;
using ASC.ViewModels.CustomerCard;
using ASC.ViewModels.ItemCard;
using ASC.WorkspaceV2;
using Autofac;

namespace ASC.ViewModels
{
	// Token: 0x02000420 RID: 1056
	public class ViewModelLocator
	{
		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x06002A41 RID: 10817 RVA: 0x000856C8 File Offset: 0x000838C8
		public CustomerHistoryViewModel CustomerHistoryViewModel
		{
			get
			{
				return Bootstrapper.Container.Resolve<CustomerHistoryViewModel>();
			}
		}

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x06002A42 RID: 10818 RVA: 0x000856E0 File Offset: 0x000838E0
		public CustomerBalanceViewModel CustomerBalanceViewModel
		{
			get
			{
				return Bootstrapper.Container.Resolve<CustomerBalanceViewModel>();
			}
		}

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x06002A43 RID: 10819 RVA: 0x000856F8 File Offset: 0x000838F8
		public CustomerRepairsViewModel CustomerRepairsViewModel
		{
			get
			{
				return Bootstrapper.Container.Resolve<CustomerRepairsViewModel>();
			}
		}

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x06002A44 RID: 10820 RVA: 0x00085710 File Offset: 0x00083910
		public CustomerFinancesViewModel CustomerFinancesViewModel
		{
			get
			{
				return Bootstrapper.Container.Resolve<CustomerFinancesViewModel>();
			}
		}

		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x06002A45 RID: 10821 RVA: 0x00085728 File Offset: 0x00083928
		public CustomerPurchasesViewModel CustomerPurchasesViewModel
		{
			get
			{
				return Bootstrapper.Container.Resolve<CustomerPurchasesViewModel>();
			}
		}

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x06002A46 RID: 10822 RVA: 0x00085740 File Offset: 0x00083940
		public CustomerInvoicesViewModel CustomerInvoicesViewModel
		{
			get
			{
				return Bootstrapper.Container.Resolve<CustomerInvoicesViewModel>();
			}
		}

		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x06002A47 RID: 10823 RVA: 0x00085758 File Offset: 0x00083958
		public CustomerEditViewModel CustomerEditViewModel
		{
			get
			{
				return Bootstrapper.Container.Resolve<CustomerEditViewModel>();
			}
		}

		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x06002A48 RID: 10824 RVA: 0x00085770 File Offset: 0x00083970
		public ProductDocumentsViewModel ProductDocumentsViewModel
		{
			get
			{
				return Bootstrapper.Container.Resolve<ProductDocumentsViewModel>();
			}
		}

		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x06002A49 RID: 10825 RVA: 0x00085788 File Offset: 0x00083988
		public ProductEditViewModel ProductEditViewModel
		{
			get
			{
				return Bootstrapper.Container.Resolve<ProductEditViewModel>();
			}
		}

		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x06002A4A RID: 10826 RVA: 0x000857A0 File Offset: 0x000839A0
		public ProductOverviewViewModel ProductOverviewViewModel
		{
			get
			{
				return Bootstrapper.Container.Resolve<ProductOverviewViewModel>();
			}
		}

		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x06002A4B RID: 10827 RVA: 0x000857B8 File Offset: 0x000839B8
		public ProductHistoryViewModel ProductHistoryViewModel
		{
			get
			{
				return Bootstrapper.Container.Resolve<ProductHistoryViewModel>();
			}
		}

		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x06002A4C RID: 10828 RVA: 0x000857D0 File Offset: 0x000839D0
		public WiolinReportViewModel WiolinReportViewModel
		{
			get
			{
				return Bootstrapper.Container.Resolve<WiolinReportViewModel>();
			}
		}

		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x06002A4D RID: 10829 RVA: 0x000857E8 File Offset: 0x000839E8
		public EmployeeHistoryViewModel EmployeeHistoryViewModel
		{
			get
			{
				return Bootstrapper.Container.Resolve<EmployeeHistoryViewModel>();
			}
		}

		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x06002A4E RID: 10830 RVA: 0x00085800 File Offset: 0x00083A00
		public RepairSendSmsViewModel RepairSendSmsViewModel
		{
			get
			{
				return Bootstrapper.Container.Resolve<RepairSendSmsViewModel>();
			}
		}

		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x06002A4F RID: 10831 RVA: 0x00085818 File Offset: 0x00083A18
		public VendorWarrantyListViewModel VendorWarrantyListViewModel
		{
			get
			{
				return Bootstrapper.Container.Resolve<VendorWarrantyListViewModel>();
			}
		}

		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x06002A50 RID: 10832 RVA: 0x00085830 File Offset: 0x00083A30
		public VendorSelectViewModel VendorSelectViewModel
		{
			get
			{
				return Bootstrapper.Container.Resolve<VendorSelectViewModel>();
			}
		}

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x06002A51 RID: 10833 RVA: 0x00085848 File Offset: 0x00083A48
		public StoreSelectViewModel StoreSelectViewModel
		{
			get
			{
				return Bootstrapper.Container.Resolve<StoreSelectViewModel>();
			}
		}

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x06002A52 RID: 10834 RVA: 0x00085860 File Offset: 0x00083A60
		public StoreCategorySelectViewModel StoreCategorySelectViewModel
		{
			get
			{
				return Bootstrapper.Container.Resolve<StoreCategorySelectViewModel>();
			}
		}

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x06002A53 RID: 10835 RVA: 0x00085878 File Offset: 0x00083A78
		public ProductsMoveViewModel ProductsMoveViewModel
		{
			get
			{
				return Bootstrapper.Container.Resolve<ProductsMoveViewModel>();
			}
		}

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x06002A54 RID: 10836 RVA: 0x00085890 File Offset: 0x00083A90
		public KassaSaldoViewModel KassaSaldoViewModel
		{
			get
			{
				return Bootstrapper.Container.Resolve<KassaSaldoViewModel>();
			}
		}

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x06002A55 RID: 10837 RVA: 0x000858A8 File Offset: 0x00083AA8
		public KassaBalanceViewModel KassaBalanceViewModel
		{
			get
			{
				return Bootstrapper.Container.Resolve<KassaBalanceViewModel>();
			}
		}

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x06002A56 RID: 10838 RVA: 0x000858C0 File Offset: 0x00083AC0
		public CustomerPaymentDetailsViewModel CustomerPaymentDetailsViewModel
		{
			get
			{
				return Bootstrapper.Container.Resolve<CustomerPaymentDetailsViewModel>();
			}
		}

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x06002A57 RID: 10839 RVA: 0x000858D8 File Offset: 0x00083AD8
		public WorkspaceV2ViewModel WorkspaceV2ViewModel
		{
			get
			{
				return Bootstrapper.Container.Resolve<WorkspaceV2ViewModel>();
			}
		}

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x06002A58 RID: 10840 RVA: 0x000858F0 File Offset: 0x00083AF0
		public RepairBoxViewModel RepairBoxViewModel
		{
			get
			{
				return Bootstrapper.Container.Resolve<RepairBoxViewModel>();
			}
		}

		// Token: 0x06002A59 RID: 10841 RVA: 0x000046B4 File Offset: 0x000028B4
		public ViewModelLocator()
		{
		}
	}
}
