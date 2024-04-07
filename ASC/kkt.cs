using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x02000049 RID: 73
	public class kkt
	{
		// Token: 0x060006E3 RID: 1763 RVA: 0x0000F49C File Offset: 0x0000D69C
		public kkt()
		{
			this.users = new HashSet<users>();
			this.kkt_employee = new HashSet<kkt_employee>();
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x0000F4C8 File Offset: 0x0000D6C8
		// (set) Token: 0x060006E5 RID: 1765 RVA: 0x0000F4DC File Offset: 0x0000D6DC
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

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x0000F4F0 File Offset: 0x0000D6F0
		// (set) Token: 0x060006E7 RID: 1767 RVA: 0x0000F504 File Offset: 0x0000D704
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

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x0000F518 File Offset: 0x0000D718
		// (set) Token: 0x060006E9 RID: 1769 RVA: 0x0000F52C File Offset: 0x0000D72C
		public int protocol
		{
			[CompilerGenerated]
			get
			{
				return this.<protocol>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<protocol>k__BackingField = value;
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x0000F540 File Offset: 0x0000D740
		// (set) Token: 0x060006EB RID: 1771 RVA: 0x0000F554 File Offset: 0x0000D754
		public string ip
		{
			[CompilerGenerated]
			get
			{
				return this.<ip>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ip>k__BackingField = value;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x0000F568 File Offset: 0x0000D768
		// (set) Token: 0x060006ED RID: 1773 RVA: 0x0000F57C File Offset: 0x0000D77C
		public int? port
		{
			[CompilerGenerated]
			get
			{
				return this.<port>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<port>k__BackingField = value;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x0000F590 File Offset: 0x0000D790
		// (set) Token: 0x060006EF RID: 1775 RVA: 0x0000F5A4 File Offset: 0x0000D7A4
		public int tax
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

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x0000F5B8 File Offset: 0x0000D7B8
		// (set) Token: 0x060006F1 RID: 1777 RVA: 0x0000F5CC File Offset: 0x0000D7CC
		public bool r_simple
		{
			[CompilerGenerated]
			get
			{
				return this.<r_simple>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<r_simple>k__BackingField = value;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x0000F5E0 File Offset: 0x0000D7E0
		// (set) Token: 0x060006F3 RID: 1779 RVA: 0x0000F5F4 File Offset: 0x0000D7F4
		public bool s_simple
		{
			[CompilerGenerated]
			get
			{
				return this.<s_simple>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<s_simple>k__BackingField = value;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x0000F608 File Offset: 0x0000D808
		// (set) Token: 0x060006F5 RID: 1781 RVA: 0x0000F61C File Offset: 0x0000D81C
		public string r_tpl
		{
			[CompilerGenerated]
			get
			{
				return this.<r_tpl>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<r_tpl>k__BackingField = value;
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x060006F6 RID: 1782 RVA: 0x0000F630 File Offset: 0x0000D830
		// (set) Token: 0x060006F7 RID: 1783 RVA: 0x0000F644 File Offset: 0x0000D844
		public string s_tpl
		{
			[CompilerGenerated]
			get
			{
				return this.<s_tpl>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<s_tpl>k__BackingField = value;
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x060006F8 RID: 1784 RVA: 0x0000F658 File Offset: 0x0000D858
		// (set) Token: 0x060006F9 RID: 1785 RVA: 0x0000F66C File Offset: 0x0000D86C
		public string footer
		{
			[CompilerGenerated]
			get
			{
				return this.<footer>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<footer>k__BackingField = value;
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x060006FA RID: 1786 RVA: 0x0000F680 File Offset: 0x0000D880
		// (set) Token: 0x060006FB RID: 1787 RVA: 0x0000F694 File Offset: 0x0000D894
		public int? office
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

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x0000F6A8 File Offset: 0x0000D8A8
		// (set) Token: 0x060006FD RID: 1789 RVA: 0x0000F6BC File Offset: 0x0000D8BC
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

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x060006FE RID: 1790 RVA: 0x0000F6D0 File Offset: 0x0000D8D0
		// (set) Token: 0x060006FF RID: 1791 RVA: 0x0000F6E4 File Offset: 0x0000D8E4
		public int order_payment_item_sign
		{
			[CompilerGenerated]
			get
			{
				return this.<order_payment_item_sign>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<order_payment_item_sign>k__BackingField = value;
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x0000F6F8 File Offset: 0x0000D8F8
		// (set) Token: 0x06000701 RID: 1793 RVA: 0x0000F70C File Offset: 0x0000D90C
		public int product_payment_item_sign
		{
			[CompilerGenerated]
			get
			{
				return this.<product_payment_item_sign>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<product_payment_item_sign>k__BackingField = value;
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x0000F720 File Offset: 0x0000D920
		// (set) Token: 0x06000703 RID: 1795 RVA: 0x0000F734 File Offset: 0x0000D934
		public int tax_type
		{
			[CompilerGenerated]
			get
			{
				return this.<tax_type>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<tax_type>k__BackingField = value;
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x0000F748 File Offset: 0x0000D948
		// (set) Token: 0x06000705 RID: 1797 RVA: 0x0000F75C File Offset: 0x0000D95C
		public string @operator
		{
			[CompilerGenerated]
			get
			{
				return this.<operator>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<operator>k__BackingField = value;
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x0000F770 File Offset: 0x0000D970
		// (set) Token: 0x06000707 RID: 1799 RVA: 0x0000F784 File Offset: 0x0000D984
		public string operator_inn
		{
			[CompilerGenerated]
			get
			{
				return this.<operator_inn>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<operator_inn>k__BackingField = value;
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x0000F798 File Offset: 0x0000D998
		// (set) Token: 0x06000709 RID: 1801 RVA: 0x0000F7AC File Offset: 0x0000D9AC
		public virtual ICollection<users> users
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

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x0600070A RID: 1802 RVA: 0x0000F7C0 File Offset: 0x0000D9C0
		// (set) Token: 0x0600070B RID: 1803 RVA: 0x0000F7D4 File Offset: 0x0000D9D4
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

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x0600070C RID: 1804 RVA: 0x0000F7E8 File Offset: 0x0000D9E8
		// (set) Token: 0x0600070D RID: 1805 RVA: 0x0000F7FC File Offset: 0x0000D9FC
		public virtual ICollection<kkt_employee> kkt_employee
		{
			[CompilerGenerated]
			get
			{
				return this.<kkt_employee>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<kkt_employee>k__BackingField = value;
			}
		}

		// Token: 0x0400034A RID: 842
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x0400034B RID: 843
		[CompilerGenerated]
		private string <name>k__BackingField;

		// Token: 0x0400034C RID: 844
		[CompilerGenerated]
		private int <protocol>k__BackingField;

		// Token: 0x0400034D RID: 845
		[CompilerGenerated]
		private string <ip>k__BackingField;

		// Token: 0x0400034E RID: 846
		[CompilerGenerated]
		private int? <port>k__BackingField;

		// Token: 0x0400034F RID: 847
		[CompilerGenerated]
		private int <tax>k__BackingField;

		// Token: 0x04000350 RID: 848
		[CompilerGenerated]
		private bool <r_simple>k__BackingField;

		// Token: 0x04000351 RID: 849
		[CompilerGenerated]
		private bool <s_simple>k__BackingField;

		// Token: 0x04000352 RID: 850
		[CompilerGenerated]
		private string <r_tpl>k__BackingField;

		// Token: 0x04000353 RID: 851
		[CompilerGenerated]
		private string <s_tpl>k__BackingField;

		// Token: 0x04000354 RID: 852
		[CompilerGenerated]
		private string <footer>k__BackingField;

		// Token: 0x04000355 RID: 853
		[CompilerGenerated]
		private int? <office>k__BackingField;

		// Token: 0x04000356 RID: 854
		[CompilerGenerated]
		private bool <archive>k__BackingField;

		// Token: 0x04000357 RID: 855
		[CompilerGenerated]
		private int <order_payment_item_sign>k__BackingField;

		// Token: 0x04000358 RID: 856
		[CompilerGenerated]
		private int <product_payment_item_sign>k__BackingField;

		// Token: 0x04000359 RID: 857
		[CompilerGenerated]
		private int <tax_type>k__BackingField;

		// Token: 0x0400035A RID: 858
		[CompilerGenerated]
		private string <operator>k__BackingField;

		// Token: 0x0400035B RID: 859
		[CompilerGenerated]
		private string <operator_inn>k__BackingField;

		// Token: 0x0400035C RID: 860
		[CompilerGenerated]
		private ICollection<users> <users>k__BackingField;

		// Token: 0x0400035D RID: 861
		[CompilerGenerated]
		private offices <offices>k__BackingField;

		// Token: 0x0400035E RID: 862
		[CompilerGenerated]
		private ICollection<kkt_employee> <kkt_employee>k__BackingField;
	}
}
