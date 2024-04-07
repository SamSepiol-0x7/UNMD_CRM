using System;

namespace ASC.Services.Abstract
{
	// Token: 0x020007EE RID: 2030
	public interface ILicenseService
	{
		// Token: 0x06003CC0 RID: 15552
		DateTime ExpirationDate();

		// Token: 0x06003CC1 RID: 15553
		double ExpirationDays();
	}
}
