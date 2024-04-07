using System;
using System.Globalization;
using System.Windows.Data;

namespace ASC.Converters
{
	// Token: 0x02000BF6 RID: 3062
	public class ConverterIntToAbs : IValueConverter
	{
		// Token: 0x060054ED RID: 21741 RVA: 0x0016DB48 File Offset: 0x0016BD48
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return Math.Abs(System.Convert.ToDecimal(value));
		}

		// Token: 0x060054EE RID: 21742 RVA: 0x00093000 File Offset: 0x00091200
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return value;
		}

		// Token: 0x060054EF RID: 21743 RVA: 0x000046B4 File Offset: 0x000028B4
		public ConverterIntToAbs()
		{
		}
	}
}
