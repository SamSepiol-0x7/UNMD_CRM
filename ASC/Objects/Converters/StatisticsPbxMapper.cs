using System;
using ASC.Common.Interfaces;
using ASC.Voip.Zadarma.Models;

namespace ASC.Objects.Converters
{
	// Token: 0x0200090F RID: 2319
	public static class StatisticsPbxMapper
	{
		// Token: 0x060047F8 RID: 18424 RVA: 0x00118218 File Offset: 0x00116418
		public static IAscCDR ToAscCDR(this StatisticPbx c)
		{
			return new AscCDR
			{
				CallId = c.CallId,
				Start = c.Callstart,
				Duration = c.Seconds,
				Src = c.Sip,
				Destination = c.Destination,
				IsIncoming = (c.Sip.Length > 4),
				Disposition = StatisticsPbxMapper.GetDisposition(c.Disposition),
				IsRecorded = c.IsRecorded
			};
		}

		// Token: 0x060047F9 RID: 18425 RVA: 0x00118298 File Offset: 0x00116498
		private static string GetDisposition(string value)
		{
			uint num = <PrivateImplementationDetails>.ComputeStringHash(value);
			if (num <= 454440820U)
			{
				if (num > 167618590U)
				{
					if (num == 272693406U)
					{
						if (value == "answered")
						{
							return Lang.t("dispositionAnswered");
						}
					}
					else if (num == 369084839U)
					{
						if (value == "no day limit")
						{
							return Lang.t("dispositionNoDayLimit");
						}
					}
					else if (num == 454440820U && value == "line limit")
					{
						return Lang.t("dispositionLineLimit");
					}
				}
				else if (num == 107912219U)
				{
					if (value == "cancel")
					{
						return Lang.t("dispositionCancel");
					}
				}
				else if (num == 167618590U)
				{
					if (value == "no money")
					{
						return Lang.t("dispositionNoMoney");
					}
				}
			}
			else if (num > 1037947582U)
			{
				if (num == 1559978112U)
				{
					if (value == "busy")
					{
						return Lang.t("dispositionBusy");
					}
				}
				else if (num == 2351514184U)
				{
					if (value == "unallocated number")
					{
						return Lang.t("dispositionUnallocatedNumber");
					}
				}
				else if (num == 3769421748U)
				{
					if (value == "failed")
					{
						return Lang.t("dispositionFailed");
					}
				}
			}
			else if (num == 459855256U)
			{
				if (value == "no answer")
				{
					return Lang.t("dispositionNoAnswer");
				}
			}
			else if (num == 484151005U)
			{
				if (value == "no limit")
				{
					return Lang.t("dispositionNoLimit");
				}
			}
			else if (num == 1037947582U && value == "no money, no limit")
			{
				return Lang.t("dispositionNoLimit");
			}
			return "";
		}
	}
}
