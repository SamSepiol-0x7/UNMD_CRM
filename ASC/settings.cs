using System;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x0200001B RID: 27
	public class settings
	{
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00004BC8 File Offset: 0x00002DC8
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x00004BDC File Offset: 0x00002DDC
		public string name
		{
			[CompilerGenerated]
			get
			{
				return this.<name>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<name>k__BackingField = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00004BF0 File Offset: 0x00002DF0
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x00004C04 File Offset: 0x00002E04
		public string value
		{
			[CompilerGenerated]
			get
			{
				return this.<value>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<value>k__BackingField = value;
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000046B4 File Offset: 0x000028B4
		public settings()
		{
		}

		// Token: 0x04000051 RID: 81
		[CompilerGenerated]
		private string <name>k__BackingField;

		// Token: 0x04000052 RID: 82
		[CompilerGenerated]
		private string <value>k__BackingField;
	}
}
