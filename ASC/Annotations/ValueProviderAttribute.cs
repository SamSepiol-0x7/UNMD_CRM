using System;
using System.Runtime.CompilerServices;

namespace ASC.Annotations
{
	// Token: 0x020000CC RID: 204
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
	public sealed class ValueProviderAttribute : Attribute
	{
		// Token: 0x06001396 RID: 5014 RVA: 0x0002B7D8 File Offset: 0x000299D8
		public ValueProviderAttribute([NotNull] string name)
		{
			this.Name = name;
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06001397 RID: 5015 RVA: 0x0002B7F4 File Offset: 0x000299F4
		// (set) Token: 0x06001398 RID: 5016 RVA: 0x0002B808 File Offset: 0x00029A08
		[NotNull]
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.<Name>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x04000974 RID: 2420
		[CompilerGenerated]
		private string <Name>k__BackingField;
	}
}
