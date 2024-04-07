using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.SimpleClasses;
using Autofac;

namespace ASC.Extensions.EpochtaSms
{
	// Token: 0x02000B84 RID: 2948
	public class EpochtaSmsClient : ISmsClient
	{
		// Token: 0x17001505 RID: 5381
		// (get) Token: 0x0600522C RID: 21036 RVA: 0x00161224 File Offset: 0x0015F424
		private string Username
		{
			[CompilerGenerated]
			get
			{
				return this.<Username>k__BackingField;
			}
		}

		// Token: 0x17001506 RID: 5382
		// (get) Token: 0x0600522D RID: 21037 RVA: 0x00161238 File Offset: 0x0015F438
		private string Password
		{
			[CompilerGenerated]
			get
			{
				return this.<Password>k__BackingField;
			}
		}

		// Token: 0x17001507 RID: 5383
		// (get) Token: 0x0600522E RID: 21038 RVA: 0x0016124C File Offset: 0x0015F44C
		private string Sender
		{
			[CompilerGenerated]
			get
			{
				return this.<Sender>k__BackingField;
			}
		}

		// Token: 0x0600522F RID: 21039 RVA: 0x00161260 File Offset: 0x0015F460
		public EpochtaSmsClient(SmsClientConfig config)
		{
			this.SmsService = Bootstrapper.Container.Resolve<ISmsService>();
			this.Username = config.Login;
			this.Password = config.Password;
			this.Sender = config.Sender;
		}

		// Token: 0x17001508 RID: 5384
		// (get) Token: 0x06005230 RID: 21040 RVA: 0x001612A8 File Offset: 0x0015F4A8
		// (set) Token: 0x06005231 RID: 21041 RVA: 0x001612BC File Offset: 0x0015F4BC
		protected ISmsService SmsService
		{
			[CompilerGenerated]
			get
			{
				return this.<SmsService>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<SmsService>k__BackingField = value;
			}
		}

