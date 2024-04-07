using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using DevExpress.Xpf.Grid;

namespace ASC.ClientCard
{
	// Token: 0x02000326 RID: 806
	public class CustomerPurchasesView : UserControl, IComponentConnector
	{
		// Token: 0x0600259F RID: 9631 RVA: 0x000731C8 File Offset: 0x000713C8
		public CustomerPurchasesView()
		{
			this.InitializeComponent();
		}

		// Token: 0x060025A0 RID: 9632 RVA: 0x000731E4 File Offset: 0x000713E4
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/ASC;component/view/customercard/customerpurchasesview.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060025A1 RID: 9633 RVA: 0x00073214 File Offset: 0x00071414
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.ClientPurchaseTable = (GridControl)target;
				return;
			case 2:
				this.Id = (GridColumn)target;
				return;
			case 3:
				this.Date = (GridColumn)target;
				return;
			case 4:
				this.Item = (GridColumn)target;
				return;
			case 5:
				this.Manager = (GridColumn)target;
				return;
			case 6:
				this.Count = (GridColumn)target;
				return;
			default:
				this._contentLoaded = true;
				return;
			}
		}

		// Token: 0x04001415 RID: 5141
		internal GridControl ClientPurchaseTable;

		// Token: 0x04001416 RID: 5142
		internal GridColumn Id;

		// Token: 0x04001417 RID: 5143
		internal GridColumn Date;

		// Token: 0x04001418 RID: 5144
		internal GridColumn Item;

		// Token: 0x04001419 RID: 5145
		internal GridColumn Manager;

		// Token: 0x0400141A RID: 5146
		internal GridColumn Count;

		// Token: 0x0400141B RID: 5147
		private bool _contentLoaded;
	}
}
