using System;
using ASC.Common.Interfaces;

namespace ASC.Invoice
{
	// Token: 0x02000AEE RID: 2798
	public interface IInvoiceFactory
	{
		// Token: 0x06004F39 RID: 20281
		IInvoice Create();

		// Token: 0x06004F3A RID: 20282
		bool AppliesTo(System.Type type);
	}
}
