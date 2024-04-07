using System;
using System.Globalization;
using System.Windows.Data;

namespace ASC.Converters
{
	// Token: 0x02000BDE RID: 3038
	public class StringDateTimeConverter : IValueConverter
	{
		// Token: 0x060054A8 RID: 21672 RVA: 0x0016C0EC File Offset: 0x0016A2EC
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value != null)
			{
				goto IL_46;
			}
			IL_12:
			int num = 35562694;
			IL_17:
			switch ((num ^ 1273332037) % 5)
			{
			case 0:
			{
				DateTime dateTime;
				return dateTime.ToString("dd.MM.yyyy");
			}
			case 2:
				return null;
			case 3:
				goto IL_12;
			case 4:
			{
				IL_46:
				DateTime dateTime;
				num = ((!DateTime.TryParseExact((string)value, "MM/dd/yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime)) ? 2072487471 : 934958167);
				goto IL_17;
			}
			}
			return value;
		}

		// Token: 0x060054A9 RID: 21673 RVA: 0x0007E558 File Offset: 0x0007C758
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060054AA RID: 21674 RVA: 0x000046B4 File Offset: 0x000028B4
		public StringDateTimeConverter()
		{
		}
	}
}
