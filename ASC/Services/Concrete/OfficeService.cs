using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Common.Objects;
using ASC.DAL;
using ASC.Services.Abstract;

namespace ASC.Services.Concrete
{
	// Token: 0x0200074B RID: 1867
	public class OfficeService : IOfficeService
	{
		// Token: 0x06003AF3 RID: 15091 RVA: 0x000E2ECC File Offset: 0x000E10CC
		public OfficeService(IHistoryV2 history, IContextFactory contextFactory)
		{
			this._history = history;
			this._contextFactory = contextFactory;
		}

		// Token: 0x06003AF4 RID: 15092 RVA: 0x000E2EF0 File Offset: 0x000E10F0
		public Task<int> CreateOfficeAsync(offices office)
		{
			OfficeService.<CreateOfficeAsync>d__3 <CreateOfficeAsync>d__;
			<CreateOfficeAsync>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<CreateOfficeAsync>d__.<>4__this = this;
			<CreateOfficeAsync>d__.office = office;
			<CreateOfficeAsync>d__.<>1__state = -1;
			<CreateOfficeAsync>d__.<>t__builder.Start<OfficeService.<CreateOfficeAsync>d__3>(ref <CreateOfficeAsync>d__);
			return <CreateOfficeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06003AF5 RID: 15093 RVA: 0x000E2F3C File Offset: 0x000E113C
		public string CheckFields(offices office)
		{
			if (string.IsNullOrEmpty(office.name))
			{
				goto IL_66;
			}
			goto IL_DC;
			int num;
			for (;;)
			{
				IL_91:
				switch ((num ^ -550101417) % 11)
				{
				case 0:
					num = ((!string.IsNullOrEmpty(office.phone)) ? -195608266 : -1422673452);
					continue;
				case 2:
					goto IL_DC;
				case 3:
					goto IL_EF;
				case 4:
					goto IL_F5;
				case 5:
					goto IL_66;
				case 6:
					goto IL_FB;
				case 7:
					num = ((office.default_company == 0) ? -1042219636 : -1172275062);
					continue;
				case 8:
					goto IL_101;
				case 9:
					num = (string.IsNullOrEmpty(office.address) ? -351124429 : -47372189);
					continue;
				case 10:
					goto IL_107;
				}
				break;
			}
			return string.Empty;
			IL_EF:
			return "InputOfficePhone";
			IL_F5:
			return "InputOfficeChief";
			IL_FB:
			return "InputDefaultFirm";
			IL_101:
			return "InputOfficeAddress";
			IL_107:
			return "InputOfficeName";
			IL_66:
			num = -491999576;
			goto IL_91;
			IL_DC:
			num = ((office.administrator != 0) ? -1445403894 : -1396518715);
			goto IL_91;
		}

		// Token: 0x06003AF6 RID: 15094 RVA: 0x000E3058 File Offset: 0x000E1258
		public Task<offices> GetOfficeAsync(int officeId)
		{
			OfficeService.<GetOfficeAsync>d__5 <GetOfficeAsync>d__;
			<GetOfficeAsync>d__.<>t__builder = AsyncTaskMethodBuilder<offices>.Create();
			<GetOfficeAsync>d__.officeId = officeId;
			<GetOfficeAsync>d__.<>1__state = -1;
			<GetOfficeAsync>d__.<>t__builder.Start<OfficeService.<GetOfficeAsync>d__5>(ref <GetOfficeAsync>d__);
			return <GetOfficeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06003AF7 RID: 15095 RVA: 0x000E309C File Offset: 0x000E129C
		public Task UpdateOfficeAsync(offices office)
		{
			OfficeService.<UpdateOfficeAsync>d__6 <UpdateOfficeAsync>d__;
			<UpdateOfficeAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<UpdateOfficeAsync>d__.<>4__this = this;
			<UpdateOfficeAsync>d__.office = office;
			<UpdateOfficeAsync>d__.<>1__state = -1;
			<UpdateOfficeAsync>d__.<>t__builder.Start<OfficeService.<UpdateOfficeAsync>d__6>(ref <UpdateOfficeAsync>d__);
			return <UpdateOfficeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06003AF8 RID: 15096 RVA: 0x000E30E8 File Offset: 0x000E12E8
		public Task<IEnumerable<IOfficeLookup>> GetOfficesLookupAsync()
		{
			OfficeService.<GetOfficesLookupAsync>d__7 <GetOfficesLookupAsync>d__;
			<GetOfficesLookupAsync>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<IOfficeLookup>>.Create();
			<GetOfficesLookupAsync>d__.<>1__state = -1;
			<GetOfficesLookupAsync>d__.<>t__builder.Start<OfficeService.<GetOfficesLookupAsync>d__7>(ref <GetOfficesLookupAsync>d__);
			return <GetOfficesLookupAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06003AF9 RID: 15097 RVA: 0x000E3124 File Offset: 0x000E1324
		public Task<List<offices>> GetOfficesAsync()
		{
			OfficeService.<GetOfficesAsync>d__8 <GetOfficesAsync>d__;
			<GetOfficesAsync>d__.<>t__builder = AsyncTaskMethodBuilder<List<offices>>.Create();
			<GetOfficesAsync>d__.<>1__state = -1;
			<GetOfficesAsync>d__.<>t__builder.Start<OfficeService.<GetOfficesAsync>d__8>(ref <GetOfficesAsync>d__);
			return <GetOfficesAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06003AFA RID: 15098 RVA: 0x000E3160 File Offset: 0x000E1360
		public Task<int> CountActiveOfficesAsync()
		{
			OfficeService.<CountActiveOfficesAsync>d__9 <CountActiveOfficesAsync>d__;
			<CountActiveOfficesAsync>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<CountActiveOfficesAsync>d__.<>4__this = this;
			<CountActiveOfficesAsync>d__.<>1__state = -1;
			<CountActiveOfficesAsync>d__.<>t__builder.Start<OfficeService.<CountActiveOfficesAsync>d__9>(ref <CountActiveOfficesAsync>d__);
			return <CountActiveOfficesAsync>d__.<>t__builder.Task;
		}

		// Token: 0x040025C1 RID: 9665
		private readonly IHistoryV2 _history;

		// Token: 0x040025C2 RID: 9666
		private readonly IContextFactory _contextFactory;

		// Token: 0x0200074C RID: 1868
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateOfficeAsync>d__3 : IAsyncStateMachine
		{
			// Token: 0x06003AFB RID: 15099 RVA: 0x000E31A4 File Offset: 0x000E13A4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				OfficeService officeService = this.<>4__this;
				int id;
				try
				{
					if (num > 1)
					{
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter awaiter;
						ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter awaiter2;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								goto IL_145;
							}
							this.office.created = new DateTime?(Localization.GetServerUtcTime(this.<ctx>5__2));
							this.<ctx>5__2.offices.Add(this.office);
							awaiter2 = this.<ctx>5__2.SaveChangesAsync().ConfigureAwait(false).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num3 = 0;
								num = 0;
								this.<>1__state = num3;
								this.<>u__1 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter, OfficeService.<CreateOfficeAsync>d__3>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
						}
						awaiter2.GetResult();
						officeService._history.Add(16, new string[]
						{
							this.office.name
						});
						awaiter = officeService._history.SaveAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num5 = 1;
							num = 1;
							this.<>1__state = num5;
							this.<>u__2 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, OfficeService.<CreateOfficeAsync>d__3>(ref awaiter, ref this);
							return;
						}
						IL_145:
						awaiter.GetResult();
						id = this.office.id;
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

			// Token: 0x06003AFC RID: 15100 RVA: 0x000E3384 File Offset: 0x000E1584
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040025C3 RID: 9667
			public int <>1__state;

			// Token: 0x040025C4 RID: 9668
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x040025C5 RID: 9669
			public offices office;

			// Token: 0x040025C6 RID: 9670
			public OfficeService <>4__this;

			// Token: 0x040025C7 RID: 9671
			private auseceEntities <ctx>5__2;

			// Token: 0x040025C8 RID: 9672
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x040025C9 RID: 9673
			private TaskAwaiter <>u__2;
		}

		// Token: 0x0200074D RID: 1869
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06003AFD RID: 15101 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x040025CA RID: 9674
			public int officeId;
		}

		// Token: 0x0200074E RID: 1870
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetOfficeAsync>d__5 : IAsyncStateMachine
		{
			// Token: 0x06003AFE RID: 15102 RVA: 0x000E33A0 File Offset: 0x000E15A0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				offices result;
				try
				{
					OfficeService.<>c__DisplayClass5_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new OfficeService.<>c__DisplayClass5_0();
						CS$<>8__locals1.officeId = this.officeId;
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						ConfiguredTaskAwaitable<offices>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = this.<ctx>5__2.offices.AsNoTracking().FirstOrDefaultAsync((offices i) => i.id == CS$<>8__locals1.officeId).ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<offices>.ConfiguredTaskAwaiter, OfficeService.<GetOfficeAsync>d__5>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<offices>.ConfiguredTaskAwaiter);
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

			// Token: 0x06003AFF RID: 15103 RVA: 0x000E352C File Offset: 0x000E172C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040025CB RID: 9675
			public int <>1__state;

			// Token: 0x040025CC RID: 9676
			public AsyncTaskMethodBuilder<offices> <>t__builder;

			// Token: 0x040025CD RID: 9677
			public int officeId;

			// Token: 0x040025CE RID: 9678
			private auseceEntities <ctx>5__2;

			// Token: 0x040025CF RID: 9679
			private ConfiguredTaskAwaitable<offices>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x0200074F RID: 1871
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateOfficeAsync>d__6 : IAsyncStateMachine
		{
			// Token: 0x06003B00 RID: 15104 RVA: 0x000E3548 File Offset: 0x000E1748
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				OfficeService officeService = this.<>4__this;
				try
				{
					if (num > 2)
					{
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						ConfiguredTaskAwaitable<offices>.ConfiguredTaskAwaiter awaiter;
						ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter awaiter2;
						TaskAwaiter awaiter3;
						switch (num)
						{
						case 0:
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<offices>.ConfiguredTaskAwaiter);
							int num2 = -1;
							num = -1;
							this.<>1__state = num2;
							break;
						}
						case 1:
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
							goto IL_17E;
						}
						case 2:
						{
							awaiter3 = this.<>u__3;
							this.<>u__3 = default(TaskAwaiter);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
							goto IL_200;
						}
						default:
							awaiter = this.<ctx>5__2.offices.FindAsync(new object[]
							{
								this.office.id
							}).ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num5 = 0;
								num = 0;
								this.<>1__state = num5;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<offices>.ConfiguredTaskAwaiter, OfficeService.<UpdateOfficeAsync>d__6>(ref awaiter, ref this);
								return;
							}
							break;
						}
						offices result = awaiter.GetResult();
						if (this.office.name != result.name)
						{
							officeService._history.Add(17, new string[]
							{
								this.office.name,
								result.name
							});
						}
						this.<ctx>5__2.Entry<offices>(result).CurrentValues.SetValues(this.office);
						awaiter2 = this.<ctx>5__2.SaveChangesAsync().ConfigureAwait(false).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num6 = 1;
							num = 1;
							this.<>1__state = num6;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter, OfficeService.<UpdateOfficeAsync>d__6>(ref awaiter2, ref this);
							return;
						}
						IL_17E:
						awaiter2.GetResult();
						officeService._history.Add(15, new string[]
						{
							this.office.name
						});
						awaiter3 = officeService._history.SaveAsync().GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							int num7 = 2;
							num = 2;
							this.<>1__state = num7;
							this.<>u__3 = awaiter3;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, OfficeService.<UpdateOfficeAsync>d__6>(ref awaiter3, ref this);
							return;
						}
						IL_200:
						awaiter3.GetResult();
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
						}
					}
					this.<ctx>5__2 = null;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003B01 RID: 15105 RVA: 0x000E37E0 File Offset: 0x000E19E0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040025D0 RID: 9680
			public int <>1__state;

