using System;
using System.Windows;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Grid;

namespace ASC.Extensions
{
	// Token: 0x02000B5D RID: 2909
	public class ColumnResizeGrip : DXThumb, IColumnPropertyOwner
	{
		// Token: 0x170014F0 RID: 5360
		// (get) Token: 0x06005173 RID: 20851 RVA: 0x0015E610 File Offset: 0x0015C810
		private ResizeHelper ResizeHelper
		{
			get
			{
				return this.resizeHelper;
			}
		}

		// Token: 0x06005174 RID: 20852 RVA: 0x0015E624 File Offset: 0x0015C824
		public ColumnResizeGrip()
		{
			this.resizeHelper = new ResizeHelper(new ColumnResizeHelperOwner(this));
			base.Loaded += this.ColumnResizeGrip_Loaded;
		}

		// Token: 0x06005175 RID: 20853 RVA: 0x0015E65C File Offset: 0x0015C85C
		private void ColumnResizeGrip_Loaded(object sender, RoutedEventArgs e)
		{
			EditGridCellData editGridCellData = base.DataContext as EditGridCellData;
			this.column = editGridCellData.Column;
			base.Visibility = (this.column.ActualAllowResizing ? Visibility.Visible : Visibility.Collapsed);
			this.ResizeHelper.Init(this);
		}

		// Token: 0x06005176 RID: 20854 RVA: 0x0015E6A4 File Offset: 0x0015C8A4
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
		}

		// Token: 0x170014F1 RID: 5361
		// (get) Token: 0x06005177 RID: 20855 RVA: 0x0015E6B8 File Offset: 0x0015C8B8
		double IColumnPropertyOwner.ActualWidth
		{
			get
			{
				return (base.TemplatedParent as FrameworkElement).ActualWidth;
			}
		}

		// Token: 0x170014F2 RID: 5362
		// (get) Token: 0x06005178 RID: 20856 RVA: 0x0015E6D8 File Offset: 0x0015C8D8
		BaseColumn IColumnPropertyOwner.Column
		{
			get
			{
				return this.column;
			}
		}

		// Token: 0x06005179 RID: 20857 RVA: 0x000304B4 File Offset: 0x0002E6B4
		FixedStyle IColumnPropertyOwner.GetActualFixedStyle()
		{
			return FixedStyle.None;
		}

		// Token: 0x0400359A RID: 13722
		private ColumnBase column;

		// Token: 0x0400359B RID: 13723
		private ResizeHelper resizeHelper;
	}
}
