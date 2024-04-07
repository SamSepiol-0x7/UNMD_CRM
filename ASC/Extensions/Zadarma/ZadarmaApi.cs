using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Common.Interfaces.VoIP;
using ASC.Common.Objects;
using ASC.Common.Objects.VoIP;
using ASC.Common.Repositories;
using ASC.Exceptions;
using ASC.Objects;
using ASC.Objects.Converters;
using ASC.Voip;
using ASC.Voip.Zadarma.Core;
using ASC.Voip.Zadarma.Models;
using Newtonsoft.Json;

namespace ASC.Extensions.Zadarma
{
	// Token: 0x02000B8A RID: 2954
	public class ZadarmaApi : IVoIP
	{
		// Token: 0x06005241 RID: 21057 RVA: 0x00161B5C File Offset: 0x0015FD5C
		public ZadarmaApi(IRepository<hooks> hooksRepository)
		{
			this._hooksRepository = hooksRepository;
			this._hooksRepository.AsNoTracking();
			this._hooksRepository.SetTimeout(5);
			this.apiKey = OfflineData.Instance.Settings.VoipKey;
			this.secretKey = OfflineData.Instance.Settings.VoipSecret;
			this._extension = OfflineData.Instance.Employee.Tel;
			this._rows = -1;
			this._backupTimer = new Timer(new TimerCallback(this.CheckCalls), null, 2000, 1000);
		}

		// Token: 0x06005242 RID: 21058 RVA: 0x00161C0C File Offset: 0x0015FE0C
		private void CheckCalls(object state)
		{
			if (!this._busy && this._serverInfo.Connected)
			{
				this._busy = true;
				try
				{
					int num = this._hooksRepository.Count((hooks i) => i.hook_id == 1L && i.@event == "NOTIFY_INTERNAL" && i.p0 == (long?)this._extension);
					if (num == -1)
					{
						return;
					}
					if (this._rows == -1)
					{
						this._rows = num;
					}
					if (num != this._rows)
					{
						this._rows = num;
						hooks firstOrDefault = this._hooksRepository.GetFirstOrDefault((hooks i) => i.hook_id == 1L && i.@event == "NOTIFY_INTERNAL" && i.p0 == (long?)this._extension, delegate(IQueryable<hooks> i)
						{
							return from o in i
							orderby o.id descending
							select o;
						}, "");
						if (firstOrDefault != null && firstOrDefault.prm != null)
						{
							NotifyInternal notifyInternal = JsonConvert.DeserializeObject<NotifyInternal>(firstOrDefault.prm);
							this.RaiseOnAgentCalled(new AscCallArgs(notifyInternal.CallerId, notifyInternal.Internal.ToString(), notifyInternal.CallStart));
						}
					}
				}
				catch (Exception)
				{
				}
				this._busy = false;
				return;
			}
		}

		// Token: 0x17001509 RID: 5385
		// (get) Token: 0x06005243 RID: 21059 RVA: 0x0007E5F4 File Offset: 0x0007C7F4
		public bool IsBalanceCheckAvailable
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700150A RID: 5386
		// (get) Token: 0x06005244 RID: 21060 RVA: 0x00161EC4 File Offset: 0x001600C4
		// (set) Token: 0x06005245 RID: 21061 RVA: 0x00161ED8 File Offset: 0x001600D8
		public EventHandler<AscCallArgs> OnAgentCalled
		{
			[CompilerGenerated]
			get
			{
				return this.<OnAgentCalled>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<OnAgentCalled>k__BackingField = value;
			}
		}

		// Token: 0x1700150B RID: 5387
		// (get) Token: 0x06005246 RID: 21062 RVA: 0x00161EEC File Offset: 0x001600EC
		// (set) Token: 0x06005247 RID: 21063 RVA: 0x00161F00 File Offset: 0x00160100
		public EventHandler<AscCallArgs> OnAnswer
		{
			[CompilerGenerated]
			get
			{
				return this.<OnAnswer>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<OnAnswer>k__BackingField = value;
			}
		}

