using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Enum;
using ASC.Common.Interfaces;
using ASC.DAL;
using ASC.Interfaces;

namespace ASC.Services
{
	// Token: 0x02000671 RID: 1649
	public class EmployeeService : IEmployeeService
	{
		// Token: 0x06003881 RID: 14465 RVA: 0x000CCE30 File Offset: 0x000CB030
		public EmployeeService(IContextFactory contextFactory)
		{
			this._contextFactory = contextFactory;
		}

		// Token: 0x06003882 RID: 14466 RVA: 0x000CCE4C File Offset: 0x000CB04C
		public Task<users> GetEmployeeAsync(string username)
		{
			EmployeeService.<GetEmployeeAsync>d__2 <GetEmployeeAsync>d__;
			<GetEmployeeAsync>d__.<>t__builder = AsyncTaskMethodBuilder<users>.Create();
			<GetEmployeeAsync>d__.username = username;
			<GetEmployeeAsync>d__.<>1__state = -1;
			<GetEmployeeAsync>d__.<>t__builder.Start<EmployeeService.<GetEmployeeAsync>d__2>(ref <GetEmployeeAsync>d__);
			return <GetEmployeeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06003883 RID: 14467 RVA: 0x000CCE90 File Offset: 0x000CB090
		public Task<List<users>> GetEmployees()
		{
			EmployeeService.<GetEmployees>d__3 <GetEmployees>d__;
			<GetEmployees>d__.<>t__builder = AsyncTaskMethodBuilder<List<users>>.Create();
			<GetEmployees>d__.<>4__this = this;
			<GetEmployees>d__.<>1__state = -1;
			<GetEmployees>d__.<>t__builder.Start<EmployeeService.<GetEmployees>d__3>(ref <GetEmployees>d__);
			return <GetEmployees>d__.<>t__builder.Task;
		}

		// Token: 0x06003884 RID: 14468 RVA: 0x000CCED4 File Offset: 0x000CB0D4
		public Task<List<users>> GetEmployeesByRole(SystemRoles role)
		{
			EmployeeService.<GetEmployeesByRole>d__4 <GetEmployeesByRole>d__;
			<GetEmployeesByRole>d__.<>t__builder = AsyncTaskMethodBuilder<List<users>>.Create();
			<GetEmployeesByRole>d__.<>4__this = this;
			<GetEmployeesByRole>d__.role = role;
			<GetEmployeesByRole>d__.<>1__state = -1;
			<GetEmployeesByRole>d__.<>t__builder.Start<EmployeeService.<GetEmployeesByRole>d__4>(ref <GetEmployeesByRole>d__);
			return <GetEmployeesByRole>d__.<>t__builder.Task;
		}

		// Token: 0x06003885 RID: 14469 RVA: 0x000CCF20 File Offset: 0x000CB120
		public Task<IEnumerable<users>> GetEmployeesForAcp(bool showArchive = false)
		{
			EmployeeService.<GetEmployeesForAcp>d__5 <GetEmployeesForAcp>d__;
			<GetEmployeesForAcp>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<users>>.Create();
			<GetEmployeesForAcp>d__.<>4__this = this;
			<GetEmployeesForAcp>d__.showArchive = showArchive;
			<GetEmployeesForAcp>d__.<>1__state = -1;
			<GetEmployeesForAcp>d__.<>t__builder.Start<EmployeeService.<GetEmployeesForAcp>d__5>(ref <GetEmployeesForAcp>d__);
			return <GetEmployeesForAcp>d__.<>t__builder.Task;
		}

		// Token: 0x06003886 RID: 14470 RVA: 0x000CCF6C File Offset: 0x000CB16C
		public Task<List<logs>> GetLogsAsync(IPeriod period, int employeeId)
		{
			EmployeeService.<GetLogsAsync>d__6 <GetLogsAsync>d__;
			<GetLogsAsync>d__.<>t__builder = AsyncTaskMethodBuilder<List<logs>>.Create();
			<GetLogsAsync>d__.period = period;
			<GetLogsAsync>d__.employeeId = employeeId;
			<GetLogsAsync>d__.<>1__state = -1;
			<GetLogsAsync>d__.<>t__builder.Start<EmployeeService.<GetLogsAsync>d__6>(ref <GetLogsAsync>d__);
			return <GetLogsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06003887 RID: 14471 RVA: 0x000CCFB8 File Offset: 0x000CB1B8
		public bool EmployeeCan(string username, int permissionId)
		{
			bool result;
			using (auseceEntities auseceEntities = this._contextFactory.Create())
			{
				result = ((from pr in auseceEntities.permissions_roles
				join ru in auseceEntities.roles_users on pr.role_id equals ru.role_id
				where ru.users.username == username && pr.permission_id == permissionId
				select pr).FirstOrDefault<permissions_roles>() != null);
			}
			return result;
		}

		// Token: 0x04002241 RID: 8769
		private readonly IContextFactory _contextFactory;

		// Token: 0x02000672 RID: 1650
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x06003888 RID: 14472 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x04002242 RID: 8770
			public string username;
		}

		// Token: 0x02000673 RID: 1651
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003889 RID: 14473 RVA: 0x000CD260 File Offset: 0x000CB460
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600388A RID: 14474 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x0600388B RID: 14475 RVA: 0x000CD278 File Offset: 0x000CB478
			internal string <GetEmployees>b__3_0(users u)
			{
				return u.Fio;
			}

			// Token: 0x0600388C RID: 14476 RVA: 0x000CD278 File Offset: 0x000CB478
			internal string <GetEmployeesByRole>b__4_0(users u)
			{
				return u.Fio;
			}

			// Token: 0x04002243 RID: 8771
			public static readonly EmployeeService.<>c <>9 = new EmployeeService.<>c();

			// Token: 0x04002244 RID: 8772
			public static Func<users, string> <>9__3_0;

			// Token: 0x04002245 RID: 8773
			public static Func<users, string> <>9__4_0;
		}

