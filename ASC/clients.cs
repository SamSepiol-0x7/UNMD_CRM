using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DevExpress.Mvvm;

namespace ASC
{
	// Token: 0x02000031 RID: 49
	public class clients : BindableBase
	{
		// Token: 0x06000326 RID: 806 RVA: 0x00008F88 File Offset: 0x00007188
		public clients()
		{
			this.banks = new HashSet<banks>();
			this.docs = new HashSet<docs>();
			this.store_items = new HashSet<store_items>();
			this.store_sales = new HashSet<store_sales>();
			this.workshop = new HashSet<workshop>();
			this.balance1 = new HashSet<balance>();
			this.logs = new HashSet<logs>();
			this.media_info = new HashSet<media_info>();
			this.cash_orders = new HashSet<cash_orders>();
			this.dealer_payments = new HashSet<dealer_payments>();
			this.payment_types = new HashSet<payment_types>();
			this.parts_request = new HashSet<parts_request>();
			this.comments = new HashSet<comments>();
			this.parts_request1 = new HashSet<parts_request>();
			this.out_sms = new HashSet<out_sms>();
			this.tel = new HashSet<tel>();
			this.notifications = new HashSet<notifications>();
			this.store_sales1 = new HashSet<store_sales>();
			this.vendors = new HashSet<vendors>();
			this.vendors1 = new HashSet<vendors>();
			this.buyout = new HashSet<buyout>();
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000327 RID: 807 RVA: 0x00009084 File Offset: 0x00007284
		// (set) Token: 0x06000328 RID: 808 RVA: 0x00009098 File Offset: 0x00007298
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

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000329 RID: 809 RVA: 0x000090C4 File Offset: 0x000072C4
		// (set) Token: 0x0600032A RID: 810 RVA: 0x000090D8 File Offset: 0x000072D8
		public int creator
		{
			[CompilerGenerated]
			get
			{
				return this.<creator>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<creator>k__BackingField == value)
				{
					return;
				}
				this.<creator>k__BackingField = value;
				this.RaisePropertyChanged("creator");
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600032B RID: 811 RVA: 0x00009104 File Offset: 0x00007304
		// (set) Token: 0x0600032C RID: 812 RVA: 0x00009118 File Offset: 0x00007318
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
				this.RaisePropertyChanged("FioOrUrName");
				this.RaisePropertyChanged("IoOrUrName");
				this.RaisePropertyChanged("name");
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600032D RID: 813 RVA: 0x00009160 File Offset: 0x00007360
		// (set) Token: 0x0600032E RID: 814 RVA: 0x00009174 File Offset: 0x00007374
		public string surname
		{
			[CompilerGenerated]
			get
			{
				return this.<surname>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<surname>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<surname>k__BackingField = value;
				this.RaisePropertyChanged("FioOrUrName");
				this.RaisePropertyChanged("surname");
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600032F RID: 815 RVA: 0x000091B0 File Offset: 0x000073B0
		// (set) Token: 0x06000330 RID: 816 RVA: 0x000091C4 File Offset: 0x000073C4
		public string patronymic
		{
			[CompilerGenerated]
			get
			{
				return this.<patronymic>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<patronymic>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<patronymic>k__BackingField = value;
				this.RaisePropertyChanged("FioOrUrName");
				this.RaisePropertyChanged("IoOrUrName");
				this.RaisePropertyChanged("patronymic");
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000331 RID: 817 RVA: 0x0000920C File Offset: 0x0000740C
		// (set) Token: 0x06000332 RID: 818 RVA: 0x00009220 File Offset: 0x00007420
		public int agent_phone_mask
		{
			[CompilerGenerated]
			get
			{
				return this.<agent_phone_mask>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<agent_phone_mask>k__BackingField == value)
				{
					return;
				}
				this.<agent_phone_mask>k__BackingField = value;
				this.RaisePropertyChanged("agent_phone_mask");
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000333 RID: 819 RVA: 0x0000924C File Offset: 0x0000744C
		// (set) Token: 0x06000334 RID: 820 RVA: 0x00009260 File Offset: 0x00007460
		public int agent2_phone_mask
		{
			[CompilerGenerated]
			get
			{
				return this.<agent2_phone_mask>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<agent2_phone_mask>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -1006399475;
				IL_10:
				switch ((num ^ -1585035112) % 4)
				{
				case 0:
					goto IL_0B;
				case 1:
					return;
				case 3:
					IL_2F:
					this.<agent2_phone_mask>k__BackingField = value;
					this.RaisePropertyChanged("agent2_phone_mask");
					num = -1892326366;
					goto IL_10;
				}
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000335 RID: 821 RVA: 0x000092B8 File Offset: 0x000074B8
		// (set) Token: 0x06000336 RID: 822 RVA: 0x000092CC File Offset: 0x000074CC
		public string address
		{
			[CompilerGenerated]
			get
			{
				return this.<address>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<address>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<address>k__BackingField = value;
				this.RaisePropertyChanged("address");
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000337 RID: 823 RVA: 0x000092FC File Offset: 0x000074FC
		// (set) Token: 0x06000338 RID: 824 RVA: 0x00009310 File Offset: 0x00007510
		public string post_index
		{
			[CompilerGenerated]
			get
			{
				return this.<post_index>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<post_index>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<post_index>k__BackingField = value;
				this.RaisePropertyChanged("post_index");
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000339 RID: 825 RVA: 0x00009340 File Offset: 0x00007540
		// (set) Token: 0x0600033A RID: 826 RVA: 0x00009354 File Offset: 0x00007554
		public string passport_num
		{
			[CompilerGenerated]
			get
			{
				return this.<passport_num>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<passport_num>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<passport_num>k__BackingField = value;
				this.RaisePropertyChanged("passport_num");
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600033B RID: 827 RVA: 0x00009384 File Offset: 0x00007584
		// (set) Token: 0x0600033C RID: 828 RVA: 0x00009398 File Offset: 0x00007598
		public DateTime? passport_date
		{
			[CompilerGenerated]
			get
			{
				return this.<passport_date>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<DateTime>(this.<passport_date>k__BackingField, value))
				{
					return;
				}
				this.<passport_date>k__BackingField = value;
				this.RaisePropertyChanged("passport_date");
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600033D RID: 829 RVA: 0x000093C8 File Offset: 0x000075C8
		// (set) Token: 0x0600033E RID: 830 RVA: 0x000093DC File Offset: 0x000075DC
		public string passport_organ
		{
			[CompilerGenerated]
			get
			{
				return this.<passport_organ>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<passport_organ>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<passport_organ>k__BackingField = value;
				this.RaisePropertyChanged("passport_organ");
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x0600033F RID: 831 RVA: 0x0000940C File Offset: 0x0000760C
		// (set) Token: 0x06000340 RID: 832 RVA: 0x00009420 File Offset: 0x00007620
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

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000341 RID: 833 RVA: 0x0000944C File Offset: 0x0000764C
		// (set) Token: 0x06000342 RID: 834 RVA: 0x00009460 File Offset: 0x00007660
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
				this.RaisePropertyChanged("FioOrUrName");
				this.RaisePropertyChanged("IoOrUrName");
				this.RaisePropertyChanged("type");
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000343 RID: 835 RVA: 0x000094A4 File Offset: 0x000076A4
		// (set) Token: 0x06000344 RID: 836 RVA: 0x000094B8 File Offset: 0x000076B8
		public DateTime? birthday
		{
			[CompilerGenerated]
			get
			{
				return this.<birthday>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<DateTime>(this.<birthday>k__BackingField, value))
				{
					return;
				}
				this.<birthday>k__BackingField = value;
				this.RaisePropertyChanged("birthday");
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000345 RID: 837 RVA: 0x000094E8 File Offset: 0x000076E8
		// (set) Token: 0x06000346 RID: 838 RVA: 0x000094FC File Offset: 0x000076FC
		public string memorial
		{
			[CompilerGenerated]
			get
			{
				return this.<memorial>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<memorial>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<memorial>k__BackingField = value;
				this.RaisePropertyChanged("memorial");
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000347 RID: 839 RVA: 0x0000952C File Offset: 0x0000772C
		// (set) Token: 0x06000348 RID: 840 RVA: 0x00009540 File Offset: 0x00007740
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

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000349 RID: 841 RVA: 0x00009570 File Offset: 0x00007770
		// (set) Token: 0x0600034A RID: 842 RVA: 0x00009584 File Offset: 0x00007784
		public bool is_regular
		{
			[CompilerGenerated]
			get
			{
				return this.<is_regular>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<is_regular>k__BackingField == value)
				{
					return;
				}
				this.<is_regular>k__BackingField = value;
				this.RaisePropertyChanged("is_regular");
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x0600034B RID: 843 RVA: 0x000095B0 File Offset: 0x000077B0
		// (set) Token: 0x0600034C RID: 844 RVA: 0x000095C4 File Offset: 0x000077C4
		public bool is_dealer
		{
			[CompilerGenerated]
			get
			{
				return this.<is_dealer>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<is_dealer>k__BackingField == value)
				{
					return;
				}
				this.<is_dealer>k__BackingField = value;
				this.RaisePropertyChanged("is_dealer");
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x0600034D RID: 845 RVA: 0x000095F0 File Offset: 0x000077F0
		// (set) Token: 0x0600034E RID: 846 RVA: 0x00009604 File Offset: 0x00007804
		public bool balance_enable
		{
			[CompilerGenerated]
			get
			{
				return this.<balance_enable>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<balance_enable>k__BackingField == value)
				{
					return;
				}
				this.<balance_enable>k__BackingField = value;
				this.RaisePropertyChanged("balance_enable");
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x0600034F RID: 847 RVA: 0x00009630 File Offset: 0x00007830
		// (set) Token: 0x06000350 RID: 848 RVA: 0x00009644 File Offset: 0x00007844
		public bool prefer_cashless
		{
			[CompilerGenerated]
			get
			{
				return this.<prefer_cashless>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<prefer_cashless>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -157252838;
				IL_10:
				switch ((num ^ -1111013296) % 4)
				{
				case 1:
					IL_2F:
					this.<prefer_cashless>k__BackingField = value;
					num = -1561027408;
					goto IL_10;
				case 2:
					return;
				case 3:
					goto IL_0B;
				}
				this.RaisePropertyChanged("prefer_cashless");
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000351 RID: 849 RVA: 0x0000969C File Offset: 0x0000789C
		// (set) Token: 0x06000352 RID: 850 RVA: 0x000096B0 File Offset: 0x000078B0
		public bool take_long
		{
			[CompilerGenerated]
			get
			{
				return this.<take_long>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<take_long>k__BackingField == value)
				{
					return;
				}
				this.<take_long>k__BackingField = value;
				this.RaisePropertyChanged("take_long");
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000353 RID: 851 RVA: 0x000096DC File Offset: 0x000078DC
		// (set) Token: 0x06000354 RID: 852 RVA: 0x000096F0 File Offset: 0x000078F0
		public bool ignore_calls
		{
			[CompilerGenerated]
			get
			{
				return this.<ignore_calls>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ignore_calls>k__BackingField == value)
				{
					return;
				}
				this.<ignore_calls>k__BackingField = value;
				this.RaisePropertyChanged("ignore_calls");
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000355 RID: 853 RVA: 0x0000971C File Offset: 0x0000791C
		// (set) Token: 0x06000356 RID: 854 RVA: 0x00009730 File Offset: 0x00007930
		public bool is_bad
		{
			[CompilerGenerated]
			get
			{
				return this.<is_bad>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<is_bad>k__BackingField == value)
				{
					return;
				}
				this.<is_bad>k__BackingField = value;
				this.RaisePropertyChanged("is_bad");
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000357 RID: 855 RVA: 0x0000975C File Offset: 0x0000795C
		// (set) Token: 0x06000358 RID: 856 RVA: 0x00009770 File Offset: 0x00007970
		public bool is_realizator
		{
			[CompilerGenerated]
			get
			{
				return this.<is_realizator>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<is_realizator>k__BackingField == value)
				{
					return;
				}
				this.<is_realizator>k__BackingField = value;
				this.RaisePropertyChanged("is_realizator");
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000359 RID: 857 RVA: 0x0000979C File Offset: 0x0000799C
		// (set) Token: 0x0600035A RID: 858 RVA: 0x000097B0 File Offset: 0x000079B0
		public bool is_agent
		{
			[CompilerGenerated]
			get
			{
				return this.<is_agent>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<is_agent>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = 354982959;
				IL_10:
				switch ((num ^ 379404858) % 4)
				{
				case 0:
					goto IL_0B;
				case 1:
					return;
				case 3:
					IL_2F:
					this.<is_agent>k__BackingField = value;
					this.RaisePropertyChanged("is_agent");
					num = 1721833564;
					goto IL_10;
				}
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x0600035B RID: 859 RVA: 0x00009808 File Offset: 0x00007A08
		// (set) Token: 0x0600035C RID: 860 RVA: 0x0000981C File Offset: 0x00007A1C
		public string INN
		{
			[CompilerGenerated]
			get
			{
				return this.<INN>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.<INN>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = 530924724;
				IL_14:
				switch ((num ^ 1527198174) % 4)
				{
				case 0:
					goto IL_0F;
				case 2:
					return;
				case 3:
					IL_33:
					this.<INN>k__BackingField = value;
					this.RaisePropertyChanged("INN");
					num = 1072422699;
					goto IL_14;
				}
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x0600035D RID: 861 RVA: 0x00009878 File Offset: 0x00007A78
		// (set) Token: 0x0600035E RID: 862 RVA: 0x0000988C File Offset: 0x00007A8C
		public string KPP
		{
			[CompilerGenerated]
			get
			{
				return this.<KPP>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<KPP>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<KPP>k__BackingField = value;
				this.RaisePropertyChanged("KPP");
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600035F RID: 863 RVA: 0x000098BC File Offset: 0x00007ABC
		// (set) Token: 0x06000360 RID: 864 RVA: 0x000098D0 File Offset: 0x00007AD0
		public string OGRN
		{
			[CompilerGenerated]
			get
			{
				return this.<OGRN>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<OGRN>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<OGRN>k__BackingField = value;
				this.RaisePropertyChanged("OGRN");
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000361 RID: 865 RVA: 0x00009900 File Offset: 0x00007B00
		// (set) Token: 0x06000362 RID: 866 RVA: 0x00009914 File Offset: 0x00007B14
		public string web_password
		{
			[CompilerGenerated]
			get
			{
				return this.<web_password>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<web_password>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<web_password>k__BackingField = value;
				this.RaisePropertyChanged("web_password");
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000363 RID: 867 RVA: 0x00009944 File Offset: 0x00007B44
		// (set) Token: 0x06000364 RID: 868 RVA: 0x00009958 File Offset: 0x00007B58
		public string ur_name
		{
			[CompilerGenerated]
			get
			{
				return this.<ur_name>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<ur_name>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<ur_name>k__BackingField = value;
				this.RaisePropertyChanged("FioOrUrName");
				this.RaisePropertyChanged("IoOrUrName");
				this.RaisePropertyChanged("ur_name");
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000365 RID: 869 RVA: 0x000099A0 File Offset: 0x00007BA0
		// (set) Token: 0x06000366 RID: 870 RVA: 0x000099B4 File Offset: 0x00007BB4
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

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000367 RID: 871 RVA: 0x000099E4 File Offset: 0x00007BE4
		// (set) Token: 0x06000368 RID: 872 RVA: 0x000099F8 File Offset: 0x00007BF8
		public string icq
		{
			[CompilerGenerated]
			get
			{
				return this.<icq>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.<icq>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = -2120491871;
				IL_14:
				switch ((num ^ -919342460) % 4)
				{
				case 0:
					IL_33:
					this.<icq>k__BackingField = value;
					this.RaisePropertyChanged("icq");
					num = -781315109;
					goto IL_14;
				case 1:
					return;
				case 2:
					goto IL_0F;
				}
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000369 RID: 873 RVA: 0x00009A54 File Offset: 0x00007C54
		// (set) Token: 0x0600036A RID: 874 RVA: 0x00009A68 File Offset: 0x00007C68
		public string skype
		{
			[CompilerGenerated]
			get
			{
				return this.<skype>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<skype>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<skype>k__BackingField = value;
				this.RaisePropertyChanged("skype");
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600036B RID: 875 RVA: 0x00009A98 File Offset: 0x00007C98
		// (set) Token: 0x0600036C RID: 876 RVA: 0x00009AAC File Offset: 0x00007CAC
		public string viber
		{
			[CompilerGenerated]
			get
			{
				return this.<viber>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.<viber>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = -204140582;
				IL_14:
				switch ((num ^ -398157260) % 4)
				{
				case 1:
					IL_33:
					num = -432336100;
					goto IL_14;
				case 2:
					return;
				case 3:
					goto IL_0F;
				}
				this.<viber>k__BackingField = value;
				this.RaisePropertyChanged("viber");
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x0600036D RID: 877 RVA: 0x00009B08 File Offset: 0x00007D08
		// (set) Token: 0x0600036E RID: 878 RVA: 0x00009B1C File Offset: 0x00007D1C
		public string telegram
		{
			[CompilerGenerated]
			get
			{
				return this.<telegram>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<telegram>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<telegram>k__BackingField = value;
				this.RaisePropertyChanged("telegram");
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x0600036F RID: 879 RVA: 0x00009B4C File Offset: 0x00007D4C
		// (set) Token: 0x06000370 RID: 880 RVA: 0x00009B60 File Offset: 0x00007D60
		public string site
		{
			[CompilerGenerated]
			get
			{
				return this.<site>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<site>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<site>k__BackingField = value;
				this.RaisePropertyChanged("site");
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000371 RID: 881 RVA: 0x00009B90 File Offset: 0x00007D90
		// (set) Token: 0x06000372 RID: 882 RVA: 0x00009BA4 File Offset: 0x00007DA4
		public string whatsapp
		{
			[CompilerGenerated]
			get
			{
				return this.<whatsapp>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.<whatsapp>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = 1021142271;
				IL_14:
				switch ((num ^ 1732439670) % 4)
				{
				case 0:
					IL_33:
					this.<whatsapp>k__BackingField = value;
					this.RaisePropertyChanged("whatsapp");
					num = 169731224;
					goto IL_14;
				case 1:
					return;
				case 3:
					goto IL_0F;
				}
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000373 RID: 883 RVA: 0x00009C00 File Offset: 0x00007E00
		// (set) Token: 0x06000374 RID: 884 RVA: 0x00009C14 File Offset: 0x00007E14
		public string agent_name
		{
			[CompilerGenerated]
			get
			{
				return this.<agent_name>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<agent_name>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<agent_name>k__BackingField = value;
				this.RaisePropertyChanged("agent_name");
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000375 RID: 885 RVA: 0x00009C44 File Offset: 0x00007E44
		// (set) Token: 0x06000376 RID: 886 RVA: 0x00009C58 File Offset: 0x00007E58
		public string agent_surname
		{
			[CompilerGenerated]
			get
			{
				return this.<agent_surname>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<agent_surname>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<agent_surname>k__BackingField = value;
				this.RaisePropertyChanged("agent_surname");
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000377 RID: 887 RVA: 0x00009C88 File Offset: 0x00007E88
		// (set) Token: 0x06000378 RID: 888 RVA: 0x00009C9C File Offset: 0x00007E9C
		public string agent_patronymic
		{
			[CompilerGenerated]
			get
			{
				return this.<agent_patronymic>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<agent_patronymic>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<agent_patronymic>k__BackingField = value;
				this.RaisePropertyChanged("agent_patronymic");
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000379 RID: 889 RVA: 0x00009CCC File Offset: 0x00007ECC
		// (set) Token: 0x0600037A RID: 890 RVA: 0x00009CE0 File Offset: 0x00007EE0
		public string agent_phone
		{
			[CompilerGenerated]
			get
			{
				return this.<agent_phone>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<agent_phone>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<agent_phone>k__BackingField = value;
				this.RaisePropertyChanged("agent_phone");
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600037B RID: 891 RVA: 0x00009D10 File Offset: 0x00007F10
		// (set) Token: 0x0600037C RID: 892 RVA: 0x00009D24 File Offset: 0x00007F24
		public string agent2_name
		{
			[CompilerGenerated]
			get
			{
				return this.<agent2_name>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<agent2_name>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<agent2_name>k__BackingField = value;
				this.RaisePropertyChanged("agent2_name");
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600037D RID: 893 RVA: 0x00009D54 File Offset: 0x00007F54
		// (set) Token: 0x0600037E RID: 894 RVA: 0x00009D68 File Offset: 0x00007F68
		public string agent2_surname
		{
			[CompilerGenerated]
			get
			{
				return this.<agent2_surname>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<agent2_surname>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<agent2_surname>k__BackingField = value;
				this.RaisePropertyChanged("agent2_surname");
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x0600037F RID: 895 RVA: 0x00009D98 File Offset: 0x00007F98
		// (set) Token: 0x06000380 RID: 896 RVA: 0x00009DAC File Offset: 0x00007FAC
		public string agent2_patronymic
		{
			[CompilerGenerated]
			get
			{
				return this.<agent2_patronymic>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<agent2_patronymic>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<agent2_patronymic>k__BackingField = value;
				this.RaisePropertyChanged("agent2_patronymic");
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000381 RID: 897 RVA: 0x00009DDC File Offset: 0x00007FDC
		// (set) Token: 0x06000382 RID: 898 RVA: 0x00009DF0 File Offset: 0x00007FF0
		public string agent2_phone
		{
			[CompilerGenerated]
			get
			{
				return this.<agent2_phone>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<agent2_phone>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<agent2_phone>k__BackingField = value;
				this.RaisePropertyChanged("agent2_phone");
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000383 RID: 899 RVA: 0x00009E20 File Offset: 0x00008020
		// (set) Token: 0x06000384 RID: 900 RVA: 0x00009E34 File Offset: 0x00008034
		public DateTime? created
		{
			[CompilerGenerated]
			get
			{
				return this.<created>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<DateTime>(this.<created>k__BackingField, value))
				{
					return;
				}
				this.<created>k__BackingField = value;
				this.RaisePropertyChanged("created");
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000385 RID: 901 RVA: 0x00009E64 File Offset: 0x00008064
		// (set) Token: 0x06000386 RID: 902 RVA: 0x00009E78 File Offset: 0x00008078
		public decimal balance
		{
			[CompilerGenerated]
			get
			{
				return this.<balance>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<balance>k__BackingField, value))
				{
					return;
				}
				this.<balance>k__BackingField = value;
				this.RaisePropertyChanged("balance");
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000387 RID: 903 RVA: 0x00009EA8 File Offset: 0x000080A8
		// (set) Token: 0x06000388 RID: 904 RVA: 0x00009EBC File Offset: 0x000080BC
		public int price_col
		{
			[CompilerGenerated]
			get
			{
				return this.<price_col>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<price_col>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -121776;
				IL_10:
				switch ((num ^ -1027858463) % 4)
				{
				case 1:
					return;
				case 2:
					IL_2F:
					this.<price_col>k__BackingField = value;
					this.RaisePropertyChanged("price_col");
					num = -1420937047;
					goto IL_10;
				case 3:
					goto IL_0B;
				}
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000389 RID: 905 RVA: 0x00009F14 File Offset: 0x00008114
		// (set) Token: 0x0600038A RID: 906 RVA: 0x00009F28 File Offset: 0x00008128
		public string agent_phone_clean
		{
			[CompilerGenerated]
			get
			{
				return this.<agent_phone_clean>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<agent_phone_clean>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<agent_phone_clean>k__BackingField = value;
				this.RaisePropertyChanged("agent_phone_clean");
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600038B RID: 907 RVA: 0x00009F58 File Offset: 0x00008158
		// (set) Token: 0x0600038C RID: 908 RVA: 0x00009F6C File Offset: 0x0000816C
		public string agent2_phone_clean
		{
			[CompilerGenerated]
			get
			{
				return this.<agent2_phone_clean>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<agent2_phone_clean>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<agent2_phone_clean>k__BackingField = value;
				this.RaisePropertyChanged("agent2_phone_clean");
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600038D RID: 909 RVA: 0x00009F9C File Offset: 0x0000819C
		// (set) Token: 0x0600038E RID: 910 RVA: 0x00009FB0 File Offset: 0x000081B0
		public int repairs
		{
			[CompilerGenerated]
			get
			{
				return this.<repairs>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<repairs>k__BackingField == value)
				{
					return;
				}
				this.<repairs>k__BackingField = value;
				this.RaisePropertyChanged("repairs");
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600038F RID: 911 RVA: 0x00009FDC File Offset: 0x000081DC
		// (set) Token: 0x06000390 RID: 912 RVA: 0x00009FF0 File Offset: 0x000081F0
		public string token
		{
			[CompilerGenerated]
			get
			{
				return this.<token>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.<token>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = -960661755;
				IL_14:
				switch ((num ^ -1526265314) % 4)
				{
				case 0:
					goto IL_0F;
				case 1:
					IL_33:
					this.<token>k__BackingField = value;
					num = -53434900;
					goto IL_14;
				case 3:
					return;
				}
				this.RaisePropertyChanged("token");
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000391 RID: 913 RVA: 0x0000A04C File Offset: 0x0000824C
		// (set) Token: 0x06000392 RID: 914 RVA: 0x0000A060 File Offset: 0x00008260
		public int purchases
		{
			[CompilerGenerated]
			get
			{
				return this.<purchases>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<purchases>k__BackingField == value)
				{
					return;
				}
				this.<purchases>k__BackingField = value;
				this.RaisePropertyChanged("purchases");
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000393 RID: 915 RVA: 0x0000A08C File Offset: 0x0000828C
		// (set) Token: 0x06000394 RID: 916 RVA: 0x0000A0A0 File Offset: 0x000082A0
		public int? visit_source
		{
			[CompilerGenerated]
			get
			{
				return this.<visit_source>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<visit_source>k__BackingField, value))
				{
					return;
				}
				this.<visit_source>k__BackingField = value;
				this.RaisePropertyChanged("visit_source");
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000395 RID: 917 RVA: 0x0000A0D0 File Offset: 0x000082D0
		// (set) Token: 0x06000396 RID: 918 RVA: 0x0000A0E4 File Offset: 0x000082E4
		public int? photo_id
		{
			[CompilerGenerated]
			get
			{
				return this.<photo_id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<photo_id>k__BackingField, value))
				{
					return;
				}
				this.<photo_id>k__BackingField = value;
				this.RaisePropertyChanged("photo_id");
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000397 RID: 919 RVA: 0x0000A114 File Offset: 0x00008314
		// (set) Token: 0x06000398 RID: 920 RVA: 0x0000A128 File Offset: 0x00008328
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

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000399 RID: 921 RVA: 0x0000A158 File Offset: 0x00008358
		// (set) Token: 0x0600039A RID: 922 RVA: 0x0000A16C File Offset: 0x0000836C
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

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x0600039B RID: 923 RVA: 0x0000A19C File Offset: 0x0000839C
		// (set) Token: 0x0600039C RID: 924 RVA: 0x0000A1B0 File Offset: 0x000083B0
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
				this.RaisePropertyChanged("store_items");
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x0600039D RID: 925 RVA: 0x0000A1E0 File Offset: 0x000083E0
		// (set) Token: 0x0600039E RID: 926 RVA: 0x0000A1F4 File Offset: 0x000083F4
		public virtual ICollection<store_sales> store_sales
		{
			[CompilerGenerated]
			get
			{
				return this.<store_sales>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<store_sales>k__BackingField, value))
				{
					return;
				}
				this.<store_sales>k__BackingField = value;
				this.RaisePropertyChanged("store_sales");
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600039F RID: 927 RVA: 0x0000A224 File Offset: 0x00008424
		// (set) Token: 0x060003A0 RID: 928 RVA: 0x0000A238 File Offset: 0x00008438
		public virtual ICollection<workshop> workshop
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

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x0000A268 File Offset: 0x00008468
		// (set) Token: 0x060003A2 RID: 930 RVA: 0x0000A27C File Offset: 0x0000847C
		public virtual ICollection<balance> balance1
		{
			[CompilerGenerated]
			get
			{
				return this.<balance1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<balance1>k__BackingField, value))
				{
					return;
				}
				this.<balance1>k__BackingField = value;
				this.RaisePropertyChanged("balance1");
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x0000A2AC File Offset: 0x000084AC
		// (set) Token: 0x060003A4 RID: 932 RVA: 0x0000A2C0 File Offset: 0x000084C0
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

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x0000A2F0 File Offset: 0x000084F0
		// (set) Token: 0x060003A6 RID: 934 RVA: 0x0000A304 File Offset: 0x00008504
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

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060003A7 RID: 935 RVA: 0x0000A334 File Offset: 0x00008534
		// (set) Token: 0x060003A8 RID: 936 RVA: 0x0000A348 File Offset: 0x00008548
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
				if (!object.Equals(this.<cash_orders>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1684544459;
				IL_13:
				switch ((num ^ -201725229) % 4)
				{
				case 1:
					IL_32:
					this.<cash_orders>k__BackingField = value;
					this.RaisePropertyChanged("cash_orders");
					num = -578746145;
					goto IL_13;
				case 2:
					return;
				case 3:
					goto IL_0E;
				}
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060003A9 RID: 937 RVA: 0x0000A3A4 File Offset: 0x000085A4
		// (set) Token: 0x060003AA RID: 938 RVA: 0x0000A3B8 File Offset: 0x000085B8
		public virtual ICollection<dealer_payments> dealer_payments
		{
			[CompilerGenerated]
			get
			{
				return this.<dealer_payments>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<dealer_payments>k__BackingField, value))
				{
					return;
				}
				this.<dealer_payments>k__BackingField = value;
				this.RaisePropertyChanged("dealer_payments");
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060003AB RID: 939 RVA: 0x0000A3E8 File Offset: 0x000085E8
		// (set) Token: 0x060003AC RID: 940 RVA: 0x0000A3FC File Offset: 0x000085FC
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

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060003AD RID: 941 RVA: 0x0000A42C File Offset: 0x0000862C
		// (set) Token: 0x060003AE RID: 942 RVA: 0x0000A440 File Offset: 0x00008640
		public virtual ICollection<payment_types> payment_types
		{
			[CompilerGenerated]
			get
			{
				return this.<payment_types>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<payment_types>k__BackingField, value))
				{
					return;
				}
				this.<payment_types>k__BackingField = value;
				this.RaisePropertyChanged("payment_types");
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060003AF RID: 943 RVA: 0x0000A470 File Offset: 0x00008670
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x0000A484 File Offset: 0x00008684
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

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x0000A4B4 File Offset: 0x000086B4
		// (set) Token: 0x060003B2 RID: 946 RVA: 0x0000A4C8 File Offset: 0x000086C8
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
				if (!object.Equals(this.<comments>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1723004905;
				IL_13:
				switch ((num ^ -287866146) % 4)
				{
				case 1:
					return;
				case 2:
					goto IL_0E;
				case 3:
					IL_32:
					this.<comments>k__BackingField = value;
					this.RaisePropertyChanged("comments");
					num = -642404226;
					goto IL_13;
				}
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x0000A524 File Offset: 0x00008724
		// (set) Token: 0x060003B4 RID: 948 RVA: 0x0000A538 File Offset: 0x00008738
		public virtual ICollection<parts_request> parts_request1
		{
			[CompilerGenerated]
			get
			{
				return this.<parts_request1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<parts_request1>k__BackingField, value))
				{
					return;
				}
				this.<parts_request1>k__BackingField = value;
				this.RaisePropertyChanged("parts_request1");
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x0000A568 File Offset: 0x00008768
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x0000A57C File Offset: 0x0000877C
		public virtual ICollection<out_sms> out_sms
		{
			[CompilerGenerated]
			get
			{
				return this.<out_sms>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<out_sms>k__BackingField, value))
				{
					return;
				}
				this.<out_sms>k__BackingField = value;
				this.RaisePropertyChanged("out_sms");
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x0000A5AC File Offset: 0x000087AC
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x0000A5C0 File Offset: 0x000087C0
		public virtual ICollection<tel> tel
		{
			[CompilerGenerated]
			get
			{
				return this.<tel>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<tel>k__BackingField, value))
				{
					return;
				}
				this.<tel>k__BackingField = value;
				this.RaisePropertyChanged("tel");
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x0000A5F0 File Offset: 0x000087F0
		// (set) Token: 0x060003BA RID: 954 RVA: 0x0000A604 File Offset: 0x00008804
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

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060003BB RID: 955 RVA: 0x0000A634 File Offset: 0x00008834
		// (set) Token: 0x060003BC RID: 956 RVA: 0x0000A648 File Offset: 0x00008848
		public virtual ICollection<store_sales> store_sales1
		{
			[CompilerGenerated]
			get
			{
				return this.<store_sales1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<store_sales1>k__BackingField, value))
				{
					return;
				}
				this.<store_sales1>k__BackingField = value;
				this.RaisePropertyChanged("store_sales1");
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060003BD RID: 957 RVA: 0x0000A678 File Offset: 0x00008878
		// (set) Token: 0x060003BE RID: 958 RVA: 0x0000A68C File Offset: 0x0000888C
		public virtual visit_sources visit_sources
		{
			[CompilerGenerated]
			get
			{
				return this.<visit_sources>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<visit_sources>k__BackingField, value))
				{
					return;
				}
				this.<visit_sources>k__BackingField = value;
				this.RaisePropertyChanged("visit_sources");
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060003BF RID: 959 RVA: 0x0000A6BC File Offset: 0x000088BC
		// (set) Token: 0x060003C0 RID: 960 RVA: 0x0000A6D0 File Offset: 0x000088D0
		public virtual ICollection<vendors> vendors
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

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x0000A700 File Offset: 0x00008900
		// (set) Token: 0x060003C2 RID: 962 RVA: 0x0000A714 File Offset: 0x00008914
		public virtual ICollection<vendors> vendors1
		{
			[CompilerGenerated]
			get
			{
				return this.<vendors1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<vendors1>k__BackingField, value))
				{
					return;
				}
				this.<vendors1>k__BackingField = value;
				this.RaisePropertyChanged("vendors1");
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x0000A744 File Offset: 0x00008944
		// (set) Token: 0x060003C4 RID: 964 RVA: 0x0000A758 File Offset: 0x00008958
		public virtual ICollection<buyout> buyout
		{
			[CompilerGenerated]
			get
			{
				return this.<buyout>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<buyout>k__BackingField, value))
				{
					return;
				}
				this.<buyout>k__BackingField = value;
				this.RaisePropertyChanged("buyout");
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x0000A788 File Offset: 0x00008988
		public virtual string FioOrUrName
		{
			get
			{
				if (this.type != 1)
				{
					return string.Concat(new string[]
					{
						this.surname,
						" ",
						this.name,
						" ",
						this.patronymic
					});
				}
				return this.ur_name;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x0000A7DC File Offset: 0x000089DC
		public virtual string IoOrUrName
		{
			get
			{
				if (this.type != 1)
				{
					return this.name + " " + this.patronymic;
				}
				return this.ur_name;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x0000A810 File Offset: 0x00008A10
		// (set) Token: 0x060003C8 RID: 968 RVA: 0x0000A824 File Offset: 0x00008A24
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

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x0000A854 File Offset: 0x00008A54
		// (set) Token: 0x060003CA RID: 970 RVA: 0x0000A868 File Offset: 0x00008A68
		public string phone_mask
		{
			[CompilerGenerated]
			get
			{
				return this.<phone_mask>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<phone_mask>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<phone_mask>k__BackingField = value;
				this.RaisePropertyChanged("phone_mask");
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060003CB RID: 971 RVA: 0x0000A898 File Offset: 0x00008A98
		// (set) Token: 0x060003CC RID: 972 RVA: 0x0000A8AC File Offset: 0x00008AAC
		public string phone2
		{
			[CompilerGenerated]
			get
			{
				return this.<phone2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<phone2>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<phone2>k__BackingField = value;
				this.RaisePropertyChanged("phone2");
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060003CD RID: 973 RVA: 0x0000A8DC File Offset: 0x00008ADC
		// (set) Token: 0x060003CE RID: 974 RVA: 0x0000A8F0 File Offset: 0x00008AF0
		public string phone2_mask
		{
			[CompilerGenerated]
			get
			{
				return this.<phone2_mask>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<phone2_mask>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<phone2_mask>k__BackingField = value;
				this.RaisePropertyChanged("phone2_mask");
			}
		}

		// Token: 0x0400017C RID: 380
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x0400017D RID: 381
		[CompilerGenerated]
		private int <creator>k__BackingField;

		// Token: 0x0400017E RID: 382
		[CompilerGenerated]
		private string <name>k__BackingField;

		// Token: 0x0400017F RID: 383
		[CompilerGenerated]
		private string <surname>k__BackingField;

		// Token: 0x04000180 RID: 384
		[CompilerGenerated]
		private string <patronymic>k__BackingField;

		// Token: 0x04000181 RID: 385
		[CompilerGenerated]
		private int <agent_phone_mask>k__BackingField;

		// Token: 0x04000182 RID: 386
		[CompilerGenerated]
		private int <agent2_phone_mask>k__BackingField;

		// Token: 0x04000183 RID: 387
		[CompilerGenerated]
		private string <address>k__BackingField;

		// Token: 0x04000184 RID: 388
		[CompilerGenerated]
		private string <post_index>k__BackingField;

		// Token: 0x04000185 RID: 389
		[CompilerGenerated]
		private string <passport_num>k__BackingField;

		// Token: 0x04000186 RID: 390
		[CompilerGenerated]
		private DateTime? <passport_date>k__BackingField;

		// Token: 0x04000187 RID: 391
		[CompilerGenerated]
		private string <passport_organ>k__BackingField;

		// Token: 0x04000188 RID: 392
		[CompilerGenerated]
		private int <state>k__BackingField;

		// Token: 0x04000189 RID: 393
		[CompilerGenerated]
		private int <type>k__BackingField;

		// Token: 0x0400018A RID: 394
		[CompilerGenerated]
		private DateTime? <birthday>k__BackingField;

		// Token: 0x0400018B RID: 395
		[CompilerGenerated]
		private string <memorial>k__BackingField;

		// Token: 0x0400018C RID: 396
		[CompilerGenerated]
		private string <notes>k__BackingField;

		// Token: 0x0400018D RID: 397
		[CompilerGenerated]
		private bool <is_regular>k__BackingField;

		// Token: 0x0400018E RID: 398
		[CompilerGenerated]
		private bool <is_dealer>k__BackingField;

		// Token: 0x0400018F RID: 399
		[CompilerGenerated]
		private bool <balance_enable>k__BackingField;

		// Token: 0x04000190 RID: 400
		[CompilerGenerated]
		private bool <prefer_cashless>k__BackingField;

		// Token: 0x04000191 RID: 401
		[CompilerGenerated]
		private bool <take_long>k__BackingField;

		// Token: 0x04000192 RID: 402
		[CompilerGenerated]
		private bool <ignore_calls>k__BackingField;

		// Token: 0x04000193 RID: 403
		[CompilerGenerated]
		private bool <is_bad>k__BackingField;

		// Token: 0x04000194 RID: 404
		[CompilerGenerated]
		private bool <is_realizator>k__BackingField;

		// Token: 0x04000195 RID: 405
		[CompilerGenerated]
		private bool <is_agent>k__BackingField;

		// Token: 0x04000196 RID: 406
		[CompilerGenerated]
		private string <INN>k__BackingField;

		// Token: 0x04000197 RID: 407
		[CompilerGenerated]
		private string <KPP>k__BackingField;

		// Token: 0x04000198 RID: 408
		[CompilerGenerated]
		private string <OGRN>k__BackingField;

		// Token: 0x04000199 RID: 409
		[CompilerGenerated]
		private string <web_password>k__BackingField;

		// Token: 0x0400019A RID: 410
		[CompilerGenerated]
		private string <ur_name>k__BackingField;

		// Token: 0x0400019B RID: 411
		[CompilerGenerated]
		private string <email>k__BackingField;

		// Token: 0x0400019C RID: 412
		[CompilerGenerated]
		private string <icq>k__BackingField;

		// Token: 0x0400019D RID: 413
		[CompilerGenerated]
		private string <skype>k__BackingField;

		// Token: 0x0400019E RID: 414
		[CompilerGenerated]
		private string <viber>k__BackingField;

		// Token: 0x0400019F RID: 415
		[CompilerGenerated]
		private string <telegram>k__BackingField;

		// Token: 0x040001A0 RID: 416
		[CompilerGenerated]
		private string <site>k__BackingField;

		// Token: 0x040001A1 RID: 417
		[CompilerGenerated]
		private string <whatsapp>k__BackingField;

		// Token: 0x040001A2 RID: 418
		[CompilerGenerated]
		private string <agent_name>k__BackingField;

		// Token: 0x040001A3 RID: 419
		[CompilerGenerated]
		private string <agent_surname>k__BackingField;

		// Token: 0x040001A4 RID: 420
		[CompilerGenerated]
		private string <agent_patronymic>k__BackingField;

		// Token: 0x040001A5 RID: 421
		[CompilerGenerated]
		private string <agent_phone>k__BackingField;

		// Token: 0x040001A6 RID: 422
		[CompilerGenerated]
		private string <agent2_name>k__BackingField;

		// Token: 0x040001A7 RID: 423
		[CompilerGenerated]
		private string <agent2_surname>k__BackingField;

		// Token: 0x040001A8 RID: 424
		[CompilerGenerated]
		private string <agent2_patronymic>k__BackingField;

		// Token: 0x040001A9 RID: 425
		[CompilerGenerated]
		private string <agent2_phone>k__BackingField;

		// Token: 0x040001AA RID: 426
		[CompilerGenerated]
		private DateTime? <created>k__BackingField;

		// Token: 0x040001AB RID: 427
		[CompilerGenerated]
		private decimal <balance>k__BackingField;

		// Token: 0x040001AC RID: 428
		[CompilerGenerated]
		private int <price_col>k__BackingField;

		// Token: 0x040001AD RID: 429
		[CompilerGenerated]
		private string <agent_phone_clean>k__BackingField;

		// Token: 0x040001AE RID: 430
		[CompilerGenerated]
		private string <agent2_phone_clean>k__BackingField;

		// Token: 0x040001AF RID: 431
		[CompilerGenerated]
		private int <repairs>k__BackingField;

		// Token: 0x040001B0 RID: 432
		[CompilerGenerated]
		private string <token>k__BackingField;

		// Token: 0x040001B1 RID: 433
		[CompilerGenerated]
		private int <purchases>k__BackingField;

		// Token: 0x040001B2 RID: 434
		[CompilerGenerated]
		private int? <visit_source>k__BackingField;

		// Token: 0x040001B3 RID: 435
		[CompilerGenerated]
		private int? <photo_id>k__BackingField;

		// Token: 0x040001B4 RID: 436
		[CompilerGenerated]
		private ICollection<banks> <banks>k__BackingField;

		// Token: 0x040001B5 RID: 437
		[CompilerGenerated]
		private ICollection<docs> <docs>k__BackingField;

		// Token: 0x040001B6 RID: 438
		[CompilerGenerated]
		private ICollection<store_items> <store_items>k__BackingField;

		// Token: 0x040001B7 RID: 439
		[CompilerGenerated]
		private ICollection<store_sales> <store_sales>k__BackingField;

		// Token: 0x040001B8 RID: 440
		[CompilerGenerated]
		private ICollection<workshop> <workshop>k__BackingField;

		// Token: 0x040001B9 RID: 441
		[CompilerGenerated]
		private ICollection<balance> <balance1>k__BackingField;

		// Token: 0x040001BA RID: 442
		[CompilerGenerated]
		private ICollection<logs> <logs>k__BackingField;

		// Token: 0x040001BB RID: 443
		[CompilerGenerated]
		private ICollection<media_info> <media_info>k__BackingField;

		// Token: 0x040001BC RID: 444
		[CompilerGenerated]
		private ICollection<cash_orders> <cash_orders>k__BackingField;

		// Token: 0x040001BD RID: 445
		[CompilerGenerated]
		private ICollection<dealer_payments> <dealer_payments>k__BackingField;

		// Token: 0x040001BE RID: 446
		[CompilerGenerated]
		private users <users>k__BackingField;

		// Token: 0x040001BF RID: 447
		[CompilerGenerated]
		private ICollection<payment_types> <payment_types>k__BackingField;

		// Token: 0x040001C0 RID: 448
		[CompilerGenerated]
		private ICollection<parts_request> <parts_request>k__BackingField;

		// Token: 0x040001C1 RID: 449
		[CompilerGenerated]
		private ICollection<comments> <comments>k__BackingField;

		// Token: 0x040001C2 RID: 450
		[CompilerGenerated]
		private ICollection<parts_request> <parts_request1>k__BackingField;

		// Token: 0x040001C3 RID: 451
		[CompilerGenerated]
		private ICollection<out_sms> <out_sms>k__BackingField;

		// Token: 0x040001C4 RID: 452
		[CompilerGenerated]
		private ICollection<tel> <tel>k__BackingField;

		// Token: 0x040001C5 RID: 453
		[CompilerGenerated]
		private ICollection<notifications> <notifications>k__BackingField;

		// Token: 0x040001C6 RID: 454
		[CompilerGenerated]
		private ICollection<store_sales> <store_sales1>k__BackingField;

		// Token: 0x040001C7 RID: 455
		[CompilerGenerated]
		private visit_sources <visit_sources>k__BackingField;

		// Token: 0x040001C8 RID: 456
		[CompilerGenerated]
		private ICollection<vendors> <vendors>k__BackingField;

		// Token: 0x040001C9 RID: 457
		[CompilerGenerated]
		private ICollection<vendors> <vendors1>k__BackingField;

		// Token: 0x040001CA RID: 458
		[CompilerGenerated]
		private ICollection<buyout> <buyout>k__BackingField;

		// Token: 0x040001CB RID: 459
		[CompilerGenerated]
		private string <phone>k__BackingField;

		// Token: 0x040001CC RID: 460
		[CompilerGenerated]
		private string <phone_mask>k__BackingField;

		// Token: 0x040001CD RID: 461
		[CompilerGenerated]
		private string <phone2>k__BackingField;

		// Token: 0x040001CE RID: 462
		[CompilerGenerated]
		private string <phone2_mask>k__BackingField;
	}
}
