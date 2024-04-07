using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Threading;
using NLog;
using NLog.Config;
using NLog.Targets;

namespace ASC
{
	// Token: 0x020000C3 RID: 195
	public partial class App : Application
	{
		// Token: 0x0600136B RID: 4971 RVA: 0x0002AF28 File Offset: 0x00029128
		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);
			Bootstrapper.BuildContainer();
			App.ConfigureLogger();
			this._logger = LogManager.GetCurrentClassLogger();
			AppDomain.CurrentDomain.UnhandledException += this.AppDomainUnhandledException;
			base.Dispatcher.UnhandledException += this.OnDispatcherUnhandledException;
			Application.Current.DispatcherUnhandledException += this.Current_DispatcherUnhandledException;
		}

		// Token: 0x0600136C RID: 4972 RVA: 0x0002AF94 File Offset: 0x00029194
		private static void ConfigureLogger()
		{
			LoggingConfiguration loggingConfiguration = new LoggingConfiguration();
			FileTarget target = new FileTarget("logfile")
			{
				FileName = string.Format("logs/asc_{0:dd-MM-yyyy}.log", DateTime.Now.Date),
				Layout = "${longdate}|${level:uppercase=true}|${logger}|${threadid}|${message}|${exception:format=tostring}"
			};
			loggingConfiguration.AddRule(LogLevel.Debug, LogLevel.Fatal, target, "*");
			LogManager.Configuration = loggingConfiguration;
		}

		// Token: 0x0600136D RID: 4973 RVA: 0x0002B004 File Offset: 0x00029204
		private void Current_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
		{
			this._logger.Error<DispatcherUnhandledExceptionEventArgs>(e.Exception.Message, e);
			MessageBox.Show(e.Exception.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
			e.Handled = true;
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x0002B048 File Offset: 0x00029248
		private void OnDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
		{
			this._logger.Error<DispatcherUnhandledExceptionEventArgs>(e.Exception.Message, e);
			MessageBox.Show("Error: " + e.Exception.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Hand);
			e.Handled = true;
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x0002B098 File Offset: 0x00029298
		private void AppDomainUnhandledException(object sender, UnhandledExceptionEventArgs e)
		{
			Exception ex = e.ExceptionObject as Exception;
			string caption = e.IsTerminating ? " The application is terminating." : string.Empty;
			string text;
			if (ex != null)
			{
				if ((text = ex.Message) != null)
				{
					goto IL_35;
				}
			}
			text = "An unmanaged exception occured.";
			IL_35:
			string text2 = text;
			this._logger.Error<UnhandledExceptionEventArgs>(text2, e);
			MessageBox.Show(text2, caption);
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x0002B0F0 File Offset: 0x000292F0
		public static void SelectCulture(string culture)
		{
			try
			{
				if (!string.IsNullOrEmpty(culture))
				{
					if (culture == "ua-UA")
					{
						culture = "uk-UA";
					}
					App.ClearDictionaries();
					if (culture != "ru-RU")
					{
						string uriString = Path.Combine(new FileInfo(Assembly.GetEntryAssembly().Location).DirectoryName, "Lang\\" + culture + ".xaml");
						ResourceDictionary item = new ResourceDictionary
						{
							Source = new Uri(uriString, UriKind.Absolute)
						};
						Application.Current.Resources.MergedDictionaries.Add(item);
					}
					CultureInfo.DefaultThreadCurrentUICulture = (CultureInfo.DefaultThreadCurrentCulture = new CultureInfo(culture));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x0002B1B4 File Offset: 0x000293B4
		private static void ClearDictionaries()
		{
			foreach (ResourceDictionary item in (from d in Application.Current.Resources.MergedDictionaries.ToList<ResourceDictionary>()
			where d.Source.OriginalString.Contains("Lang") && !d.Source.OriginalString.Contains("ru-RU")
			select d).ToList<ResourceDictionary>())
			{
				Application.Current.Resources.MergedDictionaries.Remove(item);
			}
		}

		// Token: 0x0400095F RID: 2399
		private ILogger _logger;
	}
}
