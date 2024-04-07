using System;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;

namespace ASC.Models
{
	// Token: 0x020009BD RID: 2493
	public class SalesReportDto
	{
		// Token: 0x1700145E RID: 5214
		// (get) Token: 0x06004AB5 RID: 19125 RVA: 0x0012EC28 File Offset: 0x0012CE28
		public string UID
		{
			get
			{
				return string.Format("{0:D6}-{1:D6}", this.ProductArticul, this.ProductId);
			}
		}

		// Token: 0x1700145F RID: 5215
		// (get) Token: 0x06004AB6 RID: 19126 RVA: 0x0012EC58 File Offset: 0x0012CE58
		// (set) Token: 0x06004AB7 RID: 19127 RVA: 0x0012EC6C File Offset: 0x0012CE6C
		public int ProductId
		{
			[CompilerGenerated]
			get
			{
				return this.<ProductId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ProductId>k__BackingField = value;
			}
		}

		// Token: 0x17001460 RID: 5216
		// (get) Token: 0x06004AB8 RID: 19128 RVA: 0x0012EC80 File Offset: 0x0012CE80
		// (set) Token: 0x06004AB9 RID: 19129 RVA: 0x0012EC94 File Offset: 0x0012CE94
		public int ProductArticul
		{
			[CompilerGenerated]
			get
			{
				return this.<ProductArticul>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ProductArticul>k__BackingField = value;
			}
		}

		// Token: 0x17001461 RID: 5217
		// (get) Token: 0x06004ABA RID: 19130 RVA: 0x0012ECA8 File Offset: 0x0012CEA8
		// (set) Token: 0x06004ABB RID: 19131 RVA: 0x0012ECBC File Offset: 0x0012CEBC
		public int DocumentId
		{
			[CompilerGenerated]
			get
			{
				return this.<DocumentId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<DocumentId>k__BackingField = value;
			}
		}

		// Token: 0x17001462 RID: 5218
		// (get) Token: 0x06004ABC RID: 19132 RVA: 0x0012ECD0 File Offset: 0x0012CED0
		// (set) Token: 0x06004ABD RID: 19133 RVA: 0x0012ECE4 File Offset: 0x0012CEE4
		public DateTime Date
		{
			[CompilerGenerated]
			get
			{
				return this.<Date>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Date>k__BackingField = value;
			}
		}

		// Token: 0x17001463 RID: 5219
		// (get) Token: 0x06004ABE RID: 19134 RVA: 0x0012ECF8 File Offset: 0x0012CEF8
		// (set) Token: 0x06004ABF RID: 19135 RVA: 0x0012ED0C File Offset: 0x0012CF0C
		public IEmployee Employee
		{
			[CompilerGenerated]
			get
			{
				return this.<Employee>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Employee>k__BackingField = value;
			}
		}

		// Token: 0x17001464 RID: 5220
		// (get) Token: 0x06004AC0 RID: 19136 RVA: 0x0012ED20 File Offset: 0x0012CF20
		// (set) Token: 0x06004AC1 RID: 19137 RVA: 0x0012ED34 File Offset: 0x0012CF34
		public string ProductName
		{
			[CompilerGenerated]
			get
			{
				return this.<ProductName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ProductName>k__BackingField = value;
			}
		}

		// Token: 0x17001465 RID: 5221
		// (get) Token: 0x06004AC2 RID: 19138 RVA: 0x0012ED48 File Offset: 0x0012CF48
		// (set) Token: 0x06004AC3 RID: 19139 RVA: 0x0012ED5C File Offset: 0x0012CF5C
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

		// Token: 0x17001466 RID: 5222
		// (get) Token: 0x06004AC4 RID: 19140 RVA: 0x0012ED70 File Offset: 0x0012CF70
		// (set) Token: 0x06004AC5 RID: 19141 RVA: 0x0012ED84 File Offset: 0x0012CF84
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

		// Token: 0x17001467 RID: 5223
		// (get) Token: 0x06004AC6 RID: 19142 RVA: 0x0012ED98 File Offset: 0x0012CF98
		// (set) Token: 0x06004AC7 RID: 19143 RVA: 0x0012EDAC File Offset: 0x0012CFAC
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

		// Token: 0x17001468 RID: 5224
		// (get) Token: 0x06004AC8 RID: 19144 RVA: 0x0012EDC0 File Offset: 0x0012CFC0
		public decimal PriceSumm
		{
			get
			{
				return this.Count * this.Price;
			}
		}

		// Token: 0x17001469 RID: 5225
		// (get) Token: 0x06004AC9 RID: 19145 RVA: 0x0012EDE4 File Offset: 0x0012CFE4
		// (set) Token: 0x06004ACA RID: 19146 RVA: 0x0012EDF8 File Offset: 0x0012CFF8
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
				this.<IsRealization>k__BackingField = value;
			}
		}

		// Token: 0x1700146A RID: 5226
		// (get) Token: 0x06004ACB RID: 19147 RVA: 0x0012EE0C File Offset: 0x0012D00C
		// (set) Token: 0x06004ACC RID: 19148 RVA: 0x0012EE20 File Offset: 0x0012D020
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
				this.<ReturnPercent>k__BackingField = value;
			}
		}

		// Token: 0x1700146B RID: 5227
		// (get) Token: 0x06004ACD RID: 19149 RVA: 0x0012EE34 File Offset: 0x0012D034
		public decimal RealizatorPart
		{
			get
			{
				if (!(this.InPrice == 0m))
				{
					return this.InPrice;
				}
				return this.Price * this.Count / 100m * this.ReturnPercent;
			}
		}

		// Token: 0x1700146C RID: 5228
		// (get) Token: 0x06004ACE RID: 19150 RVA: 0x0012EE8C File Offset: 0x0012D08C
		public decimal ProfitSumm
		{
			get
			{
				if (!this.IsRealization)
				{
					return this.Price * this.Count - this.InPrice * this.Count;
				}
				return this.Price * this.Count - this.RealizatorPart;
			}
		}

		// Token: 0x06004ACF RID: 19151 RVA: 0x000046B4 File Offset: 0x000028B4
		public SalesReportDto()
		{
		}

		// Token: 0x04003015 RID: 12309
		[CompilerGenerated]
		private int <ProductId>k__BackingField;

		// Token: 0x04003016 RID: 12310
		[CompilerGenerated]
		private int <ProductArticul>k__BackingField;

		// Token: 0x04003017 RID: 12311
		[CompilerGenerated]
		private int <DocumentId>k__BackingField;

		// Token: 0x04003018 RID: 12312
		[CompilerGenerated]
		private DateTime <Date>k__BackingField;

		// Token: 0x04003019 RID: 12313
		[CompilerGenerated]
		private IEmployee <Employee>k__BackingField;

		// Token: 0x0400301A RID: 12314
		[CompilerGenerated]
		private string <ProductName>k__BackingField;

		// Token: 0x0400301B RID: 12315
		[CompilerGenerated]
		private int <Count>k__BackingField;

		// Token: 0x0400301C RID: 12316
		[CompilerGenerated]
		private decimal <InPrice>k__BackingField;

		// Token: 0x0400301D RID: 12317
		[CompilerGenerated]
		private decimal <Price>k__BackingField;

		// Token: 0x0400301E RID: 12318
		[CompilerGenerated]
		private bool <IsRealization>k__BackingField;

		// Token: 0x0400301F RID: 12319
		[CompilerGenerated]
		private int <ReturnPercent>k__BackingField;
	}
}
