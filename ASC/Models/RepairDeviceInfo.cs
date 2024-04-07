using System;
using System.Runtime.CompilerServices;

namespace ASC.Models
{
	// Token: 0x02000946 RID: 2374
	public class RepairDeviceInfo
	{
		// Token: 0x17001429 RID: 5161
		// (get) Token: 0x060048E4 RID: 18660 RVA: 0x0011E058 File Offset: 0x0011C258
		// (set) Token: 0x060048E5 RID: 18661 RVA: 0x0011E06C File Offset: 0x0011C26C
		public string Type
		{
			[CompilerGenerated]
			get
			{
				return this.<Type>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Type>k__BackingField = value;
			}
		}

		// Token: 0x1700142A RID: 5162
		// (get) Token: 0x060048E6 RID: 18662 RVA: 0x0011E080 File Offset: 0x0011C280
		// (set) Token: 0x060048E7 RID: 18663 RVA: 0x0011E094 File Offset: 0x0011C294
		public string Brand
		{
			[CompilerGenerated]
			get
			{
				return this.<Brand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Brand>k__BackingField = value;
			}
		}

		// Token: 0x1700142B RID: 5163
		// (get) Token: 0x060048E8 RID: 18664 RVA: 0x0011E0A8 File Offset: 0x0011C2A8
		// (set) Token: 0x060048E9 RID: 18665 RVA: 0x0011E0BC File Offset: 0x0011C2BC
		public string Model
		{
			[CompilerGenerated]
			get
			{
				return this.<Model>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Model>k__BackingField = value;
			}
		}

		// Token: 0x060048EA RID: 18666 RVA: 0x000046B4 File Offset: 0x000028B4
		public RepairDeviceInfo()
		{
		}

		// Token: 0x04002E65 RID: 11877
		[CompilerGenerated]
		private string <Type>k__BackingField;

		// Token: 0x04002E66 RID: 11878
		[CompilerGenerated]
		private string <Brand>k__BackingField;

		// Token: 0x04002E67 RID: 11879
		[CompilerGenerated]
		private string <Model>k__BackingField;
	}
}
