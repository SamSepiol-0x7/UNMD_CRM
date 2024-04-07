using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Input;
using ASC.Interfaces;
using ASC.Models;
using ASC.Options;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels.ACP
{
	// Token: 0x02000595 RID: 1429
	public class NotifyViewModel : BaseViewModel
	{
		// Token: 0x17000FF3 RID: 4083
		// (get) Token: 0x060034AC RID: 13484 RVA: 0x000B32F8 File Offset: 0x000B14F8
		// (set) Token: 0x060034AD RID: 13485 RVA: 0x000B330C File Offset: 0x000B150C
		public Email Email
		{
			[CompilerGenerated]
			get
			{
				return this.<Email>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Email>k__BackingField, value))
				{
					return;
				}
				this.<Email>k__BackingField = value;
				this.RaisePropertyChanged("Email");
			}
		}

		// Token: 0x17000FF4 RID: 4084
		// (get) Token: 0x060034AE RID: 13486 RVA: 0x000B333C File Offset: 0x000B153C
		// (set) Token: 0x060034AF RID: 13487 RVA: 0x000B3350 File Offset: 0x000B1550
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
				if (object.Equals(this.<SmsClientConfig>k__BackingField, value))
				{
					return;
				}
				this.<SmsClientConfig>k__BackingField = value;
				this.RaisePropertyChanged("SmsClientConfig");
			}
		}

		// Token: 0x17000FF5 RID: 4085
		// (get) Token: 0x060034B0 RID: 13488 RVA: 0x000B3380 File Offset: 0x000B1580
		// (set) Token: 0x060034B1 RID: 13489 RVA: 0x000B3394 File Offset: 0x000B1594
		public Dictionary<int, string> Providers
		{
			[CompilerGenerated]
			get
			{
				return this.<Providers>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				if (object.Equals(this.<Providers>k__BackingField, value))
				{
					return;
				}
				this.<Providers>k__BackingField = value;
				this.RaisePropertyChanged("Providers");
			}
		}

		// Token: 0x17000FF6 RID: 4086
		// (get) Token: 0x060034B2 RID: 13490 RVA: 0x000B33C4 File Offset: 0x000B15C4
		// (set) Token: 0x060034B3 RID: 13491 RVA: 0x000B33D8 File Offset: 0x000B15D8
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
				if (!object.Equals(this.<PhoneOptions>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1058729974;
				IL_13:
				switch ((num ^ 1802698579) % 4)
				{
				case 1:
					return;
				case 2:
					IL_32:
					this.<PhoneOptions>k__BackingField = value;
					this.RaisePropertyChanged("PhoneOptions");
					num = 1433141151;
					goto IL_13;
				case 3:
					goto IL_0E;
				}
			}
		}

		// Token: 0x17000FF7 RID: 4087
		// (get) Token: 0x060034B4 RID: 13492 RVA: 0x000B3434 File Offset: 0x000B1634
		// (set) Token: 0x060034B5 RID: 13493 RVA: 0x000B3448 File Offset: 0x000B1648
		public string SmsTestRecepient
		{
			[CompilerGenerated]
			get
			{
				return this.<SmsTestRecepient>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<SmsTestRecepient>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<SmsTestRecepient>k__BackingField = value;
				this.RaisePropertyChanged("SmsTestRecepient");
			}
		}

		// Token: 0x17000FF8 RID: 4088
		// (get) Token: 0x060034B6 RID: 13494 RVA: 0x000B3478 File Offset: 0x000B1678
		// (set) Token: 0x060034B7 RID: 13495 RVA: 0x000B348C File Offset: 0x000B168C
		public string TestMessage
		{
			[CompilerGenerated]
			get
			{
				return this.<TestMessage>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<TestMessage>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<TestMessage>k__BackingField = value;
				this.RaisePropertyChanged("TestMessageLength");
				this.RaisePropertyChanged("TestMessage");
			}
		}

		// Token: 0x17000FF9 RID: 4089
		// (get) Token: 0x060034B8 RID: 13496 RVA: 0x000B34C8 File Offset: 0x000B16C8
		public int TestMessageLength
		{
			get
			{
				string testMessage = this.TestMessage;
				if (testMessage == null)
				{
					return 0;
				}
				return testMessage.Length;
			}
		}

		// Token: 0x17000FFA RID: 4090
		// (get) Token: 0x060034B9 RID: 13497 RVA: 0x000B34E8 File Offset: 0x000B16E8
		// (set) Token: 0x060034BA RID: 13498 RVA: 0x000B34FC File Offset: 0x000B16FC
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
				if (this.<SelectedPhoneMask>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -1928361978;
				IL_10:
				switch ((num ^ -1217251332) % 4)
				{
				case 1:
					IL_2F:
					this.<SelectedPhoneMask>k__BackingField = value;
					num = -218040256;
					goto IL_10;
				case 2:
					return;
				case 3:
					goto IL_0B;
				}
				this.RaisePropertyChanged("SelectedPhoneMask");
			}
		}

		// Token: 0x17000FFB RID: 4091
		// (get) Token: 0x060034BB RID: 13499 RVA: 0x000B3554 File Offset: 0x000B1754
		// (set) Token: 0x060034BC RID: 13500 RVA: 0x000B3568 File Offset: 0x000B1768
		public ObservableCollection<sms_templates> SmsTemplateses
		{
			[CompilerGenerated]
			get
			{
				return this.<SmsTemplateses>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SmsTemplateses>k__BackingField, value))
				{
					return;
				}
				this.<SmsTemplateses>k__BackingField = value;
				this.RaisePropertyChanged("SmsTemplateses");
			}
		}

		// Token: 0x17000FFC RID: 4092
		// (get) Token: 0x060034BD RID: 13501 RVA: 0x000B3598 File Offset: 0x000B1798
		// (set) Token: 0x060034BE RID: 13502 RVA: 0x000B35AC File Offset: 0x000B17AC
		public bool EpochtaFieldsVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<EpochtaFieldsVisible>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<EpochtaFieldsVisible>k__BackingField == value)
				{
					return;
				}
				this.<EpochtaFieldsVisible>k__BackingField = value;
				this.RaisePropertyChanged("EpochtaFieldsVisible");
			}
		}

		// Token: 0x17000FFD RID: 4093
		// (get) Token: 0x060034BF RID: 13503 RVA: 0x000B35D8 File Offset: 0x000B17D8
		// (set) Token: 0x060034C0 RID: 13504 RVA: 0x000B35EC File Offset: 0x000B17EC
		public bool SmsRuFieldsVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<SmsRuFieldsVisible>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<SmsRuFieldsVisible>k__BackingField == value)
				{
					return;
				}
				this.<SmsRuFieldsVisible>k__BackingField = value;
				this.RaisePropertyChanged("SmsRuFieldsVisible");
			}
		}

		// Token: 0x17000FFE RID: 4094
		// (get) Token: 0x060034C1 RID: 13505 RVA: 0x000B3618 File Offset: 0x000B1818
		// (set) Token: 0x060034C2 RID: 13506 RVA: 0x000B362C File Offset: 0x000B182C
		public bool EmailRawTemplateVisible
		{
			get
			{
				return this._emailRawTemplateVisible;
			}
			set
			{
				if (this._emailRawTemplateVisible == value)
				{
					return;
				}
				this._emailRawTemplateVisible = value;
				this.RaisePropertyChanged("EmailRawTemplateVisible");
				if (value)
				{
					this.Email.RawTemplate = this.Email.Template;
				}
				else
				{
					this.Email.Template = this.Email.RawTemplate;
				}
			}
		}

		// Token: 0x17000FFF RID: 4095
		// (get) Token: 0x060034C3 RID: 13507 RVA: 0x000B3688 File Offset: 0x000B1888
		// (set) Token: 0x060034C4 RID: 13508 RVA: 0x000B369C File Offset: 0x000B189C
		public ICommand SaveSmsRuSettingsCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<SaveSmsRuSettingsCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SaveSmsRuSettingsCommand>k__BackingField, value))
				{
					return;
				}
				this.<SaveSmsRuSettingsCommand>k__BackingField = value;
				this.RaisePropertyChanged("SaveSmsRuSettingsCommand");
			}
		}

		// Token: 0x17001000 RID: 4096
		// (get) Token: 0x060034C5 RID: 13509 RVA: 0x000B36CC File Offset: 0x000B18CC
		// (set) Token: 0x060034C6 RID: 13510 RVA: 0x000B36E0 File Offset: 0x000B18E0
		public ICommand BalanceSmsRuCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<BalanceSmsRuCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<BalanceSmsRuCommand>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1029457038;
				IL_13:
				switch ((num ^ 2039382515) % 4)
				{
				case 1:
					return;
				case 2:
					goto IL_0E;
				case 3:
					IL_32:
					this.<BalanceSmsRuCommand>k__BackingField = value;
					this.RaisePropertyChanged("BalanceSmsRuCommand");
					num = 92541671;
					goto IL_13;
				}
			}
		}

		// Token: 0x17001001 RID: 4097
		// (get) Token: 0x060034C7 RID: 13511 RVA: 0x000B373C File Offset: 0x000B193C
		// (set) Token: 0x060034C8 RID: 13512 RVA: 0x000B3750 File Offset: 0x000B1950
		public ICommand DelTemplateCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<DelTemplateCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<DelTemplateCommand>k__BackingField, value))
				{
					return;
				}
				this.<DelTemplateCommand>k__BackingField = value;
				this.RaisePropertyChanged("DelTemplateCommand");
			}
		}

		// Token: 0x17001002 RID: 4098
		// (get) Token: 0x060034C9 RID: 13513 RVA: 0x000B3780 File Offset: 0x000B1980
		// (set) Token: 0x060034CA RID: 13514 RVA: 0x000B3794 File Offset: 0x000B1994
		public ICommand SmsProvidecChangedCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<SmsProvidecChangedCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SmsProvidecChangedCommand>k__BackingField, value))
				{
					return;
				}
				this.<SmsProvidecChangedCommand>k__BackingField = value;
				this.RaisePropertyChanged("SmsProvidecChangedCommand");
			}
		}

		// Token: 0x060034CB RID: 13515 RVA: 0x000B37C4 File Offset: 0x000B19C4
		private void InitCommands()
		{
			this.SaveSmsRuSettingsCommand = new RelayCommand(new Action<object>(this.SaveSmsConfig));
			this.BalanceSmsRuCommand = new RelayCommand(new Action<object>(this.BalanceCheck));
			this.DelTemplateCommand = new RelayCommand(new Action<object>(this.DelTemplate));
			this.SmsProvidecChangedCommand = new RelayCommand(new Action<object>(this.SmsProviderChanged));
		}

		// Token: 0x060034CC RID: 13516 RVA: 0x000B3830 File Offset: 0x000B1A30
		public NotifyViewModel()
		{
			this._ascMessageBoxService = Bootstrapper.Container.Resolve<IAscMessageBoxService>();
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
			this.PhoneOptions = new PhoneOptions().GetAllOptions();
			this.Init();
			this.InitCommands();
		}

		// Token: 0x060034CD RID: 13517 RVA: 0x000B3894 File Offset: 0x000B1A94
		[Command]
		public void SaveEmail()
		{
			if (this.EmailRawTemplateVisible)
			{
				this.Email.Template = this.Email.RawTemplate;
			}
			bool response;
			if (response = SmsModel.SaveEmailConfig(this.Email))
			{
				this.Init();
			}
			base.ShowActionResponse(response, "");
		}

		// Token: 0x060034CE RID: 13518 RVA: 0x000306B8 File Offset: 0x0002E8B8
		public bool CanSaveEmail()
		{
			return base.IsValid();
		}

		// Token: 0x060034CF RID: 13519 RVA: 0x000B38E0 File Offset: 0x000B1AE0
		private void SaveSmsConfig(object obj)
		{
			bool response;
			if (response = SmsModel.SaveSmsConfig(this.SmsClientConfig))
			{
				this.Init();
			}
			base.ShowActionResponse(response, "");
		}

		// Token: 0x060034D0 RID: 13520 RVA: 0x000B3910 File Offset: 0x000B1B10
		private void BalanceCheck(object obj)
		{
			NotifyViewModel.<BalanceCheck>d__69 <BalanceCheck>d__;
			<BalanceCheck>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<BalanceCheck>d__.<>4__this = this;
			<BalanceCheck>d__.<>1__state = -1;
			<BalanceCheck>d__.<>t__builder.Start<NotifyViewModel.<BalanceCheck>d__69>(ref <BalanceCheck>d__);
		}

		// Token: 0x060034D1 RID: 13521 RVA: 0x000B3948 File Offset: 0x000B1B48
		private void DelTemplate(object obj)
		{
			if (obj == null)
			{
				return;
			}
			sms_templates sms_templates = obj as sms_templates;
			if (sms_templates != null && sms_templates.id == 0)
			{
				this.SmsTemplateses.Remove(sms_templates);
				base.ShowActionResponse(true, "");
				return;
			}
			if (sms_templates != null && sms_templates.id > 0)
			{
				bool response;
				if (response = SmsModel.RemoveSmsTemplate(sms_templates))
				{
					this.SmsTemplateses.Remove(sms_templates);
				}
				base.ShowActionResponse(response, "");
			}
		}

		// Token: 0x060034D2 RID: 13522 RVA: 0x000B39B4 File Offset: 0x000B1BB4
		[Command]
		public void SaveSmsTemplates()
		{
			bool response;
			if (response = SmsModel.SaveSmsTemplates(this.SmsTemplateses))
			{
				this.Init();
			}
			base.ShowActionResponse(response, "");
		}

		// Token: 0x060034D3 RID: 13523 RVA: 0x000306B8 File Offset: 0x0002E8B8
		public bool CanSaveSmsTemplates()
		{
			return base.IsValid();
		}

		// Token: 0x060034D4 RID: 13524 RVA: 0x000B39E4 File Offset: 0x000B1BE4
		private void Init()
		{
			this.Email = new Email();
			this.SmsTemplateses = new ObservableCollection<sms_templates>(SmsModel.LoadTemplates());
			ISmsService smsService = Bootstrapper.Container.Resolve<ISmsService>();
			this.Providers = smsService.GetSmsGateways();
			SmsClientConfig smsClientConfig;
			if ((smsClientConfig = SmsModel.GetSmsClientConfig()) == null)
			{
				(smsClientConfig = new SmsClientConfig()).Provider = 1;
			}
			this.SmsClientConfig = smsClientConfig;
			this.SmsProviderChanged(null);
		}

		// Token: 0x060034D5 RID: 13525 RVA: 0x000B3A48 File Offset: 0x000B1C48
		private void SmsProviderChanged(object obj)
		{
			SmsClientConfig smsClientConfig = this.SmsClientConfig;
			bool epochtaFieldsVisible;
			if (smsClientConfig == null || smsClientConfig.Provider != 2)
			{
				SmsClientConfig smsClientConfig2 = this.SmsClientConfig;
				epochtaFieldsVisible = (smsClientConfig2 != null && smsClientConfig2.Provider == 3);
			}
			else
			{
				epochtaFieldsVisible = true;
			}
			this.EpochtaFieldsVisible = epochtaFieldsVisible;
			SmsClientConfig smsClientConfig3 = this.SmsClientConfig;
			this.SmsRuFieldsVisible = (smsClientConfig3 != null && smsClientConfig3.Provider == 1);
		}

		// Token: 0x060034D6 RID: 13526 RVA: 0x000B3AA8 File Offset: 0x000B1CA8
		[Command]
		public void SmsTest()
		{
			this._windowedDocumentService.ShowNewDocument("SmsSendView", new SmsSendViewModel(), null, null);
		}

		// Token: 0x04001E66 RID: 7782
		private readonly IAscMessageBoxService _ascMessageBoxService;

		// Token: 0x04001E67 RID: 7783
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04001E68 RID: 7784
		private bool _emailRawTemplateVisible;

		// Token: 0x04001E69 RID: 7785
		[CompilerGenerated]
		private Email <Email>k__BackingField;

		// Token: 0x04001E6A RID: 7786
		[CompilerGenerated]
		private SmsClientConfig <SmsClientConfig>k__BackingField = new SmsClientConfig();

		// Token: 0x04001E6B RID: 7787
		[CompilerGenerated]
		private Dictionary<int, string> <Providers>k__BackingField;

		// Token: 0x04001E6C RID: 7788
		[CompilerGenerated]
		private List<PhoneOptions> <PhoneOptions>k__BackingField;

		// Token: 0x04001E6D RID: 7789
		[CompilerGenerated]
		private string <SmsTestRecepient>k__BackingField;

		// Token: 0x04001E6E RID: 7790
		[CompilerGenerated]
		private string <TestMessage>k__BackingField;

		// Token: 0x04001E6F RID: 7791
		[CompilerGenerated]
		private int <SelectedPhoneMask>k__BackingField = 1;

		// Token: 0x04001E70 RID: 7792
		[CompilerGenerated]
		private ObservableCollection<sms_templates> <SmsTemplateses>k__BackingField;

		// Token: 0x04001E71 RID: 7793
		[CompilerGenerated]
		private bool <EpochtaFieldsVisible>k__BackingField;

		// Token: 0x04001E72 RID: 7794
		[CompilerGenerated]
		private bool <SmsRuFieldsVisible>k__BackingField;

		// Token: 0x04001E73 RID: 7795
		[CompilerGenerated]
		private ICommand <SaveSmsRuSettingsCommand>k__BackingField;

		// Token: 0x04001E74 RID: 7796
		[CompilerGenerated]
		private ICommand <BalanceSmsRuCommand>k__BackingField;

		// Token: 0x04001E75 RID: 7797
		[CompilerGenerated]
		private ICommand <DelTemplateCommand>k__BackingField;

		// Token: 0x04001E76 RID: 7798
		[CompilerGenerated]
		private ICommand <SmsProvidecChangedCommand>k__BackingField;

		// Token: 0x02000596 RID: 1430
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <BalanceCheck>d__69 : IAsyncStateMachine
		{
			// Token: 0x060034D7 RID: 13527 RVA: 0x000B3ACC File Offset: 0x000B1CCC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NotifyViewModel notifyViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<string> awaiter;
					if (num != 0)
					{
						awaiter = SmsModel.GetBalance().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, NotifyViewModel.<BalanceCheck>d__69>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<string>);
						this.<>1__state = -1;
					}
					string result = awaiter.GetResult();
					notifyViewModel._ascMessageBoxService.ShowMessageBox("", result);
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

			// Token: 0x060034D8 RID: 13528 RVA: 0x000B3B94 File Offset: 0x000B1D94
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001E77 RID: 7799
			public int <>1__state;

			// Token: 0x04001E78 RID: 7800
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001E79 RID: 7801
			public NotifyViewModel <>4__this;

			// Token: 0x04001E7A RID: 7802
			private TaskAwaiter<string> <>u__1;
		}
	}
}
