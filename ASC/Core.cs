using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Common.Interfaces.SiteStore;
using ASC.Common.Interfaces.VoIP;
using ASC.Common.Objects;
using ASC.Common.SimpleClasses;
using ASC.Extensions.OpenCart;
using ASC.Extensions.OpenCart.Models;
using ASC.ItemsSale;
using ASC.Models;
using ASC.Objects;
using ASC.Options;
using ASC.Properties;
using ASC.Services.Abstract;
using ASC.Services.Concrete;
using Autofac;
using DevExpress.Mvvm;
using Newtonsoft.Json;
using NLog;

namespace ASC
{
	// Token: 0x0200009D RID: 157
	public class Core : GClass0
	{
		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x0600127C RID: 4732 RVA: 0x00022ED8 File Offset: 0x000210D8
		public static Core Instance
		{
			get
			{
				return Core._core;
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600127D RID: 4733 RVA: 0x00022EEC File Offset: 0x000210EC
		// (remove) Token: 0x0600127E RID: 4734 RVA: 0x00022F24 File Offset: 0x00021124
		public event EventHandler Validated
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.Validated;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.Validated, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.Validated;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.Validated, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x00022F5C File Offset: 0x0002115C
		static Core()
		{
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x00022F80 File Offset: 0x00021180
		public bool IsValid()
		{
			return this._valid;
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x00022F94 File Offset: 0x00021194
		public Core()
		{
			this._userActivityService = Bootstrapper.Container.Resolve<IUserActivityService>();
			this._taskService = Bootstrapper.Container.Resolve<ITaskService>();
			if (OfflineData.Instance.Settings.Voip != null && OfflineData.Instance.Employee.Can(24, 0))
			{
				this.InitVoIP();
			}
			if (Auth.Config.online_store != null && OfflineData.Instance.Employee.Can(58, 0))
			{
				this.InitOnlineStore();
			}
			this._userActivityTimer = new Timer(new TimerCallback(this.UserActivityTick), null, 15000, 30000);
			this._serviceWorksTimer = new Timer(new TimerCallback(this.ServiceWorks), null, 10000, 30000);
			if (Auth.Config.backup_enable && OfflineData.Instance.Employee.Can(66, 0))
			{
				this._backupTimer = new Timer(new TimerCallback(this.BackupTick), null, 60000, 60000);
			}
			this.RefreshValid();
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x000230DC File Offset: 0x000212DC
		private void InitOnlineStore()
		{
			if (this.OnlineStore != null)
			{
				IOnlineStore onlineStore = this.OnlineStore;
				onlineStore.OnNewOrder = (EventHandler<EventArgs>)Delegate.Remove(onlineStore.OnNewOrder, new EventHandler<EventArgs>(this.OnOnlineStoreOrder));
			}
			this.OnlineStore = Bootstrapper.Container.Resolve<IOnlineStore>();
			IOnlineStore onlineStore2 = this.OnlineStore;
			onlineStore2.OnNewOrder = (EventHandler<EventArgs>)Delegate.Combine(onlineStore2.OnNewOrder, new EventHandler<EventArgs>(this.OnOnlineStoreOrder));
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x00023150 File Offset: 0x00021350
		private void OnOnlineStoreOrder(object sender, EventArgs e)
		{
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x00023160 File Offset: 0x00021360
		public void InitVoIP()
		{
			if (this.VoIP != null)
			{
				IVoIP voIP = this.VoIP;
				voIP.OnAgentCalled = (EventHandler<AscCallArgs>)Delegate.Remove(voIP.OnAgentCalled, new EventHandler<AscCallArgs>(this.OnAgentCalled));
				IVoIP voIP2 = this.VoIP;
				voIP2.OnAnswer = (EventHandler<AscCallArgs>)Delegate.Remove(voIP2.OnAnswer, new EventHandler<AscCallArgs>(this.OnAnswer));
			}
			this.VoIP = Bootstrapper.Container.ResolveKeyed(OfflineData.Instance.Settings.Voip.ToString());
			IVoIP voIP3 = this.VoIP;
			voIP3.OnAgentCalled = (EventHandler<AscCallArgs>)Delegate.Combine(voIP3.OnAgentCalled, new EventHandler<AscCallArgs>(this.OnAgentCalled));
			IVoIP voIP4 = this.VoIP;
			voIP4.OnAnswer = (EventHandler<AscCallArgs>)Delegate.Combine(voIP4.OnAnswer, new EventHandler<AscCallArgs>(this.OnAnswer));
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x00023240 File Offset: 0x00021440
		private void OnAnswer(object sender, AscCallArgs e)
		{
			if (Auth.User.sip_user_id.ToString() != e.Destination)
			{
				Messenger.Default.Send(new Message(e.Destination, e.Caller, MessageType.CallAnswered));
			}
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x00023290 File Offset: 0x00021490
		private void OnAgentCalled(object sender, AscCallArgs e)
		{
			if (!string.IsNullOrEmpty(e.Caller) && Auth.User.sip_user_id.ToString() == e.Destination)
			{
				Messenger.Default.Send(new Message(e.Destination, e.Caller, MessageType.InCall));
			}
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x000232EC File Offset: 0x000214EC
		public bool CanCall()
		{
			return this.VoIP != null && OfflineData.Instance.Employee.Tel != null && this.IsValid();
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x00023324 File Offset: 0x00021524
		private void BackupTick(object state)
		{
			if (string.IsNullOrEmpty(Settings.Default.BackupPath))
			{
				return;
			}
			DateTime now = DateTime.Now;
			if (now.Hour == Auth.Config.backup_time.Hour && now.Minute == Auth.Config.backup_time.Minute)
			{
				new BackupModel().Backup(Auth.Config.backup_images);
			}
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x00023394 File Offset: 0x00021594
		public void StopUserActivitySync()
		{
			Timer userActivityTimer = this._userActivityTimer;
			if (userActivityTimer == null)
			{
				return;
			}
			userActivityTimer.Dispose();
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x000233B4 File Offset: 0x000215B4
		private void UserActivityTick(object state)
		{
			if (OfflineData.Instance.Employee.IsTrackActivity() && this._serverInfo.Connected)
			{
				this._userActivityService.SyncActivity();
				return;
			}
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x000233EC File Offset: 0x000215EC
		private void ServiceWorks(object state)
		{
			Core.<ServiceWorks>d__31 <ServiceWorks>d__;
			<ServiceWorks>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<ServiceWorks>d__.<>4__this = this;
			<ServiceWorks>d__.<>1__state = -1;
			<ServiceWorks>d__.<>t__builder.Start<Core.<ServiceWorks>d__31>(ref <ServiceWorks>d__);
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x00023424 File Offset: 0x00021624
		public void RefreshValid()
		{
			Core.<RefreshValid>d__32 <RefreshValid>d__;
			<RefreshValid>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<RefreshValid>d__.<>4__this = this;
			<RefreshValid>d__.<>1__state = -1;
			<RefreshValid>d__.<>t__builder.Start<Core.<RefreshValid>d__32>(ref <RefreshValid>d__);
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x0002345C File Offset: 0x0002165C
		private void RaiseValidated(EventArgs e)
		{
			EventHandler validated = this.Validated;
			if (validated != null)
			{
				goto IL_2E;
			}
			IL_0A:
			int num = -935172919;
			IL_0F:
			switch ((num ^ -455700530) % 4)
			{
			case 0:
				goto IL_0A;
			case 2:
				IL_2E:
				validated(this, e);
				num = -563660397;
				goto IL_0F;
			case 3:
				return;
			}
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x000234A8 File Offset: 0x000216A8
		public static string GetAddress(auseceEntities ctx)
		{
			string result;
			try
			{
				string text = ctx.Database.SqlQuery<string>("select host from information_schema.processlist WHERE ID=connection_id();", new object[0]).ToArray<string>()[0].Split(new char[]
				{
					':'
				})[0];
				if (!string.IsNullOrEmpty(text) && text.Length > 255)
				{
					text = text.Substring(0, 254);
				}
				result = text;
			}
			catch (Exception exception)
			{
				Core.Log.Error(exception, "Get ip address fail");
				result = "";
			}
			return result;
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x00023150 File Offset: 0x00021350
		public void ClosingActions()
		{
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x00023538 File Offset: 0x00021738
		[CompilerGenerated]
		private IAscResult <RefreshValid>b__32_0()
		{
			return base.method_1("");
		}

		// Token: 0x040008C5 RID: 2245
		private readonly ServerInfo _serverInfo = ServerInfo.Instance;

		// Token: 0x040008C6 RID: 2246
		private static readonly ILogger Log = LogManager.GetCurrentClassLogger();

		// Token: 0x040008C7 RID: 2247
		private readonly IUserActivityService _userActivityService;

		// Token: 0x040008C8 RID: 2248
		private readonly ITaskService _taskService;

		// Token: 0x040008C9 RID: 2249
		private static Core _core = new Core();

		// Token: 0x040008CA RID: 2250
		public Localization _localization = new Localization("UTC");

		// Token: 0x040008CB RID: 2251
		public WorkshopOptions _workshopOptions = new WorkshopOptions();

		// Token: 0x040008CC RID: 2252
		private Timer _userActivityTimer;

		// Token: 0x040008CD RID: 2253
		private Timer _backupTimer;

		// Token: 0x040008CE RID: 2254
		private Timer _serviceWorksTimer;

		// Token: 0x040008CF RID: 2255
		public IVoIP VoIP;

		// Token: 0x040008D0 RID: 2256
		public IOnlineStore OnlineStore;

		// Token: 0x040008D1 RID: 2257
		private bool _valid;

		// Token: 0x040008D2 RID: 2258
		[CompilerGenerated]
		private EventHandler Validated;

		// Token: 0x040008D3 RID: 2259
		private const int _backupTickPeriod = 60;

		// Token: 0x0200009E RID: 158
		[CompilerGenerated]
		private sealed class <>c__DisplayClass31_0
		{
			// Token: 0x06001291 RID: 4753 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass31_0()
			{
			}

			// Token: 0x06001292 RID: 4754 RVA: 0x00023550 File Offset: 0x00021750
			internal void <ServiceWorks>b__2()
			{
				NotificationService.CreateTermsNotification(this.result);
			}

			// Token: 0x040008D4 RID: 2260
			public List<KeyValuePair<int, string>> result;
		}

		// Token: 0x0200009F RID: 159
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001293 RID: 4755 RVA: 0x00023568 File Offset: 0x00021768
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06001294 RID: 4756 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x040008D5 RID: 2261
			public static readonly Core.<>c <>9 = new Core.<>c();
		}

		// Token: 0x020000A0 RID: 160
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ServiceWorks>d__31 : IAsyncStateMachine
		{
			// Token: 0x06001295 RID: 4757 RVA: 0x00023580 File Offset: 0x00021780
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Core core = this.<>4__this;
				try
				{
					if (num <= 4 || core._serverInfo.Connected)
					{
						try
						{
							TaskAwaiter<List<workshop>> awaiter;
							TaskAwaiter awaiter2;
							switch (num)
							{
							case 0:
							case 1:
								break;
							case 2:
								goto IL_366;
							case 3:
							{
								awaiter = this.<>u__4;
								this.<>u__4 = default(TaskAwaiter<List<workshop>>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								goto IL_698;
							}
							case 4:
							{
								awaiter2 = this.<>u__5;
								this.<>u__5 = default(TaskAwaiter);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
								goto IL_809;
							}
							default:
								this.<repo>5__2 = new GenericRepository<docs>();
								break;
							}
							try
							{
								if (num > 1)
								{
									List<docs> list = new List<docs>(this.<repo>5__2.GetAll((docs d) => d.type == 6 && d.state == (int?)3 && DbFunctions.DiffDays((DateTime?)core._localization.Now, (DateTime?)d.created) > (int?)d.reserve_days, null, ""));
									if (!list.Any<docs>())
									{
										goto IL_300;
									}
									this.<>7__wrap2 = list.GetEnumerator();
								}
								try
								{
									TaskAwaiter<List<store_items>> awaiter3;
									if (num == 0)
									{
										awaiter3 = this.<>u__1;
										this.<>u__1 = default(TaskAwaiter<List<store_items>>);
										int num4 = -1;
										num = -1;
										this.<>1__state = num4;
										goto IL_267;
									}
									if (num != 1)
									{
										goto IL_226;
									}
									TaskAwaiter<bool> awaiter4 = this.<>u__2;
									this.<>u__2 = default(TaskAwaiter<bool>);
									int num5 = -1;
									num = -1;
									this.<>1__state = num5;
									IL_217:
									awaiter4.GetResult();
									this.<doc>5__4 = null;
									IL_226:
									if (!this.<>7__wrap2.MoveNext())
									{
										goto IL_2F4;
									}
									this.<doc>5__4 = this.<>7__wrap2.Current;
									awaiter3 = DocumentsModel.LoadSoldItems(this.<doc>5__4.id).GetAwaiter();
									if (!awaiter3.IsCompleted)
									{
										int num6 = 0;
										num = 0;
										this.<>1__state = num6;
										this.<>u__1 = awaiter3;
										this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_items>>, Core.<ServiceWorks>d__31>(ref awaiter3, ref this);
										return;
									}
									IL_267:
									awaiter4 = ItemsSaleModel.CancellReserve(awaiter3.GetResult(), new int?(this.<doc>5__4.id), false).GetAwaiter();
									if (!awaiter4.IsCompleted)
									{
										int num7 = 1;
										num = 1;
										this.<>1__state = num7;
										this.<>u__2 = awaiter4;
										this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Core.<ServiceWorks>d__31>(ref awaiter4, ref this);
										return;
									}
									goto IL_217;
								}
								finally
								{
									if (num < 0)
									{
										((IDisposable)this.<>7__wrap2).Dispose();
									}
								}
								IL_2F4:
								this.<>7__wrap2 = default(List<docs>.Enumerator);
								IL_300:;
							}
							finally
							{
								if (num < 0 && this.<repo>5__2 != null)
								{
									((IDisposable)this.<repo>5__2).Dispose();
								}
							}
							this.<repo>5__2 = null;
							if (OfflineData.Instance.Settings.InformSms && OfflineData.Instance.Employee.Can(22, 0))
							{
								NotificationService.CreateSmsNotifications(OfflineData.Instance.Employee.Id);
							}
							this.<ctx>5__5 = new auseceEntities(true);
							IL_366:
							try
							{
								TaskAwaiter<List<hooks>> awaiter5;
								if (num != 2)
								{
									awaiter5 = (from h in this.<ctx>5__5.hooks
									where h.status == 1L && h.@event == "CALLBACK"
									select h).ToListAsync<hooks>().GetAwaiter();
									if (!awaiter5.IsCompleted)
									{
										int num8 = 2;
										num = 2;
										this.<>1__state = num8;
										this.<>u__3 = awaiter5;
										this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<hooks>>, Core.<ServiceWorks>d__31>(ref awaiter5, ref this);
										return;
									}
								}
								else
								{
									awaiter5 = this.<>u__3;
									this.<>u__3 = default(TaskAwaiter<List<hooks>>);
									int num9 = -1;
									num = -1;
									this.<>1__state = num9;
								}
								List<hooks> result = awaiter5.GetResult();
								DateTime serverUtcTime = Localization.GetServerUtcTime(this.<ctx>5__5);
								List<hooks>.Enumerator enumerator = result.GetEnumerator();
								try
								{
									while (enumerator.MoveNext())
									{
										hooks hooks = enumerator.Current;
										ASC.Extensions.OpenCart.Models.Customer customer = JsonConvert.DeserializeObject<ASC.Extensions.OpenCart.Models.Customer>(hooks.prm);
										if (!string.IsNullOrEmpty(customer.Firstname))
										{
											customer.CustomerId = OpenCartStore.CreateCustomer(customer, this.<ctx>5__5);
											List<int> employeeIds = UsersModel.UsersByPermission(58, 0);
											AscTask ascTask = new AscTask();
											ascTask.SetDefaultValues();
											ascTask.TopEmployee = OfflineData.Instance.Employee.Office.AdministratorId;
											ascTask.Type = TaskType.Callback;
											ascTask.CustomerId = new int?(customer.CustomerId);
											ascTask.AddResponsibleUsers(employeeIds);
											ascTask.Subject = "Обратный звонок";
											ascTask.Message = string.Concat(new string[]
											{
												"Клиент ",
												customer.Firstname,
												" [ID: ",
												customer.CustomerId.ToString(),
												"] желает чтобы ему позвонили на номер ",
												customer.Telephone
											});
											ascTask.Tel = customer.Telephone;
											hooks.task_id = new int?(core._taskService.CreateTask(this.<ctx>5__5, ascTask));
											hooks.status = 3L;
											hooks.updated_at = new DateTime?(serverUtcTime);
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
								this.<ctx>5__5.SaveChanges();
							}
							finally
							{
								if (num < 0 && this.<ctx>5__5 != null)
								{
									((IDisposable)this.<ctx>5__5).Dispose();
								}
							}
							this.<ctx>5__5 = null;
							List<int> list2 = core._workshopOptions.TermNotificationStatuses();
							if (!list2.Any<int>())
							{
								goto IL_817;
							}
							this.<>8__1 = new Core.<>c__DisplayClass31_0();
							awaiter = RepairModel.GetEmployeeRepairs(OfflineData.Instance.Employee.Id, list2).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num10 = 3;
								num = 3;
								this.<>1__state = num10;
								this.<>u__4 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<workshop>>, Core.<ServiceWorks>d__31>(ref awaiter, ref this);
								return;
							}
							IL_698:
							List<workshop> result2 = awaiter.GetResult();
							this.<>8__1.result = new List<KeyValuePair<int, string>>();
							List<workshop>.Enumerator enumerator2 = result2.GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									workshop workshop = enumerator2.Current;
									if (workshop.current_manager != OfflineData.Instance.Employee.Id)
									{
										if (workshop.state == 0)
										{
											continue;
										}
										if (workshop.state == 6)
										{
											continue;
										}
										if (workshop.state == 7)
										{
											continue;
										}
										if (workshop.state == 16)
										{
											continue;
										}
									}
									WorkshopOptions workshopOptions = new WorkshopOptions(workshop.state);
									if (workshop.last_status_changed != null && workshopOptions.TermsExpired(workshop.last_status_changed.Value, core._localization.Now))
									{
										this.<>8__1.result.Add(new KeyValuePair<int, string>(workshop.id, workshopOptions.Name));
									}
								}
							}
							finally
							{
								if (num < 0)
								{
									((IDisposable)enumerator2).Dispose();
								}
							}
							if (!this.<>8__1.result.Any<KeyValuePair<int, string>>())
							{
								goto IL_810;
							}
							awaiter2 = Task.Run(new Action(this.<>8__1.<ServiceWorks>b__2)).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num11 = 4;
								num = 4;
								this.<>1__state = num11;
								this.<>u__5 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Core.<ServiceWorks>d__31>(ref awaiter2, ref this);
								return;
							}
							IL_809:
							awaiter2.GetResult();
							IL_810:
							this.<>8__1 = null;
							IL_817:;
						}
						catch (Exception ex)
						{
							Core.Log.Info(ex, ex.Message);
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
				this.<>t__builder.SetResult();
			}

			// Token: 0x06001296 RID: 4758 RVA: 0x00023E98 File Offset: 0x00022098
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040008D6 RID: 2262
			public int <>1__state;

			// Token: 0x040008D7 RID: 2263
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040008D8 RID: 2264
			public Core <>4__this;

			// Token: 0x040008D9 RID: 2265
			private Core.<>c__DisplayClass31_0 <>8__1;

			// Token: 0x040008DA RID: 2266
			private GenericRepository<docs> <repo>5__2;

			// Token: 0x040008DB RID: 2267
			private List<docs>.Enumerator <>7__wrap2;

			// Token: 0x040008DC RID: 2268
			private docs <doc>5__4;

			// Token: 0x040008DD RID: 2269
			private TaskAwaiter<List<store_items>> <>u__1;

			// Token: 0x040008DE RID: 2270
			private TaskAwaiter<bool> <>u__2;

			// Token: 0x040008DF RID: 2271
			private auseceEntities <ctx>5__5;

			// Token: 0x040008E0 RID: 2272
			private TaskAwaiter<List<hooks>> <>u__3;

			// Token: 0x040008E1 RID: 2273
			private TaskAwaiter<List<workshop>> <>u__4;

			// Token: 0x040008E2 RID: 2274
			private TaskAwaiter <>u__5;
		}

		// Token: 0x020000A1 RID: 161
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <RefreshValid>d__32 : IAsyncStateMachine
		{
			// Token: 0x06001297 RID: 4759 RVA: 0x00023EB4 File Offset: 0x000220B4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Core core = this.<>4__this;
				try
				{
					TaskAwaiter<IAscResult> awaiter;
					if (num != 0)
					{
						awaiter = Task.Run<IAscResult>(() => base.method_1("")).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IAscResult>, Core.<RefreshValid>d__32>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IAscResult>);
						this.<>1__state = -1;
					}
					IAscResult result = awaiter.GetResult();
					core._valid = result.IsSucces;
					core.RaiseValidated(EventArgs.Empty);
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

			// Token: 0x06001298 RID: 4760 RVA: 0x00023F8C File Offset: 0x0002218C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040008E3 RID: 2275
			public int <>1__state;

			// Token: 0x040008E4 RID: 2276
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040008E5 RID: 2277
			public Core <>4__this;

			// Token: 0x040008E6 RID: 2278
			private TaskAwaiter<IAscResult> <>u__1;
		}
	}
}
