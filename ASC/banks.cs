using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x0200002D RID: 45
	public class banks
	{
		// Token: 0x06000288 RID: 648 RVA: 0x000082BC File Offset: 0x000064BC
		public banks()
		{
			this.invoice = new HashSet<invoice>();
			this.invoice1 = new HashSet<invoice>();
			this.vat_invoice = new HashSet<vat_invoice>();
			this.vat_invoice1 = new HashSet<vat_invoice>();
			this.p_lists = new HashSet<p_lists>();
			this.p_lists1 = new HashSet<p_lists>();
			this.w_lists = new HashSet<w_lists>();
			this.w_lists1 = new HashSet<w_lists>();
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000289 RID: 649 RVA: 0x00008328 File Offset: 0x00006528
		// (set) Token: 0x0600028A RID: 650 RVA: 0x0000833C File Offset: 0x0000653C
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

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600028B RID: 651 RVA: 0x00008350 File Offset: 0x00006550
		// (set) Token: 0x0600028C RID: 652 RVA: 0x00008364 File Offset: 0x00006564
		public string ur_name
		{
			[CompilerGenerated]
			get
			{
				return this.<ur_name>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ur_name>k__BackingField = value;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600028D RID: 653 RVA: 0x00008378 File Offset: 0x00006578
		// (set) Token: 0x0600028E RID: 654 RVA: 0x0000838C File Offset: 0x0000658C
		public string bank
		{
			[CompilerGenerated]
			get
			{
				return this.<bank>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<bank>k__BackingField = value;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600028F RID: 655 RVA: 0x000083A0 File Offset: 0x000065A0
		// (set) Token: 0x06000290 RID: 656 RVA: 0x000083B4 File Offset: 0x000065B4
		public string correspondent_account
		{
			[CompilerGenerated]
			get
			{
				return this.<correspondent_account>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<correspondent_account>k__BackingField = value;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000291 RID: 657 RVA: 0x000083C8 File Offset: 0x000065C8
		// (set) Token: 0x06000292 RID: 658 RVA: 0x000083DC File Offset: 0x000065DC
		public string checking_account
		{
			[CompilerGenerated]
			get
			{
				return this.<checking_account>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<checking_account>k__BackingField = value;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000293 RID: 659 RVA: 0x000083F0 File Offset: 0x000065F0
		// (set) Token: 0x06000294 RID: 660 RVA: 0x00008404 File Offset: 0x00006604
		public string BIC
		{
			[CompilerGenerated]
			get
			{
				return this.<BIC>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<BIC>k__BackingField = value;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000295 RID: 661 RVA: 0x00008418 File Offset: 0x00006618
		// (set) Token: 0x06000296 RID: 662 RVA: 0x0000842C File Offset: 0x0000662C
		public string SWIFT
		{
			[CompilerGenerated]
			get
			{
				return this.<SWIFT>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<SWIFT>k__BackingField = value;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000297 RID: 663 RVA: 0x00008440 File Offset: 0x00006640
		// (set) Token: 0x06000298 RID: 664 RVA: 0x00008454 File Offset: 0x00006654
		public string IBAN
		{
			[CompilerGenerated]
			get
			{
				return this.<IBAN>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<IBAN>k__BackingField = value;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000299 RID: 665 RVA: 0x00008468 File Offset: 0x00006668
		// (set) Token: 0x0600029A RID: 666 RVA: 0x0000847C File Offset: 0x0000667C
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

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600029B RID: 667 RVA: 0x00008490 File Offset: 0x00006690
		// (set) Token: 0x0600029C RID: 668 RVA: 0x000084A4 File Offset: 0x000066A4
		public int? client
		{
			[CompilerGenerated]
			get
			{
				return this.<client>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<client>k__BackingField = value;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600029D RID: 669 RVA: 0x000084B8 File Offset: 0x000066B8
		// (set) Token: 0x0600029E RID: 670 RVA: 0x000084CC File Offset: 0x000066CC
		public int? company
		{
			[CompilerGenerated]
			get
			{
				return this.<company>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<company>k__BackingField = value;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600029F RID: 671 RVA: 0x000084E0 File Offset: 0x000066E0
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x000084F4 File Offset: 0x000066F4
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

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x00008508 File Offset: 0x00006708
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x0000851C File Offset: 0x0000671C
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

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x00008530 File Offset: 0x00006730
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x00008544 File Offset: 0x00006744
		public string address
		{
			[CompilerGenerated]
			get
			{
				return this.<address>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<address>k__BackingField = value;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x00008558 File Offset: 0x00006758
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x0000856C File Offset: 0x0000676C
		public string chief
		{
			[CompilerGenerated]
			get
			{
				return this.<chief>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<chief>k__BackingField = value;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x00008580 File Offset: 0x00006780
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x00008594 File Offset: 0x00006794
		public string accountant
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

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x000085A8 File Offset: 0x000067A8
		// (set) Token: 0x060002AA RID: 682 RVA: 0x000085BC File Offset: 0x000067BC
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

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060002AB RID: 683 RVA: 0x000085D0 File Offset: 0x000067D0
		// (set) Token: 0x060002AC RID: 684 RVA: 0x000085E4 File Offset: 0x000067E4
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

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060002AD RID: 685 RVA: 0x000085F8 File Offset: 0x000067F8
		// (set) Token: 0x060002AE RID: 686 RVA: 0x0000860C File Offset: 0x0000680C
		public int? seal
		{
			[CompilerGenerated]
			get
			{
				return this.<seal>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<seal>k__BackingField = value;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060002AF RID: 687 RVA: 0x00008620 File Offset: 0x00006820
		// (set) Token: 0x060002B0 RID: 688 RVA: 0x00008634 File Offset: 0x00006834
		public int? chief_signature
		{
			[CompilerGenerated]
			get
			{
				return this.<chief_signature>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<chief_signature>k__BackingField = value;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x00008648 File Offset: 0x00006848
		// (set) Token: 0x060002B2 RID: 690 RVA: 0x0000865C File Offset: 0x0000685C
		public int? accountant_signature
		{
			[CompilerGenerated]
			get
			{
				return this.<accountant_signature>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<accountant_signature>k__BackingField = value;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x00008670 File Offset: 0x00006870
		// (set) Token: 0x060002B4 RID: 692 RVA: 0x00008684 File Offset: 0x00006884
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

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x00008698 File Offset: 0x00006898
		// (set) Token: 0x060002B6 RID: 694 RVA: 0x000086AC File Offset: 0x000068AC
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

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x000086C0 File Offset: 0x000068C0
		// (set) Token: 0x060002B8 RID: 696 RVA: 0x000086D4 File Offset: 0x000068D4
		public virtual companies companies
		{
			[CompilerGenerated]
			get
			{
				return this.<companies>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<companies>k__BackingField = value;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x000086E8 File Offset: 0x000068E8
		// (set) Token: 0x060002BA RID: 698 RVA: 0x000086FC File Offset: 0x000068FC
		public virtual ICollection<invoice> invoice
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

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060002BB RID: 699 RVA: 0x00008710 File Offset: 0x00006910
		// (set) Token: 0x060002BC RID: 700 RVA: 0x00008724 File Offset: 0x00006924
		public virtual ICollection<invoice> invoice1
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

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060002BD RID: 701 RVA: 0x00008738 File Offset: 0x00006938
		// (set) Token: 0x060002BE RID: 702 RVA: 0x0000874C File Offset: 0x0000694C
		public virtual ICollection<vat_invoice> vat_invoice
		{
			[CompilerGenerated]
			get
			{
				return this.<vat_invoice>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<vat_invoice>k__BackingField = value;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060002BF RID: 703 RVA: 0x00008760 File Offset: 0x00006960
		// (set) Token: 0x060002C0 RID: 704 RVA: 0x00008774 File Offset: 0x00006974
		public virtual ICollection<vat_invoice> vat_invoice1
		{
			[CompilerGenerated]
			get
			{
				return this.<vat_invoice1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<vat_invoice1>k__BackingField = value;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x00008788 File Offset: 0x00006988
		// (set) Token: 0x060002C2 RID: 706 RVA: 0x0000879C File Offset: 0x0000699C
		public virtual ICollection<p_lists> p_lists
		{
			[CompilerGenerated]
			get
			{
				return this.<p_lists>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<p_lists>k__BackingField = value;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x000087B0 File Offset: 0x000069B0
		// (set) Token: 0x060002C4 RID: 708 RVA: 0x000087C4 File Offset: 0x000069C4
		public virtual ICollection<p_lists> p_lists1
		{
			[CompilerGenerated]
			get
			{
				return this.<p_lists1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<p_lists1>k__BackingField = value;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x000087D8 File Offset: 0x000069D8
		// (set) Token: 0x060002C6 RID: 710 RVA: 0x000087EC File Offset: 0x000069EC
		public virtual ICollection<w_lists> w_lists
		{
			[CompilerGenerated]
			get
			{
				return this.<w_lists>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<w_lists>k__BackingField = value;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x00008800 File Offset: 0x00006A00
		// (set) Token: 0x060002C8 RID: 712 RVA: 0x00008814 File Offset: 0x00006A14
		public virtual ICollection<w_lists> w_lists1
		{
			[CompilerGenerated]
			get
			{
				return this.<w_lists1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<w_lists1>k__BackingField = value;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x00008828 File Offset: 0x00006A28
		// (set) Token: 0x060002CA RID: 714 RVA: 0x0000883C File Offset: 0x00006A3C
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

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060002CB RID: 715 RVA: 0x00008850 File Offset: 0x00006A50
		// (set) Token: 0x060002CC RID: 716 RVA: 0x00008864 File Offset: 0x00006A64
		public virtual images images1
		{
			[CompilerGenerated]
			get
			{
				return this.<images1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<images1>k__BackingField = value;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060002CD RID: 717 RVA: 0x00008878 File Offset: 0x00006A78
		// (set) Token: 0x060002CE RID: 718 RVA: 0x0000888C File Offset: 0x00006A8C
		public virtual images images2
		{
			[CompilerGenerated]
			get
			{
				return this.<images2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<images2>k__BackingField = value;
			}
		}

		// Token: 0x0400012F RID: 303
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x04000130 RID: 304
		[CompilerGenerated]
		private string <ur_name>k__BackingField;

		// Token: 0x04000131 RID: 305
		[CompilerGenerated]
		private string <bank>k__BackingField;

		// Token: 0x04000132 RID: 306
		[CompilerGenerated]
		private string <correspondent_account>k__BackingField;

		// Token: 0x04000133 RID: 307
		[CompilerGenerated]
		private string <checking_account>k__BackingField;

		// Token: 0x04000134 RID: 308
		[CompilerGenerated]
		private string <BIC>k__BackingField;

		// Token: 0x04000135 RID: 309
		[CompilerGenerated]
		private string <SWIFT>k__BackingField;

		// Token: 0x04000136 RID: 310
		[CompilerGenerated]
		private string <IBAN>k__BackingField;

		// Token: 0x04000137 RID: 311
		[CompilerGenerated]
		private int? <type>k__BackingField;

		// Token: 0x04000138 RID: 312
		[CompilerGenerated]
		private int? <client>k__BackingField;

		// Token: 0x04000139 RID: 313
		[CompilerGenerated]
		private int? <company>k__BackingField;

		// Token: 0x0400013A RID: 314
		[CompilerGenerated]
		private string <inn>k__BackingField;

		// Token: 0x0400013B RID: 315
		[CompilerGenerated]
		private string <kpp>k__BackingField;

		// Token: 0x0400013C RID: 316
		[CompilerGenerated]
		private string <address>k__BackingField;

		// Token: 0x0400013D RID: 317
		[CompilerGenerated]
		private string <chief>k__BackingField;

		// Token: 0x0400013E RID: 318
		[CompilerGenerated]
		private string <accountant>k__BackingField;

		// Token: 0x0400013F RID: 319
		[CompilerGenerated]
		private string <email>k__BackingField;

		// Token: 0x04000140 RID: 320
		[CompilerGenerated]
		private string <ogrn>k__BackingField;

		// Token: 0x04000141 RID: 321
		[CompilerGenerated]
		private int? <seal>k__BackingField;

		// Token: 0x04000142 RID: 322
		[CompilerGenerated]
		private int? <chief_signature>k__BackingField;

		// Token: 0x04000143 RID: 323
		[CompilerGenerated]
		private int? <accountant_signature>k__BackingField;

		// Token: 0x04000144 RID: 324
		[CompilerGenerated]
		private bool <archive>k__BackingField;

		// Token: 0x04000145 RID: 325
		[CompilerGenerated]
		private clients <clients>k__BackingField;

		// Token: 0x04000146 RID: 326
		[CompilerGenerated]
		private companies <companies>k__BackingField;

		// Token: 0x04000147 RID: 327
		[CompilerGenerated]
		private ICollection<invoice> <invoice>k__BackingField;

		// Token: 0x04000148 RID: 328
		[CompilerGenerated]
		private ICollection<invoice> <invoice1>k__BackingField;

		// Token: 0x04000149 RID: 329
		[CompilerGenerated]
		private ICollection<vat_invoice> <vat_invoice>k__BackingField;

		// Token: 0x0400014A RID: 330
		[CompilerGenerated]
		private ICollection<vat_invoice> <vat_invoice1>k__BackingField;

		// Token: 0x0400014B RID: 331
		[CompilerGenerated]
		private ICollection<p_lists> <p_lists>k__BackingField;

		// Token: 0x0400014C RID: 332
		[CompilerGenerated]
		private ICollection<p_lists> <p_lists1>k__BackingField;

		// Token: 0x0400014D RID: 333
		[CompilerGenerated]
		private ICollection<w_lists> <w_lists>k__BackingField;

		// Token: 0x0400014E RID: 334
		[CompilerGenerated]
		private ICollection<w_lists> <w_lists1>k__BackingField;

		// Token: 0x0400014F RID: 335
		[CompilerGenerated]
		private images <images>k__BackingField;

		// Token: 0x04000150 RID: 336
		[CompilerGenerated]
		private images <images1>k__BackingField;

		// Token: 0x04000151 RID: 337
		[CompilerGenerated]
		private images <images2>k__BackingField;
	}
}
