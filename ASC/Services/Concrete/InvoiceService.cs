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
using ASC.Common.Objects;
using ASC.DAL;
using ASC.Objects;
using ASC.Objects.Converters;
using ASC.Services.Abstract;

namespace ASC.Services.Concrete
{
	// Token: 0x02000722 RID: 1826
	public class InvoiceService : IInvoiceService
	{
		// Token: 0x06003A40 RID: 14912 RVA: 0x000DDEFC File Offset: 0x000DC0FC
		public InvoiceService(IContextFactory contextFactory)
		{
			this._contextFactory = contextFactory;
		}

		// Token: 0x06003A41 RID: 14913 RVA: 0x000DDF18 File Offset: 0x000DC118
		public Task<IEnumerable<IInvoice>> GetInvoices(IPeriod period, int officeId, int state, string filter)
		{
			InvoiceService.<GetInvoices>d__2 <GetInvoices>d__;
			<GetInvoices>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<IInvoice>>.Create();
			<GetInvoices>d__.period = period;
			<GetInvoices>d__.officeId = officeId;
			<GetInvoices>d__.state = state;
			<GetInvoices>d__.filter = filter;
			<GetInvoices>d__.<>1__state = -1;
			<GetInvoices>d__.<>t__builder.Start<InvoiceService.<GetInvoices>d__2>(ref <GetInvoices>d__);
			return <GetInvoices>d__.<>t__builder.Task;
		}

		// Token: 0x06003A42 RID: 14914 RVA: 0x000DDF74 File Offset: 0x000DC174
		public Task<Invoice> GetInvoice(int invoiceId)
		{
			InvoiceService.<GetInvoice>d__3 <GetInvoice>d__;
			<GetInvoice>d__.<>t__builder = AsyncTaskMethodBuilder<Invoice>.Create();
			<GetInvoice>d__.invoiceId = invoiceId;
			<GetInvoice>d__.<>1__state = -1;
			<GetInvoice>d__.<>t__builder.Start<InvoiceService.<GetInvoice>d__3>(ref <GetInvoice>d__);
			return <GetInvoice>d__.<>t__builder.Task;
		}

		// Token: 0x06003A43 RID: 14915 RVA: 0x000DDFB8 File Offset: 0x000DC1B8
		public Task<IInvoiceLookup> GetInvoiceLookup(string invoiceNum, int year)
		{
			InvoiceService.<GetInvoiceLookup>d__4 <GetInvoiceLookup>d__;
			<GetInvoiceLookup>d__.<>t__builder = AsyncTaskMethodBuilder<IInvoiceLookup>.Create();
			<GetInvoiceLookup>d__.<>4__this = this;
			<GetInvoiceLookup>d__.invoiceNum = invoiceNum;
			<GetInvoiceLookup>d__.<>1__state = -1;
			<GetInvoiceLookup>d__.<>t__builder.Start<InvoiceService.<GetInvoiceLookup>d__4>(ref <GetInvoiceLookup>d__);
			return <GetInvoiceLookup>d__.<>t__builder.Task;
		}

		// Token: 0x06003A44 RID: 14916 RVA: 0x000DE004 File Offset: 0x000DC204
		public Task<string> GetLastInvoiveId(int sellerId)
		{
			InvoiceService.<GetLastInvoiveId>d__5 <GetLastInvoiveId>d__;
			<GetLastInvoiveId>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<GetLastInvoiveId>d__.<>4__this = this;
			<GetLastInvoiveId>d__.sellerId = sellerId;
			<GetLastInvoiveId>d__.<>1__state = -1;
			<GetLastInvoiveId>d__.<>t__builder.Start<InvoiceService.<GetLastInvoiveId>d__5>(ref <GetLastInvoiveId>d__);
			return <GetLastInvoiveId>d__.<>t__builder.Task;
		}

