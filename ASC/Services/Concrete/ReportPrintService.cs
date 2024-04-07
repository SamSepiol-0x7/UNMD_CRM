using System;
using System.IO;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Properties;
using ASC.Services.Abstract;
using ASC.ViewModels;
using Autofac;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;

namespace ASC.Services.Concrete
{
	// Token: 0x0200076C RID: 1900
	public class ReportPrintService : IReportPrintService
	{
		// Token: 0x06003B4D RID: 15181 RVA: 0x000E6DA4 File Offset: 0x000E4FA4
		public ReportPrintService(IToasterService toasterService)
		{
			this._toasterService = toasterService;
		}

		// Token: 0x06003B4E RID: 15182 RVA: 0x000E6DC0 File Offset: 0x000E4FC0
		public void PrintPreview(XtraReport report, PrinterModel.Printer printer)
		{
			if (report.Parameters.Count > 0 && report.Parameters[0] != null && report.Parameters[0].Name == "CustomerId")
			{
				this._customerId = new int?((int)report.Parameters[0].Value);
			}
			ReportPrintTool reportPrintTool = new ReportPrintTool(report);
			reportPrintTool.PreviewForm.SaveState = true;
			reportPrintTool.PrintingSystem.AddCommandHandler(new ReportPrintService.SendPdfToEmailCommandHandler(this._customerId));
			try
			{
				if (printer == PrinterModel.Printer.Documents)
				{
					reportPrintTool.PrinterSettings.PrinterName = Settings.Default.DocsPrinter;
					if (!OfflineData.Instance.Employee.PreviewReports)
					{
						reportPrintTool.Print(Settings.Default.DocsPrinter);
					}
					else
					{
						reportPrintTool.ShowPreview();
						reportPrintTool.PrintDialog();
					}
				}
				else if (printer != PrinterModel.Printer.PriceTag)
				{
					reportPrintTool.PrinterSettings.PrinterName = Settings.Default.StickersPrinter;
					reportPrintTool.PrintDialog();
				}
				else
				{
					reportPrintTool.PrinterSettings.PrinterName = Settings.Default.DocsPrinter;
					reportPrintTool.PrintDialog();
				}
			}
			catch (Exception ex)
			{
				this._toasterService.Error(ex.Message);
			}
		}

		// Token: 0x0400264D RID: 9805
		private readonly IToasterService _toasterService;

		// Token: 0x0400264E RID: 9806
		private int? _customerId;

		// Token: 0x0200076D RID: 1901
		private class SendPdfToEmailCommandHandler : ICommandHandler
		{
			// Token: 0x06003B4F RID: 15183 RVA: 0x000E6F00 File Offset: 0x000E5100
			public SendPdfToEmailCommandHandler()
			{
				this._customerService = Bootstrapper.Container.Resolve<ICustomerService>();
			}

			// Token: 0x06003B50 RID: 15184 RVA: 0x000E6F24 File Offset: 0x000E5124
			public SendPdfToEmailCommandHandler(int? customerId) : this()
			{
				this._customerId = customerId;
			}

			// Token: 0x06003B51 RID: 15185 RVA: 0x000E6F40 File Offset: 0x000E5140
			public virtual void HandleCommand(PrintingSystemCommand command, object[] args, IPrintControl printControl, ref bool handled)
			{
				if (!this.CanHandleCommand(command, printControl))
				{
					return;
				}
				string to = (this._customerId != null) ? this._customerService.GetCustomerAsync(this._customerId.Value).Result.email : "";
				EmailViewModel emailViewModel = new EmailViewModel();
				using (MemoryStream memoryStream = new MemoryStream())
				{
					printControl.PrintingSystem.ExportToPdf(memoryStream);
					IRepairReportEmailService repairReportEmailService = Bootstrapper.Container.Resolve<IRepairReportEmailService>();
					((IEmail)repairReportEmailService).To = to;
					((IEmail)repairReportEmailService).Subject = Lang.t("Documents");
					((IEmail)repairReportEmailService).Message = Lang.t("Documents");
					repairReportEmailService.AttachFile(memoryStream.ToArray());
					emailViewModel.Email = (IEmail)repairReportEmailService;
				}
				Bootstrapper.Container.Resolve<IWindowedDocumentService>().ShowNewDocument("EmailView", emailViewModel, null, null);
				handled = true;
			}

			// Token: 0x06003B52 RID: 15186 RVA: 0x000E7038 File Offset: 0x000E5238
			public virtual bool CanHandleCommand(PrintingSystemCommand command, IPrintControl printControl)
			{
				return command == PrintingSystemCommand.SendPdf;
			}

			// Token: 0x0400264F RID: 9807
			private readonly int? _customerId;

			// Token: 0x04002650 RID: 9808
			private readonly ICustomerService _customerService;
		}
	}
}
