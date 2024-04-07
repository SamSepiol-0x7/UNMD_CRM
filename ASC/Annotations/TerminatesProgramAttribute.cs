using System;

namespace ASC.Annotations
{
	// Token: 0x020000FB RID: 251
	[Obsolete("Use [ContractAnnotation('=> halt')] instead")]
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class TerminatesProgramAttribute : Attribute
	{
		// Token: 0x0600140B RID: 5131 RVA: 0x0002B780 File Offset: 0x00029980
		public TerminatesProgramAttribute()
		{
		}
	}
}
