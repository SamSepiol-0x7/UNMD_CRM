using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using AegisImplicitMail;
using ASC.Common.Interfaces;
using ASC.Objects;
using ASC.Services.Abstract;
using Autofac;
using DevExpress.Xpf.WindowsUI;
using Newtonsoft.Json;

namespace ASC.SimpleClasses
{
	// Token: 0x02000220 RID: 544
	public class Email : IEmail
	{
		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x06001D32 RID: 7474 RVA: 0x00054CBC File Offset: 0x00052EBC
		// (set) Token: 0x06001D33 RID: 7475 RVA: 0x00054CD0 File Offset: 0x00052ED0
		public string Host
		{
			[CompilerGenerated]
			get
			{
				return this.<Host>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Host>k__BackingField = value;
			}
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x06001D34 RID: 7476 RVA: 0x00054CE4 File Offset: 0x00052EE4
		// (set) Token: 0x06001D35 RID: 7477 RVA: 0x00054CF8 File Offset: 0x00052EF8
		public int Port
		{
			[CompilerGenerated]
			get
			{
				return this.<Port>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Port>k__BackingField = value;
			}
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x06001D36 RID: 7478 RVA: 0x00054D0C File Offset: 0x00052F0C
		// (set) Token: 0x06001D37 RID: 7479 RVA: 0x00054D20 File Offset: 0x00052F20
		public string Login
		{
			[CompilerGenerated]
			get
			{
				return this.<Login>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Login>k__BackingField = value;
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x06001D38 RID: 7480 RVA: 0x00054D34 File Offset: 0x00052F34
		// (set) Token: 0x06001D39 RID: 7481 RVA: 0x00054D48 File Offset: 0x00052F48
		public string Password
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

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x06001D3A RID: 7482 RVA: 0x00054D5C File Offset: 0x00052F5C
		// (set) Token: 0x06001D3B RID: 7483 RVA: 0x00054D70 File Offset: 0x00052F70
		public bool EnableSsl
		{
			[CompilerGenerated]
			get
			{
				return this.<EnableSsl>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<EnableSsl>k__BackingField = value;
			}
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x06001D3C RID: 7484 RVA: 0x00054D84 File Offset: 0x00052F84
		// (set) Token: 0x06001D3D RID: 7485 RVA: 0x00054D98 File Offset: 0x00052F98
		public bool EnableImplicitSsl
		{
			[CompilerGenerated]
			get
			{
				return this.<EnableImplicitSsl>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<EnableImplicitSsl>k__BackingField = value;
			}
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x06001D3E RID: 7486 RVA: 0x00054DAC File Offset: 0x00052FAC
		// (set) Token: 0x06001D3F RID: 7487 RVA: 0x00054DC0 File Offset: 0x00052FC0
		public int Timeout
		{
			[CompilerGenerated]
			get
			{
				return this.<Timeout>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Timeout>k__BackingField = value;
			}
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x06001D40 RID: 7488 RVA: 0x00054DD4 File Offset: 0x00052FD4
		// (set) Token: 0x06001D41 RID: 7489 RVA: 0x00054DE8 File Offset: 0x00052FE8
		public string Template
		{
			[CompilerGenerated]
			get
			{
				return this.<Template>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Template>k__BackingField = value;
			}
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x06001D42 RID: 7490 RVA: 0x00054DFC File Offset: 0x00052FFC
		// (set) Token: 0x06001D43 RID: 7491 RVA: 0x00054E10 File Offset: 0x00053010
		[JsonIgnore]
		public string RawTemplate
		{
			[CompilerGenerated]
			get
			{
				return this.<RawTemplate>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<RawTemplate>k__BackingField = value;
			}
		}

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x06001D44 RID: 7492 RVA: 0x00054E24 File Offset: 0x00053024
		// (set) Token: 0x06001D45 RID: 7493 RVA: 0x00054E38 File Offset: 0x00053038
		[JsonIgnore]
		public string To
		{
			[CompilerGenerated]
			get
			{
				return this.<To>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<To>k__BackingField = value;
			}
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x06001D46 RID: 7494 RVA: 0x00054E4C File Offset: 0x0005304C
		// (set) Token: 0x06001D47 RID: 7495 RVA: 0x00054E60 File Offset: 0x00053060
		[JsonIgnore]
		public string Subject
		{
			[CompilerGenerated]
			get
			{
				return this.<Subject>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Subject>k__BackingField = value;
			}
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x06001D48 RID: 7496 RVA: 0x00054E74 File Offset: 0x00053074
		// (set) Token: 0x06001D49 RID: 7497 RVA: 0x00054E88 File Offset: 0x00053088
		[JsonIgnore]
		public string Message
		{
			[CompilerGenerated]
			get
			{
				return this.<Message>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Message>k__BackingField = value;
			}
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x06001D4A RID: 7498 RVA: 0x00054E9C File Offset: 0x0005309C
		// (set) Token: 0x06001D4B RID: 7499 RVA: 0x00054EB0 File Offset: 0x000530B0
		[JsonIgnore]
		public bool HaveAttachments
		{
			[CompilerGenerated]
			get
			{
				return this.<HaveAttachments>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<HaveAttachments>k__BackingField = value;
			}
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x06001D4C RID: 7500 RVA: 0x00054EC4 File Offset: 0x000530C4
		// (set) Token: 0x06001D4D RID: 7501 RVA: 0x00054ED8 File Offset: 0x000530D8
		[JsonIgnore]
		public List<byte[]> Attachments
		{
			[CompilerGenerated]
			get
			{
				return this.<Attachments>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Attachments>k__BackingField = value;
			}
		}

		// Token: 0x06001D4E RID: 7502 RVA: 0x00054EEC File Offset: 0x000530EC
		public Email()
		{
			this.Attachments = new List<byte[]>();
			if (Auth.Config.email_config == null)
			{
				return;
			}
			Email email = JsonConvert.DeserializeObject<Email>(Auth.Config.email_config);
			if (email == null)
			{
				return;
			}
			this.Host = email.Host;
			this.Port = email.Port;
			this.Login = email.Login;
			this.Password = email.Password;
			this.EnableSsl = email.EnableSsl;
			this.EnableImplicitSsl = email.EnableImplicitSsl;
			this.Timeout = email.Timeout;
			this.Template = email.Template;
			this.RawTemplate = this.Template;
			this.mailer = new MimeMailer
			{
				Host = this.Host,
				Port = this.Port,
				User = this.Login,
				Password = this.Password,
				AuthenticationMode = AuthenticationType.Base64,
				Timeout = this.Timeout * 100
			};
			if (this.EnableSsl)
			{
				this.mailer.SslType = SslMode.Ssl;
				this.mailer.EnableImplicitSsl = this.EnableImplicitSsl;
			}
			this.mailer.SendCompleted += this.OnMailSent;
		}

		// Token: 0x06001D4F RID: 7503 RVA: 0x00055024 File Offset: 0x00053224
		public Email(string sendTo) : this()
		{
			this.To = sendTo;
		}

		// Token: 0x06001D50 RID: 7504 RVA: 0x00055040 File Offset: 0x00053240
		public Email(string sendTo, string subject) : this()
		{
			this.To = sendTo;
			this.Subject = subject;
		}

		// Token: 0x06001D51 RID: 7505 RVA: 0x000046B4 File Offset: 0x000028B4
		[JsonConstructor]
		private Email(bool dummy)
		{
		}

		// Token: 0x06001D52 RID: 7506 RVA: 0x00055064 File Offset: 0x00053264
		public Email(store_items item) : this()
		{
			this.Item = item;
			this.Subject = Lang.t("Photos");
			this.Message = this.Item.name;
			this.HaveAttachments = true;
		}

		// Token: 0x06001D53 RID: 7507 RVA: 0x000550A8 File Offset: 0x000532A8
		public bool EmailNotConfigured()
		{
			return string.IsNullOrEmpty(this.Host) || this.Port == 0 || string.IsNullOrEmpty(this.Login) || string.IsNullOrEmpty(this.Password);
		}

		// Token: 0x06001D54 RID: 7508 RVA: 0x000550E4 File Offset: 0x000532E4
		public string CreateMessageBody()
		{
			if (!this.IsBodyHtml())
			{
				return this.Message;
			}
			this.Template = Regex.Replace(this.Template, "\\[img](.*?)\\[/img]", delegate(Match m)
			{
				string value = m.Groups[1].Value;
				return "<img src=\"" + value + "\" />";
			});
			return this.Template.Replace("{MESSAGE}", this.Message).Replace("{USER}", OfflineData.Instance.Employee.FioShort).Replace("{SIGNATURE}", this.GetUserSignature(OfflineData.Instance.Employee.Signature));
		}

		// Token: 0x06001D55 RID: 7509 RVA: 0x00055184 File Offset: 0x00053384
		private string GetUserSignature(string signature)
		{
			if (!string.IsNullOrEmpty(signature))
			{
				return signature.Replace("\r\n", "<br />");
			}
			return signature;
		}

		// Token: 0x06001D56 RID: 7510 RVA: 0x000551AC File Offset: 0x000533AC
		public bool IsBodyHtml()
		{
			return !string.IsNullOrEmpty(this.Template);
		}

		// Token: 0x06001D57 RID: 7511 RVA: 0x000551C8 File Offset: 0x000533C8
		public virtual Task<bool> SendEmail()
		{
			Email.<SendEmail>d__67 <SendEmail>d__;
			<SendEmail>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<SendEmail>d__.<>4__this = this;
			<SendEmail>d__.<>1__state = -1;
			<SendEmail>d__.<>t__builder.Start<Email.<SendEmail>d__67>(ref <SendEmail>d__);
			return <SendEmail>d__.<>t__builder.Task;
		}

		// Token: 0x06001D58 RID: 7512 RVA: 0x0005520C File Offset: 0x0005340C
		private void OnMailSent(object sender, AsyncCompletedEventArgs e)
		{
			if (e.UserState != null)
			{
				Console.Out.WriteLine(e.UserState.ToString());
			}
			if (e.Error == null)
			{
				if (!e.Cancelled)
				{
					Application.Current.Dispatcher.Invoke<MessageBoxResult>(() => WinUIMessageBox.Show((string)Application.Current.TryFindResource("MailSent"), (string)Application.Current.TryFindResource("Info")));
				}
				return;
			}
			Application.Current.Dispatcher.Invoke<MessageBoxResult>(() => WinUIMessageBox.Show(e.Error.Message, (string)Application.Current.TryFindResource("MessageSendError")));
		}

		// Token: 0x06001D59 RID: 7513 RVA: 0x000552B4 File Offset: 0x000534B4
		public virtual bool CheckFields()
		{
			if (string.IsNullOrEmpty(this.To))
			{
				WinUIMessageBox.Show((string)Application.Current.TryFindResource("CheckToEmail"));
				return false;
			}
			bool result;
			try
			{
				new MailAddress(this.To);
				goto IL_49;
			}
			catch (FormatException ex)
			{
				WinUIMessageBox.Show(ex.Message);
				result = false;
			}
			return result;
			IL_49:
			if (string.IsNullOrEmpty(this.Subject))
			{
				WinUIMessageBox.Show((string)Application.Current.TryFindResource("CheckTitle"));
				return false;
			}
			if (this.Subject.Length > 70)
			{
				WinUIMessageBox.Show((string)Application.Current.TryFindResource("SubjectTooLong"));
				return false;
			}
			if (!string.IsNullOrEmpty(this.Message))
			{
				return true;
			}
			WinUIMessageBox.Show((string)Application.Current.TryFindResource("CheckMessage"));
			return false;
		}

		// Token: 0x04000F56 RID: 3926
		[CompilerGenerated]
		private string <Host>k__BackingField;

		// Token: 0x04000F57 RID: 3927
		[CompilerGenerated]
		private int <Port>k__BackingField;

		// Token: 0x04000F58 RID: 3928
		[CompilerGenerated]
		private string <Login>k__BackingField;

		// Token: 0x04000F59 RID: 3929
		[CompilerGenerated]
		private string <Password>k__BackingField;

		// Token: 0x04000F5A RID: 3930
		[CompilerGenerated]
		private bool <EnableSsl>k__BackingField;

		// Token: 0x04000F5B RID: 3931
		[CompilerGenerated]
		private bool <EnableImplicitSsl>k__BackingField;

		// Token: 0x04000F5C RID: 3932
		[CompilerGenerated]
		private int <Timeout>k__BackingField;

		// Token: 0x04000F5D RID: 3933
		[CompilerGenerated]
		private string <Template>k__BackingField;

		// Token: 0x04000F5E RID: 3934
		[CompilerGenerated]
		private string <RawTemplate>k__BackingField;

		// Token: 0x04000F5F RID: 3935
		[CompilerGenerated]
		private string <To>k__BackingField;

		// Token: 0x04000F60 RID: 3936
		[CompilerGenerated]
		private string <Subject>k__BackingField;

		// Token: 0x04000F61 RID: 3937
		[CompilerGenerated]
		private string <Message>k__BackingField;

		// Token: 0x04000F62 RID: 3938
		[CompilerGenerated]
		private bool <HaveAttachments>k__BackingField;

		// Token: 0x04000F63 RID: 3939
		[CompilerGenerated]
		private List<byte[]> <Attachments>k__BackingField;

		// Token: 0x04000F64 RID: 3940
		[JsonIgnore]
		private store_items Item;

		// Token: 0x04000F65 RID: 3941
		[JsonIgnore]
		public MimeMailer mailer;

		// Token: 0x02000221 RID: 545
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001D5A RID: 7514 RVA: 0x00055398 File Offset: 0x00053598
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06001D5B RID: 7515 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06001D5C RID: 7516 RVA: 0x000553B0 File Offset: 0x000535B0
			internal string <CreateMessageBody>b__64_0(Match m)
			{
				string value = m.Groups[1].Value;
				return "<img src=\"" + value + "\" />";
			}

			// Token: 0x06001D5D RID: 7517 RVA: 0x000553E0 File Offset: 0x000535E0
			internal MessageBoxResult <OnMailSent>b__68_1()
			{
				return WinUIMessageBox.Show((string)Application.Current.TryFindResource("MailSent"), (string)Application.Current.TryFindResource("Info"));
			}

			// Token: 0x04000F66 RID: 3942
			public static readonly Email.<>c <>9 = new Email.<>c();

			// Token: 0x04000F67 RID: 3943
			public static MatchEvaluator <>9__64_0;

			// Token: 0x04000F68 RID: 3944
			public static Func<MessageBoxResult> <>9__68_1;
		}

		// Token: 0x02000222 RID: 546
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SendEmail>d__67 : IAsyncStateMachine
		{
			// Token: 0x06001D5E RID: 7518 RVA: 0x0005541C File Offset: 0x0005361C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Email email = this.<>4__this;
				bool result2;
				try
				{
					TaskAwaiter<IEnumerable<images>> awaiter;
					if (num != 0)
					{
						if (!email.CheckFields() || email.EmailNotConfigured())
						{
							goto IL_1C0;
						}
						this.<mail>5__2 = new MimeMailMessage
						{
							From = new MailAddress(email.Login),
							Sender = new MailAddress(email.Login),
							SubjectEncoding = Encoding.UTF8,
							HeadersEncoding = Encoding.UTF8,
							Body = email.CreateMessageBody(),
							Subject = email.Subject,
							IsBodyHtml = email.IsBodyHtml()
						};
						this.<mail>5__2.To.Add(new MimeMailAddress(email.To));
						if (!email.HaveAttachments)
						{
							goto IL_19B;
						}
						awaiter = Bootstrapper.Container.Resolve<IProductService>().GetImages(email.Item.id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.<>1__state = num2;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<images>>, Email.<SendEmail>d__67>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<images>>);
						int num3 = -1;
						num = -1;
						this.<>1__state = num3;
					}
					IEnumerable<images> result = awaiter.GetResult();
					int num4 = 1;
					IEnumerator<images> enumerator = result.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							images images = enumerator.Current;
							string name = string.Format("file{0}.jpg", num4);
							if (images != null)
							{
								MemoryStream contentStream = new MemoryStream(images.img);
								this.<mail>5__2.Attachments.Add(new MimeAttachment(contentStream, name, AttachmentLocation.Attachmed));
							}
							num4++;
						}
					}
					finally
					{
						if (num < 0 && enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					IL_19B:
					try
					{
						email.mailer.SendMailAsync(this.<mail>5__2);
						result2 = true;
						goto IL_1E4;
					}
					catch (Exception ex)
					{
						WinUIMessageBox.Show(ex.Message);
						result2 = false;
						goto IL_1E4;
					}
					IL_1C0:
					result2 = false;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<mail>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_1E4:
				this.<>1__state = -2;
				this.<mail>5__2 = null;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06001D5F RID: 7519 RVA: 0x00055674 File Offset: 0x00053874
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000F69 RID: 3945
			public int <>1__state;

			// Token: 0x04000F6A RID: 3946
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x04000F6B RID: 3947
			public Email <>4__this;

			// Token: 0x04000F6C RID: 3948
			private MimeMailMessage <mail>5__2;

			// Token: 0x04000F6D RID: 3949
			private TaskAwaiter<IEnumerable<images>> <>u__1;
		}

		// Token: 0x02000223 RID: 547
		[CompilerGenerated]
		private sealed class <>c__DisplayClass68_0
		{
			// Token: 0x06001D60 RID: 7520 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass68_0()
			{
			}

			// Token: 0x06001D61 RID: 7521 RVA: 0x00055690 File Offset: 0x00053890
			internal MessageBoxResult <OnMailSent>b__0()
			{
				return WinUIMessageBox.Show(this.e.Error.Message, (string)Application.Current.TryFindResource("MessageSendError"));
			}

			// Token: 0x04000F6E RID: 3950
			public AsyncCompletedEventArgs e;
		}
	}
}
