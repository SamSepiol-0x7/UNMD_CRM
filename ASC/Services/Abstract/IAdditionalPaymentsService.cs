using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASC.Services.Abstract
{
	// Token: 0x020007E4 RID: 2020
	public interface IAdditionalPaymentsService
	{
		// Token: 0x06003C94 RID: 15508
		Task<IList<additional_payments>> ClearEmployeesProfit(int repairId);
	}
}
