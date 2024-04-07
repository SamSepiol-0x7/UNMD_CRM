using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DevExpress.Mvvm;

namespace ASC
{
	// Token: 0x02000054 RID: 84
	public class parts_request : BindableBase
	{
		// Token: 0x06000836 RID: 2102 RVA: 0x00010F44 File Offset: 0x0000F144
		public parts_request()
		{
			this.parts_request_employees = new HashSet<parts_request_employees>();
			this.logs = new HashSet<logs>();
			this.tasks = new HashSet<tasks>();
			this.store_items1 = new HashSet<store_items>();
			this.notifications = new HashSet<notifications>();
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000837 RID: 2103 RVA: 0x00010F90 File Offset: 0x0000F190
		// (set) Token: 0x06000838 RID: 2104 RVA: 0x00010FA4 File Offset: 0x0000F1A4
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
				if (this.<id>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -871256624;
				IL_10:
				switch ((num ^ -168625221) % 4)
				{
				case 0:
					goto IL_0B;
				case 1:
					IL_2F:
					this.<id>k__BackingField = value;
					this.RaisePropertyChanged("id");
					num = -976687719;
					goto IL_10;
				case 3:
					return;
				}
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x00010FFC File Offset: 0x0000F1FC
		// (set) Token: 0x0600083A RID: 2106 RVA: 0x00011010 File Offset: 0x0000F210
		public DateTime request_time
		{
			[CompilerGenerated]
			get
			{
				return this.<request_time>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (DateTime.Equals(this.<request_time>k__BackingField, value))
				{
					return;
				}
				this.<request_time>k__BackingField = value;
				this.RaisePropertyChanged("Progress");
				this.RaisePropertyChanged("request_time");
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x0001104C File Offset: 0x0000F24C
		// (set) Token: 0x0600083C RID: 2108 RVA: 0x00011060 File Offset: 0x0000F260
		public int from_user
		{
			[CompilerGenerated]
			get
			{
				return this.<from_user>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<from_user>k__BackingField == value)
				{
					return;
				}
				this.<from_user>k__BackingField = value;
				this.RaisePropertyChanged("from_user");
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x0001108C File Offset: 0x0000F28C
		// (set) Token: 0x0600083E RID: 2110 RVA: 0x000110A0 File Offset: 0x0000F2A0
		public int? repair
		{
			[CompilerGenerated]
			get
			{
				return this.<repair>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<repair>k__BackingField, value))
				{
					return;
				}
				this.<repair>k__BackingField = value;
				this.RaisePropertyChanged("RepairCardVisible");
				this.RaisePropertyChanged("repair");
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x000110DC File Offset: 0x0000F2DC
		// (set) Token: 0x06000840 RID: 2112 RVA: 0x000110F0 File Offset: 0x0000F2F0
		public int? client
		{
			[CompilerGenerated]
			get
			{
				return this.<client>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<client>k__BackingField, value))
				{
					return;
				}
				this.<client>k__BackingField = value;
				this.RaisePropertyChanged("client");
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x00011120 File Offset: 0x0000F320
		// (set) Token: 0x06000842 RID: 2114 RVA: 0x00011134 File Offset: 0x0000F334
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

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x00011160 File Offset: 0x0000F360
		// (set) Token: 0x06000844 RID: 2116 RVA: 0x00011174 File Offset: 0x0000F374
		public decimal? summ
		{
			[CompilerGenerated]
			get
			{
				return this.<summ>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<decimal>(this.<summ>k__BackingField, value))
				{
					return;
				}
				this.<summ>k__BackingField = value;
				this.RaisePropertyChanged("summ");
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x000111A4 File Offset: 0x0000F3A4
		// (set) Token: 0x06000846 RID: 2118 RVA: 0x000111B8 File Offset: 0x0000F3B8
		public string tracking
		{
			[CompilerGenerated]
			get
			{
				return this.<tracking>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<tracking>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<tracking>k__BackingField = value;
				this.RaisePropertyChanged("tracking");
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x000111E8 File Offset: 0x0000F3E8
		// (set) Token: 0x06000848 RID: 2120 RVA: 0x000111FC File Offset: 0x0000F3FC
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

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000849 RID: 2121 RVA: 0x00011238 File Offset: 0x0000F438
		// (set) Token: 0x0600084A RID: 2122 RVA: 0x0001124C File Offset: 0x0000F44C
		public int pririty
		{
			[CompilerGenerated]
			get
			{
				return this.<pririty>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<pririty>k__BackingField == value)
				{
					return;
				}
				this.<pririty>k__BackingField = value;
				this.RaisePropertyChanged("pririty");
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x00011278 File Offset: 0x0000F478
		// (set) Token: 0x0600084C RID: 2124 RVA: 0x0001128C File Offset: 0x0000F48C
		public int count
		{
			[CompilerGenerated]
			get
			{
				return this.<count>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<count>k__BackingField == value)
				{
					return;
				}
				this.<count>k__BackingField = value;
				this.RaisePropertyChanged("count");
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x000112B8 File Offset: 0x0000F4B8
		// (set) Token: 0x0600084E RID: 2126 RVA: 0x000112CC File Offset: 0x0000F4CC
		public string item_name
		{
			[CompilerGenerated]
			get
			{
				return this.<item_name>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<item_name>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<item_name>k__BackingField = value;
				this.RaisePropertyChanged("item_name");
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x000112FC File Offset: 0x0000F4FC
		// (set) Token: 0x06000850 RID: 2128 RVA: 0x00011310 File Offset: 0x0000F510
		public string notes
		{
			[CompilerGenerated]
			get
			{
				return this.<notes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<notes>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<notes>k__BackingField = value;
				this.RaisePropertyChanged("notes");
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x00011340 File Offset: 0x0000F540
		// (set) Token: 0x06000852 RID: 2130 RVA: 0x00011354 File Offset: 0x0000F554
		public string url
		{
			[CompilerGenerated]
			get
			{
				return this.<url>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<url>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<url>k__BackingField = value;
				this.RaisePropertyChanged("url");
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000853 RID: 2131 RVA: 0x00011384 File Offset: 0x0000F584
		// (set) Token: 0x06000854 RID: 2132 RVA: 0x00011398 File Offset: 0x0000F598
		public int? dealer
		{
			[CompilerGenerated]
			get
			{
				return this.<dealer>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<dealer>k__BackingField, value))
				{
					return;
				}
				this.<dealer>k__BackingField = value;
				this.RaisePropertyChanged("dealer");
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x000113C8 File Offset: 0x0000F5C8
		// (set) Token: 0x06000856 RID: 2134 RVA: 0x000113DC File Offset: 0x0000F5DC
		public DateTime? end_date
		{
			[CompilerGenerated]
			get
			{
				return this.<end_date>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<DateTime>(this.<end_date>k__BackingField, value))
				{
					return;
				}
				this.<end_date>k__BackingField = value;
				this.RaisePropertyChanged("end_date");
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x0001140C File Offset: 0x0000F60C
		// (set) Token: 0x06000858 RID: 2136 RVA: 0x00011420 File Offset: 0x0000F620
		public DateTime? plan_end_date
		{
			[CompilerGenerated]
			get
			{
				return this.<plan_end_date>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<DateTime>(this.<plan_end_date>k__BackingField, value))
				{
					return;
				}
				this.<plan_end_date>k__BackingField = value;
				this.RaisePropertyChanged("ProgressVisible");
				this.RaisePropertyChanged("Progress");
				this.RaisePropertyChanged("plan_end_date");
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x00011464 File Offset: 0x0000F664
		// (set) Token: 0x0600085A RID: 2138 RVA: 0x00011478 File Offset: 0x0000F678
		public virtual clients clients
		{
			[CompilerGenerated]
			get
			{
				return this.<clients>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<clients>k__BackingField, value))
				{
					return;
				}
				this.<clients>k__BackingField = value;
				this.RaisePropertyChanged("clients");
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x000114A8 File Offset: 0x0000F6A8
		// (set) Token: 0x0600085C RID: 2140 RVA: 0x000114BC File Offset: 0x0000F6BC
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

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x000114EC File Offset: 0x0000F6EC
		// (set) Token: 0x0600085E RID: 2142 RVA: 0x00011500 File Offset: 0x0000F700
		public virtual users users
		{
			[CompilerGenerated]
			get
			{
				return this.<users>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<users>k__BackingField, value))
				{
					return;
				}
				this.<users>k__BackingField = value;
				this.RaisePropertyChanged("users");
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x00011530 File Offset: 0x0000F730
		// (set) Token: 0x06000860 RID: 2144 RVA: 0x00011544 File Offset: 0x0000F744
		public virtual workshop workshop
		{
			[CompilerGenerated]
			get
			{
				return this.<workshop>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<workshop>k__BackingField, value))
				{
					return;
				}
				this.<workshop>k__BackingField = value;
				this.RaisePropertyChanged("workshop");
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x00011574 File Offset: 0x0000F774
		// (set) Token: 0x06000862 RID: 2146 RVA: 0x00011588 File Offset: 0x0000F788
		public virtual ICollection<parts_request_employees> parts_request_employees
		{
			[CompilerGenerated]
			get
			{
				return this.<parts_request_employees>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<parts_request_employees>k__BackingField, value))
				{
					return;
				}
				this.<parts_request_employees>k__BackingField = value;
				this.RaisePropertyChanged("parts_request_employees");
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x000115B8 File Offset: 0x0000F7B8
		// (set) Token: 0x06000864 RID: 2148 RVA: 0x000115CC File Offset: 0x0000F7CC
		public virtual ICollection<logs> logs
		{
			[CompilerGenerated]
			get
			{
				return this.<logs>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<logs>k__BackingField, value))
				{
					return;
				}
				this.<logs>k__BackingField = value;
				this.RaisePropertyChanged("logs");
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x000115FC File Offset: 0x0000F7FC
		// (set) Token: 0x06000866 RID: 2150 RVA: 0x00011610 File Offset: 0x0000F810
		public virtual ICollection<tasks> tasks
		{
			[CompilerGenerated]
			get
			{
				return this.<tasks>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<tasks>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -731921800;
				IL_13:
				switch ((num ^ -2095440882) % 4)
				{
				case 1:
					IL_32:
					this.<tasks>k__BackingField = value;
					num = -1686588158;
					goto IL_13;
				case 2:
					return;
				case 3:
					goto IL_0E;
				}
				this.RaisePropertyChanged("tasks");
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x0001166C File Offset: 0x0000F86C
		// (set) Token: 0x06000868 RID: 2152 RVA: 0x00011680 File Offset: 0x0000F880
		public virtual ICollection<store_items> store_items1
		{
			[CompilerGenerated]
			get
			{
				return this.<store_items1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<store_items1>k__BackingField, value))
				{
					return;
				}
				this.<store_items1>k__BackingField = value;
				this.RaisePropertyChanged("store_items1");
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x000116B0 File Offset: 0x0000F8B0
		// (set) Token: 0x0600086A RID: 2154 RVA: 0x000116C4 File Offset: 0x0000F8C4
		public virtual clients clients1
		{
			[CompilerGenerated]
			get
			{
				return this.<clients1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<clients1>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1335970010;
				IL_13:
				switch ((num ^ -1077204949) % 4)
				{
				case 1:
					return;
				case 2:
					IL_32:
					this.<clients1>k__BackingField = value;
					this.RaisePropertyChanged("clients1");
					num = -2103563349;
					goto IL_13;
				case 3:
					goto IL_0E;
				}
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x00011720 File Offset: 0x0000F920
		// (set) Token: 0x0600086C RID: 2156 RVA: 0x00011734 File Offset: 0x0000F934
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

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x00011764 File Offset: 0x0000F964
		public bool RepairCardVisible
		{
			get
			{
				return this.repair != null;
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x0600086E RID: 2158 RVA: 0x00011780 File Offset: 0x0000F980
		public bool ItemCardVisible
		{
			get
			{
				return this.item_id != null;
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x0600086F RID: 2159 RVA: 0x0001179C File Offset: 0x0000F99C
		public bool ProgressVisible
		{
			get
			{
				return this.plan_end_date != null;
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000870 RID: 2160 RVA: 0x000117B8 File Offset: 0x0000F9B8
		public double Progress
		{
			get
			{
				if (this.plan_end_date == null)
				{
					return 0.0;
				}
				double totalDays = (this.plan_end_date.Value - this.request_time).TotalDays;
				double totalDays2 = (DateTime.Now - this.request_time).TotalDays;
				if (totalDays2 <= totalDays)
				{
					return Math.Round(100.0 / totalDays * totalDays2, 2);
				}
				return 100.0;
			}
		}

		// Token: 0x040003ED RID: 1005
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x040003EE RID: 1006
		[CompilerGenerated]
		private DateTime <request_time>k__BackingField;

		// Token: 0x040003EF RID: 1007
		[CompilerGenerated]
		private int <from_user>k__BackingField;

		// Token: 0x040003F0 RID: 1008
		[CompilerGenerated]
		private int? <repair>k__BackingField;

		// Token: 0x040003F1 RID: 1009
		[CompilerGenerated]
		private int? <client>k__BackingField;

		// Token: 0x040003F2 RID: 1010
		[CompilerGenerated]
		private int <state>k__BackingField;

		// Token: 0x040003F3 RID: 1011
		[CompilerGenerated]
		private decimal? <summ>k__BackingField;

		// Token: 0x040003F4 RID: 1012
		[CompilerGenerated]
		private string <tracking>k__BackingField;

		// Token: 0x040003F5 RID: 1013
		[CompilerGenerated]
		private int? <item_id>k__BackingField;

		// Token: 0x040003F6 RID: 1014
		[CompilerGenerated]
		private int <pririty>k__BackingField;

		// Token: 0x040003F7 RID: 1015
		[CompilerGenerated]
		private int <count>k__BackingField;

		// Token: 0x040003F8 RID: 1016
		[CompilerGenerated]
		private string <item_name>k__BackingField;

		// Token: 0x040003F9 RID: 1017
		[CompilerGenerated]
		private string <notes>k__BackingField;

		// Token: 0x040003FA RID: 1018
		[CompilerGenerated]
		private string <url>k__BackingField;

		// Token: 0x040003FB RID: 1019
		[CompilerGenerated]
		private int? <dealer>k__BackingField;

		// Token: 0x040003FC RID: 1020
		[CompilerGenerated]
		private DateTime? <end_date>k__BackingField;

		// Token: 0x040003FD RID: 1021
		[CompilerGenerated]
		private DateTime? <plan_end_date>k__BackingField;

		// Token: 0x040003FE RID: 1022
		[CompilerGenerated]
		private clients <clients>k__BackingField;

		// Token: 0x040003FF RID: 1023
		[CompilerGenerated]
		private store_items <store_items>k__BackingField;

		// Token: 0x04000400 RID: 1024
		[CompilerGenerated]
		private users <users>k__BackingField;

		// Token: 0x04000401 RID: 1025
		[CompilerGenerated]
		private workshop <workshop>k__BackingField;

		// Token: 0x04000402 RID: 1026
		[CompilerGenerated]
		private ICollection<parts_request_employees> <parts_request_employees>k__BackingField;

		// Token: 0x04000403 RID: 1027
		[CompilerGenerated]
		private ICollection<logs> <logs>k__BackingField;

		// Token: 0x04000404 RID: 1028
		[CompilerGenerated]
		private ICollection<tasks> <tasks>k__BackingField;

		// Token: 0x04000405 RID: 1029
		[CompilerGenerated]
		private ICollection<store_items> <store_items1>k__BackingField;

		// Token: 0x04000406 RID: 1030
		[CompilerGenerated]
		private clients <clients1>k__BackingField;

		// Token: 0x04000407 RID: 1031
		[CompilerGenerated]
		private ICollection<notifications> <notifications>k__BackingField;
	}
}
