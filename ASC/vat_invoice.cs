using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x02000084 RID: 132
	public class vat_invoice
	{
		// Token: 0x06001024 RID: 4132 RVA: 0x0001DA34 File Offset: 0x0001BC34
		public vat_invoice()
		{
			this.invoice_items = new HashSet<invoice_items>();
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x06001025 RID: 4133 RVA: 0x0001DA54 File Offset: 0x0001BC54
		// (set) Token: 0x06001026 RID: 4134 RVA: 0x0001DA68 File Offset: 0x0001BC68
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

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x06001027 RID: 4135 RVA: 0x0001DA7C File Offset: 0x0001BC7C
		// (set) Token: 0x06001028 RID: 4136 RVA: 0x0001DA90 File Offset: 0x0001BC90
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

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06001029 RID: 4137 RVA: 0x0001DAA4 File Offset: 0x0001BCA4
		// (set) Token: 0x0600102A RID: 4138 RVA: 0x0001DAB8 File Offset: 0x0001BCB8
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

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x0600102B RID: 4139 RVA: 0x0001DACC File Offset: 0x0001BCCC
		// (set) Token: 0x0600102C RID: 4140 RVA: 0x0001DAE0 File Offset: 0x0001BCE0
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

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x0600102D RID: 4141 RVA: 0x0001DAF4 File Offset: 0x0001BCF4
		// (set) Token: 0x0600102E RID: 4142 RVA: 0x0001DB08 File Offset: 0x0001BD08
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

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x0600102F RID: 4143 RVA: 0x0001DB1C File Offset: 0x0001BD1C
		// (set) Token: 0x06001030 RID: 4144 RVA: 0x0001DB30 File Offset: 0x0001BD30
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

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06001031 RID: 4145 RVA: 0x0001DB44 File Offset: 0x0001BD44
		// (set) Token: 0x06001032 RID: 4146 RVA: 0x0001DB58 File Offset: 0x0001BD58
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

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06001033 RID: 4147 RVA: 0x0001DB6C File Offset: 0x0001BD6C
		// (set) Token: 0x06001034 RID: 4148 RVA: 0x0001DB80 File Offset: 0x0001BD80
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

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06001035 RID: 4149 RVA: 0x0001DB94 File Offset: 0x0001BD94
		// (set) Token: 0x06001036 RID: 4150 RVA: 0x0001DBA8 File Offset: 0x0001BDA8
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

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06001037 RID: 4151 RVA: 0x0001DBBC File Offset: 0x0001BDBC
		// (set) Token: 0x06001038 RID: 4152 RVA: 0x0001DBD0 File Offset: 0x0001BDD0
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

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x06001039 RID: 4153 RVA: 0x0001DBE4 File Offset: 0x0001BDE4
		// (set) Token: 0x0600103A RID: 4154 RVA: 0x0001DBF8 File Offset: 0x0001BDF8
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

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x0600103B RID: 4155 RVA: 0x0001DC0C File Offset: 0x0001BE0C
		// (set) Token: 0x0600103C RID: 4156 RVA: 0x0001DC20 File Offset: 0x0001BE20
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

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x0600103D RID: 4157 RVA: 0x0001DC34 File Offset: 0x0001BE34
		// (set) Token: 0x0600103E RID: 4158 RVA: 0x0001DC48 File Offset: 0x0001BE48
		public string currency
		{
			[CompilerGenerated]
			get
			{
				return this.<currency>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<currency>k__BackingField = value;
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x0600103F RID: 4159 RVA: 0x0001DC5C File Offset: 0x0001BE5C
		// (set) Token: 0x06001040 RID: 4160 RVA: 0x0001DC70 File Offset: 0x0001BE70
		public string currency_code
		{
			[CompilerGenerated]
			get
			{
				return this.<currency_code>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<currency_code>k__BackingField = value;
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06001041 RID: 4161 RVA: 0x0001DC84 File Offset: 0x0001BE84
		// (set) Token: 0x06001042 RID: 4162 RVA: 0x0001DC98 File Offset: 0x0001BE98
		public string state_contract
		{
			[CompilerGenerated]
			get
			{
				return this.<state_contract>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<state_contract>k__BackingField = value;
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x06001043 RID: 4163 RVA: 0x0001DCAC File Offset: 0x0001BEAC
		// (set) Token: 0x06001044 RID: 4164 RVA: 0x0001DCC0 File Offset: 0x0001BEC0
		public string payment_order
		{
			[CompilerGenerated]
			get
			{
				return this.<payment_order>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<payment_order>k__BackingField = value;
			}
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x06001045 RID: 4165 RVA: 0x0001DCD4 File Offset: 0x0001BED4
		// (set) Token: 0x06001046 RID: 4166 RVA: 0x0001DCE8 File Offset: 0x0001BEE8
		public DateTime? payment_order_date
		{
			[CompilerGenerated]
			get
			{
				return this.<payment_order_date>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<payment_order_date>k__BackingField = value;
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06001047 RID: 4167 RVA: 0x0001DCFC File Offset: 0x0001BEFC
		// (set) Token: 0x06001048 RID: 4168 RVA: 0x0001DD10 File Offset: 0x0001BF10
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

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06001049 RID: 4169 RVA: 0x0001DD24 File Offset: 0x0001BF24
		// (set) Token: 0x0600104A RID: 4170 RVA: 0x0001DD38 File Offset: 0x0001BF38
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

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x0600104B RID: 4171 RVA: 0x0001DD4C File Offset: 0x0001BF4C
		// (set) Token: 0x0600104C RID: 4172 RVA: 0x0001DD60 File Offset: 0x0001BF60
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

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x0600104D RID: 4173 RVA: 0x0001DD74 File Offset: 0x0001BF74
		// (set) Token: 0x0600104E RID: 4174 RVA: 0x0001DD88 File Offset: 0x0001BF88
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

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x0600104F RID: 4175 RVA: 0x0001DD9C File Offset: 0x0001BF9C
		// (set) Token: 0x06001050 RID: 4176 RVA: 0x0001DDB0 File Offset: 0x0001BFB0
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

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x06001051 RID: 4177 RVA: 0x0001DDC4 File Offset: 0x0001BFC4
		// (set) Token: 0x06001052 RID: 4178 RVA: 0x0001DDD8 File Offset: 0x0001BFD8
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

		// Token: 0x0400079C RID: 1948
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x0400079D RID: 1949
		[CompilerGenerated]
		private string <num>k__BackingField;

		// Token: 0x0400079E RID: 1950
		[CompilerGenerated]
		private DateTime <created>k__BackingField;

		// Token: 0x0400079F RID: 1951
		[CompilerGenerated]
		private int? <invoice>k__BackingField;

		// Token: 0x040007A0 RID: 1952
		[CompilerGenerated]
		private int <user>k__BackingField;

		// Token: 0x040007A1 RID: 1953
		[CompilerGenerated]
		private int <seller>k__BackingField;

		// Token: 0x040007A2 RID: 1954
		[CompilerGenerated]
		private int <customer>k__BackingField;

		// Token: 0x040007A3 RID: 1955
		[CompilerGenerated]
		private int <office>k__BackingField;

		// Token: 0x040007A4 RID: 1956
		[CompilerGenerated]
		private decimal <tax>k__BackingField;

		// Token: 0x040007A5 RID: 1957
		[CompilerGenerated]
		private decimal <summ>k__BackingField;

		// Token: 0x040007A6 RID: 1958
		[CompilerGenerated]
		private decimal <total>k__BackingField;

		// Token: 0x040007A7 RID: 1959
		[CompilerGenerated]
		private string <notes>k__BackingField;

		// Token: 0x040007A8 RID: 1960
		[CompilerGenerated]
		private string <currency>k__BackingField;

		// Token: 0x040007A9 RID: 1961
		[CompilerGenerated]
		private string <currency_code>k__BackingField;

		// Token: 0x040007AA RID: 1962
		[CompilerGenerated]
		private string <state_contract>k__BackingField;

		// Token: 0x040007AB RID: 1963
		[CompilerGenerated]
		private string <payment_order>k__BackingField;

		// Token: 0x040007AC RID: 1964
		[CompilerGenerated]
		private DateTime? <payment_order_date>k__BackingField;

		// Token: 0x040007AD RID: 1965
		[CompilerGenerated]
		private banks <banks>k__BackingField;

		// Token: 0x040007AE RID: 1966
		[CompilerGenerated]
		private banks <banks1>k__BackingField;

		// Token: 0x040007AF RID: 1967
		[CompilerGenerated]
		private invoice <invoice1>k__BackingField;

		// Token: 0x040007B0 RID: 1968
		[CompilerGenerated]
		private offices <offices>k__BackingField;

		// Token: 0x040007B1 RID: 1969
		[CompilerGenerated]
		private users <users>k__BackingField;

		// Token: 0x040007B2 RID: 1970
		[CompilerGenerated]
		private ICollection<invoice_items> <invoice_items>k__BackingField;
	}
}
