using System;
using System.Collections.ObjectModel;
using ASC.Common.Interfaces;
using ASC.Models;
using ASC.SimpleClasses;

namespace ASC.Objects.Converters
{
	// Token: 0x0200090C RID: 2316
	public class PackingListMapper
	{
		// Token: 0x060047F3 RID: 18419 RVA: 0x00117E5C File Offset: 0x0011605C
		public static PackingList PackingListConvert(p_lists doc)
		{
			if (doc == null)
			{
				return null;
			}
			PackingList packingList = new PackingList();
			packingList.Id = doc.id;
			packingList.Num = doc.num;
			invoice invoice = doc.invoice1;
			packingList.State = ((invoice != null) ? invoice.state : 0);
			packingList.Date = Localization.ToLocalTimeZone(doc.created);
			packingList.Items = new ObservableCollection<IInvoiceItem>(PackingListItemsMapper.PackingListItemsConverter(doc.invoice_items));
			packingList.Seller = doc.banks1.BankToSellerPaymentDetails();
			packingList.Customer = InvoiceModel.BankToCustomerPaymentDetails(doc.banks);
			packingList.Employee = new Employee
			{
				Id = doc.users.id,
				OfficeId = doc.users.office,
				FirstName = doc.users.name,
				LastName = doc.users.surname,
				Patronymic = doc.users.patronymic
			};
			packingList.Total = Fn.FormatSumm(doc.total);
			packingList.OfficeId = doc.office;
			packingList.Notes = doc.notes;
			packingList.Reason = doc.reason;
			packingList.InvoiceId = doc.invoice;
			packingList.Operator = doc.users.FioShort;
			return packingList;
		}

		// Token: 0x060047F4 RID: 18420 RVA: 0x000046B4 File Offset: 0x000028B4
		public PackingListMapper()
		{
		}
	}
}
