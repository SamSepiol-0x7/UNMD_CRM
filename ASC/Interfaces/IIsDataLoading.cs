using System;

namespace ASC.Interfaces
{
	// Token: 0x02000B32 RID: 2866
	public interface IIsDataLoading
	{
		// Token: 0x170014CD RID: 5325
		// (get) Token: 0x060050C1 RID: 20673
		bool IsLoadingData { get; }

		// Token: 0x060050C2 RID: 20674
		void SetIsDataLoading(bool value);
	}
}
