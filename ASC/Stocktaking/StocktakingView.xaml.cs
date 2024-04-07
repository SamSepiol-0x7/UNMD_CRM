using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using DevExpress.Xpf.Bars;
using DevExpress.Xpf.Core.Serialization;
using DevExpress.Xpf.Grid;

namespace ASC.Stocktaking
{
	// Token: 0x020001EA RID: 490
	public partial class StocktakingView : UserControl
	{
		// Token: 0x06001AE7 RID: 6887 RVA: 0x0004F674 File Offset: 0x0004D874
		public StocktakingView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06001AE8 RID: 6888 RVA: 0x0004EE44 File Offset: 0x0004D044
		private void TableView1_OnAllowProperty(object sender, AllowPropertyEventArgs e)
		{
			if (e.Property.Name == "TotalSummary")
			{
				e.Allow = false;
			}
		}
	}
}
