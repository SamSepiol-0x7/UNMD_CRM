using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ASC
{
	// Token: 0x02000093 RID: 147
	public class CallsChartView : UserControl, IComponentConnector
	{
		// Token: 0x06001247 RID: 4679 RVA: 0x00021F6C File Offset: 0x0002016C
		public CallsChartView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x00021F88 File Offset: 0x00020188
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this._contentLoaded)
			{
				goto IL_2C;
			}
			IL_08:
			int num = 552928639;
			IL_0D:
			Uri resourceLocator;
			switch ((num ^ 538332538) % 4)
			{
			case 0:
				goto IL_08;
			case 1:
				return;
			case 2:
				IL_2C:
				this._contentLoaded = true;
				resourceLocator = new Uri("/ASC;component/charts/callschart/callschartview.xaml", UriKind.Relative);
				num = 450665789;
				goto IL_0D;
			}
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x00021FE4 File Offset: 0x000201E4
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this._contentLoaded = true;
		}

		// Token: 0x040008A0 RID: 2208
		private bool _contentLoaded;
	}
}
