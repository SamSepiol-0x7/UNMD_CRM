using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Clients;
using ASC.Common.Interfaces;
using ASC.Common.Objects.VoIP;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using ASC.ViewModel;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels
{
	// Token: 0x0200042D RID: 1069
	public class NewCustomerCallViewModel : BaseViewModel, ICustomerSelect
	{
		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x06002AB7 RID: 10935 RVA: 0x00086E08 File Offset: 0x00085008
		// (set) Token: 0x06002AB8 RID: 10936 RVA: 0x00086E1C File Offset: 0x0008501C
		public string Tel
		{
			[CompilerGenerated]
			get
			{
				return this.<Tel>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Tel>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Tel>k__BackingField = value;
				this.RaisePropertyChanged("Tel");
			}
		}

		// Token: 0x06002AB9 RID: 10937 RVA: 0x00086E4C File Offset: 0x0008504C
		public NewCustomerCallViewModel()
		{
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
		}

		// Token: 0x06002ABA RID: 10938 RVA: 0x00086E80 File Offset: 0x00085080
		public NewCustomerCallViewModel(string tel) : this()
		{
			this.Tel = tel;
		}

		// Token: 0x06002ABB RID: 10939 RVA: 0x00086E9C File Offset: 0x0008509C
		[Command]
		public void Create()
		{
			this._windowedDocumentService.CloseActiveDocument();
			AddCustomerViewModel addCustomerViewModel = Bootstrapper.Container.Resolve<AddCustomerViewModel>();
			addCustomerViewModel.AddTelToList(this.Tel);
			this._windowedDocumentService.ShowNewDocument("CustomerCreateView", addCustomerViewModel, null, null);
		}

		// Token: 0x06002ABC RID: 10940 RVA: 0x00086EE0 File Offset: 0x000850E0
		[Command]
		public void AddTelToExistCustomer()
		{
			this._windowedDocumentService.CloseActiveDocument();
			this._navigationService.Navigate("ClientsView", new ClientsViewModel("selectClient"), this);
		}

		// Token: 0x06002ABD RID: 10941 RVA: 0x00086F14 File Offset: 0x00085114
		[Command]
		public void Close()
		{
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x06002ABE RID: 10942 RVA: 0x00086F2C File Offset: 0x0008512C
		public void SelectCustomerFromList(ICustomer customer)
		{
			NewCustomerCallViewModel.<SelectCustomerFromList>d__11 <SelectCustomerFromList>d__;
			<SelectCustomerFromList>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SelectCustomerFromList>d__.<>4__this = this;
			<SelectCustomerFromList>d__.customer = customer;
			<SelectCustomerFromList>d__.<>1__state = -1;
			<SelectCustomerFromList>d__.<>t__builder.Start<NewCustomerCallViewModel.<SelectCustomerFromList>d__11>(ref <SelectCustomerFromList>d__);
		}

		// Token: 0x06002ABF RID: 10943 RVA: 0x00086F6C File Offset: 0x0008516C
		[Command]
		public void Call()
		{
			NewCustomerCallViewModel.<Call>d__12 <Call>d__;
			<Call>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Call>d__.<>4__this = this;
			<Call>d__.<>1__state = -1;
			<Call>d__.<>t__builder.Start<NewCustomerCallViewModel.<Call>d__12>(ref <Call>d__);
		}

		// Token: 0x06002AC0 RID: 10944 RVA: 0x0006A994 File Offset: 0x00068B94
		public bool CnaCall()
		{
			return Core.Instance.CanCall();
		}

		// Token: 0x06002AC1 RID: 10945 RVA: 0x00086FA4 File Offset: 0x000851A4
		[CompilerGenerated]
		private Task<Callback> <Call>b__12_0()
		{
			return Core.Instance.VoIP.Callback(OfflineData.Instance.Employee.Tel.ToString(), this.Tel);
		}

		// Token: 0x040017B2 RID: 6066
		private readonly INavigationService _navigationService;

		// Token: 0x040017B3 RID: 6067
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x040017B4 RID: 6068
		[CompilerGenerated]
		private string <Tel>k__BackingField;

		// Token: 0x0200042E RID: 1070
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SelectCustomerFromList>d__11 : IAsyncStateMachine
		{
			// Token: 0x06002AC2 RID: 10946 RVA: 0x00086FE4 File Offset: 0x000851E4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NewCustomerCallViewModel newCustomerCallViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<CustomerCard> awaiter;
					if (num != 0)
					{
						awaiter = ClientsModel.GetCustomerCard(this.customer.Id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<CustomerCard>, NewCustomerCallViewModel.<SelectCustomerFromList>d__11>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<CustomerCard>);
						this.<>1__state = -1;
					}
					CustomerCard result = awaiter.GetResult();
					Tel tel = new Tel
					{
						Phone = newCustomerCallViewModel.Tel,
						Mask = 1
					};
					result.AddTel(tel);
					newCustomerCallViewModel._navigationService.NavigateToCustomerCard(this.customer.Id, null);
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

			// Token: 0x06002AC3 RID: 10947 RVA: 0x000870DC File Offset: 0x000852DC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040017B5 RID: 6069
			public int <>1__state;

			// Token: 0x040017B6 RID: 6070
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040017B7 RID: 6071
			public ICustomer customer;

			// Token: 0x040017B8 RID: 6072
			public NewCustomerCallViewModel <>4__this;

			// Token: 0x040017B9 RID: 6073
			private TaskAwaiter<CustomerCard> <>u__1;
		}

		// Token: 0x0200042F RID: 1071
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Call>d__12 : IAsyncStateMachine
		{
			// Token: 0x06002AC4 RID: 10948 RVA: 0x000870F8 File Offset: 0x000852F8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NewCustomerCallViewModel newCustomerCallViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<Callback> awaiter;
					if (num != 0)
					{
						newCustomerCallViewModel.ShowWait();
						awaiter = Task.Run<Callback>(() => Core.Instance.VoIP.Callback(OfflineData.Instance.Employee.Tel.ToString(), base.Tel)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Callback>, NewCustomerCallViewModel.<Call>d__12>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<Callback>);
						this.<>1__state = -1;
					}
					awaiter.GetResult();
					newCustomerCallViewModel.HideWait();
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

			// Token: 0x06002AC5 RID: 10949 RVA: 0x000871C4 File Offset: 0x000853C4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040017BA RID: 6074
			public int <>1__state;

			// Token: 0x040017BB RID: 6075
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040017BC RID: 6076
			public NewCustomerCallViewModel <>4__this;

			// Token: 0x040017BD RID: 6077
			private TaskAwaiter<Callback> <>u__1;
		}
	}
}
