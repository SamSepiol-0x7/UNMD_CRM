using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ASC.SimpleClasses
{
	// Token: 0x02000227 RID: 551
	public class UserSalaryReport
	{
		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x06001DB2 RID: 7602 RVA: 0x00055F4C File Offset: 0x0005414C
		// (set) Token: 0x06001DB3 RID: 7603 RVA: 0x00055F60 File Offset: 0x00054160
		public ObservableCollection<CashOrdersLite> Payments
		{
			[CompilerGenerated]
			get
			{
				return this.<Payments>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<Payments>k__BackingField = value;
			}
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x06001DB4 RID: 7604 RVA: 0x00055F74 File Offset: 0x00054174
		// (set) Token: 0x06001DB5 RID: 7605 RVA: 0x00055F88 File Offset: 0x00054188
		public ObservableCollection<workshop> Repairs
		{
			[CompilerGenerated]
			get
			{
				return this.<Repairs>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<Repairs>k__BackingField = value;
			}
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x06001DB6 RID: 7606 RVA: 0x00055F9C File Offset: 0x0005419C
		// (set) Token: 0x06001DB7 RID: 7607 RVA: 0x00055FB0 File Offset: 0x000541B0
		public ObservableCollection<workshop> NonOutRepairs
		{
			[CompilerGenerated]
			get
			{
				return this.<NonOutRepairs>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<NonOutRepairs>k__BackingField = value;
			}
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x06001DB8 RID: 7608 RVA: 0x00055FC4 File Offset: 0x000541C4
		// (set) Token: 0x06001DB9 RID: 7609 RVA: 0x00055FD8 File Offset: 0x000541D8
		public ObservableCollection<additional_payments> AdditionalPayments
		{
			[CompilerGenerated]
			get
			{
				return this.<AdditionalPayments>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<AdditionalPayments>k__BackingField = value;
			}
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x06001DBA RID: 7610 RVA: 0x00055FEC File Offset: 0x000541EC
		// (set) Token: 0x06001DBB RID: 7611 RVA: 0x00056000 File Offset: 0x00054200
		public ObservableCollection<docs> Sales
		{
			[CompilerGenerated]
			get
			{
				return this.<Sales>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<Sales>k__BackingField = value;
			}
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x06001DBC RID: 7612 RVA: 0x00056014 File Offset: 0x00054214
		// (set) Token: 0x06001DBD RID: 7613 RVA: 0x00056028 File Offset: 0x00054228
		public ObservableCollection<store_int_reserve> InRepairSales
		{
			[CompilerGenerated]
			get
			{
				return this.<InRepairSales>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<InRepairSales>k__BackingField = value;
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x06001DBE RID: 7614 RVA: 0x0005603C File Offset: 0x0005423C
		// (set) Token: 0x06001DBF RID: 7615 RVA: 0x00056050 File Offset: 0x00054250
		public ObservableCollection<workshop> AcceptedRepairs
		{
			[CompilerGenerated]
			get
			{
				return this.<AcceptedRepairs>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<AcceptedRepairs>k__BackingField = value;
			}
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x06001DC0 RID: 7616 RVA: 0x00056064 File Offset: 0x00054264
		// (set) Token: 0x06001DC1 RID: 7617 RVA: 0x00056078 File Offset: 0x00054278
		public ObservableCollection<workshop> IssuedRepairs
		{
			[CompilerGenerated]
			get
			{
				return this.<IssuedRepairs>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<IssuedRepairs>k__BackingField = value;
			}
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x0005608C File Offset: 0x0005428C
		public void SetPayments(IEnumerable<CashOrdersLite> payments)
		{
			this.Payments = new ObservableCollection<CashOrdersLite>(payments);
		}

		// Token: 0x06001DC3 RID: 7619 RVA: 0x000560A8 File Offset: 0x000542A8
		public void SetIssuedRepairs(IEnumerable<workshop> issuedRepairs)
		{
			this.IssuedRepairs = new ObservableCollection<workshop>(issuedRepairs);
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x000560C4 File Offset: 0x000542C4
		public void CalcSummUserIssued(users employee)
		{
			this.SummUserIssued = employee.pay_device_out * this.IssuedRepairs.Count;
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x000560F0 File Offset: 0x000542F0
		public void SetAcceptedRepairs(IEnumerable<workshop> acceptedRepairs)
		{
			this.AcceptedRepairs = new ObservableCollection<workshop>(acceptedRepairs);
		}

		// Token: 0x06001DC6 RID: 7622 RVA: 0x0005610C File Offset: 0x0005430C
		public void CalcSummUserAccepted(users employee)
		{
			this.SummUserAccepted = employee.pay_device_in * this.AcceptedRepairs.Count;
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x00056138 File Offset: 0x00054338
		public void SetInRepairSales(IEnumerable<store_int_reserve> inRepairSales)
		{
			this.InRepairSales = new ObservableCollection<store_int_reserve>(inRepairSales);
			this.CalcSummPaySaleInRepairUser();
		}

		// Token: 0x06001DC8 RID: 7624 RVA: 0x00056158 File Offset: 0x00054358
		protected virtual void CalcSummPaySaleInRepairUser()
		{
			this.SummPaySaleInRepairUser = (from i in this.InRepairSales
			select i.ManagerPart).DefaultIfEmpty<decimal>().Sum();
		}

		// Token: 0x06001DC9 RID: 7625 RVA: 0x000561A0 File Offset: 0x000543A0
		public void SetAdditionalPayments(IEnumerable<additional_payments> additionalPayments)
		{
			this.AdditionalPayments = new ObservableCollection<additional_payments>(additionalPayments);
			this.CalcAddtionalPlus();
			this.CalcAddtionalMinus();
		}

		// Token: 0x06001DCA RID: 7626 RVA: 0x000561C8 File Offset: 0x000543C8
		protected virtual void CalcAddtionalPlus()
		{
			this.AddtionalPlus = (from p in this.AdditionalPayments
			where p.price > 0m
			select p.price).DefaultIfEmpty<decimal>().Sum();
		}

		// Token: 0x06001DCB RID: 7627 RVA: 0x00056234 File Offset: 0x00054434
		protected virtual void CalcAddtionalMinus()
		{
			this.AddtionalMinus = (from p in this.AdditionalPayments
			where p.price < 0m
			select p.price).DefaultIfEmpty<decimal>().Sum();
		}

		// Token: 0x06001DCC RID: 7628 RVA: 0x000562A0 File Offset: 0x000544A0
		public void SetRepairs(IEnumerable<workshop> repairs)
		{
			this.Repairs = new ObservableCollection<workshop>(repairs);
		}

		// Token: 0x06001DCD RID: 7629 RVA: 0x000562BC File Offset: 0x000544BC
		public void SetNonOutRepairs(IEnumerable<workshop> repairs)
		{
			this.NonOutRepairs = new ObservableCollection<workshop>(repairs);
		}

		// Token: 0x06001DCE RID: 7630 RVA: 0x000562D8 File Offset: 0x000544D8
		public void SetSales(IEnumerable<docs> documents)
		{
			this.Sales = new ObservableCollection<docs>(documents);
			this.CalcSummPaySaleUser();
		}

		// Token: 0x06001DCF RID: 7631 RVA: 0x000562F8 File Offset: 0x000544F8
		public void CalcSummPayWorksUser(users employee)
		{
			this.SummPayWorksUser = (from r in this.Repairs
			select r.GetMasterPart(employee)).DefaultIfEmpty<decimal>().Sum();
		}

		// Token: 0x06001DD0 RID: 7632 RVA: 0x0005633C File Offset: 0x0005453C
		public void CalcSummNonOutWorks(users employee)
		{
			this.SummNonOutWorks = (from r in this.NonOutRepairs
			select r.GetMasterPart(employee)).DefaultIfEmpty<decimal>().Sum();
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x00056380 File Offset: 0x00054580
		protected virtual void CalcSummPaySaleUser()
		{
			this.SummPaySaleUser = (from s in this.Sales
			select s.ManagerPart).DefaultIfEmpty<decimal>().Sum();
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x06001DD2 RID: 7634 RVA: 0x000563C8 File Offset: 0x000545C8
		public int IoDevicesCount
		{
			get
			{
				ObservableCollection<workshop> acceptedRepairs = this.AcceptedRepairs;
				int num = (acceptedRepairs != null) ? acceptedRepairs.Count : 0;
				ObservableCollection<workshop> issuedRepairs = this.IssuedRepairs;
				int num2 = (issuedRepairs != null) ? issuedRepairs.Count : 0;
				return num + num2;
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x06001DD3 RID: 7635 RVA: 0x000563FC File Offset: 0x000545FC
		public int IssuedDevicesCount
		{
			get
			{
				ObservableCollection<workshop> issuedRepairs = this.IssuedRepairs;
				if (issuedRepairs == null)
				{
					return 0;
				}
				return issuedRepairs.Count;
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x06001DD4 RID: 7636 RVA: 0x0005641C File Offset: 0x0005461C
		public int AcceptedDevicesCount
		{
			get
			{
				ObservableCollection<workshop> acceptedRepairs = this.AcceptedRepairs;
				if (acceptedRepairs == null)
				{
					return 0;
				}
				return acceptedRepairs.Count;
			}
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x06001DD5 RID: 7637 RVA: 0x0005643C File Offset: 0x0005463C
		// (set) Token: 0x06001DD6 RID: 7638 RVA: 0x00056450 File Offset: 0x00054650
		public bool NoSalaryRecords
		{
			[CompilerGenerated]
			get
			{
				return this.<NoSalaryRecords>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<NoSalaryRecords>k__BackingField = value;
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x06001DD7 RID: 7639 RVA: 0x00056464 File Offset: 0x00054664
		// (set) Token: 0x06001DD8 RID: 7640 RVA: 0x00056478 File Offset: 0x00054678
		public int TotalPartsOnUser
		{
			[CompilerGenerated]
			get
			{
				return this.<TotalPartsOnUser>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<TotalPartsOnUser>k__BackingField = value;
			}
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x06001DD9 RID: 7641 RVA: 0x0005648C File Offset: 0x0005468C
		// (set) Token: 0x06001DDA RID: 7642 RVA: 0x000564A0 File Offset: 0x000546A0
		public int InstalledUserParts
		{
			[CompilerGenerated]
			get
			{
				return this.<InstalledUserParts>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<InstalledUserParts>k__BackingField = value;
			}
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x06001DDB RID: 7643 RVA: 0x000564B4 File Offset: 0x000546B4
		// (set) Token: 0x06001DDC RID: 7644 RVA: 0x000564C8 File Offset: 0x000546C8
		public int NotInstalledUserParts
		{
			[CompilerGenerated]
			get
			{
				return this.<NotInstalledUserParts>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<NotInstalledUserParts>k__BackingField = value;
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x06001DDD RID: 7645 RVA: 0x000564DC File Offset: 0x000546DC
		// (set) Token: 0x06001DDE RID: 7646 RVA: 0x000564F0 File Offset: 0x000546F0
		public decimal NotInstalledUserPartsSumm
		{
			[CompilerGenerated]
			get
			{
				return this.<NotInstalledUserPartsSumm>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<NotInstalledUserPartsSumm>k__BackingField = value;
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x06001DDF RID: 7647 RVA: 0x00056504 File Offset: 0x00054704
		// (set) Token: 0x06001DE0 RID: 7648 RVA: 0x00056518 File Offset: 0x00054718
		public decimal InstalledUserPartsSumm
		{
			[CompilerGenerated]
			get
			{
				return this.<InstalledUserPartsSumm>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<InstalledUserPartsSumm>k__BackingField = value;
			}
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x06001DE1 RID: 7649 RVA: 0x0005652C File Offset: 0x0005472C
		// (set) Token: 0x06001DE2 RID: 7650 RVA: 0x00056540 File Offset: 0x00054740
		public decimal SummPartsOnUser
		{
			[CompilerGenerated]
			get
			{
				return this.<SummPartsOnUser>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<SummPartsOnUser>k__BackingField = value;
			}
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x06001DE3 RID: 7651 RVA: 0x00056554 File Offset: 0x00054754
		// (set) Token: 0x06001DE4 RID: 7652 RVA: 0x00056568 File Offset: 0x00054768
		public decimal SummUserAccepted
		{
			[CompilerGenerated]
			get
			{
				return this.<SummUserAccepted>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<SummUserAccepted>k__BackingField = value;
			}
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x06001DE5 RID: 7653 RVA: 0x0005657C File Offset: 0x0005477C
		// (set) Token: 0x06001DE6 RID: 7654 RVA: 0x00056590 File Offset: 0x00054790
		public decimal SummUserIssued
		{
			[CompilerGenerated]
			get
			{
				return this.<SummUserIssued>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<SummUserIssued>k__BackingField = value;
			}
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x06001DE7 RID: 7655 RVA: 0x000565A4 File Offset: 0x000547A4
		public decimal SummIoDevices
		{
			get
			{
				return this.SummUserAccepted + this.SummUserIssued;
			}
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x06001DE8 RID: 7656 RVA: 0x000565C4 File Offset: 0x000547C4
		// (set) Token: 0x06001DE9 RID: 7657 RVA: 0x000565D8 File Offset: 0x000547D8
		public decimal SummPayWorksUser
		{
			[CompilerGenerated]
			get
			{
				return this.<SummPayWorksUser>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<SummPayWorksUser>k__BackingField = value;
			}
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x06001DEA RID: 7658 RVA: 0x000565EC File Offset: 0x000547EC
		// (set) Token: 0x06001DEB RID: 7659 RVA: 0x00056600 File Offset: 0x00054800
		public decimal SummPaySaleUser
		{
			[CompilerGenerated]
			get
			{
				return this.<SummPaySaleUser>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<SummPaySaleUser>k__BackingField = value;
			}
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x06001DEC RID: 7660 RVA: 0x00056614 File Offset: 0x00054814
		// (set) Token: 0x06001DED RID: 7661 RVA: 0x00056628 File Offset: 0x00054828
		public decimal SummPaySaleInRepairUser
		{
			[CompilerGenerated]
			get
			{
				return this.<SummPaySaleInRepairUser>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<SummPaySaleInRepairUser>k__BackingField = value;
			}
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x06001DEE RID: 7662 RVA: 0x0005663C File Offset: 0x0005483C
		public decimal TotalPaySale
		{
			get
			{
				return this.SummPaySaleInRepairUser + this.SummPaySaleUser;
			}
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x06001DEF RID: 7663 RVA: 0x0005665C File Offset: 0x0005485C
		// (set) Token: 0x06001DF0 RID: 7664 RVA: 0x00056670 File Offset: 0x00054870
		public decimal SummNonOutWorks
		{
			[CompilerGenerated]
			get
			{
				return this.<SummNonOutWorks>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<SummNonOutWorks>k__BackingField = value;
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x06001DF1 RID: 7665 RVA: 0x00056684 File Offset: 0x00054884
		// (set) Token: 0x06001DF2 RID: 7666 RVA: 0x00056698 File Offset: 0x00054898
		public decimal AddtionalPlus
		{
			[CompilerGenerated]
			get
			{
				return this.<AddtionalPlus>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<AddtionalPlus>k__BackingField = value;
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x06001DF3 RID: 7667 RVA: 0x000566AC File Offset: 0x000548AC
		// (set) Token: 0x06001DF4 RID: 7668 RVA: 0x000566C0 File Offset: 0x000548C0
		public decimal AddtionalMinus
		{
			[CompilerGenerated]
			get
			{
				return this.<AddtionalMinus>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<AddtionalMinus>k__BackingField = value;
			}
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x06001DF5 RID: 7669 RVA: 0x000566D4 File Offset: 0x000548D4
		// (set) Token: 0x06001DF6 RID: 7670 RVA: 0x000566E8 File Offset: 0x000548E8
		public decimal AlreadyPayed
		{
			[CompilerGenerated]
			get
			{
				return this.<AlreadyPayed>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<AlreadyPayed>k__BackingField = value;
			}
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x06001DF7 RID: 7671 RVA: 0x000566FC File Offset: 0x000548FC
		// (set) Token: 0x06001DF8 RID: 7672 RVA: 0x00056710 File Offset: 0x00054910
		public decimal Advance
		{
			[CompilerGenerated]
			get
			{
				return this.<Advance>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Advance>k__BackingField = value;
			}
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x06001DF9 RID: 7673 RVA: 0x00056724 File Offset: 0x00054924
		// (set) Token: 0x06001DFA RID: 7674 RVA: 0x00056738 File Offset: 0x00054938
		public decimal PaySumm
		{
			[CompilerGenerated]
			get
			{
				return this.<PaySumm>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<PaySumm>k__BackingField = value;
			}
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x06001DFB RID: 7675 RVA: 0x0005674C File Offset: 0x0005494C
		// (set) Token: 0x06001DFC RID: 7676 RVA: 0x00056760 File Offset: 0x00054960
		public decimal FinalPaySumm
		{
			[CompilerGenerated]
			get
			{
				return this.<FinalPaySumm>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<FinalPaySumm>k__BackingField = value;
			}
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x06001DFD RID: 7677 RVA: 0x00056774 File Offset: 0x00054974
		// (set) Token: 0x06001DFE RID: 7678 RVA: 0x00056788 File Offset: 0x00054988
		public decimal MonthSalary
		{
			[CompilerGenerated]
			get
			{
				return this.<MonthSalary>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<MonthSalary>k__BackingField = value;
			}
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x06001DFF RID: 7679 RVA: 0x0005679C File Offset: 0x0005499C
		// (set) Token: 0x06001E00 RID: 7680 RVA: 0x000567B0 File Offset: 0x000549B0
		public decimal TotalPlus
		{
			[CompilerGenerated]
			get
			{
				return this.<TotalPlus>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<TotalPlus>k__BackingField = value;
			}
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x06001E01 RID: 7681 RVA: 0x000567C4 File Offset: 0x000549C4
		// (set) Token: 0x06001E02 RID: 7682 RVA: 0x000567D8 File Offset: 0x000549D8
		public salary LastSalary
		{
			[CompilerGenerated]
			get
			{
				return this.<LastSalary>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<LastSalary>k__BackingField = value;
			}
		}

		// Token: 0x06001E03 RID: 7683 RVA: 0x000046B4 File Offset: 0x000028B4
		public UserSalaryReport()
		{
		}

		// Token: 0x04000F92 RID: 3986
		[CompilerGenerated]
		private ObservableCollection<CashOrdersLite> <Payments>k__BackingField;

		// Token: 0x04000F93 RID: 3987
		[CompilerGenerated]
		private ObservableCollection<workshop> <Repairs>k__BackingField;

		// Token: 0x04000F94 RID: 3988
		[CompilerGenerated]
		private ObservableCollection<workshop> <NonOutRepairs>k__BackingField;

		// Token: 0x04000F95 RID: 3989
		[CompilerGenerated]
		private ObservableCollection<additional_payments> <AdditionalPayments>k__BackingField;

		// Token: 0x04000F96 RID: 3990
		[CompilerGenerated]
		private ObservableCollection<docs> <Sales>k__BackingField;

		// Token: 0x04000F97 RID: 3991
		[CompilerGenerated]
		private ObservableCollection<store_int_reserve> <InRepairSales>k__BackingField;

		// Token: 0x04000F98 RID: 3992
		[CompilerGenerated]
		private ObservableCollection<workshop> <AcceptedRepairs>k__BackingField;

		// Token: 0x04000F99 RID: 3993
		[CompilerGenerated]
		private ObservableCollection<workshop> <IssuedRepairs>k__BackingField;

		// Token: 0x04000F9A RID: 3994
		[CompilerGenerated]
		private bool <NoSalaryRecords>k__BackingField;

		// Token: 0x04000F9B RID: 3995
		[CompilerGenerated]
		private int <TotalPartsOnUser>k__BackingField;

		// Token: 0x04000F9C RID: 3996
		[CompilerGenerated]
		private int <InstalledUserParts>k__BackingField;

		// Token: 0x04000F9D RID: 3997
		[CompilerGenerated]
		private int <NotInstalledUserParts>k__BackingField;

		// Token: 0x04000F9E RID: 3998
		[CompilerGenerated]
		private decimal <NotInstalledUserPartsSumm>k__BackingField;

		// Token: 0x04000F9F RID: 3999
		[CompilerGenerated]
		private decimal <InstalledUserPartsSumm>k__BackingField;

		// Token: 0x04000FA0 RID: 4000
		[CompilerGenerated]
		private decimal <SummPartsOnUser>k__BackingField;

		// Token: 0x04000FA1 RID: 4001
		[CompilerGenerated]
		private decimal <SummUserAccepted>k__BackingField;

		// Token: 0x04000FA2 RID: 4002
		[CompilerGenerated]
		private decimal <SummUserIssued>k__BackingField;

		// Token: 0x04000FA3 RID: 4003
		[CompilerGenerated]
		private decimal <SummPayWorksUser>k__BackingField;

		// Token: 0x04000FA4 RID: 4004
		[CompilerGenerated]
		private decimal <SummPaySaleUser>k__BackingField;

		// Token: 0x04000FA5 RID: 4005
		[CompilerGenerated]
		private decimal <SummPaySaleInRepairUser>k__BackingField;

		// Token: 0x04000FA6 RID: 4006
		[CompilerGenerated]
		private decimal <SummNonOutWorks>k__BackingField;

		// Token: 0x04000FA7 RID: 4007
		[CompilerGenerated]
		private decimal <AddtionalPlus>k__BackingField;

		// Token: 0x04000FA8 RID: 4008
		[CompilerGenerated]
		private decimal <AddtionalMinus>k__BackingField;

		// Token: 0x04000FA9 RID: 4009
		[CompilerGenerated]
		private decimal <AlreadyPayed>k__BackingField;

		// Token: 0x04000FAA RID: 4010
		[CompilerGenerated]
		private decimal <Advance>k__BackingField;

		// Token: 0x04000FAB RID: 4011
		[CompilerGenerated]
		private decimal <PaySumm>k__BackingField;

		// Token: 0x04000FAC RID: 4012
		[CompilerGenerated]
		private decimal <FinalPaySumm>k__BackingField;

		// Token: 0x04000FAD RID: 4013
		[CompilerGenerated]
		private decimal <MonthSalary>k__BackingField;

		// Token: 0x04000FAE RID: 4014
		[CompilerGenerated]
		private decimal <TotalPlus>k__BackingField;

		// Token: 0x04000FAF RID: 4015
		[CompilerGenerated]
		private salary <LastSalary>k__BackingField;

		// Token: 0x02000228 RID: 552
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001E04 RID: 7684 RVA: 0x000567EC File Offset: 0x000549EC
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06001E05 RID: 7685 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06001E06 RID: 7686 RVA: 0x00056804 File Offset: 0x00054A04
			internal decimal <CalcSummPaySaleInRepairUser>b__38_0(store_int_reserve i)
			{
				return i.ManagerPart;
			}

			// Token: 0x06001E07 RID: 7687 RVA: 0x00056818 File Offset: 0x00054A18
			internal bool <CalcAddtionalPlus>b__40_0(additional_payments p)
			{
				return p.price > 0m;
			}

			// Token: 0x06001E08 RID: 7688 RVA: 0x00056838 File Offset: 0x00054A38
			internal decimal <CalcAddtionalPlus>b__40_1(additional_payments p)
			{
				return p.price;
			}

			// Token: 0x06001E09 RID: 7689 RVA: 0x0005684C File Offset: 0x00054A4C
			internal bool <CalcAddtionalMinus>b__41_0(additional_payments p)
			{
				return p.price < 0m;
			}

			// Token: 0x06001E0A RID: 7690 RVA: 0x00056838 File Offset: 0x00054A38
			internal decimal <CalcAddtionalMinus>b__41_1(additional_payments p)
			{
				return p.price;
			}

			// Token: 0x06001E0B RID: 7691 RVA: 0x0005686C File Offset: 0x00054A6C
			internal decimal <CalcSummPaySaleUser>b__47_0(docs s)
			{
				return s.ManagerPart;
			}

			// Token: 0x04000FB0 RID: 4016
			public static readonly UserSalaryReport.<>c <>9 = new UserSalaryReport.<>c();

			// Token: 0x04000FB1 RID: 4017
			public static Func<store_int_reserve, decimal> <>9__38_0;

			// Token: 0x04000FB2 RID: 4018
			public static Func<additional_payments, bool> <>9__40_0;

			// Token: 0x04000FB3 RID: 4019
			public static Func<additional_payments, decimal> <>9__40_1;

			// Token: 0x04000FB4 RID: 4020
			public static Func<additional_payments, bool> <>9__41_0;

			// Token: 0x04000FB5 RID: 4021
			public static Func<additional_payments, decimal> <>9__41_1;

			// Token: 0x04000FB6 RID: 4022
			public static Func<docs, decimal> <>9__47_0;
		}

		// Token: 0x02000229 RID: 553
		[CompilerGenerated]
		private sealed class <>c__DisplayClass45_0
		{
			// Token: 0x06001E0C RID: 7692 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass45_0()
			{
			}

			// Token: 0x06001E0D RID: 7693 RVA: 0x00056880 File Offset: 0x00054A80
			internal decimal <CalcSummPayWorksUser>b__0(workshop r)
			{
				return r.GetMasterPart(this.employee);
			}

			// Token: 0x04000FB7 RID: 4023
			public users employee;
		}

		// Token: 0x0200022A RID: 554
		[CompilerGenerated]
		private sealed class <>c__DisplayClass46_0
		{
			// Token: 0x06001E0E RID: 7694 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass46_0()
			{
			}

			// Token: 0x06001E0F RID: 7695 RVA: 0x0005689C File Offset: 0x00054A9C
			internal decimal <CalcSummNonOutWorks>b__0(workshop r)
			{
				return r.GetMasterPart(this.employee);
			}

			// Token: 0x04000FB8 RID: 4024
			public users employee;
		}
	}
}
