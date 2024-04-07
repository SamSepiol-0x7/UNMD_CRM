using System;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x02000042 RID: 66
	public class hooks
	{
		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x0000DE54 File Offset: 0x0000C054
		// (set) Token: 0x060005E5 RID: 1509 RVA: 0x0000DE68 File Offset: 0x0000C068
		public long id
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

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x0000DE7C File Offset: 0x0000C07C
		// (set) Token: 0x060005E7 RID: 1511 RVA: 0x0000DE90 File Offset: 0x0000C090
		public long hook_id
		{
			[CompilerGenerated]
			get
			{
				return this.<hook_id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<hook_id>k__BackingField = value;
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x0000DEA4 File Offset: 0x0000C0A4
		// (set) Token: 0x060005E9 RID: 1513 RVA: 0x0000DEB8 File Offset: 0x0000C0B8
		public long status
		{
			[CompilerGenerated]
			get
			{
				return this.<status>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<status>k__BackingField = value;
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x0000DECC File Offset: 0x0000C0CC
		// (set) Token: 0x060005EB RID: 1515 RVA: 0x0000DEE0 File Offset: 0x0000C0E0
		public DateTime? created_at
		{
			[CompilerGenerated]
			get
			{
				return this.<created_at>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<created_at>k__BackingField = value;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x0000DEF4 File Offset: 0x0000C0F4
		// (set) Token: 0x060005ED RID: 1517 RVA: 0x0000DF08 File Offset: 0x0000C108
		public DateTime? updated_at
		{
			[CompilerGenerated]
			get
			{
				return this.<updated_at>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<updated_at>k__BackingField = value;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x060005EE RID: 1518 RVA: 0x0000DF1C File Offset: 0x0000C11C
		// (set) Token: 0x060005EF RID: 1519 RVA: 0x0000DF30 File Offset: 0x0000C130
		public string @event
		{
			[CompilerGenerated]
			get
			{
				return this.<event>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<event>k__BackingField = value;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x060005F0 RID: 1520 RVA: 0x0000DF44 File Offset: 0x0000C144
		// (set) Token: 0x060005F1 RID: 1521 RVA: 0x0000DF58 File Offset: 0x0000C158
		public long? p0
		{
			[CompilerGenerated]
			get
			{
				return this.<p0>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<p0>k__BackingField = value;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x0000DF6C File Offset: 0x0000C16C
		// (set) Token: 0x060005F3 RID: 1523 RVA: 0x0000DF80 File Offset: 0x0000C180
		public string prm
		{
			[CompilerGenerated]
			get
			{
				return this.<prm>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<prm>k__BackingField = value;
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x0000DF94 File Offset: 0x0000C194
		// (set) Token: 0x060005F5 RID: 1525 RVA: 0x0000DFA8 File Offset: 0x0000C1A8
		public int? task_id
		{
			[CompilerGenerated]
			get
			{
				return this.<task_id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<task_id>k__BackingField = value;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x0000DFBC File Offset: 0x0000C1BC
		// (set) Token: 0x060005F7 RID: 1527 RVA: 0x0000DFD0 File Offset: 0x0000C1D0
		public virtual tasks tasks
		{
			[CompilerGenerated]
			get
			{
				return this.<tasks>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<tasks>k__BackingField = value;
			}
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x000046B4 File Offset: 0x000028B4
		public hooks()
		{
		}

		// Token: 0x040002CF RID: 719
		[CompilerGenerated]
		private long <id>k__BackingField;

		// Token: 0x040002D0 RID: 720
		[CompilerGenerated]
		private long <hook_id>k__BackingField;

		// Token: 0x040002D1 RID: 721
		[CompilerGenerated]
		private long <status>k__BackingField;

		// Token: 0x040002D2 RID: 722
		[CompilerGenerated]
		private DateTime? <created_at>k__BackingField;

		// Token: 0x040002D3 RID: 723
		[CompilerGenerated]
		private DateTime? <updated_at>k__BackingField;

		// Token: 0x040002D4 RID: 724
		[CompilerGenerated]
		private string <event>k__BackingField;

		// Token: 0x040002D5 RID: 725
		[CompilerGenerated]
		private long? <p0>k__BackingField;

		// Token: 0x040002D6 RID: 726
		[CompilerGenerated]
		private string <prm>k__BackingField;

		// Token: 0x040002D7 RID: 727
		[CompilerGenerated]
		private int? <task_id>k__BackingField;

		// Token: 0x040002D8 RID: 728
		[CompilerGenerated]
		private tasks <tasks>k__BackingField;
	}
}
