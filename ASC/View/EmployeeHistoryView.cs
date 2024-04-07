using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ASC.View
{
	// Token: 0x0200032C RID: 812
	public class EmployeeHistoryView : UserControl, IComponentConnector
	{
		// Token: 0x060025B2 RID: 9650 RVA: 0x0007353C File Offset: 0x0007173C
		public EmployeeHistoryView()
		{
			this.InitializeComponent();
		}

		// Token: 0x060025B3 RID: 9651 RVA: 0x00073558 File Offset: 0x00071758
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/ASC;component/view/employee/employeehistoryview.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060025B4 RID: 9652 RVA: 0x00073588 File Offset: 0x00071788
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this._contentLoaded = true;
		}

		// Token: 0x04001429 RID: 5161
		private bool _contentLoaded;
	}
}
