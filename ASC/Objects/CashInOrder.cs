using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects.Reports;
using ASC.SimpleClasses;
using Autofac;
using DevExpress.XtraReports.UI;

namespace ASC.Objects
{
	// Token: 0x020008B2 RID: 2226
	public class CashInOrder : CashOrder
	{
		// Token: 0x170012A2 RID: 4770
		// (get) Token: 0x060043DF RID: 17375 RVA: 0x0010A96C File Offset: 0x00108B6C
		// (set) Token: 0x060043E0 RID: 17376 RVA: 0x0010A980 File Offset: 0x00108B80
		public string InvoiceNum
		{
			[CompilerGenerated]
			get
			{
				return this.<InvoiceNum>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<InvoiceNum>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<InvoiceNum>k__BackingField = value;
				this.RaisePropertyChanged("InvoiceNum");
			}
		}

		// Token: 0x060043E1 RID: 17377 RVA: 0x00101D7C File Offset: 0x000FFF7C
		public CashInOrder()
		{
		}

		// Token: 0x060043E2 RID: 17378 RVA: 0x0010A9B0 File Offset: 0x00108BB0
		public CashInOrder(workshop repair, decimal summ, Kassa.Types type)
		{
			base.RepairId = new int?(repair.id);
			base.Type = (int)type;
			base.PaymentSystem = repair.payment_system;
			base.AutocompleteReason();
			switch (repair.prepaid_type)
			{
			case 1:
				base.Reason = string.Format("Полная предоплата стоимости ремонта №{0:D6} в размере {1:N2}", repair.id, summ);
				break;
			case 2:
				base.Reason = string.Format("Предоплата за детали для ремонта №{0:D6} в размере {1:N2}", repair.id, summ);
				break;
			case 3:
				base.Reason = string.Format("Предоплата за часть стоимости деталей для ремонта №{0:D6} в размере {1:N2}", repair.id, summ);
				break;
			case 4:
				base.Reason = string.Format("Предоплата за часть стоимости работ ремонта №{0:D6} в размере {1:N2}", repair.id, summ);
				break;
			}
			this.SetSumm(summ);
			base.SetCustomer(new int?(repair.client));
			base.CompanyId = repair.company;
		}

		// Token: 0x060043E3 RID: 17379 RVA: 0x0010AAC0 File Offset: 0x00108CC0
		public void SetPinpadData(IPinpadResult r)
		{
			base.PinpadId = r.PinpadId;
			base.Amount = r.Amount;
			base.TermNum = r.TermNum;
			base.ClientCard = r.ClientCard;
			base.ClientExpiryDate = r.ClientExpiryDate;
			base.AuthCode = r.AuthCode;
			base.CardName = r.CardName;
		}

		// Token: 0x060043E4 RID: 17380 RVA: 0x0010AB24 File Offset: 0x00108D24
		public void FillByRepair(int repairId)
		{
			CashInOrder.<FillByRepair>d__7 <FillByRepair>d__;
			<FillByRepair>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<FillByRepair>d__.<>4__this = this;
			<FillByRepair>d__.repairId = repairId;
			<FillByRepair>d__.<>1__state = -1;
			<FillByRepair>d__.<>t__builder.Start<CashInOrder.<FillByRepair>d__7>(ref <FillByRepair>d__);
		}

		// Token: 0x060043E5 RID: 17381 RVA: 0x0010AB64 File Offset: 0x00108D64
		public void FillByRepair(workshop repair, Kassa.Types type)
		{
			CashInOrder.<FillByRepair>d__8 <FillByRepair>d__;
			<FillByRepair>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<FillByRepair>d__.<>4__this = this;
			<FillByRepair>d__.repair = repair;
			<FillByRepair>d__.type = type;
			<FillByRepair>d__.<>1__state = -1;
			<FillByRepair>d__.<>t__builder.Start<CashInOrder.<FillByRepair>d__8>(ref <FillByRepair>d__);
		}

		// Token: 0x060043E6 RID: 17382 RVA: 0x0010ABAC File Offset: 0x00108DAC
		public void FillByDoc(DocsList document)
		{
			base.DocumentId = new int?(document.id);
			this.SetSumm(document.total);
			if (document.dealer != null)
			{
				base.SetCustomer(new int?(document.dealer.Value));
			}
		}

		// Token: 0x060043E7 RID: 17383 RVA: 0x0010AC00 File Offset: 0x00108E00
		public CashInOrder(docs document)
		{
			base.CompanyId = document.company;
			base.SetType(Kassa.Types.soldByRn);
			base.DocumentId = new int?(document.id);
			base.PaymentSystem = document.payment_system;
			this.SetSumm(document.total);
			if (document.dealer != null)
			{
				base.SetCustomer(new int?(document.dealer.Value));
			}
			base.AutocompleteReason();
		}

