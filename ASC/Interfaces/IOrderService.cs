using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASC.Interfaces
{
	// Token: 0x02000B35 RID: 2869
	public interface IOrderService
	{
		// Token: 0x060050CE RID: 20686
		Task<List<images>> GetImages(int orderId);

		// Token: 0x060050CF RID: 20687
		Task UpdateImageIds(int orderId, List<int> imageIds);

		// Token: 0x060050D0 RID: 20688
		Task CancellOrder(int repairId, int nextStatus, int paymentSystem);

		// Token: 0x060050D1 RID: 20689
		Task DeleteWorkshopIssuedData(int repairId);

		// Token: 0x060050D2 RID: 20690
		Task<DateTime?> GetDateOfIssue(int repairId);
	}
}
