using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;

namespace ASC
{
	// Token: 0x020000A9 RID: 169
	public interface IHistoryV2 : IDisposable
	{
		// Token: 0x060012BD RID: 4797
		void Add(int actionCode, string[] prm = null);

		// Token: 0x060012BE RID: 4798
		void AddItemLog(string action, int itemId, string prm1, string prm2 = "");

		// Token: 0x060012BF RID: 4799
		void AddItemLog(int itemId, parts_request request);

		// Token: 0x060012C0 RID: 4800
		void AddRepairItemLog(string action, int itemId, int repairId, int customerId);

		// Token: 0x060012C1 RID: 4801
		void AddDocumentLog(string action, int documentId, string notes = "");

		// Token: 0x060012C2 RID: 4802
		void AddPartsRequestLog(string action, int requestId, string prm1 = "", string prm2 = "");

		// Token: 0x060012C3 RID: 4803
		void AddPartsRequestLog(int requestId, DateTime? prm1, DateTime? prm2);

		// Token: 0x060012C4 RID: 4804
		void AddPartsRequestLog(int requestId, decimal? prm1, decimal? prm2);

		// Token: 0x060012C5 RID: 4805
		void AddClientLog(string action, int clientId, [Optional] decimal summa = 0m, int repairId = 0);

		// Token: 0x060012C6 RID: 4806
		void AddClientCardLog(string action, int clientId, string value1, string value2);

		// Token: 0x060012C7 RID: 4807
		void AddClientCardLog(string action, int customerId, IPhone tel);

		// Token: 0x060012C8 RID: 4808
		void AddClientCardLog(string action, int clientId, bool boolValue);

		// Token: 0x060012C9 RID: 4809
		void StateChangeLog(workshop repair);

		// Token: 0x060012CA RID: 4810
		void AdminUpdateStatusLog(int repairId, int currentStatus, int nextStatus, decimal repairCost);

		// Token: 0x060012CB RID: 4811
		void AddRepairLog(string action, int repairId, users usr1 = null, users usr2 = null, offices off1 = null, offices off2 = null, works works = null, string[] prmStrings = null);

		// Token: 0x060012CC RID: 4812
		void AddRepairLog(int repairId, int informOption);

		// Token: 0x060012CD RID: 4813
		void AddRepairLog(int repairId, string color);

		// Token: 0x060012CE RID: 4814
		void AddRepairLog(int repairId, string action, bool value);

		// Token: 0x060012CF RID: 4815
		void AddRepairLog(int repairId, decimal summ);

		// Token: 0x060012D0 RID: 4816
		void AddRepairLog(string action, IWorkPartObject item);

		// Token: 0x060012D1 RID: 4817
		void AddRepairLog(string action, int repairId, string prm1, string prm2 = "");

		// Token: 0x060012D2 RID: 4818
		void AddUserLog(string action, int userId, string[] prm);

		// Token: 0x060012D3 RID: 4819
		void AddKassaLog(cash_orders order);

		// Token: 0x060012D4 RID: 4820
		void Save();

		// Token: 0x060012D5 RID: 4821
		Task SaveAsync();
	}
}
