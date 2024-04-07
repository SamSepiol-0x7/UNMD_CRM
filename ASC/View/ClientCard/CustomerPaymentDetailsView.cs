using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ASC.View.ClientCard
{
	// Token: 0x02000383 RID: 899
	public class CustomerPaymentDetailsView : UserControl, IComponentConnector
	{
		// Token: 0x060026CC RID: 9932 RVA: 0x000764E8 File Offset: 0x000746E8
		public CustomerPaymentDetailsView()
		{
			this.InitializeComponent();
		}

		// Token: 0x060026CD RID: 9933 RVA: 0x00076504 File Offset: 0x00074704
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/ASC;component/view/customercard/customerpaymentdetailsview.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060026CE RID: 9934 RVA: 0x00076534 File Offset: 0x00074734
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this._contentLoaded = true;
		}

		// Token: 0x040014E9 RID: 5353
		private bool _contentLoaded;
	}
}
