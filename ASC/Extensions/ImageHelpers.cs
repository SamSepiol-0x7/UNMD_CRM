using System;
using System.IO;
using System.Windows.Media.Imaging;

namespace ASC.Extensions
{
	// Token: 0x02000B6A RID: 2922
	public static class ImageHelpers
	{
		// Token: 0x060051C1 RID: 20929 RVA: 0x0015F590 File Offset: 0x0015D790
		public static BitmapImage ToBitmapImage(this WriteableBitmap wbm)
		{
			BitmapImage bitmapImage = new BitmapImage();
			using (MemoryStream memoryStream = new MemoryStream())
			{
				new PngBitmapEncoder
				{
					Frames = 
					{
						BitmapFrame.Create(wbm)
					}
				}.Save(memoryStream);
				bitmapImage.BeginInit();
				bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
				bitmapImage.StreamSource = memoryStream;
				bitmapImage.EndInit();
				bitmapImage.Freeze();
			}
			return bitmapImage;
		}
	}
}
