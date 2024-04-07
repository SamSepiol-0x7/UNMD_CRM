using System;
using System.Runtime.InteropServices;

namespace ASC.Interfaces
{
	// Token: 0x02000B47 RID: 2887
	public interface IMyItemSelect
	{
		// Token: 0x0600512C RID: 20780
		void AddProductFromEmployeeCart(store_int_reserve reserve, int count = 1);

		// Token: 0x0600512D RID: 20781
		void AddProductDirectFromStore(store_items product, int count = 1, [Optional] decimal price = 0m);
	}
}
