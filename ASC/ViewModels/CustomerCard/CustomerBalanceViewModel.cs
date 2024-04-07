using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Interfaces;
using ASC.RealizatorPay;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels.CustomerCard
{
	// Token: 0x020004D8 RID: 1240
	public class CustomerBalanceViewModel : CustomerCollectionViewModel<balance>
	{
		// Token: 0x06002FA5 RID: 12197 RVA: 0x0009C9B0 File Offset: 0x0009ABB0
		public CustomerBalanceViewModel(ICustomerService customerService)
		{
			this._customerService = customerService;
		}

		// Token: 0x06002FA6 RID: 12198 RVA: 0x0009C9CC File Offset: 0x0009ABCC
		[Command]
		public void BalanceDoubleClick()
		{
			if (base.SelectedItem.dealer_payment != null)
			{
				new RealizatorPayView(base.SelectedItem.dealer_payment.Value, true).Show();
			}
		}

		// Token: 0x06002FA7 RID: 12199 RVA: 0x0009CA0C File Offset: 0x0009AC0C
		public bool CanBalanceDoubleClick()
		{
			return base.SelectedItem != null;
		}

		// Token: 0x06002FA8 RID: 12200 RVA: 0x0009CA24 File Offset: 0x0009AC24
		protected override void LoadData()
		{
			CustomerBalanceViewModel.<LoadData>d__4 <LoadData>d__;
			<LoadData>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadData>d__.<>4__this = this;
			<LoadData>d__.<>1__state = -1;
			<LoadData>d__.<>t__builder.Start<CustomerBalanceViewModel.<LoadData>d__4>(ref <LoadData>d__);
		}

		// Token: 0x06002FA9 RID: 12201 RVA: 0x0009CA5C File Offset: 0x0009AC5C
		[CompilerGenerated]
		private Task<IEnumerable<balance>> <LoadData>b__4_0()
		{
			return this._customerService.GetBalanceDetails(this.Customer.Id);
		}

		// Token: 0x06002FAA RID: 12202 RVA: 0x0009CA80 File Offset: 0x0009AC80
		[CompilerGenerated]
		[DebuggerHidden]
		private void <>n__0()
		{
			base.LoadData();
		}

		// Token: 0x04001AFF RID: 6911
		private readonly ICustomerService _customerService;

		// Token: 0x020004D9 RID: 1241
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadData>d__4 : IAsyncStateMachine
		{
			// Token: 0x06002FAB RID: 12203 RVA: 0x0009CA94 File Offset: 0x0009AC94
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CustomerBalanceViewModel customerBalanceViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<balance>> awaiter;
					if (num != 0)
					{
						customerBalanceViewModel.<>n__0();
						awaiter = Task.Run<IEnumerable<balance>>(() => customerBalanceViewModel._customerService.GetBalanceDetails(customerBalanceViewModel.Customer.Id)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<balance>>, CustomerBalanceViewModel.<LoadData>d__4>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<balance>>);
						this.<>1__state = -1;
					}
					IEnumerable<balance> result = awaiter.GetResult();
					customerBalanceViewModel.SetItems(result);
					customerBalanceViewModel.SetIsDataLoading(false);
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

			// Token: 0x06002FAC RID: 12204 RVA: 0x0009CB68 File Offset: 0x0009AD68
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001B00 RID: 6912
			public int <>1__state;

			// Token: 0x04001B01 RID: 6913
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001B02 RID: 6914
			public CustomerBalanceViewModel <>4__this;

			// Token: 0x04001B03 RID: 6915
			private TaskAwaiter<IEnumerable<balance>> <>u__1;
		}
	}
}
