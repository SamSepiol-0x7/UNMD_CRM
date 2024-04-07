using System;
using System.Runtime.CompilerServices;

namespace ASC.ViewModels
{
	// Token: 0x020003C9 RID: 969
	public class LicenseExpirationViewModel : PopupViewModel, ILicenseExpirationViewModel
	{
		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x06002821 RID: 10273 RVA: 0x0007C068 File Offset: 0x0007A268
		// (set) Token: 0x06002822 RID: 10274 RVA: 0x0007C07C File Offset: 0x0007A27C
		public string Text
		{
			[CompilerGenerated]
			get
			{
				return this.<Text>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (string.Equals(this.<Text>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Text>k__BackingField = value;
				this.RaisePropertyChanged("Text");
			}
		}

		// Token: 0x17000D9E RID: 3486
		// (get) Token: 0x06002823 RID: 10275 RVA: 0x0007C0AC File Offset: 0x0007A2AC
		// (set) Token: 0x06002824 RID: 10276 RVA: 0x0007C0C0 File Offset: 0x0007A2C0
		public int ExpireDays
		{
			[CompilerGenerated]
			get
			{
				return this.<ExpireDays>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<ExpireDays>k__BackingField == value)
				{
					return;
				}
				this.<ExpireDays>k__BackingField = value;
				this.RaisePropertyChanged("ExpireDays");
			}
		}

		// Token: 0x17000D9F RID: 3487
		// (get) Token: 0x06002825 RID: 10277 RVA: 0x0007C0EC File Offset: 0x0007A2EC
		// (set) Token: 0x06002826 RID: 10278 RVA: 0x0007C100 File Offset: 0x0007A300
		public bool ExpireDaysVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<ExpireDaysVisible>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<ExpireDaysVisible>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = 186937586;
				IL_10:
				switch ((num ^ 147319016) % 4)
				{
				case 0:
					goto IL_0B;
				case 1:
					IL_2F:
					this.<ExpireDaysVisible>k__BackingField = value;
					this.RaisePropertyChanged("ExpireDaysVisible");
					num = 1424739747;
					goto IL_10;
				case 2:
					return;
				}
			}
		}

		// Token: 0x06002827 RID: 10279 RVA: 0x0007C158 File Offset: 0x0007A358
		public LicenseExpirationViewModel()
		{
			this.ExpireDaysVisible = true;
			base.SetTitle("Срок действия лицензии истекает");
			this.Text = "До окончания лицензии дней";
		}

		// Token: 0x06002828 RID: 10280 RVA: 0x0007C188 File Offset: 0x0007A388
		public void SetExpireDays(int value)
		{
			if (value < 0)
			{
				throw new ArgumentException();
			}
			this.ExpireDays = value;
		}

		// Token: 0x06002829 RID: 10281 RVA: 0x0007C1A8 File Offset: 0x0007A3A8
		public void SetLicenseExpired()
		{
			this.ExpireDaysVisible = false;
			base.SetTitle("Срок действия лицензии истёк");
			this.Text = "Приобрести ключ можно на сайте asccrm.ru";
		}

		// Token: 0x040015F8 RID: 5624
		[CompilerGenerated]
		private string <Text>k__BackingField;

		// Token: 0x040015F9 RID: 5625
		[CompilerGenerated]
		private int <ExpireDays>k__BackingField;

		// Token: 0x040015FA RID: 5626
		[CompilerGenerated]
		private bool <ExpireDaysVisible>k__BackingField;
	}
}
