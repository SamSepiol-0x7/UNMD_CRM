using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Threading;
using ASC.Calls;
using ASC.Charts.CallConversions;
using ASC.Charts.CallsChart;
using ASC.Charts.Masters;
using ASC.Charts.PartsChart;
using ASC.Charts.RepairStatuses;
using ASC.Charts.SalesCategoriesChart;
using ASC.Charts.SalesChart;
using ASC.Charts.VisitSource;
using ASC.Clients;
using ASC.Documents;
using ASC.Invoice;
using ASC.ItemsArrival;
using ASC.ItemsBuyout;
using ASC.ItemsExport;
using ASC.ItemsSale;
using ASC.Kassa;
using ASC.NewRepair;
using ASC.Objects;
using ASC.Options;
using ASC.PartsRequest;
using ASC.PKO;
using ASC.PriceEditor;
using ASC.PriceWorks;
using ASC.RepairCard;
using ASC.RepairsChart;
using ASC.RequestsManager;
using ASC.RKO;
using ASC.Salary;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using ASC.Stocktaking;
using ASC.StoreManagement;
using ASC.StoreSimple;
using ASC.TaskManager;
using ASC.View;
using ASC.View.Charts;
using ASC.View.CustomerCard;
using ASC.View.Repair;
using ASC.ViewModel;
using ASC.ViewModels;
using ASC.ViewModels.Charts;
using ASC.Workspace.Repairs;
using Autofac;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Xpf.Docking;

namespace ASC.Services.Concrete
{
	// Token: 0x02000735 RID: 1845
	public class NavigationService : ISupportParentViewModel, ISupportServices, INavigationReportsService, ASC.Services.Abstract.INavigationService
	{
		// Token: 0x1700109F RID: 4255
		// (get) Token: 0x06003A73 RID: 14963 RVA: 0x000E00F4 File Offset: 0x000DE2F4
		// (set) Token: 0x06003A74 RID: 14964 RVA: 0x000E0108 File Offset: 0x000DE308
		public object ParentViewModel
		{
			[CompilerGenerated]
			get
			{
				return this.<ParentViewModel>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ParentViewModel>k__BackingField = value;
			}
		}

		// Token: 0x170010A0 RID: 4256
		// (get) Token: 0x06003A75 RID: 14965 RVA: 0x000E011C File Offset: 0x000DE31C
		protected IDocumentManagerService TabbedService
		{
			get
			{
				return this.GetService("TabbedService");
			}
		}

		// Token: 0x06003A76 RID: 14966 RVA: 0x000E0134 File Offset: 0x000DE334
		public NavigationService(IUserActivityService userActivityService)
		{
			this._userActivityService = userActivityService;
		}

		// Token: 0x06003A77 RID: 14967 RVA: 0x000E0150 File Offset: 0x000DE350
		public void NavigateRepairCartridges(List<int> ids)
		{
			this.CreateTab(typeof(RepairCartridgeView).FullName, new RepairCartridgeViewModel(ids), null);
		}

		// Token: 0x06003A78 RID: 14968 RVA: 0x000E017C File Offset: 0x000DE37C
		public void NavigateRepairCartridge(int repairId)
		{
			this.CreateTab(typeof(RepairCartridgeView).FullName, new RepairCartridgeViewModel(repairId), null);
		}

		// Token: 0x06003A79 RID: 14969 RVA: 0x000E01A8 File Offset: 0x000DE3A8
		public void NavigateCartridgeCardsEditor()
		{
			this.CreateTab(typeof(CartridgeCardsEditorView).FullName, Bootstrapper.Container.Resolve<CartridgeCardsEditorViewModel>(), null);
		}

		// Token: 0x06003A7A RID: 14970 RVA: 0x000E01D8 File Offset: 0x000DE3D8
		public void NavigateNewCartridge()
		{
			this.CreateTab(typeof(NewCartridgeView).FullName, Bootstrapper.Container.Resolve<NewCartridgeViewModel>(), null);
		}

