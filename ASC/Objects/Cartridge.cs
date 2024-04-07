using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using ASC.Common.Interfaces;
using ASC.SimpleClasses;

namespace ASC.Objects
{
	// Token: 0x020008B7 RID: 2231
	public class Cartridge : CartridgeCard
	{
		// Token: 0x170012A3 RID: 4771
		// (get) Token: 0x060043F3 RID: 17395 RVA: 0x0010B388 File Offset: 0x00109588
		// (set) Token: 0x060043F4 RID: 17396 RVA: 0x0010B39C File Offset: 0x0010959C
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

		// Token: 0x170012A4 RID: 4772
		// (get) Token: 0x060043F5 RID: 17397 RVA: 0x0010B3C8 File Offset: 0x001095C8
		// (set) Token: 0x060043F6 RID: 17398 RVA: 0x0010B3DC File Offset: 0x001095DC
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

		// Token: 0x170012A5 RID: 4773
		// (get) Token: 0x060043F7 RID: 17399 RVA: 0x0010B40C File Offset: 0x0010960C
		// (set) Token: 0x060043F8 RID: 17400 RVA: 0x0010B420 File Offset: 0x00109620
		public string SerialNumber
		{
			[CompilerGenerated]
			get
			{
				return this.<SerialNumber>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<SerialNumber>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<SerialNumber>k__BackingField = value;
				this.RaisePropertyChanged("SerialNumber");
			}
		}

		// Token: 0x170012A6 RID: 4774
		// (get) Token: 0x060043F9 RID: 17401 RVA: 0x0010B450 File Offset: 0x00109650
		// (set) Token: 0x060043FA RID: 17402 RVA: 0x0010B464 File Offset: 0x00109664
		public int Status
		{
			[CompilerGenerated]
			get
			{
				return this.<Status>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Status>k__BackingField == value)
				{
					return;
				}
				this.<Status>k__BackingField = value;
				this.RaisePropertyChanged("CanRefill");
				this.RaisePropertyChanged("CanChip");
				this.RaisePropertyChanged("CanOPCDrum");
				this.RaisePropertyChanged("CanCleaningBlade");
				this.RaisePropertyChanged("Status");
			}
		}

