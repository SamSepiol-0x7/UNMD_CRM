using System;
using System.Runtime.CompilerServices;

namespace ASC.Annotations
{
	// Token: 0x020000E5 RID: 229
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
	public sealed class AspMvcActionAttribute : Attribute
	{
		// Token: 0x060013E5 RID: 5093 RVA: 0x0002B780 File Offset: 0x00029980
		public AspMvcActionAttribute()
		{
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x0002BDDC File Offset: 0x00029FDC
		public AspMvcActionAttribute([NotNull] string anonymousProperty)
		{
			this.AnonymousProperty = anonymousProperty;
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x060013E7 RID: 5095 RVA: 0x0002BDF8 File Offset: 0x00029FF8
		// (set) Token: 0x060013E8 RID: 5096 RVA: 0x0002BE0C File Offset: 0x0002A00C
		[CanBeNull]
		public string AnonymousProperty
		{
			[CompilerGenerated]
			get
			{
				return this.<AnonymousProperty>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<AnonymousProperty>k__BackingField = value;
			}
		}

		// Token: 0x04000995 RID: 2453
		[CompilerGenerated]
		private string <AnonymousProperty>k__BackingField;
	}
}
