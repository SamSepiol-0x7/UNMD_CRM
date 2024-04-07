using System;
using System.Globalization;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;
using PawnHunter.Numerals;

namespace ASC
{
	// Token: 0x0200009A RID: 154
	public static class ConvertersStack
	{
		// Token: 0x0600126E RID: 4718 RVA: 0x00022AB8 File Offset: 0x00020CB8
		public static byte[] ImageToByteArray(BitmapImage imageIn)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				new JpegBitmapEncoder
				{
					Frames = 
					{
						BitmapFrame.Create(imageIn)
					}
				}.Save(memoryStream);
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x00022B0C File Offset: 0x00020D0C
		public static BitmapImage ByteArrayToImage(byte[] imageData)
		{
			if (imageData != null && imageData.Length != 0)
			{
				BitmapImage result;
				using (MemoryStream memoryStream = new MemoryStream(imageData))
				{
					memoryStream.Position = 0L;
					BitmapImage bitmapImage = new BitmapImage();
					bitmapImage.BeginInit();
					bitmapImage.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
					bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
					bitmapImage.StreamSource = memoryStream;
					bitmapImage.EndInit();
					bitmapImage.Freeze();
					result = bitmapImage;
				}
				return result;
			}
			return null;
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x00022B84 File Offset: 0x00020D84
		public static string IndexToCompanyType(int i)
		{
			switch (i)
			{
			case 0:
				return Application.Current.TryFindResource("Ooo").ToString();
			case 1:
				return Application.Current.TryFindResource("Ipred").ToString();
			case 2:
				return Application.Current.TryFindResource("Ppred").ToString();
			default:
				return string.Empty;
			}
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x00022BE8 File Offset: 0x00020DE8
		public static string SummToString(decimal summ, string currency)
		{
			NumeralsFormatter provider = new NumeralsFormatter(CultureInfo.CurrentCulture);
			string format;
			if (!(currency == "RUB"))
			{
				if (currency == "UAH")
				{
					string[] array = new string[9];
					array[0] = "{0:T;M} {0:W;";
					int num = 1;
					object obj = Application.Current.TryFindResource("Uah");
					array[num] = ((obj != null) ? obj.ToString() : null);
					array[2] = "(";
					int num2 = 3;
					object obj2 = Application.Current.TryFindResource("Uah1");
					array[num2] = ((obj2 != null) ? obj2.ToString() : null);
					array[4] = ",";
					int num3 = 5;
					object obj3 = Application.Current.TryFindResource("Uah2");
					array[num3] = ((obj3 != null) ? obj3.ToString() : null);
					array[6] = ",";
					int num4 = 7;
					object obj4 = Application.Current.TryFindResource("Uah3");
					array[num4] = ((obj4 != null) ? obj4.ToString() : null);
					array[8] = ")} {1:00} коп.";
					format = string.Concat(array);
				}
				else
				{
					format = "{0:T;M} {0:W;рубл(ь,я,ей)} {1:00} коп.";
				}
			}
			else
			{
				format = "{0:T;M} {0:W;рубл(ь,я,ей)} {1:00} коп.";
			}
			string result;
			try
			{
				result = string.Format(provider, format, new object[]
				{
					(int)Math.Abs(summ),
					summ.ToString("0.00", CultureInfo.InvariantCulture).Split(new char[]
					{
						'.'
					})[1]
				}).ToLower();
			}
			catch (Exception)
			{
				result = string.Format("{0} {1}", summ, currency);
			}
			return result;
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x00022D54 File Offset: 0x00020F54
		public static string SummToString(decimal summ)
		{
			NumeralsFormatter provider = new NumeralsFormatter(CultureInfo.CurrentCulture);
			string result;
			try
			{
				result = string.Format(provider, "{0:t;M}", new object[]
				{
					(int)Math.Abs(summ)
				});
			}
			catch (Exception)
			{
				result = string.Format("{0:n0}", summ);
			}
			return result;
		}
	}
}
