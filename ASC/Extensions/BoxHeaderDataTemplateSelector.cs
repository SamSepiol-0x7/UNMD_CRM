using System;
using System.Windows;
using System.Windows.Controls;
using ASC.Objects;
using DevExpress.Xpf.Grid;

namespace ASC.Extensions
{
	// Token: 0x02000B5B RID: 2907
	internal class BoxHeaderDataTemplateSelector : DataTemplateSelector
	{
		// Token: 0x06005165 RID: 20837 RVA: 0x0015E304 File Offset: 0x0015C504
		public override DataTemplate SelectTemplate(object item, DependencyObject container)
		{
			FrameworkElement frameworkElement = container as FrameworkElement;
			if (frameworkElement != null)
			{
				CardHeaderData cardHeaderData = item as CardHeaderData;
				if (cardHeaderData != null)
				{
					if (cardHeaderData.RowData.Row is WorkshopBox)
					{
						return frameworkElement.FindResource("BoxWorkshopHeaderTemplate") as DataTemplate;
					}
					return frameworkElement.FindResource("BoxStoreHeaderTemplate") as DataTemplate;
				}
			}
			return null;
		}

		// Token: 0x06005166 RID: 20838 RVA: 0x0009F64C File Offset: 0x0009D84C
		public BoxHeaderDataTemplateSelector()
		{
		}
	}
}
