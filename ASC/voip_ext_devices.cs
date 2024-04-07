using System;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x02000087 RID: 135
	public class voip_ext_devices
	{
		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x060010A5 RID: 4261 RVA: 0x0001E44C File Offset: 0x0001C64C
		// (set) Token: 0x060010A6 RID: 4262 RVA: 0x0001E460 File Offset: 0x0001C660
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

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x060010A7 RID: 4263 RVA: 0x0001E474 File Offset: 0x0001C674
		// (set) Token: 0x060010A8 RID: 4264 RVA: 0x0001E488 File Offset: 0x0001C688
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

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x060010A9 RID: 4265 RVA: 0x0001E49C File Offset: 0x0001C69C
		// (set) Token: 0x060010AA RID: 4266 RVA: 0x0001E4B0 File Offset: 0x0001C6B0
		public string phone
		{
			[CompilerGenerated]
			get
			{
				return this.<phone>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<phone>k__BackingField = value;
			}
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x000046B4 File Offset: 0x000028B4
		public voip_ext_devices()
		{
		}

		// Token: 0x040007DB RID: 2011
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x040007DC RID: 2012
		[CompilerGenerated]
		private string <name>k__BackingField;

		// Token: 0x040007DD RID: 2013
		[CompilerGenerated]
		private string <phone>k__BackingField;
	}
}
