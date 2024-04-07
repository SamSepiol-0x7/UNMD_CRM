using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x02000048 RID: 72
	public class items_state
	{
		// Token: 0x060006DC RID: 1756 RVA: 0x0000F404 File Offset: 0x0000D604
		public items_state()
		{
			this.store_items = new HashSet<store_items>();
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x0000F424 File Offset: 0x0000D624
		// (set) Token: 0x060006DE RID: 1758 RVA: 0x0000F438 File Offset: 0x0000D638
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

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x060006DF RID: 1759 RVA: 0x0000F44C File Offset: 0x0000D64C
		// (set) Token: 0x060006E0 RID: 1760 RVA: 0x0000F460 File Offset: 0x0000D660
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

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x0000F474 File Offset: 0x0000D674
		// (set) Token: 0x060006E2 RID: 1762 RVA: 0x0000F488 File Offset: 0x0000D688
		public virtual ICollection<store_items> store_items
		{
			[CompilerGenerated]
			get
			{
				return this.<store_items>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<store_items>k__BackingField = value;
			}
		}

		// Token: 0x04000347 RID: 839
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x04000348 RID: 840
		[CompilerGenerated]
		private string <name>k__BackingField;

		// Token: 0x04000349 RID: 841
		[CompilerGenerated]
		private ICollection<store_items> <store_items>k__BackingField;
	}
}
