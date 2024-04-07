using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x02000079 RID: 121
	public class store_types
	{
		// Token: 0x06000E6A RID: 3690 RVA: 0x0001AB2C File Offset: 0x00018D2C
		public store_types()
		{
			this.stores = new HashSet<stores>();
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06000E6B RID: 3691 RVA: 0x0001AB4C File Offset: 0x00018D4C
		// (set) Token: 0x06000E6C RID: 3692 RVA: 0x0001AB60 File Offset: 0x00018D60
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

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06000E6D RID: 3693 RVA: 0x0001AB74 File Offset: 0x00018D74
		// (set) Token: 0x06000E6E RID: 3694 RVA: 0x0001AB88 File Offset: 0x00018D88
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

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06000E6F RID: 3695 RVA: 0x0001AB9C File Offset: 0x00018D9C
		// (set) Token: 0x06000E70 RID: 3696 RVA: 0x0001ABB0 File Offset: 0x00018DB0
		public virtual ICollection<stores> stores
		{
			[CompilerGenerated]
			get
			{
				return this.<stores>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<stores>k__BackingField = value;
			}
		}

		// Token: 0x040006CE RID: 1742
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x040006CF RID: 1743
		[CompilerGenerated]
		private string <name>k__BackingField;

		// Token: 0x040006D0 RID: 1744
		[CompilerGenerated]
		private ICollection<stores> <stores>k__BackingField;
	}
}
