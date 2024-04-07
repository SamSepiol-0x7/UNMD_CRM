using System;
using ASC.Common.Interfaces;
using ASC.Common.Objects;

namespace ASC.Objects.Converters
{
	// Token: 0x02000917 RID: 2327
	public static class OfficeConverters
	{
		// Token: 0x06004808 RID: 18440 RVA: 0x00118ED0 File Offset: 0x001170D0
		public static IOffice ToOffice(this offices o)
		{
			return new Office
			{
				Id = o.id,
				Name = o.name,
				Created = o.created,
				Tel = o.phone,
				Tel2 = o.phone2,
				Address = o.address,
				Archive = (o.state == 0),
				Logo = o.logo,
				DefaultCompanyId = o.default_company,
				AdministratorId = o.administrator
			};
		}

		// Token: 0x06004809 RID: 18441 RVA: 0x00118F60 File Offset: 0x00117160
		public static IOfficeLookup ToOfficeLookup(this offices o)
		{
			return new OfficeDTO(o.id, o.name, o.address)
			{
				State = o.state
			};
		}
	}
}
