using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ASC.Models;
using ASC.Objects.Converters;
using ASC.Objects.Reports;
using ASC.Services.Abstract;
using Autofac;
using DevExpress.XtraReports.UI;

namespace ASC.Services.Concrete
{
	// Token: 0x020006E6 RID: 1766
	public class BuyoutService : IBuyoutService
	{
		// Token: 0x0600399E RID: 14750 RVA: 0x000D7998 File Offset: 0x000D5B98
		public Task<buyout> GetByIdAsync(int buyoutId)
		{
			BuyoutService.<GetByIdAsync>d__0 <GetByIdAsync>d__;
			<GetByIdAsync>d__.<>t__builder = AsyncTaskMethodBuilder<buyout>.Create();
			<GetByIdAsync>d__.buyoutId = buyoutId;
			<GetByIdAsync>d__.<>1__state = -1;
			<GetByIdAsync>d__.<>t__builder.Start<BuyoutService.<GetByIdAsync>d__0>(ref <GetByIdAsync>d__);
			return <GetByIdAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600399F RID: 14751 RVA: 0x000D79DC File Offset: 0x000D5BDC
		public Task<buyout> GetByDocumentIdAsync(int documentId)
		{
			BuyoutService.<GetByDocumentIdAsync>d__1 <GetByDocumentIdAsync>d__;
			<GetByDocumentIdAsync>d__.<>t__builder = AsyncTaskMethodBuilder<buyout>.Create();
			<GetByDocumentIdAsync>d__.documentId = documentId;
			<GetByDocumentIdAsync>d__.<>1__state = -1;
			<GetByDocumentIdAsync>d__.<>t__builder.Start<BuyoutService.<GetByDocumentIdAsync>d__1>(ref <GetByDocumentIdAsync>d__);
			return <GetByDocumentIdAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060039A0 RID: 14752 RVA: 0x000D7A20 File Offset: 0x000D5C20
		public Task<int> MakeBuyout(docs document, store_items product, clients customer, buyout customerDocument)
		{
			BuyoutService.<MakeBuyout>d__2 <MakeBuyout>d__;
			<MakeBuyout>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<MakeBuyout>d__.<>4__this = this;
			<MakeBuyout>d__.document = document;
			<MakeBuyout>d__.product = product;
			<MakeBuyout>d__.customer = customer;
			<MakeBuyout>d__.customerDocument = customerDocument;
			<MakeBuyout>d__.<>1__state = -1;
			<MakeBuyout>d__.<>t__builder.Start<BuyoutService.<MakeBuyout>d__2>(ref <MakeBuyout>d__);
			return <MakeBuyout>d__.<>t__builder.Task;
		}

		// Token: 0x060039A1 RID: 14753 RVA: 0x000D7A84 File Offset: 0x000D5C84
		public string ConstructName(string type, string maker, string model)
		{
			return string.Concat(new string[]
			{
				type,
				" ",
				maker,
				" ",
				model
			});
		}

		// Token: 0x060039A2 RID: 14754 RVA: 0x000D7AB8 File Offset: 0x000D5CB8
		private Task CreateItem(docs document, store_items product)
		{
			BuyoutService.<CreateItem>d__4 <CreateItem>d__;
			<CreateItem>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<CreateItem>d__.document = document;
			<CreateItem>d__.product = product;
			<CreateItem>d__.<>1__state = -1;
			<CreateItem>d__.<>t__builder.Start<BuyoutService.<CreateItem>d__4>(ref <CreateItem>d__);
			return <CreateItem>d__.<>t__builder.Task;
		}

		// Token: 0x060039A3 RID: 14755 RVA: 0x000D7B04 File Offset: 0x000D5D04
		private Task CreateRko(auseceEntities ctx, docs document)
		{
			BuyoutService.<CreateRko>d__5 <CreateRko>d__;
			<CreateRko>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<CreateRko>d__.ctx = ctx;
			<CreateRko>d__.document = document;
			<CreateRko>d__.<>1__state = -1;
			<CreateRko>d__.<>t__builder.Start<BuyoutService.<CreateRko>d__5>(ref <CreateRko>d__);
			return <CreateRko>d__.<>t__builder.Task;
		}

		// Token: 0x060039A4 RID: 14756 RVA: 0x000D7B50 File Offset: 0x000D5D50
		private Task<int> CreateDocument(auseceEntities ctx, docs document, clients client)
		{
			BuyoutService.<CreateDocument>d__6 <CreateDocument>d__;
			<CreateDocument>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<CreateDocument>d__.ctx = ctx;
			<CreateDocument>d__.document = document;
			<CreateDocument>d__.client = client;
			<CreateDocument>d__.<>1__state = -1;
			<CreateDocument>d__.<>t__builder.Start<BuyoutService.<CreateDocument>d__6>(ref <CreateDocument>d__);
			return <CreateDocument>d__.<>t__builder.Task;
		}

		// Token: 0x060039A5 RID: 14757 RVA: 0x000D7BA4 File Offset: 0x000D5DA4
		public Task<docs> GetBuyoutDocumentAsync(int documentId)
		{
			BuyoutService.<GetBuyoutDocumentAsync>d__7 <GetBuyoutDocumentAsync>d__;
			<GetBuyoutDocumentAsync>d__.<>t__builder = AsyncTaskMethodBuilder<docs>.Create();
			<GetBuyoutDocumentAsync>d__.documentId = documentId;
			<GetBuyoutDocumentAsync>d__.<>1__state = -1;
			<GetBuyoutDocumentAsync>d__.<>t__builder.Start<BuyoutService.<GetBuyoutDocumentAsync>d__7>(ref <GetBuyoutDocumentAsync>d__);
			return <GetBuyoutDocumentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060039A6 RID: 14758 RVA: 0x000D7BE8 File Offset: 0x000D5DE8
		public Task<XtraReport> CreateReport(int documentId)
		{
			BuyoutService.<CreateReport>d__8 <CreateReport>d__;
			<CreateReport>d__.<>t__builder = AsyncTaskMethodBuilder<XtraReport>.Create();
			<CreateReport>d__.<>4__this = this;
			<CreateReport>d__.documentId = documentId;
			<CreateReport>d__.<>1__state = -1;
			<CreateReport>d__.<>t__builder.Start<BuyoutService.<CreateReport>d__8>(ref <CreateReport>d__);
			return <CreateReport>d__.<>t__builder.Task;
		}

		// Token: 0x060039A7 RID: 14759 RVA: 0x000046B4 File Offset: 0x000028B4
		public BuyoutService()
		{
		}

		// Token: 0x020006E7 RID: 1767
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetByIdAsync>d__0 : IAsyncStateMachine
		{
			// Token: 0x060039A8 RID: 14760 RVA: 0x000D7C34 File Offset: 0x000D5E34
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				buyout result;
				try
				{
					if (num != 0)
					{
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						ConfiguredTaskAwaitable<buyout>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = this.<ctx>5__2.buyout.FindAsync(new object[]
							{
								this.buyoutId
							}).ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<buyout>.ConfiguredTaskAwaiter, BuyoutService.<GetByIdAsync>d__0>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<buyout>.ConfiguredTaskAwaiter);
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

			// Token: 0x060039A9 RID: 14761 RVA: 0x000D7D40 File Offset: 0x000D5F40
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400240A RID: 9226
			public int <>1__state;

			// Token: 0x0400240B RID: 9227
			public AsyncTaskMethodBuilder<buyout> <>t__builder;

			// Token: 0x0400240C RID: 9228
			public int buyoutId;

			// Token: 0x0400240D RID: 9229
			private auseceEntities <ctx>5__2;

			// Token: 0x0400240E RID: 9230
			private ConfiguredTaskAwaitable<buyout>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x020006E8 RID: 1768
		[CompilerGenerated]
		private sealed class <>c__DisplayClass1_0
		{
			// Token: 0x060039AA RID: 14762 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass1_0()
			{
			}

			// Token: 0x0400240F RID: 9231
			public int documentId;
		}

		// Token: 0x020006E9 RID: 1769
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetByDocumentIdAsync>d__1 : IAsyncStateMachine
		{
			// Token: 0x060039AB RID: 14763 RVA: 0x000D7D5C File Offset: 0x000D5F5C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				buyout result;
				try
				{
					BuyoutService.<>c__DisplayClass1_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new BuyoutService.<>c__DisplayClass1_0();
						CS$<>8__locals1.documentId = this.documentId;
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						ConfiguredTaskAwaitable<buyout>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = (from i in this.<ctx>5__2.buyout
							where i.document_id == CS$<>8__locals1.documentId
							select i).FirstOrDefaultAsync<buyout>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<buyout>.ConfiguredTaskAwaiter, BuyoutService.<GetByDocumentIdAsync>d__1>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<buyout>.ConfiguredTaskAwaiter);
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

			// Token: 0x060039AC RID: 14764 RVA: 0x000D7EE8 File Offset: 0x000D60E8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002410 RID: 9232
			public int <>1__state;

			// Token: 0x04002411 RID: 9233
			public AsyncTaskMethodBuilder<buyout> <>t__builder;

			// Token: 0x04002412 RID: 9234
			public int documentId;

			// Token: 0x04002413 RID: 9235
			private auseceEntities <ctx>5__2;

			// Token: 0x04002414 RID: 9236
			private ConfiguredTaskAwaitable<buyout>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x020006EA RID: 1770
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <MakeBuyout>d__2 : IAsyncStateMachine
		{
			// Token: 0x060039AD RID: 14765 RVA: 0x000D7F04 File Offset: 0x000D6104
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				BuyoutService buyoutService = this.<>4__this;
				int result2;
				try
				{
					if (num > 3)
					{
						if (this.customer.id == 0)
						{
							ClientsModel clientsModel = new ClientsModel();
							this.customer = clientsModel.SilentCreateNewClient(this.customer);
						}
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<int> awaiter;
						ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter awaiter2;
						TaskAwaiter awaiter3;
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
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
							goto IL_18E;
						}
						case 2:
						{
							awaiter3 = this.<>u__3;
							this.<>u__3 = default(TaskAwaiter);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
							goto IL_1F9;
						}
						case 3:
						{
							awaiter3 = this.<>u__3;
							this.<>u__3 = default(TaskAwaiter);
							int num5 = -1;
							num = -1;
							this.<>1__state = num5;
							goto IL_260;
						}
						default:
							awaiter = buyoutService.CreateDocument(this.<ctx>5__2, this.document, this.customer).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num6 = 0;
								num = 0;
								this.<>1__state = num6;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, BuyoutService.<MakeBuyout>d__2>(ref awaiter, ref this);
								return;
							}
							break;
						}
						int result = awaiter.GetResult();
						this.<documentId>5__3 = result;
						this.customerDocument.document_id = this.<documentId>5__3;
						this.customerDocument.created_at = Localization.GetServerUtcTime(this.<ctx>5__2);
						this.customerDocument.customer_id = this.customer.id;
						this.<ctx>5__2.buyout.Add(this.customerDocument);
						awaiter2 = this.<ctx>5__2.SaveChangesAsync().ConfigureAwait(false).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num7 = 1;
							num = 1;
							this.<>1__state = num7;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter, BuyoutService.<MakeBuyout>d__2>(ref awaiter2, ref this);
							return;
						}
						IL_18E:
						awaiter2.GetResult();
						awaiter3 = buyoutService.CreateRko(this.<ctx>5__2, this.document).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							int num8 = 2;
							num = 2;
							this.<>1__state = num8;
							this.<>u__3 = awaiter3;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, BuyoutService.<MakeBuyout>d__2>(ref awaiter3, ref this);
							return;
						}
						IL_1F9:
						awaiter3.GetResult();
						awaiter3 = buyoutService.CreateItem(this.document, this.product).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							int num9 = 3;
							num = 3;
							this.<>1__state = num9;
							this.<>u__3 = awaiter3;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, BuyoutService.<MakeBuyout>d__2>(ref awaiter3, ref this);
							return;
						}
						IL_260:
						awaiter3.GetResult();
						result2 = this.<documentId>5__3;
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

			// Token: 0x060039AE RID: 14766 RVA: 0x000D81FC File Offset: 0x000D63FC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002415 RID: 9237
			public int <>1__state;

			// Token: 0x04002416 RID: 9238
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x04002417 RID: 9239
			public clients customer;

			// Token: 0x04002418 RID: 9240
			public BuyoutService <>4__this;

			// Token: 0x04002419 RID: 9241
			public docs document;

			// Token: 0x0400241A RID: 9242
			public buyout customerDocument;

			// Token: 0x0400241B RID: 9243
			public store_items product;

			// Token: 0x0400241C RID: 9244
			private auseceEntities <ctx>5__2;

			// Token: 0x0400241D RID: 9245
			private int <documentId>5__3;

			// Token: 0x0400241E RID: 9246
			private TaskAwaiter<int> <>u__1;

			// Token: 0x0400241F RID: 9247
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__2;

			// Token: 0x04002420 RID: 9248
			private TaskAwaiter <>u__3;
		}

		// Token: 0x020006EB RID: 1771
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060039AF RID: 14767 RVA: 0x000D8218 File Offset: 0x000D6418
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060039B0 RID: 14768 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x04002421 RID: 9249
			public static readonly BuyoutService.<>c <>9 = new BuyoutService.<>c();
		}

		// Token: 0x020006EC RID: 1772
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateItem>d__4 : IAsyncStateMachine
		{
			// Token: 0x060039B1 RID: 14769 RVA: 0x000D8230 File Offset: 0x000D6430
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					if (num > 4)
					{
						this.<history>5__2 = new HistoryV2();
						this.<ctx>5__3 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<int> awaiter;
						ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter awaiter2;
						ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter3;
						TaskAwaiter awaiter4;
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
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
							goto IL_20F;
						}
						case 2:
						{
							awaiter3 = this.<>u__3;
							this.<>u__3 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
							goto IL_2C9;
						}
						case 3:
						{
							awaiter3 = this.<>u__3;
							this.<>u__3 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
							int num5 = -1;
							num = -1;
							this.<>1__state = num5;
							goto IL_3D1;
						}
						case 4:
						{
							awaiter4 = this.<>u__4;
							this.<>u__4 = default(TaskAwaiter);
							int num6 = -1;
							num = -1;
							this.<>1__state = num6;
							goto IL_46B;
						}
						default:
							if (this.document.dealer != null)
							{
								this.product.dealer = this.document.dealer.Value;
							}
							this.product.store = this.document.store.Value;
							this.product.count = 1;
							this.product.in_count = 1;
							this.product.in_price = this.document.total;
							this.product.in_summ = this.document.total;
							this.product.currency_rate = Auth.CurrencyModel.Rate;
							this.<>7__wrap3 = this.product;
							awaiter = Bootstrapper.Container.Resolve<IProductService>().GetOrCreateArticul(this.<ctx>5__3, this.product).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num7 = 0;
								num = 0;
								this.<>1__state = num7;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, BuyoutService.<CreateItem>d__4>(ref awaiter, ref this);
								return;
							}
							break;
						}
						int result = awaiter.GetResult();
						this.<>7__wrap3.articul = result;
						this.<>7__wrap3 = null;
						this.product.document = new int?(this.document.id);
						this.<ctx>5__3.store_items.Add(this.product);
						awaiter2 = this.<ctx>5__3.SaveChangesAsync().ConfigureAwait(false).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num8 = 1;
							num = 1;
							this.<>1__state = num8;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter, BuyoutService.<CreateItem>d__4>(ref awaiter2, ref this);
							return;
						}
						IL_20F:
						awaiter2.GetResult();
						awaiter3 = this.<ctx>5__3.Entry<store_items>(this.product).Reference<stores>((store_items i) => i.stores).LoadAsync().ConfigureAwait(false).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							int num9 = 2;
							num = 2;
							this.<>1__state = num9;
							this.<>u__3 = awaiter3;
							this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, BuyoutService.<CreateItem>d__4>(ref awaiter3, ref this);
							return;
						}
						IL_2C9:
						awaiter3.GetResult();
						HistoryV2 historyV = this.<history>5__2;
						string action = "changeStore";
						int id = this.product.id;
						stores stores = this.product.stores;
						historyV.AddItemLog(action, id, (stores != null) ? stores.name : null, "");
						if (this.product.box == null)
						{
							goto IL_40F;
						}
						awaiter3 = this.<ctx>5__3.Entry<store_items>(this.product).Reference<boxes>((store_items i) => i.boxes).LoadAsync().ConfigureAwait(false).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							int num10 = 3;
							num = 3;
							this.<>1__state = num10;
							this.<>u__3 = awaiter3;
							this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, BuyoutService.<CreateItem>d__4>(ref awaiter3, ref this);
							return;
						}
						IL_3D1:
						awaiter3.GetResult();
						HistoryV2 historyV2 = this.<history>5__2;
						string action2 = "setBox";
						int id2 = this.product.id;
						boxes boxes = this.product.boxes;
						historyV2.AddItemLog(action2, id2, (boxes != null) ? boxes.name : null, "");
						IL_40F:
						awaiter4 = this.<history>5__2.SaveAsync().GetAwaiter();
						if (!awaiter4.IsCompleted)
						{
							int num11 = 4;
							num = 4;
							this.<>1__state = num11;
							this.<>u__4 = awaiter4;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, BuyoutService.<CreateItem>d__4>(ref awaiter4, ref this);
							return;
						}
						IL_46B:
						awaiter4.GetResult();
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
					this.<>1__state = -2;
					this.<history>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<history>5__2 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060039B2 RID: 14770 RVA: 0x000D8740 File Offset: 0x000D6940
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002422 RID: 9250
			public int <>1__state;

			// Token: 0x04002423 RID: 9251
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002424 RID: 9252
			public docs document;

			// Token: 0x04002425 RID: 9253
			public store_items product;

			// Token: 0x04002426 RID: 9254
			private HistoryV2 <history>5__2;

			// Token: 0x04002427 RID: 9255
			private auseceEntities <ctx>5__3;

			// Token: 0x04002428 RID: 9256
			private store_items <>7__wrap3;

			// Token: 0x04002429 RID: 9257
			private TaskAwaiter<int> <>u__1;

			// Token: 0x0400242A RID: 9258
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__2;

			// Token: 0x0400242B RID: 9259
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__3;

			// Token: 0x0400242C RID: 9260
			private TaskAwaiter <>u__4;
		}

		// Token: 0x020006ED RID: 1773
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateRko>d__5 : IAsyncStateMachine
		{
			// Token: 0x060039B3 RID: 14771 RVA: 0x000D875C File Offset: 0x000D695C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter awaiter;
					ConfiguredTaskAwaitable<docs>.ConfiguredTaskAwaiter awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter);
							this.<>1__state = -1;
							goto IL_147;
						}
						this.<kassa>5__2 = new KassaModel();
						this.<kassa>5__2.NewCashOrder(this.document, 2, null, true);
						this.<kassa>5__2.MakeRko();
						awaiter2 = this.ctx.docs.FindAsync(new object[]
						{
							this.document.id
						}).ConfigureAwait(false).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<docs>.ConfiguredTaskAwaiter, BuyoutService.<CreateRko>d__5>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(ConfiguredTaskAwaitable<docs>.ConfiguredTaskAwaiter);
						this.<>1__state = -1;
					}
					awaiter2.GetResult().order_id = new int?(this.<kassa>5__2.GetOrderId());
					awaiter = this.ctx.SaveChangesAsync().ConfigureAwait(false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter, BuyoutService.<CreateRko>d__5>(ref awaiter, ref this);
						return;
					}
					IL_147:
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<kassa>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<kassa>5__2 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060039B4 RID: 14772 RVA: 0x000D8910 File Offset: 0x000D6B10
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400242D RID: 9261
			public int <>1__state;

			// Token: 0x0400242E RID: 9262
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400242F RID: 9263
			public docs document;

			// Token: 0x04002430 RID: 9264
			public auseceEntities ctx;

			// Token: 0x04002431 RID: 9265
			private KassaModel <kassa>5__2;

			// Token: 0x04002432 RID: 9266
			private ConfiguredTaskAwaitable<docs>.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x04002433 RID: 9267
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__2;
		}

		// Token: 0x020006EE RID: 1774
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateDocument>d__6 : IAsyncStateMachine
		{
			// Token: 0x060039B5 RID: 14773 RVA: 0x000D892C File Offset: 0x000D6B2C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				int id;
				try
				{
					ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						this.document.currency_rate = new decimal?(Auth.CurrencyModel.Rate);
						this.document.type = 8;
						this.document.reason = (string)Application.Current.TryFindResource("RedemptionOfEquipment");
						this.document.company = Auth.User.offices1.default_company;
						this.document.dealer = new int?(this.client.id);
						this.document.state = new int?(1);
						this.ctx.docs.Add(this.document);
						awaiter = this.ctx.SaveChangesAsync().ConfigureAwait(false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter, BuyoutService.<CreateDocument>d__6>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter);
						this.<>1__state = -1;
					}
					awaiter.GetResult();
					id = this.document.id;
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

			// Token: 0x060039B6 RID: 14774 RVA: 0x000D8AA8 File Offset: 0x000D6CA8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002434 RID: 9268
			public int <>1__state;

			// Token: 0x04002435 RID: 9269
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x04002436 RID: 9270
			public docs document;

			// Token: 0x04002437 RID: 9271
			public clients client;

			// Token: 0x04002438 RID: 9272
			public auseceEntities ctx;

			// Token: 0x04002439 RID: 9273
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x020006EF RID: 1775
		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x060039B7 RID: 14775 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x0400243A RID: 9274
			public int documentId;
		}

		// Token: 0x020006F0 RID: 1776
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetBuyoutDocumentAsync>d__7 : IAsyncStateMachine
		{
			// Token: 0x060039B8 RID: 14776 RVA: 0x000D8AC4 File Offset: 0x000D6CC4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				docs result;
				try
				{
					BuyoutService.<>c__DisplayClass7_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new BuyoutService.<>c__DisplayClass7_0();
						CS$<>8__locals1.documentId = this.documentId;
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						ConfiguredTaskAwaitable<docs>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = (from i in this.<ctx>5__2.docs.AsNoTracking().Include((docs i) => i.store_items).Include((docs i) => i.store_sales).Include((docs i) => i.stores)
							where i.id == CS$<>8__locals1.documentId
							select i).FirstOrDefaultAsync<docs>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<docs>.ConfiguredTaskAwaiter, BuyoutService.<GetBuyoutDocumentAsync>d__7>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<docs>.ConfiguredTaskAwaiter);
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

			// Token: 0x060039B9 RID: 14777 RVA: 0x000D8D18 File Offset: 0x000D6F18
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400243B RID: 9275
			public int <>1__state;

			// Token: 0x0400243C RID: 9276
			public AsyncTaskMethodBuilder<docs> <>t__builder;

			// Token: 0x0400243D RID: 9277
			public int documentId;

			// Token: 0x0400243E RID: 9278
			private auseceEntities <ctx>5__2;

			// Token: 0x0400243F RID: 9279
			private ConfiguredTaskAwaitable<docs>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x020006F1 RID: 1777
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateReport>d__8 : IAsyncStateMachine
		{
			// Token: 0x060039BA RID: 14778 RVA: 0x000D8D34 File Offset: 0x000D6F34
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				BuyoutService buyoutService = this.<>4__this;
				XtraReport result3;
				try
				{
					TaskAwaiter<doc_templates> awaiter;
					TaskAwaiter<docs> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<doc_templates>);
							this.<>1__state = -1;
							goto IL_E6;
						}
						this.<reportTemplateService>5__2 = Bootstrapper.Container.Resolve<IReportTemplateService>();
						this.<report>5__3 = new XtraReport();
						awaiter2 = buyoutService.GetBuyoutDocumentAsync(this.documentId).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<docs>, BuyoutService.<CreateReport>d__8>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<docs>);
						this.<>1__state = -1;
					}
					docs result = awaiter2.GetResult();
					this.<d>5__4 = result;
					awaiter = this.<reportTemplateService>5__2.GetByNameAsync("buyout").GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<doc_templates>, BuyoutService.<CreateReport>d__8>(ref awaiter, ref this);
						return;
					}
					IL_E6:
					doc_templates result2 = awaiter.GetResult();
					string @string = Encoding.UTF8.GetString(result2.data);
					this.<report>5__3.Tag = result2.id;
					this.<report>5__3.LoadLayout(ReportPrintModel.GenerateStreamFromString(@string));
					BuyoutReport item = new BuyoutReport(this.<d>5__4.ToStoreDocument());
					this.<report>5__3.DataSource = new List<BuyoutReport>
					{
						item
					};
					this.<report>5__3.CreateDocument();
					result3 = this.<report>5__3;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<reportTemplateService>5__2 = null;
					this.<report>5__3 = null;
					this.<d>5__4 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<reportTemplateService>5__2 = null;
				this.<report>5__3 = null;
				this.<d>5__4 = null;
				this.<>t__builder.SetResult(result3);
			}

			// Token: 0x060039BB RID: 14779 RVA: 0x000D8F3C File Offset: 0x000D713C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002440 RID: 9280
			public int <>1__state;

			// Token: 0x04002441 RID: 9281
			public AsyncTaskMethodBuilder<XtraReport> <>t__builder;

			// Token: 0x04002442 RID: 9282
			public BuyoutService <>4__this;

			// Token: 0x04002443 RID: 9283
			public int documentId;

			// Token: 0x04002444 RID: 9284
			private IReportTemplateService <reportTemplateService>5__2;

			// Token: 0x04002445 RID: 9285
			private XtraReport <report>5__3;

			// Token: 0x04002446 RID: 9286
			private docs <d>5__4;

			// Token: 0x04002447 RID: 9287
			private TaskAwaiter<docs> <>u__1;

			// Token: 0x04002448 RID: 9288
			private TaskAwaiter<doc_templates> <>u__2;
		}
	}
}
