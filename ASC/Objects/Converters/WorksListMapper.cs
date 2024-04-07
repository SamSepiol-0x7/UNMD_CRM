using System;
using System.Collections.ObjectModel;
using ASC.Common.Interfaces;
using ASC.Models;
using ASC.SimpleClasses;

namespace ASC.Objects.Converters
{
	// Token: 0x02000913 RID: 2323
	public class WorksListMapper
	{
		// Token: 0x06004802 RID: 18434 RVA: 0x00118B80 File Offset: 0x00116D80
		public static WorksList WorksListConvert(w_lists doc)
		{
			if (doc == null)
			{
				return null;
			}
			WorksList worksList = new WorksList();
			worksList.Id = doc.id;
			worksList.Num = doc.num;
			invoice invoice = doc.invoice1;
			worksList.State = ((invoice != null) ? invoice.state : 0);
			worksList.Date = Localization.ToLocalTimeZone(doc.created);
			worksList.Items = new ObservableCollection<IInvoiceItem>(InvoiceItemsMapper.WorksListItemsConverter(doc.invoice_items));
			worksList.Seller = doc.banks1.BankToSellerPaymentDetails();
			worksList.Customer = InvoiceModel.BankToCustomerPaymentDetails(doc.banks);
			worksList.Employee = new Employee
			{
				Id = doc.users.id,
				OfficeId = doc.users.office,
				FirstName = doc.users.name,
				LastName = doc.users.surname,
				Patronymic = doc.users.patronymic
			};
			worksList.Total = Fn.FormatSumm(doc.total);
			worksList.OfficeId = doc.office;
			worksList.Notes = doc.notes;
			worksList.Reason = doc.reason;
			worksList.InvoiceId = doc.invoice;
			worksList.Operator = doc.users.FioShort;
			return worksList;
		}

		// Token: 0x06004803 RID: 18435 RVA: 0x000046B4 File Offset: 0x000028B4
		public WorksListMapper()
		{
		}
	}
}
