using System;
using System.Threading.Tasks;

namespace ASC.Services.Abstract
{
	// Token: 0x02000802 RID: 2050
	public interface IUserActivityService
	{
		// Token: 0x06003D60 RID: 15712
		void UserLogin(int userId);

		// Token: 0x06003D61 RID: 15713
		void SyncActivity();

		// Token: 0x06003D62 RID: 15714
		void AddActivity(string notes);

		// Token: 0x06003D63 RID: 15715
		Task<bool> SecondSessionOpened();
	}
}
