using System;
using ASC.Common.Interfaces;

namespace ASC.Interfaces
{
	// Token: 0x02000B41 RID: 2881
	public interface IInvoiceItemAdd
	{
		// Token: 0x170014E4 RID: 5348
		// (get) Token: 0x06005121 RID: 20769
		IInvoice Document { get; }

		// Token: 0x06005122 RID: 20770
		void InvoiceItemAdd(IInvoiceItem item);
	}
}
