using System;
using System.Collections.ObjectModel;
using ASC.Common.Interfaces;
using ASC.Models;
using ASC.SimpleClasses;

namespace ASC.Objects.Converters
{
	// Token: 0x02000908 RID: 2312
	public class InvoiceMapper
	{
		// Token: 0x060047EA RID: 18410 RVA: 0x00117BC4 File Offset: 0x00115DC4
		public static Invoice InvoiveConvert(invoice i)
		{
			return new Invoice
			{
				Id = i.id,
				Num = i.num,
				State = i.state,
				Date = Localization.ToLocalTimeZone(i.created),
				PaidDate = ((i.paid == null) ? null : new DateTime?(Localization.ToLocalTimeZone(i.paid.Value))),
				Items = new ObservableCollection<IInvoiceItem>(InvoiceItemsMapper.InvoiceItemsConverter(i.invoice_items)),
				Seller = i.banks.BankToSellerPaymentDetails(),
				Customer = InvoiceModel.BankToCustomerPaymentDetails(i.banks1),
				Employee = new Employee
				{
					Id = i.users.id,
					OfficeId = i.users.office,
					FirstName = i.users.name,
					LastName = i.users.surname,
					Patronymic = i.users.patronymic
				},
				Total = Fn.FormatSumm(i.total),
				OfficeId = i.office,
				Notes = i.notes,
				Operator = i.users.FioShort
			};
		}

		// Token: 0x060047EB RID: 18411 RVA: 0x000046B4 File Offset: 0x000028B4
		public InvoiceMapper()
		{
		}
	}
}
