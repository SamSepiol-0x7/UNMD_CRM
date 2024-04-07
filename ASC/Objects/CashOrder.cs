using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using ASC.Common.Interfaces;
using ASC.Models;
using DevExpress.Mvvm;

namespace ASC.Objects
{
	// Token: 0x02000898 RID: 2200
	public class CashOrder : BindableBase, ICheckFields, ICashOrder
	{
		// Token: 0x17001249 RID: 4681
		// (get) Token: 0x060042C9 RID: 17097 RVA: 0x00105938 File Offset: 0x00103B38
		// (set) Token: 0x060042CA RID: 17098 RVA: 0x0010594C File Offset: 0x00103B4C
		public int Id
		{
			[CompilerGenerated]
			get
			{
				return this.<Id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Id>k__BackingField == value)
				{
					return;
				}
				this.<Id>k__BackingField = value;
				this.RaisePropertyChanged("Id");
			}
		}

		// Token: 0x1700124A RID: 4682
		// (get) Token: 0x060042CB RID: 17099 RVA: 0x00105978 File Offset: 0x00103B78
		// (set) Token: 0x060042CC RID: 17100 RVA: 0x0010598C File Offset: 0x00103B8C
		public DateTime Date
		{
			[CompilerGenerated]
			get
			{
				return this.<Date>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (DateTime.Equals(this.<Date>k__BackingField, value))
				{
					return;
				}
				this.<Date>k__BackingField = value;
				this.RaisePropertyChanged("Date");
			}
		}

		// Token: 0x1700124B RID: 4683
		// (get) Token: 0x060042CD RID: 17101 RVA: 0x001059BC File Offset: 0x00103BBC
		// (set) Token: 0x060042CE RID: 17102 RVA: 0x001059D0 File Offset: 0x00103BD0
		public int CompanyId
		{
			[CompilerGenerated]
			get
			{
				return this.<CompanyId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CompanyId>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -660258923;
				IL_10:
				switch ((num ^ -965651849) % 4)
				{
				case 0:
					goto IL_0B;
				case 1:
					IL_2F:
					this.<CompanyId>k__BackingField = value;
					this.RaisePropertyChanged("CompanyId");
					num = -1517682244;
					goto IL_10;
				case 2:
					return;
				}
			}
		}

