using System;
using System.Data.Entity;
using NLog;

namespace ASC.Models
{
	// Token: 0x02000963 RID: 2403
	public class ConfigModel
	{
		// Token: 0x0600495D RID: 18781 RVA: 0x001212A4 File Offset: 0x0011F4A4
		public static bool UpdateConfig(config c)
		{
			bool result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					using (DbContextTransaction dbContextTransaction = auseceEntities.Database.BeginTransaction())
					{
						try
						{
							config entity = auseceEntities.config.Find(new object[]
							{
								1
							});
							auseceEntities.Entry<config>(entity).CurrentValues.SetValues(c);
							auseceEntities.SaveChanges();
							dbContextTransaction.Commit();
						}
						catch (Exception ex)
						{
							ConfigModel.Log.Error(ex, ex.Message);
							dbContextTransaction.Rollback();
						}
					}
				}
				return true;
			}
			catch (Exception ex2)
			{
				ConfigModel.Log.Error(ex2, ex2.Message);
				result = false;
			}
			return result;
		}

		// Token: 0x0600495E RID: 18782 RVA: 0x000046B4 File Offset: 0x000028B4
		public ConfigModel()
		{
		}

		// Token: 0x0600495F RID: 18783 RVA: 0x00121388 File Offset: 0x0011F588
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigModel()
		{
		}

		// Token: 0x04002EBD RID: 11965
		private static readonly ILogger Log = LogManager.GetCurrentClassLogger();
	}
}
