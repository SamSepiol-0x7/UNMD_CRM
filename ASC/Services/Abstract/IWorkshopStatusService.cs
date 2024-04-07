using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASC.Models;
using ASC.Options;

namespace ASC.Services.Abstract
{
	// Token: 0x02000808 RID: 2056
	public interface IWorkshopStatusService
	{
		// Token: 0x06003D71 RID: 15729
		List<WorkshopOptions> GetStatusList();

		// Token: 0x06003D72 RID: 15730
		Task<workshop> UpdateStatus(workshop repair);

		// Token: 0x06003D73 RID: 15731
		Task AdminUpdateStatus(int repairId, int nextStatus);

		// Token: 0x06003D74 RID: 15732
		Task UpdateStatusLog(auseceEntities ctx, RepairStatusLogModel repairStatusLogModel);
	}
}
