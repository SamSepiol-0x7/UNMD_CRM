using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.ViewModels;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;

namespace ASC.Invoice
{
	// Token: 0x02000B15 RID: 2837
	internal sealed class NewVATInvoiceViewModel : InvoiceBaseViewModel
	{
		// Token: 0x0600502C RID: 20524 RVA: 0x0015BC74 File Offset: 0x00159E74
		public NewVATInvoiceViewModel()
		{
			this.SetViewName("VatInvoice");
			base.Document = this.InvoiceStrategy.Create(typeof(VATInvoice));
		}

		// Token: 0x0600502D RID: 20525 RVA: 0x0015BCB0 File Offset: 0x00159EB0
		public override Task LoadDocument(int id)
		{
			NewVATInvoiceViewModel.<LoadDocument>d__1 <LoadDocument>d__;
			<LoadDocument>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadDocument>d__.<>4__this = this;
			<LoadDocument>d__.id = id;
			<LoadDocument>d__.<>1__state = -1;
			<LoadDocument>d__.<>t__builder.Start<NewVATInvoiceViewModel.<LoadDocument>d__1>(ref <LoadDocument>d__);
			return <LoadDocument>d__.<>t__builder.Task;
		}

		// Token: 0x0600502E RID: 20526 RVA: 0x0015BCFC File Offset: 0x00159EFC
		[Command]
		public void CreateDocument()
		{
			NewVATInvoiceViewModel.<CreateDocument>d__2 <CreateDocument>d__;
			<CreateDocument>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<CreateDocument>d__.<>4__this = this;
			<CreateDocument>d__.<>1__state = -1;
			<CreateDocument>d__.<>t__builder.Start<NewVATInvoiceViewModel.<CreateDocument>d__2>(ref <CreateDocument>d__);
		}

		// Token: 0x0600502F RID: 20527 RVA: 0x0015BD34 File Offset: 0x00159F34
		[Command]
		public override void Print()
		{
			NewVATInvoiceViewModel.<Print>d__3 <Print>d__;
			<Print>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Print>d__.<>4__this = this;
			<Print>d__.<>1__state = -1;
			<Print>d__.<>t__builder.Start<NewVATInvoiceViewModel.<Print>d__3>(ref <Print>d__);
		}

		// Token: 0x06005030 RID: 20528 RVA: 0x0015BD6C File Offset: 0x00159F6C
		[Command]
		public override void SendEmail()
		{
			base.SendEmail();
			this._windowedDocumentService.CloseActiveDocument();
			this._windowedDocumentService.ShowNewDocument("EmailView", new EmailViewModel(base.Document, "vatinvoice0"), this, null);
		}

		// Token: 0x06005031 RID: 20529 RVA: 0x0015A668 File Offset: 0x00158868
		[CompilerGenerated]
		[DebuggerHidden]
		private void <>n__0()
		{
			base.Print();
		}

		// Token: 0x02000B16 RID: 2838
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadDocument>d__1 : IAsyncStateMachine
		{
			// Token: 0x06005032 RID: 20530 RVA: 0x0015BDAC File Offset: 0x00159FAC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NewVATInvoiceViewModel newVATInvoiceViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<VATInvoice> awaiter;
					if (num != 0)
					{
						awaiter = InvoiceModel.GetVATInvoice(this.id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<VATInvoice>, NewVATInvoiceViewModel.<LoadDocument>d__1>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<VATInvoice>);
						this.<>1__state = -1;
					}
					VATInvoice result = awaiter.GetResult();
					newVATInvoiceViewModel.Document = result;
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

			// Token: 0x06005033 RID: 20531 RVA: 0x0015BE70 File Offset: 0x0015A070
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003551 RID: 13649
			public int <>1__state;

			// Token: 0x04003552 RID: 13650
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04003553 RID: 13651
			public int id;

			// Token: 0x04003554 RID: 13652
			public NewVATInvoiceViewModel <>4__this;

			// Token: 0x04003555 RID: 13653
			private TaskAwaiter<VATInvoice> <>u__1;
		}

		// Token: 0x02000B17 RID: 2839
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateDocument>d__2 : IAsyncStateMachine
		{
			// Token: 0x06005034 RID: 20532 RVA: 0x0015BE8C File Offset: 0x0015A08C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NewVATInvoiceViewModel newVATInvoiceViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (!newVATInvoiceViewModel.CheckFields(newVATInvoiceViewModel.Document))
						{
							goto IL_EA;
						}
						int num2 = InvoiceModel.CreateVATInvoice((IVATInvoice)newVATInvoiceViewModel.Document);
						this.<success>5__2 = (num2 > 0);
						if (!this.<success>5__2)
						{
							goto IL_BE;
						}
						newVATInvoiceViewModel._navigationService.SetTabHeader("VatInvoice", newVATInvoiceViewModel.Document.Num);
						awaiter = newVATInvoiceViewModel.LoadDocument(num2).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, NewVATInvoiceViewModel.<CreateDocument>d__2>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
					}
					awaiter.GetResult();
					IL_BE:
					newVATInvoiceViewModel.ShowActionResponse(this.<success>5__2, "");
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_EA:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06005035 RID: 20533 RVA: 0x0015BFA8 File Offset: 0x0015A1A8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003556 RID: 13654
			public int <>1__state;

			// Token: 0x04003557 RID: 13655
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04003558 RID: 13656
			public NewVATInvoiceViewModel <>4__this;

			// Token: 0x04003559 RID: 13657
			private bool <success>5__2;

			// Token: 0x0400355A RID: 13658
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000B18 RID: 2840
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Print>d__3 : IAsyncStateMachine
		{
			// Token: 0x06005036 RID: 20534 RVA: 0x0015BFC4 File Offset: 0x0015A1C4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NewVATInvoiceViewModel newVATInvoiceViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<XtraReport> awaiter;
					if (num != 0)
					{
						newVATInvoiceViewModel.<>n__0();
						awaiter = ReportPrintModel.CreateReport("vatinvoice0", newVATInvoiceViewModel.Document).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XtraReport>, NewVATInvoiceViewModel.<Print>d__3>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<XtraReport>);
						this.<>1__state = -1;
					}
					XtraReport result = awaiter.GetResult();
					DevExpress.XtraReports.IReport report;
					if (result == null)
					{
						report = result;
						if (result == null)
						{
							goto IL_93;
						}
					}
					else
					{
						result.ShowRibbonPreview();
						report = result;
						if (result == null)
						{
							goto IL_93;
						}
					}
					report.PrintDialog();
					IL_93:;
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

			// Token: 0x06005037 RID: 20535 RVA: 0x0015C0A4 File Offset: 0x0015A2A4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400355B RID: 13659
			public int <>1__state;

			// Token: 0x0400355C RID: 13660
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400355D RID: 13661
			public NewVATInvoiceViewModel <>4__this;

			// Token: 0x0400355E RID: 13662
			private TaskAwaiter<XtraReport> <>u__1;
		}
	}
}
