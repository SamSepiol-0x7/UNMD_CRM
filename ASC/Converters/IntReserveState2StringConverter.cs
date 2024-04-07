using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ASC.Converters
{
	// Token: 0x02000BF0 RID: 3056
	public class IntReserveState2StringConverter : IValueConverter
	{
		// Token: 0x060054DB RID: 21723 RVA: 0x0016CF68 File Offset: 0x0016B168
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is int)
			{
				for (;;)
				{
					IL_66:
					switch ((int)value)
					{
					case 0:
						goto IL_8D;
					case 1:
						goto IL_A2;
					case 2:
						goto IL_B7;
					case 3:
						goto IL_CC;
					case 4:
						goto IL_E1;
					case 5:
						goto IL_F6;
					default:
					{
						uint num2;
						uint num = num2 * 847278972U ^ 545504018U;
						for (;;)
						{
							switch ((num2 = (num ^ 1814615803U)) % 10U)
							{
							case 0U:
								goto IL_A2;
							case 1U:
								goto IL_CC;
							case 2U:
								goto IL_E1;
							case 3U:
							case 4U:
								goto IL_66;
							case 5U:
								goto IL_B7;
							case 6U:
								goto IL_8D;
							case 7U:
								goto IL_F6;
							case 9U:
								num = (num2 * 754331379U ^ 68679290U);
								continue;
							}
							goto Block_2;
						}
						break;
					}
					}
				}
				Block_2:
				return value;
				IL_8D:
				return (string)Application.Current.TryFindResource("Waiting");
				IL_A2:
				return (string)Application.Current.TryFindResource("ItemOnMaster");
				IL_B7:
				return (string)Application.Current.TryFindResource("ItemOnRepair");
				IL_CC:
				return (string)Application.Current.TryFindResource("ItemOnOutRepair");
				IL_E1:
				return (string)Application.Current.TryFindResource("Arhive");
				IL_F6:
				return (string)Application.Current.TryFindResource("Rejected");
			}
			return value;
		}

		// Token: 0x060054DC RID: 21724 RVA: 0x0007E558 File Offset: 0x0007C758
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060054DD RID: 21725 RVA: 0x000046B4 File Offset: 0x000028B4
		public IntReserveState2StringConverter()
		{
		}
	}
}
