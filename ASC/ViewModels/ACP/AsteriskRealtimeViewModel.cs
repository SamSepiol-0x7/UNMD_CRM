using System;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces.VoIP;
using ASC.Common.Objects.VoIP;
using ASC.Objects;
using ASC.Services.Abstract;
using AsterNET.Manager;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels.ACP
{
	// Token: 0x0200055B RID: 1371
	public class AsteriskRealtimeViewModel : BaseViewModel
	{
		// Token: 0x17000F9B RID: 3995
		// (get) Token: 0x060032ED RID: 13037 RVA: 0x000AB680 File Offset: 0x000A9880
		// (set) Token: 0x060032EE RID: 13038 RVA: 0x000AB694 File Offset: 0x000A9894
		public IAsteriskCredentials Credentials
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

		// Token: 0x17000F9C RID: 3996
		// (get) Token: 0x060032EF RID: 13039 RVA: 0x000AB6C4 File Offset: 0x000A98C4
		// (set) Token: 0x060032F0 RID: 13040 RVA: 0x000AB6D8 File Offset: 0x000A98D8
		public bool WebPortVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<WebPortVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<WebPortVisible>k__BackingField == value)
				{
					return;
				}
				this.<WebPortVisible>k__BackingField = value;
				this.RaisePropertyChanged("WebPortVisible");
			}
		}

		// Token: 0x060032F1 RID: 13041 RVA: 0x000AB704 File Offset: 0x000A9904
		public AsteriskRealtimeViewModel(config c)
		{
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._ascMessageBoxService = Bootstrapper.Container.Resolve<IAscMessageBoxService>();
			VoIPClient? voip = OfflineData.Instance.Settings.Voip;
			if (voip.GetValueOrDefault() == VoIPClient.AsteriskRealtime & voip != null)
			{
				this.Credentials = new AsteriskRealtimeCredentials
				{
					Host = c.aster_host,
					Port = c.aster_port,
					Login = c.aster_login,
					Password = c.aster_password,
					WebPort = c.aster_web_port,
					Prefix = OfflineData.Instance.Settings.VoipPrefix
				};
			}
			voip = OfflineData.Instance.Settings.Voip;
			if (voip.GetValueOrDefault() == VoIPClient.AsteriskAMI & voip != null)
			{
				this.Credentials = new AsteriskAMICredentials(c.aster_host, c.aster_port, c.aster_login, c.aster_password, OfflineData.Instance.Settings.VoipPrefix);
			}
			voip = OfflineData.Instance.Settings.Voip;
			this.WebPortVisible = (voip.GetValueOrDefault() == VoIPClient.AsteriskRealtime & voip != null);
		}

		// Token: 0x060032F2 RID: 13042 RVA: 0x000AB838 File Offset: 0x000A9A38
		[Command]
		public void TestConnection()
		{
			ManagerConnection managerConnection = new ManagerConnection(this.Credentials.Host, this.Credentials.Port, this.Credentials.Login, this.Credentials.Password);
			try
			{
				managerConnection.Login();
				this._ascMessageBoxService.ShowMessageBox("Info", managerConnection.AsteriskVersion.ToString());
			}
			catch (Exception ex)
			{
				this._toasterService.Error(ex.Message);
			}
		}

		// Token: 0x04001D4D RID: 7501
		private readonly IToasterService _toasterService;

		// Token: 0x04001D4E RID: 7502
		private readonly IAscMessageBoxService _ascMessageBoxService;

		// Token: 0x04001D4F RID: 7503
		[CompilerGenerated]
		private IAsteriskCredentials <Credentials>k__BackingField;

		// Token: 0x04001D50 RID: 7504
		[CompilerGenerated]
		private bool <WebPortVisible>k__BackingField;
	}
}
