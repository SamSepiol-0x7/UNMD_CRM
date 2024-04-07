using System;
using System.Runtime.CompilerServices;
using ASC.Services.Abstract;
using NLog;

namespace ASC.Services.Concrete
{
	// Token: 0x02000733 RID: 1843
	public class LoggerService<T> : ILoggerService<T>
	{
		// Token: 0x1700109A RID: 4250
		// (get) Token: 0x06003A63 RID: 14947 RVA: 0x000DFF58 File Offset: 0x000DE158
		// (set) Token: 0x06003A64 RID: 14948 RVA: 0x000DFF6C File Offset: 0x000DE16C
		public ILogger logger
		{
			[CompilerGenerated]
			get
			{
				return this.<logger>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<logger>k__BackingField = value;
			}
		}

		// Token: 0x06003A65 RID: 14949 RVA: 0x000DFF80 File Offset: 0x000DE180
		public LoggerService()
		{
			this.logger = LogManager.GetLogger(typeof(T).Name);
		}

		// Token: 0x06003A66 RID: 14950 RVA: 0x000DFFB0 File Offset: 0x000DE1B0
		public void Debug(string message)
		{
			this.logger.Debug(message);
		}

		// Token: 0x06003A67 RID: 14951 RVA: 0x000DFFCC File Offset: 0x000DE1CC
		public void Debug(Exception e, string message)
		{
			this.logger.Debug(e, message);
		}

		// Token: 0x06003A68 RID: 14952 RVA: 0x000DFFE8 File Offset: 0x000DE1E8
		public void Info(string message)
		{
			this.logger.Info(message);
		}

		// Token: 0x06003A69 RID: 14953 RVA: 0x000E0004 File Offset: 0x000DE204
		public void Error(Exception e, string message)
		{
			this.logger.Error(e, message);
		}

		// Token: 0x04002573 RID: 9587
		[CompilerGenerated]
		private ILogger <logger>k__BackingField;
	}
}
