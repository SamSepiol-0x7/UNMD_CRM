using System;

namespace ASC.Services.Abstract
{
	// Token: 0x020007F1 RID: 2033
	public interface INavigationReportsService
	{
		// Token: 0x06003CC9 RID: 15561
		void NavigateRepairStatusesReport();

		// Token: 0x06003CCA RID: 15562
		void NavigateMastersReport();

		// Token: 0x06003CCB RID: 15563
		void NavigateFinancesReport();

		// Token: 0x06003CCC RID: 15564
		void NavigateStatusCheckReport();

		// Token: 0x06003CCD RID: 15565
		void NavigateEmployeesActivityReport();

		// Token: 0x06003CCE RID: 15566
		void NavigateProductsReport();

		// Token: 0x06003CCF RID: 15567
		void NavigateProductSalesReport();

		// Token: 0x06003CD0 RID: 15568
		void NavigateFinancesFlowReport();

		// Token: 0x06003CD1 RID: 15569
		void NavigateZnamenFinancesFlowReport();

		// Token: 0x06003CD2 RID: 15570
		void NavigateWiolinReport();

		// Token: 0x06003CD3 RID: 15571
		void NavigateSalesByCategoryReport();

		// Token: 0x06003CD4 RID: 15572
		void NavigateVisitSourceReport();

		// Token: 0x06003CD5 RID: 15573
		void NavigateRepairsChart();

		// Token: 0x06003CD6 RID: 15574
		void NavigateCallsReport();

		// Token: 0x06003CD7 RID: 15575
		void NavigateCallConversionReport();

		// Token: 0x06003CD8 RID: 15576
		void NavigateBoxesReport();
	}
}
