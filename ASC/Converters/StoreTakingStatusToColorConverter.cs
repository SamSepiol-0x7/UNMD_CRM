using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace ASC.Converters
{
	// Token: 0x02000BD7 RID: 3031
	public class StoreTakingStatusToColorConverter : IValueConverter
	{
		// Token: 0x06005491 RID: 21649 RVA: 0x0016BCE4 File Offset: 0x00169EE4
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value != null)
			{
				IL_71:
				int num;
				while (int.TryParse(value.ToString(), out num))
				{
					for (;;)
					{
						IL_5B:
						switch (num)
						{
						case 1:
							goto IL_98;
						case 2:
							goto IL_A3;
						case 3:
							goto IL_AE;
						default:
						{
							uint num3;
							uint num2 = num3 * 3888498863U ^ 791496251U;
							for (;;)
							{
								switch ((num3 = (num2 ^ 1937958766U)) % 10U)
								{
								case 0U:
									goto IL_AE;
								case 1U:
									goto IL_A3;
								case 2U:
									num2 = (num3 * 2741812088U ^ 4118067656U);
									continue;
								case 3U:
									goto IL_5B;
								case 4U:
									goto IL_98;
								case 5U:
								case 6U:
									goto IL_82;
								case 8U:
									goto IL_8D;
								case 9U:
									goto IL_71;
								}
								goto Block_2;
							}
							break;
						}
						}
					}
					Block_2:
					break;
					IL_8D:
					return new SolidColorBrush(Colors.Transparent);
					IL_98:
					return new SolidColorBrush(Colors.LightGreen);
					IL_A3:
					return new SolidColorBrush(Colors.Yellow);
					IL_AE:
					return new SolidColorBrush(Colors.LightCoral);
				}
				return new SolidColorBrush(Colors.Transparent);
			}
			IL_82:
			return new SolidColorBrush(Colors.Transparent);
		}

		// Token: 0x06005492 RID: 21650 RVA: 0x0007E558 File Offset: 0x0007C758
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06005493 RID: 21651 RVA: 0x000046B4 File Offset: 0x000028B4
		public StoreTakingStatusToColorConverter()
		{
		}
	}
}
