using System;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;
using DevExpress.Mvvm;

namespace ASC.Objects
{
	// Token: 0x020008E0 RID: 2272
	public class InvoiceItem : BindableBase, IInvoiceItem
	{
		// Token: 0x1700135E RID: 4958
		// (get) Token: 0x06004619 RID: 17945 RVA: 0x0011243C File Offset: 0x0011063C
		// (set) Token: 0x0600461A RID: 17946 RVA: 0x00112450 File Offset: 0x00110650
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
				this.RaisePropertyChanged("Id");
			}
		}

		// Token: 0x1700135F RID: 4959
		// (get) Token: 0x0600461B RID: 17947 RVA: 0x0011247C File Offset: 0x0011067C
		// (set) Token: 0x0600461C RID: 17948 RVA: 0x00112490 File Offset: 0x00110690
		public int InvoiceId
		{
			[CompilerGenerated]
			get
			{
				return this.<InvoiceId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<InvoiceId>k__BackingField == value)
				{
					return;
				}
				this.<InvoiceId>k__BackingField = value;
				this.RaisePropertyChanged("InvoiceId");
			}
		}

		// Token: 0x17001360 RID: 4960
		// (get) Token: 0x0600461D RID: 17949 RVA: 0x001124BC File Offset: 0x001106BC
		// (set) Token: 0x0600461E RID: 17950 RVA: 0x001124D0 File Offset: 0x001106D0
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
				this.RaisePropertyChanged("Name");
			}
		}

		// Token: 0x17001361 RID: 4961
		// (get) Token: 0x0600461F RID: 17951 RVA: 0x00112500 File Offset: 0x00110700
		// (set) Token: 0x06004620 RID: 17952 RVA: 0x00112514 File Offset: 0x00110714
		public double Count
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
				this.RaisePropertyChanged("Count");
			}
		}

		// Token: 0x17001362 RID: 4962
		// (get) Token: 0x06004621 RID: 17953 RVA: 0x00112544 File Offset: 0x00110744
		// (set) Token: 0x06004622 RID: 17954 RVA: 0x00112558 File Offset: 0x00110758
		public string Units
		{
			[CompilerGenerated]
			get
			{
				return this.<Units>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Units>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Units>k__BackingField = value;
				this.RaisePropertyChanged("Units");
			}
		}

		// Token: 0x17001363 RID: 4963
		// (get) Token: 0x06004623 RID: 17955 RVA: 0x00112588 File Offset: 0x00110788
		// (set) Token: 0x06004624 RID: 17956 RVA: 0x0011259C File Offset: 0x0011079C
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
				this.RaisePropertyChanged("Price");
			}
		}

		// Token: 0x17001364 RID: 4964
		// (get) Token: 0x06004625 RID: 17957 RVA: 0x001125CC File Offset: 0x001107CC
		// (set) Token: 0x06004626 RID: 17958 RVA: 0x001125E0 File Offset: 0x001107E0
		public double? Tax
		{
			[CompilerGenerated]
			get
			{
				return this.<Tax>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!Nullable.Equals<double>(this.<Tax>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -977667660;
				IL_13:
				switch ((num ^ -1026519017) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					IL_32:
					this.<Tax>k__BackingField = value;
					this.RaisePropertyChanged("Tax");
					num = -663453359;
					goto IL_13;
				case 3:
					return;
				}
			}
		}

		// Token: 0x17001365 RID: 4965
		// (get) Token: 0x06004627 RID: 17959 RVA: 0x0011263C File Offset: 0x0011083C
		// (set) Token: 0x06004628 RID: 17960 RVA: 0x00112650 File Offset: 0x00110850
		public decimal TaxSumm
		{
			[CompilerGenerated]
			get
			{
				return this.<TaxSumm>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<TaxSumm>k__BackingField, value))
				{
					return;
				}
				this.<TaxSumm>k__BackingField = value;
				this.RaisePropertyChanged("TaxSumm");
			}
		}

		// Token: 0x17001366 RID: 4966
		// (get) Token: 0x06004629 RID: 17961 RVA: 0x00112680 File Offset: 0x00110880
		// (set) Token: 0x0600462A RID: 17962 RVA: 0x00112694 File Offset: 0x00110894
		public decimal PriceWithoutTax
		{
			[CompilerGenerated]
			get
			{
				return this.<PriceWithoutTax>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<PriceWithoutTax>k__BackingField, value))
				{
					return;
				}
				this.<PriceWithoutTax>k__BackingField = value;
				this.RaisePropertyChanged("PriceWithoutTax");
			}
		}

		// Token: 0x17001367 RID: 4967
		// (get) Token: 0x0600462B RID: 17963 RVA: 0x001126C4 File Offset: 0x001108C4
		// (set) Token: 0x0600462C RID: 17964 RVA: 0x001126D8 File Offset: 0x001108D8
		public int TaxMode
		{
			[CompilerGenerated]
			get
			{
				return this.<TaxMode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<TaxMode>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = 1389967079;
				IL_10:
				switch ((num ^ 330428762) % 4)
				{
				case 0:
					goto IL_0B;
				case 1:
					return;
				case 3:
					IL_2F:
					num = 1357947948;
					goto IL_10;
				}
				this.<TaxMode>k__BackingField = value;
				this.RaisePropertyChanged("TaxMode");
			}
		}

		// Token: 0x17001368 RID: 4968
		// (get) Token: 0x0600462D RID: 17965 RVA: 0x00112730 File Offset: 0x00110930
		// (set) Token: 0x0600462E RID: 17966 RVA: 0x00112744 File Offset: 0x00110944
		public int? RepairId
		{
			[CompilerGenerated]
			get
			{
				return this.<RepairId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!Nullable.Equals<int>(this.<RepairId>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -48987639;
				IL_13:
				switch ((num ^ -664021128) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					return;
				case 2:
					IL_32:
					this.<RepairId>k__BackingField = value;
					num = -1337544029;
					goto IL_13;
				}
				this.RaisePropertyChanged("RepairId");
			}
		}

		// Token: 0x17001369 RID: 4969
		// (get) Token: 0x0600462F RID: 17967 RVA: 0x001127A0 File Offset: 0x001109A0
		// (set) Token: 0x06004630 RID: 17968 RVA: 0x001127B4 File Offset: 0x001109B4
		public IRepair Repair
		{
			[CompilerGenerated]
			get
			{
				return this.<Repair>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Repair>k__BackingField, value))
				{
					return;
				}
				this.<Repair>k__BackingField = value;
				this.RaisePropertyChanged("Repair");
			}
		}

		// Token: 0x1700136A RID: 4970
		// (get) Token: 0x06004631 RID: 17969 RVA: 0x001127E4 File Offset: 0x001109E4
		// (set) Token: 0x06004632 RID: 17970 RVA: 0x001127F8 File Offset: 0x001109F8
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

		// Token: 0x1700136B RID: 4971
		// (get) Token: 0x06004633 RID: 17971 RVA: 0x00112828 File Offset: 0x00110A28
		// (set) Token: 0x06004634 RID: 17972 RVA: 0x0011283C File Offset: 0x00110A3C
		public decimal Total
		{
			[CompilerGenerated]
			get
			{
				return this.<Total>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<Total>k__BackingField, value))
				{
					return;
				}
				this.<Total>k__BackingField = value;
				this.RaisePropertyChanged("Total");
			}
		}

		// Token: 0x1700136C RID: 4972
		// (get) Token: 0x06004635 RID: 17973 RVA: 0x0011286C File Offset: 0x00110A6C
		// (set) Token: 0x06004636 RID: 17974 RVA: 0x00112880 File Offset: 0x00110A80
		public decimal SummWithoutTax
		{
			[CompilerGenerated]
			get
			{
				return this.<SummWithoutTax>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<SummWithoutTax>k__BackingField, value))
				{
					return;
				}
				this.<SummWithoutTax>k__BackingField = value;
				this.RaisePropertyChanged("SummWithoutTax");
			}
		}

		// Token: 0x06004637 RID: 17975 RVA: 0x001128B0 File Offset: 0x00110AB0
		public InvoiceItem()
		{
			this.Count = 1.0;
		}

		// Token: 0x06004638 RID: 17976 RVA: 0x001128D4 File Offset: 0x00110AD4
		public InvoiceItem(int id, string name, decimal price, double count, string units, double? tax, int taxMode, decimal total, int invoiceId, int? repairId, int? documentId, IRepair repair)
		{
			this.Id = id;
			this.Name = name;
			this.Count = count;
			this.Units = units;
			this.Price = price;
			this.TaxMode = taxMode;
			this.Tax = tax;
			this.Total = total;
			this.InvoiceId = invoiceId;
			this.RepairId = repairId;
			this.DocumentId = documentId;
			this.Repair = repair;
			this.Calculate();
		}

		// Token: 0x06004639 RID: 17977 RVA: 0x0011294C File Offset: 0x00110B4C
		public void Calculate()
		{
			if (this.TaxMode == 0)
			{
				goto IL_80;
			}
			double valueOrDefault;
			for (;;)
			{
				IL_8F:
				valueOrDefault = this.Tax.GetValueOrDefault();
				for (;;)
				{
					IL_77:
					int taxMode = this.TaxMode;
					for (;;)
					{
						switch (taxMode)
						{
						case 0:
							goto IL_A1;
						case 1:
							goto IL_E1;
						case 2:
							goto IL_144;
						default:
						{
							uint num;
							switch ((num = (num * 144735769U ^ 3742378515U ^ 596499515U)) % 13U)
							{
							case 0U:
								goto IL_8F;
							case 1U:
								goto IL_77;
							case 2U:
								return;
							case 4U:
								goto IL_1AD;
							case 5U:
								goto IL_144;
							case 6U:
								continue;
							case 7U:
							case 9U:
								goto IL_80;
							case 8U:
								goto IL_E1;
							case 10U:
								goto IL_A1;
							case 11U:
								return;
							case 12U:
								goto IL_AD;
							}
							goto Block_2;
						}
						}
					}
				}
			}
			Block_2:
			return;
			IL_A1:
			this.PriceWithoutTax = this.Price;
			IL_AD:
			this.SummWithoutTax = this.Price * (decimal)this.Count;
			this.TaxSumm = 0m;
			this.Total = this.SummWithoutTax;
			return;
			IL_E1:
			this.PriceWithoutTax = this.Price;
			this.SummWithoutTax = this.Price * (decimal)this.Count;
			this.TaxSumm = this.SummWithoutTax / 100m * (decimal)valueOrDefault;
			this.Total = this.SummWithoutTax + this.TaxSumm;
			return;
			IL_144:
			this.Total = this.Price * (decimal)this.Count;
			this.TaxSumm = this.Total - this.Total / (decimal)(1.0 + valueOrDefault / 100.0);
			this.SummWithoutTax = this.Total - this.TaxSumm;
			IL_1AD:
			this.PriceWithoutTax = this.SummWithoutTax / (decimal)this.Count;
			return;
			IL_80:
			this.Tax = null;
			goto IL_8F;
		}

		// Token: 0x04002D12 RID: 11538
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04002D13 RID: 11539
		[CompilerGenerated]
		private int <InvoiceId>k__BackingField;

		// Token: 0x04002D14 RID: 11540
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04002D15 RID: 11541
		[CompilerGenerated]
		private double <Count>k__BackingField;

		// Token: 0x04002D16 RID: 11542
		[CompilerGenerated]
		private string <Units>k__BackingField;

		// Token: 0x04002D17 RID: 11543
		[CompilerGenerated]
		private decimal <Price>k__BackingField;

		// Token: 0x04002D18 RID: 11544
		[CompilerGenerated]
		private double? <Tax>k__BackingField;

		// Token: 0x04002D19 RID: 11545
		[CompilerGenerated]
		private decimal <TaxSumm>k__BackingField;

		// Token: 0x04002D1A RID: 11546
		[CompilerGenerated]
		private decimal <PriceWithoutTax>k__BackingField;

		// Token: 0x04002D1B RID: 11547
		[CompilerGenerated]
		private int <TaxMode>k__BackingField;

		// Token: 0x04002D1C RID: 11548
		[CompilerGenerated]
		private int? <RepairId>k__BackingField;

		// Token: 0x04002D1D RID: 11549
		[CompilerGenerated]
		private IRepair <Repair>k__BackingField;

		// Token: 0x04002D1E RID: 11550
		[CompilerGenerated]
		private int? <DocumentId>k__BackingField;

		// Token: 0x04002D1F RID: 11551
		[CompilerGenerated]
		private decimal <Total>k__BackingField;

		// Token: 0x04002D20 RID: 11552
		[CompilerGenerated]
		private decimal <SummWithoutTax>k__BackingField;
	}
}
