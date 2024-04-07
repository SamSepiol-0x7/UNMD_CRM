using System;
using System.Runtime.CompilerServices;

namespace ASC.SimpleClasses
{
	// Token: 0x02000210 RID: 528
	public class SalesInfo
	{
		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x06001C09 RID: 7177 RVA: 0x000528A4 File Offset: 0x00050AA4
		// (set) Token: 0x06001C0A RID: 7178 RVA: 0x000528B8 File Offset: 0x00050AB8
		public int SalesTotal
		{
			[CompilerGenerated]
			get
			{
				return this.<SalesTotal>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<SalesTotal>k__BackingField = value;
			}
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x06001C0B RID: 7179 RVA: 0x000528CC File Offset: 0x00050ACC
		// (set) Token: 0x06001C0C RID: 7180 RVA: 0x000528E0 File Offset: 0x00050AE0
		public string Date
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

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06001C0D RID: 7181 RVA: 0x000528F4 File Offset: 0x00050AF4
		// (set) Token: 0x06001C0E RID: 7182 RVA: 0x00052908 File Offset: 0x00050B08
		public string ToolTipText
		{
			[CompilerGenerated]
			get
			{
				return this.<ToolTipText>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ToolTipText>k__BackingField = value;
			}
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x000046B4 File Offset: 0x000028B4
		public SalesInfo()
		{
		}

		// Token: 0x04000EC9 RID: 3785
		[CompilerGenerated]
		private int <SalesTotal>k__BackingField;

		// Token: 0x04000ECA RID: 3786
		[CompilerGenerated]
		private string <Date>k__BackingField;

		// Token: 0x04000ECB RID: 3787
		[CompilerGenerated]
		private string <ToolTipText>k__BackingField;
	}
}
