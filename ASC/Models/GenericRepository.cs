using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Common.Repositories;
using ASC.Extensions;
using ASC.Objects;
using Autofac;

namespace ASC.Models
{
	// Token: 0x0200096E RID: 2414
	public class GenericRepository<T> : IRepository<T>, IDisposable where T : class
	{
		// Token: 0x0600498C RID: 18828 RVA: 0x00122628 File Offset: 0x00120828
		public GenericRepository()
		{
			this._context = Bootstrapper.Container.Resolve<auseceEntities>();
			this._entity = this._context.Set<T>();
		}

		// Token: 0x0600498D RID: 18829 RVA: 0x00122668 File Offset: 0x00120868
		public GenericRepository(auseceEntities context)
		{
			this._context = context;
			this._entity = this._context.Set<T>();
		}

		// Token: 0x0600498E RID: 18830 RVA: 0x001226A0 File Offset: 0x001208A0
		public void EnableLazyLoading()
		{
			this._context.Configuration.LazyLoadingEnabled = true;
		}

		// Token: 0x0600498F RID: 18831 RVA: 0x001226C0 File Offset: 0x001208C0
		public void AsNoTracking()
		{
			this._entity.AsNoTracking();
		}

		// Token: 0x06004990 RID: 18832 RVA: 0x001226DC File Offset: 0x001208DC
		public void DisableProxyCreation()
		{
			this._context.Configuration.ProxyCreationEnabled = false;
		}

		// Token: 0x06004991 RID: 18833 RVA: 0x001226FC File Offset: 0x001208FC
		public void SetTimeout(int timeout = 180)
		{
			this._context.Database.CommandTimeout = new int?(timeout);
		}

		// Token: 0x06004992 RID: 18834 RVA: 0x00122720 File Offset: 0x00120920
		public T GetFirstOrDefault(Expression<Func<T, bool>> filter, string includeProperties = "")
		{
			IQueryable<T> queryable = this._entity;
			queryable = this.Filter(filter, queryable);
			queryable = this.IncludeProperties(includeProperties, queryable);
			return queryable.FirstOrDefault<T>();
		}

		// Token: 0x06004993 RID: 18835 RVA: 0x0012274C File Offset: 0x0012094C
		public T GetFirstOrDefault(Expression<Func<T, bool>> filter, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy, string includeProperties = "")
		{
			IQueryable<T> queryable = this._entity;
			queryable = this.Filter(filter, queryable);
			queryable = this.IncludeProperties(includeProperties, queryable);
			if (orderBy != null)
			{
				return orderBy(queryable).FirstOrDefault<T>();
			}
			return queryable.FirstOrDefault<T>();
		}

		// Token: 0x06004994 RID: 18836 RVA: 0x00122788 File Offset: 0x00120988
		public IAscResult Update(T entity)
		{
			Result result = new Result();
			try
			{
				if (entity == null)
				{
					throw new ArgumentNullException("entity");
				}
				this._context.SaveChanges();
				result.SetSuccess();
			}
			catch (DbEntityValidationException ex)
			{
				foreach (DbEntityValidationResult dbEntityValidationResult in ex.EntityValidationErrors)
				{
					foreach (DbValidationError dbValidationError in dbEntityValidationResult.ValidationErrors)
					{
						this.errorMessage = this.errorMessage + Environment.NewLine + string.Format("Property: {0} Error: {1}", dbValidationError.PropertyName, dbValidationError.ErrorMessage);
					}
				}
				result.Message = this.errorMessage;
			}
			catch (Exception ex2)
			{
				Result result2 = result;
				result2.Message = result2.Message + Environment.NewLine + ex2.Message;
			}
			return result;
		}

		// Token: 0x06004995 RID: 18837 RVA: 0x001228A8 File Offset: 0x00120AA8
		private IQueryable<T> Filter(Expression<Func<T, bool>> filter, IQueryable<T> query)
		{
			if (filter != null)
			{
				query = query.Where(filter);
			}
			return query;
		}

		// Token: 0x06004996 RID: 18838 RVA: 0x001228C4 File Offset: 0x00120AC4
		private IQueryable<T> IncludeProperties(string includeProperties, IQueryable<T> query)
		{
			if (string.IsNullOrEmpty(includeProperties))
			{
				goto IL_08;
			}
			goto IL_6B;
			int num;
			string[] array;
			int num2;
			for (;;)
			{
				IL_44:
				switch ((num ^ 824390958) % 6)
				{
				case 0:
				{
					string path = array[num2];
					query = query.Include(path);
					num2++;
					num = 465594778;
					continue;
				}
				case 1:
					goto IL_6B;
				case 2:
					return query;
				case 4:
					num = ((num2 >= array.Length) ? 1785983057 : 1158101378);
					continue;
				case 5:
					goto IL_08;
				}
				break;
			}
			return query;
			IL_08:
			num = 2067917220;
			goto IL_44;
			IL_6B:
			array = includeProperties.Split(new char[]
			{
				','
			}, StringSplitOptions.RemoveEmptyEntries);
			num2 = 0;
			num = 465594778;
			goto IL_44;
		}

