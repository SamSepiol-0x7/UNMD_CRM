using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Grid;

namespace ASC.Workspace.Repairs
{
	// Token: 0x0200011A RID: 282
	public partial class RepairsView : UserControl
	{
		// Token: 0x06001446 RID: 5190 RVA: 0x0002DB1C File Offset: 0x0002BD1C
		public RepairsView()
		{
			try
			{
				this.InitializeComponent();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + " == Application shutdown now ==");
				Application.Current.Shutdown();
			}
		}
	}
}
