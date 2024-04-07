using System;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;

namespace ASC.Objects
{
	// Token: 0x020008C5 RID: 2245
	public class ChartData : IChartData
	{
		// Token: 0x170012D4 RID: 4820
		// (get) Token: 0x0600447E RID: 17534 RVA: 0x0010CEB0 File Offset: 0x0010B0B0
		// (set) Token: 0x0600447F RID: 17535 RVA: 0x0010CEC4 File Offset: 0x0010B0C4
		public string SeriesDataMember
		{
			[CompilerGenerated]
			get
			{
				return this.<SeriesDataMember>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<SeriesDataMember>k__BackingField = value;
			}
		}

		// Token: 0x170012D5 RID: 4821
		// (get) Token: 0x06004480 RID: 17536 RVA: 0x0010CED8 File Offset: 0x0010B0D8
		// (set) Token: 0x06004481 RID: 17537 RVA: 0x0010CEEC File Offset: 0x0010B0EC
		public DateTime ArgumentDataMember
		{
			[CompilerGenerated]
			get
			{
				return this.<ArgumentDataMember>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ArgumentDataMember>k__BackingField = value;
			}
		}

		// Token: 0x170012D6 RID: 4822
		// (get) Token: 0x06004482 RID: 17538 RVA: 0x0010CF00 File Offset: 0x0010B100
		// (set) Token: 0x06004483 RID: 17539 RVA: 0x0010CF14 File Offset: 0x0010B114
		public decimal ValueDataMember
		{
			[CompilerGenerated]
			get
			{
				return this.<ValueDataMember>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ValueDataMember>k__BackingField = value;
			}
		}

		// Token: 0x06004484 RID: 17540 RVA: 0x000046B4 File Offset: 0x000028B4
		public ChartData()
		{
		}

		// Token: 0x04002C37 RID: 11319
		[CompilerGenerated]
		private string <SeriesDataMember>k__BackingField;

		// Token: 0x04002C38 RID: 11320
		[CompilerGenerated]
		private DateTime <ArgumentDataMember>k__BackingField;

		// Token: 0x04002C39 RID: 11321
		[CompilerGenerated]
		private decimal <ValueDataMember>k__BackingField;
	}
}
