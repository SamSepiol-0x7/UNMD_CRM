using System;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Objects;

namespace ASC.Services.Abstract
{
	// Token: 0x02000805 RID: 2053
	public interface IWorkshopWorkService
	{
		// Token: 0x06003D6A RID: 15722
		Task<int> CreateWork(WorkPartObject work);

		// Token: 0x06003D6B RID: 15723
		Task UpdateWorks(WorkPartObject item);

		// Token: 0x06003D6C RID: 15724
		Task RemoveWork(IWorkPartObject item);
	}
}
