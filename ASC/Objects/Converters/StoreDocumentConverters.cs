using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Objects.Reports;
using ASC.Services.Abstract;
using Autofac;
using Poly;

namespace ASC.Objects.Converters
{
	// Token: 0x0200091A RID: 2330
	public static class StoreDocumentConverters
	{
		// Token: 0x06004810 RID: 18448 RVA: 0x00119294 File Offset: 0x00117494
		public static StoreDocument ToStoreDocument(this docs d)
		{
			StoreDocument storeDocument = new StoreDocument
			{
				Id = d.id,
				Type = (DocType)d.type,
				Status = (DocStates)d.state.Value,
				PaymentSystem = d.payment_system,
				StoreId = d.store,
				EmployeeId = d.user,
				CompanyId = d.company,
				OfficeId = d.office,
				DealerId = d.dealer,
				PriceOption = d.price_option,
				ReturnPercent = d.return_percent,
				ReserveDays = d.reserve_days,
				CurrencyRate = d.currency_rate,
				Date = d.created,
				Reason = d.reason,
				Notes = d.notes,
				Track = d.track,
				CashOrderId = d.order_id,
				InvoiceId = d.invoice,
				WorksIncluded = d.works_included
			};
			storeDocument.SetTotal(d.total);
			if (d.store_items != null)
			{
				foreach (store_items i in d.store_items)
				{
					storeDocument.AddItem(i.ToSaleItem());
				}
			}
			if (d.store_sales != null)
			{
				foreach (store_sales i2 in d.store_sales)
				{
					storeDocument.AddItem(i2.ToSaleItem());
				}
			}
			if (d.users != null)
			{
				storeDocument.Employee = d.users.User2Employee();
			}
			return storeDocument;
		}

		// Token: 0x06004811 RID: 18449 RVA: 0x00119464 File Offset: 0x00117664
		public static Task<SaleDocument> ToSaleDocument(this docs d)
		{
			StoreDocumentConverters.<ToSaleDocument>d__1 <ToSaleDocument>d__;
			<ToSaleDocument>d__.<>t__builder = AsyncTaskMethodBuilder<SaleDocument>.Create();
			<ToSaleDocument>d__.d = d;
			<ToSaleDocument>d__.<>1__state = -1;
			<ToSaleDocument>d__.<>t__builder.Start<StoreDocumentConverters.<ToSaleDocument>d__1>(ref <ToSaleDocument>d__);
			return <ToSaleDocument>d__.<>t__builder.Task;
		}

		// Token: 0x06004812 RID: 18450 RVA: 0x001194A8 File Offset: 0x001176A8
		public static GoodsMoveDocument ToProductsMoveDocument(this docs d)
		{
			GoodsMoveDocument goodsMoveDocument = new GoodsMoveDocument(d.ToStoreDocument())
			{
				ToStoreId = d.d_store,
				DestinationPay = d.d_pay
			};
			int? toStoreId = goodsMoveDocument.ToStoreId;
			if (toStoreId.GetValueOrDefault() > 0 & toStoreId != null)
			{
				goodsMoveDocument.LoadToStore();
			}
			if (d.store_sales != null)
			{
				foreach (store_sales store_sales in d.store_sales)
				{
					store_items store_items = store_sales.SaleToStoreItem(d.id);
					store_items.category = store_sales.d_category.Value;
					goodsMoveDocument.AddItem(store_items);
				}
			}
			goodsMoveDocument.SetTotal(d.total);
			return goodsMoveDocument;
		}

		// Token: 0x06004813 RID: 18451 RVA: 0x00119578 File Offset: 0x00117778
		public static docs ConvetBack(this IStoreDocument d)
		{
			return new docs
			{
				id = d.Id,
				type = (int)d.Type,
				state = new int?((int)d.Status),
				payment_system = d.PaymentSystem,
				store = d.StoreId,
				user = d.EmployeeId,
				company = d.CompanyId,
				office = d.OfficeId,
				dealer = d.DealerId,
				price_option = d.PriceOption,
				return_percent = d.ReturnPercent,
				reserve_days = d.ReserveDays,
				currency_rate = d.CurrencyRate,
				total = d.Total,
				created = d.Date,
				reason = d.Reason,
				notes = d.Notes,
				track = d.Track,
				order_id = d.CashOrderId,
				invoice = d.InvoiceId,
				works_included = d.WorksIncluded
			};
		}

		// Token: 0x06004814 RID: 18452 RVA: 0x0011968C File Offset: 0x0011788C
		public static docs ConvetBack(this IGoodsMoveDocument d)
		{
			docs docs = d.ConvetBack();
			docs.d_store = d.ToStoreId;
			docs.d_pay = d.DestinationPay;
			return docs;
		}

		// Token: 0x0200091B RID: 2331
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ToSaleDocument>d__1 : IAsyncStateMachine
		{
			// Token: 0x06004815 RID: 18453 RVA: 0x001196B8 File Offset: 0x001178B8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				SaleDocument result2;
				try
				{
					TaskAwaiter<Invoice> awaiter;
					if (num != 0)
					{
						this.<result>5__2 = new SaleDocument();
						this.d.ToStoreDocument().CopyProperties(this.<result>5__2);
						this.<result>5__2.SetTotal(this.d.total);
						this.<result>5__2.AnonCustomer = (this.d.dealer == null);
						if (this.d.invoice == null)
						{
							goto IL_117;
						}
						IInvoiceService invoiceService = Bootstrapper.Container.Resolve<IInvoiceService>();
						this.<>7__wrap2 = this.<result>5__2;
						awaiter = invoiceService.GetInvoice(this.d.invoice.Value).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Invoice>, StoreDocumentConverters.<ToSaleDocument>d__1>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<Invoice>);
						this.<>1__state = -1;
					}
					Invoice result = awaiter.GetResult();
					this.<>7__wrap2.Invoice = result;
					this.<>7__wrap2 = null;
					IL_117:
					if (this.d.cash_orders1 != null)
					{
						this.<result>5__2.CashOrder = this.d.cash_orders1.ToCashInOrder();
					}
					if (this.d.clients != null)
					{
						this.<result>5__2.Customer = this.d.clients.Client2CustomerCard();
					}
					result2 = this.<result>5__2;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<result>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<result>5__2 = null;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06004816 RID: 18454 RVA: 0x0011988C File Offset: 0x00117A8C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002E09 RID: 11785
			public int <>1__state;

			// Token: 0x04002E0A RID: 11786
			public AsyncTaskMethodBuilder<SaleDocument> <>t__builder;

			// Token: 0x04002E0B RID: 11787
			public docs d;

			// Token: 0x04002E0C RID: 11788
			private SaleDocument <result>5__2;

			// Token: 0x04002E0D RID: 11789
			private SaleDocument <>7__wrap2;

			// Token: 0x04002E0E RID: 11790
			private TaskAwaiter<Invoice> <>u__1;
		}
	}
}
