using System;
using System.Runtime.CompilerServices;

namespace ASC.Models
{
	// Token: 0x02000948 RID: 2376
	public class RepairPaymentInfo
	{
		// Token: 0x1700142F RID: 5167
		// (get) Token: 0x060048F2 RID: 18674 RVA: 0x0011E148 File Offset: 0x0011C348
		// (set) Token: 0x060048F3 RID: 18675 RVA: 0x0011E15C File Offset: 0x0011C35C
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

		// Token: 0x17001430 RID: 5168
		// (get) Token: 0x060048F4 RID: 18676 RVA: 0x0011E170 File Offset: 0x0011C370
		// (set) Token: 0x060048F5 RID: 18677 RVA: 0x0011E184 File Offset: 0x0011C384
		public int PaymentSystemId
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentSystemId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<PaymentSystemId>k__BackingField = value;
			}
		}

		// Token: 0x17001431 RID: 5169
		// (get) Token: 0x060048F6 RID: 18678 RVA: 0x0011E198 File Offset: 0x0011C398
		// (set) Token: 0x060048F7 RID: 18679 RVA: 0x0011E1AC File Offset: 0x0011C3AC
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

		// Token: 0x17001432 RID: 5170
		// (get) Token: 0x060048F8 RID: 18680 RVA: 0x0011E1C0 File Offset: 0x0011C3C0
		// (set) Token: 0x060048F9 RID: 18681 RVA: 0x0011E1D4 File Offset: 0x0011C3D4
		public decimal PrepaidAmount
		{
			[CompilerGenerated]
			get
			{
				return this.<PrepaidAmount>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<PrepaidAmount>k__BackingField = value;
			}
		}

		// Token: 0x060048FA RID: 18682 RVA: 0x000046B4 File Offset: 0x000028B4
		public RepairPaymentInfo()
		{
		}

		// Token: 0x04002E6B RID: 11883
		[CompilerGenerated]
		private int <CompanyId>k__BackingField;

		// Token: 0x04002E6C RID: 11884
		[CompilerGenerated]
		private int <PaymentSystemId>k__BackingField;

		// Token: 0x04002E6D RID: 11885
		[CompilerGenerated]
		private int <CustomerId>k__BackingField;

		// Token: 0x04002E6E RID: 11886
		[CompilerGenerated]
		private decimal <PrepaidAmount>k__BackingField;
	}
}