		// Token: 0x06003A7B RID: 14971 RVA: 0x000E0208 File Offset: 0x000DE408
		public void NavigateSmsList()
		{
			this.CreateTab(typeof(SmsListView).FullName, new SmsListViewModel(), null);
		}

		// Token: 0x06003A7C RID: 14972 RVA: 0x000E0230 File Offset: 0x000DE430
		public void NavigateItemsBuyout()
		{
			this.CreateTab(typeof(ItemsBuyoutView).FullName, Bootstrapper.Container.Resolve<ItemsBuyoutViewModel>(), null);
		}

		// Token: 0x06003A7D RID: 14973 RVA: 0x000E0260 File Offset: 0x000DE460
		public void NavigateSalesByCategoryReport()
		{
			this.CreateTab(typeof(SalesCategoriesChartView).FullName, new SalesCategoriesChartViewModel(), null);
		}

		// Token: 0x06003A7E RID: 14974 RVA: 0x000E0288 File Offset: 0x000DE488
		public void NavigateWiolinReport()
		{
			this.CreateTab(typeof(WiolinReportView).FullName, Bootstrapper.Container.Resolve<WiolinReportViewModel>(), null);
		}

		// Token: 0x06003A7F RID: 14975 RVA: 0x000E02B8 File Offset: 0x000DE4B8
		public void NavigateZnamenFinancesFlowReport()
		{
			this.CreateTab(typeof(ZnamenFinancesFlowReportView).FullName, Bootstrapper.Container.Resolve<ZnamenFinancesFlowReportViewModel>(), null);
		}

		// Token: 0x06003A80 RID: 14976 RVA: 0x000E02E8 File Offset: 0x000DE4E8
		public void NavigateFinancesFlowReport()
		{
			this.CreateTab(typeof(FinancesFlowReportView).FullName, new FinancesFlowReportViewModel(), null);
		}

		// Token: 0x06003A81 RID: 14977 RVA: 0x000E0310 File Offset: 0x000DE510
		public void NavigateProductSalesReport()
		{
			this.CreateTab(typeof(SalesChartView).FullName, Bootstrapper.Container.Resolve<SalesChartViewModel>(), null);
		}

		// Token: 0x06003A82 RID: 14978 RVA: 0x000E0340 File Offset: 0x000DE540
		public void NavigateProductsReport()
		{
			this.CreateTab(typeof(PartsChartView).FullName, new PartsChartViewModel(), null);
		}

		// Token: 0x06003A83 RID: 14979 RVA: 0x000E0368 File Offset: 0x000DE568
		public void NavigateEmployeesActivityReport()
		{
			this.CreateTab(typeof(EmployeesActivityChartView).FullName, Bootstrapper.Container.Resolve<EmployeesActivityChartViewModel>(), null);
		}

		// Token: 0x06003A84 RID: 14980 RVA: 0x000E0398 File Offset: 0x000DE598
		public void NavigateStatusCheckReport()
		{
			this.CreateTab(typeof(StatusCheckView).FullName, Bootstrapper.Container.Resolve<StatusCheckViewModel>(), null);
		}

		// Token: 0x06003A85 RID: 14981 RVA: 0x000E03C8 File Offset: 0x000DE5C8
		public void NavigateFinancesReport()
		{
			this.CreateTab(typeof(FinancesChartView).FullName, new FinancesChartViewModel(), null);
		}

		// Token: 0x06003A86 RID: 14982 RVA: 0x000E03F0 File Offset: 0x000DE5F0
		public void NavigateRequestsManager()
		{
			this.CreateTab(typeof(RequestsManagerView).FullName, new RequestsManagerViewModel(), null);
		}

		// Token: 0x06003A87 RID: 14983 RVA: 0x000E0418 File Offset: 0x000DE618
		public void NavigateRepairMassEdit()
		{
			this.CreateTab(typeof(RepairMassEditView).FullName, Bootstrapper.Container.Resolve<RepairMassEditViewModel>(), null);
		}

