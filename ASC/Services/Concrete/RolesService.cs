using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.DAL;
using ASC.Services.Abstract;

namespace ASC.Services.Concrete
{
	// Token: 0x02000794 RID: 1940
	public class RolesService : IRolesService
	{
		// Token: 0x06003BA2 RID: 15266 RVA: 0x000EB1A4 File Offset: 0x000E93A4
		public RolesService(IContextFactory contextFactory)
		{
			this._contextFactory = contextFactory;
		}

		// Token: 0x06003BA3 RID: 15267 RVA: 0x000EB1C0 File Offset: 0x000E93C0
		public Task<IList<roles>> GetRolesAsync()
		{
			RolesService.<GetRolesAsync>d__2 <GetRolesAsync>d__;
			<GetRolesAsync>d__.<>t__builder = AsyncTaskMethodBuilder<IList<roles>>.Create();
			<GetRolesAsync>d__.<>4__this = this;
			<GetRolesAsync>d__.<>1__state = -1;
			<GetRolesAsync>d__.<>t__builder.Start<RolesService.<GetRolesAsync>d__2>(ref <GetRolesAsync>d__);
			return <GetRolesAsync>d__.<>t__builder.Task;
		}

		// Token: 0x040026DC RID: 9948
		private readonly IContextFactory _contextFactory;

		// Token: 0x02000795 RID: 1941
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003BA4 RID: 15268 RVA: 0x000EB204 File Offset: 0x000E9404
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003BA5 RID: 15269 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x040026DD RID: 9949
			public static readonly RolesService.<>c <>9 = new RolesService.<>c();
		}

		// Token: 0x02000796 RID: 1942
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetRolesAsync>d__2 : IAsyncStateMachine
		{
			// Token: 0x06003BA6 RID: 15270 RVA: 0x000EB21C File Offset: 0x000E941C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RolesService rolesService = this.<>4__this;
				IList<roles> result;
				try
				{
					if (num != 0)
					{
						this.<ctx>5__2 = rolesService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<List<roles>> awaiter;
						if (num != 0)
						{
							awaiter = (from i in this.<ctx>5__2.roles.AsNoTracking()
							orderby i.name
							select i).ToListAsync<roles>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<roles>>, RolesService.<GetRolesAsync>d__2>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<roles>>);
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

			// Token: 0x06003BA7 RID: 15271 RVA: 0x000EB360 File Offset: 0x000E9560
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040026DE RID: 9950
			public int <>1__state;

			// Token: 0x040026DF RID: 9951
			public AsyncTaskMethodBuilder<IList<roles>> <>t__builder;

			// Token: 0x040026E0 RID: 9952
			public RolesService <>4__this;

			// Token: 0x040026E1 RID: 9953
			private auseceEntities <ctx>5__2;

			// Token: 0x040026E2 RID: 9954
			private TaskAwaiter<List<roles>> <>u__1;
		}
	}
}
