using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ASC
{
	// Token: 0x020000B4 RID: 180
	public class StickersView : UserControl, IComponentConnector
	{
		// Token: 0x06001310 RID: 4880 RVA: 0x00029A98 File Offset: 0x00027C98
		public StickersView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x00029AB4 File Offset: 0x00027CB4
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/ASC;component/stickers/stickersview.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x00029AE4 File Offset: 0x00027CE4
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this._contentLoaded = true;
		}

		// Token: 0x04000929 RID: 2345
		private bool _contentLoaded;
	}
}
