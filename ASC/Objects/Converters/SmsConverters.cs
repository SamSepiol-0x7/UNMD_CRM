using System;

namespace ASC.Objects.Converters
{
	// Token: 0x02000920 RID: 2336
	public static class SmsConverters
	{
		// Token: 0x0600481E RID: 18462 RVA: 0x00119BC4 File Offset: 0x00117DC4
		public static AscSms ToAscSms(this out_sms c)
		{
			if (c == null)
			{
				return null;
			}
			AscSms ascSms = new AscSms
			{
				Id = c.id,
				Text = c.msg,
				Date = Localization.ToLocalTimeZone(c.created),
				Tel = c.phone,
				CustomerId = c.client
			};
			if (c.clients != null)
			{
				ascSms.Customer = c.clients.Client2Customer();
			}
			return ascSms;
		}

		// Token: 0x0600481F RID: 18463 RVA: 0x00119C38 File Offset: 0x00117E38
		public static AscSms ToAscSms(this in_sms c)
		{
			if (c == null)
			{
				return null;
			}
			return new AscSms
			{
				Id = c.id,
				Text = c.msg,
				Date = Localization.ToLocalTimeZone(c.date),
				Tel = c.callerid,
				Modem = c.modem
			};
		}
	}
}
