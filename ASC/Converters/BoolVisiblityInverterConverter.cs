using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ASC.Converters
{
	// Token: 0x02000BE0 RID: 3040
	public class BoolVisiblityInverterConverter : IValueConverter
	{
		// Token: 0x060054AE RID: 21678 RVA: 0x0016C1B0 File Offset: 0x0016A3B0
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is bool)
			{
				return ((bool)value) ? Visibility.Collapsed : Visibility.Visible;
			}
			return Visibility.Collapsed;
		}

		// Token: 0x060054AF RID: 21679 RVA: 0x0016C1E0 File Offset: 0x0016A3E0
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is bool)
			{
				return !(bool)value;
			}
			return value;
		}

		// Token: 0x060054B0 RID: 21680 RVA: 0x000046B4 File Offset: 0x000028B4
		public BoolVisiblityInverterConverter()
		{
		}
	}
}
