using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Interfaces;

namespace ASC.ViewModels.CustomerCard
{
	// Token: 0x020004E5 RID: 1253
	public class CustomerHistoryViewModel : CustomerCollectionViewModel<logs>
	{
		// Token: 0x06002FF5 RID: 12277 RVA: 0x0009DD1C File Offset: 0x0009BF1C
		public CustomerHistoryViewModel(ICustomerService customerService)
		{
			this._customerService = customerService;
		}

		// Token: 0x06002FF6 RID: 12278 RVA: 0x0009DD38 File Offset: 0x0009BF38
		protected override void LoadData()
		{
			CustomerHistoryViewModel.<LoadData>d__2 <LoadData>d__;
			<LoadData>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadData>d__.<>4__this = this;
			<LoadData>d__.<>1__state = -1;
			<LoadData>d__.<>t__builder.Start<CustomerHistoryViewModel.<LoadData>d__2>(ref <LoadData>d__);
		}

		// Token: 0x06002FF7 RID: 12279 RVA: 0x0009DD70 File Offset: 0x0009BF70
		[CompilerGenerated]
		private Task<IEnumerable<logs>> <LoadData>b__2_0()
		{
			return this._customerService.GetHistory(this.Customer.Id, base.Period);
		}

		// Token: 0x06002FF8 RID: 12280 RVA: 0x0009DD9C File Offset: 0x0009BF9C
		[CompilerGenerated]
		[DebuggerHidden]
		private void <>n__0()
		{
			base.LoadData();
		}

		// Token: 0x04001B37 RID: 6967
		private readonly ICustomerService _customerService;

		// Token: 0x020004E6 RID: 1254
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadData>d__2 : IAsyncStateMachine
		{
			// Token: 0x06002FF9 RID: 12281 RVA: 0x0009DDB0 File Offset: 0x0009BFB0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CustomerHistoryViewModel customerHistoryViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<logs>> awaiter;
					if (num != 0)
					{
						customerHistoryViewModel.<>n__0();
						awaiter = Task.Run<IEnumerable<logs>>(() => customerHistoryViewModel._customerService.GetHistory(customerHistoryViewModel.Customer.Id, base.Period)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<logs>>, CustomerHistoryViewModel.<LoadData>d__2>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<logs>>);
						this.<>1__state = -1;
					}
					IEnumerable<logs> result = awaiter.GetResult();
					customerHistoryViewModel.SetItems(result);
					customerHistoryViewModel.SetIsDataLoading(false);
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

			// Token: 0x06002FFA RID: 12282 RVA: 0x0009DE84 File Offset: 0x0009C084
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001B38 RID: 6968
			public int <>1__state;

			// Token: 0x04001B39 RID: 6969
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001B3A RID: 6970
			public CustomerHistoryViewModel <>4__this;

			// Token: 0x04001B3B RID: 6971
			private TaskAwaiter<IEnumerable<logs>> <>u__1;
		}
	}
}
