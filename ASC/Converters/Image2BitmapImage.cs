using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Media.Imaging;

namespace ASC.Converters
{
	// Token: 0x02000BF8 RID: 3064
	public static class Image2BitmapImage
	{
		// Token: 0x060054F3 RID: 21747 RVA: 0x0016DBC0 File Offset: 0x0016BDC0
		public static BitmapImage Convert(Image img)
		{
			BitmapImage result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				BitmapImage bitmapImage = new BitmapImage();
				try
				{
					img.Save(memoryStream, ImageFormat.Png);
					memoryStream.Position = 0L;
					bitmapImage.BeginInit();
					bitmapImage.StreamSource = memoryStream;
					bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
					bitmapImage.EndInit();
				}
				catch (Exception)
				{
					return bitmapImage;
				}
				result = bitmapImage;
			}
			return result;
		}
	}
}
