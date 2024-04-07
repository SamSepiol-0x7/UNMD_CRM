using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Data;

namespace ASC.Converters
{
	// Token: 0x02000BE8 RID: 3048
	public class ProductAttributesConverter : IValueConverter
	{
		// Token: 0x060054C2 RID: 21698 RVA: 0x0016CC28 File Offset: 0x0016AE28
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			IEnumerable<field_values> enumerable = value as IEnumerable<field_values>;
			if (enumerable == null)
			{
				return null;
			}
			int fieldId = (parameter as int?).GetValueOrDefault();
			if (fieldId == 0)
			{
				return null;
			}
			field_values field_values = new List<field_values>(enumerable).FirstOrDefault((field_values f) => f.field_id == fieldId);
			if (field_values == null)
			{
				return null;
			}
			DateTime dateTime;
			if (DateTime.TryParseExact(field_values.value, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
			{
				return dateTime.ToString("dd.MM.yyyy");
			}
			return field_values.value;
		}

		// Token: 0x060054C3 RID: 21699 RVA: 0x0007E558 File Offset: 0x0007C758
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060054C4 RID: 21700 RVA: 0x000046B4 File Offset: 0x000028B4
		public ProductAttributesConverter()
		{
		}

		// Token: 0x02000BE9 RID: 3049
		[CompilerGenerated]
		private sealed class <>c__DisplayClass0_0
		{
			// Token: 0x060054C5 RID: 21701 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass0_0()
			{
			}

			// Token: 0x060054C6 RID: 21702 RVA: 0x0016CCB8 File Offset: 0x0016AEB8
			internal bool <Convert>b__0(field_values f)
			{
				return f.field_id == this.fieldId;
			}

			// Token: 0x040037FC RID: 14332
			public int fieldId;
		}
	}
}
