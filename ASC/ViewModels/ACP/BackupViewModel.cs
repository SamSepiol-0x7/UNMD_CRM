using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using ASC.Common.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Properties;
using ASC.Services.Abstract;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;
using MySql.Data.MySqlClient;

namespace ASC.ViewModels.ACP
{
	// Token: 0x02000574 RID: 1396
	public class BackupViewModel : BaseViewModel
	{
		// Token: 0x17000FB5 RID: 4021
		// (get) Token: 0x06003388 RID: 13192 RVA: 0x000AE1F4 File Offset: 0x000AC3F4
		// (set) Token: 0x06003389 RID: 13193 RVA: 0x000AE208 File Offset: 0x000AC408
		public int RepairsCounter
		{
			[CompilerGenerated]
			get
			{
				return this.<RepairsCounter>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<RepairsCounter>k__BackingField == value)
				{
					return;
				}
				this.<RepairsCounter>k__BackingField = value;
				this.RaisePropertyChanged("RepairsCounter");
			}
		}

		// Token: 0x17000FB6 RID: 4022
		// (get) Token: 0x0600338A RID: 13194 RVA: 0x000AE234 File Offset: 0x000AC434
		// (set) Token: 0x0600338B RID: 13195 RVA: 0x000AE248 File Offset: 0x000AC448
		public bool ExcludePhotos
		{
			[CompilerGenerated]
			get
			{
				return this.<ExcludePhotos>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ExcludePhotos>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = 2050170560;
				IL_10:
				switch ((num ^ 1470011897) % 4)
				{
				case 0:
					goto IL_0B;
				case 1:
					return;
				case 3:
					IL_2F:
					this.<ExcludePhotos>k__BackingField = value;
					this.RaisePropertyChanged("ExcludePhotos");
					num = 1316829431;
					goto IL_10;
				}
			}
		}

		// Token: 0x17000FB7 RID: 4023
		// (get) Token: 0x0600338C RID: 13196 RVA: 0x000AE2A0 File Offset: 0x000AC4A0
		// (set) Token: 0x0600338D RID: 13197 RVA: 0x000AE2B4 File Offset: 0x000AC4B4
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

