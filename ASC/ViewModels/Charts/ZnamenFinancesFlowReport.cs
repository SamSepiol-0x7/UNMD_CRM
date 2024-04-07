using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Objects;
using ASC.Options;
using ASC.Salary;
using ASC.SimpleClasses;

namespace ASC.ViewModels.Charts
{
	// Token: 0x02000526 RID: 1318
	public class ZnamenFinancesFlowReport : FinancesFlowReport
	{
		// Token: 0x0600313E RID: 12606 RVA: 0x000A41F4 File Offset: 0x000A23F4
		protected override Task LoadOutcome()
		{
			ZnamenFinancesFlowReport.<LoadOutcome>d__0 <LoadOutcome>d__;
			<LoadOutcome>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadOutcome>d__.<>4__this = this;
			<LoadOutcome>d__.<>1__state = -1;
			<LoadOutcome>d__.<>t__builder.Start<ZnamenFinancesFlowReport.<LoadOutcome>d__0>(ref <LoadOutcome>d__);
			return <LoadOutcome>d__.<>t__builder.Task;
		}

		// Token: 0x0600313F RID: 12607 RVA: 0x000A4238 File Offset: 0x000A2438
		protected override Task<List<IFinancesFlowReportItem>> GetCurrentPeriodSalary()
		{
			ZnamenFinancesFlowReport.<GetCurrentPeriodSalary>d__1 <GetCurrentPeriodSalary>d__;
			<GetCurrentPeriodSalary>d__.<>t__builder = AsyncTaskMethodBuilder<List<IFinancesFlowReportItem>>.Create();
			<GetCurrentPeriodSalary>d__.<>4__this = this;
			<GetCurrentPeriodSalary>d__.<>1__state = -1;
			<GetCurrentPeriodSalary>d__.<>t__builder.Start<ZnamenFinancesFlowReport.<GetCurrentPeriodSalary>d__1>(ref <GetCurrentPeriodSalary>d__);
			return <GetCurrentPeriodSalary>d__.<>t__builder.Task;
		}

		// Token: 0x06003140 RID: 12608 RVA: 0x000A427C File Offset: 0x000A247C
		protected virtual void AddSalaryToOutcome(IEnumerable<IFinancesFlowReportItem> items)
		{
			decimal value = items.Sum((IFinancesFlowReportItem i) => i.Summ);
			base.Outcome.AddItem(new FinancesFlowReportItem("З/П", -Math.Abs(value), -1));
			this.CalcProfit();
			this.CalcOverview();
		}

		// Token: 0x06003141 RID: 12609 RVA: 0x000A42DC File Offset: 0x000A24DC
		public ZnamenFinancesFlowReport()
		{
		}

