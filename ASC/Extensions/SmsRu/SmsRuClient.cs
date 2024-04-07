using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Phone;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.SimpleClasses;
using Autofac;
using SmsRu;
using SmsRu.Enumerations;

namespace ASC.Extensions.SmsRu
{
	// Token: 0x02000B7C RID: 2940
	public class SmsRuClient : ISmsClient
	{
		// Token: 0x17001501 RID: 5377
		// (get) Token: 0x06005213 RID: 21011 RVA: 0x00160A3C File Offset: 0x0015EC3C
		// (set) Token: 0x06005214 RID: 21012 RVA: 0x00160A50 File Offset: 0x0015EC50
		private string Username
		{
			[CompilerGenerated]
			get
			{
				return this.<Username>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Username>k__BackingField = value;
			}
		}

		// Token: 0x17001502 RID: 5378
		// (get) Token: 0x06005215 RID: 21013 RVA: 0x00160A64 File Offset: 0x0015EC64
		// (set) Token: 0x06005216 RID: 21014 RVA: 0x00160A78 File Offset: 0x0015EC78
		private string Password
		{
			[CompilerGenerated]
			get
			{
				return this.<Password>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Password>k__BackingField = value;
			}
		}

		// Token: 0x17001503 RID: 5379
		// (get) Token: 0x06005217 RID: 21015 RVA: 0x00160A8C File Offset: 0x0015EC8C
		// (set) Token: 0x06005218 RID: 21016 RVA: 0x00160AA0 File Offset: 0x0015ECA0
		private string ApiId
		{
			[CompilerGenerated]
			get
			{
				return this.<ApiId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ApiId>k__BackingField = value;
			}
		}

		// Token: 0x17001504 RID: 5380
		// (get) Token: 0x06005219 RID: 21017 RVA: 0x00160AB4 File Offset: 0x0015ECB4
		// (set) Token: 0x0600521A RID: 21018 RVA: 0x00160AC8 File Offset: 0x0015ECC8
		private string Sender
		{
			[CompilerGenerated]
			get
			{
				return this.<Sender>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Sender>k__BackingField = value;
			}
		}

		// Token: 0x0600521B RID: 21019 RVA: 0x00160ADC File Offset: 0x0015ECDC
		public SmsRuClient(SmsClientConfig config)
		{
			this.SmsService = Bootstrapper.Container.Resolve<ISmsService>();
			this.Username = config.Login;
			this.Password = config.Password;
			this.ApiId = config.ApiId;
			this.Sender = config.Sender;
		}

