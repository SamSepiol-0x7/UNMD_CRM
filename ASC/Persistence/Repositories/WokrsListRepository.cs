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
	// Token: 0x020002F7 RID: 759
	public class WokrsListRepository : GenericRepository<w_lists>, IWorksListRepository
	{
		// Token: 0x06002487 RID: 9351 RVA: 0x0006E3E4 File Offset: 0x0006C5E4
		public WokrsListRepository(auseceEntities context) : base(context)
		{
		}

		// Token: 0x06002488 RID: 9352 RVA: 0x0006E3F8 File Offset: 0x0006C5F8
		public Task<string> GetLastWokrsListId(int sellerId)
		{
			WokrsListRepository.<GetLastWokrsListId>d__1 <GetLastWokrsListId>d__;
			<GetLastWokrsListId>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<GetLastWokrsListId>d__.<>4__this = this;
			<GetLastWokrsListId>d__.sellerId = sellerId;
			<GetLastWokrsListId>d__.<>1__state = -1;
			<GetLastWokrsListId>d__.<>t__builder.Start<WokrsListRepository.<GetLastWokrsListId>d__1>(ref <GetLastWokrsListId>d__);
			return <GetLastWokrsListId>d__.<>t__builder.Task;
		}

		// Token: 0x06002489 RID: 9353 RVA: 0x0006E444 File Offset: 0x0006C644
		public Task<IInvoiceLookup> GetWokrsListLookup(string invoiceNum, int year)
		{
			WokrsListRepository.<GetWokrsListLookup>d__2 <GetWokrsListLookup>d__;
			<GetWokrsListLookup>d__.<>t__builder = AsyncTaskMethodBuilder<IInvoiceLookup>.Create();
			<GetWokrsListLookup>d__.<>4__this = this;
			<GetWokrsListLookup>d__.invoiceNum = invoiceNum;
			<GetWokrsListLookup>d__.<>1__state = -1;
			<GetWokrsListLookup>d__.<>t__builder.Start<WokrsListRepository.<GetWokrsListLookup>d__2>(ref <GetWokrsListLookup>d__);
			return <GetWokrsListLookup>d__.<>t__builder.Task;
		}

		// Token: 0x0600248A RID: 9354 RVA: 0x0006E490 File Offset: 0x0006C690
		public Task<IEnumerable<IInvoice>> GetInvoices(IPeriod period, int officeId, int state, string filter)
		{
			WokrsListRepository.<GetInvoices>d__3 <GetInvoices>d__;
			<GetInvoices>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<IInvoice>>.Create();
			<GetInvoices>d__.<>4__this = this;
			<GetInvoices>d__.period = period;
			<GetInvoices>d__.officeId = officeId;
			<GetInvoices>d__.<>1__state = -1;
			<GetInvoices>d__.<>t__builder.Start<WokrsListRepository.<GetInvoices>d__3>(ref <GetInvoices>d__);
			return <GetInvoices>d__.<>t__builder.Task;
		}

		// Token: 0x020002F8 RID: 760
		[CompilerGenerated]
		private sealed class <>c__DisplayClass1_0
		{
			// Token: 0x0600248B RID: 9355 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass1_0()
			{
			}

			// Token: 0x0400134A RID: 4938
			public int sellerId;
		}

		// Token: 0x020002F9 RID: 761
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600248C RID: 9356 RVA: 0x0006E4E4 File Offset: 0x0006C6E4
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600248D RID: 9357 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x0600248E RID: 9358 RVA: 0x0006E4FC File Offset: 0x0006C6FC
			internal IOrderedQueryable<w_lists> <GetInvoices>b__3_2(IQueryable<w_lists> i)
			{
				return from d in i
				orderby d.id descending
				select d;
			}

			// Token: 0x0400134B RID: 4939
			public static readonly WokrsListRepository.<>c <>9 = new WokrsListRepository.<>c();

			// Token: 0x0400134C RID: 4940
			public static Func<IQueryable<w_lists>, IOrderedQueryable<w_lists>> <>9__3_2;
		}

		// Token: 0x020002FA RID: 762
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetLastWokrsListId>d__1 : IAsyncStateMachine
		{
			// Token: 0x0600248F RID: 9359 RVA: 0x0006E548 File Offset: 0x0006C748
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WokrsListRepository wokrsListRepository = this.<>4__this;
				string result2;
				try
				{
					TaskAwaiter<w_lists> awaiter;
					if (num != 0)
					{
						WokrsListRepository.<>c__DisplayClass1_0 CS$<>8__locals1 = new WokrsListRepository.<>c__DisplayClass1_0();
						CS$<>8__locals1.sellerId = this.sellerId;
						awaiter = (from i in wokrsListRepository._context.w_lists.AsNoTracking()
						where i.seller == CS$<>8__locals1.sellerId
						select i into x
						orderby x.id descending
						select x).FirstOrDefaultAsync<w_lists>().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<w_lists>, WokrsListRepository.<GetLastWokrsListId>d__1>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<w_lists>);
						this.<>1__state = -1;
					}
					w_lists result = awaiter.GetResult();
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

			// Token: 0x06002490 RID: 9360 RVA: 0x0006E6EC File Offset: 0x0006C8EC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400134D RID: 4941
			public int <>1__state;

			// Token: 0x0400134E RID: 4942
			public AsyncTaskMethodBuilder<string> <>t__builder;

			// Token: 0x0400134F RID: 4943
			public int sellerId;

			// Token: 0x04001350 RID: 4944
			public WokrsListRepository <>4__this;

			// Token: 0x04001351 RID: 4945
			private TaskAwaiter<w_lists> <>u__1;
		}

		// Token: 0x020002FB RID: 763
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x06002491 RID: 9361 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x04001352 RID: 4946
			public string invoiceNum;
		}

		// Token: 0x020002FC RID: 764
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetWokrsListLookup>d__2 : IAsyncStateMachine
		{
			// Token: 0x06002492 RID: 9362 RVA: 0x0006E708 File Offset: 0x0006C908
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WokrsListRepository wokrsListRepository = this.<>4__this;
				IInvoiceLookup result;
				try
				{
					ConfiguredTaskAwaitable<InvoiceLookup>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						WokrsListRepository.<>c__DisplayClass2_0 CS$<>8__locals1 = new WokrsListRepository.<>c__DisplayClass2_0();
						CS$<>8__locals1.invoiceNum = this.invoiceNum;
						ParameterExpression parameterExpression;
						awaiter = (from i in wokrsListRepository._context.w_lists.AsNoTracking()
						where i.num == CS$<>8__locals1.invoiceNum && i.created.Year == DateTime.Now.Year
						select i).Select(Expression.Lambda<Func<w_lists, InvoiceLookup>>(Expression.MemberInit(Expression.New(typeof(InvoiceLookup)), new MemberBinding[]
						{
							Expression.Bind(methodof(InvoiceLookup.set_Id(int)), Expression.Property(parameterExpression, methodof(w_lists.get_id()))),
							Expression.Bind(methodof(InvoiceLookup.set_Num(string)), Expression.Property(parameterExpression, methodof(w_lists.get_num()))),
							Expression.Bind(methodof(InvoiceLookup.set_Date(DateTime)), Expression.Property(parameterExpression, methodof(w_lists.get_created())))
						}), new ParameterExpression[]
						{
							parameterExpression
						})).FirstOrDefaultAsync<InvoiceLookup>().ConfigureAwait(false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<InvoiceLookup>.ConfiguredTaskAwaiter, WokrsListRepository.<GetWokrsListLookup>d__2>(ref awaiter, ref this);
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

			// Token: 0x06002493 RID: 9363 RVA: 0x0006E98C File Offset: 0x0006CB8C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001353 RID: 4947
			public int <>1__state;

			// Token: 0x04001354 RID: 4948
			public AsyncTaskMethodBuilder<IInvoiceLookup> <>t__builder;

			// Token: 0x04001355 RID: 4949
			public string invoiceNum;

			// Token: 0x04001356 RID: 4950
			public WokrsListRepository <>4__this;

			// Token: 0x04001357 RID: 4951
			private ConfiguredTaskAwaitable<InvoiceLookup>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x020002FD RID: 765
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06002494 RID: 9364 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x04001358 RID: 4952
			public DateTime from;

			// Token: 0x04001359 RID: 4953
			public DateTime to;

			// Token: 0x0400135A RID: 4954
			public int officeId;
		}

		// Token: 0x020002FE RID: 766
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetInvoices>d__3 : IAsyncStateMachine
		{
			// Token: 0x06002495 RID: 9365 RVA: 0x0006E9A8 File Offset: 0x0006CBA8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WokrsListRepository wokrsListRepository = this.<>4__this;
				IEnumerable<IInvoice> result;
				try
				{
					TaskAwaiter<IEnumerable<w_lists>> awaiter;
					if (num != 0)
					{
						WokrsListRepository.<>c__DisplayClass3_0 CS$<>8__locals1 = new WokrsListRepository.<>c__DisplayClass3_0();
						CS$<>8__locals1.officeId = this.officeId;
						CS$<>8__locals1.from = this.period.From.Date;
						CS$<>8__locals1.to = this.period.To.Date.AddDays(1.0).AddSeconds(-1.0);
						List<KeyValuePair<bool, Expression<Func<w_lists, bool>>>> filterList = new List<KeyValuePair<bool, Expression<Func<w_lists, bool>>>>
						{
							new KeyValuePair<bool, Expression<Func<w_lists, bool>>>(true, (w_lists i) => i.created >= CS$<>8__locals1.from && i.created <= CS$<>8__locals1.to),
							new KeyValuePair<bool, Expression<Func<w_lists, bool>>>(CS$<>8__locals1.officeId != 0, (w_lists i) => i.office == CS$<>8__locals1.officeId)
						};
						awaiter = wokrsListRepository.GetAllAsync(filterList, new Func<IQueryable<w_lists>, IOrderedQueryable<w_lists>>(WokrsListRepository.<>c.<>9.<GetInvoices>b__3_2), "users,banks,banks1,invoice1", true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<w_lists>>, WokrsListRepository.<GetInvoices>d__3>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<w_lists>>);
						this.<>1__state = -1;
					}
					result = awaiter.GetResult().Select(new Func<w_lists, WorksList>(WorksListMapper.WorksListConvert)).ToList<WorksList>();
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

			// Token: 0x06002496 RID: 9366 RVA: 0x0006EC64 File Offset: 0x0006CE64
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400135B RID: 4955
			public int <>1__state;

			// Token: 0x0400135C RID: 4956
			public AsyncTaskMethodBuilder<IEnumerable<IInvoice>> <>t__builder;

			// Token: 0x0400135D RID: 4957
			public int officeId;

			// Token: 0x0400135E RID: 4958
			public IPeriod period;

			// Token: 0x0400135F RID: 4959
			public WokrsListRepository <>4__this;

			// Token: 0x04001360 RID: 4960
			private TaskAwaiter<IEnumerable<w_lists>> <>u__1;
		}
	}
}
