using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace ASC.ViewModels.Charts
{
	// Token: 0x020004FA RID: 1274
	public class ColumnTemplateSelector : DataTemplateSelector
	{
		// Token: 0x17000EFB RID: 3835
		// (get) Token: 0x06003056 RID: 12374 RVA: 0x0009F58C File Offset: 0x0009D78C
		// (set) Token: 0x06003057 RID: 12375 RVA: 0x0009F5A0 File Offset: 0x0009D7A0
		public DataTemplate DefaultColumnTemplate
		{
			[CompilerGenerated]
			get
			{
				return this.<DefaultColumnTemplate>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<DefaultColumnTemplate>k__BackingField = value;
			}
		}

		// Token: 0x17000EFC RID: 3836
		// (get) Token: 0x06003058 RID: 12376 RVA: 0x0009F5B4 File Offset: 0x0009D7B4
		// (set) Token: 0x06003059 RID: 12377 RVA: 0x0009F5C8 File Offset: 0x0009D7C8
		public DataTemplate LookupColumnTemplate
		{
			[CompilerGenerated]
			get
			{
				return this.<LookupColumnTemplate>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<LookupColumnTemplate>k__BackingField = value;
			}
		}

		// Token: 0x17000EFD RID: 3837
		// (get) Token: 0x0600305A RID: 12378 RVA: 0x0009F5DC File Offset: 0x0009D7DC
		// (set) Token: 0x0600305B RID: 12379 RVA: 0x0009F5F0 File Offset: 0x0009D7F0
		public DataTemplate BindingColumnTemplate
		{
			[CompilerGenerated]
			get
			{
				return this.<BindingColumnTemplate>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<BindingColumnTemplate>k__BackingField = value;
			}
		}

		// Token: 0x0600305C RID: 12380 RVA: 0x0009F604 File Offset: 0x0009D804
		public override DataTemplate SelectTemplate(object item, DependencyObject container)
		{
			Column column = item as Column;
			if (column == null)
			{
				return null;
			}
			switch (column.Settings)
			{
			case SettingsType.Default:
				return this.DefaultColumnTemplate;
			case SettingsType.Lookup:
				return this.LookupColumnTemplate;
			case SettingsType.Binding:
				return this.BindingColumnTemplate;
			default:
				return null;
			}
		}

		// Token: 0x0600305D RID: 12381 RVA: 0x0009F64C File Offset: 0x0009D84C
		public ColumnTemplateSelector()
		{
		}

		// Token: 0x04001B80 RID: 7040
		[CompilerGenerated]
		private DataTemplate <DefaultColumnTemplate>k__BackingField;

		// Token: 0x04001B81 RID: 7041
		[CompilerGenerated]
		private DataTemplate <LookupColumnTemplate>k__BackingField;

		// Token: 0x04001B82 RID: 7042
		[CompilerGenerated]
		private DataTemplate <BindingColumnTemplate>k__BackingField;
	}
}
