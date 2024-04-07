using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using System.Windows.Markup;

namespace ASC.Converters
{
	// Token: 0x02000BED RID: 3053
	internal class ListInt2ValueConverter : MarkupExtension, IValueConverter
	{
		// Token: 0x060054D0 RID: 21712 RVA: 0x0016BE8C File Offset: 0x0016A08C
		public ListInt2ValueConverter()
		{
		}

		// Token: 0x060054D1 RID: 21713 RVA: 0x0016BE7C File Offset: 0x0016A07C
		public override object ProvideValue(IServiceProvider serviceProvider)
		{
			return this;
		}

		// Token: 0x060054D2 RID: 21714 RVA: 0x0016CDB4 File Offset: 0x0016AFB4
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value != null && ((List<int>)value).Any<int>())
			{
				return (List<int>)value;
			}
			return null;
		}

		// Token: 0x060054D3 RID: 21715 RVA: 0x0016CDDC File Offset: 0x0016AFDC
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value == null)
			{
				return null;
			}
			List<object> list = (List<object>)value;
			List<int> list2 = new List<int>();
			foreach (object obj in list)
			{
				list2.Add((int)obj);
			}
			return list2;
		}
	}
}
