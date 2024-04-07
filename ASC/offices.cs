using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Media;

namespace ASC
{
	// Token: 0x02000051 RID: 81
	public class offices
	{
		// Token: 0x060007CF RID: 1999 RVA: 0x00010698 File Offset: 0x0000E898
		public offices()
		{
			this.docs = new HashSet<docs>();
			this.stores = new HashSet<stores>();
			this.workshop = new HashSet<workshop>();
			this.workshop1 = new HashSet<workshop>();
			this.balance = new HashSet<balance>();
			this.logs = new HashSet<logs>();
			this.cash_orders = new HashSet<cash_orders>();
			this.users1 = new HashSet<users>();
			this.invoice = new HashSet<invoice>();
			this.vat_invoice = new HashSet<vat_invoice>();
			this.p_lists = new HashSet<p_lists>();
			this.w_lists = new HashSet<w_lists>();
			this.pinpad = new HashSet<pinpad>();
			this.kkt = new HashSet<kkt>();
			this.kkt_employee = new HashSet<kkt_employee>();
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x060007D0 RID: 2000 RVA: 0x00010750 File Offset: 0x0000E950
		// (set) Token: 0x060007D1 RID: 2001 RVA: 0x00010764 File Offset: 0x0000E964
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

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x060007D2 RID: 2002 RVA: 0x00010778 File Offset: 0x0000E978
		// (set) Token: 0x060007D3 RID: 2003 RVA: 0x0001078C File Offset: 0x0000E98C
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

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x060007D4 RID: 2004 RVA: 0x000107A0 File Offset: 0x0000E9A0
		// (set) Token: 0x060007D5 RID: 2005 RVA: 0x000107B4 File Offset: 0x0000E9B4
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

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x000107C8 File Offset: 0x0000E9C8
		// (set) Token: 0x060007D7 RID: 2007 RVA: 0x000107DC File Offset: 0x0000E9DC
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

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x060007D8 RID: 2008 RVA: 0x000107F0 File Offset: 0x0000E9F0
		// (set) Token: 0x060007D9 RID: 2009 RVA: 0x00010804 File Offset: 0x0000EA04
		public string phone
		{
			[CompilerGenerated]
			get
			{
				return this.<phone>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<phone>k__BackingField = value;
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x060007DA RID: 2010 RVA: 0x00010818 File Offset: 0x0000EA18
		// (set) Token: 0x060007DB RID: 2011 RVA: 0x0001082C File Offset: 0x0000EA2C
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

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x060007DC RID: 2012 RVA: 0x00010840 File Offset: 0x0000EA40
		// (set) Token: 0x060007DD RID: 2013 RVA: 0x00010854 File Offset: 0x0000EA54
		public int administrator
		{
			[CompilerGenerated]
			get
			{
				return this.<administrator>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<administrator>k__BackingField = value;
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x060007DE RID: 2014 RVA: 0x00010868 File Offset: 0x0000EA68
		// (set) Token: 0x060007DF RID: 2015 RVA: 0x0001087C File Offset: 0x0000EA7C
		public DateTime? created
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

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x060007E0 RID: 2016 RVA: 0x00010890 File Offset: 0x0000EA90
		// (set) Token: 0x060007E1 RID: 2017 RVA: 0x000108A4 File Offset: 0x0000EAA4
		public string phone2
		{
			[CompilerGenerated]
			get
			{
				return this.<phone2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<phone2>k__BackingField = value;
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x000108B8 File Offset: 0x0000EAB8
		// (set) Token: 0x060007E3 RID: 2019 RVA: 0x000108CC File Offset: 0x0000EACC
		public int default_company
		{
			[CompilerGenerated]
			get
			{
				return this.<default_company>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<default_company>k__BackingField = value;
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x060007E4 RID: 2020 RVA: 0x000108E0 File Offset: 0x0000EAE0
		// (set) Token: 0x060007E5 RID: 2021 RVA: 0x000108F4 File Offset: 0x0000EAF4
		public bool card_payment
		{
			[CompilerGenerated]
			get
			{
				return this.<card_payment>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<card_payment>k__BackingField = value;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x00010908 File Offset: 0x0000EB08
		// (set) Token: 0x060007E7 RID: 2023 RVA: 0x0001091C File Offset: 0x0000EB1C
		public bool use_boxes
		{
			[CompilerGenerated]
			get
			{
				return this.<use_boxes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<use_boxes>k__BackingField = value;
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x00010930 File Offset: 0x0000EB30
		// (set) Token: 0x060007E9 RID: 2025 RVA: 0x00010944 File Offset: 0x0000EB44
		public bool paint_repairs
		{
			[CompilerGenerated]
			get
			{
				return this.<paint_repairs>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<paint_repairs>k__BackingField = value;
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x00010958 File Offset: 0x0000EB58
		// (set) Token: 0x060007EB RID: 2027 RVA: 0x0001096C File Offset: 0x0000EB6C
		public bool warranty_sn
		{
			[CompilerGenerated]
			get
			{
				return this.<warranty_sn>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<warranty_sn>k__BackingField = value;
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x060007EC RID: 2028 RVA: 0x00010980 File Offset: 0x0000EB80
		// (set) Token: 0x060007ED RID: 2029 RVA: 0x00010994 File Offset: 0x0000EB94
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

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x000109A8 File Offset: 0x0000EBA8
		// (set) Token: 0x060007EF RID: 2031 RVA: 0x000109BC File Offset: 0x0000EBBC
		public virtual ICollection<stores> stores
		{
			[CompilerGenerated]
			get
			{
				return this.<stores>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<stores>k__BackingField = value;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x000109D0 File Offset: 0x0000EBD0
		// (set) Token: 0x060007F1 RID: 2033 RVA: 0x000109E4 File Offset: 0x0000EBE4
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

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x000109F8 File Offset: 0x0000EBF8
		// (set) Token: 0x060007F3 RID: 2035 RVA: 0x00010A0C File Offset: 0x0000EC0C
		public virtual ICollection<workshop> workshop1
		{
			[CompilerGenerated]
			get
			{
				return this.<workshop1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<workshop1>k__BackingField = value;
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x060007F4 RID: 2036 RVA: 0x00010A20 File Offset: 0x0000EC20
		// (set) Token: 0x060007F5 RID: 2037 RVA: 0x00010A34 File Offset: 0x0000EC34
		public virtual ICollection<balance> balance
		{
			[CompilerGenerated]
			get
			{
				return this.<balance>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<balance>k__BackingField = value;
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x00010A48 File Offset: 0x0000EC48
		// (set) Token: 0x060007F7 RID: 2039 RVA: 0x00010A5C File Offset: 0x0000EC5C
		public virtual ICollection<logs> logs
		{
			[CompilerGenerated]
			get
			{
				return this.<logs>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<logs>k__BackingField = value;
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x00010A70 File Offset: 0x0000EC70
		// (set) Token: 0x060007F9 RID: 2041 RVA: 0x00010A84 File Offset: 0x0000EC84
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

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x00010A98 File Offset: 0x0000EC98
		// (set) Token: 0x060007FB RID: 2043 RVA: 0x00010AAC File Offset: 0x0000ECAC
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

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x00010AC0 File Offset: 0x0000ECC0
		// (set) Token: 0x060007FD RID: 2045 RVA: 0x00010AD4 File Offset: 0x0000ECD4
		public virtual ICollection<users> users1
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

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x00010AE8 File Offset: 0x0000ECE8
		// (set) Token: 0x060007FF RID: 2047 RVA: 0x00010AFC File Offset: 0x0000ECFC
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

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x00010B10 File Offset: 0x0000ED10
		// (set) Token: 0x06000801 RID: 2049 RVA: 0x00010B24 File Offset: 0x0000ED24
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

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x00010B38 File Offset: 0x0000ED38
		// (set) Token: 0x06000803 RID: 2051 RVA: 0x00010B4C File Offset: 0x0000ED4C
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

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x00010B60 File Offset: 0x0000ED60
		// (set) Token: 0x06000805 RID: 2053 RVA: 0x00010B74 File Offset: 0x0000ED74
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

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x00010B88 File Offset: 0x0000ED88
		// (set) Token: 0x06000807 RID: 2055 RVA: 0x00010B9C File Offset: 0x0000ED9C
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

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000808 RID: 2056 RVA: 0x00010BB0 File Offset: 0x0000EDB0
		// (set) Token: 0x06000809 RID: 2057 RVA: 0x00010BC4 File Offset: 0x0000EDC4
		public virtual ICollection<pinpad> pinpad
		{
			[CompilerGenerated]
			get
			{
				return this.<pinpad>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<pinpad>k__BackingField = value;
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x0600080A RID: 2058 RVA: 0x00010BD8 File Offset: 0x0000EDD8
		// (set) Token: 0x0600080B RID: 2059 RVA: 0x00010BEC File Offset: 0x0000EDEC
		public virtual ICollection<kkt> kkt
		{
			[CompilerGenerated]
			get
			{
				return this.<kkt>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<kkt>k__BackingField = value;
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x0600080C RID: 2060 RVA: 0x00010C00 File Offset: 0x0000EE00
		// (set) Token: 0x0600080D RID: 2061 RVA: 0x00010C14 File Offset: 0x0000EE14
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

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x0600080E RID: 2062 RVA: 0x00010C28 File Offset: 0x0000EE28
		public virtual Bitmap LogoBitmap
		{
			get
			{
				if (this.logo == null)
				{
					return null;
				}
				return new Bitmap(new MemoryStream(this.logo));
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x00010C50 File Offset: 0x0000EE50
		public virtual ImageSource ImageSource
		{
			get
			{
				if (this.logo != null)
				{
					return ConvertersStack.ByteArrayToImage(this.logo);
				}
				return null;
			}
		}

		// Token: 0x040003BC RID: 956
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x040003BD RID: 957
		[CompilerGenerated]
		private int <state>k__BackingField;

		// Token: 0x040003BE RID: 958
		[CompilerGenerated]
		private string <name>k__BackingField;

		// Token: 0x040003BF RID: 959
		[CompilerGenerated]
		private string <address>k__BackingField;

		// Token: 0x040003C0 RID: 960
		[CompilerGenerated]
		private string <phone>k__BackingField;

		// Token: 0x040003C1 RID: 961
		[CompilerGenerated]
		private byte[] <logo>k__BackingField;

		// Token: 0x040003C2 RID: 962
		[CompilerGenerated]
		private int <administrator>k__BackingField;

		// Token: 0x040003C3 RID: 963
		[CompilerGenerated]
		private DateTime? <created>k__BackingField;

		// Token: 0x040003C4 RID: 964
		[CompilerGenerated]
		private string <phone2>k__BackingField;

		// Token: 0x040003C5 RID: 965
		[CompilerGenerated]
		private int <default_company>k__BackingField;

		// Token: 0x040003C6 RID: 966
		[CompilerGenerated]
		private bool <card_payment>k__BackingField;

		// Token: 0x040003C7 RID: 967
		[CompilerGenerated]
		private bool <use_boxes>k__BackingField;

		// Token: 0x040003C8 RID: 968
		[CompilerGenerated]
		private bool <paint_repairs>k__BackingField;

		// Token: 0x040003C9 RID: 969
		[CompilerGenerated]
		private bool <warranty_sn>k__BackingField;

		// Token: 0x040003CA RID: 970
		[CompilerGenerated]
		private ICollection<docs> <docs>k__BackingField;

		// Token: 0x040003CB RID: 971
		[CompilerGenerated]
		private ICollection<stores> <stores>k__BackingField;

		// Token: 0x040003CC RID: 972
		[CompilerGenerated]
		private ICollection<workshop> <workshop>k__BackingField;

		// Token: 0x040003CD RID: 973
		[CompilerGenerated]
		private ICollection<workshop> <workshop1>k__BackingField;

		// Token: 0x040003CE RID: 974
		[CompilerGenerated]
		private ICollection<balance> <balance>k__BackingField;

		// Token: 0x040003CF RID: 975
		[CompilerGenerated]
		private ICollection<logs> <logs>k__BackingField;

		// Token: 0x040003D0 RID: 976
		[CompilerGenerated]
		private ICollection<cash_orders> <cash_orders>k__BackingField;

		// Token: 0x040003D1 RID: 977
		[CompilerGenerated]
		private users <users>k__BackingField;

		// Token: 0x040003D2 RID: 978
		[CompilerGenerated]
		private ICollection<users> <users1>k__BackingField;

		// Token: 0x040003D3 RID: 979
		[CompilerGenerated]
		private companies <companies>k__BackingField;

		// Token: 0x040003D4 RID: 980
		[CompilerGenerated]
		private ICollection<invoice> <invoice>k__BackingField;

		// Token: 0x040003D5 RID: 981
		[CompilerGenerated]
		private ICollection<vat_invoice> <vat_invoice>k__BackingField;

		// Token: 0x040003D6 RID: 982
		[CompilerGenerated]
		private ICollection<p_lists> <p_lists>k__BackingField;

		// Token: 0x040003D7 RID: 983
		[CompilerGenerated]
		private ICollection<w_lists> <w_lists>k__BackingField;

		// Token: 0x040003D8 RID: 984
		[CompilerGenerated]
		private ICollection<pinpad> <pinpad>k__BackingField;

		// Token: 0x040003D9 RID: 985
		[CompilerGenerated]
		private ICollection<kkt> <kkt>k__BackingField;

		// Token: 0x040003DA RID: 986
		[CompilerGenerated]
		private ICollection<kkt_employee> <kkt_employee>k__BackingField;
	}
}
