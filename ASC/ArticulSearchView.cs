using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ASC
{
	// Token: 0x02000092 RID: 146
	public class ArticulSearchView : UserControl, IComponentConnector
	{
		// Token: 0x06001243 RID: 4675 RVA: 0x00021EF4 File Offset: 0x000200F4
		public ArticulSearchView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x00021F10 File Offset: 0x00020110
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/ASC;component/articulsearch/articulsearchview.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x00021F40 File Offset: 0x00020140
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate _CreateDelegate(Type delegateType, string handler)
		{
			return Delegate.CreateDelegate(delegateType, this, handler);
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x00021F58 File Offset: 0x00020158
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this._contentLoaded = true;
		}

		// Token: 0x0400089F RID: 2207
		private bool _contentLoaded;
	}
}
