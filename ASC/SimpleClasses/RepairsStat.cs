using System;
using System.Runtime.CompilerServices;
using DevExpress.Mvvm;

namespace ASC.SimpleClasses
{
	// Token: 0x02000224 RID: 548
	public class RepairsStat : BindableBase
	{
		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x06001D62 RID: 7522 RVA: 0x000556C8 File Offset: 0x000538C8
		// (set) Token: 0x06001D63 RID: 7523 RVA: 0x000556DC File Offset: 0x000538DC
		public int AveragePrice
		{
			[CompilerGenerated]
			get
			{
				return this.<AveragePrice>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<AveragePrice>k__BackingField == value)
				{
					return;
				}
				this.<AveragePrice>k__BackingField = value;
				this.RaisePropertyChanged("AveragePrice");
			}
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x06001D64 RID: 7524 RVA: 0x00055708 File Offset: 0x00053908
		// (set) Token: 0x06001D65 RID: 7525 RVA: 0x0005571C File Offset: 0x0005391C
		public int MaxPrice
		{
			[CompilerGenerated]
			get
			{
				return this.<MaxPrice>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<MaxPrice>k__BackingField == value)
				{
					return;
				}
				this.<MaxPrice>k__BackingField = value;
				this.RaisePropertyChanged("MaxPrice");
			}
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x06001D66 RID: 7526 RVA: 0x00055748 File Offset: 0x00053948
		// (set) Token: 0x06001D67 RID: 7527 RVA: 0x0005575C File Offset: 0x0005395C
		public int MinPrice
		{
			[CompilerGenerated]
			get
			{
				return this.<MinPrice>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<MinPrice>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -968013681;
				IL_10:
				switch ((num ^ -51956594) % 4)
				{
				case 0:
					goto IL_0B;
				case 1:
					return;
				case 2:
					IL_2F:
					this.<MinPrice>k__BackingField = value;
					this.RaisePropertyChanged("MinPrice");
					num = -1412880719;
					goto IL_10;
				}
			}
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x06001D68 RID: 7528 RVA: 0x000557B4 File Offset: 0x000539B4
		// (set) Token: 0x06001D69 RID: 7529 RVA: 0x000557C8 File Offset: 0x000539C8
		public double RepairsPerDay
		{
			[CompilerGenerated]
			get
			{
				return this.<RepairsPerDay>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<RepairsPerDay>k__BackingField == value)
				{
					return;
				}
				this.<RepairsPerDay>k__BackingField = value;
				this.RaisePropertyChanged("RepairsPerDay");
			}
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x06001D6A RID: 7530 RVA: 0x000557F8 File Offset: 0x000539F8
		// (set) Token: 0x06001D6B RID: 7531 RVA: 0x0005580C File Offset: 0x00053A0C
		public int TotalRepairIn
		{
			[CompilerGenerated]
			get
			{
				return this.<TotalRepairIn>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<TotalRepairIn>k__BackingField == value)
				{
					return;
				}
				this.<TotalRepairIn>k__BackingField = value;
				this.RaisePropertyChanged("TotalRepairIn");
			}
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x06001D6C RID: 7532 RVA: 0x00055838 File Offset: 0x00053A38
		// (set) Token: 0x06001D6D RID: 7533 RVA: 0x0005584C File Offset: 0x00053A4C
		public int TotalRepairOk
		{
			[CompilerGenerated]
			get
			{
				return this.<TotalRepairOk>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<TotalRepairOk>k__BackingField == value)
				{
					return;
				}
				this.<TotalRepairOk>k__BackingField = value;
				this.RaisePropertyChanged("TotalRepairOk");
			}
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x06001D6E RID: 7534 RVA: 0x00055878 File Offset: 0x00053A78
		// (set) Token: 0x06001D6F RID: 7535 RVA: 0x0005588C File Offset: 0x00053A8C
		public int TotalRepairOkWarranty
		{
			[CompilerGenerated]
			get
			{
				return this.<TotalRepairOkWarranty>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<TotalRepairOkWarranty>k__BackingField == value)
				{
					return;
				}
				this.<TotalRepairOkWarranty>k__BackingField = value;
				this.RaisePropertyChanged("TotalRepairOkWarranty");
			}
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x06001D70 RID: 7536 RVA: 0x000558B8 File Offset: 0x00053AB8
		// (set) Token: 0x06001D71 RID: 7537 RVA: 0x000558CC File Offset: 0x00053ACC
		public int TotalRepairOut
		{
			[CompilerGenerated]
			get
			{
				return this.<TotalRepairOut>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<TotalRepairOut>k__BackingField == value)
				{
					return;
				}
				this.<TotalRepairOut>k__BackingField = value;
				this.RaisePropertyChanged("TotalRepairOut");
			}
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x06001D72 RID: 7538 RVA: 0x000558F8 File Offset: 0x00053AF8
		// (set) Token: 0x06001D73 RID: 7539 RVA: 0x0005590C File Offset: 0x00053B0C
		public int TotalNoRepairOut
		{
			[CompilerGenerated]
			get
			{
				return this.<TotalNoRepairOut>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<TotalNoRepairOut>k__BackingField == value)
				{
					return;
				}
				this.<TotalNoRepairOut>k__BackingField = value;
				this.RaisePropertyChanged("TotalNoRepairOut");
			}
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x06001D74 RID: 7540 RVA: 0x00055938 File Offset: 0x00053B38
		// (set) Token: 0x06001D75 RID: 7541 RVA: 0x0005594C File Offset: 0x00053B4C
		public int WarrantyRepairIn
		{
			[CompilerGenerated]
			get
			{
				return this.<WarrantyRepairIn>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<WarrantyRepairIn>k__BackingField == value)
				{
					return;
				}
				this.<WarrantyRepairIn>k__BackingField = value;
				this.RaisePropertyChanged("WarrantyRepairIn");
			}
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x06001D76 RID: 7542 RVA: 0x00055978 File Offset: 0x00053B78
		// (set) Token: 0x06001D77 RID: 7543 RVA: 0x0005598C File Offset: 0x00053B8C
		public int RepeatIn
		{
			[CompilerGenerated]
			get
			{
				return this.<RepeatIn>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<RepeatIn>k__BackingField == value)
				{
					return;
				}
				this.<RepeatIn>k__BackingField = value;
				this.RaisePropertyChanged("RepeatIn");
			}
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x06001D78 RID: 7544 RVA: 0x000559B8 File Offset: 0x00053BB8
		// (set) Token: 0x06001D79 RID: 7545 RVA: 0x000559CC File Offset: 0x00053BCC
		public int ReadyRepairOk
		{
			[CompilerGenerated]
			get
			{
				return this.<ReadyRepairOk>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ReadyRepairOk>k__BackingField == value)
				{
					return;
				}
				this.<ReadyRepairOk>k__BackingField = value;
				this.RaisePropertyChanged("ReadyRepairOk");
			}
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x06001D7A RID: 7546 RVA: 0x000559F8 File Offset: 0x00053BF8
		// (set) Token: 0x06001D7B RID: 7547 RVA: 0x00055A0C File Offset: 0x00053C0C
		public int ReadyRepairNotOk
		{
			[CompilerGenerated]
			get
			{
				return this.<ReadyRepairNotOk>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ReadyRepairNotOk>k__BackingField == value)
				{
					return;
				}
				this.<ReadyRepairNotOk>k__BackingField = value;
				this.RaisePropertyChanged("ReadyRepairNotOk");
			}
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x00023150 File Offset: 0x00021350
		public void RecalcMinPrice()
		{
		}

		// Token: 0x06001D7D RID: 7549 RVA: 0x000069B8 File Offset: 0x00004BB8
		public RepairsStat()
		{
		}

		// Token: 0x04000F6F RID: 3951
		[CompilerGenerated]
		private int <AveragePrice>k__BackingField;

		// Token: 0x04000F70 RID: 3952
		[CompilerGenerated]
		private int <MaxPrice>k__BackingField;

		// Token: 0x04000F71 RID: 3953
		[CompilerGenerated]
		private int <MinPrice>k__BackingField;

		// Token: 0x04000F72 RID: 3954
		[CompilerGenerated]
		private double <RepairsPerDay>k__BackingField;

		// Token: 0x04000F73 RID: 3955
		[CompilerGenerated]
		private int <TotalRepairIn>k__BackingField;

		// Token: 0x04000F74 RID: 3956
		[CompilerGenerated]
		private int <TotalRepairOk>k__BackingField;

		// Token: 0x04000F75 RID: 3957
		[CompilerGenerated]
		private int <TotalRepairOkWarranty>k__BackingField;

		// Token: 0x04000F76 RID: 3958
		[CompilerGenerated]
		private int <TotalRepairOut>k__BackingField;

		// Token: 0x04000F77 RID: 3959
		[CompilerGenerated]
		private int <TotalNoRepairOut>k__BackingField;

		// Token: 0x04000F78 RID: 3960
		[CompilerGenerated]
		private int <WarrantyRepairIn>k__BackingField;

		// Token: 0x04000F79 RID: 3961
		[CompilerGenerated]
		private int <RepeatIn>k__BackingField;

		// Token: 0x04000F7A RID: 3962
		[CompilerGenerated]
		private int <ReadyRepairOk>k__BackingField;

		// Token: 0x04000F7B RID: 3963
		[CompilerGenerated]
		private int <ReadyRepairNotOk>k__BackingField;
	}
}
