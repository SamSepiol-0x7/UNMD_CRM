using System;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using ASC.Models;
using ASC.Objects;
using ASC.Properties;
using ASC.Services.Abstract;
using ASC.Updater;
using ASC.Updater.Entities;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels
{
	// Token: 0x0200044B RID: 1099
	public class UpdateViewModel : BaseViewModel
	{
		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x06002B59 RID: 11097 RVA: 0x00089EA0 File Offset: 0x000880A0
		// (set) Token: 0x06002B5A RID: 11098 RVA: 0x00089EB4 File Offset: 0x000880B4
		public bool DownloadProgressBarVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<DownloadProgressBarVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<DownloadProgressBarVisible>k__BackingField == value)
				{
					return;
				}
				this.<DownloadProgressBarVisible>k__BackingField = value;
				this.RaisePropertyChanged("DownloadProgressBarVisible");
			}
		}

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x06002B5B RID: 11099 RVA: 0x00089EE0 File Offset: 0x000880E0
		// (set) Token: 0x06002B5C RID: 11100 RVA: 0x00089EF4 File Offset: 0x000880F4
		public double DownloadProgress
		{
			[CompilerGenerated]
			get
			{
				return this.<DownloadProgress>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<DownloadProgress>k__BackingField == value)
				{
					return;
				}
				this.<DownloadProgress>k__BackingField = value;
				this.RaisePropertyChanged("DownloadProgress");
			}
		}

		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x06002B5D RID: 11101 RVA: 0x00089F24 File Offset: 0x00088124
		// (set) Token: 0x06002B5E RID: 11102 RVA: 0x00089F38 File Offset: 0x00088138
		public bool UpdateAvailable
		{
			[CompilerGenerated]
			get
			{
				return this.<UpdateAvailable>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<UpdateAvailable>k__BackingField == value)
				{
					return;
				}
				this.<UpdateAvailable>k__BackingField = value;
				this.RaisePropertyChanged("UpdateAvailable");
			}
		}

		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x06002B5F RID: 11103 RVA: 0x00089F64 File Offset: 0x00088164
		// (set) Token: 0x06002B60 RID: 11104 RVA: 0x00089F78 File Offset: 0x00088178
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
				this.RaisePropertyChanged("Message");
			}
		}

		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x06002B61 RID: 11105 RVA: 0x00089FA8 File Offset: 0x000881A8
		// (set) Token: 0x06002B62 RID: 11106 RVA: 0x00089FBC File Offset: 0x000881BC
		public string CurrentVersion
		{
			[CompilerGenerated]
			get
			{
				return this.<CurrentVersion>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (string.Equals(this.<CurrentVersion>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<CurrentVersion>k__BackingField = value;
				this.RaisePropertyChanged("CurrentVersion");
			}
		}

		// Token: 0x17000E31 RID: 3633
		// (get) Token: 0x06002B63 RID: 11107 RVA: 0x00089FEC File Offset: 0x000881EC
		// (set) Token: 0x06002B64 RID: 11108 RVA: 0x0008A000 File Offset: 0x00088200
		public string Version
		{
			[CompilerGenerated]
			get
			{
				return this.<Version>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (string.Equals(this.<Version>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Version>k__BackingField = value;
				this.RaisePropertyChanged("Version");
			}
		}

		// Token: 0x17000E32 RID: 3634
		// (get) Token: 0x06002B65 RID: 11109 RVA: 0x0008A030 File Offset: 0x00088230
		// (set) Token: 0x06002B66 RID: 11110 RVA: 0x0008A044 File Offset: 0x00088244
		public string ReleaseNotes
		{
			[CompilerGenerated]
			get
			{
				return this.<ReleaseNotes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.<ReleaseNotes>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = 696590945;
				IL_14:
				switch ((num ^ 1507294766) % 4)
				{
				case 0:
					goto IL_0F;
				case 1:
					IL_33:
					this.<ReleaseNotes>k__BackingField = value;
					this.RaisePropertyChanged("ReleaseNotes");
					num = 1587864516;
					goto IL_14;
				case 3:
					return;
				}
			}
		}

		// Token: 0x06002B67 RID: 11111 RVA: 0x0008A0A0 File Offset: 0x000882A0
		public UpdateViewModel()
		{
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
			this.Message = Lang.t("PleaseWait");
			this.CheckForUpdates();
		}

		// Token: 0x06002B68 RID: 11112 RVA: 0x0008A0EC File Offset: 0x000882EC
		private void CheckForUpdates()
		{
			this.CurrentVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
			AutoUpdater.Initialize(AuthModel.GetUpdatePath(), this.CurrentVersion);
			AutoUpdater.Instance.NewUpdate += this.InstanceOnNewUpdate;
			AutoUpdater.Instance.DownloadProgressChanged += this.InstanceOnDownloadProgressChanged;
			AutoUpdater.Instance.Error += this.InstanceOnError;
			AutoUpdater.Instance.DownloadCompleted += this.InstanceOnDownloadCompleted;
			AutoUpdater.Instance.NoUpdates += this.InstanceOnNoUpdates;
		}

		// Token: 0x06002B69 RID: 11113 RVA: 0x0008A194 File Offset: 0x00088394
		private void InstanceOnNoUpdates(object sender, EventArgs e)
		{
			AutoUpdater.Instance.Reject();
			AutoUpdater.Instance.Stop();
			Application.Current.Dispatcher.Invoke(delegate()
			{
				this.Message = Lang.t("NoUpdates");
			});
		}

		// Token: 0x06002B6A RID: 11114 RVA: 0x0008A1D0 File Offset: 0x000883D0
		private void InstanceOnDownloadCompleted(object sender, EventArgs e)
		{
			AutoUpdater.Instance.UpdateView();
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x06002B6B RID: 11115 RVA: 0x0008A1F4 File Offset: 0x000883F4
		private void InstanceOnError(object sender, MessageArgs messageArgs)
		{
			this._toasterService.Error(messageArgs.Message);
		}

		// Token: 0x06002B6C RID: 11116 RVA: 0x0008A214 File Offset: 0x00088414
		private void InstanceOnDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			if (!this.DownloadProgressBarVisible)
			{
				Application.Current.Dispatcher.Invoke(delegate()
				{
					this.DownloadProgressBarVisible = true;
				});
			}
			Application.Current.Dispatcher.Invoke(delegate()
			{
				this.DownloadProgress = (double)e.ProgressPercentage;
			});
		}

		// Token: 0x06002B6D RID: 11117 RVA: 0x0008A274 File Offset: 0x00088474
		private void InstanceOnNewUpdate(object sender, EventArgs e)
		{
			AutoUpdater autoUpdater = sender as AutoUpdater;
			if (autoUpdater != null)
			{
				this.ReleaseNotes = autoUpdater.GetReleaseNotes();
			}
			if (Application.Current != null)
			{
				Application.Current.Dispatcher.Invoke(delegate()
				{
					this.Message = Lang.t("UpdateAvailable");
					this.UpdateAvailable = true;
					base.RaiseCanExecuteChanged(() => this.Update());
				});
				return;
			}
		}

		// Token: 0x06002B6E RID: 11118 RVA: 0x0008A2BC File Offset: 0x000884BC
		[Command]
		public void Update()
		{
			AutoUpdater.Instance.Accept();
		}

		// Token: 0x06002B6F RID: 11119 RVA: 0x0008A2D4 File Offset: 0x000884D4
		public bool CanUpdate()
		{
			return OfflineData.Instance.Employee.Can(1, 0) && this.UpdateAvailable;
		}

		// Token: 0x06002B70 RID: 11120 RVA: 0x0008A2FC File Offset: 0x000884FC
		[Command]
		public void Close()
		{
			AutoUpdater.Instance.Reject();
			AutoUpdater.Instance.Stop();
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x06002B71 RID: 11121 RVA: 0x0008A328 File Offset: 0x00088528
		public void SetVersion(string version)
		{
			this.Version = version;
			base.RaiseCanExecuteChanged(() => this.Skip());
		}

		// Token: 0x06002B72 RID: 11122 RVA: 0x0008A378 File Offset: 0x00088578
		[Command]
		public void Skip()
		{
			Settings.Default.SkipUpdate = this.Version;
			Settings.Default.Save();
			this.Close();
		}

		// Token: 0x06002B73 RID: 11123 RVA: 0x0008A3A8 File Offset: 0x000885A8
		public bool CanSkip()
		{
			return !string.IsNullOrEmpty(this.Version);
		}

		// Token: 0x06002B74 RID: 11124 RVA: 0x0008A3C4 File Offset: 0x000885C4
		[CompilerGenerated]
		private void <InstanceOnNoUpdates>b__32_0()
		{
			this.Message = Lang.t("NoUpdates");
		}

		// Token: 0x06002B75 RID: 11125 RVA: 0x0008A3E4 File Offset: 0x000885E4
		[CompilerGenerated]
		private void <InstanceOnNewUpdate>b__36_0()
		{
			this.Message = Lang.t("UpdateAvailable");
			this.UpdateAvailable = true;
			base.RaiseCanExecuteChanged(() => this.Update());
		}

		// Token: 0x04001832 RID: 6194
		private readonly IToasterService _toasterService;

		// Token: 0x04001833 RID: 6195
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04001834 RID: 6196
		[CompilerGenerated]
		private bool <DownloadProgressBarVisible>k__BackingField;

		// Token: 0x04001835 RID: 6197
		[CompilerGenerated]
		private double <DownloadProgress>k__BackingField;

		// Token: 0x04001836 RID: 6198
		[CompilerGenerated]
		private bool <UpdateAvailable>k__BackingField;

		// Token: 0x04001837 RID: 6199
		[CompilerGenerated]
		private string <Message>k__BackingField;

		// Token: 0x04001838 RID: 6200
		[CompilerGenerated]
		private string <CurrentVersion>k__BackingField;

		// Token: 0x04001839 RID: 6201
		[CompilerGenerated]
		private string <Version>k__BackingField;

		// Token: 0x0400183A RID: 6202
		[CompilerGenerated]
		private string <ReleaseNotes>k__BackingField;

		// Token: 0x0200044C RID: 1100
		[CompilerGenerated]
		private sealed class <>c__DisplayClass35_0
		{
			// Token: 0x06002B76 RID: 11126 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass35_0()
			{
			}

			// Token: 0x06002B77 RID: 11127 RVA: 0x0008A444 File Offset: 0x00088644
			internal void <InstanceOnDownloadProgressChanged>b__0()
			{
				this.<>4__this.DownloadProgressBarVisible = true;
			}

			// Token: 0x06002B78 RID: 11128 RVA: 0x0008A460 File Offset: 0x00088660
			internal void <InstanceOnDownloadProgressChanged>b__1()
			{
				this.<>4__this.DownloadProgress = (double)this.downloadProgressChangedEventArgs.ProgressPercentage;
			}

			// Token: 0x0400183B RID: 6203
			public UpdateViewModel <>4__this;

			// Token: 0x0400183C RID: 6204
			public DownloadProgressChangedEventArgs downloadProgressChangedEventArgs;
		}
	}
}
