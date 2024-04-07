using System;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x02000058 RID: 88
	public class payment_type_users
	{
		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x000120B4 File Offset: 0x000102B4
		// (set) Token: 0x060008B5 RID: 2229 RVA: 0x000120C8 File Offset: 0x000102C8
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

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x060008B6 RID: 2230 RVA: 0x000120DC File Offset: 0x000102DC
		// (set) Token: 0x060008B7 RID: 2231 RVA: 0x000120F0 File Offset: 0x000102F0
		public int payment_type
		{
			[CompilerGenerated]
			get
			{
				return this.<payment_type>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<payment_type>k__BackingField = value;
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x060008B8 RID: 2232 RVA: 0x00012104 File Offset: 0x00010304
		// (set) Token: 0x060008B9 RID: 2233 RVA: 0x00012118 File Offset: 0x00010318
		public int user_id
		{
			[CompilerGenerated]
			get
			{
				return this.<user_id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<user_id>k__BackingField = value;
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x0001212C File Offset: 0x0001032C
		// (set) Token: 0x060008BB RID: 2235 RVA: 0x00012140 File Offset: 0x00010340
		public virtual users users
		{
			[CompilerGenerated]
			get
			{
				return this.<users>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<users>k__BackingField = value;
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x00012154 File Offset: 0x00010354
		// (set) Token: 0x060008BD RID: 2237 RVA: 0x00012168 File Offset: 0x00010368
		public virtual payment_types payment_types
		{
			[CompilerGenerated]
			get
			{
				return this.<payment_types>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<payment_types>k__BackingField = value;
			}
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x000046B4 File Offset: 0x000028B4
		public payment_type_users()
		{
		}

		// Token: 0x04000420 RID: 1056
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x04000421 RID: 1057
		[CompilerGenerated]
		private int <payment_type>k__BackingField;

		// Token: 0x04000422 RID: 1058
		[CompilerGenerated]
		private int <user_id>k__BackingField;

		// Token: 0x04000423 RID: 1059
		[CompilerGenerated]
		private users <users>k__BackingField;

		// Token: 0x04000424 RID: 1060
		[CompilerGenerated]
		private payment_types <payment_types>k__BackingField;
	}
}