		// Token: 0x06005248 RID: 21064 RVA: 0x00161F14 File Offset: 0x00160114
		private void RaiseOnAgentCalled(AscCallArgs args)
		{
			if (this.OnAgentCalled != null)
			{
				this.OnAgentCalled(this, args);
			}
		}

		// Token: 0x06005249 RID: 21065 RVA: 0x00161F38 File Offset: 0x00160138
		public Task<UserBalance> Balance()
		{
			return this.ProcessGetRequest<UserBalance>("/v1/info/balance/", null);
		}

		// Token: 0x0600524A RID: 21066 RVA: 0x00161F54 File Offset: 0x00160154
		public Task<UserSips> Sips()
		{
			return this.ProcessGetRequest<UserSips>("/v1/sip/", null);
		}

		// Token: 0x0600524B RID: 21067 RVA: 0x00161F70 File Offset: 0x00160170
		public Task<Callback> Callback(string user, string phone)
		{
			QueryInfo queryInfo = new QueryInfo().Add("from", user).Add("to", phone);
			return this.ProcessGetRequest<Callback>("/v1/request/callback/", queryInfo);
		}

		// Token: 0x0600524C RID: 21068 RVA: 0x00161FA8 File Offset: 0x001601A8
		public Task<ASC.Common.Objects.VoIP.RecordRequest> RecordRequest(IAscCDR callDetails)
		{
			QueryInfo queryInfo = new QueryInfo().Add("call_id", callDetails.CallId).Add("lifetime", 1800);
			return this.ProcessGetRequest<ASC.Common.Objects.VoIP.RecordRequest>("/v1/pbx/record/request/", queryInfo);
		}

		// Token: 0x0600524D RID: 21069 RVA: 0x00161FEC File Offset: 0x001601EC
		public Task<StatisticsPbx> StatisticsPbx(IPeriod period, int skip = 0, int limit = 1000)
		{
			QueryInfo queryInfo = new QueryInfo().Add("start", period.From.Date.ToString("yyyy-MM-dd HH:mm:ss")).Add("end", period.To.Date.AddDays(1.0).AddSeconds(-1.0).ToString("yyyy-MM-dd HH:mm:ss")).Add("skip", skip).Add("limit", limit);
			return this.ProcessGetRequest<StatisticsPbx>("/v1/statistics/pbx/", queryInfo);
		}

		// Token: 0x0600524E RID: 21070 RVA: 0x00162098 File Offset: 0x00160298
		private Task<IList<StatisticPbx>> GetStatistics(IPeriod period, int skip = 0, int limit = 1000)
		{
			ZadarmaApi.<GetStatistics>d__27 <GetStatistics>d__;
			<GetStatistics>d__.<>t__builder = AsyncTaskMethodBuilder<IList<StatisticPbx>>.Create();
			<GetStatistics>d__.<>4__this = this;
			<GetStatistics>d__.period = period;
			<GetStatistics>d__.skip = skip;
			<GetStatistics>d__.limit = limit;
			<GetStatistics>d__.<>1__state = -1;
			<GetStatistics>d__.<>t__builder.Start<ZadarmaApi.<GetStatistics>d__27>(ref <GetStatistics>d__);
			return <GetStatistics>d__.<>t__builder.Task;
		}

		// Token: 0x0600524F RID: 21071 RVA: 0x001620F4 File Offset: 0x001602F4
		public Task<IEnumerable<IAscCDR>> GetCdr(IPeriod period, CallType type)
		{
			ZadarmaApi.<GetCdr>d__28 <GetCdr>d__;
			<GetCdr>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<IAscCDR>>.Create();
			<GetCdr>d__.<>4__this = this;
			<GetCdr>d__.period = period;
			<GetCdr>d__.type = type;
			<GetCdr>d__.<>1__state = -1;
			<GetCdr>d__.<>t__builder.Start<ZadarmaApi.<GetCdr>d__28>(ref <GetCdr>d__);
			return <GetCdr>d__.<>t__builder.Task;
		}

		// Token: 0x06005250 RID: 21072 RVA: 0x00162148 File Offset: 0x00160348
		private Request CreateGetRequest(string methodUrl, QueryInfo queryInfo = null)
		{
			RequestInfo requestInfo = new RequestInfo("GET", this.baseUrl, methodUrl);
			AuthorizeInfo authorizeInfo = new AuthorizeInfo(this.apiKey, this.secretKey);
			queryInfo = (queryInfo ?? new QueryInfo());
			queryInfo.Add("format", "json");
			return new Request(requestInfo, queryInfo, authorizeInfo);
		}

