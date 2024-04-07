using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASC.Common.Interfaces;

namespace ASC.Interfaces
{
	// Token: 0x02000B2B RID: 2859
	public interface ICashOrderService
	{
		// Token: 0x06005091 RID: 20625
		Task<List<cash_orders>> GetCashOrders(IPeriod period, int paymentSystemId);
	}
}
