using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using ASC.Common.Entities;
using ASC.Options;
using DevExpress.Mvvm;

namespace ASC
{
	// Token: 0x02000076 RID: 118
	public class store_items : BindableBase, IBaseObject, IEntity
	{
		// Token: 0x06000D67 RID: 3431 RVA: 0x0001868C File Offset: 0x0001688C
		public store_items()
		{
			this.order_items = new HashSet<order_items>();
			this.workshop_parts = new HashSet<workshop_parts>();
			this.store_sales = new HashSet<store_sales>();
			this.logs = new HashSet<logs>();
			this.store_int_reserve = new HashSet<store_int_reserve>();
			this.parts_request = new HashSet<parts_request>();
			this.field_values = new HashSet<field_values>();
			this.images = new HashSet<images>();
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06000D68 RID: 3432 RVA: 0x00018710 File Offset: 0x00016910
		// (set) Token: 0x06000D69 RID: 3433 RVA: 0x00018724 File Offset: 0x00016924
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
				this.RaisePropertyChanged("UID");
				this.RaisePropertyChanged("Id");
				this.RaisePropertyChanged("id");
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06000D6A RID: 3434 RVA: 0x00018768 File Offset: 0x00016968
		// (set) Token: 0x06000D6B RID: 3435 RVA: 0x0001877C File Offset: 0x0001697C
		public int articul
		{
			[CompilerGenerated]
			get
			{
				return this.<articul>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<articul>k__BackingField == value)
				{
					return;
				}
				this.<articul>k__BackingField = value;
				this.RaisePropertyChanged("UID");
				this.RaisePropertyChanged("articul");
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06000D6C RID: 3436 RVA: 0x000187B4 File Offset: 0x000169B4
		// (set) Token: 0x06000D6D RID: 3437 RVA: 0x000187C8 File Offset: 0x000169C8
		public int dealer
		{
			[CompilerGenerated]
			get
			{
				return this.<dealer>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<dealer>k__BackingField == value)
				{
					return;
				}
				this.<dealer>k__BackingField = value;
				this.RaisePropertyChanged("dealer");
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06000D6E RID: 3438 RVA: 0x000187F4 File Offset: 0x000169F4
		// (set) Token: 0x06000D6F RID: 3439 RVA: 0x00018808 File Offset: 0x00016A08
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
				if (this.<is_realization>k__BackingField == value)
				{
					return;
				}
				this.<is_realization>k__BackingField = value;
				this.RaisePropertyChanged("Price1Formatted");
				this.RaisePropertyChanged("Price2Formatted");
				this.RaisePropertyChanged("Price3Formatted");
				this.RaisePropertyChanged("Price4Formatted");
				this.RaisePropertyChanged("Price5Formatted");
				this.RaisePropertyChanged("Price1Raw");
				this.RaisePropertyChanged("Price2Raw");
				this.RaisePropertyChanged("Price3Raw");
				this.RaisePropertyChanged("Price4Raw");
				this.RaisePropertyChanged("Price5Raw");
				this.RaisePropertyChanged("is_realization");
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06000D70 RID: 3440 RVA: 0x000188A4 File Offset: 0x00016AA4
		// (set) Token: 0x06000D71 RID: 3441 RVA: 0x000188B8 File Offset: 0x00016AB8
		public int dealer_lock
		{
			[CompilerGenerated]
			get
			{
				return this.<dealer_lock>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<dealer_lock>k__BackingField == value)
				{
					return;
				}
				this.<dealer_lock>k__BackingField = value;
				this.RaisePropertyChanged("Available");
				this.RaisePropertyChanged("dealer_lock");
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06000D72 RID: 3442 RVA: 0x000188F0 File Offset: 0x00016AF0
		// (set) Token: 0x06000D73 RID: 3443 RVA: 0x00018904 File Offset: 0x00016B04
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
				this.RaisePropertyChanged("name");
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06000D74 RID: 3444 RVA: 0x00018934 File Offset: 0x00016B34
		// (set) Token: 0x06000D75 RID: 3445 RVA: 0x00018948 File Offset: 0x00016B48
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

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06000D76 RID: 3446 RVA: 0x00018974 File Offset: 0x00016B74
		// (set) Token: 0x06000D77 RID: 3447 RVA: 0x00018988 File Offset: 0x00016B88
		public int category
		{
			[CompilerGenerated]
			get
			{
				return this.<category>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<category>k__BackingField == value)
				{
					return;
				}
				this.<category>k__BackingField = value;
				this.RaisePropertyChanged("category");
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06000D78 RID: 3448 RVA: 0x000189B4 File Offset: 0x00016BB4
		// (set) Token: 0x06000D79 RID: 3449 RVA: 0x000189C8 File Offset: 0x00016BC8
		public int store
		{
			[CompilerGenerated]
			get
			{
				return this.<store>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<store>k__BackingField == value)
				{
					return;
				}
				this.<store>k__BackingField = value;
				this.RaisePropertyChanged("store");
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06000D7A RID: 3450 RVA: 0x000189F4 File Offset: 0x00016BF4
		// (set) Token: 0x06000D7B RID: 3451 RVA: 0x00018A08 File Offset: 0x00016C08
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
				this.RaisePropertyChanged("DealerWarranty");
				this.RaisePropertyChanged("created");
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06000D7C RID: 3452 RVA: 0x00018A44 File Offset: 0x00016C44
		// (set) Token: 0x06000D7D RID: 3453 RVA: 0x00018A58 File Offset: 0x00016C58
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
				this.RaisePropertyChanged("Available");
				this.RaisePropertyChanged("InSumm");
				this.RaisePropertyChanged("PriceSumm");
				this.RaisePropertyChanged("Price2Summ");
				this.RaisePropertyChanged("Price3Summ");
				this.RaisePropertyChanged("count");
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06000D7E RID: 3454 RVA: 0x00018ABC File Offset: 0x00016CBC
		// (set) Token: 0x06000D7F RID: 3455 RVA: 0x00018AD0 File Offset: 0x00016CD0
		public int reserved
		{
			[CompilerGenerated]
			get
			{
				return this.<reserved>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<reserved>k__BackingField == value)
				{
					return;
				}
				this.<reserved>k__BackingField = value;
				this.RaisePropertyChanged("Available");
				this.RaisePropertyChanged("reserved");
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06000D80 RID: 3456 RVA: 0x00018B08 File Offset: 0x00016D08
		// (set) Token: 0x06000D81 RID: 3457 RVA: 0x00018B1C File Offset: 0x00016D1C
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

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06000D82 RID: 3458 RVA: 0x00018B4C File Offset: 0x00016D4C
		// (set) Token: 0x06000D83 RID: 3459 RVA: 0x00018B60 File Offset: 0x00016D60
		public string box_name
		{
			[CompilerGenerated]
			get
			{
				return this.<box_name>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<box_name>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<box_name>k__BackingField = value;
				this.RaisePropertyChanged("box_name");
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06000D84 RID: 3460 RVA: 0x00018B90 File Offset: 0x00016D90
		// (set) Token: 0x06000D85 RID: 3461 RVA: 0x00018BA4 File Offset: 0x00016DA4
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
				this.RaisePropertyChanged("Price1Formatted");
				this.RaisePropertyChanged("Price2Formatted");
				this.RaisePropertyChanged("Price3Formatted");
				this.RaisePropertyChanged("Price4Formatted");
				this.RaisePropertyChanged("Price5Formatted");
				this.RaisePropertyChanged("Price1Raw");
				this.RaisePropertyChanged("Price2Raw");
				this.RaisePropertyChanged("Price3Raw");
				this.RaisePropertyChanged("Price4Raw");
				this.RaisePropertyChanged("Price5Raw");
				this.RaisePropertyChanged("price_option");
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06000D86 RID: 3462 RVA: 0x00018C40 File Offset: 0x00016E40
		// (set) Token: 0x06000D87 RID: 3463 RVA: 0x00018C54 File Offset: 0x00016E54
		public decimal currency_rate
		{
			[CompilerGenerated]
			get
			{
				return this.<currency_rate>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<currency_rate>k__BackingField, value))
				{
					return;
				}
				this.<currency_rate>k__BackingField = value;
				this.RaisePropertyChanged("Price1Formatted");
				this.RaisePropertyChanged("Price2Formatted");
				this.RaisePropertyChanged("Price3Formatted");
				this.RaisePropertyChanged("Price4Formatted");
				this.RaisePropertyChanged("Price5Formatted");
				this.RaisePropertyChanged("Price1Raw");
				this.RaisePropertyChanged("Price2Raw");
				this.RaisePropertyChanged("Price3Raw");
				this.RaisePropertyChanged("Price4Raw");
				this.RaisePropertyChanged("Price5Raw");
				this.RaisePropertyChanged("currency_rate");
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06000D88 RID: 3464 RVA: 0x00018CF0 File Offset: 0x00016EF0
		// (set) Token: 0x06000D89 RID: 3465 RVA: 0x00018D04 File Offset: 0x00016F04
		public decimal in_price
		{
			[CompilerGenerated]
			get
			{
				return this.<in_price>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!decimal.Equals(this.<in_price>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 278238124;
				IL_13:
				switch ((num ^ 611340674) % 4)
				{
				case 0:
					goto IL_0E;
				case 2:
					return;
				case 3:
					IL_32:
					this.<in_price>k__BackingField = value;
					this.RaisePropertyChanged("InSumm");
					this.RaisePropertyChanged("in_price");
					num = 1845326547;
					goto IL_13;
				}
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06000D8A RID: 3466 RVA: 0x00018D68 File Offset: 0x00016F68
		// (set) Token: 0x06000D8B RID: 3467 RVA: 0x00018D7C File Offset: 0x00016F7C
		public decimal price
		{
			[CompilerGenerated]
			get
			{
				return this.<price>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<price>k__BackingField, value))
				{
					return;
				}
				this.<price>k__BackingField = value;
				this.RaisePropertyChanged("PriceSumm");
				this.RaisePropertyChanged("Price1Formatted");
				this.RaisePropertyChanged("Price1Raw");
				this.RaisePropertyChanged("price");
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06000D8C RID: 3468 RVA: 0x00018DCC File Offset: 0x00016FCC
		// (set) Token: 0x06000D8D RID: 3469 RVA: 0x00018DE0 File Offset: 0x00016FE0
		public decimal price2
		{
			[CompilerGenerated]
			get
			{
				return this.<price2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<price2>k__BackingField, value))
				{
					return;
				}
				this.<price2>k__BackingField = value;
				this.RaisePropertyChanged("Price2Summ");
				this.RaisePropertyChanged("Price2Formatted");
				this.RaisePropertyChanged("Price2Raw");
				this.RaisePropertyChanged("price2");
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06000D8E RID: 3470 RVA: 0x00018E30 File Offset: 0x00017030
		// (set) Token: 0x06000D8F RID: 3471 RVA: 0x00018E44 File Offset: 0x00017044
		public decimal price3
		{
			[CompilerGenerated]
			get
			{
				return this.<price3>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!decimal.Equals(this.<price3>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1514547168;
				IL_13:
				switch ((num ^ 748991593) % 4)
				{
				case 1:
					return;
				case 2:
					goto IL_0E;
				case 3:
					IL_32:
					this.<price3>k__BackingField = value;
					num = 220967005;
					goto IL_13;
				}
				this.RaisePropertyChanged("Price3Summ");
				this.RaisePropertyChanged("Price3Formatted");
				this.RaisePropertyChanged("Price3Raw");
				this.RaisePropertyChanged("price3");
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06000D90 RID: 3472 RVA: 0x00018EC0 File Offset: 0x000170C0
		// (set) Token: 0x06000D91 RID: 3473 RVA: 0x00018ED4 File Offset: 0x000170D4
		public decimal price4
		{
			[CompilerGenerated]
			get
			{
				return this.<price4>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<price4>k__BackingField, value))
				{
					return;
				}
				this.<price4>k__BackingField = value;
				this.RaisePropertyChanged("Price4Formatted");
				this.RaisePropertyChanged("Price4Raw");
				this.RaisePropertyChanged("price4");
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06000D92 RID: 3474 RVA: 0x00018F18 File Offset: 0x00017118
		// (set) Token: 0x06000D93 RID: 3475 RVA: 0x00018F2C File Offset: 0x0001712C
		public decimal price5
		{
			[CompilerGenerated]
			get
			{
				return this.<price5>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<price5>k__BackingField, value))
				{
					return;
				}
				this.<price5>k__BackingField = value;
				this.RaisePropertyChanged("Price5Formatted");
				this.RaisePropertyChanged("Price5Raw");
				this.RaisePropertyChanged("price5");
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06000D94 RID: 3476 RVA: 0x00018F70 File Offset: 0x00017170
		// (set) Token: 0x06000D95 RID: 3477 RVA: 0x00018F84 File Offset: 0x00017184
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
				if (Nullable.Equals<int>(this.<document>k__BackingField, value))
				{
					return;
				}
				this.<document>k__BackingField = value;
				this.RaisePropertyChanged("document");
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06000D96 RID: 3478 RVA: 0x00018FB4 File Offset: 0x000171B4
		// (set) Token: 0x06000D97 RID: 3479 RVA: 0x00018FC8 File Offset: 0x000171C8
		public string shop_title
		{
			[CompilerGenerated]
			get
			{
				return this.<shop_title>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<shop_title>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<shop_title>k__BackingField = value;
				this.RaisePropertyChanged("shop_title");
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06000D98 RID: 3480 RVA: 0x00018FF8 File Offset: 0x000171F8
		// (set) Token: 0x06000D99 RID: 3481 RVA: 0x0001900C File Offset: 0x0001720C
		public string shop_description
		{
			[CompilerGenerated]
			get
			{
				return this.<shop_description>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<shop_description>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<shop_description>k__BackingField = value;
				this.RaisePropertyChanged("shop_description");
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06000D9A RID: 3482 RVA: 0x0001903C File Offset: 0x0001723C
		// (set) Token: 0x06000D9B RID: 3483 RVA: 0x00019050 File Offset: 0x00017250
		public string SN
		{
			[CompilerGenerated]
			get
			{
				return this.<SN>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.<SN>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = 1003333194;
				IL_14:
				switch ((num ^ 1922609475) % 4)
				{
				case 1:
					return;
				case 2:
					goto IL_0F;
				case 3:
					IL_33:
					this.<SN>k__BackingField = value;
					num = 536237847;
					goto IL_14;
				}
				this.RaisePropertyChanged("SN");
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06000D9C RID: 3484 RVA: 0x000190AC File Offset: 0x000172AC
		// (set) Token: 0x06000D9D RID: 3485 RVA: 0x000190C0 File Offset: 0x000172C0
		public string PN
		{
			[CompilerGenerated]
			get
			{
				return this.<PN>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<PN>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<PN>k__BackingField = value;
				this.RaisePropertyChanged("PN");
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06000D9E RID: 3486 RVA: 0x000190F0 File Offset: 0x000172F0
		// (set) Token: 0x06000D9F RID: 3487 RVA: 0x00019104 File Offset: 0x00017304
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
				if (!string.Equals(this.<description>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = -162136067;
				IL_14:
				switch ((num ^ -2099463504) % 4)
				{
				case 0:
					goto IL_0F;
				case 1:
					return;
				case 3:
					IL_33:
					num = -292956742;
					goto IL_14;
				}
				this.<description>k__BackingField = value;
				this.RaisePropertyChanged("description");
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06000DA0 RID: 3488 RVA: 0x00019160 File Offset: 0x00017360
		// (set) Token: 0x06000DA1 RID: 3489 RVA: 0x00019174 File Offset: 0x00017374
		public bool? shop_enable
		{
			[CompilerGenerated]
			get
			{
				return this.<shop_enable>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<bool>(this.<shop_enable>k__BackingField, value))
				{
					return;
				}
				this.<shop_enable>k__BackingField = value;
				this.RaisePropertyChanged("shop_enable");
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06000DA2 RID: 3490 RVA: 0x000191A4 File Offset: 0x000173A4
		// (set) Token: 0x06000DA3 RID: 3491 RVA: 0x000191B8 File Offset: 0x000173B8
		public string int_barcode
		{
			[CompilerGenerated]
			get
			{
				return this.<int_barcode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<int_barcode>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<int_barcode>k__BackingField = value;
				this.RaisePropertyChanged("int_barcode");
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06000DA4 RID: 3492 RVA: 0x000191E8 File Offset: 0x000173E8
		// (set) Token: 0x06000DA5 RID: 3493 RVA: 0x000191FC File Offset: 0x000173FC
		public string ext_barcode
		{
			[CompilerGenerated]
			get
			{
				return this.<ext_barcode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<ext_barcode>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<ext_barcode>k__BackingField = value;
				this.RaisePropertyChanged("ext_barcode");
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06000DA6 RID: 3494 RVA: 0x0001922C File Offset: 0x0001742C
		// (set) Token: 0x06000DA7 RID: 3495 RVA: 0x00019240 File Offset: 0x00017440
		public decimal in_summ
		{
			[CompilerGenerated]
			get
			{
				return this.<in_summ>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<in_summ>k__BackingField, value))
				{
					return;
				}
				this.<in_summ>k__BackingField = value;
				this.RaisePropertyChanged("in_summ");
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06000DA8 RID: 3496 RVA: 0x00019270 File Offset: 0x00017470
		// (set) Token: 0x06000DA9 RID: 3497 RVA: 0x00019284 File Offset: 0x00017484
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

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06000DAA RID: 3498 RVA: 0x000192B4 File Offset: 0x000174B4
		// (set) Token: 0x06000DAB RID: 3499 RVA: 0x000192C8 File Offset: 0x000174C8
		public int? img1
		{
			[CompilerGenerated]
			get
			{
				return this.<img1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!Nullable.Equals<int>(this.<img1>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1976053875;
				IL_13:
				switch ((num ^ 252109929) % 4)
				{
				case 1:
					IL_32:
					this.<img1>k__BackingField = value;
					num = 426962753;
					goto IL_13;
				case 2:
					return;
				case 3:
					goto IL_0E;
				}
				this.RaisePropertyChanged("img1");
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06000DAC RID: 3500 RVA: 0x00019324 File Offset: 0x00017524
		// (set) Token: 0x06000DAD RID: 3501 RVA: 0x00019338 File Offset: 0x00017538
		public int? img2
		{
			[CompilerGenerated]
			get
			{
				return this.<img2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<img2>k__BackingField, value))
				{
					return;
				}
				this.<img2>k__BackingField = value;
				this.RaisePropertyChanged("img2");
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06000DAE RID: 3502 RVA: 0x00019368 File Offset: 0x00017568
		// (set) Token: 0x06000DAF RID: 3503 RVA: 0x0001937C File Offset: 0x0001757C
		public int? img3
		{
			[CompilerGenerated]
			get
			{
				return this.<img3>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<img3>k__BackingField, value))
				{
					return;
				}
				this.<img3>k__BackingField = value;
				this.RaisePropertyChanged("img3");
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06000DB0 RID: 3504 RVA: 0x000193AC File Offset: 0x000175AC
		// (set) Token: 0x06000DB1 RID: 3505 RVA: 0x000193C0 File Offset: 0x000175C0
		public int? img4
		{
			[CompilerGenerated]
			get
			{
				return this.<img4>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<img4>k__BackingField, value))
				{
					return;
				}
				this.<img4>k__BackingField = value;
				this.RaisePropertyChanged("img4");
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06000DB2 RID: 3506 RVA: 0x000193F0 File Offset: 0x000175F0
		// (set) Token: 0x06000DB3 RID: 3507 RVA: 0x00019404 File Offset: 0x00017604
		public int? img5
		{
			[CompilerGenerated]
			get
			{
				return this.<img5>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<img5>k__BackingField, value))
				{
					return;
				}
				this.<img5>k__BackingField = value;
				this.RaisePropertyChanged("img5");
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06000DB4 RID: 3508 RVA: 0x00019434 File Offset: 0x00017634
		// (set) Token: 0x06000DB5 RID: 3509 RVA: 0x00019448 File Offset: 0x00017648
		public int minimum_in_stock
		{
			[CompilerGenerated]
			get
			{
				return this.<minimum_in_stock>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<minimum_in_stock>k__BackingField == value)
				{
					return;
				}
				this.<minimum_in_stock>k__BackingField = value;
				this.RaisePropertyChanged("minimum_in_stock");
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06000DB6 RID: 3510 RVA: 0x00019474 File Offset: 0x00017674
		// (set) Token: 0x06000DB7 RID: 3511 RVA: 0x00019488 File Offset: 0x00017688
		public int sold
		{
			[CompilerGenerated]
			get
			{
				return this.<sold>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<sold>k__BackingField == value)
				{
					return;
				}
				this.<sold>k__BackingField = value;
				this.RaisePropertyChanged("sold");
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x000194B4 File Offset: 0x000176B4
		// (set) Token: 0x06000DB9 RID: 3513 RVA: 0x000194C8 File Offset: 0x000176C8
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

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06000DBA RID: 3514 RVA: 0x000194F4 File Offset: 0x000176F4
		// (set) Token: 0x06000DBB RID: 3515 RVA: 0x00019508 File Offset: 0x00017708
		public int warranty
		{
			[CompilerGenerated]
			get
			{
				return this.<warranty>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<warranty>k__BackingField == value)
				{
					return;
				}
				this.<warranty>k__BackingField = value;
				this.RaisePropertyChanged("Warranty");
				this.RaisePropertyChanged("warranty");
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06000DBC RID: 3516 RVA: 0x00019540 File Offset: 0x00017740
		// (set) Token: 0x06000DBD RID: 3517 RVA: 0x00019554 File Offset: 0x00017754
		public int warranty_dealer
		{
			[CompilerGenerated]
			get
			{
				return this.<warranty_dealer>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<warranty_dealer>k__BackingField == value)
				{
					return;
				}
				this.<warranty_dealer>k__BackingField = value;
				this.RaisePropertyChanged("WarrantyProgressVisible");
				this.RaisePropertyChanged("DealerWarranty");
				this.RaisePropertyChanged("EndDealerWarranty");
				this.RaisePropertyChanged("warranty_dealer");
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06000DBE RID: 3518 RVA: 0x000195A0 File Offset: 0x000177A0
		// (set) Token: 0x06000DBF RID: 3519 RVA: 0x000195B4 File Offset: 0x000177B4
		public int in_count
		{
			[CompilerGenerated]
			get
			{
				return this.<in_count>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<in_count>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = 898866646;
				IL_10:
				switch ((num ^ 616626475) % 4)
				{
				case 0:
					goto IL_0B;
				case 1:
					return;
				case 2:
					IL_2F:
					num = 242067308;
					goto IL_10;
				}
				this.<in_count>k__BackingField = value;
				this.RaisePropertyChanged("in_count");
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06000DC0 RID: 3520 RVA: 0x0001960C File Offset: 0x0001780C
		// (set) Token: 0x06000DC1 RID: 3521 RVA: 0x00019620 File Offset: 0x00017820
		public bool not_for_sale
		{
			[CompilerGenerated]
			get
			{
				return this.<not_for_sale>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<not_for_sale>k__BackingField == value)
				{
					return;
				}
				this.<not_for_sale>k__BackingField = value;
				this.RaisePropertyChanged("not_for_sale");
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06000DC2 RID: 3522 RVA: 0x0001964C File Offset: 0x0001784C
		// (set) Token: 0x06000DC3 RID: 3523 RVA: 0x00019660 File Offset: 0x00017860
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

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06000DC4 RID: 3524 RVA: 0x00019690 File Offset: 0x00017890
		// (set) Token: 0x06000DC5 RID: 3525 RVA: 0x000196A4 File Offset: 0x000178A4
		public int st_state
		{
			[CompilerGenerated]
			get
			{
				return this.<st_state>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<st_state>k__BackingField == value)
				{
					return;
				}
				this.<st_state>k__BackingField = value;
				this.RaisePropertyChanged("st_state");
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06000DC6 RID: 3526 RVA: 0x000196D0 File Offset: 0x000178D0
		// (set) Token: 0x06000DC7 RID: 3527 RVA: 0x000196E4 File Offset: 0x000178E4
		public string st_notes
		{
			[CompilerGenerated]
			get
			{
				return this.<st_notes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<st_notes>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<st_notes>k__BackingField = value;
				this.RaisePropertyChanged("st_notes");
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06000DC8 RID: 3528 RVA: 0x00019714 File Offset: 0x00017914
		// (set) Token: 0x06000DC9 RID: 3529 RVA: 0x00019728 File Offset: 0x00017928
		public int units
		{
			[CompilerGenerated]
			get
			{
				return this.<units>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<units>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -1837865197;
				IL_10:
				switch ((num ^ -1619174142) % 4)
				{
				case 1:
					return;
				case 2:
					IL_2F:
					this.<units>k__BackingField = value;
					num = -1474384078;
					goto IL_10;
				case 3:
					goto IL_0B;
				}
				this.RaisePropertyChanged("units");
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06000DCA RID: 3530 RVA: 0x00019780 File Offset: 0x00017980
		// (set) Token: 0x06000DCB RID: 3531 RVA: 0x00019794 File Offset: 0x00017994
		public bool ge_highlight
		{
			[CompilerGenerated]
			get
			{
				return this.<ge_highlight>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ge_highlight>k__BackingField == value)
				{
					return;
				}
				this.<ge_highlight>k__BackingField = value;
				this.RaisePropertyChanged("ge_highlight");
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06000DCC RID: 3532 RVA: 0x000197C0 File Offset: 0x000179C0
		// (set) Token: 0x06000DCD RID: 3533 RVA: 0x000197D4 File Offset: 0x000179D4
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

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06000DCE RID: 3534 RVA: 0x00019800 File Offset: 0x00017A00
		// (set) Token: 0x06000DCF RID: 3535 RVA: 0x00019814 File Offset: 0x00017A14
		public DateTime? updated
		{
			[CompilerGenerated]
			get
			{
				return this.<updated>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<DateTime>(this.<updated>k__BackingField, value))
				{
					return;
				}
				this.<updated>k__BackingField = value;
				this.RaisePropertyChanged("updated");
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06000DD0 RID: 3536 RVA: 0x00019844 File Offset: 0x00017A44
		// (set) Token: 0x06000DD1 RID: 3537 RVA: 0x00019858 File Offset: 0x00017A58
		public virtual items_state items_state
		{
			[CompilerGenerated]
			get
			{
				return this.<items_state>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<items_state>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1806889651;
				IL_13:
				switch ((num ^ -1731642426) % 4)
				{
				case 0:
					IL_32:
					num = -331097529;
					goto IL_13;
				case 2:
					goto IL_0E;
				case 3:
					return;
				}
				this.<items_state>k__BackingField = value;
				this.RaisePropertyChanged("StateName");
				this.RaisePropertyChanged("items_state");
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06000DD2 RID: 3538 RVA: 0x000198BC File Offset: 0x00017ABC
		// (set) Token: 0x06000DD3 RID: 3539 RVA: 0x000198D0 File Offset: 0x00017AD0
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
				if (object.Equals(this.<order_items>k__BackingField, value))
				{
					return;
				}
				this.<order_items>k__BackingField = value;
				this.RaisePropertyChanged("order_items");
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x06000DD4 RID: 3540 RVA: 0x00019900 File Offset: 0x00017B00
		// (set) Token: 0x06000DD5 RID: 3541 RVA: 0x00019914 File Offset: 0x00017B14
		public virtual store_cats store_cats
		{
			[CompilerGenerated]
			get
			{
				return this.<store_cats>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<store_cats>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1569750407;
				IL_13:
				switch ((num ^ 573249260) % 4)
				{
				case 0:
					IL_32:
					this.<store_cats>k__BackingField = value;
					num = 1005454149;
					goto IL_13;
				case 2:
					goto IL_0E;
				case 3:
					return;
				}
				this.RaisePropertyChanged("store_cats");
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x06000DD6 RID: 3542 RVA: 0x00019970 File Offset: 0x00017B70
		// (set) Token: 0x06000DD7 RID: 3543 RVA: 0x00019984 File Offset: 0x00017B84
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
				if (!object.Equals(this.<workshop_parts>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -39516476;
				IL_13:
				switch ((num ^ -2042615367) % 4)
				{
				case 0:
					IL_32:
					num = -1762790149;
					goto IL_13;
				case 1:
					return;
				case 3:
					goto IL_0E;
				}
				this.<workshop_parts>k__BackingField = value;
				this.RaisePropertyChanged("workshop_parts");
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06000DD8 RID: 3544 RVA: 0x000199E0 File Offset: 0x00017BE0
		// (set) Token: 0x06000DD9 RID: 3545 RVA: 0x000199F4 File Offset: 0x00017BF4
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
				this.RaisePropertyChanged("WarrantyProgressVisible");
				this.RaisePropertyChanged("stores");
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06000DDA RID: 3546 RVA: 0x00019A30 File Offset: 0x00017C30
		// (set) Token: 0x06000DDB RID: 3547 RVA: 0x00019A44 File Offset: 0x00017C44
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

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06000DDC RID: 3548 RVA: 0x00019A74 File Offset: 0x00017C74
		// (set) Token: 0x06000DDD RID: 3549 RVA: 0x00019A88 File Offset: 0x00017C88
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

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06000DDE RID: 3550 RVA: 0x00019AB8 File Offset: 0x00017CB8
		// (set) Token: 0x06000DDF RID: 3551 RVA: 0x00019ACC File Offset: 0x00017CCC
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

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06000DE0 RID: 3552 RVA: 0x00019AFC File Offset: 0x00017CFC
		// (set) Token: 0x06000DE1 RID: 3553 RVA: 0x00019B10 File Offset: 0x00017D10
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

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06000DE2 RID: 3554 RVA: 0x00019B40 File Offset: 0x00017D40
		// (set) Token: 0x06000DE3 RID: 3555 RVA: 0x00019B54 File Offset: 0x00017D54
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
				this.RaisePropertyChanged("store_int_reserve");
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06000DE4 RID: 3556 RVA: 0x00019B84 File Offset: 0x00017D84
		// (set) Token: 0x06000DE5 RID: 3557 RVA: 0x00019B98 File Offset: 0x00017D98
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

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06000DE6 RID: 3558 RVA: 0x00019BC8 File Offset: 0x00017DC8
		// (set) Token: 0x06000DE7 RID: 3559 RVA: 0x00019BDC File Offset: 0x00017DDC
		public virtual parts_request parts_request1
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

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06000DE8 RID: 3560 RVA: 0x00019C0C File Offset: 0x00017E0C
		// (set) Token: 0x06000DE9 RID: 3561 RVA: 0x00019C20 File Offset: 0x00017E20
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

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06000DEA RID: 3562 RVA: 0x00019C50 File Offset: 0x00017E50
		// (set) Token: 0x06000DEB RID: 3563 RVA: 0x00019C64 File Offset: 0x00017E64
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
				this.RaisePropertyChanged("Attributes");
				this.RaisePropertyChanged("field_values");
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06000DEC RID: 3564 RVA: 0x00019CA0 File Offset: 0x00017EA0
		// (set) Token: 0x06000DED RID: 3565 RVA: 0x00019CB4 File Offset: 0x00017EB4
		public virtual ICollection<images> images
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

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06000DEE RID: 3566 RVA: 0x00019CE4 File Offset: 0x00017EE4
		// (set) Token: 0x06000DEF RID: 3567 RVA: 0x00019CFC File Offset: 0x00017EFC
		public ObservableCollection<field_values> Attributes
		{
			get
			{
				return new ObservableCollection<field_values>(this.field_values);
			}
			set
			{
				if (object.Equals(this.Attributes, value))
				{
					return;
				}
				this.field_values = value;
				this.RaisePropertyChanged("Attributes");
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06000DF0 RID: 3568 RVA: 0x00019D2C File Offset: 0x00017F2C
		public int Available
		{
			get
			{
				return this.count - this.reserved - this.dealer_lock;
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06000DF1 RID: 3569 RVA: 0x00019D50 File Offset: 0x00017F50
		public string Warranty
		{
			get
			{
				return new WarrantyOptions().Days2Name(this.warranty);
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06000DF2 RID: 3570 RVA: 0x00019D70 File Offset: 0x00017F70
		public bool WarrantyProgressVisible
		{
			get
			{
				if (this.warranty_dealer != 0)
				{
					stores stores = this.stores;
					return stores != null && !stores.it_vis_warranty_dealer;
				}
				return false;
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06000DF3 RID: 3571 RVA: 0x00019D9C File Offset: 0x00017F9C
		// (set) Token: 0x06000DF4 RID: 3572 RVA: 0x00019DB0 File Offset: 0x00017FB0
		public int BuyCount
		{
			[CompilerGenerated]
			get
			{
				return this.<BuyCount>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<BuyCount>k__BackingField == value)
				{
					return;
				}
				this.<BuyCount>k__BackingField = value;
				this.RaisePropertyChanged("BuyCount");
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06000DF5 RID: 3573 RVA: 0x00019DDC File Offset: 0x00017FDC
		// (set) Token: 0x06000DF6 RID: 3574 RVA: 0x00019DF0 File Offset: 0x00017FF0
		public decimal BuyCost
		{
			[CompilerGenerated]
			get
			{
				return this.<BuyCost>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<BuyCost>k__BackingField, value))
				{
					return;
				}
				this.<BuyCost>k__BackingField = value;
				this.RaisePropertyChanged("BuyCost");
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06000DF7 RID: 3575 RVA: 0x00019E20 File Offset: 0x00018020
		// (set) Token: 0x06000DF8 RID: 3576 RVA: 0x00019E34 File Offset: 0x00018034
		public bool Selected
		{
			[CompilerGenerated]
			get
			{
				return this.<Selected>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Selected>k__BackingField == value)
				{
					return;
				}
				this.<Selected>k__BackingField = value;
				this.RaisePropertyChanged("Selected");
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06000DF9 RID: 3577 RVA: 0x00019E60 File Offset: 0x00018060
		public string UID
		{
			get
			{
				return string.Format("{0:D6}-{1:D6}", this.articul, this.id);
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06000DFA RID: 3578 RVA: 0x00019E90 File Offset: 0x00018090
		// (set) Token: 0x06000DFB RID: 3579 RVA: 0x00019EA4 File Offset: 0x000180A4
		[NotMapped]
		public int? SaleId
		{
			[CompilerGenerated]
			get
			{
				return this.<SaleId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<SaleId>k__BackingField, value))
				{
					return;
				}
				this.<SaleId>k__BackingField = value;
				this.RaisePropertyChanged("SaleId");
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06000DFC RID: 3580 RVA: 0x00019ED4 File Offset: 0x000180D4
		public double DealerWarranty
		{
			get
			{
				if (this.warranty_dealer == 0)
				{
					return 0.0;
				}
				TimeSpan? timeSpan = this._localization.Now - this.created;
				if (timeSpan == null)
				{
					return 0.0;
				}
				int num = timeSpan.Value.Days * 100 / this.warranty_dealer;
				if (num == 0)
				{
					return 1.0;
				}
				if (num <= 100)
				{
					return (double)num;
				}
				return 100.0;
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06000DFD RID: 3581 RVA: 0x00019F80 File Offset: 0x00018180
		public decimal InSumm
		{
			get
			{
				return this.in_price * this.count;
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06000DFE RID: 3582 RVA: 0x00019FA4 File Offset: 0x000181A4
		public decimal PriceSumm
		{
			get
			{
				return this.count * this.price;
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06000DFF RID: 3583 RVA: 0x00019FC8 File Offset: 0x000181C8
		public decimal Price2Summ
		{
			get
			{
				return this.count * this.price2;
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06000E00 RID: 3584 RVA: 0x00019FEC File Offset: 0x000181EC
		public decimal Price3Summ
		{
			get
			{
				return this.count * this.price3;
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06000E01 RID: 3585 RVA: 0x0001A010 File Offset: 0x00018210
		public virtual string EndDealerWarranty
		{
			get
			{
				if (this.warranty_dealer != 0)
				{
					return this._localization.Now.AddDays((double)this.warranty_dealer).ToShortDateString();
				}
				return null;
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06000E02 RID: 3586 RVA: 0x0001A04C File Offset: 0x0001824C
		public virtual string StateName
		{
			get
			{
				return this.items_state.name;
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06000E03 RID: 3587 RVA: 0x0001A064 File Offset: 0x00018264
		// (set) Token: 0x06000E04 RID: 3588 RVA: 0x0001A080 File Offset: 0x00018280
		public virtual decimal Price1Formatted
		{
			get
			{
				return this.FormatPrice(this.price);
			}
			set
			{
				if (decimal.Equals(this.Price1Formatted, value))
				{
					return;
				}
				this.price = this.SetPrice(value);
				this.RaisePropertyChanged("Price1Formatted");
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06000E05 RID: 3589 RVA: 0x0001A0B4 File Offset: 0x000182B4
		// (set) Token: 0x06000E06 RID: 3590 RVA: 0x0001A0D0 File Offset: 0x000182D0
		public virtual decimal Price2Formatted
		{
			get
			{
				return this.FormatPrice(this.price2);
			}
			set
			{
				if (decimal.Equals(this.Price2Formatted, value))
				{
					return;
				}
				this.price2 = this.SetPrice(value);
				this.RaisePropertyChanged("Price2Formatted");
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06000E07 RID: 3591 RVA: 0x0001A104 File Offset: 0x00018304
		// (set) Token: 0x06000E08 RID: 3592 RVA: 0x0001A120 File Offset: 0x00018320
		public virtual decimal Price3Formatted
		{
			get
			{
				return this.FormatPrice(this.price3);
			}
			set
			{
				if (decimal.Equals(this.Price3Formatted, value))
				{
					return;
				}
				this.price3 = this.SetPrice(value);
				this.RaisePropertyChanged("Price3Formatted");
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06000E09 RID: 3593 RVA: 0x0001A154 File Offset: 0x00018354
		// (set) Token: 0x06000E0A RID: 3594 RVA: 0x0001A170 File Offset: 0x00018370
		public virtual decimal Price4Formatted
		{
			get
			{
				return this.FormatPrice(this.price4);
			}
			set
			{
				if (decimal.Equals(this.Price4Formatted, value))
				{
					return;
				}
				this.price4 = this.SetPrice(value);
				this.RaisePropertyChanged("Price4Formatted");
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06000E0B RID: 3595 RVA: 0x0001A1A4 File Offset: 0x000183A4
		// (set) Token: 0x06000E0C RID: 3596 RVA: 0x0001A1C0 File Offset: 0x000183C0
		public virtual decimal Price5Formatted
		{
			get
			{
				return this.FormatPrice(this.price5);
			}
			set
			{
				if (decimal.Equals(this.Price5Formatted, value))
				{
					return;
				}
				this.price5 = this.SetPrice(value);
				this.RaisePropertyChanged("Price5Formatted");
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06000E0D RID: 3597 RVA: 0x0001A064 File Offset: 0x00018264
		// (set) Token: 0x06000E0E RID: 3598 RVA: 0x0001A1F4 File Offset: 0x000183F4
		public virtual decimal Price1Raw
		{
			get
			{
				return this.FormatPrice(this.price);
			}
			set
			{
				if (decimal.Equals(this.Price1Raw, value))
				{
					return;
				}
				this.price = this.SetPrice(value);
				this.RaisePropertyChanged("Price1Raw");
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06000E0F RID: 3599 RVA: 0x0001A0B4 File Offset: 0x000182B4
		// (set) Token: 0x06000E10 RID: 3600 RVA: 0x0001A228 File Offset: 0x00018428
		public virtual decimal Price2Raw
		{
			get
			{
				return this.FormatPrice(this.price2);
			}
			set
			{
				if (decimal.Equals(this.Price2Raw, value))
				{
					return;
				}
				this.price2 = this.SetPrice(value);
				this.RaisePropertyChanged("Price2Raw");
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06000E11 RID: 3601 RVA: 0x0001A104 File Offset: 0x00018304
		// (set) Token: 0x06000E12 RID: 3602 RVA: 0x0001A25C File Offset: 0x0001845C
		public virtual decimal Price3Raw
		{
			get
			{
				return this.FormatPrice(this.price3);
			}
			set
			{
				if (decimal.Equals(this.Price3Raw, value))
				{
					return;
				}
				this.price3 = this.SetPrice(value);
				this.RaisePropertyChanged("Price3Raw");
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06000E13 RID: 3603 RVA: 0x0001A154 File Offset: 0x00018354
		// (set) Token: 0x06000E14 RID: 3604 RVA: 0x0001A290 File Offset: 0x00018490
		public virtual decimal Price4Raw
		{
			get
			{
				return this.FormatPrice(this.price4);
			}
			set
			{
				if (decimal.Equals(this.Price4Raw, value))
				{
					return;
				}
				this.price4 = this.SetPrice(value);
				this.RaisePropertyChanged("Price4Raw");
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06000E15 RID: 3605 RVA: 0x0001A1A4 File Offset: 0x000183A4
		// (set) Token: 0x06000E16 RID: 3606 RVA: 0x0001A2C4 File Offset: 0x000184C4
		public virtual decimal Price5Raw
		{
			get
			{
				return this.FormatPrice(this.price5);
			}
			set
			{
				if (decimal.Equals(this.Price5Raw, value))
				{
					return;
				}
				this.price5 = this.SetPrice(value);
				this.RaisePropertyChanged("Price5Raw");
			}
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x0001A2F8 File Offset: 0x000184F8
		private decimal SetPrice(decimal value)
		{
			if (!this.is_realization)
			{
				if (this.price_option == 2)
				{
					return value / Auth.CurrencyModel.Rate * this.currency_rate;
				}
			}
			if (this.price_option != 1 && this.price_option != 3)
			{
				return 0m;
			}
			return value;
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x0001A350 File Offset: 0x00018550
		public decimal FormatPrice(decimal value)
		{
			if (!this.is_realization && this.price_option == 2)
			{
				if (this.currency_rate == 0m)
				{
					return 0m;
				}
				value = value / this.currency_rate * Auth.CurrencyModel.Rate;
			}
			return value;
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06000E19 RID: 3609 RVA: 0x0001A3A4 File Offset: 0x000185A4
		// (set) Token: 0x06000E1A RID: 3610 RVA: 0x0001A3B8 File Offset: 0x000185B8
		public int Id
		{
			get
			{
				return this.id;
			}
			set
			{
				if (this.Id == value)
				{
					return;
				}
				this.id = value;
				this.RaisePropertyChanged("Id");
			}
		}

		// Token: 0x04000664 RID: 1636
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x04000665 RID: 1637
		[CompilerGenerated]
		private int <articul>k__BackingField;

		// Token: 0x04000666 RID: 1638
		[CompilerGenerated]
		private int <dealer>k__BackingField;

		// Token: 0x04000667 RID: 1639
		[CompilerGenerated]
		private bool <is_realization>k__BackingField;

		// Token: 0x04000668 RID: 1640
		[CompilerGenerated]
		private int <dealer_lock>k__BackingField;

		// Token: 0x04000669 RID: 1641
		[CompilerGenerated]
		private string <name>k__BackingField;

		// Token: 0x0400066A RID: 1642
		[CompilerGenerated]
		private int <state>k__BackingField;

		// Token: 0x0400066B RID: 1643
		[CompilerGenerated]
		private int <category>k__BackingField;

		// Token: 0x0400066C RID: 1644
		[CompilerGenerated]
		private int <store>k__BackingField;

		// Token: 0x0400066D RID: 1645
		[CompilerGenerated]
		private DateTime? <created>k__BackingField;

		// Token: 0x0400066E RID: 1646
		[CompilerGenerated]
		private int <count>k__BackingField;

		// Token: 0x0400066F RID: 1647
		[CompilerGenerated]
		private int <reserved>k__BackingField;

		// Token: 0x04000670 RID: 1648
		[CompilerGenerated]
		private int? <box>k__BackingField;

		// Token: 0x04000671 RID: 1649
		[CompilerGenerated]
		private string <box_name>k__BackingField;

		// Token: 0x04000672 RID: 1650
		[CompilerGenerated]
		private int <price_option>k__BackingField;

		// Token: 0x04000673 RID: 1651
		[CompilerGenerated]
		private decimal <currency_rate>k__BackingField;

		// Token: 0x04000674 RID: 1652
		[CompilerGenerated]
		private decimal <in_price>k__BackingField;

		// Token: 0x04000675 RID: 1653
		[CompilerGenerated]
		private decimal <price>k__BackingField;

		// Token: 0x04000676 RID: 1654
		[CompilerGenerated]
		private decimal <price2>k__BackingField;

		// Token: 0x04000677 RID: 1655
		[CompilerGenerated]
		private decimal <price3>k__BackingField;

		// Token: 0x04000678 RID: 1656
		[CompilerGenerated]
		private decimal <price4>k__BackingField;

		// Token: 0x04000679 RID: 1657
		[CompilerGenerated]
		private decimal <price5>k__BackingField;

		// Token: 0x0400067A RID: 1658
		[CompilerGenerated]
		private int? <document>k__BackingField;

		// Token: 0x0400067B RID: 1659
		[CompilerGenerated]
		private string <shop_title>k__BackingField;

		// Token: 0x0400067C RID: 1660
		[CompilerGenerated]
		private string <shop_description>k__BackingField;

		// Token: 0x0400067D RID: 1661
		[CompilerGenerated]
		private string <SN>k__BackingField;

		// Token: 0x0400067E RID: 1662
		[CompilerGenerated]
		private string <PN>k__BackingField;

		// Token: 0x0400067F RID: 1663
		[CompilerGenerated]
		private string <description>k__BackingField;

		// Token: 0x04000680 RID: 1664
		[CompilerGenerated]
		private bool? <shop_enable>k__BackingField;

		// Token: 0x04000681 RID: 1665
		[CompilerGenerated]
		private string <int_barcode>k__BackingField;

		// Token: 0x04000682 RID: 1666
		[CompilerGenerated]
		private string <ext_barcode>k__BackingField;

		// Token: 0x04000683 RID: 1667
		[CompilerGenerated]
		private decimal <in_summ>k__BackingField;

		// Token: 0x04000684 RID: 1668
		[CompilerGenerated]
		private string <notes>k__BackingField;

		// Token: 0x04000685 RID: 1669
		[CompilerGenerated]
		private int? <img1>k__BackingField;

		// Token: 0x04000686 RID: 1670
		[CompilerGenerated]
		private int? <img2>k__BackingField;

		// Token: 0x04000687 RID: 1671
		[CompilerGenerated]
		private int? <img3>k__BackingField;

		// Token: 0x04000688 RID: 1672
		[CompilerGenerated]
		private int? <img4>k__BackingField;

		// Token: 0x04000689 RID: 1673
		[CompilerGenerated]
		private int? <img5>k__BackingField;

		// Token: 0x0400068A RID: 1674
		[CompilerGenerated]
		private int <minimum_in_stock>k__BackingField;

		// Token: 0x0400068B RID: 1675
		[CompilerGenerated]
		private int <sold>k__BackingField;

		// Token: 0x0400068C RID: 1676
		[CompilerGenerated]
		private int <return_percent>k__BackingField;

		// Token: 0x0400068D RID: 1677
		[CompilerGenerated]
		private int <warranty>k__BackingField;

		// Token: 0x0400068E RID: 1678
		[CompilerGenerated]
		private int <warranty_dealer>k__BackingField;

		// Token: 0x0400068F RID: 1679
		[CompilerGenerated]
		private int <in_count>k__BackingField;

		// Token: 0x04000690 RID: 1680
		[CompilerGenerated]
		private bool <not_for_sale>k__BackingField;

		// Token: 0x04000691 RID: 1681
		[CompilerGenerated]
		private int? <part_request>k__BackingField;

		// Token: 0x04000692 RID: 1682
		[CompilerGenerated]
		private int <st_state>k__BackingField;

		// Token: 0x04000693 RID: 1683
		[CompilerGenerated]
		private string <st_notes>k__BackingField;

		// Token: 0x04000694 RID: 1684
		[CompilerGenerated]
		private int <units>k__BackingField;

		// Token: 0x04000695 RID: 1685
		[CompilerGenerated]
		private bool <ge_highlight>k__BackingField;

		// Token: 0x04000696 RID: 1686
		[CompilerGenerated]
		private bool <Hidden>k__BackingField;

		// Token: 0x04000697 RID: 1687
		[CompilerGenerated]
		private DateTime? <updated>k__BackingField;

		// Token: 0x04000698 RID: 1688
		[CompilerGenerated]
		private items_state <items_state>k__BackingField;

		// Token: 0x04000699 RID: 1689
		[CompilerGenerated]
		private ICollection<order_items> <order_items>k__BackingField;

		// Token: 0x0400069A RID: 1690
		[CompilerGenerated]
		private store_cats <store_cats>k__BackingField;

		// Token: 0x0400069B RID: 1691
		[CompilerGenerated]
		private ICollection<workshop_parts> <workshop_parts>k__BackingField;

		// Token: 0x0400069C RID: 1692
		[CompilerGenerated]
		private stores <stores>k__BackingField;

		// Token: 0x0400069D RID: 1693
		[CompilerGenerated]
		private ICollection<store_sales> <store_sales>k__BackingField;

		// Token: 0x0400069E RID: 1694
		[CompilerGenerated]
		private docs <docs>k__BackingField;

		// Token: 0x0400069F RID: 1695
		[CompilerGenerated]
		private clients <clients>k__BackingField;

		// Token: 0x040006A0 RID: 1696
		[CompilerGenerated]
		private ICollection<logs> <logs>k__BackingField;

		// Token: 0x040006A1 RID: 1697
		[CompilerGenerated]
		private ICollection<store_int_reserve> <store_int_reserve>k__BackingField;

		// Token: 0x040006A2 RID: 1698
		[CompilerGenerated]
		private ICollection<parts_request> <parts_request>k__BackingField;

		// Token: 0x040006A3 RID: 1699
		[CompilerGenerated]
		private parts_request <parts_request1>k__BackingField;

		// Token: 0x040006A4 RID: 1700
		[CompilerGenerated]
		private boxes <boxes>k__BackingField;

		// Token: 0x040006A5 RID: 1701
		[CompilerGenerated]
		private ICollection<field_values> <field_values>k__BackingField;

		// Token: 0x040006A6 RID: 1702
		[CompilerGenerated]
		private ICollection<images> <images>k__BackingField;

		// Token: 0x040006A7 RID: 1703
		private readonly Localization _localization = new Localization("UTC");

		// Token: 0x040006A8 RID: 1704
		[CompilerGenerated]
		private int <BuyCount>k__BackingField = 1;

		// Token: 0x040006A9 RID: 1705
		[CompilerGenerated]
		private decimal <BuyCost>k__BackingField;

		// Token: 0x040006AA RID: 1706
		[CompilerGenerated]
		private bool <Selected>k__BackingField;

		// Token: 0x040006AB RID: 1707
		[CompilerGenerated]
		private int? <SaleId>k__BackingField;
	}
}
