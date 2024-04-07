using System;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x0200001D RID: 29
	public class workshop_issued
	{
		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00004E2C File Offset: 0x0000302C
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00004E40 File Offset: 0x00003040
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

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00004E54 File Offset: 0x00003054
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x00004E68 File Offset: 0x00003068
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

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00004E7C File Offset: 0x0000307C
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x00004E90 File Offset: 0x00003090
		public int employee_id
		{
			[CompilerGenerated]
			get
			{
				return this.<employee_id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<employee_id>k__BackingField = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00004EA4 File Offset: 0x000030A4
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x00004EB8 File Offset: 0x000030B8
		public DateTime created_at
		{
			[CompilerGenerated]
			get
			{
				return this.<created_at>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<created_at>k__BackingField = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00004ECC File Offset: 0x000030CC
		// (set) Token: 0x060000FB RID: 251 RVA: 0x00004EE0 File Offset: 0x000030E0
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

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00004EF4 File Offset: 0x000030F4
		// (set) Token: 0x060000FD RID: 253 RVA: 0x00004F08 File Offset: 0x00003108
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

		// Token: 0x060000FE RID: 254 RVA: 0x000046B4 File Offset: 0x000028B4
		public workshop_issued()
		{
		}

		// Token: 0x0400005F RID: 95
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x04000060 RID: 96
		[CompilerGenerated]
		private int <repair_id>k__BackingField;

		// Token: 0x04000061 RID: 97
		[CompilerGenerated]
		private int <employee_id>k__BackingField;

		// Token: 0x04000062 RID: 98
		[CompilerGenerated]
		private DateTime <created_at>k__BackingField;

		// Token: 0x04000063 RID: 99
		[CompilerGenerated]
		private users <users>k__BackingField;

		// Token: 0x04000064 RID: 100
		[CompilerGenerated]
		private workshop <workshop>k__BackingField;
	}
}
