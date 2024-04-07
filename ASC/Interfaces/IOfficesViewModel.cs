using System;

namespace ASC.Interfaces
{
	// Token: 0x02000B34 RID: 2868
	public interface IOfficesViewModel : IRefreshable
	{
		// Token: 0x170014CF RID: 5327
		// (get) Token: 0x060050C5 RID: 20677
		// (set) Token: 0x060050C6 RID: 20678
		bool ShowArchive { get; set; }

		// Token: 0x170014D0 RID: 5328
		// (get) Token: 0x060050C7 RID: 20679
		string GroupHeader { get; }

		// Token: 0x170014D1 RID: 5329
		// (get) Token: 0x060050C8 RID: 20680
		string ListHeader { get; }

		// Token: 0x060050C9 RID: 20681
		void ShowCreate();

		// Token: 0x060050CA RID: 20682
		void ShowEdit();

		// Token: 0x060050CB RID: 20683
		bool CanShowEdit();

		// Token: 0x060050CC RID: 20684
		void Refresh();

		// Token: 0x060050CD RID: 20685
		void LoadItems();
	}
}
