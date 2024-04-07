using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Grid;

namespace ASC.ItemsSale
{
	// Token: 0x020001C9 RID: 457
	public partial class ItemsSaleView : UserControl
	{
		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x060019CC RID: 6604 RVA: 0x0004A184 File Offset: 0x00048384
		// (set) Token: 0x060019CD RID: 6605 RVA: 0x0004A198 File Offset: 0x00048398
		public ItemsSaleViewModel ItemsSaleViewModel { get; set; }

		// Token: 0x060019CE RID: 6606 RVA: 0x0004A1AC File Offset: 0x000483AC
		public ItemsSaleView()
		{
			this.ItemsSaleViewModel = new ItemsSaleViewModel();
			this.InitializeComponent();
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x0004A1D0 File Offset: 0x000483D0
		public ItemsSaleView(store_items item)
		{
			this.ItemsSaleViewModel = new ItemsSaleViewModel(item);
			this.InitializeComponent();
		}
	}
}
