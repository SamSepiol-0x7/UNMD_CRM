using System;

namespace ASC.Annotations
{
	// Token: 0x020000C6 RID: 198
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.GenericParameter)]
	public sealed class CanBeNullAttribute : Attribute
	{
		// Token: 0x0600138E RID: 5006 RVA: 0x0002B780 File Offset: 0x00029980
		public CanBeNullAttribute()
		{
		}
	}
}
