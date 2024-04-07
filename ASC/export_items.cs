using System;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x0200003F RID: 63
	public class export_items
	{
		// Token: 0x170002AE RID: 686
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x0000D928 File Offset: 0x0000BB28
		// (set) Token: 0x060005B2 RID: 1458 RVA: 0x0000D93C File Offset: 0x0000BB3C
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

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x0000D950 File Offset: 0x0000BB50
		// (set) Token: 0x060005B4 RID: 1460 RVA: 0x0000D964 File Offset: 0x0000BB64
		public int item_id
		{
			[CompilerGenerated]
			get
			{
				return this.<item_id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<item_id>k__BackingField = value;
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x0000D978 File Offset: 0x0000BB78
		// (set) Token: 0x060005B6 RID: 1462 RVA: 0x0000D98C File Offset: 0x0000BB8C
		public int state
		{
			[CompilerGenerated]
			get
			{
				return this.<state>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<state>k__BackingField = value;
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x0000D9A0 File Offset: 0x0000BBA0
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x0000D9B4 File Offset: 0x0000BBB4
		public DateTime sync_datetime
		{
			[CompilerGenerated]
			get
			{
				return this.<sync_datetime>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<sync_datetime>k__BackingField = value;
			}
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x000046B4 File Offset: 0x000028B4
		public export_items()
		{
		}

		// Token: 0x040002B8 RID: 696
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x040002B9 RID: 697
		[CompilerGenerated]
		private int <item_id>k__BackingField;

		// Token: 0x040002BA RID: 698
		[CompilerGenerated]
		private int <state>k__BackingField;

		// Token: 0x040002BB RID: 699
		[CompilerGenerated]
		private DateTime <sync_datetime>k__BackingField;
	}
}
