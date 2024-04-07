using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x0200001C RID: 28
	public class vendors
	{
		// Token: 0x060000D9 RID: 217 RVA: 0x00004C18 File Offset: 0x00002E18
		public vendors()
		{
			this.workshop = new HashSet<workshop>();
			this.workshop_price = new HashSet<workshop_price>();
			this.workshop_cats = new HashSet<workshop_cats>();
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00004C4C File Offset: 0x00002E4C
		// (set) Token: 0x060000DB RID: 219 RVA: 0x00004C60 File Offset: 0x00002E60
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

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00004C74 File Offset: 0x00002E74
		// (set) Token: 0x060000DD RID: 221 RVA: 0x00004C88 File Offset: 0x00002E88
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

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00004C9C File Offset: 0x00002E9C
		// (set) Token: 0x060000DF RID: 223 RVA: 0x00004CB0 File Offset: 0x00002EB0
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

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00004CC4 File Offset: 0x00002EC4
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x00004CD8 File Offset: 0x00002ED8
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

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00004CEC File Offset: 0x00002EEC
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x00004D00 File Offset: 0x00002F00
		public DateTime? updated_at
		{
			[CompilerGenerated]
			get
			{
				return this.<updated_at>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<updated_at>k__BackingField = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00004D14 File Offset: 0x00002F14
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x00004D28 File Offset: 0x00002F28
		public int parts_agent
		{
			[CompilerGenerated]
			get
			{
				return this.<parts_agent>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<parts_agent>k__BackingField = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00004D3C File Offset: 0x00002F3C
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x00004D50 File Offset: 0x00002F50
		public int works_agent
		{
			[CompilerGenerated]
			get
			{
				return this.<works_agent>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<works_agent>k__BackingField = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00004D64 File Offset: 0x00002F64
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x00004D78 File Offset: 0x00002F78
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

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00004D8C File Offset: 0x00002F8C
		// (set) Token: 0x060000EB RID: 235 RVA: 0x00004DA0 File Offset: 0x00002FA0
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

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00004DB4 File Offset: 0x00002FB4
		// (set) Token: 0x060000ED RID: 237 RVA: 0x00004DC8 File Offset: 0x00002FC8
		public virtual ICollection<workshop_cats> workshop_cats
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

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00004DDC File Offset: 0x00002FDC
		// (set) Token: 0x060000EF RID: 239 RVA: 0x00004DF0 File Offset: 0x00002FF0
		public virtual clients clients
		{
			[CompilerGenerated]
			get
			{
				return this.<clients>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<clients>k__BackingField = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00004E04 File Offset: 0x00003004
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x00004E18 File Offset: 0x00003018
		public virtual clients clients1
		{
			[CompilerGenerated]
			get
			{
				return this.<clients1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<clients1>k__BackingField = value;
			}
		}

		// Token: 0x04000053 RID: 83
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x04000054 RID: 84
		[CompilerGenerated]
		private string <name>k__BackingField;

		// Token: 0x04000055 RID: 85
		[CompilerGenerated]
		private bool <archive>k__BackingField;

		// Token: 0x04000056 RID: 86
		[CompilerGenerated]
		private DateTime <created_at>k__BackingField;

		// Token: 0x04000057 RID: 87
		[CompilerGenerated]
		private DateTime? <updated_at>k__BackingField;

		// Token: 0x04000058 RID: 88
		[CompilerGenerated]
		private int <parts_agent>k__BackingField;

		// Token: 0x04000059 RID: 89
		[CompilerGenerated]
		private int <works_agent>k__BackingField;

		// Token: 0x0400005A RID: 90
		[CompilerGenerated]
		private ICollection<workshop> <workshop>k__BackingField;

		// Token: 0x0400005B RID: 91
		[CompilerGenerated]
		private ICollection<workshop_price> <workshop_price>k__BackingField;

		// Token: 0x0400005C RID: 92
		[CompilerGenerated]
		private ICollection<workshop_cats> <workshop_cats>k__BackingField;

		// Token: 0x0400005D RID: 93
		[CompilerGenerated]
		private clients <clients>k__BackingField;

		// Token: 0x0400005E RID: 94
		[CompilerGenerated]
		private clients <clients1>k__BackingField;
	}
}
