using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ASC.Common.Interfaces.VoIP;
using ASC.Common.Objects.VoIP;
using ASC.Objects;
using ASC.Services.Abstract;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels.ACP
{
	// Token: 0x0200055E RID: 1374
	public class CloudVoIPViewModel : BaseViewModel
	{
		// Token: 0x17000FA0 RID: 4000
		// (get) Token: 0x06003300 RID: 13056 RVA: 0x000ABBE4 File Offset: 0x000A9DE4
		// (set) Token: 0x06003301 RID: 13057 RVA: 0x000ABBF8 File Offset: 0x000A9DF8
		public ICloudCredentials Credentials
		{
			[CompilerGenerated]
			get
			{
				return this.<Credentials>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Credentials>k__BackingField, value))
				{
					return;
				}
				this.<Credentials>k__BackingField = value;
				this.RaisePropertyChanged("Credentials");
			}
		}

		// Token: 0x17000FA1 RID: 4001
		// (get) Token: 0x06003302 RID: 13058 RVA: 0x000ABC28 File Offset: 0x000A9E28
		// (set) Token: 0x06003303 RID: 13059 RVA: 0x000ABC3C File Offset: 0x000A9E3C
		public bool SecretVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<SecretVisible>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<SecretVisible>k__BackingField == value)
				{
					return;
				}
				this.<SecretVisible>k__BackingField = value;
				this.RaisePropertyChanged("SecretVisible");
			}
		}

		// Token: 0x17000FA2 RID: 4002
		// (get) Token: 0x06003304 RID: 13060 RVA: 0x000ABC68 File Offset: 0x000A9E68
		// (set) Token: 0x06003305 RID: 13061 RVA: 0x000ABC7C File Offset: 0x000A9E7C
		public bool EndpointVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<EndpointVisible>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<EndpointVisible>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -1285302413;
				IL_10:
				switch ((num ^ -1276976328) % 4)
				{
				case 0:
					goto IL_0B;
				case 2:
					IL_2F:
					this.<EndpointVisible>k__BackingField = value;
					num = -1190935907;
					goto IL_10;
				case 3:
					return;
				}
				this.RaisePropertyChanged("EndpointVisible");
			}
		}

		// Token: 0x06003306 RID: 13062 RVA: 0x000ABCD4 File Offset: 0x000A9ED4
		public CloudVoIPViewModel()
		{
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._ascMessageBoxService = Bootstrapper.Container.Resolve<IAscMessageBoxService>();
			this.Credentials = new CloudCredentials
			{
				Key = OfflineData.Instance.Settings.VoipKey,
				Secret = OfflineData.Instance.Settings.VoipSecret,
				Endpoint = OfflineData.Instance.Settings.VoipEndpoint
			};
		}

		// Token: 0x06003307 RID: 13063 RVA: 0x000ABD54 File Offset: 0x000A9F54
		private void SetName(VoIPClient? value)
		{
			if (value != null)
			{
				goto IL_46;
			}
			string text = "";
			IL_25:
			string str = text;
			int num = 1289684091;
			IL_2B:
			switch ((num ^ 111258526) % 3)
			{
			case 0:
				IL_46:
				num = 1645882014;
				goto IL_2B;
			case 2:
				text = value.Value.ToString();
				goto IL_25;
			}
			this.Credentials.Name = Lang.t("VoIp") + " " + str;
		}

		// Token: 0x06003308 RID: 13064 RVA: 0x000ABDD0 File Offset: 0x000A9FD0
		[Command]
		public void Balance()
		{
			CloudVoIPViewModel.<Balance>d__16 <Balance>d__;
			<Balance>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Balance>d__.<>4__this = this;
			<Balance>d__.<>1__state = -1;
			<Balance>d__.<>t__builder.Start<CloudVoIPViewModel.<Balance>d__16>(ref <Balance>d__);
		}

		// Token: 0x06003309 RID: 13065 RVA: 0x000ABE08 File Offset: 0x000AA008
		public bool CanBalance()
		{
			return Core.Instance.VoIP != null && Core.Instance.IsValid() && Core.Instance.VoIP.IsBalanceCheckAvailable;
		}

		// Token: 0x0600330A RID: 13066 RVA: 0x000ABE40 File Offset: 0x000AA040
		protected override void OnParameterChanged(object parameter)
		{
			base.OnParameterChanged(parameter);
			if (parameter != null)
			{
				goto IL_2E;
			}
			IL_0A:
			int num = -1104447069;
			IL_0F:
			switch ((num ^ -1414416776) % 4)
			{
			case 0:
				goto IL_0A;
			case 1:
				IL_2E:
				this.SecretVisible = ((VoIPClient)parameter != VoIPClient.Megafon);
				this.EndpointVisible = ((VoIPClient)parameter == VoIPClient.Megafon);
				num = -1704863166;
				goto IL_0F;
			case 3:
				return;
			}
			this.SetName(new VoIPClient?((VoIPClient)parameter));
		}

		// Token: 0x04001D59 RID: 7513
		[CompilerGenerated]
		private ICloudCredentials <Credentials>k__BackingField;

		// Token: 0x04001D5A RID: 7514
		private readonly IToasterService _toasterService;

		// Token: 0x04001D5B RID: 7515
		private readonly IAscMessageBoxService _ascMessageBoxService;

		// Token: 0x04001D5C RID: 7516
		[CompilerGenerated]
		private bool <SecretVisible>k__BackingField;

		// Token: 0x04001D5D RID: 7517
		[CompilerGenerated]
		private bool <EndpointVisible>k__BackingField;

		// Token: 0x0200055F RID: 1375
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Balance>d__16 : IAsyncStateMachine
		{
			// Token: 0x0600330B RID: 13067 RVA: 0x000ABEB8 File Offset: 0x000AA0B8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CloudVoIPViewModel cloudVoIPViewModel = this.<>4__this;
				try
				{
					try
					{
						TaskAwaiter<UserBalance> awaiter;
						if (num != 0)
						{
							awaiter = Core.Instance.VoIP.Balance().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<UserBalance>, CloudVoIPViewModel.<Balance>d__16>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<UserBalance>);
							this.<>1__state = -1;
						}
						UserBalance result = awaiter.GetResult();
						cloudVoIPViewModel._ascMessageBoxService.ShowMessageBox("Info", string.Format("{0} {1}", result.Balance, result.Currency));
					}
					catch (Exception ex)
					{
						cloudVoIPViewModel._toasterService.Error(ex.Message);
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

			// Token: 0x0600330C RID: 13068 RVA: 0x000ABFCC File Offset: 0x000AA1CC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001D5E RID: 7518
			public int <>1__state;

			// Token: 0x04001D5F RID: 7519
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001D60 RID: 7520
			public CloudVoIPViewModel <>4__this;

			// Token: 0x04001D61 RID: 7521
			private TaskAwaiter<UserBalance> <>u__1;
		}
	}
}