		// Token: 0x06005232 RID: 21042 RVA: 0x001612D0 File Offset: 0x0015F4D0
		public Task<bool> SendAsync(string phone, string message, int? customerId)
		{
			EpochtaSmsClient.<SendAsync>d__15 <SendAsync>d__;
			<SendAsync>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<SendAsync>d__.<>4__this = this;
			<SendAsync>d__.phone = phone;
			<SendAsync>d__.message = message;
			<SendAsync>d__.customerId = customerId;
			<SendAsync>d__.<>1__state = -1;
			<SendAsync>d__.<>t__builder.Start<EpochtaSmsClient.<SendAsync>d__15>(ref <SendAsync>d__);
			return <SendAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06005233 RID: 21043 RVA: 0x0016132C File Offset: 0x0015F52C
		public Task SendAsync(int repairId, int customerId, int templateId)
		{
			EpochtaSmsClient.<SendAsync>d__16 <SendAsync>d__;
			<SendAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<SendAsync>d__.<>4__this = this;
			<SendAsync>d__.repairId = repairId;
			<SendAsync>d__.customerId = customerId;
			<SendAsync>d__.templateId = templateId;
			<SendAsync>d__.<>1__state = -1;
			<SendAsync>d__.<>t__builder.Start<EpochtaSmsClient.<SendAsync>d__16>(ref <SendAsync>d__);
			return <SendAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06005234 RID: 21044 RVA: 0x00161388 File Offset: 0x0015F588
		public Task<string> BalanceAsync()
		{
			EpochtaSmsClient.<BalanceAsync>d__17 <BalanceAsync>d__;
			<BalanceAsync>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<BalanceAsync>d__.<>4__this = this;
			<BalanceAsync>d__.<>1__state = -1;
			<BalanceAsync>d__.<>t__builder.Start<EpochtaSmsClient.<BalanceAsync>d__17>(ref <BalanceAsync>d__);
			return <BalanceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06005235 RID: 21045 RVA: 0x001613CC File Offset: 0x0015F5CC
		[CompilerGenerated]
		private string <BalanceAsync>b__17_0()
		{
			string result;
			try
			{
				string s = string.Concat(new string[]
				{
					"XML=<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n<SMS>\n<operations>\n<operation>BALANCE</operation>\n</operations>\n<authentification>\n<username>",
					this.Username,
					"</username>\n<password>",
					this.Password,
					"</password>\n</authentification>\n</SMS>\n"
				});
				HttpWebRequest httpWebRequest = WebRequest.Create("http://api.myatompark.com/members/sms/xml.php") as HttpWebRequest;
				httpWebRequest.Method = "Post";
				httpWebRequest.ContentType = "application/x-www-form-urlencoded";
				byte[] bytes = new UTF8Encoding().GetBytes(s);
				httpWebRequest.ContentLength = (long)bytes.Length;
				httpWebRequest.GetRequestStream().Write(bytes, 0, bytes.Length);
				using (HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse)
				{
					if (httpWebResponse.StatusCode != HttpStatusCode.OK)
					{
						result = "Error";
					}
					else
					{
						XDocument xdocument = XDocument.Parse(new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd());
						XElement xelement = xdocument.Descendants("amount").FirstOrDefault<XElement>();
						string text;
						if (xelement != null)
						{
							if ((text = xelement.Value) != null)
							{
								goto IL_E4;
							}
						}
						text = "";
						IL_E4:
						string str = text;
						XElement xelement2 = xdocument.Descendants("currency").FirstOrDefault<XElement>();
						string text2;
						if (xelement2 != null)
						{
							if ((text2 = xelement2.Value) != null)
							{
								goto IL_10E;
							}
						}
						text2 = "";
						IL_10E:
						string str2 = text2;
						result = str + " " + str2;
					}
				}
			}
			catch (Exception ex)
			{
				result = ex.Message;
			}
			return result;
		}

		// Token: 0x040035F9 RID: 13817
		private const string BaseUrl = "http://api.myatompark.com/members/sms/xml.php";

		// Token: 0x040035FA RID: 13818
		[CompilerGenerated]
		private readonly string <Username>k__BackingField;

		// Token: 0x040035FB RID: 13819
		[CompilerGenerated]
		private readonly string <Password>k__BackingField;

		// Token: 0x040035FC RID: 13820
		[CompilerGenerated]
		private readonly string <Sender>k__BackingField;

		// Token: 0x040035FD RID: 13821
		[CompilerGenerated]
		private ISmsService <SmsService>k__BackingField;

		// Token: 0x02000B85 RID: 2949
		[CompilerGenerated]
		private sealed class <>c__DisplayClass15_0
		{
			// Token: 0x06005236 RID: 21046 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass15_0()
			{
			}

			// Token: 0x06005237 RID: 21047 RVA: 0x00161544 File Offset: 0x0015F744
			internal bool <SendAsync>b__0()
			{
				HttpWebRequest httpWebRequest = WebRequest.Create("http://api.myatompark.com/members/sms/xml.php") as HttpWebRequest;
				httpWebRequest.Method = "POST";
				httpWebRequest.ContentType = "application/x-www-form-urlencoded";
				byte[] bytes = Encoding.UTF8.GetBytes(this.xml);
				httpWebRequest.ContentLength = (long)bytes.Length;
				httpWebRequest.GetRequestStream().Write(bytes, 0, bytes.Length);
				bool result;
				using (HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse)
				{
					if (httpWebResponse.StatusCode != HttpStatusCode.OK)
					{
						throw new WebException(string.Format("{0}: {1}", httpWebResponse.StatusCode, httpWebResponse.StatusDescription));
					}
					XElement xelement = XDocument.Parse(new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd()).Descendants("status").FirstOrDefault<XElement>();
					string s;
					if (xelement != null)
					{
						if ((s = xelement.Value) != null)
						{
							goto IL_C7;
						}
					}
					s = "0";
					IL_C7:
					int num = int.Parse(s);
					if (num <= 0)
					{
						result = false;
					}
					else
					{
						Bootstrapper.Container.Resolve<ISmsService>().SaveSmsToDb(this.customerId, this.phone, this.message, new int?(num), null);
						result = true;
					}
				}
				return result;
			}

			// Token: 0x040035FE RID: 13822
			public string xml;

			// Token: 0x040035FF RID: 13823
			public int? customerId;

			// Token: 0x04003600 RID: 13824
			public string phone;

			// Token: 0x04003601 RID: 13825
			public string message;
		}

		// Token: 0x02000B86 RID: 2950
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SendAsync>d__15 : IAsyncStateMachine
		{
			// Token: 0x06005238 RID: 21048 RVA: 0x00161670 File Offset: 0x0015F870
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				EpochtaSmsClient epochtaSmsClient = this.<>4__this;
				bool result;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						EpochtaSmsClient.<>c__DisplayClass15_0 CS$<>8__locals1 = new EpochtaSmsClient.<>c__DisplayClass15_0();
						CS$<>8__locals1.customerId = this.customerId;
						CS$<>8__locals1.phone = this.phone;
						CS$<>8__locals1.message = this.message;
						CS$<>8__locals1.xml = string.Format("XML=<?xml version=\"1.0\" encoding=\"UTF-8\"?>\r\n                    <SMS>\r\n                        <operations>\r\n                            <operation>SEND</operation>\r\n                        </operations>\r\n                        <authentification>\r\n                            <username>{0}</username>\r\n                            <password>{1}</password>\r\n                        </authentification>\r\n                        <message>\r\n                            <sender>{2}</sender>\r\n                            <text>{3}</text>\r\n                        </message>\r\n                        <numbers>\r\n                            <number messageID=\"{4}\">{5}</number>\r\n                        </numbers>\r\n                    </SMS>", new object[]
						{
							epochtaSmsClient.Username,
							epochtaSmsClient.Password,
							epochtaSmsClient.Sender,
							CS$<>8__locals1.message,
							Guid.NewGuid(),
							CS$<>8__locals1.phone
						});
						awaiter = Task.Run<bool>(new Func<bool>(CS$<>8__locals1.<SendAsync>b__0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, EpochtaSmsClient.<SendAsync>d__15>(ref awaiter, ref this);
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

			// Token: 0x06005239 RID: 21049 RVA: 0x001617B4 File Offset: 0x0015F9B4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003602 RID: 13826
			public int <>1__state;

			// Token: 0x04003603 RID: 13827
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x04003604 RID: 13828
			public int? customerId;

			// Token: 0x04003605 RID: 13829
			public string phone;

			// Token: 0x04003606 RID: 13830
			public string message;

			// Token: 0x04003607 RID: 13831
			public EpochtaSmsClient <>4__this;

			// Token: 0x04003608 RID: 13832
			private TaskAwaiter<bool> <>u__1;
		}

		// Token: 0x02000B87 RID: 2951
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600523A RID: 21050 RVA: 0x001617D0 File Offset: 0x0015F9D0
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600523B RID: 21051 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x0600523C RID: 21052 RVA: 0x00160E70 File Offset: 0x0015F070
			internal bool <SendAsync>b__16_0(Tel p)
			{
				return p.Type == 1 && p.Notify;
			}

			// Token: 0x04003609 RID: 13833
			public static readonly EpochtaSmsClient.<>c <>9 = new EpochtaSmsClient.<>c();

			// Token: 0x0400360A RID: 13834
			public static Func<Tel, bool> <>9__16_0;
		}

		// Token: 0x02000B88 RID: 2952
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SendAsync>d__16 : IAsyncStateMachine
		{
			// Token: 0x0600523D RID: 21053 RVA: 0x001617E8 File Offset: 0x0015F9E8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				EpochtaSmsClient epochtaSmsClient = this.<>4__this;
				try
				{
					TaskAwaiter<CustomerCard> awaiter;
					if (num != 0)
					{
						if (num - 1 <= 1)
						{
							goto IL_B2;
						}
						this.<rawMsg>5__2 = SmsModel.GetTemplateById(this.templateId);
						if (string.IsNullOrEmpty(this.<rawMsg>5__2))
						{
							goto IL_214;
						}
						awaiter = ClientsModel.GetCustomerCard(this.customerId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<CustomerCard>, EpochtaSmsClient.<SendAsync>d__16>(ref awaiter, ref this);
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
						goto IL_214;
					}
					IL_B2:
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
								goto IL_1DE;
							}
							awaiter3 = epochtaSmsClient.SmsService.ConstructSms(this.<rawMsg>5__2, this.repairId, this.<customer>5__3.IoOrUrName).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								this.<>1__state = 1;
								this.<>u__2 = awaiter3;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, EpochtaSmsClient.<SendAsync>d__16>(ref awaiter3, ref this);
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
						Tel tel = this.<customer>5__3.Phones.FirstOrDefault(new Func<Tel, bool>(EpochtaSmsClient.<>c.<>9.<SendAsync>b__16_0));
						if (tel == null)
						{
							goto IL_214;
						}
						awaiter2 = epochtaSmsClient.SendAsync(tel.PhoneClean, result2, new int?(this.customerId)).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 2;
							this.<>u__3 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, EpochtaSmsClient.<SendAsync>d__16>(ref awaiter2, ref this);
							return;
						}
						IL_1DE:
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
				IL_214:
				this.<>1__state = -2;
				this.<rawMsg>5__2 = null;
				this.<customer>5__3 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x0600523E RID: 21054 RVA: 0x00161A60 File Offset: 0x0015FC60
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400360B RID: 13835
			public int <>1__state;

			// Token: 0x0400360C RID: 13836
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400360D RID: 13837
			public int templateId;

			// Token: 0x0400360E RID: 13838
			public int customerId;

			// Token: 0x0400360F RID: 13839
			public EpochtaSmsClient <>4__this;

			// Token: 0x04003610 RID: 13840
			public int repairId;

			// Token: 0x04003611 RID: 13841
			private string <rawMsg>5__2;

			// Token: 0x04003612 RID: 13842
			private CustomerCard <customer>5__3;

			// Token: 0x04003613 RID: 13843
			private TaskAwaiter<CustomerCard> <>u__1;

			// Token: 0x04003614 RID: 13844
			private TaskAwaiter<string> <>u__2;

			// Token: 0x04003615 RID: 13845
			private TaskAwaiter<bool> <>u__3;
		}

		// Token: 0x02000B89 RID: 2953
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <BalanceAsync>d__17 : IAsyncStateMachine
		{
			// Token: 0x0600523F RID: 21055 RVA: 0x00161A7C File Offset: 0x0015FC7C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				EpochtaSmsClient @object = this.<>4__this;
				string result;
				try
				{
					TaskAwaiter<string> awaiter;
					if (num != 0)
					{
						awaiter = Task.Run<string>(delegate()
						{
							string result2;
							try
							{
								string s = string.Concat(new string[]
								{
									"XML=<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n<SMS>\n<operations>\n<operation>BALANCE</operation>\n</operations>\n<authentification>\n<username>",
									base.Username,
									"</username>\n<password>",
									base.Password,
									"</password>\n</authentification>\n</SMS>\n"
								});
								HttpWebRequest httpWebRequest = WebRequest.Create("http://api.myatompark.com/members/sms/xml.php") as HttpWebRequest;
								httpWebRequest.Method = "Post";
								httpWebRequest.ContentType = "application/x-www-form-urlencoded";
								byte[] bytes = new UTF8Encoding().GetBytes(s);
								httpWebRequest.ContentLength = (long)bytes.Length;
								httpWebRequest.GetRequestStream().Write(bytes, 0, bytes.Length);
								using (HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse)
								{
									if (httpWebResponse.StatusCode != HttpStatusCode.OK)
									{
										result2 = "Error";
									}
									else
									{
										XDocument xdocument = XDocument.Parse(new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd());
										XElement xelement = xdocument.Descendants("amount").FirstOrDefault<XElement>();
										string text;
										if (xelement != null)
										{
											if ((text = xelement.Value) != null)
											{
												goto IL_E4;
											}
										}
										text = "";
										IL_E4:
										string str = text;
										XElement xelement2 = xdocument.Descendants("currency").FirstOrDefault<XElement>();
										string text2;
										if (xelement2 != null)
										{
											if ((text2 = xelement2.Value) != null)
											{
												goto IL_10E;
											}
										}
										text2 = "";
										IL_10E:
										string str2 = text2;
										result2 = str + " " + str2;
									}
								}
							}
							catch (Exception ex)
							{
								result2 = ex.Message;
							}
							return result2;
						}).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, EpochtaSmsClient.<BalanceAsync>d__17>(ref awaiter, ref this);
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

			// Token: 0x06005240 RID: 21056 RVA: 0x00161B40 File Offset: 0x0015FD40
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003616 RID: 13846
			public int <>1__state;

			// Token: 0x04003617 RID: 13847
			public AsyncTaskMethodBuilder<string> <>t__builder;

			// Token: 0x04003618 RID: 13848
			public EpochtaSmsClient <>4__this;

			// Token: 0x04003619 RID: 13849
			private TaskAwaiter<string> <>u__1;
		}
	}
}
