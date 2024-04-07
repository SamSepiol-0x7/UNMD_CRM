using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASC.Common.Interfaces;

namespace ASC.Services.Abstract
{
	// Token: 0x020007F4 RID: 2036
	public interface IOfficeService
	{
		// Token: 0x06003D14 RID: 15636
		Task<int> CreateOfficeAsync(offices office);

		// Token: 0x06003D15 RID: 15637
		string CheckFields(offices office);

		// Token: 0x06003D16 RID: 15638
		Task<offices> GetOfficeAsync(int officeId);

		// Token: 0x06003D17 RID: 15639
		Task UpdateOfficeAsync(offices office);

		// Token: 0x06003D18 RID: 15640
		Task<List<offices>> GetOfficesAsync();

		// Token: 0x06003D19 RID: 15641
		Task<IEnumerable<IOfficeLookup>> GetOfficesLookupAsync();

		// Token: 0x06003D1A RID: 15642
		Task<int> CountActiveOfficesAsync();
	}
}
