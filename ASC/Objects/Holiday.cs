using System;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;

namespace ASC.Objects
{
	// Token: 0x020008D6 RID: 2262
	public class Holiday : IHoliday
	{
		// Token: 0x17001348 RID: 4936
		// (get) Token: 0x060045C7 RID: 17863 RVA: 0x0011119C File Offset: 0x0010F39C
		// (set) Token: 0x060045C8 RID: 17864 RVA: 0x001111B0 File Offset: 0x0010F3B0
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

		// Token: 0x17001349 RID: 4937
		// (get) Token: 0x060045C9 RID: 17865 RVA: 0x001111C4 File Offset: 0x0010F3C4
		// (set) Token: 0x060045CA RID: 17866 RVA: 0x001111D8 File Offset: 0x0010F3D8
		public DateTime Date
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

		// Token: 0x060045CB RID: 17867 RVA: 0x000046B4 File Offset: 0x000028B4
		public Holiday()
		{
		}

		// Token: 0x04002CE1 RID: 11489
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04002CE2 RID: 11490
		[CompilerGenerated]
		private DateTime <Date>k__BackingField;
	}
}
