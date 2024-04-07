using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASC.Common.Objects;
using ASC.Objects;
using ASC.Objects.Reports;
using ASC.SimpleClasses;

namespace ASC.Interfaces
{
	// Token: 0x02000B3B RID: 2875
	public interface IStoreService
	{
		// Token: 0x060050E9 RID: 20713
		Dictionary<int, string> GetPriceColumns();

		// Token: 0x060050EA RID: 20714
		Task<stores> GetStoreAsync(int storeId);

		// Token: 0x060050EB RID: 20715
		Task<List<stores>> GetStores();

		// Token: 0x060050EC RID: 20716
		Task<List<store_cats>> GetCategoriesAsync(int storeId);

		// Token: 0x060050ED RID: 20717
		Task<List<store_cats>> GetCategoriesAsync();

		// Token: 0x060050EE RID: 20718
		Task<store_items> GetProduct(int productId);

		// Token: 0x060050EF RID: 20719
		Task<IEnumerable<Product>> GetProductsAsync(int categoryId, string query);

		// Token: 0x060050F0 RID: 20720
		Task<List<Product>> GetProductsOfDocumentAsync(int documentId);

		// Token: 0x060050F1 RID: 20721
		Task<GoodsMoveDocument> GetProductsMoveDocument(int documentId);

		// Token: 0x060050F2 RID: 20722
		Task<List<items_state>> GetProductStatesAsync();

		// Token: 0x060050F3 RID: 20723
		Task<List<boxes>> GetBoxesAsync(int storeId);

		// Token: 0x060050F4 RID: 20724
		Task<int> ItemsMoveDispatch(IGoodsMoveDocument document);

		// Token: 0x060050F5 RID: 20725
		Task<bool> ItemsMoveArrived(int documentId);

		// Token: 0x060050F6 RID: 20726
		Task SetDocumentCashOrder(int documentId, int cashOrderId);

		// Token: 0x060050F7 RID: 20727
		Task<List<fields>> GetCategoryFieldsAsync(int categoryId);

		// Token: 0x060050F8 RID: 20728
		Task DeleteProductAsync(int productId);

		// Token: 0x060050F9 RID: 20729
		Task<IList<int>> SearchSKU(string searchString);

		// Token: 0x060050FA RID: 20730
		Task<IList<ArticulSearchLite>> GetProductsBySKU(IList<int> articuls);

		// Token: 0x060050FB RID: 20731
		List<ItemUnits> GetUnits();
	}
}
