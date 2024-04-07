using System;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x02000028 RID: 40
	public class api_failed_logins
	{
		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00006CA8 File Offset: 0x00004EA8
		// (set) Token: 0x06000183 RID: 387 RVA: 0x00006CBC File Offset: 0x00004EBC
		public int id
		{
			[CompilerGenerated]
			get
			{
				return this.<id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<id>k__BackingField = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00006CD0 File Offset: 0x00004ED0
		// (set) Token: 0x06000185 RID: 389 RVA: 0x00006CE4 File Offset: 0x00004EE4
		public long? ip_address
		{
			[CompilerGenerated]
			get
			{
				return this.<ip_address>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ip_address>k__BackingField = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00006CF8 File Offset: 0x00004EF8
		// (set) Token: 0x06000187 RID: 391 RVA: 0x00006D0C File Offset: 0x00004F0C
		public DateTime attempted_at
		{
			[CompilerGenerated]
			get
			{
				return this.<attempted_at>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<attempted_at>k__BackingField = value;
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x000046B4 File Offset: 0x000028B4
		public api_failed_logins()
		{
		}

		// Token: 0x040000B1 RID: 177
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x040000B2 RID: 178
		[CompilerGenerated]
		private long? <ip_address>k__BackingField;

		// Token: 0x040000B3 RID: 179
		[CompilerGenerated]
		private DateTime <attempted_at>k__BackingField;
	}
}
