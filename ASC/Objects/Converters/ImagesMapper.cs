using System;
using ASC.Common.Interfaces;

namespace ASC.Objects.Converters
{
	// Token: 0x02000905 RID: 2309
	public static class ImagesMapper
	{
		// Token: 0x060047DF RID: 18399 RVA: 0x001178B4 File Offset: 0x00115AB4
		public static images ToImages(this IImage i)
		{
			return new images
			{
				id = i.Id,
				img = i.Image,
				added = i.Created,
				item_id = i.StoreItemId
			};
		}

		// Token: 0x060047E0 RID: 18400 RVA: 0x001178F8 File Offset: 0x00115AF8
		public static IImage BackToImages(this images i)
		{
			return new AscImage
			{
				Id = i.id,
				Image = i.img,
				Created = i.added,
				StoreItemId = i.item_id
			};
		}
	}
}
