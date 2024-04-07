using System;
using System.Collections.Generic;
using System.Linq;
using ASC.SimpleClasses;

namespace ASC.Objects.Converters
{
	// Token: 0x02000922 RID: 2338
	public static class ArticulConverters
	{
		// Token: 0x06004822 RID: 18466 RVA: 0x00119ED4 File Offset: 0x001180D4
		public static ArticulSearchLite ToArticulSearchLite(this store_items a)
		{
			ArticulSearchLite articulSearchLite = new ArticulSearchLite();
			articulSearchLite.ItemId = a.id;
			articulSearchLite.Articul = a.articul;
			articulSearchLite.Category = a.category;
			articulSearchLite.State = a.state;
			articulSearchLite.Name = a.name;
			articulSearchLite.CategoryName = a.store_cats.name;
			articulSearchLite.StateName = a.items_state.name;
			articulSearchLite.PartNumber = a.PN;
			articulSearchLite.Description = a.description;
			articulSearchLite.Price = a.price2;
			articulSearchLite.PriceOpt = a.price3;
			articulSearchLite.PriceOpt2 = a.price4;
			articulSearchLite.PriceOpt3 = a.price5;
			articulSearchLite.Price4Sc = a.price;
			articulSearchLite.Count = a.count;
			articulSearchLite.Units = a.units;
			articulSearchLite.Warranty = a.warranty;
			articulSearchLite.Reserved = a.reserved;
			List<decimal> source = new List<decimal>
			{
				a.price2,
				a.price3,
				a.price4,
				a.price5,
				a.price
			};
			articulSearchLite.MaxPrice = source.Max<decimal>();
			return articulSearchLite;
		}
	}
}
