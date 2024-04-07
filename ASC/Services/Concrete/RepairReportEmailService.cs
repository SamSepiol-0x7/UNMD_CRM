using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Mail;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using AegisImplicitMail;
using ASC.Services.Abstract;
using ASC.SimpleClasses;

namespace ASC.Services.Concrete
{
	// Token: 0x02000781 RID: 1921
	public class RepairReportEmailService : Email, IRepairReportEmailService
	{
		// Token: 0x06003B7F RID: 15231 RVA: 0x000E9E44 File Offset: 0x000E8044
		public RepairReportEmailService(IToasterService toasterService)
		{
			this._toasterService = toasterService;
		}

		// Token: 0x06003B80 RID: 15232 RVA: 0x000E9E60 File Offset: 0x000E8060
		public void AttachFile(byte[] attach)
		{
			base.Attachments.Add(attach);
			if (!base.HaveAttachments)
			{
				base.HaveAttachments = true;
			}
		}

		// Token: 0x06003B81 RID: 15233 RVA: 0x000E9E88 File Offset: 0x000E8088
		public override Task<bool> SendEmail()
		{
			RepairReportEmailService.<SendEmail>d__3 <SendEmail>d__;
			<SendEmail>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<SendEmail>d__.<>4__this = this;
			<SendEmail>d__.<>1__state = -1;
			<SendEmail>d__.<>t__builder.Start<RepairReportEmailService.<SendEmail>d__3>(ref <SendEmail>d__);
			return <SendEmail>d__.<>t__builder.Task;
		}

		// Token: 0x0400269C RID: 9884
		private readonly IToasterService _toasterService;

		// Token: 0x02000782 RID: 1922
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SendEmail>d__3 : IAsyncStateMachine
		{
			// Token: 0x06003B82 RID: 15234 RVA: 0x000E9ECC File Offset: 0x000E80CC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairReportEmailService repairReportEmailService = this.<>4__this;
				bool result;
				try
				{
					if (repairReportEmailService.CheckFields() && !repairReportEmailService.EmailNotConfigured())
					{
						MimeMailMessage mimeMailMessage = new MimeMailMessage
						{
							From = new MailAddress(repairReportEmailService.Login),
							Sender = new MailAddress(repairReportEmailService.Login),
							SubjectEncoding = Encoding.UTF8,
							HeadersEncoding = Encoding.UTF8,
							Subject = repairReportEmailService.Subject,
							IsBodyHtml = repairReportEmailService.IsBodyHtml(),
							BodyTransferEncoding = TransferEncoding.Base64,
							Body = repairReportEmailService.CreateMessageBody()
						};
						mimeMailMessage.To.Add(new MimeMailAddress(repairReportEmailService.To));
						if (repairReportEmailService.HaveAttachments)
						{
							int num2 = 1;
							List<byte[]>.Enumerator enumerator = repairReportEmailService.Attachments.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									byte[] buffer = enumerator.Current;
									string name = string.Format("file{0}.pdf", num2);
									MemoryStream contentStream = new MemoryStream(buffer);
									mimeMailMessage.Attachments.Add(new MimeAttachment(contentStream, name, AttachmentLocation.Attachmed));
									num2++;
								}
							}
							finally
							{
								if (num < 0)
								{
									((IDisposable)enumerator).Dispose();
								}
							}
						}
						try
						{
							repairReportEmailService.mailer.SendMailAsync(mimeMailMessage);
						}
						catch (Exception ex)
						{
							repairReportEmailService._toasterService.Error(ex.Message);
							result = false;
							goto IL_15F;
						}
						result = true;
					}
					else
					{
						result = false;
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_15F:
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06003B83 RID: 15235 RVA: 0x000EA098 File Offset: 0x000E8298
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400269D RID: 9885
			public int <>1__state;

			// Token: 0x0400269E RID: 9886
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x0400269F RID: 9887
			public RepairReportEmailService <>4__this;
		}
	}
}