		// Token: 0x060043E8 RID: 17384 RVA: 0x0010AC80 File Offset: 0x00108E80
		public CashInOrder(IStoreDocument document)
		{
			base.CompanyId = document.CompanyId;
			base.SetType(Kassa.Types.soldByRn);
			base.DocumentId = new int?(document.Id);
			base.PaymentSystem = document.PaymentSystem;
			this.SetSumm(document.Total);
			if (document.DealerId != null)
			{
				base.SetCustomer(new int?(document.DealerId.Value));
			}
			base.AutocompleteReason();
		}

		// Token: 0x060043E9 RID: 17385 RVA: 0x0010AD00 File Offset: 0x00108F00
		public override string CheckFields()
		{
			int? customerId = base.CustomerId;
			if (customerId.GetValueOrDefault() == 0 & customerId != null)
			{
				return "InputPayer";
			}
			if (base.Type == 0)
			{
				return "SelectPkoType";
			}
			if (base.Type == 13 && base.Customer != null && !base.Customer.BalanceEnabled)
			{
				return "TurnOnClientBalance";
			}
			if (base.Summ == 0m)
			{
				return "InputSumm";
			}
			if (base.Summ < 0m)
			{
				return "PkoSummError";
			}
			if (base.CompanyId != 0)
			{
				return "";
			}
			return "InputCompany";
		}

		// Token: 0x060043EA RID: 17386 RVA: 0x0010ADA4 File Offset: 0x00108FA4
		public Task<XtraReport> CreateReport()
		{
			CashInOrder.<CreateReport>d__13 <CreateReport>d__;
			<CreateReport>d__.<>t__builder = AsyncTaskMethodBuilder<XtraReport>.Create();
			<CreateReport>d__.<>4__this = this;
			<CreateReport>d__.<>1__state = -1;
			<CreateReport>d__.<>t__builder.Start<CashInOrder.<CreateReport>d__13>(ref <CreateReport>d__);
			return <CreateReport>d__.<>t__builder.Task;
		}

		// Token: 0x04002BDB RID: 11227
		[CompilerGenerated]
		private string <InvoiceNum>k__BackingField;

