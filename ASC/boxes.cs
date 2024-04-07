using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x0200002E RID: 46
	public class boxes
	{
		// Token: 0x060002CF RID: 719 RVA: 0x000088A0 File Offset: 0x00006AA0
		public boxes()
		{
			this.store_items = new HashSet<store_items>();
			this.workshop = new HashSet<workshop>();
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x000088CC File Offset: 0x00006ACC
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x000088E0 File Offset: 0x00006AE0
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

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x000088F4 File Offset: 0x00006AF4
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x00008908 File Offset: 0x00006B08
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

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x0000891C File Offset: 0x00006B1C
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x00008930 File Offset: 0x00006B30
		public int places
		{
			[CompilerGenerated]
			get
			{
				return this.<places>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<places>k__BackingField = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x00008944 File Offset: 0x00006B44
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x00008958 File Offset: 0x00006B58
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

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x0000896C File Offset: 0x00006B6C
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x00008980 File Offset: 0x00006B80
		public bool non_items
		{
			[CompilerGenerated]
			get
			{
				return this.<non_items>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<non_items>k__BackingField = value;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060002DA RID: 730 RVA: 0x00008994 File Offset: 0x00006B94
		// (set) Token: 0x060002DB RID: 731 RVA: 0x000089A8 File Offset: 0x00006BA8
		public string color
		{
			[CompilerGenerated]
			get
			{
				return this.<color>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<color>k__BackingField = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060002DC RID: 732 RVA: 0x000089BC File Offset: 0x00006BBC
		// (set) Token: 0x060002DD RID: 733 RVA: 0x000089D0 File Offset: 0x00006BD0
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

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060002DE RID: 734 RVA: 0x000089E4 File Offset: 0x00006BE4
		// (set) Token: 0x060002DF RID: 735 RVA: 0x000089F8 File Offset: 0x00006BF8
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

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x00008A0C File Offset: 0x00006C0C
		// (set) Token: 0x060002E1 RID: 737 RVA: 0x00008A20 File Offset: 0x00006C20
		public virtual ICollection<workshop> workshop
		{
			[CompilerGenerated]
			get
			{
				return this.<workshop>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<workshop>k__BackingField = value;
			}
		}

		// Token: 0x04000152 RID: 338
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x04000153 RID: 339
		[CompilerGenerated]
		private string <name>k__BackingField;

		// Token: 0x04000154 RID: 340
		[CompilerGenerated]
		private int <places>k__BackingField;

		// Token: 0x04000155 RID: 341
		[CompilerGenerated]
		private int? <store_id>k__BackingField;

		// Token: 0x04000156 RID: 342
		[CompilerGenerated]
		private bool <non_items>k__BackingField;

		// Token: 0x04000157 RID: 343
		[CompilerGenerated]
		private string <color>k__BackingField;

		// Token: 0x04000158 RID: 344
		[CompilerGenerated]
		private stores <stores>k__BackingField;

		// Token: 0x04000159 RID: 345
		[CompilerGenerated]
		private ICollection<store_items> <store_items>k__BackingField;

		// Token: 0x0400015A RID: 346
		[CompilerGenerated]
		private ICollection<workshop> <workshop>k__BackingField;
	}
}
