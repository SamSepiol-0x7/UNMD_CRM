using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using ASC.Common.Interfaces;
using ASC.Objects;
using ASC.Objects.Converters;
using ASC.Objects.Reports;
using ASC.SimpleClasses;
using NLog;

namespace ASC.Models
{
	// Token: 0x020009BE RID: 2494
	public class DocumentsModel : ItemsModel
	{
		// Token: 0x06004AD0 RID: 19152 RVA: 0x0012EEF4 File Offset: 0x0012D0F4
		public static SaleDocument DefaultSaleDocument()
		{
			return new SaleDocument
			{
				Date = DateTime.UtcNow,
				Status = DocStates.NotActive,
				OfficeId = OfflineData.Instance.Employee.OfficeId,
				EmployeeId = OfflineData.Instance.Employee.Id,
				Type = DocType.RashodnayaNakladnaya,
				Reason = "Empty",
				ReserveDays = Auth.Config.default_reserve_days,
				Customer = ClientsModel.DefaultCustomer().Client2CustomerCard()
			};
		}

		// Token: 0x06004AD1 RID: 19153 RVA: 0x0012EF74 File Offset: 0x0012D174
		public static GoodsMoveDocument DefaultMoveDocument()
		{
			return new GoodsMoveDocument
			{
				Date = DateTime.UtcNow,
				Status = DocStates.NotActive,
				OfficeId = OfflineData.Instance.Employee.OfficeId,
				EmployeeId = OfflineData.Instance.Employee.Id,
				Type = DocType.InternalRelocation,
				Reason = "Empty",
				ReserveDays = Auth.Config.default_reserve_days
			};
		}

		// Token: 0x06004AD2 RID: 19154 RVA: 0x0012EFE4 File Offset: 0x0012D1E4
		public static Task<List<DocsList>> GetDocs(IPeriod period, bool inCurrentOffice, string searchQuery, int documentsType = 0)
		{
			DocumentsModel.<GetDocs>d__3 <GetDocs>d__;
			<GetDocs>d__.<>t__builder = AsyncTaskMethodBuilder<List<DocsList>>.Create();
			<GetDocs>d__.period = period;
			<GetDocs>d__.inCurrentOffice = inCurrentOffice;
			<GetDocs>d__.searchQuery = searchQuery;
			<GetDocs>d__.documentsType = documentsType;
			<GetDocs>d__.<>1__state = -1;
			<GetDocs>d__.<>t__builder.Start<DocumentsModel.<GetDocs>d__3>(ref <GetDocs>d__);
			return <GetDocs>d__.<>t__builder.Task;
		}

		// Token: 0x06004AD3 RID: 19155 RVA: 0x0012F040 File Offset: 0x0012D240
		private static Func<docs, DocsList> DocumentsLiteFunc()
		{
			return (docs i) => new DocsList
			{
				id = i.id,
				state = i.state,
				created = i.created,
				FirstName = i.users.name,
				LastName = i.users.surname,
				Patronymic = i.users.patronymic,
				username = i.users.username,
				Office = i.offices.name,
				total = i.total,
				dealer = i.dealer,
				type = i.type,
				OrderId = i.order_id,
				OfficeId = i.office,
				Customer = i.clients.Client2Customer()
			};
		}

