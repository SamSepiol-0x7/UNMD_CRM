using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using DevExpress.Mvvm;

namespace ASC.Services.Abstract
{
	// Token: 0x020007F5 RID: 2037
	public interface IPartsRequestService
	{
		// Token: 0x06003D1B RID: 15643
		Task<parts_request> GetRequest(int requestId);

		// Token: 0x06003D1C RID: 15644
		void ReferenceDealer(parts_request request);

		// Token: 0x06003D1D RID: 15645
		Task<List<parts_request>> GetRequests(IPeriod period, int employeeId, int selectedRequestStatus, int priority);

		// Token: 0x06003D1E RID: 15646
		Task<List<parts_request>> GetRequests(workshop repair);

		// Token: 0x06003D1F RID: 15647
		Task<List<parts_request>> GetRequests(int repairId);

		// Token: 0x06003D20 RID: 15648
		List<int> GetResponsibleEmployees(parts_request request);

		// Token: 0x06003D21 RID: 15649
		parts_request NewRequest();

		// Token: 0x06003D22 RID: 15650
		parts_request NewRequest(workshop repair);

		// Token: 0x06003D23 RID: 15651
		parts_request NewRequest(store_items item);

		// Token: 0x06003D24 RID: 15652
		void ReferenceFromUser(parts_request request);

		// Token: 0x06003D25 RID: 15653
		bool CreateRequest(parts_request request, List<int> responsibleUsers);

		// Token: 0x06003D26 RID: 15654
		Task UpdateRequest(parts_request request);

		// Token: 0x06003D27 RID: 15655
		bool CheckFields(parts_request request, IMessageBoxService mbs);

		// Token: 0x06003D28 RID: 15656
		Dictionary<int, string> GetPartsRequestStatuses(bool includeAll = false);
	}
}
