using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using DevExpress.Xpf.Core;
using Newtonsoft.Json;

namespace ASC.SimpleClasses
{
	// Token: 0x02000213 RID: 531
	public class Sms : INotifyPropertyChanged
	{
		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06001C22 RID: 7202 RVA: 0x00052A5C File Offset: 0x00050C5C
		// (remove) Token: 0x06001C23 RID: 7203 RVA: 0x00052A94 File Offset: 0x00050C94
		public event PropertyChangedEventHandler PropertyChanged
		{
			[CompilerGenerated]
			add
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x06001C24 RID: 7204 RVA: 0x00052ACC File Offset: 0x00050CCC
		// (set) Token: 0x06001C25 RID: 7205 RVA: 0x00052AE0 File Offset: 0x00050CE0
		[JsonIgnore]
		public List<KeyValuePair<int, string>> Providers
		{
			[CompilerGenerated]
			get
			{
				return this.<Providers>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<Providers>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -373107484;
				IL_13:
				switch ((num ^ -824298027) % 4)
				{
				case 1:
					return;
				case 2:
					goto IL_0E;
				case 3:
					IL_32:
					num = -606825251;
					goto IL_13;
				}
				this.<Providers>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.Providers);
			}
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x06001C26 RID: 7206 RVA: 0x00052B3C File Offset: 0x00050D3C
		// (set) Token: 0x06001C27 RID: 7207 RVA: 0x00052B50 File Offset: 0x00050D50
		public int Provider
		{
			[CompilerGenerated]
			get
			{
				return this.<Provider>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Provider>k__BackingField == value)
				{
					return;
				}
				this.<Provider>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.Provider);
			}
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06001C28 RID: 7208 RVA: 0x00052B7C File Offset: 0x00050D7C
		// (set) Token: 0x06001C29 RID: 7209 RVA: 0x00052B90 File Offset: 0x00050D90
		public int AuthType
		{
			[CompilerGenerated]
			get
			{
				return this.<AuthType>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<AuthType>k__BackingField == value)
				{
					return;
				}
				this.<AuthType>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.LoginPasswordEnable);
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.ApiFieldEnable);
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.AuthType);
			}
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06001C2A RID: 7210 RVA: 0x00052BD4 File Offset: 0x00050DD4
		// (set) Token: 0x06001C2B RID: 7211 RVA: 0x00052BE8 File Offset: 0x00050DE8
		public string SmsRuApiId
		{
			[CompilerGenerated]
			get
			{
				return this.<SmsRuApiId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<SmsRuApiId>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<SmsRuApiId>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.SmsRuApiId);
			}
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06001C2C RID: 7212 RVA: 0x00052C18 File Offset: 0x00050E18
		// (set) Token: 0x06001C2D RID: 7213 RVA: 0x00052C2C File Offset: 0x00050E2C
		public string SmsRuLogin
		{
			[CompilerGenerated]
			get
			{
				return this.<SmsRuLogin>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<SmsRuLogin>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<SmsRuLogin>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.SmsRuLogin);
			}
		}

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x06001C2E RID: 7214 RVA: 0x00052C5C File Offset: 0x00050E5C
		// (set) Token: 0x06001C2F RID: 7215 RVA: 0x00052C70 File Offset: 0x00050E70
		public string SmsRuPassword
		{
			[CompilerGenerated]
			get
			{
				return this.<SmsRuPassword>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<SmsRuPassword>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<SmsRuPassword>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.SmsRuPassword);
			}
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x06001C30 RID: 7216 RVA: 0x00052CA0 File Offset: 0x00050EA0
		// (set) Token: 0x06001C31 RID: 7217 RVA: 0x00052CB4 File Offset: 0x00050EB4
		public string SmsRuSender
		{
			[CompilerGenerated]
			get
			{
				return this.<SmsRuSender>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<SmsRuSender>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<SmsRuSender>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.SmsRuSender);
			}
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x06001C32 RID: 7218 RVA: 0x00052CE4 File Offset: 0x00050EE4
		[JsonIgnore]
		public bool LoginPasswordEnable
		{
			get
			{
				return this.AuthType == 1 || this.AuthType == 3;
			}
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06001C33 RID: 7219 RVA: 0x00052D08 File Offset: 0x00050F08
		[JsonIgnore]
		public bool ApiFieldEnable
		{
			get
			{
				return this.AuthType == 0;
			}
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x06001C34 RID: 7220 RVA: 0x00052D20 File Offset: 0x00050F20
		// (set) Token: 0x06001C35 RID: 7221 RVA: 0x00052D34 File Offset: 0x00050F34
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
				if (string.Equals(this.<Message>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Message>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.MessageLength);
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.Message);
			}
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x06001C36 RID: 7222 RVA: 0x00052D70 File Offset: 0x00050F70
		[JsonIgnore]
		public int MessageLength
		{
			get
			{
				string message = this.Message;
				if (message == null)
				{
					return 0;
				}
				return message.Length;
			}
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x06001C37 RID: 7223 RVA: 0x00052D90 File Offset: 0x00050F90
		// (set) Token: 0x06001C38 RID: 7224 RVA: 0x00052DA4 File Offset: 0x00050FA4
		[JsonIgnore]
		public List<string> Phones
		{
			[CompilerGenerated]
			get
			{
				return this.<Phones>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Phones>k__BackingField, value))
				{
					return;
				}
				this.<Phones>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.Phones);
			}
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x000046B4 File Offset: 0x000028B4
		[JsonConstructor]
		private Sms(bool dummy)
		{
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x00052DD4 File Offset: 0x00050FD4
		public Sms()
		{
			this.Providers = new List<KeyValuePair<int, string>>
			{
				new KeyValuePair<int, string>(1, "SMS.RU"),
				new KeyValuePair<int, string>(2, "EpochtaSms")
			};
			if (Auth.Config.sms_config != null)
			{
				Sms sms = JsonConvert.DeserializeObject<Sms>(Auth.Config.sms_config);
				if (sms != null)
				{
					this.Provider = sms.Provider;
					this.SmsRuApiId = sms.SmsRuApiId;
					this.SmsRuLogin = sms.SmsRuLogin;
					this.SmsRuPassword = sms.SmsRuPassword;
					this.SmsRuSender = sms.SmsRuSender;
					this.AuthType = sms.AuthType;
				}
			}
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x00052E7C File Offset: 0x0005107C
		public bool SmsConfigured(bool silent = false)
		{
			if (this.Provider == 0)
			{
				if (!silent)
				{
					DXMessageBox.Show((string)Application.Current.TryFindResource("CheckSmsConfig"));
				}
				return false;
			}
			if (this.Provider == 1 && this.AuthType == 0 && (string.IsNullOrEmpty(this.SmsRuApiId) || string.IsNullOrEmpty(this.SmsRuSender)))
			{
				if (!silent)
				{
					DXMessageBox.Show((string)Application.Current.TryFindResource("CheckSmsConfig"));
				}
				return false;
			}
			if (this.Provider == 1)
			{
				if (this.AuthType == 1 || this.AuthType == 3)
				{
					if (string.IsNullOrEmpty(this.SmsRuLogin) || string.IsNullOrEmpty(this.SmsRuPassword) || string.IsNullOrEmpty(this.SmsRuSender))
					{
						if (!silent)
						{
							DXMessageBox.Show((string)Application.Current.TryFindResource("CheckSmsConfig"));
						}
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x00052F60 File Offset: 0x00051160
		private bool Ready2SendSms(IReadOnlyCollection<string> phones, string message)
		{
			if (string.IsNullOrEmpty(message))
			{
				DXMessageBox.Show((string)Application.Current.TryFindResource("MessageTooShort"));
				return false;
			}
			if (phones != null && phones.Count != 0)
			{
				return true;
			}
			DXMessageBox.Show((string)Application.Current.TryFindResource("NoSmsRecepient"));
			return false;
		}

		// Token: 0x06001C3D RID: 7229 RVA: 0x00052FBC File Offset: 0x000511BC
		[GeneratedCode("PropertyChanged.Fody", "3.1.3.0")]
		[DebuggerNonUserCode]
		protected void <>OnPropertyChanged(PropertyChangedEventArgs eventArgs)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, eventArgs);
			}
		}

		// Token: 0x04000ED4 RID: 3796
		[CompilerGenerated]
		private PropertyChangedEventHandler PropertyChanged;

		// Token: 0x04000ED5 RID: 3797
		[CompilerGenerated]
		private List<KeyValuePair<int, string>> <Providers>k__BackingField;

		// Token: 0x04000ED6 RID: 3798
		[CompilerGenerated]
		private int <Provider>k__BackingField;

		// Token: 0x04000ED7 RID: 3799
		[CompilerGenerated]
		private int <AuthType>k__BackingField;

		// Token: 0x04000ED8 RID: 3800
		[CompilerGenerated]
		private string <SmsRuApiId>k__BackingField;

		// Token: 0x04000ED9 RID: 3801
		[CompilerGenerated]
		private string <SmsRuLogin>k__BackingField;

		// Token: 0x04000EDA RID: 3802
		[CompilerGenerated]
		private string <SmsRuPassword>k__BackingField;

		// Token: 0x04000EDB RID: 3803
		[CompilerGenerated]
		private string <SmsRuSender>k__BackingField;

		// Token: 0x04000EDC RID: 3804
		[CompilerGenerated]
		private string <Message>k__BackingField;

		// Token: 0x04000EDD RID: 3805
		[CompilerGenerated]
		private List<string> <Phones>k__BackingField;
	}
}
