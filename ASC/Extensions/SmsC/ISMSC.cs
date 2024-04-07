using System;

namespace ASC.Extensions.SmsC
{
	// Token: 0x02000BB0 RID: 2992
	public interface ISMSC
	{
		// Token: 0x060053FA RID: 21498
		void SetLogin(string login);

		// Token: 0x060053FB RID: 21499
		void SetPassword(string password);

		// Token: 0x060053FC RID: 21500
		string[] send_sms(string phones, string message, int translit = 0, string time = "", int id = 0, int format = 0, string sender = "", string query = "", string[] files = null);

		// Token: 0x060053FD RID: 21501
		void send_sms_mail(string phones, string message, int translit = 0, string time = "", int id = 0, int format = 0, string sender = "");

		// Token: 0x1700159A RID: 5530
		// (get) Token: 0x060053FE RID: 21502
		string[] sms_cost { get; }

		// Token: 0x1700159B RID: 5531
		// (get) Token: 0x060053FF RID: 21503
		string[] status { get; }

		// Token: 0x1700159C RID: 5532
		// (get) Token: 0x06005400 RID: 21504
		string balance { get; }
	}
}
