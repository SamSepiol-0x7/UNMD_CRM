using System;
using System.Runtime.CompilerServices;

namespace ASC.ViewModels.Charts
{
	// Token: 0x02000532 RID: 1330
	public class DashboardReportItem
	{
		// Token: 0x17000F45 RID: 3909
		// (get) Token: 0x06003181 RID: 12673 RVA: 0x000A56D8 File Offset: 0x000A38D8
		// (set) Token: 0x06003182 RID: 12674 RVA: 0x000A56EC File Offset: 0x000A38EC
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.<Name>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x17000F46 RID: 3910
		// (get) Token: 0x06003183 RID: 12675 RVA: 0x000A5700 File Offset: 0x000A3900
		// (set) Token: 0x06003184 RID: 12676 RVA: 0x000A5714 File Offset: 0x000A3914
		public decimal Value
		{
			[CompilerGenerated]
			get
			{
				return this.<Value>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Value>k__BackingField = value;
			}
		}

		// Token: 0x06003185 RID: 12677 RVA: 0x000046B4 File Offset: 0x000028B4
		public DashboardReportItem()
		{
		}

		// Token: 0x06003186 RID: 12678 RVA: 0x000A5728 File Offset: 0x000A3928
		public DashboardReportItem(string name, decimal value)
		{
			this.Name = name;
			this.Value = value;
		}

		// Token: 0x04001C6A RID: 7274
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04001C6B RID: 7275
		[CompilerGenerated]
		private decimal <Value>k__BackingField;
	}
}
