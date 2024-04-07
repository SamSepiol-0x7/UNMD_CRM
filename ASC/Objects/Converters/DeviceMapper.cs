using System;

namespace ASC.Objects.Converters
{
	// Token: 0x02000903 RID: 2307
	public static class DeviceMapper
	{
		// Token: 0x060047DC RID: 18396 RVA: 0x00117790 File Offset: 0x00115990
		public static Device ToDevice(this devices d)
		{
			if (d == null)
			{
				return null;
			}
			return new Device
			{
				Id = d.id,
				CompanyList = d.company_list,
				ComplectList = d.complect_list,
				Enable = d.enable,
				FaultList = d.fault_list,
				LookList = d.look_list,
				Name = d.name,
				Position = d.position,
				Refill = d.refill
			};
		}

		// Token: 0x060047DD RID: 18397 RVA: 0x00117814 File Offset: 0x00115A14
		public static devices ConvertBack(this Device d)
		{
			return new devices
			{
				id = d.Id,
				company_list = d.CompanyList,
				complect_list = d.ComplectList,
				enable = d.Enable,
				fault_list = d.FaultList,
				look_list = d.LookList,
				name = d.Name,
				position = d.Position,
				refill = d.Refill
			};
		}
	}
}
