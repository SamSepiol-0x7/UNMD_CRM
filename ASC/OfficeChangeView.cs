using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using DevExpress.Xpf.Editors;

namespace ASC
{
	// Token: 0x020000B7 RID: 183
	public class OfficeChangeView : UserControl, IComponentConnector
	{
		// Token: 0x0600131D RID: 4893 RVA: 0x00029E60 File Offset: 0x00028060
		public OfficeChangeView()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x00029E7C File Offset: 0x0002807C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/ASC;component/view/officechangeview.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x00029EAC File Offset: 0x000280AC
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.ComboBox = (ComboBoxEdit)target;
				return;
			}
			this._contentLoaded = true;
		}

		// Token: 0x04000938 RID: 2360
		internal ComboBoxEdit ComboBox;

		// Token: 0x04000939 RID: 2361
		private bool _contentLoaded;
	}
}
