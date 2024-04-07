using System;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x02000091 RID: 145
	public class IdNamePair
	{
		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x0600123E RID: 4670 RVA: 0x00021EA4 File Offset: 0x000200A4
		// (set) Token: 0x0600123F RID: 4671 RVA: 0x00021EB8 File Offset: 0x000200B8
		public int id
		{
			[CompilerGenerated]
			get
			{
				return this.<id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<id>k__BackingField = value;
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06001240 RID: 4672 RVA: 0x00021ECC File Offset: 0x000200CC
		// (set) Token: 0x06001241 RID: 4673 RVA: 0x00021EE0 File Offset: 0x000200E0
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

		// Token: 0x06001242 RID: 4674 RVA: 0x000046B4 File Offset: 0x000028B4
		public IdNamePair()
		{
		}

		// Token: 0x0400089D RID: 2205
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x0400089E RID: 2206
		[CompilerGenerated]
		private string <name>k__BackingField;
	}
}
