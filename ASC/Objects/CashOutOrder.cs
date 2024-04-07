using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Models;
using ASC.Objects.Reports;
using DevExpress.XtraReports.UI;
using Poly;

namespace ASC.Objects
{
	// Token: 0x02000879 RID: 2169
	public class CashOutOrder : CashOrder
	{
		// Token: 0x06004121 RID: 16673 RVA: 0x00101D7C File Offset: 0x000FFF7C
		public CashOutOrder()
		{
		}

		// Token: 0x06004122 RID: 16674 RVA: 0x00101D90 File Offset: 0x000FFF90
		public CashOutOrder(CashOrder o)
		{
			o.CopyProperties(this);
		}

		// Token: 0x06004123 RID: 16675 RVA: 0x00101DAC File Offset: 0x000FFFAC
		public void FillByPaymentToDealer(int customerId, decimal summ)
		{
			base.SetCustomer(new int?(customerId));
			this.SetSumm(summ);
			base.SetType(Kassa.Types.DealerOfGoodsPayment);
			base.AutocompleteReason();
		}

		// Token: 0x06004124 RID: 16676 RVA: 0x00101DDC File Offset: 0x000FFFDC
		public override void SetSumm(decimal summ)
		{
			base.Summ = -Math.Abs(summ);
			base.SetSummaString();
		}

		// Token: 0x06004125 RID: 16677 RVA: 0x00101E00 File Offset: 0x00100000
		public Task<XtraReport> CreateReport()
		{
			CashOutOrder.<CreateReport>d__4 <CreateReport>d__;
			<CreateReport>d__.<>t__builder = AsyncTaskMethodBuilder<XtraReport>.Create();
			<CreateReport>d__.<>4__this = this;
			<CreateReport>d__.<>1__state = -1;
			<CreateReport>d__.<>t__builder.Start<CashOutOrder.<CreateReport>d__4>(ref <CreateReport>d__);
			return <CreateReport>d__.<>t__builder.Task;
		}

		// Token: 0x0200087A RID: 2170
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004126 RID: 16678 RVA: 0x00101E44 File Offset: 0x00100044
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004127 RID: 16679 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x04002A68 RID: 10856
			public static readonly CashOutOrder.<>c <>9 = new CashOutOrder.<>c();
		}

		// Token: 0x0200087B RID: 2171
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateReport>d__4 : IAsyncStateMachine
		{
			// Token: 0x06004128 RID: 16680 RVA: 0x00101E5C File Offset: 0x0010005C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CashOutOrder order = this.<>4__this;
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
								awaiter = this.<ctx>5__3.doc_templates.FirstOrDefaultAsync((doc_templates t) => t.name == "rko").GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<doc_templates>, CashOutOrder.<CreateReport>d__4>(ref awaiter, ref this);
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
								goto IL_1B0;
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
				IL_1B0:
				this.<>1__state = -2;
				this.<report>5__2 = null;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06004129 RID: 16681 RVA: 0x00102080 File Offset: 0x00100280
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002A69 RID: 10857
			public int <>1__state;

			// Token: 0x04002A6A RID: 10858
			public AsyncTaskMethodBuilder<XtraReport> <>t__builder;

			// Token: 0x04002A6B RID: 10859
			public CashOutOrder <>4__this;

			// Token: 0x04002A6C RID: 10860
			private XtraReport <report>5__2;

			// Token: 0x04002A6D RID: 10861
			private auseceEntities <ctx>5__3;

			// Token: 0x04002A6E RID: 10862
			private TaskAwaiter<doc_templates> <>u__1;
		}
	}
}
