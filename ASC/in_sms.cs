using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x02000047 RID: 71
	public class in_sms
	{
		// Token: 0x060006CD RID: 1741 RVA: 0x0000F2CC File Offset: 0x0000D4CC
		public in_sms()
		{
			this.notifications = new HashSet<notifications>();
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x0000F2EC File Offset: 0x0000D4EC
		// (set) Token: 0x060006CF RID: 1743 RVA: 0x0000F300 File Offset: 0x0000D500
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

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x060006D0 RID: 1744 RVA: 0x0000F314 File Offset: 0x0000D514
		// (set) Token: 0x060006D1 RID: 1745 RVA: 0x0000F328 File Offset: 0x0000D528
		public DateTime date
		{
			[CompilerGenerated]
			get
			{
				return this.<date>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<date>k__BackingField = value;
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x060006D2 RID: 1746 RVA: 0x0000F33C File Offset: 0x0000D53C
		// (set) Token: 0x060006D3 RID: 1747 RVA: 0x0000F350 File Offset: 0x0000D550
		public string modem
		{
			[CompilerGenerated]
			get
			{
				return this.<modem>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<modem>k__BackingField = value;
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x060006D4 RID: 1748 RVA: 0x0000F364 File Offset: 0x0000D564
		// (set) Token: 0x060006D5 RID: 1749 RVA: 0x0000F378 File Offset: 0x0000D578
		public string callerid
		{
			[CompilerGenerated]
			get
			{
				return this.<callerid>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<callerid>k__BackingField = value;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x0000F38C File Offset: 0x0000D58C
		// (set) Token: 0x060006D7 RID: 1751 RVA: 0x0000F3A0 File Offset: 0x0000D5A0
		public string msg
		{
			[CompilerGenerated]
			get
			{
				return this.<msg>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<msg>k__BackingField = value;
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x0000F3B4 File Offset: 0x0000D5B4
		// (set) Token: 0x060006D9 RID: 1753 RVA: 0x0000F3C8 File Offset: 0x0000D5C8
		public string oktell
		{
			[CompilerGenerated]
			get
			{
				return this.<oktell>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<oktell>k__BackingField = value;
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x0000F3DC File Offset: 0x0000D5DC
		// (set) Token: 0x060006DB RID: 1755 RVA: 0x0000F3F0 File Offset: 0x0000D5F0
		public virtual ICollection<notifications> notifications
		{
			[CompilerGenerated]
			get
			{
				return this.<notifications>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<notifications>k__BackingField = value;
			}
		}

		// Token: 0x04000340 RID: 832
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x04000341 RID: 833
		[CompilerGenerated]
		private DateTime <date>k__BackingField;

		// Token: 0x04000342 RID: 834
		[CompilerGenerated]
		private string <modem>k__BackingField;

		// Token: 0x04000343 RID: 835
		[CompilerGenerated]
		private string <callerid>k__BackingField;

		// Token: 0x04000344 RID: 836
		[CompilerGenerated]
		private string <msg>k__BackingField;

		// Token: 0x04000345 RID: 837
		[CompilerGenerated]
		private string <oktell>k__BackingField;

		// Token: 0x04000346 RID: 838
		[CompilerGenerated]
		private ICollection<notifications> <notifications>k__BackingField;
	}
}
