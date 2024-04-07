using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Threading;
using DevExpress.Xpf.Grid;

namespace ASC.EFExtensions
{
	// Token: 0x02000BCE RID: 3022
	public class CommitHelper
	{
		// Token: 0x06005471 RID: 21617 RVA: 0x0016B9B0 File Offset: 0x00169BB0
		public static void SetCommitOnValueChanged(GridColumn element, bool value)
		{
			element.SetValue(CommitHelper.CommitOnValueChangedProperty, value);
		}

		// Token: 0x06005472 RID: 21618 RVA: 0x0016B9D0 File Offset: 0x00169BD0
		public static bool GetCommitOnValueChanged(GridColumn element)
		{
			return (bool)element.GetValue(CommitHelper.CommitOnValueChangedProperty);
		}

		// Token: 0x06005473 RID: 21619 RVA: 0x0016B9F0 File Offset: 0x00169BF0
		private static void CommitOnValueChangedPropertyChanged(DependencyObject source, DependencyPropertyChangedEventArgs e)
		{
			GridColumn gridColumn = source as GridColumn;
			if (gridColumn.View != null)
			{
				CommitHelper.ToggleCellValueChanging(gridColumn, (bool)e.NewValue);
				return;
			}
			Dispatcher.CurrentDispatcher.BeginInvoke(new Action<GridColumn, bool>(delegate(GridColumn column, bool subscribe)
			{
				CommitHelper.ToggleCellValueChanging(column, subscribe);
			}), new object[]
			{
				gridColumn,
				(bool)e.NewValue
			});
		}

		// Token: 0x06005474 RID: 21620 RVA: 0x0016BA68 File Offset: 0x00169C68
		private static void ToggleCellValueChanging(GridColumn col, bool subscribe)
		{
			TableView tableView = col.View as TableView;
			if (tableView == null)
			{
				return;
			}
			if (subscribe)
			{
				tableView.CellValueChanging += CommitHelper.view_CellValueChanging;
				return;
			}
			tableView.CellValueChanging -= CommitHelper.view_CellValueChanging;
		}

		// Token: 0x06005475 RID: 21621 RVA: 0x0016BAB0 File Offset: 0x00169CB0
		private static void view_CellValueChanging(object sender, CellValueChangedEventArgs e)
		{
			TableView tableView = sender as TableView;
			if ((bool)e.Column.GetValue(CommitHelper.CommitOnValueChangedProperty))
			{
				tableView.PostEditor();
			}
		}

		// Token: 0x06005476 RID: 21622 RVA: 0x000046B4 File Offset: 0x000028B4
		public CommitHelper()
		{
		}

		// Token: 0x06005477 RID: 21623 RVA: 0x0016BAE4 File Offset: 0x00169CE4
		// Note: this type is marked as 'beforefieldinit'.
		static CommitHelper()
		{
		}

		// Token: 0x040037F7 RID: 14327
		public static readonly DependencyProperty CommitOnValueChangedProperty = DependencyProperty.RegisterAttached("CommitOnValueChanged", typeof(bool), typeof(CommitHelper), new PropertyMetadata(new PropertyChangedCallback(CommitHelper.CommitOnValueChangedPropertyChanged)));

		// Token: 0x02000BCF RID: 3023
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005478 RID: 21624 RVA: 0x0016BB28 File Offset: 0x00169D28
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06005479 RID: 21625 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x0600547A RID: 21626 RVA: 0x0016BB40 File Offset: 0x00169D40
			internal void <CommitOnValueChangedPropertyChanged>b__3_0(GridColumn column, bool subscribe)
			{
				CommitHelper.ToggleCellValueChanging(column, subscribe);
			}

			// Token: 0x040037F8 RID: 14328
			public static readonly CommitHelper.<>c <>9 = new CommitHelper.<>c();

			// Token: 0x040037F9 RID: 14329
			public static Action<GridColumn, bool> <>9__3_0;
		}
	}
}
