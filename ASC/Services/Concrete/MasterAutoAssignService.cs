using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.DAL;
using ASC.Services.Abstract;

namespace ASC.Services.Concrete
{
	// Token: 0x020006DB RID: 1755
	public class MasterAutoAssignService : IMasterAutoAssignService
	{
		// Token: 0x0600397F RID: 14719 RVA: 0x000D6BF4 File Offset: 0x000D4DF4
		public MasterAutoAssignService(IContextFactory contextFactory)
		{
			this._contextFactory = contextFactory;
		}

		// Token: 0x06003980 RID: 14720 RVA: 0x000D6C10 File Offset: 0x000D4E10
		public Task<int?> GetMaster(IMasterAutoAssignCriteria criteria, int? skipFromUser = null)
		{
			MasterAutoAssignService.<GetMaster>d__4 <GetMaster>d__;
			<GetMaster>d__.<>t__builder = AsyncTaskMethodBuilder<int?>.Create();
			<GetMaster>d__.<>4__this = this;
			<GetMaster>d__.criteria = criteria;
			<GetMaster>d__.skipFromUser = skipFromUser;
			<GetMaster>d__.<>1__state = -1;
			<GetMaster>d__.<>t__builder.Start<MasterAutoAssignService.<GetMaster>d__4>(ref <GetMaster>d__);
			return <GetMaster>d__.<>t__builder.Task;
		}

		// Token: 0x06003981 RID: 14721 RVA: 0x000D6C64 File Offset: 0x000D4E64
		private Task<int> GetOrdersInStatus(auseceEntities ctx, int userId, int status)
		{
			MasterAutoAssignService.<GetOrdersInStatus>d__5 <GetOrdersInStatus>d__;
			<GetOrdersInStatus>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<GetOrdersInStatus>d__.ctx = ctx;
			<GetOrdersInStatus>d__.userId = userId;
			<GetOrdersInStatus>d__.status = status;
			<GetOrdersInStatus>d__.<>1__state = -1;
			<GetOrdersInStatus>d__.<>t__builder.Start<MasterAutoAssignService.<GetOrdersInStatus>d__5>(ref <GetOrdersInStatus>d__);
			return <GetOrdersInStatus>d__.<>t__builder.Task;
		}

		// Token: 0x06003982 RID: 14722 RVA: 0x000D6CB8 File Offset: 0x000D4EB8
		private Task<DateTime?> GetUserLastDiagDate(auseceEntities ctx, int userId)
		{
			MasterAutoAssignService.<GetUserLastDiagDate>d__6 <GetUserLastDiagDate>d__;
			<GetUserLastDiagDate>d__.<>t__builder = AsyncTaskMethodBuilder<DateTime?>.Create();
			<GetUserLastDiagDate>d__.ctx = ctx;
			<GetUserLastDiagDate>d__.userId = userId;
			<GetUserLastDiagDate>d__.<>1__state = -1;
			<GetUserLastDiagDate>d__.<>t__builder.Start<MasterAutoAssignService.<GetUserLastDiagDate>d__6>(ref <GetUserLastDiagDate>d__);
			return <GetUserLastDiagDate>d__.<>t__builder.Task;
		}

		// Token: 0x040023DD RID: 9181
		private readonly IContextFactory _contextFactory;

		// Token: 0x020006DC RID: 1756
		private class MasterInfoModel
		{
			// Token: 0x17001095 RID: 4245
			// (get) Token: 0x06003983 RID: 14723 RVA: 0x000D6D04 File Offset: 0x000D4F04
			// (set) Token: 0x06003984 RID: 14724 RVA: 0x000D6D18 File Offset: 0x000D4F18
			public int UserId
			{
				[CompilerGenerated]
				get
				{
					return this.<UserId>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<UserId>k__BackingField = value;
				}
			}

			// Token: 0x17001096 RID: 4246
			// (get) Token: 0x06003985 RID: 14725 RVA: 0x000D6D2C File Offset: 0x000D4F2C
			// (set) Token: 0x06003986 RID: 14726 RVA: 0x000D6D40 File Offset: 0x000D4F40
			public int Orders
			{
				[CompilerGenerated]
				get
				{
					return this.<Orders>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<Orders>k__BackingField = value;
				}
			}

			// Token: 0x17001097 RID: 4247
			// (get) Token: 0x06003987 RID: 14727 RVA: 0x000D6D54 File Offset: 0x000D4F54
			// (set) Token: 0x06003988 RID: 14728 RVA: 0x000D6D68 File Offset: 0x000D4F68
			public DateTime? LastDiag
			{
				[CompilerGenerated]
				get
				{
					return this.<LastDiag>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<LastDiag>k__BackingField = value;
				}
			}

			// Token: 0x06003989 RID: 14729 RVA: 0x000046B4 File Offset: 0x000028B4
			public MasterInfoModel()
			{
			}

			// Token: 0x040023DE RID: 9182
			[CompilerGenerated]
			private int <UserId>k__BackingField;

