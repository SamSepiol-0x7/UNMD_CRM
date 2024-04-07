using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Interfaces;
using ASC.PKO;
using ASC.RKO;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels.CustomerCard
{
	// Token: 0x020004E3 RID: 1251
	public class CustomerFinancesViewModel : CustomerCollectionViewModel<CashOrdersLite>
	{
		// Token: 0x06002FED RID: 12269 RVA: 0x0009DB18 File Offset: 0x0009BD18
		public CustomerFinancesViewModel(ICustomerService customerService, INavigationService navigationService)
		{
			this._customerService = customerService;
			this._navigationService = navigationService;
		}

		// Token: 0x06002FEE RID: 12270 RVA: 0x0009DB3C File Offset: 0x0009BD3C
		protected override void LoadData()
		{
			CustomerFinancesViewModel.<LoadData>d__3 <LoadData>d__;
			<LoadData>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadData>d__.<>4__this = this;
			<LoadData>d__.<>1__state = -1;
			<LoadData>d__.<>t__builder.Start<CustomerFinancesViewModel.<LoadData>d__3>(ref <LoadData>d__);
		}

		// Token: 0x06002FEF RID: 12271 RVA: 0x0009DB74 File Offset: 0x0009BD74
		[Command]
		public void ItemDoubleClick()
		{
			if (base.SelectedItem.summa < 0m)
			{
				this._navigationService.Navigate("RkoView", new RkoViewModel(base.SelectedItem.id));
				return;
			}
			this._navigationService.Navigate("PkoView", new PkoViewModel(base.SelectedItem.id));
		}

		// Token: 0x06002FF0 RID: 12272 RVA: 0x0009DBDC File Offset: 0x0009BDDC
		public bool CanItemDoubleClick()
		{
			return base.SelectedItem != null;
		}

		// Token: 0x06002FF1 RID: 12273 RVA: 0x0009DBF4 File Offset: 0x0009BDF4
		[CompilerGenerated]
		private Task<List<CashOrdersLite>> <LoadData>b__3_0()
		{
			return this._customerService.GetOrders(this.Customer.Id);
		}

		// Token: 0x06002FF2 RID: 12274 RVA: 0x0009DC18 File Offset: 0x0009BE18
		[CompilerGenerated]
		[DebuggerHidden]
		private void <>n__0()
		{
			base.LoadData();
		}

		// Token: 0x04001B31 RID: 6961
		private readonly ICustomerService _customerService;

		// Token: 0x04001B32 RID: 6962
		private readonly INavigationService _navigationService;

		// Token: 0x020004E4 RID: 1252
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadData>d__3 : IAsyncStateMachine
		{
			// Token: 0x06002FF3 RID: 12275 RVA: 0x0009DC2C File Offset: 0x0009BE2C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CustomerFinancesViewModel customerFinancesViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<CashOrdersLite>> awaiter;
					if (num != 0)
					{
						customerFinancesViewModel.<>n__0();
						awaiter = Task.Run<List<CashOrdersLite>>(() => customerFinancesViewModel._customerService.GetOrders(customerFinancesViewModel.Customer.Id)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<CashOrdersLite>>, CustomerFinancesViewModel.<LoadData>d__3>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<CashOrdersLite>>);
						this.<>1__state = -1;
					}
					List<CashOrdersLite> result = awaiter.GetResult();
					customerFinancesViewModel.SetItems(result);
					customerFinancesViewModel.SetIsDataLoading(false);
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

			// Token: 0x06002FF4 RID: 12276 RVA: 0x0009DD00 File Offset: 0x0009BF00
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001B33 RID: 6963
			public int <>1__state;

			// Token: 0x04001B34 RID: 6964
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001B35 RID: 6965
			public CustomerFinancesViewModel <>4__this;

			// Token: 0x04001B36 RID: 6966
			private TaskAwaiter<List<CashOrdersLite>> <>u__1;
		}
	}
}
