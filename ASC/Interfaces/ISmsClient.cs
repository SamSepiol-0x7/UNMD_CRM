using System;
using System.Threading.Tasks;

namespace ASC.Interfaces
{
	// Token: 0x02000B44 RID: 2884
	public interface ISmsClient
	{
		// Token: 0x06005125 RID: 20773
		Task<bool> SendAsync(string phone, string message, int? customerId);

		// Token: 0x06005126 RID: 20774
		Task SendAsync(int repairId, int customerId, int templateId);

		// Token: 0x06005127 RID: 20775
		Task<string> BalanceAsync();
	}
}
