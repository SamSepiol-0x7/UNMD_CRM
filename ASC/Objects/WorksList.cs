using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using ASC.Common.Interfaces;
using ASC.Common.Repositories;
using ASC.Models;
using Autofac;

namespace ASC.Objects
{
	// Token: 0x020008FE RID: 2302
	public class WorksList : InvoiceBase, ICheckFields, IInvoice, IInvoiceLookup, IWorksList, IInvoiceDocument
	{
		// Token: 0x17001402 RID: 5122
		// (get) Token: 0x060047CA RID: 18378 RVA: 0x00117148 File Offset: 0x00115348
		// (set) Token: 0x060047CB RID: 18379 RVA: 0x0011715C File Offset: 0x0011535C
		public string Reason
		{
			[CompilerGenerated]
			get
			{
				return this.<Reason>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Reason>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Reason>k__BackingField = value;
				this.RaisePropertyChanged("Reason");
			}
		}

		// Token: 0x17001403 RID: 5123
		// (get) Token: 0x060047CC RID: 18380 RVA: 0x0011718C File Offset: 0x0011538C
		// (set) Token: 0x060047CD RID: 18381 RVA: 0x001171A0 File Offset: 0x001153A0
		public int? InvoiceId
		{
			[CompilerGenerated]
			get
			{
				return this.<InvoiceId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!Nullable.Equals<int>(this.<InvoiceId>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 2019806047;
				IL_13:
				switch ((num ^ 2110023409) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					IL_32:
					num = 1026728714;
					goto IL_13;
				case 2:
					return;
				}
				this.<InvoiceId>k__BackingField = value;
				this.RaisePropertyChanged("InvoiceId");
			}
		}

		// Token: 0x060047CE RID: 18382 RVA: 0x001171FC File Offset: 0x001153FC
		public WorksList()
		{
			this._worksListRepository = Bootstrapper.Container.Resolve<IWorksListRepository>();
		}

		// Token: 0x060047CF RID: 18383 RVA: 0x00117220 File Offset: 0x00115420
		public override void SetNum()
		{
			WorksList.<SetNum>d__10 <SetNum>d__;
			<SetNum>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SetNum>d__.<>4__this = this;
			<SetNum>d__.<>1__state = -1;
			<SetNum>d__.<>t__builder.Start<WorksList.<SetNum>d__10>(ref <SetNum>d__);
		}

		// Token: 0x060047D0 RID: 18384 RVA: 0x00117258 File Offset: 0x00115458
		public void ConstructReason(IInvoice invoice)
		{
			this.Reason = string.Format("{0} № {1} {2} {3:dd.MM.yyyy}", new object[]
			{
				(string)Application.Current.TryFindResource("Invoice"),
				invoice.Num,
				(string)Application.Current.TryFindResource("From"),
				invoice.Date
			});
		}

		// Token: 0x060047D1 RID: 18385 RVA: 0x001172C0 File Offset: 0x001154C0
		public void FillFromInvoice(IInvoice invoice)
		{
			this.InvoiceId = new int?(invoice.Id);
			base.Employee = invoice.Employee;
			foreach (IInvoiceItem invoiceItem in invoice.Items)
			{
				invoiceItem.Id = 0;
			}
			base.Items = invoice.Items;
			base.Seller = invoice.Seller;
			base.Customer = invoice.Customer;
			this.ConstructReason(invoice);
			this.CalcTotal();
		}

		// Token: 0x060047D2 RID: 18386 RVA: 0x0011735C File Offset: 0x0011555C
		public override string CheckFields()
		{
			string text = base.CheckFields();
			if (!string.IsNullOrEmpty(text))
			{
				goto IL_5F;
			}
			goto IL_9B;
			int num;
			for (;;)
			{
				IL_64:
				switch ((num ^ 1342020137) % 7)
				{
				case 0:
					goto IL_9B;
				case 1:
					goto IL_AD;
				case 3:
					goto IL_B5;
				case 4:
					goto IL_5F;
				case 5:
					return text;
				case 6:
					num = ((this._worksListRepository.GetWokrsListLookup(base.Num, DateTime.Now.Year).Result != null) ? 462157931 : 857994331);
					continue;
				}
				break;
			}
			goto IL_B3;
			IL_AD:
			return "InvoiceNumErr";
			IL_B3:
			return null;
			IL_B5:
			return "InputReason";
			IL_5F:
			num = 949995;
			goto IL_64;
			IL_9B:
			num = ((!string.IsNullOrEmpty(this.Reason)) ? 1816795767 : 919386384);
			goto IL_64;
		}

		// Token: 0x060047D3 RID: 18387 RVA: 0x00117428 File Offset: 0x00115628
		public override Task<byte[]> GetPdf(string templateName = "")
		{
			WorksList.<GetPdf>d__14 <GetPdf>d__;
			<GetPdf>d__.<>t__builder = AsyncTaskMethodBuilder<byte[]>.Create();
			<GetPdf>d__.<>4__this = this;
			<GetPdf>d__.templateName = templateName;
			<GetPdf>d__.<>1__state = -1;
			<GetPdf>d__.<>t__builder.Start<WorksList.<GetPdf>d__14>(ref <GetPdf>d__);
			return <GetPdf>d__.<>t__builder.Task;
		}

		// Token: 0x060047D4 RID: 18388 RVA: 0x00117474 File Offset: 0x00115674
		public override string GetNumAndDateStr()
		{
			return (string)Application.Current.TryFindResource("PrintWorks") + " № " + base.Num;
		}

		// Token: 0x04002DF2 RID: 11762
		[CompilerGenerated]
		private string <Reason>k__BackingField;

		// Token: 0x04002DF3 RID: 11763
		[CompilerGenerated]
		private int? <InvoiceId>k__BackingField;

		// Token: 0x04002DF4 RID: 11764
		private IWorksListRepository _worksListRepository;

		// Token: 0x020008FF RID: 2303
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SetNum>d__10 : IAsyncStateMachine
		{
			// Token: 0x060047D5 RID: 18389 RVA: 0x001174A8 File Offset: 0x001156A8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorksList worksList = this.<>4__this;
				try
				{
					TaskAwaiter<string> awaiter;
					if (num != 0)
					{
						awaiter = worksList._worksListRepository.GetLastWokrsListId(worksList.Seller.Id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, WorksList.<SetNum>d__10>(ref awaiter, ref this);
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
					worksList.SetNum(result);
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

			// Token: 0x060047D6 RID: 18390 RVA: 0x00117574 File Offset: 0x00115774
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002DF5 RID: 11765
			public int <>1__state;

			// Token: 0x04002DF6 RID: 11766
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04002DF7 RID: 11767
			public WorksList <>4__this;

			// Token: 0x04002DF8 RID: 11768
			private TaskAwaiter<string> <>u__1;
		}

		// Token: 0x02000900 RID: 2304
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetPdf>d__14 : IAsyncStateMachine
		{
			// Token: 0x060047D7 RID: 18391 RVA: 0x00117590 File Offset: 0x00115790
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorksList invoice = this.<>4__this;
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
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<byte[]>, WorksList.<GetPdf>d__14>(ref awaiter, ref this);
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

			// Token: 0x060047D8 RID: 18392 RVA: 0x0011764C File Offset: 0x0011584C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002DF9 RID: 11769
			public int <>1__state;

			// Token: 0x04002DFA RID: 11770
			public AsyncTaskMethodBuilder<byte[]> <>t__builder;

			// Token: 0x04002DFB RID: 11771
			public string templateName;

			// Token: 0x04002DFC RID: 11772
			public WorksList <>4__this;

			// Token: 0x04002DFD RID: 11773
			private TaskAwaiter<byte[]> <>u__1;
		}
	}
}
