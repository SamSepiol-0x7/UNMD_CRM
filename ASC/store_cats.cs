using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x02000073 RID: 115
	public class store_cats
	{
		// Token: 0x06000D0C RID: 3340 RVA: 0x00017A90 File Offset: 0x00015C90
		public store_cats()
		{
			this.store_cats1 = new HashSet<store_cats>();
			this.store_items = new HashSet<store_items>();
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06000D0D RID: 3341 RVA: 0x00017ABC File Offset: 0x00015CBC
		// (set) Token: 0x06000D0E RID: 3342 RVA: 0x00017AD0 File Offset: 0x00015CD0
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

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06000D0F RID: 3343 RVA: 0x00017AE4 File Offset: 0x00015CE4
		// (set) Token: 0x06000D10 RID: 3344 RVA: 0x00017AF8 File Offset: 0x00015CF8
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

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06000D11 RID: 3345 RVA: 0x00017B0C File Offset: 0x00015D0C
		// (set) Token: 0x06000D12 RID: 3346 RVA: 0x00017B20 File Offset: 0x00015D20
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

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06000D13 RID: 3347 RVA: 0x00017B34 File Offset: 0x00015D34
		// (set) Token: 0x06000D14 RID: 3348 RVA: 0x00017B48 File Offset: 0x00015D48
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

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06000D15 RID: 3349 RVA: 0x00017B5C File Offset: 0x00015D5C
		// (set) Token: 0x06000D16 RID: 3350 RVA: 0x00017B70 File Offset: 0x00015D70
		public bool? enable
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

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06000D17 RID: 3351 RVA: 0x00017B84 File Offset: 0x00015D84
		// (set) Token: 0x06000D18 RID: 3352 RVA: 0x00017B98 File Offset: 0x00015D98
		public int? store_id
		{
			[CompilerGenerated]
			get
			{
				return this.<store_id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<store_id>k__BackingField = value;
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06000D19 RID: 3353 RVA: 0x00017BAC File Offset: 0x00015DAC
		// (set) Token: 0x06000D1A RID: 3354 RVA: 0x00017BC0 File Offset: 0x00015DC0
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

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06000D1B RID: 3355 RVA: 0x00017BD4 File Offset: 0x00015DD4
		// (set) Token: 0x06000D1C RID: 3356 RVA: 0x00017BE8 File Offset: 0x00015DE8
		public virtual ICollection<store_cats> store_cats1
		{
			[CompilerGenerated]
			get
			{
				return this.<store_cats1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<store_cats1>k__BackingField = value;
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06000D1D RID: 3357 RVA: 0x00017BFC File Offset: 0x00015DFC
		// (set) Token: 0x06000D1E RID: 3358 RVA: 0x00017C10 File Offset: 0x00015E10
		public virtual store_cats store_cats2
		{
			[CompilerGenerated]
			get
			{
				return this.<store_cats2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<store_cats2>k__BackingField = value;
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06000D1F RID: 3359 RVA: 0x00017C24 File Offset: 0x00015E24
		// (set) Token: 0x06000D20 RID: 3360 RVA: 0x00017C38 File Offset: 0x00015E38
		public virtual stores stores
		{
			[CompilerGenerated]
			get
			{
				return this.<stores>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<stores>k__BackingField = value;
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06000D21 RID: 3361 RVA: 0x00017C4C File Offset: 0x00015E4C
		// (set) Token: 0x06000D22 RID: 3362 RVA: 0x00017C60 File Offset: 0x00015E60
		public virtual ICollection<store_items> store_items
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

		// Token: 0x0400063B RID: 1595
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x0400063C RID: 1596
		[CompilerGenerated]
		private string <name>k__BackingField;

		// Token: 0x0400063D RID: 1597
		[CompilerGenerated]
		private int? <parent>k__BackingField;

		// Token: 0x0400063E RID: 1598
		[CompilerGenerated]
		private int? <position>k__BackingField;

		// Token: 0x0400063F RID: 1599
		[CompilerGenerated]
		private bool? <enable>k__BackingField;

		// Token: 0x04000640 RID: 1600
		[CompilerGenerated]
		private int? <store_id>k__BackingField;

		// Token: 0x04000641 RID: 1601
		[CompilerGenerated]
		private string <ico>k__BackingField;

		// Token: 0x04000642 RID: 1602
		[CompilerGenerated]
		private ICollection<store_cats> <store_cats1>k__BackingField;

		// Token: 0x04000643 RID: 1603
		[CompilerGenerated]
		private store_cats <store_cats2>k__BackingField;

		// Token: 0x04000644 RID: 1604
		[CompilerGenerated]
		private stores <stores>k__BackingField;

		// Token: 0x04000645 RID: 1605
		[CompilerGenerated]
		private ICollection<store_items> <store_items>k__BackingField;
	}
}
