using System;

namespace ASC.Annotations
{
	// Token: 0x020000DB RID: 219
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.GenericParameter)]
	public sealed class ProvidesContextAttribute : Attribute
	{
		// Token: 0x060013C6 RID: 5062 RVA: 0x0002B780 File Offset: 0x00029980
		public ProvidesContextAttribute()
		{
		}
	}
}
