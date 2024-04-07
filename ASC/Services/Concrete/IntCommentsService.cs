using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Objects;
using ASC.Services.Abstract;
using NLog;

namespace ASC.Services.Concrete
{
	// Token: 0x02000717 RID: 1815
	public class IntCommentsService : IIntCommentsService
	{
		// Token: 0x06003A27 RID: 14887 RVA: 0x000DD05C File Offset: 0x000DB25C
		public Task CreateRepairComment(int repairId, string text)
		{
			IntCommentsService.<CreateRepairComment>d__2 <CreateRepairComment>d__;
			<CreateRepairComment>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<CreateRepairComment>d__.<>4__this = this;
			<CreateRepairComment>d__.repairId = repairId;
			<CreateRepairComment>d__.text = text;
			<CreateRepairComment>d__.<>1__state = -1;
			<CreateRepairComment>d__.<>t__builder.Start<IntCommentsService.<CreateRepairComment>d__2>(ref <CreateRepairComment>d__);
			return <CreateRepairComment>d__.<>t__builder.Task;
		}

		// Token: 0x06003A28 RID: 14888 RVA: 0x000DD0B0 File Offset: 0x000DB2B0
		public Task CreatePartRequestComment(int requestId, string text)
		{
			IntCommentsService.<CreatePartRequestComment>d__3 <CreatePartRequestComment>d__;
			<CreatePartRequestComment>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<CreatePartRequestComment>d__.<>4__this = this;
			<CreatePartRequestComment>d__.requestId = requestId;
			<CreatePartRequestComment>d__.text = text;
			<CreatePartRequestComment>d__.<>1__state = -1;
			<CreatePartRequestComment>d__.<>t__builder.Start<IntCommentsService.<CreatePartRequestComment>d__3>(ref <CreatePartRequestComment>d__);
			return <CreatePartRequestComment>d__.<>t__builder.Task;
		}

		// Token: 0x06003A29 RID: 14889 RVA: 0x000DD104 File Offset: 0x000DB304
		public Task<List<comments>> GetRepairComments(int repairId)
		{
			IntCommentsService.<GetRepairComments>d__4 <GetRepairComments>d__;
			<GetRepairComments>d__.<>t__builder = AsyncTaskMethodBuilder<List<comments>>.Create();
			<GetRepairComments>d__.repairId = repairId;
			<GetRepairComments>d__.<>1__state = -1;
			<GetRepairComments>d__.<>t__builder.Start<IntCommentsService.<GetRepairComments>d__4>(ref <GetRepairComments>d__);
			return <GetRepairComments>d__.<>t__builder.Task;
		}

		// Token: 0x06003A2A RID: 14890 RVA: 0x000DD148 File Offset: 0x000DB348
		public Task<List<comments>> GetRequestComments(int requestId)
		{
			IntCommentsService.<GetRequestComments>d__5 <GetRequestComments>d__;
			<GetRequestComments>d__.<>t__builder = AsyncTaskMethodBuilder<List<comments>>.Create();
			<GetRequestComments>d__.requestId = requestId;
			<GetRequestComments>d__.<>1__state = -1;
			<GetRequestComments>d__.<>t__builder.Start<IntCommentsService.<GetRequestComments>d__5>(ref <GetRequestComments>d__);
			return <GetRequestComments>d__.<>t__builder.Task;
		}

		// Token: 0x06003A2B RID: 14891 RVA: 0x000DD18C File Offset: 0x000DB38C
		public Task<List<comments>> GetTaskComments(int taskId)
		{
			IntCommentsService.<GetTaskComments>d__6 <GetTaskComments>d__;
			<GetTaskComments>d__.<>t__builder = AsyncTaskMethodBuilder<List<comments>>.Create();
			<GetTaskComments>d__.taskId = taskId;
			<GetTaskComments>d__.<>1__state = -1;
			<GetTaskComments>d__.<>t__builder.Start<IntCommentsService.<GetTaskComments>d__6>(ref <GetTaskComments>d__);
			return <GetTaskComments>d__.<>t__builder.Task;
		}

