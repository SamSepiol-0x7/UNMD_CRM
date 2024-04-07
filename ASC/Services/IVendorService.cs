using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASC.Services
{
	// Token: 0x020005F8 RID: 1528
	public interface IVendorService
	{
		// Token: 0x0600375F RID: 14175
		Task<List<vendors>> GetVendors();

		// Token: 0x06003760 RID: 14176
		Task<List<vendors>> GetAllVendors();

		// Token: 0x06003761 RID: 14177
		Task<vendors> GetVendor(int vendorId);

		// Token: 0x06003762 RID: 14178
		Task<int> CreateVendor(vendors data);

		// Token: 0x06003763 RID: 14179
		Task UpdateVendor(vendors data);
	}
}
