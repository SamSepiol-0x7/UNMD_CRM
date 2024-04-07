using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.SimpleClasses;

namespace ASC.Models
{
	// Token: 0x02000981 RID: 2433
	public class OfficesModel : CompaniesModel
	{
		// Token: 0x060049D8 RID: 18904 RVA: 0x001252F8 File Offset: 0x001234F8
		public static List<IdNameClass> LoadOffices(bool includeAll = false)
		{
			List<IdNameClass> result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					ParameterExpression parameterExpression;
					List<IdNameClass> list = (from o in auseceEntities.offices
					where o.state == 1
					orderby o.name
					select o).Select(Expression.Lambda<Func<offices, IdNameClass>>(Expression.MemberInit(Expression.New(typeof(IdNameClass)), new MemberBinding[]
					{
						Expression.Bind(methodof(IdNameClass.set_Id(int)), Expression.Property(parameterExpression, methodof(offices.get_id()))),
						Expression.Bind(methodof(IdNameClass.set_Name(string)), Expression.Property(parameterExpression, methodof(offices.get_name())))
					}), new ParameterExpression[]
					{
						parameterExpression
					})).ToList<IdNameClass>();
					if (includeAll)
					{
						list.Insert(0, new IdNameClass
						{
							Id = 0,
							Name = Lang.t("All")
						});
					}
					result = list;
				}
			}
			catch (Exception exception)
			{
				CompaniesModel.Log.Error(exception, "Load offices error");
				result = new List<IdNameClass>();
			}
			return result;
		}

		// Token: 0x060049D9 RID: 18905 RVA: 0x001254D0 File Offset: 0x001236D0
		public static Task<List<offices>> LoadAllOffices(bool showArchive = false)
		{
			OfficesModel.<LoadAllOffices>d__1 <LoadAllOffices>d__;
			<LoadAllOffices>d__.<>t__builder = AsyncTaskMethodBuilder<List<offices>>.Create();
			<LoadAllOffices>d__.showArchive = showArchive;
			<LoadAllOffices>d__.<>1__state = -1;
			<LoadAllOffices>d__.<>t__builder.Start<OfficesModel.<LoadAllOffices>d__1>(ref <LoadAllOffices>d__);
			return <LoadAllOffices>d__.<>t__builder.Task;
		}

		// Token: 0x060049DA RID: 18906 RVA: 0x00125514 File Offset: 0x00123714
		public List<string> GetOfficeNamesById(List<int> officeIds)
		{
			List<string> result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					List<<>f__AnonymousType9<int, string>> offices = (from o in auseceEntities.offices
					where officeIds.Contains(o.id)
					select new
					{
						Id = o.id,
						Name = o.name
					}).ToList();
					result = (from office in officeIds
					select (from o in offices
					where o.Id == office
					select o.Name).FirstOrDefault<string>()).ToList<string>();
				}
			}
			catch (Exception exception)
			{
				CompaniesModel.Log.Error(exception, "Get office name error");
				result = new List<string>();
			}
			return result;
		}

		// Token: 0x060049DB RID: 18907 RVA: 0x001256F4 File Offset: 0x001238F4
		public OfficesModel()
		{
		}

		// Token: 0x02000982 RID: 2434
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060049DC RID: 18908 RVA: 0x00125708 File Offset: 0x00123908
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060049DD RID: 18909 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x060049DE RID: 18910 RVA: 0x00125720 File Offset: 0x00123920
			internal IOrderedQueryable<offices> <LoadAllOffices>b__1_0(IQueryable<offices> q)
			{
				return from d in q
				orderby d.name
				select d;
			}

			// Token: 0x060049DF RID: 18911 RVA: 0x00125720 File Offset: 0x00123920
			internal IOrderedQueryable<offices> <LoadAllOffices>b__1_3(IQueryable<offices> q)
			{
				return from d in q
				orderby d.name
				select d;
			}

			// Token: 0x060049E0 RID: 18912 RVA: 0x0012576C File Offset: 0x0012396C
			internal string <GetOfficeNamesById>b__2_4(<>f__AnonymousType9<int, string> o)
			{
				return o.Name;
			}

			// Token: 0x04002F24 RID: 12068
			public static readonly OfficesModel.<>c <>9 = new OfficesModel.<>c();

			// Token: 0x04002F25 RID: 12069
			public static Func<IQueryable<offices>, IOrderedQueryable<offices>> <>9__1_0;

			// Token: 0x04002F26 RID: 12070
			public static Func<IQueryable<offices>, IOrderedQueryable<offices>> <>9__1_3;

			// Token: 0x04002F27 RID: 12071
			public static Func<<>f__AnonymousType9<int, string>, string> <>9__2_4;
		}

		// Token: 0x02000983 RID: 2435
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadAllOffices>d__1 : IAsyncStateMachine
		{
			// Token: 0x060049E1 RID: 18913 RVA: 0x00125780 File Offset: 0x00123980
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<offices> result;
				try
				{
					if (num > 1)
					{
						this.<repo>5__2 = new GenericRepository<offices>();
					}
					try
					{
						TaskAwaiter<IEnumerable<offices>> awaiter;
						List<offices> list;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<IEnumerable<offices>>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
							}
							else if (!this.showArchive)
							{
								awaiter = this.<repo>5__2.GetAllAsync((offices o) => o.state == 1, new Func<IQueryable<offices>, IOrderedQueryable<offices>>(OfficesModel.<>c.<>9.<LoadAllOffices>b__1_3), "users").GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num3 = 1;
									num = 1;
									this.<>1__state = num3;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<offices>>, OfficesModel.<LoadAllOffices>d__1>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<repo>5__2.GetAllAsync(null, new Func<IQueryable<offices>, IOrderedQueryable<offices>>(OfficesModel.<>c.<>9.<LoadAllOffices>b__1_0), "users").GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num4 = 0;
									num = 0;
									this.<>1__state = num4;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<offices>>, OfficesModel.<LoadAllOffices>d__1>(ref awaiter, ref this);
									return;
								}
								goto IL_191;
							}
							list = new List<offices>(awaiter.GetResult());
							goto IL_19E;
						}
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<offices>>);
						int num5 = -1;
						num = -1;
						this.<>1__state = num5;
						IL_191:
						list = new List<offices>(awaiter.GetResult());
						IL_19E:
						result = list;
					}
					finally
					{
						if (num < 0 && this.<repo>5__2 != null)
						{
							((IDisposable)this.<repo>5__2).Dispose();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x060049E2 RID: 18914 RVA: 0x001259A8 File Offset: 0x00123BA8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002F28 RID: 12072
			public int <>1__state;

			// Token: 0x04002F29 RID: 12073
			public AsyncTaskMethodBuilder<List<offices>> <>t__builder;

			// Token: 0x04002F2A RID: 12074
			public bool showArchive;

			// Token: 0x04002F2B RID: 12075
			private GenericRepository<offices> <repo>5__2;

			// Token: 0x04002F2C RID: 12076
			private TaskAwaiter<IEnumerable<offices>> <>u__1;
		}

		// Token: 0x02000984 RID: 2436
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x060049E3 RID: 18915 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x04002F2D RID: 12077
			public List<int> officeIds;
		}

		// Token: 0x02000985 RID: 2437
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_1
		{
			// Token: 0x060049E4 RID: 18916 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass2_1()
			{
			}

			// Token: 0x060049E5 RID: 18917 RVA: 0x001259C4 File Offset: 0x00123BC4
			internal string <GetOfficeNamesById>b__2(int office)
			{
				OfficesModel.<>c__DisplayClass2_2 CS$<>8__locals1 = new OfficesModel.<>c__DisplayClass2_2();
				CS$<>8__locals1.office = office;
				return this.offices.Where(new Func<<>f__AnonymousType9<int, string>, bool>(CS$<>8__locals1.<GetOfficeNamesById>b__3)).Select(new Func<<>f__AnonymousType9<int, string>, string>(OfficesModel.<>c.<>9.<GetOfficeNamesById>b__2_4)).FirstOrDefault<string>();
			}

			// Token: 0x04002F2E RID: 12078
			public List<<>f__AnonymousType9<int, string>> offices;
		}

		// Token: 0x02000986 RID: 2438
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_2
		{
			// Token: 0x060049E6 RID: 18918 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass2_2()
			{
			}

			// Token: 0x060049E7 RID: 18919 RVA: 0x00125A20 File Offset: 0x00123C20
			internal bool <GetOfficeNamesById>b__3(<>f__AnonymousType9<int, string> o)
			{
				return o.Id == this.office;
			}

			// Token: 0x04002F2F RID: 12079
			public int office;
		}
	}
}
