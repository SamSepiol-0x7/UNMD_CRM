using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ASC.Extensions
{
	// Token: 0x02000B6B RID: 2923
	public static class String
	{
		// Token: 0x060051C2 RID: 20930 RVA: 0x0015F604 File Offset: 0x0015D804
		public static string Base64Encode(this string plainText)
		{
			return Convert.ToBase64String(Encoding.UTF8.GetBytes(plainText));
		}

		// Token: 0x060051C3 RID: 20931 RVA: 0x0015F624 File Offset: 0x0015D824
		public static string Base64Decode(this string base64EncodedData)
		{
			if (!string.IsNullOrEmpty(base64EncodedData))
			{
				goto IL_2C;
			}
			IL_08:
			int num = -1139314262;
			IL_0D:
			byte[] bytes;
			switch ((num ^ -842716085) % 4)
			{
			case 0:
				goto IL_08;
			case 1:
				return string.Empty;
			case 2:
				IL_2C:
				bytes = Convert.FromBase64String(base64EncodedData);
				num = -541629924;
				goto IL_0D;
			}
			return Encoding.UTF8.GetString(bytes);
		}

		// Token: 0x060051C4 RID: 20932 RVA: 0x0015F67C File Offset: 0x0015D87C
		public static string FirstOrEmpty(this string source, bool withDot = false)
		{
			if (!withDot)
			{
				goto IL_4E;
			}
			string text = ".";
			IL_0F:
			string str = text;
			int num = (!string.IsNullOrEmpty(source)) ? -1509284155 : -276983166;
			IL_2F:
			switch ((num ^ -989202240) % 4)
			{
			case 0:
				IL_4E:
				num = -855274337;
				goto IL_2F;
			case 1:
				return source.Substring(0, 1) + str;
			case 3:
				text = "";
				goto IL_0F;
			}
			return string.Empty;
		}

		// Token: 0x060051C5 RID: 20933 RVA: 0x0015F6F4 File Offset: 0x0015D8F4
		public static string Truncate(this string value, int maxChars, string end = "...")
		{
			if (value.Length > maxChars)
			{
				return value.Substring(0, maxChars) + end;
			}
			return value;
		}

		// Token: 0x060051C6 RID: 20934 RVA: 0x0015F71C File Offset: 0x0015D91C
		public static string RemoveIntegers(this string input)
		{
			return Regex.Replace(input, "[\\d-]", string.Empty);
		}
	}
}
