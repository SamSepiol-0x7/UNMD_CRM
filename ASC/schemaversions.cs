using System;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x0200006E RID: 110
	public class schemaversions
	{
		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06000B90 RID: 2960 RVA: 0x000159A4 File Offset: 0x00013BA4
		// (set) Token: 0x06000B91 RID: 2961 RVA: 0x000159B8 File Offset: 0x00013BB8
		public int schemaversionid
		{
			[CompilerGenerated]
			get
			{
				return this.<schemaversionid>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<schemaversionid>k__BackingField = value;
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06000B92 RID: 2962 RVA: 0x000159CC File Offset: 0x00013BCC
		// (set) Token: 0x06000B93 RID: 2963 RVA: 0x000159E0 File Offset: 0x00013BE0
		public string scriptname
		{
			[CompilerGenerated]
			get
			{
				return this.<scriptname>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<scriptname>k__BackingField = value;
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06000B94 RID: 2964 RVA: 0x000159F4 File Offset: 0x00013BF4
		// (set) Token: 0x06000B95 RID: 2965 RVA: 0x00015A08 File Offset: 0x00013C08
		public DateTime applied
		{
			[CompilerGenerated]
			get
			{
				return this.<applied>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<applied>k__BackingField = value;
			}
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x000046B4 File Offset: 0x000028B4
		public schemaversions()
		{
		}

		// Token: 0x04000581 RID: 1409
		[CompilerGenerated]
		private int <schemaversionid>k__BackingField;

		// Token: 0x04000582 RID: 1410
		[CompilerGenerated]
		private string <scriptname>k__BackingField;

		// Token: 0x04000583 RID: 1411
		[CompilerGenerated]
		private DateTime <applied>k__BackingField;
	}
}
