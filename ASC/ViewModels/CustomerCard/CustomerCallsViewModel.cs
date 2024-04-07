using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Calls;
using ASC.Common.Interfaces;
using ASC.Common.Interfaces.VoIP;
using ASC.Extensions.Mango;
using ASC.Interfaces;
using ASC.Objects;
using Autofac;

namespace ASC.ViewModels.CustomerCard
{
	// Token: 0x020004DA RID: 1242
	public class CustomerCallsViewModel : CallsViewModel
	{
		// Token: 0x06002FAD RID: 12205 RVA: 0x0009CB84 File Offset: 0x0009AD84
		public CustomerCallsViewModel()
		{
			this._customerService = Bootstrapper.Container.Resolve<ICustomerService>();
		}

		// Token: 0x06002FAE RID: 12206 RVA: 0x0009CBA8 File Offset: 0x0009ADA8
		public CustomerCallsViewModel(int customerId) : this()
		{
			this._customerId = customerId;
			base.Period.From = DateTime.Now.AddDays(-14.0);
			this.BgInit();
		}

		// Token: 0x06002FAF RID: 12207 RVA: 0x0009CBEC File Offset: 0x0009ADEC
		public override void OnLoad()
		{
			base.OnViewLoaded();
			base.SetViewLoaded(true);
			this.BgInit();
		}

		// Token: 0x06002FB0 RID: 12208 RVA: 0x0009CC0C File Offset: 0x0009AE0C
		public sealed override void BgInit()
		{
			CustomerCallsViewModel.<BgInit>d__5 <BgInit>d__;
			<BgInit>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<BgInit>d__.<>4__this = this;
			<BgInit>d__.<>1__state = -1;
			<BgInit>d__.<>t__builder.Start<CustomerCallsViewModel.<BgInit>d__5>(ref <BgInit>d__);
		}

		// Token: 0x06002FB1 RID: 12209 RVA: 0x00065CC0 File Offset: 0x00063EC0
		[CompilerGenerated]
		private Task<IEnumerable<IAscCDR>> <BgInit>b__5_2()
		{
			return Core.Instance.VoIP.GetCdr(base.Period, (CallType)base.SelectedType);
		}

		// Token: 0x06002FB2 RID: 12210 RVA: 0x0009CC44 File Offset: 0x0009AE44
		[CompilerGenerated]
		private bool <BgInit>b__5_1(IAscCDR i)
		{
			return i.Customer != null && i.Customer.Id == this._customerId;
		}

		// Token: 0x04001B04 RID: 6916
		private readonly int _customerId;

		// Token: 0x04001B05 RID: 6917
		private readonly ICustomerService _customerService;

		// Token: 0x020004DB RID: 1243
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002FB3 RID: 12211 RVA: 0x0009CC70 File Offset: 0x0009AE70
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06002FB4 RID: 12212 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06002FB5 RID: 12213 RVA: 0x00065E80 File Offset: 0x00064080
			internal bool <BgInit>b__5_0(Employee i)
			{
				return i.Tel != null;
			}

			// Token: 0x04001B06 RID: 6918
			public static readonly CustomerCallsViewModel.<>c <>9 = new CustomerCallsViewModel.<>c();

			// Token: 0x04001B07 RID: 6919
			public static Func<Employee, bool> <>9__5_0;
		}

