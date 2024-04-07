using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Objects.Converters;
using NLog;

namespace ASC.ItemsSale
{
	// Token: 0x020001B1 RID: 433
	public class ItemsSaleModel : DocumentsModel
	{
		// Token: 0x0600190C RID: 6412 RVA: 0x000458DC File Offset: 0x00043ADC
		public static Task<bool> CancellReserve(IEnumerable<store_items> items, int? documentId = null, bool isSale = false)
		{
			ItemsSaleModel.<CancellReserve>d__1 <CancellReserve>d__;
			<CancellReserve>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<CancellReserve>d__.items = items;
			<CancellReserve>d__.documentId = documentId;
			<CancellReserve>d__.isSale = isSale;
			<CancellReserve>d__.<>1__state = -1;
			<CancellReserve>d__.<>t__builder.Start<ItemsSaleModel.<CancellReserve>d__1>(ref <CancellReserve>d__);
			return <CancellReserve>d__.<>t__builder.Task;
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x00045930 File Offset: 0x00043B30
		public static IAscResult SaleReserve(int documentId, IEnumerable<store_items> items, IPinpadResult pp, bool balancePay, string customerEmail)
		{
			Result result = new Result();
			HistoryV2 historyV = new HistoryV2();
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					using (DbContextTransaction dbContextTransaction = auseceEntities.Database.BeginTransaction())
					{
						try
						{
							docs docs = auseceEntities.docs.Find(new object[]
							{
								documentId
							});
							if (docs.total > 0m)
							{
								if (!balancePay)
								{
									CashInOrder cashInOrder = new CashInOrder(docs);
									cashInOrder.SetOffice(OfflineData.Instance.Employee.OfficeId);
									cashInOrder.SetEmployee(OfflineData.Instance.Employee.Id);
									cashInOrder.SetCustomerEmail(customerEmail);
									if (pp != null)
									{
										cashInOrder.SetPinpadData(pp);
									}
									IAscResult ascResult = KassaModel.CreateCashOrder(auseceEntities, cashInOrder, false, false);
									if (!ascResult.IsSucces)
									{
										return ascResult;
									}
									docs.reason = string.Format(Lang.t("PnDocumentReason"), ascResult.Id.ToString("D6"));
									docs.order_id = new int?(ascResult.Id);
								}
								else if (!KassaModel.SubstractCustomerBalance(docs.dealer.Value, docs.total, Kassa.Balance.ItemsSale, new int?(docs.id), 0))
								{
									result.Message = "Substract customer balance fail, aborted";
									return result;
								}
							}
							DateTime serverUtcTime = Localization.GetServerUtcTime(auseceEntities);
							using (IEnumerator<store_items> enumerator = items.GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									store_items item = enumerator.Current;
									store_items store_items = auseceEntities.store_items.FirstOrDefault((store_items i) => i.id == item.id);
									if (store_items != null)
									{
										store_items.reserved -= item.BuyCount;
										historyV.AddItemLog("SaleAndCancellReserve", store_items.id, "", "");
										store_items.count -= item.BuyCount;
										store_items.sold += item.BuyCount;
										store_items.updated = new DateTime?(serverUtcTime);
										if (item.count == 0 && store_items.box != null)
										{
											item.box = null;
											historyV.AddItemLog("LastItemSold", item.id, store_items.box_name, "");
										}
									}
								}
							}
							foreach (store_items store_items2 in items)
							{
								store_sales store_sales = auseceEntities.store_sales.Find(new object[]
								{
									store_items2.SaleId
								});
								store_sales.warranty = store_items2.warranty;
								store_sales.sn = store_items2.SN;
							}
							docs.type = 2;
							docs.state = new int?(5);
							docs.created = DateTime.UtcNow;
							auseceEntities.SaveChanges();
							dbContextTransaction.Commit();
							if (docs.dealer != null)
							{
								ClientsModel.RefreshPurchasesCount(docs.dealer.Value);
							}
							historyV.Save();
							result.SetSuccess();
						}
						catch (Exception ex)
						{
							ItemsSaleModel.Log.Error(ex, ex.Message);
							dbContextTransaction.Rollback();
							result.Message = ex.Message;
							return result;
						}
					}
				}
			}
			catch (Exception ex2)
			{
				ItemsSaleModel.Log.Error(ex2, "Cancell reserve fail");
				result.Message = ex2.Message;
				return result;
			}
			return result;
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x00045DE4 File Offset: 0x00043FE4
		public static IAscResult CreateDocument(IEnumerable<store_items> items, IStoreDocument document, decimal currencyRate, bool RealizatorItems2Balance)
		{
			Result result = new Result();
			IAscResult result2;
			try
			{
				HistoryV2 historyV = new HistoryV2();
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					document.DealerId = document.DealerId;
					document.CurrencyRate = new decimal?(currencyRate);
					docs docs = document.ConvetBack();
					auseceEntities.docs.Add(docs);
					auseceEntities.SaveChanges();
					result.Id = docs.id;
					ItemsSaleModel.SaleItems(items, docs.id, document.DealerId);
					if (RealizatorItems2Balance)
					{
						foreach (store_items item in items)
						{
							new KassaModel().RealizatorItems2Balance(item, historyV);
						}
					}
					historyV.AddDocumentLog("RnCreated", result.Id, "");
					historyV.Save();
					result.SetSuccess();
				}
				return result;
			}
			catch (Exception ex)
			{
				result.Message = ex.Message;
				ILogger log = ItemsSaleModel.Log;
				string str = "Save document error ";
				Exception ex2 = ex;
				log.Error(str + ((ex2 != null) ? ex2.ToString() : null));
				result2 = result;
			}
			return result2;
		}

		// Token: 0x0600190F RID: 6415 RVA: 0x00045F24 File Offset: 0x00044124
		public bool MakeReserve(IEnumerable<store_items> items)
		{
			bool result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					DateTime serverUtcTime = Localization.GetServerUtcTime(auseceEntities);
					foreach (store_items store_items in items)
					{
						store_items store_items2 = auseceEntities.store_items.Find(new object[]
						{
							store_items.id
						});
						if (store_items2 != null)
						{
							store_items2.reserved += store_items.BuyCount;
							store_items2.updated = new DateTime?(serverUtcTime);
						}
					}
					auseceEntities.SaveChanges();
					result = true;
				}
			}
			catch (Exception exception)
			{
				ItemsSaleModel.Log.Error(exception, "Make items reserve fail");
				result = false;
			}
			return result;
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x00046004 File Offset: 0x00044204
		public Task<bool> CancellRn(int documentId, string reason)
		{
			ItemsSaleModel.<CancellRn>d__5 <CancellRn>d__;
			<CancellRn>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<CancellRn>d__.<>4__this = this;
			<CancellRn>d__.documentId = documentId;
			<CancellRn>d__.reason = reason;
			<CancellRn>d__.<>1__state = -1;
			<CancellRn>d__.<>t__builder.Start<ItemsSaleModel.<CancellRn>d__5>(ref <CancellRn>d__);
			return <CancellRn>d__.<>t__builder.Task;
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x00046058 File Offset: 0x00044258
		private void SubstractDealerBalance(List<store_sales> items)
		{
			try
			{
				foreach (store_sales store_sales in items)
				{
					if (store_sales.is_realization)
					{
						decimal summ = (store_sales.in_price == 0m) ? (store_sales.price * store_sales.count / 100m * store_sales.return_percent) : store_sales.in_price;
						KassaModel.SubstractCustomerBalance(store_sales.dealer, summ, Kassa.Balance.CancellRn, new int?(store_sales.document_id), 0);
					}
				}
			}
			catch (Exception exception)
			{
				ItemsSaleModel.Log.Error(exception, "Substract dealer balance on cancel Rn fail");
			}
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x00046130 File Offset: 0x00044330
		public static void SaleItems(IEnumerable<store_items> items, int documentId, int? customerId)
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					foreach (store_items store_items in items)
					{
						auseceEntities.store_sales.Add(new store_sales(true)
						{
							dealer = store_items.dealer,
							customer_id = customerId,
							item_id = store_items.id,
							document_id = documentId,
							count = store_items.BuyCount,
							in_price = store_items.in_price,
							price = store_items.BuyCost,
							warranty = store_items.warranty,
							is_realization = store_items.is_realization,
							return_percent = store_items.return_percent,
							sn = store_items.SN
						});
					}
					auseceEntities.SaveChanges();
					if (customerId != null && customerId.Value > 0)
					{
						ClientsModel.RefreshPurchasesCount(customerId.Value);
					}
				}
			}
			catch (Exception exception)
			{
				ItemsSaleModel.Log.Error(exception, "Sale items fail");
			}
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x0004626C File Offset: 0x0004446C
		public static IAscResult SaveTrack(ISaleDocument document)
		{
			Result result = new Result();
			IAscResult result2;
			try
			{
				HistoryV2 historyV = new HistoryV2();
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					auseceEntities.docs.Find(new object[]
					{
						document.Id
					}).track = document.Track;
					auseceEntities.SaveChanges();
					historyV.AddDocumentLog("TrackChanged", document.Id, document.Track);
				}
				historyV.Save();
				goto IL_95;
			}
			catch (Exception ex)
			{
				ItemsSaleModel.Log.Error(ex, ex.Message);
				result.Message = ex.Message;
				result2 = result;
			}
			return result2;
			IL_95:
			result.SetSuccess();
			return result;
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x00046334 File Offset: 0x00044534
		public ItemsSaleModel()
		{
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x00046348 File Offset: 0x00044548
		// Note: this type is marked as 'beforefieldinit'.
		static ItemsSaleModel()
		{
		}

		// Token: 0x04000CD1 RID: 3281
		private static readonly ILogger Log = LogManager.GetCurrentClassLogger();

		// Token: 0x020001B2 RID: 434
		[CompilerGenerated]
		private sealed class <>c__DisplayClass1_0
		{
			// Token: 0x06001916 RID: 6422 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass1_0()
			{
			}

			// Token: 0x04000CD2 RID: 3282
			public store_items item;
		}

		// Token: 0x020001B3 RID: 435
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CancellReserve>d__1 : IAsyncStateMachine
		{
			// Token: 0x06001917 RID: 6423 RVA: 0x00046360 File Offset: 0x00044560
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				bool result3;
				try
				{
					if (num > 1)
					{
						this.<history>5__2 = new HistoryV2();
					}
					try
					{
						if (num > 1)
						{
							this.<ctx>5__3 = new auseceEntities(true);
						}
						try
						{
							if (num > 1)
							{
								this.<transaction>5__4 = this.<ctx>5__3.Database.BeginTransaction();
							}
							try
							{
								TaskAwaiter<docs> awaiter;
								if (num != 0)
								{
									if (num == 1)
									{
										awaiter = this.<>u__2;
										this.<>u__2 = default(TaskAwaiter<docs>);
										int num2 = -1;
										num = -1;
										this.<>1__state = num2;
										goto IL_27D;
									}
									this.<>7__wrap4 = this.items.GetEnumerator();
								}
								try
								{
									TaskAwaiter<store_items> awaiter2;
									if (num == 0)
									{
										awaiter2 = this.<>u__1;
										this.<>u__1 = default(TaskAwaiter<store_items>);
										int num3 = -1;
										num = -1;
										this.<>1__state = num3;
										goto IL_1C1;
									}
									IL_A5:
									if (!this.<>7__wrap4.MoveNext())
									{
										goto IL_20E;
									}
									this.<>8__1 = new ItemsSaleModel.<>c__DisplayClass1_0();
									this.<>8__1.item = this.<>7__wrap4.Current;
									awaiter2 = this.<ctx>5__3.store_items.FirstOrDefaultAsync((store_items i) => i.id == this.<>8__1.item.id).GetAwaiter();
									if (!awaiter2.IsCompleted)
									{
										int num4 = 0;
										num = 0;
										this.<>1__state = num4;
										this.<>u__1 = awaiter2;
										this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<store_items>, ItemsSaleModel.<CancellReserve>d__1>(ref awaiter2, ref this);
										return;
									}
									IL_1C1:
									store_items result = awaiter2.GetResult();
									if (result != null)
									{
										result.reserved -= this.<>8__1.item.BuyCount;
										if (this.isSale)
										{
											this.<history>5__2.AddItemLog("SaleAndCancellReserve", result.id, "", "");
										}
										this.<>8__1 = null;
										goto IL_A5;
									}
									goto IL_A5;
								}
								finally
								{
									if (num < 0 && this.<>7__wrap4 != null)
									{
										this.<>7__wrap4.Dispose();
									}
								}
								IL_20E:
								this.<>7__wrap4 = null;
								if (this.documentId == null)
								{
									goto IL_2EE;
								}
								awaiter = this.<ctx>5__3.docs.FindAsync(new object[]
								{
									this.documentId
								}).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num5 = 1;
									num = 1;
									this.<>1__state = num5;
									this.<>u__2 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<docs>, ItemsSaleModel.<CancellReserve>d__1>(ref awaiter, ref this);
									return;
								}
								IL_27D:
								docs result2 = awaiter.GetResult();
								result2.type = 6;
								result2.state = new int?(4);
								result2.total = 0m;
								if (result2.dealer != null)
								{
									ClientsModel.RefreshPurchasesCount(result2.dealer.Value);
								}
								this.<history>5__2.AddDocumentLog("CancelledReserve", this.documentId.Value, "");
								IL_2EE:
								this.<ctx>5__3.SaveChanges();
								this.<transaction>5__4.Commit();
								this.<history>5__2.Save();
							}
							catch (Exception ex)
							{
								ItemsSaleModel.Log.Error(ex, ex.Message);
								this.<transaction>5__4.Rollback();
								result3 = false;
								goto IL_3B5;
							}
							finally
							{
								if (num < 0 && this.<transaction>5__4 != null)
								{
									((IDisposable)this.<transaction>5__4).Dispose();
								}
							}
							this.<transaction>5__4 = null;
						}
						finally
						{
							if (num < 0 && this.<ctx>5__3 != null)
							{
								((IDisposable)this.<ctx>5__3).Dispose();
							}
						}
						this.<ctx>5__3 = null;
					}
					catch (Exception exception)
					{
						ItemsSaleModel.Log.Error(exception, "Cancell reserve fail");
						result3 = false;
						goto IL_3B5;
					}
					result3 = true;
				}
				catch (Exception exception2)
				{
					this.<>1__state = -2;
					this.<history>5__2 = null;
					this.<>t__builder.SetException(exception2);
					return;
				}
				IL_3B5:
				this.<>1__state = -2;
				this.<history>5__2 = null;
				this.<>t__builder.SetResult(result3);
			}

			// Token: 0x06001918 RID: 6424 RVA: 0x000467D4 File Offset: 0x000449D4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000CD3 RID: 3283
			public int <>1__state;

			// Token: 0x04000CD4 RID: 3284
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x04000CD5 RID: 3285
			public IEnumerable<store_items> items;

			// Token: 0x04000CD6 RID: 3286
			private ItemsSaleModel.<>c__DisplayClass1_0 <>8__1;

			// Token: 0x04000CD7 RID: 3287
			public bool isSale;

			// Token: 0x04000CD8 RID: 3288
			public int? documentId;

			// Token: 0x04000CD9 RID: 3289
			private HistoryV2 <history>5__2;

			// Token: 0x04000CDA RID: 3290
			private auseceEntities <ctx>5__3;

			// Token: 0x04000CDB RID: 3291
			private DbContextTransaction <transaction>5__4;

			// Token: 0x04000CDC RID: 3292
			private IEnumerator<store_items> <>7__wrap4;

			// Token: 0x04000CDD RID: 3293
			private TaskAwaiter<store_items> <>u__1;

			// Token: 0x04000CDE RID: 3294
			private TaskAwaiter<docs> <>u__2;
		}

		// Token: 0x020001B4 RID: 436
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x06001919 RID: 6425 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x04000CDF RID: 3295
			public store_items item;
		}

		// Token: 0x020001B5 RID: 437
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CancellRn>d__5 : IAsyncStateMachine
		{
			// Token: 0x0600191A RID: 6426 RVA: 0x000467F0 File Offset: 0x000449F0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsSaleModel itemsSaleModel = this.<>4__this;
				bool result2;
				try
				{
					TaskAwaiter<docs> awaiter;
					TaskAwaiter<List<store_sales>> awaiter2;
					TaskAwaiter<cash_orders> awaiter3;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<docs>);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<List<store_sales>>);
						this.<>1__state = -1;
						goto IL_F9;
					case 2:
						awaiter3 = this.<>u__3;
						this.<>u__3 = default(TaskAwaiter<cash_orders>);
						this.<>1__state = -1;
						goto IL_1B7;
					default:
						awaiter = itemsSaleModel.LoadDocument(this.documentId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<docs>, ItemsSaleModel.<CancellRn>d__5>(ref awaiter, ref this);
							return;
						}
						break;
					}
					docs result = awaiter.GetResult();
					this.<document>5__2 = result;
					if (this.<document>5__2 == null)
					{
						result2 = false;
						goto IL_265;
					}
					awaiter2 = DocumentsModel.LoadSales(this.documentId).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_sales>>, ItemsSaleModel.<CancellRn>d__5>(ref awaiter2, ref this);
						return;
					}
					IL_F9:
					List<store_sales> result3 = awaiter2.GetResult();
					if (result3.Any<store_sales>())
					{
						itemsSaleModel.RestoreItemsCount(result3);
						itemsSaleModel.SubstractDealerBalance(result3);
					}
					itemsSaleModel.SetDocumentState(this.<document>5__2.id, 7);
					this.<kassa>5__3 = new KassaModel();
					if (this.<document>5__2.order_id == null)
					{
						goto IL_1EA;
					}
					awaiter3 = KassaModel.GetOrder(this.<document>5__2.order_id.Value).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__3 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<cash_orders>, ItemsSaleModel.<CancellRn>d__5>(ref awaiter3, ref this);
						return;
					}
					IL_1B7:
					if (awaiter3.GetResult() != null)
					{
						this.<kassa>5__3.NewCashOrder(this.<document>5__2, 9, this.<document>5__2.dealer, true);
						this.<kassa>5__3.MakeRko();
					}
					IL_1EA:
					if (this.<document>5__2.dealer != null)
					{
						ClientsModel.RefreshPurchasesCount(this.<document>5__2.dealer.Value);
					}
					HistoryV2 historyV = new HistoryV2();
					historyV.AddDocumentLog("CancellRn", this.documentId, this.reason);
					historyV.Save();
					result2 = true;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<document>5__2 = null;
					this.<kassa>5__3 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_265:
				this.<>1__state = -2;
				this.<document>5__2 = null;
				this.<kassa>5__3 = null;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x0600191B RID: 6427 RVA: 0x00046AA0 File Offset: 0x00044CA0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000CE0 RID: 3296
			public int <>1__state;

			// Token: 0x04000CE1 RID: 3297
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x04000CE2 RID: 3298
			public ItemsSaleModel <>4__this;

			// Token: 0x04000CE3 RID: 3299
			public int documentId;

			// Token: 0x04000CE4 RID: 3300
			public string reason;

			// Token: 0x04000CE5 RID: 3301
			private docs <document>5__2;

			// Token: 0x04000CE6 RID: 3302
			private KassaModel <kassa>5__3;

			// Token: 0x04000CE7 RID: 3303
			private TaskAwaiter<docs> <>u__1;

			// Token: 0x04000CE8 RID: 3304
			private TaskAwaiter<List<store_sales>> <>u__2;

			// Token: 0x04000CE9 RID: 3305
			private TaskAwaiter<cash_orders> <>u__3;
		}
	}
}
