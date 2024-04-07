using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Input;
using ASC.Extensions.EpochtaSms;
using ASC.Extensions.SmsRu;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Options;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using Autofac;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels
{
	// Token: 0x02000418 RID: 1048
	public class SmsSendViewModel : ViewModelBase
	{
		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x06002A06 RID: 10758 RVA: 0x00084670 File Offset: 0x00082870
		// (set) Token: 0x06002A07 RID: 10759 RVA: 0x00084684 File Offset: 0x00082884
		public SmsClientConfig SmsClientConfig
		{
			[CompilerGenerated]
			get
			{
				return this.<SmsClientConfig>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<SmsClientConfig>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1027787028;
				IL_13:
				switch ((num ^ -884927579) % 4)
				{
				case 1:
					return;
				case 2:
					goto IL_0E;
				case 3:
					IL_32:
					this.<SmsClientConfig>k__BackingField = value;
					num = -468290403;
					goto IL_13;
				}
				this.RaisePropertyChanged("SmsClientConfig");
			}
		}

		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x06002A08 RID: 10760 RVA: 0x000846E0 File Offset: 0x000828E0
		// (set) Token: 0x06002A09 RID: 10761 RVA: 0x000846F4 File Offset: 0x000828F4
		public List<PhoneOptions> PhoneOptions
		{
			[CompilerGenerated]
			get
			{
				return this.<PhoneOptions>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<PhoneOptions>k__BackingField, value))
				{
					return;
				}
				this.<PhoneOptions>k__BackingField = value;
				this.RaisePropertyChanged("PhoneOptions");
			}
		}

		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x06002A0A RID: 10762 RVA: 0x00084724 File Offset: 0x00082924
		// (set) Token: 0x06002A0B RID: 10763 RVA: 0x00084738 File Offset: 0x00082938
		public int SelectedPhoneMask
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedPhoneMask>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedPhoneMask>k__BackingField == value)
				{
					return;
				}
				this.<SelectedPhoneMask>k__BackingField = value;
				this.RaisePropertyChanged("SelectedPhoneMask");
			}
		}

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x06002A0C RID: 10764 RVA: 0x00084764 File Offset: 0x00082964
		// (set) Token: 0x06002A0D RID: 10765 RVA: 0x00084778 File Offset: 0x00082978
		public string SmsRecepient
		{
			[CompilerGenerated]
			get
			{
				return this.<SmsRecepient>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<SmsRecepient>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<SmsRecepient>k__BackingField = value;
				this.RaisePropertyChanged("SmsRecepient");
			}
		}

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x06002A0E RID: 10766 RVA: 0x000847A8 File Offset: 0x000829A8
		// (set) Token: 0x06002A0F RID: 10767 RVA: 0x000847BC File Offset: 0x000829BC
		public bool ExistClient
		{
			[CompilerGenerated]
			get
			{
				return this.<ExistClient>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ExistClient>k__BackingField == value)
				{
					return;
				}
				this.<ExistClient>k__BackingField = value;
				this.RaisePropertyChanged("NoClient");
				this.RaisePropertyChanged("ExistClient");
			}
		}

		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x06002A10 RID: 10768 RVA: 0x000847F4 File Offset: 0x000829F4
		public bool NoClient
		{
			get
			{
				return !this.ExistClient;
			}
		}

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x06002A11 RID: 10769 RVA: 0x0008480C File Offset: 0x00082A0C
		// (set) Token: 0x06002A12 RID: 10770 RVA: 0x00084820 File Offset: 0x00082A20
		public List<string> ClientPhones
		{
			[CompilerGenerated]
			get
			{
				return this.<ClientPhones>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ClientPhones>k__BackingField, value))
				{
					return;
				}
				this.<ClientPhones>k__BackingField = value;
				this.RaisePropertyChanged("ClientPhones");
			}
		}

		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x06002A13 RID: 10771 RVA: 0x00084850 File Offset: 0x00082A50
		// (set) Token: 0x06002A14 RID: 10772 RVA: 0x00084864 File Offset: 0x00082A64
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
				this.RaisePropertyChanged("MessageLength");
				this.RaisePropertyChanged("Message");
			}
		}

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x06002A15 RID: 10773 RVA: 0x000848A0 File Offset: 0x00082AA0
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

		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x06002A16 RID: 10774 RVA: 0x000848C0 File Offset: 0x00082AC0
		// (set) Token: 0x06002A17 RID: 10775 RVA: 0x000848D4 File Offset: 0x00082AD4
		public int ClientId
		{
			[CompilerGenerated]
			get
			{
				return this.<ClientId>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<ClientId>k__BackingField == value)
				{
					return;
				}
				this.<ClientId>k__BackingField = value;
				this.RaisePropertyChanged("ClientId");
			}
		}

		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x06002A18 RID: 10776 RVA: 0x00084900 File Offset: 0x00082B00
		// (set) Token: 0x06002A19 RID: 10777 RVA: 0x00084914 File Offset: 0x00082B14
		public ICommand SendSmsCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<SendSmsCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<SendSmsCommand>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1164748689;
				IL_13:
				switch ((num ^ 135711556) % 4)
				{
				case 0:
					IL_32:
					num = 4325351;
					goto IL_13;
				case 1:
					return;
				case 2:
					goto IL_0E;
				}
				this.<SendSmsCommand>k__BackingField = value;
				this.RaisePropertyChanged("SendSmsCommand");
			}
		}

		// Token: 0x06002A1A RID: 10778 RVA: 0x00084970 File Offset: 0x00082B70
		private void InitCommands()
		{
			this.SendSmsCommand = new RelayCommand(new Action<object>(this.SendSms), new Func<bool>(this.CanSendSms));
		}

		// Token: 0x06002A1B RID: 10779 RVA: 0x000849A0 File Offset: 0x00082BA0
		private bool CanSendSms()
		{
			return this.SmsClientConfig != null && OfflineData.Instance.Employee.Can(63, 0);
		}

		// Token: 0x06002A1C RID: 10780 RVA: 0x000849CC File Offset: 0x00082BCC
		public SmsSendViewModel()
		{
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this.PhoneOptions = new PhoneOptions().GetAllOptions();
			this.SmsClientConfig = SmsModel.GetSmsClientConfig();
			this.InitCommands();
		}

		// Token: 0x06002A1D RID: 10781 RVA: 0x00084A20 File Offset: 0x00082C20
		public SmsSendViewModel(int clientId) : this()
		{
			this.ClientId = clientId;
			this.SetRecepient(clientId);
		}

		// Token: 0x06002A1E RID: 10782 RVA: 0x00084A44 File Offset: 0x00082C44
		public SmsSendViewModel(string phone) : this()
		{
			this.SmsRecepient = phone;
		}

		// Token: 0x06002A1F RID: 10783 RVA: 0x00084A60 File Offset: 0x00082C60
		private void SetRecepient(int clientId)
		{
			SmsSendViewModel.<SetRecepient>d__47 <SetRecepient>d__;
			<SetRecepient>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SetRecepient>d__.<>4__this = this;
			<SetRecepient>d__.clientId = clientId;
			<SetRecepient>d__.<>1__state = -1;
			<SetRecepient>d__.<>t__builder.Start<SmsSendViewModel.<SetRecepient>d__47>(ref <SetRecepient>d__);
		}

		// Token: 0x06002A20 RID: 10784 RVA: 0x00084AA0 File Offset: 0x00082CA0
		private bool CheckFields()
		{
			if (string.IsNullOrEmpty(this.SmsRecepient))
			{
				this._toasterService.Info(Lang.t("InputPhone"));
				return false;
			}
			if (!string.IsNullOrEmpty(this.Message))
			{
				return true;
			}
			this._toasterService.Info(Lang.t("MessageTooShort"));
			return false;
		}

		// Token: 0x06002A21 RID: 10785 RVA: 0x00084AF8 File Offset: 0x00082CF8
		private void SendSms(object obj)
		{
			SmsSendViewModel.<SendSms>d__49 <SendSms>d__;
			<SendSms>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SendSms>d__.<>4__this = this;
			<SendSms>d__.<>1__state = -1;
			<SendSms>d__.<>t__builder.Start<SmsSendViewModel.<SendSms>d__49>(ref <SendSms>d__);
		}

		// Token: 0x06002A22 RID: 10786 RVA: 0x00084B30 File Offset: 0x00082D30
		[Command]
		public void Close()
		{
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x0400175A RID: 5978
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x0400175B RID: 5979
		private readonly IToasterService _toasterService;

		// Token: 0x0400175C RID: 5980
		[CompilerGenerated]
		private SmsClientConfig <SmsClientConfig>k__BackingField;

		// Token: 0x0400175D RID: 5981
		[CompilerGenerated]
		private List<PhoneOptions> <PhoneOptions>k__BackingField;

		// Token: 0x0400175E RID: 5982
		[CompilerGenerated]
		private int <SelectedPhoneMask>k__BackingField;

		// Token: 0x0400175F RID: 5983
		[CompilerGenerated]
		private string <SmsRecepient>k__BackingField;

		// Token: 0x04001760 RID: 5984
		[CompilerGenerated]
		private bool <ExistClient>k__BackingField;

		// Token: 0x04001761 RID: 5985
		[CompilerGenerated]
		private List<string> <ClientPhones>k__BackingField;

		// Token: 0x04001762 RID: 5986
		[CompilerGenerated]
		private string <Message>k__BackingField;

		// Token: 0x04001763 RID: 5987
		[CompilerGenerated]
		private int <ClientId>k__BackingField;

		// Token: 0x04001764 RID: 5988
		[CompilerGenerated]
		private ICommand <SendSmsCommand>k__BackingField;

		// Token: 0x02000419 RID: 1049
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002A23 RID: 10787 RVA: 0x00084B48 File Offset: 0x00082D48
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06002A24 RID: 10788 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06002A25 RID: 10789 RVA: 0x00084B60 File Offset: 0x00082D60
			internal string <SetRecepient>b__47_0(Tel p)
			{
				return p.Phone;
			}

			// Token: 0x04001765 RID: 5989
			public static readonly SmsSendViewModel.<>c <>9 = new SmsSendViewModel.<>c();

			// Token: 0x04001766 RID: 5990
			public static Func<Tel, string> <>9__47_0;
		}

		// Token: 0x0200041A RID: 1050
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SetRecepient>d__47 : IAsyncStateMachine
		{
			// Token: 0x06002A26 RID: 10790 RVA: 0x00084B74 File Offset: 0x00082D74
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				SmsSendViewModel smsSendViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<CustomerCard> awaiter;
					if (num != 0)
					{
						awaiter = ClientsModel.GetCustomerCard(this.clientId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<CustomerCard>, SmsSendViewModel.<SetRecepient>d__47>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<CustomerCard>);
						this.<>1__state = -1;
					}
					CustomerCard result = awaiter.GetResult();
					if (((result != null) ? result.Phones : null) != null && result.Phones.Any<Tel>())
					{
						smsSendViewModel.ClientPhones = result.Phones.Select(new Func<Tel, string>(SmsSendViewModel.<>c.<>9.<SetRecepient>b__47_0)).ToList<string>();
						smsSendViewModel.SmsRecepient = result.Phone;
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002A27 RID: 10791 RVA: 0x00084C90 File Offset: 0x00082E90
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001767 RID: 5991
			public int <>1__state;

			// Token: 0x04001768 RID: 5992
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001769 RID: 5993
			public int clientId;

			// Token: 0x0400176A RID: 5994
			public SmsSendViewModel <>4__this;

			// Token: 0x0400176B RID: 5995
			private TaskAwaiter<CustomerCard> <>u__1;
		}

		// Token: 0x0200041B RID: 1051
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SendSms>d__49 : IAsyncStateMachine
		{
			// Token: 0x06002A28 RID: 10792 RVA: 0x00084CAC File Offset: 0x00082EAC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				SmsSendViewModel smsSendViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						IL_F0:
						while (smsSendViewModel.CheckFields())
						{
							SmsClientConfig smsClientConfig;
							ISmsClient smsClient;
							for (;;)
							{
								IL_E8:
								smsClientConfig = SmsModel.GetSmsClientConfig();
								IL_E3:
								while (smsClientConfig != null)
								{
									for (;;)
									{
										IL_D7:
										smsClient = null;
										int provider = smsClientConfig.Provider;
										for (;;)
										{
											IL_BD:
											switch (provider)
											{
											case 1:
												goto IL_102;
											case 2:
												goto IL_10B;
											case 3:
												goto IL_114;
											default:
											{
												uint num3;
												uint num2 = num3 * 160321888U ^ 4133514684U;
												for (;;)
												{
													switch ((num3 = (num2 ^ 113297637U)) % 28U)
													{
													case 0U:
														goto IL_1A7;
													case 1U:
														goto IL_178;
													case 2U:
													case 15U:
													case 26U:
														goto IL_124;
													case 4U:
														goto IL_E8;
													case 5U:
														goto IL_18E;
													case 6U:
													case 12U:
														goto IL_F0;
													case 7U:
														goto IL_114;
													case 9U:
														goto IL_10B;
													case 10U:
														goto IL_E3;
													case 11U:
														goto IL_102;
													case 13U:
														num2 = (num3 * 3277052591U ^ 1133883812U);
														continue;
													case 14U:
														goto IL_D7;
													case 16U:
														goto IL_BD;
													case 17U:
														goto IL_180;
													case 18U:
														goto IL_1B0;
													case 19U:
														goto IL_193;
													case 20U:
														goto IL_1D0;
													case 22U:
														goto IL_1B9;
													case 23U:
														goto IL_132;
													case 24U:
														goto IL_16F;
													case 25U:
														goto IL_12A;
													case 27U:
														goto IL_166;
													}
													goto Block_4;
												}
												break;
											}
											}
										}
									}
								}
								break;
							}
							Block_4:
							break;
							IL_102:
							smsClient = new SmsRuClient(smsClientConfig);
							goto IL_124;
							IL_10B:
							smsClient = new EpochtaSmsClient(smsClientConfig);
							goto IL_124;
							IL_114:
							smsClient = Bootstrapper.Container.ResolveKeyed("SMSC");
							IL_124:
							if (smsClient == null)
							{
								break;
							}
							IL_12A:
							int? num4;
							if (smsSendViewModel.ClientId == 0)
							{
								num4 = null;
								goto IL_149;
							}
							IL_132:
							num4 = new int?(smsSendViewModel.ClientId);
							IL_149:
							int? customerId = num4;
							awaiter = smsClient.SendAsync(smsSendViewModel.SmsRecepient, smsSendViewModel.Message, customerId).GetAwaiter();
							IL_166:
							if (awaiter.IsCompleted)
							{
								goto IL_1B0;
							}
							IL_16F:
							this.<>1__state = 0;
							IL_178:
							this.<>u__1 = awaiter;
							IL_180:
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, SmsSendViewModel.<SendSms>d__49>(ref awaiter, ref this);
							IL_18E:
							return;
						}
						goto IL_20B;
					}
					IL_193:
					awaiter = this.<>u__1;
					this.<>u__1 = default(TaskAwaiter<bool>);
					IL_1A7:
					this.<>1__state = -1;
					IL_1B0:
					if (awaiter.GetResult())
					{
						goto IL_1D0;
					}
					IL_1B9:
					smsSendViewModel._toasterService.Error(Lang.t("MessageSendError"));
					goto IL_1F0;
					IL_1D0:
					smsSendViewModel._toasterService.Success(Lang.t("MessageAccepted"));
					smsSendViewModel._windowedDocumentService.CloseActiveDocument();
					IL_1F0:;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_20B:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002A29 RID: 10793 RVA: 0x00084EF4 File Offset: 0x000830F4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400176C RID: 5996
			public int <>1__state;

			// Token: 0x0400176D RID: 5997
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400176E RID: 5998
			public SmsSendViewModel <>4__this;

			// Token: 0x0400176F RID: 5999
			private TaskAwaiter<bool> <>u__1;
		}
	}
}
