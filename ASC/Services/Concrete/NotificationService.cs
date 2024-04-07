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
using ASC.Objects;
using ASC.Objects.Converters;
using ASC.Services.Abstract;
using NLog;

namespace ASC.Services.Concrete
{
	// Token: 0x02000739 RID: 1849
	public class NotificationService : INotificationService
	{
		// Token: 0x06003AC9 RID: 15049 RVA: 0x000E1114 File Offset: 0x000DF314
		public NotificationService(IContextFactory contextFactory)
		{
			this._contextFactory = contextFactory;
		}

		// Token: 0x06003ACA RID: 15050 RVA: 0x000E1130 File Offset: 0x000DF330
		public Task<int> CountEmployeeNotificationsAsync(int employeeId)
		{
			NotificationService.<CountEmployeeNotificationsAsync>d__3 <CountEmployeeNotificationsAsync>d__;
			<CountEmployeeNotificationsAsync>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<CountEmployeeNotificationsAsync>d__.<>4__this = this;
			<CountEmployeeNotificationsAsync>d__.employeeId = employeeId;
			<CountEmployeeNotificationsAsync>d__.<>1__state = -1;
			<CountEmployeeNotificationsAsync>d__.<>t__builder.Start<NotificationService.<CountEmployeeNotificationsAsync>d__3>(ref <CountEmployeeNotificationsAsync>d__);
			return <CountEmployeeNotificationsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06003ACB RID: 15051 RVA: 0x000E117C File Offset: 0x000DF37C
		public Task<IEnumerable<IAscNotification>> GetEmployeeNotifications(int employeeId, int limit)
		{
			NotificationService.<GetEmployeeNotifications>d__4 <GetEmployeeNotifications>d__;
			<GetEmployeeNotifications>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<IAscNotification>>.Create();
			<GetEmployeeNotifications>d__.employeeId = employeeId;
			<GetEmployeeNotifications>d__.limit = limit;
			<GetEmployeeNotifications>d__.<>1__state = -1;
			<GetEmployeeNotifications>d__.<>t__builder.Start<NotificationService.<GetEmployeeNotifications>d__4>(ref <GetEmployeeNotifications>d__);
			return <GetEmployeeNotifications>d__.<>t__builder.Task;
		}

		// Token: 0x06003ACC RID: 15052 RVA: 0x000E11C8 File Offset: 0x000DF3C8
		public static void CreateNotification(workshop r, string comment)
		{
			NotificationService.<CreateNotification>d__5 <CreateNotification>d__;
			<CreateNotification>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<CreateNotification>d__.r = r;
			<CreateNotification>d__.comment = comment;
			<CreateNotification>d__.<>1__state = -1;
			<CreateNotification>d__.<>t__builder.Start<NotificationService.<CreateNotification>d__5>(ref <CreateNotification>d__);
		}

		// Token: 0x06003ACD RID: 15053 RVA: 0x000E1208 File Offset: 0x000DF408
		public static void CreateNotification(IAscNotification notification)
		{
			NotificationService.<CreateNotification>d__6 <CreateNotification>d__;
			<CreateNotification>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<CreateNotification>d__.notification = notification;
			<CreateNotification>d__.<>1__state = -1;
			<CreateNotification>d__.<>t__builder.Start<NotificationService.<CreateNotification>d__6>(ref <CreateNotification>d__);
		}

		// Token: 0x06003ACE RID: 15054 RVA: 0x000E1240 File Offset: 0x000DF440
		private static IEnumerable<int> GetEmployees(workshop r)
		{
			List<int> list = new List<int>();
			if (r.current_manager != OfflineData.Instance.Employee.Id)
			{
				list.Add(r.current_manager);
			}
			if (r.master != null)
			{
				int? master = r.master;
				int id = OfflineData.Instance.Employee.Id;
				if (!(master.GetValueOrDefault() == id & master != null))
				{
					list.Add(r.master.Value);
				}
			}
			return list;
		}

		// Token: 0x06003ACF RID: 15055 RVA: 0x000E12C8 File Offset: 0x000DF4C8
		public static void CreateStatusNotification(int repairId, string deviceName, string statusName, int employeeId)
		{
			NotificationService.<CreateStatusNotification>d__8 <CreateStatusNotification>d__;
			<CreateStatusNotification>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<CreateStatusNotification>d__.repairId = repairId;
			<CreateStatusNotification>d__.deviceName = deviceName;
			<CreateStatusNotification>d__.statusName = statusName;
			<CreateStatusNotification>d__.employeeId = employeeId;
			<CreateStatusNotification>d__.<>1__state = -1;
			<CreateStatusNotification>d__.<>t__builder.Start<NotificationService.<CreateStatusNotification>d__8>(ref <CreateStatusNotification>d__);
		}

		// Token: 0x06003AD0 RID: 15056 RVA: 0x000E1318 File Offset: 0x000DF518
		public static void CreateTermsNotification(List<KeyValuePair<int, string>> repairs)
		{
			NotificationService.<CreateTermsNotification>d__9 <CreateTermsNotification>d__;
			<CreateTermsNotification>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<CreateTermsNotification>d__.repairs = repairs;
			<CreateTermsNotification>d__.<>1__state = -1;
			<CreateTermsNotification>d__.<>t__builder.Start<NotificationService.<CreateTermsNotification>d__9>(ref <CreateTermsNotification>d__);
		}

		// Token: 0x06003AD1 RID: 15057 RVA: 0x000E1350 File Offset: 0x000DF550
		public static void CreateSmsNotifications(int employeeId)
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					List<int> exist = (from n in auseceEntities.notifications
					where n.type == 3 && n.sms_id != null && n.employee == employeeId
					select n.sms_id.Value).ToList<int>();
					List<in_sms> list = (from s in auseceEntities.in_sms
					where !exist.Contains(s.id)
					select s).ToList<in_sms>();
					if (list.Any<in_sms>())
					{
						foreach (in_sms in_sms in list)
						{
							AscNotification ascNotification = new AscNotification();
							ascNotification.SetEmployee(employeeId);
							ascNotification.SmsNotification(in_sms.id, in_sms.callerid, in_sms.msg, in_sms.date);
							auseceEntities.notifications.Add(ascNotification.BackToNotification());
						}
						auseceEntities.SaveChanges();
					}
				}
			}
			catch (Exception ex)
			{
				NotificationService.Log.Error(ex, ex.Message);
			}
		}

		// Token: 0x06003AD2 RID: 15058 RVA: 0x000E164C File Offset: 0x000DF84C
		public static void CreateCustomTaskNotifications(int employeeId)
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					List<int> existTaskNotifications = (from n in auseceEntities.notifications
					where n.type == 5 && n.task_id != null && n.employee == employeeId
					select n.task_id.Value).ToList<int>();
					DateTime now = DateTime.UtcNow;
					var list = (from t in auseceEntities.tasks
					where t.task_employees.Any((task_employees e) => e.employee == employeeId) && !existTaskNotifications.Contains(t.idt) && t.state == 1 && t.type == 4 && t.start_datetime < now
					select new
					{
						t.idt,
						t.text,
						t.title
					}).ToList();
					if (list.Any())
					{
						foreach (var <>f__AnonymousType in list)
						{
							AscNotification ascNotification = new AscNotification();
							ascNotification.SetEmployee(employeeId);
							ascNotification.TaskCustom(<>f__AnonymousType.idt, <>f__AnonymousType.title, <>f__AnonymousType.text);
							auseceEntities.notifications.Add(ascNotification.BackToNotification());
						}
						auseceEntities.SaveChanges();
					}
				}
			}
			catch (Exception ex)
			{
				NotificationService.Log.Error(ex, ex.Message);
			}
		}

		// Token: 0x06003AD3 RID: 15059 RVA: 0x000E1BA8 File Offset: 0x000DFDA8
		public static void CreateIntRequestNotification(List<int> employees, int requestId, string reqestTitle)
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					foreach (int employee in employees)
					{
						AscNotification ascNotification = new AscNotification();
						ascNotification.SetEmployee(employee);
						ascNotification.IntReserveRequest(requestId, reqestTitle);
						auseceEntities.notifications.Add(ascNotification.BackToNotification());
					}
					auseceEntities.SaveChanges();
				}
			}
			catch (Exception ex)
			{
				NotificationService.Log.Error(ex, ex.Message);
			}
		}

		// Token: 0x06003AD4 RID: 15060 RVA: 0x000E1C64 File Offset: 0x000DFE64
		public static void CreateBuyRequestNotification(List<int> employees, int requestId, string reqestTitle)
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					foreach (int employee in employees)
					{
						AscNotification ascNotification = new AscNotification();
						ascNotification.SetEmployee(employee);
						ascNotification.BuyRequest(requestId, reqestTitle);
						auseceEntities.notifications.Add(ascNotification.BackToNotification());
					}
					auseceEntities.SaveChanges();
				}
			}
			catch (Exception ex)
			{
				NotificationService.Log.Error(ex, ex.Message);
			}
		}

		// Token: 0x06003AD5 RID: 15061 RVA: 0x000E1D20 File Offset: 0x000DFF20
		public Task MarkAllAsRead(int employeeId)
		{
			NotificationService.<MarkAllAsRead>d__14 <MarkAllAsRead>d__;
			<MarkAllAsRead>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<MarkAllAsRead>d__.<>4__this = this;
			<MarkAllAsRead>d__.employeeId = employeeId;
			<MarkAllAsRead>d__.<>1__state = -1;
			<MarkAllAsRead>d__.<>t__builder.Start<NotificationService.<MarkAllAsRead>d__14>(ref <MarkAllAsRead>d__);
			return <MarkAllAsRead>d__.<>t__builder.Task;
		}

		// Token: 0x06003AD6 RID: 15062 RVA: 0x000E1D6C File Offset: 0x000DFF6C
		public Task MarkAsRead(int notificationId)
		{
			NotificationService.<MarkAsRead>d__15 <MarkAsRead>d__;
			<MarkAsRead>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<MarkAsRead>d__.<>4__this = this;
			<MarkAsRead>d__.notificationId = notificationId;
			<MarkAsRead>d__.<>1__state = -1;
			<MarkAsRead>d__.<>t__builder.Start<NotificationService.<MarkAsRead>d__15>(ref <MarkAsRead>d__);
			return <MarkAsRead>d__.<>t__builder.Task;
		}

		// Token: 0x06003AD7 RID: 15063 RVA: 0x000E1DB8 File Offset: 0x000DFFB8
		// Note: this type is marked as 'beforefieldinit'.
		static NotificationService()
		{
		}

		// Token: 0x0400257F RID: 9599
		public static readonly ILogger Log = LogManager.GetCurrentClassLogger();

		// Token: 0x04002580 RID: 9600
		private readonly IContextFactory _contextFactory;

		// Token: 0x0200073A RID: 1850
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06003AD8 RID: 15064 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x04002581 RID: 9601
			public int employeeId;
		}

		// Token: 0x0200073B RID: 1851
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CountEmployeeNotificationsAsync>d__3 : IAsyncStateMachine
		{
			// Token: 0x06003AD9 RID: 15065 RVA: 0x000E1DD0 File Offset: 0x000DFFD0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NotificationService notificationService = this.<>4__this;
				int result;
				try
				{
					NotificationService.<>c__DisplayClass3_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new NotificationService.<>c__DisplayClass3_0();
						CS$<>8__locals1.employeeId = this.employeeId;
						this.<ctx>5__2 = notificationService._contextFactory.Create();
					}
					try
					{
						ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = this.<ctx>5__2.notifications.CountAsync((notifications n) => !n.status && n.employee == CS$<>8__locals1.employeeId).ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter, NotificationService.<CountEmployeeNotificationsAsync>d__3>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter);
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

			// Token: 0x06003ADA RID: 15066 RVA: 0x000E1F84 File Offset: 0x000E0184
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002582 RID: 9602
			public int <>1__state;

			// Token: 0x04002583 RID: 9603
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x04002584 RID: 9604
			public int employeeId;

			// Token: 0x04002585 RID: 9605
			public NotificationService <>4__this;

			// Token: 0x04002586 RID: 9606
			private auseceEntities <ctx>5__2;

			// Token: 0x04002587 RID: 9607
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x0200073C RID: 1852
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x06003ADB RID: 15067 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x04002588 RID: 9608
			public int employeeId;
		}

		// Token: 0x0200073D RID: 1853
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003ADC RID: 15068 RVA: 0x000E1FA0 File Offset: 0x000E01A0
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003ADD RID: 15069 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06003ADE RID: 15070 RVA: 0x000E1FB8 File Offset: 0x000E01B8
			internal IAscNotification <GetEmployeeNotifications>b__4_0(notifications n)
			{
				return n.ToAscNotification();
			}

			// Token: 0x04002589 RID: 9609
			public static readonly NotificationService.<>c <>9 = new NotificationService.<>c();

			// Token: 0x0400258A RID: 9610
			public static Func<notifications, IAscNotification> <>9__4_0;
		}

		// Token: 0x0200073E RID: 1854
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetEmployeeNotifications>d__4 : IAsyncStateMachine
		{
			// Token: 0x06003ADF RID: 15071 RVA: 0x000E1FCC File Offset: 0x000E01CC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IEnumerable<IAscNotification> result;
				try
				{
					NotificationService.<>c__DisplayClass4_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new NotificationService.<>c__DisplayClass4_0();
						CS$<>8__locals1.employeeId = this.employeeId;
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						ConfiguredTaskAwaitable<List<notifications>>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = (from n in this.<ctx>5__2.notifications.AsNoTracking()
							where !n.status && n.employee == CS$<>8__locals1.employeeId
							select n into i
							orderby i.created descending
							select i).Take(this.limit).ToListAsync<notifications>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<List<notifications>>.ConfiguredTaskAwaiter, NotificationService.<GetEmployeeNotifications>d__4>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<List<notifications>>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult().Select(new Func<notifications, IAscNotification>(NotificationService.<>c.<>9.<GetEmployeeNotifications>b__4_0)).ToList<IAscNotification>();
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

			// Token: 0x06003AE0 RID: 15072 RVA: 0x000E21F4 File Offset: 0x000E03F4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400258B RID: 9611
			public int <>1__state;

			// Token: 0x0400258C RID: 9612
			public AsyncTaskMethodBuilder<IEnumerable<IAscNotification>> <>t__builder;

			// Token: 0x0400258D RID: 9613
			public int employeeId;

			// Token: 0x0400258E RID: 9614
			public int limit;

			// Token: 0x0400258F RID: 9615
			private auseceEntities <ctx>5__2;

			// Token: 0x04002590 RID: 9616
			private ConfiguredTaskAwaitable<List<notifications>>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x0200073F RID: 1855
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateNotification>d__5 : IAsyncStateMachine
		{
			// Token: 0x06003AE1 RID: 15073 RVA: 0x000E2210 File Offset: 0x000E0410
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					List<IAscNotification> list;
					if (num != 0)
					{
						list = new List<IAscNotification>();
						IEnumerator<int> enumerator = NotificationService.GetEmployees(this.r).GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								int employee = enumerator.Current;
								AscNotification ascNotification = new AscNotification();
								ascNotification.CommentNotification(this.r.id, this.r.Title, this.comment);
								ascNotification.SetEmployee(employee);
								list.Add(ascNotification);
							}
						}
						finally
						{
							if (num < 0 && enumerator != null)
							{
								enumerator.Dispose();
							}
						}
						if (!list.Any<IAscNotification>())
						{
							goto IL_1A6;
						}
					}
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
								List<IAscNotification>.Enumerator enumerator2 = list.GetEnumerator();
								try
								{
									while (enumerator2.MoveNext())
									{
										IAscNotification n = enumerator2.Current;
										notifications entity = n.BackToNotification();
										this.<ctx>5__2.notifications.Add(entity);
									}
								}
								finally
								{
									if (num < 0)
									{
										((IDisposable)enumerator2).Dispose();
									}
								}
								awaiter = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, NotificationService.<CreateNotification>d__5>(ref awaiter, ref this);
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
					catch (Exception ex)
					{
						NotificationService.Log.Error(ex, ex.Message);
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_1A6:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003AE2 RID: 15074 RVA: 0x000E2454 File Offset: 0x000E0654
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002591 RID: 9617
			public int <>1__state;

			// Token: 0x04002592 RID: 9618
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04002593 RID: 9619
			public workshop r;

			// Token: 0x04002594 RID: 9620
			public string comment;

			// Token: 0x04002595 RID: 9621
			private auseceEntities <ctx>5__2;

			// Token: 0x04002596 RID: 9622
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x02000740 RID: 1856
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateNotification>d__6 : IAsyncStateMachine
		{
			// Token: 0x06003AE3 RID: 15075 RVA: 0x000E2470 File Offset: 0x000E0670
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
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
							TaskAwaiter<int> awaiter;
							if (num != 0)
							{
								this.<ctx>5__2.notifications.Add(this.notification.BackToNotification());
								awaiter = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, NotificationService.<CreateNotification>d__6>(ref awaiter, ref this);
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
					catch (Exception ex)
					{
						NotificationService.Log.Error(ex, ex.Message);
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

			// Token: 0x06003AE4 RID: 15076 RVA: 0x000E25A0 File Offset: 0x000E07A0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002597 RID: 9623
			public int <>1__state;

			// Token: 0x04002598 RID: 9624
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04002599 RID: 9625
			public IAscNotification notification;

			// Token: 0x0400259A RID: 9626
			private auseceEntities <ctx>5__2;

			// Token: 0x0400259B RID: 9627
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x02000741 RID: 1857
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateStatusNotification>d__8 : IAsyncStateMachine
		{
			// Token: 0x06003AE5 RID: 15077 RVA: 0x000E25BC File Offset: 0x000E07BC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					AscNotification ascNotification;
					if (num != 0)
					{
						ascNotification = new AscNotification();
						ascNotification.RepairStatusNotification(this.repairId, this.deviceName, this.statusName);
						ascNotification.SetEmployee(this.employeeId);
					}
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
								notifications entity = ascNotification.BackToNotification();
								this.<ctx>5__2.notifications.Add(entity);
								awaiter = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, NotificationService.<CreateStatusNotification>d__8>(ref awaiter, ref this);
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
					catch (Exception ex)
					{
						NotificationService.Log.Error(ex, ex.Message);
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

			// Token: 0x06003AE6 RID: 15078 RVA: 0x000E271C File Offset: 0x000E091C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400259C RID: 9628
			public int <>1__state;

			// Token: 0x0400259D RID: 9629
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400259E RID: 9630
			public int repairId;

			// Token: 0x0400259F RID: 9631
			public string deviceName;

			// Token: 0x040025A0 RID: 9632
			public string statusName;

			// Token: 0x040025A1 RID: 9633
			public int employeeId;

			// Token: 0x040025A2 RID: 9634
			private auseceEntities <ctx>5__2;

			// Token: 0x040025A3 RID: 9635
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x02000742 RID: 1858
		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x06003AE7 RID: 15079 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x040025A4 RID: 9636
			public KeyValuePair<int, string> repair;
		}

		// Token: 0x02000743 RID: 1859
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateTermsNotification>d__9 : IAsyncStateMachine
		{
			// Token: 0x06003AE8 RID: 15080 RVA: 0x000E2738 File Offset: 0x000E0938
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
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
								this.<>7__wrap2 = this.repairs.GetEnumerator();
							}
							try
							{
								TaskAwaiter<bool> awaiter;
								if (num == 0)
								{
									awaiter = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter<bool>);
									int num2 = -1;
									num = -1;
									this.<>1__state = num2;
									goto IL_1E4;
								}
								IL_51:
								if (!this.<>7__wrap2.MoveNext())
								{
									goto IL_22D;
								}
								this.<>8__1 = new NotificationService.<>c__DisplayClass9_0();
								this.<>8__1.repair = this.<>7__wrap2.Current;
								awaiter = this.<ctx>5__2.notifications.AnyAsync((notifications n) => n.repair_id == (int?)this.<>8__1.repair.Key && !n.status && n.type == 4).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num3 = 0;
									num = 0;
									this.<>1__state = num3;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, NotificationService.<CreateTermsNotification>d__9>(ref awaiter, ref this);
									return;
								}
								IL_1E4:
								if (!awaiter.GetResult())
								{
									AscNotification ascNotification = new AscNotification();
									ascNotification.RepairTermsNotification(this.<>8__1.repair.Key, this.<>8__1.repair.Value);
									ascNotification.SetEmployee(OfflineData.Instance.Employee.Id);
									this.<ctx>5__2.notifications.Add(ascNotification.BackToNotification());
									this.<>8__1 = null;
									goto IL_51;
								}
								goto IL_51;
							}
							finally
							{
								if (num < 0)
								{
									((IDisposable)this.<>7__wrap2).Dispose();
								}
							}
							IL_22D:
							this.<>7__wrap2 = default(List<KeyValuePair<int, string>>.Enumerator);
							this.<ctx>5__2.SaveChanges();
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
					catch (Exception ex)
					{
						NotificationService.Log.Error(ex, ex.Message);
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

			// Token: 0x06003AE9 RID: 15081 RVA: 0x000E2A58 File Offset: 0x000E0C58
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040025A5 RID: 9637
			public int <>1__state;

			// Token: 0x040025A6 RID: 9638
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040025A7 RID: 9639
			public List<KeyValuePair<int, string>> repairs;

			// Token: 0x040025A8 RID: 9640
			private NotificationService.<>c__DisplayClass9_0 <>8__1;

			// Token: 0x040025A9 RID: 9641
			private auseceEntities <ctx>5__2;

			// Token: 0x040025AA RID: 9642
			private List<KeyValuePair<int, string>>.Enumerator <>7__wrap2;

			// Token: 0x040025AB RID: 9643
			private TaskAwaiter<bool> <>u__1;
		}

		// Token: 0x02000744 RID: 1860
		[CompilerGenerated]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x06003AEA RID: 15082 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x040025AC RID: 9644
			public int employeeId;
		}

		// Token: 0x02000745 RID: 1861
		[CompilerGenerated]
		private sealed class <>c__DisplayClass10_1
		{
			// Token: 0x06003AEB RID: 15083 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass10_1()
			{
			}

			// Token: 0x040025AD RID: 9645
			public List<int> exist;
		}

		// Token: 0x02000746 RID: 1862
		[CompilerGenerated]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x06003AEC RID: 15084 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass11_0()
			{
			}

			// Token: 0x040025AE RID: 9646
			public int employeeId;
		}

		// Token: 0x02000747 RID: 1863
		[CompilerGenerated]
		private sealed class <>c__DisplayClass11_1
		{
			// Token: 0x06003AED RID: 15085 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass11_1()
			{
			}

			// Token: 0x040025AF RID: 9647
			public List<int> existTaskNotifications;

			// Token: 0x040025B0 RID: 9648
			public DateTime now;

			// Token: 0x040025B1 RID: 9649
			public NotificationService.<>c__DisplayClass11_0 CS$<>8__locals1;
		}

		// Token: 0x02000748 RID: 1864
		[CompilerGenerated]
		private sealed class <>c__DisplayClass14_0
		{
			// Token: 0x06003AEE RID: 15086 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass14_0()
			{
			}

			// Token: 0x040025B2 RID: 9650
			public int employeeId;
		}

		// Token: 0x02000749 RID: 1865
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <MarkAllAsRead>d__14 : IAsyncStateMachine
		{
			// Token: 0x06003AEF RID: 15087 RVA: 0x000E2A74 File Offset: 0x000E0C74
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NotificationService notificationService = this.<>4__this;
				try
				{
					NotificationService.<>c__DisplayClass14_0 CS$<>8__locals1;
					if (num > 1)
					{
						CS$<>8__locals1 = new NotificationService.<>c__DisplayClass14_0();
						CS$<>8__locals1.employeeId = this.employeeId;
						this.<ctx>5__2 = notificationService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<int> awaiter;
						TaskAwaiter<List<notifications>> awaiter2;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<int>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								goto IL_1D0;
							}
							this.<ctx>5__2.Configuration.ProxyCreationEnabled = false;
							awaiter2 = (from n in this.<ctx>5__2.notifications
							where n.employee == CS$<>8__locals1.employeeId && !n.status
							select n).ToListAsync<notifications>().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num3 = 0;
								num = 0;
								this.<>1__state = num3;
								this.<>u__1 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<notifications>>, NotificationService.<MarkAllAsRead>d__14>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<notifications>>);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
						}
						List<notifications>.Enumerator enumerator = awaiter2.GetResult().GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								notifications notifications = enumerator.Current;
								notifications.status = true;
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
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, NotificationService.<MarkAllAsRead>d__14>(ref awaiter, ref this);
							return;
						}
						IL_1D0:
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

			// Token: 0x06003AF0 RID: 15088 RVA: 0x000E2CF4 File Offset: 0x000E0EF4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040025B3 RID: 9651
			public int <>1__state;

			// Token: 0x040025B4 RID: 9652
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040025B5 RID: 9653
			public int employeeId;

			// Token: 0x040025B6 RID: 9654
			public NotificationService <>4__this;

			// Token: 0x040025B7 RID: 9655
			private auseceEntities <ctx>5__2;

			// Token: 0x040025B8 RID: 9656
			private TaskAwaiter<List<notifications>> <>u__1;

			// Token: 0x040025B9 RID: 9657
			private TaskAwaiter<int> <>u__2;
		}

		// Token: 0x0200074A RID: 1866
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <MarkAsRead>d__15 : IAsyncStateMachine
		{
			// Token: 0x06003AF1 RID: 15089 RVA: 0x000E2D10 File Offset: 0x000E0F10
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NotificationService notificationService = this.<>4__this;
				try
				{
					if (num > 1)
					{
						this.<ctx>5__2 = notificationService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<int> awaiter;
						TaskAwaiter<notifications> awaiter2;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<int>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								goto IL_E5;
							}
							awaiter2 = this.<ctx>5__2.notifications.FindAsync(new object[]
							{
								this.notificationId
							}).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num3 = 0;
								num = 0;
								this.<>1__state = num3;
								this.<>u__1 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<notifications>, NotificationService.<MarkAsRead>d__15>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<notifications>);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
						}
						awaiter2.GetResult().status = true;
						awaiter = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num5 = 1;
							num = 1;
							this.<>1__state = num5;
							this.<>u__2 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, NotificationService.<MarkAsRead>d__15>(ref awaiter, ref this);
							return;
						}
						IL_E5:
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

			// Token: 0x06003AF2 RID: 15090 RVA: 0x000E2EB0 File Offset: 0x000E10B0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040025BA RID: 9658
			public int <>1__state;

			// Token: 0x040025BB RID: 9659
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040025BC RID: 9660
			public NotificationService <>4__this;

			// Token: 0x040025BD RID: 9661
			public int notificationId;

			// Token: 0x040025BE RID: 9662
			private auseceEntities <ctx>5__2;

			// Token: 0x040025BF RID: 9663
			private TaskAwaiter<notifications> <>u__1;

			// Token: 0x040025C0 RID: 9664
			private TaskAwaiter<int> <>u__2;
		}
	}
}