		// Token: 0x1700124C RID: 4684
		// (get) Token: 0x060042CF RID: 17103 RVA: 0x00105A28 File Offset: 0x00103C28
		// (set) Token: 0x060042D0 RID: 17104 RVA: 0x00105A3C File Offset: 0x00103C3C
		public int OfficeId
		{
			[CompilerGenerated]
			get
			{
				return this.<OfficeId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<OfficeId>k__BackingField == value)
				{
					return;
				}
				this.<OfficeId>k__BackingField = value;
				this.RaisePropertyChanged("OfficeId");
			}
		}

		// Token: 0x1700124D RID: 4685
		// (get) Token: 0x060042D1 RID: 17105 RVA: 0x00105A68 File Offset: 0x00103C68
		// (set) Token: 0x060042D2 RID: 17106 RVA: 0x00105A7C File Offset: 0x00103C7C
		public int Type
		{
			[CompilerGenerated]
			get
			{
				return this.<Type>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Type>k__BackingField == value)
				{
					return;
				}
				this.<Type>k__BackingField = value;
				this.RaisePropertyChanged("Type");
			}
		}

		// Token: 0x1700124E RID: 4686
		// (get) Token: 0x060042D3 RID: 17107 RVA: 0x00105AA8 File Offset: 0x00103CA8
		// (set) Token: 0x060042D4 RID: 17108 RVA: 0x00105ABC File Offset: 0x00103CBC
		public int EmployeeId
		{
			[CompilerGenerated]
			get
			{
				return this.<EmployeeId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<EmployeeId>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -42978705;
				IL_10:
				switch ((num ^ -795120158) % 4)
				{
				case 1:
					return;
				case 2:
					IL_2F:
					this.<EmployeeId>k__BackingField = value;
					this.RaisePropertyChanged("EmployeeId");
					num = -246034846;
					goto IL_10;
				case 3:
					goto IL_0B;
				}
			}
		}

		// Token: 0x1700124F RID: 4687
		// (get) Token: 0x060042D5 RID: 17109 RVA: 0x00105B14 File Offset: 0x00103D14
		// (set) Token: 0x060042D6 RID: 17110 RVA: 0x00105B28 File Offset: 0x00103D28
		public decimal Summ
		{
			[CompilerGenerated]
			get
			{
				return this.<Summ>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<Summ>k__BackingField, value))
				{
					return;
				}
				this.<Summ>k__BackingField = value;
				this.RaisePropertyChanged("Summ");
			}
		}

		// Token: 0x17001250 RID: 4688
		// (get) Token: 0x060042D7 RID: 17111 RVA: 0x00105B58 File Offset: 0x00103D58
		// (set) Token: 0x060042D8 RID: 17112 RVA: 0x00105B6C File Offset: 0x00103D6C
		public string SummStr
		{
			[CompilerGenerated]
			get
			{
				return this.<SummStr>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<SummStr>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<SummStr>k__BackingField = value;
				this.RaisePropertyChanged("SummStr");
			}
		}

		// Token: 0x17001251 RID: 4689
		// (get) Token: 0x060042D9 RID: 17113 RVA: 0x00105B9C File Offset: 0x00103D9C
		// (set) Token: 0x060042DA RID: 17114 RVA: 0x00105BB0 File Offset: 0x00103DB0
		public int? InvoiceId
		{
			[CompilerGenerated]
			get
			{
				return this.<InvoiceId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<InvoiceId>k__BackingField, value))
				{
					return;
				}
				this.<InvoiceId>k__BackingField = value;
				this.RaisePropertyChanged("InvoiceId");
			}
		}

		// Token: 0x17001252 RID: 4690
		// (get) Token: 0x060042DB RID: 17115 RVA: 0x00105BE0 File Offset: 0x00103DE0
		// (set) Token: 0x060042DC RID: 17116 RVA: 0x00105BF4 File Offset: 0x00103DF4
		public int? CustomerId
		{
			[CompilerGenerated]
			get
			{
				return this.<CustomerId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<CustomerId>k__BackingField, value))
				{
					return;
				}
				this.<CustomerId>k__BackingField = value;
				this.RaisePropertyChanged("CustomerId");
			}
		}

		// Token: 0x17001253 RID: 4691
		// (get) Token: 0x060042DD RID: 17117 RVA: 0x00105C24 File Offset: 0x00103E24
		// (set) Token: 0x060042DE RID: 17118 RVA: 0x00105C38 File Offset: 0x00103E38
		public string CustomerEmail
		{
			[CompilerGenerated]
			get
			{
				return this.<CustomerEmail>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<CustomerEmail>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<CustomerEmail>k__BackingField = value;
				this.RaisePropertyChanged("CustomerEmail");
			}
		}

		// Token: 0x17001254 RID: 4692
		// (get) Token: 0x060042DF RID: 17119 RVA: 0x00105C68 File Offset: 0x00103E68
		// (set) Token: 0x060042E0 RID: 17120 RVA: 0x00105C7C File Offset: 0x00103E7C
		public CustomerCard Customer
		{
			[CompilerGenerated]
			get
			{
				return this.<Customer>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Customer>k__BackingField, value))
				{
					return;
				}
				this.<Customer>k__BackingField = value;
				this.RaisePropertyChanged("Customer");
			}
		}

		// Token: 0x17001255 RID: 4693
		// (get) Token: 0x060042E1 RID: 17121 RVA: 0x00105CAC File Offset: 0x00103EAC
		// (set) Token: 0x060042E2 RID: 17122 RVA: 0x00105CC0 File Offset: 0x00103EC0
		public int? ToEmployeeId
		{
			[CompilerGenerated]
			get
			{
				return this.<ToEmployeeId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<ToEmployeeId>k__BackingField, value))
				{
					return;
				}
				this.<ToEmployeeId>k__BackingField = value;
				this.RaisePropertyChanged("ToEmployeeId");
			}
		}

		// Token: 0x17001256 RID: 4694
		// (get) Token: 0x060042E3 RID: 17123 RVA: 0x00105CF0 File Offset: 0x00103EF0
		// (set) Token: 0x060042E4 RID: 17124 RVA: 0x00105D04 File Offset: 0x00103F04
		public string Reason
		{
			[CompilerGenerated]
			get
			{
				return this.<Reason>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Reason>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Reason>k__BackingField = value;
				this.RaisePropertyChanged("Reason");
			}
		}

		// Token: 0x17001257 RID: 4695
		// (get) Token: 0x060042E5 RID: 17125 RVA: 0x00105D34 File Offset: 0x00103F34
		// (set) Token: 0x060042E6 RID: 17126 RVA: 0x00105D48 File Offset: 0x00103F48
		public int? RepairId
		{
			[CompilerGenerated]
			get
			{
				return this.<RepairId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<RepairId>k__BackingField, value))
				{
					return;
				}
				this.<RepairId>k__BackingField = value;
				this.RaisePropertyChanged("RepairId");
			}
		}

		// Token: 0x17001258 RID: 4696
		// (get) Token: 0x060042E7 RID: 17127 RVA: 0x00105D78 File Offset: 0x00103F78
		// (set) Token: 0x060042E8 RID: 17128 RVA: 0x00105D8C File Offset: 0x00103F8C
		public int? DocumentId
		{
			[CompilerGenerated]
			get
			{
				return this.<DocumentId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!Nullable.Equals<int>(this.<DocumentId>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1025756131;
				IL_13:
				switch ((num ^ -1425481750) % 4)
				{
				case 0:
					goto IL_0E;
				case 2:
					IL_32:
					this.<DocumentId>k__BackingField = value;
					this.RaisePropertyChanged("DocumentId");
					num = -550483493;
					goto IL_13;
				case 3:
					return;
				}
			}
		}

		// Token: 0x17001259 RID: 4697
		// (get) Token: 0x060042E9 RID: 17129 RVA: 0x00105DE8 File Offset: 0x00103FE8
		// (set) Token: 0x060042EA RID: 17130 RVA: 0x00105DFC File Offset: 0x00103FFC
		public int? PhotoId
		{
			[CompilerGenerated]
			get
			{
				return this.<PhotoId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!Nullable.Equals<int>(this.<PhotoId>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 455171878;
				IL_13:
				switch ((num ^ 1900899749) % 4)
				{
				case 0:
					IL_32:
					num = 1443052020;
					goto IL_13;
				case 2:
					goto IL_0E;
				case 3:
					return;
				}
				this.<PhotoId>k__BackingField = value;
				this.RaisePropertyChanged("PhotoId");
			}
		}

		// Token: 0x1700125A RID: 4698
		// (get) Token: 0x060042EB RID: 17131 RVA: 0x00105E58 File Offset: 0x00104058
		// (set) Token: 0x060042EC RID: 17132 RVA: 0x00105E6C File Offset: 0x0010406C
		public byte[] Photo
		{
			[CompilerGenerated]
			get
			{
				return this.<Photo>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Photo>k__BackingField, value))
				{
					return;
				}
				this.<Photo>k__BackingField = value;
				this.RaisePropertyChanged("Photo");
			}
		}

		// Token: 0x1700125B RID: 4699
		// (get) Token: 0x060042ED RID: 17133 RVA: 0x00105E9C File Offset: 0x0010409C
		// (set) Token: 0x060042EE RID: 17134 RVA: 0x00105EB0 File Offset: 0x001040B0
		public int PaymentSystem
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentSystem>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PaymentSystem>k__BackingField == value)
				{
					return;
				}
				this.<PaymentSystem>k__BackingField = value;
				this.RaisePropertyChanged("PaymentSystem");
			}
		}

		// Token: 0x1700125C RID: 4700
		// (get) Token: 0x060042EF RID: 17135 RVA: 0x00105EDC File Offset: 0x001040DC
		// (set) Token: 0x060042F0 RID: 17136 RVA: 0x00105EF0 File Offset: 0x001040F0
		public decimal CardFee
		{
			[CompilerGenerated]
			get
			{
				return this.<CardFee>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<CardFee>k__BackingField, value))
				{
					return;
				}
				this.<CardFee>k__BackingField = value;
				this.RaisePropertyChanged("HaveCardFee");
				this.RaisePropertyChanged("CardFee");
			}
		}

		// Token: 0x1700125D RID: 4701
		// (get) Token: 0x060042F1 RID: 17137 RVA: 0x00105F2C File Offset: 0x0010412C
		// (set) Token: 0x060042F2 RID: 17138 RVA: 0x00105F40 File Offset: 0x00104140
		public bool IsBackdate
		{
			[CompilerGenerated]
			get
			{
				return this.<IsBackdate>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IsBackdate>k__BackingField == value)
				{
					return;
				}
				this.<IsBackdate>k__BackingField = value;
				this.RaisePropertyChanged("IsBackdate");
			}
		}

		// Token: 0x1700125E RID: 4702
		// (get) Token: 0x060042F3 RID: 17139 RVA: 0x00105F6C File Offset: 0x0010416C
		public bool HaveCardFee
		{
			get
			{
				return this.CardFee > 0m;
			}
		}

		// Token: 0x1700125F RID: 4703
		// (get) Token: 0x060042F4 RID: 17140 RVA: 0x00105F8C File Offset: 0x0010418C
		// (set) Token: 0x060042F5 RID: 17141 RVA: 0x00105FA0 File Offset: 0x001041A0
		public int PinpadId
		{
			[CompilerGenerated]
			get
			{
				return this.<PinpadId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PinpadId>k__BackingField == value)
				{
					return;
				}
				this.<PinpadId>k__BackingField = value;
				this.RaisePropertyChanged("PinpadId");
			}
		}

		// Token: 0x17001260 RID: 4704
		// (get) Token: 0x060042F6 RID: 17142 RVA: 0x00105FCC File Offset: 0x001041CC
		// (set) Token: 0x060042F7 RID: 17143 RVA: 0x00105FE0 File Offset: 0x001041E0
		public decimal Amount
		{
			[CompilerGenerated]
			get
			{
				return this.<Amount>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<Amount>k__BackingField, value))
				{
					return;
				}
				this.<Amount>k__BackingField = value;
				this.RaisePropertyChanged("Amount");
			}
		}

		// Token: 0x17001261 RID: 4705
		// (get) Token: 0x060042F8 RID: 17144 RVA: 0x00106010 File Offset: 0x00104210
		// (set) Token: 0x060042F9 RID: 17145 RVA: 0x00106024 File Offset: 0x00104224
		public string TermNum
		{
			[CompilerGenerated]
			get
			{
				return this.<TermNum>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<TermNum>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<TermNum>k__BackingField = value;
				this.RaisePropertyChanged("TermNum");
			}
		}

		// Token: 0x17001262 RID: 4706
		// (get) Token: 0x060042FA RID: 17146 RVA: 0x00106054 File Offset: 0x00104254
		// (set) Token: 0x060042FB RID: 17147 RVA: 0x00106068 File Offset: 0x00104268
		public string ClientCard
		{
			[CompilerGenerated]
			get
			{
				return this.<ClientCard>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<ClientCard>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<ClientCard>k__BackingField = value;
				this.RaisePropertyChanged("ClientCard");
			}
		}

		// Token: 0x17001263 RID: 4707
		// (get) Token: 0x060042FC RID: 17148 RVA: 0x00106098 File Offset: 0x00104298
		// (set) Token: 0x060042FD RID: 17149 RVA: 0x001060AC File Offset: 0x001042AC
		public string ClientExpiryDate
		{
			[CompilerGenerated]
			get
			{
				return this.<ClientExpiryDate>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<ClientExpiryDate>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<ClientExpiryDate>k__BackingField = value;
				this.RaisePropertyChanged("ClientExpiryDate");
			}
		}

		// Token: 0x17001264 RID: 4708
		// (get) Token: 0x060042FE RID: 17150 RVA: 0x001060DC File Offset: 0x001042DC
		// (set) Token: 0x060042FF RID: 17151 RVA: 0x001060F0 File Offset: 0x001042F0
		public string AuthCode
		{
			[CompilerGenerated]
			get
			{
				return this.<AuthCode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<AuthCode>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<AuthCode>k__BackingField = value;
				this.RaisePropertyChanged("AuthCode");
			}
		}

		// Token: 0x17001265 RID: 4709
		// (get) Token: 0x06004300 RID: 17152 RVA: 0x00106120 File Offset: 0x00104320
		// (set) Token: 0x06004301 RID: 17153 RVA: 0x00106134 File Offset: 0x00104334
		public string CardName
		{
			[CompilerGenerated]
			get
			{
				return this.<CardName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<CardName>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<CardName>k__BackingField = value;
				this.RaisePropertyChanged("CardName");
			}
		}

		// Token: 0x17001266 RID: 4710
		// (get) Token: 0x06004302 RID: 17154 RVA: 0x00106164 File Offset: 0x00104364
		// (set) Token: 0x06004303 RID: 17155 RVA: 0x00106178 File Offset: 0x00104378
		public int? PaymentItemSign
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentItemSign>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!Nullable.Equals<int>(this.<PaymentItemSign>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 458376293;
				IL_13:
				switch ((num ^ 1626585311) % 4)
				{
				case 0:
					goto IL_0E;
				case 2:
					return;
				case 3:
					IL_32:
					this.<PaymentItemSign>k__BackingField = value;
					this.RaisePropertyChanged("PaymentItemSign");
					num = 157761106;
					goto IL_13;
				}
			}
		}

		// Token: 0x17001267 RID: 4711
		// (get) Token: 0x06004304 RID: 17156 RVA: 0x001061D4 File Offset: 0x001043D4
		// (set) Token: 0x06004305 RID: 17157 RVA: 0x001061E8 File Offset: 0x001043E8
		public long? FiscalDocumentNumber
		{
			[CompilerGenerated]
			get
			{
				return this.<FiscalDocumentNumber>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!Nullable.Equals<long>(this.<FiscalDocumentNumber>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1222438097;
				IL_13:
				switch ((num ^ -1604703098) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					return;
				case 2:
					IL_32:
					this.<FiscalDocumentNumber>k__BackingField = value;
					this.RaisePropertyChanged("HaveFiscalDocumentNumber");
					this.RaisePropertyChanged("FiscalDocumentNumber");
					num = -569399559;
					goto IL_13;
				}
			}
		}

		// Token: 0x17001268 RID: 4712
		// (get) Token: 0x06004306 RID: 17158 RVA: 0x0010624C File Offset: 0x0010444C
		public bool HaveFiscalDocumentNumber
		{
			get
			{
				long? fiscalDocumentNumber = this.FiscalDocumentNumber;
				return fiscalDocumentNumber.GetValueOrDefault() > 0L & fiscalDocumentNumber != null;
			}
		}

		// Token: 0x06004307 RID: 17159 RVA: 0x0010627C File Offset: 0x0010447C
		public CashOrder()
		{
			Localization localization = new Localization("UTC");
			this.Summ = 0m;
			this.Date = localization.Now;
			this.PaymentSystem = 0;
			this.IsBackdate = false;
		}

		// Token: 0x06004308 RID: 17160 RVA: 0x001062C0 File Offset: 0x001044C0
		public void SetOffice(int officeId)
		{
			this.OfficeId = officeId;
		}

		// Token: 0x06004309 RID: 17161 RVA: 0x001062D4 File Offset: 0x001044D4
		public void SetEmployee(int employeeId)
		{
			this.EmployeeId = employeeId;
		}

		// Token: 0x0600430A RID: 17162 RVA: 0x001062E8 File Offset: 0x001044E8
		public bool IsCashInOrder()
		{
			return this.Summ > 0m;
		}

		// Token: 0x0600430B RID: 17163 RVA: 0x00106308 File Offset: 0x00104508
		public bool IsCashOutOrder()
		{
			return this.Summ < 0m;
		}

		// Token: 0x0600430C RID: 17164 RVA: 0x0007E558 File Offset: 0x0007C758
		public virtual string CheckFields()
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600430D RID: 17165 RVA: 0x00106328 File Offset: 0x00104528
		public virtual void SetSumm(decimal summ)
		{
			this.Summ = summ;
			this.CalcFee();
			this.SetSummaString();
		}

		// Token: 0x0600430E RID: 17166 RVA: 0x00106348 File Offset: 0x00104548
		private void CalcFee()
		{
			if (OfflineData.Instance.Employee.Pinpad != null && this.PaymentSystem == -1 && OfflineData.Instance.Employee.Pinpad.Fee > 0.0)
			{
				decimal num = this.Summ / 100m * (decimal)OfflineData.Instance.Employee.Pinpad.Fee;
				this.Summ -= num;
				this.CardFee = num;
				this.Reason += string.Format(", банковский сбор в размере {0:N2}", num);
			}
		}

		// Token: 0x0600430F RID: 17167 RVA: 0x00106400 File Offset: 0x00104600
		public void SetSummaString()
		{
			this.SummStr = ConvertersStack.SummToString(this.Summ, Auth.Config.currency);
		}

		// Token: 0x06004310 RID: 17168 RVA: 0x00106428 File Offset: 0x00104628
		public void AutocompleteReason()
		{
			string shortName = Auth.CurrencyModel.SelectedCurrency.ShortName;
			for (;;)
			{
				IL_108:
				int type = this.Type;
				for (;;)
				{
					switch (type)
					{
					case 1:
						goto IL_112;
					case 2:
						goto IL_13A;
					case 3:
						goto IL_16D;
					case 4:
						goto IL_195;
					case 5:
						goto IL_1BD;
					case 6:
						goto IL_1E5;
					case 7:
					case 10:
					case 18:
						return;
					case 8:
						goto IL_20D;
					case 9:
						goto IL_240;
					case 11:
						goto IL_273;
					case 12:
						goto IL_29B;
					case 13:
						goto IL_2CE;
					case 14:
						goto IL_30B;
					case 15:
						goto IL_348;
					case 16:
						goto IL_385;
					case 17:
						goto IL_3B8;
					case 19:
						goto IL_3F5;
					default:
					{
						uint num;
						switch ((num = (num * 1627143900U ^ 4015560566U ^ 3973668763U)) % 30U)
						{
						case 0U:
							goto IL_240;
						case 1U:
							goto IL_29B;
						case 2U:
						case 25U:
							goto IL_108;
						case 3U:
							goto IL_20D;
						case 4U:
							return;
						case 5U:
							return;
						case 6U:
							return;
						case 7U:
							return;
						case 8U:
							goto IL_30B;
						case 9U:
							return;
						case 10U:
							goto IL_3B8;
						case 11U:
							goto IL_348;
						case 12U:
							continue;
						case 13U:
							return;
						case 14U:
							goto IL_3F5;
						case 15U:
							goto IL_2CE;
						case 16U:
							goto IL_195;
						case 17U:
							goto IL_16D;
						case 19U:
							return;
						case 20U:
							return;
						case 21U:
							goto IL_1E5;
						case 22U:
							return;
						case 23U:
							goto IL_1BD;
						case 24U:
							return;
						case 26U:
							goto IL_385;
						case 27U:
							goto IL_112;
						case 28U:
							goto IL_273;
						case 29U:
							goto IL_13A;
						}
						goto Block_1;
					}
					}
				}
			}
			Block_1:
			return;
			IL_112:
			this.Reason = string.Format(this.Resource("RkoReason1"), Math.Abs(this.Summ), shortName);
			return;
			IL_13A:
			this.Reason = string.Format(this.Resource("RkoReason2"), this.DocumentId, Math.Abs(this.Summ), shortName);
			return;
			IL_16D:
			this.Reason = string.Format(this.Resource("RkoReason3"), Math.Abs(this.Summ), shortName);
			return;
			IL_195:
			this.Reason = string.Format(this.Resource("RkoReason4"), Math.Abs(this.Summ), shortName);
			return;
			IL_1BD:
			this.Reason = string.Format(this.Resource("RkoReason5"), Math.Abs(this.Summ), shortName);
			return;
			IL_1E5:
			this.Reason = string.Format(this.Resource("RkoReason6"), Math.Abs(this.Summ), shortName);
			return;
			IL_20D:
			this.Reason = string.Format(this.Resource("RkoReason8"), Math.Abs(this.Summ), shortName, this.RepairId);
			return;
			IL_240:
			this.Reason = string.Format(this.Resource("RkoReason9"), Math.Abs(this.Summ), shortName, this.DocumentId);
			return;
			IL_273:
			this.Reason = string.Format(this.Resource("PkoReason11"), Math.Abs(this.Summ), shortName);
			return;
			IL_29B:
			this.Reason = string.Format(this.Resource("PkoReason12"), this.RepairId, Math.Abs(this.Summ), shortName);
			return;
			IL_2CE:
			this.Reason = string.Format(this.Resource("PkoReason13"), Math.Abs(this.Summ), shortName, string.Format("{0:D6}", this.CustomerId));
			return;
			IL_30B:
			this.Reason = string.Format(this.Resource("PkoReason14"), Math.Abs(this.Summ), shortName, string.Format("{0:D6}", this.DocumentId));
			return;
			IL_348:
			this.Reason = string.Format(this.Resource("PkoReason15"), Math.Abs(this.Summ), shortName, string.Format("{0:D6}", this.RepairId));
			return;
			IL_385:
			this.Reason = string.Format(this.Resource("RkoReason16"), Math.Abs(this.Summ), shortName, this.DocumentId);
			return;
			IL_3B8:
			this.Reason = string.Format(this.Resource("PkoReason17"), Math.Abs(this.Summ), shortName, string.Format("{0:D6}", this.InvoiceId));
			return;
			IL_3F5:
			this.Reason = string.Format(this.Resource("RkoReason19"), Math.Abs(this.Summ), shortName);
		}

		// Token: 0x06004311 RID: 17169 RVA: 0x00106854 File Offset: 0x00104A54
		private string Resource(string resource)
		{
			return (string)Application.Current.TryFindResource(resource);
		}

		// Token: 0x06004312 RID: 17170 RVA: 0x00106874 File Offset: 0x00104A74
		public void SetCustomer(int? customerId)
		{
			CashOrder.<SetCustomer>d__135 <SetCustomer>d__;
			<SetCustomer>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SetCustomer>d__.<>4__this = this;
			<SetCustomer>d__.customerId = customerId;
			<SetCustomer>d__.<>1__state = -1;
			<SetCustomer>d__.<>t__builder.Start<CashOrder.<SetCustomer>d__135>(ref <SetCustomer>d__);
		}

		// Token: 0x06004313 RID: 17171 RVA: 0x001068B4 File Offset: 0x00104AB4
		public void SetCompany(int companyId)
		{
			this.CompanyId = companyId;
		}

		// Token: 0x06004314 RID: 17172 RVA: 0x001068C8 File Offset: 0x00104AC8
		public void SetType(Kassa.Types type)
		{
			this.Type = (int)type;
		}

		// Token: 0x06004315 RID: 17173 RVA: 0x001068DC File Offset: 0x00104ADC
		public bool RepairAttached()
		{
			return this.RepairId != null;
		}

		// Token: 0x06004316 RID: 17174 RVA: 0x001068F8 File Offset: 0x00104AF8
		public bool DocumentAttached()
		{
			return this.DocumentId != null;
		}

		// Token: 0x06004317 RID: 17175 RVA: 0x00106914 File Offset: 0x00104B14
		public bool InvoiceAttached()
		{
			return this.InvoiceId != null;
		}

		// Token: 0x06004318 RID: 17176 RVA: 0x00106930 File Offset: 0x00104B30
		public void SetCustomerEmail(string customerEmail)
		{
			this.CustomerEmail = customerEmail;
		}

		// Token: 0x06004319 RID: 17177 RVA: 0x00106944 File Offset: 0x00104B44
		public bool IsNew()
		{
			return this.Id == 0;
		}

		// Token: 0x04002B2A RID: 11050
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04002B2B RID: 11051
		[CompilerGenerated]
		private DateTime <Date>k__BackingField;

		// Token: 0x04002B2C RID: 11052
		[CompilerGenerated]
		private int <CompanyId>k__BackingField;

		// Token: 0x04002B2D RID: 11053
		[CompilerGenerated]
		private int <OfficeId>k__BackingField;

		// Token: 0x04002B2E RID: 11054
		[CompilerGenerated]
		private int <Type>k__BackingField;

		// Token: 0x04002B2F RID: 11055
		[CompilerGenerated]
		private int <EmployeeId>k__BackingField;

		// Token: 0x04002B30 RID: 11056
		[CompilerGenerated]
		private decimal <Summ>k__BackingField;

		// Token: 0x04002B31 RID: 11057
		[CompilerGenerated]
		private string <SummStr>k__BackingField;

		// Token: 0x04002B32 RID: 11058
		[CompilerGenerated]
		private int? <InvoiceId>k__BackingField;

		// Token: 0x04002B33 RID: 11059
		[CompilerGenerated]
		private int? <CustomerId>k__BackingField;

		// Token: 0x04002B34 RID: 11060
		[CompilerGenerated]
		private string <CustomerEmail>k__BackingField;

		// Token: 0x04002B35 RID: 11061
		[CompilerGenerated]
		private CustomerCard <Customer>k__BackingField;

		// Token: 0x04002B36 RID: 11062
		[CompilerGenerated]
		private int? <ToEmployeeId>k__BackingField;

		// Token: 0x04002B37 RID: 11063
		[CompilerGenerated]
		private string <Reason>k__BackingField;

		// Token: 0x04002B38 RID: 11064
		[CompilerGenerated]
		private int? <RepairId>k__BackingField;

		// Token: 0x04002B39 RID: 11065
		[CompilerGenerated]
		private int? <DocumentId>k__BackingField;

		// Token: 0x04002B3A RID: 11066
		[CompilerGenerated]
		private int? <PhotoId>k__BackingField;

		// Token: 0x04002B3B RID: 11067
		[CompilerGenerated]
		private byte[] <Photo>k__BackingField;

		// Token: 0x04002B3C RID: 11068
		[CompilerGenerated]
		private int <PaymentSystem>k__BackingField;

		// Token: 0x04002B3D RID: 11069
		[CompilerGenerated]
		private decimal <CardFee>k__BackingField;

		// Token: 0x04002B3E RID: 11070
		[CompilerGenerated]
		private bool <IsBackdate>k__BackingField;

		// Token: 0x04002B3F RID: 11071
		[CompilerGenerated]
		private int <PinpadId>k__BackingField;

		// Token: 0x04002B40 RID: 11072
		[CompilerGenerated]
		private decimal <Amount>k__BackingField;

		// Token: 0x04002B41 RID: 11073
		[CompilerGenerated]
		private string <TermNum>k__BackingField;

		// Token: 0x04002B42 RID: 11074
		[CompilerGenerated]
		private string <ClientCard>k__BackingField;

		// Token: 0x04002B43 RID: 11075
		[CompilerGenerated]
		private string <ClientExpiryDate>k__BackingField;

		// Token: 0x04002B44 RID: 11076
		[CompilerGenerated]
		private string <AuthCode>k__BackingField;

		// Token: 0x04002B45 RID: 11077
		[CompilerGenerated]
		private string <CardName>k__BackingField;

		// Token: 0x04002B46 RID: 11078
		[CompilerGenerated]
		private int? <PaymentItemSign>k__BackingField;

		// Token: 0x04002B47 RID: 11079
		[CompilerGenerated]
		private long? <FiscalDocumentNumber>k__BackingField;

		// Token: 0x02000899 RID: 2201
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SetCustomer>d__135 : IAsyncStateMachine
		{
			// Token: 0x0600431A RID: 17178 RVA: 0x0010695C File Offset: 0x00104B5C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CashOrder cashOrder = this.<>4__this;
				try
				{
					TaskAwaiter<CustomerCard> awaiter;
					if (num != 0)
					{
						cashOrder.CustomerId = this.customerId;
						if (this.customerId == null)
						{
							cashOrder.Customer = null;
							cashOrder.CustomerEmail = "";
							goto IL_C3;
						}
						awaiter = ClientsModel.GetCustomerCard(this.customerId.Value).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<CustomerCard>, CashOrder.<SetCustomer>d__135>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<CustomerCard>);
						this.<>1__state = -1;
					}
					CustomerCard result = awaiter.GetResult();
					cashOrder.Customer = result;
					CashOrder cashOrder2 = cashOrder;
					CustomerCard customer = cashOrder.Customer;
					cashOrder2.CustomerEmail = ((customer != null) ? customer.Email : null);
					IL_C3:;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x0600431B RID: 17179 RVA: 0x00106A6C File Offset: 0x00104C6C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002B48 RID: 11080
			public int <>1__state;

			// Token: 0x04002B49 RID: 11081
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04002B4A RID: 11082
			public CashOrder <>4__this;

			// Token: 0x04002B4B RID: 11083
			public int? customerId;

			// Token: 0x04002B4C RID: 11084
			private TaskAwaiter<CustomerCard> <>u__1;
		}
	}
}
