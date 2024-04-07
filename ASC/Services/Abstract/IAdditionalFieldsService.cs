using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASC.Common.Interfaces;

namespace ASC.Services.Abstract
{
	// Token: 0x020007E3 RID: 2019
	public interface IAdditionalFieldsService
	{
		// Token: 0x06003C8A RID: 15498
		Task<int> CreateAdditionalField(fields field);

		// Token: 0x06003C8B RID: 15499
		Task<List<object>> GetDeviceFields(int deviceId);

		// Token: 0x06003C8C RID: 15500
		Task<List<IAttribute>> GetDeviceUiFields(IEnumerable<field_values> values, int deviceId);

		// Token: 0x06003C8D RID: 15501
		Task<List<IAttribute>> GetProductUiFields(int productId);

		// Token: 0x06003C8E RID: 15502
		Task<List<IAttribute>> GetProductUiFieldsByCategory(int categoryId);

		// Token: 0x06003C8F RID: 15503
		Task<List<fields>> GetAdditionalFields(bool? isStoreItemField, bool showArchive = false);

		// Token: 0x06003C90 RID: 15504
		List<object> GetDeviceAttributesReadonly(IEnumerable<field_values> values);

		// Token: 0x06003C91 RID: 15505
		Task UpdateAdditionalField(fields field);

		// Token: 0x06003C92 RID: 15506
		Task UpdateAdditionalFields(int repairId, IEnumerable<object> fields);

		// Token: 0x06003C93 RID: 15507
		Task<bool> AdditionalFieldsExist(bool isStoreItemField);
	}
}
