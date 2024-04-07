using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASC.Common.Interfaces;

namespace ASC.Interfaces
{
	// Token: 0x02000B28 RID: 2856
	public interface IRepairModel
	{
		// Token: 0x0600506B RID: 20587
		Dictionary<int, string> GetRejectReasons();

		// Token: 0x0600506C RID: 20588
		List<IPrepaidType> GetPrePaidTypes();

		// Token: 0x0600506D RID: 20589
		Task RestoreIntReserve(int repairId);
	}
}
