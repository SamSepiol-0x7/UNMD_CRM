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

namespace ASC.StoreSimple
{
	// Token: 0x020002DB RID: 731
	public partial class StoreV2View : UserControl
	{
		// Token: 0x06002437 RID: 9271 RVA: 0x0006C24C File Offset: 0x0006A44C
		public StoreV2View()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002438 RID: 9272 RVA: 0x0004EE44 File Offset: 0x0004D044
		private void ProductsGrid_AllowProperty(object sender, AllowPropertyEventArgs e)
		{
			if (e.Property.Name == "TotalSummary")
			{
				e.Allow = false;
			}
		}

		// Token: 0x06002439 RID: 9273 RVA: 0x0006C268 File Offset: 0x0006A468
		private void TableView1_OnAllowProperty(object sender, AllowPropertyEventArgs e)
		{
			if (e.Property.Name == "SearchString")
			{
				e.Allow = false;
			}
		}
	}
}
