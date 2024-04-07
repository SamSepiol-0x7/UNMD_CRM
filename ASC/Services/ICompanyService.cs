using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASC.Common.Interfaces;

namespace ASC.Services
{
	// Token: 0x020005C6 RID: 1478
	public interface ICompanyService
	{
		// Token: 0x060036EE RID: 14062
		Task<companies> GetCompany(int companyId);

		// Token: 0x060036EF RID: 14063
		Task<IEnumerable<ICompanyLookUp>> GetCompaniesLookup();
	}
}
