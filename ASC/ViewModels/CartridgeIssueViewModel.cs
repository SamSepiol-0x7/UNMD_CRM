using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Options;
using ASC.Services.Abstract;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;

namespace ASC.ViewModels
{
	// Token: 0x020003AD RID: 941
	public class CartridgeIssueViewModel : PopupViewModel
	{
		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x06002768 RID: 10088 RVA: 0x00078688 File Offset: 0x00076888
		// (set) Token: 0x06002769 RID: 10089 RVA: 0x0007869C File Offset: 0x0007689C
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

		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x0600276A RID: 10090 RVA: 0x000786CC File Offset: 0x000768CC
		// (set) Token: 0x0600276B RID: 10091 RVA: 0x000786E0 File Offset: 0x000768E0
		public ObservableCollection<CartridgeEx> Cartridges
		{
			[CompilerGenerated]
			get
			{
				return this.<Cartridges>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(this.<Cartridges>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 2106250919;
				IL_13:
				switch ((num ^ 1276512674) % 4)
				{
				case 0:
					IL_32:
					num = 1621364784;
					goto IL_13;
				case 1:
					return;
				case 3:
					goto IL_0E;
				}
				this.<Cartridges>k__BackingField = value;
				this.RaisePropertyChanged("Cartridges");
			}
		}

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x0600276C RID: 10092 RVA: 0x00046F70 File Offset: 0x00045170
		public bool CanPrintCheque
		{
			get
			{
				return OfflineData.Instance.Employee.KktReady();
			}
		}

		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x0600276D RID: 10093 RVA: 0x0007873C File Offset: 0x0007693C
		// (set) Token: 0x0600276E RID: 10094 RVA: 0x00078750 File Offset: 0x00076950
		public bool PrintCheque
		{
			[CompilerGenerated]
			get
			{
				return this.<PrintCheque>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PrintCheque>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = 1990860607;
				IL_10:
				switch ((num ^ 952997682) % 4)
				{
				case 0:
					goto IL_0B;
				case 1:
					return;
				case 3:
					IL_2F:
					this.<PrintCheque>k__BackingField = value;
					this.RaisePropertyChanged("PrintCheque");
					num = 212607328;
					goto IL_10;
				}
			}
		}

		// Token: 0x17000D7F RID: 3455
		// (get) Token: 0x0600276F RID: 10095 RVA: 0x000787A8 File Offset: 0x000769A8
		// (set) Token: 0x06002770 RID: 10096 RVA: 0x000787BC File Offset: 0x000769BC
		public bool SendChequeToEmail
		{
			[CompilerGenerated]
			get
			{
				return this.<SendChequeToEmail>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SendChequeToEmail>k__BackingField == value)
				{
					return;
				}
				this.<SendChequeToEmail>k__BackingField = value;
				this.RaisePropertyChanged("SendChequeToEmail");
			}
		}

		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x06002771 RID: 10097 RVA: 0x000787E8 File Offset: 0x000769E8
		// (set) Token: 0x06002772 RID: 10098 RVA: 0x000787FC File Offset: 0x000769FC
		public string CustomerEmail
		{
			[CompilerGenerated]
			get
			{
				return this.<CustomerEmail>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<CustomerEmail>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<CustomerEmail>k__BackingField = value;
				this.RaisePropertyChanged("CustomerEmail");
			}
		}

		// Token: 0x17000D81 RID: 3457
		// (get) Token: 0x06002773 RID: 10099 RVA: 0x0007882C File Offset: 0x00076A2C
		// (set) Token: 0x06002774 RID: 10100 RVA: 0x00078870 File Offset: 0x00076A70
		public int PaymentSystem
		{
			get
			{
				return base.GetProperty<int>(() => this.PaymentSystem);
			}
			set
			{
				if (this.PaymentSystem == value)
				{
					return;
				}
				base.SetProperty<int>(() => this.PaymentSystem, value, new Action(this.OnPaymentSystemChanged));
				this.RaisePropertyChanged("PaymentSystem");
			}
		}

