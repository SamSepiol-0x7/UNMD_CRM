using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ASC
{
	// Token: 0x020000A8 RID: 168
	internal static class Generators
	{
		// Token: 0x060012BB RID: 4795 RVA: 0x00024BA4 File Offset: 0x00022DA4
		public static string RandomString(int length, string allowedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789")
		{
			if (length < 0)
			{
				throw new ArgumentOutOfRangeException("length", "length cannot be less than zero.");
			}
			if (string.IsNullOrEmpty(allowedChars))
			{
				throw new ArgumentException("allowedChars may not be empty.");
			}
			char[] array = new HashSet<char>(allowedChars).ToArray<char>();
			if (256 >= array.Length)
			{
				using (RNGCryptoServiceProvider rngcryptoServiceProvider = new RNGCryptoServiceProvider())
				{
					StringBuilder stringBuilder = new StringBuilder();
					byte[] array2 = new byte[128];
					while (stringBuilder.Length < length)
					{
						rngcryptoServiceProvider.GetBytes(array2);
						int num = 0;
						while (num < array2.Length && stringBuilder.Length < length)
						{
							if (256 - 256 % array.Length > (int)array2[num])
							{
								stringBuilder.Append(array[(int)array2[num] % array.Length]);
							}
							num++;
						}
					}
					return stringBuilder.ToString();
				}
			}
			throw new ArgumentException(string.Format("allowedChars may contain no more than {0} characters.", 256));
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x00024C98 File Offset: 0x00022E98
		public static string HashPassword(string password)
		{
			byte[] bytes = Encoding.ASCII.GetBytes(password);
			byte[] array = new MD5CryptoServiceProvider().ComputeHash(bytes);
			string text = "";
			foreach (byte b in array)
			{
				text += b.ToString("x2");
			}
			return text;
		}
	}
}
