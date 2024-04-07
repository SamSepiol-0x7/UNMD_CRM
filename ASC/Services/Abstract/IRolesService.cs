using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASC.Services.Abstract
{
	// Token: 0x020007FD RID: 2045
	public interface IRolesService
	{
		// Token: 0x06003D41 RID: 15681
		Task<IList<roles>> GetRolesAsync();
	}
}
