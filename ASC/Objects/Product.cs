using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;
using DevExpress.Mvvm;

namespace ASC.Objects
{
	// Token: 0x02000873 RID: 2163
	public class Product : BindableBase, IDisposable, IIdName, ICheckFields
	{
		// Token: 0x1700113C RID: 4412
		// (get) Token: 0x06004032 RID: 16434 RVA: 0x000FFC94 File Offset: 0x000FDE94
		// (set) Token: 0x06004033 RID: 16435 RVA: 0x000FFCA8 File Offset: 0x000FDEA8
		public int Id
		{
			[CompilerGenerated]
			get
			{
				return this.<Id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Id>k__BackingField == value)
				{
					return;
				}
				this.<Id>k__BackingField = value;
				this.RaisePropertyChanged("UID");
				this.RaisePropertyChanged("Id");
			}
		}

		// Token: 0x1700113D RID: 4413
		// (get) Token: 0x06004034 RID: 16436 RVA: 0x000FFCE0 File Offset: 0x000FDEE0
		// (set) Token: 0x06004035 RID: 16437 RVA: 0x000FFCF4 File Offset: 0x000FDEF4
		public int Articul
		{
			[CompilerGenerated]
			get
			{
				return this.<Articul>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Articul>k__BackingField == value)
				{
					return;
				}
				this.<Articul>k__BackingField = value;
				this.RaisePropertyChanged("UID");
				this.RaisePropertyChanged("Articul");
			}
		}

		// Token: 0x1700113E RID: 4414
		// (get) Token: 0x06004036 RID: 16438 RVA: 0x000FFD2C File Offset: 0x000FDF2C
		// (set) Token: 0x06004037 RID: 16439 RVA: 0x000FFD40 File Offset: 0x000FDF40
		public int DealerId
		{
			[CompilerGenerated]
			get
			{
				return this.<DealerId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<DealerId>k__BackingField == value)
				{
					return;
				}
				this.<DealerId>k__BackingField = value;
				this.RaisePropertyChanged("DealerId");
			}
		}

		// Token: 0x1700113F RID: 4415
		// (get) Token: 0x06004038 RID: 16440 RVA: 0x000FFD6C File Offset: 0x000FDF6C
		// (set) Token: 0x06004039 RID: 16441 RVA: 0x000FFD80 File Offset: 0x000FDF80
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.<Name>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Name>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Name>k__BackingField = value;
				this.RaisePropertyChanged("DescriptionOrName");
				this.RaisePropertyChanged("Name");
			}
		}

		// Token: 0x17001140 RID: 4416
		// (get) Token: 0x0600403A RID: 16442 RVA: 0x000FFDBC File Offset: 0x000FDFBC
		// (set) Token: 0x0600403B RID: 16443 RVA: 0x000FFDD0 File Offset: 0x000FDFD0
		public int State
		{
			[CompilerGenerated]
			get
			{
				return this.<State>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<State>k__BackingField == value)
				{
					return;
				}
				this.<State>k__BackingField = value;
				this.RaisePropertyChanged("State");
			}
		}

		// Token: 0x17001141 RID: 4417
		// (get) Token: 0x0600403C RID: 16444 RVA: 0x000FFDFC File Offset: 0x000FDFFC
		// (set) Token: 0x0600403D RID: 16445 RVA: 0x000FFE10 File Offset: 0x000FE010
		public int CategoryId
		{
			[CompilerGenerated]
			get
			{
				return this.<CategoryId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CategoryId>k__BackingField == value)
				{
					return;
				}
				this.<CategoryId>k__BackingField = value;
				this.RaisePropertyChanged("CategoryId");
			}
		}

		// Token: 0x17001142 RID: 4418
		// (get) Token: 0x0600403E RID: 16446 RVA: 0x000FFE3C File Offset: 0x000FE03C
		// (set) Token: 0x0600403F RID: 16447 RVA: 0x000FFE50 File Offset: 0x000FE050
		public int StoreId
		{
			[CompilerGenerated]
			get
			{
				return this.<StoreId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<StoreId>k__BackingField == value)
				{
					return;
				}
				this.<StoreId>k__BackingField = value;
				this.RaisePropertyChanged("StoreId");
			}
		}

		// Token: 0x17001143 RID: 4419
		// (get) Token: 0x06004040 RID: 16448 RVA: 0x000FFE7C File Offset: 0x000FE07C
		// (set) Token: 0x06004041 RID: 16449 RVA: 0x000FFE90 File Offset: 0x000FE090
		public DateTime? Created
		{
			[CompilerGenerated]
			get
			{
				return this.<Created>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<DateTime>(this.<Created>k__BackingField, value))
				{
					return;
				}
				this.<Created>k__BackingField = value;
				this.RaisePropertyChanged("Created");
			}
		}

		// Token: 0x17001144 RID: 4420
		// (get) Token: 0x06004042 RID: 16450 RVA: 0x000FFEC0 File Offset: 0x000FE0C0
		// (set) Token: 0x06004043 RID: 16451 RVA: 0x000FFED4 File Offset: 0x000FE0D4
		public int Count
		{
			[CompilerGenerated]
			get
			{
				return this.<Count>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Count>k__BackingField == value)
				{
					return;
				}
				this.<Count>k__BackingField = value;
				this.RaisePropertyChanged("Available");
				this.RaisePropertyChanged("Count");
			}
		}

		// Token: 0x17001145 RID: 4421
		// (get) Token: 0x06004044 RID: 16452 RVA: 0x000FFF0C File Offset: 0x000FE10C
		// (set) Token: 0x06004045 RID: 16453 RVA: 0x000FFF20 File Offset: 0x000FE120
		public int Reserved
		{
			[CompilerGenerated]
			get
			{
				return this.<Reserved>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Reserved>k__BackingField == value)
				{
					return;
				}
				this.<Reserved>k__BackingField = value;
				this.RaisePropertyChanged("Available");
				this.RaisePropertyChanged("Reserved");
			}
		}

		// Token: 0x17001146 RID: 4422
		// (get) Token: 0x06004046 RID: 16454 RVA: 0x000FFF58 File Offset: 0x000FE158
		// (set) Token: 0x06004047 RID: 16455 RVA: 0x000FFF6C File Offset: 0x000FE16C
		public int Units
		{
			[CompilerGenerated]
			get
			{
				return this.<Units>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Units>k__BackingField == value)
				{
					return;
				}
				this.<Units>k__BackingField = value;
				this.RaisePropertyChanged("Units");
			}
		}

		// Token: 0x17001147 RID: 4423
		// (get) Token: 0x06004048 RID: 16456 RVA: 0x000FFF98 File Offset: 0x000FE198
		// (set) Token: 0x06004049 RID: 16457 RVA: 0x000FFFAC File Offset: 0x000FE1AC
		public int? BoxId
		{
			[CompilerGenerated]
			get
			{
				return this.<BoxId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<BoxId>k__BackingField, value))
				{
					return;
				}
				this.<BoxId>k__BackingField = value;
				this.RaisePropertyChanged("BoxId");
			}
		}

		// Token: 0x17001148 RID: 4424
		// (get) Token: 0x0600404A RID: 16458 RVA: 0x000FFFDC File Offset: 0x000FE1DC
		// (set) Token: 0x0600404B RID: 16459 RVA: 0x000FFFF0 File Offset: 0x000FE1F0
		public int PriceOption
		{
			[CompilerGenerated]
			get
			{
				return this.<PriceOption>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PriceOption>k__BackingField == value)
				{
					return;
				}
				this.<PriceOption>k__BackingField = value;
				this.RaisePropertyChanged("Price1Raw");
				this.RaisePropertyChanged("Price2Raw");
				this.RaisePropertyChanged("Price3Raw");
				this.RaisePropertyChanged("Price4Raw");
				this.RaisePropertyChanged("Price5Raw");
				this.RaisePropertyChanged("PriceOption");
			}
		}

		// Token: 0x17001149 RID: 4425
		// (get) Token: 0x0600404C RID: 16460 RVA: 0x00100054 File Offset: 0x000FE254
		// (set) Token: 0x0600404D RID: 16461 RVA: 0x00100068 File Offset: 0x000FE268
		public decimal CurrencyRate
		{
			[CompilerGenerated]
			get
			{
				return this.<CurrencyRate>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<CurrencyRate>k__BackingField, value))
				{
					return;
				}
				this.<CurrencyRate>k__BackingField = value;
				this.RaisePropertyChanged("Price1Raw");
				this.RaisePropertyChanged("Price2Raw");
				this.RaisePropertyChanged("Price3Raw");
				this.RaisePropertyChanged("Price4Raw");
				this.RaisePropertyChanged("Price5Raw");
				this.RaisePropertyChanged("CurrencyRate");
			}
		}

		// Token: 0x1700114A RID: 4426
		// (get) Token: 0x0600404E RID: 16462 RVA: 0x001000D0 File Offset: 0x000FE2D0
		// (set) Token: 0x0600404F RID: 16463 RVA: 0x001000E4 File Offset: 0x000FE2E4
		public decimal InPrice
		{
			[CompilerGenerated]
			get
			{
				return this.<InPrice>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<InPrice>k__BackingField, value))
				{
					return;
				}
				this.<InPrice>k__BackingField = value;
				this.RaisePropertyChanged("InPrice");
			}
		}

		// Token: 0x1700114B RID: 4427
		// (get) Token: 0x06004050 RID: 16464 RVA: 0x00100114 File Offset: 0x000FE314
		// (set) Token: 0x06004051 RID: 16465 RVA: 0x00100128 File Offset: 0x000FE328
		public decimal Price
		{
			[CompilerGenerated]
			get
			{
				return this.<Price>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<Price>k__BackingField, value))
				{
					return;
				}
				this.<Price>k__BackingField = value;
				this.RaisePropertyChanged("Price1Raw");
				this.RaisePropertyChanged("Price");
			}
		}

		// Token: 0x1700114C RID: 4428
		// (get) Token: 0x06004052 RID: 16466 RVA: 0x00100164 File Offset: 0x000FE364
		// (set) Token: 0x06004053 RID: 16467 RVA: 0x00100178 File Offset: 0x000FE378
		public decimal Price2
		{
			[CompilerGenerated]
			get
			{
				return this.<Price2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<Price2>k__BackingField, value))
				{
					return;
				}
				this.<Price2>k__BackingField = value;
				this.RaisePropertyChanged("Price2Raw");
				this.RaisePropertyChanged("Price2");
			}
		}

		// Token: 0x1700114D RID: 4429
		// (get) Token: 0x06004054 RID: 16468 RVA: 0x001001B4 File Offset: 0x000FE3B4
		// (set) Token: 0x06004055 RID: 16469 RVA: 0x001001C8 File Offset: 0x000FE3C8
		public decimal Price3
		{
			[CompilerGenerated]
			get
			{
				return this.<Price3>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<Price3>k__BackingField, value))
				{
					return;
				}
				this.<Price3>k__BackingField = value;
				this.RaisePropertyChanged("Price3Raw");
				this.RaisePropertyChanged("Price3");
			}
		}

		// Token: 0x1700114E RID: 4430
		// (get) Token: 0x06004056 RID: 16470 RVA: 0x00100204 File Offset: 0x000FE404
		// (set) Token: 0x06004057 RID: 16471 RVA: 0x00100218 File Offset: 0x000FE418
		public decimal Price4
		{
			[CompilerGenerated]
			get
			{
				return this.<Price4>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<Price4>k__BackingField, value))
				{
					return;
				}
				this.<Price4>k__BackingField = value;
				this.RaisePropertyChanged("Price4Raw");
				this.RaisePropertyChanged("Price4");
			}
		}

		// Token: 0x1700114F RID: 4431
		// (get) Token: 0x06004058 RID: 16472 RVA: 0x00100254 File Offset: 0x000FE454
		// (set) Token: 0x06004059 RID: 16473 RVA: 0x00100268 File Offset: 0x000FE468
		public decimal Price5
		{
			[CompilerGenerated]
			get
			{
				return this.<Price5>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<Price5>k__BackingField, value))
				{
					return;
				}
				this.<Price5>k__BackingField = value;
				this.RaisePropertyChanged("Price5Raw");
				this.RaisePropertyChanged("Price5");
			}
		}

		// Token: 0x17001150 RID: 4432
		// (get) Token: 0x0600405A RID: 16474 RVA: 0x001002A4 File Offset: 0x000FE4A4
		// (set) Token: 0x0600405B RID: 16475 RVA: 0x001002C0 File Offset: 0x000FE4C0
		public virtual decimal Price1Raw
		{
			get
			{
				return this.FormatPrice(this.Price);
			}
			set
			{
				if (decimal.Equals(this.Price1Raw, value))
				{
					return;
				}
				this.Price = this.SetPrice(value);
				this.RaisePropertyChanged("Price1Raw");
			}
		}

		// Token: 0x17001151 RID: 4433
		// (get) Token: 0x0600405C RID: 16476 RVA: 0x001002F4 File Offset: 0x000FE4F4
		// (set) Token: 0x0600405D RID: 16477 RVA: 0x00100310 File Offset: 0x000FE510
		public virtual decimal Price2Raw
		{
			get
			{
				return this.FormatPrice(this.Price2);
			}
			set
			{
				if (decimal.Equals(this.Price2Raw, value))
				{
					return;
				}
				this.Price2 = this.SetPrice(value);
				this.RaisePropertyChanged("Price2Raw");
			}
		}

		// Token: 0x17001152 RID: 4434
		// (get) Token: 0x0600405E RID: 16478 RVA: 0x00100344 File Offset: 0x000FE544
		// (set) Token: 0x0600405F RID: 16479 RVA: 0x00100360 File Offset: 0x000FE560
		public virtual decimal Price3Raw
		{
			get
			{
				return this.FormatPrice(this.Price3);
			}
			set
			{
				if (decimal.Equals(this.Price3Raw, value))
				{
					return;
				}
				this.Price3 = this.SetPrice(value);
				this.RaisePropertyChanged("Price3Raw");
			}
		}

		// Token: 0x17001153 RID: 4435
		// (get) Token: 0x06004060 RID: 16480 RVA: 0x00100394 File Offset: 0x000FE594
		// (set) Token: 0x06004061 RID: 16481 RVA: 0x001003B0 File Offset: 0x000FE5B0
		public virtual decimal Price4Raw
		{
			get
			{
				return this.FormatPrice(this.Price4);
			}
			set
			{
				if (decimal.Equals(this.Price4Raw, value))
				{
					return;
				}
				this.Price4 = this.SetPrice(value);
				this.RaisePropertyChanged("Price4Raw");
			}
		}

		// Token: 0x17001154 RID: 4436
		// (get) Token: 0x06004062 RID: 16482 RVA: 0x001003E4 File Offset: 0x000FE5E4
		// (set) Token: 0x06004063 RID: 16483 RVA: 0x00100400 File Offset: 0x000FE600
		public virtual decimal Price5Raw
		{
			get
			{
				return this.FormatPrice(this.Price5);
			}
			set
			{
				if (decimal.Equals(this.Price5Raw, value))
				{
					return;
				}
				this.Price5 = this.SetPrice(value);
				this.RaisePropertyChanged("Price5Raw");
			}
		}

		// Token: 0x17001155 RID: 4437
		// (get) Token: 0x06004064 RID: 16484 RVA: 0x00100434 File Offset: 0x000FE634
		// (set) Token: 0x06004065 RID: 16485 RVA: 0x00100448 File Offset: 0x000FE648
		public int? DocumentId
		{
			[CompilerGenerated]
			get
			{
				return this.<DocumentId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<DocumentId>k__BackingField, value))
				{
					return;
				}
				this.<DocumentId>k__BackingField = value;
				this.RaisePropertyChanged("DocumentId");
			}
		}

		// Token: 0x17001156 RID: 4438
		// (get) Token: 0x06004066 RID: 16486 RVA: 0x00100478 File Offset: 0x000FE678
		// (set) Token: 0x06004067 RID: 16487 RVA: 0x0010048C File Offset: 0x000FE68C
		public int? PartRequestId
		{
			[CompilerGenerated]
			get
			{
				return this.<PartRequestId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!Nullable.Equals<int>(this.<PartRequestId>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 824049575;
				IL_13:
				switch ((num ^ 1829055862) % 4)
				{
				case 0:
					IL_32:
					this.<PartRequestId>k__BackingField = value;
					this.RaisePropertyChanged("PartRequestId");
					num = 1815832877;
					goto IL_13;
				case 1:
					return;
				case 2:
					goto IL_0E;
				}
			}
		}

		// Token: 0x17001157 RID: 4439
		// (get) Token: 0x06004068 RID: 16488 RVA: 0x001004E8 File Offset: 0x000FE6E8
		// (set) Token: 0x06004069 RID: 16489 RVA: 0x001004FC File Offset: 0x000FE6FC
		public string ShopTitle
		{
			[CompilerGenerated]
			get
			{
				return this.<ShopTitle>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<ShopTitle>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<ShopTitle>k__BackingField = value;
				this.RaisePropertyChanged("ShopTitle");
			}
		}

		// Token: 0x17001158 RID: 4440
		// (get) Token: 0x0600406A RID: 16490 RVA: 0x0010052C File Offset: 0x000FE72C
		// (set) Token: 0x0600406B RID: 16491 RVA: 0x00100540 File Offset: 0x000FE740
		public string ShopDescription
		{
			[CompilerGenerated]
			get
			{
				return this.<ShopDescription>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<ShopDescription>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<ShopDescription>k__BackingField = value;
				this.RaisePropertyChanged("ShopDescription");
			}
		}

		// Token: 0x17001159 RID: 4441
		// (get) Token: 0x0600406C RID: 16492 RVA: 0x00100570 File Offset: 0x000FE770
		// (set) Token: 0x0600406D RID: 16493 RVA: 0x00100584 File Offset: 0x000FE784
		public string Sn
		{
			[CompilerGenerated]
			get
			{
				return this.<Sn>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Sn>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Sn>k__BackingField = value;
				this.RaisePropertyChanged("Sn");
			}
		}

		// Token: 0x1700115A RID: 4442
		// (get) Token: 0x0600406E RID: 16494 RVA: 0x001005B4 File Offset: 0x000FE7B4
		// (set) Token: 0x0600406F RID: 16495 RVA: 0x001005C8 File Offset: 0x000FE7C8
		public string Pn
		{
			[CompilerGenerated]
			get
			{
				return this.<Pn>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Pn>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Pn>k__BackingField = value;
				this.RaisePropertyChanged("Pn");
			}
		}

		// Token: 0x1700115B RID: 4443
		// (get) Token: 0x06004070 RID: 16496 RVA: 0x001005F8 File Offset: 0x000FE7F8
		// (set) Token: 0x06004071 RID: 16497 RVA: 0x0010060C File Offset: 0x000FE80C
		public string Description
		{
			[CompilerGenerated]
			get
			{
				return this.<Description>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Description>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Description>k__BackingField = value;
				this.RaisePropertyChanged("DescriptionOrName");
				this.RaisePropertyChanged("Description");
			}
		}

		// Token: 0x1700115C RID: 4444
		// (get) Token: 0x06004072 RID: 16498 RVA: 0x00100648 File Offset: 0x000FE848
		// (set) Token: 0x06004073 RID: 16499 RVA: 0x0010065C File Offset: 0x000FE85C
		public bool? ShopEnable
		{
			[CompilerGenerated]
			get
			{
				return this.<ShopEnable>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<bool>(this.<ShopEnable>k__BackingField, value))
				{
					return;
				}
				this.<ShopEnable>k__BackingField = value;
				this.RaisePropertyChanged("ShopEnable");
			}
		}

		// Token: 0x1700115D RID: 4445
		// (get) Token: 0x06004074 RID: 16500 RVA: 0x0010068C File Offset: 0x000FE88C
		// (set) Token: 0x06004075 RID: 16501 RVA: 0x001006A0 File Offset: 0x000FE8A0
		public string AscBarcode
		{
			[CompilerGenerated]
			get
			{
				return this.<AscBarcode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<AscBarcode>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<AscBarcode>k__BackingField = value;
				this.RaisePropertyChanged("AscBarcode");
			}
		}

		// Token: 0x1700115E RID: 4446
		// (get) Token: 0x06004076 RID: 16502 RVA: 0x001006D0 File Offset: 0x000FE8D0
		// (set) Token: 0x06004077 RID: 16503 RVA: 0x001006E4 File Offset: 0x000FE8E4
		public string Barcode
		{
			[CompilerGenerated]
			get
			{
				return this.<Barcode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Barcode>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Barcode>k__BackingField = value;
				this.RaisePropertyChanged("Barcode");
			}
		}

		// Token: 0x1700115F RID: 4447
		// (get) Token: 0x06004078 RID: 16504 RVA: 0x00100714 File Offset: 0x000FE914
		// (set) Token: 0x06004079 RID: 16505 RVA: 0x00100728 File Offset: 0x000FE928
		public int InCount
		{
			[CompilerGenerated]
			get
			{
				return this.<InCount>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<InCount>k__BackingField == value)
				{
					return;
				}
				this.<InCount>k__BackingField = value;
				this.RaisePropertyChanged("InCount");
			}
		}

		// Token: 0x17001160 RID: 4448
		// (get) Token: 0x0600407A RID: 16506 RVA: 0x00100754 File Offset: 0x000FE954
		// (set) Token: 0x0600407B RID: 16507 RVA: 0x00100768 File Offset: 0x000FE968
		public decimal InSumm
		{
			[CompilerGenerated]
			get
			{
				return this.<InSumm>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<InSumm>k__BackingField, value))
				{
					return;
				}
				this.<InSumm>k__BackingField = value;
				this.RaisePropertyChanged("InSumm");
			}
		}

		// Token: 0x17001161 RID: 4449
		// (get) Token: 0x0600407C RID: 16508 RVA: 0x00100798 File Offset: 0x000FE998
		// (set) Token: 0x0600407D RID: 16509 RVA: 0x001007AC File Offset: 0x000FE9AC
		public string Notes
		{
			[CompilerGenerated]
			get
			{
				return this.<Notes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Notes>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Notes>k__BackingField = value;
				this.RaisePropertyChanged("Notes");
			}
		}

		// Token: 0x17001162 RID: 4450
		// (get) Token: 0x0600407E RID: 16510 RVA: 0x001007DC File Offset: 0x000FE9DC
		// (set) Token: 0x0600407F RID: 16511 RVA: 0x001007F0 File Offset: 0x000FE9F0
		public int MinimumInStock
		{
			[CompilerGenerated]
			get
			{
				return this.<MinimumInStock>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<MinimumInStock>k__BackingField == value)
				{
					return;
				}
				this.<MinimumInStock>k__BackingField = value;
				this.RaisePropertyChanged("MinimumInStock");
			}
		}

		// Token: 0x17001163 RID: 4451
		// (get) Token: 0x06004080 RID: 16512 RVA: 0x0010081C File Offset: 0x000FEA1C
		// (set) Token: 0x06004081 RID: 16513 RVA: 0x00100830 File Offset: 0x000FEA30
		public int Sold
		{
			[CompilerGenerated]
			get
			{
				return this.<Sold>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Sold>k__BackingField == value)
				{
					return;
				}
				this.<Sold>k__BackingField = value;
				this.RaisePropertyChanged("Sold");
			}
		}

		// Token: 0x17001164 RID: 4452
		// (get) Token: 0x06004082 RID: 16514 RVA: 0x0010085C File Offset: 0x000FEA5C
		// (set) Token: 0x06004083 RID: 16515 RVA: 0x00100870 File Offset: 0x000FEA70
		public int ReturnPercent
		{
			[CompilerGenerated]
			get
			{
				return this.<ReturnPercent>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ReturnPercent>k__BackingField == value)
				{
					return;
				}
				this.<ReturnPercent>k__BackingField = value;
				this.RaisePropertyChanged("ReturnPercent");
			}
		}

		// Token: 0x17001165 RID: 4453
		// (get) Token: 0x06004084 RID: 16516 RVA: 0x0010089C File Offset: 0x000FEA9C
		// (set) Token: 0x06004085 RID: 16517 RVA: 0x001008B0 File Offset: 0x000FEAB0
		public int Warranty
		{
			[CompilerGenerated]
			get
			{
				return this.<Warranty>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Warranty>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -1847896589;
				IL_10:
				switch ((num ^ -1754250335) % 4)
				{
				case 1:
					IL_2F:
					this.<Warranty>k__BackingField = value;
					this.RaisePropertyChanged("Warranty");
					num = -392535011;
					goto IL_10;
				case 2:
					return;
				case 3:
					goto IL_0B;
				}
			}
		}

		// Token: 0x17001166 RID: 4454
		// (get) Token: 0x06004086 RID: 16518 RVA: 0x00100908 File Offset: 0x000FEB08
		// (set) Token: 0x06004087 RID: 16519 RVA: 0x0010091C File Offset: 0x000FEB1C
		public int DealerWarranty
		{
			[CompilerGenerated]
			get
			{
				return this.<DealerWarranty>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<DealerWarranty>k__BackingField == value)
				{
					return;
				}
				this.<DealerWarranty>k__BackingField = value;
				this.RaisePropertyChanged("DealerWarranty");
			}
		}

		// Token: 0x17001167 RID: 4455
		// (get) Token: 0x06004088 RID: 16520 RVA: 0x00100948 File Offset: 0x000FEB48
		// (set) Token: 0x06004089 RID: 16521 RVA: 0x0010095C File Offset: 0x000FEB5C
		public bool NotForSale
		{
			[CompilerGenerated]
			get
			{
				return this.<NotForSale>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<NotForSale>k__BackingField == value)
				{
					return;
				}
				this.<NotForSale>k__BackingField = value;
				this.RaisePropertyChanged("NotForSale");
			}
		}

		// Token: 0x17001168 RID: 4456
		// (get) Token: 0x0600408A RID: 16522 RVA: 0x00100988 File Offset: 0x000FEB88
		// (set) Token: 0x0600408B RID: 16523 RVA: 0x0010099C File Offset: 0x000FEB9C
		public bool IsRealization
		{
			[CompilerGenerated]
			get
			{
				return this.<IsRealization>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IsRealization>k__BackingField == value)
				{
					return;
				}
				this.<IsRealization>k__BackingField = value;
				this.RaisePropertyChanged("Price1Raw");
				this.RaisePropertyChanged("Price2Raw");
				this.RaisePropertyChanged("Price3Raw");
				this.RaisePropertyChanged("Price4Raw");
				this.RaisePropertyChanged("Price5Raw");
				this.RaisePropertyChanged("IsRealization");
			}
		}

		// Token: 0x17001169 RID: 4457
		// (get) Token: 0x0600408C RID: 16524 RVA: 0x00100A00 File Offset: 0x000FEC00
		public string UID
		{
			get
			{
				return string.Format("{0:D6}-{1:D6}", this.Articul, this.Id);
			}
		}

		// Token: 0x1700116A RID: 4458
		// (get) Token: 0x0600408D RID: 16525 RVA: 0x00100A30 File Offset: 0x000FEC30
		// (set) Token: 0x0600408E RID: 16526 RVA: 0x00100A44 File Offset: 0x000FEC44
		public List<images> Images
		{
			[CompilerGenerated]
			get
			{
				return this.<Images>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Images>k__BackingField, value))
				{
					return;
				}
				this.<Images>k__BackingField = value;
				this.RaisePropertyChanged("Images");
			}
		}

		// Token: 0x1700116B RID: 4459
		// (get) Token: 0x0600408F RID: 16527 RVA: 0x00100A74 File Offset: 0x000FEC74
		// (set) Token: 0x06004090 RID: 16528 RVA: 0x00100A88 File Offset: 0x000FEC88
		public List<IAttribute> Attributes
		{
			[CompilerGenerated]
			get
			{
				return this.<Attributes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Attributes>k__BackingField, value))
				{
					return;
				}
				this.<Attributes>k__BackingField = value;
				this.RaisePropertyChanged("Attributes");
			}
		}

		// Token: 0x1700116C RID: 4460
		// (get) Token: 0x06004091 RID: 16529 RVA: 0x00100AB8 File Offset: 0x000FECB8
		// (set) Token: 0x06004092 RID: 16530 RVA: 0x00100ACC File Offset: 0x000FECCC
		public List<int> ImageIds
		{
			[CompilerGenerated]
			get
			{
				return this.<ImageIds>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ImageIds>k__BackingField, value))
				{
					return;
				}
				this.<ImageIds>k__BackingField = value;
				this.RaisePropertyChanged("ImageIds");
			}
		}

		// Token: 0x1700116D RID: 4461
		// (get) Token: 0x06004093 RID: 16531 RVA: 0x00100AFC File Offset: 0x000FECFC
		// (set) Token: 0x06004094 RID: 16532 RVA: 0x00100B10 File Offset: 0x000FED10
		public string BoxName
		{
			[CompilerGenerated]
			get
			{
				return this.<BoxName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<BoxName>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<BoxName>k__BackingField = value;
				this.RaisePropertyChanged("BoxName");
			}
		}

		// Token: 0x1700116E RID: 4462
		// (get) Token: 0x06004095 RID: 16533 RVA: 0x00100B40 File Offset: 0x000FED40
		// (set) Token: 0x06004096 RID: 16534 RVA: 0x00100B54 File Offset: 0x000FED54
		public string StateName
		{
			[CompilerGenerated]
			get
			{
				return this.<StateName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<StateName>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<StateName>k__BackingField = value;
				this.RaisePropertyChanged("StateName");
			}
		}

		// Token: 0x1700116F RID: 4463
		// (get) Token: 0x06004097 RID: 16535 RVA: 0x00100B84 File Offset: 0x000FED84
		public int Available
		{
			get
			{
				return this.Count - this.Reserved;
			}
		}

		// Token: 0x17001170 RID: 4464
		// (get) Token: 0x06004098 RID: 16536 RVA: 0x00100BA0 File Offset: 0x000FEDA0
		public virtual string DescriptionOrName
		{
			get
			{
				if (!string.IsNullOrEmpty(this.Description))
				{
					return this.Description;
				}
				return this.Name;
			}
		}

		// Token: 0x17001171 RID: 4465
		// (get) Token: 0x06004099 RID: 16537 RVA: 0x00100BC8 File Offset: 0x000FEDC8
		// (set) Token: 0x0600409A RID: 16538 RVA: 0x00100BDC File Offset: 0x000FEDDC
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

		// Token: 0x0600409B RID: 16539 RVA: 0x00100C08 File Offset: 0x000FEE08
		public Product()
		{
			this.Images = new List<images>();
			this.ImageIds = new List<int>();
			this.Attributes = new List<IAttribute>();
		}

		// Token: 0x0600409C RID: 16540 RVA: 0x00100C3C File Offset: 0x000FEE3C
		public void CalcInSumm()
		{
			this.InSumm = this.InCount * this.InPrice;
		}

		// Token: 0x0600409D RID: 16541 RVA: 0x00100C68 File Offset: 0x000FEE68
		public void SetInPriceForAll()
		{
			decimal inPrice = this.InPrice;
			this.InPrice = inPrice / this.InCount;
		}

		// Token: 0x0600409E RID: 16542 RVA: 0x00100C94 File Offset: 0x000FEE94
		public void SetImageIds(IEnumerable<int> ids)
		{
			this.ImageIds.Clear();
			this.ImageIds.AddRange(ids);
		}

		// Token: 0x0600409F RID: 16543 RVA: 0x00100CB8 File Offset: 0x000FEEB8
		public void SetImages(IEnumerable<images> images)
		{
			this.Images.Clear();
			this.Images.AddRange(images);
			this.SetImageIds(this.GetImageIds(images));
		}

		// Token: 0x060040A0 RID: 16544 RVA: 0x00100CEC File Offset: 0x000FEEEC
		private IEnumerable<int> GetImageIds(IEnumerable<images> images)
		{
			return (from i in images
			where i.id > 0
			select i.id).ToList<int>();
		}

		// Token: 0x060040A1 RID: 16545 RVA: 0x00100D48 File Offset: 0x000FEF48
		public void SetAttributes(IEnumerable<IAttribute> a)
		{
			this.Attributes.Clear();
			this.Attributes.AddRange(a);
		}

		// Token: 0x060040A2 RID: 16546 RVA: 0x00100D6C File Offset: 0x000FEF6C
		public string CheckFields()
		{
			if (this.InCount <= 0)
			{
				return "ItemErrorCount";
			}
			if (string.IsNullOrEmpty(this.Name))
			{
				return "ItemError";
			}
			this.Name = this.Name.Trim();
			if (this.Name.Length > 254)
			{
				return "ItemNameTooLong";
			}
			if (this.CategoryId == 0)
			{
				return "ItemErrorCategory";
			}
			return "";
		}

		// Token: 0x060040A3 RID: 16547 RVA: 0x00100DD8 File Offset: 0x000FEFD8
		public void Dispose()
		{
			this.Images = null;
			this.Name = string.Empty;
			this.Description = string.Empty;
			this.ShopTitle = string.Empty;
			this.ShopDescription = string.Empty;
			this.AscBarcode = string.Empty;
			this.Barcode = string.Empty;
			this.Attributes = null;
		}

		// Token: 0x060040A4 RID: 16548 RVA: 0x00100E38 File Offset: 0x000FF038
		private decimal SetPrice(decimal value)
		{
			if (!this.IsRealization)
			{
				if (this.PriceOption == 2)
				{
					return value / Auth.CurrencyModel.Rate * this.CurrencyRate;
				}
			}
			if (this.PriceOption != 1)
			{
				if (this.PriceOption != 3)
				{
					return 0m;
				}
			}
			return value;
		}

		// Token: 0x060040A5 RID: 16549 RVA: 0x00100E90 File Offset: 0x000FF090
		public decimal FormatPrice(decimal value)
		{
			if (!this.IsRealization && this.PriceOption == 2)
			{
				if (this.CurrencyRate == 0m)
				{
					return 0m;
				}
				value = value / this.CurrencyRate * Auth.CurrencyModel.Rate;
			}
			return value;
		}

		// Token: 0x04002A11 RID: 10769
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04002A12 RID: 10770
		[CompilerGenerated]
		private int <Articul>k__BackingField;

		// Token: 0x04002A13 RID: 10771
		[CompilerGenerated]
		private int <DealerId>k__BackingField;

		// Token: 0x04002A14 RID: 10772
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04002A15 RID: 10773
		[CompilerGenerated]
		private int <State>k__BackingField;

		// Token: 0x04002A16 RID: 10774
		[CompilerGenerated]
		private int <CategoryId>k__BackingField;

		// Token: 0x04002A17 RID: 10775
		[CompilerGenerated]
		private int <StoreId>k__BackingField;

		// Token: 0x04002A18 RID: 10776
		[CompilerGenerated]
		private DateTime? <Created>k__BackingField;

		// Token: 0x04002A19 RID: 10777
		[CompilerGenerated]
		private int <Count>k__BackingField;

		// Token: 0x04002A1A RID: 10778
		[CompilerGenerated]
		private int <Reserved>k__BackingField;

		// Token: 0x04002A1B RID: 10779
		[CompilerGenerated]
		private int <Units>k__BackingField;

		// Token: 0x04002A1C RID: 10780
		[CompilerGenerated]
		private int? <BoxId>k__BackingField;

		// Token: 0x04002A1D RID: 10781
		[CompilerGenerated]
		private int <PriceOption>k__BackingField;

		// Token: 0x04002A1E RID: 10782
		[CompilerGenerated]
		private decimal <CurrencyRate>k__BackingField;

		// Token: 0x04002A1F RID: 10783
		[CompilerGenerated]
		private decimal <InPrice>k__BackingField;

		// Token: 0x04002A20 RID: 10784
		[CompilerGenerated]
		private decimal <Price>k__BackingField;

		// Token: 0x04002A21 RID: 10785
		[CompilerGenerated]
		private decimal <Price2>k__BackingField;

		// Token: 0x04002A22 RID: 10786
		[CompilerGenerated]
		private decimal <Price3>k__BackingField;

		// Token: 0x04002A23 RID: 10787
		[CompilerGenerated]
		private decimal <Price4>k__BackingField;

		// Token: 0x04002A24 RID: 10788
		[CompilerGenerated]
		private decimal <Price5>k__BackingField;

		// Token: 0x04002A25 RID: 10789
		[CompilerGenerated]
		private int? <DocumentId>k__BackingField;

		// Token: 0x04002A26 RID: 10790
		[CompilerGenerated]
		private int? <PartRequestId>k__BackingField;

		// Token: 0x04002A27 RID: 10791
		[CompilerGenerated]
		private string <ShopTitle>k__BackingField;

		// Token: 0x04002A28 RID: 10792
		[CompilerGenerated]
		private string <ShopDescription>k__BackingField;

		// Token: 0x04002A29 RID: 10793
		[CompilerGenerated]
		private string <Sn>k__BackingField;

		// Token: 0x04002A2A RID: 10794
		[CompilerGenerated]
		private string <Pn>k__BackingField;

		// Token: 0x04002A2B RID: 10795
		[CompilerGenerated]
		private string <Description>k__BackingField;

		// Token: 0x04002A2C RID: 10796
		[CompilerGenerated]
		private bool? <ShopEnable>k__BackingField;

		// Token: 0x04002A2D RID: 10797
		[CompilerGenerated]
		private string <AscBarcode>k__BackingField;

		// Token: 0x04002A2E RID: 10798
		[CompilerGenerated]
		private string <Barcode>k__BackingField;

		// Token: 0x04002A2F RID: 10799
		[CompilerGenerated]
		private int <InCount>k__BackingField;

		// Token: 0x04002A30 RID: 10800
		[CompilerGenerated]
		private decimal <InSumm>k__BackingField;

		// Token: 0x04002A31 RID: 10801
		[CompilerGenerated]
		private string <Notes>k__BackingField;

		// Token: 0x04002A32 RID: 10802
		[CompilerGenerated]
		private int <MinimumInStock>k__BackingField;

		// Token: 0x04002A33 RID: 10803
		[CompilerGenerated]
		private int <Sold>k__BackingField;

		// Token: 0x04002A34 RID: 10804
		[CompilerGenerated]
		private int <ReturnPercent>k__BackingField;

		// Token: 0x04002A35 RID: 10805
		[CompilerGenerated]
		private int <Warranty>k__BackingField;

		// Token: 0x04002A36 RID: 10806
		[CompilerGenerated]
		private int <DealerWarranty>k__BackingField;

		// Token: 0x04002A37 RID: 10807
		[CompilerGenerated]
		private bool <NotForSale>k__BackingField;

		// Token: 0x04002A38 RID: 10808
		[CompilerGenerated]
		private bool <IsRealization>k__BackingField;

		// Token: 0x04002A39 RID: 10809
		[CompilerGenerated]
		private List<images> <Images>k__BackingField;

		// Token: 0x04002A3A RID: 10810
		[CompilerGenerated]
		private List<IAttribute> <Attributes>k__BackingField;

		// Token: 0x04002A3B RID: 10811
		[CompilerGenerated]
		private List<int> <ImageIds>k__BackingField;

		// Token: 0x04002A3C RID: 10812
		[CompilerGenerated]
		private string <BoxName>k__BackingField;

		// Token: 0x04002A3D RID: 10813
		[CompilerGenerated]
		private string <StateName>k__BackingField;

		// Token: 0x04002A3E RID: 10814
		[CompilerGenerated]
		private bool <Selected>k__BackingField;

		// Token: 0x02000874 RID: 2164
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060040A6 RID: 16550 RVA: 0x00100EE4 File Offset: 0x000FF0E4
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060040A7 RID: 16551 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x060040A8 RID: 16552 RVA: 0x0007FCB0 File Offset: 0x0007DEB0
			internal bool <GetImageIds>b__210_0(images i)
			{
				return i.id > 0;
			}

			// Token: 0x060040A9 RID: 16553 RVA: 0x0007FCC8 File Offset: 0x0007DEC8
			internal int <GetImageIds>b__210_1(images i)
			{
				return i.id;
			}

			// Token: 0x04002A3F RID: 10815
			public static readonly Product.<>c <>9 = new Product.<>c();

			// Token: 0x04002A40 RID: 10816
			public static Func<images, bool> <>9__210_0;

			// Token: 0x04002A41 RID: 10817
			public static Func<images, int> <>9__210_1;
		}
	}
}
