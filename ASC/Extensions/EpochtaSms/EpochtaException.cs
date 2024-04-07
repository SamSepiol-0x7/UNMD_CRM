using System;

namespace ASC.Extensions.EpochtaSms
{
	// Token: 0x02000B82 RID: 2946
	public class EpochtaException : Exception
	{
		// Token: 0x0600522B RID: 21035 RVA: 0x00161200 File Offset: 0x0015F400
		public EpochtaException(int status)
		{
			EpochtaException.EpochtaExceptionKind epochtaExceptionKind = (EpochtaException.EpochtaExceptionKind)status;
			base..ctor(epochtaExceptionKind.ToString());
		}

		// Token: 0x02000B83 RID: 2947
		private enum EpochtaExceptionKind
		{
			// Token: 0x040035F3 RID: 13811
			UnknownError,
			// Token: 0x040035F4 RID: 13812
			AuthFailed = -1,
			// Token: 0x040035F5 RID: 13813
			XmlError = -2,
			// Token: 0x040035F6 RID: 13814
			NotEnoughCredits = -3,
			// Token: 0x040035F7 RID: 13815
			NoRecipients = -4,
			// Token: 0x040035F8 RID: 13816
			BadSenderName = -5
		}
	}
}
