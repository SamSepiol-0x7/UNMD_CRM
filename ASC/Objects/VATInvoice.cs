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
using DevExpress.DataAccess.ObjectBinding;

namespace ASC.Objects
{
	// Token: 0x020008FA RID: 2298
	[HighlightedClass]
	public class VATInvoice : InvoiceBase, ICheckFields, IInvoice, IInvoiceLookup, IInvoiceDocument, IVATInvoice
	{
		// Token: 0x170013F2 RID: 5106
		// (get) Token: 0x06004799 RID: 18329 RVA: 0x00116814 File Offset: 0x00114A14
		// (set) Token: 0x0600479A RID: 18330 RVA: 0x00116828 File Offset: 0x00114A28
		public string Currency
		{
			[CompilerGenerated]
			get
			{
				return this.<Currency>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Currency>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Currency>k__BackingField = value;
				this.RaisePropertyChanged("Currency");
			}
		}

		// Token: 0x170013F3 RID: 5107
		// (get) Token: 0x0600479B RID: 18331 RVA: 0x00116858 File Offset: 0x00114A58
		// (set) Token: 0x0600479C RID: 18332 RVA: 0x0011686C File Offset: 0x00114A6C
		public string CurrencyCode
		{
			[CompilerGenerated]
			get
			{
				return this.<CurrencyCode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<CurrencyCode>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<CurrencyCode>k__BackingField = value;
				this.RaisePropertyChanged("CurrencyCode");
			}
		}

		// Token: 0x170013F4 RID: 5108
		// (get) Token: 0x0600479D RID: 18333 RVA: 0x0011689C File Offset: 0x00114A9C
		// (set) Token: 0x0600479E RID: 18334 RVA: 0x001168B0 File Offset: 0x00114AB0
		public string StateContract
		{
			[CompilerGenerated]
			get
			{
				return this.<StateContract>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<StateContract>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<StateContract>k__BackingField = value;
				this.RaisePropertyChanged("StateContract");
			}
		}

