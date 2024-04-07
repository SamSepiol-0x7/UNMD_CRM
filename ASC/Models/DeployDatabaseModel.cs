using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using ASC.Common.Interfaces;
using ASC.Objects;
using ICSharpCode.SharpZipLib.Zip;
using MySql.Data.MySqlClient;

namespace ASC.Models
{
	// Token: 0x02000965 RID: 2405
	public class DeployDatabaseModel
	{
		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06004962 RID: 18786 RVA: 0x0012141C File Offset: 0x0011F61C
		// (remove) Token: 0x06004963 RID: 18787 RVA: 0x00121454 File Offset: 0x0011F654
		public event EventHandler<string> DeployStepChanged
		{
			[CompilerGenerated]
			add
			{
				EventHandler<string> eventHandler = this.DeployStepChanged;
				EventHandler<string> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<string> value2 = (EventHandler<string>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<string>>(ref this.DeployStepChanged, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<string> eventHandler = this.DeployStepChanged;
				EventHandler<string> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<string> value2 = (EventHandler<string>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<string>>(ref this.DeployStepChanged, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x06004964 RID: 18788 RVA: 0x0012148C File Offset: 0x0011F68C
		public DeployDatabaseModel(string host, uint port, string username)
		{
			this._host = host;
			this._port = port;
			this._username = username;
		}

		// Token: 0x06004965 RID: 18789 RVA: 0x001214B4 File Offset: 0x0011F6B4
		public IAscResult Deploy(string password, string newDbName)
		{
			Result result = new Result();
			this.OnDeployStepChanged("Extracting DB dump...");
			IAscResult ascResult = this.ExtractDatabeseDump();
			if (!ascResult.IsSucces)
			{
				return ascResult;
			}
			this.OnDeployStepChanged("Creating admin user...");
			IAscResult ascResult2 = this.CreateAdminUser(password);
			if (!ascResult2.IsSucces)
			{
				return ascResult2;
			}
			this.OnDeployStepChanged("Creating DB...");
			IAscResult ascResult3 = this.CreateDatabase(newDbName, password);
			if (!ascResult3.IsSucces)
			{
				return ascResult3;
			}
			this.OnDeployStepChanged("Importing DB dump...");
			IAscResult ascResult4 = this.ImportDump(password, newDbName);
			if (!ascResult4.IsSucces)
			{
				return ascResult4;
			}
			this.GarbageDelete();
			result.SetSuccess();
			return result;
		}

		// Token: 0x06004966 RID: 18790 RVA: 0x0012154C File Offset: 0x0011F74C
		private void GarbageDelete()
		{
			try
			{
				File.Delete("CleanDB/cleanASC.sql");
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06004967 RID: 18791 RVA: 0x00121578 File Offset: 0x0011F778
		private IAscResult ImportDump(string password, string newDbName)
		{
			Result result = new Result();
			try
			{
				using (MySqlConnection mySqlConnection = new MySqlConnection(string.Format("Server={0}; Port={1}; database={2}; UID={3}; password={4};Charset=utf8;", new object[]
				{
					this._host,
					this._port,
					newDbName,
					this._username,
					password
				}) + "convertzerodatetime=true;"))
				{
					using (MySqlCommand mySqlCommand = new MySqlCommand())
					{
						using (MySqlBackup mySqlBackup = new MySqlBackup(mySqlCommand))
						{
							mySqlCommand.Connection = mySqlConnection;
							mySqlBackup.Command.CommandTimeout = 0;
							mySqlConnection.Open();
							try
							{
								mySqlBackup.ImportFromFile("CleanDB/cleanASC.sql");
							}
							catch (Exception ex)
							{
								result.Message = ex.Message;
								return result;
							}
							mySqlConnection.Close();
							result.SetSuccess();
						}
					}
				}
			}
			catch (Exception ex2)
			{
				result.Message = ex2.Message;
			}
			return result;
		}

		// Token: 0x06004968 RID: 18792 RVA: 0x001216A4 File Offset: 0x0011F8A4
		private string GetConnectionString(string password)
		{
			return string.Format("Server={0}; Port={1}; UID={2}; password={3};Charset=utf8;", new object[]
			{
				this._host,
				this._port,
				this._username,
				password
			});
		}

		// Token: 0x06004969 RID: 18793 RVA: 0x001216E8 File Offset: 0x0011F8E8
		private IAscResult CreateDatabase(string dbName, string password)
		{
			Result result = new Result();
			try
			{
				using (MySqlConnection mySqlConnection = new MySqlConnection(this.GetConnectionString(password)))
				{
					mySqlConnection.Open();
					using (MySqlCommand mySqlCommand = new MySqlCommand("CREATE DATABASE IF NOT EXISTS `" + dbName + "`;", mySqlConnection))
					{
						mySqlCommand.ExecuteNonQuery();
					}
				}
				result.SetSuccess();
			}
			catch (Exception ex)
			{
				result.Message = ex.Message;
			}
			return result;
		}

		// Token: 0x0600496A RID: 18794 RVA: 0x00121784 File Offset: 0x0011F984
		private void OnDeployStepChanged(string msg)
		{
			if (this.DeployStepChanged != null)
			{
				this.DeployStepChanged(this, msg);
			}
		}

		// Token: 0x0600496B RID: 18795 RVA: 0x001217A8 File Offset: 0x0011F9A8
		private void DropUser(string password)
		{
			string str = "admin";
			try
			{
				using (MySqlConnection mySqlConnection = new MySqlConnection(this.GetConnectionString(password)))
				{
					mySqlConnection.Open();
					using (MySqlCommand mySqlCommand = new MySqlCommand("DROP USER '" + str + "'@'%';FLUSH PRIVILEGES;", mySqlConnection))
					{
						mySqlCommand.ExecuteNonQuery();
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600496C RID: 18796 RVA: 0x00121834 File Offset: 0x0011FA34
		private IAscResult CreateAdminUser(string password)
		{
			Result result = new Result();
			this.DropUser(password);
			try
			{
				using (MySqlConnection mySqlConnection = new MySqlConnection(this.GetConnectionString(password)))
				{
					mySqlConnection.Open();
					string text = "admin";
					string text2 = Generators.HashPassword("123456");
					using (MySqlCommand mySqlCommand = new MySqlCommand(string.Concat(new string[]
					{
						"CREATE USER '",
						text,
						"'@'%' IDENTIFIED BY '",
						text2,
						"';GRANT ALL ON *.* TO '",
						text,
						"'@'%' WITH GRANT OPTION;FLUSH PRIVILEGES;"
					}), mySqlConnection))
					{
						mySqlCommand.ExecuteNonQuery();
					}
				}
				result.SetSuccess();
			}
			catch (Exception ex)
			{
				result.Message = ex.Message;
			}
			return result;
		}

		// Token: 0x0600496D RID: 18797 RVA: 0x00121918 File Offset: 0x0011FB18
		private IAscResult ExtractDatabeseDump()
		{
			Result result = new Result();
			if (!File.Exists("CleanDB/asc-db.zip"))
			{
				result.Message = "Cannot find file";
				return result;
			}
			try
			{
				using (ZipInputStream zipInputStream = new ZipInputStream(File.OpenRead("CleanDB/asc-db.zip")))
				{
					ZipEntry nextEntry;
					while ((nextEntry = zipInputStream.GetNextEntry()) != null)
					{
						string directoryName = Path.GetDirectoryName(nextEntry.Name);
						string fileName = Path.GetFileName(nextEntry.Name);
						if (directoryName.Length > 0)
						{
							Directory.CreateDirectory(directoryName);
						}
						if (fileName != string.Empty)
						{
							using (FileStream fileStream = File.Create("CleanDB/" + nextEntry.Name))
							{
								byte[] array = new byte[2048];
								for (;;)
								{
									int num = zipInputStream.Read(array, 0, array.Length);
									if (num <= 0)
									{
										break;
									}
									fileStream.Write(array, 0, num);
								}
							}
						}
					}
				}
				result.SetSuccess();
			}
			catch (Exception ex)
			{
				result.Message = ex.Message;
			}
			return result;
		}

		// Token: 0x0600496E RID: 18798 RVA: 0x00121A3C File Offset: 0x0011FC3C
		private IAscResult DownloadDatabaseDump()
		{
			Result result = new Result();
			try
			{
				using (WebClient webClient = new WebClient())
				{
					webClient.DownloadFile("https://asccrm.ru/download/cleanASC.zip", "asc-db.zip");
				}
				result.SetSuccess();
			}
			catch (Exception ex)
			{
				result.Message = ex.Message;
			}
			return result;
		}

		// Token: 0x04002EBE RID: 11966
		private const string DumpUrl = "https://asccrm.ru/download/cleanASC.zip";

		// Token: 0x04002EBF RID: 11967
		private const string DumpZipFile = "asc-db.zip";

		// Token: 0x04002EC0 RID: 11968
		private readonly string _host;

		// Token: 0x04002EC1 RID: 11969
		private readonly uint _port;

		// Token: 0x04002EC2 RID: 11970
		private readonly string _username;

		// Token: 0x04002EC3 RID: 11971
		[CompilerGenerated]
		private EventHandler<string> DeployStepChanged;
	}
}
