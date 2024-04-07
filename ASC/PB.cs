using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading;
using ASC.SimpleClasses;
using Flurl.Http;
using NLog;

namespace ASC
{
	// Token: 0x02000096 RID: 150
	public class PB
	{
		// Token: 0x06001263 RID: 4707 RVA: 0x00022764 File Offset: 0x00020964
		public decimal GetRate(string from, string to)
		{
			decimal result;
			try
			{
				PbUaRate pbUaRate = "https://api.privatbank.ua/p24api/pubinfo?exchange&json&coursid=11".WithTimeout(9).WithHeader("User-Agent", "ASC Desktop client").GetJsonAsync(default(CancellationToken), HttpCompletionOption.ResponseContentRead).Result.FirstOrDefault((PbUaRate r) => r.base_ccy == to && r.ccy == from);
				result = ((pbUaRate != null) ? pbUaRate.buy : 0m);
			}
			catch (Exception ex)
			{
				ILogger log = PB.Log;
				string str = "Get currency rate from PB error, last record from DB used ";
				Exception ex2 = ex;
				log.Error(str + ((ex2 != null) ? ex2.ToString() : null));
				result = 0m;
			}
			return result;
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x000046B4 File Offset: 0x000028B4
		public PB()
		{
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x00022814 File Offset: 0x00020A14
		// Note: this type is marked as 'beforefieldinit'.
		static PB()
		{
		}

		// Token: 0x040008B3 RID: 2227
		public static readonly ILogger Log = LogManager.GetCurrentClassLogger();

		// Token: 0x02000097 RID: 151
		[CompilerGenerated]
		private sealed class <>c__DisplayClass1_0
		{
			// Token: 0x06001266 RID: 4710 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass1_0()
			{
			}

			// Token: 0x06001267 RID: 4711 RVA: 0x0002282C File Offset: 0x00020A2C
			internal bool <GetRate>b__0(PbUaRate r)
			{
				return r.base_ccy == this.to && r.ccy == this.from;
			}

			// Token: 0x040008B4 RID: 2228
			public string to;

			// Token: 0x040008B5 RID: 2229
			public string from;
		}
	}
}
