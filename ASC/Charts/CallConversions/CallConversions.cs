using System;
using System.Runtime.CompilerServices;

namespace ASC.Charts.CallConversions
{
	// Token: 0x0200029A RID: 666
	public class CallConversions
	{
		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x06002290 RID: 8848 RVA: 0x00065610 File Offset: 0x00063810
		// (set) Token: 0x06002291 RID: 8849 RVA: 0x00065624 File Offset: 0x00063824
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
				this.<Date>k__BackingField = value;
			}
		}

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x06002292 RID: 8850 RVA: 0x00065638 File Offset: 0x00063838
		// (set) Token: 0x06002293 RID: 8851 RVA: 0x0006564C File Offset: 0x0006384C
		public int Count
		{
			[CompilerGenerated]
			get
			{
				return this.<Count>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Count>k__BackingField = value;
			}
		}

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x06002294 RID: 8852 RVA: 0x00065660 File Offset: 0x00063860
		// (set) Token: 0x06002295 RID: 8853 RVA: 0x00065674 File Offset: 0x00063874
		public int TotalCalls
		{
			[CompilerGenerated]
			get
			{
				return this.<TotalCalls>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<TotalCalls>k__BackingField = value;
			}
		}

		// Token: 0x06002296 RID: 8854 RVA: 0x000046B4 File Offset: 0x000028B4
		public CallConversions()
		{
		}

		// Token: 0x040011D7 RID: 4567
		[CompilerGenerated]
		private DateTime <Date>k__BackingField;

		// Token: 0x040011D8 RID: 4568
		[CompilerGenerated]
		private int <Count>k__BackingField;

		// Token: 0x040011D9 RID: 4569
		[CompilerGenerated]
		private int <TotalCalls>k__BackingField;
	}
}
