using System;

namespace ASC.Services.Abstract
{
	// Token: 0x02000801 RID: 2049
	public interface IToasterService
	{
		// Token: 0x06003D5D RID: 15709
		void Info(string message);

		// Token: 0x06003D5E RID: 15710
		void Error(string message);

		// Token: 0x06003D5F RID: 15711
		void Success(string message);
	}
}
