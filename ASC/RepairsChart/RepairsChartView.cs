using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ASC.RepairsChart
{
	// Token: 0x0200015A RID: 346
	public class RepairsChartView : UserControl, IComponentConnector
	{
		// Token: 0x060016A7 RID: 5799 RVA: 0x00039770 File Offset: 0x00037970
		public RepairsChartView()
		{
			this.InitializeComponent();
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x0003978C File Offset: 0x0003798C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this._contentLoaded)
			{
				goto IL_2C;
			}
			IL_08:
			int num = -140281768;
			IL_0D:
			Uri resourceLocator;
			switch ((num ^ -2041782771) % 4)
			{
			case 0:
				goto IL_08;
			case 1:
				return;
			case 2:
				IL_2C:
				this._contentLoaded = true;
				resourceLocator = new Uri("/ASC;component/charts/repairschart/repairschartview.xaml", UriKind.Relative);
				num = -888295210;
				goto IL_0D;
			}
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x000397E8 File Offset: 0x000379E8
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this._contentLoaded = true;
		}

		// Token: 0x04000B29 RID: 2857
		private bool _contentLoaded;
	}
}
