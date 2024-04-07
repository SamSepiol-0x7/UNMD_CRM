using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using ASC.View.Controls;

namespace ASC.ClientCard
{
	// Token: 0x0200031F RID: 799
	public class CustomerCallsView : UserControl, IComponentConnector
	{
		// Token: 0x06002588 RID: 9608 RVA: 0x00072CD0 File Offset: 0x00070ED0
		public CustomerCallsView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002589 RID: 9609 RVA: 0x00072CEC File Offset: 0x00070EEC
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/ASC;component/view/customercard/customercallsview.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600258A RID: 9610 RVA: 0x00021F40 File Offset: 0x00020140
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate _CreateDelegate(Type delegateType, string handler)
		{
			return Delegate.CreateDelegate(delegateType, this, handler);
		}

		// Token: 0x0600258B RID: 9611 RVA: 0x00072D1C File Offset: 0x00070F1C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.CallsViewControl = (CallsView)target;
				return;
			}
			this._contentLoaded = true;
		}

		// Token: 0x040013F7 RID: 5111
		internal CallsView CallsViewControl;

		// Token: 0x040013F8 RID: 5112
		private bool _contentLoaded;
	}
}
