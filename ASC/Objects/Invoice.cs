using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Models;
using ASC.Services.Abstract;
using Autofac;
using DevExpress.DataAccess.ObjectBinding;

namespace ASC.Objects
{
	// Token: 0x020008D7 RID: 2263
	[HighlightedClass]
	public class Invoice : InvoiceBase
	{
		// Token: 0x060045CC RID: 17868 RVA: 0x001111EC File Offset: 0x0010F3EC
		public Invoice()
		{
			this._invoiceService = Bootstrapper.Container.Resolve<IInvoiceService>();
		}

		// Token: 0x060045CD RID: 17869 RVA: 0x00111210 File Offset: 0x0010F410
		public sealed override void SetNum()
		{
			Invoice.<SetNum>d__2 <SetNum>d__;
			<SetNum>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SetNum>d__.<>4__this = this;
			<SetNum>d__.<>1__state = -1;
			<SetNum>d__.<>t__builder.Start<Invoice.<SetNum>d__2>(ref <SetNum>d__);
		}

		// Token: 0x060045CE RID: 17870 RVA: 0x00111248 File Offset: 0x0010F448
		public override string CheckFields()
		{
			string text = base.CheckFields();
			if (string.IsNullOrEmpty(text))
			{
				goto IL_52;
			}
			IL_1E:
			int num = -640305591;
			IL_23:
			switch ((num ^ -1230937731) % 5)
			{
			case 0:
				return "InvoiceNumErr";
			case 2:
				goto IL_1E;
			case 3:
				IL_52:
				num = ((this._invoiceService.GetInvoiceLookup(base.Num, DateTime.Now.Year).Result != null) ? -890837184 : -1953725301);
				goto IL_23;
			case 4:
				return text;
			}
			return null;
		}

		// Token: 0x060045CF RID: 17871 RVA: 0x001112D8 File Offset: 0x0010F4D8
		public override Task<byte[]> GetPdf(string templateName = "")
		{
			Invoice.<GetPdf>d__4 <GetPdf>d__;
			<GetPdf>d__.<>t__builder = AsyncTaskMethodBuilder<byte[]>.Create();
			<GetPdf>d__.<>4__this = this;
			<GetPdf>d__.templateName = templateName;
			<GetPdf>d__.<>1__state = -1;
			<GetPdf>d__.<>t__builder.Start<Invoice.<GetPdf>d__4>(ref <GetPdf>d__);
			return <GetPdf>d__.<>t__builder.Task;
		}

		// Token: 0x060045D0 RID: 17872 RVA: 0x00111324 File Offset: 0x0010F524
		public override Task<bool> Archive()
		{
			Invoice.<Archive>d__5 <Archive>d__;
			<Archive>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<Archive>d__.<>4__this = this;
			<Archive>d__.<>1__state = -1;
			<Archive>d__.<>t__builder.Start<Invoice.<Archive>d__5>(ref <Archive>d__);
			return <Archive>d__.<>t__builder.Task;
		}

		// Token: 0x04002CE3 RID: 11491
		private IInvoiceService _invoiceService;

		// Token: 0x020008D8 RID: 2264
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SetNum>d__2 : IAsyncStateMachine
		{
			// Token: 0x060045D1 RID: 17873 RVA: 0x00111368 File Offset: 0x0010F568
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Invoice invoice = this.<>4__this;
				try
				{
					TaskAwaiter<string> awaiter;
					if (num != 0)
					{
						awaiter = invoice._invoiceService.GetLastInvoiveId(invoice.Seller.Id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Invoice.<SetNum>d__2>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<string>);
						this.<>1__state = -1;
					}
					string result = awaiter.GetResult();
					invoice.SetNum(result);
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

			// Token: 0x060045D2 RID: 17874 RVA: 0x00111434 File Offset: 0x0010F634
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002CE4 RID: 11492
			public int <>1__state;

			// Token: 0x04002CE5 RID: 11493
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04002CE6 RID: 11494
			public Invoice <>4__this;

			// Token: 0x04002CE7 RID: 11495
			private TaskAwaiter<string> <>u__1;
		}

		// Token: 0x020008D9 RID: 2265
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetPdf>d__4 : IAsyncStateMachine
		{
			// Token: 0x060045D3 RID: 17875 RVA: 0x00111450 File Offset: 0x0010F650
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Invoice invoice = this.<>4__this;
				byte[] result;
				try
				{
					TaskAwaiter<byte[]> awaiter;
					if (num != 0)
					{
						awaiter = ReportPrintModel.CreatePdfReport(this.templateName, invoice).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<byte[]>, Invoice.<GetPdf>d__4>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<byte[]>);
						this.<>1__state = -1;
					}
					result = awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x060045D4 RID: 17876 RVA: 0x0011150C File Offset: 0x0010F70C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002CE8 RID: 11496
			public int <>1__state;

			// Token: 0x04002CE9 RID: 11497
			public AsyncTaskMethodBuilder<byte[]> <>t__builder;

			// Token: 0x04002CEA RID: 11498
			public string templateName;

			// Token: 0x04002CEB RID: 11499
			public Invoice <>4__this;

			// Token: 0x04002CEC RID: 11500
			private TaskAwaiter<byte[]> <>u__1;
		}

		// Token: 0x020008DA RID: 2266
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Archive>d__5 : IAsyncStateMachine
		{
			// Token: 0x060045D5 RID: 17877 RVA: 0x00111528 File Offset: 0x0010F728
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Invoice invoice = this.<>4__this;
				bool result;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						awaiter = InvoiceModel.ArchiveInvoice(invoice.Id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Invoice.<Archive>d__5>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<bool>);
						this.<>1__state = -1;
					}
					result = awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x060045D6 RID: 17878 RVA: 0x001115E4 File Offset: 0x0010F7E4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002CED RID: 11501
			public int <>1__state;

			// Token: 0x04002CEE RID: 11502
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x04002CEF RID: 11503
			public Invoice <>4__this;

			// Token: 0x04002CF0 RID: 11504
			private TaskAwaiter<bool> <>u__1;
		}
	}
}
