using System;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using DevExpress.Xpf.Core;

namespace ASC.ViewModels
{
	// Token: 0x020003EF RID: 1007
	public class HamburgerMenuItemViewModel
	{
		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x060028E0 RID: 10464 RVA: 0x0007F090 File Offset: 0x0007D290
		// (set) Token: 0x060028E1 RID: 10465 RVA: 0x0007F0A4 File Offset: 0x0007D2A4
		public string Caption
		{
			[CompilerGenerated]
			get
			{
				return this.<Caption>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Caption>k__BackingField = value;
			}
		}

		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x060028E2 RID: 10466 RVA: 0x0007F0B8 File Offset: 0x0007D2B8
		// (set) Token: 0x060028E3 RID: 10467 RVA: 0x0007F0CC File Offset: 0x0007D2CC
		public string PageName
		{
			[CompilerGenerated]
			get
			{
				return this.<PageName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<PageName>k__BackingField = value;
			}
		}

		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x060028E4 RID: 10468 RVA: 0x0007F0E0 File Offset: 0x0007D2E0
		// (set) Token: 0x060028E5 RID: 10469 RVA: 0x0007F0F4 File Offset: 0x0007D2F4
		public ImageSource Glyph
		{
			[CompilerGenerated]
			get
			{
				return this.<Glyph>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Glyph>k__BackingField = value;
			}
		}

		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x060028E6 RID: 10470 RVA: 0x0007F108 File Offset: 0x0007D308
		// (set) Token: 0x060028E7 RID: 10471 RVA: 0x0007F11C File Offset: 0x0007D31C
		public string Placement
		{
			[CompilerGenerated]
			get
			{
				return this.<Placement>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Placement>k__BackingField = value;
			}
		}

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x060028E8 RID: 10472 RVA: 0x0007F130 File Offset: 0x0007D330
		// (set) Token: 0x060028E9 RID: 10473 RVA: 0x0007F144 File Offset: 0x0007D344
		public object NavigationParameter
		{
			[CompilerGenerated]
			get
			{
				return this.<NavigationParameter>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<NavigationParameter>k__BackingField = value;
			}
		}

		// Token: 0x060028EA RID: 10474 RVA: 0x0007F158 File Offset: 0x0007D358
		public HamburgerMenuItemViewModel(string caption, string pageName)
		{
			this.Caption = caption;
			this.PageName = pageName;
			this.Placement = "Top";
		}

		// Token: 0x060028EB RID: 10475 RVA: 0x0007F184 File Offset: 0x0007D384
		public HamburgerMenuItemViewModel(string caption, string pageName, object prm) : this(caption, pageName)
		{
			this.NavigationParameter = prm;
		}

		// Token: 0x060028EC RID: 10476 RVA: 0x0007F1A0 File Offset: 0x0007D3A0
		public HamburgerMenuItemViewModel(string caption, string pageName, DXImageInfo glyph) : this(caption, pageName)
		{
			object obj = new DXImageExtension
			{
				Image = glyph
			}.ProvideValue(null);
			if (obj != null)
			{
				this.Glyph = (ImageSource)obj;
			}
		}

		// Token: 0x060028ED RID: 10477 RVA: 0x0007F1D8 File Offset: 0x0007D3D8
		public HamburgerMenuItemViewModel(string caption, string pageName, DXImageInfo glyph, object prm) : this(caption, pageName, glyph)
		{
			this.NavigationParameter = prm;
		}

		// Token: 0x04001681 RID: 5761
		[CompilerGenerated]
		private string <Caption>k__BackingField;

		// Token: 0x04001682 RID: 5762
		[CompilerGenerated]
		private string <PageName>k__BackingField;

		// Token: 0x04001683 RID: 5763
		[CompilerGenerated]
		private ImageSource <Glyph>k__BackingField;

		// Token: 0x04001684 RID: 5764
		[CompilerGenerated]
		private string <Placement>k__BackingField;

		// Token: 0x04001685 RID: 5765
		[CompilerGenerated]
		private object <NavigationParameter>k__BackingField;
	}
}
