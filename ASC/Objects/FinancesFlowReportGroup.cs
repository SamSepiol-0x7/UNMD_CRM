using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;

namespace ASC.Objects
{
	// Token: 0x0200086A RID: 2154
	public class FinancesFlowReportGroup : IFinancesFlowReportGroup
	{
		// Token: 0x17001127 RID: 4391
		// (get) Token: 0x06003FF6 RID: 16374 RVA: 0x000FF648 File Offset: 0x000FD848
		// (set) Token: 0x06003FF7 RID: 16375 RVA: 0x000FF65C File Offset: 0x000FD85C
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

		// Token: 0x17001128 RID: 4392
		// (get) Token: 0x06003FF8 RID: 16376 RVA: 0x000FF670 File Offset: 0x000FD870
		public ObservableCollection<IFinancesFlowReportItem> Items
		{
			[CompilerGenerated]
			get
			{
				return this.<Items>k__BackingField;
			}
		}

		// Token: 0x17001129 RID: 4393
		// (get) Token: 0x06003FF9 RID: 16377 RVA: 0x000FF684 File Offset: 0x000FD884
		public decimal Total
		{
			get
			{
				return (from i in this.Items
				select i.Summ).DefaultIfEmpty<decimal>().Sum();
			}
		}

		// Token: 0x06003FFA RID: 16378 RVA: 0x000FF6C8 File Offset: 0x000FD8C8
		public FinancesFlowReportGroup(string name)
		{
			this.Name = name;
			this.Items = new ObservableCollection<IFinancesFlowReportItem>();
		}

		// Token: 0x06003FFB RID: 16379 RVA: 0x000FF6F0 File Offset: 0x000FD8F0
		public void ClearItems()
		{
			this.Items.Clear();
		}

		// Token: 0x06003FFC RID: 16380 RVA: 0x000FF708 File Offset: 0x000FD908
		public void AddItem(IFinancesFlowReportItem item)
		{
			this.Items.Add(item);
		}

		// Token: 0x040029F9 RID: 10745
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x040029FA RID: 10746
		[CompilerGenerated]
		private readonly ObservableCollection<IFinancesFlowReportItem> <Items>k__BackingField;

		// Token: 0x0200086B RID: 2155
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003FFD RID: 16381 RVA: 0x000FF724 File Offset: 0x000FD924
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003FFE RID: 16382 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06003FFF RID: 16383 RVA: 0x000A480C File Offset: 0x000A2A0C
			internal decimal <get_Total>b__8_0(IFinancesFlowReportItem i)
			{
				return i.Summ;
			}

			// Token: 0x040029FB RID: 10747
			public static readonly FinancesFlowReportGroup.<>c <>9 = new FinancesFlowReportGroup.<>c();

			// Token: 0x040029FC RID: 10748
			public static Func<IFinancesFlowReportItem, decimal> <>9__8_0;
		}
	}
}
