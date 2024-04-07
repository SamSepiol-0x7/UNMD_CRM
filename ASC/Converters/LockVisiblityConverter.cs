using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ASC.Converters
{
	// Token: 0x02000BFA RID: 3066
	public class LockVisiblityConverter : IMultiValueConverter
	{
		// Token: 0x060054F7 RID: 21751 RVA: 0x0016DCA0 File Offset: 0x0016BEA0
		public object Convert(object[] value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value != null && value[0] != null && value[1] != null && !(value[0].GetType() != typeof(int)) && !(value[1].GetType() != typeof(DateTime)))
			{
				DateTime d = (DateTime)value[1];
				return ((this._localization.Now - d).TotalMinutes < 1.0) ? Visibility.Visible : Visibility.Collapsed;
			}
			return Visibility.Collapsed;
		}

		// Token: 0x060054F8 RID: 21752 RVA: 0x0007E558 File Offset: 0x0007C758
		public object[] ConvertBack(object value, Type[] targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060054F9 RID: 21753 RVA: 0x0016DD2C File Offset: 0x0016BF2C
		public LockVisiblityConverter()
		{
		}

		// Token: 0x040037FD RID: 14333
		private Localization _localization = new Localization("UTC");
	}
}
