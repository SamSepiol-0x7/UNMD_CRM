using System;
using System.Collections.ObjectModel;
using ASC.Common.Interfaces;
using ASC.Models;
using ASC.SimpleClasses;

namespace ASC.Objects.Converters
{
	// Token: 0x02000912 RID: 2322
	public class VATInvoiceMapper
	{
		// Token: 0x06004800 RID: 18432 RVA: 0x00118A04 File Offset: 0x00116C04
		public static VATInvoice VATInvoiveConvert(vat_invoice doc)
		{
			if (doc == null)
			{
				return null;
			}
			VATInvoice vatinvoice = new VATInvoice(Auth.CurrencyModel.SelectedCurrency);
			vatinvoice.Id = doc.id;
			vatinvoice.Num = doc.num;
			invoice invoice = doc.invoice1;
			vatinvoice.State = ((invoice != null) ? invoice.state : 0);
			vatinvoice.Date = Localization.ToLocalTimeZone(doc.created);
			vatinvoice.Items = new ObservableCollection<IInvoiceItem>(InvoiceItemsMapper.VATInvoiceItemsConverter(doc.invoice_items));
			vatinvoice.Seller = doc.banks1.BankToSellerPaymentDetails();
			vatinvoice.Customer = InvoiceModel.BankToCustomerPaymentDetails(doc.banks);
			vatinvoice.Employee = new Employee
			{
				Id = doc.users.id,
				OfficeId = doc.users.office,
				FirstName = doc.users.name,
				LastName = doc.users.surname,
				Patronymic = doc.users.patronymic
			};
			vatinvoice.Total = Fn.FormatSumm(doc.total);
			vatinvoice.OfficeId = doc.office;
			vatinvoice.Notes = doc.notes;
			vatinvoice.Currency = doc.currency;
			vatinvoice.CurrencyCode = doc.currency_code;
			vatinvoice.StateContract = doc.state_contract;
			vatinvoice.PaymentOrder = doc.payment_order;
			vatinvoice.PaymentOrderDate = doc.payment_order_date;
			vatinvoice.InvoiceId = doc.invoice;
			vatinvoice.Operator = doc.users.FioShort;
			return vatinvoice;
		}

		// Token: 0x06004801 RID: 18433 RVA: 0x000046B4 File Offset: 0x000028B4
		public VATInvoiceMapper()
		{
		}
	}
}
