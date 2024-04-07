using System;
using System.Collections.Generic;

namespace ASC.Interfaces
{
	// Token: 0x02000B33 RID: 2867
	public interface IKktCheque
	{
		// Token: 0x170014CE RID: 5326
		// (get) Token: 0x060050C3 RID: 20675
		Dictionary<int, string> PaymentItemSigns { get; }

		// Token: 0x060050C4 RID: 20676
		void LoadPaymentItemSigns();
	}
}
