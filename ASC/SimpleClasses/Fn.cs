using System;

namespace ASC.SimpleClasses
{
	// Token: 0x020001FF RID: 511
	public class Fn
	{
		// Token: 0x06001BA5 RID: 7077 RVA: 0x00051AC0 File Offset: 0x0004FCC0
		public static decimal FormatSumm(decimal input)
		{
			decimal result;
			try
			{
				result = ((!Auth.Config.classic_kassa) ? decimal.ToInt32(input) : Math.Round(input, 2));
			}
			catch (Exception)
			{
				result = input;
			}
			return result;
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x000046B4 File Offset: 0x000028B4
		public Fn()
		{
		}
	}
}
