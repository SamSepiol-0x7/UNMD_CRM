using System;
using System.Globalization;
using System.Windows.Data;

namespace ASC.Converters
{
	// Token: 0x02000BD2 RID: 3026
	public class NumericNegationConverter : IValueConverter
	{
		// Token: 0x0600547E RID: 21630 RVA: 0x0016BB68 File Offset: 0x00169D68
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is int)
			{
				int num = (int)value;
				return -num;
			}
			return value;
		}

		// Token: 0x0600547F RID: 21631 RVA: 0x0007E558 File Offset: 0x0007C758
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06005480 RID: 21632 RVA: 0x000046B4 File Offset: 0x000028B4
		public NumericNegationConverter()
		{
		}
	}
}
