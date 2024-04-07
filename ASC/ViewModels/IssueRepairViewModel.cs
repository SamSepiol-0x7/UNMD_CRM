using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Options;
using ASC.PKO;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.XtraReports.UI;

namespace ASC.ViewModels
{
	// Token: 0x020003FA RID: 1018
	public class IssueRepairViewModel : PopupViewModel
	{
		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x06002928 RID: 10536 RVA: 0x000801D4 File Offset: 0x0007E3D4
		// (set) Token: 0x06002929 RID: 10537 RVA: 0x000801E8 File Offset: 0x0007E3E8
		public int RepairId
		{
			[CompilerGenerated]
			get
			{
				return this.<RepairId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<RepairId>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = 136713991;
				IL_10:
				switch ((num ^ 1714748977) % 4)
				{
				case 0:
					goto IL_0B;
				case 1:
					IL_2F:
					this.<RepairId>k__BackingField = value;
					num = 199231450;
					goto IL_10;
				case 2:
					return;
				}
				this.RaisePropertyChanged("RepairId");
			}
		}

		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x0600292A RID: 10538 RVA: 0x00080240 File Offset: 0x0007E440
		// (set) Token: 0x0600292B RID: 10539 RVA: 0x00080254 File Offset: 0x0007E454
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

		// Token: 0x17000DC1 RID: 3521
		// (get) Token: 0x0600292C RID: 10540 RVA: 0x00080284 File Offset: 0x0007E484
		// (set) Token: 0x0600292D RID: 10541 RVA: 0x00080298 File Offset: 0x0007E498
		public workshop Repair
		{
			[CompilerGenerated]
			get
			{
				return this.<Repair>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Repair>k__BackingField, value))
				{
					return;
				}
				this.<Repair>k__BackingField = value;
				this.RaisePropertyChanged("Repair");
			}
		}

		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x0600292E RID: 10542 RVA: 0x000802C8 File Offset: 0x0007E4C8
		// (set) Token: 0x0600292F RID: 10543 RVA: 0x000802DC File Offset: 0x0007E4DC
		public bool ConfirmOutWithoutRepair
		{
			[CompilerGenerated]
			get
			{
				return this.<ConfirmOutWithoutRepair>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ConfirmOutWithoutRepair>k__BackingField == value)
				{
					return;
				}
				this.<ConfirmOutWithoutRepair>k__BackingField = value;
				this.RaisePropertyChanged("ConfirmOutWithoutRepair");
			}
		}

		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x06002930 RID: 10544 RVA: 0x00080308 File Offset: 0x0007E508
		// (set) Token: 0x06002931 RID: 10545 RVA: 0x0008031C File Offset: 0x0007E51C
		public decimal RepairCostTotal
		{
			[CompilerGenerated]
			get
			{
				return this.<RepairCostTotal>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (decimal.Equals(this.<RepairCostTotal>k__BackingField, value))
				{
					return;
				}
				this.<RepairCostTotal>k__BackingField = value;
				this.RaisePropertyChanged("RepairCostTotal");
			}
		}

		// Token: 0x17000DC4 RID: 3524
		// (get) Token: 0x06002932 RID: 10546 RVA: 0x0008034C File Offset: 0x0007E54C
		// (set) Token: 0x06002933 RID: 10547 RVA: 0x00080360 File Offset: 0x0007E560
		public decimal FinalAmount
		{
			[CompilerGenerated]
			get
			{
				return this.<FinalAmount>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (decimal.Equals(this.<FinalAmount>k__BackingField, value))
				{
					return;
				}
				this.<FinalAmount>k__BackingField = value;
				this.RaisePropertyChanged("FinalAmount");
			}
		}

		// Token: 0x17000DC5 RID: 3525
		// (get) Token: 0x06002934 RID: 10548 RVA: 0x00080390 File Offset: 0x0007E590
		// (set) Token: 0x06002935 RID: 10549 RVA: 0x000803A4 File Offset: 0x0007E5A4
		public decimal AlreadyPayed
		{
			[CompilerGenerated]
			get
			{
				return this.<AlreadyPayed>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!decimal.Equals(this.<AlreadyPayed>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1643113900;
				IL_13:
				switch ((num ^ 475987137) % 4)
				{
				case 1:
					return;
				case 2:
					IL_32:
					this.<AlreadyPayed>k__BackingField = value;
					this.RaisePropertyChanged("AlreadyPayed");
					num = 1224446453;
					goto IL_13;
				case 3:
					goto IL_0E;
				}
			}
		}

		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x06002936 RID: 10550 RVA: 0x00080400 File Offset: 0x0007E600
		// (set) Token: 0x06002937 RID: 10551 RVA: 0x00080414 File Offset: 0x0007E614
		public Dictionary<int, string> RejectReasons
		{
			[CompilerGenerated]
			get
			{
				return this.<RejectReasons>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<RejectReasons>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -856527072;
				IL_13:
				switch ((num ^ -2001990385) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					IL_32:
					this.<RejectReasons>k__BackingField = value;
					this.RaisePropertyChanged("RejectReasons");
					num = -1634929787;
					goto IL_13;
				case 3:
					return;
				}
			}
		}

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x06002938 RID: 10552 RVA: 0x00080470 File Offset: 0x0007E670
		// (set) Token: 0x06002939 RID: 10553 RVA: 0x00080484 File Offset: 0x0007E684
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

		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x0600293A RID: 10554 RVA: 0x000804B0 File Offset: 0x0007E6B0
		public bool PayCheckEnable
		{
			get
			{
				return !this.DebtOut;
			}
		}

		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x0600293B RID: 10555 RVA: 0x000804C8 File Offset: 0x0007E6C8
		// (set) Token: 0x0600293C RID: 10556 RVA: 0x000804DC File Offset: 0x0007E6DC
		public int RejectReasonId
		{
			[CompilerGenerated]
			get
			{
				return this.<RejectReasonId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<RejectReasonId>k__BackingField == value)
				{
					return;
				}
				this.<RejectReasonId>k__BackingField = value;
				this.RaisePropertyChanged("RejectReasonId");
			}
		}

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x0600293D RID: 10557 RVA: 0x00080508 File Offset: 0x0007E708
		// (set) Token: 0x0600293E RID: 10558 RVA: 0x0008051C File Offset: 0x0007E71C
		public bool CustomRejectReasonVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<CustomRejectReasonVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CustomRejectReasonVisible>k__BackingField == value)
				{
					return;
				}
				this.<CustomRejectReasonVisible>k__BackingField = value;
				this.RaisePropertyChanged("CustomRejectReasonVisible");
			}
		}

		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x0600293F RID: 10559 RVA: 0x00080548 File Offset: 0x0007E748
		// (set) Token: 0x06002940 RID: 10560 RVA: 0x0008055C File Offset: 0x0007E75C
		public bool DebtOutVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<DebtOutVisible>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<DebtOutVisible>k__BackingField == value)
				{
					return;
				}
				this.<DebtOutVisible>k__BackingField = value;
				this.RaisePropertyChanged("DebtOutVisible");
			}
		}

		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x06002941 RID: 10561 RVA: 0x00080588 File Offset: 0x0007E788
		// (set) Token: 0x06002942 RID: 10562 RVA: 0x0008059C File Offset: 0x0007E79C
		public PrintOptions PrintOptions
		{
			[CompilerGenerated]
			get
			{
				return this.<PrintOptions>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<PrintOptions>k__BackingField, value))
				{
					return;
				}
				this.<PrintOptions>k__BackingField = value;
				this.RaisePropertyChanged("PrintOptions");
			}
		}

		// Token: 0x17000DCD RID: 3533
		// (get) Token: 0x06002943 RID: 10563 RVA: 0x000805CC File Offset: 0x0007E7CC
		// (set) Token: 0x06002944 RID: 10564 RVA: 0x000805E0 File Offset: 0x0007E7E0
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

		// Token: 0x17000DCE RID: 3534
		// (get) Token: 0x06002945 RID: 10565 RVA: 0x0008060C File Offset: 0x0007E80C
		// (set) Token: 0x06002946 RID: 10566 RVA: 0x00080620 File Offset: 0x0007E820
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

		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x06002947 RID: 10567 RVA: 0x00080650 File Offset: 0x0007E850
		// (set) Token: 0x06002948 RID: 10568 RVA: 0x00080664 File Offset: 0x0007E864
		public bool DebtOut
		{
			get
			{
				return this._debtOut;
			}
			set
			{
				if (this._debtOut == value)
				{
					return;
				}
				this._debtOut = value;
				this.RaisePropertyChanged("PayCheckEnable");
				this.RaisePropertyChanged("DebtOut");
				if (value)
				{
					this.PayFromBalance = false;
				}
			}
		}

		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x06002949 RID: 10569 RVA: 0x000806A4 File Offset: 0x0007E8A4
		// (set) Token: 0x0600294A RID: 10570 RVA: 0x000806B8 File Offset: 0x0007E8B8
		public bool PayFromBalance
		{
			get
			{
				return this._payFromBalance;
			}
			set
			{
				if (this._payFromBalance == value)
				{
					return;
				}
				this._payFromBalance = value;
				this.RaisePropertyChanged("PayFromBalance");
				if (value)
				{
					this.DebtOut = false;
				}
			}
		}

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x0600294B RID: 10571 RVA: 0x000806F0 File Offset: 0x0007E8F0
		// (set) Token: 0x0600294C RID: 10572 RVA: 0x00080704 File Offset: 0x0007E904
		public bool IsLoaded
		{
			[CompilerGenerated]
			get
			{
				return this.<IsLoaded>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<IsLoaded>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -1451547533;
				IL_10:
				switch ((num ^ -640741150) % 4)
				{
				case 0:
					IL_2F:
					this.<IsLoaded>k__BackingField = value;
					num = -1599861955;
					goto IL_10;
				case 1:
					return;
				case 2:
					goto IL_0B;
				}
				this.RaisePropertyChanged("IsLoaded");
			}
		}

		// Token: 0x0600294D RID: 10573 RVA: 0x0008075C File Offset: 0x0007E95C
		public IssueRepairViewModel()
		{
			this._repairModel = Bootstrapper.Container.Resolve<IRepairModel>();
			this._workshopOptions = Bootstrapper.Container.Resolve<WorkshopOptions>();
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._ascMessageBoxService = Bootstrapper.Container.Resolve<IAscMessageBoxService>();
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
			this._workshopService = Bootstrapper.Container.Resolve<IWorkshopService>();
			this._reportPrintService = Bootstrapper.Container.Resolve<IReportPrintService>();
			this.RejectReasons = this._repairModel.GetRejectReasons();
			this.PrintOptions = new PrintOptions();
		}

		// Token: 0x0600294E RID: 10574 RVA: 0x0008080C File Offset: 0x0007EA0C
		public IssueRepairViewModel(int repairId) : this()
		{
			this.RepairId = repairId;
		}

		// Token: 0x0600294F RID: 10575 RVA: 0x00080828 File Offset: 0x0007EA28
		private void Init()
		{
			IssueRepairViewModel.<Init>d__84 <Init>d__;
			<Init>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<IssueRepairViewModel.<Init>d__84>(ref <Init>d__);
		}

		// Token: 0x06002950 RID: 10576 RVA: 0x00080860 File Offset: 0x0007EA60
		private void SetDebtOutVisible()
		{
			List<WorkshopOptions> source = this._workshopOptions.OptionsByOption(this.Repair.state);
			for (;;)
			{
				IL_9E:
				int num = -1832159101;
				for (;;)
				{
					switch ((num ^ -1980062086) % 3)
					{
					case 1:
					{
						bool debtOutVisible;
						if (this.Repair.clients.balance_enable && this.Repair.state == 6 && OfflineData.Instance.Employee.Can(64, 0))
						{
							debtOutVisible = source.Any((WorkshopOptions o) => o.Id == 16);
						}
						else
						{
							debtOutVisible = false;
						}
						this.DebtOutVisible = debtOutVisible;
						num = -1376590458;
						continue;
					}
					case 2:
						goto IL_9E;
					}
					return;
				}
			}
		}

		// Token: 0x06002951 RID: 10577 RVA: 0x00080914 File Offset: 0x0007EB14
		[AsyncCommand]
		public Task IssueRepair()
		{
			IssueRepairViewModel.<IssueRepair>d__86 <IssueRepair>d__;
			<IssueRepair>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<IssueRepair>d__.<>4__this = this;
			<IssueRepair>d__.<>1__state = -1;
			<IssueRepair>d__.<>t__builder.Start<IssueRepairViewModel.<IssueRepair>d__86>(ref <IssueRepair>d__);
			return <IssueRepair>d__.<>t__builder.Task;
		}

		// Token: 0x06002952 RID: 10578 RVA: 0x00080958 File Offset: 0x0007EB58
		public bool CanIssueRepair()
		{
			return OfflineData.Instance.Employee.Can(4, 0) && this.IsLoaded && this.Repair.state != 8;
		}

		// Token: 0x06002953 RID: 10579 RVA: 0x00080994 File Offset: 0x0007EB94
		private Task<bool> OutCheckFields(workshop repair, bool confirmOutWithoutRepair)
		{
			IssueRepairViewModel.<OutCheckFields>d__88 <OutCheckFields>d__;
			<OutCheckFields>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<OutCheckFields>d__.<>4__this = this;
			<OutCheckFields>d__.repair = repair;
			<OutCheckFields>d__.confirmOutWithoutRepair = confirmOutWithoutRepair;
			<OutCheckFields>d__.<>1__state = -1;
			<OutCheckFields>d__.<>t__builder.Start<IssueRepairViewModel.<OutCheckFields>d__88>(ref <OutCheckFields>d__);
			return <OutCheckFields>d__.<>t__builder.Task;
		}

		// Token: 0x06002954 RID: 10580 RVA: 0x000809E8 File Offset: 0x0007EBE8
		private void PrintReports()
		{
			IssueRepairViewModel.<PrintReports>d__89 <PrintReports>d__;
			<PrintReports>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<PrintReports>d__.<>4__this = this;
			<PrintReports>d__.<>1__state = -1;
			<PrintReports>d__.<>t__builder.Start<IssueRepairViewModel.<PrintReports>d__89>(ref <PrintReports>d__);
		}

		// Token: 0x06002955 RID: 10581 RVA: 0x00080A20 File Offset: 0x0007EC20
		[Command]
		public void PrintDocumentLoss()
		{
			new DocumentLoss(this.Repair.id).Show();
		}

		// Token: 0x06002956 RID: 10582 RVA: 0x00080A44 File Offset: 0x0007EC44
		public bool CanPrintDocumentLoss()
		{
			return this.Repair != null;
		}

		// Token: 0x06002957 RID: 10583 RVA: 0x00080A5C File Offset: 0x0007EC5C
		[Command]
		public void RejectReasonChanged()
		{
			if (this.RejectReasonId == 0)
			{
				return;
			}
			KeyValuePair<int, string> keyValuePair = this.RejectReasons.FirstOrDefault((KeyValuePair<int, string> r) => r.Key == this.RejectReasonId);
			if (keyValuePair.Key != -1)
			{
				this.Repair.reject_reason = keyValuePair.Value;
			}
			this.CustomRejectReasonVisible = (keyValuePair.Key == -1);
		}

		// Token: 0x06002958 RID: 10584 RVA: 0x00080AB8 File Offset: 0x0007ECB8
		[Command]
		public void SendChequeChanged()
		{
			if (!this.SendChequeToEmail)
			{
				this.CustomerEmail = "";
			}
		}

		// Token: 0x06002959 RID: 10585 RVA: 0x00080AD8 File Offset: 0x0007ECD8
		protected override void OnParentViewModelChanged(object parentViewModel)
		{
			base.OnParentViewModelChanged(parentViewModel);
			this._repairCard = (parentViewModel as ICashOrderSelect);
		}

		// Token: 0x0600295A RID: 10586 RVA: 0x00080AF8 File Offset: 0x0007ECF8
		public override void OnLoad()
		{
			base.OnLoad();
			this.Init();
		}

		// Token: 0x0600295B RID: 10587 RVA: 0x00080B14 File Offset: 0x0007ED14
		[CompilerGenerated]
		private Task<workshop> <Init>b__84_2()
		{
			return this._workshopService.GetRepair(this.RepairId);
		}

		// Token: 0x0600295C RID: 10588 RVA: 0x00080B34 File Offset: 0x0007ED34
		[CompilerGenerated]
		private Task<CustomerCard> <Init>b__84_3()
		{
			return ClientsModel.GetCustomerCard(this.Repair.client);
		}

		// Token: 0x0600295D RID: 10589 RVA: 0x00080B54 File Offset: 0x0007ED54
		[CompilerGenerated]
		private bool <RejectReasonChanged>b__92_0(KeyValuePair<int, string> r)
		{
			return r.Key == this.RejectReasonId;
		}

		// Token: 0x040016B5 RID: 5813
		private readonly WorkshopOptions _workshopOptions;

		// Token: 0x040016B6 RID: 5814
		private readonly IRepairModel _repairModel;

		// Token: 0x040016B7 RID: 5815
		private readonly INavigationService _navigationService;

		// Token: 0x040016B8 RID: 5816
		private readonly IToasterService _toasterService;

		// Token: 0x040016B9 RID: 5817
		private readonly IAscMessageBoxService _ascMessageBoxService;

		// Token: 0x040016BA RID: 5818
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x040016BB RID: 5819
		private readonly IWorkshopService _workshopService;

		// Token: 0x040016BC RID: 5820
		private readonly IReportPrintService _reportPrintService;

		// Token: 0x040016BD RID: 5821
		[CompilerGenerated]
		private int <RepairId>k__BackingField;

		// Token: 0x040016BE RID: 5822
		[CompilerGenerated]
		private CustomerCard <Customer>k__BackingField;

		// Token: 0x040016BF RID: 5823
		[CompilerGenerated]
		private workshop <Repair>k__BackingField;

		// Token: 0x040016C0 RID: 5824
		[CompilerGenerated]
		private bool <ConfirmOutWithoutRepair>k__BackingField;

		// Token: 0x040016C1 RID: 5825
		[CompilerGenerated]
		private decimal <RepairCostTotal>k__BackingField;

		// Token: 0x040016C2 RID: 5826
		[CompilerGenerated]
		private decimal <FinalAmount>k__BackingField;

		// Token: 0x040016C3 RID: 5827
		[CompilerGenerated]
		private decimal <AlreadyPayed>k__BackingField;

		// Token: 0x040016C4 RID: 5828
		[CompilerGenerated]
		private Dictionary<int, string> <RejectReasons>k__BackingField;

		// Token: 0x040016C5 RID: 5829
		[CompilerGenerated]
		private bool <PayCheck>k__BackingField;

		// Token: 0x040016C6 RID: 5830
		[CompilerGenerated]
		private int <RejectReasonId>k__BackingField;

		// Token: 0x040016C7 RID: 5831
		[CompilerGenerated]
		private bool <CustomRejectReasonVisible>k__BackingField;

		// Token: 0x040016C8 RID: 5832
		[CompilerGenerated]
		private bool <DebtOutVisible>k__BackingField;

		// Token: 0x040016C9 RID: 5833
		[CompilerGenerated]
		private PrintOptions <PrintOptions>k__BackingField;

		// Token: 0x040016CA RID: 5834
		[CompilerGenerated]
		private bool <SendChequeToEmail>k__BackingField;

		// Token: 0x040016CB RID: 5835
		[CompilerGenerated]
		private string <CustomerEmail>k__BackingField;

		// Token: 0x040016CC RID: 5836
		private bool _debtOut;

		// Token: 0x040016CD RID: 5837
		private bool _payFromBalance;

		// Token: 0x040016CE RID: 5838
		[CompilerGenerated]
		private bool <IsLoaded>k__BackingField;

		// Token: 0x040016CF RID: 5839
		private ICashOrderSelect _repairCard;

		// Token: 0x020003FB RID: 1019
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Init>d__84 : IAsyncStateMachine
		{
			// Token: 0x0600295E RID: 10590 RVA: 0x00080B70 File Offset: 0x0007ED70
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IssueRepairViewModel issueRepairViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<workshop> awaiter;
					TaskAwaiter<decimal> awaiter2;
					TaskAwaiter<CustomerCard> awaiter3;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<workshop>);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<decimal>);
						this.<>1__state = -1;
						goto IL_F8;
					case 2:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<decimal>);
						this.<>1__state = -1;
						goto IL_165;
					case 3:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<decimal>);
						this.<>1__state = -1;
						goto IL_1D2;
					case 4:
						awaiter3 = this.<>u__3;
						this.<>u__3 = default(TaskAwaiter<CustomerCard>);
						this.<>1__state = -1;
						goto IL_250;
					default:
						issueRepairViewModel.ShowWait();
						awaiter = Task.Run<workshop>(() => issueRepairViewModel._workshopService.GetRepair(base.RepairId)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop>, IssueRepairViewModel.<Init>d__84>(ref awaiter, ref this);
							return;
						}
						break;
					}
					workshop result = awaiter.GetResult();
					issueRepairViewModel.Repair = result;
					awaiter2 = RepairModel.GetAlreadyPayedSumm(issueRepairViewModel.RepairId).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, IssueRepairViewModel.<Init>d__84>(ref awaiter2, ref this);
						return;
					}
					IL_F8:
					decimal result2 = awaiter2.GetResult();
					issueRepairViewModel.AlreadyPayed = result2;
					awaiter2 = RepairModel.GetRepairFinalAmount(issueRepairViewModel.RepairId).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, IssueRepairViewModel.<Init>d__84>(ref awaiter2, ref this);
						return;
					}
					IL_165:
					result2 = awaiter2.GetResult();
					issueRepairViewModel.FinalAmount = result2;
					awaiter2 = RepairModel.GetRepairCostTotal(issueRepairViewModel.RepairId).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, IssueRepairViewModel.<Init>d__84>(ref awaiter2, ref this);
						return;
					}
					IL_1D2:
					result2 = awaiter2.GetResult();
					issueRepairViewModel.RepairCostTotal = result2;
					if (issueRepairViewModel.Repair == null)
					{
						goto IL_288;
					}
					awaiter3 = Task.Run<CustomerCard>(() => ClientsModel.GetCustomerCard(base.Repair.client)).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 4;
						this.<>u__3 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<CustomerCard>, IssueRepairViewModel.<Init>d__84>(ref awaiter3, ref this);
						return;
					}
					IL_250:
					CustomerCard result3 = awaiter3.GetResult();
					issueRepairViewModel.Customer = result3;
					issueRepairViewModel.Repair.real_repair_cost = issueRepairViewModel.RepairCostTotal;
					issueRepairViewModel.PrintOptions.PrintCheck = issueRepairViewModel.Repair.print_check;
					IL_288:
					issueRepairViewModel.SetDebtOutVisible();
					issueRepairViewModel.HideWait();
					issueRepairViewModel.RaiseCanExecuteChanged(() => issueRepairViewModel.PrintDocumentLoss());
					issueRepairViewModel.RaiseCanExecuteChanged(() => issueRepairViewModel.IssueRepair());
					issueRepairViewModel.IsLoaded = true;
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

			// Token: 0x0600295F RID: 10591 RVA: 0x00080ED8 File Offset: 0x0007F0D8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040016D0 RID: 5840
			public int <>1__state;

			// Token: 0x040016D1 RID: 5841
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040016D2 RID: 5842
			public IssueRepairViewModel <>4__this;

			// Token: 0x040016D3 RID: 5843
			private TaskAwaiter<workshop> <>u__1;

			// Token: 0x040016D4 RID: 5844
			private TaskAwaiter<decimal> <>u__2;

			// Token: 0x040016D5 RID: 5845
			private TaskAwaiter<CustomerCard> <>u__3;
		}

		// Token: 0x020003FC RID: 1020
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002960 RID: 10592 RVA: 0x00080EF4 File Offset: 0x0007F0F4
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06002961 RID: 10593 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06002962 RID: 10594 RVA: 0x00080F0C File Offset: 0x0007F10C
			internal bool <SetDebtOutVisible>b__85_0(WorkshopOptions o)
			{
				return o.Id == 16;
			}

			// Token: 0x040016D6 RID: 5846
			public static readonly IssueRepairViewModel.<>c <>9 = new IssueRepairViewModel.<>c();

			// Token: 0x040016D7 RID: 5847
			public static Func<WorkshopOptions, bool> <>9__85_0;
		}

		// Token: 0x020003FD RID: 1021
		[CompilerGenerated]
		private sealed class <>c__DisplayClass86_0
		{
			// Token: 0x06002963 RID: 10595 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass86_0()
			{
			}

			// Token: 0x06002964 RID: 10596 RVA: 0x00080F24 File Offset: 0x0007F124
			internal Task<IAscResult> <IssueRepair>b__0()
			{
				return ((RepairModel)this.<>4__this._repairModel).MakeRepairOut(this.<>4__this.Repair, this.<>4__this.DebtOut, this.<>4__this.FinalAmount, this.<>4__this.PayFromBalance, this.<>4__this.CustomerEmail);
			}

			// Token: 0x06002965 RID: 10597 RVA: 0x00080F80 File Offset: 0x0007F180
			internal Task<IAscResult> <IssueRepair>b__1()
			{
				return OfflineData.Instance.Employee.Kkt.RepairCheck(this.<>4__this.RepairId, this.ascResult.Ids.FirstOrDefault<int>(), this.<>4__this.CustomerEmail);
			}

			// Token: 0x040016D8 RID: 5848
			public IssueRepairViewModel <>4__this;

			// Token: 0x040016D9 RID: 5849
			public IAscResult ascResult;
		}

		// Token: 0x020003FE RID: 1022
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <IssueRepair>d__86 : IAsyncStateMachine
		{
			// Token: 0x06002966 RID: 10598 RVA: 0x00080FC8 File Offset: 0x0007F1C8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IssueRepairViewModel issueRepairViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<bool> awaiter;
					TaskAwaiter<IAscResult> awaiter2;
					switch (num)
					{
					case 0:
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<bool>);
						int num2 = -1;
						num = -1;
						this.<>1__state = num2;
						break;
					}
					case 1:
					{
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<IAscResult>);
						int num3 = -1;
						num = -1;
						this.<>1__state = num3;
						goto IL_11B;
					}
					case 2:
					{
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<IAscResult>);
						int num4 = -1;
						num = -1;
						this.<>1__state = num4;
						goto IL_252;
					}
					case 3:
						IL_2AB:
						try
						{
							TaskAwaiter awaiter3;
							if (num != 3)
							{
								this.<history>5__2.AddRepairLog(issueRepairViewModel.RepairId, issueRepairViewModel.FinalAmount);
								awaiter3 = this.<history>5__2.SaveAsync().GetAwaiter();
								if (!awaiter3.IsCompleted)
								{
									int num5 = 3;
									num = 3;
									this.<>1__state = num5;
									this.<>u__3 = awaiter3;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, IssueRepairViewModel.<IssueRepair>d__86>(ref awaiter3, ref this);
									return;
								}
							}
							else
							{
								awaiter3 = this.<>u__3;
								this.<>u__3 = default(TaskAwaiter);
								int num6 = -1;
								num = -1;
								this.<>1__state = num6;
							}
							awaiter3.GetResult();
						}
						finally
						{
							if (num < 0 && this.<history>5__2 != null)
							{
								this.<history>5__2.Dispose();
							}
						}
						this.<history>5__2 = null;
						goto IL_34B;
					default:
						this.<>8__1 = new IssueRepairViewModel.<>c__DisplayClass86_0();
						this.<>8__1.<>4__this = this.<>4__this;
						awaiter = issueRepairViewModel.OutCheckFields(issueRepairViewModel.Repair, issueRepairViewModel.ConfirmOutWithoutRepair).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num7 = 0;
							num = 0;
							this.<>1__state = num7;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, IssueRepairViewModel.<IssueRepair>d__86>(ref awaiter, ref this);
							return;
						}
						break;
					}
					if (!awaiter.GetResult())
					{
						goto IL_3C0;
					}
					issueRepairViewModel.ShowWait();
					awaiter2 = Task.Run<IAscResult>(new Func<Task<IAscResult>>(this.<>8__1.<IssueRepair>b__0)).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						int num8 = 1;
						num = 1;
						this.<>1__state = num8;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IAscResult>, IssueRepairViewModel.<IssueRepair>d__86>(ref awaiter2, ref this);
						return;
					}
					IL_11B:
					IAscResult result = awaiter2.GetResult();
					this.<>8__1.ascResult = result;
					issueRepairViewModel.HideWait();
					if (!this.<>8__1.ascResult.IsSucces)
					{
						issueRepairViewModel.Repair.new_state = issueRepairViewModel.Repair.state;
						issueRepairViewModel._toasterService.Error(this.<>8__1.ascResult.Message);
						goto IL_3C0;
					}
					issueRepairViewModel.Repair.state = this.<>8__1.ascResult.Id;
					issueRepairViewModel._toasterService.Success(Lang.t("Complete"));
					if (issueRepairViewModel.Repair.state != 8)
					{
						goto IL_35E;
					}
					if (!issueRepairViewModel.PrintOptions.PrintCheck || !OfflineData.Instance.Employee.KktReady())
					{
						goto IL_34B;
					}
					issueRepairViewModel.ShowWait();
					awaiter2 = Task.Run<IAscResult>(new Func<Task<IAscResult>>(this.<>8__1.<IssueRepair>b__1)).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						int num9 = 2;
						num = 2;
						this.<>1__state = num9;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IAscResult>, IssueRepairViewModel.<IssueRepair>d__86>(ref awaiter2, ref this);
						return;
					}
					IL_252:
					IAscResult result2 = awaiter2.GetResult();
					issueRepairViewModel.HideWait();
					if (result2.IsSucces && string.IsNullOrEmpty(result2.Message))
					{
						this.<history>5__2 = Bootstrapper.Container.Resolve<IHistoryV2>();
						goto IL_2AB;
					}
					issueRepairViewModel._toasterService.Error("Ошибка ККТ: " + result2.Message);
					IL_34B:
					if (issueRepairViewModel.PrintOptions.IfAnyRepairOkDocumentPrint())
					{
						issueRepairViewModel.PrintReports();
					}
					IL_35E:
					if (issueRepairViewModel.Repair.state == 12)
					{
						if (issueRepairViewModel.PrintOptions.IfAnyRepairRejectDocumentPrint())
						{
							issueRepairViewModel.PrintReports();
						}
					}
					ICashOrderSelect repairCard = issueRepairViewModel._repairCard;
					if (repairCard != null)
					{
						repairCard.DataRefresh();
					}
					issueRepairViewModel._windowedDocumentService.CloseActiveDocument();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_3C0:
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002967 RID: 10599 RVA: 0x000813E4 File Offset: 0x0007F5E4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040016DA RID: 5850
			public int <>1__state;

			// Token: 0x040016DB RID: 5851
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040016DC RID: 5852
			public IssueRepairViewModel <>4__this;

			// Token: 0x040016DD RID: 5853
			private IssueRepairViewModel.<>c__DisplayClass86_0 <>8__1;

			// Token: 0x040016DE RID: 5854
			private TaskAwaiter<bool> <>u__1;

			// Token: 0x040016DF RID: 5855
			private TaskAwaiter<IAscResult> <>u__2;

			// Token: 0x040016E0 RID: 5856
			private IHistoryV2 <history>5__2;

			// Token: 0x040016E1 RID: 5857
			private TaskAwaiter <>u__3;
		}

		// Token: 0x020003FF RID: 1023
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OutCheckFields>d__88 : IAsyncStateMachine
		{
			// Token: 0x06002968 RID: 10600 RVA: 0x00081400 File Offset: 0x0007F600
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IssueRepairViewModel issueRepairViewModel = this.<>4__this;
				bool result;
				try
				{
					TaskAwaiter<decimal> awaiter;
					if (num != 0)
					{
						if (this.repair.office != Auth.User.office)
						{
							issueRepairViewModel._toasterService.Info(Lang.t("OutWrongOffice"));
							result = false;
							goto IL_45A;
						}
						if (this.repair.state != 7)
						{
							if (!issueRepairViewModel.PayCheck && !issueRepairViewModel.DebtOut && issueRepairViewModel.Repair.payment_system != -1)
							{
								issueRepairViewModel._toasterService.Info(Lang.t("ConfirmData"));
								result = false;
								goto IL_45A;
							}
						}
						if (this.repair.state == 6 && issueRepairViewModel.PayCheck && this.repair.invoice1 != null)
						{
							if (this.repair.invoice1.state == 2)
							{
								result = true;
								goto IL_45A;
							}
							string messageBoxText = string.Format(Lang.t("InvoiceNotPaidCreateNewPko"), this.repair.invoice1.num);
							if (issueRepairViewModel._ascMessageBoxService.ShowMessageBox(messageBoxText, Lang.t("InvoiceNotPaid"), MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
							{
								result = false;
								goto IL_45A;
							}
							this.repair.invoice = null;
						}
						if (this.repair.state != 7 && this.repair.payment_system == 1 && !RepairModel.OrderExist(this.repair.id) && !issueRepairViewModel.DebtOut && issueRepairViewModel.FinalAmount > 0m)
						{
							if (issueRepairViewModel._ascMessageBoxService.ShowMessageBox(Lang.t("CreatePko"), Lang.t("CashlessPkoNotFound"), MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes)
							{
								result = false;
								goto IL_45A;
							}
							issueRepairViewModel._windowedDocumentService.CloseActiveDocument();
							issueRepairViewModel._navigationService.Navigate("PkoView", new PkoViewModel(this.repair, Kassa.Types.repairPayment, true, true), issueRepairViewModel._repairCard);
							result = false;
							goto IL_45A;
						}
						else
						{
							if (this.repair.state == 7)
							{
								if (!this.confirmOutWithoutRepair)
								{
									issueRepairViewModel._toasterService.Info(Lang.t("ConfirmTheIssue"));
									result = false;
									goto IL_45A;
								}
							}
							if (this.repair.state == 7 && string.IsNullOrEmpty(this.repair.reject_reason))
							{
								issueRepairViewModel._toasterService.Info(Lang.t("InputRejectReason"));
								result = false;
								goto IL_45A;
							}
							awaiter = RepairModel.GetRepairCostTotal(this.repair.id).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, IssueRepairViewModel.<OutCheckFields>d__88>(ref awaiter, ref this);
								return;
							}
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<decimal>);
						this.<>1__state = -1;
					}
					decimal result2 = awaiter.GetResult();
					if (this.repair.state == 6 && result2 == 0m && !this.repair.is_warranty && !this.repair.is_repeat)
					{
						issueRepairViewModel._toasterService.Info(Lang.t("RepairCostError"));
						result = false;
					}
					else
					{
						if (this.repair.state == 6)
						{
							if (result2 < this.repair.repair_cost && issueRepairViewModel._ascMessageBoxService.ShowMessageBox(Lang.t("WorksLessRepairCost"), Lang.t("Price"), MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
							{
								result = false;
								goto IL_45A;
							}
						}
						if ((this.repair.state == 7 || this.repair.state == 6) && issueRepairViewModel.FinalAmount < 0m)
						{
							string messageBoxText2 = string.Format(Lang.t("RkoCreateQuestion"), issueRepairViewModel.FinalAmount);
							if (issueRepairViewModel._ascMessageBoxService.ShowMessageBox(messageBoxText2, Lang.t("PrePaid"), MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
							{
								result = RepairModel.PrepaidRefund(this.repair, issueRepairViewModel.FinalAmount);
								goto IL_45A;
							}
						}
						if (this.repair.state == 6)
						{
							if (issueRepairViewModel.PayFromBalance && this.repair.clients.balance < issueRepairViewModel.FinalAmount)
							{
								if (issueRepairViewModel._ascMessageBoxService.ShowMessageBox(Lang.t("ClientBalanceTooLow"), Lang.t("Balance"), MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.No)
								{
									result = false;
									goto IL_45A;
								}
							}
						}
						result = true;
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_45A:
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06002969 RID: 10601 RVA: 0x00081898 File Offset: 0x0007FA98
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040016E2 RID: 5858
			public int <>1__state;

			// Token: 0x040016E3 RID: 5859
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x040016E4 RID: 5860
			public workshop repair;

			// Token: 0x040016E5 RID: 5861
			public IssueRepairViewModel <>4__this;

			// Token: 0x040016E6 RID: 5862
			public bool confirmOutWithoutRepair;

			// Token: 0x040016E7 RID: 5863
			private TaskAwaiter<decimal> <>u__1;
		}

		// Token: 0x02000400 RID: 1024
		[CompilerGenerated]
		private sealed class <>c__DisplayClass89_0
		{
			// Token: 0x0600296A RID: 10602 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass89_0()
			{
			}

			// Token: 0x0600296B RID: 10603 RVA: 0x000818B4 File Offset: 0x0007FAB4
			internal Task<IRepairCard> <PrintReports>b__0()
			{
				return RepairModel.GetRepairCard(this.<>4__this.RepairId);
			}

			// Token: 0x0600296C RID: 10604 RVA: 0x000818D4 File Offset: 0x0007FAD4
			internal Task<XtraReport> <PrintReports>b__1()
			{
				return ((RepairCard)this.card).CreateReport("diag", 1);
			}

			// Token: 0x0600296D RID: 10605 RVA: 0x000818F8 File Offset: 0x0007FAF8
			internal Task<XtraReport> <PrintReports>b__2()
			{
				return ((RepairCard)this.card).CreateReport("works", 1);
			}

			// Token: 0x0600296E RID: 10606 RVA: 0x0008191C File Offset: 0x0007FB1C
			internal Task<XtraReport> <PrintReports>b__3()
			{
				return ((RepairCard)this.card).CreateReport("warranty", 1);
			}

			// Token: 0x0600296F RID: 10607 RVA: 0x00081940 File Offset: 0x0007FB40
			internal Task<XtraReport> <PrintReports>b__4()
			{
				return ((RepairCard)this.card).CreateReport("reject", 1);
			}

			// Token: 0x040016E8 RID: 5864
			public IssueRepairViewModel <>4__this;

			// Token: 0x040016E9 RID: 5865
			public IRepairCard card;
		}

		// Token: 0x02000401 RID: 1025
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <PrintReports>d__89 : IAsyncStateMachine
		{
			// Token: 0x06002970 RID: 10608 RVA: 0x00081964 File Offset: 0x0007FB64
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IssueRepairViewModel issueRepairViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IRepairCard> awaiter;
					TaskAwaiter<XtraReport> awaiter2;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IRepairCard>);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<XtraReport>);
						this.<>1__state = -1;
						goto IL_17D;
					case 2:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<XtraReport>);
						this.<>1__state = -1;
						goto IL_214;
					case 3:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<XtraReport>);
						this.<>1__state = -1;
						goto IL_2BE;
					case 4:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<XtraReport>);
						this.<>1__state = -1;
						goto IL_367;
					default:
						this.<>8__1 = new IssueRepairViewModel.<>c__DisplayClass89_0();
						this.<>8__1.<>4__this = this.<>4__this;
						if (!issueRepairViewModel.PrintOptions.PrintDiagnosticDocument && !issueRepairViewModel.PrintOptions.PrintWorksDocument && !issueRepairViewModel.PrintOptions.PrintWarrantyDocument && !issueRepairViewModel.PrintOptions.PrintRejectDocument)
						{
							goto IL_3C8;
						}
						issueRepairViewModel.ShowWait();
						this.<report>5__2 = new XtraReport();
						awaiter = Task.Run<IRepairCard>(new Func<Task<IRepairCard>>(this.<>8__1.<PrintReports>b__0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IRepairCard>, IssueRepairViewModel.<PrintReports>d__89>(ref awaiter, ref this);
							return;
						}
						break;
					}
					IRepairCard result = awaiter.GetResult();
					this.<>8__1.card = result;
					if (!issueRepairViewModel.PrintOptions.PrintDiagnosticDocument)
					{
						goto IL_19D;
					}
					awaiter2 = Task.Run<XtraReport>(new Func<Task<XtraReport>>(this.<>8__1.<PrintReports>b__1)).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XtraReport>, IssueRepairViewModel.<PrintReports>d__89>(ref awaiter2, ref this);
						return;
					}
					IL_17D:
					XtraReport result2 = awaiter2.GetResult();
					this.<report>5__2.Pages.AddRange(result2.Pages);
					IL_19D:
					if (!issueRepairViewModel.PrintOptions.PrintWorksDocument)
					{
						goto IL_234;
					}
					awaiter2 = Task.Run<XtraReport>(new Func<Task<XtraReport>>(this.<>8__1.<PrintReports>b__2)).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XtraReport>, IssueRepairViewModel.<PrintReports>d__89>(ref awaiter2, ref this);
						return;
					}
					IL_214:
					XtraReport result3 = awaiter2.GetResult();
					this.<report>5__2.Pages.AddRange(result3.Pages);
					IL_234:
					if (!issueRepairViewModel.PrintOptions.PrintWarrantyDocument)
					{
						goto IL_2DE;
					}
					if (issueRepairViewModel.Repair.state != 8)
					{
						goto IL_2DE;
					}
					awaiter2 = Task.Run<XtraReport>(new Func<Task<XtraReport>>(this.<>8__1.<PrintReports>b__3)).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XtraReport>, IssueRepairViewModel.<PrintReports>d__89>(ref awaiter2, ref this);
						return;
					}
					IL_2BE:
					XtraReport result4 = awaiter2.GetResult();
					this.<report>5__2.Pages.AddRange(result4.Pages);
					IL_2DE:
					if (!issueRepairViewModel.PrintOptions.PrintRejectDocument || issueRepairViewModel.Repair.state != 12)
					{
						goto IL_387;
					}
					awaiter2 = Task.Run<XtraReport>(new Func<Task<XtraReport>>(this.<>8__1.<PrintReports>b__4)).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 4;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XtraReport>, IssueRepairViewModel.<PrintReports>d__89>(ref awaiter2, ref this);
						return;
					}
					IL_367:
					XtraReport result5 = awaiter2.GetResult();
					this.<report>5__2.Pages.AddRange(result5.Pages);
					IL_387:
					issueRepairViewModel.HideWait();
					issueRepairViewModel._reportPrintService.PrintPreview(this.<report>5__2, PrinterModel.Printer.Documents);
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<report>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_3C8:
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<report>5__2 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002971 RID: 10609 RVA: 0x00081D78 File Offset: 0x0007FF78
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040016EA RID: 5866
			public int <>1__state;

			// Token: 0x040016EB RID: 5867
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040016EC RID: 5868
			public IssueRepairViewModel <>4__this;

			// Token: 0x040016ED RID: 5869
			private IssueRepairViewModel.<>c__DisplayClass89_0 <>8__1;

			// Token: 0x040016EE RID: 5870
			private XtraReport <report>5__2;

			// Token: 0x040016EF RID: 5871
			private TaskAwaiter<IRepairCard> <>u__1;

			// Token: 0x040016F0 RID: 5872
			private TaskAwaiter<XtraReport> <>u__2;
		}
	}
}
