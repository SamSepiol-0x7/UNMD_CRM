using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using ASC.Common.Interfaces;

namespace ASC.ViewModels.Charts
{
	// Token: 0x0200050C RID: 1292
	public interface IFinancesFlowReport
	{
		// Token: 0x17000F17 RID: 3863
		// (get) Token: 0x060030B5 RID: 12469
		decimal Profit { get; }

		// Token: 0x17000F18 RID: 3864
		// (get) Token: 0x060030B6 RID: 12470
		decimal CurrentPeriodSalary { get; }

		// Token: 0x17000F19 RID: 3865
		// (get) Token: 0x060030B7 RID: 12471
		IFinancesFlowReportGroup Income { get; }

		// Token: 0x17000F1A RID: 3866
		// (get) Token: 0x060030B8 RID: 12472
		IFinancesFlowReportGroup Outcome { get; }

		// Token: 0x17000F1B RID: 3867
		// (get) Token: 0x060030B9 RID: 12473
		ObservableCollection<IFinancesFlowReportItem> Overview { get; }

		// Token: 0x17000F1C RID: 3868
		// (get) Token: 0x060030BA RID: 12474
		ObservableCollection<IFinancesFlowReportItem> Salary { get; }

		// Token: 0x060030BB RID: 12475
		Task LoadData();

		// Token: 0x060030BC RID: 12476
		void SetPeriod(IPeriod period);

		// Token: 0x060030BD RID: 12477
		void SetCompany(int companyId);

		// Token: 0x060030BE RID: 12478
		void SetOffice(int officeId);
	}
}
