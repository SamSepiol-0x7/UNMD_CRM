using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace ASC.Converters
{
	// Token: 0x02000BD9 RID: 3033
	public class custConverter : MarkupExtension, IValueConverter
	{
		// Token: 0x06005497 RID: 21655 RVA: 0x0016BDEC File Offset: 0x00169FEC
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is ObservableCollection<permissions>)
			{
				return new List<object>(value as ObservableCollection<permissions>);
			}
			return value;
		}

		// Token: 0x06005498 RID: 21656 RVA: 0x0016BE10 File Offset: 0x0016A010
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is List<object>)
			{
				List<object> list = value as List<object>;
				ObservableCollection<permissions> observableCollection = new ObservableCollection<permissions>();
				foreach (object obj in list)
				{
					observableCollection.Add(obj as permissions);
				}
				return observableCollection;
			}
			return value;
		}

		// Token: 0x06005499 RID: 21657 RVA: 0x0016BE7C File Offset: 0x0016A07C
		public override object ProvideValue(IServiceProvider serviceProvider)
		{
			return this;
		}

		// Token: 0x0600549A RID: 21658 RVA: 0x0016BE8C File Offset: 0x0016A08C
		public custConverter()
		{
		}
	}
}
