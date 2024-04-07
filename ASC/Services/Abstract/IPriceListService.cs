using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASC.Services.Abstract
{
	// Token: 0x020007F7 RID: 2039
	public interface IPriceListService
	{
		// Token: 0x06003D31 RID: 15665
		Task<workshop_price> GetItem(int optionId);

		// Token: 0x06003D32 RID: 15666
		Task<int> CreateItem(workshop_price item);

		// Token: 0x06003D33 RID: 15667
		Task UpdateItem(workshop_price item);

		// Token: 0x06003D34 RID: 15668
		string CheckFields(workshop_price item);

		// Token: 0x06003D35 RID: 15669
		Task<List<workshop_cats>> GetPriceCategories();
	}
}