		// Token: 0x06003A2C RID: 14892 RVA: 0x000DD1D0 File Offset: 0x000DB3D0
		public Task CreateTaskComment(int taskId, string comment)
		{
			IntCommentsService.<CreateTaskComment>d__7 <CreateTaskComment>d__;
			<CreateTaskComment>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<CreateTaskComment>d__.<>4__this = this;
			<CreateTaskComment>d__.taskId = taskId;
			<CreateTaskComment>d__.comment = comment;
			<CreateTaskComment>d__.<>1__state = -1;
			<CreateTaskComment>d__.<>t__builder.Start<IntCommentsService.<CreateTaskComment>d__7>(ref <CreateTaskComment>d__);
			return <CreateTaskComment>d__.<>t__builder.Task;
		}

		// Token: 0x06003A2D RID: 14893 RVA: 0x000DD224 File Offset: 0x000DB424
		public IntCommentsService()
		{
		}

		// Token: 0x06003A2E RID: 14894 RVA: 0x000DD248 File Offset: 0x000DB448
		// Note: this type is marked as 'beforefieldinit'.
		static IntCommentsService()
		{
		}

		// Token: 0x04002505 RID: 9477
		private static readonly ILogger Log = LogManager.GetCurrentClassLogger();

		// Token: 0x04002506 RID: 9478
		private readonly Localization _localization = new Localization("UTC");

		// Token: 0x02000718 RID: 1816
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateRepairComment>d__2 : IAsyncStateMachine
		{
			// Token: 0x06003A2F RID: 14895 RVA: 0x000DD260 File Offset: 0x000DB460
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IntCommentsService intCommentsService = this.<>4__this;
				try
				{
					comments entity;
					if (num != 0)
					{
						entity = new comments
						{
							created = new DateTime?(intCommentsService._localization.Now),
							text = this.text,
							user = OfflineData.Instance.Employee.Id,
							remont = new int?(this.repairId)
						};
					}
					try
					{
						if (num != 0)
						{
							this.<history>5__2 = new HistoryV2();
							this.<ctx>5__3 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<int> awaiter;
							if (num != 0)
							{
								this.<ctx>5__3.comments.Attach(entity);
								this.<ctx>5__3.Entry<comments>(entity).State = EntityState.Added;
								this.<history>5__2.AddRepairLog("addIntComment", this.repairId, null, null, null, null, null, null);
								awaiter = this.<ctx>5__3.SaveChangesAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, IntCommentsService.<CreateRepairComment>d__2>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<int>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							awaiter.GetResult();
							this.<history>5__2.Save();
						}
						finally
						{
							if (num < 0 && this.<ctx>5__3 != null)
							{
								((IDisposable)this.<ctx>5__3).Dispose();
							}
						}
						this.<ctx>5__3 = null;
						this.<history>5__2 = null;
					}
					catch (Exception exception)
					{
						IntCommentsService.Log.Error(exception, "Add new repair comment fail");
					}
				}
				catch (Exception exception2)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception2);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003A30 RID: 14896 RVA: 0x000DD450 File Offset: 0x000DB650
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002507 RID: 9479
			public int <>1__state;

			// Token: 0x04002508 RID: 9480
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002509 RID: 9481
			public IntCommentsService <>4__this;

			// Token: 0x0400250A RID: 9482
			public string text;

			// Token: 0x0400250B RID: 9483
			public int repairId;

			// Token: 0x0400250C RID: 9484
			private HistoryV2 <history>5__2;

			// Token: 0x0400250D RID: 9485
			private auseceEntities <ctx>5__3;

			// Token: 0x0400250E RID: 9486
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x02000719 RID: 1817
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreatePartRequestComment>d__3 : IAsyncStateMachine
		{
			// Token: 0x06003A31 RID: 14897 RVA: 0x000DD46C File Offset: 0x000DB66C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IntCommentsService intCommentsService = this.<>4__this;
				try
				{
					comments entity;
					if (num != 0)
					{
						entity = new comments
						{
							created = new DateTime?(intCommentsService._localization.Now),
							text = this.text,
							user = Auth.User.id,
							part_request = new int?(this.requestId)
						};
					}
					try
					{
						if (num != 0)
						{
							this.<history>5__2 = new HistoryV2();
							this.<ctx>5__3 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<int> awaiter;
							if (num != 0)
							{
								this.<ctx>5__3.comments.Attach(entity);
								this.<ctx>5__3.Entry<comments>(entity).State = EntityState.Added;
								this.<history>5__2.AddPartsRequestLog("addIntComment", this.requestId, "", "");
								awaiter = this.<ctx>5__3.SaveChangesAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, IntCommentsService.<CreatePartRequestComment>d__3>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<int>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							awaiter.GetResult();
							this.<history>5__2.Save();
						}
						finally
						{
							if (num < 0 && this.<ctx>5__3 != null)
							{
								((IDisposable)this.<ctx>5__3).Dispose();
							}
						}
						this.<ctx>5__3 = null;
						this.<history>5__2 = null;
					}
					catch (Exception exception)
					{
						IntCommentsService.Log.Error(exception, "Add new repair comment fail");
					}
				}
				catch (Exception exception2)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception2);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003A32 RID: 14898 RVA: 0x000DD660 File Offset: 0x000DB860
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400250F RID: 9487
			public int <>1__state;

			// Token: 0x04002510 RID: 9488
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002511 RID: 9489
			public IntCommentsService <>4__this;

			// Token: 0x04002512 RID: 9490
			public string text;

			// Token: 0x04002513 RID: 9491
			public int requestId;

			// Token: 0x04002514 RID: 9492
			private HistoryV2 <history>5__2;

			// Token: 0x04002515 RID: 9493
			private auseceEntities <ctx>5__3;

			// Token: 0x04002516 RID: 9494
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x0200071A RID: 1818
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x06003A33 RID: 14899 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x04002517 RID: 9495
			public int repairId;
		}

		// Token: 0x0200071B RID: 1819
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003A34 RID: 14900 RVA: 0x000DD67C File Offset: 0x000DB87C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003A35 RID: 14901 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x04002518 RID: 9496
			public static readonly IntCommentsService.<>c <>9 = new IntCommentsService.<>c();
		}

