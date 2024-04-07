using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Objects;
using ASC.Objects.Converters;

namespace ASC.Services
{
	// Token: 0x02000693 RID: 1683
	public class SmsService : ISmsService
	{
		// Token: 0x060038CB RID: 14539 RVA: 0x000CFB1C File Offset: 0x000CDD1C
		public Dictionary<int, string> GetDirections()
		{
			return new Dictionary<int, string>
			{
				{
					0,
					Lang.t("All")
				},
				{
					1,
					Lang.t("Incoming")
				},
				{
					2,
					Lang.t("Outcoming")
				}
			};
		}

		// Token: 0x060038CC RID: 14540 RVA: 0x000CFB64 File Offset: 0x000CDD64
		public Task<IEnumerable<IAscSms>> GetOutcoming(IPeriod period)
		{
			SmsService.<GetOutcoming>d__1 <GetOutcoming>d__;
			<GetOutcoming>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<IAscSms>>.Create();
			<GetOutcoming>d__.period = period;
			<GetOutcoming>d__.<>1__state = -1;
			<GetOutcoming>d__.<>t__builder.Start<SmsService.<GetOutcoming>d__1>(ref <GetOutcoming>d__);
			return <GetOutcoming>d__.<>t__builder.Task;
		}

		// Token: 0x060038CD RID: 14541 RVA: 0x000CFBA8 File Offset: 0x000CDDA8
		public Task<IEnumerable<IAscSms>> GetIncoming(IPeriod period)
		{
			SmsService.<GetIncoming>d__2 <GetIncoming>d__;
			<GetIncoming>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<IAscSms>>.Create();
			<GetIncoming>d__.period = period;
			<GetIncoming>d__.<>1__state = -1;
			<GetIncoming>d__.<>t__builder.Start<SmsService.<GetIncoming>d__2>(ref <GetIncoming>d__);
			return <GetIncoming>d__.<>t__builder.Task;
		}

		// Token: 0x060038CE RID: 14542 RVA: 0x000CFBEC File Offset: 0x000CDDEC
		public Task<IEnumerable<IAscSms>> LoadSmses(IPeriod period, SmsDirection direction)
		{
			SmsService.<LoadSmses>d__3 <LoadSmses>d__;
			<LoadSmses>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<IAscSms>>.Create();
			<LoadSmses>d__.<>4__this = this;
			<LoadSmses>d__.period = period;
			<LoadSmses>d__.direction = direction;
			<LoadSmses>d__.<>1__state = -1;
			<LoadSmses>d__.<>t__builder.Start<SmsService.<LoadSmses>d__3>(ref <LoadSmses>d__);
			return <LoadSmses>d__.<>t__builder.Task;
		}

		// Token: 0x060038CF RID: 14543 RVA: 0x000CFC40 File Offset: 0x000CDE40
		public Task<List<sms_templates>> GetTemplates()
		{
			SmsService.<GetTemplates>d__4 <GetTemplates>d__;
			<GetTemplates>d__.<>t__builder = AsyncTaskMethodBuilder<List<sms_templates>>.Create();
			<GetTemplates>d__.<>1__state = -1;
			<GetTemplates>d__.<>t__builder.Start<SmsService.<GetTemplates>d__4>(ref <GetTemplates>d__);
			return <GetTemplates>d__.<>t__builder.Task;
		}

		// Token: 0x060038D0 RID: 14544 RVA: 0x000CFC7C File Offset: 0x000CDE7C
		public Task<string> ConstructSms(string rawMsg, int repairId, string customerIoOrUrName)
		{
			SmsService.<ConstructSms>d__5 <ConstructSms>d__;
			<ConstructSms>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<ConstructSms>d__.rawMsg = rawMsg;
			<ConstructSms>d__.repairId = repairId;
			<ConstructSms>d__.customerIoOrUrName = customerIoOrUrName;
			<ConstructSms>d__.<>1__state = -1;
			<ConstructSms>d__.<>t__builder.Start<SmsService.<ConstructSms>d__5>(ref <ConstructSms>d__);
			return <ConstructSms>d__.<>t__builder.Task;
		}

