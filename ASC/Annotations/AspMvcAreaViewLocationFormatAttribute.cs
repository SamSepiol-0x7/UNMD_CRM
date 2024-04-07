using System;
using System.Runtime.CompilerServices;

namespace ASC.Annotations
{
	// Token: 0x020000E1 RID: 225
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public sealed class AspMvcAreaViewLocationFormatAttribute : Attribute
	{
		// Token: 0x060013D9 RID: 5081 RVA: 0x0002BCCC File Offset: 0x00029ECC
		public AspMvcAreaViewLocationFormatAttribute([NotNull] string format)
		{
			this.Format = format;
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x060013DA RID: 5082 RVA: 0x0002BCE8 File Offset: 0x00029EE8
		// (set) Token: 0x060013DB RID: 5083 RVA: 0x0002BCFC File Offset: 0x00029EFC
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

		// Token: 0x04000991 RID: 2449
		[CompilerGenerated]
		private string <Format>k__BackingField;
	}
}
