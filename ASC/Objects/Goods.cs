using System;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;

namespace ASC.Objects
{
	// Token: 0x020008D5 RID: 2261
	public class Goods : IIdName, IGoods
	{
		// Token: 0x17001341 RID: 4929
		// (get) Token: 0x060045B8 RID: 17848 RVA: 0x00111084 File Offset: 0x0010F284
		// (set) Token: 0x060045B9 RID: 17849 RVA: 0x00111098 File Offset: 0x0010F298
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

		// Token: 0x17001342 RID: 4930
		// (get) Token: 0x060045BA RID: 17850 RVA: 0x001110AC File Offset: 0x0010F2AC
		// (set) Token: 0x060045BB RID: 17851 RVA: 0x001110C0 File Offset: 0x0010F2C0
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

		// Token: 0x17001343 RID: 4931
		// (get) Token: 0x060045BC RID: 17852 RVA: 0x001110D4 File Offset: 0x0010F2D4
		// (set) Token: 0x060045BD RID: 17853 RVA: 0x001110E8 File Offset: 0x0010F2E8
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

		// Token: 0x17001344 RID: 4932
		// (get) Token: 0x060045BE RID: 17854 RVA: 0x001110FC File Offset: 0x0010F2FC
		// (set) Token: 0x060045BF RID: 17855 RVA: 0x00111110 File Offset: 0x0010F310
		public DateTime Created
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

		// Token: 0x17001345 RID: 4933
		// (get) Token: 0x060045C0 RID: 17856 RVA: 0x00111124 File Offset: 0x0010F324
		// (set) Token: 0x060045C1 RID: 17857 RVA: 0x00111138 File Offset: 0x0010F338
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
				this.<StoreId>k__BackingField = value;
			}
		}

		// Token: 0x17001346 RID: 4934
		// (get) Token: 0x060045C2 RID: 17858 RVA: 0x0011114C File Offset: 0x0010F34C
		// (set) Token: 0x060045C3 RID: 17859 RVA: 0x00111160 File Offset: 0x0010F360
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
				this.<CategoryId>k__BackingField = value;
			}
		}

		// Token: 0x17001347 RID: 4935
		// (get) Token: 0x060045C4 RID: 17860 RVA: 0x00111174 File Offset: 0x0010F374
		// (set) Token: 0x060045C5 RID: 17861 RVA: 0x00111188 File Offset: 0x0010F388
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

		// Token: 0x060045C6 RID: 17862 RVA: 0x000046B4 File Offset: 0x000028B4
		public Goods()
		{
		}

		// Token: 0x04002CDA RID: 11482
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04002CDB RID: 11483
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04002CDC RID: 11484
		[CompilerGenerated]
		private int <Count>k__BackingField;

		// Token: 0x04002CDD RID: 11485
		[CompilerGenerated]
		private DateTime <Created>k__BackingField;

		// Token: 0x04002CDE RID: 11486
		[CompilerGenerated]
		private int <StoreId>k__BackingField;

		// Token: 0x04002CDF RID: 11487
		[CompilerGenerated]
		private int <CategoryId>k__BackingField;

		// Token: 0x04002CE0 RID: 11488
		[CompilerGenerated]
		private decimal <InPrice>k__BackingField;
	}
}
