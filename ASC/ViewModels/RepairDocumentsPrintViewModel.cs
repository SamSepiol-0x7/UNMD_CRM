using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Services.Abstract;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;

namespace ASC.ViewModels
{
	// Token: 0x0200048F RID: 1167
	public class RepairDocumentsPrintViewModel : BaseViewModel
	{
		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x06002D94 RID: 11668 RVA: 0x00093E0C File Offset: 0x0009200C
		// (set) Token: 0x06002D95 RID: 11669 RVA: 0x00093E20 File Offset: 0x00092020
		public int RepairId
		{
			[CompilerGenerated]
			get
			{
				return this.<RepairId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<RepairId>k__BackingField == value)
				{
					return;
				}
				this.<RepairId>k__BackingField = value;
				this.RaisePropertyChanged("RepairId");
			}
		}

		// Token: 0x17000E8F RID: 3727
		// (get) Token: 0x06002D96 RID: 11670 RVA: 0x00093E4C File Offset: 0x0009204C
		// (set) Token: 0x06002D97 RID: 11671 RVA: 0x00093E60 File Offset: 0x00092060
		public bool PrintNewRepair
		{
			[CompilerGenerated]
			get
			{
				return this.<PrintNewRepair>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PrintNewRepair>k__BackingField == value)
				{
					return;
				}
				this.<PrintNewRepair>k__BackingField = value;
				this.RaisePropertyChanged("PrintNewRepair");
			}
		}

		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x06002D98 RID: 11672 RVA: 0x00093E8C File Offset: 0x0009208C
		// (set) Token: 0x06002D99 RID: 11673 RVA: 0x00093EA0 File Offset: 0x000920A0
		public bool PrintWarranty
		{
			[CompilerGenerated]
			get
			{
				return this.<PrintWarranty>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PrintWarranty>k__BackingField == value)
				{
					return;
				}
				this.<PrintWarranty>k__BackingField = value;
				this.RaisePropertyChanged("PrintWarranty");
			}
		}

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x06002D9A RID: 11674 RVA: 0x00093ECC File Offset: 0x000920CC
		// (set) Token: 0x06002D9B RID: 11675 RVA: 0x00093EE0 File Offset: 0x000920E0
		public bool PrintWorks
		{
			[CompilerGenerated]
			get
			{
				return this.<PrintWorks>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PrintWorks>k__BackingField == value)
				{
					return;
				}
				this.<PrintWorks>k__BackingField = value;
				this.RaisePropertyChanged("PrintWorks");
			}
		}

		// Token: 0x17000E92 RID: 3730
		// (get) Token: 0x06002D9C RID: 11676 RVA: 0x00093F0C File Offset: 0x0009210C
		// (set) Token: 0x06002D9D RID: 11677 RVA: 0x00093F20 File Offset: 0x00092120
		public bool PrintDiag
		{
			[CompilerGenerated]
			get
			{
				return this.<PrintDiag>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PrintDiag>k__BackingField == value)
				{
					return;
				}
				this.<PrintDiag>k__BackingField = value;
				this.RaisePropertyChanged("PrintDiag");
			}
		}

		// Token: 0x17000E93 RID: 3731
		// (get) Token: 0x06002D9E RID: 11678 RVA: 0x00093F4C File Offset: 0x0009214C
		// (set) Token: 0x06002D9F RID: 11679 RVA: 0x00093F60 File Offset: 0x00092160
		public bool PrintReject
		{
			[CompilerGenerated]
			get
			{
				return this.<PrintReject>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PrintReject>k__BackingField == value)
				{
					return;
				}
				this.<PrintReject>k__BackingField = value;
				this.RaisePropertyChanged("PrintReject");
			}
		}

		// Token: 0x17000E94 RID: 3732
		// (get) Token: 0x06002DA0 RID: 11680 RVA: 0x00093F8C File Offset: 0x0009218C
		// (set) Token: 0x06002DA1 RID: 11681 RVA: 0x00093FA0 File Offset: 0x000921A0
		public bool IsRepair
		{
			[CompilerGenerated]
			get
			{
				return this.<IsRepair>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IsRepair>k__BackingField == value)
				{
					return;
				}
				this.<IsRepair>k__BackingField = value;
				this.RaisePropertyChanged("IsRepair");
			}
		}

		// Token: 0x06002DA2 RID: 11682 RVA: 0x00093FCC File Offset: 0x000921CC
		public RepairDocumentsPrintViewModel()
		{
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
			this._reportPrintService = Bootstrapper.Container.Resolve<IReportPrintService>();
		}

		// Token: 0x06002DA3 RID: 11683 RVA: 0x00094010 File Offset: 0x00092210
		public RepairDocumentsPrintViewModel(int repairId, bool isRepair = true) : this()
		{
			this.IsRepair = isRepair;
			this.RepairId = repairId;
		}

		// Token: 0x06002DA4 RID: 11684 RVA: 0x00094034 File Offset: 0x00092234
		[Command]
		public void CancelPrint()
		{
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x06002DA5 RID: 11685 RVA: 0x0009404C File Offset: 0x0009224C
		private bool NoSelected()
		{
			return !this.PrintNewRepair && !this.PrintWarranty && !this.PrintWorks && !this.PrintDiag && !this.PrintReject;
		}

		// Token: 0x06002DA6 RID: 11686 RVA: 0x00094084 File Offset: 0x00092284
		[Command]
		public void PrintDocuments()
		{
			if (this.NoSelected())
			{
				this._toasterService.Info(Lang.t("SelectDocument2"));
				return;
			}
			if (this.IsRepair)
			{
				this.PrintRepairDocuments();
				return;
			}
			this.PrintCartridgeDocuments();
		}

		// Token: 0x06002DA7 RID: 11687 RVA: 0x000940C4 File Offset: 0x000922C4
		private void PrintCartridgeDocuments()
		{
			RepairDocumentsPrintViewModel.<PrintCartridgeDocuments>d__36 <PrintCartridgeDocuments>d__;
			<PrintCartridgeDocuments>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<PrintCartridgeDocuments>d__.<>4__this = this;
			<PrintCartridgeDocuments>d__.<>1__state = -1;
			<PrintCartridgeDocuments>d__.<>t__builder.Start<RepairDocumentsPrintViewModel.<PrintCartridgeDocuments>d__36>(ref <PrintCartridgeDocuments>d__);
		}

		// Token: 0x06002DA8 RID: 11688 RVA: 0x000940FC File Offset: 0x000922FC
		private void PrintRepairDocuments()
		{
			RepairDocumentsPrintViewModel.<PrintRepairDocuments>d__37 <PrintRepairDocuments>d__;
			<PrintRepairDocuments>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<PrintRepairDocuments>d__.<>4__this = this;
			<PrintRepairDocuments>d__.<>1__state = -1;
			<PrintRepairDocuments>d__.<>t__builder.Start<RepairDocumentsPrintViewModel.<PrintRepairDocuments>d__37>(ref <PrintRepairDocuments>d__);
		}

		// Token: 0x0400198A RID: 6538
		private readonly IToasterService _toasterService;

		// Token: 0x0400198B RID: 6539
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x0400198C RID: 6540
		private readonly IReportPrintService _reportPrintService;

		// Token: 0x0400198D RID: 6541
		[CompilerGenerated]
		private int <RepairId>k__BackingField;

		// Token: 0x0400198E RID: 6542
		[CompilerGenerated]
		private bool <PrintNewRepair>k__BackingField;

		// Token: 0x0400198F RID: 6543
		[CompilerGenerated]
		private bool <PrintWarranty>k__BackingField;

		// Token: 0x04001990 RID: 6544
		[CompilerGenerated]
		private bool <PrintWorks>k__BackingField;

		// Token: 0x04001991 RID: 6545
		[CompilerGenerated]
		private bool <PrintDiag>k__BackingField;

		// Token: 0x04001992 RID: 6546
		[CompilerGenerated]
		private bool <PrintReject>k__BackingField;

		// Token: 0x04001993 RID: 6547
		[CompilerGenerated]
		private bool <IsRepair>k__BackingField;

		// Token: 0x02000490 RID: 1168
		[CompilerGenerated]
		private sealed class <>c__DisplayClass36_0
		{
			// Token: 0x06002DA9 RID: 11689 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass36_0()
			{
			}

			// Token: 0x06002DAA RID: 11690 RVA: 0x00094134 File Offset: 0x00092334
			internal Task<CartridgeReport> <PrintCartridgeDocuments>b__0()
			{
				return this.cartridgeService.GetCartgidgeReport(this.<>4__this.RepairId);
			}

			// Token: 0x06002DAB RID: 11691 RVA: 0x00094158 File Offset: 0x00092358
			internal Task <PrintCartridgeDocuments>b__1(Task<CartridgeReport> t)
			{
				RepairDocumentsPrintViewModel.<>c__DisplayClass36_0.<<PrintCartridgeDocuments>b__1>d <<PrintCartridgeDocuments>b__1>d;
				<<PrintCartridgeDocuments>b__1>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<PrintCartridgeDocuments>b__1>d.<>4__this = this;
				<<PrintCartridgeDocuments>b__1>d.t = t;
				<<PrintCartridgeDocuments>b__1>d.<>1__state = -1;
				<<PrintCartridgeDocuments>b__1>d.<>t__builder.Start<RepairDocumentsPrintViewModel.<>c__DisplayClass36_0.<<PrintCartridgeDocuments>b__1>d>(ref <<PrintCartridgeDocuments>b__1>d);
				return <<PrintCartridgeDocuments>b__1>d.<>t__builder.Task;
			}

			// Token: 0x06002DAC RID: 11692 RVA: 0x000941A4 File Offset: 0x000923A4
			internal Task<CartridgeIssueReport> <PrintCartridgeDocuments>b__2()
			{
				return this.cartridgeService.GetIssueCartridgeReport(this.<>4__this.RepairId);
			}

			// Token: 0x06002DAD RID: 11693 RVA: 0x000941C8 File Offset: 0x000923C8
			internal Task <PrintCartridgeDocuments>b__3(Task<CartridgeIssueReport> t)
			{
				RepairDocumentsPrintViewModel.<>c__DisplayClass36_0.<<PrintCartridgeDocuments>b__3>d <<PrintCartridgeDocuments>b__3>d;
				<<PrintCartridgeDocuments>b__3>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<PrintCartridgeDocuments>b__3>d.<>4__this = this;
				<<PrintCartridgeDocuments>b__3>d.t = t;
				<<PrintCartridgeDocuments>b__3>d.<>1__state = -1;
				<<PrintCartridgeDocuments>b__3>d.<>t__builder.Start<RepairDocumentsPrintViewModel.<>c__DisplayClass36_0.<<PrintCartridgeDocuments>b__3>d>(ref <<PrintCartridgeDocuments>b__3>d);
				return <<PrintCartridgeDocuments>b__3>d.<>t__builder.Task;
			}

			// Token: 0x04001994 RID: 6548
			public ICartridgeService cartridgeService;

			// Token: 0x04001995 RID: 6549
			public RepairDocumentsPrintViewModel <>4__this;

			// Token: 0x04001996 RID: 6550
			public XtraReport report;

			// Token: 0x02000491 RID: 1169
			[StructLayout(LayoutKind.Auto)]
			private struct <<PrintCartridgeDocuments>b__1>d : IAsyncStateMachine
			{
				// Token: 0x06002DAE RID: 11694 RVA: 0x00094214 File Offset: 0x00092414
				void IAsyncStateMachine.MoveNext()
				{
					int num = this.<>1__state;
					RepairDocumentsPrintViewModel.<>c__DisplayClass36_0 CS$<>8__locals1 = this.<>4__this;
					try
					{
						TaskAwaiter<XtraReport> awaiter;
						if (num != 0)
						{
							awaiter = ReportPrintModel.CreateReport("new_cartridge", this.t.Result).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XtraReport>, RepairDocumentsPrintViewModel.<>c__DisplayClass36_0.<<PrintCartridgeDocuments>b__1>d>(ref awaiter, ref this);
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
						CS$<>8__locals1.report.Pages.AddRange(result.Pages);
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

				// Token: 0x06002DAF RID: 11695 RVA: 0x000942F0 File Offset: 0x000924F0
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04001997 RID: 6551
				public int <>1__state;

				// Token: 0x04001998 RID: 6552
				public AsyncTaskMethodBuilder <>t__builder;

				// Token: 0x04001999 RID: 6553
				public Task<CartridgeReport> t;

				// Token: 0x0400199A RID: 6554
				public RepairDocumentsPrintViewModel.<>c__DisplayClass36_0 <>4__this;

				// Token: 0x0400199B RID: 6555
				private TaskAwaiter<XtraReport> <>u__1;
			}

			// Token: 0x02000492 RID: 1170
			[StructLayout(LayoutKind.Auto)]
			private struct <<PrintCartridgeDocuments>b__3>d : IAsyncStateMachine
			{
				// Token: 0x06002DB0 RID: 11696 RVA: 0x0009430C File Offset: 0x0009250C
				void IAsyncStateMachine.MoveNext()
				{
					int num = this.<>1__state;
					RepairDocumentsPrintViewModel.<>c__DisplayClass36_0 CS$<>8__locals1 = this.<>4__this;
					try
					{
						TaskAwaiter<XtraReport> awaiter;
						if (num != 0)
						{
							awaiter = ReportPrintModel.CreateReport("issue_cartridge", this.t.Result).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XtraReport>, RepairDocumentsPrintViewModel.<>c__DisplayClass36_0.<<PrintCartridgeDocuments>b__3>d>(ref awaiter, ref this);
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
						CS$<>8__locals1.report.Pages.AddRange(result.Pages);
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

				// Token: 0x06002DB1 RID: 11697 RVA: 0x000943E8 File Offset: 0x000925E8
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x0400199C RID: 6556
				public int <>1__state;

				// Token: 0x0400199D RID: 6557
				public AsyncTaskMethodBuilder <>t__builder;

				// Token: 0x0400199E RID: 6558
				public Task<CartridgeIssueReport> t;

				// Token: 0x0400199F RID: 6559
				public RepairDocumentsPrintViewModel.<>c__DisplayClass36_0 <>4__this;

				// Token: 0x040019A0 RID: 6560
				private TaskAwaiter<XtraReport> <>u__1;
			}
		}

		// Token: 0x02000493 RID: 1171
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <PrintCartridgeDocuments>d__36 : IAsyncStateMachine
		{
			// Token: 0x06002DB2 RID: 11698 RVA: 0x00094404 File Offset: 0x00092604
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairDocumentsPrintViewModel repairDocumentsPrintViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						this.<>8__1 = new RepairDocumentsPrintViewModel.<>c__DisplayClass36_0();
						this.<>8__1.<>4__this = this.<>4__this;
						this.<>8__1.cartridgeService = Bootstrapper.Container.Resolve<ICartridgeService>();
						repairDocumentsPrintViewModel.ShowWait();
						List<Task> list = new List<Task>();
						this.<>8__1.report = new XtraReport();
						if (repairDocumentsPrintViewModel.PrintNewRepair)
						{
							Task<Task> item = Task.Run<CartridgeReport>(new Func<Task<CartridgeReport>>(this.<>8__1.<PrintCartridgeDocuments>b__0)).ContinueWith<Task>(new Func<Task<CartridgeReport>, Task>(this.<>8__1.<PrintCartridgeDocuments>b__1));
							list.Add(item);
						}
						if (repairDocumentsPrintViewModel.PrintWorks)
						{
							Task<Task> item2 = Task.Run<CartridgeIssueReport>(new Func<Task<CartridgeIssueReport>>(this.<>8__1.<PrintCartridgeDocuments>b__2)).ContinueWith<Task>(new Func<Task<CartridgeIssueReport>, Task>(this.<>8__1.<PrintCartridgeDocuments>b__3));
							list.Add(item2);
						}
						awaiter = Task.WhenAll(list).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RepairDocumentsPrintViewModel.<PrintCartridgeDocuments>d__36>(ref awaiter, ref this);
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
					repairDocumentsPrintViewModel.HideWait();
					repairDocumentsPrintViewModel._reportPrintService.PrintPreview(this.<>8__1.report, PrinterModel.Printer.Documents);
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002DB3 RID: 11699 RVA: 0x000945BC File Offset: 0x000927BC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040019A1 RID: 6561
			public int <>1__state;

			// Token: 0x040019A2 RID: 6562
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040019A3 RID: 6563
			public RepairDocumentsPrintViewModel <>4__this;

			// Token: 0x040019A4 RID: 6564
			private RepairDocumentsPrintViewModel.<>c__DisplayClass36_0 <>8__1;

			// Token: 0x040019A5 RID: 6565
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000494 RID: 1172
		[CompilerGenerated]
		private sealed class <>c__DisplayClass37_0
		{
			// Token: 0x06002DB4 RID: 11700 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass37_0()
			{
			}

			// Token: 0x06002DB5 RID: 11701 RVA: 0x000945D8 File Offset: 0x000927D8
			internal Task<XtraReport> <PrintRepairDocuments>b__0()
			{
				return ((RepairCard)this.card).CreateReport("new_rep", 1);
			}

			// Token: 0x06002DB6 RID: 11702 RVA: 0x000945FC File Offset: 0x000927FC
			internal void <PrintRepairDocuments>b__1(Task<XtraReport> t)
			{
				this.report.Pages.AddRange(t.Result.Pages);
			}

			// Token: 0x06002DB7 RID: 11703 RVA: 0x00094624 File Offset: 0x00092824
			internal Task<XtraReport> <PrintRepairDocuments>b__2()
			{
				return ((RepairCard)this.card).CreateReport("diag", 1);
			}

			// Token: 0x06002DB8 RID: 11704 RVA: 0x000945FC File Offset: 0x000927FC
			internal void <PrintRepairDocuments>b__3(Task<XtraReport> t)
			{
				this.report.Pages.AddRange(t.Result.Pages);
			}

			// Token: 0x06002DB9 RID: 11705 RVA: 0x00094648 File Offset: 0x00092848
			internal Task<XtraReport> <PrintRepairDocuments>b__4()
			{
				return ((RepairCard)this.card).CreateReport("warranty", 1);
			}

			// Token: 0x06002DBA RID: 11706 RVA: 0x000945FC File Offset: 0x000927FC
			internal void <PrintRepairDocuments>b__5(Task<XtraReport> t)
			{
				this.report.Pages.AddRange(t.Result.Pages);
			}

			// Token: 0x06002DBB RID: 11707 RVA: 0x0009466C File Offset: 0x0009286C
			internal Task<XtraReport> <PrintRepairDocuments>b__6()
			{
				return ((RepairCard)this.card).CreateReport("works", 1);
			}

			// Token: 0x06002DBC RID: 11708 RVA: 0x000945FC File Offset: 0x000927FC
			internal void <PrintRepairDocuments>b__7(Task<XtraReport> t)
			{
				this.report.Pages.AddRange(t.Result.Pages);
			}

			// Token: 0x06002DBD RID: 11709 RVA: 0x00094690 File Offset: 0x00092890
			internal Task<XtraReport> <PrintRepairDocuments>b__8()
			{
				return ((RepairCard)this.card).CreateReport("reject", 1);
			}

			// Token: 0x06002DBE RID: 11710 RVA: 0x000945FC File Offset: 0x000927FC
			internal void <PrintRepairDocuments>b__9(Task<XtraReport> t)
			{
				this.report.Pages.AddRange(t.Result.Pages);
			}

			// Token: 0x040019A6 RID: 6566
			public IRepairCard card;

			// Token: 0x040019A7 RID: 6567
			public XtraReport report;
		}

		// Token: 0x02000495 RID: 1173
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <PrintRepairDocuments>d__37 : IAsyncStateMachine
		{
			// Token: 0x06002DBF RID: 11711 RVA: 0x000946B4 File Offset: 0x000928B4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairDocumentsPrintViewModel repairDocumentsPrintViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter<IRepairCard> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter);
							this.<>1__state = -1;
							goto IL_2A0;
						}
						this.<>8__1 = new RepairDocumentsPrintViewModel.<>c__DisplayClass37_0();
						repairDocumentsPrintViewModel.ShowWait();
						this.<>8__1.report = new XtraReport
						{
							RequestParameters = false
						};
						this.<tasks>5__2 = new List<Task>();
						awaiter2 = RepairModel.GetRepairCard(repairDocumentsPrintViewModel.RepairId).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IRepairCard>, RepairDocumentsPrintViewModel.<PrintRepairDocuments>d__37>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IRepairCard>);
						this.<>1__state = -1;
					}
					IRepairCard result = awaiter2.GetResult();
					this.<>8__1.card = result;
					this.<>8__1.report.Parameters.Add(new Parameter
					{
						Name = "CustomerId",
						Value = this.<>8__1.card.Customer.Id,
						Type = typeof(int),
						Visible = false
					});
					if (repairDocumentsPrintViewModel.PrintNewRepair)
					{
						Task item = Task.Run<XtraReport>(new Func<Task<XtraReport>>(this.<>8__1.<PrintRepairDocuments>b__0)).ContinueWith(new Action<Task<XtraReport>>(this.<>8__1.<PrintRepairDocuments>b__1));
						this.<tasks>5__2.Add(item);
					}
					if (repairDocumentsPrintViewModel.PrintDiag)
					{
						Task item2 = Task.Run<XtraReport>(new Func<Task<XtraReport>>(this.<>8__1.<PrintRepairDocuments>b__2)).ContinueWith(new Action<Task<XtraReport>>(this.<>8__1.<PrintRepairDocuments>b__3));
						this.<tasks>5__2.Add(item2);
					}
					if (repairDocumentsPrintViewModel.PrintWarranty)
					{
						Task item3 = Task.Run<XtraReport>(new Func<Task<XtraReport>>(this.<>8__1.<PrintRepairDocuments>b__4)).ContinueWith(new Action<Task<XtraReport>>(this.<>8__1.<PrintRepairDocuments>b__5));
						this.<tasks>5__2.Add(item3);
					}
					if (repairDocumentsPrintViewModel.PrintWorks)
					{
						Task item4 = Task.Run<XtraReport>(new Func<Task<XtraReport>>(this.<>8__1.<PrintRepairDocuments>b__6)).ContinueWith(new Action<Task<XtraReport>>(this.<>8__1.<PrintRepairDocuments>b__7));
						this.<tasks>5__2.Add(item4);
					}
					if (repairDocumentsPrintViewModel.PrintReject)
					{
						Task item5 = Task.Run<XtraReport>(new Func<Task<XtraReport>>(this.<>8__1.<PrintRepairDocuments>b__8)).ContinueWith(new Action<Task<XtraReport>>(this.<>8__1.<PrintRepairDocuments>b__9));
						this.<tasks>5__2.Add(item5);
					}
					awaiter = Task.WhenAll(this.<tasks>5__2).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RepairDocumentsPrintViewModel.<PrintRepairDocuments>d__37>(ref awaiter, ref this);
						return;
					}
					IL_2A0:
					awaiter.GetResult();
					repairDocumentsPrintViewModel.HideWait();
					repairDocumentsPrintViewModel._reportPrintService.PrintPreview(this.<>8__1.report, PrinterModel.Printer.Documents);
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<tasks>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<tasks>5__2 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002DC0 RID: 11712 RVA: 0x00094A0C File Offset: 0x00092C0C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040019A8 RID: 6568
			public int <>1__state;

			// Token: 0x040019A9 RID: 6569
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040019AA RID: 6570
			public RepairDocumentsPrintViewModel <>4__this;

			// Token: 0x040019AB RID: 6571
			private RepairDocumentsPrintViewModel.<>c__DisplayClass37_0 <>8__1;

			// Token: 0x040019AC RID: 6572
			private List<Task> <tasks>5__2;

			// Token: 0x040019AD RID: 6573
			private TaskAwaiter<IRepairCard> <>u__1;

			// Token: 0x040019AE RID: 6574
			private TaskAwaiter <>u__2;
		}
	}
}
