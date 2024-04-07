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
using ASC.Common.SimpleClasses;
using ASC.Models;
using ASC.Objects;
using ASC.Objects.Converters;
using ASC.Services.Abstract;
using Autofac;
using DevExpress.Mvvm;

namespace ASC.Services.Concrete
{
	// Token: 0x020007A4 RID: 1956
	public class TaskService : ITaskService
	{
		// Token: 0x06003BCB RID: 15307 RVA: 0x000EC400 File Offset: 0x000EA600
		public TaskService(ILoggerService<TaskService> loggerService)
		{
			this._loggerService = loggerService;
		}

		// Token: 0x06003BCC RID: 15308 RVA: 0x000EC41C File Offset: 0x000EA61C
		public Task CancelTasks(IList<int> taskIds)
		{
			TaskService.<CancelTasks>d__2 <CancelTasks>d__;
			<CancelTasks>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<CancelTasks>d__.taskIds = taskIds;
			<CancelTasks>d__.<>1__state = -1;
			<CancelTasks>d__.<>t__builder.Start<TaskService.<CancelTasks>d__2>(ref <CancelTasks>d__);
			return <CancelTasks>d__.<>t__builder.Task;
		}

		// Token: 0x06003BCD RID: 15309 RVA: 0x000EC460 File Offset: 0x000EA660
		public static tasks DefaultTask()
		{
			Localization localization = new Localization("UTC");
			return new tasks
			{
				created = DateTime.UtcNow,
				start_datetime = localization.Now,
				state = 1,
				priority = 1
			};
		}

		// Token: 0x06003BCE RID: 15310 RVA: 0x000EC4A4 File Offset: 0x000EA6A4
		public Task<IAscTask> GetTask(int taskId)
		{
			TaskService.<GetTask>d__4 <GetTask>d__;
			<GetTask>d__.<>t__builder = AsyncTaskMethodBuilder<IAscTask>.Create();
			<GetTask>d__.taskId = taskId;
			<GetTask>d__.<>1__state = -1;
			<GetTask>d__.<>t__builder.Start<TaskService.<GetTask>d__4>(ref <GetTask>d__);
			return <GetTask>d__.<>t__builder.Task;
		}

		// Token: 0x06003BCF RID: 15311 RVA: 0x000EC4E8 File Offset: 0x000EA6E8
		public void Task4FireItems(IEnumerable<store_items> fireItems)
		{
			TaskService.<Task4FireItems>d__5 <Task4FireItems>d__;
			<Task4FireItems>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Task4FireItems>d__.<>4__this = this;
			<Task4FireItems>d__.fireItems = fireItems;
			<Task4FireItems>d__.<>1__state = -1;
			<Task4FireItems>d__.<>t__builder.Start<TaskService.<Task4FireItems>d__5>(ref <Task4FireItems>d__);
		}

		// Token: 0x06003BD0 RID: 15312 RVA: 0x000EC528 File Offset: 0x000EA728
		private static void AssingEmployee(int employeeId, int taskId, auseceEntities ctx)
		{
			task_employees entity = new task_employees
			{
				employee = employeeId,
				task = taskId
			};
			ctx.task_employees.Add(entity);
		}

