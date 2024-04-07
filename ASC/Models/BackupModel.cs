using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using ASC.Properties;
using DevExpress.Xpf.Core;
using MySql.Data.MySqlClient;
using NLog;

namespace ASC.Models
{
	// Token: 0x02000969 RID: 2409
	public class BackupModel
	{
		// Token: 0x1700144E RID: 5198
		// (get) Token: 0x06004976 RID: 18806 RVA: 0x00121D78 File Offset: 0x0011FF78
		// (set) Token: 0x06004977 RID: 18807 RVA: 0x00121D8C File Offset: 0x0011FF8C
		public virtual long TotalRows
		{
			[CompilerGenerated]
			get
			{
				return this.<TotalRows>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<TotalRows>k__BackingField = value;
			}
		} = 1L;

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06004978 RID: 18808 RVA: 0x00121DA0 File Offset: 0x0011FFA0
		// (remove) Token: 0x06004979 RID: 18809 RVA: 0x00121DDC File Offset: 0x0011FFDC
		public event MySqlBackup.exportProgressChange BackupTick
		{
			[CompilerGenerated]
			add
			{
				MySqlBackup.exportProgressChange exportProgressChange = this.BackupTick;
				MySqlBackup.exportProgressChange exportProgressChange2;
				do
				{
					exportProgressChange2 = exportProgressChange;
					MySqlBackup.exportProgressChange value2 = (MySqlBackup.exportProgressChange)Delegate.Combine(exportProgressChange2, value);
					exportProgressChange = Interlocked.CompareExchange<MySqlBackup.exportProgressChange>(ref this.BackupTick, value2, exportProgressChange2);
				}
				while (exportProgressChange != exportProgressChange2);
			}
			[CompilerGenerated]
			remove
			{
				MySqlBackup.exportProgressChange exportProgressChange = this.BackupTick;
				MySqlBackup.exportProgressChange exportProgressChange2;
				do
				{
					exportProgressChange2 = exportProgressChange;
					MySqlBackup.exportProgressChange value2 = (MySqlBackup.exportProgressChange)Delegate.Remove(exportProgressChange2, value);
					exportProgressChange = Interlocked.CompareExchange<MySqlBackup.exportProgressChange>(ref this.BackupTick, value2, exportProgressChange2);
				}
				while (exportProgressChange != exportProgressChange2);
			}
		}

		// Token: 0x0600497A RID: 18810 RVA: 0x00121E18 File Offset: 0x00120018
		public List<string> GetDocumentHeaders()
		{
			return new List<string>
			{
				"/*!40101 SET @OLD_CHARACTER_SET_CLIENT= 'utf8' */;",
				"/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;",
				"/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;",
				"/*!40101 SET NAMES utf8 */;",
				"/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;",
				"/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;",
				"/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;",
				"/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;"
			};
		}

