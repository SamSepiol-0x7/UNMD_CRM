using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC.Options
{
	// Token: 0x0200024D RID: 589
	public class KkmProtocolOptions
	{
		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x0600206E RID: 8302 RVA: 0x0005D4E8 File Offset: 0x0005B6E8
		// (set) Token: 0x0600206F RID: 8303 RVA: 0x0005D4FC File Offset: 0x0005B6FC
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

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x06002070 RID: 8304 RVA: 0x0005D510 File Offset: 0x0005B710
		// (set) Token: 0x06002071 RID: 8305 RVA: 0x0005D524 File Offset: 0x0005B724
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

		// Token: 0x06002072 RID: 8306 RVA: 0x000046B4 File Offset: 0x000028B4
		public KkmProtocolOptions()
		{
		}

		// Token: 0x06002073 RID: 8307 RVA: 0x0005D538 File Offset: 0x0005B738
		public KkmProtocolOptions(int id, string name)
		{
			this.Id = id;
			this.Name = name;
		}

		// Token: 0x06002074 RID: 8308 RVA: 0x0005D55C File Offset: 0x0005B75C
		public List<KkmProtocolOptions> GetAllOptions()
		{
			return new List<KkmProtocolOptions>
			{
				new KkmProtocolOptions(0, "ШТРИХ-М"),
				new KkmProtocolOptions(1, "АТОЛ")
			};
		}

		// Token: 0x0400109E RID: 4254
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x0400109F RID: 4255
		[CompilerGenerated]
		private string <Name>k__BackingField;
	}
}
