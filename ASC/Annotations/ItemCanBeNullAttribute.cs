using System;

namespace ASC.Annotations
{
	// Token: 0x020000C9 RID: 201
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Delegate)]
	public sealed class ItemCanBeNullAttribute : Attribute
	{
		// Token: 0x06001391 RID: 5009 RVA: 0x0002B780 File Offset: 0x00029980
		public ItemCanBeNullAttribute()
		{
		}
	}
}
