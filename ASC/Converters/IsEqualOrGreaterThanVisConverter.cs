using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ASC.Converters
{
	// Token: 0x02000BF1 RID: 3057
	public class IsEqualOrGreaterThanVisConverter : IValueConverter
	{
		// Token: 0x060054DE RID: 21726 RVA: 0x0016D084 File Offset: 0x0016B284
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			int num = (int)value;
			int num2 = System.Convert.ToInt32(parameter);
			return (num >= num2) ? Visibility.Visible : Visibility.Collapsed;
		}

		// Token: 0x060054DF RID: 21727 RVA: 0x00093000 File Offset: 0x00091200
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return value;
		}

		// Token: 0x060054E0 RID: 21728 RVA: 0x000046B4 File Offset: 0x000028B4
		public IsEqualOrGreaterThanVisConverter()
		{
		}
	}
}
