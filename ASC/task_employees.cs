using System;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x0200007C RID: 124
	public class task_employees
	{
		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x06000EC7 RID: 3783 RVA: 0x0001BA1C File Offset: 0x00019C1C
		// (set) Token: 0x06000EC8 RID: 3784 RVA: 0x0001BA30 File Offset: 0x00019C30
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

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06000EC9 RID: 3785 RVA: 0x0001BA44 File Offset: 0x00019C44
		// (set) Token: 0x06000ECA RID: 3786 RVA: 0x0001BA58 File Offset: 0x00019C58
		public int employee
		{
			[CompilerGenerated]
			get
			{
				return this.<employee>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<employee>k__BackingField = value;
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06000ECB RID: 3787 RVA: 0x0001BA6C File Offset: 0x00019C6C
		// (set) Token: 0x06000ECC RID: 3788 RVA: 0x0001BA80 File Offset: 0x00019C80
		public int task
		{
			[CompilerGenerated]
			get
			{
				return this.<task>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<task>k__BackingField = value;
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06000ECD RID: 3789 RVA: 0x0001BA94 File Offset: 0x00019C94
		// (set) Token: 0x06000ECE RID: 3790 RVA: 0x0001BAA8 File Offset: 0x00019CA8
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

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06000ECF RID: 3791 RVA: 0x0001BABC File Offset: 0x00019CBC
		// (set) Token: 0x06000ED0 RID: 3792 RVA: 0x0001BAD0 File Offset: 0x00019CD0
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

		// Token: 0x06000ED1 RID: 3793 RVA: 0x000046B4 File Offset: 0x000028B4
		public task_employees()
		{
		}

		// Token: 0x040006F8 RID: 1784
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x040006F9 RID: 1785
		[CompilerGenerated]
		private int <employee>k__BackingField;

		// Token: 0x040006FA RID: 1786
		[CompilerGenerated]
		private int <task>k__BackingField;

		// Token: 0x040006FB RID: 1787
		[CompilerGenerated]
		private tasks <tasks>k__BackingField;

		// Token: 0x040006FC RID: 1788
		[CompilerGenerated]
		private users <users>k__BackingField;
	}
}
