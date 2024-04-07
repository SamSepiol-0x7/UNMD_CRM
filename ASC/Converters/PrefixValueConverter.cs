using System;
using System.Globalization;
using System.Windows.Data;

namespace ASC.Converters
{
	// Token: 0x02000BFB RID: 3067
	internal class PrefixValueConverter : IValueConverter
	{
		// Token: 0x060054FA RID: 21754 RVA: 0x0016DD50 File Offset: 0x0016BF50
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value == null)
			{
				return string.Empty;
			}
			string text = value.ToString();
			int num;
			if (!int.TryParse(parameter.ToString(), out num) || text.Length <= num)
			{
				return text;
			}
			if (num != 1)
			{
				return text.Substring(0, num);
			}
			return text.Substring(0, num) + ".";
		}

		// Token: 0x060054FB RID: 21755 RVA: 0x0002A744 File Offset: 0x00028944
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060054FC RID: 21756 RVA: 0x000046B4 File Offset: 0x000028B4
		public PrefixValueConverter()
		{
		}
	}
}
