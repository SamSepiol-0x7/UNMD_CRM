using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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
using ASC.Voip.Megafon;
using ASC.Voip.Megafon.Core;
using ASC.Voip.Megafon.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ASC.Extensions.Megafon
{
	// Token: 0x02000BB8 RID: 3000
	public class Megafon : IVoIP, IMegafon
	{
		// Token: 0x170015A0 RID: 5536
		// (get) Token: 0x0600541D RID: 21533 RVA: 0x000304B4 File Offset: 0x0002E6B4
		public bool IsBalanceCheckAvailable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170015A1 RID: 5537
		// (get) Token: 0x0600541E RID: 21534 RVA: 0x00168CD8 File Offset: 0x00166ED8
		// (set) Token: 0x0600541F RID: 21535 RVA: 0x00168CEC File Offset: 0x00166EEC
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

		// Token: 0x170015A2 RID: 5538
		// (get) Token: 0x06005420 RID: 21536 RVA: 0x00168D00 File Offset: 0x00166F00
		// (set) Token: 0x06005421 RID: 21537 RVA: 0x00168D14 File Offset: 0x00166F14
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

		// Token: 0x06005422 RID: 21538 RVA: 0x00168D28 File Offset: 0x00166F28
		public Megafon(IMegafonApiOptions options, IRepository<hooks> hooksRepository)
		{
			if (options == null)
			{
				throw new ArgumentNullException("options");
			}
			this._options = options;
			this._hooksRepository = hooksRepository;
			this._hooksRepository.AsNoTracking();
			this._hooksRepository.SetTimeout(5);
			this._extension = OfflineData.Instance.Employee.Tel;
			this._rows = -1;
			this._checkCallsTimer = new Timer(new TimerCallback(this.CheckCalls), null, 2000, 1000);
		}

		// Token: 0x06005423 RID: 21539 RVA: 0x00168DB8 File Offset: 0x00166FB8
		private void CheckCalls(object state)
		{
			if (!this._busy && this._serverInfo.Connected)
			{
				this._busy = true;
				try
				{
					int num = this._hooksRepository.Count((hooks i) => i.hook_id == 6L && i.@event == "Incoming".ToUpper() && i.p0 == (long?)this._extension);
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
						hooks firstOrDefault = this._hooksRepository.GetFirstOrDefault((hooks i) => i.hook_id == 6L && i.@event == "Incoming".ToUpper() && i.p0 == (long?)this._extension, delegate(IQueryable<hooks> i)
						{
							return from o in i
							orderby o.id descending
							select o;
						}, "");
						if (firstOrDefault != null && firstOrDefault.prm != null)
						{
							NotifyInternal notifyInternal = JsonConvert.DeserializeObject<NotifyInternal>(firstOrDefault.prm);
							this.RaiseOnAgentCalled(new AscCallArgs(notifyInternal.Phone, notifyInternal.Ext, firstOrDefault.created_at ?? DateTime.Now));
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

		// Token: 0x06005424 RID: 21540 RVA: 0x001690B4 File Offset: 0x001672B4
		private void RaiseOnAgentCalled(AscCallArgs args)
		{
			if (this.OnAgentCalled != null)
			{
				this.OnAgentCalled(this, args);
			}
		}

		// Token: 0x06005425 RID: 21541 RVA: 0x0007E558 File Offset: 0x0007C758
		public Task<UserBalance> Balance()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06005426 RID: 21542 RVA: 0x001690D8 File Offset: 0x001672D8
		public Task<Callback> Callback(string user, string phone)
		{
			Megafon.<Callback>d__22 <Callback>d__;
			<Callback>d__.<>t__builder = AsyncTaskMethodBuilder<ASC.Common.Objects.VoIP.Callback>.Create();
			<Callback>d__.<>4__this = this;
			<Callback>d__.user = user;
			<Callback>d__.phone = phone;
			<Callback>d__.<>1__state = -1;
			<Callback>d__.<>t__builder.Start<Megafon.<Callback>d__22>(ref <Callback>d__);
			return <Callback>d__.<>t__builder.Task;
		}

		// Token: 0x06005427 RID: 21543 RVA: 0x0016912C File Offset: 0x0016732C
		public Task<IEnumerable<IAscCDR>> GetCdr(IPeriod period, CallType type)
		{
			Megafon.<GetCdr>d__23 <GetCdr>d__;
			<GetCdr>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<IAscCDR>>.Create();
			<GetCdr>d__.<>4__this = this;
			<GetCdr>d__.period = period;
			<GetCdr>d__.type = type;
			<GetCdr>d__.<>1__state = -1;
			<GetCdr>d__.<>t__builder.Start<Megafon.<GetCdr>d__23>(ref <GetCdr>d__);
			return <GetCdr>d__.<>t__builder.Task;
		}

		// Token: 0x06005428 RID: 21544 RVA: 0x00169180 File Offset: 0x00167380
		private void AddDirectionFilter(CallType type, ICollection<KeyValuePair<string, string>> args)
		{
			if (type == CallType.Incoming)
			{
				args.Add(new KeyValuePair<string, string>("type", "in"));
				return;
			}
			if (type == CallType.Outcoming)
			{
				args.Add(new KeyValuePair<string, string>("type", "out"));
				return;
			}
		}

		// Token: 0x06005429 RID: 21545 RVA: 0x001691C4 File Offset: 0x001673C4
		private IAscCDR FromCsv(string csvLine)
		{
			string[] array = csvLine.Split(new char[]
			{
				','
			});
			AscCDR ascCDR = new AscCDR
			{
				CallId = array[0],
				IsIncoming = (array[1] == "in"),
				Start = DateTime.Parse(array[5]),
				Duration = int.Parse(array[7]),
				IsRecorded = !string.IsNullOrEmpty(array[8]),
				Record = array[8]
			};
			ascCDR.Destination = (ascCDR.IsIncoming ? array[4] : array[2]);
			ascCDR.Src = (ascCDR.IsIncoming ? array[2] : array[4]);
			ascCDR.Disposition = this.GetDisposition(ascCDR.Duration);
			return ascCDR;
		}

		// Token: 0x0600542A RID: 21546 RVA: 0x0016927C File Offset: 0x0016747C
		private string GetDisposition(int duration)
		{
			if (duration <= 0)
			{
				return Lang.t("dispositionFailed");
			}
			return Lang.t("dispositionAnswered");
		}

		// Token: 0x0600542B RID: 21547 RVA: 0x001692A4 File Offset: 0x001674A4
		public Task<RecordRequest> RecordRequest(IAscCDR callDetails)
		{
			return Task.FromResult<RecordRequest>(new RecordRequest
			{
				Link = callDetails.Record
			});
		}

		// Token: 0x0600542C RID: 21548 RVA: 0x001692C8 File Offset: 0x001674C8
		public Task<ICollection<MegafonGroup>> Groups()
		{
			Megafon.<Groups>d__28 <Groups>d__;
			<Groups>d__.<>t__builder = AsyncTaskMethodBuilder<ICollection<MegafonGroup>>.Create();
			<Groups>d__.<>4__this = this;
			<Groups>d__.<>1__state = -1;
			<Groups>d__.<>t__builder.Start<Megafon.<Groups>d__28>(ref <Groups>d__);
			return <Groups>d__.<>t__builder.Task;
		}

		// Token: 0x0600542D RID: 21549 RVA: 0x0016930C File Offset: 0x0016750C
		public Task<bool> GetDnd(string user)
		{
			Megafon.<GetDnd>d__29 <GetDnd>d__;
			<GetDnd>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<GetDnd>d__.<>4__this = this;
			<GetDnd>d__.user = user;
			<GetDnd>d__.<>1__state = -1;
			<GetDnd>d__.<>t__builder.Start<Megafon.<GetDnd>d__29>(ref <GetDnd>d__);
			return <GetDnd>d__.<>t__builder.Task;
		}

		// Token: 0x0600542E RID: 21550 RVA: 0x00169358 File Offset: 0x00167558
		private Task<TResult> SendRequest<TResult>(ICollection<KeyValuePair<string, string>> args, Func<StreamReader, TResult> processResults = null)
		{
			Megafon.<SendRequest>d__30<TResult> <SendRequest>d__;
			<SendRequest>d__.<>t__builder = AsyncTaskMethodBuilder<TResult>.Create();
			<SendRequest>d__.<>4__this = this;
			<SendRequest>d__.args = args;
			<SendRequest>d__.processResults = processResults;
			<SendRequest>d__.<>1__state = -1;
			<SendRequest>d__.<>t__builder.Start<Megafon.<SendRequest>d__30<TResult>>(ref <SendRequest>d__);
			return <SendRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0600542F RID: 21551 RVA: 0x001693AC File Offset: 0x001675AC
		[CompilerGenerated]
		private List<IAscCDR> <GetCdr>b__23_0(StreamReader response)
		{
			List<IAscCDR> list = new List<IAscCDR>();
			while (!response.EndOfStream)
			{
				string text = response.ReadLine();
				if (text != null)
				{
					list.Add(this.FromCsv(text));
				}
			}
			return list;
		}

		// Token: 0x04003774 RID: 14196
		private ServerInfo _serverInfo = ServerInfo.Instance;

		// Token: 0x04003775 RID: 14197
		private readonly IMegafonApiOptions _options;

		// Token: 0x04003776 RID: 14198
		private IRepository<hooks> _hooksRepository;

		// Token: 0x04003777 RID: 14199
		private const string phoneNumberRegex = "^7\\d{10}$";

		// Token: 0x04003778 RID: 14200
		[CompilerGenerated]
		private EventHandler<AscCallArgs> <OnAgentCalled>k__BackingField;

		// Token: 0x04003779 RID: 14201
		[CompilerGenerated]
		private EventHandler<AscCallArgs> <OnAnswer>k__BackingField;

		// Token: 0x0400377A RID: 14202
		private int? _extension;

		// Token: 0x0400377B RID: 14203
		private Timer _checkCallsTimer;

		// Token: 0x0400377C RID: 14204
		private int _rows;

		// Token: 0x0400377D RID: 14205
		private bool _busy;

		// Token: 0x02000BB9 RID: 3001
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005430 RID: 21552 RVA: 0x001693E4 File Offset: 0x001675E4
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06005431 RID: 21553 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06005432 RID: 21554 RVA: 0x00162218 File Offset: 0x00160418
			internal IOrderedQueryable<hooks> <CheckCalls>b__19_2(IQueryable<hooks> i)
			{
				return from o in i
				orderby o.id descending
				select o;
			}

			// Token: 0x06005433 RID: 21555 RVA: 0x001693FC File Offset: 0x001675FC
			internal MegafonGroup[] <Groups>b__28_0(StreamReader text)
			{
				MegafonGroup[] result;
				using (JsonTextReader jsonTextReader = new JsonTextReader(text))
				{
					result = new JsonSerializer().Deserialize<MegafonGroup[]>(jsonTextReader);
				}
				return result;
			}

			// Token: 0x06005434 RID: 21556 RVA: 0x0016943C File Offset: 0x0016763C
			internal bool <GetDnd>b__29_0(StreamReader text)
			{
				bool result;
				using (JsonTextReader jsonTextReader = new JsonTextReader(text))
				{
					result = new JsonSerializer().Deserialize<JObject>(jsonTextReader).Value<bool>("state");
				}
				return result;
			}

			// Token: 0x0400377E RID: 14206
			public static readonly Megafon.<>c <>9 = new Megafon.<>c();

			// Token: 0x0400377F RID: 14207
			public static Func<IQueryable<hooks>, IOrderedQueryable<hooks>> <>9__19_2;

			// Token: 0x04003780 RID: 14208
			public static Func<StreamReader, MegafonGroup[]> <>9__28_0;

			// Token: 0x04003781 RID: 14209
			public static Func<StreamReader, bool> <>9__29_0;
		}

		// Token: 0x02000BBA RID: 3002
		[CompilerGenerated]
		private sealed class <>c__DisplayClass22_0
		{
			// Token: 0x06005435 RID: 21557 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass22_0()
			{
			}

			// Token: 0x06005436 RID: 21558 RVA: 0x00169484 File Offset: 0x00167684
			internal Callback <Callback>b__0(StreamReader response)
			{
				return new Callback
				{
					From = this.user,
					To = this.phone
				};
			}

			// Token: 0x04003782 RID: 14210
			public string user;

			// Token: 0x04003783 RID: 14211
			public string phone;
		}

		// Token: 0x02000BBB RID: 3003
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Callback>d__22 : IAsyncStateMachine
		{
			// Token: 0x06005437 RID: 21559 RVA: 0x001694B0 File Offset: 0x001676B0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Megafon megafon = this.<>4__this;
				Callback result;
				try
				{
					TaskAwaiter<Callback> awaiter;
					if (num != 0)
					{
						Megafon.<>c__DisplayClass22_0 CS$<>8__locals1 = new Megafon.<>c__DisplayClass22_0();
						CS$<>8__locals1.user = this.user;
						CS$<>8__locals1.phone = this.phone;
						if (!Regex.IsMatch(CS$<>8__locals1.phone, "^7\\d{10}$"))
						{
							throw new ArgumentException("Number you were going to reach: $" + CS$<>8__locals1.phone + " is invalid. Use 7XXXXXXXXXX format.");
						}
						KeyValuePair<string, string>[] args = new KeyValuePair<string, string>[]
						{
							new KeyValuePair<string, string>("cmd", "makeCall"),
							new KeyValuePair<string, string>("token", megafon._options.ApiToken),
							new KeyValuePair<string, string>("user", CS$<>8__locals1.user),
							new KeyValuePair<string, string>("phone", CS$<>8__locals1.phone)
						};
						awaiter = megafon.SendRequest<Callback>(args, new Func<StreamReader, Callback>(CS$<>8__locals1.<Callback>b__0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Callback>, Megafon.<Callback>d__22>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<Callback>);
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

			// Token: 0x06005438 RID: 21560 RVA: 0x0016963C File Offset: 0x0016783C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003784 RID: 14212
			public int <>1__state;

			// Token: 0x04003785 RID: 14213
			public AsyncTaskMethodBuilder<Callback> <>t__builder;

			// Token: 0x04003786 RID: 14214
			public string user;

			// Token: 0x04003787 RID: 14215
			public string phone;

			// Token: 0x04003788 RID: 14216
			public Megafon <>4__this;

			// Token: 0x04003789 RID: 14217
			private TaskAwaiter<Callback> <>u__1;
		}

		// Token: 0x02000BBC RID: 3004
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCdr>d__23 : IAsyncStateMachine
		{
			// Token: 0x06005439 RID: 21561 RVA: 0x00169658 File Offset: 0x00167858
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Megafon megafon = this.<>4__this;
				IEnumerable<IAscCDR> result;
				try
				{
					TaskAwaiter<List<IAscCDR>> awaiter;
					if (num != 0)
					{
						List<KeyValuePair<string, string>> args = new List<KeyValuePair<string, string>>
						{
							new KeyValuePair<string, string>("cmd", "history"),
							new KeyValuePair<string, string>("token", megafon._options.ApiToken),
							new KeyValuePair<string, string>("start", string.Format("{0:yyyyMMddTHHmmssZ}", this.period.From)),
							new KeyValuePair<string, string>("end", string.Format("{0:yyyyMMddTHHmmssZ}", this.period.To.AddDays(1.0).AddSeconds(-1.0)))
						};
						megafon.AddDirectionFilter(this.type, args);
						awaiter = megafon.SendRequest<List<IAscCDR>>(args, delegate(StreamReader response)
						{
							List<IAscCDR> list = new List<IAscCDR>();
							while (!response.EndOfStream)
							{
								string text = response.ReadLine();
								if (text != null)
								{
									list.Add(base.FromCsv(text));
								}
							}
							return list;
						}).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<IAscCDR>>, Megafon.<GetCdr>d__23>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<IAscCDR>>);
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

			// Token: 0x0600543A RID: 21562 RVA: 0x001697E8 File Offset: 0x001679E8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400378A RID: 14218
			public int <>1__state;

			// Token: 0x0400378B RID: 14219
			public AsyncTaskMethodBuilder<IEnumerable<IAscCDR>> <>t__builder;

			// Token: 0x0400378C RID: 14220
			public Megafon <>4__this;

			// Token: 0x0400378D RID: 14221
			public IPeriod period;

			// Token: 0x0400378E RID: 14222
			public CallType type;

			// Token: 0x0400378F RID: 14223
			private TaskAwaiter<List<IAscCDR>> <>u__1;
		}

		// Token: 0x02000BBD RID: 3005
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Groups>d__28 : IAsyncStateMachine
		{
			// Token: 0x0600543B RID: 21563 RVA: 0x00169804 File Offset: 0x00167A04
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Megafon megafon = this.<>4__this;
				ICollection<MegafonGroup> result;
				try
				{
					TaskAwaiter<MegafonGroup[]> awaiter;
					if (num != 0)
					{
						KeyValuePair<string, string>[] args = new KeyValuePair<string, string>[]
						{
							new KeyValuePair<string, string>("cmd", "groups"),
							new KeyValuePair<string, string>("token", megafon._options.ApiToken)
						};
						awaiter = megafon.SendRequest<MegafonGroup[]>(args, new Func<StreamReader, MegafonGroup[]>(Megafon.<>c.<>9.<Groups>b__28_0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<MegafonGroup[]>, Megafon.<Groups>d__28>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<MegafonGroup[]>);
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

			// Token: 0x0600543C RID: 21564 RVA: 0x0016991C File Offset: 0x00167B1C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003790 RID: 14224
			public int <>1__state;

			// Token: 0x04003791 RID: 14225
			public AsyncTaskMethodBuilder<ICollection<MegafonGroup>> <>t__builder;

			// Token: 0x04003792 RID: 14226
			public Megafon <>4__this;

			// Token: 0x04003793 RID: 14227
			private TaskAwaiter<MegafonGroup[]> <>u__1;
		}

		// Token: 0x02000BBE RID: 3006
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetDnd>d__29 : IAsyncStateMachine
		{
			// Token: 0x0600543D RID: 21565 RVA: 0x00169938 File Offset: 0x00167B38
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Megafon megafon = this.<>4__this;
				bool result;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						KeyValuePair<string, string>[] args = new KeyValuePair<string, string>[]
						{
							new KeyValuePair<string, string>("cmd", "get_dnd"),
							new KeyValuePair<string, string>("token", megafon._options.ApiToken),
							new KeyValuePair<string, string>("user", this.user)
						};
						awaiter = megafon.SendRequest<bool>(args, new Func<StreamReader, bool>(Megafon.<>c.<>9.<GetDnd>b__29_0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Megafon.<GetDnd>d__29>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<bool>);
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

			// Token: 0x0600543E RID: 21566 RVA: 0x00169A64 File Offset: 0x00167C64
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003794 RID: 14228
			public int <>1__state;

			// Token: 0x04003795 RID: 14229
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x04003796 RID: 14230
			public Megafon <>4__this;

			// Token: 0x04003797 RID: 14231
			public string user;

			// Token: 0x04003798 RID: 14232
			private TaskAwaiter<bool> <>u__1;
		}

		// Token: 0x02000BBF RID: 3007
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SendRequest>d__30<TResult> : IAsyncStateMachine
		{
			// Token: 0x0600543F RID: 21567 RVA: 0x00169A80 File Offset: 0x00167C80
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Megafon megafon = this.<>4__this;
				TResult result2;
				try
				{
					if (num > 2)
					{
						this.<client>5__2 = new HttpClient();
					}
					try
					{
						if (num > 2)
						{
							this.<request>5__3 = new HttpRequestMessage(HttpMethod.Post, megafon._options.PbxEndpoint);
						}
						try
						{
							TaskAwaiter<HttpResponseMessage> awaiter;
							if (num != 0)
							{
								if (num - 1 <= 1)
								{
									goto IL_CC;
								}
								this.<request>5__3.Headers.CacheControl = CacheControlHeaderValue.Parse("no-cache");
								this.<request>5__3.Content = new FormUrlEncodedContent(this.args);
								awaiter = this.<client>5__2.SendAsync(this.<request>5__3).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									goto IL_231;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<HttpResponseMessage>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
							}
							HttpResponseMessage result = awaiter.GetResult();
							this.<response>5__4 = result;
							IL_CC:
							try
							{
								TaskAwaiter<string> awaiter3;
								if (num != 1)
								{
									TaskAwaiter<Stream> awaiter2;
									if (num != 2)
									{
										if (this.<response>5__4.IsSuccessStatusCode)
										{
											if (this.processResults == null)
											{
												result2 = default(TResult);
												goto IL_29B;
											}
											awaiter2 = this.<response>5__4.Content.ReadAsStreamAsync().GetAwaiter();
											if (!awaiter2.IsCompleted)
											{
												int num3 = 2;
												num = 2;
												this.<>1__state = num3;
												this.<>u__3 = awaiter2;
												this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Stream>, Megafon.<SendRequest>d__30<TResult>>(ref awaiter2, ref this);
												return;
											}
										}
										else
										{
											awaiter3 = this.<response>5__4.Content.ReadAsStringAsync().GetAwaiter();
											if (!awaiter3.IsCompleted)
											{
												int num4 = 1;
												num = 1;
												this.<>1__state = num4;
												this.<>u__2 = awaiter3;
												this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Megafon.<SendRequest>d__30<TResult>>(ref awaiter3, ref this);
												return;
											}
											goto IL_1E8;
										}
									}
									else
									{
										awaiter2 = this.<>u__3;
										this.<>u__3 = default(TaskAwaiter<Stream>);
										int num5 = -1;
										num = -1;
										this.<>1__state = num5;
									}
									Stream result3 = awaiter2.GetResult();
									try
									{
										StreamReader streamReader = new StreamReader(result3);
										try
										{
											result2 = this.processResults(streamReader);
											goto IL_29B;
										}
										finally
										{
											if (num < 0 && streamReader != null)
											{
												((IDisposable)streamReader).Dispose();
											}
										}
									}
									finally
									{
										if (num < 0 && result3 != null)
										{
											((IDisposable)result3).Dispose();
										}
									}
								}
								awaiter3 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<string>);
								int num6 = -1;
								num = -1;
								this.<>1__state = num6;
								IL_1E8:
								throw new InvalidOperationException(awaiter3.GetResult());
							}
							finally
							{
								if (num < 0 && this.<response>5__4 != null)
								{
									((IDisposable)this.<response>5__4).Dispose();
								}
							}
							IL_231:
							int num7 = 0;
							num = 0;
							this.<>1__state = num7;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Megafon.<SendRequest>d__30<TResult>>(ref awaiter, ref this);
							return;
						}
						finally
						{
							if (num < 0 && this.<request>5__3 != null)
							{
								((IDisposable)this.<request>5__3).Dispose();
							}
						}
					}
					finally
					{
						if (num < 0 && this.<client>5__2 != null)
						{
							((IDisposable)this.<client>5__2).Dispose();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_29B:
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06005440 RID: 21568 RVA: 0x00169DD0 File Offset: 0x00167FD0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003799 RID: 14233
			public int <>1__state;

			// Token: 0x0400379A RID: 14234
			public AsyncTaskMethodBuilder<TResult> <>t__builder;

			// Token: 0x0400379B RID: 14235
			public Megafon <>4__this;

			// Token: 0x0400379C RID: 14236
			public ICollection<KeyValuePair<string, string>> args;

			// Token: 0x0400379D RID: 14237
			public Func<StreamReader, TResult> processResults;

			// Token: 0x0400379E RID: 14238
			private HttpClient <client>5__2;

			// Token: 0x0400379F RID: 14239
			private HttpRequestMessage <request>5__3;

			// Token: 0x040037A0 RID: 14240
			private HttpResponseMessage <response>5__4;

			// Token: 0x040037A1 RID: 14241
			private TaskAwaiter<HttpResponseMessage> <>u__1;

			// Token: 0x040037A2 RID: 14242
			private TaskAwaiter<string> <>u__2;

			// Token: 0x040037A3 RID: 14243
			private TaskAwaiter<Stream> <>u__3;
		}
	}
}
