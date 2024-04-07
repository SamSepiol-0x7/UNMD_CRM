using System;
using System.Globalization;
using System.Windows.Data;
using DevExpress.Utils;

namespace ASC.Converters
{
	// Token: 0x02000BDF RID: 3039
	public class BoolToDefaultBooleanConverter : IValueConverter
	{
		// Token: 0x060054AB RID: 21675 RVA: 0x0016C16C File Offset: 0x0016A36C
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return ((bool)value) ? DefaultBoolean.True : DefaultBoolean.False;
		}

		// Token: 0x060054AC RID: 21676 RVA: 0x0016C18C File Offset: 0x0016A38C
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if ((DefaultBoolean)value == DefaultBoolean.True)
			{
				return true;
			}
			return false;
		}

		// Token: 0x060054AD RID: 21677 RVA: 0x000046B4 File Offset: 0x000028B4
		public BoolToDefaultBooleanConverter()
		{
		}
	}
}
