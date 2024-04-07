using System;
using System.Threading.Tasks;

namespace ASC.Services.Abstract
{
	// Token: 0x020007FA RID: 2042
	public interface IRepairReportEmailService
	{
		// Token: 0x06003D3D RID: 15677
		void AttachFile(byte[] attach);

		// Token: 0x06003D3E RID: 15678
		Task<bool> SendEmail();
	}
}
