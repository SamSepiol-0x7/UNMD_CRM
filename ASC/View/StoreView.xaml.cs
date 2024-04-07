using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using ASC.Extensions;
using ASC.Properties;
using DevExpress.Xpf.Grid;

namespace ASC.View
{
	// Token: 0x0200036A RID: 874
	public partial class StoreView : UserControl
	{
		// Token: 0x06002677 RID: 9847 RVA: 0x000755A0 File Offset: 0x000737A0
		public StoreView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002678 RID: 9848 RVA: 0x000755BC File Offset: 0x000737BC
		private void StoreView_OnUnloaded(object sender, RoutedEventArgs e)
		{
			Auth.User.PutCategoriesStateToUserConfig();
			Settings.Default.Save();
		}

		// Token: 0x06002679 RID: 9849 RVA: 0x000755E0 File Offset: 0x000737E0
		private void TableView_OnRowDoubleClick(object sender, RowDoubleClickEventArgs e)
		{
			if (!this.TableView.Grid.IsMasterRowExpanded(e.HitInfo.RowHandle, null))
			{
				this.TableView.Grid.ExpandMasterRow(e.HitInfo.RowHandle, null);
				return;
			}
			this.TableView.Grid.CollapseMasterRow(e.HitInfo.RowHandle, null);
		}
	}
}
