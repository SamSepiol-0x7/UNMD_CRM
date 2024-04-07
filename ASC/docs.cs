using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ASC.Extensions;
using ASC.Options;
using DevExpress.Mvvm;

namespace ASC
{
	// Token: 0x0200003B RID: 59
	public class docs : BindableBase
	{
		// Token: 0x06000534 RID: 1332 RVA: 0x0000C5E4 File Offset: 0x0000A7E4
		public docs()
		{
			this.store_items = new HashSet<store_items>();
			this.store_sales = new HashSet<store_sales>();
			this.works = new HashSet<works>();
			this.media_info = new HashSet<media_info>();
			this.cash_orders = new HashSet<cash_orders>();
			this.invoice_items = new HashSet<invoice_items>();
			this.tasks = new HashSet<tasks>();
			this.buyout = new HashSet<buyout>();
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x0000C65C File Offset: 0x0000A85C
		// (set) Token: 0x06000536 RID: 1334 RVA: 0x0000C670 File Offset: 0x0000A870
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
				this.RaisePropertyChanged("Profit");
				this.RaisePropertyChanged("ManagerPart");
				this.RaisePropertyChanged("id");
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x0000C6B4 File Offset: 0x0000A8B4
		// (set) Token: 0x06000538 RID: 1336 RVA: 0x0000C6C8 File Offset: 0x0000A8C8
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
				this.RaisePropertyChanged("Type");
				this.RaisePropertyChanged("type");
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x0000C700 File Offset: 0x0000A900
		// (set) Token: 0x0600053A RID: 1338 RVA: 0x0000C714 File Offset: 0x0000A914
		public int? state
		{
			[CompilerGenerated]
			get
			{
				return this.<state>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<state>k__BackingField, value))
				{
					return;
				}
				this.<state>k__BackingField = value;
				this.RaisePropertyChanged("state");
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x0000C744 File Offset: 0x0000A944
		// (set) Token: 0x0600053C RID: 1340 RVA: 0x0000C758 File Offset: 0x0000A958
		public bool is_realization
		{
			[CompilerGenerated]
			get
			{
				return this.<is_realization>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<is_realization>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = 210896619;
				IL_10:
				switch ((num ^ 912097929) % 4)
				{
				case 1:
					IL_2F:
					num = 1887923477;
					goto IL_10;
				case 2:
					return;
				case 3:
					goto IL_0B;
				}
				this.<is_realization>k__BackingField = value;
				this.RaisePropertyChanged("is_realization");
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x0000C7B0 File Offset: 0x0000A9B0
		// (set) Token: 0x0600053E RID: 1342 RVA: 0x0000C7C4 File Offset: 0x0000A9C4
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

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x0000C7F0 File Offset: 0x0000A9F0
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x0000C804 File Offset: 0x0000AA04
		public int? store
		{
			[CompilerGenerated]
			get
			{
				return this.<store>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<store>k__BackingField, value))
				{
					return;
				}
				this.<store>k__BackingField = value;
				this.RaisePropertyChanged("store");
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x0000C834 File Offset: 0x0000AA34
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x0000C848 File Offset: 0x0000AA48
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

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x0000C874 File Offset: 0x0000AA74
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x0000C888 File Offset: 0x0000AA88
		public decimal total
		{
			[CompilerGenerated]
			get
			{
				return this.<total>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<total>k__BackingField, value))
				{
					return;
				}
				this.<total>k__BackingField = value;
				this.RaisePropertyChanged("total");
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x0000C8B8 File Offset: 0x0000AAB8
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x0000C8CC File Offset: 0x0000AACC
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
				this.RaisePropertyChanged("CreateDateTime");
				this.RaisePropertyChanged("created");
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x0000C908 File Offset: 0x0000AB08
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x0000C91C File Offset: 0x0000AB1C
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

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x0000C948 File Offset: 0x0000AB48
		// (set) Token: 0x0600054A RID: 1354 RVA: 0x0000C95C File Offset: 0x0000AB5C
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
				if (!Nullable.Equals<int>(this.<dealer>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 795719699;
				IL_13:
				switch ((num ^ 1386342273) % 4)
				{
				case 0:
					goto IL_0E;
				case 2:
					return;
				case 3:
					IL_32:
					this.<dealer>k__BackingField = value;
					this.RaisePropertyChanged("dealer");
					num = 1729809348;
					goto IL_13;
				}
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x0000C9B8 File Offset: 0x0000ABB8
		// (set) Token: 0x0600054C RID: 1356 RVA: 0x0000C9CC File Offset: 0x0000ABCC
		public decimal? currency_rate
		{
			[CompilerGenerated]
			get
			{
				return this.<currency_rate>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<decimal>(this.<currency_rate>k__BackingField, value))
				{
					return;
				}
				this.<currency_rate>k__BackingField = value;
				this.RaisePropertyChanged("currency_rate");
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x0000C9FC File Offset: 0x0000ABFC
		// (set) Token: 0x0600054E RID: 1358 RVA: 0x0000CA10 File Offset: 0x0000AC10
		public byte[] img1
		{
			[CompilerGenerated]
			get
			{
				return this.<img1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<img1>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 992857875;
				IL_13:
				switch ((num ^ 864277064) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					IL_32:
					this.<img1>k__BackingField = value;
					this.RaisePropertyChanged("img1");
					num = 471344994;
					goto IL_13;
				case 3:
					return;
				}
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x0000CA6C File Offset: 0x0000AC6C
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x0000CA80 File Offset: 0x0000AC80
		public byte[] img2
		{
			[CompilerGenerated]
			get
			{
				return this.<img2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<img2>k__BackingField, value))
				{
					return;
				}
				this.<img2>k__BackingField = value;
				this.RaisePropertyChanged("img2");
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x0000CAB0 File Offset: 0x0000ACB0
		// (set) Token: 0x06000552 RID: 1362 RVA: 0x0000CAC4 File Offset: 0x0000ACC4
		public byte[] img3
		{
			[CompilerGenerated]
			get
			{
				return this.<img3>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<img3>k__BackingField, value))
				{
					return;
				}
				this.<img3>k__BackingField = value;
				this.RaisePropertyChanged("img3");
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x0000CAF4 File Offset: 0x0000ACF4
		// (set) Token: 0x06000554 RID: 1364 RVA: 0x0000CB08 File Offset: 0x0000AD08
		public string reason
		{
			[CompilerGenerated]
			get
			{
				return this.<reason>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.<reason>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = 1645535049;
				IL_14:
				switch ((num ^ 782658751) % 4)
				{
				case 0:
					goto IL_0F;
				case 1:
					IL_33:
					this.<reason>k__BackingField = value;
					this.RaisePropertyChanged("reason");
					num = 549727152;
					goto IL_14;
				case 2:
					return;
				}
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x0000CB64 File Offset: 0x0000AD64
		// (set) Token: 0x06000556 RID: 1366 RVA: 0x0000CB78 File Offset: 0x0000AD78
		public int? order_id
		{
			[CompilerGenerated]
			get
			{
				return this.<order_id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<order_id>k__BackingField, value))
				{
					return;
				}
				this.<order_id>k__BackingField = value;
				this.RaisePropertyChanged("order_id");
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x0000CBA8 File Offset: 0x0000ADA8
		// (set) Token: 0x06000558 RID: 1368 RVA: 0x0000CBBC File Offset: 0x0000ADBC
		public int price_option
		{
			[CompilerGenerated]
			get
			{
				return this.<price_option>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<price_option>k__BackingField == value)
				{
					return;
				}
				this.<price_option>k__BackingField = value;
				this.RaisePropertyChanged("DealerPercentVisible");
				this.RaisePropertyChanged("price_option");
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x0000CBF4 File Offset: 0x0000ADF4
		// (set) Token: 0x0600055A RID: 1370 RVA: 0x0000CC08 File Offset: 0x0000AE08
		public int return_percent
		{
			[CompilerGenerated]
			get
			{
				return this.<return_percent>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<return_percent>k__BackingField == value)
				{
					return;
				}
				this.<return_percent>k__BackingField = value;
				this.RaisePropertyChanged("return_percent");
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x0000CC34 File Offset: 0x0000AE34
		// (set) Token: 0x0600055C RID: 1372 RVA: 0x0000CC48 File Offset: 0x0000AE48
		public int reserve_days
		{
			[CompilerGenerated]
			get
			{
				return this.<reserve_days>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<reserve_days>k__BackingField == value)
				{
					return;
				}
				this.<reserve_days>k__BackingField = value;
				this.RaisePropertyChanged("reserve_days");
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x0000CC74 File Offset: 0x0000AE74
		// (set) Token: 0x0600055E RID: 1374 RVA: 0x0000CC88 File Offset: 0x0000AE88
		public int? master_id
		{
			[CompilerGenerated]
			get
			{
				return this.<master_id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<master_id>k__BackingField, value))
				{
					return;
				}
				this.<master_id>k__BackingField = value;
				this.RaisePropertyChanged("master_id");
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x0000CCB8 File Offset: 0x0000AEB8
		// (set) Token: 0x06000560 RID: 1376 RVA: 0x0000CCCC File Offset: 0x0000AECC
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
				this.RaisePropertyChanged("repair_id");
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x0000CCFC File Offset: 0x0000AEFC
		// (set) Token: 0x06000562 RID: 1378 RVA: 0x0000CD10 File Offset: 0x0000AF10
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

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x0000CD3C File Offset: 0x0000AF3C
		// (set) Token: 0x06000564 RID: 1380 RVA: 0x0000CD50 File Offset: 0x0000AF50
		public bool works_included
		{
			[CompilerGenerated]
			get
			{
				return this.<works_included>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<works_included>k__BackingField == value)
				{
					return;
				}
				this.<works_included>k__BackingField = value;
				this.RaisePropertyChanged("works_included");
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x0000CD7C File Offset: 0x0000AF7C
		// (set) Token: 0x06000566 RID: 1382 RVA: 0x0000CD90 File Offset: 0x0000AF90
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

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000567 RID: 1383 RVA: 0x0000CDC0 File Offset: 0x0000AFC0
		// (set) Token: 0x06000568 RID: 1384 RVA: 0x0000CDD4 File Offset: 0x0000AFD4
		public string track
		{
			[CompilerGenerated]
			get
			{
				return this.<track>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.<track>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = 1578644925;
				IL_14:
				switch ((num ^ 1085995863) % 4)
				{
				case 0:
					goto IL_0F;
				case 2:
					return;
				case 3:
					IL_33:
					this.<track>k__BackingField = value;
					this.RaisePropertyChanged("track");
					num = 766336526;
					goto IL_14;
				}
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x0000CE30 File Offset: 0x0000B030
		// (set) Token: 0x0600056A RID: 1386 RVA: 0x0000CE44 File Offset: 0x0000B044
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

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x0000CE74 File Offset: 0x0000B074
		// (set) Token: 0x0600056C RID: 1388 RVA: 0x0000CE88 File Offset: 0x0000B088
		public int? d_store
		{
			[CompilerGenerated]
			get
			{
				return this.<d_store>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!Nullable.Equals<int>(this.<d_store>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1067551879;
				IL_13:
				switch ((num ^ -356826589) % 4)
				{
				case 1:
					IL_32:
					this.<d_store>k__BackingField = value;
					this.RaisePropertyChanged("d_store");
					num = -1303507997;
					goto IL_13;
				case 2:
					return;
				case 3:
					goto IL_0E;
				}
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x0000CEE4 File Offset: 0x0000B0E4
		// (set) Token: 0x0600056E RID: 1390 RVA: 0x0000CEF8 File Offset: 0x0000B0F8
		public DateTime? updated_at
		{
			[CompilerGenerated]
			get
			{
				return this.<updated_at>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<DateTime>(this.<updated_at>k__BackingField, value))
				{
					return;
				}
				this.<updated_at>k__BackingField = value;
				this.RaisePropertyChanged("updated_at");
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x0000CF28 File Offset: 0x0000B128
		// (set) Token: 0x06000570 RID: 1392 RVA: 0x0000CF3C File Offset: 0x0000B13C
		public bool d_pay
		{
			[CompilerGenerated]
			get
			{
				return this.<d_pay>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<d_pay>k__BackingField == value)
				{
					return;
				}
				this.<d_pay>k__BackingField = value;
				this.RaisePropertyChanged("d_pay");
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x0000CF68 File Offset: 0x0000B168
		// (set) Token: 0x06000572 RID: 1394 RVA: 0x0000CF7C File Offset: 0x0000B17C
		public virtual stores stores
		{
			[CompilerGenerated]
			get
			{
				return this.<stores>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<stores>k__BackingField, value))
				{
					return;
				}
				this.<stores>k__BackingField = value;
				this.RaisePropertyChanged("stores");
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x0000CFAC File Offset: 0x0000B1AC
		// (set) Token: 0x06000574 RID: 1396 RVA: 0x0000CFC0 File Offset: 0x0000B1C0
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
				if (!object.Equals(this.<store_items>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 2038856563;
				IL_13:
				switch ((num ^ 1400704592) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					IL_32:
					num = 1816448678;
					goto IL_13;
				case 3:
					return;
				}
				this.<store_items>k__BackingField = value;
				this.RaisePropertyChanged("store_items");
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x0000D01C File Offset: 0x0000B21C
		// (set) Token: 0x06000576 RID: 1398 RVA: 0x0000D030 File Offset: 0x0000B230
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

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x0000D060 File Offset: 0x0000B260
		// (set) Token: 0x06000578 RID: 1400 RVA: 0x0000D074 File Offset: 0x0000B274
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

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x0000D0A4 File Offset: 0x0000B2A4
		// (set) Token: 0x0600057A RID: 1402 RVA: 0x0000D0B8 File Offset: 0x0000B2B8
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
				this.RaisePropertyChanged("works");
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x0000D0E8 File Offset: 0x0000B2E8
		// (set) Token: 0x0600057C RID: 1404 RVA: 0x0000D0FC File Offset: 0x0000B2FC
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

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x0000D12C File Offset: 0x0000B32C
		// (set) Token: 0x0600057E RID: 1406 RVA: 0x0000D140 File Offset: 0x0000B340
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
				int num = 1996019242;
				IL_13:
				switch ((num ^ 1678729921) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					IL_32:
					num = 1707025683;
					goto IL_13;
				case 3:
					return;
				}
				this.<offices>k__BackingField = value;
				this.RaisePropertyChanged("offices");
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x0000D19C File Offset: 0x0000B39C
		// (set) Token: 0x06000580 RID: 1408 RVA: 0x0000D1B0 File Offset: 0x0000B3B0
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

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x0000D1E0 File Offset: 0x0000B3E0
		// (set) Token: 0x06000582 RID: 1410 RVA: 0x0000D1F4 File Offset: 0x0000B3F4
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

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x0000D224 File Offset: 0x0000B424
		// (set) Token: 0x06000584 RID: 1412 RVA: 0x0000D238 File Offset: 0x0000B438
		public virtual cash_orders cash_orders1
		{
			[CompilerGenerated]
			get
			{
				return this.<cash_orders1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<cash_orders1>k__BackingField, value))
				{
					return;
				}
				this.<cash_orders1>k__BackingField = value;
				this.RaisePropertyChanged("cash_orders1");
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x0000D268 File Offset: 0x0000B468
		// (set) Token: 0x06000586 RID: 1414 RVA: 0x0000D27C File Offset: 0x0000B47C
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
				this.RaisePropertyChanged("ManagerFio");
				this.RaisePropertyChanged("ManagerPart");
				this.RaisePropertyChanged("users");
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x0000D2C0 File Offset: 0x0000B4C0
		// (set) Token: 0x06000588 RID: 1416 RVA: 0x0000D2D4 File Offset: 0x0000B4D4
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

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x0000D304 File Offset: 0x0000B504
		// (set) Token: 0x0600058A RID: 1418 RVA: 0x0000D318 File Offset: 0x0000B518
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

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x0000D348 File Offset: 0x0000B548
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x0000D35C File Offset: 0x0000B55C
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

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x0000D38C File Offset: 0x0000B58C
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x0000D3A0 File Offset: 0x0000B5A0
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

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x0000D3D0 File Offset: 0x0000B5D0
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x0000D3E4 File Offset: 0x0000B5E4
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
				if (object.Equals(this.<tasks>k__BackingField, value))
				{
					return;
				}
				this.<tasks>k__BackingField = value;
				this.RaisePropertyChanged("tasks");
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x0000D414 File Offset: 0x0000B614
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x0000D428 File Offset: 0x0000B628
		public virtual stores stores1
		{
			[CompilerGenerated]
			get
			{
				return this.<stores1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<stores1>k__BackingField, value))
				{
					return;
				}
				this.<stores1>k__BackingField = value;
				this.RaisePropertyChanged("stores1");
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x0000D458 File Offset: 0x0000B658
		// (set) Token: 0x06000594 RID: 1428 RVA: 0x0000D46C File Offset: 0x0000B66C
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

		// Token: 0x06000595 RID: 1429 RVA: 0x0000D49C File Offset: 0x0000B69C
		public docs(bool defaultValues = false)
		{
			if (defaultValues)
			{
				Localization localization = new Localization("UTC");
				this.state = new int?(0);
				this.created = localization.Now;
				this.office = Auth.User.office;
				this.user = Auth.User.id;
				this.total = 0m;
				this.currency_rate = new decimal?(0m);
				this.reserve_days = 0;
				this.reason = "";
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x0000D534 File Offset: 0x0000B734
		public virtual string ManagerFio
		{
			get
			{
				string[] array = new string[5];
				int num = 0;
				users users = this.users;
				array[num] = ((users != null) ? users.surname : null);
				array[1] = " ";
				int num2 = 2;
				users users2 = this.users;
				array[num2] = ((users2 != null) ? users2.name.FirstOrEmpty(true) : null);
				array[3] = " ";
				int num3 = 4;
				users users3 = this.users;
				array[num3] = ((users3 != null) ? users3.patronymic.FirstOrEmpty(true) : null);
				return string.Concat(array);
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x0000D5A8 File Offset: 0x0000B7A8
		public virtual DateTime CreateDateTime
		{
			get
			{
				return Localization.ToLocalTimeZone(this.created);
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x0000D5C0 File Offset: 0x0000B7C0
		public virtual string Type
		{
			get
			{
				return this._documentOptions.GetOptionById(this.type);
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x0000D5E0 File Offset: 0x0000B7E0
		public virtual decimal Profit
		{
			get
			{
				if (this.id == 0)
				{
					return 0m;
				}
				decimal result;
				try
				{
					using (auseceEntities auseceEntities = new auseceEntities(true))
					{
						List<store_sales> source = (from s in auseceEntities.store_sales
						where s.document_id == this.id
						select s).ToList<store_sales>();
						if (source.Any<store_sales>())
						{
							result = source.Sum(delegate(store_sales item)
							{
								if (!item.is_realization)
								{
									return item.price * item.count - item.in_price * item.count;
								}
								return item.price * item.count - item.RealizatorPart * item.count;
							});
						}
						else
						{
							result = 0m;
						}
					}
				}
				catch (Exception value)
				{
					Console.WriteLine(value);
					result = 0m;
				}
				return result;
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x0000D6E4 File Offset: 0x0000B8E4
		public virtual decimal ManagerPart
		{
			get
			{
				users users = this.users;
				bool flag;
				if (users == null)
				{
					flag = true;
				}
				else
				{
					int pay_sale = users.pay_sale;
					flag = false;
				}
				if (flag)
				{
					return 0m;
				}
				return this.Profit / 100m * this.users.pay_sale;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x0000D734 File Offset: 0x0000B934
		public bool DealerPercentVisible
		{
			get
			{
				return this.price_option == 3 && Auth.Config.realizator_enable;
			}
		}

		// Token: 0x0400027D RID: 637
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x0400027E RID: 638
		[CompilerGenerated]
		private int <type>k__BackingField;

		// Token: 0x0400027F RID: 639
		[CompilerGenerated]
		private int? <state>k__BackingField;

		// Token: 0x04000280 RID: 640
		[CompilerGenerated]
		private bool <is_realization>k__BackingField;

		// Token: 0x04000281 RID: 641
		[CompilerGenerated]
		private int <company>k__BackingField;

		// Token: 0x04000282 RID: 642
		[CompilerGenerated]
		private int? <store>k__BackingField;

		// Token: 0x04000283 RID: 643
		[CompilerGenerated]
		private int <user>k__BackingField;

		// Token: 0x04000284 RID: 644
		[CompilerGenerated]
		private decimal <total>k__BackingField;

		// Token: 0x04000285 RID: 645
		[CompilerGenerated]
		private DateTime <created>k__BackingField;

		// Token: 0x04000286 RID: 646
		[CompilerGenerated]
		private int <office>k__BackingField;

		// Token: 0x04000287 RID: 647
		[CompilerGenerated]
		private int? <dealer>k__BackingField;

		// Token: 0x04000288 RID: 648
		[CompilerGenerated]
		private decimal? <currency_rate>k__BackingField;

		// Token: 0x04000289 RID: 649
		[CompilerGenerated]
		private byte[] <img1>k__BackingField;

		// Token: 0x0400028A RID: 650
		[CompilerGenerated]
		private byte[] <img2>k__BackingField;

		// Token: 0x0400028B RID: 651
		[CompilerGenerated]
		private byte[] <img3>k__BackingField;

		// Token: 0x0400028C RID: 652
		[CompilerGenerated]
		private string <reason>k__BackingField;

		// Token: 0x0400028D RID: 653
		[CompilerGenerated]
		private int? <order_id>k__BackingField;

		// Token: 0x0400028E RID: 654
		[CompilerGenerated]
		private int <price_option>k__BackingField;

		// Token: 0x0400028F RID: 655
		[CompilerGenerated]
		private int <return_percent>k__BackingField;

		// Token: 0x04000290 RID: 656
		[CompilerGenerated]
		private int <reserve_days>k__BackingField;

		// Token: 0x04000291 RID: 657
		[CompilerGenerated]
		private int? <master_id>k__BackingField;

		// Token: 0x04000292 RID: 658
		[CompilerGenerated]
		private int? <repair_id>k__BackingField;

		// Token: 0x04000293 RID: 659
		[CompilerGenerated]
		private int <payment_system>k__BackingField;

		// Token: 0x04000294 RID: 660
		[CompilerGenerated]
		private bool <works_included>k__BackingField;

		// Token: 0x04000295 RID: 661
		[CompilerGenerated]
		private int? <invoice>k__BackingField;

		// Token: 0x04000296 RID: 662
		[CompilerGenerated]
		private string <track>k__BackingField;

		// Token: 0x04000297 RID: 663
		[CompilerGenerated]
		private string <notes>k__BackingField;

		// Token: 0x04000298 RID: 664
		[CompilerGenerated]
		private int? <d_store>k__BackingField;

		// Token: 0x04000299 RID: 665
		[CompilerGenerated]
		private DateTime? <updated_at>k__BackingField;

		// Token: 0x0400029A RID: 666
		[CompilerGenerated]
		private bool <d_pay>k__BackingField;

		// Token: 0x0400029B RID: 667
		[CompilerGenerated]
		private stores <stores>k__BackingField;

		// Token: 0x0400029C RID: 668
		[CompilerGenerated]
		private ICollection<store_items> <store_items>k__BackingField;

		// Token: 0x0400029D RID: 669
		[CompilerGenerated]
		private ICollection<store_sales> <store_sales>k__BackingField;

		// Token: 0x0400029E RID: 670
		[CompilerGenerated]
		private workshop <workshop>k__BackingField;

		// Token: 0x0400029F RID: 671
		[CompilerGenerated]
		private ICollection<works> <works>k__BackingField;

		// Token: 0x040002A0 RID: 672
		[CompilerGenerated]
		private clients <clients>k__BackingField;

		// Token: 0x040002A1 RID: 673
		[CompilerGenerated]
		private offices <offices>k__BackingField;

		// Token: 0x040002A2 RID: 674
		[CompilerGenerated]
		private ICollection<media_info> <media_info>k__BackingField;

		// Token: 0x040002A3 RID: 675
		[CompilerGenerated]
		private ICollection<cash_orders> <cash_orders>k__BackingField;

		// Token: 0x040002A4 RID: 676
		[CompilerGenerated]
		private cash_orders <cash_orders1>k__BackingField;

		// Token: 0x040002A5 RID: 677
		[CompilerGenerated]
		private users <users>k__BackingField;

		// Token: 0x040002A6 RID: 678
		[CompilerGenerated]
		private users <users1>k__BackingField;

		// Token: 0x040002A7 RID: 679
		[CompilerGenerated]
		private companies <companies>k__BackingField;

		// Token: 0x040002A8 RID: 680
		[CompilerGenerated]
		private ICollection<invoice_items> <invoice_items>k__BackingField;

		// Token: 0x040002A9 RID: 681
		[CompilerGenerated]
		private invoice <invoice1>k__BackingField;

		// Token: 0x040002AA RID: 682
		[CompilerGenerated]
		private ICollection<tasks> <tasks>k__BackingField;

		// Token: 0x040002AB RID: 683
		[CompilerGenerated]
		private stores <stores1>k__BackingField;

		// Token: 0x040002AC RID: 684
		[CompilerGenerated]
		private ICollection<buyout> <buyout>k__BackingField;

		// Token: 0x040002AD RID: 685
		private DocumentOptions _documentOptions = new DocumentOptions();

		// Token: 0x0200003C RID: 60
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600059C RID: 1436 RVA: 0x0000D758 File Offset: 0x0000B958
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600059D RID: 1437 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x0600059E RID: 1438 RVA: 0x0000D770 File Offset: 0x0000B970
			internal decimal <get_Profit>b__202_1(store_sales item)
			{
				if (!item.is_realization)
				{
					return item.price * item.count - item.in_price * item.count;
				}
				return item.price * item.count - item.RealizatorPart * item.count;
			}

			// Token: 0x040002AE RID: 686
			public static readonly docs.<>c <>9 = new docs.<>c();

			// Token: 0x040002AF RID: 687
			public static Func<store_sales, decimal> <>9__202_1;
		}
	}
}
