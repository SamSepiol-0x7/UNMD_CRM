using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASC.Common.Interfaces;

namespace ASC.Interfaces
{
	// Token: 0x02000B38 RID: 2872
	public interface ISmsService
	{
		// Token: 0x060050D9 RID: 20697
		Task<IEnumerable<IAscSms>> LoadSmses(IPeriod period, SmsDirection direction);

		// Token: 0x060050DA RID: 20698
		Task<IEnumerable<IAscSms>> GetOutcoming(IPeriod period);

		// Token: 0x060050DB RID: 20699
		Task<IEnumerable<IAscSms>> GetIncoming(IPeriod period);

		// Token: 0x060050DC RID: 20700
		Dictionary<int, string> GetDirections();

		// Token: 0x060050DD RID: 20701
		Task<List<sms_templates>> GetTemplates();

		// Token: 0x060050DE RID: 20702
		Task<string> ConstructSms(string rawMsg, int repairId, string customerIoOrUrName);

		// Token: 0x060050DF RID: 20703
		void SaveSmsToDb(int? customerId, string phone, string message, int? statusCode = null, string smsId = null);

		// Token: 0x060050E0 RID: 20704
		Dictionary<int, string> GetSmsGateways();
	}
}
