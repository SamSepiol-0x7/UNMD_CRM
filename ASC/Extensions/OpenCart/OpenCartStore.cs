using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading;
using ASC.Common.Interfaces.Extensions.OpenCart;
using ASC.Common.Interfaces.SiteStore;
using ASC.Extensions.OpenCart.Models;
using ASC.Models;
using ASC.Services.Abstract;
using Newtonsoft.Json;

namespace ASC.Extensions.OpenCart
{
	// Token: 0x02000B9A RID: 2970
	public class OpenCartStore : IOnlineStore
	{
		// Token: 0x17001515 RID: 5397
		// (get) Token: 0x06005294 RID: 21140 RVA: 0x00163D0C File Offset: 0x00161F0C
		// (set) Token: 0x06005295 RID: 21141 RVA: 0x00163D20 File Offset: 0x00161F20
		public EventHandler<EventArgs> OnNewOrder
		{
			[CompilerGenerated]
			get
			{
				return this.<OnNewOrder>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<OnNewOrder>k__BackingField = value;
			}
		}

		// Token: 0x17001516 RID: 5398
		// (get) Token: 0x06005296 RID: 21142 RVA: 0x00163D34 File Offset: 0x00161F34
		// (set) Token: 0x06005297 RID: 21143 RVA: 0x00163D48 File Offset: 0x00161F48
		public EventHandler<EventArgs> OnNewCustomer
		{
			[CompilerGenerated]
			get
			{
				return this.<OnNewCustomer>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<OnNewCustomer>k__BackingField = value;
			}
		}

		// Token: 0x06005298 RID: 21144 RVA: 0x00163D5C File Offset: 0x00161F5C
		public OpenCartStore(ITaskService taskService)
		{
			this._taskService = taskService;
			this.apiKey = Auth.Config.online_store_key;
			this.baseUrl = Auth.Config.online_store_api;
			this._employeeIds = UsersModel.UsersByPermission(58, 0);
			this._timer = new Timer(new TimerCallback(this.OrdersCheck), null, 3000, 5000);
		}

		// Token: 0x06005299 RID: 21145 RVA: 0x00163DD4 File Offset: 0x00161FD4
		private void OrdersCheck(object state)
		{
			if (!this._busy && this._employeeIds.Any<int>() && this._serverInfo.Connected)
			{
				this.SetBusy(true);
				try
				{
					this.OrdersCheck();
				}
				catch (Exception)
				{
					this.SleepOrdersCheck();
				}
				this.SetBusy(false);
				return;
			}
		}

		// Token: 0x0600529A RID: 21146 RVA: 0x00023150 File Offset: 0x00021350
		private void SleepOrdersCheck()
		{
		}

		// Token: 0x0600529B RID: 21147 RVA: 0x00163E34 File Offset: 0x00162034
		private void OrdersCheck()
		{
			using (auseceEntities auseceEntities = new auseceEntities(true))
			{
				DateTime serverUtcTime = Localization.GetServerUtcTime(auseceEntities);
				DateTime maxDate = serverUtcTime.AddMinutes(-10.0);
				List<hooks> list = auseceEntities.hooks.Where(OpenCartStore.NewOpenCartOrder(maxDate)).ToList<hooks>();
				OpenCartStore.PendingHooks(list, serverUtcTime, auseceEntities);
				foreach (hooks hooks in list)
				{
					Order order = JsonConvert.DeserializeObject<Order>(hooks.prm);
					if (hooks.@event == "NEW_ORDER")
					{
						hooks.task_id = new int?(this.CreateTask(order, auseceEntities));
					}
					if (hooks.@event == "ORDER_CHANGED")
					{
						tasks tasks = auseceEntities.tasks.FirstOrDefault((tasks t) => t.hooks.Any((hooks h) => h.hook_id == 3L && h.p0 == (long?)((long)order.OrderId)));
						if (tasks != null)
						{
							this.CreateTaskNotification(tasks, auseceEntities, hooks, order);
						}
						else
						{
							hooks.task_id = new int?(this.CreateTask(order, auseceEntities));
						}
					}
					if (hooks.@event == "NEW_CUSTOMER")
					{
						Customer customer = JsonConvert.DeserializeObject<Customer>(hooks.prm);
						if (auseceEntities.clients.FirstOrDefault((clients c) => c.email == customer.Email) == null)
						{
							customer.CustomerId = OpenCartStore.CreateCustomer(customer, auseceEntities);
							this.CreateTaskNotification(auseceEntities, customer);
						}
					}
					hooks.p0 = new long?((long)order.OrderId);
					hooks.status = 3L;
					auseceEntities.SaveChanges();
				}
			}
		}