		// Token: 0x170012A7 RID: 4775
		// (get) Token: 0x060043FB RID: 17403 RVA: 0x0010B4BC File Offset: 0x001096BC
		// (set) Token: 0x060043FC RID: 17404 RVA: 0x0010B4D0 File Offset: 0x001096D0
		public int CustomerId
		{
			[CompilerGenerated]
			get
			{
				return this.<CustomerId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CustomerId>k__BackingField == value)
				{
					return;
				}
				this.<CustomerId>k__BackingField = value;
				this.RaisePropertyChanged("CustomerId");
			}
		}

		// Token: 0x170012A8 RID: 4776
		// (get) Token: 0x060043FD RID: 17405 RVA: 0x0010B4FC File Offset: 0x001096FC
		// (set) Token: 0x060043FE RID: 17406 RVA: 0x0010B510 File Offset: 0x00109710
		public int ManagerId
		{
			[CompilerGenerated]
			get
			{
				return this.<ManagerId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ManagerId>k__BackingField == value)
				{
					return;
				}
				this.<ManagerId>k__BackingField = value;
				this.RaisePropertyChanged("ManagerId");
			}
		}

		// Token: 0x170012A9 RID: 4777
		// (get) Token: 0x060043FF RID: 17407 RVA: 0x0010B53C File Offset: 0x0010973C
		// (set) Token: 0x06004400 RID: 17408 RVA: 0x0010B550 File Offset: 0x00109750
		public int CurrentManagerId
		{
			[CompilerGenerated]
			get
			{
				return this.<CurrentManagerId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CurrentManagerId>k__BackingField == value)
				{
					return;
				}
				this.<CurrentManagerId>k__BackingField = value;
				this.RaisePropertyChanged("CurrentManagerId");
			}
		}

		// Token: 0x170012AA RID: 4778
		// (get) Token: 0x06004401 RID: 17409 RVA: 0x0010B57C File Offset: 0x0010977C
		// (set) Token: 0x06004402 RID: 17410 RVA: 0x0010B590 File Offset: 0x00109790
		public int? MasterId
		{
			[CompilerGenerated]
			get
			{
				return this.<MasterId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<MasterId>k__BackingField, value))
				{
					return;
				}
				this.<MasterId>k__BackingField = value;
				this.RaisePropertyChanged("MasterId");
			}
		}

		// Token: 0x170012AB RID: 4779
		// (get) Token: 0x06004403 RID: 17411 RVA: 0x0010B5C0 File Offset: 0x001097C0
		// (set) Token: 0x06004404 RID: 17412 RVA: 0x0010B5D4 File Offset: 0x001097D4
		public DateTime InDate
		{
			[CompilerGenerated]
			get
			{
				return this.<InDate>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (DateTime.Equals(this.<InDate>k__BackingField, value))
				{
					return;
				}
				this.<InDate>k__BackingField = value;
				this.RaisePropertyChanged("InDate");
			}
		}

		// Token: 0x170012AC RID: 4780
		// (get) Token: 0x06004405 RID: 17413 RVA: 0x0010B604 File Offset: 0x00109804
		// (set) Token: 0x06004406 RID: 17414 RVA: 0x0010B618 File Offset: 0x00109818
		public DateTime? OutDate
		{
			[CompilerGenerated]
			get
			{
				return this.<OutDate>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<DateTime>(this.<OutDate>k__BackingField, value))
				{
					return;
				}
				this.<OutDate>k__BackingField = value;
				this.RaisePropertyChanged("OutDate");
			}
		}

		// Token: 0x170012AD RID: 4781
		// (get) Token: 0x06004407 RID: 17415 RVA: 0x0010B648 File Offset: 0x00109848
		// (set) Token: 0x06004408 RID: 17416 RVA: 0x0010B65C File Offset: 0x0010985C
		public int PaymentSystem
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentSystem>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PaymentSystem>k__BackingField == value)
				{
					return;
				}
				this.<PaymentSystem>k__BackingField = value;
				this.RaisePropertyChanged("PaymentSystem");
			}
		}

		// Token: 0x170012AE RID: 4782
		// (get) Token: 0x06004409 RID: 17417 RVA: 0x0010B688 File Offset: 0x00109888
		// (set) Token: 0x0600440A RID: 17418 RVA: 0x0010B69C File Offset: 0x0010989C
		public bool IsWarranty
		{
			[CompilerGenerated]
			get
			{
				return this.<IsWarranty>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IsWarranty>k__BackingField == value)
				{
					return;
				}
				this.<IsWarranty>k__BackingField = value;
				this.RaisePropertyChanged("IsWarranty");
			}
		}

		// Token: 0x170012AF RID: 4783
		// (get) Token: 0x0600440B RID: 17419 RVA: 0x0010B6C8 File Offset: 0x001098C8
		// (set) Token: 0x0600440C RID: 17420 RVA: 0x0010B6DC File Offset: 0x001098DC
		public bool IsRepeat
		{
			[CompilerGenerated]
			get
			{
				return this.<IsRepeat>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IsRepeat>k__BackingField == value)
				{
					return;
				}
				this.<IsRepeat>k__BackingField = value;
				this.RaisePropertyChanged("IsRepeat");
			}
		}

		// Token: 0x170012B0 RID: 4784
		// (get) Token: 0x0600440D RID: 17421 RVA: 0x0010B708 File Offset: 0x00109908
		// (set) Token: 0x0600440E RID: 17422 RVA: 0x0010B71C File Offset: 0x0010991C
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

		// Token: 0x170012B1 RID: 4785
		// (get) Token: 0x0600440F RID: 17423 RVA: 0x0010B74C File Offset: 0x0010994C
		// (set) Token: 0x06004410 RID: 17424 RVA: 0x0010B760 File Offset: 0x00109960
		public int CurrentOfficeId
		{
			[CompilerGenerated]
			get
			{
				return this.<CurrentOfficeId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CurrentOfficeId>k__BackingField == value)
				{
					return;
				}
				this.<CurrentOfficeId>k__BackingField = value;
				this.RaisePropertyChanged("CurrentOfficeId");
			}
		}

		// Token: 0x170012B2 RID: 4786
		// (get) Token: 0x06004411 RID: 17425 RVA: 0x0010B78C File Offset: 0x0010998C
		// (set) Token: 0x06004412 RID: 17426 RVA: 0x0010B7A0 File Offset: 0x001099A0
		public int CompanyId
		{
			[CompilerGenerated]
			get
			{
				return this.<CompanyId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CompanyId>k__BackingField == value)
				{
					return;
				}
				this.<CompanyId>k__BackingField = value;
				this.RaisePropertyChanged("CompanyId");
			}
		}

		// Token: 0x170012B3 RID: 4787
		// (get) Token: 0x06004413 RID: 17427 RVA: 0x0010B7CC File Offset: 0x001099CC
		// (set) Token: 0x06004414 RID: 17428 RVA: 0x0010B7E0 File Offset: 0x001099E0
		public int? SelectedHistoryOption
		{
			get
			{
				return this._selectedHistoryOption;
			}
			set
			{
				if (Nullable.Equals<int>(this._selectedHistoryOption, value))
				{
					return;
				}
				this._selectedHistoryOption = value;
				this.RaisePropertyChanged("SelectedHistoryOption");
				int? num = value;
				this.IsWarranty = (num.GetValueOrDefault() == 1 & num != null);
				num = value;
				this.IsRepeat = (num.GetValueOrDefault() == 2 & num != null);
			}
		}

		// Token: 0x170012B4 RID: 4788
		// (get) Token: 0x06004415 RID: 17429 RVA: 0x0010B844 File Offset: 0x00109A44
		// (set) Token: 0x06004416 RID: 17430 RVA: 0x0010B858 File Offset: 0x00109A58
		public bool Refill
		{
			get
			{
				return this._refill;
			}
			set
			{
				if (this._refill == value)
				{
					return;
				}
				this._refill = value;
				this.RaisePropertyChanged("GetFaults");
				this.RaisePropertyChanged("Refill");
				this.CalcTotalCost();
			}
		}

		// Token: 0x170012B5 RID: 4789
		// (get) Token: 0x06004417 RID: 17431 RVA: 0x0010B894 File Offset: 0x00109A94
		// (set) Token: 0x06004418 RID: 17432 RVA: 0x0010B8A8 File Offset: 0x00109AA8
		public bool OPCDrum
		{
			get
			{
				return this._opcDrum;
			}
			set
			{
				if (this._opcDrum == value)
				{
					return;
				}
				this._opcDrum = value;
				this.RaisePropertyChanged("GetFaults");
				this.RaisePropertyChanged("OPCDrum");
				this.CalcTotalCost();
			}
		}

		// Token: 0x170012B6 RID: 4790
		// (get) Token: 0x06004419 RID: 17433 RVA: 0x0010B8E4 File Offset: 0x00109AE4
		// (set) Token: 0x0600441A RID: 17434 RVA: 0x0010B8F8 File Offset: 0x00109AF8
		public bool Chip
		{
			get
			{
				return this._chip;
			}
			set
			{
				if (this._chip == value)
				{
					return;
				}
				this._chip = value;
				this.RaisePropertyChanged("GetFaults");
				this.RaisePropertyChanged("Chip");
				this.CalcTotalCost();
			}
		}

		// Token: 0x170012B7 RID: 4791
		// (get) Token: 0x0600441B RID: 17435 RVA: 0x0010B934 File Offset: 0x00109B34
		// (set) Token: 0x0600441C RID: 17436 RVA: 0x0010B948 File Offset: 0x00109B48
		public bool CleaningBlade
		{
			get
			{
				return this._cleaningBlade;
			}
			set
			{
				if (this._cleaningBlade == value)
				{
					return;
				}
				this._cleaningBlade = value;
				this.RaisePropertyChanged("GetFaults");
				this.RaisePropertyChanged("CleaningBlade");
				this.CalcTotalCost();
			}
		}

		// Token: 0x170012B8 RID: 4792
		// (get) Token: 0x0600441D RID: 17437 RVA: 0x0010B984 File Offset: 0x00109B84
		public bool CanRefill
		{
			get
			{
				return this.IsInWork() && this.CardHaveMaterial(Material.MaterialType.Toner);
			}
		}

		// Token: 0x170012B9 RID: 4793
		// (get) Token: 0x0600441E RID: 17438 RVA: 0x0010B9A4 File Offset: 0x00109BA4
		public bool CanChip
		{
			get
			{
				return this.IsInWork() && this.CardHaveMaterial(Material.MaterialType.Chip);
			}
		}

		// Token: 0x170012BA RID: 4794
		// (get) Token: 0x0600441F RID: 17439 RVA: 0x0010B9C4 File Offset: 0x00109BC4
		public bool CanOPCDrum
		{
			get
			{
				return this.IsInWork() && this.CardHaveMaterial(Material.MaterialType.OPCDrum);
			}
		}

		// Token: 0x170012BB RID: 4795
		// (get) Token: 0x06004420 RID: 17440 RVA: 0x0010B9E4 File Offset: 0x00109BE4
		public bool CanCleaningBlade
		{
			get
			{
				return this.IsInWork() && this.CardHaveMaterial(Material.MaterialType.CleaningBlade);
			}
		}

		// Token: 0x06004421 RID: 17441 RVA: 0x0010BA04 File Offset: 0x00109C04
		private bool IsInWork()
		{
			return this.Status == 4;
		}

		// Token: 0x06004422 RID: 17442 RVA: 0x0010BA1C File Offset: 0x00109C1C
		private bool CardHaveMaterial(Material.MaterialType material)
		{
			return base.Materials.Any((IMaterial m) => m.Type == (int)material);
		}

		// Token: 0x170012BC RID: 4796
		// (get) Token: 0x06004423 RID: 17443 RVA: 0x0010BA50 File Offset: 0x00109C50
		// (set) Token: 0x06004424 RID: 17444 RVA: 0x0010BA64 File Offset: 0x00109C64
		public decimal TotalCost
		{
			[CompilerGenerated]
			get
			{
				return this.<TotalCost>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<TotalCost>k__BackingField, value))
				{
					return;
				}
				this.<TotalCost>k__BackingField = value;
				this.RaisePropertyChanged("TotalCost");
			}
		}

		// Token: 0x170012BD RID: 4797
		// (get) Token: 0x06004425 RID: 17445 RVA: 0x0010BA94 File Offset: 0x00109C94
		// (set) Token: 0x06004426 RID: 17446 RVA: 0x0010BAA8 File Offset: 0x00109CA8
		public string CartridgeNotes
		{
			[CompilerGenerated]
			get
			{
				return this.<CartridgeNotes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<CartridgeNotes>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<CartridgeNotes>k__BackingField = value;
				this.RaisePropertyChanged("CartridgeNotes");
			}
		}

		// Token: 0x06004427 RID: 17447 RVA: 0x0010BAD8 File Offset: 0x00109CD8
		public Cartridge()
		{
		}

		// Token: 0x06004428 RID: 17448 RVA: 0x0010BAEC File Offset: 0x00109CEC
		public Cartridge(ICartridgeCard c) : base(c)
		{
		}

		// Token: 0x06004429 RID: 17449 RVA: 0x0007E558 File Offset: 0x0007C758
		public override Task<bool> Save()
		{
			throw new NotImplementedException();
		}

		// Token: 0x170012BE RID: 4798
		// (get) Token: 0x0600442A RID: 17450 RVA: 0x0010BB00 File Offset: 0x00109D00
		public string GetFaults
		{
			get
			{
				string text = "";
				if (this.Refill)
				{
					text += this.DefaultOrComma(text, (string)Application.Current.TryFindResource("Refill"));
				}
				if (this.Chip)
				{
					text += this.DefaultOrComma(text, (string)Application.Current.TryFindResource("Chip"));
				}
				if (this.OPCDrum)
				{
					text += this.DefaultOrComma(text, (string)Application.Current.TryFindResource("OPCDrum"));
				}
				if (this.CleaningBlade)
				{
					text += this.DefaultOrComma(text, (string)Application.Current.TryFindResource("CleaningBlade"));
				}
				return text;
			}
		}

		// Token: 0x0600442B RID: 17451 RVA: 0x0010BBBC File Offset: 0x00109DBC
		private string DefaultOrComma(string result, string fault)
		{
			if (!string.IsNullOrEmpty(result))
			{
				return ", " + fault;
			}
			return fault;
		}

		// Token: 0x0600442C RID: 17452 RVA: 0x0010BBE0 File Offset: 0x00109DE0
		private void CalcTotalCost()
		{
			decimal num = 0m;
			if (this.Refill)
			{
				IMaterial material = base.Materials.FirstOrDefault((IMaterial m) => m.Type == 0);
				if (material != null)
				{
					num += material.Total;
				}
			}
			if (this.Chip)
			{
				IMaterial material2 = base.Materials.FirstOrDefault((IMaterial m) => m.Type == 2);
				if (material2 != null)
				{
					num += material2.Total;
				}
			}
			if (this.OPCDrum)
			{
				IMaterial material3 = base.Materials.FirstOrDefault((IMaterial m) => m.Type == 1);
				if (material3 != null)
				{
					num += material3.Total;
				}
			}
			if (this.CleaningBlade)
			{
				IMaterial material4 = base.Materials.FirstOrDefault((IMaterial m) => m.Type == 3);
				if (material4 != null)
				{
					num += material4.Total;
				}
			}
			this.TotalCost = Fn.FormatSumm(num);
			base.RaisePropertyChanged<decimal>(() => this.TotalCost);
		}

		// Token: 0x04002BF0 RID: 11248
		private bool _refill;

		// Token: 0x04002BF1 RID: 11249
		private bool _opcDrum;

		// Token: 0x04002BF2 RID: 11250
		private bool _chip;

		// Token: 0x04002BF3 RID: 11251
		private bool _cleaningBlade;

		// Token: 0x04002BF4 RID: 11252
		private int? _selectedHistoryOption;

		// Token: 0x04002BF5 RID: 11253
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04002BF6 RID: 11254
		[CompilerGenerated]
		private string <Barcode>k__BackingField;

		// Token: 0x04002BF7 RID: 11255
		[CompilerGenerated]
		private string <SerialNumber>k__BackingField;

		// Token: 0x04002BF8 RID: 11256
		[CompilerGenerated]
		private int <Status>k__BackingField;

		// Token: 0x04002BF9 RID: 11257
		[CompilerGenerated]
		private int <CustomerId>k__BackingField;

		// Token: 0x04002BFA RID: 11258
		[CompilerGenerated]
		private int <ManagerId>k__BackingField;

		// Token: 0x04002BFB RID: 11259
		[CompilerGenerated]
		private int <CurrentManagerId>k__BackingField;

		// Token: 0x04002BFC RID: 11260
		[CompilerGenerated]
		private int? <MasterId>k__BackingField;

		// Token: 0x04002BFD RID: 11261
		[CompilerGenerated]
		private DateTime <InDate>k__BackingField;

		// Token: 0x04002BFE RID: 11262
		[CompilerGenerated]
		private DateTime? <OutDate>k__BackingField;

		// Token: 0x04002BFF RID: 11263
		[CompilerGenerated]
		private int <PaymentSystem>k__BackingField;

		// Token: 0x04002C00 RID: 11264
		[CompilerGenerated]
		private bool <IsWarranty>k__BackingField;

		// Token: 0x04002C01 RID: 11265
		[CompilerGenerated]
		private bool <IsRepeat>k__BackingField;

		// Token: 0x04002C02 RID: 11266
		[CompilerGenerated]
		private int? <BoxId>k__BackingField;

		// Token: 0x04002C03 RID: 11267
		[CompilerGenerated]
		private int <CurrentOfficeId>k__BackingField;

		// Token: 0x04002C04 RID: 11268
		[CompilerGenerated]
		private int <CompanyId>k__BackingField;

		// Token: 0x04002C05 RID: 11269
		[CompilerGenerated]
		private decimal <TotalCost>k__BackingField;

		// Token: 0x04002C06 RID: 11270
		[CompilerGenerated]
		private string <CartridgeNotes>k__BackingField;

		// Token: 0x020008B8 RID: 2232
		public enum HistoryOptions
		{
			// Token: 0x04002C08 RID: 11272
			Warranty = 1,
			// Token: 0x04002C09 RID: 11273
			Repeat
		}

		// Token: 0x020008B9 RID: 2233
		[CompilerGenerated]
		private sealed class <>c__DisplayClass93_0
		{
			// Token: 0x0600442D RID: 17453 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass93_0()
			{
			}

			// Token: 0x0600442E RID: 17454 RVA: 0x0010BD48 File Offset: 0x00109F48
			internal bool <CardHaveMaterial>b__0(IMaterial m)
			{
				return m.Type == (int)this.material;
			}

			// Token: 0x04002C0A RID: 11274
			public Material.MaterialType material;
		}

		// Token: 0x020008BA RID: 2234
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600442F RID: 17455 RVA: 0x0010BD64 File Offset: 0x00109F64
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004430 RID: 17456 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06004431 RID: 17457 RVA: 0x0010BD7C File Offset: 0x00109F7C
			internal bool <CalcTotalCost>b__108_1(IMaterial m)
			{
				return m.Type == 0;
			}

			// Token: 0x06004432 RID: 17458 RVA: 0x0010BD94 File Offset: 0x00109F94
			internal bool <CalcTotalCost>b__108_2(IMaterial m)
			{
				return m.Type == 2;
			}

			// Token: 0x06004433 RID: 17459 RVA: 0x0010BDAC File Offset: 0x00109FAC
			internal bool <CalcTotalCost>b__108_3(IMaterial m)
			{
				return m.Type == 1;
			}

			// Token: 0x06004434 RID: 17460 RVA: 0x0010BDC4 File Offset: 0x00109FC4
			internal bool <CalcTotalCost>b__108_4(IMaterial m)
			{
				return m.Type == 3;
			}

			// Token: 0x04002C0B RID: 11275
			public static readonly Cartridge.<>c <>9 = new Cartridge.<>c();

			// Token: 0x04002C0C RID: 11276
			public static Func<IMaterial, bool> <>9__108_1;

			// Token: 0x04002C0D RID: 11277
			public static Func<IMaterial, bool> <>9__108_2;

			// Token: 0x04002C0E RID: 11278
			public static Func<IMaterial, bool> <>9__108_3;

			// Token: 0x04002C0F RID: 11279
			public static Func<IMaterial, bool> <>9__108_4;
		}
	}
}
