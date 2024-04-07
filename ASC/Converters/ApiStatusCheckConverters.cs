using System;
using ASC.Common.Objects;

namespace ASC.Converters
{
	// Token: 0x02000BD3 RID: 3027
	public static class ApiStatusCheckConverters
	{
		// Token: 0x06005481 RID: 21633 RVA: 0x0016BB90 File Offset: 0x00169D90
		public static ApiStatusCheck ToApiStatusCheck(this api_status_checks c)
		{
			ApiStatusCheck apiStatusCheck = new ApiStatusCheck();
			apiStatusCheck.Id = c.id;
			apiStatusCheck.RepairId = c.repair;
			apiStatusCheck.UserAgent = c.user_agent;
			apiStatusCheck.Created = c.created;
			apiStatusCheck.SetIpAddress(c.ip_address);
			return apiStatusCheck;
		}
	}
}
