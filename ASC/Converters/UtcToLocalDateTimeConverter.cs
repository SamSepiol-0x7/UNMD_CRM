using System;
using System.Globalization;
using System.Windows.Data;

namespace ASC.Converters
{
	// Token: 0x02000BFE RID: 3070
	public class UtcToLocalDateTimeConverter : IValueConverter
	{
		// Token: 0x06005503 RID: 21763 RVA: 0x0016DE30 File Offset: 0x0016C030
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (Auth.Config != null && value != null)
			{
				object result;
				try
				{
					TimeZoneInfo destinationTimeZone = TimeZoneInfo.FindSystemTimeZoneById(Auth.Config.time_zone);
					result = TimeZoneInfo.ConvertTime(DateTime.SpecifyKind(DateTime.Parse(value.ToString()), DateTimeKind.Utc), destinationTimeZone);
				}
				catch (Exception)
				{
					result = value;
				}
				return result;
			}
			return null;
		}

		// Token: 0x06005504 RID: 21764 RVA: 0x0016DE90 File Offset: 0x0016C090
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (Auth.Config != null && value != null)
			{
				object result;
				try
				{
					TimeZoneInfo sourceTimeZone = TimeZoneInfo.FindSystemTimeZoneById(Auth.Config.time_zone);
					result = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse(value.ToString()), sourceTimeZone);
				}
				catch (Exception)
				{
					result = value;
				}
				return result;
			}
			return null;
		}

		// Token: 0x06005505 RID: 21765 RVA: 0x000046B4 File Offset: 0x000028B4
		public UtcToLocalDateTimeConverter()
		{
		}
	}
}
