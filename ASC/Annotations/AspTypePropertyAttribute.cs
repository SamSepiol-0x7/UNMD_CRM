using System;
using System.Runtime.CompilerServices;

namespace ASC.Annotations
{
	// Token: 0x02000106 RID: 262
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class AspTypePropertyAttribute : Attribute
	{
		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x0600141C RID: 5148 RVA: 0x0002C070 File Offset: 0x0002A270
		// (set) Token: 0x0600141D RID: 5149 RVA: 0x0002C084 File Offset: 0x0002A284
		public bool CreateConstructorReferences
		{
			[CompilerGenerated]
			get
			{
				return this.<CreateConstructorReferences>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<CreateConstructorReferences>k__BackingField = value;
			}
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x0002C098 File Offset: 0x0002A298
		public AspTypePropertyAttribute(bool createConstructorReferences)
		{
			this.CreateConstructorReferences = createConstructorReferences;
		}

		// Token: 0x040009A9 RID: 2473
		[CompilerGenerated]
		private bool <CreateConstructorReferences>k__BackingField;
	}
}
