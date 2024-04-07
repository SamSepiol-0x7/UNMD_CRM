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

namespace ASC.Documents
{
	// Token: 0x020001E8 RID: 488
	public partial class DocumentsView : UserControl
	{
		// Token: 0x06001AC5 RID: 6853 RVA: 0x0004EE28 File Offset: 0x0004D028
		public DocumentsView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06001AC6 RID: 6854 RVA: 0x0004EE44 File Offset: 0x0004D044
		private void TableView1_OnAllowProperty(object sender, AllowPropertyEventArgs e)
		{
			if (e.Property.Name == "TotalSummary")
			{
				e.Allow = false;
			}
		}
	}
}
