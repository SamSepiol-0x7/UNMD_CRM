using System;
using System.Threading.Tasks;

namespace ASC.Services.Abstract
{
	// Token: 0x020007EB RID: 2027
	public interface IDeviceModelService
	{
		// Token: 0x06003CB0 RID: 15536
		Task<int> CreateDeviceModel(int deviceId, int deviceMakerId, string modelName);

		// Token: 0x06003CB1 RID: 15537
		Task<device_models> GetDeviceModel(int deviceId, int deviceMakerId, string modelName);
	}
}
