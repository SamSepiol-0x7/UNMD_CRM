using System;
using System.Threading.Tasks;
using ASC.Common.Interfaces;

namespace ASC.Services.Abstract
{
	// Token: 0x02000807 RID: 2055
	public interface IWorkshopPartService
	{
		// Token: 0x06003D6E RID: 15726
		Task AddPart(IWorkPartObject product);

		// Token: 0x06003D6F RID: 15727
		Task UpdatePart(IWorkPartObject item);

		// Token: 0x06003D70 RID: 15728
		Task RemovePart(IWorkPartObject item);
	}
}
