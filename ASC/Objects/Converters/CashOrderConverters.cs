using System;
using ASC.SimpleClasses;

namespace ASC.Objects.Converters
{
	// Token: 0x02000923 RID: 2339
	public static class CashOrderConverters
	{
		// Token: 0x06004823 RID: 18467 RVA: 0x0011A018 File Offset: 0x00118218
		public static CashInOrder ToCashInOrder(this cash_orders o)
		{
			CashInOrder cashInOrder = new CashInOrder();
			cashInOrder.Id = o.id;
			cashInOrder.Date = Localization.ToLocalTimeZone(o.created);
			cashInOrder.CompanyId = o.company;
			cashInOrder.OfficeId = o.office;
			cashInOrder.Type = o.type;
			cashInOrder.EmployeeId = o.user;
			cashInOrder.Summ = o.summa;
			cashInOrder.SummStr = o.summa_str;
			cashInOrder.InvoiceId = o.invoice;
			cashInOrder.CustomerId = o.client;
			cashInOrder.ToEmployeeId = o.to_user;
			cashInOrder.Reason = o.notes;
			cashInOrder.RepairId = o.repair;
			cashInOrder.DocumentId = o.document;
			cashInOrder.PhotoId = o.img;
			images images = o.images;
			cashInOrder.Photo = ((images != null) ? images.img : null);
			cashInOrder.PaymentSystem = o.payment_system;
			cashInOrder.CardFee = o.card_fee;
			cashInOrder.IsBackdate = o.is_backdate;
			cashInOrder.Customer = o.clients.Client2CustomerCard();
			invoice invoice = o.invoice1;
			cashInOrder.InvoiceNum = ((invoice != null) ? invoice.num : null);
			cashInOrder.CustomerEmail = o.customer_email;
			cashInOrder.FiscalDocumentNumber = o.fdn;
			cashInOrder.PaymentItemSign = o.payment_item_sign;
			CashInOrder cashInOrder2 = cashInOrder;
			if (o.pinpad_logs != null)
			{
				cashInOrder2.TermNum = o.pinpad_logs.TermNum;
				cashInOrder2.ClientCard = o.pinpad_logs.ClientCard;
				cashInOrder2.ClientExpiryDate = o.pinpad_logs.ClientExpiryDate;
				cashInOrder2.AuthCode = o.pinpad_logs.AuthCode;
				cashInOrder2.CardName = o.pinpad_logs.CardName;
			}
			return cashInOrder2;
		}

		// Token: 0x06004824 RID: 18468 RVA: 0x0011A1CC File Offset: 0x001183CC
		public static CashOutOrder ToCashOutOrder(this cash_orders o)
		{
			CashOutOrder cashOutOrder = new CashOutOrder();
			cashOutOrder.Id = o.id;
			cashOutOrder.Date = Localization.ToLocalTimeZone(o.created);
			cashOutOrder.CompanyId = o.company;
			cashOutOrder.OfficeId = o.office;
			cashOutOrder.Type = o.type;
			cashOutOrder.EmployeeId = o.user;
			cashOutOrder.Summ = o.summa;
			cashOutOrder.SummStr = o.summa_str;
			cashOutOrder.InvoiceId = o.invoice;
			cashOutOrder.CustomerId = o.client;
			cashOutOrder.ToEmployeeId = o.to_user;
			cashOutOrder.Reason = o.notes;
			cashOutOrder.RepairId = o.repair;
			cashOutOrder.DocumentId = o.document;
			cashOutOrder.PhotoId = o.img;
			images images = o.images;
			cashOutOrder.Photo = ((images != null) ? images.img : null);
			cashOutOrder.PaymentSystem = o.payment_system;
			cashOutOrder.CardFee = o.card_fee;
			cashOutOrder.IsBackdate = o.is_backdate;
			cashOutOrder.Customer = o.clients.Client2CustomerCard();
			cashOutOrder.CustomerEmail = o.customer_email;
			cashOutOrder.FiscalDocumentNumber = o.fdn;
			cashOutOrder.PaymentItemSign = o.payment_item_sign;
			CashOutOrder cashOutOrder2 = cashOutOrder;
			if (o.pinpad_logs != null)
			{
				cashOutOrder2.TermNum = o.pinpad_logs.TermNum;
				cashOutOrder2.ClientCard = o.pinpad_logs.ClientCard;
				cashOutOrder2.ClientExpiryDate = o.pinpad_logs.ClientExpiryDate;
				cashOutOrder2.AuthCode = o.pinpad_logs.AuthCode;
				cashOutOrder2.CardName = o.pinpad_logs.CardName;
			}
			return cashOutOrder2;
		}

