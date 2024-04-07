using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Models;

namespace ASC.Interfaces
{
	// Token: 0x02000B2A RID: 2858
	public interface IWorkshopService
	{
		// Token: 0x06005070 RID: 20592
		Task<int> CreateRepair(workshop repair);

		// Token: 0x06005071 RID: 20593
		Task<devices> GetDevice(int deviceId);

		// Token: 0x06005072 RID: 20594
		Task UpdateDevice(IDevice dev);

		// Token: 0x06005073 RID: 20595
		Task UpdateDevice(int deviceId, string name);

		// Token: 0x06005074 RID: 20596
		Task<IEnumerable<IDevice>> GetActiveDevices();

		// Token: 0x06005075 RID: 20597
		Task<List<device_models>> GetModels(int makerId, int deviceType);

		// Token: 0x06005076 RID: 20598
		Task<IManufacturer> GetManufacturerByName(string name);

		// Token: 0x06005077 RID: 20599
		Task<IEnumerable<IManufacturer>> GetManufacturers(string companyList);

		// Token: 0x06005078 RID: 20600
		Task<IEnumerable<IManufacturer>> GetManufacturers(int deviceId);

		// Token: 0x06005079 RID: 20601
		Task<IDevice> GetRefillDevice();

		// Token: 0x0600507A RID: 20602
		Task<ICustomer> GetOrderCustomer(int repairId);

		// Token: 0x0600507B RID: 20603
		Task<int> GetRepairCustomerId(int repairId);

		// Token: 0x0600507C RID: 20604
		Task UpdateRepairCostAndWarranty(auseceEntities ctx, int repairId);

		// Token: 0x0600507D RID: 20605
		Task<decimal> TotalWorksCost(auseceEntities ctx, int repairId);

		// Token: 0x0600507E RID: 20606
		Task<decimal> TotalPartsCost(auseceEntities ctx, int repairId);

		// Token: 0x0600507F RID: 20607
		Task SaveBox(int repairId, int? boxId);

		// Token: 0x06005080 RID: 20608
		Task SaveIssuingMessage(int repairId, string msg);

		// Token: 0x06005081 RID: 20609
		Task SetRepairColor(int repairId, string color);

		// Token: 0x06005082 RID: 20610
		Task SaveWarrantyLabel(int repairId, string warrantyLabel);

		// Token: 0x06005083 RID: 20611
		Task UpdateInformStatus(int repairId, int status);

		// Token: 0x06005084 RID: 20612
		Task UpdateDiagnosticResult(workshop repair);

		// Token: 0x06005085 RID: 20613
		Task ChangeCustomer(int repairId, ICustomer customer);

		// Token: 0x06005086 RID: 20614
		Task ChangeMaster(int repairId, int? master);

		// Token: 0x06005087 RID: 20615
		Task ChangeManager(workshop repair);

		// Token: 0x06005088 RID: 20616
		Task ChangeOffice(workshop repair);

		// Token: 0x06005089 RID: 20617
		Task DeleteAsync(int repairId);

		// Token: 0x0600508A RID: 20618
		Task RestoreAsync(int repairId);

		// Token: 0x0600508B RID: 20619
		Task<workshop> GetRepair(int repairId);

		// Token: 0x0600508C RID: 20620
		Task<PreviousRepair> GetRepairInfo(int repairId);

		// Token: 0x0600508D RID: 20621
		Task<RepairPaymentInfo> GetRepairPaymentInfo(int repairId);

		// Token: 0x0600508E RID: 20622
		Task<RepairDeviceInfo> GetRepairDeviceInfo(int repairId);

		// Token: 0x0600508F RID: 20623
		Task<RepairMassEditModel> GetMassEditModel(int repairId);

		// Token: 0x06005090 RID: 20624
		Task UpdateRepairs(IList<RepairMassEditModel> items);
	}
}
