using System;

namespace ASC.Objects.Converters
{
	// Token: 0x02000902 RID: 2306
	public static class CdrMapper
	{
		// Token: 0x060047DA RID: 18394 RVA: 0x0011767C File Offset: 0x0011587C
		public static AscCDR ToAscCDR(this cdr c)
		{
			return new AscCDR
			{
				CallId = c.uniqueid,
				Src = c.src,
				Destination = c.dst,
				Duration = c.duration,
				Start = Localization.ToLocalTimeZone(c.calldate),
				IsIncoming = c.dcontext.Contains("from"),
				IsRecorded = (c.duration > 0),
				Disposition = CdrMapper.GetDisposition(c.disposition)
			};
		}

		// Token: 0x060047DB RID: 18395 RVA: 0x00117708 File Offset: 0x00115908
		private static string GetDisposition(string value)
		{
			if (value == "ANSWERED")
			{
				return Lang.t("dispositionAnswered");
			}
			if (value == "NO ANSWER")
			{
				return Lang.t("dispositionNoAnswer");
			}
			if (value == "BUSY")
			{
				return Lang.t("dispositionBusy");
			}
			if (value == "FAILED")
			{
				return Lang.t("dispositionFailed");
			}
			if (value == "UNKNOWN")
			{
				return Lang.t("dispositionFailed");
			}
			return value;
		}
	}
}