		// Token: 0x0600521C RID: 21020 RVA: 0x00160B30 File Offset: 0x0015ED30
		public Task<bool> SendAsync(string phone, string message, int? customerId)
		{
			SmsRuClient.<SendAsync>d__18 <SendAsync>d__;
			<SendAsync>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<SendAsync>d__.<>4__this = this;
			<SendAsync>d__.phone = phone;
			<SendAsync>d__.message = message;
			<SendAsync>d__.customerId = customerId;
			<SendAsync>d__.<>1__state = -1;
			<SendAsync>d__.<>t__builder.Start<SmsRuClient.<SendAsync>d__18>(ref <SendAsync>d__);
			return <SendAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600521D RID: 21021 RVA: 0x00160B8C File Offset: 0x0015ED8C
		public Task SendAsync(int repairId, int customerId, int templateId)
		{
			SmsRuClient.<SendAsync>d__19 <SendAsync>d__;
			<SendAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<SendAsync>d__.<>4__this = this;
			<SendAsync>d__.repairId = repairId;
			<SendAsync>d__.customerId = customerId;
			<SendAsync>d__.templateId = templateId;
			<SendAsync>d__.<>1__state = -1;
			<SendAsync>d__.<>t__builder.Start<SmsRuClient.<SendAsync>d__19>(ref <SendAsync>d__);
			return <SendAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600521E RID: 21022 RVA: 0x00160BE8 File Offset: 0x0015EDE8
		public Task<string> BalanceAsync()
		{
			SmsRuClient.<BalanceAsync>d__20 <BalanceAsync>d__;
			<BalanceAsync>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<BalanceAsync>d__.<>4__this = this;
			<BalanceAsync>d__.<>1__state = -1;
			<BalanceAsync>d__.<>t__builder.Start<SmsRuClient.<BalanceAsync>d__20>(ref <BalanceAsync>d__);
			return <BalanceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600521F RID: 21023 RVA: 0x00160C2C File Offset: 0x0015EE2C
		[CompilerGenerated]
		private string <BalanceAsync>b__20_0()
		{
			string[] array = new SmsRuProvider(this.Username, this.Password, this.ApiId).CheckBalance(EnumAuthenticationTypes.Simple).Split(new char[]
			{
				'\n'
			});
			if (array.Length == 0)
			{
				return "Err";
			}
			if (array.Length > 1)
			{
				return array[1];
			}
			return "Err";
		}

		// Token: 0x040035D1 RID: 13777
		[CompilerGenerated]
		private string <Username>k__BackingField;

		// Token: 0x040035D2 RID: 13778
		[CompilerGenerated]
		private string <Password>k__BackingField;

		// Token: 0x040035D3 RID: 13779
		[CompilerGenerated]
		private string <ApiId>k__BackingField;

		// Token: 0x040035D4 RID: 13780
		[CompilerGenerated]
		private string <Sender>k__BackingField;

		// Token: 0x040035D5 RID: 13781
		protected ISmsService SmsService;

		// Token: 0x02000B7D RID: 2941
		[CompilerGenerated]
		private sealed class <>c__DisplayClass18_0
		{
			// Token: 0x06005220 RID: 21024 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass18_0()
			{
			}

			// Token: 0x06005221 RID: 21025 RVA: 0x00160C80 File Offset: 0x0015EE80
			internal bool <SendAsync>b__0()
			{
				SmsRuProvider smsRuProvider = new SmsRuProvider(this.<>4__this.Username, this.<>4__this.Password, this.<>4__this.ApiId);
				bool result;
				try
				{
					this.phone = Phone.ClearPhoneString(this.phone);
					string[] array = smsRuProvider.Send(this.<>4__this.Sender, this.phone, this.message, EnumAuthenticationTypes.Simple).Split(new char[]
					{
						'\n'
					});
					if (array.Length == 0)
					{
						result = false;
					}
					else
					{
						int num = Convert.ToInt32(array[0]);
						if (num == 100)
						{
							Bootstrapper.Container.Resolve<ISmsService>().SaveSmsToDb(this.customerId, this.phone, this.message, new int?(num), null);
						}
						result = (num == 100);
					}
				}
				catch (Exception)
				{
					result = false;
				}
				return result;
			}

			// Token: 0x040035D6 RID: 13782
			public SmsRuClient <>4__this;

			// Token: 0x040035D7 RID: 13783
			public string phone;

			// Token: 0x040035D8 RID: 13784
			public string message;

			// Token: 0x040035D9 RID: 13785
			public int? customerId;
		}

		// Token: 0x02000B7E RID: 2942
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SendAsync>d__18 : IAsyncStateMachine
		{
			// Token: 0x06005222 RID: 21026 RVA: 0x00160D50 File Offset: 0x0015EF50
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				bool result;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						awaiter = Task.Run<bool>(new Func<bool>(new SmsRuClient.<>c__DisplayClass18_0
						{
							<>4__this = this.<>4__this,
							phone = this.phone,
							message = this.message,
							customerId = this.customerId
						}.<SendAsync>b__0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, SmsRuClient.<SendAsync>d__18>(ref awaiter, ref this);
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

			// Token: 0x06005223 RID: 21027 RVA: 0x00160E3C File Offset: 0x0015F03C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040035DA RID: 13786
			public int <>1__state;

			// Token: 0x040035DB RID: 13787
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x040035DC RID: 13788
			public SmsRuClient <>4__this;

			// Token: 0x040035DD RID: 13789
			public string phone;

			// Token: 0x040035DE RID: 13790
			public string message;

			// Token: 0x040035DF RID: 13791
			public int? customerId;

			// Token: 0x040035E0 RID: 13792
			private TaskAwaiter<bool> <>u__1;
		}

		// Token: 0x02000B7F RID: 2943
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005224 RID: 21028 RVA: 0x00160E58 File Offset: 0x0015F058
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06005225 RID: 21029 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06005226 RID: 21030 RVA: 0x00160E70 File Offset: 0x0015F070
			internal bool <SendAsync>b__19_0(Tel p)
			{
				return p.Type == 1 && p.Notify;
			}

			// Token: 0x040035E1 RID: 13793
			public static readonly SmsRuClient.<>c <>9 = new SmsRuClient.<>c();

			// Token: 0x040035E2 RID: 13794
			public static Func<Tel, bool> <>9__19_0;
		}

		// Token: 0x02000B80 RID: 2944
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SendAsync>d__19 : IAsyncStateMachine
		{
			// Token: 0x06005227 RID: 21031 RVA: 0x00160E90 File Offset: 0x0015F090
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				SmsRuClient smsRuClient = this.<>4__this;
				try
				{
					TaskAwaiter<CustomerCard> awaiter;
					if (num != 0)
					{
						if (num - 1 <= 1)
						{
							goto IL_B0;
						}
						this.<rawMsg>5__2 = SmsModel.GetTemplateById(this.templateId);
						if (string.IsNullOrEmpty(this.<rawMsg>5__2))
						{
							goto IL_211;
						}
						awaiter = ClientsModel.GetCustomerCard(this.customerId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<CustomerCard>, SmsRuClient.<SendAsync>d__19>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<CustomerCard>);
						int num2 = -1;
						num = -1;
						this.<>1__state = num2;
					}
					CustomerCard result = awaiter.GetResult();
					this.<customer>5__3 = result;
					if (this.<customer>5__3 == null)
					{
						goto IL_211;
					}
					IL_B0:
					try
					{
						TaskAwaiter<bool> awaiter2;
						TaskAwaiter<string> awaiter3;
						if (num != 1)
						{
							if (num == 2)
							{
								awaiter2 = this.<>u__3;
								this.<>u__3 = default(TaskAwaiter<bool>);
								this.<>1__state = -1;
								goto IL_1B6;
							}
							awaiter3 = smsRuClient.SmsService.ConstructSms(this.<rawMsg>5__2, this.repairId, this.<customer>5__3.IoOrUrName).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								this.<>1__state = 1;
								this.<>u__2 = awaiter3;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, SmsRuClient.<SendAsync>d__19>(ref awaiter3, ref this);
								return;
							}
						}
						else
						{
							awaiter3 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<string>);
							this.<>1__state = -1;
						}
						string result2 = awaiter3.GetResult();
						Tel tel = this.<customer>5__3.Phones.FirstOrDefault(new Func<Tel, bool>(SmsRuClient.<>c.<>9.<SendAsync>b__19_0));
						if (tel == null)
						{
							goto IL_211;
						}
						awaiter2 = smsRuClient.SendAsync(tel.PhoneClean, result2, new int?(this.customerId)).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 2;
							this.<>u__3 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, SmsRuClient.<SendAsync>d__19>(ref awaiter2, ref this);
							return;
						}
						IL_1B6:
						awaiter2.GetResult();
					}
					catch (Exception)
					{
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<rawMsg>5__2 = null;
					this.<customer>5__3 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_211:
				this.<>1__state = -2;
				this.<rawMsg>5__2 = null;
				this.<customer>5__3 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06005228 RID: 21032 RVA: 0x00161104 File Offset: 0x0015F304
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040035E3 RID: 13795
			public int <>1__state;

			// Token: 0x040035E4 RID: 13796
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040035E5 RID: 13797
			public int templateId;

			// Token: 0x040035E6 RID: 13798
			public int customerId;

			// Token: 0x040035E7 RID: 13799
			public SmsRuClient <>4__this;

			// Token: 0x040035E8 RID: 13800
			public int repairId;

			// Token: 0x040035E9 RID: 13801
			private string <rawMsg>5__2;

			// Token: 0x040035EA RID: 13802
			private CustomerCard <customer>5__3;

			// Token: 0x040035EB RID: 13803
			private TaskAwaiter<CustomerCard> <>u__1;

			// Token: 0x040035EC RID: 13804
			private TaskAwaiter<string> <>u__2;

			// Token: 0x040035ED RID: 13805
			private TaskAwaiter<bool> <>u__3;
		}

		// Token: 0x02000B81 RID: 2945
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <BalanceAsync>d__20 : IAsyncStateMachine
		{
			// Token: 0x06005229 RID: 21033 RVA: 0x00161120 File Offset: 0x0015F320
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				SmsRuClient @object = this.<>4__this;
				string result;
				try
				{
					TaskAwaiter<string> awaiter;
					if (num != 0)
					{
						awaiter = Task.Run<string>(delegate()
						{
							string[] array = new SmsRuProvider(base.Username, base.Password, base.ApiId).CheckBalance(EnumAuthenticationTypes.Simple).Split(new char[]
							{
								'\n'
							});
							if (array.Length == 0)
							{
								return "Err";
							}
							if (array.Length > 1)
							{
								return array[1];
							}
							return "Err";
						}).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, SmsRuClient.<BalanceAsync>d__20>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<string>);
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

			// Token: 0x0600522A RID: 21034 RVA: 0x001611E4 File Offset: 0x0015F3E4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040035EE RID: 13806
			public int <>1__state;

			// Token: 0x040035EF RID: 13807
			public AsyncTaskMethodBuilder<string> <>t__builder;

			// Token: 0x040035F0 RID: 13808
			public SmsRuClient <>4__this;

			// Token: 0x040035F1 RID: 13809
			private TaskAwaiter<string> <>u__1;
		}
	}
}
