using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using ASC.SimpleClasses;
using NLog;

namespace ASC
{
	// Token: 0x02000075 RID: 117
	public class store_int_reserve : INotifyPropertyChanged
	{
		// Token: 0x06000D30 RID: 3376 RVA: 0x00017D64 File Offset: 0x00015F64
		public store_int_reserve()
		{
			this.tasks = new HashSet<tasks>();
			this.notifications = new HashSet<notifications>();
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06000D31 RID: 3377 RVA: 0x00017D90 File Offset: 0x00015F90
		// (set) Token: 0x06000D32 RID: 3378 RVA: 0x00017DA4 File Offset: 0x00015FA4
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

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06000D33 RID: 3379 RVA: 0x00017DD0 File Offset: 0x00015FD0
		// (set) Token: 0x06000D34 RID: 3380 RVA: 0x00017DE4 File Offset: 0x00015FE4
		public int item_id
		{
			[CompilerGenerated]
			get
			{
				return this.<item_id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<item_id>k__BackingField == value)
				{
					return;
				}
				this.<item_id>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.item_id);
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06000D35 RID: 3381 RVA: 0x00017E10 File Offset: 0x00016010
		// (set) Token: 0x06000D36 RID: 3382 RVA: 0x00017E24 File Offset: 0x00016024
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
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.Summ);
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.Profit);
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.ManagerPart);
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.count);
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06000D37 RID: 3383 RVA: 0x00017E70 File Offset: 0x00016070
		// (set) Token: 0x06000D38 RID: 3384 RVA: 0x00017E84 File Offset: 0x00016084
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
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.created);
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06000D39 RID: 3385 RVA: 0x00017EB4 File Offset: 0x000160B4
		// (set) Token: 0x06000D3A RID: 3386 RVA: 0x00017EC8 File Offset: 0x000160C8
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
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.from_user);
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06000D3B RID: 3387 RVA: 0x00017EF4 File Offset: 0x000160F4
		// (set) Token: 0x06000D3C RID: 3388 RVA: 0x00017F08 File Offset: 0x00016108
		public int to_user
		{
			[CompilerGenerated]
			get
			{
				return this.<to_user>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<to_user>k__BackingField == value)
				{
					return;
				}
				this.<to_user>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.to_user);
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06000D3D RID: 3389 RVA: 0x00017F34 File Offset: 0x00016134
		// (set) Token: 0x06000D3E RID: 3390 RVA: 0x00017F48 File Offset: 0x00016148
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
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.notes);
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06000D3F RID: 3391 RVA: 0x00017F78 File Offset: 0x00016178
		// (set) Token: 0x06000D40 RID: 3392 RVA: 0x00017F8C File Offset: 0x0001618C
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
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.state);
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06000D41 RID: 3393 RVA: 0x00017FB8 File Offset: 0x000161B8
		// (set) Token: 0x06000D42 RID: 3394 RVA: 0x00017FCC File Offset: 0x000161CC
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
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.repair_id);
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06000D43 RID: 3395 RVA: 0x00017FFC File Offset: 0x000161FC
		// (set) Token: 0x06000D44 RID: 3396 RVA: 0x00018010 File Offset: 0x00016210
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
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.Summ);
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.Profit);
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.ManagerPart);
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.PriceFormatted);
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.price);
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06000D45 RID: 3397 RVA: 0x0001806C File Offset: 0x0001626C
		// (set) Token: 0x06000D46 RID: 3398 RVA: 0x00018080 File Offset: 0x00016280
		public string sn
		{
			[CompilerGenerated]
			get
			{
				return this.<sn>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<sn>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<sn>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.sn);
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06000D47 RID: 3399 RVA: 0x000180B0 File Offset: 0x000162B0
		// (set) Token: 0x06000D48 RID: 3400 RVA: 0x000180C4 File Offset: 0x000162C4
		public int? work_id
		{
			[CompilerGenerated]
			get
			{
				return this.<work_id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<work_id>k__BackingField, value))
				{
					return;
				}
				this.<work_id>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.work_id);
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06000D49 RID: 3401 RVA: 0x000180F4 File Offset: 0x000162F4
		// (set) Token: 0x06000D4A RID: 3402 RVA: 0x00018108 File Offset: 0x00016308
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
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.warranty);
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06000D4B RID: 3403 RVA: 0x00018134 File Offset: 0x00016334
		// (set) Token: 0x06000D4C RID: 3404 RVA: 0x00018148 File Offset: 0x00016348
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

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06000D4D RID: 3405 RVA: 0x00018178 File Offset: 0x00016378
		// (set) Token: 0x06000D4E RID: 3406 RVA: 0x0001818C File Offset: 0x0001638C
		public bool r_lock
		{
			[CompilerGenerated]
			get
			{
				return this.<r_lock>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<r_lock>k__BackingField == value)
				{
					return;
				}
				this.<r_lock>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.r_lock);
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06000D4F RID: 3407 RVA: 0x000181B8 File Offset: 0x000163B8
		// (set) Token: 0x06000D50 RID: 3408 RVA: 0x000181CC File Offset: 0x000163CC
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
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.Profit);
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.ManagerPart);
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.store_items);
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06000D51 RID: 3409 RVA: 0x00018210 File Offset: 0x00016410
		// (set) Token: 0x06000D52 RID: 3410 RVA: 0x00018224 File Offset: 0x00016424
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
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.OnFio);
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.ManagerPart);
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.users);
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06000D53 RID: 3411 RVA: 0x00018268 File Offset: 0x00016468
		// (set) Token: 0x06000D54 RID: 3412 RVA: 0x0001827C File Offset: 0x0001647C
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
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.users1);
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06000D55 RID: 3413 RVA: 0x000182AC File Offset: 0x000164AC
		// (set) Token: 0x06000D56 RID: 3414 RVA: 0x000182C0 File Offset: 0x000164C0
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
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.tasks);
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06000D57 RID: 3415 RVA: 0x000182F0 File Offset: 0x000164F0
		// (set) Token: 0x06000D58 RID: 3416 RVA: 0x00018304 File Offset: 0x00016504
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
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.workshop);
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06000D59 RID: 3417 RVA: 0x00018334 File Offset: 0x00016534
		// (set) Token: 0x06000D5A RID: 3418 RVA: 0x00018348 File Offset: 0x00016548
		public virtual works works
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
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.works);
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06000D5B RID: 3419 RVA: 0x00018378 File Offset: 0x00016578
		// (set) Token: 0x06000D5C RID: 3420 RVA: 0x0001838C File Offset: 0x0001658C
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
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.notifications);
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000D5D RID: 3421 RVA: 0x000183BC File Offset: 0x000165BC
		// (remove) Token: 0x06000D5E RID: 3422 RVA: 0x000183F8 File Offset: 0x000165F8
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

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06000D5F RID: 3423 RVA: 0x00018430 File Offset: 0x00016630
		public virtual decimal Summ
		{
			get
			{
				return Fn.FormatSumm(this.count * this.price);
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06000D60 RID: 3424 RVA: 0x00018458 File Offset: 0x00016658
		public virtual string OnFio
		{
			get
			{
				return string.Concat(new string[]
				{
					this.users.surname,
					" ",
					this.users.name,
					" ",
					this.users.patronymic
				});
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06000D61 RID: 3425 RVA: 0x000184AC File Offset: 0x000166AC
		public decimal Profit
		{
			get
			{
				decimal result;
				try
				{
					if (!this.store_items.is_realization)
					{
						goto IL_31;
					}
					IL_0D:
					int num = -463000502;
					IL_12:
					switch ((num ^ -757072481) % 4)
					{
					case 1:
						result = this.price - this.GetDealerPart();
						break;
					case 2:
						IL_31:
						result = this.price - this.store_items.in_price;
						num = -608498501;
						goto IL_12;
					case 3:
						goto IL_0D;
					}
				}
				catch (Exception exception)
				{
					store_int_reserve.Log.Error(exception, "Get profit summ fail, zero returned");
					result = 0m;
				}
				return result;
			}
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x00018548 File Offset: 0x00016748
		public decimal GetDealerPart()
		{
			decimal result;
			try
			{
				result = ((this.store_items.in_price == 0m) ? (this.price * this.count / 100m * this.store_items.return_percent) : this.store_items.in_price);
			}
			catch (Exception exception)
			{
				store_int_reserve.Log.Error(exception, "Get dealer part fail, zero returned");
				result = 0m;
			}
			return result;
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06000D63 RID: 3427 RVA: 0x000185E0 File Offset: 0x000167E0
		public decimal ManagerPart
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
					bool pay_4_sale_in_repair = users.pay_4_sale_in_repair;
					flag = false;
				}
				if (flag)
				{
					return 0m;
				}
				return Fn.FormatSumm(this.Profit / 100m * this.users.pay_sale);
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06000D64 RID: 3428 RVA: 0x00018638 File Offset: 0x00016838
		public decimal PriceFormatted
		{
			get
			{
				return Fn.FormatSumm(this.price);
			}
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x00018650 File Offset: 0x00016850
		// Note: this type is marked as 'beforefieldinit'.
		static store_int_reserve()
		{
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x00018668 File Offset: 0x00016868
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

		// Token: 0x0400064C RID: 1612
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x0400064D RID: 1613
		[CompilerGenerated]
		private int <item_id>k__BackingField;

		// Token: 0x0400064E RID: 1614
		[CompilerGenerated]
		private int <count>k__BackingField;

		// Token: 0x0400064F RID: 1615
		[CompilerGenerated]
		private DateTime? <created>k__BackingField;

		// Token: 0x04000650 RID: 1616
		[CompilerGenerated]
		private int <from_user>k__BackingField;

		// Token: 0x04000651 RID: 1617
		[CompilerGenerated]
		private int <to_user>k__BackingField;

		// Token: 0x04000652 RID: 1618
		[CompilerGenerated]
		private string <notes>k__BackingField;

		// Token: 0x04000653 RID: 1619
		[CompilerGenerated]
		private int <state>k__BackingField;

		// Token: 0x04000654 RID: 1620
		[CompilerGenerated]
		private int? <repair_id>k__BackingField;

		// Token: 0x04000655 RID: 1621
		[CompilerGenerated]
		private decimal <price>k__BackingField;

		// Token: 0x04000656 RID: 1622
		[CompilerGenerated]
		private string <sn>k__BackingField;

		// Token: 0x04000657 RID: 1623
		[CompilerGenerated]
		private int? <work_id>k__BackingField;

		// Token: 0x04000658 RID: 1624
		[CompilerGenerated]
		private int <warranty>k__BackingField;

		// Token: 0x04000659 RID: 1625
		[CompilerGenerated]
		private string <name>k__BackingField;

		// Token: 0x0400065A RID: 1626
		[CompilerGenerated]
		private bool <r_lock>k__BackingField;

		// Token: 0x0400065B RID: 1627
		[CompilerGenerated]
		private store_items <store_items>k__BackingField;

		// Token: 0x0400065C RID: 1628
		[CompilerGenerated]
		private users <users>k__BackingField;

		// Token: 0x0400065D RID: 1629
		[CompilerGenerated]
		private users <users1>k__BackingField;

		// Token: 0x0400065E RID: 1630
		[CompilerGenerated]
		private ICollection<tasks> <tasks>k__BackingField;

		// Token: 0x0400065F RID: 1631
		[CompilerGenerated]
		private workshop <workshop>k__BackingField;

		// Token: 0x04000660 RID: 1632
		[CompilerGenerated]
		private works <works>k__BackingField;

		// Token: 0x04000661 RID: 1633
		[CompilerGenerated]
		private ICollection<notifications> <notifications>k__BackingField;

		// Token: 0x04000662 RID: 1634
		private static readonly ILogger Log = LogManager.GetCurrentClassLogger();

		// Token: 0x04000663 RID: 1635
		[CompilerGenerated]
		private PropertyChangedEventHandler PropertyChanged;
	}
}
