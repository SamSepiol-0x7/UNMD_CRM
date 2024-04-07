using System;
using ASC.Common.Interfaces;

namespace ASC.Interfaces
{
	// Token: 0x02000B26 RID: 2854
	public interface IGoodsInvoiceReport : IReport
	{
		// Token: 0x170014C8 RID: 5320
		// (get) Token: 0x06005061 RID: 20577
		// (set) Token: 0x06005062 RID: 20578
		ICustomer Customer { get; set; }

		// Token: 0x170014C9 RID: 5321
		// (get) Token: 0x06005063 RID: 20579
		// (set) Token: 0x06005064 RID: 20580
		IOffice Office { get; set; }

		// Token: 0x170014CA RID: 5322
		// (get) Token: 0x06005065 RID: 20581
		// (set) Token: 0x06005066 RID: 20582
		stores Store { get; set; }

		// Token: 0x06005067 RID: 20583
		void LoadOffice();

		// Token: 0x06005068 RID: 20584
		void LoadCustomer();

		// Token: 0x06005069 RID: 20585
		void LoadStore();
	}
}
