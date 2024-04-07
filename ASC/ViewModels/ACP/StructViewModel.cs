using System;
using System.Runtime.CompilerServices;
using ASC.Interfaces;
using Autofac;
using DevExpress.Mvvm.POCO;

namespace ASC.ViewModels.ACP
{
	// Token: 0x02000571 RID: 1393
	public class StructViewModel : BaseViewModel
	{
		// Token: 0x17000FB0 RID: 4016
		// (get) Token: 0x06003377 RID: 13175 RVA: 0x000ADE38 File Offset: 0x000AC038
		public IOfficesViewModel CompaniesViewModel
		{
			[CompilerGenerated]
			get
			{
				return this.<CompaniesViewModel>k__BackingField;
			}
		}

		// Token: 0x17000FB1 RID: 4017
		// (get) Token: 0x06003378 RID: 13176 RVA: 0x000ADE4C File Offset: 0x000AC04C
		public IOfficesViewModel OfficesViewModel
		{
			[CompilerGenerated]
			get
			{
				return this.<OfficesViewModel>k__BackingField;
			}
		}

		// Token: 0x17000FB2 RID: 4018
		// (get) Token: 0x06003379 RID: 13177 RVA: 0x000ADE60 File Offset: 0x000AC060
		public IOfficesViewModel BanksViewModel
		{
			[CompilerGenerated]
			get
			{
				return this.<BanksViewModel>k__BackingField;
			}
		}

		// Token: 0x0600337A RID: 13178 RVA: 0x000ADE74 File Offset: 0x000AC074
		public StructViewModel()
		{
			this.CompaniesViewModel = Bootstrapper.Container.ResolveNamed("CompaniesViewModel");
			this.CompaniesViewModel.SetParentViewModel(this);
			this.OfficesViewModel = Bootstrapper.Container.ResolveNamed("OfficesViewModel");
			this.OfficesViewModel.SetParentViewModel(this);
			this.BanksViewModel = Bootstrapper.Container.ResolveNamed("CompanyPaymentDetailsViewModel");
			this.BanksViewModel.SetParentViewModel(this);
		}

		// Token: 0x04001DAB RID: 7595
		[CompilerGenerated]
		private readonly IOfficesViewModel <CompaniesViewModel>k__BackingField;

		// Token: 0x04001DAC RID: 7596
		[CompilerGenerated]
		private readonly IOfficesViewModel <OfficesViewModel>k__BackingField;

		// Token: 0x04001DAD RID: 7597
		[CompilerGenerated]
		private readonly IOfficesViewModel <BanksViewModel>k__BackingField;
	}
}
