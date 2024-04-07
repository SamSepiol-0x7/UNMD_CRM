using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;
using ASC.Common.Objects;
using ASC.Converters;

namespace ASC.Models
{
	// Token: 0x02000966 RID: 2406
	public class StatusCheckModel
	{
		// Token: 0x0600496F RID: 18799 RVA: 0x00121AA8 File Offset: 0x0011FCA8
		public static IEnumerable<ApiStatusCheck> GetApiStatusChecks(IPeriod period, string query)
		{
			DateTime from = period.From.Date;
			DateTime to = period.To.Date.AddDays(1.0).AddSeconds(-1.0);
			IEnumerable<ApiStatusCheck> result;
			using (GenericRepository<api_status_checks> genericRepository = new GenericRepository<api_status_checks>())
			{
				genericRepository.AsNoTracking();
				List<KeyValuePair<bool, Expression<Func<api_status_checks, bool>>>> filterList = new List<KeyValuePair<bool, Expression<Func<api_status_checks, bool>>>>
				{
					new KeyValuePair<bool, Expression<Func<api_status_checks, bool>>>(true, (api_status_checks r) => r.created >= from && r.created <= to),
					new KeyValuePair<bool, Expression<Func<api_status_checks, bool>>>(!string.IsNullOrEmpty(query), (api_status_checks r) => r.user_agent.Contains(query))
				};
				result = (from c in genericRepository.GetAll(filterList, delegate(IQueryable<api_status_checks> i)
				{
					return from c in i
					orderby c.id descending
					select c;
				}, "")
				select c.ToApiStatusCheck()).ToList<ApiStatusCheck>();
			}
			return result;
		}

		// Token: 0x06004970 RID: 18800 RVA: 0x000046B4 File Offset: 0x000028B4
		public StatusCheckModel()
		{
		}

		// Token: 0x02000967 RID: 2407
		[CompilerGenerated]
		private sealed class <>c__DisplayClass0_0
		{
			// Token: 0x06004971 RID: 18801 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass0_0()
			{
			}

			// Token: 0x04002EC4 RID: 11972
			public DateTime from;

			// Token: 0x04002EC5 RID: 11973
			public DateTime to;

			// Token: 0x04002EC6 RID: 11974
			public string query;
		}

		// Token: 0x02000968 RID: 2408
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004972 RID: 18802 RVA: 0x00121D00 File Offset: 0x0011FF00
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004973 RID: 18803 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06004974 RID: 18804 RVA: 0x00121D18 File Offset: 0x0011FF18
			internal IOrderedQueryable<api_status_checks> <GetApiStatusChecks>b__0_0(IQueryable<api_status_checks> i)
			{
				return from c in i
				orderby c.id descending
				select c;
			}

			// Token: 0x06004975 RID: 18805 RVA: 0x00121D64 File Offset: 0x0011FF64
			internal ApiStatusCheck <GetApiStatusChecks>b__0_1(api_status_checks c)
			{
				return c.ToApiStatusCheck();
			}

			// Token: 0x04002EC7 RID: 11975
			public static readonly StatusCheckModel.<>c <>9 = new StatusCheckModel.<>c();

			// Token: 0x04002EC8 RID: 11976
			public static Func<IQueryable<api_status_checks>, IOrderedQueryable<api_status_checks>> <>9__0_0;

			// Token: 0x04002EC9 RID: 11977
			public static Func<api_status_checks, ApiStatusCheck> <>9__0_1;
		}
	}
}
