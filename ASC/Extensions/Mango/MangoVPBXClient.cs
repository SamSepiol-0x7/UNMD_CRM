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
using ASC.Common.Objects.VoIP;
using ASC.Objects;
using ASC.Voip;
using ASC.Voip.Mango.Core;
using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ASC.Extensions.Mango
{
	// Token: 0x02000BC6 RID: 3014
	public class MangoVPBXClient
	{
		// Token: 0x170015A8 RID: 5544
		// (get) Token: 0x0600545A RID: 21594 RVA: 0x0016ABFC File Offset: 0x00168DFC
		public AuthorizeInfo AuthorizeInfo
		{
			[CompilerGenerated]
			get
			{
				return this.<AuthorizeInfo>k__BackingField;
			}
		}

		// Token: 0x0600545B RID: 21595 RVA: 0x0016AC10 File Offset: 0x00168E10
		public MangoVPBXClient(AuthorizeInfo authorizeInfo)
		{
			this.AuthorizeInfo = authorizeInfo;
		}

		// Token: 0x0600545C RID: 21596 RVA: 0x0016AC38 File Offset: 0x00168E38
		public Task<UserBalance> Balance()
		{
			QueryInfo queryInfo = new QueryInfo();
			queryInfo.Add("json", "{}");
			return this.ProcessPostRequest<UserBalance>("/account/balance", queryInfo);
		}

		// Token: 0x0600545D RID: 21597 RVA: 0x0016AC68 File Offset: 0x00168E68
		public Task<Callback> Callback(string from, string to)
		{
			QueryInfo queryInfo = new QueryInfo();
			string value = JsonConvert.SerializeObject(new Dictionary<string, object>
			{
				{
					"command_id",
					"cbk1"
				},
				{
					"from",
					new Dictionary<string, object>
					{
						{
							"extension",
							from
						}
					}
				},
				{
					"to_number",
					to
				}
			});
			queryInfo.Add("json", value);
			return this.ProcessPostRequest<Callback>("/commands/callback", queryInfo);
		}

		// Token: 0x0600545E RID: 21598 RVA: 0x0016ACD8 File Offset: 0x00168ED8
		public Task<IEnumerable<IAscCDR>> Stats(IPeriod period, string callParty = "")
		{
			MangoVPBXClient.<Stats>d__7 <Stats>d__;
			<Stats>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<IAscCDR>>.Create();
			<Stats>d__.<>4__this = this;
			<Stats>d__.period = period;
			<Stats>d__.callParty = callParty;
			<Stats>d__.<>1__state = -1;
			<Stats>d__.<>t__builder.Start<MangoVPBXClient.<Stats>d__7>(ref <Stats>d__);
			return <Stats>d__.<>t__builder.Task;
		}

		// Token: 0x0600545F RID: 21599 RVA: 0x0016AD2C File Offset: 0x00168F2C
		public Task<RecordRequest> Recording(string recordingId)
		{
			MangoVPBXClient.<Recording>d__8 <Recording>d__;
			<Recording>d__.<>t__builder = AsyncTaskMethodBuilder<RecordRequest>.Create();
			<Recording>d__.<>4__this = this;
			<Recording>d__.recordingId = recordingId;
			<Recording>d__.<>1__state = -1;
			<Recording>d__.<>t__builder.Start<MangoVPBXClient.<Recording>d__8>(ref <Recording>d__);
			return <Recording>d__.<>t__builder.Task;
		}

		// Token: 0x06005460 RID: 21600 RVA: 0x0016AD78 File Offset: 0x00168F78
		private Request CreatePostRequest(string methodUrl, QueryInfo queryInfo)
		{
			return new Request(new RequestInfo("POST", this.baseUrl, methodUrl), queryInfo, this.AuthorizeInfo);
		}

		// Token: 0x06005461 RID: 21601 RVA: 0x0016ADA4 File Offset: 0x00168FA4
		private Task<T> ProcessPostRequest<T>(string methodUrl, QueryInfo queryInfo)
		{
			Request request = this.CreatePostRequest(methodUrl, queryInfo);
			return this.ProcessRequest<T>(request);
		}

		// Token: 0x06005462 RID: 21602 RVA: 0x0016ADC4 File Offset: 0x00168FC4
		private Task<T> ProcessRequest<T>(Request request)
		{
			MangoVPBXClient.<ProcessRequest>d__11<T> <ProcessRequest>d__;
			<ProcessRequest>d__.<>t__builder = AsyncTaskMethodBuilder<T>.Create();
			<ProcessRequest>d__.request = request;
			<ProcessRequest>d__.<>1__state = -1;
			<ProcessRequest>d__.<>t__builder.Start<MangoVPBXClient.<ProcessRequest>d__11<T>>(ref <ProcessRequest>d__);
			return <ProcessRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06005463 RID: 21603 RVA: 0x0016AE08 File Offset: 0x00169008
		public static AscCDR FromCsv(string csvLine)
		{
			AscCDR ascCDR = new AscCDR();
			string[] array = csvLine.Split(new char[]
			{
				';'
			});
			ascCDR.Start = MangoVPBXClient.UnixTimeStampToDateTime(Convert.ToDouble(array[1]));
			DateTime d = MangoVPBXClient.UnixTimeStampToDateTime(Convert.ToDouble(array[2]));
			MangoVPBXClient.UnixTimeStampToDateTime(Convert.ToDouble(array[3]));
			string text = array[4];
			string text2 = array[5];
			string text3 = array[6];
			string text4 = array[7];
			ascCDR.IsIncoming = string.IsNullOrEmpty(text);
			ascCDR.Src = ((!string.IsNullOrEmpty(text)) ? text : text2);
			ascCDR.Destination = ((!string.IsNullOrEmpty(text3)) ? text3 : text4);
			ascCDR.Duration = (d - ascCDR.Start).Seconds;
			if (!(array[0] == "[]"))
			{
				string[] array2 = array[0].Trim(new char[]
				{
					'[',
					']'
				}).Split(new char[]
				{
					','
				});
				ascCDR.IsRecorded = true;
				ascCDR.CallId = array2[0];
			}
			else
			{
				ascCDR.CallId = array[1];
			}
			return ascCDR;
		}

		// Token: 0x06005464 RID: 21604 RVA: 0x0016AF14 File Offset: 0x00169114
		public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
		{
			DateTime result = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
			result = result.AddSeconds(unixTimeStamp).ToLocalTime();
			return result;
		}

		// Token: 0x040037D2 RID: 14290
		private string baseUrl = "https://app.mango-office.ru/vpbx";

		// Token: 0x040037D3 RID: 14291
		[CompilerGenerated]
		private readonly AuthorizeInfo <AuthorizeInfo>k__BackingField;

		// Token: 0x02000BC7 RID: 3015
		[CompilerGenerated]
		private static class <>o__7
		{
			// Token: 0x040037D4 RID: 14292
			public static CallSite<Func<CallSite, object, long, object>> <>p__0;

			// Token: 0x040037D5 RID: 14293
			public static CallSite<Func<CallSite, object, long, object>> <>p__1;

			// Token: 0x040037D6 RID: 14294
			public static CallSite<Func<CallSite, object, string, object>> <>p__2;

			// Token: 0x040037D7 RID: 14295
			public static CallSite<Func<CallSite, object, object, object>> <>p__3;

			// Token: 0x040037D8 RID: 14296
			public static CallSite<Func<CallSite, System.Type, object, object>> <>p__4;

			// Token: 0x040037D9 RID: 14297
			public static CallSite<Action<CallSite, QueryInfo, string, object>> <>p__5;

			// Token: 0x040037DA RID: 14298
			public static CallSite<Func<CallSite, object, object>> <>p__6;

			// Token: 0x040037DB RID: 14299
			public static CallSite<Func<CallSite, object, object>> <>p__7;

			// Token: 0x040037DC RID: 14300
			public static CallSite<Func<CallSite, object, object, object>> <>p__8;

			// Token: 0x040037DD RID: 14301
			public static CallSite<Func<CallSite, System.Type, object, object>> <>p__9;

			// Token: 0x040037DE RID: 14302
			public static CallSite<Action<CallSite, QueryInfo, string, object>> <>p__10;
		}

		// Token: 0x02000BC8 RID: 3016
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005465 RID: 21605 RVA: 0x0016AF48 File Offset: 0x00169148
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06005466 RID: 21606 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06005467 RID: 21607 RVA: 0x0016AF60 File Offset: 0x00169160
			internal bool <Stats>b__7_0(string row)
			{
				return !string.IsNullOrEmpty(row);
			}

			// Token: 0x06005468 RID: 21608 RVA: 0x0016AF78 File Offset: 0x00169178
			internal AscCDR <Stats>b__7_1(string row)
			{
				return MangoVPBXClient.FromCsv(row);
			}

			// Token: 0x040037DF RID: 14303
			public static readonly MangoVPBXClient.<>c <>9 = new MangoVPBXClient.<>c();

			// Token: 0x040037E0 RID: 14304
			public static Func<string, bool> <>9__7_0;

			// Token: 0x040037E1 RID: 14305
			public static Func<string, AscCDR> <>9__7_1;
		}

		// Token: 0x02000BC9 RID: 3017
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Stats>d__7 : IAsyncStateMachine
		{
			// Token: 0x06005469 RID: 21609 RVA: 0x0016AF8C File Offset: 0x0016918C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				MangoVPBXClient mangoVPBXClient = this.<>4__this;
				IEnumerable<IAscCDR> result3;
				try
				{
					object obj;
					TaskAwaiter<object> awaiter;
					if (num != 0)
					{
						if (num - 1 <= 1)
						{
							goto IL_4FE;
						}
						this.<output>5__2 = new List<IAscCDR>();
						this.<queryInfo>5__3 = new QueryInfo();
						obj = new JObject();
						if (MangoVPBXClient.<>o__7.<>p__0 == null)
						{
							MangoVPBXClient.<>o__7.<>p__0 = CallSite<Func<CallSite, object, long, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "date_from", typeof(MangoVPBXClient), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
							}));
						}
						MangoVPBXClient.<>o__7.<>p__0.Target(MangoVPBXClient.<>o__7.<>p__0, obj, this.period.From.Date.ToUnixTimestamp());
						if (MangoVPBXClient.<>o__7.<>p__1 == null)
						{
							MangoVPBXClient.<>o__7.<>p__1 = CallSite<Func<CallSite, object, long, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "date_to", typeof(MangoVPBXClient), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
							}));
						}
						MangoVPBXClient.<>o__7.<>p__1.Target(MangoVPBXClient.<>o__7.<>p__1, obj, this.period.To.Date.AddDays(1.0).AddSeconds(-1.0).ToUnixTimestamp());
						if (!string.IsNullOrEmpty(this.callParty))
						{
							object obj2 = new JObject();
							if (MangoVPBXClient.<>o__7.<>p__2 == null)
							{
								MangoVPBXClient.<>o__7.<>p__2 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "number", typeof(MangoVPBXClient), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
								}));
							}
							MangoVPBXClient.<>o__7.<>p__2.Target(MangoVPBXClient.<>o__7.<>p__2, obj2, this.callParty);
							if (MangoVPBXClient.<>o__7.<>p__3 == null)
							{
								MangoVPBXClient.<>o__7.<>p__3 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "call_party", typeof(MangoVPBXClient), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							MangoVPBXClient.<>o__7.<>p__3.Target(MangoVPBXClient.<>o__7.<>p__3, obj, obj2);
						}
						if (MangoVPBXClient.<>o__7.<>p__5 == null)
						{
							MangoVPBXClient.<>o__7.<>p__5 = CallSite<Action<CallSite, QueryInfo, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Add", null, typeof(MangoVPBXClient), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Action<CallSite, QueryInfo, string, object> target = MangoVPBXClient.<>o__7.<>p__5.Target;
						CallSite <>p__ = MangoVPBXClient.<>o__7.<>p__5;
						QueryInfo arg = this.<queryInfo>5__3;
						string arg2 = "json";
						if (MangoVPBXClient.<>o__7.<>p__4 == null)
						{
							MangoVPBXClient.<>o__7.<>p__4 = CallSite<Func<CallSite, System.Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "SerializeObject", null, typeof(MangoVPBXClient), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						target(<>p__, arg, arg2, MangoVPBXClient.<>o__7.<>p__4.Target(MangoVPBXClient.<>o__7.<>p__4, typeof(JsonConvert), obj));
						awaiter = mangoVPBXClient.ProcessPostRequest<object>("/stats/request", this.<queryInfo>5__3).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							goto IL_66A;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<object>);
						int num2 = -1;
						num = -1;
						this.<>1__state = num2;
					}
					object result = awaiter.GetResult();
					Thread.Sleep(300);
					this.<queryInfo>5__3.Parameters.Clear();
					obj = new JObject();
					if (MangoVPBXClient.<>o__7.<>p__8 == null)
					{
						MangoVPBXClient.<>o__7.<>p__8 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "key", typeof(MangoVPBXClient), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, object, object> target2 = MangoVPBXClient.<>o__7.<>p__8.Target;
					CallSite <>p__2 = MangoVPBXClient.<>o__7.<>p__8;
					object arg3 = obj;
					if (MangoVPBXClient.<>o__7.<>p__7 == null)
					{
						MangoVPBXClient.<>o__7.<>p__7 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(MangoVPBXClient), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, object> target3 = MangoVPBXClient.<>o__7.<>p__7.Target;
					CallSite <>p__3 = MangoVPBXClient.<>o__7.<>p__7;
					if (MangoVPBXClient.<>o__7.<>p__6 == null)
					{
						MangoVPBXClient.<>o__7.<>p__6 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "key", typeof(MangoVPBXClient), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					target2(<>p__2, arg3, target3(<>p__3, MangoVPBXClient.<>o__7.<>p__6.Target(MangoVPBXClient.<>o__7.<>p__6, result)));
					if (MangoVPBXClient.<>o__7.<>p__10 == null)
					{
						MangoVPBXClient.<>o__7.<>p__10 = CallSite<Action<CallSite, QueryInfo, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Add", null, typeof(MangoVPBXClient), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Action<CallSite, QueryInfo, string, object> target4 = MangoVPBXClient.<>o__7.<>p__10.Target;
					CallSite <>p__4 = MangoVPBXClient.<>o__7.<>p__10;
					QueryInfo arg4 = this.<queryInfo>5__3;
					string arg5 = "json";
					if (MangoVPBXClient.<>o__7.<>p__9 == null)
					{
						MangoVPBXClient.<>o__7.<>p__9 = CallSite<Func<CallSite, System.Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "SerializeObject", null, typeof(MangoVPBXClient), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					target4(<>p__4, arg4, arg5, MangoVPBXClient.<>o__7.<>p__9.Target(MangoVPBXClient.<>o__7.<>p__9, typeof(JsonConvert), obj));
					IL_4FE:
					try
					{
						TaskAwaiter<string> awaiter2;
						ConfiguredTaskAwaitable<HttpWebResponse>.ConfiguredTaskAwaiter awaiter3;
						if (num != 1)
						{
							if (num == 2)
							{
								awaiter2 = this.<>u__3;
								this.<>u__3 = default(TaskAwaiter<string>);
								this.<>1__state = -1;
								goto IL_5B6;
							}
							awaiter3 = mangoVPBXClient.CreatePostRequest("/stats/result", this.<queryInfo>5__3).GetResponse().ConfigureAwait(false).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								this.<>1__state = 1;
								this.<>u__2 = awaiter3;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<HttpWebResponse>.ConfiguredTaskAwaiter, MangoVPBXClient.<Stats>d__7>(ref awaiter3, ref this);
								return;
							}
						}
						else
						{
							awaiter3 = this.<>u__2;
							this.<>u__2 = default(ConfiguredTaskAwaitable<HttpWebResponse>.ConfiguredTaskAwaiter);
							this.<>1__state = -1;
						}
						awaiter2 = awaiter3.GetResult().Content().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 2;
							this.<>u__3 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, MangoVPBXClient.<Stats>d__7>(ref awaiter2, ref this);
							return;
						}
						IL_5B6:
						string result2 = awaiter2.GetResult();
						if (!string.IsNullOrEmpty(result2))
						{
							this.<output>5__2.AddRange(result2.Split(new char[]
							{
								'\n'
							}).Where(new Func<string, bool>(MangoVPBXClient.<>c.<>9.<Stats>b__7_0)).Select(new Func<string, AscCDR>(MangoVPBXClient.<>c.<>9.<Stats>b__7_1)));
							result3 = this.<output>5__2;
							goto IL_6B2;
						}
						result3 = this.<output>5__2;
						goto IL_6B2;
					}
					catch (Exception)
					{
						result3 = this.<output>5__2;
						goto IL_6B2;
					}
					IL_66A:
					this.<>1__state = 0;
					this.<>u__1 = awaiter;
					this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, MangoVPBXClient.<Stats>d__7>(ref awaiter, ref this);
					return;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<output>5__2 = null;
					this.<queryInfo>5__3 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_6B2:
				this.<>1__state = -2;
				this.<output>5__2 = null;
				this.<queryInfo>5__3 = null;
				this.<>t__builder.SetResult(result3);
			}

			// Token: 0x0600546A RID: 21610 RVA: 0x0016B6A4 File Offset: 0x001698A4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040037E2 RID: 14306
			public int <>1__state;

			// Token: 0x040037E3 RID: 14307
			public AsyncTaskMethodBuilder<IEnumerable<IAscCDR>> <>t__builder;

			// Token: 0x040037E4 RID: 14308
			public IPeriod period;

			// Token: 0x040037E5 RID: 14309
			public string callParty;

			// Token: 0x040037E6 RID: 14310
			public MangoVPBXClient <>4__this;

			// Token: 0x040037E7 RID: 14311
			private List<IAscCDR> <output>5__2;

			// Token: 0x040037E8 RID: 14312
			private QueryInfo <queryInfo>5__3;

			// Token: 0x040037E9 RID: 14313
			private TaskAwaiter<object> <>u__1;

			// Token: 0x040037EA RID: 14314
			private ConfiguredTaskAwaitable<HttpWebResponse>.ConfiguredTaskAwaiter <>u__2;

			// Token: 0x040037EB RID: 14315
			private TaskAwaiter<string> <>u__3;
		}

		// Token: 0x02000BCA RID: 3018
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Recording>d__8 : IAsyncStateMachine
		{
			// Token: 0x0600546B RID: 21611 RVA: 0x0016B6C0 File Offset: 0x001698C0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				MangoVPBXClient mangoVPBXClient = this.<>4__this;
				RecordRequest result2;
				try
				{
					ConfiguredTaskAwaitable<HttpWebResponse>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						this.<result>5__2 = new RecordRequest();
						QueryInfo queryInfo = new QueryInfo();
						string value = JsonConvert.SerializeObject(new Dictionary<string, object>
						{
							{
								"recording_id",
								this.recordingId ?? ""
							},
							{
								"action",
								"download"
							}
						});
						queryInfo.Add("json", value);
						awaiter = mangoVPBXClient.CreatePostRequest("/queries/recording/post/", queryInfo).GetResponse().ConfigureAwait(false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<HttpWebResponse>.ConfiguredTaskAwaiter, MangoVPBXClient.<Recording>d__8>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(ConfiguredTaskAwaitable<HttpWebResponse>.ConfiguredTaskAwaiter);
						this.<>1__state = -1;
					}
					HttpWebResponse result = awaiter.GetResult();
					result.Headers.Get("Location");
					this.<result>5__2.Link = result.Headers.Get("Location");
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

			// Token: 0x0600546C RID: 21612 RVA: 0x0016B838 File Offset: 0x00169A38
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040037EC RID: 14316
			public int <>1__state;

			// Token: 0x040037ED RID: 14317
			public AsyncTaskMethodBuilder<RecordRequest> <>t__builder;

			// Token: 0x040037EE RID: 14318
			public string recordingId;

			// Token: 0x040037EF RID: 14319
			public MangoVPBXClient <>4__this;

			// Token: 0x040037F0 RID: 14320
			private RecordRequest <result>5__2;

			// Token: 0x040037F1 RID: 14321
			private ConfiguredTaskAwaitable<HttpWebResponse>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000BCB RID: 3019
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ProcessRequest>d__11<T> : IAsyncStateMachine
		{
			// Token: 0x0600546D RID: 21613 RVA: 0x0016B854 File Offset: 0x00169A54
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				T result;
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
							this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<HttpWebResponse>.ConfiguredTaskAwaiter, MangoVPBXClient.<ProcessRequest>d__11<T>>(ref awaiter2, ref this);
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
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, MangoVPBXClient.<ProcessRequest>d__11<T>>(ref awaiter, ref this);
						return;
					}
					IL_CF:
					result = JsonConvert.DeserializeObject<T>(awaiter.GetResult());
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

			// Token: 0x0600546E RID: 21614 RVA: 0x0016B97C File Offset: 0x00169B7C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040037F2 RID: 14322
			public int <>1__state;

			// Token: 0x040037F3 RID: 14323
			public AsyncTaskMethodBuilder<T> <>t__builder;

			// Token: 0x040037F4 RID: 14324
			public Request request;

			// Token: 0x040037F5 RID: 14325
			private ConfiguredTaskAwaitable<HttpWebResponse>.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x040037F6 RID: 14326
			private TaskAwaiter<string> <>u__2;
		}
	}
}
