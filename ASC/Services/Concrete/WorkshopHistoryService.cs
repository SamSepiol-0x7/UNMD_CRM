using System;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Models;
using ASC.Options;
using ASC.Services.Abstract;

namespace ASC.Services.Concrete
{
	// Token: 0x020007C2 RID: 1986
	public class WorkshopHistoryService : IWorkshopHistoryService
	{
		// Token: 0x06003C3E RID: 15422 RVA: 0x000F0288 File Offset: 0x000EE488
		public WorkshopHistoryService(ILoggerService<WorkshopHistoryService> loggerService)
		{
			this._loggerService = loggerService;
		}

		// Token: 0x06003C3F RID: 15423 RVA: 0x000F02A4 File Offset: 0x000EE4A4
		public Task LogRepairChanges(workshop original, workshop current)
		{
			WorkshopHistoryService.<LogRepairChanges>d__2 <LogRepairChanges>d__;
			<LogRepairChanges>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LogRepairChanges>d__.<>4__this = this;
			<LogRepairChanges>d__.original = original;
			<LogRepairChanges>d__.current = current;
			<LogRepairChanges>d__.<>1__state = -1;
			<LogRepairChanges>d__.<>t__builder.Start<WorkshopHistoryService.<LogRepairChanges>d__2>(ref <LogRepairChanges>d__);
			return <LogRepairChanges>d__.<>t__builder.Task;
		}

		// Token: 0x06003C40 RID: 15424 RVA: 0x000F02F8 File Offset: 0x000EE4F8
		private Task<string> GetMakerNameById(int makerId)
		{
			WorkshopHistoryService.<GetMakerNameById>d__3 <GetMakerNameById>d__;
			<GetMakerNameById>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<GetMakerNameById>d__.<>4__this = this;
			<GetMakerNameById>d__.makerId = makerId;
			<GetMakerNameById>d__.<>1__state = -1;
			<GetMakerNameById>d__.<>t__builder.Start<WorkshopHistoryService.<GetMakerNameById>d__3>(ref <GetMakerNameById>d__);
			return <GetMakerNameById>d__.<>t__builder.Task;
		}

		// Token: 0x06003C41 RID: 15425 RVA: 0x000F0344 File Offset: 0x000EE544
		private Task<string> GetModelNameById(int modelId)
		{
			WorkshopHistoryService.<GetModelNameById>d__4 <GetModelNameById>d__;
			<GetModelNameById>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<GetModelNameById>d__.<>4__this = this;
			<GetModelNameById>d__.modelId = modelId;
			<GetModelNameById>d__.<>1__state = -1;
			<GetModelNameById>d__.<>t__builder.Start<WorkshopHistoryService.<GetModelNameById>d__4>(ref <GetModelNameById>d__);
			return <GetModelNameById>d__.<>t__builder.Task;
		}

		// Token: 0x04002794 RID: 10132
		private readonly ILoggerService<WorkshopHistoryService> _loggerService;

