using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASC.Common.Enum;
using ASC.Common.Interfaces;

namespace ASC.Interfaces
{
	// Token: 0x02000B2E RID: 2862
	public interface IEmployeeService
	{
		// Token: 0x060050AB RID: 20651
		Task<users> GetEmployeeAsync(string username);

		// Token: 0x060050AC RID: 20652
		Task<List<users>> GetEmployees();

		// Token: 0x060050AD RID: 20653
		Task<List<users>> GetEmployeesByRole(SystemRoles role);

		// Token: 0x060050AE RID: 20654
		Task<List<logs>> GetLogsAsync(IPeriod period, int employeeId);

		// Token: 0x060050AF RID: 20655
		bool EmployeeCan(string username, int permissionId);

		// Token: 0x060050B0 RID: 20656
		Task<IEnumerable<users>> GetEmployeesForAcp(bool showArchive = false);
	}
}
