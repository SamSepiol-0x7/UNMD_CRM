using System;
using System.Collections.Generic;
using ASC.Services.Abstract;

namespace ASC.Services.Concrete
{
	// Token: 0x020006F2 RID: 1778
	public class CallService : ICallService
	{
		// Token: 0x060039BC RID: 14780 RVA: 0x000CFB1C File Offset: 0x000CDD1C
		public Dictionary<int, string> GetDirections()
		{
			return new Dictionary<int, string>
			{
				{
					0,
					Lang.t("All")
				},
				{
					1,
					Lang.t("Incoming")
				},
				{
					2,
					Lang.t("Outcoming")
				}
			};
		}

		// Token: 0x060039BD RID: 14781 RVA: 0x000046B4 File Offset: 0x000028B4
		public CallService()
		{
		}
	}
}
