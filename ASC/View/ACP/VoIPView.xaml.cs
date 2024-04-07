using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using ASC.SimpleClasses;
using DevExpress.Xpf.Diagram;
using DevExpress.Xpf.WindowsUI;

namespace ASC.View.ACP
{
	// Token: 0x020003A3 RID: 931
	public partial class VoIPView : UserControl
	{
		// Token: 0x06002743 RID: 10051 RVA: 0x00077AF8 File Offset: 0x00075CF8
		public VoIPView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002744 RID: 10052 RVA: 0x00077B14 File Offset: 0x00075D14
		private void dataBindingBehavior_GenerateItem(object sender, DiagramGenerateItemEventArgs e)
		{
			string templateName = (!(e.DataObject is QueueDiagram)) ? "QueueMemberTemplate" : "QueueTemplate";
			e.Item = e.CreateItemFromTemplate(templateName);
		}
	}
}
