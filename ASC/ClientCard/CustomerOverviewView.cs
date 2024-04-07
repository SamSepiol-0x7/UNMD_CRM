using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;
using DevExpress.Xpf.WindowsUI;

namespace ASC.ClientCard
{
	// Token: 0x02000325 RID: 805
	public class CustomerOverviewView : NavigationPage, IComponentConnector
	{
		// Token: 0x0600259B RID: 9627 RVA: 0x00073100 File Offset: 0x00071300
		public CustomerOverviewView()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600259C RID: 9628 RVA: 0x0007311C File Offset: 0x0007131C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this._contentLoaded)
			{
				goto IL_2C;
			}
			IL_08:
			int num = 133451625;
			IL_0D:
			switch ((num ^ 1648807659) % 4)
			{
			case 0:
				goto IL_08;
			case 2:
				return;
			case 3:
				IL_2C:
				this._contentLoaded = true;
				num = 970566118;
				goto IL_0D;
			}
			Uri resourceLocator = new Uri("/ASC;component/view/customercard/customeroverviewview.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600259D RID: 9629 RVA: 0x00021F40 File Offset: 0x00020140
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate _CreateDelegate(Type delegateType, string handler)
		{
			return Delegate.CreateDelegate(delegateType, this, handler);
		}

		// Token: 0x0600259E RID: 9630 RVA: 0x00073178 File Offset: 0x00071378
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId != 1)
			{
				goto IL_28;
			}
			IL_04:
			int num = -880769501;
			IL_09:
			switch ((num ^ -1484578758) % 4)
			{
			case 1:
				this.CustomerOverviewUC = (CustomerOverviewView)target;
				return;
			case 2:
				goto IL_04;
			case 3:
				IL_28:
				this._contentLoaded = true;
				num = -1273646906;
				goto IL_09;
			}
		}

		// Token: 0x04001413 RID: 5139
		internal CustomerOverviewView CustomerOverviewUC;

		// Token: 0x04001414 RID: 5140
		private bool _contentLoaded;
	}
}