		// Token: 0x06003BD1 RID: 15313 RVA: 0x000EC558 File Offset: 0x000EA758
		public Task<IEnumerable<tasks>> GetTasks(Period period, int userId, int status, int priority, int taskType, string query, int direction)
		{
			DateTime from = period.From.Date;
			DateTime to = period.To.Date.AddDays(1.0).AddSeconds(-1.0);
			Task<IEnumerable<tasks>> allAsync;
			using (GenericRepository<tasks> genericRepository = new GenericRepository<tasks>())
			{
				genericRepository.AsNoTracking();
				genericRepository.SetTimeout(180);
				List<KeyValuePair<bool, Expression<Func<tasks, bool>>>> filterList = new List<KeyValuePair<bool, Expression<Func<tasks, bool>>>>
				{
					new KeyValuePair<bool, Expression<Func<tasks, bool>>>(direction == 2, (tasks t) => t.task_author == (int?)OfflineData.Instance.Employee.Id),
					new KeyValuePair<bool, Expression<Func<tasks, bool>>>(userId != 0 && direction == 1, (tasks t) => t.task_employees.Any((task_employees te) => te.employee == userId)),
					new KeyValuePair<bool, Expression<Func<tasks, bool>>>(taskType != -1 && taskType != -2, (tasks t) => t.type == taskType),
					new KeyValuePair<bool, Expression<Func<tasks, bool>>>(status == -1, (tasks t) => t.state != 2 && t.state != 5),
					new KeyValuePair<bool, Expression<Func<tasks, bool>>>(status != -1, (tasks t) => t.start_datetime >= from && t.start_datetime <= to),
					new KeyValuePair<bool, Expression<Func<tasks, bool>>>(status > 0, (tasks t) => t.state == status),
					new KeyValuePair<bool, Expression<Func<tasks, bool>>>(priority != 0, (tasks t) => t.priority == priority),
					new KeyValuePair<bool, Expression<Func<tasks, bool>>>(!string.IsNullOrEmpty(query), (tasks t) => t.title.Contains(query) || t.text.Contains(query))
				};
				allAsync = genericRepository.GetAllAsync(filterList, delegate(IQueryable<tasks> i)
				{
					return from d in i
					orderby d.start_datetime descending
					select d;
				}, "task_employees.users", false);
			}
			return allAsync;
		}

