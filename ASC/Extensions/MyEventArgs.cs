using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC.Extensions
{
	// Token: 0x02000B66 RID: 2918
	public class MyEventArgs : EventArgs
	{
		// Token: 0x170014FA RID: 5370
		// (get) Token: 0x060051AD RID: 20909 RVA: 0x0015F1B4 File Offset: 0x0015D3B4
		// (set) Token: 0x060051AE RID: 20910 RVA: 0x0015F1C8 File Offset: 0x0015D3C8
		public List<LayoutChangedType> LayoutChangedTypes
		{
			[CompilerGenerated]
			get
			{
				return this.<LayoutChangedTypes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<LayoutChangedTypes>k__BackingField = value;
			}
		}

		// Token: 0x060051AF RID: 20911 RVA: 0x0005D324 File Offset: 0x0005B524
		public MyEventArgs()
		{
		}

		// Token: 0x040035AA RID: 13738
		[CompilerGenerated]
		private List<LayoutChangedType> <LayoutChangedTypes>k__BackingField;
	}
}
