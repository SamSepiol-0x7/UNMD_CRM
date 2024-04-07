using System;
using ASC.Common.Interfaces;

namespace ASC.Objects.Converters
{
	// Token: 0x02000909 RID: 2313
	public static class ManufacturerMapper
	{
		// Token: 0x060047EC RID: 18412 RVA: 0x00117D18 File Offset: 0x00115F18
		public static IManufacturer ToManufacturer(this device_makers d)
		{
			if (d == null)
			{
				return null;
			}
			return new Manufacturer
			{
				Id = d.id,
				Name = d.name
			};
		}

		// Token: 0x060047ED RID: 18413 RVA: 0x00117D48 File Offset: 0x00115F48
		public static device_makers ConvertBack(this IManufacturer d)
		{
			return new device_makers
			{
				id = d.Id,
				name = d.Name
			};
		}
	}
}
