using System;
using System.Runtime.CompilerServices;
using DevExpress.Data;

namespace ASC.ViewModels.Charts
{
	// Token: 0x02000505 RID: 1285
	public class Summary
	{
		// Token: 0x17000F0F RID: 3855
		// (get) Token: 0x06003093 RID: 12435 RVA: 0x000A02B4 File Offset: 0x0009E4B4
		// (set) Token: 0x06003094 RID: 12436 RVA: 0x000A02C8 File Offset: 0x0009E4C8
		public SummaryItemType Type
		{
			[CompilerGenerated]
			get
			{
				return this.<Type>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Type>k__BackingField = value;
			}
		}

		// Token: 0x17000F10 RID: 3856
		// (get) Token: 0x06003095 RID: 12437 RVA: 0x000A02DC File Offset: 0x0009E4DC
		// (set) Token: 0x06003096 RID: 12438 RVA: 0x000A02F0 File Offset: 0x0009E4F0
		public string FieldName
		{
			[CompilerGenerated]
			get
			{
				return this.<FieldName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<FieldName>k__BackingField = value;
			}
		}

		// Token: 0x06003097 RID: 12439 RVA: 0x000046B4 File Offset: 0x000028B4
		public Summary()
		{
		}

		// Token: 0x04001BAC RID: 7084
		[CompilerGenerated]
		private SummaryItemType <Type>k__BackingField;

		// Token: 0x04001BAD RID: 7085
		[CompilerGenerated]
		private string <FieldName>k__BackingField;
	}
}
