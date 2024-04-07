using System;
using System.Globalization;
using System.Windows.Data;

namespace ASC.Converters
{
	// Token: 0x02000BDD RID: 3037
	internal class StringToLengthConverter : IValueConverter
	{
		// Token: 0x060054A5 RID: 21669 RVA: 0x0016C024 File Offset: 0x0016A224
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value == null)
			{
				goto IL_12;
			}
			goto IL_79;
			int num;
			double num2;
			for (;;)
			{
				IL_46:
				switch ((num ^ 377517990) % 6)
				{
				case 0:
					num2 = (double)(((string)value).Length * 12 - ((string)value).Length);
					if (num2 >= 150.0)
					{
						num = 1593934165;
						continue;
					}
					goto IL_8B;
				case 2:
					goto IL_9D;
				case 3:
					goto IL_AC;
				case 4:
					goto IL_12;
				case 5:
					goto IL_79;
				}
				break;
			}
			goto IL_96;
			IL_8B:
			double num3 = 150.0;
			goto IL_97;
			IL_96:
			num3 = num2;
			IL_97:
			return num3;
			IL_9D:
			return 150.0;
			IL_AC:
			return 150.0;
			IL_12:
			num = 694994397;
			goto IL_46;
			IL_79:
			num = (string.IsNullOrEmpty((string)value) ? 386763448 : 1366869176);
			goto IL_46;
		}

		// Token: 0x060054A6 RID: 21670 RVA: 0x0007E558 File Offset: 0x0007C758
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060054A7 RID: 21671 RVA: 0x000046B4 File Offset: 0x000028B4
		public StringToLengthConverter()
		{
		}
	}
}
