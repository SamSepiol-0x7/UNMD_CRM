using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x0200006B RID: 107
	public class roles
	{
		// Token: 0x06000B5F RID: 2911 RVA: 0x000155E0 File Offset: 0x000137E0
		public roles()
		{
			this.permissions_roles = new HashSet<permissions_roles>();
			this.roles_users = new HashSet<roles_users>();
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06000B60 RID: 2912 RVA: 0x0001560C File Offset: 0x0001380C
		// (set) Token: 0x06000B61 RID: 2913 RVA: 0x00015620 File Offset: 0x00013820
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

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06000B62 RID: 2914 RVA: 0x00015634 File Offset: 0x00013834
		// (set) Token: 0x06000B63 RID: 2915 RVA: 0x00015648 File Offset: 0x00013848
		public string name
		{
			[CompilerGenerated]
			get
			{
				return this.<name>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<name>k__BackingField = value;
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06000B64 RID: 2916 RVA: 0x0001565C File Offset: 0x0001385C
		// (set) Token: 0x06000B65 RID: 2917 RVA: 0x00015670 File Offset: 0x00013870
		public string state
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

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06000B66 RID: 2918 RVA: 0x00015684 File Offset: 0x00013884
		// (set) Token: 0x06000B67 RID: 2919 RVA: 0x00015698 File Offset: 0x00013898
		public string description
		{
			[CompilerGenerated]
			get
			{
				return this.<description>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<description>k__BackingField = value;
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06000B68 RID: 2920 RVA: 0x000156AC File Offset: 0x000138AC
		// (set) Token: 0x06000B69 RID: 2921 RVA: 0x000156C0 File Offset: 0x000138C0
		public virtual ICollection<permissions_roles> permissions_roles
		{
			[CompilerGenerated]
			get
			{
				return this.<permissions_roles>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<permissions_roles>k__BackingField = value;
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06000B6A RID: 2922 RVA: 0x000156D4 File Offset: 0x000138D4
		// (set) Token: 0x06000B6B RID: 2923 RVA: 0x000156E8 File Offset: 0x000138E8
		public virtual ICollection<roles_users> roles_users
		{
			[CompilerGenerated]
			get
			{
				return this.<roles_users>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<roles_users>k__BackingField = value;
			}
		}

		// Token: 0x0400056A RID: 1386
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x0400056B RID: 1387
		[CompilerGenerated]
		private string <name>k__BackingField;

		// Token: 0x0400056C RID: 1388
		[CompilerGenerated]
		private string <state>k__BackingField;

		// Token: 0x0400056D RID: 1389
		[CompilerGenerated]
		private string <description>k__BackingField;

		// Token: 0x0400056E RID: 1390
		[CompilerGenerated]
		private ICollection<permissions_roles> <permissions_roles>k__BackingField;

		// Token: 0x0400056F RID: 1391
		[CompilerGenerated]
		private ICollection<roles_users> <roles_users>k__BackingField;
	}
}
