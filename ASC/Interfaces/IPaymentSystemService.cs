using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASC.Interfaces
{
	// Token: 0x02000B36 RID: 2870
	public interface IPaymentSystemService
	{
		// Token: 0x060050D3 RID: 20691
		Task<List<payment_systems>> GetPaymentSystems();
	}
}
