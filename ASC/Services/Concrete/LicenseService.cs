using System;
using System.Xml.Linq;
using ASC.Extensions;
using ASC.Services.Abstract;

namespace ASC.Services.Concrete
{
	// Token: 0x02000732 RID: 1842
	public class LicenseService : ILicenseService
	{
		// Token: 0x06003A60 RID: 14944 RVA: 0x000046B4 File Offset: 0x000028B4
		public LicenseService()
		{
		}

		// Token: 0x06003A61 RID: 14945 RVA: 0x000DFEF0 File Offset: 0x000DE0F0
		public DateTime ExpirationDate()
		{
			DateTime result;
			DateTime.TryParse(XElement.Parse(Auth.Config.key.Base64Decode()).Element("Expiration").Value, out result);
			return result;
		}

		// Token: 0x06003A62 RID: 14946 RVA: 0x000DFF30 File Offset: 0x000DE130
		public double ExpirationDays()
		{
			return (this.ExpirationDate() - DateTime.Now).TotalDays;
		}
	}
}
