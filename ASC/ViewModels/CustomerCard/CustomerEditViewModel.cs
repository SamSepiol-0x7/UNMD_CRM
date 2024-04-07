using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using ASC.ViewModel;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Xpf.WindowsUI.Navigation;

namespace ASC.ViewModels.CustomerCard
{
	// Token: 0x020004DE RID: 1246
	public class CustomerEditViewModel : BaseViewModel, INavigationAware, IIsDataLoading, IRefreshable
	{
		// Token: 0x17000EEA RID: 3818
		// (get) Token: 0x06002FC3 RID: 12227 RVA: 0x0009D228 File Offset: 0x0009B428
		// (set) Token: 0x06002FC4 RID: 12228 RVA: 0x0009D23C File Offset: 0x0009B43C
		public CustomerCard Customer
		{
			[CompilerGenerated]
			get
			{
				return this.<Customer>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<Customer>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 629178500;
				IL_13:
				switch ((num ^ 1444957603) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					IL_32:
					this.<Customer>k__BackingField = value;
					this.RaisePropertyChanged("Customer");
					num = 1159685413;
					goto IL_13;
				case 3:
					return;
				}
			}
		}

		// Token: 0x17000EEB RID: 3819
		// (get) Token: 0x06002FC5 RID: 12229 RVA: 0x0009D298 File Offset: 0x0009B498
		// (set) Token: 0x06002FC6 RID: 12230 RVA: 0x0009D2AC File Offset: 0x0009B4AC
		public Tel SelectedTel
		{
			get
			{
				return this._selectedTel;
			}
			set
			{
				if (object.Equals(this._selectedTel, value))
				{
					return;
				}
				Tel selectedTel = value;
				if (value == null)
				{
					(selectedTel = new Tel()).Mask = 1;
				}
				this._selectedTel = selectedTel;
				this.RaisePropertyChanged("SelectedTel");
			}
		}

