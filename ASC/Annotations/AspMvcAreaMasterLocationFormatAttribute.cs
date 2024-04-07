using System;
using System.Runtime.CompilerServices;

namespace ASC.Annotations
{
	// Token: 0x020000DF RID: 223
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public sealed class AspMvcAreaMasterLocationFormatAttribute : Attribute
	{
		// Token: 0x060013D3 RID: 5075 RVA: 0x0002BC44 File Offset: 0x00029E44
		public AspMvcAreaMasterLocationFormatAttribute([NotNull] string format)
		{
			this.Format = format;
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x060013D4 RID: 5076 RVA: 0x0002BC60 File Offset: 0x00029E60
		// (set) Token: 0x060013D5 RID: 5077 RVA: 0x0002BC74 File Offset: 0x00029E74
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

		// Token: 0x0400098F RID: 2447
		[CompilerGenerated]
		private string <Format>k__BackingField;
	}
}