		// Token: 0x020008B3 RID: 2227
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <FillByRepair>d__7 : IAsyncStateMachine
		{
			// Token: 0x060043EB RID: 17387 RVA: 0x0010ADE8 File Offset: 0x00108FE8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CashInOrder cashInOrder = this.<>4__this;
				try
				{
					TaskAwaiter<decimal> awaiter;
					TaskAwaiter<RepairPaymentInfo> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<decimal>);
							this.<>1__state = -1;
							goto IL_EE;
						}
						cashInOrder.RepairId = new int?(this.repairId);
						awaiter2 = Bootstrapper.Container.Resolve<IWorkshopService>().GetRepairPaymentInfo(this.repairId).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<RepairPaymentInfo>, CashInOrder.<FillByRepair>d__7>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<RepairPaymentInfo>);
						this.<>1__state = -1;
					}
					RepairPaymentInfo result = awaiter2.GetResult();
					this.<repairInfo>5__2 = result;
					cashInOrder.PaymentSystem = this.<repairInfo>5__2.PaymentSystemId;
					awaiter = RepairModel.GetRepairFinalAmount(this.repairId).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, CashInOrder.<FillByRepair>d__7>(ref awaiter, ref this);
						return;
					}
					IL_EE:
					decimal result2 = awaiter.GetResult();
					decimal summ = (result2 < 0m) ? 0m : result2;
					cashInOrder.SetSumm(summ);
					cashInOrder.SetCustomer(new int?(this.<repairInfo>5__2.CustomerId));
					cashInOrder.CompanyId = this.<repairInfo>5__2.CompanyId;
					cashInOrder.AutocompleteReason();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<repairInfo>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<repairInfo>5__2 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060043EC RID: 17388 RVA: 0x0010AFB0 File Offset: 0x001091B0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002BDC RID: 11228
			public int <>1__state;

			// Token: 0x04002BDD RID: 11229
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04002BDE RID: 11230
			public CashInOrder <>4__this;

			// Token: 0x04002BDF RID: 11231
			public int repairId;

			// Token: 0x04002BE0 RID: 11232
			private RepairPaymentInfo <repairInfo>5__2;

			// Token: 0x04002BE1 RID: 11233
			private TaskAwaiter<RepairPaymentInfo> <>u__1;

			// Token: 0x04002BE2 RID: 11234
			private TaskAwaiter<decimal> <>u__2;
		}

		// Token: 0x020008B4 RID: 2228
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <FillByRepair>d__8 : IAsyncStateMachine
		{
			// Token: 0x060043ED RID: 17389 RVA: 0x0010AFCC File Offset: 0x001091CC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CashInOrder cashInOrder = this.<>4__this;
				try
				{
					TaskAwaiter<decimal> awaiter;
					if (num != 0)
					{
						cashInOrder.RepairId = new int?(this.repair.id);
						cashInOrder.PaymentSystem = this.repair.payment_system;
						awaiter = RepairModel.GetRepairFinalAmount(this.repair.id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, CashInOrder.<FillByRepair>d__8>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<decimal>);
						this.<>1__state = -1;
					}
					decimal result = awaiter.GetResult();
					decimal summ = (result < 0m) ? 0m : result;
					cashInOrder.SetSumm(summ);
					cashInOrder.SetCustomer(new int?(this.repair.client));
					cashInOrder.CompanyId = this.repair.company;
					cashInOrder.AutocompleteReason();
					cashInOrder.SetType(this.type);
					cashInOrder.AutocompleteReason();
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

			// Token: 0x060043EE RID: 17390 RVA: 0x0010B114 File Offset: 0x00109314
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002BE3 RID: 11235
			public int <>1__state;

			// Token: 0x04002BE4 RID: 11236
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04002BE5 RID: 11237
			public CashInOrder <>4__this;

			// Token: 0x04002BE6 RID: 11238
			public workshop repair;

			// Token: 0x04002BE7 RID: 11239
			public Kassa.Types type;

			// Token: 0x04002BE8 RID: 11240
			private TaskAwaiter<decimal> <>u__1;
		}

		// Token: 0x020008B5 RID: 2229
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060043EF RID: 17391 RVA: 0x0010B130 File Offset: 0x00109330
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060043F0 RID: 17392 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x04002BE9 RID: 11241
			public static readonly CashInOrder.<>c <>9 = new CashInOrder.<>c();
		}

		// Token: 0x020008B6 RID: 2230
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateReport>d__13 : IAsyncStateMachine
		{
			// Token: 0x060043F1 RID: 17393 RVA: 0x0010B148 File Offset: 0x00109348
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CashInOrder order = this.<>4__this;
				XtraReport result2;
				try
				{
					if (num != 0)
					{
						this.<report>5__2 = new XtraReport();
					}
					try
					{
						if (num != 0)
						{
							this.<ctx>5__3 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<doc_templates> awaiter;
							if (num != 0)
							{
								awaiter = this.<ctx>5__3.doc_templates.FirstOrDefaultAsync((doc_templates t) => t.name == "pko").GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<doc_templates>, CashInOrder.<CreateReport>d__13>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<doc_templates>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							doc_templates result = awaiter.GetResult();
							if (result == null)
							{
								result2 = this.<report>5__2;
								goto IL_1AD;
							}
							string @string = Encoding.UTF8.GetString(result.data);
							this.<report>5__2.Tag = result.id;
							this.<report>5__2.LoadLayout(ReportPrintModel.GenerateStreamFromString(@string));
							this.<report>5__2.DataSource = new List<CashOrderReport>
							{
								new CashOrderReport(order)
							};
							this.<report>5__2.CreateDocument();
						}
						finally
						{
							if (num < 0 && this.<ctx>5__3 != null)
							{
								((IDisposable)this.<ctx>5__3).Dispose();
							}
						}
						this.<ctx>5__3 = null;
					}
					catch (Exception)
					{
					}
					result2 = this.<report>5__2;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<report>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_1AD:
				this.<>1__state = -2;
				this.<report>5__2 = null;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x060043F2 RID: 17394 RVA: 0x0010B36C File Offset: 0x0010956C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002BEA RID: 11242
			public int <>1__state;

			// Token: 0x04002BEB RID: 11243
			public AsyncTaskMethodBuilder<XtraReport> <>t__builder;

			// Token: 0x04002BEC RID: 11244
			public CashInOrder <>4__this;

			// Token: 0x04002BED RID: 11245
			private XtraReport <report>5__2;

			// Token: 0x04002BEE RID: 11246
			private auseceEntities <ctx>5__3;

			// Token: 0x04002BEF RID: 11247
			private TaskAwaiter<doc_templates> <>u__1;
		}
	}
}
