using System;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x0200008E RID: 142
	public class workshop_parts
	{
		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x060011E9 RID: 4585 RVA: 0x000217FC File Offset: 0x0001F9FC
		// (set) Token: 0x060011EA RID: 4586 RVA: 0x00021810 File Offset: 0x0001FA10
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

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x060011EB RID: 4587 RVA: 0x00021824 File Offset: 0x0001FA24
		// (set) Token: 0x060011EC RID: 4588 RVA: 0x00021838 File Offset: 0x0001FA38
		public int part_id
		{
			[CompilerGenerated]
			get
			{
				return this.<part_id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<part_id>k__BackingField = value;
			}
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x060011ED RID: 4589 RVA: 0x0002184C File Offset: 0x0001FA4C
		// (set) Token: 0x060011EE RID: 4590 RVA: 0x00021860 File Offset: 0x0001FA60
		public int? count
		{
			[CompilerGenerated]
			get
			{
				return this.<count>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<count>k__BackingField = value;
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x060011EF RID: 4591 RVA: 0x00021874 File Offset: 0x0001FA74
		// (set) Token: 0x060011F0 RID: 4592 RVA: 0x00021888 File Offset: 0x0001FA88
		public int master
		{
			[CompilerGenerated]
			get
			{
				return this.<master>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<master>k__BackingField = value;
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x060011F1 RID: 4593 RVA: 0x0002189C File Offset: 0x0001FA9C
		// (set) Token: 0x060011F2 RID: 4594 RVA: 0x000218B0 File Offset: 0x0001FAB0
		public int? state
		{
			[CompilerGenerated]
			get
			{
				return this.<state>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<state>k__BackingField = value;
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x060011F3 RID: 4595 RVA: 0x000218C4 File Offset: 0x0001FAC4
		// (set) Token: 0x060011F4 RID: 4596 RVA: 0x000218D8 File Offset: 0x0001FAD8
		public int repair_id
		{
			[CompilerGenerated]
			get
			{
				return this.<repair_id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<repair_id>k__BackingField = value;
			}
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x060011F5 RID: 4597 RVA: 0x000218EC File Offset: 0x0001FAEC
		// (set) Token: 0x060011F6 RID: 4598 RVA: 0x00021900 File Offset: 0x0001FB00
		public virtual workshop workshop
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

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x060011F7 RID: 4599 RVA: 0x00021914 File Offset: 0x0001FB14
		// (set) Token: 0x060011F8 RID: 4600 RVA: 0x00021928 File Offset: 0x0001FB28
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

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x060011F9 RID: 4601 RVA: 0x0002193C File Offset: 0x0001FB3C
		// (set) Token: 0x060011FA RID: 4602 RVA: 0x00021950 File Offset: 0x0001FB50
		public virtual users users
		{
			[CompilerGenerated]
			get
			{
				return this.<users>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<users>k__BackingField = value;
			}
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x000046B4 File Offset: 0x000028B4
		public workshop_parts()
		{
		}

		// Token: 0x04000874 RID: 2164
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x04000875 RID: 2165
		[CompilerGenerated]
		private int <part_id>k__BackingField;

		// Token: 0x04000876 RID: 2166
		[CompilerGenerated]
		private int? <count>k__BackingField;

		// Token: 0x04000877 RID: 2167
		[CompilerGenerated]
		private int <master>k__BackingField;

		// Token: 0x04000878 RID: 2168
		[CompilerGenerated]
		private int? <state>k__BackingField;

		// Token: 0x04000879 RID: 2169
		[CompilerGenerated]
		private int <repair_id>k__BackingField;

		// Token: 0x0400087A RID: 2170
		[CompilerGenerated]
		private workshop <workshop>k__BackingField;

		// Token: 0x0400087B RID: 2171
		[CompilerGenerated]
		private store_items <store_items>k__BackingField;

		// Token: 0x0400087C RID: 2172
		[CompilerGenerated]
		private users <users>k__BackingField;
	}
}
