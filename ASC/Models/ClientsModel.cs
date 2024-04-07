using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Common.Models;
using ASC.Common.Phone;
using ASC.Objects;
using ASC.Objects.Converters;
using ASC.SimpleClasses;
using NLog;

namespace ASC.Models
{
	// Token: 0x020009E6 RID: 2534
	public class ClientsModel : CustomerModel
	{
		// Token: 0x06004BA8 RID: 19368 RVA: 0x00134124 File Offset: 0x00132324
		public static clients DefaultCustomer()
		{
			Localization localization = new Localization("UTC");
			return new clients
			{
				surname = string.Empty,
				name = string.Empty,
				ur_name = string.Empty,
				created = new DateTime?(localization.Now),
				creator = Auth.User.id,
				state = 1,
				type = 0,
				is_regular = false,
				is_dealer = false,
				balance_enable = false,
				prefer_cashless = false,
				take_long = false,
				ignore_calls = false,
				is_bad = false,
				balance = 0m,
				price_col = 2,
				web_password = Generators.RandomString(6, "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"),
				agent2_phone_mask = 1,
				agent_phone_mask = 1,
				repairs = 0,
				purchases = 0
			};
		}

		// Token: 0x06004BA9 RID: 19369 RVA: 0x00134204 File Offset: 0x00132404
		public static clients SetDefaultValues(clients customer)
		{
			Localization localization = new Localization("UTC");
			customer.surname = string.Empty;
			customer.name = string.Empty;
			customer.ur_name = string.Empty;
			customer.created = new DateTime?(localization.Now);
			customer.creator = Auth.User.id;
			customer.state = 1;
			customer.type = 0;
			customer.is_regular = false;
			customer.is_dealer = false;
			customer.balance_enable = false;
			customer.prefer_cashless = false;
			customer.take_long = false;
			customer.ignore_calls = false;
			customer.is_bad = false;
			customer.balance = 0m;
			customer.price_col = 2;
			customer.web_password = Generators.RandomString(6, "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789");
			customer.repairs = 0;
			customer.purchases = 0;
			return customer;
		}

		// Token: 0x06004BAA RID: 19370 RVA: 0x001342D0 File Offset: 0x001324D0
		public static Task<CustomerCard> GetCustomerCard(int customerId)
		{
			ClientsModel.<GetCustomerCard>d__3 <GetCustomerCard>d__;
			<GetCustomerCard>d__.<>t__builder = AsyncTaskMethodBuilder<CustomerCard>.Create();
			<GetCustomerCard>d__.customerId = customerId;
			<GetCustomerCard>d__.<>1__state = -1;
			<GetCustomerCard>d__.<>t__builder.Start<ClientsModel.<GetCustomerCard>d__3>(ref <GetCustomerCard>d__);
			return <GetCustomerCard>d__.<>t__builder.Task;
		}

		// Token: 0x06004BAB RID: 19371 RVA: 0x00134314 File Offset: 0x00132514
		public static IAscResult CreateManyClients(IEnumerable<ICustomer> clients)
		{
			Result result = new Result();
			try
			{
				using (auseceEntities ctx = new auseceEntities(true))
				{
					List<clients> entities = clients.Select(delegate(ICustomer c)
					{
						clients clients2 = ClientsModel.SetDefaultValues(ctx.clients.Create());
						clients2.name = c.FirstName;
						clients2.surname = c.LastName;
						clients2.patronymic = c.Patronymic;
						clients2.ur_name = c.UrName;
						clients2.type = c.Type;
						ClientsModel.AddTel(clients2, c.Phone);
						return clients2;
					}).AsParallel<clients>().ToList<clients>();
					ctx.clients.AddRange(entities);
					ctx.SaveChanges();
					result.SetSuccess();
				}
			}
			catch (Exception ex)
			{
				ClientsModel.Log.Error(ex, "Create many clients fail");
				result.Message = ex.Message;
			}
			return result;
		}

		// Token: 0x06004BAC RID: 19372 RVA: 0x001343D0 File Offset: 0x001325D0
		public static void AddTel(clients c, string tel)
		{
			if (tel.Length > 45)
			{
				tel = tel.Substring(0, 45);
			}
			c.tel.Add(new tel
			{
				phone = tel,
				phone_clean = Phone.ClearPhoneString(tel),
				type = 1
			});
		}

