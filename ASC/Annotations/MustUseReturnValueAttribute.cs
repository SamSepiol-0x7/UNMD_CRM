using System;
using System.Runtime.CompilerServices;

namespace ASC.Annotations
{
	// Token: 0x020000DA RID: 218
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class MustUseReturnValueAttribute : Attribute
	{
		// Token: 0x060013C2 RID: 5058 RVA: 0x0002B780 File Offset: 0x00029980
		public MustUseReturnValueAttribute()
		{
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x0002BB44 File Offset: 0x00029D44
		public MustUseReturnValueAttribute([NotNull] string justification)
		{
			this.Justification = justification;
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x060013C4 RID: 5060 RVA: 0x0002BB60 File Offset: 0x00029D60
		// (set) Token: 0x060013C5 RID: 5061 RVA: 0x0002BB74 File Offset: 0x00029D74
		[CanBeNull]
		public string Justification
		{
			[CompilerGenerated]
			get
			{
				return this.<Justification>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Justification>k__BackingField = value;
			}
		}

		// Token: 0x0400098A RID: 2442
		[CompilerGenerated]
		private string <Justification>k__BackingField;
	}
}
