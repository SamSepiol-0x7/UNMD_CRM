using System;
using ASC.Common.Interfaces;

namespace ASC.Objects.Converters
{
	// Token: 0x02000916 RID: 2326
	public static class NotificationConverters
	{
		// Token: 0x06004806 RID: 18438 RVA: 0x00118D58 File Offset: 0x00116F58
		public static IAscNotification ToAscNotification(this notifications n)
		{
			AscNotification ascNotification = new AscNotification();
			ascNotification.Id = n.id;
			ascNotification.Created = Localization.ToLocalTimeZone(n.created);
			ascNotification.Type = n.type;
			ascNotification.CustomerId = n.customer;
			ascNotification.EmployeeId = n.employee;
			ascNotification.TaskId = n.task_id;
			ascNotification.RepairId = n.repair_id;
			ascNotification.SmsId = n.sms_id;
			ascNotification.RequestId = n.request_id;
			ascNotification.BuyPartRequestId = n.part_request_id;
			ascNotification.Subject = n.subject;
			ascNotification.Text = n.text;
			ascNotification.Tel = n.tel;
			ascNotification.Readed = n.status;
			ascNotification.SetColor();
			return ascNotification;
		}

		// Token: 0x06004807 RID: 18439 RVA: 0x00118E20 File Offset: 0x00117020
		public static notifications BackToNotification(this IAscNotification n)
		{
			return new notifications
			{
				created = n.Created,
				type = n.Type,
				customer = n.CustomerId,
				employee = n.EmployeeId,
				task_id = n.TaskId,
				repair_id = n.RepairId,
				sms_id = n.SmsId,
				request_id = n.RequestId,
				part_request_id = n.BuyPartRequestId,
				subject = n.Subject,
				text = n.Text,
				tel = n.Tel,
				status = n.Readed
			};
		}
	}
}
