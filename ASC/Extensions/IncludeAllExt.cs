using System;
using System.Collections.Generic;
using ASC.Common.Interfaces;
using ASC.SimpleClasses;

namespace ASC.Extensions
{
	// Token: 0x02000B54 RID: 2900
	public static class IncludeAllExt
	{
		// Token: 0x0600514F RID: 20815 RVA: 0x0015D35C File Offset: 0x0015B55C
		public static List<T> WithIncludeAll<T>(this List<T> set)
		{
			List<IIdName> list = set as List<IIdName>;
			if (list != null)
			{
				list.Insert(0, new IdNameClass(0, Lang.t("All")));
			}
			return set;
		}
	}
}
