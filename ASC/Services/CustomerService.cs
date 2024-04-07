using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Common.Models;
using ASC.DAL;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Objects.Converters;
using ASC.SimpleClasses;

namespace ASC.Services
{
	// Token: 0x0200064F RID: 1615
	public class CustomerService : ICustomerService
	{
		// Token: 0x0600382C RID: 14380 RVA: 0x000C8D88 File Offset: 0x000C6F88
		public CustomerService(IContextFactory contextFactory)
		{
			this._contextFactory = contextFactory;
		}

		// Token: 0x0600382D RID: 14381 RVA: 0x000C8DA4 File Offset: 0x000C6FA4
		public Task<IEnumerable<ICustomer>> GetCustomers(int clientType, int visitSource, string query, bool showArchive = false)
		{
			CustomerService.<GetCustomers>d__2 <GetCustomers>d__;
			<GetCustomers>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<ICustomer>>.Create();
			<GetCustomers>d__.<>4__this = this;
			<GetCustomers>d__.clientType = clientType;
			<GetCustomers>d__.visitSource = visitSource;
			<GetCustomers>d__.query = query;
			<GetCustomers>d__.showArchive = showArchive;
			<GetCustomers>d__.<>1__state = -1;
			<GetCustomers>d__.<>t__builder.Start<CustomerService.<GetCustomers>d__2>(ref <GetCustomers>d__);
			return <GetCustomers>d__.<>t__builder.Task;
		}

		// Token: 0x0600382E RID: 14382 RVA: 0x000C8E08 File Offset: 0x000C7008
		private Func<Customer, string> ClientsOrder()
		{
			return delegate(Customer t)
			{
				if (t.Type == 1 && t.UrName != null)
				{
					return t.UrName;
				}
				return t.LastName;
			};
		}

		// Token: 0x0600382F RID: 14383 RVA: 0x000C8E34 File Offset: 0x000C7034
		private static Expression<Func<clients, bool>> CustomerTextSearch(string query)
		{
			string[] words = new string[0];
			if (!string.IsNullOrEmpty(query))
			{
				words = query.Trim().Split(new char[]
				{
					' '
				});
			}
			if (words.Length >= 2)
			{
				return (clients c) => words.Contains(c.name) || words.Contains(c.surname) || words.Contains(c.patronymic) || words.Contains(c.ur_name);
			}
			return (clients c) => c.name.Contains(query) || c.surname.Contains(query) || c.patronymic.Contains(query) || c.ur_name.Contains(query) || c.tel.Any((tel t) => t.phone_clean.Contains(query)) || c.tel.Any((tel t) => t.note.Contains(query)) || c.banks.Any((banks b) => b.ur_name.Contains(query));
		}

		// Token: 0x06003830 RID: 14384 RVA: 0x000C93A8 File Offset: 0x000C75A8
		public Task UpdateRepairsCount(int customerId)
		{
			CustomerService.<UpdateRepairsCount>d__5 <UpdateRepairsCount>d__;
			<UpdateRepairsCount>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<UpdateRepairsCount>d__.<>4__this = this;
			<UpdateRepairsCount>d__.customerId = customerId;
			<UpdateRepairsCount>d__.<>1__state = -1;
			<UpdateRepairsCount>d__.<>t__builder.Start<CustomerService.<UpdateRepairsCount>d__5>(ref <UpdateRepairsCount>d__);
			return <UpdateRepairsCount>d__.<>t__builder.Task;
		}

		// Token: 0x06003831 RID: 14385 RVA: 0x000C93F4 File Offset: 0x000C75F4
		public Task<clients> GetByEmail(string email)
		{
			CustomerService.<GetByEmail>d__6 <GetByEmail>d__;
			<GetByEmail>d__.<>t__builder = AsyncTaskMethodBuilder<clients>.Create();
			<GetByEmail>d__.email = email;
			<GetByEmail>d__.<>1__state = -1;
			<GetByEmail>d__.<>t__builder.Start<CustomerService.<GetByEmail>d__6>(ref <GetByEmail>d__);
			return <GetByEmail>d__.<>t__builder.Task;
		}