		// Token: 0x020004DC RID: 1244
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <BgInit>d__5 : IAsyncStateMachine
		{
			// Token: 0x06002FB6 RID: 12214 RVA: 0x0009CC88 File Offset: 0x0009AE88
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CustomerCallsViewModel customerCallsViewModel = this.<>4__this;
				try
				{
					if (num > 3)
					{
						if (!customerCallsViewModel.ViewLoaded)
						{
							goto IL_39E;
						}
						customerCallsViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter<List<clients>> awaiter;
						TaskAwaiter<List<tel>> awaiter2;
						TaskAwaiter<IEnumerable<IAscCDR>> awaiter3;
						switch (num)
						{
						case 0:
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<clients>>);
							int num2 = -1;
							num = -1;
							this.<>1__state = num2;
							break;
						}
						case 1:
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<List<tel>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
							goto IL_1B8;
						}
						case 2:
							IL_1CE:
							try
							{
								if (num == 2)
								{
									awaiter3 = this.<>u__3;
									this.<>u__3 = default(TaskAwaiter<IEnumerable<IAscCDR>>);
									int num4 = -1;
									num = -1;
									this.<>1__state = num4;
									goto IL_23C;
								}
								IL_1F4:
								if (!this.<>7__wrap5.MoveNext())
								{
									goto IL_290;
								}
								tel tel = this.<>7__wrap5.Current;
								awaiter3 = this.<mango>5__5.GetCdr(customerCallsViewModel.Period, (CallType)customerCallsViewModel.SelectedType, tel.phone_clean).GetAwaiter();
								if (!awaiter3.IsCompleted)
								{
									int num5 = 2;
									num = 2;
									this.<>1__state = num5;
									this.<>u__3 = awaiter3;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<IAscCDR>>, CustomerCallsViewModel.<BgInit>d__5>(ref awaiter3, ref this);
									return;
								}
								IL_23C:
								IEnumerable<IAscCDR> result = awaiter3.GetResult();
								this.<items>5__2.AddRange(result);
								goto IL_1F4;
							}
							finally
							{
								if (num < 0)
								{
									((IDisposable)this.<>7__wrap5).Dispose();
								}
							}
							IL_290:
							this.<>7__wrap5 = default(List<tel>.Enumerator);
							goto IL_2D1;
						case 3:
						{
							awaiter3 = this.<>u__3;
							this.<>u__3 = default(TaskAwaiter<IEnumerable<IAscCDR>>);
							int num6 = -1;
							num = -1;
							this.<>1__state = num6;
							goto IL_2BB;
						}
						default:
							this.<items>5__2 = new List<IAscCDR>();
							awaiter = customerCallsViewModel._customerService.GetCustomersAsync().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num7 = 0;
								num = 0;
								this.<>1__state = num7;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<clients>>, CustomerCallsViewModel.<BgInit>d__5>(ref awaiter, ref this);
								return;
							}
							break;
						}
						List<clients> result2 = awaiter.GetResult();
						this.<customers>5__3 = result2;
						this.<employees>5__4 = OfflineData.Instance.ActiveUsers.Where(new Func<Employee, bool>(CustomerCallsViewModel.<>c.<>9.<BgInit>b__5_0)).ToList<Employee>();
						IVoIP voIP = Core.Instance.VoIP;
						this.<mango>5__5 = (voIP as MangoOffice);
						if (this.<mango>5__5 != null)
						{
							awaiter2 = customerCallsViewModel._customerService.GetPhonesAsync(customerCallsViewModel._customerId).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num8 = 1;
								num = 1;
								this.<>1__state = num8;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<tel>>, CustomerCallsViewModel.<BgInit>d__5>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter3 = Task.Run<IEnumerable<IAscCDR>>(() => Core.Instance.VoIP.GetCdr(base.Period, (CallType)base.SelectedType)).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								int num9 = 3;
								num = 3;
								this.<>1__state = num9;
								this.<>u__3 = awaiter3;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<IAscCDR>>, CustomerCallsViewModel.<BgInit>d__5>(ref awaiter3, ref this);
								return;
							}
							goto IL_2BB;
						}
						IL_1B8:
						List<tel> result3 = awaiter2.GetResult();
						this.<>7__wrap5 = result3.GetEnumerator();
						goto IL_1CE;
						IL_2BB:
						IEnumerable<IAscCDR> result4 = awaiter3.GetResult();
						this.<items>5__2.AddRange(result4);
						IL_2D1:
						List<IAscCDR>.Enumerator enumerator = this.<items>5__2.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								IAscCDR ascCDR = enumerator.Current;
								((AscCDR)ascCDR).TryIdentityCustomer(this.<customers>5__3);
								((AscCDR)ascCDR).TryIdentityEmployee(this.<employees>5__4);
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)enumerator).Dispose();
							}
						}
						customerCallsViewModel.SetItems(from i in this.<items>5__2
						where i.Customer != null && i.Customer.Id == customerCallsViewModel._customerId
						select i);
						this.<items>5__2 = null;
						this.<customers>5__3 = null;
						this.<employees>5__4 = null;
						this.<mango>5__5 = null;
					}
					catch (Exception ex)
					{
						customerCallsViewModel.HideWait();
						customerCallsViewModel._toasterService.Error(ex.Message);
						goto IL_39E;
					}
					customerCallsViewModel.HideWait();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_39E:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002FB7 RID: 12215 RVA: 0x0009D0AC File Offset: 0x0009B2AC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001B08 RID: 6920
			public int <>1__state;

			// Token: 0x04001B09 RID: 6921
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001B0A RID: 6922
			public CustomerCallsViewModel <>4__this;

			// Token: 0x04001B0B RID: 6923
			private List<IAscCDR> <items>5__2;

			// Token: 0x04001B0C RID: 6924
			private List<clients> <customers>5__3;

			// Token: 0x04001B0D RID: 6925
			private List<Employee> <employees>5__4;

			// Token: 0x04001B0E RID: 6926
			private MangoOffice <mango>5__5;

			// Token: 0x04001B0F RID: 6927
			private TaskAwaiter<List<clients>> <>u__1;

			// Token: 0x04001B10 RID: 6928
			private TaskAwaiter<List<tel>> <>u__2;

			// Token: 0x04001B11 RID: 6929
			private List<tel>.Enumerator <>7__wrap5;

			// Token: 0x04001B12 RID: 6930
			private TaskAwaiter<IEnumerable<IAscCDR>> <>u__3;
		}
	}
}
