using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;
using ASC.SimpleClasses;

namespace ASC.Objects.Converters
{
	// Token: 0x0200092D RID: 2349
	public static class CartridgeCardConverter
	{
		// Token: 0x06004846 RID: 18502 RVA: 0x0011B778 File Offset: 0x00119978
		public static ICartridgeCard ToCartridgeCard(this cartridge_cards card)
		{
			CartridgeCard cartridgeCard = new CartridgeCard();
			cartridgeCard.CardId = card.id;
			cartridgeCard.MakerId = card.maker;
			cartridgeCard.Name = card.name;
			cartridgeCard.Created = card.created;
			cartridgeCard.Notes = card.notes;
			cartridgeCard.FullWeight = card.full_weight;
			cartridgeCard.TonerWeight = card.toner_weight;
			cartridgeCard.Resource = card.resource;
			cartridgeCard.EmployeeId = card.user;
			cartridgeCard.Color = card.color;
			images images = card.images;
			cartridgeCard.Photo = ((images != null) ? images.img : null);
			cartridgeCard.Archive = card.archive;
			ObservableCollection<IMaterial> materials;
			if (card.materials != null)
			{
				materials = new ObservableCollection<IMaterial>(from c in card.materials
				select c.ToMaterial());
			}
			else
			{
				materials = new ObservableCollection<IMaterial>();
			}
			cartridgeCard.Materials = materials;
			return cartridgeCard;
		}

		// Token: 0x06004847 RID: 18503 RVA: 0x0011B86C File Offset: 0x00119A6C
		public static IdNameClass ToIdName(this ICartridgeCard c)
		{
			return new IdNameClass(c.CardId, c.Name);
		}

		// Token: 0x06004848 RID: 18504 RVA: 0x0011B88C File Offset: 0x00119A8C
		public static ICartridgeCard ToCartridgeCard(this workshop w)
		{
			CartridgeCard cartridgeCard = new CartridgeCard();
			cartridgeCard.CardId = w.id;
			cartridgeCard.MakerId = w.maker;
			cartridgeCard.Name = w.c_workshop.cartridge_cards.name;
			cartridgeCard.Created = w.c_workshop.cartridge_cards.created;
			cartridgeCard.Notes = w.c_workshop.cartridge_cards.notes;
			cartridgeCard.FullWeight = w.c_workshop.cartridge_cards.full_weight;
			cartridgeCard.TonerWeight = w.c_workshop.cartridge_cards.toner_weight;
			cartridgeCard.Resource = w.c_workshop.cartridge_cards.resource;
			cartridgeCard.EmployeeId = w.c_workshop.cartridge_cards.user;
			cartridgeCard.Color = w.c_workshop.cartridge_cards.color;
			images images = w.c_workshop.cartridge_cards.images;
			cartridgeCard.Photo = ((images != null) ? images.img : null);
			ObservableCollection<IMaterial> materials;
			if (w.c_workshop.cartridge_cards.materials != null)
			{
				materials = new ObservableCollection<IMaterial>(from c in w.c_workshop.cartridge_cards.materials
				select c.ToMaterial());
			}
			else
			{
				materials = new ObservableCollection<IMaterial>();
			}
			cartridgeCard.Materials = materials;
			return cartridgeCard;
		}

		// Token: 0x06004849 RID: 18505 RVA: 0x0011B9E0 File Offset: 0x00119BE0
		public static IMaterial ToMaterial(this materials m)
		{
			return new Material
			{
				Id = m.id,
				Name = m.name,
				Type = m.type,
				Count = m.count,
				Articul = m.articul,
				Price = m.price,
				WorksPrice = m.works_price
			};
		}

		// Token: 0x0200092E RID: 2350
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600484A RID: 18506 RVA: 0x0011BA48 File Offset: 0x00119C48
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600484B RID: 18507 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x0600484C RID: 18508 RVA: 0x0011B0A4 File Offset: 0x001192A4
			internal IMaterial <ToCartridgeCard>b__0_0(materials c)
			{
				return c.ToMaterial();
			}

			// Token: 0x0600484D RID: 18509 RVA: 0x0011B0A4 File Offset: 0x001192A4
			internal IMaterial <ToCartridgeCard>b__2_0(materials c)
			{
				return c.ToMaterial();
			}

			// Token: 0x04002E22 RID: 11810
			public static readonly CartridgeCardConverter.<>c <>9 = new CartridgeCardConverter.<>c();

			// Token: 0x04002E23 RID: 11811
			public static Func<materials, IMaterial> <>9__0_0;

			// Token: 0x04002E24 RID: 11812
			public static Func<materials, IMaterial> <>9__2_0;
		}
	}
}
