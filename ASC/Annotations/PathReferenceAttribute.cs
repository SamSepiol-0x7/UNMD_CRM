using System;
using System.Runtime.CompilerServices;

namespace ASC.Annotations
{
	// Token: 0x020000DC RID: 220
	[AttributeUsage(AttributeTargets.Parameter)]
	public sealed class PathReferenceAttribute : Attribute
	{
		// Token: 0x060013C7 RID: 5063 RVA: 0x0002B780 File Offset: 0x00029980
		public PathReferenceAttribute()
		{
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x0002BB88 File Offset: 0x00029D88
		public PathReferenceAttribute([NotNull] [PathReference] string basePath)
		{
			this.BasePath = basePath;
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x060013C9 RID: 5065 RVA: 0x0002BBA4 File Offset: 0x00029DA4
		// (set) Token: 0x060013CA RID: 5066 RVA: 0x0002BBB8 File Offset: 0x00029DB8
		[CanBeNull]
		public string BasePath
		{
			[CompilerGenerated]
			get
			{
				return this.<BasePath>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<BasePath>k__BackingField = value;
			}
		}

		// Token: 0x0400098B RID: 2443
		[CompilerGenerated]
		private string <BasePath>k__BackingField;
	}
}
