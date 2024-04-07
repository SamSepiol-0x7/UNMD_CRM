using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Services.Abstract;
using ASC.ViewModels;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;

namespace ASC.Invoice
{
	// Token: 0x02000B20 RID: 2848
	internal sealed class WorksListViewModel : InvoiceBaseViewModel, IInvoiceSelect
	{
		// Token: 0x0600504E RID: 20558 RVA: 0x0015C85C File Offset: 0x0015AA5C
		public WorksListViewModel(IInvoiceService invoiceService)
		{
			this._invoiceService = invoiceService;
			this.SetViewName("PrintWorks");
			base.Document = this.InvoiceStrategy.Create(typeof(WorksList));
		}

		// Token: 0x0600504F RID: 20559 RVA: 0x0015C89C File Offset: 0x0015AA9C
		public override Task LoadDocument(int id)
		{
			WorksListViewModel.<LoadDocument>d__2 <LoadDocument>d__;
			<LoadDocument>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadDocument>d__.<>4__this = this;
			<LoadDocument>d__.id = id;
			<LoadDocument>d__.<>1__state = -1;
			<LoadDocument>d__.<>t__builder.Start<WorksListViewModel.<LoadDocument>d__2>(ref <LoadDocument>d__);
			return <LoadDocument>d__.<>t__builder.Task;
		}

		// Token: 0x06005050 RID: 20560 RVA: 0x0015C8E8 File Offset: 0x0015AAE8
		[Command]
		public void CreateDocument()
		{
			WorksListViewModel.<CreateDocument>d__3 <CreateDocument>d__;
			<CreateDocument>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<CreateDocument>d__.<>4__this = this;
			<CreateDocument>d__.<>1__state = -1;
			<CreateDocument>d__.<>t__builder.Start<WorksListViewModel.<CreateDocument>d__3>(ref <CreateDocument>d__);
		}

		// Token: 0x06005051 RID: 20561 RVA: 0x0015C920 File Offset: 0x0015AB20
		[Command]
		public override void Print()
		{
			WorksListViewModel.<Print>d__4 <Print>d__;
			<Print>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Print>d__.<>4__this = this;
			<Print>d__.<>1__state = -1;
			<Print>d__.<>t__builder.Start<WorksListViewModel.<Print>d__4>(ref <Print>d__);
		}

		// Token: 0x06005052 RID: 20562 RVA: 0x0015C27C File Offset: 0x0015A47C
		[Command]
		public void SearchReason()
		{
			this._navigationService.Navigate("InvoiceView", new InvoiceViewModel(true), this);
		}

		// Token: 0x06005053 RID: 20563 RVA: 0x0015C958 File Offset: 0x0015AB58
		public Task SelectInvoice(int invoiceId)
		{
			WorksListViewModel.<SelectInvoice>d__6 <SelectInvoice>d__;
			<SelectInvoice>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<SelectInvoice>d__.<>4__this = this;
			<SelectInvoice>d__.invoiceId = invoiceId;
			<SelectInvoice>d__.<>1__state = -1;
			<SelectInvoice>d__.<>t__builder.Start<WorksListViewModel.<SelectInvoice>d__6>(ref <SelectInvoice>d__);
			return <SelectInvoice>d__.<>t__builder.Task;
		}

		// Token: 0x06005054 RID: 20564 RVA: 0x0015C9A4 File Offset: 0x0015ABA4
		[Command]
		public override void SendEmail()
		{
			base.SendEmail();
			this._windowedDocumentService.CloseActiveDocument();
			base.Document.EnablePrintImages();
			this._windowedDocumentService.ShowNewDocument("EmailView", new EmailViewModel(base.Document, "w_list0"), null, null);
		}

		// Token: 0x06005055 RID: 20565 RVA: 0x0015A668 File Offset: 0x00158868
		[CompilerGenerated]
		[DebuggerHidden]
		private void <>n__0()
		{
			base.Print();
		}

		// Token: 0x04003576 RID: 13686
		private readonly IInvoiceService _invoiceService;

