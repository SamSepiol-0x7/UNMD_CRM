using System;
using System.Collections.Generic;
using ASC.Options;
using ASC.SimpleClasses;
using ASC.ViewModels;

namespace ASC.Services.Abstract
{
	// Token: 0x020007F2 RID: 2034
	public interface INavigationService : INavigationReportsService
	{
		// Token: 0x06003CD9 RID: 15577
		void NavigateEmployeeTask(int taskId);

		// Token: 0x06003CDA RID: 15578
		void NavigateSiteOrderTask(int taskId);

		// Token: 0x06003CDB RID: 15579
		void NavigatePartsRequest(int requestId);

		// Token: 0x06003CDC RID: 15580
		void NavigateRequestCard(int buyPartRequestId);

		// Token: 0x06003CDD RID: 15581
		void NavigateNewCustomerCall(string tel);

		// Token: 0x06003CDE RID: 15582
		void NavigateRepairCard(int repairId);

		// Token: 0x06003CDF RID: 15583
		void NavigateRepairs();

		// Token: 0x06003CE0 RID: 15584
		void NavigateToCustomerCard(int customerId, object parentVm = null);

		// Token: 0x06003CE1 RID: 15585
		void NavigateCustomers();

		// Token: 0x06003CE2 RID: 15586
		void NavigateTasks();

		// Token: 0x06003CE3 RID: 15587
		void NavigateCalls();

		// Token: 0x06003CE4 RID: 15588
		void NavigateSettings();

		// Token: 0x06003CE5 RID: 15589
		void NavigateOutcome();

		// Token: 0x06003CE6 RID: 15590
		void NavigateIncome();

		// Token: 0x06003CE7 RID: 15591
		void NavigateKassa();

		// Token: 0x06003CE8 RID: 15592
		void NavigateCreateInvoice();

		// Token: 0x06003CE9 RID: 15593
		void NavigateInvoice(int invoiceId);

		// Token: 0x06003CEA RID: 15594
		void NavigateCreateInvoice(WorkshopLite order);

		// Token: 0x06003CEB RID: 15595
		void NavigateSalary();

		// Token: 0x06003CEC RID: 15596
		void NavigateServiceWorksPrice();

		// Token: 0x06003CED RID: 15597
		void NavigateItemsArrival();

		// Token: 0x06003CEE RID: 15598
		void NavigateSaleProducts();

		// Token: 0x06003CEF RID: 15599
		void NavigateProductsCatalogExport();

		// Token: 0x06003CF0 RID: 15600
		void NavigateInvoiceList();

		// Token: 0x06003CF1 RID: 15601
		void NavigateSaleDocument(int documentId);

		// Token: 0x06003CF2 RID: 15602
		void NavigateItemsArrivalDocument(int documentId);

		// Token: 0x06003CF3 RID: 15603
		void NavigateCreateVATInvoice();

		// Token: 0x06003CF4 RID: 15604
		void NavigateCreatePackingList();

		// Token: 0x06003CF5 RID: 15605
		void NavigateCreateWorksList();

		// Token: 0x06003CF6 RID: 15606
		void NavigateNewRepair();

		// Token: 0x06003CF7 RID: 15607
		void NavigateDocuments();

		// Token: 0x06003CF8 RID: 15608
		void NavigateProductsMassEditor();

		// Token: 0x06003CF9 RID: 15609
		void NavigateStocktaking();

		// Token: 0x06003CFA RID: 15610
		void NavigateStoreManagement();

		// Token: 0x06003CFB RID: 15611
		void NavigateRequestsManager();

		// Token: 0x06003CFC RID: 15612
		void NavigateItemsBuyout();

		// Token: 0x06003CFD RID: 15613
		void NavigateSmsList();

		// Token: 0x06003CFE RID: 15614
		void NavigateNewCartridge();

		// Token: 0x06003CFF RID: 15615
		void NavigateCartridgeCardsEditor();

		// Token: 0x06003D00 RID: 15616
		void NavigateRepairCartridge(int repairId);

		// Token: 0x06003D01 RID: 15617
		void NavigateRepairCartridges(List<int> ids);

		// Token: 0x06003D02 RID: 15618
		void CloseTabByName(string name);

		// Token: 0x06003D03 RID: 15619
		void CloseCurrentTab();

		// Token: 0x06003D04 RID: 15620
		void SetTabHeader(string resourceName, int id);

		// Token: 0x06003D05 RID: 15621
		void SetTabHeader(string resourceName, string text);

		// Token: 0x06003D06 RID: 15622
		object CurrentTabViewModelOrNull();

		// Token: 0x06003D07 RID: 15623
		void NavigateToStore();

		// Token: 0x06003D08 RID: 15624
		void NavigateToStore(StoreViewModel.ReturnAction action, int repairId, bool warrantyRepair, object parentVm = null);

		// Token: 0x06003D09 RID: 15625
		void NavigateToStore(bool returnOnSelect, ItemsOptions.opName opt, object parentVm = null);

		// Token: 0x06003D0A RID: 15626
		void NavigateToStoreItem(int itemId, int tab = 0);

		// Token: 0x06003D0B RID: 15627
		void Navigate(string view, IBaseViewModel viewModel, object parentViewModel);

		// Token: 0x06003D0C RID: 15628
		void Navigate(string view, IBaseViewModel viewModel);

		// Token: 0x06003D0D RID: 15629
		void UpdateTabTitle(string tabId, string title);

		// Token: 0x06003D0E RID: 15630
		void NavigateWorkshopStatusByUser();

		// Token: 0x06003D0F RID: 15631
		void NavigateRepairMassEdit();
	}
}
