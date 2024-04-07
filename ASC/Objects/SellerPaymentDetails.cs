using System;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;

namespace ASC.Objects
{
	// Token: 0x020008F6 RID: 2294
	public class SellerPaymentDetails : IIdName, IPaymentDetails, IPaymentDetailLookup, ISellerPaymentDetails
	{
		// Token: 0x170013D8 RID: 5080
		// (get) Token: 0x06004758 RID: 18264 RVA: 0x001160A4 File Offset: 0x001142A4
		// (set) Token: 0x06004759 RID: 18265 RVA: 0x001160B8 File Offset: 0x001142B8
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

		// Token: 0x170013D9 RID: 5081
		// (get) Token: 0x0600475A RID: 18266 RVA: 0x001160CC File Offset: 0x001142CC
		// (set) Token: 0x0600475B RID: 18267 RVA: 0x001160E0 File Offset: 0x001142E0
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

		// Token: 0x170013DA RID: 5082
		// (get) Token: 0x0600475C RID: 18268 RVA: 0x001160F4 File Offset: 0x001142F4
		// (set) Token: 0x0600475D RID: 18269 RVA: 0x00116108 File Offset: 0x00114308
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

		// Token: 0x170013DB RID: 5083
		// (get) Token: 0x0600475E RID: 18270 RVA: 0x0011611C File Offset: 0x0011431C
		// (set) Token: 0x0600475F RID: 18271 RVA: 0x00116130 File Offset: 0x00114330
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

		// Token: 0x170013DC RID: 5084
		// (get) Token: 0x06004760 RID: 18272 RVA: 0x00116144 File Offset: 0x00114344
		// (set) Token: 0x06004761 RID: 18273 RVA: 0x00116158 File Offset: 0x00114358
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

		// Token: 0x170013DD RID: 5085
		// (get) Token: 0x06004762 RID: 18274 RVA: 0x0011616C File Offset: 0x0011436C
		// (set) Token: 0x06004763 RID: 18275 RVA: 0x00116180 File Offset: 0x00114380
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

		// Token: 0x170013DE RID: 5086
		// (get) Token: 0x06004764 RID: 18276 RVA: 0x00116194 File Offset: 0x00114394
		// (set) Token: 0x06004765 RID: 18277 RVA: 0x001161A8 File Offset: 0x001143A8
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

		// Token: 0x170013DF RID: 5087
		// (get) Token: 0x06004766 RID: 18278 RVA: 0x001161BC File Offset: 0x001143BC
		// (set) Token: 0x06004767 RID: 18279 RVA: 0x001161D0 File Offset: 0x001143D0
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

		// Token: 0x170013E0 RID: 5088
		// (get) Token: 0x06004768 RID: 18280 RVA: 0x001161E4 File Offset: 0x001143E4
		// (set) Token: 0x06004769 RID: 18281 RVA: 0x001161F8 File Offset: 0x001143F8
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

		// Token: 0x170013E1 RID: 5089
		// (get) Token: 0x0600476A RID: 18282 RVA: 0x0011620C File Offset: 0x0011440C
		// (set) Token: 0x0600476B RID: 18283 RVA: 0x00116220 File Offset: 0x00114420
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

		// Token: 0x170013E2 RID: 5090
		// (get) Token: 0x0600476C RID: 18284 RVA: 0x00116234 File Offset: 0x00114434
		// (set) Token: 0x0600476D RID: 18285 RVA: 0x00116248 File Offset: 0x00114448
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

		// Token: 0x170013E3 RID: 5091
		// (get) Token: 0x0600476E RID: 18286 RVA: 0x0011625C File Offset: 0x0011445C
		// (set) Token: 0x0600476F RID: 18287 RVA: 0x00116270 File Offset: 0x00114470
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

		// Token: 0x170013E4 RID: 5092
		// (get) Token: 0x06004770 RID: 18288 RVA: 0x00116284 File Offset: 0x00114484
		// (set) Token: 0x06004771 RID: 18289 RVA: 0x00116298 File Offset: 0x00114498
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

		// Token: 0x170013E5 RID: 5093
		// (get) Token: 0x06004772 RID: 18290 RVA: 0x001162AC File Offset: 0x001144AC
		// (set) Token: 0x06004773 RID: 18291 RVA: 0x001162C0 File Offset: 0x001144C0
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

		// Token: 0x170013E6 RID: 5094
		// (get) Token: 0x06004774 RID: 18292 RVA: 0x001162D4 File Offset: 0x001144D4
		// (set) Token: 0x06004775 RID: 18293 RVA: 0x001162E8 File Offset: 0x001144E8
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