		// Token: 0x0600529C RID: 21148 RVA: 0x001641C0 File Offset: 0x001623C0
		private int CreateTask(IOrder order, auseceEntities ctx)
		{
			if (ctx.clients.FirstOrDefault((clients c) => c.email == order.Email) == null)
			{
				OpenCartStore.CreateCustomer(order, ctx);
			}
			SiteOrderTask siteOrderTask = new SiteOrderTask(order);
			siteOrderTask.AddResponsibleUsers(this._employeeIds);
			this.RaiseOnNewOrder(null);
			return this._taskService.CreateTask(ctx, siteOrderTask);
		}

		// Token: 0x0600529D RID: 21149 RVA: 0x00164294 File Offset: 0x00162494
		private static void PendingHooks(List<hooks> oChooks, DateTime serverTime, auseceEntities ctx)
		{
			using (List<hooks>.Enumerator enumerator = oChooks.GetEnumerator())
			{
				for (;;)
				{
					IL_6F:
					int num = (!enumerator.MoveNext()) ? -1755494493 : -1294807928;
					for (;;)
					{
						switch ((num ^ -1492184855) % 4)
						{
						case 0:
							goto IL_6F;
						case 1:
						{
							hooks hooks = enumerator.Current;
							hooks.status = 2L;
							hooks.updated_at = new DateTime?(serverTime);
							num = -561865531;
							continue;
						}
						case 3:
							num = -1294807928;
							continue;
						}
						goto Block_3;
					}
				}
				Block_3:;
			}
			ctx.SaveChanges();
		}

		// Token: 0x0600529E RID: 21150 RVA: 0x00164344 File Offset: 0x00162544
		private static int CreateCustomer(IOrder order, auseceEntities ctx)
		{
			return OpenCartStore.CreateCustomer(new Customer
			{
				Lastname = order.Lastname,
				Firstname = order.Firstname,
				Email = order.Email,
				Telephone = order.Telephone
			}, ctx);
		}

		// Token: 0x0600529F RID: 21151 RVA: 0x0016438C File Offset: 0x0016258C
		public static int CreateCustomer(Customer customer, auseceEntities ctx)
		{
			clients clients = new clients();
			clients = ClientsModel.SetDefaultValues(clients);
			clients.name = customer.Firstname;
			clients.surname = customer.Lastname;
			clients.email = customer.Email;
			if (!string.IsNullOrEmpty(customer.Telephone))
			{
				ClientsModel.AddTel(clients, customer.Telephone);
			}
			ctx.clients.Add(clients);
			ctx.SaveChanges();
			return clients.id;
		}

		// Token: 0x060052A0 RID: 21152 RVA: 0x00164400 File Offset: 0x00162600
		public void CreateTaskNotification(auseceEntities ctx, Customer customer)
		{
			string text = string.Concat(new string[]
			{
				Lang.t("NewClient"),
				": ",
				customer.Lastname,
				" ",
				customer.Firstname,
				" ",
				customer.Email
			});
			foreach (int user in this._employeeIds)
			{
				this._taskService.CreateNotifications(ctx, user, customer.CustomerId, text);
			}
		}

		// Token: 0x060052A1 RID: 21153 RVA: 0x001644B0 File Offset: 0x001626B0
		private void CreateTaskNotification(tasks task, auseceEntities ctx, hooks hook, IOrder order)
		{
			hooks hooks = task.hooks.FirstOrDefault((hooks h) => h.@event == "NEW_ORDER");
			if (hooks != null)
			{
				hooks.prm = hook.prm;
				if (hook.created_at - hooks.created_at <= TimeSpan.FromSeconds(3.0))
				{
					return;
				}
			}
			hook.task_id = new int?(task.idt);
			string text = string.Concat(new string[]
			{
				string.Format("{0} #{1} {2}", Lang.t("Id"), order.OrderId, Lang.t("Changed").ToLower()),
				"[",
				order.StoreName,
				"] ",
				Environment.NewLine,
				Lang.t("Status"),
				": ",
				order.OrderStatus
			});
			foreach (int user in this._employeeIds)
			{
				this._taskService.CreateNotifications(ctx, user, task, text);
			}
		}

