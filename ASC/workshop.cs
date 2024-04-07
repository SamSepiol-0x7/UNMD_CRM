using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using ASC.Extensions;
using ASC.Options;
using ASC.SimpleClasses;
using DevExpress.Mvvm;

namespace ASC
{
	// Token: 0x02000089 RID: 137
	public class workshop : BindableBase
	{
		// Token: 0x060010D4 RID: 4308 RVA: 0x0001E810 File Offset: 0x0001CA10
		public workshop()
		{
			this.repair_cost = 0m;
			this.workshop_parts = new HashSet<workshop_parts>();
			this.docs = new HashSet<docs>();
			this.works = new HashSet<works>();
			this.logs = new HashSet<logs>();
			this.media_info = new HashSet<media_info>();
			this.cash_orders = new HashSet<cash_orders>();
			this.field_values = new HashSet<field_values>();
			this.workshop1 = new HashSet<workshop>();
			this.store_int_reserve = new HashSet<store_int_reserve>();
			this.parts_request = new HashSet<parts_request>();
			this.comments = new HashSet<comments>();
			this.invoice_items = new HashSet<invoice_items>();
			this.notifications = new HashSet<notifications>();
			this.workshop_issued = new HashSet<workshop_issued>();
			this.repair_status_logs = new HashSet<repair_status_logs>();
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x060010D5 RID: 4309 RVA: 0x0001E8FC File Offset: 0x0001CAFC
		// (set) Token: 0x060010D6 RID: 4310 RVA: 0x0001E910 File Offset: 0x0001CB10
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
				int num = -1229424613;
				IL_10:
				switch ((num ^ -677888898) % 4)
				{
				case 1:
					return;
				case 2:
					IL_2F:
					this.<id>k__BackingField = value;
					this.RaisePropertyChanged("id");
					num = -2017904750;
					goto IL_10;
				case 3:
					goto IL_0B;
				}
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x060010D7 RID: 4311 RVA: 0x0001E968 File Offset: 0x0001CB68
		// (set) Token: 0x060010D8 RID: 4312 RVA: 0x0001E97C File Offset: 0x0001CB7C
		public int client
		{
			[CompilerGenerated]
			get
			{
				return this.<client>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<client>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = 1121629991;
				IL_10:
				switch ((num ^ 335966070) % 4)
				{
				case 1:
					return;
				case 2:
					goto IL_0B;
				case 3:
					IL_2F:
					this.<client>k__BackingField = value;
					this.RaisePropertyChanged("client");
					num = 1727749766;
					goto IL_10;
				}
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x060010D9 RID: 4313 RVA: 0x0001E9D4 File Offset: 0x0001CBD4
		// (set) Token: 0x060010DA RID: 4314 RVA: 0x0001E9E8 File Offset: 0x0001CBE8
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
				this.RaisePropertyChanged("type");
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x060010DB RID: 4315 RVA: 0x0001EA14 File Offset: 0x0001CC14
		// (set) Token: 0x060010DC RID: 4316 RVA: 0x0001EA28 File Offset: 0x0001CC28
		public int maker
		{
			[CompilerGenerated]
			get
			{
				return this.<maker>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<maker>k__BackingField == value)
				{
					return;
				}
				this.<maker>k__BackingField = value;
				this.RaisePropertyChanged("maker");
			}
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x060010DD RID: 4317 RVA: 0x0001EA54 File Offset: 0x0001CC54
		// (set) Token: 0x060010DE RID: 4318 RVA: 0x0001EA68 File Offset: 0x0001CC68
		public int? model
		{
			[CompilerGenerated]
			get
			{
				return this.<model>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<model>k__BackingField, value))
				{
					return;
				}
				this.<model>k__BackingField = value;
				this.RaisePropertyChanged("model");
			}
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x060010DF RID: 4319 RVA: 0x0001EA98 File Offset: 0x0001CC98
		// (set) Token: 0x060010E0 RID: 4320 RVA: 0x0001EAAC File Offset: 0x0001CCAC
		public string serial_number
		{
			[CompilerGenerated]
			get
			{
				return this.<serial_number>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<serial_number>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<serial_number>k__BackingField = value;
				this.RaisePropertyChanged("serial_number");
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x060010E1 RID: 4321 RVA: 0x0001EADC File Offset: 0x0001CCDC
		// (set) Token: 0x060010E2 RID: 4322 RVA: 0x0001EAF0 File Offset: 0x0001CCF0
		public int company
		{
			[CompilerGenerated]
			get
			{
				return this.<company>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<company>k__BackingField == value)
				{
					return;
				}
				this.<company>k__BackingField = value;
				this.RaisePropertyChanged("company");
			}
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x060010E3 RID: 4323 RVA: 0x0001EB1C File Offset: 0x0001CD1C
		// (set) Token: 0x060010E4 RID: 4324 RVA: 0x0001EB30 File Offset: 0x0001CD30
		public int office
		{
			[CompilerGenerated]
			get
			{
				return this.<office>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<office>k__BackingField == value)
				{
					return;
				}
				this.<office>k__BackingField = value;
				this.RaisePropertyChanged("office");
			}
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x060010E5 RID: 4325 RVA: 0x0001EB5C File Offset: 0x0001CD5C
		// (set) Token: 0x060010E6 RID: 4326 RVA: 0x0001EB70 File Offset: 0x0001CD70
		public int start_office
		{
			[CompilerGenerated]
			get
			{
				return this.<start_office>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<start_office>k__BackingField == value)
				{
					return;
				}
				this.<start_office>k__BackingField = value;
				this.RaisePropertyChanged("start_office");
			}
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x060010E7 RID: 4327 RVA: 0x0001EB9C File Offset: 0x0001CD9C
		// (set) Token: 0x060010E8 RID: 4328 RVA: 0x0001EBB0 File Offset: 0x0001CDB0
		public int manager
		{
			[CompilerGenerated]
			get
			{
				return this.<manager>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<manager>k__BackingField == value)
				{
					return;
				}
				this.<manager>k__BackingField = value;
				this.RaisePropertyChanged("manager");
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x060010E9 RID: 4329 RVA: 0x0001EBDC File Offset: 0x0001CDDC
		// (set) Token: 0x060010EA RID: 4330 RVA: 0x0001EBF0 File Offset: 0x0001CDF0
		public int current_manager
		{
			[CompilerGenerated]
			get
			{
				return this.<current_manager>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<current_manager>k__BackingField == value)
				{
					return;
				}
				this.<current_manager>k__BackingField = value;
				this.RaisePropertyChanged("current_manager");
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x060010EB RID: 4331 RVA: 0x0001EC1C File Offset: 0x0001CE1C
		// (set) Token: 0x060010EC RID: 4332 RVA: 0x0001EC30 File Offset: 0x0001CE30
		public int? master
		{
			[CompilerGenerated]
			get
			{
				return this.<master>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!Nullable.Equals<int>(this.<master>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 574744974;
				IL_13:
				switch ((num ^ 653663483) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					return;
				case 2:
					IL_32:
					num = 1201739928;
					goto IL_13;
				}
				this.<master>k__BackingField = value;
				this.RaisePropertyChanged("master");
			}
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x060010ED RID: 4333 RVA: 0x0001EC8C File Offset: 0x0001CE8C
		// (set) Token: 0x060010EE RID: 4334 RVA: 0x0001ECA0 File Offset: 0x0001CEA0
		public string diagnostic_result
		{
			[CompilerGenerated]
			get
			{
				return this.<diagnostic_result>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<diagnostic_result>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<diagnostic_result>k__BackingField = value;
				this.RaisePropertyChanged("diagnostic_result");
			}
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x060010EF RID: 4335 RVA: 0x0001ECD0 File Offset: 0x0001CED0
		// (set) Token: 0x060010F0 RID: 4336 RVA: 0x0001ECE4 File Offset: 0x0001CEE4
		public DateTime in_date
		{
			[CompilerGenerated]
			get
			{
				return this.<in_date>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (DateTime.Equals(this.<in_date>k__BackingField, value))
				{
					return;
				}
				this.<in_date>k__BackingField = value;
				this.RaisePropertyChanged("RepairProgress");
				this.RaisePropertyChanged("InDateTime");
				this.RaisePropertyChanged("InRepairDays");
				this.RaisePropertyChanged("in_date");
			}
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x060010F1 RID: 4337 RVA: 0x0001ED34 File Offset: 0x0001CF34
		// (set) Token: 0x060010F2 RID: 4338 RVA: 0x0001ED48 File Offset: 0x0001CF48
		public DateTime? out_date
		{
			[CompilerGenerated]
			get
			{
				return this.<out_date>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<DateTime>(this.<out_date>k__BackingField, value))
				{
					return;
				}
				this.<out_date>k__BackingField = value;
				this.RaisePropertyChanged("WarrantyUpTo");
				this.RaisePropertyChanged("RepairProgress");
				this.RaisePropertyChanged("OutDateTime");
				this.RaisePropertyChanged("OutDateVisible");
				this.RaisePropertyChanged("WarrantyVisible");
				this.RaisePropertyChanged("out_date");
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x060010F3 RID: 4339 RVA: 0x0001EDB0 File Offset: 0x0001CFB0
		// (set) Token: 0x060010F4 RID: 4340 RVA: 0x0001EDC4 File Offset: 0x0001CFC4
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
				this.RaisePropertyChanged("Ready2Issue");
				this.RaisePropertyChanged("Ready2IssueWithoutRepair");
				this.RaisePropertyChanged("WarrantyVisible");
				this.RaisePropertyChanged("StateColor");
				this.RaisePropertyChanged("state");
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x060010F5 RID: 4341 RVA: 0x0001EE1C File Offset: 0x0001D01C
		// (set) Token: 0x060010F6 RID: 4342 RVA: 0x0001EE30 File Offset: 0x0001D030
		public int? user_lock
		{
			[CompilerGenerated]
			get
			{
				return this.<user_lock>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<user_lock>k__BackingField, value))
				{
					return;
				}
				this.<user_lock>k__BackingField = value;
				this.RaisePropertyChanged("LockUserFio");
				this.RaisePropertyChanged("IsLocked");
				this.RaisePropertyChanged("user_lock");
			}
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x060010F7 RID: 4343 RVA: 0x0001EE74 File Offset: 0x0001D074
		// (set) Token: 0x060010F8 RID: 4344 RVA: 0x0001EE88 File Offset: 0x0001D088
		public DateTime? lock_datetime
		{
			[CompilerGenerated]
			get
			{
				return this.<lock_datetime>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<DateTime>(this.<lock_datetime>k__BackingField, value))
				{
					return;
				}
				this.<lock_datetime>k__BackingField = value;
				this.RaisePropertyChanged("IsLocked");
				this.RaisePropertyChanged("lock_datetime");
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x060010F9 RID: 4345 RVA: 0x0001EEC4 File Offset: 0x0001D0C4
		// (set) Token: 0x060010FA RID: 4346 RVA: 0x0001EED8 File Offset: 0x0001D0D8
		public bool? express_repair
		{
			[CompilerGenerated]
			get
			{
				return this.<express_repair>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<bool>(this.<express_repair>k__BackingField, value))
				{
					return;
				}
				this.<express_repair>k__BackingField = value;
				this.RaisePropertyChanged("express_repair");
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x060010FB RID: 4347 RVA: 0x0001EF08 File Offset: 0x0001D108
		// (set) Token: 0x060010FC RID: 4348 RVA: 0x0001EF1C File Offset: 0x0001D11C
		public bool is_warranty
		{
			[CompilerGenerated]
			get
			{
				return this.<is_warranty>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<is_warranty>k__BackingField == value)
				{
					return;
				}
				this.<is_warranty>k__BackingField = value;
				this.RaisePropertyChanged("is_warranty");
			}
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x060010FD RID: 4349 RVA: 0x0001EF48 File Offset: 0x0001D148
		// (set) Token: 0x060010FE RID: 4350 RVA: 0x0001EF5C File Offset: 0x0001D15C
		public bool is_repeat
		{
			[CompilerGenerated]
			get
			{
				return this.<is_repeat>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<is_repeat>k__BackingField == value)
				{
					return;
				}
				this.<is_repeat>k__BackingField = value;
				this.RaisePropertyChanged("is_repeat");
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x060010FF RID: 4351 RVA: 0x0001EF88 File Offset: 0x0001D188
		// (set) Token: 0x06001100 RID: 4352 RVA: 0x0001EF9C File Offset: 0x0001D19C
		public bool can_format
		{
			[CompilerGenerated]
			get
			{
				return this.<can_format>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<can_format>k__BackingField == value)
				{
					return;
				}
				this.<can_format>k__BackingField = value;
				this.RaisePropertyChanged("can_format");
			}
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06001101 RID: 4353 RVA: 0x0001EFC8 File Offset: 0x0001D1C8
		// (set) Token: 0x06001102 RID: 4354 RVA: 0x0001EFDC File Offset: 0x0001D1DC
		public bool print_check
		{
			[CompilerGenerated]
			get
			{
				return this.<print_check>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<print_check>k__BackingField == value)
				{
					return;
				}
				this.<print_check>k__BackingField = value;
				this.RaisePropertyChanged("print_check");
			}
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06001103 RID: 4355 RVA: 0x0001F008 File Offset: 0x0001D208
		// (set) Token: 0x06001104 RID: 4356 RVA: 0x0001F01C File Offset: 0x0001D21C
		public int? box
		{
			[CompilerGenerated]
			get
			{
				return this.<box>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<box>k__BackingField, value))
				{
					return;
				}
				this.<box>k__BackingField = value;
				this.RaisePropertyChanged("box");
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06001105 RID: 4357 RVA: 0x0001F04C File Offset: 0x0001D24C
		// (set) Token: 0x06001106 RID: 4358 RVA: 0x0001F060 File Offset: 0x0001D260
		public string warranty_label
		{
			[CompilerGenerated]
			get
			{
				return this.<warranty_label>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<warranty_label>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<warranty_label>k__BackingField = value;
				this.RaisePropertyChanged("warranty_label");
			}
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06001107 RID: 4359 RVA: 0x0001F090 File Offset: 0x0001D290
		// (set) Token: 0x06001108 RID: 4360 RVA: 0x0001F0A4 File Offset: 0x0001D2A4
		public string ext_notes
		{
			[CompilerGenerated]
			get
			{
				return this.<ext_notes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<ext_notes>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<ext_notes>k__BackingField = value;
				this.RaisePropertyChanged("ext_notes");
			}
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06001109 RID: 4361 RVA: 0x0001F0D4 File Offset: 0x0001D2D4
		// (set) Token: 0x0600110A RID: 4362 RVA: 0x0001F0E8 File Offset: 0x0001D2E8
		public bool is_prepaid
		{
			[CompilerGenerated]
			get
			{
				return this.<is_prepaid>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<is_prepaid>k__BackingField == value)
				{
					return;
				}
				this.<is_prepaid>k__BackingField = value;
				this.RaisePropertyChanged("is_prepaid");
			}
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x0600110B RID: 4363 RVA: 0x0001F114 File Offset: 0x0001D314
		// (set) Token: 0x0600110C RID: 4364 RVA: 0x0001F128 File Offset: 0x0001D328
		public int prepaid_type
		{
			[CompilerGenerated]
			get
			{
				return this.<prepaid_type>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<prepaid_type>k__BackingField == value)
				{
					return;
				}
				this.<prepaid_type>k__BackingField = value;
				this.RaisePropertyChanged("prepaid_type");
			}
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x0600110D RID: 4365 RVA: 0x0001F154 File Offset: 0x0001D354
		// (set) Token: 0x0600110E RID: 4366 RVA: 0x0001F168 File Offset: 0x0001D368
		public decimal prepaid_summ
		{
			[CompilerGenerated]
			get
			{
				return this.<prepaid_summ>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<prepaid_summ>k__BackingField, value))
				{
					return;
				}
				this.<prepaid_summ>k__BackingField = value;
				this.RaisePropertyChanged("prepaid_summ");
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x0600110F RID: 4367 RVA: 0x0001F198 File Offset: 0x0001D398
		// (set) Token: 0x06001110 RID: 4368 RVA: 0x0001F1AC File Offset: 0x0001D3AC
		public int? prepaid_order
		{
			[CompilerGenerated]
			get
			{
				return this.<prepaid_order>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<prepaid_order>k__BackingField, value))
				{
					return;
				}
				this.<prepaid_order>k__BackingField = value;
				this.RaisePropertyChanged("prepaid_order");
			}
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06001111 RID: 4369 RVA: 0x0001F1DC File Offset: 0x0001D3DC
		// (set) Token: 0x06001112 RID: 4370 RVA: 0x0001F1F0 File Offset: 0x0001D3F0
		public bool is_pre_agreed
		{
			[CompilerGenerated]
			get
			{
				return this.<is_pre_agreed>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<is_pre_agreed>k__BackingField == value)
				{
					return;
				}
				this.<is_pre_agreed>k__BackingField = value;
				this.RaisePropertyChanged("is_pre_agreed");
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06001113 RID: 4371 RVA: 0x0001F21C File Offset: 0x0001D41C
		// (set) Token: 0x06001114 RID: 4372 RVA: 0x0001F230 File Offset: 0x0001D430
		public decimal? pre_agreed_amount
		{
			[CompilerGenerated]
			get
			{
				return this.<pre_agreed_amount>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<decimal>(this.<pre_agreed_amount>k__BackingField, value))
				{
					return;
				}
				this.<pre_agreed_amount>k__BackingField = value;
				this.RaisePropertyChanged("pre_agreed_amount");
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06001115 RID: 4373 RVA: 0x0001F260 File Offset: 0x0001D460
		// (set) Token: 0x06001116 RID: 4374 RVA: 0x0001F274 File Offset: 0x0001D474
		public decimal repair_cost
		{
			[CompilerGenerated]
			get
			{
				return this.<repair_cost>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<repair_cost>k__BackingField, value))
				{
					return;
				}
				this.<repair_cost>k__BackingField = value;
				this.RaisePropertyChanged("ShowRepairCost");
				this.RaisePropertyChanged("repair_cost");
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06001117 RID: 4375 RVA: 0x0001F2B0 File Offset: 0x0001D4B0
		// (set) Token: 0x06001118 RID: 4376 RVA: 0x0001F2C4 File Offset: 0x0001D4C4
		public string fault
		{
			[CompilerGenerated]
			get
			{
				return this.<fault>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<fault>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<fault>k__BackingField = value;
				this.RaisePropertyChanged("fault");
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06001119 RID: 4377 RVA: 0x0001F2F4 File Offset: 0x0001D4F4
		// (set) Token: 0x0600111A RID: 4378 RVA: 0x0001F308 File Offset: 0x0001D508
		public string complect
		{
			[CompilerGenerated]
			get
			{
				return this.<complect>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<complect>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<complect>k__BackingField = value;
				this.RaisePropertyChanged("complect");
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x0600111B RID: 4379 RVA: 0x0001F338 File Offset: 0x0001D538
		// (set) Token: 0x0600111C RID: 4380 RVA: 0x0001F34C File Offset: 0x0001D54C
		public string look
		{
			[CompilerGenerated]
			get
			{
				return this.<look>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<look>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<look>k__BackingField = value;
				this.RaisePropertyChanged("look");
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x0600111D RID: 4381 RVA: 0x0001F37C File Offset: 0x0001D57C
		// (set) Token: 0x0600111E RID: 4382 RVA: 0x0001F390 File Offset: 0x0001D590
		public bool thirs_party_sc
		{
			[CompilerGenerated]
			get
			{
				return this.<thirs_party_sc>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<thirs_party_sc>k__BackingField == value)
				{
					return;
				}
				this.<thirs_party_sc>k__BackingField = value;
				this.RaisePropertyChanged("thirs_party_sc");
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x0600111F RID: 4383 RVA: 0x0001F3BC File Offset: 0x0001D5BC
		// (set) Token: 0x06001120 RID: 4384 RVA: 0x0001F3D0 File Offset: 0x0001D5D0
		public DateTime? last_save
		{
			[CompilerGenerated]
			get
			{
				return this.<last_save>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<DateTime>(this.<last_save>k__BackingField, value))
				{
					return;
				}
				this.<last_save>k__BackingField = value;
				this.RaisePropertyChanged("last_save");
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06001121 RID: 4385 RVA: 0x0001F400 File Offset: 0x0001D600
		// (set) Token: 0x06001122 RID: 4386 RVA: 0x0001F414 File Offset: 0x0001D614
		public DateTime? last_status_changed
		{
			[CompilerGenerated]
			get
			{
				return this.<last_status_changed>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<DateTime>(this.<last_status_changed>k__BackingField, value))
				{
					return;
				}
				this.<last_status_changed>k__BackingField = value;
				this.RaisePropertyChanged("last_status_changed");
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06001123 RID: 4387 RVA: 0x0001F444 File Offset: 0x0001D644
		// (set) Token: 0x06001124 RID: 4388 RVA: 0x0001F458 File Offset: 0x0001D658
		public int warranty_days
		{
			[CompilerGenerated]
			get
			{
				return this.<warranty_days>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<warranty_days>k__BackingField == value)
				{
					return;
				}
				this.<warranty_days>k__BackingField = value;
				this.RaisePropertyChanged("WarrantyUpTo");
				this.RaisePropertyChanged("WarrantyVisible");
				this.RaisePropertyChanged("warranty_days");
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06001125 RID: 4389 RVA: 0x0001F49C File Offset: 0x0001D69C
		// (set) Token: 0x06001126 RID: 4390 RVA: 0x0001F4B0 File Offset: 0x0001D6B0
		public string barcode
		{
			[CompilerGenerated]
			get
			{
				return this.<barcode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<barcode>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<barcode>k__BackingField = value;
				this.RaisePropertyChanged("barcode");
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06001127 RID: 4391 RVA: 0x0001F4E0 File Offset: 0x0001D6E0
		// (set) Token: 0x06001128 RID: 4392 RVA: 0x0001F4F4 File Offset: 0x0001D6F4
		public int new_state
		{
			[CompilerGenerated]
			get
			{
				return this.<new_state>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<new_state>k__BackingField == value)
				{
					return;
				}
				this.<new_state>k__BackingField = value;
				this.RaisePropertyChanged("new_state");
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06001129 RID: 4393 RVA: 0x0001F520 File Offset: 0x0001D720
		// (set) Token: 0x0600112A RID: 4394 RVA: 0x0001F534 File Offset: 0x0001D734
		public bool is_card_payment
		{
			[CompilerGenerated]
			get
			{
				return this.<is_card_payment>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<is_card_payment>k__BackingField == value)
				{
					return;
				}
				this.<is_card_payment>k__BackingField = value;
				this.RaisePropertyChanged("is_card_payment");
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x0600112B RID: 4395 RVA: 0x0001F560 File Offset: 0x0001D760
		// (set) Token: 0x0600112C RID: 4396 RVA: 0x0001F574 File Offset: 0x0001D774
		public int informed_status
		{
			[CompilerGenerated]
			get
			{
				return this.<informed_status>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<informed_status>k__BackingField == value)
				{
					return;
				}
				this.<informed_status>k__BackingField = value;
				this.RaisePropertyChanged("informed_status");
			}
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x0600112D RID: 4397 RVA: 0x0001F5A0 File Offset: 0x0001D7A0
		// (set) Token: 0x0600112E RID: 4398 RVA: 0x0001F5B4 File Offset: 0x0001D7B4
		public decimal parts_cost
		{
			[CompilerGenerated]
			get
			{
				return this.<parts_cost>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<parts_cost>k__BackingField, value))
				{
					return;
				}
				this.<parts_cost>k__BackingField = value;
				this.RaisePropertyChanged("ProfitSumm");
				this.RaisePropertyChanged("parts_cost");
			}
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x0600112F RID: 4399 RVA: 0x0001F5F0 File Offset: 0x0001D7F0
		// (set) Token: 0x06001130 RID: 4400 RVA: 0x0001F604 File Offset: 0x0001D804
		public bool is_debt
		{
			[CompilerGenerated]
			get
			{
				return this.<is_debt>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<is_debt>k__BackingField == value)
				{
					return;
				}
				this.<is_debt>k__BackingField = value;
				this.RaisePropertyChanged("is_debt");
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06001131 RID: 4401 RVA: 0x0001F630 File Offset: 0x0001D830
		// (set) Token: 0x06001132 RID: 4402 RVA: 0x0001F644 File Offset: 0x0001D844
		public string image_ids
		{
			[CompilerGenerated]
			get
			{
				return this.<image_ids>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<image_ids>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<image_ids>k__BackingField = value;
				this.RaisePropertyChanged("image_ids");
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06001133 RID: 4403 RVA: 0x0001F674 File Offset: 0x0001D874
		// (set) Token: 0x06001134 RID: 4404 RVA: 0x0001F688 File Offset: 0x0001D888
		public string color
		{
			[CompilerGenerated]
			get
			{
				return this.<color>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<color>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<color>k__BackingField = value;
				this.RaisePropertyChanged("Color");
				this.RaisePropertyChanged("color");
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06001135 RID: 4405 RVA: 0x0001F6C4 File Offset: 0x0001D8C4
		// (set) Token: 0x06001136 RID: 4406 RVA: 0x0001F6D8 File Offset: 0x0001D8D8
		public string order_moving
		{
			[CompilerGenerated]
			get
			{
				return this.<order_moving>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<order_moving>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<order_moving>k__BackingField = value;
				this.RaisePropertyChanged("order_moving");
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06001137 RID: 4407 RVA: 0x0001F708 File Offset: 0x0001D908
		// (set) Token: 0x06001138 RID: 4408 RVA: 0x0001F71C File Offset: 0x0001D91C
		public int payment_system
		{
			[CompilerGenerated]
			get
			{
				return this.<payment_system>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<payment_system>k__BackingField == value)
				{
					return;
				}
				this.<payment_system>k__BackingField = value;
				this.RaisePropertyChanged("IsCashLess");
				this.RaisePropertyChanged("payment_system");
			}
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06001139 RID: 4409 RVA: 0x0001F754 File Offset: 0x0001D954
		// (set) Token: 0x0600113A RID: 4410 RVA: 0x0001F768 File Offset: 0x0001D968
		public int? early
		{
			[CompilerGenerated]
			get
			{
				return this.<early>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<early>k__BackingField, value))
				{
					return;
				}
				this.<early>k__BackingField = value;
				this.RaisePropertyChanged("early");
			}
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x0600113B RID: 4411 RVA: 0x0001F798 File Offset: 0x0001D998
		// (set) Token: 0x0600113C RID: 4412 RVA: 0x0001F7AC File Offset: 0x0001D9AC
		public decimal real_repair_cost
		{
			[CompilerGenerated]
			get
			{
				return this.<real_repair_cost>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<real_repair_cost>k__BackingField, value))
				{
					return;
				}
				this.<real_repair_cost>k__BackingField = value;
				this.RaisePropertyChanged("TotalRepairCost");
				this.RaisePropertyChanged("ProfitSumm");
				this.RaisePropertyChanged("ShowRepairCost");
				this.RaisePropertyChanged("real_repair_cost");
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x0600113D RID: 4413 RVA: 0x0001F7FC File Offset: 0x0001D9FC
		// (set) Token: 0x0600113E RID: 4414 RVA: 0x0001F810 File Offset: 0x0001DA10
		public string issued_msg
		{
			[CompilerGenerated]
			get
			{
				return this.<issued_msg>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<issued_msg>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<issued_msg>k__BackingField = value;
				this.RaisePropertyChanged("issued_msg");
			}
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x0600113F RID: 4415 RVA: 0x0001F840 File Offset: 0x0001DA40
		// (set) Token: 0x06001140 RID: 4416 RVA: 0x0001F854 File Offset: 0x0001DA54
		public string reject_reason
		{
			[CompilerGenerated]
			get
			{
				return this.<reject_reason>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<reject_reason>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<reject_reason>k__BackingField = value;
				this.RaisePropertyChanged("reject_reason");
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06001141 RID: 4417 RVA: 0x0001F884 File Offset: 0x0001DA84
		// (set) Token: 0x06001142 RID: 4418 RVA: 0x0001F898 File Offset: 0x0001DA98
		public string ext_early
		{
			[CompilerGenerated]
			get
			{
				return this.<ext_early>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<ext_early>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<ext_early>k__BackingField = value;
				this.RaisePropertyChanged("ext_early");
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06001143 RID: 4419 RVA: 0x0001F8C8 File Offset: 0x0001DAC8
		// (set) Token: 0x06001144 RID: 4420 RVA: 0x0001F8DC File Offset: 0x0001DADC
		public bool sms_inform
		{
			[CompilerGenerated]
			get
			{
				return this.<sms_inform>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<sms_inform>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -1932758275;
				IL_10:
				switch ((num ^ -446999624) % 4)
				{
				case 0:
					goto IL_0B;
				case 1:
					return;
				case 2:
					IL_2F:
					num = -533980789;
					goto IL_10;
				}
				this.<sms_inform>k__BackingField = value;
				this.RaisePropertyChanged("sms_inform");
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06001145 RID: 4421 RVA: 0x0001F934 File Offset: 0x0001DB34
		// (set) Token: 0x06001146 RID: 4422 RVA: 0x0001F948 File Offset: 0x0001DB48
		public int? invoice
		{
			[CompilerGenerated]
			get
			{
				return this.<invoice>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<invoice>k__BackingField, value))
				{
					return;
				}
				this.<invoice>k__BackingField = value;
				this.RaisePropertyChanged("invoice");
			}
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06001147 RID: 4423 RVA: 0x0001F978 File Offset: 0x0001DB78
		// (set) Token: 0x06001148 RID: 4424 RVA: 0x0001F98C File Offset: 0x0001DB8C
		public int? cartridge
		{
			[CompilerGenerated]
			get
			{
				return this.<cartridge>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<cartridge>k__BackingField, value))
				{
					return;
				}
				this.<cartridge>k__BackingField = value;
				this.RaisePropertyChanged("DeviceOverview");
				this.RaisePropertyChanged("MasterPart");
				this.RaisePropertyChanged("cartridge");
			}
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06001149 RID: 4425 RVA: 0x0001F9D0 File Offset: 0x0001DBD0
		// (set) Token: 0x0600114A RID: 4426 RVA: 0x0001F9E4 File Offset: 0x0001DBE4
		public bool termsControl
		{
			[CompilerGenerated]
			get
			{
				return this.<termsControl>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<termsControl>k__BackingField == value)
				{
					return;
				}
				this.<termsControl>k__BackingField = value;
				this.RaisePropertyChanged("termsControl");
			}
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x0600114B RID: 4427 RVA: 0x0001FA10 File Offset: 0x0001DC10
		// (set) Token: 0x0600114C RID: 4428 RVA: 0x0001FA24 File Offset: 0x0001DC24
		public int? vendor_id
		{
			[CompilerGenerated]
			get
			{
				return this.<vendor_id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<vendor_id>k__BackingField, value))
				{
					return;
				}
				this.<vendor_id>k__BackingField = value;
				this.RaisePropertyChanged("vendor_id");
			}
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x0600114D RID: 4429 RVA: 0x0001FA54 File Offset: 0x0001DC54
		// (set) Token: 0x0600114E RID: 4430 RVA: 0x0001FA68 File Offset: 0x0001DC68
		public bool quick_repair
		{
			[CompilerGenerated]
			get
			{
				return this.<quick_repair>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<quick_repair>k__BackingField == value)
				{
					return;
				}
				this.<quick_repair>k__BackingField = value;
				this.RaisePropertyChanged("MasterPart");
				this.RaisePropertyChanged("quick_repair");
			}
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x0600114F RID: 4431 RVA: 0x0001FAA0 File Offset: 0x0001DCA0
		// (set) Token: 0x06001150 RID: 4432 RVA: 0x0001FAB4 File Offset: 0x0001DCB4
		public bool Hidden
		{
			[CompilerGenerated]
			get
			{
				return this.<Hidden>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Hidden>k__BackingField == value)
				{
					return;
				}
				this.<Hidden>k__BackingField = value;
				this.RaisePropertyChanged("Hidden");
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06001151 RID: 4433 RVA: 0x0001FAE0 File Offset: 0x0001DCE0
		// (set) Token: 0x06001152 RID: 4434 RVA: 0x0001FAF4 File Offset: 0x0001DCF4
		public string Title
		{
			[CompilerGenerated]
			get
			{
				return this.<Title>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Title>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Title>k__BackingField = value;
				this.RaisePropertyChanged("Title");
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06001153 RID: 4435 RVA: 0x0001FB24 File Offset: 0x0001DD24
		// (set) Token: 0x06001154 RID: 4436 RVA: 0x0001FB38 File Offset: 0x0001DD38
		public virtual device_makers device_makers
		{
			[CompilerGenerated]
			get
			{
				return this.<device_makers>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<device_makers>k__BackingField, value))
				{
					return;
				}
				this.<device_makers>k__BackingField = value;
				this.RaisePropertyChanged("DeviceOverview");
				this.RaisePropertyChanged("device_makers");
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06001155 RID: 4437 RVA: 0x0001FB74 File Offset: 0x0001DD74
		// (set) Token: 0x06001156 RID: 4438 RVA: 0x0001FB88 File Offset: 0x0001DD88
		public virtual device_models device_models
		{
			[CompilerGenerated]
			get
			{
				return this.<device_models>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<device_models>k__BackingField, value))
				{
					return;
				}
				this.<device_models>k__BackingField = value;
				this.RaisePropertyChanged("DeviceOverview");
				this.RaisePropertyChanged("device_models");
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06001157 RID: 4439 RVA: 0x0001FBC4 File Offset: 0x0001DDC4
		// (set) Token: 0x06001158 RID: 4440 RVA: 0x0001FBD8 File Offset: 0x0001DDD8
		public virtual ICollection<workshop_parts> workshop_parts
		{
			[CompilerGenerated]
			get
			{
				return this.<workshop_parts>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<workshop_parts>k__BackingField, value))
				{
					return;
				}
				this.<workshop_parts>k__BackingField = value;
				this.RaisePropertyChanged("workshop_parts");
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06001159 RID: 4441 RVA: 0x0001FC08 File Offset: 0x0001DE08
		// (set) Token: 0x0600115A RID: 4442 RVA: 0x0001FC1C File Offset: 0x0001DE1C
		public virtual devices devices
		{
			[CompilerGenerated]
			get
			{
				return this.<devices>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<devices>k__BackingField, value))
				{
					return;
				}
				this.<devices>k__BackingField = value;
				this.RaisePropertyChanged("DeviceOverview");
				this.RaisePropertyChanged("devices");
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x0600115B RID: 4443 RVA: 0x0001FC58 File Offset: 0x0001DE58
		// (set) Token: 0x0600115C RID: 4444 RVA: 0x0001FC6C File Offset: 0x0001DE6C
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
				if (object.Equals(this.<docs>k__BackingField, value))
				{
					return;
				}
				this.<docs>k__BackingField = value;
				this.RaisePropertyChanged("docs");
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x0600115D RID: 4445 RVA: 0x0001FC9C File Offset: 0x0001DE9C
		// (set) Token: 0x0600115E RID: 4446 RVA: 0x0001FCB0 File Offset: 0x0001DEB0
		public virtual ICollection<works> works
		{
			[CompilerGenerated]
			get
			{
				return this.<works>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<works>k__BackingField, value))
				{
					return;
				}
				this.<works>k__BackingField = value;
				this.RaisePropertyChanged("TotalUserWorksCost");
				this.RaisePropertyChanged("MasterPart");
				this.RaisePropertyChanged("TotalUserPartsCost");
				this.RaisePropertyChanged("AllMastersPart");
				this.RaisePropertyChanged("ProfitSumm");
				this.RaisePropertyChanged("EmployeePartsCost");
				this.RaisePropertyChanged("Masters");
				this.RaisePropertyChanged("works");
			}
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x0600115F RID: 4447 RVA: 0x0001FD2C File Offset: 0x0001DF2C
		// (set) Token: 0x06001160 RID: 4448 RVA: 0x0001FD40 File Offset: 0x0001DF40
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

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06001161 RID: 4449 RVA: 0x0001FD70 File Offset: 0x0001DF70
		// (set) Token: 0x06001162 RID: 4450 RVA: 0x0001FD84 File Offset: 0x0001DF84
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
				this.RaisePropertyChanged("offices");
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06001163 RID: 4451 RVA: 0x0001FDB4 File Offset: 0x0001DFB4
		// (set) Token: 0x06001164 RID: 4452 RVA: 0x0001FDC8 File Offset: 0x0001DFC8
		public virtual offices offices1
		{
			[CompilerGenerated]
			get
			{
				return this.<offices1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<offices1>k__BackingField, value))
				{
					return;
				}
				this.<offices1>k__BackingField = value;
				this.RaisePropertyChanged("offices1");
			}
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06001165 RID: 4453 RVA: 0x0001FDF8 File Offset: 0x0001DFF8
		// (set) Token: 0x06001166 RID: 4454 RVA: 0x0001FE0C File Offset: 0x0001E00C
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
				if (!object.Equals(this.<logs>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1997116250;
				IL_13:
				switch ((num ^ 1342095835) % 4)
				{
				case 0:
					IL_32:
					num = 1155462020;
					goto IL_13;
				case 1:
					return;
				case 2:
					goto IL_0E;
				}
				this.<logs>k__BackingField = value;
				this.RaisePropertyChanged("logs");
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06001167 RID: 4455 RVA: 0x0001FE68 File Offset: 0x0001E068
		// (set) Token: 0x06001168 RID: 4456 RVA: 0x0001FE7C File Offset: 0x0001E07C
		public virtual ICollection<media_info> media_info
		{
			[CompilerGenerated]
			get
			{
				return this.<media_info>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<media_info>k__BackingField, value))
				{
					return;
				}
				this.<media_info>k__BackingField = value;
				this.RaisePropertyChanged("media_info");
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06001169 RID: 4457 RVA: 0x0001FEAC File Offset: 0x0001E0AC
		// (set) Token: 0x0600116A RID: 4458 RVA: 0x0001FEC0 File Offset: 0x0001E0C0
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

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x0600116B RID: 4459 RVA: 0x0001FEF0 File Offset: 0x0001E0F0
		// (set) Token: 0x0600116C RID: 4460 RVA: 0x0001FF04 File Offset: 0x0001E104
		public virtual users lock_users
		{
			[CompilerGenerated]
			get
			{
				return this.<lock_users>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<lock_users>k__BackingField, value))
				{
					return;
				}
				this.<lock_users>k__BackingField = value;
				this.RaisePropertyChanged("LockUserFio");
				this.RaisePropertyChanged("lock_users");
			}
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x0600116D RID: 4461 RVA: 0x0001FF40 File Offset: 0x0001E140
		// (set) Token: 0x0600116E RID: 4462 RVA: 0x0001FF54 File Offset: 0x0001E154
		public virtual users master_users
		{
			[CompilerGenerated]
			get
			{
				return this.<master_users>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<master_users>k__BackingField, value))
				{
					return;
				}
				this.<master_users>k__BackingField = value;
				this.RaisePropertyChanged("MasterFio");
				this.RaisePropertyChanged("master_users");
			}
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x0600116F RID: 4463 RVA: 0x0001FF90 File Offset: 0x0001E190
		// (set) Token: 0x06001170 RID: 4464 RVA: 0x0001FFA4 File Offset: 0x0001E1A4
		public virtual users users2
		{
			[CompilerGenerated]
			get
			{
				return this.<users2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<users2>k__BackingField, value))
				{
					return;
				}
				this.<users2>k__BackingField = value;
				this.RaisePropertyChanged("AllManagersPart");
				this.RaisePropertyChanged("ProfitSumm");
				this.RaisePropertyChanged("users2");
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06001171 RID: 4465 RVA: 0x0001FFE8 File Offset: 0x0001E1E8
		// (set) Token: 0x06001172 RID: 4466 RVA: 0x0001FFFC File Offset: 0x0001E1FC
		public virtual users users3
		{
			[CompilerGenerated]
			get
			{
				return this.<users3>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<users3>k__BackingField, value))
				{
					return;
				}
				this.<users3>k__BackingField = value;
				this.RaisePropertyChanged("AllManagersPart");
				this.RaisePropertyChanged("ProfitSumm");
				this.RaisePropertyChanged("users3");
			}
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06001173 RID: 4467 RVA: 0x00020040 File Offset: 0x0001E240
		// (set) Token: 0x06001174 RID: 4468 RVA: 0x00020054 File Offset: 0x0001E254
		public virtual ICollection<field_values> field_values
		{
			[CompilerGenerated]
			get
			{
				return this.<field_values>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<field_values>k__BackingField, value))
				{
					return;
				}
				this.<field_values>k__BackingField = value;
				this.RaisePropertyChanged("field_values");
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06001175 RID: 4469 RVA: 0x00020084 File Offset: 0x0001E284
		// (set) Token: 0x06001176 RID: 4470 RVA: 0x00020098 File Offset: 0x0001E298
		public virtual ICollection<workshop> workshop1
		{
			[CompilerGenerated]
			get
			{
				return this.<workshop1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<workshop1>k__BackingField, value))
				{
					return;
				}
				this.<workshop1>k__BackingField = value;
				this.RaisePropertyChanged("workshop1");
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06001177 RID: 4471 RVA: 0x000200C8 File Offset: 0x0001E2C8
		// (set) Token: 0x06001178 RID: 4472 RVA: 0x000200DC File Offset: 0x0001E2DC
		public virtual workshop workshop2
		{
			[CompilerGenerated]
			get
			{
				return this.<workshop2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<workshop2>k__BackingField, value))
				{
					return;
				}
				this.<workshop2>k__BackingField = value;
				this.RaisePropertyChanged("workshop2");
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06001179 RID: 4473 RVA: 0x0002010C File Offset: 0x0001E30C
		// (set) Token: 0x0600117A RID: 4474 RVA: 0x00020120 File Offset: 0x0001E320
		public virtual companies companies
		{
			[CompilerGenerated]
			get
			{
				return this.<companies>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<companies>k__BackingField, value))
				{
					return;
				}
				this.<companies>k__BackingField = value;
				this.RaisePropertyChanged("companies");
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x0600117B RID: 4475 RVA: 0x00020150 File Offset: 0x0001E350
		// (set) Token: 0x0600117C RID: 4476 RVA: 0x00020164 File Offset: 0x0001E364
		public virtual ICollection<store_int_reserve> store_int_reserve
		{
			[CompilerGenerated]
			get
			{
				return this.<store_int_reserve>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<store_int_reserve>k__BackingField, value))
				{
					return;
				}
				this.<store_int_reserve>k__BackingField = value;
				this.RaisePropertyChanged("TotalUserPartsCost");
				this.RaisePropertyChanged("AllMastersPart");
				this.RaisePropertyChanged("ProfitSumm");
				this.RaisePropertyChanged("EmployeePartsCost");
				this.RaisePropertyChanged("MasterPart");
				this.RaisePropertyChanged("store_int_reserve");
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x0600117D RID: 4477 RVA: 0x000201CC File Offset: 0x0001E3CC
		// (set) Token: 0x0600117E RID: 4478 RVA: 0x000201E0 File Offset: 0x0001E3E0
		public virtual ICollection<parts_request> parts_request
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

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x0600117F RID: 4479 RVA: 0x00020210 File Offset: 0x0001E410
		// (set) Token: 0x06001180 RID: 4480 RVA: 0x00020224 File Offset: 0x0001E424
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

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06001181 RID: 4481 RVA: 0x00020254 File Offset: 0x0001E454
		// (set) Token: 0x06001182 RID: 4482 RVA: 0x00020268 File Offset: 0x0001E468
		public virtual boxes boxes
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
				this.RaisePropertyChanged("boxes");
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06001183 RID: 4483 RVA: 0x00020298 File Offset: 0x0001E498
		// (set) Token: 0x06001184 RID: 4484 RVA: 0x000202AC File Offset: 0x0001E4AC
		public virtual ICollection<invoice_items> invoice_items
		{
			[CompilerGenerated]
			get
			{
				return this.<invoice_items>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<invoice_items>k__BackingField, value))
				{
					return;
				}
				this.<invoice_items>k__BackingField = value;
				this.RaisePropertyChanged("invoice_items");
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06001185 RID: 4485 RVA: 0x000202DC File Offset: 0x0001E4DC
		// (set) Token: 0x06001186 RID: 4486 RVA: 0x000202F0 File Offset: 0x0001E4F0
		public virtual invoice invoice1
		{
			[CompilerGenerated]
			get
			{
				return this.<invoice1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<invoice1>k__BackingField, value))
				{
					return;
				}
				this.<invoice1>k__BackingField = value;
				this.RaisePropertyChanged("invoice1");
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06001187 RID: 4487 RVA: 0x00020320 File Offset: 0x0001E520
		// (set) Token: 0x06001188 RID: 4488 RVA: 0x00020334 File Offset: 0x0001E534
		public virtual c_workshop c_workshop
		{
			[CompilerGenerated]
			get
			{
				return this.<c_workshop>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<c_workshop>k__BackingField, value))
				{
					return;
				}
				this.<c_workshop>k__BackingField = value;
				this.RaisePropertyChanged("DeviceOverview");
				this.RaisePropertyChanged("c_workshop");
			}
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06001189 RID: 4489 RVA: 0x00020370 File Offset: 0x0001E570
		// (set) Token: 0x0600118A RID: 4490 RVA: 0x00020384 File Offset: 0x0001E584
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

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x0600118B RID: 4491 RVA: 0x000203B4 File Offset: 0x0001E5B4
		// (set) Token: 0x0600118C RID: 4492 RVA: 0x000203C8 File Offset: 0x0001E5C8
		public virtual vendors vendors
		{
			[CompilerGenerated]
			get
			{
				return this.<vendors>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<vendors>k__BackingField, value))
				{
					return;
				}
				this.<vendors>k__BackingField = value;
				this.RaisePropertyChanged("vendors");
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x0600118D RID: 4493 RVA: 0x000203F8 File Offset: 0x0001E5F8
		// (set) Token: 0x0600118E RID: 4494 RVA: 0x0002040C File Offset: 0x0001E60C
		public virtual ICollection<workshop_issued> workshop_issued
		{
			[CompilerGenerated]
			get
			{
				return this.<workshop_issued>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<workshop_issued>k__BackingField, value))
				{
					return;
				}
				this.<workshop_issued>k__BackingField = value;
				this.RaisePropertyChanged("workshop_issued");
			}
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x0600118F RID: 4495 RVA: 0x0002043C File Offset: 0x0001E63C
		// (set) Token: 0x06001190 RID: 4496 RVA: 0x00020450 File Offset: 0x0001E650
		public virtual ICollection<repair_status_logs> repair_status_logs
		{
			[CompilerGenerated]
			get
			{
				return this.<repair_status_logs>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<repair_status_logs>k__BackingField, value))
				{
					return;
				}
				this.<repair_status_logs>k__BackingField = value;
				this.RaisePropertyChanged("repair_status_logs");
			}
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06001191 RID: 4497 RVA: 0x00020480 File Offset: 0x0001E680
		// (set) Token: 0x06001192 RID: 4498 RVA: 0x00020494 File Offset: 0x0001E694
		public ObservableCollection<object> AdditionalFields
		{
			[CompilerGenerated]
			get
			{
				return this.<AdditionalFields>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<AdditionalFields>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 2038262339;
				IL_13:
				switch ((num ^ 1836080101) % 4)
				{
				case 0:
					goto IL_0E;
				case 2:
					return;
				case 3:
					IL_32:
					this.<AdditionalFields>k__BackingField = value;
					this.RaisePropertyChanged("AdditionalFields");
					num = 459275384;
					goto IL_13;
				}
			}
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06001193 RID: 4499 RVA: 0x000204F0 File Offset: 0x0001E6F0
		// (set) Token: 0x06001194 RID: 4500 RVA: 0x00020504 File Offset: 0x0001E704
		public ObservableCollection<object> AdditionalFieldsEdit
		{
			[CompilerGenerated]
			get
			{
				return this.<AdditionalFieldsEdit>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<AdditionalFieldsEdit>k__BackingField, value))
				{
					return;
				}
				this.<AdditionalFieldsEdit>k__BackingField = value;
				this.RaisePropertyChanged("AdditionalFieldsEdit");
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06001195 RID: 4501 RVA: 0x00020534 File Offset: 0x0001E734
		public bool IsCashLess
		{
			get
			{
				return this.payment_system == 1;
			}
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06001196 RID: 4502 RVA: 0x0002054C File Offset: 0x0001E74C
		public bool Ready2Issue
		{
			get
			{
				return this.state == 6;
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06001197 RID: 4503 RVA: 0x00020564 File Offset: 0x0001E764
		public bool Ready2IssueWithoutRepair
		{
			get
			{
				return this.state == 7;
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06001198 RID: 4504 RVA: 0x0002057C File Offset: 0x0001E77C
		public virtual string LockUserFio
		{
			get
			{
				if (this.user_lock != null && this.lock_users != null)
				{
					return string.Concat(new string[]
					{
						this.lock_users.surname,
						" ",
						this.lock_users.name,
						" ",
						this.lock_users.patronymic
					});
				}
				return string.Empty;
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06001199 RID: 4505 RVA: 0x000205EC File Offset: 0x0001E7EC
		// (set) Token: 0x0600119A RID: 4506 RVA: 0x00020600 File Offset: 0x0001E800
		public string ModelName
		{
			[CompilerGenerated]
			get
			{
				return this.<ModelName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<ModelName>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<ModelName>k__BackingField = value;
				this.RaisePropertyChanged("ModelName");
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x0600119B RID: 4507 RVA: 0x00020630 File Offset: 0x0001E830
		// (set) Token: 0x0600119C RID: 4508 RVA: 0x00020644 File Offset: 0x0001E844
		public string MakerName
		{
			[CompilerGenerated]
			get
			{
				return this.<MakerName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<MakerName>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<MakerName>k__BackingField = value;
				this.RaisePropertyChanged("MakerName");
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x0600119D RID: 4509 RVA: 0x00020674 File Offset: 0x0001E874
		public virtual string WarrantyUpTo
		{
			get
			{
				if (this.out_date == null || this.warranty_days == 0)
				{
					return string.Empty;
				}
				return this.out_date.Value.AddDays((double)this.warranty_days).ToShortDateString();
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x0600119E RID: 4510 RVA: 0x000206C4 File Offset: 0x0001E8C4
		public virtual double RepairProgress
		{
			get
			{
				DateTime? out_date = this.out_date;
				if (out_date == null)
				{
					goto IL_45;
				}
				DateTime dateTime = out_date.GetValueOrDefault();
				IL_24:
				DateTime d = dateTime;
				int num = -728343447;
				IL_2A:
				switch ((num ^ -300633435) % 3)
				{
				case 1:
					dateTime = this._localization.Now;
					goto IL_24;
				case 2:
					IL_45:
					num = -953333893;
					goto IL_2A;
				}
				return (double)(100 * (d - this.in_date).Days) / WorkshopOptions.GetTotalRepairDays();
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x0600119F RID: 4511 RVA: 0x0002073C File Offset: 0x0001E93C
		public virtual DateTime InDateTime
		{
			get
			{
				return Localization.ToLocalTimeZone(this.in_date);
			}
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x060011A0 RID: 4512 RVA: 0x00020754 File Offset: 0x0001E954
		public virtual DateTime OutDateTime
		{
			get
			{
				if (this.out_date == null)
				{
					return DateTime.MinValue;
				}
				return Localization.ToLocalTimeZone(this.out_date.Value);
			}
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x060011A1 RID: 4513 RVA: 0x0002078C File Offset: 0x0001E98C
		public virtual decimal TotalUserWorksCost
		{
			get
			{
				decimal result;
				try
				{
					result = (from w in this.works
					where w.user == this._master.id
					select w.price * w.count).DefaultIfEmpty<decimal>().Sum();
				}
				catch (Exception)
				{
					result = 0m;
				}
				return result;
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x060011A2 RID: 4514 RVA: 0x000207FC File Offset: 0x0001E9FC
		public virtual decimal TotalUserPartsCost
		{
			get
			{
				decimal result;
				try
				{
					if (this.PartsInWorks())
					{
						goto IL_61;
					}
					IL_08:
					result = (from w in this.store_int_reserve
					select w.price * w.count).DefaultIfEmpty<decimal>().Sum();
					int num = -763406133;
					IL_42:
					switch ((num ^ -976402386) % 4)
					{
					case 0:
						goto IL_08;
					case 2:
						IL_61:
						num = -938275919;
						goto IL_42;
					case 3:
						result = (from r in this.works.SelectMany((works w) => w.store_int_reserve).ToList<store_int_reserve>()
						select r.Summ).DefaultIfEmpty<decimal>().Sum();
						break;
					}
				}
				catch (Exception)
				{
					result = 0m;
				}
				return result;
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x060011A3 RID: 4515 RVA: 0x000208F0 File Offset: 0x0001EAF0
		public virtual decimal EmployeePartsCost
		{
			get
			{
				decimal result;
				try
				{
					if (this.PartsInWorks())
					{
						result = (from r in (from w in this.works
						where w.user == this._master.id
						select w).SelectMany((works w) => w.store_int_reserve).ToList<store_int_reserve>()
						select r.Summ).DefaultIfEmpty<decimal>().Sum();
					}
					else
					{
						result = (from w in this.store_int_reserve
						select w.price * w.count).DefaultIfEmpty<decimal>().Sum();
					}
				}
				catch (Exception)
				{
					result = 0m;
				}
				return result;
			}
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x000209C8 File Offset: 0x0001EBC8
		private bool PartsInWorks()
		{
			return this.works.SelectMany((works w) => w.store_int_reserve).Any<store_int_reserve>();
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x060011A5 RID: 4517 RVA: 0x00020A04 File Offset: 0x0001EC04
		// (set) Token: 0x060011A6 RID: 4518 RVA: 0x00020A20 File Offset: 0x0001EC20
		public string Color
		{
			get
			{
				return this.color ?? "#00000000";
			}
			set
			{
				if (!string.Equals(this.Color, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = -176290212;
				IL_14:
				switch ((num ^ -2045036203) % 4)
				{
				case 1:
					return;
				case 2:
					goto IL_0F;
				case 3:
					IL_33:
					this.color = value;
					this.RaisePropertyChanged("Color");
					num = -174901479;
					goto IL_14;
				}
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x060011A7 RID: 4519 RVA: 0x00020A7C File Offset: 0x0001EC7C
		public bool IsLocked
		{
			get
			{
				if (this.user_lock != null && this.lock_datetime != null)
				{
					int? user_lock = this.user_lock;
					int id = Auth.User.id;
					if (!(user_lock.GetValueOrDefault() == id & user_lock != null))
					{
						return (this._localization.Now - this.lock_datetime.Value).TotalMinutes < 1.0;
					}
				}
				return false;
			}
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x060011A8 RID: 4520 RVA: 0x00020B04 File Offset: 0x0001ED04
		public virtual string MasterFio
		{
			get
			{
				string[] array = new string[5];
				int num = 0;
				users master_users = this.master_users;
				array[num] = ((master_users != null) ? master_users.surname : null);
				array[1] = " ";
				int num2 = 2;
				users master_users2 = this.master_users;
				array[num2] = ((master_users2 != null) ? master_users2.name.FirstOrEmpty(true) : null);
				array[3] = " ";
				int num3 = 4;
				users master_users3 = this.master_users;
				array[num3] = ((master_users3 != null) ? master_users3.patronymic.FirstOrEmpty(true) : null);
				return string.Concat(array);
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x060011A9 RID: 4521 RVA: 0x00020B78 File Offset: 0x0001ED78
		public virtual string DeviceOverview
		{
			get
			{
				if (this.cartridge != null)
				{
					string[] array = new string[5];
					int num = 0;
					devices devices = this.devices;
					array[num] = ((devices != null) ? devices.name : null);
					array[1] = " ";
					int num2 = 2;
					device_makers device_makers = this.device_makers;
					array[num2] = ((device_makers != null) ? device_makers.name : null);
					array[3] = " ";
					int num3 = 4;
					c_workshop c_workshop = this.c_workshop;
					string text;
					if (c_workshop == null)
					{
						text = null;
					}
					else
					{
						cartridge_cards cartridge_cards = c_workshop.cartridge_cards;
						text = ((cartridge_cards != null) ? cartridge_cards.name : null);
					}
					array[num3] = text;
					return string.Concat(array);
				}
				string[] array2 = new string[5];
				int num4 = 0;
				devices devices2 = this.devices;
				array2[num4] = ((devices2 != null) ? devices2.name : null);
				array2[1] = " ";
				int num5 = 2;
				device_makers device_makers2 = this.device_makers;
				array2[num5] = ((device_makers2 != null) ? device_makers2.name : null);
				array2[3] = " ";
				int num6 = 4;
				device_models device_models = this.device_models;
				array2[num6] = ((device_models != null) ? device_models.name : null);
				return string.Concat(array2);
			}
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x060011AA RID: 4522 RVA: 0x00020C58 File Offset: 0x0001EE58
		public decimal TotalRepairCost
		{
			get
			{
				return this.real_repair_cost;
			}
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x060011AB RID: 4523 RVA: 0x00020C6C File Offset: 0x0001EE6C
		public decimal AllMastersPart
		{
			get
			{
				decimal result;
				try
				{
					decimal num = 0m;
					if (this.works.Any<works>())
					{
						if (!Auth.Config.parts_included)
						{
							num += this.works.Sum((works work) => work.price / 100m * work.users.pay_repair);
							result = Fn.FormatSumm(num);
						}
						else
						{
							works firstWork = this.works.First<works>();
							if (this.works.All((works w) => w.user == firstWork.user))
							{
								num = this.works.DefaultIfEmpty<works>().Sum((works w) => w.price) - this.TotalUserPartsCost;
								result = Fn.FormatSumm(num / 100m * firstWork.users.pay_repair);
							}
							else if (this.PartsInWorks())
							{
								foreach (works works in this.works)
								{
									if (works.store_int_reserve.Any<store_int_reserve>())
									{
										decimal d = (from p in works.store_int_reserve
										select p.price * p.count).DefaultIfEmpty<decimal>().Sum();
										num += (works.price - d) / 100m * works.users.pay_repair;
									}
									else
									{
										num += works.price / 100m * works.users.pay_repair;
									}
								}
								result = Fn.FormatSumm(num);
							}
							else
							{
								IEnumerable<users> first = (from w in this.works
								select w.users).ToList<users>();
								List<users> second = (from w in this.store_int_reserve
								select w.users).ToList<users>();
								using (List<users>.Enumerator enumerator2 = first.Union(second).ToList<users>().GetEnumerator())
								{
									while (enumerator2.MoveNext())
									{
										users user = enumerator2.Current;
										List<works> source = (from w in this.works
										where w.user == user.id
										select w).ToList<works>();
										decimal d2 = 0m;
										if (source.Any<works>())
										{
											d2 = source.DefaultIfEmpty<works>().Sum((works work) => work.price * work.count);
										}
										List<store_int_reserve> source2 = (from r in this.store_int_reserve
										where r.to_user == user.id
										select r).ToList<store_int_reserve>();
										decimal d3 = 0m;
										if (source2.Any<store_int_reserve>())
										{
											d3 = source2.DefaultIfEmpty<store_int_reserve>().Sum((store_int_reserve r) => r.Summ);
										}
										decimal d4 = (d2 - d3) / 100m * user.pay_repair;
										num += d4;
									}
								}
								result = Fn.FormatSumm(num);
							}
						}
					}
					else
					{
						result = 0m;
					}
				}
				catch (Exception)
				{
					result = 0m;
				}
				return result;
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x060011AC RID: 4524 RVA: 0x00021074 File Offset: 0x0001F274
		public decimal AllManagersPart
		{
			get
			{
				decimal result;
				try
				{
					int pay_device_in = this.users2.pay_device_in;
					int pay_device_out = this.users3.pay_device_out;
					result = Fn.FormatSumm(pay_device_in + pay_device_out);
				}
				catch (Exception)
				{
					result = 0m;
				}
				return result;
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x060011AD RID: 4525 RVA: 0x000210C4 File Offset: 0x0001F2C4
		public decimal ProfitSumm
		{
			get
			{
				decimal result;
				try
				{
					result = Fn.FormatSumm(this.real_repair_cost - this.parts_cost - this.AllMastersPart - this.AllManagersPart);
				}
				catch (Exception)
				{
					result = 0m;
				}
				return result;
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x060011AE RID: 4526 RVA: 0x0002111C File Offset: 0x0001F31C
		public string Masters
		{
			get
			{
				string result;
				try
				{
					List<users> source = (from w in this.works
					select w.users).ToList<users>();
					string text = "";
					if (!source.Any<users>())
					{
						result = text;
					}
					else
					{
						text = source.Aggregate(text, (string current, users user) => current + user.Fio + ", ");
						result = text.Remove(text.Length - 2);
					}
				}
				catch (Exception)
				{
					result = "";
				}
				return result;
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x060011AF RID: 4527 RVA: 0x000211C0 File Offset: 0x0001F3C0
		public decimal MasterPart
		{
			get
			{
				if (this._master != null)
				{
					goto IL_2C;
				}
				IL_08:
				int num = -592828267;
				IL_0D:
				int masterPercent;
				switch ((num ^ -260140972) % 4)
				{
				case 0:
					goto IL_08;
				case 1:
					return 0m;
				case 2:
					IL_2C:
					masterPercent = this.GetMasterPercent(this._master);
					num = -1071387913;
					goto IL_0D;
				}
				return this.GetMasterPart(masterPercent);
			}
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x0002121C File Offset: 0x0001F41C
		private decimal GetMasterPart(int percent)
		{
			if (!Auth.Config.parts_included)
			{
				return this.TotalUserWorksCost / 100m * percent;
			}
			return (this.TotalUserWorksCost - this.EmployeePartsCost) / 100m * percent;
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x0002127C File Offset: 0x0001F47C
		private int GetMasterPercent(users user)
		{
			if (this.cartridge != null)
			{
				return user.pay_cartridge_refill;
			}
			if (this.quick_repair)
			{
				return user.pay_repair_quick;
			}
			return user.pay_repair;
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x000212B8 File Offset: 0x0001F4B8
		public decimal GetMasterPart(users user)
		{
			this._master = user;
			decimal result;
			try
			{
				if (this._master == null)
				{
					result = 0m;
				}
				else
				{
					int masterPercent = this.GetMasterPercent(this._master);
					result = this.GetMasterPart(masterPercent);
				}
			}
			catch (Exception)
			{
				result = 0m;
			}
			return result;
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x060011B3 RID: 4531 RVA: 0x00021310 File Offset: 0x0001F510
		public bool OutDateVisible
		{
			get
			{
				return this.out_date != null;
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x060011B4 RID: 4532 RVA: 0x0002132C File Offset: 0x0001F52C
		public bool WarrantyVisible
		{
			get
			{
				return this.out_date != null && this.warranty_days != 0 && (this.state == 8 || this.state == 16);
			}
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x060011B5 RID: 4533 RVA: 0x00021368 File Offset: 0x0001F568
		public string StateColor
		{
			get
			{
				WorkshopOptions option = new WorkshopOptions().GetOption(this.state);
				if (option == null)
				{
					goto IL_5A;
				}
				string value = option.Color;
				IL_1D:
				int num = (!string.IsNullOrEmpty(value)) ? 918855099 : 149243676;
				IL_3B:
				switch ((num ^ 610139704) % 4)
				{
				case 1:
					value = null;
					goto IL_1D;
				case 2:
					IL_5A:
					num = 1296718105;
					goto IL_3B;
				case 3:
					return option.Color;
				}
				return "#00000000";
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x060011B6 RID: 4534 RVA: 0x000213E4 File Offset: 0x0001F5E4
		public double InRepairDays
		{
			get
			{
				double result;
				try
				{
					double totalDays = (this._localization.NowDate - this.in_date.Date).TotalDays;
					result = ((totalDays < 0.0) ? 0.0 : totalDays);
				}
				catch (Exception)
				{
					result = 0.0;
				}
				return result;
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x060011B7 RID: 4535 RVA: 0x00021454 File Offset: 0x0001F654
		public decimal ShowRepairCost
		{
			get
			{
				if (!(this.real_repair_cost == 0m))
				{
					return this.real_repair_cost;
				}
				return this.repair_cost;
			}
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x00021480 File Offset: 0x0001F680
		[CompilerGenerated]
		private bool <get_TotalUserWorksCost>b__412_0(works w)
		{
			return w.user == this._master.id;
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x00021480 File Offset: 0x0001F680
		[CompilerGenerated]
		private bool <get_EmployeePartsCost>b__416_0(works w)
		{
			return w.user == this._master.id;
		}

		// Token: 0x040007F1 RID: 2033
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x040007F2 RID: 2034
		[CompilerGenerated]
		private int <client>k__BackingField;

		// Token: 0x040007F3 RID: 2035
		[CompilerGenerated]
		private int <type>k__BackingField;

		// Token: 0x040007F4 RID: 2036
		[CompilerGenerated]
		private int <maker>k__BackingField;

		// Token: 0x040007F5 RID: 2037
		[CompilerGenerated]
		private int? <model>k__BackingField;

		// Token: 0x040007F6 RID: 2038
		[CompilerGenerated]
		private string <serial_number>k__BackingField;

		// Token: 0x040007F7 RID: 2039
		[CompilerGenerated]
		private int <company>k__BackingField;

		// Token: 0x040007F8 RID: 2040
		[CompilerGenerated]
		private int <office>k__BackingField;

		// Token: 0x040007F9 RID: 2041
		[CompilerGenerated]
		private int <start_office>k__BackingField;

		// Token: 0x040007FA RID: 2042
		[CompilerGenerated]
		private int <manager>k__BackingField;

		// Token: 0x040007FB RID: 2043
		[CompilerGenerated]
		private int <current_manager>k__BackingField;

		// Token: 0x040007FC RID: 2044
		[CompilerGenerated]
		private int? <master>k__BackingField;

		// Token: 0x040007FD RID: 2045
		[CompilerGenerated]
		private string <diagnostic_result>k__BackingField;

		// Token: 0x040007FE RID: 2046
		[CompilerGenerated]
		private DateTime <in_date>k__BackingField;

		// Token: 0x040007FF RID: 2047
		[CompilerGenerated]
		private DateTime? <out_date>k__BackingField;

		// Token: 0x04000800 RID: 2048
		[CompilerGenerated]
		private int <state>k__BackingField;

		// Token: 0x04000801 RID: 2049
		[CompilerGenerated]
		private int? <user_lock>k__BackingField;

		// Token: 0x04000802 RID: 2050
		[CompilerGenerated]
		private DateTime? <lock_datetime>k__BackingField;

		// Token: 0x04000803 RID: 2051
		[CompilerGenerated]
		private bool? <express_repair>k__BackingField;

		// Token: 0x04000804 RID: 2052
		[CompilerGenerated]
		private bool <is_warranty>k__BackingField;

		// Token: 0x04000805 RID: 2053
		[CompilerGenerated]
		private bool <is_repeat>k__BackingField;

		// Token: 0x04000806 RID: 2054
		[CompilerGenerated]
		private bool <can_format>k__BackingField;

		// Token: 0x04000807 RID: 2055
		[CompilerGenerated]
		private bool <print_check>k__BackingField;

		// Token: 0x04000808 RID: 2056
		[CompilerGenerated]
		private int? <box>k__BackingField;

		// Token: 0x04000809 RID: 2057
		[CompilerGenerated]
		private string <warranty_label>k__BackingField;

		// Token: 0x0400080A RID: 2058
		[CompilerGenerated]
		private string <ext_notes>k__BackingField;

		// Token: 0x0400080B RID: 2059
		[CompilerGenerated]
		private bool <is_prepaid>k__BackingField;

		// Token: 0x0400080C RID: 2060
		[CompilerGenerated]
		private int <prepaid_type>k__BackingField;

		// Token: 0x0400080D RID: 2061
		[CompilerGenerated]
		private decimal <prepaid_summ>k__BackingField;

		// Token: 0x0400080E RID: 2062
		[CompilerGenerated]
		private int? <prepaid_order>k__BackingField;

		// Token: 0x0400080F RID: 2063
		[CompilerGenerated]
		private bool <is_pre_agreed>k__BackingField;

		// Token: 0x04000810 RID: 2064
		[CompilerGenerated]
		private decimal? <pre_agreed_amount>k__BackingField;

		// Token: 0x04000811 RID: 2065
		[CompilerGenerated]
		private decimal <repair_cost>k__BackingField;

		// Token: 0x04000812 RID: 2066
		[CompilerGenerated]
		private string <fault>k__BackingField;

		// Token: 0x04000813 RID: 2067
		[CompilerGenerated]
		private string <complect>k__BackingField;

		// Token: 0x04000814 RID: 2068
		[CompilerGenerated]
		private string <look>k__BackingField;

		// Token: 0x04000815 RID: 2069
		[CompilerGenerated]
		private bool <thirs_party_sc>k__BackingField;

		// Token: 0x04000816 RID: 2070
		[CompilerGenerated]
		private DateTime? <last_save>k__BackingField;

		// Token: 0x04000817 RID: 2071
		[CompilerGenerated]
		private DateTime? <last_status_changed>k__BackingField;

		// Token: 0x04000818 RID: 2072
		[CompilerGenerated]
		private int <warranty_days>k__BackingField;

		// Token: 0x04000819 RID: 2073
		[CompilerGenerated]
		private string <barcode>k__BackingField;

		// Token: 0x0400081A RID: 2074
		[CompilerGenerated]
		private int <new_state>k__BackingField;

		// Token: 0x0400081B RID: 2075
		[CompilerGenerated]
		private bool <is_card_payment>k__BackingField;

		// Token: 0x0400081C RID: 2076
		[CompilerGenerated]
		private int <informed_status>k__BackingField;

		// Token: 0x0400081D RID: 2077
		[CompilerGenerated]
		private decimal <parts_cost>k__BackingField;

		// Token: 0x0400081E RID: 2078
		[CompilerGenerated]
		private bool <is_debt>k__BackingField;

		// Token: 0x0400081F RID: 2079
		[CompilerGenerated]
		private string <image_ids>k__BackingField;

		// Token: 0x04000820 RID: 2080
		[CompilerGenerated]
		private string <color>k__BackingField;

		// Token: 0x04000821 RID: 2081
		[CompilerGenerated]
		private string <order_moving>k__BackingField;

		// Token: 0x04000822 RID: 2082
		[CompilerGenerated]
		private int <payment_system>k__BackingField;

		// Token: 0x04000823 RID: 2083
		[CompilerGenerated]
		private int? <early>k__BackingField;

		// Token: 0x04000824 RID: 2084
		[CompilerGenerated]
		private decimal <real_repair_cost>k__BackingField;

		// Token: 0x04000825 RID: 2085
		[CompilerGenerated]
		private string <issued_msg>k__BackingField;

		// Token: 0x04000826 RID: 2086
		[CompilerGenerated]
		private string <reject_reason>k__BackingField;

		// Token: 0x04000827 RID: 2087
		[CompilerGenerated]
		private string <ext_early>k__BackingField;

		// Token: 0x04000828 RID: 2088
		[CompilerGenerated]
		private bool <sms_inform>k__BackingField;

		// Token: 0x04000829 RID: 2089
		[CompilerGenerated]
		private int? <invoice>k__BackingField;

		// Token: 0x0400082A RID: 2090
		[CompilerGenerated]
		private int? <cartridge>k__BackingField;

		// Token: 0x0400082B RID: 2091
		[CompilerGenerated]
		private bool <termsControl>k__BackingField;

		// Token: 0x0400082C RID: 2092
		[CompilerGenerated]
		private int? <vendor_id>k__BackingField;

		// Token: 0x0400082D RID: 2093
		[CompilerGenerated]
		private bool <quick_repair>k__BackingField;

		// Token: 0x0400082E RID: 2094
		[CompilerGenerated]
		private bool <Hidden>k__BackingField;

		// Token: 0x0400082F RID: 2095
		[CompilerGenerated]
		private string <Title>k__BackingField;

		// Token: 0x04000830 RID: 2096
		[CompilerGenerated]
		private device_makers <device_makers>k__BackingField;

		// Token: 0x04000831 RID: 2097
		[CompilerGenerated]
		private device_models <device_models>k__BackingField;

		// Token: 0x04000832 RID: 2098
		[CompilerGenerated]
		private ICollection<workshop_parts> <workshop_parts>k__BackingField;

		// Token: 0x04000833 RID: 2099
		[CompilerGenerated]
		private devices <devices>k__BackingField;

		// Token: 0x04000834 RID: 2100
		[CompilerGenerated]
		private ICollection<docs> <docs>k__BackingField;

		// Token: 0x04000835 RID: 2101
		[CompilerGenerated]
		private ICollection<works> <works>k__BackingField;

		// Token: 0x04000836 RID: 2102
		[CompilerGenerated]
		private clients <clients>k__BackingField;

		// Token: 0x04000837 RID: 2103
		[CompilerGenerated]
		private offices <offices>k__BackingField;

		// Token: 0x04000838 RID: 2104
		[CompilerGenerated]
		private offices <offices1>k__BackingField;

		// Token: 0x04000839 RID: 2105
		[CompilerGenerated]
		private ICollection<logs> <logs>k__BackingField;

		// Token: 0x0400083A RID: 2106
		[CompilerGenerated]
		private ICollection<media_info> <media_info>k__BackingField;

		// Token: 0x0400083B RID: 2107
		[CompilerGenerated]
		private ICollection<cash_orders> <cash_orders>k__BackingField;

		// Token: 0x0400083C RID: 2108
		[CompilerGenerated]
		private users <lock_users>k__BackingField;

		// Token: 0x0400083D RID: 2109
		[CompilerGenerated]
		private users <master_users>k__BackingField;

		// Token: 0x0400083E RID: 2110
		[CompilerGenerated]
		private users <users2>k__BackingField;

		// Token: 0x0400083F RID: 2111
		[CompilerGenerated]
		private users <users3>k__BackingField;

		// Token: 0x04000840 RID: 2112
		[CompilerGenerated]
		private ICollection<field_values> <field_values>k__BackingField;

		// Token: 0x04000841 RID: 2113
		[CompilerGenerated]
		private ICollection<workshop> <workshop1>k__BackingField;

		// Token: 0x04000842 RID: 2114
		[CompilerGenerated]
		private workshop <workshop2>k__BackingField;

		// Token: 0x04000843 RID: 2115
		[CompilerGenerated]
		private companies <companies>k__BackingField;

		// Token: 0x04000844 RID: 2116
		[CompilerGenerated]
		private ICollection<store_int_reserve> <store_int_reserve>k__BackingField;

		// Token: 0x04000845 RID: 2117
		[CompilerGenerated]
		private ICollection<parts_request> <parts_request>k__BackingField;

		// Token: 0x04000846 RID: 2118
		[CompilerGenerated]
		private ICollection<comments> <comments>k__BackingField;

		// Token: 0x04000847 RID: 2119
		[CompilerGenerated]
		private boxes <boxes>k__BackingField;

		// Token: 0x04000848 RID: 2120
		[CompilerGenerated]
		private ICollection<invoice_items> <invoice_items>k__BackingField;

		// Token: 0x04000849 RID: 2121
		[CompilerGenerated]
		private invoice <invoice1>k__BackingField;

		// Token: 0x0400084A RID: 2122
		[CompilerGenerated]
		private c_workshop <c_workshop>k__BackingField;

		// Token: 0x0400084B RID: 2123
		[CompilerGenerated]
		private ICollection<notifications> <notifications>k__BackingField;

		// Token: 0x0400084C RID: 2124
		[CompilerGenerated]
		private vendors <vendors>k__BackingField;

		// Token: 0x0400084D RID: 2125
		[CompilerGenerated]
		private ICollection<workshop_issued> <workshop_issued>k__BackingField;

		// Token: 0x0400084E RID: 2126
		[CompilerGenerated]
		private ICollection<repair_status_logs> <repair_status_logs>k__BackingField;

		// Token: 0x0400084F RID: 2127
		private readonly Localization _localization = new Localization("UTC");

		// Token: 0x04000850 RID: 2128
		[CompilerGenerated]
		private ObservableCollection<object> <AdditionalFields>k__BackingField = new ObservableCollection<object>();

		// Token: 0x04000851 RID: 2129
		[CompilerGenerated]
		private ObservableCollection<object> <AdditionalFieldsEdit>k__BackingField = new ObservableCollection<object>();

		// Token: 0x04000852 RID: 2130
		private users _master;

		// Token: 0x04000853 RID: 2131
		[CompilerGenerated]
		private string <ModelName>k__BackingField;

		// Token: 0x04000854 RID: 2132
		[CompilerGenerated]
		private string <MakerName>k__BackingField;

		// Token: 0x0200008A RID: 138
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060011BA RID: 4538 RVA: 0x000214A0 File Offset: 0x0001F6A0
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060011BB RID: 4539 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x060011BC RID: 4540 RVA: 0x000214B8 File Offset: 0x0001F6B8
			internal decimal <get_TotalUserWorksCost>b__412_1(works w)
			{
				return w.price * w.count;
			}

			// Token: 0x060011BD RID: 4541 RVA: 0x000214DC File Offset: 0x0001F6DC
			internal IEnumerable<store_int_reserve> <get_TotalUserPartsCost>b__414_0(works w)
			{
				return w.store_int_reserve;
			}

			// Token: 0x060011BE RID: 4542 RVA: 0x000214F0 File Offset: 0x0001F6F0
			internal decimal <get_TotalUserPartsCost>b__414_1(store_int_reserve r)
			{
				return r.Summ;
			}

			// Token: 0x060011BF RID: 4543 RVA: 0x00021504 File Offset: 0x0001F704
			internal decimal <get_TotalUserPartsCost>b__414_2(store_int_reserve w)
			{
				return w.price * w.count;
			}

			// Token: 0x060011C0 RID: 4544 RVA: 0x000214DC File Offset: 0x0001F6DC
			internal IEnumerable<store_int_reserve> <get_EmployeePartsCost>b__416_1(works w)
			{
				return w.store_int_reserve;
			}

			// Token: 0x060011C1 RID: 4545 RVA: 0x000214F0 File Offset: 0x0001F6F0
			internal decimal <get_EmployeePartsCost>b__416_2(store_int_reserve r)
			{
				return r.Summ;
			}

			// Token: 0x060011C2 RID: 4546 RVA: 0x00021504 File Offset: 0x0001F704
			internal decimal <get_EmployeePartsCost>b__416_3(store_int_reserve w)
			{
				return w.price * w.count;
			}

			// Token: 0x060011C3 RID: 4547 RVA: 0x000214DC File Offset: 0x0001F6DC
			internal IEnumerable<store_int_reserve> <PartsInWorks>b__417_0(works w)
			{
				return w.store_int_reserve;
			}

			// Token: 0x060011C4 RID: 4548 RVA: 0x00021528 File Offset: 0x0001F728
			internal decimal <get_AllMastersPart>b__430_0(works work)
			{
				return work.price / 100m * work.users.pay_repair;
			}

			// Token: 0x060011C5 RID: 4549 RVA: 0x0002155C File Offset: 0x0001F75C
			internal decimal <get_AllMastersPart>b__430_4(works w)
			{
				return w.price;
			}

			// Token: 0x060011C6 RID: 4550 RVA: 0x00021504 File Offset: 0x0001F704
			internal decimal <get_AllMastersPart>b__430_5(store_int_reserve p)
			{
				return p.price * p.count;
			}

			// Token: 0x060011C7 RID: 4551 RVA: 0x00021570 File Offset: 0x0001F770
			internal users <get_AllMastersPart>b__430_2(works w)
			{
				return w.users;
			}

			// Token: 0x060011C8 RID: 4552 RVA: 0x00021584 File Offset: 0x0001F784
			internal users <get_AllMastersPart>b__430_3(store_int_reserve w)
			{
				return w.users;
			}

			// Token: 0x060011C9 RID: 4553 RVA: 0x000214B8 File Offset: 0x0001F6B8
			internal decimal <get_AllMastersPart>b__430_7(works work)
			{
				return work.price * work.count;
			}

			// Token: 0x060011CA RID: 4554 RVA: 0x000214F0 File Offset: 0x0001F6F0
			internal decimal <get_AllMastersPart>b__430_9(store_int_reserve r)
			{
				return r.Summ;
			}

			// Token: 0x060011CB RID: 4555 RVA: 0x00021570 File Offset: 0x0001F770
			internal users <get_Masters>b__436_0(works w)
			{
				return w.users;
			}

			// Token: 0x060011CC RID: 4556 RVA: 0x00021598 File Offset: 0x0001F798
			internal string <get_Masters>b__436_1(string current, users user)
			{
				return current + user.Fio + ", ";
			}

			// Token: 0x04000855 RID: 2133
			public static readonly workshop.<>c <>9 = new workshop.<>c();

			// Token: 0x04000856 RID: 2134
			public static Func<works, decimal> <>9__412_1;

			// Token: 0x04000857 RID: 2135
			public static Func<works, IEnumerable<store_int_reserve>> <>9__414_0;

			// Token: 0x04000858 RID: 2136
			public static Func<store_int_reserve, decimal> <>9__414_1;

			// Token: 0x04000859 RID: 2137
			public static Func<store_int_reserve, decimal> <>9__414_2;

			// Token: 0x0400085A RID: 2138
			public static Func<works, IEnumerable<store_int_reserve>> <>9__416_1;

			// Token: 0x0400085B RID: 2139
			public static Func<store_int_reserve, decimal> <>9__416_2;

			// Token: 0x0400085C RID: 2140
			public static Func<store_int_reserve, decimal> <>9__416_3;

			// Token: 0x0400085D RID: 2141
			public static Func<works, IEnumerable<store_int_reserve>> <>9__417_0;

			// Token: 0x0400085E RID: 2142
			public static Func<works, decimal> <>9__430_0;

			// Token: 0x0400085F RID: 2143
			public static Func<works, decimal> <>9__430_4;

			// Token: 0x04000860 RID: 2144
			public static Func<store_int_reserve, decimal> <>9__430_5;

			// Token: 0x04000861 RID: 2145
			public static Func<works, users> <>9__430_2;

			// Token: 0x04000862 RID: 2146
			public static Func<store_int_reserve, users> <>9__430_3;

			// Token: 0x04000863 RID: 2147
			public static Func<works, decimal> <>9__430_7;

			// Token: 0x04000864 RID: 2148
			public static Func<store_int_reserve, decimal> <>9__430_9;

			// Token: 0x04000865 RID: 2149
			public static Func<works, users> <>9__436_0;

			// Token: 0x04000866 RID: 2150
			public static Func<string, users, string> <>9__436_1;
		}

		// Token: 0x0200008B RID: 139
		[CompilerGenerated]
		private sealed class <>c__DisplayClass430_0
		{
			// Token: 0x060011CD RID: 4557 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass430_0()
			{
			}

			// Token: 0x060011CE RID: 4558 RVA: 0x000215B8 File Offset: 0x0001F7B8
			internal bool <get_AllMastersPart>b__1(works w)
			{
				return w.user == this.firstWork.user;
			}

			// Token: 0x04000867 RID: 2151
			public works firstWork;
		}

		// Token: 0x0200008C RID: 140
		[CompilerGenerated]
		private sealed class <>c__DisplayClass430_1
		{
			// Token: 0x060011CF RID: 4559 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass430_1()
			{
			}

			// Token: 0x060011D0 RID: 4560 RVA: 0x000215D8 File Offset: 0x0001F7D8
			internal bool <get_AllMastersPart>b__6(works w)
			{
				return w.user == this.user.id;
			}

			// Token: 0x060011D1 RID: 4561 RVA: 0x000215F8 File Offset: 0x0001F7F8
			internal bool <get_AllMastersPart>b__8(store_int_reserve r)
			{
				return r.to_user == this.user.id;
			}

			// Token: 0x04000868 RID: 2152
			public users user;
		}
	}
}
