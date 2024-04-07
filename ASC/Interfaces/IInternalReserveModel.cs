using System;

namespace ASC.Interfaces
{
	// Token: 0x02000B31 RID: 2865
	public interface IInternalReserveModel
	{
		// Token: 0x060050C0 RID: 20672
		store_int_reserve CreateReserve(store_items item, int count, decimal price, int? repairId, int? workId);
	}
}