		// Token: 0x0200071C RID: 1820
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetRepairComments>d__4 : IAsyncStateMachine
		{
			// Token: 0x06003A36 RID: 14902 RVA: 0x000DD694 File Offset: 0x000DB894
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<comments> result;
				try
				{
					IntCommentsService.<>c__DisplayClass4_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new IntCommentsService.<>c__DisplayClass4_0();
						CS$<>8__locals1.repairId = this.repairId;
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<List<comments>> awaiter;
						if (num != 0)
						{
							awaiter = (from c in (from c in this.<ctx>5__2.comments
							where c.remont == (int?)CS$<>8__locals1.repairId
							select c).Include((comments c) => c.users)
							orderby c.id descending
							select c).ToListAsync<comments>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<comments>>, IntCommentsService.<GetRepairComments>d__4>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<comments>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult();
					}
					catch (Exception exception)
					{
						IntCommentsService.Log.Error(exception, "Load repair comments fail");
						result = new List<comments>();
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
						}
					}
				}
				catch (Exception exception2)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception2);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06003A37 RID: 14903 RVA: 0x000DD8DC File Offset: 0x000DBADC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002519 RID: 9497
			public int <>1__state;

			// Token: 0x0400251A RID: 9498
			public AsyncTaskMethodBuilder<List<comments>> <>t__builder;

			// Token: 0x0400251B RID: 9499
			public int repairId;

			// Token: 0x0400251C RID: 9500
			private auseceEntities <ctx>5__2;

