using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using DevExpress.Xpf.Core.Serialization;
using DevExpress.Xpf.Grid;

namespace ASC.Kassa
{
	// Token: 0x02000AE7 RID: 2791
	public partial class KassaView : UserControl
	{
		// Token: 0x06004EF6 RID: 20214 RVA: 0x00156264 File Offset: 0x00154464
		public KassaView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06004EF7 RID: 20215 RVA: 0x0004EE44 File Offset: 0x0004D044
		private void TableView1_OnAllowProperty(object sender, AllowPropertyEventArgs e)
		{
			if (e.Property.Name == "TotalSummary")
			{
				e.Allow = false;
			}
		}
	}
}
