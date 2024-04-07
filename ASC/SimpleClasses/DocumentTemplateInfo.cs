using System;
using System.Runtime.CompilerServices;

namespace ASC.SimpleClasses
{
	// Token: 0x020001FB RID: 507
	public class DocumentTemplateInfo
	{
		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06001B8D RID: 7053 RVA: 0x000516D0 File Offset: 0x0004F8D0
		// (set) Token: 0x06001B8E RID: 7054 RVA: 0x000516E4 File Offset: 0x0004F8E4
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

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06001B8F RID: 7055 RVA: 0x000516F8 File Offset: 0x0004F8F8
		// (set) Token: 0x06001B90 RID: 7056 RVA: 0x0005170C File Offset: 0x0004F90C
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

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06001B91 RID: 7057 RVA: 0x00051720 File Offset: 0x0004F920
		// (set) Token: 0x06001B92 RID: 7058 RVA: 0x00051734 File Offset: 0x0004F934
		public string Description
		{
			[CompilerGenerated]
			get
			{
				return this.<Description>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Description>k__BackingField = value;
			}
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x000046B4 File Offset: 0x000028B4
		public DocumentTemplateInfo()
		{
		}

		// Token: 0x04000E7E RID: 3710
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04000E7F RID: 3711
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04000E80 RID: 3712
		[CompilerGenerated]
		private string <Description>k__BackingField;
	}
}
