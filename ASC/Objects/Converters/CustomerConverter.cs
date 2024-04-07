using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;
using ASC.Models;
using ASC.SimpleClasses;

namespace ASC.Objects.Converters
{
	// Token: 0x02000926 RID: 2342
	public static class CustomerConverter
	{
		// Token: 0x0600482A RID: 18474 RVA: 0x0011A78C File Offset: 0x0011898C
		public static CustomerCard Client2CustomerCard(this clients c)
		{
			if (c == null)
			{
				return new CustomerCard();
			}
			return new CustomerCard
			{
				Id = c.id,
				Created = c.created,
				Type = c.type,
				State = c.state,
				LastName = c.surname,
				FirstName = c.name,
				Patronymic = c.patronymic,
				UrName = c.ur_name,
				Phone = CustomerConverter.GetFirstCustomerTel(c),
				PhoneMask = CustomerConverter.GetFirstCustomerTelMask(c),
				IsRealizator = c.is_realizator,
				BalanceEnabled = c.balance_enable,
				Balance = Fn.FormatSumm(c.balance),
				IsBad = c.is_bad,
				IsRegular = c.is_regular,
				IsAgent = c.is_agent,
				IsDealer = c.is_dealer,
				VisitSource = c.visit_source,
				VisitSourceName = ((c.visit_sources == null) ? "" : c.visit_sources.name),
				RepairsCount = c.repairs,
				PurchasesCount = c.purchases,
				Address = c.address,
				Email = c.email,
				PriceCol = c.price_col,
				PriceColString = StoreModel.GetPriceColName(c.price_col),
				IgnoreCalls = c.ignore_calls,
				PreferCashless = c.prefer_cashless,
				TakeLong = c.take_long,
				Notes = c.notes,
				Birthday = c.birthday,
				PassportDate = c.passport_date,
				PassportNum = c.passport_num,
				PassportOrgan = c.passport_organ,
				Icq = c.icq,
				Whatsapp = c.whatsapp,
				Skype = c.skype,
				Viber = c.viber,
				Site = c.site,
				Telegram = c.telegram,
				WebPassword = c.web_password,
				PostIndex = c.post_index,
				Inn = c.INN,
				Kpp = c.KPP,
				Ogrn = c.OGRN,
				PhotoId = c.photo_id,
				Phones = CustomerConverter.FillPhones(c)
			};
		}

		// Token: 0x0600482B RID: 18475 RVA: 0x0011A9F0 File Offset: 0x00118BF0
		private static ObservableCollection<Tel> FillPhones(clients client)
		{
			if (client.tel != null && client.tel.Any<tel>())
			{
				return new ObservableCollection<Tel>((from c in client.tel
				select c.ToTel()).ToList<Tel>());
			}
			return new ObservableCollection<Tel>();
		}

		// Token: 0x0600482C RID: 18476 RVA: 0x0011AA4C File Offset: 0x00118C4C
		public static string GetFirstCustomerTel(clients c)
		{
			if (c.tel == null)
			{
				return string.Empty;
			}
			tel tel = c.tel.FirstOrDefault((tel p) => p.type == 1);
			if (tel != null)
			{
				return tel.phone;
			}
			return string.Empty;
		}

		// Token: 0x0600482D RID: 18477 RVA: 0x0011AAA4 File Offset: 0x00118CA4
		private static int GetFirstCustomerTelMask(clients c)
		{
			if (c.tel == null)
			{
				return 0;
			}
			tel tel = c.tel.FirstOrDefault((tel p) => p.type == 1);
			if (tel != null)
			{
				return tel.mask;
			}
			return 1;
		}

