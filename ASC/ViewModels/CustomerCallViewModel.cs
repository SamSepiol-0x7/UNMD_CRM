using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.ItemsSale;
using ASC.Models;
using ASC.Objects;
using ASC.Services.Abstract;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels
{
	// Token: 0x02000476 RID: 1142
	public class CustomerCallViewModel : BaseViewModel
	{
		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x06002CBF RID: 11455 RVA: 0x000900E4 File Offset: 0x0008E2E4
		// (set) Token: 0x06002CC0 RID: 11456 RVA: 0x000900F8 File Offset: 0x0008E2F8
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
				this.RaisePropertyChanged("Customer");
			}
		}

		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x06002CC1 RID: 11457 RVA: 0x00090128 File Offset: 0x0008E328
		// (set) Token: 0x06002CC2 RID: 11458 RVA: 0x0009013C File Offset: 0x0008E33C
		public ObservableCollection<IRepairCard> Repairs
		{
			[CompilerGenerated]
			get
			{
				return this.<Repairs>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Repairs>k__BackingField, value))
				{
					return;
				}
				this.<Repairs>k__BackingField = value;
				this.RaisePropertyChanged("Repairs");
			}
		}

		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x06002CC3 RID: 11459 RVA: 0x0009016C File Offset: 0x0008E36C
		// (set) Token: 0x06002CC4 RID: 11460 RVA: 0x00090180 File Offset: 0x0008E380
		public ObservableCollection<store_sales> Purchases
		{
			[CompilerGenerated]
			get
			{
				return this.<Purchases>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Purchases>k__BackingField, value))
				{
					return;
				}
				this.<Purchases>k__BackingField = value;
				this.RaisePropertyChanged("Purchases");
			}
		}

		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x06002CC5 RID: 11461 RVA: 0x000901B0 File Offset: 0x0008E3B0
		// (set) Token: 0x06002CC6 RID: 11462 RVA: 0x000901C4 File Offset: 0x0008E3C4
		public IRepairCard SelectedRepair
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedRepair>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedRepair>k__BackingField, value))
				{
					return;
				}
				this.<SelectedRepair>k__BackingField = value;
				this.RaisePropertyChanged("SelectedRepair");
			}
		}

		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x06002CC7 RID: 11463 RVA: 0x000901F4 File Offset: 0x0008E3F4
		// (set) Token: 0x06002CC8 RID: 11464 RVA: 0x00090208 File Offset: 0x0008E408
		public store_sales SelectedPurchase
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedPurchase>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedPurchase>k__BackingField, value))
				{
					return;
				}
				this.<SelectedPurchase>k__BackingField = value;
				this.RaisePropertyChanged("SelectedPurchase");
			}
		}

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x06002CC9 RID: 11465 RVA: 0x00090238 File Offset: 0x0008E438
		// (set) Token: 0x06002CCA RID: 11466 RVA: 0x0009024C File Offset: 0x0008E44C
		public bool RepairsVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<RepairsVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<RepairsVisible>k__BackingField == value)
				{
					return;
				}
				this.<RepairsVisible>k__BackingField = value;
				this.RaisePropertyChanged("RepairsVisible");
			}
		}

		// Token: 0x17000E6C RID: 3692
		// (get) Token: 0x06002CCB RID: 11467 RVA: 0x00090278 File Offset: 0x0008E478
		// (set) Token: 0x06002CCC RID: 11468 RVA: 0x0009028C File Offset: 0x0008E48C
		public bool PurchasesVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<PurchasesVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PurchasesVisible>k__BackingField == value)
				{
					return;
				}
				this.<PurchasesVisible>k__BackingField = value;
				this.RaisePropertyChanged("PurchasesVisible");
			}
		}

		// Token: 0x17000E6D RID: 3693
		// (get) Token: 0x06002CCD RID: 11469 RVA: 0x000902B8 File Offset: 0x0008E4B8
		// (set) Token: 0x06002CCE RID: 11470 RVA: 0x000902CC File Offset: 0x0008E4CC
		public string CallFrom
		{
			[CompilerGenerated]
			get
			{
				return this.<CallFrom>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<CallFrom>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<CallFrom>k__BackingField = value;
				this.RaisePropertyChanged("CallFrom");
			}
		}

		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x06002CCF RID: 11471 RVA: 0x000902FC File Offset: 0x0008E4FC
		// (set) Token: 0x06002CD0 RID: 11472 RVA: 0x00090310 File Offset: 0x0008E510
		public int CustomerId
		{
			[CompilerGenerated]
			get
			{
				return this.<CustomerId>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<CustomerId>k__BackingField == value)
				{
					return;
				}
				this.<CustomerId>k__BackingField = value;
				this.RaisePropertyChanged("CustomerId");
			}
		}

		// Token: 0x06002CD1 RID: 11473 RVA: 0x0009033C File Offset: 0x0008E53C
		public CustomerCallViewModel(ICustomerService customerService, INavigationService navigationService, IWindowedDocumentService windowedDocumentService)
		{
			this._customerService = customerService;
			this._navigationService = navigationService;
			this._windowedDocumentService = windowedDocumentService;
		}

		// Token: 0x06002CD2 RID: 11474 RVA: 0x00090364 File Offset: 0x0008E564
		public void SetCallFrom(string callFrom)
		{
			this.CallFrom = callFrom;
		}

		// Token: 0x06002CD3 RID: 11475 RVA: 0x00090378 File Offset: 0x0008E578
		public void SetCustomerId(int customerId)
		{
			this.CustomerId = customerId;
		}

		// Token: 0x06002CD4 RID: 11476 RVA: 0x0009038C File Offset: 0x0008E58C
		[Command]
		public void Close()
		{
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x06002CD5 RID: 11477 RVA: 0x000903A4 File Offset: 0x0008E5A4
		[Command]
		public void Unloaded()
		{
			base.HideWait();
		}

		// Token: 0x06002CD6 RID: 11478 RVA: 0x000903B8 File Offset: 0x0008E5B8
		[Command]
		public void ShowEmail()
		{
			this._windowedDocumentService.ShowNewDocument("EmailView", new EmailViewModel(this.Customer.Email), null, null);
		}

		// Token: 0x06002CD7 RID: 11479 RVA: 0x000903E8 File Offset: 0x0008E5E8
		[Command]
		public void RepairDoubleClick()
		{
			if (this.SelectedRepair != null)
			{
				goto IL_2C;
			}
			IL_08:
			int num = 156673923;
			IL_0D:
			switch ((num ^ 580816822) % 4)
			{
			case 0:
				goto IL_08;
			case 1:
				return;
			case 3:
				IL_2C:
				this._navigationService.NavigateRepairCard(this.SelectedRepair.Id);
				this._windowedDocumentService.CloseActiveDocument();
				num = 1979100228;
				goto IL_0D;
			}
		}

		// Token: 0x06002CD8 RID: 11480 RVA: 0x0009044C File Offset: 0x0008E64C
		[Command]
		public void OpenCustomerCard()
		{
			if (this.Customer == null)
			{
				return;
			}
			this._navigationService.NavigateToCustomerCard(this.Customer.Id, null);
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x06002CD9 RID: 11481 RVA: 0x00090484 File Offset: 0x0008E684
		[Command]
		public void PurchaseDoubleClick()
		{
			if (this.SelectedPurchase != null)
			{
				goto IL_2C;
			}
			IL_08:
			int num = 50080418;
			IL_0D:
			switch ((num ^ 763993447) % 4)
			{
			case 0:
				goto IL_08;
			case 1:
				return;
			case 3:
				IL_2C:
				this._navigationService.Navigate("ItemsSaleView", new ItemsSaleViewModel(this.SelectedPurchase.document_id));
				this._windowedDocumentService.CloseActiveDocument();
				num = 598998337;
				goto IL_0D;
			}
		}

		// Token: 0x06002CDA RID: 11482 RVA: 0x000904F0 File Offset: 0x0008E6F0
		public override void OnLoad()
		{
			CustomerCallViewModel.<OnLoad>d__48 <OnLoad>d__;
			<OnLoad>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnLoad>d__.<>4__this = this;
			<OnLoad>d__.<>1__state = -1;
			<OnLoad>d__.<>t__builder.Start<CustomerCallViewModel.<OnLoad>d__48>(ref <OnLoad>d__);
		}

		// Token: 0x06002CDB RID: 11483 RVA: 0x00090528 File Offset: 0x0008E728
		[CompilerGenerated]
		private Task<CustomerCard> <OnLoad>b__48_0()
		{
			return ClientsModel.GetCustomerCard(this.CustomerId);
		}

		// Token: 0x06002CDC RID: 11484 RVA: 0x0003401C File Offset: 0x0003221C
		[CompilerGenerated]
		[DebuggerHidden]
		private void <>n__0()
		{
			base.OnLoad();
		}

		// Token: 0x04001901 RID: 6401
		[CompilerGenerated]
		private CustomerCard <Customer>k__BackingField;

		// Token: 0x04001902 RID: 6402
		[CompilerGenerated]
		private ObservableCollection<IRepairCard> <Repairs>k__BackingField;

		// Token: 0x04001903 RID: 6403
		[CompilerGenerated]
		private ObservableCollection<store_sales> <Purchases>k__BackingField;

		// Token: 0x04001904 RID: 6404
		[CompilerGenerated]
		private IRepairCard <SelectedRepair>k__BackingField;

		// Token: 0x04001905 RID: 6405
		[CompilerGenerated]
		private store_sales <SelectedPurchase>k__BackingField;

		// Token: 0x04001906 RID: 6406
		[CompilerGenerated]
		private bool <RepairsVisible>k__BackingField;

		// Token: 0x04001907 RID: 6407
		[CompilerGenerated]
		private bool <PurchasesVisible>k__BackingField;

		// Token: 0x04001908 RID: 6408
		[CompilerGenerated]
		private string <CallFrom>k__BackingField;

		// Token: 0x04001909 RID: 6409
		protected ICustomerService _customerService;

		// Token: 0x0400190A RID: 6410
		private readonly INavigationService _navigationService;

		// Token: 0x0400190B RID: 6411
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x0400190C RID: 6412
		[CompilerGenerated]
		private int <CustomerId>k__BackingField;

		// Token: 0x02000477 RID: 1143
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnLoad>d__48 : IAsyncStateMachine
		{
			// Token: 0x06002CDD RID: 11485 RVA: 0x00090540 File Offset: 0x0008E740
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CustomerCallViewModel customerCallViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<CustomerCard> awaiter;
					TaskAwaiter<IEnumerable<RepairCard>> awaiter2;
					TaskAwaiter<IEnumerable<store_sales>> awaiter3;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<CustomerCard>);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<IEnumerable<RepairCard>>);
						this.<>1__state = -1;
						goto IL_134;
					case 2:
						awaiter3 = this.<>u__3;
						this.<>u__3 = default(TaskAwaiter<IEnumerable<store_sales>>);
						this.<>1__state = -1;
						goto IL_1B1;
					default:
						customerCallViewModel.<>n__0();
						customerCallViewModel.ShowWait();
						awaiter = Task.Run<CustomerCard>(() => ClientsModel.GetCustomerCard(base.CustomerId)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<CustomerCard>, CustomerCallViewModel.<OnLoad>d__48>(ref awaiter, ref this);
							return;
						}
						break;
					}
					CustomerCard result = awaiter.GetResult();
					customerCallViewModel.Customer = result;
					CustomerCard customer = customerCallViewModel.Customer;
					if (customer != null)
					{
						customer.CountPurchases();
					}
					CustomerCard customer2 = customerCallViewModel.Customer;
					if (customer2 != null)
					{
						customer2.LoadCustomerInfo();
					}
					customerCallViewModel.HideWait();
					if (customerCallViewModel.Customer == null)
					{
						goto IL_1EF;
					}
					awaiter2 = customerCallViewModel._customerService.GetActiveRepairs(customerCallViewModel.Customer.Id).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<RepairCard>>, CustomerCallViewModel.<OnLoad>d__48>(ref awaiter2, ref this);
						return;
					}
					IL_134:
					IEnumerable<RepairCard> result2 = awaiter2.GetResult();
					customerCallViewModel.Repairs = new ObservableCollection<IRepairCard>(result2);
					awaiter3 = customerCallViewModel._customerService.GetPurchases(customerCallViewModel.Customer.Id).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__3 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<store_sales>>, CustomerCallViewModel.<OnLoad>d__48>(ref awaiter3, ref this);
						return;
					}
					IL_1B1:
					IEnumerable<store_sales> result3 = awaiter3.GetResult();
					customerCallViewModel.Purchases = new ObservableCollection<store_sales>(result3);
					customerCallViewModel.RepairsVisible = (customerCallViewModel.Repairs.Count > 0);
					customerCallViewModel.PurchasesVisible = (customerCallViewModel.Purchases.Count > 0);
					IL_1EF:;
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

			// Token: 0x06002CDE RID: 11486 RVA: 0x00090788 File Offset: 0x0008E988
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400190D RID: 6413
			public int <>1__state;

			// Token: 0x0400190E RID: 6414
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400190F RID: 6415
			public CustomerCallViewModel <>4__this;

			// Token: 0x04001910 RID: 6416
			private TaskAwaiter<CustomerCard> <>u__1;

			// Token: 0x04001911 RID: 6417
			private TaskAwaiter<IEnumerable<RepairCard>> <>u__2;

			// Token: 0x04001912 RID: 6418
			private TaskAwaiter<IEnumerable<store_sales>> <>u__3;
		}
	}
}