		// Token: 0x06003A45 RID: 14917 RVA: 0x000DE050 File Offset: 0x000DC250
		public IAscResult CreateWorksList(IWorksList doc)
		{
			Result result = new Result();
			try
			{
				using (auseceEntities auseceEntities = this._contextFactory.Create())
				{
					using (DbContextTransaction dbContextTransaction = auseceEntities.Database.BeginTransaction())
					{
						try
						{
							w_lists w_lists = new w_lists
							{
								num = doc.Num,
								created = doc.Date,
								user = doc.Employee.Id,
								seller = doc.Seller.Id,
								customer = doc.Customer.Id,
								tax = doc.Tax,
								summ = doc.Summ,
								total = doc.Total,
								office = doc.Employee.OfficeId,
								notes = doc.Notes,
								invoice = doc.InvoiceId,
								reason = doc.Reason
							};
							auseceEntities.w_lists.Add(w_lists);
							auseceEntities.SaveChanges();
							foreach (IInvoiceItem invoiceItem in doc.Items)
							{
								invoice_items entity = new invoice_items
								{
									name = invoiceItem.Name,
									price = invoiceItem.Price,
									count = invoiceItem.Count,
									units = invoiceItem.Units,
									tax = invoiceItem.Tax.GetValueOrDefault(),
									tax_mode = invoiceItem.TaxMode,
									total = invoiceItem.Total,
									w_list = new int?(w_lists.id),
									repair = invoiceItem.RepairId,
									document = invoiceItem.DocumentId
								};
								auseceEntities.invoice_items.Add(entity);
							}
							auseceEntities.SaveChanges();
							dbContextTransaction.Commit();
							result.Id = w_lists.id;
						}
						catch (Exception ex)
						{
							Exception innerException = ex.InnerException;
							if (((innerException != null) ? innerException.InnerException : null) != null && ex.InnerException.InnerException.Message.Contains("for key 'num'"))
							{
								result.MessageFromResource("InvoiceNumErr");
							}
							dbContextTransaction.Rollback();
							return result;
						}
					}
				}
			}
			catch (Exception ex2)
			{
				result.Message = ex2.Message;
				return result;
			}
			result.SetSuccess();
			return result;
		}

		// Token: 0x06003A46 RID: 14918 RVA: 0x000DE32C File Offset: 0x000DC52C
		public Task<IWorksList> GetWorksList(int invoiceId)
		{
			InvoiceService.<GetWorksList>d__7 <GetWorksList>d__;
			<GetWorksList>d__.<>t__builder = AsyncTaskMethodBuilder<IWorksList>.Create();
			<GetWorksList>d__.invoiceId = invoiceId;
			<GetWorksList>d__.<>1__state = -1;
			<GetWorksList>d__.<>t__builder.Start<InvoiceService.<GetWorksList>d__7>(ref <GetWorksList>d__);
			return <GetWorksList>d__.<>t__builder.Task;
		}

		// Token: 0x06003A47 RID: 14919 RVA: 0x000DE370 File Offset: 0x000DC570
		public Task UpdateInvoiceItem(IInvoiceItem item, IInvoice document, decimal total)
		{
			InvoiceService.<UpdateInvoiceItem>d__8 <UpdateInvoiceItem>d__;
			<UpdateInvoiceItem>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<UpdateInvoiceItem>d__.<>4__this = this;
			<UpdateInvoiceItem>d__.item = item;
			<UpdateInvoiceItem>d__.document = document;
			<UpdateInvoiceItem>d__.total = total;
			<UpdateInvoiceItem>d__.<>1__state = -1;
			<UpdateInvoiceItem>d__.<>t__builder.Start<InvoiceService.<UpdateInvoiceItem>d__8>(ref <UpdateInvoiceItem>d__);
			return <UpdateInvoiceItem>d__.<>t__builder.Task;
		}

		// Token: 0x06003A48 RID: 14920 RVA: 0x000DE3CC File Offset: 0x000DC5CC
		public Task UpdateInvoiceCustomer(int invoiceId, int banksId)
		{
			InvoiceService.<UpdateInvoiceCustomer>d__9 <UpdateInvoiceCustomer>d__;
			<UpdateInvoiceCustomer>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<UpdateInvoiceCustomer>d__.<>4__this = this;
			<UpdateInvoiceCustomer>d__.invoiceId = invoiceId;
			<UpdateInvoiceCustomer>d__.banksId = banksId;
			<UpdateInvoiceCustomer>d__.<>1__state = -1;
			<UpdateInvoiceCustomer>d__.<>t__builder.Start<InvoiceService.<UpdateInvoiceCustomer>d__9>(ref <UpdateInvoiceCustomer>d__);
			return <UpdateInvoiceCustomer>d__.<>t__builder.Task;
		}

		// Token: 0x04002531 RID: 9521
		private readonly IContextFactory _contextFactory;

