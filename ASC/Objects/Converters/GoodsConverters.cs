using System;

namespace ASC.Objects.Converters
{
	// Token: 0x02000915 RID: 2325
	public static class GoodsConverters
	{
		// Token: 0x06004805 RID: 18437 RVA: 0x00118D20 File Offset: 0x00116F20
		public static Goods ToGoods(this store_sales s)
		{
			return new Goods
			{
				Id = s.id,
				Name = s.name,
				Count = s.count
			};
		}
	}
}
