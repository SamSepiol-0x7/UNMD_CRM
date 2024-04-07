using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using DevExpress.Xpf.Core.Serialization;
using DevExpress.Xpf.Grid;

namespace ASC.RequestsManager
{
	// Token: 0x02000232 RID: 562
	public partial class RequestsManagerView : UserControl
	{
		// Token: 0x06001EAB RID: 7851 RVA: 0x000581CC File Offset: 0x000563CC
		public RequestsManagerView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x0004EE44 File Offset: 0x0004D044
		private void TableView1_OnAllowProperty(object sender, AllowPropertyEventArgs e)
		{
			if (e.Property.Name == "TotalSummary")
			{
				e.Allow = false;
			}
		}
	}
}
