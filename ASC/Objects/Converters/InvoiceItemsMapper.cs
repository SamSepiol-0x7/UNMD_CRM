using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ASC.SimpleClasses;

namespace ASC.Objects.Converters
{
	// Token: 0x02000906 RID: 2310
	public class InvoiceItemsMapper
	{
		// Token: 0x060047E1 RID: 18401 RVA: 0x0011793C File Offset: 0x00115B3C
		public static IEnumerable<InvoiceItem> WorksListItemsConverter(IEnumerable<invoice_items> items)
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
			select new InvoiceItem(item.id, item.name, Fn.FormatSumm(item.price), item.count, item.units, new double?(item.tax), item.tax_mode, Fn.FormatSumm(item.total), item.w_list.Value, item.repair, item.document, item.workshop.ToRepairCard())).ToList<InvoiceItem>();
		}

		// Token: 0x060047E2 RID: 18402 RVA: 0x00117994 File Offset: 0x00115B94
		public static IEnumerable<InvoiceItem> InvoiceItemsConverter(IEnumerable<invoice_items> items)
		{
			if (items == null)
			{
				return new List<InvoiceItem>();
			}
			List<invoice_items> source = items.ToList<invoice_items>();
			if (source.Any<invoice_items>())
			{
				return (from item in source
				select new InvoiceItem(item.id, item.name, Fn.FormatSumm(item.price), item.count, item.units, new double?(item.tax), item.tax_mode, Fn.FormatSumm(item.total), item.invoice.Value, item.repair, item.document, item.workshop.ToRepairCard())).ToList<InvoiceItem>();
			}
			return new List<InvoiceItem>();
		}

		// Token: 0x060047E3 RID: 18403 RVA: 0x001179EC File Offset: 0x00115BEC
		public static IEnumerable<InvoiceItem> VATInvoiceItemsConverter(IEnumerable<invoice_items> items)
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
			select new InvoiceItem(item.id, item.name, Fn.FormatSumm(item.price), item.count, item.units, new double?(item.tax), item.tax_mode, Fn.FormatSumm(item.total), item.vat_invoice.Value, item.repair, item.document, item.workshop.ToRepairCard())).ToList<InvoiceItem>();
		}

		// Token: 0x060047E4 RID: 18404 RVA: 0x000046B4 File Offset: 0x000028B4
		public InvoiceItemsMapper()
		{
		}

		// Token: 0x02000907 RID: 2311
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060047E5 RID: 18405 RVA: 0x00117A44 File Offset: 0x00115C44
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060047E6 RID: 18406 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x060047E7 RID: 18407 RVA: 0x00117A5C File Offset: 0x00115C5C
			internal InvoiceItem <WorksListItemsConverter>b__0_0(invoice_items item)
			{
				return new InvoiceItem(item.id, item.name, Fn.FormatSumm(item.price), item.count, item.units, new double?(item.tax), item.tax_mode, Fn.FormatSumm(item.total), item.w_list.Value, item.repair, item.document, item.workshop.ToRepairCard());
			}

			// Token: 0x060047E8 RID: 18408 RVA: 0x00117AD4 File Offset: 0x00115CD4
			internal InvoiceItem <InvoiceItemsConverter>b__1_0(invoice_items item)
			{
				return new InvoiceItem(item.id, item.name, Fn.FormatSumm(item.price), item.count, item.units, new double?(item.tax), item.tax_mode, Fn.FormatSumm(item.total), item.invoice.Value, item.repair, item.document, item.workshop.ToRepairCard());
			}

			// Token: 0x060047E9 RID: 18409 RVA: 0x00117B4C File Offset: 0x00115D4C
			internal InvoiceItem <VATInvoiceItemsConverter>b__2_0(invoice_items item)
			{
				return new InvoiceItem(item.id, item.name, Fn.FormatSumm(item.price), item.count, item.units, new double?(item.tax), item.tax_mode, Fn.FormatSumm(item.total), item.vat_invoice.Value, item.repair, item.document, item.workshop.ToRepairCard());
			}

			// Token: 0x04002DFE RID: 11774
			public static readonly InvoiceItemsMapper.<>c <>9 = new InvoiceItemsMapper.<>c();

			// Token: 0x04002DFF RID: 11775
			public static Func<invoice_items, InvoiceItem> <>9__0_0;

			// Token: 0x04002E00 RID: 11776
			public static Func<invoice_items, InvoiceItem> <>9__1_0;

			// Token: 0x04002E01 RID: 11777
			public static Func<invoice_items, InvoiceItem> <>9__2_0;
		}
	}
}
