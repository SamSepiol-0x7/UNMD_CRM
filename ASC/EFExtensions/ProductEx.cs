using System;

namespace ASC.EFExtensions
{
	// Token: 0x02000BCD RID: 3021
	public static class ProductEx
	{
		// Token: 0x06005470 RID: 21616 RVA: 0x0016B998 File Offset: 0x00169B98
		public static bool NotInStock(this store_items item)
		{
			return item.Available < 1;
		}
	}
}
