using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.DAL;
using ASC.Models;
using ASC.Services.Abstract;
using Microsoft.CSharp.RuntimeBinder;

namespace ASC.Services.Concrete
{
	// Token: 0x02000783 RID: 1923
	public class RepairStatusLogsService : IRepairStatusLogsService
	{
		// Token: 0x06003B84 RID: 15236 RVA: 0x000EA0B4 File Offset: 0x000E82B4
		public RepairStatusLogsService(IContextFactory contextFactory, ILoggerService<RepairStatusLogsService> loggerService)
		{
			this._contextFactory = contextFactory;
			this._loggerService = loggerService;
		}

		// Token: 0x06003B85 RID: 15237 RVA: 0x000EA0D8 File Offset: 0x000E82D8
		public Task<List<UserRepairStatusLogsModel>> GetData(IPeriod period, IList<int> statusIds, IList<int> userIds)
		{
			RepairStatusLogsService.<GetData>d__3 <GetData>d__;
			<GetData>d__.<>t__builder = AsyncTaskMethodBuilder<List<UserRepairStatusLogsModel>>.Create();
			<GetData>d__.<>4__this = this;
			<GetData>d__.period = period;
			<GetData>d__.statusIds = statusIds;
			<GetData>d__.userIds = userIds;
			<GetData>d__.<>1__state = -1;
			<GetData>d__.<>t__builder.Start<RepairStatusLogsService.<GetData>d__3>(ref <GetData>d__);
			return <GetData>d__.<>t__builder.Task;
		}

		// Token: 0x06003B86 RID: 15238 RVA: 0x000EA134 File Offset: 0x000E8334
		private Task<UserRepairStatusLogsModel> GetUserData(IPeriod period, IList<int> statusIds, auseceEntities ctx, int userId, List<repair_status_logs> data)
		{
			RepairStatusLogsService.<GetUserData>d__4 <GetUserData>d__;
			<GetUserData>d__.<>t__builder = AsyncTaskMethodBuilder<UserRepairStatusLogsModel>.Create();
			<GetUserData>d__.<>4__this = this;
			<GetUserData>d__.period = period;
			<GetUserData>d__.statusIds = statusIds;
			<GetUserData>d__.ctx = ctx;
			<GetUserData>d__.userId = userId;
			<GetUserData>d__.data = data;
			<GetUserData>d__.<>1__state = -1;
			<GetUserData>d__.<>t__builder.Start<RepairStatusLogsService.<GetUserData>d__4>(ref <GetUserData>d__);
			return <GetUserData>d__.<>t__builder.Task;
		}

		// Token: 0x06003B87 RID: 15239 RVA: 0x000EA1A4 File Offset: 0x000E83A4
		private Task<List<repair_status_logs>> GetRepairStatusLogs(ICollection<int> statusIds, ICollection<int> userIds, auseceEntities ctx, IPeriod period)
		{
			RepairStatusLogsService.<GetRepairStatusLogs>d__5 <GetRepairStatusLogs>d__;
			<GetRepairStatusLogs>d__.<>t__builder = AsyncTaskMethodBuilder<List<repair_status_logs>>.Create();
			<GetRepairStatusLogs>d__.statusIds = statusIds;
			<GetRepairStatusLogs>d__.userIds = userIds;
			<GetRepairStatusLogs>d__.ctx = ctx;
			<GetRepairStatusLogs>d__.period = period;
			<GetRepairStatusLogs>d__.<>1__state = -1;
			<GetRepairStatusLogs>d__.<>t__builder.Start<RepairStatusLogsService.<GetRepairStatusLogs>d__5>(ref <GetRepairStatusLogs>d__);
			return <GetRepairStatusLogs>d__.<>t__builder.Task;
		}

