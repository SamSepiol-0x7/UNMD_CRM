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
	// Token: 0x02000330 RID: 816
	public partial class ProductsMoveView : UserControl
	{
		// Token: 0x060025C1 RID: 9665 RVA: 0x00073740 File Offset: 0x00071940
		public ProductsMoveView()
		{
			this.InitializeComponent();
		}

		// Token: 0x060025C2 RID: 9666 RVA: 0x00022914 File Offset: 0x00020B14
		private void MoveGrid_OnAllowProperty(object sender, AllowPropertyEventArgs e)
		{
			if (e.Property.Name == "TotalSummary" || e.Property.Name == "SearchString")
			{
				e.Allow = false;
			}
		}
	}
}
