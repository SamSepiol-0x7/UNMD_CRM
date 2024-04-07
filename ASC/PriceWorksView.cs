using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using DevExpress.Xpf.Grid;

namespace ASC
{
	// Token: 0x020000C0 RID: 192
	public class PriceWorksView : UserControl, IComponentConnector
	{
		// Token: 0x06001358 RID: 4952 RVA: 0x0002AB64 File Offset: 0x00028D64
		public PriceWorksView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x0002AB80 File Offset: 0x00028D80
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/ASC;component/priceworks/priceworksview.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x0002ABB0 File Offset: 0x00028DB0
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.CollectionSearchControl = (GridSearchControl)target;
				return;
			case 2:
				this.CategoriesListControl = (TreeListControl)target;
				return;
			case 3:
				this.PriceGrid = (GridControl)target;
				return;
			case 4:
				this.CollectionTableView = (TableView)target;
				return;
			default:
				this._contentLoaded = true;
				return;
			}
		}

		// Token: 0x04000953 RID: 2387
		internal GridSearchControl CollectionSearchControl;

		// Token: 0x04000954 RID: 2388
		internal TreeListControl CategoriesListControl;

		// Token: 0x04000955 RID: 2389
		internal GridControl PriceGrid;

		// Token: 0x04000956 RID: 2390
		internal TableView CollectionTableView;

		// Token: 0x04000957 RID: 2391
		private bool _contentLoaded;
	}
}
