using System;
using System.Runtime.CompilerServices;

namespace ASC.Annotations
{
	// Token: 0x020000E6 RID: 230
	[AttributeUsage(AttributeTargets.Parameter)]
	public sealed class AspMvcAreaAttribute : Attribute
	{
		// Token: 0x060013E9 RID: 5097 RVA: 0x0002B780 File Offset: 0x00029980
		public AspMvcAreaAttribute()
		{
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x0002BE20 File Offset: 0x0002A020
		public AspMvcAreaAttribute([NotNull] string anonymousProperty)
		{
			this.AnonymousProperty = anonymousProperty;
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x060013EB RID: 5099 RVA: 0x0002BE3C File Offset: 0x0002A03C
		// (set) Token: 0x060013EC RID: 5100 RVA: 0x0002BE50 File Offset: 0x0002A050
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

		// Token: 0x04000996 RID: 2454
		[CompilerGenerated]
		private string <AnonymousProperty>k__BackingField;
	}
}
