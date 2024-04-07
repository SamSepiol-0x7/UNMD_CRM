using System;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces.Extensions.OpenCart;
using Newtonsoft.Json;

namespace ASC.Extensions.OpenCart.Models
{
	// Token: 0x02000BA4 RID: 2980
	public class Total : ITotal
	{
		// Token: 0x17001582 RID: 5506
		// (get) Token: 0x06005385 RID: 21381 RVA: 0x00165944 File Offset: 0x00163B44
		// (set) Token: 0x06005386 RID: 21382 RVA: 0x00165958 File Offset: 0x00163B58
		[JsonProperty("order_total_id")]
		public int OrderTotalId
		{
			[CompilerGenerated]
			get
			{
				return this.<OrderTotalId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<OrderTotalId>k__BackingField = value;
			}
		}

		// Token: 0x17001583 RID: 5507
		// (get) Token: 0x06005387 RID: 21383 RVA: 0x0016596C File Offset: 0x00163B6C
		// (set) Token: 0x06005388 RID: 21384 RVA: 0x00165980 File Offset: 0x00163B80
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

		// Token: 0x17001584 RID: 5508
		// (get) Token: 0x06005389 RID: 21385 RVA: 0x00165994 File Offset: 0x00163B94
		// (set) Token: 0x0600538A RID: 21386 RVA: 0x001659A8 File Offset: 0x00163BA8
		[JsonProperty("code")]
		public string Code
		{
			[CompilerGenerated]
			get
			{
				return this.<Code>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Code>k__BackingField = value;
			}
		}

		// Token: 0x17001585 RID: 5509
		// (get) Token: 0x0600538B RID: 21387 RVA: 0x001659BC File Offset: 0x00163BBC
		// (set) Token: 0x0600538C RID: 21388 RVA: 0x001659D0 File Offset: 0x00163BD0
		[JsonProperty("title")]
		public string Title
		{
			[CompilerGenerated]
			get
			{
				return this.<Title>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Title>k__BackingField = value;
			}
		}

		// Token: 0x17001586 RID: 5510
		// (get) Token: 0x0600538D RID: 21389 RVA: 0x001659E4 File Offset: 0x00163BE4
		// (set) Token: 0x0600538E RID: 21390 RVA: 0x001659F8 File Offset: 0x00163BF8
		[JsonProperty("value")]
		public string Value
		{
			[CompilerGenerated]
			get
			{
				return this.<Value>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Value>k__BackingField = value;
			}
		}

		// Token: 0x17001587 RID: 5511
		// (get) Token: 0x0600538F RID: 21391 RVA: 0x00165A0C File Offset: 0x00163C0C
		// (set) Token: 0x06005390 RID: 21392 RVA: 0x00165A20 File Offset: 0x00163C20
		[JsonProperty("sort_order")]
		public int SortOrder
		{
			[CompilerGenerated]
			get
			{
				return this.<SortOrder>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<SortOrder>k__BackingField = value;
			}
		}

		// Token: 0x06005391 RID: 21393 RVA: 0x000046B4 File Offset: 0x000028B4
		public Total()
		{
		}

		// Token: 0x040036FA RID: 14074
		[CompilerGenerated]
		private int <OrderTotalId>k__BackingField;

		// Token: 0x040036FB RID: 14075
		[CompilerGenerated]
		private int <OrderId>k__BackingField;

		// Token: 0x040036FC RID: 14076
		[CompilerGenerated]
		private string <Code>k__BackingField;

		// Token: 0x040036FD RID: 14077
		[CompilerGenerated]
		private string <Title>k__BackingField;

		// Token: 0x040036FE RID: 14078
		[CompilerGenerated]
		private string <Value>k__BackingField;

		// Token: 0x040036FF RID: 14079
		[CompilerGenerated]
		private int <SortOrder>k__BackingField;
	}
}
