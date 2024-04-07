using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ASC.SimpleClasses;

namespace ASC.Objects.Converters
{
	// Token: 0x0200090A RID: 2314
	public class PackingListItemsMapper
	{
		// Token: 0x060047EE RID: 18414 RVA: 0x00117D74 File Offset: 0x00115F74
		public static IEnumerable<InvoiceItem> PackingListItemsConverter(IEnumerable<invoice_items> items)
		{
			if (items == null)
			{
				return new List<InvoiceItem>();
			}
			List<invoice_items> source = items.ToList<invoice_items>();
			if (!source.Any<invoice_items>())
			{
				return new List<InvoiceItem>();
			}
			return (from item in source
			select new InvoiceItem(item.id, item.name, Fn.FormatSumm(item.price), item.count, item.units, new double?(item.tax), item.tax_mode, Fn.FormatSumm(item.total), item.p_list.Value, item.repair, item.document, item.workshop.ToRepairCard())).ToList<InvoiceItem>();
		}

		// Token: 0x060047EF RID: 18415 RVA: 0x000046B4 File Offset: 0x000028B4
		public PackingListItemsMapper()
		{
		}

		// Token: 0x0200090B RID: 2315
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060047F0 RID: 18416 RVA: 0x00117DCC File Offset: 0x00115FCC
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060047F1 RID: 18417 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x060047F2 RID: 18418 RVA: 0x00117DE4 File Offset: 0x00115FE4
			internal InvoiceItem <PackingListItemsConverter>b__0_0(invoice_items item)
			{
				return new InvoiceItem(item.id, item.name, Fn.FormatSumm(item.price), item.count, item.units, new double?(item.tax), item.tax_mode, Fn.FormatSumm(item.total), item.p_list.Value, item.repair, item.document, item.workshop.ToRepairCard());
			}

			// Token: 0x04002E02 RID: 11778
			public static readonly PackingListItemsMapper.<>c <>9 = new PackingListItemsMapper.<>c();

			// Token: 0x04002E03 RID: 11779
			public static Func<invoice_items, InvoiceItem> <>9__0_0;
		}
	}
}
