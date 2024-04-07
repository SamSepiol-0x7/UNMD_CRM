using System;

namespace ASC.Annotations
{
	// Token: 0x020000C8 RID: 200
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Delegate)]
	public sealed class ItemNotNullAttribute : Attribute
	{
		// Token: 0x06001390 RID: 5008 RVA: 0x0002B780 File Offset: 0x00029980
		public ItemNotNullAttribute()
		{
		}
	}
}
