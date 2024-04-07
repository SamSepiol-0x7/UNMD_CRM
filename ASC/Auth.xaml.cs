using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Markup;
using ASC.Models;
using Microsoft.Win32;

namespace ASC
{
	// Token: 0x020000C5 RID: 197
	public partial class Auth : Window
	{
		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06001378 RID: 4984 RVA: 0x0002B30C File Offset: 0x0002950C
		// (set) Token: 0x06001379 RID: 4985 RVA: 0x0002B320 File Offset: 0x00029520
		public AuthModel AuthModel { get; set; } = new AuthModel();

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x0600137A RID: 4986 RVA: 0x0002B334 File Offset: 0x00029534
		// (set) Token: 0x0600137B RID: 4987 RVA: 0x0002B348 File Offset: 0x00029548
		public static users User { get; set; }

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x0600137C RID: 4988 RVA: 0x0002B35C File Offset: 0x0002955C
		// (set) Token: 0x0600137D RID: 4989 RVA: 0x0002B370 File Offset: 0x00029570
		public static Currency CurrencyModel { get; set; }

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x0600137E RID: 4990 RVA: 0x0002B384 File Offset: 0x00029584
		// (set) Token: 0x0600137F RID: 4991 RVA: 0x0002B398 File Offset: 0x00029598
		public static config Config { get; set; }

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06001380 RID: 4992 RVA: 0x0002B3AC File Offset: 0x000295AC
		public static string CnnString
		{
			get
			{
				return AuthModel.CnnString;
			}
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06001381 RID: 4993 RVA: 0x0002B3C0 File Offset: 0x000295C0
		// (set) Token: 0x06001382 RID: 4994 RVA: 0x0002B3D4 File Offset: 0x000295D4
		public static int MaxUsers { get; private set; }

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06001383 RID: 4995 RVA: 0x0002B3E8 File Offset: 0x000295E8
		public static int DisplayMaxUsers
		{
			get
			{
				return Auth.MaxUsers - 1;
			}
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x0002B3FC File Offset: 0x000295FC
		public Auth()
		{
			if (!this.NetVersionOk())
			{
				if (System.Windows.MessageBox.Show("Download .Net Framework?", ".Net 4.5.2 or later required!", MessageBoxButton.YesNo, MessageBoxImage.Asterisk) == MessageBoxResult.Yes)
				{
					Process.Start("https://dotnet.microsoft.com/download/dotnet-framework-runtime");
				}
			}
			this.InitializeComponent();
			if (this.AuthModel.HideAction == null)
			{
				this.AuthModel.HideAction = new Action(base.Hide);
			}
			if (this.textBoxUsername.Text.Length > 0)
			{
				this.textBoxPassword.Focus();
			}
			this.AuthModel.CloseAction = new Action(base.Close);
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x0002B4A4 File Offset: 0x000296A4
		private bool NetVersionOk()
		{
			bool result;
			try
			{
				using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\v4\\Full\\"))
				{
					result = (Convert.ToInt32(registryKey.GetValue("Release")) >= 379893);
				}
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x0002B514 File Offset: 0x00029714
		private string GetPassword()
		{
			return this.textBoxPassword.Password;
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x0002B52C File Offset: 0x0002972C
		public void ClearPassword()
		{
			this.textBoxPassword.Clear();
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x0002B544 File Offset: 0x00029744
		private void textBoxPassword_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
		{
			if (e.Key == Key.Return)
			{
				this.AuthModel.LogIn(this.GetPassword());
			}
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x0002B56C File Offset: 0x0002976C
		private void imageClose_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			this.AuthModel.LogOut();
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x0002B584 File Offset: 0x00029784
		private void En_GotFocus(object sender, RoutedEventArgs e)
		{
			InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-US"));
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x0002B5A8 File Offset: 0x000297A8
		private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
		{
			this.AuthModel.CapslockActive = System.Windows.Forms.Control.IsKeyLocked(Keys.Capital);
		}
	}
}