		// Token: 0x060052A2 RID: 21154 RVA: 0x0016464C File Offset: 0x0016284C
		private static Expression<Func<hooks, bool>> NewOpenCartOrder(DateTime maxDate)
		{
			List<string> events = new List<string>
			{
				"NEW_ORDER",
				"ORDER_CHANGED",
				"NEW_CUSTOMER"
			};
			return (hooks h) => h.hook_id == 3L && events.Contains(h.@event) && (h.status == 1L || (h.status == 2L && (DateTime?)maxDate > h.updated_at));
		}

		// Token: 0x060052A3 RID: 21155 RVA: 0x00164820 File Offset: 0x00162A20
		private void RaiseOnNewOrder(EventArgs args)
		{
			if (this.OnNewOrder != null)
			{
				this.OnNewOrder(this, args);
			}
		}

		// Token: 0x060052A4 RID: 21156 RVA: 0x00164844 File Offset: 0x00162A44
		private void SetBusy(bool value)
		{
			this._busy = value;
		}

		// Token: 0x04003680 RID: 13952
		private readonly ITaskService _taskService;

		// Token: 0x04003681 RID: 13953
		private readonly ServerInfo _serverInfo = ServerInfo.Instance;

		// Token: 0x04003682 RID: 13954
		private string baseUrl;

		// Token: 0x04003683 RID: 13955
		private string apiKey;

		// Token: 0x04003684 RID: 13956
		[CompilerGenerated]
		private EventHandler<EventArgs> <OnNewOrder>k__BackingField;

		// Token: 0x04003685 RID: 13957
		[CompilerGenerated]
		private EventHandler<EventArgs> <OnNewCustomer>k__BackingField;

		// Token: 0x04003686 RID: 13958
		private bool _busy;

		// Token: 0x04003687 RID: 13959
		private Timer _timer;

		// Token: 0x04003688 RID: 13960
		private List<int> _employeeIds;

		// Token: 0x02000B9B RID: 2971
		[CompilerGenerated]
		private sealed class <>c__DisplayClass18_0
		{
			// Token: 0x060052A5 RID: 21157 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass18_0()
			{
			}

			// Token: 0x04003689 RID: 13961
			public Order order;
		}

		// Token: 0x02000B9C RID: 2972
		[CompilerGenerated]
		private sealed class <>c__DisplayClass18_1
		{
			// Token: 0x060052A6 RID: 21158 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass18_1()
			{
			}

			// Token: 0x0400368A RID: 13962
			public Customer customer;
		}

		// Token: 0x02000B9D RID: 2973
		[CompilerGenerated]
		private sealed class <>c__DisplayClass19_0
		{
			// Token: 0x060052A7 RID: 21159 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass19_0()
			{
			}

			// Token: 0x0400368B RID: 13963
			public IOrder order;
		}

		// Token: 0x02000B9E RID: 2974
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060052A8 RID: 21160 RVA: 0x00164858 File Offset: 0x00162A58
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060052A9 RID: 21161 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x060052AA RID: 21162 RVA: 0x00164870 File Offset: 0x00162A70
			internal bool <CreateTaskNotification>b__24_0(hooks h)
			{
				return h.@event == "NEW_ORDER";
			}

			// Token: 0x0400368C RID: 13964
			public static readonly OpenCartStore.<>c <>9 = new OpenCartStore.<>c();

			// Token: 0x0400368D RID: 13965
			public static Func<hooks, bool> <>9__24_0;
		}

		// Token: 0x02000B9F RID: 2975
		[CompilerGenerated]
		private sealed class <>c__DisplayClass25_0
		{
			// Token: 0x060052AB RID: 21163 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass25_0()
			{
			}

			// Token: 0x0400368E RID: 13966
			public List<string> events;

			// Token: 0x0400368F RID: 13967
			public DateTime maxDate;
		}
	}
}
