using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x02000059 RID: 89
	public class permissions
	{
		// Token: 0x060008BF RID: 2239 RVA: 0x0001217C File Offset: 0x0001037C
		public permissions()
		{
			this.permissions_roles = new HashSet<permissions_roles>();
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x0001219C File Offset: 0x0001039C
		// (set) Token: 0x060008C1 RID: 2241 RVA: 0x000121B0 File Offset: 0x000103B0
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

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x060008C2 RID: 2242 RVA: 0x000121C4 File Offset: 0x000103C4
		// (set) Token: 0x060008C3 RID: 2243 RVA: 0x000121D8 File Offset: 0x000103D8
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

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x060008C4 RID: 2244 RVA: 0x000121EC File Offset: 0x000103EC
		// (set) Token: 0x060008C5 RID: 2245 RVA: 0x00012200 File Offset: 0x00010400
		public virtual ICollection<permissions_roles> permissions_roles
		{
			[CompilerGenerated]
			get
			{
				return this.<permissions_roles>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<permissions_roles>k__BackingField = value;
			}
		}

		// Token: 0x04000425 RID: 1061
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x04000426 RID: 1062
		[CompilerGenerated]
		private string <name>k__BackingField;

		// Token: 0x04000427 RID: 1063
		[CompilerGenerated]
		private ICollection<permissions_roles> <permissions_roles>k__BackingField;
	}
}
