using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace ASC.Converters
{
	// Token: 0x02000BDA RID: 3034
	public class Int2ColorConverter : IValueConverter
	{
		// Token: 0x0600549B RID: 21659 RVA: 0x0016BEA0 File Offset: 0x0016A0A0
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value == null)
			{
				return Brushes.Black;
			}
			int num;
			if (int.TryParse(value.ToString(), out num))
			{
				if (num == 0)
				{
					return Brushes.Black;
				}
				if (num < 0)
				{
					return Brushes.DarkRed;
				}
				return Brushes.DarkGreen;
			}
			else
			{
				decimal d;
				decimal.TryParse(value.ToString(), out d);
				if (d == 0m)
				{
					return Brushes.Black;
				}
				if (!(d < 0m))
				{
					return Brushes.DarkGreen;
				}
				return Brushes.DarkRed;
			}
		}

		// Token: 0x0600549C RID: 21660 RVA: 0x0007E558 File Offset: 0x0007C758
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600549D RID: 21661 RVA: 0x000046B4 File Offset: 0x000028B4
		public Int2ColorConverter()
		{
		}
	}
}
