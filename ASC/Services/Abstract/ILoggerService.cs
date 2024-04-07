using System;

namespace ASC.Services.Abstract
{
	// Token: 0x020007EF RID: 2031
	public interface ILoggerService<T>
	{
		// Token: 0x06003CC2 RID: 15554
		void Debug(string message);

		// Token: 0x06003CC3 RID: 15555
		void Debug(Exception e, string message);

		// Token: 0x06003CC4 RID: 15556
		void Info(string message);

		// Token: 0x06003CC5 RID: 15557
		void Error(Exception e, string message);
	}
}