		// Token: 0x060038D1 RID: 14545 RVA: 0x000CFCD0 File Offset: 0x000CDED0
		public void SaveSmsToDb(int? customerId, string phone, string message, int? statusCode = null, string smsId = null)
		{
			using (auseceEntities auseceEntities = new auseceEntities(true))
			{
				Localization localization = new Localization("UTC");
				out_sms entity = new out_sms
				{
					state = 1,
					created = localization.Now,
					user = Auth.User.id,
					client = customerId,
					msg = message,
					phone = phone,
					service = 1,
					status_code = statusCode,
					sms_id = (smsId ?? "")
				};
				auseceEntities.out_sms.Add(entity);
				auseceEntities.SaveChanges();
				if (customerId != null)
				{
					HistoryV2 historyV = new HistoryV2();
					historyV.AddClientCardLog("SmsSended", customerId.Value, message, null);
					historyV.Save();
				}
			}
		}

		// Token: 0x060038D2 RID: 14546 RVA: 0x000CFDA4 File Offset: 0x000CDFA4
		public Dictionary<int, string> GetSmsGateways()
		{
			return new Dictionary<int, string>
			{
				{
					1,
					"SMS.RU"
				},
				{
					2,
					"EpochtaSms"
				},
				{
					3,
					"СМС-центр"
				}
			};
		}

		// Token: 0x060038D3 RID: 14547 RVA: 0x000046B4 File Offset: 0x000028B4
		public SmsService()
		{
		}

		// Token: 0x02000694 RID: 1684
		[CompilerGenerated]
		private sealed class <>c__DisplayClass1_0
		{
			// Token: 0x060038D4 RID: 14548 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass1_0()
			{
			}

			// Token: 0x040022B9 RID: 8889
			public DateTime from;

			// Token: 0x040022BA RID: 8890
			public DateTime to;
		}

		// Token: 0x02000695 RID: 1685
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060038D5 RID: 14549 RVA: 0x000CFDDC File Offset: 0x000CDFDC
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060038D6 RID: 14550 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x060038D7 RID: 14551 RVA: 0x000CFDF4 File Offset: 0x000CDFF4
			internal AscSms <GetOutcoming>b__1_0(out_sms m)
			{
				return m.ToAscSms();
			}

			// Token: 0x060038D8 RID: 14552 RVA: 0x000CFE08 File Offset: 0x000CE008
			internal DateTime <GetOutcoming>b__1_1(AscSms m)
			{
				return m.Date;
			}

			// Token: 0x060038D9 RID: 14553 RVA: 0x000CFE1C File Offset: 0x000CE01C
			internal AscSms <GetIncoming>b__2_0(in_sms m)
			{
				return m.ToAscSms();
			}

			// Token: 0x060038DA RID: 14554 RVA: 0x000CFE08 File Offset: 0x000CE008
			internal DateTime <GetIncoming>b__2_1(AscSms m)
			{
				return m.Date;
			}

			// Token: 0x060038DB RID: 14555 RVA: 0x000CFE30 File Offset: 0x000CE030
			internal DateTime <LoadSmses>b__3_0(IAscSms m)
			{
				return m.Date;
			}

			// Token: 0x040022BB RID: 8891
			public static readonly SmsService.<>c <>9 = new SmsService.<>c();

			// Token: 0x040022BC RID: 8892
			public static Func<out_sms, AscSms> <>9__1_0;

			// Token: 0x040022BD RID: 8893
			public static Func<AscSms, DateTime> <>9__1_1;

			// Token: 0x040022BE RID: 8894
			public static Func<in_sms, AscSms> <>9__2_0;

