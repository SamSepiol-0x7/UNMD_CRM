using System;
using ASC.Common.Interfaces;
using ASC.Objects;

namespace ASC.Invoice
{
	// Token: 0x02000AF2 RID: 2802
	public class PackingListFactory : IInvoiceFactory
	{
		// Token: 0x06004F42 RID: 20290 RVA: 0x00157674 File Offset: 0x00155874
		public IInvoice Create()
		{
			return new PackingList();
		}

		// Token: 0x06004F43 RID: 20291 RVA: 0x00157688 File Offset: 0x00155888
		public bool AppliesTo(System.Type type)
		{
			return typeof(PackingList).Equals(type);
		}

		// Token: 0x06004F44 RID: 20292 RVA: 0x000046B4 File Offset: 0x000028B4
		public PackingListFactory()
		{
		}
	}
}