		// Token: 0x170013F5 RID: 5109
		// (get) Token: 0x0600479F RID: 18335 RVA: 0x001168E0 File Offset: 0x00114AE0
		// (set) Token: 0x060047A0 RID: 18336 RVA: 0x001168F4 File Offset: 0x00114AF4
		public string PaymentOrder
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentOrder>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<PaymentOrder>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<PaymentOrder>k__BackingField = value;
				this.RaisePropertyChanged("PaymentOrder");
			}
		}

		// Token: 0x170013F6 RID: 5110
		// (get) Token: 0x060047A1 RID: 18337 RVA: 0x00116924 File Offset: 0x00114B24
		// (set) Token: 0x060047A2 RID: 18338 RVA: 0x00116938 File Offset: 0x00114B38
		public DateTime? PaymentOrderDate
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentOrderDate>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<DateTime>(this.<PaymentOrderDate>k__BackingField, value))
				{
					return;
				}
				this.<PaymentOrderDate>k__BackingField = value;
				this.RaisePropertyChanged("PaymentOrderDate");
			}
		}

		// Token: 0x170013F7 RID: 5111
		// (get) Token: 0x060047A3 RID: 18339 RVA: 0x00116968 File Offset: 0x00114B68
		// (set) Token: 0x060047A4 RID: 18340 RVA: 0x0011697C File Offset: 0x00114B7C
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

		// Token: 0x060047A5 RID: 18341 RVA: 0x001169AC File Offset: 0x00114BAC
		public VATInvoice(ICurrency currency)
		{
			this._vatInvoiceRepository = Bootstrapper.Container.Resolve<IVATInvoiceRepository>();
			this.Currency = currency.Name;
			this.CurrencyCode = currency.NumCode;
		}

		// Token: 0x060047A6 RID: 18342 RVA: 0x001169E8 File Offset: 0x00114BE8
		public override void SetNum()
		{
			VATInvoice.<SetNum>d__26 <SetNum>d__;
			<SetNum>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SetNum>d__.<>4__this = this;
			<SetNum>d__.<>1__state = -1;
			<SetNum>d__.<>t__builder.Start<VATInvoice.<SetNum>d__26>(ref <SetNum>d__);
		}

		// Token: 0x060047A7 RID: 18343 RVA: 0x00116A20 File Offset: 0x00114C20
		public void FillFromInvoice(IInvoice invoice)
		{
			this.InvoiceId = new int?(invoice.Id);
			base.Employee = invoice.Employee;
			base.Items = invoice.Items;
			base.Seller = invoice.Seller;
			base.Customer = invoice.Customer;
			this.CalcTotal();
		}

		// Token: 0x060047A8 RID: 18344 RVA: 0x00116A74 File Offset: 0x00114C74
		public override string CheckFields()
		{
			string text = base.CheckFields();
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			if (this._vatInvoiceRepository.GetVATInvoiceLookup(base.Num, DateTime.Now.Year).Result != null)
			{
				return "InvoiceNumErr";
			}
			return null;
		}

		// Token: 0x060047A9 RID: 18345 RVA: 0x00116AC0 File Offset: 0x00114CC0
		public override Task<byte[]> GetPdf(string templateName = "")
		{
			VATInvoice.<GetPdf>d__29 <GetPdf>d__;
			<GetPdf>d__.<>t__builder = AsyncTaskMethodBuilder<byte[]>.Create();
			<GetPdf>d__.<>4__this = this;
			<GetPdf>d__.templateName = templateName;
			<GetPdf>d__.<>1__state = -1;
			<GetPdf>d__.<>t__builder.Start<VATInvoice.<GetPdf>d__29>(ref <GetPdf>d__);
			return <GetPdf>d__.<>t__builder.Task;
		}

		// Token: 0x060047AA RID: 18346 RVA: 0x00116B0C File Offset: 0x00114D0C
		public override string GetNumAndDateStr()
		{
			return (string)Application.Current.TryFindResource("VatInvoice") + " № " + base.Num;
		}

		// Token: 0x04002DDA RID: 11738
		[CompilerGenerated]
		private string <Currency>k__BackingField;

		// Token: 0x04002DDB RID: 11739
		[CompilerGenerated]
		private string <CurrencyCode>k__BackingField;

		// Token: 0x04002DDC RID: 11740
		[CompilerGenerated]
		private string <StateContract>k__BackingField;

		// Token: 0x04002DDD RID: 11741
		[CompilerGenerated]
		private string <PaymentOrder>k__BackingField;

		// Token: 0x04002DDE RID: 11742
		[CompilerGenerated]
		private DateTime? <PaymentOrderDate>k__BackingField;

		// Token: 0x04002DDF RID: 11743
		[CompilerGenerated]
		private int? <InvoiceId>k__BackingField;

		// Token: 0x04002DE0 RID: 11744
		private IVATInvoiceRepository _vatInvoiceRepository;

		// Token: 0x020008FB RID: 2299
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SetNum>d__26 : IAsyncStateMachine
		{
			// Token: 0x060047AB RID: 18347 RVA: 0x00116B40 File Offset: 0x00114D40
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				VATInvoice vatinvoice = this.<>4__this;
				try
				{
					TaskAwaiter<string> awaiter;
					if (num != 0)
					{
						awaiter = vatinvoice._vatInvoiceRepository.GetLastInvoiveId(vatinvoice.Seller.Id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, VATInvoice.<SetNum>d__26>(ref awaiter, ref this);
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
					vatinvoice.SetNum(result);
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

			// Token: 0x060047AC RID: 18348 RVA: 0x00116C0C File Offset: 0x00114E0C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002DE1 RID: 11745
			public int <>1__state;

			// Token: 0x04002DE2 RID: 11746
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04002DE3 RID: 11747
			public VATInvoice <>4__this;

			// Token: 0x04002DE4 RID: 11748
			private TaskAwaiter<string> <>u__1;
		}

		// Token: 0x020008FC RID: 2300
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetPdf>d__29 : IAsyncStateMachine
		{
			// Token: 0x060047AD RID: 18349 RVA: 0x00116C28 File Offset: 0x00114E28
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				VATInvoice invoice = this.<>4__this;
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
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<byte[]>, VATInvoice.<GetPdf>d__29>(ref awaiter, ref this);
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

			// Token: 0x060047AE RID: 18350 RVA: 0x00116CE4 File Offset: 0x00114EE4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002DE5 RID: 11749
			public int <>1__state;

			// Token: 0x04002DE6 RID: 11750
			public AsyncTaskMethodBuilder<byte[]> <>t__builder;

			// Token: 0x04002DE7 RID: 11751
			public string templateName;

			// Token: 0x04002DE8 RID: 11752
			public VATInvoice <>4__this;

			// Token: 0x04002DE9 RID: 11753
			private TaskAwaiter<byte[]> <>u__1;
		}
	}
}
