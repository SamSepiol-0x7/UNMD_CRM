using System;

namespace ASC.Objects.Converters
{
	// Token: 0x0200090E RID: 2318
	public static class RealizationItemConverters
	{
		// Token: 0x060047F6 RID: 18422 RVA: 0x001180B8 File Offset: 0x001162B8
		public static RealizationItem ToRealizationItem(this store_items i, bool reserve = false)
		{
			if (i == null)
			{
				return null;
			}
			return new RealizationItem
			{
				Id = i.id,
				Name = i.name,
				CategoryId = i.category,
				Count = (reserve ? i.reserved : i.count),
				InPrice = i.in_price,
				Percent = i.return_percent,
				Created = i.created,
				Price2 = new decimal?(i.price2),
				Price2Summ = new decimal?(i.price2 * i.count)
			};
		}

		// Token: 0x060047F7 RID: 18423 RVA: 0x00118160 File Offset: 0x00116360
		public static RealizationItem ToRealizationItem(this store_sales i)
		{
			if (i == null)
			{
				return null;
			}
			return new RealizationItem
			{
				Id = i.store_items.id,
				Name = i.store_items.name,
				CategoryId = i.store_items.category,
				Count = i.count,
				InPrice = i.in_price,
				Percent = i.return_percent,
				Created = i.store_items.created,
				DateOfSale = new DateTime?(i.docs.created),
				SoldSumm = new decimal?(i.price * i.count)
			};
		}
	}
}
