using System;
using ASC.Common.Interfaces;
using ASC.Objects;

namespace ASC.Invoice
{
	// Token: 0x02000AF3 RID: 2803
	public class WorksListFactory : IInvoiceFactory
	{
		// Token: 0x06004F45 RID: 20293 RVA: 0x001576A8 File Offset: 0x001558A8
		public IInvoice Create()
		{
			return new WorksList();
		}

		// Token: 0x06004F46 RID: 20294 RVA: 0x001576BC File Offset: 0x001558BC
		public bool AppliesTo(System.Type type)
		{
			return typeof(WorksList).Equals(type);
		}

		// Token: 0x06004F47 RID: 20295 RVA: 0x000046B4 File Offset: 0x000028B4
		public WorksListFactory()
		{
		}
	}
}
