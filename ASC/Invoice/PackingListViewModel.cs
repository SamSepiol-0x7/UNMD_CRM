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
	// Token: 0x02000B1B RID: 2843
	internal sealed class PackingListViewModel : InvoiceBaseViewModel, IInvoiceSelect
	{
		// Token: 0x0600503E RID: 20542 RVA: 0x0015C180 File Offset: 0x0015A380
		public PackingListViewModel(IInvoiceService invoiceService)
		{
			this._invoiceService = invoiceService;
			this.SetViewName("PackingList");
			base.Document = this.InvoiceStrategy.Create(typeof(PackingList));
		}

		// Token: 0x0600503F RID: 20543 RVA: 0x0015C1C0 File Offset: 0x0015A3C0
		public override Task LoadDocument(int id)
		{
			PackingListViewModel.<LoadDocument>d__2 <LoadDocument>d__;
			<LoadDocument>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadDocument>d__.<>4__this = this;
			<LoadDocument>d__.id = id;
			<LoadDocument>d__.<>1__state = -1;
			<LoadDocument>d__.<>t__builder.Start<PackingListViewModel.<LoadDocument>d__2>(ref <LoadDocument>d__);
			return <LoadDocument>d__.<>t__builder.Task;
		}

		// Token: 0x06005040 RID: 20544 RVA: 0x0015C20C File Offset: 0x0015A40C
		[Command]
		public void CreateDocument()
		{
			PackingListViewModel.<CreateDocument>d__3 <CreateDocument>d__;
			<CreateDocument>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<CreateDocument>d__.<>4__this = this;
			<CreateDocument>d__.<>1__state = -1;
			<CreateDocument>d__.<>t__builder.Start<PackingListViewModel.<CreateDocument>d__3>(ref <CreateDocument>d__);
		}

		// Token: 0x06005041 RID: 20545 RVA: 0x0015C244 File Offset: 0x0015A444
		[Command]
		public override void Print()
		{
			PackingListViewModel.<Print>d__4 <Print>d__;
			<Print>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Print>d__.<>4__this = this;
			<Print>d__.<>1__state = -1;
			<Print>d__.<>t__builder.Start<PackingListViewModel.<Print>d__4>(ref <Print>d__);
		}

		// Token: 0x06005042 RID: 20546 RVA: 0x0015C27C File Offset: 0x0015A47C
		[Command]
		public void SearchReason()
		{
			this._navigationService.Navigate("InvoiceView", new InvoiceViewModel(true), this);
		}

		// Token: 0x06005043 RID: 20547 RVA: 0x0015C2A0 File Offset: 0x0015A4A0
		public Task SelectInvoice(int invoiceId)
		{
			PackingListViewModel.<SelectInvoice>d__6 <SelectInvoice>d__;
			<SelectInvoice>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<SelectInvoice>d__.<>4__this = this;
			<SelectInvoice>d__.invoiceId = invoiceId;
			<SelectInvoice>d__.<>1__state = -1;
			<SelectInvoice>d__.<>t__builder.Start<PackingListViewModel.<SelectInvoice>d__6>(ref <SelectInvoice>d__);
			return <SelectInvoice>d__.<>t__builder.Task;
		}

		// Token: 0x06005044 RID: 20548 RVA: 0x0015C2EC File Offset: 0x0015A4EC
		[Command]
		public override void SendEmail()
		{
			base.SendEmail();
			this._windowedDocumentService.CloseActiveDocument();
			this._windowedDocumentService.ShowNewDocument("EmailView", new EmailViewModel(base.Document, "p_list0"), this, null);
		}

		// Token: 0x06005045 RID: 20549 RVA: 0x0015A668 File Offset: 0x00158868
		[CompilerGenerated]
		[DebuggerHidden]
		private void <>n__0()
		{
			base.Print();
		}

		// Token: 0x04003561 RID: 13665
		private IInvoiceService _invoiceService;

		// Token: 0x02000B1C RID: 2844
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadDocument>d__2 : IAsyncStateMachine
		{
			// Token: 0x06005046 RID: 20550 RVA: 0x0015C32C File Offset: 0x0015A52C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PackingListViewModel packingListViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<PackingList> awaiter;
					if (num != 0)
					{
						awaiter = InvoiceModel.GetPackingList(this.id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<PackingList>, PackingListViewModel.<LoadDocument>d__2>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<PackingList>);
						this.<>1__state = -1;
					}
					PackingList result = awaiter.GetResult();
					packingListViewModel.Document = result;
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

			// Token: 0x06005047 RID: 20551 RVA: 0x0015C3F0 File Offset: 0x0015A5F0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003562 RID: 13666
			public int <>1__state;

			// Token: 0x04003563 RID: 13667
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04003564 RID: 13668
			public int id;

			// Token: 0x04003565 RID: 13669
			public PackingListViewModel <>4__this;

			// Token: 0x04003566 RID: 13670
			private TaskAwaiter<PackingList> <>u__1;
		}

		// Token: 0x02000B1D RID: 2845
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateDocument>d__3 : IAsyncStateMachine
		{
			// Token: 0x06005048 RID: 20552 RVA: 0x0015C40C File Offset: 0x0015A60C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PackingListViewModel packingListViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (!packingListViewModel.CheckFields(packingListViewModel.Document))
						{
							goto IL_EA;
						}
						int num2 = InvoiceModel.CreatePackingList((IPackingList)packingListViewModel.Document);
						this.<success>5__2 = (num2 > 0);
						if (!this.<success>5__2)
						{
							goto IL_BE;
						}
						packingListViewModel._navigationService.SetTabHeader("PackingList", packingListViewModel.Document.Num);
						awaiter = packingListViewModel.LoadDocument(num2).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, PackingListViewModel.<CreateDocument>d__3>(ref awaiter, ref this);
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
					packingListViewModel.ShowActionResponse(this.<success>5__2, "");
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

			// Token: 0x06005049 RID: 20553 RVA: 0x0015C528 File Offset: 0x0015A728
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003567 RID: 13671
			public int <>1__state;

			// Token: 0x04003568 RID: 13672
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04003569 RID: 13673
			public PackingListViewModel <>4__this;

			// Token: 0x0400356A RID: 13674
			private bool <success>5__2;

			// Token: 0x0400356B RID: 13675
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000B1E RID: 2846
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Print>d__4 : IAsyncStateMachine
		{
			// Token: 0x0600504A RID: 20554 RVA: 0x0015C544 File Offset: 0x0015A744
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PackingListViewModel packingListViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<XtraReport> awaiter;
					if (num != 0)
					{
						packingListViewModel.<>n__0();
						awaiter = ReportPrintModel.CreateReport("p_list0", packingListViewModel.Document).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XtraReport>, PackingListViewModel.<Print>d__4>(ref awaiter, ref this);
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

			// Token: 0x0600504B RID: 20555 RVA: 0x0015C624 File Offset: 0x0015A824
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400356C RID: 13676
			public int <>1__state;

			// Token: 0x0400356D RID: 13677
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400356E RID: 13678
			public PackingListViewModel <>4__this;

			// Token: 0x0400356F RID: 13679
			private TaskAwaiter<XtraReport> <>u__1;
		}

		// Token: 0x02000B1F RID: 2847
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SelectInvoice>d__6 : IAsyncStateMachine
		{
			// Token: 0x0600504C RID: 20556 RVA: 0x0015C640 File Offset: 0x0015A840
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PackingListViewModel packingListViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						goto IL_AC;
					}
					goto IL_F6;
					TaskAwaiter<Invoice> awaiter;
					for (;;)
					{
						IL_D0:
						Invoice result = awaiter.GetResult();
						for (;;)
						{
							PackingList packingList = (PackingList)packingListViewModel.Document;
							if (packingList != null)
							{
								packingList.FillFromInvoice(result);
								uint num2;
								switch ((num2 = (num2 * 4133970069U ^ 678706443U ^ 928138425U)) % 22U)
								{
								case 0U:
									goto IL_B0;
								case 1U:
									goto IL_178;
								case 2U:
									goto IL_142;
								case 3U:
									goto IL_FF;
								case 4U:
									continue;
								case 5U:
									goto IL_DD;
								case 6U:
									goto IL_E8;
								case 7U:
									goto IL_108;
								case 8U:
									goto IL_1A2;
								case 9U:
									goto IL_C7;
								case 10U:
									goto IL_11D;
								case 11U:
								case 18U:
									goto IL_AC;
								case 12U:
									goto IL_148;
								case 14U:
									goto IL_155;
								case 15U:
									goto IL_D0;
								case 16U:
									goto IL_12A;
								case 17U:
									goto IL_122;
								case 19U:
									goto IL_18A;
								case 20U:
									goto IL_181;
								case 21U:
									goto IL_F6;
								}
								goto Block_5;
							}
							goto IL_141;
						}
					}
					Block_5:
					goto IL_1A9;
					IL_141:
					IL_142:
					packingListViewModel.SetSeller();
					IL_148:
					if (packingListViewModel.Document.Customer == null)
					{
						goto IL_1A9;
					}
					IL_155:
					packingListViewModel.CustomerId = packingListViewModel.Document.Customer.CustomerId;
					TaskAwaiter awaiter2 = packingListViewModel.LoadCustomerPaymentDetails().GetAwaiter();
					IL_178:
					if (awaiter2.IsCompleted)
					{
						goto IL_1A2;
					}
					IL_181:
					this.<>1__state = 1;
					IL_18A:
					this.<>u__2 = awaiter2;
					this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, PackingListViewModel.<SelectInvoice>d__6>(ref awaiter2, ref this);
					return;
					IL_AC:
					if (num == 1)
					{
						goto IL_122;
					}
					IL_B0:
					awaiter = packingListViewModel._invoiceService.GetInvoice(this.invoiceId).GetAwaiter();
					IL_C7:
					if (awaiter.IsCompleted)
					{
						goto IL_D0;
					}
					goto IL_FF;
					IL_DD:
					int num3 = -1;
					num = -1;
					this.<>1__state = num3;
					goto IL_D0;
					IL_E8:
					this.<>u__1 = default(TaskAwaiter<Invoice>);
					goto IL_DD;
					IL_F6:
					awaiter = this.<>u__1;
					goto IL_E8;
					IL_FF:
					this.<>1__state = 0;
					IL_108:
					this.<>u__1 = awaiter;
					this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Invoice>, PackingListViewModel.<SelectInvoice>d__6>(ref awaiter, ref this);
					IL_11D:
					return;
					IL_122:
					awaiter2 = this.<>u__2;
					IL_12A:
					this.<>u__2 = default(TaskAwaiter);
					this.<>1__state = -1;
					IL_1A2:
					awaiter2.GetResult();
					IL_1A9:;
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

			// Token: 0x0600504D RID: 20557 RVA: 0x0015C840 File Offset: 0x0015AA40
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003570 RID: 13680
			public int <>1__state;

			// Token: 0x04003571 RID: 13681
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04003572 RID: 13682
			public PackingListViewModel <>4__this;

			// Token: 0x04003573 RID: 13683
			public int invoiceId;

			// Token: 0x04003574 RID: 13684
			private TaskAwaiter<Invoice> <>u__1;

			// Token: 0x04003575 RID: 13685
			private TaskAwaiter <>u__2;
		}
	}
}
