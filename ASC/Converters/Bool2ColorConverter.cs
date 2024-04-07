using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace ASC.Converters
{
	// Token: 0x02000BD4 RID: 3028
	public class Bool2ColorConverter : IValueConverter
	{
		// Token: 0x06005482 RID: 21634 RVA: 0x0016BBE0 File Offset: 0x00169DE0
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (!(value is bool))
			{
				return Brushes.Transparent;
			}
			if (!(bool)value)
			{
				return Brushes.Orange;
			}
			return Brushes.LightGreen;
		}

		// Token: 0x06005483 RID: 21635 RVA: 0x0007E558 File Offset: 0x0007C758
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06005484 RID: 21636 RVA: 0x000046B4 File Offset: 0x000028B4
		public Bool2ColorConverter()
		{
		}
	}
}
