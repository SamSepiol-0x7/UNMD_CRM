using System;
using System.Runtime.CompilerServices;

namespace ASC.Annotations
{
	// Token: 0x020000E7 RID: 231
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
	public sealed class AspMvcControllerAttribute : Attribute
	{
		// Token: 0x060013ED RID: 5101 RVA: 0x0002B780 File Offset: 0x00029980
		public AspMvcControllerAttribute()
		{
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x0002BE64 File Offset: 0x0002A064
		public AspMvcControllerAttribute([NotNull] string anonymousProperty)
		{
			this.AnonymousProperty = anonymousProperty;
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x060013EF RID: 5103 RVA: 0x0002BE80 File Offset: 0x0002A080
		// (set) Token: 0x060013F0 RID: 5104 RVA: 0x0002BE94 File Offset: 0x0002A094
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

		// Token: 0x04000997 RID: 2455
		[CompilerGenerated]
		private string <AnonymousProperty>k__BackingField;
	}
}
