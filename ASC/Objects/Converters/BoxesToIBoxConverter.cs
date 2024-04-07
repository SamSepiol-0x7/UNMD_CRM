using System;
using ASC.Common.Interfaces;

namespace ASC.Objects.Converters
{
	// Token: 0x02000931 RID: 2353
	public static class BoxesToIBoxConverter
	{
		// Token: 0x06004854 RID: 18516 RVA: 0x0011C360 File Offset: 0x0011A560
		public static IBox ToIBox(this boxes b)
		{
			if (b.non_items)
			{
				return new WorkshopBox
				{
					Id = b.id,
					Name = b.name,
					Places = b.places,
					Color = b.color,
					Used = b.workshop.Count
				};
			}
			return new StoreBox
			{
				Id = b.id,
				Name = b.name,
				Places = b.places,
				StoreId = new int?(b.store_id ?? -1),
				Color = b.color,
				Used = b.store_items.Count
			};
		}

		// Token: 0x06004855 RID: 18517 RVA: 0x0011C428 File Offset: 0x0011A628
		public static boxes BackToBoxes(this IStoreBox box)
		{
			return new boxes
			{
				id = box.Id,
				name = box.Name,
				store_id = box.StoreId,
				places = box.Places,
				color = box.Color
			};
		}
	}
}
