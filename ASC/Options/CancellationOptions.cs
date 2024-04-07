using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ASC.Interfaces;

namespace ASC.Options
{
	// Token: 0x0200025D RID: 605
	public class CancellationOptions : IOptions<CancellationOptions>
	{
		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x060020D5 RID: 8405 RVA: 0x0005E9F4 File Offset: 0x0005CBF4
		// (set) Token: 0x060020D6 RID: 8406 RVA: 0x0005EA08 File Offset: 0x0005CC08
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

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x060020D7 RID: 8407 RVA: 0x0005EA1C File Offset: 0x0005CC1C
		// (set) Token: 0x060020D8 RID: 8408 RVA: 0x0005EA30 File Offset: 0x0005CC30
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

		// Token: 0x060020D9 RID: 8409 RVA: 0x0005EA44 File Offset: 0x0005CC44
		public CancellationOptions(int id, string name)
		{
			this.Id = id;
			this.Name = name;
		}

		// Token: 0x060020DA RID: 8410 RVA: 0x000046B4 File Offset: 0x000028B4
		public CancellationOptions()
		{
		}

		// Token: 0x060020DB RID: 8411 RVA: 0x0005EA68 File Offset: 0x0005CC68
		public List<CancellationOptions> GetAllOptions()
		{
			return new List<CancellationOptions>
			{
				new CancellationOptions(1, Lang.t("WarrantyCancellation")),
				new CancellationOptions(2, Lang.t("ExchangeCancellation")),
				new CancellationOptions(3, Lang.t("OtherCancellation")),
				new CancellationOptions(4, Lang.t("Recycling"))
			};
		}

		// Token: 0x040010D3 RID: 4307
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x040010D4 RID: 4308
		[CompilerGenerated]
		private string <Name>k__BackingField;
	}
}
