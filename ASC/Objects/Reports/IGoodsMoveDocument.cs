using System;
using System.Collections.ObjectModel;
using ASC.Common.Interfaces;

namespace ASC.Objects.Reports
{
	// Token: 0x02000937 RID: 2359
	public interface IGoodsMoveDocument : IStoreDocument
	{
		// Token: 0x17001405 RID: 5125
		// (get) Token: 0x06004862 RID: 18530
		// (set) Token: 0x06004863 RID: 18531
		int? ToStoreId { get; set; }

		// Token: 0x17001406 RID: 5126
		// (get) Token: 0x06004864 RID: 18532
		// (set) Token: 0x06004865 RID: 18533
		bool DestinationPay { get; set; }

		// Token: 0x17001407 RID: 5127
		// (get) Token: 0x06004866 RID: 18534
		// (set) Token: 0x06004867 RID: 18535
		ObservableCollection<store_items> Items { get; set; }
	}
}
