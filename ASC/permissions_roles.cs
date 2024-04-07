using System;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x0200005A RID: 90
	public class permissions_roles
	{
		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x00012214 File Offset: 0x00010414
		// (set) Token: 0x060008C7 RID: 2247 RVA: 0x00012228 File Offset: 0x00010428
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

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x0001223C File Offset: 0x0001043C
		// (set) Token: 0x060008C9 RID: 2249 RVA: 0x00012250 File Offset: 0x00010450
		public int permission_id
		{
			[CompilerGenerated]
			get
			{
				return this.<permission_id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<permission_id>k__BackingField = value;
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x00012264 File Offset: 0x00010464
		// (set) Token: 0x060008CB RID: 2251 RVA: 0x00012278 File Offset: 0x00010478
		public int role_id
		{
			[CompilerGenerated]
			get
			{
				return this.<role_id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<role_id>k__BackingField = value;
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x060008CC RID: 2252 RVA: 0x0001228C File Offset: 0x0001048C
		// (set) Token: 0x060008CD RID: 2253 RVA: 0x000122A0 File Offset: 0x000104A0
		public virtual permissions permissions
		{
			[CompilerGenerated]
			get
			{
				return this.<permissions>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<permissions>k__BackingField = value;
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x060008CE RID: 2254 RVA: 0x000122B4 File Offset: 0x000104B4
		// (set) Token: 0x060008CF RID: 2255 RVA: 0x000122C8 File Offset: 0x000104C8
		public virtual roles roles
		{
			[CompilerGenerated]
			get
			{
				return this.<roles>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<roles>k__BackingField = value;
			}
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x000046B4 File Offset: 0x000028B4
		public permissions_roles()
		{
		}

		// Token: 0x04000428 RID: 1064
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x04000429 RID: 1065
		[CompilerGenerated]
		private int <permission_id>k__BackingField;

		// Token: 0x0400042A RID: 1066
		[CompilerGenerated]
		private int <role_id>k__BackingField;

		// Token: 0x0400042B RID: 1067
		[CompilerGenerated]
		private permissions <permissions>k__BackingField;

		// Token: 0x0400042C RID: 1068
		[CompilerGenerated]
		private roles <roles>k__BackingField;
	}
}
