using System;
using System.Runtime.CompilerServices;

namespace ASC.SimpleClasses
{
	// Token: 0x02000204 RID: 516
	public class PbUaRate
	{
		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06001BB7 RID: 7095 RVA: 0x00051D50 File Offset: 0x0004FF50
		// (set) Token: 0x06001BB8 RID: 7096 RVA: 0x00051D64 File Offset: 0x0004FF64
		public string ccy
		{
			[CompilerGenerated]
			get
			{
				return this.<ccy>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ccy>k__BackingField = value;
			}
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06001BB9 RID: 7097 RVA: 0x00051D78 File Offset: 0x0004FF78
		// (set) Token: 0x06001BBA RID: 7098 RVA: 0x00051D8C File Offset: 0x0004FF8C
		public string base_ccy
		{
			[CompilerGenerated]
			get
			{
				return this.<base_ccy>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<base_ccy>k__BackingField = value;
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06001BBB RID: 7099 RVA: 0x00051DA0 File Offset: 0x0004FFA0
		// (set) Token: 0x06001BBC RID: 7100 RVA: 0x00051DB4 File Offset: 0x0004FFB4
		public decimal buy
		{
			[CompilerGenerated]
			get
			{
				return this.<buy>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<buy>k__BackingField = value;
			}
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x06001BBD RID: 7101 RVA: 0x00051DC8 File Offset: 0x0004FFC8
		// (set) Token: 0x06001BBE RID: 7102 RVA: 0x00051DDC File Offset: 0x0004FFDC
		public decimal sale
		{
			[CompilerGenerated]
			get
			{
				return this.<sale>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<sale>k__BackingField = value;
			}
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x000046B4 File Offset: 0x000028B4
		public PbUaRate()
		{
		}

		// Token: 0x04000EA0 RID: 3744
		[CompilerGenerated]
		private string <ccy>k__BackingField;

		// Token: 0x04000EA1 RID: 3745
		[CompilerGenerated]
		private string <base_ccy>k__BackingField;

		// Token: 0x04000EA2 RID: 3746
		[CompilerGenerated]
		private decimal <buy>k__BackingField;

		// Token: 0x04000EA3 RID: 3747
		[CompilerGenerated]
		private decimal <sale>k__BackingField;
	}
}