		// Token: 0x06003A88 RID: 14984 RVA: 0x000E0448 File Offset: 0x000DE648
		public void NavigateCallConversionReport()
		{
			this.CreateTab(typeof(CallConversionsView).FullName, new CallConversionsViewModel(), null);
		}

		// Token: 0x06003A89 RID: 14985 RVA: 0x000E0470 File Offset: 0x000DE670
		public void NavigateCallsReport()
		{
			this.CreateTab(typeof(CallsChartView).FullName, new CallsChartViewModel(), null);
		}

		// Token: 0x06003A8A RID: 14986 RVA: 0x000E0498 File Offset: 0x000DE698
		public void NavigateStoreManagement()
		{
			this.CreateTab(typeof(StoreManagementView).FullName, new StoreManagementViewModel(), null);
		}

		// Token: 0x06003A8B RID: 14987 RVA: 0x000E04C0 File Offset: 0x000DE6C0
		public void NavigateRepairStatusesReport()
		{
			this.CreateTab(typeof(RepairStatusesView).FullName, new RepairStatusesViewModel(), null);
		}

		// Token: 0x06003A8C RID: 14988 RVA: 0x000E04E8 File Offset: 0x000DE6E8
		public void NavigateStocktaking()
		{
			this.CreateTab(typeof(StocktakingView).FullName, Bootstrapper.Container.Resolve<StocktakingViewModel>(), null);
		}

		// Token: 0x06003A8D RID: 14989 RVA: 0x000E0518 File Offset: 0x000DE718
		public void NavigateProductsMassEditor()
		{
			this.CreateTab(typeof(PriceEditorView).FullName, new PriceEditorViewModel(), null);
		}

		// Token: 0x06003A8E RID: 14990 RVA: 0x000E0540 File Offset: 0x000DE740
		public void NavigateMastersReport()
		{
			this.CreateTab(typeof(MastersChartView).FullName, new MastersChartViewModel(), null);
		}

		// Token: 0x06003A8F RID: 14991 RVA: 0x000E0568 File Offset: 0x000DE768
		public void NavigateDocuments()
		{
			this.CreateTab(typeof(DocumentsView).FullName, new DocumentsViewModel(), null);
		}

		// Token: 0x06003A90 RID: 14992 RVA: 0x000E0590 File Offset: 0x000DE790
		public void NavigateNewRepair()
		{
			this.CreateTab(typeof(NewRepairView).FullName, Bootstrapper.Container.Resolve<NewRepairViewModel>(), null);
		}

		// Token: 0x06003A91 RID: 14993 RVA: 0x000E05C0 File Offset: 0x000DE7C0
		public void NavigateVisitSourceReport()
		{
			this.CreateTab(typeof(VisitSourceView).FullName, new VisitSourceViewModel(), null);
		}

		// Token: 0x06003A92 RID: 14994 RVA: 0x000E05E8 File Offset: 0x000DE7E8
		public void NavigateRepairsChart()
		{
			this.CreateTab(typeof(RepairsChartView).FullName, new RepairsChartViewModel(), null);
		}

		// Token: 0x06003A93 RID: 14995 RVA: 0x000E0610 File Offset: 0x000DE810
		public void NavigateCreateWorksList()
		{
			this.CreateTab(typeof(WorksListView).FullName, Bootstrapper.Container.Resolve<WorksListViewModel>(), null);
		}

		// Token: 0x06003A94 RID: 14996 RVA: 0x000E0640 File Offset: 0x000DE840
		public void NavigateCreatePackingList()
		{
			this.CreateTab("PackingListView", Bootstrapper.Container.Resolve<PackingListViewModel>(), null);
		}

		// Token: 0x06003A95 RID: 14997 RVA: 0x000E0664 File Offset: 0x000DE864
		public void NavigateCreateVATInvoice()
		{
			this.CreateTab(typeof(NewVATInvoiceView).FullName, new NewVATInvoiceViewModel(), null);
		}

