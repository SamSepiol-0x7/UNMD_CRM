using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASC.Common.Interfaces;

namespace ASC.Services.Abstract
{
	// Token: 0x020007FC RID: 2044
	public interface IReportsService
	{
		// Token: 0x06003D40 RID: 15680
		Task<IList<cash_orders>> LoadWithdrawFundsTableData(IPeriod period, int officeId);
	}
}
