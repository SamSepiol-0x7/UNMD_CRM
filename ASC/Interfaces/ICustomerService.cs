using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Common.Models;
using ASC.Objects;
using ASC.SimpleClasses;

namespace ASC.Interfaces
{
	// Token: 0x02000B2D RID: 2861
	public interface ICustomerService
	{
		// Token: 0x06005095 RID: 20629
		Task<IEnumerable<ICustomer>> GetCustomers(int clientType, int visitSource, string query, bool showArchive = false);

		// Token: 0x06005096 RID: 20630
		Task<clients> GetByEmail(string email);

		// Token: 0x06005097 RID: 20631
		Task<List<clients>> GetCustomersAsync();

		// Token: 0x06005098 RID: 20632
		Task<clients> GetCustomerAsync(int customerId);

		// Token: 0x06005099 RID: 20633
		Task<ICustomer> GetCustomerCardAsync(int customerId);

		// Token: 0x0600509A RID: 20634
		Task<List<tel>> GetPhonesAsync(int customerId);

		// Token: 0x0600509B RID: 20635
		Task<IEnumerable<logs>> GetHistory(int customerId, IPeriod period);

		// Token: 0x0600509C RID: 20636
		Task<IEnumerable<balance>> GetBalanceDetails(int customerId);

		// Token: 0x0600509D RID: 20637
		Task<List<CashOrdersLite>> GetOrders(int customerId);

		// Token: 0x0600509E RID: 20638
		Task<IEnumerable<Invoice>> GetInvoices(int customerId, IPeriod period);

		// Token: 0x0600509F RID: 20639
		void SaveCustomer(CustomerCard c);

		// Token: 0x060050A0 RID: 20640
		Task<int> CreatePaymentDetailsAsync(IPaymentDetails details);

		// Token: 0x060050A1 RID: 20641
		Task<IEnumerable<PaymentDetails>> GetPaymentDetailsAsync(int customerId);

		// Token: 0x060050A2 RID: 20642
		Task<int> CreateCustomer(CustomerCard c);

		// Token: 0x060050A3 RID: 20643
		IEnumerable<ICustomerType> GetCustomerTypes();

		// Token: 0x060050A4 RID: 20644
		ICustomerType GetCustomerType(CustomerModel.Type type);

		// Token: 0x060050A5 RID: 20645
		Task<IEnumerable<workshop>> GetRepairs(int customerId, IPeriod period, int repairStatus);

		// Token: 0x060050A6 RID: 20646
		Task<IEnumerable<RepairCard>> GetActiveRepairs(int customerId);

		// Token: 0x060050A7 RID: 20647
		Task UpdateRepairsCount(int customerId);

		// Token: 0x060050A8 RID: 20648
		Task<int> CountRepairs(int customerId);

		// Token: 0x060050A9 RID: 20649
		Task<IEnumerable<store_sales>> GetPurchases(int customerId);

		// Token: 0x060050AA RID: 20650
		Task<int> CountPurchases(int customerId);
	}
}
