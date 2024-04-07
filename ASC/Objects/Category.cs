using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Media.Imaging;
using ASC.Common.Interfaces;
using DevExpress.Mvvm;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Core.Native;

namespace ASC.Objects
{
	// Token: 0x0200089A RID: 2202
	public class Category : BindableBase, ICategory
	{
		// Token: 0x17001269 RID: 4713
		// (get) Token: 0x0600431C RID: 17180 RVA: 0x00106A88 File Offset: 0x00104C88
		// (set) Token: 0x0600431D RID: 17181 RVA: 0x00106A9C File Offset: 0x00104C9C
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

		// Token: 0x1700126A RID: 4714
		// (get) Token: 0x0600431E RID: 17182 RVA: 0x00106AC8 File Offset: 0x00104CC8
		// (set) Token: 0x0600431F RID: 17183 RVA: 0x00106ADC File Offset: 0x00104CDC
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.<Name>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Name>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Name>k__BackingField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		// Token: 0x1700126B RID: 4715
		// (get) Token: 0x06004320 RID: 17184 RVA: 0x00106B0C File Offset: 0x00104D0C
		// (set) Token: 0x06004321 RID: 17185 RVA: 0x00106B20 File Offset: 0x00104D20
		public int? Parent
		{
			[CompilerGenerated]
			get
			{
				return this.<Parent>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<Parent>k__BackingField, value))
				{
					return;
				}
				this.<Parent>k__BackingField = value;
				this.RaisePropertyChanged("Parent");
			}
		}

		// Token: 0x1700126C RID: 4716
		// (get) Token: 0x06004322 RID: 17186 RVA: 0x00106B50 File Offset: 0x00104D50
		// (set) Token: 0x06004323 RID: 17187 RVA: 0x00106B64 File Offset: 0x00104D64
		public int? VendorId
		{
			[CompilerGenerated]
			get
			{
				return this.<VendorId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<VendorId>k__BackingField, value))
				{
					return;
				}
				this.<VendorId>k__BackingField = value;
				this.RaisePropertyChanged("VendorId");
			}
		}

		// Token: 0x1700126D RID: 4717
		// (get) Token: 0x06004324 RID: 17188 RVA: 0x00106B94 File Offset: 0x00104D94
		// (set) Token: 0x06004325 RID: 17189 RVA: 0x00106BA8 File Offset: 0x00104DA8
		public int? Position
		{
			[CompilerGenerated]
			get
			{
				return this.<Position>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<Position>k__BackingField, value))
				{
					return;
				}
				this.<Position>k__BackingField = value;
				this.RaisePropertyChanged("Position");
			}
		}

		// Token: 0x1700126E RID: 4718
		// (get) Token: 0x06004326 RID: 17190 RVA: 0x00106BD8 File Offset: 0x00104DD8
		// (set) Token: 0x06004327 RID: 17191 RVA: 0x00106BEC File Offset: 0x00104DEC
		public bool Archive
		{
			[CompilerGenerated]
			get
			{
				return this.<Archive>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Archive>k__BackingField == value)
				{
					return;
				}
				this.<Archive>k__BackingField = value;
				this.RaisePropertyChanged("Archive");
			}
		}

		// Token: 0x1700126F RID: 4719
		// (get) Token: 0x06004328 RID: 17192 RVA: 0x00106C18 File Offset: 0x00104E18
		// (set) Token: 0x06004329 RID: 17193 RVA: 0x00106C2C File Offset: 0x00104E2C
		public virtual bool IsExpand
		{
			[CompilerGenerated]
			get
			{
				return this.<IsExpand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IsExpand>k__BackingField == value)
				{
					return;
				}
				this.<IsExpand>k__BackingField = value;
				this.RaisePropertyChanged("IsExpand");
			}
		}

		// Token: 0x17001270 RID: 4720
		// (get) Token: 0x0600432A RID: 17194 RVA: 0x00106C58 File Offset: 0x00104E58
		// (set) Token: 0x0600432B RID: 17195 RVA: 0x00106C6C File Offset: 0x00104E6C
		public string Icon
		{
			[CompilerGenerated]
			get
			{
				return this.<Icon>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Icon>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Icon>k__BackingField = value;
				this.RaisePropertyChanged("Image");
				this.RaisePropertyChanged("Icon");
			}
		}

		// Token: 0x0600432C RID: 17196 RVA: 0x00106CA8 File Offset: 0x00104EA8
		public Category()
		{
			this.Icon = "Open_16x16.png";
		}

		// Token: 0x17001271 RID: 4721
		// (get) Token: 0x0600432D RID: 17197 RVA: 0x00106CC8 File Offset: 0x00104EC8
		public BitmapImage Image
		{
			get
			{
				if (!string.IsNullOrEmpty(this.Icon))
				{
					goto IL_31;
				}
				IL_0D:
				int num = 1127566319;
				IL_12:
				KeyValuePair<string, BitmapImage> keyValuePair;
				switch ((num ^ 602758581) % 4)
				{
				case 0:
					goto IL_0D;
				case 2:
					return this.DefaultImage();
				case 3:
					IL_31:
					keyValuePair = OfflineData.Instance.Images.FirstOrDefault((KeyValuePair<string, BitmapImage> i) => i.Key == this.Icon);
					num = 1203457836;
					goto IL_12;
				}
				return keyValuePair.Value ?? this.DefaultImage();
			}
		}

		// Token: 0x0600432E RID: 17198 RVA: 0x00106D44 File Offset: 0x00104F44
		private BitmapImage DefaultImage()
		{
			return new BitmapImage(new DXImageExtension
			{
				Image = (new DXImageConverter().ConvertFrom("Open_16x16.png") as DXImageInfo)
			}.Image.MakeUri());
		}

		// Token: 0x0600432F RID: 17199 RVA: 0x00106D80 File Offset: 0x00104F80
		public override string ToString()
		{
			return this.Name;
		}

		// Token: 0x06004330 RID: 17200 RVA: 0x00106D94 File Offset: 0x00104F94
		[CompilerGenerated]
		private bool <get_Image>b__34_0(KeyValuePair<string, BitmapImage> i)
		{
			return i.Key == this.Icon;
		}

		// Token: 0x04002B4D RID: 11085
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04002B4E RID: 11086
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04002B4F RID: 11087
		[CompilerGenerated]
		private int? <Parent>k__BackingField;

		// Token: 0x04002B50 RID: 11088
		[CompilerGenerated]
		private int? <VendorId>k__BackingField;

		// Token: 0x04002B51 RID: 11089
		[CompilerGenerated]
		private int? <Position>k__BackingField;

		// Token: 0x04002B52 RID: 11090
		[CompilerGenerated]
		private bool <Archive>k__BackingField;

		// Token: 0x04002B53 RID: 11091
		[CompilerGenerated]
		private bool <IsExpand>k__BackingField;

		// Token: 0x04002B54 RID: 11092
		[CompilerGenerated]
		private string <Icon>k__BackingField;
	}
}
