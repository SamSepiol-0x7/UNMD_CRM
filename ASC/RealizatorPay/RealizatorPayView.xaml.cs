using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Grid;

namespace ASC.RealizatorPay
{
	// Token: 0x02000164 RID: 356
	public partial class RealizatorPayView : ThemedWindow
	{
		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x060016D9 RID: 5849 RVA: 0x0003A75C File Offset: 0x0003895C
		// (set) Token: 0x060016DA RID: 5850 RVA: 0x0003A770 File Offset: 0x00038970
		public PayViewModel PayViewModel { get; set; }

		// Token: 0x060016DB RID: 5851 RVA: 0x0003A784 File Offset: 0x00038984
		public RealizatorPayView(int realizatorId)
		{
			this.PayViewModel = new PayViewModel(realizatorId);
			this.InitializeComponent();
			this.PayViewModel.CloseAction = new Action(base.Close);
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x0003A7C0 File Offset: 0x000389C0
		public RealizatorPayView(int paymentId, bool setTrue)
		{
			this.PayViewModel = new PayViewModel(paymentId, setTrue);
			this.InitializeComponent();
			this.PayViewModel.CloseAction = new Action(base.Close);
		}
	}
}
