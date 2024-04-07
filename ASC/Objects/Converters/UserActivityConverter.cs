using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace ASC.Objects.Converters
{
	// Token: 0x0200091D RID: 2333
	public static class UserActivityConverter
	{
		// Token: 0x06004819 RID: 18457 RVA: 0x0011997C File Offset: 0x00117B7C
		public static UsersActivity ToUsersActivity(this users_activity a)
		{
			return new UsersActivity
			{
				Id = a.id,
				DateTime = a.datetime_,
				EmployeeId = a.user_id,
				Ip = a.address,
				AppVersion = a.app_version,
				Notes = a.notes
			};
		}

		// Token: 0x0600481A RID: 18458 RVA: 0x001199D8 File Offset: 0x00117BD8
		public static Expression<Func<users_activity, UsersActivity>> ToDtoSelector()
		{
			ParameterExpression parameterExpression;
			return Expression.Lambda<Func<users_activity, UsersActivity>>(Expression.MemberInit(Expression.New(typeof(UsersActivity)), new MemberBinding[]
			{
				Expression.Bind(methodof(UsersActivity.set_Id(int)), Expression.Property(parameterExpression, methodof(users_activity.get_id()))),
				Expression.Bind(methodof(UsersActivity.set_DateTime(DateTime)), Expression.Property(parameterExpression, methodof(users_activity.get_datetime_()))),
				Expression.Bind(methodof(UsersActivity.set_EmployeeId(int)), Expression.Property(parameterExpression, methodof(users_activity.get_user_id()))),
				Expression.Bind(methodof(UsersActivity.set_Ip(string)), Expression.Property(parameterExpression, methodof(users_activity.get_address()))),
				Expression.Bind(methodof(UsersActivity.set_AppVersion(string)), Expression.Property(parameterExpression, methodof(users_activity.get_app_version()))),
				Expression.Bind(methodof(UsersActivity.set_Notes(string)), Expression.Property(parameterExpression, methodof(users_activity.get_notes())))
			}), new ParameterExpression[]
			{
				parameterExpression
			});
		}

		// Token: 0x0200091E RID: 2334
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600481B RID: 18459 RVA: 0x00119B2C File Offset: 0x00117D2C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600481C RID: 18460 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x04002E0F RID: 11791
			public static readonly UserActivityConverter.<>c <>9 = new UserActivityConverter.<>c();
		}
	}
}
