using System;
using System.Threading.Tasks;
using ASC.SimpleClasses;

namespace ASC.Services.Abstract
{
	// Token: 0x02000800 RID: 2048
	public interface ITelService
	{
		// Token: 0x06003D5A RID: 15706
		Task<int> CreateTel(int customerId, Tel tel);

		// Token: 0x06003D5B RID: 15707
		Task UpdateTel(int customerId, Tel tel);

		// Token: 0x06003D5C RID: 15708
		Task DeleteTel(int customerId, int telId);
	}
}
