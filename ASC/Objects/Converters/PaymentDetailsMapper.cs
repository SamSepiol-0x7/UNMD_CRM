using System;

namespace ASC.Objects.Converters
{
	// Token: 0x0200090D RID: 2317
	public static class PaymentDetailsMapper
	{
		// Token: 0x060047F5 RID: 18421 RVA: 0x00117FA0 File Offset: 0x001161A0
		public static SellerPaymentDetails BankToSellerPaymentDetails(this banks b)
		{
			SellerPaymentDetails sellerPaymentDetails = new SellerPaymentDetails();
			sellerPaymentDetails.Id = b.id;
			sellerPaymentDetails.CompanyId = b.company.GetValueOrDefault();
			sellerPaymentDetails.Name = b.ur_name;
			sellerPaymentDetails.Inn = b.inn;
			sellerPaymentDetails.Kpp = b.kpp;
			sellerPaymentDetails.Address = b.address;
			sellerPaymentDetails.CorrespondentAccount = b.correspondent_account;
			sellerPaymentDetails.CheckingAccount = b.checking_account;
			sellerPaymentDetails.Bank = b.bank;
			sellerPaymentDetails.Bic = b.BIC;
			sellerPaymentDetails.Chief = b.chief;
			sellerPaymentDetails.Accountant = b.accountant;
			sellerPaymentDetails.Email = b.email;
			sellerPaymentDetails.Ogrn = b.ogrn;
			images images = b.images2;
			sellerPaymentDetails.Seal = ((images != null) ? images.img : null);
			images images2 = b.images1;
			sellerPaymentDetails.ChiefSignature = ((images2 != null) ? images2.img : null);
			images images3 = b.images;
			sellerPaymentDetails.AccountantSignature = ((images3 != null) ? images3.img : null);
			sellerPaymentDetails.IsArchive = b.archive;
			return sellerPaymentDetails;
		}
	}
}
