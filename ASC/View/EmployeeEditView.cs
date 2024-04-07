using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ASC.View
{
	// Token: 0x02000342 RID: 834
	public class EmployeeEditView : UserControl, IComponentConnector
	{
		// Token: 0x060025F9 RID: 9721 RVA: 0x000740DC File Offset: 0x000722DC
		public EmployeeEditView()
		{
			this.InitializeComponent();
		}

		// Token: 0x060025FA RID: 9722 RVA: 0x000740F8 File Offset: 0x000722F8
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/ASC;component/view/employee/employeeeditview.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060025FB RID: 9723 RVA: 0x00021F40 File Offset: 0x00020140
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate _CreateDelegate(Type delegateType, string handler)
		{
			return Delegate.CreateDelegate(delegateType, this, handler);
		}

		// Token: 0x060025FC RID: 9724 RVA: 0x00074128 File Offset: 0x00072328
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.Phone1Mask = (ComboBox)target;
				return;
			}
			if (connectionId != 2)
			{
				this._contentLoaded = true;
				return;
			}
			this.Phone2Mask = (ComboBox)target;
		}

		// Token: 0x0400145D RID: 5213
		internal ComboBox Phone1Mask;

		// Token: 0x0400145E RID: 5214
		internal ComboBox Phone2Mask;

		// Token: 0x0400145F RID: 5215
		private bool _contentLoaded;
	}
}
