using System;
using System.Runtime.CompilerServices;

namespace ASC.Messages
{
	// Token: 0x02000301 RID: 769
	public class OpenOfficeEditMessage
	{
		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x0600249B RID: 9371 RVA: 0x0006ECC4 File Offset: 0x0006CEC4
		// (set) Token: 0x0600249C RID: 9372 RVA: 0x0006ECD8 File Offset: 0x0006CED8
		public int OfficeId
		{
			[CompilerGenerated]
			get
			{
				return this.<OfficeId>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<OfficeId>k__BackingField = value;
			}
		}

		// Token: 0x0600249D RID: 9373 RVA: 0x0006ECEC File Offset: 0x0006CEEC
		public OpenOfficeEditMessage(int officeId)
		{
			this.OfficeId = officeId;
		}

		// Token: 0x04001362 RID: 4962
		[CompilerGenerated]
		private int <OfficeId>k__BackingField;
	}
}
