using System;
using System.Runtime.CompilerServices;
using ASC.About;
using ASC.Charts.WithdrawFunds;
using ASC.Common;
using ASC.Common.Interfaces;
using ASC.Common.Interfaces.SiteStore;
using ASC.Common.Interfaces.VoIP;
using ASC.Common.Repositories;
using ASC.DAL;
using ASC.Extensions.Asterisk;
using ASC.Extensions.Mango;
using ASC.Extensions.Megafon;
using ASC.Extensions.OpenCart;
using ASC.Extensions.Rostelecom;
using ASC.Extensions.SmsC;
using ASC.Extensions.Zadarma;
using ASC.Interfaces;
using ASC.Invoice;
using ASC.ItemsExport;
using ASC.Kassa;
using ASC.Models;
using ASC.NewRepair;
using ASC.Options;
using ASC.Persistence;
using ASC.Persistence.Repositories;
using ASC.PKO;
using ASC.PriceWorks;
using ASC.RepairCard.Admin;
using ASC.RKO;
using ASC.Services;
using ASC.Services.Abstract;
using ASC.Services.Concrete;
using ASC.Stocktaking;
using ASC.ViewModel;
using ASC.ViewModels;
using ASC.ViewModels.ACP;
using ASC.ViewModels.Charts;
using ASC.ViewModels.Controls;
using ASC.ViewModels.CustomerCard;
using ASC.ViewModels.ItemCard;
using ASC.Voip.Megafon.Core;
using ASC.WorkspaceV2;
using Autofac;
using Autofac.Builder;

