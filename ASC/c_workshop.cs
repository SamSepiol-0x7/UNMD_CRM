using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x02000036 RID: 54
	public class c_workshop
	{
		// Token: 0x060004D5 RID: 1237 RVA: 0x0000BDF0 File Offset: 0x00009FF0
		public c_workshop()
		{
			this.workshop = new HashSet<workshop>();
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x0000BE10 File Offset: 0x0000A010
		// (set) Token: 0x060004D7 RID: 1239 RVA: 0x0000BE24 File Offset: 0x0000A024
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

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x0000BE38 File Offset: 0x0000A038
		// (set) Token: 0x060004D9 RID: 1241 RVA: 0x0000BE4C File Offset: 0x0000A04C
		public bool refill
		{
			[CompilerGenerated]
			get
			{
				return this.<refill>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<refill>k__BackingField = value;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x0000BE60 File Offset: 0x0000A060
		// (set) Token: 0x060004DB RID: 1243 RVA: 0x0000BE74 File Offset: 0x0000A074
		public bool chip
		{
			[CompilerGenerated]
			get
			{
				return this.<chip>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<chip>k__BackingField = value;
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x0000BE88 File Offset: 0x0000A088
		// (set) Token: 0x060004DD RID: 1245 RVA: 0x0000BE9C File Offset: 0x0000A09C
		public bool opc_drum
		{
			[CompilerGenerated]
			get
			{
				return this.<opc_drum>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<opc_drum>k__BackingField = value;
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x0000BEB0 File Offset: 0x0000A0B0
		// (set) Token: 0x060004DF RID: 1247 RVA: 0x0000BEC4 File Offset: 0x0000A0C4
		public bool c_blade
		{
			[CompilerGenerated]
			get
			{
				return this.<c_blade>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<c_blade>k__BackingField = value;
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x0000BED8 File Offset: 0x0000A0D8
		// (set) Token: 0x060004E1 RID: 1249 RVA: 0x0000BEEC File Offset: 0x0000A0EC
		public int card_id
		{
			[CompilerGenerated]
			get
			{
				return this.<card_id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<card_id>k__BackingField = value;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x0000BF00 File Offset: 0x0000A100
		// (set) Token: 0x060004E3 RID: 1251 RVA: 0x0000BF14 File Offset: 0x0000A114
		public virtual cartridge_cards cartridge_cards
		{
			[CompilerGenerated]
			get
			{
				return this.<cartridge_cards>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<cartridge_cards>k__BackingField = value;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060004E4 RID: 1252 RVA: 0x0000BF28 File Offset: 0x0000A128
		// (set) Token: 0x060004E5 RID: 1253 RVA: 0x0000BF3C File Offset: 0x0000A13C
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

		// Token: 0x04000250 RID: 592
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x04000251 RID: 593
		[CompilerGenerated]
		private bool <refill>k__BackingField;

		// Token: 0x04000252 RID: 594
		[CompilerGenerated]
		private bool <chip>k__BackingField;

		// Token: 0x04000253 RID: 595
		[CompilerGenerated]
		private bool <opc_drum>k__BackingField;

		// Token: 0x04000254 RID: 596
		[CompilerGenerated]
		private bool <c_blade>k__BackingField;

		// Token: 0x04000255 RID: 597
		[CompilerGenerated]
		private int <card_id>k__BackingField;

		// Token: 0x04000256 RID: 598
		[CompilerGenerated]
		private cartridge_cards <cartridge_cards>k__BackingField;

		// Token: 0x04000257 RID: 599
		[CompilerGenerated]
		private ICollection<workshop> <workshop>k__BackingField;
	}
}
