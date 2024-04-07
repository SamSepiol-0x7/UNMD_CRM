using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Interfaces;
using ASC.Objects;
using ASC.Services.Abstract;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels.CustomerCard
{
	// Token: 0x020004E7 RID: 1255
	public class CustomerInvoicesViewModel : CustomerCollectionViewModel<Invoice>
	{
		// Token: 0x06002FFB RID: 12283 RVA: 0x0009DEA0 File Offset: 0x0009C0A0
		public CustomerInvoicesViewModel(ICustomerService customerService, INavigationService navigationService)
		{
			this._customerService = customerService;
			this._navigationService = navigationService;
		}

		// Token: 0x06002FFC RID: 12284 RVA: 0x0009DEC4 File Offset: 0x0009C0C4
		protected override void LoadData()
		{
			CustomerInvoicesViewModel.<LoadData>d__3 <LoadData>d__;
			<LoadData>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadData>d__.<>4__this = this;
			<LoadData>d__.<>1__state = -1;
			<LoadData>d__.<>t__builder.Start<CustomerInvoicesViewModel.<LoadData>d__3>(ref <LoadData>d__);
		}

		// Token: 0x06002FFD RID: 12285 RVA: 0x0009DEFC File Offset: 0x0009C0FC
		[Command]
		public void InvoiceDoubleClick()
		{
			this._navigationService.NavigateInvoice(base.SelectedItem.Id);
		}

		// Token: 0x06002FFE RID: 12286 RVA: 0x0009DF20 File Offset: 0x0009C120
		public bool CanInvoiceDoubleClick()
		{
			return base.SelectedItem != null;
		}

		// Token: 0x06002FFF RID: 12287 RVA: 0x0009DF38 File Offset: 0x0009C138
		[CompilerGenerated]
		private Task<IEnumerable<Invoice>> <LoadData>b__3_0()
		{
			return this._customerService.GetInvoices(this.Customer.Id, base.Period);
		}

		// Token: 0x06003000 RID: 12288 RVA: 0x0009DF64 File Offset: 0x0009C164
		[CompilerGenerated]
		[DebuggerHidden]
		private void <>n__0()
		{
			base.LoadData();
		}

		// Token: 0x04001B3C RID: 6972
		private readonly ICustomerService _customerService;

		// Token: 0x04001B3D RID: 6973
		private readonly INavigationService _navigationService;

		// Token: 0x020004E8 RID: 1256
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadData>d__3 : IAsyncStateMachine
		{
			// Token: 0x06003001 RID: 12289 RVA: 0x0009DF78 File Offset: 0x0009C178
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CustomerInvoicesViewModel customerInvoicesViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<Invoice>> awaiter;
					if (num != 0)
					{
						customerInvoicesViewModel.<>n__0();
						awaiter = Task.Run<IEnumerable<Invoice>>(() => customerInvoicesViewModel._customerService.GetInvoices(customerInvoicesViewModel.Customer.Id, base.Period)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<Invoice>>, CustomerInvoicesViewModel.<LoadData>d__3>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<Invoice>>);
						this.<>1__state = -1;
					}
					IEnumerable<Invoice> result = awaiter.GetResult();
					customerInvoicesViewModel.SetItems(result);
					customerInvoicesViewModel.SetIsDataLoading(false);
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

			// Token: 0x06003002 RID: 12290 RVA: 0x0009E04C File Offset: 0x0009C24C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001B3E RID: 6974
			public int <>1__state;

			// Token: 0x04001B3F RID: 6975
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001B40 RID: 6976
			public CustomerInvoicesViewModel <>4__this;

			// Token: 0x04001B41 RID: 6977
			private TaskAwaiter<IEnumerable<Invoice>> <>u__1;
		}
	}
}
