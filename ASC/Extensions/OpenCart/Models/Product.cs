using System;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces.Extensions.OpenCart;
using Newtonsoft.Json;

namespace ASC.Extensions.OpenCart.Models
{
	// Token: 0x02000BA3 RID: 2979
	public class Product : IProduct
	{
		// Token: 0x17001577 RID: 5495
		// (get) Token: 0x0600536E RID: 21358 RVA: 0x0016578C File Offset: 0x0016398C
		// (set) Token: 0x0600536F RID: 21359 RVA: 0x001657A0 File Offset: 0x001639A0
		[JsonProperty("order_product_id")]
		public int OrderProductId
		{
			[CompilerGenerated]
			get
			{
				return this.<OrderProductId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<OrderProductId>k__BackingField = value;
			}
		}

		// Token: 0x17001578 RID: 5496
		// (get) Token: 0x06005370 RID: 21360 RVA: 0x001657B4 File Offset: 0x001639B4
		// (set) Token: 0x06005371 RID: 21361 RVA: 0x001657C8 File Offset: 0x001639C8
		[JsonProperty("order_id")]
		public int OrderId
		{
			[CompilerGenerated]
			get
			{
				return this.<OrderId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<OrderId>k__BackingField = value;
			}
		}

		// Token: 0x17001579 RID: 5497
		// (get) Token: 0x06005372 RID: 21362 RVA: 0x001657DC File Offset: 0x001639DC
		// (set) Token: 0x06005373 RID: 21363 RVA: 0x001657F0 File Offset: 0x001639F0
		[JsonProperty("product_id")]
		public int ProductId
		{
			[CompilerGenerated]
			get
			{
				return this.<ProductId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ProductId>k__BackingField = value;
			}
		}

		// Token: 0x1700157A RID: 5498
		// (get) Token: 0x06005374 RID: 21364 RVA: 0x00165804 File Offset: 0x00163A04
		// (set) Token: 0x06005375 RID: 21365 RVA: 0x00165818 File Offset: 0x00163A18
		[JsonProperty("name")]
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.<Name>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x1700157B RID: 5499
		// (get) Token: 0x06005376 RID: 21366 RVA: 0x0016582C File Offset: 0x00163A2C
		// (set) Token: 0x06005377 RID: 21367 RVA: 0x00165840 File Offset: 0x00163A40
		[JsonProperty("model")]
		public string Model
		{
			[CompilerGenerated]
			get
			{
				return this.<Model>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Model>k__BackingField = value;
			}
		}

		// Token: 0x1700157C RID: 5500
		// (get) Token: 0x06005378 RID: 21368 RVA: 0x00165854 File Offset: 0x00163A54
		// (set) Token: 0x06005379 RID: 21369 RVA: 0x00165868 File Offset: 0x00163A68
		[JsonProperty("quantity")]
		public int Quantity
		{
			[CompilerGenerated]
			get
			{
				return this.<Quantity>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Quantity>k__BackingField = value;
			}
		}

		// Token: 0x1700157D RID: 5501
		// (get) Token: 0x0600537A RID: 21370 RVA: 0x0016587C File Offset: 0x00163A7C
		// (set) Token: 0x0600537B RID: 21371 RVA: 0x00165890 File Offset: 0x00163A90
		[JsonProperty("price")]
		public decimal Price
		{
			[CompilerGenerated]
			get
			{
				return this.<Price>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Price>k__BackingField = value;
			}
		}

		// Token: 0x1700157E RID: 5502
		// (get) Token: 0x0600537C RID: 21372 RVA: 0x001658A4 File Offset: 0x00163AA4
		// (set) Token: 0x0600537D RID: 21373 RVA: 0x001658B8 File Offset: 0x00163AB8
		[JsonProperty("total")]
		public decimal Total
		{
			[CompilerGenerated]
			get
			{
				return this.<Total>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Total>k__BackingField = value;
			}
		}

		// Token: 0x1700157F RID: 5503
		// (get) Token: 0x0600537E RID: 21374 RVA: 0x001658CC File Offset: 0x00163ACC
		// (set) Token: 0x0600537F RID: 21375 RVA: 0x001658E0 File Offset: 0x00163AE0
		[JsonProperty("tax")]
		public decimal Tax
		{
			[CompilerGenerated]
			get
			{
				return this.<Tax>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Tax>k__BackingField = value;
			}
		}

		// Token: 0x17001580 RID: 5504
		// (get) Token: 0x06005380 RID: 21376 RVA: 0x001658F4 File Offset: 0x00163AF4
		// (set) Token: 0x06005381 RID: 21377 RVA: 0x00165908 File Offset: 0x00163B08
		[JsonProperty("reward")]
		public int Reward
		{
			[CompilerGenerated]
			get
			{
				return this.<Reward>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Reward>k__BackingField = value;
			}
		}

		// Token: 0x17001581 RID: 5505
		// (get) Token: 0x06005382 RID: 21378 RVA: 0x0016591C File Offset: 0x00163B1C
		// (set) Token: 0x06005383 RID: 21379 RVA: 0x00165930 File Offset: 0x00163B30
		[JsonProperty("sku")]
		public int? Sku
		{
			[CompilerGenerated]
			get
			{
				return this.<Sku>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Sku>k__BackingField = value;
			}
		}

		// Token: 0x06005384 RID: 21380 RVA: 0x000046B4 File Offset: 0x000028B4
		public Product()
		{
		}

		// Token: 0x040036EF RID: 14063
		[CompilerGenerated]
		private int <OrderProductId>k__BackingField;

		// Token: 0x040036F0 RID: 14064
		[CompilerGenerated]
		private int <OrderId>k__BackingField;

		// Token: 0x040036F1 RID: 14065
		[CompilerGenerated]
		private int <ProductId>k__BackingField;

		// Token: 0x040036F2 RID: 14066
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x040036F3 RID: 14067
		[CompilerGenerated]
		private string <Model>k__BackingField;

		// Token: 0x040036F4 RID: 14068
		[CompilerGenerated]
		private int <Quantity>k__BackingField;

		// Token: 0x040036F5 RID: 14069
		[CompilerGenerated]
		private decimal <Price>k__BackingField;

		// Token: 0x040036F6 RID: 14070
		[CompilerGenerated]
		private decimal <Total>k__BackingField;

		// Token: 0x040036F7 RID: 14071
		[CompilerGenerated]
		private decimal <Tax>k__BackingField;

		// Token: 0x040036F8 RID: 14072
		[CompilerGenerated]
		private int <Reward>k__BackingField;

		// Token: 0x040036F9 RID: 14073
		[CompilerGenerated]
		private int? <Sku>k__BackingField;
	}
}
