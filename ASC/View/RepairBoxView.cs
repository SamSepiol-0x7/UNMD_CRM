using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ASC.View
{
	// Token: 0x02000331 RID: 817
	public class RepairBoxView : UserControl, IComponentConnector
	{
		// Token: 0x060025C6 RID: 9670 RVA: 0x00073860 File Offset: 0x00071A60
		public RepairBoxView()
		{
			this.InitializeComponent();
		}

		// Token: 0x060025C7 RID: 9671 RVA: 0x0007387C File Offset: 0x00071A7C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/ASC;component/view/controls/repairboxview.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060025C8 RID: 9672 RVA: 0x000738AC File Offset: 0x00071AAC
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this._contentLoaded = true;
		}

		// Token: 0x0400143B RID: 5179
		private bool _contentLoaded;
	}
}
