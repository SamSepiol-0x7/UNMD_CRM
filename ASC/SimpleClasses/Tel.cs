using System;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;
using DevExpress.Mvvm;

namespace ASC.SimpleClasses
{
	// Token: 0x02000217 RID: 535
	public class Tel : BindableBase, IPhone
	{
		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06001C4C RID: 7244 RVA: 0x00053104 File Offset: 0x00051304
		// (set) Token: 0x06001C4D RID: 7245 RVA: 0x00053118 File Offset: 0x00051318
		public int Id
		{
			[CompilerGenerated]
			get
			{
				return this.<Id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Id>k__BackingField == value)
				{
					return;
				}
				this.<Id>k__BackingField = value;
				this.RaisePropertyChanged("Id");
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x06001C4E RID: 7246 RVA: 0x00053144 File Offset: 0x00051344
		// (set) Token: 0x06001C4F RID: 7247 RVA: 0x00053158 File Offset: 0x00051358
		public string Phone
		{
			[CompilerGenerated]
			get
			{
				return this.<Phone>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.<Phone>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = -501948826;
				IL_14:
				switch ((num ^ -1397417684) % 4)
				{
				case 0:
					goto IL_0F;
				case 1:
					IL_33:
					num = -55068777;
					goto IL_14;
				case 2:
					return;
				}
				this.<Phone>k__BackingField = value;
				this.RaisePropertyChanged("Phone");
			}
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x06001C50 RID: 7248 RVA: 0x000531B4 File Offset: 0x000513B4
		// (set) Token: 0x06001C51 RID: 7249 RVA: 0x000531C8 File Offset: 0x000513C8
		public string PhoneClean
		{
			[CompilerGenerated]
			get
			{
				return this.<PhoneClean>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.<PhoneClean>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = 1842798509;
				IL_14:
				switch ((num ^ 309703032) % 4)
				{
				case 0:
					IL_33:
					this.<PhoneClean>k__BackingField = value;
					this.RaisePropertyChanged("PhoneClean");
					num = 566500566;
					goto IL_14;
				case 1:
					return;
				case 3:
					goto IL_0F;
				}
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x06001C52 RID: 7250 RVA: 0x00053224 File Offset: 0x00051424
		// (set) Token: 0x06001C53 RID: 7251 RVA: 0x00053238 File Offset: 0x00051438
		public int Mask
		{
			[CompilerGenerated]
			get
			{
				return this.<Mask>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Mask>k__BackingField == value)
				{
					return;
				}
				this.<Mask>k__BackingField = value;
				this.RaisePropertyChanged("Mask");
			}
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06001C54 RID: 7252 RVA: 0x00053264 File Offset: 0x00051464
		// (set) Token: 0x06001C55 RID: 7253 RVA: 0x00053278 File Offset: 0x00051478
		public int Type
		{
			[CompilerGenerated]
			get
			{
				return this.<Type>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Type>k__BackingField == value)
				{
					return;
				}
				this.<Type>k__BackingField = value;
				this.RaisePropertyChanged("IsMain");
				this.RaisePropertyChanged("Type");
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06001C56 RID: 7254 RVA: 0x000532B0 File Offset: 0x000514B0
		// (set) Token: 0x06001C57 RID: 7255 RVA: 0x000532C4 File Offset: 0x000514C4
		public string Note
		{
			[CompilerGenerated]
			get
			{
				return this.<Note>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Note>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Note>k__BackingField = value;
				this.RaisePropertyChanged("Note");
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06001C58 RID: 7256 RVA: 0x000532F4 File Offset: 0x000514F4
		// (set) Token: 0x06001C59 RID: 7257 RVA: 0x0005330C File Offset: 0x0005150C
		public bool IsMain
		{
			get
			{
				return this.Type == 1;
			}
			set
			{
				if (this.IsMain == value)
				{
					return;
				}
				this.Type = (value ? 1 : 0);
				this.RaisePropertyChanged("IsMain");
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06001C5A RID: 7258 RVA: 0x00053340 File Offset: 0x00051540
		// (set) Token: 0x06001C5B RID: 7259 RVA: 0x00053354 File Offset: 0x00051554
		public bool Notify
		{
			[CompilerGenerated]
			get
			{
				return this.<Notify>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Notify>k__BackingField == value)
				{
					return;
				}
				this.<Notify>k__BackingField = value;
				this.RaisePropertyChanged("Notify");
			}
		}

		// Token: 0x06001C5C RID: 7260 RVA: 0x000069B8 File Offset: 0x00004BB8
		public Tel()
		{
		}

		// Token: 0x04000EE7 RID: 3815
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04000EE8 RID: 3816
		[CompilerGenerated]
		private string <Phone>k__BackingField;

		// Token: 0x04000EE9 RID: 3817
		[CompilerGenerated]
		private string <PhoneClean>k__BackingField;

		// Token: 0x04000EEA RID: 3818
		[CompilerGenerated]
		private int <Mask>k__BackingField;

		// Token: 0x04000EEB RID: 3819
		[CompilerGenerated]
		private int <Type>k__BackingField;

		// Token: 0x04000EEC RID: 3820
		[CompilerGenerated]
		private string <Note>k__BackingField;

		// Token: 0x04000EED RID: 3821
		[CompilerGenerated]
		private bool <Notify>k__BackingField;
	}
}
