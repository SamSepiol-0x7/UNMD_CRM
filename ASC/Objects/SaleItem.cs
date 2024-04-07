using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;
using ASC.Common.Objects;

namespace ASC.Objects
{
	// Token: 0x0200088C RID: 2188
	public class SaleItem : IIdName, ISaleItem
	{
		// Token: 0x170011F0 RID: 4592
		// (get) Token: 0x060041FF RID: 16895 RVA: 0x0010409C File Offset: 0x0010229C
		// (set) Token: 0x06004200 RID: 16896 RVA: 0x001040B0 File Offset: 0x001022B0
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

		// Token: 0x170011F1 RID: 4593
		// (get) Token: 0x06004201 RID: 16897 RVA: 0x001040C4 File Offset: 0x001022C4
		// (set) Token: 0x06004202 RID: 16898 RVA: 0x001040D8 File Offset: 0x001022D8
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

		// Token: 0x170011F2 RID: 4594
		// (get) Token: 0x06004203 RID: 16899 RVA: 0x001040EC File Offset: 0x001022EC
		// (set) Token: 0x06004204 RID: 16900 RVA: 0x00104100 File Offset: 0x00102300
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

		// Token: 0x170011F3 RID: 4595
		// (get) Token: 0x06004205 RID: 16901 RVA: 0x00104114 File Offset: 0x00102314
		// (set) Token: 0x06004206 RID: 16902 RVA: 0x00104128 File Offset: 0x00102328
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

