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
using ASC.Common.Phone;
using ASC.Extensions;
using ASC.Extensions.Pinpad;
using ASC.Interfaces;
using ASC.Objects;
using ASC.Objects.Converters;
using ASC.PartsRequest;
using ASC.Services;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using Autofac;
using Newtonsoft.Json;
using NLog;

namespace ASC.Models
{
	// Token: 0x02000A16 RID: 2582
	public class RepairModel : PartsRequestModel, IRepairModel
	{
		// Token: 0x06004C50 RID: 19536 RVA: 0x00139B38 File Offset: 0x00137D38
		public RepairModel()
		{
			this._logger = Bootstrapper.Container.Resolve<ILoggerService<RepairModel>>();
		}

		// Token: 0x06004C51 RID: 19537 RVA: 0x00139B5C File Offset: 0x00137D5C
		public static workshop DefaultRepair()
		{
			Localization localization = new Localization("UTC");
			return new workshop
			{
				start_office = OfflineData.Instance.Employee.OfficeId,
				office = OfflineData.Instance.Employee.OfficeId,
				manager = OfflineData.Instance.Employee.Id,
				current_manager = OfflineData.Instance.Employee.Id,
				type = 0,
				state = 0,
				model = new int?(0),
				is_repeat = false,
				is_warranty = false,
				express_repair = new bool?(false),
				can_format = false,
				thirs_party_sc = false,
				print_check = Auth.Config.print_check,
				payment_system = 0,
				prepaid_summ = 0m,
				repair_cost = 0m,
				pre_agreed_amount = new decimal?(0m),
				is_prepaid = false,
				is_pre_agreed = false,
				in_date = localization.Now,
				last_save = new DateTime?(localization.Now),
				last_status_changed = new DateTime?(localization.Now),
				warranty_days = Auth.Config.default_works_warranty,
				barcode = string.Empty,
				reject_reason = string.Empty,
				is_debt = false,
				sms_inform = true,
				fault = "",
				termsControl = true,
				Title = ""
			};
		}

		// Token: 0x06004C52 RID: 19538 RVA: 0x00139CE0 File Offset: 0x00137EE0
		public void TaskTrigger(workshop repair)
		{
			try
			{
				string modelName = repair.ModelName.ToLower().Trim();
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					Func<string, bool> <>9__3;
					List<tasks> list = (from t in auseceEntities.tasks.Include((tasks t) => t.task_employees)
					where t.state == 0 && t.type == 5 && t.m_device == (int?)repair.type && t.m_maker == (int?)repair.maker
					select t).AsEnumerable<tasks>().Where(delegate(tasks t)
					{
						IEnumerable<string> source = t.m_match.Split(new char[]
						{
							' '
						});
						Func<string, bool> predicate;
						if ((predicate = <>9__3) == null)
						{
							predicate = (<>9__3 = ((string z) => modelName.Contains(z.ToLower().Trim())));
						}
						return source.Any(predicate) || t.m_match.ToLower().Trim().Contains(modelName);
					}).ToList<tasks>();
					if (list.Any<tasks>())
					{
						foreach (tasks tasks in list)
						{
							tasks.state = 1;
							tasks.repair_id = new int?(repair.id);
							if (OfflineData.Instance.Settings.InformTaskMatch)
							{
								foreach (task_employees task_employees in tasks.task_employees)
								{
									AscNotification ascNotification = new AscNotification();
									ascNotification.SetEmployee(task_employees.employee);
									ascNotification.TaskDeviceMatch(tasks.idt, tasks.text);
									auseceEntities.notifications.Add(ascNotification.BackToNotification());
								}
							}
						}
						auseceEntities.SaveChanges();
					}
				}
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Task trigger fail");
			}
		}

		// Token: 0x06004C53 RID: 19539 RVA: 0x0013A044 File Offset: 0x00138244
		public string SerializeImageIds(List<int> ids)
		{
			if (ids != null && ids.Count > 0)
			{
				string result;
				try
				{
					result = JsonConvert.SerializeObject(ids);
				}
				catch (Exception value)
				{
					GenericModel.Log.Error<Exception>(value);
					result = "";
				}
				return result;
			}
			return "";
		}

		// Token: 0x06004C54 RID: 19540 RVA: 0x0013A094 File Offset: 0x00138294
		public Task FinishQuickRepair(workshop repair, IEnumerable<WorkPartObject> wpObjects, decimal totalSumm)
		{
			RepairModel.<FinishQuickRepair>d__5 <FinishQuickRepair>d__;
			<FinishQuickRepair>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<FinishQuickRepair>d__.<>4__this = this;
			<FinishQuickRepair>d__.repair = repair;
			<FinishQuickRepair>d__.wpObjects = wpObjects;
			<FinishQuickRepair>d__.totalSumm = totalSumm;
			<FinishQuickRepair>d__.<>1__state = -1;
			<FinishQuickRepair>d__.<>t__builder.Start<RepairModel.<FinishQuickRepair>d__5>(ref <FinishQuickRepair>d__);
			return <FinishQuickRepair>d__.<>t__builder.Task;
		}

		// Token: 0x06004C55 RID: 19541 RVA: 0x0013A0F0 File Offset: 0x001382F0
		private workshop_issued CreateWorkshopIssueRecord(int repairId, DateTime date)
		{
			return new workshop_issued
			{
				repair_id = repairId,
				employee_id = OfflineData.Instance.Employee.Id,
				created_at = date
			};
		}

		// Token: 0x06004C56 RID: 19542 RVA: 0x0013A128 File Offset: 0x00138328
		private Task CreateOrUpdateReserve(List<WorkPartObject> items, workshop repair)
		{
			RepairModel.<CreateOrUpdateReserve>d__7 <CreateOrUpdateReserve>d__;
			<CreateOrUpdateReserve>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<CreateOrUpdateReserve>d__.<>4__this = this;
			<CreateOrUpdateReserve>d__.items = items;
			<CreateOrUpdateReserve>d__.repair = repair;
			<CreateOrUpdateReserve>d__.<>1__state = -1;
			<CreateOrUpdateReserve>d__.<>t__builder.Start<RepairModel.<CreateOrUpdateReserve>d__7>(ref <CreateOrUpdateReserve>d__);
			return <CreateOrUpdateReserve>d__.<>t__builder.Task;
		}

		// Token: 0x06004C57 RID: 19543 RVA: 0x0013A17C File Offset: 0x0013837C
		public static Task<decimal> GetRepairCostTotal(int repairId)
		{
			RepairModel.<GetRepairCostTotal>d__8 <GetRepairCostTotal>d__;
			<GetRepairCostTotal>d__.<>t__builder = AsyncTaskMethodBuilder<decimal>.Create();
			<GetRepairCostTotal>d__.repairId = repairId;
			<GetRepairCostTotal>d__.<>1__state = -1;
			<GetRepairCostTotal>d__.<>t__builder.Start<RepairModel.<GetRepairCostTotal>d__8>(ref <GetRepairCostTotal>d__);
			return <GetRepairCostTotal>d__.<>t__builder.Task;
		}

		// Token: 0x06004C58 RID: 19544 RVA: 0x0013A1C0 File Offset: 0x001383C0
		public static Task<decimal> GetAlreadyPayedSumm(int repairId)
		{
			RepairModel.<GetAlreadyPayedSumm>d__9 <GetAlreadyPayedSumm>d__;
			<GetAlreadyPayedSumm>d__.<>t__builder = AsyncTaskMethodBuilder<decimal>.Create();
			<GetAlreadyPayedSumm>d__.repairId = repairId;
			<GetAlreadyPayedSumm>d__.<>1__state = -1;
			<GetAlreadyPayedSumm>d__.<>t__builder.Start<RepairModel.<GetAlreadyPayedSumm>d__9>(ref <GetAlreadyPayedSumm>d__);
			return <GetAlreadyPayedSumm>d__.<>t__builder.Task;
		}

		// Token: 0x06004C59 RID: 19545 RVA: 0x0013A204 File Offset: 0x00138404
		public static Task<decimal> GetRepairFinalAmount(int repairId)
		{
			RepairModel.<GetRepairFinalAmount>d__10 <GetRepairFinalAmount>d__;
			<GetRepairFinalAmount>d__.<>t__builder = AsyncTaskMethodBuilder<decimal>.Create();
			<GetRepairFinalAmount>d__.repairId = repairId;
			<GetRepairFinalAmount>d__.<>1__state = -1;
			<GetRepairFinalAmount>d__.<>t__builder.Start<RepairModel.<GetRepairFinalAmount>d__10>(ref <GetRepairFinalAmount>d__);
			return <GetRepairFinalAmount>d__.<>t__builder.Task;
		}

		// Token: 0x06004C5A RID: 19546 RVA: 0x0013A248 File Offset: 0x00138448
		public static Task<List<works>> LoadWorks(int repairId)
		{
			RepairModel.<LoadWorks>d__11 <LoadWorks>d__;
			<LoadWorks>d__.<>t__builder = AsyncTaskMethodBuilder<List<works>>.Create();
			<LoadWorks>d__.repairId = repairId;
			<LoadWorks>d__.<>1__state = -1;
			<LoadWorks>d__.<>t__builder.Start<RepairModel.<LoadWorks>d__11>(ref <LoadWorks>d__);
			return <LoadWorks>d__.<>t__builder.Task;
		}

		// Token: 0x06004C5B RID: 19547 RVA: 0x0013A28C File Offset: 0x0013848C
		public static Task<List<WorkPartObject>> LoadWorkParts(int repairId)
		{
			RepairModel.<LoadWorkParts>d__12 <LoadWorkParts>d__;
			<LoadWorkParts>d__.<>t__builder = AsyncTaskMethodBuilder<List<WorkPartObject>>.Create();
			<LoadWorkParts>d__.repairId = repairId;
			<LoadWorkParts>d__.<>1__state = -1;
			<LoadWorkParts>d__.<>t__builder.Start<RepairModel.<LoadWorkParts>d__12>(ref <LoadWorkParts>d__);
			return <LoadWorkParts>d__.<>t__builder.Task;
		}

		// Token: 0x06004C5C RID: 19548 RVA: 0x0013A2D0 File Offset: 0x001384D0
		public static Task<List<WorkPartObject>> LoadWorkParts(int repairId, int employeeId)
		{
			RepairModel.<LoadWorkParts>d__13 <LoadWorkParts>d__;
			<LoadWorkParts>d__.<>t__builder = AsyncTaskMethodBuilder<List<WorkPartObject>>.Create();
			<LoadWorkParts>d__.repairId = repairId;
			<LoadWorkParts>d__.employeeId = employeeId;
			<LoadWorkParts>d__.<>1__state = -1;
			<LoadWorkParts>d__.<>t__builder.Start<RepairModel.<LoadWorkParts>d__13>(ref <LoadWorkParts>d__);
			return <LoadWorkParts>d__.<>t__builder.Task;
		}

		// Token: 0x06004C5D RID: 19549 RVA: 0x0013A31C File Offset: 0x0013851C
		public static List<WorkPartObject> WorksAndPartsConvert(List<works> works, List<store_int_reserve> parts, int employeeId = 0)
		{
			List<WorkPartObject> list = new List<WorkPartObject>();
			if (works != null && works.Any<works>())
			{
				List<WorkPartObject> collection = (employeeId == 0) ? works.Select(RepairModel.WorksConvert()).ToList<WorkPartObject>() : (from w in works
				where w.user == employeeId
				select w).Select(RepairModel.WorksConvert()).ToList<WorkPartObject>();
				list.AddRange(collection);
			}
			if (parts != null)
			{
				if (parts.Any((store_int_reserve p) => p.state > 1))
				{
					List<WorkPartObject> list2;
					if (employeeId != 0)
					{
						list2 = (from p in parts
						where p.state > 1 && p.to_user == employeeId
						select p).Select(RepairModel.PartsConvert()).ToList<WorkPartObject>();
					}
					else
					{
						list2 = (from p in parts
						where p.state > 1
						select p).Select(RepairModel.PartsConvert()).ToList<WorkPartObject>();
					}
					List<WorkPartObject> collection2 = list2;
					list.AddRange(collection2);
				}
			}
			return list;
		}

		// Token: 0x06004C5E RID: 19550 RVA: 0x0013A420 File Offset: 0x00138620
		private static Func<store_int_reserve, WorkPartObject> PartsConvert()
		{
			return (store_int_reserve p) => new WorkPartObject
			{
				Id = -p.id,
				Type = 2,
				EmployeeId = p.to_user,
				Name = p.name,
				Price = p.price,
				Count = p.count,
				Warranty = p.warranty,
				WorkId = p.work_id,
				ItemId = new int?(p.item_id),
				RepairId = p.repair_id.GetValueOrDefault()
			};
		}

		// Token: 0x06004C5F RID: 19551 RVA: 0x0013A44C File Offset: 0x0013864C
		private static Func<works, WorkPartObject> WorksConvert()
		{
			return (works w) => new WorkPartObject
			{
				Id = w.id,
				Type = 1,
				EmployeeId = w.user,
				Name = w.name,
				Price = w.price,
				Count = (int)w.count,
				Warranty = w.warranty,
				MasterPercent = w.users.pay_repair,
				RepairId = w.repair.GetValueOrDefault(),
				Repairman = w.users.User2EmployeeLite()
			};
		}

		// Token: 0x06004C60 RID: 19552 RVA: 0x0013A478 File Offset: 0x00138678
		public static Task<decimal> TotalPartsCost(int repairId)
		{
			RepairModel.<TotalPartsCost>d__17 <TotalPartsCost>d__;
			<TotalPartsCost>d__.<>t__builder = AsyncTaskMethodBuilder<decimal>.Create();
			<TotalPartsCost>d__.repairId = repairId;
			<TotalPartsCost>d__.<>1__state = -1;
			<TotalPartsCost>d__.<>t__builder.Start<RepairModel.<TotalPartsCost>d__17>(ref <TotalPartsCost>d__);
			return <TotalPartsCost>d__.<>t__builder.Task;
		}

		// Token: 0x06004C61 RID: 19553 RVA: 0x0013A4BC File Offset: 0x001386BC
		private static Task<decimal> TotalPartsCost(int repairId, auseceEntities ctx)
		{
			return (from p in ctx.store_int_reserve
			where p.repair_id == (int?)repairId && (p.state == 2 || p.state == 3)
			select (decimal)p.count * p.price).DefaultIfEmpty<decimal>().SumAsync();
		}

		// Token: 0x06004C62 RID: 19554 RVA: 0x0013A638 File Offset: 0x00138838
		public static Task<decimal> TotalWorksCost(int repairId)
		{
			RepairModel.<TotalWorksCost>d__19 <TotalWorksCost>d__;
			<TotalWorksCost>d__.<>t__builder = AsyncTaskMethodBuilder<decimal>.Create();
			<TotalWorksCost>d__.repairId = repairId;
			<TotalWorksCost>d__.<>1__state = -1;
			<TotalWorksCost>d__.<>t__builder.Start<RepairModel.<TotalWorksCost>d__19>(ref <TotalWorksCost>d__);
			return <TotalWorksCost>d__.<>t__builder.Task;
		}

		// Token: 0x06004C63 RID: 19555 RVA: 0x0013A67C File Offset: 0x0013887C
		[Obsolete("use WorkshopService.TotalWorksCost(...)")]
		public static Task<decimal> TotalWorksCost(int repairId, auseceEntities ctx)
		{
			return (from w in ctx.works
			where w.repair == (int?)repairId
			select w.price * (decimal)w.count).DefaultIfEmpty<decimal>().SumAsync();
		}

		// Token: 0x06004C64 RID: 19556 RVA: 0x0013A790 File Offset: 0x00138990
		public static Task<List<store_int_reserve>> LoadParts(int repairId)
		{
			RepairModel.<LoadParts>d__21 <LoadParts>d__;
			<LoadParts>d__.<>t__builder = AsyncTaskMethodBuilder<List<store_int_reserve>>.Create();
			<LoadParts>d__.repairId = repairId;
			<LoadParts>d__.<>1__state = -1;
			<LoadParts>d__.<>t__builder.Start<RepairModel.<LoadParts>d__21>(ref <LoadParts>d__);
			return <LoadParts>d__.<>t__builder.Task;
		}

