using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using DevExpress.Mvvm;

namespace ASC
{
	// Token: 0x02000044 RID: 68
	public class images : BindableBase
	{
		// Token: 0x06000656 RID: 1622 RVA: 0x0000E714 File Offset: 0x0000C914
		public images()
		{
			this.cash_orders = new HashSet<cash_orders>();
			this.banks = new HashSet<banks>();
			this.banks1 = new HashSet<banks>();
			this.banks2 = new HashSet<banks>();
			this.cartridge_cards = new HashSet<cartridge_cards>();
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000657 RID: 1623 RVA: 0x0000E760 File Offset: 0x0000C960
		// (set) Token: 0x06000658 RID: 1624 RVA: 0x0000E774 File Offset: 0x0000C974
		public int id
		{
			[CompilerGenerated]
			get
			{
				return this.<id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<id>k__BackingField == value)
				{
					return;
				}
				this.<id>k__BackingField = value;
				this.RaisePropertyChanged("id");
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000659 RID: 1625 RVA: 0x0000E7A0 File Offset: 0x0000C9A0
		// (set) Token: 0x0600065A RID: 1626 RVA: 0x0000E7B4 File Offset: 0x0000C9B4
		public byte[] img
		{
			[CompilerGenerated]
			get
			{
				return this.<img>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<img>k__BackingField, value))
				{
					return;
				}
				this.<img>k__BackingField = value;
				this.RaisePropertyChanged("Photo");
				this.RaisePropertyChanged("img");
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x0600065B RID: 1627 RVA: 0x0000E7F0 File Offset: 0x0000C9F0
		// (set) Token: 0x0600065C RID: 1628 RVA: 0x0000E804 File Offset: 0x0000CA04
		public byte[] preview
		{
			[CompilerGenerated]
			get
			{
				return this.<preview>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<preview>k__BackingField, value))
				{
					return;
				}
				this.<preview>k__BackingField = value;
				this.RaisePropertyChanged("PreviewSource");
				this.RaisePropertyChanged("preview");
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x0600065D RID: 1629 RVA: 0x0000E840 File Offset: 0x0000CA40
		// (set) Token: 0x0600065E RID: 1630 RVA: 0x0000E854 File Offset: 0x0000CA54
		public int? uid
		{
			[CompilerGenerated]
			get
			{
				return this.<uid>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<uid>k__BackingField, value))
				{
					return;
				}
				this.<uid>k__BackingField = value;
				this.RaisePropertyChanged("uid");
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x0600065F RID: 1631 RVA: 0x0000E884 File Offset: 0x0000CA84
		// (set) Token: 0x06000660 RID: 1632 RVA: 0x0000E898 File Offset: 0x0000CA98
		public DateTime? added
		{
			[CompilerGenerated]
			get
			{
				return this.<added>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<DateTime>(this.<added>k__BackingField, value))
				{
					return;
				}
				this.<added>k__BackingField = value;
				this.RaisePropertyChanged("added");
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000661 RID: 1633 RVA: 0x0000E8C8 File Offset: 0x0000CAC8
		// (set) Token: 0x06000662 RID: 1634 RVA: 0x0000E8DC File Offset: 0x0000CADC
		public int? item_id
		{
			[CompilerGenerated]
			get
			{
				return this.<item_id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<item_id>k__BackingField, value))
				{
					return;
				}
				this.<item_id>k__BackingField = value;
				this.RaisePropertyChanged("item_id");
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x0000E90C File Offset: 0x0000CB0C
		// (set) Token: 0x06000664 RID: 1636 RVA: 0x0000E920 File Offset: 0x0000CB20
		public virtual ICollection<cash_orders> cash_orders
		{
			[CompilerGenerated]
			get
			{
				return this.<cash_orders>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<cash_orders>k__BackingField, value))
				{
					return;
				}
				this.<cash_orders>k__BackingField = value;
				this.RaisePropertyChanged("cash_orders");
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x0000E950 File Offset: 0x0000CB50
		// (set) Token: 0x06000666 RID: 1638 RVA: 0x0000E964 File Offset: 0x0000CB64
		public virtual ICollection<banks> banks
		{
			[CompilerGenerated]
			get
			{
				return this.<banks>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<banks>k__BackingField, value))
				{
					return;
				}
				this.<banks>k__BackingField = value;
				this.RaisePropertyChanged("banks");
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x0000E994 File Offset: 0x0000CB94
		// (set) Token: 0x06000668 RID: 1640 RVA: 0x0000E9A8 File Offset: 0x0000CBA8
		public virtual ICollection<banks> banks1
		{
			[CompilerGenerated]
			get
			{
				return this.<banks1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<banks1>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -2071596032;
				IL_13:
				switch ((num ^ -1457522997) % 4)
				{
				case 0:
					IL_32:
					this.<banks1>k__BackingField = value;
					this.RaisePropertyChanged("banks1");
					num = -2094890022;
					goto IL_13;
				case 2:
					goto IL_0E;
				case 3:
					return;
				}
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x0000EA04 File Offset: 0x0000CC04
		// (set) Token: 0x0600066A RID: 1642 RVA: 0x0000EA18 File Offset: 0x0000CC18
		public virtual ICollection<banks> banks2
		{
			[CompilerGenerated]
			get
			{
				return this.<banks2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<banks2>k__BackingField, value))
				{
					return;
				}
				this.<banks2>k__BackingField = value;
				this.RaisePropertyChanged("banks2");
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x0000EA48 File Offset: 0x0000CC48
		// (set) Token: 0x0600066C RID: 1644 RVA: 0x0000EA5C File Offset: 0x0000CC5C
		public virtual ICollection<cartridge_cards> cartridge_cards
		{
			[CompilerGenerated]
			get
			{
				return this.<cartridge_cards>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<cartridge_cards>k__BackingField, value))
				{
					return;
				}
				this.<cartridge_cards>k__BackingField = value;
				this.RaisePropertyChanged("cartridge_cards");
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x0000EA8C File Offset: 0x0000CC8C
		// (set) Token: 0x0600066E RID: 1646 RVA: 0x0000EAA0 File Offset: 0x0000CCA0
		public virtual store_items store_items
		{
			[CompilerGenerated]
			get
			{
				return this.<store_items>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<store_items>k__BackingField, value))
				{
					return;
				}
				this.<store_items>k__BackingField = value;
				this.RaisePropertyChanged("store_items");
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x0000EAD0 File Offset: 0x0000CCD0
		public virtual BitmapImage Photo
		{
			get
			{
				if (this.img == null)
				{
					return new BitmapImage(new Uri("pack://application:,,,/ASC;component/Resources/noFoto.png", UriKind.Absolute));
				}
				return ConvertersStack.ByteArrayToImage(this.img);
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x0000EB04 File Offset: 0x0000CD04
		public virtual ImageSource PreviewSource
		{
			get
			{
				if (this.preview == null)
				{
					return null;
				}
				BitmapImage bitmapImage = new BitmapImage();
				bitmapImage.BeginInit();
				using (MemoryStream memoryStream = new MemoryStream(this.preview))
				{
					bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
					bitmapImage.StreamSource = memoryStream;
					bitmapImage.EndInit();
				}
				return bitmapImage;
			}
		}

		// Token: 0x04000307 RID: 775
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x04000308 RID: 776
		[CompilerGenerated]
		private byte[] <img>k__BackingField;

		// Token: 0x04000309 RID: 777
		[CompilerGenerated]
		private byte[] <preview>k__BackingField;

		// Token: 0x0400030A RID: 778
		[CompilerGenerated]
		private int? <uid>k__BackingField;

		// Token: 0x0400030B RID: 779
		[CompilerGenerated]
		private DateTime? <added>k__BackingField;

		// Token: 0x0400030C RID: 780
		[CompilerGenerated]
		private int? <item_id>k__BackingField;

		// Token: 0x0400030D RID: 781
		[CompilerGenerated]
		private ICollection<cash_orders> <cash_orders>k__BackingField;

		// Token: 0x0400030E RID: 782
		[CompilerGenerated]
		private ICollection<banks> <banks>k__BackingField;

		// Token: 0x0400030F RID: 783
		[CompilerGenerated]
		private ICollection<banks> <banks1>k__BackingField;

		// Token: 0x04000310 RID: 784
		[CompilerGenerated]
		private ICollection<banks> <banks2>k__BackingField;

		// Token: 0x04000311 RID: 785
		[CompilerGenerated]
		private ICollection<cartridge_cards> <cartridge_cards>k__BackingField;

		// Token: 0x04000312 RID: 786
		[CompilerGenerated]
		private store_items <store_items>k__BackingField;
	}
}