		// Token: 0x06003A96 RID: 14998 RVA: 0x000E068C File Offset: 0x000DE88C
		public void NavigateInvoiceList()
		{
			this.CreateTab(typeof(InvoiceView).FullName, new InvoiceViewModel(), null);
		}

		// Token: 0x06003A97 RID: 14999 RVA: 0x000E06B4 File Offset: 0x000DE8B4
		public void NavigateProductsCatalogExport()
		{
			this.CreateTab(typeof(ItemsExportView).FullName, new ExportItemsViewModel(), null);
		}

		// Token: 0x06003A98 RID: 15000 RVA: 0x000E06DC File Offset: 0x000DE8DC
		public void NavigateSaleDocument(int documentId)
		{
			this.CreateTab(typeof(ItemsSaleView).FullName, new ItemsSaleViewModel(documentId), null);
		}

		// Token: 0x06003A99 RID: 15001 RVA: 0x000E0708 File Offset: 0x000DE908
		public void NavigateSaleProducts()
		{
			this.CreateTab(typeof(ItemsSaleView).FullName, new ItemsSaleViewModel(), null);
		}

		// Token: 0x06003A9A RID: 15002 RVA: 0x000E0730 File Offset: 0x000DE930
		public void NavigateItemsArrivalDocument(int documentId)
		{
			this.CreateTab(typeof(InItems).FullName, new ItemsArrivalViewModel(documentId), null);
		}

		// Token: 0x06003A9B RID: 15003 RVA: 0x000E075C File Offset: 0x000DE95C
		public void NavigateItemsArrival()
		{
			this.CreateTab(typeof(InItems).FullName, new ItemsArrivalViewModel(), null);
		}

		// Token: 0x06003A9C RID: 15004 RVA: 0x000E0784 File Offset: 0x000DE984
		public void NavigateServiceWorksPrice()
		{
			this.CreateTab(typeof(PriceWorksView).FullName, Bootstrapper.Container.Resolve<PriceWorksViewModel>(), null);
		}

		// Token: 0x06003A9D RID: 15005 RVA: 0x000E07B4 File Offset: 0x000DE9B4
		public void NavigateSalary()
		{
			this.CreateTab(typeof(SalaryView).FullName, new SalaryViewModel(), null);
		}

		// Token: 0x06003A9E RID: 15006 RVA: 0x000E07DC File Offset: 0x000DE9DC
		public void NavigateCreateInvoice(WorkshopLite order)
		{
			string itemName = Lang.t("Repair") + " " + order.DeviceOverview;
			NewInvoiceViewModel newInvoiceViewModel = Bootstrapper.Container.Resolve<NewInvoiceViewModel>();
			newInvoiceViewModel.SelectCustomerFromList(new Customer
			{
				Id = order.ClientId
			});
			newInvoiceViewModel.AddItem(itemName, 1, order.RealRepairCost, new int?(order.RepairId));
			this.CreateTab(typeof(NewInvoiceView).FullName, newInvoiceViewModel, null);
		}

		// Token: 0x06003A9F RID: 15007 RVA: 0x000E0858 File Offset: 0x000DEA58
		public void NavigateCreateInvoice()
		{
			this.CreateTab(typeof(NewInvoiceView).FullName, Bootstrapper.Container.Resolve<NewInvoiceViewModel>(), null);
		}

		// Token: 0x06003AA0 RID: 15008 RVA: 0x000E0888 File Offset: 0x000DEA88
		public void NavigateInvoice(int invoiceId)
		{
			NewInvoiceViewModel newInvoiceViewModel = Bootstrapper.Container.Resolve<NewInvoiceViewModel>();
			newInvoiceViewModel.SetDocumentIdToLoad(invoiceId);
			this.CreateTab(typeof(NewInvoiceView).FullName, newInvoiceViewModel, null);
		}

