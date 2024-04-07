using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using ASC.Common.Interfaces;
using ASC.Common.Repositories;
using ASC.Models;
using Autofac;
using DevExpress.DataAccess.ObjectBinding;

namespace ASC.Objects
{
	// Token: 0x020008E3 RID: 2275
	[HighlightedClass]
	public class PackingList : InvoiceBase, ICheckFields, IInvoice, IInvoiceLookup, IPackingList, IInvoiceDocument
	{
		// Token: 0x17001376 RID: 4982
		// (get) Token: 0x0600464C RID: 17996 RVA: 0x00112E04 File Offset: 0x00111004
		// (set) Token: 0x0600464D RID: 17997 RVA: 0x00112E18 File Offset: 0x00111018
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

		// Token: 0x17001377 RID: 4983
		// (get) Token: 0x0600464E RID: 17998 RVA: 0x00112E48 File Offset: 0x00111048
		// (set) Token: 0x0600464F RID: 17999 RVA: 0x00112E5C File Offset: 0x0011105C
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
				if (Nullable.Equals<int>(this.<InvoiceId>k__BackingField, value))
				{
					return;
				}
				this.<InvoiceId>k__BackingField = value;
				this.RaisePropertyChanged("InvoiceId");
			}
		}

		// Token: 0x17001378 RID: 4984
		// (get) Token: 0x06004650 RID: 18000 RVA: 0x00112E8C File Offset: 0x0011108C
		// (set) Token: 0x06004651 RID: 18001 RVA: 0x00112EA0 File Offset: 0x001110A0
		public string ItemRowsStr
		{
			[CompilerGenerated]
			get
			{
				return this.<ItemRowsStr>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<ItemRowsStr>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<ItemRowsStr>k__BackingField = value;
				this.RaisePropertyChanged("ItemRowsStr");
			}
		}

		// Token: 0x06004652 RID: 18002 RVA: 0x00112ED0 File Offset: 0x001110D0
		public PackingList()
		{
			this._packingListRepository = Bootstrapper.Container.Resolve<IPackingListRepository>();
		}

		// Token: 0x06004653 RID: 18003 RVA: 0x00112EF4 File Offset: 0x001110F4
		public override void SetNum()
		{
			PackingList.<SetNum>d__14 <SetNum>d__;
			<SetNum>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SetNum>d__.<>4__this = this;
			<SetNum>d__.<>1__state = -1;
			<SetNum>d__.<>t__builder.Start<PackingList.<SetNum>d__14>(ref <SetNum>d__);
		}

		// Token: 0x06004654 RID: 18004 RVA: 0x00112F2C File Offset: 0x0011112C
		public override void CalcTotal()
		{
			base.Total = base.Items.Sum((IInvoiceItem i) => i.Total);
			base.Tax = base.Items.Sum((IInvoiceItem i) => i.TaxSumm);
			base.Summ = base.Items.Sum((IInvoiceItem i) => i.SummWithoutTax);
			base.TotalSummStr = ConvertersStack.SummToString(base.Total, Auth.Config.currency);
			this.ItemRowsStr = ConvertersStack.SummToString(base.Items.Count);
		}

		// Token: 0x06004655 RID: 18005 RVA: 0x00113000 File Offset: 0x00111200
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

		// Token: 0x06004656 RID: 18006 RVA: 0x00113068 File Offset: 0x00111268
		public void FillFromInvoice(IInvoice invoice)
		{
			this.InvoiceId = new int?(invoice.Id);
			base.Employee = invoice.Employee;
			base.Items = invoice.Items;
			base.Seller = invoice.Seller;
			base.Customer = invoice.Customer;
			this.ConstructReason(invoice);
			this.CalcTotal();
		}

		// Token: 0x06004657 RID: 18007 RVA: 0x001130C4 File Offset: 0x001112C4
		public override string CheckFields()
		{
			string text = base.CheckFields();
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			if (string.IsNullOrEmpty(this.Reason))
			{
				return "InputReason";
			}
			if (this._packingListRepository.GetPackingListLookup(base.Num, DateTime.Now.Year).Result != null)
			{
				return "InvoiceNumErr";
			}
			return null;
		}

		// Token: 0x06004658 RID: 18008 RVA: 0x00113124 File Offset: 0x00111324
		public override Task<byte[]> GetPdf(string templateName = "")
		{
			PackingList.<GetPdf>d__19 <GetPdf>d__;
			<GetPdf>d__.<>t__builder = AsyncTaskMethodBuilder<byte[]>.Create();
			<GetPdf>d__.<>4__this = this;
			<GetPdf>d__.templateName = templateName;
			<GetPdf>d__.<>1__state = -1;
			<GetPdf>d__.<>t__builder.Start<PackingList.<GetPdf>d__19>(ref <GetPdf>d__);
			return <GetPdf>d__.<>t__builder.Task;
		}

		// Token: 0x06004659 RID: 18009 RVA: 0x00113170 File Offset: 0x00111370
		public override string GetNumAndDateStr()
		{
			return string.Format("{0} № {1} {2} {3:dd.MM.yyyy}", new object[]
			{
				(string)Application.Current.TryFindResource("PackingList"),
				base.Num,
				(string)Application.Current.TryFindResource("From"),
				base.Date
			});
		}

		// Token: 0x04002D2E RID: 11566
		[CompilerGenerated]
		private string <Reason>k__BackingField;

		// Token: 0x04002D2F RID: 11567
		[CompilerGenerated]
		private int? <InvoiceId>k__BackingField;

		// Token: 0x04002D30 RID: 11568
		[CompilerGenerated]
		private string <ItemRowsStr>k__BackingField;

		// Token: 0x04002D31 RID: 11569
		private IPackingListRepository _packingListRepository;

		// Token: 0x020008E4 RID: 2276
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SetNum>d__14 : IAsyncStateMachine
		{
			// Token: 0x0600465A RID: 18010 RVA: 0x001131D4 File Offset: 0x001113D4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PackingList packingList = this.<>4__this;
				try
				{
					TaskAwaiter<string> awaiter;
					if (num != 0)
					{
						awaiter = packingList._packingListRepository.GetLastPackingListId(packingList.Seller.Id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, PackingList.<SetNum>d__14>(ref awaiter, ref this);
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
					packingList.SetNum(result);
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

			// Token: 0x0600465B RID: 18011 RVA: 0x001132A0 File Offset: 0x001114A0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002D32 RID: 11570
			public int <>1__state;

			// Token: 0x04002D33 RID: 11571
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04002D34 RID: 11572
			public PackingList <>4__this;

			// Token: 0x04002D35 RID: 11573
			private TaskAwaiter<string> <>u__1;
		}

		// Token: 0x020008E5 RID: 2277
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600465C RID: 18012 RVA: 0x001132BC File Offset: 0x001114BC
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600465D RID: 18013 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x0600465E RID: 18014 RVA: 0x00111E70 File Offset: 0x00110070
			internal decimal <CalcTotal>b__15_0(IInvoiceItem i)
			{
				return i.Total;
			}

			// Token: 0x0600465F RID: 18015 RVA: 0x00111E84 File Offset: 0x00110084
			internal decimal <CalcTotal>b__15_1(IInvoiceItem i)
			{
				return i.TaxSumm;
			}

			// Token: 0x06004660 RID: 18016 RVA: 0x00111E98 File Offset: 0x00110098
			internal decimal <CalcTotal>b__15_2(IInvoiceItem i)
			{
				return i.SummWithoutTax;
			}

			// Token: 0x04002D36 RID: 11574
			public static readonly PackingList.<>c <>9 = new PackingList.<>c();

			// Token: 0x04002D37 RID: 11575
			public static Func<IInvoiceItem, decimal> <>9__15_0;

			// Token: 0x04002D38 RID: 11576
			public static Func<IInvoiceItem, decimal> <>9__15_1;

			// Token: 0x04002D39 RID: 11577
			public static Func<IInvoiceItem, decimal> <>9__15_2;
		}

		// Token: 0x020008E6 RID: 2278
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetPdf>d__19 : IAsyncStateMachine
		{
			// Token: 0x06004661 RID: 18017 RVA: 0x001132D4 File Offset: 0x001114D4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PackingList invoice = this.<>4__this;
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
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<byte[]>, PackingList.<GetPdf>d__19>(ref awaiter, ref this);
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

			// Token: 0x06004662 RID: 18018 RVA: 0x00113390 File Offset: 0x00111590
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002D3A RID: 11578
			public int <>1__state;

			// Token: 0x04002D3B RID: 11579
			public AsyncTaskMethodBuilder<byte[]> <>t__builder;

			// Token: 0x04002D3C RID: 11580
			public string templateName;

			// Token: 0x04002D3D RID: 11581
			public PackingList <>4__this;

			// Token: 0x04002D3E RID: 11582
			private TaskAwaiter<byte[]> <>u__1;
		}
	}
}
