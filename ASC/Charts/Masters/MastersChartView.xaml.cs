using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using DevExpress.Xpf.Core.Serialization;
using DevExpress.Xpf.Grid;

namespace ASC.Charts.Masters
{
	// Token: 0x02000292 RID: 658
	public partial class MastersChartView : UserControl
	{
		// Token: 0x0600225F RID: 8799 RVA: 0x000649E4 File Offset: 0x00062BE4
		public MastersChartView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002260 RID: 8800 RVA: 0x0004EE44 File Offset: 0x0004D044
		private void TableView1_OnAllowProperty(object sender, AllowPropertyEventArgs e)
		{
			if (e.Property.Name == "TotalSummary")
			{
				e.Allow = false;
			}
		}
	}
}
