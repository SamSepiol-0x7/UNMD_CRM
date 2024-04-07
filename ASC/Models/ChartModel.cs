using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using ASC.Charts.VisitSource;
using ASC.Common.Interfaces;
using ASC.Objects;
using ASC.Objects.Converters;
using ASC.Options;
using ASC.SimpleClasses;
using NLog;

namespace ASC.Models
{
	// Token: 0x0200098D RID: 2445
	public class ChartModel : StoreModel
	{
		// Token: 0x06004A27 RID: 18983 RVA: 0x00127318 File Offset: 0x00125518
		public static Task<List<visit_sources>> LoadVisitSourcesesAsync(bool includeDisabled = false)
		{
			ChartModel.<LoadVisitSourcesesAsync>d__1 <LoadVisitSourcesesAsync>d__;
			<LoadVisitSourcesesAsync>d__.<>t__builder = AsyncTaskMethodBuilder<List<visit_sources>>.Create();
			<LoadVisitSourcesesAsync>d__.includeDisabled = includeDisabled;
			<LoadVisitSourcesesAsync>d__.<>1__state = -1;
			<LoadVisitSourcesesAsync>d__.<>t__builder.Start<ChartModel.<LoadVisitSourcesesAsync>d__1>(ref <LoadVisitSourcesesAsync>d__);
			return <LoadVisitSourcesesAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06004A28 RID: 18984 RVA: 0x0012735C File Offset: 0x0012555C
		public Task<List<IVisitSourceChartItem>> LoadVisitChartData(IPeriod period, int officeId, int deviceId)
		{
			ChartModel.<LoadVisitChartData>d__2 <LoadVisitChartData>d__;
			<LoadVisitChartData>d__.<>t__builder = AsyncTaskMethodBuilder<List<IVisitSourceChartItem>>.Create();
			<LoadVisitChartData>d__.period = period;
			<LoadVisitChartData>d__.officeId = officeId;
			<LoadVisitChartData>d__.deviceId = deviceId;
			<LoadVisitChartData>d__.<>1__state = -1;
			<LoadVisitChartData>d__.<>t__builder.Start<ChartModel.<LoadVisitChartData>d__2>(ref <LoadVisitChartData>d__);
			return <LoadVisitChartData>d__.<>t__builder.Task;
		}

		// Token: 0x06004A29 RID: 18985 RVA: 0x001273B0 File Offset: 0x001255B0
		public Task<List<CustomerCard>> LoadVisitChartDataDetails(IPeriod period, int officeId, int deviceId, List<int> selectedIds)
		{
			ChartModel.<LoadVisitChartDataDetails>d__3 <LoadVisitChartDataDetails>d__;
			<LoadVisitChartDataDetails>d__.<>t__builder = AsyncTaskMethodBuilder<List<CustomerCard>>.Create();
			<LoadVisitChartDataDetails>d__.period = period;
			<LoadVisitChartDataDetails>d__.officeId = officeId;
			<LoadVisitChartDataDetails>d__.deviceId = deviceId;
			<LoadVisitChartDataDetails>d__.selectedIds = selectedIds;
			<LoadVisitChartDataDetails>d__.<>1__state = -1;
			<LoadVisitChartDataDetails>d__.<>t__builder.Start<ChartModel.<LoadVisitChartDataDetails>d__3>(ref <LoadVisitChartDataDetails>d__);
			return <LoadVisitChartDataDetails>d__.<>t__builder.Task;
		}

		// Token: 0x06004A2A RID: 18986 RVA: 0x0012740C File Offset: 0x0012560C
		public static bool SaveVisitSources(visit_sources source)
		{
			bool result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					auseceEntities.visit_sources.Attach(source);
					auseceEntities.Entry<visit_sources>(source).State = EntityState.Modified;
					auseceEntities.SaveChanges();
					result = true;
				}
			}
			catch (Exception exception)
			{
				ChartModel.Log.Error(exception, "Save visit source fail");
				result = false;
			}
			return result;
		}

