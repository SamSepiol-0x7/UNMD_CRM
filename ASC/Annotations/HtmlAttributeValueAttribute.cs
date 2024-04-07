using System;
using System.Runtime.CompilerServices;

namespace ASC.Annotations
{
	// Token: 0x020000F4 RID: 244
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
	public sealed class HtmlAttributeValueAttribute : Attribute
	{
		// Token: 0x06001400 RID: 5120 RVA: 0x0002BEEC File Offset: 0x0002A0EC
		public HtmlAttributeValueAttribute([NotNull] string name)
		{
			this.Name = name;
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06001401 RID: 5121 RVA: 0x0002BF08 File Offset: 0x0002A108
		// (set) Token: 0x06001402 RID: 5122 RVA: 0x0002BF1C File Offset: 0x0002A11C
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

		// Token: 0x04000999 RID: 2457
		[CompilerGenerated]
		private string <Name>k__BackingField;
	}
}
