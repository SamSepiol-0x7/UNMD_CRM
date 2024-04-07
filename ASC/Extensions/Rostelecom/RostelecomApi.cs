using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Common.Interfaces.VoIP;
using ASC.Common.Objects;
using ASC.Common.Objects.VoIP;
using ASC.Common.Repositories;
using ASC.Objects;
using ASC.Voip.Rostelecom;
using ASC.Voip.Rostelecom.Core;
using ASC.Voip.Rostelecom.Models;
using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json;

namespace ASC.Extensions.Rostelecom
{
	// Token: 0x02000B90 RID: 2960
	public class RostelecomApi : IVoIP
	{
		// Token: 0x1700150C RID: 5388
		// (get) Token: 0x06005262 RID: 21090 RVA: 0x000304B4 File Offset: 0x0002E6B4
		public bool IsBalanceCheckAvailable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700150D RID: 5389
		// (get) Token: 0x06005263 RID: 21091 RVA: 0x00162888 File Offset: 0x00160A88
		// (set) Token: 0x06005264 RID: 21092 RVA: 0x0016289C File Offset: 0x00160A9C
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

		// Token: 0x1700150E RID: 5390
		// (get) Token: 0x06005265 RID: 21093 RVA: 0x001628B0 File Offset: 0x00160AB0
		// (set) Token: 0x06005266 RID: 21094 RVA: 0x001628C4 File Offset: 0x00160AC4
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

		// Token: 0x06005267 RID: 21095 RVA: 0x001628D8 File Offset: 0x00160AD8
		public RostelecomApi(IRepository<hooks> hooksRepository)
		{
			this._hooksRepository = hooksRepository;
			this._hooksRepository.AsNoTracking();
			this._hooksRepository.SetTimeout(5);
			this.apiKey = OfflineData.Instance.Settings.VoipKey;
			this.secretKey = OfflineData.Instance.Settings.VoipSecret;
			this._extension = OfflineData.Instance.Employee.Tel;
			this._rows = -1;
			this._checkCallsTimer = new Timer(new TimerCallback(this.CheckCalls), null, 2000, 800);
		}

