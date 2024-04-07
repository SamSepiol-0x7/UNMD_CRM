using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ASC.Options
{
	// Token: 0x0200024B RID: 587
	public class ClientInformOptions
	{
		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x06002065 RID: 8293 RVA: 0x0005D3E0 File Offset: 0x0005B5E0
		// (set) Token: 0x06002066 RID: 8294 RVA: 0x0005D3F4 File Offset: 0x0005B5F4
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

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x06002067 RID: 8295 RVA: 0x0005D408 File Offset: 0x0005B608
		// (set) Token: 0x06002068 RID: 8296 RVA: 0x0005D41C File Offset: 0x0005B61C
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

		// Token: 0x06002069 RID: 8297 RVA: 0x0005D430 File Offset: 0x0005B630
		public static Dictionary<int, string> GetAllOptions()
		{
			return new Dictionary<int, string>
			{
				{
					0,
					"---"
				},
				{
					1,
					Lang.t("ClientInformed")
				},
				{
					2,
					Lang.t("ClientNotAnswer")
				},
				{
					3,
					Lang.t("ClientNotAvailable")
				},
				{
					4,
					Lang.t("ClientOther")
				}
			};
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x0005D494 File Offset: 0x0005B694
		public string GetOptionNameById(int optionId)
		{
			return ClientInformOptions.GetAllOptions().FirstOrDefault((KeyValuePair<int, string> o) => o.Key == optionId).Value;
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x000046B4 File Offset: 0x000028B4
		public ClientInformOptions()
		{
		}

		// Token: 0x0400109B RID: 4251
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x0400109C RID: 4252
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x0200024C RID: 588
		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x0600206C RID: 8300 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x0600206D RID: 8301 RVA: 0x0005D4CC File Offset: 0x0005B6CC
			internal bool <GetOptionNameById>b__0(KeyValuePair<int, string> o)
			{
				return o.Key == this.optionId;
			}

			// Token: 0x0400109D RID: 4253
			public int optionId;
		}
	}
}
