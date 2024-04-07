using System;
using System.Windows;
using DevExpress.Xpf.Grid;

namespace ASC.Extensions
{
	// Token: 0x02000B5E RID: 2910
	public class GridSummaryItemEx : GridSummaryItem
	{
		// Token: 0x170014F3 RID: 5363
		// (get) Token: 0x0600517A RID: 20858 RVA: 0x0015E6EC File Offset: 0x0015C8EC
		// (set) Token: 0x0600517B RID: 20859 RVA: 0x0015E70C File Offset: 0x0015C90C
		public string Name
		{
			get
			{
				return (string)base.GetValue(GridSummaryItemEx.NameProperty);
			}
			set
			{
				base.SetValue(GridSummaryItemEx.NameProperty, value);
			}
		}

		// Token: 0x0600517C RID: 20860 RVA: 0x0015E728 File Offset: 0x0015C928
		public GridSummaryItemEx()
		{
		}

		// Token: 0x0600517D RID: 20861 RVA: 0x0015E73C File Offset: 0x0015C93C
		// Note: this type is marked as 'beforefieldinit'.
		static GridSummaryItemEx()
		{
		}

		// Token: 0x0400359C RID: 13724
		public static readonly DependencyProperty NameProperty = DependencyProperty.Register("Name", typeof(string), typeof(GridSummaryItemEx), new FrameworkPropertyMetadata(null));
	}
}
