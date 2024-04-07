using System;
using System.Runtime.CompilerServices;

namespace ASC.ViewModels.Charts
{
	// Token: 0x0200052F RID: 1327
	public class DashboardReport
	{
		// Token: 0x17000F3D RID: 3901
		// (get) Token: 0x06003169 RID: 12649 RVA: 0x000A5434 File Offset: 0x000A3634
		// (set) Token: 0x0600316A RID: 12650 RVA: 0x000A5448 File Offset: 0x000A3648
		public CashReport InCashReport
		{
			[CompilerGenerated]
			get
			{
				return this.<InCashReport>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<InCashReport>k__BackingField = value;
			}
		}

		// Token: 0x17000F3E RID: 3902
		// (get) Token: 0x0600316B RID: 12651 RVA: 0x000A545C File Offset: 0x000A365C
		// (set) Token: 0x0600316C RID: 12652 RVA: 0x000A5470 File Offset: 0x000A3670
		public CashReport OutCashReport
		{
			[CompilerGenerated]
			get
			{
				return this.<OutCashReport>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<OutCashReport>k__BackingField = value;
			}
		}

		// Token: 0x17000F3F RID: 3903
		// (get) Token: 0x0600316D RID: 12653 RVA: 0x000A5484 File Offset: 0x000A3684
		// (set) Token: 0x0600316E RID: 12654 RVA: 0x000A5498 File Offset: 0x000A3698
		public CashReport InPaymentSystems
		{
			[CompilerGenerated]
			get
			{
				return this.<InPaymentSystems>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<InPaymentSystems>k__BackingField = value;
			}
		}

		// Token: 0x17000F40 RID: 3904
		// (get) Token: 0x0600316F RID: 12655 RVA: 0x000A54AC File Offset: 0x000A36AC
		// (set) Token: 0x06003170 RID: 12656 RVA: 0x000A54C0 File Offset: 0x000A36C0
		public CashReport OutPaymentSystems
		{
			[CompilerGenerated]
			get
			{
				return this.<OutPaymentSystems>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<OutPaymentSystems>k__BackingField = value;
			}
		}

		// Token: 0x06003171 RID: 12657 RVA: 0x000A54D4 File Offset: 0x000A36D4
		public DashboardReport()
		{
			this.InCashReport = new CashReport();
			this.OutCashReport = new CashReport();
			this.InPaymentSystems = new CashReport();
			this.OutPaymentSystems = new CashReport();
		}

		// Token: 0x04001C60 RID: 7264
		[CompilerGenerated]
		private CashReport <InCashReport>k__BackingField;

		// Token: 0x04001C61 RID: 7265
		[CompilerGenerated]
		private CashReport <OutCashReport>k__BackingField;

		// Token: 0x04001C62 RID: 7266
		[CompilerGenerated]
		private CashReport <InPaymentSystems>k__BackingField;

		// Token: 0x04001C63 RID: 7267
		[CompilerGenerated]
		private CashReport <OutPaymentSystems>k__BackingField;
	}
}
