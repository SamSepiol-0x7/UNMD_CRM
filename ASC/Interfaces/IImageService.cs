using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASC.Interfaces
{
	// Token: 0x02000B30 RID: 2864
	public interface IImageService
	{
		// Token: 0x060050B9 RID: 20665
		Task<List<images>> GetImages(List<int> imageIds);

		// Token: 0x060050BA RID: 20666
		Task<images> GetImage(int imageId);

		// Token: 0x060050BB RID: 20667
		Task<int> CreateImageAsync(images image);

		// Token: 0x060050BC RID: 20668
		Task<List<int>> CreateImages(List<images> images);

		// Token: 0x060050BD RID: 20669
		void DeleteImages(List<int> imageIds);

		// Token: 0x060050BE RID: 20670
		void DeleteImage(int imageId);

		// Token: 0x060050BF RID: 20671
		Task UpdateImageAsync(images i);
	}
}