		// Token: 0x06004AD4 RID: 19156 RVA: 0x0012F06C File Offset: 0x0012D26C
		public bool CreateDocument(docs document, IEnumerable<store_items> items)
		{
			bool result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					auseceEntities.docs.Add(document);
					auseceEntities.SaveChanges();
					base.CreateStoreSales(items, document.id);
					ItemsModel.SubstractItems(items, true);
					this.SetDocumentState(document.id, 6);
					result = true;
				}
			}
			catch (Exception exception)
			{
				DocumentsModel.Log.Error(exception, "Create document fail");
				result = false;
			}
			return result;
		}

		// Token: 0x06004AD5 RID: 19157 RVA: 0x0012F0F8 File Offset: 0x0012D2F8
		public Task<int> CreateArrivalDocument(docs document, List<Product> items, bool createRko, int paymentOption)
		{
			DocumentsModel.<CreateArrivalDocument>d__6 <CreateArrivalDocument>d__;
			<CreateArrivalDocument>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<CreateArrivalDocument>d__.<>4__this = this;
			<CreateArrivalDocument>d__.document = document;
			<CreateArrivalDocument>d__.items = items;
			<CreateArrivalDocument>d__.createRko = createRko;
			<CreateArrivalDocument>d__.paymentOption = paymentOption;
			<CreateArrivalDocument>d__.<>1__state = -1;
			<CreateArrivalDocument>d__.<>t__builder.Start<DocumentsModel.<CreateArrivalDocument>d__6>(ref <CreateArrivalDocument>d__);
			return <CreateArrivalDocument>d__.<>t__builder.Task;
		}

		// Token: 0x06004AD6 RID: 19158 RVA: 0x0012F15C File Offset: 0x0012D35C
		public Task<List<cash_orders>> LoadCashOrders(int documentId)
		{
			DocumentsModel.<LoadCashOrders>d__7 <LoadCashOrders>d__;
			<LoadCashOrders>d__.<>t__builder = AsyncTaskMethodBuilder<List<cash_orders>>.Create();
			<LoadCashOrders>d__.documentId = documentId;
			<LoadCashOrders>d__.<>1__state = -1;
			<LoadCashOrders>d__.<>t__builder.Start<DocumentsModel.<LoadCashOrders>d__7>(ref <LoadCashOrders>d__);
			return <LoadCashOrders>d__.<>t__builder.Task;
		}

		// Token: 0x06004AD7 RID: 19159 RVA: 0x0012F1A0 File Offset: 0x0012D3A0
		public static Task<List<store_sales>> LoadSales(int documentId)
		{
			DocumentsModel.<LoadSales>d__8 <LoadSales>d__;
			<LoadSales>d__.<>t__builder = AsyncTaskMethodBuilder<List<store_sales>>.Create();
			<LoadSales>d__.documentId = documentId;
			<LoadSales>d__.<>1__state = -1;
			<LoadSales>d__.<>t__builder.Start<DocumentsModel.<LoadSales>d__8>(ref <LoadSales>d__);
			return <LoadSales>d__.<>t__builder.Task;
		}

		// Token: 0x06004AD8 RID: 19160 RVA: 0x0012F1E4 File Offset: 0x0012D3E4
		public static Task<List<store_items>> LoadSoldItems(int documentId)
		{
			DocumentsModel.<LoadSoldItems>d__9 <LoadSoldItems>d__;
			<LoadSoldItems>d__.<>t__builder = AsyncTaskMethodBuilder<List<store_items>>.Create();
			<LoadSoldItems>d__.documentId = documentId;
			<LoadSoldItems>d__.<>1__state = -1;
			<LoadSoldItems>d__.<>t__builder.Start<DocumentsModel.<LoadSoldItems>d__9>(ref <LoadSoldItems>d__);
			return <LoadSoldItems>d__.<>t__builder.Task;
		}

		// Token: 0x06004AD9 RID: 19161 RVA: 0x0012F228 File Offset: 0x0012D428
		public static Task<List<logs>> LoadHistory(int documentId)
		{
			DocumentsModel.<LoadHistory>d__10 <LoadHistory>d__;
			<LoadHistory>d__.<>t__builder = AsyncTaskMethodBuilder<List<logs>>.Create();
			<LoadHistory>d__.documentId = documentId;
			<LoadHistory>d__.<>1__state = -1;
			<LoadHistory>d__.<>t__builder.Start<DocumentsModel.<LoadHistory>d__10>(ref <LoadHistory>d__);
			return <LoadHistory>d__.<>t__builder.Task;
		}

		// Token: 0x06004ADA RID: 19162 RVA: 0x0012F26C File Offset: 0x0012D46C
		public void SetDocumentState(int documentId, int state)
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					docs docs = auseceEntities.docs.Find(new object[]
					{
						documentId
					});
					if (docs != null)
					{
						docs.state = new int?(state);
						auseceEntities.SaveChanges();
					}
				}
			}
			catch (Exception exception)
			{
				DocumentsModel.Log.Error(exception, "Set document state fail");
			}
		}

		// Token: 0x06004ADB RID: 19163 RVA: 0x0012F2F0 File Offset: 0x0012D4F0
		public static void SetReserveState(int documentId, int state)
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					docs docs = auseceEntities.docs.Find(new object[]
					{
						documentId
					});
					if (docs != null)
					{
						docs.reason = Lang.t("ReservedItems");
						docs.type = 6;
						docs.state = new int?(state);
						auseceEntities.SaveChanges();
					}
				}
			}
			catch (Exception exception)
			{
				DocumentsModel.Log.Error(exception, "Set document reserve state fail");
			}
		}

		// Token: 0x06004ADC RID: 19164 RVA: 0x0012F38C File Offset: 0x0012D58C
		public static void SetDocStateAndTypeRn(int documentId, DocStates state)
		{
			try
			{
				Localization localization = new Localization("UTC");
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					docs docs = auseceEntities.docs.Find(new object[]
					{
						documentId
					});
					docs.state = new int?((int)state);
					docs.type = 2;
					docs.created = localization.Now;
					auseceEntities.SaveChanges();
				}
			}
			catch (Exception exception)
			{
				DocumentsModel.Log.Error(exception, "Set document state and type fail");
			}
		}

		// Token: 0x06004ADD RID: 19165 RVA: 0x0012F428 File Offset: 0x0012D628
		public void UpdateDocumentAfterPko(int documentId, int cashOrderId)
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					docs docs = auseceEntities.docs.Find(new object[]
					{
						documentId
					});
					if (docs != null)
					{
						docs.reason = string.Format((string)Application.Current.TryFindResource("PnDocumentReason"), cashOrderId.ToString("D6"));
						docs.order_id = new int?(cashOrderId);
						docs.state = new int?(5);
						auseceEntities.SaveChanges();
					}
				}
			}
			catch (Exception exception)
			{
				DocumentsModel.Log.Error(exception, "Update document state after pko fail");
			}
		}

		// Token: 0x06004ADE RID: 19166 RVA: 0x0012F4E4 File Offset: 0x0012D6E4
		public Task<docs> LoadDocument(int documentId)
		{
			DocumentsModel.<LoadDocument>d__15 <LoadDocument>d__;
			<LoadDocument>d__.<>t__builder = AsyncTaskMethodBuilder<docs>.Create();
			<LoadDocument>d__.documentId = documentId;
			<LoadDocument>d__.<>1__state = -1;
			<LoadDocument>d__.<>t__builder.Start<DocumentsModel.<LoadDocument>d__15>(ref <LoadDocument>d__);
			return <LoadDocument>d__.<>t__builder.Task;
		}

		// Token: 0x06004ADF RID: 19167 RVA: 0x0012F528 File Offset: 0x0012D728
		public static Task<SaleDocument> GetStoreDocument(int documentId)
		{
			DocumentsModel.<GetStoreDocument>d__16 <GetStoreDocument>d__;
			<GetStoreDocument>d__.<>t__builder = AsyncTaskMethodBuilder<SaleDocument>.Create();
			<GetStoreDocument>d__.documentId = documentId;
			<GetStoreDocument>d__.<>1__state = -1;
			<GetStoreDocument>d__.<>t__builder.Start<DocumentsModel.<GetStoreDocument>d__16>(ref <GetStoreDocument>d__);
			return <GetStoreDocument>d__.<>t__builder.Task;
		}

		// Token: 0x06004AE0 RID: 19168 RVA: 0x0012F56C File Offset: 0x0012D76C
		public string CancellPn(int documentId)
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					docs docs = auseceEntities.docs.Find(new object[]
					{
						documentId
					});
					if (docs != null)
					{
						int? state = docs.state;
						List<store_items> list = (from i in auseceEntities.store_items
						where i.document == (int?)documentId
						select i).ToList<store_items>();
						if (!list.Any((store_items i) => i.reserved > 0))
						{
							if (!list.Any((store_items i) => i.in_count < i.count))
							{
								foreach (store_items store_items in list)
								{
									store_items.count = 0;
									store_items.minimum_in_stock = 0;
								}
								docs.state = new int?(8);
								auseceEntities.SaveChanges();
								int? num = state;
								if (num.GetValueOrDefault() == 2 & num != null)
								{
									if (!auseceEntities.cash_orders.Any((cash_orders o) => o.document == (int?)documentId))
									{
										return (string)Application.Current.TryFindResource("PnCancellationNotPossible");
									}
									KassaModel kassaModel = new KassaModel();
									kassaModel.NewCashOrder(docs, 16, docs.dealer, true);
									kassaModel.MakePko(false);
								}
								goto IL_25A;
							}
						}
						return (string)Application.Current.TryFindResource("PnCancellationNotPossible");
					}
					return "Document not found";
				}
				IL_25A:;
			}
			catch (Exception ex)
			{
				DocumentsModel.Log.Error<Exception>(ex);
				return ex.Message;
			}
			return (string)Application.Current.TryFindResource("Complete");
		}

		// Token: 0x06004AE1 RID: 19169 RVA: 0x0012F854 File Offset: 0x0012DA54
		public static IAscResult SaveNotes(IStoreDocument d)
		{
			IAscResult result;
			using (GenericRepository<docs> genericRepository = new GenericRepository<docs>())
			{
				docs firstOrDefault = genericRepository.GetFirstOrDefault((docs doc) => doc.id == d.Id, "");
				firstOrDefault.notes = d.Notes;
				IAscResult ascResult = genericRepository.Update(firstOrDefault);
				if (ascResult.IsSucces)
				{
					HistoryV2 historyV = new HistoryV2();
					historyV.AddDocumentLog("NotesChanged", d.Id, d.Notes);
					historyV.Save();
				}
				result = ascResult;
			}
			return result;
		}

		// Token: 0x06004AE2 RID: 19170 RVA: 0x0012F95C File Offset: 0x0012DB5C
		public static Task<StoreDocument> GetDocument(int documentId)
		{
			DocumentsModel.<GetDocument>d__19 <GetDocument>d__;
			<GetDocument>d__.<>t__builder = AsyncTaskMethodBuilder<StoreDocument>.Create();
			<GetDocument>d__.documentId = documentId;
			<GetDocument>d__.<>1__state = -1;
			<GetDocument>d__.<>t__builder.Start<DocumentsModel.<GetDocument>d__19>(ref <GetDocument>d__);
			return <GetDocument>d__.<>t__builder.Task;
		}

		// Token: 0x06004AE3 RID: 19171 RVA: 0x0012F9A0 File Offset: 0x0012DBA0
		public DocumentsModel()
		{
		}

		// Token: 0x06004AE4 RID: 19172 RVA: 0x0012F9B4 File Offset: 0x0012DBB4
		// Note: this type is marked as 'beforefieldinit'.
		static DocumentsModel()
		{
		}

		// Token: 0x04003020 RID: 12320
		private static readonly ILogger Log = LogManager.GetCurrentClassLogger();

		// Token: 0x020009BF RID: 2495
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06004AE5 RID: 19173 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x04003021 RID: 12321
			public int documentsType;

			// Token: 0x04003022 RID: 12322
			public string searchQuery;
		}

		// Token: 0x020009C0 RID: 2496
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_1
		{
			// Token: 0x06004AE6 RID: 19174 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass3_1()
			{
			}

			// Token: 0x04003023 RID: 12323
			public DateTime from;

			// Token: 0x04003024 RID: 12324
			public DateTime to;
		}

		// Token: 0x020009C1 RID: 2497
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004AE7 RID: 19175 RVA: 0x0012F9CC File Offset: 0x0012DBCC
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004AE8 RID: 19176 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06004AE9 RID: 19177 RVA: 0x0012F9E4 File Offset: 0x0012DBE4
			internal IOrderedQueryable<docs> <GetDocs>b__3_6(IQueryable<docs> i)
			{
				return from d in i
				orderby d.id
				select d;
			}

			// Token: 0x06004AEA RID: 19178 RVA: 0x0012FA30 File Offset: 0x0012DC30
			internal DocsList <DocumentsLiteFunc>b__4_0(docs i)
			{
				return new DocsList
				{
					id = i.id,
					state = i.state,
					created = i.created,
					FirstName = i.users.name,
					LastName = i.users.surname,
					Patronymic = i.users.patronymic,
					username = i.users.username,
					Office = i.offices.name,
					total = i.total,
					dealer = i.dealer,
					type = i.type,
					OrderId = i.order_id,
					OfficeId = i.office,
					Customer = i.clients.Client2Customer()
				};
			}

			// Token: 0x06004AEB RID: 19179 RVA: 0x0012FB08 File Offset: 0x0012DD08
			internal bool <CancellPn>b__17_1(store_items i)
			{
				return i.reserved > 0;
			}

			// Token: 0x06004AEC RID: 19180 RVA: 0x0012FB20 File Offset: 0x0012DD20
			internal bool <CancellPn>b__17_2(store_items i)
			{
				return i.in_count < i.count;
			}

			// Token: 0x04003025 RID: 12325
			public static readonly DocumentsModel.<>c <>9 = new DocumentsModel.<>c();

			// Token: 0x04003026 RID: 12326
			public static Func<IQueryable<docs>, IOrderedQueryable<docs>> <>9__3_6;

			// Token: 0x04003027 RID: 12327
			public static Func<docs, DocsList> <>9__4_0;

			// Token: 0x04003028 RID: 12328
			public static Func<store_items, bool> <>9__17_1;

			// Token: 0x04003029 RID: 12329
			public static Func<store_items, bool> <>9__17_2;
		}

		// Token: 0x020009C2 RID: 2498
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetDocs>d__3 : IAsyncStateMachine
		{
			// Token: 0x06004AED RID: 19181 RVA: 0x0012FB3C File Offset: 0x0012DD3C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<DocsList> result2;
				try
				{
					DocumentsModel.<>c__DisplayClass3_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new DocumentsModel.<>c__DisplayClass3_0();
						CS$<>8__locals1.documentsType = this.documentsType;
						CS$<>8__locals1.searchQuery = this.searchQuery;
						this.<repo>5__2 = new GenericRepository<docs>();
					}
					try
					{
						TaskAwaiter<IEnumerable<docs>> awaiter;
						if (num != 0)
						{
							DocumentsModel.<>c__DisplayClass3_1 CS$<>8__locals2 = new DocumentsModel.<>c__DisplayClass3_1();
							CS$<>8__locals2.from = this.period.From;
							CS$<>8__locals2.to = this.period.To.AddHours(23.0).AddMinutes(59.0).AddSeconds(59.0);
							bool key = string.IsNullOrEmpty(CS$<>8__locals1.searchQuery);
							List<KeyValuePair<bool, Expression<Func<docs, bool>>>> filterList = new List<KeyValuePair<bool, Expression<Func<docs, bool>>>>
							{
								new KeyValuePair<bool, Expression<Func<docs, bool>>>(true, (docs i) => i.state > (int?)0),
								new KeyValuePair<bool, Expression<Func<docs, bool>>>(key, (docs i) => i.created >= CS$<>8__locals2.from && i.created <= CS$<>8__locals2.to),
								new KeyValuePair<bool, Expression<Func<docs, bool>>>(this.inCurrentOffice, (docs i) => i.office == Auth.User.office),
								new KeyValuePair<bool, Expression<Func<docs, bool>>>(CS$<>8__locals1.documentsType != 0, (docs i) => i.type == CS$<>8__locals1.documentsType),
								new KeyValuePair<bool, Expression<Func<docs, bool>>>(!string.IsNullOrEmpty(CS$<>8__locals1.searchQuery), (docs i) => CS$<>8__locals1.searchQuery.Contains(i.id.ToString()) || i.store_sales.Any((store_sales s) => s.sn.Contains(CS$<>8__locals1.searchQuery)) || (i.clients != null && (i.clients.ur_name.Contains(CS$<>8__locals1.searchQuery) || i.clients.surname.Contains(CS$<>8__locals1.searchQuery) || i.clients.name.Contains(CS$<>8__locals1.searchQuery) || i.clients.patronymic.Contains(CS$<>8__locals1.searchQuery))))
							};
							awaiter = this.<repo>5__2.GetAllAsync(filterList, new Func<IQueryable<docs>, IOrderedQueryable<docs>>(DocumentsModel.<>c.<>9.<GetDocs>b__3_6), "clients", false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<docs>>, DocumentsModel.<GetDocs>d__3>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IEnumerable<docs>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						IEnumerable<docs> result = awaiter.GetResult();
						if (!result.Any<docs>())
						{
							result2 = new List<DocsList>();
						}
						else
						{
							result2 = result.Select(DocumentsModel.DocumentsLiteFunc()).ToList<DocsList>();
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

			// Token: 0x06004AEE RID: 19182 RVA: 0x00130290 File Offset: 0x0012E490
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400302A RID: 12330
			public int <>1__state;

			// Token: 0x0400302B RID: 12331
			public AsyncTaskMethodBuilder<List<DocsList>> <>t__builder;

			// Token: 0x0400302C RID: 12332
			public int documentsType;

			// Token: 0x0400302D RID: 12333
			public string searchQuery;

			// Token: 0x0400302E RID: 12334
			public IPeriod period;

			// Token: 0x0400302F RID: 12335
			public bool inCurrentOffice;

			// Token: 0x04003030 RID: 12336
			private GenericRepository<docs> <repo>5__2;

			// Token: 0x04003031 RID: 12337
			private TaskAwaiter<IEnumerable<docs>> <>u__1;
		}

		// Token: 0x020009C3 RID: 2499
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateArrivalDocument>d__6 : IAsyncStateMachine
		{
			// Token: 0x06004AEF RID: 19183 RVA: 0x001302AC File Offset: 0x0012E4AC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				DocumentsModel documentsModel = this.<>4__this;
				int id;
				try
				{
					if (num > 3)
					{
						this.<history>5__2 = new HistoryV2();
						this.<ctx>5__3 = new auseceEntities(true);
					}
					try
					{
						if (num > 3)
						{
							this.<transaction>5__4 = this.<ctx>5__3.Database.BeginTransaction();
						}
						try
						{
							TaskAwaiter<int> awaiter;
							TaskAwaiter awaiter2;
							switch (num)
							{
							case 0:
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<int>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								break;
							}
							case 1:
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<int>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
								goto IL_233;
							}
							case 2:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
								goto IL_2AA;
							}
							case 3:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter);
								int num5 = -1;
								num = -1;
								this.<>1__state = num5;
								goto IL_318;
							}
							default:
								this.<ctx>5__3.docs.Add(this.document);
								this.document.state = new int?(1);
								awaiter = this.<ctx>5__3.SaveChangesAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num6 = 0;
									num = 0;
									this.<>1__state = num6;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, DocumentsModel.<CreateArrivalDocument>d__6>(ref awaiter, ref this);
									return;
								}
								break;
							}
							awaiter.GetResult();
							this.<history>5__2.Add(50, new string[]
							{
								this.document.id.ToString(),
								this.document.total.ToString(CultureInfo.CurrentCulture),
								this.items.Count.ToString()
							});
							if (!this.createRko || !(this.document.total > 0m) || this.document.is_realization)
							{
								goto IL_23B;
							}
							KassaModel kassaModel = new KassaModel();
							kassaModel.NewCashOrder(this.document, 2, null, true);
							kassaModel.SetPaymentSystem(this.paymentOption);
							this.document.order_id = new int?(kassaModel.MakeRko(this.<ctx>5__3, this.<history>5__2, false, 0));
							this.document.state = new int?(2);
							awaiter = this.<ctx>5__3.SaveChangesAsync().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num7 = 1;
								num = 1;
								this.<>1__state = num7;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, DocumentsModel.<CreateArrivalDocument>d__6>(ref awaiter, ref this);
								return;
							}
							IL_233:
							awaiter.GetResult();
							IL_23B:
							awaiter2 = documentsModel.CreateProducts(this.<ctx>5__3, this.<history>5__2, this.document, this.items).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num8 = 2;
								num = 2;
								this.<>1__state = num8;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, DocumentsModel.<CreateArrivalDocument>d__6>(ref awaiter2, ref this);
								return;
							}
							IL_2AA:
							awaiter2.GetResult();
							this.<transaction>5__4.Commit();
							awaiter2 = this.<history>5__2.SaveAsync().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num9 = 3;
								num = 3;
								this.<>1__state = num9;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, DocumentsModel.<CreateArrivalDocument>d__6>(ref awaiter2, ref this);
								return;
							}
							IL_318:
							awaiter2.GetResult();
							id = this.document.id;
						}
						catch (Exception)
						{
							this.<transaction>5__4.Rollback();
							throw;
						}
						finally
						{
							if (num < 0 && this.<transaction>5__4 != null)
							{
								((IDisposable)this.<transaction>5__4).Dispose();
							}
						}
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

			// Token: 0x06004AF0 RID: 19184 RVA: 0x001306C4 File Offset: 0x0012E8C4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003032 RID: 12338
			public int <>1__state;

			// Token: 0x04003033 RID: 12339
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x04003034 RID: 12340
			public docs document;

			// Token: 0x04003035 RID: 12341
			public List<Product> items;

			// Token: 0x04003036 RID: 12342
			public bool createRko;

			// Token: 0x04003037 RID: 12343
			public int paymentOption;

			// Token: 0x04003038 RID: 12344
			public DocumentsModel <>4__this;

			// Token: 0x04003039 RID: 12345
			private HistoryV2 <history>5__2;

			// Token: 0x0400303A RID: 12346
			private auseceEntities <ctx>5__3;

			// Token: 0x0400303B RID: 12347
			private DbContextTransaction <transaction>5__4;

			// Token: 0x0400303C RID: 12348
			private TaskAwaiter<int> <>u__1;

			// Token: 0x0400303D RID: 12349
			private TaskAwaiter <>u__2;
		}

		// Token: 0x020009C4 RID: 2500
		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x06004AF1 RID: 19185 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x0400303E RID: 12350
			public int documentId;
		}

		// Token: 0x020009C5 RID: 2501
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadCashOrders>d__7 : IAsyncStateMachine
		{
			// Token: 0x06004AF2 RID: 19186 RVA: 0x001306E0 File Offset: 0x0012E8E0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<cash_orders> result;
				try
				{
					DocumentsModel.<>c__DisplayClass7_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new DocumentsModel.<>c__DisplayClass7_0();
						CS$<>8__locals1.documentId = this.documentId;
						this.<repo>5__2 = new GenericRepository<cash_orders>();
					}
					try
					{
						TaskAwaiter<IEnumerable<cash_orders>> awaiter;
						if (num != 0)
						{
							awaiter = this.<repo>5__2.GetAllAsync((cash_orders o) => o.document == (int?)CS$<>8__locals1.documentId, null, "users").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<cash_orders>>, DocumentsModel.<LoadCashOrders>d__7>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IEnumerable<cash_orders>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = new List<cash_orders>(awaiter.GetResult());
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

			// Token: 0x06004AF3 RID: 19187 RVA: 0x00130870 File Offset: 0x0012EA70
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400303F RID: 12351
			public int <>1__state;

			// Token: 0x04003040 RID: 12352
			public AsyncTaskMethodBuilder<List<cash_orders>> <>t__builder;

			// Token: 0x04003041 RID: 12353
			public int documentId;

			// Token: 0x04003042 RID: 12354
			private GenericRepository<cash_orders> <repo>5__2;

			// Token: 0x04003043 RID: 12355
			private TaskAwaiter<IEnumerable<cash_orders>> <>u__1;
		}

		// Token: 0x020009C6 RID: 2502
		[CompilerGenerated]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x06004AF4 RID: 19188 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x04003044 RID: 12356
			public int documentId;
		}

		// Token: 0x020009C7 RID: 2503
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadSales>d__8 : IAsyncStateMachine
		{
			// Token: 0x06004AF5 RID: 19189 RVA: 0x0013088C File Offset: 0x0012EA8C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<store_sales> result;
				try
				{
					DocumentsModel.<>c__DisplayClass8_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new DocumentsModel.<>c__DisplayClass8_0();
						CS$<>8__locals1.documentId = this.documentId;
						this.<repo>5__2 = new GenericRepository<store_sales>();
					}
					try
					{
						TaskAwaiter<IEnumerable<store_sales>> awaiter;
						if (num != 0)
						{
							awaiter = this.<repo>5__2.GetAllAsync((store_sales i) => i.document_id == CS$<>8__locals1.documentId, null, "store_items,clients").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<store_sales>>, DocumentsModel.<LoadSales>d__8>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IEnumerable<store_sales>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = new List<store_sales>(awaiter.GetResult());
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

			// Token: 0x06004AF6 RID: 19190 RVA: 0x00130A0C File Offset: 0x0012EC0C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003045 RID: 12357
			public int <>1__state;

			// Token: 0x04003046 RID: 12358
			public AsyncTaskMethodBuilder<List<store_sales>> <>t__builder;

			// Token: 0x04003047 RID: 12359
			public int documentId;

			// Token: 0x04003048 RID: 12360
			private GenericRepository<store_sales> <repo>5__2;

			// Token: 0x04003049 RID: 12361
			private TaskAwaiter<IEnumerable<store_sales>> <>u__1;
		}

		// Token: 0x020009C8 RID: 2504
		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x06004AF7 RID: 19191 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x06004AF8 RID: 19192 RVA: 0x00130A28 File Offset: 0x0012EC28
			internal store_items <LoadSoldItems>b__0(store_sales item)
			{
				return item.SaleToStoreItem(this.documentId);
			}

			// Token: 0x0400304A RID: 12362
			public int documentId;
		}

		// Token: 0x020009C9 RID: 2505
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadSoldItems>d__9 : IAsyncStateMachine
		{
			// Token: 0x06004AF9 RID: 19193 RVA: 0x00130A44 File Offset: 0x0012EC44
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<store_items> result2;
				try
				{
					TaskAwaiter<List<store_sales>> awaiter;
					if (num != 0)
					{
						this.<>8__1 = new DocumentsModel.<>c__DisplayClass9_0();
						this.<>8__1.documentId = this.documentId;
						awaiter = DocumentsModel.LoadSales(this.<>8__1.documentId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_sales>>, DocumentsModel.<LoadSoldItems>d__9>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<store_sales>>);
						this.<>1__state = -1;
					}
					List<store_sales> result = awaiter.GetResult();
					if (result.Any<store_sales>())
					{
						result2 = result.Select(new Func<store_sales, store_items>(this.<>8__1.<LoadSoldItems>b__0)).ToList<store_items>();
					}
					else
					{
						result2 = new List<store_items>();
					}
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
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06004AFA RID: 19194 RVA: 0x00130B58 File Offset: 0x0012ED58
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400304B RID: 12363
			public int <>1__state;

			// Token: 0x0400304C RID: 12364
			public AsyncTaskMethodBuilder<List<store_items>> <>t__builder;

			// Token: 0x0400304D RID: 12365
			public int documentId;

			// Token: 0x0400304E RID: 12366
			private DocumentsModel.<>c__DisplayClass9_0 <>8__1;

			// Token: 0x0400304F RID: 12367
			private TaskAwaiter<List<store_sales>> <>u__1;
		}

		// Token: 0x020009CA RID: 2506
		[CompilerGenerated]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x06004AFB RID: 19195 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x04003050 RID: 12368
			public int documentId;
		}

		// Token: 0x020009CB RID: 2507
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadHistory>d__10 : IAsyncStateMachine
		{
			// Token: 0x06004AFC RID: 19196 RVA: 0x00130B74 File Offset: 0x0012ED74
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<logs> result;
				try
				{
					DocumentsModel.<>c__DisplayClass10_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new DocumentsModel.<>c__DisplayClass10_0();
						CS$<>8__locals1.documentId = this.documentId;
						this.<repo>5__2 = new GenericRepository<logs>();
					}
					try
					{
						TaskAwaiter<IEnumerable<logs>> awaiter;
						if (num != 0)
						{
							awaiter = this.<repo>5__2.GetAllAsync((logs l) => l.document == (int?)CS$<>8__locals1.documentId, null, "users").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<logs>>, DocumentsModel.<LoadHistory>d__10>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IEnumerable<logs>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = new List<logs>(awaiter.GetResult());
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

			// Token: 0x06004AFD RID: 19197 RVA: 0x00130D04 File Offset: 0x0012EF04
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003051 RID: 12369
			public int <>1__state;

			// Token: 0x04003052 RID: 12370
			public AsyncTaskMethodBuilder<List<logs>> <>t__builder;

			// Token: 0x04003053 RID: 12371
			public int documentId;

			// Token: 0x04003054 RID: 12372
			private GenericRepository<logs> <repo>5__2;

			// Token: 0x04003055 RID: 12373
			private TaskAwaiter<IEnumerable<logs>> <>u__1;
		}

		// Token: 0x020009CC RID: 2508
		[CompilerGenerated]
		private sealed class <>c__DisplayClass15_0
		{
			// Token: 0x06004AFE RID: 19198 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass15_0()
			{
			}

			// Token: 0x04003056 RID: 12374
			public int documentId;
		}

		// Token: 0x020009CD RID: 2509
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadDocument>d__15 : IAsyncStateMachine
		{
			// Token: 0x06004AFF RID: 19199 RVA: 0x00130D20 File Offset: 0x0012EF20
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				docs result;
				try
				{
					DocumentsModel.<>c__DisplayClass15_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new DocumentsModel.<>c__DisplayClass15_0();
						CS$<>8__locals1.documentId = this.documentId;
						this.<repo>5__2 = new GenericRepository<docs>();
					}
					try
					{
						TaskAwaiter<docs> awaiter;
						if (num != 0)
						{
							awaiter = this.<repo>5__2.GetFirstOrDefaultAsync((docs d) => d.id == CS$<>8__locals1.documentId, "clients,users,stores,companies,cash_orders1,invoice1").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<docs>, DocumentsModel.<LoadDocument>d__15>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<docs>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult();
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

			// Token: 0x06004B00 RID: 19200 RVA: 0x00130E9C File Offset: 0x0012F09C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003057 RID: 12375
			public int <>1__state;

			// Token: 0x04003058 RID: 12376
			public AsyncTaskMethodBuilder<docs> <>t__builder;

			// Token: 0x04003059 RID: 12377
			public int documentId;

			// Token: 0x0400305A RID: 12378
			private GenericRepository<docs> <repo>5__2;

			// Token: 0x0400305B RID: 12379
			private TaskAwaiter<docs> <>u__1;
		}

		// Token: 0x020009CE RID: 2510
		[CompilerGenerated]
		private sealed class <>c__DisplayClass16_0
		{
			// Token: 0x06004B01 RID: 19201 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass16_0()
			{
			}

			// Token: 0x0400305C RID: 12380
			public int documentId;
		}

		// Token: 0x020009CF RID: 2511
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetStoreDocument>d__16 : IAsyncStateMachine
		{
			// Token: 0x06004B02 RID: 19202 RVA: 0x00130EB8 File Offset: 0x0012F0B8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				SaleDocument result;
				try
				{
					DocumentsModel.<>c__DisplayClass16_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new DocumentsModel.<>c__DisplayClass16_0();
						CS$<>8__locals1.documentId = this.documentId;
						this.<repo>5__2 = new GenericRepository<docs>();
					}
					try
					{
						TaskAwaiter<SaleDocument> awaiter;
						if (num != 0)
						{
							awaiter = this.<repo>5__2.GetFirstOrDefault((docs d) => d.id == CS$<>8__locals1.documentId, "clients,users,stores,companies,cash_orders1").ToSaleDocument().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<SaleDocument>, DocumentsModel.<GetStoreDocument>d__16>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<SaleDocument>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult();
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

			// Token: 0x06004B03 RID: 19203 RVA: 0x00131038 File Offset: 0x0012F238
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400305D RID: 12381
			public int <>1__state;

			// Token: 0x0400305E RID: 12382
			public AsyncTaskMethodBuilder<SaleDocument> <>t__builder;

			// Token: 0x0400305F RID: 12383
			public int documentId;

			// Token: 0x04003060 RID: 12384
			private GenericRepository<docs> <repo>5__2;

			// Token: 0x04003061 RID: 12385
			private TaskAwaiter<SaleDocument> <>u__1;
		}

		// Token: 0x020009D0 RID: 2512
		[CompilerGenerated]
		private sealed class <>c__DisplayClass17_0
		{
			// Token: 0x06004B04 RID: 19204 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass17_0()
			{
			}

			// Token: 0x04003062 RID: 12386
			public int documentId;
		}

		// Token: 0x020009D1 RID: 2513
		[CompilerGenerated]
		private sealed class <>c__DisplayClass18_0
		{
			// Token: 0x06004B05 RID: 19205 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass18_0()
			{
			}

			// Token: 0x04003063 RID: 12387
			public IStoreDocument d;
		}

		// Token: 0x020009D2 RID: 2514
		[CompilerGenerated]
		private sealed class <>c__DisplayClass19_0
		{
			// Token: 0x06004B06 RID: 19206 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass19_0()
			{
			}

			// Token: 0x04003064 RID: 12388
			public int documentId;
		}

		// Token: 0x020009D3 RID: 2515
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetDocument>d__19 : IAsyncStateMachine
		{
			// Token: 0x06004B07 RID: 19207 RVA: 0x00131054 File Offset: 0x0012F254
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				StoreDocument result;
				try
				{
					DocumentsModel.<>c__DisplayClass19_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new DocumentsModel.<>c__DisplayClass19_0();
						CS$<>8__locals1.documentId = this.documentId;
						this.<repo>5__2 = new GenericRepository<docs>();
					}
					try
					{
						TaskAwaiter<docs> awaiter;
						if (num != 0)
						{
							this.<repo>5__2.AsNoTracking();
							awaiter = this.<repo>5__2.GetFirstOrDefaultAsync((docs d) => d.id == CS$<>8__locals1.documentId, "store_sales,store_items").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<docs>, DocumentsModel.<GetDocument>d__19>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<docs>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult().ToStoreDocument();
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

			// Token: 0x06004B08 RID: 19208 RVA: 0x001311E0 File Offset: 0x0012F3E0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003065 RID: 12389
			public int <>1__state;

			// Token: 0x04003066 RID: 12390
			public AsyncTaskMethodBuilder<StoreDocument> <>t__builder;

			// Token: 0x04003067 RID: 12391
			public int documentId;

			// Token: 0x04003068 RID: 12392
			private GenericRepository<docs> <repo>5__2;

			// Token: 0x04003069 RID: 12393
			private TaskAwaiter<docs> <>u__1;
		}
	}
}