		// Token: 0x170013E7 RID: 5095
		// (get) Token: 0x06004776 RID: 18294 RVA: 0x001162FC File Offset: 0x001144FC
		// (set) Token: 0x06004777 RID: 18295 RVA: 0x00116310 File Offset: 0x00114510
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
		} = 1;

		// Token: 0x170013E8 RID: 5096
		// (get) Token: 0x06004778 RID: 18296 RVA: 0x00116324 File Offset: 0x00114524
		// (set) Token: 0x06004779 RID: 18297 RVA: 0x00116338 File Offset: 0x00114538
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

		// Token: 0x170013E9 RID: 5097
		// (get) Token: 0x0600477A RID: 18298 RVA: 0x0011634C File Offset: 0x0011454C
		// (set) Token: 0x0600477B RID: 18299 RVA: 0x00116360 File Offset: 0x00114560
		public byte[] Seal
		{
			[CompilerGenerated]
			get
			{
				return this.<Seal>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Seal>k__BackingField = value;
			}
		}

		// Token: 0x170013EA RID: 5098
		// (get) Token: 0x0600477C RID: 18300 RVA: 0x00116374 File Offset: 0x00114574
		// (set) Token: 0x0600477D RID: 18301 RVA: 0x00116388 File Offset: 0x00114588
		public byte[] ChiefSignature
		{
			[CompilerGenerated]
			get
			{
				return this.<ChiefSignature>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ChiefSignature>k__BackingField = value;
			}
		}

		// Token: 0x170013EB RID: 5099
		// (get) Token: 0x0600477E RID: 18302 RVA: 0x0011639C File Offset: 0x0011459C
		// (set) Token: 0x0600477F RID: 18303 RVA: 0x001163B0 File Offset: 0x001145B0
		public byte[] AccountantSignature
		{
			[CompilerGenerated]
			get
			{
				return this.<AccountantSignature>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<AccountantSignature>k__BackingField = value;
			}
		}

		// Token: 0x06004780 RID: 18304 RVA: 0x001163C4 File Offset: 0x001145C4
		public SellerPaymentDetails()
		{
		}

		// Token: 0x04002DBF RID: 11711
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04002DC0 RID: 11712
		[CompilerGenerated]
		private int <CustomerId>k__BackingField;

		// Token: 0x04002DC1 RID: 11713
		[CompilerGenerated]
		private int <CompanyId>k__BackingField;

		// Token: 0x04002DC2 RID: 11714
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04002DC3 RID: 11715
		[CompilerGenerated]
		private string <Inn>k__BackingField;

		// Token: 0x04002DC4 RID: 11716
		[CompilerGenerated]
		private string <Kpp>k__BackingField;

		// Token: 0x04002DC5 RID: 11717
		[CompilerGenerated]
		private string <Ogrn>k__BackingField;

		// Token: 0x04002DC6 RID: 11718
		[CompilerGenerated]
		private string <Address>k__BackingField;

		// Token: 0x04002DC7 RID: 11719
		[CompilerGenerated]
		private string <CorrespondentAccount>k__BackingField;

		// Token: 0x04002DC8 RID: 11720
		[CompilerGenerated]
		private string <CheckingAccount>k__BackingField;

		// Token: 0x04002DC9 RID: 11721
		[CompilerGenerated]
		private string <Bank>k__BackingField;

		// Token: 0x04002DCA RID: 11722
		[CompilerGenerated]
		private string <Bic>k__BackingField;

		// Token: 0x04002DCB RID: 11723
		[CompilerGenerated]
		private string <Chief>k__BackingField;

		// Token: 0x04002DCC RID: 11724
		[CompilerGenerated]
		private string <Accountant>k__BackingField;

		// Token: 0x04002DCD RID: 11725
		[CompilerGenerated]
		private string <Email>k__BackingField;

		// Token: 0x04002DCE RID: 11726
		[CompilerGenerated]
		private int <Type>k__BackingField;

		// Token: 0x04002DCF RID: 11727
		[CompilerGenerated]
		private bool <IsArchive>k__BackingField;

		// Token: 0x04002DD0 RID: 11728
		[CompilerGenerated]
		private byte[] <Seal>k__BackingField;

		// Token: 0x04002DD1 RID: 11729
		[CompilerGenerated]
		private byte[] <ChiefSignature>k__BackingField;

		// Token: 0x04002DD2 RID: 11730
		[CompilerGenerated]
		private byte[] <AccountantSignature>k__BackingField;
	}
}
