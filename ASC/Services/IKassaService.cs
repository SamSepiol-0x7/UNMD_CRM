using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Common.SimpleClasses;
using ASC.Objects;
using ASC.SimpleClasses;

namespace ASC.Services
{
	// Token: 0x020005D1 RID: 1489
	public interface IKassaService
	{
		// Token: 0x06003702 RID: 14082
		Task<decimal> GetCashSaldo(IPeriod period, int companyId, int officeId);

		// Token: 0x06003703 RID: 14083
		Task<decimal> GetCashlessSaldo(IPeriod period, int companyId, int officeId);

		// Token: 0x06003704 RID: 14084
		Task<Saldo> GetThisMonthSaldo(int companyId, int officeId);

		// Token: 0x06003705 RID: 14085
		Task<CashInOrder> GetCashInOrderAsync(int orderId);

		// Token: 0x06003706 RID: 14086
		Task<CashOutOrder> GetCashOutOrderAsync(int orderId);

		// Token: 0x06003707 RID: 14087
		Task<cash_orders> GetCashOrderAsync(int cashOrderId);

		// Token: 0x06003708 RID: 14088
		Task<List<CashOrdersLite>> LoadOrdersAsync(int companyId, int office, Period period, int orderType, int paymentSystem, string searchQuery);

		// Token: 0x06003709 RID: 14089
		Task<decimal> GetCashBalanceAsync(IPeriod period, int companyId, int officeId);

		// Token: 0x0600370A RID: 14090
		Task<decimal> GetCashLessBalanceAsync(IPeriod period, int companyId, int officeId);

		// Token: 0x0600370B RID: 14091
		Task<decimal> GetCardBalanceAsync(IPeriod period, int companyId, int officeId);
	}
}