		// Token: 0x0600497B RID: 18811 RVA: 0x00121E84 File Offset: 0x00120084
		public bool Backup(bool excludePhotos)
		{
			bool result;
			try
			{
				string text = Settings.Default.BackupPath;
				if (string.IsNullOrEmpty(text))
				{
					text = Path.Combine(MediaModel.GetAppDir(), "Backup");
					Directory.CreateDirectory(text);
				}
				string path = DateTime.Now.Year.ToString();
				Directory.CreateDirectory(Path.Combine(text, path));
				string path2 = DateTime.Now.Month.ToString();
				string text2 = Path.Combine(text, path, path2);
				Directory.CreateDirectory(text2);
				string path3 = string.Format("{0:dd-HH-mm}.sql", DateTime.Now);
				string connectionString = Auth.CnnString + ";convertzerodatetime=true;";
				string filePath = Path.Combine(text2, path3);
				using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
				{
					using (MySqlCommand mySqlCommand = new MySqlCommand())
					{
						using (MySqlBackup mySqlBackup = new MySqlBackup(mySqlCommand))
						{
							mySqlCommand.Connection = mySqlConnection;
							mySqlBackup.Command.CommandTimeout = 0;
							mySqlBackup.ExportInfo.SetDocumentHeaders(this.GetDocumentHeaders());
							mySqlConnection.Open();
							if (excludePhotos)
							{
								mySqlBackup.ExportInfo.ExcludeTables = new List<string>
								{
									"images"
								};
							}
							mySqlBackup.Database.GetDatabaseInfo(mySqlCommand, true);
							mySqlBackup.ExportProgressChanged += this.MbOnExportProgressChanged;
							this.TotalRows = mySqlBackup.Database.TotalRows;
							mySqlBackup.ExportToFile(filePath);
							mySqlConnection.Close();
							if (this.CancellBackup)
							{
								this.CancellBackup = false;
								Application.Current.Dispatcher.Invoke<MessageBoxResult>(() => DXMessageBox.Show((string)Application.Current.TryFindResource("Stopped")));
								result = false;
							}
							else
							{
								result = true;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				result = false;
			}
			return result;
		}

		// Token: 0x0600497C RID: 18812 RVA: 0x001220C4 File Offset: 0x001202C4
		public virtual void MbOnExportProgressChanged(object sender, ExportProgressArgs e)
		{
			if (this.BackupTick != null)
			{
				this.BackupTick(sender, e);
			}
		}

		// Token: 0x0600497D RID: 18813 RVA: 0x001220E8 File Offset: 0x001202E8
		public static bool RestoreUsers()
		{
			bool result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					foreach (users users in (from u in auseceEntities.users
					where u.is_bot == false && u.state == (int?)1 && u.username != "admin"
					select u).ToList<users>())
					{
						try
						{
							auseceEntities.add_User(users.username, "123456", AuthModel.DbName);
						}
						catch (Exception exception)
						{
							BackupModel.Log.Error(exception, "Create user while import fail");
						}
					}
				}
				return true;
			}
			catch (Exception exception2)
			{
				BackupModel.Log.Error(exception2, "Load users for restore operations fail");
				result = false;
			}
			return result;
		}

		// Token: 0x0600497E RID: 18814 RVA: 0x001222BC File Offset: 0x001204BC
		public static int LastWorkshopId()
		{
			int result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					result = (from r in auseceEntities.workshop
					orderby r.id descending
					select r.id).FirstOrDefault<int>() + 1;
				}
			}
			catch (Exception ex)
			{
				ILogger log = BackupModel.Log;
				string str = "Get last repair id error ";
				Exception ex2 = ex;
				log.Error(str + ((ex2 != null) ? ex2.ToString() : null));
				result = 1;
			}
			return result;
		}

		// Token: 0x0600497F RID: 18815 RVA: 0x001223AC File Offset: 0x001205AC
		public static bool SetWorkshopAutoIncrement(int count)
		{
			bool result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					auseceEntities.Database.ExecuteSqlCommand("ALTER TABLE workshop AUTO_INCREMENT={0};", new object[]
					{
						count
					});
					result = true;
				}
			}
			catch (Exception ex)
			{
				ILogger log = BackupModel.Log;
				string str = "Update workshop AUTO_INCREMENT error ";
				Exception ex2 = ex;
				log.Error(str + ((ex2 != null) ? ex2.ToString() : null));
				result = false;
			}
			return result;
		}

		// Token: 0x06004980 RID: 18816 RVA: 0x00122434 File Offset: 0x00120634
		public BackupModel()
		{
		}

		// Token: 0x06004981 RID: 18817 RVA: 0x00122458 File Offset: 0x00120658
		// Note: this type is marked as 'beforefieldinit'.
		static BackupModel()
		{
		}

		// Token: 0x04002ECA RID: 11978
		public static readonly ILogger Log = LogManager.GetCurrentClassLogger();

		// Token: 0x04002ECB RID: 11979
		public bool CancellBackup;

		// Token: 0x04002ECC RID: 11980
		[CompilerGenerated]
		private long <TotalRows>k__BackingField;

		// Token: 0x04002ECD RID: 11981
		[CompilerGenerated]
		private MySqlBackup.exportProgressChange BackupTick;

		// Token: 0x0200096A RID: 2410
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004982 RID: 18818 RVA: 0x00122470 File Offset: 0x00120670
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004983 RID: 18819 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06004984 RID: 18820 RVA: 0x00122488 File Offset: 0x00120688
			internal MessageBoxResult <Backup>b__10_0()
			{
				return DXMessageBox.Show((string)Application.Current.TryFindResource("Stopped"));
			}

			// Token: 0x04002ECE RID: 11982
			public static readonly BackupModel.<>c <>9 = new BackupModel.<>c();

			// Token: 0x04002ECF RID: 11983
			public static Func<MessageBoxResult> <>9__10_0;
		}
	}
}
