using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ASC.Interfaces;

namespace ASC.Options
{
	// Token: 0x02000261 RID: 609
	public class ItemsOptions : IOptions<ItemsOptions>
	{
		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x060020ED RID: 8429 RVA: 0x0005EE08 File Offset: 0x0005D008
		// (set) Token: 0x060020EE RID: 8430 RVA: 0x0005EE1C File Offset: 0x0005D01C
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

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x060020EF RID: 8431 RVA: 0x0005EE30 File Offset: 0x0005D030
		// (set) Token: 0x060020F0 RID: 8432 RVA: 0x0005EE44 File Offset: 0x0005D044
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

		// Token: 0x060020F1 RID: 8433 RVA: 0x0005EE58 File Offset: 0x0005D058
		public ItemsOptions(int id, string name)
		{
			this.Id = id;
			this.Name = name;
		}

		// Token: 0x060020F2 RID: 8434 RVA: 0x000046B4 File Offset: 0x000028B4
		public ItemsOptions()
		{
		}

		// Token: 0x060020F3 RID: 8435 RVA: 0x0005EE7C File Offset: 0x0005D07C
		public List<ItemsOptions> GetAllOptions()
		{
			return new List<ItemsOptions>
			{
				new ItemsOptions(2, Lang.t("OnlyInStock")),
				new ItemsOptions(3, Lang.t("ReservedItems")),
				new ItemsOptions(9, Lang.t("InStockAndReserved")),
				new ItemsOptions(1, Lang.t("AllItems")),
				new ItemsOptions(7, Lang.t("ZeroCountItems")),
				new ItemsOptions(8, Lang.t("InStockAndForSale"))
			};
		}

		// Token: 0x060020F4 RID: 8436 RVA: 0x0005EF14 File Offset: 0x0005D114
		public static List<ItemsOptions> GetStockTakingOptions()
		{
			return new List<ItemsOptions>
			{
				new ItemsOptions(2, Lang.t("OnlyInStock")),
				new ItemsOptions(3, Lang.t("ReservedItems"))
			};
		}

		// Token: 0x040010DB RID: 4315
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x040010DC RID: 4316
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x02000262 RID: 610
		public enum opName
		{
			// Token: 0x040010DE RID: 4318
			all = 1,
			// Token: 0x040010DF RID: 4319
			inStock,
			// Token: 0x040010E0 RID: 4320
			reserved,
			// Token: 0x040010E1 RID: 4321
			ZeroCountItems = 7,
			// Token: 0x040010E2 RID: 4322
			inStock4Sale,
			// Token: 0x040010E3 RID: 4323
			InStockAndReserved
		}
	}
}