			// Token: 0x040023DF RID: 9183
			[CompilerGenerated]
			private int <Orders>k__BackingField;

			// Token: 0x040023E0 RID: 9184
			[CompilerGenerated]
			private DateTime? <LastDiag>k__BackingField;
		}

		// Token: 0x020006DD RID: 1757
		public class MasterAutoAssignCriteria : IMasterAutoAssignCriteria
		{
			// Token: 0x17001098 RID: 4248
			// (get) Token: 0x0600398A RID: 14730 RVA: 0x000D6D7C File Offset: 0x000D4F7C
			// (set) Token: 0x0600398B RID: 14731 RVA: 0x000D6D90 File Offset: 0x000D4F90
			public List<int> StatusList
			{
				[CompilerGenerated]
				get
				{
					return this.<StatusList>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<StatusList>k__BackingField = value;
				}
			} = new List<int>();

			// Token: 0x17001099 RID: 4249
			// (get) Token: 0x0600398C RID: 14732 RVA: 0x000D6DA4 File Offset: 0x000D4FA4
			// (set) Token: 0x0600398D RID: 14733 RVA: 0x000D6DB8 File Offset: 0x000D4FB8
			public int DayLimit
			{
				[CompilerGenerated]
				get
				{
					return this.<DayLimit>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<DayLimit>k__BackingField = value;
				}
			}

			// Token: 0x0600398E RID: 14734 RVA: 0x000D6DCC File Offset: 0x000D4FCC
			public MasterAutoAssignCriteria()
			{
			}

			// Token: 0x040023E1 RID: 9185
			[CompilerGenerated]
			private List<int> <StatusList>k__BackingField;

			// Token: 0x040023E2 RID: 9186
			[CompilerGenerated]
			private int <DayLimit>k__BackingField;
		}

		// Token: 0x020006DE RID: 1758
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x0600398F RID: 14735 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x06003990 RID: 14736 RVA: 0x000D6DEC File Offset: 0x000D4FEC
			internal bool <GetMaster>b__7(MasterAutoAssignService.MasterInfoModel i)
			{
				int userId = i.UserId;
				int? num = this.skipFromUser;
				return userId == num.GetValueOrDefault() & num != null;
			}

			// Token: 0x040023E3 RID: 9187
			public int? skipFromUser;
		}

		// Token: 0x020006DF RID: 1759
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_1
		{
			// Token: 0x06003991 RID: 14737 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass4_1()
			{
			}

			// Token: 0x040023E4 RID: 9188
			public auseceEntities ctx;

			// Token: 0x040023E5 RID: 9189
			public DateTime todayStart;

			// Token: 0x040023E6 RID: 9190
			public DateTime todayEnd;
		}

		// Token: 0x020006E0 RID: 1760
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003992 RID: 14738 RVA: 0x000D6E18 File Offset: 0x000D5018
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003993 RID: 14739 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06003994 RID: 14740 RVA: 0x000D6E30 File Offset: 0x000D5030
			internal int <GetMaster>b__4_0(MasterAutoAssignService.MasterInfoModel i)
			{
				return i.Orders;
			}

			// Token: 0x06003995 RID: 14741 RVA: 0x000D6E44 File Offset: 0x000D5044
			internal DateTime? <GetMaster>b__4_1(MasterAutoAssignService.MasterInfoModel i)
			{
				return i.LastDiag;
			}

			// Token: 0x040023E7 RID: 9191
			public static readonly MasterAutoAssignService.<>c <>9 = new MasterAutoAssignService.<>c();

			// Token: 0x040023E8 RID: 9192
			public static Func<MasterAutoAssignService.MasterInfoModel, int> <>9__4_0;

