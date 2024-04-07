using System;
using System.Linq;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;

namespace ASC.Objects.Converters
{
	// Token: 0x02000910 RID: 2320
	public static class StoreItemMapper
	{
		// Token: 0x060047FA RID: 18426 RVA: 0x0011844C File Offset: 0x0011664C
		public static Product ToStoreItem(this store_items i)
		{
			Product product = new Product();
			product.Id = i.id;
			product.Articul = i.articul;
			product.AscBarcode = i.int_barcode;
			product.BoxId = i.box;
			boxes boxes = i.boxes;
			string boxName;
			if (boxes != null)
			{
				if ((boxName = boxes.name) != null)
				{
					goto IL_51;
				}
			}
			boxName = "";
			IL_51:
			product.BoxName = boxName;
			product.CategoryId = i.category;
			product.Count = i.count;
			product.Barcode = i.ext_barcode;
			product.Created = i.created;
			product.CurrencyRate = i.currency_rate;
			product.DealerId = i.dealer;
			product.InCount = i.in_count;
			product.InPrice = i.in_price;
			product.Name = i.name;
			product.Price = i.price;
			product.InSumm = i.in_summ;
			product.PriceOption = i.price_option;
			product.Units = i.units;
			product.DealerWarranty = i.warranty_dealer;
			product.Description = i.description;
			product.DocumentId = i.document;
			product.MinimumInStock = i.minimum_in_stock;
			product.NotForSale = i.not_for_sale;
			product.Notes = i.notes;
			product.PartRequestId = i.part_request;
			product.Pn = i.PN;
			product.Price2 = i.price2;
			product.Price3 = i.price3;
			product.Price4 = i.price4;
			product.Price5 = i.price5;
			product.Reserved = i.reserved;
			product.ReturnPercent = i.return_percent;
			product.ShopDescription = i.shop_description;
			product.ShopEnable = i.shop_enable;
			product.ShopTitle = i.shop_title;
			product.Sn = i.SN;
			product.Sold = i.sold;
			product.State = i.state;
			items_state items_state = i.items_state;
			string stateName;
			if (items_state != null)
			{
				if ((stateName = items_state.name) != null)
				{
					goto IL_1FE;
				}
			}
			stateName = "";
			IL_1FE:
			product.StateName = stateName;
			product.StoreId = i.store;
			product.Warranty = i.warranty;
			product.IsRealization = i.is_realization;
			Product product2 = product;
			if (i.images != null)
			{
				product2.SetImages(i.images);
			}
			if (i.field_values != null)
			{
				product2.SetAttributes((from p in i.field_values
				select p.ToUserField()).ToList<IAttribute>());
			}
			return product2;
		}

		// Token: 0x060047FB RID: 18427 RVA: 0x001186D4 File Offset: 0x001168D4
		public static store_items BackToStoreItem(this Product i)
		{
			return new store_items
			{
				id = i.Id,
				articul = i.Articul,
				int_barcode = i.AscBarcode,
				box = i.BoxId,
				box_name = i.BoxName,
				category = i.CategoryId,
				count = i.Count,
				ext_barcode = i.Barcode,
				created = i.Created,
				currency_rate = i.CurrencyRate,
				dealer = i.DealerId,
				in_count = i.InCount,
				in_price = i.InPrice,
				name = i.Name,
				price = i.Price,
				in_summ = i.InSumm,
				price_option = i.PriceOption,
				units = i.Units,
				warranty_dealer = i.DealerWarranty,
				description = i.Description,
				document = i.DocumentId,
				minimum_in_stock = i.MinimumInStock,
				not_for_sale = i.NotForSale,
				notes = i.Notes,
				part_request = i.PartRequestId,
				PN = i.Pn,
				price2 = i.Price2,
				price3 = i.Price3,
				price4 = i.Price4,
				price5 = i.Price5,
				reserved = i.Reserved,
				return_percent = i.ReturnPercent,
				shop_description = i.ShopDescription,
				shop_enable = i.ShopEnable,
				shop_title = i.ShopTitle,
				SN = i.Sn,
				sold = i.Sold,
				state = i.State,
				store = i.StoreId,
				warranty = i.Warranty,
				is_realization = i.IsRealization
			};
		}

		// Token: 0x060047FC RID: 18428 RVA: 0x001188D4 File Offset: 0x00116AD4
		public static store_items SaleToStoreItem(this store_sales item, int documentId)
		{
			return new store_items
			{
				id = item.item_id,
				SaleId = new int?(item.id),
				articul = item.store_items.articul,
				name = item.store_items.name,
				category = item.store_items.category,
				SN = item.sn,
				BuyCost = item.price,
				BuyCount = item.count,
				dealer = item.dealer,
				document = new int?(documentId),
				count = item.store_items.count,
				reserved = item.store_items.reserved,
				price = item.price,
				warranty = item.warranty,
				is_realization = item.is_realization,
				return_percent = item.return_percent,
				minimum_in_stock = item.store_items.minimum_in_stock
			};
		}

		// Token: 0x02000911 RID: 2321
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060047FD RID: 18429 RVA: 0x001189D8 File Offset: 0x00116BD8
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060047FE RID: 18430 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x060047FF RID: 18431 RVA: 0x001189F0 File Offset: 0x00116BF0
			internal IAttribute <ToStoreItem>b__0_0(field_values p)
			{
				return p.ToUserField();
			}

			// Token: 0x04002E04 RID: 11780
			public static readonly StoreItemMapper.<>c <>9 = new StoreItemMapper.<>c();

			// Token: 0x04002E05 RID: 11781
			public static Func<field_values, IAttribute> <>9__0_0;
		}
	}
}
