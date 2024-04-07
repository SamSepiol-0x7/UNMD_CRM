using System;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x02000052 RID: 82
	public class order_items
	{
		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000810 RID: 2064 RVA: 0x00010C74 File Offset: 0x0000EE74
		// (set) Token: 0x06000811 RID: 2065 RVA: 0x00010C88 File Offset: 0x0000EE88
		public int id
		{
			[CompilerGenerated]
			get
			{
				return this.<id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<id>k__BackingField = value;
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000812 RID: 2066 RVA: 0x00010C9C File Offset: 0x0000EE9C
		// (set) Token: 0x06000813 RID: 2067 RVA: 0x00010CB0 File Offset: 0x0000EEB0
		public int order_id
		{
			[CompilerGenerated]
			get
			{
				return this.<order_id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<order_id>k__BackingField = value;
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x00010CC4 File Offset: 0x0000EEC4
		// (set) Token: 0x06000815 RID: 2069 RVA: 0x00010CD8 File Offset: 0x0000EED8
		public int item_id
		{
			[CompilerGenerated]
			get
			{
				return this.<item_id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<item_id>k__BackingField = value;
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000816 RID: 2070 RVA: 0x00010CEC File Offset: 0x0000EEEC
		// (set) Token: 0x06000817 RID: 2071 RVA: 0x00010D00 File Offset: 0x0000EF00
		public int item_count
		{
			[CompilerGenerated]
			get
			{
				return this.<item_count>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<item_count>k__BackingField = value;
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000818 RID: 2072 RVA: 0x00010D14 File Offset: 0x0000EF14
		// (set) Token: 0x06000819 RID: 2073 RVA: 0x00010D28 File Offset: 0x0000EF28
		public virtual store_items store_items
		{
			[CompilerGenerated]
			get
			{
				return this.<store_items>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<store_items>k__BackingField = value;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x0600081A RID: 2074 RVA: 0x00010D3C File Offset: 0x0000EF3C
		// (set) Token: 0x0600081B RID: 2075 RVA: 0x00010D50 File Offset: 0x0000EF50
		public virtual cash_orders cash_orders
		{
			[CompilerGenerated]
			get
			{
				return this.<cash_orders>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<cash_orders>k__BackingField = value;
			}
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x000046B4 File Offset: 0x000028B4
		public order_items()
		{
		}

		// Token: 0x040003DB RID: 987
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x040003DC RID: 988
		[CompilerGenerated]
		private int <order_id>k__BackingField;

		// Token: 0x040003DD RID: 989
		[CompilerGenerated]
		private int <item_id>k__BackingField;

		// Token: 0x040003DE RID: 990
		[CompilerGenerated]
		private int <item_count>k__BackingField;

		// Token: 0x040003DF RID: 991
		[CompilerGenerated]
		private store_items <store_items>k__BackingField;

		// Token: 0x040003E0 RID: 992
		[CompilerGenerated]
		private cash_orders <cash_orders>k__BackingField;
	}
}