		// Token: 0x02000527 RID: 1319
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadOutcome>d__0 : IAsyncStateMachine
		{
			// Token: 0x06003142 RID: 12610 RVA: 0x000A42F0 File Offset: 0x000A24F0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ZnamenFinancesFlowReport znamenFinancesFlowReport = this.<>4__this;
				try
				{
					TaskAwaiter<List<payment_types>> awaiter;
					if (num != 0)
					{
						if (num - 1 <= 4)
						{
							goto IL_9D;
						}
						znamenFinancesFlowReport.Outcome.ClearItems();
						awaiter = new OrderOptions().LoadUserPaymentTypes().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.<>1__state = num2;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<payment_types>>, ZnamenFinancesFlowReport.<LoadOutcome>d__0>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<payment_types>>);
						int num3 = -1;
						num = -1;
						this.<>1__state = num3;
					}
					List<payment_types> result = awaiter.GetResult();
					this.<userTypes>5__2 = new List<IPaymentType>(result);
					this.<ctx>5__3 = new auseceEntities(true);
					IL_9D:
					try
					{
						TaskAwaiter<decimal> awaiter2;
						switch (num)
						{
						case 1:
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<decimal>);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
							break;
						}
						case 2:
							IL_14F:
							try
							{
								if (num == 2)
								{
									awaiter2 = this.<>u__2;
									this.<>u__2 = default(TaskAwaiter<decimal>);
									int num5 = -1;
									num = -1;
									this.<>1__state = num5;
									goto IL_1BD;
								}
								IL_175:
								if (!this.<>7__wrap3.MoveNext())
								{
									goto IL_236;
								}
								this.<type>5__5 = this.<>7__wrap3.Current;
								awaiter2 = znamenFinancesFlowReport.GetRkoSumAsync(this.<ctx>5__3, this.<type>5__5.Id).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									int num6 = 2;
									num = 2;
									this.<>1__state = num6;
									this.<>u__2 = awaiter2;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, ZnamenFinancesFlowReport.<LoadOutcome>d__0>(ref awaiter2, ref this);
									return;
								}
								IL_1BD:
								decimal result2 = awaiter2.GetResult();
								znamenFinancesFlowReport.Outcome.AddItem(new FinancesFlowReportItem(this.<type>5__5.Name, result2, this.<type>5__5.Id));
								this.<type>5__5 = null;
								goto IL_175;
							}
							finally
							{
								if (num < 0)
								{
									((IDisposable)this.<>7__wrap3).Dispose();
								}
							}
							IL_236:
							this.<>7__wrap3 = default(List<IPaymentType>.Enumerator);
							awaiter2 = znamenFinancesFlowReport.GetRkoSumAsync(this.<ctx>5__3, 8).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num7 = 3;
								num = 3;
								this.<>1__state = num7;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, ZnamenFinancesFlowReport.<LoadOutcome>d__0>(ref awaiter2, ref this);
								return;
							}
							goto IL_2A0;
						case 3:
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<decimal>);
							int num8 = -1;
							num = -1;
							this.<>1__state = num8;
							goto IL_2A0;
						}
						case 4:
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<decimal>);
							int num9 = -1;
							num = -1;
							this.<>1__state = num9;
							goto IL_325;
						}
						case 5:
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<decimal>);
							int num10 = -1;
							num = -1;
							this.<>1__state = num10;
							goto IL_3AA;
						}
						default:
							awaiter2 = znamenFinancesFlowReport.GetRkoSumAsync(this.<ctx>5__3, 2).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num11 = 1;
								num = 1;
								this.<>1__state = num11;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, ZnamenFinancesFlowReport.<LoadOutcome>d__0>(ref awaiter2, ref this);
								return;
							}
							break;
						}
						decimal result3 = awaiter2.GetResult();
						znamenFinancesFlowReport.Outcome.AddItem(new FinancesFlowReportItem(Lang.t("PnPayment"), result3, 2));
						this.<>7__wrap3 = this.<userTypes>5__2.GetEnumerator();
						goto IL_14F;
						IL_2A0:
						decimal result4 = awaiter2.GetResult();
						znamenFinancesFlowReport.Outcome.AddItem(new FinancesFlowReportItem(Lang.t("RepairRefund"), result4, 8));
						awaiter2 = znamenFinancesFlowReport.GetRkoSumAsync(this.<ctx>5__3, 9).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num12 = 4;
							num = 4;
							this.<>1__state = num12;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, ZnamenFinancesFlowReport.<LoadOutcome>d__0>(ref awaiter2, ref this);
							return;
						}
						IL_325:
						decimal result5 = awaiter2.GetResult();
						znamenFinancesFlowReport.Outcome.AddItem(new FinancesFlowReportItem(Lang.t("SaleRefund"), result5, 9));
						awaiter2 = znamenFinancesFlowReport.GetRkoSumAsync(this.<ctx>5__3, 1).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num13 = 5;
							num = 5;
							this.<>1__state = num13;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, ZnamenFinancesFlowReport.<LoadOutcome>d__0>(ref awaiter2, ref this);
							return;
						}
						IL_3AA:
						decimal result6 = awaiter2.GetResult();
						znamenFinancesFlowReport.Outcome.AddItem(new FinancesFlowReportItem(Lang.t("OtherV2"), result6, 1));
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
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<userTypes>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<userTypes>5__2 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003143 RID: 12611 RVA: 0x000A4778 File Offset: 0x000A2978
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001C3C RID: 7228
			public int <>1__state;

			// Token: 0x04001C3D RID: 7229
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001C3E RID: 7230
			public ZnamenFinancesFlowReport <>4__this;

			// Token: 0x04001C3F RID: 7231
			private List<IPaymentType> <userTypes>5__2;

			// Token: 0x04001C40 RID: 7232
			private TaskAwaiter<List<payment_types>> <>u__1;

			// Token: 0x04001C41 RID: 7233
			private auseceEntities <ctx>5__3;

			// Token: 0x04001C42 RID: 7234
			private TaskAwaiter<decimal> <>u__2;

			// Token: 0x04001C43 RID: 7235
			private List<IPaymentType>.Enumerator <>7__wrap3;

			// Token: 0x04001C44 RID: 7236
			private IPaymentType <type>5__5;
		}

		// Token: 0x02000528 RID: 1320
		[CompilerGenerated]
		private sealed class <>c__DisplayClass1_0
		{
			// Token: 0x06003144 RID: 12612 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass1_0()
			{
			}

			// Token: 0x06003145 RID: 12613 RVA: 0x000A4794 File Offset: 0x000A2994
			internal UserSalaryReport <GetCurrentPeriodSalary>b__1()
			{
				SalaryModel model = this.<>4__this._model;
				users user = this.employee;
				IPeriod period = this.<>4__this._period;
				int? salary_rate = this.employee.salary_rate;
				return model.LoadUserReport(user, period, (salary_rate != null) ? new decimal?(salary_rate.GetValueOrDefault()) : null);
			}

			// Token: 0x04001C45 RID: 7237
			public users employee;

			// Token: 0x04001C46 RID: 7238
			public ZnamenFinancesFlowReport <>4__this;
		}

		// Token: 0x02000529 RID: 1321
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003146 RID: 12614 RVA: 0x000A47F4 File Offset: 0x000A29F4
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003147 RID: 12615 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06003148 RID: 12616 RVA: 0x000A480C File Offset: 0x000A2A0C
			internal decimal <AddSalaryToOutcome>b__2_0(IFinancesFlowReportItem i)
			{
				return i.Summ;
			}

			// Token: 0x04001C47 RID: 7239
			public static readonly ZnamenFinancesFlowReport.<>c <>9 = new ZnamenFinancesFlowReport.<>c();

			// Token: 0x04001C48 RID: 7240
			public static Func<IFinancesFlowReportItem, decimal> <>9__2_0;
		}

		// Token: 0x0200052A RID: 1322
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCurrentPeriodSalary>d__1 : IAsyncStateMachine
		{
			// Token: 0x06003149 RID: 12617 RVA: 0x000A4820 File Offset: 0x000A2A20
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ZnamenFinancesFlowReport znamenFinancesFlowReport = this.<>4__this;
				List<IFinancesFlowReportItem> result3;
				try
				{
					if (num > 1)
					{
						this.<result>5__2 = new List<IFinancesFlowReportItem>();
						this.<ctx>5__3 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<List<users>> awaiter;
						if (num != 0)
						{
							if (num == 1)
							{
								goto IL_116;
							}
							awaiter = (from u in this.<ctx>5__3.users
							where u.state == (int?)1
							select u).ToListAsync<users>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<users>>, ZnamenFinancesFlowReport.<GetCurrentPeriodSalary>d__1>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<users>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						List<users> result = awaiter.GetResult();
						this.<>7__wrap3 = result.GetEnumerator();
						IL_116:
						try
						{
							TaskAwaiter<UserSalaryReport> awaiter2;
							if (num == 1)
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<UserSalaryReport>);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
								goto IL_19F;
							}
							IL_13C:
							if (!this.<>7__wrap3.MoveNext())
							{
								goto IL_21B;
							}
							this.<>8__1 = new ZnamenFinancesFlowReport.<>c__DisplayClass1_0();
							this.<>8__1.<>4__this = znamenFinancesFlowReport;
							this.<>8__1.employee = this.<>7__wrap3.Current;
							awaiter2 = Task.Run<UserSalaryReport>(new Func<UserSalaryReport>(this.<>8__1.<GetCurrentPeriodSalary>b__1)).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num5 = 1;
								num = 1;
								this.<>1__state = num5;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<UserSalaryReport>, ZnamenFinancesFlowReport.<GetCurrentPeriodSalary>d__1>(ref awaiter2, ref this);
								return;
							}
							IL_19F:
							UserSalaryReport result2 = awaiter2.GetResult();
							FinancesFlowReportItem item = new FinancesFlowReportItem(this.<>8__1.employee.FioShort, result2.TotalPlus);
							this.<result>5__2.Add(item);
							this.<>8__1 = null;
							goto IL_13C;
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)this.<>7__wrap3).Dispose();
							}
						}
						IL_21B:
						this.<>7__wrap3 = default(List<users>.Enumerator);
					}
					finally
					{
						if (num < 0 && this.<ctx>5__3 != null)
						{
							((IDisposable)this.<ctx>5__3).Dispose();
						}
					}
					this.<ctx>5__3 = null;
					znamenFinancesFlowReport.AddSalaryToOutcome(this.<result>5__2);
					result3 = this.<result>5__2;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<result>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<result>5__2 = null;
				this.<>t__builder.SetResult(result3);
			}

			// Token: 0x0600314A RID: 12618 RVA: 0x000A4B14 File Offset: 0x000A2D14
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001C49 RID: 7241
			public int <>1__state;

			// Token: 0x04001C4A RID: 7242
			public AsyncTaskMethodBuilder<List<IFinancesFlowReportItem>> <>t__builder;

			// Token: 0x04001C4B RID: 7243
			public ZnamenFinancesFlowReport <>4__this;

			// Token: 0x04001C4C RID: 7244
			private ZnamenFinancesFlowReport.<>c__DisplayClass1_0 <>8__1;

			// Token: 0x04001C4D RID: 7245
			private List<IFinancesFlowReportItem> <result>5__2;

			// Token: 0x04001C4E RID: 7246
			private auseceEntities <ctx>5__3;

			// Token: 0x04001C4F RID: 7247
			private TaskAwaiter<List<users>> <>u__1;

			// Token: 0x04001C50 RID: 7248
			private List<users>.Enumerator <>7__wrap3;

			// Token: 0x04001C51 RID: 7249
			private TaskAwaiter<UserSalaryReport> <>u__2;
		}
	}
}
