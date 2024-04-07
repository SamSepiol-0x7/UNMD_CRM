using System;
using System.Globalization;
using System.Windows.Data;
using ASC.Options;

namespace ASC.Converters
{
	// Token: 0x02000BF9 RID: 3065
	public class IntToWarrantyOptionsName : IValueConverter
	{
		// Token: 0x060054F4 RID: 21748 RVA: 0x0016DC40 File Offset: 0x0016BE40
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value == null)
			{
				return string.Empty;
			}
			WarrantyOptions warrantyOptions = new WarrantyOptions();
			object result;
			try
			{
				result = ((warrantyOptions.GetOptionByDays((int)value) == null) ? string.Empty : warrantyOptions.GetOptionByDays((int)value).Name);
			}
			catch (Exception)
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x060054F5 RID: 21749 RVA: 0x0007E558 File Offset: 0x0007C758
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060054F6 RID: 21750 RVA: 0x000046B4 File Offset: 0x000028B4
		public IntToWarrantyOptionsName()
		{
		}
	}
}
