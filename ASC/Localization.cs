using System;
using System.Linq;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;

namespace ASC
{
	// Token: 0x020000B1 RID: 177
	public class Localization : ILocalization
	{
		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06001302 RID: 4866 RVA: 0x00029888 File Offset: 0x00027A88
		private TimeZoneInfo TimeZone
		{
			[CompilerGenerated]
			get
			{
				return this.<TimeZone>k__BackingField;
			}
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x0002989C File Offset: 0x00027A9C
		public Localization(string timeZoneId = "UTC")
		{
			this.TimeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06001304 RID: 4868 RVA: 0x000298BC File Offset: 0x00027ABC
		public DateTime Now
		{
			get
			{
				return TimeZoneInfo.ConvertTime(DateTime.UtcNow, this.TimeZone);
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06001305 RID: 4869 RVA: 0x000298DC File Offset: 0x00027ADC
		public DateTime NowDate
		{
			get
			{
				return TimeZoneInfo.ConvertTime(DateTime.UtcNow, this.TimeZone).Date;
			}
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x00029904 File Offset: 0x00027B04
		public static DateTime ToLocalTimeZone(DateTime value)
		{
			TimeZoneInfo destinationTimeZone = TimeZoneInfo.FindSystemTimeZoneById(Auth.Config.time_zone);
			return TimeZoneInfo.ConvertTime(DateTime.SpecifyKind(value, DateTimeKind.Utc), destinationTimeZone);
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x00029930 File Offset: 0x00027B30
		public static DateTime GetServerUtcTime()
		{
			DateTime result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					result = Localization.GetServerUtcTime(auseceEntities);
				}
			}
			catch (Exception)
			{
				result = DateTime.Now;
			}
			return result;
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x00029980 File Offset: 0x00027B80
		public static DateTime GetServerUtcTime(auseceEntities ctx)
		{
			return ctx.Database.SqlQuery<DateTime>("SELECT UTC_TIMESTAMP() FROM DUAL;", new object[0]).ToList<DateTime>().First<DateTime>();
		}

		// Token: 0x04000924 RID: 2340
		[CompilerGenerated]
		private readonly TimeZoneInfo <TimeZone>k__BackingField;
	}
}
