using System;
using System.Runtime.CompilerServices;

namespace ASC.Annotations
{
	// Token: 0x020000E4 RID: 228
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public sealed class AspMvcViewLocationFormatAttribute : Attribute
	{
		// Token: 0x060013E2 RID: 5090 RVA: 0x0002BD98 File Offset: 0x00029F98
		public AspMvcViewLocationFormatAttribute([NotNull] string format)
		{
			this.Format = format;
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x060013E3 RID: 5091 RVA: 0x0002BDB4 File Offset: 0x00029FB4
		// (set) Token: 0x060013E4 RID: 5092 RVA: 0x0002BDC8 File Offset: 0x00029FC8
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

		// Token: 0x04000994 RID: 2452
		[CompilerGenerated]
		private string <Format>k__BackingField;
	}
}
