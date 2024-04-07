using System;
using System.Windows;

namespace ASC
{
	// Token: 0x0200001E RID: 30
	public static class Lang
	{
		// Token: 0x060000FF RID: 255 RVA: 0x00004F1C File Offset: 0x0000311C
		public static string t(string resourceName)
		{
			string result;
			try
			{
				string text = (string)Application.Current.TryFindResource(resourceName);
				if (!string.IsNullOrEmpty(text))
				{
					goto IL_3E;
				}
				string text2 = resourceName;
				IL_1D:
				result = text2;
				int num = -1579879634;
				IL_23:
				switch ((num ^ -720408909) % 3)
				{
				case 0:
					IL_3E:
					num = -1301134448;
					goto IL_23;
				case 2:
					text2 = text;
					goto IL_1D;
				}
			}
			catch (Exception)
			{
				result = "Resource not found";
			}
			return result;
		}
	}
}