		// Token: 0x06004A2B RID: 18987 RVA: 0x00127484 File Offset: 0x00125684
		public static bool AddNewVisitSource(visit_sources source)
		{
			bool result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					auseceEntities.visit_sources.Add(source);
					auseceEntities.SaveChanges();
					result = true;
				}
			}
			catch (Exception exception)
			{
				ChartModel.Log.Error(exception, "Save visit source fail");
				result = false;
			}
			return result;
		}

		// Token: 0x06004A2C RID: 18988 RVA: 0x001274EC File Offset: 0x001256EC
		public List<VisitTriggers> GetTriggers(List<int> existTriggers)
		{
			List<VisitTriggers> list = new List<VisitTriggers>
			{
				new VisitTriggers
				{
					Id = new int?(1),
					Name = (string)Application.Current.TryFindResource("WasInService")
				},
				new VisitTriggers
				{
					Id = new int?(2),
					Name = (string)Application.Current.TryFindResource("IsRegular")
				},
				new VisitTriggers
				{
					Id = new int?(3),
					Name = (string)Application.Current.TryFindResource("ExistClient")
				},
				new VisitTriggers
				{
					Id = new int?(4),
					Name = (string)Application.Current.TryFindResource("WarrantyRepair")
				}
			};
			foreach (VisitTriggers visitTriggers in list)
			{
				if (visitTriggers.Id != null && existTriggers.Contains(visitTriggers.Id.Value))
				{
					visitTriggers.Enable = false;
				}
			}
			list.Insert(0, new VisitTriggers
			{
				Id = null,
				Name = (string)Application.Current.TryFindResource("Clear"),
				Enable = true
			});
			return list;
		}

		// Token: 0x06004A2D RID: 18989 RVA: 0x00127668 File Offset: 0x00125868
		public Task<Dictionary<string, int>> LoadCallsPeriodData(int option, Period period, users user, voip_ext_devices extDevice, int clientType)
		{
			ChartModel.<LoadCallsPeriodData>d__7 <LoadCallsPeriodData>d__;
			<LoadCallsPeriodData>d__.<>t__builder = AsyncTaskMethodBuilder<Dictionary<string, int>>.Create();
			<LoadCallsPeriodData>d__.<>4__this = this;
			<LoadCallsPeriodData>d__.option = option;
			<LoadCallsPeriodData>d__.period = period;
			<LoadCallsPeriodData>d__.user = user;
			<LoadCallsPeriodData>d__.extDevice = extDevice;
			<LoadCallsPeriodData>d__.clientType = clientType;
			<LoadCallsPeriodData>d__.<>1__state = -1;
			<LoadCallsPeriodData>d__.<>t__builder.Start<ChartModel.<LoadCallsPeriodData>d__7>(ref <LoadCallsPeriodData>d__);
			return <LoadCallsPeriodData>d__.<>t__builder.Task;
		}

		// Token: 0x06004A2E RID: 18990 RVA: 0x001276D8 File Offset: 0x001258D8
		private IQueryable<cdr> NewOrExistCustomer(int clientType, auseceEntities ctx, IQueryable<cdr> cdr)
		{
			if (clientType == 1)
			{
				cdr = cdr.Where(this.NewCustomer(ctx));
			}
			if (clientType == 2)
			{
				cdr = cdr.Where(this.ExistCustomer(ctx));
			}
			return cdr;
		}

		// Token: 0x06004A2F RID: 18991 RVA: 0x0012770C File Offset: 0x0012590C
		private Expression<Func<cdr, bool>> ExistCustomer(auseceEntities ctx)
		{
			return (cdr i) => ctx.tel.Any((tel c) => c.phone_clean.Contains(i.dst) || i.src.Contains(c.phone_clean));
		}

		// Token: 0x06004A30 RID: 18992 RVA: 0x0012785C File Offset: 0x00125A5C
		private Expression<Func<cdr, bool>> NewCustomer(auseceEntities ctx)
		{
			return (cdr i) => !ctx.tel.Any((tel c) => c.phone_clean.Contains(i.dst) && i.src.Contains(c.phone_clean));
		}

		// Token: 0x06004A31 RID: 18993 RVA: 0x001279B0 File Offset: 0x00125BB0
		public int CountCalls(Period period, users user, voip_ext_devices extDevice, int clientType, bool incoming)
		{
			int result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					IQueryable<cdr> queryable = from i in auseceEntities.cdr.Where(this.InPeriod(period))
					where i.dcontext.Contains("from") == incoming
					select i;
					queryable = ChartModel.UserFilter(user, queryable);
					queryable = ChartModel.DeviceFilter(extDevice, queryable);
					queryable = this.NewOrExistCustomer(clientType, auseceEntities, queryable);
					result = (from i in queryable
					group i by i.uniqueid).Count<IGrouping<string, cdr>>();
				}
			}
			catch (Exception exception)
			{
				ChartModel.Log.Error(exception, "Count calls fail");
				result = 0;
			}
			return result;
		}

		// Token: 0x06004A32 RID: 18994 RVA: 0x00127B34 File Offset: 0x00125D34
		public Expression<Func<cdr, bool>> InPeriod(Period period)
		{
			DateTime from = period.From.Date;
			DateTime to = period.To.Date.AddDays(1.0).AddSeconds(-1.0);
			return (cdr o) => o.calldate >= from && o.calldate <= to;
		}

		// Token: 0x06004A33 RID: 18995 RVA: 0x00127C4C File Offset: 0x00125E4C
		private static IQueryable<cdr> DeviceFilter(voip_ext_devices extDevice, IQueryable<cdr> cdr)
		{
			if (extDevice != null && extDevice.id != 0)
			{
				cdr = cdr.Where(ChartModel.ChannelsMatch(extDevice.name));
			}
			return cdr;
		}

		// Token: 0x06004A34 RID: 18996 RVA: 0x00127C78 File Offset: 0x00125E78
		private static IQueryable<cdr> UserFilter(users user, IQueryable<cdr> cdr)
		{
			if (user != null && user.sip_user_id != null)
			{
				int? sip_user_id = user.sip_user_id;
				if (!(sip_user_id.GetValueOrDefault() == 0 & sip_user_id != null))
				{
					string phone = user.sip_user_id.ToString();
					cdr = cdr.Where(ChartModel.ChannelsMatch(phone));
				}
			}
			return cdr;
		}

		// Token: 0x06004A35 RID: 18997 RVA: 0x00127CD8 File Offset: 0x00125ED8
		public TimeSpan CountTotalTimeLength(Period period, users user, voip_ext_devices extDevice, int clientType, bool? incoming)
		{
			TimeSpan result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					IQueryable<cdr> queryable = auseceEntities.cdr.Where(this.InPeriod(period));
					if (incoming != null)
					{
						queryable = from i in queryable
						where (bool?)i.dcontext.Contains("from") == incoming
						select i;
					}
					queryable = ChartModel.UserFilter(user, queryable);
					queryable = ChartModel.DeviceFilter(extDevice, queryable);
					queryable = this.NewOrExistCustomer(clientType, auseceEntities, queryable);
					result = TimeSpan.FromSeconds((double)(from i in queryable
					select i.billsec).DefaultIfEmpty(0).Sum());
				}
			}
			catch (Exception exception)
			{
				ChartModel.Log.Error(exception, "Count calls total time lenght fail");
				result = TimeSpan.FromSeconds(0.0);
			}
			return result;
		}

		// Token: 0x06004A36 RID: 18998 RVA: 0x00127E98 File Offset: 0x00126098
		private static Expression<Func<cdr, bool>> ChannelsMatch(string phone)
		{
			return (cdr i) => i.channel.Contains(phone) || i.dstchannel.Contains(phone) || i.dst.Contains(phone);
		}

		// Token: 0x06004A37 RID: 18999 RVA: 0x00127FD4 File Offset: 0x001261D4
		public List<voip_ext_devices> LoadVoipExtDevices()
		{
			List<voip_ext_devices> list = new List<voip_ext_devices>
			{
				new voip_ext_devices
				{
					id = 0,
					phone = (string)Application.Current.TryFindResource("AllDevices")
				}
			};
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					list.AddRange(auseceEntities.voip_ext_devices.ToList<voip_ext_devices>());
				}
			}
			catch (Exception exception)
			{
				ChartModel.Log.Error(exception, "Load devices fail");
			}
			return list;
		}

		// Token: 0x06004A38 RID: 19000 RVA: 0x0012806C File Offset: 0x0012626C
		public List<users> LoadUsers()
		{
			List<users> list = new List<users>
			{
				this.AllUsersOption()
			};
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					List<users> collection = (from u in auseceEntities.users
					where u.state == (int?)1 && u.sip_user_id != null
					select u).ToList<users>();
					list.AddRange(collection);
				}
			}
			catch (Exception exception)
			{
				ChartModel.Log.Error(exception, "Load users fail");
			}
			return list;
		}

		// Token: 0x06004A39 RID: 19001 RVA: 0x0012818C File Offset: 0x0012638C
		private users AllUsersOption()
		{
			return new users
			{
				id = 0,
				surname = (string)Application.Current.TryFindResource("AllUsers")
			};
		}

		// Token: 0x06004A3A RID: 19002 RVA: 0x001281C0 File Offset: 0x001263C0
		public static Task<IEnumerable<IRepairCardForReport>> LoadEmployeeRepairs(IPeriod period, int officeId, int employeeId, int deviceId, int state)
		{
			ChartModel.<LoadEmployeeRepairs>d__21 <LoadEmployeeRepairs>d__;
			<LoadEmployeeRepairs>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<IRepairCardForReport>>.Create();
			<LoadEmployeeRepairs>d__.period = period;
			<LoadEmployeeRepairs>d__.officeId = officeId;
			<LoadEmployeeRepairs>d__.employeeId = employeeId;
			<LoadEmployeeRepairs>d__.deviceId = deviceId;
			<LoadEmployeeRepairs>d__.state = state;
			<LoadEmployeeRepairs>d__.<>1__state = -1;
			<LoadEmployeeRepairs>d__.<>t__builder.Start<ChartModel.<LoadEmployeeRepairs>d__21>(ref <LoadEmployeeRepairs>d__);
			return <LoadEmployeeRepairs>d__.<>t__builder.Task;
		}

		// Token: 0x06004A3B RID: 19003 RVA: 0x00128224 File Offset: 0x00126424
		private static Func<workshop, RepairCardForReport> RepairCardConvert(int employeeId = 0)
		{
			return delegate(workshop r)
			{
				RepairCardForReport repairCardForReport = new RepairCardForReport();
				repairCardForReport.Id = r.id;
				repairCardForReport.CompanyId = r.company;
				repairCardForReport.OfficeId = r.office;
				repairCardForReport.InDateTime = r.in_date;
				repairCardForReport.Status = r.state;
				repairCardForReport.FullDeviceName = r.Title;
				repairCardForReport.SerialNumber = r.serial_number;
				repairCardForReport.BarCode = r.barcode;
				repairCardForReport.ExtNotes = r.ext_notes;
				repairCardForReport.PrepaidType = new int?(r.prepaid_type);
				repairCardForReport.PrepaidSumm = new decimal?(r.prepaid_summ);
				repairCardForReport.PreviousRepair = r.early;
				repairCardForReport.IsPrepaid = r.is_prepaid;
				repairCardForReport.IsPreAgreed = r.is_pre_agreed;
				repairCardForReport.IsWarranty = r.is_warranty;
				repairCardForReport.IsRepeat = r.is_repeat;
				repairCardForReport.CanFormat = r.can_format;
				repairCardForReport.ExpressRepair = r.express_repair.GetValueOrDefault();
				repairCardForReport.ThirdPartySc = r.thirs_party_sc;
				repairCardForReport.MasterId = r.master;
				repairCardForReport.ManagerId = r.current_manager;
				repairCardForReport.BoxId = r.box;
				repairCardForReport.InformStatus = r.informed_status;
				repairCardForReport.Fault = r.fault;
				repairCardForReport.Complect = r.complect;
				repairCardForReport.Look = r.look;
				repairCardForReport.DiagnosticResult = r.diagnostic_result;
				repairCardForReport.RejectReason = r.reject_reason;
				repairCardForReport.RepairCost = r.repair_cost;
				repairCardForReport.RealRepairCost = r.real_repair_cost;
				repairCardForReport.PreAgreedSumm = r.pre_agreed_amount;
				repairCardForReport.OutDate = r.out_date;
				repairCardForReport.WorksAndParts = new ObservableCollection<IWorkPartObject>(RepairModel.WorksAndPartsConvert(r.works.ToList<works>(), r.store_int_reserve.ToList<store_int_reserve>(), 0));
				repairCardForReport.ManagerPart = ChartModel.GetManagerPart(r);
				repairCardForReport.MasterFio = r.MasterFio;
				repairCardForReport.AllPartsCost = r.store_int_reserve.Sum((store_int_reserve s) => s.price * s.count);
				repairCardForReport.AllPartsInSumm = r.store_int_reserve.Sum((store_int_reserve s) => s.store_items.in_price * s.count);
				repairCardForReport.ManagerGoodsPart = r.store_int_reserve.Sum((store_int_reserve s) => s.price * s.count / 100m * s.users.pay_repair_q_sale);
				repairCardForReport.CustomerVisitSource = r.clients.visit_source;
				repairCardForReport.SetStatusColor();
				repairCardForReport.CalcWorksCost(employeeId);
				repairCardForReport.CalcAllWorksSumm();
				repairCardForReport.CalcPartsSumm(employeeId);
				repairCardForReport.CalcMasterPart(employeeId);
				repairCardForReport.CallAllMastersPart();
				repairCardForReport.CalcProfit();
				repairCardForReport.FillMastersFio();
				return repairCardForReport;
			};
		}

		// Token: 0x06004A3C RID: 19004 RVA: 0x00128248 File Offset: 0x00126448
		public static decimal GetManagerPart(workshop r)
		{
			int pay_device_in = r.users2.pay_device_in;
			int pay_device_out = r.users3.pay_device_out;
			return pay_device_in + pay_device_out;
		}

		// Token: 0x06004A3D RID: 19005 RVA: 0x00128274 File Offset: 0x00126474
		public Task<List<KeyValuePair<string, int>>> LoadPartsChartData(int storeId)
		{
			ChartModel.<LoadPartsChartData>d__24 <LoadPartsChartData>d__;
			<LoadPartsChartData>d__.<>t__builder = AsyncTaskMethodBuilder<List<KeyValuePair<string, int>>>.Create();
			<LoadPartsChartData>d__.<>4__this = this;
			<LoadPartsChartData>d__.storeId = storeId;
			<LoadPartsChartData>d__.<>1__state = -1;
			<LoadPartsChartData>d__.<>t__builder.Start<ChartModel.<LoadPartsChartData>d__24>(ref <LoadPartsChartData>d__);
			return <LoadPartsChartData>d__.<>t__builder.Task;
		}

		// Token: 0x06004A3E RID: 19006 RVA: 0x001282C0 File Offset: 0x001264C0
		public Task<int> CountTotalParts(int storeId)
		{
			ChartModel.<CountTotalParts>d__25 <CountTotalParts>d__;
			<CountTotalParts>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<CountTotalParts>d__.storeId = storeId;
			<CountTotalParts>d__.<>1__state = -1;
			<CountTotalParts>d__.<>t__builder.Start<ChartModel.<CountTotalParts>d__25>(ref <CountTotalParts>d__);
			return <CountTotalParts>d__.<>t__builder.Task;
		}

		// Token: 0x06004A3F RID: 19007 RVA: 0x00128304 File Offset: 0x00126504
		public Task<decimal> CountTotalInSumm(int storeId)
		{
			ChartModel.<CountTotalInSumm>d__26 <CountTotalInSumm>d__;
			<CountTotalInSumm>d__.<>t__builder = AsyncTaskMethodBuilder<decimal>.Create();
			<CountTotalInSumm>d__.storeId = storeId;
			<CountTotalInSumm>d__.<>1__state = -1;
			<CountTotalInSumm>d__.<>t__builder.Start<ChartModel.<CountTotalInSumm>d__26>(ref <CountTotalInSumm>d__);
			return <CountTotalInSumm>d__.<>t__builder.Task;
		}

		// Token: 0x06004A40 RID: 19008 RVA: 0x00128348 File Offset: 0x00126548
		public Task<decimal> CountTotalOutSummPrice2(int storeId)
		{
			ChartModel.<CountTotalOutSummPrice2>d__27 <CountTotalOutSummPrice2>d__;
			<CountTotalOutSummPrice2>d__.<>t__builder = AsyncTaskMethodBuilder<decimal>.Create();
			<CountTotalOutSummPrice2>d__.storeId = storeId;
			<CountTotalOutSummPrice2>d__.<>1__state = -1;
			<CountTotalOutSummPrice2>d__.<>t__builder.Start<ChartModel.<CountTotalOutSummPrice2>d__27>(ref <CountTotalOutSummPrice2>d__);
			return <CountTotalOutSummPrice2>d__.<>t__builder.Task;
		}

		// Token: 0x06004A41 RID: 19009 RVA: 0x0012838C File Offset: 0x0012658C
		public Task<List<SalesInfo2>> LoadRepairsPeriodData(Period period, int officeId, int device, int deviceMaker, int typeInOut)
		{
			ChartModel.<LoadRepairsPeriodData>d__28 <LoadRepairsPeriodData>d__;
			<LoadRepairsPeriodData>d__.<>t__builder = AsyncTaskMethodBuilder<List<SalesInfo2>>.Create();
			<LoadRepairsPeriodData>d__.period = period;
			<LoadRepairsPeriodData>d__.officeId = officeId;
			<LoadRepairsPeriodData>d__.device = device;
			<LoadRepairsPeriodData>d__.deviceMaker = deviceMaker;
			<LoadRepairsPeriodData>d__.typeInOut = typeInOut;
			<LoadRepairsPeriodData>d__.<>1__state = -1;
			<LoadRepairsPeriodData>d__.<>t__builder.Start<ChartModel.<LoadRepairsPeriodData>d__28>(ref <LoadRepairsPeriodData>d__);
			return <LoadRepairsPeriodData>d__.<>t__builder.Task;
		}

		// Token: 0x06004A42 RID: 19010 RVA: 0x001283F4 File Offset: 0x001265F4
		public RepairsStat LoadInStatistic(Period period, int device, int maker)
		{
			double totalDays = (period.To.Date.AddDays(1.0).AddSeconds(-1.0) - period.From.Date).TotalDays;
			RepairsStat repairsStat = new RepairsStat();
			this.CountTotalIn(period, repairsStat, device, maker);
			this.CountTotalInWarranty(period, repairsStat, device, maker);
			this.CountRepeatIn(period, repairsStat, device, maker);
			repairsStat.RepairsPerDay = Math.Round((double)repairsStat.TotalRepairIn / totalDays, 2);
			return repairsStat;
		}

		// Token: 0x06004A43 RID: 19011 RVA: 0x00128488 File Offset: 0x00126688
		public RepairsStat LoadOutStatistic(Period period, int device, int maker, bool ExcludeZeroFromMinPrice)
		{
			period.From = period.From.Date;
			period.To = period.To.Date.AddDays(1.0).AddSeconds(-1.0);
			double num = Math.Abs((period.To - period.From).TotalDays);
			RepairsStat repairsStat = new RepairsStat();
			this.CountTotalOut(period, repairsStat, device, maker);
			repairsStat.RepairsPerDay = Math.Round((double)repairsStat.TotalRepairOut / num, 2);
			this.GetMinPrice(period, repairsStat, device, maker, ExcludeZeroFromMinPrice);
			this.GetMaxPrice(period, repairsStat, device, maker);
			this.NoRepairOut(period, device, maker, repairsStat);
			this.ReadyRepairNotOk(period, device, maker, repairsStat);
			this.ReadyRepairOk(period, device, maker, repairsStat);
			int num2 = this.PeriodOutOkTotal(period, device, maker);
			if (num2 != 0)
			{
				this.CountTotalRepairOk(period, repairsStat, device, maker);
				this.CountTotalRepairOkWarranty(period, repairsStat, device, maker);
				repairsStat.AveragePrice = num2 / repairsStat.TotalRepairOk;
			}
			return repairsStat;
		}

		// Token: 0x06004A44 RID: 19012 RVA: 0x00128588 File Offset: 0x00126788
		private void NoRepairOut(Period period, int device, int maker, RepairsStat stat)
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					IQueryable<workshop> queryable = from r in auseceEntities.workshop.AsNoTracking().Where(this.outSelectedPeriod(period))
					where r.state == 12
					select r;
					queryable = this.DeviceFilter(device, queryable);
					queryable = this.MakerFilter(maker, queryable);
					stat.TotalNoRepairOut = queryable.Count<workshop>();
				}
			}
			catch (Exception exception)
			{
				ChartModel.Log.Error(exception, "No repair out count fail");
			}
		}

		// Token: 0x06004A45 RID: 19013 RVA: 0x0012866C File Offset: 0x0012686C
		private void ReadyRepairNotOk(IPeriod period, int device, int maker, RepairsStat stat)
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					IQueryable<workshop> queryable = from r in auseceEntities.workshop.AsNoTracking().Where(this.outSelectedPeriod(period))
					where r.state == 7
					select r;
					queryable = this.DeviceFilter(device, queryable);
					queryable = this.MakerFilter(maker, queryable);
					stat.ReadyRepairNotOk = queryable.Count<workshop>();
				}
			}
			catch (Exception exception)
			{
				ChartModel.Log.Error(exception, "Ready repair not ok count fail");
			}
		}

		// Token: 0x06004A46 RID: 19014 RVA: 0x0012874C File Offset: 0x0012694C
		private void ReadyRepairOk(Period period, int device, int maker, RepairsStat stat)
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					IQueryable<workshop> queryable = from r in auseceEntities.workshop.AsNoTracking().Where(this.outSelectedPeriod(period))
					where r.state == 6
					select r;
					queryable = this.DeviceFilter(device, queryable);
					queryable = this.MakerFilter(maker, queryable);
					stat.ReadyRepairOk = queryable.Count<workshop>();
				}
			}
			catch (Exception exception)
			{
				ChartModel.Log.Error(exception, "Ready repair ok count fail");
				throw;
			}
		}

		// Token: 0x06004A47 RID: 19015 RVA: 0x0012882C File Offset: 0x00126A2C
		private int PeriodOutOkTotal(IPeriod period, int device, int maker)
		{
			int result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					IQueryable<workshop> queryable = from r in auseceEntities.workshop.AsNoTracking().Where(this.outSelectedPeriod(period))
					where r.state == 8
					select r;
					queryable = this.DeviceFilter(device, queryable);
					queryable = this.MakerFilter(maker, queryable);
					result = (int)(from r in queryable
					select r.real_repair_cost).DefaultIfEmpty<decimal>().Sum();
				}
			}
			catch (Exception exception)
			{
				ChartModel.Log.Error(exception, "Period out ok count fail");
				result = 0;
			}
			return result;
		}

		// Token: 0x06004A48 RID: 19016 RVA: 0x00128954 File Offset: 0x00126B54
		private void CountTotalRepairOk(Period period, RepairsStat stat, int device, int maker)
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					IQueryable<workshop> queryable = auseceEntities.workshop.AsNoTracking().Where(this.outSelectedPeriod(period));
					queryable = this.DeviceFilter(device, queryable);
					queryable = this.MakerFilter(maker, queryable);
					stat.TotalRepairOk = queryable.Count((workshop r) => r.state == 8 && r.is_warranty == false);
				}
			}
			catch (Exception exception)
			{
				ChartModel.Log.Error(exception, "Count total repair ok fail");
			}
		}

		// Token: 0x06004A49 RID: 19017 RVA: 0x00128A64 File Offset: 0x00126C64
		private void CountTotalRepairOkWarranty(Period period, RepairsStat stat, int device, int maker)
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					IQueryable<workshop> queryable = auseceEntities.workshop.AsNoTracking().Where(this.outSelectedPeriod(period));
					queryable = this.DeviceFilter(device, queryable);
					queryable = this.MakerFilter(maker, queryable);
					stat.TotalRepairOkWarranty = queryable.Count((workshop r) => r.state == 8 && r.is_warranty);
				}
			}
			catch (Exception exception)
			{
				ChartModel.Log.Error(exception, "Count total repair ok warranty count");
			}
		}

		// Token: 0x06004A4A RID: 19018 RVA: 0x00128B5C File Offset: 0x00126D5C
		private void GetMaxPrice(IPeriod period, RepairsStat stat, int device, int maker)
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					IQueryable<workshop> queryable = from r in auseceEntities.workshop.AsNoTracking().Where(this.outSelectedPeriod(period))
					where r.state == 8
					select r;
					queryable = this.DeviceFilter(device, queryable);
					queryable = this.MakerFilter(maker, queryable);
					stat.MaxPrice = (int)(from r in queryable
					orderby r.real_repair_cost descending
					select r.real_repair_cost).FirstOrDefault<decimal>();
				}
			}
			catch (Exception exception)
			{
				ChartModel.Log.Error(exception, " Get max price fail");
			}
		}

		// Token: 0x06004A4B RID: 19019 RVA: 0x00128CD8 File Offset: 0x00126ED8
		private void GetMinPrice(IPeriod period, RepairsStat stat, int device, int maker, bool ExcludeZeroFromMinPrice)
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					IQueryable<workshop> queryable = from r in auseceEntities.workshop.AsNoTracking().Where(this.outSelectedPeriod(period))
					where r.state == 8 && r.is_warranty == false
					select r;
					queryable = this.DeviceFilter(device, queryable);
					queryable = this.MakerFilter(maker, queryable);
					if (ExcludeZeroFromMinPrice)
					{
						queryable = from r in queryable
						where r.real_repair_cost > 0m
						select r;
					}
					stat.MinPrice = (int)(from r in queryable
					orderby r.real_repair_cost
					select r.real_repair_cost).FirstOrDefault<decimal>();
				}
			}
			catch (Exception exception)
			{
				ChartModel.Log.Error(exception, "Get min price fail");
				throw;
			}
		}

		// Token: 0x06004A4C RID: 19020 RVA: 0x00128EE8 File Offset: 0x001270E8
		private void CountTotalIn(Period period, RepairsStat stat, int device, int maker)
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					IQueryable<workshop> queryable = auseceEntities.workshop.Where(this.inSelectedPeriod(period)).AsNoTracking<workshop>();
					queryable = this.DeviceFilter(device, queryable);
					queryable = this.MakerFilter(maker, queryable);
					stat.TotalRepairIn = queryable.Count<workshop>();
				}
			}
			catch (Exception exception)
			{
				ChartModel.Log.Error(exception, "Count total in fail");
			}
		}

		// Token: 0x06004A4D RID: 19021 RVA: 0x00128F70 File Offset: 0x00127170
		private void CountTotalOut(Period period, RepairsStat stat, int device, int maker)
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					IQueryable<workshop> queryable = auseceEntities.workshop.AsNoTracking().Where(this.outSelectedPeriod(period));
					queryable = this.DeviceFilter(device, queryable);
					queryable = this.MakerFilter(maker, queryable);
					stat.TotalRepairOut = queryable.Count((workshop r) => r.state == 8 || r.state == 12);
				}
			}
			catch (Exception exception)
			{
				ChartModel.Log.Error(exception, "Count total out fail");
				throw;
			}
		}

		// Token: 0x06004A4E RID: 19022 RVA: 0x00129080 File Offset: 0x00127280
		private void CountTotalInWarranty(Period period, RepairsStat stat, int device, int maker)
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					IQueryable<workshop> queryable = (from r in auseceEntities.workshop.Where(this.inSelectedPeriod(period))
					where r.is_warranty
					select r).AsNoTracking<workshop>();
					queryable = this.DeviceFilter(device, queryable);
					queryable = this.MakerFilter(maker, queryable);
					stat.WarrantyRepairIn = queryable.Count<workshop>();
				}
			}
			catch (Exception exception)
			{
				ChartModel.Log.Error(exception, "Count tottal in warranty fail");
			}
		}

		// Token: 0x06004A4F RID: 19023 RVA: 0x00129148 File Offset: 0x00127348
		private void CountRepeatIn(Period period, RepairsStat stat, int device, int maker)
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					IQueryable<workshop> queryable = (from r in auseceEntities.workshop.Where(this.inSelectedPeriod(period))
					where r.is_repeat
					select r).AsNoTracking<workshop>();
					queryable = this.DeviceFilter(device, queryable);
					queryable = this.MakerFilter(maker, queryable);
					stat.RepeatIn = queryable.Count<workshop>();
				}
			}
			catch (Exception exception)
			{
				ChartModel.Log.Error(exception, "Count repeat in fail");
			}
		}

		// Token: 0x06004A50 RID: 19024 RVA: 0x00129210 File Offset: 0x00127410
		private IQueryable<workshop> DeviceFilter(int device, IQueryable<workshop> result)
		{
			if (device != 0)
			{
				result = from r in result
				where r.type == device
				select r;
			}
			return result;
		}

		// Token: 0x06004A51 RID: 19025 RVA: 0x00129298 File Offset: 0x00127498
		private IQueryable<workshop> MakerFilter(int maker, IQueryable<workshop> result)
		{
			if (maker > 0)
			{
				result = from r in result
				where r.maker == maker
				select r;
			}
			return result;
		}

		// Token: 0x06004A52 RID: 19026 RVA: 0x00129324 File Offset: 0x00127524
		private Expression<Func<workshop, bool>> inSelectedPeriod(IPeriod period)
		{
			DateTime from = period.From.Date;
			DateTime to = period.To.Date.AddDays(1.0).AddSeconds(-1.0);
			return (workshop i) => i.in_date >= from && i.in_date <= to;
		}

		// Token: 0x06004A53 RID: 19027 RVA: 0x0012943C File Offset: 0x0012763C
		private Expression<Func<workshop, bool>> outSelectedPeriod(IPeriod period)
		{
			DateTime from = period.From.Date;
			DateTime to = period.To.Date.AddDays(1.0).AddSeconds(-1.0);
			return (workshop i) => i.out_date != null && i.out_date >= (DateTime?)from && i.out_date <= (DateTime?)to;
		}

		// Token: 0x06004A54 RID: 19028 RVA: 0x001295C0 File Offset: 0x001277C0
		public IEnumerable<SalesInfo2> LoadSaleCategoriesChartData(Period period)
		{
			List<SalesInfo2> list = new List<SalesInfo2>();
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					DateTime from = period.From.Date;
					DateTime to = period.To.AddHours(23.0).AddMinutes(59.0).AddSeconds(59.0);
					List<int> docIds = (from i in auseceEntities.docs
					where i.type == 2 && i.state == (int?)5 && i.created >= @from && i.created <= to
					select i.id).ToList<int>();
					foreach (store_sales store_sales in (from s in auseceEntities.store_sales.AsNoTracking()
					where docIds.Contains(s.document_id)
					select s).ToList<store_sales>())
					{
						string category = (store_sales.store_items.store_cats.parent != null) ? (store_sales.store_items.store_cats.store_cats2.name + " > " + store_sales.store_items.store_cats.name) : store_sales.store_items.store_cats.name;
						DateTime created = store_sales.docs.created;
						decimal total = store_sales.count * store_sales.price;
						list.Add(new SalesInfo2
						{
							Category = category,
							Date = created,
							Total = total
						});
					}
				}
			}
			catch (Exception exception)
			{
				ChartModel.Log.Error(exception, "Load Sale Categories Chart Data fail");
			}
			return list;
		}

		// Token: 0x06004A55 RID: 19029 RVA: 0x001299A4 File Offset: 0x00127BA4
		public Task<List<SalesInfo2>> LoadSalesChartData(Period period, int officeId, int userId)
		{
			ChartModel.<LoadSalesChartData>d__48 <LoadSalesChartData>d__;
			<LoadSalesChartData>d__.<>t__builder = AsyncTaskMethodBuilder<List<SalesInfo2>>.Create();
			<LoadSalesChartData>d__.<>4__this = this;
			<LoadSalesChartData>d__.period = period;
			<LoadSalesChartData>d__.officeId = officeId;
			<LoadSalesChartData>d__.userId = userId;
			<LoadSalesChartData>d__.<>1__state = -1;
			<LoadSalesChartData>d__.<>t__builder.Start<ChartModel.<LoadSalesChartData>d__48>(ref <LoadSalesChartData>d__);
			return <LoadSalesChartData>d__.<>t__builder.Task;
		}

		// Token: 0x06004A56 RID: 19030 RVA: 0x00129A00 File Offset: 0x00127C00
		public IEnumerable<SalesReportDto> LoadSalesInPeriod(Period period, int officeId, int userId)
		{
			DateTime from = period.From.Date;
			DateTime to = period.To.Date.AddHours(23.0).AddMinutes(59.0).AddSeconds(59.0);
			IEnumerable<SalesReportDto> result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					IQueryable<store_sales> queryable = from i in auseceEntities.store_sales.AsNoTracking()
					where i.docs.type == 2 && i.docs.state == (int?)5 && i.docs.created >= @from && i.docs.created <= to
					select i;
					queryable = this.OfficeFilter(officeId, queryable);
					queryable = this.UserFilter(userId, queryable);
					ParameterExpression parameterExpression;
					result = queryable.Select(System.Linq.Expressions.Expression.Lambda<Func<store_sales, SalesReportDto>>(System.Linq.Expressions.Expression.MemberInit(System.Linq.Expressions.Expression.New(typeof(SalesReportDto)), new MemberBinding[]
					{
						System.Linq.Expressions.Expression.Bind(methodof(SalesReportDto.set_ProductId(int)), System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(store_sales.get_store_items())), methodof(store_items.get_id()))),
						System.Linq.Expressions.Expression.Bind(methodof(SalesReportDto.set_ProductArticul(int)), System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(store_sales.get_store_items())), methodof(store_items.get_articul()))),
						System.Linq.Expressions.Expression.Bind(methodof(SalesReportDto.set_ProductName(string)), System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(store_sales.get_store_items())), methodof(store_items.get_name()))),
						System.Linq.Expressions.Expression.Bind(methodof(SalesReportDto.set_DocumentId(int)), System.Linq.Expressions.Expression.Property(parameterExpression, methodof(store_sales.get_document_id()))),
						System.Linq.Expressions.Expression.Bind(methodof(SalesReportDto.set_Date(DateTime)), System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(store_sales.get_docs())), methodof(docs.get_created()))),
						System.Linq.Expressions.Expression.Bind(methodof(SalesReportDto.set_Employee(IEmployee)), System.Linq.Expressions.Expression.MemberInit(System.Linq.Expressions.Expression.New(typeof(Employee)), new MemberBinding[]
						{
							System.Linq.Expressions.Expression.Bind(methodof(Employee.set_Id(int)), System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(store_sales.get_users())), methodof(users.get_id()))),
							System.Linq.Expressions.Expression.Bind(methodof(Employee.set_FirstName(string)), System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(store_sales.get_users())), methodof(users.get_name()))),
							System.Linq.Expressions.Expression.Bind(methodof(Employee.set_LastName(string)), System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(store_sales.get_users())), methodof(users.get_surname()))),
							System.Linq.Expressions.Expression.Bind(methodof(Employee.set_Patronymic(string)), System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(store_sales.get_users())), methodof(users.get_patronymic())))
						})),
						System.Linq.Expressions.Expression.Bind(methodof(SalesReportDto.set_Count(int)), System.Linq.Expressions.Expression.Property(parameterExpression, methodof(store_sales.get_count()))),
						System.Linq.Expressions.Expression.Bind(methodof(SalesReportDto.set_InPrice(decimal)), System.Linq.Expressions.Expression.Property(parameterExpression, methodof(store_sales.get_in_price()))),
						System.Linq.Expressions.Expression.Bind(methodof(SalesReportDto.set_Price(decimal)), System.Linq.Expressions.Expression.Property(parameterExpression, methodof(store_sales.get_price()))),
						System.Linq.Expressions.Expression.Bind(methodof(SalesReportDto.set_IsRealization(bool)), System.Linq.Expressions.Expression.Property(parameterExpression, methodof(store_sales.get_is_realization()))),
						System.Linq.Expressions.Expression.Bind(methodof(SalesReportDto.set_ReturnPercent(int)), System.Linq.Expressions.Expression.Property(parameterExpression, methodof(store_sales.get_return_percent())))
					}), new ParameterExpression[]
					{
						parameterExpression
					})).ToList<SalesReportDto>();
				}
			}
			catch (Exception exception)
			{
				ChartModel.Log.Error(exception, "Load sales by document id fail");
				throw;
			}
			return result;
		}

		// Token: 0x06004A57 RID: 19031 RVA: 0x0012A010 File Offset: 0x00128210
		private IQueryable<store_sales> UserFilter(int userId, IQueryable<store_sales> daySales)
		{
			if (userId != 0)
			{
				daySales = from i in daySales
				where i.user == userId
				select i;
			}
			return daySales;
		}

		// Token: 0x06004A58 RID: 19032 RVA: 0x0012A098 File Offset: 0x00128298
		private IQueryable<store_sales> OfficeFilter(int officeId, IQueryable<store_sales> daySales)
		{
			if (officeId != 0)
			{
				daySales = from i in daySales
				where i.docs.office == officeId
				select i;
			}
			return daySales;
		}

		// Token: 0x06004A59 RID: 19033 RVA: 0x0012A134 File Offset: 0x00128334
		public static Task<Dictionary<DateTime, int>> LoadWithdrawFundsChartData(Period period, int officeId)
		{
			ChartModel.<LoadWithdrawFundsChartData>d__52 <LoadWithdrawFundsChartData>d__;
			<LoadWithdrawFundsChartData>d__.<>t__builder = AsyncTaskMethodBuilder<Dictionary<DateTime, int>>.Create();
			<LoadWithdrawFundsChartData>d__.period = period;
			<LoadWithdrawFundsChartData>d__.officeId = officeId;
			<LoadWithdrawFundsChartData>d__.<>1__state = -1;
			<LoadWithdrawFundsChartData>d__.<>t__builder.Start<ChartModel.<LoadWithdrawFundsChartData>d__52>(ref <LoadWithdrawFundsChartData>d__);
			return <LoadWithdrawFundsChartData>d__.<>t__builder.Task;
		}

		// Token: 0x06004A5A RID: 19034 RVA: 0x0012A180 File Offset: 0x00128380
		public static Task<IEnumerable<workshop>> LoadRepairStatusesData(int officeId, int userId, int statusId, int ignoreAfter)
		{
			ChartModel.<LoadRepairStatusesData>d__53 <LoadRepairStatusesData>d__;
			<LoadRepairStatusesData>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<workshop>>.Create();
			<LoadRepairStatusesData>d__.officeId = officeId;
			<LoadRepairStatusesData>d__.userId = userId;
			<LoadRepairStatusesData>d__.statusId = statusId;
			<LoadRepairStatusesData>d__.ignoreAfter = ignoreAfter;
			<LoadRepairStatusesData>d__.<>1__state = -1;
			<LoadRepairStatusesData>d__.<>t__builder.Start<ChartModel.<LoadRepairStatusesData>d__53>(ref <LoadRepairStatusesData>d__);
			return <LoadRepairStatusesData>d__.<>t__builder.Task;
		}

		// Token: 0x06004A5B RID: 19035 RVA: 0x0012A1DC File Offset: 0x001283DC
		public static Task<List<IChartData>> GetFinancesChart(IPeriod period, int officeId, int paymentSystem, int type)
		{
			ChartModel.<GetFinancesChart>d__54 <GetFinancesChart>d__;
			<GetFinancesChart>d__.<>t__builder = AsyncTaskMethodBuilder<List<IChartData>>.Create();
			<GetFinancesChart>d__.period = period;
			<GetFinancesChart>d__.officeId = officeId;
			<GetFinancesChart>d__.paymentSystem = paymentSystem;
			<GetFinancesChart>d__.type = type;
			<GetFinancesChart>d__.<>1__state = -1;
			<GetFinancesChart>d__.<>t__builder.Start<ChartModel.<GetFinancesChart>d__54>(ref <GetFinancesChart>d__);
			return <GetFinancesChart>d__.<>t__builder.Task;
		}

		// Token: 0x06004A5C RID: 19036 RVA: 0x0012A238 File Offset: 0x00128438
		public ChartModel()
		{
		}

		// Token: 0x06004A5D RID: 19037 RVA: 0x0012A24C File Offset: 0x0012844C
		// Note: this type is marked as 'beforefieldinit'.
		static ChartModel()
		{
		}

		// Token: 0x04002F51 RID: 12113
		private static readonly ILogger Log = LogManager.GetCurrentClassLogger();

		// Token: 0x04002F52 RID: 12114
		private List<string> Phones;

		// Token: 0x0200098E RID: 2446
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004A5E RID: 19038 RVA: 0x0012A264 File Offset: 0x00128464
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004A5F RID: 19039 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06004A60 RID: 19040 RVA: 0x0012A27C File Offset: 0x0012847C
			internal int <LoadVisitChartDataDetails>b__3_0(visit_sources s)
			{
				return s.id;
			}

			// Token: 0x06004A61 RID: 19041 RVA: 0x0012A290 File Offset: 0x00128490
			internal CustomerCard <LoadVisitChartDataDetails>b__3_5(clients c)
			{
				return c.Client2CustomerCard();
			}

			// Token: 0x06004A62 RID: 19042 RVA: 0x0012A2A4 File Offset: 0x001284A4
			internal IOrderedQueryable<workshop> <LoadEmployeeRepairs>b__21_9(IQueryable<workshop> i)
			{
				return from d in i
				orderby d.id descending
				select d;
			}

			// Token: 0x06004A63 RID: 19043 RVA: 0x00021504 File Offset: 0x0001F704
			internal decimal <RepairCardConvert>b__22_1(store_int_reserve s)
			{
				return s.price * s.count;
			}

			// Token: 0x06004A64 RID: 19044 RVA: 0x0012A2F0 File Offset: 0x001284F0
			internal decimal <RepairCardConvert>b__22_2(store_int_reserve s)
			{
				return s.store_items.in_price * s.count;
			}

			// Token: 0x06004A65 RID: 19045 RVA: 0x0012A318 File Offset: 0x00128518
			internal decimal <RepairCardConvert>b__22_3(store_int_reserve s)
			{
				return s.price * s.count / 100m * s.users.pay_repair_q_sale;
			}

			// Token: 0x06004A66 RID: 19046 RVA: 0x0012A35C File Offset: 0x0012855C
			internal int <LoadPartsChartData>b__24_0(store_cats c)
			{
				return c.id;
			}

			// Token: 0x06004A67 RID: 19047 RVA: 0x0012A370 File Offset: 0x00128570
			internal DateTime <LoadWithdrawFundsChartData>b__52_2(cash_orders r)
			{
				return r.created;
			}

			// Token: 0x06004A68 RID: 19048 RVA: 0x0012A384 File Offset: 0x00128584
			internal int <LoadWithdrawFundsChartData>b__52_3(cash_orders r)
			{
				return decimal.ToInt32(r.summa);
			}

			// Token: 0x04002F53 RID: 12115
			public static readonly ChartModel.<>c <>9 = new ChartModel.<>c();

			// Token: 0x04002F54 RID: 12116
			public static Func<visit_sources, int> <>9__3_0;

			// Token: 0x04002F55 RID: 12117
			public static Func<clients, CustomerCard> <>9__3_5;

			// Token: 0x04002F56 RID: 12118
			public static Func<IQueryable<workshop>, IOrderedQueryable<workshop>> <>9__21_9;

			// Token: 0x04002F57 RID: 12119
			public static Func<store_int_reserve, decimal> <>9__22_1;

			// Token: 0x04002F58 RID: 12120
			public static Func<store_int_reserve, decimal> <>9__22_2;

			// Token: 0x04002F59 RID: 12121
			public static Func<store_int_reserve, decimal> <>9__22_3;

			// Token: 0x04002F5A RID: 12122
			public static Func<store_cats, int> <>9__24_0;

			// Token: 0x04002F5B RID: 12123
			public static Func<cash_orders, DateTime> <>9__52_2;

			// Token: 0x04002F5C RID: 12124
			public static Func<cash_orders, int> <>9__52_3;
		}

		// Token: 0x0200098F RID: 2447
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadVisitSourcesesAsync>d__1 : IAsyncStateMachine
		{
			// Token: 0x06004A69 RID: 19049 RVA: 0x0012A39C File Offset: 0x0012859C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<visit_sources> result2;
				try
				{
					try
					{
						if (num > 1)
						{
							this.<ctx>5__2 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<List<visit_sources>> awaiter;
							List<visit_sources> result;
							if (num != 0)
							{
								if (num == 1)
								{
									awaiter = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter<List<visit_sources>>);
									int num2 = -1;
									num = -1;
									this.<>1__state = num2;
								}
								else if (!this.includeDisabled)
								{
									awaiter = (from s in this.<ctx>5__2.visit_sources
									where s.enabled == (bool?)true
									orderby s.position
									select s).ToListAsync<visit_sources>().GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										int num3 = 1;
										num = 1;
										this.<>1__state = num3;
										this.<>u__1 = awaiter;
										this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<visit_sources>>, ChartModel.<LoadVisitSourcesesAsync>d__1>(ref awaiter, ref this);
										return;
									}
								}
								else
								{
									awaiter = (from s in this.<ctx>5__2.visit_sources
									orderby s.position
									select s).ToListAsync<visit_sources>().GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										int num4 = 0;
										num = 0;
										this.<>1__state = num4;
										this.<>u__1 = awaiter;
										this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<visit_sources>>, ChartModel.<LoadVisitSourcesesAsync>d__1>(ref awaiter, ref this);
										return;
									}
									goto IL_1E8;
								}
								result = awaiter.GetResult();
								goto IL_1F0;
							}
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<visit_sources>>);
							int num5 = -1;
							num = -1;
							this.<>1__state = num5;
							IL_1E8:
							result = awaiter.GetResult();
							IL_1F0:
							result2 = result;
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
						ChartModel.Log.Error(exception, "Load visit sources fail");
						result2 = new List<visit_sources>();
					}
				}
				catch (Exception exception2)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception2);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06004A6A RID: 19050 RVA: 0x0012A64C File Offset: 0x0012884C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002F5D RID: 12125
			public int <>1__state;

			// Token: 0x04002F5E RID: 12126
			public AsyncTaskMethodBuilder<List<visit_sources>> <>t__builder;

			// Token: 0x04002F5F RID: 12127
			public bool includeDisabled;

			// Token: 0x04002F60 RID: 12128
			private auseceEntities <ctx>5__2;

			// Token: 0x04002F61 RID: 12129
			private TaskAwaiter<List<visit_sources>> <>u__1;
		}

		// Token: 0x02000990 RID: 2448
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x06004A6B RID: 19051 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x04002F62 RID: 12130
			public DateTime from;

			// Token: 0x04002F63 RID: 12131
			public DateTime to;

			// Token: 0x04002F64 RID: 12132
			public int officeId;

			// Token: 0x04002F65 RID: 12133
			public int deviceId;
		}

		// Token: 0x02000991 RID: 2449
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_1
		{
			// Token: 0x06004A6C RID: 19052 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass2_1()
			{
			}

			// Token: 0x04002F66 RID: 12134
			public visit_sources source;

			// Token: 0x04002F67 RID: 12135
			public ChartModel.<>c__DisplayClass2_0 CS$<>8__locals1;
		}

		// Token: 0x02000992 RID: 2450
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadVisitChartData>d__2 : IAsyncStateMachine
		{
			// Token: 0x06004A6D RID: 19053 RVA: 0x0012A668 File Offset: 0x00128868
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<IVisitSourceChartItem> result2;
				try
				{
					TaskAwaiter<List<visit_sources>> awaiter;
					if (num != 0)
					{
						this.<>8__1 = new ChartModel.<>c__DisplayClass2_0();
						this.<>8__1.officeId = this.officeId;
						this.<>8__1.deviceId = this.deviceId;
						this.<>8__1.from = this.period.From;
						this.<>8__1.to = this.period.To.AddHours(23.0).AddMinutes(59.0).AddSeconds(59.0);
						this.<result>5__2 = new List<IVisitSourceChartItem>();
						awaiter = ChartModel.LoadVisitSourcesesAsync(false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							goto IL_4F3;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<visit_sources>>);
						int num2 = -1;
						num = -1;
						this.<>1__state = num2;
					}
					List<visit_sources> result = awaiter.GetResult();
					try
					{
						auseceEntities auseceEntities = new auseceEntities(true);
						try
						{
							List<visit_sources>.Enumerator enumerator = result.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									ChartModel.<>c__DisplayClass2_1 CS$<>8__locals1 = new ChartModel.<>c__DisplayClass2_1();
									CS$<>8__locals1.CS$<>8__locals1 = this.<>8__1;
									CS$<>8__locals1.source = enumerator.Current;
									IQueryable<clients> source = from r in auseceEntities.clients.AsNoTracking()
									where r.visit_source == (int?)CS$<>8__locals1.source.id && r.created >= (DateTime?)CS$<>8__locals1.CS$<>8__locals1.@from && r.created <= (DateTime?)CS$<>8__locals1.CS$<>8__locals1.to
									select r;
									if (CS$<>8__locals1.CS$<>8__locals1.officeId != 0)
									{
										source = from r in source
										where r.workshop.Any((workshop o) => o.start_office == CS$<>8__locals1.CS$<>8__locals1.officeId)
										select r;
									}
									if (CS$<>8__locals1.CS$<>8__locals1.deviceId != 0)
									{
										source = from r in source
										where r.workshop.Any((workshop d) => d.type == CS$<>8__locals1.CS$<>8__locals1.deviceId)
										select r;
									}
									this.<result>5__2.Add(new VisitSourceChartPoint
									{
										Id = CS$<>8__locals1.source.id,
										Name = CS$<>8__locals1.source.name,
										Count = source.Count<clients>()
									});
								}
							}
							finally
							{
								if (num < 0)
								{
									((IDisposable)enumerator).Dispose();
								}
							}
							result2 = this.<result>5__2;
							goto IL_53B;
						}
						finally
						{
							if (num < 0 && auseceEntities != null)
							{
								((IDisposable)auseceEntities).Dispose();
							}
						}
					}
					catch (Exception exception)
					{
						ChartModel.Log.Error(exception, "Load chart data fail");
						result2 = this.<result>5__2;
						goto IL_53B;
					}
					IL_4F3:
					int num3 = 0;
					num = 0;
					this.<>1__state = num3;
					this.<>u__1 = awaiter;
					this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<visit_sources>>, ChartModel.<LoadVisitChartData>d__2>(ref awaiter, ref this);
					return;
				}
				catch (Exception exception2)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<result>5__2 = null;
					this.<>t__builder.SetException(exception2);
					return;
				}
				IL_53B:
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<result>5__2 = null;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06004A6E RID: 19054 RVA: 0x0012AC38 File Offset: 0x00128E38
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002F68 RID: 12136
			public int <>1__state;

			// Token: 0x04002F69 RID: 12137
			public AsyncTaskMethodBuilder<List<IVisitSourceChartItem>> <>t__builder;

			// Token: 0x04002F6A RID: 12138
			public int officeId;

			// Token: 0x04002F6B RID: 12139
			public int deviceId;

			// Token: 0x04002F6C RID: 12140
			public IPeriod period;

			// Token: 0x04002F6D RID: 12141
			private ChartModel.<>c__DisplayClass2_0 <>8__1;

			// Token: 0x04002F6E RID: 12142
			private List<IVisitSourceChartItem> <result>5__2;

			// Token: 0x04002F6F RID: 12143
			private TaskAwaiter<List<visit_sources>> <>u__1;
		}

		// Token: 0x02000993 RID: 2451
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06004A6F RID: 19055 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x04002F70 RID: 12144
			public List<int> sourceIds;

			// Token: 0x04002F71 RID: 12145
			public DateTime from;

			// Token: 0x04002F72 RID: 12146
			public DateTime to;

			// Token: 0x04002F73 RID: 12147
			public int officeId;

			// Token: 0x04002F74 RID: 12148
			public int deviceId;
		}

		// Token: 0x02000994 RID: 2452
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadVisitChartDataDetails>d__3 : IAsyncStateMachine
		{
			// Token: 0x06004A70 RID: 19056 RVA: 0x0012AC54 File Offset: 0x00128E54
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<CustomerCard> result2;
				try
				{
					TaskAwaiter<List<visit_sources>> awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							goto IL_15D;
						}
						this.<>8__1 = new ChartModel.<>c__DisplayClass3_0();
						this.<>8__1.officeId = this.officeId;
						this.<>8__1.deviceId = this.deviceId;
						this.<>8__1.from = this.period.From;
						this.<>8__1.to = this.period.To.AddHours(23.0).AddMinutes(59.0).AddSeconds(59.0);
						this.<>8__1.sourceIds = new List<int>();
						if (this.selectedIds.Any<int>())
						{
							this.<>8__1.sourceIds.AddRange(this.selectedIds);
							goto IL_151;
						}
						awaiter = ChartModel.LoadVisitSourcesesAsync(false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							goto IL_5B5;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<visit_sources>>);
						int num2 = -1;
						num = -1;
						this.<>1__state = num2;
					}
					List<visit_sources> result = awaiter.GetResult();
					this.<>8__1.sourceIds.AddRange(result.Select(new Func<visit_sources, int>(ChartModel.<>c.<>9.<LoadVisitChartDataDetails>b__3_0)).ToList<int>());
					IL_151:
					this.<ctx>5__2 = new auseceEntities(true);
					IL_15D:
					try
					{
						TaskAwaiter<List<clients>> awaiter2;
						if (num != 1)
						{
							IQueryable<clients> source = from r in this.<ctx>5__2.clients.AsNoTracking().Include((clients r) => r.visit_sources)
							where r.visit_source != null && this.<>8__1.sourceIds.Contains(r.visit_source.Value) && r.created >= (DateTime?)this.<>8__1.@from && r.created <= (DateTime?)this.<>8__1.to
							select r;
							if (this.<>8__1.officeId != 0)
							{
								source = from r in source
								where r.workshop.Any((workshop o) => o.start_office == this.<>8__1.officeId)
								select r;
							}
							if (this.<>8__1.deviceId != 0)
							{
								source = from r in source
								where r.workshop.Any((workshop d) => d.type == this.<>8__1.deviceId)
								select r;
							}
							awaiter2 = source.ToListAsync<clients>().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num3 = 1;
								num = 1;
								this.<>1__state = num3;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<clients>>, ChartModel.<LoadVisitChartDataDetails>d__3>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<List<clients>>);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
						}
						result2 = awaiter2.GetResult().Select(new Func<clients, CustomerCard>(ChartModel.<>c.<>9.<LoadVisitChartDataDetails>b__3_5)).ToList<CustomerCard>();
						goto IL_5F6;
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
						}
					}
					IL_5B5:
					int num5 = 0;
					num = 0;
					this.<>1__state = num5;
					this.<>u__1 = awaiter;
					this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<visit_sources>>, ChartModel.<LoadVisitChartDataDetails>d__3>(ref awaiter, ref this);
					return;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_5F6:
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06004A71 RID: 19057 RVA: 0x0012B2A8 File Offset: 0x001294A8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002F75 RID: 12149
			public int <>1__state;

			// Token: 0x04002F76 RID: 12150
			public AsyncTaskMethodBuilder<List<CustomerCard>> <>t__builder;

			// Token: 0x04002F77 RID: 12151
			public int officeId;

			// Token: 0x04002F78 RID: 12152
			public int deviceId;

			// Token: 0x04002F79 RID: 12153
			public IPeriod period;

			// Token: 0x04002F7A RID: 12154
			public List<int> selectedIds;

			// Token: 0x04002F7B RID: 12155
			private ChartModel.<>c__DisplayClass3_0 <>8__1;

			// Token: 0x04002F7C RID: 12156
			private TaskAwaiter<List<visit_sources>> <>u__1;

			// Token: 0x04002F7D RID: 12157
			private auseceEntities <ctx>5__2;

			// Token: 0x04002F7E RID: 12158
			private TaskAwaiter<List<clients>> <>u__2;
		}

		// Token: 0x02000995 RID: 2453
		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x06004A72 RID: 19058 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x04002F7F RID: 12159
			public DateTime day;
		}

		// Token: 0x02000996 RID: 2454
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadCallsPeriodData>d__7 : IAsyncStateMachine
		{
			// Token: 0x06004A73 RID: 19059 RVA: 0x0012B2C4 File Offset: 0x001294C4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ChartModel chartModel = this.<>4__this;
				Dictionary<string, int> result2;
				try
				{
					if (num != 0)
					{
						this.<tdc>5__2 = new Dictionary<string, int>();
					}
					try
					{
						if (num != 0)
						{
							this.<ctx>5__3 = new auseceEntities(true);
						}
						try
						{
							if (num != 0)
							{
								this.<>7__wrap3 = this.period.EachDay().GetEnumerator();
							}
							try
							{
								TaskAwaiter<int> awaiter;
								if (num == 0)
								{
									awaiter = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter<int>);
									int num2 = -1;
									num = -1;
									this.<>1__state = num2;
									goto IL_3C6;
								}
								IL_6C:
								if (!this.<>7__wrap3.MoveNext())
								{
									goto IL_433;
								}
								ChartModel.<>c__DisplayClass7_0 CS$<>8__locals1 = new ChartModel.<>c__DisplayClass7_0();
								CS$<>8__locals1.day = this.<>7__wrap3.Current;
								IQueryable<cdr> queryable = from i in this.<ctx>5__3.cdr
								where i.calldate.Year == CS$<>8__locals1.day.Date.Year && i.calldate.Month == CS$<>8__locals1.day.Month && i.calldate.Day == CS$<>8__locals1.day.Day
								select i;
								if (this.option == 2)
								{
									queryable = from i in queryable
									where i.dcontext.Contains("from")
									select i;
								}
								if (this.option == 3)
								{
									queryable = from i in queryable
									where !i.dcontext.Contains("from")
									select i;
								}
								queryable = ChartModel.UserFilter(this.user, queryable);
								queryable = ChartModel.DeviceFilter(this.extDevice, queryable);
								queryable = chartModel.NewOrExistCustomer(this.clientType, this.<ctx>5__3, queryable);
								this.<>7__wrap4 = this.<tdc>5__2;
								this.<>7__wrap5 = CS$<>8__locals1.day.Date.ToShortDateString();
								awaiter = (from i in queryable
								group i by i.uniqueid).CountAsync<IGrouping<string, cdr>>().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num3 = 0;
									num = 0;
									this.<>1__state = num3;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, ChartModel.<LoadCallsPeriodData>d__7>(ref awaiter, ref this);
									return;
								}
								IL_3C6:
								int result = awaiter.GetResult();
								this.<>7__wrap4.Add(this.<>7__wrap5, result);
								this.<>7__wrap4 = null;
								this.<>7__wrap5 = null;
								goto IL_6C;
							}
							finally
							{
								if (num < 0 && this.<>7__wrap3 != null)
								{
									this.<>7__wrap3.Dispose();
								}
							}
							IL_433:
							this.<>7__wrap3 = null;
							result2 = this.<tdc>5__2;
						}
						finally
						{
							if (num < 0 && this.<ctx>5__3 != null)
							{
								((IDisposable)this.<ctx>5__3).Dispose();
							}
						}
					}
					catch (Exception exception)
					{
						ChartModel.Log.Error(exception, "Load period data fail");
						result2 = this.<tdc>5__2;
					}
				}
				catch (Exception exception2)
				{
					this.<>1__state = -2;
					this.<tdc>5__2 = null;
					this.<>t__builder.SetException(exception2);
					return;
				}
				this.<>1__state = -2;
				this.<tdc>5__2 = null;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06004A74 RID: 19060 RVA: 0x0012B7E8 File Offset: 0x001299E8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002F80 RID: 12160
			public int <>1__state;

			// Token: 0x04002F81 RID: 12161
			public AsyncTaskMethodBuilder<Dictionary<string, int>> <>t__builder;

			// Token: 0x04002F82 RID: 12162
			public Period period;

			// Token: 0x04002F83 RID: 12163
			public int option;

			// Token: 0x04002F84 RID: 12164
			public users user;

			// Token: 0x04002F85 RID: 12165
			public voip_ext_devices extDevice;

			// Token: 0x04002F86 RID: 12166
			public ChartModel <>4__this;

			// Token: 0x04002F87 RID: 12167
			public int clientType;

			// Token: 0x04002F88 RID: 12168
			private Dictionary<string, int> <tdc>5__2;

			// Token: 0x04002F89 RID: 12169
			private auseceEntities <ctx>5__3;

			// Token: 0x04002F8A RID: 12170
			private IEnumerator<DateTime> <>7__wrap3;

			// Token: 0x04002F8B RID: 12171
			private Dictionary<string, int> <>7__wrap4;

			// Token: 0x04002F8C RID: 12172
			private string <>7__wrap5;

			// Token: 0x04002F8D RID: 12173
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x02000997 RID: 2455
		[CompilerGenerated]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x06004A75 RID: 19061 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x04002F8E RID: 12174
			public auseceEntities ctx;
		}

		// Token: 0x02000998 RID: 2456
		[CompilerGenerated]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x06004A76 RID: 19062 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass11_0()
			{
			}

			// Token: 0x04002F8F RID: 12175
			public auseceEntities ctx;
		}

		// Token: 0x02000999 RID: 2457
		[CompilerGenerated]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x06004A77 RID: 19063 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x04002F90 RID: 12176
			public bool incoming;
		}

		// Token: 0x0200099A RID: 2458
		[CompilerGenerated]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x06004A78 RID: 19064 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass13_0()
			{
			}

			// Token: 0x04002F91 RID: 12177
			public DateTime from;

			// Token: 0x04002F92 RID: 12178
			public DateTime to;
		}

		// Token: 0x0200099B RID: 2459
		[CompilerGenerated]
		private sealed class <>c__DisplayClass16_0
		{
			// Token: 0x06004A79 RID: 19065 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass16_0()
			{
			}

			// Token: 0x04002F93 RID: 12179
			public bool? incoming;
		}

		// Token: 0x0200099C RID: 2460
		[CompilerGenerated]
		private sealed class <>c__DisplayClass17_0
		{
			// Token: 0x06004A7A RID: 19066 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass17_0()
			{
			}

			// Token: 0x04002F94 RID: 12180
			public string phone;
		}

		// Token: 0x0200099D RID: 2461
		[CompilerGenerated]
		private sealed class <>c__DisplayClass21_0
		{
			// Token: 0x06004A7B RID: 19067 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass21_0()
			{
			}

			// Token: 0x04002F95 RID: 12181
			public DateTime from;

			// Token: 0x04002F96 RID: 12182
			public DateTime to;

			// Token: 0x04002F97 RID: 12183
			public int officeId;

			// Token: 0x04002F98 RID: 12184
			public int employeeId;

			// Token: 0x04002F99 RID: 12185
			public int deviceId;
		}

		// Token: 0x0200099E RID: 2462
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadEmployeeRepairs>d__21 : IAsyncStateMachine
		{
			// Token: 0x06004A7C RID: 19068 RVA: 0x0012B804 File Offset: 0x00129A04
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IEnumerable<IRepairCardForReport> result;
				try
				{
					if (num != 0)
					{
						this.<>8__1 = new ChartModel.<>c__DisplayClass21_0();
						this.<>8__1.officeId = this.officeId;
						this.<>8__1.employeeId = this.employeeId;
						this.<>8__1.deviceId = this.deviceId;
						this.<>8__1.from = this.period.From.Date;
						this.<>8__1.to = this.period.To.Date.AddHours(23.0).AddMinutes(59.0).AddSeconds(59.0);
						this.<repo>5__2 = new GenericRepository<workshop>();
					}
					try
					{
						TaskAwaiter<IEnumerable<workshop>> awaiter;
						if (num != 0)
						{
							this.<repo>5__2.EnableLazyLoading();
							this.<repo>5__2.SetTimeout(180);
							List<KeyValuePair<bool, Expression<Func<workshop, bool>>>> filterList = new List<KeyValuePair<bool, Expression<Func<workshop, bool>>>>
							{
								new KeyValuePair<bool, Expression<Func<workshop, bool>>>(true, (workshop r) => (r.state == 8 || r.state == 12) && r.out_date != null && r.out_date >= (DateTime?)this.<>8__1.from && r.out_date <= (DateTime?)this.<>8__1.to),
								new KeyValuePair<bool, Expression<Func<workshop, bool>>>(this.<>8__1.officeId != 0, (workshop i) => i.office == this.<>8__1.officeId),
								new KeyValuePair<bool, Expression<Func<workshop, bool>>>(this.<>8__1.employeeId != 0, (workshop i) => i.works.Any((works w) => w.user == this.<>8__1.employeeId) || i.master == (int?)this.<>8__1.employeeId),
								new KeyValuePair<bool, Expression<Func<workshop, bool>>>(this.<>8__1.deviceId > 0, (workshop i) => i.type == this.<>8__1.deviceId),
								new KeyValuePair<bool, Expression<Func<workshop, bool>>>(this.<>8__1.deviceId == -1, (workshop i) => i.cartridge == null),
								new KeyValuePair<bool, Expression<Func<workshop, bool>>>(this.state == 1, (workshop i) => i.state == 8 && i.real_repair_cost > 0m),
								new KeyValuePair<bool, Expression<Func<workshop, bool>>>(this.state == 2, (workshop i) => i.state == 12),
								new KeyValuePair<bool, Expression<Func<workshop, bool>>>(this.state == 3, (workshop i) => i.is_warranty && i.real_repair_cost == 0m)
							};
							awaiter = this.<repo>5__2.GetAllAsync(filterList, new Func<IQueryable<workshop>, IOrderedQueryable<workshop>>(ChartModel.<>c.<>9.<LoadEmployeeRepairs>b__21_9), "works,store_int_reserve,store_int_reserve,users2,users3,clients", false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<workshop>>, ChartModel.<LoadEmployeeRepairs>d__21>(ref awaiter, ref this);
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
						result = awaiter.GetResult().Select(ChartModel.RepairCardConvert(this.<>8__1.employeeId)).ToList<RepairCardForReport>();
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
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06004A7D RID: 19069 RVA: 0x0012C020 File Offset: 0x0012A220
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002F9A RID: 12186
			public int <>1__state;

			// Token: 0x04002F9B RID: 12187
			public AsyncTaskMethodBuilder<IEnumerable<IRepairCardForReport>> <>t__builder;

			// Token: 0x04002F9C RID: 12188
			public int officeId;

			// Token: 0x04002F9D RID: 12189
			public int employeeId;

			// Token: 0x04002F9E RID: 12190
			public int deviceId;

			// Token: 0x04002F9F RID: 12191
			public IPeriod period;

			// Token: 0x04002FA0 RID: 12192
			public int state;

			// Token: 0x04002FA1 RID: 12193
			private ChartModel.<>c__DisplayClass21_0 <>8__1;

			// Token: 0x04002FA2 RID: 12194
			private GenericRepository<workshop> <repo>5__2;

			// Token: 0x04002FA3 RID: 12195
			private TaskAwaiter<IEnumerable<workshop>> <>u__1;
		}

		// Token: 0x0200099F RID: 2463
		[CompilerGenerated]
		private sealed class <>c__DisplayClass22_0
		{
			// Token: 0x06004A7E RID: 19070 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass22_0()
			{
			}

			// Token: 0x06004A7F RID: 19071 RVA: 0x0012C03C File Offset: 0x0012A23C
			internal RepairCardForReport <RepairCardConvert>b__0(workshop r)
			{
				RepairCardForReport repairCardForReport = new RepairCardForReport();
				repairCardForReport.Id = r.id;
				repairCardForReport.CompanyId = r.company;
				repairCardForReport.OfficeId = r.office;
				repairCardForReport.InDateTime = r.in_date;
				repairCardForReport.Status = r.state;
				repairCardForReport.FullDeviceName = r.Title;
				repairCardForReport.SerialNumber = r.serial_number;
				repairCardForReport.BarCode = r.barcode;
				repairCardForReport.ExtNotes = r.ext_notes;
				repairCardForReport.PrepaidType = new int?(r.prepaid_type);
				repairCardForReport.PrepaidSumm = new decimal?(r.prepaid_summ);
				repairCardForReport.PreviousRepair = r.early;
				repairCardForReport.IsPrepaid = r.is_prepaid;
				repairCardForReport.IsPreAgreed = r.is_pre_agreed;
				repairCardForReport.IsWarranty = r.is_warranty;
				repairCardForReport.IsRepeat = r.is_repeat;
				repairCardForReport.CanFormat = r.can_format;
				repairCardForReport.ExpressRepair = r.express_repair.GetValueOrDefault();
				repairCardForReport.ThirdPartySc = r.thirs_party_sc;
				repairCardForReport.MasterId = r.master;
				repairCardForReport.ManagerId = r.current_manager;
				repairCardForReport.BoxId = r.box;
				repairCardForReport.InformStatus = r.informed_status;
				repairCardForReport.Fault = r.fault;
				repairCardForReport.Complect = r.complect;
				repairCardForReport.Look = r.look;
				repairCardForReport.DiagnosticResult = r.diagnostic_result;
				repairCardForReport.RejectReason = r.reject_reason;
				repairCardForReport.RepairCost = r.repair_cost;
				repairCardForReport.RealRepairCost = r.real_repair_cost;
				repairCardForReport.PreAgreedSumm = r.pre_agreed_amount;
				repairCardForReport.OutDate = r.out_date;
				repairCardForReport.WorksAndParts = new ObservableCollection<IWorkPartObject>(RepairModel.WorksAndPartsConvert(r.works.ToList<works>(), r.store_int_reserve.ToList<store_int_reserve>(), 0));
				repairCardForReport.ManagerPart = ChartModel.GetManagerPart(r);
				repairCardForReport.MasterFio = r.MasterFio;
				repairCardForReport.AllPartsCost = r.store_int_reserve.Sum(new Func<store_int_reserve, decimal>(ChartModel.<>c.<>9.<RepairCardConvert>b__22_1));
				repairCardForReport.AllPartsInSumm = r.store_int_reserve.Sum(new Func<store_int_reserve, decimal>(ChartModel.<>c.<>9.<RepairCardConvert>b__22_2));
				repairCardForReport.ManagerGoodsPart = r.store_int_reserve.Sum(new Func<store_int_reserve, decimal>(ChartModel.<>c.<>9.<RepairCardConvert>b__22_3));
				repairCardForReport.CustomerVisitSource = r.clients.visit_source;
				repairCardForReport.SetStatusColor();
				repairCardForReport.CalcWorksCost(this.employeeId);
				repairCardForReport.CalcAllWorksSumm();
				repairCardForReport.CalcPartsSumm(this.employeeId);
				repairCardForReport.CalcMasterPart(this.employeeId);
				repairCardForReport.CallAllMastersPart();
				repairCardForReport.CalcProfit();
				repairCardForReport.FillMastersFio();
				return repairCardForReport;
			}

			// Token: 0x04002FA4 RID: 12196
			public int employeeId;
		}

		// Token: 0x020009A0 RID: 2464
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadPartsChartData>d__24 : IAsyncStateMachine
		{
			// Token: 0x06004A80 RID: 19072 RVA: 0x0012C304 File Offset: 0x0012A504
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ChartModel chartModel = this.<>4__this;
				List<KeyValuePair<string, int>> result;
				try
				{
					TaskAwaiter<List<store_cats>> awaiter;
					if (num != 0)
					{
						this.<result>5__2 = new List<KeyValuePair<string, int>>();
						awaiter = chartModel.LoadRootNodes(this.storeId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.<>1__state = num2;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_cats>>, ChartModel.<LoadPartsChartData>d__24>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<store_cats>>);
						int num3 = -1;
						num = -1;
						this.<>1__state = num3;
					}
					List<store_cats>.Enumerator enumerator = awaiter.GetResult().GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							store_cats store_cats = enumerator.Current;
							List<int> ids = chartModel.LoadChildrensCats(store_cats).Select(new Func<store_cats, int>(ChartModel.<>c.<>9.<LoadPartsChartData>b__24_0)).ToList<int>();
							int value = chartModel.CountItemsInCategories(ids);
							this.<result>5__2.Add(new KeyValuePair<string, int>(store_cats.name, value));
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)enumerator).Dispose();
						}
					}
					result = this.<result>5__2;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<result>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<result>5__2 = null;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06004A81 RID: 19073 RVA: 0x0012C474 File Offset: 0x0012A674
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002FA5 RID: 12197
			public int <>1__state;

			// Token: 0x04002FA6 RID: 12198
			public AsyncTaskMethodBuilder<List<KeyValuePair<string, int>>> <>t__builder;

			// Token: 0x04002FA7 RID: 12199
			public ChartModel <>4__this;

			// Token: 0x04002FA8 RID: 12200
			public int storeId;

			// Token: 0x04002FA9 RID: 12201
			private List<KeyValuePair<string, int>> <result>5__2;

			// Token: 0x04002FAA RID: 12202
			private TaskAwaiter<List<store_cats>> <>u__1;
		}

		// Token: 0x020009A1 RID: 2465
		[CompilerGenerated]
		private sealed class <>c__DisplayClass25_0
		{
			// Token: 0x06004A82 RID: 19074 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass25_0()
			{
			}

			// Token: 0x04002FAB RID: 12203
			public int storeId;
		}

		// Token: 0x020009A2 RID: 2466
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CountTotalParts>d__25 : IAsyncStateMachine
		{
			// Token: 0x06004A83 RID: 19075 RVA: 0x0012C490 File Offset: 0x0012A690
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				int result;
				try
				{
					ChartModel.<>c__DisplayClass25_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new ChartModel.<>c__DisplayClass25_0();
						CS$<>8__locals1.storeId = this.storeId;
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
								awaiter = this.<ctx>5__2.store_items.CountAsync((store_items i) => i.store == CS$<>8__locals1.storeId && i.count - i.reserved - i.dealer_lock > 0).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, ChartModel.<CountTotalParts>d__25>(ref awaiter, ref this);
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
						ChartModel.Log.Error(exception, "Total parts count fail");
						result = 0;
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

			// Token: 0x06004A84 RID: 19076 RVA: 0x0012C6AC File Offset: 0x0012A8AC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002FAC RID: 12204
			public int <>1__state;

			// Token: 0x04002FAD RID: 12205
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x04002FAE RID: 12206
			public int storeId;

			// Token: 0x04002FAF RID: 12207
			private auseceEntities <ctx>5__2;

			// Token: 0x04002FB0 RID: 12208
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x020009A3 RID: 2467
		[CompilerGenerated]
		private sealed class <>c__DisplayClass26_0
		{
			// Token: 0x06004A85 RID: 19077 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass26_0()
			{
			}

			// Token: 0x04002FB1 RID: 12209
			public int storeId;
		}

		// Token: 0x020009A4 RID: 2468
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CountTotalInSumm>d__26 : IAsyncStateMachine
		{
			// Token: 0x06004A86 RID: 19078 RVA: 0x0012C6C8 File Offset: 0x0012A8C8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				decimal result;
				try
				{
					ChartModel.<>c__DisplayClass26_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new ChartModel.<>c__DisplayClass26_0();
						CS$<>8__locals1.storeId = this.storeId;
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
								awaiter = (from i in this.<ctx>5__2.store_items
								where i.store == CS$<>8__locals1.storeId && i.count - i.reserved - i.dealer_lock > 0
								select i.in_price * (decimal)i.count).DefaultIfEmpty<decimal>().SumAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, ChartModel.<CountTotalInSumm>d__26>(ref awaiter, ref this);
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
						ChartModel.Log.Error(exception, "Total in summ count fail");
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

			// Token: 0x06004A87 RID: 19079 RVA: 0x0012C970 File Offset: 0x0012AB70
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002FB2 RID: 12210
			public int <>1__state;

			// Token: 0x04002FB3 RID: 12211
			public AsyncTaskMethodBuilder<decimal> <>t__builder;

			// Token: 0x04002FB4 RID: 12212
			public int storeId;

			// Token: 0x04002FB5 RID: 12213
			private auseceEntities <ctx>5__2;

			// Token: 0x04002FB6 RID: 12214
			private TaskAwaiter<decimal> <>u__1;
		}

		// Token: 0x020009A5 RID: 2469
		[CompilerGenerated]
		private sealed class <>c__DisplayClass27_0
		{
			// Token: 0x06004A88 RID: 19080 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass27_0()
			{
			}

			// Token: 0x04002FB7 RID: 12215
			public int storeId;
		}

		// Token: 0x020009A6 RID: 2470
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CountTotalOutSummPrice2>d__27 : IAsyncStateMachine
		{
			// Token: 0x06004A89 RID: 19081 RVA: 0x0012C98C File Offset: 0x0012AB8C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				decimal result;
				try
				{
					ChartModel.<>c__DisplayClass27_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new ChartModel.<>c__DisplayClass27_0();
						CS$<>8__locals1.storeId = this.storeId;
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
								awaiter = (from i in this.<ctx>5__2.store_items
								where i.store == CS$<>8__locals1.storeId && i.count - i.reserved - i.dealer_lock > 0
								select i.price2 * (decimal)i.count).DefaultIfEmpty<decimal>().SumAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, ChartModel.<CountTotalOutSummPrice2>d__27>(ref awaiter, ref this);
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
						ChartModel.Log.Error(exception, "Total out summ price2 count fail");
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

			// Token: 0x06004A8A RID: 19082 RVA: 0x0012CC34 File Offset: 0x0012AE34
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002FB8 RID: 12216
			public int <>1__state;

			// Token: 0x04002FB9 RID: 12217
			public AsyncTaskMethodBuilder<decimal> <>t__builder;

			// Token: 0x04002FBA RID: 12218
			public int storeId;

			// Token: 0x04002FBB RID: 12219
			private auseceEntities <ctx>5__2;

			// Token: 0x04002FBC RID: 12220
			private TaskAwaiter<decimal> <>u__1;
		}

		// Token: 0x020009A7 RID: 2471
		[CompilerGenerated]
		private sealed class <>c__DisplayClass28_0
		{
			// Token: 0x06004A8B RID: 19083 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass28_0()
			{
			}

			// Token: 0x06004A8C RID: 19084 RVA: 0x0012CC50 File Offset: 0x0012AE50
			internal SalesInfo2 <LoadRepairsPeriodData>b__6(<>f__AnonymousType10<DateTime, DateTime?, int, int, int> repair)
			{
				return new SalesInfo2
				{
					Date = ((this.typeInOut == 0) ? Localization.ToLocalTimeZone(repair.in_date) : Localization.ToLocalTimeZone(repair.out_date.Value)),
					Total = 1m
				};
			}

			// Token: 0x04002FBD RID: 12221
			public DateTime from;

			// Token: 0x04002FBE RID: 12222
			public DateTime to;

			// Token: 0x04002FBF RID: 12223
			public int officeId;

			// Token: 0x04002FC0 RID: 12224
			public int device;

			// Token: 0x04002FC1 RID: 12225
			public int deviceMaker;

			// Token: 0x04002FC2 RID: 12226
			public int typeInOut;
		}

		// Token: 0x020009A8 RID: 2472
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadRepairsPeriodData>d__28 : IAsyncStateMachine
		{
			// Token: 0x06004A8D RID: 19085 RVA: 0x0012CC9C File Offset: 0x0012AE9C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<SalesInfo2> result2;
				try
				{
					if (num != 0)
					{
						this.<>8__1 = new ChartModel.<>c__DisplayClass28_0();
						this.<>8__1.officeId = this.officeId;
						this.<>8__1.device = this.device;
						this.<>8__1.deviceMaker = this.deviceMaker;
						this.<>8__1.typeInOut = this.typeInOut;
						this.<tdc>5__2 = new List<SalesInfo2>();
						this.<>8__1.from = this.period.From.Date;
						this.<>8__1.to = this.period.To.Date.AddHours(23.0).AddMinutes(59.0).AddSeconds(59.0);
					}
					try
					{
						if (num != 0)
						{
							this.<ctx>5__3 = new auseceEntities(true);
						}
						try
						{
							var awaiter;
							if (num != 0)
							{
								var source = from r in this.<ctx>5__3.workshop
								select new
								{
									r.in_date,
									r.out_date,
									r.office,
									r.type,
									r.maker
								};
								if (this.<>8__1.typeInOut == 0)
								{
									source = from i in source
									where i.in_date >= this.<>8__1.@from && i.in_date <= this.<>8__1.to
									select i;
								}
								if (this.<>8__1.typeInOut == 1)
								{
									source = from i in source
									where i.out_date != null && i.out_date >= (DateTime?)this.<>8__1.@from && i.out_date <= (DateTime?)this.<>8__1.to
									select i;
								}
								if (this.<>8__1.officeId != 0)
								{
									source = from i in source
									where i.office == this.<>8__1.officeId
									select i;
								}
								if (this.<>8__1.device != 0)
								{
									source = from i in source
									where i.type == this.<>8__1.device
									select i;
								}
								if (this.<>8__1.deviceMaker > 0)
								{
									source = from i in source
									where i.maker == this.<>8__1.deviceMaker
									select i;
								}
								awaiter = source.ToListAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<List<<>f__AnonymousType10<DateTime, DateTime?, int, int, int>>>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							var result = awaiter.GetResult();
							this.<tdc>5__2.AddRange(result.Select(new Func<<>f__AnonymousType10<DateTime, DateTime?, int, int, int>, SalesInfo2>(this.<>8__1.<LoadRepairsPeriodData>b__6)));
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
					catch (Exception exception)
					{
						ChartModel.Log.Error(exception, "Load period data fail");
					}
					result2 = this.<tdc>5__2;
				}
				catch (Exception exception2)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<tdc>5__2 = null;
					this.<>t__builder.SetException(exception2);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<tdc>5__2 = null;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06004A8E RID: 19086 RVA: 0x0012D400 File Offset: 0x0012B600
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002FC3 RID: 12227
			public int <>1__state;

			// Token: 0x04002FC4 RID: 12228
			public AsyncTaskMethodBuilder<List<SalesInfo2>> <>t__builder;

			// Token: 0x04002FC5 RID: 12229
			public int officeId;

			// Token: 0x04002FC6 RID: 12230
			public int device;

			// Token: 0x04002FC7 RID: 12231
			public int deviceMaker;

			// Token: 0x04002FC8 RID: 12232
			public int typeInOut;

			// Token: 0x04002FC9 RID: 12233
			public Period period;

			// Token: 0x04002FCA RID: 12234
			private ChartModel.<>c__DisplayClass28_0 <>8__1;

			// Token: 0x04002FCB RID: 12235
			private List<SalesInfo2> <tdc>5__2;

			// Token: 0x04002FCC RID: 12236
			private auseceEntities <ctx>5__3;

			// Token: 0x04002FCD RID: 12237
			private TaskAwaiter<List<<>f__AnonymousType10<DateTime, DateTime?, int, int, int>>> <>u__1;
		}

		// Token: 0x020009A9 RID: 2473
		[CompilerGenerated]
		private sealed class <>c__DisplayClass43_0
		{
			// Token: 0x06004A8F RID: 19087 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass43_0()
			{
			}

			// Token: 0x04002FCE RID: 12238
			public int device;
		}

		// Token: 0x020009AA RID: 2474
		[CompilerGenerated]
		private sealed class <>c__DisplayClass44_0
		{
			// Token: 0x06004A90 RID: 19088 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass44_0()
			{
			}

			// Token: 0x04002FCF RID: 12239
			public int maker;
		}

		// Token: 0x020009AB RID: 2475
		[CompilerGenerated]
		private sealed class <>c__DisplayClass45_0
		{
			// Token: 0x06004A91 RID: 19089 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass45_0()
			{
			}

			// Token: 0x04002FD0 RID: 12240
			public DateTime from;

			// Token: 0x04002FD1 RID: 12241
			public DateTime to;
		}

		// Token: 0x020009AC RID: 2476
		[CompilerGenerated]
		private sealed class <>c__DisplayClass46_0
		{
			// Token: 0x06004A92 RID: 19090 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass46_0()
			{
			}

			// Token: 0x04002FD2 RID: 12242
			public DateTime from;

			// Token: 0x04002FD3 RID: 12243
			public DateTime to;
		}

		// Token: 0x020009AD RID: 2477
		[CompilerGenerated]
		private sealed class <>c__DisplayClass47_0
		{
			// Token: 0x06004A93 RID: 19091 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass47_0()
			{
			}

			// Token: 0x04002FD4 RID: 12244
			public DateTime from;

			// Token: 0x04002FD5 RID: 12245
			public DateTime to;

			// Token: 0x04002FD6 RID: 12246
			public List<int> docIds;
		}

		// Token: 0x020009AE RID: 2478
		[CompilerGenerated]
		private sealed class <>c__DisplayClass48_0
		{
			// Token: 0x06004A94 RID: 19092 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass48_0()
			{
			}

			// Token: 0x04002FD7 RID: 12247
			public DateTime from;

			// Token: 0x04002FD8 RID: 12248
			public DateTime to;
		}

		// Token: 0x020009AF RID: 2479
		[CompilerGenerated]
		private sealed class <>c__DisplayClass48_1
		{
			// Token: 0x06004A95 RID: 19093 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass48_1()
			{
			}

			// Token: 0x06004A96 RID: 19094 RVA: 0x0012D41C File Offset: 0x0012B61C
			internal bool <LoadSalesChartData>b__4(<>f__AnonymousType11<DateTime, int, decimal, string, string> i)
			{
				return i.created >= this.day.Date && i.created <= this.day.Date.AddDays(1.0).AddSeconds(-1.0);
			}

			// Token: 0x04002FD9 RID: 12249
			public DateTime day;
		}

		// Token: 0x020009B0 RID: 2480
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadSalesChartData>d__48 : IAsyncStateMachine
		{
			// Token: 0x06004A97 RID: 19095 RVA: 0x0012D47C File Offset: 0x0012B67C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ChartModel chartModel = this.<>4__this;
				List<SalesInfo2> result2;
				try
				{
					if (num != 0)
					{
						this.<tdc>5__2 = new List<SalesInfo2>();
						this.<summa>5__3 = 0m;
					}
					try
					{
						if (num != 0)
						{
							this.<ctx>5__4 = new auseceEntities(true);
						}
						try
						{
							var awaiter;
							if (num != 0)
							{
								ChartModel.<>c__DisplayClass48_0 CS$<>8__locals1 = new ChartModel.<>c__DisplayClass48_0();
								CS$<>8__locals1.from = this.period.From.Date;
								CS$<>8__locals1.to = this.period.To.Date.AddDays(1.0).AddSeconds(-1.0);
								IQueryable<store_sales> queryable = from i in this.<ctx>5__4.store_sales.AsNoTracking().Include((store_sales i) => i.users).Include((store_sales i) => i.docs)
								where i.docs.type == 2 && i.docs.state == (int?)5 && i.docs.created >= CS$<>8__locals1.@from && i.docs.created <= CS$<>8__locals1.to
								select i;
								queryable = chartModel.OfficeFilter(this.officeId, queryable);
								queryable = chartModel.UserFilter(this.userId, queryable);
								awaiter = (from i in queryable
								select new
								{
									i.docs.created,
									i.count,
									i.price,
									i.users.username,
									i.users.name
								}).ToListAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<List<<>f__AnonymousType11<DateTime, int, decimal, string, string>>>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							var result = awaiter.GetResult();
							IEnumerator<DateTime> enumerator = this.period.EachDay().GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									DateTime day = enumerator.Current;
									var enumerator2 = result.Where(new Func<<>f__AnonymousType11<DateTime, int, decimal, string, string>, bool>(new ChartModel.<>c__DisplayClass48_1
									{
										day = day
									}.<LoadSalesChartData>b__4)).ToList().GetEnumerator();
									try
									{
										while (enumerator2.MoveNext())
										{
											var <>f__AnonymousType = enumerator2.Current;
											this.<summa>5__3 += <>f__AnonymousType.count * <>f__AnonymousType.price;
											this.<tdc>5__2.Add(new SalesInfo2
											{
												Date = Localization.ToLocalTimeZone(<>f__AnonymousType.created),
												Total = <>f__AnonymousType.count * <>f__AnonymousType.price,
												User = <>f__AnonymousType.username + " - " + <>f__AnonymousType.name,
												Summa = this.<summa>5__3
											});
										}
									}
									finally
									{
										if (num < 0)
										{
											((IDisposable)enumerator2).Dispose();
										}
									}
								}
							}
							finally
							{
								if (num < 0 && enumerator != null)
								{
									enumerator.Dispose();
								}
							}
							result2 = this.<tdc>5__2;
						}
						finally
						{
							if (num < 0 && this.<ctx>5__4 != null)
							{
								((IDisposable)this.<ctx>5__4).Dispose();
							}
						}
					}
					catch (Exception exception)
					{
						ChartModel.Log.Error(exception, "Load sales chard data fail");
						result2 = new List<SalesInfo2>();
					}
				}
				catch (Exception exception2)
				{
					this.<>1__state = -2;
					this.<tdc>5__2 = null;
					this.<>t__builder.SetException(exception2);
					return;
				}
				this.<>1__state = -2;
				this.<tdc>5__2 = null;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06004A98 RID: 19096 RVA: 0x0012DB64 File Offset: 0x0012BD64
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002FDA RID: 12250
			public int <>1__state;

			// Token: 0x04002FDB RID: 12251
			public AsyncTaskMethodBuilder<List<SalesInfo2>> <>t__builder;

			// Token: 0x04002FDC RID: 12252
			public Period period;

			// Token: 0x04002FDD RID: 12253
			public ChartModel <>4__this;

			// Token: 0x04002FDE RID: 12254
			public int officeId;

			// Token: 0x04002FDF RID: 12255
			public int userId;

			// Token: 0x04002FE0 RID: 12256
			private List<SalesInfo2> <tdc>5__2;

			// Token: 0x04002FE1 RID: 12257
			private decimal <summa>5__3;

			// Token: 0x04002FE2 RID: 12258
			private auseceEntities <ctx>5__4;

			// Token: 0x04002FE3 RID: 12259
			private TaskAwaiter<List<<>f__AnonymousType11<DateTime, int, decimal, string, string>>> <>u__1;
		}

		// Token: 0x020009B1 RID: 2481
		[CompilerGenerated]
		private sealed class <>c__DisplayClass49_0
		{
			// Token: 0x06004A99 RID: 19097 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass49_0()
			{
			}

			// Token: 0x04002FE4 RID: 12260
			public DateTime from;

			// Token: 0x04002FE5 RID: 12261
			public DateTime to;
		}

		// Token: 0x020009B2 RID: 2482
		[CompilerGenerated]
		private sealed class <>c__DisplayClass50_0
		{
			// Token: 0x06004A9A RID: 19098 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass50_0()
			{
			}

			// Token: 0x04002FE6 RID: 12262
			public int userId;
		}

		// Token: 0x020009B3 RID: 2483
		[CompilerGenerated]
		private sealed class <>c__DisplayClass51_0
		{
			// Token: 0x06004A9B RID: 19099 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass51_0()
			{
			}

			// Token: 0x04002FE7 RID: 12263
			public int officeId;
		}

		// Token: 0x020009B4 RID: 2484
		[CompilerGenerated]
		private sealed class <>c__DisplayClass52_0
		{
			// Token: 0x06004A9C RID: 19100 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass52_0()
			{
			}

			// Token: 0x04002FE8 RID: 12264
			public DateTime from;

			// Token: 0x04002FE9 RID: 12265
			public DateTime to;

			// Token: 0x04002FEA RID: 12266
			public int officeId;
		}

		// Token: 0x020009B5 RID: 2485
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadWithdrawFundsChartData>d__52 : IAsyncStateMachine
		{
			// Token: 0x06004A9D RID: 19101 RVA: 0x0012DB80 File Offset: 0x0012BD80
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Dictionary<DateTime, int> result;
				try
				{
					ChartModel.<>c__DisplayClass52_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new ChartModel.<>c__DisplayClass52_0();
						CS$<>8__locals1.officeId = this.officeId;
						CS$<>8__locals1.from = this.period.From.Date;
						CS$<>8__locals1.to = this.period.To.Date.AddDays(1.0).AddSeconds(-1.0);
					}
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<Dictionary<DateTime, int>> awaiter;
							if (num != 0)
							{
								IQueryable<cash_orders> source = (from o in this.<ctx>5__2.cash_orders.AsNoTracking()
								where o.type == 7 && o.created >= CS$<>8__locals1.@from && o.created <= CS$<>8__locals1.to
								select o).AsQueryable<cash_orders>();
								if (CS$<>8__locals1.officeId != 0)
								{
									source = from o in source
									where o.office == CS$<>8__locals1.officeId
									select o;
								}
								awaiter = source.ToDictionaryAsync(new Func<cash_orders, DateTime>(ChartModel.<>c.<>9.<LoadWithdrawFundsChartData>b__52_2), new Func<cash_orders, int>(ChartModel.<>c.<>9.<LoadWithdrawFundsChartData>b__52_3)).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Dictionary<DateTime, int>>, ChartModel.<LoadWithdrawFundsChartData>d__52>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<Dictionary<DateTime, int>>);
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
					catch (Exception value)
					{
						ChartModel.Log.Error<Exception>(value);
						result = new Dictionary<DateTime, int>();
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

			// Token: 0x06004A9E RID: 19102 RVA: 0x0012DEDC File Offset: 0x0012C0DC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002FEB RID: 12267
			public int <>1__state;

			// Token: 0x04002FEC RID: 12268
			public AsyncTaskMethodBuilder<Dictionary<DateTime, int>> <>t__builder;

			// Token: 0x04002FED RID: 12269
			public int officeId;

			// Token: 0x04002FEE RID: 12270
			public Period period;

			// Token: 0x04002FEF RID: 12271
			private auseceEntities <ctx>5__2;

			// Token: 0x04002FF0 RID: 12272
			private TaskAwaiter<Dictionary<DateTime, int>> <>u__1;
		}

		// Token: 0x020009B6 RID: 2486
		[CompilerGenerated]
		private sealed class <>c__DisplayClass53_0
		{
			// Token: 0x06004A9F RID: 19103 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass53_0()
			{
			}

			// Token: 0x04002FF1 RID: 12273
			public int officeId;

			// Token: 0x04002FF2 RID: 12274
			public Localization localization;

			// Token: 0x04002FF3 RID: 12275
			public int ignoreAfter;

			// Token: 0x04002FF4 RID: 12276
			public int userId;

			// Token: 0x04002FF5 RID: 12277
			public int statusId;
		}

		// Token: 0x020009B7 RID: 2487
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadRepairStatusesData>d__53 : IAsyncStateMachine
		{
			// Token: 0x06004AA0 RID: 19104 RVA: 0x0012DEF8 File Offset: 0x0012C0F8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IEnumerable<workshop> result;
				try
				{
					ChartModel.<>c__DisplayClass53_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new ChartModel.<>c__DisplayClass53_0();
						CS$<>8__locals1.officeId = this.officeId;
						CS$<>8__locals1.ignoreAfter = this.ignoreAfter;
						CS$<>8__locals1.userId = this.userId;
						CS$<>8__locals1.statusId = this.statusId;
						CS$<>8__locals1.localization = new Localization("UTC");
						this.<repo>5__2 = new GenericRepository<workshop>();
					}
					try
					{
						TaskAwaiter<IEnumerable<workshop>> awaiter;
						if (num != 0)
						{
							List<KeyValuePair<bool, Expression<Func<workshop, bool>>>> filterList = new List<KeyValuePair<bool, Expression<Func<workshop, bool>>>>
							{
								new KeyValuePair<bool, Expression<Func<workshop, bool>>>(true, (workshop r) => r.state != 8 && r.state != 12),
								new KeyValuePair<bool, Expression<Func<workshop, bool>>>(CS$<>8__locals1.officeId != 0, (workshop r) => r.office == CS$<>8__locals1.officeId),
								new KeyValuePair<bool, Expression<Func<workshop, bool>>>(CS$<>8__locals1.ignoreAfter != 0, (workshop r) => DbFunctions.DiffDays((DateTime?)CS$<>8__locals1.localization.Now, (DateTime?)r.in_date) < (int?)CS$<>8__locals1.ignoreAfter),
								new KeyValuePair<bool, Expression<Func<workshop, bool>>>(CS$<>8__locals1.userId != 0, (workshop r) => r.manager == CS$<>8__locals1.userId || r.current_manager == CS$<>8__locals1.userId || r.master == (int?)CS$<>8__locals1.userId),
								new KeyValuePair<bool, Expression<Func<workshop, bool>>>(CS$<>8__locals1.statusId != 99, (workshop r) => r.state == CS$<>8__locals1.statusId)
							};
							awaiter = this.<repo>5__2.GetAllAsync(filterList, null, "", false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<workshop>>, ChartModel.<LoadRepairStatusesData>d__53>(ref awaiter, ref this);
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

			// Token: 0x06004AA1 RID: 19105 RVA: 0x0012E3D4 File Offset: 0x0012C5D4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002FF6 RID: 12278
			public int <>1__state;

			// Token: 0x04002FF7 RID: 12279
			public AsyncTaskMethodBuilder<IEnumerable<workshop>> <>t__builder;

			// Token: 0x04002FF8 RID: 12280
			public int officeId;

			// Token: 0x04002FF9 RID: 12281
			public int ignoreAfter;

			// Token: 0x04002FFA RID: 12282
			public int userId;

			// Token: 0x04002FFB RID: 12283
			public int statusId;

			// Token: 0x04002FFC RID: 12284
			private GenericRepository<workshop> <repo>5__2;

			// Token: 0x04002FFD RID: 12285
			private TaskAwaiter<IEnumerable<workshop>> <>u__1;
		}

		// Token: 0x020009B8 RID: 2488
		[CompilerGenerated]
		private sealed class <>c__DisplayClass54_0
		{
			// Token: 0x06004AA2 RID: 19106 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass54_0()
			{
			}

			// Token: 0x06004AA3 RID: 19107 RVA: 0x0012E3F0 File Offset: 0x0012C5F0
			internal bool <GetFinancesChart>b__4(PaymentOptions s)
			{
				return s.Id == this.paymentSystem;
			}

			// Token: 0x04002FFE RID: 12286
			public DateTime from;

			// Token: 0x04002FFF RID: 12287
			public DateTime to;

			// Token: 0x04003000 RID: 12288
			public int officeId;

			// Token: 0x04003001 RID: 12289
			public int paymentSystem;

			// Token: 0x04003002 RID: 12290
			public int type;

			// Token: 0x04003003 RID: 12291
			public Func<PaymentOptions, bool> <>9__4;
		}

		// Token: 0x020009B9 RID: 2489
		[CompilerGenerated]
		private sealed class <>c__DisplayClass54_1
		{
			// Token: 0x06004AA4 RID: 19108 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass54_1()
			{
			}

			// Token: 0x06004AA5 RID: 19109 RVA: 0x0012E40C File Offset: 0x0012C60C
			internal bool <GetFinancesChart>b__5(cash_orders o)
			{
				return o.created.Date == this.day.Date;
			}

			// Token: 0x04003004 RID: 12292
			public DateTime day;
		}

		// Token: 0x020009BA RID: 2490
		[CompilerGenerated]
		private sealed class <>c__DisplayClass54_2
		{
			// Token: 0x06004AA6 RID: 19110 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass54_2()
			{
			}

			// Token: 0x06004AA7 RID: 19111 RVA: 0x0012E438 File Offset: 0x0012C638
			internal bool <GetFinancesChart>b__6(PaymentOptions s)
			{
				return s.Id == this.order.payment_system;
			}

			// Token: 0x04003005 RID: 12293
			public cash_orders order;
		}

		// Token: 0x020009BB RID: 2491
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetFinancesChart>d__54 : IAsyncStateMachine
		{
			// Token: 0x06004AA8 RID: 19112 RVA: 0x0012E458 File Offset: 0x0012C658
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<IChartData> result2;
				try
				{
					if (num != 0)
					{
						this.<>8__1 = new ChartModel.<>c__DisplayClass54_0();
						this.<>8__1.officeId = this.officeId;
						this.<>8__1.paymentSystem = this.paymentSystem;
						this.<>8__1.type = this.type;
						this.<>8__1.from = this.period.From.Date;
						this.<>8__1.to = this.period.To.Date.AddDays(1.0).AddSeconds(-1.0);
						this.<result>5__2 = new List<IChartData>();
						this.<repo>5__3 = new GenericRepository<cash_orders>();
					}
					try
					{
						TaskAwaiter<IEnumerable<cash_orders>> awaiter;
						if (num != 0)
						{
							this.<repo>5__3.AsNoTracking();
							List<KeyValuePair<bool, Expression<Func<cash_orders, bool>>>> filterList = new List<KeyValuePair<bool, Expression<Func<cash_orders, bool>>>>
							{
								new KeyValuePair<bool, Expression<Func<cash_orders, bool>>>(true, (cash_orders r) => r.created >= this.<>8__1.from && r.created <= this.<>8__1.to),
								new KeyValuePair<bool, Expression<Func<cash_orders, bool>>>(this.<>8__1.officeId > 0, (cash_orders r) => r.office == this.<>8__1.officeId),
								new KeyValuePair<bool, Expression<Func<cash_orders, bool>>>(this.<>8__1.paymentSystem != -100, (cash_orders r) => r.payment_system == this.<>8__1.paymentSystem),
								new KeyValuePair<bool, Expression<Func<cash_orders, bool>>>(this.<>8__1.type > 0, (cash_orders r) => r.type == this.<>8__1.type)
							};
							awaiter = this.<repo>5__3.GetAllAsync(filterList, null, "", false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<cash_orders>>, ChartModel.<GetFinancesChart>d__54>(ref awaiter, ref this);
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
						IEnumerable<cash_orders> result = awaiter.GetResult();
						IEnumerator<DateTime> enumerator = this.period.EachDay().GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								ChartModel.<>c__DisplayClass54_1 CS$<>8__locals1 = new ChartModel.<>c__DisplayClass54_1();
								CS$<>8__locals1.day = enumerator.Current;
								List<PaymentOptions> list;
								if (this.<>8__1.paymentSystem == -100)
								{
									list = OfflineData.Instance.PaymentOptionses;
								}
								else
								{
									IEnumerable<PaymentOptions> paymentOptionses = OfflineData.Instance.PaymentOptionses;
									Func<PaymentOptions, bool> predicate;
									if ((predicate = this.<>8__1.<>9__4) == null)
									{
										predicate = (this.<>8__1.<>9__4 = new Func<PaymentOptions, bool>(this.<>8__1.<GetFinancesChart>b__4));
									}
									list = paymentOptionses.Where(predicate).ToList<PaymentOptions>();
								}
								List<PaymentOptions>.Enumerator enumerator2 = list.GetEnumerator();
								try
								{
									while (enumerator2.MoveNext())
									{
										PaymentOptions paymentOptions = enumerator2.Current;
										this.<result>5__2.Add(new ChartData
										{
											SeriesDataMember = "Приход " + paymentOptions.Name,
											ArgumentDataMember = CS$<>8__locals1.day,
											ValueDataMember = 0m
										});
										this.<result>5__2.Add(new ChartData
										{
											SeriesDataMember = "Расход " + paymentOptions.Name,
											ArgumentDataMember = CS$<>8__locals1.day,
											ValueDataMember = 0m
										});
									}
								}
								finally
								{
									if (num < 0)
									{
										((IDisposable)enumerator2).Dispose();
									}
								}
								List<cash_orders>.Enumerator enumerator3 = result.Where(new Func<cash_orders, bool>(CS$<>8__locals1.<GetFinancesChart>b__5)).ToList<cash_orders>().GetEnumerator();
								try
								{
									while (enumerator3.MoveNext())
									{
										ChartModel.<>c__DisplayClass54_2 CS$<>8__locals2 = new ChartModel.<>c__DisplayClass54_2();
										CS$<>8__locals2.order = enumerator3.Current;
										PaymentOptions paymentOptions2 = OfflineData.Instance.PaymentOptionses.FirstOrDefault(new Func<PaymentOptions, bool>(CS$<>8__locals2.<GetFinancesChart>b__6));
										string str = (paymentOptions2 != null) ? paymentOptions2.Name : null;
										string seriesDataMember = (CS$<>8__locals2.order.summa > 0m) ? ("Приход " + str) : ("Расход " + str);
										this.<result>5__2.Add(new ChartData
										{
											SeriesDataMember = seriesDataMember,
											ArgumentDataMember = CS$<>8__locals1.day,
											ValueDataMember = CS$<>8__locals2.order.summa
										});
									}
								}
								finally
								{
									if (num < 0)
									{
										((IDisposable)enumerator3).Dispose();
									}
								}
							}
						}
						finally
						{
							if (num < 0 && enumerator != null)
							{
								enumerator.Dispose();
							}
						}
					}
					finally
					{
						if (num < 0 && this.<repo>5__3 != null)
						{
							((IDisposable)this.<repo>5__3).Dispose();
						}
					}
					this.<repo>5__3 = null;
					result2 = this.<result>5__2;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<result>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<result>5__2 = null;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06004AA9 RID: 19113 RVA: 0x0012EB44 File Offset: 0x0012CD44
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003006 RID: 12294
			public int <>1__state;

			// Token: 0x04003007 RID: 12295
			public AsyncTaskMethodBuilder<List<IChartData>> <>t__builder;

			// Token: 0x04003008 RID: 12296
			public int officeId;

			// Token: 0x04003009 RID: 12297
			public int paymentSystem;

			// Token: 0x0400300A RID: 12298
			public int type;

			// Token: 0x0400300B RID: 12299
			public IPeriod period;

			// Token: 0x0400300C RID: 12300
			private ChartModel.<>c__DisplayClass54_0 <>8__1;

			// Token: 0x0400300D RID: 12301
			private List<IChartData> <result>5__2;

			// Token: 0x0400300E RID: 12302
			private GenericRepository<cash_orders> <repo>5__3;

			// Token: 0x0400300F RID: 12303
			private TaskAwaiter<IEnumerable<cash_orders>> <>u__1;
		}
	}
}
