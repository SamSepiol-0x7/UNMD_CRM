using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Objects;

namespace ASC.Services.Abstract
{
	// Token: 0x020007F9 RID: 2041
	public interface IProductService
	{
		// Token: 0x06003D37 RID: 15671
		Task<IEnumerable<images>> GetImages(int productId);

		// Token: 0x06003D38 RID: 15672
		Task<IEnumerable<int>> GetImageIds(int productId);

		// Token: 0x06003D39 RID: 15673
		Task<List<ItemOperation>> GetDocuments(int productId);

		// Token: 0x06003D3A RID: 15674
		Task UpdateProduct(store_items product, IEnumerable<IAttribute> attributes);

		// Token: 0x06003D3B RID: 15675
		Task<List<logs>> GetHistory(int productId);

		// Token: 0x06003D3C RID: 15676
		Task<int> GetOrCreateArticul(auseceEntities ctx, store_items item);
	}
}