		// Token: 0x06003BD2 RID: 15314 RVA: 0x000ECB9C File Offset: 0x000EAD9C
		public void UpdateTaskState(parts_request request, int state)
		{
			if (request == null)
			{
				return;
			}
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					List<tasks> list = (from t in auseceEntities.tasks
					where t.part_request == (int?)request.id && t.type == 12
					select t).ToList<tasks>();
					if (list.Any<tasks>())
					{
						foreach (tasks tasks in list)
						{
							tasks.state = state;
						}
						auseceEntities.SaveChanges();
					}
				}
			}
			catch (Exception e)
			{
				this._loggerService.Error(e, "Update task state error");
			}
		}

		// Token: 0x06003BD3 RID: 15315 RVA: 0x000ECD40 File Offset: 0x000EAF40
		public Task<bool> UpdateTask(IAscTask task)
		{
			TaskService.<UpdateTask>d__9 <UpdateTask>d__;
			<UpdateTask>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<UpdateTask>d__.<>4__this = this;
			<UpdateTask>d__.task = task;
			<UpdateTask>d__.<>1__state = -1;
			<UpdateTask>d__.<>t__builder.Start<TaskService.<UpdateTask>d__9>(ref <UpdateTask>d__);
			return <UpdateTask>d__.<>t__builder.Task;
		}

		// Token: 0x06003BD4 RID: 15316 RVA: 0x000ECD8C File Offset: 0x000EAF8C
		public List<KeyValuePair<int, string>> LoadPriorities(bool includeAll = false)
		{
			List<KeyValuePair<int, string>> result;
			try
			{
				List<KeyValuePair<int, string>> list = new List<KeyValuePair<int, string>>
				{
					new KeyValuePair<int, string>(1, Lang.t("Normal")),
					new KeyValuePair<int, string>(2, Lang.t("Hight")),
					new KeyValuePair<int, string>(3, Lang.t("Low"))
				};
				TaskService.IncludeAll(includeAll, list);
				result = list;
			}
			catch (Exception e)
			{
				this._loggerService.Error(e, "Load priorities fail");
				result = new List<KeyValuePair<int, string>>();
			}
			return result;
		}

		// Token: 0x06003BD5 RID: 15317 RVA: 0x000ECE18 File Offset: 0x000EB018
		public List<KeyValuePair<AscTaskPriority, string>> GetTaskPriorities()
		{
			return new List<KeyValuePair<AscTaskPriority, string>>
			{
				new KeyValuePair<AscTaskPriority, string>(AscTaskPriority.Normal, Lang.t("Normal")),
				new KeyValuePair<AscTaskPriority, string>(AscTaskPriority.High, Lang.t("Hight")),
				new KeyValuePair<AscTaskPriority, string>(AscTaskPriority.Low, Lang.t("Low"))
			};
		}

		// Token: 0x06003BD6 RID: 15318 RVA: 0x000ECE6C File Offset: 0x000EB06C
		public List<KeyValuePair<AscTaskStatus, string>> GetTaskStatuses()
		{
			return new List<KeyValuePair<AscTaskStatus, string>>
			{
				new KeyValuePair<AscTaskStatus, string>(AscTaskStatus.Active, Lang.t("NotStarted")),
				new KeyValuePair<AscTaskStatus, string>(AscTaskStatus.Completed, Lang.t("TaskComplete")),
				new KeyValuePair<AscTaskStatus, string>(AscTaskStatus.Hold, Lang.t("Holded")),
				new KeyValuePair<AscTaskStatus, string>(AscTaskStatus.InProgress, Lang.t("InProgress")),
				new KeyValuePair<AscTaskStatus, string>(AscTaskStatus.Cancelled, Lang.t("Cancelled2"))
			};
		}

		// Token: 0x06003BD7 RID: 15319 RVA: 0x000ECEEC File Offset: 0x000EB0EC
		public List<KeyValuePair<AscTaskStatus, string>> GetTaskDeviceMatchStatuses(int taskAuthorId)
		{
			List<KeyValuePair<AscTaskStatus, string>> list = new List<KeyValuePair<AscTaskStatus, string>>
			{
				new KeyValuePair<AscTaskStatus, string>(AscTaskStatus.Active, Lang.t("NotStarted")),
				new KeyValuePair<AscTaskStatus, string>(AscTaskStatus.Completed, Lang.t("TaskComplete"))
			};
			if (taskAuthorId == Auth.User.id)
			{
				list.Insert(0, new KeyValuePair<AscTaskStatus, string>(AscTaskStatus.Created, Lang.t("Created")));
			}
			return list;
		}

		// Token: 0x06003BD8 RID: 15320 RVA: 0x000ECF50 File Offset: 0x000EB150
		public List<KeyValuePair<int, string>> LoadTaskStatuses(bool includeAll = false)
		{
			List<KeyValuePair<int, string>> result;
			try
			{
				List<KeyValuePair<int, string>> list = new List<KeyValuePair<int, string>>
				{
					new KeyValuePair<int, string>(1, Lang.t("NotStarted")),
					new KeyValuePair<int, string>(2, Lang.t("TaskComplete")),
					new KeyValuePair<int, string>(3, Lang.t("Holded")),
					new KeyValuePair<int, string>(4, Lang.t("InProgress")),
					new KeyValuePair<int, string>(5, Lang.t("Cancelled2"))
				};
				if (includeAll)
				{
					list.Add(new KeyValuePair<int, string>(0, Lang.t("All")));
					list.Add(new KeyValuePair<int, string>(-1, Lang.t("OnlyActual")));
				}
				result = list;
			}
			catch (Exception e)
			{
				this._loggerService.Error(e, "Load task statuses fail");
				result = new List<KeyValuePair<int, string>>();
			}
			return result;
		}

		// Token: 0x06003BD9 RID: 15321 RVA: 0x000ED030 File Offset: 0x000EB230
		private static void IncludeAll(bool includeAll, List<KeyValuePair<int, string>> result)
		{
			if (includeAll)
			{
				result.Add(new KeyValuePair<int, string>(0, Lang.t("All")));
			}
		}

		// Token: 0x06003BDA RID: 15322 RVA: 0x000ED058 File Offset: 0x000EB258
		public List<KeyValuePair<int, string>> LoadTaskTypes(bool includeAll = false)
		{
			List<KeyValuePair<int, string>> result;
			try
			{
				List<KeyValuePair<int, string>> list = new List<KeyValuePair<int, string>>
				{
					new KeyValuePair<int, string>(4, Lang.t("CustomTask")),
					new KeyValuePair<int, string>(10, Lang.t("RemoteRequestItem")),
					new KeyValuePair<int, string>(11, Lang.t("RemoteServicesRequest")),
					new KeyValuePair<int, string>(20, Lang.t("Callback"))
				};
				if (includeAll)
				{
					list.Add(new KeyValuePair<int, string>(-2, Lang.t("All")));
				}
				result = list;
			}
			catch (Exception e)
			{
				this._loggerService.Error(e, "Load task types fail");
				result = new List<KeyValuePair<int, string>>();
			}
			return result;
		}

		// Token: 0x06003BDB RID: 15323 RVA: 0x000ED110 File Offset: 0x000EB310
		public int CreateTask(IAscTask t)
		{
			int result;
			using (auseceEntities auseceEntities = new auseceEntities(true))
			{
				result = this.CreateTask(auseceEntities, t);
			}
			return result;
		}

		// Token: 0x06003BDC RID: 15324 RVA: 0x000ED14C File Offset: 0x000EB34C
		public int CreateTask(auseceEntities ctx, IAscTask t)
		{
			if (t.Type == TaskType.DeviceMatch)
			{
				t.Status = AscTaskStatus.Created;
				if (t.ResponsibleUsers.All((int u) => u != OfflineData.Instance.Employee.Id))
				{
					t.AddResponsibleUser(OfflineData.Instance.Employee.Id);
				}
			}
			tasks tasks = t.BackToTask();
			ctx.tasks.Add(tasks);
			ctx.SaveChanges();
			foreach (int num in t.ResponsibleUsers)
			{
				TaskService.AssingEmployee(num, tasks.idt, ctx);
				if (OfflineData.Instance.Settings.InformTaskRequest && tasks.type == 10)
				{
					this.CreateNotifications(ctx, num, tasks, tasks.text);
				}
				if (tasks.type == 20)
				{
					AscNotification ascNotification = TaskService.CreateNotification(num);
					ascNotification.CallbackToCustomer(t.CustomerId.Value, t.Message);
					ascNotification.TaskId = new int?(tasks.idt);
					ctx.notifications.Add(ascNotification.BackToNotification());
				}
			}
			ctx.SaveChanges();
			return tasks.idt;
		}

		// Token: 0x06003BDD RID: 15325 RVA: 0x000ED2A0 File Offset: 0x000EB4A0
		private static AscNotification CreateNotification(int employeeId)
		{
			AscNotification ascNotification = new AscNotification();
			ascNotification.SetEmployee(employeeId);
			return ascNotification;
		}

		// Token: 0x06003BDE RID: 15326 RVA: 0x000ED2BC File Offset: 0x000EB4BC
		public void CreateNotifications(auseceEntities ctx, int user, tasks task, string text)
		{
			AscNotification ascNotification = TaskService.CreateNotification(user);
			ascNotification.TaskSiteRequest(task.idt, text, (TaskType)task.type);
			ctx.notifications.Add(ascNotification.BackToNotification());
		}

		// Token: 0x06003BDF RID: 15327 RVA: 0x000ED2F8 File Offset: 0x000EB4F8
		public void CreateNotifications(auseceEntities ctx, int user, int customerId, string text)
		{
			AscNotification ascNotification = TaskService.CreateNotification(user);
			ascNotification.NewCustomer(customerId, text);
			ctx.notifications.Add(ascNotification.BackToNotification());
		}

		// Token: 0x06003BE0 RID: 15328 RVA: 0x000ED328 File Offset: 0x000EB528
		public Task<int> GetActiveTaskIds()
		{
			TaskService.<GetActiveTaskIds>d__22 <GetActiveTaskIds>d__;
			<GetActiveTaskIds>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<GetActiveTaskIds>d__.<>4__this = this;
			<GetActiveTaskIds>d__.<>1__state = -1;
			<GetActiveTaskIds>d__.<>t__builder.Start<TaskService.<GetActiveTaskIds>d__22>(ref <GetActiveTaskIds>d__);
			return <GetActiveTaskIds>d__.<>t__builder.Task;
		}

		// Token: 0x04002714 RID: 10004
		private readonly ILoggerService<TaskService> _loggerService;

		// Token: 0x020007A5 RID: 1957
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x06003BE1 RID: 15329 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x04002715 RID: 10005
			public IList<int> taskIds;
		}

		// Token: 0x020007A6 RID: 1958
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CancelTasks>d__2 : IAsyncStateMachine
		{
			// Token: 0x06003BE2 RID: 15330 RVA: 0x000ED36C File Offset: 0x000EB56C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					TaskService.<>c__DisplayClass2_0 CS$<>8__locals1;
					if (num > 1)
					{
						CS$<>8__locals1 = new TaskService.<>c__DisplayClass2_0();
						CS$<>8__locals1.taskIds = this.taskIds;
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<int> awaiter;
						TaskAwaiter<List<tasks>> awaiter2;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<int>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								goto IL_1AD;
							}
							awaiter2 = (from i in this.<ctx>5__2.tasks
							where CS$<>8__locals1.taskIds.Contains(i.idt)
							select i).ToListAsync<tasks>().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num3 = 0;
								num = 0;
								this.<>1__state = num3;
								this.<>u__1 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<tasks>>, TaskService.<CancelTasks>d__2>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<tasks>>);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
						}
						List<tasks>.Enumerator enumerator = awaiter2.GetResult().GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								tasks tasks = enumerator.Current;
								tasks.state = 5;
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)enumerator).Dispose();
							}
						}
						awaiter = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num5 = 1;
							num = 1;
							this.<>1__state = num5;
							this.<>u__2 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, TaskService.<CancelTasks>d__2>(ref awaiter, ref this);
							return;
						}
						IL_1AD:
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

			// Token: 0x06003BE3 RID: 15331 RVA: 0x000ED5CC File Offset: 0x000EB7CC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002716 RID: 10006
			public int <>1__state;

			// Token: 0x04002717 RID: 10007
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002718 RID: 10008
			public IList<int> taskIds;

			// Token: 0x04002719 RID: 10009
			private auseceEntities <ctx>5__2;

			// Token: 0x0400271A RID: 10010
			private TaskAwaiter<List<tasks>> <>u__1;

			// Token: 0x0400271B RID: 10011
			private TaskAwaiter<int> <>u__2;
		}

		// Token: 0x020007A7 RID: 1959
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x06003BE4 RID: 15332 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x0400271C RID: 10012
			public int taskId;
		}

		// Token: 0x020007A8 RID: 1960
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetTask>d__4 : IAsyncStateMachine
		{
			// Token: 0x06003BE5 RID: 15333 RVA: 0x000ED5E8 File Offset: 0x000EB7E8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IAscTask result;
				try
				{
					TaskService.<>c__DisplayClass4_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new TaskService.<>c__DisplayClass4_0();
						CS$<>8__locals1.taskId = this.taskId;
						this.<repo>5__2 = new GenericRepository<tasks>();
					}
					try
					{
						TaskAwaiter<tasks> awaiter;
						if (num != 0)
						{
							awaiter = this.<repo>5__2.GetFirstOrDefaultAsync((tasks t) => t.idt == CS$<>8__locals1.taskId, "task_employees").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<tasks>, TaskService.<GetTask>d__4>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<tasks>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult().ToAscTask();
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

			// Token: 0x06003BE6 RID: 15334 RVA: 0x000ED768 File Offset: 0x000EB968
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400271D RID: 10013
			public int <>1__state;

			// Token: 0x0400271E RID: 10014
			public AsyncTaskMethodBuilder<IAscTask> <>t__builder;

			// Token: 0x0400271F RID: 10015
			public int taskId;

			// Token: 0x04002720 RID: 10016
			private GenericRepository<tasks> <repo>5__2;

			// Token: 0x04002721 RID: 10017
			private TaskAwaiter<tasks> <>u__1;
		}

		// Token: 0x020007A9 RID: 1961
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003BE7 RID: 15335 RVA: 0x000ED784 File Offset: 0x000EB984
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003BE8 RID: 15336 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06003BE9 RID: 15337 RVA: 0x00057F3C File Offset: 0x0005613C
			internal int <Task4FireItems>b__5_0(users u)
			{
				return u.id;
			}

			// Token: 0x06003BEA RID: 15338 RVA: 0x000ED79C File Offset: 0x000EB99C
			internal IOrderedQueryable<tasks> <GetTasks>b__7_0(IQueryable<tasks> i)
			{
				return from d in i
				orderby d.start_datetime descending
				select d;
			}

			// Token: 0x06003BEB RID: 15339 RVA: 0x000ED7E8 File Offset: 0x000EB9E8
			internal bool <CreateTask>b__18_0(int u)
			{
				return u != OfflineData.Instance.Employee.Id;
			}

			// Token: 0x04002722 RID: 10018
			public static readonly TaskService.<>c <>9 = new TaskService.<>c();

			// Token: 0x04002723 RID: 10019
			public static Func<users, int> <>9__5_0;

			// Token: 0x04002724 RID: 10020
			public static Func<IQueryable<tasks>, IOrderedQueryable<tasks>> <>9__7_0;

			// Token: 0x04002725 RID: 10021
			public static Func<int, bool> <>9__18_0;
		}

		// Token: 0x020007AA RID: 1962
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Task4FireItems>d__5 : IAsyncStateMachine
		{
			// Token: 0x06003BEC RID: 15340 RVA: 0x000ED80C File Offset: 0x000EBA0C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				TaskService taskService = this.<>4__this;
				try
				{
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2 = new auseceEntities(true);
						}
						try
						{
							if (num != 0)
							{
								this.<>7__wrap2 = this.fireItems.GetEnumerator();
							}
							try
							{
								if (num != 0)
								{
									goto IL_1AE;
								}
								TaskAwaiter<List<users>> awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<List<users>>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								IL_57:
								List<users> result = awaiter.GetResult();
								this.<prm>5__5.CreateRequest(this.<request>5__6, result.Select(new Func<users, int>(TaskService.<>c.<>9.<Task4FireItems>b__5_0)).ToList<int>());
								int num3 = this.<item>5__4.minimum_in_stock - this.<item>5__4.count;
								tasks tasks = TaskService.DefaultTask();
								tasks.type = 12;
								tasks.title = Lang.t("BuyItems");
								tasks.text = string.Format(Lang.t("RequestPartsTask"), this.<item>5__4.UID, this.<item>5__4.name, num3);
								tasks.item_id = new int?(this.<item>5__4.id);
								tasks.is_timelimit = false;
								tasks.top_user = Auth.User.offices1.administrator;
								tasks.part_request = new int?(this.<request>5__6.id);
								this.<ctx>5__2.tasks.Add(tasks);
								this.<ctx>5__2.SaveChanges();
								TaskService.AssingEmployee(Auth.User.id, tasks.idt, this.<ctx>5__2);
								this.<ctx>5__2.SaveChanges();
								this.<prm>5__5 = null;
								this.<request>5__6 = null;
								this.<item>5__4 = null;
								IL_1AE:
								if (this.<>7__wrap2.MoveNext())
								{
									this.<item>5__4 = this.<>7__wrap2.Current;
									this.<prm>5__5 = Bootstrapper.Container.Resolve<IPartsRequestService>();
									this.<request>5__6 = this.<prm>5__5.NewRequest(this.<item>5__4);
									awaiter = new UsersModel().LoadPartRequestManagers().GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										int num4 = 0;
										num = 0;
										this.<>1__state = num4;
										this.<>u__1 = awaiter;
										this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<users>>, TaskService.<Task4FireItems>d__5>(ref awaiter, ref this);
										return;
									}
									goto IL_57;
								}
							}
							finally
							{
								if (num < 0 && this.<>7__wrap2 != null)
								{
									this.<>7__wrap2.Dispose();
								}
							}
							this.<>7__wrap2 = null;
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
					catch (Exception e)
					{
						taskService._loggerService.Error(e, "Create task fail");
					}
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

			// Token: 0x06003BED RID: 15341 RVA: 0x000EDB3C File Offset: 0x000EBD3C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002726 RID: 10022
			public int <>1__state;

			// Token: 0x04002727 RID: 10023
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04002728 RID: 10024
			public IEnumerable<store_items> fireItems;

			// Token: 0x04002729 RID: 10025
			public TaskService <>4__this;

			// Token: 0x0400272A RID: 10026
			private auseceEntities <ctx>5__2;

			// Token: 0x0400272B RID: 10027
			private IEnumerator<store_items> <>7__wrap2;

			// Token: 0x0400272C RID: 10028
			private store_items <item>5__4;

			// Token: 0x0400272D RID: 10029
			private IPartsRequestService <prm>5__5;

			// Token: 0x0400272E RID: 10030
			private parts_request <request>5__6;

			// Token: 0x0400272F RID: 10031
			private TaskAwaiter<List<users>> <>u__1;
		}

		// Token: 0x020007AB RID: 1963
		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x06003BEE RID: 15342 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x04002730 RID: 10032
			public int userId;

			// Token: 0x04002731 RID: 10033
			public int taskType;

			// Token: 0x04002732 RID: 10034
			public DateTime from;

			// Token: 0x04002733 RID: 10035
			public DateTime to;

			// Token: 0x04002734 RID: 10036
			public int status;

			// Token: 0x04002735 RID: 10037
			public int priority;

			// Token: 0x04002736 RID: 10038
			public string query;
		}

		// Token: 0x020007AC RID: 1964
		[CompilerGenerated]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x06003BEF RID: 15343 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x04002737 RID: 10039
			public parts_request request;
		}

		// Token: 0x020007AD RID: 1965
		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x06003BF0 RID: 15344 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x04002738 RID: 10040
			public IAscTask task;
		}

		// Token: 0x020007AE RID: 1966
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateTask>d__9 : IAsyncStateMachine
		{
			// Token: 0x06003BF1 RID: 15345 RVA: 0x000EDB58 File Offset: 0x000EBD58
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				TaskService taskService = this.<>4__this;
				bool result2;
				try
				{
					if (num != 0)
					{
						this.<>8__1 = new TaskService.<>c__DisplayClass9_0();
						this.<>8__1.task = this.task;
					}
					try
					{
						if (num != 0)
						{
							this.<localization>5__2 = new Localization("UTC");
							if (this.<>8__1.task.Type == TaskType.DeviceMatch)
							{
								int? creatorId = this.<>8__1.task.CreatorId;
								int id = OfflineData.Instance.Employee.Id;
								if (!(creatorId.GetValueOrDefault() == id & creatorId != null))
								{
									this.<>8__1.task.Status = AscTaskStatus.Created;
								}
							}
							this.<ctx>5__3 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<List<tasks>> awaiter;
							if (num != 0)
							{
								awaiter = (from t in this.<ctx>5__3.tasks
								where t.idt == this.<>8__1.task.Id
								select t).ToListAsync<tasks>().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<tasks>>, TaskService.<UpdateTask>d__9>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<List<tasks>>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							List<tasks> result = awaiter.GetResult();
							if (!result.Any<tasks>())
							{
								result2 = false;
							}
							else
							{
								List<tasks>.Enumerator enumerator = result.GetEnumerator();
								try
								{
									while (enumerator.MoveNext())
									{
										tasks tasks = enumerator.Current;
										tasks.state = (int)this.<>8__1.task.Status;
										tasks.complete_datetime = new DateTime?(this.<localization>5__2.Now);
										tasks.m_match = this.<>8__1.task.MatchText;
										tasks.doc_id = this.<>8__1.task.DocumentId;
									}
								}
								finally
								{
									if (num < 0)
									{
										((IDisposable)enumerator).Dispose();
									}
								}
								this.<ctx>5__3.SaveChanges();
								Messenger.Default.Send(new Message(null, MessageType.TaskChanged));
								result2 = true;
							}
						}
						finally
						{
							if (num < 0 && this.<ctx>5__3 != null)
							{
								((IDisposable)this.<ctx>5__3).Dispose();
							}
						}
					}
					catch (Exception e)
					{
						taskService._loggerService.Error(e, "Update task state fail");
						result2 = false;
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06003BF2 RID: 15346 RVA: 0x000EDE88 File Offset: 0x000EC088
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002739 RID: 10041
			public int <>1__state;

			// Token: 0x0400273A RID: 10042
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x0400273B RID: 10043
			public IAscTask task;

			// Token: 0x0400273C RID: 10044
			private TaskService.<>c__DisplayClass9_0 <>8__1;

			// Token: 0x0400273D RID: 10045
			public TaskService <>4__this;

			// Token: 0x0400273E RID: 10046
			private Localization <localization>5__2;

			// Token: 0x0400273F RID: 10047
			private auseceEntities <ctx>5__3;

			// Token: 0x04002740 RID: 10048
			private TaskAwaiter<List<tasks>> <>u__1;
		}

		// Token: 0x020007AF RID: 1967
		[CompilerGenerated]
		private sealed class <>c__DisplayClass22_0
		{
			// Token: 0x06003BF3 RID: 15347 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass22_0()
			{
			}

			// Token: 0x04002741 RID: 10049
			public DateTime now;
		}

		// Token: 0x020007B0 RID: 1968
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetActiveTaskIds>d__22 : IAsyncStateMachine
		{
			// Token: 0x06003BF4 RID: 15348 RVA: 0x000EDEA4 File Offset: 0x000EC0A4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				TaskService taskService = this.<>4__this;
				int result;
				try
				{
					try
					{
						if (num > 2)
						{
							this.<ctx>5__2 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<List<tasks>> awaiter;
							TaskAwaiter<int> awaiter2;
							switch (num)
							{
							case 0:
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<List<tasks>>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								break;
							}
							case 1:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<int>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
								goto IL_36C;
							}
							case 2:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<int>);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
								goto IL_573;
							}
							default:
								this.<>8__1 = new TaskService.<>c__DisplayClass22_0();
								if (!OfflineData.Instance.Employee.Can(58, 0))
								{
									goto IL_374;
								}
								awaiter = (from t in this.<ctx>5__2.tasks
								where t.state == 1 && (t.type == 10 || t.type == 11) && t.task_employees.All((task_employees e) => e.employee != OfflineData.Instance.Employee.Id)
								select t).Take(10).ToListAsync<tasks>().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num5 = 0;
									num = 0;
									this.<>1__state = num5;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<tasks>>, TaskService.<GetActiveTaskIds>d__22>(ref awaiter, ref this);
									return;
								}
								break;
							}
							List<tasks>.Enumerator enumerator = awaiter.GetResult().GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									tasks tasks = enumerator.Current;
									task_employees entity = new task_employees
									{
										task = tasks.idt,
										employee = Auth.User.id
									};
									this.<ctx>5__2.task_employees.Add(entity);
									if (OfflineData.Instance.Settings.InformTaskRequest)
									{
										AscNotification ascNotification = new AscNotification();
										ascNotification.SetEmployee(OfflineData.Instance.Employee.Id);
										ascNotification.TaskSiteRequest(tasks.idt, tasks.text, (TaskType)tasks.type);
										this.<ctx>5__2.notifications.Add(ascNotification.BackToNotification());
									}
								}
							}
							finally
							{
								if (num < 0)
								{
									((IDisposable)enumerator).Dispose();
								}
							}
							awaiter2 = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num6 = 1;
								num = 1;
								this.<>1__state = num6;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, TaskService.<GetActiveTaskIds>d__22>(ref awaiter2, ref this);
								return;
							}
							IL_36C:
							awaiter2.GetResult();
							IL_374:
							if (OfflineData.Instance.Settings.InformTaskCustom)
							{
								NotificationService.CreateCustomTaskNotifications(OfflineData.Instance.Employee.Id);
							}
							this.<>8__1.now = DateTime.UtcNow;
							awaiter2 = (from t in this.<ctx>5__2.tasks
							where t.task_employees.Any((task_employees e) => e.employee == OfflineData.Instance.Employee.Id) && t.state == 1 && this.<>8__1.now > t.start_datetime
							select t).CountAsync<tasks>().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num7 = 2;
								num = 2;
								this.<>1__state = num7;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, TaskService.<GetActiveTaskIds>d__22>(ref awaiter2, ref this);
								return;
							}
							IL_573:
							result = awaiter2.GetResult();
						}
						finally
						{
							if (num < 0 && this.<ctx>5__2 != null)
							{
								((IDisposable)this.<ctx>5__2).Dispose();
							}
						}
					}
					catch (Exception ex)
					{
						taskService._loggerService.Error(ex, ex.Message);
						result = -1;
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

			// Token: 0x06003BF5 RID: 15349 RVA: 0x000EE4F4 File Offset: 0x000EC6F4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002742 RID: 10050
			public int <>1__state;

			// Token: 0x04002743 RID: 10051
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x04002744 RID: 10052
			private TaskService.<>c__DisplayClass22_0 <>8__1;

			// Token: 0x04002745 RID: 10053
			public TaskService <>4__this;

			// Token: 0x04002746 RID: 10054
			private auseceEntities <ctx>5__2;

			// Token: 0x04002747 RID: 10055
			private TaskAwaiter<List<tasks>> <>u__1;

			// Token: 0x04002748 RID: 10056
			private TaskAwaiter<int> <>u__2;
		}
	}
}
