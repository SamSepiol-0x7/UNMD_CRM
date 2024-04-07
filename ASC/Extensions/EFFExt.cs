using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using NLog;

namespace ASC.Extensions
{
	// Token: 0x02000B79 RID: 2937
	public static class EFFExt
	{
		// Token: 0x06005203 RID: 20995 RVA: 0x0016067C File Offset: 0x0015E87C
		public static IQueryable<T> WhereIf<T>(this IQueryable<T> source, bool condition, Expression<Func<T, bool>> predicate)
		{
			if (condition)
			{
				return source.Where(predicate);
			}
			return source;
		}

		// Token: 0x06005204 RID: 20996 RVA: 0x00160698 File Offset: 0x0015E898
		public static List<T> ToListSafe<T>(this IOrderedQueryable<T> input)
		{
			List<T> result;
			try
			{
				result = input.ToList<T>();
			}
			catch (Exception value)
			{
				EFFExt.Log.Error<Exception>(value);
				result = new List<T>();
			}
			return result;
		}

		// Token: 0x06005205 RID: 20997 RVA: 0x001606D4 File Offset: 0x0015E8D4
		public static List<T> ToListSafe<T>(this IQueryable<T> input)
		{
			List<T> result;
			try
			{
				result = input.ToList<T>();
			}
			catch (DbException value)
			{
				EFFExt.Log.Error<DbException>(value);
				result = new List<T>();
			}
			catch (Exception value2)
			{
				EFFExt.Log.Error<Exception>(value2);
				result = new List<T>();
			}
			return result;
		}

		// Token: 0x06005206 RID: 20998 RVA: 0x00160730 File Offset: 0x0015E930
		public static void DetachAll(this auseceEntities context)
		{
			foreach (DbEntityEntry dbEntityEntry in context.ChangeTracker.Entries())
			{
				if (dbEntityEntry.Entity != null)
				{
					dbEntityEntry.State = EntityState.Detached;
				}
			}
		}

		// Token: 0x06005207 RID: 20999 RVA: 0x0016078C File Offset: 0x0015E98C
		public static void UnchangedAll(this auseceEntities context)
		{
			foreach (DbEntityEntry dbEntityEntry in context.ChangeTracker.Entries())
			{
				if (dbEntityEntry.Entity != null)
				{
					dbEntityEntry.State = EntityState.Unchanged;
				}
			}
		}

		// Token: 0x06005208 RID: 21000 RVA: 0x001607E8 File Offset: 0x0015E9E8
		// Note: this type is marked as 'beforefieldinit'.
		static EFFExt()
		{
		}

		// Token: 0x040035D0 RID: 13776
		private static readonly ILogger Log = LogManager.GetCurrentClassLogger();
	}
}
