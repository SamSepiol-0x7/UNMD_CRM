using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Interfaces;

namespace ASC.Services
{
	// Token: 0x02000690 RID: 1680
	public class PaymentSystemService : IPaymentSystemService
	{
		// Token: 0x060038C5 RID: 14533 RVA: 0x000CF974 File Offset: 0x000CDB74
		public Task<List<payment_systems>> GetPaymentSystems()
		{
			PaymentSystemService.<GetPaymentSystems>d__0 <GetPaymentSystems>d__;
			<GetPaymentSystems>d__.<>t__builder = AsyncTaskMethodBuilder<List<payment_systems>>.Create();
			<GetPaymentSystems>d__.<>1__state = -1;
			<GetPaymentSystems>d__.<>t__builder.Start<PaymentSystemService.<GetPaymentSystems>d__0>(ref <GetPaymentSystems>d__);
			return <GetPaymentSystems>d__.<>t__builder.Task;
		}

		// Token: 0x060038C6 RID: 14534 RVA: 0x000046B4 File Offset: 0x000028B4
		public PaymentSystemService()
		{
		}

		// Token: 0x02000691 RID: 1681
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060038C7 RID: 14535 RVA: 0x000CF9B0 File Offset: 0x000CDBB0
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060038C8 RID: 14536 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x040022B4 RID: 8884
			public static readonly PaymentSystemService.<>c <>9 = new PaymentSystemService.<>c();
		}

		// Token: 0x02000692 RID: 1682
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetPaymentSystems>d__0 : IAsyncStateMachine
		{
			// Token: 0x060038C9 RID: 14537 RVA: 0x000CF9C8 File Offset: 0x000CDBC8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<payment_systems> result;
				try
				{
					if (num != 0)
					{
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						ConfiguredTaskAwaitable<List<payment_systems>>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = (from s in this.<ctx>5__2.payment_systems
							where s.is_enable
							select s).ToListAsync<payment_systems>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<List<payment_systems>>.ConfiguredTaskAwaiter, PaymentSystemService.<GetPaymentSystems>d__0>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<List<payment_systems>>.ConfiguredTaskAwaiter);
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

			// Token: 0x060038CA RID: 14538 RVA: 0x000CFB00 File Offset: 0x000CDD00
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040022B5 RID: 8885
			public int <>1__state;

			// Token: 0x040022B6 RID: 8886
			public AsyncTaskMethodBuilder<List<payment_systems>> <>t__builder;

			// Token: 0x040022B7 RID: 8887
			private auseceEntities <ctx>5__2;

			// Token: 0x040022B8 RID: 8888
			private ConfiguredTaskAwaitable<List<payment_systems>>.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