		// Token: 0x17000FB8 RID: 4024
		// (get) Token: 0x0600338E RID: 13198 RVA: 0x000AE2E4 File Offset: 0x000AC4E4
		// (set) Token: 0x0600338F RID: 13199 RVA: 0x000AE2F8 File Offset: 0x000AC4F8
		public double Progress
		{
			[CompilerGenerated]
			get
			{
				return this.<Progress>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Progress>k__BackingField == value)
				{
					return;
				}
				this.<Progress>k__BackingField = value;
				this.RaisePropertyChanged("Progress");
			}
		}

		// Token: 0x17000FB9 RID: 4025
		// (get) Token: 0x06003390 RID: 13200 RVA: 0x000AE328 File Offset: 0x000AC528
		// (set) Token: 0x06003391 RID: 13201 RVA: 0x000AE33C File Offset: 0x000AC53C
		public long TotalRows
		{
			[CompilerGenerated]
			get
			{
				return this.<TotalRows>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<TotalRows>k__BackingField == value)
				{
					return;
				}
				this.<TotalRows>k__BackingField = value;
				this.RaisePropertyChanged("TotalRows");
			}
		}

		// Token: 0x06003392 RID: 13202 RVA: 0x000AE368 File Offset: 0x000AC568
		private void RefreshCommands()
		{
			base.RaiseCanExecuteChanged(() => this.BackupStop());
			base.RaiseCanExecuteChanged(() => this.Backup());
		}

		// Token: 0x06003393 RID: 13203 RVA: 0x000AE3EC File Offset: 0x000AC5EC
		public BackupViewModel()
		{
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._ascMessageBoxService = Bootstrapper.Container.Resolve<IAscMessageBoxService>();
			this._backupModel = new BackupModel();
			this._backupModel.BackupTick += this.BackupModelOnBackupTick;
			this._bgBackup = new BackgroundWorker();
			this._bgBackup.RunWorkerCompleted += this.BgBackupOnRunWorkerCompleted;
			this._bgBackup.DoWork += this.BgBackupOnDoWork;
			this._bgRestoreBackup = new BackgroundWorker();
			this._bgRestoreBackup.DoWork += this.BgRestoreBackupOnDoWork;
			this.RepairsCounter = BackupModel.LastWorkshopId();
		}

		// Token: 0x06003394 RID: 13204 RVA: 0x000AE4C4 File Offset: 0x000AC6C4
		private void BackupModelOnBackupTick(object sender, ExportProgressArgs e)
		{
			if (this._backupModel.CancellBackup)
			{
				for (;;)
				{
					MySqlBackup mySqlBackup = sender as MySqlBackup;
					if (mySqlBackup != null)
					{
						mySqlBackup.StopAllProcess();
						uint num;
						switch ((num = (num * 69373766U ^ 1920449700U ^ 1025661512U)) % 4U)
						{
						case 0U:
						case 3U:
							continue;
						case 2U:
							goto IL_4A;
						}
						break;
					}
					goto IL_49;
				}
				goto IL_59;
				IL_49:
				IL_4A:
				this.Progress = 0.0;
			}
			IL_59:
			this.Progress = (double)e.CurrentRowIndexInAllTables;
		}

		// Token: 0x06003395 RID: 13205 RVA: 0x000AE538 File Offset: 0x000AC738
		private void BgBackupOnRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.RefreshCommands();
		}

		// Token: 0x06003396 RID: 13206 RVA: 0x000AE54C File Offset: 0x000AC74C
		[Command]
		public void BackupStop()
		{
			if (this._bgBackup.IsBusy)
			{
				this._backupModel.CancellBackup = true;
			}
		}

		// Token: 0x06003397 RID: 13207 RVA: 0x000AE574 File Offset: 0x000AC774
		public bool CanBackupStop()
		{
			return this._bgBackup.IsBusy;
		}

		// Token: 0x06003398 RID: 13208 RVA: 0x000AE58C File Offset: 0x000AC78C
		[Command]
		public void SelectBackupPath()
		{
			using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
			{
				if (folderBrowserDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
				{
					Settings.Default.BackupPath = folderBrowserDialog.SelectedPath;
					Settings.Default.Save();
				}
			}
		}

		// Token: 0x06003399 RID: 13209 RVA: 0x000AE5EC File Offset: 0x000AC7EC
		[Command]
		public void Restore()
		{
			if (Auth.User.username != "admin")
			{
				this._toasterService.Info(Lang.t("LoginAsAdmin"));
				return;
			}
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Multiselect = false;
				openFileDialog.Filter = "SQL Dump files (*.sql) | *.sql;";
				if (openFileDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(openFileDialog.FileName))
				{
					this._ascMessageBoxService.ShowMessageBox(Lang.t("ImportDbWarning"));
					this._bgRestoreBackup.RunWorkerAsync(openFileDialog.FileName);
				}
			}
		}

		// Token: 0x0600339A RID: 13210 RVA: 0x0007E5F4 File Offset: 0x0007C7F4
		public bool CanRestore()
		{
			return true;
		}

		// Token: 0x0600339B RID: 13211 RVA: 0x000AE698 File Offset: 0x000AC898
		private void BgRestoreBackupOnDoWork(object sender, DoWorkEventArgs e)
		{
			string text = e.Argument as string;
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			IAscResult ascResult = this.Restore(text);
			if (ascResult.IsSucces)
			{
				BackupModel.RestoreUsers();
				this.Progress = 100.0;
				System.Windows.Application.Current.Dispatcher.Invoke(delegate()
				{
					this._toasterService.Success(Lang.t("DbImportComplete"));
				});
				this.Progress = 0.0;
				return;
			}
			this._toasterService.Error(ascResult.Message);
		}

		// Token: 0x0600339C RID: 13212 RVA: 0x000AE71C File Offset: 0x000AC91C
		public void MbOnImportProgressChanged(object sender, ImportProgressArgs importProgressArgs)
		{
			this.Progress = (double)importProgressArgs.PercentageCompleted;
		}

		// Token: 0x0600339D RID: 13213 RVA: 0x000AE738 File Offset: 0x000AC938
		private bool ChechPath()
		{
			if (string.IsNullOrEmpty(Settings.Default.BackupPath))
			{
				this._toasterService.Info(Lang.t("SelectBackupPath"));
				return false;
			}
			return true;
		}

		// Token: 0x0600339E RID: 13214 RVA: 0x000AE770 File Offset: 0x000AC970
		[Command]
		public void Backup()
		{
			if (!this.ChechPath())
			{
				return;
			}
			if (!this._bgBackup.IsBusy)
			{
				this._bgBackup.RunWorkerAsync();
				this.RefreshCommands();
			}
		}

		// Token: 0x0600339F RID: 13215 RVA: 0x000AE7A4 File Offset: 0x000AC9A4
		public bool CanBackup()
		{
			return Auth.User != null && !this._bgBackup.IsBusy && OfflineData.Instance.Employee.Can(66, 0);
		}

		// Token: 0x060033A0 RID: 13216 RVA: 0x000AE7DC File Offset: 0x000AC9DC
		private void BgBackupOnDoWork(object sender, DoWorkEventArgs e)
		{
			if (this._backupModel.Backup(this.ExcludePhotos))
			{
				this.Progress = 100.0;
				System.Windows.Application.Current.Dispatcher.Invoke(delegate()
				{
					this._toasterService.Success(Lang.t("Complete"));
				});
				this.Progress = 0.0;
			}
		}

		// Token: 0x060033A1 RID: 13217 RVA: 0x000AE838 File Offset: 0x000ACA38
		[Command]
		public void Save()
		{
			BackupViewModel.<Save>d__40 <Save>d__;
			<Save>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Save>d__.<>4__this = this;
			<Save>d__.<>1__state = -1;
			<Save>d__.<>t__builder.Start<BackupViewModel.<Save>d__40>(ref <Save>d__);
		}

		// Token: 0x060033A2 RID: 13218 RVA: 0x000AE870 File Offset: 0x000ACA70
		[Command]
		public void SetRepairCounter()
		{
			if (this.RepairsCounter <= BackupModel.LastWorkshopId())
			{
				this._toasterService.Info(Lang.t("SetRepairsCounterWarning2"));
				return;
			}
			if (this._ascMessageBoxService.ShowMessageBox(Lang.t("SetRepairsCounterWarning"), Lang.t("RepairsCounter"), MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
			{
				if (BackupModel.SetWorkshopAutoIncrement(this.RepairsCounter))
				{
					this._toasterService.Success(Lang.t("Saved"));
					return;
				}
				this._toasterService.Error("");
			}
		}

		// Token: 0x060033A3 RID: 13219 RVA: 0x000AE8F8 File Offset: 0x000ACAF8
		public IAscResult Restore(string filePath)
		{
			Result result = new Result();
			using (MySqlConnection mySqlConnection = new MySqlConnection(Auth.CnnString + ";convertzerodatetime=true;"))
			{
				using (MySqlCommand mySqlCommand = new MySqlCommand())
				{
					using (MySqlBackup mySqlBackup = new MySqlBackup(mySqlCommand))
					{
						mySqlCommand.Connection = mySqlConnection;
						mySqlBackup.Command.CommandTimeout = 0;
						mySqlConnection.Open();
						mySqlBackup.ImportProgressChanged += this.MbOnImportProgressChanged;
						try
						{
							mySqlBackup.ImportFromFile(filePath);
						}
						catch (Exception ex)
						{
							result.Message = ex.Message;
							return result;
						}
						mySqlConnection.Close();
					}
				}
			}
			result.SetSuccess();
			return result;
		}

		// Token: 0x060033A4 RID: 13220 RVA: 0x000AE9DC File Offset: 0x000ACBDC
		[CompilerGenerated]
		private void <BgRestoreBackupOnDoWork>b__34_0()
		{
			this._toasterService.Success(Lang.t("DbImportComplete"));
		}

		// Token: 0x060033A5 RID: 13221 RVA: 0x000AEA00 File Offset: 0x000ACC00
		[CompilerGenerated]
		private void <BgBackupOnDoWork>b__39_0()
		{
			this._toasterService.Success(Lang.t("Complete"));
		}

		// Token: 0x060033A6 RID: 13222 RVA: 0x000AEA24 File Offset: 0x000ACC24
		[CompilerGenerated]
		private bool <Save>b__40_0()
		{
			return ConfigModel.UpdateConfig(this.Config);
		}

		// Token: 0x04001DB6 RID: 7606
		private IToasterService _toasterService;

		// Token: 0x04001DB7 RID: 7607
		private IAscMessageBoxService _ascMessageBoxService;

		// Token: 0x04001DB8 RID: 7608
		private BackupModel _backupModel;

		// Token: 0x04001DB9 RID: 7609
		[CompilerGenerated]
		private int <RepairsCounter>k__BackingField;

		// Token: 0x04001DBA RID: 7610
		private BackgroundWorker _bgBackup;

		// Token: 0x04001DBB RID: 7611
		private BackgroundWorker _bgRestoreBackup;

		// Token: 0x04001DBC RID: 7612
		[CompilerGenerated]
		private bool <ExcludePhotos>k__BackingField;

		// Token: 0x04001DBD RID: 7613
		[CompilerGenerated]
		private config <Config>k__BackingField = Auth.Config;

		// Token: 0x04001DBE RID: 7614
		[CompilerGenerated]
		private double <Progress>k__BackingField;

		// Token: 0x04001DBF RID: 7615
		[CompilerGenerated]
		private long <TotalRows>k__BackingField = 1L;

		// Token: 0x02000575 RID: 1397
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Save>d__40 : IAsyncStateMachine
		{
			// Token: 0x060033A7 RID: 13223 RVA: 0x000AEA3C File Offset: 0x000ACC3C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				BackupViewModel backupViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						if (!backupViewModel.ChechPath())
						{
							goto IL_B2;
						}
						backupViewModel.ShowWait();
						awaiter = Task.Run<bool>(() => ConfigModel.UpdateConfig(base.Config)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, BackupViewModel.<Save>d__40>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<bool>);
						this.<>1__state = -1;
					}
					bool result = awaiter.GetResult();
					backupViewModel.HideWait();
					backupViewModel.ShowActionResponse(result, "");
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_B2:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060033A8 RID: 13224 RVA: 0x000AEB20 File Offset: 0x000ACD20
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001DC0 RID: 7616
			public int <>1__state;

			// Token: 0x04001DC1 RID: 7617
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001DC2 RID: 7618
			public BackupViewModel <>4__this;

			// Token: 0x04001DC3 RID: 7619
			private TaskAwaiter<bool> <>u__1;
		}
	}
}
