using System;
using System.Globalization;
using System.Windows.Data;

namespace ASC.Converters
{
	// Token: 0x02000BEB RID: 3051
	public class FieldsVisibilityConverter : IValueConverter
	{
		// Token: 0x060054CA RID: 21706 RVA: 0x0016CD38 File Offset: 0x0016AF38
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			string text = parameter as string;
			return text != null && Auth.User.IsFieldVisible(text);
		}

		// Token: 0x060054CB RID: 21707 RVA: 0x0007E558 File Offset: 0x0007C758
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060054CC RID: 21708 RVA: 0x000046B4 File Offset: 0x000028B4
		public FieldsVisibilityConverter()
		{
		}
	}
}
