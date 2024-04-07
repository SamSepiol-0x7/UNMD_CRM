using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Media;

namespace ASC.ViewModels.Charts
{
	// Token: 0x02000530 RID: 1328
	public class CashReport
	{
		// Token: 0x17000F41 RID: 3905
		// (get) Token: 0x06003172 RID: 12658 RVA: 0x000A5514 File Offset: 0x000A3714
		// (set) Token: 0x06003173 RID: 12659 RVA: 0x000A5528 File Offset: 0x000A3728
		public string ReportName
		{
			[CompilerGenerated]
			get
			{
				return this.<ReportName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ReportName>k__BackingField = value;
			}
		}

		// Token: 0x17000F42 RID: 3906
		// (get) Token: 0x06003174 RID: 12660 RVA: 0x000A553C File Offset: 0x000A373C
		// (set) Token: 0x06003175 RID: 12661 RVA: 0x000A5550 File Offset: 0x000A3750
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
				this.<Total>k__BackingField = value;
			}
		}

		// Token: 0x17000F43 RID: 3907
		// (get) Token: 0x06003176 RID: 12662 RVA: 0x000A5564 File Offset: 0x000A3764
		// (set) Token: 0x06003177 RID: 12663 RVA: 0x000A5578 File Offset: 0x000A3778
		public Brush TotalColor
		{
			[CompilerGenerated]
			get
			{
				return this.<TotalColor>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<TotalColor>k__BackingField = value;
			}
		}

		// Token: 0x17000F44 RID: 3908
		// (get) Token: 0x06003178 RID: 12664 RVA: 0x000A558C File Offset: 0x000A378C
		// (set) Token: 0x06003179 RID: 12665 RVA: 0x000A55A0 File Offset: 0x000A37A0
		public List<DashboardReportItem> Details
		{
			[CompilerGenerated]
			get
			{
				return this.<Details>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Details>k__BackingField = value;
			}
		}

		// Token: 0x0600317A RID: 12666 RVA: 0x000A55B4 File Offset: 0x000A37B4
		public CashReport()
		{
			this.Details = new List<DashboardReportItem>();
		}

		// Token: 0x0600317B RID: 12667 RVA: 0x000A55D4 File Offset: 0x000A37D4
		public void SetDetails(IEnumerable<DashboardReportItem> items)
		{
			this.Details.Clear();
			this.Details.AddRange(items);
			this.CalcTotal();
		}

		// Token: 0x0600317C RID: 12668 RVA: 0x000A5600 File Offset: 0x000A3800
		private void CalcTotal()
		{
			decimal num = (from d in this.Details
			select d.Value).DefaultIfEmpty<decimal>().Sum();
			for (;;)
			{
				IL_76:
				int num2 = -1343347033;
				for (;;)
				{
					switch ((num2 ^ -812147775) % 3)
					{
					case 1:
						this.TotalColor = ((num > 0m) ? Brushes.DarkGreen : Brushes.DarkRed);
						num2 = -811158242;
						continue;
					case 2:
						goto IL_76;
					}
					goto Block_3;
				}
			}
			Block_3:
			this.Total = Math.Abs(num);
		}

		// Token: 0x0600317D RID: 12669 RVA: 0x000A5698 File Offset: 0x000A3898
		public void SetReportName(string name)
		{
			this.ReportName = name;
		}

		// Token: 0x04001C64 RID: 7268
		[CompilerGenerated]
		private string <ReportName>k__BackingField;

		// Token: 0x04001C65 RID: 7269
		[CompilerGenerated]
		private decimal <Total>k__BackingField;

		// Token: 0x04001C66 RID: 7270
		[CompilerGenerated]
		private Brush <TotalColor>k__BackingField;

		// Token: 0x04001C67 RID: 7271
		[CompilerGenerated]
		private List<DashboardReportItem> <Details>k__BackingField;

		// Token: 0x02000531 RID: 1329
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600317E RID: 12670 RVA: 0x000A56AC File Offset: 0x000A38AC
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600317F RID: 12671 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06003180 RID: 12672 RVA: 0x000A56C4 File Offset: 0x000A38C4
			internal decimal <CalcTotal>b__18_0(DashboardReportItem d)
			{
				return d.Value;
			}

			// Token: 0x04001C68 RID: 7272
			public static readonly CashReport.<>c <>9 = new CashReport.<>c();

			// Token: 0x04001C69 RID: 7273
			public static Func<DashboardReportItem, decimal> <>9__18_0;
		}
	}
}