		// Token: 0x02000B21 RID: 2849
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadDocument>d__2 : IAsyncStateMachine
		{
			// Token: 0x06005056 RID: 20566 RVA: 0x0015C9F0 File Offset: 0x0015ABF0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorksListViewModel worksListViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IWorksList> awaiter;
					if (num != 0)
					{
						awaiter = worksListViewModel._invoiceService.GetWorksList(this.id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IWorksList>, WorksListViewModel.<LoadDocument>d__2>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IWorksList>);
						this.<>1__state = -1;
					}
					IWorksList result = awaiter.GetResult();
					worksListViewModel.Document = result;
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

			// Token: 0x06005057 RID: 20567 RVA: 0x0015CAB8 File Offset: 0x0015ACB8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003577 RID: 13687
			public int <>1__state;

			// Token: 0x04003578 RID: 13688
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04003579 RID: 13689
			public WorksListViewModel <>4__this;

			// Token: 0x0400357A RID: 13690
			public int id;

			// Token: 0x0400357B RID: 13691
			private TaskAwaiter<IWorksList> <>u__1;
		}

		// Token: 0x02000B22 RID: 2850
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateDocument>d__3 : IAsyncStateMachine
		{
			// Token: 0x06005058 RID: 20568 RVA: 0x0015CAD4 File Offset: 0x0015ACD4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorksListViewModel worksListViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (!worksListViewModel.CheckFields(worksListViewModel.Document))
						{
							goto IL_104;
						}
						this.<result>5__2 = worksListViewModel._invoiceService.CreateWorksList((IWorksList)worksListViewModel.Document);
						if (!this.<result>5__2.IsSucces)
						{
							goto IL_CE;
						}
						worksListViewModel._navigationService.SetTabHeader("PrintWorks", worksListViewModel.Document.Num);
						awaiter = worksListViewModel.LoadDocument(this.<result>5__2.Id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorksListViewModel.<CreateDocument>d__3>(ref awaiter, ref this);
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
					IL_CE:
					worksListViewModel.ShowActionResponse(this.<result>5__2.IsSucces, "");
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<result>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_104:
				this.<>1__state = -2;
				this.<result>5__2 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06005059 RID: 20569 RVA: 0x0015CC10 File Offset: 0x0015AE10
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400357C RID: 13692
			public int <>1__state;

			// Token: 0x0400357D RID: 13693
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400357E RID: 13694
			public WorksListViewModel <>4__this;

			// Token: 0x0400357F RID: 13695
			private IAscResult <result>5__2;

			// Token: 0x04003580 RID: 13696
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000B23 RID: 2851
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Print>d__4 : IAsyncStateMachine
		{
			// Token: 0x0600505A RID: 20570 RVA: 0x0015CC2C File Offset: 0x0015AE2C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorksListViewModel worksListViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<XtraReport> awaiter;
					if (num != 0)
					{
						worksListViewModel.<>n__0();
						awaiter = ReportPrintModel.CreateReport("w_list0", worksListViewModel.Document).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XtraReport>, WorksListViewModel.<Print>d__4>(ref awaiter, ref this);
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

			// Token: 0x0600505B RID: 20571 RVA: 0x0015CD0C File Offset: 0x0015AF0C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003581 RID: 13697
			public int <>1__state;

			// Token: 0x04003582 RID: 13698
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04003583 RID: 13699
			public WorksListViewModel <>4__this;

			// Token: 0x04003584 RID: 13700
			private TaskAwaiter<XtraReport> <>u__1;
		}

		// Token: 0x02000B24 RID: 2852
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SelectInvoice>d__6 : IAsyncStateMachine
		{
			// Token: 0x0600505C RID: 20572 RVA: 0x0015CD28 File Offset: 0x0015AF28
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorksListViewModel worksListViewModel = this.<>4__this;
				try
				{
					if (num > 1)
					{
						worksListViewModel.ShowWait();
					}
					try
					{
						if (num != 0)
						{
							goto IL_B7;
						}
						goto IL_F5;
						TaskAwaiter<Invoice> awaiter;
						for (;;)
						{
							IL_DD:
							Invoice result = awaiter.GetResult();
							for (;;)
							{
								WorksList worksList = (WorksList)worksListViewModel.Document;
								if (worksList != null)
								{
									worksList.FillFromInvoice(result);
									uint num2;
									switch ((num2 = (num2 * 1392687618U ^ 258483698U ^ 157700937U)) % 22U)
									{
									case 0U:
										goto IL_197;
									case 1U:
										goto IL_10A;
									case 2U:
										goto IL_185;
									case 3U:
										continue;
									case 4U:
									case 5U:
										goto IL_B7;
									case 6U:
										goto IL_130;
									case 7U:
										goto IL_1B6;
									case 8U:
										goto IL_129;
									case 9U:
										goto IL_D4;
									case 10U:
										goto IL_F5;
									case 11U:
										goto IL_120;
									case 13U:
										goto IL_DD;
									case 14U:
										goto IL_178;
									case 15U:
										goto IL_BD;
									case 16U:
										goto IL_143;
									case 17U:
										goto IL_1A0;
									case 18U:
										goto IL_EA;
									case 19U:
										goto IL_162;
									case 20U:
										goto IL_18E;
									case 21U:
										goto IL_14F;
									}
									goto Block_9;
								}
								goto IL_14E;
							}
						}
						Block_9:
						goto IL_1B8;
						IL_14E:
						IL_14F:
						worksListViewModel.SetSeller();
						if (worksListViewModel.Document.Customer == null)
						{
							goto IL_1B8;
						}
						IL_162:
						worksListViewModel.CustomerId = worksListViewModel.Document.Customer.CustomerId;
						IL_178:
						TaskAwaiter awaiter2 = worksListViewModel.LoadCustomerPaymentDetails().GetAwaiter();
						IL_185:
						if (awaiter2.IsCompleted)
						{
							goto IL_18E;
						}
						IL_197:
						int num3 = 1;
						num = 1;
						this.<>1__state = num3;
						IL_1A0:
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorksListViewModel.<SelectInvoice>d__6>(ref awaiter2, ref this);
						IL_1B6:
						return;
						IL_B7:
						if (num == 1)
						{
							goto IL_10A;
						}
						IL_BD:
						awaiter = worksListViewModel._invoiceService.GetInvoice(this.invoiceId).GetAwaiter();
						IL_D4:
						if (awaiter.IsCompleted)
						{
							goto IL_DD;
						}
						goto IL_120;
						IL_EA:
						int num4 = -1;
						num = -1;
						this.<>1__state = num4;
						goto IL_DD;
						IL_F5:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<Invoice>);
						goto IL_EA;
						IL_10A:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter);
						goto IL_143;
						IL_120:
						int num5 = 0;
						num = 0;
						this.<>1__state = num5;
						IL_129:
						this.<>u__1 = awaiter;
						IL_130:
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Invoice>, WorksListViewModel.<SelectInvoice>d__6>(ref awaiter, ref this);
						return;
						IL_143:
						int num6 = -1;
						num = -1;
						this.<>1__state = num6;
						IL_18E:
						awaiter2.GetResult();
						IL_1B8:;
					}
					catch (Exception ex)
					{
						worksListViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							worksListViewModel.HideWait();
						}
					}
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

			// Token: 0x0600505D RID: 20573 RVA: 0x0015CF8C File Offset: 0x0015B18C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003585 RID: 13701
			public int <>1__state;

			// Token: 0x04003586 RID: 13702
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04003587 RID: 13703
			public WorksListViewModel <>4__this;

			// Token: 0x04003588 RID: 13704
			public int invoiceId;

			// Token: 0x04003589 RID: 13705
			private TaskAwaiter<Invoice> <>u__1;

			// Token: 0x0400358A RID: 13706
			private TaskAwaiter <>u__2;
		}
	}
}
