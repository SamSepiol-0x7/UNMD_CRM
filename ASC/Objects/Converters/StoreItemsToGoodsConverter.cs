using System;
using ASC.Common.Interfaces;

namespace ASC.Objects.Converters
{
	// Token: 0x02000932 RID: 2354
	public static class StoreItemsToGoodsConverter
	{
		// Token: 0x06004856 RID: 18518 RVA: 0x0011C478 File Offset: 0x0011A678
		public static IGoods ToGoods(this store_items i)
		{
			return new Goods
			{
				Id = i.id,
				Name = i.name,
				Count = i.count,
				Created = (i.created ?? DateTime.Now),
				StoreId = i.store,
				CategoryId = i.category,
				InPrice = i.in_price
			};
		}
	}
}
