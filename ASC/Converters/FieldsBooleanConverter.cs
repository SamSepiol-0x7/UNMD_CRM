using System;
using System.Globalization;
using System.Windows.Data;

namespace ASC.Converters
{
	// Token: 0x02000BEA RID: 3050
	public class FieldsBooleanConverter : IValueConverter
	{
		// Token: 0x060054C7 RID: 21703 RVA: 0x0016CCD4 File Offset: 0x0016AED4
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			string text = parameter as string;
			if (text == null)
			{
				return false;
			}
			return Auth.User.IsFieldVisible(text);
		}

		// Token: 0x060054C8 RID: 21704 RVA: 0x0016CD04 File Offset: 0x0016AF04
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			string text = parameter as string;
			if (text != null)
			{
				Auth.User.SetFieldVisibility(text, (bool)value);
			}
			return Auth.User.FieldsVisibility;
		}

		// Token: 0x060054C9 RID: 21705 RVA: 0x000046B4 File Offset: 0x000028B4
		public FieldsBooleanConverter()
		{
		}
	}
}
