using System;

namespace ASC.Extensions
{
	// Token: 0x02000B51 RID: 2897
	public static class DateTimeExtensions
	{
		// Token: 0x06005143 RID: 20803 RVA: 0x0015D0EC File Offset: 0x0015B2EC
		public static long ToUnixTimestamp(this DateTime d)
		{
			return (long)(d - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
		}
	}
}
