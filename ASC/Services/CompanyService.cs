using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Common.Objects;

namespace ASC.Services
{
	// Token: 0x020005C7 RID: 1479
	public class CompanyService : ICompanyService
	{
		// Token: 0x060036F0 RID: 14064 RVA: 0x000BBC10 File Offset: 0x000B9E10
		public Task<companies> GetCompany(int companyId)
		{
			CompanyService.<GetCompany>d__0 <GetCompany>d__;
			<GetCompany>d__.<>t__builder = AsyncTaskMethodBuilder<companies>.Create();
			<GetCompany>d__.companyId = companyId;
			<GetCompany>d__.<>1__state = -1;
			<GetCompany>d__.<>t__builder.Start<CompanyService.<GetCompany>d__0>(ref <GetCompany>d__);
			return <GetCompany>d__.<>t__builder.Task;
		}

		// Token: 0x060036F1 RID: 14065 RVA: 0x000BBC54 File Offset: 0x000B9E54
		public Task<IEnumerable<ICompanyLookUp>> GetCompaniesLookup()
		{
			CompanyService.<GetCompaniesLookup>d__1 <GetCompaniesLookup>d__;
			<GetCompaniesLookup>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<ICompanyLookUp>>.Create();
			<GetCompaniesLookup>d__.<>1__state = -1;
			<GetCompaniesLookup>d__.<>t__builder.Start<CompanyService.<GetCompaniesLookup>d__1>(ref <GetCompaniesLookup>d__);
			return <GetCompaniesLookup>d__.<>t__builder.Task;
		}

		// Token: 0x060036F2 RID: 14066 RVA: 0x000046B4 File Offset: 0x000028B4
		public CompanyService()
		{
		}

		// Token: 0x020005C8 RID: 1480
		[CompilerGenerated]
		private sealed class <>c__DisplayClass0_0
		{
			// Token: 0x060036F3 RID: 14067 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass0_0()
			{
			}

			// Token: 0x04001F9D RID: 8093
			public int companyId;
		}

		// Token: 0x020005C9 RID: 1481
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCompany>d__0 : IAsyncStateMachine
		{
			// Token: 0x060036F4 RID: 14068 RVA: 0x000BBC90 File Offset: 0x000B9E90
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				companies result;
				try
				{
					CompanyService.<>c__DisplayClass0_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new CompanyService.<>c__DisplayClass0_0();
						CS$<>8__locals1.companyId = this.companyId;
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						ConfiguredTaskAwaitable<companies>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = this.<ctx>5__2.companies.AsNoTracking().FirstOrDefaultAsync((companies i) => i.id == CS$<>8__locals1.companyId).ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<companies>.ConfiguredTaskAwaiter, CompanyService.<GetCompany>d__0>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<companies>.ConfiguredTaskAwaiter);
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

			// Token: 0x060036F5 RID: 14069 RVA: 0x000BBE1C File Offset: 0x000BA01C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001F9E RID: 8094
			public int <>1__state;

			// Token: 0x04001F9F RID: 8095
			public AsyncTaskMethodBuilder<companies> <>t__builder;

			// Token: 0x04001FA0 RID: 8096
			public int companyId;

			// Token: 0x04001FA1 RID: 8097
			private auseceEntities <ctx>5__2;

			// Token: 0x04001FA2 RID: 8098
			private ConfiguredTaskAwaitable<companies>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x020005CA RID: 1482
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060036F6 RID: 14070 RVA: 0x000BBE38 File Offset: 0x000BA038
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060036F7 RID: 14071 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x04001FA3 RID: 8099
			public static readonly CompanyService.<>c <>9 = new CompanyService.<>c();
		}

		// Token: 0x020005CB RID: 1483
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCompaniesLookup>d__1 : IAsyncStateMachine
		{
			// Token: 0x060036F8 RID: 14072 RVA: 0x000BBE50 File Offset: 0x000BA050
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IEnumerable<ICompanyLookUp> result;
				try
				{
					if (num != 0)
					{
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						ConfiguredTaskAwaitable<List<CompanyLookUp>>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							ParameterExpression parameterExpression;
							awaiter = this.<ctx>5__2.companies.AsNoTracking().Select(Expression.Lambda<Func<companies, CompanyLookUp>>(Expression.MemberInit(Expression.New(typeof(CompanyLookUp)), new MemberBinding[]
							{
								Expression.Bind(methodof(CompanyLookUp.set_Id(int)), Expression.Property(parameterExpression, methodof(companies.get_id()))),
								Expression.Bind(methodof(CompanyLookUp.set_Name(string)), Expression.Property(parameterExpression, methodof(companies.get_name()))),
								Expression.Bind(methodof(CompanyLookUp.set_State(bool)), Expression.Property(parameterExpression, methodof(companies.get_status())))
							}), new ParameterExpression[]
							{
								parameterExpression
							})).ToListAsync<CompanyLookUp>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<List<CompanyLookUp>>.ConfiguredTaskAwaiter, CompanyService.<GetCompaniesLookup>d__1>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<List<CompanyLookUp>>.ConfiguredTaskAwaiter);
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

			// Token: 0x060036F9 RID: 14073 RVA: 0x000BC030 File Offset: 0x000BA230
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001FA4 RID: 8100
			public int <>1__state;

			// Token: 0x04001FA5 RID: 8101
			public AsyncTaskMethodBuilder<IEnumerable<ICompanyLookUp>> <>t__builder;

			// Token: 0x04001FA6 RID: 8102
			private auseceEntities <ctx>5__2;

			// Token: 0x04001FA7 RID: 8103
			private ConfiguredTaskAwaitable<List<CompanyLookUp>>.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
