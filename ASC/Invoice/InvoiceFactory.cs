using System;
using ASC.Common.Interfaces;
using ASC.Objects;

namespace ASC.Invoice
{
	// Token: 0x02000AF0 RID: 2800
	public class InvoiceFactory : IInvoiceFactory
	{
		// Token: 0x06004F3C RID: 20284 RVA: 0x00157604 File Offset: 0x00155804
		public IInvoice Create()
		{
			return new Invoice();
		}

		// Token: 0x06004F3D RID: 20285 RVA: 0x00157618 File Offset: 0x00155818
		public bool AppliesTo(System.Type type)
		{
			return typeof(Invoice).Equals(type);
		}

		// Token: 0x06004F3E RID: 20286 RVA: 0x000046B4 File Offset: 0x000028B4
		public InvoiceFactory()
		{
		}
	}
}
