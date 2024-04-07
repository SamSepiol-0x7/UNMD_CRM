using System;
using System.Collections.Generic;
using ASC.Objects;

namespace ASC.Interfaces
{
	// Token: 0x02000B46 RID: 2886
	public interface IItemsSelect
	{
		// Token: 0x0600512B RID: 20779
		void AddItemsFromStore(List<Product> items, Product selectedItem);
	}
}
