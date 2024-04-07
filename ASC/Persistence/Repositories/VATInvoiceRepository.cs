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
using ASC.Common.Repositories;
using ASC.Models;
using ASC.Objects;
using ASC.Objects.Converters;

namespace ASC.Persistence.Repositories
{
	// Token: 0x020002EF RID: 751
	public class VATInvoiceRepository : GenericRepository<vat_invoice>, IVATInvoiceRepository
	{
		// Token: 0x06002477 RID: 9335 RVA: 0x0006DB48 File Offset: 0x0006BD48
		public VATInvoiceRepository(auseceEntities context) : base(context)
		{
		}

		// Token: 0x06002478 RID: 9336 RVA: 0x0006DB5C File Offset: 0x0006BD5C
		public Task<IEnumerable<IInvoice>> GetInvoices(IPeriod period, int officeId, int state, string filter)
		{
			VATInvoiceRepository.<GetInvoices>d__1 <GetInvoices>d__;
			<GetInvoices>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<IInvoice>>.Create();
			<GetInvoices>d__.<>4__this = this;
			<GetInvoices>d__.period = period;
			<GetInvoices>d__.officeId = officeId;
			<GetInvoices>d__.<>1__state = -1;
			<GetInvoices>d__.<>t__builder.Start<VATInvoiceRepository.<GetInvoices>d__1>(ref <GetInvoices>d__);
			return <GetInvoices>d__.<>t__builder.Task;
		}

		// Token: 0x06002479 RID: 9337 RVA: 0x0006DBB0 File Offset: 0x0006BDB0
		public Task<string> GetLastInvoiveId(int sellerId)
		{
			VATInvoiceRepository.<GetLastInvoiveId>d__2 <GetLastInvoiveId>d__;
			<GetLastInvoiveId>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<GetLastInvoiveId>d__.<>4__this = this;
			<GetLastInvoiveId>d__.sellerId = sellerId;
			<GetLastInvoiveId>d__.<>1__state = -1;
			<GetLastInvoiveId>d__.<>t__builder.Start<VATInvoiceRepository.<GetLastInvoiveId>d__2>(ref <GetLastInvoiveId>d__);
			return <GetLastInvoiveId>d__.<>t__builder.Task;
		}

		// Token: 0x0600247A RID: 9338 RVA: 0x0006DBFC File Offset: 0x0006BDFC
		public Task<IInvoiceLookup> GetVATInvoiceLookup(string invoiceNum, int year)
		{
			VATInvoiceRepository.<GetVATInvoiceLookup>d__3 <GetVATInvoiceLookup>d__;
			<GetVATInvoiceLookup>d__.<>t__builder = AsyncTaskMethodBuilder<IInvoiceLookup>.Create();
			<GetVATInvoiceLookup>d__.<>4__this = this;
			<GetVATInvoiceLookup>d__.invoiceNum = invoiceNum;
			<GetVATInvoiceLookup>d__.<>1__state = -1;
			<GetVATInvoiceLookup>d__.<>t__builder.Start<VATInvoiceRepository.<GetVATInvoiceLookup>d__3>(ref <GetVATInvoiceLookup>d__);
			return <GetVATInvoiceLookup>d__.<>t__builder.Task;
		}

		// Token: 0x020002F0 RID: 752
		[CompilerGenerated]
		private sealed class <>c__DisplayClass1_0
		{
			// Token: 0x0600247B RID: 9339 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass1_0()
			{
			}

			// Token: 0x04001333 RID: 4915
			public DateTime from;

			// Token: 0x04001334 RID: 4916
			public DateTime to;

			// Token: 0x04001335 RID: 4917
			public int officeId;
		}

		// Token: 0x020002F1 RID: 753
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600247C RID: 9340 RVA: 0x0006DC48 File Offset: 0x0006BE48
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600247D RID: 9341 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x0600247E RID: 9342 RVA: 0x0006DC60 File Offset: 0x0006BE60
			internal IOrderedQueryable<vat_invoice> <GetInvoices>b__1_2(IQueryable<vat_invoice> i)
			{
				return from d in i
				orderby d.id descending
				select d;
			}

