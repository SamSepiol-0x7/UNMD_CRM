using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Phone;
using ASC.Objects.Converters;
using ASC.Services.Abstract;
using ASC.SimpleClasses;

namespace ASC.Services.Concrete
{
	// Token: 0x020007B1 RID: 1969
	public class TelService : ITelService
	{
		// Token: 0x06003BF6 RID: 15350 RVA: 0x000EE510 File Offset: 0x000EC710
		public TelService(ILoggerService<TelService> loggerService)
		{
			this._loggerService = loggerService;
		}

		// Token: 0x06003BF7 RID: 15351 RVA: 0x000EE52C File Offset: 0x000EC72C
		public Task<int> CreateTel(int customerId, Tel tel)
		{
			TelService.<CreateTel>d__2 <CreateTel>d__;
			<CreateTel>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<CreateTel>d__.<>4__this = this;
			<CreateTel>d__.customerId = customerId;
			<CreateTel>d__.tel = tel;
			<CreateTel>d__.<>1__state = -1;
			<CreateTel>d__.<>t__builder.Start<TelService.<CreateTel>d__2>(ref <CreateTel>d__);
			return <CreateTel>d__.<>t__builder.Task;
		}

		// Token: 0x06003BF8 RID: 15352 RVA: 0x000EE580 File Offset: 0x000EC780
		public Task UpdateTel(int customerId, Tel tel)
		{
			TelService.<UpdateTel>d__3 <UpdateTel>d__;
			<UpdateTel>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<UpdateTel>d__.customerId = customerId;
			<UpdateTel>d__.tel = tel;
			<UpdateTel>d__.<>1__state = -1;
			<UpdateTel>d__.<>t__builder.Start<TelService.<UpdateTel>d__3>(ref <UpdateTel>d__);
			return <UpdateTel>d__.<>t__builder.Task;
		}

		// Token: 0x06003BF9 RID: 15353 RVA: 0x000EE5CC File Offset: 0x000EC7CC
		public Task DeleteTel(int customerId, int telId)
		{
			TelService.<DeleteTel>d__4 <DeleteTel>d__;
			<DeleteTel>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<DeleteTel>d__.customerId = customerId;
			<DeleteTel>d__.telId = telId;
			<DeleteTel>d__.<>1__state = -1;
			<DeleteTel>d__.<>t__builder.Start<TelService.<DeleteTel>d__4>(ref <DeleteTel>d__);
			return <DeleteTel>d__.<>t__builder.Task;
		}

		// Token: 0x04002749 RID: 10057
		private readonly ILoggerService<TelService> _loggerService;

		// Token: 0x020007B2 RID: 1970
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x06003BFA RID: 15354 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x0400274A RID: 10058
			public int customerId;
		}

		// Token: 0x020007B3 RID: 1971
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003BFB RID: 15355 RVA: 0x000EE618 File Offset: 0x000EC818
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003BFC RID: 15356 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06003BFD RID: 15357 RVA: 0x000EE630 File Offset: 0x000EC830
			internal void <CreateTel>b__2_0(tel t)
			{
				t.type = 0;
			}

			// Token: 0x06003BFE RID: 15358 RVA: 0x000EE630 File Offset: 0x000EC830
			internal void <UpdateTel>b__3_1(tel t)
			{
				t.type = 0;
			}

			// Token: 0x0400274B RID: 10059
			public static readonly TelService.<>c <>9 = new TelService.<>c();

			// Token: 0x0400274C RID: 10060
			public static Action<tel> <>9__2_0;

