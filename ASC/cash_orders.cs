using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DevExpress.Mvvm;

namespace ASC
{
	// Token: 0x02000024 RID: 36
	public class cash_orders : BindableBase
	{
		// Token: 0x06000115 RID: 277 RVA: 0x00005CDC File Offset: 0x00003EDC
		public cash_orders()
		{
			this.docs1 = new HashSet<docs>();
			this.order_items = new HashSet<order_items>();
			this.logs = new HashSet<logs>();
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00005D10 File Offset: 0x00003F10
		// (set) Token: 0x06000117 RID: 279 RVA: 0x00005D24 File Offset: 0x00003F24
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

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00005D50 File Offset: 0x00003F50
		// (set) Token: 0x06000119 RID: 281 RVA: 0x00005D64 File Offset: 0x00003F64
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
				if (!DateTime.Equals(this.<created>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1725627540;
				IL_13:
				switch ((num ^ -545550953) % 4)
				{
				case 0:
					goto IL_0E;
				case 2:
					IL_32:
					this.<created>k__BackingField = value;
					this.RaisePropertyChanged("created");
					num = -243030382;
					goto IL_13;
				case 3:
					return;
				}
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00005DC0 File Offset: 0x00003FC0
		// (set) Token: 0x0600011B RID: 283 RVA: 0x00005DD4 File Offset: 0x00003FD4
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

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00005E00 File Offset: 0x00004000
		// (set) Token: 0x0600011D RID: 285 RVA: 0x00005E14 File Offset: 0x00004014
		public decimal summa
		{
			[CompilerGenerated]
			get
			{
				return this.<summa>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<summa>k__BackingField, value))
				{
					return;
				}
				this.<summa>k__BackingField = value;
				this.RaisePropertyChanged("summa");
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00005E44 File Offset: 0x00004044
		// (set) Token: 0x0600011F RID: 287 RVA: 0x00005E58 File Offset: 0x00004058
		public string summa_str
		{
			[CompilerGenerated]
			get
			{
				return this.<summa_str>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<summa_str>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<summa_str>k__BackingField = value;
				this.RaisePropertyChanged("summa_str");
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00005E88 File Offset: 0x00004088
		// (set) Token: 0x06000121 RID: 289 RVA: 0x00005E9C File Offset: 0x0000409C
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

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00005ECC File Offset: 0x000040CC
		// (set) Token: 0x06000123 RID: 291 RVA: 0x00005EE0 File Offset: 0x000040E0
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

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00005F10 File Offset: 0x00004110
		// (set) Token: 0x06000125 RID: 293 RVA: 0x00005F24 File Offset: 0x00004124
		public int? to_user
		{
			[CompilerGenerated]
			get
			{
				return this.<to_user>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!Nullable.Equals<int>(this.<to_user>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -879170051;
				IL_13:
				switch ((num ^ -895473733) % 4)
				{
				case 1:
					IL_32:
					this.<to_user>k__BackingField = value;
					num = -1497369093;
					goto IL_13;
				case 2:
					return;
				case 3:
					goto IL_0E;
				}
				this.RaisePropertyChanged("to_user");
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00005F80 File Offset: 0x00004180
		// (set) Token: 0x06000127 RID: 295 RVA: 0x00005F94 File Offset: 0x00004194
		public int user
		{
			[CompilerGenerated]
			get
			{
				return this.<user>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<user>k__BackingField == value)
				{
					return;
				}
				this.<user>k__BackingField = value;
				this.RaisePropertyChanged("user");
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00005FC0 File Offset: 0x000041C0
		// (set) Token: 0x06000129 RID: 297 RVA: 0x00005FD4 File Offset: 0x000041D4
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

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00006000 File Offset: 0x00004200
		// (set) Token: 0x0600012B RID: 299 RVA: 0x00006014 File Offset: 0x00004214
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

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00006040 File Offset: 0x00004240
		// (set) Token: 0x0600012D RID: 301 RVA: 0x00006054 File Offset: 0x00004254
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
				if (!string.Equals(this.<notes>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = 497541483;
				IL_14:
				switch ((num ^ 1483489960) % 4)
				{
				case 0:
					IL_33:
					this.<notes>k__BackingField = value;
					this.RaisePropertyChanged("notes");
					num = 915292121;
					goto IL_14;
				case 2:
					goto IL_0F;
				case 3:
					return;
				}
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600012E RID: 302 RVA: 0x000060B0 File Offset: 0x000042B0
		// (set) Token: 0x0600012F RID: 303 RVA: 0x000060C4 File Offset: 0x000042C4
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
				this.RaisePropertyChanged("repair");
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000130 RID: 304 RVA: 0x000060F4 File Offset: 0x000042F4
		// (set) Token: 0x06000131 RID: 305 RVA: 0x00006108 File Offset: 0x00004308
		public int? document
		{
			[CompilerGenerated]
			get
			{
				return this.<document>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!Nullable.Equals<int>(this.<document>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1051566871;
				IL_13:
				switch ((num ^ 1118159890) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					return;
				case 3:
					IL_32:
					this.<document>k__BackingField = value;
					this.RaisePropertyChanged("document");
					num = 1282310500;
					goto IL_13;
				}
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00006164 File Offset: 0x00004364
		// (set) Token: 0x06000133 RID: 307 RVA: 0x00006178 File Offset: 0x00004378
		public int? img
		{
			[CompilerGenerated]
			get
			{
				return this.<img>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<img>k__BackingField, value))
				{
					return;
				}
				this.<img>k__BackingField = value;
				this.RaisePropertyChanged("img");
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000134 RID: 308 RVA: 0x000061A8 File Offset: 0x000043A8
		// (set) Token: 0x06000135 RID: 309 RVA: 0x000061BC File Offset: 0x000043BC
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
				this.RaisePropertyChanged("payment_system");
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000136 RID: 310 RVA: 0x000061E8 File Offset: 0x000043E8
		// (set) Token: 0x06000137 RID: 311 RVA: 0x000061FC File Offset: 0x000043FC
		public bool is_backdate
		{
			[CompilerGenerated]
			get
			{
				return this.<is_backdate>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<is_backdate>k__BackingField == value)
				{
					return;
				}
				this.<is_backdate>k__BackingField = value;
				this.RaisePropertyChanged("is_backdate");
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00006228 File Offset: 0x00004428
		// (set) Token: 0x06000139 RID: 313 RVA: 0x0000623C File Offset: 0x0000443C
		public decimal card_fee
		{
			[CompilerGenerated]
			get
			{
				return this.<card_fee>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<card_fee>k__BackingField, value))
				{
					return;
				}
				this.<card_fee>k__BackingField = value;
				this.RaisePropertyChanged("card_fee");
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600013A RID: 314 RVA: 0x0000626C File Offset: 0x0000446C
		// (set) Token: 0x0600013B RID: 315 RVA: 0x00006280 File Offset: 0x00004480
		public int? card_info
		{
			[CompilerGenerated]
			get
			{
				return this.<card_info>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<card_info>k__BackingField, value))
				{
					return;
				}
				this.<card_info>k__BackingField = value;
				this.RaisePropertyChanged("card_info");
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600013C RID: 316 RVA: 0x000062B0 File Offset: 0x000044B0
		// (set) Token: 0x0600013D RID: 317 RVA: 0x000062C4 File Offset: 0x000044C4
		public string customer_email
		{
			[CompilerGenerated]
			get
			{
				return this.<customer_email>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<customer_email>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<customer_email>k__BackingField = value;
				this.RaisePropertyChanged("customer_email");
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600013E RID: 318 RVA: 0x000062F4 File Offset: 0x000044F4
		// (set) Token: 0x0600013F RID: 319 RVA: 0x00006308 File Offset: 0x00004508
		public long? fdn
		{
			[CompilerGenerated]
			get
			{
				return this.<fdn>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<long>(this.<fdn>k__BackingField, value))
				{
					return;
				}
				this.<fdn>k__BackingField = value;
				this.RaisePropertyChanged("fdn");
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00006338 File Offset: 0x00004538
		// (set) Token: 0x06000141 RID: 321 RVA: 0x0000634C File Offset: 0x0000454C
		public int? payment_item_sign
		{
			[CompilerGenerated]
			get
			{
				return this.<payment_item_sign>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<payment_item_sign>k__BackingField, value))
				{
					return;
				}
				this.<payment_item_sign>k__BackingField = value;
				this.RaisePropertyChanged("payment_item_sign");
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000142 RID: 322 RVA: 0x0000637C File Offset: 0x0000457C
		// (set) Token: 0x06000143 RID: 323 RVA: 0x00006390 File Offset: 0x00004590
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

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000144 RID: 324 RVA: 0x000063C0 File Offset: 0x000045C0
		// (set) Token: 0x06000145 RID: 325 RVA: 0x000063D4 File Offset: 0x000045D4
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
				if (!object.Equals(this.<offices>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1564400112;
				IL_13:
				switch ((num ^ -806575615) % 4)
				{
				case 1:
					return;
				case 2:
					goto IL_0E;
				case 3:
					IL_32:
					num = -1225051867;
					goto IL_13;
				}
				this.<offices>k__BackingField = value;
				this.RaisePropertyChanged("offices");
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00006430 File Offset: 0x00004630
		// (set) Token: 0x06000147 RID: 327 RVA: 0x00006444 File Offset: 0x00004644
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

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000148 RID: 328 RVA: 0x00006474 File Offset: 0x00004674
		// (set) Token: 0x06000149 RID: 329 RVA: 0x00006488 File Offset: 0x00004688
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

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600014A RID: 330 RVA: 0x000064B8 File Offset: 0x000046B8
		// (set) Token: 0x0600014B RID: 331 RVA: 0x000064CC File Offset: 0x000046CC
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
				this.RaisePropertyChanged("docs1");
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600014C RID: 332 RVA: 0x000064FC File Offset: 0x000046FC
		// (set) Token: 0x0600014D RID: 333 RVA: 0x00006510 File Offset: 0x00004710
		public virtual ICollection<order_items> order_items
		{
			[CompilerGenerated]
			get
			{
				return this.<order_items>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<order_items>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -568778799;
				IL_13:
				switch ((num ^ -1762632921) % 4)
				{
				case 1:
					IL_32:
					this.<order_items>k__BackingField = value;
					this.RaisePropertyChanged("order_items");
					num = -595179361;
					goto IL_13;
				case 2:
					return;
				case 3:
					goto IL_0E;
				}
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600014E RID: 334 RVA: 0x0000656C File Offset: 0x0000476C
		// (set) Token: 0x0600014F RID: 335 RVA: 0x00006580 File Offset: 0x00004780
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

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000150 RID: 336 RVA: 0x000065B0 File Offset: 0x000047B0
		// (set) Token: 0x06000151 RID: 337 RVA: 0x000065C4 File Offset: 0x000047C4
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

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000152 RID: 338 RVA: 0x000065F4 File Offset: 0x000047F4
		// (set) Token: 0x06000153 RID: 339 RVA: 0x00006608 File Offset: 0x00004808
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

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00006638 File Offset: 0x00004838
		// (set) Token: 0x06000155 RID: 341 RVA: 0x0000664C File Offset: 0x0000484C
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

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000156 RID: 342 RVA: 0x0000667C File Offset: 0x0000487C
		// (set) Token: 0x06000157 RID: 343 RVA: 0x00006690 File Offset: 0x00004890
		public virtual images images
		{
			[CompilerGenerated]
			get
			{
				return this.<images>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<images>k__BackingField, value))
				{
					return;
				}
				this.<images>k__BackingField = value;
				this.RaisePropertyChanged("images");
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000158 RID: 344 RVA: 0x000066C0 File Offset: 0x000048C0
		// (set) Token: 0x06000159 RID: 345 RVA: 0x000066D4 File Offset: 0x000048D4
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
				if (!object.Equals(this.<invoice1>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1384924789;
				IL_13:
				switch ((num ^ 1268391596) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					return;
				case 2:
					IL_32:
					this.<invoice1>k__BackingField = value;
					this.RaisePropertyChanged("invoice1");
					num = 1825448115;
					goto IL_13;
				}
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600015A RID: 346 RVA: 0x00006730 File Offset: 0x00004930
		// (set) Token: 0x0600015B RID: 347 RVA: 0x00006744 File Offset: 0x00004944
		public virtual pinpad_logs pinpad_logs
		{
			[CompilerGenerated]
			get
			{
				return this.<pinpad_logs>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<pinpad_logs>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 2069264294;
				IL_13:
				switch ((num ^ 489359921) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					IL_32:
					num = 1060391959;
					goto IL_13;
				case 3:
					return;
				}
				this.<pinpad_logs>k__BackingField = value;
				this.RaisePropertyChanged("pinpad_logs");
			}
		}

		// Token: 0x0400007D RID: 125
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x0400007E RID: 126
		[CompilerGenerated]
		private DateTime <created>k__BackingField;

		// Token: 0x0400007F RID: 127
		[CompilerGenerated]
		private int <type>k__BackingField;

		// Token: 0x04000080 RID: 128
		[CompilerGenerated]
		private decimal <summa>k__BackingField;

		// Token: 0x04000081 RID: 129
		[CompilerGenerated]
		private string <summa_str>k__BackingField;

		// Token: 0x04000082 RID: 130
		[CompilerGenerated]
		private int? <invoice>k__BackingField;

		// Token: 0x04000083 RID: 131
		[CompilerGenerated]
		private int? <client>k__BackingField;

		// Token: 0x04000084 RID: 132
		[CompilerGenerated]
		private int? <to_user>k__BackingField;

		// Token: 0x04000085 RID: 133
		[CompilerGenerated]
		private int <user>k__BackingField;

		// Token: 0x04000086 RID: 134
		[CompilerGenerated]
		private int <company>k__BackingField;

		// Token: 0x04000087 RID: 135
		[CompilerGenerated]
		private int <office>k__BackingField;

		// Token: 0x04000088 RID: 136
		[CompilerGenerated]
		private string <notes>k__BackingField;

		// Token: 0x04000089 RID: 137
		[CompilerGenerated]
		private int? <repair>k__BackingField;

		// Token: 0x0400008A RID: 138
		[CompilerGenerated]
		private int? <document>k__BackingField;

		// Token: 0x0400008B RID: 139
		[CompilerGenerated]
		private int? <img>k__BackingField;

		// Token: 0x0400008C RID: 140
		[CompilerGenerated]
		private int <payment_system>k__BackingField;

		// Token: 0x0400008D RID: 141
		[CompilerGenerated]
		private bool <is_backdate>k__BackingField;

		// Token: 0x0400008E RID: 142
		[CompilerGenerated]
		private decimal <card_fee>k__BackingField;

		// Token: 0x0400008F RID: 143
		[CompilerGenerated]
		private int? <card_info>k__BackingField;

		// Token: 0x04000090 RID: 144
		[CompilerGenerated]
		private string <customer_email>k__BackingField;

		// Token: 0x04000091 RID: 145
		[CompilerGenerated]
		private long? <fdn>k__BackingField;

		// Token: 0x04000092 RID: 146
		[CompilerGenerated]
		private int? <payment_item_sign>k__BackingField;

		// Token: 0x04000093 RID: 147
		[CompilerGenerated]
		private clients <clients>k__BackingField;

		// Token: 0x04000094 RID: 148
		[CompilerGenerated]
		private offices <offices>k__BackingField;

		// Token: 0x04000095 RID: 149
		[CompilerGenerated]
		private workshop <workshop>k__BackingField;

		// Token: 0x04000096 RID: 150
		[CompilerGenerated]
		private docs <docs>k__BackingField;

		// Token: 0x04000097 RID: 151
		[CompilerGenerated]
		private ICollection<docs> <docs1>k__BackingField;

		// Token: 0x04000098 RID: 152
		[CompilerGenerated]
		private ICollection<order_items> <order_items>k__BackingField;

		// Token: 0x04000099 RID: 153
		[CompilerGenerated]
		private ICollection<logs> <logs>k__BackingField;

		// Token: 0x0400009A RID: 154
		[CompilerGenerated]
		private users <users>k__BackingField;

		// Token: 0x0400009B RID: 155
		[CompilerGenerated]
		private users <users1>k__BackingField;

		// Token: 0x0400009C RID: 156
		[CompilerGenerated]
		private companies <companies>k__BackingField;

		// Token: 0x0400009D RID: 157
		[CompilerGenerated]
		private images <images>k__BackingField;

		// Token: 0x0400009E RID: 158
		[CompilerGenerated]
		private invoice <invoice1>k__BackingField;

		// Token: 0x0400009F RID: 159
		[CompilerGenerated]
		private pinpad_logs <pinpad_logs>k__BackingField;
	}
}
