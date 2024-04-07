using System;
using System.Threading.Tasks;
using ASC.Common.Interfaces;

namespace ASC.Services
{
	// Token: 0x020005CC RID: 1484
	public interface IHookService
	{
		// Token: 0x060036FA RID: 14074
		Task<IHook> GetFirstHookByTaskId(int taskId);
	}
}
