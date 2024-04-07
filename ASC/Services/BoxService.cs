using System;
using System.Data.Entity;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Objects.Converters;

namespace ASC.Services
{
	// Token: 0x020005C2 RID: 1474
	public class BoxService : IBoxService
	{
		// Token: 0x060036E6 RID: 14054 RVA: 0x000BB89C File Offset: 0x000B9A9C
		public Task<boxes> GetBoxAsync(int boxId)
		{
			BoxService.<GetBoxAsync>d__0 <GetBoxAsync>d__;
			<GetBoxAsync>d__.<>t__builder = AsyncTaskMethodBuilder<boxes>.Create();
			<GetBoxAsync>d__.boxId = boxId;
			<GetBoxAsync>d__.<>1__state = -1;
			<GetBoxAsync>d__.<>t__builder.Start<BoxService.<GetBoxAsync>d__0>(ref <GetBoxAsync>d__);
			return <GetBoxAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060036E7 RID: 14055 RVA: 0x000BB8E0 File Offset: 0x000B9AE0
		public Task<int> CreateBoxAsync(IStoreBox box)
		{
			BoxService.<CreateBoxAsync>d__1 <CreateBoxAsync>d__;
			<CreateBoxAsync>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<CreateBoxAsync>d__.box = box;
			<CreateBoxAsync>d__.<>1__state = -1;
			<CreateBoxAsync>d__.<>t__builder.Start<BoxService.<CreateBoxAsync>d__1>(ref <CreateBoxAsync>d__);
			return <CreateBoxAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060036E8 RID: 14056 RVA: 0x000046B4 File Offset: 0x000028B4
		public BoxService()
		{
		}

		// Token: 0x020005C3 RID: 1475
		[CompilerGenerated]
		private sealed class <>c__DisplayClass0_0
		{
			// Token: 0x060036E9 RID: 14057 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass0_0()
			{
			}

			// Token: 0x04001F91 RID: 8081
			public int boxId;
		}

		// Token: 0x020005C4 RID: 1476
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetBoxAsync>d__0 : IAsyncStateMachine
		{
			// Token: 0x060036EA RID: 14058 RVA: 0x000BB924 File Offset: 0x000B9B24
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				boxes result;
				try
				{
					BoxService.<>c__DisplayClass0_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new BoxService.<>c__DisplayClass0_0();
						CS$<>8__locals1.boxId = this.boxId;
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						ConfiguredTaskAwaitable<boxes>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = this.<ctx>5__2.boxes.AsNoTracking().FirstOrDefaultAsync((boxes i) => i.id == CS$<>8__locals1.boxId).ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<boxes>.ConfiguredTaskAwaiter, BoxService.<GetBoxAsync>d__0>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<boxes>.ConfiguredTaskAwaiter);
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

			// Token: 0x060036EB RID: 14059 RVA: 0x000BBAB0 File Offset: 0x000B9CB0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001F92 RID: 8082
			public int <>1__state;

			// Token: 0x04001F93 RID: 8083
			public AsyncTaskMethodBuilder<boxes> <>t__builder;

			// Token: 0x04001F94 RID: 8084
			public int boxId;

			// Token: 0x04001F95 RID: 8085
			private auseceEntities <ctx>5__2;

			// Token: 0x04001F96 RID: 8086
			private ConfiguredTaskAwaitable<boxes>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x020005C5 RID: 1477
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateBoxAsync>d__1 : IAsyncStateMachine
		{
			// Token: 0x060036EC RID: 14060 RVA: 0x000BBACC File Offset: 0x000B9CCC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				int id;
				try
				{
					if (num != 0)
					{
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							this.<b>5__3 = this.box.BackToBoxes();
							this.<ctx>5__2.boxes.Add(this.<b>5__3);
							awaiter = this.<ctx>5__2.SaveChangesAsync().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter, BoxService.<CreateBoxAsync>d__1>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						awaiter.GetResult();
						id = this.<b>5__3.id;
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
				this.<>t__builder.SetResult(id);
			}

			// Token: 0x060036ED RID: 14061 RVA: 0x000BBBF4 File Offset: 0x000B9DF4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001F97 RID: 8087
			public int <>1__state;

			// Token: 0x04001F98 RID: 8088
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x04001F99 RID: 8089
			public IStoreBox box;

			// Token: 0x04001F9A RID: 8090
			private auseceEntities <ctx>5__2;

			// Token: 0x04001F9B RID: 8091
			private boxes <b>5__3;

			// Token: 0x04001F9C RID: 8092
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
