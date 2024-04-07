using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using ASC.Common.Interfaces;

namespace ASC.Converters
{
	// Token: 0x02000BE6 RID: 3046
	public class ProductsConverter : IValueConverter
	{
		// Token: 0x060054BD RID: 21693 RVA: 0x0016CB7C File Offset: 0x0016AD7C
		public object Convert(object value, System.Type targetType, object parameter, CultureInfo culture)
		{
			IEnumerable<IAttribute> enumerable = value as IEnumerable<IAttribute>;
			if (enumerable == null)
			{
				return null;
			}
			int fieldId = (parameter as int?).GetValueOrDefault();
			if (fieldId == 0)
			{
				return null;
			}
			IAttribute attribute = new List<IAttribute>(enumerable).FirstOrDefault((IAttribute f) => f.FieldId == fieldId);
			if (attribute == null)
			{
				return null;
			}
			DateTime dateTime;
			if (DateTime.TryParseExact(attribute.Text, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
			{
				return dateTime.ToString("dd.MM.yyyy");
			}
			return attribute.Text;
		}

		// Token: 0x060054BE RID: 21694 RVA: 0x0007E558 File Offset: 0x0007C758
		public object ConvertBack(object value, System.Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060054BF RID: 21695 RVA: 0x000046B4 File Offset: 0x000028B4
		public ProductsConverter()
		{
		}

		// Token: 0x02000BE7 RID: 3047
		[CompilerGenerated]
		private sealed class <>c__DisplayClass0_0
		{
			// Token: 0x060054C0 RID: 21696 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass0_0()
			{
			}

			// Token: 0x060054C1 RID: 21697 RVA: 0x0016CC0C File Offset: 0x0016AE0C
			internal bool <Convert>b__0(IAttribute f)
			{
				return f.FieldId == this.fieldId;
			}

			// Token: 0x040037FB RID: 14331
			public int fieldId;
		}
	}
}
