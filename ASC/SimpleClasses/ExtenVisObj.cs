using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC.SimpleClasses
{
	// Token: 0x020001FE RID: 510
	public class ExtenVisObj
	{
		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06001B9C RID: 7068 RVA: 0x00051A00 File Offset: 0x0004FC00
		// (set) Token: 0x06001B9D RID: 7069 RVA: 0x00051A14 File Offset: 0x0004FC14
		public int Priority
		{
			[CompilerGenerated]
			get
			{
				return this.<Priority>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Priority>k__BackingField = value;
			}
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06001B9E RID: 7070 RVA: 0x00051A28 File Offset: 0x0004FC28
		// (set) Token: 0x06001B9F RID: 7071 RVA: 0x00051A3C File Offset: 0x0004FC3C
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

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06001BA0 RID: 7072 RVA: 0x00051A50 File Offset: 0x0004FC50
		// (set) Token: 0x06001BA1 RID: 7073 RVA: 0x00051A64 File Offset: 0x0004FC64
		public string AdditionalInfo
		{
			[CompilerGenerated]
			get
			{
				return this.<AdditionalInfo>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<AdditionalInfo>k__BackingField = value;
			}
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06001BA2 RID: 7074 RVA: 0x00051A78 File Offset: 0x0004FC78
		// (set) Token: 0x06001BA3 RID: 7075 RVA: 0x00051A8C File Offset: 0x0004FC8C
		public List<ExtenVisObj> Children
		{
			[CompilerGenerated]
			get
			{
				return this.<Children>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Children>k__BackingField = value;
			}
		} = new List<ExtenVisObj>();

		// Token: 0x06001BA4 RID: 7076 RVA: 0x00051AA0 File Offset: 0x0004FCA0
		public ExtenVisObj()
		{
		}

		// Token: 0x04000E90 RID: 3728
		[CompilerGenerated]
		private int <Priority>k__BackingField;

		// Token: 0x04000E91 RID: 3729
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04000E92 RID: 3730
		[CompilerGenerated]
		private string <AdditionalInfo>k__BackingField;

		// Token: 0x04000E93 RID: 3731
		[CompilerGenerated]
		private List<ExtenVisObj> <Children>k__BackingField;
	}
}
