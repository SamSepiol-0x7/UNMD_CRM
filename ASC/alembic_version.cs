using System;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x02000027 RID: 39
	public class alembic_version
	{
		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00006C80 File Offset: 0x00004E80
		// (set) Token: 0x06000180 RID: 384 RVA: 0x00006C94 File Offset: 0x00004E94
		public string version_num
		{
			[CompilerGenerated]
			get
			{
				return this.<version_num>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<version_num>k__BackingField = value;
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000046B4 File Offset: 0x000028B4
		public alembic_version()
		{
		}

		// Token: 0x040000B0 RID: 176
		[CompilerGenerated]
		private string <version_num>k__BackingField;
	}
}