		// Token: 0x06003AA1 RID: 15009 RVA: 0x000E08C0 File Offset: 0x000DEAC0
		public void NavigateIncome()
		{
			this.CreateTab(typeof(PkoView).FullName, new PkoViewModel(), null);
		}

		// Token: 0x06003AA2 RID: 15010 RVA: 0x000E08E8 File Offset: 0x000DEAE8
		public void NavigateOutcome()
		{
			this.CreateTab(typeof(RkoView).FullName, new RkoViewModel(), null);
		}

		// Token: 0x06003AA3 RID: 15011 RVA: 0x000E0910 File Offset: 0x000DEB10
		public void NavigateBoxesReport()
		{
			this.CreateTab(typeof(BoxesReportView).FullName, new BoxesReportViewModel(), null);
		}

		// Token: 0x06003AA4 RID: 15012 RVA: 0x000E0938 File Offset: 0x000DEB38
		public void NavigateSettings()
		{
			this.CreateTab(typeof(ACPV2View).FullName, new ACPV2ViewModel(), null);
		}

		// Token: 0x06003AA5 RID: 15013 RVA: 0x000E0960 File Offset: 0x000DEB60
		public void NavigateCalls()
		{
			this.CreateTab(typeof(CallsView).FullName, new CallsViewModel(), null);
		}

		// Token: 0x06003AA6 RID: 15014 RVA: 0x000E0988 File Offset: 0x000DEB88
		public void NavigateTasks()
		{
			this.CreateTab(typeof(TaskManagerView).FullName, new TaskManagerViewModel(), null);
		}

		// Token: 0x06003AA7 RID: 15015 RVA: 0x000E09B0 File Offset: 0x000DEBB0
		public void NavigateRepairs()
		{
			this.CreateTab(typeof(RepairsView).FullName, new RepairsViewModel(), null);
		}

		// Token: 0x06003AA8 RID: 15016 RVA: 0x000E09D8 File Offset: 0x000DEBD8
		public void NavigateCustomers()
		{
			this.CreateTab(typeof(ClientsView).FullName, new ClientsViewModel(), null);
		}

		// Token: 0x06003AA9 RID: 15017 RVA: 0x000E0A00 File Offset: 0x000DEC00
		public void NavigateWorkshopStatusByUser()
		{
			this.CreateTab(typeof(WorkshopStatusByUserView).FullName, Bootstrapper.Container.Resolve<WorkshopStatusByUserViewModel>(), null);
		}

		// Token: 0x06003AAA RID: 15018 RVA: 0x000E0A30 File Offset: 0x000DEC30
		public void NavigateKassa()
		{
			this.CreateTab(typeof(KassaView).FullName, Bootstrapper.Container.Resolve<KassaViewModel>(), null);
		}

		// Token: 0x06003AAB RID: 15019 RVA: 0x000E0A60 File Offset: 0x000DEC60
		public void NavigateNewCustomerCall(string tel)
		{
			this.CreateTab(typeof(NewCustomerCallView).FullName, new NewCustomerCallViewModel(tel), null);
		}

		// Token: 0x06003AAC RID: 15020 RVA: 0x000E0A8C File Offset: 0x000DEC8C
		public void NavigateRequestCard(int buyPartRequestId)
		{
			this.CreateTab(typeof(RequestCardView).FullName, new RequestCardViewModel(buyPartRequestId), null);
		}

		// Token: 0x06003AAD RID: 15021 RVA: 0x000E0AB8 File Offset: 0x000DECB8
		public void NavigatePartsRequest(int requestId)
		{
			this.CreateTab(typeof(PartsRequestView).FullName, new PartsRequestViewModel(requestId), null);
		}

		// Token: 0x06003AAE RID: 15022 RVA: 0x000E0AE4 File Offset: 0x000DECE4
		public void NavigateSiteOrderTask(int taskId)
		{
			this.CreateTab(typeof(SiteOrderTaskView).FullName, SiteOrderTaskViewModel.Create(taskId), null);
		}

