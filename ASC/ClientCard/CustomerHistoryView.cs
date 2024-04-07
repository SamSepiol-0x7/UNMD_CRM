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
	// Token: 0x02000323 RID: 803
	public class CustomerHistoryView : UserControl, IComponentConnector
	{
		// Token: 0x06002595 RID: 9621 RVA: 0x00072FE0 File Offset: 0x000711E0
		public CustomerHistoryView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002596 RID: 9622 RVA: 0x00072FFC File Offset: 0x000711FC
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/ASC;component/view/customercard/customerhistoryview.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002597 RID: 9623 RVA: 0x0007302C File Offset: 0x0007122C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.TableHistory = (GridControl)target;
				return;
			case 2:
				this.Id = (GridColumn)target;
				return;
			case 3:
				this.Date = (GridColumn)target;
				return;
			case 4:
				this.Employee = (GridColumn)target;
				return;
			case 5:
				this.Event = (GridColumn)target;
				return;
			default:
				this._contentLoaded = true;
				return;
			}
		}

		// Token: 0x0400140C RID: 5132
		internal GridControl TableHistory;

		// Token: 0x0400140D RID: 5133
		internal GridColumn Id;

		// Token: 0x0400140E RID: 5134
		internal GridColumn Date;

		// Token: 0x0400140F RID: 5135
		internal GridColumn Employee;

		// Token: 0x04001410 RID: 5136
		internal GridColumn Event;

		// Token: 0x04001411 RID: 5137
		private bool _contentLoaded;
	}
}
