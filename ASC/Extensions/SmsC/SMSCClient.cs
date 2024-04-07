using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Phone;
using ASC.Interfaces;
using ASC.Models;
using ASC.SimpleClasses;
using Autofac;

namespace ASC.Extensions.SmsC
{
	// Token: 0x02000BB2 RID: 2994
	internal class SMSCClient : ISmsClient
	{
		// Token: 0x0600540D RID: 21517 RVA: 0x001685F4 File Offset: 0x001667F4
		public SMSCClient(ISMSC smscClient)
		{
			this._smscClient = smscClient;
			SmsClientConfig smsClientConfig = SmsModel.GetSmsClientConfig();
			this._smscClient.SetLogin(smsClientConfig.Login);
			this._smscClient.SetPassword(smsClientConfig.Password);
			this._sender = smsClientConfig.Sender;
		}

		// Token: 0x0600540E RID: 21518 RVA: 0x00168644 File Offset: 0x00166844
		public Task<bool> SendAsync(string phone, string message, int? customerId)
		{
			SMSCClient.<SendAsync>d__3 <SendAsync>d__;
			<SendAsync>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<SendAsync>d__.<>4__this = this;
			<SendAsync>d__.phone = phone;
			<SendAsync>d__.message = message;
			<SendAsync>d__.customerId = customerId;
			<SendAsync>d__.<>1__state = -1;
			<SendAsync>d__.<>t__builder.Start<SMSCClient.<SendAsync>d__3>(ref <SendAsync>d__);
			return <SendAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600540F RID: 21519 RVA: 0x001686A0 File Offset: 0x001668A0
		public Task SendAsync(int repairId, int customerId, int templateId)
		{
			SMSCClient.<SendAsync>d__4 <SendAsync>d__;
			<SendAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<SendAsync>d__.<>4__this = this;
			<SendAsync>d__.repairId = repairId;
			<SendAsync>d__.customerId = customerId;
			<SendAsync>d__.templateId = templateId;
			<SendAsync>d__.<>1__state = -1;
			<SendAsync>d__.<>t__builder.Start<SMSCClient.<SendAsync>d__4>(ref <SendAsync>d__);
			return <SendAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06005410 RID: 21520 RVA: 0x001686FC File Offset: 0x001668FC
		public Task<string> BalanceAsync()
		{
			SMSCClient.<BalanceAsync>d__5 <BalanceAsync>d__;
			<BalanceAsync>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<BalanceAsync>d__.<>4__this = this;
			<BalanceAsync>d__.<>1__state = -1;
			<BalanceAsync>d__.<>t__builder.Start<SMSCClient.<BalanceAsync>d__5>(ref <BalanceAsync>d__);
			return <BalanceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06005411 RID: 21521 RVA: 0x00168740 File Offset: 0x00166940
		[CompilerGenerated]
		private string <BalanceAsync>b__5_0()
		{
			return this._smscClient.balance;
		}

		// Token: 0x04003756 RID: 14166
		private readonly ISMSC _smscClient;

		// Token: 0x04003757 RID: 14167
		private string _sender;

		// Token: 0x02000BB3 RID: 2995
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06005412 RID: 21522 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x06005413 RID: 21523 RVA: 0x00168758 File Offset: 0x00166958
			internal bool <SendAsync>b__0()
			{
				bool result;
				try
				{
					string id = this.<>4__this._smscClient.send_sms(this.phone, this.message, 0, "", 0, 0, this.<>4__this._sender, "", null)[0];
					string text = this.<>4__this._smscClient.get_status(id, this.phone, 0)[0];
					Bootstrapper.Container.Resolve<ISmsService>().SaveSmsToDb(this.customerId, this.phone, this.message, null, null);
					result = true;
				}
				catch (Exception)
				{
					result = false;
				}
				return result;
			}

			// Token: 0x04003758 RID: 14168
			public SMSCClient <>4__this;

			// Token: 0x04003759 RID: 14169
			public string phone;

			// Token: 0x0400375A RID: 14170
			public string message;

			// Token: 0x0400375B RID: 14171
			public int? customerId;
		}

		// Token: 0x02000BB4 RID: 2996
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SendAsync>d__3 : IAsyncStateMachine
		{
			// Token: 0x06005414 RID: 21524 RVA: 0x00168800 File Offset: 0x00166A00
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				bool result;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						SMSCClient.<>c__DisplayClass3_0 CS$<>8__locals1 = new SMSCClient.<>c__DisplayClass3_0();
						CS$<>8__locals1.<>4__this = this.<>4__this;
						CS$<>8__locals1.phone = this.phone;
						CS$<>8__locals1.message = this.message;
						CS$<>8__locals1.customerId = this.customerId;
						CS$<>8__locals1.phone = Phone.ClearPhoneString(CS$<>8__locals1.phone);
						awaiter = Task.Run<bool>(new Func<bool>(CS$<>8__locals1.<SendAsync>b__0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, SMSCClient.<SendAsync>d__3>(ref awaiter, ref this);
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

			// Token: 0x06005415 RID: 21525 RVA: 0x00168900 File Offset: 0x00166B00
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400375C RID: 14172
			public int <>1__state;

			// Token: 0x0400375D RID: 14173
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x0400375E RID: 14174
			public SMSCClient <>4__this;

			// Token: 0x0400375F RID: 14175
			public string phone;

			// Token: 0x04003760 RID: 14176
			public string message;

			// Token: 0x04003761 RID: 14177
			public int? customerId;

			// Token: 0x04003762 RID: 14178
			private TaskAwaiter<bool> <>u__1;
		}

		// Token: 0x02000BB5 RID: 2997
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005416 RID: 21526 RVA: 0x0016891C File Offset: 0x00166B1C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06005417 RID: 21527 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06005418 RID: 21528 RVA: 0x00168934 File Offset: 0x00166B34
			internal bool <SendAsync>b__4_0(tel p)
			{
				return p.type == 1 && p.notify;
			}

			// Token: 0x04003763 RID: 14179
			public static readonly SMSCClient.<>c <>9 = new SMSCClient.<>c();

			// Token: 0x04003764 RID: 14180
			public static Func<tel, bool> <>9__4_0;
		}

		// Token: 0x02000BB6 RID: 2998
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SendAsync>d__4 : IAsyncStateMachine
		{
			// Token: 0x06005419 RID: 21529 RVA: 0x00168954 File Offset: 0x00166B54
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				SMSCClient smscclient = this.<>4__this;
				try
				{
					TaskAwaiter<clients> awaiter;
					if (num != 0)
					{
						if (num - 1 <= 1)
						{
							goto IL_BC;
						}
						this.<rawMsg>5__2 = SmsModel.GetTemplateById(this.templateId);
						if (string.IsNullOrEmpty(this.<rawMsg>5__2))
						{
							goto IL_225;
						}
						awaiter = Bootstrapper.Container.Resolve<ICustomerService>().GetCustomerAsync(this.customerId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<clients>, SMSCClient.<SendAsync>d__4>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<clients>);
						int num2 = -1;
						num = -1;
						this.<>1__state = num2;
					}
					clients result = awaiter.GetResult();
					this.<customer>5__3 = result;
					if (this.<customer>5__3 == null)
					{
						goto IL_225;
					}
					IL_BC:
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
								goto IL_1EF;
							}
							awaiter3 = Bootstrapper.Container.Resolve<ISmsService>().ConstructSms(this.<rawMsg>5__2, this.repairId, this.<customer>5__3.IoOrUrName).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								this.<>1__state = 1;
								this.<>u__2 = awaiter3;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, SMSCClient.<SendAsync>d__4>(ref awaiter3, ref this);
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
						tel tel = this.<customer>5__3.tel.FirstOrDefault(new Func<tel, bool>(SMSCClient.<>c.<>9.<SendAsync>b__4_0));
						if (tel == null)
						{
							goto IL_225;
						}
						awaiter2 = smscclient.SendAsync(tel.phone_clean, result2, new int?(this.customerId)).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 2;
							this.<>u__3 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, SMSCClient.<SendAsync>d__4>(ref awaiter2, ref this);
							return;
						}
						IL_1EF:
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
				IL_225:
				this.<>1__state = -2;
				this.<rawMsg>5__2 = null;
				this.<customer>5__3 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x0600541A RID: 21530 RVA: 0x00168BDC File Offset: 0x00166DDC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003765 RID: 14181
			public int <>1__state;

			// Token: 0x04003766 RID: 14182
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04003767 RID: 14183
			public int templateId;

			// Token: 0x04003768 RID: 14184
			public int customerId;

			// Token: 0x04003769 RID: 14185
			public int repairId;

			// Token: 0x0400376A RID: 14186
			public SMSCClient <>4__this;

			// Token: 0x0400376B RID: 14187
			private string <rawMsg>5__2;

			// Token: 0x0400376C RID: 14188
			private clients <customer>5__3;

			// Token: 0x0400376D RID: 14189
			private TaskAwaiter<clients> <>u__1;

			// Token: 0x0400376E RID: 14190
			private TaskAwaiter<string> <>u__2;

			// Token: 0x0400376F RID: 14191
			private TaskAwaiter<bool> <>u__3;
		}

		// Token: 0x02000BB7 RID: 2999
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <BalanceAsync>d__5 : IAsyncStateMachine
		{
			// Token: 0x0600541B RID: 21531 RVA: 0x00168BF8 File Offset: 0x00166DF8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				SMSCClient @object = this.<>4__this;
				string result;
				try
				{
					TaskAwaiter<string> awaiter;
					if (num != 0)
					{
						awaiter = Task.Run<string>(() => @object._smscClient.balance).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, SMSCClient.<BalanceAsync>d__5>(ref awaiter, ref this);
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

			// Token: 0x0600541C RID: 21532 RVA: 0x00168CBC File Offset: 0x00166EBC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003770 RID: 14192
			public int <>1__state;

			// Token: 0x04003771 RID: 14193
			public AsyncTaskMethodBuilder<string> <>t__builder;

			// Token: 0x04003772 RID: 14194
			public SMSCClient <>4__this;

			// Token: 0x04003773 RID: 14195
			private TaskAwaiter<string> <>u__1;
		}
	}
}
