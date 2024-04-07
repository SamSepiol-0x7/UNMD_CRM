using System;
using ASC.Common.Interfaces;

namespace ASC.Interfaces
{
	// Token: 0x02000B2C RID: 2860
	public interface ICustomerSearchViewModel
	{
		// Token: 0x06005092 RID: 20626
		ICustomer GetSelected();

		// Token: 0x06005093 RID: 20627
		void SetSelected(int customerId);

		// Token: 0x06005094 RID: 20628
		void SetSelected(ICustomer customer);
	}
}