		// Token: 0x0600482E RID: 18478 RVA: 0x0011AAF4 File Offset: 0x00118CF4
		public static Customer Client2Customer(this clients c)
		{
			if (c == null)
			{
				return new Customer();
			}
			return new Customer
			{
				Id = c.id,
				Created = c.created,
				Type = c.type,
				State = c.state,
				LastName = c.surname,
				FirstName = c.name,
				Patronymic = c.patronymic,
				UrName = c.ur_name,
				Phone = CustomerConverter.GetFirstCustomerTel(c),
				IsRealizator = c.is_realizator,
				BalanceEnabled = c.balance_enable,
				IsBad = c.is_bad,
				IsRegular = c.is_regular,
				IsAgent = c.is_agent,
				IsDealer = c.is_dealer,
				RepairsCount = c.repairs,
				PurchasesCount = c.purchases,
				Address = c.address,
				Email = c.email,
				Balance = c.balance,
				PhotoId = c.photo_id
			};
		}

		// Token: 0x0600482F RID: 18479 RVA: 0x0011AC0C File Offset: 0x00118E0C
		public static clients Customer2Client(this Customer c)
		{
			clients clients = ClientsModel.SetDefaultValues(new clients());
			clients.id = c.Id;
			clients.created = c.Created;
			clients.type = c.Type;
			clients.state = c.State;
			clients.surname = c.LastName;
			clients.name = c.FirstName;
			clients.patronymic = c.Patronymic;
			clients.ur_name = c.UrName;
			clients.is_realizator = c.IsRealizator;
			clients.balance_enable = c.BalanceEnabled;
			clients.is_bad = c.IsBad;
			clients.is_regular = c.IsRegular;
			clients.is_agent = c.IsAgent;
			clients.is_dealer = c.IsDealer;
			clients.repairs = c.RepairsCount;
			clients.purchases = c.PurchasesCount;
			clients.address = c.Address;
			clients.email = c.Email;
			clients.photo_id = c.PhotoId;
			return clients;
		}

		// Token: 0x06004830 RID: 18480 RVA: 0x0011AD08 File Offset: 0x00118F08
		public static clients Customer2Client(this ICustomer c)
		{
			clients clients = ClientsModel.SetDefaultValues(new clients());
			clients.id = c.Id;
			clients.created = c.Created;
			clients.type = c.Type;
			clients.state = c.State;
			clients.surname = c.LastName;
			clients.name = c.FirstName;
			clients.patronymic = c.Patronymic;
			clients.ur_name = c.UrName;
			clients.is_realizator = c.IsRealizator;
			clients.balance_enable = c.BalanceEnabled;
			clients.is_bad = c.IsBad;
			clients.is_regular = c.IsRegular;
			clients.is_agent = c.IsAgent;
			clients.repairs = c.RepairsCount;
			clients.purchases = c.PurchasesCount;
			clients.phone = c.Phone;
			clients.photo_id = c.PhotoId;
			return clients;
		}

		// Token: 0x02000927 RID: 2343
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004831 RID: 18481 RVA: 0x0011ADEC File Offset: 0x00118FEC
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004832 RID: 18482 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06004833 RID: 18483 RVA: 0x0011AE04 File Offset: 0x00119004
			internal Tel <FillPhones>b__1_0(tel c)
			{
				return c.ToTel();
			}

			// Token: 0x06004834 RID: 18484 RVA: 0x00084148 File Offset: 0x00082348
			internal bool <GetFirstCustomerTel>b__2_0(tel p)
			{
				return p.type == 1;
			}

			// Token: 0x06004835 RID: 18485 RVA: 0x00084148 File Offset: 0x00082348
			internal bool <GetFirstCustomerTelMask>b__3_0(tel p)
			{
				return p.type == 1;
			}

			// Token: 0x04002E11 RID: 11793
			public static readonly CustomerConverter.<>c <>9 = new CustomerConverter.<>c();

			// Token: 0x04002E12 RID: 11794
			public static Func<tel, Tel> <>9__1_0;

			// Token: 0x04002E13 RID: 11795
			public static Func<tel, bool> <>9__2_0;

			// Token: 0x04002E14 RID: 11796
			public static Func<tel, bool> <>9__3_0;
		}
	}
}