			// Token: 0x04001336 RID: 4918
			public static readonly VATInvoiceRepository.<>c <>9 = new VATInvoiceRepository.<>c();

			// Token: 0x04001337 RID: 4919
			public static Func<IQueryable<vat_invoice>, IOrderedQueryable<vat_invoice>> <>9__1_2;
		}

		// Token: 0x020002F2 RID: 754
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetInvoices>d__1 : IAsyncStateMachine
		{
			// Token: 0x0600247F RID: 9343 RVA: 0x0006DCAC File Offset: 0x0006BEAC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				VATInvoiceRepository vatinvoiceRepository = this.<>4__this;
				IEnumerable<IInvoice> result;
				try
				{
					TaskAwaiter<IEnumerable<vat_invoice>> awaiter;
					if (num != 0)
					{
						VATInvoiceRepository.<>c__DisplayClass1_0 CS$<>8__locals1 = new VATInvoiceRepository.<>c__DisplayClass1_0();
						CS$<>8__locals1.officeId = this.officeId;
						CS$<>8__locals1.from = this.period.From.Date;
						CS$<>8__locals1.to = this.period.To.Date.AddDays(1.0).AddSeconds(-1.0);
						List<KeyValuePair<bool, Expression<Func<vat_invoice, bool>>>> filterList = new List<KeyValuePair<bool, Expression<Func<vat_invoice, bool>>>>
						{
							new KeyValuePair<bool, Expression<Func<vat_invoice, bool>>>(true, (vat_invoice i) => i.created >= CS$<>8__locals1.from && i.created <= CS$<>8__locals1.to),
							new KeyValuePair<bool, Expression<Func<vat_invoice, bool>>>(CS$<>8__locals1.officeId != 0, (vat_invoice i) => i.office == CS$<>8__locals1.officeId)
						};
						awaiter = vatinvoiceRepository.GetAllAsync(filterList, new Func<IQueryable<vat_invoice>, IOrderedQueryable<vat_invoice>>(VATInvoiceRepository.<>c.<>9.<GetInvoices>b__1_2), "users,banks,banks1,invoice1", true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<vat_invoice>>, VATInvoiceRepository.<GetInvoices>d__1>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<vat_invoice>>);
						this.<>1__state = -1;
					}
					result = awaiter.GetResult().Select(new Func<vat_invoice, VATInvoice>(VATInvoiceMapper.VATInvoiveConvert)).ToList<VATInvoice>();
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

			// Token: 0x06002480 RID: 9344 RVA: 0x0006DF68 File Offset: 0x0006C168
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001338 RID: 4920
			public int <>1__state;

			// Token: 0x04001339 RID: 4921
			public AsyncTaskMethodBuilder<IEnumerable<IInvoice>> <>t__builder;

			// Token: 0x0400133A RID: 4922
			public int officeId;

			// Token: 0x0400133B RID: 4923
			public IPeriod period;

			// Token: 0x0400133C RID: 4924
			public VATInvoiceRepository <>4__this;

			// Token: 0x0400133D RID: 4925
			private TaskAwaiter<IEnumerable<vat_invoice>> <>u__1;
		}

		// Token: 0x020002F3 RID: 755
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x06002481 RID: 9345 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x0400133E RID: 4926
			public int sellerId;
		}

