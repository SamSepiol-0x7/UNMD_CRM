using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASC.Models
{
	// Token: 0x02000ACA RID: 2762
	public interface IKassa
	{
		// Token: 0x06004E8C RID: 20108
		Task Widthraw(int officeId, int toUserId, int paymentSystemId, decimal summa);

		// Token: 0x06004E8D RID: 20109
		Dictionary<int, string> GetWithdrawModes();
	}
}
