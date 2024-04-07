using System;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;

namespace ASC.Objects
{
	// Token: 0x020008E7 RID: 2279
	public class PaymentDetails : IIdName, IPaymentDetails, IPaymentDetailLookup
	{
		// Token: 0x17001379 RID: 4985
		// (get) Token: 0x06004663 RID: 18019 RVA: 0x001133AC File Offset: 0x001115AC
		// (set) Token: 0x06004664 RID: 18020 RVA: 0x001133C0 File Offset: 0x001115C0
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
				this.<Id>k__BackingField = value;
			}
		}

		// Token: 0x1700137A RID: 4986
		// (get) Token: 0x06004665 RID: 18021 RVA: 0x001133D4 File Offset: 0x001115D4
		// (set) Token: 0x06004666 RID: 18022 RVA: 0x001133E8 File Offset: 0x001115E8
		public int CustomerId
		{
			[CompilerGenerated]
			get
			{
				return this.<CustomerId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<CustomerId>k__BackingField = value;
			}
		}

		// Token: 0x1700137B RID: 4987
		// (get) Token: 0x06004667 RID: 18023 RVA: 0x001133FC File Offset: 0x001115FC
		// (set) Token: 0x06004668 RID: 18024 RVA: 0x00113410 File Offset: 0x00111610
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
				this.<CompanyId>k__BackingField = value;
			}
		}

		// Token: 0x1700137C RID: 4988
		// (get) Token: 0x06004669 RID: 18025 RVA: 0x00113424 File Offset: 0x00111624
		// (set) Token: 0x0600466A RID: 18026 RVA: 0x00113438 File Offset: 0x00111638
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.<Name>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x1700137D RID: 4989
		// (get) Token: 0x0600466B RID: 18027 RVA: 0x0011344C File Offset: 0x0011164C
		// (set) Token: 0x0600466C RID: 18028 RVA: 0x00113460 File Offset: 0x00111660
		public string Inn
		{
			[CompilerGenerated]
			get
			{
				return this.<Inn>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Inn>k__BackingField = value;
			}
		}

		// Token: 0x1700137E RID: 4990
		// (get) Token: 0x0600466D RID: 18029 RVA: 0x00113474 File Offset: 0x00111674
		// (set) Token: 0x0600466E RID: 18030 RVA: 0x00113488 File Offset: 0x00111688
		public string Kpp
		{
			[CompilerGenerated]
			get
			{
				return this.<Kpp>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Kpp>k__BackingField = value;
			}
		}

		// Token: 0x1700137F RID: 4991
		// (get) Token: 0x0600466F RID: 18031 RVA: 0x0011349C File Offset: 0x0011169C
		// (set) Token: 0x06004670 RID: 18032 RVA: 0x001134B0 File Offset: 0x001116B0
		public string Ogrn
		{
			[CompilerGenerated]
			get
			{
				return this.<Ogrn>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Ogrn>k__BackingField = value;
			}
		}

		// Token: 0x17001380 RID: 4992
		// (get) Token: 0x06004671 RID: 18033 RVA: 0x001134C4 File Offset: 0x001116C4
		// (set) Token: 0x06004672 RID: 18034 RVA: 0x001134D8 File Offset: 0x001116D8
		public string Address
		{
			[CompilerGenerated]
			get
			{
				return this.<Address>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Address>k__BackingField = value;
			}
		}

		// Token: 0x17001381 RID: 4993
		// (get) Token: 0x06004673 RID: 18035 RVA: 0x001134EC File Offset: 0x001116EC
		// (set) Token: 0x06004674 RID: 18036 RVA: 0x00113500 File Offset: 0x00111700
		public string CorrespondentAccount
		{
			[CompilerGenerated]
			get
			{
				return this.<CorrespondentAccount>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<CorrespondentAccount>k__BackingField = value;
			}
		}

		// Token: 0x17001382 RID: 4994
		// (get) Token: 0x06004675 RID: 18037 RVA: 0x00113514 File Offset: 0x00111714
		// (set) Token: 0x06004676 RID: 18038 RVA: 0x00113528 File Offset: 0x00111728
		public string CheckingAccount
		{
			[CompilerGenerated]
			get
			{
				return this.<CheckingAccount>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<CheckingAccount>k__BackingField = value;
			}
		}

		// Token: 0x17001383 RID: 4995
		// (get) Token: 0x06004677 RID: 18039 RVA: 0x0011353C File Offset: 0x0011173C
		// (set) Token: 0x06004678 RID: 18040 RVA: 0x00113550 File Offset: 0x00111750
		public string Bank
		{
			[CompilerGenerated]
			get
			{
				return this.<Bank>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Bank>k__BackingField = value;
			}
		}

		// Token: 0x17001384 RID: 4996
		// (get) Token: 0x06004679 RID: 18041 RVA: 0x00113564 File Offset: 0x00111764
		// (set) Token: 0x0600467A RID: 18042 RVA: 0x00113578 File Offset: 0x00111778
		public string Bic
		{
			[CompilerGenerated]
			get
			{
				return this.<Bic>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Bic>k__BackingField = value;
			}
		}

		// Token: 0x17001385 RID: 4997
		// (get) Token: 0x0600467B RID: 18043 RVA: 0x0011358C File Offset: 0x0011178C
		// (set) Token: 0x0600467C RID: 18044 RVA: 0x001135A0 File Offset: 0x001117A0
		public string Chief
		{
			[CompilerGenerated]
			get
			{
				return this.<Chief>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Chief>k__BackingField = value;
			}
		}

		// Token: 0x17001386 RID: 4998
		// (get) Token: 0x0600467D RID: 18045 RVA: 0x001135B4 File Offset: 0x001117B4
		// (set) Token: 0x0600467E RID: 18046 RVA: 0x001135C8 File Offset: 0x001117C8
		public string Accountant
		{
			[CompilerGenerated]
			get
			{
				return this.<Accountant>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Accountant>k__BackingField = value;
			}
		}

		// Token: 0x17001387 RID: 4999
		// (get) Token: 0x0600467F RID: 18047 RVA: 0x001135DC File Offset: 0x001117DC
		// (set) Token: 0x06004680 RID: 18048 RVA: 0x001135F0 File Offset: 0x001117F0
		public string Email
		{
			[CompilerGenerated]
			get
			{
				return this.<Email>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Email>k__BackingField = value;
			}
		}

		// Token: 0x17001388 RID: 5000
		// (get) Token: 0x06004681 RID: 18049 RVA: 0x00113604 File Offset: 0x00111804
		// (set) Token: 0x06004682 RID: 18050 RVA: 0x00113618 File Offset: 0x00111818
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
				this.<Type>k__BackingField = value;
			}
		}

		// Token: 0x17001389 RID: 5001
		// (get) Token: 0x06004683 RID: 18051 RVA: 0x0011362C File Offset: 0x0011182C
		// (set) Token: 0x06004684 RID: 18052 RVA: 0x00113640 File Offset: 0x00111840
		public bool IsArchive
		{
			[CompilerGenerated]
			get
			{
				return this.<IsArchive>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<IsArchive>k__BackingField = value;
			}
		}

		// Token: 0x06004685 RID: 18053 RVA: 0x000046B4 File Offset: 0x000028B4
		public PaymentDetails()
		{
		}

		// Token: 0x04002D3F RID: 11583
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04002D40 RID: 11584
		[CompilerGenerated]
		private int <CustomerId>k__BackingField;

		// Token: 0x04002D41 RID: 11585
		[CompilerGenerated]
		private int <CompanyId>k__BackingField;

		// Token: 0x04002D42 RID: 11586
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04002D43 RID: 11587
		[CompilerGenerated]
		private string <Inn>k__BackingField;

		// Token: 0x04002D44 RID: 11588
		[CompilerGenerated]
		private string <Kpp>k__BackingField;

		// Token: 0x04002D45 RID: 11589
		[CompilerGenerated]
		private string <Ogrn>k__BackingField;

		// Token: 0x04002D46 RID: 11590
		[CompilerGenerated]
		private string <Address>k__BackingField;

		// Token: 0x04002D47 RID: 11591
		[CompilerGenerated]
		private string <CorrespondentAccount>k__BackingField;

		// Token: 0x04002D48 RID: 11592
		[CompilerGenerated]
		private string <CheckingAccount>k__BackingField;

		// Token: 0x04002D49 RID: 11593
		[CompilerGenerated]
		private string <Bank>k__BackingField;

		// Token: 0x04002D4A RID: 11594
		[CompilerGenerated]
		private string <Bic>k__BackingField;

		// Token: 0x04002D4B RID: 11595
		[CompilerGenerated]
		private string <Chief>k__BackingField;

		// Token: 0x04002D4C RID: 11596
		[CompilerGenerated]
		private string <Accountant>k__BackingField;

		// Token: 0x04002D4D RID: 11597
		[CompilerGenerated]
		private string <Email>k__BackingField;

		// Token: 0x04002D4E RID: 11598
		[CompilerGenerated]
		private int <Type>k__BackingField;

		// Token: 0x04002D4F RID: 11599
		[CompilerGenerated]
		private bool <IsArchive>k__BackingField;
	}
}
