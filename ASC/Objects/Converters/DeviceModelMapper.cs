using System;
using ASC.SimpleClasses;

namespace ASC.Objects.Converters
{
	// Token: 0x02000904 RID: 2308
	public static class DeviceModelMapper
	{
		// Token: 0x060047DE RID: 18398 RVA: 0x00117894 File Offset: 0x00115A94
		public static IdNameClass ToIdName(this device_models d)
		{
			return new IdNameClass(d.id, d.name);
		}
	}
}
