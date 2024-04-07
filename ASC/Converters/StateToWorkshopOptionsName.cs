using System;
using System.Globalization;
using System.Windows.Data;
using ASC.Options;

namespace ASC.Converters
{
	// Token: 0x02000BFD RID: 3069
	public class StateToWorkshopOptionsName : IValueConverter
	{
		// Token: 0x06005500 RID: 21760 RVA: 0x0016DDE8 File Offset: 0x0016BFE8
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value != null)
			{
				object result;
				try
				{
					result = new WorkshopOptions().GetOption((int)value).Name;
				}
				catch (Exception)
				{
					result = string.Empty;
				}
				return result;
			}
			return string.Empty;
		}

		// Token: 0x06005501 RID: 21761 RVA: 0x0007E558 File Offset: 0x0007C758
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06005502 RID: 21762 RVA: 0x000046B4 File Offset: 0x000028B4
		public StateToWorkshopOptionsName()
		{
		}
	}
}
