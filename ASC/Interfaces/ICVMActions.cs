using System;

namespace ASC.Interfaces
{
	// Token: 0x02000B3C RID: 2876
	public interface ICVMActions
	{
		// Token: 0x060050FC RID: 20732
		void Save();

		// Token: 0x060050FD RID: 20733
		bool CanSave();

		// Token: 0x060050FE RID: 20734
		void Refresh();

		// Token: 0x060050FF RID: 20735
		bool CanRefresh();
	}
}
