using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace ASC.ViewModels.Charts
{
	// Token: 0x02000503 RID: 1283
	public class LookupColumn : Column
	{
		// Token: 0x0600308F RID: 12431 RVA: 0x000A0254 File Offset: 0x0009E454
		public LookupColumn(SettingsType settings, string fieldName, IList source) : base(settings, fieldName)
		{
			this.Source = source;
		}

		// Token: 0x17000F0D RID: 3853
		// (get) Token: 0x06003090 RID: 12432 RVA: 0x000A0270 File Offset: 0x0009E470
		public IList Source
		{
			[CompilerGenerated]
			get
			{
				return this.<Source>k__BackingField;
			}
		}

		// Token: 0x04001BAA RID: 7082
		[CompilerGenerated]
		private readonly IList <Source>k__BackingField;
	}
}
