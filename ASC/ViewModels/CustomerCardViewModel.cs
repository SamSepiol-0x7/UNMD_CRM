using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Common.Objects.VoIP;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Options;
using ASC.RealizatorPay;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using ASC.ViewModels.CustomerCard;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Core.Native;

namespace ASC.ViewModels
{
	// Token: 0x02000455 RID: 1109
	public class CustomerCardViewModel : MenuViewModel, IRefreshable
	{
		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x06002BCB RID: 11211 RVA: 0x0008BAB8 File Offset: 0x00089CB8
		// (set) Token: 0x06002BCC RID: 11212 RVA: 0x0008BACC File Offset: 0x00089CCC
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
				if (object.Equals(this.<Customer>k__BackingField, value))
				{
					return;
				}
				this.<Customer>k__BackingField = value;
				this.RaisePropertyChanged("SaveButtonVisible");
				this.RaisePropertyChanged("CreateButtonVisible");
				this.RaisePropertyChanged("Customer");
			}
		}

		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x06002BCD RID: 11213 RVA: 0x0008BB10 File Offset: 0x00089D10
		// (set) Token: 0x06002BCE RID: 11214 RVA: 0x0008BB24 File Offset: 0x00089D24
		public CustomerCallsViewModel CallsViewModel
		{
			[CompilerGenerated]
			get
			{
				return this.<CallsViewModel>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				if (object.Equals(this.<CallsViewModel>k__BackingField, value))
				{
					return;
				}
				this.<CallsViewModel>k__BackingField = value;
				this.RaisePropertyChanged("CallsViewModel");
			}
		}

		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x06002BCF RID: 11215 RVA: 0x0008BB54 File Offset: 0x00089D54
		// (set) Token: 0x06002BD0 RID: 11216 RVA: 0x0008BB68 File Offset: 0x00089D68
		public List<PhoneOptions> PhoneOptions
		{
			[CompilerGenerated]
			get
			{
				return this.<PhoneOptions>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<PhoneOptions>k__BackingField, value))
				{
					return;
				}
				this.<PhoneOptions>k__BackingField = value;
				this.RaisePropertyChanged("PhoneOptions");
			}
		}

		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x06002BD1 RID: 11217 RVA: 0x0008BB98 File Offset: 0x00089D98
		public bool SaveButtonVisible
		{
			get
			{
				return OfflineData.Instance.Employee.Can(11, 0) && this.Customer != null && this.Customer.Id != 0;
			}
		}

		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x06002BD2 RID: 11218 RVA: 0x0008BBD4 File Offset: 0x00089DD4
		public bool CreateButtonVisible
		{
			get
			{
				return this.Customer.Id == 0;
			}
		}

		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x06002BD3 RID: 11219 RVA: 0x0008BBF0 File Offset: 0x00089DF0
		// (set) Token: 0x06002BD4 RID: 11220 RVA: 0x0008BC04 File Offset: 0x00089E04
		public List<string> CustomerInfo
		{
			[CompilerGenerated]
			get
			{
				return this.<CustomerInfo>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<CustomerInfo>k__BackingField, value))
				{
					return;
				}
				this.<CustomerInfo>k__BackingField = value;
				this.RaisePropertyChanged("CustomerInfo");
			}
		}

		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x06002BD5 RID: 11221 RVA: 0x0008BC34 File Offset: 0x00089E34
		// (set) Token: 0x06002BD6 RID: 11222 RVA: 0x0008BC48 File Offset: 0x00089E48
		public Realizator Realizator
		{
			[CompilerGenerated]
			get
			{
				return this.<Realizator>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Realizator>k__BackingField, value))
				{
					return;
				}
				this.<Realizator>k__BackingField = value;
				this.RaisePropertyChanged("Realizator");
			}
		}

		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x06002BD7 RID: 11223 RVA: 0x0008BC78 File Offset: 0x00089E78
		// (set) Token: 0x06002BD8 RID: 11224 RVA: 0x0008BC8C File Offset: 0x00089E8C
		private int CustomerId
		{
			[CompilerGenerated]
			get
			{
				return this.<CustomerId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CustomerId>k__BackingField == value)
				{
					return;
				}
				this.<CustomerId>k__BackingField = value;
				this.RaisePropertyChanged("CustomerId");
			}
		}

		// Token: 0x06002BD9 RID: 11225 RVA: 0x0008BCB8 File Offset: 0x00089EB8
		public CustomerCardViewModel()
		{
			this._customerService = Bootstrapper.Container.Resolve<ICustomerService>();
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
		}

		// Token: 0x06002BDA RID: 11226 RVA: 0x0008BD0C File Offset: 0x00089F0C
		public CustomerCardViewModel(int clientId) : this()
		{
			this.CustomerId = clientId;
			this.SetViewName("ClientCard", clientId);
			this.LoadPhoneOptions();
			this.LoadCustomer(clientId);
			this.CallsViewModel = new CustomerCallsViewModel(this.CustomerId);
		}

		// Token: 0x06002BDB RID: 11227 RVA: 0x0008BD50 File Offset: 0x00089F50
		private void LoadCustomer(int customerId)
		{
			CustomerCardViewModel.<LoadCustomer>d__34 <LoadCustomer>d__;
			<LoadCustomer>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadCustomer>d__.<>4__this = this;
			<LoadCustomer>d__.customerId = customerId;
			<LoadCustomer>d__.<>1__state = -1;
			<LoadCustomer>d__.<>t__builder.Start<CustomerCardViewModel.<LoadCustomer>d__34>(ref <LoadCustomer>d__);
		}

		// Token: 0x06002BDC RID: 11228 RVA: 0x0008BD90 File Offset: 0x00089F90
		private void LoadPhoto()
		{
			Task.Run(delegate()
			{
				this.Customer.LoadPhoto();
			});
		}

		// Token: 0x06002BDD RID: 11229 RVA: 0x0008BDB0 File Offset: 0x00089FB0
		public override void MenuItemChanged()
		{
			base.RaiseCanExecuteChanged(() => this.Save());
			if (base.CurrentMenuItemPageName("CustomerDealerView"))
			{
				this.RealizatorLoad();
			}
		}

		// Token: 0x06002BDE RID: 11230 RVA: 0x0008BE0C File Offset: 0x0008A00C
		public override void InitMenu()
		{
			CustomerCardViewModel.<InitMenu>d__37 <InitMenu>d__;
			<InitMenu>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<InitMenu>d__.<>4__this = this;
			<InitMenu>d__.<>1__state = -1;
			<InitMenu>d__.<>t__builder.Start<CustomerCardViewModel.<InitMenu>d__37>(ref <InitMenu>d__);
		}

		// Token: 0x06002BDF RID: 11231 RVA: 0x0008BE44 File Offset: 0x0008A044
		private void LoadPhoneOptions()
		{
			this.PhoneOptions = new PhoneOptions().GetAllOptions();
		}

		// Token: 0x06002BE0 RID: 11232 RVA: 0x0008BE64 File Offset: 0x0008A064
		[Command]
		public void PlayRecord(object obj)
		{
			string recordId = obj as string;
			new ClientsModel().GetRecord(recordId);
		}

		// Token: 0x06002BE1 RID: 11233 RVA: 0x0008BE84 File Offset: 0x0008A084
		[Command]
		public void MakePayment()
		{
			new RealizatorPayView(this.Customer.Id).Show();
		}

		// Token: 0x06002BE2 RID: 11234 RVA: 0x0008BEA8 File Offset: 0x0008A0A8
		public bool CanMakePayment()
		{
			return OfflineData.Instance.Employee.Can(16, 0);
		}

		// Token: 0x06002BE3 RID: 11235 RVA: 0x0008BEC8 File Offset: 0x0008A0C8
		private void RealizatorLoad()
		{
			this.Realizator = new Realizator(this.Customer.Id);
			this.Realizator.SetParentViewModel(this);
		}

		// Token: 0x06002BE4 RID: 11236 RVA: 0x0008BEF8 File Offset: 0x0008A0F8
		[Command]
		public void CallClient()
		{
			CustomerCardViewModel.<CallClient>d__43 <CallClient>d__;
			<CallClient>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<CallClient>d__.<>4__this = this;
			<CallClient>d__.<>1__state = -1;
			<CallClient>d__.<>t__builder.Start<CustomerCardViewModel.<CallClient>d__43>(ref <CallClient>d__);
		}

		// Token: 0x06002BE5 RID: 11237 RVA: 0x0008BF30 File Offset: 0x0008A130
		public bool CanCallClient()
		{
			if (Core.Instance.CanCall() && this.Customer != null)
			{
				return this.Customer.Phones.Any((Tel p) => p.Type == 1);
			}
			return false;
		}

		// Token: 0x06002BE6 RID: 11238 RVA: 0x0008BF84 File Offset: 0x0008A184
		[Command]
		public void ShowSmsForm()
		{
			this._windowedDocumentService.ShowNewDocument("SmsSendView", new SmsSendViewModel(this.CustomerId), null, null);
		}

		// Token: 0x06002BE7 RID: 11239 RVA: 0x0008BFB0 File Offset: 0x0008A1B0
		public bool CanShowSmsForm()
		{
			return OfflineData.Instance.Employee.Can(63, 0) && !string.IsNullOrEmpty(Auth.Config.sms_config) && base.IsValid();
		}

		// Token: 0x06002BE8 RID: 11240 RVA: 0x0008BFEC File Offset: 0x0008A1EC
		[Command]
		public void Refresh()
		{
			this.CallsViewModel.Refresh();
		}

		// Token: 0x06002BE9 RID: 11241 RVA: 0x0008C004 File Offset: 0x0008A204
		public bool CanRefresh()
		{
			return base.SelectedMenuItem != null && base.SelectedMenuItem.Caption == Lang.t("Calls") && this.CallsViewModel != null;
		}

		// Token: 0x06002BEA RID: 11242 RVA: 0x0008C040 File Offset: 0x0008A240
		public void DataRefresh()
		{
			CustomerCard customer = this.Customer;
			if (customer == null)
			{
				return;
			}
			customer.LoadPaymentDetais();
		}

		// Token: 0x06002BEB RID: 11243 RVA: 0x0008C060 File Offset: 0x0008A260
		[Command]
		public void ShowEmail()
		{
			this._windowedDocumentService.ShowNewDocument("EmailView", new EmailViewModel(this.Customer.Email), null, null);
		}

		// Token: 0x06002BEC RID: 11244 RVA: 0x0008C090 File Offset: 0x0008A290
		public bool CanShowEmail()
		{
			return this.Customer != null;
		}

		// Token: 0x06002BED RID: 11245 RVA: 0x0008C0A8 File Offset: 0x0008A2A8
		public void RefCustomerEditViewModel(CustomerEditViewModel vm)
		{
			this._customerEditViewModel = vm;
		}

		// Token: 0x06002BEE RID: 11246 RVA: 0x0008C0BC File Offset: 0x0008A2BC
		[Command]
		public void Save()
		{
			this._customerEditViewModel.SaveCard();
		}

		// Token: 0x06002BEF RID: 11247 RVA: 0x0008C0D4 File Offset: 0x0008A2D4
		public bool CanSave()
		{
			return base.SelectedMenuItem != null && base.SelectedMenuItem.PageName == "CustomerEditView" && this._customerEditViewModel != null;
		}

		// Token: 0x06002BF0 RID: 11248 RVA: 0x0008C10C File Offset: 0x0008A30C
		[Command]
		public void ChargeBalance()
		{
			IKoViewModel koViewModel = Bootstrapper.Container.ResolveKeyed("PKO");
			koViewModel.SetOrderType(Kassa.Types.plusClientBalance);
			koViewModel.SelectCustomerFromList(this.Customer);
			this._navigationService.Navigate("PkoView", koViewModel);
		}

		// Token: 0x06002BF1 RID: 11249 RVA: 0x0008C150 File Offset: 0x0008A350
		public bool CanChargeBalance()
		{
			return this.Customer != null && this.Customer.BalanceEnabled;
		}

		// Token: 0x06002BF2 RID: 11250 RVA: 0x0008C174 File Offset: 0x0008A374
		[Command]
		public void SubstractBalance()
		{
			IKoViewModel koViewModel = Bootstrapper.Container.ResolveKeyed("RKO");
			koViewModel.SetOrderType(Kassa.Types.minusClientBalance);
			koViewModel.SelectCustomerFromList(this.Customer);
			this._navigationService.Navigate("RkoView", koViewModel);
		}

		// Token: 0x06002BF3 RID: 11251 RVA: 0x0008C150 File Offset: 0x0008A350
		public bool CanSubstractBalance()
		{
			return this.Customer != null && this.Customer.BalanceEnabled;
		}

		// Token: 0x06002BF4 RID: 11252 RVA: 0x0008C1B8 File Offset: 0x0008A3B8
		[CompilerGenerated]
		private void <LoadPhoto>b__35_0()
		{
			this.Customer.LoadPhoto();
		}

		// Token: 0x06002BF5 RID: 11253 RVA: 0x0008C1D0 File Offset: 0x0008A3D0
		[CompilerGenerated]
		[DebuggerHidden]
		private void <>n__0()
		{
			base.InitMenu();
		}

		// Token: 0x04001868 RID: 6248
		protected ICustomerService _customerService;

		// Token: 0x04001869 RID: 6249
		private readonly INavigationService _navigationService;

		// Token: 0x0400186A RID: 6250
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x0400186B RID: 6251
		private readonly IToasterService _toasterService;

		// Token: 0x0400186C RID: 6252
		[CompilerGenerated]
		private CustomerCard <Customer>k__BackingField;

		// Token: 0x0400186D RID: 6253
		[CompilerGenerated]
		private CustomerCallsViewModel <CallsViewModel>k__BackingField;

		// Token: 0x0400186E RID: 6254
		[CompilerGenerated]
		private List<PhoneOptions> <PhoneOptions>k__BackingField;

		// Token: 0x0400186F RID: 6255
		[CompilerGenerated]
		private List<string> <CustomerInfo>k__BackingField;

		// Token: 0x04001870 RID: 6256
		[CompilerGenerated]
		private Realizator <Realizator>k__BackingField;

		// Token: 0x04001871 RID: 6257
		[CompilerGenerated]
		private int <CustomerId>k__BackingField;

		// Token: 0x04001872 RID: 6258
		private CustomerEditViewModel _customerEditViewModel;

		// Token: 0x02000456 RID: 1110
		[CompilerGenerated]
		private sealed class <>c__DisplayClass34_0
		{
			// Token: 0x06002BF6 RID: 11254 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass34_0()
			{
			}

			// Token: 0x06002BF7 RID: 11255 RVA: 0x0008C1E4 File Offset: 0x0008A3E4
			internal Task<ICustomer> <LoadCustomer>b__2()
			{
				return this.<>4__this._customerService.GetCustomerCardAsync(this.customerId);
			}

			// Token: 0x04001873 RID: 6259
			public CustomerCardViewModel <>4__this;

			// Token: 0x04001874 RID: 6260
			public int customerId;
		}

		// Token: 0x02000457 RID: 1111
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadCustomer>d__34 : IAsyncStateMachine
		{
			// Token: 0x06002BF8 RID: 11256 RVA: 0x0008C208 File Offset: 0x0008A408
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CustomerCardViewModel customerCardViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<ICustomer> awaiter;
					if (num != 0)
					{
						CustomerCardViewModel.<>c__DisplayClass34_0 CS$<>8__locals1 = new CustomerCardViewModel.<>c__DisplayClass34_0();
						CS$<>8__locals1.<>4__this = this.<>4__this;
						CS$<>8__locals1.customerId = this.customerId;
						customerCardViewModel.ShowWait();
						awaiter = Task.Run<ICustomer>(new Func<Task<ICustomer>>(CS$<>8__locals1.<LoadCustomer>b__2)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ICustomer>, CustomerCardViewModel.<LoadCustomer>d__34>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<ICustomer>);
						this.<>1__state = -1;
					}
					ICustomer result = awaiter.GetResult();
					customerCardViewModel.Customer = (CustomerCard)result;
					customerCardViewModel._navigationService.UpdateTabTitle(customerCardViewModel.TabId, Lang.t("ClientCard") + " " + customerCardViewModel.Customer.FioShortOrUrName);
					customerCardViewModel.RaiseCanExecuteChanged(() => customerCardViewModel.ChargeBalance());
					customerCardViewModel.RaiseCanExecuteChanged(() => customerCardViewModel.SubstractBalance());
					customerCardViewModel.Customer.CountPurchases();
					customerCardViewModel.Customer.LoadCustomerInfo();
					customerCardViewModel.InitMenu();
					customerCardViewModel.HideWait();
					customerCardViewModel.LoadPhoto();
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

			// Token: 0x06002BF9 RID: 11257 RVA: 0x0008C3D4 File Offset: 0x0008A5D4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001875 RID: 6261
			public int <>1__state;

			// Token: 0x04001876 RID: 6262
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001877 RID: 6263
			public CustomerCardViewModel <>4__this;

			// Token: 0x04001878 RID: 6264
			public int customerId;

			// Token: 0x04001879 RID: 6265
			private TaskAwaiter<ICustomer> <>u__1;
		}

		// Token: 0x02000458 RID: 1112
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002BFA RID: 11258 RVA: 0x0008C3F0 File Offset: 0x0008A5F0
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06002BFB RID: 11259 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06002BFC RID: 11260 RVA: 0x0008C408 File Offset: 0x0008A608
			internal void <InitMenu>b__37_0()
			{
				Thread.Sleep(100);
			}

			// Token: 0x06002BFD RID: 11261 RVA: 0x0008C41C File Offset: 0x0008A61C
			internal bool <CallClient>b__43_0(Tel p)
			{
				return p.Type == 1;
			}

			// Token: 0x06002BFE RID: 11262 RVA: 0x0008C41C File Offset: 0x0008A61C
			internal bool <CanCallClient>b__44_0(Tel p)
			{
				return p.Type == 1;
			}

			// Token: 0x0400187A RID: 6266
			public static readonly CustomerCardViewModel.<>c <>9 = new CustomerCardViewModel.<>c();

			// Token: 0x0400187B RID: 6267
			public static Action <>9__37_0;

			// Token: 0x0400187C RID: 6268
			public static Func<Tel, bool> <>9__43_0;

			// Token: 0x0400187D RID: 6269
			public static Func<Tel, bool> <>9__44_0;
		}

		// Token: 0x02000459 RID: 1113
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <InitMenu>d__37 : IAsyncStateMachine
		{
			// Token: 0x06002BFF RID: 11263 RVA: 0x0008C434 File Offset: 0x0008A634
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CustomerCardViewModel customerCardViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<bool> awaiter;
					TaskAwaiter awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<bool>);
							this.<>1__state = -1;
							goto IL_2A8;
						}
						customerCardViewModel.<>n__0();
						customerCardViewModel.ShowWait();
						awaiter2 = Task.Run(new Action(CustomerCardViewModel.<>c.<>9.<InitMenu>b__37_0)).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, CustomerCardViewModel.<InitMenu>d__37>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
					}
					awaiter2.GetResult();
					customerCardViewModel.AddMenuItem("Overview", "CustomerOverviewView", "Home_32x32.png");
					if (OfflineData.Instance.Employee.Can(11, 0))
					{
						customerCardViewModel.AddMenuItem("Edit", "CustomerEditView", "Edit_32x32.png", customerCardViewModel.Customer);
					}
					customerCardViewModel.AddMenuItem("Repairs", "CustomerRepairsView", "IDE_32x32.png", customerCardViewModel.Customer);
					customerCardViewModel.AddMenuItem("Purchases", "CustomerPurchasesView", "BOOrder_32x32.png", customerCardViewModel.Customer);
					if (customerCardViewModel.Customer != null && customerCardViewModel.Customer.IsDealer && customerCardViewModel.IsValid())
					{
						DXImageInfo glyph = (DXImageInfo)new DXImageGrayscaleConverter().ConvertFromString("Cube_32x32.png");
						customerCardViewModel.MenuItems.Add(new HamburgerMenuItemViewModel(Lang.t("Sales"), "CustomerSalesView", glyph, customerCardViewModel));
					}
					if (customerCardViewModel.IsValid())
					{
						customerCardViewModel.AddMenuItem("Calls", "CustomerCallsView", "Phone_32x32.png");
					}
					if (customerCardViewModel.Customer != null && customerCardViewModel.Customer.IsRealizator && customerCardViewModel.IsValid())
					{
						customerCardViewModel.AddMenuItem("Realizator", "CustomerDealerView", "");
					}
					if (OfflineData.Instance.Employee.Can(15, 0))
					{
						customerCardViewModel.AddMenuItem("Finances", "CustomerFinancesView", "Currency_32x32.png", customerCardViewModel.Customer);
					}
					if (customerCardViewModel.Customer != null && customerCardViewModel.Customer.BalanceEnabled && OfflineData.Instance.Employee.Can(15, 0))
					{
						customerCardViewModel.AddMenuItem("Balance", "CustomerBalanceView", "Accounting_32x32.png", customerCardViewModel.Customer);
					}
					customerCardViewModel.AddMenuItem("History", "CustomerHistoryView", "HistoryItem_32x32.png", customerCardViewModel.Customer);
					awaiter = ClientsModel.HasInvoices(customerCardViewModel.CustomerId).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, CustomerCardViewModel.<InitMenu>d__37>(ref awaiter, ref this);
						return;
					}
					IL_2A8:
					if (awaiter.GetResult() && customerCardViewModel.IsValid())
					{
						DXImageInfo glyph2 = (DXImageInfo)new DXImageConverter().ConvertFromString("Report_32x32.png");
						customerCardViewModel.MenuItems.Insert(3, new HamburgerMenuItemViewModel(Lang.t("Invoices"), "CustomerInvoicesView", glyph2, customerCardViewModel.Customer));
					}
					customerCardViewModel.SelectFirstMenuItem();
					customerCardViewModel.HideWait();
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

			// Token: 0x06002C00 RID: 11264 RVA: 0x0008C790 File Offset: 0x0008A990
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400187E RID: 6270
			public int <>1__state;

			// Token: 0x0400187F RID: 6271
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001880 RID: 6272
			public CustomerCardViewModel <>4__this;

			// Token: 0x04001881 RID: 6273
			private TaskAwaiter <>u__1;

			// Token: 0x04001882 RID: 6274
			private TaskAwaiter<bool> <>u__2;
		}

		// Token: 0x0200045A RID: 1114
		[CompilerGenerated]
		private sealed class <>c__DisplayClass43_0
		{
			// Token: 0x06002C01 RID: 11265 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass43_0()
			{
			}

			// Token: 0x06002C02 RID: 11266 RVA: 0x0008C7AC File Offset: 0x0008A9AC
			internal Task<Callback> <CallClient>b__1()
			{
				return Core.Instance.VoIP.Callback(OfflineData.Instance.Employee.Tel.ToString(), this.phone.PhoneClean);
			}

			// Token: 0x04001883 RID: 6275
			public Tel phone;
		}

		// Token: 0x0200045B RID: 1115
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CallClient>d__43 : IAsyncStateMachine
		{
			// Token: 0x06002C03 RID: 11267 RVA: 0x0008C7F0 File Offset: 0x0008A9F0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CustomerCardViewModel customerCardViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<Callback> awaiter;
					if (num != 0)
					{
						CustomerCardViewModel.<>c__DisplayClass43_0 CS$<>8__locals1 = new CustomerCardViewModel.<>c__DisplayClass43_0();
						CS$<>8__locals1.phone = customerCardViewModel.Customer.Phones.FirstOrDefault(new Func<Tel, bool>(CustomerCardViewModel.<>c.<>9.<CallClient>b__43_0));
						if (CS$<>8__locals1.phone == null || string.IsNullOrEmpty(CS$<>8__locals1.phone.PhoneClean))
						{
							customerCardViewModel._toasterService.Info(Lang.t("InputPhone"));
							goto IL_10E;
						}
						customerCardViewModel.ShowWait();
						awaiter = Task.Run<Callback>(new Func<Task<Callback>>(CS$<>8__locals1.<CallClient>b__1)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Callback>, CustomerCardViewModel.<CallClient>d__43>(ref awaiter, ref this);
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
					customerCardViewModel.HideWait();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_10E:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002C04 RID: 11268 RVA: 0x0008C930 File Offset: 0x0008AB30
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001884 RID: 6276
			public int <>1__state;

			// Token: 0x04001885 RID: 6277
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001886 RID: 6278
			public CustomerCardViewModel <>4__this;

			// Token: 0x04001887 RID: 6279
			private TaskAwaiter<Callback> <>u__1;
		}
	}
}
