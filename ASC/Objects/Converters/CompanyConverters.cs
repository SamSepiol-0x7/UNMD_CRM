using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace ASC.Objects.Converters
{
	// Token: 0x02000924 RID: 2340
	public static class CompanyConverters
	{
		// Token: 0x06004826 RID: 18470 RVA: 0x0011A500 File Offset: 0x00118700
		public static Expression<Func<companies, Company>> CompaniesSelector()
		{
			ParameterExpression parameterExpression;
			return Expression.Lambda<Func<companies, Company>>(Expression.MemberInit(Expression.New(typeof(Company)), new MemberBinding[]
			{
				Expression.Bind(methodof(Company.set_Id(int)), Expression.Property(parameterExpression, methodof(companies.get_id()))),
				Expression.Bind(methodof(Company.set_Name(string)), Expression.Property(parameterExpression, methodof(companies.get_name()))),
				Expression.Bind(methodof(Company.set_IsArchive(bool)), Expression.Not(Expression.Property(parameterExpression, methodof(companies.get_status())))),
				Expression.Bind(methodof(Company.set_Description(string)), Expression.Property(parameterExpression, methodof(companies.get_description()))),
				Expression.Bind(methodof(Company.set_Email(string)), Expression.Property(parameterExpression, methodof(companies.get_email()))),
				Expression.Bind(methodof(Company.set_Site(string)), Expression.Property(parameterExpression, methodof(companies.get_site()))),
				Expression.Bind(methodof(Company.set_Inn(string)), Expression.Property(parameterExpression, methodof(companies.get_inn()))),
				Expression.Bind(methodof(Company.set_Kpp(string)), Expression.Property(parameterExpression, methodof(companies.get_kpp()))),
				Expression.Bind(methodof(Company.set_Ogrn(string)), Expression.Property(parameterExpression, methodof(companies.get_ogrn())))
			}), new ParameterExpression[]
			{
				parameterExpression
			});
		}

		// Token: 0x06004827 RID: 18471 RVA: 0x0011A6E0 File Offset: 0x001188E0
		public static Company ToCompany(this companies c)
		{
			return new Company
			{
				Id = c.id,
				Name = c.name,
				IsArchive = !c.status,
				Description = c.description,
				Email = c.email,
				Site = c.site,
				Accountant = c.users1.User2Employee(),
				Inn = c.inn,
				Kpp = c.kpp,
				Ogrn = c.ogrn
			};
		}

		// Token: 0x02000925 RID: 2341
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004828 RID: 18472 RVA: 0x0011A774 File Offset: 0x00118974
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004829 RID: 18473 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x04002E10 RID: 11792
			public static readonly CompanyConverters.<>c <>9 = new CompanyConverters.<>c();
		}
	}
}
