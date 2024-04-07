using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Common.Repositories;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Services.Abstract;
using ASC.ViewModels;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModel
{
	// Token: 0x020002A9 RID: 681
	public class PaymentDetailsViewModel : PopupViewModel
	{
		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x060022FD RID: 8957 RVA: 0x00066D40 File Offset: 0x00064F40
		// (set) Token: 0x060022FE RID: 8958 RVA: 0x00066D54 File Offset: 0x00064F54
		public IPaymentDetails Details
		{
			[CompilerGenerated]
			get
			{
				return this.<Details>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Details>k__BackingField, value))
				{
					return;
				}
				this.<Details>k__BackingField = value;
				this.RaisePropertyChanged("Details");
			}
		}

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x060022FF RID: 8959 RVA: 0x00066D84 File Offset: 0x00064F84
		// (set) Token: 0x06002300 RID: 8960 RVA: 0x00066D98 File Offset: 0x00064F98
		public bool CanArchive
		{
			[CompilerGenerated]
			get
			{
				return this.<CanArchive>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<CanArchive>k__BackingField == value)
				{
					return;
				}
				this.<CanArchive>k__BackingField = value;
				this.RaisePropertyChanged("CanArchive");
			}
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x00066DC4 File Offset: 0x00064FC4
		private void IoC()
		{
			this._paymentDetailRepository = Bootstrapper.Container.Resolve<IPaymentDetailRepository>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
		}

		// Token: 0x06002302 RID: 8962 RVA: 0x00066DF4 File Offset: 0x00064FF4
		public PaymentDetailsViewModel()
		{
			this.IoC();
			this.Details = new SellerPaymentDetails
			{
				Type = 1
			};
		}

		// Token: 0x06002303 RID: 8963 RVA: 0x00066E20 File Offset: 0x00065020
		public PaymentDetailsViewModel(int customerId)
		{
			this.IoC();
			this.Details = new PaymentDetails
			{
				CustomerId = customerId
			};
		}

		// Token: 0x06002304 RID: 8964 RVA: 0x00066E4C File Offset: 0x0006504C
		public PaymentDetailsViewModel(ICustomer customer)
		{
			this.IoC();
			this.Details = new PaymentDetails
			{
				CustomerId = customer.Id
			};
		}

		// Token: 0x06002305 RID: 8965 RVA: 0x00066E7C File Offset: 0x0006507C
		public PaymentDetailsViewModel(IPaymentDetails details)
		{
			this.IoC();
			this.Details = details;
		}

		// Token: 0x06002306 RID: 8966 RVA: 0x00066E9C File Offset: 0x0006509C
		public PaymentDetailsViewModel(IPaymentDetailLookup details)
		{
			this.IoC();
			this.LoadItem(details.Id);
		}

		// Token: 0x06002307 RID: 8967 RVA: 0x00066EC4 File Offset: 0x000650C4
		private void LoadItem(int detailsId)
		{
			PaymentDetailsViewModel.<LoadItem>d__17 <LoadItem>d__;
			<LoadItem>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadItem>d__.<>4__this = this;
			<LoadItem>d__.detailsId = detailsId;
			<LoadItem>d__.<>1__state = -1;
			<LoadItem>d__.<>t__builder.Start<PaymentDetailsViewModel.<LoadItem>d__17>(ref <LoadItem>d__);
		}

		// Token: 0x06002308 RID: 8968 RVA: 0x00066F04 File Offset: 0x00065104
		private void SetArchiveVisible()
		{
			this.CanArchive = (this.Details.Type == 1);
		}

		// Token: 0x06002309 RID: 8969 RVA: 0x00066F28 File Offset: 0x00065128
		protected override void OnParentViewModelChanged(object parentViewModel)
		{
			this._parentViewModel = (parentViewModel as IRefreshable);
		}

		// Token: 0x0600230A RID: 8970 RVA: 0x00066F44 File Offset: 0x00065144
		[AsyncCommand]
		public Task Save()
		{
			PaymentDetailsViewModel.<Save>d__20 <Save>d__;
			<Save>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Save>d__.<>4__this = this;
			<Save>d__.<>1__state = -1;
			<Save>d__.<>t__builder.Start<PaymentDetailsViewModel.<Save>d__20>(ref <Save>d__);
			return <Save>d__.<>t__builder.Task;
		}

		// Token: 0x0600230B RID: 8971 RVA: 0x00066F88 File Offset: 0x00065188
		public bool CanSave()
		{
			return this.Details != null;
		}

		// Token: 0x0600230C RID: 8972 RVA: 0x00066FA0 File Offset: 0x000651A0
		private Task Update()
		{
			PaymentDetailsViewModel.<Update>d__22 <Update>d__;
			<Update>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Update>d__.<>4__this = this;
			<Update>d__.<>1__state = -1;
			<Update>d__.<>t__builder.Start<PaymentDetailsViewModel.<Update>d__22>(ref <Update>d__);
			return <Update>d__.<>t__builder.Task;
		}

		// Token: 0x0600230D RID: 8973 RVA: 0x00066FE4 File Offset: 0x000651E4
		private Task Create()
		{
			PaymentDetailsViewModel.<Create>d__23 <Create>d__;
			<Create>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Create>d__.<>4__this = this;
			<Create>d__.<>1__state = -1;
			<Create>d__.<>t__builder.Start<PaymentDetailsViewModel.<Create>d__23>(ref <Create>d__);
			return <Create>d__.<>t__builder.Task;
		}

		// Token: 0x0600230E RID: 8974 RVA: 0x00067028 File Offset: 0x00065228
		private bool CheckFields()
		{
			if (string.IsNullOrEmpty(this.Details.Name))
			{
				this._toasterService.Info(Lang.t("InputCompany"));
				return false;
			}
			if (string.IsNullOrEmpty(this.Details.Address))
			{
				this._toasterService.Info(Lang.t("InputAddress"));
				return false;
			}
			if (this.Details.Type == 1)
			{
				if (this.Details.CompanyId <= 0)
				{
					this._toasterService.Info(Lang.t("SelectCompany"));
					return false;
				}
			}
			return true;
		}

		// Token: 0x0400121A RID: 4634
		private IRefreshable _parentViewModel;

		// Token: 0x0400121B RID: 4635
		private IPaymentDetailRepository _paymentDetailRepository;

		// Token: 0x0400121C RID: 4636
		private IToasterService _toasterService;

		// Token: 0x0400121D RID: 4637
		[CompilerGenerated]
		private IPaymentDetails <Details>k__BackingField;

		// Token: 0x0400121E RID: 4638
		[CompilerGenerated]
		private bool <CanArchive>k__BackingField;

		// Token: 0x020002AA RID: 682
		[CompilerGenerated]
		private sealed class <>c__DisplayClass17_0
		{
			// Token: 0x0600230F RID: 8975 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass17_0()
			{
			}

			// Token: 0x06002310 RID: 8976 RVA: 0x000670C0 File Offset: 0x000652C0
			internal Task<IPaymentDetails> <LoadItem>b__0()
			{
				return this.<>4__this._paymentDetailRepository.GetPaymentDetails(this.detailsId);
			}

			// Token: 0x0400121F RID: 4639
			public PaymentDetailsViewModel <>4__this;

			// Token: 0x04001220 RID: 4640
			public int detailsId;
		}

		// Token: 0x020002AB RID: 683
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadItem>d__17 : IAsyncStateMachine
		{
			// Token: 0x06002311 RID: 8977 RVA: 0x000670E4 File Offset: 0x000652E4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PaymentDetailsViewModel paymentDetailsViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IPaymentDetails> awaiter;
					if (num != 0)
					{
						PaymentDetailsViewModel.<>c__DisplayClass17_0 CS$<>8__locals1 = new PaymentDetailsViewModel.<>c__DisplayClass17_0();
						CS$<>8__locals1.<>4__this = this.<>4__this;
						CS$<>8__locals1.detailsId = this.detailsId;
						paymentDetailsViewModel.ShowWait();
						awaiter = Task.Run<IPaymentDetails>(new Func<Task<IPaymentDetails>>(CS$<>8__locals1.<LoadItem>b__0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IPaymentDetails>, PaymentDetailsViewModel.<LoadItem>d__17>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IPaymentDetails>);
						this.<>1__state = -1;
					}
					IPaymentDetails result = awaiter.GetResult();
					paymentDetailsViewModel.Details = result;
					paymentDetailsViewModel.SetArchiveVisible();
					paymentDetailsViewModel.HideWait();
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

			// Token: 0x06002312 RID: 8978 RVA: 0x000671DC File Offset: 0x000653DC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001221 RID: 4641
			public int <>1__state;

			// Token: 0x04001222 RID: 4642
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001223 RID: 4643
			public PaymentDetailsViewModel <>4__this;

			// Token: 0x04001224 RID: 4644
			public int detailsId;

			// Token: 0x04001225 RID: 4645
			private TaskAwaiter<IPaymentDetails> <>u__1;
		}

		// Token: 0x020002AC RID: 684
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Save>d__20 : IAsyncStateMachine
		{
			// Token: 0x06002313 RID: 8979 RVA: 0x000671F8 File Offset: 0x000653F8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PaymentDetailsViewModel paymentDetailsViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (num != 1)
						{
							if (!paymentDetailsViewModel.CheckFields())
							{
								goto IL_109;
							}
							paymentDetailsViewModel.ShowWait();
							if (paymentDetailsViewModel.Details.Id != 0)
							{
								awaiter = paymentDetailsViewModel.Update().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									this.<>1__state = 1;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, PaymentDetailsViewModel.<Save>d__20>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = paymentDetailsViewModel.Create().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									this.<>1__state = 0;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, PaymentDetailsViewModel.<Save>d__20>(ref awaiter, ref this);
									return;
								}
								goto IL_E9;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							this.<>1__state = -1;
						}
						awaiter.GetResult();
						goto IL_F0;
					}
					awaiter = this.<>u__1;
					this.<>u__1 = default(TaskAwaiter);
					this.<>1__state = -1;
					IL_E9:
					awaiter.GetResult();
					IL_F0:;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_109:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002314 RID: 8980 RVA: 0x00067334 File Offset: 0x00065534
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001226 RID: 4646
			public int <>1__state;

			// Token: 0x04001227 RID: 4647
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001228 RID: 4648
			public PaymentDetailsViewModel <>4__this;

			// Token: 0x04001229 RID: 4649
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020002AD RID: 685
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Update>d__22 : IAsyncStateMachine
		{
			// Token: 0x06002315 RID: 8981 RVA: 0x00067350 File Offset: 0x00065550
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PaymentDetailsViewModel paymentDetailsViewModel = this.<>4__this;
				try
				{
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = InvoiceModel.UpdatePaymentDetails(paymentDetailsViewModel.Details).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, PaymentDetailsViewModel.<Update>d__22>(ref awaiter, ref this);
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
					}
					catch (Exception ex)
					{
						paymentDetailsViewModel.HideWait();
						paymentDetailsViewModel._toasterService.Error(ex.Message);
						goto IL_D7;
					}
					paymentDetailsViewModel.HideWait();
					paymentDetailsViewModel.ShowActionResponse(true, Lang.t("PaymentDetailsUpdated"));
					paymentDetailsViewModel.ClosePopup();
					IRefreshable parentViewModel = paymentDetailsViewModel._parentViewModel;
					if (parentViewModel != null)
					{
						parentViewModel.DataRefresh();
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_D7:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002316 RID: 8982 RVA: 0x00067464 File Offset: 0x00065664
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400122A RID: 4650
			public int <>1__state;

			// Token: 0x0400122B RID: 4651
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400122C RID: 4652
			public PaymentDetailsViewModel <>4__this;

			// Token: 0x0400122D RID: 4653
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020002AE RID: 686
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Create>d__23 : IAsyncStateMachine
		{
			// Token: 0x06002317 RID: 8983 RVA: 0x00067480 File Offset: 0x00065680
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PaymentDetailsViewModel paymentDetailsViewModel = this.<>4__this;
				try
				{
					try
					{
						TaskAwaiter<int> awaiter;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<int>);
								this.<>1__state = -1;
							}
							else if (paymentDetailsViewModel.Details.CustomerId > 0)
							{
								awaiter = Bootstrapper.Container.Resolve<ICustomerService>().CreatePaymentDetailsAsync(paymentDetailsViewModel.Details).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									this.<>1__state = 0;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, PaymentDetailsViewModel.<Create>d__23>(ref awaiter, ref this);
									return;
								}
								goto IL_F5;
							}
							else
							{
								awaiter = InvoiceModel.AddPaymentDetails(paymentDetailsViewModel.Details).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									this.<>1__state = 1;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, PaymentDetailsViewModel.<Create>d__23>(ref awaiter, ref this);
									return;
								}
							}
							awaiter.GetResult();
							goto IL_FD;
						}
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<int>);
						this.<>1__state = -1;
						IL_F5:
						awaiter.GetResult();
						IL_FD:;
					}
					catch (Exception ex)
					{
						paymentDetailsViewModel.HideWait();
						paymentDetailsViewModel._toasterService.Error(ex.Message);
						goto IL_15D;
					}
					paymentDetailsViewModel.HideWait();
					paymentDetailsViewModel.ShowActionResponse(true, "");
					paymentDetailsViewModel.ClosePopup();
					IRefreshable parentViewModel = paymentDetailsViewModel._parentViewModel;
					if (parentViewModel != null)
					{
						parentViewModel.DataRefresh();
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_15D:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002318 RID: 8984 RVA: 0x00067634 File Offset: 0x00065834
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400122E RID: 4654
			public int <>1__state;

			// Token: 0x0400122F RID: 4655
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001230 RID: 4656
			public PaymentDetailsViewModel <>4__this;

			// Token: 0x04001231 RID: 4657
			private TaskAwaiter<int> <>u__1;
		}
	}
}
