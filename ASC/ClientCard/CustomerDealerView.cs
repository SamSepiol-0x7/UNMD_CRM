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
	// Token: 0x02000320 RID: 800
	public class CustomerDealerView : UserControl, IComponentConnector
	{
		// Token: 0x0600258C RID: 9612 RVA: 0x00072D44 File Offset: 0x00070F44
		public CustomerDealerView()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600258D RID: 9613 RVA: 0x00072D60 File Offset: 0x00070F60
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this._contentLoaded)
			{
				goto IL_2C;
			}
			IL_08:
			int num = 1192009903;
			IL_0D:
			switch ((num ^ 1241385309) % 4)
			{
			case 0:
				goto IL_08;
			case 2:
				return;
			case 3:
				IL_2C:
				this._contentLoaded = true;
				num = 1680027212;
				goto IL_0D;
			}
			Uri resourceLocator = new Uri("/ASC;component/view/customercard/customerdealerview.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600258E RID: 9614 RVA: 0x00072DBC File Offset: 0x00070FBC
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.DealerUserControl = (CustomerDealerView)target;
				return;
			case 2:
				this.RealizItemsTable = (GridControl)target;
				return;
			case 3:
				this.TableView = (TableView)target;
				return;
			default:
				this._contentLoaded = true;
				return;
			}
		}

		// Token: 0x040013F9 RID: 5113
		internal CustomerDealerView DealerUserControl;

		// Token: 0x040013FA RID: 5114
		internal GridControl RealizItemsTable;

		// Token: 0x040013FB RID: 5115
		internal TableView TableView;

		// Token: 0x040013FC RID: 5116
		private bool _contentLoaded;
	}
}
