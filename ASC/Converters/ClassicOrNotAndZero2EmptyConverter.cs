using System;
using System.Globalization;
using System.Windows.Data;

namespace ASC.Converters
{
	// Token: 0x02000BE2 RID: 3042
	internal class ClassicOrNotAndZero2EmptyConverter : IValueConverter
	{
		// Token: 0x060054B2 RID: 21682 RVA: 0x0016C2B8 File Offset: 0x0016A4B8
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value == null || !(value is decimal))
			{
				return null;
			}
			if ((decimal)value == 0m)
			{
				return " ";
			}
			if (Auth.Config.classic_kassa)
			{
				return value;
			}
			return decimal.ToInt32((decimal)value);
		}

		// Token: 0x060054B3 RID: 21683 RVA: 0x00093000 File Offset: 0x00091200
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return value;
		}

		// Token: 0x060054B4 RID: 21684 RVA: 0x000046B4 File Offset: 0x000028B4
		public ClassicOrNotAndZero2EmptyConverter()
		{
		}
	}
}
