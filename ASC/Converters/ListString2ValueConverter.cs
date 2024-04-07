using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using System.Windows.Markup;

namespace ASC.Converters
{
	// Token: 0x02000BDB RID: 3035
	internal class ListString2ValueConverter : MarkupExtension, IValueConverter
	{
		// Token: 0x0600549E RID: 21662 RVA: 0x0016BE8C File Offset: 0x0016A08C
		public ListString2ValueConverter()
		{
		}

		// Token: 0x0600549F RID: 21663 RVA: 0x0016BE7C File Offset: 0x0016A07C
		public override object ProvideValue(IServiceProvider serviceProvider)
		{
			return this;
		}

		// Token: 0x060054A0 RID: 21664 RVA: 0x0016BF18 File Offset: 0x0016A118
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value != null && ((List<string>)value).Any<string>())
			{
				return (List<string>)value;
			}
			return null;
		}

		// Token: 0x060054A1 RID: 21665 RVA: 0x0016BF40 File Offset: 0x0016A140
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value == null)
			{
				return null;
			}
			List<object> list = (List<object>)value;
			List<string> list2 = new List<string>();
			foreach (object obj in list)
			{
				list2.Add((string)obj);
			}
			return list2;
		}
	}
}
