using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ASC
{
	// Token: 0x02000072 RID: 114
	public class stores : INotifyPropertyChanged
	{
		// Token: 0x06000CD8 RID: 3288 RVA: 0x000172F4 File Offset: 0x000154F4
		public stores()
		{
			this.store_cats = new HashSet<store_cats>();
			this.store_items = new HashSet<store_items>();
			this.docs = new HashSet<docs>();
			this.boxes = new HashSet<boxes>();
			this.docs1 = new HashSet<docs>();
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06000CD9 RID: 3289 RVA: 0x00017340 File Offset: 0x00015540
		// (set) Token: 0x06000CDA RID: 3290 RVA: 0x00017354 File Offset: 0x00015554
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
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.id);
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06000CDB RID: 3291 RVA: 0x00017380 File Offset: 0x00015580
		// (set) Token: 0x06000CDC RID: 3292 RVA: 0x00017394 File Offset: 0x00015594
		public string name
		{
			[CompilerGenerated]
			get
			{
				return this.<name>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<name>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<name>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.name);
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06000CDD RID: 3293 RVA: 0x000173C4 File Offset: 0x000155C4
		// (set) Token: 0x06000CDE RID: 3294 RVA: 0x000173D8 File Offset: 0x000155D8
		public int? office
		{
			[CompilerGenerated]
			get
			{
				return this.<office>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<office>k__BackingField, value))
				{
					return;
				}
				this.<office>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.office);
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06000CDF RID: 3295 RVA: 0x00017408 File Offset: 0x00015608
		// (set) Token: 0x06000CE0 RID: 3296 RVA: 0x0001741C File Offset: 0x0001561C
		public int type
		{
			[CompilerGenerated]
			get
			{
				return this.<type>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<type>k__BackingField == value)
				{
					return;
				}
				this.<type>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.type);
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06000CE1 RID: 3297 RVA: 0x00017448 File Offset: 0x00015648
		// (set) Token: 0x06000CE2 RID: 3298 RVA: 0x0001745C File Offset: 0x0001565C
		public string description
		{
			[CompilerGenerated]
			get
			{
				return this.<description>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<description>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<description>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.description);
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x0001748C File Offset: 0x0001568C
		// (set) Token: 0x06000CE4 RID: 3300 RVA: 0x000174A0 File Offset: 0x000156A0
		public int sub_type
		{
			[CompilerGenerated]
			get
			{
				return this.<sub_type>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<sub_type>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -354121675;
				IL_10:
				switch ((num ^ -1329843032) % 4)
				{
				case 0:
					IL_2F:
					num = -1733228342;
					goto IL_10;
				case 1:
					return;
				case 3:
					goto IL_0B;
				}
				this.<sub_type>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.sub_type);
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x000174F8 File Offset: 0x000156F8
		// (set) Token: 0x06000CE6 RID: 3302 RVA: 0x0001750C File Offset: 0x0001570C
		public bool it_vis_pn
		{
			[CompilerGenerated]
			get
			{
				return this.<it_vis_pn>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<it_vis_pn>k__BackingField == value)
				{
					return;
				}
				this.<it_vis_pn>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.it_vis_pn);
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x00017538 File Offset: 0x00015738
		// (set) Token: 0x06000CE8 RID: 3304 RVA: 0x0001754C File Offset: 0x0001574C
		public bool it_vis_notes
		{
			[CompilerGenerated]
			get
			{
				return this.<it_vis_notes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<it_vis_notes>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -377936556;
				IL_10:
				switch ((num ^ -1433708083) % 4)
				{
				case 1:
					return;
				case 2:
					IL_2F:
					this.<it_vis_notes>k__BackingField = value;
					num = -1794677459;
					goto IL_10;
				case 3:
					goto IL_0B;
				}
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.it_vis_notes);
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x000175A4 File Offset: 0x000157A4
		// (set) Token: 0x06000CEA RID: 3306 RVA: 0x000175B8 File Offset: 0x000157B8
		public bool it_vis_description
		{
			[CompilerGenerated]
			get
			{
				return this.<it_vis_description>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<it_vis_description>k__BackingField == value)
				{
					return;
				}
				this.<it_vis_description>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.it_vis_description);
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06000CEB RID: 3307 RVA: 0x000175E4 File Offset: 0x000157E4
		// (set) Token: 0x06000CEC RID: 3308 RVA: 0x000175F8 File Offset: 0x000157F8
		public bool it_vis_sn
		{
			[CompilerGenerated]
			get
			{
				return this.<it_vis_sn>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<it_vis_sn>k__BackingField == value)
				{
					return;
				}
				this.<it_vis_sn>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.it_vis_sn);
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06000CED RID: 3309 RVA: 0x00017624 File Offset: 0x00015824
		// (set) Token: 0x06000CEE RID: 3310 RVA: 0x00017638 File Offset: 0x00015838
		public bool it_vis_barcode
		{
			[CompilerGenerated]
			get
			{
				return this.<it_vis_barcode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<it_vis_barcode>k__BackingField == value)
				{
					return;
				}
				this.<it_vis_barcode>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.it_vis_barcode);
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06000CEF RID: 3311 RVA: 0x00017664 File Offset: 0x00015864
		// (set) Token: 0x06000CF0 RID: 3312 RVA: 0x00017678 File Offset: 0x00015878
		public bool it_vis_photo
		{
			[CompilerGenerated]
			get
			{
				return this.<it_vis_photo>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<it_vis_photo>k__BackingField == value)
				{
					return;
				}
				this.<it_vis_photo>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.it_vis_photo);
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x000176A4 File Offset: 0x000158A4
		// (set) Token: 0x06000CF2 RID: 3314 RVA: 0x000176B8 File Offset: 0x000158B8
		public bool it_vis_warranty
		{
			[CompilerGenerated]
			get
			{
				return this.<it_vis_warranty>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<it_vis_warranty>k__BackingField == value)
				{
					return;
				}
				this.<it_vis_warranty>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.it_vis_warranty);
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06000CF3 RID: 3315 RVA: 0x000176E4 File Offset: 0x000158E4
		// (set) Token: 0x06000CF4 RID: 3316 RVA: 0x000176F8 File Offset: 0x000158F8
		public bool it_vis_warranty_dealer
		{
			[CompilerGenerated]
			get
			{
				return this.<it_vis_warranty_dealer>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<it_vis_warranty_dealer>k__BackingField == value)
				{
					return;
				}
				this.<it_vis_warranty_dealer>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.it_vis_warranty_dealer);
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x00017724 File Offset: 0x00015924
		// (set) Token: 0x06000CF6 RID: 3318 RVA: 0x00017738 File Offset: 0x00015938
		public bool active
		{
			[CompilerGenerated]
			get
			{
				return this.<active>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<active>k__BackingField == value)
				{
					return;
				}
				this.<active>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.Archive);
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.active);
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06000CF7 RID: 3319 RVA: 0x00017770 File Offset: 0x00015970
		// (set) Token: 0x06000CF8 RID: 3320 RVA: 0x00017784 File Offset: 0x00015984
		public virtual ICollection<store_cats> store_cats
		{
			[CompilerGenerated]
			get
			{
				return this.<store_cats>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<store_cats>k__BackingField, value))
				{
					return;
				}
				this.<store_cats>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.store_cats);
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06000CF9 RID: 3321 RVA: 0x000177B4 File Offset: 0x000159B4
		// (set) Token: 0x06000CFA RID: 3322 RVA: 0x000177C8 File Offset: 0x000159C8
		public virtual store_sub_types store_sub_types
		{
			[CompilerGenerated]
			get
			{
				return this.<store_sub_types>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<store_sub_types>k__BackingField, value))
				{
					return;
				}
				this.<store_sub_types>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.store_sub_types);
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06000CFB RID: 3323 RVA: 0x000177F8 File Offset: 0x000159F8
		// (set) Token: 0x06000CFC RID: 3324 RVA: 0x0001780C File Offset: 0x00015A0C
		public virtual store_types store_types
		{
			[CompilerGenerated]
			get
			{
				return this.<store_types>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<store_types>k__BackingField, value))
				{
					return;
				}
				this.<store_types>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.store_types);
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06000CFD RID: 3325 RVA: 0x0001783C File Offset: 0x00015A3C
		// (set) Token: 0x06000CFE RID: 3326 RVA: 0x00017850 File Offset: 0x00015A50
		public virtual ICollection<store_items> store_items
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
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.store_items);
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06000CFF RID: 3327 RVA: 0x00017880 File Offset: 0x00015A80
		// (set) Token: 0x06000D00 RID: 3328 RVA: 0x00017894 File Offset: 0x00015A94
		public virtual ICollection<docs> docs
		{
			[CompilerGenerated]
			get
			{
				return this.<docs>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<docs>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1504909192;
				IL_13:
				switch ((num ^ 501357001) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					return;
				case 3:
					IL_32:
					this.<docs>k__BackingField = value;
					this.<>OnPropertyChanged(<>PropertyChangedEventArgs.docs);
					num = 1990753555;
					goto IL_13;
				}
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06000D01 RID: 3329 RVA: 0x000178F0 File Offset: 0x00015AF0
		// (set) Token: 0x06000D02 RID: 3330 RVA: 0x00017904 File Offset: 0x00015B04
		public virtual offices offices
		{
			[CompilerGenerated]
			get
			{
				return this.<offices>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<offices>k__BackingField, value))
				{
					return;
				}
				this.<offices>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.offices);
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06000D03 RID: 3331 RVA: 0x00017934 File Offset: 0x00015B34
		// (set) Token: 0x06000D04 RID: 3332 RVA: 0x00017948 File Offset: 0x00015B48
		public virtual ICollection<boxes> boxes
		{
			[CompilerGenerated]
			get
			{
				return this.<boxes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<boxes>k__BackingField, value))
				{
					return;
				}
				this.<boxes>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.boxes);
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06000D05 RID: 3333 RVA: 0x00017978 File Offset: 0x00015B78
		// (set) Token: 0x06000D06 RID: 3334 RVA: 0x0001798C File Offset: 0x00015B8C
		public virtual ICollection<docs> docs1
		{
			[CompilerGenerated]
			get
			{
				return this.<docs1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<docs1>k__BackingField, value))
				{
					return;
				}
				this.<docs1>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.docs1);
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000D07 RID: 3335 RVA: 0x000179BC File Offset: 0x00015BBC
		// (remove) Token: 0x06000D08 RID: 3336 RVA: 0x000179F8 File Offset: 0x00015BF8
		public event PropertyChangedEventHandler PropertyChanged
		{
			[CompilerGenerated]
			add
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06000D09 RID: 3337 RVA: 0x00017A30 File Offset: 0x00015C30
		// (set) Token: 0x06000D0A RID: 3338 RVA: 0x00017A48 File Offset: 0x00015C48
		public bool Archive
		{
			get
			{
				return !this.active;
			}
			set
			{
				this.active = !value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.Archive);
			}
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x00017A6C File Offset: 0x00015C6C
		[GeneratedCode("PropertyChanged.Fody", "3.1.3.0")]
		[DebuggerNonUserCode]
		protected void <>OnPropertyChanged(PropertyChangedEventArgs eventArgs)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, eventArgs);
			}
		}

		// Token: 0x04000623 RID: 1571
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x04000624 RID: 1572
		[CompilerGenerated]
		private string <name>k__BackingField;

		// Token: 0x04000625 RID: 1573
		[CompilerGenerated]
		private int? <office>k__BackingField;

		// Token: 0x04000626 RID: 1574
		[CompilerGenerated]
		private int <type>k__BackingField;

		// Token: 0x04000627 RID: 1575
		[CompilerGenerated]
		private string <description>k__BackingField;

		// Token: 0x04000628 RID: 1576
		[CompilerGenerated]
		private int <sub_type>k__BackingField;

		// Token: 0x04000629 RID: 1577
		[CompilerGenerated]
		private bool <it_vis_pn>k__BackingField;

		// Token: 0x0400062A RID: 1578
		[CompilerGenerated]
		private bool <it_vis_notes>k__BackingField;

		// Token: 0x0400062B RID: 1579
		[CompilerGenerated]
		private bool <it_vis_description>k__BackingField;

		// Token: 0x0400062C RID: 1580
		[CompilerGenerated]
		private bool <it_vis_sn>k__BackingField;

		// Token: 0x0400062D RID: 1581
		[CompilerGenerated]
		private bool <it_vis_barcode>k__BackingField;

		// Token: 0x0400062E RID: 1582
		[CompilerGenerated]
		private bool <it_vis_photo>k__BackingField;

		// Token: 0x0400062F RID: 1583
		[CompilerGenerated]
		private bool <it_vis_warranty>k__BackingField;

		// Token: 0x04000630 RID: 1584
		[CompilerGenerated]
		private bool <it_vis_warranty_dealer>k__BackingField;

		// Token: 0x04000631 RID: 1585
		[CompilerGenerated]
		private bool <active>k__BackingField;

		// Token: 0x04000632 RID: 1586
		[CompilerGenerated]
		private ICollection<store_cats> <store_cats>k__BackingField;

		// Token: 0x04000633 RID: 1587
		[CompilerGenerated]
		private store_sub_types <store_sub_types>k__BackingField;

		// Token: 0x04000634 RID: 1588
		[CompilerGenerated]
		private store_types <store_types>k__BackingField;

		// Token: 0x04000635 RID: 1589
		[CompilerGenerated]
		private ICollection<store_items> <store_items>k__BackingField;

		// Token: 0x04000636 RID: 1590
		[CompilerGenerated]
		private ICollection<docs> <docs>k__BackingField;

		// Token: 0x04000637 RID: 1591
		[CompilerGenerated]
		private offices <offices>k__BackingField;

		// Token: 0x04000638 RID: 1592
		[CompilerGenerated]
		private ICollection<boxes> <boxes>k__BackingField;

		// Token: 0x04000639 RID: 1593
		[CompilerGenerated]
		private ICollection<docs> <docs1>k__BackingField;

		// Token: 0x0400063A RID: 1594
		[CompilerGenerated]
		private PropertyChangedEventHandler PropertyChanged;
	}
}
