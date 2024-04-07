using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Markup;
using ASC.Extensions;
using DevExpress.Xpf.Editors;

namespace ASC.ItemsBuyout
{
	// Token: 0x02000273 RID: 627
	public partial class ItemsBuyoutView : System.Windows.Controls.UserControl
	{
		// Token: 0x06002172 RID: 8562 RVA: 0x000610F4 File Offset: 0x0005F2F4
		public ItemsBuyoutView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002173 RID: 8563 RVA: 0x00029B98 File Offset: 0x00027D98
		private void En_GotFocus(object sender, RoutedEventArgs e)
		{
			if (Auth.Config.auto_switch_layout)
			{
				InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-US"));
			}
		}

		// Token: 0x06002174 RID: 8564 RVA: 0x00029BC8 File Offset: 0x00027DC8
		private void Ru_GotFocus(object sender, RoutedEventArgs e)
		{
			if (Auth.Config.auto_switch_layout)
			{
				InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(CultureInfo.CurrentCulture);
			}
		}
	}
}
