using System;
using System.Runtime.CompilerServices;

namespace ASC.Annotations
{
	// Token: 0x020000E3 RID: 227
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public sealed class AspMvcPartialViewLocationFormatAttribute : Attribute
	{
		// Token: 0x060013DF RID: 5087 RVA: 0x0002BD54 File Offset: 0x00029F54
		public AspMvcPartialViewLocationFormatAttribute([NotNull] string format)
		{
			this.Format = format;
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x060013E0 RID: 5088 RVA: 0x0002BD70 File Offset: 0x00029F70
		// (set) Token: 0x060013E1 RID: 5089 RVA: 0x0002BD84 File Offset: 0x00029F84
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

		// Token: 0x04000993 RID: 2451
		[CompilerGenerated]
		private string <Format>k__BackingField;
	}
}
