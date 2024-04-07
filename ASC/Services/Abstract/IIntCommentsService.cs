using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASC.Services.Abstract
{
	// Token: 0x020007EC RID: 2028
	public interface IIntCommentsService
	{
		// Token: 0x06003CB2 RID: 15538
		Task CreateRepairComment(int repairId, string text);

		// Token: 0x06003CB3 RID: 15539
		Task CreatePartRequestComment(int requestId, string text);

		// Token: 0x06003CB4 RID: 15540
		Task CreateTaskComment(int taskId, string comment);

		// Token: 0x06003CB5 RID: 15541
		Task<List<comments>> GetRepairComments(int repairId);

		// Token: 0x06003CB6 RID: 15542
		Task<List<comments>> GetRequestComments(int requestId);

		// Token: 0x06003CB7 RID: 15543
		Task<List<comments>> GetTaskComments(int taskId);
	}
}
