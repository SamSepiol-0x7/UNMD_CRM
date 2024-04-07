using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Objects;
using ASC.Services.Abstract;
using ASC.ViewModel;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels.CustomerCard
{
	// Token: 0x020004D0 RID: 1232
	public class CustomerPaymentDetailsViewModel : CollectionViewModel<IPaymentDetails>
	{
		// Token: 0x17000EE3 RID: 3811
		// (get) Token: 0x06002F84 RID: 12164 RVA: 0x0009BC90 File Offset: 0x00099E90
		public string GroupHeader
		{
			[CompilerGenerated]
			get
			{
				return this.<GroupHeader>k__BackingField;
			}
		}

		// Token: 0x17000EE4 RID: 3812
		// (get) Token: 0x06002F85 RID: 12165 RVA: 0x0009BCA4 File Offset: 0x00099EA4
		public string ListHeader
		{
			[CompilerGenerated]
			get
			{
				return this.<ListHeader>k__BackingField;
			}
		}

		// Token: 0x06002F86 RID: 12166 RVA: 0x0009BCB8 File Offset: 0x00099EB8
		public CustomerPaymentDetailsViewModel(ICustomerService customerService, IWindowedDocumentService windowedDocumentService)
		{
			this._customerService = customerService;
			this._windowedDocumentService = windowedDocumentService;
			this.GroupHeader = Lang.t("BankDetails");
			this.ListHeader = Lang.t("BanksList");
		}

		// Token: 0x06002F87 RID: 12167 RVA: 0x0009BCFC File Offset: 0x00099EFC
		private Task LoadData(int customerId)
		{
			CustomerPaymentDetailsViewModel.<LoadData>d__9 <LoadData>d__;
			<LoadData>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadData>d__.<>4__this = this;
			<LoadData>d__.customerId = customerId;
			<LoadData>d__.<>1__state = -1;
			<LoadData>d__.<>t__builder.Start<CustomerPaymentDetailsViewModel.<LoadData>d__9>(ref <LoadData>d__);
			return <LoadData>d__.<>t__builder.Task;
		}

		// Token: 0x06002F88 RID: 12168 RVA: 0x0009BD48 File Offset: 0x00099F48
		protected override void OnParameterChanged(object prm)
		{
			CustomerPaymentDetailsViewModel.<OnParameterChanged>d__10 <OnParameterChanged>d__;
			<OnParameterChanged>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnParameterChanged>d__.<>4__this = this;
			<OnParameterChanged>d__.prm = prm;
			<OnParameterChanged>d__.<>1__state = -1;
			<OnParameterChanged>d__.<>t__builder.Start<CustomerPaymentDetailsViewModel.<OnParameterChanged>d__10>(ref <OnParameterChanged>d__);
		}

		// Token: 0x06002F89 RID: 12169 RVA: 0x0009BD88 File Offset: 0x00099F88
		[Command]
		public void ItemMouseDoubleClick()
		{
			this._windowedDocumentService.ShowNewDocument("PaymentDetailsView", new PaymentDetailsViewModel(base.SelectedItem), null, null);
		}

		// Token: 0x06002F8A RID: 12170 RVA: 0x0009BDB4 File Offset: 0x00099FB4
		public bool CanItemMouseDoubleClick()
		{
			return base.SelectedItem != null;
		}

		// Token: 0x04001AD7 RID: 6871
		private readonly ICustomerService _customerService;

		// Token: 0x04001AD8 RID: 6872
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04001AD9 RID: 6873
		[CompilerGenerated]
		private readonly string <GroupHeader>k__BackingField;

		// Token: 0x04001ADA RID: 6874
		[CompilerGenerated]
		private readonly string <ListHeader>k__BackingField;

		// Token: 0x020004D1 RID: 1233
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadData>d__9 : IAsyncStateMachine
		{
			// Token: 0x06002F8B RID: 12171 RVA: 0x0009BDCC File Offset: 0x00099FCC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CustomerPaymentDetailsViewModel customerPaymentDetailsViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<PaymentDetails>> awaiter;
					if (num != 0)
					{
						awaiter = customerPaymentDetailsViewModel._customerService.GetPaymentDetailsAsync(this.customerId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<PaymentDetails>>, CustomerPaymentDetailsViewModel.<LoadData>d__9>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<PaymentDetails>>);
						this.<>1__state = -1;
					}
					IEnumerable<PaymentDetails> result = awaiter.GetResult();
					customerPaymentDetailsViewModel.SetItems(result);
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

			// Token: 0x06002F8C RID: 12172 RVA: 0x0009BE94 File Offset: 0x0009A094
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001ADB RID: 6875
			public int <>1__state;

			// Token: 0x04001ADC RID: 6876
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001ADD RID: 6877
			public CustomerPaymentDetailsViewModel <>4__this;

			// Token: 0x04001ADE RID: 6878
			public int customerId;

			// Token: 0x04001ADF RID: 6879
			private TaskAwaiter<IEnumerable<PaymentDetails>> <>u__1;
		}

		// Token: 0x020004D2 RID: 1234
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnParameterChanged>d__10 : IAsyncStateMachine
		{
			// Token: 0x06002F8D RID: 12173 RVA: 0x0009BEB0 File Offset: 0x0009A0B0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CustomerPaymentDetailsViewModel customerPaymentDetailsViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (!(this.prm is int))
						{
							goto IL_87;
						}
						int num2 = (int)this.prm;
						if (num2 <= 0)
						{
							goto IL_87;
						}
						awaiter = customerPaymentDetailsViewModel.LoadData(num2).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, CustomerPaymentDetailsViewModel.<OnParameterChanged>d__10>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
					}
					awaiter.GetResult();
					IL_87:;
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

			// Token: 0x06002F8E RID: 12174 RVA: 0x0009BF84 File Offset: 0x0009A184
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001AE0 RID: 6880
			public int <>1__state;

			// Token: 0x04001AE1 RID: 6881
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001AE2 RID: 6882
			public object prm;

			// Token: 0x04001AE3 RID: 6883
			public CustomerPaymentDetailsViewModel <>4__this;

			// Token: 0x04001AE4 RID: 6884
			private TaskAwaiter <>u__1;
		}
	}
}
