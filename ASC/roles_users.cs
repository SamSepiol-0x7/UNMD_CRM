using System;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x0200006C RID: 108
	public class roles_users
	{
		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06000B6C RID: 2924 RVA: 0x000156FC File Offset: 0x000138FC
		// (set) Token: 0x06000B6D RID: 2925 RVA: 0x00015710 File Offset: 0x00013910
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

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06000B6E RID: 2926 RVA: 0x00015724 File Offset: 0x00013924
		// (set) Token: 0x06000B6F RID: 2927 RVA: 0x00015738 File Offset: 0x00013938
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

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06000B70 RID: 2928 RVA: 0x0001574C File Offset: 0x0001394C
		// (set) Token: 0x06000B71 RID: 2929 RVA: 0x00015760 File Offset: 0x00013960
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

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06000B72 RID: 2930 RVA: 0x00015774 File Offset: 0x00013974
		// (set) Token: 0x06000B73 RID: 2931 RVA: 0x00015788 File Offset: 0x00013988
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

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06000B74 RID: 2932 RVA: 0x0001579C File Offset: 0x0001399C
		// (set) Token: 0x06000B75 RID: 2933 RVA: 0x000157B0 File Offset: 0x000139B0
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

		// Token: 0x06000B76 RID: 2934 RVA: 0x000046B4 File Offset: 0x000028B4
		public roles_users()
		{
		}

		// Token: 0x04000570 RID: 1392
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x04000571 RID: 1393
		[CompilerGenerated]
		private int <user_id>k__BackingField;

		// Token: 0x04000572 RID: 1394
		[CompilerGenerated]
		private int <role_id>k__BackingField;

		// Token: 0x04000573 RID: 1395
		[CompilerGenerated]
		private roles <roles>k__BackingField;

		// Token: 0x04000574 RID: 1396
		[CompilerGenerated]
		private users <users>k__BackingField;
	}
}
