using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ASC.ClientCard
{
	// Token: 0x02000324 RID: 804
	public class CustomerInvoicesView : UserControl, IComponentConnector
	{
		// Token: 0x06002598 RID: 9624 RVA: 0x000730A0 File Offset: 0x000712A0
		public CustomerInvoicesView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002599 RID: 9625 RVA: 0x000730BC File Offset: 0x000712BC
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/ASC;component/view/customercard/customerinvoicesview.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600259A RID: 9626 RVA: 0x000730EC File Offset: 0x000712EC
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this._contentLoaded = true;
		}

		// Token: 0x04001412 RID: 5138
		private bool _contentLoaded;
	}
}
