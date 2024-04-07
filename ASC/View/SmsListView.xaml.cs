using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using DevExpress.Xpf.Core.Serialization;
using DevExpress.Xpf.Grid;

namespace ASC.View
{
	// Token: 0x0200035A RID: 858
	public partial class SmsListView : UserControl
	{
		// Token: 0x06002646 RID: 9798 RVA: 0x00074DF8 File Offset: 0x00072FF8
		public SmsListView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002647 RID: 9799 RVA: 0x0004EE44 File Offset: 0x0004D044
		private void TableView1_OnAllowProperty(object sender, AllowPropertyEventArgs e)
		{
			if (e.Property.Name == "TotalSummary")
			{
				e.Allow = false;
			}
		}
	}
}
