using System;
using System.Runtime.CompilerServices;
using ASC.Interfaces;

namespace ASC.Objects
{
	// Token: 0x02000884 RID: 2180
	public class PinpadResult : IPinpadResult
	{
		// Token: 0x170011D1 RID: 4561
		// (get) Token: 0x060041A8 RID: 16808 RVA: 0x00102F38 File Offset: 0x00101138
		// (set) Token: 0x060041A9 RID: 16809 RVA: 0x00102F4C File Offset: 0x0010114C
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
				this.<PinpadId>k__BackingField = value;
			}
		}

		// Token: 0x170011D2 RID: 4562
		// (get) Token: 0x060041AA RID: 16810 RVA: 0x00102F60 File Offset: 0x00101160
		// (set) Token: 0x060041AB RID: 16811 RVA: 0x00102F74 File Offset: 0x00101174
		public int ErrorCode
		{
			[CompilerGenerated]
			get
			{
				return this.<ErrorCode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ErrorCode>k__BackingField = value;
			}
		}

		// Token: 0x170011D3 RID: 4563
		// (get) Token: 0x060041AC RID: 16812 RVA: 0x00102F88 File Offset: 0x00101188
		// (set) Token: 0x060041AD RID: 16813 RVA: 0x00102F9C File Offset: 0x0010119C
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
				this.<Amount>k__BackingField = value;
			}
		}

		// Token: 0x170011D4 RID: 4564
		// (get) Token: 0x060041AE RID: 16814 RVA: 0x00102FB0 File Offset: 0x001011B0
		// (set) Token: 0x060041AF RID: 16815 RVA: 0x00102FC4 File Offset: 0x001011C4
		public string Cheque
		{
			[CompilerGenerated]
			get
			{
				return this.<Cheque>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Cheque>k__BackingField = value;
			}
		}

		// Token: 0x170011D5 RID: 4565
		// (get) Token: 0x060041B0 RID: 16816 RVA: 0x00102FD8 File Offset: 0x001011D8
		// (set) Token: 0x060041B1 RID: 16817 RVA: 0x00102FEC File Offset: 0x001011EC
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
				this.<TermNum>k__BackingField = value;
			}
		}

		// Token: 0x170011D6 RID: 4566
		// (get) Token: 0x060041B2 RID: 16818 RVA: 0x00103000 File Offset: 0x00101200
		// (set) Token: 0x060041B3 RID: 16819 RVA: 0x00103014 File Offset: 0x00101214
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
				this.<ClientCard>k__BackingField = value;
			}
		}

		// Token: 0x170011D7 RID: 4567
		// (get) Token: 0x060041B4 RID: 16820 RVA: 0x00103028 File Offset: 0x00101228
		// (set) Token: 0x060041B5 RID: 16821 RVA: 0x0010303C File Offset: 0x0010123C
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
				this.<ClientExpiryDate>k__BackingField = value;
			}
		}

		// Token: 0x170011D8 RID: 4568
		// (get) Token: 0x060041B6 RID: 16822 RVA: 0x00103050 File Offset: 0x00101250
		// (set) Token: 0x060041B7 RID: 16823 RVA: 0x00103064 File Offset: 0x00101264
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
				this.<AuthCode>k__BackingField = value;
			}
		}

		// Token: 0x170011D9 RID: 4569
		// (get) Token: 0x060041B8 RID: 16824 RVA: 0x00103078 File Offset: 0x00101278
		// (set) Token: 0x060041B9 RID: 16825 RVA: 0x0010308C File Offset: 0x0010128C
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
				this.<CardName>k__BackingField = value;
			}
		}

		// Token: 0x170011DA RID: 4570
		// (get) Token: 0x060041BA RID: 16826 RVA: 0x001030A0 File Offset: 0x001012A0
		public string ResultText
		{
			get
			{
				int errorCode = this.ErrorCode;
				if (errorCode == 0)
				{
					return "Complete";
				}
				if (errorCode == 2000)
				{
					return "Cancelled2";
				}
				return "Error";
			}
		}

		// Token: 0x060041BB RID: 16827 RVA: 0x000046B4 File Offset: 0x000028B4
		public PinpadResult()
		{
		}

		// Token: 0x04002AA7 RID: 10919
		[CompilerGenerated]
		private int <PinpadId>k__BackingField;

		// Token: 0x04002AA8 RID: 10920
		[CompilerGenerated]
		private int <ErrorCode>k__BackingField;

		// Token: 0x04002AA9 RID: 10921
		[CompilerGenerated]
		private decimal <Amount>k__BackingField;

		// Token: 0x04002AAA RID: 10922
		[CompilerGenerated]
		private string <Cheque>k__BackingField;

		// Token: 0x04002AAB RID: 10923
		[CompilerGenerated]
		private string <TermNum>k__BackingField;

		// Token: 0x04002AAC RID: 10924
		[CompilerGenerated]
		private string <ClientCard>k__BackingField;

		// Token: 0x04002AAD RID: 10925
		[CompilerGenerated]
		private string <ClientExpiryDate>k__BackingField;

		// Token: 0x04002AAE RID: 10926
		[CompilerGenerated]
		private string <AuthCode>k__BackingField;

		// Token: 0x04002AAF RID: 10927
		[CompilerGenerated]
		private string <CardName>k__BackingField;
	}
}
