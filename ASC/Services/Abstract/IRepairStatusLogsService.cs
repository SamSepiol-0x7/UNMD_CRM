using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Models;

namespace ASC.Services.Abstract
{
	// Token: 0x020007FB RID: 2043
	public interface IRepairStatusLogsService
	{
		// Token: 0x06003D3F RID: 15679
		Task<List<UserRepairStatusLogsModel>> GetData(IPeriod period, IList<int> statusIds, IList<int> userIds);
	}
}
