using System;
using ASC.Common.Interfaces;

namespace ASC.Interfaces
{
	// Token: 0x02000B3F RID: 2879
	public interface ICashOrderSelect : IRefreshable
	{
		// Token: 0x0600511F RID: 20767
		void SelectCashOrder(ICashOrder order);
	}
}