		// Token: 0x06005251 RID: 21073 RVA: 0x0016219C File Offset: 0x0016039C
		private Task<T> ProcessGetRequest<T>(string methodUrl, QueryInfo queryInfo = null)
		{
			Request request = this.CreateGetRequest(methodUrl, queryInfo);
			return this.ProcessRequest<T>(request);
		}

		// Token: 0x06005252 RID: 21074 RVA: 0x001621BC File Offset: 0x001603BC
		private Task<T> ProcessRequest<T>(Request request)
		{
			ZadarmaApi.<ProcessRequest>d__31<T> <ProcessRequest>d__;
			<ProcessRequest>d__.<>t__builder = AsyncTaskMethodBuilder<T>.Create();
			<ProcessRequest>d__.request = request;
			<ProcessRequest>d__.<>1__state = -1;
			<ProcessRequest>d__.<>t__builder.Start<ZadarmaApi.<ProcessRequest>d__31<T>>(ref <ProcessRequest>d__);
			return <ProcessRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0400361A RID: 13850
		private ServerInfo _serverInfo = ServerInfo.Instance;

		// Token: 0x0400361B RID: 13851
		private IRepository<hooks> _hooksRepository;

		// Token: 0x0400361C RID: 13852
		private string baseUrl = "https://api.zadarma.com";

		// Token: 0x0400361D RID: 13853
		private string apiKey;

		// Token: 0x0400361E RID: 13854
		private string secretKey;

		// Token: 0x0400361F RID: 13855
		private int? _extension;

		// Token: 0x04003620 RID: 13856
		private Timer _backupTimer;

		// Token: 0x04003621 RID: 13857
		private int _rows;

		// Token: 0x04003622 RID: 13858
		private bool _busy;

		// Token: 0x04003623 RID: 13859
		[CompilerGenerated]
		private EventHandler<AscCallArgs> <OnAgentCalled>k__BackingField;

		// Token: 0x04003624 RID: 13860
		[CompilerGenerated]
		private EventHandler<AscCallArgs> <OnAnswer>k__BackingField;

		// Token: 0x02000B8B RID: 2955
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005253 RID: 21075 RVA: 0x00162200 File Offset: 0x00160400
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06005254 RID: 21076 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06005255 RID: 21077 RVA: 0x00162218 File Offset: 0x00160418
			internal IOrderedQueryable<hooks> <CheckCalls>b__10_2(IQueryable<hooks> i)
			{
				return from o in i
				orderby o.id descending
				select o;
			}

			// Token: 0x06005256 RID: 21078 RVA: 0x00162264 File Offset: 0x00160464
			internal IAscCDR <GetCdr>b__28_0(StatisticPbx s)
			{
				return s.ToAscCDR();
			}

			// Token: 0x06005257 RID: 21079 RVA: 0x00162278 File Offset: 0x00160478
			internal bool <GetCdr>b__28_1(IAscCDR r)
			{
				return r.Disposition == Lang.t("dispositionAnswered") && !string.IsNullOrEmpty(r.Src) && !string.IsNullOrEmpty(r.Destination);
			}

			// Token: 0x06005258 RID: 21080 RVA: 0x00065E9C File Offset: 0x0006409C
			internal bool <GetCdr>b__28_2(IAscCDR s)
			{
				return s.IsIncoming;
			}

			// Token: 0x06005259 RID: 21081 RVA: 0x00065EB0 File Offset: 0x000640B0
			internal bool <GetCdr>b__28_3(IAscCDR s)
			{
				return !s.IsIncoming;
			}

			// Token: 0x04003625 RID: 13861
			public static readonly ZadarmaApi.<>c <>9 = new ZadarmaApi.<>c();

			// Token: 0x04003626 RID: 13862
			public static Func<IQueryable<hooks>, IOrderedQueryable<hooks>> <>9__10_2;

			// Token: 0x04003627 RID: 13863
			public static Func<StatisticPbx, IAscCDR> <>9__28_0;

			// Token: 0x04003628 RID: 13864
			public static Func<IAscCDR, bool> <>9__28_1;

			// Token: 0x04003629 RID: 13865
			public static Func<IAscCDR, bool> <>9__28_2;

			// Token: 0x0400362A RID: 13866
			public static Func<IAscCDR, bool> <>9__28_3;
		}

