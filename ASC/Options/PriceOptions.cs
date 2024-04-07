using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ASC.Interfaces;

namespace ASC.Options
{
	// Token: 0x02000263 RID: 611
	public class PriceOptions : IOptions<PriceOptions>
	{
		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x060020F5 RID: 8437 RVA: 0x0005EF54 File Offset: 0x0005D154
		// (set) Token: 0x060020F6 RID: 8438 RVA: 0x0005EF68 File Offset: 0x0005D168
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

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x060020F7 RID: 8439 RVA: 0x0005EF7C File Offset: 0x0005D17C
		// (set) Token: 0x060020F8 RID: 8440 RVA: 0x0005EF90 File Offset: 0x0005D190
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

		// Token: 0x060020F9 RID: 8441 RVA: 0x000046B4 File Offset: 0x000028B4
		public PriceOptions()
		{
		}

		// Token: 0x060020FA RID: 8442 RVA: 0x0005EFA4 File Offset: 0x0005D1A4
		public PriceOptions(int id, string name)
		{
			this.Id = id;
			this.Name = name;
		}

		// Token: 0x060020FB RID: 8443 RVA: 0x0005EFC8 File Offset: 0x0005D1C8
		public List<PriceOptions> GetAllOptions()
		{
			return new List<PriceOptions>
			{
				new PriceOptions(1, Lang.t("Fixed")),
				new PriceOptions(2, "Привязка к курсу $"),
				new PriceOptions(3, "Проценты, цена 0")
			};
		}

		// Token: 0x060020FC RID: 8444 RVA: 0x0005F014 File Offset: 0x0005D214
		public PriceOptions GetOption(int optionId)
		{
			return this.GetAllOptions().FirstOrDefault((PriceOptions o) => o.Id == optionId);
		}

		// Token: 0x040010E4 RID: 4324
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x040010E5 RID: 4325
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x02000264 RID: 612
		[CompilerGenerated]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x060020FD RID: 8445 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass11_0()
			{
			}

			// Token: 0x060020FE RID: 8446 RVA: 0x0005F048 File Offset: 0x0005D248
			internal bool <GetOption>b__0(PriceOptions o)
			{
				return o.Id == this.optionId;
			}

			// Token: 0x040010E6 RID: 4326
			public int optionId;
		}
	}
}
