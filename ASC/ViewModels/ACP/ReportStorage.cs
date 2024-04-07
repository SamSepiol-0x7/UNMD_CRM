using System;
using ASC.Models;
using DevExpress.Xpf.Reports.UserDesigner;
using DevExpress.Xpf.Reports.UserDesigner.Native;
using DevExpress.XtraReports.UI;

namespace ASC.ViewModels.ACP
{
	// Token: 0x0200059D RID: 1437
	public class ReportStorage : IReportStorage
	{
		// Token: 0x06003513 RID: 13587 RVA: 0x000B49B4 File Offset: 0x000B2BB4
		public void SetReportId(int id)
		{
			this._reportId = id;
		}

		// Token: 0x06003514 RID: 13588 RVA: 0x000304B4 File Offset: 0x0002E6B4
		public bool CanCreateNew()
		{
			return false;
		}

		// Token: 0x06003515 RID: 13589 RVA: 0x0007E558 File Offset: 0x0007C758
		public XtraReport CreateNew()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06003516 RID: 13590 RVA: 0x0007E558 File Offset: 0x0007C758
		public XtraReport CreateNewSubreport()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06003517 RID: 13591 RVA: 0x000304B4 File Offset: 0x0002E6B4
		public bool CanOpen()
		{
			return false;
		}

		// Token: 0x06003518 RID: 13592 RVA: 0x0007E558 File Offset: 0x0007C758
		public string Open(IReportDesignerUI designer)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06003519 RID: 13593 RVA: 0x0007E558 File Offset: 0x0007C758
		public XtraReport Load(string reportID, IReportSerializer designerReportSerializer)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600351A RID: 13594 RVA: 0x000B49C8 File Offset: 0x000B2BC8
		public string Save(string reportID, IReportProvider reportProvider, bool saveAs, string reportTitle, IReportDesignerUI designer)
		{
			XtraReport report = reportProvider.GetReport();
			ReportPrintModel.SaveTemplate(this._reportId, report);
			return this._reportId.ToString();
		}

		// Token: 0x0600351B RID: 13595 RVA: 0x000B49F4 File Offset: 0x000B2BF4
		public string GetErrorMessage(Exception exception)
		{
			return ExceptionHelper.GetInnerErrorMessage(exception);
		}

		// Token: 0x0600351C RID: 13596 RVA: 0x000046B4 File Offset: 0x000028B4
		public ReportStorage()
		{
		}

		// Token: 0x04001E9C RID: 7836
		private int _reportId;
	}
}
