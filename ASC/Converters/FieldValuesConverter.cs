using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Data;

namespace ASC.Converters
{
	// Token: 0x02000BE4 RID: 3044
	public class FieldValuesConverter : IValueConverter
	{
		// Token: 0x060054B8 RID: 21688 RVA: 0x0016CAD0 File Offset: 0x0016ACD0
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
			if (!DateTime.TryParseExact(field_values.value, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
			{
				return field_values.value;
			}
			return dateTime.ToString("dd.MM.yyyy");
		}

		// Token: 0x060054B9 RID: 21689 RVA: 0x0007E558 File Offset: 0x0007C758
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060054BA RID: 21690 RVA: 0x000046B4 File Offset: 0x000028B4
		public FieldValuesConverter()
		{
		}

		// Token: 0x02000BE5 RID: 3045
		[CompilerGenerated]
		private sealed class <>c__DisplayClass0_0
		{
			// Token: 0x060054BB RID: 21691 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass0_0()
			{
			}

			// Token: 0x060054BC RID: 21692 RVA: 0x0016CB60 File Offset: 0x0016AD60
			internal bool <Convert>b__0(field_values f)
			{
				return f.field_id == this.fieldId;
			}

			// Token: 0x040037FA RID: 14330
			public int fieldId;
		}
	}
}
