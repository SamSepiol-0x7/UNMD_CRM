using System;
using ASC.Common.Interfaces;

namespace ASC.Invoice
{
	// Token: 0x02000AEF RID: 2799
	public interface IInvoiceStrategy
	{
		// Token: 0x06004F3B RID: 20283
		IInvoice Create(System.Type type);
	}
}
