using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x02000033 RID: 51
	public class companies
	{
		// Token: 0x060003E8 RID: 1000 RVA: 0x0000AB00 File Offset: 0x00008D00
		public companies()
		{
			this.status = true;
			this.banks1 = new HashSet<banks>();
			this.cash_orders = new HashSet<cash_orders>();
			this.docs = new HashSet<docs>();
			this.offices = new HashSet<offices>();
			this.workshop = new HashSet<workshop>();
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x0000AB54 File Offset: 0x00008D54
		// (set) Token: 0x060003EA RID: 1002 RVA: 0x0000AB68 File Offset: 0x00008D68
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

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x0000AB7C File Offset: 0x00008D7C
		// (set) Token: 0x060003EC RID: 1004 RVA: 0x0000AB90 File Offset: 0x00008D90
		public int? type
		{
			[CompilerGenerated]
			get
			{
				return this.<type>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<type>k__BackingField = value;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x0000ABA4 File Offset: 0x00008DA4
		// (set) Token: 0x060003EE RID: 1006 RVA: 0x0000ABB8 File Offset: 0x00008DB8
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

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x0000ABCC File Offset: 0x00008DCC
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x0000ABE0 File Offset: 0x00008DE0
		public string inn
		{
			[CompilerGenerated]
			get
			{
				return this.<inn>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<inn>k__BackingField = value;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x0000ABF4 File Offset: 0x00008DF4
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x0000AC08 File Offset: 0x00008E08
		public string kpp
		{
			[CompilerGenerated]
			get
			{
				return this.<kpp>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<kpp>k__BackingField = value;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x0000AC1C File Offset: 0x00008E1C
		// (set) Token: 0x060003F4 RID: 1012 RVA: 0x0000AC30 File Offset: 0x00008E30
		public string ogrn
		{
			[CompilerGenerated]
			get
			{
				return this.<ogrn>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ogrn>k__BackingField = value;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x0000AC44 File Offset: 0x00008E44
		// (set) Token: 0x060003F6 RID: 1014 RVA: 0x0000AC58 File Offset: 0x00008E58
		public string ur_address
		{
			[CompilerGenerated]
			get
			{
				return this.<ur_address>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ur_address>k__BackingField = value;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x0000AC6C File Offset: 0x00008E6C
		// (set) Token: 0x060003F8 RID: 1016 RVA: 0x0000AC80 File Offset: 0x00008E80
		public string site
		{
			[CompilerGenerated]
			get
			{
				return this.<site>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<site>k__BackingField = value;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x0000AC94 File Offset: 0x00008E94
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x0000ACA8 File Offset: 0x00008EA8
		public string email
		{
			[CompilerGenerated]
			get
			{
				return this.<email>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<email>k__BackingField = value;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x0000ACBC File Offset: 0x00008EBC
		// (set) Token: 0x060003FC RID: 1020 RVA: 0x0000ACD0 File Offset: 0x00008ED0
		public byte[] logo
		{
			[CompilerGenerated]
			get
			{
				return this.<logo>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<logo>k__BackingField = value;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x0000ACE4 File Offset: 0x00008EE4
		// (set) Token: 0x060003FE RID: 1022 RVA: 0x0000ACF8 File Offset: 0x00008EF8
		public string banks
		{
			[CompilerGenerated]
			get
			{
				return this.<banks>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<banks>k__BackingField = value;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x0000AD0C File Offset: 0x00008F0C
		// (set) Token: 0x06000400 RID: 1024 RVA: 0x0000AD20 File Offset: 0x00008F20
		public bool is_default
		{
			[CompilerGenerated]
			get
			{
				return this.<is_default>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<is_default>k__BackingField = value;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x0000AD34 File Offset: 0x00008F34
		// (set) Token: 0x06000402 RID: 1026 RVA: 0x0000AD48 File Offset: 0x00008F48
		public bool status
		{
			[CompilerGenerated]
			get
			{
				return this.<status>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<status>k__BackingField = value;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x0000AD5C File Offset: 0x00008F5C
		// (set) Token: 0x06000404 RID: 1028 RVA: 0x0000AD70 File Offset: 0x00008F70
		public int? director
		{
			[CompilerGenerated]
			get
			{
				return this.<director>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<director>k__BackingField = value;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x0000AD84 File Offset: 0x00008F84
		// (set) Token: 0x06000406 RID: 1030 RVA: 0x0000AD98 File Offset: 0x00008F98
		public int? accountant
		{
			[CompilerGenerated]
			get
			{
				return this.<accountant>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<accountant>k__BackingField = value;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x0000ADAC File Offset: 0x00008FAC
		// (set) Token: 0x06000408 RID: 1032 RVA: 0x0000ADC0 File Offset: 0x00008FC0
		public string description
		{
			[CompilerGenerated]
			get
			{
				return this.<description>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<description>k__BackingField = value;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x0000ADD4 File Offset: 0x00008FD4
		// (set) Token: 0x0600040A RID: 1034 RVA: 0x0000ADE8 File Offset: 0x00008FE8
		public int tax_form
		{
			[CompilerGenerated]
			get
			{
				return this.<tax_form>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<tax_form>k__BackingField = value;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x0000ADFC File Offset: 0x00008FFC
		// (set) Token: 0x0600040C RID: 1036 RVA: 0x0000AE10 File Offset: 0x00009010
		public virtual ICollection<banks> banks1
		{
			[CompilerGenerated]
			get
			{
				return this.<banks1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<banks1>k__BackingField = value;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x0000AE24 File Offset: 0x00009024
		// (set) Token: 0x0600040E RID: 1038 RVA: 0x0000AE38 File Offset: 0x00009038
		public virtual ICollection<cash_orders> cash_orders
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

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x0600040F RID: 1039 RVA: 0x0000AE4C File Offset: 0x0000904C
		// (set) Token: 0x06000410 RID: 1040 RVA: 0x0000AE60 File Offset: 0x00009060
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

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x0000AE74 File Offset: 0x00009074
		// (set) Token: 0x06000412 RID: 1042 RVA: 0x0000AE88 File Offset: 0x00009088
		public virtual users users1
		{
			[CompilerGenerated]
			get
			{
				return this.<users1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<users1>k__BackingField = value;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x0000AE9C File Offset: 0x0000909C
		// (set) Token: 0x06000414 RID: 1044 RVA: 0x0000AEB0 File Offset: 0x000090B0
		public virtual ICollection<docs> docs
		{
			[CompilerGenerated]
			get
			{
				return this.<docs>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<docs>k__BackingField = value;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x0000AEC4 File Offset: 0x000090C4
		// (set) Token: 0x06000416 RID: 1046 RVA: 0x0000AED8 File Offset: 0x000090D8
		public virtual ICollection<offices> offices
		{
			[CompilerGenerated]
			get
			{
				return this.<offices>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<offices>k__BackingField = value;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x0000AEEC File Offset: 0x000090EC
		// (set) Token: 0x06000418 RID: 1048 RVA: 0x0000AF00 File Offset: 0x00009100
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

		// Token: 0x040001DB RID: 475
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x040001DC RID: 476
		[CompilerGenerated]
		private int? <type>k__BackingField;

		// Token: 0x040001DD RID: 477
		[CompilerGenerated]
		private string <name>k__BackingField;

		// Token: 0x040001DE RID: 478
		[CompilerGenerated]
		private string <inn>k__BackingField;

		// Token: 0x040001DF RID: 479
		[CompilerGenerated]
		private string <kpp>k__BackingField;

		// Token: 0x040001E0 RID: 480
		[CompilerGenerated]
		private string <ogrn>k__BackingField;

		// Token: 0x040001E1 RID: 481
		[CompilerGenerated]
		private string <ur_address>k__BackingField;

		// Token: 0x040001E2 RID: 482
		[CompilerGenerated]
		private string <site>k__BackingField;

		// Token: 0x040001E3 RID: 483
		[CompilerGenerated]
		private string <email>k__BackingField;

		// Token: 0x040001E4 RID: 484
		[CompilerGenerated]
		private byte[] <logo>k__BackingField;

		// Token: 0x040001E5 RID: 485
		[CompilerGenerated]
		private string <banks>k__BackingField;

		// Token: 0x040001E6 RID: 486
		[CompilerGenerated]
		private bool <is_default>k__BackingField;

		// Token: 0x040001E7 RID: 487
		[CompilerGenerated]
		private bool <status>k__BackingField;

		// Token: 0x040001E8 RID: 488
		[CompilerGenerated]
		private int? <director>k__BackingField;

		// Token: 0x040001E9 RID: 489
		[CompilerGenerated]
		private int? <accountant>k__BackingField;

		// Token: 0x040001EA RID: 490
		[CompilerGenerated]
		private string <description>k__BackingField;

		// Token: 0x040001EB RID: 491
		[CompilerGenerated]
		private int <tax_form>k__BackingField;

		// Token: 0x040001EC RID: 492
		[CompilerGenerated]
		private ICollection<banks> <banks1>k__BackingField;

		// Token: 0x040001ED RID: 493
		[CompilerGenerated]
		private ICollection<cash_orders> <cash_orders>k__BackingField;

		// Token: 0x040001EE RID: 494
		[CompilerGenerated]
		private users <users>k__BackingField;

		// Token: 0x040001EF RID: 495
		[CompilerGenerated]
		private users <users1>k__BackingField;

		// Token: 0x040001F0 RID: 496
		[CompilerGenerated]
		private ICollection<docs> <docs>k__BackingField;

		// Token: 0x040001F1 RID: 497
		[CompilerGenerated]
		private ICollection<offices> <offices>k__BackingField;

		// Token: 0x040001F2 RID: 498
		[CompilerGenerated]
		private ICollection<workshop> <workshop>k__BackingField;
	}
}
