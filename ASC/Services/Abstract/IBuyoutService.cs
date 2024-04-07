using System;
using System.Threading.Tasks;
using DevExpress.XtraReports.UI;

namespace ASC.Services.Abstract
{
	// Token: 0x020007E7 RID: 2023
	public interface IBuyoutService
	{
		// Token: 0x06003C97 RID: 15511
		Task<buyout> GetByIdAsync(int buyoutId);

		// Token: 0x06003C98 RID: 15512
		Task<buyout> GetByDocumentIdAsync(int documentId);

		// Token: 0x06003C99 RID: 15513
		Task<int> MakeBuyout(docs document, store_items item, clients client, buyout customerDocument);

		// Token: 0x06003C9A RID: 15514
		string ConstructName(string type, string maker, string model);

		// Token: 0x06003C9B RID: 15515
		Task<XtraReport> CreateReport(int documentId);

		// Token: 0x06003C9C RID: 15516
		Task<docs> GetBuyoutDocumentAsync(int documentId);
	}
}