		// Token: 0x06004C65 RID: 19557 RVA: 0x0013A7D4 File Offset: 0x001389D4
		public Task<IAscResult> MakeRepairOut(workshop repair, bool debtOut, decimal finalAmount, bool payFromBalance, string customerEmail)
		{
			RepairModel.<MakeRepairOut>d__22 <MakeRepairOut>d__;
			<MakeRepairOut>d__.<>t__builder = AsyncTaskMethodBuilder<IAscResult>.Create();
			<MakeRepairOut>d__.<>4__this = this;
			<MakeRepairOut>d__.repair = repair;
			<MakeRepairOut>d__.debtOut = debtOut;
			<MakeRepairOut>d__.finalAmount = finalAmount;
			<MakeRepairOut>d__.payFromBalance = payFromBalance;
			<MakeRepairOut>d__.customerEmail = customerEmail;
			<MakeRepairOut>d__.<>1__state = -1;
			<MakeRepairOut>d__.<>t__builder.Start<RepairModel.<MakeRepairOut>d__22>(ref <MakeRepairOut>d__);
			return <MakeRepairOut>d__.<>t__builder.Task;
		}

		// Token: 0x06004C66 RID: 19558 RVA: 0x0013A844 File Offset: 0x00138A44
		public bool RepairDebtOut(workshop repair, decimal summ)
		{
			bool result;
			try
			{
				HistoryV2 historyV = new HistoryV2();
				Localization localization = new Localization("UTC");
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					workshop workshop = auseceEntities.workshop.Find(new object[]
					{
						repair.id
					});
					historyV.AddClientLog("RepairDebtOut", repair.client, summ, repair.id);
					historyV.StateChangeLog(repair);
					workshop.company = repair.company;
					workshop.state = repair.new_state;
					workshop.reject_reason = repair.reject_reason;
					workshop.out_date = new DateTime?(localization.Now);
					if (workshop.box != null)
					{
						string prm = (workshop.boxes == null) ? "" : workshop.boxes.name;
						historyV.AddRepairLog("removedFromBox", repair.id, prm, "");
						workshop.box = null;
					}
					workshop.is_debt = true;
					auseceEntities.SaveChanges();
					KassaModel.SubstractCustomerBalance(repair.client, -summ, Kassa.Balance.RepairDebtOpen, new int?(repair.id), 0);
					historyV.Save();
					result = true;
				}
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Repair debt out error");
				result = false;
			}
			return result;
		}

		// Token: 0x06004C67 RID: 19559 RVA: 0x0013A9C4 File Offset: 0x00138BC4
		public static bool OrderExist(int repairId)
		{
			bool result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					result = (auseceEntities.cash_orders.Count((cash_orders o) => o.repair == (int?)repairId && o.payment_system == 1) > 0);
				}
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Order exist check error");
				result = false;
			}
			return result;
		}

		// Token: 0x06004C68 RID: 19560 RVA: 0x0013AAD4 File Offset: 0x00138CD4
		public void SubstractItems(IEnumerable<store_int_reserve> reserves, int repairId, int customerId)
		{
			HistoryV2 historyV = new HistoryV2();
			foreach (store_int_reserve store_int_reserve in reserves)
			{
				if (base.SoldItemRepairOut(store_int_reserve))
				{
					historyV.AddRepairItemLog("ItemSoldInRepair", store_int_reserve.item_id, repairId, customerId);
				}
			}
			historyV.Save();
		}

		// Token: 0x06004C69 RID: 19561 RVA: 0x0013AB40 File Offset: 0x00138D40
		public devices LoadDevice(int deviceId)
		{
			devices firstOrDefault;
			using (GenericRepository<devices> genericRepository = new GenericRepository<devices>())
			{
				firstOrDefault = genericRepository.GetFirstOrDefault((devices d) => d.id == deviceId, "");
			}
			return firstOrDefault;
		}

		// Token: 0x06004C6A RID: 19562 RVA: 0x0013ABE8 File Offset: 0x00138DE8
		public bool DeviceExist(string deviceName)
		{
			bool result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					result = (auseceEntities.devices.FirstOrDefault((devices d) => d.name == deviceName.Trim() && d.enable != (bool?)false) != null);
				}
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Device exist check fail");
				result = false;
			}
			return result;
		}

		// Token: 0x06004C6B RID: 19563 RVA: 0x0013AD14 File Offset: 0x00138F14
		public device_makers LoaMakerByName(string makerName)
		{
			device_makers firstOrDefault;
			using (GenericRepository<device_makers> genericRepository = new GenericRepository<device_makers>())
			{
				firstOrDefault = genericRepository.GetFirstOrDefault((device_makers m) => m.name == makerName.Trim(), "");
			}
			return firstOrDefault;
		}

		// Token: 0x06004C6C RID: 19564 RVA: 0x0013ADD4 File Offset: 0x00138FD4
		public bool MakerExist(string makerName, int deviceId)
		{
			device_makers device_makers = this.LoaMakerByName(makerName);
			if (device_makers != null)
			{
				bool result;
				try
				{
					devices devices = this.LoadDevice(deviceId);
					if (!string.IsNullOrEmpty((devices == null) ? null : devices.company_list))
					{
						result = WorkshopService.ExtractMakerIds(devices.company_list).Contains(device_makers.id);
					}
					else
					{
						result = false;
					}
				}
				catch (Exception exception)
				{
					GenericModel.Log.Error(exception, "Maker exist check fail");
					result = false;
				}
				return result;
			}
			return false;
		}

		// Token: 0x06004C6D RID: 19565 RVA: 0x0013AE50 File Offset: 0x00139050
		public void UpdateDeviceMakerName(int makerId, string name)
		{
			RepairModel.<UpdateDeviceMakerName>d__30 <UpdateDeviceMakerName>d__;
			<UpdateDeviceMakerName>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<UpdateDeviceMakerName>d__.makerId = makerId;
			<UpdateDeviceMakerName>d__.name = name;
			<UpdateDeviceMakerName>d__.<>1__state = -1;
			<UpdateDeviceMakerName>d__.<>t__builder.Start<RepairModel.<UpdateDeviceMakerName>d__30>(ref <UpdateDeviceMakerName>d__);
		}

		// Token: 0x06004C6E RID: 19566 RVA: 0x0013AE90 File Offset: 0x00139090
		public void UpdateCompanyList(IDevice device)
		{
			using (auseceEntities auseceEntities = new auseceEntities(true))
			{
				devices devices = new devices
				{
					id = device.Id
				};
				auseceEntities.devices.Attach(devices);
				devices.company_list = device.CompanyList;
				auseceEntities.SaveChanges();
			}
		}

		// Token: 0x06004C6F RID: 19567 RVA: 0x0013AEF4 File Offset: 0x001390F4
		public Task<List<IdNameClass>> GetModels(int makerId, int deviceType)
		{
			RepairModel.<GetModels>d__32 <GetModels>d__;
			<GetModels>d__.<>t__builder = AsyncTaskMethodBuilder<List<IdNameClass>>.Create();
			<GetModels>d__.<>4__this = this;
			<GetModels>d__.makerId = makerId;
			<GetModels>d__.deviceType = deviceType;
			<GetModels>d__.<>1__state = -1;
			<GetModels>d__.<>t__builder.Start<RepairModel.<GetModels>d__32>(ref <GetModels>d__);
			return <GetModels>d__.<>t__builder.Task;
		}

		// Token: 0x06004C70 RID: 19568 RVA: 0x0013AF48 File Offset: 0x00139148
		public Task<List<device_models>> LoadModels(int makerId, int deviceType)
		{
			RepairModel.<LoadModels>d__33 <LoadModels>d__;
			<LoadModels>d__.<>t__builder = AsyncTaskMethodBuilder<List<device_models>>.Create();
			<LoadModels>d__.makerId = makerId;
			<LoadModels>d__.deviceType = deviceType;
			<LoadModels>d__.<>1__state = -1;
			<LoadModels>d__.<>t__builder.Start<RepairModel.<LoadModels>d__33>(ref <LoadModels>d__);
			return <LoadModels>d__.<>t__builder.Task;
		}

		// Token: 0x06004C71 RID: 19569 RVA: 0x0013AF94 File Offset: 0x00139194
		public int CreateDeviceModel(workshop repair, bool detachRepair = false)
		{
			repair.ModelName = repair.ModelName.Trim();
			int num = this.SearchDuplicate(repair.type, repair.maker, repair.ModelName);
			if (num != 0)
			{
				return num;
			}
			return this.NewDeviceModel(repair);
		}

		// Token: 0x06004C72 RID: 19570 RVA: 0x0013AFD8 File Offset: 0x001391D8
		private int NewDeviceModel(workshop repair)
		{
			int result;
			using (auseceEntities auseceEntities = new auseceEntities(true))
			{
				try
				{
					device_models device_models = new device_models
					{
						name = repair.ModelName,
						device = new int?(repair.type),
						maker = repair.maker
					};
					auseceEntities.device_models.Add(device_models);
					auseceEntities.SaveChanges();
					result = device_models.id;
				}
				catch (Exception exception)
				{
					GenericModel.Log.Error(exception, "Create new device model error");
					result = 0;
				}
			}
			return result;
		}

		// Token: 0x06004C73 RID: 19571 RVA: 0x0013B074 File Offset: 0x00139274
		private int SearchDuplicate(int type, int deviceMaker, string modelName)
		{
			int result;
			using (GenericRepository<device_models> genericRepository = new GenericRepository<device_models>())
			{
				device_models firstOrDefault = genericRepository.GetFirstOrDefault((device_models m) => m.device == (int?)type && m.maker == deviceMaker && m.name == modelName, "");
				result = ((firstOrDefault == null) ? 0 : firstOrDefault.id);
			}
			return result;
		}

		// Token: 0x06004C74 RID: 19572 RVA: 0x0013B1D0 File Offset: 0x001393D0
		public string[] SplitString(string commaSeparatedString)
		{
			if (!string.IsNullOrEmpty(commaSeparatedString))
			{
				return commaSeparatedString.Split(new char[]
				{
					','
				});
			}
			return new string[0];
		}

		// Token: 0x06004C75 RID: 19573 RVA: 0x0013B200 File Offset: 0x00139400
		public Task<List<ClientAndDevices>> SearchDeviceMatch(workshop repair)
		{
			RepairModel.<SearchDeviceMatch>d__38 <SearchDeviceMatch>d__;
			<SearchDeviceMatch>d__.<>t__builder = AsyncTaskMethodBuilder<List<ASC.SimpleClasses.ClientAndDevices>>.Create();
			<SearchDeviceMatch>d__.repair = repair;
			<SearchDeviceMatch>d__.<>1__state = -1;
			<SearchDeviceMatch>d__.<>t__builder.Start<RepairModel.<SearchDeviceMatch>d__38>(ref <SearchDeviceMatch>d__);
			return <SearchDeviceMatch>d__.<>t__builder.Task;
		}

		// Token: 0x06004C76 RID: 19574 RVA: 0x0013B244 File Offset: 0x00139444
		private static Expression<Func<workshop, ClientAndDevices>> ClientAndDevices()
		{
			ParameterExpression parameterExpression;
			return Expression.Lambda<Func<workshop, ClientAndDevices>>(Expression.MemberInit(Expression.New(typeof(ClientAndDevices)), new MemberBinding[]
			{
				Expression.Bind(methodof(ASC.SimpleClasses.ClientAndDevices.set_Id(int)), Expression.Property(parameterExpression, methodof(workshop.get_id()))),
				Expression.Bind(methodof(ASC.SimpleClasses.ClientAndDevices.set_DeviceMaker(string)), Expression.Property(Expression.Property(parameterExpression, methodof(workshop.get_device_makers())), methodof(device_makers.get_name()))),
				Expression.Bind(methodof(ASC.SimpleClasses.ClientAndDevices.set_DeviceModel(string)), Expression.Property(Expression.Property(parameterExpression, methodof(workshop.get_device_models())), methodof(device_models.get_name()))),
				Expression.Bind(methodof(ASC.SimpleClasses.ClientAndDevices.set_SerialNumber(string)), Expression.Property(parameterExpression, methodof(workshop.get_serial_number()))),
				Expression.Bind(methodof(ASC.SimpleClasses.ClientAndDevices.set_Fault(string)), Expression.Property(parameterExpression, methodof(workshop.get_fault()))),
				Expression.Bind(methodof(ASC.SimpleClasses.ClientAndDevices.set_ClientSurname(string)), Expression.Property(Expression.Property(parameterExpression, methodof(workshop.get_clients())), methodof(clients.get_surname()))),
				Expression.Bind(methodof(ASC.SimpleClasses.ClientAndDevices.set_ClientName(string)), Expression.Property(Expression.Property(parameterExpression, methodof(workshop.get_clients())), methodof(clients.get_name()))),
				Expression.Bind(methodof(ASC.SimpleClasses.ClientAndDevices.set_ClientPatronymic(string)), Expression.Property(Expression.Property(parameterExpression, methodof(workshop.get_clients())), methodof(clients.get_patronymic()))),
				Expression.Bind(methodof(ASC.SimpleClasses.ClientAndDevices.set_ClientId(int)), Expression.Property(Expression.Property(parameterExpression, methodof(workshop.get_clients())), methodof(clients.get_id()))),
				Expression.Bind(methodof(ASC.SimpleClasses.ClientAndDevices.set_TypeId(int)), Expression.Property(Expression.Property(parameterExpression, methodof(workshop.get_devices())), methodof(devices.get_id()))),
				Expression.Bind(methodof(ASC.SimpleClasses.ClientAndDevices.set_MakerId(int)), Expression.Property(Expression.Property(parameterExpression, methodof(workshop.get_device_makers())), methodof(device_makers.get_id()))),
				Expression.Bind(methodof(ASC.SimpleClasses.ClientAndDevices.set_ModelId(int)), Expression.Property(Expression.Property(parameterExpression, methodof(workshop.get_device_models())), methodof(device_models.get_id())))
			}), new ParameterExpression[]
			{
				parameterExpression
			});
		}

		// Token: 0x06004C77 RID: 19575 RVA: 0x0013B558 File Offset: 0x00139758
		public bool IsRepairOk(int state)
		{
			return state == 6;
		}

		// Token: 0x06004C78 RID: 19576 RVA: 0x0013B56C File Offset: 0x0013976C
		public static Task<IEnumerable<logs>> GetRepairLogs(int repairId)
		{
			RepairModel.<GetRepairLogs>d__41 <GetRepairLogs>d__;
			<GetRepairLogs>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<logs>>.Create();
			<GetRepairLogs>d__.repairId = repairId;
			<GetRepairLogs>d__.<>1__state = -1;
			<GetRepairLogs>d__.<>t__builder.Start<RepairModel.<GetRepairLogs>d__41>(ref <GetRepairLogs>d__);
			return <GetRepairLogs>d__.<>t__builder.Task;
		}

		// Token: 0x06004C79 RID: 19577 RVA: 0x0013B5B0 File Offset: 0x001397B0
		public Task RestoreIntReserve(int repairId)
		{
			RepairModel.<RestoreIntReserve>d__42 <RestoreIntReserve>d__;
			<RestoreIntReserve>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<RestoreIntReserve>d__.<>4__this = this;
			<RestoreIntReserve>d__.repairId = repairId;
			<RestoreIntReserve>d__.<>1__state = -1;
			<RestoreIntReserve>d__.<>t__builder.Start<RepairModel.<RestoreIntReserve>d__42>(ref <RestoreIntReserve>d__);
			return <RestoreIntReserve>d__.<>t__builder.Task;
		}

		// Token: 0x06004C7A RID: 19578 RVA: 0x0013B5FC File Offset: 0x001397FC
		public string CheckDiagFields(workshop repair)
		{
			if (string.IsNullOrEmpty(repair.diagnostic_result) && Auth.Config.diag_required)
			{
				return Lang.t("InputDiagnosticResult");
			}
			if (repair.repair_cost == 0m && !repair.is_warranty && !repair.is_repeat && !Auth.Config.rep_price_by_manager)
			{
				return Lang.t("RepairCostError");
			}
			return "";
		}

		// Token: 0x06004C7B RID: 19579 RVA: 0x0013B66C File Offset: 0x0013986C
		public static Task<List<ClientAndDevices>> SearchClientMatchV2(clients client)
		{
			RepairModel.<SearchClientMatchV2>d__44 <SearchClientMatchV2>d__;
			<SearchClientMatchV2>d__.<>t__builder = AsyncTaskMethodBuilder<List<ASC.SimpleClasses.ClientAndDevices>>.Create();
			<SearchClientMatchV2>d__.client = client;
			<SearchClientMatchV2>d__.<>1__state = -1;
			<SearchClientMatchV2>d__.<>t__builder.Start<RepairModel.<SearchClientMatchV2>d__44>(ref <SearchClientMatchV2>d__);
			return <SearchClientMatchV2>d__.<>t__builder.Task;
		}

		// Token: 0x06004C7C RID: 19580 RVA: 0x0013B6B0 File Offset: 0x001398B0
		private static string ClientPhone(clients c)
		{
			tel tel = c.tel.FirstOrDefault((tel p) => p.type == 1);
			if (tel != null)
			{
				return tel.phone;
			}
			return "";
		}

		// Token: 0x06004C7D RID: 19581 RVA: 0x0013B6F8 File Offset: 0x001398F8
		public Task ReloadFieldValues(workshop repair)
		{
			RepairModel.<ReloadFieldValues>d__46 <ReloadFieldValues>d__;
			<ReloadFieldValues>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ReloadFieldValues>d__.repair = repair;
			<ReloadFieldValues>d__.<>1__state = -1;
			<ReloadFieldValues>d__.<>t__builder.Start<RepairModel.<ReloadFieldValues>d__46>(ref <ReloadFieldValues>d__);
			return <ReloadFieldValues>d__.<>t__builder.Task;
		}

		// Token: 0x06004C7E RID: 19582 RVA: 0x0013B73C File Offset: 0x0013993C
		public static void SetRealRepairCost(int repairId, decimal cost)
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					auseceEntities.workshop.Find(new object[]
					{
						repairId
					}).real_repair_cost = cost;
					auseceEntities.SaveChanges();
				}
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Set real repair cost fail");
			}
		}

		// Token: 0x06004C7F RID: 19583 RVA: 0x0013B7B4 File Offset: 0x001399B4
		public int CreateNewMaker(int deviceId, string name)
		{
			int id;
			using (auseceEntities auseceEntities = new auseceEntities(true))
			{
				device_makers device_makers = new device_makers
				{
					name = name
				};
				auseceEntities.device_makers.Add(device_makers);
				auseceEntities.SaveChanges();
				this.AddMakerToDevice(deviceId, device_makers.id);
				id = device_makers.id;
			}
			return id;
		}

		// Token: 0x06004C80 RID: 19584 RVA: 0x0013B81C File Offset: 0x00139A1C
		public void AddMakerToDevice(int deviceId, int makerId)
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					devices devices = auseceEntities.devices.FirstOrDefault((devices d) => d.id == deviceId);
					if (devices == null)
					{
						GenericModel.Log.Error("Add maker to device fail, device not exist");
					}
					else
					{
						if (string.IsNullOrEmpty(devices.company_list))
						{
							devices.company_list = makerId.ToString();
						}
						else
						{
							List<string> list = devices.company_list.Split(new char[]
							{
								','
							}).ToList<string>();
							list.Add(makerId.ToString());
							devices.company_list = string.Join(",", list.Distinct<string>());
						}
						auseceEntities.SaveChanges();
					}
				}
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Add maker to device fail");
			}
		}

		// Token: 0x06004C81 RID: 19585 RVA: 0x0013B964 File Offset: 0x00139B64
		public static Task<IEnumerable<cash_orders>> GetRepairCashOrders(int repairId)
		{
			RepairModel.<GetRepairCashOrders>d__50 <GetRepairCashOrders>d__;
			<GetRepairCashOrders>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<cash_orders>>.Create();
			<GetRepairCashOrders>d__.repairId = repairId;
			<GetRepairCashOrders>d__.<>1__state = -1;
			<GetRepairCashOrders>d__.<>t__builder.Start<RepairModel.<GetRepairCashOrders>d__50>(ref <GetRepairCashOrders>d__);
			return <GetRepairCashOrders>d__.<>t__builder.Task;
		}

		// Token: 0x06004C82 RID: 19586 RVA: 0x0013B9A8 File Offset: 0x00139BA8
		public static bool PrepaidRefund(workshop repair, decimal amount)
		{
			bool result;
			try
			{
				KassaModel kassaModel = new KassaModel();
				kassaModel.NewCashOrder(8, repair.client, Math.Abs(amount), new int?(repair.id));
				kassaModel.MakeRko();
				result = true;
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Make repair prepaid refund");
				result = false;
			}
			return result;
		}

		// Token: 0x06004C83 RID: 19587 RVA: 0x0013BA08 File Offset: 0x00139C08
		public Task AdminSaveCard(workshop repair)
		{
			RepairModel.<AdminSaveCard>d__52 <AdminSaveCard>d__;
			<AdminSaveCard>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<AdminSaveCard>d__.<>4__this = this;
			<AdminSaveCard>d__.repair = repair;
			<AdminSaveCard>d__.<>1__state = -1;
			<AdminSaveCard>d__.<>t__builder.Start<RepairModel.<AdminSaveCard>d__52>(ref <AdminSaveCard>d__);
			return <AdminSaveCard>d__.<>t__builder.Task;
		}

		// Token: 0x06004C84 RID: 19588 RVA: 0x0013BA54 File Offset: 0x00139C54
		public Task AdminSaveCard(workshop repair, int cardId)
		{
			RepairModel.<AdminSaveCard>d__53 <AdminSaveCard>d__;
			<AdminSaveCard>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<AdminSaveCard>d__.repair = repair;
			<AdminSaveCard>d__.cardId = cardId;
			<AdminSaveCard>d__.<>1__state = -1;
			<AdminSaveCard>d__.<>t__builder.Start<RepairModel.<AdminSaveCard>d__53>(ref <AdminSaveCard>d__);
			return <AdminSaveCard>d__.<>t__builder.Task;
		}

		// Token: 0x06004C85 RID: 19589 RVA: 0x0013BAA0 File Offset: 0x00139CA0
		public Dictionary<int, string> GetRejectReasons()
		{
			return new Dictionary<int, string>
			{
				{
					1,
					Lang.t("ClientRefused2Repair")
				},
				{
					2,
					Lang.t("RepairNotPossible")
				},
				{
					3,
					Lang.t("RepairNotPossible2")
				},
				{
					4,
					Lang.t("RepairNotPossible3")
				},
				{
					5,
					Lang.t("RepairNotPossible5")
				},
				{
					-1,
					Lang.t("RepairNotPossible4")
				}
			};
		}

		// Token: 0x06004C86 RID: 19590 RVA: 0x0013BB18 File Offset: 0x00139D18
		public List<IPrepaidType> GetPrePaidTypes()
		{
			return new List<IPrepaidType>
			{
				new PrepaidType(1, Lang.t("FullPrepaid")),
				new PrepaidType(2, Lang.t("PartsPrepaid")),
				new PrepaidType(3, Lang.t("PartsPartPrepaid")),
				new PrepaidType(4, Lang.t("WorksPartPreaid")),
				new PrepaidType(5, Lang.t("DiagnosticPrepaid"))
			};
		}

		// Token: 0x06004C87 RID: 19591 RVA: 0x0013BB98 File Offset: 0x00139D98
		public static Task<List<boxes>> LoadNonItemBoxes(int? currentBoxId, bool includeAll)
		{
			RepairModel.<LoadNonItemBoxes>d__56 <LoadNonItemBoxes>d__;
			<LoadNonItemBoxes>d__.<>t__builder = AsyncTaskMethodBuilder<List<boxes>>.Create();
			<LoadNonItemBoxes>d__.currentBoxId = currentBoxId;
			<LoadNonItemBoxes>d__.includeAll = includeAll;
			<LoadNonItemBoxes>d__.<>1__state = -1;
			<LoadNonItemBoxes>d__.<>t__builder.Start<RepairModel.<LoadNonItemBoxes>d__56>(ref <LoadNonItemBoxes>d__);
			return <LoadNonItemBoxes>d__.<>t__builder.Task;
		}

		// Token: 0x06004C88 RID: 19592 RVA: 0x0013BBE4 File Offset: 0x00139DE4
		private static Expression<Func<boxes, bool>> FreeBoxes(int? currentBoxId)
		{
			if (currentBoxId != null)
			{
				return (boxes b) => b.non_items && (b.places == 0 || b.places > b.workshop.Count || (int?)b.id == currentBoxId);
			}
			return (boxes b) => b.non_items && (b.places == 0 || b.places > b.workshop.Count);
		}

		// Token: 0x06004C89 RID: 19593 RVA: 0x0013BDD0 File Offset: 0x00139FD0
		public static Task<bool> ChangeRepairInvoice(int repairId, IInvoice invoice)
		{
			RepairModel.<ChangeRepairInvoice>d__58 <ChangeRepairInvoice>d__;
			<ChangeRepairInvoice>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<ChangeRepairInvoice>d__.repairId = repairId;
			<ChangeRepairInvoice>d__.invoice = invoice;
			<ChangeRepairInvoice>d__.<>1__state = -1;
			<ChangeRepairInvoice>d__.<>t__builder.Start<RepairModel.<ChangeRepairInvoice>d__58>(ref <ChangeRepairInvoice>d__);
			return <ChangeRepairInvoice>d__.<>t__builder.Task;
		}

		// Token: 0x06004C8A RID: 19594 RVA: 0x0013BE1C File Offset: 0x0013A01C
		public static List<KeyValuePair<string, string>> GetRepairInfo(workshop repair)
		{
			List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
			if (repair.clients.is_regular)
			{
				list.Add(new KeyValuePair<string, string>(Lang.t("IsRegular"), "#FF000000"));
			}
			if (repair.clients.is_agent)
			{
				list.Add(new KeyValuePair<string, string>(Lang.t("Agent"), "#FF000000"));
			}
			if (repair.clients.is_bad)
			{
				list.Add(new KeyValuePair<string, string>(Lang.t("LabelIsBad"), "#FF9C3931"));
			}
			if (repair.IsCashLess)
			{
				list.Add(new KeyValuePair<string, string>(Lang.t("IsCashless"), "#FF000000"));
			}
			if (repair.thirs_party_sc)
			{
				list.Add(new KeyValuePair<string, string>(Lang.t("CheckBoxThirdPartySc"), "#FF000000"));
			}
			if (repair.can_format)
			{
				list.Add(new KeyValuePair<string, string>(Lang.t("CheckBoxCanFormat"), "#FF000000"));
			}
			if (repair.express_repair != null && repair.express_repair.Value)
			{
				list.Add(new KeyValuePair<string, string>(Lang.t("CheckBoxExpressRepair"), "#FF9C3931"));
			}
			if (repair.is_warranty)
			{
				list.Add(new KeyValuePair<string, string>(Lang.t("WarrantyRepair"), "#FF000000"));
			}
			if (repair.is_repeat)
			{
				list.Add(new KeyValuePair<string, string>(Lang.t("Repeat"), "#FF000000"));
			}
			if (repair.print_check)
			{
				list.Add(new KeyValuePair<string, string>(Lang.t("PrintCheck"), "#FF000000"));
			}
			if (repair.is_prepaid)
			{
				list.Add(new KeyValuePair<string, string>(string.Format("{0}: {1:N2}", Lang.t("PrePaid"), repair.prepaid_summ), "#FF9C3931"));
			}
			int? vendor_id = repair.vendor_id;
			if (vendor_id.GetValueOrDefault() > 0 & vendor_id != null)
			{
				list.Add(new KeyValuePair<string, string>(Lang.t("VendorWarranty") ?? "", "#FF9C3931"));
			}
			if (repair.is_pre_agreed)
			{
				list.Add(new KeyValuePair<string, string>(string.Format("{0}: {1:N2}", Lang.t("IsPreAgreedAmountShort"), repair.pre_agreed_amount), "#FF9C3931"));
			}
			return list;
		}

		// Token: 0x06004C8B RID: 19595 RVA: 0x0013C058 File Offset: 0x0013A258
		public static Task<bool> MarkDeviceAsCartridgeAsync(int deviceId)
		{
			RepairModel.<MarkDeviceAsCartridgeAsync>d__60 <MarkDeviceAsCartridgeAsync>d__;
			<MarkDeviceAsCartridgeAsync>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<MarkDeviceAsCartridgeAsync>d__.deviceId = deviceId;
			<MarkDeviceAsCartridgeAsync>d__.<>1__state = -1;
			<MarkDeviceAsCartridgeAsync>d__.<>t__builder.Start<RepairModel.<MarkDeviceAsCartridgeAsync>d__60>(ref <MarkDeviceAsCartridgeAsync>d__);
			return <MarkDeviceAsCartridgeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06004C8C RID: 19596 RVA: 0x0013C09C File Offset: 0x0013A29C
		public static Task<List<workshop>> GetEmployeeRepairs(int employeeId, List<int> statuses)
		{
			RepairModel.<GetEmployeeRepairs>d__61 <GetEmployeeRepairs>d__;
			<GetEmployeeRepairs>d__.<>t__builder = AsyncTaskMethodBuilder<List<workshop>>.Create();
			<GetEmployeeRepairs>d__.employeeId = employeeId;
			<GetEmployeeRepairs>d__.statuses = statuses;
			<GetEmployeeRepairs>d__.<>1__state = -1;
			<GetEmployeeRepairs>d__.<>t__builder.Start<RepairModel.<GetEmployeeRepairs>d__61>(ref <GetEmployeeRepairs>d__);
			return <GetEmployeeRepairs>d__.<>t__builder.Task;
		}

		// Token: 0x06004C8D RID: 19597 RVA: 0x0013C0E8 File Offset: 0x0013A2E8
		public static List<IIdName> GetRepairGridModes()
		{
			return new List<IIdName>
			{
				new IdNameClass(1, Lang.t("Cartridges")),
				new IdNameClass(2, Lang.t("Repairs"))
			};
		}

		// Token: 0x06004C8E RID: 19598 RVA: 0x0013C128 File Offset: 0x0013A328
		public static Task<IRepairCard> GetRepairCard(int repairId)
		{
			RepairModel.<GetRepairCard>d__64 <GetRepairCard>d__;
			<GetRepairCard>d__.<>t__builder = AsyncTaskMethodBuilder<IRepairCard>.Create();
			<GetRepairCard>d__.repairId = repairId;
			<GetRepairCard>d__.<>1__state = -1;
			<GetRepairCard>d__.<>t__builder.Start<RepairModel.<GetRepairCard>d__64>(ref <GetRepairCard>d__);
			return <GetRepairCard>d__.<>t__builder.Task;
		}

		// Token: 0x04003163 RID: 12643
		private ILoggerService<RepairModel> _logger;

		// Token: 0x02000A17 RID: 2583
		public enum WorkType
		{
			// Token: 0x04003165 RID: 12645
			Regular,
			// Token: 0x04003166 RID: 12646
			Refill,
			// Token: 0x04003167 RID: 12647
			Chip,
			// Token: 0x04003168 RID: 12648
			OPCDrum,
			// Token: 0x04003169 RID: 12649
			CleaningBlade
		}

		// Token: 0x02000A18 RID: 2584
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06004C8F RID: 19599 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x0400316A RID: 12650
			public workshop repair;
		}

		// Token: 0x02000A19 RID: 2585
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_1
		{
			// Token: 0x06004C90 RID: 19600 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass3_1()
			{
			}

			// Token: 0x06004C91 RID: 19601 RVA: 0x0013C16C File Offset: 0x0013A36C
			internal bool <TaskTrigger>b__2(tasks t)
			{
				IEnumerable<string> source = t.m_match.Split(new char[]
				{
					' '
				});
				Func<string, bool> predicate;
				if ((predicate = this.<>9__3) == null)
				{
					predicate = (this.<>9__3 = ((string z) => this.modelName.Contains(z.ToLower().Trim())));
				}
				return source.Any(predicate) || t.m_match.ToLower().Trim().Contains(this.modelName);
			}

			// Token: 0x06004C92 RID: 19602 RVA: 0x0013C1D4 File Offset: 0x0013A3D4
			internal bool <TaskTrigger>b__3(string z)
			{
				return this.modelName.Contains(z.ToLower().Trim());
			}

			// Token: 0x0400316B RID: 12651
			public string modelName;

			// Token: 0x0400316C RID: 12652
			public Func<string, bool> <>9__3;
		}

		// Token: 0x02000A1A RID: 2586
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004C93 RID: 19603 RVA: 0x0013C1F8 File Offset: 0x0013A3F8
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004C94 RID: 19604 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06004C95 RID: 19605 RVA: 0x000F9D08 File Offset: 0x000F7F08
			internal bool <FinishQuickRepair>b__5_0(WorkPartObject o)
			{
				return o.Type == 1;
			}

			// Token: 0x06004C96 RID: 19606 RVA: 0x0013C210 File Offset: 0x0013A410
			internal bool <FinishQuickRepair>b__5_1(WorkPartObject o)
			{
				return o.Type == 2;
			}

			// Token: 0x06004C97 RID: 19607 RVA: 0x0013C228 File Offset: 0x0013A428
			internal bool <CreateOrUpdateReserve>b__7_0(WorkPartObject i)
			{
				return !i.DirectItem;
			}

			// Token: 0x06004C98 RID: 19608 RVA: 0x0013C240 File Offset: 0x0013A440
			internal bool <CreateOrUpdateReserve>b__7_1(WorkPartObject i)
			{
				return i.DirectItem;
			}

			// Token: 0x06004C99 RID: 19609 RVA: 0x0013C254 File Offset: 0x0013A454
			internal bool <WorksAndPartsConvert>b__14_0(store_int_reserve p)
			{
				return p.state > 1;
			}

			// Token: 0x06004C9A RID: 19610 RVA: 0x0013C254 File Offset: 0x0013A454
			internal bool <WorksAndPartsConvert>b__14_2(store_int_reserve p)
			{
				return p.state > 1;
			}

			// Token: 0x06004C9B RID: 19611 RVA: 0x0013C26C File Offset: 0x0013A46C
			internal WorkPartObject <PartsConvert>b__15_0(store_int_reserve p)
			{
				return new WorkPartObject
				{
					Id = -p.id,
					Type = 2,
					EmployeeId = p.to_user,
					Name = p.name,
					Price = p.price,
					Count = p.count,
					Warranty = p.warranty,
					WorkId = p.work_id,
					ItemId = new int?(p.item_id),
					RepairId = p.repair_id.GetValueOrDefault()
				};
			}

			// Token: 0x06004C9C RID: 19612 RVA: 0x0013C300 File Offset: 0x0013A500
			internal WorkPartObject <WorksConvert>b__16_0(works w)
			{
				return new WorkPartObject
				{
					Id = w.id,
					Type = 1,
					EmployeeId = w.user,
					Name = w.name,
					Price = w.price,
					Count = (int)w.count,
					Warranty = w.warranty,
					MasterPercent = w.users.pay_repair,
					RepairId = w.repair.GetValueOrDefault(),
					Repairman = w.users.User2EmployeeLite()
				};
			}

			// Token: 0x06004C9D RID: 19613 RVA: 0x0013C398 File Offset: 0x0013A598
			internal IdNameClass <GetModels>b__32_0(device_models r)
			{
				return r.ToIdName();
			}

			// Token: 0x06004C9E RID: 19614 RVA: 0x0013C3AC File Offset: 0x0013A5AC
			internal IOrderedQueryable<device_models> <LoadModels>b__33_1(IQueryable<device_models> o)
			{
				return from m in o
				orderby m.name
				select m;
			}

			// Token: 0x06004C9F RID: 19615 RVA: 0x0013C3F8 File Offset: 0x0013A5F8
			internal IOrderedQueryable<logs> <GetRepairLogs>b__41_1(IQueryable<logs> i)
			{
				return from o in i
				orderby o.id descending
				select o;
			}

			// Token: 0x06004CA0 RID: 19616 RVA: 0x0013C444 File Offset: 0x0013A644
			internal ClientAndDevices <SearchClientMatchV2>b__44_6(clients c)
			{
				return new ClientAndDevices
				{
					Client = c,
					ClientId = c.id,
					ClientType = c.type,
					ClientPhone = RepairModel.ClientPhone(c),
					ClientName = c.name,
					ClientSurname = c.surname,
					ClientPatronymic = c.patronymic,
					UrName = c.ur_name,
					RepairsCount = c.workshop.Count
				};
			}

			// Token: 0x06004CA1 RID: 19617 RVA: 0x00084148 File Offset: 0x00082348
			internal bool <ClientPhone>b__45_0(tel p)
			{
				return p.type == 1;
			}

			// Token: 0x06004CA2 RID: 19618 RVA: 0x000D14F8 File Offset: 0x000CF6F8
			internal string <LoadNonItemBoxes>b__56_0(boxes x)
			{
				return x.name;
			}

			// Token: 0x0400316D RID: 12653
			public static readonly RepairModel.<>c <>9 = new RepairModel.<>c();

			// Token: 0x0400316E RID: 12654
			public static Func<WorkPartObject, bool> <>9__5_0;

			// Token: 0x0400316F RID: 12655
			public static Func<WorkPartObject, bool> <>9__5_1;

			// Token: 0x04003170 RID: 12656
			public static Func<WorkPartObject, bool> <>9__7_0;

			// Token: 0x04003171 RID: 12657
			public static Func<WorkPartObject, bool> <>9__7_1;

			// Token: 0x04003172 RID: 12658
			public static Func<store_int_reserve, bool> <>9__14_0;

			// Token: 0x04003173 RID: 12659
			public static Func<store_int_reserve, bool> <>9__14_2;

			// Token: 0x04003174 RID: 12660
			public static Func<store_int_reserve, WorkPartObject> <>9__15_0;

			// Token: 0x04003175 RID: 12661
			public static Func<works, WorkPartObject> <>9__16_0;

			// Token: 0x04003176 RID: 12662
			public static Func<device_models, IdNameClass> <>9__32_0;

			// Token: 0x04003177 RID: 12663
			public static Func<IQueryable<device_models>, IOrderedQueryable<device_models>> <>9__33_1;

			// Token: 0x04003178 RID: 12664
			public static Func<IQueryable<logs>, IOrderedQueryable<logs>> <>9__41_1;

			// Token: 0x04003179 RID: 12665
			public static Func<clients, ClientAndDevices> <>9__44_6;

			// Token: 0x0400317A RID: 12666
			public static Func<tel, bool> <>9__45_0;

			// Token: 0x0400317B RID: 12667
			public static Func<boxes, string> <>9__56_0;
		}

		// Token: 0x02000A1B RID: 2587
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06004CA3 RID: 19619 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x06004CA4 RID: 19620 RVA: 0x0013C4C4 File Offset: 0x0013A6C4
			internal bool <FinishQuickRepair>b__2(WorkPartObject o)
			{
				if (o.Type == 2)
				{
					int? workId = o.WorkId;
					int id = this.workObj.Id;
					return workId.GetValueOrDefault() == id & workId != null;
				}
				return false;
			}

			// Token: 0x0400317C RID: 12668
			public WorkPartObject workObj;
		}

		// Token: 0x02000A1C RID: 2588
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <FinishQuickRepair>d__5 : IAsyncStateMachine
		{
			// Token: 0x06004CA5 RID: 19621 RVA: 0x0013C504 File Offset: 0x0013A704
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairModel repairModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter2;
					switch (num)
					{
					case 0:
						break;
					case 1:
						goto IL_177;
					case 2:
					case 3:
					case 4:
						IL_1CF:
						try
						{
							TaskAwaiter<int> awaiter;
							switch (num)
							{
							case 2:
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<int>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								break;
							}
							case 3:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
								goto IL_33D;
							}
							case 4:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
								goto IL_3B5;
							}
							default:
							{
								this.<original>5__8 = this.<ctx>5__7.workshop.Find(new object[]
								{
									this.repair.id
								});
								DateTime serverUtcTime = Localization.GetServerUtcTime(this.<ctx>5__7);
								this.<original>5__8.state = this.repair.new_state;
								this.<original>5__8.out_date = new DateTime?(serverUtcTime);
								this.<original>5__8.real_repair_cost = this.totalSumm;
								this.<ctx>5__7.workshop_issued.Add(repairModel.CreateWorkshopIssueRecord(this.repair.id, serverUtcTime));
								awaiter = this.<ctx>5__7.SaveChangesAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num5 = 2;
									num = 2;
									this.<>1__state = num5;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, RepairModel.<FinishQuickRepair>d__5>(ref awaiter, ref this);
									return;
								}
								break;
							}
							}
							awaiter.GetResult();
							awaiter2 = this.<history>5__3.SaveAsync().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num6 = 3;
								num = 3;
								this.<>1__state = num6;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RepairModel.<FinishQuickRepair>d__5>(ref awaiter2, ref this);
								return;
							}
							IL_33D:
							awaiter2.GetResult();
							awaiter2 = Bootstrapper.Container.Resolve<IWorkshopStatusService>().UpdateStatusLog(this.<ctx>5__7, new RepairStatusLogModel(this.<original>5__8)).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num7 = 4;
								num = 4;
								this.<>1__state = num7;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RepairModel.<FinishQuickRepair>d__5>(ref awaiter2, ref this);
								return;
							}
							IL_3B5:
							awaiter2.GetResult();
							this.<original>5__8 = null;
						}
						finally
						{
							if (num < 0 && this.<ctx>5__7 != null)
							{
								((IDisposable)this.<ctx>5__7).Dispose();
							}
						}
						this.<ctx>5__7 = null;
						goto IL_40D;
					default:
					{
						this.<workPartObjects>5__2 = this.wpObjects.ToList<WorkPartObject>();
						List<WorkPartObject>.Enumerator enumerator = this.<workPartObjects>5__2.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								WorkPartObject workPartObject = enumerator.Current;
								workPartObject.RepairId = this.repair.id;
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)enumerator).Dispose();
							}
						}
						List<WorkPartObject> list = this.<workPartObjects>5__2.Where(new Func<WorkPartObject, bool>(RepairModel.<>c.<>9.<FinishQuickRepair>b__5_0)).ToList<WorkPartObject>();
						if (list.Any<WorkPartObject>())
						{
							this.<workService>5__4 = Bootstrapper.Container.Resolve<IWorkshopWorkService>();
							this.<>7__wrap4 = list.GetEnumerator();
						}
						else
						{
							List<WorkPartObject> items = this.<workPartObjects>5__2.Where(new Func<WorkPartObject, bool>(RepairModel.<>c.<>9.<FinishQuickRepair>b__5_1)).ToList<WorkPartObject>();
							awaiter2 = repairModel.CreateOrUpdateReserve(items, this.repair).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num8 = 1;
								num = 1;
								this.<>1__state = num8;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RepairModel.<FinishQuickRepair>d__5>(ref awaiter2, ref this);
								return;
							}
							goto IL_194;
						}
						break;
					}
					}
					try
					{
						if (num == 0)
						{
							TaskAwaiter<int> awaiter = this.<>u__1;
						}
						return;
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)this.<>7__wrap4).Dispose();
						}
					}
					IL_177:
					awaiter2 = this.<>u__2;
					this.<>u__2 = default(TaskAwaiter);
					int num9 = -1;
					num = -1;
					this.<>1__state = num9;
					IL_194:
					awaiter2.GetResult();
					this.repair.new_state = 8;
					this.<history>5__3 = new HistoryV2();
					this.<history>5__3.StateChangeLog(this.repair);
					this.<ctx>5__7 = new auseceEntities(true);
					goto IL_1CF;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<workPartObjects>5__2 = null;
					this.<history>5__3 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_40D:
				this.<>1__state = -2;
				this.<workPartObjects>5__2 = null;
				this.<history>5__3 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06004CA6 RID: 19622 RVA: 0x0013C9A4 File Offset: 0x0013ABA4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400317D RID: 12669
			public int <>1__state;

			// Token: 0x0400317E RID: 12670
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400317F RID: 12671
			public IEnumerable<WorkPartObject> wpObjects;

			// Token: 0x04003180 RID: 12672
			public workshop repair;

			// Token: 0x04003181 RID: 12673
			private RepairModel.<>c__DisplayClass5_0 <>8__1;

			// Token: 0x04003182 RID: 12674
			public RepairModel <>4__this;

			// Token: 0x04003183 RID: 12675
			public decimal totalSumm;

			// Token: 0x04003184 RID: 12676
			private List<WorkPartObject> <workPartObjects>5__2;

			// Token: 0x04003185 RID: 12677
			private HistoryV2 <history>5__3;

			// Token: 0x04003186 RID: 12678
			private IWorkshopWorkService <workService>5__4;

			// Token: 0x04003187 RID: 12679
			private List<WorkPartObject>.Enumerator <>7__wrap4;

			// Token: 0x04003188 RID: 12680
			private List<WorkPartObject> <workParts>5__6;

			// Token: 0x04003189 RID: 12681
			private TaskAwaiter<int> <>u__1;

			// Token: 0x0400318A RID: 12682
			private TaskAwaiter <>u__2;

			// Token: 0x0400318B RID: 12683
			private auseceEntities <ctx>5__7;

			// Token: 0x0400318C RID: 12684
			private workshop <original>5__8;
		}

		// Token: 0x02000A1D RID: 2589
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateOrUpdateReserve>d__7 : IAsyncStateMachine
		{
			// Token: 0x06004CA7 RID: 19623 RVA: 0x0013C9C0 File Offset: 0x0013ABC0
			void IAsyncStateMachine.MoveNext()
			{
				/*
An exception occurred when decompiling this method (06004CA7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ASC.Models.RepairModel/<CreateOrUpdateReserve>d__7::MoveNext()

 ---> System.Exception: Inconsistent stack size at IL_43D
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
			}

			// Token: 0x06004CA8 RID: 19624 RVA: 0x0013CEE0 File Offset: 0x0013B0E0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400318D RID: 12685
			public int <>1__state;

			// Token: 0x0400318E RID: 12686
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400318F RID: 12687
			public List<WorkPartObject> items;

			// Token: 0x04003190 RID: 12688
			public workshop repair;

			// Token: 0x04003191 RID: 12689
			public RepairModel <>4__this;

			// Token: 0x04003192 RID: 12690
			private List<store_int_reserve> <rsv>5__2;

			// Token: 0x04003193 RID: 12691
			private List<WorkPartObject>.Enumerator <>7__wrap2;

			// Token: 0x04003194 RID: 12692
			private WorkPartObject <i>5__4;

			// Token: 0x04003195 RID: 12693
			private int <id>5__5;

			// Token: 0x04003196 RID: 12694
			private auseceEntities <ctx>5__6;

			// Token: 0x04003197 RID: 12695
			private store_int_reserve <reserve>5__7;

			// Token: 0x04003198 RID: 12696
			private TaskAwaiter<store_int_reserve> <>u__1;

			// Token: 0x04003199 RID: 12697
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__2;
		}

		// Token: 0x02000A1E RID: 2590
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetRepairCostTotal>d__8 : IAsyncStateMachine
		{
			// Token: 0x06004CA9 RID: 19625 RVA: 0x0013CEFC File Offset: 0x0013B0FC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				decimal result;
				try
				{
					TaskAwaiter<decimal> awaiter;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<decimal>);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<decimal>);
						this.<>1__state = -1;
						goto IL_E4;
					case 2:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<decimal>);
						this.<>1__state = -1;
						goto IL_147;
					default:
						if (Auth.Config.parts_included)
						{
							awaiter = RepairModel.TotalWorksCost(this.repairId).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, RepairModel.<GetRepairCostTotal>d__8>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = RepairModel.TotalWorksCost(this.repairId).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 1;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, RepairModel.<GetRepairCostTotal>d__8>(ref awaiter, ref this);
								return;
							}
							goto IL_E4;
						}
						break;
					}
					result = awaiter.GetResult();
					goto IL_177;
					IL_E4:
					this.<>7__wrap1 = awaiter.GetResult();
					awaiter = RepairModel.TotalPartsCost(this.repairId).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, RepairModel.<GetRepairCostTotal>d__8>(ref awaiter, ref this);
						return;
					}
					IL_147:
					decimal result2 = awaiter.GetResult();
					result = this.<>7__wrap1 + result2;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_177:
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06004CAA RID: 19626 RVA: 0x0013D0B0 File Offset: 0x0013B2B0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400319A RID: 12698
			public int <>1__state;

			// Token: 0x0400319B RID: 12699
			public AsyncTaskMethodBuilder<decimal> <>t__builder;

			// Token: 0x0400319C RID: 12700
			public int repairId;

			// Token: 0x0400319D RID: 12701
			private TaskAwaiter<decimal> <>u__1;

			// Token: 0x0400319E RID: 12702
			private decimal <>7__wrap1;
		}

		// Token: 0x02000A1F RID: 2591
		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x06004CAB RID: 19627 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x0400319F RID: 12703
			public int repairId;
		}

		// Token: 0x02000A20 RID: 2592
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetAlreadyPayedSumm>d__9 : IAsyncStateMachine
		{
			// Token: 0x06004CAC RID: 19628 RVA: 0x0013D0CC File Offset: 0x0013B2CC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				decimal result;
				try
				{
					RepairModel.<>c__DisplayClass9_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new RepairModel.<>c__DisplayClass9_0();
						CS$<>8__locals1.repairId = this.repairId;
					}
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<decimal> awaiter;
							if (num != 0)
							{
								awaiter = (from o in this.<ctx>5__2.cash_orders
								where o.repair == (int?)CS$<>8__locals1.repairId
								select o.summa).DefaultIfEmpty<decimal>().SumAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, RepairModel.<GetAlreadyPayedSumm>d__9>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<decimal>);
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
					catch (Exception ex)
					{
						ILogger log = GenericModel.Log;
						string str = "Already payed summ get error ";
						Exception ex2 = ex;
						log.Error(str + ((ex2 != null) ? ex2.ToString() : null));
						result = 0m;
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

			// Token: 0x06004CAD RID: 19629 RVA: 0x0013D2F0 File Offset: 0x0013B4F0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040031A0 RID: 12704
			public int <>1__state;

			// Token: 0x040031A1 RID: 12705
			public AsyncTaskMethodBuilder<decimal> <>t__builder;

			// Token: 0x040031A2 RID: 12706
			public int repairId;

			// Token: 0x040031A3 RID: 12707
			private auseceEntities <ctx>5__2;

			// Token: 0x040031A4 RID: 12708
			private TaskAwaiter<decimal> <>u__1;
		}

		// Token: 0x02000A21 RID: 2593
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetRepairFinalAmount>d__10 : IAsyncStateMachine
		{
			// Token: 0x06004CAE RID: 19630 RVA: 0x0013D30C File Offset: 0x0013B50C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				decimal result2;
				try
				{
					TaskAwaiter<decimal> awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<decimal>);
							this.<>1__state = -1;
							goto IL_CC;
						}
						awaiter = RepairModel.GetRepairCostTotal(this.repairId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, RepairModel.<GetRepairFinalAmount>d__10>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<decimal>);
						this.<>1__state = -1;
					}
					this.<>7__wrap1 = awaiter.GetResult();
					awaiter = RepairModel.GetAlreadyPayedSumm(this.repairId).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, RepairModel.<GetRepairFinalAmount>d__10>(ref awaiter, ref this);
						return;
					}
					IL_CC:
					decimal result = awaiter.GetResult();
					result2 = this.<>7__wrap1 - result;
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

			// Token: 0x06004CAF RID: 19631 RVA: 0x0013D43C File Offset: 0x0013B63C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040031A5 RID: 12709
			public int <>1__state;

			// Token: 0x040031A6 RID: 12710
			public AsyncTaskMethodBuilder<decimal> <>t__builder;

			// Token: 0x040031A7 RID: 12711
			public int repairId;

			// Token: 0x040031A8 RID: 12712
			private decimal <>7__wrap1;

			// Token: 0x040031A9 RID: 12713
			private TaskAwaiter<decimal> <>u__1;
		}

		// Token: 0x02000A22 RID: 2594
		[CompilerGenerated]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x06004CB0 RID: 19632 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass11_0()
			{
			}

			// Token: 0x040031AA RID: 12714
			public int repairId;
		}

		// Token: 0x02000A23 RID: 2595
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadWorks>d__11 : IAsyncStateMachine
		{
			// Token: 0x06004CB1 RID: 19633 RVA: 0x0013D458 File Offset: 0x0013B658
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<works> result;
				try
				{
					RepairModel.<>c__DisplayClass11_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new RepairModel.<>c__DisplayClass11_0();
						CS$<>8__locals1.repairId = this.repairId;
						this.<repo>5__2 = new GenericRepository<works>();
					}
					try
					{
						TaskAwaiter<IEnumerable<works>> awaiter;
						if (num != 0)
						{
							awaiter = this.<repo>5__2.GetAllAsync((works w) => w.repair == (int?)CS$<>8__locals1.repairId, null, "users").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<works>>, RepairModel.<LoadWorks>d__11>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IEnumerable<works>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = new List<works>(awaiter.GetResult());
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

			// Token: 0x06004CB2 RID: 19634 RVA: 0x0013D5E8 File Offset: 0x0013B7E8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040031AB RID: 12715
			public int <>1__state;

			// Token: 0x040031AC RID: 12716
			public AsyncTaskMethodBuilder<List<works>> <>t__builder;

			// Token: 0x040031AD RID: 12717
			public int repairId;

			// Token: 0x040031AE RID: 12718
			private GenericRepository<works> <repo>5__2;

			// Token: 0x040031AF RID: 12719
			private TaskAwaiter<IEnumerable<works>> <>u__1;
		}

		// Token: 0x02000A24 RID: 2596
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadWorkParts>d__12 : IAsyncStateMachine
		{
			// Token: 0x06004CB3 RID: 19635 RVA: 0x0013D604 File Offset: 0x0013B804
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<WorkPartObject> result3;
				try
				{
					try
					{
						TaskAwaiter<List<store_int_reserve>> awaiter;
						TaskAwaiter<List<works>> awaiter2;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<List<store_int_reserve>>);
								this.<>1__state = -1;
								goto IL_B7;
							}
							awaiter2 = RepairModel.LoadWorks(this.repairId).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<works>>, RepairModel.<LoadWorkParts>d__12>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<works>>);
							this.<>1__state = -1;
						}
						List<works> result = awaiter2.GetResult();
						this.<works>5__2 = result;
						awaiter = RepairModel.LoadParts(this.repairId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 1;
							this.<>u__2 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_int_reserve>>, RepairModel.<LoadWorkParts>d__12>(ref awaiter, ref this);
							return;
						}
						IL_B7:
						List<store_int_reserve> result2 = awaiter.GetResult();
						result3 = RepairModel.WorksAndPartsConvert(this.<works>5__2, result2, 0);
					}
					catch (Exception exception)
					{
						GenericModel.Log.Error(exception, "Load repair works adn parts fail");
						result3 = new List<WorkPartObject>();
					}
				}
				catch (Exception exception2)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception2);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result3);
			}

			// Token: 0x06004CB4 RID: 19636 RVA: 0x0013D780 File Offset: 0x0013B980
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040031B0 RID: 12720
			public int <>1__state;

			// Token: 0x040031B1 RID: 12721
			public AsyncTaskMethodBuilder<List<WorkPartObject>> <>t__builder;

			// Token: 0x040031B2 RID: 12722
			public int repairId;

			// Token: 0x040031B3 RID: 12723
			private List<works> <works>5__2;

			// Token: 0x040031B4 RID: 12724
			private TaskAwaiter<List<works>> <>u__1;

			// Token: 0x040031B5 RID: 12725
			private TaskAwaiter<List<store_int_reserve>> <>u__2;
		}

		// Token: 0x02000A25 RID: 2597
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadWorkParts>d__13 : IAsyncStateMachine
		{
			// Token: 0x06004CB5 RID: 19637 RVA: 0x0013D79C File Offset: 0x0013B99C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<WorkPartObject> result3;
				try
				{
					try
					{
						TaskAwaiter<List<store_int_reserve>> awaiter;
						TaskAwaiter<List<works>> awaiter2;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<List<store_int_reserve>>);
								this.<>1__state = -1;
								goto IL_B7;
							}
							awaiter2 = RepairModel.LoadWorks(this.repairId).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<works>>, RepairModel.<LoadWorkParts>d__13>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<works>>);
							this.<>1__state = -1;
						}
						List<works> result = awaiter2.GetResult();
						this.<works>5__2 = result;
						awaiter = RepairModel.LoadParts(this.repairId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 1;
							this.<>u__2 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_int_reserve>>, RepairModel.<LoadWorkParts>d__13>(ref awaiter, ref this);
							return;
						}
						IL_B7:
						List<store_int_reserve> result2 = awaiter.GetResult();
						result3 = RepairModel.WorksAndPartsConvert(this.<works>5__2, result2, this.employeeId);
					}
					catch (Exception exception)
					{
						GenericModel.Log.Error(exception, "Load repair works adn parts fail");
						result3 = new List<WorkPartObject>();
					}
				}
				catch (Exception exception2)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception2);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result3);
			}

			// Token: 0x06004CB6 RID: 19638 RVA: 0x0013D91C File Offset: 0x0013BB1C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040031B6 RID: 12726
			public int <>1__state;

			// Token: 0x040031B7 RID: 12727
			public AsyncTaskMethodBuilder<List<WorkPartObject>> <>t__builder;

			// Token: 0x040031B8 RID: 12728
			public int repairId;

			// Token: 0x040031B9 RID: 12729
			public int employeeId;

			// Token: 0x040031BA RID: 12730
			private List<works> <works>5__2;

			// Token: 0x040031BB RID: 12731
			private TaskAwaiter<List<works>> <>u__1;

			// Token: 0x040031BC RID: 12732
			private TaskAwaiter<List<store_int_reserve>> <>u__2;
		}

		// Token: 0x02000A26 RID: 2598
		[CompilerGenerated]
		private sealed class <>c__DisplayClass14_0
		{
			// Token: 0x06004CB7 RID: 19639 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass14_0()
			{
			}

			// Token: 0x06004CB8 RID: 19640 RVA: 0x0013D938 File Offset: 0x0013BB38
			internal bool <WorksAndPartsConvert>b__1(works w)
			{
				return w.user == this.employeeId;
			}

			// Token: 0x06004CB9 RID: 19641 RVA: 0x0013D954 File Offset: 0x0013BB54
			internal bool <WorksAndPartsConvert>b__3(store_int_reserve p)
			{
				return p.state > 1 && p.to_user == this.employeeId;
			}

			// Token: 0x040031BD RID: 12733
			public int employeeId;
		}

		// Token: 0x02000A27 RID: 2599
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <TotalPartsCost>d__17 : IAsyncStateMachine
		{
			// Token: 0x06004CBA RID: 19642 RVA: 0x0013D97C File Offset: 0x0013BB7C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				decimal result;
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
							TaskAwaiter<decimal> awaiter;
							if (num != 0)
							{
								awaiter = RepairModel.TotalPartsCost(this.repairId, this.<ctx>5__2).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, RepairModel.<TotalPartsCost>d__17>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<decimal>);
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
						GenericModel.Log.Error(exception, "Total parts count error");
						result = 0m;
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

			// Token: 0x06004CBB RID: 19643 RVA: 0x0013DA98 File Offset: 0x0013BC98
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040031BE RID: 12734
			public int <>1__state;

			// Token: 0x040031BF RID: 12735
			public AsyncTaskMethodBuilder<decimal> <>t__builder;

			// Token: 0x040031C0 RID: 12736
			public int repairId;

			// Token: 0x040031C1 RID: 12737
			private auseceEntities <ctx>5__2;

			// Token: 0x040031C2 RID: 12738
			private TaskAwaiter<decimal> <>u__1;
		}

		// Token: 0x02000A28 RID: 2600
		[CompilerGenerated]
		private sealed class <>c__DisplayClass18_0
		{
			// Token: 0x06004CBC RID: 19644 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass18_0()
			{
			}

			// Token: 0x040031C3 RID: 12739
			public int repairId;
		}

		// Token: 0x02000A29 RID: 2601
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <TotalWorksCost>d__19 : IAsyncStateMachine
		{
			// Token: 0x06004CBD RID: 19645 RVA: 0x0013DAB4 File Offset: 0x0013BCB4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				decimal result;
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
							TaskAwaiter<decimal> awaiter;
							if (num != 0)
							{
								awaiter = RepairModel.TotalWorksCost(this.repairId, this.<ctx>5__2).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, RepairModel.<TotalWorksCost>d__19>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<decimal>);
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
						GenericModel.Log.Error(exception, "Total works count error");
						result = 0m;
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

			// Token: 0x06004CBE RID: 19646 RVA: 0x0013DBD0 File Offset: 0x0013BDD0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040031C4 RID: 12740
			public int <>1__state;

			// Token: 0x040031C5 RID: 12741
			public AsyncTaskMethodBuilder<decimal> <>t__builder;

			// Token: 0x040031C6 RID: 12742
			public int repairId;

			// Token: 0x040031C7 RID: 12743
			private auseceEntities <ctx>5__2;

			// Token: 0x040031C8 RID: 12744
			private TaskAwaiter<decimal> <>u__1;
		}

		// Token: 0x02000A2A RID: 2602
		[CompilerGenerated]
		private sealed class <>c__DisplayClass20_0
		{
			// Token: 0x06004CBF RID: 19647 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass20_0()
			{
			}

			// Token: 0x040031C9 RID: 12745
			public int repairId;
		}

		// Token: 0x02000A2B RID: 2603
		[CompilerGenerated]
		private sealed class <>c__DisplayClass21_0
		{
			// Token: 0x06004CC0 RID: 19648 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass21_0()
			{
			}

			// Token: 0x040031CA RID: 12746
			public int repairId;
		}

		// Token: 0x02000A2C RID: 2604
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadParts>d__21 : IAsyncStateMachine
		{
			// Token: 0x06004CC1 RID: 19649 RVA: 0x0013DBEC File Offset: 0x0013BDEC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<store_int_reserve> result;
				try
				{
					RepairModel.<>c__DisplayClass21_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new RepairModel.<>c__DisplayClass21_0();
						CS$<>8__locals1.repairId = this.repairId;
						this.<repo>5__2 = new GenericRepository<store_int_reserve>();
					}
					try
					{
						TaskAwaiter<IEnumerable<store_int_reserve>> awaiter;
						if (num != 0)
						{
							awaiter = this.<repo>5__2.GetAllAsync((store_int_reserve p) => p.repair_id == (int?)CS$<>8__locals1.repairId && (p.state == 2 || p.state == 3), null, "store_items").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<store_int_reserve>>, RepairModel.<LoadParts>d__21>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IEnumerable<store_int_reserve>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = new List<store_int_reserve>(awaiter.GetResult());
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

			// Token: 0x06004CC2 RID: 19650 RVA: 0x0013DDE4 File Offset: 0x0013BFE4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040031CB RID: 12747
			public int <>1__state;

			// Token: 0x040031CC RID: 12748
			public AsyncTaskMethodBuilder<List<store_int_reserve>> <>t__builder;

			// Token: 0x040031CD RID: 12749
			public int repairId;

			// Token: 0x040031CE RID: 12750
			private GenericRepository<store_int_reserve> <repo>5__2;

			// Token: 0x040031CF RID: 12751
			private TaskAwaiter<IEnumerable<store_int_reserve>> <>u__1;
		}

		// Token: 0x02000A2D RID: 2605
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <MakeRepairOut>d__22 : IAsyncStateMachine
		{
			// Token: 0x06004CC3 RID: 19651 RVA: 0x0013DE00 File Offset: 0x0013C000
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairModel repairModel = this.<>4__this;
				IAscResult result;
				try
				{
					TaskAwaiter<List<store_int_reserve>> awaiter;
					if (num != 0)
					{
						if (num - 1 <= 4)
						{
							goto IL_282;
						}
						this.<result>5__2 = new Result();
						this.<co>5__3 = new CashInOrder();
						this.<co>5__3.SetOffice(OfflineData.Instance.Employee.OfficeId);
						this.<co>5__3.SetEmployee(OfflineData.Instance.Employee.Id);
						this.<co>5__3.SetCustomerEmail(this.customerEmail);
						if (this.repair.payment_system == -1)
						{
							if (!this.payFromBalance && this.finalAmount > 0m && OfflineData.Instance.Employee.PinpadReady())
							{
								IPinpadResult pinpadResult = new SBRFPinpad().Purchase(this.finalAmount);
								if (pinpadResult.ErrorCode != 0)
								{
									this.<result>5__2.Message = pinpadResult.ResultText;
									result = this.<result>5__2;
									goto IL_814;
								}
								this.<co>5__3.PinpadId = pinpadResult.PinpadId;
								this.<co>5__3.Amount = pinpadResult.Amount;
								this.<co>5__3.TermNum = pinpadResult.TermNum;
								this.<co>5__3.ClientCard = pinpadResult.ClientCard;
								this.<co>5__3.ClientExpiryDate = pinpadResult.ClientExpiryDate;
								this.<co>5__3.AuthCode = pinpadResult.AuthCode;
								this.<co>5__3.CardName = pinpadResult.CardName;
							}
						}
						awaiter = RepairModel.LoadParts(this.repair.id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.<>1__state = num2;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_int_reserve>>, RepairModel.<MakeRepairOut>d__22>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<store_int_reserve>>);
						int num3 = -1;
						num = -1;
						this.<>1__state = num3;
					}
					List<store_int_reserve> result2 = awaiter.GetResult();
					if (result2.Any<store_int_reserve>())
					{
						repairModel.SubstractItems(result2, this.repair.id, this.repair.client);
					}
					if (this.debtOut)
					{
						this.repair.new_state = 16;
						repairModel.RepairDebtOut(this.repair, this.finalAmount);
						this.<result>5__2.Id = this.repair.new_state;
						this.<result>5__2.SetSuccess();
						result = this.<result>5__2;
						goto IL_814;
					}
					this.<newState>5__4 = (repairModel.IsRepairOk(this.repair.state) ? 8 : 12);
					this.<history>5__5 = new HistoryV2();
					IL_282:
					try
					{
						if (num - 1 > 4)
						{
							this.<ctx>5__7 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<workshop> awaiter2;
							TaskAwaiter awaiter3;
							TaskAwaiter<int> awaiter4;
							switch (num)
							{
							case 1:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<workshop>);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
								break;
							}
							case 2:
							{
								awaiter3 = this.<>u__3;
								this.<>u__3 = default(TaskAwaiter);
								int num5 = -1;
								num = -1;
								this.<>1__state = num5;
								goto IL_3A9;
							}
							case 3:
							{
								awaiter4 = this.<>u__4;
								this.<>u__4 = default(TaskAwaiter<int>);
								int num6 = -1;
								num = -1;
								this.<>1__state = num6;
								goto IL_516;
							}
							case 4:
							{
								awaiter3 = this.<>u__3;
								this.<>u__3 = default(TaskAwaiter);
								int num7 = -1;
								num = -1;
								this.<>1__state = num7;
								goto IL_5A6;
							}
							case 5:
							{
								awaiter3 = this.<>u__3;
								this.<>u__3 = default(TaskAwaiter);
								int num8 = -1;
								num = -1;
								this.<>1__state = num8;
								goto IL_61E;
							}
							default:
								awaiter2 = this.<ctx>5__7.workshop.FindAsync(new object[]
								{
									this.repair.id
								}).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									int num9 = 1;
									num = 1;
									this.<>1__state = num9;
									this.<>u__2 = awaiter2;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop>, RepairModel.<MakeRepairOut>d__22>(ref awaiter2, ref this);
									return;
								}
								break;
							}
							workshop result3 = awaiter2.GetResult();
							this.<original>5__8 = result3;
							awaiter3 = Bootstrapper.Container.Resolve<IWorkshopHistoryService>().LogRepairChanges(this.<original>5__8, this.repair).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								int num10 = 2;
								num = 2;
								this.<>1__state = num10;
								this.<>u__3 = awaiter3;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RepairModel.<MakeRepairOut>d__22>(ref awaiter3, ref this);
								return;
							}
							IL_3A9:
							awaiter3.GetResult();
							this.<ctx>5__7.Entry<workshop>(this.<original>5__8).CurrentValues.SetValues(this.repair);
							this.<outDate>5__6 = Localization.GetServerUtcTime(this.<ctx>5__7);
							this.<original>5__8.state = this.<newState>5__4;
							this.<original>5__8.out_date = new DateTime?(this.<outDate>5__6);
							this.<original>5__8.last_status_changed = new DateTime?(this.<outDate>5__6);
							this.<ctx>5__7.workshop_issued.Add(repairModel.CreateWorkshopIssueRecord(this.repair.id, this.<outDate>5__6));
							if (this.<original>5__8.box != null)
							{
								string prm = (this.<original>5__8.boxes == null) ? "" : this.<original>5__8.boxes.name;
								this.<history>5__5.AddRepairLog("removedFromBox", this.repair.id, prm, "");
								this.<original>5__8.box = null;
							}
							awaiter4 = this.<ctx>5__7.SaveChangesAsync().GetAwaiter();
							if (!awaiter4.IsCompleted)
							{
								int num11 = 3;
								num = 3;
								this.<>1__state = num11;
								this.<>u__4 = awaiter4;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, RepairModel.<MakeRepairOut>d__22>(ref awaiter4, ref this);
								return;
							}
							IL_516:
							awaiter4.GetResult();
							this.<history>5__5.AddRepairLog("Issued2Client", this.repair.id, this.finalAmount, this.repair.payment_system);
							awaiter3 = this.<history>5__5.SaveAsync().GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								int num12 = 4;
								num = 4;
								this.<>1__state = num12;
								this.<>u__3 = awaiter3;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RepairModel.<MakeRepairOut>d__22>(ref awaiter3, ref this);
								return;
							}
							IL_5A6:
							awaiter3.GetResult();
							awaiter3 = Bootstrapper.Container.Resolve<IWorkshopStatusService>().UpdateStatusLog(this.<ctx>5__7, new RepairStatusLogModel(this.repair)).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								int num13 = 5;
								num = 5;
								this.<>1__state = num13;
								this.<>u__3 = awaiter3;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RepairModel.<MakeRepairOut>d__22>(ref awaiter3, ref this);
								return;
							}
							IL_61E:
							awaiter3.GetResult();
							this.<original>5__8 = null;
						}
						finally
						{
							if (num < 0 && this.<ctx>5__7 != null)
							{
								((IDisposable)this.<ctx>5__7).Dispose();
							}
						}
						this.<ctx>5__7 = null;
						if (this.payFromBalance)
						{
							KassaModel.SubstractCustomerBalance(this.repair.client, this.finalAmount, Kassa.Balance.RepairFromBalance, new int?(this.repair.id), 0);
							this.<result>5__2.Id = this.<newState>5__4;
							this.repair.out_date = new DateTime?(this.<outDate>5__6);
							this.<result>5__2.SetSuccess();
							result = this.<result>5__2;
							goto IL_814;
						}
						if (this.<newState>5__4 == 8)
						{
							if (this.finalAmount > 0m && this.repair.invoice == null)
							{
								this.<co>5__3.FillByRepair(this.repair, Kassa.Types.repairPayment);
								IAscResult ascResult = KassaModel.CreateCashOrder(this.<co>5__3, true);
								if (!ascResult.IsSucces)
								{
									this.<result>5__2.Message = ascResult.Message;
									result = this.<result>5__2;
									goto IL_814;
								}
								this.<co>5__3.Id = ascResult.Id;
								this.<result>5__2.AddId(this.<co>5__3.Id);
							}
						}
						this.<result>5__2.Id = this.<newState>5__4;
						this.repair.out_date = new DateTime?(this.<outDate>5__6);
						this.<result>5__2.SetSuccess();
					}
					catch (Exception ex)
					{
						GenericModel.Log.Error(ex, ex.Message);
						this.<result>5__2.Id = this.repair.state;
						this.<result>5__2.Message = ex.Message;
					}
					result = this.<result>5__2;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<result>5__2 = null;
					this.<co>5__3 = null;
					this.<history>5__5 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_814:
				this.<>1__state = -2;
				this.<result>5__2 = null;
				this.<co>5__3 = null;
				this.<history>5__5 = null;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06004CC4 RID: 19652 RVA: 0x0013E698 File Offset: 0x0013C898
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040031D0 RID: 12752
			public int <>1__state;

			// Token: 0x040031D1 RID: 12753
			public AsyncTaskMethodBuilder<IAscResult> <>t__builder;

			// Token: 0x040031D2 RID: 12754
			public string customerEmail;

			// Token: 0x040031D3 RID: 12755
			public workshop repair;

			// Token: 0x040031D4 RID: 12756
			public bool payFromBalance;

			// Token: 0x040031D5 RID: 12757
			public decimal finalAmount;

			// Token: 0x040031D6 RID: 12758
			public RepairModel <>4__this;

			// Token: 0x040031D7 RID: 12759
			public bool debtOut;

			// Token: 0x040031D8 RID: 12760
			private Result <result>5__2;

			// Token: 0x040031D9 RID: 12761
			private CashInOrder <co>5__3;

			// Token: 0x040031DA RID: 12762
			private int <newState>5__4;

			// Token: 0x040031DB RID: 12763
			private HistoryV2 <history>5__5;

			// Token: 0x040031DC RID: 12764
			private TaskAwaiter<List<store_int_reserve>> <>u__1;

			// Token: 0x040031DD RID: 12765
			private DateTime <outDate>5__6;

			// Token: 0x040031DE RID: 12766
			private auseceEntities <ctx>5__7;

			// Token: 0x040031DF RID: 12767
			private workshop <original>5__8;

			// Token: 0x040031E0 RID: 12768
			private TaskAwaiter<workshop> <>u__2;

			// Token: 0x040031E1 RID: 12769
			private TaskAwaiter <>u__3;

			// Token: 0x040031E2 RID: 12770
			private TaskAwaiter<int> <>u__4;
		}

		// Token: 0x02000A2E RID: 2606
		[CompilerGenerated]
		private sealed class <>c__DisplayClass24_0
		{
			// Token: 0x06004CC5 RID: 19653 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass24_0()
			{
			}

			// Token: 0x040031E3 RID: 12771
			public int repairId;
		}

		// Token: 0x02000A2F RID: 2607
		[CompilerGenerated]
		private sealed class <>c__DisplayClass26_0
		{
			// Token: 0x06004CC6 RID: 19654 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass26_0()
			{
			}

			// Token: 0x040031E4 RID: 12772
			public int deviceId;
		}

		// Token: 0x02000A30 RID: 2608
		[CompilerGenerated]
		private sealed class <>c__DisplayClass27_0
		{
			// Token: 0x06004CC7 RID: 19655 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass27_0()
			{
			}

			// Token: 0x040031E5 RID: 12773
			public string deviceName;
		}

		// Token: 0x02000A31 RID: 2609
		[CompilerGenerated]
		private sealed class <>c__DisplayClass28_0
		{
			// Token: 0x06004CC8 RID: 19656 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass28_0()
			{
			}

			// Token: 0x040031E6 RID: 12774
			public string makerName;
		}

		// Token: 0x02000A32 RID: 2610
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateDeviceMakerName>d__30 : IAsyncStateMachine
		{
			// Token: 0x06004CC9 RID: 19657 RVA: 0x0013E6B4 File Offset: 0x0013C8B4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					try
					{
						if (num > 1)
						{
							this.<history>5__2 = new HistoryV2();
							this.<ctx>5__3 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<int> awaiter;
							TaskAwaiter<device_makers> awaiter2;
							if (num != 0)
							{
								if (num == 1)
								{
									awaiter = this.<>u__2;
									this.<>u__2 = default(TaskAwaiter<int>);
									int num2 = -1;
									num = -1;
									this.<>1__state = num2;
									goto IL_122;
								}
								awaiter2 = this.<ctx>5__3.device_makers.FindAsync(new object[]
								{
									this.makerId
								}).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									int num3 = 0;
									num = 0;
									this.<>1__state = num3;
									this.<>u__1 = awaiter2;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<device_makers>, RepairModel.<UpdateDeviceMakerName>d__30>(ref awaiter2, ref this);
									return;
								}
							}
							else
							{
								awaiter2 = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<device_makers>);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
							}
							device_makers result = awaiter2.GetResult();
							if (result == null)
							{
								goto IL_1A6;
							}
							this.<history>5__2.Add(57, new string[]
							{
								result.name,
								this.name
							});
							this.<history>5__2.Save();
							result.name = this.name;
							awaiter = this.<ctx>5__3.SaveChangesAsync().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num5 = 1;
								num = 1;
								this.<>1__state = num5;
								this.<>u__2 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, RepairModel.<UpdateDeviceMakerName>d__30>(ref awaiter, ref this);
								return;
							}
							IL_122:
							awaiter.GetResult();
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
						GenericModel.Log.Error(exception, "Update device maker name fail");
					}
				}
				catch (Exception exception2)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception2);
					return;
				}
				IL_1A6:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06004CCA RID: 19658 RVA: 0x0013E8C8 File Offset: 0x0013CAC8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040031E7 RID: 12775
			public int <>1__state;

			// Token: 0x040031E8 RID: 12776
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040031E9 RID: 12777
			public int makerId;

			// Token: 0x040031EA RID: 12778
			public string name;

			// Token: 0x040031EB RID: 12779
			private HistoryV2 <history>5__2;

			// Token: 0x040031EC RID: 12780
			private auseceEntities <ctx>5__3;

			// Token: 0x040031ED RID: 12781
			private TaskAwaiter<device_makers> <>u__1;

			// Token: 0x040031EE RID: 12782
			private TaskAwaiter<int> <>u__2;
		}

		// Token: 0x02000A33 RID: 2611
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetModels>d__32 : IAsyncStateMachine
		{
			// Token: 0x06004CCB RID: 19659 RVA: 0x0013E8E4 File Offset: 0x0013CAE4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairModel repairModel = this.<>4__this;
				List<IdNameClass> result;
				try
				{
					TaskAwaiter<List<device_models>> awaiter;
					if (num != 0)
					{
						awaiter = repairModel.LoadModels(this.makerId, this.deviceType).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<device_models>>, RepairModel.<GetModels>d__32>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<device_models>>);
						this.<>1__state = -1;
					}
					result = awaiter.GetResult().Select(new Func<device_models, IdNameClass>(RepairModel.<>c.<>9.<GetModels>b__32_0)).ToList<IdNameClass>();
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

			// Token: 0x06004CCC RID: 19660 RVA: 0x0013E9D0 File Offset: 0x0013CBD0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040031EF RID: 12783
			public int <>1__state;

			// Token: 0x040031F0 RID: 12784
			public AsyncTaskMethodBuilder<List<IdNameClass>> <>t__builder;

			// Token: 0x040031F1 RID: 12785
			public RepairModel <>4__this;

			// Token: 0x040031F2 RID: 12786
			public int makerId;

			// Token: 0x040031F3 RID: 12787
			public int deviceType;

			// Token: 0x040031F4 RID: 12788
			private TaskAwaiter<List<device_models>> <>u__1;
		}

		// Token: 0x02000A34 RID: 2612
		[CompilerGenerated]
		private sealed class <>c__DisplayClass33_0
		{
			// Token: 0x06004CCD RID: 19661 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass33_0()
			{
			}

			// Token: 0x040031F5 RID: 12789
			public int makerId;

			// Token: 0x040031F6 RID: 12790
			public int deviceType;
		}

		// Token: 0x02000A35 RID: 2613
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadModels>d__33 : IAsyncStateMachine
		{
			// Token: 0x06004CCE RID: 19662 RVA: 0x0013E9EC File Offset: 0x0013CBEC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<device_models> result;
				try
				{
					RepairModel.<>c__DisplayClass33_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new RepairModel.<>c__DisplayClass33_0();
						CS$<>8__locals1.makerId = this.makerId;
						CS$<>8__locals1.deviceType = this.deviceType;
						this.<repo>5__2 = new GenericRepository<device_models>();
					}
					try
					{
						TaskAwaiter<IEnumerable<device_models>> awaiter;
						if (num != 0)
						{
							awaiter = this.<repo>5__2.GetAllAsync((device_models m) => m.maker == CS$<>8__locals1.makerId && m.device == (int?)CS$<>8__locals1.deviceType, new Func<IQueryable<device_models>, IOrderedQueryable<device_models>>(RepairModel.<>c.<>9.<LoadModels>b__33_1), "").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<device_models>>, RepairModel.<LoadModels>d__33>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IEnumerable<device_models>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = new List<device_models>(awaiter.GetResult());
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

			// Token: 0x06004CCF RID: 19663 RVA: 0x0013EBE4 File Offset: 0x0013CDE4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040031F7 RID: 12791
			public int <>1__state;

			// Token: 0x040031F8 RID: 12792
			public AsyncTaskMethodBuilder<List<device_models>> <>t__builder;

			// Token: 0x040031F9 RID: 12793
			public int makerId;

			// Token: 0x040031FA RID: 12794
			public int deviceType;

			// Token: 0x040031FB RID: 12795
			private GenericRepository<device_models> <repo>5__2;

			// Token: 0x040031FC RID: 12796
			private TaskAwaiter<IEnumerable<device_models>> <>u__1;
		}

		// Token: 0x02000A36 RID: 2614
		[CompilerGenerated]
		private sealed class <>c__DisplayClass36_0
		{
			// Token: 0x06004CD0 RID: 19664 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass36_0()
			{
			}

			// Token: 0x040031FD RID: 12797
			public int type;

			// Token: 0x040031FE RID: 12798
			public int deviceMaker;

			// Token: 0x040031FF RID: 12799
			public string modelName;
		}

		// Token: 0x02000A37 RID: 2615
		[CompilerGenerated]
		private sealed class <>c__DisplayClass38_0
		{
			// Token: 0x06004CD1 RID: 19665 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass38_0()
			{
			}

			// Token: 0x04003200 RID: 12800
			public workshop repair;
		}

		// Token: 0x02000A38 RID: 2616
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SearchDeviceMatch>d__38 : IAsyncStateMachine
		{
			// Token: 0x06004CD2 RID: 19666 RVA: 0x0013EC00 File Offset: 0x0013CE00
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<ClientAndDevices> result;
				try
				{
					RepairModel.<>c__DisplayClass38_0 CS$<>8__locals1;
					if (num > 1)
					{
						CS$<>8__locals1 = new RepairModel.<>c__DisplayClass38_0();
						CS$<>8__locals1.repair = this.repair;
					}
					try
					{
						if (num > 1)
						{
							this.<ctx>5__2 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<List<ClientAndDevices>> awaiter;
							if (num != 0)
							{
								if (num == 1)
								{
									awaiter = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter<List<ClientAndDevices>>);
									int num2 = -1;
									num = -1;
									this.<>1__state = num2;
								}
								else if (Auth.Config.history_by_sn && CS$<>8__locals1.repair.serial_number.Length > 0)
								{
									awaiter = (from ws in this.<ctx>5__2.workshop.Include((workshop h) => h.clients).Include((workshop h) => h.device_makers).Include((workshop h) => h.device_models)
									where ws.serial_number == CS$<>8__locals1.repair.serial_number
									select ws).Select(RepairModel.ClientAndDevices()).ToListAsync<ClientAndDevices>().GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										int num3 = 0;
										num = 0;
										this.<>1__state = num3;
										this.<>u__1 = awaiter;
										this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<ClientAndDevices>>, RepairModel.<SearchDeviceMatch>d__38>(ref awaiter, ref this);
										return;
									}
									goto IL_49B;
								}
								else
								{
									if (CS$<>8__locals1.repair.type <= 0 || CS$<>8__locals1.repair.maker <= 0 || CS$<>8__locals1.repair.serial_number.Length <= 0)
									{
										goto IL_4BD;
									}
									awaiter = (from ws in this.<ctx>5__2.workshop.Include((workshop h) => h.clients).Include((workshop h) => h.device_makers).Include((workshop h) => h.device_models)
									where ws.maker == CS$<>8__locals1.repair.maker && ws.type == CS$<>8__locals1.repair.type && ws.serial_number == CS$<>8__locals1.repair.serial_number
									select ws).Select(RepairModel.ClientAndDevices()).ToListAsync<ClientAndDevices>().GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										int num4 = 1;
										num = 1;
										this.<>1__state = num4;
										this.<>u__1 = awaiter;
										this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<ClientAndDevices>>, RepairModel.<SearchDeviceMatch>d__38>(ref awaiter, ref this);
										return;
									}
								}
								result = awaiter.GetResult();
								goto IL_502;
							}
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<ClientAndDevices>>);
							int num5 = -1;
							num = -1;
							this.<>1__state = num5;
							IL_49B:
							result = awaiter.GetResult();
							goto IL_502;
						}
						finally
						{
							if (num < 0 && this.<ctx>5__2 != null)
							{
								((IDisposable)this.<ctx>5__2).Dispose();
							}
						}
						IL_4BD:
						this.<ctx>5__2 = null;
					}
					catch (Exception exception)
					{
						GenericModel.Log.Error(exception, "Search device match fail");
						result = new List<ClientAndDevices>();
						goto IL_502;
					}
					result = new List<ClientAndDevices>();
				}
				catch (Exception exception2)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception2);
					return;
				}
				IL_502:
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06004CD3 RID: 19667 RVA: 0x0013F170 File Offset: 0x0013D370
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003201 RID: 12801
			public int <>1__state;

			// Token: 0x04003202 RID: 12802
			public AsyncTaskMethodBuilder<List<ClientAndDevices>> <>t__builder;

			// Token: 0x04003203 RID: 12803
			public workshop repair;

			// Token: 0x04003204 RID: 12804
			private auseceEntities <ctx>5__2;

			// Token: 0x04003205 RID: 12805
			private TaskAwaiter<List<ClientAndDevices>> <>u__1;
		}

		// Token: 0x02000A39 RID: 2617
		[CompilerGenerated]
		private sealed class <>c__DisplayClass41_0
		{
			// Token: 0x06004CD4 RID: 19668 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass41_0()
			{
			}

			// Token: 0x04003206 RID: 12806
			public int repairId;
		}

		// Token: 0x02000A3A RID: 2618
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetRepairLogs>d__41 : IAsyncStateMachine
		{
			// Token: 0x06004CD5 RID: 19669 RVA: 0x0013F18C File Offset: 0x0013D38C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IEnumerable<logs> result;
				try
				{
					RepairModel.<>c__DisplayClass41_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new RepairModel.<>c__DisplayClass41_0();
						CS$<>8__locals1.repairId = this.repairId;
						this.<repo>5__2 = new GenericRepository<logs>();
					}
					try
					{
						TaskAwaiter<IEnumerable<logs>> awaiter;
						if (num != 0)
						{
							awaiter = this.<repo>5__2.GetAllAsync((logs i) => i.repair == (int?)CS$<>8__locals1.repairId, new Func<IQueryable<logs>, IOrderedQueryable<logs>>(RepairModel.<>c.<>9.<GetRepairLogs>b__41_1), "users").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<logs>>, RepairModel.<GetRepairLogs>d__41>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IEnumerable<logs>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult();
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

			// Token: 0x06004CD6 RID: 19670 RVA: 0x0013F334 File Offset: 0x0013D534
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003207 RID: 12807
			public int <>1__state;

			// Token: 0x04003208 RID: 12808
			public AsyncTaskMethodBuilder<IEnumerable<logs>> <>t__builder;

			// Token: 0x04003209 RID: 12809
			public int repairId;

			// Token: 0x0400320A RID: 12810
			private GenericRepository<logs> <repo>5__2;

			// Token: 0x0400320B RID: 12811
			private TaskAwaiter<IEnumerable<logs>> <>u__1;
		}

		// Token: 0x02000A3B RID: 2619
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <RestoreIntReserve>d__42 : IAsyncStateMachine
		{
			// Token: 0x06004CD7 RID: 19671 RVA: 0x0013F350 File Offset: 0x0013D550
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairModel repairModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<store_int_reserve>> awaiter;
					if (num != 0)
					{
						awaiter = RepairModel.LoadParts(this.repairId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.<>1__state = num2;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_int_reserve>>, RepairModel.<RestoreIntReserve>d__42>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<store_int_reserve>>);
						int num3 = -1;
						num = -1;
						this.<>1__state = num3;
					}
					List<store_int_reserve> result = awaiter.GetResult();
					if (result.Any<store_int_reserve>())
					{
						List<store_int_reserve>.Enumerator enumerator = result.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								store_int_reserve reserve = enumerator.Current;
								repairModel.CancellReserve(reserve, PartsRequestModel.State.Installed);
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

			// Token: 0x06004CD8 RID: 19672 RVA: 0x0013F460 File Offset: 0x0013D660
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400320C RID: 12812
			public int <>1__state;

			// Token: 0x0400320D RID: 12813
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400320E RID: 12814
			public int repairId;

			// Token: 0x0400320F RID: 12815
			public RepairModel <>4__this;

			// Token: 0x04003210 RID: 12816
			private TaskAwaiter<List<store_int_reserve>> <>u__1;
		}

		// Token: 0x02000A3C RID: 2620
		[CompilerGenerated]
		private sealed class <>c__DisplayClass44_0
		{
			// Token: 0x06004CD9 RID: 19673 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass44_0()
			{
			}

			// Token: 0x04003211 RID: 12817
			public clients client;
		}

		// Token: 0x02000A3D RID: 2621
		[CompilerGenerated]
		private sealed class <>c__DisplayClass44_1
		{
			// Token: 0x06004CDA RID: 19674 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass44_1()
			{
			}

			// Token: 0x04003212 RID: 12818
			public string clean;
		}

		// Token: 0x02000A3E RID: 2622
		[CompilerGenerated]
		private sealed class <>c__DisplayClass44_2
		{
			// Token: 0x06004CDB RID: 19675 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass44_2()
			{
			}

			// Token: 0x04003213 RID: 12819
			public string phone8;
		}

		// Token: 0x02000A3F RID: 2623
		[CompilerGenerated]
		private sealed class <>c__DisplayClass44_3
		{
			// Token: 0x06004CDC RID: 19676 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass44_3()
			{
			}

			// Token: 0x04003214 RID: 12820
			public string phone7;
		}

		// Token: 0x02000A40 RID: 2624
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SearchClientMatchV2>d__44 : IAsyncStateMachine
		{
			// Token: 0x06004CDD RID: 19677 RVA: 0x0013F47C File Offset: 0x0013D67C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<ClientAndDevices> result;
				try
				{
					RepairModel.<>c__DisplayClass44_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new RepairModel.<>c__DisplayClass44_0();
						CS$<>8__locals1.client = this.client;
					}
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<List<clients>> awaiter;
							if (num != 0)
							{
								IQueryable<clients> source = (from c in this.<ctx>5__2.clients.Include((clients c) => c.tel)
								where c.state == 1
								select c).DefaultIfEmpty<clients>();
								if (!string.IsNullOrEmpty(CS$<>8__locals1.client.name))
								{
									source = from cl in source
									where cl.name.Contains(CS$<>8__locals1.client.name)
									select cl;
								}
								if (!string.IsNullOrEmpty(CS$<>8__locals1.client.surname))
								{
									source = from cl in source
									where cl.surname.Contains(CS$<>8__locals1.client.surname)
									select cl;
								}
								if (!string.IsNullOrEmpty(CS$<>8__locals1.client.patronymic))
								{
									source = from cl in source
									where cl.patronymic.Contains(CS$<>8__locals1.client.patronymic)
									select cl;
								}
								if (!string.IsNullOrEmpty(CS$<>8__locals1.client.ur_name))
								{
									source = from cl in source
									where cl.ur_name.Contains(CS$<>8__locals1.client.ur_name)
									select cl;
								}
								if (!string.IsNullOrEmpty(CS$<>8__locals1.client.phone))
								{
									RepairModel.<>c__DisplayClass44_1 CS$<>8__locals2 = new RepairModel.<>c__DisplayClass44_1();
									CS$<>8__locals2.clean = Phone.ClearPhoneString(CS$<>8__locals1.client.phone);
									if (CS$<>8__locals2.clean[0] == '\a')
									{
										RepairModel.<>c__DisplayClass44_2 CS$<>8__locals3 = new RepairModel.<>c__DisplayClass44_2();
										CS$<>8__locals3.phone8 = "8" + CS$<>8__locals2.clean.Remove(0, 1);
										source = from cl in source
										where cl.tel.Any((tel t) => t.phone_clean.Contains(CS$<>8__locals3.phone8))
										select cl;
									}
									if (CS$<>8__locals2.clean[0] == '\b')
									{
										RepairModel.<>c__DisplayClass44_3 CS$<>8__locals4 = new RepairModel.<>c__DisplayClass44_3();
										CS$<>8__locals4.phone7 = "7" + CS$<>8__locals2.clean.Remove(0, 1);
										source = from cl in source
										where cl.tel.Any((tel t) => t.phone_clean.Contains(CS$<>8__locals4.phone7))
										select cl;
									}
									source = from cl in source
									where cl.tel.Any((tel t) => t.phone_clean.Contains(CS$<>8__locals2.clean))
									select cl;
								}
								awaiter = source.ToListAsync<clients>().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<clients>>, RepairModel.<SearchClientMatchV2>d__44>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<List<clients>>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							result = awaiter.GetResult().Select(new Func<clients, ClientAndDevices>(RepairModel.<>c.<>9.<SearchClientMatchV2>b__44_6)).ToList<ClientAndDevices>();
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
						GenericModel.Log.Error(exception, "Search client match fail");
						result = new List<ClientAndDevices>();
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

			// Token: 0x06004CDE RID: 19678 RVA: 0x0013FC7C File Offset: 0x0013DE7C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003215 RID: 12821
			public int <>1__state;

			// Token: 0x04003216 RID: 12822
			public AsyncTaskMethodBuilder<List<ClientAndDevices>> <>t__builder;

			// Token: 0x04003217 RID: 12823
			public clients client;

			// Token: 0x04003218 RID: 12824
			private auseceEntities <ctx>5__2;

			// Token: 0x04003219 RID: 12825
			private TaskAwaiter<List<clients>> <>u__1;
		}

		// Token: 0x02000A41 RID: 2625
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ReloadFieldValues>d__46 : IAsyncStateMachine
		{
			// Token: 0x06004CDF RID: 19679 RVA: 0x0013FC98 File Offset: 0x0013DE98
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2 = new auseceEntities(false);
						}
						try
						{
							TaskAwaiter awaiter;
							if (num != 0)
							{
								this.<ctx>5__2.workshop.Attach(this.repair);
								awaiter = this.<ctx>5__2.Entry<workshop>(this.repair).Collection<field_values>((workshop r) => r.field_values).LoadAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RepairModel.<ReloadFieldValues>d__46>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter);
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
						GenericModel.Log.Error(exception, "Reload user fields fail");
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

			// Token: 0x06004CE0 RID: 19680 RVA: 0x0013FE34 File Offset: 0x0013E034
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400321A RID: 12826
			public int <>1__state;

			// Token: 0x0400321B RID: 12827
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400321C RID: 12828
			public workshop repair;

			// Token: 0x0400321D RID: 12829
			private auseceEntities <ctx>5__2;

			// Token: 0x0400321E RID: 12830
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000A42 RID: 2626
		[CompilerGenerated]
		private sealed class <>c__DisplayClass49_0
		{
			// Token: 0x06004CE1 RID: 19681 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass49_0()
			{
			}

			// Token: 0x0400321F RID: 12831
			public int deviceId;
		}

		// Token: 0x02000A43 RID: 2627
		[CompilerGenerated]
		private sealed class <>c__DisplayClass50_0
		{
			// Token: 0x06004CE2 RID: 19682 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass50_0()
			{
			}

			// Token: 0x04003220 RID: 12832
			public int repairId;
		}

		// Token: 0x02000A44 RID: 2628
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetRepairCashOrders>d__50 : IAsyncStateMachine
		{
			// Token: 0x06004CE3 RID: 19683 RVA: 0x0013FE50 File Offset: 0x0013E050
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IEnumerable<cash_orders> result;
				try
				{
					RepairModel.<>c__DisplayClass50_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new RepairModel.<>c__DisplayClass50_0();
						CS$<>8__locals1.repairId = this.repairId;
						this.<repo>5__2 = new GenericRepository<cash_orders>();
					}
					try
					{
						TaskAwaiter<IEnumerable<cash_orders>> awaiter;
						if (num != 0)
						{
							awaiter = this.<repo>5__2.GetAllAsync((cash_orders i) => i.repair == (int?)CS$<>8__locals1.repairId, null, "").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<cash_orders>>, RepairModel.<GetRepairCashOrders>d__50>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IEnumerable<cash_orders>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult();
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

			// Token: 0x06004CE4 RID: 19684 RVA: 0x0013FFDC File Offset: 0x0013E1DC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003221 RID: 12833
			public int <>1__state;

			// Token: 0x04003222 RID: 12834
			public AsyncTaskMethodBuilder<IEnumerable<cash_orders>> <>t__builder;

			// Token: 0x04003223 RID: 12835
			public int repairId;

			// Token: 0x04003224 RID: 12836
			private GenericRepository<cash_orders> <repo>5__2;

			// Token: 0x04003225 RID: 12837
			private TaskAwaiter<IEnumerable<cash_orders>> <>u__1;
		}

		// Token: 0x02000A45 RID: 2629
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <AdminSaveCard>d__52 : IAsyncStateMachine
		{
			// Token: 0x06004CE5 RID: 19685 RVA: 0x0013FFF8 File Offset: 0x0013E1F8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairModel repairModel = this.<>4__this;
				try
				{
					if (num > 3)
					{
						int? model = this.repair.model;
						if (model.GetValueOrDefault() == 0 & model != null)
						{
							this.repair.model = new int?(repairModel.CreateDeviceModel(this.repair, true));
						}
					}
					try
					{
						if (num > 3)
						{
							this.<ctx>5__2 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<workshop> awaiter;
							TaskAwaiter awaiter2;
							TaskAwaiter<int> awaiter3;
							switch (num)
							{
							case 0:
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<workshop>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								break;
							}
							case 1:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
								goto IL_16E;
							}
							case 2:
							{
								awaiter3 = this.<>u__3;
								this.<>u__3 = default(TaskAwaiter<int>);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
								goto IL_1F2;
							}
							case 3:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter);
								int num5 = -1;
								num = -1;
								this.<>1__state = num5;
								goto IL_25C;
							}
							default:
								awaiter = this.<ctx>5__2.workshop.FindAsync(new object[]
								{
									this.repair.id
								}).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num6 = 0;
									num = 0;
									this.<>1__state = num6;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop>, RepairModel.<AdminSaveCard>d__52>(ref awaiter, ref this);
									return;
								}
								break;
							}
							workshop result = awaiter.GetResult();
							this.<original>5__3 = result;
							awaiter2 = Bootstrapper.Container.Resolve<IWorkshopHistoryService>().LogRepairChanges(this.<original>5__3, this.repair).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num7 = 1;
								num = 1;
								this.<>1__state = num7;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RepairModel.<AdminSaveCard>d__52>(ref awaiter2, ref this);
								return;
							}
							IL_16E:
							awaiter2.GetResult();
							this.<ctx>5__2.Entry<workshop>(this.<original>5__3).CurrentValues.SetValues(this.repair);
							awaiter3 = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								int num8 = 2;
								num = 2;
								this.<>1__state = num8;
								this.<>u__3 = awaiter3;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, RepairModel.<AdminSaveCard>d__52>(ref awaiter3, ref this);
								return;
							}
							IL_1F2:
							awaiter3.GetResult();
							awaiter2 = WorkshopService.SetOrderTitle(this.<original>5__3, this.<ctx>5__2).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num9 = 3;
								num = 3;
								this.<>1__state = num9;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RepairModel.<AdminSaveCard>d__52>(ref awaiter2, ref this);
								return;
							}
							IL_25C:
							awaiter2.GetResult();
							this.<original>5__3 = null;
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
						GenericModel.Log.Error(exception, "Repair card admin changes save error");
						throw;
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

			// Token: 0x06004CE6 RID: 19686 RVA: 0x00140324 File Offset: 0x0013E524
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003226 RID: 12838
			public int <>1__state;

			// Token: 0x04003227 RID: 12839
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04003228 RID: 12840
			public workshop repair;

			// Token: 0x04003229 RID: 12841
			public RepairModel <>4__this;

			// Token: 0x0400322A RID: 12842
			private auseceEntities <ctx>5__2;

			// Token: 0x0400322B RID: 12843
			private workshop <original>5__3;

			// Token: 0x0400322C RID: 12844
			private TaskAwaiter<workshop> <>u__1;

			// Token: 0x0400322D RID: 12845
			private TaskAwaiter <>u__2;

			// Token: 0x0400322E RID: 12846
			private TaskAwaiter<int> <>u__3;
		}

		// Token: 0x02000A46 RID: 2630
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <AdminSaveCard>d__53 : IAsyncStateMachine
		{
			// Token: 0x06004CE7 RID: 19687 RVA: 0x00140340 File Offset: 0x0013E540
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					if (num > 4)
					{
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<workshop> awaiter;
						TaskAwaiter<c_workshop> awaiter2;
						TaskAwaiter awaiter3;
						TaskAwaiter<int> awaiter4;
						switch (num)
						{
						case 0:
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<workshop>);
							int num2 = -1;
							num = -1;
							this.<>1__state = num2;
							break;
						}
						case 1:
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<c_workshop>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
							goto IL_132;
						}
						case 2:
						{
							awaiter3 = this.<>u__3;
							this.<>u__3 = default(TaskAwaiter);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
							goto IL_1B5;
						}
						case 3:
						{
							awaiter4 = this.<>u__4;
							this.<>u__4 = default(TaskAwaiter<int>);
							int num5 = -1;
							num = -1;
							this.<>1__state = num5;
							goto IL_239;
						}
						case 4:
						{
							awaiter3 = this.<>u__3;
							this.<>u__3 = default(TaskAwaiter);
							int num6 = -1;
							num = -1;
							this.<>1__state = num6;
							goto IL_2A0;
						}
						default:
							awaiter = this.<ctx>5__2.workshop.FindAsync(new object[]
							{
								this.repair.id
							}).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num7 = 0;
								num = 0;
								this.<>1__state = num7;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop>, RepairModel.<AdminSaveCard>d__53>(ref awaiter, ref this);
								return;
							}
							break;
						}
						workshop result = awaiter.GetResult();
						this.<original>5__3 = result;
						awaiter2 = this.<ctx>5__2.c_workshop.FindAsync(new object[]
						{
							this.<original>5__3.cartridge
						}).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num8 = 1;
							num = 1;
							this.<>1__state = num8;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<c_workshop>, RepairModel.<AdminSaveCard>d__53>(ref awaiter2, ref this);
							return;
						}
						IL_132:
						c_workshop result2 = awaiter2.GetResult();
						if (result2 != null)
						{
							result2.card_id = this.cardId;
						}
						awaiter3 = Bootstrapper.Container.Resolve<IWorkshopHistoryService>().LogRepairChanges(this.<original>5__3, this.repair).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							int num9 = 2;
							num = 2;
							this.<>1__state = num9;
							this.<>u__3 = awaiter3;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RepairModel.<AdminSaveCard>d__53>(ref awaiter3, ref this);
							return;
						}
						IL_1B5:
						awaiter3.GetResult();
						this.<ctx>5__2.Entry<workshop>(this.<original>5__3).CurrentValues.SetValues(this.repair);
						awaiter4 = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
						if (!awaiter4.IsCompleted)
						{
							int num10 = 3;
							num = 3;
							this.<>1__state = num10;
							this.<>u__4 = awaiter4;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, RepairModel.<AdminSaveCard>d__53>(ref awaiter4, ref this);
							return;
						}
						IL_239:
						awaiter4.GetResult();
						awaiter3 = WorkshopService.SetOrderTitle(this.<original>5__3, this.<ctx>5__2).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							int num11 = 4;
							num = 4;
							this.<>1__state = num11;
							this.<>u__3 = awaiter3;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RepairModel.<AdminSaveCard>d__53>(ref awaiter3, ref this);
							return;
						}
						IL_2A0:
						awaiter3.GetResult();
						this.<original>5__3 = null;
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

			// Token: 0x06004CE8 RID: 19688 RVA: 0x00140680 File Offset: 0x0013E880
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400322F RID: 12847
			public int <>1__state;

			// Token: 0x04003230 RID: 12848
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04003231 RID: 12849
			public workshop repair;

			// Token: 0x04003232 RID: 12850
			public int cardId;

			// Token: 0x04003233 RID: 12851
			private auseceEntities <ctx>5__2;

			// Token: 0x04003234 RID: 12852
			private workshop <original>5__3;

			// Token: 0x04003235 RID: 12853
			private TaskAwaiter<workshop> <>u__1;

			// Token: 0x04003236 RID: 12854
			private TaskAwaiter<c_workshop> <>u__2;

			// Token: 0x04003237 RID: 12855
			private TaskAwaiter <>u__3;

			// Token: 0x04003238 RID: 12856
			private TaskAwaiter<int> <>u__4;
		}

		// Token: 0x02000A47 RID: 2631
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadNonItemBoxes>d__56 : IAsyncStateMachine
		{
			// Token: 0x06004CE9 RID: 19689 RVA: 0x0014069C File Offset: 0x0013E89C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<boxes> result;
				try
				{
					if (num != 0)
					{
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						ConfiguredTaskAwaitable<List<boxes>>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = this.<ctx>5__2.boxes.Where(RepairModel.FreeBoxes(this.currentBoxId)).ToListAsync<boxes>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<List<boxes>>.ConfiguredTaskAwaiter, RepairModel.<LoadNonItemBoxes>d__56>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<List<boxes>>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						List<boxes> list = awaiter.GetResult().OrderBy(new Func<boxes, string>(RepairModel.<>c.<>9.<LoadNonItemBoxes>b__56_0), new NaturalComparer()).ToList<boxes>();
						if (this.includeAll)
						{
							list.Insert(0, new boxes
							{
								name = Lang.t("RemoveFromBox"),
								id = 0
							});
						}
						result = list;
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

			// Token: 0x06004CEA RID: 19690 RVA: 0x0014081C File Offset: 0x0013EA1C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003239 RID: 12857
			public int <>1__state;

			// Token: 0x0400323A RID: 12858
			public AsyncTaskMethodBuilder<List<boxes>> <>t__builder;

			// Token: 0x0400323B RID: 12859
			public int? currentBoxId;

			// Token: 0x0400323C RID: 12860
			public bool includeAll;

			// Token: 0x0400323D RID: 12861
			private auseceEntities <ctx>5__2;

			// Token: 0x0400323E RID: 12862
			private ConfiguredTaskAwaitable<List<boxes>>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000A48 RID: 2632
		[CompilerGenerated]
		private sealed class <>c__DisplayClass57_0
		{
			// Token: 0x06004CEB RID: 19691 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass57_0()
			{
			}

			// Token: 0x0400323F RID: 12863
			public int? currentBoxId;
		}

		// Token: 0x02000A49 RID: 2633
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ChangeRepairInvoice>d__58 : IAsyncStateMachine
		{
			// Token: 0x06004CEC RID: 19692 RVA: 0x00140838 File Offset: 0x0013EA38
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				bool result;
				try
				{
					if (num != 0)
					{
						this.<history>5__2 = new HistoryV2();
					}
					try
					{
						if (num != 0)
						{
							this.<ctx>5__3 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<workshop> awaiter;
							if (num != 0)
							{
								awaiter = this.<ctx>5__3.workshop.FindAsync(new object[]
								{
									this.repairId
								}).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop>, RepairModel.<ChangeRepairInvoice>d__58>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<workshop>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							awaiter.GetResult().invoice = new int?(this.invoice.Id);
							this.<ctx>5__3.SaveChanges();
							this.<history>5__2.AddRepairLog("InvoiceChanged", this.repairId, this.invoice.Num, "");
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
					}
					catch (Exception ex)
					{
						GenericModel.Log.Error(ex, ex.Message);
					}
					result = true;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<history>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<history>5__2 = null;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06004CED RID: 19693 RVA: 0x001409FC File Offset: 0x0013EBFC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003240 RID: 12864
			public int <>1__state;

			// Token: 0x04003241 RID: 12865
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x04003242 RID: 12866
			public int repairId;

			// Token: 0x04003243 RID: 12867
			public IInvoice invoice;

			// Token: 0x04003244 RID: 12868
			private HistoryV2 <history>5__2;

			// Token: 0x04003245 RID: 12869
			private auseceEntities <ctx>5__3;

			// Token: 0x04003246 RID: 12870
			private TaskAwaiter<workshop> <>u__1;
		}

		// Token: 0x02000A4A RID: 2634
		[CompilerGenerated]
		private sealed class <>c__DisplayClass60_0
		{
			// Token: 0x06004CEE RID: 19694 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass60_0()
			{
			}

			// Token: 0x06004CEF RID: 19695 RVA: 0x00140A18 File Offset: 0x0013EC18
			internal bool <MarkDeviceAsCartridgeAsync>b__0(devices d)
			{
				return d.id == this.deviceId;
			}

			// Token: 0x04003247 RID: 12871
			public int deviceId;
		}

		// Token: 0x02000A4B RID: 2635
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <MarkDeviceAsCartridgeAsync>d__60 : IAsyncStateMachine
		{
			// Token: 0x06004CF0 RID: 19696 RVA: 0x00140A34 File Offset: 0x0013EC34
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				bool result2;
				try
				{
					if (num != 0)
					{
						this.<>8__1 = new RepairModel.<>c__DisplayClass60_0();
						this.<>8__1.deviceId = this.deviceId;
					}
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<List<devices>> awaiter;
							if (num != 0)
							{
								awaiter = this.<ctx>5__2.devices.ToListAsync<devices>().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<devices>>, RepairModel.<MarkDeviceAsCartridgeAsync>d__60>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<List<devices>>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							List<devices> result = awaiter.GetResult();
							List<devices>.Enumerator enumerator = result.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									devices devices = enumerator.Current;
									devices.refill = false;
								}
							}
							finally
							{
								if (num < 0)
								{
									((IDisposable)enumerator).Dispose();
								}
							}
							devices devices2 = result.FirstOrDefault(new Func<devices, bool>(this.<>8__1.<MarkDeviceAsCartridgeAsync>b__0));
							if (devices2 == null)
							{
								result2 = false;
								goto IL_16A;
							}
							devices2.refill = true;
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
						GenericModel.Log.Error(ex, ex.Message);
						result2 = false;
						goto IL_16A;
					}
					result2 = true;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_16A:
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06004CF1 RID: 19697 RVA: 0x00140C2C File Offset: 0x0013EE2C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003248 RID: 12872
			public int <>1__state;

			// Token: 0x04003249 RID: 12873
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x0400324A RID: 12874
			public int deviceId;

			// Token: 0x0400324B RID: 12875
			private RepairModel.<>c__DisplayClass60_0 <>8__1;

			// Token: 0x0400324C RID: 12876
			private auseceEntities <ctx>5__2;

			// Token: 0x0400324D RID: 12877
			private TaskAwaiter<List<devices>> <>u__1;
		}

		// Token: 0x02000A4C RID: 2636
		[CompilerGenerated]
		private sealed class <>c__DisplayClass61_0
		{
			// Token: 0x06004CF2 RID: 19698 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass61_0()
			{
			}

			// Token: 0x0400324E RID: 12878
			public List<int> statuses;

			// Token: 0x0400324F RID: 12879
			public int employeeId;
		}

		// Token: 0x02000A4D RID: 2637
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetEmployeeRepairs>d__61 : IAsyncStateMachine
		{
			// Token: 0x06004CF3 RID: 19699 RVA: 0x00140C48 File Offset: 0x0013EE48
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<workshop> result;
				try
				{
					RepairModel.<>c__DisplayClass61_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new RepairModel.<>c__DisplayClass61_0();
						CS$<>8__locals1.statuses = this.statuses;
						CS$<>8__locals1.employeeId = this.employeeId;
						this.<repo>5__2 = new GenericRepository<workshop>();
					}
					try
					{
						TaskAwaiter<IEnumerable<workshop>> awaiter;
						if (num != 0)
						{
							awaiter = this.<repo>5__2.GetAllAsync((workshop r) => CS$<>8__locals1.statuses.Contains(r.state) && r.termsControl && (r.current_manager == CS$<>8__locals1.employeeId || r.master == (int?)CS$<>8__locals1.employeeId), null, "").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<workshop>>, RepairModel.<GetEmployeeRepairs>d__61>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IEnumerable<workshop>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = new List<workshop>(awaiter.GetResult());
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

			// Token: 0x06004CF4 RID: 19700 RVA: 0x00140E98 File Offset: 0x0013F098
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003250 RID: 12880
			public int <>1__state;

			// Token: 0x04003251 RID: 12881
			public AsyncTaskMethodBuilder<List<workshop>> <>t__builder;

			// Token: 0x04003252 RID: 12882
			public List<int> statuses;

			// Token: 0x04003253 RID: 12883
			public int employeeId;

			// Token: 0x04003254 RID: 12884
			private GenericRepository<workshop> <repo>5__2;

			// Token: 0x04003255 RID: 12885
			private TaskAwaiter<IEnumerable<workshop>> <>u__1;
		}

		// Token: 0x02000A4E RID: 2638
		[CompilerGenerated]
		private sealed class <>c__DisplayClass64_0
		{
			// Token: 0x06004CF5 RID: 19701 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass64_0()
			{
			}

			// Token: 0x04003256 RID: 12886
			public int repairId;
		}

		// Token: 0x02000A4F RID: 2639
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetRepairCard>d__64 : IAsyncStateMachine
		{
			// Token: 0x06004CF6 RID: 19702 RVA: 0x00140EB4 File Offset: 0x0013F0B4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IRepairCard result;
				try
				{
					RepairModel.<>c__DisplayClass64_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new RepairModel.<>c__DisplayClass64_0();
						CS$<>8__locals1.repairId = this.repairId;
						this.<repo>5__2 = new GenericRepository<workshop>();
					}
					try
					{
						TaskAwaiter<workshop> awaiter;
						if (num != 0)
						{
							this.<repo>5__2.AsNoTracking();
							awaiter = this.<repo>5__2.GetFirstOrDefaultAsync((workshop r) => r.id == CS$<>8__locals1.repairId, "clients,device_makers,device_models,devices,works,store_int_reserve,field_values").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop>, RepairModel.<GetRepairCard>d__64>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<workshop>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult().ToRepairCard();
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

			// Token: 0x06004CF7 RID: 19703 RVA: 0x00141040 File Offset: 0x0013F240
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003257 RID: 12887
			public int <>1__state;

			// Token: 0x04003258 RID: 12888
			public AsyncTaskMethodBuilder<IRepairCard> <>t__builder;

			// Token: 0x04003259 RID: 12889
			public int repairId;

			// Token: 0x0400325A RID: 12890
			private GenericRepository<workshop> <repo>5__2;

			// Token: 0x0400325B RID: 12891
			private TaskAwaiter<workshop> <>u__1;
		}
	}
}
