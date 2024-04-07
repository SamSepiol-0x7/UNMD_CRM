using System;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;

namespace ASC.Charts.VisitSource
{
	// Token: 0x02000282 RID: 642
	public class VisitSourceChartPoint : IVisitSourceChartItem
	{
		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x060021F7 RID: 8695 RVA: 0x00063348 File Offset: 0x00061548
		// (set) Token: 0x060021F8 RID: 8696 RVA: 0x0006335C File Offset: 0x0006155C
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

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x060021F9 RID: 8697 RVA: 0x00063370 File Offset: 0x00061570
		// (set) Token: 0x060021FA RID: 8698 RVA: 0x00063384 File Offset: 0x00061584
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

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x060021FB RID: 8699 RVA: 0x00063398 File Offset: 0x00061598
		// (set) Token: 0x060021FC RID: 8700 RVA: 0x000633AC File Offset: 0x000615AC
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

		// Token: 0x060021FD RID: 8701 RVA: 0x000046B4 File Offset: 0x000028B4
		public VisitSourceChartPoint()
		{
		}

		// Token: 0x0400116E RID: 4462
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x0400116F RID: 4463
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04001170 RID: 4464
		[CompilerGenerated]
		private int <Count>k__BackingField;
	}
}
