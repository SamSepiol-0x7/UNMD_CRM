using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace ASC.Converters
{
	// Token: 0x02000BEC RID: 3052
	public class IEnumerableObjectsToIntsConverter : IValueConverter
	{
		// Token: 0x060054CD RID: 21709 RVA: 0x0016CD64 File Offset: 0x0016AF64
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is IEnumerable<int>)
			{
				return ((IEnumerable<int>)value).Cast<object>().ToList<object>();
			}
			return null;
		}

		// Token: 0x060054CE RID: 21710 RVA: 0x0016CD8C File Offset: 0x0016AF8C
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is List<object>)
			{
				return ((List<object>)value).Cast<int>().ToList<int>();
			}
			return null;
		}

		// Token: 0x060054CF RID: 21711 RVA: 0x000046B4 File Offset: 0x000028B4
		public IEnumerableObjectsToIntsConverter()
		{
		}
	}
}
