using System;

namespace ASC.DAL
{
	// Token: 0x02000BD0 RID: 3024
	public class ContextFactory : IContextFactory
	{
		// Token: 0x0600547B RID: 21627 RVA: 0x0016BB54 File Offset: 0x00169D54
		public auseceEntities Create()
		{
			return new auseceEntities(true);
		}

		// Token: 0x0600547C RID: 21628 RVA: 0x000046B4 File Offset: 0x000028B4
		public ContextFactory()
		{
		}
	}
}
