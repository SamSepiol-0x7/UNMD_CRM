using System;

namespace ASC.Annotations
{
	// Token: 0x020000F7 RID: 247
	[Flags]
	public enum CollectionAccessType
	{
		// Token: 0x0400099C RID: 2460
		None = 0,
		// Token: 0x0400099D RID: 2461
		Read = 1,
		// Token: 0x0400099E RID: 2462
		ModifyExistingContent = 2,
		// Token: 0x0400099F RID: 2463
		UpdatedContent = 6
	}
}
