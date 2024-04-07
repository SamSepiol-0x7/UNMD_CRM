using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Services.Abstract;
using ASC.ViewModels;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.XtraReports.UI;

namespace ASC.RealizatorPay
{
	// Token: 0x02000165 RID: 357
	public class PayViewModel : BaseViewModel
	{
		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x060016E0 RID: 5856 RVA: 0x0003A894 File Offset: 0x00038A94
		// (set) Token: 0x060016E1 RID: 5857 RVA: 0x0003A8A8 File Offset: 0x00038AA8
		public Action CloseAction
		{
			[CompilerGenerated]
			get
			{
				return this.<CloseAction>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<CloseAction>k__BackingField, value))
				{
					return;
				}
				this.<CloseAction>k__BackingField = value;
				this.RaisePropertyChanged("CloseAction");
			}
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x060016E2 RID: 5858 RVA: 0x0003A8D8 File Offset: 0x00038AD8
		// (set) Token: 0x060016E3 RID: 5859 RVA: 0x0003A8EC File Offset: 0x00038AEC
		public ObservableCollection<store_sales> SoldItems
		{
			[CompilerGenerated]
			get
			{
				return this.<SoldItems>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SoldItems>k__BackingField, value))
				{
					return;
				}
				this.<SoldItems>k__BackingField = value;
				this.RaisePropertyChanged("SoldItems");
			}
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x060016E4 RID: 5860 RVA: 0x0003A91C File Offset: 0x00038B1C
		// (set) Token: 0x060016E5 RID: 5861 RVA: 0x0003A930 File Offset: 0x00038B30
		public store_sales SelectedItem
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedItem>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedItem>k__BackingField, value))
				{
					return;
				}
				this.<SelectedItem>k__BackingField = value;
				this.RaisePropertyChanged("SelectedItem");
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x060016E6 RID: 5862 RVA: 0x0003A960 File Offset: 0x00038B60
		// (set) Token: 0x060016E7 RID: 5863 RVA: 0x0003A974 File Offset: 0x00038B74
		public int CountSelected
		{
			[CompilerGenerated]
			get
			{
				return this.<CountSelected>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CountSelected>k__BackingField == value)
				{
					return;
				}
				this.<CountSelected>k__BackingField = value;
				this.RaisePropertyChanged("CountSelected");
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x060016E8 RID: 5864 RVA: 0x0003A9A0 File Offset: 0x00038BA0
		// (set) Token: 0x060016E9 RID: 5865 RVA: 0x0003A9B4 File Offset: 0x00038BB4
		public decimal SummSelected
		{
			[CompilerGenerated]
			get
			{
				return this.<SummSelected>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<SummSelected>k__BackingField, value))
				{
					return;
				}
				this.<SummSelected>k__BackingField = value;
				this.RaisePropertyChanged("SummSelected");
			}
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x060016EA RID: 5866 RVA: 0x0003A9E4 File Offset: 0x00038BE4
		// (set) Token: 0x060016EB RID: 5867 RVA: 0x0003A9F8 File Offset: 0x00038BF8
		public bool IsCorrectInput
		{
			[CompilerGenerated]
			get
			{
				return this.<IsCorrectInput>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IsCorrectInput>k__BackingField == value)
				{
					return;
				}
				this.<IsCorrectInput>k__BackingField = value;
				this.RaisePropertyChanged("IsCorrectInput");
			}
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x060016EC RID: 5868 RVA: 0x0003AA24 File Offset: 0x00038C24
		// (set) Token: 0x060016ED RID: 5869 RVA: 0x0003AA38 File Offset: 0x00038C38
		public bool CreateRko
		{
			[CompilerGenerated]
			get
			{
				return this.<CreateRko>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CreateRko>k__BackingField == value)
				{
					return;
				}
				this.<CreateRko>k__BackingField = value;
				this.RaisePropertyChanged("CreateRko");
			}
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x060016EE RID: 5870 RVA: 0x0003AA64 File Offset: 0x00038C64
		// (set) Token: 0x060016EF RID: 5871 RVA: 0x0003AA78 File Offset: 0x00038C78
		public bool PrintRko
		{
			[CompilerGenerated]
			get
			{
				return this.<PrintRko>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PrintRko>k__BackingField == value)
				{
					return;
				}
				this.<PrintRko>k__BackingField = value;
				this.RaisePropertyChanged("PrintRko");
			}
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x060016F0 RID: 5872 RVA: 0x0003AAA4 File Offset: 0x00038CA4
		// (set) Token: 0x060016F1 RID: 5873 RVA: 0x0003AAB8 File Offset: 0x00038CB8
		public bool PrintDescription
		{
			[CompilerGenerated]
			get
			{
				return this.<PrintDescription>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PrintDescription>k__BackingField == value)
				{
					return;
				}
				this.<PrintDescription>k__BackingField = value;
				this.RaisePropertyChanged("PrintDescription");
			}
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x060016F2 RID: 5874 RVA: 0x0003AAE4 File Offset: 0x00038CE4
		// (set) Token: 0x060016F3 RID: 5875 RVA: 0x0003AAF8 File Offset: 0x00038CF8
		public bool SelectAll
		{
			get
			{
				return this._selectAll;
			}
			set
			{
				if (this._selectAll == value)
				{
					return;
				}
				this._selectAll = value;
				this.RaisePropertyChanged("SelectAll");
				if (this.SoldItems != null)
				{
					foreach (store_sales store_sales in this.SoldItems)
					{
						store_sales.isSelected = value;
					}
				}
				this.SelectionChanged();
			}
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x060016F4 RID: 5876 RVA: 0x0003AB70 File Offset: 0x00038D70
		// (set) Token: 0x060016F5 RID: 5877 RVA: 0x0003AB84 File Offset: 0x00038D84
		public ICustomer Customer
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

		// Token: 0x060016F6 RID: 5878 RVA: 0x0003ABB4 File Offset: 0x00038DB4
		private void IoC()
		{
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x0003ABD4 File Offset: 0x00038DD4
		public PayViewModel(int realizatorId)
		{
			this.IoC();
			this.SetViewName("RealizatorPay");
			this._clientId = realizatorId;
			this.BgInit();
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x0003AC08 File Offset: 0x00038E08
		public PayViewModel(int paymentId, bool setTrue)
		{
			this.IoC();
			this.SetViewName("RealizatorPay", paymentId);
			this.LoadExistPayment(paymentId);
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x0003AC34 File Offset: 0x00038E34
		private void LoadExistPayment(int paymentId)
		{
			base.ShowWait();
			Task.Run<IEnumerable<store_sales>>(() => PayModel.LoadExistPayment(paymentId)).ContinueWith(delegate(Task<IEnumerable<store_sales>> t)
			{
				this.SoldItems = new ObservableCollection<store_sales>(t.Result);
				this.SelectAll = true;
				this.HideWait();
			});
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x0003AC80 File Offset: 0x00038E80
		private void BgInit()
		{
			PayViewModel.<BgInit>d__50 <BgInit>d__;
			<BgInit>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<BgInit>d__.<>4__this = this;
			<BgInit>d__.<>1__state = -1;
			<BgInit>d__.<>t__builder.Start<PayViewModel.<BgInit>d__50>(ref <BgInit>d__);
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x0003ACB8 File Offset: 0x00038EB8
		[Command]
		public void SelectionChanged()
		{
			this.CountSelected = this.SoldItems.Count((store_sales i) => i.isSelected);
			if (this.CountSelected != 0)
			{
				this.SummSelected = (from i in this.SoldItems
				where i.isSelected
				select i.RealizatorPart).DefaultIfEmpty<decimal>().Sum();
				return;
			}
			this.SummSelected = 0m;
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x0003AD68 File Offset: 0x00038F68
		[Command]
		public void Pay()
		{
			PayViewModel.<Pay>d__53 <Pay>d__;
			<Pay>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Pay>d__.<>4__this = this;
			<Pay>d__.<>1__state = -1;
			<Pay>d__.<>t__builder.Start<PayViewModel.<Pay>d__53>(ref <Pay>d__);
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x0003ADA0 File Offset: 0x00038FA0
		public bool CanPay()
		{
			return this._clientId != 0 && !this._payInProcess;
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x0003ADC0 File Offset: 0x00038FC0
		private void SetCanPay(bool can)
		{
			this._payInProcess = !can;
			base.RaiseCanExecuteChanged(() => this.Pay());
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x0003AE14 File Offset: 0x00039014
		private bool CheckFields()
		{
			if (this.CountSelected == 0)
			{
				this._toasterService.Info(Lang.t("SelectItem"));
				return false;
			}
			if (this.IsCorrectInput)
			{
				return true;
			}
			this._toasterService.Info(Lang.t("ConfirmData"));
			return false;
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x0003AE60 File Offset: 0x00039060
		[Command]
		public void Close()
		{
			this.CloseAction();
		}

		// Token: 0x06001701 RID: 5889 RVA: 0x0003AE78 File Offset: 0x00039078
		[CompilerGenerated]
		private Task<CustomerCard> <BgInit>b__50_2()
		{
			return ClientsModel.GetCustomerCard(this._clientId);
		}

		// Token: 0x06001702 RID: 5890 RVA: 0x0003AE90 File Offset: 0x00039090
		[CompilerGenerated]
		private void <BgInit>b__50_3(Task<CustomerCard> t)
		{
			this.Customer = t.Result;
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x0003AEAC File Offset: 0x000390AC
		[CompilerGenerated]
		private Task<IEnumerable<store_sales>> <BgInit>b__50_0()
		{
			return PayModel.LoadSoldItems(this._clientId);
		}

		// Token: 0x06001704 RID: 5892 RVA: 0x0003AEC4 File Offset: 0x000390C4
		[CompilerGenerated]
		private void <BgInit>b__50_1(Task<IEnumerable<store_sales>> t)
		{
			this.SoldItems = new ObservableCollection<store_sales>(t.Result);
		}

		// Token: 0x04000B52 RID: 2898
		private IToasterService _toasterService;

		// Token: 0x04000B53 RID: 2899
		[CompilerGenerated]
		private Action <CloseAction>k__BackingField;

		// Token: 0x04000B54 RID: 2900
		private int _clientId;

		// Token: 0x04000B55 RID: 2901
		private bool _selectAll;

		// Token: 0x04000B56 RID: 2902
		[CompilerGenerated]
		private ObservableCollection<store_sales> <SoldItems>k__BackingField;

		// Token: 0x04000B57 RID: 2903
		[CompilerGenerated]
		private store_sales <SelectedItem>k__BackingField;

		// Token: 0x04000B58 RID: 2904
		[CompilerGenerated]
		private int <CountSelected>k__BackingField;

		// Token: 0x04000B59 RID: 2905
		[CompilerGenerated]
		private decimal <SummSelected>k__BackingField;

		// Token: 0x04000B5A RID: 2906
		[CompilerGenerated]
		private bool <IsCorrectInput>k__BackingField;

		// Token: 0x04000B5B RID: 2907
		[CompilerGenerated]
		private bool <CreateRko>k__BackingField;

		// Token: 0x04000B5C RID: 2908
		[CompilerGenerated]
		private bool <PrintRko>k__BackingField;

		// Token: 0x04000B5D RID: 2909
		[CompilerGenerated]
		private bool <PrintDescription>k__BackingField;

		// Token: 0x04000B5E RID: 2910
		[CompilerGenerated]
		private ICustomer <Customer>k__BackingField;

		// Token: 0x04000B5F RID: 2911
		private bool _payInProcess;

		// Token: 0x02000166 RID: 358
		[CompilerGenerated]
		private sealed class <>c__DisplayClass49_0
		{
			// Token: 0x06001705 RID: 5893 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass49_0()
			{
			}

			// Token: 0x06001706 RID: 5894 RVA: 0x0003AEE4 File Offset: 0x000390E4
			internal Task<IEnumerable<store_sales>> <LoadExistPayment>b__0()
			{
				return PayModel.LoadExistPayment(this.paymentId);
			}

			// Token: 0x06001707 RID: 5895 RVA: 0x0003AEFC File Offset: 0x000390FC
			internal void <LoadExistPayment>b__1(Task<IEnumerable<store_sales>> t)
			{
				this.<>4__this.SoldItems = new ObservableCollection<store_sales>(t.Result);
				this.<>4__this.SelectAll = true;
				this.<>4__this.HideWait();
			}

			// Token: 0x04000B60 RID: 2912
			public int paymentId;

			// Token: 0x04000B61 RID: 2913
			public PayViewModel <>4__this;
		}

		// Token: 0x02000167 RID: 359
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <BgInit>d__50 : IAsyncStateMachine
		{
			// Token: 0x06001708 RID: 5896 RVA: 0x0003AF38 File Offset: 0x00039138
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PayViewModel payViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						payViewModel.ShowWait();
						List<Task> list = new List<Task>();
						if (payViewModel.Customer == null)
						{
							Task item = Task.Run<CustomerCard>(() => ClientsModel.GetCustomerCard(payViewModel._clientId)).ContinueWith(delegate(Task<CustomerCard> t)
							{
								base.Customer = t.Result;
							});
							list.Add(item);
						}
						Task item2 = Task.Run<IEnumerable<store_sales>>(() => PayModel.LoadSoldItems(payViewModel._clientId)).ContinueWith(delegate(Task<IEnumerable<store_sales>> t)
						{
							base.SoldItems = new ObservableCollection<store_sales>(t.Result);
						});
						list.Add(item2);
						awaiter = Task.WhenAll(list).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, PayViewModel.<BgInit>d__50>(ref awaiter, ref this);
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
					payViewModel.HideWait();
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

			// Token: 0x06001709 RID: 5897 RVA: 0x0003B064 File Offset: 0x00039264
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000B62 RID: 2914
			public int <>1__state;

			// Token: 0x04000B63 RID: 2915
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000B64 RID: 2916
			public PayViewModel <>4__this;

			// Token: 0x04000B65 RID: 2917
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000168 RID: 360
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600170A RID: 5898 RVA: 0x0003B080 File Offset: 0x00039280
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600170B RID: 5899 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x0600170C RID: 5900 RVA: 0x0003B098 File Offset: 0x00039298
			internal bool <SelectionChanged>b__51_0(store_sales i)
			{
				return i.isSelected;
			}

			// Token: 0x0600170D RID: 5901 RVA: 0x0003B098 File Offset: 0x00039298
			internal bool <SelectionChanged>b__51_1(store_sales i)
			{
				return i.isSelected;
			}

			// Token: 0x0600170E RID: 5902 RVA: 0x0003A344 File Offset: 0x00038544
			internal decimal <SelectionChanged>b__51_2(store_sales i)
			{
				return i.RealizatorPart;
			}

			// Token: 0x0600170F RID: 5903 RVA: 0x0003B098 File Offset: 0x00039298
			internal bool <Pay>b__53_0(store_sales i)
			{
				return i.isSelected;
			}

			// Token: 0x04000B66 RID: 2918
			public static readonly PayViewModel.<>c <>9 = new PayViewModel.<>c();

			// Token: 0x04000B67 RID: 2919
			public static Func<store_sales, bool> <>9__51_0;

			// Token: 0x04000B68 RID: 2920
			public static Func<store_sales, bool> <>9__51_1;

			// Token: 0x04000B69 RID: 2921
			public static Func<store_sales, decimal> <>9__51_2;

			// Token: 0x04000B6A RID: 2922
			public static Func<store_sales, bool> <>9__53_0;
		}

		// Token: 0x02000169 RID: 361
		[CompilerGenerated]
		private sealed class <>c__DisplayClass53_0
		{
			// Token: 0x06001710 RID: 5904 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass53_0()
			{
			}

			// Token: 0x06001711 RID: 5905 RVA: 0x0003B0AC File Offset: 0x000392AC
			internal IAscResult <Pay>b__1()
			{
				return PayModel.MakePayment(this.selected, this.<>4__this._clientId, this.<>4__this.CreateRko);
			}

			// Token: 0x04000B6B RID: 2923
			public List<store_sales> selected;

			// Token: 0x04000B6C RID: 2924
			public PayViewModel <>4__this;
		}

		// Token: 0x0200016A RID: 362
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Pay>d__53 : IAsyncStateMachine
		{
			// Token: 0x06001712 RID: 5906 RVA: 0x0003B0DC File Offset: 0x000392DC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PayViewModel payViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IAscResult> awaiter;
					TaskAwaiter<CashOutOrder> awaiter2;
					TaskAwaiter<XtraReport> awaiter3;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IAscResult>);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<CashOutOrder>);
						this.<>1__state = -1;
						goto IL_1A4;
					case 2:
						awaiter3 = this.<>u__3;
						this.<>u__3 = default(TaskAwaiter<XtraReport>);
						this.<>1__state = -1;
						goto IL_1FE;
					default:
					{
						PayViewModel.<>c__DisplayClass53_0 CS$<>8__locals1 = new PayViewModel.<>c__DisplayClass53_0();
						CS$<>8__locals1.<>4__this = this.<>4__this;
						if (!payViewModel.CheckFields())
						{
							goto IL_233;
						}
						payViewModel.SetCanPay(false);
						CS$<>8__locals1.selected = payViewModel.SoldItems.Where(new Func<store_sales, bool>(PayViewModel.<>c.<>9.<Pay>b__53_0)).ToList<store_sales>();
						if (CS$<>8__locals1.selected.Count <= 0)
						{
							goto IL_233;
						}
						awaiter = Task.Run<IAscResult>(new Func<IAscResult>(CS$<>8__locals1.<Pay>b__1)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IAscResult>, PayViewModel.<Pay>d__53>(ref awaiter, ref this);
							return;
						}
						break;
					}
					}
					IAscResult result = awaiter.GetResult();
					if (result.IsSucces)
					{
						payViewModel._toasterService.Success(Lang.t("Complete"));
					}
					else
					{
						payViewModel._toasterService.Error("");
					}
					if (!payViewModel.CreateRko || !payViewModel.PrintRko || !result.IsSucces)
					{
						goto IL_211;
					}
					awaiter2 = KassaModel.GetCashOutOrder(result.Id).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<CashOutOrder>, PayViewModel.<Pay>d__53>(ref awaiter2, ref this);
						return;
					}
					IL_1A4:
					awaiter3 = awaiter2.GetResult().CreateReport().GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__3 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XtraReport>, PayViewModel.<Pay>d__53>(ref awaiter3, ref this);
						return;
					}
					IL_1FE:
					XtraReport result2 = awaiter3.GetResult();
					result2.ShowRibbonPreview();
					result2.PrintDialog();
					IL_211:
					payViewModel.SetCanPay(true);
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_233:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06001713 RID: 5907 RVA: 0x0003B34C File Offset: 0x0003954C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000B6D RID: 2925
			public int <>1__state;

			// Token: 0x04000B6E RID: 2926
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000B6F RID: 2927
			public PayViewModel <>4__this;

			// Token: 0x04000B70 RID: 2928
			private TaskAwaiter<IAscResult> <>u__1;

			// Token: 0x04000B71 RID: 2929
			private TaskAwaiter<CashOutOrder> <>u__2;

			// Token: 0x04000B72 RID: 2930
			private TaskAwaiter<XtraReport> <>u__3;
		}
	}
}
