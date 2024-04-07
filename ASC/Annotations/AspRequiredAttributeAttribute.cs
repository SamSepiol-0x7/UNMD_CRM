using System;
using System.Runtime.CompilerServices;

namespace ASC.Annotations
{
	// Token: 0x02000105 RID: 261
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public sealed class AspRequiredAttributeAttribute : Attribute
	{
		// Token: 0x06001419 RID: 5145 RVA: 0x0002C02C File Offset: 0x0002A22C
		public AspRequiredAttributeAttribute([NotNull] string attribute)
		{
			this.Attribute = attribute;
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x0600141A RID: 5146 RVA: 0x0002C048 File Offset: 0x0002A248
		// (set) Token: 0x0600141B RID: 5147 RVA: 0x0002C05C File Offset: 0x0002A25C
		[NotNull]
		public string Attribute
		{
			[CompilerGenerated]
			get
			{
				return this.<Attribute>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Attribute>k__BackingField = value;
			}
		}

		// Token: 0x040009A8 RID: 2472
		[CompilerGenerated]
		private string <Attribute>k__BackingField;
	}
}
