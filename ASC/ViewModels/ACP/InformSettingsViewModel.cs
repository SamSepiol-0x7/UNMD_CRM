using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Enum;
using ASC.Common.Models;
using ASC.Interfaces;
using ASC.Objects;
using ASC.Services.Abstract;
using DevExpress.Mvvm;

namespace ASC.ViewModels.ACP
{
	// Token: 0x0200054D RID: 1357
	public class InformSettingsViewModel : BindableBase, IAcpModuleSettings
	{
		// Token: 0x17000F7A RID: 3962
		// (get) Token: 0x06003266 RID: 12902 RVA: 0x000A955C File Offset: 0x000A775C
		public string Name
		{
			get
			{
				return Lang.t("NotificationSettings");
			}
		}

		// Token: 0x17000F7B RID: 3963
		// (get) Token: 0x06003267 RID: 12903 RVA: 0x000A9574 File Offset: 0x000A7774
		// (set) Token: 0x06003268 RID: 12904 RVA: 0x000A9588 File Offset: 0x000A7788
		public bool InformComment
		{
			[CompilerGenerated]
			get
			{
				return this.<InformComment>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<InformComment>k__BackingField == value)
				{
					return;
				}
				this.<InformComment>k__BackingField = value;
				this.RaisePropertyChanged("InformComment");
			}
		}

