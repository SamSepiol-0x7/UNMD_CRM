using System;
using ASC.Common.Interfaces;
using ASC.Objects;

namespace ASC.Invoice
{
	// Token: 0x02000AF1 RID: 2801
	public class VATInvoiceFactory : IInvoiceFactory
	{
		// Token: 0x06004F3F RID: 20287 RVA: 0x00157638 File Offset: 0x00155838
		public IInvoice Create()
		{
			return new VATInvoice(Auth.CurrencyModel.SelectedCurrency);
		}

		// Token: 0x06004F40 RID: 20288 RVA: 0x00157654 File Offset: 0x00155854
		public bool AppliesTo(System.Type type)
		{
			return typeof(VATInvoice).Equals(type);
		}

		// Token: 0x06004F41 RID: 20289 RVA: 0x000046B4 File Offset: 0x000028B4
		public VATInvoiceFactory()
		{
		}
	}
}
