using System;
using System.Runtime.CompilerServices;

namespace ASC.Annotations
{
	// Token: 0x020000E0 RID: 224
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public sealed class AspMvcAreaPartialViewLocationFormatAttribute : Attribute
	{
		// Token: 0x060013D6 RID: 5078 RVA: 0x0002BC88 File Offset: 0x00029E88
		public AspMvcAreaPartialViewLocationFormatAttribute([NotNull] string format)
		{
			this.Format = format;
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x060013D7 RID: 5079 RVA: 0x0002BCA4 File Offset: 0x00029EA4
		// (set) Token: 0x060013D8 RID: 5080 RVA: 0x0002BCB8 File Offset: 0x00029EB8
		[NotNull]
		public string Format
		{
			[CompilerGenerated]
			get
			{
				return this.<Format>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Format>k__BackingField = value;
			}
		}

		// Token: 0x04000990 RID: 2448
		[CompilerGenerated]
		private string <Format>k__BackingField;
	}
}
