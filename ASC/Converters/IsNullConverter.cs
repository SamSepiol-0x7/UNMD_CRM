using System;
using System.Globalization;
using System.Windows.Data;

namespace ASC.Converters
{
	// Token: 0x02000BF2 RID: 3058
	public class IsNullConverter : IValueConverter
	{
		// Token: 0x060054E1 RID: 21729 RVA: 0x0016D0AC File Offset: 0x0016B2AC
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return value == null;
		}

		// Token: 0x060054E2 RID: 21730 RVA: 0x0016D0C4 File Offset: 0x0016B2C4
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new InvalidOperationException("IsNullConverter can only be used OneWay.");
		}

		// Token: 0x060054E3 RID: 21731 RVA: 0x000046B4 File Offset: 0x000028B4
		public IsNullConverter()
		{
		}
	}
}
