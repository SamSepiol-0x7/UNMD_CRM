using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Markup;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Grid;

namespace ASC.View
{
	// Token: 0x0200034B RID: 843
	public partial class NewCartridgeView : System.Windows.Controls.UserControl
	{
		// Token: 0x06002615 RID: 9749 RVA: 0x0007454C File Offset: 0x0007274C
		public NewCartridgeView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002616 RID: 9750 RVA: 0x00029B98 File Offset: 0x00027D98
		private void En_GotFocus(object sender, RoutedEventArgs e)
		{
			if (Auth.Config.auto_switch_layout)
			{
				InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-US"));
			}
		}

		// Token: 0x06002617 RID: 9751 RVA: 0x00074568 File Offset: 0x00072768
		private void Ru_GotFocus(object sender, RoutedEventArgs e)
		{
			if (Auth.Config.auto_switch_layout)
			{
				try
				{
					InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(CultureInfo.CurrentCulture);
				}
				catch (Exception)
				{
				}
			}
		}
	}
}
