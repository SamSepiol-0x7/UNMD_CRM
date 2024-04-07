using System;
using System.Runtime.CompilerServices;

namespace ASC.ItemsExport.Models
{
	// Token: 0x02000317 RID: 791
	public class Attribute
	{
		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x0600252E RID: 9518 RVA: 0x00072308 File Offset: 0x00070508
		// (set) Token: 0x0600252F RID: 9519 RVA: 0x0007231C File Offset: 0x0007051C
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.<Name>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x06002530 RID: 9520 RVA: 0x00072330 File Offset: 0x00070530
		// (set) Token: 0x06002531 RID: 9521 RVA: 0x00072344 File Offset: 0x00070544
		public string Value
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

		// Token: 0x06002532 RID: 9522 RVA: 0x000046B4 File Offset: 0x000028B4
		public Attribute()
		{
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x00072358 File Offset: 0x00070558
		public Attribute(string name, string value)
		{
			this.Name = name;
			this.Value = value;
		}

		// Token: 0x040013CA RID: 5066
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x040013CB RID: 5067
		[CompilerGenerated]
		private string <Value>k__BackingField;
	}
}
