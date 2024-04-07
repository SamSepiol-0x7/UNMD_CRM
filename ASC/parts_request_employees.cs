using System;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x02000055 RID: 85
	public class parts_request_employees
	{
		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x0001183C File Offset: 0x0000FA3C
		// (set) Token: 0x06000872 RID: 2162 RVA: 0x00011850 File Offset: 0x0000FA50
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

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x00011864 File Offset: 0x0000FA64
		// (set) Token: 0x06000874 RID: 2164 RVA: 0x00011878 File Offset: 0x0000FA78
		public int emploee
		{
			[CompilerGenerated]
			get
			{
				return this.<emploee>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<emploee>k__BackingField = value;
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x0001188C File Offset: 0x0000FA8C
		// (set) Token: 0x06000876 RID: 2166 RVA: 0x000118A0 File Offset: 0x0000FAA0
		public int request
		{
			[CompilerGenerated]
			get
			{
				return this.<request>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<request>k__BackingField = value;
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x000118B4 File Offset: 0x0000FAB4
		// (set) Token: 0x06000878 RID: 2168 RVA: 0x000118C8 File Offset: 0x0000FAC8
		public virtual parts_request parts_request
		{
			[CompilerGenerated]
			get
			{
				return this.<parts_request>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<parts_request>k__BackingField = value;
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x000118DC File Offset: 0x0000FADC
		// (set) Token: 0x0600087A RID: 2170 RVA: 0x000118F0 File Offset: 0x0000FAF0
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

		// Token: 0x0600087B RID: 2171 RVA: 0x000046B4 File Offset: 0x000028B4
		public parts_request_employees()
		{
		}

		// Token: 0x04000408 RID: 1032
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x04000409 RID: 1033
		[CompilerGenerated]
		private int <emploee>k__BackingField;

		// Token: 0x0400040A RID: 1034
		[CompilerGenerated]
		private int <request>k__BackingField;

		// Token: 0x0400040B RID: 1035
		[CompilerGenerated]
		private parts_request <parts_request>k__BackingField;

		// Token: 0x0400040C RID: 1036
		[CompilerGenerated]
		private users <users>k__BackingField;
	}
}
