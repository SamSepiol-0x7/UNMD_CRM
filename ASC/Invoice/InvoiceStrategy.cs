using System;
using System.Linq;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;

namespace ASC.Invoice
{
	// Token: 0x02000AF4 RID: 2804
	public class InvoiceStrategy : IInvoiceStrategy
	{
		// Token: 0x06004F48 RID: 20296 RVA: 0x001576DC File Offset: 0x001558DC
		public InvoiceStrategy(IInvoiceFactory[] invoiceFactories)
		{
			if (invoiceFactories == null)
			{
				throw new ArgumentNullException("invoiceFactories");
			}
			this.invoiceFactories = invoiceFactories;
		}

		// Token: 0x06004F49 RID: 20297 RVA: 0x00157704 File Offset: 0x00155904
		public IInvoice Create(System.Type type)
		{
			IInvoiceFactory invoiceFactory = this.invoiceFactories.FirstOrDefault((IInvoiceFactory factory) => factory.AppliesTo(type));
			if (invoiceFactory == null)
			{
				throw new Exception("type not registered");
			}
			return invoiceFactory.Create();
		}

		// Token: 0x040034AC RID: 13484
		private readonly IInvoiceFactory[] invoiceFactories;

		// Token: 0x02000AF5 RID: 2805
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x06004F4A RID: 20298 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x06004F4B RID: 20299 RVA: 0x00157748 File Offset: 0x00155948
			internal bool <Create>b__0(IInvoiceFactory factory)
			{
				return factory.AppliesTo(this.type);
			}

			// Token: 0x040034AD RID: 13485
			public System.Type type;
		}
	}
}
