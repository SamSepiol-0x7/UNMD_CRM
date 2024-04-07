using System;
using ASC.Common.Phone;
using ASC.SimpleClasses;

namespace ASC.Objects.Converters
{
	// Token: 0x0200091C RID: 2332
	public static class TelConverters
	{
		// Token: 0x06004817 RID: 18455 RVA: 0x001198A8 File Offset: 0x00117AA8
		public static Tel ToTel(this tel c)
		{
			return new Tel
			{
				Id = c.id,
				Phone = c.phone,
				PhoneClean = c.phone_clean,
				Mask = c.mask,
				Type = c.type,
				Note = c.note,
				Notify = c.notify
			};
		}

		// Token: 0x06004818 RID: 18456 RVA: 0x00119910 File Offset: 0x00117B10
		public static tel ConvertBack(this Tel t, int customerId)
		{
			return new tel
			{
				phone = t.Phone,
				phone_clean = Phone.ClearPhoneString(t.Phone),
				mask = t.Mask,
				type = t.Type,
				note = t.Note,
				customer = new int?(customerId),
				notify = t.Notify
			};
		}
	}
}