		// Token: 0x06004BAD RID: 19373 RVA: 0x0013441C File Offset: 0x0013261C
		public static void MakeCustomerDealer(int customerId)
		{
			try
			{
				HistoryV2 historyV = new HistoryV2();
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					clients clients = auseceEntities.clients.Find(new object[]
					{
						customerId
					});
					if (clients != null)
					{
						clients.is_realizator = true;
						clients.balance_enable = true;
						auseceEntities.SaveChanges();
						historyV.AddClientLog("balanceOn", customerId, 0m, 0);
						historyV.Save();
					}
				}
			}
			catch (Exception exception)
			{
				ClientsModel.Log.Error(exception, "Make customer dealer fail");
			}
		}

		// Token: 0x06004BAE RID: 19374 RVA: 0x001344C0 File Offset: 0x001326C0
		public cdr GetRecord(string recordId)
		{
			cdr result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					result = auseceEntities.cdr.FirstOrDefault((cdr r) => r.uniqueid == recordId);
				}
			}
			catch (Exception exception)
			{
				ClientsModel.Log.Error(exception, "Load cdr fail");
				result = null;
			}
			return result;
		}

		// Token: 0x06004BAF RID: 19375 RVA: 0x0013458C File Offset: 0x0013278C
		public int CreateNewClient(CustomerCard c)
		{
			int result;
			try
			{
				HistoryV2 historyV = new HistoryV2();
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					clients clients = ClientsModel.DefaultCustomer();
					clients.type = c.Type;
					clients.state = 1;
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
					clients.visit_source = c.VisitSource;
					clients.address = c.Address;
					clients.email = c.Email;
					clients.price_col = c.PriceCol;
					clients.ignore_calls = c.IgnoreCalls;
					clients.prefer_cashless = c.PreferCashless;
					clients.take_long = c.TakeLong;
					clients.notes = c.Notes;
					clients.birthday = c.Birthday;
					clients.passport_date = c.PassportDate;
					clients.passport_num = c.PassportNum;
					clients.passport_organ = c.PassportOrgan;
					clients.icq = c.Icq;
					clients.whatsapp = c.Whatsapp;
					clients.skype = c.Skype;
					clients.viber = c.Viber;
					clients.site = c.Site;
					clients.telegram = c.Telegram;
					clients.web_password = c.WebPassword;
					clients.post_index = c.PostIndex;
					clients.INN = c.Inn;
					clients.KPP = c.Kpp;
					clients.OGRN = c.Ogrn;
					auseceEntities.clients.Add(clients);
					if (clients.type == 1)
					{
						clients.name = clients.ur_name;
					}
					auseceEntities.SaveChanges();
					c.Id = clients.id;
					historyV.AddClientLog("clientCreated", clients.id, 0m, 0);
					historyV.Save();
					if (c.Phones.Any<Tel>())
					{
						foreach (Tel tel in c.Phones)
						{
							c.AddTel(tel);
						}
					}
					result = clients.id;
				}
			}
			catch (Exception exception)
			{
				ClientsModel.Log.Error(exception, "Create new customer fail");
				result = 0;
			}
			return result;
		}

		// Token: 0x06004BB0 RID: 19376 RVA: 0x0013485C File Offset: 0x00132A5C
		public clients SilentCreateNewClient(clients client)
		{
			HistoryV2 historyV = new HistoryV2();
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					auseceEntities.clients.Add(client);
					auseceEntities.SaveChanges();
					historyV.AddClientLog("clientCreated", client.id, 0m, 0);
					historyV.Save();
				}
			}
			catch (Exception exception)
			{
				ClientsModel.Log.Error(exception, "Silent create new customer fail");
				throw;
			}
			return client;
		}

		// Token: 0x06004BB1 RID: 19377 RVA: 0x001348E8 File Offset: 0x00132AE8
		public string CheckFields(CustomerCard client)
		{
			if (client.Type == 0 && string.IsNullOrEmpty(client.FirstName))
			{
				return Lang.t("InputClientName");
			}
			if (Auth.Config.is_patronymic_required && client.Type == 0 && string.IsNullOrEmpty(client.Patronymic))
			{
				return Lang.t("InputPatronymic");
			}
			if (client.Type == 1)
			{
				if (string.IsNullOrEmpty(client.UrName))
				{
					return Lang.t("InputUrName");
				}
			}
			if (!Auth.Config.phone_required || client.Phones.Any<Tel>())
			{
				return "";
			}
			return Lang.t("PhoneRequired");
		}

		// Token: 0x06004BB2 RID: 19378 RVA: 0x00134990 File Offset: 0x00132B90
		public static Task<IEnumerable<PaymentDetails>> GetCustomerPaymentDetails(int customerId)
		{
			ClientsModel.<GetCustomerPaymentDetails>d__11 <GetCustomerPaymentDetails>d__;
			<GetCustomerPaymentDetails>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<PaymentDetails>>.Create();
			<GetCustomerPaymentDetails>d__.customerId = customerId;
			<GetCustomerPaymentDetails>d__.<>1__state = -1;
			<GetCustomerPaymentDetails>d__.<>t__builder.Start<ClientsModel.<GetCustomerPaymentDetails>d__11>(ref <GetCustomerPaymentDetails>d__);
			return <GetCustomerPaymentDetails>d__.<>t__builder.Task;
		}

		// Token: 0x06004BB3 RID: 19379 RVA: 0x001349D4 File Offset: 0x00132BD4
		public static Task<bool> HasInvoices(int customerId)
		{
			return Task.Run<bool>(delegate()
			{
				bool result;
				using (GenericRepository<invoice> genericRepository = new GenericRepository<invoice>())
				{
					result = genericRepository.Any((invoice i) => i.banks1.client == (int?)customerId);
				}
				return result;
			});
		}

		// Token: 0x06004BB4 RID: 19380 RVA: 0x00134A00 File Offset: 0x00132C00
		public static void RefreshPurchasesCount(int customerId)
		{
			using (GenericRepository<clients> genericRepository = new GenericRepository<clients>())
			{
				clients firstOrDefault = genericRepository.GetFirstOrDefault((clients c) => c.id == customerId, "");
				firstOrDefault.purchases = firstOrDefault.store_sales1.Count(delegate(store_sales s)
				{
					int? state = s.docs.state;
					return state.GetValueOrDefault() == 5 & state != null;
				});
				genericRepository.Update(firstOrDefault);
			}
		}

		// Token: 0x06004BB5 RID: 19381 RVA: 0x00134AE0 File Offset: 0x00132CE0
		public static IAscResult MergeCustomers(IEnumerable<ICustomer> customers, int targetId)
		{
			Result result = new Result();
			List<int> ids = (from c in customers
			select c.Id).ToList<int>();
			try
			{
				ids.Remove(targetId);
				HistoryV2 historyV = new HistoryV2();
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					using (DbContextTransaction dbContextTransaction = auseceEntities.Database.BeginTransaction())
					{
						try
						{
							foreach (workshop workshop in (from w in auseceEntities.workshop
							where ids.Contains(w.client)
							select w).ToList<workshop>())
							{
								workshop.client = targetId;
							}
							foreach (banks banks in (from w in auseceEntities.banks
							where ids.Contains(w.client.Value)
							select w).ToList<banks>())
							{
								banks.client = new int?(targetId);
							}
							foreach (docs docs in (from w in auseceEntities.docs
							where ids.Contains(w.dealer.Value)
							select w).ToList<docs>())
							{
								docs.dealer = new int?(targetId);
							}
							foreach (store_items store_items in (from w in auseceEntities.store_items
							where ids.Contains(w.dealer)
							select w).ToList<store_items>())
							{
								store_items.dealer = targetId;
							}
							foreach (store_sales store_sales in (from w in auseceEntities.store_sales
							where ids.Contains(w.dealer)
							select w).ToList<store_sales>())
							{
								store_sales.dealer = targetId;
							}
							foreach (store_sales store_sales2 in (from w in auseceEntities.store_sales
							where ids.Contains(w.customer_id.Value)
							select w).ToList<store_sales>())
							{
								store_sales2.customer_id = new int?(targetId);
							}
							foreach (cash_orders cash_orders in (from w in auseceEntities.cash_orders
							where ids.Contains(w.client.Value)
							select w).ToList<cash_orders>())
							{
								cash_orders.client = new int?(targetId);
							}
							foreach (dealer_payments dealer_payments in (from w in auseceEntities.dealer_payments
							where ids.Contains(w.dealer_id)
							select w).ToList<dealer_payments>())
							{
								dealer_payments.dealer_id = targetId;
							}
							foreach (comments comments in (from w in auseceEntities.comments
							where ids.Contains(w.client.Value)
							select w).ToList<comments>())
							{
								comments.client = new int?(targetId);
							}
							foreach (logs logs in (from w in auseceEntities.logs
							where ids.Contains(w.client.Value)
							select w).ToList<logs>())
							{
								logs.client = new int?(targetId);
							}
							foreach (notifications notifications in (from w in auseceEntities.notifications
							where ids.Contains(w.customer.Value)
							select w).ToList<notifications>())
							{
								notifications.customer = new int?(targetId);
							}
							foreach (out_sms out_sms in (from w in auseceEntities.out_sms
							where ids.Contains(w.client.Value)
							select w).ToList<out_sms>())
							{
								out_sms.client = new int?(targetId);
							}
							foreach (parts_request parts_request in (from w in auseceEntities.parts_request
							where ids.Contains(w.client.Value)
							select w).ToList<parts_request>())
							{
								parts_request.client = new int?(targetId);
							}
							foreach (parts_request parts_request2 in (from w in auseceEntities.parts_request
							where ids.Contains(w.dealer.Value)
							select w).ToList<parts_request>())
							{
								parts_request2.dealer = new int?(targetId);
							}
							foreach (payment_types payment_types in (from w in auseceEntities.payment_types
							where ids.Contains(w.client.Value)
							select w).ToList<payment_types>())
							{
								payment_types.client = new int?(targetId);
							}
							foreach (tel tel in (from w in auseceEntities.tel
							where ids.Contains(w.customer.Value)
							select w).ToList<tel>())
							{
								tel entity = new tel
								{
									phone = tel.phone,
									phone_clean = tel.phone_clean,
									mask = tel.mask,
									customer = new int?(targetId),
									type = 0,
									note = tel.note
								};
								auseceEntities.tel.Add(entity);
							}
							foreach (clients clients in (from w in auseceEntities.clients
							where ids.Contains(w.id)
							select w).ToList<clients>())
							{
								clients.state = 0;
								clients clients2 = clients;
								ICollection<workshop> workshop2 = clients.workshop;
								clients2.repairs = ((workshop2 != null) ? workshop2.Count : 0);
								clients clients3 = clients;
								ICollection<store_sales> store_sales3 = clients.store_sales1;
								int purchases;
								if (store_sales3 == null)
								{
									purchases = 0;
								}
								else
								{
									purchases = store_sales3.Count(delegate(store_sales s)
									{
										int? state = s.docs.state;
										return state.GetValueOrDefault() == 5 & state != null;
									});
								}
								clients3.purchases = purchases;
								historyV.AddClientCardLog("CustomerWasMerged", clients.id, targetId.ToString("d6"), null);
								historyV.AddClientCardLog("ArchiveChanged", clients.id, true);
							}
							auseceEntities.SaveChanges();
							clients clients4 = auseceEntities.clients.Find(new object[]
							{
								targetId
							});
							ICollection<workshop> workshop3 = clients4.workshop;
							clients4.repairs = ((workshop3 != null) ? workshop3.Count : 0);
							ICollection<store_sales> store_sales4 = clients4.store_sales1;
							int purchases2;
							if (store_sales4 == null)
							{
								purchases2 = 0;
							}
							else
							{
								purchases2 = store_sales4.Count(delegate(store_sales s)
								{
									int? state = s.docs.state;
									return state.GetValueOrDefault() == 5 & state != null;
								});
							}
							clients4.purchases = purchases2;
							auseceEntities.SaveChanges();
							dbContextTransaction.Commit();
							historyV.Save();
						}
						catch (Exception ex)
						{
							dbContextTransaction.Rollback();
							ClientsModel.Log.Error(ex, ex.Message);
							result.Message = ex.Message;
							return result;
						}
					}
				}
			}
			catch (Exception ex2)
			{
				ClientsModel.Log.Error(ex2, ex2.Message);
				result.Message = ex2.Message;
				return result;
			}
			result.SetSuccess();
			return result;
		}

		// Token: 0x06004BB6 RID: 19382 RVA: 0x00135D24 File Offset: 0x00133F24
		public ClientsModel()
		{
		}

		// Token: 0x06004BB7 RID: 19383 RVA: 0x00135D38 File Offset: 0x00133F38
		// Note: this type is marked as 'beforefieldinit'.
		static ClientsModel()
		{
		}

		// Token: 0x040030CA RID: 12490
		private static readonly ILogger Log = LogManager.GetCurrentClassLogger();

		// Token: 0x020009E7 RID: 2535
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06004BB8 RID: 19384 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x040030CB RID: 12491
			public int customerId;
		}

		// Token: 0x020009E8 RID: 2536
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCustomerCard>d__3 : IAsyncStateMachine
		{
			// Token: 0x06004BB9 RID: 19385 RVA: 0x00135D50 File Offset: 0x00133F50
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CustomerCard result2;
				try
				{
					ClientsModel.<>c__DisplayClass3_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new ClientsModel.<>c__DisplayClass3_0();
						CS$<>8__locals1.customerId = this.customerId;
						this.<repo>5__2 = new GenericRepository<clients>();
					}
					try
					{
						TaskAwaiter<clients> awaiter;
						if (num != 0)
						{
							awaiter = this.<repo>5__2.GetFirstOrDefaultAsync((clients c) => c.id == CS$<>8__locals1.customerId, "tel").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<clients>, ClientsModel.<GetCustomerCard>d__3>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<clients>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						clients result = awaiter.GetResult();
						result2 = ((result != null) ? result.Client2CustomerCard() : null);
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
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06004BBA RID: 19386 RVA: 0x00135ED8 File Offset: 0x001340D8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040030CC RID: 12492
			public int <>1__state;

			// Token: 0x040030CD RID: 12493
			public AsyncTaskMethodBuilder<CustomerCard> <>t__builder;

			// Token: 0x040030CE RID: 12494
			public int customerId;

			// Token: 0x040030CF RID: 12495
			private GenericRepository<clients> <repo>5__2;

			// Token: 0x040030D0 RID: 12496
			private TaskAwaiter<clients> <>u__1;
		}

		// Token: 0x020009E9 RID: 2537
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x06004BBB RID: 19387 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x06004BBC RID: 19388 RVA: 0x00135EF4 File Offset: 0x001340F4
			internal clients <CreateManyClients>b__0(ICustomer c)
			{
				clients clients = ClientsModel.SetDefaultValues(this.ctx.clients.Create());
				clients.name = c.FirstName;
				clients.surname = c.LastName;
				clients.patronymic = c.Patronymic;
				clients.ur_name = c.UrName;
				clients.type = c.Type;
				ClientsModel.AddTel(clients, c.Phone);
				return clients;
			}

			// Token: 0x040030D1 RID: 12497
			public auseceEntities ctx;
		}

		// Token: 0x020009EA RID: 2538
		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x06004BBD RID: 19389 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x040030D2 RID: 12498
			public string recordId;
		}

		// Token: 0x020009EB RID: 2539
		[CompilerGenerated]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x06004BBE RID: 19390 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass11_0()
			{
			}

			// Token: 0x040030D3 RID: 12499
			public int customerId;
		}

		// Token: 0x020009EC RID: 2540
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCustomerPaymentDetails>d__11 : IAsyncStateMachine
		{
			// Token: 0x06004BBF RID: 19391 RVA: 0x00135F60 File Offset: 0x00134160
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IEnumerable<PaymentDetails> result2;
				try
				{
					ClientsModel.<>c__DisplayClass11_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new ClientsModel.<>c__DisplayClass11_0();
						CS$<>8__locals1.customerId = this.customerId;
						this.<repo>5__2 = new GenericRepository<banks>();
					}
					try
					{
						TaskAwaiter<IEnumerable<banks>> awaiter;
						if (num != 0)
						{
							awaiter = this.<repo>5__2.GetAllAsync((banks b) => b.client == (int?)CS$<>8__locals1.customerId, null, "clients").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<banks>>, ClientsModel.<GetCustomerPaymentDetails>d__11>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IEnumerable<banks>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						IEnumerable<banks> result = awaiter.GetResult();
						if (result.Any<banks>())
						{
							result2 = result.Select(new Func<banks, PaymentDetails>(InvoiceModel.BankToCustomerPaymentDetails)).ToList<PaymentDetails>();
						}
						else
						{
							result2 = new List<PaymentDetails>();
						}
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
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06004BC0 RID: 19392 RVA: 0x00136118 File Offset: 0x00134318
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040030D4 RID: 12500
			public int <>1__state;

			// Token: 0x040030D5 RID: 12501
			public AsyncTaskMethodBuilder<IEnumerable<PaymentDetails>> <>t__builder;

			// Token: 0x040030D6 RID: 12502
			public int customerId;

			// Token: 0x040030D7 RID: 12503
			private GenericRepository<banks> <repo>5__2;

			// Token: 0x040030D8 RID: 12504
			private TaskAwaiter<IEnumerable<banks>> <>u__1;
		}

		// Token: 0x020009ED RID: 2541
		[CompilerGenerated]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x06004BC1 RID: 19393 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x06004BC2 RID: 19394 RVA: 0x00136134 File Offset: 0x00134334
			internal bool <HasInvoices>b__0()
			{
				bool result;
				using (GenericRepository<invoice> genericRepository = new GenericRepository<invoice>())
				{
					result = genericRepository.Any((invoice i) => i.banks1.client == (int?)this.customerId);
				}
				return result;
			}

			// Token: 0x040030D9 RID: 12505
			public int customerId;
		}

		// Token: 0x020009EE RID: 2542
		[CompilerGenerated]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x06004BC3 RID: 19395 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass13_0()
			{
			}

			// Token: 0x040030DA RID: 12506
			public int customerId;
		}

		// Token: 0x020009EF RID: 2543
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004BC4 RID: 19396 RVA: 0x001361EC File Offset: 0x001343EC
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004BC5 RID: 19397 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06004BC6 RID: 19398 RVA: 0x00136204 File Offset: 0x00134404
			internal bool <RefreshPurchasesCount>b__13_1(store_sales s)
			{
				int? state = s.docs.state;
				return state.GetValueOrDefault() == 5 & state != null;
			}

			// Token: 0x06004BC7 RID: 19399 RVA: 0x00136230 File Offset: 0x00134430
			internal int <MergeCustomers>b__14_0(ICustomer c)
			{
				return c.Id;
			}

			// Token: 0x06004BC8 RID: 19400 RVA: 0x00136204 File Offset: 0x00134404
			internal bool <MergeCustomers>b__14_19(store_sales s)
			{
				int? state = s.docs.state;
				return state.GetValueOrDefault() == 5 & state != null;
			}

			// Token: 0x06004BC9 RID: 19401 RVA: 0x00136204 File Offset: 0x00134404
			internal bool <MergeCustomers>b__14_18(store_sales s)
			{
				int? state = s.docs.state;
				return state.GetValueOrDefault() == 5 & state != null;
			}

			// Token: 0x040030DB RID: 12507
			public static readonly ClientsModel.<>c <>9 = new ClientsModel.<>c();

			// Token: 0x040030DC RID: 12508
			public static Func<store_sales, bool> <>9__13_1;

			// Token: 0x040030DD RID: 12509
			public static Func<ICustomer, int> <>9__14_0;

			// Token: 0x040030DE RID: 12510
			public static Func<store_sales, bool> <>9__14_19;

			// Token: 0x040030DF RID: 12511
			public static Func<store_sales, bool> <>9__14_18;
		}

		// Token: 0x020009F0 RID: 2544
		[CompilerGenerated]
		private sealed class <>c__DisplayClass14_0
		{
			// Token: 0x06004BCA RID: 19402 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass14_0()
			{
			}

			// Token: 0x040030E0 RID: 12512
			public List<int> ids;
		}
	}
}
