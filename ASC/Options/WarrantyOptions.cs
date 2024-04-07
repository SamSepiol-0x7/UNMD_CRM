using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ASC.Common.Objects;

namespace ASC.Options
{
	// Token: 0x02000269 RID: 617
	public class WarrantyOptions : Warranty
	{
		// Token: 0x06002125 RID: 8485 RVA: 0x0005FB94 File Offset: 0x0005DD94
		public override List<Warranty> GetAllOptions()
		{
			return WarrantyOptions.GetAll();
		}

		// Token: 0x06002126 RID: 8486 RVA: 0x0005FBA8 File Offset: 0x0005DDA8
		public static List<Warranty> GetAll()
		{
			return new List<Warranty>
			{
				new Warranty(1, 0, Lang.t("WarrantyOpt1")),
				new Warranty(17, 7, "7 " + Lang.t("DayGenetiv")),
				new Warranty(2, 14, "14 " + Lang.t("DayGenetiv")),
				new Warranty(3, 31, "1 " + Lang.t("Month").ToLower()),
				new Warranty(4, 62, "2 " + Lang.t("MonthGenitive")),
				new Warranty(5, 93, "3 " + Lang.t("MonthGenitive")),
				new Warranty(6, 124, "4 " + Lang.t("MonthGenitive")),
				new Warranty(7, 155, "5 " + Lang.t("MonthGenitivePlural")),
				new Warranty(8, 186, "6 " + Lang.t("MonthGenitivePlural")),
				new Warranty(9, 217, "7 " + Lang.t("MonthGenitivePlural")),
				new Warranty(10, 248, "8 " + Lang.t("MonthGenitivePlural")),
				new Warranty(11, 279, "9 " + Lang.t("MonthGenitivePlural")),
				new Warranty(12, 310, "10 " + Lang.t("MonthGenitivePlural")),
				new Warranty(13, 341, "11 " + Lang.t("MonthGenitivePlural")),
				new Warranty(14, 365, "1 " + Lang.t("Year").ToLower()),
				new Warranty(15, 730, "2 " + Lang.t("YearGenitive")),
				new Warranty(16, 1095, "3 " + Lang.t("YearGenitive")),
				new Warranty(-1, 0, Lang.t("WarrantyOpt-1")),
				new Warranty(-2, 0, Lang.t("WarrantyOpt-2")),
				new Warranty(-3, 0, Lang.t("WarrantyOpt-3"))
			};
		}

		// Token: 0x06002127 RID: 8487 RVA: 0x0005FE68 File Offset: 0x0005E068
		public static string DaysToName(int days)
		{
			Warranty warranty = WarrantyOptions.GetAll().FirstOrDefault((Warranty o) => o.Days == days);
			if (warranty == null)
			{
				return string.Empty;
			}
			return warranty.Name;
		}

		// Token: 0x06002128 RID: 8488 RVA: 0x0005FEA8 File Offset: 0x0005E0A8
		public static int State2DefaultWarrany(int state)
		{
			switch (state)
			{
			case 1:
				return Auth.Config.default_items_warranty;
			case 2:
				return Auth.Config.default_items_used_warranty;
			case 3:
				return Auth.Config.default_items_rep_warranty;
			case 5:
				return Auth.Config.default_items_razb_warranty;
			case 6:
				return Auth.Config.default_items_other_warranty;
			}
			return 0;
		}

		// Token: 0x06002129 RID: 8489 RVA: 0x0005FF10 File Offset: 0x0005E110
		public WarrantyOptions()
		{
		}

		// Token: 0x0200026A RID: 618
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x0600212A RID: 8490 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x0600212B RID: 8491 RVA: 0x0005FF24 File Offset: 0x0005E124
			internal bool <DaysToName>b__0(Warranty o)
			{
				return o.Days == this.days;
			}

			// Token: 0x040010F8 RID: 4344
			public int days;
		}
	}
}
