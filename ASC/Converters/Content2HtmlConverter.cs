using System;
using System.Globalization;
using System.Windows.Data;
using DevExpress.Xpf.RichEdit;

namespace ASC.Converters
{
	// Token: 0x02000BD8 RID: 3032
	public class Content2HtmlConverter : IValueConverter
	{
		// Token: 0x06005494 RID: 21652 RVA: 0x0016BDB4 File Offset: 0x00169FB4
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return new HtmlToContentConverter().Convert(value, targetType, parameter, culture);
		}

		// Token: 0x06005495 RID: 21653 RVA: 0x0016BDD0 File Offset: 0x00169FD0
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return new ContentToHtmlConverter().Convert(value, targetType, parameter, culture);
		}

		// Token: 0x06005496 RID: 21654 RVA: 0x000046B4 File Offset: 0x000028B4
		public Content2HtmlConverter()
		{
		}
	}
}
