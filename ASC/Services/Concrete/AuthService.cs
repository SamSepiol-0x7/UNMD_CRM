using System;
using ASC.Services.Abstract;

namespace ASC.Services.Concrete
{
	// Token: 0x020006DA RID: 1754
	public class AuthService : IAuthService
	{
		// Token: 0x0600397D RID: 14717 RVA: 0x000D6BE0 File Offset: 0x000D4DE0
		public users GetCurrentUser()
		{
			return Auth.User;
		}

		// Token: 0x0600397E RID: 14718 RVA: 0x000046B4 File Offset: 0x000028B4
		public AuthService()
		{
		}
	}
}