		// Token: 0x02000674 RID: 1652
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetEmployeeAsync>d__2 : IAsyncStateMachine
		{
			// Token: 0x0600388D RID: 14477 RVA: 0x000CD28C File Offset: 0x000CB48C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				users result;
				try
				{
					EmployeeService.<>c__DisplayClass2_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new EmployeeService.<>c__DisplayClass2_0();
						CS$<>8__locals1.username = this.username;
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						ConfiguredTaskAwaitable<users>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = (from i in this.<ctx>5__2.users.AsNoTracking().Include((users i) => i.offices1).Include((users i) => i.offices1.companies).Include((users i) => i.kkt1).Include((users i) => i.pinpad1).Include((users i) => i.roles_users)
							where i.username == CS$<>8__locals1.username && i.state == (int?)1
							select i).FirstOrDefaultAsync<users>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<users>.ConfiguredTaskAwaiter, EmployeeService.<GetEmployeeAsync>d__2>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<users>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult();
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
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

			// Token: 0x0600388E RID: 14478 RVA: 0x000CD5B8 File Offset: 0x000CB7B8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002246 RID: 8774
			public int <>1__state;

			// Token: 0x04002247 RID: 8775
			public AsyncTaskMethodBuilder<users> <>t__builder;

			// Token: 0x04002248 RID: 8776
			public string username;

			// Token: 0x04002249 RID: 8777
			private auseceEntities <ctx>5__2;

			// Token: 0x0400224A RID: 8778
			private ConfiguredTaskAwaitable<users>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000675 RID: 1653
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetEmployees>d__3 : IAsyncStateMachine
		{
			// Token: 0x0600388F RID: 14479 RVA: 0x000CD5D4 File Offset: 0x000CB7D4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				EmployeeService employeeService = this.<>4__this;
				List<users> result;
				try
				{
					if (num != 0)
					{
						this.<ctx>5__2 = employeeService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<List<users>> awaiter;
						if (num != 0)
						{
							awaiter = (from u in this.<ctx>5__2.users
							where u.state == (int?)1 && !u.is_bot
							select u).ToListAsync<users>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<users>>, EmployeeService.<GetEmployees>d__3>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<users>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult().OrderBy(new Func<users, string>(EmployeeService.<>c.<>9.<GetEmployees>b__3_0)).ToList<users>();
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
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

			// Token: 0x06003890 RID: 14480 RVA: 0x000CD7A0 File Offset: 0x000CB9A0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400224B RID: 8779
			public int <>1__state;

			// Token: 0x0400224C RID: 8780
			public AsyncTaskMethodBuilder<List<users>> <>t__builder;

			// Token: 0x0400224D RID: 8781
			public EmployeeService <>4__this;

			// Token: 0x0400224E RID: 8782
			private auseceEntities <ctx>5__2;

			// Token: 0x0400224F RID: 8783
			private TaskAwaiter<List<users>> <>u__1;
		}

		// Token: 0x02000676 RID: 1654
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x06003891 RID: 14481 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x04002250 RID: 8784
			public SystemRoles role;
		}

		// Token: 0x02000677 RID: 1655
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetEmployeesByRole>d__4 : IAsyncStateMachine
		{
			// Token: 0x06003892 RID: 14482 RVA: 0x000CD7BC File Offset: 0x000CB9BC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				EmployeeService employeeService = this.<>4__this;
				List<users> result;
				try
				{
					EmployeeService.<>c__DisplayClass4_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new EmployeeService.<>c__DisplayClass4_0();
						CS$<>8__locals1.role = this.role;
						this.<ctx>5__2 = employeeService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<List<users>> awaiter;
						if (num != 0)
						{
							awaiter = (from usr in this.<ctx>5__2.users
							join ru in this.<ctx>5__2.roles_users on usr.id equals ru.user_id
							select new
							{
								usr,
								ru
							} into i
							where i.usr.state == (int?)1 && !i.usr.is_bot
							where i.ru.role_id == (int)CS$<>8__locals1.role
							select i.usr).ToListAsync<users>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<users>>, EmployeeService.<GetEmployeesByRole>d__4>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<users>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult().OrderBy(new Func<users, string>(EmployeeService.<>c.<>9.<GetEmployeesByRole>b__4_0)).ToList<users>();
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
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

			// Token: 0x06003893 RID: 14483 RVA: 0x000CDBC8 File Offset: 0x000CBDC8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002251 RID: 8785
			public int <>1__state;

			// Token: 0x04002252 RID: 8786
			public AsyncTaskMethodBuilder<List<users>> <>t__builder;

			// Token: 0x04002253 RID: 8787
			public SystemRoles role;

			// Token: 0x04002254 RID: 8788
			public EmployeeService <>4__this;

			// Token: 0x04002255 RID: 8789
			private auseceEntities <ctx>5__2;

			// Token: 0x04002256 RID: 8790
			private TaskAwaiter<List<users>> <>u__1;
		}

		// Token: 0x02000678 RID: 1656
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetEmployeesForAcp>d__5 : IAsyncStateMachine
		{
			// Token: 0x06003894 RID: 14484 RVA: 0x000CDBE4 File Offset: 0x000CBDE4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				EmployeeService employeeService = this.<>4__this;
				IEnumerable<users> result;
				try
				{
					if (num != 0)
					{
						this.<ctx>5__2 = employeeService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<List<users>> awaiter;
						if (num != 0)
						{
							IQueryable<users> source = this.<ctx>5__2.users.AsNoTracking().Include((users i) => i.offices1).AsQueryable<users>();
							if (!this.showArchive)
							{
								source = from i in source
								where i.state == (int?)1
								select i;
							}
							awaiter = (from i in source
							orderby i.surname, i.name
							select i).ToListAsync<users>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<users>>, EmployeeService.<GetEmployeesForAcp>d__5>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<users>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult();
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
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

			// Token: 0x06003895 RID: 14485 RVA: 0x000CDE40 File Offset: 0x000CC040
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002257 RID: 8791
			public int <>1__state;

			// Token: 0x04002258 RID: 8792
			public AsyncTaskMethodBuilder<IEnumerable<users>> <>t__builder;

			// Token: 0x04002259 RID: 8793
			public EmployeeService <>4__this;

			// Token: 0x0400225A RID: 8794
			public bool showArchive;

			// Token: 0x0400225B RID: 8795
			private auseceEntities <ctx>5__2;

			// Token: 0x0400225C RID: 8796
			private TaskAwaiter<List<users>> <>u__1;
		}

		// Token: 0x02000679 RID: 1657
		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x06003896 RID: 14486 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x0400225D RID: 8797
			public int employeeId;

			// Token: 0x0400225E RID: 8798
			public DateTime from;

			// Token: 0x0400225F RID: 8799
			public DateTime to;
		}

		// Token: 0x0200067A RID: 1658
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetLogsAsync>d__6 : IAsyncStateMachine
		{
			// Token: 0x06003897 RID: 14487 RVA: 0x000CDE5C File Offset: 0x000CC05C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<logs> result;
				try
				{
					EmployeeService.<>c__DisplayClass6_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new EmployeeService.<>c__DisplayClass6_0();
						CS$<>8__locals1.employeeId = this.employeeId;
						CS$<>8__locals1.from = this.period.From.Date;
						CS$<>8__locals1.to = this.period.To.Date.AddDays(1.0).AddSeconds(-1.0);
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						ConfiguredTaskAwaitable<List<logs>>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = (from l in this.<ctx>5__2.logs.AsNoTracking()
							where l.user == CS$<>8__locals1.employeeId && l.created >= (DateTime?)CS$<>8__locals1.@from && l.created <= (DateTime?)CS$<>8__locals1.to
							select l).ToListAsync<logs>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<List<logs>>.ConfiguredTaskAwaiter, EmployeeService.<GetLogsAsync>d__6>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<List<logs>>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult();
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
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

			// Token: 0x06003898 RID: 14488 RVA: 0x000CE100 File Offset: 0x000CC300
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002260 RID: 8800
			public int <>1__state;

			// Token: 0x04002261 RID: 8801
			public AsyncTaskMethodBuilder<List<logs>> <>t__builder;

			// Token: 0x04002262 RID: 8802
			public int employeeId;

			// Token: 0x04002263 RID: 8803
			public IPeriod period;

			// Token: 0x04002264 RID: 8804
			private auseceEntities <ctx>5__2;

			// Token: 0x04002265 RID: 8805
			private ConfiguredTaskAwaitable<List<logs>>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x0200067B RID: 1659
		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x06003899 RID: 14489 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x04002266 RID: 8806
			public string username;

			// Token: 0x04002267 RID: 8807
			public int permissionId;
		}
	}
}
