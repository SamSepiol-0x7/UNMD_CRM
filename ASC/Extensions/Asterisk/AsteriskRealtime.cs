using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using ASC.Common.Interfaces;
using ASC.Common.Interfaces.VoIP;
using ASC.Common.Objects;
using ASC.Common.Objects.VoIP;
using ASC.Common.Repositories;
using ASC.Objects;
using ASC.Objects.Converters;
using AsterNET.Manager;
using AsterNET.Manager.Action;
using AsterNET.Manager.Event;

namespace ASC.Extensions.Asterisk
{
	// Token: 0x02000BA9 RID: 2985
	public class AsteriskRealtime : IVoIP
	{
		// Token: 0x060053D9 RID: 21465 RVA: 0x00166FE4 File Offset: 0x001651E4
		public AsteriskRealtime(IRepository<ps_endpoints> endpointsRepository, IRepository<cdr> cdrRepository)
		{
			this._endpointsRepository = endpointsRepository;
			this._cdrRepository = cdrRepository;
			this._cdrRepository.AsNoTracking();
			if (OfflineData.Instance.Employee.Tel != null)
			{
				this.Cnn = new ManagerConnection(Auth.Config.aster_host, Auth.Config.aster_port, Auth.Config.aster_login, Auth.Config.aster_password)
				{
					DefaultEventTimeout = 2000,
					DefaultResponseTimeout = 1500
				};
				this.Login();
			}
		}

