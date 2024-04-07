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
using ASC.Objects.Converters;

namespace ASC.Persistence.Repositories
{
	// Token: 0x020002E2 RID: 738
	public class PaymentDetailRepository : GenericRepository<banks>, IPaymentDetailRepository
	{
		// Token: 0x0600245D RID: 9309 RVA: 0x0006CE44 File Offset: 0x0006B044
		public PaymentDetailRepository(auseceEntities context) : base(context)
		{
		}

		// Token: 0x0600245E RID: 9310 RVA: 0x0006CE58 File Offset: 0x0006B058
		public Task<IEnumerable<IPaymentDetailLookup>> GetSellerBanksLookup()
		{
			PaymentDetailRepository.<GetSellerBanksLookup>d__1 <GetSellerBanksLookup>d__;
			<GetSellerBanksLookup>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<IPaymentDetailLookup>>.Create();
			<GetSellerBanksLookup>d__.<>4__this = this;
			<GetSellerBanksLookup>d__.<>1__state = -1;
			<GetSellerBanksLookup>d__.<>t__builder.Start<PaymentDetailRepository.<GetSellerBanksLookup>d__1>(ref <GetSellerBanksLookup>d__);
			return <GetSellerBanksLookup>d__.<>t__builder.Task;
		}

		// Token: 0x0600245F RID: 9311 RVA: 0x0006CE9C File Offset: 0x0006B09C
		public Task<IPaymentDetails> GetPaymentDetails(int detailsId)
		{
			PaymentDetailRepository.<GetPaymentDetails>d__2 <GetPaymentDetails>d__;
			<GetPaymentDetails>d__.<>t__builder = AsyncTaskMethodBuilder<IPaymentDetails>.Create();
			<GetPaymentDetails>d__.<>4__this = this;
			<GetPaymentDetails>d__.detailsId = detailsId;
			<GetPaymentDetails>d__.<>1__state = -1;
			<GetPaymentDetails>d__.<>t__builder.Start<PaymentDetailRepository.<GetPaymentDetails>d__2>(ref <GetPaymentDetails>d__);
			return <GetPaymentDetails>d__.<>t__builder.Task;
		}

		// Token: 0x020002E3 RID: 739
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002460 RID: 9312 RVA: 0x0006CEE8 File Offset: 0x0006B0E8
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06002461 RID: 9313 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x04001311 RID: 4881
			public static readonly PaymentDetailRepository.<>c <>9 = new PaymentDetailRepository.<>c();
		}

		// Token: 0x020002E4 RID: 740
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetSellerBanksLookup>d__1 : IAsyncStateMachine
		{
			// Token: 0x06002462 RID: 9314 RVA: 0x0006CF00 File Offset: 0x0006B100
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PaymentDetailRepository paymentDetailRepository = this.<>4__this;
				IEnumerable<IPaymentDetailLookup> result;
				try
				{
					TaskAwaiter<List<PaymentDetailLookup>> awaiter;
					if (num != 0)
					{
						ParameterExpression parameterExpression;
						awaiter = (from c in paymentDetailRepository._context.banks.AsNoTracking()
						where c.company != null
						select c).Select(Expression.Lambda<Func<banks, PaymentDetailLookup>>(Expression.MemberInit(Expression.New(typeof(PaymentDetailLookup)), new MemberBinding[]
						{
							Expression.Bind(methodof(PaymentDetailLookup.set_Id(int)), Expression.Property(parameterExpression, methodof(banks.get_id()))),
							Expression.Bind(methodof(PaymentDetailLookup.set_Name(string)), Expression.Property(parameterExpression, methodof(banks.get_ur_name()))),
							Expression.Bind(methodof(PaymentDetailLookup.set_Bank(string)), Expression.Property(parameterExpression, methodof(banks.get_bank()))),
							Expression.Bind(methodof(PaymentDetailLookup.set_IsArchive(bool)), Expression.Property(parameterExpression, methodof(banks.get_archive())))
						}), new ParameterExpression[]
						{
							parameterExpression
						})).ToListAsync<PaymentDetailLookup>().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<PaymentDetailLookup>>, PaymentDetailRepository.<GetSellerBanksLookup>d__1>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<PaymentDetailLookup>>);
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

			// Token: 0x06002463 RID: 9315 RVA: 0x0006D134 File Offset: 0x0006B334
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001312 RID: 4882
			public int <>1__state;

			// Token: 0x04001313 RID: 4883
			public AsyncTaskMethodBuilder<IEnumerable<IPaymentDetailLookup>> <>t__builder;

			// Token: 0x04001314 RID: 4884
			public PaymentDetailRepository <>4__this;

			// Token: 0x04001315 RID: 4885
			private TaskAwaiter<List<PaymentDetailLookup>> <>u__1;
		}

		// Token: 0x020002E5 RID: 741
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x06002464 RID: 9316 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x04001316 RID: 4886
			public int detailsId;
		}

		// Token: 0x020002E6 RID: 742
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetPaymentDetails>d__2 : IAsyncStateMachine
		{
			// Token: 0x06002465 RID: 9317 RVA: 0x0006D150 File Offset: 0x0006B350
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PaymentDetailRepository paymentDetailRepository = this.<>4__this;
				IPaymentDetails result;
				try
				{
					TaskAwaiter<banks> awaiter;
					if (num != 0)
					{
						PaymentDetailRepository.<>c__DisplayClass2_0 CS$<>8__locals1 = new PaymentDetailRepository.<>c__DisplayClass2_0();
						CS$<>8__locals1.detailsId = this.detailsId;
						awaiter = paymentDetailRepository._context.banks.SingleAsync((banks b) => b.id == CS$<>8__locals1.detailsId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<banks>, PaymentDetailRepository.<GetPaymentDetails>d__2>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<banks>);
						this.<>1__state = -1;
					}
					result = awaiter.GetResult().BankToSellerPaymentDetails();
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

			// Token: 0x06002466 RID: 9318 RVA: 0x0006D290 File Offset: 0x0006B490
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001317 RID: 4887
			public int <>1__state;

			// Token: 0x04001318 RID: 4888
			public AsyncTaskMethodBuilder<IPaymentDetails> <>t__builder;

			// Token: 0x04001319 RID: 4889
			public int detailsId;

			// Token: 0x0400131A RID: 4890
			public PaymentDetailRepository <>4__this;

			// Token: 0x0400131B RID: 4891
			private TaskAwaiter<banks> <>u__1;
		}
	}
}
