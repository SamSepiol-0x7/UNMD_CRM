using System;
using System.Runtime.CompilerServices;

namespace ASC.Charts.RepairStatuses
{
	// Token: 0x0200028F RID: 655
	public class StatusesChart
	{
		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x06002247 RID: 8775 RVA: 0x00064468 File Offset: 0x00062668
		// (set) Token: 0x06002248 RID: 8776 RVA: 0x0006447C File Offset: 0x0006267C
		public int Count
		{
			[CompilerGenerated]
			get
			{
				return this.<Count>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Count>k__BackingField = value;
			}
		}

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x06002249 RID: 8777 RVA: 0x00064490 File Offset: 0x00062690
		// (set) Token: 0x0600224A RID: 8778 RVA: 0x000644A4 File Offset: 0x000626A4
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

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x0600224B RID: 8779 RVA: 0x000644B8 File Offset: 0x000626B8
		// (set) Token: 0x0600224C RID: 8780 RVA: 0x000644CC File Offset: 0x000626CC
		public string Color
		{
			[CompilerGenerated]
			get
			{
				return this.<Color>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Color>k__BackingField = value;
			}
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x0600224D RID: 8781 RVA: 0x000644E0 File Offset: 0x000626E0
		// (set) Token: 0x0600224E RID: 8782 RVA: 0x000644F4 File Offset: 0x000626F4
		public decimal? Summa
		{
			[CompilerGenerated]
			get
			{
				return this.<Summa>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Summa>k__BackingField = value;
			}
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x0600224F RID: 8783 RVA: 0x00064508 File Offset: 0x00062708
		// (set) Token: 0x06002250 RID: 8784 RVA: 0x0006451C File Offset: 0x0006271C
		public string Currency
		{
			[CompilerGenerated]
			get
			{
				return this.<Currency>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Currency>k__BackingField = value;
			}
		} = Auth.CurrencyModel.SelectedCurrency.ShortName;

		// Token: 0x06002251 RID: 8785 RVA: 0x00064530 File Offset: 0x00062730
		public StatusesChart()
		{
		}

		// Token: 0x040011A0 RID: 4512
		[CompilerGenerated]
		private int <Count>k__BackingField;

		// Token: 0x040011A1 RID: 4513
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x040011A2 RID: 4514
		[CompilerGenerated]
		private string <Color>k__BackingField;

		// Token: 0x040011A3 RID: 4515
		[CompilerGenerated]
		private decimal? <Summa>k__BackingField;

		// Token: 0x040011A4 RID: 4516
		[CompilerGenerated]
		private string <Currency>k__BackingField;
	}
}
