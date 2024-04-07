using System;
using System.Threading.Tasks;

namespace ASC.Services.Abstract
{
	// Token: 0x02000806 RID: 2054
	public interface IWorkshopHistoryService
	{
		// Token: 0x06003D6D RID: 15725
		Task LogRepairChanges(workshop original, workshop current);
	}
}
