using System;
using System.Threading.Tasks;
using ASC.Common.Interfaces;

namespace ASC.Services
{
	// Token: 0x020005C1 RID: 1473
	public interface IBoxService
	{
		// Token: 0x060036E4 RID: 14052
		Task<boxes> GetBoxAsync(int boxId);

		// Token: 0x060036E5 RID: 14053
		Task<int> CreateBoxAsync(IStoreBox box);
	}
}