			// Token: 0x040023E9 RID: 9193
			public static Func<MasterAutoAssignService.MasterInfoModel, DateTime?> <>9__4_1;
		}

		// Token: 0x020006E1 RID: 1761
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetMaster>d__4 : IAsyncStateMachine
		{
			// Token: 0x06003996 RID: 14742 RVA: 0x000D6E58 File Offset: 0x000D5058
			void IAsyncStateMachine.MoveNext()
			{
				/*
An exception occurred when decompiling this method (06003996)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ASC.Services.Concrete.MasterAutoAssignService/<GetMaster>d__4::MoveNext()

 ---> System.Exception: Inconsistent stack size at IL_61D
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
			}

			// Token: 0x06003997 RID: 14743 RVA: 0x000D7564 File Offset: 0x000D5764
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040023EA RID: 9194
			public int <>1__state;

			// Token: 0x040023EB RID: 9195
			public AsyncTaskMethodBuilder<int?> <>t__builder;

			// Token: 0x040023EC RID: 9196
			public int? skipFromUser;

			// Token: 0x040023ED RID: 9197
			public MasterAutoAssignService <>4__this;

			// Token: 0x040023EE RID: 9198
			public IMasterAutoAssignCriteria criteria;

			// Token: 0x040023EF RID: 9199
			private MasterAutoAssignService.<>c__DisplayClass4_1 <>8__1;

			// Token: 0x040023F0 RID: 9200
			private MasterAutoAssignService.<>c__DisplayClass4_0 <>8__2;

			// Token: 0x040023F1 RID: 9201
			private List<MasterAutoAssignService.MasterInfoModel> <list>5__2;

			// Token: 0x040023F2 RID: 9202
			private TaskAwaiter<List<<>f__AnonymousType1<int, int>>> <>u__1;

			// Token: 0x040023F3 RID: 9203
			private List<<>f__AnonymousType1<int, int>>.Enumerator <>7__wrap2;

			// Token: 0x040023F4 RID: 9204
			private <>f__AnonymousType1<int, int> <user>5__4;

			// Token: 0x040023F5 RID: 9205
			private List<int>.Enumerator <>7__wrap4;

			// Token: 0x040023F6 RID: 9206
			private int <>7__wrap5;

			// Token: 0x040023F7 RID: 9207
			private TaskAwaiter<int> <>u__2;

			// Token: 0x040023F8 RID: 9208
			private List<MasterAutoAssignService.MasterInfoModel> <>7__wrap6;

			// Token: 0x040023F9 RID: 9209
			private MasterAutoAssignService.MasterInfoModel <>7__wrap7;

			// Token: 0x040023FA RID: 9210
			private MasterAutoAssignService.MasterInfoModel <>7__wrap8;

			// Token: 0x040023FB RID: 9211
			private TaskAwaiter<DateTime?> <>u__3;
		}

		// Token: 0x020006E2 RID: 1762
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06003998 RID: 14744 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x040023FC RID: 9212
			public int userId;

			// Token: 0x040023FD RID: 9213
			public int status;
		}

		// Token: 0x020006E3 RID: 1763
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetOrdersInStatus>d__5 : IAsyncStateMachine
		{
			// Token: 0x06003999 RID: 14745 RVA: 0x000D7580 File Offset: 0x000D5780
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				int result;
				try
				{
					TaskAwaiter<int> awaiter;
					if (num != 0)
					{
						MasterAutoAssignService.<>c__DisplayClass5_0 CS$<>8__locals1 = new MasterAutoAssignService.<>c__DisplayClass5_0();
						CS$<>8__locals1.userId = this.userId;
						CS$<>8__locals1.status = this.status;
						awaiter = (from i in this.ctx.workshop
						where i.master == (int?)CS$<>8__locals1.userId
						where i.out_date == null
						where i.state == CS$<>8__locals1.status
						select i).CountAsync<workshop>().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, MasterAutoAssignService.<GetOrdersInStatus>d__5>(ref awaiter, ref this);
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

			// Token: 0x0600399A RID: 14746 RVA: 0x000D77B4 File Offset: 0x000D59B4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040023FE RID: 9214
			public int <>1__state;

			// Token: 0x040023FF RID: 9215
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x04002400 RID: 9216
			public int userId;

			// Token: 0x04002401 RID: 9217
			public int status;

			// Token: 0x04002402 RID: 9218
			public auseceEntities ctx;

			// Token: 0x04002403 RID: 9219
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x020006E4 RID: 1764
		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x0600399B RID: 14747 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x04002404 RID: 9220
			public int userId;
		}

		// Token: 0x020006E5 RID: 1765
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetUserLastDiagDate>d__6 : IAsyncStateMachine
		{
			// Token: 0x0600399C RID: 14748 RVA: 0x000D77D0 File Offset: 0x000D59D0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				DateTime? result2;
				try
				{
					TaskAwaiter<repair_status_logs> awaiter;
					if (num != 0)
					{
						MasterAutoAssignService.<>c__DisplayClass6_0 CS$<>8__locals1 = new MasterAutoAssignService.<>c__DisplayClass6_0();
						CS$<>8__locals1.userId = this.userId;
						awaiter = (from i in this.ctx.repair_status_logs
						where i.MasterId == (int?)CS$<>8__locals1.userId
						orderby i.CreatedAt descending
						select i).FirstOrDefaultAsync<repair_status_logs>().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<repair_status_logs>, MasterAutoAssignService.<GetUserLastDiagDate>d__6>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<repair_status_logs>);
						this.<>1__state = -1;
					}
					repair_status_logs result = awaiter.GetResult();
					result2 = ((result != null) ? new DateTime?(result.CreatedAt) : null);
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x0600399D RID: 14749 RVA: 0x000D797C File Offset: 0x000D5B7C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002405 RID: 9221
			public int <>1__state;

			// Token: 0x04002406 RID: 9222
			public AsyncTaskMethodBuilder<DateTime?> <>t__builder;

			// Token: 0x04002407 RID: 9223
			public int userId;

			// Token: 0x04002408 RID: 9224
			public auseceEntities ctx;

			// Token: 0x04002409 RID: 9225
			private TaskAwaiter<repair_status_logs> <>u__1;
		}
	}
}
