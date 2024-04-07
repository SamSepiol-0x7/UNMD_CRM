using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x02000067 RID: 103
	public class p_lists
	{
		// Token: 0x06000AAD RID: 2733 RVA: 0x00014828 File Offset: 0x00012A28
		public p_lists()
		{
			this.invoice_items = new HashSet<invoice_items>();
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06000AAE RID: 2734 RVA: 0x00014848 File Offset: 0x00012A48
		// (set) Token: 0x06000AAF RID: 2735 RVA: 0x0001485C File Offset: 0x00012A5C
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

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x00014870 File Offset: 0x00012A70
		// (set) Token: 0x06000AB1 RID: 2737 RVA: 0x00014884 File Offset: 0x00012A84
		public string num
		{
			[CompilerGenerated]
			get
			{
				return this.<num>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<num>k__BackingField = value;
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06000AB2 RID: 2738 RVA: 0x00014898 File Offset: 0x00012A98
		// (set) Token: 0x06000AB3 RID: 2739 RVA: 0x000148AC File Offset: 0x00012AAC
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

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x000148C0 File Offset: 0x00012AC0
		// (set) Token: 0x06000AB5 RID: 2741 RVA: 0x000148D4 File Offset: 0x00012AD4
		public int? invoice
		{
			[CompilerGenerated]
			get
			{
				return this.<invoice>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<invoice>k__BackingField = value;
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x000148E8 File Offset: 0x00012AE8
		// (set) Token: 0x06000AB7 RID: 2743 RVA: 0x000148FC File Offset: 0x00012AFC
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

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06000AB8 RID: 2744 RVA: 0x00014910 File Offset: 0x00012B10
		// (set) Token: 0x06000AB9 RID: 2745 RVA: 0x00014924 File Offset: 0x00012B24
		public int seller
		{
			[CompilerGenerated]
			get
			{
				return this.<seller>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<seller>k__BackingField = value;
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06000ABA RID: 2746 RVA: 0x00014938 File Offset: 0x00012B38
		// (set) Token: 0x06000ABB RID: 2747 RVA: 0x0001494C File Offset: 0x00012B4C
		public int customer
		{
			[CompilerGenerated]
			get
			{
				return this.<customer>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<customer>k__BackingField = value;
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x00014960 File Offset: 0x00012B60
		// (set) Token: 0x06000ABD RID: 2749 RVA: 0x00014974 File Offset: 0x00012B74
		public int office
		{
			[CompilerGenerated]
			get
			{
				return this.<office>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<office>k__BackingField = value;
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x00014988 File Offset: 0x00012B88
		// (set) Token: 0x06000ABF RID: 2751 RVA: 0x0001499C File Offset: 0x00012B9C
		public decimal tax
		{
			[CompilerGenerated]
			get
			{
				return this.<tax>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<tax>k__BackingField = value;
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x000149B0 File Offset: 0x00012BB0
		// (set) Token: 0x06000AC1 RID: 2753 RVA: 0x000149C4 File Offset: 0x00012BC4
		public decimal summ
		{
			[CompilerGenerated]
			get
			{
				return this.<summ>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<summ>k__BackingField = value;
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x000149D8 File Offset: 0x00012BD8
		// (set) Token: 0x06000AC3 RID: 2755 RVA: 0x000149EC File Offset: 0x00012BEC
		public decimal total
		{
			[CompilerGenerated]
			get
			{
				return this.<total>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<total>k__BackingField = value;
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x00014A00 File Offset: 0x00012C00
		// (set) Token: 0x06000AC5 RID: 2757 RVA: 0x00014A14 File Offset: 0x00012C14
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

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x00014A28 File Offset: 0x00012C28
		// (set) Token: 0x06000AC7 RID: 2759 RVA: 0x00014A3C File Offset: 0x00012C3C
		public string reason
		{
			[CompilerGenerated]
			get
			{
				return this.<reason>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<reason>k__BackingField = value;
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x00014A50 File Offset: 0x00012C50
		// (set) Token: 0x06000AC9 RID: 2761 RVA: 0x00014A64 File Offset: 0x00012C64
		public virtual banks banks
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

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06000ACA RID: 2762 RVA: 0x00014A78 File Offset: 0x00012C78
		// (set) Token: 0x06000ACB RID: 2763 RVA: 0x00014A8C File Offset: 0x00012C8C
		public virtual banks banks1
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

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06000ACC RID: 2764 RVA: 0x00014AA0 File Offset: 0x00012CA0
		// (set) Token: 0x06000ACD RID: 2765 RVA: 0x00014AB4 File Offset: 0x00012CB4
		public virtual invoice invoice1
		{
			[CompilerGenerated]
			get
			{
				return this.<invoice1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<invoice1>k__BackingField = value;
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06000ACE RID: 2766 RVA: 0x00014AC8 File Offset: 0x00012CC8
		// (set) Token: 0x06000ACF RID: 2767 RVA: 0x00014ADC File Offset: 0x00012CDC
		public virtual ICollection<invoice_items> invoice_items
		{
			[CompilerGenerated]
			get
			{
				return this.<invoice_items>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<invoice_items>k__BackingField = value;
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x00014AF0 File Offset: 0x00012CF0
		// (set) Token: 0x06000AD1 RID: 2769 RVA: 0x00014B04 File Offset: 0x00012D04
		public virtual offices offices
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

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x00014B18 File Offset: 0x00012D18
		// (set) Token: 0x06000AD3 RID: 2771 RVA: 0x00014B2C File Offset: 0x00012D2C
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

		// Token: 0x04000513 RID: 1299
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x04000514 RID: 1300
		[CompilerGenerated]
		private string <num>k__BackingField;

		// Token: 0x04000515 RID: 1301
		[CompilerGenerated]
		private DateTime <created>k__BackingField;

		// Token: 0x04000516 RID: 1302
		[CompilerGenerated]
		private int? <invoice>k__BackingField;

		// Token: 0x04000517 RID: 1303
		[CompilerGenerated]
		private int <user>k__BackingField;

		// Token: 0x04000518 RID: 1304
		[CompilerGenerated]
		private int <seller>k__BackingField;

		// Token: 0x04000519 RID: 1305
		[CompilerGenerated]
		private int <customer>k__BackingField;

		// Token: 0x0400051A RID: 1306
		[CompilerGenerated]
		private int <office>k__BackingField;

		// Token: 0x0400051B RID: 1307
		[CompilerGenerated]
		private decimal <tax>k__BackingField;

		// Token: 0x0400051C RID: 1308
		[CompilerGenerated]
		private decimal <summ>k__BackingField;

		// Token: 0x0400051D RID: 1309
		[CompilerGenerated]
		private decimal <total>k__BackingField;

		// Token: 0x0400051E RID: 1310
		[CompilerGenerated]
		private string <notes>k__BackingField;

		// Token: 0x0400051F RID: 1311
		[CompilerGenerated]
		private string <reason>k__BackingField;

		// Token: 0x04000520 RID: 1312
		[CompilerGenerated]
		private banks <banks>k__BackingField;

		// Token: 0x04000521 RID: 1313
		[CompilerGenerated]
		private banks <banks1>k__BackingField;

		// Token: 0x04000522 RID: 1314
		[CompilerGenerated]
		private invoice <invoice1>k__BackingField;

		// Token: 0x04000523 RID: 1315
		[CompilerGenerated]
		private ICollection<invoice_items> <invoice_items>k__BackingField;

		// Token: 0x04000524 RID: 1316
		[CompilerGenerated]
		private offices <offices>k__BackingField;

		// Token: 0x04000525 RID: 1317
		[CompilerGenerated]
		private users <users>k__BackingField;
	}
}
