using System;
using System.Runtime.CompilerServices;

namespace ASC.Messages
{
	// Token: 0x020002FF RID: 767
	public class OpenCompanyEditMessage
	{
		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x06002497 RID: 9367 RVA: 0x0006EC80 File Offset: 0x0006CE80
		// (set) Token: 0x06002498 RID: 9368 RVA: 0x0006EC94 File Offset: 0x0006CE94
		public int CompanyId
		{
			[CompilerGenerated]
			get
			{
				return this.<CompanyId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<CompanyId>k__BackingField = value;
			}
		}

		// Token: 0x06002499 RID: 9369 RVA: 0x0006ECA8 File Offset: 0x0006CEA8
		public OpenCompanyEditMessage(int companyId)
		{
			this.CompanyId = companyId;
		}

		// Token: 0x04001361 RID: 4961
		[CompilerGenerated]
		private int <CompanyId>k__BackingField;
	}
}
