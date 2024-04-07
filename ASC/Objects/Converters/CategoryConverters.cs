using System;

namespace ASC.Objects.Converters
{
	// Token: 0x0200092C RID: 2348
	public static class CategoryConverters
	{
		// Token: 0x06004844 RID: 18500 RVA: 0x0011B688 File Offset: 0x00119888
		public static Category ToCategory(this workshop_cats c)
		{
			return new Category
			{
				Id = c.id,
				Name = c.name,
				Parent = c.parent,
				Position = c.position,
				Archive = c.archive,
				Icon = c.ico,
				VendorId = c.vendor_id
			};
		}

		// Token: 0x06004845 RID: 18501 RVA: 0x0011B6F0 File Offset: 0x001198F0
		public static StoreCategory ToStoreCategory(this store_cats c)
		{
			return new StoreCategory
			{
				Id = c.id,
				Name = c.name,
				Parent = c.parent,
				Position = c.position,
				Archive = (!c.enable).GetValueOrDefault(),
				Icon = c.ico
			};
		}
	}
}
