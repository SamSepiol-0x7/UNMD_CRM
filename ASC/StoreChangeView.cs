using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ASC
{
	// Token: 0x020000B2 RID: 178
	public class StoreChangeView : UserControl, IComponentConnector
	{
		// Token: 0x06001309 RID: 4873 RVA: 0x000299B0 File Offset: 0x00027BB0
		public StoreChangeView()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x000299CC File Offset: 0x00027BCC
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/ASC;component/view/storechangeview.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x00021F40 File Offset: 0x00020140
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate _CreateDelegate(Type delegateType, string handler)
		{
			return Delegate.CreateDelegate(delegateType, this, handler);
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x000299FC File Offset: 0x00027BFC
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.StoreChangeViewUC = (StoreChangeView)target;
				return;
			}
			this._contentLoaded = true;
		}

		// Token: 0x04000925 RID: 2341
		internal StoreChangeView StoreChangeViewUC;

		// Token: 0x04000926 RID: 2342
		private bool _contentLoaded;
	}
}
