using System;
using System.Collections.ObjectModel;
using ASC.Options;

namespace ASC.Interfaces
{
	// Token: 0x02000B3A RID: 2874
	public interface IStatusViewModel
	{
		// Token: 0x060050E2 RID: 20706
		void LoadRepairStates(int state);

		// Token: 0x170014D2 RID: 5330
		// (get) Token: 0x060050E3 RID: 20707
		// (set) Token: 0x060050E4 RID: 20708
		ObservableCollection<WorkshopOptions> StatesList { get; set; }

		// Token: 0x170014D3 RID: 5331
		// (get) Token: 0x060050E5 RID: 20709
		// (set) Token: 0x060050E6 RID: 20710
		WorkshopOptions SelectedOption { get; set; }

		// Token: 0x060050E7 RID: 20711
		void SetSelected(int statusId);

		// Token: 0x060050E8 RID: 20712
		bool CanChangeState();
	}
}
