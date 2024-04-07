using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x0200002F RID: 47
	public class cartridge_cards
	{
		// Token: 0x060002E2 RID: 738 RVA: 0x00008A34 File Offset: 0x00006C34
		public cartridge_cards()
		{
			this.materials = new HashSet<materials>();
			this.c_workshop = new HashSet<c_workshop>();
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x00008A60 File Offset: 0x00006C60
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x00008A74 File Offset: 0x00006C74
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

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x00008A88 File Offset: 0x00006C88
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x00008A9C File Offset: 0x00006C9C
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

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x00008AB0 File Offset: 0x00006CB0
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x00008AC4 File Offset: 0x00006CC4
		public int maker
		{
			[CompilerGenerated]
			get
			{
				return this.<maker>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<maker>k__BackingField = value;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x00008AD8 File Offset: 0x00006CD8
		// (set) Token: 0x060002EA RID: 746 RVA: 0x00008AEC File Offset: 0x00006CEC
		public double full_weight
		{
			[CompilerGenerated]
			get
			{
				return this.<full_weight>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<full_weight>k__BackingField = value;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060002EB RID: 747 RVA: 0x00008B00 File Offset: 0x00006D00
		// (set) Token: 0x060002EC RID: 748 RVA: 0x00008B14 File Offset: 0x00006D14
		public double toner_weight
		{
			[CompilerGenerated]
			get
			{
				return this.<toner_weight>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<toner_weight>k__BackingField = value;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060002ED RID: 749 RVA: 0x00008B28 File Offset: 0x00006D28
		// (set) Token: 0x060002EE RID: 750 RVA: 0x00008B3C File Offset: 0x00006D3C
		public int resource
		{
			[CompilerGenerated]
			get
			{
				return this.<resource>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<resource>k__BackingField = value;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060002EF RID: 751 RVA: 0x00008B50 File Offset: 0x00006D50
		// (set) Token: 0x060002F0 RID: 752 RVA: 0x00008B64 File Offset: 0x00006D64
		public DateTime created
		{
			[CompilerGenerated]
			get
			{
				return this.<created>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<created>k__BackingField = value;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x00008B78 File Offset: 0x00006D78
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x00008B8C File Offset: 0x00006D8C
		public int user
		{
			[CompilerGenerated]
			get
			{
				return this.<user>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<user>k__BackingField = value;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x00008BA0 File Offset: 0x00006DA0
		// (set) Token: 0x060002F4 RID: 756 RVA: 0x00008BB4 File Offset: 0x00006DB4
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

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x00008BC8 File Offset: 0x00006DC8
		// (set) Token: 0x060002F6 RID: 758 RVA: 0x00008BDC File Offset: 0x00006DDC
		public int? photo
		{
			[CompilerGenerated]
			get
			{
				return this.<photo>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<photo>k__BackingField = value;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x00008BF0 File Offset: 0x00006DF0
		// (set) Token: 0x060002F8 RID: 760 RVA: 0x00008C04 File Offset: 0x00006E04
		public int color
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

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x00008C18 File Offset: 0x00006E18
		// (set) Token: 0x060002FA RID: 762 RVA: 0x00008C2C File Offset: 0x00006E2C
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

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060002FB RID: 763 RVA: 0x00008C40 File Offset: 0x00006E40
		// (set) Token: 0x060002FC RID: 764 RVA: 0x00008C54 File Offset: 0x00006E54
		public virtual device_makers device_makers
		{
			[CompilerGenerated]
			get
			{
				return this.<device_makers>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<device_makers>k__BackingField = value;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060002FD RID: 765 RVA: 0x00008C68 File Offset: 0x00006E68
		// (set) Token: 0x060002FE RID: 766 RVA: 0x00008C7C File Offset: 0x00006E7C
		public virtual images images
		{
			[CompilerGenerated]
			get
			{
				return this.<images>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<images>k__BackingField = value;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060002FF RID: 767 RVA: 0x00008C90 File Offset: 0x00006E90
		// (set) Token: 0x06000300 RID: 768 RVA: 0x00008CA4 File Offset: 0x00006EA4
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

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000301 RID: 769 RVA: 0x00008CB8 File Offset: 0x00006EB8
		// (set) Token: 0x06000302 RID: 770 RVA: 0x00008CCC File Offset: 0x00006ECC
		public virtual ICollection<materials> materials
		{
			[CompilerGenerated]
			get
			{
				return this.<materials>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<materials>k__BackingField = value;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000303 RID: 771 RVA: 0x00008CE0 File Offset: 0x00006EE0
		// (set) Token: 0x06000304 RID: 772 RVA: 0x00008CF4 File Offset: 0x00006EF4
		public virtual ICollection<c_workshop> c_workshop
		{
			[CompilerGenerated]
			get
			{
				return this.<c_workshop>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<c_workshop>k__BackingField = value;
			}
		}

		// Token: 0x0400015B RID: 347
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x0400015C RID: 348
		[CompilerGenerated]
		private string <name>k__BackingField;

		// Token: 0x0400015D RID: 349
		[CompilerGenerated]
		private int <maker>k__BackingField;

		// Token: 0x0400015E RID: 350
		[CompilerGenerated]
		private double <full_weight>k__BackingField;

		// Token: 0x0400015F RID: 351
		[CompilerGenerated]
		private double <toner_weight>k__BackingField;

		// Token: 0x04000160 RID: 352
		[CompilerGenerated]
		private int <resource>k__BackingField;

		// Token: 0x04000161 RID: 353
		[CompilerGenerated]
		private DateTime <created>k__BackingField;

		// Token: 0x04000162 RID: 354
		[CompilerGenerated]
		private int <user>k__BackingField;

		// Token: 0x04000163 RID: 355
		[CompilerGenerated]
		private string <notes>k__BackingField;

		// Token: 0x04000164 RID: 356
		[CompilerGenerated]
		private int? <photo>k__BackingField;

		// Token: 0x04000165 RID: 357
		[CompilerGenerated]
		private int <color>k__BackingField;

		// Token: 0x04000166 RID: 358
		[CompilerGenerated]
		private bool <archive>k__BackingField;

		// Token: 0x04000167 RID: 359
		[CompilerGenerated]
		private device_makers <device_makers>k__BackingField;

		// Token: 0x04000168 RID: 360
		[CompilerGenerated]
		private images <images>k__BackingField;

		// Token: 0x04000169 RID: 361
		[CompilerGenerated]
		private users <users>k__BackingField;

		// Token: 0x0400016A RID: 362
		[CompilerGenerated]
		private ICollection<materials> <materials>k__BackingField;

		// Token: 0x0400016B RID: 363
		[CompilerGenerated]
		private ICollection<c_workshop> <c_workshop>k__BackingField;
	}
}
