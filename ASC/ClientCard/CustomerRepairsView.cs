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
	// Token: 0x02000327 RID: 807
	public class CustomerRepairsView : UserControl, IComponentConnector
	{
		// Token: 0x060025A2 RID: 9634 RVA: 0x00073298 File Offset: 0x00071498
		public CustomerRepairsView()
		{
			this.InitializeComponent();
		}

		// Token: 0x060025A3 RID: 9635 RVA: 0x000732B4 File Offset: 0x000714B4
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/ASC;component/view/customercard/customerrepairsview.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060025A4 RID: 9636 RVA: 0x000732E4 File Offset: 0x000714E4
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.ClientRepairsTable = (GridControl)target;
				return;
			case 2:
				this.Id = (GridColumn)target;
				return;
			case 3:
				this.Date = (GridColumn)target;
				return;
			case 4:
				this.IssueDate = (GridColumn)target;
				return;
			case 5:
				this.Device = (GridColumn)target;
				return;
			case 6:
				this.Status = (GridColumn)target;
				return;
			default:
				this._contentLoaded = true;
				return;
			}
		}

		// Token: 0x0400141C RID: 5148
		internal GridControl ClientRepairsTable;

		// Token: 0x0400141D RID: 5149
		internal GridColumn Id;

		// Token: 0x0400141E RID: 5150
		internal GridColumn Date;

		// Token: 0x0400141F RID: 5151
		internal GridColumn IssueDate;

		// Token: 0x04001420 RID: 5152
		internal GridColumn Device;

		// Token: 0x04001421 RID: 5153
		internal GridColumn Status;

		// Token: 0x04001422 RID: 5154
		private bool _contentLoaded;
	}
}
