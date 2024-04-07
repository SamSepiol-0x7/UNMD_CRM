using System;
using System.Runtime.CompilerServices;

namespace ASC.SimpleClasses
{
	// Token: 0x020001F9 RID: 505
	public class CategoryExpand
	{
		// Token: 0x06001B7D RID: 7037 RVA: 0x000046B4 File Offset: 0x000028B4
		public CategoryExpand()
		{
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x00051598 File Offset: 0x0004F798
		public CategoryExpand(int categoryId, bool isExpand)
		{
			this.CategoryId = categoryId;
			this.IsExpand = isExpand;
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06001B7F RID: 7039 RVA: 0x000515BC File Offset: 0x0004F7BC
		// (set) Token: 0x06001B80 RID: 7040 RVA: 0x000515D0 File Offset: 0x0004F7D0
		public int CategoryId
		{
			[CompilerGenerated]
			get
			{
				return this.<CategoryId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<CategoryId>k__BackingField = value;
			}
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x06001B81 RID: 7041 RVA: 0x000515E4 File Offset: 0x0004F7E4
		// (set) Token: 0x06001B82 RID: 7042 RVA: 0x000515F8 File Offset: 0x0004F7F8
		public bool IsExpand
		{
			[CompilerGenerated]
			get
			{
				return this.<IsExpand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<IsExpand>k__BackingField = value;
			}
		}

		// Token: 0x04000E78 RID: 3704
		[CompilerGenerated]
		private int <CategoryId>k__BackingField;

		// Token: 0x04000E79 RID: 3705
		[CompilerGenerated]
		private bool <IsExpand>k__BackingField;
	}
}
