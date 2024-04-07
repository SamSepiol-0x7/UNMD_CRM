using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace ASC.Models
{
	// Token: 0x0200094A RID: 2378
	public class UserRepairStatusLogsModel
	{
		// Token: 0x17001438 RID: 5176
		// (get) Token: 0x06004902 RID: 18690 RVA: 0x0011E2AC File Offset: 0x0011C4AC
		// (set) Token: 0x06004903 RID: 18691 RVA: 0x0011E2C0 File Offset: 0x0011C4C0
		public int UserId
		{
			[CompilerGenerated]
			get
			{
				return this.<UserId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<UserId>k__BackingField = value;
			}
		}

		// Token: 0x17001439 RID: 5177
		// (get) Token: 0x06004904 RID: 18692 RVA: 0x0011E2D4 File Offset: 0x0011C4D4
		// (set) Token: 0x06004905 RID: 18693 RVA: 0x0011E2E8 File Offset: 0x0011C4E8
		public string UserFioShort
		{
			[CompilerGenerated]
			get
			{
				return this.<UserFioShort>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<UserFioShort>k__BackingField = value;
			}
		}

		// Token: 0x1700143A RID: 5178
		// (get) Token: 0x06004906 RID: 18694 RVA: 0x0011E2FC File Offset: 0x0011C4FC
		[Dynamic]
		public dynamic Total
		{
			[CompilerGenerated]
			[return: Dynamic]
			get
			{
				return this.<Total>k__BackingField;
			}
		} = new ExpandoObject();

		// Token: 0x06004907 RID: 18695 RVA: 0x0011E310 File Offset: 0x0011C510
		public UserRepairStatusLogsModel(users user)
		{
			this.UserId = user.id;
			this.UserFioShort = user.FioShort;
		}

		// Token: 0x1700143B RID: 5179
		// (get) Token: 0x06004908 RID: 18696 RVA: 0x0011E354 File Offset: 0x0011C554
		[Dynamic(new bool[]
		{
			false,
			true
		})]
		public List<dynamic> Data
		{
			[CompilerGenerated]
			[return: Dynamic(new bool[]
			{
				false,
				true
			})]
			get
			{
				return this.<Data>k__BackingField;
			}
		} = new List<object>();

		// Token: 0x04002E74 RID: 11892
		[CompilerGenerated]
		private int <UserId>k__BackingField;

		// Token: 0x04002E75 RID: 11893
		[CompilerGenerated]
		private string <UserFioShort>k__BackingField;

		// Token: 0x04002E76 RID: 11894
		[Dynamic]
		[CompilerGenerated]
		private readonly dynamic <Total>k__BackingField;

		// Token: 0x04002E77 RID: 11895
		[Dynamic(new bool[]
		{
			false,
			true
		})]
		[CompilerGenerated]
		private readonly List<dynamic> <Data>k__BackingField;

		// Token: 0x0200094B RID: 2379
		public class StatusData
		{
			// Token: 0x1700143C RID: 5180
			// (get) Token: 0x06004909 RID: 18697 RVA: 0x0011E368 File Offset: 0x0011C568
			// (set) Token: 0x0600490A RID: 18698 RVA: 0x0011E37C File Offset: 0x0011C57C
			public int Count
			{
				[CompilerGenerated]
				get
				{
					return this.<Count>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<Count>k__BackingField = value;
				}
			}

			// Token: 0x1700143D RID: 5181
			// (get) Token: 0x0600490B RID: 18699 RVA: 0x0011E390 File Offset: 0x0011C590
			// (set) Token: 0x0600490C RID: 18700 RVA: 0x0011E3A4 File Offset: 0x0011C5A4
			public List<int> RepairIds
			{
				[CompilerGenerated]
				get
				{
					return this.<RepairIds>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<RepairIds>k__BackingField = value;
				}
			}

			// Token: 0x0600490D RID: 18701 RVA: 0x000046B4 File Offset: 0x000028B4
			public StatusData()
			{
			}

			// Token: 0x04002E78 RID: 11896
			[CompilerGenerated]
			private int <Count>k__BackingField;

			// Token: 0x04002E79 RID: 11897
			[CompilerGenerated]
			private List<int> <RepairIds>k__BackingField;
		}
	}
}
