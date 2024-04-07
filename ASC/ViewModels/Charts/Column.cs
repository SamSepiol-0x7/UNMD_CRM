using System;
using System.Runtime.CompilerServices;
using DevExpress.Mvvm;

namespace ASC.ViewModels.Charts
{
	// Token: 0x02000502 RID: 1282
	public class Column : BindableBase
	{
		// Token: 0x0600308C RID: 12428 RVA: 0x000A0208 File Offset: 0x0009E408
		public Column(SettingsType settings, string fieldName)
		{
			this.Settings = settings;
			this.FieldName = fieldName;
		}

		// Token: 0x17000F0B RID: 3851
		// (get) Token: 0x0600308D RID: 12429 RVA: 0x000A022C File Offset: 0x0009E42C
		public SettingsType Settings
		{
			[CompilerGenerated]
			get
			{
				return this.<Settings>k__BackingField;
			}
		}

		// Token: 0x17000F0C RID: 3852
		// (get) Token: 0x0600308E RID: 12430 RVA: 0x000A0240 File Offset: 0x0009E440
		public string FieldName
		{
			[CompilerGenerated]
			get
			{
				return this.<FieldName>k__BackingField;
			}
		}

		// Token: 0x04001BA8 RID: 7080
		[CompilerGenerated]
		private readonly SettingsType <Settings>k__BackingField;

		// Token: 0x04001BA9 RID: 7081
		[CompilerGenerated]
		private readonly string <FieldName>k__BackingField;
	}
}
