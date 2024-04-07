using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Models;
using ASC.Objects;
using NLog;

namespace ASC.RealizatorPay
{
	// Token: 0x0200015E RID: 350
	public class PayModel
	{
		// Token: 0x060016CA RID: 5834 RVA: 0x00039FD8 File Offset: 0x000381D8
		public static Task<IEnumerable<store_sales>> LoadSoldItems(int clientId)
		{
			PayModel.<LoadSoldItems>d__1 <LoadSoldItems>d__;
			<LoadSoldItems>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<store_sales>>.Create();
			<LoadSoldItems>d__.clientId = clientId;
			<LoadSoldItems>d__.<>1__state = -1;
			<LoadSoldItems>d__.<>t__builder.Start<PayModel.<LoadSoldItems>d__1>(ref <LoadSoldItems>d__);
			return <LoadSoldItems>d__.<>t__builder.Task;
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x0003A01C File Offset: 0x0003821C
		public static IAscResult MakePayment(IEnumerable<store_sales> items, int customerId, bool createRko)
		{
			Result result = new Result();
			decimal num = (from i in items
			select i.RealizatorPart).DefaultIfEmpty<decimal>().Sum();
			int num2 = 0;
			IAscResult result2;
			try
			{
				Localization localization = new Localization("UTC");
				HistoryV2 historyV = new HistoryV2();
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					dealer_payments dealer_payments = new dealer_payments
					{
						payment_date = localization.Now,
						user_id = Auth.User.id,
						dealer_id = customerId,
						state = 1,
						summ = num
					};
					auseceEntities.dealer_payments.Add(dealer_payments);
					auseceEntities.SaveChanges();
					num2 = dealer_payments.id;
					historyV.AddClientLog("DealerPayment", customerId, num, 0);
					historyV.Save();
					auseceEntities.Configuration.ValidateOnSaveEnabled = false;
					foreach (store_sales store_sales in items)
					{
						store_sales store_sales2 = new store_sales
						{
							id = store_sales.id
						};
						auseceEntities.store_sales.Attach(store_sales2);
						store_sales2.realizator_payed = true;
						store_sales2.dealer_payment = new int?(num2);
					}
					auseceEntities.SaveChanges();
					KassaModel.SubstractCustomerBalance(customerId, num, Kassa.Balance.SubstractBalance, null, num2);
				}
				if (createRko)
				{
					CashOutOrder cashOutOrder = new CashOutOrder();
					cashOutOrder.SetCompany(OfflineData.Instance.Employee.Office.DefaultCompanyId);
					cashOutOrder.SetOffice(OfflineData.Instance.Employee.OfficeId);
					cashOutOrder.SetEmployee(OfflineData.Instance.Employee.Id);
					cashOutOrder.FillByPaymentToDealer(customerId, num);
					IAscResult ascResult = KassaModel.CreateCashOrder(cashOutOrder, true);
					bool isSucces = ascResult.IsSucces;
					result.Id = ascResult.Id;
				}
				goto IL_1F4;
			}
			catch (Exception ex)
			{
				PayModel.Log.Error(ex, "Error in dealer payment");
				result.Message = ex.Message;
				result2 = result;
			}
			return result2;
			IL_1F4:
			result.SetSuccess();
			return result;
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x0003A270 File Offset: 0x00038470
		public static Task<IEnumerable<store_sales>> LoadExistPayment(int paymentId)
		{
			PayModel.<LoadExistPayment>d__3 <LoadExistPayment>d__;
			<LoadExistPayment>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<store_sales>>.Create();
			<LoadExistPayment>d__.paymentId = paymentId;
			<LoadExistPayment>d__.<>1__state = -1;
			<LoadExistPayment>d__.<>t__builder.Start<PayModel.<LoadExistPayment>d__3>(ref <LoadExistPayment>d__);
			return <LoadExistPayment>d__.<>t__builder.Task;
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x000046B4 File Offset: 0x000028B4
		public PayModel()
		{
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x0003A2B4 File Offset: 0x000384B4
		// Note: this type is marked as 'beforefieldinit'.
		static PayModel()
		{
		}

		// Token: 0x04000B3E RID: 2878
		private static readonly ILogger Log = LogManager.GetCurrentClassLogger();

		// Token: 0x0200015F RID: 351
		[CompilerGenerated]
		private sealed class <>c__DisplayClass1_0
		{
			// Token: 0x060016CF RID: 5839 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass1_0()
			{
			}

			// Token: 0x04000B3F RID: 2879
			public int clientId;
		}

		// Token: 0x02000160 RID: 352
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060016D0 RID: 5840 RVA: 0x0003A2CC File Offset: 0x000384CC
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060016D1 RID: 5841 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x060016D2 RID: 5842 RVA: 0x0003A2E4 File Offset: 0x000384E4
			internal IOrderedQueryable<store_sales> <LoadSoldItems>b__1_1(IQueryable<store_sales> i)
			{
				return from d in i
				orderby d.docs.created descending
				select d;
			}

			// Token: 0x060016D3 RID: 5843 RVA: 0x0003A344 File Offset: 0x00038544
			internal decimal <MakePayment>b__2_0(store_sales i)
			{
				return i.RealizatorPart;
			}

			// Token: 0x04000B40 RID: 2880
			public static readonly PayModel.<>c <>9 = new PayModel.<>c();

			// Token: 0x04000B41 RID: 2881
			public static Func<IQueryable<store_sales>, IOrderedQueryable<store_sales>> <>9__1_1;

			// Token: 0x04000B42 RID: 2882
			public static Func<store_sales, decimal> <>9__2_0;
		}

		// Token: 0x02000161 RID: 353
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadSoldItems>d__1 : IAsyncStateMachine
		{
			// Token: 0x060016D4 RID: 5844 RVA: 0x0003A358 File Offset: 0x00038558
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IEnumerable<store_sales> result;
				try
				{
					PayModel.<>c__DisplayClass1_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new PayModel.<>c__DisplayClass1_0();
						CS$<>8__locals1.clientId = this.clientId;
						this.<repo>5__2 = new GenericRepository<store_sales>();
					}
					try
					{
						TaskAwaiter<IEnumerable<store_sales>> awaiter;
						if (num != 0)
						{
							awaiter = this.<repo>5__2.GetAllAsync((store_sales i) => i.docs.state == (int?)5 && i.dealer == CS$<>8__locals1.clientId && i.is_realization && i.realizator_payed == false, new Func<IQueryable<store_sales>, IOrderedQueryable<store_sales>>(PayModel.<>c.<>9.<LoadSoldItems>b__1_1), "docs,store_items").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<store_sales>>, PayModel.<LoadSoldItems>d__1>(ref awaiter, ref this);
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

			// Token: 0x060016D5 RID: 5845 RVA: 0x0003A598 File Offset: 0x00038798
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000B43 RID: 2883
			public int <>1__state;

			// Token: 0x04000B44 RID: 2884
			public AsyncTaskMethodBuilder<IEnumerable<store_sales>> <>t__builder;

			// Token: 0x04000B45 RID: 2885
			public int clientId;

			// Token: 0x04000B46 RID: 2886
			private GenericRepository<store_sales> <repo>5__2;

			// Token: 0x04000B47 RID: 2887
			private TaskAwaiter<IEnumerable<store_sales>> <>u__1;
		}

		// Token: 0x02000162 RID: 354
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x060016D6 RID: 5846 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x04000B48 RID: 2888
			public int paymentId;
		}

		// Token: 0x02000163 RID: 355
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadExistPayment>d__3 : IAsyncStateMachine
		{
			// Token: 0x060016D7 RID: 5847 RVA: 0x0003A5B4 File Offset: 0x000387B4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IEnumerable<store_sales> result;
				try
				{
					PayModel.<>c__DisplayClass3_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new PayModel.<>c__DisplayClass3_0();
						CS$<>8__locals1.paymentId = this.paymentId;
						this.<repo>5__2 = new GenericRepository<store_sales>();
					}
					try
					{
						TaskAwaiter<IEnumerable<store_sales>> awaiter;
						if (num != 0)
						{
							awaiter = this.<repo>5__2.GetAllAsync((store_sales i) => i.dealer_payment == (int?)CS$<>8__locals1.paymentId, null, "store_items").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<store_sales>>, PayModel.<LoadExistPayment>d__3>(ref awaiter, ref this);
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

			// Token: 0x060016D8 RID: 5848 RVA: 0x0003A740 File Offset: 0x00038940
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000B49 RID: 2889
			public int <>1__state;

			// Token: 0x04000B4A RID: 2890
			public AsyncTaskMethodBuilder<IEnumerable<store_sales>> <>t__builder;

			// Token: 0x04000B4B RID: 2891
			public int paymentId;

			// Token: 0x04000B4C RID: 2892
			private GenericRepository<store_sales> <repo>5__2;

			// Token: 0x04000B4D RID: 2893
			private TaskAwaiter<IEnumerable<store_sales>> <>u__1;
		}
	}
}