		// Token: 0x06003B88 RID: 15240 RVA: 0x000EA200 File Offset: 0x000E8400
		[return: Dynamic]
		private static dynamic GetDateLogs(IEnumerable<int> statusIds, DateTime day, List<repair_status_logs> data, int userId)
		{
			object obj = new ExpandoObject();
			if (RepairStatusLogsService.<>o__6.<>p__0 == null)
			{
				RepairStatusLogsService.<>o__6.<>p__0 = CallSite<Func<CallSite, object, DateTime, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "Date", typeof(RepairStatusLogsService), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
				}));
			}
			RepairStatusLogsService.<>o__6.<>p__0.Target(RepairStatusLogsService.<>o__6.<>p__0, obj, day);
			using (IEnumerator<int> enumerator = statusIds.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					int statusId = enumerator.Current;
					List<repair_status_logs> source = data.Where(delegate(repair_status_logs i)
					{
						if (i.UserId == userId)
						{
							if (i.StatusId == statusId)
							{
								return i.CreatedAt.Date == day;
							}
						}
						return false;
					}).ToList<repair_status_logs>();
					IDictionary<string, object> dictionary = obj as IDictionary<string, object>;
					string key = string.Format("Id_{0}", statusId);
					UserRepairStatusLogsModel.StatusData statusData = new UserRepairStatusLogsModel.StatusData();
					statusData.Count = source.Count<repair_status_logs>();
					statusData.RepairIds = (from i in source
					select i.RepairId).ToList<int>();
					dictionary.Add(key, statusData);
				}
			}
			return obj;
		}

		// Token: 0x06003B89 RID: 15241 RVA: 0x000EA350 File Offset: 0x000E8550
		private void GetUserStatusesTotal(IEnumerable<int> statusIds, UserRepairStatusLogsModel d, List<repair_status_logs> data, int userId)
		{
			IDictionary<string, object> dictionary = d.Total as IDictionary<string, object>;
			using (IEnumerator<int> enumerator = statusIds.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					int statusId = enumerator.Current;
					dictionary.Add(string.Format("StatusId_{0}", statusId), data.Count((repair_status_logs i) => i.UserId == userId && i.StatusId == statusId));
				}
			}
		}

		// Token: 0x040026A0 RID: 9888
		private readonly IContextFactory _contextFactory;

		// Token: 0x040026A1 RID: 9889
		private readonly ILoggerService<RepairStatusLogsService> _loggerService;

		// Token: 0x02000784 RID: 1924
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetData>d__3 : IAsyncStateMachine
		{
			// Token: 0x06003B8A RID: 15242 RVA: 0x000EA3F0 File Offset: 0x000E85F0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairStatusLogsService repairStatusLogsService = this.<>4__this;
				List<UserRepairStatusLogsModel> result3;
				try
				{
					try
					{
						if (num > 1)
						{
							this.<ctx>5__2 = repairStatusLogsService._contextFactory.Create();
						}
						try
						{
							TaskAwaiter<List<repair_status_logs>> awaiter;
							if (num != 0)
							{
								if (num == 1)
								{
									goto IL_C9;
								}
								awaiter = repairStatusLogsService.GetRepairStatusLogs(this.statusIds, this.userIds, this.<ctx>5__2, this.period).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<repair_status_logs>>, RepairStatusLogsService.<GetData>d__3>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<List<repair_status_logs>>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							List<repair_status_logs> result = awaiter.GetResult();
							this.<data>5__3 = result;
							this.<result>5__4 = new List<UserRepairStatusLogsModel>();
							this.<>7__wrap4 = this.userIds.GetEnumerator();
							IL_C9:
							try
							{
								TaskAwaiter<UserRepairStatusLogsModel> awaiter2;
								if (num == 1)
								{
									awaiter2 = this.<>u__2;
									this.<>u__2 = default(TaskAwaiter<UserRepairStatusLogsModel>);
									int num4 = -1;
									num = -1;
									this.<>1__state = num4;
									goto IL_148;
								}
								IL_EF:
								if (!this.<>7__wrap4.MoveNext())
								{
									goto IL_1A5;
								}
								int userId = this.<>7__wrap4.Current;
								this.<>7__wrap5 = this.<result>5__4;
								awaiter2 = repairStatusLogsService.GetUserData(this.period, this.statusIds, this.<ctx>5__2, userId, this.<data>5__3).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									int num5 = 1;
									num = 1;
									this.<>1__state = num5;
									this.<>u__2 = awaiter2;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<UserRepairStatusLogsModel>, RepairStatusLogsService.<GetData>d__3>(ref awaiter2, ref this);
									return;
								}
								IL_148:
								UserRepairStatusLogsModel result2 = awaiter2.GetResult();
								this.<>7__wrap5.Add(result2);
								this.<>7__wrap5 = null;
								goto IL_EF;
							}
							finally
							{
								if (num < 0 && this.<>7__wrap4 != null)
								{
									this.<>7__wrap4.Dispose();
								}
							}
							IL_1A5:
							this.<>7__wrap4 = null;
							result3 = this.<result>5__4;
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
						repairStatusLogsService._loggerService.Error(ex, ex.Message);
						throw;
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result3);
			}

			// Token: 0x06003B8B RID: 15243 RVA: 0x000EA674 File Offset: 0x000E8874
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040026A2 RID: 9890
			public int <>1__state;

			// Token: 0x040026A3 RID: 9891
			public AsyncTaskMethodBuilder<List<UserRepairStatusLogsModel>> <>t__builder;

			// Token: 0x040026A4 RID: 9892
			public RepairStatusLogsService <>4__this;

			// Token: 0x040026A5 RID: 9893
			public IList<int> statusIds;

			// Token: 0x040026A6 RID: 9894
			public IList<int> userIds;

			// Token: 0x040026A7 RID: 9895
			public IPeriod period;

			// Token: 0x040026A8 RID: 9896
			private auseceEntities <ctx>5__2;

			// Token: 0x040026A9 RID: 9897
			private List<repair_status_logs> <data>5__3;

			// Token: 0x040026AA RID: 9898
			private List<UserRepairStatusLogsModel> <result>5__4;

			// Token: 0x040026AB RID: 9899
			private TaskAwaiter<List<repair_status_logs>> <>u__1;

			// Token: 0x040026AC RID: 9900
			private IEnumerator<int> <>7__wrap4;

			// Token: 0x040026AD RID: 9901
			private List<UserRepairStatusLogsModel> <>7__wrap5;

			// Token: 0x040026AE RID: 9902
			private TaskAwaiter<UserRepairStatusLogsModel> <>u__2;
		}

		// Token: 0x02000785 RID: 1925
		[CompilerGenerated]
		private static class <>o__4
		{
			// Token: 0x040026AF RID: 9903
			public static CallSite<Action<CallSite, List<object>, object>> <>p__0;
		}

		// Token: 0x02000786 RID: 1926
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x06003B8C RID: 15244 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x040026B0 RID: 9904
			public int userId;
		}

		// Token: 0x02000787 RID: 1927
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetUserData>d__4 : IAsyncStateMachine
		{
			// Token: 0x06003B8D RID: 15245 RVA: 0x000EA690 File Offset: 0x000E8890
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairStatusLogsService repairStatusLogsService = this.<>4__this;
				UserRepairStatusLogsModel result;
				try
				{
					TaskAwaiter<users> awaiter;
					if (num != 0)
					{
						this.<>8__1 = new RepairStatusLogsService.<>c__DisplayClass4_0();
						this.<>8__1.userId = this.userId;
						awaiter = this.ctx.users.SingleAsync((users i) => i.id == this.<>8__1.userId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.<>1__state = num2;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<users>, RepairStatusLogsService.<GetUserData>d__4>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<users>);
						int num3 = -1;
						num = -1;
						this.<>1__state = num3;
					}
					UserRepairStatusLogsModel userRepairStatusLogsModel = new UserRepairStatusLogsModel(awaiter.GetResult());
					repairStatusLogsService.GetUserStatusesTotal(this.statusIds, userRepairStatusLogsModel, this.data, this.<>8__1.userId);
					IEnumerator<DateTime> enumerator = this.period.EachDay().GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							DateTime day = enumerator.Current;
							if (RepairStatusLogsService.<>o__4.<>p__0 == null)
							{
								RepairStatusLogsService.<>o__4.<>p__0 = CallSite<Action<CallSite, List<object>, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Add", null, typeof(RepairStatusLogsService), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							RepairStatusLogsService.<>o__4.<>p__0.Target(RepairStatusLogsService.<>o__4.<>p__0, userRepairStatusLogsModel.Data, RepairStatusLogsService.GetDateLogs(this.statusIds, day, this.data, this.<>8__1.userId));
						}
					}
					finally
					{
						if (num < 0 && enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					result = userRepairStatusLogsModel;
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
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06003B8E RID: 15246 RVA: 0x000EA8F0 File Offset: 0x000E8AF0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040026B1 RID: 9905
			public int <>1__state;

			// Token: 0x040026B2 RID: 9906
			public AsyncTaskMethodBuilder<UserRepairStatusLogsModel> <>t__builder;

			// Token: 0x040026B3 RID: 9907
			public int userId;

			// Token: 0x040026B4 RID: 9908
			public auseceEntities ctx;

			// Token: 0x040026B5 RID: 9909
			public RepairStatusLogsService <>4__this;

			// Token: 0x040026B6 RID: 9910
			public IList<int> statusIds;

			// Token: 0x040026B7 RID: 9911
			public List<repair_status_logs> data;

			// Token: 0x040026B8 RID: 9912
			private RepairStatusLogsService.<>c__DisplayClass4_0 <>8__1;

			// Token: 0x040026B9 RID: 9913
			public IPeriod period;

			// Token: 0x040026BA RID: 9914
			private TaskAwaiter<users> <>u__1;
		}

		// Token: 0x02000788 RID: 1928
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06003B8F RID: 15247 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x040026BB RID: 9915
			public DateTime from;

			// Token: 0x040026BC RID: 9916
			public DateTime to;

			// Token: 0x040026BD RID: 9917
			public ICollection<int> userIds;

			// Token: 0x040026BE RID: 9918
			public ICollection<int> statusIds;
		}

		// Token: 0x02000789 RID: 1929
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003B90 RID: 15248 RVA: 0x000EA90C File Offset: 0x000E8B0C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003B91 RID: 15249 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06003B92 RID: 15250 RVA: 0x000EA924 File Offset: 0x000E8B24
			internal int <GetDateLogs>b__6_1(repair_status_logs i)
			{
				return i.RepairId;
			}

			// Token: 0x040026BF RID: 9919
			public static readonly RepairStatusLogsService.<>c <>9 = new RepairStatusLogsService.<>c();

			// Token: 0x040026C0 RID: 9920
			public static Func<repair_status_logs, int> <>9__6_1;
		}

		// Token: 0x0200078A RID: 1930
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetRepairStatusLogs>d__5 : IAsyncStateMachine
		{
			// Token: 0x06003B93 RID: 15251 RVA: 0x000EA938 File Offset: 0x000E8B38
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<repair_status_logs> result;
				try
				{
					TaskAwaiter<List<repair_status_logs>> awaiter;
					if (num != 0)
					{
						RepairStatusLogsService.<>c__DisplayClass5_0 CS$<>8__locals1 = new RepairStatusLogsService.<>c__DisplayClass5_0();
						CS$<>8__locals1.userIds = this.userIds;
						CS$<>8__locals1.statusIds = this.statusIds;
						CS$<>8__locals1.from = this.period.From.Date;
						CS$<>8__locals1.to = this.period.To.Date.AddDays(1.0).AddSeconds(-1.0);
						awaiter = (from i in this.ctx.repair_status_logs.AsNoTracking().Include((repair_status_logs i) => i.User)
						where i.CreatedAt >= CS$<>8__locals1.@from && i.CreatedAt <= CS$<>8__locals1.to
						where CS$<>8__locals1.userIds.Contains(i.UserId)
						where CS$<>8__locals1.statusIds.Contains(i.StatusId)
						select i).ToListAsync<repair_status_logs>().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<repair_status_logs>>, RepairStatusLogsService.<GetRepairStatusLogs>d__5>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<repair_status_logs>>);
						this.<>1__state = -1;
					}
					result = awaiter.GetResult();
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

			// Token: 0x06003B94 RID: 15252 RVA: 0x000EAC84 File Offset: 0x000E8E84
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040026C1 RID: 9921
			public int <>1__state;

			// Token: 0x040026C2 RID: 9922
			public AsyncTaskMethodBuilder<List<repair_status_logs>> <>t__builder;

			// Token: 0x040026C3 RID: 9923
			public ICollection<int> userIds;

			// Token: 0x040026C4 RID: 9924
			public ICollection<int> statusIds;

			// Token: 0x040026C5 RID: 9925
			public IPeriod period;

			// Token: 0x040026C6 RID: 9926
			public auseceEntities ctx;

			// Token: 0x040026C7 RID: 9927
			private TaskAwaiter<List<repair_status_logs>> <>u__1;
		}

		// Token: 0x0200078B RID: 1931
		[CompilerGenerated]
		private static class <>o__6
		{
			// Token: 0x040026C8 RID: 9928
			public static CallSite<Func<CallSite, object, DateTime, object>> <>p__0;
		}

		// Token: 0x0200078C RID: 1932
		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x06003B95 RID: 15253 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x040026C9 RID: 9929
			public int userId;

			// Token: 0x040026CA RID: 9930
			public DateTime day;
		}

		// Token: 0x0200078D RID: 1933
		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_1
		{
			// Token: 0x06003B96 RID: 15254 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass6_1()
			{
			}

			// Token: 0x06003B97 RID: 15255 RVA: 0x000EACA0 File Offset: 0x000E8EA0
			internal bool <GetDateLogs>b__0(repair_status_logs i)
			{
				if (i.UserId == this.CS$<>8__locals1.userId)
				{
					if (i.StatusId == this.statusId)
					{
						return i.CreatedAt.Date == this.CS$<>8__locals1.day;
					}
				}
				return false;
			}

			// Token: 0x040026CB RID: 9931
			public int statusId;

			// Token: 0x040026CC RID: 9932
			public RepairStatusLogsService.<>c__DisplayClass6_0 CS$<>8__locals1;
		}

		// Token: 0x0200078E RID: 1934
		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x06003B98 RID: 15256 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x040026CD RID: 9933
			public int userId;
		}

		// Token: 0x0200078F RID: 1935
		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_1
		{
			// Token: 0x06003B99 RID: 15257 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass7_1()
			{
			}

			// Token: 0x06003B9A RID: 15258 RVA: 0x000EACF0 File Offset: 0x000E8EF0
			internal bool <GetUserStatusesTotal>b__0(repair_status_logs i)
			{
				return i.UserId == this.CS$<>8__locals1.userId && i.StatusId == this.statusId;
			}

			// Token: 0x040026CE RID: 9934
			public int statusId;

			// Token: 0x040026CF RID: 9935
			public RepairStatusLogsService.<>c__DisplayClass7_0 CS$<>8__locals1;
		}
	}
}