		// Token: 0x02000B8C RID: 2956
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetStatistics>d__27 : IAsyncStateMachine
		{
			// Token: 0x0600525A RID: 21082 RVA: 0x001622BC File Offset: 0x001604BC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ZadarmaApi zadarmaApi = this.<>4__this;
				IList<StatisticPbx> result3;
				try
				{
					TaskAwaiter<IList<StatisticPbx>> awaiter;
					TaskAwaiter<StatisticsPbx> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<IList<StatisticPbx>>);
							this.<>1__state = -1;
							goto IL_133;
						}
						this.<output>5__2 = new List<StatisticPbx>();
						awaiter2 = zadarmaApi.StatisticsPbx(this.period, this.skip, this.limit).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<StatisticsPbx>, ZadarmaApi.<GetStatistics>d__27>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<StatisticsPbx>);
						this.<>1__state = -1;
					}
					StatisticsPbx result = awaiter2.GetResult();
					this.<output>5__2.AddRange(result.Stats);
					if (result.Stats.Count != 1000)
					{
						goto IL_150;
					}
					this.<>7__wrap2 = this.<output>5__2;
					awaiter = zadarmaApi.GetStatistics(this.period, this.limit, this.limit + 1000).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IList<StatisticPbx>>, ZadarmaApi.<GetStatistics>d__27>(ref awaiter, ref this);
						return;
					}
					IL_133:
					IList<StatisticPbx> result2 = awaiter.GetResult();
					this.<>7__wrap2.AddRange(result2);
					this.<>7__wrap2 = null;
					IL_150:
					result3 = this.<output>5__2;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<output>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<output>5__2 = null;
				this.<>t__builder.SetResult(result3);
			}

			// Token: 0x0600525B RID: 21083 RVA: 0x0016247C File Offset: 0x0016067C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400362B RID: 13867
			public int <>1__state;

			// Token: 0x0400362C RID: 13868
			public AsyncTaskMethodBuilder<IList<StatisticPbx>> <>t__builder;

			// Token: 0x0400362D RID: 13869
			public ZadarmaApi <>4__this;

			// Token: 0x0400362E RID: 13870
			public IPeriod period;

			// Token: 0x0400362F RID: 13871
			public int skip;

			// Token: 0x04003630 RID: 13872
			public int limit;

			// Token: 0x04003631 RID: 13873
			private List<StatisticPbx> <output>5__2;

			// Token: 0x04003632 RID: 13874
			private TaskAwaiter<StatisticsPbx> <>u__1;

			// Token: 0x04003633 RID: 13875
			private List<StatisticPbx> <>7__wrap2;

			// Token: 0x04003634 RID: 13876
			private TaskAwaiter<IList<StatisticPbx>> <>u__2;
		}

		// Token: 0x02000B8D RID: 2957
		[CompilerGenerated]
		private sealed class <>c__DisplayClass28_0
		{
			// Token: 0x0600525C RID: 21084 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass28_0()
			{
			}

			// Token: 0x0600525D RID: 21085 RVA: 0x00162498 File Offset: 0x00160698
			internal bool <GetCdr>b__4(IAscCDR i)
			{
				return (i.Start.Equals(this.a.Start) && i.Disposition != Lang.t("dispositionAnswered")) || i.Destination.Equals("0");
			}

			// Token: 0x04003635 RID: 13877
			public IAscCDR a;
		}

		// Token: 0x02000B8E RID: 2958
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCdr>d__28 : IAsyncStateMachine
		{
			// Token: 0x0600525E RID: 21086 RVA: 0x001624EC File Offset: 0x001606EC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ZadarmaApi zadarmaApi = this.<>4__this;
				IEnumerable<IAscCDR> result;
				try
				{
					try
					{
						TaskAwaiter<IList<StatisticPbx>> awaiter;
						if (num != 0)
						{
							awaiter = zadarmaApi.GetStatistics(this.period, 0, 1000).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IList<StatisticPbx>>, ZadarmaApi.<GetCdr>d__28>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IList<StatisticPbx>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						List<IAscCDR> list = awaiter.GetResult().Select(new Func<StatisticPbx, IAscCDR>(ZadarmaApi.<>c.<>9.<GetCdr>b__28_0)).ToList<IAscCDR>();
						List<IAscCDR>.Enumerator enumerator = list.Where(new Func<IAscCDR, bool>(ZadarmaApi.<>c.<>9.<GetCdr>b__28_1)).ToList<IAscCDR>().GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								IAscCDR a = enumerator.Current;
								list.RemoveAll(new Predicate<IAscCDR>(new ZadarmaApi.<>c__DisplayClass28_0
								{
									a = a
								}.<GetCdr>b__4));
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)enumerator).Dispose();
							}
						}
						CallType callType = this.type;
						if (callType == CallType.Incoming)
						{
							result = list.Where(new Func<IAscCDR, bool>(ZadarmaApi.<>c.<>9.<GetCdr>b__28_2)).ToList<IAscCDR>();
						}
						else if (callType != CallType.Outcoming)
						{
							result = list;
						}
						else
						{
							result = list.Where(new Func<IAscCDR, bool>(ZadarmaApi.<>c.<>9.<GetCdr>b__28_3)).ToList<IAscCDR>();
						}
					}
					catch (Exception ex)
					{
						if (ex.Message.Contains("You exceeded the rate limit"))
						{
							throw new AsccrmException("Превышен лимит запросов, повторите попытку позже.");
						}
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
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x0600525F RID: 21087 RVA: 0x00162720 File Offset: 0x00160920
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003636 RID: 13878
			public int <>1__state;

			// Token: 0x04003637 RID: 13879
			public AsyncTaskMethodBuilder<IEnumerable<IAscCDR>> <>t__builder;

			// Token: 0x04003638 RID: 13880
			public ZadarmaApi <>4__this;

			// Token: 0x04003639 RID: 13881
			public IPeriod period;

			// Token: 0x0400363A RID: 13882
			public CallType type;

			// Token: 0x0400363B RID: 13883
			private TaskAwaiter<IList<StatisticPbx>> <>u__1;
		}

		// Token: 0x02000B8F RID: 2959
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ProcessRequest>d__31<T> : IAsyncStateMachine
		{
			// Token: 0x06005260 RID: 21088 RVA: 0x0016273C File Offset: 0x0016093C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				T result2;
				try
				{
					TaskAwaiter<string> awaiter;
					ConfiguredTaskAwaitable<HttpWebResponse>.ConfiguredTaskAwaiter awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<string>);
							this.<>1__state = -1;
							goto IL_CC;
						}
						awaiter2 = this.request.GetResponse().ConfigureAwait(false).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<HttpWebResponse>.ConfiguredTaskAwaiter, ZadarmaApi.<ProcessRequest>d__31<T>>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(ConfiguredTaskAwaitable<HttpWebResponse>.ConfiguredTaskAwaiter);
						this.<>1__state = -1;
					}
					awaiter = awaiter2.GetResult().Content().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, ZadarmaApi.<ProcessRequest>d__31<T>>(ref awaiter, ref this);
						return;
					}
					IL_CC:
					string result = awaiter.GetResult();
					JsonConvert.DeserializeObject<ResponseObject>(result).Validate();
					result2 = JsonConvert.DeserializeObject<T>(result);
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06005261 RID: 21089 RVA: 0x0016286C File Offset: 0x00160A6C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400363C RID: 13884
			public int <>1__state;

			// Token: 0x0400363D RID: 13885
			public AsyncTaskMethodBuilder<T> <>t__builder;

			// Token: 0x0400363E RID: 13886
			public Request request;

			// Token: 0x0400363F RID: 13887
			private ConfiguredTaskAwaitable<HttpWebResponse>.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x04003640 RID: 13888
			private TaskAwaiter<string> <>u__2;
		}
	}
}