			// Token: 0x0400274D RID: 10061
			public static Action<tel> <>9__3_1;
		}

		// Token: 0x020007B4 RID: 1972
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateTel>d__2 : IAsyncStateMachine
		{
			// Token: 0x06003BFF RID: 15359 RVA: 0x000EE644 File Offset: 0x000EC844
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				TelService telService = this.<>4__this;
				int result2;
				try
				{
					if (num > 2)
					{
						this.<>8__1 = new TelService.<>c__DisplayClass2_0();
						this.<>8__1.customerId = this.customerId;
					}
					try
					{
						if (num > 2)
						{
							this.<history>5__2 = new HistoryV2();
							this.<ctx>5__3 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<List<tel>> awaiter;
							TaskAwaiter<int> awaiter2;
							TaskAwaiter awaiter3;
							switch (num)
							{
							case 0:
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<List<tel>>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								break;
							}
							case 1:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<int>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
								goto IL_21D;
							}
							case 2:
							{
								awaiter3 = this.<>u__3;
								this.<>u__3 = default(TaskAwaiter);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
								goto IL_2A2;
							}
							default:
								awaiter = (from t in this.<ctx>5__3.tel
								where t.customer == (int?)this.<>8__1.customerId
								select t).ToListAsync<tel>().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num5 = 0;
									num = 0;
									this.<>1__state = num5;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<tel>>, TelService.<CreateTel>d__2>(ref awaiter, ref this);
									return;
								}
								break;
							}
							List<tel> result = awaiter.GetResult();
							this.<n>5__4 = this.tel.ConvertBack(this.<>8__1.customerId);
							if (!result.Any<tel>())
							{
								this.<n>5__4.type = 1;
							}
							if (this.<n>5__4.type == 1 && result.Any<tel>())
							{
								result.ForEach(new Action<tel>(TelService.<>c.<>9.<CreateTel>b__2_0));
							}
							this.<ctx>5__3.tel.Add(this.<n>5__4);
							awaiter2 = this.<ctx>5__3.SaveChangesAsync().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num6 = 1;
								num = 1;
								this.<>1__state = num6;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, TelService.<CreateTel>d__2>(ref awaiter2, ref this);
								return;
							}
							IL_21D:
							awaiter2.GetResult();
							this.<history>5__2.AddClientCardLog("TelCreated", this.<>8__1.customerId, this.tel);
							awaiter3 = this.<history>5__2.SaveAsync().GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								int num7 = 2;
								num = 2;
								this.<>1__state = num7;
								this.<>u__3 = awaiter3;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, TelService.<CreateTel>d__2>(ref awaiter3, ref this);
								return;
							}
							IL_2A2:
							awaiter3.GetResult();
							result2 = this.<n>5__4.id;
						}
						finally
						{
							if (num < 0 && this.<ctx>5__3 != null)
							{
								((IDisposable)this.<ctx>5__3).Dispose();
							}
						}
					}
					catch (Exception ex)
					{
						telService._loggerService.Error(ex, ex.Message);
						result2 = -1;
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06003C00 RID: 15360 RVA: 0x000EE9C4 File Offset: 0x000ECBC4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400274E RID: 10062
			public int <>1__state;

			// Token: 0x0400274F RID: 10063
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x04002750 RID: 10064
			public int customerId;

			// Token: 0x04002751 RID: 10065
			public Tel tel;

			// Token: 0x04002752 RID: 10066
			private TelService.<>c__DisplayClass2_0 <>8__1;

			// Token: 0x04002753 RID: 10067
			public TelService <>4__this;

			// Token: 0x04002754 RID: 10068
			private HistoryV2 <history>5__2;

			// Token: 0x04002755 RID: 10069
			private auseceEntities <ctx>5__3;

			// Token: 0x04002756 RID: 10070
			private tel <n>5__4;

			// Token: 0x04002757 RID: 10071
			private TaskAwaiter<List<tel>> <>u__1;

			// Token: 0x04002758 RID: 10072
			private TaskAwaiter<int> <>u__2;

			// Token: 0x04002759 RID: 10073
			private TaskAwaiter <>u__3;
		}

		// Token: 0x020007B5 RID: 1973
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06003C01 RID: 15361 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x0400275A RID: 10074
			public Tel tel;

			// Token: 0x0400275B RID: 10075
			public int customerId;
		}

		// Token: 0x020007B6 RID: 1974
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateTel>d__3 : IAsyncStateMachine
		{
			// Token: 0x06003C02 RID: 15362 RVA: 0x000EE9E0 File Offset: 0x000ECBE0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					if (num > 3)
					{
						this.<>8__1 = new TelService.<>c__DisplayClass3_0();
						this.<>8__1.tel = this.tel;
						this.<>8__1.customerId = this.customerId;
						this.<history>5__2 = new HistoryV2();
						this.<ctx>5__3 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<tel> awaiter;
						TaskAwaiter<List<tel>> awaiter2;
						TaskAwaiter<int> awaiter3;
						TaskAwaiter awaiter4;
						switch (num)
						{
						case 0:
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<tel>);
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
							goto IL_26B;
						}
						case 2:
						{
							awaiter3 = this.<>u__3;
							this.<>u__3 = default(TaskAwaiter<int>);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
							goto IL_399;
						}
						case 3:
						{
							awaiter4 = this.<>u__4;
							this.<>u__4 = default(TaskAwaiter);
							int num5 = -1;
							num = -1;
							this.<>1__state = num5;
							goto IL_3FD;
						}
						default:
							awaiter = this.<ctx>5__3.tel.FirstOrDefaultAsync((tel t) => t.id == this.<>8__1.tel.Id).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num6 = 0;
								num = 0;
								this.<>1__state = num6;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<tel>, TelService.<UpdateTel>d__3>(ref awaiter, ref this);
								return;
							}
							break;
						}
						tel result = awaiter.GetResult();
						this.<original>5__4 = result;
						this.<history>5__2.AddClientCardLog("PhoneChanged", this.<>8__1.customerId, this.<original>5__4.phone, this.<>8__1.tel.Phone);
						if (!this.<>8__1.tel.IsMain)
						{
							goto IL_296;
						}
						awaiter2 = (from t in this.<ctx>5__3.tel
						where t.customer == (int?)this.<>8__1.customerId
						select t).ToListAsync<tel>().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num7 = 1;
							num = 1;
							this.<>1__state = num7;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<tel>>, TelService.<UpdateTel>d__3>(ref awaiter2, ref this);
							return;
						}
						IL_26B:
						awaiter2.GetResult().ForEach(new Action<tel>(TelService.<>c.<>9.<UpdateTel>b__3_1));
						IL_296:
						this.<original>5__4.phone = this.<>8__1.tel.Phone;
						this.<original>5__4.phone_clean = Phone.ClearPhoneString(this.<>8__1.tel.Phone);
						this.<original>5__4.mask = this.<>8__1.tel.Mask;
						this.<original>5__4.type = this.<>8__1.tel.Type;
						this.<original>5__4.note = this.<>8__1.tel.Note;
						this.<original>5__4.notify = this.<>8__1.tel.Notify;
						awaiter3 = this.<ctx>5__3.SaveChangesAsync().GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							int num8 = 2;
							num = 2;
							this.<>1__state = num8;
							this.<>u__3 = awaiter3;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, TelService.<UpdateTel>d__3>(ref awaiter3, ref this);
							return;
						}
						IL_399:
						awaiter3.GetResult();
						awaiter4 = this.<history>5__2.SaveAsync().GetAwaiter();
						if (!awaiter4.IsCompleted)
						{
							int num9 = 3;
							num = 3;
							this.<>1__state = num9;
							this.<>u__4 = awaiter4;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, TelService.<UpdateTel>d__3>(ref awaiter4, ref this);
							return;
						}
						IL_3FD:
						awaiter4.GetResult();
						this.<original>5__4 = null;
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
					this.<>8__1 = null;
					this.<history>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<history>5__2 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003C03 RID: 15363 RVA: 0x000EEE98 File Offset: 0x000ED098
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400275C RID: 10076
			public int <>1__state;

			// Token: 0x0400275D RID: 10077
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400275E RID: 10078
			public Tel tel;

			// Token: 0x0400275F RID: 10079
			public int customerId;

			// Token: 0x04002760 RID: 10080
			private TelService.<>c__DisplayClass3_0 <>8__1;

			// Token: 0x04002761 RID: 10081
			private HistoryV2 <history>5__2;

			// Token: 0x04002762 RID: 10082
			private auseceEntities <ctx>5__3;

			// Token: 0x04002763 RID: 10083
			private tel <original>5__4;

			// Token: 0x04002764 RID: 10084
			private TaskAwaiter<tel> <>u__1;

			// Token: 0x04002765 RID: 10085
			private TaskAwaiter<List<tel>> <>u__2;

			// Token: 0x04002766 RID: 10086
			private TaskAwaiter<int> <>u__3;

			// Token: 0x04002767 RID: 10087
			private TaskAwaiter <>u__4;
		}

		// Token: 0x020007B7 RID: 1975
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x06003C04 RID: 15364 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x04002768 RID: 10088
			public int customerId;
		}

		// Token: 0x020007B8 RID: 1976
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <DeleteTel>d__4 : IAsyncStateMachine
		{
			// Token: 0x06003C05 RID: 15365 RVA: 0x000EEEB4 File Offset: 0x000ED0B4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					if (num > 4)
					{
						this.<>8__1 = new TelService.<>c__DisplayClass4_0();
						this.<>8__1.customerId = this.customerId;
						this.<history>5__2 = new HistoryV2();
						this.<ctx>5__3 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<tel> awaiter;
						TaskAwaiter<int> awaiter2;
						TaskAwaiter awaiter3;
						switch (num)
						{
						case 0:
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<tel>);
							int num2 = -1;
							num = -1;
							this.<>1__state = num2;
							break;
						}
						case 1:
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<int>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
							goto IL_14D;
						}
						case 2:
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<tel>);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
							goto IL_227;
						}
						case 3:
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<int>);
							int num5 = -1;
							num = -1;
							this.<>1__state = num5;
							goto IL_295;
						}
						case 4:
						{
							awaiter3 = this.<>u__3;
							this.<>u__3 = default(TaskAwaiter);
							int num6 = -1;
							num = -1;
							this.<>1__state = num6;
							goto IL_31F;
						}
						default:
							awaiter = this.<ctx>5__3.tel.FindAsync(new object[]
							{
								this.telId
							}).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num7 = 0;
								num = 0;
								this.<>1__state = num7;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<tel>, TelService.<DeleteTel>d__4>(ref awaiter, ref this);
								return;
							}
							break;
						}
						tel result = awaiter.GetResult();
						this.<phone>5__4 = result;
						this.<ctx>5__3.tel.Remove(this.<phone>5__4);
						awaiter2 = this.<ctx>5__3.SaveChangesAsync().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num8 = 1;
							num = 1;
							this.<>1__state = num8;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, TelService.<DeleteTel>d__4>(ref awaiter2, ref this);
							return;
						}
						IL_14D:
						awaiter2.GetResult();
						awaiter = this.<ctx>5__3.tel.FirstOrDefaultAsync((tel t) => t.customer == (int?)this.<>8__1.customerId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num9 = 2;
							num = 2;
							this.<>1__state = num9;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<tel>, TelService.<DeleteTel>d__4>(ref awaiter, ref this);
							return;
						}
						IL_227:
						tel result2 = awaiter.GetResult();
						if (result2 == null)
						{
							goto IL_29D;
						}
						result2.type = 1;
						awaiter2 = this.<ctx>5__3.SaveChangesAsync().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num10 = 3;
							num = 3;
							this.<>1__state = num10;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, TelService.<DeleteTel>d__4>(ref awaiter2, ref this);
							return;
						}
						IL_295:
						awaiter2.GetResult();
						IL_29D:
						this.<history>5__2.AddClientCardLog("TelDeleted", this.<>8__1.customerId, this.<phone>5__4.ToTel());
						awaiter3 = this.<history>5__2.SaveAsync().GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							int num11 = 4;
							num = 4;
							this.<>1__state = num11;
							this.<>u__3 = awaiter3;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, TelService.<DeleteTel>d__4>(ref awaiter3, ref this);
							return;
						}
						IL_31F:
						awaiter3.GetResult();
						this.<phone>5__4 = null;
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
					this.<>8__1 = null;
					this.<history>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<history>5__2 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003C06 RID: 15366 RVA: 0x000EF290 File Offset: 0x000ED490
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002769 RID: 10089
			public int <>1__state;

			// Token: 0x0400276A RID: 10090
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400276B RID: 10091
			public int customerId;

			// Token: 0x0400276C RID: 10092
			public int telId;

			// Token: 0x0400276D RID: 10093
			private TelService.<>c__DisplayClass4_0 <>8__1;

			// Token: 0x0400276E RID: 10094
			private HistoryV2 <history>5__2;

			// Token: 0x0400276F RID: 10095
			private auseceEntities <ctx>5__3;

			// Token: 0x04002770 RID: 10096
			private tel <phone>5__4;

			// Token: 0x04002771 RID: 10097
			private TaskAwaiter<tel> <>u__1;

			// Token: 0x04002772 RID: 10098
			private TaskAwaiter<int> <>u__2;

			// Token: 0x04002773 RID: 10099
			private TaskAwaiter <>u__3;
		}
	}
}
