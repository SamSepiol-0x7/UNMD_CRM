using System;
using System.Runtime.CompilerServices;
using ASC.Interfaces;

namespace ASC.Objects
{
	// Token: 0x02000883 RID: 2179
	public class Pinpad : IPinpad
	{
		// Token: 0x170011CB RID: 4555
		// (get) Token: 0x0600419B RID: 16795 RVA: 0x00102E48 File Offset: 0x00101048
		// (set) Token: 0x0600419C RID: 16796 RVA: 0x00102E5C File Offset: 0x0010105C
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

		// Token: 0x170011CC RID: 4556
		// (get) Token: 0x0600419D RID: 16797 RVA: 0x00102E70 File Offset: 0x00101070
		// (set) Token: 0x0600419E RID: 16798 RVA: 0x00102E84 File Offset: 0x00101084
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
				this.<OfficeId>k__BackingField = value;
			}
		}

		// Token: 0x170011CD RID: 4557
		// (get) Token: 0x0600419F RID: 16799 RVA: 0x00102E98 File Offset: 0x00101098
		// (set) Token: 0x060041A0 RID: 16800 RVA: 0x00102EAC File Offset: 0x001010AC
		public double Fee
		{
			[CompilerGenerated]
			get
			{
				return this.<Fee>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Fee>k__BackingField = value;
			}
		}

		// Token: 0x170011CE RID: 4558
		// (get) Token: 0x060041A1 RID: 16801 RVA: 0x00102EC0 File Offset: 0x001010C0
		// (set) Token: 0x060041A2 RID: 16802 RVA: 0x00102ED4 File Offset: 0x001010D4
		public bool FeeMode
		{
			[CompilerGenerated]
			get
			{
				return this.<FeeMode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<FeeMode>k__BackingField = value;
			}
		}

		// Token: 0x170011CF RID: 4559
		// (get) Token: 0x060041A3 RID: 16803 RVA: 0x00102EE8 File Offset: 0x001010E8
		// (set) Token: 0x060041A4 RID: 16804 RVA: 0x00102EFC File Offset: 0x001010FC
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

		// Token: 0x170011D0 RID: 4560
		// (get) Token: 0x060041A5 RID: 16805 RVA: 0x00102F10 File Offset: 0x00101110
		// (set) Token: 0x060041A6 RID: 16806 RVA: 0x00102F24 File Offset: 0x00101124
		public int? Kkt
		{
			[CompilerGenerated]
			get
			{
				return this.<Kkt>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Kkt>k__BackingField = value;
			}
		}

		// Token: 0x060041A7 RID: 16807 RVA: 0x000046B4 File Offset: 0x000028B4
		public Pinpad()
		{
		}

		// Token: 0x04002AA1 RID: 10913
		[CompilerGenerated]
		private int <PinpadId>k__BackingField;

		// Token: 0x04002AA2 RID: 10914
		[CompilerGenerated]
		private int <OfficeId>k__BackingField;

		// Token: 0x04002AA3 RID: 10915
		[CompilerGenerated]
		private double <Fee>k__BackingField;

		// Token: 0x04002AA4 RID: 10916
		[CompilerGenerated]
		private bool <FeeMode>k__BackingField;

		// Token: 0x04002AA5 RID: 10917
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04002AA6 RID: 10918
		[CompilerGenerated]
		private int? <Kkt>k__BackingField;
	}
}