namespace ASC
{
	// Token: 0x02000017 RID: 23
	public class Bootstrapper
	{
		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00003E40 File Offset: 0x00002040
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00003E54 File Offset: 0x00002054
		public static IContainer Container
		{
			[CompilerGenerated]
			get
			{
				return Bootstrapper.<Container>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				Bootstrapper.<Container>k__BackingField = value;
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00003E68 File Offset: 0x00002068
		public static void BuildContainer()
		{
			ContainerBuilder containerBuilder = new ContainerBuilder();
			containerBuilder.RegisterType<UoW>().As<IUoW>();
			containerBuilder.RegisterType<auseceEntities>();
			containerBuilder.RegisterType<ContextFactory>().As<IContextFactory>();
			Bootstrapper.RegisterServices(containerBuilder);
			containerBuilder.RegisterType<Period>().As<IPeriod>();
			containerBuilder.RegisterType<UsersModel>();
			containerBuilder.RegisterType<InvoiceModel>().As<IInvoiceModel>();
			containerBuilder.RegisterType<RepairModel>().As<IRepairModel>();
			containerBuilder.RegisterType<InternalReserveModel>().As<IInternalReserveModel>();
			containerBuilder.RegisterType<KassaModel>().As<IKassa>();
			containerBuilder.RegisterType<KassaModel>().AsSelf<KassaModel, ConcreteReflectionActivatorData>();
			containerBuilder.RegisterType<AdditionalFieldsService>().As<IAdditionalFieldsService>();
			containerBuilder.RegisterType<HistoryV2>().As<IHistoryV2>();
			containerBuilder.RegisterType<WorkshopOptions>().AsSelf<WorkshopOptions, ConcreteReflectionActivatorData>();
			containerBuilder.RegisterType<VATInvoiceRepository>().As<IVATInvoiceRepository>();
			containerBuilder.RegisterType<PackingListRepository>().As<IPackingListRepository>();
			containerBuilder.RegisterType<WokrsListRepository>().As<IWorksListRepository>();
			containerBuilder.RegisterType<PaymentDetailRepository>().As<IPaymentDetailRepository>();
			containerBuilder.RegisterType<GenericRepository<ps_endpoints>>().As<IRepository<ps_endpoints>>();
			containerBuilder.RegisterType<GenericRepository<cdr>>().As<IRepository<cdr>>();
			containerBuilder.RegisterType<GenericRepository<hooks>>().As<IRepository<hooks>>();
			containerBuilder.RegisterType<OpenCartStore>().As<IOnlineStore>();
			containerBuilder.RegisterType<FinancesFlowReport>().As<IFinancesFlowReport>();
			containerBuilder.RegisterType<ZnamenFinancesFlowReport>().As<IFinancesFlowReport>().Keyed<IFinancesFlowReport>("Znamen");
			Bootstrapper.RegisterVoip(containerBuilder);
			containerBuilder.RegisterType<Localization>().As<ILocalization>();
			containerBuilder.RegisterType<ExportXML>().As<IExport>().Keyed<IExport>("XML");
			containerBuilder.RegisterType<ExportJSON>().As<IExport>().Keyed<IExport>("JSON");
			containerBuilder.RegisterType<SMSC>().As<ISMSC>();
			containerBuilder.RegisterType<SMSCClient>().As<ISmsClient>().Keyed<ISmsClient>("SMSC");
			Bootstrapper.RegisterViewModels(containerBuilder);
			containerBuilder.RegisterType<InvoiceStrategy>().As<IInvoiceStrategy>().WithParameter("invoiceFactories", new IInvoiceFactory[]
			{
				new InvoiceFactory(),
				new VATInvoiceFactory(),
				new PackingListFactory(),
				new WorksListFactory()
			});
			Bootstrapper.Container = containerBuilder.Build(ContainerBuildOptions.None);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00004044 File Offset: 0x00002244
		private static void RegisterVoip(ContainerBuilder builder)
		{
			builder.RegisterType<ZadarmaApi>().As<IVoIP>().Keyed<IVoIP>("Zadarma");
			builder.RegisterType<RostelecomApi>().As<IVoIP>().Keyed<IVoIP>("Rostelecom");
			builder.RegisterType<MangoOffice>().As<IVoIP>().Keyed<IVoIP>("MangoTelecom");
			builder.RegisterType<AsteriskRealtime>().As<IVoIP>().Keyed<IVoIP>("AsteriskRealtime");
			builder.RegisterType<Megafon>().As<IVoIP>().Keyed<IVoIP>("Megafon");
			builder.RegisterType<MegafonApiOptions>().As<IMegafonApiOptions>();
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000040CC File Offset: 0x000022CC
		private static void RegisterViewModels(ContainerBuilder builder)
		{
			builder.RegisterType<AboutViewModel>();
			builder.RegisterType<KassaViewModel>();
			builder.RegisterType<EmployeesActivityChartViewModel>();
			builder.RegisterType<ProductAttributesViewModel>().As<IProductAttributesViewModel>();
			builder.RegisterType<ProductAttributesListViewModel>().AsSelf<ProductAttributesListViewModel, ConcreteReflectionActivatorData>();
			builder.RegisterType<VendorWarrantyViewModel>().AsSelf<VendorWarrantyViewModel, ConcreteReflectionActivatorData>();
			builder.RegisterType<VendorWarrantyListViewModel>().AsSelf<VendorWarrantyListViewModel, ConcreteReflectionActivatorData>();
			builder.RegisterType<VendorSelectViewModel>().AsSelf<VendorSelectViewModel, ConcreteReflectionActivatorData>();
			builder.RegisterType<OrderCancellationViewModel>().AsSelf<OrderCancellationViewModel, ConcreteReflectionActivatorData>();
			builder.RegisterType<AdditionalFieldEditViewModel>().AsSelf<AdditionalFieldEditViewModel, ConcreteReflectionActivatorData>();
			builder.RegisterType<AdditionalFieldsListViewModel>().AsSelf<AdditionalFieldsListViewModel, ConcreteReflectionActivatorData>();
			builder.RegisterType<CompaniesViewModel>().Named<IOfficesViewModel>("CompaniesViewModel").As<IOfficesViewModel>();
			builder.RegisterType<OfficesViewModel>().Named<IOfficesViewModel>("OfficesViewModel").As<IOfficesViewModel>();
			builder.RegisterType<CompanyPaymentDetailsViewModel>().Named<IOfficesViewModel>("CompanyPaymentDetailsViewModel").As<IOfficesViewModel>();
			builder.RegisterType<OfficeEditViewModel>().Named<IPopupViewModel>("OfficeEditViewModel").As<IPopupViewModel>();
			builder.RegisterType<CompanyEditViewModel>();
			builder.RegisterType<CloudVoIPViewModel>().AsSelf<CloudVoIPViewModel, ConcreteReflectionActivatorData>();
			builder.RegisterType<InformSettingsViewModel>().AsSelf<InformSettingsViewModel, ConcreteReflectionActivatorData>();
			builder.RegisterType<CustomerHistoryViewModel>();
			builder.RegisterType<CustomerBalanceViewModel>();
			builder.RegisterType<CustomerRepairsViewModel>();
			builder.RegisterType<CustomerFinancesViewModel>();
			builder.RegisterType<CustomerPurchasesViewModel>();
			builder.RegisterType<CustomerInvoicesViewModel>();
			builder.RegisterType<CustomerEditViewModel>();
			builder.RegisterType<CustomerPaymentDetailsViewModel>();
			builder.RegisterType<CustomerCallViewModel>().AsSelf<CustomerCallViewModel, ConcreteReflectionActivatorData>();
			builder.RegisterType<ProductEditViewModel>();
			builder.RegisterType<ProductDocumentsViewModel>();
			builder.RegisterType<ProductOverviewViewModel>();
			builder.RegisterType<ProductHistoryViewModel>();
			builder.RegisterType<PhotoViewAddModel>();
			builder.RegisterType<WiolinReportViewModel>();
			builder.RegisterType<ZnamenFinancesFlowReportViewModel>();
			builder.RegisterType<ASC.Charts.WithdrawFunds.WithdrawFundsViewModel>().AsSelf<ASC.Charts.WithdrawFunds.WithdrawFundsViewModel, ConcreteReflectionActivatorData>();
			builder.RegisterType<SalesChartViewModel>().AsSelf<SalesChartViewModel, ConcreteReflectionActivatorData>();
			builder.RegisterType<EmployeeHistoryViewModel>();
			builder.RegisterType<RepairSendSmsViewModel>();
			builder.RegisterType<StoreSelectViewModel>();
			builder.RegisterType<StoreCategorySelectViewModel>();
			builder.RegisterType<ProductsMoveViewModel>();
			builder.RegisterType<MoneyMoveViewModel>();
			builder.RegisterType<ItemCardViewModel>();
			builder.RegisterType<UpdateViewModel>();
			builder.RegisterType<ItemsBuyoutViewModel>();
			builder.RegisterType<CartridgeCardsEditorViewModel>();
			builder.RegisterType<ASC.ViewModels.WithdrawFundsViewModel>();
			builder.RegisterType<KassaSaldoViewModel>().AsSelf<KassaSaldoViewModel, ConcreteReflectionActivatorData>();
			builder.RegisterType<KassaBalanceViewModel>().AsSelf<KassaBalanceViewModel, ConcreteReflectionActivatorData>();
			builder.RegisterType<PriceWorksCategoryViewModel>();
			builder.RegisterType<NotificationsPanelViewModel>();
			builder.RegisterType<WorkspaceV2ViewModel>().AsSelf<WorkspaceV2ViewModel, ConcreteReflectionActivatorData>();
			builder.RegisterType<NewInvoiceViewModel>().AsSelf<NewInvoiceViewModel, ConcreteReflectionActivatorData>();
			builder.RegisterType<PackingListViewModel>().AsSelf<PackingListViewModel, ConcreteReflectionActivatorData>();
			builder.RegisterType<NewVATInvoiceViewModel>().AsSelf<NewVATInvoiceViewModel, ConcreteReflectionActivatorData>();
			builder.RegisterType<WorksListViewModel>().AsSelf<WorksListViewModel, ConcreteReflectionActivatorData>();
			builder.RegisterType<PriceWorksViewModel>().AsSelf<PriceWorksViewModel, ConcreteReflectionActivatorData>();
			builder.RegisterType<LicenseExpirationViewModel>().As<ILicenseExpirationViewModel>();
			builder.RegisterType<AddCustomerViewModel>();
			builder.RegisterType<NewRepairViewModel>();
			builder.RegisterType<RepairBoxViewModel>().AsSelf<RepairBoxViewModel, ConcreteReflectionActivatorData>();
			builder.RegisterType<StocktakingViewModel>();
			builder.RegisterType<CustomerSearchViewModel>().As<ICustomerSearchViewModel>();
			builder.RegisterType<NewCartridgeViewModel>().AsSelf<NewCartridgeViewModel, ConcreteReflectionActivatorData>();
			builder.RegisterType<CartringeArticulSearchViewModel>().AsSelf<CartringeArticulSearchViewModel, ConcreteReflectionActivatorData>();
			builder.RegisterType<CartridgeCardViewModel>().AsSelf<CartridgeCardViewModel, ConcreteReflectionActivatorData>();
			builder.RegisterType<CartridgeIssueViewModel>().AsSelf<CartridgeIssueViewModel, ConcreteReflectionActivatorData>();
			builder.RegisterType<StatusCheckViewModel>().AsSelf<StatusCheckViewModel, ConcreteReflectionActivatorData>();
			builder.RegisterType<WorkshopStatusByUserViewModel>().AsSelf<WorkshopStatusByUserViewModel, ConcreteReflectionActivatorData>();
			builder.RegisterType<RepairMassEditViewModel>().AsSelf<RepairMassEditViewModel, ConcreteReflectionActivatorData>();
			builder.RegisterType<AutoAssignSettingsViewModel>().AsSelf<AutoAssignSettingsViewModel, ConcreteReflectionActivatorData>();
			builder.RegisterType<PkoViewModel>().As<IKoViewModel>().Keyed<IKoViewModel>("PKO");
			builder.RegisterType<RkoViewModel>().As<IKoViewModel>().Keyed<IKoViewModel>("RKO");
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000043D4 File Offset: 0x000025D4
		private static void RegisterServices(ContainerBuilder builder)
		{
			builder.RegisterGeneric(typeof(LoggerService<>)).As(new System.Type[]
			{
				typeof(ILoggerService<>)
			}).InstancePerDependency();
			builder.RegisterType<CompanyService>().As<ICompanyService>();
			builder.RegisterType<HookService>().As<IHookService>();
			builder.RegisterType<BoxService>().As<IBoxService>();
			builder.RegisterType<BuyoutService>().As<IBuyoutService>();
			builder.RegisterType<ReportTemplateService>().As<IReportTemplateService>();
			builder.RegisterType<LicenseService>().As<ILicenseService>();
			builder.RegisterType<WorkshopService>().As<IWorkshopService>();
			builder.RegisterType<WorkshopWorkService>().As<IWorkshopWorkService>();
			builder.RegisterType<WorkshopPartService>().As<IWorkshopPartService>();
			builder.RegisterType<UserActivityService>().As<IUserActivityService>().SingleInstance();
			builder.RegisterType<AuthService>().As<IAuthService>().SingleInstance();
			builder.RegisterType<CartridgeService>().As<ICartridgeService>();
			builder.RegisterType<CustomerService>().As<ICustomerService>();
			builder.RegisterType<StoreService>().As<IStoreService>();
			builder.RegisterType<ProductService>().As<IProductService>();
			builder.RegisterType<OrderService>().As<IOrderService>();
			builder.RegisterType<ImageService>().As<IImageService>();
			builder.RegisterType<PaymentSystemService>().As<IPaymentSystemService>();
			builder.RegisterType<EmployeeService>().As<IEmployeeService>();
			builder.RegisterType<CashOrderService>().As<ICashOrderService>();
			builder.RegisterType<SoundService>().As<ISoundService>();
			builder.RegisterType<CallService>().As<ICallService>();
			builder.RegisterType<SmsService>().As<ISmsService>();
			builder.RegisterType<VendorService>().As<IVendorService>();
			builder.RegisterType<WorkshopPriceService>().As<IWorkshopPriceService>();
			builder.RegisterType<OfficeService>().As<IOfficeService>();
			builder.RegisterType<InvoiceService>().As<IInvoiceService>();
			builder.RegisterType<KassaService>().As<IKassaService>();
			builder.RegisterType<DeviceModelService>().As<IDeviceModelService>();
			builder.RegisterType<CartridgeCardService>().As<ICartridgeCardService>();
			builder.RegisterType<TaskService>().As<ITaskService>();
			builder.RegisterType<AdditionalPaymentsService>().As<IAdditionalPaymentsService>();
			builder.RegisterType<ReportsService>().As<IReportsService>();
			builder.RegisterType<PriceListService>().As<IPriceListService>();
			builder.RegisterType<PriceEditorService>().As<IPriceEditorService>();
			builder.RegisterType<ReportPrintService>().As<IReportPrintService>();
			builder.RegisterType<RepairReportEmailService>().As<IRepairReportEmailService>();
			builder.RegisterType<RolesService>().As<IRolesService>();
			builder.RegisterType<WorkshopStatusService>().As<IWorkshopStatusService>();
			builder.RegisterType<WorkshopHistoryService>().As<IWorkshopHistoryService>();
			builder.RegisterType<RepairStatusLogsService>().As<IRepairStatusLogsService>();
			builder.RegisterType<SeedData>().As<ISeedData>();
			builder.RegisterType<IntCommentsService>().As<IIntCommentsService>();
			builder.RegisterType<MasterAutoAssignService>().As<IMasterAutoAssignService>();
			builder.RegisterType<PartsRequestService>().As<IPartsRequestService>();
			builder.RegisterType<TelService>().As<ITelService>();
			builder.RegisterType<NotificationService>().As<INotificationService>();
			builder.RegisterType<NavigationService>().As<INavigationService>().SingleInstance();
			builder.RegisterType<ToasterService>().As<IToasterService>().SingleInstance();
			builder.RegisterType<WindowedDocumentService>().As<IWindowedDocumentService>().SingleInstance();
			builder.RegisterType<WaitIndicatorService>().As<IWaitIndicatorService>().SingleInstance();
			builder.RegisterType<AscMessageBoxService>().As<IAscMessageBoxService>().SingleInstance();
			builder.RegisterType<SettingsService>().As<ISettingsService>().SingleInstance();
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000046B4 File Offset: 0x000028B4
		public Bootstrapper()
		{
		}

		// Token: 0x04000030 RID: 48
		[CompilerGenerated]
		private static IContainer <Container>k__BackingField;
	}
}
