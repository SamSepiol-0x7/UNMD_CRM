using System;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;

namespace ASC.Objects
{
	// Token: 0x0200086C RID: 2156
	public class FinancesFlowReportItem : IFinancesFlowReportItem
	{
		// Token: 0x06004000 RID: 16384 RVA: 0x000FF73C File Offset: 0x000FD93C
		public FinancesFlowReportItem(string name, decimal summ)
		{
			this.Name = name;
			this.Summ = summ;
		}

		// Token: 0x06004001 RID: 16385 RVA: 0x000FF760 File Offset: 0x000FD960
		public FinancesFlowReportItem(string name, decimal summ, int type) : this(name, summ)
		{
			this.Type = type;
		}

		// Token: 0x1700112A RID: 4394
		// (get) Token: 0x06004002 RID: 16386 RVA: 0x000FF77C File Offset: 0x000FD97C
		// (set) Token: 0x06004003 RID: 16387 RVA: 0x000FF790 File Offset: 0x000FD990
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

		// Token: 0x1700112B RID: 4395
		// (get) Token: 0x06004004 RID: 16388 RVA: 0x000FF7A4 File Offset: 0x000FD9A4
		// (set) Token: 0x06004005 RID: 16389 RVA: 0x000FF7B8 File Offset: 0x000FD9B8
		public int Type
		{
			[CompilerGenerated]
			get
			{
				return this.<Type>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Type>k__BackingField = value;
			}
		}

		// Token: 0x1700112C RID: 4396
		// (get) Token: 0x06004006 RID: 16390 RVA: 0x000FF7CC File Offset: 0x000FD9CC
		// (set) Token: 0x06004007 RID: 16391 RVA: 0x000FF7E0 File Offset: 0x000FD9E0
		public decimal Summ
		{
			[CompilerGenerated]
			get
			{
				return this.<Summ>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Summ>k__BackingField = value;
			}
		}

		// Token: 0x040029FD RID: 10749
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x040029FE RID: 10750
		[CompilerGenerated]
		private int <Type>k__BackingField;

		// Token: 0x040029FF RID: 10751
		[CompilerGenerated]
		private decimal <Summ>k__BackingField;
	}
}
