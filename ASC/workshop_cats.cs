using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x0200008D RID: 141
	public class workshop_cats
	{
		// Token: 0x060011D2 RID: 4562 RVA: 0x00021618 File Offset: 0x0001F818
		public workshop_cats()
		{
			this.workshop_cats1 = new HashSet<workshop_cats>();
			this.workshop_price = new HashSet<workshop_price>();
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x060011D3 RID: 4563 RVA: 0x00021644 File Offset: 0x0001F844
		// (set) Token: 0x060011D4 RID: 4564 RVA: 0x00021658 File Offset: 0x0001F858
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

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x060011D5 RID: 4565 RVA: 0x0002166C File Offset: 0x0001F86C
		// (set) Token: 0x060011D6 RID: 4566 RVA: 0x00021680 File Offset: 0x0001F880
		public string name
		{
			[CompilerGenerated]
			get
			{
				return this.<name>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<name>k__BackingField = value;
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x060011D7 RID: 4567 RVA: 0x00021694 File Offset: 0x0001F894
		// (set) Token: 0x060011D8 RID: 4568 RVA: 0x000216A8 File Offset: 0x0001F8A8
		public int? parent
		{
			[CompilerGenerated]
			get
			{
				return this.<parent>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<parent>k__BackingField = value;
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x060011D9 RID: 4569 RVA: 0x000216BC File Offset: 0x0001F8BC
		// (set) Token: 0x060011DA RID: 4570 RVA: 0x000216D0 File Offset: 0x0001F8D0
		public int? position
		{
			[CompilerGenerated]
			get
			{
				return this.<position>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<position>k__BackingField = value;
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x060011DB RID: 4571 RVA: 0x000216E4 File Offset: 0x0001F8E4
		// (set) Token: 0x060011DC RID: 4572 RVA: 0x000216F8 File Offset: 0x0001F8F8
		public bool archive
		{
			[CompilerGenerated]
			get
			{
				return this.<archive>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<archive>k__BackingField = value;
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x060011DD RID: 4573 RVA: 0x0002170C File Offset: 0x0001F90C
		// (set) Token: 0x060011DE RID: 4574 RVA: 0x00021720 File Offset: 0x0001F920
		public string ico
		{
			[CompilerGenerated]
			get
			{
				return this.<ico>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ico>k__BackingField = value;
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x060011DF RID: 4575 RVA: 0x00021734 File Offset: 0x0001F934
		// (set) Token: 0x060011E0 RID: 4576 RVA: 0x00021748 File Offset: 0x0001F948
		public int? vendor_id
		{
			[CompilerGenerated]
			get
			{
				return this.<vendor_id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<vendor_id>k__BackingField = value;
			}
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x060011E1 RID: 4577 RVA: 0x0002175C File Offset: 0x0001F95C
		// (set) Token: 0x060011E2 RID: 4578 RVA: 0x00021770 File Offset: 0x0001F970
		public virtual ICollection<workshop_cats> workshop_cats1
		{
			[CompilerGenerated]
			get
			{
				return this.<workshop_cats1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<workshop_cats1>k__BackingField = value;
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x060011E3 RID: 4579 RVA: 0x00021784 File Offset: 0x0001F984
		// (set) Token: 0x060011E4 RID: 4580 RVA: 0x00021798 File Offset: 0x0001F998
		public virtual workshop_cats workshop_cats2
		{
			[CompilerGenerated]
			get
			{
				return this.<workshop_cats2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<workshop_cats2>k__BackingField = value;
			}
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x060011E5 RID: 4581 RVA: 0x000217AC File Offset: 0x0001F9AC
		// (set) Token: 0x060011E6 RID: 4582 RVA: 0x000217C0 File Offset: 0x0001F9C0
		public virtual ICollection<workshop_price> workshop_price
		{
			[CompilerGenerated]
			get
			{
				return this.<workshop_price>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<workshop_price>k__BackingField = value;
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x060011E7 RID: 4583 RVA: 0x000217D4 File Offset: 0x0001F9D4
		// (set) Token: 0x060011E8 RID: 4584 RVA: 0x000217E8 File Offset: 0x0001F9E8
		public virtual vendors vendors
		{
			[CompilerGenerated]
			get
			{
				return this.<vendors>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<vendors>k__BackingField = value;
			}
		}

		// Token: 0x04000869 RID: 2153
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x0400086A RID: 2154
		[CompilerGenerated]
		private string <name>k__BackingField;

		// Token: 0x0400086B RID: 2155
		[CompilerGenerated]
		private int? <parent>k__BackingField;

		// Token: 0x0400086C RID: 2156
		[CompilerGenerated]
		private int? <position>k__BackingField;

		// Token: 0x0400086D RID: 2157
		[CompilerGenerated]
		private bool <archive>k__BackingField;

		// Token: 0x0400086E RID: 2158
		[CompilerGenerated]
		private string <ico>k__BackingField;

		// Token: 0x0400086F RID: 2159
		[CompilerGenerated]
		private int? <vendor_id>k__BackingField;

		// Token: 0x04000870 RID: 2160
		[CompilerGenerated]
		private ICollection<workshop_cats> <workshop_cats1>k__BackingField;

		// Token: 0x04000871 RID: 2161
		[CompilerGenerated]
		private workshop_cats <workshop_cats2>k__BackingField;

		// Token: 0x04000872 RID: 2162
		[CompilerGenerated]
		private ICollection<workshop_price> <workshop_price>k__BackingField;

		// Token: 0x04000873 RID: 2163
		[CompilerGenerated]
		private vendors <vendors>k__BackingField;
	}
}
