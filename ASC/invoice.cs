using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x02000045 RID: 69
	public class invoice
	{
		// Token: 0x06000671 RID: 1649 RVA: 0x0000EB64 File Offset: 0x0000CD64
		public invoice()
		{
			this.cash_orders = new HashSet<cash_orders>();
			this.vat_invoice = new HashSet<vat_invoice>();
			this.invoice_items = new HashSet<invoice_items>();
			this.p_lists = new HashSet<p_lists>();
			this.w_lists = new HashSet<w_lists>();
			this.workshop = new HashSet<workshop>();
			this.docs = new HashSet<docs>();
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x0000EBC4 File Offset: 0x0000CDC4
		// (set) Token: 0x06000673 RID: 1651 RVA: 0x0000EBD8 File Offset: 0x0000CDD8
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

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x0000EBEC File Offset: 0x0000CDEC
		// (set) Token: 0x06000675 RID: 1653 RVA: 0x0000EC00 File Offset: 0x0000CE00
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

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000676 RID: 1654 RVA: 0x0000EC14 File Offset: 0x0000CE14
		// (set) Token: 0x06000677 RID: 1655 RVA: 0x0000EC28 File Offset: 0x0000CE28
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

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000678 RID: 1656 RVA: 0x0000EC3C File Offset: 0x0000CE3C
		// (set) Token: 0x06000679 RID: 1657 RVA: 0x0000EC50 File Offset: 0x0000CE50
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

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x0000EC64 File Offset: 0x0000CE64
		// (set) Token: 0x0600067B RID: 1659 RVA: 0x0000EC78 File Offset: 0x0000CE78
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

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x0000EC8C File Offset: 0x0000CE8C
		// (set) Token: 0x0600067D RID: 1661 RVA: 0x0000ECA0 File Offset: 0x0000CEA0
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

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x0000ECB4 File Offset: 0x0000CEB4
		// (set) Token: 0x0600067F RID: 1663 RVA: 0x0000ECC8 File Offset: 0x0000CEC8
		public DateTime? paid
		{
			[CompilerGenerated]
			get
			{
				return this.<paid>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<paid>k__BackingField = value;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x0000ECDC File Offset: 0x0000CEDC
		// (set) Token: 0x06000681 RID: 1665 RVA: 0x0000ECF0 File Offset: 0x0000CEF0
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

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000682 RID: 1666 RVA: 0x0000ED04 File Offset: 0x0000CF04
		// (set) Token: 0x06000683 RID: 1667 RVA: 0x0000ED18 File Offset: 0x0000CF18
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

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000684 RID: 1668 RVA: 0x0000ED2C File Offset: 0x0000CF2C
		// (set) Token: 0x06000685 RID: 1669 RVA: 0x0000ED40 File Offset: 0x0000CF40
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

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x0000ED54 File Offset: 0x0000CF54
		// (set) Token: 0x06000687 RID: 1671 RVA: 0x0000ED68 File Offset: 0x0000CF68
		public int state
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

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x0000ED7C File Offset: 0x0000CF7C
		// (set) Token: 0x06000689 RID: 1673 RVA: 0x0000ED90 File Offset: 0x0000CF90
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

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x0000EDA4 File Offset: 0x0000CFA4
		// (set) Token: 0x0600068B RID: 1675 RVA: 0x0000EDB8 File Offset: 0x0000CFB8
		public int type
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

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x0000EDCC File Offset: 0x0000CFCC
		// (set) Token: 0x0600068D RID: 1677 RVA: 0x0000EDE0 File Offset: 0x0000CFE0
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

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x0000EDF4 File Offset: 0x0000CFF4
		// (set) Token: 0x0600068F RID: 1679 RVA: 0x0000EE08 File Offset: 0x0000D008
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

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000690 RID: 1680 RVA: 0x0000EE1C File Offset: 0x0000D01C
		// (set) Token: 0x06000691 RID: 1681 RVA: 0x0000EE30 File Offset: 0x0000D030
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

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x0000EE44 File Offset: 0x0000D044
		// (set) Token: 0x06000693 RID: 1683 RVA: 0x0000EE58 File Offset: 0x0000D058
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

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x0000EE6C File Offset: 0x0000D06C
		// (set) Token: 0x06000695 RID: 1685 RVA: 0x0000EE80 File Offset: 0x0000D080
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

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x0000EE94 File Offset: 0x0000D094
		// (set) Token: 0x06000697 RID: 1687 RVA: 0x0000EEA8 File Offset: 0x0000D0A8
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

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000698 RID: 1688 RVA: 0x0000EEBC File Offset: 0x0000D0BC
		// (set) Token: 0x06000699 RID: 1689 RVA: 0x0000EED0 File Offset: 0x0000D0D0
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

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x0600069A RID: 1690 RVA: 0x0000EEE4 File Offset: 0x0000D0E4
		// (set) Token: 0x0600069B RID: 1691 RVA: 0x0000EEF8 File Offset: 0x0000D0F8
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

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x0000EF0C File Offset: 0x0000D10C
		// (set) Token: 0x0600069D RID: 1693 RVA: 0x0000EF20 File Offset: 0x0000D120
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

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x0000EF34 File Offset: 0x0000D134
		// (set) Token: 0x0600069F RID: 1695 RVA: 0x0000EF48 File Offset: 0x0000D148
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

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x060006A0 RID: 1696 RVA: 0x0000EF5C File Offset: 0x0000D15C
		// (set) Token: 0x060006A1 RID: 1697 RVA: 0x0000EF70 File Offset: 0x0000D170
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

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x0000EF84 File Offset: 0x0000D184
		// (set) Token: 0x060006A3 RID: 1699 RVA: 0x0000EF98 File Offset: 0x0000D198
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

		// Token: 0x04000313 RID: 787
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x04000314 RID: 788
		[CompilerGenerated]
		private string <num>k__BackingField;

		// Token: 0x04000315 RID: 789
		[CompilerGenerated]
		private DateTime <created>k__BackingField;

		// Token: 0x04000316 RID: 790
		[CompilerGenerated]
		private int <user>k__BackingField;

		// Token: 0x04000317 RID: 791
		[CompilerGenerated]
		private int <seller>k__BackingField;

		// Token: 0x04000318 RID: 792
		[CompilerGenerated]
		private int <customer>k__BackingField;

		// Token: 0x04000319 RID: 793
		[CompilerGenerated]
		private DateTime? <paid>k__BackingField;

		// Token: 0x0400031A RID: 794
		[CompilerGenerated]
		private decimal <tax>k__BackingField;

		// Token: 0x0400031B RID: 795
		[CompilerGenerated]
		private decimal <summ>k__BackingField;

		// Token: 0x0400031C RID: 796
		[CompilerGenerated]
		private decimal <total>k__BackingField;

		// Token: 0x0400031D RID: 797
		[CompilerGenerated]
		private int <state>k__BackingField;

		// Token: 0x0400031E RID: 798
		[CompilerGenerated]
		private int <office>k__BackingField;

		// Token: 0x0400031F RID: 799
		[CompilerGenerated]
		private int <type>k__BackingField;

		// Token: 0x04000320 RID: 800
		[CompilerGenerated]
		private string <notes>k__BackingField;

		// Token: 0x04000321 RID: 801
		[CompilerGenerated]
		private banks <banks>k__BackingField;

		// Token: 0x04000322 RID: 802
		[CompilerGenerated]
		private banks <banks1>k__BackingField;

		// Token: 0x04000323 RID: 803
		[CompilerGenerated]
		private ICollection<cash_orders> <cash_orders>k__BackingField;

		// Token: 0x04000324 RID: 804
		[CompilerGenerated]
		private offices <offices>k__BackingField;

		// Token: 0x04000325 RID: 805
		[CompilerGenerated]
		private users <users>k__BackingField;

		// Token: 0x04000326 RID: 806
		[CompilerGenerated]
		private ICollection<vat_invoice> <vat_invoice>k__BackingField;

		// Token: 0x04000327 RID: 807
		[CompilerGenerated]
		private ICollection<invoice_items> <invoice_items>k__BackingField;

		// Token: 0x04000328 RID: 808
		[CompilerGenerated]
		private ICollection<p_lists> <p_lists>k__BackingField;

		// Token: 0x04000329 RID: 809
		[CompilerGenerated]
		private ICollection<w_lists> <w_lists>k__BackingField;

		// Token: 0x0400032A RID: 810
		[CompilerGenerated]
		private ICollection<workshop> <workshop>k__BackingField;

		// Token: 0x0400032B RID: 811
		[CompilerGenerated]
		private ICollection<docs> <docs>k__BackingField;
	}
}
