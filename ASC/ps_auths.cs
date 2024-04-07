using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x0200005E RID: 94
	public class ps_auths
	{
		// Token: 0x0600091C RID: 2332 RVA: 0x00012904 File Offset: 0x00010B04
		public ps_auths()
		{
			this.users = new HashSet<users>();
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x00012924 File Offset: 0x00010B24
		// (set) Token: 0x0600091E RID: 2334 RVA: 0x00012938 File Offset: 0x00010B38
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

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x0600091F RID: 2335 RVA: 0x0001294C File Offset: 0x00010B4C
		// (set) Token: 0x06000920 RID: 2336 RVA: 0x00012960 File Offset: 0x00010B60
		public string auth_type
		{
			[CompilerGenerated]
			get
			{
				return this.<auth_type>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<auth_type>k__BackingField = value;
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x00012974 File Offset: 0x00010B74
		// (set) Token: 0x06000922 RID: 2338 RVA: 0x00012988 File Offset: 0x00010B88
		public int? nonce_lifetime
		{
			[CompilerGenerated]
			get
			{
				return this.<nonce_lifetime>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<nonce_lifetime>k__BackingField = value;
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x0001299C File Offset: 0x00010B9C
		// (set) Token: 0x06000924 RID: 2340 RVA: 0x000129B0 File Offset: 0x00010BB0
		public string md5_cred
		{
			[CompilerGenerated]
			get
			{
				return this.<md5_cred>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<md5_cred>k__BackingField = value;
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000925 RID: 2341 RVA: 0x000129C4 File Offset: 0x00010BC4
		// (set) Token: 0x06000926 RID: 2342 RVA: 0x000129D8 File Offset: 0x00010BD8
		public string password
		{
			[CompilerGenerated]
			get
			{
				return this.<password>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<password>k__BackingField = value;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x000129EC File Offset: 0x00010BEC
		// (set) Token: 0x06000928 RID: 2344 RVA: 0x00012A00 File Offset: 0x00010C00
		public string realm
		{
			[CompilerGenerated]
			get
			{
				return this.<realm>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<realm>k__BackingField = value;
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x00012A14 File Offset: 0x00010C14
		// (set) Token: 0x0600092A RID: 2346 RVA: 0x00012A28 File Offset: 0x00010C28
		public string username
		{
			[CompilerGenerated]
			get
			{
				return this.<username>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<username>k__BackingField = value;
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x00012A3C File Offset: 0x00010C3C
		// (set) Token: 0x0600092C RID: 2348 RVA: 0x00012A50 File Offset: 0x00010C50
		public virtual ICollection<users> users
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

		// Token: 0x04000450 RID: 1104
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x04000451 RID: 1105
		[CompilerGenerated]
		private string <auth_type>k__BackingField;

		// Token: 0x04000452 RID: 1106
		[CompilerGenerated]
		private int? <nonce_lifetime>k__BackingField;

		// Token: 0x04000453 RID: 1107
		[CompilerGenerated]
		private string <md5_cred>k__BackingField;

		// Token: 0x04000454 RID: 1108
		[CompilerGenerated]
		private string <password>k__BackingField;

		// Token: 0x04000455 RID: 1109
		[CompilerGenerated]
		private string <realm>k__BackingField;

		// Token: 0x04000456 RID: 1110
		[CompilerGenerated]
		private string <username>k__BackingField;

		// Token: 0x04000457 RID: 1111
		[CompilerGenerated]
		private ICollection<users> <users>k__BackingField;
	}
}