		// Token: 0x020007C3 RID: 1987
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LogRepairChanges>d__2 : IAsyncStateMachine
		{
			// Token: 0x06003C42 RID: 15426 RVA: 0x000F0390 File Offset: 0x000EE590
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopHistoryService workshopHistoryService = this.<>4__this;
				try
				{
					TaskAwaiter<string> awaiter;
					TaskAwaiter<companies> awaiter2;
					TaskAwaiter awaiter3;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<string>);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<string>);
						this.<>1__state = -1;
						goto IL_272;
					case 2:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<companies>);
						this.<>1__state = -1;
						goto IL_604;
					case 3:
						awaiter3 = this.<>u__3;
						this.<>u__3 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_7B5;
					default:
						this.<history>5__2 = new HistoryV2();
						if (this.original.diagnostic_result != this.current.diagnostic_result)
						{
							this.<history>5__2.AddRepairLog("diagChanged", this.original.id, this.original.diagnostic_result, this.current.diagnostic_result);
						}
						if (this.original.repair_cost != this.current.repair_cost)
						{
							this.<history>5__2.AddRepairLog("diagSummChanged", this.original.id, this.original.repair_cost.ToString("N0"), this.current.repair_cost.ToString("N0"));
						}
						if (this.original.maker == this.current.maker)
						{
							goto IL_1AA;
						}
						this.<>7__wrap2 = this.<history>5__2;
						this.<>7__wrap3 = this.original.id;
						awaiter = workshopHistoryService.GetMakerNameById(this.current.maker).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, WorkshopHistoryService.<LogRepairChanges>d__2>(ref awaiter, ref this);
							return;
						}
						break;
					}
					string result = awaiter.GetResult();
					this.<>7__wrap2.AddRepairLog("MakerChanged", this.<>7__wrap3, result, "");
					this.<>7__wrap2 = null;
					IL_1AA:
					int? num2 = this.original.model;
					int? num3 = this.current.model;
					if (num2.GetValueOrDefault() == num3.GetValueOrDefault() & num2 != null == (num3 != null))
					{
						goto IL_29D;
					}
					this.<>7__wrap2 = this.<history>5__2;
					this.<>7__wrap3 = this.original.id;
					awaiter = workshopHistoryService.GetModelNameById(this.current.model.Value).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, WorkshopHistoryService.<LogRepairChanges>d__2>(ref awaiter, ref this);
						return;
					}
					IL_272:
					result = awaiter.GetResult();
					this.<>7__wrap2.AddRepairLog("ModelChanged", this.<>7__wrap3, result, "");
					this.<>7__wrap2 = null;
					IL_29D:
					if (this.original.serial_number != this.current.serial_number)
					{
						this.<history>5__2.AddRepairLog("snChanged", this.original.id, this.original.serial_number, this.current.serial_number);
					}
					if (this.original.fault != this.current.fault)
					{
						this.<history>5__2.AddRepairLog("faultChanged", this.original.id, this.original.fault, this.current.fault);
					}
					if (this.original.is_warranty != this.current.is_warranty)
					{
						this.<history>5__2.AddRepairLog(this.original.id, "warranty", this.current.is_warranty);
					}
					if (this.original.is_repeat != this.current.is_repeat)
					{
						this.<history>5__2.AddRepairLog(this.original.id, "repeat", this.current.is_repeat);
					}
					num3 = this.original.early;
					num2 = this.current.early;
					if (!(num3.GetValueOrDefault() == num2.GetValueOrDefault() & num3 != null == (num2 != null)))
					{
						this.<history>5__2.AddRepairLog("PreviousRepairChanged", this.original.id, string.Format("{0}", this.original.early), string.Format("{0}", this.current.early));
					}
					if (this.original.can_format != this.current.can_format)
					{
						this.<history>5__2.AddRepairLog(this.original.id, "canFormat", this.current.can_format);
					}
					bool? express_repair = this.original.express_repair;
					bool? express_repair2 = this.current.express_repair;
					if (!(express_repair.GetValueOrDefault() == express_repair2.GetValueOrDefault() & express_repair != null == (express_repair2 != null)))
					{
						this.<history>5__2.AddRepairLog(this.original.id, "expressRepair", this.current.express_repair != null && this.current.express_repair.Value);
					}
					if (this.original.quick_repair != this.current.quick_repair)
					{
						this.<history>5__2.AddRepairLog(this.original.id, "quickRepair", this.current.quick_repair);
					}
					if (this.original.thirs_party_sc != this.current.thirs_party_sc)
					{
						this.<history>5__2.AddRepairLog(this.original.id, "thirsPartySc", this.current.thirs_party_sc);
					}
					if (this.original.company == this.current.company)
					{
						goto IL_643;
					}
					awaiter2 = CompaniesModel.LoadCompany(this.current.company).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<companies>, WorkshopHistoryService.<LogRepairChanges>d__2>(ref awaiter2, ref this);
						return;
					}
					IL_604:
					companies result2 = awaiter2.GetResult();
					string prm = (result2 == null) ? "" : result2.name;
					this.<history>5__2.AddRepairLog("CompanyChanged", this.original.id, prm, "");
					IL_643:
					if (this.original.payment_system != this.current.payment_system)
					{
						string optionName = new PaymentOptions().GetOptionName(this.current.payment_system);
						this.<history>5__2.AddRepairLog("paymentSystemChanged", this.original.id, optionName, "");
					}
					num2 = this.original.vendor_id;
					num3 = this.current.vendor_id;
					if (!(num2.GetValueOrDefault() == num3.GetValueOrDefault() & num2 != null == (num3 != null)))
					{
						this.<history>5__2.AddRepairLog("VendorWarrantyChanged", this.original.id, string.Format("{0}", this.current.vendor_id), "");
					}
					if (this.original.ext_notes != this.current.ext_notes)
					{
						this.<history>5__2.AddRepairLog("NotesChanged", this.original.id, this.current.ext_notes ?? "", "");
					}
					awaiter3 = this.<history>5__2.SaveAsync().GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__3 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopHistoryService.<LogRepairChanges>d__2>(ref awaiter3, ref this);
						return;
					}
					IL_7B5:
					awaiter3.GetResult();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<history>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<history>5__2 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003C43 RID: 15427 RVA: 0x000F0BB4 File Offset: 0x000EEDB4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002795 RID: 10133
			public int <>1__state;

			// Token: 0x04002796 RID: 10134
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002797 RID: 10135
			public workshop original;

			// Token: 0x04002798 RID: 10136
			public workshop current;

			// Token: 0x04002799 RID: 10137
			public WorkshopHistoryService <>4__this;

			// Token: 0x0400279A RID: 10138
			private HistoryV2 <history>5__2;

			// Token: 0x0400279B RID: 10139
			private HistoryV2 <>7__wrap2;

			// Token: 0x0400279C RID: 10140
			private int <>7__wrap3;

			// Token: 0x0400279D RID: 10141
			private TaskAwaiter<string> <>u__1;

			// Token: 0x0400279E RID: 10142
			private TaskAwaiter<companies> <>u__2;

			// Token: 0x0400279F RID: 10143
			private TaskAwaiter <>u__3;
		}

		// Token: 0x020007C4 RID: 1988
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06003C44 RID: 15428 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x040027A0 RID: 10144
			public int makerId;
		}

		// Token: 0x020007C5 RID: 1989
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003C45 RID: 15429 RVA: 0x000F0BD0 File Offset: 0x000EEDD0
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003C46 RID: 15430 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x040027A1 RID: 10145
			public static readonly WorkshopHistoryService.<>c <>9 = new WorkshopHistoryService.<>c();
		}

		// Token: 0x020007C6 RID: 1990
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetMakerNameById>d__3 : IAsyncStateMachine
		{
			// Token: 0x06003C47 RID: 15431 RVA: 0x000F0BE8 File Offset: 0x000EEDE8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopHistoryService workshopHistoryService = this.<>4__this;
				string result;
				try
				{
					WorkshopHistoryService.<>c__DisplayClass3_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new WorkshopHistoryService.<>c__DisplayClass3_0();
						CS$<>8__locals1.makerId = this.makerId;
					}
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<string> awaiter;
							if (num != 0)
							{
								awaiter = (from m in this.<ctx>5__2.device_makers
								where m.id == CS$<>8__locals1.makerId
								select m.name).FirstOrDefaultAsync<string>().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, WorkshopHistoryService.<GetMakerNameById>d__3>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<string>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							result = awaiter.GetResult();
						}
						finally
						{
							if (num < 0 && this.<ctx>5__2 != null)
							{
								((IDisposable)this.<ctx>5__2).Dispose();
							}
						}
					}
					catch (Exception ex)
					{
						workshopHistoryService._loggerService.Error(ex, ex.Message);
						result = string.Empty;
					}
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

			// Token: 0x06003C48 RID: 15432 RVA: 0x000F0DF0 File Offset: 0x000EEFF0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040027A2 RID: 10146
			public int <>1__state;

			// Token: 0x040027A3 RID: 10147
			public AsyncTaskMethodBuilder<string> <>t__builder;

			// Token: 0x040027A4 RID: 10148
			public int makerId;

			// Token: 0x040027A5 RID: 10149
			public WorkshopHistoryService <>4__this;

			// Token: 0x040027A6 RID: 10150
			private auseceEntities <ctx>5__2;

			// Token: 0x040027A7 RID: 10151
			private TaskAwaiter<string> <>u__1;
		}

		// Token: 0x020007C7 RID: 1991
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x06003C49 RID: 15433 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x040027A8 RID: 10152
			public int modelId;
		}

		// Token: 0x020007C8 RID: 1992
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetModelNameById>d__4 : IAsyncStateMachine
		{
			// Token: 0x06003C4A RID: 15434 RVA: 0x000F0E0C File Offset: 0x000EF00C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopHistoryService workshopHistoryService = this.<>4__this;
				string result;
				try
				{
					WorkshopHistoryService.<>c__DisplayClass4_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new WorkshopHistoryService.<>c__DisplayClass4_0();
						CS$<>8__locals1.modelId = this.modelId;
					}
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<string> awaiter;
							if (num != 0)
							{
								awaiter = (from m in this.<ctx>5__2.device_models
								where m.id == CS$<>8__locals1.modelId
								select m.name).FirstOrDefaultAsync<string>().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, WorkshopHistoryService.<GetModelNameById>d__4>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<string>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							result = awaiter.GetResult();
						}
						finally
						{
							if (num < 0 && this.<ctx>5__2 != null)
							{
								((IDisposable)this.<ctx>5__2).Dispose();
							}
						}
					}
					catch (Exception ex)
					{
						workshopHistoryService._loggerService.Error(ex, ex.Message);
						result = string.Empty;
					}
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

			// Token: 0x06003C4B RID: 15435 RVA: 0x000F1014 File Offset: 0x000EF214
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040027A9 RID: 10153
			public int <>1__state;

			// Token: 0x040027AA RID: 10154
			public AsyncTaskMethodBuilder<string> <>t__builder;

			// Token: 0x040027AB RID: 10155
			public int modelId;

			// Token: 0x040027AC RID: 10156
			public WorkshopHistoryService <>4__this;

			// Token: 0x040027AD RID: 10157
			private auseceEntities <ctx>5__2;

			// Token: 0x040027AE RID: 10158
			private TaskAwaiter<string> <>u__1;
		}
	}
}