		// Token: 0x06003AAF RID: 15023 RVA: 0x000E0B10 File Offset: 0x000DED10
		public void NavigateRepairCard(int repairId)
		{
			this.CreateTab(typeof(RepairCardView).FullName, new RepairCardViewModel(repairId), null);
		}

		// Token: 0x06003AB0 RID: 15024 RVA: 0x000E0B3C File Offset: 0x000DED3C
		public void NavigateEmployeeTask(int taskId)
		{
			this.CreateTab(typeof(EmployeeTaskView).FullName, new EmployeeTaskViewModel(taskId), null);
		}

		// Token: 0x06003AB1 RID: 15025 RVA: 0x000E0B68 File Offset: 0x000DED68
		public void NavigateToCustomerCard(int customerId, object parentVm = null)
		{
			this.CreateTab(typeof(ClientCardView).FullName, new CustomerCardViewModel(customerId), parentVm);
		}

		// Token: 0x06003AB2 RID: 15026 RVA: 0x000E0B94 File Offset: 0x000DED94
		private void CreateTab(string view, IBaseViewModel viewModel, object parentVm = null)
		{
			if (this.TabbedService == null)
			{
				return;
			}
			if (OfflineData.Instance.Employee.TrackActivity)
			{
				IUserActivityService userActivityService = this._userActivityService;
				string str = "Navigation ";
				IBaseViewModel viewModel2 = viewModel;
				userActivityService.AddActivity(str + ((viewModel2 != null) ? viewModel2.ViewName : null));
			}
			IDocument document = this.TabbedService.Documents.FirstOrDefault((IDocument d) => d.Title != null && d.Title.ToString() == viewModel.ViewName);
			if (document == null)
			{
				TabbedDocumentUIService service = null;
				int selectedTabIndex = -1;
				if (this.TabbedService is TabbedDocumentUIService)
				{
					service = (this.TabbedService as TabbedDocumentUIService);
					selectedTabIndex = service.ActualDocumentGroup.SelectedTabIndex;
				}
				IDocument document2 = this.TabbedService.CreateDocument(view, viewModel, null, parentVm ?? this.ParentViewModel);
				document2.Id = "TabId_" + Generators.RandomString(6, "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789");
				document2.Title = viewModel.ViewName;
				document2.DestroyOnClose = true;
				if (service != null && service.ActualDocumentGroup.Items.Count > 2 && selectedTabIndex < service.ActualDocumentGroup.Items.Count - 2)
				{
					Dispatcher.CurrentDispatcher.BeginInvoke(new Action(delegate()
					{
						service.ActualDocumentGroup.Items.Move(service.ActualDocumentGroup.SelectedTabIndex, selectedTabIndex + 1);
					}), new object[0]);
				}
				viewModel.TabId = document2.Id.ToString();
				document2.Show();
				return;
			}
			document.Show();
		}

		// Token: 0x06003AB3 RID: 15027 RVA: 0x000E0D28 File Offset: 0x000DEF28
		public void UpdateTabTitle(string tabId, string title)
		{
			if (string.IsNullOrEmpty(tabId))
			{
				return;
			}
			IDocument document = this.TabbedService.Documents.FirstOrDefault((IDocument d) => d.Id.ToString() == tabId);
			if (document != null)
			{
				document.Title = title;
			}
		}

		// Token: 0x170010A1 RID: 4257
		// (get) Token: 0x06003AB4 RID: 15028 RVA: 0x000E0D78 File Offset: 0x000DEF78
		protected IServiceContainer ServiceContainer
		{
			get
			{
				if (this.serviceContainer == null)
				{
					this.serviceContainer = new ServiceContainer(this);
				}
				return this.serviceContainer;
			}
		}

		// Token: 0x170010A2 RID: 4258
		// (get) Token: 0x06003AB5 RID: 15029 RVA: 0x000E0DA0 File Offset: 0x000DEFA0
		IServiceContainer ISupportServices.ServiceContainer
		{
			get
			{
				return this.ServiceContainer;
			}
		}