		// Token: 0x170011F4 RID: 4596
		// (get) Token: 0x06004207 RID: 16903 RVA: 0x0010413C File Offset: 0x0010233C
		// (set) Token: 0x06004208 RID: 16904 RVA: 0x00104150 File Offset: 0x00102350
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
				this.<Price>k__BackingField = value;
			}
		}

		// Token: 0x170011F5 RID: 4597
		// (get) Token: 0x06004209 RID: 16905 RVA: 0x00104164 File Offset: 0x00102364
		// (set) Token: 0x0600420A RID: 16906 RVA: 0x00104178 File Offset: 0x00102378
		public decimal PriceOpt
		{
			[CompilerGenerated]
			get
			{
				return this.<PriceOpt>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<PriceOpt>k__BackingField = value;
			}
		}

		// Token: 0x170011F6 RID: 4598
		// (get) Token: 0x0600420B RID: 16907 RVA: 0x0010418C File Offset: 0x0010238C
		// (set) Token: 0x0600420C RID: 16908 RVA: 0x001041A0 File Offset: 0x001023A0
		public decimal PriceOpt2
		{
			[CompilerGenerated]
			get
			{
				return this.<PriceOpt2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<PriceOpt2>k__BackingField = value;
			}
		}

		// Token: 0x170011F7 RID: 4599
		// (get) Token: 0x0600420D RID: 16909 RVA: 0x001041B4 File Offset: 0x001023B4
		// (set) Token: 0x0600420E RID: 16910 RVA: 0x001041C8 File Offset: 0x001023C8
		public decimal PriceSC
		{
			[CompilerGenerated]
			get
			{
				return this.<PriceSC>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<PriceSC>k__BackingField = value;
			}
		}

		// Token: 0x170011F8 RID: 4600
		// (get) Token: 0x0600420F RID: 16911 RVA: 0x001041DC File Offset: 0x001023DC
		// (set) Token: 0x06004210 RID: 16912 RVA: 0x001041F0 File Offset: 0x001023F0
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
				this.<InPrice>k__BackingField = value;
			}
		}

		// Token: 0x170011F9 RID: 4601
		// (get) Token: 0x06004211 RID: 16913 RVA: 0x00104204 File Offset: 0x00102404
		// (set) Token: 0x06004212 RID: 16914 RVA: 0x00104218 File Offset: 0x00102418
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
				this.<Sn>k__BackingField = value;
			}
		}

		// Token: 0x170011FA RID: 4602
		// (get) Token: 0x06004213 RID: 16915 RVA: 0x0010422C File Offset: 0x0010242C
		// (set) Token: 0x06004214 RID: 16916 RVA: 0x00104240 File Offset: 0x00102440
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
				this.<Warranty>k__BackingField = value;
			}
		}

		// Token: 0x170011FB RID: 4603
		// (get) Token: 0x06004215 RID: 16917 RVA: 0x00104254 File Offset: 0x00102454
		// (set) Token: 0x06004216 RID: 16918 RVA: 0x00104268 File Offset: 0x00102468
		public string WarrantyStr
		{
			[CompilerGenerated]
			get
			{
				return this.<WarrantyStr>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<WarrantyStr>k__BackingField = value;
			}
		}

		// Token: 0x170011FC RID: 4604
		// (get) Token: 0x06004217 RID: 16919 RVA: 0x0010427C File Offset: 0x0010247C
		// (set) Token: 0x06004218 RID: 16920 RVA: 0x00104290 File Offset: 0x00102490
		public int StateId
		{
			[CompilerGenerated]
			get
			{
				return this.<StateId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<StateId>k__BackingField = value;
			}
		}

		// Token: 0x170011FD RID: 4605
		// (get) Token: 0x06004219 RID: 16921 RVA: 0x001042A4 File Offset: 0x001024A4
		// (set) Token: 0x0600421A RID: 16922 RVA: 0x001042B8 File Offset: 0x001024B8
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

		// Token: 0x170011FE RID: 4606
		// (get) Token: 0x0600421B RID: 16923 RVA: 0x001042CC File Offset: 0x001024CC
		// (set) Token: 0x0600421C RID: 16924 RVA: 0x001042E0 File Offset: 0x001024E0
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
				this.<Notes>k__BackingField = value;
			}
		}

		// Token: 0x170011FF RID: 4607
		// (get) Token: 0x0600421D RID: 16925 RVA: 0x001042F4 File Offset: 0x001024F4
		// (set) Token: 0x0600421E RID: 16926 RVA: 0x00104308 File Offset: 0x00102508
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
				this.<BoxName>k__BackingField = value;
			}
		}

		// Token: 0x17001200 RID: 4608
		// (get) Token: 0x0600421F RID: 16927 RVA: 0x0010431C File Offset: 0x0010251C
		public string UID
		{
			get
			{
				return string.Format("{0:D6}-{1:D6}", this.Articul, this.Id);
			}
		}

		// Token: 0x17001201 RID: 4609
		// (get) Token: 0x06004220 RID: 16928 RVA: 0x0010434C File Offset: 0x0010254C
		// (set) Token: 0x06004221 RID: 16929 RVA: 0x00104360 File Offset: 0x00102560
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
				this.<AscBarcode>k__BackingField = value;
			}
		}

		// Token: 0x17001202 RID: 4610
		// (get) Token: 0x06004222 RID: 16930 RVA: 0x00104374 File Offset: 0x00102574
		// (set) Token: 0x06004223 RID: 16931 RVA: 0x00104388 File Offset: 0x00102588
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
				this.<Description>k__BackingField = value;
			}
		}

		// Token: 0x17001203 RID: 4611
		// (get) Token: 0x06004224 RID: 16932 RVA: 0x0010439C File Offset: 0x0010259C
		// (set) Token: 0x06004225 RID: 16933 RVA: 0x001043B0 File Offset: 0x001025B0
		public string Partnumber
		{
			[CompilerGenerated]
			get
			{
				return this.<Partnumber>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Partnumber>k__BackingField = value;
			}
		}

		// Token: 0x17001204 RID: 4612
		// (get) Token: 0x06004226 RID: 16934 RVA: 0x001043C4 File Offset: 0x001025C4
		// (set) Token: 0x06004227 RID: 16935 RVA: 0x001043D8 File Offset: 0x001025D8
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
				this.<Units>k__BackingField = value;
			}
		}

		// Token: 0x17001205 RID: 4613
		// (get) Token: 0x06004228 RID: 16936 RVA: 0x001043EC File Offset: 0x001025EC
		// (set) Token: 0x06004229 RID: 16937 RVA: 0x00104400 File Offset: 0x00102600
		public int DealerWarrantyDays
		{
			[CompilerGenerated]
			get
			{
				return this.<DealerWarrantyDays>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<DealerWarrantyDays>k__BackingField = value;
			}
		}

		// Token: 0x17001206 RID: 4614
		// (get) Token: 0x0600422A RID: 16938 RVA: 0x00104414 File Offset: 0x00102614
		// (set) Token: 0x0600422B RID: 16939 RVA: 0x00104428 File Offset: 0x00102628
		public ICustomer Dealer
		{
			[CompilerGenerated]
			get
			{
				return this.<Dealer>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Dealer>k__BackingField = value;
			}
		}

		// Token: 0x17001207 RID: 4615
		// (get) Token: 0x0600422C RID: 16940 RVA: 0x0010443C File Offset: 0x0010263C
		// (set) Token: 0x0600422D RID: 16941 RVA: 0x00104450 File Offset: 0x00102650
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
				this.<Attributes>k__BackingField = value;
			}
		}

		// Token: 0x17001208 RID: 4616
		// (get) Token: 0x0600422E RID: 16942 RVA: 0x00104464 File Offset: 0x00102664
		// (set) Token: 0x0600422F RID: 16943 RVA: 0x00104478 File Offset: 0x00102678
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
				this.<Created>k__BackingField = value;
			}
		}

		// Token: 0x17001209 RID: 4617
		// (get) Token: 0x06004230 RID: 16944 RVA: 0x0010448C File Offset: 0x0010268C
		public string DealerWarrantyText
		{
			get
			{
				return new Warranty().Days2Name(this.DealerWarrantyDays);
			}
		}

		// Token: 0x1700120A RID: 4618
		// (get) Token: 0x06004231 RID: 16945 RVA: 0x001044AC File Offset: 0x001026AC
		public string UnitsText
		{
			get
			{
				int units = this.Units;
				if (units == 0)
				{
					return Lang.t("Pcs");
				}
				if (units != 1)
				{
					return "";
				}
				return Lang.t("Gram");
			}
		}

		// Token: 0x06004232 RID: 16946 RVA: 0x001044E4 File Offset: 0x001026E4
		public void SetWarranty(int days)
		{
			this.Warranty = days;
			Warranty warranty = new Warranty();
			this.WarrantyStr = warranty.Days2Name(days);
		}

		// Token: 0x06004233 RID: 16947 RVA: 0x0010450C File Offset: 0x0010270C
		public SaleItem()
		{
			this.Attributes = new List<IAttribute>();
		}

		// Token: 0x06004234 RID: 16948 RVA: 0x0010452C File Offset: 0x0010272C
		public void SetAttributes(IEnumerable<IAttribute> attributes)
		{
			this.Attributes.Clear();
			this.Attributes.AddRange(attributes);
		}

		// Token: 0x04002ACD RID: 10957
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04002ACE RID: 10958
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04002ACF RID: 10959
		[CompilerGenerated]
		private int <Articul>k__BackingField;

		// Token: 0x04002AD0 RID: 10960
		[CompilerGenerated]
		private int <Count>k__BackingField;

		// Token: 0x04002AD1 RID: 10961
		[CompilerGenerated]
		private decimal <Price>k__BackingField;

		// Token: 0x04002AD2 RID: 10962
		[CompilerGenerated]
		private decimal <PriceOpt>k__BackingField;

		// Token: 0x04002AD3 RID: 10963
		[CompilerGenerated]
		private decimal <PriceOpt2>k__BackingField;

		// Token: 0x04002AD4 RID: 10964
		[CompilerGenerated]
		private decimal <PriceSC>k__BackingField;

		// Token: 0x04002AD5 RID: 10965
		[CompilerGenerated]
		private decimal <InPrice>k__BackingField;

		// Token: 0x04002AD6 RID: 10966
		[CompilerGenerated]
		private string <Sn>k__BackingField;

		// Token: 0x04002AD7 RID: 10967
		[CompilerGenerated]
		private int <Warranty>k__BackingField;

		// Token: 0x04002AD8 RID: 10968
		[CompilerGenerated]
		private string <WarrantyStr>k__BackingField;

		// Token: 0x04002AD9 RID: 10969
		[CompilerGenerated]
		private int <StateId>k__BackingField;

		// Token: 0x04002ADA RID: 10970
		[CompilerGenerated]
		private string <StateName>k__BackingField;

		// Token: 0x04002ADB RID: 10971
		[CompilerGenerated]
		private string <Notes>k__BackingField;

		// Token: 0x04002ADC RID: 10972
		[CompilerGenerated]
		private string <BoxName>k__BackingField;

		// Token: 0x04002ADD RID: 10973
		[CompilerGenerated]
		private string <AscBarcode>k__BackingField;

		// Token: 0x04002ADE RID: 10974
		[CompilerGenerated]
		private string <Description>k__BackingField;

		// Token: 0x04002ADF RID: 10975
		[CompilerGenerated]
		private string <Partnumber>k__BackingField;

		// Token: 0x04002AE0 RID: 10976
		[CompilerGenerated]
		private int <Units>k__BackingField;

		// Token: 0x04002AE1 RID: 10977
		[CompilerGenerated]
		private int <DealerWarrantyDays>k__BackingField;

		// Token: 0x04002AE2 RID: 10978
		[CompilerGenerated]
		private ICustomer <Dealer>k__BackingField;

		// Token: 0x04002AE3 RID: 10979
		[CompilerGenerated]
		private List<IAttribute> <Attributes>k__BackingField;

		// Token: 0x04002AE4 RID: 10980
		[CompilerGenerated]
		private DateTime? <Created>k__BackingField;
	}
}
