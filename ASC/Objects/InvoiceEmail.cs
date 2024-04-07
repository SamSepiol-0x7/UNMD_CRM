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
using ASC.Common.Interfaces;
using ASC.Extensions;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using Autofac;

namespace ASC.Objects
{
	// Token: 0x020008DD RID: 2269
	public class InvoiceEmail : Email
	{
		// Token: 0x1700135D RID: 4957
		// (get) Token: 0x0600460D RID: 17933 RVA: 0x00111EAC File Offset: 0x001100AC
		// (set) Token: 0x0600460E RID: 17934 RVA: 0x00111EC0 File Offset: 0x001100C0
		public IInvoice Invoice
		{
			[CompilerGenerated]
			get
			{
				return this.<Invoice>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Invoice>k__BackingField = value;
			}
		}

		// Token: 0x0600460F RID: 17935 RVA: 0x00111ED4 File Offset: 0x001100D4
		public InvoiceEmail()
		{
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
		}

		// Token: 0x06004610 RID: 17936 RVA: 0x00111EF8 File Offset: 0x001100F8
		public InvoiceEmail(IInvoice invoice, string templateName) : this()
		{
			base.To = invoice.Customer.Email;
			base.Subject = invoice.GetNumAndDateStr();
			base.Message = base.Subject;
			this.AttachFiles(invoice, templateName);
		}

		// Token: 0x06004611 RID: 17937 RVA: 0x00111F3C File Offset: 0x0011013C
		public InvoiceEmail(IEnumerable<KeyValuePair<IInvoice, string>> documents, string to) : this()
		{
			base.To = to;
			foreach (KeyValuePair<IInvoice, string> keyValuePair in documents)
			{
				base.Subject = base.Subject + keyValuePair.Key.GetNumAndDateStr() + "; ";
				this.AttachFiles(keyValuePair.Key, keyValuePair.Value);
			}
			base.Message = base.Subject;
			if (base.Subject.Length > 35)
			{
				base.Subject = base.Subject.Truncate(32, "...");
			}
		}

		// Token: 0x06004612 RID: 17938 RVA: 0x00111FF4 File Offset: 0x001101F4
		private void AttachFiles(IInvoice invoice, string templateName)
		{
			InvoiceEmail.<AttachFiles>d__8 <AttachFiles>d__;
			<AttachFiles>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<AttachFiles>d__.<>4__this = this;
			<AttachFiles>d__.invoice = invoice;
			<AttachFiles>d__.templateName = templateName;
			<AttachFiles>d__.<>1__state = -1;
			<AttachFiles>d__.<>t__builder.Start<InvoiceEmail.<AttachFiles>d__8>(ref <AttachFiles>d__);
		}

		// Token: 0x06004613 RID: 17939 RVA: 0x0011203C File Offset: 0x0011023C
		public override Task<bool> SendEmail()
		{
			InvoiceEmail.<SendEmail>d__9 <SendEmail>d__;
			<SendEmail>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<SendEmail>d__.<>4__this = this;
			<SendEmail>d__.<>1__state = -1;
			<SendEmail>d__.<>t__builder.Start<InvoiceEmail.<SendEmail>d__9>(ref <SendEmail>d__);
			return <SendEmail>d__.<>t__builder.Task;
		}

		// Token: 0x06004614 RID: 17940 RVA: 0x00112080 File Offset: 0x00110280
		public override bool CheckFields()
		{
			if (string.IsNullOrEmpty(base.To))
			{
				this._toasterService.Info(Lang.t("CheckToEmail"));
				return false;
			}
			bool result;
			try
			{
				new MailAddress(base.To);
				goto IL_4B;
			}
			catch (FormatException ex)
			{
				this._toasterService.Error(ex.Message);
				result = false;
			}
			return result;
			IL_4B:
			if (string.IsNullOrEmpty(base.Subject))
			{
				this._toasterService.Info(Lang.t("CheckTitle"));
				return false;
			}
			if (base.Subject.Length > 35)
			{
				this._toasterService.Info(Lang.t("SubjectTooLong") + "[35]");
				return false;
			}
			if (string.IsNullOrEmpty(base.Message))
			{
				this._toasterService.Info(Lang.t("CheckMessage"));
				return false;
			}
			return true;
		}

		// Token: 0x04002D07 RID: 11527
		private readonly IToasterService _toasterService;

		// Token: 0x04002D08 RID: 11528
		[CompilerGenerated]
		private IInvoice <Invoice>k__BackingField;

		// Token: 0x020008DE RID: 2270
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <AttachFiles>d__8 : IAsyncStateMachine
		{
			// Token: 0x06004615 RID: 17941 RVA: 0x00112164 File Offset: 0x00110364
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				InvoiceEmail invoiceEmail = this.<>4__this;
				try
				{
					TaskAwaiter<byte[]> awaiter;
					if (num != 0)
					{
						awaiter = this.invoice.GetPdf(this.templateName).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<byte[]>, InvoiceEmail.<AttachFiles>d__8>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<byte[]>);
						this.<>1__state = -1;
					}
					byte[] result = awaiter.GetResult();
					invoiceEmail.Attachments.Add(result);
					invoiceEmail.HaveAttachments = true;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06004616 RID: 17942 RVA: 0x00112238 File Offset: 0x00110438
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002D09 RID: 11529
			public int <>1__state;

			// Token: 0x04002D0A RID: 11530
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04002D0B RID: 11531
			public IInvoice invoice;

			// Token: 0x04002D0C RID: 11532
			public string templateName;

			// Token: 0x04002D0D RID: 11533
			public InvoiceEmail <>4__this;

			// Token: 0x04002D0E RID: 11534
			private TaskAwaiter<byte[]> <>u__1;
		}

		// Token: 0x020008DF RID: 2271
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SendEmail>d__9 : IAsyncStateMachine
		{
			// Token: 0x06004617 RID: 17943 RVA: 0x00112254 File Offset: 0x00110454
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				InvoiceEmail invoiceEmail = this.<>4__this;
				bool result;
				try
				{
					if (invoiceEmail.CheckFields() && !invoiceEmail.EmailNotConfigured())
					{
						MimeMailMessage mimeMailMessage = new MimeMailMessage
						{
							From = new MailAddress(invoiceEmail.Login),
							Sender = new MailAddress(invoiceEmail.Login),
							SubjectEncoding = Encoding.UTF8,
							HeadersEncoding = Encoding.UTF8,
							Subject = invoiceEmail.Subject,
							IsBodyHtml = invoiceEmail.IsBodyHtml(),
							BodyTransferEncoding = TransferEncoding.Base64,
							Body = invoiceEmail.CreateMessageBody()
						};
						mimeMailMessage.To.Add(new MimeMailAddress(invoiceEmail.To));
						if (invoiceEmail.HaveAttachments)
						{
							int num2 = 1;
							List<byte[]>.Enumerator enumerator = invoiceEmail.Attachments.GetEnumerator();
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
							invoiceEmail.mailer.SendMailAsync(mimeMailMessage);
						}
						catch (Exception ex)
						{
							invoiceEmail._toasterService.Error(ex.Message);
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

			// Token: 0x06004618 RID: 17944 RVA: 0x00112420 File Offset: 0x00110620
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002D0F RID: 11535
			public int <>1__state;

			// Token: 0x04002D10 RID: 11536
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x04002D11 RID: 11537
			public InvoiceEmail <>4__this;
		}
	}
}
