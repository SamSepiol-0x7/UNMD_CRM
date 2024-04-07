using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ASC.Common.Interfaces;

namespace ASC.ViewModels.ItemCard
{
	// Token: 0x020004B6 RID: 1206
	public interface IProductAttributesViewModel
	{
		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x06002ECD RID: 11981
		ObservableCollection<IAttribute> Items { get; }

		// Token: 0x06002ECE RID: 11982
		void Save();

		// Token: 0x06002ECF RID: 11983
		void LoadItems(int itemId, bool readOnly);

		// Token: 0x06002ED0 RID: 11984
		void SetAttributes(IEnumerable<IAttribute> a);

		// Token: 0x06002ED1 RID: 11985
		void LoadItemsByCategory(int categoryId);
	}
}
