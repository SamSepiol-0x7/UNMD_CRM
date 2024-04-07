using System;
using System.Threading.Tasks;

namespace ASC.Interfaces
{
	// Token: 0x02000B42 RID: 2882
	public interface IInvoiceSelect
	{
		// Token: 0x06005123 RID: 20771
		Task SelectInvoice(int invoiceId);
	}
}