		// Token: 0x020002F4 RID: 756
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetLastInvoiveId>d__2 : IAsyncStateMachine
		{
			// Token: 0x06002482 RID: 9346 RVA: 0x0006DF84 File Offset: 0x0006C184
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				VATInvoiceRepository vatinvoiceRepository = this.<>4__this;
				string result2;
				try
				{
					TaskAwaiter<vat_invoice> awaiter;
					if (num != 0)
					{
						VATInvoiceRepository.<>c__DisplayClass2_0 CS$<>8__locals1 = new VATInvoiceRepository.<>c__DisplayClass2_0();
						CS$<>8__locals1.sellerId = this.sellerId;
						awaiter = (from i in vatinvoiceRepository._context.vat_invoice.AsNoTracking()
						where i.seller == CS$<>8__locals1.sellerId
						select i into x
						orderby x.id descending
						select x).FirstOrDefaultAsync<vat_invoice>().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<vat_invoice>, VATInvoiceRepository.<GetLastInvoiveId>d__2>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<vat_invoice>);
						this.<>1__state = -1;
					}
					vat_invoice result = awaiter.GetResult();
					string text;
					if (result != null)
					{
						if ((text = result.num) != null)
						{
							goto IL_14B;
						}
					}
					text = "";
					IL_14B:
					result2 = text;
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

			// Token: 0x06002483 RID: 9347 RVA: 0x0006E128 File Offset: 0x0006C328
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400133F RID: 4927
			public int <>1__state;

			// Token: 0x04001340 RID: 4928
			public AsyncTaskMethodBuilder<string> <>t__builder;

			// Token: 0x04001341 RID: 4929
			public int sellerId;

			// Token: 0x04001342 RID: 4930
			public VATInvoiceRepository <>4__this;

			// Token: 0x04001343 RID: 4931
			private TaskAwaiter<vat_invoice> <>u__1;
		}

		// Token: 0x020002F5 RID: 757
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06002484 RID: 9348 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x04001344 RID: 4932
			public string invoiceNum;
		}

		// Token: 0x020002F6 RID: 758
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetVATInvoiceLookup>d__3 : IAsyncStateMachine
		{
			// Token: 0x06002485 RID: 9349 RVA: 0x0006E144 File Offset: 0x0006C344
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				VATInvoiceRepository vatinvoiceRepository = this.<>4__this;
				IInvoiceLookup result;
				try
				{
					ConfiguredTaskAwaitable<InvoiceLookup>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						VATInvoiceRepository.<>c__DisplayClass3_0 CS$<>8__locals1 = new VATInvoiceRepository.<>c__DisplayClass3_0();
						CS$<>8__locals1.invoiceNum = this.invoiceNum;
						ParameterExpression parameterExpression;
						awaiter = (from i in vatinvoiceRepository._context.vat_invoice.AsNoTracking()
						where i.num == CS$<>8__locals1.invoiceNum && i.created.Year == DateTime.Now.Year
						select i).Select(Expression.Lambda<Func<vat_invoice, InvoiceLookup>>(Expression.MemberInit(Expression.New(typeof(InvoiceLookup)), new MemberBinding[]
						{
							Expression.Bind(methodof(InvoiceLookup.set_Id(int)), Expression.Property(parameterExpression, methodof(vat_invoice.get_id()))),
							Expression.Bind(methodof(InvoiceLookup.set_Num(string)), Expression.Property(parameterExpression, methodof(vat_invoice.get_num()))),
							Expression.Bind(methodof(InvoiceLookup.set_Date(DateTime)), Expression.Property(parameterExpression, methodof(vat_invoice.get_created())))
						}), new ParameterExpression[]
						{
							parameterExpression
						})).FirstOrDefaultAsync<InvoiceLookup>().ConfigureAwait(false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<InvoiceLookup>.ConfiguredTaskAwaiter, VATInvoiceRepository.<GetVATInvoiceLookup>d__3>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(ConfiguredTaskAwaitable<InvoiceLookup>.ConfiguredTaskAwaiter);
						this.<>1__state = -1;
					}
					result = awaiter.GetResult();
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

			// Token: 0x06002486 RID: 9350 RVA: 0x0006E3C8 File Offset: 0x0006C5C8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001345 RID: 4933
			public int <>1__state;

			// Token: 0x04001346 RID: 4934
			public AsyncTaskMethodBuilder<IInvoiceLookup> <>t__builder;

			// Token: 0x04001347 RID: 4935
			public string invoiceNum;

			// Token: 0x04001348 RID: 4936
			public VATInvoiceRepository <>4__this;

			// Token: 0x04001349 RID: 4937
			private ConfiguredTaskAwaitable<InvoiceLookup>.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
