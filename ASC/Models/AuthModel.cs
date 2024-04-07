using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Objects;
using ASC.Objects.Converters;
using ASC.Properties;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using ASC.Updater;
using ASC.WorkspaceV2;
using Autofac;
using DbUp;
using DbUp.Engine;
using DevExpress.Xpf.Core;
using MySql.Data.MySqlClient;

namespace ASC.Models
{
	// Token: 0x020009D4 RID: 2516
	public class AuthModel : INotifyPropertyChanged
	{
		// Token: 0x14000017 RID: 23
		// (add) Token: 0x06004B09 RID: 19209 RVA: 0x001311FC File Offset: 0x0012F3FC
		// (remove) Token: 0x06004B0A RID: 19210 RVA: 0x00131234 File Offset: 0x0012F434
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

		// Token: 0x1700146D RID: 5229
		// (get) Token: 0x06004B0B RID: 19211 RVA: 0x00131270 File Offset: 0x0012F470
		// (set) Token: 0x06004B0C RID: 19212 RVA: 0x00131284 File Offset: 0x0012F484
		public Action HideAction
		{
			[CompilerGenerated]
			get
			{
				return this.<HideAction>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<HideAction>k__BackingField, value))
				{
					return;
				}
				this.<HideAction>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.HideAction);
			}
		}

		// Token: 0x1700146E RID: 5230
		// (get) Token: 0x06004B0D RID: 19213 RVA: 0x001312B4 File Offset: 0x0012F4B4
		// (set) Token: 0x06004B0E RID: 19214 RVA: 0x001312C8 File Offset: 0x0012F4C8
		public Action CloseAction
		{
			[CompilerGenerated]
			get
			{
				return this.<CloseAction>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<CloseAction>k__BackingField, value))
				{
					return;
				}
				this.<CloseAction>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.CloseAction);
			}
		}

		// Token: 0x1700146F RID: 5231
		// (get) Token: 0x06004B0F RID: 19215 RVA: 0x001312F8 File Offset: 0x0012F4F8
		// (set) Token: 0x06004B10 RID: 19216 RVA: 0x0013130C File Offset: 0x0012F50C
		public string AssemblyVersion
		{
			[CompilerGenerated]
			get
			{
				return this.<AssemblyVersion>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (string.Equals(this.<AssemblyVersion>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<AssemblyVersion>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.AssemblyVersion);
			}
		}

		// Token: 0x17001470 RID: 5232
		// (get) Token: 0x06004B11 RID: 19217 RVA: 0x0013133C File Offset: 0x0012F53C
		// (set) Token: 0x06004B12 RID: 19218 RVA: 0x00131350 File Offset: 0x0012F550
		public List<IdNameClass> Offices
		{
			[CompilerGenerated]
			get
			{
				return this.<Offices>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Offices>k__BackingField, value))
				{
					return;
				}
				this.<Offices>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.Offices);
			}
		}

		// Token: 0x17001471 RID: 5233
		// (get) Token: 0x06004B13 RID: 19219 RVA: 0x00131380 File Offset: 0x0012F580
		// (set) Token: 0x06004B14 RID: 19220 RVA: 0x00131394 File Offset: 0x0012F594
		public users User
		{
			[CompilerGenerated]
			get
			{
				return this.<User>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<User>k__BackingField, value))
				{
					return;
				}
				this.<User>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.User);
			}
		}

		// Token: 0x17001472 RID: 5234
		// (get) Token: 0x06004B15 RID: 19221 RVA: 0x001313C4 File Offset: 0x0012F5C4
		// (set) Token: 0x06004B16 RID: 19222 RVA: 0x001313D8 File Offset: 0x0012F5D8
		public ICommand SetDefaultsCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<SetDefaultsCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SetDefaultsCommand>k__BackingField, value))
				{
					return;
				}
				this.<SetDefaultsCommand>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.SetDefaultsCommand);
			}
		}

		// Token: 0x17001473 RID: 5235
		// (get) Token: 0x06004B17 RID: 19223 RVA: 0x00131408 File Offset: 0x0012F608
		// (set) Token: 0x06004B18 RID: 19224 RVA: 0x0013141C File Offset: 0x0012F61C
		public RelayCommand LoginBtnClickCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<LoginBtnClickCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<LoginBtnClickCommand>k__BackingField, value))
				{
					return;
				}
				this.<LoginBtnClickCommand>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.LoginBtnClickCommand);
			}
		}

		// Token: 0x17001474 RID: 5236
		// (get) Token: 0x06004B19 RID: 19225 RVA: 0x0013144C File Offset: 0x0012F64C
		// (set) Token: 0x06004B1A RID: 19226 RVA: 0x00131460 File Offset: 0x0012F660
		public RelayCommand TestConnectionCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<TestConnectionCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<TestConnectionCommand>k__BackingField, value))
				{
					return;
				}
				this.<TestConnectionCommand>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.TestConnectionCommand);
			}
		}

		// Token: 0x17001475 RID: 5237
		// (get) Token: 0x06004B1B RID: 19227 RVA: 0x00131490 File Offset: 0x0012F690
		// (set) Token: 0x06004B1C RID: 19228 RVA: 0x001314A4 File Offset: 0x0012F6A4
		public RelayCommand DeployDatabaseCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<DeployDatabaseCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<DeployDatabaseCommand>k__BackingField, value))
				{
					return;
				}
				this.<DeployDatabaseCommand>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.DeployDatabaseCommand);
			}
		}

		// Token: 0x17001476 RID: 5238
		// (get) Token: 0x06004B1D RID: 19229 RVA: 0x001314D4 File Offset: 0x0012F6D4
		// (set) Token: 0x06004B1E RID: 19230 RVA: 0x001314E8 File Offset: 0x0012F6E8
		public ICommand ContinueLoginCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<ContinueLoginCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ContinueLoginCommand>k__BackingField, value))
				{
					return;
				}
				this.<ContinueLoginCommand>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.ContinueLoginCommand);
			}
		}

		// Token: 0x17001477 RID: 5239
		// (get) Token: 0x06004B1F RID: 19231 RVA: 0x00131518 File Offset: 0x0012F718
		// (set) Token: 0x06004B20 RID: 19232 RVA: 0x0013152C File Offset: 0x0012F72C
		public ICommand ToggleSettingsCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<ToggleSettingsCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<ToggleSettingsCommand>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 634471966;
				IL_13:
				switch ((num ^ 367172143) % 4)
				{
				case 0:
					IL_32:
					num = 305363312;
					goto IL_13;
				case 1:
					return;
				case 2:
					goto IL_0E;
				}
				this.<ToggleSettingsCommand>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.ToggleSettingsCommand);
			}
		}

		// Token: 0x17001478 RID: 5240
		// (get) Token: 0x06004B21 RID: 19233 RVA: 0x00131588 File Offset: 0x0012F788
		// (set) Token: 0x06004B22 RID: 19234 RVA: 0x0013159C File Offset: 0x0012F79C
		public static string Host
		{
			[CompilerGenerated]
			get
			{
				return AuthModel.<Host>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				AuthModel.<Host>k__BackingField = value;
			}
		}

		// Token: 0x17001479 RID: 5241
		// (get) Token: 0x06004B23 RID: 19235 RVA: 0x001315B0 File Offset: 0x0012F7B0
		// (set) Token: 0x06004B24 RID: 19236 RVA: 0x001315C4 File Offset: 0x0012F7C4
		public static uint Port
		{
			[CompilerGenerated]
			get
			{
				return AuthModel.<Port>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				AuthModel.<Port>k__BackingField = value;
			}
		}

		// Token: 0x1700147A RID: 5242
		// (get) Token: 0x06004B25 RID: 19237 RVA: 0x001315D8 File Offset: 0x0012F7D8
		// (set) Token: 0x06004B26 RID: 19238 RVA: 0x001315EC File Offset: 0x0012F7EC
		public static string DbName
		{
			[CompilerGenerated]
			get
			{
				return AuthModel.<DbName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				AuthModel.<DbName>k__BackingField = value;
			}
		}

		// Token: 0x1700147B RID: 5243
		// (get) Token: 0x06004B27 RID: 19239 RVA: 0x00131600 File Offset: 0x0012F800
		// (set) Token: 0x06004B28 RID: 19240 RVA: 0x00131614 File Offset: 0x0012F814
		public string Username
		{
			[CompilerGenerated]
			get
			{
				return this.<Username>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Username>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Username>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.Username);
			}
		}

		// Token: 0x1700147C RID: 5244
		// (get) Token: 0x06004B29 RID: 19241 RVA: 0x00131644 File Offset: 0x0012F844
		// (set) Token: 0x06004B2A RID: 19242 RVA: 0x00131658 File Offset: 0x0012F858
		public bool SettingsVisibility
		{
			[CompilerGenerated]
			get
			{
				return this.<SettingsVisibility>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SettingsVisibility>k__BackingField == value)
				{
					return;
				}
				this.<SettingsVisibility>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.SettingsVisibility);
			}
		}

		// Token: 0x1700147D RID: 5245
		// (get) Token: 0x06004B2B RID: 19243 RVA: 0x00131684 File Offset: 0x0012F884
		// (set) Token: 0x06004B2C RID: 19244 RVA: 0x00131698 File Offset: 0x0012F898
		public bool DefaultVisibility
		{
			[CompilerGenerated]
			get
			{
				return this.<DefaultVisibility>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<DefaultVisibility>k__BackingField == value)
				{
					return;
				}
				this.<DefaultVisibility>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.DefaultVisibility);
			}
		}

		// Token: 0x1700147E RID: 5246
		// (get) Token: 0x06004B2D RID: 19245 RVA: 0x001316C4 File Offset: 0x0012F8C4
		// (set) Token: 0x06004B2E RID: 19246 RVA: 0x001316D8 File Offset: 0x0012F8D8
		public bool OfficesSelectVis
		{
			[CompilerGenerated]
			get
			{
				return this.<OfficesSelectVis>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<OfficesSelectVis>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -1535234061;
				IL_10:
				switch ((num ^ -1773392166) % 4)
				{
				case 1:
					return;
				case 2:
					goto IL_0B;
				case 3:
					IL_2F:
					this.<OfficesSelectVis>k__BackingField = value;
					num = -1330065050;
					goto IL_10;
				}
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.OfficesSelectVis);
			}
		}

		// Token: 0x1700147F RID: 5247
		// (get) Token: 0x06004B2F RID: 19247 RVA: 0x00131730 File Offset: 0x0012F930
		// (set) Token: 0x06004B30 RID: 19248 RVA: 0x00131744 File Offset: 0x0012F944
		public bool FirstRun
		{
			get
			{
				return this._firstRun;
			}
			set
			{
				if (this._firstRun != value)
				{
					for (;;)
					{
						IL_51:
						this._firstRun = value;
						this.<>OnPropertyChanged(<>PropertyChangedEventArgs.FirstRun);
						this.Username = "root";
						for (;;)
						{
							RelayCommand testConnectionCommand = this.TestConnectionCommand;
							if (testConnectionCommand != null)
							{
								testConnectionCommand.RaiseCanExecuteChanged();
								uint num;
								switch ((num = (num * 1667239712U ^ 4167269163U ^ 1448589575U)) % 6U)
								{
								case 0U:
								case 5U:
									return;
								case 1U:
									goto IL_51;
								case 2U:
									goto IL_72;
								case 3U:
									continue;
								}
								goto Block_3;
							}
							goto IL_71;
						}
					}
					Block_3:
					return;
					IL_71:
					IL_72:
					RelayCommand deployDatabaseCommand = this.DeployDatabaseCommand;
					if (deployDatabaseCommand != null)
					{
						deployDatabaseCommand.RaiseCanExecuteChanged();
					}
					return;
				}
			}
		}

		// Token: 0x17001480 RID: 5248
		// (get) Token: 0x06004B31 RID: 19249 RVA: 0x001317D4 File Offset: 0x0012F9D4
		// (set) Token: 0x06004B32 RID: 19250 RVA: 0x001317E8 File Offset: 0x0012F9E8
		public bool ProgressVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<ProgressVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ProgressVisible>k__BackingField == value)
				{
					return;
				}
				this.<ProgressVisible>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.ProgressVisible);
			}
		}

		// Token: 0x17001481 RID: 5249
		// (get) Token: 0x06004B33 RID: 19251 RVA: 0x00131814 File Offset: 0x0012FA14
		// (set) Token: 0x06004B34 RID: 19252 RVA: 0x00131828 File Offset: 0x0012FA28
		public double ProgressValue
		{
			[CompilerGenerated]
			get
			{
				return this.<ProgressValue>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!(this.<ProgressValue>k__BackingField == value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1534242732;
				IL_13:
				switch ((num ^ -1429364091) % 4)
				{
				case 1:
					return;
				case 2:
					IL_32:
					num = -842901411;
					goto IL_13;
				case 3:
					goto IL_0E;
				}
				this.<ProgressValue>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.ProgressValue);
			}
		}

		// Token: 0x17001482 RID: 5250
		// (get) Token: 0x06004B35 RID: 19253 RVA: 0x00131884 File Offset: 0x0012FA84
		// (set) Token: 0x06004B36 RID: 19254 RVA: 0x00131898 File Offset: 0x0012FA98
		public string LoadMsg
		{
			[CompilerGenerated]
			get
			{
				return this.<LoadMsg>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<LoadMsg>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<LoadMsg>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.LoadMsg);
			}
		}

		// Token: 0x17001483 RID: 5251
		// (get) Token: 0x06004B37 RID: 19255 RVA: 0x001318C8 File Offset: 0x0012FAC8
		// (set) Token: 0x06004B38 RID: 19256 RVA: 0x001318DC File Offset: 0x0012FADC
		public bool CapslockActive
		{
			get
			{
				return this._capslockActive;
			}
			set
			{
				if (this._capslockActive == value)
				{
					return;
				}
				this._capslockActive = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.CapslockActive);
			}
		}

		// Token: 0x17001484 RID: 5252
		// (get) Token: 0x06004B39 RID: 19257 RVA: 0x00131908 File Offset: 0x0012FB08
		// (set) Token: 0x06004B3A RID: 19258 RVA: 0x00131934 File Offset: 0x0012FB34
		public string Language
		{
			get
			{
				if (!string.IsNullOrEmpty(this._language))
				{
					App.SelectCulture(this._language);
				}
				return this._language;
			}
			set
			{
				if (string.Equals(this._language, value, StringComparison.Ordinal))
				{
					return;
				}
				this._language = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.Language);
				App.SelectCulture(this._language);
				Settings.Default.language = this._language;
				Settings.Default.Save();
			}
		}

		// Token: 0x06004B3B RID: 19259 RVA: 0x00131988 File Offset: 0x0012FB88
		public AuthModel()
		{
			this.ShowDefault();
			this._employeeService = Bootstrapper.Container.Resolve<IEmployeeService>();
			this._userActivityService = Bootstrapper.Container.Resolve<IUserActivityService>();
			this._seedDataService = Bootstrapper.Container.Resolve<ISeedData>();
			this.RemoveUpdateFiles();
			if (Settings.Default.SettingsUpgradeRequired)
			{
				try
				{
					Settings.Default.Upgrade();
					Settings.Default.SettingsUpgradeRequired = false;
					Settings.Default.Save();
				}
				catch (Exception ex)
				{
					System.Windows.MessageBox.Show(ex.Message);
				}
			}
			this.AssemblyVersion = AuthModel.GetVersion();
			AuthModel.Host = Settings.Default.dbHost;
			AuthModel.Port = Settings.Default.dbPort;
			AuthModel.DbName = Settings.Default.dbName;
			this.Username = Settings.Default.lastLogin;
			this._bgLogin.DoWork += this.BgLoginOnDoWork;
			this._bgLogin.ProgressChanged += this.BgLoginOnProgressChanged;
			this._bgLogin.RunWorkerCompleted += this.BgLoginOnRunWorkerCompleted;
			this.InitCommands();
		}

		// Token: 0x06004B3C RID: 19260 RVA: 0x00131AEC File Offset: 0x0012FCEC
		public static string GetVersion()
		{
			return Assembly.GetExecutingAssembly().GetName().Version.ToString();
		}

		// Token: 0x06004B3D RID: 19261 RVA: 0x00131B10 File Offset: 0x0012FD10
		private void RemoveUpdateFiles()
		{
			string directoryName = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
			if (directoryName == null)
			{
				return;
			}
			string path = Path.Combine(directoryName, "UpdaterConfig.json");
			string path2 = Path.Combine(directoryName, "update.zip");
			try
			{
				if (File.Exists(path))
				{
					File.Delete(path);
				}
				if (File.Exists(path2))
				{
					File.Delete(path2);
				}
			}
			catch (Exception ex)
			{
				System.Windows.MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06004B3E RID: 19262 RVA: 0x00131B84 File Offset: 0x0012FD84
		private void BgLoginOnProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			this.ProgressValue = (double)e.ProgressPercentage;
		}

		// Token: 0x06004B3F RID: 19263 RVA: 0x00131BA0 File Offset: 0x0012FDA0
		private void InitCommands()
		{
			this.SetDefaultsCommand = new RelayCommand(new Action<object>(this.SetDefaults));
			this.LoginBtnClickCommand = new RelayCommand(new Action<object>(this.LoginBtnClick), new Func<bool>(this.CanLoginBtnClick));
			this.DeployDatabaseCommand = new RelayCommand(new Action<object>(this.DeployDatabase), new Func<bool>(this.CanDeployDatabase));
			this.TestConnectionCommand = new RelayCommand(new Action<object>(this.TestConnection), new Func<bool>(this.CanTestConnection));
			this.ContinueLoginCommand = new RelayCommand(new Action<object>(this.ContinueLogin));
			this.ToggleSettingsCommand = new RelayCommand(new Action<object>(this.ToggleSettings));
		}

		// Token: 0x06004B40 RID: 19264 RVA: 0x00131C5C File Offset: 0x0012FE5C
		private void SetDefaults(object obj)
		{
			Settings.Default.Reset();
			string[] files = Directory.GetFiles("cfg\\", "*.xml");
			if (files.Any<string>())
			{
				foreach (string path in files)
				{
					try
					{
						File.Delete(path);
					}
					catch (Exception ex)
					{
						System.Windows.MessageBox.Show(ex.Message);
					}
				}
			}
			if (this.CloseAction != null)
			{
				this.CloseAction();
			}
		}

		// Token: 0x06004B41 RID: 19265 RVA: 0x00131CD8 File Offset: 0x0012FED8
		private void ToggleSettings(object obj)
		{
			this.SetLoadMsgText("");
			if (this.DefaultVisibility)
			{
				this.ShowSettings();
				return;
			}
			this.ShowDefault();
		}

		// Token: 0x06004B42 RID: 19266 RVA: 0x00131D08 File Offset: 0x0012FF08
		private void HideAll()
		{
			this.HideOfficeSelect();
			this.HideSettings();
			this.HideDefault();
		}

		// Token: 0x06004B43 RID: 19267 RVA: 0x00131D28 File Offset: 0x0012FF28
		private void HideOfficeSelect()
		{
			this.OfficesSelectVis = false;
		}

		// Token: 0x06004B44 RID: 19268 RVA: 0x00131D3C File Offset: 0x0012FF3C
		private void ShowOfficeSelect()
		{
			this.HideProgressbar();
			this.HideSettings();
			this.HideDefault();
			this.OfficesSelectVis = true;
		}

		// Token: 0x06004B45 RID: 19269 RVA: 0x00131D64 File Offset: 0x0012FF64
		private void HideSettings()
		{
			this.SettingsVisibility = false;
		}

		// Token: 0x06004B46 RID: 19270 RVA: 0x00131D78 File Offset: 0x0012FF78
		private void ShowSettings()
		{
			this.HideProgressbar();
			this.HideOfficeSelect();
			this.HideDefault();
			this.SettingsVisibility = true;
		}

		// Token: 0x06004B47 RID: 19271 RVA: 0x00131DA0 File Offset: 0x0012FFA0
		private void HideDefault()
		{
			this.DefaultVisibility = false;
		}

		// Token: 0x06004B48 RID: 19272 RVA: 0x00131DB4 File Offset: 0x0012FFB4
		private void ShowDefault()
		{
			this.HideProgressbar();
			this.HideOfficeSelect();
			this.HideSettings();
			this.DefaultVisibility = true;
		}

		// Token: 0x06004B49 RID: 19273 RVA: 0x00131DDC File Offset: 0x0012FFDC
		private void ShowProgressbar()
		{
			this.ProgressVisible = true;
			System.Windows.Application.Current.Dispatcher.Invoke(delegate()
			{
				RelayCommand loginBtnClickCommand = this.LoginBtnClickCommand;
				if (loginBtnClickCommand == null)
				{
					return;
				}
				loginBtnClickCommand.RaiseCanExecuteChanged();
			});
		}

		// Token: 0x06004B4A RID: 19274 RVA: 0x00131E0C File Offset: 0x0013000C
		private void HideProgressbar()
		{
			this.ProgressVisible = false;
			System.Windows.Application.Current.Dispatcher.Invoke(delegate()
			{
				RelayCommand loginBtnClickCommand = this.LoginBtnClickCommand;
				if (loginBtnClickCommand == null)
				{
					return;
				}
				loginBtnClickCommand.RaiseCanExecuteChanged();
			});
		}

		// Token: 0x06004B4B RID: 19275 RVA: 0x00131E3C File Offset: 0x0013003C
		private void ContinueLogin(object obj)
		{
			AuthModel.<ContinueLogin>d__122 <ContinueLogin>d__;
			<ContinueLogin>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<ContinueLogin>d__.<>4__this = this;
			<ContinueLogin>d__.<>1__state = -1;
			<ContinueLogin>d__.<>t__builder.Start<AuthModel.<ContinueLogin>d__122>(ref <ContinueLogin>d__);
		}

		// Token: 0x06004B4C RID: 19276 RVA: 0x00131E74 File Offset: 0x00130074
		private void SetProgress(double value)
		{
			this.ProgressValue = value;
		}

		// Token: 0x06004B4D RID: 19277 RVA: 0x00131E88 File Offset: 0x00130088
		private Task LoadUserCard()
		{
			AuthModel.<LoadUserCard>d__124 <LoadUserCard>d__;
			<LoadUserCard>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadUserCard>d__.<>4__this = this;
			<LoadUserCard>d__.<>1__state = -1;
			<LoadUserCard>d__.<>t__builder.Start<AuthModel.<LoadUserCard>d__124>(ref <LoadUserCard>d__);
			return <LoadUserCard>d__.<>t__builder.Task;
		}

		// Token: 0x06004B4E RID: 19278 RVA: 0x00131ECC File Offset: 0x001300CC
		private void UpdateUserOffice()
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					users users = auseceEntities.users.Include((users u) => u.kkt_employee).FirstOrDefault((users u) => u.id == this.User.id);
					if (users != null)
					{
						users.office = this.User.office;
						if (users.kkt_employee != null)
						{
							List<kkt_employee> source = users.kkt_employee.ToList<kkt_employee>();
							if (source.Any<kkt_employee>())
							{
								kkt_employee kkt_employee = source.FirstOrDefault((kkt_employee p) => p.office == this.User.office);
								if (kkt_employee != null)
								{
									users.kkt = new int?(kkt_employee.kkt);
								}
								else
								{
									users.kkt = null;
								}
							}
						}
						auseceEntities.SaveChanges();
					}
				}
			}
			catch (Exception)
			{
				System.Windows.MessageBox.Show("Update employee office fail");
			}
		}

		// Token: 0x06004B4F RID: 19279 RVA: 0x00132068 File Offset: 0x00130268
		private void ContinueLogin()
		{
			Auth.User = this.User;
			OfflineData.Instance.SetEmployee(this.User.User2Employee());
			this.LoadConfig();
			if (Auth.Config != null)
			{
				if (!this._bgLogin.IsBusy)
				{
					this._bgLogin.RunWorkerAsync();
				}
				return;
			}
		}

		// Token: 0x06004B50 RID: 19280 RVA: 0x001320BC File Offset: 0x001302BC
		private string GetConnectionString(string password)
		{
			string password2 = Generators.HashPassword(password);
			return new MySqlConnectionStringBuilder
			{
				UserID = this.Username,
				Password = password2,
				Port = AuthModel.Port,
				Server = AuthModel.Host,
				Database = AuthModel.DbName,
				CharacterSet = "utf8",
				ConnectionProtocol = MySqlConnectionProtocol.Sockets,
				SslMode = MySqlSslMode.Preferred,
				UseCompression = true
			}.GetConnectionString(true);
		}

		// Token: 0x06004B51 RID: 19281 RVA: 0x00132130 File Offset: 0x00130330
		private void LoginBtnClick(object obj)
		{
			PasswordBox passwordBox = obj as PasswordBox;
			if (passwordBox != null)
			{
				string password = passwordBox.Password;
				this.LogIn(password);
			}
		}

		// Token: 0x06004B52 RID: 19282 RVA: 0x00132158 File Offset: 0x00130358
		private bool CanLoginBtnClick()
		{
			return !this.ProgressVisible;
		}

		// Token: 0x06004B53 RID: 19283 RVA: 0x00132170 File Offset: 0x00130370
		private void DeployDatabase(object obj)
		{
			AuthModel.<DeployDatabase>d__130 <DeployDatabase>d__;
			<DeployDatabase>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<DeployDatabase>d__.<>4__this = this;
			<DeployDatabase>d__.obj = obj;
			<DeployDatabase>d__.<>1__state = -1;
			<DeployDatabase>d__.<>t__builder.Start<AuthModel.<DeployDatabase>d__130>(ref <DeployDatabase>d__);
		}

		// Token: 0x06004B54 RID: 19284 RVA: 0x001321B0 File Offset: 0x001303B0
		private void DeployOnDeployStepChanged(object sender, string e)
		{
			this.SetLoadMsgText(e);
		}

		// Token: 0x06004B55 RID: 19285 RVA: 0x001321C4 File Offset: 0x001303C4
		private bool CanDeployDatabase()
		{
			return this.FirstRun;
		}

		// Token: 0x06004B56 RID: 19286 RVA: 0x001321D8 File Offset: 0x001303D8
		public void LogIn(string password)
		{
			AuthModel.<LogIn>d__133 <LogIn>d__;
			<LogIn>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LogIn>d__.<>4__this = this;
			<LogIn>d__.password = password;
			<LogIn>d__.<>1__state = -1;
			<LogIn>d__.<>t__builder.Start<AuthModel.<LogIn>d__133>(ref <LogIn>d__);
		}

		// Token: 0x06004B57 RID: 19287 RVA: 0x00132218 File Offset: 0x00130418
		private bool CheckConnection(string password)
		{
			bool result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					auseceEntities.Database.Connection.ConnectionString = this.GetConnectionString(password);
					auseceEntities.Database.CommandTimeout = new int?(this.CommandTimeout);
					auseceEntities.Database.Connection.Open();
				}
				return true;
			}
			catch (MySqlException ex)
			{
				this.ShowDefault();
				if (ex.Message.Contains("Access denied"))
				{
					this.SetLoadMsgText((string)System.Windows.Application.Current.TryFindResource("AuthMsg"));
					result = false;
				}
				else
				{
					if (ex.InnerException == null)
					{
						System.Windows.MessageBox.Show(ex.Message, "Ошибка соединения", MessageBoxButton.OK, MessageBoxImage.Hand);
					}
					else
					{
						System.Windows.MessageBox.Show(ex.InnerException.Message, "Ошибка соединения", MessageBoxButton.OK, MessageBoxImage.Hand);
					}
					result = false;
				}
			}
			catch (Exception ex2)
			{
				this.ShowDefault();
				System.Windows.MessageBox.Show(ex2.Message);
				result = false;
			}
			return result;
		}

		// Token: 0x06004B58 RID: 19288 RVA: 0x0013232C File Offset: 0x0013052C
		private void InitializeAutoUpdater()
		{
			try
			{
				AutoUpdater.Initialize(AuthModel.GetUpdatePath(), Assembly.GetExecutingAssembly().GetName().Version.ToString());
				AutoUpdater.Instance.NewUpdate += this.InstanceOnNewUpdate;
				AutoUpdater.Instance.DownloadProgressChanged += this.InstanceOnDownloadProgressChanged;
				AutoUpdater.Instance.DownloadCompleted += this.InstanceOnDownloadCompleted;
				AutoUpdater.Instance.NoUpdates += this.InstanceOnNoUpdates;
			}
			catch (Exception ex)
			{
				System.Windows.MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06004B59 RID: 19289 RVA: 0x001323D0 File Offset: 0x001305D0
		public static string GetUpdatePath()
		{
			Version version = Assembly.GetExecutingAssembly().GetName().Version;
			if (!AuthModel.IsDev())
			{
				return string.Format("https://nbuk1.ru/asc/config-from-{0}.json", version.Revision);
			}
			return string.Format("https://nbuk1.ru/asc/dev-from-{0}.json", version.Revision);
		}

		// Token: 0x06004B5A RID: 19290 RVA: 0x00132420 File Offset: 0x00130620
		public static bool IsDev()
		{
			return AuthModel.IsEven(Assembly.GetExecutingAssembly().GetName().Version.Build);
		}

		// Token: 0x06004B5B RID: 19291 RVA: 0x00132448 File Offset: 0x00130648
		private static bool IsEven(int a)
		{
			return a % 2 == 0;
		}

		// Token: 0x06004B5C RID: 19292 RVA: 0x0013245C File Offset: 0x0013065C
		private void InstanceOnNoUpdates(object sender, EventArgs e)
		{
			System.Windows.MessageBox.Show("There are no updates");
			AutoUpdater.Instance.Reject();
			AutoUpdater.Instance.Stop();
		}

		// Token: 0x06004B5D RID: 19293 RVA: 0x00132488 File Offset: 0x00130688
		private void InstanceOnDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			this.ShowProgressbar();
			this.ProgressValue = (double)e.ProgressPercentage;
		}

		// Token: 0x06004B5E RID: 19294 RVA: 0x001324A8 File Offset: 0x001306A8
		private void InstanceOnDownloadCompleted(object sender, EventArgs e)
		{
			AutoUpdater.Instance.UpdateView();
		}

		// Token: 0x06004B5F RID: 19295 RVA: 0x0008A2BC File Offset: 0x000884BC
		private void InstanceOnNewUpdate(object sender, EventArgs e)
		{
			AutoUpdater.Instance.Accept();
		}

		// Token: 0x06004B60 RID: 19296 RVA: 0x001324C0 File Offset: 0x001306C0
		private bool IsActualVersionOfAsc()
		{
			bool result;
			try
			{
				string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
				string versionFromDb = this.GetVersionFromDb();
				Version version2 = new Version(version);
				Version version3 = new Version(versionFromDb);
				if (version2 > version3)
				{
					System.Windows.MessageBox.Show((string)System.Windows.Application.Current.TryFindResource("VersionError"));
				}
				result = (version3 == version2);
			}
			catch (Exception)
			{
				System.Windows.MessageBox.Show("Actuallity detect fail, true returned");
				result = true;
			}
			return result;
		}

		// Token: 0x06004B61 RID: 19297 RVA: 0x00132544 File Offset: 0x00130744
		private string GetVersionFromDb()
		{
			string result;
			try
			{
				using (MySqlConnection mySqlConnection = new MySqlConnection(AuthModel.CnnString))
				{
					mySqlConnection.Open();
					using (MySqlCommand mySqlCommand = new MySqlCommand("SELECT version FROM config WHERE id=1;", mySqlConnection))
					{
						using (MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader())
						{
							StringBuilder stringBuilder = new StringBuilder();
							while (mySqlDataReader.Read())
							{
								stringBuilder.Append(mySqlDataReader.GetString(0));
							}
							result = stringBuilder.ToString();
						}
					}
				}
			}
			catch (Exception)
			{
				System.Windows.MessageBox.Show("Get version from db fail");
				result = "";
			}
			return result;
		}

		// Token: 0x06004B62 RID: 19298 RVA: 0x00132608 File Offset: 0x00130808
		private UpgradeEngine GetUpgrader()
		{
			return DeployChanges.To.MySqlDatabase(AuthModel.CnnString).WithExecutionTimeout(new TimeSpan?(TimeSpan.FromHours(2.0))).WithTransactionPerScript().WithScriptsEmbeddedInAssembly(Assembly.Load("ASC.Migrations")).LogToAutodetectedLog().LogToConsole().Build();
		}

		// Token: 0x06004B63 RID: 19299 RVA: 0x00132660 File Offset: 0x00130860
		private Task<bool> UpdateDbIfNeeded(UpgradeEngine upgrader)
		{
			AuthModel.<UpdateDbIfNeeded>d__146 <UpdateDbIfNeeded>d__;
			<UpdateDbIfNeeded>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<UpdateDbIfNeeded>d__.<>4__this = this;
			<UpdateDbIfNeeded>d__.upgrader = upgrader;
			<UpdateDbIfNeeded>d__.<>1__state = -1;
			<UpdateDbIfNeeded>d__.<>t__builder.Start<AuthModel.<UpdateDbIfNeeded>d__146>(ref <UpdateDbIfNeeded>d__);
			return <UpdateDbIfNeeded>d__.<>t__builder.Task;
		}

		// Token: 0x06004B64 RID: 19300 RVA: 0x001326AC File Offset: 0x001308AC
		private void BackupModelOnBackupTick(object sender, ExportProgressArgs e)
		{
			double value = (double)e.CurrentRowIndexInAllTables / (double)e.TotalRowsInAllTables * 100.0;
			System.Windows.Application.Current.Dispatcher.Invoke(delegate()
			{
				this.ProgressValue = Math.Abs(value);
			});
		}

		// Token: 0x06004B65 RID: 19301 RVA: 0x00132700 File Offset: 0x00130900
		private void SetLoadMsgText(string text)
		{
			System.Windows.Application.Current.Dispatcher.Invoke(delegate()
			{
				this.LoadMsg = text;
			});
		}

		// Token: 0x06004B66 RID: 19302 RVA: 0x0013273C File Offset: 0x0013093C
		private void BgLoginOnRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.HideProgressbar();
			this.HideAction();
			WorkspaceV2View workspaceV2View = new WorkspaceV2View();
			try
			{
				workspaceV2View.Show();
			}
			catch (Exception ex)
			{
				System.Windows.MessageBox.Show(ex.Message);
				System.Windows.Application.Current.Shutdown();
			}
		}

		// Token: 0x06004B67 RID: 19303 RVA: 0x00132790 File Offset: 0x00130990
		private void BgLoginOnDoWork(object sender, DoWorkEventArgs e)
		{
			this._bgLogin.ReportProgress(10);
			this.SetLoadMsgText("Core init...");
			Core instance = Core.Instance;
			this._bgLogin.ReportProgress(30);
			this.SetLoadMsgText(Lang.t("ApplyingUserSettings"));
			Thread.Sleep(200);
			ApplicationThemeHelper.ApplicationThemeName = "Office2013DarkGray";
			this._bgLogin.ReportProgress(40);
			this.SetLoadMsgText(Lang.t("CachingPermissions"));
			OfflineData.Instance.Employee.Can(20, 0);
			this._bgLogin.ReportProgress(41);
			OfflineData.Instance.Employee.Can(15, 0);
			this._bgLogin.ReportProgress(42);
			OfflineData.Instance.Employee.Can(7, 0);
			this._bgLogin.ReportProgress(43);
			OfflineData.Instance.Employee.Can(12, 0);
			this._bgLogin.ReportProgress(44);
			OfflineData.Instance.Employee.Can(2, 0);
			this._bgLogin.ReportProgress(45);
			OfflineData.Instance.Employee.Can(16, 0);
			this._bgLogin.ReportProgress(60);
			this.SetLoadMsgText("Last login save...");
			this.SaveLastUsername();
			this._userActivityService.UserLogin(Auth.User.id);
			this._bgLogin.ReportProgress(80);
			this.SetLoadMsgText(Lang.t("CurrencyInit"));
			Thread.Sleep(200);
			AuthModel.InitCurrency();
			this._bgLogin.ReportProgress(90);
			this.SetLoadMsgText("");
			this._bgLogin.ReportProgress(100);
		}

		// Token: 0x06004B68 RID: 19304 RVA: 0x00132940 File Offset: 0x00130B40
		private static void InitCurrency()
		{
			if (!string.IsNullOrEmpty(Auth.Config.currency))
			{
				Auth.CurrencyModel = new Currency(Auth.Config.currency);
			}
		}

		// Token: 0x06004B69 RID: 19305 RVA: 0x00132974 File Offset: 0x00130B74
		private void LoadConfig()
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(false))
				{
					Auth.Config = auseceEntities.config.FirstOrDefault((config c) => c.id == 1);
					this._configGetTry = 0;
				}
			}
			catch (Exception ex)
			{
				if (this._configGetTry >= 5)
				{
					System.Windows.MessageBox.Show("Load config from DB fail " + ex.Message);
				}
				else
				{
					this._configGetTry++;
					this.LoadConfig();
				}
			}
		}

		// Token: 0x06004B6A RID: 19306 RVA: 0x00132A54 File Offset: 0x00130C54
		public void TestConnection(object obj)
		{
			PasswordBox passwordBox = obj as PasswordBox;
			if (passwordBox != null)
			{
				IAscResult ascResult = this.TestConnection(passwordBox.Password, true);
				if (!ascResult.IsSucces)
				{
					System.Windows.MessageBox.Show(ascResult.Message);
				}
				else if (System.Windows.MessageBox.Show((string)System.Windows.Application.Current.TryFindResource("SaveSettingsQuestion"), "Успешное соединение", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
				{
					this.SaveServerCnn();
					this.SaveLastUsername();
					this.ShowSettings();
					return;
				}
			}
		}

		// Token: 0x06004B6B RID: 19307 RVA: 0x00132AC8 File Offset: 0x00130CC8
		private bool CanTestConnection()
		{
			return !this.FirstRun;
		}

		// Token: 0x06004B6C RID: 19308 RVA: 0x00132AE0 File Offset: 0x00130CE0
		private IAscResult TestConnection(string password, bool setDbName = true)
		{
			Result result = new Result();
			IAscResult result2;
			using (auseceEntities auseceEntities = new auseceEntities(true))
			{
				string text = (!this.FirstRun) ? Generators.HashPassword(password) : password;
				auseceEntities.Database.Connection.ConnectionString = (setDbName ? string.Format("Server={0}; Port={1}; database={2}; UID={3}; password={4}; Charset=utf8;", new object[]
				{
					AuthModel.Host,
					AuthModel.Port,
					AuthModel.DbName,
					this.Username,
					text
				}) : string.Format("Server={0}; Port={1}; UID={2}; password={3}; Charset=utf8;", new object[]
				{
					AuthModel.Host,
					AuthModel.Port,
					this.Username,
					text
				}));
				try
				{
					auseceEntities.Database.Connection.Open();
					result.SetSuccess();
					return result;
				}
				catch (Exception ex)
				{
					result.Message = ex.Message;
					result2 = result;
				}
			}
			return result2;
		}

		// Token: 0x06004B6D RID: 19309 RVA: 0x00132BE4 File Offset: 0x00130DE4
		private void SaveServerCnn()
		{
			Settings.Default.dbHost = AuthModel.Host;
			Settings.Default.dbPort = AuthModel.Port;
			Settings.Default.dbName = AuthModel.DbName;
		}

		// Token: 0x06004B6E RID: 19310 RVA: 0x00132C20 File Offset: 0x00130E20
		private void SaveLastUsername()
		{
			Settings.Default.lastLogin = this.Username;
			Settings.Default.Save();
		}

		// Token: 0x06004B6F RID: 19311 RVA: 0x00132C48 File Offset: 0x00130E48
		public void LogOut()
		{
			System.Windows.Application.Current.Shutdown();
		}

		// Token: 0x06004B70 RID: 19312 RVA: 0x00132C60 File Offset: 0x00130E60
		[CompilerGenerated]
		private void <ShowProgressbar>b__120_0()
		{
			RelayCommand loginBtnClickCommand = this.LoginBtnClickCommand;
			if (loginBtnClickCommand == null)
			{
				return;
			}
			loginBtnClickCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x06004B71 RID: 19313 RVA: 0x00132C60 File Offset: 0x00130E60
		[CompilerGenerated]
		private void <HideProgressbar>b__121_0()
		{
			RelayCommand loginBtnClickCommand = this.LoginBtnClickCommand;
			if (loginBtnClickCommand == null)
			{
				return;
			}
			loginBtnClickCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x06004B72 RID: 19314 RVA: 0x00132C80 File Offset: 0x00130E80
		[CompilerGenerated]
		private void <ContinueLogin>b__122_0()
		{
			this.SetProgress(2.0);
			Thread.Sleep(100);
			this.UpdateUserOffice();
			this.SetProgress(8.0);
		}

		// Token: 0x06004B73 RID: 19315 RVA: 0x00132CB8 File Offset: 0x00130EB8
		[CompilerGenerated]
		private bool <UpdateUserOffice>b__125_2(kkt_employee p)
		{
			return p.office == this.User.office;
		}

		// Token: 0x06004B74 RID: 19316 RVA: 0x00132CD8 File Offset: 0x00130ED8
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

		// Token: 0x0400306A RID: 12394
		private readonly IEmployeeService _employeeService;

		// Token: 0x0400306B RID: 12395
		private readonly IUserActivityService _userActivityService;

		// Token: 0x0400306C RID: 12396
		[CompilerGenerated]
		private PropertyChangedEventHandler PropertyChanged;

		// Token: 0x0400306D RID: 12397
		private int CommandTimeout = 10;

		// Token: 0x0400306E RID: 12398
		private int _configGetTry;

		// Token: 0x0400306F RID: 12399
		private BackgroundWorker _bgLogin = new BackgroundWorker
		{
			WorkerReportsProgress = true
		};

		// Token: 0x04003070 RID: 12400
		private string _language = Settings.Default.language;

		// Token: 0x04003071 RID: 12401
		private bool _capslockActive = System.Windows.Forms.Control.IsKeyLocked(Keys.Capital);

		// Token: 0x04003072 RID: 12402
		private bool _firstRun;

		// Token: 0x04003073 RID: 12403
		[CompilerGenerated]
		private Action <HideAction>k__BackingField;

		// Token: 0x04003074 RID: 12404
		[CompilerGenerated]
		private Action <CloseAction>k__BackingField;

		// Token: 0x04003075 RID: 12405
		public static string CnnString;

		// Token: 0x04003076 RID: 12406
		private readonly ISeedData _seedDataService;

		// Token: 0x04003077 RID: 12407
		[CompilerGenerated]
		private string <AssemblyVersion>k__BackingField;

		// Token: 0x04003078 RID: 12408
		[CompilerGenerated]
		private List<IdNameClass> <Offices>k__BackingField;

		// Token: 0x04003079 RID: 12409
		[CompilerGenerated]
		private users <User>k__BackingField;

		// Token: 0x0400307A RID: 12410
		[CompilerGenerated]
		private ICommand <SetDefaultsCommand>k__BackingField;

		// Token: 0x0400307B RID: 12411
		[CompilerGenerated]
		private RelayCommand <LoginBtnClickCommand>k__BackingField;

		// Token: 0x0400307C RID: 12412
		[CompilerGenerated]
		private RelayCommand <TestConnectionCommand>k__BackingField;

		// Token: 0x0400307D RID: 12413
		[CompilerGenerated]
		private RelayCommand <DeployDatabaseCommand>k__BackingField;

		// Token: 0x0400307E RID: 12414
		[CompilerGenerated]
		private ICommand <ContinueLoginCommand>k__BackingField;

		// Token: 0x0400307F RID: 12415
		[CompilerGenerated]
		private ICommand <ToggleSettingsCommand>k__BackingField;

		// Token: 0x04003080 RID: 12416
		[CompilerGenerated]
		private static string <Host>k__BackingField;

		// Token: 0x04003081 RID: 12417
		[CompilerGenerated]
		private static uint <Port>k__BackingField;

		// Token: 0x04003082 RID: 12418
		[CompilerGenerated]
		private static string <DbName>k__BackingField;

		// Token: 0x04003083 RID: 12419
		[CompilerGenerated]
		private string <Username>k__BackingField;

		// Token: 0x04003084 RID: 12420
		[CompilerGenerated]
		private bool <SettingsVisibility>k__BackingField;

		// Token: 0x04003085 RID: 12421
		[CompilerGenerated]
		private bool <DefaultVisibility>k__BackingField;

		// Token: 0x04003086 RID: 12422
		[CompilerGenerated]
		private bool <OfficesSelectVis>k__BackingField;

		// Token: 0x04003087 RID: 12423
		[CompilerGenerated]
		private bool <ProgressVisible>k__BackingField;

		// Token: 0x04003088 RID: 12424
		[CompilerGenerated]
		private double <ProgressValue>k__BackingField;

		// Token: 0x04003089 RID: 12425
		[CompilerGenerated]
		private string <LoadMsg>k__BackingField;

		// Token: 0x020009D5 RID: 2517
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ContinueLogin>d__122 : IAsyncStateMachine
		{
			// Token: 0x06004B75 RID: 19317 RVA: 0x00132CFC File Offset: 0x00130EFC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AuthModel authModel = this.<>4__this;
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
							goto IL_DA;
						}
						authModel.HideAll();
						authModel.ShowProgressbar();
						awaiter = Task.Run(delegate()
						{
							base.SetProgress(2.0);
							Thread.Sleep(100);
							base.UpdateUserOffice();
							base.SetProgress(8.0);
						}).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, AuthModel.<ContinueLogin>d__122>(ref awaiter, ref this);
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
					awaiter = authModel.LoadUserCard().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, AuthModel.<ContinueLogin>d__122>(ref awaiter, ref this);
						return;
					}
					IL_DA:
					awaiter.GetResult();
					authModel.ContinueLogin();
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

			// Token: 0x06004B76 RID: 19318 RVA: 0x00132E2C File Offset: 0x0013102C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400308A RID: 12426
			public int <>1__state;

			// Token: 0x0400308B RID: 12427
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400308C RID: 12428
			public AuthModel <>4__this;

			// Token: 0x0400308D RID: 12429
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020009D6 RID: 2518
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadUserCard>d__124 : IAsyncStateMachine
		{
			// Token: 0x06004B77 RID: 19319 RVA: 0x00132E48 File Offset: 0x00131048
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AuthModel authModel = this.<>4__this;
				try
				{
					TaskAwaiter<users> awaiter;
					if (num != 0)
					{
						awaiter = authModel._employeeService.GetEmployeeAsync(authModel.Username).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<users>, AuthModel.<LoadUserCard>d__124>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<users>);
						this.<>1__state = -1;
					}
					users result = awaiter.GetResult();
					authModel.User = result;
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

			// Token: 0x06004B78 RID: 19320 RVA: 0x00132F10 File Offset: 0x00131110
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400308E RID: 12430
			public int <>1__state;

			// Token: 0x0400308F RID: 12431
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04003090 RID: 12432
			public AuthModel <>4__this;

			// Token: 0x04003091 RID: 12433
			private TaskAwaiter<users> <>u__1;
		}

		// Token: 0x020009D7 RID: 2519
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004B79 RID: 19321 RVA: 0x00132F2C File Offset: 0x0013112C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004B7A RID: 19322 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06004B7B RID: 19323 RVA: 0x00132F44 File Offset: 0x00131144
			internal void <LogIn>b__133_0()
			{
				Thread.Sleep(200);
			}

			// Token: 0x06004B7C RID: 19324 RVA: 0x00132F5C File Offset: 0x0013115C
			internal string <UpdateDbIfNeeded>b__146_2(SqlScript i)
			{
				return i.Name;
			}

			// Token: 0x04003092 RID: 12434
			public static readonly AuthModel.<>c <>9 = new AuthModel.<>c();

			// Token: 0x04003093 RID: 12435
			public static Action <>9__133_0;

			// Token: 0x04003094 RID: 12436
			public static Func<SqlScript, string> <>9__146_2;
		}

		// Token: 0x020009D8 RID: 2520
		[CompilerGenerated]
		private sealed class <>c__DisplayClass130_0
		{
			// Token: 0x06004B7D RID: 19325 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass130_0()
			{
			}

			// Token: 0x06004B7E RID: 19326 RVA: 0x00132F70 File Offset: 0x00131170
			internal IAscResult <DeployDatabase>b__0()
			{
				return this.deploy.Deploy(this.password, AuthModel.DbName);
			}

			// Token: 0x04003095 RID: 12437
			public string password;

			// Token: 0x04003096 RID: 12438
			public DeployDatabaseModel deploy;
		}

		// Token: 0x020009D9 RID: 2521
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <DeployDatabase>d__130 : IAsyncStateMachine
		{
			// Token: 0x06004B7F RID: 19327 RVA: 0x00132F94 File Offset: 0x00131194
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AuthModel authModel = this.<>4__this;
				try
				{
					TaskAwaiter<IAscResult> awaiter;
					if (num != 0)
					{
						PasswordBox passwordBox = this.obj as PasswordBox;
						if (passwordBox == null)
						{
							goto IL_145;
						}
						AuthModel.<>c__DisplayClass130_0 CS$<>8__locals1 = new AuthModel.<>c__DisplayClass130_0();
						CS$<>8__locals1.password = passwordBox.Password;
						IAscResult ascResult = authModel.TestConnection(CS$<>8__locals1.password, false);
						if (!ascResult.IsSucces)
						{
							System.Windows.MessageBox.Show(ascResult.Message);
							goto IL_145;
						}
						CS$<>8__locals1.deploy = new DeployDatabaseModel(AuthModel.Host, AuthModel.Port, authModel.Username);
						CS$<>8__locals1.deploy.DeployStepChanged += authModel.DeployOnDeployStepChanged;
						authModel.HideSettings();
						authModel.ShowProgressbar();
						awaiter = Task.Run<IAscResult>(new Func<IAscResult>(CS$<>8__locals1.<DeployDatabase>b__0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IAscResult>, AuthModel.<DeployDatabase>d__130>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IAscResult>);
						this.<>1__state = -1;
					}
					IAscResult result = awaiter.GetResult();
					if (!result.IsSucces)
					{
						System.Windows.MessageBox.Show(result.Message);
						authModel.ShowSettings();
					}
					else
					{
						authModel.SaveServerCnn();
						authModel.Username = "admin";
						authModel.LogIn("123456");
					}
					IL_145:;
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

			// Token: 0x06004B80 RID: 19328 RVA: 0x00133130 File Offset: 0x00131330
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003097 RID: 12439
			public int <>1__state;

			// Token: 0x04003098 RID: 12440
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04003099 RID: 12441
			public object obj;

			// Token: 0x0400309A RID: 12442
			public AuthModel <>4__this;

			// Token: 0x0400309B RID: 12443
			private TaskAwaiter<IAscResult> <>u__1;
		}

		// Token: 0x020009DA RID: 2522
		[CompilerGenerated]
		private sealed class <>c__DisplayClass133_0
		{
			// Token: 0x06004B81 RID: 19329 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass133_0()
			{
			}

			// Token: 0x06004B82 RID: 19330 RVA: 0x0013314C File Offset: 0x0013134C
			internal bool <LogIn>b__1()
			{
				return this.<>4__this.CheckConnection(this.password);
			}

			// Token: 0x0400309C RID: 12444
			public AuthModel <>4__this;

			// Token: 0x0400309D RID: 12445
			public string password;
		}

		// Token: 0x020009DB RID: 2523
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LogIn>d__133 : IAsyncStateMachine
		{
			// Token: 0x06004B83 RID: 19331 RVA: 0x0013316C File Offset: 0x0013136C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AuthModel authModel = this.<>4__this;
				try
				{
					TaskAwaiter<bool> awaiter;
					TaskAwaiter awaiter2;
					TaskAwaiter<int> awaiter3;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<bool>);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_193;
					case 2:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<bool>);
						this.<>1__state = -1;
						goto IL_243;
					case 3:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_2AB;
					case 4:
						awaiter3 = this.<>u__3;
						this.<>u__3 = default(TaskAwaiter<int>);
						this.<>1__state = -1;
						goto IL_388;
					default:
						this.<>8__1 = new AuthModel.<>c__DisplayClass133_0();
						this.<>8__1.<>4__this = this.<>4__this;
						this.<>8__1.password = this.password;
						authModel.SetLoadMsgText((string)System.Windows.Application.Current.TryFindResource("Authentication") + "...");
						authModel.HideAll();
						awaiter = Task.Run<bool>(new Func<bool>(this.<>8__1.<LogIn>b__1)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, AuthModel.<LogIn>d__133>(ref awaiter, ref this);
							return;
						}
						break;
					}
					if (!awaiter.GetResult())
					{
						goto IL_3DE;
					}
					authModel.ShowProgressbar();
					authModel.SetLoadMsgText((string)System.Windows.Application.Current.TryFindResource("Initialization") + "...");
					awaiter2 = Task.Run(new Action(AuthModel.<>c.<>9.<LogIn>b__133_0)).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, AuthModel.<LogIn>d__133>(ref awaiter2, ref this);
						return;
					}
					IL_193:
					awaiter2.GetResult();
					AuthModel.CnnString = authModel.GetConnectionString(this.<>8__1.password);
					UpgradeEngine upgrader = authModel.GetUpgrader();
					bool flag = authModel._employeeService.EmployeeCan(authModel.Username, 1);
					if (upgrader.IsUpgradeRequired() && !flag)
					{
						authModel.SetLoadMsgText("You do not have permission to update");
						authModel.ShowDefault();
						goto IL_3DE;
					}
					awaiter = authModel.UpdateDbIfNeeded(upgrader).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, AuthModel.<LogIn>d__133>(ref awaiter, ref this);
						return;
					}
					IL_243:
					bool result = awaiter.GetResult();
					this.<updateOk>5__2 = result;
					awaiter2 = authModel.LoadUserCard().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, AuthModel.<LogIn>d__133>(ref awaiter2, ref this);
						return;
					}
					IL_2AB:
					awaiter2.GetResult();
					if (authModel.User == null)
					{
						authModel.SetLoadMsgText("");
						System.Windows.MessageBox.Show("Load user card fail");
						goto IL_3DE;
					}
					if (!authModel.IsActualVersionOfAsc())
					{
						authModel.InitializeAutoUpdater();
						goto IL_3DE;
					}
					if (!this.<updateOk>5__2)
					{
						authModel.SetLoadMsgText("");
						authModel.ShowDefault();
						goto IL_3DE;
					}
					if (!authModel.User.User2Employee().Can(59, authModel.User.id))
					{
						goto IL_3B6;
					}
					awaiter3 = Bootstrapper.Container.Resolve<IOfficeService>().CountActiveOfficesAsync().GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 4;
						this.<>u__3 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, AuthModel.<LogIn>d__133>(ref awaiter3, ref this);
						return;
					}
					IL_388:
					if (awaiter3.GetResult() > 1)
					{
						authModel.Offices = new List<IdNameClass>(OfficesModel.LoadOffices(false));
						authModel.SetLoadMsgText("");
						authModel.ShowOfficeSelect();
						goto IL_3DE;
					}
					IL_3B6:
					authModel.ContinueLogin();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_3DE:
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06004B84 RID: 19332 RVA: 0x00133590 File Offset: 0x00131790
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400309E RID: 12446
			public int <>1__state;

			// Token: 0x0400309F RID: 12447
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040030A0 RID: 12448
			public AuthModel <>4__this;

			// Token: 0x040030A1 RID: 12449
			public string password;

			// Token: 0x040030A2 RID: 12450
			private AuthModel.<>c__DisplayClass133_0 <>8__1;

			// Token: 0x040030A3 RID: 12451
			private bool <updateOk>5__2;

			// Token: 0x040030A4 RID: 12452
			private TaskAwaiter<bool> <>u__1;

			// Token: 0x040030A5 RID: 12453
			private TaskAwaiter <>u__2;

			// Token: 0x040030A6 RID: 12454
			private TaskAwaiter<int> <>u__3;
		}

		// Token: 0x020009DC RID: 2524
		[CompilerGenerated]
		private sealed class <>c__DisplayClass146_0
		{
			// Token: 0x06004B85 RID: 19333 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass146_0()
			{
			}

			// Token: 0x06004B86 RID: 19334 RVA: 0x001335AC File Offset: 0x001317AC
			internal void <UpdateDbIfNeeded>b__0()
			{
				BackupModel backupModel = new BackupModel();
				backupModel.BackupTick += this.<>4__this.BackupModelOnBackupTick;
				backupModel.Backup(true);
			}

			// Token: 0x040030A7 RID: 12455
			public AuthModel <>4__this;

			// Token: 0x040030A8 RID: 12456
			public UpgradeEngine upgrader;
		}

		// Token: 0x020009DD RID: 2525
		[CompilerGenerated]
		private sealed class <>c__DisplayClass146_1
		{
			// Token: 0x06004B87 RID: 19335 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass146_1()
			{
			}

			// Token: 0x06004B88 RID: 19336 RVA: 0x001335DC File Offset: 0x001317DC
			internal void <UpdateDbIfNeeded>b__1()
			{
				this.result = this.CS$<>8__locals1.upgrader.PerformUpgrade();
				Thread.Sleep(1000);
			}

			// Token: 0x040030A9 RID: 12457
			public DatabaseUpgradeResult result;

			// Token: 0x040030AA RID: 12458
			public AuthModel.<>c__DisplayClass146_0 CS$<>8__locals1;
		}

		// Token: 0x020009DE RID: 2526
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateDbIfNeeded>d__146 : IAsyncStateMachine
		{
			// Token: 0x06004B89 RID: 19337 RVA: 0x0013360C File Offset: 0x0013180C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AuthModel authModel = this.<>4__this;
				bool result;
				try
				{
					AuthModel.<>c__DisplayClass146_0 CS$<>8__locals1;
					if (num > 2)
					{
						CS$<>8__locals1 = new AuthModel.<>c__DisplayClass146_0();
						CS$<>8__locals1.<>4__this = this.<>4__this;
						CS$<>8__locals1.upgrader = this.upgrader;
					}
					try
					{
						TaskAwaiter awaiter;
						switch (num)
						{
						case 0:
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							this.<>1__state = -1;
							break;
						case 1:
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							this.<>1__state = -1;
							goto IL_193;
						case 2:
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							this.<>1__state = -1;
							goto IL_27F;
						default:
							this.<>8__1 = new AuthModel.<>c__DisplayClass146_1();
							this.<>8__1.CS$<>8__locals1 = CS$<>8__locals1;
							if (!this.<>8__1.CS$<>8__locals1.upgrader.IsUpgradeRequired())
							{
								result = true;
								goto IL_2BD;
							}
							authModel.ShowProgressbar();
							authModel.SetLoadMsgText((string)System.Windows.Application.Current.TryFindResource("BackupBeforeUpdate") + "...");
							awaiter = Task.Run(new Action(this.<>8__1.CS$<>8__locals1.<UpdateDbIfNeeded>b__0)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, AuthModel.<UpdateDbIfNeeded>d__146>(ref awaiter, ref this);
								return;
							}
							break;
						}
						awaiter.GetResult();
						authModel.SetLoadMsgText("DB update in progress...");
						this.<>8__1.result = null;
						awaiter = Task.Run(new Action(this.<>8__1.<UpdateDbIfNeeded>b__1)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 1;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, AuthModel.<UpdateDbIfNeeded>d__146>(ref awaiter, ref this);
							return;
						}
						IL_193:
						awaiter.GetResult();
						authModel.HideProgressbar();
						authModel.SetLoadMsgText("");
						if (!this.<>8__1.result.Successful)
						{
							System.Windows.MessageBox.Show(this.<>8__1.result.Error.Message);
							result = false;
							goto IL_2BD;
						}
						authModel.SetLoadMsgText("Seed data...");
						awaiter = authModel._seedDataService.Seed(this.<>8__1.result.Scripts.Select(new Func<SqlScript, string>(AuthModel.<>c.<>9.<UpdateDbIfNeeded>b__146_2)).ToList<string>()).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 2;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, AuthModel.<UpdateDbIfNeeded>d__146>(ref awaiter, ref this);
							return;
						}
						IL_27F:
						awaiter.GetResult();
						authModel.SetLoadMsgText("Update completed, loading...");
						result = true;
					}
					catch (Exception ex)
					{
						System.Windows.MessageBox.Show(ex.Message);
						result = false;
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_2BD:
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06004B8A RID: 19338 RVA: 0x00133920 File Offset: 0x00131B20
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040030AB RID: 12459
			public int <>1__state;

			// Token: 0x040030AC RID: 12460
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x040030AD RID: 12461
			public AuthModel <>4__this;

			// Token: 0x040030AE RID: 12462
			public UpgradeEngine upgrader;

			// Token: 0x040030AF RID: 12463
			private AuthModel.<>c__DisplayClass146_1 <>8__1;

			// Token: 0x040030B0 RID: 12464
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020009DF RID: 2527
		[CompilerGenerated]
		private sealed class <>c__DisplayClass147_0
		{
			// Token: 0x06004B8B RID: 19339 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass147_0()
			{
			}

			// Token: 0x06004B8C RID: 19340 RVA: 0x0013393C File Offset: 0x00131B3C
			internal void <BackupModelOnBackupTick>b__0()
			{
				this.<>4__this.ProgressValue = Math.Abs(this.value);
			}

			// Token: 0x040030B1 RID: 12465
			public AuthModel <>4__this;

			// Token: 0x040030B2 RID: 12466
			public double value;
		}

		// Token: 0x020009E0 RID: 2528
		[CompilerGenerated]
		private sealed class <>c__DisplayClass148_0
		{
			// Token: 0x06004B8D RID: 19341 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass148_0()
			{
			}

			// Token: 0x06004B8E RID: 19342 RVA: 0x00133960 File Offset: 0x00131B60
			internal void <SetLoadMsgText>b__0()
			{
				this.<>4__this.LoadMsg = this.text;
			}

			// Token: 0x040030B3 RID: 12467
			public AuthModel <>4__this;

			// Token: 0x040030B4 RID: 12468
			public string text;
		}
	}
}