		// Token: 0x06003832 RID: 14386 RVA: 0x000C9438 File Offset: 0x000C7638
		public Task<List<clients>> GetCustomersAsync()
		{
			CustomerService.<GetCustomersAsync>d__7 <GetCustomersAsync>d__;
			<GetCustomersAsync>d__.<>t__builder = AsyncTaskMethodBuilder<List<clients>>.Create();
			<GetCustomersAsync>d__.<>1__state = -1;
			<GetCustomersAsync>d__.<>t__builder.Start<CustomerService.<GetCustomersAsync>d__7>(ref <GetCustomersAsync>d__);
			return <GetCustomersAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06003833 RID: 14387 RVA: 0x000C9474 File Offset: 0x000C7674
		public Task<clients> GetCustomerAsync(int customerId)
		{
			CustomerService.<GetCustomerAsync>d__8 <GetCustomerAsync>d__;
			<GetCustomerAsync>d__.<>t__builder = AsyncTaskMethodBuilder<clients>.Create();
			<GetCustomerAsync>d__.customerId = customerId;
			<GetCustomerAsync>d__.<>1__state = -1;
			<GetCustomerAsync>d__.<>t__builder.Start<CustomerService.<GetCustomerAsync>d__8>(ref <GetCustomerAsync>d__);
			return <GetCustomerAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06003834 RID: 14388 RVA: 0x000C94B8 File Offset: 0x000C76B8
		public Task<ICustomer> GetCustomerCardAsync(int customerId)
		{
			CustomerService.<GetCustomerCardAsync>d__9 <GetCustomerCardAsync>d__;
			<GetCustomerCardAsync>d__.<>t__builder = AsyncTaskMethodBuilder<ICustomer>.Create();
			<GetCustomerCardAsync>d__.<>4__this = this;
			<GetCustomerCardAsync>d__.customerId = customerId;
			<GetCustomerCardAsync>d__.<>1__state = -1;
			<GetCustomerCardAsync>d__.<>t__builder.Start<CustomerService.<GetCustomerCardAsync>d__9>(ref <GetCustomerCardAsync>d__);
			return <GetCustomerCardAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06003835 RID: 14389 RVA: 0x000C9504 File Offset: 0x000C7704
		public Task<List<tel>> GetPhonesAsync(int customerId)
		{
			CustomerService.<GetPhonesAsync>d__10 <GetPhonesAsync>d__;
			<GetPhonesAsync>d__.<>t__builder = AsyncTaskMethodBuilder<List<tel>>.Create();
			<GetPhonesAsync>d__.customerId = customerId;
			<GetPhonesAsync>d__.<>1__state = -1;
			<GetPhonesAsync>d__.<>t__builder.Start<CustomerService.<GetPhonesAsync>d__10>(ref <GetPhonesAsync>d__);
			return <GetPhonesAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06003836 RID: 14390 RVA: 0x000C9548 File Offset: 0x000C7748
		public Task<IEnumerable<logs>> GetHistory(int customerId, IPeriod period)
		{
			DateTime from = period.From;
			DateTime to = period.To.Date.AddDays(1.0).AddSeconds(-1.0);
			Task<IEnumerable<logs>> allAsync;
			using (GenericRepository<logs> genericRepository = new GenericRepository<logs>())
			{
				genericRepository.AsNoTracking();
				allAsync = genericRepository.GetAllAsync((logs l) => l.client == (int?)customerId && l.created >= (DateTime?)from && l.created <= (DateTime?)to, delegate(IQueryable<logs> l)
				{
					return from c in l
					orderby c.id descending
					select c;
				}, "users");
			}
			return allAsync;
		}

		// Token: 0x06003837 RID: 14391 RVA: 0x000C972C File Offset: 0x000C792C
		public Task<IEnumerable<balance>> GetBalanceDetails(int customerId)
		{
			Task<IEnumerable<balance>> allAsync;
			using (GenericRepository<balance> genericRepository = new GenericRepository<balance>())
			{
				allAsync = genericRepository.GetAllAsync((balance b) => b.client == customerId, delegate(IQueryable<balance> b)
				{
					return from o in b
					orderby o.id descending
					select o;
				}, "clients,users,offices,dealer_payments");
			}
			return allAsync;
		}

		// Token: 0x06003838 RID: 14392 RVA: 0x000C97F4 File Offset: 0x000C79F4
		public Task<IEnumerable<workshop>> GetRepairs(int customerId, IPeriod period, int repairStatus)
		{
			CustomerService.<GetRepairs>d__13 <GetRepairs>d__;
			<GetRepairs>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<workshop>>.Create();
			<GetRepairs>d__.<>4__this = this;
			<GetRepairs>d__.customerId = customerId;
			<GetRepairs>d__.period = period;
			<GetRepairs>d__.repairStatus = repairStatus;
			<GetRepairs>d__.<>1__state = -1;
			<GetRepairs>d__.<>t__builder.Start<CustomerService.<GetRepairs>d__13>(ref <GetRepairs>d__);
			return <GetRepairs>d__.<>t__builder.Task;
		}

		// Token: 0x06003839 RID: 14393 RVA: 0x000C9850 File Offset: 0x000C7A50
		public Task<List<CashOrdersLite>> GetOrders(int customerId)
		{
			Task<List<CashOrdersLite>> result;
			using (auseceEntities auseceEntities = new auseceEntities(true))
			{
				result = (from o in auseceEntities.cash_orders.AsNoTracking().Select(KassaModel.OrdersLite())
				orderby o.id
				where o.ClientId == (int?)customerId
				orderby o.id descending
				select o).ToListAsync<CashOrdersLite>();
			}
			return result;
		}

		// Token: 0x0600383A RID: 14394 RVA: 0x000C99A4 File Offset: 0x000C7BA4
		public Task<IEnumerable<store_sales>> GetPurchases(int customerId)
		{
			Task<IEnumerable<store_sales>> allAsync;
			using (GenericRepository<store_sales> genericRepository = new GenericRepository<store_sales>())
			{
				allAsync = genericRepository.GetAllAsync((store_sales d) => d.docs.dealer == (int?)customerId && d.docs.type == 2, delegate(IQueryable<store_sales> l)
				{
					return from c in l
					orderby c.docs.id descending
					select c;
				}, "docs,store_items,users");
			}
			return allAsync;
		}

		// Token: 0x0600383B RID: 14395 RVA: 0x000C9AD4 File Offset: 0x000C7CD4
		public Task<IEnumerable<RepairCard>> GetActiveRepairs(int customerId)
		{
			CustomerService.<GetActiveRepairs>d__16 <GetActiveRepairs>d__;
			<GetActiveRepairs>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<RepairCard>>.Create();
			<GetActiveRepairs>d__.<>4__this = this;
			<GetActiveRepairs>d__.customerId = customerId;
			<GetActiveRepairs>d__.<>1__state = -1;
			<GetActiveRepairs>d__.<>t__builder.Start<CustomerService.<GetActiveRepairs>d__16>(ref <GetActiveRepairs>d__);
			return <GetActiveRepairs>d__.<>t__builder.Task;
		}

		// Token: 0x0600383C RID: 14396 RVA: 0x000C9B20 File Offset: 0x000C7D20
		public Task<IEnumerable<Invoice>> GetInvoices(int customerId, IPeriod period)
		{
			CustomerService.<GetInvoices>d__17 <GetInvoices>d__;
			<GetInvoices>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<Invoice>>.Create();
			<GetInvoices>d__.customerId = customerId;
			<GetInvoices>d__.period = period;
			<GetInvoices>d__.<>1__state = -1;
			<GetInvoices>d__.<>t__builder.Start<CustomerService.<GetInvoices>d__17>(ref <GetInvoices>d__);
			return <GetInvoices>d__.<>t__builder.Task;
		}

		// Token: 0x0600383D RID: 14397 RVA: 0x000C9B6C File Offset: 0x000C7D6C
		public void SaveCustomer(CustomerCard c)
		{
			using (auseceEntities auseceEntities = new auseceEntities(true))
			{
				clients clients = auseceEntities.clients.Find(new object[]
				{
					c.Id
				});
				this.LogChanges(clients, c);
				clients.state = c.State;
				clients.type = c.Type;
				clients.surname = c.LastName;
				clients.name = c.FirstName;
				clients.patronymic = c.Patronymic;
				clients.ur_name = c.UrName;
				clients.is_bad = c.IsBad;
				clients.is_realizator = c.IsRealizator;
				clients.is_regular = c.IsRegular;
				clients.is_agent = c.IsAgent;
				clients.is_dealer = c.IsDealer;
				clients.visit_source = c.VisitSource;
				clients.balance_enable = c.BalanceEnabled;
				clients.address = c.Address;
				clients.email = c.Email;
				clients.memorial = c.Memorial;
				clients.web_password = c.WebPassword;
				clients.price_col = c.PriceCol;
				clients.ignore_calls = c.IgnoreCalls;
				clients.prefer_cashless = c.PreferCashless;
				clients.take_long = c.TakeLong;
				clients.notes = c.Notes;
				clients.passport_date = c.PassportDate;
				clients.passport_num = c.PassportNum;
				clients.passport_organ = c.PassportOrgan;
				clients.birthday = c.Birthday;
				clients.icq = c.Icq;
				clients.whatsapp = c.Whatsapp;
				clients.site = c.Site;
				clients.telegram = c.Telegram;
				clients.skype = c.Skype;
				clients.viber = c.Viber;
				clients.post_index = c.PostIndex;
				clients.INN = c.Inn;
				clients.OGRN = c.Ogrn;
				clients.KPP = c.Kpp;
				auseceEntities.SaveChanges();
			}
		}

		// Token: 0x0600383E RID: 14398 RVA: 0x000C9D88 File Offset: 0x000C7F88
		private void LogChanges(clients original, CustomerCard current)
		{
			HistoryV2 historyV = new HistoryV2();
			if (original == null)
			{
				return;
			}
			if (original.email != current.Email)
			{
				historyV.AddClientCardLog("EmailChanged", current.Id, original.email, current.Email);
			}
			if (original.skype != current.Skype)
			{
				historyV.AddClientCardLog("SkypeChanged", current.Id, original.skype, current.Skype);
			}
			if (original.icq != current.Icq)
			{
				historyV.AddClientCardLog("IcqChanged", current.Id, original.icq, current.Icq);
			}
			if (original.viber != current.Viber)
			{
				historyV.AddClientCardLog("ViberChanged", current.Id, original.viber, current.Viber);
			}
			if (original.whatsapp != current.Whatsapp)
			{
				historyV.AddClientCardLog("WhatsAppChanged", current.Id, original.whatsapp, current.Whatsapp);
			}
			if (original.address != current.Address)
			{
				historyV.AddClientCardLog("AddressChanged", current.Id, original.address, current.Address);
			}
			if (original.ur_name != current.UrName)
			{
				historyV.AddClientCardLog("UrNameChanged", current.Id, original.ur_name, current.UrName);
			}
			if (original.name != current.FirstName)
			{
				historyV.AddClientCardLog("NameChanged", current.Id, original.name, current.FirstName);
			}
			if (original.surname != current.LastName)
			{
				historyV.AddClientCardLog("SurNameChanged", current.Id, original.surname, current.LastName);
			}
			if (original.patronymic != current.Patronymic)
			{
				historyV.AddClientCardLog("PatronymicChanged", current.Id, original.patronymic, current.Patronymic);
			}
			if (original.is_bad != current.IsBad)
			{
				historyV.AddClientCardLog("badChanged", current.Id, current.IsBad);
			}
			if (original.is_regular != current.IsRegular)
			{
				historyV.AddClientCardLog("regularChanged", current.Id, current.IsRegular);
			}
			if (original.type != current.Type)
			{
				historyV.AddClientCardLog("TypeChanged", current.Id, current.IsUr);
			}
			if (original.is_dealer != current.IsDealer)
			{
				historyV.AddClientCardLog("DealerChanged", current.Id, current.IsDealer);
			}
			if (original.state != current.State)
			{
				historyV.AddClientCardLog("ArchiveChanged", current.Id, current.IsArchive);
			}
			historyV.Save();
		}

		// Token: 0x0600383F RID: 14399 RVA: 0x000CA044 File Offset: 0x000C8244
		public Task<IEnumerable<PaymentDetails>> GetPaymentDetailsAsync(int customerId)
		{
			CustomerService.<GetPaymentDetailsAsync>d__20 <GetPaymentDetailsAsync>d__;
			<GetPaymentDetailsAsync>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<PaymentDetails>>.Create();
			<GetPaymentDetailsAsync>d__.customerId = customerId;
			<GetPaymentDetailsAsync>d__.<>1__state = -1;
			<GetPaymentDetailsAsync>d__.<>t__builder.Start<CustomerService.<GetPaymentDetailsAsync>d__20>(ref <GetPaymentDetailsAsync>d__);
			return <GetPaymentDetailsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06003840 RID: 14400 RVA: 0x000CA088 File Offset: 0x000C8288
		public Task<int> CreatePaymentDetailsAsync(IPaymentDetails details)
		{
			CustomerService.<CreatePaymentDetailsAsync>d__21 <CreatePaymentDetailsAsync>d__;
			<CreatePaymentDetailsAsync>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<CreatePaymentDetailsAsync>d__.details = details;
			<CreatePaymentDetailsAsync>d__.<>1__state = -1;
			<CreatePaymentDetailsAsync>d__.<>t__builder.Start<CustomerService.<CreatePaymentDetailsAsync>d__21>(ref <CreatePaymentDetailsAsync>d__);
			return <CreatePaymentDetailsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06003841 RID: 14401 RVA: 0x000CA0CC File Offset: 0x000C82CC
		public Task<int> CreateCustomer(CustomerCard c)
		{
			CustomerService.<CreateCustomer>d__22 <CreateCustomer>d__;
			<CreateCustomer>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<CreateCustomer>d__.c = c;
			<CreateCustomer>d__.<>1__state = -1;
			<CreateCustomer>d__.<>t__builder.Start<CustomerService.<CreateCustomer>d__22>(ref <CreateCustomer>d__);
			return <CreateCustomer>d__.<>t__builder.Task;
		}

		// Token: 0x06003842 RID: 14402 RVA: 0x000CA110 File Offset: 0x000C8310
		public IEnumerable<ICustomerType> GetAllCustomerTypes()
		{
			return new List<ClientTypes>
			{
				new ClientTypes(CustomerModel.Type.Regular, Lang.t("RegularClients")),
				new ClientTypes(CustomerModel.Type.Dealer, Lang.t("Dealers")),
				new ClientTypes(CustomerModel.Type.All, Lang.t("AllClients")),
				new ClientTypes(CustomerModel.Type.Bad, Lang.t("BadClients")),
				new ClientTypes(CustomerModel.Type.Company, Lang.t("Companies")),
				new ClientTypes(CustomerModel.Type.Agent, Lang.t("Agents")),
				new ClientTypes(CustomerModel.Type.Realizator, Lang.t("Realizators"))
			};
		}

		// Token: 0x06003843 RID: 14403 RVA: 0x000CA1BC File Offset: 0x000C83BC
		public ICustomerType GetCustomerType(CustomerModel.Type type)
		{
			return this.GetAllCustomerTypes().FirstOrDefault((ICustomerType t) => t.Id == (int)type);
		}

		// Token: 0x06003844 RID: 14404 RVA: 0x000CA1F0 File Offset: 0x000C83F0
		public IEnumerable<ICustomerType> GetCustomerTypes()
		{
			List<ClientTypes> list = new List<ClientTypes>
			{
				new ClientTypes(CustomerModel.Type.Regular, Lang.t("RegularClients")),
				new ClientTypes(CustomerModel.Type.Dealer, Lang.t("Dealers")),
				new ClientTypes(CustomerModel.Type.All, Lang.t("AllClients")),
				new ClientTypes(CustomerModel.Type.Bad, Lang.t("BadClients")),
				new ClientTypes(CustomerModel.Type.Company, Lang.t("Companies")),
				new ClientTypes(CustomerModel.Type.Agent, Lang.t("Agents"))
			};
			if (Auth.Config.realizator_enable)
			{
				list.Add(new ClientTypes(CustomerModel.Type.Realizator, Lang.t("Realizators")));
			}
			return (from t in list
			orderby t.Name
			select t).ToList<ClientTypes>();
		}

		// Token: 0x06003845 RID: 14405 RVA: 0x000CA2D4 File Offset: 0x000C84D4
		public Task<int> CountRepairs(int customerId)
		{
			CustomerService.<CountRepairs>d__26 <CountRepairs>d__;
			<CountRepairs>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<CountRepairs>d__.<>4__this = this;
			<CountRepairs>d__.customerId = customerId;
			<CountRepairs>d__.<>1__state = -1;
			<CountRepairs>d__.<>t__builder.Start<CustomerService.<CountRepairs>d__26>(ref <CountRepairs>d__);
			return <CountRepairs>d__.<>t__builder.Task;
		}

		// Token: 0x06003846 RID: 14406 RVA: 0x000CA320 File Offset: 0x000C8520
		public Task<int> CountPurchases(int customerId)
		{
			CustomerService.<CountPurchases>d__27 <CountPurchases>d__;
			<CountPurchases>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<CountPurchases>d__.<>4__this = this;
			<CountPurchases>d__.customerId = customerId;
			<CountPurchases>d__.<>1__state = -1;
			<CountPurchases>d__.<>t__builder.Start<CustomerService.<CountPurchases>d__27>(ref <CountPurchases>d__);
			return <CountPurchases>d__.<>t__builder.Task;
		}

		// Token: 0x040021C3 RID: 8643
		private readonly IContextFactory _contextFactory;

		// Token: 0x02000650 RID: 1616
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x06003847 RID: 14407 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x040021C4 RID: 8644
			public int visitSource;
		}

		// Token: 0x02000651 RID: 1617
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003848 RID: 14408 RVA: 0x000CA36C File Offset: 0x000C856C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003849 RID: 14409 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x0600384A RID: 14410 RVA: 0x000CA384 File Offset: 0x000C8584
			internal Customer <GetCustomers>b__2_9(clients c)
			{
				return c.Client2Customer();
			}

			// Token: 0x0600384B RID: 14411 RVA: 0x000CA398 File Offset: 0x000C8598
			internal string <ClientsOrder>b__3_0(Customer t)
			{
				if (t.Type == 1 && t.UrName != null)
				{
					return t.UrName;
				}
				return t.LastName;
			}

			// Token: 0x0600384C RID: 14412 RVA: 0x000CA3C4 File Offset: 0x000C85C4
			internal IOrderedQueryable<logs> <GetHistory>b__11_1(IQueryable<logs> l)
			{
				return from c in l
				orderby c.id descending
				select c;
			}

			// Token: 0x0600384D RID: 14413 RVA: 0x000CA410 File Offset: 0x000C8610
			internal IOrderedQueryable<balance> <GetBalanceDetails>b__12_1(IQueryable<balance> b)
			{
				return from o in b
				orderby o.id descending
				select o;
			}

			// Token: 0x0600384E RID: 14414 RVA: 0x000CA45C File Offset: 0x000C865C
			internal IOrderedQueryable<store_sales> <GetPurchases>b__15_1(IQueryable<store_sales> l)
			{
				return from c in l
				orderby c.docs.id descending
				select c;
			}

			// Token: 0x0600384F RID: 14415 RVA: 0x000CA4BC File Offset: 0x000C86BC
			internal RepairCard <GetActiveRepairs>b__16_0(workshop r)
			{
				return r.ToRepairCard();
			}

			// Token: 0x06003850 RID: 14416 RVA: 0x000CA4D0 File Offset: 0x000C86D0
			internal IOrderedQueryable<invoice> <GetInvoices>b__17_2(IQueryable<invoice> i)
			{
				return from d in i
				orderby d.id descending
				select d;
			}

			// Token: 0x06003851 RID: 14417 RVA: 0x000CA51C File Offset: 0x000C871C
			internal string <GetCustomerTypes>b__25_0(ClientTypes t)
			{
				return t.Name;
			}

			// Token: 0x040021C5 RID: 8645
			public static readonly CustomerService.<>c <>9 = new CustomerService.<>c();

			// Token: 0x040021C6 RID: 8646
			public static Func<clients, Customer> <>9__2_9;

			// Token: 0x040021C7 RID: 8647
			public static Func<Customer, string> <>9__3_0;

			// Token: 0x040021C8 RID: 8648
			public static Func<IQueryable<logs>, IOrderedQueryable<logs>> <>9__11_1;

			// Token: 0x040021C9 RID: 8649
			public static Func<IQueryable<balance>, IOrderedQueryable<balance>> <>9__12_1;

			// Token: 0x040021CA RID: 8650
			public static Func<IQueryable<store_sales>, IOrderedQueryable<store_sales>> <>9__15_1;

			// Token: 0x040021CB RID: 8651
			public static Func<workshop, RepairCard> <>9__16_0;

			// Token: 0x040021CC RID: 8652
			public static Func<IQueryable<invoice>, IOrderedQueryable<invoice>> <>9__17_2;

			// Token: 0x040021CD RID: 8653
			public static Func<ClientTypes, string> <>9__25_0;
		}

		// Token: 0x02000652 RID: 1618
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCustomers>d__2 : IAsyncStateMachine
		{
			// Token: 0x06003852 RID: 14418 RVA: 0x000CA530 File Offset: 0x000C8730
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CustomerService customerService = this.<>4__this;
				IEnumerable<ICustomer> result;
				try
				{
					CustomerService.<>c__DisplayClass2_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new CustomerService.<>c__DisplayClass2_0();
						CS$<>8__locals1.visitSource = this.visitSource;
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						ConfiguredTaskAwaitable<List<clients>>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							IQueryable<clients> source = this.<ctx>5__2.clients.AsNoTracking().Include((clients i) => i.tel).AsQueryable<clients>();
							if (!this.showArchive)
							{
								source = from c in source
								where c.state == 1
								select c;
							}
							if (this.clientType == 0)
							{
								source = from c in source
								where c.is_regular
								select c;
							}
							if (this.clientType == 1)
							{
								source = from c in source
								where c.is_dealer
								select c;
							}
							if (this.clientType == 2)
							{
								source = from c in source
								where c.is_realizator
								select c;
							}
							if (this.clientType == 4)
							{
								source = from c in source
								where c.is_bad
								select c;
							}
							if (this.clientType == 5)
							{
								source = from c in source
								where c.type == 1
								select c;
							}
							if (this.clientType == 6)
							{
								source = from c in source
								where c.is_agent
								select c;
							}
							if (CS$<>8__locals1.visitSource != 0)
							{
								source = from c in source
								where c.visit_source == (int?)CS$<>8__locals1.visitSource
								select c;
							}
							if (!string.IsNullOrEmpty(this.query))
							{
								source = source.Where(CustomerService.CustomerTextSearch(this.query));
							}
							awaiter = source.ToListAsync<clients>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<List<clients>>.ConfiguredTaskAwaiter, CustomerService.<GetCustomers>d__2>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<List<clients>>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult().AsParallel<clients>().Select(new Func<clients, Customer>(CustomerService.<>c.<>9.<GetCustomers>b__2_9)).OrderBy(customerService.ClientsOrder()).ToList<Customer>();
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06003853 RID: 14419 RVA: 0x000CA9E4 File Offset: 0x000C8BE4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040021CE RID: 8654
			public int <>1__state;

			// Token: 0x040021CF RID: 8655
			public AsyncTaskMethodBuilder<IEnumerable<ICustomer>> <>t__builder;

			// Token: 0x040021D0 RID: 8656
			public int visitSource;

			// Token: 0x040021D1 RID: 8657
			public bool showArchive;

			// Token: 0x040021D2 RID: 8658
			public int clientType;

			// Token: 0x040021D3 RID: 8659
			public string query;

			// Token: 0x040021D4 RID: 8660
			public CustomerService <>4__this;

			// Token: 0x040021D5 RID: 8661
			private auseceEntities <ctx>5__2;

			// Token: 0x040021D6 RID: 8662
			private ConfiguredTaskAwaitable<List<clients>>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000653 RID: 1619
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x06003854 RID: 14420 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x040021D7 RID: 8663
			public string query;

			// Token: 0x040021D8 RID: 8664
			public string[] words;
		}

		// Token: 0x02000654 RID: 1620
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06003855 RID: 14421 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x040021D9 RID: 8665
			public int customerId;
		}

		// Token: 0x02000655 RID: 1621
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateRepairsCount>d__5 : IAsyncStateMachine
		{
			// Token: 0x06003856 RID: 14422 RVA: 0x000CAA00 File Offset: 0x000C8C00
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CustomerService customerService = this.<>4__this;
				try
				{
					if (num > 2)
					{
						this.<>8__1 = new CustomerService.<>c__DisplayClass5_0();
						this.<>8__1.customerId = this.customerId;
						this.<ctx>5__2 = customerService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<clients> awaiter;
						TaskAwaiter<int> awaiter2;
						switch (num)
						{
						case 0:
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<clients>);
							int num2 = -1;
							num = -1;
							this.<>1__state = num2;
							break;
						}
						case 1:
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<int>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
							goto IL_1E9;
						}
						case 2:
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<int>);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
							goto IL_262;
						}
						default:
							awaiter = this.<ctx>5__2.clients.FindAsync(new object[]
							{
								this.<>8__1.customerId
							}).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num5 = 0;
								num = 0;
								this.<>1__state = num5;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<clients>, CustomerService.<UpdateRepairsCount>d__5>(ref awaiter, ref this);
								return;
							}
							break;
						}
						clients result = awaiter.GetResult();
						this.<>7__wrap2 = result;
						awaiter2 = (from i in this.<ctx>5__2.workshop
						where !i.Hidden
						where i.client == this.<>8__1.customerId
						select i).CountAsync<workshop>().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num6 = 1;
							num = 1;
							this.<>1__state = num6;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, CustomerService.<UpdateRepairsCount>d__5>(ref awaiter2, ref this);
							return;
						}
						IL_1E9:
						int result2 = awaiter2.GetResult();
						this.<>7__wrap2.repairs = result2;
						this.<>7__wrap2 = null;
						awaiter2 = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num7 = 2;
							num = 2;
							this.<>1__state = num7;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, CustomerService.<UpdateRepairsCount>d__5>(ref awaiter2, ref this);
							return;
						}
						IL_262:
						awaiter2.GetResult();
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
						}
					}
					this.<ctx>5__2 = null;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003857 RID: 14423 RVA: 0x000CAD08 File Offset: 0x000C8F08
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040021DA RID: 8666
			public int <>1__state;

			// Token: 0x040021DB RID: 8667
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040021DC RID: 8668
			public int customerId;

			// Token: 0x040021DD RID: 8669
			public CustomerService <>4__this;

			// Token: 0x040021DE RID: 8670
			private CustomerService.<>c__DisplayClass5_0 <>8__1;

			// Token: 0x040021DF RID: 8671
			private auseceEntities <ctx>5__2;

			// Token: 0x040021E0 RID: 8672
			private TaskAwaiter<clients> <>u__1;

			// Token: 0x040021E1 RID: 8673
			private clients <>7__wrap2;

			// Token: 0x040021E2 RID: 8674
			private TaskAwaiter<int> <>u__2;
		}

		// Token: 0x02000656 RID: 1622
		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x06003858 RID: 14424 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x040021E3 RID: 8675
			public string email;
		}

		// Token: 0x02000657 RID: 1623
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetByEmail>d__6 : IAsyncStateMachine
		{
			// Token: 0x06003859 RID: 14425 RVA: 0x000CAD24 File Offset: 0x000C8F24
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				clients result;
				try
				{
					CustomerService.<>c__DisplayClass6_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new CustomerService.<>c__DisplayClass6_0();
						CS$<>8__locals1.email = this.email;
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						ConfiguredTaskAwaitable<clients>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = this.<ctx>5__2.clients.FirstOrDefaultAsync((clients c) => c.email == CS$<>8__locals1.email).ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<clients>.ConfiguredTaskAwaiter, CustomerService.<GetByEmail>d__6>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<clients>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult();
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x0600385A RID: 14426 RVA: 0x000CAEA8 File Offset: 0x000C90A8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040021E4 RID: 8676
			public int <>1__state;

			// Token: 0x040021E5 RID: 8677
			public AsyncTaskMethodBuilder<clients> <>t__builder;

			// Token: 0x040021E6 RID: 8678
			public string email;

			// Token: 0x040021E7 RID: 8679
			private auseceEntities <ctx>5__2;

			// Token: 0x040021E8 RID: 8680
			private ConfiguredTaskAwaitable<clients>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000658 RID: 1624
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCustomersAsync>d__7 : IAsyncStateMachine
		{
			// Token: 0x0600385B RID: 14427 RVA: 0x000CAEC4 File Offset: 0x000C90C4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<clients> result;
				try
				{
					if (num != 0)
					{
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						ConfiguredTaskAwaitable<List<clients>>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = this.<ctx>5__2.clients.AsNoTracking().Include((clients i) => i.tel).ToListAsync<clients>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<List<clients>>.ConfiguredTaskAwaiter, CustomerService.<GetCustomersAsync>d__7>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<List<clients>>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult();
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x0600385C RID: 14428 RVA: 0x000CB004 File Offset: 0x000C9204
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040021E9 RID: 8681
			public int <>1__state;

			// Token: 0x040021EA RID: 8682
			public AsyncTaskMethodBuilder<List<clients>> <>t__builder;

			// Token: 0x040021EB RID: 8683
			private auseceEntities <ctx>5__2;

			// Token: 0x040021EC RID: 8684
			private ConfiguredTaskAwaitable<List<clients>>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000659 RID: 1625
		[CompilerGenerated]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x0600385D RID: 14429 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x040021ED RID: 8685
			public int customerId;
		}

		// Token: 0x0200065A RID: 1626
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCustomerAsync>d__8 : IAsyncStateMachine
		{
			// Token: 0x0600385E RID: 14430 RVA: 0x000CB020 File Offset: 0x000C9220
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				clients result;
				try
				{
					CustomerService.<>c__DisplayClass8_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new CustomerService.<>c__DisplayClass8_0();
						CS$<>8__locals1.customerId = this.customerId;
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						ConfiguredTaskAwaitable<clients>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = this.<ctx>5__2.clients.AsNoTracking().Include((clients i) => i.tel).FirstOrDefaultAsync((clients i) => i.id == CS$<>8__locals1.customerId).ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<clients>.ConfiguredTaskAwaiter, CustomerService.<GetCustomerAsync>d__8>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<clients>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult();
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x0600385F RID: 14431 RVA: 0x000CB1EC File Offset: 0x000C93EC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040021EE RID: 8686
			public int <>1__state;

			// Token: 0x040021EF RID: 8687
			public AsyncTaskMethodBuilder<clients> <>t__builder;

			// Token: 0x040021F0 RID: 8688
			public int customerId;

			// Token: 0x040021F1 RID: 8689
			private auseceEntities <ctx>5__2;

			// Token: 0x040021F2 RID: 8690
			private ConfiguredTaskAwaitable<clients>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x0200065B RID: 1627
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCustomerCardAsync>d__9 : IAsyncStateMachine
		{
			// Token: 0x06003860 RID: 14432 RVA: 0x000CB208 File Offset: 0x000C9408
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CustomerService customerService = this.<>4__this;
				ICustomer result2;
				try
				{
					TaskAwaiter<clients> awaiter;
					if (num != 0)
					{
						awaiter = customerService.GetCustomerAsync(this.customerId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<clients>, CustomerService.<GetCustomerCardAsync>d__9>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<clients>);
						this.<>1__state = -1;
					}
					clients result = awaiter.GetResult();
					result2 = ((result != null) ? result.Client2CustomerCard() : null);
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06003861 RID: 14433 RVA: 0x000CB2D0 File Offset: 0x000C94D0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040021F3 RID: 8691
			public int <>1__state;

			// Token: 0x040021F4 RID: 8692
			public AsyncTaskMethodBuilder<ICustomer> <>t__builder;

			// Token: 0x040021F5 RID: 8693
			public CustomerService <>4__this;

			// Token: 0x040021F6 RID: 8694
			public int customerId;

			// Token: 0x040021F7 RID: 8695
			private TaskAwaiter<clients> <>u__1;
		}

		// Token: 0x0200065C RID: 1628
		[CompilerGenerated]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x06003862 RID: 14434 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x040021F8 RID: 8696
			public int customerId;
		}

		// Token: 0x0200065D RID: 1629
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetPhonesAsync>d__10 : IAsyncStateMachine
		{
			// Token: 0x06003863 RID: 14435 RVA: 0x000CB2EC File Offset: 0x000C94EC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<tel> result;
				try
				{
					CustomerService.<>c__DisplayClass10_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new CustomerService.<>c__DisplayClass10_0();
						CS$<>8__locals1.customerId = this.customerId;
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						ConfiguredTaskAwaitable<List<tel>>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = (from i in this.<ctx>5__2.tel.AsNoTracking()
							where i.customer == (int?)CS$<>8__locals1.customerId
							select i).ToListAsync<tel>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<List<tel>>.ConfiguredTaskAwaiter, CustomerService.<GetPhonesAsync>d__10>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<List<tel>>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult();
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06003864 RID: 14436 RVA: 0x000CB48C File Offset: 0x000C968C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040021F9 RID: 8697
			public int <>1__state;

			// Token: 0x040021FA RID: 8698
			public AsyncTaskMethodBuilder<List<tel>> <>t__builder;

			// Token: 0x040021FB RID: 8699
			public int customerId;

			// Token: 0x040021FC RID: 8700
			private auseceEntities <ctx>5__2;

			// Token: 0x040021FD RID: 8701
			private ConfiguredTaskAwaitable<List<tel>>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x0200065E RID: 1630
		[CompilerGenerated]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x06003865 RID: 14437 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass11_0()
			{
			}

			// Token: 0x040021FE RID: 8702
			public int customerId;

			// Token: 0x040021FF RID: 8703
			public DateTime from;

			// Token: 0x04002200 RID: 8704
			public DateTime to;
		}

		// Token: 0x0200065F RID: 1631
		[CompilerGenerated]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x06003866 RID: 14438 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x04002201 RID: 8705
			public int customerId;
		}

		// Token: 0x02000660 RID: 1632
		[CompilerGenerated]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x06003867 RID: 14439 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass13_0()
			{
			}

			// Token: 0x04002202 RID: 8706
			public int customerId;

			// Token: 0x04002203 RID: 8707
			public DateTime from;

			// Token: 0x04002204 RID: 8708
			public DateTime to;

			// Token: 0x04002205 RID: 8709
			public int repairStatus;
		}

		// Token: 0x02000661 RID: 1633
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetRepairs>d__13 : IAsyncStateMachine
		{
			// Token: 0x06003868 RID: 14440 RVA: 0x000CB4A8 File Offset: 0x000C96A8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CustomerService customerService = this.<>4__this;
				IEnumerable<workshop> result;
				try
				{
					CustomerService.<>c__DisplayClass13_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new CustomerService.<>c__DisplayClass13_0();
						CS$<>8__locals1.customerId = this.customerId;
						CS$<>8__locals1.repairStatus = this.repairStatus;
						CS$<>8__locals1.from = this.period.From.Date;
						CS$<>8__locals1.to = this.period.To.Date.AddDays(1.0).AddSeconds(-1.0);
						this.<ctx>5__2 = customerService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<List<workshop>> awaiter;
						if (num != 0)
						{
							IQueryable<workshop> source = from i in this.<ctx>5__2.workshop.AsNoTracking().Include((workshop i) => i.device_makers).Include((workshop i) => i.device_models).Include((workshop i) => i.devices).Include((workshop i) => i.master_users).Include((workshop i) => i.c_workshop.cartridge_cards)
							where !i.Hidden
							where i.client == CS$<>8__locals1.customerId
							select i into r
							where r.in_date >= CS$<>8__locals1.@from && r.in_date <= CS$<>8__locals1.to
							select r;
							if (CS$<>8__locals1.repairStatus != 99)
							{
								source = from i in source
								where i.state == CS$<>8__locals1.repairStatus
								select i;
							}
							awaiter = (from i in source
							orderby i.id descending
							select i).ToListAsync<workshop>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<workshop>>, CustomerService.<GetRepairs>d__13>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<workshop>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult();
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06003869 RID: 14441 RVA: 0x000CB9C0 File Offset: 0x000C9BC0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002206 RID: 8710
			public int <>1__state;

			// Token: 0x04002207 RID: 8711
			public AsyncTaskMethodBuilder<IEnumerable<workshop>> <>t__builder;

			// Token: 0x04002208 RID: 8712
			public int customerId;

			// Token: 0x04002209 RID: 8713
			public int repairStatus;

			// Token: 0x0400220A RID: 8714
			public IPeriod period;

			// Token: 0x0400220B RID: 8715
			public CustomerService <>4__this;

			// Token: 0x0400220C RID: 8716
			private auseceEntities <ctx>5__2;

			// Token: 0x0400220D RID: 8717
			private TaskAwaiter<List<workshop>> <>u__1;
		}

		// Token: 0x02000662 RID: 1634
		[CompilerGenerated]
		private sealed class <>c__DisplayClass14_0
		{
			// Token: 0x0600386A RID: 14442 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass14_0()
			{
			}

			// Token: 0x0400220E RID: 8718
			public int customerId;
		}

		// Token: 0x02000663 RID: 1635
		[CompilerGenerated]
		private sealed class <>c__DisplayClass15_0
		{
			// Token: 0x0600386B RID: 14443 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass15_0()
			{
			}

			// Token: 0x0400220F RID: 8719
			public int customerId;
		}

		// Token: 0x02000664 RID: 1636
		[CompilerGenerated]
		private sealed class <>c__DisplayClass16_0
		{
			// Token: 0x0600386C RID: 14444 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass16_0()
			{
			}

			// Token: 0x04002210 RID: 8720
			public int customerId;
		}

		// Token: 0x02000665 RID: 1637
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetActiveRepairs>d__16 : IAsyncStateMachine
		{
			// Token: 0x0600386D RID: 14445 RVA: 0x000CB9DC File Offset: 0x000C9BDC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CustomerService customerService = this.<>4__this;
				IEnumerable<RepairCard> result;
				try
				{
					CustomerService.<>c__DisplayClass16_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new CustomerService.<>c__DisplayClass16_0();
						CS$<>8__locals1.customerId = this.customerId;
						this.<ctx>5__2 = customerService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<List<workshop>> awaiter;
						if (num != 0)
						{
							awaiter = (from r in this.<ctx>5__2.workshop.AsNoTracking().Include((workshop i) => i.device_makers).Include((workshop i) => i.device_models).Include((workshop i) => i.devices)
							where r.client == CS$<>8__locals1.customerId
							where r.state != 8
							where r.state != 12
							orderby r.id descending
							select r).ToListAsync<workshop>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<workshop>>, CustomerService.<GetActiveRepairs>d__16>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<workshop>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult().Select(new Func<workshop, RepairCard>(CustomerService.<>c.<>9.<GetActiveRepairs>b__16_0)).ToList<RepairCard>();
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x0600386E RID: 14446 RVA: 0x000CBD58 File Offset: 0x000C9F58
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002211 RID: 8721
			public int <>1__state;

			// Token: 0x04002212 RID: 8722
			public AsyncTaskMethodBuilder<IEnumerable<RepairCard>> <>t__builder;

			// Token: 0x04002213 RID: 8723
			public int customerId;

			// Token: 0x04002214 RID: 8724
			public CustomerService <>4__this;

			// Token: 0x04002215 RID: 8725
			private auseceEntities <ctx>5__2;

			// Token: 0x04002216 RID: 8726
			private TaskAwaiter<List<workshop>> <>u__1;
		}

		// Token: 0x02000666 RID: 1638
		[CompilerGenerated]
		private sealed class <>c__DisplayClass17_0
		{
			// Token: 0x0600386F RID: 14447 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass17_0()
			{
			}

			// Token: 0x04002217 RID: 8727
			public IPeriod period;

			// Token: 0x04002218 RID: 8728
			public int customerId;
		}

		// Token: 0x02000667 RID: 1639
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetInvoices>d__17 : IAsyncStateMachine
		{
			// Token: 0x06003870 RID: 14448 RVA: 0x000CBD74 File Offset: 0x000C9F74
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IEnumerable<Invoice> result;
				try
				{
					CustomerService.<>c__DisplayClass17_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new CustomerService.<>c__DisplayClass17_0();
						CS$<>8__locals1.period = this.period;
						CS$<>8__locals1.customerId = this.customerId;
						this.<repo>5__2 = new GenericRepository<invoice>();
					}
					try
					{
						TaskAwaiter<IEnumerable<invoice>> awaiter;
						if (num != 0)
						{
							List<KeyValuePair<bool, Expression<Func<invoice, bool>>>> filterList = new List<KeyValuePair<bool, Expression<Func<invoice, bool>>>>
							{
								new KeyValuePair<bool, Expression<Func<invoice, bool>>>(CS$<>8__locals1.period != null, (invoice i) => i.created >= CS$<>8__locals1.period.From && i.created <= CS$<>8__locals1.period.To),
								new KeyValuePair<bool, Expression<Func<invoice, bool>>>(true, (invoice i) => i.banks1.client == (int?)CS$<>8__locals1.customerId)
							};
							awaiter = this.<repo>5__2.GetAllAsync(filterList, new Func<IQueryable<invoice>, IOrderedQueryable<invoice>>(CustomerService.<>c.<>9.<GetInvoices>b__17_2), "users,banks,banks1", false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<invoice>>, CustomerService.<GetInvoices>d__17>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IEnumerable<invoice>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult().Select(new Func<invoice, Invoice>(InvoiceMapper.InvoiveConvert)).ToList<Invoice>();
					}
					finally
					{
						if (num < 0 && this.<repo>5__2 != null)
						{
							((IDisposable)this.<repo>5__2).Dispose();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06003871 RID: 14449 RVA: 0x000CC06C File Offset: 0x000CA26C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002219 RID: 8729
			public int <>1__state;

			// Token: 0x0400221A RID: 8730
			public AsyncTaskMethodBuilder<IEnumerable<Invoice>> <>t__builder;

			// Token: 0x0400221B RID: 8731
			public IPeriod period;

			// Token: 0x0400221C RID: 8732
			public int customerId;

			// Token: 0x0400221D RID: 8733
			private GenericRepository<invoice> <repo>5__2;

			// Token: 0x0400221E RID: 8734
			private TaskAwaiter<IEnumerable<invoice>> <>u__1;
		}

		// Token: 0x02000668 RID: 1640
		[CompilerGenerated]
		private sealed class <>c__DisplayClass20_0
		{
			// Token: 0x06003872 RID: 14450 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass20_0()
			{
			}

			// Token: 0x0400221F RID: 8735
			public int customerId;
		}

		// Token: 0x02000669 RID: 1641
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetPaymentDetailsAsync>d__20 : IAsyncStateMachine
		{
			// Token: 0x06003873 RID: 14451 RVA: 0x000CC088 File Offset: 0x000CA288
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IEnumerable<PaymentDetails> result2;
				try
				{
					CustomerService.<>c__DisplayClass20_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new CustomerService.<>c__DisplayClass20_0();
						CS$<>8__locals1.customerId = this.customerId;
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						ConfiguredTaskAwaitable<List<banks>>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = (from i in this.<ctx>5__2.banks.AsNoTracking().Include((banks i) => i.clients)
							where i.client == (int?)CS$<>8__locals1.customerId
							select i).ToListAsync<banks>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<List<banks>>.ConfiguredTaskAwaiter, CustomerService.<GetPaymentDetailsAsync>d__20>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<List<banks>>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						List<banks> result = awaiter.GetResult();
						if (!result.Any<banks>())
						{
							result2 = new List<PaymentDetails>();
						}
						else
						{
							result2 = result.Select(new Func<banks, PaymentDetails>(ASC.Models.InvoiceModel.BankToCustomerPaymentDetails)).ToList<PaymentDetails>();
						}
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06003874 RID: 14452 RVA: 0x000CC294 File Offset: 0x000CA494
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002220 RID: 8736
			public int <>1__state;

			// Token: 0x04002221 RID: 8737
			public AsyncTaskMethodBuilder<IEnumerable<PaymentDetails>> <>t__builder;

			// Token: 0x04002222 RID: 8738
			public int customerId;

			// Token: 0x04002223 RID: 8739
			private auseceEntities <ctx>5__2;

			// Token: 0x04002224 RID: 8740
			private ConfiguredTaskAwaitable<List<banks>>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x0200066A RID: 1642
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreatePaymentDetailsAsync>d__21 : IAsyncStateMachine
		{
			// Token: 0x06003875 RID: 14453 RVA: 0x000CC2B0 File Offset: 0x000CA4B0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				int id;
				try
				{
					if (num != 0)
					{
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							this.<banks>5__3 = new banks
							{
								ur_name = this.details.Name,
								client = new int?(this.details.CustomerId),
								company = null,
								inn = this.details.Inn,
								kpp = this.details.Kpp,
								address = this.details.Address,
								correspondent_account = this.details.CorrespondentAccount,
								checking_account = this.details.CheckingAccount,
								bank = this.details.Bank,
								BIC = this.details.Bic,
								chief = this.details.Chief,
								accountant = this.details.Accountant,
								email = this.details.Email,
								ogrn = this.details.Ogrn
							};
							this.<ctx>5__2.banks.Add(this.<banks>5__3);
							awaiter = this.<ctx>5__2.SaveChangesAsync().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter, CustomerService.<CreatePaymentDetailsAsync>d__21>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						awaiter.GetResult();
						id = this.<banks>5__3.id;
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(id);
			}

			// Token: 0x06003876 RID: 14454 RVA: 0x000CC4DC File Offset: 0x000CA6DC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002225 RID: 8741
			public int <>1__state;

			// Token: 0x04002226 RID: 8742
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x04002227 RID: 8743
			public IPaymentDetails details;

			// Token: 0x04002228 RID: 8744
			private auseceEntities <ctx>5__2;

			// Token: 0x04002229 RID: 8745
			private banks <banks>5__3;

			// Token: 0x0400222A RID: 8746
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x0200066B RID: 1643
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateCustomer>d__22 : IAsyncStateMachine
		{
			// Token: 0x06003877 RID: 14455 RVA: 0x000CC4F8 File Offset: 0x000CA6F8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				int id;
				try
				{
					if (num != 0)
					{
						this.<history>5__2 = new HistoryV2();
						this.<ctx>5__3 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<int> awaiter;
						if (num != 0)
						{
							this.<client>5__4 = ClientsModel.DefaultCustomer();
							this.<client>5__4.type = this.c.Type;
							this.<client>5__4.state = 1;
							this.<client>5__4.surname = this.c.LastName;
							this.<client>5__4.name = this.c.FirstName;
							this.<client>5__4.patronymic = this.c.Patronymic;
							this.<client>5__4.ur_name = this.c.UrName;
							this.<client>5__4.is_realizator = this.c.IsRealizator;
							this.<client>5__4.balance_enable = this.c.BalanceEnabled;
							this.<client>5__4.is_bad = this.c.IsBad;
							this.<client>5__4.is_regular = this.c.IsRegular;
							this.<client>5__4.is_agent = this.c.IsAgent;
							this.<client>5__4.is_dealer = this.c.IsDealer;
							this.<client>5__4.visit_source = this.c.VisitSource;
							this.<client>5__4.address = this.c.Address;
							this.<client>5__4.email = this.c.Email;
							this.<client>5__4.price_col = this.c.PriceCol;
							this.<client>5__4.ignore_calls = this.c.IgnoreCalls;
							this.<client>5__4.prefer_cashless = this.c.PreferCashless;
							this.<client>5__4.take_long = this.c.TakeLong;
							this.<client>5__4.notes = this.c.Notes;
							this.<client>5__4.birthday = this.c.Birthday;
							this.<client>5__4.passport_date = this.c.PassportDate;
							this.<client>5__4.passport_num = this.c.PassportNum;
							this.<client>5__4.passport_organ = this.c.PassportOrgan;
							this.<client>5__4.icq = this.c.Icq;
							this.<client>5__4.whatsapp = this.c.Whatsapp;
							this.<client>5__4.skype = this.c.Skype;
							this.<client>5__4.viber = this.c.Viber;
							this.<client>5__4.site = this.c.Site;
							this.<client>5__4.telegram = this.c.Telegram;
							this.<client>5__4.web_password = this.c.WebPassword;
							this.<client>5__4.post_index = this.c.PostIndex;
							this.<client>5__4.INN = this.c.Inn;
							this.<client>5__4.KPP = this.c.Kpp;
							this.<client>5__4.OGRN = this.c.Ogrn;
							this.<ctx>5__3.clients.Add(this.<client>5__4);
							if (this.<client>5__4.type == 1)
							{
								this.<client>5__4.name = this.<client>5__4.ur_name;
							}
							awaiter = this.<ctx>5__3.SaveChangesAsync().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, CustomerService.<CreateCustomer>d__22>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<int>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						awaiter.GetResult();
						this.c.Id = this.<client>5__4.id;
						this.<history>5__2.AddClientLog("clientCreated", this.<client>5__4.id, 0m, 0);
						this.<history>5__2.Save();
						if (this.c.Phones.Any<Tel>())
						{
							IEnumerator<Tel> enumerator = this.c.Phones.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									Tel tel = enumerator.Current;
									this.c.AddTel(tel);
								}
							}
							finally
							{
								if (num < 0 && enumerator != null)
								{
									enumerator.Dispose();
								}
							}
						}
						id = this.<client>5__4.id;
					}
					finally
					{
						if (num < 0 && this.<ctx>5__3 != null)
						{
							((IDisposable)this.<ctx>5__3).Dispose();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<history>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<history>5__2 = null;
				this.<>t__builder.SetResult(id);
			}

			// Token: 0x06003878 RID: 14456 RVA: 0x000CCA10 File Offset: 0x000CAC10
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400222B RID: 8747
			public int <>1__state;

			// Token: 0x0400222C RID: 8748
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x0400222D RID: 8749
			public CustomerCard c;

			// Token: 0x0400222E RID: 8750
			private HistoryV2 <history>5__2;

			// Token: 0x0400222F RID: 8751
			private auseceEntities <ctx>5__3;

			// Token: 0x04002230 RID: 8752
			private clients <client>5__4;

			// Token: 0x04002231 RID: 8753
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x0200066C RID: 1644
		[CompilerGenerated]
		private sealed class <>c__DisplayClass24_0
		{
			// Token: 0x06003879 RID: 14457 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass24_0()
			{
			}

			// Token: 0x0600387A RID: 14458 RVA: 0x000CCA2C File Offset: 0x000CAC2C
			internal bool <GetCustomerType>b__0(ICustomerType t)
			{
				return t.Id == (int)this.type;
			}

			// Token: 0x04002232 RID: 8754
			public CustomerModel.Type type;
		}

		// Token: 0x0200066D RID: 1645
		[CompilerGenerated]
		private sealed class <>c__DisplayClass26_0
		{
			// Token: 0x0600387B RID: 14459 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass26_0()
			{
			}

			// Token: 0x04002233 RID: 8755
			public int customerId;
		}

		// Token: 0x0200066E RID: 1646
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CountRepairs>d__26 : IAsyncStateMachine
		{
			// Token: 0x0600387C RID: 14460 RVA: 0x000CCA48 File Offset: 0x000CAC48
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CustomerService customerService = this.<>4__this;
				int result;
				try
				{
					CustomerService.<>c__DisplayClass26_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new CustomerService.<>c__DisplayClass26_0();
						CS$<>8__locals1.customerId = this.customerId;
						this.<ctx>5__2 = customerService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<int> awaiter;
						if (num != 0)
						{
							awaiter = (from r in this.<ctx>5__2.workshop
							where !r.Hidden
							where r.client == CS$<>8__locals1.customerId
							select r).CountAsync<workshop>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, CustomerService.<CountRepairs>d__26>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<int>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult();
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x0600387D RID: 14461 RVA: 0x000CCC1C File Offset: 0x000CAE1C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002234 RID: 8756
			public int <>1__state;

			// Token: 0x04002235 RID: 8757
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x04002236 RID: 8758
			public int customerId;

			// Token: 0x04002237 RID: 8759
			public CustomerService <>4__this;

			// Token: 0x04002238 RID: 8760
			private auseceEntities <ctx>5__2;

			// Token: 0x04002239 RID: 8761
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x0200066F RID: 1647
		[CompilerGenerated]
		private sealed class <>c__DisplayClass27_0
		{
			// Token: 0x0600387E RID: 14462 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass27_0()
			{
			}

			// Token: 0x0400223A RID: 8762
			public int customerId;
		}

		// Token: 0x02000670 RID: 1648
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CountPurchases>d__27 : IAsyncStateMachine
		{
			// Token: 0x0600387F RID: 14463 RVA: 0x000CCC38 File Offset: 0x000CAE38
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CustomerService customerService = this.<>4__this;
				int result;
				try
				{
					CustomerService.<>c__DisplayClass27_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new CustomerService.<>c__DisplayClass27_0();
						CS$<>8__locals1.customerId = this.customerId;
						this.<ctx>5__2 = customerService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<int> awaiter;
						if (num != 0)
						{
							awaiter = this.<ctx>5__2.docs.CountAsync((docs p) => p.dealer == (int?)CS$<>8__locals1.customerId && p.state == (int?)5).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, CustomerService.<CountPurchases>d__27>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<int>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult();
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06003880 RID: 14464 RVA: 0x000CCE14 File Offset: 0x000CB014
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400223B RID: 8763
			public int <>1__state;

			// Token: 0x0400223C RID: 8764
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x0400223D RID: 8765
			public int customerId;

			// Token: 0x0400223E RID: 8766
			public CustomerService <>4__this;

			// Token: 0x0400223F RID: 8767
			private auseceEntities <ctx>5__2;

			// Token: 0x04002240 RID: 8768
			private TaskAwaiter<int> <>u__1;
		}
	}
}