		// Token: 0x06004997 RID: 18839 RVA: 0x0012295C File Offset: 0x00120B5C
		public Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>> filter, string includeProperties = "")
		{
			GenericRepository<T>.<GetFirstOrDefaultAsync>d__14 <GetFirstOrDefaultAsync>d__;
			<GetFirstOrDefaultAsync>d__.<>t__builder = AsyncTaskMethodBuilder<T>.Create();
			<GetFirstOrDefaultAsync>d__.<>4__this = this;
			<GetFirstOrDefaultAsync>d__.filter = filter;
			<GetFirstOrDefaultAsync>d__.includeProperties = includeProperties;
			<GetFirstOrDefaultAsync>d__.<>1__state = -1;
			<GetFirstOrDefaultAsync>d__.<>t__builder.Start<GenericRepository<T>.<GetFirstOrDefaultAsync>d__14>(ref <GetFirstOrDefaultAsync>d__);
			return <GetFirstOrDefaultAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06004998 RID: 18840 RVA: 0x001229B0 File Offset: 0x00120BB0
		public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
		{
			IQueryable<T> queryable = this._entity;
			queryable = this.Filter(filter, queryable);
			queryable = this.IncludeProperties(includeProperties, queryable);
			if (orderBy != null)
			{
				return orderBy(queryable).ToList<T>();
			}
			return queryable.ToList<T>();
		}

		// Token: 0x06004999 RID: 18841 RVA: 0x001229EC File Offset: 0x00120BEC
		public IEnumerable<T> GetAll(List<KeyValuePair<bool, Expression<Func<T, bool>>>> filterList, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
		{
			IQueryable<T> queryable = this._entity;
			if (filterList != null)
			{
				foreach (KeyValuePair<bool, Expression<Func<T, bool>>> keyValuePair in filterList)
				{
					queryable = queryable.WhereIf(keyValuePair.Key, keyValuePair.Value);
				}
			}
			queryable = this.IncludeProperties(includeProperties, queryable);
			if (orderBy == null)
			{
				return queryable.ToList<T>();
			}
			return orderBy(queryable).ToList<T>();
		}

		// Token: 0x0600499A RID: 18842 RVA: 0x00122A74 File Offset: 0x00120C74
		public Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
		{
			GenericRepository<T>.<GetAllAsync>d__17 <GetAllAsync>d__;
			<GetAllAsync>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<T>>.Create();
			<GetAllAsync>d__.<>4__this = this;
			<GetAllAsync>d__.filter = filter;
			<GetAllAsync>d__.orderBy = orderBy;
			<GetAllAsync>d__.includeProperties = includeProperties;
			<GetAllAsync>d__.<>1__state = -1;
			<GetAllAsync>d__.<>t__builder.Start<GenericRepository<T>.<GetAllAsync>d__17>(ref <GetAllAsync>d__);
			return <GetAllAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600499B RID: 18843 RVA: 0x00122AD0 File Offset: 0x00120CD0
		public Task<IEnumerable<T>> GetAllAsync(List<KeyValuePair<bool, Expression<Func<T, bool>>>> filterList, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "", bool dnt = false)
		{
			GenericRepository<T>.<GetAllAsync>d__18 <GetAllAsync>d__;
			<GetAllAsync>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<T>>.Create();
			<GetAllAsync>d__.<>4__this = this;
			<GetAllAsync>d__.filterList = filterList;
			<GetAllAsync>d__.orderBy = orderBy;
			<GetAllAsync>d__.includeProperties = includeProperties;
			<GetAllAsync>d__.dnt = dnt;
			<GetAllAsync>d__.<>1__state = -1;
			<GetAllAsync>d__.<>t__builder.Start<GenericRepository<T>.<GetAllAsync>d__18>(ref <GetAllAsync>d__);
			return <GetAllAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600499C RID: 18844 RVA: 0x00122B34 File Offset: 0x00120D34
		public int Count(Expression<Func<T, bool>> filter = null)
		{
			IQueryable<T> queryable = this._entity;
			queryable = this.Filter(filter, queryable);
			return queryable.Count<T>();
		}

		// Token: 0x0600499D RID: 18845 RVA: 0x00122B58 File Offset: 0x00120D58
		public Task<int> CountAsync(Expression<Func<T, bool>> filter = null)
		{
			GenericRepository<T>.<CountAsync>d__20 <CountAsync>d__;
			<CountAsync>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<CountAsync>d__.<>4__this = this;
			<CountAsync>d__.filter = filter;
			<CountAsync>d__.<>1__state = -1;
			<CountAsync>d__.<>t__builder.Start<GenericRepository<T>.<CountAsync>d__20>(ref <CountAsync>d__);
			return <CountAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600499E RID: 18846 RVA: 0x00122BA4 File Offset: 0x00120DA4
		public bool Any(Expression<Func<T, bool>> filter = null)
		{
			IQueryable<T> queryable = this._entity;
			queryable = this.Filter(filter, queryable);
			return queryable.Any<T>();
		}

		// Token: 0x0600499F RID: 18847 RVA: 0x00122BC8 File Offset: 0x00120DC8
		public auseceEntities GetContext()
		{
			return this._context;
		}

		// Token: 0x060049A0 RID: 18848 RVA: 0x00122BDC File Offset: 0x00120DDC
		public void Dispose()
		{
			auseceEntities context = this._context;
			if (context == null)
			{
				return;
			}
			context.Dispose();
		}

		// Token: 0x04002ED3 RID: 11987
		protected readonly auseceEntities _context;

		// Token: 0x04002ED4 RID: 11988
		protected DbSet<T> _entity;

		// Token: 0x04002ED5 RID: 11989
		private string errorMessage = string.Empty;

		// Token: 0x0200096F RID: 2415
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetFirstOrDefaultAsync>d__14 : IAsyncStateMachine
		{
			// Token: 0x060049A1 RID: 18849 RVA: 0x00122BFC File Offset: 0x00120DFC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				GenericRepository<T> genericRepository = this.<>4__this;
				T result;
				try
				{
					TaskAwaiter<T> awaiter;
					if (num != 0)
					{
						IQueryable<T> queryable = genericRepository._entity;
						if (this.filter != null)
						{
							queryable = genericRepository.Filter(this.filter, queryable);
						}
						queryable = genericRepository.IncludeProperties(this.includeProperties, queryable);
						awaiter = queryable.FirstOrDefaultAsync<T>().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<T>, GenericRepository<T>.<GetFirstOrDefaultAsync>d__14>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<T>);
						this.<>1__state = -1;
					}
					result = awaiter.GetResult();
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

			// Token: 0x060049A2 RID: 18850 RVA: 0x00122CE0 File Offset: 0x00120EE0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002ED6 RID: 11990
			public int <>1__state;

			// Token: 0x04002ED7 RID: 11991
			public AsyncTaskMethodBuilder<T> <>t__builder;

			// Token: 0x04002ED8 RID: 11992
			public GenericRepository<T> <>4__this;

			// Token: 0x04002ED9 RID: 11993
			public Expression<Func<T, bool>> filter;

			// Token: 0x04002EDA RID: 11994
			public string includeProperties;

			// Token: 0x04002EDB RID: 11995
			private TaskAwaiter<T> <>u__1;
		}

		// Token: 0x02000970 RID: 2416
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetAllAsync>d__17 : IAsyncStateMachine
		{
			// Token: 0x060049A3 RID: 18851 RVA: 0x00122CFC File Offset: 0x00120EFC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				GenericRepository<T> genericRepository = this.<>4__this;
				IEnumerable<T> result;
				try
				{
					TaskAwaiter<List<T>> awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<T>>);
							this.<>1__state = -1;
						}
						else
						{
							IQueryable<T> queryable = genericRepository._entity;
							queryable = genericRepository.Filter(this.filter, queryable);
							queryable = genericRepository.IncludeProperties(this.includeProperties, queryable);
							if (this.orderBy == null)
							{
								awaiter = queryable.ToListAsync<T>().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									this.<>1__state = 1;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<T>>, GenericRepository<T>.<GetAllAsync>d__17>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.orderBy(queryable).ToListAsync<T>().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									this.<>1__state = 0;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<T>>, GenericRepository<T>.<GetAllAsync>d__17>(ref awaiter, ref this);
									return;
								}
								goto IL_108;
							}
						}
						result = awaiter.GetResult();
						goto IL_12B;
					}
					awaiter = this.<>u__1;
					this.<>u__1 = default(TaskAwaiter<List<T>>);
					this.<>1__state = -1;
					IL_108:
					result = awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_12B:
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x060049A4 RID: 18852 RVA: 0x00122E64 File Offset: 0x00121064
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002EDC RID: 11996
			public int <>1__state;

			// Token: 0x04002EDD RID: 11997
			public AsyncTaskMethodBuilder<IEnumerable<T>> <>t__builder;

			// Token: 0x04002EDE RID: 11998
			public GenericRepository<T> <>4__this;

			// Token: 0x04002EDF RID: 11999
			public Expression<Func<T, bool>> filter;

			// Token: 0x04002EE0 RID: 12000
			public string includeProperties;

			// Token: 0x04002EE1 RID: 12001
			public Func<IQueryable<T>, IOrderedQueryable<T>> orderBy;

			// Token: 0x04002EE2 RID: 12002
			private TaskAwaiter<List<T>> <>u__1;
		}

		// Token: 0x02000971 RID: 2417
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetAllAsync>d__18 : IAsyncStateMachine
		{
			// Token: 0x060049A5 RID: 18853 RVA: 0x00122E80 File Offset: 0x00121080
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				GenericRepository<T> genericRepository = this.<>4__this;
				IEnumerable<T> result;
				try
				{
					TaskAwaiter<List<T>> awaiter;
					if (num != 0)
					{
						if (num != 1)
						{
							IQueryable<T> queryable = genericRepository._entity;
							if (this.filterList != null)
							{
								List<KeyValuePair<bool, Expression<Func<T, bool>>>>.Enumerator enumerator = this.filterList.GetEnumerator();
								try
								{
									while (enumerator.MoveNext())
									{
										KeyValuePair<bool, Expression<Func<T, bool>>> keyValuePair = enumerator.Current;
										queryable = queryable.WhereIf(keyValuePair.Key, keyValuePair.Value);
									}
								}
								finally
								{
									if (num < 0)
									{
										((IDisposable)enumerator).Dispose();
									}
								}
							}
							queryable = genericRepository.IncludeProperties(this.includeProperties, queryable);
							if (this.dnt)
							{
								queryable = queryable.AsNoTracking<T>();
							}
							if (this.orderBy != null)
							{
								awaiter = this.orderBy(queryable).ToListAsync<T>().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<T>>, GenericRepository<T>.<GetAllAsync>d__18>(ref awaiter, ref this);
									return;
								}
								goto IL_15D;
							}
							else
							{
								awaiter = queryable.ToListAsync<T>().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num3 = 1;
									num = 1;
									this.<>1__state = num3;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<T>>, GenericRepository<T>.<GetAllAsync>d__18>(ref awaiter, ref this);
									return;
								}
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<T>>);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
						}
						result = awaiter.GetResult();
						goto IL_180;
					}
					awaiter = this.<>u__1;
					this.<>u__1 = default(TaskAwaiter<List<T>>);
					int num5 = -1;
					num = -1;
					this.<>1__state = num5;
					IL_15D:
					result = awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_180:
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x060049A6 RID: 18854 RVA: 0x00123058 File Offset: 0x00121258
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002EE3 RID: 12003
			public int <>1__state;

			// Token: 0x04002EE4 RID: 12004
			public AsyncTaskMethodBuilder<IEnumerable<T>> <>t__builder;

			// Token: 0x04002EE5 RID: 12005
			public GenericRepository<T> <>4__this;

			// Token: 0x04002EE6 RID: 12006
			public List<KeyValuePair<bool, Expression<Func<T, bool>>>> filterList;

			// Token: 0x04002EE7 RID: 12007
			public string includeProperties;

			// Token: 0x04002EE8 RID: 12008
			public bool dnt;

			// Token: 0x04002EE9 RID: 12009
			public Func<IQueryable<T>, IOrderedQueryable<T>> orderBy;

			// Token: 0x04002EEA RID: 12010
			private TaskAwaiter<List<T>> <>u__1;
		}

		// Token: 0x02000972 RID: 2418
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CountAsync>d__20 : IAsyncStateMachine
		{
			// Token: 0x060049A7 RID: 18855 RVA: 0x00123074 File Offset: 0x00121274
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				GenericRepository<T> genericRepository = this.<>4__this;
				int result;
				try
				{
					TaskAwaiter<int> awaiter;
					if (num != 0)
					{
						IQueryable<T> queryable = genericRepository._entity;
						queryable = genericRepository.Filter(this.filter, queryable);
						awaiter = queryable.CountAsync<T>().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, GenericRepository<T>.<CountAsync>d__20>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<int>);
						this.<>1__state = -1;
					}
					result = awaiter.GetResult();
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

			// Token: 0x060049A8 RID: 18856 RVA: 0x00123144 File Offset: 0x00121344
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002EEB RID: 12011
			public int <>1__state;

			// Token: 0x04002EEC RID: 12012
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x04002EED RID: 12013
			public GenericRepository<T> <>4__this;

			// Token: 0x04002EEE RID: 12014
			public Expression<Func<T, bool>> filter;

			// Token: 0x04002EEF RID: 12015
			private TaskAwaiter<int> <>u__1;
		}
	}
}
