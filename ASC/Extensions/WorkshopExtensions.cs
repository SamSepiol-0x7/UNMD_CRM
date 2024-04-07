using System;

namespace ASC.Extensions
{
	// Token: 0x02000B59 RID: 2905
	public static class WorkshopExtensions
	{
		// Token: 0x0600515C RID: 20828 RVA: 0x0015E184 File Offset: 0x0015C384
		public static void SetRealCost(this workshop w, decimal worksSumm, decimal partsSumm)
		{
			w.real_repair_cost = (Auth.Config.parts_included ? worksSumm : (worksSumm + partsSumm));
			w.parts_cost = partsSumm;
		}
	}
}
