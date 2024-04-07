using System;
using System.Globalization;
using System.Windows.Data;

namespace ASC.Converters
{
	// Token: 0x02000BEF RID: 3055
	public class ToUpperValueConverter : IValueConverter
	{
		// Token: 0x060054D8 RID: 21720 RVA: 0x0016CF2C File Offset: 0x0016B12C
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			string text = value as string;
			if (string.IsNullOrEmpty(text))
			{
				return string.Empty;
			}
			return text.ToUpper();
		}

		// Token: 0x060054D9 RID: 21721 RVA: 0x0016CF54 File Offset: 0x0016B154
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return new NotImplementedException();
		}

		// Token: 0x060054DA RID: 21722 RVA: 0x000046B4 File Offset: 0x000028B4
		public ToUpperValueConverter()
		{
		}
	}
}
