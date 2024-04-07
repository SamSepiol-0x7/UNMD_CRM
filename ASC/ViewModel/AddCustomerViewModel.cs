using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects.Converters;
using ASC.Services.Abstract;
using ASC.ViewModels.CustomerCard;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModel
{
	// Token: 0x020002A3 RID: 675
	public class AddCustomerViewModel : CustomerEditViewModel
	{
		// Token: 0x060022DE RID: 8926 RVA: 0x00066408 File Offset: 0x00064608
		public AddCustomerViewModel(ICustomerService customerService, IStoreService storeService, INavigationService navigationService, IWindowedDocumentService windowedDocumentService, IToasterService toasterService) : base(customerService, storeService, windowedDocumentService, toasterService)
		{
			this._navigationService = navigationService;
			clients c = ClientsModel.DefaultCustomer();
			base.Customer = c.Client2CustomerCard();
		}

		// Token: 0x060022DF RID: 8927 RVA: 0x0006643C File Offset: 0x0006463C
		public void AddTelToList(string tel)
		{
			base.Customer.AddTelToList(tel, 1);
		}

		// Token: 0x060022E0 RID: 8928 RVA: 0x00066458 File Offset: 0x00064658
		[Command]
		public void CreateCustomer()
		{
			AddCustomerViewModel.<CreateCustomer>d__3 <CreateCustomer>d__;
			<CreateCustomer>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<CreateCustomer>d__.<>4__this = this;
			<CreateCustomer>d__.<>1__state = -1;
			<CreateCustomer>d__.<>t__builder.Start<AddCustomerViewModel.<CreateCustomer>d__3>(ref <CreateCustomer>d__);
		}

		// Token: 0x060022E1 RID: 8929 RVA: 0x00066490 File Offset: 0x00064690
		[Command]
		public void CloseCard()
		{
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x060022E2 RID: 8930 RVA: 0x000664A8 File Offset: 0x000646A8
		private bool CheckFieldsEx(ICustomer client)
		{
			if (client.Type == 0 && string.IsNullOrEmpty(client.FirstName))
			{
				this._toasterService.Info(Lang.t("InputClientName"));
				return false;
			}
			if (Auth.Config.is_patronymic_required && client.Type == 0 && string.IsNullOrEmpty(client.Patronymic))
			{
				this._toasterService.Info(Lang.t("InputPatronymic"));
				return false;
			}
			if (client.Type == 1)
			{
				if (string.IsNullOrEmpty(client.UrName))
				{
					this._toasterService.Info(Lang.t("InputUrName"));
					return false;
				}
			}
			return true;
		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x0006654C File Offset: 0x0006474C
		[CompilerGenerated]
		private Task<int> <CreateCustomer>b__3_0()
		{
			return this._customerService.CreateCustomer(base.Customer);
		}

		// Token: 0x04001205 RID: 4613
		private readonly INavigationService _navigationService;

		// Token: 0x020002A4 RID: 676
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateCustomer>d__3 : IAsyncStateMachine
		{
			// Token: 0x060022E4 RID: 8932 RVA: 0x0006656C File Offset: 0x0006476C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AddCustomerViewModel addCustomerViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<int> awaiter;
					if (num != 0)
					{
						if (!addCustomerViewModel.CheckFields(addCustomerViewModel.Customer))
						{
							goto IL_E4;
						}
						if (!addCustomerViewModel.CheckFieldsEx(addCustomerViewModel.Customer))
						{
							goto IL_E4;
						}
						awaiter = Task.Run<int>(() => addCustomerViewModel._customerService.CreateCustomer(base.Customer)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, AddCustomerViewModel.<CreateCustomer>d__3>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<int>);
						this.<>1__state = -1;
					}
					int result = awaiter.GetResult();
					if (result > 0)
					{
						addCustomerViewModel._windowedDocumentService.CloseActiveDocument();
						addCustomerViewModel._navigationService.NavigateToCustomerCard(result, null);
					}
					else
					{
						addCustomerViewModel._toasterService.Error("");
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_E4:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060022E5 RID: 8933 RVA: 0x00066680 File Offset: 0x00064880
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001206 RID: 4614
			public int <>1__state;

			// Token: 0x04001207 RID: 4615
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001208 RID: 4616
			public AddCustomerViewModel <>4__this;

			// Token: 0x04001209 RID: 4617
			private TaskAwaiter<int> <>u__1;
		}
	}
}
