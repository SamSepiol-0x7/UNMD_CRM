using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using DevExpress.Xpf.Core.Serialization;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Grid.LookUp;

namespace ASC.View
{
	// Token: 0x0200032E RID: 814
	public partial class NewStoreItemView : UserControl, IStyleConnector
	{
		// Token: 0x060025B8 RID: 9656 RVA: 0x000735FC File Offset: 0x000717FC
		public NewStoreItemView()
		{
			this.InitializeComponent();
		}

		// Token: 0x060025B9 RID: 9657 RVA: 0x0004EE44 File Offset: 0x0004D044
		private void PART_GridControl_OnAllowProperty(object sender, AllowPropertyEventArgs e)
		{
			if (e.Property.Name == "TotalSummary")
			{
				e.Allow = false;
			}
		}

		// Token: 0x060025BD RID: 9661 RVA: 0x000736B0 File Offset: 0x000718B0
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IStyleConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 2)
			{
				((GridControl)target).AddHandler(DXSerializer.AllowPropertyEvent, new AllowPropertyEventHandler(this.PART_GridControl_OnAllowProperty));
			}
		}
	}
}
