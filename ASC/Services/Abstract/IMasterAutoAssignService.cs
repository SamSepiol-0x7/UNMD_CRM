using System;
using System.Threading.Tasks;
using ASC.Common.Interfaces;

namespace ASC.Services.Abstract
{
	// Token: 0x020007E6 RID: 2022
	public interface IMasterAutoAssignService
	{
		// Token: 0x06003C96 RID: 15510
		Task<int?> GetMaster(IMasterAutoAssignCriteria criteria, int? skipFromUser = null);
	}
}
