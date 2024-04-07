using System;
using System.Runtime.CompilerServices;

namespace ASC.ViewModels.Charts
{
	// Token: 0x02000504 RID: 1284
	public class BindingColumn : Column
	{
		// Token: 0x06003091 RID: 12433 RVA: 0x000A0284 File Offset: 0x0009E484
		public BindingColumn(SettingsType settings, string fieldName, string header) : base(settings, fieldName)
		{
			this.Header = header;
		}

		// Token: 0x17000F0E RID: 3854
		// (get) Token: 0x06003092 RID: 12434 RVA: 0x000A02A0 File Offset: 0x0009E4A0
		public string Header
		{
			[CompilerGenerated]
			get
			{
				return this.<Header>k__BackingField;
			}
		}

		// Token: 0x04001BAB RID: 7083
		[CompilerGenerated]
		private readonly string <Header>k__BackingField;
	}
}
