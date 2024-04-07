using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace ASC.Converters
{
	// Token: 0x02000BEE RID: 3054
	public class TimeSpanConverter : MarkupExtension, IValueConverter
	{
		// Token: 0x060054D4 RID: 21716 RVA: 0x0016CE44 File Offset: 0x0016B044
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value != null)
			{
				TimeSpan timeSpan = (TimeSpan)value;
				return string.Format("{0:D2}, {1:D2}:{2:D2}", timeSpan.Days, timeSpan.Hours, timeSpan.Minutes);
			}
			return "00, 00:00";
		}

		// Token: 0x060054D5 RID: 21717 RVA: 0x0016CE90 File Offset: 0x0016B090
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value != null)
			{
				if (((string)value).Length == 9)
				{
					object result;
					try
					{
						int days = System.Convert.ToInt32(((string)value).Substring(0, 2));
						int hours = System.Convert.ToInt32(((string)value).Substring(4, 2));
						int minutes = System.Convert.ToInt32(((string)value).Substring(7, 2));
						result = new TimeSpan(days, hours, minutes, 0);
					}
					catch (Exception)
					{
						result = new TimeSpan(0, 0, 0, 0);
					}
					return result;
				}
			}
			return new TimeSpan(0, 0, 0, 0);
		}

		// Token: 0x060054D6 RID: 21718 RVA: 0x0016BE7C File Offset: 0x0016A07C
		public override object ProvideValue(IServiceProvider serviceProvider)
		{
			return this;
		}

		// Token: 0x060054D7 RID: 21719 RVA: 0x0016BE8C File Offset: 0x0016A08C
		public TimeSpanConverter()
		{
		}
	}
}
