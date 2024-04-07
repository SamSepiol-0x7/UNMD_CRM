using System;
using System.Runtime.CompilerServices;
using System.Windows;
using DevExpress.Mvvm;
using DevExpress.Xpf.Docking;
using DevExpress.Xpf.Reports.UserDesigner;

namespace ASC.Extensions
{
	// Token: 0x02000B5F RID: 2911
	internal class CustomReportDesignerClassicView : ReportDesignerClassicView
	{
		// Token: 0x0600517E RID: 20862 RVA: 0x0015E774 File Offset: 0x0015C974
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			Style docPanelStyle = base.Resources["docPanelStyle"] as Style;
			if (docPanelStyle != null)
			{
				base.DoWithDocumentManagerService(delegate(IDocumentManagerService docService)
				{
					(docService as TabbedDocumentUIService).DocumentPanelStyle = docPanelStyle;
				});
				return;
			}
		}

		// Token: 0x0600517F RID: 20863 RVA: 0x0015E7C4 File Offset: 0x0015C9C4
		public CustomReportDesignerClassicView()
		{
		}

		// Token: 0x0400359D RID: 13725
		private const string docPanelStyleKey = "docPanelStyle";

		// Token: 0x02000B60 RID: 2912
		[CompilerGenerated]
		private sealed class <>c__DisplayClass1_0
		{
			// Token: 0x06005180 RID: 20864 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass1_0()
			{
			}

			// Token: 0x06005181 RID: 20865 RVA: 0x0015E7D8 File Offset: 0x0015C9D8
			internal void <OnApplyTemplate>b__0(IDocumentManagerService docService)
			{
				(docService as TabbedDocumentUIService).DocumentPanelStyle = this.docPanelStyle;
			}

			// Token: 0x0400359E RID: 13726
			public Style docPanelStyle;
		}
	}
}
