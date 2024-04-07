using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;

namespace ASC.Objects.Converters
{
	// Token: 0x02000918 RID: 2328
	public static class SaleItemConverters
	{
		// Token: 0x0600480A RID: 18442 RVA: 0x00118F90 File Offset: 0x00117190
		public static SaleItem ToSaleItem(this store_items i)
		{
			SaleItem saleItem = new SaleItem();
			saleItem.Id = i.id;
			saleItem.Name = i.name;
			saleItem.Articul = i.articul;
			saleItem.Count = i.in_count;
			saleItem.InPrice = i.in_price;
			saleItem.Price = i.price2;
			saleItem.PriceOpt = i.price3;
			saleItem.PriceOpt2 = i.price4;
			saleItem.PriceSC = i.price;
			saleItem.Sn = i.SN;
			saleItem.Notes = i.notes;
			saleItem.AscBarcode = i.int_barcode;
			saleItem.Description = i.description;
			boxes boxes = i.boxes;
			string boxName;
			if (boxes != null)
			{
				if ((boxName = boxes.name) != null)
				{
					goto IL_BD;
				}
			}
			boxName = "";
			IL_BD:
			saleItem.BoxName = boxName;
			saleItem.Partnumber = i.PN;
			saleItem.Created = i.created;
			saleItem.Units = i.units;
			saleItem.DealerWarrantyDays = i.warranty_dealer;
			saleItem.StateId = i.state;
			items_state items_state = i.items_state;
			string stateName;
			if (items_state != null)
			{
				if ((stateName = items_state.name) != null)
				{
					goto IL_11A;
				}
			}
			stateName = "";
			IL_11A:
			saleItem.StateName = stateName;
			saleItem.Dealer = i.clients.Client2Customer();
			SaleItem saleItem2 = saleItem;
			saleItem2.SetWarranty(i.warranty);
			if (i.field_values != null)
			{
				List<IAttribute> attributes = (from f in i.field_values
				where !string.IsNullOrEmpty(f.value)
				select f.ToUserField()).ToList<IAttribute>();
				saleItem2.SetAttributes(attributes);
			}
			return saleItem2;
		}

		// Token: 0x0600480B RID: 18443 RVA: 0x00119140 File Offset: 0x00117340
		public static SaleItem ToSaleItem(this store_sales i)
		{
			SaleItem saleItem = new SaleItem();
			saleItem.Id = i.id;
			saleItem.Name = i.store_items.name;
			saleItem.Articul = i.store_items.articul;
			saleItem.AscBarcode = i.store_items.int_barcode;
			saleItem.Description = i.store_items.description;
			saleItem.Count = i.count;
			saleItem.InPrice = i.in_price;
			saleItem.Price = i.price;
			saleItem.Sn = i.sn;
			saleItem.Partnumber = i.store_items.PN;
			saleItem.Created = i.store_items.created;
			saleItem.Units = i.store_items.units;
			saleItem.DealerWarrantyDays = i.store_items.warranty_dealer;
			saleItem.StateId = i.store_items.state;
			store_items store_items = i.store_items;
			string stateName;
			if (store_items != null)
			{
				items_state items_state = store_items.items_state;
				if (items_state != null)
				{
					if ((stateName = items_state.name) != null)
					{
						goto IL_102;
					}
				}
			}
			stateName = "";
			IL_102:
			saleItem.StateName = stateName;
			saleItem.SetWarranty(i.warranty);
			return saleItem;
		}

		// Token: 0x02000919 RID: 2329
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600480C RID: 18444 RVA: 0x00119260 File Offset: 0x00117460
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600480D RID: 18445 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x0600480E RID: 18446 RVA: 0x00119278 File Offset: 0x00117478
			internal bool <ToSaleItem>b__0_0(field_values f)
			{
				return !string.IsNullOrEmpty(f.value);
			}

			// Token: 0x0600480F RID: 18447 RVA: 0x001189F0 File Offset: 0x00116BF0
			internal IAttribute <ToSaleItem>b__0_1(field_values f)
			{
				return f.ToUserField();
			}

			// Token: 0x04002E06 RID: 11782
			public static readonly SaleItemConverters.<>c <>9 = new SaleItemConverters.<>c();

			// Token: 0x04002E07 RID: 11783
			public static Func<field_values, bool> <>9__0_0;

			// Token: 0x04002E08 RID: 11784
			public static Func<field_values, IAttribute> <>9__0_1;
		}
	}
}