		// Token: 0x02000723 RID: 1827
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x06003A49 RID: 14921 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x04002532 RID: 9522
			public DateTime from;

			// Token: 0x04002533 RID: 9523
			public DateTime to;

			// Token: 0x04002534 RID: 9524
			public int officeId;

			// Token: 0x04002535 RID: 9525
			public int state;

			// Token: 0x04002536 RID: 9526
			public string filter;
		}

		// Token: 0x02000724 RID: 1828
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003A4A RID: 14922 RVA: 0x000DE420 File Offset: 0x000DC620
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003A4B RID: 14923 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x04002537 RID: 9527
			public static readonly InvoiceService.<>c <>9 = new InvoiceService.<>c();
		}

		// Token: 0x02000725 RID: 1829
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetInvoices>d__2 : IAsyncStateMachine
		{
			// Token: 0x06003A4C RID: 14924 RVA: 0x000DE438 File Offset: 0x000DC638
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IEnumerable<IInvoice> result;
				try
				{
					InvoiceService.<>c__DisplayClass2_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new InvoiceService.<>c__DisplayClass2_0();
						CS$<>8__locals1.officeId = this.officeId;
						CS$<>8__locals1.state = this.state;
						CS$<>8__locals1.filter = this.filter;
						CS$<>8__locals1.from = this.period.From.Date;
						CS$<>8__locals1.to = this.period.To.Date.AddDays(1.0).AddSeconds(-1.0);
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						ConfiguredTaskAwaitable<List<invoice>>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							IQueryable<invoice> source = from i in this.<ctx>5__2.invoice.AsNoTracking().Include((invoice i) => i.users).Include((invoice i) => i.banks).Include((invoice i) => i.banks1)
							where i.created >= CS$<>8__locals1.@from && i.created <= CS$<>8__locals1.to
							select i;
							if (CS$<>8__locals1.officeId != 0)
							{
								source = from i in source
								where i.office == CS$<>8__locals1.officeId
								select i;
							}
							if (CS$<>8__locals1.state != 0)
							{
								source = from i in source
								where i.state == CS$<>8__locals1.state
								select i;
							}
							if (!string.IsNullOrEmpty(CS$<>8__locals1.filter))
							{
								source = from i in source
								where i.num.Contains(CS$<>8__locals1.filter) || i.banks1.ur_name.Contains(CS$<>8__locals1.filter)
								select i;
							}
							awaiter = (from d in source
							orderby d.id descending
							select d).ToListAsync<invoice>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<List<invoice>>.ConfiguredTaskAwaiter, InvoiceService.<GetInvoices>d__2>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<List<invoice>>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult().Select(new Func<invoice, Invoice>(InvoiceMapper.InvoiveConvert)).ToList<Invoice>();
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

			// Token: 0x06003A4D RID: 14925 RVA: 0x000DE998 File Offset: 0x000DCB98
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002538 RID: 9528
			public int <>1__state;

			// Token: 0x04002539 RID: 9529
			public AsyncTaskMethodBuilder<IEnumerable<IInvoice>> <>t__builder;

			// Token: 0x0400253A RID: 9530
			public int officeId;

			// Token: 0x0400253B RID: 9531
			public int state;

			// Token: 0x0400253C RID: 9532
			public string filter;

			// Token: 0x0400253D RID: 9533
			public IPeriod period;

			// Token: 0x0400253E RID: 9534
			private auseceEntities <ctx>5__2;

			// Token: 0x0400253F RID: 9535
			private ConfiguredTaskAwaitable<List<invoice>>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000726 RID: 1830
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06003A4E RID: 14926 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x04002540 RID: 9536
			public int invoiceId;
		}

		// Token: 0x02000727 RID: 1831
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetInvoice>d__3 : IAsyncStateMachine
		{
			// Token: 0x06003A4F RID: 14927 RVA: 0x000DE9B4 File Offset: 0x000DCBB4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Invoice result;
				try
				{
					InvoiceService.<>c__DisplayClass3_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new InvoiceService.<>c__DisplayClass3_0();
						CS$<>8__locals1.invoiceId = this.invoiceId;
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						ConfiguredTaskAwaitable<invoice>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = (from i in this.<ctx>5__2.invoice.AsNoTracking().Include((invoice i) => i.invoice_items).Include((invoice i) => from x in i.invoice_items
							select x.workshop).Include((invoice i) => i.users).Include((invoice i) => i.banks).Include((invoice i) => i.banks1)
							where i.id == CS$<>8__locals1.invoiceId
							select i).FirstOrDefaultAsync<invoice>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<invoice>.ConfiguredTaskAwaiter, InvoiceService.<GetInvoice>d__3>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<invoice>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						Invoice invoice = InvoiceMapper.InvoiveConvert(awaiter.GetResult());
						if (invoice != null)
						{
							invoice.CalcTotal();
						}
						result = invoice;
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

			// Token: 0x06003A50 RID: 14928 RVA: 0x000DECF8 File Offset: 0x000DCEF8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002541 RID: 9537
			public int <>1__state;

			// Token: 0x04002542 RID: 9538
			public AsyncTaskMethodBuilder<Invoice> <>t__builder;

			// Token: 0x04002543 RID: 9539
			public int invoiceId;

			// Token: 0x04002544 RID: 9540
			private auseceEntities <ctx>5__2;

			// Token: 0x04002545 RID: 9541
			private ConfiguredTaskAwaitable<invoice>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000728 RID: 1832
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x06003A51 RID: 14929 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x04002546 RID: 9542
			public string invoiceNum;
		}

		// Token: 0x02000729 RID: 1833
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetInvoiceLookup>d__4 : IAsyncStateMachine
		{
			// Token: 0x06003A52 RID: 14930 RVA: 0x000DED14 File Offset: 0x000DCF14
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				InvoiceService invoiceService = this.<>4__this;
				IInvoiceLookup result;
				try
				{
					InvoiceService.<>c__DisplayClass4_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new InvoiceService.<>c__DisplayClass4_0();
						CS$<>8__locals1.invoiceNum = this.invoiceNum;
						this.<ctx>5__2 = invoiceService._contextFactory.Create();
					}
					try
					{
						ConfiguredTaskAwaitable<InvoiceLookup>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							ParameterExpression parameterExpression;
							awaiter = (from i in this.<ctx>5__2.invoice.AsNoTracking()
							where i.num == CS$<>8__locals1.invoiceNum && i.created.Year == DateTime.Now.Year
							select i).Select(Expression.Lambda<Func<invoice, InvoiceLookup>>(Expression.MemberInit(Expression.New(typeof(InvoiceLookup)), new MemberBinding[]
							{
								Expression.Bind(methodof(InvoiceLookup.set_Id(int)), Expression.Property(parameterExpression, methodof(invoice.get_id()))),
								Expression.Bind(methodof(InvoiceLookup.set_Num(string)), Expression.Property(parameterExpression, methodof(invoice.get_num()))),
								Expression.Bind(methodof(InvoiceLookup.set_Date(DateTime)), Expression.Property(parameterExpression, methodof(invoice.get_created())))
							}), new ParameterExpression[]
							{
								parameterExpression
							})).FirstOrDefaultAsync<InvoiceLookup>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<InvoiceLookup>.ConfiguredTaskAwaiter, InvoiceService.<GetInvoiceLookup>d__4>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<InvoiceLookup>.ConfiguredTaskAwaiter);
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

			// Token: 0x06003A53 RID: 14931 RVA: 0x000DEFDC File Offset: 0x000DD1DC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002547 RID: 9543
			public int <>1__state;

			// Token: 0x04002548 RID: 9544
			public AsyncTaskMethodBuilder<IInvoiceLookup> <>t__builder;

			// Token: 0x04002549 RID: 9545
			public string invoiceNum;

			// Token: 0x0400254A RID: 9546
			public InvoiceService <>4__this;

			// Token: 0x0400254B RID: 9547
			private auseceEntities <ctx>5__2;

			// Token: 0x0400254C RID: 9548
			private ConfiguredTaskAwaitable<InvoiceLookup>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x0200072A RID: 1834
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06003A54 RID: 14932 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x0400254D RID: 9549
			public int sellerId;
		}

		// Token: 0x0200072B RID: 1835
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetLastInvoiveId>d__5 : IAsyncStateMachine
		{
			// Token: 0x06003A55 RID: 14933 RVA: 0x000DEFF8 File Offset: 0x000DD1F8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				InvoiceService invoiceService = this.<>4__this;
				string result2;
				try
				{
					InvoiceService.<>c__DisplayClass5_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new InvoiceService.<>c__DisplayClass5_0();
						CS$<>8__locals1.sellerId = this.sellerId;
						this.<ctx>5__2 = invoiceService._contextFactory.Create();
					}
					try
					{
						ConfiguredTaskAwaitable<invoice>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = (from i in this.<ctx>5__2.invoice.AsNoTracking()
							where i.seller == CS$<>8__locals1.sellerId
							select i into x
							orderby x.id descending
							select x).FirstOrDefaultAsync<invoice>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<invoice>.ConfiguredTaskAwaiter, InvoiceService.<GetLastInvoiveId>d__5>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<invoice>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						invoice result = awaiter.GetResult();
						string text;
						if (result != null)
						{
							if ((text = result.num) != null)
							{
								goto IL_16D;
							}
						}
						text = "";
						IL_16D:
						result2 = text;
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

			// Token: 0x06003A56 RID: 14934 RVA: 0x000DF1F0 File Offset: 0x000DD3F0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400254E RID: 9550
			public int <>1__state;

			// Token: 0x0400254F RID: 9551
			public AsyncTaskMethodBuilder<string> <>t__builder;

			// Token: 0x04002550 RID: 9552
			public int sellerId;

			// Token: 0x04002551 RID: 9553
			public InvoiceService <>4__this;

			// Token: 0x04002552 RID: 9554
			private auseceEntities <ctx>5__2;

			// Token: 0x04002553 RID: 9555
			private ConfiguredTaskAwaitable<invoice>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x0200072C RID: 1836
		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x06003A57 RID: 14935 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x04002554 RID: 9556
			public int invoiceId;
		}

		// Token: 0x0200072D RID: 1837
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetWorksList>d__7 : IAsyncStateMachine
		{
			// Token: 0x06003A58 RID: 14936 RVA: 0x000DF20C File Offset: 0x000DD40C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IWorksList result;
				try
				{
					InvoiceService.<>c__DisplayClass7_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new InvoiceService.<>c__DisplayClass7_0();
						CS$<>8__locals1.invoiceId = this.invoiceId;
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						ConfiguredTaskAwaitable<w_lists>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = (from i in this.<ctx>5__2.w_lists.AsNoTracking().Include((w_lists i) => i.invoice_items).Include((w_lists i) => from x in i.invoice_items
							select x.workshop).Include((w_lists i) => i.users).Include((w_lists i) => i.banks).Include((w_lists i) => i.banks1)
							where i.id == CS$<>8__locals1.invoiceId
							select i).FirstOrDefaultAsync<w_lists>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<w_lists>.ConfiguredTaskAwaiter, InvoiceService.<GetWorksList>d__7>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<w_lists>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						WorksList worksList = WorksListMapper.WorksListConvert(awaiter.GetResult());
						if (worksList != null)
						{
							worksList.CalcTotal();
						}
						result = worksList;
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

			// Token: 0x06003A59 RID: 14937 RVA: 0x000DF550 File Offset: 0x000DD750
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002555 RID: 9557
			public int <>1__state;

			// Token: 0x04002556 RID: 9558
			public AsyncTaskMethodBuilder<IWorksList> <>t__builder;

			// Token: 0x04002557 RID: 9559
			public int invoiceId;

			// Token: 0x04002558 RID: 9560
			private auseceEntities <ctx>5__2;

			// Token: 0x04002559 RID: 9561
			private ConfiguredTaskAwaitable<w_lists>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x0200072E RID: 1838
		[CompilerGenerated]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x06003A5A RID: 14938 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x0400255A RID: 9562
			public IInvoiceItem item;

			// Token: 0x0400255B RID: 9563
			public IInvoice document;
		}

		// Token: 0x0200072F RID: 1839
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateInvoiceItem>d__8 : IAsyncStateMachine
		{
			// Token: 0x06003A5B RID: 14939 RVA: 0x000DF56C File Offset: 0x000DD76C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				InvoiceService invoiceService = this.<>4__this;
				try
				{
					if (num > 5)
					{
						this.<>8__1 = new InvoiceService.<>c__DisplayClass8_0();
						this.<>8__1.item = this.item;
						this.<>8__1.document = this.document;
						this.<ctx>5__2 = invoiceService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<invoice_items> awaiter;
						TaskAwaiter<invoice> awaiter2;
						TaskAwaiter<w_lists> awaiter3;
						TaskAwaiter<p_lists> awaiter4;
						TaskAwaiter<vat_invoice> awaiter5;
						TaskAwaiter<int> awaiter6;
						switch (num)
						{
						case 0:
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<invoice_items>);
							int num2 = -1;
							num = -1;
							this.<>1__state = num2;
							break;
						}
						case 1:
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<invoice>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
							goto IL_2FB;
						}
						case 2:
						{
							awaiter3 = this.<>u__3;
							this.<>u__3 = default(TaskAwaiter<w_lists>);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
							goto IL_408;
						}
						case 3:
						{
							awaiter4 = this.<>u__4;
							this.<>u__4 = default(TaskAwaiter<p_lists>);
							int num5 = -1;
							num = -1;
							this.<>1__state = num5;
							goto IL_515;
						}
						case 4:
						{
							awaiter5 = this.<>u__5;
							this.<>u__5 = default(TaskAwaiter<vat_invoice>);
							int num6 = -1;
							num = -1;
							this.<>1__state = num6;
							goto IL_622;
						}
						case 5:
						{
							awaiter6 = this.<>u__6;
							this.<>u__6 = default(TaskAwaiter<int>);
							int num7 = -1;
							num = -1;
							this.<>1__state = num7;
							goto IL_69C;
						}
						default:
							awaiter = this.<ctx>5__2.invoice_items.SingleAsync((invoice_items i) => i.id == this.<>8__1.item.Id).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num8 = 0;
								num = 0;
								this.<>1__state = num8;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<invoice_items>, InvoiceService.<UpdateInvoiceItem>d__8>(ref awaiter, ref this);
								return;
							}
							break;
						}
						invoice_items result = awaiter.GetResult();
						result.name = this.<>8__1.item.Name;
						result.price = this.<>8__1.item.Price;
						result.count = this.<>8__1.item.Count;
						result.total = this.<>8__1.item.Total;
						result.units = this.<>8__1.item.Units;
						if (this.<>8__1.item.Tax != null)
						{
							result.tax = this.<>8__1.item.Tax.Value;
						}
						result.tax_mode = this.<>8__1.item.TaxMode;
						if (!(this.<>8__1.document is Invoice))
						{
							goto IL_319;
						}
						awaiter2 = this.<ctx>5__2.invoice.SingleAsync((invoice i) => i.id == this.<>8__1.document.Id).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num9 = 1;
							num = 1;
							this.<>1__state = num9;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<invoice>, InvoiceService.<UpdateInvoiceItem>d__8>(ref awaiter2, ref this);
							return;
						}
						IL_2FB:
						invoice result2 = awaiter2.GetResult();
						result2.summ = this.total;
						result2.total = this.total;
						IL_319:
						if (!(this.<>8__1.document is WorksList))
						{
							goto IL_426;
						}
						awaiter3 = this.<ctx>5__2.w_lists.SingleAsync((w_lists i) => i.id == this.<>8__1.document.Id).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							int num10 = 2;
							num = 2;
							this.<>1__state = num10;
							this.<>u__3 = awaiter3;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<w_lists>, InvoiceService.<UpdateInvoiceItem>d__8>(ref awaiter3, ref this);
							return;
						}
						IL_408:
						w_lists result3 = awaiter3.GetResult();
						result3.summ = this.total;
						result3.total = this.total;
						IL_426:
						if (!(this.<>8__1.document is PackingList))
						{
							goto IL_533;
						}
						awaiter4 = this.<ctx>5__2.p_lists.SingleAsync((p_lists i) => i.id == this.<>8__1.document.Id).GetAwaiter();
						if (!awaiter4.IsCompleted)
						{
							int num11 = 3;
							num = 3;
							this.<>1__state = num11;
							this.<>u__4 = awaiter4;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<p_lists>, InvoiceService.<UpdateInvoiceItem>d__8>(ref awaiter4, ref this);
							return;
						}
						IL_515:
						p_lists result4 = awaiter4.GetResult();
						result4.summ = this.total;
						result4.total = this.total;
						IL_533:
						if (!(this.<>8__1.document is VATInvoice))
						{
							goto IL_640;
						}
						awaiter5 = this.<ctx>5__2.vat_invoice.SingleAsync((vat_invoice i) => i.id == this.<>8__1.document.Id).GetAwaiter();
						if (!awaiter5.IsCompleted)
						{
							int num12 = 4;
							num = 4;
							this.<>1__state = num12;
							this.<>u__5 = awaiter5;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<vat_invoice>, InvoiceService.<UpdateInvoiceItem>d__8>(ref awaiter5, ref this);
							return;
						}
						IL_622:
						vat_invoice result5 = awaiter5.GetResult();
						result5.summ = this.total;
						result5.total = this.total;
						IL_640:
						awaiter6 = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
						if (!awaiter6.IsCompleted)
						{
							int num13 = 5;
							num = 5;
							this.<>1__state = num13;
							this.<>u__6 = awaiter6;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, InvoiceService.<UpdateInvoiceItem>d__8>(ref awaiter6, ref this);
							return;
						}
						IL_69C:
						awaiter6.GetResult();
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

			// Token: 0x06003A5C RID: 14940 RVA: 0x000DFCB0 File Offset: 0x000DDEB0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400255C RID: 9564
			public int <>1__state;

			// Token: 0x0400255D RID: 9565
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400255E RID: 9566
			public IInvoiceItem item;

			// Token: 0x0400255F RID: 9567
			public IInvoice document;

			// Token: 0x04002560 RID: 9568
			public InvoiceService <>4__this;

			// Token: 0x04002561 RID: 9569
			private InvoiceService.<>c__DisplayClass8_0 <>8__1;

			// Token: 0x04002562 RID: 9570
			public decimal total;

			// Token: 0x04002563 RID: 9571
			private auseceEntities <ctx>5__2;

			// Token: 0x04002564 RID: 9572
			private TaskAwaiter<invoice_items> <>u__1;

			// Token: 0x04002565 RID: 9573
			private TaskAwaiter<invoice> <>u__2;

			// Token: 0x04002566 RID: 9574
			private TaskAwaiter<w_lists> <>u__3;

			// Token: 0x04002567 RID: 9575
			private TaskAwaiter<p_lists> <>u__4;

			// Token: 0x04002568 RID: 9576
			private TaskAwaiter<vat_invoice> <>u__5;

			// Token: 0x04002569 RID: 9577
			private TaskAwaiter<int> <>u__6;
		}

		// Token: 0x02000730 RID: 1840
		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x06003A5D RID: 14941 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x0400256A RID: 9578
			public int invoiceId;
		}

		// Token: 0x02000731 RID: 1841
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateInvoiceCustomer>d__9 : IAsyncStateMachine
		{
			// Token: 0x06003A5E RID: 14942 RVA: 0x000DFCCC File Offset: 0x000DDECC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				InvoiceService invoiceService = this.<>4__this;
				try
				{
					InvoiceService.<>c__DisplayClass9_0 CS$<>8__locals1;
					if (num > 1)
					{
						CS$<>8__locals1 = new InvoiceService.<>c__DisplayClass9_0();
						CS$<>8__locals1.invoiceId = this.invoiceId;
						this.<ctx>5__2 = invoiceService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<int> awaiter;
						TaskAwaiter<invoice> awaiter2;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<int>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								goto IL_14D;
							}
							awaiter2 = this.<ctx>5__2.invoice.SingleAsync((invoice i) => i.id == CS$<>8__locals1.invoiceId).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num3 = 0;
								num = 0;
								this.<>1__state = num3;
								this.<>u__1 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<invoice>, InvoiceService.<UpdateInvoiceCustomer>d__9>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<invoice>);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
						}
						awaiter2.GetResult().customer = this.banksId;
						awaiter = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num5 = 1;
							num = 1;
							this.<>1__state = num5;
							this.<>u__2 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, InvoiceService.<UpdateInvoiceCustomer>d__9>(ref awaiter, ref this);
							return;
						}
						IL_14D:
						awaiter.GetResult();
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
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003A5F RID: 14943 RVA: 0x000DFED4 File Offset: 0x000DE0D4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400256B RID: 9579
			public int <>1__state;

			// Token: 0x0400256C RID: 9580
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400256D RID: 9581
			public int invoiceId;

			// Token: 0x0400256E RID: 9582
			public InvoiceService <>4__this;

			// Token: 0x0400256F RID: 9583
			public int banksId;

			// Token: 0x04002570 RID: 9584
			private auseceEntities <ctx>5__2;

			// Token: 0x04002571 RID: 9585
			private TaskAwaiter<invoice> <>u__1;

			// Token: 0x04002572 RID: 9586
			private TaskAwaiter<int> <>u__2;
		}
	}
}
