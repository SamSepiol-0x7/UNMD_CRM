using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Xml.Linq;
using ASC.Common.Interfaces;
using ASC.Extensions;
using ASC.Objects;
using ASC.Services.Abstract;
using ASC.ViewModels;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.About
{
	// Token: 0x02000C00 RID: 3072
	public class AboutViewModel : BaseViewModel
	{
		// Token: 0x170015AD RID: 5549
		// (get) Token: 0x06005509 RID: 21769 RVA: 0x0016DF74 File Offset: 0x0016C174
		// (set) Token: 0x0600550A RID: 21770 RVA: 0x0016DF88 File Offset: 0x0016C188
		public string AboutText
		{
			[CompilerGenerated]
			get
			{
				return this.<AboutText>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (string.Equals(this.<AboutText>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<AboutText>k__BackingField = value;
				this.RaisePropertyChanged("AboutText");
			}
		}

		// Token: 0x170015AE RID: 5550
		// (get) Token: 0x0600550B RID: 21771 RVA: 0x0016DFB8 File Offset: 0x0016C1B8
		// (set) Token: 0x0600550C RID: 21772 RVA: 0x0016DFCC File Offset: 0x0016C1CC
		public string License
		{
			[CompilerGenerated]
			get
			{
				return this.<License>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<License>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<License>k__BackingField = value;
				this.RaisePropertyChanged("License");
			}
		}

		// Token: 0x170015AF RID: 5551
		// (get) Token: 0x0600550D RID: 21773 RVA: 0x0016DFFC File Offset: 0x0016C1FC
		// (set) Token: 0x0600550E RID: 21774 RVA: 0x0016E010 File Offset: 0x0016C210
		public bool LicenseExist
		{
			[CompilerGenerated]
			get
			{
				return this.<LicenseExist>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<LicenseExist>k__BackingField == value)
				{
					return;
				}
				this.<LicenseExist>k__BackingField = value;
				this.RaisePropertyChanged("LicenseExist");
			}
		}

		// Token: 0x170015B0 RID: 5552
		// (get) Token: 0x0600550F RID: 21775 RVA: 0x0016E03C File Offset: 0x0016C23C
		// (set) Token: 0x06005510 RID: 21776 RVA: 0x0016E050 File Offset: 0x0016C250
		public bool ShowInputDialog
		{
			[CompilerGenerated]
			get
			{
				return this.<ShowInputDialog>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ShowInputDialog>k__BackingField == value)
				{
					return;
				}
				this.<ShowInputDialog>k__BackingField = value;
				this.RaisePropertyChanged("ShowInputDialog");
			}
		}

		// Token: 0x170015B1 RID: 5553
		// (get) Token: 0x06005511 RID: 21777 RVA: 0x0016E07C File Offset: 0x0016C27C
		// (set) Token: 0x06005512 RID: 21778 RVA: 0x0016E090 File Offset: 0x0016C290
		public bool ShowLicenseInfo
		{
			[CompilerGenerated]
			get
			{
				return this.<ShowLicenseInfo>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ShowLicenseInfo>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = 1718815335;
				IL_10:
				switch ((num ^ 1019987026) % 4)
				{
				case 0:
					IL_2F:
					num = 2021513512;
					goto IL_10;
				case 1:
					return;
				case 3:
					goto IL_0B;
				}
				this.<ShowLicenseInfo>k__BackingField = value;
				this.RaisePropertyChanged("ShowLicenseInfo");
			}
		}

		// Token: 0x170015B2 RID: 5554
		// (get) Token: 0x06005513 RID: 21779 RVA: 0x0016E0E8 File Offset: 0x0016C2E8
		// (set) Token: 0x06005514 RID: 21780 RVA: 0x0016E0FC File Offset: 0x0016C2FC
		public DateTime Expiration
		{
			[CompilerGenerated]
			get
			{
				return this.<Expiration>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (DateTime.Equals(this.<Expiration>k__BackingField, value))
				{
					return;
				}
				this.<Expiration>k__BackingField = value;
				this.RaisePropertyChanged("Expiration");
			}
		}

		// Token: 0x170015B3 RID: 5555
		// (get) Token: 0x06005515 RID: 21781 RVA: 0x0016E12C File Offset: 0x0016C32C
		// (set) Token: 0x06005516 RID: 21782 RVA: 0x0016E140 File Offset: 0x0016C340
		public string Owner
		{
			[CompilerGenerated]
			get
			{
				return this.<Owner>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Owner>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Owner>k__BackingField = value;
				this.RaisePropertyChanged("Owner");
			}
		}

		// Token: 0x170015B4 RID: 5556
		// (get) Token: 0x06005517 RID: 21783 RVA: 0x0016E170 File Offset: 0x0016C370
		// (set) Token: 0x06005518 RID: 21784 RVA: 0x0016E184 File Offset: 0x0016C384
		public string Email
		{
			[CompilerGenerated]
			get
			{
				return this.<Email>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Email>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Email>k__BackingField = value;
				this.RaisePropertyChanged("Email");
			}
		}

		// Token: 0x170015B5 RID: 5557
		// (get) Token: 0x06005519 RID: 21785 RVA: 0x0016E1B4 File Offset: 0x0016C3B4
		public Brush ExpirationColor
		{
			get
			{
				if (this._isValid != null)
				{
					goto IL_50;
				}
				IL_1C:
				int num = -759708803;
				IL_21:
				switch ((num ^ -275430817) % 5)
				{
				case 0:
					goto IL_1C;
				case 1:
					IL_50:
					num = (this._isValid.Value ? -416700107 : -4762359);
					goto IL_21;
				case 3:
					return Brushes.Black;
				case 4:
					return Brushes.DarkRed;
				}
				return Brushes.DarkGreen;
			}
		}

		// Token: 0x0600551A RID: 21786 RVA: 0x0016E234 File Offset: 0x0016C434
		public AboutViewModel(IToasterService toasterService, IAscMessageBoxService ascMessageBoxService, IWindowedDocumentService windowedDocumentService)
		{
			this.ShowLicenseInfo = true;
			this._toasterService = toasterService;
			this._ascMessageBoxService = ascMessageBoxService;
			this._windowedDocumentService = windowedDocumentService;
			string text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
			this.AboutText = string.Concat(new string[]
			{
				"Программа для автоматизации",
				Environment.NewLine,
				"сервисных центров",
				Environment.NewLine,
				"Версия: ",
				text,
				" ",
				Environment.NewLine,
				"© 2024 Ассоциация сервисных центров. Нежадная версия от мистера 'K' :)",
				Environment.NewLine,
				"P.S. привет Vik-On и Vik-Off,я так и не научился различать",
				Environment.NewLine,
				"P.P.S. прога по максимуму почищена от обфускаторов, разбирайте на здоровье :)"
			});
			if (!string.IsNullOrEmpty(Auth.Config.key))
			{
				this.LicenseExist = true;
				XElement xelement = XElement.Parse(Auth.Config.key.Base64Decode());
				this.Expiration = (DateTime)xelement.Element("Expiration");
				XElement xelement2 = xelement.Element("Customer");
				if (xelement2 != null)
				{
					XElement xelement3 = xelement2.Element("Name");
					string owner;
					if (xelement3 == null || (owner = xelement3.Value) == null)
					{
						owner = "";
					}
					this.Owner = owner;
					XElement xelement4 = xelement2.Element("Email");
					string email;
					if (xelement4 == null || (email = xelement4.Value) == null)
					{
						email = "";
					}
					this.Email = email;
					return;
				}
				XElement xelement5 = xelement.Element("ProductFeatures");
				if (xelement5 != null)
				{
					string[] array = (from item in xelement5.Elements("Feature")
					select item.Value).ToArray<string>();
					this.Owner = array[1] + " " + array[0];
					this.Email = array[2];
					return;
				}
			}
			else
			{
				this.ShowLicenseInfo = false;
				this.ShowInputDialog = true;
			}
		}

		// Token: 0x0600551B RID: 21787 RVA: 0x0016E434 File Offset: 0x0016C634
		[Command]
		public void Back()
		{
			this.ShowInputDialog = false;
			this.ShowLicenseInfo = true;
		}

		// Token: 0x0600551C RID: 21788 RVA: 0x0016E450 File Offset: 0x0016C650
		public bool CanBack()
		{
			return !string.IsNullOrEmpty(Auth.Config.key);
		}

		// Token: 0x0600551D RID: 21789 RVA: 0x0016E470 File Offset: 0x0016C670
		[Command]
		public void ShowChangeLicense()
		{
			this.ShowInputDialog = true;
			this.ShowLicenseInfo = false;
		}

		// Token: 0x0600551E RID: 21790 RVA: 0x000B3CFC File Offset: 0x000B1EFC
		public bool CanShowChangeLicense()
		{
			return OfflineData.Instance.Employee.Can(1, 0);
		}

		// Token: 0x0600551F RID: 21791 RVA: 0x0016E48C File Offset: 0x0016C68C
		[Command]
		public void CheckLicense()
		{
			AboutViewModel.<CheckLicense>d__43 <CheckLicense>d__;
			<CheckLicense>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<CheckLicense>d__.<>4__this = this;
			<CheckLicense>d__.<>1__state = -1;
			<CheckLicense>d__.<>t__builder.Start<AboutViewModel.<CheckLicense>d__43>(ref <CheckLicense>d__);
		}

		// Token: 0x06005520 RID: 21792 RVA: 0x000B3CFC File Offset: 0x000B1EFC
		public bool CanCheckLicense()
		{
			return OfflineData.Instance.Employee.Can(1, 0);
		}

		// Token: 0x06005521 RID: 21793 RVA: 0x0016E4C4 File Offset: 0x0016C6C4
		[Command]
		public void Close()
		{
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x06005522 RID: 21794 RVA: 0x0016E4DC File Offset: 0x0016C6DC
		[Command]
		public void Loaded()
		{
			this._isValid = new bool?(Core.Instance.IsValid());
			base.RaisePropertyChanged<Brush>(() => this.ExpirationColor);
		}

		// Token: 0x040037FF RID: 14335
		[CompilerGenerated]
		private string <AboutText>k__BackingField;

		// Token: 0x04003800 RID: 14336
		[CompilerGenerated]
		private string <License>k__BackingField;

		// Token: 0x04003801 RID: 14337
		[CompilerGenerated]
		private bool <LicenseExist>k__BackingField;

		// Token: 0x04003802 RID: 14338
		[CompilerGenerated]
		private bool <ShowInputDialog>k__BackingField;

		// Token: 0x04003803 RID: 14339
		[CompilerGenerated]
		private bool <ShowLicenseInfo>k__BackingField;

		// Token: 0x04003804 RID: 14340
		[CompilerGenerated]
		private DateTime <Expiration>k__BackingField;

		// Token: 0x04003805 RID: 14341
		[CompilerGenerated]
		private string <Owner>k__BackingField;

		// Token: 0x04003806 RID: 14342
		[CompilerGenerated]
		private string <Email>k__BackingField;

		// Token: 0x04003807 RID: 14343
		private bool? _isValid;

		// Token: 0x04003808 RID: 14344
		private readonly IToasterService _toasterService;

		// Token: 0x04003809 RID: 14345
		private readonly IAscMessageBoxService _ascMessageBoxService;

		// Token: 0x0400380A RID: 14346
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x02000C01 RID: 3073
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005523 RID: 21795 RVA: 0x0016E534 File Offset: 0x0016C734
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06005524 RID: 21796 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06005525 RID: 21797 RVA: 0x0016E54C File Offset: 0x0016C74C
			internal string <.ctor>b__38_0(XElement item)
			{
				return item.Value;
			}

			// Token: 0x0400380B RID: 14347
			public static readonly AboutViewModel.<>c <>9 = new AboutViewModel.<>c();

			// Token: 0x0400380C RID: 14348
			public static Func<XElement, string> <>9__38_0;
		}

		// Token: 0x02000C02 RID: 3074
		[CompilerGenerated]
		private sealed class <>c__DisplayClass43_0
		{
			// Token: 0x06005526 RID: 21798 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass43_0()
			{
			}

			// Token: 0x06005527 RID: 21799 RVA: 0x0016E560 File Offset: 0x0016C760
			internal IAscResult <CheckLicense>b__0()
			{
				return this.sl.method_1(this.license);
			}

			// Token: 0x0400380D RID: 14349
			public GClass0 sl;

			// Token: 0x0400380E RID: 14350
			public string license;
		}

		// Token: 0x02000C03 RID: 3075
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CheckLicense>d__43 : IAsyncStateMachine
		{
			// Token: 0x06005528 RID: 21800 RVA: 0x0016E580 File Offset: 0x0016C780
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AboutViewModel aboutViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IAscResult> awaiter;
					if (num != 0)
					{
						this.<>8__1 = new AboutViewModel.<>c__DisplayClass43_0();
						if (string.IsNullOrEmpty(aboutViewModel.License))
						{
							aboutViewModel._toasterService.Info(Lang.t("InputLicense"));
							goto IL_237;
						}
						this.<>8__1.license = aboutViewModel.License.Trim();
						aboutViewModel.ShowWait();
						this.<>8__1.sl = new GClass0();
						awaiter = Task.Run<IAscResult>(new Func<IAscResult>(this.<>8__1.<CheckLicense>b__0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.<>1__state = num2;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IAscResult>, AboutViewModel.<CheckLicense>d__43>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IAscResult>);
						int num3 = -1;
						num = -1;
						this.<>1__state = num3;
					}
					IAscResult result = awaiter.GetResult();
					if (result.IsSucces)
					{
						try
						{
							try
							{
								auseceEntities auseceEntities = new auseceEntities(true);
								try
								{
									config config = auseceEntities.config.FirstOrDefault((config c) => c.id == Auth.Config.id);
									string key = this.<>8__1.license.Base64Encode();
									if (config != null)
									{
										config.key = key;
										auseceEntities.SaveChanges();
										Auth.Config = config;
										aboutViewModel.HideWait();
										aboutViewModel._ascMessageBoxService.ShowMessageBox(Lang.t("LicenseAccepted"));
										aboutViewModel.Back();
									}
								}
								finally
								{
									if (num < 0 && auseceEntities != null)
									{
										((IDisposable)auseceEntities).Dispose();
									}
								}
							}
							catch (Exception ex)
							{
								aboutViewModel._toasterService.Error(ex.Message);
							}
							goto IL_215;
						}
						finally
						{
							if (num < 0)
							{
								aboutViewModel.HideWait();
							}
						}
					}
					aboutViewModel.HideWait();
					aboutViewModel._ascMessageBoxService.ShowMessageBox(Lang.t("LicenseNotValid"), result.Message);
					IL_215:;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_237:
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06005529 RID: 21801 RVA: 0x0016E844 File Offset: 0x0016CA44
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400380F RID: 14351
			public int <>1__state;

			// Token: 0x04003810 RID: 14352
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04003811 RID: 14353
			public AboutViewModel <>4__this;

			// Token: 0x04003812 RID: 14354
			private AboutViewModel.<>c__DisplayClass43_0 <>8__1;

			// Token: 0x04003813 RID: 14355
			private TaskAwaiter<IAscResult> <>u__1;
		}

		// Token: 0x02000C04 RID: 3076
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c__0
		{
			// Token: 0x0600552A RID: 21802 RVA: 0x00002065 File Offset: 0x00000265
			// Note: this type is marked as 'beforefieldinit'.
			static <>c__0()
			{
			}

			// Token: 0x0600552B RID: 21803 RVA: 0x00002071 File Offset: 0x00000271
			public <>c__0()
			{
			}

			// Token: 0x0600552C RID: 21804 RVA: 0x00002079 File Offset: 0x00000279
			internal string <.ctor>b__0_0(XElement item)
			{
				return item.Value;
			}

			// Token: 0x04003814 RID: 14356
			public static readonly AboutViewModel.<>c__0 <>9 = new AboutViewModel.<>c__0();

			// Token: 0x04003815 RID: 14357
			public static Func<XElement, string> <>9__0_0;
		}

		// Token: 0x02000C05 RID: 3077
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c__1
		{
			// Token: 0x0600552D RID: 21805 RVA: 0x00002081 File Offset: 0x00000281
			// Note: this type is marked as 'beforefieldinit'.
			static <>c__1()
			{
			}

			// Token: 0x0600552E RID: 21806 RVA: 0x00002071 File Offset: 0x00000271
			public <>c__1()
			{
			}

			// Token: 0x0600552F RID: 21807 RVA: 0x00002079 File Offset: 0x00000279
			internal string <.ctor>b__0_0(XElement item)
			{
				return item.Value;
			}

			// Token: 0x04003816 RID: 14358
			public static readonly AboutViewModel.<>c__1 <>9 = new AboutViewModel.<>c__1();

			// Token: 0x04003817 RID: 14359
			public static Func<XElement, string> <>9__0_0;
		}

		// Token: 0x02000C06 RID: 3078
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c__2
		{
			// Token: 0x06005530 RID: 21808 RVA: 0x0000208D File Offset: 0x0000028D
			// Note: this type is marked as 'beforefieldinit'.
			static <>c__2()
			{
			}

			// Token: 0x06005531 RID: 21809 RVA: 0x00002071 File Offset: 0x00000271
			public <>c__2()
			{
			}

			// Token: 0x06005532 RID: 21810 RVA: 0x00002079 File Offset: 0x00000279
			internal string <.ctor>b__0_0(XElement item)
			{
				return item.Value;
			}

			// Token: 0x04003818 RID: 14360
			public static readonly AboutViewModel.<>c__2 <>9 = new AboutViewModel.<>c__2();

			// Token: 0x04003819 RID: 14361
			public static Func<XElement, string> <>9__0_0;
		}
	}
}
