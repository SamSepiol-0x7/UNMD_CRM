using System;
using System.Threading.Tasks;

namespace ASC.Interfaces
{
	// Token: 0x02000B25 RID: 2853
	public interface IAcpModuleSettings
	{
		// Token: 0x170014C7 RID: 5319
		// (get) Token: 0x0600505E RID: 20574
		string Name { get; }

		// Token: 0x0600505F RID: 20575
		Task SaveSettings();

		// Token: 0x06005060 RID: 20576
		Task LoadSettings();
	}
}
