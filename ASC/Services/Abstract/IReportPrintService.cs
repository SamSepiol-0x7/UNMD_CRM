using System;
using ASC.Models;
using DevExpress.XtraReports.UI;

namespace ASC.Services.Abstract
{
	// Token: 0x020007F8 RID: 2040
	public interface IReportPrintService
	{
		// Token: 0x06003D36 RID: 15670
		void PrintPreview(XtraReport report, PrinterModel.Printer printer);
	}
}
