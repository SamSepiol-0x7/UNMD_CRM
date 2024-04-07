using System;
using System.Globalization;
using System.Windows.Data;

namespace ASC.Converters
{
	// Token: 0x02000BF7 RID: 3063
	internal class FirstUpperConverter : IValueConverter
	{
		// Token: 0x060054F0 RID: 21744 RVA: 0x0016DB68 File Offset: 0x0016BD68
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value == null)
			{
				return string.Empty;
			}
			string text = value.ToString();
			if (text.Length <= 0)
			{
				return string.Empty;
			}
			return text.Substring(0, 1).ToUpper() + ((text.Length > 1) ? text.Substring(1) : "");
		}

		// Token: 0x060054F1 RID: 21745 RVA: 0x00093000 File Offset: 0x00091200
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return value;
		}

		// Token: 0x060054F2 RID: 21746 RVA: 0x000046B4 File Offset: 0x000028B4
		public FirstUpperConverter()
		{
		}
	}
}
