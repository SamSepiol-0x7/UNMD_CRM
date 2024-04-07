using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC.SimpleClasses
{
	// Token: 0x0200020B RID: 523
	public class QueueDiagram
	{
		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06001BEC RID: 7148 RVA: 0x000523E0 File Offset: 0x000505E0
		// (set) Token: 0x06001BED RID: 7149 RVA: 0x000523F4 File Offset: 0x000505F4
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

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06001BEE RID: 7150 RVA: 0x00052408 File Offset: 0x00050608
		// (set) Token: 0x06001BEF RID: 7151 RVA: 0x0005241C File Offset: 0x0005061C
		public List<queue_members> Members
		{
			[CompilerGenerated]
			get
			{
				return this.<Members>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Members>k__BackingField = value;
			}
		} = new List<queue_members>();

		// Token: 0x06001BF0 RID: 7152 RVA: 0x00052430 File Offset: 0x00050630
		public QueueDiagram()
		{
		}

		// Token: 0x04000EB4 RID: 3764
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04000EB5 RID: 3765
		[CompilerGenerated]
		private List<queue_members> <Members>k__BackingField;
	}
}