		// Token: 0x060053DA RID: 21466 RVA: 0x00167078 File Offset: 0x00165278
		private void Login()
		{
			try
			{
				this.Cnn.Login();
				this.Cnn.AgentCalled += this.CnnOnAgentCalled;
				this.Cnn.AgentComplete += this.CnnOnAgentComplete;
				this.Cnn.AgentConnect += this.CnnOnAgentConnect;
				this.Cnn.Hangup += this.CnnOnHangup;
			}
			catch (AsterNET.Manager.TimeoutException)
			{
				MessageBox.Show(Lang.t("VoipErrMsg"));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x060053DB RID: 21467 RVA: 0x0016712C File Offset: 0x0016532C
		private void CnnOnAgentCalled(object sender, AgentCalledEvent agentCalledEvent)
		{
			KeyValuePair<string, string> keyValuePair = agentCalledEvent.Attributes.FirstOrDefault((KeyValuePair<string, string> p) => p.Key == "destcalleridnum");
			if (this.OnAgentCalled != null)
			{
				this.OnAgentCalled(this, new AscCallArgs(agentCalledEvent.CallerIdNum, keyValuePair.Value, DateTime.Now));
			}
		}

		// Token: 0x060053DC RID: 21468 RVA: 0x00167190 File Offset: 0x00165390
		private void CnnOnAgentConnect(object sender, AgentConnectEvent agentConnectEvent)
		{
			string memberName = agentConnectEvent.MemberName;
			string value = agentConnectEvent.Attributes.FirstOrDefault((KeyValuePair<string, string> a) => a.Key == "calleridnum").Value;
			if (this.OnAnswer != null)
			{
				this.OnAnswer(this, new AscCallArgs(value, memberName, DateTime.Now));
			}
		}

		// Token: 0x060053DD RID: 21469 RVA: 0x00023150 File Offset: 0x00021350
		private void CnnOnHangup(object sender, HangupEvent hangupEvent)
		{
		}

		// Token: 0x060053DE RID: 21470 RVA: 0x00023150 File Offset: 0x00021350
		private void CnnOnAgentComplete(object sender, AgentCompleteEvent agentCompleteEvent)
		{
		}

		// Token: 0x17001597 RID: 5527
		// (get) Token: 0x060053DF RID: 21471 RVA: 0x000304B4 File Offset: 0x0002E6B4
		public bool IsBalanceCheckAvailable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17001598 RID: 5528
		// (get) Token: 0x060053E0 RID: 21472 RVA: 0x001671F8 File Offset: 0x001653F8
		// (set) Token: 0x060053E1 RID: 21473 RVA: 0x0016720C File Offset: 0x0016540C
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

		// Token: 0x17001599 RID: 5529
		// (get) Token: 0x060053E2 RID: 21474 RVA: 0x00167220 File Offset: 0x00165420
		// (set) Token: 0x060053E3 RID: 21475 RVA: 0x00167234 File Offset: 0x00165434
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

		// Token: 0x060053E4 RID: 21476 RVA: 0x0007E558 File Offset: 0x0007C758
		public Task<UserBalance> Balance()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060053E5 RID: 21477 RVA: 0x00167248 File Offset: 0x00165448
		public Task<Callback> Callback(string user, string phone)
		{
			AsteriskRealtime.<Callback>d__21 <Callback>d__;
			<Callback>d__.<>t__builder = AsyncTaskMethodBuilder<ASC.Common.Objects.VoIP.Callback>.Create();
			<Callback>d__.<>4__this = this;
			<Callback>d__.user = user;
			<Callback>d__.phone = phone;
			<Callback>d__.<>1__state = -1;
			<Callback>d__.<>t__builder.Start<AsteriskRealtime.<Callback>d__21>(ref <Callback>d__);
			return <Callback>d__.<>t__builder.Task;
		}

		// Token: 0x060053E6 RID: 21478 RVA: 0x0016729C File Offset: 0x0016549C
		private OriginateAction NewOriginateAction(ps_endpoints endpoint, string to)
		{
			return new OriginateAction
			{
				Context = endpoint.context,
				Priority = "1",
				Channel = "PJSIP/" + endpoint.auth,
				CallerId = endpoint.auth,
				Exten = to,
				Timeout = 10000,
				Async = true
			};
		}

		// Token: 0x060053E7 RID: 21479 RVA: 0x00167300 File Offset: 0x00165500
		public Task<IEnumerable<IAscCDR>> GetCdr(IPeriod period, CallType type)
		{
			AsteriskRealtime.<GetCdr>d__23 <GetCdr>d__;
			<GetCdr>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<IAscCDR>>.Create();
			<GetCdr>d__.<>4__this = this;
			<GetCdr>d__.period = period;
			<GetCdr>d__.type = type;
			<GetCdr>d__.<>1__state = -1;
			<GetCdr>d__.<>t__builder.Start<AsteriskRealtime.<GetCdr>d__23>(ref <GetCdr>d__);
			return <GetCdr>d__.<>t__builder.Task;
		}

		// Token: 0x060053E8 RID: 21480 RVA: 0x00167354 File Offset: 0x00165554
		public Task<RecordRequest> RecordRequest(IAscCDR callDetails)
		{
			AsteriskRealtime.<RecordRequest>d__24 <RecordRequest>d__;
			<RecordRequest>d__.<>t__builder = AsyncTaskMethodBuilder<ASC.Common.Objects.VoIP.RecordRequest>.Create();
			<RecordRequest>d__.<>4__this = this;
			<RecordRequest>d__.callDetails = callDetails;
			<RecordRequest>d__.<>1__state = -1;
			<RecordRequest>d__.<>t__builder.Start<AsteriskRealtime.<RecordRequest>d__24>(ref <RecordRequest>d__);
			return <RecordRequest>d__.<>t__builder.Task;
		}

		// Token: 0x04003727 RID: 14119
		private const int ActionTimeout = 10000;

		// Token: 0x04003728 RID: 14120
		private ManagerConnection Cnn;

		// Token: 0x04003729 RID: 14121
		private IRepository<ps_endpoints> _endpointsRepository;

		// Token: 0x0400372A RID: 14122
		private IRepository<cdr> _cdrRepository;

		// Token: 0x0400372B RID: 14123
		[CompilerGenerated]
		private EventHandler<AscCallArgs> <OnAgentCalled>k__BackingField;

		// Token: 0x0400372C RID: 14124
		[CompilerGenerated]
		private EventHandler<AscCallArgs> <OnAnswer>k__BackingField;

		// Token: 0x02000BAA RID: 2986
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060053E9 RID: 21481 RVA: 0x001673A0 File Offset: 0x001655A0
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060053EA RID: 21482 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x060053EB RID: 21483 RVA: 0x001673B8 File Offset: 0x001655B8
			internal bool <CnnOnAgentCalled>b__6_0(KeyValuePair<string, string> p)
			{
				return p.Key == "destcalleridnum";
			}

			// Token: 0x060053EC RID: 21484 RVA: 0x001673D8 File Offset: 0x001655D8
			internal bool <CnnOnAgentConnect>b__7_0(KeyValuePair<string, string> a)
			{
				return a.Key == "calleridnum";
			}

			// Token: 0x060053ED RID: 21485 RVA: 0x001673F8 File Offset: 0x001655F8
			internal AscCDR <GetCdr>b__23_0(cdr s)
			{
				return s.ToAscCDR();
			}

			// Token: 0x060053EE RID: 21486 RVA: 0x0016740C File Offset: 0x0016560C
			internal bool <GetCdr>b__23_1(AscCDR s)
			{
				return s.IsIncoming;
			}

			// Token: 0x060053EF RID: 21487 RVA: 0x001673F8 File Offset: 0x001655F8
			internal AscCDR <GetCdr>b__23_2(cdr s)
			{
				return s.ToAscCDR();
			}

			// Token: 0x060053F0 RID: 21488 RVA: 0x00167420 File Offset: 0x00165620
			internal bool <GetCdr>b__23_3(AscCDR s)
			{
				return !s.IsIncoming;
			}

			// Token: 0x060053F1 RID: 21489 RVA: 0x001673F8 File Offset: 0x001655F8
			internal AscCDR <GetCdr>b__23_4(cdr s)
			{
				return s.ToAscCDR();
			}

			// Token: 0x0400372D RID: 14125
			public static readonly AsteriskRealtime.<>c <>9 = new AsteriskRealtime.<>c();

			// Token: 0x0400372E RID: 14126
			public static Func<KeyValuePair<string, string>, bool> <>9__6_0;

			// Token: 0x0400372F RID: 14127
			public static Func<KeyValuePair<string, string>, bool> <>9__7_0;

			// Token: 0x04003730 RID: 14128
			public static Func<cdr, AscCDR> <>9__23_0;

			// Token: 0x04003731 RID: 14129
			public static Func<AscCDR, bool> <>9__23_1;

			// Token: 0x04003732 RID: 14130
			public static Func<cdr, AscCDR> <>9__23_2;

			// Token: 0x04003733 RID: 14131
			public static Func<AscCDR, bool> <>9__23_3;

			// Token: 0x04003734 RID: 14132
			public static Func<cdr, AscCDR> <>9__23_4;
		}

		// Token: 0x02000BAB RID: 2987
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Callback>d__21 : IAsyncStateMachine
		{
			// Token: 0x060053F2 RID: 21490 RVA: 0x00167438 File Offset: 0x00165638
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AsteriskRealtime asteriskRealtime = this.<>4__this;
				Callback result2;
				try
				{
					if (num != 0)
					{
						this.<result>5__2 = new Callback
						{
							From = this.user,
							To = this.phone
						};
					}
					try
					{
						TaskAwaiter<ps_endpoints> awaiter;
						if (num != 0)
						{
							this.phone = OfflineData.Instance.Settings.VoipPrefix + this.phone.Remove(0, 1);
							this.<regexObj>5__3 = new Regex("[^\\d+]");
							awaiter = asteriskRealtime._endpointsRepository.GetFirstOrDefaultAsync((ps_endpoints i) => i.id == OfflineData.Instance.Employee.Tel.Value, "").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ps_endpoints>, AsteriskRealtime.<Callback>d__21>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<ps_endpoints>);
							this.<>1__state = -1;
						}
						ps_endpoints result = awaiter.GetResult();
						asteriskRealtime.Cnn.SendAction(asteriskRealtime.NewOriginateAction(result, this.<regexObj>5__3.Replace(this.phone, "")));
						this.<regexObj>5__3 = null;
					}
					catch (Exception)
					{
					}
					result2 = this.<result>5__2;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<result>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<result>5__2 = null;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x060053F3 RID: 21491 RVA: 0x00167664 File Offset: 0x00165864
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003735 RID: 14133
			public int <>1__state;

			// Token: 0x04003736 RID: 14134
			public AsyncTaskMethodBuilder<Callback> <>t__builder;

			// Token: 0x04003737 RID: 14135
			public string user;

			// Token: 0x04003738 RID: 14136
			public string phone;

			// Token: 0x04003739 RID: 14137
			public AsteriskRealtime <>4__this;

			// Token: 0x0400373A RID: 14138
			private Callback <result>5__2;

			// Token: 0x0400373B RID: 14139
			private Regex <regexObj>5__3;

			// Token: 0x0400373C RID: 14140
			private TaskAwaiter<ps_endpoints> <>u__1;
		}

		// Token: 0x02000BAC RID: 2988
		[CompilerGenerated]
		private sealed class <>c__DisplayClass23_0
		{
			// Token: 0x060053F4 RID: 21492 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass23_0()
			{
			}

			// Token: 0x0400373D RID: 14141
			public DateTime from;

			// Token: 0x0400373E RID: 14142
			public DateTime to;
		}

		// Token: 0x02000BAD RID: 2989
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCdr>d__23 : IAsyncStateMachine
		{
			// Token: 0x060053F5 RID: 21493 RVA: 0x00167680 File Offset: 0x00165880
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AsteriskRealtime asteriskRealtime = this.<>4__this;
				IEnumerable<IAscCDR> result2;
				try
				{
					ConfiguredTaskAwaitable<IEnumerable<cdr>>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						AsteriskRealtime.<>c__DisplayClass23_0 CS$<>8__locals1 = new AsteriskRealtime.<>c__DisplayClass23_0();
						CS$<>8__locals1.from = this.period.From.Date;
						CS$<>8__locals1.to = this.period.To.Date.AddDays(1.0).AddSeconds(-1.0);
						awaiter = asteriskRealtime._cdrRepository.GetAllAsync((cdr i) => i.calldate >= CS$<>8__locals1.from && i.calldate <= CS$<>8__locals1.to, null, "").ConfigureAwait(false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<IEnumerable<cdr>>.ConfiguredTaskAwaiter, AsteriskRealtime.<GetCdr>d__23>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(ConfiguredTaskAwaitable<IEnumerable<cdr>>.ConfiguredTaskAwaiter);
						this.<>1__state = -1;
					}
					IEnumerable<cdr> result = awaiter.GetResult();
					CallType callType = this.type;
					if (callType == CallType.Incoming)
					{
						result2 = result.Select(new Func<cdr, AscCDR>(AsteriskRealtime.<>c.<>9.<GetCdr>b__23_0)).Where(new Func<AscCDR, bool>(AsteriskRealtime.<>c.<>9.<GetCdr>b__23_1)).ToList<AscCDR>();
					}
					else if (callType != CallType.Outcoming)
					{
						result2 = result.Select(new Func<cdr, AscCDR>(AsteriskRealtime.<>c.<>9.<GetCdr>b__23_4)).ToList<AscCDR>();
					}
					else
					{
						result2 = result.Select(new Func<cdr, AscCDR>(AsteriskRealtime.<>c.<>9.<GetCdr>b__23_2)).Where(new Func<AscCDR, bool>(AsteriskRealtime.<>c.<>9.<GetCdr>b__23_3)).ToList<AscCDR>();
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

			// Token: 0x060053F6 RID: 21494 RVA: 0x00167964 File Offset: 0x00165B64
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400373F RID: 14143
			public int <>1__state;

			// Token: 0x04003740 RID: 14144
			public AsyncTaskMethodBuilder<IEnumerable<IAscCDR>> <>t__builder;

			// Token: 0x04003741 RID: 14145
			public IPeriod period;

			// Token: 0x04003742 RID: 14146
			public AsteriskRealtime <>4__this;

			// Token: 0x04003743 RID: 14147
			public CallType type;

			// Token: 0x04003744 RID: 14148
			private ConfiguredTaskAwaitable<IEnumerable<cdr>>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000BAE RID: 2990
		[CompilerGenerated]
		private sealed class <>c__DisplayClass24_0
		{
			// Token: 0x060053F7 RID: 21495 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass24_0()
			{
			}

			// Token: 0x04003745 RID: 14149
			public IAscCDR callDetails;
		}

		// Token: 0x02000BAF RID: 2991
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <RecordRequest>d__24 : IAsyncStateMachine
		{
			// Token: 0x060053F8 RID: 21496 RVA: 0x00167980 File Offset: 0x00165B80
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AsteriskRealtime asteriskRealtime = this.<>4__this;
				RecordRequest result2;
				try
				{
					ConfiguredTaskAwaitable<cdr>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						AsteriskRealtime.<>c__DisplayClass24_0 CS$<>8__locals1 = new AsteriskRealtime.<>c__DisplayClass24_0();
						CS$<>8__locals1.callDetails = this.callDetails;
						awaiter = asteriskRealtime._cdrRepository.GetFirstOrDefaultAsync((cdr i) => i.uniqueid == CS$<>8__locals1.callDetails.CallId, "").ConfigureAwait(false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<cdr>.ConfiguredTaskAwaiter, AsteriskRealtime.<RecordRequest>d__24>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(ConfiguredTaskAwaitable<cdr>.ConfiguredTaskAwaiter);
						this.<>1__state = -1;
					}
					cdr result = awaiter.GetResult();
					string text = "audio-" + result.uniqueid + ".wav";
					result2 = new RecordRequest
					{
						Link = string.Format("http://{0}:{1}/records/{2}-{3:d2}/{4:d2}/{5}", new object[]
						{
							asteriskRealtime.Cnn.Hostname,
							Auth.Config.aster_web_port,
							result.calldate.Year,
							result.calldate.Month,
							result.calldate.Day,
							text
						})
					};
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

			// Token: 0x060053F9 RID: 21497 RVA: 0x00167B8C File Offset: 0x00165D8C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003746 RID: 14150
			public int <>1__state;

			// Token: 0x04003747 RID: 14151
			public AsyncTaskMethodBuilder<RecordRequest> <>t__builder;

			// Token: 0x04003748 RID: 14152
			public IAscCDR callDetails;

			// Token: 0x04003749 RID: 14153
			public AsteriskRealtime <>4__this;

			// Token: 0x0400374A RID: 14154
			private ConfiguredTaskAwaitable<cdr>.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