		// Token: 0x06005268 RID: 21096 RVA: 0x00162988 File Offset: 0x00160B88
		private void CheckCalls(object state)
		{
			if (!this._busy && this._serverInfo.Connected)
			{
				this._busy = true;
				try
				{
					int num = this._hooksRepository.Count(this.NewCallToCurrentUser());
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
						hooks firstOrDefault = this._hooksRepository.GetFirstOrDefault(this.NewCallToCurrentUser(), delegate(IQueryable<hooks> i)
						{
							return from o in i
							orderby o.id descending
							select o;
						}, "");
						if (firstOrDefault != null && firstOrDefault.prm != null)
						{
							NotifyInternal notifyInternal = JsonConvert.DeserializeObject<NotifyInternal>(firstOrDefault.prm);
							string[] array = notifyInternal.FromNumber.Split(new char[]
							{
								'+',
								'@'
							});
							string caller = (array.Length > 1) ? array[1] : notifyInternal.FromNumber;
							this.RaiseOnAgentCalled(new AscCallArgs(caller, notifyInternal.RequestPin, notifyInternal.Timestamp));
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

		// Token: 0x06005269 RID: 21097 RVA: 0x00162AA8 File Offset: 0x00160CA8
		private Expression<Func<hooks, bool>> NewCallToCurrentUser()
		{
			List<string> d = new List<string>
			{
				"CALLING_INCOMING",
				"NEW_INCOMING"
			};
			return (hooks i) => i.hook_id == 2L && d.Contains(i.@event) && i.p0 == (long?)this._extension;
		}

		// Token: 0x0600526A RID: 21098 RVA: 0x00162BE8 File Offset: 0x00160DE8
		private void RaiseOnAgentCalled(AscCallArgs args)
		{
			if (this.OnAgentCalled != null)
			{
				this.OnAgentCalled(this, args);
			}
		}

		// Token: 0x0600526B RID: 21099 RVA: 0x0007E558 File Offset: 0x0007C758
		public Task<UserBalance> Balance()
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600526C RID: 21100 RVA: 0x00162C0C File Offset: 0x00160E0C
		public Task<Callback> Callback(string user, string phone)
		{
			QueryInfo queryInfo = new QueryInfo();
			queryInfo.Add("request_number", phone);
			queryInfo.Add("from_pin", user);
			return this.ProcessPostRequest<Callback>("/call_back", queryInfo);
		}

		// Token: 0x0600526D RID: 21101 RVA: 0x00162C44 File Offset: 0x00160E44
		public Task<IEnumerable<IAscCDR>> GetCdr(IPeriod period, CallType type)
		{
			RostelecomApi.<GetCdr>d__25 <GetCdr>d__;
			<GetCdr>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<IAscCDR>>.Create();
			<GetCdr>d__.<>4__this = this;
			<GetCdr>d__.period = period;
			<GetCdr>d__.<>1__state = -1;
			<GetCdr>d__.<>t__builder.Start<RostelecomApi.<GetCdr>d__25>(ref <GetCdr>d__);
			return <GetCdr>d__.<>t__builder.Task;
		}

		// Token: 0x0600526E RID: 21102 RVA: 0x00162C90 File Offset: 0x00160E90
		private Task<List<AscCDR>> GetRecords(IPeriod period)
		{
			RostelecomApi.<GetRecords>d__26 <GetRecords>d__;
			<GetRecords>d__.<>t__builder = AsyncTaskMethodBuilder<List<AscCDR>>.Create();
			<GetRecords>d__.<>4__this = this;
			<GetRecords>d__.period = period;
			<GetRecords>d__.<>1__state = -1;
			<GetRecords>d__.<>t__builder.Start<RostelecomApi.<GetRecords>d__26>(ref <GetRecords>d__);
			return <GetRecords>d__.<>t__builder.Task;
		}

		// Token: 0x0600526F RID: 21103 RVA: 0x00162CDC File Offset: 0x00160EDC
		private string GetNumber(string input)
		{
			Match match = new Regex("^(sip):([^@]+)(?:@(.+))?$").Match(input);
			if (match.Groups.Count > 1)
			{
				return match.Groups[2].Value;
			}
			return input;
		}

		// Token: 0x06005270 RID: 21104 RVA: 0x00162D1C File Offset: 0x00160F1C
		public Task<RecordRequest> RecordRequest(IAscCDR callDetails)
		{
			RostelecomApi.<RecordRequest>d__28 <RecordRequest>d__;
			<RecordRequest>d__.<>t__builder = AsyncTaskMethodBuilder<ASC.Common.Objects.VoIP.RecordRequest>.Create();
			<RecordRequest>d__.<>4__this = this;
			<RecordRequest>d__.callDetails = callDetails;
			<RecordRequest>d__.<>1__state = -1;
			<RecordRequest>d__.<>t__builder.Start<RostelecomApi.<RecordRequest>d__28>(ref <RecordRequest>d__);
			return <RecordRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06005271 RID: 21105 RVA: 0x00162D68 File Offset: 0x00160F68
		private Request CreatePostRequest(string methodUrl, QueryInfo queryInfo)
		{
			RequestInfo requestInfo = new RequestInfo("POST", this.baseUrl, methodUrl);
			AuthorizeInfo authorizeInfo = new AuthorizeInfo(this.apiKey, this.secretKey);
			return new Request(requestInfo, queryInfo, authorizeInfo);
		}

		// Token: 0x06005272 RID: 21106 RVA: 0x00162DA0 File Offset: 0x00160FA0
		private Task<T> ProcessPostRequest<T>(string methodUrl, QueryInfo queryInfo)
		{
			Request request = this.CreatePostRequest(methodUrl, queryInfo);
			return this.ProcessRequest<T>(request);
		}

		// Token: 0x06005273 RID: 21107 RVA: 0x00162DC0 File Offset: 0x00160FC0
		private Task<T> ProcessRequest<T>(Request request)
		{
			RostelecomApi.<ProcessRequest>d__31<T> <ProcessRequest>d__;
			<ProcessRequest>d__.<>t__builder = AsyncTaskMethodBuilder<T>.Create();
			<ProcessRequest>d__.request = request;
			<ProcessRequest>d__.<>1__state = -1;
			<ProcessRequest>d__.<>t__builder.Start<RostelecomApi.<ProcessRequest>d__31<T>>(ref <ProcessRequest>d__);
			return <ProcessRequest>d__.<>t__builder.Task;
		}

		// Token: 0x04003641 RID: 13889
		private ServerInfo _serverInfo = ServerInfo.Instance;

		// Token: 0x04003642 RID: 13890
		private IRepository<hooks> _hooksRepository;

		// Token: 0x04003643 RID: 13891
		private string baseUrl = "https://api.cloudpbx.rt.ru";

		// Token: 0x04003644 RID: 13892
		private string apiKey;

		// Token: 0x04003645 RID: 13893
		private string secretKey;

		// Token: 0x04003646 RID: 13894
		private int? _extension;

		// Token: 0x04003647 RID: 13895
		private Timer _checkCallsTimer;

		// Token: 0x04003648 RID: 13896
		private int _rows;

		// Token: 0x04003649 RID: 13897
		private bool _busy;

		// Token: 0x0400364A RID: 13898
		[CompilerGenerated]
		private EventHandler<AscCallArgs> <OnAgentCalled>k__BackingField;

		// Token: 0x0400364B RID: 13899
		[CompilerGenerated]
		private EventHandler<AscCallArgs> <OnAnswer>k__BackingField;

		// Token: 0x02000B91 RID: 2961
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005274 RID: 21108 RVA: 0x00162E04 File Offset: 0x00161004
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06005275 RID: 21109 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06005276 RID: 21110 RVA: 0x00162218 File Offset: 0x00160418
			internal IOrderedQueryable<hooks> <CheckCalls>b__20_0(IQueryable<hooks> i)
			{
				return from o in i
				orderby o.id descending
				select o;
			}

			// Token: 0x0400364C RID: 13900
			public static readonly RostelecomApi.<>c <>9 = new RostelecomApi.<>c();

			// Token: 0x0400364D RID: 13901
			public static Func<IQueryable<hooks>, IOrderedQueryable<hooks>> <>9__20_0;
		}

		// Token: 0x02000B92 RID: 2962
		[CompilerGenerated]
		private sealed class <>c__DisplayClass21_0
		{
			// Token: 0x06005277 RID: 21111 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass21_0()
			{
			}

			// Token: 0x0400364E RID: 13902
			public List<string> d;

			// Token: 0x0400364F RID: 13903
			public RostelecomApi <>4__this;
		}

		// Token: 0x02000B93 RID: 2963
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCdr>d__25 : IAsyncStateMachine
		{
			// Token: 0x06005278 RID: 21112 RVA: 0x00162E1C File Offset: 0x0016101C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RostelecomApi rostelecomApi = this.<>4__this;
				IEnumerable<IAscCDR> result;
				try
				{
					TaskAwaiter<List<AscCDR>> awaiter;
					if (num != 0)
					{
						awaiter = rostelecomApi.GetRecords(this.period).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<AscCDR>>, RostelecomApi.<GetCdr>d__25>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<AscCDR>>);
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

			// Token: 0x06005279 RID: 21113 RVA: 0x00162ED8 File Offset: 0x001610D8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003650 RID: 13904
			public int <>1__state;

			// Token: 0x04003651 RID: 13905
			public AsyncTaskMethodBuilder<IEnumerable<IAscCDR>> <>t__builder;

			// Token: 0x04003652 RID: 13906
			public RostelecomApi <>4__this;

			// Token: 0x04003653 RID: 13907
			public IPeriod period;

			// Token: 0x04003654 RID: 13908
			private TaskAwaiter<List<AscCDR>> <>u__1;
		}

		// Token: 0x02000B94 RID: 2964
		[CompilerGenerated]
		private sealed class <>c__DisplayClass26_0
		{
			// Token: 0x0600527A RID: 21114 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass26_0()
			{
			}

			// Token: 0x04003655 RID: 13909
			public DateTime from;

			// Token: 0x04003656 RID: 13910
			public DateTime to;

			// Token: 0x04003657 RID: 13911
			public List<string> events;
		}

		// Token: 0x02000B95 RID: 2965
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetRecords>d__26 : IAsyncStateMachine
		{
			// Token: 0x0600527B RID: 21115 RVA: 0x00162EF4 File Offset: 0x001610F4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RostelecomApi rostelecomApi = this.<>4__this;
				List<AscCDR> result2;
				try
				{
					RostelecomApi.<>c__DisplayClass26_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new RostelecomApi.<>c__DisplayClass26_0();
						CS$<>8__locals1.from = this.period.From.Date;
						CS$<>8__locals1.to = this.period.To.Date.AddDays(1.0).AddSeconds(-1.0);
						CS$<>8__locals1.events = new List<string>
						{
							"END_INCOMING",
							"END_OUTBOUND"
						};
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						ConfiguredTaskAwaitable<List<string>>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = (from i in this.<ctx>5__2.hooks.AsNoTracking()
							where i.created_at >= (DateTime?)CS$<>8__locals1.@from && i.created_at <= (DateTime?)CS$<>8__locals1.to && i.hook_id == 2L && CS$<>8__locals1.events.Contains(i.@event)
							select i.prm).DefaultIfEmpty<string>().ToListAsync<string>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<List<string>>.ConfiguredTaskAwaiter, RostelecomApi.<GetRecords>d__26>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<List<string>>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						List<string> result = awaiter.GetResult();
						List<AscCDR> list = new List<AscCDR>();
						List<string>.Enumerator enumerator = result.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								string text = enumerator.Current;
								if (text != null)
								{
									NotifyInternal notifyInternal = JsonConvert.DeserializeObject<NotifyInternal>(text);
									AscCDR ascCDR = new AscCDR
									{
										CallId = notifyInternal.SessionId,
										Start = notifyInternal.Timestamp,
										IsIncoming = (notifyInternal.Type == "incoming"),
										IsRecorded = (notifyInternal.IsRecord == "true")
									};
									if (!ascCDR.IsIncoming)
									{
										ascCDR.Destination = rostelecomApi.GetNumber(notifyInternal.RequestNumber);
										ascCDR.Src = notifyInternal.FromPin;
									}
									else
									{
										ascCDR.Destination = notifyInternal.RequestPin;
										ascCDR.Src = rostelecomApi.GetNumber(notifyInternal.FromNumber);
									}
									list.Add(ascCDR);
								}
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)enumerator).Dispose();
							}
						}
						result2 = list;
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
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x0600527C RID: 21116 RVA: 0x0016336C File Offset: 0x0016156C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003658 RID: 13912
			public int <>1__state;

			// Token: 0x04003659 RID: 13913
			public AsyncTaskMethodBuilder<List<AscCDR>> <>t__builder;

			// Token: 0x0400365A RID: 13914
			public IPeriod period;

			// Token: 0x0400365B RID: 13915
			public RostelecomApi <>4__this;

			// Token: 0x0400365C RID: 13916
			private auseceEntities <ctx>5__2;

			// Token: 0x0400365D RID: 13917
			private ConfiguredTaskAwaitable<List<string>>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000B96 RID: 2966
		[CompilerGenerated]
		private static class <>o__28
		{
			// Token: 0x0400365E RID: 13918
			public static CallSite<Func<CallSite, object, object>> <>p__0;

			// Token: 0x0400365F RID: 13919
			public static CallSite<Func<CallSite, System.Type, object, object>> <>p__1;

			// Token: 0x04003660 RID: 13920
			public static CallSite<Func<CallSite, object, object>> <>p__2;

			// Token: 0x04003661 RID: 13921
			public static CallSite<Func<CallSite, object, int, object>> <>p__3;

			// Token: 0x04003662 RID: 13922
			public static CallSite<Func<CallSite, object, bool>> <>p__4;

			// Token: 0x04003663 RID: 13923
			public static CallSite<Func<CallSite, object, object>> <>p__5;

			// Token: 0x04003664 RID: 13924
			public static CallSite<Func<CallSite, System.Type, object, MissingFieldException>> <>p__6;

			// Token: 0x04003665 RID: 13925
			public static CallSite<Func<CallSite, object, object>> <>p__7;

			// Token: 0x04003666 RID: 13926
			public static CallSite<Func<CallSite, object, string>> <>p__8;
		}

		// Token: 0x02000B97 RID: 2967
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <RecordRequest>d__28 : IAsyncStateMachine
		{
			// Token: 0x0600527D RID: 21117 RVA: 0x00163388 File Offset: 0x00161588
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RostelecomApi rostelecomApi = this.<>4__this;
				RecordRequest result2;
				try
				{
					TaskAwaiter<object> awaiter;
					if (num != 0)
					{
						QueryInfo queryInfo = new QueryInfo();
						queryInfo.Add("session_id", this.callDetails.CallId);
						awaiter = rostelecomApi.ProcessPostRequest<object>("/get_record", queryInfo).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, RostelecomApi.<RecordRequest>d__28>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<object>);
						this.<>1__state = -1;
					}
					object result = awaiter.GetResult();
					if (RostelecomApi.<>o__28.<>p__1 == null)
					{
						RostelecomApi.<>o__28.<>p__1 = CallSite<Func<CallSite, System.Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(RostelecomApi), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, System.Type, object, object> target = RostelecomApi.<>o__28.<>p__1.Target;
					CallSite <>p__ = RostelecomApi.<>o__28.<>p__1;
					System.Type typeFromHandle = typeof(Convert);
					if (RostelecomApi.<>o__28.<>p__0 == null)
					{
						RostelecomApi.<>o__28.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "code", typeof(RostelecomApi), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					object arg = target(<>p__, typeFromHandle, RostelecomApi.<>o__28.<>p__0.Target(RostelecomApi.<>o__28.<>p__0, result));
					if (RostelecomApi.<>o__28.<>p__2 == null)
					{
						RostelecomApi.<>o__28.<>p__2 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "resultMessage", typeof(RostelecomApi), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					object arg2 = RostelecomApi.<>o__28.<>p__2.Target(RostelecomApi.<>o__28.<>p__2, result);
					if (RostelecomApi.<>o__28.<>p__4 == null)
					{
						RostelecomApi.<>o__28.<>p__4 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(RostelecomApi), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, bool> target2 = RostelecomApi.<>o__28.<>p__4.Target;
					CallSite <>p__2 = RostelecomApi.<>o__28.<>p__4;
					if (RostelecomApi.<>o__28.<>p__3 == null)
					{
						RostelecomApi.<>o__28.<>p__3 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, typeof(RostelecomApi), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					if (target2(<>p__2, RostelecomApi.<>o__28.<>p__3.Target(RostelecomApi.<>o__28.<>p__3, arg, 0)))
					{
						if (RostelecomApi.<>o__28.<>p__6 == null)
						{
							RostelecomApi.<>o__28.<>p__6 = CallSite<Func<CallSite, System.Type, object, MissingFieldException>>.Create(Binder.InvokeConstructor(CSharpBinderFlags.None, typeof(RostelecomApi), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, System.Type, object, MissingFieldException> target3 = RostelecomApi.<>o__28.<>p__6.Target;
						CallSite <>p__3 = RostelecomApi.<>o__28.<>p__6;
						System.Type typeFromHandle2 = typeof(MissingFieldException);
						if (RostelecomApi.<>o__28.<>p__5 == null)
						{
							RostelecomApi.<>o__28.<>p__5 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(RostelecomApi), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						throw target3(<>p__3, typeFromHandle2, RostelecomApi.<>o__28.<>p__5.Target(RostelecomApi.<>o__28.<>p__5, arg2));
					}
					RecordRequest recordRequest = new RecordRequest();
					RecordRequest recordRequest2 = recordRequest;
					if (RostelecomApi.<>o__28.<>p__8 == null)
					{
						RostelecomApi.<>o__28.<>p__8 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(RostelecomApi)));
					}
					Func<CallSite, object, string> target4 = RostelecomApi.<>o__28.<>p__8.Target;
					CallSite <>p__4 = RostelecomApi.<>o__28.<>p__8;
					if (RostelecomApi.<>o__28.<>p__7 == null)
					{
						RostelecomApi.<>o__28.<>p__7 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "url", typeof(RostelecomApi), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					recordRequest2.Link = target4(<>p__4, RostelecomApi.<>o__28.<>p__7.Target(RostelecomApi.<>o__28.<>p__7, result));
					result2 = recordRequest;
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

			// Token: 0x0600527E RID: 21118 RVA: 0x00163754 File Offset: 0x00161954
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003667 RID: 13927
			public int <>1__state;

			// Token: 0x04003668 RID: 13928
			public AsyncTaskMethodBuilder<RecordRequest> <>t__builder;

			// Token: 0x04003669 RID: 13929
			public IAscCDR callDetails;

			// Token: 0x0400366A RID: 13930
			public RostelecomApi <>4__this;

			// Token: 0x0400366B RID: 13931
			private TaskAwaiter<object> <>u__1;
		}

		// Token: 0x02000B98 RID: 2968
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ProcessRequest>d__31<T> : IAsyncStateMachine
		{
			// Token: 0x0600527F RID: 21119 RVA: 0x00163770 File Offset: 0x00161970
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
							goto IL_CF;
						}
						awaiter2 = this.request.GetResponse().ConfigureAwait(false).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<HttpWebResponse>.ConfiguredTaskAwaiter, RostelecomApi.<ProcessRequest>d__31<T>>(ref awaiter2, ref this);
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
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, RostelecomApi.<ProcessRequest>d__31<T>>(ref awaiter, ref this);
						return;
					}
					IL_CF:
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

			// Token: 0x06005280 RID: 21120 RVA: 0x001638A4 File Offset: 0x00161AA4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400366C RID: 13932
			public int <>1__state;

			// Token: 0x0400366D RID: 13933
			public AsyncTaskMethodBuilder<T> <>t__builder;

			// Token: 0x0400366E RID: 13934
			public Request request;

			// Token: 0x0400366F RID: 13935
			private ConfiguredTaskAwaitable<HttpWebResponse>.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x04003670 RID: 13936
			private TaskAwaiter<string> <>u__2;
		}
	}
}
