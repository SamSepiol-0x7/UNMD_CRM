using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Interfaces;
using ASC.ItemsSale;
using ASC.Services.Abstract;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels.CustomerCard
{
	// Token: 0x020004E9 RID: 1257
	public class CustomerPurchasesViewModel : CustomerCollectionViewModel<store_sales>
	{
		// Token: 0x06003003 RID: 12291 RVA: 0x0009E068 File Offset: 0x0009C268
		public CustomerPurchasesViewModel(ICustomerService customerService, INavigationService navigationService)
		{
			this._customerService = customerService;
			this._navigationService = navigationService;
		}

		// Token: 0x06003004 RID: 12292 RVA: 0x0009E08C File Offset: 0x0009C28C
		protected override void LoadData()
		{
			CustomerPurchasesViewModel.<LoadData>d__3 <LoadData>d__;
			<LoadData>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadData>d__.<>4__this = this;
			<LoadData>d__.<>1__state = -1;
			<LoadData>d__.<>t__builder.Start<CustomerPurchasesViewModel.<LoadData>d__3>(ref <LoadData>d__);
		}

		// Token: 0x06003005 RID: 12293 RVA: 0x0009E0C4 File Offset: 0x0009C2C4
		[Command]
		public void PurchaseDoubleClick()
		{
			this._navigationService.Navigate("ItemsSaleView", new ItemsSaleViewModel(base.SelectedItem.document_id));
		}

		// Token: 0x06003006 RID: 12294 RVA: 0x0009E0F4 File Offset: 0x0009C2F4
		public bool CanPurchaseDoubleClick()
		{
			return base.SelectedItem != null;
		}

		// Token: 0x06003007 RID: 12295 RVA: 0x0009E10C File Offset: 0x0009C30C
		[CompilerGenerated]
		private Task<IEnumerable<store_sales>> <LoadData>b__3_0()
		{
			return this._customerService.GetPurchases(this.Customer.Id);
		}

		// Token: 0x06003008 RID: 12296 RVA: 0x0009E130 File Offset: 0x0009C330
		[CompilerGenerated]
		[DebuggerHidden]
		private void <>n__0()
		{
			base.LoadData();
		}

		// Token: 0x04001B42 RID: 6978
		private readonly ICustomerService _customerService;

		// Token: 0x04001B43 RID: 6979
		private readonly INavigationService _navigationService;

		// Token: 0x020004EA RID: 1258
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadData>d__3 : IAsyncStateMachine
		{
			// Token: 0x06003009 RID: 12297 RVA: 0x0009E144 File Offset: 0x0009C344
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CustomerPurchasesViewModel customerPurchasesViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<store_sales>> awaiter;
					if (num != 0)
					{
						customerPurchasesViewModel.<>n__0();
						awaiter = Task.Run<IEnumerable<store_sales>>(() => customerPurchasesViewModel._customerService.GetPurchases(customerPurchasesViewModel.Customer.Id)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<store_sales>>, CustomerPurchasesViewModel.<LoadData>d__3>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<store_sales>>);
						this.<>1__state = -1;
					}
					IEnumerable<store_sales> result = awaiter.GetResult();
					customerPurchasesViewModel.SetItems(result);
					customerPurchasesViewModel.SetIsDataLoading(false);
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

			// Token: 0x0600300A RID: 12298 RVA: 0x0009E218 File Offset: 0x0009C418
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001B44 RID: 6980
			public int <>1__state;

			// Token: 0x04001B45 RID: 6981
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001B46 RID: 6982
			public CustomerPurchasesViewModel <>4__this;

			// Token: 0x04001B47 RID: 6983
			private TaskAwaiter<IEnumerable<store_sales>> <>u__1;
		}
	}
}
