using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;
using ASC.Models;
using ASC.Objects.Converters;

namespace ASC.Objects
{
	// Token: 0x02000871 RID: 2161
	public class StoreBox : Box, ICheckFields, IStoreBox, IBox
	{
		// Token: 0x1700113A RID: 4410
		// (get) Token: 0x06004028 RID: 16424 RVA: 0x000FFAA4 File Offset: 0x000FDCA4
		// (set) Token: 0x06004029 RID: 16425 RVA: 0x000FFAB8 File Offset: 0x000FDCB8
		public int? StoreId
		{
			[CompilerGenerated]
			get
			{
				return this.<StoreId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<StoreId>k__BackingField, value))
				{
					return;
				}
				this.<StoreId>k__BackingField = value;
				this.RaisePropertyChanged("StoreId");
			}
		}

		// Token: 0x1700113B RID: 4411
		// (get) Token: 0x0600402A RID: 16426 RVA: 0x000FFAE8 File Offset: 0x000FDCE8
		// (set) Token: 0x0600402B RID: 16427 RVA: 0x000FFAFC File Offset: 0x000FDCFC
		public List<IGoods> Items
		{
			[CompilerGenerated]
			get
			{
				return this.<Items>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Items>k__BackingField, value))
				{
					return;
				}
				this.<Items>k__BackingField = value;
				this.RaisePropertyChanged("Items");
			}
		}

		// Token: 0x0600402C RID: 16428 RVA: 0x000FFB2C File Offset: 0x000FDD2C
		public StoreBox()
		{
			this.Items = new List<IGoods>();
		}

		// Token: 0x0600402D RID: 16429 RVA: 0x000FFB4C File Offset: 0x000FDD4C
		public override void LoadItems()
		{
			using (GenericRepository<store_items> genericRepository = new GenericRepository<store_items>())
			{
				IEnumerable<store_items> all = genericRepository.GetAll((store_items r) => r.box == (int?)this.Id, null, "");
				this.Items = (from r in all
				select r.ToGoods()).ToList<IGoods>();
			}
		}

		// Token: 0x0600402E RID: 16430 RVA: 0x000FFC2C File Offset: 0x000FDE2C
		public override string CheckFields()
		{
			string text = base.CheckFields();
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			if (this.StoreId == null)
			{
				return "SelectStore2";
			}
			return "";
		}

		// Token: 0x04002A0D RID: 10765
		[CompilerGenerated]
		private int? <StoreId>k__BackingField;

		// Token: 0x04002A0E RID: 10766
		[CompilerGenerated]
		private List<IGoods> <Items>k__BackingField;

		// Token: 0x02000872 RID: 2162
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600402F RID: 16431 RVA: 0x000FFC68 File Offset: 0x000FDE68
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004030 RID: 16432 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06004031 RID: 16433 RVA: 0x000FFC80 File Offset: 0x000FDE80
			internal IGoods <LoadItems>b__9_1(store_items r)
			{
				return r.ToGoods();
			}

			// Token: 0x04002A0F RID: 10767
			public static readonly StoreBox.<>c <>9 = new StoreBox.<>c();

			// Token: 0x04002A10 RID: 10768
			public static Func<store_items, IGoods> <>9__9_1;
		}
	}
}
