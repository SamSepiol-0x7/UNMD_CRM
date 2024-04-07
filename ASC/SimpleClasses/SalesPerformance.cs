using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC.SimpleClasses
{
	// Token: 0x02000211 RID: 529
	public class SalesPerformance
	{
		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06001C10 RID: 7184 RVA: 0x0005291C File Offset: 0x00050B1C
		// (set) Token: 0x06001C11 RID: 7185 RVA: 0x00052930 File Offset: 0x00050B30
		public string SalesName
		{
			[CompilerGenerated]
			get
			{
				return this.<SalesName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<SalesName>k__BackingField = value;
			}
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06001C12 RID: 7186 RVA: 0x00052944 File Offset: 0x00050B44
		// (set) Token: 0x06001C13 RID: 7187 RVA: 0x00052958 File Offset: 0x00050B58
		public List<SalesInfo> SalesTotals
		{
			[CompilerGenerated]
			get
			{
				return this.<SalesTotals>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<SalesTotals>k__BackingField = value;
			}
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x000046B4 File Offset: 0x000028B4
		public SalesPerformance()
		{
		}

		// Token: 0x04000ECC RID: 3788
		[CompilerGenerated]
		private string <SalesName>k__BackingField;

		// Token: 0x04000ECD RID: 3789
		[CompilerGenerated]
		private List<SalesInfo> <SalesTotals>k__BackingField;
	}
}
