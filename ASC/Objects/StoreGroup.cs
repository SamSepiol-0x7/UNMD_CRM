using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using ASC.Models;

namespace ASC.Objects
{
	// Token: 0x02000892 RID: 2194
	public class StoreGroup
	{
		// Token: 0x1700122F RID: 4655
		// (get) Token: 0x0600428A RID: 17034 RVA: 0x0010531C File Offset: 0x0010351C
		// (set) Token: 0x0600428B RID: 17035 RVA: 0x00105330 File Offset: 0x00103530
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
				this.<Articul>k__BackingField = value;
			}
		}

		// Token: 0x17001230 RID: 4656
		// (get) Token: 0x0600428C RID: 17036 RVA: 0x00105344 File Offset: 0x00103544
		public string ArticulFormatted
		{
			get
			{
				return this.Articul.ToString("D6");
			}
		}

		// Token: 0x17001231 RID: 4657
		// (get) Token: 0x0600428D RID: 17037 RVA: 0x00105364 File Offset: 0x00103564
		// (set) Token: 0x0600428E RID: 17038 RVA: 0x00105378 File Offset: 0x00103578
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
				this.<Id>k__BackingField = value;
			}
		}

		// Token: 0x17001232 RID: 4658
		// (get) Token: 0x0600428F RID: 17039 RVA: 0x0010538C File Offset: 0x0010358C
		// (set) Token: 0x06004290 RID: 17040 RVA: 0x001053A0 File Offset: 0x001035A0
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
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x17001233 RID: 4659
		// (get) Token: 0x06004291 RID: 17041 RVA: 0x001053B4 File Offset: 0x001035B4
		// (set) Token: 0x06004292 RID: 17042 RVA: 0x001053C8 File Offset: 0x001035C8
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
				this.<Count>k__BackingField = value;
			}
		}

		// Token: 0x17001234 RID: 4660
		// (get) Token: 0x06004293 RID: 17043 RVA: 0x001053DC File Offset: 0x001035DC
		// (set) Token: 0x06004294 RID: 17044 RVA: 0x001053F0 File Offset: 0x001035F0
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
				this.<Reserved>k__BackingField = value;
			}
		}

		// Token: 0x17001235 RID: 4661
		// (get) Token: 0x06004295 RID: 17045 RVA: 0x00105404 File Offset: 0x00103604
		// (set) Token: 0x06004296 RID: 17046 RVA: 0x00105418 File Offset: 0x00103618
		public int Category
		{
			[CompilerGenerated]
			get
			{
				return this.<Category>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Category>k__BackingField = value;
			}
		}

		// Token: 0x17001236 RID: 4662
		// (get) Token: 0x06004297 RID: 17047 RVA: 0x0010542C File Offset: 0x0010362C
		// (set) Token: 0x06004298 RID: 17048 RVA: 0x00105440 File Offset: 0x00103640
		public decimal PriceMin
		{
			[CompilerGenerated]
			get
			{
				return this.<PriceMin>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<PriceMin>k__BackingField = value;
			}
		}

		// Token: 0x17001237 RID: 4663
		// (get) Token: 0x06004299 RID: 17049 RVA: 0x00105454 File Offset: 0x00103654
		// (set) Token: 0x0600429A RID: 17050 RVA: 0x00105468 File Offset: 0x00103668
		public decimal PriceMax
		{
			[CompilerGenerated]
			get
			{
				return this.<PriceMax>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<PriceMax>k__BackingField = value;
			}
		}

		// Token: 0x17001238 RID: 4664
		// (get) Token: 0x0600429B RID: 17051 RVA: 0x0010547C File Offset: 0x0010367C
		// (set) Token: 0x0600429C RID: 17052 RVA: 0x00105490 File Offset: 0x00103690
		public int Avaliable
		{
			[CompilerGenerated]
			get
			{
				return this.<Avaliable>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Avaliable>k__BackingField = value;
			}
		}

		// Token: 0x17001239 RID: 4665
		// (get) Token: 0x0600429D RID: 17053 RVA: 0x001054A4 File Offset: 0x001036A4
		// (set) Token: 0x0600429E RID: 17054 RVA: 0x001054B8 File Offset: 0x001036B8
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
				this.<State>k__BackingField = value;
			}
		}

		// Token: 0x1700123A RID: 4666
		// (get) Token: 0x0600429F RID: 17055 RVA: 0x001054CC File Offset: 0x001036CC
		// (set) Token: 0x060042A0 RID: 17056 RVA: 0x001054E0 File Offset: 0x001036E0
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
				this.<StateName>k__BackingField = value;
			}
		}

		// Token: 0x1700123B RID: 4667
		// (get) Token: 0x060042A1 RID: 17057 RVA: 0x001054F4 File Offset: 0x001036F4
		// (set) Token: 0x060042A2 RID: 17058 RVA: 0x00105568 File Offset: 0x00103768
		public ObservableCollection<Product> Details
		{
			get
			{
				if (this._details == null)
				{
					this._details = new ObservableCollection<Product>(StoreModel.LoadDetailItemsV2(this.DetailIds));
					return this._details;
				}
				Product product = this._details.FirstOrDefault<Product>();
				if (product != null)
				{
					if (this.Articul != product.Articul)
					{
						this._details = new ObservableCollection<Product>(StoreModel.LoadDetailItemsV2(this.DetailIds));
						return this._details;
					}
				}
				return this._details;
			}
			set
			{
				this._details = value;
			}
		}

		// Token: 0x060042A3 RID: 17059 RVA: 0x000046B4 File Offset: 0x000028B4
		public StoreGroup()
		{
		}

		// Token: 0x04002B0B RID: 11019
		[CompilerGenerated]
		private int <Articul>k__BackingField;

		// Token: 0x04002B0C RID: 11020
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04002B0D RID: 11021
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04002B0E RID: 11022
		[CompilerGenerated]
		private int <Count>k__BackingField;

		// Token: 0x04002B0F RID: 11023
		[CompilerGenerated]
		private int <Reserved>k__BackingField;

		// Token: 0x04002B10 RID: 11024
		[CompilerGenerated]
		private int <Category>k__BackingField;

		// Token: 0x04002B11 RID: 11025
		[CompilerGenerated]
		private decimal <PriceMin>k__BackingField;

		// Token: 0x04002B12 RID: 11026
		[CompilerGenerated]
		private decimal <PriceMax>k__BackingField;

		// Token: 0x04002B13 RID: 11027
		[CompilerGenerated]
		private int <Avaliable>k__BackingField;

		// Token: 0x04002B14 RID: 11028
		[CompilerGenerated]
		private int <State>k__BackingField;

		// Token: 0x04002B15 RID: 11029
		[CompilerGenerated]
		private string <StateName>k__BackingField;

		// Token: 0x04002B16 RID: 11030
		public List<int> Stores;

		// Token: 0x04002B17 RID: 11031
		public List<int> DetailIds;

		// Token: 0x04002B18 RID: 11032
		private ObservableCollection<Product> _details;
	}
}
