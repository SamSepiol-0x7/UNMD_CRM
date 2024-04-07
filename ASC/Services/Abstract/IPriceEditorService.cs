using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASC.Common.Interfaces;

namespace ASC.Services.Abstract
{
	// Token: 0x020007F6 RID: 2038
	public interface IPriceEditorService
	{
		// Token: 0x06003D29 RID: 15657
		Task LogChanges(IEnumerable<store_items> items);

		// Token: 0x06003D2A RID: 15658
		Task<List<store_items>> LoadItems4Edit(int storeId, int availabilityMode, int categoryId, int stateId, string query, bool searchInDescription);

		// Token: 0x06003D2B RID: 15659
		void RejectChanges(IEnumerable<store_items> items);

		// Token: 0x06003D2C RID: 15660
		IAscResult SetHighlight(int itemId, bool value);

		// Token: 0x06003D2D RID: 15661
		IAscResult SetHighlight(IEnumerable<int> itemIds, bool value);

		// Token: 0x06003D2E RID: 15662
		bool SaveContext();

		// Token: 0x06003D2F RID: 15663
		Task SaveHistory();

		// Token: 0x06003D30 RID: 15664
		void ResetHistory();
	}
}
