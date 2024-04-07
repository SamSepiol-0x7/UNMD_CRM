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
	// Token: 0x020000B3 RID: 179
	public class ManagerChangeView : UserControl, IComponentConnector
	{
		// Token: 0x0600130D RID: 4877 RVA: 0x00029A24 File Offset: 0x00027C24
		public ManagerChangeView()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x00029A40 File Offset: 0x00027C40
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/ASC;component/view/managerchangeview.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x00029A70 File Offset: 0x00027C70
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

		// Token: 0x04000927 RID: 2343
		internal ComboBoxEdit ComboBox;

		// Token: 0x04000928 RID: 2344
		private bool _contentLoaded;
	}
}