		// Token: 0x06004825 RID: 18469 RVA: 0x0011A368 File Offset: 0x00118568
		public static CashOrdersLite ToCashOrdersLite(this cash_orders o)
		{
			CashOrdersLite result;
			try
			{
				CashOrdersLite cashOrdersLite = new CashOrdersLite();
				cashOrdersLite.id = o.id;
				cashOrdersLite.OfficeId = o.office;
				offices offices = o.offices;
				string officeName;
				if (offices != null)
				{
					if ((officeName = offices.name) != null)
					{
						goto IL_39;
					}
				}
				officeName = "";
				IL_39:
				cashOrdersLite.OfficeName = officeName;
				cashOrdersLite.created = Localization.ToLocalTimeZone(o.created);
				cashOrdersLite.type = o.type;
				users users = o.users1;
				string toUserLastName;
				if (users != null)
				{
					if ((toUserLastName = users.surname) != null)
					{
						goto IL_77;
					}
				}
				toUserLastName = "";
				IL_77:
				cashOrdersLite.ToUserLastName = toUserLastName;
				users users2 = o.users1;
				string toUserFirstName;
				if (users2 != null)
				{
					if ((toUserFirstName = users2.name) != null)
					{
						goto IL_98;
					}
				}
				toUserFirstName = "";
				IL_98:
				cashOrdersLite.ToUserFirstName = toUserFirstName;
				users users3 = o.users1;
				string toUserPatronymic;
				if (users3 != null)
				{
					if ((toUserPatronymic = users3.patronymic) != null)
					{
						goto IL_B9;
					}
				}
				toUserPatronymic = "";
				IL_B9:
				cashOrdersLite.ToUserPatronymic = toUserPatronymic;
				users users4 = o.users;
				string userLastName;
				if (users4 != null)
				{
					if ((userLastName = users4.surname) != null)
					{
						goto IL_DA;
					}
				}
				userLastName = "";
				IL_DA:
				cashOrdersLite.UserLastName = userLastName;
				users users5 = o.users;
				string userFirstName;
				if (users5 != null)
				{
					if ((userFirstName = users5.name) != null)
					{
						goto IL_FB;
					}
				}
				userFirstName = "";
				IL_FB:
				cashOrdersLite.UserFirstName = userFirstName;
				users users6 = o.users;
				string userPatronymic;
				if (users6 != null)
				{
					if ((userPatronymic = users6.patronymic) != null)
					{
						goto IL_11C;
					}
				}
				userPatronymic = "";
				IL_11C:
				cashOrdersLite.UserPatronymic = userPatronymic;
				users users7 = o.users;
				string username;
				if (users7 != null)
				{
					if ((username = users7.username) != null)
					{
						goto IL_13D;
					}
				}
				username = "";
				IL_13D:
				cashOrdersLite.username = username;
				cashOrdersLite.notes = o.notes;
				cashOrdersLite.payment_system = o.payment_system;
				cashOrdersLite.summa = o.summa;
				result = cashOrdersLite;
			}
			catch (Exception)
			{
				result = null;
			}
			return result;
		}
	}
}