			// Token: 0x040025D1 RID: 9681
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040025D2 RID: 9682
			public offices office;

			// Token: 0x040025D3 RID: 9683
			public OfficeService <>4__this;

			// Token: 0x040025D4 RID: 9684
			private auseceEntities <ctx>5__2;

			// Token: 0x040025D5 RID: 9685
			private ConfiguredTaskAwaitable<offices>.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x040025D6 RID: 9686
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__2;

			// Token: 0x040025D7 RID: 9687
			private TaskAwaiter <>u__3;
		}

		// Token: 0x02000750 RID: 1872
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003B02 RID: 15106 RVA: 0x000E37FC File Offset: 0x000E19FC
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003B03 RID: 15107 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x040025D8 RID: 9688
			public static readonly OfficeService.<>c <>9 = new OfficeService.<>c();
		}

		// Token: 0x02000751 RID: 1873
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetOfficesLookupAsync>d__7 : IAsyncStateMachine
		{
			// Token: 0x06003B04 RID: 15108 RVA: 0x000E3814 File Offset: 0x000E1A14
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IEnumerable<IOfficeLookup> result;
				try
				{
					if (num != 0)
					{
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						ConfiguredTaskAwaitable<List<OfficeDTO>>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							ParameterExpression parameterExpression;
							awaiter = this.<ctx>5__2.offices.AsNoTracking().Select(Expression.Lambda<Func<offices, OfficeDTO>>(Expression.MemberInit(Expression.New(typeof(OfficeDTO)), new MemberBinding[]
							{
								Expression.Bind(methodof(OfficeDTO.set_Id(int)), Expression.Property(parameterExpression, methodof(offices.get_id()))),
								Expression.Bind(methodof(OfficeDTO.set_Name(string)), Expression.Property(parameterExpression, methodof(offices.get_name()))),
								Expression.Bind(methodof(OfficeDTO.set_Address(string)), Expression.Property(parameterExpression, methodof(offices.get_address()))),
								Expression.Bind(methodof(OfficeDTO.set_State(int)), Expression.Property(parameterExpression, methodof(offices.get_state())))
							}), new ParameterExpression[]
							{
								parameterExpression
							})).ToListAsync<OfficeDTO>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<List<OfficeDTO>>.ConfiguredTaskAwaiter, OfficeService.<GetOfficesLookupAsync>d__7>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<List<OfficeDTO>>.ConfiguredTaskAwaiter);
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

			// Token: 0x06003B05 RID: 15109 RVA: 0x000E3A20 File Offset: 0x000E1C20
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040025D9 RID: 9689
			public int <>1__state;

			// Token: 0x040025DA RID: 9690
			public AsyncTaskMethodBuilder<IEnumerable<IOfficeLookup>> <>t__builder;

			// Token: 0x040025DB RID: 9691
			private auseceEntities <ctx>5__2;

			// Token: 0x040025DC RID: 9692
			private ConfiguredTaskAwaitable<List<OfficeDTO>>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000752 RID: 1874
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetOfficesAsync>d__8 : IAsyncStateMachine
		{
			// Token: 0x06003B06 RID: 15110 RVA: 0x000E3A3C File Offset: 0x000E1C3C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<offices> result;
				try
				{
					if (num != 0)
					{
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						ConfiguredTaskAwaitable<List<offices>>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = (from i in this.<ctx>5__2.offices.AsNoTracking().Include((offices i) => i.users)
							where i.state == 1
							orderby i.name
							select i).ToListAsync<offices>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<List<offices>>.ConfiguredTaskAwaiter, OfficeService.<GetOfficesAsync>d__8>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<List<offices>>.ConfiguredTaskAwaiter);
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

			// Token: 0x06003B07 RID: 15111 RVA: 0x000E3C28 File Offset: 0x000E1E28
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040025DD RID: 9693
			public int <>1__state;

			// Token: 0x040025DE RID: 9694
			public AsyncTaskMethodBuilder<List<offices>> <>t__builder;

			// Token: 0x040025DF RID: 9695
			private auseceEntities <ctx>5__2;

			// Token: 0x040025E0 RID: 9696
			private ConfiguredTaskAwaitable<List<offices>>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000753 RID: 1875
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CountActiveOfficesAsync>d__9 : IAsyncStateMachine
		{
			// Token: 0x06003B08 RID: 15112 RVA: 0x000E3C44 File Offset: 0x000E1E44
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				OfficeService officeService = this.<>4__this;
				int result;
				try
				{
					if (num != 0)
					{
						this.<ctx>5__2 = officeService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<int> awaiter;
						if (num != 0)
						{
							awaiter = this.<ctx>5__2.offices.CountAsync((offices i) => i.state == 1).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, OfficeService.<CountActiveOfficesAsync>d__9>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<int>);
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

			// Token: 0x06003B09 RID: 15113 RVA: 0x000E3D98 File Offset: 0x000E1F98
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040025E1 RID: 9697
			public int <>1__state;

			// Token: 0x040025E2 RID: 9698
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x040025E3 RID: 9699
			public OfficeService <>4__this;

			// Token: 0x040025E4 RID: 9700
			private auseceEntities <ctx>5__2;

			// Token: 0x040025E5 RID: 9701
			private TaskAwaiter<int> <>u__1;
		}
	}
}
