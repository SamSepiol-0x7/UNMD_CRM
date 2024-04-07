using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Services.Abstract;

namespace ASC.Services.Concrete
{
	// Token: 0x020007BC RID: 1980
	public class UserActivityService : IUserActivityService
	{
		// Token: 0x06003C1F RID: 15391 RVA: 0x000EF69C File Offset: 0x000ED89C
		public UserActivityService(ILoggerService<UserActivityService> loggerService)
		{
			this._loggerService = loggerService;
			this._activity = new List<IActivity>();
			this._localization = new Localization("UTC");
		}

		// Token: 0x06003C20 RID: 15392 RVA: 0x000EF6D4 File Offset: 0x000ED8D4
		public void UserLogin(int userId)
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					this._userLastLogin = Localization.GetServerUtcTime(auseceEntities);
					users users = auseceEntities.users.Find(new object[]
					{
						userId
					});
					if (users != null)
					{
						users.last_login = new DateTime?(this._userLastLogin);
						this._loggerService.Info("User " + users.username + " login, ASC " + AuthModel.GetVersion());
					}
					users_activity entity = this.CreateUsersActivityRecord(userId, Lang.t("UserLogin"), Localization.GetServerUtcTime(auseceEntities), auseceEntities);
					auseceEntities.users_activity.Add(entity);
					auseceEntities.SaveChanges();
				}
			}
			catch (DbEntityValidationException ex)
			{
				foreach (DbEntityValidationResult dbEntityValidationResult in ex.EntityValidationErrors)
				{
					foreach (DbValidationError dbValidationError in dbEntityValidationResult.ValidationErrors)
					{
						this._loggerService.Error(ex, "Property: " + dbValidationError.PropertyName + " ValidationError: " + dbValidationError.ErrorMessage);
					}
				}
			}
			catch (Exception ex2)
			{
				this._loggerService.Error(ex2, ex2.Message);
			}
		}

		// Token: 0x06003C21 RID: 15393 RVA: 0x000EF868 File Offset: 0x000EDA68
		private users_activity CreateUsersActivityRecord(int userId, string notes, DateTime date, auseceEntities ctx)
		{
			return new users_activity
			{
				user_id = userId,
				datetime_ = date,
				address = Core.GetAddress(ctx),
				notes = notes,
				app_version = AuthModel.GetVersion(),
				machine_name = Environment.MachineName
			};
		}

		// Token: 0x06003C22 RID: 15394 RVA: 0x000EF8B4 File Offset: 0x000EDAB4
		public void SyncActivity()
		{
			UserActivityService.<SyncActivity>d__7 <SyncActivity>d__;
			<SyncActivity>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SyncActivity>d__.<>4__this = this;
			<SyncActivity>d__.<>1__state = -1;
			<SyncActivity>d__.<>t__builder.Start<UserActivityService.<SyncActivity>d__7>(ref <SyncActivity>d__);
		}

		// Token: 0x06003C23 RID: 15395 RVA: 0x000EF8EC File Offset: 0x000EDAEC
		public void AddActivity(string notes)
		{
			Activity item = new Activity
			{
				DateTime = this._localization.Now,
				Notes = notes
			};
			this._activity.Add(item);
		}

		// Token: 0x06003C24 RID: 15396 RVA: 0x000EF924 File Offset: 0x000EDB24
		public Task<bool> SecondSessionOpened()
		{
			UserActivityService.<SecondSessionOpened>d__9 <SecondSessionOpened>d__;
			<SecondSessionOpened>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<SecondSessionOpened>d__.<>4__this = this;
			<SecondSessionOpened>d__.<>1__state = -1;
			<SecondSessionOpened>d__.<>t__builder.Start<UserActivityService.<SecondSessionOpened>d__9>(ref <SecondSessionOpened>d__);
			return <SecondSessionOpened>d__.<>t__builder.Task;
		}

		// Token: 0x0400277E RID: 10110
		private readonly List<IActivity> _activity;

		// Token: 0x0400277F RID: 10111
		private readonly Localization _localization;

		// Token: 0x04002780 RID: 10112
		private readonly ILoggerService<UserActivityService> _loggerService;

		// Token: 0x04002781 RID: 10113
		private DateTime _userLastLogin;

		// Token: 0x020007BD RID: 1981
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SyncActivity>d__7 : IAsyncStateMachine
		{
			// Token: 0x06003C25 RID: 15397 RVA: 0x000EF968 File Offset: 0x000EDB68
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				UserActivityService userActivityService = this.<>4__this;
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
								this.<ctx>5__2.Configuration.ValidateOnSaveEnabled = false;
								users users = new users
								{
									id = Auth.User.id
								};
								this.<ctx>5__2.users.Attach(users);
								users.last_activity = new DateTime?(Localization.GetServerUtcTime(this.<ctx>5__2));
								if (userActivityService._activity.Any<IActivity>())
								{
									List<IActivity>.Enumerator enumerator = userActivityService._activity.GetEnumerator();
									try
									{
										while (enumerator.MoveNext())
										{
											IActivity activity = enumerator.Current;
											users_activity entity = userActivityService.CreateUsersActivityRecord(OfflineData.Instance.Employee.Id, activity.Notes, activity.DateTime, this.<ctx>5__2);
											this.<ctx>5__2.users_activity.Add(entity);
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
								awaiter = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, UserActivityService.<SyncActivity>d__7>(ref awaiter, ref this);
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
							userActivityService._activity.Clear();
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
					catch (DbEntityValidationException ex)
					{
						IEnumerator<DbEntityValidationResult> enumerator2 = ex.EntityValidationErrors.GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								DbEntityValidationResult dbEntityValidationResult = enumerator2.Current;
								IEnumerator<DbValidationError> enumerator3 = dbEntityValidationResult.ValidationErrors.GetEnumerator();
								try
								{
									while (enumerator3.MoveNext())
									{
										DbValidationError dbValidationError = enumerator3.Current;
										userActivityService._loggerService.Error(ex, "Property: " + dbValidationError.PropertyName + " ValidationError: " + dbValidationError.ErrorMessage);
									}
								}
								finally
								{
									if (num < 0 && enumerator3 != null)
									{
										enumerator3.Dispose();
									}
								}
							}
						}
						finally
						{
							if (num < 0 && enumerator2 != null)
							{
								enumerator2.Dispose();
							}
						}
					}
					catch (Exception ex2)
					{
						userActivityService._loggerService.Debug(ex2, ex2.Message);
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

			// Token: 0x06003C26 RID: 15398 RVA: 0x000EFC84 File Offset: 0x000EDE84
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002782 RID: 10114
			public int <>1__state;

			// Token: 0x04002783 RID: 10115
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04002784 RID: 10116
			public UserActivityService <>4__this;

			// Token: 0x04002785 RID: 10117
			private auseceEntities <ctx>5__2;

			// Token: 0x04002786 RID: 10118
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x020007BE RID: 1982
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003C27 RID: 15399 RVA: 0x000EFCA0 File Offset: 0x000EDEA0
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003C28 RID: 15400 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x04002787 RID: 10119
			public static readonly UserActivityService.<>c <>9 = new UserActivityService.<>c();
		}

		// Token: 0x020007BF RID: 1983
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SecondSessionOpened>d__9 : IAsyncStateMachine
		{
			// Token: 0x06003C29 RID: 15401 RVA: 0x000EFCB8 File Offset: 0x000EDEB8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				UserActivityService userActivityService = this.<>4__this;
				bool result;
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
							TaskAwaiter<string> awaiter;
							if (num != 0)
							{
								awaiter = (from i in (from i in this.<ctx>5__2.users_activity
								where i.user_id == OfflineData.Instance.Employee.Id
								where i.notes == "Выполнен вход в систему"
								orderby i.id descending
								select i).Take(1).DefaultIfEmpty<users_activity>()
								select i.machine_name).FirstOrDefaultAsync<string>().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, UserActivityService.<SecondSessionOpened>d__9>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<string>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							result = (awaiter.GetResult() != Environment.MachineName);
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
						userActivityService._loggerService.Error(ex, ex.Message);
						result = false;
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

			// Token: 0x06003C2A RID: 15402 RVA: 0x000EFF74 File Offset: 0x000EE174
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002788 RID: 10120
			public int <>1__state;

			// Token: 0x04002789 RID: 10121
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x0400278A RID: 10122
			public UserActivityService <>4__this;

			// Token: 0x0400278B RID: 10123
			private auseceEntities <ctx>5__2;

			// Token: 0x0400278C RID: 10124
			private TaskAwaiter<string> <>u__1;
		}
	}
}
