using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC.SimpleClasses
{
	// Token: 0x02000216 RID: 534
	public class Statuses
	{
		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x06001C47 RID: 7239 RVA: 0x000530B4 File Offset: 0x000512B4
		// (set) Token: 0x06001C48 RID: 7240 RVA: 0x000530C8 File Offset: 0x000512C8
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

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x06001C49 RID: 7241 RVA: 0x000530DC File Offset: 0x000512DC
		// (set) Token: 0x06001C4A RID: 7242 RVA: 0x000530F0 File Offset: 0x000512F0
		public List<int> Contains
		{
			[CompilerGenerated]
			get
			{
				return this.<Contains>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Contains>k__BackingField = value;
			}
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x000046B4 File Offset: 0x000028B4
		public Statuses()
		{
		}

		// Token: 0x04000EE5 RID: 3813
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04000EE6 RID: 3814
		[CompilerGenerated]
		private List<int> <Contains>k__BackingField;
	}
}