		// Token: 0x17000EEC RID: 3820
		// (get) Token: 0x06002FC7 RID: 12231 RVA: 0x0009D2EC File Offset: 0x0009B4EC
		// (set) Token: 0x06002FC8 RID: 12232 RVA: 0x0009D300 File Offset: 0x0009B500
		public PaymentDetails SelectedPaymentDetails
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedPaymentDetails>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<SelectedPaymentDetails>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1273786347;
				IL_13:
				switch ((num ^ 432197882) % 4)
				{
				case 1:
					return;
				case 2:
					goto IL_0E;
				case 3:
					IL_32:
					this.<SelectedPaymentDetails>k__BackingField = value;
					this.RaisePropertyChanged("SelectedPaymentDetails");
					num = 1776939358;
					goto IL_13;
				}
			}
		}

		// Token: 0x17000EED RID: 3821
		// (get) Token: 0x06002FC9 RID: 12233 RVA: 0x0009D35C File Offset: 0x0009B55C
		// (set) Token: 0x06002FCA RID: 12234 RVA: 0x0009D370 File Offset: 0x0009B570
		public ObservableCollection<IPaymentDetails> PaymentDetails
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentDetails>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(this.<PaymentDetails>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1562208050;
				IL_13:
				switch ((num ^ -566404941) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					return;
				case 3:
					IL_32:
					this.<PaymentDetails>k__BackingField = value;
					this.RaisePropertyChanged("PaymentDetails");
					num = -989283007;
					goto IL_13;
				}
			}
		}

		// Token: 0x17000EEE RID: 3822
		// (get) Token: 0x06002FCB RID: 12235 RVA: 0x0009D3CC File Offset: 0x0009B5CC
		// (set) Token: 0x06002FCC RID: 12236 RVA: 0x0009D3E0 File Offset: 0x0009B5E0
		public Dictionary<int, string> PriceCols
		{
			[CompilerGenerated]
			get
			{
				return this.<PriceCols>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<PriceCols>k__BackingField, value))
				{
					return;
				}
				this.<PriceCols>k__BackingField = value;
				this.RaisePropertyChanged("PriceCols");
			}
		}

		// Token: 0x06002FCD RID: 12237 RVA: 0x0009D410 File Offset: 0x0009B610
		public CustomerEditViewModel(ICustomerService customerService, IStoreService storeService, IWindowedDocumentService windowedDocumentService, IToasterService toasterService)
		{
			this._customerService = customerService;
			this._windowedDocumentService = windowedDocumentService;
			this._toasterService = toasterService;
			this.PriceCols = storeService.GetPriceColumns();
			this.SelectedTel = new Tel
			{
				Mask = 1
			};
		}

		// Token: 0x06002FCE RID: 12238 RVA: 0x0009D458 File Offset: 0x0009B658
		protected virtual void LoadData()
		{
			this.SetIsDataLoading(true);
		}

		// Token: 0x06002FCF RID: 12239 RVA: 0x0009D46C File Offset: 0x0009B66C
		public void NavigatedTo(NavigationEventArgs e)
		{
			CustomerEditViewModel.<NavigatedTo>d__25 <NavigatedTo>d__;
			<NavigatedTo>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<NavigatedTo>d__.<>4__this = this;
			<NavigatedTo>d__.e = e;
			<NavigatedTo>d__.<>1__state = -1;
			<NavigatedTo>d__.<>t__builder.Start<CustomerEditViewModel.<NavigatedTo>d__25>(ref <NavigatedTo>d__);
		}

		// Token: 0x06002FD0 RID: 12240 RVA: 0x0009D4AC File Offset: 0x0009B6AC
		private Task LoadPaymentDetails(int customerId)
		{
			CustomerEditViewModel.<LoadPaymentDetails>d__26 <LoadPaymentDetails>d__;
			<LoadPaymentDetails>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadPaymentDetails>d__.<>4__this = this;
			<LoadPaymentDetails>d__.customerId = customerId;
			<LoadPaymentDetails>d__.<>1__state = -1;
			<LoadPaymentDetails>d__.<>t__builder.Start<CustomerEditViewModel.<LoadPaymentDetails>d__26>(ref <LoadPaymentDetails>d__);
			return <LoadPaymentDetails>d__.<>t__builder.Task;
		}

		// Token: 0x06002FD1 RID: 12241 RVA: 0x00023150 File Offset: 0x00021350
		public void NavigatingFrom(NavigatingEventArgs e)
		{
		}

		// Token: 0x06002FD2 RID: 12242 RVA: 0x00023150 File Offset: 0x00021350
		public void NavigatedFrom(NavigationEventArgs e)
		{
		}

		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x06002FD3 RID: 12243 RVA: 0x0009D4F8 File Offset: 0x0009B6F8
		// (set) Token: 0x06002FD4 RID: 12244 RVA: 0x0009D50C File Offset: 0x0009B70C
		public bool IsLoadingData
		{
			[CompilerGenerated]
			get
			{
				return this.<IsLoadingData>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<IsLoadingData>k__BackingField == value)
				{
					return;
				}
				this.<IsLoadingData>k__BackingField = value;
				this.RaisePropertyChanged("IsLoadingData");
			}
		}

		// Token: 0x06002FD5 RID: 12245 RVA: 0x0009D538 File Offset: 0x0009B738
		public void SetIsDataLoading(bool value)
		{
			this.IsLoadingData = value;
		}

		// Token: 0x06002FD6 RID: 12246 RVA: 0x0009D54C File Offset: 0x0009B74C
		public void SaveCard()
		{
			CustomerEditViewModel.<SaveCard>d__34 <SaveCard>d__;
			<SaveCard>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SaveCard>d__.<>4__this = this;
			<SaveCard>d__.<>1__state = -1;
			<SaveCard>d__.<>t__builder.Start<CustomerEditViewModel.<SaveCard>d__34>(ref <SaveCard>d__);
		}

		// Token: 0x06002FD7 RID: 12247 RVA: 0x0009D584 File Offset: 0x0009B784
		public bool CanSaveCustomerCard()
		{
			return this.Customer != null;
		}

		// Token: 0x06002FD8 RID: 12248 RVA: 0x0009D59C File Offset: 0x0009B79C
		[Command]
		public void TelDoubleCkick()
		{
			this._windowedDocumentService.ShowNewDocument("TelEditView", new TelEditViewModel(this.Customer, this.SelectedTel), null, null);
		}

		// Token: 0x06002FD9 RID: 12249 RVA: 0x0009D5CC File Offset: 0x0009B7CC
		public bool CanTelDoubleCkick()
		{
			return this.SelectedTel != null;
		}

		// Token: 0x06002FDA RID: 12250 RVA: 0x0009D5E4 File Offset: 0x0009B7E4
		[Command]
		public void AddTel()
		{
			this._windowedDocumentService.ShowNewDocument("TelEditView", new TelEditViewModel(this.Customer), null, null);
		}

		// Token: 0x06002FDB RID: 12251 RVA: 0x0009D584 File Offset: 0x0009B784
		public bool CanAddTel()
		{
			return this.Customer != null;
		}

		// Token: 0x06002FDC RID: 12252 RVA: 0x0009D610 File Offset: 0x0009B810
		[Command]
		public void AddPaymentDetails()
		{
			this._windowedDocumentService.ShowNewDocument("PaymentDetailsView", new PaymentDetailsViewModel(this.Customer), this, null);
		}

		// Token: 0x06002FDD RID: 12253 RVA: 0x0004F514 File Offset: 0x0004D714
		public bool CanAddPaymentDetails()
		{
			return OfflineData.Instance.Employee.Can(65, 0);
		}

		// Token: 0x06002FDE RID: 12254 RVA: 0x0009D63C File Offset: 0x0009B83C
		[Command]
		public void PaymentDetailDoubleClick()
		{
			this._windowedDocumentService.ShowNewDocument("PaymentDetailsView", new PaymentDetailsViewModel(this.SelectedPaymentDetails), this, null);
		}

		// Token: 0x06002FDF RID: 12255 RVA: 0x0009D668 File Offset: 0x0009B868
		public bool CanPaymentDetailDoubleClick()
		{
			return this.SelectedPaymentDetails != null && OfflineData.Instance.Employee.Can(65, 0);
		}

		// Token: 0x06002FE0 RID: 12256 RVA: 0x0009D694 File Offset: 0x0009B894
		[Command]
		public void GenWebPassword()
		{
			this.Customer.GenWebPassword();
		}

		// Token: 0x06002FE1 RID: 12257 RVA: 0x0009D584 File Offset: 0x0009B784
		public bool CanGenWebPassword()
		{
			return this.Customer != null;
		}

		// Token: 0x06002FE2 RID: 12258 RVA: 0x0009D6AC File Offset: 0x0009B8AC
		protected override void OnParentViewModelChanged(object obj)
		{
			CustomerCardViewModel customerCardViewModel = obj as CustomerCardViewModel;
			if (customerCardViewModel != null)
			{
				customerCardViewModel.RefCustomerEditViewModel(this);
			}
		}

		// Token: 0x06002FE3 RID: 12259 RVA: 0x0009D6CC File Offset: 0x0009B8CC
		public void DataRefresh()
		{
			CustomerEditViewModel.<DataRefresh>d__47 <DataRefresh>d__;
			<DataRefresh>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<DataRefresh>d__.<>4__this = this;
			<DataRefresh>d__.<>1__state = -1;
			<DataRefresh>d__.<>t__builder.Start<CustomerEditViewModel.<DataRefresh>d__47>(ref <DataRefresh>d__);
		}

		// Token: 0x06002FE4 RID: 12260 RVA: 0x0009D704 File Offset: 0x0009B904
		[CompilerGenerated]
		private void <SaveCard>b__34_0()
		{
			this._customerService.SaveCustomer(this.Customer);
		}

		// Token: 0x04001B16 RID: 6934
		protected readonly ICustomerService _customerService;

		// Token: 0x04001B17 RID: 6935
		protected readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04001B18 RID: 6936
		protected readonly IToasterService _toasterService;

		// Token: 0x04001B19 RID: 6937
		[CompilerGenerated]
		private CustomerCard <Customer>k__BackingField;

		// Token: 0x04001B1A RID: 6938
		private Tel _selectedTel;

		// Token: 0x04001B1B RID: 6939
		[CompilerGenerated]
		private PaymentDetails <SelectedPaymentDetails>k__BackingField;

		// Token: 0x04001B1C RID: 6940
		[CompilerGenerated]
		private ObservableCollection<IPaymentDetails> <PaymentDetails>k__BackingField;

		// Token: 0x04001B1D RID: 6941
		[CompilerGenerated]
		private Dictionary<int, string> <PriceCols>k__BackingField;

		// Token: 0x04001B1E RID: 6942
		[CompilerGenerated]
		private bool <IsLoadingData>k__BackingField;

		// Token: 0x020004DF RID: 1247
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <NavigatedTo>d__25 : IAsyncStateMachine
		{
			// Token: 0x06002FE5 RID: 12261 RVA: 0x0009D724 File Offset: 0x0009B924
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CustomerEditViewModel customerEditViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						customerEditViewModel.Customer = (CustomerCard)this.e.Parameter;
						awaiter = customerEditViewModel.LoadPaymentDetails(customerEditViewModel.Customer.Id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, CustomerEditViewModel.<NavigatedTo>d__25>(ref awaiter, ref this);
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
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002FE6 RID: 12262 RVA: 0x0009D7F8 File Offset: 0x0009B9F8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001B1F RID: 6943
			public int <>1__state;

			// Token: 0x04001B20 RID: 6944
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001B21 RID: 6945
			public CustomerEditViewModel <>4__this;

			// Token: 0x04001B22 RID: 6946
			public NavigationEventArgs e;

			// Token: 0x04001B23 RID: 6947
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020004E0 RID: 1248
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadPaymentDetails>d__26 : IAsyncStateMachine
		{
			// Token: 0x06002FE7 RID: 12263 RVA: 0x0009D814 File Offset: 0x0009BA14
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CustomerEditViewModel customerEditViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<PaymentDetails>> awaiter;
					if (num != 0)
					{
						awaiter = customerEditViewModel._customerService.GetPaymentDetailsAsync(this.customerId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<PaymentDetails>>, CustomerEditViewModel.<LoadPaymentDetails>d__26>(ref awaiter, ref this);
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
					customerEditViewModel.PaymentDetails = new ObservableCollection<IPaymentDetails>(result);
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

			// Token: 0x06002FE8 RID: 12264 RVA: 0x0009D8E0 File Offset: 0x0009BAE0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001B24 RID: 6948
			public int <>1__state;

			// Token: 0x04001B25 RID: 6949
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001B26 RID: 6950
			public CustomerEditViewModel <>4__this;

			// Token: 0x04001B27 RID: 6951
			public int customerId;

			// Token: 0x04001B28 RID: 6952
			private TaskAwaiter<IEnumerable<PaymentDetails>> <>u__1;
		}

		// Token: 0x020004E1 RID: 1249
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SaveCard>d__34 : IAsyncStateMachine
		{
			// Token: 0x06002FE9 RID: 12265 RVA: 0x0009D8FC File Offset: 0x0009BAFC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CustomerEditViewModel customerEditViewModel = this.<>4__this;
				try
				{
					if (num != 0 && customerEditViewModel.Customer.IsRealizator && !customerEditViewModel.Customer.BalanceEnabled)
					{
						ClientsModel.MakeCustomerDealer(customerEditViewModel.Customer.Id);
					}
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = Task.Run(delegate()
							{
								customerEditViewModel._customerService.SaveCustomer(base.Customer);
							}).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, CustomerEditViewModel.<SaveCard>d__34>(ref awaiter, ref this);
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
						customerEditViewModel._toasterService.Success(Lang.t("CustomerCardSaved"));
					}
					catch (Exception ex)
					{
						customerEditViewModel._toasterService.Error(ex.Message);
					}
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

			// Token: 0x06002FEA RID: 12266 RVA: 0x0009DA20 File Offset: 0x0009BC20
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001B29 RID: 6953
			public int <>1__state;

			// Token: 0x04001B2A RID: 6954
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001B2B RID: 6955
			public CustomerEditViewModel <>4__this;

			// Token: 0x04001B2C RID: 6956
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020004E2 RID: 1250
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <DataRefresh>d__47 : IAsyncStateMachine
		{
			// Token: 0x06002FEB RID: 12267 RVA: 0x0009DA3C File Offset: 0x0009BC3C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CustomerEditViewModel customerEditViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = customerEditViewModel.LoadPaymentDetails(customerEditViewModel.Customer.Id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, CustomerEditViewModel.<DataRefresh>d__47>(ref awaiter, ref this);
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
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002FEC RID: 12268 RVA: 0x0009DAFC File Offset: 0x0009BCFC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001B2D RID: 6957
			public int <>1__state;

			// Token: 0x04001B2E RID: 6958
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001B2F RID: 6959
			public CustomerEditViewModel <>4__this;

			// Token: 0x04001B30 RID: 6960
			private TaskAwaiter <>u__1;
		}
	}
}
