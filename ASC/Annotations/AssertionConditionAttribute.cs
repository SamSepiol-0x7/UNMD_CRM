using System;
using System.Runtime.CompilerServices;

namespace ASC.Annotations
{
	// Token: 0x020000F9 RID: 249
	[AttributeUsage(AttributeTargets.Parameter)]
	public sealed class AssertionConditionAttribute : Attribute
	{
		// Token: 0x06001408 RID: 5128 RVA: 0x0002BF74 File Offset: 0x0002A174
		public AssertionConditionAttribute(AssertionConditionType conditionType)
		{
			this.ConditionType = conditionType;
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06001409 RID: 5129 RVA: 0x0002BF90 File Offset: 0x0002A190
		// (set) Token: 0x0600140A RID: 5130 RVA: 0x0002BFA4 File Offset: 0x0002A1A4
		public AssertionConditionType ConditionType
		{
			[CompilerGenerated]
			get
			{
				return this.<ConditionType>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<ConditionType>k__BackingField = value;
			}
		}

		// Token: 0x040009A0 RID: 2464
		[CompilerGenerated]
		private AssertionConditionType <ConditionType>k__BackingField;
	}
}
