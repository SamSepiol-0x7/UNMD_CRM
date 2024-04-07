using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x02000078 RID: 120
	public class store_sub_types
	{
		// Token: 0x06000E5F RID: 3679 RVA: 0x0001AA38 File Offset: 0x00018C38
		public store_sub_types()
		{
			this.stores = new HashSet<stores>();
			this.store_fields = new HashSet<store_fields>();
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06000E60 RID: 3680 RVA: 0x0001AA64 File Offset: 0x00018C64
		// (set) Token: 0x06000E61 RID: 3681 RVA: 0x0001AA78 File Offset: 0x00018C78
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

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06000E62 RID: 3682 RVA: 0x0001AA8C File Offset: 0x00018C8C
		// (set) Token: 0x06000E63 RID: 3683 RVA: 0x0001AAA0 File Offset: 0x00018CA0
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

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06000E64 RID: 3684 RVA: 0x0001AAB4 File Offset: 0x00018CB4
		// (set) Token: 0x06000E65 RID: 3685 RVA: 0x0001AAC8 File Offset: 0x00018CC8
		public bool? enable
		{
			[CompilerGenerated]
			get
			{
				return this.<enable>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<enable>k__BackingField = value;
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06000E66 RID: 3686 RVA: 0x0001AADC File Offset: 0x00018CDC
		// (set) Token: 0x06000E67 RID: 3687 RVA: 0x0001AAF0 File Offset: 0x00018CF0
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

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06000E68 RID: 3688 RVA: 0x0001AB04 File Offset: 0x00018D04
		// (set) Token: 0x06000E69 RID: 3689 RVA: 0x0001AB18 File Offset: 0x00018D18
		public virtual ICollection<store_fields> store_fields
		{
			[CompilerGenerated]
			get
			{
				return this.<store_fields>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<store_fields>k__BackingField = value;
			}
		}

		// Token: 0x040006C9 RID: 1737
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x040006CA RID: 1738
		[CompilerGenerated]
		private string <name>k__BackingField;

		// Token: 0x040006CB RID: 1739
		[CompilerGenerated]
		private bool? <enable>k__BackingField;

		// Token: 0x040006CC RID: 1740
		[CompilerGenerated]
		private ICollection<stores> <stores>k__BackingField;

		// Token: 0x040006CD RID: 1741
		[CompilerGenerated]
		private ICollection<store_fields> <store_fields>k__BackingField;
	}
}
