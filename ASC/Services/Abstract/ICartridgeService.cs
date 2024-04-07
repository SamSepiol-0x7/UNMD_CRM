using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASC.Objects;

namespace ASC.Services.Abstract
{
	// Token: 0x020007EA RID: 2026
	public interface ICartridgeService
	{
		// Token: 0x06003CA4 RID: 15524
		Dictionary<int, string> GetHistoryOptions();

		// Token: 0x06003CA5 RID: 15525
		Task UpdateBox(int cartridgeId, int? boxId);

		// Token: 0x06003CA6 RID: 15526
		Task<Result> CreateCartridges(IEnumerable<Cartridge> cartridges, int companyId, int officeId, int paymentSystem, int customerId, int? masterId);

		// Token: 0x06003CA7 RID: 15527
		Task<List<Cartridge>> GetCartridges(List<int> ids);

		// Token: 0x06003CA8 RID: 15528
		Task<List<CartridgeEx>> GetCartridgesEx(List<int> ids);

		// Token: 0x06003CA9 RID: 15529
		Task<Cartridge> GetCartridge(int id);

		// Token: 0x06003CAA RID: 15530
		Task<Cartridge> GetCartridge(string serialNumber);

		// Token: 0x06003CAB RID: 15531
		Task<CartridgeReport> GetCartgidgesReport(int companyId, int officeId, int customerId, List<int> ids);

		// Token: 0x06003CAC RID: 15532
		Task<CartridgeReport> GetCartgidgeReport(int repairId);

		// Token: 0x06003CAD RID: 15533
		Task<CartridgeIssueReport> GetIssueCartridgeReport(List<int> ids);

		// Token: 0x06003CAE RID: 15534
		Task<CartridgeIssueReport> GetIssueCartridgeReport(int repairId);

		// Token: 0x06003CAF RID: 15535
		Task<Result> IssueCartridges(IEnumerable<CartridgeEx> cartridges, int paymentSystem);
	}
}