		// Token: 0x17000F7C RID: 3964
		// (get) Token: 0x06003269 RID: 12905 RVA: 0x000A95B4 File Offset: 0x000A77B4
		// (set) Token: 0x0600326A RID: 12906 RVA: 0x000A95C8 File Offset: 0x000A77C8
		public bool InformSms
		{
			[CompilerGenerated]
			get
			{
				return this.<InformSms>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<InformSms>k__BackingField == value)
				{
					return;
				}
				this.<InformSms>k__BackingField = value;
				this.RaisePropertyChanged("InformSms");
			}
		}

		// Token: 0x17000F7D RID: 3965
		// (get) Token: 0x0600326B RID: 12907 RVA: 0x000A95F4 File Offset: 0x000A77F4
		// (set) Token: 0x0600326C RID: 12908 RVA: 0x000A9608 File Offset: 0x000A7808
		public bool InformTaskMatch
		{
			[CompilerGenerated]
			get
			{
				return this.<InformTaskMatch>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<InformTaskMatch>k__BackingField == value)
				{
					return;
				}
				this.<InformTaskMatch>k__BackingField = value;
				this.RaisePropertyChanged("InformTaskMatch");
			}
		}

		// Token: 0x17000F7E RID: 3966
		// (get) Token: 0x0600326D RID: 12909 RVA: 0x000A9634 File Offset: 0x000A7834
		// (set) Token: 0x0600326E RID: 12910 RVA: 0x000A9648 File Offset: 0x000A7848
		public bool InformTaskCustom
		{
			[CompilerGenerated]
			get
			{
				return this.<InformTaskCustom>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<InformTaskCustom>k__BackingField == value)
				{
					return;
				}
				this.<InformTaskCustom>k__BackingField = value;
				this.RaisePropertyChanged("InformTaskCustom");
			}
		}

		// Token: 0x17000F7F RID: 3967
		// (get) Token: 0x0600326F RID: 12911 RVA: 0x000A9674 File Offset: 0x000A7874
		// (set) Token: 0x06003270 RID: 12912 RVA: 0x000A9688 File Offset: 0x000A7888
		public bool InformTaskRequest
		{
			[CompilerGenerated]
			get
			{
				return this.<InformTaskRequest>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<InformTaskRequest>k__BackingField == value)
				{
					return;
				}
				this.<InformTaskRequest>k__BackingField = value;
				this.RaisePropertyChanged("InformTaskRequest");
			}
		}

		// Token: 0x17000F80 RID: 3968
		// (get) Token: 0x06003271 RID: 12913 RVA: 0x000A96B4 File Offset: 0x000A78B4
		// (set) Token: 0x06003272 RID: 12914 RVA: 0x000A96C8 File Offset: 0x000A78C8
		public bool InformIntRequest
		{
			[CompilerGenerated]
			get
			{
				return this.<InformIntRequest>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<InformIntRequest>k__BackingField == value)
				{
					return;
				}
				this.<InformIntRequest>k__BackingField = value;
				this.RaisePropertyChanged("InformIntRequest");
			}
		}

		// Token: 0x17000F81 RID: 3969
		// (get) Token: 0x06003273 RID: 12915 RVA: 0x000A96F4 File Offset: 0x000A78F4
		// (set) Token: 0x06003274 RID: 12916 RVA: 0x000A9708 File Offset: 0x000A7908
		public bool InformPartRequest
		{
			[CompilerGenerated]
			get
			{
				return this.<InformPartRequest>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<InformPartRequest>k__BackingField == value)
				{
					return;
				}
				this.<InformPartRequest>k__BackingField = value;
				this.RaisePropertyChanged("InformPartRequest");
			}
		}

		// Token: 0x17000F82 RID: 3970
		// (get) Token: 0x06003275 RID: 12917 RVA: 0x000A9734 File Offset: 0x000A7934
		// (set) Token: 0x06003276 RID: 12918 RVA: 0x000A9748 File Offset: 0x000A7948
		public bool InformCall
		{
			[CompilerGenerated]
			get
			{
				return this.<InformCall>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<InformCall>k__BackingField == value)
				{
					return;
				}
				this.<InformCall>k__BackingField = value;
				this.RaisePropertyChanged("InformCall");
			}
		}

		// Token: 0x17000F83 RID: 3971
		// (get) Token: 0x06003277 RID: 12919 RVA: 0x000A9774 File Offset: 0x000A7974
		// (set) Token: 0x06003278 RID: 12920 RVA: 0x000A9788 File Offset: 0x000A7988
		public string InformCommentColor
		{
			[CompilerGenerated]
			get
			{
				return this.<InformCommentColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.<InformCommentColor>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = -1711791035;
				IL_14:
				switch ((num ^ -686916056) % 4)
				{
				case 1:
					return;
				case 2:
					IL_33:
					this.<InformCommentColor>k__BackingField = value;
					this.RaisePropertyChanged("InformCommentColor");
					num = -201647624;
					goto IL_14;
				case 3:
					goto IL_0F;
				}
			}
		}

		// Token: 0x17000F84 RID: 3972
		// (get) Token: 0x06003279 RID: 12921 RVA: 0x000A97E4 File Offset: 0x000A79E4
		// (set) Token: 0x0600327A RID: 12922 RVA: 0x000A97F8 File Offset: 0x000A79F8
		public string InformStatusColor
		{
			[CompilerGenerated]
			get
			{
				return this.<InformStatusColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<InformStatusColor>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<InformStatusColor>k__BackingField = value;
				this.RaisePropertyChanged("InformStatusColor");
			}
		}

		// Token: 0x17000F85 RID: 3973
		// (get) Token: 0x0600327B RID: 12923 RVA: 0x000A9828 File Offset: 0x000A7A28
		// (set) Token: 0x0600327C RID: 12924 RVA: 0x000A983C File Offset: 0x000A7A3C
		public string InformSmsColor
		{
			[CompilerGenerated]
			get
			{
				return this.<InformSmsColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<InformSmsColor>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<InformSmsColor>k__BackingField = value;
				this.RaisePropertyChanged("InformSmsColor");
			}
		}

		// Token: 0x17000F86 RID: 3974
		// (get) Token: 0x0600327D RID: 12925 RVA: 0x000A986C File Offset: 0x000A7A6C
		// (set) Token: 0x0600327E RID: 12926 RVA: 0x000A9880 File Offset: 0x000A7A80
		public string InformTermsColor
		{
			[CompilerGenerated]
			get
			{
				return this.<InformTermsColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<InformTermsColor>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<InformTermsColor>k__BackingField = value;
				this.RaisePropertyChanged("InformTermsColor");
			}
		}

		// Token: 0x17000F87 RID: 3975
		// (get) Token: 0x0600327F RID: 12927 RVA: 0x000A98B0 File Offset: 0x000A7AB0
		// (set) Token: 0x06003280 RID: 12928 RVA: 0x000A98C4 File Offset: 0x000A7AC4
		public string InformTaskMatchColor
		{
			[CompilerGenerated]
			get
			{
				return this.<InformTaskMatchColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.<InformTaskMatchColor>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = 1045150036;
				IL_14:
				switch ((num ^ 20634899) % 4)
				{
				case 0:
					goto IL_0F;
				case 2:
					IL_33:
					this.<InformTaskMatchColor>k__BackingField = value;
					num = 1597167810;
					goto IL_14;
				case 3:
					return;
				}
				this.RaisePropertyChanged("InformTaskMatchColor");
			}
		}

		// Token: 0x17000F88 RID: 3976
		// (get) Token: 0x06003281 RID: 12929 RVA: 0x000A9920 File Offset: 0x000A7B20
		// (set) Token: 0x06003282 RID: 12930 RVA: 0x000A9934 File Offset: 0x000A7B34
		public string InformTaskCustomColor
		{
			[CompilerGenerated]
			get
			{
				return this.<InformTaskCustomColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<InformTaskCustomColor>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<InformTaskCustomColor>k__BackingField = value;
				this.RaisePropertyChanged("InformTaskCustomColor");
			}
		}

		// Token: 0x17000F89 RID: 3977
		// (get) Token: 0x06003283 RID: 12931 RVA: 0x000A9964 File Offset: 0x000A7B64
		// (set) Token: 0x06003284 RID: 12932 RVA: 0x000A9978 File Offset: 0x000A7B78
		public string InformTaskRequestColor
		{
			[CompilerGenerated]
			get
			{
				return this.<InformTaskRequestColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<InformTaskRequestColor>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<InformTaskRequestColor>k__BackingField = value;
				this.RaisePropertyChanged("InformTaskRequestColor");
			}
		}

		// Token: 0x17000F8A RID: 3978
		// (get) Token: 0x06003285 RID: 12933 RVA: 0x000A99A8 File Offset: 0x000A7BA8
		// (set) Token: 0x06003286 RID: 12934 RVA: 0x000A99BC File Offset: 0x000A7BBC
		public string InformIntRequestColor
		{
			[CompilerGenerated]
			get
			{
				return this.<InformIntRequestColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<InformIntRequestColor>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<InformIntRequestColor>k__BackingField = value;
				this.RaisePropertyChanged("InformIntRequestColor");
			}
		}

		// Token: 0x17000F8B RID: 3979
		// (get) Token: 0x06003287 RID: 12935 RVA: 0x000A99EC File Offset: 0x000A7BEC
		// (set) Token: 0x06003288 RID: 12936 RVA: 0x000A9A00 File Offset: 0x000A7C00
		public string InformCallColor
		{
			[CompilerGenerated]
			get
			{
				return this.<InformCallColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.<InformCallColor>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = -76612790;
				IL_14:
				switch ((num ^ -798747947) % 4)
				{
				case 0:
					IL_33:
					this.<InformCallColor>k__BackingField = value;
					num = -1088661080;
					goto IL_14;
				case 2:
					goto IL_0F;
				case 3:
					return;
				}
				this.RaisePropertyChanged("InformCallColor");
			}
		}

		// Token: 0x17000F8C RID: 3980
		// (get) Token: 0x06003289 RID: 12937 RVA: 0x000A9A5C File Offset: 0x000A7C5C
		// (set) Token: 0x0600328A RID: 12938 RVA: 0x000A9A70 File Offset: 0x000A7C70
		public string InformPartRequestColor
		{
			[CompilerGenerated]
			get
			{
				return this.<InformPartRequestColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.<InformPartRequestColor>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = 109107455;
				IL_14:
				switch ((num ^ 352919576) % 4)
				{
				case 0:
					goto IL_0F;
				case 1:
					IL_33:
					num = 217606446;
					goto IL_14;
				case 3:
					return;
				}
				this.<InformPartRequestColor>k__BackingField = value;
				this.RaisePropertyChanged("InformPartRequestColor");
			}
		}

		// Token: 0x0600328B RID: 12939 RVA: 0x000A9ACC File Offset: 0x000A7CCC
		public InformSettingsViewModel(ISettingsService settingsService)
		{
			this._settingsService = settingsService;
		}

		// Token: 0x0600328C RID: 12940 RVA: 0x000A9B54 File Offset: 0x000A7D54
		public Task LoadSettings()
		{
			InformSettingsViewModel.<LoadSettings>d__77 <LoadSettings>d__;
			<LoadSettings>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadSettings>d__.<>4__this = this;
			<LoadSettings>d__.<>1__state = -1;
			<LoadSettings>d__.<>t__builder.Start<InformSettingsViewModel.<LoadSettings>d__77>(ref <LoadSettings>d__);
			return <LoadSettings>d__.<>t__builder.Task;
		}

		// Token: 0x0600328D RID: 12941 RVA: 0x000A9B98 File Offset: 0x000A7D98
		private string GetColorValue(string value)
		{
			if (!string.IsNullOrEmpty(value))
			{
				return value;
			}
			return "#00000000";
		}

		// Token: 0x0600328E RID: 12942 RVA: 0x000A9BB4 File Offset: 0x000A7DB4
		public Task SaveSettings()
		{
			InformSettingsViewModel.<SaveSettings>d__79 <SaveSettings>d__;
			<SaveSettings>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<SaveSettings>d__.<>4__this = this;
			<SaveSettings>d__.<>1__state = -1;
			<SaveSettings>d__.<>t__builder.Start<InformSettingsViewModel.<SaveSettings>d__79>(ref <SaveSettings>d__);
			return <SaveSettings>d__.<>t__builder.Task;
		}

		// Token: 0x04001CF7 RID: 7415
		private readonly ISettingsService _settingsService;

		// Token: 0x04001CF8 RID: 7416
		private const string NoColorValue = "#00000000";

		// Token: 0x04001CF9 RID: 7417
		[CompilerGenerated]
		private bool <InformComment>k__BackingField;

		// Token: 0x04001CFA RID: 7418
		[CompilerGenerated]
		private bool <InformSms>k__BackingField;

		// Token: 0x04001CFB RID: 7419
		[CompilerGenerated]
		private bool <InformTaskMatch>k__BackingField;

		// Token: 0x04001CFC RID: 7420
		[CompilerGenerated]
		private bool <InformTaskCustom>k__BackingField;

		// Token: 0x04001CFD RID: 7421
		[CompilerGenerated]
		private bool <InformTaskRequest>k__BackingField;

		// Token: 0x04001CFE RID: 7422
		[CompilerGenerated]
		private bool <InformIntRequest>k__BackingField;

		// Token: 0x04001CFF RID: 7423
		[CompilerGenerated]
		private bool <InformPartRequest>k__BackingField;

		// Token: 0x04001D00 RID: 7424
		[CompilerGenerated]
		private bool <InformCall>k__BackingField;

		// Token: 0x04001D01 RID: 7425
		[CompilerGenerated]
		private string <InformCommentColor>k__BackingField = "#00000000";

		// Token: 0x04001D02 RID: 7426
		[CompilerGenerated]
		private string <InformStatusColor>k__BackingField = "#00000000";

		// Token: 0x04001D03 RID: 7427
		[CompilerGenerated]
		private string <InformSmsColor>k__BackingField = "#00000000";

		// Token: 0x04001D04 RID: 7428
		[CompilerGenerated]
		private string <InformTermsColor>k__BackingField = "#00000000";

		// Token: 0x04001D05 RID: 7429
		[CompilerGenerated]
		private string <InformTaskMatchColor>k__BackingField = "#00000000";

		// Token: 0x04001D06 RID: 7430
		[CompilerGenerated]
		private string <InformTaskCustomColor>k__BackingField = "#00000000";

		// Token: 0x04001D07 RID: 7431
		[CompilerGenerated]
		private string <InformTaskRequestColor>k__BackingField = "#00000000";

		// Token: 0x04001D08 RID: 7432
		[CompilerGenerated]
		private string <InformIntRequestColor>k__BackingField = "#00000000";

		// Token: 0x04001D09 RID: 7433
		[CompilerGenerated]
		private string <InformCallColor>k__BackingField = "#00000000";

		// Token: 0x04001D0A RID: 7434
		[CompilerGenerated]
		private string <InformPartRequestColor>k__BackingField = "#00000000";

		// Token: 0x0200054E RID: 1358
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadSettings>d__77 : IAsyncStateMachine
		{
			// Token: 0x0600328F RID: 12943 RVA: 0x000A9BF8 File Offset: 0x000A7DF8
			void IAsyncStateMachine.MoveNext()
			{
				InformSettingsViewModel informSettingsViewModel = this.<>4__this;
				try
				{
					SettingsModel settings = OfflineData.Instance.Settings;
					informSettingsViewModel.InformComment = settings.InformComment;
					informSettingsViewModel.InformSms = settings.InformSms;
					informSettingsViewModel.InformTaskMatch = settings.InformTaskMatch;
					informSettingsViewModel.InformTaskCustom = settings.InformTaskCustom;
					informSettingsViewModel.InformTaskRequest = settings.InformTaskRequest;
					informSettingsViewModel.InformIntRequest = settings.InformIntRequest;
					informSettingsViewModel.InformPartRequest = settings.InformPartRequest;
					informSettingsViewModel.InformCall = settings.InformCall;
					informSettingsViewModel.InformCommentColor = informSettingsViewModel.GetColorValue(settings.InformCommentColor);
					informSettingsViewModel.InformStatusColor = informSettingsViewModel.GetColorValue(settings.InformStatusColor);
					informSettingsViewModel.InformSmsColor = informSettingsViewModel.GetColorValue(settings.InformSmsColor);
					informSettingsViewModel.InformTermsColor = informSettingsViewModel.GetColorValue(settings.InformTermsColor);
					informSettingsViewModel.InformTaskMatchColor = informSettingsViewModel.GetColorValue(settings.InformTaskMatchColor);
					informSettingsViewModel.InformTaskCustomColor = informSettingsViewModel.GetColorValue(settings.InformTaskCustomColor);
					informSettingsViewModel.InformTaskRequestColor = informSettingsViewModel.GetColorValue(settings.InformTaskRequestColor);
					informSettingsViewModel.InformIntRequestColor = informSettingsViewModel.GetColorValue(settings.InformIntRequestColor);
					informSettingsViewModel.InformCallColor = informSettingsViewModel.GetColorValue(settings.InformCallColor);
					informSettingsViewModel.InformPartRequestColor = informSettingsViewModel.GetColorValue(settings.InformPartRequestColor);
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

			// Token: 0x06003290 RID: 12944 RVA: 0x000A9D74 File Offset: 0x000A7F74
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001D0B RID: 7435
			public int <>1__state;

			// Token: 0x04001D0C RID: 7436
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001D0D RID: 7437
			public InformSettingsViewModel <>4__this;
		}

		// Token: 0x0200054F RID: 1359
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SaveSettings>d__79 : IAsyncStateMachine
		{
			// Token: 0x06003291 RID: 12945 RVA: 0x000A9D90 File Offset: 0x000A7F90
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				InformSettingsViewModel informSettingsViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = informSettingsViewModel._settingsService.UpdateSettingsAsync(new Dictionary<SettingsName, string>
						{
							{
								SettingsName.inform_comment,
								informSettingsViewModel.InformComment ? "1" : "0"
							},
							{
								SettingsName.inform_sms,
								informSettingsViewModel.InformSms ? "1" : "0"
							},
							{
								SettingsName.inform_task_match,
								informSettingsViewModel.InformTaskMatch ? "1" : "0"
							},
							{
								SettingsName.inform_task_custom,
								informSettingsViewModel.InformTaskCustom ? "1" : "0"
							},
							{
								SettingsName.inform_task_request,
								informSettingsViewModel.InformTaskRequest ? "1" : "0"
							},
							{
								SettingsName.inform_int_request,
								informSettingsViewModel.InformIntRequest ? "1" : "0"
							},
							{
								SettingsName.inform_part_request,
								informSettingsViewModel.InformPartRequest ? "1" : "0"
							},
							{
								SettingsName.inform_call,
								informSettingsViewModel.InformCall ? "1" : "0"
							},
							{
								SettingsName.inform_comment_color,
								informSettingsViewModel.InformCommentColor
							},
							{
								SettingsName.inform_status_color,
								informSettingsViewModel.InformStatusColor
							},
							{
								SettingsName.inform_sms_color,
								informSettingsViewModel.InformSmsColor
							},
							{
								SettingsName.inform_terms_color,
								informSettingsViewModel.InformTermsColor
							},
							{
								SettingsName.inform_task_match_color,
								informSettingsViewModel.InformTaskMatchColor
							},
							{
								SettingsName.inform_task_custom_color,
								informSettingsViewModel.InformTaskCustomColor
							},
							{
								SettingsName.inform_task_request_color,
								informSettingsViewModel.InformTaskRequestColor
							},
							{
								SettingsName.inform_int_request_color,
								informSettingsViewModel.InformIntRequestColor
							},
							{
								SettingsName.inform_call_color,
								informSettingsViewModel.InformCallColor
							},
							{
								SettingsName.inform_part_request_color,
								informSettingsViewModel.InformPartRequestColor
							}
						}).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, InformSettingsViewModel.<SaveSettings>d__79>(ref awaiter, ref this);
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

			// Token: 0x06003292 RID: 12946 RVA: 0x000A9FC4 File Offset: 0x000A81C4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001D0E RID: 7438
			public int <>1__state;

			// Token: 0x04001D0F RID: 7439
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001D10 RID: 7440
			public InformSettingsViewModel <>4__this;

			// Token: 0x04001D11 RID: 7441
			private TaskAwaiter <>u__1;
		}
	}
}
