using System;
using System.Runtime.CompilerServices;

namespace ASC.Annotations
{
	// Token: 0x020000F3 RID: 243
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
	public sealed class HtmlElementAttributesAttribute : Attribute
	{
		// Token: 0x060013FC RID: 5116 RVA: 0x0002B780 File Offset: 0x00029980
		public HtmlElementAttributesAttribute()
		{
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x0002BEA8 File Offset: 0x0002A0A8
		public HtmlElementAttributesAttribute([NotNull] string name)
		{
			this.Name = name;
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x060013FE RID: 5118 RVA: 0x0002BEC4 File Offset: 0x0002A0C4
		// (set) Token: 0x060013FF RID: 5119 RVA: 0x0002BED8 File Offset: 0x0002A0D8
		[CanBeNull]
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

		// Token: 0x04000998 RID: 2456
		[CompilerGenerated]
		private string <Name>k__BackingField;
	}
}
