using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Models;
using ASC.Objects;
using ASC.Objects.Converters;
using ASC.SimpleClasses;

namespace ASC.Workspace
{
	// Token: 0x02000110 RID: 272
	public class WorkspaceModel
	{
		// Token: 0x06001430 RID: 5168 RVA: 0x0002C1B0 File Offset: 0x0002A3B0
		public Task<List<WorkshopLite>> SelectOrders(RepairGridOptions gridOptions, bool? hidden = false)
		{
			WorkspaceModel.<SelectOrders>d__3 <SelectOrders>d__;
			<SelectOrders>d__.<>t__builder = AsyncTaskMethodBuilder<List<WorkshopLite>>.Create();
			<SelectOrders>d__.<>4__this = this;
			<SelectOrders>d__.gridOptions = gridOptions;
			<SelectOrders>d__.hidden = hidden;
			<SelectOrders>d__.<>1__state = -1;
			<SelectOrders>d__.<>t__builder.Start<WorkspaceModel.<SelectOrders>d__3>(ref <SelectOrders>d__);
			return <SelectOrders>d__.<>t__builder.Task;
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x0002C204 File Offset: 0x0002A404
		private static Expression<Func<workshop, bool>> ExcludeStatuses(int[] states)
		{
			return (workshop r) => !states.Contains(r.state);
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x0002C29C File Offset: 0x0002A49C
		private static Expression<Func<workshop, bool>> MasterOrManager(int userId)
		{
			return (workshop r) => r.current_manager == userId || r.master == (int?)userId;
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x0002C360 File Offset: 0x0002A560
		private Employee GetEmployee(int? employeeId)
		{
			if (employeeId != null && this._employees != null)
			{
				return this._employees.FirstOrDefault(delegate(Employee e)
				{
					int id = e.Id;
					int? employeeId2 = employeeId;
					return id == employeeId2.GetValueOrDefault() & employeeId2 != null;
				}) ?? new Employee();
			}
			return new Employee();
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x0002C3B8 File Offset: 0x0002A5B8
		private Func<workshop, WorkshopLite> OrderRecord(string query)
		{
			bool canViewClients = OfflineData.Instance.Employee.Can(7, 0);
			bool csaew = OfflineData.Instance.Employee.Can(25, 0) || OfflineData.Instance.Employee.Can(77, 0);
			return delegate(workshop r)
			{
				WorkshopLite workshopLite = new WorkshopLite();
				workshopLite.LockEmployee = this.GetEmployee(r.user_lock);
				workshopLite.VendorId = r.vendor_id;
				workshopLite.MasterEmployee = this.GetEmployee(r.master);
				workshopLite.CurrentManagerEmployee = this.GetEmployee(new int?(r.current_manager));
				workshopLite.ClientId = r.client;
				workshopLite.ClientType = r.clients.type;
				workshopLite.ClientUrName = (canViewClients ? r.clients.ur_name : "No permissions");
				workshopLite.ClientFirstName = (canViewClients ? r.clients.name : "No permissions");
				workshopLite.ClientLastName = (canViewClients ? r.clients.surname : "No permissions");
				workshopLite.ClientPatronymic = (canViewClients ? r.clients.patronymic : "No permissions");
				workshopLite.ClientPhone = (canViewClients ? CustomerConverter.GetFirstCustomerTel(r.clients) : "No permissions");
				workshopLite.ClientRepairs = r.clients.repairs;
				workshopLite.LockUserId = r.user_lock;
				workshopLite.LockTime = r.lock_datetime;
				workshopLite.RepairId = r.id;
				workshopLite.InformedStatus = r.informed_status;
				workshopLite.DeviceOverview = r.Title;
				workshopLite.SerialNumber = r.serial_number;
				workshopLite.Fault = r.fault;
				workshopLite.State = r.state;
				workshopLite.CurrentManager = r.current_manager;
				workshopLite.Manager = r.manager;
				workshopLite.Master = r.master;
				workshopLite.Office = r.office;
				workshopLite.InDate = r.in_date;
				workshopLite.OutDate = r.out_date;
				workshopLite.LastStatusChanged = r.last_status_changed;
				workshopLite.RepairCost = r.repair_cost;
				workshopLite.RealRepairCost = (csaew ? r.real_repair_cost : 0m);
				boxes boxes = r.boxes;
				string boxName;
				if (boxes != null)
				{
					if ((boxName = boxes.name) != null)
					{
						goto IL_220;
					}
				}
				boxName = "";
				IL_220:
				workshopLite.BoxName = boxName;
				workshopLite.Color = r.color;
				workshopLite.OrderMoving = r.order_moving;
				workshopLite.IsWarranty = r.is_warranty;
				workshopLite.IsExpress = r.express_repair;
				workshopLite.IsRegular = r.clients.is_regular;
				workshopLite.IsAgent = r.clients.is_agent;
				workshopLite.IsBad = r.clients.is_bad;
				workshopLite.IsQuery = !string.IsNullOrEmpty(query);
				workshopLite.UserFields = r.field_values;
				workshopLite.CartridgeId = r.cartridge;
				return workshopLite;
			};
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x0002C42C File Offset: 0x0002A62C
		private static Expression<Func<workshop, bool>> SearchCriteria(string query)
		{
			query = WorkspaceModel.RemoveZeroIfInt(query);
			return (workshop r) => r.id.ToString().Contains(query) || r.Title.Contains(query) || r.serial_number.Contains(query) || r.clients.tel.Any((tel t) => t.phone_clean.Contains(query)) || r.clients.surname.Contains(query) || r.clients.name.Contains(query) || r.clients.patronymic.Contains(query) || r.clients.ur_name.Contains(query) || r.fault.Contains(query) || (from f in r.field_values
			select f.value).Contains(query);
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x0002C908 File Offset: 0x0002AB08
		private Expression<Func<workshop, bool>> OutInPeriod(int SelectedWorkshopOption)
		{
			DateTime fromPeriod = this._localization.Now.AddDays((double)(-(double)SelectedWorkshopOption));
			return (workshop r) => r.out_date != null && r.out_date.Value >= fromPeriod;
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x0002CA0C File Offset: 0x0002AC0C
		private static string RemoveZeroIfInt(string query)
		{
			int num;
			if (int.TryParse(query, out num))
			{
				query = num.ToString();
			}
			return query;
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x0002CA30 File Offset: 0x0002AC30
		public WorkspaceModel()
		{
		}

		// Token: 0x040009AE RID: 2478
		private readonly Localization _localization = new Localization("UTC");

		// Token: 0x040009AF RID: 2479
		private List<Employee> _employees;

		// Token: 0x040009B0 RID: 2480
		private DateTime _employessLoaded = DateTime.Now;

		// Token: 0x02000111 RID: 273
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06001439 RID: 5177 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x040009B1 RID: 2481
			public bool? hidden;

			// Token: 0x040009B2 RID: 2482
			public RepairGridOptions gridOptions;
		}

		// Token: 0x02000112 RID: 274
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600143A RID: 5178 RVA: 0x0002CA60 File Offset: 0x0002AC60
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600143B RID: 5179 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x040009B3 RID: 2483
			public static readonly WorkspaceModel.<>c <>9 = new WorkspaceModel.<>c();
		}

		// Token: 0x02000113 RID: 275
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SelectOrders>d__3 : IAsyncStateMachine
		{
			// Token: 0x0600143C RID: 5180 RVA: 0x0002CA78 File Offset: 0x0002AC78
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkspaceModel workspaceModel = this.<>4__this;
				List<WorkshopLite> result2;
				try
				{
					if (num > 1)
					{
						this.<>8__1 = new WorkspaceModel.<>c__DisplayClass3_0();
						this.<>8__1.hidden = this.hidden;
						this.<>8__1.gridOptions = this.gridOptions;
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						if (num != 0)
						{
							goto IL_3E6;
						}
						goto IL_720;
						IQueryable<workshop> source;
						for (;;)
						{
							IL_41E:
							source = this.<ctx>5__2.workshop.Include((workshop r) => r.clients).Include((workshop r) => r.clients.tel).Include((workshop r) => r.boxes).Include((workshop r) => r.field_values).Include((workshop r) => r.c_workshop.cartridge_cards).AsNoTracking<workshop>();
							for (;;)
							{
								IL_3D8:
								if (Auth.User.new_on_top)
								{
									goto IL_379;
								}
								for (;;)
								{
									IL_3BE:
									if (this.<>8__1.hidden != null)
									{
										goto IL_2F7;
									}
									for (;;)
									{
										IL_2E0:
										if (this.<>8__1.gridOptions.DeviceType != 0)
										{
											goto IL_1CF;
										}
										IL_2C5:
										while (this.<>8__1.gridOptions.CustomerType != 3)
										{
											for (;;)
											{
												IL_1BB:
												int customerType = this.<>8__1.gridOptions.CustomerType;
												for (;;)
												{
													IL_193:
													switch (customerType)
													{
													case 0:
														goto IL_772;
													case 1:
														goto IL_7D0;
													case 2:
													case 3:
														goto IL_95A;
													case 4:
														goto IL_82E;
													case 5:
														goto IL_88C;
													case 6:
														goto IL_901;
													default:
													{
														uint num3;
														uint num2 = num3 * 319117574U ^ 315678567U;
														for (;;)
														{
															switch ((num3 = (num2 ^ 3468522325U)) % 66U)
															{
															case 0U:
																goto IL_6F3;
															case 1U:
																goto IL_CD4;
															case 2U:
																goto IL_72A;
															case 3U:
															case 7U:
																goto IL_C68;
															case 4U:
																goto IL_6EA;
															case 5U:
															case 8U:
															case 36U:
															case 52U:
																goto IL_95A;
															case 6U:
																goto IL_ADF;
															case 9U:
																goto IL_41E;
															case 10U:
															case 41U:
																goto IL_BD1;
															case 11U:
																goto IL_82E;
															case 12U:
																goto IL_1BB;
															case 13U:
																goto IL_ACA;
															case 14U:
																goto IL_2E0;
															case 15U:
																goto IL_732;
															case 16U:
																goto IL_720;
															case 17U:
																goto IL_751;
															case 18U:
																goto IL_88C;
															case 19U:
																goto IL_BE6;
															case 20U:
																goto IL_CB0;
															case 21U:
																goto IL_193;
															case 22U:
																goto IL_709;
															case 23U:
																goto IL_772;
															case 24U:
																goto IL_CC1;
															case 25U:
																goto IL_5A2;
															case 26U:
																goto IL_2C5;
															case 27U:
																goto IL_740;
															case 28U:
																goto IL_3D8;
															case 29U:
																goto IL_400;
															case 30U:
																goto IL_3EF;
															case 31U:
																goto IL_AAD;
															case 32U:
																goto IL_989;
															case 33U:
																goto IL_40B;
															case 34U:
															case 61U:
																goto IL_A9B;
															case 35U:
																goto IL_3BE;
															case 37U:
																goto IL_7D0;
															case 38U:
																goto IL_BB3;
															case 39U:
																goto IL_9AC;
															case 40U:
																goto IL_9E9;
															case 42U:
																goto IL_1E2;
															case 43U:
																goto IL_CA7;
															case 44U:
																goto IL_BA1;
															case 45U:
															case 49U:
																goto IL_3E6;
															case 46U:
															case 65U:
																goto IL_C99;
															case 47U:
																goto IL_379;
															case 48U:
																goto IL_901;
															case 50U:
																goto IL_A19;
															case 51U:
																goto IL_1CF;
															case 53U:
																goto IL_C7A;
															case 54U:
																goto IL_24A;
															case 56U:
																goto IL_9F8;
															case 57U:
																goto IL_971;
															case 58U:
																num2 = (num3 * 908064618U ^ 2043474620U);
																continue;
															case 59U:
																goto IL_25D;
															case 60U:
																goto IL_764;
															case 62U:
																goto IL_9C0;
															case 63U:
																goto IL_9CC;
															case 64U:
																goto IL_2F7;
															}
															goto Block_7;
														}
														break;
													}
													}
												}
											}
										}
										goto Block_9;
										IL_24A:
										if (this.<>8__1.gridOptions.DeviceType == 2)
										{
											goto IL_25D;
										}
										goto IL_2C5;
										IL_1CF:
										if (this.<>8__1.gridOptions.DeviceType == 1)
										{
											goto IL_1E2;
										}
										goto IL_24A;
										IL_25D:
										source = from o in source
										where o.cartridge == null
										select o;
										goto IL_2C5;
										IL_1E2:
										source = from o in source
										where o.cartridge != null
										select o;
										goto IL_24A;
									}
									IL_2F7:
									source = from r in source
									where (bool?)r.Hidden == this.<>8__1.hidden
									select r;
									goto IL_2E0;
								}
								IL_379:
								source = from o in source
								orderby o.id descending
								select o;
								goto IL_3BE;
							}
						}
						Block_7:
						goto IL_D01;
						Block_9:
						goto IL_95A;
						IL_772:
						source = from o in source
						where o.clients.is_regular
						select o;
						goto IL_95A;
						IL_7D0:
						source = from o in source
						where o.clients.is_dealer
						select o;
						goto IL_95A;
						IL_82E:
						source = from o in source
						where o.clients.is_bad
						select o;
						goto IL_95A;
						IL_88C:
						source = from o in source
						where o.clients.type == 1
						select o;
						goto IL_95A;
						IL_901:
						source = from o in source
						where o.clients.is_agent
						select o;
						IL_95A:
						if (string.IsNullOrEmpty(this.<>8__1.gridOptions.SearchString))
						{
							goto IL_9AC;
						}
						IL_971:
						if (this.<>8__1.gridOptions.SearchString.Length < 2)
						{
							goto IL_9AC;
						}
						IL_989:
						source = source.Where(WorkspaceModel.SearchCriteria(this.<>8__1.gridOptions.SearchString));
						goto IL_C99;
						IL_9AC:
						if (this.<>8__1.gridOptions.Status != 99)
						{
							goto IL_A19;
						}
						IL_9C0:
						if (Auth.User.display_out)
						{
							goto IL_9E9;
						}
						IL_9CC:
						source = source.Where(WorkspaceModel.ExcludeStatuses(new int[]
						{
							8,
							12
						}));
						IL_9E9:
						if (Auth.User.display_complete)
						{
							goto IL_A9B;
						}
						IL_9F8:
						source = source.Where(WorkspaceModel.ExcludeStatuses(new int[]
						{
							6,
							7
						}));
						goto IL_A9B;
						IL_A19:
						source = from r in source
						where r.state == this.<>8__1.gridOptions.Status
						select r;
						IL_A9B:
						if (!this.<>8__1.gridOptions.OnlyMyOrders)
						{
							goto IL_ACA;
						}
						IL_AAD:
						source = source.Where(WorkspaceModel.MasterOrManager(Auth.User.id));
						goto IL_C68;
						IL_ACA:
						if (this.<>8__1.gridOptions.OpenOtherUserCards)
						{
							goto IL_BA1;
						}
						IL_ADF:
						source = from r in source
						where r.master == null || r.master == (int?)Auth.User.id
						select r;
						goto IL_BD1;
						IL_BA1:
						if (this.<>8__1.gridOptions.Employee == 0)
						{
							goto IL_BD1;
						}
						IL_BB3:
						source = source.Where(WorkspaceModel.MasterOrManager(this.<>8__1.gridOptions.Employee));
						IL_BD1:
						if (this.<>8__1.gridOptions.OfficeId == 0)
						{
							goto IL_C68;
						}
						IL_BE6:
						source = from r in source
						where r.office == this.<>8__1.gridOptions.OfficeId
						select r;
						IL_C68:
						if (this.<>8__1.gridOptions.SelectedWarrantyOption == 0)
						{
							goto IL_C99;
						}
						IL_C7A:
						source = source.Where(workspaceModel.OutInPeriod(this.<>8__1.gridOptions.SelectedWarrantyOption));
						IL_C99:
						TaskAwaiter<List<workshop>> awaiter = source.ToListAsync<workshop>().GetAwaiter();
						IL_CA7:
						if (awaiter.IsCompleted)
						{
							goto IL_CD4;
						}
						IL_CB0:
						int num4 = 1;
						num = 1;
						this.<>1__state = num4;
						this.<>u__2 = awaiter;
						IL_CC1:
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<workshop>>, WorkspaceModel.<SelectOrders>d__3>(ref awaiter, ref this);
						return;
						IL_3E6:
						if (num == 1)
						{
							goto IL_72A;
						}
						IL_3EF:
						TimeSpan t = DateTime.Now - workspaceModel._employessLoaded;
						IL_400:
						if (workspaceModel._employees == null)
						{
							goto IL_5A2;
						}
						IL_40B:
						if (!(t > new TimeSpan(0, 5, 0)))
						{
							goto IL_41E;
						}
						IL_5A2:
						workspaceModel._employessLoaded = DateTime.Now;
						ParameterExpression parameterExpression;
						TaskAwaiter<List<Employee>> awaiter2 = this.<ctx>5__2.users.Select(Expression.Lambda<Func<users, Employee>>(Expression.MemberInit(Expression.New(typeof(Employee)), new MemberBinding[]
						{
							Expression.Bind(methodof(Employee.set_Id(int)), Expression.Property(parameterExpression, methodof(users.get_id()))),
							Expression.Bind(methodof(Employee.set_LastName(string)), Expression.Property(parameterExpression, methodof(users.get_surname()))),
							Expression.Bind(methodof(Employee.set_FirstName(string)), Expression.Property(parameterExpression, methodof(users.get_name()))),
							Expression.Bind(methodof(Employee.set_Patronymic(string)), Expression.Property(parameterExpression, methodof(users.get_patronymic()))),
							Expression.Bind(methodof(Employee.set_OfficeId(int)), Expression.Property(parameterExpression, methodof(users.get_office())))
						}), new ParameterExpression[]
						{
							parameterExpression
						})).ToListAsync<Employee>().GetAwaiter();
						IL_6EA:
						if (!awaiter2.IsCompleted)
						{
							goto IL_740;
						}
						IL_6F3:
						List<Employee> result = awaiter2.GetResult();
						workspaceModel._employees = result;
						goto IL_41E;
						IL_709:
						this.<>u__1 = default(TaskAwaiter<List<Employee>>);
						int num5 = -1;
						num = -1;
						this.<>1__state = num5;
						goto IL_6F3;
						IL_720:
						awaiter2 = this.<>u__1;
						goto IL_709;
						IL_72A:
						awaiter = this.<>u__2;
						IL_732:
						this.<>u__2 = default(TaskAwaiter<List<workshop>>);
						goto IL_764;
						IL_740:
						int num6 = 0;
						num = 0;
						this.<>1__state = num6;
						this.<>u__1 = awaiter2;
						IL_751:
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<Employee>>, WorkspaceModel.<SelectOrders>d__3>(ref awaiter2, ref this);
						return;
						IL_764:
						int num7 = -1;
						num = -1;
						this.<>1__state = num7;
						IL_CD4:
						result2 = awaiter.GetResult().AsParallel<workshop>().Select(workspaceModel.OrderRecord(this.<>8__1.gridOptions.SearchString)).ToList<WorkshopLite>();
						IL_D01:;
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
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x0600143D RID: 5181 RVA: 0x0002D810 File Offset: 0x0002BA10
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040009B4 RID: 2484
			public int <>1__state;

			// Token: 0x040009B5 RID: 2485
			public AsyncTaskMethodBuilder<List<WorkshopLite>> <>t__builder;

			// Token: 0x040009B6 RID: 2486
			public bool? hidden;

			// Token: 0x040009B7 RID: 2487
			public RepairGridOptions gridOptions;

			// Token: 0x040009B8 RID: 2488
			public WorkspaceModel <>4__this;

			// Token: 0x040009B9 RID: 2489
			private WorkspaceModel.<>c__DisplayClass3_0 <>8__1;

			// Token: 0x040009BA RID: 2490
			private auseceEntities <ctx>5__2;

			// Token: 0x040009BB RID: 2491
			private TaskAwaiter<List<Employee>> <>u__1;

			// Token: 0x040009BC RID: 2492
			private TaskAwaiter<List<workshop>> <>u__2;
		}

		// Token: 0x02000114 RID: 276
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x0600143E RID: 5182 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x040009BD RID: 2493
			public int[] states;
		}

		// Token: 0x02000115 RID: 277
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x0600143F RID: 5183 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x040009BE RID: 2494
			public int userId;
		}

		// Token: 0x02000116 RID: 278
		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x06001440 RID: 5184 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x06001441 RID: 5185 RVA: 0x0002D82C File Offset: 0x0002BA2C
			internal bool <GetEmployee>b__0(Employee e)
			{
				int id = e.Id;
				int? num = this.employeeId;
				return id == num.GetValueOrDefault() & num != null;
			}

			// Token: 0x040009BF RID: 2495
			public int? employeeId;
		}

		// Token: 0x02000117 RID: 279
		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x06001442 RID: 5186 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x06001443 RID: 5187 RVA: 0x0002D858 File Offset: 0x0002BA58
			internal WorkshopLite <OrderRecord>b__0(workshop r)
			{
				WorkshopLite workshopLite = new WorkshopLite();
				workshopLite.LockEmployee = this.<>4__this.GetEmployee(r.user_lock);
				workshopLite.VendorId = r.vendor_id;
				workshopLite.MasterEmployee = this.<>4__this.GetEmployee(r.master);
				workshopLite.CurrentManagerEmployee = this.<>4__this.GetEmployee(new int?(r.current_manager));
				workshopLite.ClientId = r.client;
				workshopLite.ClientType = r.clients.type;
				workshopLite.ClientUrName = (this.canViewClients ? r.clients.ur_name : "No permissions");
				workshopLite.ClientFirstName = (this.canViewClients ? r.clients.name : "No permissions");
				workshopLite.ClientLastName = (this.canViewClients ? r.clients.surname : "No permissions");
				workshopLite.ClientPatronymic = (this.canViewClients ? r.clients.patronymic : "No permissions");
				workshopLite.ClientPhone = (this.canViewClients ? CustomerConverter.GetFirstCustomerTel(r.clients) : "No permissions");
				workshopLite.ClientRepairs = r.clients.repairs;
				workshopLite.LockUserId = r.user_lock;
				workshopLite.LockTime = r.lock_datetime;
				workshopLite.RepairId = r.id;
				workshopLite.InformedStatus = r.informed_status;
				workshopLite.DeviceOverview = r.Title;
				workshopLite.SerialNumber = r.serial_number;
				workshopLite.Fault = r.fault;
				workshopLite.State = r.state;
				workshopLite.CurrentManager = r.current_manager;
				workshopLite.Manager = r.manager;
				workshopLite.Master = r.master;
				workshopLite.Office = r.office;
				workshopLite.InDate = r.in_date;
				workshopLite.OutDate = r.out_date;
				workshopLite.LastStatusChanged = r.last_status_changed;
				workshopLite.RepairCost = r.repair_cost;
				workshopLite.RealRepairCost = (this.csaew ? r.real_repair_cost : 0m);
				boxes boxes = r.boxes;
				string boxName;
				if (boxes != null)
				{
					if ((boxName = boxes.name) != null)
					{
						goto IL_220;
					}
				}
				boxName = "";
				IL_220:
				workshopLite.BoxName = boxName;
				workshopLite.Color = r.color;
				workshopLite.OrderMoving = r.order_moving;
				workshopLite.IsWarranty = r.is_warranty;
				workshopLite.IsExpress = r.express_repair;
				workshopLite.IsRegular = r.clients.is_regular;
				workshopLite.IsAgent = r.clients.is_agent;
				workshopLite.IsBad = r.clients.is_bad;
				workshopLite.IsQuery = !string.IsNullOrEmpty(this.query);
				workshopLite.UserFields = r.field_values;
				workshopLite.CartridgeId = r.cartridge;
				return workshopLite;
			}

			// Token: 0x040009C0 RID: 2496
			public WorkspaceModel <>4__this;

			// Token: 0x040009C1 RID: 2497
			public bool canViewClients;

			// Token: 0x040009C2 RID: 2498
			public bool csaew;

			// Token: 0x040009C3 RID: 2499
			public string query;
		}

		// Token: 0x02000118 RID: 280
		[CompilerGenerated]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x06001444 RID: 5188 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x040009C4 RID: 2500
			public string query;
		}

		// Token: 0x02000119 RID: 281
		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x06001445 RID: 5189 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x040009C5 RID: 2501
			public DateTime fromPeriod;
		}
	}
}
