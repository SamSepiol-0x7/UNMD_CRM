using System;
using System.Runtime.CompilerServices;

namespace ASC.Annotations
{
	// Token: 0x020000D7 RID: 215
	[MeansImplicitUse(ImplicitUseTargetFlags.WithMembers)]
	public sealed class PublicAPIAttribute : Attribute
	{
		// Token: 0x060013BC RID: 5052 RVA: 0x0002B780 File Offset: 0x00029980
		public PublicAPIAttribute()
		{
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x0002BB00 File Offset: 0x00029D00
		public PublicAPIAttribute([NotNull] string comment)
		{
			this.Comment = comment;
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x060013BE RID: 5054 RVA: 0x0002BB1C File Offset: 0x00029D1C
		// (set) Token: 0x060013BF RID: 5055 RVA: 0x0002BB30 File Offset: 0x00029D30
		[CanBeNull]
		public string Comment
		{
			[CompilerGenerated]
			get
			{
				return this.<Comment>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Comment>k__BackingField = value;
			}
		}

		// Token: 0x04000989 RID: 2441
		[CompilerGenerated]
		private string <Comment>k__BackingField;
	}
}
