using System;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;

namespace ASC.Objects
{
	// Token: 0x02000893 RID: 2195
	public class UsersActivity : IActivity
	{
		// Token: 0x1700123C RID: 4668
		// (get) Token: 0x060042A4 RID: 17060 RVA: 0x0010557C File Offset: 0x0010377C
		// (set) Token: 0x060042A5 RID: 17061 RVA: 0x00105590 File Offset: 0x00103790
		public int Id
		{
			[CompilerGenerated]
			get
			{
				return this.<Id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Id>k__BackingField = value;
			}
		}

		// Token: 0x1700123D RID: 4669
		// (get) Token: 0x060042A6 RID: 17062 RVA: 0x001055A4 File Offset: 0x001037A4
		// (set) Token: 0x060042A7 RID: 17063 RVA: 0x001055B8 File Offset: 0x001037B8
		public int EmployeeId
		{
			[CompilerGenerated]
			get
			{
				return this.<EmployeeId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<EmployeeId>k__BackingField = value;
			}
		}

		// Token: 0x1700123E RID: 4670
		// (get) Token: 0x060042A8 RID: 17064 RVA: 0x001055CC File Offset: 0x001037CC
		// (set) Token: 0x060042A9 RID: 17065 RVA: 0x001055E0 File Offset: 0x001037E0
		public DateTime DateTime
		{
			[CompilerGenerated]
			get
			{
				return this.<DateTime>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<DateTime>k__BackingField = value;
			}
		}

		// Token: 0x1700123F RID: 4671
		// (get) Token: 0x060042AA RID: 17066 RVA: 0x001055F4 File Offset: 0x001037F4
		// (set) Token: 0x060042AB RID: 17067 RVA: 0x00105608 File Offset: 0x00103808
		public string Notes
		{
			[CompilerGenerated]
			get
			{
				return this.<Notes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Notes>k__BackingField = value;
			}
		}

		// Token: 0x17001240 RID: 4672
		// (get) Token: 0x060042AC RID: 17068 RVA: 0x0010561C File Offset: 0x0010381C
		// (set) Token: 0x060042AD RID: 17069 RVA: 0x00105630 File Offset: 0x00103830
		public string AppVersion
		{
			[CompilerGenerated]
			get
			{
				return this.<AppVersion>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<AppVersion>k__BackingField = value;
			}
		}

		// Token: 0x17001241 RID: 4673
		// (get) Token: 0x060042AE RID: 17070 RVA: 0x00105644 File Offset: 0x00103844
		// (set) Token: 0x060042AF RID: 17071 RVA: 0x00105658 File Offset: 0x00103858
		public string Ip
		{
			[CompilerGenerated]
			get
			{
				return this.<Ip>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Ip>k__BackingField = value;
			}
		}

		// Token: 0x17001242 RID: 4674
		// (get) Token: 0x060042B0 RID: 17072 RVA: 0x0010566C File Offset: 0x0010386C
		// (set) Token: 0x060042B1 RID: 17073 RVA: 0x00105680 File Offset: 0x00103880
		public int Value
		{
			[CompilerGenerated]
			get
			{
				return this.<Value>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Value>k__BackingField = value;
			}
		}

		// Token: 0x060042B2 RID: 17074 RVA: 0x00105694 File Offset: 0x00103894
		public UsersActivity()
		{
			this.Value = 1;
		}

		// Token: 0x04002B19 RID: 11033
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04002B1A RID: 11034
		[CompilerGenerated]
		private int <EmployeeId>k__BackingField;

		// Token: 0x04002B1B RID: 11035
		[CompilerGenerated]
		private DateTime <DateTime>k__BackingField;

		// Token: 0x04002B1C RID: 11036
		[CompilerGenerated]
		private string <Notes>k__BackingField;

		// Token: 0x04002B1D RID: 11037
		[CompilerGenerated]
		private string <AppVersion>k__BackingField;

		// Token: 0x04002B1E RID: 11038
		[CompilerGenerated]
		private string <Ip>k__BackingField;

		// Token: 0x04002B1F RID: 11039
		[CompilerGenerated]
		private int <Value>k__BackingField;
	}
}