		// Token: 0x06003AB6 RID: 15030 RVA: 0x000E0DB4 File Offset: 0x000DEFB4
		public void CloseTabByName(string name)
		{
			if (this.TabbedService != null)
			{
				Application.Current.Dispatcher.BeginInvoke(new Action(delegate()
				{
					IDocument document = this.TabbedService.Documents.FirstOrDefault((IDocument d) => d.Title.ToString() == name);
					if (document == null)
					{
						return;
					}
					document.Close(true);
				}), new object[0]);
				return;
			}
		}

		// Token: 0x06003AB7 RID: 15031 RVA: 0x000E0E00 File Offset: 0x000DF000
		public void CloseCurrentTab()
		{
			if (this.TabbedService == null)
			{
				goto IL_40;
			}
			IL_08:
			IDocument activeDocument = this.TabbedService.ActiveDocument;
			if (activeDocument == null)
			{
				return;
			}
			activeDocument.Close(true);
			int num = 1596009534;
			IL_21:
			switch ((num ^ 1467943364) % 4)
			{
			case 0:
				IL_40:
				num = 844684313;
				goto IL_21;
			case 1:
				return;
			case 3:
				goto IL_08;
			}
		}

		// Token: 0x06003AB8 RID: 15032 RVA: 0x000E0E58 File Offset: 0x000DF058
		public void SetTabHeader(string resourceName, int id)
		{
			this.SetTabHeader(resourceName, string.Format("{0:D6}", id));
		}

		// Token: 0x06003AB9 RID: 15033 RVA: 0x000E0E7C File Offset: 0x000DF07C
		public void SetTabHeader(string resourceName, string text)
		{
			this.TabbedService.ActiveDocument.Title = Lang.t(resourceName) + " " + text;
		}

		// Token: 0x06003ABA RID: 15034 RVA: 0x000E0EAC File Offset: 0x000DF0AC
		public void NavigateToStore()
		{
			if (OfflineData.Instance.Employee.GroupByArticul)
			{
				this.CreateTab("ASC.View.StoreView", new StoreViewModel(), null);
				return;
			}
			this.CreateTab("StoreV2View", new StoreSimpleViewModel(), null);
		}

		// Token: 0x06003ABB RID: 15035 RVA: 0x000E0EF0 File Offset: 0x000DF0F0
		public void NavigateToStore(StoreViewModel.ReturnAction action, int repairId, bool warrantyRepair, object parentVm = null)
		{
			if (!OfflineData.Instance.Employee.GroupByArticul)
			{
				goto IL_35;
			}
			IL_11:
			int num = -1224389111;
			IL_16:
			switch ((num ^ -990617850) % 4)
			{
			case 0:
				IL_35:
				this.CreateTab("StoreV2View", new StoreSimpleViewModel(action, repairId, warrantyRepair), parentVm);
				num = -1735872081;
				goto IL_16;
			case 2:
				goto IL_11;
			case 3:
				this.CreateTab("ASC.View.StoreView", new StoreViewModel(action, repairId, warrantyRepair), parentVm);
				return;
			}
		}

		// Token: 0x06003ABC RID: 15036 RVA: 0x000E0F64 File Offset: 0x000DF164
		public void NavigateToStore(bool returnOnSelect, ItemsOptions.opName opt, object parentVm = null)
		{
			if (OfflineData.Instance.Employee.GroupByArticul)
			{
				this.CreateTab("ASC.View.StoreView", new StoreViewModel(returnOnSelect, (int)opt), parentVm);
				return;
			}
			this.CreateTab("StoreV2View", new StoreSimpleViewModel(returnOnSelect, (int)opt), parentVm);
		}

		// Token: 0x06003ABD RID: 15037 RVA: 0x000E0FAC File Offset: 0x000DF1AC
		public void NavigateToStoreItem(int itemId, int tab = 0)
		{
			this.CreateTab("ItemCardView", new ItemCardViewModel(itemId, tab), null);
		}

