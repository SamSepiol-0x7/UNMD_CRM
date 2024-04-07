using System;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;
using ASC.SimpleClasses;
using DevExpress.Mvvm;

namespace ASC.Objects
{
	// Token: 0x020008E1 RID: 2273
	public class Material : BindableBase, IMaterial
	{
		// Token: 0x1700136D RID: 4973
		// (get) Token: 0x0600463A RID: 17978 RVA: 0x00112B24 File Offset: 0x00110D24
		// (set) Token: 0x0600463B RID: 17979 RVA: 0x00112B38 File Offset: 0x00110D38
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

		// Token: 0x1700136E RID: 4974
		// (get) Token: 0x0600463C RID: 17980 RVA: 0x00112B64 File Offset: 0x00110D64
		// (set) Token: 0x0600463D RID: 17981 RVA: 0x00112B78 File Offset: 0x00110D78
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
				if (!string.Equals(this.<Name>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = -1035828595;
				IL_14:
				switch ((num ^ -2047748816) % 4)
				{
				case 1:
					return;
				case 2:
					IL_33:
					this.<Name>k__BackingField = value;
					this.RaisePropertyChanged("Name");
					num = -1787855768;
					goto IL_14;
				case 3:
					goto IL_0F;
				}
			}
		}

		// Token: 0x1700136F RID: 4975
		// (get) Token: 0x0600463E RID: 17982 RVA: 0x00112BD4 File Offset: 0x00110DD4
		// (set) Token: 0x0600463F RID: 17983 RVA: 0x00112BE8 File Offset: 0x00110DE8
		public int? Articul
		{
			[CompilerGenerated]
			get
			{
				return this.<Articul>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<Articul>k__BackingField, value))
				{
					return;
				}
				this.<Articul>k__BackingField = value;
				this.RaisePropertyChanged("Articul");
			}
		}

		// Token: 0x17001370 RID: 4976
		// (get) Token: 0x06004640 RID: 17984 RVA: 0x00112C18 File Offset: 0x00110E18
		// (set) Token: 0x06004641 RID: 17985 RVA: 0x00112C2C File Offset: 0x00110E2C
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
				this.RaisePropertyChanged("Count");
			}
		}

		// Token: 0x17001371 RID: 4977
		// (get) Token: 0x06004642 RID: 17986 RVA: 0x00112C58 File Offset: 0x00110E58
		// (set) Token: 0x06004643 RID: 17987 RVA: 0x00112C6C File Offset: 0x00110E6C
		public int Type
		{
			[CompilerGenerated]
			get
			{
				return this.<Type>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Type>k__BackingField == value)
				{
					return;
				}
				this.<Type>k__BackingField = value;
				this.RaisePropertyChanged("Type");
			}
		}

		// Token: 0x17001372 RID: 4978
		// (get) Token: 0x06004644 RID: 17988 RVA: 0x00112C98 File Offset: 0x00110E98
		// (set) Token: 0x06004645 RID: 17989 RVA: 0x00112CAC File Offset: 0x00110EAC
		public decimal Price
		{
			get
			{
				return this._price;
			}
			set
			{
				if (decimal.Equals(this._price, value))
				{
					return;
				}
				this._price = value;
				this.RaisePropertyChanged("Total");
				this.RaisePropertyChanged("Price");
				base.RaisePropertyChanged<decimal>(() => this.Total);
			}
		}

		// Token: 0x17001373 RID: 4979
		// (get) Token: 0x06004646 RID: 17990 RVA: 0x00112D1C File Offset: 0x00110F1C
		// (set) Token: 0x06004647 RID: 17991 RVA: 0x00112D30 File Offset: 0x00110F30
		public decimal WorksPrice
		{
			get
			{
				return this._worksPrice;
			}
			set
			{
				if (decimal.Equals(this._worksPrice, value))
				{
					return;
				}
				this._worksPrice = value;
				this.RaisePropertyChanged("Total");
				this.RaisePropertyChanged("WorksPrice");
				base.RaisePropertyChanged<decimal>(() => this.Total);
			}
		}

		// Token: 0x17001374 RID: 4980
		// (get) Token: 0x06004648 RID: 17992 RVA: 0x00112DA0 File Offset: 0x00110FA0
		public decimal Total
		{
			get
			{
				return Fn.FormatSumm(this.Price + this.WorksPrice);
			}
		}

		// Token: 0x17001375 RID: 4981
		// (get) Token: 0x06004649 RID: 17993 RVA: 0x00112DC4 File Offset: 0x00110FC4
		// (set) Token: 0x0600464A RID: 17994 RVA: 0x00112DD8 File Offset: 0x00110FD8
		public int UseItemId
		{
			[CompilerGenerated]
			get
			{
				return this.<UseItemId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<UseItemId>k__BackingField == value)
				{
					return;
				}
				this.<UseItemId>k__BackingField = value;
				this.RaisePropertyChanged("UseItemId");
			}
		}

		// Token: 0x0600464B RID: 17995 RVA: 0x000069B8 File Offset: 0x00004BB8
		public Material()
		{
		}

		// Token: 0x04002D21 RID: 11553
		private decimal _price;

		// Token: 0x04002D22 RID: 11554
		private decimal _worksPrice;

		// Token: 0x04002D23 RID: 11555
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04002D24 RID: 11556
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04002D25 RID: 11557
		[CompilerGenerated]
		private int? <Articul>k__BackingField;

		// Token: 0x04002D26 RID: 11558
		[CompilerGenerated]
		private int <Count>k__BackingField;

		// Token: 0x04002D27 RID: 11559
		[CompilerGenerated]
		private int <Type>k__BackingField;

		// Token: 0x04002D28 RID: 11560
		[CompilerGenerated]
		private int <UseItemId>k__BackingField;

		// Token: 0x020008E2 RID: 2274
		public enum MaterialType
		{
			// Token: 0x04002D2A RID: 11562
			Toner,
			// Token: 0x04002D2B RID: 11563
			OPCDrum,
			// Token: 0x04002D2C RID: 11564
			Chip,
			// Token: 0x04002D2D RID: 11565
			CleaningBlade
		}
	}
}
