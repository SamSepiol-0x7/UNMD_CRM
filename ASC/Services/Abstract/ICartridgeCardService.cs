using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Objects;

namespace ASC.Services.Abstract
{
	// Token: 0x020007E9 RID: 2025
	public interface ICartridgeCardService
	{
		// Token: 0x06003C9E RID: 15518
		Task<ICartridgeCard> GetCartridgeCard(int cardId);

		// Token: 0x06003C9F RID: 15519
		Task<IEnumerable<ICartridgeCard>> GetCards(int makerId = 0, bool showArchive = false, string name = "");

		// Token: 0x06003CA0 RID: 15520
		Task<int> CreateCartridgeCard(CartridgeCard cartridgeCard);

		// Token: 0x06003CA1 RID: 15521
		Task<bool> IsUnique(string name, int makerId);

		// Token: 0x06003CA2 RID: 15522
		List<CartridgeColors> GetColors();

		// Token: 0x06003CA3 RID: 15523
		List<KeyValuePair<int, string>> GetMaterialTypes();
	}
}
