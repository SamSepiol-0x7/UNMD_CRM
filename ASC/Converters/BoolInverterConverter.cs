using System;
using System.Globalization;
using System.Windows.Data;

namespace ASC.Converters
{
	// Token: 0x02000BF5 RID: 3061
	public class BoolInverterConverter : IValueConverter
	{
		// Token: 0x060054EA RID: 21738 RVA: 0x0016C1E0 File Offset: 0x0016A3E0
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is bool)
			{
				return !(bool)value;
			}
			return value;
		}

		// Token: 0x060054EB RID: 21739 RVA: 0x0016C1E0 File Offset: 0x0016A3E0
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is bool)
			{
				return !(bool)value;
			}
			return value;
		}

		// Token: 0x060054EC RID: 21740 RVA: 0x000046B4 File Offset: 0x000028B4
		public BoolInverterConverter()
		{
		}
	}
}