			// Token: 0x0400251D RID: 9501
			private TaskAwaiter<List<comments>> <>u__1;
		}

		// Token: 0x0200071D RID: 1821
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06003A38 RID: 14904 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x0400251E RID: 9502
			public int requestId;
		}

		// Token: 0x0200071E RID: 1822
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetRequestComments>d__5 : IAsyncStateMachine
		{
			// Token: 0x06003A39 RID: 14905 RVA: 0x000DD8F8 File Offset: 0x000DBAF8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<comments> result;
				try
				{
					IntCommentsService.<>c__DisplayClass5_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new IntCommentsService.<>c__DisplayClass5_0();
						CS$<>8__locals1.requestId = this.requestId;
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<List<comments>> awaiter;
						if (num != 0)
						{
							awaiter = (from c in (from c in this.<ctx>5__2.comments
							where c.part_request == (int?)CS$<>8__locals1.requestId
							select c).Include((comments c) => c.users)
							orderby c.id descending
							select c).ToListAsync<comments>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<comments>>, IntCommentsService.<GetRequestComments>d__5>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<comments>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult();
					}
					catch (Exception exception)
					{
						IntCommentsService.Log.Error(exception, "Load part request comments fail");
						result = new List<comments>();
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
						}
					}
				}
				catch (Exception exception2)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception2);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06003A3A RID: 14906 RVA: 0x000DDB40 File Offset: 0x000DBD40
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400251F RID: 9503
			public int <>1__state;

			// Token: 0x04002520 RID: 9504
			public AsyncTaskMethodBuilder<List<comments>> <>t__builder;

			// Token: 0x04002521 RID: 9505
			public int requestId;

			// Token: 0x04002522 RID: 9506
			private auseceEntities <ctx>5__2;

			// Token: 0x04002523 RID: 9507
			private TaskAwaiter<List<comments>> <>u__1;
		}

		// Token: 0x0200071F RID: 1823
		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x06003A3B RID: 14907 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x04002524 RID: 9508
			public int taskId;
		}

		// Token: 0x02000720 RID: 1824
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetTaskComments>d__6 : IAsyncStateMachine
		{
			// Token: 0x06003A3C RID: 14908 RVA: 0x000DDB5C File Offset: 0x000DBD5C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<comments> result;
				try
				{
					IntCommentsService.<>c__DisplayClass6_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new IntCommentsService.<>c__DisplayClass6_0();
						CS$<>8__locals1.taskId = this.taskId;
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<List<comments>> awaiter;
						if (num != 0)
						{
							awaiter = (from c in (from c in this.<ctx>5__2.comments
							where c.task_id == (int?)CS$<>8__locals1.taskId
							select c).Include((comments c) => c.users)
							orderby c.id descending
							select c).ToListAsync<comments>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<comments>>, IntCommentsService.<GetTaskComments>d__6>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<comments>>);
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

			// Token: 0x06003A3D RID: 14909 RVA: 0x000DDD6C File Offset: 0x000DBF6C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002525 RID: 9509
			public int <>1__state;

			// Token: 0x04002526 RID: 9510
			public AsyncTaskMethodBuilder<List<comments>> <>t__builder;

			// Token: 0x04002527 RID: 9511
			public int taskId;

			// Token: 0x04002528 RID: 9512
			private auseceEntities <ctx>5__2;

			// Token: 0x04002529 RID: 9513
			private TaskAwaiter<List<comments>> <>u__1;
		}

		// Token: 0x02000721 RID: 1825
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateTaskComment>d__7 : IAsyncStateMachine
		{
			// Token: 0x06003A3E RID: 14910 RVA: 0x000DDD88 File Offset: 0x000DBF88
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IntCommentsService intCommentsService = this.<>4__this;
				try
				{
					if (num != 0)
					{
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<int> awaiter;
						if (num != 0)
						{
							this.<ctx>5__2.comments.Add(new comments
							{
								created = new DateTime?(intCommentsService._localization.Now),
								text = this.comment,
								user = OfflineData.Instance.Employee.Id,
								task_id = new int?(this.taskId)
							});
							awaiter = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, IntCommentsService.<CreateTaskComment>d__7>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<int>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						awaiter.GetResult();
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
						}
					}
					this.<ctx>5__2 = null;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003A3F RID: 14911 RVA: 0x000DDEE0 File Offset: 0x000DC0E0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400252A RID: 9514
			public int <>1__state;

			// Token: 0x0400252B RID: 9515
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400252C RID: 9516
			public IntCommentsService <>4__this;

			// Token: 0x0400252D RID: 9517
			public string comment;

			// Token: 0x0400252E RID: 9518
			public int taskId;

			// Token: 0x0400252F RID: 9519
			private auseceEntities <ctx>5__2;

			// Token: 0x04002530 RID: 9520
			private TaskAwaiter<int> <>u__1;
		}
	}
}
