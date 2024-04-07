using System;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Objects;
using ASC.SimpleClasses;
using NLog;

namespace ASC.RepairCard
{
	// Token: 0x02000811 RID: 2065
	public class PermissionsController
	{
		// Token: 0x06003DA9 RID: 15785 RVA: 0x000F5340 File Offset: 0x000F3540
		public PermissionsController()
		{
		}

		// Token: 0x06003DAA RID: 15786 RVA: 0x000F5360 File Offset: 0x000F3560
		public Task<bool> CanOpenRepairCard(int repairId)
		{
			PermissionsController.<CanOpenRepairCard>d__2 <CanOpenRepairCard>d__;
			<CanOpenRepairCard>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<CanOpenRepairCard>d__.<>4__this = this;
			<CanOpenRepairCard>d__.repairId = repairId;
			<CanOpenRepairCard>d__.<>1__state = -1;
			<CanOpenRepairCard>d__.<>t__builder.Start<PermissionsController.<CanOpenRepairCard>d__2>(ref <CanOpenRepairCard>d__);
			return <CanOpenRepairCard>d__.<>t__builder.Task;
		}

		// Token: 0x0400284F RID: 10319
		private readonly ILogger Log = LogManager.GetCurrentClassLogger();

		// Token: 0x02000812 RID: 2066
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x06003DAB RID: 15787 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x04002850 RID: 10320
			public int repairId;
		}

		// Token: 0x02000813 RID: 2067
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003DAC RID: 15788 RVA: 0x000F53AC File Offset: 0x000F35AC
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003DAD RID: 15789 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x04002851 RID: 10321
			public static readonly PermissionsController.<>c <>9 = new PermissionsController.<>c();
		}

		// Token: 0x02000814 RID: 2068
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CanOpenRepairCard>d__2 : IAsyncStateMachine
		{
			// Token: 0x06003DAE RID: 15790 RVA: 0x000F53C4 File Offset: 0x000F35C4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PermissionsController permissionsController = this.<>4__this;
				bool result2;
				try
				{
					PermissionsController.<>c__DisplayClass2_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new PermissionsController.<>c__DisplayClass2_0();
						CS$<>8__locals1.repairId = this.repairId;
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<WorkshopLite> awaiter;
						if (num != 0)
						{
							ParameterExpression parameterExpression;
							awaiter = (from r in this.<ctx>5__2.workshop
							where r.id == CS$<>8__locals1.repairId
							select r).Select(Expression.Lambda<Func<workshop, WorkshopLite>>(Expression.MemberInit(Expression.New(typeof(WorkshopLite)), new MemberBinding[]
							{
								Expression.Bind(methodof(WorkshopLite.set_Master(int?)), Expression.Property(parameterExpression, methodof(workshop.get_master()))),
								Expression.Bind(methodof(WorkshopLite.set_Manager(int)), Expression.Property(parameterExpression, methodof(workshop.get_manager()))),
								Expression.Bind(methodof(WorkshopLite.set_CurrentManager(int)), Expression.Property(parameterExpression, methodof(workshop.get_current_manager())))
							}), new ParameterExpression[]
							{
								parameterExpression
							})).FirstOrDefaultAsync<WorkshopLite>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<WorkshopLite>, PermissionsController.<CanOpenRepairCard>d__2>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<WorkshopLite>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						WorkshopLite result = awaiter.GetResult();
						if (result.Master == null && result.State == 0 && OfflineData.Instance.Employee.Can(57, 0))
						{
							result2 = true;
						}
						else
						{
							if (!OfflineData.Instance.Employee.Can(23, 0))
							{
								if (result.CurrentManager != Auth.User.id)
								{
									int? master = result.Master;
									int id = Auth.User.id;
									if (!(master.GetValueOrDefault() == id & master != null))
									{
										result2 = false;
										goto IL_2BD;
									}
								}
							}
							result2 = true;
						}
					}
					catch (Exception ex)
					{
						ILogger log = permissionsController.Log;
						string str = "Load repair for permissions check fail ";
						Exception ex2 = ex;
						log.Error(str + ((ex2 != null) ? ex2.ToString() : null));
						result2 = false;
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_2BD:
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06003DAF RID: 15791 RVA: 0x000F56F0 File Offset: 0x000F38F0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002852 RID: 10322
			public int <>1__state;

			// Token: 0x04002853 RID: 10323
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x04002854 RID: 10324
			public int repairId;

			// Token: 0x04002855 RID: 10325
			public PermissionsController <>4__this;

			// Token: 0x04002856 RID: 10326
			private auseceEntities <ctx>5__2;

			// Token: 0x04002857 RID: 10327
			private TaskAwaiter<WorkshopLite> <>u__1;
		}
	}
}