			// Token: 0x040022BF RID: 8895
			public static Func<AscSms, DateTime> <>9__2_1;

			// Token: 0x040022C0 RID: 8896
			public static Func<IAscSms, DateTime> <>9__3_0;
		}

		// Token: 0x02000696 RID: 1686
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetOutcoming>d__1 : IAsyncStateMachine
		{
			// Token: 0x060038DC RID: 14556 RVA: 0x000CFE44 File Offset: 0x000CE044
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IEnumerable<IAscSms> result;
				try
				{
					SmsService.<>c__DisplayClass1_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new SmsService.<>c__DisplayClass1_0();
						CS$<>8__locals1.from = this.period.From.Date;
						CS$<>8__locals1.to = this.period.To.Date.AddDays(1.0).AddSeconds(-1.0);
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						ConfiguredTaskAwaitable<List<out_sms>>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = (from m in this.<ctx>5__2.out_sms.AsNoTracking().Include((out_sms m) => m.clients)
							where m.created >= CS$<>8__locals1.@from && m.created <= CS$<>8__locals1.to
							select m).ToListAsync<out_sms>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<List<out_sms>>.ConfiguredTaskAwaiter, SmsService.<GetOutcoming>d__1>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<List<out_sms>>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult().Select(new Func<out_sms, AscSms>(SmsService.<>c.<>9.<GetOutcoming>b__1_0)).OrderByDescending(new Func<AscSms, DateTime>(SmsService.<>c.<>9.<GetOutcoming>b__1_1)).ToList<AscSms>();
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

			// Token: 0x060038DD RID: 14557 RVA: 0x000D0110 File Offset: 0x000CE310
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040022C1 RID: 8897
			public int <>1__state;

			// Token: 0x040022C2 RID: 8898
			public AsyncTaskMethodBuilder<IEnumerable<IAscSms>> <>t__builder;

			// Token: 0x040022C3 RID: 8899
			public IPeriod period;

			// Token: 0x040022C4 RID: 8900
			private auseceEntities <ctx>5__2;

			// Token: 0x040022C5 RID: 8901
			private ConfiguredTaskAwaitable<List<out_sms>>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000697 RID: 1687
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x060038DE RID: 14558 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x040022C6 RID: 8902
			public DateTime from;

			// Token: 0x040022C7 RID: 8903
			public DateTime to;
		}

		// Token: 0x02000698 RID: 1688
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetIncoming>d__2 : IAsyncStateMachine
		{
			// Token: 0x060038DF RID: 14559 RVA: 0x000D012C File Offset: 0x000CE32C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IEnumerable<IAscSms> result;
				try
				{
					SmsService.<>c__DisplayClass2_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new SmsService.<>c__DisplayClass2_0();
						CS$<>8__locals1.from = this.period.From.Date;
						CS$<>8__locals1.to = this.period.To.Date.AddDays(1.0).AddSeconds(-1.0);
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						ConfiguredTaskAwaitable<List<in_sms>>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = (from m in this.<ctx>5__2.in_sms.AsNoTracking()
							where m.date >= CS$<>8__locals1.@from && m.date <= CS$<>8__locals1.to
							select m).ToListAsync<in_sms>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<List<in_sms>>.ConfiguredTaskAwaiter, SmsService.<GetIncoming>d__2>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<List<in_sms>>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult().Select(new Func<in_sms, AscSms>(SmsService.<>c.<>9.<GetIncoming>b__2_0)).OrderByDescending(new Func<AscSms, DateTime>(SmsService.<>c.<>9.<GetIncoming>b__2_1)).ToList<AscSms>();
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

			// Token: 0x060038E0 RID: 14560 RVA: 0x000D03B4 File Offset: 0x000CE5B4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040022C8 RID: 8904
			public int <>1__state;

			// Token: 0x040022C9 RID: 8905
			public AsyncTaskMethodBuilder<IEnumerable<IAscSms>> <>t__builder;

			// Token: 0x040022CA RID: 8906
			public IPeriod period;

			// Token: 0x040022CB RID: 8907
			private auseceEntities <ctx>5__2;

			// Token: 0x040022CC RID: 8908
			private ConfiguredTaskAwaitable<List<in_sms>>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000699 RID: 1689
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadSmses>d__3 : IAsyncStateMachine
		{
			// Token: 0x060038E1 RID: 14561 RVA: 0x000D03D0 File Offset: 0x000CE5D0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				SmsService smsService = this.<>4__this;
				IEnumerable<IAscSms> result;
				try
				{
					TaskAwaiter<IEnumerable<IAscSms>> awaiter;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<IAscSms>>);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<IAscSms>>);
						this.<>1__state = -1;
						goto IL_1A8;
					case 2:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<IAscSms>>);
						this.<>1__state = -1;
						goto IL_21C;
					case 3:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<IAscSms>>);
						this.<>1__state = -1;
						goto IL_243;
					default:
						if (this.direction == SmsDirection.All)
						{
							this.<result>5__2 = new List<IAscSms>();
							awaiter = smsService.GetIncoming(this.period).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<IAscSms>>, SmsService.<LoadSmses>d__3>(ref awaiter, ref this);
								return;
							}
						}
						else if (this.direction != SmsDirection.Incoming)
						{
							if (this.direction != SmsDirection.Outcoming)
							{
								result = new List<IAscSms>();
								goto IL_266;
							}
							awaiter = smsService.GetOutcoming(this.period).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 3;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<IAscSms>>, SmsService.<LoadSmses>d__3>(ref awaiter, ref this);
								return;
							}
							goto IL_243;
						}
						else
						{
							awaiter = smsService.GetIncoming(this.period).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<IAscSms>>, SmsService.<LoadSmses>d__3>(ref awaiter, ref this);
								return;
							}
							goto IL_21C;
						}
						break;
					}
					IEnumerable<IAscSms> result2 = awaiter.GetResult();
					this.<incoming>5__3 = result2;
					awaiter = smsService.GetOutcoming(this.period).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<IAscSms>>, SmsService.<LoadSmses>d__3>(ref awaiter, ref this);
						return;
					}
					IL_1A8:
					IEnumerable<IAscSms> result3 = awaiter.GetResult();
					this.<result>5__2.AddRange(this.<incoming>5__3);
					this.<result>5__2.AddRange(result3);
					result = this.<result>5__2.OrderByDescending(new Func<IAscSms, DateTime>(SmsService.<>c.<>9.<LoadSmses>b__3_0)).ToList<IAscSms>();
					goto IL_266;
					IL_21C:
					result = awaiter.GetResult();
					goto IL_266;
					IL_243:
					result = awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_266:
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x060038E2 RID: 14562 RVA: 0x000D0674 File Offset: 0x000CE874
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040022CD RID: 8909
			public int <>1__state;

			// Token: 0x040022CE RID: 8910
			public AsyncTaskMethodBuilder<IEnumerable<IAscSms>> <>t__builder;

			// Token: 0x040022CF RID: 8911
			public SmsDirection direction;

			// Token: 0x040022D0 RID: 8912
			public SmsService <>4__this;

			// Token: 0x040022D1 RID: 8913
			public IPeriod period;

			// Token: 0x040022D2 RID: 8914
			private List<IAscSms> <result>5__2;

			// Token: 0x040022D3 RID: 8915
			private IEnumerable<IAscSms> <incoming>5__3;

			// Token: 0x040022D4 RID: 8916
			private TaskAwaiter<IEnumerable<IAscSms>> <>u__1;
		}

		// Token: 0x0200069A RID: 1690
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetTemplates>d__4 : IAsyncStateMachine
		{
			// Token: 0x060038E3 RID: 14563 RVA: 0x000D0690 File Offset: 0x000CE890
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<sms_templates> result;
				try
				{
					if (num != 0)
					{
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						ConfiguredTaskAwaitable<List<sms_templates>>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = (from i in this.<ctx>5__2.sms_templates.AsNoTracking()
							orderby i.name
							select i).ToListAsync<sms_templates>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<List<sms_templates>>.ConfiguredTaskAwaiter, SmsService.<GetTemplates>d__4>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<List<sms_templates>>.ConfiguredTaskAwaiter);
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

			// Token: 0x060038E4 RID: 14564 RVA: 0x000D07D0 File Offset: 0x000CE9D0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040022D5 RID: 8917
			public int <>1__state;

			// Token: 0x040022D6 RID: 8918
			public AsyncTaskMethodBuilder<List<sms_templates>> <>t__builder;

			// Token: 0x040022D7 RID: 8919
			private auseceEntities <ctx>5__2;

			// Token: 0x040022D8 RID: 8920
			private ConfiguredTaskAwaitable<List<sms_templates>>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x0200069B RID: 1691
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x060038E5 RID: 14565 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x040022D9 RID: 8921
			public int repairId;
		}

		// Token: 0x0200069C RID: 1692
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ConstructSms>d__5 : IAsyncStateMachine
		{
			// Token: 0x060038E6 RID: 14566 RVA: 0x000D07EC File Offset: 0x000CE9EC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				string result2;
				try
				{
					SmsService.<>c__DisplayClass5_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new SmsService.<>c__DisplayClass5_0();
						CS$<>8__locals1.repairId = this.repairId;
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<workshop> awaiter;
						if (num != 0)
						{
							awaiter = this.<ctx>5__2.workshop.AsNoTracking().Include((workshop i) => i.offices).Include((workshop i) => i.offices1).Include((workshop i) => i.devices).Include((workshop i) => i.device_makers).Include((workshop i) => i.device_models).SingleAsync((workshop i) => i.id == CS$<>8__locals1.repairId).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop>, SmsService.<ConstructSms>d__5>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<workshop>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						workshop result = awaiter.GetResult();
						string newValue = (result.offices1 == null) ? "" : result.offices1.address;
						string newValue2 = (result.offices1 == null) ? "" : result.offices1.phone;
						string newValue3 = (result.offices == null) ? "" : result.offices.address;
						string newValue4 = (result.offices == null) ? "" : result.offices.phone;
						result2 = this.rawMsg.Replace("{REP}", result.id.ToString("D6")).Replace("{REPSHORT}", result.id.ToString()).Replace("{SUMM}", result.real_repair_cost.ToString("N0")).Replace("{DSUMM}", result.repair_cost.ToString("N0")).Replace("{CLIENT}", this.customerIoOrUrName).Replace("{DEVICE}", result.devices.name.ToLower()).Replace("{MAKER}", result.device_makers.name).Replace("{MODEL}", result.device_models.name).Replace("{DIAGRESULT}", result.diagnostic_result).Replace("{OFFICEPHONE}", newValue2).Replace("{OFFICEADDRESS}", newValue).Replace("{CURRENTOFFICEPHONE}", newValue4).Replace("{CURRENTOFFICEADDRESS}", newValue3);
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

			// Token: 0x060038E7 RID: 14567 RVA: 0x000D0C34 File Offset: 0x000CEE34
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040022DA RID: 8922
			public int <>1__state;

			// Token: 0x040022DB RID: 8923
			public AsyncTaskMethodBuilder<string> <>t__builder;

			// Token: 0x040022DC RID: 8924
			public int repairId;

			// Token: 0x040022DD RID: 8925
			public string rawMsg;

			// Token: 0x040022DE RID: 8926
			public string customerIoOrUrName;

			// Token: 0x040022DF RID: 8927
			private auseceEntities <ctx>5__2;

			// Token: 0x040022E0 RID: 8928
			private TaskAwaiter<workshop> <>u__1;
		}
	}
}