		// Token: 0x06003ABE RID: 15038 RVA: 0x000E0FCC File Offset: 0x000DF1CC
		public void Navigate(string view, IBaseViewModel viewModel, object parentViewModel)
		{
			this.CreateTab(view, viewModel, parentViewModel);
		}

		// Token: 0x06003ABF RID: 15039 RVA: 0x000E0FE4 File Offset: 0x000DF1E4
		public object CurrentTabViewModelOrNull()
		{
			IDocument activeDocument = this.TabbedService.ActiveDocument;
			if (activeDocument == null)
			{
				return null;
			}
			return activeDocument.Content;
		}

		// Token: 0x06003AC0 RID: 15040 RVA: 0x000E1008 File Offset: 0x000DF208
		public void Navigate(string view, IBaseViewModel viewModel)
		{
			this.CreateTab(view, viewModel, null);
		}

		// Token: 0x04002576 RID: 9590
		private readonly IUserActivityService _userActivityService;

		// Token: 0x04002577 RID: 9591
		[CompilerGenerated]
		private object <ParentViewModel>k__BackingField;

		// Token: 0x04002578 RID: 9592
		private IServiceContainer serviceContainer;

		// Token: 0x02000736 RID: 1846
		[CompilerGenerated]
		private sealed class <>c__DisplayClass67_0
		{
			// Token: 0x06003AC1 RID: 15041 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass67_0()
			{
			}

			// Token: 0x06003AC2 RID: 15042 RVA: 0x000E1020 File Offset: 0x000DF220
			internal bool <CreateTab>b__0(IDocument d)
			{
				return d.Title != null && d.Title.ToString() == this.viewModel.ViewName;
			}

			// Token: 0x06003AC3 RID: 15043 RVA: 0x000E1054 File Offset: 0x000DF254
			internal void <CreateTab>b__1()
			{
				this.service.ActualDocumentGroup.Items.Move(this.service.ActualDocumentGroup.SelectedTabIndex, this.selectedTabIndex + 1);
			}

			// Token: 0x04002579 RID: 9593
			public IBaseViewModel viewModel;

			// Token: 0x0400257A RID: 9594
			public TabbedDocumentUIService service;

			// Token: 0x0400257B RID: 9595
			public int selectedTabIndex;
		}

		// Token: 0x02000737 RID: 1847
		[CompilerGenerated]
		private sealed class <>c__DisplayClass68_0
		{
			// Token: 0x06003AC4 RID: 15044 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass68_0()
			{
			}

			// Token: 0x06003AC5 RID: 15045 RVA: 0x000E1090 File Offset: 0x000DF290
			internal bool <UpdateTabTitle>b__0(IDocument d)
			{
				return d.Id.ToString() == this.tabId;
			}

			// Token: 0x0400257C RID: 9596
			public string tabId;
		}

		// Token: 0x02000738 RID: 1848
		[CompilerGenerated]
		private sealed class <>c__DisplayClass74_0
		{
			// Token: 0x06003AC6 RID: 15046 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass74_0()
			{
			}

			// Token: 0x06003AC7 RID: 15047 RVA: 0x000E10B4 File Offset: 0x000DF2B4
			internal void <CloseTabByName>b__0()
			{
				IDocument document = this.<>4__this.TabbedService.Documents.FirstOrDefault((IDocument d) => d.Title.ToString() == this.name);
				if (document == null)
				{
					return;
				}
				document.Close(true);
			}

			// Token: 0x06003AC8 RID: 15048 RVA: 0x000E10F0 File Offset: 0x000DF2F0
			internal bool <CloseTabByName>b__1(IDocument d)
			{
				return d.Title.ToString() == this.name;
			}

			// Token: 0x0400257D RID: 9597
			public NavigationService <>4__this;

			// Token: 0x0400257E RID: 9598
			public string name;
		}
	}
}
