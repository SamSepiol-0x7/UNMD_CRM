using System;

namespace ASC.Annotations
{
	// Token: 0x020000C7 RID: 199
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.GenericParameter)]
	public sealed class NotNullAttribute : Attribute
	{
		// Token: 0x0600138F RID: 5007 RVA: 0x0002B780 File Offset: 0x00029980
		public NotNullAttribute()
		{
		}
	}
}
