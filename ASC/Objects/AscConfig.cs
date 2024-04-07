using System;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;

namespace ASC.Objects
{
	// Token: 0x02000877 RID: 2167
	public class AscConfig : IAscConfig
	{
		// Token: 0x1700118B RID: 4491
		// (get) Token: 0x060040E4 RID: 16612 RVA: 0x001013C8 File Offset: 0x000FF5C8
		// (set) Token: 0x060040E5 RID: 16613 RVA: 0x001013DC File Offset: 0x000FF5DC
		public string CurrencyString
		{
			[CompilerGenerated]
			get
			{
				return this.<CurrencyString>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<CurrencyString>k__BackingField = value;
			}
		}

		// Token: 0x060040E6 RID: 16614 RVA: 0x000046B4 File Offset: 0x000028B4
		public AscConfig()
		{
		}

		// Token: 0x04002A58 RID: 10840
		[CompilerGenerated]
		private string <CurrencyString>k__BackingField;
	}
}
