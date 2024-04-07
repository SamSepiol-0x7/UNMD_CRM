using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ASC.Converters
{
	// Token: 0x02000BF4 RID: 3060
	public class ZeroVisibilityConverter : IValueConverter
	{
		// Token: 0x060054E7 RID: 21735 RVA: 0x0016DB18 File Offset: 0x0016BD18
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is int)
			{
				return ((int)value == 0) ? Visibility.Visible : Visibility.Collapsed;
			}
			return Visibility.Collapsed;
		}

		// Token: 0x060054E8 RID: 21736 RVA: 0x0002A744 File Offset: 0x00028944
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060054E9 RID: 21737 RVA: 0x000046B4 File Offset: 0x000028B4
		public ZeroVisibilityConverter()
		{
		}
	}
}
