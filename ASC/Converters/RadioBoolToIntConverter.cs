using System;
using System.Globalization;
using System.Windows.Data;

namespace ASC.Converters
{
	// Token: 0x02000BFC RID: 3068
	public class RadioBoolToIntConverter : IValueConverter
	{
		// Token: 0x060054FD RID: 21757 RVA: 0x0016DDA8 File Offset: 0x0016BFA8
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if ((int)value == int.Parse(parameter.ToString()))
			{
				return true;
			}
			return false;
		}

		// Token: 0x060054FE RID: 21758 RVA: 0x0016DDD8 File Offset: 0x0016BFD8
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return parameter;
		}

		// Token: 0x060054FF RID: 21759 RVA: 0x000046B4 File Offset: 0x000028B4
		public RadioBoolToIntConverter()
		{
		}
	}
}
