using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Objects;

namespace ASC.Services
{
	// Token: 0x020005FD RID: 1533
	public interface IWorkshopPriceService
	{
		// Token: 0x0600376F RID: 14191
		Task<List<Category>> GetCategoriesAsync(int? vendorId, bool showArchive, bool includeAll = false);

		// Token: 0x06003770 RID: 14192
		Task<List<workshop_price>> GetPriceItems(int? vendorId, int category);

		// Token: 0x06003771 RID: 14193
		Task<bool> CreatePriceCategory(ICategory c);

		// Token: 0x06003772 RID: 14194
		Task<bool> UpdatePriceCategory(ICategory c);

		// Token: 0x06003773 RID: 14195
		Task<bool> SaveCategoriesPosition(IEnumerable<ICategory> c);

		// Token: 0x06003774 RID: 14196
		void UpdateCategoriesExpandState(IEnumerable<ICategory> c);
	}
}
