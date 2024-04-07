using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using DevExpress.Mvvm;

namespace ASC
{
	// Token: 0x0200007A RID: 122
	public class tasks : BindableBase
	{
		// Token: 0x06000E71 RID: 3697 RVA: 0x0001ABC4 File Offset: 0x00018DC4
		public tasks()
		{
			this.tasks1 = new HashSet<tasks>();
			this.task_employees = new HashSet<task_employees>();
			this.notifications = new HashSet<notifications>();
			this.hooks = new HashSet<hooks>();
			this.comments = new HashSet<comments>();
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06000E72 RID: 3698 RVA: 0x0001AC10 File Offset: 0x00018E10
		// (set) Token: 0x06000E73 RID: 3699 RVA: 0x0001AC24 File Offset: 0x00018E24
		public int idt
		{
			[CompilerGenerated]
			get
			{
				return this.<idt>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<idt>k__BackingField == value)
				{
					return;
				}
				this.<idt>k__BackingField = value;
				this.RaisePropertyChanged("idt");
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06000E74 RID: 3700 RVA: 0x0001AC50 File Offset: 0x00018E50
		// (set) Token: 0x06000E75 RID: 3701 RVA: 0x0001AC64 File Offset: 0x00018E64
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
				this.RaisePropertyChanged("Progress");
				this.RaisePropertyChanged("Image");
				this.RaisePropertyChanged("type");
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06000E76 RID: 3702 RVA: 0x0001ACA8 File Offset: 0x00018EA8
		// (set) Token: 0x06000E77 RID: 3703 RVA: 0x0001ACBC File Offset: 0x00018EBC
		public int state
		{
			[CompilerGenerated]
			get
			{
				return this.<state>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<state>k__BackingField == value)
				{
					return;
				}
				this.<state>k__BackingField = value;
				this.RaisePropertyChanged("state");
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06000E78 RID: 3704 RVA: 0x0001ACE8 File Offset: 0x00018EE8
		// (set) Token: 0x06000E79 RID: 3705 RVA: 0x0001ACFC File Offset: 0x00018EFC
		public string title
		{
			[CompilerGenerated]
			get
			{
				return this.<title>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.<title>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = 1881780453;
				IL_14:
				switch ((num ^ 163263380) % 4)
				{
				case 0:
					IL_33:
					this.<title>k__BackingField = value;
					this.RaisePropertyChanged("title");
					num = 653748651;
					goto IL_14;
				case 1:
					return;
				case 2:
					goto IL_0F;
				}
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06000E7A RID: 3706 RVA: 0x0001AD58 File Offset: 0x00018F58
		// (set) Token: 0x06000E7B RID: 3707 RVA: 0x0001AD6C File Offset: 0x00018F6C
		public string text
		{
			[CompilerGenerated]
			get
			{
				return this.<text>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<text>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<text>k__BackingField = value;
				this.RaisePropertyChanged("TextShort");
				this.RaisePropertyChanged("text");
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06000E7C RID: 3708 RVA: 0x0001ADA8 File Offset: 0x00018FA8
		// (set) Token: 0x06000E7D RID: 3709 RVA: 0x0001ADBC File Offset: 0x00018FBC
		public int top_user
		{
			[CompilerGenerated]
			get
			{
				return this.<top_user>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<top_user>k__BackingField == value)
				{
					return;
				}
				this.<top_user>k__BackingField = value;
				this.RaisePropertyChanged("top_user");
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06000E7E RID: 3710 RVA: 0x0001ADE8 File Offset: 0x00018FE8
		// (set) Token: 0x06000E7F RID: 3711 RVA: 0x0001ADFC File Offset: 0x00018FFC
		public int? parent_task
		{
			[CompilerGenerated]
			get
			{
				return this.<parent_task>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<parent_task>k__BackingField, value))
				{
					return;
				}
				this.<parent_task>k__BackingField = value;
				this.RaisePropertyChanged("parent_task");
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06000E80 RID: 3712 RVA: 0x0001AE2C File Offset: 0x0001902C
		// (set) Token: 0x06000E81 RID: 3713 RVA: 0x0001AE40 File Offset: 0x00019040
		public DateTime start_datetime
		{
			[CompilerGenerated]
			get
			{
				return this.<start_datetime>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (DateTime.Equals(this.<start_datetime>k__BackingField, value))
				{
					return;
				}
				this.<start_datetime>k__BackingField = value;
				this.RaisePropertyChanged("start_datetime");
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06000E82 RID: 3714 RVA: 0x0001AE70 File Offset: 0x00019070
		// (set) Token: 0x06000E83 RID: 3715 RVA: 0x0001AE84 File Offset: 0x00019084
		public DateTime? end_datetime
		{
			[CompilerGenerated]
			get
			{
				return this.<end_datetime>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<DateTime>(this.<end_datetime>k__BackingField, value))
				{
					return;
				}
				this.<end_datetime>k__BackingField = value;
				this.RaisePropertyChanged("Progress");
				this.RaisePropertyChanged("end_datetime");
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06000E84 RID: 3716 RVA: 0x0001AEC0 File Offset: 0x000190C0
		// (set) Token: 0x06000E85 RID: 3717 RVA: 0x0001AED4 File Offset: 0x000190D4
		public bool is_timelimit
		{
			[CompilerGenerated]
			get
			{
				return this.<is_timelimit>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<is_timelimit>k__BackingField == value)
				{
					return;
				}
				this.<is_timelimit>k__BackingField = value;
				this.RaisePropertyChanged("Progress");
				this.RaisePropertyChanged("is_timelimit");
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06000E86 RID: 3718 RVA: 0x0001AF0C File Offset: 0x0001910C
		// (set) Token: 0x06000E87 RID: 3719 RVA: 0x0001AF20 File Offset: 0x00019120
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
				this.RaisePropertyChanged("ItemCardVisible");
				this.RaisePropertyChanged("item_id");
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06000E88 RID: 3720 RVA: 0x0001AF5C File Offset: 0x0001915C
		// (set) Token: 0x06000E89 RID: 3721 RVA: 0x0001AF70 File Offset: 0x00019170
		public int? repair_id
		{
			[CompilerGenerated]
			get
			{
				return this.<repair_id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<repair_id>k__BackingField, value))
				{
					return;
				}
				this.<repair_id>k__BackingField = value;
				this.RaisePropertyChanged("RepairCardVisible");
				this.RaisePropertyChanged("repair_id");
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06000E8A RID: 3722 RVA: 0x0001AFAC File Offset: 0x000191AC
		// (set) Token: 0x06000E8B RID: 3723 RVA: 0x0001AFC0 File Offset: 0x000191C0
		public int? task_author
		{
			[CompilerGenerated]
			get
			{
				return this.<task_author>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<task_author>k__BackingField, value))
				{
					return;
				}
				this.<task_author>k__BackingField = value;
				this.RaisePropertyChanged("task_author");
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06000E8C RID: 3724 RVA: 0x0001AFF0 File Offset: 0x000191F0
		// (set) Token: 0x06000E8D RID: 3725 RVA: 0x0001B004 File Offset: 0x00019204
		public DateTime? complete_datetime
		{
			[CompilerGenerated]
			get
			{
				return this.<complete_datetime>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<DateTime>(this.<complete_datetime>k__BackingField, value))
				{
					return;
				}
				this.<complete_datetime>k__BackingField = value;
				this.RaisePropertyChanged("complete_datetime");
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06000E8E RID: 3726 RVA: 0x0001B034 File Offset: 0x00019234
		// (set) Token: 0x06000E8F RID: 3727 RVA: 0x0001B048 File Offset: 0x00019248
		public int? request_id
		{
			[CompilerGenerated]
			get
			{
				return this.<request_id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<request_id>k__BackingField, value))
				{
					return;
				}
				this.<request_id>k__BackingField = value;
				this.RaisePropertyChanged("request_id");
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06000E90 RID: 3728 RVA: 0x0001B078 File Offset: 0x00019278
		// (set) Token: 0x06000E91 RID: 3729 RVA: 0x0001B08C File Offset: 0x0001928C
		public int priority
		{
			[CompilerGenerated]
			get
			{
				return this.<priority>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<priority>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -1250987110;
				IL_10:
				switch ((num ^ -1878980161) % 4)
				{
				case 0:
					goto IL_0B;
				case 1:
					return;
				case 3:
					IL_2F:
					this.<priority>k__BackingField = value;
					this.RaisePropertyChanged("priority");
					num = -991062727;
					goto IL_10;
				}
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06000E92 RID: 3730 RVA: 0x0001B0E4 File Offset: 0x000192E4
		// (set) Token: 0x06000E93 RID: 3731 RVA: 0x0001B0F8 File Offset: 0x000192F8
		public string email
		{
			[CompilerGenerated]
			get
			{
				return this.<email>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<email>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<email>k__BackingField = value;
				this.RaisePropertyChanged("email");
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06000E94 RID: 3732 RVA: 0x0001B128 File Offset: 0x00019328
		// (set) Token: 0x06000E95 RID: 3733 RVA: 0x0001B13C File Offset: 0x0001933C
		public string phone
		{
			[CompilerGenerated]
			get
			{
				return this.<phone>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<phone>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<phone>k__BackingField = value;
				this.RaisePropertyChanged("phone");
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06000E96 RID: 3734 RVA: 0x0001B16C File Offset: 0x0001936C
		// (set) Token: 0x06000E97 RID: 3735 RVA: 0x0001B180 File Offset: 0x00019380
		public int? part_request
		{
			[CompilerGenerated]
			get
			{
				return this.<part_request>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<part_request>k__BackingField, value))
				{
					return;
				}
				this.<part_request>k__BackingField = value;
				this.RaisePropertyChanged("part_request");
			}
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06000E98 RID: 3736 RVA: 0x0001B1B0 File Offset: 0x000193B0
		// (set) Token: 0x06000E99 RID: 3737 RVA: 0x0001B1C4 File Offset: 0x000193C4
		public int? m_device
		{
			[CompilerGenerated]
			get
			{
				return this.<m_device>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!Nullable.Equals<int>(this.<m_device>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -281320616;
				IL_13:
				switch ((num ^ -163885381) % 4)
				{
				case 0:
					goto IL_0E;
				case 2:
					IL_32:
					this.<m_device>k__BackingField = value;
					num = -1745980530;
					goto IL_13;
				case 3:
					return;
				}
				this.RaisePropertyChanged("m_device");
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x06000E9A RID: 3738 RVA: 0x0001B220 File Offset: 0x00019420
		// (set) Token: 0x06000E9B RID: 3739 RVA: 0x0001B234 File Offset: 0x00019434
		public int? m_maker
		{
			[CompilerGenerated]
			get
			{
				return this.<m_maker>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!Nullable.Equals<int>(this.<m_maker>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1413318893;
				IL_13:
				switch ((num ^ 1011057304) % 4)
				{
				case 0:
					IL_32:
					num = 1125203467;
					goto IL_13;
				case 1:
					return;
				case 2:
					goto IL_0E;
				}
				this.<m_maker>k__BackingField = value;
				this.RaisePropertyChanged("m_maker");
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x06000E9C RID: 3740 RVA: 0x0001B290 File Offset: 0x00019490
		// (set) Token: 0x06000E9D RID: 3741 RVA: 0x0001B2A4 File Offset: 0x000194A4
		public string m_match
		{
			[CompilerGenerated]
			get
			{
				return this.<m_match>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.<m_match>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = 931286911;
				IL_14:
				switch ((num ^ 439224606) % 4)
				{
				case 0:
					IL_33:
					this.<m_match>k__BackingField = value;
					this.RaisePropertyChanged("m_match");
					num = 447588756;
					goto IL_14;
				case 1:
					return;
				case 3:
					goto IL_0F;
				}
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x06000E9E RID: 3742 RVA: 0x0001B300 File Offset: 0x00019500
		// (set) Token: 0x06000E9F RID: 3743 RVA: 0x0001B314 File Offset: 0x00019514
		public DateTime created
		{
			[CompilerGenerated]
			get
			{
				return this.<created>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (DateTime.Equals(this.<created>k__BackingField, value))
				{
					return;
				}
				this.<created>k__BackingField = value;
				this.RaisePropertyChanged("created");
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06000EA0 RID: 3744 RVA: 0x0001B344 File Offset: 0x00019544
		// (set) Token: 0x06000EA1 RID: 3745 RVA: 0x0001B358 File Offset: 0x00019558
		public int? doc_id
		{
			[CompilerGenerated]
			get
			{
				return this.<doc_id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<doc_id>k__BackingField, value))
				{
					return;
				}
				this.<doc_id>k__BackingField = value;
				this.RaisePropertyChanged("doc_id");
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x06000EA2 RID: 3746 RVA: 0x0001B388 File Offset: 0x00019588
		// (set) Token: 0x06000EA3 RID: 3747 RVA: 0x0001B39C File Offset: 0x0001959C
		public virtual ICollection<tasks> tasks1
		{
			[CompilerGenerated]
			get
			{
				return this.<tasks1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<tasks1>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1384100659;
				IL_13:
				switch ((num ^ 1939896442) % 4)
				{
				case 1:
					return;
				case 2:
					goto IL_0E;
				case 3:
					IL_32:
					this.<tasks1>k__BackingField = value;
					this.RaisePropertyChanged("tasks1");
					num = 572839154;
					goto IL_13;
				}
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06000EA4 RID: 3748 RVA: 0x0001B3F8 File Offset: 0x000195F8
		// (set) Token: 0x06000EA5 RID: 3749 RVA: 0x0001B40C File Offset: 0x0001960C
		public virtual tasks tasks2
		{
			[CompilerGenerated]
			get
			{
				return this.<tasks2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<tasks2>k__BackingField, value))
				{
					return;
				}
				this.<tasks2>k__BackingField = value;
				this.RaisePropertyChanged("tasks2");
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06000EA6 RID: 3750 RVA: 0x0001B43C File Offset: 0x0001963C
		// (set) Token: 0x06000EA7 RID: 3751 RVA: 0x0001B450 File Offset: 0x00019650
		public virtual users users1
		{
			[CompilerGenerated]
			get
			{
				return this.<users1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<users1>k__BackingField, value))
				{
					return;
				}
				this.<users1>k__BackingField = value;
				this.RaisePropertyChanged("users1");
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06000EA8 RID: 3752 RVA: 0x0001B480 File Offset: 0x00019680
		// (set) Token: 0x06000EA9 RID: 3753 RVA: 0x0001B494 File Offset: 0x00019694
		public virtual store_int_reserve store_int_reserve
		{
			[CompilerGenerated]
			get
			{
				return this.<store_int_reserve>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<store_int_reserve>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1884157990;
				IL_13:
				switch ((num ^ -1956734849) % 4)
				{
				case 1:
					return;
				case 2:
					goto IL_0E;
				case 3:
					IL_32:
					this.<store_int_reserve>k__BackingField = value;
					num = -849640577;
					goto IL_13;
				}
				this.RaisePropertyChanged("store_int_reserve");
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06000EAA RID: 3754 RVA: 0x0001B4F0 File Offset: 0x000196F0
		// (set) Token: 0x06000EAB RID: 3755 RVA: 0x0001B504 File Offset: 0x00019704
		public virtual ICollection<task_employees> task_employees
		{
			[CompilerGenerated]
			get
			{
				return this.<task_employees>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<task_employees>k__BackingField, value))
				{
					return;
				}
				this.<task_employees>k__BackingField = value;
				this.RaisePropertyChanged("TaskUsers");
				this.RaisePropertyChanged("task_employees");
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06000EAC RID: 3756 RVA: 0x0001B540 File Offset: 0x00019740
		// (set) Token: 0x06000EAD RID: 3757 RVA: 0x0001B554 File Offset: 0x00019754
		public virtual parts_request parts_request
		{
			[CompilerGenerated]
			get
			{
				return this.<parts_request>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<parts_request>k__BackingField, value))
				{
					return;
				}
				this.<parts_request>k__BackingField = value;
				this.RaisePropertyChanged("parts_request");
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x06000EAE RID: 3758 RVA: 0x0001B584 File Offset: 0x00019784
		// (set) Token: 0x06000EAF RID: 3759 RVA: 0x0001B598 File Offset: 0x00019798
		public virtual ICollection<notifications> notifications
		{
			[CompilerGenerated]
			get
			{
				return this.<notifications>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<notifications>k__BackingField, value))
				{
					return;
				}
				this.<notifications>k__BackingField = value;
				this.RaisePropertyChanged("notifications");
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x06000EB0 RID: 3760 RVA: 0x0001B5C8 File Offset: 0x000197C8
		// (set) Token: 0x06000EB1 RID: 3761 RVA: 0x0001B5DC File Offset: 0x000197DC
		public virtual ICollection<hooks> hooks
		{
			[CompilerGenerated]
			get
			{
				return this.<hooks>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<hooks>k__BackingField, value))
				{
					return;
				}
				this.<hooks>k__BackingField = value;
				this.RaisePropertyChanged("hooks");
			}
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x06000EB2 RID: 3762 RVA: 0x0001B60C File Offset: 0x0001980C
		// (set) Token: 0x06000EB3 RID: 3763 RVA: 0x0001B620 File Offset: 0x00019820
		public virtual docs docs
		{
			[CompilerGenerated]
			get
			{
				return this.<docs>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<docs>k__BackingField, value))
				{
					return;
				}
				this.<docs>k__BackingField = value;
				this.RaisePropertyChanged("docs");
			}
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x06000EB4 RID: 3764 RVA: 0x0001B650 File Offset: 0x00019850
		// (set) Token: 0x06000EB5 RID: 3765 RVA: 0x0001B664 File Offset: 0x00019864
		public virtual ICollection<comments> comments
		{
			[CompilerGenerated]
			get
			{
				return this.<comments>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<comments>k__BackingField, value))
				{
					return;
				}
				this.<comments>k__BackingField = value;
				this.RaisePropertyChanged("comments");
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x06000EB6 RID: 3766 RVA: 0x0001B694 File Offset: 0x00019894
		// (set) Token: 0x06000EB7 RID: 3767 RVA: 0x0001B6A8 File Offset: 0x000198A8
		public ObservableCollection<workshop> Repairs
		{
			[CompilerGenerated]
			get
			{
				return this.<Repairs>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Repairs>k__BackingField, value))
				{
					return;
				}
				this.<Repairs>k__BackingField = value;
				this.RaisePropertyChanged("RepairsVisibility");
				this.RaisePropertyChanged("Repairs");
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06000EB8 RID: 3768 RVA: 0x0001B6E4 File Offset: 0x000198E4
		public Visibility RepairsVisibility
		{
			get
			{
				if (this.Repairs != null && this.Repairs.Count != 0)
				{
					return Visibility.Visible;
				}
				return Visibility.Collapsed;
			}
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06000EB9 RID: 3769 RVA: 0x0001B70C File Offset: 0x0001990C
		// (set) Token: 0x06000EBA RID: 3770 RVA: 0x0001B720 File Offset: 0x00019920
		public bool ProgressbarVisibility
		{
			[CompilerGenerated]
			get
			{
				return this.<ProgressbarVisibility>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ProgressbarVisibility>k__BackingField == value)
				{
					return;
				}
				this.<ProgressbarVisibility>k__BackingField = value;
				this.RaisePropertyChanged("ProgressbarVisibilityInvert");
				this.RaisePropertyChanged("ProgressbarVisibility");
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x06000EBB RID: 3771 RVA: 0x0001B758 File Offset: 0x00019958
		public bool ProgressbarVisibilityInvert
		{
			get
			{
				return !this.ProgressbarVisibility;
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x06000EBC RID: 3772 RVA: 0x0001B770 File Offset: 0x00019970
		// (set) Token: 0x06000EBD RID: 3773 RVA: 0x0001B784 File Offset: 0x00019984
		public double UpdateProgress
		{
			[CompilerGenerated]
			get
			{
				return this.<UpdateProgress>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<UpdateProgress>k__BackingField == value)
				{
					return;
				}
				this.<UpdateProgress>k__BackingField = value;
				this.RaisePropertyChanged("UpdateProgress");
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06000EBE RID: 3774 RVA: 0x0001B7B4 File Offset: 0x000199B4
		public bool ItemCardVisible
		{
			get
			{
				return this.item_id != null;
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06000EBF RID: 3775 RVA: 0x0001B7D0 File Offset: 0x000199D0
		public bool RepairCardVisible
		{
			get
			{
				return this.repair_id != null;
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06000EC0 RID: 3776 RVA: 0x0001B7EC File Offset: 0x000199EC
		public virtual double Progress
		{
			get
			{
				if (this.is_timelimit)
				{
					goto IL_4B;
				}
				IL_17:
				int num = 242281824;
				IL_1C:
				switch ((num ^ 1922208586) % 5)
				{
				case 0:
					goto IL_17;
				case 2:
					IL_4B:
					num = ((this.type != 1) ? 1858745089 : 359761800);
					goto IL_1C;
				case 3:
					return 0.0;
				case 4:
					return (double)(100 * (DateTime.Now - this.end_datetime.Value).Hours / Auth.Config.give2user_time);
				}
				return 0.0;
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x06000EC1 RID: 3777 RVA: 0x0001B894 File Offset: 0x00019A94
		public string TaskUsers
		{
			get
			{
				if (this.task_employees != null && this.task_employees.Any<task_employees>())
				{
					return this.task_employees.Aggregate("", (string current, task_employees employee) => current + employee.users.FioShort + ", ").TrimEnd(new char[]
					{
						',',
						' '
					});
				}
				return string.Empty;
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x06000EC2 RID: 3778 RVA: 0x0001B900 File Offset: 0x00019B00
		public string TextShort
		{
			get
			{
				if (!string.IsNullOrEmpty(this.text))
				{
					goto IL_50;
				}
				IL_1C:
				int num = 2057372760;
				IL_21:
				switch ((num ^ 289117500) % 5)
				{
				case 0:
					return this.text.Substring(0, 300) + "\r\n[...]";
				case 1:
					return this.text;
				case 3:
					goto IL_1C;
				case 4:
					IL_50:
					num = ((this.text.Length <= 300) ? 1418544360 : 967019432);
					goto IL_21;
				}
				return this.text;
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x06000EC3 RID: 3779 RVA: 0x0001B99C File Offset: 0x00019B9C
		public ImageSource Image
		{
			get
			{
				if (this.type != 10)
				{
					if (this.type != 11)
					{
						return new BitmapImage(new Uri("pack://application:,,,/DevExpress.Images.v17.2;component/Images/Support/Info_16x16.png"));
					}
				}
				return new BitmapImage(new Uri("pack://application:,,,/DevExpress.Images.v17.2;component/Images/Business%20Objects/BOLocalization_16x16.png"));
			}
		}

		// Token: 0x040006D1 RID: 1745
		[CompilerGenerated]
		private int <idt>k__BackingField;

		// Token: 0x040006D2 RID: 1746
		[CompilerGenerated]
		private int <type>k__BackingField;

		// Token: 0x040006D3 RID: 1747
		[CompilerGenerated]
		private int <state>k__BackingField;

		// Token: 0x040006D4 RID: 1748
		[CompilerGenerated]
		private string <title>k__BackingField;

		// Token: 0x040006D5 RID: 1749
		[CompilerGenerated]
		private string <text>k__BackingField;

		// Token: 0x040006D6 RID: 1750
		[CompilerGenerated]
		private int <top_user>k__BackingField;

		// Token: 0x040006D7 RID: 1751
		[CompilerGenerated]
		private int? <parent_task>k__BackingField;

		// Token: 0x040006D8 RID: 1752
		[CompilerGenerated]
		private DateTime <start_datetime>k__BackingField;

		// Token: 0x040006D9 RID: 1753
		[CompilerGenerated]
		private DateTime? <end_datetime>k__BackingField;

		// Token: 0x040006DA RID: 1754
		[CompilerGenerated]
		private bool <is_timelimit>k__BackingField;

		// Token: 0x040006DB RID: 1755
		[CompilerGenerated]
		private int? <item_id>k__BackingField;

		// Token: 0x040006DC RID: 1756
		[CompilerGenerated]
		private int? <repair_id>k__BackingField;

		// Token: 0x040006DD RID: 1757
		[CompilerGenerated]
		private int? <task_author>k__BackingField;

		// Token: 0x040006DE RID: 1758
		[CompilerGenerated]
		private DateTime? <complete_datetime>k__BackingField;

		// Token: 0x040006DF RID: 1759
		[CompilerGenerated]
		private int? <request_id>k__BackingField;

		// Token: 0x040006E0 RID: 1760
		[CompilerGenerated]
		private int <priority>k__BackingField;

		// Token: 0x040006E1 RID: 1761
		[CompilerGenerated]
		private string <email>k__BackingField;

		// Token: 0x040006E2 RID: 1762
		[CompilerGenerated]
		private string <phone>k__BackingField;

		// Token: 0x040006E3 RID: 1763
		[CompilerGenerated]
		private int? <part_request>k__BackingField;

		// Token: 0x040006E4 RID: 1764
		[CompilerGenerated]
		private int? <m_device>k__BackingField;

		// Token: 0x040006E5 RID: 1765
		[CompilerGenerated]
		private int? <m_maker>k__BackingField;

		// Token: 0x040006E6 RID: 1766
		[CompilerGenerated]
		private string <m_match>k__BackingField;

		// Token: 0x040006E7 RID: 1767
		[CompilerGenerated]
		private DateTime <created>k__BackingField;

		// Token: 0x040006E8 RID: 1768
		[CompilerGenerated]
		private int? <doc_id>k__BackingField;

		// Token: 0x040006E9 RID: 1769
		[CompilerGenerated]
		private ICollection<tasks> <tasks1>k__BackingField;

		// Token: 0x040006EA RID: 1770
		[CompilerGenerated]
		private tasks <tasks2>k__BackingField;

		// Token: 0x040006EB RID: 1771
		[CompilerGenerated]
		private users <users1>k__BackingField;

		// Token: 0x040006EC RID: 1772
		[CompilerGenerated]
		private store_int_reserve <store_int_reserve>k__BackingField;

		// Token: 0x040006ED RID: 1773
		[CompilerGenerated]
		private ICollection<task_employees> <task_employees>k__BackingField;

		// Token: 0x040006EE RID: 1774
		[CompilerGenerated]
		private parts_request <parts_request>k__BackingField;

		// Token: 0x040006EF RID: 1775
		[CompilerGenerated]
		private ICollection<notifications> <notifications>k__BackingField;

		// Token: 0x040006F0 RID: 1776
		[CompilerGenerated]
		private ICollection<hooks> <hooks>k__BackingField;

		// Token: 0x040006F1 RID: 1777
		[CompilerGenerated]
		private docs <docs>k__BackingField;

		// Token: 0x040006F2 RID: 1778
		[CompilerGenerated]
		private ICollection<comments> <comments>k__BackingField;

		// Token: 0x040006F3 RID: 1779
		[CompilerGenerated]
		private ObservableCollection<workshop> <Repairs>k__BackingField;

		// Token: 0x040006F4 RID: 1780
		[CompilerGenerated]
		private bool <ProgressbarVisibility>k__BackingField;

		// Token: 0x040006F5 RID: 1781
		[CompilerGenerated]
		private double <UpdateProgress>k__BackingField;

		// Token: 0x0200007B RID: 123
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000EC4 RID: 3780 RVA: 0x0001B9E0 File Offset: 0x00019BE0
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06000EC5 RID: 3781 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06000EC6 RID: 3782 RVA: 0x0001B9F8 File Offset: 0x00019BF8
			internal string <get_TaskUsers>b__160_0(string current, task_employees employee)
			{
				return current + employee.users.FioShort + ", ";
			}

			// Token: 0x040006F6 RID: 1782
			public static readonly tasks.<>c <>9 = new tasks.<>c();

			// Token: 0x040006F7 RID: 1783
			public static Func<string, task_employees, string> <>9__160_0;
		}
	}
}