		// Token: 0x17000D82 RID: 3458
		// (get) Token: 0x06002775 RID: 10101 RVA: 0x000788D8 File Offset: 0x00076AD8
		// (set) Token: 0x06002776 RID: 10102 RVA: 0x000788EC File Offset: 0x00076AEC
		public bool CustomerBalanceVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<CustomerBalanceVisible>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<CustomerBalanceVisible>k__BackingField == value)
				{
					return;
				}
				this.<CustomerBalanceVisible>k__BackingField = value;
				this.RaisePropertyChanged("CustomerBalanceVisible");
			}
		}

		// Token: 0x06002777 RID: 10103 RVA: 0x00078918 File Offset: 0x00076B18
		private void OnPaymentSystemChanged()
		{
			this.CustomerBalanceVisible = (this.PaymentSystem == -2);
		}

		// Token: 0x17000D83 RID: 3459
		// (get) Token: 0x06002778 RID: 10104 RVA: 0x00078938 File Offset: 0x00076B38
		// (set) Token: 0x06002779 RID: 10105 RVA: 0x0007894C File Offset: 0x00076B4C
		public bool PayCheck
		{
			[CompilerGenerated]
			get
			{
				return this.<PayCheck>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PayCheck>k__BackingField == value)
				{
					return;
				}
				this.<PayCheck>k__BackingField = value;
				this.RaisePropertyChanged("PayCheck");
			}
		}

		// Token: 0x17000D84 RID: 3460
		// (get) Token: 0x0600277A RID: 10106 RVA: 0x00078978 File Offset: 0x00076B78
		// (set) Token: 0x0600277B RID: 10107 RVA: 0x0007898C File Offset: 0x00076B8C
		public bool PrintWorksDoc
		{
			[CompilerGenerated]
			get
			{
				return this.<PrintWorksDoc>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PrintWorksDoc>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -454465608;
				IL_10:
				switch ((num ^ -953685299) % 4)
				{
				case 1:
					return;
				case 2:
					goto IL_0B;
				case 3:
					IL_2F:
					this.<PrintWorksDoc>k__BackingField = value;
					num = -2042647819;
					goto IL_10;
				}
				this.RaisePropertyChanged("PrintWorksDoc");
			}
		}

		// Token: 0x17000D85 RID: 3461
		// (get) Token: 0x0600277C RID: 10108 RVA: 0x000789E4 File Offset: 0x00076BE4
		// (set) Token: 0x0600277D RID: 10109 RVA: 0x000789F8 File Offset: 0x00076BF8
		public decimal Total
		{
			[CompilerGenerated]
			get
			{
				return this.<Total>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<Total>k__BackingField, value))
				{
					return;
				}
				this.<Total>k__BackingField = value;
				this.RaisePropertyChanged("Total");
			}
		}

		// Token: 0x17000D86 RID: 3462
		// (get) Token: 0x0600277E RID: 10110 RVA: 0x00078A28 File Offset: 0x00076C28
		// (set) Token: 0x0600277F RID: 10111 RVA: 0x00078A3C File Offset: 0x00076C3C
		public decimal PrePaid
		{
			[CompilerGenerated]
			get
			{
				return this.<PrePaid>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<PrePaid>k__BackingField, value))
				{
					return;
				}
				this.<PrePaid>k__BackingField = value;
				this.RaisePropertyChanged("PrePaid");
			}
		}

		// Token: 0x17000D87 RID: 3463
		// (get) Token: 0x06002780 RID: 10112 RVA: 0x00078A6C File Offset: 0x00076C6C
		// (set) Token: 0x06002781 RID: 10113 RVA: 0x00078A80 File Offset: 0x00076C80
		public decimal FinalAmount
		{
			[CompilerGenerated]
			get
			{
				return this.<FinalAmount>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!decimal.Equals(this.<FinalAmount>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 943458467;
				IL_13:
				switch ((num ^ 1847130430) % 4)
				{
				case 0:
					IL_32:
					this.<FinalAmount>k__BackingField = value;
					this.RaisePropertyChanged("FinalAmount");
					num = 1145108353;
					goto IL_13;
				case 1:
					return;
				case 2:
					goto IL_0E;
				}
			}
		}

		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x06002782 RID: 10114 RVA: 0x00078ADC File Offset: 0x00076CDC
		// (set) Token: 0x06002783 RID: 10115 RVA: 0x00078AF0 File Offset: 0x00076CF0
		public List<PaymentOptions> PaymentOptions
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentOptions>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<PaymentOptions>k__BackingField, value))
				{
					return;
				}
				this.<PaymentOptions>k__BackingField = value;
				this.RaisePropertyChanged("PaymentOptions");
			}
		}

		// Token: 0x06002784 RID: 10116 RVA: 0x00078B20 File Offset: 0x00076D20
		public CartridgeIssueViewModel(IToasterService toasterService, ICustomerService customerService, ICartridgeService cartridgeService)
		{
			this._toasterService = toasterService;
			this._customerService = customerService;
			this._cartridgeService = cartridgeService;
			base.SetTitle(Lang.t("DeviceOut"));
		}

		// Token: 0x06002785 RID: 10117 RVA: 0x00078B60 File Offset: 0x00076D60
		[AsyncCommand]
		public Task MakeIssue()
		{
			CartridgeIssueViewModel.<MakeIssue>d__59 <MakeIssue>d__;
			<MakeIssue>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<MakeIssue>d__.<>4__this = this;
			<MakeIssue>d__.<>1__state = -1;
			<MakeIssue>d__.<>t__builder.Start<CartridgeIssueViewModel.<MakeIssue>d__59>(ref <MakeIssue>d__);
			return <MakeIssue>d__.<>t__builder.Task;
		}

		// Token: 0x06002786 RID: 10118 RVA: 0x00078BA4 File Offset: 0x00076DA4
		private bool CheckIssue()
		{
			if (!this.PayCheck)
			{
				this._toasterService.Info(Lang.t("ConfirmPayment"));
				return false;
			}
			return true;
		}

		// Token: 0x06002787 RID: 10119 RVA: 0x00078BD4 File Offset: 0x00076DD4
		private void PrintWorksDocument()
		{
			CartridgeIssueViewModel.<>c__DisplayClass61_0 CS$<>8__locals1 = new CartridgeIssueViewModel.<>c__DisplayClass61_0();
			CS$<>8__locals1.<>4__this = this;
			base.ShowWait();
			CS$<>8__locals1.ids = (from c in this.Cartridges
			select c.Id).ToList<int>();
			Task.Run<CartridgeIssueReport>(() => CS$<>8__locals1.<>4__this._cartridgeService.GetIssueCartridgeReport(CS$<>8__locals1.ids)).ContinueWith<Task>(delegate(Task<CartridgeIssueReport> t)
			{
				CartridgeIssueViewModel.<>c__DisplayClass61_0.<<PrintWorksDocument>b__2>d <<PrintWorksDocument>b__2>d;
				<<PrintWorksDocument>b__2>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<PrintWorksDocument>b__2>d.<>4__this = CS$<>8__locals1;
				<<PrintWorksDocument>b__2>d.t = t;
				<<PrintWorksDocument>b__2>d.<>1__state = -1;
				<<PrintWorksDocument>b__2>d.<>t__builder.Start<CartridgeIssueViewModel.<>c__DisplayClass61_0.<<PrintWorksDocument>b__2>d>(ref <<PrintWorksDocument>b__2>d);
				return <<PrintWorksDocument>b__2>d.<>t__builder.Task;
			}, TaskScheduler.FromCurrentSynchronizationContext());
		}

		// Token: 0x06002788 RID: 10120 RVA: 0x00078C54 File Offset: 0x00076E54
		[Command]
		public void HideIssue()
		{
			base.ClosePopup();
		}

		// Token: 0x06002789 RID: 10121 RVA: 0x00078C68 File Offset: 0x00076E68
		[Command]
		public void SendChequeChanged()
		{
			if (!this.SendChequeToEmail)
			{
				this.CustomerEmail = "";
			}
		}

		// Token: 0x17000D89 RID: 3465
		// (get) Token: 0x0600278A RID: 10122 RVA: 0x00078C88 File Offset: 0x00076E88
		// (set) Token: 0x0600278B RID: 10123 RVA: 0x00078C9C File Offset: 0x00076E9C
		public string OutMessage
		{
			[CompilerGenerated]
			get
			{
				return this.<OutMessage>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (string.Equals(this.<OutMessage>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<OutMessage>k__BackingField = value;
				this.RaisePropertyChanged("OutMessage");
			}
		}

		// Token: 0x0600278C RID: 10124 RVA: 0x00078CCC File Offset: 0x00076ECC
		private void CreateOutMessage()
		{
			this.OutMessage = string.Empty;
			if (this.Cartridges.Count != 1)
			{
				foreach (CartridgeEx cartridgeEx in this.Cartridges)
				{
					if (!string.IsNullOrEmpty(cartridgeEx.OutMessage))
					{
						this.OutMessage = string.Concat(new string[]
						{
							this.OutMessage,
							cartridgeEx.MakerName,
							" ",
							cartridgeEx.Name,
							": ",
							cartridgeEx.OutMessage,
							Environment.NewLine
						});
					}
				}
				return;
			}
			CartridgeEx cartridgeEx2 = this.Cartridges.FirstOrDefault<CartridgeEx>();
			this.OutMessage = ((cartridgeEx2 != null) ? cartridgeEx2.OutMessage : null);
		}

		// Token: 0x0600278D RID: 10125 RVA: 0x00078DA8 File Offset: 0x00076FA8
		public override void OnLoad()
		{
			CartridgeIssueViewModel.<OnLoad>d__69 <OnLoad>d__;
			<OnLoad>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnLoad>d__.<>4__this = this;
			<OnLoad>d__.<>1__state = -1;
			<OnLoad>d__.<>t__builder.Start<CartridgeIssueViewModel.<OnLoad>d__69>(ref <OnLoad>d__);
		}

		// Token: 0x0600278E RID: 10126 RVA: 0x00078DE0 File Offset: 0x00076FE0
		protected override void OnParentViewModelChanged(object parentViewModel)
		{
			this._parentViewModel = (parentViewModel as IRefreshable);
			base.OnParentViewModelChanged(parentViewModel);
		}

		// Token: 0x0600278F RID: 10127 RVA: 0x00078E00 File Offset: 0x00077000
		private void CalcTotal()
		{
			this.Total = this.Cartridges.Sum((CartridgeEx c) => c.Total);
			for (;;)
			{
				IL_C0:
				int num = 330308210;
				for (;;)
				{
					switch ((num ^ 1721946375) % 4)
					{
					case 0:
						goto IL_C0;
					case 1:
						this.PrePaid = this.Cartridges.Sum((CartridgeEx c) => c.PrePaid);
						num = 1002023037;
						continue;
					case 2:
						this.FinalAmount = this.Cartridges.Sum((CartridgeEx c) => c.FinalAmount);
						num = 739866752;
						continue;
					}
					return;
				}
			}
		}

		// Token: 0x06002790 RID: 10128 RVA: 0x00078ED4 File Offset: 0x000770D4
		public void SetCartridges(ObservableCollection<CartridgeEx> cartridges)
		{
			this.Cartridges = cartridges;
		}

		// Token: 0x06002791 RID: 10129 RVA: 0x00078EE8 File Offset: 0x000770E8
		[CompilerGenerated]
		private Task<Result> <MakeIssue>b__59_0()
		{
			return this._cartridgeService.IssueCartridges(this.Cartridges, this.PaymentSystem);
		}

		// Token: 0x06002792 RID: 10130 RVA: 0x0003401C File Offset: 0x0003221C
		[CompilerGenerated]
		[DebuggerHidden]
		private void <>n__0()
		{
			base.OnLoad();
		}

		// Token: 0x04001560 RID: 5472
		private readonly IToasterService _toasterService;

		// Token: 0x04001561 RID: 5473
		private readonly ICustomerService _customerService;

		// Token: 0x04001562 RID: 5474
		private readonly ICartridgeService _cartridgeService;

		// Token: 0x04001563 RID: 5475
		private IRefreshable _parentViewModel;

		// Token: 0x04001564 RID: 5476
		[CompilerGenerated]
		private ICustomer <Customer>k__BackingField;

		// Token: 0x04001565 RID: 5477
		[CompilerGenerated]
		private ObservableCollection<CartridgeEx> <Cartridges>k__BackingField;

		// Token: 0x04001566 RID: 5478
		[CompilerGenerated]
		private bool <PrintCheque>k__BackingField;

		// Token: 0x04001567 RID: 5479
		[CompilerGenerated]
		private bool <SendChequeToEmail>k__BackingField;

		// Token: 0x04001568 RID: 5480
		[CompilerGenerated]
		private string <CustomerEmail>k__BackingField;

		// Token: 0x04001569 RID: 5481
		[CompilerGenerated]
		private bool <CustomerBalanceVisible>k__BackingField;

		// Token: 0x0400156A RID: 5482
		[CompilerGenerated]
		private bool <PayCheck>k__BackingField;

		// Token: 0x0400156B RID: 5483
		[CompilerGenerated]
		private bool <PrintWorksDoc>k__BackingField = true;

		// Token: 0x0400156C RID: 5484
		[CompilerGenerated]
		private decimal <Total>k__BackingField;

		// Token: 0x0400156D RID: 5485
		[CompilerGenerated]
		private decimal <PrePaid>k__BackingField;

		// Token: 0x0400156E RID: 5486
		[CompilerGenerated]
		private decimal <FinalAmount>k__BackingField;

		// Token: 0x0400156F RID: 5487
		[CompilerGenerated]
		private List<PaymentOptions> <PaymentOptions>k__BackingField;

		// Token: 0x04001570 RID: 5488
		[CompilerGenerated]
		private string <OutMessage>k__BackingField;

		// Token: 0x020003AE RID: 942
		[CompilerGenerated]
		private sealed class <>c__DisplayClass59_0
		{
			// Token: 0x06002793 RID: 10131 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass59_0()
			{
			}

			// Token: 0x06002794 RID: 10132 RVA: 0x00078F0C File Offset: 0x0007710C
			internal IAscResult <MakeIssue>b__1()
			{
				return OfflineData.Instance.Employee.Kkt.RepairCheck(this.<>4__this.Cartridges, this.result.Ids, this.<>4__this.CustomerEmail, this.<>4__this.PaymentSystem);
			}

			// Token: 0x04001571 RID: 5489
			public Result result;

			// Token: 0x04001572 RID: 5490
			public CartridgeIssueViewModel <>4__this;
		}

		// Token: 0x020003AF RID: 943
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <MakeIssue>d__59 : IAsyncStateMachine
		{
			// Token: 0x06002795 RID: 10133 RVA: 0x00078F5C File Offset: 0x0007715C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CartridgeIssueViewModel cartridgeIssueViewModel = this.<>4__this;
				try
				{
					if (num > 1)
					{
						if (!cartridgeIssueViewModel.CheckIssue())
						{
							goto IL_1CC;
						}
						cartridgeIssueViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter<IAscResult> awaiter;
						TaskAwaiter<Result> awaiter2;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<IAscResult>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								goto IL_13B;
							}
							this.<>8__1 = new CartridgeIssueViewModel.<>c__DisplayClass59_0();
							this.<>8__1.<>4__this = cartridgeIssueViewModel;
							awaiter2 = Task.Run<Result>(() => cartridgeIssueViewModel._cartridgeService.IssueCartridges(base.Cartridges, base.PaymentSystem)).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num3 = 0;
								num = 0;
								this.<>1__state = num3;
								this.<>u__1 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Result>, CartridgeIssueViewModel.<MakeIssue>d__59>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<Result>);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
						}
						Result result = awaiter2.GetResult();
						this.<>8__1.result = result;
						cartridgeIssueViewModel._toasterService.Success("");
						cartridgeIssueViewModel.ClosePopup();
						if (cartridgeIssueViewModel.PrintWorksDoc)
						{
							cartridgeIssueViewModel.PrintWorksDocument();
						}
						cartridgeIssueViewModel._parentViewModel.DataRefresh();
						if (!cartridgeIssueViewModel.PrintCheque)
						{
							goto IL_164;
						}
						awaiter = Task.Run<IAscResult>(new Func<IAscResult>(this.<>8__1.<MakeIssue>b__1)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num5 = 1;
							num = 1;
							this.<>1__state = num5;
							this.<>u__2 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IAscResult>, CartridgeIssueViewModel.<MakeIssue>d__59>(ref awaiter, ref this);
							return;
						}
						IL_13B:
						if (!awaiter.GetResult().IsSucces)
						{
							cartridgeIssueViewModel._toasterService.Error(this.<>8__1.result.Message);
						}
						IL_164:
						this.<>8__1 = null;
					}
					catch (Exception ex)
					{
						cartridgeIssueViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							cartridgeIssueViewModel.HideWait();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_1CC:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002796 RID: 10134 RVA: 0x00079194 File Offset: 0x00077394
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001573 RID: 5491
			public int <>1__state;

			// Token: 0x04001574 RID: 5492
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001575 RID: 5493
			public CartridgeIssueViewModel <>4__this;

			// Token: 0x04001576 RID: 5494
			private CartridgeIssueViewModel.<>c__DisplayClass59_0 <>8__1;

			// Token: 0x04001577 RID: 5495
			private TaskAwaiter<Result> <>u__1;

			// Token: 0x04001578 RID: 5496
			private TaskAwaiter<IAscResult> <>u__2;
		}

		// Token: 0x020003B0 RID: 944
		[CompilerGenerated]
		private sealed class <>c__DisplayClass61_0
		{
			// Token: 0x06002797 RID: 10135 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass61_0()
			{
			}

			// Token: 0x06002798 RID: 10136 RVA: 0x000791B0 File Offset: 0x000773B0
			internal Task<CartridgeIssueReport> <PrintWorksDocument>b__1()
			{
				return this.<>4__this._cartridgeService.GetIssueCartridgeReport(this.ids);
			}

			// Token: 0x06002799 RID: 10137 RVA: 0x000791D4 File Offset: 0x000773D4
			internal Task <PrintWorksDocument>b__2(Task<CartridgeIssueReport> t)
			{
				CartridgeIssueViewModel.<>c__DisplayClass61_0.<<PrintWorksDocument>b__2>d <<PrintWorksDocument>b__2>d;
				<<PrintWorksDocument>b__2>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<PrintWorksDocument>b__2>d.<>4__this = this;
				<<PrintWorksDocument>b__2>d.t = t;
				<<PrintWorksDocument>b__2>d.<>1__state = -1;
				<<PrintWorksDocument>b__2>d.<>t__builder.Start<CartridgeIssueViewModel.<>c__DisplayClass61_0.<<PrintWorksDocument>b__2>d>(ref <<PrintWorksDocument>b__2>d);
				return <<PrintWorksDocument>b__2>d.<>t__builder.Task;
			}

			// Token: 0x04001579 RID: 5497
			public CartridgeIssueViewModel <>4__this;

			// Token: 0x0400157A RID: 5498
			public List<int> ids;

			// Token: 0x020003B1 RID: 945
			[StructLayout(LayoutKind.Auto)]
			private struct <<PrintWorksDocument>b__2>d : IAsyncStateMachine
			{
				// Token: 0x0600279A RID: 10138 RVA: 0x00079220 File Offset: 0x00077420
				void IAsyncStateMachine.MoveNext()
				{
					int num = this.<>1__state;
					CartridgeIssueViewModel.<>c__DisplayClass61_0 CS$<>8__locals1 = this.<>4__this;
					try
					{
						TaskAwaiter<XtraReport> awaiter;
						if (num != 0)
						{
							awaiter = ReportPrintModel.CreateReport("issue_cartridge", this.t.Result).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XtraReport>, CartridgeIssueViewModel.<>c__DisplayClass61_0.<<PrintWorksDocument>b__2>d>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<XtraReport>);
							this.<>1__state = -1;
						}
						XtraReport result = awaiter.GetResult();
						CS$<>8__locals1.<>4__this.HideWait();
						DevExpress.XtraReports.IReport report;
						if (result == null)
						{
							report = result;
							if (result == null)
							{
								goto IL_9D;
							}
						}
						else
						{
							result.ShowRibbonPreview();
							report = result;
							if (result == null)
							{
								goto IL_9D;
							}
						}
						report.PrintDialog();
						IL_9D:;
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

				// Token: 0x0600279B RID: 10139 RVA: 0x00079308 File Offset: 0x00077508
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x0400157B RID: 5499
				public int <>1__state;

				// Token: 0x0400157C RID: 5500
				public AsyncTaskMethodBuilder <>t__builder;

				// Token: 0x0400157D RID: 5501
				public Task<CartridgeIssueReport> t;

				// Token: 0x0400157E RID: 5502
				public CartridgeIssueViewModel.<>c__DisplayClass61_0 <>4__this;

				// Token: 0x0400157F RID: 5503
				private TaskAwaiter<XtraReport> <>u__1;
			}
		}

		// Token: 0x020003B2 RID: 946
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600279C RID: 10140 RVA: 0x00079324 File Offset: 0x00077524
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600279D RID: 10141 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x0600279E RID: 10142 RVA: 0x0007933C File Offset: 0x0007753C
			internal int <PrintWorksDocument>b__61_0(CartridgeEx c)
			{
				return c.Id;
			}

			// Token: 0x0600279F RID: 10143 RVA: 0x00079350 File Offset: 0x00077550
			internal int <OnLoad>b__69_0(CartridgeEx c)
			{
				return c.CustomerId;
			}

			// Token: 0x060027A0 RID: 10144 RVA: 0x00079364 File Offset: 0x00077564
			internal decimal <CalcTotal>b__71_0(CartridgeEx c)
			{
				return c.Total;
			}

			// Token: 0x060027A1 RID: 10145 RVA: 0x00079378 File Offset: 0x00077578
			internal decimal <CalcTotal>b__71_1(CartridgeEx c)
			{
				return c.PrePaid;
			}

			// Token: 0x060027A2 RID: 10146 RVA: 0x0007938C File Offset: 0x0007758C
			internal decimal <CalcTotal>b__71_2(CartridgeEx c)
			{
				return c.FinalAmount;
			}

			// Token: 0x04001580 RID: 5504
			public static readonly CartridgeIssueViewModel.<>c <>9 = new CartridgeIssueViewModel.<>c();

			// Token: 0x04001581 RID: 5505
			public static Func<CartridgeEx, int> <>9__61_0;

			// Token: 0x04001582 RID: 5506
			public static Func<CartridgeEx, int> <>9__69_0;

			// Token: 0x04001583 RID: 5507
			public static Func<CartridgeEx, decimal> <>9__71_0;

			// Token: 0x04001584 RID: 5508
			public static Func<CartridgeEx, decimal> <>9__71_1;

			// Token: 0x04001585 RID: 5509
			public static Func<CartridgeEx, decimal> <>9__71_2;
		}

		// Token: 0x020003B3 RID: 947
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnLoad>d__69 : IAsyncStateMachine
		{
			// Token: 0x060027A3 RID: 10147 RVA: 0x000793A0 File Offset: 0x000775A0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CartridgeIssueViewModel cartridgeIssueViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<ICustomer> awaiter;
					if (num != 0)
					{
						cartridgeIssueViewModel.<>n__0();
						cartridgeIssueViewModel.ShowWait();
						this.<paymentOptions>5__2 = new List<PaymentOptions>(OfflineData.Instance.PaymentOptionses);
						int customerId = cartridgeIssueViewModel.Cartridges.Select(new Func<CartridgeEx, int>(CartridgeIssueViewModel.<>c.<>9.<OnLoad>b__69_0)).FirstOrDefault<int>();
						awaiter = cartridgeIssueViewModel._customerService.GetCustomerCardAsync(customerId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ICustomer>, CartridgeIssueViewModel.<OnLoad>d__69>(ref awaiter, ref this);
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
					cartridgeIssueViewModel.Customer = result;
					if (cartridgeIssueViewModel.Customer.BalanceEnabled)
					{
						this.<paymentOptions>5__2.Add(new PaymentOptions
						{
							Id = -2,
							Name = Lang.t("Label10")
						});
					}
					cartridgeIssueViewModel.PaymentOptions = this.<paymentOptions>5__2;
					cartridgeIssueViewModel.CreateOutMessage();
					cartridgeIssueViewModel.CalcTotal();
					cartridgeIssueViewModel.HideWait();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<paymentOptions>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<paymentOptions>5__2 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060027A4 RID: 10148 RVA: 0x0007952C File Offset: 0x0007772C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001586 RID: 5510
			public int <>1__state;

			// Token: 0x04001587 RID: 5511
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001588 RID: 5512
			public CartridgeIssueViewModel <>4__this;

			// Token: 0x04001589 RID: 5513
			private List<PaymentOptions> <paymentOptions>5__2;

			// Token: 0x0400158A RID: 5514
			private TaskAwaiter<ICustomer> <>u__1;
		}
	}
}
