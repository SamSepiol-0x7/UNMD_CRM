using System;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Objects;

namespace ASC.Services
{
	// Token: 0x020005CD RID: 1485
	public class HookService : IHookService
	{
		// Token: 0x060036FB RID: 14075 RVA: 0x000BC04C File Offset: 0x000BA24C
		public Task<IHook> GetFirstHookByTaskId(int taskId)
		{
			HookService.<GetFirstHookByTaskId>d__0 <GetFirstHookByTaskId>d__;
			<GetFirstHookByTaskId>d__.<>t__builder = AsyncTaskMethodBuilder<IHook>.Create();
			<GetFirstHookByTaskId>d__.taskId = taskId;
			<GetFirstHookByTaskId>d__.<>1__state = -1;
			<GetFirstHookByTaskId>d__.<>t__builder.Start<HookService.<GetFirstHookByTaskId>d__0>(ref <GetFirstHookByTaskId>d__);
			return <GetFirstHookByTaskId>d__.<>t__builder.Task;
		}

		// Token: 0x060036FC RID: 14076 RVA: 0x000046B4 File Offset: 0x000028B4
		public HookService()
		{
		}

		// Token: 0x020005CE RID: 1486
		[CompilerGenerated]
		private sealed class <>c__DisplayClass0_0
		{
			// Token: 0x060036FD RID: 14077 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass0_0()
			{
			}

			// Token: 0x04001FA8 RID: 8104
			public int taskId;
		}

		// Token: 0x020005CF RID: 1487
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060036FE RID: 14078 RVA: 0x000BC090 File Offset: 0x000BA290
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060036FF RID: 14079 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x04001FA9 RID: 8105
			public static readonly HookService.<>c <>9 = new HookService.<>c();
		}

		// Token: 0x020005D0 RID: 1488
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetFirstHookByTaskId>d__0 : IAsyncStateMachine
		{
			// Token: 0x06003700 RID: 14080 RVA: 0x000BC0A8 File Offset: 0x000BA2A8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IHook result;
				try
				{
					HookService.<>c__DisplayClass0_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new HookService.<>c__DisplayClass0_0();
						CS$<>8__locals1.taskId = this.taskId;
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						ConfiguredTaskAwaitable<Hook>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							ParameterExpression parameterExpression;
							awaiter = (from h in this.<ctx>5__2.hooks
							where h.task_id == (int?)CS$<>8__locals1.taskId
							select h).Select(Expression.Lambda<Func<hooks, Hook>>(Expression.MemberInit(Expression.New(typeof(Hook)), new MemberBinding[]
							{
								Expression.Bind(methodof(Hook.set_Id(int)), Expression.Convert(Expression.Property(parameterExpression, methodof(hooks.get_id())), typeof(int))),
								Expression.Bind(methodof(Hook.set_HookId(int)), Expression.Convert(Expression.Property(parameterExpression, methodof(hooks.get_hook_id())), typeof(int))),
								Expression.Bind(methodof(Hook.set_Status(int)), Expression.Convert(Expression.Property(parameterExpression, methodof(hooks.get_status())), typeof(int))),
								Expression.Bind(methodof(Hook.set_CreatedAt(DateTime?)), Expression.Property(parameterExpression, methodof(hooks.get_created_at()))),
								Expression.Bind(methodof(Hook.set_UpdatedAt(DateTime?)), Expression.Property(parameterExpression, methodof(hooks.get_updated_at()))),
								Expression.Bind(methodof(Hook.set_Event(string)), Expression.Property(parameterExpression, methodof(hooks.get_event()))),
								Expression.Bind(methodof(Hook.set_p0(int?)), Expression.Convert(Expression.Property(parameterExpression, methodof(hooks.get_p0())), typeof(int?))),
								Expression.Bind(methodof(Hook.set_Prm(string)), Expression.Property(parameterExpression, methodof(hooks.get_prm()))),
								Expression.Bind(methodof(Hook.set_TaskId(int?)), Expression.Property(parameterExpression, methodof(hooks.get_task_id())))
							}), new ParameterExpression[]
							{
								parameterExpression
							})).FirstOrDefaultAsync<Hook>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<Hook>.ConfiguredTaskAwaiter, HookService.<GetFirstHookByTaskId>d__0>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<Hook>.ConfiguredTaskAwaiter);
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
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06003701 RID: 14081 RVA: 0x000BC458 File Offset: 0x000BA658
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001FAA RID: 8106
			public int <>1__state;

			// Token: 0x04001FAB RID: 8107
			public AsyncTaskMethodBuilder<IHook> <>t__builder;

			// Token: 0x04001FAC RID: 8108
			public int taskId;

			// Token: 0x04001FAD RID: 8109
			private auseceEntities <ctx>5__2;

			// Token: 0x04001FAE RID: 8110
			private ConfiguredTaskAwaitable<Hook>.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
