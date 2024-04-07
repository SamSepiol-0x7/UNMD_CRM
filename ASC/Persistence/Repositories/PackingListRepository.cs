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
	// Token: 0x020002E7 RID: 743
	public class PackingListRepository : GenericRepository<p_lists>, IPackingListRepository
	{
		// Token: 0x06002467 RID: 9319 RVA: 0x0006D2AC File Offset: 0x0006B4AC
		public PackingListRepository(auseceEntities context) : base(context)
		{
		}

		// Token: 0x06002468 RID: 9320 RVA: 0x0006D2C0 File Offset: 0x0006B4C0
		public Task<IEnumerable<IInvoice>> GetInvoices(IPeriod period, int officeId, int state, string filter)
		{
			PackingListRepository.<GetInvoices>d__1 <GetInvoices>d__;
			<GetInvoices>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<IInvoice>>.Create();
			<GetInvoices>d__.<>4__this = this;
			<GetInvoices>d__.period = period;
			<GetInvoices>d__.officeId = officeId;
			<GetInvoices>d__.<>1__state = -1;
			<GetInvoices>d__.<>t__builder.Start<PackingListRepository.<GetInvoices>d__1>(ref <GetInvoices>d__);
			return <GetInvoices>d__.<>t__builder.Task;
		}

		// Token: 0x06002469 RID: 9321 RVA: 0x0006D314 File Offset: 0x0006B514
		public Task<string> GetLastPackingListId(int sellerId)
		{
			PackingListRepository.<GetLastPackingListId>d__2 <GetLastPackingListId>d__;
			<GetLastPackingListId>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<GetLastPackingListId>d__.<>4__this = this;
			<GetLastPackingListId>d__.sellerId = sellerId;
			<GetLastPackingListId>d__.<>1__state = -1;
			<GetLastPackingListId>d__.<>t__builder.Start<PackingListRepository.<GetLastPackingListId>d__2>(ref <GetLastPackingListId>d__);
			return <GetLastPackingListId>d__.<>t__builder.Task;
		}

		// Token: 0x0600246A RID: 9322 RVA: 0x0006D360 File Offset: 0x0006B560
		public Task<IInvoiceLookup> GetPackingListLookup(string invoiceNum, int year)
		{
			PackingListRepository.<GetPackingListLookup>d__3 <GetPackingListLookup>d__;
			<GetPackingListLookup>d__.<>t__builder = AsyncTaskMethodBuilder<IInvoiceLookup>.Create();
			<GetPackingListLookup>d__.<>4__this = this;
			<GetPackingListLookup>d__.invoiceNum = invoiceNum;
			<GetPackingListLookup>d__.<>1__state = -1;
			<GetPackingListLookup>d__.<>t__builder.Start<PackingListRepository.<GetPackingListLookup>d__3>(ref <GetPackingListLookup>d__);
			return <GetPackingListLookup>d__.<>t__builder.Task;
		}

		// Token: 0x020002E8 RID: 744
		[CompilerGenerated]
		private sealed class <>c__DisplayClass1_0
		{
			// Token: 0x0600246B RID: 9323 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass1_0()
			{
			}

			// Token: 0x0400131C RID: 4892
			public DateTime from;

			// Token: 0x0400131D RID: 4893
			public DateTime to;

			// Token: 0x0400131E RID: 4894
			public int officeId;
		}

		// Token: 0x020002E9 RID: 745
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600246C RID: 9324 RVA: 0x0006D3AC File Offset: 0x0006B5AC
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600246D RID: 9325 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x0600246E RID: 9326 RVA: 0x0006D3C4 File Offset: 0x0006B5C4
			internal IOrderedQueryable<p_lists> <GetInvoices>b__1_2(IQueryable<p_lists> i)
			{
				return from d in i
				orderby d.id descending
				select d;
			}

			// Token: 0x0400131F RID: 4895
			public static readonly PackingListRepository.<>c <>9 = new PackingListRepository.<>c();

			// Token: 0x04001320 RID: 4896
			public static Func<IQueryable<p_lists>, IOrderedQueryable<p_lists>> <>9__1_2;
		}

		// Token: 0x020002EA RID: 746
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetInvoices>d__1 : IAsyncStateMachine
		{
			// Token: 0x0600246F RID: 9327 RVA: 0x0006D410 File Offset: 0x0006B610
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PackingListRepository packingListRepository = this.<>4__this;
				IEnumerable<IInvoice> result;
				try
				{
					TaskAwaiter<IEnumerable<p_lists>> awaiter;
					if (num != 0)
					{
						PackingListRepository.<>c__DisplayClass1_0 CS$<>8__locals1 = new PackingListRepository.<>c__DisplayClass1_0();
						CS$<>8__locals1.officeId = this.officeId;
						CS$<>8__locals1.from = this.period.From.Date;
						CS$<>8__locals1.to = this.period.To.Date.AddDays(1.0).AddSeconds(-1.0);
						List<KeyValuePair<bool, Expression<Func<p_lists, bool>>>> filterList = new List<KeyValuePair<bool, Expression<Func<p_lists, bool>>>>
						{
							new KeyValuePair<bool, Expression<Func<p_lists, bool>>>(true, (p_lists i) => i.created >= CS$<>8__locals1.from && i.created <= CS$<>8__locals1.to),
							new KeyValuePair<bool, Expression<Func<p_lists, bool>>>(CS$<>8__locals1.officeId != 0, (p_lists i) => i.office == CS$<>8__locals1.officeId)
						};
						awaiter = packingListRepository.GetAllAsync(filterList, new Func<IQueryable<p_lists>, IOrderedQueryable<p_lists>>(PackingListRepository.<>c.<>9.<GetInvoices>b__1_2), "users,banks,banks1,invoice1", false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<p_lists>>, PackingListRepository.<GetInvoices>d__1>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<p_lists>>);
						this.<>1__state = -1;
					}
					result = awaiter.GetResult().Select(new Func<p_lists, PackingList>(PackingListMapper.PackingListConvert)).ToList<PackingList>();
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

			// Token: 0x06002470 RID: 9328 RVA: 0x0006D6CC File Offset: 0x0006B8CC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001321 RID: 4897
			public int <>1__state;

			// Token: 0x04001322 RID: 4898
			public AsyncTaskMethodBuilder<IEnumerable<IInvoice>> <>t__builder;

			// Token: 0x04001323 RID: 4899
			public int officeId;

			// Token: 0x04001324 RID: 4900
			public IPeriod period;

			// Token: 0x04001325 RID: 4901
			public PackingListRepository <>4__this;

			// Token: 0x04001326 RID: 4902
			private TaskAwaiter<IEnumerable<p_lists>> <>u__1;
		}

		// Token: 0x020002EB RID: 747
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x06002471 RID: 9329 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x04001327 RID: 4903
			public int sellerId;
		}

		// Token: 0x020002EC RID: 748
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetLastPackingListId>d__2 : IAsyncStateMachine
		{
			// Token: 0x06002472 RID: 9330 RVA: 0x0006D6E8 File Offset: 0x0006B8E8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PackingListRepository packingListRepository = this.<>4__this;
				string result2;
				try
				{
					TaskAwaiter<p_lists> awaiter;
					if (num != 0)
					{
						PackingListRepository.<>c__DisplayClass2_0 CS$<>8__locals1 = new PackingListRepository.<>c__DisplayClass2_0();
						CS$<>8__locals1.sellerId = this.sellerId;
						awaiter = (from i in packingListRepository._context.p_lists.AsNoTracking()
						where i.seller == CS$<>8__locals1.sellerId
						select i into x
						orderby x.id descending
						select x).FirstOrDefaultAsync<p_lists>().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<p_lists>, PackingListRepository.<GetLastPackingListId>d__2>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<p_lists>);
						this.<>1__state = -1;
					}
					p_lists result = awaiter.GetResult();
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

			// Token: 0x06002473 RID: 9331 RVA: 0x0006D88C File Offset: 0x0006BA8C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001328 RID: 4904
			public int <>1__state;

			// Token: 0x04001329 RID: 4905
			public AsyncTaskMethodBuilder<string> <>t__builder;

			// Token: 0x0400132A RID: 4906
			public int sellerId;

			// Token: 0x0400132B RID: 4907
			public PackingListRepository <>4__this;

			// Token: 0x0400132C RID: 4908
			private TaskAwaiter<p_lists> <>u__1;
		}

		// Token: 0x020002ED RID: 749
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06002474 RID: 9332 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x0400132D RID: 4909
			public string invoiceNum;
		}

		// Token: 0x020002EE RID: 750
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetPackingListLookup>d__3 : IAsyncStateMachine
		{
			// Token: 0x06002475 RID: 9333 RVA: 0x0006D8A8 File Offset: 0x0006BAA8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PackingListRepository packingListRepository = this.<>4__this;
				IInvoiceLookup result;
				try
				{
					ConfiguredTaskAwaitable<InvoiceLookup>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						PackingListRepository.<>c__DisplayClass3_0 CS$<>8__locals1 = new PackingListRepository.<>c__DisplayClass3_0();
						CS$<>8__locals1.invoiceNum = this.invoiceNum;
						ParameterExpression parameterExpression;
						awaiter = (from i in packingListRepository._context.p_lists.AsNoTracking()
						where i.num == CS$<>8__locals1.invoiceNum && i.created.Year == DateTime.Now.Year
						select i).Select(Expression.Lambda<Func<p_lists, InvoiceLookup>>(Expression.MemberInit(Expression.New(typeof(InvoiceLookup)), new MemberBinding[]
						{
							Expression.Bind(methodof(InvoiceLookup.set_Id(int)), Expression.Property(parameterExpression, methodof(p_lists.get_id()))),
							Expression.Bind(methodof(InvoiceLookup.set_Num(string)), Expression.Property(parameterExpression, methodof(p_lists.get_num()))),
							Expression.Bind(methodof(InvoiceLookup.set_Date(DateTime)), Expression.Property(parameterExpression, methodof(p_lists.get_created())))
						}), new ParameterExpression[]
						{
							parameterExpression
						})).FirstOrDefaultAsync<InvoiceLookup>().ConfigureAwait(false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<InvoiceLookup>.ConfiguredTaskAwaiter, PackingListRepository.<GetPackingListLookup>d__3>(ref awaiter, ref this);
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

			// Token: 0x06002476 RID: 9334 RVA: 0x0006DB2C File Offset: 0x0006BD2C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400132E RID: 4910
			public int <>1__state;

			// Token: 0x0400132F RID: 4911
			public AsyncTaskMethodBuilder<IInvoiceLookup> <>t__builder;

			// Token: 0x04001330 RID: 4912
			public string invoiceNum;

			// Token: 0x04001331 RID: 4913
			public PackingListRepository <>4__this;

			// Token: 0x04001332 RID: 4914
			private ConfiguredTaskAwaitable<InvoiceLookup>.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
