using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ASC
{
	// Token: 0x020000BF RID: 191
	public class PriceItemView : UserControl, IComponentConnector
	{
		// Token: 0x06001355 RID: 4949 RVA: 0x0002AB04 File Offset: 0x00028D04
		public PriceItemView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x0002AB20 File Offset: 0x00028D20
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/ASC;component/priceworks/itemeditor/priceitemview.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x0002AB50 File Offset: 0x00028D50
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this._contentLoaded = true;
		}

		// Token: 0x04000952 RID: 2386
		private bool _contentLoaded;
	}
}
