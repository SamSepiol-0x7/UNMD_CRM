using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;
using DevExpress.Xpf.WindowsUI;

namespace ASC.ClientCard
{
	// Token: 0x02000321 RID: 801
	public class CustomerEditView : NavigationPage, IComponentConnector
	{
		// Token: 0x0600258F RID: 9615 RVA: 0x00072E0C File Offset: 0x0007100C
		public CustomerEditView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002590 RID: 9616 RVA: 0x00072E28 File Offset: 0x00071028
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/ASC;component/view/customercard/customereditview.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002591 RID: 9617 RVA: 0x00072E58 File Offset: 0x00071058
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.CustomerEditUc = (CustomerEditView)target;
				return;
			}
			this._contentLoaded = true;
		}

		// Token: 0x040013FD RID: 5117
		internal CustomerEditView CustomerEditUc;

		// Token: 0x040013FE RID: 5118
		private bool _contentLoaded;
	}
}
