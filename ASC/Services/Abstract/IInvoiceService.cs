using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Objects;

namespace ASC.Services.Abstract
{
	// Token: 0x020007ED RID: 2029
	public interface IInvoiceService
	{
		// Token: 0x06003CB8 RID: 15544
		Task<IEnumerable<IInvoice>> GetInvoices(IPeriod period, int officeId, int state, string filter);

		// Token: 0x06003CB9 RID: 15545
		Task<Invoice> GetInvoice(int invoiceId);

		// Token: 0x06003CBA RID: 15546
		Task<IInvoiceLookup> GetInvoiceLookup(string invoiceNum, int year);

		// Token: 0x06003CBB RID: 15547
		Task<string> GetLastInvoiveId(int sellerId);

		// Token: 0x06003CBC RID: 15548
		IAscResult CreateWorksList(IWorksList doc);

		// Token: 0x06003CBD RID: 15549
		Task<IWorksList> GetWorksList(int invoiceId);

		// Token: 0x06003CBE RID: 15550
		Task UpdateInvoiceItem(IInvoiceItem item, IInvoice document, decimal total);

		// Token: 0x06003CBF RID: 15551
		Task UpdateInvoiceCustomer(int invoiceId, int banksId);
	}
}
