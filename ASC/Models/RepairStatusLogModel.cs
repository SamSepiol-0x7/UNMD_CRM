using System;
using System.Runtime.CompilerServices;
using ASC.Objects;

namespace ASC.Models
{
	// Token: 0x02000949 RID: 2377
	public class RepairStatusLogModel
	{
		// Token: 0x17001433 RID: 5171
		// (get) Token: 0x060048FB RID: 18683 RVA: 0x0011E1E8 File Offset: 0x0011C3E8
		public int RepairId
		{
			[CompilerGenerated]
			get
			{
				return this.<RepairId>k__BackingField;
			}
		}

		// Token: 0x17001434 RID: 5172
		// (get) Token: 0x060048FC RID: 18684 RVA: 0x0011E1FC File Offset: 0x0011C3FC
		public int StatusId
		{
			[CompilerGenerated]
			get
			{
				return this.<StatusId>k__BackingField;
			}
		}

		// Token: 0x17001435 RID: 5173
		// (get) Token: 0x060048FD RID: 18685 RVA: 0x0011E210 File Offset: 0x0011C410
		public int UserId
		{
			[CompilerGenerated]
			get
			{
				return this.<UserId>k__BackingField;
			}
		}

		// Token: 0x17001436 RID: 5174
		// (get) Token: 0x060048FE RID: 18686 RVA: 0x0011E224 File Offset: 0x0011C424
		public int? ManagerId
		{
			[CompilerGenerated]
			get
			{
				return this.<ManagerId>k__BackingField;
			}
		}

		// Token: 0x17001437 RID: 5175
		// (get) Token: 0x060048FF RID: 18687 RVA: 0x0011E238 File Offset: 0x0011C438
		public int? MasterId
		{
			[CompilerGenerated]
			get
			{
				return this.<MasterId>k__BackingField;
			}
		}

		// Token: 0x06004900 RID: 18688 RVA: 0x000046B4 File Offset: 0x000028B4
		public RepairStatusLogModel()
		{
		}

		// Token: 0x06004901 RID: 18689 RVA: 0x0011E24C File Offset: 0x0011C44C
		public RepairStatusLogModel(workshop repair)
		{
			this.RepairId = repair.id;
			this.StatusId = repair.state;
			this.UserId = OfflineData.Instance.Employee.Id;
			this.ManagerId = new int?(repair.manager);
			this.MasterId = repair.master;
		}

		// Token: 0x04002E6F RID: 11887
		[CompilerGenerated]
		private readonly int <RepairId>k__BackingField;

		// Token: 0x04002E70 RID: 11888
		[CompilerGenerated]
		private readonly int <StatusId>k__BackingField;

		// Token: 0x04002E71 RID: 11889
		[CompilerGenerated]
		private readonly int <UserId>k__BackingField;

		// Token: 0x04002E72 RID: 11890
		[CompilerGenerated]
		private readonly int? <ManagerId>k__BackingField;

		// Token: 0x04002E73 RID: 11891
		[CompilerGenerated]
		private readonly int? <MasterId>k__BackingField;
	}
}
