using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace ASC.Converters
{
	// Token: 0x02000BDC RID: 3036
	public class Progress2Color : IValueConverter
	{
		// Token: 0x060054A2 RID: 21666 RVA: 0x0016BFA8 File Offset: 0x0016A1A8
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (!(value is double))
			{
				return "Black";
			}
			double num = (double)value;
			if (num < 26.0)
			{
				return Colors.ForestGreen;
			}
			if (num < 51.0)
			{
				return Colors.Yellow;
			}
			if (num < 76.0)
			{
				return Colors.Orange;
			}
			return Color.FromRgb(228, 71, 71);
		}

		// Token: 0x060054A3 RID: 21667 RVA: 0x0007E558 File Offset: 0x0007C758
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060054A4 RID: 21668 RVA: 0x000046B4 File Offset: 0x000028B4
		public Progress2Color()
		{
		}
	}
}
