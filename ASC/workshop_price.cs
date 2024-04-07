using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x0200008F RID: 143
	public class workshop_price
	{
		// Token: 0x060011FC RID: 4604 RVA: 0x00021964 File Offset: 0x0001FB64
		public workshop_price()
		{
			this.works = new HashSet<works>();
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x060011FD RID: 4605 RVA: 0x00021984 File Offset: 0x0001FB84
		// (set) Token: 0x060011FE RID: 4606 RVA: 0x00021998 File Offset: 0x0001FB98
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

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x060011FF RID: 4607 RVA: 0x000219AC File Offset: 0x0001FBAC
		// (set) Token: 0x06001200 RID: 4608 RVA: 0x000219C0 File Offset: 0x0001FBC0
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

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06001201 RID: 4609 RVA: 0x000219D4 File Offset: 0x0001FBD4
		// (set) Token: 0x06001202 RID: 4610 RVA: 0x000219E8 File Offset: 0x0001FBE8
		public int category
		{
			[CompilerGenerated]
			get
			{
				return this.<category>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<category>k__BackingField = value;
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06001203 RID: 4611 RVA: 0x000219FC File Offset: 0x0001FBFC
		// (set) Token: 0x06001204 RID: 4612 RVA: 0x00021A10 File Offset: 0x0001FC10
		public int? warranty
		{
			[CompilerGenerated]
			get
			{
				return this.<warranty>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<warranty>k__BackingField = value;
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06001205 RID: 4613 RVA: 0x00021A24 File Offset: 0x0001FC24
		// (set) Token: 0x06001206 RID: 4614 RVA: 0x00021A38 File Offset: 0x0001FC38
		public decimal price1
		{
			[CompilerGenerated]
			get
			{
				return this.<price1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<price1>k__BackingField = value;
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06001207 RID: 4615 RVA: 0x00021A4C File Offset: 0x0001FC4C
		// (set) Token: 0x06001208 RID: 4616 RVA: 0x00021A60 File Offset: 0x0001FC60
		public decimal price2
		{
			[CompilerGenerated]
			get
			{
				return this.<price2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<price2>k__BackingField = value;
			}
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06001209 RID: 4617 RVA: 0x00021A74 File Offset: 0x0001FC74
		// (set) Token: 0x0600120A RID: 4618 RVA: 0x00021A88 File Offset: 0x0001FC88
		public bool enable
		{
			[CompilerGenerated]
			get
			{
				return this.<enable>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<enable>k__BackingField = value;
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x0600120B RID: 4619 RVA: 0x00021A9C File Offset: 0x0001FC9C
		// (set) Token: 0x0600120C RID: 4620 RVA: 0x00021AB0 File Offset: 0x0001FCB0
		public string notes
		{
			[CompilerGenerated]
			get
			{
				return this.<notes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<notes>k__BackingField = value;
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x0600120D RID: 4621 RVA: 0x00021AC4 File Offset: 0x0001FCC4
		// (set) Token: 0x0600120E RID: 4622 RVA: 0x00021AD8 File Offset: 0x0001FCD8
		public int master_part
		{
			[CompilerGenerated]
			get
			{
				return this.<master_part>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<master_part>k__BackingField = value;
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x0600120F RID: 4623 RVA: 0x00021AEC File Offset: 0x0001FCEC
		// (set) Token: 0x06001210 RID: 4624 RVA: 0x00021B00 File Offset: 0x0001FD00
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

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06001211 RID: 4625 RVA: 0x00021B14 File Offset: 0x0001FD14
		// (set) Token: 0x06001212 RID: 4626 RVA: 0x00021B28 File Offset: 0x0001FD28
		public virtual workshop_cats workshop_cats
		{
			[CompilerGenerated]
			get
			{
				return this.<workshop_cats>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<workshop_cats>k__BackingField = value;
			}
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06001213 RID: 4627 RVA: 0x00021B3C File Offset: 0x0001FD3C
		// (set) Token: 0x06001214 RID: 4628 RVA: 0x00021B50 File Offset: 0x0001FD50
		public virtual ICollection<works> works
		{
			[CompilerGenerated]
			get
			{
				return this.<works>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<works>k__BackingField = value;
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06001215 RID: 4629 RVA: 0x00021B64 File Offset: 0x0001FD64
		// (set) Token: 0x06001216 RID: 4630 RVA: 0x00021B78 File Offset: 0x0001FD78
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

		// Token: 0x0400087D RID: 2173
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x0400087E RID: 2174
		[CompilerGenerated]
		private string <name>k__BackingField;

		// Token: 0x0400087F RID: 2175
		[CompilerGenerated]
		private int <category>k__BackingField;

		// Token: 0x04000880 RID: 2176
		[CompilerGenerated]
		private int? <warranty>k__BackingField;

		// Token: 0x04000881 RID: 2177
		[CompilerGenerated]
		private decimal <price1>k__BackingField;

		// Token: 0x04000882 RID: 2178
		[CompilerGenerated]
		private decimal <price2>k__BackingField;

		// Token: 0x04000883 RID: 2179
		[CompilerGenerated]
		private bool <enable>k__BackingField;

		// Token: 0x04000884 RID: 2180
		[CompilerGenerated]
		private string <notes>k__BackingField;

		// Token: 0x04000885 RID: 2181
		[CompilerGenerated]
		private int <master_part>k__BackingField;

		// Token: 0x04000886 RID: 2182
		[CompilerGenerated]
		private int? <vendor_id>k__BackingField;

		// Token: 0x04000887 RID: 2183
		[CompilerGenerated]
		private workshop_cats <workshop_cats>k__BackingField;

		// Token: 0x04000888 RID: 2184
		[CompilerGenerated]
		private ICollection<works> <works>k__BackingField;

		// Token: 0x04000889 RID: 2185
		[CompilerGenerated]
		private vendors <vendors>k__BackingField;
	}
}
