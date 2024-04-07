using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ASC.Common.Enum;
using ASC.Common.Interfaces;
using ASC.Common.Interfaces.VoIP;
using ASC.Common.Models;
using ASC.Common.Objects;
using ASC.Common.Objects.VoIP;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Options;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using Autofac;
using DevExpress.Mvvm.POCO;

namespace ASC.ViewModels.ACP
{
	// Token: 0x0200054A RID: 1354
	public class AcpViewModel : BaseViewModel, ICVMActions
	{
		// Token: 0x17000F6B RID: 3947
		// (get) Token: 0x0600323A RID: 12858 RVA: 0x000A84E8 File Offset: 0x000A66E8
		// (set) Token: 0x0600323B RID: 12859 RVA: 0x000A84FC File Offset: 0x000A66FC
		public List<Warranty> WarrantyList
		{
			[CompilerGenerated]
			get
			{
				return this.<WarrantyList>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<WarrantyList>k__BackingField, value))
				{
					return;
				}
				this.<WarrantyList>k__BackingField = value;
				this.RaisePropertyChanged("WarrantyList");
			}
		}

		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x0600323C RID: 12860 RVA: 0x000A852C File Offset: 0x000A672C
		// (set) Token: 0x0600323D RID: 12861 RVA: 0x000A8540 File Offset: 0x000A6740
		public config Config
		{
			[CompilerGenerated]
			get
			{
				return this.<Config>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Config>k__BackingField, value))
				{
					return;
				}
				this.<Config>k__BackingField = value;
				this.RaisePropertyChanged("Config");
			}
		}

		// Token: 0x17000F6D RID: 3949
		// (get) Token: 0x0600323E RID: 12862 RVA: 0x000A8570 File Offset: 0x000A6770
		// (set) Token: 0x0600323F RID: 12863 RVA: 0x000A8584 File Offset: 0x000A6784
		public ReadOnlyCollection<TimeZoneInfo> TimeZonesList
		{
			[CompilerGenerated]
			get
			{
				return this.<TimeZonesList>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(this.<TimeZonesList>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -184162700;
				IL_13:
				switch ((num ^ -1706216787) % 4)
				{
				case 0:
					IL_32:
					this.<TimeZonesList>k__BackingField = value;
					this.RaisePropertyChanged("TimeZonesList");
					num = -285352629;
					goto IL_13;
				case 1:
					return;
				case 3:
					goto IL_0E;
				}
			}
		}

		// Token: 0x17000F6E RID: 3950
		// (get) Token: 0x06003240 RID: 12864 RVA: 0x000A85E0 File Offset: 0x000A67E0
		// (set) Token: 0x06003241 RID: 12865 RVA: 0x000A85F4 File Offset: 0x000A67F4
		public Currency Currency
		{
			[CompilerGenerated]
			get
			{
				return this.<Currency>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Currency>k__BackingField, value))
				{
					return;
				}
				this.<Currency>k__BackingField = value;
				this.RaisePropertyChanged("Currency");
			}
		}

		// Token: 0x17000F6F RID: 3951
		// (get) Token: 0x06003242 RID: 12866 RVA: 0x000A8624 File Offset: 0x000A6824
		// (set) Token: 0x06003243 RID: 12867 RVA: 0x000A8638 File Offset: 0x000A6838
		public List<IIdName> VoIPClients
		{
			[CompilerGenerated]
			get
			{
				return this.<VoIPClients>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<VoIPClients>k__BackingField, value))
				{
					return;
				}
				this.<VoIPClients>k__BackingField = value;
				this.RaisePropertyChanged("VoIPClients");
			}
		}

		// Token: 0x17000F70 RID: 3952
		// (get) Token: 0x06003244 RID: 12868 RVA: 0x000A8668 File Offset: 0x000A6868
		// (set) Token: 0x06003245 RID: 12869 RVA: 0x000A867C File Offset: 0x000A687C
		public List<IIdName> OnlineStores
		{
			[CompilerGenerated]
			get
			{
				return this.<OnlineStores>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<OnlineStores>k__BackingField, value))
				{
					return;
				}
				this.<OnlineStores>k__BackingField = value;
				this.RaisePropertyChanged("OnlineStores");
			}
		}

		// Token: 0x17000F71 RID: 3953
		// (get) Token: 0x06003246 RID: 12870 RVA: 0x000A86AC File Offset: 0x000A68AC
		// (set) Token: 0x06003247 RID: 12871 RVA: 0x000A86C0 File Offset: 0x000A68C0
		public AsteriskRealtimeViewModel AsteriskRealtimeViewModel
		{
			[CompilerGenerated]
			get
			{
				return this.<AsteriskRealtimeViewModel>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<AsteriskRealtimeViewModel>k__BackingField, value))
				{
					return;
				}
				this.<AsteriskRealtimeViewModel>k__BackingField = value;
				this.RaisePropertyChanged("AsteriskRealtimeViewModel");
			}
		}

		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x06003248 RID: 12872 RVA: 0x000A86F0 File Offset: 0x000A68F0
		// (set) Token: 0x06003249 RID: 12873 RVA: 0x000A8704 File Offset: 0x000A6904
		public CloudVoIPViewModel CloudVoIPViewModel
		{
			[CompilerGenerated]
			get
			{
				return this.<CloudVoIPViewModel>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<CloudVoIPViewModel>k__BackingField, value))
				{
					return;
				}
				this.<CloudVoIPViewModel>k__BackingField = value;
				this.RaisePropertyChanged("CloudVoIPViewModel");
			}
		}

		// Token: 0x17000F73 RID: 3955
		// (get) Token: 0x0600324A RID: 12874 RVA: 0x000A8734 File Offset: 0x000A6934
		public IAcpModuleSettings InformSettingsViewModel
		{
			[CompilerGenerated]
			get
			{
				return this.<InformSettingsViewModel>k__BackingField;
			}
		}

		// Token: 0x17000F74 RID: 3956
		// (get) Token: 0x0600324B RID: 12875 RVA: 0x000A8748 File Offset: 0x000A6948
		public IAcpModuleSettings AutoAssignSettingViewModel
		{
			[CompilerGenerated]
			get
			{
				return this.<AutoAssignSettingViewModel>k__BackingField;
			}
		}

		// Token: 0x17000F75 RID: 3957
		// (get) Token: 0x0600324C RID: 12876 RVA: 0x000A875C File Offset: 0x000A695C
		// (set) Token: 0x0600324D RID: 12877 RVA: 0x000A8770 File Offset: 0x000A6970
		public IDocumentsPrintSettings DocumentsPrintSettings
		{
			[CompilerGenerated]
			get
			{
				return this.<DocumentsPrintSettings>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<DocumentsPrintSettings>k__BackingField, value))
				{
					return;
				}
				this.<DocumentsPrintSettings>k__BackingField = value;
				this.RaisePropertyChanged("DocumentsPrintSettings");
			}
		}

		// Token: 0x17000F76 RID: 3958
		// (get) Token: 0x0600324E RID: 12878 RVA: 0x000A87A0 File Offset: 0x000A69A0
		// (set) Token: 0x0600324F RID: 12879 RVA: 0x000A87E4 File Offset: 0x000A69E4
		public int? VoIP
		{
			get
			{
				return base.GetProperty<int?>(() => this.VoIP);
			}
			set
			{
				if (Nullable.Equals<int>(this.VoIP, value))
				{
					return;
				}
				base.SetProperty<int?>(() => this.VoIP, value, new Action(this.OnVoIPChanged));
				this.RaisePropertyChanged("VoIP");
			}
		}

		// Token: 0x17000F77 RID: 3959
		// (get) Token: 0x06003250 RID: 12880 RVA: 0x000A8850 File Offset: 0x000A6A50
		// (set) Token: 0x06003251 RID: 12881 RVA: 0x000A8864 File Offset: 0x000A6A64
		public bool AsteriskRealtimeVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<AsteriskRealtimeVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<AsteriskRealtimeVisible>k__BackingField == value)
				{
					return;
				}
				this.<AsteriskRealtimeVisible>k__BackingField = value;
				this.RaisePropertyChanged("AsteriskRealtimeVisible");
			}
		}

		// Token: 0x17000F78 RID: 3960
		// (get) Token: 0x06003252 RID: 12882 RVA: 0x000A8890 File Offset: 0x000A6A90
		// (set) Token: 0x06003253 RID: 12883 RVA: 0x000A88A4 File Offset: 0x000A6AA4
		public bool CloudVoIPVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<CloudVoIPVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CloudVoIPVisible>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -1571419409;
				IL_10:
				switch ((num ^ -1374149788) % 4)
				{
				case 0:
					IL_2F:
					this.<CloudVoIPVisible>k__BackingField = value;
					this.RaisePropertyChanged("CloudVoIPVisible");
					num = -1165588883;
					goto IL_10;
				case 2:
					goto IL_0B;
				case 3:
					return;
				}
			}
		}

		// Token: 0x17000F79 RID: 3961
		// (get) Token: 0x06003254 RID: 12884 RVA: 0x000A88FC File Offset: 0x000A6AFC
		// (set) Token: 0x06003255 RID: 12885 RVA: 0x000A8910 File Offset: 0x000A6B10
		public bool Valid
		{
			[CompilerGenerated]
			get
			{
				return this.<Valid>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Valid>k__BackingField == value)
				{
					return;
				}
				this.<Valid>k__BackingField = value;
				this.RaisePropertyChanged("Valid");
			}
		}

		// Token: 0x06003256 RID: 12886 RVA: 0x000A893C File Offset: 0x000A6B3C
		public AcpViewModel()
		{
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this.SetViewName("Acp");
			this.Config = Auth.Config;
			this.WarrantyList = WarrantyOptions.GetAll();
			this.TimeZonesList = TimeZoneInfo.GetSystemTimeZones();
			this.VoIPClients = VoipModel.GetVoIPClients();
			this.InformSettingsViewModel = Bootstrapper.Container.Resolve<InformSettingsViewModel>();
			this.AutoAssignSettingViewModel = Bootstrapper.Container.Resolve<AutoAssignSettingsViewModel>();
			this.OnlineStores = new List<IIdName>
			{
				new IdNameClass(1, "OpenCart 2.3")
			};
			VoIPClient? voip = OfflineData.Instance.Settings.Voip;
			this.VoIP = ((voip != null) ? new int?((int)voip.GetValueOrDefault()) : null);
			this.VoIPCfg(this.VoIP);
			this.SetDocumentsPrintSettings();
			this.Valid = base.IsValid();
		}

		// Token: 0x06003257 RID: 12887 RVA: 0x000A8A34 File Offset: 0x000A6C34
		private void OnVoIPChanged()
		{
			this.CloudVoIPVisible = this.IsCloudVoip(this.VoIP);
			int? voIP = this.VoIP;
			bool asteriskRealtimeVisible;
			if (!(voIP.GetValueOrDefault() == 2 & voIP != null))
			{
				voIP = this.VoIP;
				asteriskRealtimeVisible = (voIP.GetValueOrDefault() == 3 & voIP != null);
			}
			else
			{
				asteriskRealtimeVisible = true;
			}
			this.AsteriskRealtimeVisible = asteriskRealtimeVisible;
			this.VoIPCfg(this.VoIP);
		}

		// Token: 0x06003258 RID: 12888 RVA: 0x000A8A9C File Offset: 0x000A6C9C
		private bool IsCloudVoip(int? value)
		{
			int? num = value;
			if (!(num.GetValueOrDefault() == 1 & num != null))
			{
				num = value;
				if (!(num.GetValueOrDefault() == 4 & num != null))
				{
					num = value;
					if (!(num.GetValueOrDefault() == 5 & num != null))
					{
						num = value;
						return num.GetValueOrDefault() == 6 & num != null;
					}
				}
			}
			return true;
		}

		// Token: 0x06003259 RID: 12889 RVA: 0x000A8B04 File Offset: 0x000A6D04
		private void VoIPCfg(int? value)
		{
			int? num = value;
			if (!(num.GetValueOrDefault() == 2 & num != null))
			{
				num = this.VoIP;
				if (!(num.GetValueOrDefault() == 3 & num != null))
				{
					goto IL_4F;
				}
			}
			this.AsteriskRealtimeViewModel = new AsteriskRealtimeViewModel(this.Config);
			this.AsteriskRealtimeViewModel.SetParentViewModel(this);
			IL_4F:
			if (this.IsCloudVoip(value))
			{
				this.CloudVoIPViewModel = Bootstrapper.Container.Resolve<CloudVoIPViewModel>();
				this.CloudVoIPViewModel.SetParentViewModel(this);
			}
		}

		// Token: 0x0600325A RID: 12890 RVA: 0x0009582C File Offset: 0x00093A2C
		protected override void OnParentViewModelChanged(object parentViewModel)
		{
			base.OnParentViewModelChanged(parentViewModel);
			ACPV2ViewModel acpv2ViewModel = parentViewModel as ACPV2ViewModel;
			if (acpv2ViewModel != null)
			{
				acpv2ViewModel.SetChildViewModel(this);
			}
		}

		// Token: 0x0600325B RID: 12891 RVA: 0x000A8B88 File Offset: 0x000A6D88
		public void Save()
		{
			AcpViewModel.<Save>d__63 <Save>d__;
			<Save>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Save>d__.<>4__this = this;
			<Save>d__.<>1__state = -1;
			<Save>d__.<>t__builder.Start<AcpViewModel.<Save>d__63>(ref <Save>d__);
		}

		// Token: 0x0600325C RID: 12892 RVA: 0x000A8BC0 File Offset: 0x000A6DC0
		private void SetDocumentsPrintSettings()
		{
			this.DocumentsPrintSettings = new DocumentsPrintSettings
			{
				PrintNewRepairReport = OfflineData.Instance.Settings.PrintNewRepairReport,
				PrintRepStickers = OfflineData.Instance.Settings.PrintRepStickers,
				PrintNewCartridgeReport = OfflineData.Instance.Settings.PrintNewCartridgeReport,
				PrintCartridgeStickers = OfflineData.Instance.Settings.PrintCartridgeStickers
			};
		}

		// Token: 0x0600325D RID: 12893 RVA: 0x000A8C2C File Offset: 0x000A6E2C
		public override void OnLoad()
		{
			AcpViewModel.<OnLoad>d__65 <OnLoad>d__;
			<OnLoad>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnLoad>d__.<>4__this = this;
			<OnLoad>d__.<>1__state = -1;
			<OnLoad>d__.<>t__builder.Start<AcpViewModel.<OnLoad>d__65>(ref <OnLoad>d__);
		}

		// Token: 0x0600325E RID: 12894 RVA: 0x0007E5F4 File Offset: 0x0007C7F4
		public bool CanSave()
		{
			return true;
		}

		// Token: 0x0600325F RID: 12895 RVA: 0x0007E558 File Offset: 0x0007C758
		public void Refresh()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06003260 RID: 12896 RVA: 0x000304B4 File Offset: 0x0002E6B4
		public bool CanRefresh()
		{
			return false;
		}

		// Token: 0x06003261 RID: 12897 RVA: 0x0003401C File Offset: 0x0003221C
		[CompilerGenerated]
		[DebuggerHidden]
		private void <>n__0()
		{
			base.OnLoad();
		}

		// Token: 0x04001CDB RID: 7387
		private readonly IToasterService _toasterService;

		// Token: 0x04001CDC RID: 7388
		[CompilerGenerated]
		private List<Warranty> <WarrantyList>k__BackingField;

		// Token: 0x04001CDD RID: 7389
		[CompilerGenerated]
		private config <Config>k__BackingField;

		// Token: 0x04001CDE RID: 7390
		[CompilerGenerated]
		private ReadOnlyCollection<TimeZoneInfo> <TimeZonesList>k__BackingField;

		// Token: 0x04001CDF RID: 7391
		[CompilerGenerated]
		private Currency <Currency>k__BackingField = new Currency();

		// Token: 0x04001CE0 RID: 7392
		[CompilerGenerated]
		private List<IIdName> <VoIPClients>k__BackingField;

		// Token: 0x04001CE1 RID: 7393
		[CompilerGenerated]
		private List<IIdName> <OnlineStores>k__BackingField;

		// Token: 0x04001CE2 RID: 7394
		[CompilerGenerated]
		private AsteriskRealtimeViewModel <AsteriskRealtimeViewModel>k__BackingField;

		// Token: 0x04001CE3 RID: 7395
		[CompilerGenerated]
		private CloudVoIPViewModel <CloudVoIPViewModel>k__BackingField;

		// Token: 0x04001CE4 RID: 7396
		[CompilerGenerated]
		private readonly IAcpModuleSettings <InformSettingsViewModel>k__BackingField;

		// Token: 0x04001CE5 RID: 7397
		[CompilerGenerated]
		private readonly IAcpModuleSettings <AutoAssignSettingViewModel>k__BackingField;

		// Token: 0x04001CE6 RID: 7398
		[CompilerGenerated]
		private IDocumentsPrintSettings <DocumentsPrintSettings>k__BackingField;

		// Token: 0x04001CE7 RID: 7399
		[CompilerGenerated]
		private bool <AsteriskRealtimeVisible>k__BackingField;

		// Token: 0x04001CE8 RID: 7400
		[CompilerGenerated]
		private bool <CloudVoIPVisible>k__BackingField;

		// Token: 0x04001CE9 RID: 7401
		[CompilerGenerated]
		private bool <Valid>k__BackingField;

		// Token: 0x0200054B RID: 1355
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Save>d__63 : IAsyncStateMachine
		{
			// Token: 0x06003262 RID: 12898 RVA: 0x000A8C64 File Offset: 0x000A6E64
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AcpViewModel acpViewModel = this.<>4__this;
				try
				{
					if (num <= 8 || OfflineData.Instance.Employee.Can(1, 0))
					{
						try
						{
							if (num > 8)
							{
								this.<ctx>5__2 = new auseceEntities(false);
							}
							try
							{
								TaskAwaiter awaiter;
								int? voIP;
								switch (num)
								{
								case 0:
								{
									awaiter = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter);
									int num2 = -1;
									num = -1;
									this.<>1__state = num2;
									break;
								}
								case 1:
								{
									awaiter = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter);
									int num3 = -1;
									num = -1;
									this.<>1__state = num3;
									goto IL_29A;
								}
								case 2:
								{
									awaiter = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter);
									int num4 = -1;
									num = -1;
									this.<>1__state = num4;
									goto IL_36C;
								}
								case 3:
								{
									awaiter = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter);
									int num5 = -1;
									num = -1;
									this.<>1__state = num5;
									goto IL_3E4;
								}
								case 4:
								{
									awaiter = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter);
									int num6 = -1;
									num = -1;
									this.<>1__state = num6;
									goto IL_45C;
								}
								case 5:
								{
									awaiter = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter);
									int num7 = -1;
									num = -1;
									this.<>1__state = num7;
									goto IL_4D2;
								}
								case 6:
								{
									awaiter = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter);
									int num8 = -1;
									num = -1;
									this.<>1__state = num8;
									goto IL_535;
								}
								case 7:
								{
									awaiter = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter);
									int num9 = -1;
									num = -1;
									this.<>1__state = num9;
									goto IL_621;
								}
								case 8:
								{
									awaiter = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter);
									int num10 = -1;
									num = -1;
									this.<>1__state = num10;
									goto IL_68E;
								}
								default:
								{
									this.<c>5__3 = this.<ctx>5__2.config.FirstOrDefault<config>();
									this.<ctx>5__2.Entry<config>(this.<c>5__3).CurrentValues.SetValues(acpViewModel.Config);
									this.<settingsService>5__4 = Bootstrapper.Container.Resolve<ISettingsService>();
									VoIPClient? voip = OfflineData.Instance.Settings.Voip;
									int? num11 = (voip != null) ? new int?((int)voip.GetValueOrDefault()) : null;
									voIP = acpViewModel.VoIP;
									if (num11.GetValueOrDefault() == voIP.GetValueOrDefault() & num11 != null == (voIP != null))
									{
										goto IL_187;
									}
									awaiter = this.<settingsService>5__4.UpdateSettingsAsync("voip", string.Format("{0}", acpViewModel.VoIP)).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										int num12 = 0;
										num = 0;
										this.<>1__state = num12;
										this.<>u__1 = awaiter;
										this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, AcpViewModel.<Save>d__63>(ref awaiter, ref this);
										return;
									}
									break;
								}
								}
								awaiter.GetResult();
								IL_187:
								voIP = acpViewModel.VoIP;
								if (!(voIP.GetValueOrDefault() == 2 & voIP != null))
								{
									voIP = acpViewModel.VoIP;
									if (!(voIP.GetValueOrDefault() == 3 & voIP != null))
									{
										goto IL_2D9;
									}
								}
								this.<vc>5__5 = (AsteriskRealtimeCredentials)acpViewModel.AsteriskRealtimeViewModel.Credentials;
								this.<c>5__3.aster_host = this.<vc>5__5.Host;
								this.<c>5__3.aster_port = this.<vc>5__5.Port;
								this.<c>5__3.aster_login = this.<vc>5__5.Login;
								this.<c>5__3.aster_password = this.<vc>5__5.Password;
								awaiter = this.<settingsService>5__4.UpdateSettingsAsync("voip_prefix", this.<vc>5__5.Prefix).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num13 = 1;
									num = 1;
									this.<>1__state = num13;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, AcpViewModel.<Save>d__63>(ref awaiter, ref this);
									return;
								}
								IL_29A:
								awaiter.GetResult();
								voIP = acpViewModel.VoIP;
								if (voIP.GetValueOrDefault() == 2 & voIP != null)
								{
									this.<c>5__3.aster_web_port = this.<vc>5__5.WebPort;
								}
								this.<vc>5__5 = null;
								IL_2D9:
								if (!acpViewModel.IsCloudVoip(acpViewModel.VoIP))
								{
									goto IL_46A;
								}
								this.<credentials>5__6 = acpViewModel.CloudVoIPViewModel.Credentials;
								awaiter = this.<settingsService>5__4.UpdateSettingsAsync("voip_key", this.<credentials>5__6.Key.Trim()).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num14 = 2;
									num = 2;
									this.<>1__state = num14;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, AcpViewModel.<Save>d__63>(ref awaiter, ref this);
									return;
								}
								IL_36C:
								awaiter.GetResult();
								awaiter = this.<settingsService>5__4.UpdateSettingsAsync("voip_secret", this.<credentials>5__6.Secret.Trim()).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num15 = 3;
									num = 3;
									this.<>1__state = num15;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, AcpViewModel.<Save>d__63>(ref awaiter, ref this);
									return;
								}
								IL_3E4:
								awaiter.GetResult();
								awaiter = this.<settingsService>5__4.UpdateSettingsAsync("voip_endpoint", this.<credentials>5__6.Endpoint.Trim()).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num16 = 4;
									num = 4;
									this.<>1__state = num16;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, AcpViewModel.<Save>d__63>(ref awaiter, ref this);
									return;
								}
								IL_45C:
								awaiter.GetResult();
								this.<credentials>5__6 = null;
								IL_46A:
								this.<ctx>5__2.SaveChanges();
								awaiter = acpViewModel.InformSettingsViewModel.SaveSettings().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num17 = 5;
									num = 5;
									this.<>1__state = num17;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, AcpViewModel.<Save>d__63>(ref awaiter, ref this);
									return;
								}
								IL_4D2:
								awaiter.GetResult();
								awaiter = acpViewModel.AutoAssignSettingViewModel.SaveSettings().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num18 = 6;
									num = 6;
									this.<>1__state = num18;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, AcpViewModel.<Save>d__63>(ref awaiter, ref this);
									return;
								}
								IL_535:
								awaiter.GetResult();
								awaiter = this.<settingsService>5__4.UpdateSettingsAsync(new Dictionary<SettingsName, string>
								{
									{
										SettingsName.print_new_repair_report,
										acpViewModel.DocumentsPrintSettings.PrintNewRepairReport ? "1" : "0"
									},
									{
										SettingsName.print_rep_stickers,
										acpViewModel.DocumentsPrintSettings.PrintRepStickers ? "1" : "0"
									},
									{
										SettingsName.print_new_cartridge_report,
										acpViewModel.DocumentsPrintSettings.PrintNewCartridgeReport ? "1" : "0"
									},
									{
										SettingsName.print_cartridge_stickers,
										acpViewModel.DocumentsPrintSettings.PrintCartridgeStickers ? "1" : "0"
									}
								}).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num19 = 7;
									num = 7;
									this.<>1__state = num19;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, AcpViewModel.<Save>d__63>(ref awaiter, ref this);
									return;
								}
								IL_621:
								awaiter.GetResult();
								Auth.Config = this.<c>5__3;
								awaiter = OfflineData.Instance.ReloadSettings().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num20 = 8;
									num = 8;
									this.<>1__state = num20;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, AcpViewModel.<Save>d__63>(ref awaiter, ref this);
									return;
								}
								IL_68E:
								awaiter.GetResult();
								acpViewModel.SetDocumentsPrintSettings();
								if (acpViewModel.VoIP != null)
								{
									Core.Instance.InitVoIP();
								}
								this.<c>5__3 = null;
								this.<settingsService>5__4 = null;
							}
							finally
							{
								if (num < 0 && this.<ctx>5__2 != null)
								{
									((IDisposable)this.<ctx>5__2).Dispose();
								}
							}
							this.<ctx>5__2 = null;
							acpViewModel._toasterService.Success(Lang.t("Saved"));
						}
						catch (Exception ex)
						{
							acpViewModel._toasterService.Error(ex.Message);
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
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003263 RID: 12899 RVA: 0x000A93FC File Offset: 0x000A75FC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001CEA RID: 7402
			public int <>1__state;

			// Token: 0x04001CEB RID: 7403
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001CEC RID: 7404
			public AcpViewModel <>4__this;

			// Token: 0x04001CED RID: 7405
			private auseceEntities <ctx>5__2;

			// Token: 0x04001CEE RID: 7406
			private config <c>5__3;

			// Token: 0x04001CEF RID: 7407
			private ISettingsService <settingsService>5__4;

			// Token: 0x04001CF0 RID: 7408
			private TaskAwaiter <>u__1;

			// Token: 0x04001CF1 RID: 7409
			private AsteriskRealtimeCredentials <vc>5__5;

			// Token: 0x04001CF2 RID: 7410
			private ICloudCredentials <credentials>5__6;
		}

		// Token: 0x0200054C RID: 1356
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnLoad>d__65 : IAsyncStateMachine
		{
			// Token: 0x06003264 RID: 12900 RVA: 0x000A9418 File Offset: 0x000A7618
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AcpViewModel acpViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							this.<>1__state = -1;
							goto IL_B6;
						}
						acpViewModel.<>n__0();
						awaiter = acpViewModel.InformSettingsViewModel.LoadSettings().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, AcpViewModel.<OnLoad>d__65>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
					}
					awaiter.GetResult();
					awaiter = acpViewModel.AutoAssignSettingViewModel.LoadSettings().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, AcpViewModel.<OnLoad>d__65>(ref awaiter, ref this);
						return;
					}
					IL_B6:
					awaiter.GetResult();
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

			// Token: 0x06003265 RID: 12901 RVA: 0x000A9540 File Offset: 0x000A7740
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001CF3 RID: 7411
			public int <>1__state;

			// Token: 0x04001CF4 RID: 7412
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001CF5 RID: 7413
			public AcpViewModel <>4__this;

			// Token: 0x04001CF6 RID: 7414
			private TaskAwaiter <>u__1;
		}
	}
}
