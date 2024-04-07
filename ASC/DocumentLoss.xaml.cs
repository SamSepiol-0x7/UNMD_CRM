using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using ASC.Models;
using DevExpress.Xpf.Core;

namespace ASC
{
	// Token: 0x020000A2 RID: 162
	public partial class DocumentLoss : ThemedWindow
	{
		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x06001299 RID: 4761 RVA: 0x00023FA8 File Offset: 0x000221A8
		// (set) Token: 0x0600129A RID: 4762 RVA: 0x00023FBC File Offset: 0x000221BC
		public DocumentLossModel DocumentLossModel { get; set; }

		// Token: 0x0600129B RID: 4763 RVA: 0x00023FD0 File Offset: 0x000221D0
		public DocumentLoss(int repairId)
		{
			this.DocumentLossModel = new DocumentLossModel(repairId);
			this.InitializeComponent();
			if (this.DocumentLossModel.CloseAction == null)
			{
				this.DocumentLossModel.CloseAction = new Action(base.Close);
			}
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x0002401C File Offset: 0x0002221C
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			this.DocumentLossModel.Close();
		}
	}
}
