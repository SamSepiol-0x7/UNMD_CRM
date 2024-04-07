using System;
using System.Collections.Generic;

namespace ASC.Interfaces
{
	// Token: 0x02000B4D RID: 2893
	public interface IOptions<T>
	{
		// Token: 0x170014E9 RID: 5353
		// (get) Token: 0x06005136 RID: 20790
		// (set) Token: 0x06005137 RID: 20791
		int Id { get; set; }

		// Token: 0x170014EA RID: 5354
		// (get) Token: 0x06005138 RID: 20792
		// (set) Token: 0x06005139 RID: 20793
		string Name { get; set; }

		// Token: 0x0600513A RID: 20794
		List<T> GetAllOptions();
	}
}
