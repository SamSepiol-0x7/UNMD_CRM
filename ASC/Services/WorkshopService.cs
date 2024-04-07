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
using ASC.DAL;
using ASC.Extensions;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Objects.Converters;
using ASC.Services.Abstract;
using Autofac;
using Newtonsoft.Json;

namespace ASC.Services
{
	// Token: 0x0200060A RID: 1546
	public class WorkshopService : IWorkshopService
	{
		// Token: 0x06003794 RID: 14228 RVA: 0x000C15B4 File Offset: 0x000BF7B4
		public WorkshopService(ILoggerService<WorkshopService> logger, IContextFactory contextFactory, IHistoryV2 historyService)
		{
			this._logger = logger;
			this._contextFactory = contextFactory;
			this._historyService = historyService;
		}

		// Token: 0x06003795 RID: 14229 RVA: 0x000C15DC File Offset: 0x000BF7DC
		public Task<devices> GetDevice(int deviceId)
		{
			WorkshopService.<GetDevice>d__4 <GetDevice>d__;
			<GetDevice>d__.<>t__builder = AsyncTaskMethodBuilder<devices>.Create();
			<GetDevice>d__.deviceId = deviceId;
			<GetDevice>d__.<>1__state = -1;
			<GetDevice>d__.<>t__builder.Start<WorkshopService.<GetDevice>d__4>(ref <GetDevice>d__);
			return <GetDevice>d__.<>t__builder.Task;
		}

		// Token: 0x06003796 RID: 14230 RVA: 0x000C1620 File Offset: 0x000BF820
		public Task UpdateDevice(IDevice dev)
		{
			WorkshopService.<UpdateDevice>d__5 <UpdateDevice>d__;
			<UpdateDevice>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<UpdateDevice>d__.dev = dev;
			<UpdateDevice>d__.<>1__state = -1;
			<UpdateDevice>d__.<>t__builder.Start<WorkshopService.<UpdateDevice>d__5>(ref <UpdateDevice>d__);
			return <UpdateDevice>d__.<>t__builder.Task;
		}

		// Token: 0x06003797 RID: 14231 RVA: 0x000C1664 File Offset: 0x000BF864
		public Task UpdateDevice(int deviceId, string name)
		{
			WorkshopService.<UpdateDevice>d__6 <UpdateDevice>d__;
			<UpdateDevice>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<UpdateDevice>d__.deviceId = deviceId;
			<UpdateDevice>d__.name = name;
			<UpdateDevice>d__.<>1__state = -1;
			<UpdateDevice>d__.<>t__builder.Start<WorkshopService.<UpdateDevice>d__6>(ref <UpdateDevice>d__);
			return <UpdateDevice>d__.<>t__builder.Task;
		}

		// Token: 0x06003798 RID: 14232 RVA: 0x000C16B0 File Offset: 0x000BF8B0
		public Task<IEnumerable<IDevice>> GetActiveDevices()
		{
			WorkshopService.<GetActiveDevices>d__7 <GetActiveDevices>d__;
			<GetActiveDevices>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<IDevice>>.Create();
			<GetActiveDevices>d__.<>1__state = -1;
			<GetActiveDevices>d__.<>t__builder.Start<WorkshopService.<GetActiveDevices>d__7>(ref <GetActiveDevices>d__);
			return <GetActiveDevices>d__.<>t__builder.Task;
		}

		// Token: 0x06003799 RID: 14233 RVA: 0x000C16EC File Offset: 0x000BF8EC
		public Task<List<device_models>> GetModels(int makerId, int deviceType)
		{
			WorkshopService.<GetModels>d__8 <GetModels>d__;
			<GetModels>d__.<>t__builder = AsyncTaskMethodBuilder<List<device_models>>.Create();
			<GetModels>d__.makerId = makerId;
			<GetModels>d__.deviceType = deviceType;
			<GetModels>d__.<>1__state = -1;
			<GetModels>d__.<>t__builder.Start<WorkshopService.<GetModels>d__8>(ref <GetModels>d__);
			return <GetModels>d__.<>t__builder.Task;
		}

		// Token: 0x0600379A RID: 14234 RVA: 0x000C1738 File Offset: 0x000BF938
		public static int[] ExtractMakerIds(string companyList)
		{
			string[] array = companyList.Split(new char[]
			{
				','
			});
			int[] array2 = new int[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array2[i] = Convert.ToInt32(array[i]);
			}
			return array2;
		}

		// Token: 0x0600379B RID: 14235 RVA: 0x000C177C File Offset: 0x000BF97C
		public Task<IManufacturer> GetManufacturerByName(string name)
		{
			WorkshopService.<GetManufacturerByName>d__10 <GetManufacturerByName>d__;
			<GetManufacturerByName>d__.<>t__builder = AsyncTaskMethodBuilder<IManufacturer>.Create();
			<GetManufacturerByName>d__.name = name;
			<GetManufacturerByName>d__.<>1__state = -1;
			<GetManufacturerByName>d__.<>t__builder.Start<WorkshopService.<GetManufacturerByName>d__10>(ref <GetManufacturerByName>d__);
			return <GetManufacturerByName>d__.<>t__builder.Task;
		}

		// Token: 0x0600379C RID: 14236 RVA: 0x000C17C0 File Offset: 0x000BF9C0
		public Task<IEnumerable<IManufacturer>> GetManufacturers(int deviceId)
		{
			WorkshopService.<GetManufacturers>d__11 <GetManufacturers>d__;
			<GetManufacturers>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<IManufacturer>>.Create();
			<GetManufacturers>d__.<>4__this = this;
			<GetManufacturers>d__.deviceId = deviceId;
			<GetManufacturers>d__.<>1__state = -1;
			<GetManufacturers>d__.<>t__builder.Start<WorkshopService.<GetManufacturers>d__11>(ref <GetManufacturers>d__);
			return <GetManufacturers>d__.<>t__builder.Task;
		}

		// Token: 0x0600379D RID: 14237 RVA: 0x000C180C File Offset: 0x000BFA0C
		public Task<IEnumerable<IManufacturer>> GetManufacturers(string companyList)
		{
			WorkshopService.<GetManufacturers>d__12 <GetManufacturers>d__;
			<GetManufacturers>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<IManufacturer>>.Create();
			<GetManufacturers>d__.companyList = companyList;
			<GetManufacturers>d__.<>1__state = -1;
			<GetManufacturers>d__.<>t__builder.Start<WorkshopService.<GetManufacturers>d__12>(ref <GetManufacturers>d__);
			return <GetManufacturers>d__.<>t__builder.Task;
		}

		// Token: 0x0600379E RID: 14238 RVA: 0x000C1850 File Offset: 0x000BFA50
		public Task<IDevice> GetRefillDevice()
		{
			WorkshopService.<GetRefillDevice>d__13 <GetRefillDevice>d__;
			<GetRefillDevice>d__.<>t__builder = AsyncTaskMethodBuilder<IDevice>.Create();
			<GetRefillDevice>d__.<>1__state = -1;
			<GetRefillDevice>d__.<>t__builder.Start<WorkshopService.<GetRefillDevice>d__13>(ref <GetRefillDevice>d__);
			return <GetRefillDevice>d__.<>t__builder.Task;
		}

		// Token: 0x0600379F RID: 14239 RVA: 0x000C188C File Offset: 0x000BFA8C
		public Task<ICustomer> GetOrderCustomer(int repairId)
		{
			WorkshopService.<GetOrderCustomer>d__14 <GetOrderCustomer>d__;
			<GetOrderCustomer>d__.<>t__builder = AsyncTaskMethodBuilder<ICustomer>.Create();
			<GetOrderCustomer>d__.repairId = repairId;
			<GetOrderCustomer>d__.<>1__state = -1;
			<GetOrderCustomer>d__.<>t__builder.Start<WorkshopService.<GetOrderCustomer>d__14>(ref <GetOrderCustomer>d__);
			return <GetOrderCustomer>d__.<>t__builder.Task;
		}

		// Token: 0x060037A0 RID: 14240 RVA: 0x000C18D0 File Offset: 0x000BFAD0
		public Task UpdateRepairCostAndWarranty(auseceEntities ctx, int repairId)
		{
			WorkshopService.<UpdateRepairCostAndWarranty>d__15 <UpdateRepairCostAndWarranty>d__;
			<UpdateRepairCostAndWarranty>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<UpdateRepairCostAndWarranty>d__.<>4__this = this;
			<UpdateRepairCostAndWarranty>d__.ctx = ctx;
			<UpdateRepairCostAndWarranty>d__.repairId = repairId;
			<UpdateRepairCostAndWarranty>d__.<>1__state = -1;
			<UpdateRepairCostAndWarranty>d__.<>t__builder.Start<WorkshopService.<UpdateRepairCostAndWarranty>d__15>(ref <UpdateRepairCostAndWarranty>d__);
			return <UpdateRepairCostAndWarranty>d__.<>t__builder.Task;
		}

		// Token: 0x060037A1 RID: 14241 RVA: 0x000C1924 File Offset: 0x000BFB24
		private Task<int> GetWarranty(auseceEntities ctx, int repairId)
		{
			WorkshopService.<GetWarranty>d__16 <GetWarranty>d__;
			<GetWarranty>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<GetWarranty>d__.<>4__this = this;
			<GetWarranty>d__.ctx = ctx;
			<GetWarranty>d__.repairId = repairId;
			<GetWarranty>d__.<>1__state = -1;
			<GetWarranty>d__.<>t__builder.Start<WorkshopService.<GetWarranty>d__16>(ref <GetWarranty>d__);
			return <GetWarranty>d__.<>t__builder.Task;
		}

		// Token: 0x060037A2 RID: 14242 RVA: 0x000C1978 File Offset: 0x000BFB78
		private Task<int?> GetMaxWorksWarranty(auseceEntities ctx, int repairId)
		{
			WorkshopService.<GetMaxWorksWarranty>d__17 <GetMaxWorksWarranty>d__;
			<GetMaxWorksWarranty>d__.<>t__builder = AsyncTaskMethodBuilder<int?>.Create();
			<GetMaxWorksWarranty>d__.ctx = ctx;
			<GetMaxWorksWarranty>d__.repairId = repairId;
			<GetMaxWorksWarranty>d__.<>1__state = -1;
			<GetMaxWorksWarranty>d__.<>t__builder.Start<WorkshopService.<GetMaxWorksWarranty>d__17>(ref <GetMaxWorksWarranty>d__);
			return <GetMaxWorksWarranty>d__.<>t__builder.Task;
		}

		// Token: 0x060037A3 RID: 14243 RVA: 0x000C19C4 File Offset: 0x000BFBC4
		private Task<int?> GetMaxPartsWarranty(auseceEntities ctx, int repairId)
		{
			WorkshopService.<GetMaxPartsWarranty>d__18 <GetMaxPartsWarranty>d__;
			<GetMaxPartsWarranty>d__.<>t__builder = AsyncTaskMethodBuilder<int?>.Create();
			<GetMaxPartsWarranty>d__.ctx = ctx;
			<GetMaxPartsWarranty>d__.repairId = repairId;
			<GetMaxPartsWarranty>d__.<>1__state = -1;
			<GetMaxPartsWarranty>d__.<>t__builder.Start<WorkshopService.<GetMaxPartsWarranty>d__18>(ref <GetMaxPartsWarranty>d__);
			return <GetMaxPartsWarranty>d__.<>t__builder.Task;
		}

		// Token: 0x060037A4 RID: 14244 RVA: 0x000C1A10 File Offset: 0x000BFC10
		public Task<decimal> TotalWorksCost(auseceEntities ctx, int repairId)
		{
			return (from w in ctx.works
			where w.repair == (int?)repairId
			select w.price * (decimal)w.count).DefaultIfEmpty<decimal>().SumAsync();
		}

		// Token: 0x060037A5 RID: 14245 RVA: 0x000C1B24 File Offset: 0x000BFD24
		public Task<decimal> TotalPartsCost(auseceEntities ctx, int repairId)
		{
			return (from p in ctx.store_int_reserve
			where p.repair_id == (int?)repairId && (p.state == 2 || p.state == 3)
			select (decimal)p.count * p.price).DefaultIfEmpty<decimal>().SumAsync();
		}

		// Token: 0x060037A6 RID: 14246 RVA: 0x000C1CA0 File Offset: 0x000BFEA0
		public Task SaveBox(int repairId, int? boxId)
		{
			WorkshopService.<SaveBox>d__21 <SaveBox>d__;
			<SaveBox>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<SaveBox>d__.<>4__this = this;
			<SaveBox>d__.repairId = repairId;
			<SaveBox>d__.boxId = boxId;
			<SaveBox>d__.<>1__state = -1;
			<SaveBox>d__.<>t__builder.Start<WorkshopService.<SaveBox>d__21>(ref <SaveBox>d__);
			return <SaveBox>d__.<>t__builder.Task;
		}

		// Token: 0x060037A7 RID: 14247 RVA: 0x000C1CF4 File Offset: 0x000BFEF4
		public Task SaveIssuingMessage(int repairId, string msg)
		{
			WorkshopService.<SaveIssuingMessage>d__22 <SaveIssuingMessage>d__;
			<SaveIssuingMessage>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<SaveIssuingMessage>d__.<>4__this = this;
			<SaveIssuingMessage>d__.repairId = repairId;
			<SaveIssuingMessage>d__.msg = msg;
			<SaveIssuingMessage>d__.<>1__state = -1;
			<SaveIssuingMessage>d__.<>t__builder.Start<WorkshopService.<SaveIssuingMessage>d__22>(ref <SaveIssuingMessage>d__);
			return <SaveIssuingMessage>d__.<>t__builder.Task;
		}

		// Token: 0x060037A8 RID: 14248 RVA: 0x000C1D48 File Offset: 0x000BFF48
		public Task SetRepairColor(int repairId, string color)
		{
			WorkshopService.<SetRepairColor>d__23 <SetRepairColor>d__;
			<SetRepairColor>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<SetRepairColor>d__.<>4__this = this;
			<SetRepairColor>d__.repairId = repairId;
			<SetRepairColor>d__.color = color;
			<SetRepairColor>d__.<>1__state = -1;
			<SetRepairColor>d__.<>t__builder.Start<WorkshopService.<SetRepairColor>d__23>(ref <SetRepairColor>d__);
			return <SetRepairColor>d__.<>t__builder.Task;
		}

		// Token: 0x060037A9 RID: 14249 RVA: 0x000C1D9C File Offset: 0x000BFF9C
		public Task SaveWarrantyLabel(int repairId, string warrantyLabel)
		{
			WorkshopService.<SaveWarrantyLabel>d__24 <SaveWarrantyLabel>d__;
			<SaveWarrantyLabel>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<SaveWarrantyLabel>d__.<>4__this = this;
			<SaveWarrantyLabel>d__.repairId = repairId;
			<SaveWarrantyLabel>d__.warrantyLabel = warrantyLabel;
			<SaveWarrantyLabel>d__.<>1__state = -1;
			<SaveWarrantyLabel>d__.<>t__builder.Start<WorkshopService.<SaveWarrantyLabel>d__24>(ref <SaveWarrantyLabel>d__);
			return <SaveWarrantyLabel>d__.<>t__builder.Task;
		}

		// Token: 0x060037AA RID: 14250 RVA: 0x000C1DF0 File Offset: 0x000BFFF0
		public Task UpdateInformStatus(int repairId, int status)
		{
			WorkshopService.<UpdateInformStatus>d__25 <UpdateInformStatus>d__;
			<UpdateInformStatus>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<UpdateInformStatus>d__.<>4__this = this;
			<UpdateInformStatus>d__.repairId = repairId;
			<UpdateInformStatus>d__.status = status;
			<UpdateInformStatus>d__.<>1__state = -1;
			<UpdateInformStatus>d__.<>t__builder.Start<WorkshopService.<UpdateInformStatus>d__25>(ref <UpdateInformStatus>d__);
			return <UpdateInformStatus>d__.<>t__builder.Task;
		}

		// Token: 0x060037AB RID: 14251 RVA: 0x000C1E44 File Offset: 0x000C0044
		public Task ChangeCustomer(int repairId, ICustomer customer)
		{
			WorkshopService.<ChangeCustomer>d__26 <ChangeCustomer>d__;
			<ChangeCustomer>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ChangeCustomer>d__.<>4__this = this;
			<ChangeCustomer>d__.repairId = repairId;
			<ChangeCustomer>d__.customer = customer;
			<ChangeCustomer>d__.<>1__state = -1;
			<ChangeCustomer>d__.<>t__builder.Start<WorkshopService.<ChangeCustomer>d__26>(ref <ChangeCustomer>d__);
			return <ChangeCustomer>d__.<>t__builder.Task;
		}

		// Token: 0x060037AC RID: 14252 RVA: 0x000C1E98 File Offset: 0x000C0098
		public Task ChangeMaster(int repairId, int? master)
		{
			WorkshopService.<ChangeMaster>d__27 <ChangeMaster>d__;
			<ChangeMaster>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ChangeMaster>d__.<>4__this = this;
			<ChangeMaster>d__.repairId = repairId;
			<ChangeMaster>d__.master = master;
			<ChangeMaster>d__.<>1__state = -1;
			<ChangeMaster>d__.<>t__builder.Start<WorkshopService.<ChangeMaster>d__27>(ref <ChangeMaster>d__);
			return <ChangeMaster>d__.<>t__builder.Task;
		}

		// Token: 0x060037AD RID: 14253 RVA: 0x000C1EEC File Offset: 0x000C00EC
		public Task ChangeManager(workshop repair)
		{
			WorkshopService.<ChangeManager>d__28 <ChangeManager>d__;
			<ChangeManager>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ChangeManager>d__.<>4__this = this;
			<ChangeManager>d__.repair = repair;
			<ChangeManager>d__.<>1__state = -1;
			<ChangeManager>d__.<>t__builder.Start<WorkshopService.<ChangeManager>d__28>(ref <ChangeManager>d__);
			return <ChangeManager>d__.<>t__builder.Task;
		}

		// Token: 0x060037AE RID: 14254 RVA: 0x000C1F38 File Offset: 0x000C0138
		public Task ChangeOffice(workshop repair)
		{
			WorkshopService.<ChangeOffice>d__29 <ChangeOffice>d__;
			<ChangeOffice>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ChangeOffice>d__.<>4__this = this;
			<ChangeOffice>d__.repair = repair;
			<ChangeOffice>d__.<>1__state = -1;
			<ChangeOffice>d__.<>t__builder.Start<WorkshopService.<ChangeOffice>d__29>(ref <ChangeOffice>d__);
			return <ChangeOffice>d__.<>t__builder.Task;
		}

		// Token: 0x060037AF RID: 14255 RVA: 0x000C1F84 File Offset: 0x000C0184
		public string LogOrderMoving(workshop repair, int newOffice)
		{
			if (string.IsNullOrEmpty(repair.order_moving))
			{
				return JsonConvert.SerializeObject(new List<int>
				{
					repair.office,
					newOffice
				});
			}
			string result;
			try
			{
				List<int> list = JsonConvert.DeserializeObject<List<int>>(repair.order_moving);
				list.Add(newOffice);
				result = JsonConvert.SerializeObject(list);
			}
			catch (Exception ex)
			{
				this._logger.Info(ex.Message);
				result = null;
			}
			return result;
		}

		// Token: 0x060037B0 RID: 14256 RVA: 0x000C2000 File Offset: 0x000C0200
		public Task DeleteAsync(int repairId)
		{
			WorkshopService.<DeleteAsync>d__31 <DeleteAsync>d__;
			<DeleteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<DeleteAsync>d__.<>4__this = this;
			<DeleteAsync>d__.repairId = repairId;
			<DeleteAsync>d__.<>1__state = -1;
			<DeleteAsync>d__.<>t__builder.Start<WorkshopService.<DeleteAsync>d__31>(ref <DeleteAsync>d__);
			return <DeleteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060037B1 RID: 14257 RVA: 0x000C204C File Offset: 0x000C024C
		public Task RestoreAsync(int repairId)
		{
			WorkshopService.<RestoreAsync>d__32 <RestoreAsync>d__;
			<RestoreAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<RestoreAsync>d__.<>4__this = this;
			<RestoreAsync>d__.repairId = repairId;
			<RestoreAsync>d__.<>1__state = -1;
			<RestoreAsync>d__.<>t__builder.Start<WorkshopService.<RestoreAsync>d__32>(ref <RestoreAsync>d__);
			return <RestoreAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060037B2 RID: 14258 RVA: 0x000C2098 File Offset: 0x000C0298
		public Task<int> CreateRepair(workshop repair)
		{
			WorkshopService.<CreateRepair>d__33 <CreateRepair>d__;
			<CreateRepair>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<CreateRepair>d__.<>4__this = this;
			<CreateRepair>d__.repair = repair;
			<CreateRepair>d__.<>1__state = -1;
			<CreateRepair>d__.<>t__builder.Start<WorkshopService.<CreateRepair>d__33>(ref <CreateRepair>d__);
			return <CreateRepair>d__.<>t__builder.Task;
		}

		// Token: 0x060037B3 RID: 14259 RVA: 0x000C20E4 File Offset: 0x000C02E4
		public static Task SetOrderTitle(workshop repair, auseceEntities ctx)
		{
			WorkshopService.<SetOrderTitle>d__34 <SetOrderTitle>d__;
			<SetOrderTitle>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<SetOrderTitle>d__.repair = repair;
			<SetOrderTitle>d__.ctx = ctx;
			<SetOrderTitle>d__.<>1__state = -1;
			<SetOrderTitle>d__.<>t__builder.Start<WorkshopService.<SetOrderTitle>d__34>(ref <SetOrderTitle>d__);
			return <SetOrderTitle>d__.<>t__builder.Task;
		}

		// Token: 0x060037B4 RID: 14260 RVA: 0x000C2130 File Offset: 0x000C0330
		public Task<workshop> GetRepair(int repairId)
		{
			WorkshopService.<GetRepair>d__35 <GetRepair>d__;
			<GetRepair>d__.<>t__builder = AsyncTaskMethodBuilder<workshop>.Create();
			<GetRepair>d__.<>4__this = this;
			<GetRepair>d__.repairId = repairId;
			<GetRepair>d__.<>1__state = -1;
			<GetRepair>d__.<>t__builder.Start<WorkshopService.<GetRepair>d__35>(ref <GetRepair>d__);
			return <GetRepair>d__.<>t__builder.Task;
		}

		// Token: 0x060037B5 RID: 14261 RVA: 0x000C217C File Offset: 0x000C037C
		public Task<PreviousRepair> GetRepairInfo(int repairId)
		{
			WorkshopService.<GetRepairInfo>d__36 <GetRepairInfo>d__;
			<GetRepairInfo>d__.<>t__builder = AsyncTaskMethodBuilder<PreviousRepair>.Create();
			<GetRepairInfo>d__.<>4__this = this;
			<GetRepairInfo>d__.repairId = repairId;
			<GetRepairInfo>d__.<>1__state = -1;
			<GetRepairInfo>d__.<>t__builder.Start<WorkshopService.<GetRepairInfo>d__36>(ref <GetRepairInfo>d__);
			return <GetRepairInfo>d__.<>t__builder.Task;
		}

		// Token: 0x060037B6 RID: 14262 RVA: 0x000C21C8 File Offset: 0x000C03C8
		public Task<int> GetRepairCustomerId(int repairId)
		{
			WorkshopService.<GetRepairCustomerId>d__37 <GetRepairCustomerId>d__;
			<GetRepairCustomerId>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<GetRepairCustomerId>d__.<>4__this = this;
			<GetRepairCustomerId>d__.repairId = repairId;
			<GetRepairCustomerId>d__.<>1__state = -1;
			<GetRepairCustomerId>d__.<>t__builder.Start<WorkshopService.<GetRepairCustomerId>d__37>(ref <GetRepairCustomerId>d__);
			return <GetRepairCustomerId>d__.<>t__builder.Task;
		}

		// Token: 0x060037B7 RID: 14263 RVA: 0x000C2214 File Offset: 0x000C0414
		public Task<RepairPaymentInfo> GetRepairPaymentInfo(int repairId)
		{
			WorkshopService.<GetRepairPaymentInfo>d__38 <GetRepairPaymentInfo>d__;
			<GetRepairPaymentInfo>d__.<>t__builder = AsyncTaskMethodBuilder<RepairPaymentInfo>.Create();
			<GetRepairPaymentInfo>d__.<>4__this = this;
			<GetRepairPaymentInfo>d__.repairId = repairId;
			<GetRepairPaymentInfo>d__.<>1__state = -1;
			<GetRepairPaymentInfo>d__.<>t__builder.Start<WorkshopService.<GetRepairPaymentInfo>d__38>(ref <GetRepairPaymentInfo>d__);
			return <GetRepairPaymentInfo>d__.<>t__builder.Task;
		}

		// Token: 0x060037B8 RID: 14264 RVA: 0x000C2260 File Offset: 0x000C0460
		public Task<RepairDeviceInfo> GetRepairDeviceInfo(int repairId)
		{
			WorkshopService.<GetRepairDeviceInfo>d__39 <GetRepairDeviceInfo>d__;
			<GetRepairDeviceInfo>d__.<>t__builder = AsyncTaskMethodBuilder<RepairDeviceInfo>.Create();
			<GetRepairDeviceInfo>d__.<>4__this = this;
			<GetRepairDeviceInfo>d__.repairId = repairId;
			<GetRepairDeviceInfo>d__.<>1__state = -1;
			<GetRepairDeviceInfo>d__.<>t__builder.Start<WorkshopService.<GetRepairDeviceInfo>d__39>(ref <GetRepairDeviceInfo>d__);
			return <GetRepairDeviceInfo>d__.<>t__builder.Task;
		}

		// Token: 0x060037B9 RID: 14265 RVA: 0x000C22AC File Offset: 0x000C04AC
		public Task<RepairMassEditModel> GetMassEditModel(int repairId)
		{
			WorkshopService.<GetMassEditModel>d__40 <GetMassEditModel>d__;
			<GetMassEditModel>d__.<>t__builder = AsyncTaskMethodBuilder<RepairMassEditModel>.Create();
			<GetMassEditModel>d__.<>4__this = this;
			<GetMassEditModel>d__.repairId = repairId;
			<GetMassEditModel>d__.<>1__state = -1;
			<GetMassEditModel>d__.<>t__builder.Start<WorkshopService.<GetMassEditModel>d__40>(ref <GetMassEditModel>d__);
			return <GetMassEditModel>d__.<>t__builder.Task;
		}

		// Token: 0x060037BA RID: 14266 RVA: 0x000C22F8 File Offset: 0x000C04F8
		public Task UpdateRepairs(IList<RepairMassEditModel> items)
		{
			WorkshopService.<UpdateRepairs>d__41 <UpdateRepairs>d__;
			<UpdateRepairs>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<UpdateRepairs>d__.<>4__this = this;
			<UpdateRepairs>d__.items = items;
			<UpdateRepairs>d__.<>1__state = -1;
			<UpdateRepairs>d__.<>t__builder.Start<WorkshopService.<UpdateRepairs>d__41>(ref <UpdateRepairs>d__);
			return <UpdateRepairs>d__.<>t__builder.Task;
		}

		// Token: 0x060037BB RID: 14267 RVA: 0x000C2344 File Offset: 0x000C0544
		public Task UpdateDiagnosticResult(workshop repair)
		{
			WorkshopService.<UpdateDiagnosticResult>d__42 <UpdateDiagnosticResult>d__;
			<UpdateDiagnosticResult>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<UpdateDiagnosticResult>d__.repair = repair;
			<UpdateDiagnosticResult>d__.<>1__state = -1;
			<UpdateDiagnosticResult>d__.<>t__builder.Start<WorkshopService.<UpdateDiagnosticResult>d__42>(ref <UpdateDiagnosticResult>d__);
			return <UpdateDiagnosticResult>d__.<>t__builder.Task;
		}

		// Token: 0x04002080 RID: 8320
		private readonly ILoggerService<WorkshopService> _logger;

		// Token: 0x04002081 RID: 8321
		private readonly IContextFactory _contextFactory;

		// Token: 0x04002082 RID: 8322
		private readonly IHistoryV2 _historyService;

		// Token: 0x0200060B RID: 1547
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x060037BC RID: 14268 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x04002083 RID: 8323
			public int deviceId;
		}

		// Token: 0x0200060C RID: 1548
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetDevice>d__4 : IAsyncStateMachine
		{
			// Token: 0x060037BD RID: 14269 RVA: 0x000C2388 File Offset: 0x000C0588
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				devices result;
				try
				{
					WorkshopService.<>c__DisplayClass4_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new WorkshopService.<>c__DisplayClass4_0();
						CS$<>8__locals1.deviceId = this.deviceId;
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						ConfiguredTaskAwaitable<devices>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = this.<ctx>5__2.devices.AsNoTracking().FirstOrDefaultAsync((devices i) => i.id == CS$<>8__locals1.deviceId).ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<devices>.ConfiguredTaskAwaiter, WorkshopService.<GetDevice>d__4>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<devices>.ConfiguredTaskAwaiter);
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

			// Token: 0x060037BE RID: 14270 RVA: 0x000C2514 File Offset: 0x000C0714
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002084 RID: 8324
			public int <>1__state;

			// Token: 0x04002085 RID: 8325
			public AsyncTaskMethodBuilder<devices> <>t__builder;

			// Token: 0x04002086 RID: 8326
			public int deviceId;

			// Token: 0x04002087 RID: 8327
			private auseceEntities <ctx>5__2;

			// Token: 0x04002088 RID: 8328
			private ConfiguredTaskAwaitable<devices>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x0200060D RID: 1549
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateDevice>d__5 : IAsyncStateMachine
		{
			// Token: 0x060037BF RID: 14271 RVA: 0x000C2530 File Offset: 0x000C0730
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					if (num > 1)
					{
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter awaiter;
						ConfiguredTaskAwaitable<devices>.ConfiguredTaskAwaiter awaiter2;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = this.<>u__2;
								this.<>u__2 = default(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								goto IL_120;
							}
							awaiter2 = this.<ctx>5__2.devices.FindAsync(new object[]
							{
								this.dev.Id
							}).ConfigureAwait(false).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num3 = 0;
								num = 0;
								this.<>1__state = num3;
								this.<>u__1 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<devices>.ConfiguredTaskAwaiter, WorkshopService.<UpdateDevice>d__5>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<devices>.ConfiguredTaskAwaiter);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
						}
						devices result = awaiter2.GetResult();
						result.fault_list = this.dev.FaultList;
						result.look_list = this.dev.LookList;
						result.complect_list = this.dev.ComplectList;
						awaiter = this.<ctx>5__2.SaveChangesAsync().ConfigureAwait(false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num5 = 1;
							num = 1;
							this.<>1__state = num5;
							this.<>u__2 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter, WorkshopService.<UpdateDevice>d__5>(ref awaiter, ref this);
							return;
						}
						IL_120:
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

			// Token: 0x060037C0 RID: 14272 RVA: 0x000C2708 File Offset: 0x000C0908
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002089 RID: 8329
			public int <>1__state;

			// Token: 0x0400208A RID: 8330
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400208B RID: 8331
			public IDevice dev;

			// Token: 0x0400208C RID: 8332
			private auseceEntities <ctx>5__2;

			// Token: 0x0400208D RID: 8333
			private ConfiguredTaskAwaitable<devices>.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x0400208E RID: 8334
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__2;
		}

		// Token: 0x0200060E RID: 1550
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateDevice>d__6 : IAsyncStateMachine
		{
			// Token: 0x060037C1 RID: 14273 RVA: 0x000C2724 File Offset: 0x000C0924
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					if (num > 1)
					{
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter awaiter;
						ConfiguredTaskAwaitable<devices>.ConfiguredTaskAwaiter awaiter2;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = this.<>u__2;
								this.<>u__2 = default(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								goto IL_149;
							}
							this.<history>5__3 = new HistoryV2();
							awaiter2 = this.<ctx>5__2.devices.FindAsync(new object[]
							{
								this.deviceId
							}).ConfigureAwait(false).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num3 = 0;
								num = 0;
								this.<>1__state = num3;
								this.<>u__1 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<devices>.ConfiguredTaskAwaiter, WorkshopService.<UpdateDevice>d__6>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<devices>.ConfiguredTaskAwaiter);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
						}
						devices result = awaiter2.GetResult();
						this.<history>5__3.Add(56, new string[]
						{
							result.name,
							this.name
						});
						result.name = this.name;
						awaiter = this.<ctx>5__2.SaveChangesAsync().ConfigureAwait(false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num5 = 1;
							num = 1;
							this.<>1__state = num5;
							this.<>u__2 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter, WorkshopService.<UpdateDevice>d__6>(ref awaiter, ref this);
							return;
						}
						IL_149:
						awaiter.GetResult();
						this.<history>5__3.Save();
						this.<history>5__3 = null;
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

			// Token: 0x060037C2 RID: 14274 RVA: 0x000C2918 File Offset: 0x000C0B18
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400208F RID: 8335
			public int <>1__state;

			// Token: 0x04002090 RID: 8336
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002091 RID: 8337
			public int deviceId;

			// Token: 0x04002092 RID: 8338
			public string name;

			// Token: 0x04002093 RID: 8339
			private auseceEntities <ctx>5__2;

			// Token: 0x04002094 RID: 8340
			private HistoryV2 <history>5__3;

			// Token: 0x04002095 RID: 8341
			private ConfiguredTaskAwaitable<devices>.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x04002096 RID: 8342
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__2;
		}

		// Token: 0x0200060F RID: 1551
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060037C3 RID: 14275 RVA: 0x000C2934 File Offset: 0x000C0B34
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060037C4 RID: 14276 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x060037C5 RID: 14277 RVA: 0x000C294C File Offset: 0x000C0B4C
			internal Device <GetActiveDevices>b__7_0(devices d)
			{
				return d.ToDevice();
			}

			// Token: 0x060037C6 RID: 14278 RVA: 0x000C2960 File Offset: 0x000C0B60
			internal <>f__AnonymousType4<int, int> <GetManufacturers>b__12_0(int i, int v)
			{
				return new
				{
					Index = i,
					Value = v
				};
			}

			// Token: 0x060037C7 RID: 14279 RVA: 0x000C2974 File Offset: 0x000C0B74
			internal int <GetManufacturers>b__12_1(<>f__AnonymousType4<int, int> pair)
			{
				return pair.Index;
			}

			// Token: 0x060037C8 RID: 14280 RVA: 0x000C2988 File Offset: 0x000C0B88
			internal int <GetManufacturers>b__12_2(<>f__AnonymousType4<int, int> pair)
			{
				return pair.Value;
			}

			// Token: 0x060037C9 RID: 14281 RVA: 0x000C299C File Offset: 0x000C0B9C
			internal IManufacturer <GetManufacturers>b__12_4(device_makers dm)
			{
				return dm.ToManufacturer();
			}

			// Token: 0x04002097 RID: 8343
			public static readonly WorkshopService.<>c <>9 = new WorkshopService.<>c();

			// Token: 0x04002098 RID: 8344
			public static Func<devices, Device> <>9__7_0;

			// Token: 0x04002099 RID: 8345
			public static Func<int, int, <>f__AnonymousType4<int, int>> <>9__12_0;

			// Token: 0x0400209A RID: 8346
			public static Func<<>f__AnonymousType4<int, int>, int> <>9__12_1;

			// Token: 0x0400209B RID: 8347
			public static Func<<>f__AnonymousType4<int, int>, int> <>9__12_2;

			// Token: 0x0400209C RID: 8348
			public static Func<device_makers, IManufacturer> <>9__12_4;
		}

		// Token: 0x02000610 RID: 1552
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetActiveDevices>d__7 : IAsyncStateMachine
		{
			// Token: 0x060037CA RID: 14282 RVA: 0x000C29B0 File Offset: 0x000C0BB0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IEnumerable<IDevice> result;
				try
				{
					if (num != 0)
					{
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						ConfiguredTaskAwaitable<List<devices>>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = (from d in this.<ctx>5__2.devices.AsNoTracking()
							where d.enable != (bool?)false
							select d into o
							orderby o.position
							select o).ToListAsync<devices>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<List<devices>>.ConfiguredTaskAwaiter, WorkshopService.<GetActiveDevices>d__7>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<List<devices>>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult().Select(new Func<devices, Device>(WorkshopService.<>c.<>9.<GetActiveDevices>b__7_0)).ToList<Device>();
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

			// Token: 0x060037CB RID: 14283 RVA: 0x000C2B98 File Offset: 0x000C0D98
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400209D RID: 8349
			public int <>1__state;

			// Token: 0x0400209E RID: 8350
			public AsyncTaskMethodBuilder<IEnumerable<IDevice>> <>t__builder;

			// Token: 0x0400209F RID: 8351
			private auseceEntities <ctx>5__2;

			// Token: 0x040020A0 RID: 8352
			private ConfiguredTaskAwaitable<List<devices>>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000611 RID: 1553
		[CompilerGenerated]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x060037CC RID: 14284 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x040020A1 RID: 8353
			public int makerId;

			// Token: 0x040020A2 RID: 8354
			public int deviceType;
		}

		// Token: 0x02000612 RID: 1554
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetModels>d__8 : IAsyncStateMachine
		{
			// Token: 0x060037CD RID: 14285 RVA: 0x000C2BB4 File Offset: 0x000C0DB4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<device_models> result;
				try
				{
					WorkshopService.<>c__DisplayClass8_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new WorkshopService.<>c__DisplayClass8_0();
						CS$<>8__locals1.makerId = this.makerId;
						CS$<>8__locals1.deviceType = this.deviceType;
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						ConfiguredTaskAwaitable<List<device_models>>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = (from m in this.<ctx>5__2.device_models.AsNoTracking()
							where m.maker == CS$<>8__locals1.makerId && m.device == (int?)CS$<>8__locals1.deviceType
							orderby m.name
							select m).ToListAsync<device_models>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<List<device_models>>.ConfiguredTaskAwaiter, WorkshopService.<GetModels>d__8>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<List<device_models>>.ConfiguredTaskAwaiter);
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

			// Token: 0x060037CE RID: 14286 RVA: 0x000C2DE0 File Offset: 0x000C0FE0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040020A3 RID: 8355
			public int <>1__state;

			// Token: 0x040020A4 RID: 8356
			public AsyncTaskMethodBuilder<List<device_models>> <>t__builder;

			// Token: 0x040020A5 RID: 8357
			public int makerId;

			// Token: 0x040020A6 RID: 8358
			public int deviceType;

			// Token: 0x040020A7 RID: 8359
			private auseceEntities <ctx>5__2;

			// Token: 0x040020A8 RID: 8360
			private ConfiguredTaskAwaitable<List<device_models>>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000613 RID: 1555
		[CompilerGenerated]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x060037CF RID: 14287 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x040020A9 RID: 8361
			public string name;
		}

		// Token: 0x02000614 RID: 1556
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetManufacturerByName>d__10 : IAsyncStateMachine
		{
			// Token: 0x060037D0 RID: 14288 RVA: 0x000C2DFC File Offset: 0x000C0FFC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IManufacturer result;
				try
				{
					WorkshopService.<>c__DisplayClass10_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new WorkshopService.<>c__DisplayClass10_0();
						CS$<>8__locals1.name = this.name;
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						ConfiguredTaskAwaitable<device_makers>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = this.<ctx>5__2.device_makers.FirstOrDefaultAsync((device_makers i) => i.name == CS$<>8__locals1.name).ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<device_makers>.ConfiguredTaskAwaiter, WorkshopService.<GetManufacturerByName>d__10>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<device_makers>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult().ToManufacturer();
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

			// Token: 0x060037D1 RID: 14289 RVA: 0x000C2F88 File Offset: 0x000C1188
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040020AA RID: 8362
			public int <>1__state;

			// Token: 0x040020AB RID: 8363
			public AsyncTaskMethodBuilder<IManufacturer> <>t__builder;

			// Token: 0x040020AC RID: 8364
			public string name;

			// Token: 0x040020AD RID: 8365
			private auseceEntities <ctx>5__2;

			// Token: 0x040020AE RID: 8366
			private ConfiguredTaskAwaitable<device_makers>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000615 RID: 1557
		[CompilerGenerated]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x060037D2 RID: 14290 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass11_0()
			{
			}

			// Token: 0x040020AF RID: 8367
			public int deviceId;
		}

		// Token: 0x02000616 RID: 1558
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetManufacturers>d__11 : IAsyncStateMachine
		{
			// Token: 0x060037D3 RID: 14291 RVA: 0x000C2FA4 File Offset: 0x000C11A4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopService workshopService = this.<>4__this;
				IEnumerable<IManufacturer> result2;
				try
				{
					WorkshopService.<>c__DisplayClass11_0 CS$<>8__locals1;
					if (num > 1)
					{
						CS$<>8__locals1 = new WorkshopService.<>c__DisplayClass11_0();
						CS$<>8__locals1.deviceId = this.deviceId;
						this.<ctx>5__2 = workshopService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<IEnumerable<IManufacturer>> awaiter;
						TaskAwaiter<string> awaiter2;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<IEnumerable<IManufacturer>>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								goto IL_18A;
							}
							awaiter2 = (from i in this.<ctx>5__2.devices
							where i.id == CS$<>8__locals1.deviceId
							select i.company_list).FirstOrDefaultAsync<string>().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num3 = 0;
								num = 0;
								this.<>1__state = num3;
								this.<>u__1 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, WorkshopService.<GetManufacturers>d__11>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<string>);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
						}
						string result = awaiter2.GetResult();
						awaiter = workshopService.GetManufacturers(result).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num5 = 1;
							num = 1;
							this.<>1__state = num5;
							this.<>u__2 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<IManufacturer>>, WorkshopService.<GetManufacturers>d__11>(ref awaiter, ref this);
							return;
						}
						IL_18A:
						result2 = awaiter.GetResult();
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
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x060037D4 RID: 14292 RVA: 0x000C31E0 File Offset: 0x000C13E0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040020B0 RID: 8368
			public int <>1__state;

			// Token: 0x040020B1 RID: 8369
			public AsyncTaskMethodBuilder<IEnumerable<IManufacturer>> <>t__builder;

			// Token: 0x040020B2 RID: 8370
			public int deviceId;

			// Token: 0x040020B3 RID: 8371
			public WorkshopService <>4__this;

			// Token: 0x040020B4 RID: 8372
			private auseceEntities <ctx>5__2;

			// Token: 0x040020B5 RID: 8373
			private TaskAwaiter<string> <>u__1;

			// Token: 0x040020B6 RID: 8374
			private TaskAwaiter<IEnumerable<IManufacturer>> <>u__2;
		}

		// Token: 0x02000617 RID: 1559
		[CompilerGenerated]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x060037D5 RID: 14293 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x060037D6 RID: 14294 RVA: 0x000C31FC File Offset: 0x000C13FC
			internal int <GetManufacturers>b__3(device_makers dm)
			{
				return this.idToIndexMap[dm.id];
			}

			// Token: 0x040020B7 RID: 8375
			public int[] myIntArray;

			// Token: 0x040020B8 RID: 8376
			public Dictionary<int, int> idToIndexMap;
		}

		// Token: 0x02000618 RID: 1560
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetManufacturers>d__12 : IAsyncStateMachine
		{
			// Token: 0x060037D7 RID: 14295 RVA: 0x000C321C File Offset: 0x000C141C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IEnumerable<IManufacturer> result;
				try
				{
					if (num != 0)
					{
						this.<>8__1 = new WorkshopService.<>c__DisplayClass12_0();
						this.<>8__1.myIntArray = WorkshopService.ExtractMakerIds(this.companyList);
						this.<>8__1.idToIndexMap = this.<>8__1.myIntArray.Select(new Func<int, int, <>f__AnonymousType4<int, int>>(WorkshopService.<>c.<>9.<GetManufacturers>b__12_0)).Distinct().ToDictionary(new Func<<>f__AnonymousType4<int, int>, int>(WorkshopService.<>c.<>9.<GetManufacturers>b__12_1), new Func<<>f__AnonymousType4<int, int>, int>(WorkshopService.<>c.<>9.<GetManufacturers>b__12_2));
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						ConfiguredTaskAwaitable<List<device_makers>>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = (from dm in this.<ctx>5__2.device_makers.AsNoTracking()
							where this.<>8__1.myIntArray.Contains(dm.id)
							select dm).ToListAsync<device_makers>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<List<device_makers>>.ConfiguredTaskAwaiter, WorkshopService.<GetManufacturers>d__12>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<List<device_makers>>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult().OrderBy(new Func<device_makers, int>(this.<>8__1.<GetManufacturers>b__3)).Select(new Func<device_makers, IManufacturer>(WorkshopService.<>c.<>9.<GetManufacturers>b__12_4)).ToList<IManufacturer>();
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
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x060037D8 RID: 14296 RVA: 0x000C34AC File Offset: 0x000C16AC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040020B9 RID: 8377
			public int <>1__state;

			// Token: 0x040020BA RID: 8378
			public AsyncTaskMethodBuilder<IEnumerable<IManufacturer>> <>t__builder;

			// Token: 0x040020BB RID: 8379
			public string companyList;

			// Token: 0x040020BC RID: 8380
			private WorkshopService.<>c__DisplayClass12_0 <>8__1;

			// Token: 0x040020BD RID: 8381
			private auseceEntities <ctx>5__2;

			// Token: 0x040020BE RID: 8382
			private ConfiguredTaskAwaitable<List<device_makers>>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000619 RID: 1561
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetRefillDevice>d__13 : IAsyncStateMachine
		{
			// Token: 0x060037D9 RID: 14297 RVA: 0x000C34C8 File Offset: 0x000C16C8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IDevice result;
				try
				{
					if (num != 0)
					{
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						ConfiguredTaskAwaitable<devices>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = (from d in this.<ctx>5__2.devices.AsNoTracking()
							where d.enable != (bool?)false && d.refill
							select d).FirstOrDefaultAsync<devices>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<devices>.ConfiguredTaskAwaiter, WorkshopService.<GetRefillDevice>d__13>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<devices>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult().ToDevice();
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

			// Token: 0x060037DA RID: 14298 RVA: 0x000C3668 File Offset: 0x000C1868
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040020BF RID: 8383
			public int <>1__state;

			// Token: 0x040020C0 RID: 8384
			public AsyncTaskMethodBuilder<IDevice> <>t__builder;

			// Token: 0x040020C1 RID: 8385
			private auseceEntities <ctx>5__2;

			// Token: 0x040020C2 RID: 8386
			private ConfiguredTaskAwaitable<devices>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x0200061A RID: 1562
		[CompilerGenerated]
		private sealed class <>c__DisplayClass14_0
		{
			// Token: 0x060037DB RID: 14299 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass14_0()
			{
			}

			// Token: 0x040020C3 RID: 8387
			public int repairId;
		}

		// Token: 0x0200061B RID: 1563
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetOrderCustomer>d__14 : IAsyncStateMachine
		{
			// Token: 0x060037DC RID: 14300 RVA: 0x000C3684 File Offset: 0x000C1884
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ICustomer result;
				try
				{
					WorkshopService.<>c__DisplayClass14_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new WorkshopService.<>c__DisplayClass14_0();
						CS$<>8__locals1.repairId = this.repairId;
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						ConfiguredTaskAwaitable<clients>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = (from c in this.<ctx>5__2.clients.AsNoTracking()
							where c.workshop.FirstOrDefault((workshop r) => r.id == CS$<>8__locals1.repairId) != null
							select c).FirstOrDefaultAsync<clients>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<clients>.ConfiguredTaskAwaiter, WorkshopService.<GetOrderCustomer>d__14>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<clients>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult().Client2Customer();
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

			// Token: 0x060037DD RID: 14301 RVA: 0x000C388C File Offset: 0x000C1A8C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040020C4 RID: 8388
			public int <>1__state;

			// Token: 0x040020C5 RID: 8389
			public AsyncTaskMethodBuilder<ICustomer> <>t__builder;

			// Token: 0x040020C6 RID: 8390
			public int repairId;

			// Token: 0x040020C7 RID: 8391
			private auseceEntities <ctx>5__2;

			// Token: 0x040020C8 RID: 8392
			private ConfiguredTaskAwaitable<clients>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x0200061C RID: 1564
		[CompilerGenerated]
		private sealed class <>c__DisplayClass15_0
		{
			// Token: 0x060037DE RID: 14302 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass15_0()
			{
			}

			// Token: 0x040020C9 RID: 8393
			public int repairId;
		}

		// Token: 0x0200061D RID: 1565
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateRepairCostAndWarranty>d__15 : IAsyncStateMachine
		{
			// Token: 0x060037DF RID: 14303 RVA: 0x000C38A8 File Offset: 0x000C1AA8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopService workshopService = this.<>4__this;
				try
				{
					TaskAwaiter<workshop> awaiter;
					TaskAwaiter<decimal> awaiter2;
					TaskAwaiter<int> awaiter3;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<workshop>);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<decimal>);
						this.<>1__state = -1;
						goto IL_181;
					case 2:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<decimal>);
						this.<>1__state = -1;
						goto IL_1FA;
					case 3:
						awaiter3 = this.<>u__3;
						this.<>u__3 = default(TaskAwaiter<int>);
						this.<>1__state = -1;
						goto IL_288;
					case 4:
						awaiter3 = this.<>u__3;
						this.<>u__3 = default(TaskAwaiter<int>);
						this.<>1__state = -1;
						goto IL_2FE;
					default:
						this.<>8__1 = new WorkshopService.<>c__DisplayClass15_0();
						this.<>8__1.repairId = this.repairId;
						awaiter = this.ctx.workshop.FirstAsync((workshop i) => i.id == this.<>8__1.repairId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop>, WorkshopService.<UpdateRepairCostAndWarranty>d__15>(ref awaiter, ref this);
							return;
						}
						break;
					}
					workshop result = awaiter.GetResult();
					this.<repair>5__2 = result;
					awaiter2 = workshopService.TotalWorksCost(this.ctx, this.<>8__1.repairId).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, WorkshopService.<UpdateRepairCostAndWarranty>d__15>(ref awaiter2, ref this);
						return;
					}
					IL_181:
					decimal result2 = awaiter2.GetResult();
					this.<works>5__3 = result2;
					awaiter2 = workshopService.TotalPartsCost(this.ctx, this.<>8__1.repairId).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, WorkshopService.<UpdateRepairCostAndWarranty>d__15>(ref awaiter2, ref this);
						return;
					}
					IL_1FA:
					decimal result3 = awaiter2.GetResult();
					this.<repair>5__2.SetRealCost(this.<works>5__3, result3);
					this.<>7__wrap3 = this.<repair>5__2;
					awaiter3 = workshopService.GetWarranty(this.ctx, this.<>8__1.repairId).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__3 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, WorkshopService.<UpdateRepairCostAndWarranty>d__15>(ref awaiter3, ref this);
						return;
					}
					IL_288:
					int result4 = awaiter3.GetResult();
					this.<>7__wrap3.warranty_days = result4;
					this.<>7__wrap3 = null;
					awaiter3 = this.ctx.SaveChangesAsync().GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 4;
						this.<>u__3 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, WorkshopService.<UpdateRepairCostAndWarranty>d__15>(ref awaiter3, ref this);
						return;
					}
					IL_2FE:
					awaiter3.GetResult();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<repair>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<repair>5__2 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060037E0 RID: 14304 RVA: 0x000C3C24 File Offset: 0x000C1E24
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040020CA RID: 8394
			public int <>1__state;

			// Token: 0x040020CB RID: 8395
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040020CC RID: 8396
			public int repairId;

			// Token: 0x040020CD RID: 8397
			public auseceEntities ctx;

			// Token: 0x040020CE RID: 8398
			public WorkshopService <>4__this;

			// Token: 0x040020CF RID: 8399
			private WorkshopService.<>c__DisplayClass15_0 <>8__1;

			// Token: 0x040020D0 RID: 8400
			private workshop <repair>5__2;

			// Token: 0x040020D1 RID: 8401
			private decimal <works>5__3;

			// Token: 0x040020D2 RID: 8402
			private TaskAwaiter<workshop> <>u__1;

			// Token: 0x040020D3 RID: 8403
			private TaskAwaiter<decimal> <>u__2;

			// Token: 0x040020D4 RID: 8404
			private workshop <>7__wrap3;

			// Token: 0x040020D5 RID: 8405
			private TaskAwaiter<int> <>u__3;
		}

		// Token: 0x0200061E RID: 1566
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetWarranty>d__16 : IAsyncStateMachine
		{
			// Token: 0x060037E1 RID: 14305 RVA: 0x000C3C40 File Offset: 0x000C1E40
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopService workshopService = this.<>4__this;
				int valueOrDefault;
				try
				{
					TaskAwaiter<int?> awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<int?>);
							this.<>1__state = -1;
							goto IL_EB;
						}
						awaiter = workshopService.GetMaxWorksWarranty(this.ctx, this.repairId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int?>, WorkshopService.<GetWarranty>d__16>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<int?>);
						this.<>1__state = -1;
					}
					int? result = awaiter.GetResult();
					this.<worksWarranty>5__2 = result;
					awaiter = workshopService.GetMaxPartsWarranty(this.ctx, this.repairId).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int?>, WorkshopService.<GetWarranty>d__16>(ref awaiter, ref this);
						return;
					}
					IL_EB:
					int? result2 = awaiter.GetResult();
					result = this.<worksWarranty>5__2;
					int? num2 = result2;
					valueOrDefault = ((result.GetValueOrDefault() > num2.GetValueOrDefault() & (result != null & num2 != null)) ? this.<worksWarranty>5__2 : result2).GetValueOrDefault();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(valueOrDefault);
			}

			// Token: 0x060037E2 RID: 14306 RVA: 0x000C3DCC File Offset: 0x000C1FCC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040020D6 RID: 8406
			public int <>1__state;

			// Token: 0x040020D7 RID: 8407
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x040020D8 RID: 8408
			public WorkshopService <>4__this;

			// Token: 0x040020D9 RID: 8409
			public auseceEntities ctx;

			// Token: 0x040020DA RID: 8410
			public int repairId;

			// Token: 0x040020DB RID: 8411
			private int? <worksWarranty>5__2;

			// Token: 0x040020DC RID: 8412
			private TaskAwaiter<int?> <>u__1;
		}

		// Token: 0x0200061F RID: 1567
		[CompilerGenerated]
		private sealed class <>c__DisplayClass17_0
		{
			// Token: 0x060037E3 RID: 14307 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass17_0()
			{
			}

			// Token: 0x040020DD RID: 8413
			public int repairId;
		}

		// Token: 0x02000620 RID: 1568
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetMaxWorksWarranty>d__17 : IAsyncStateMachine
		{
			// Token: 0x060037E4 RID: 14308 RVA: 0x000C3DE8 File Offset: 0x000C1FE8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				int? result2;
				try
				{
					TaskAwaiter<int> awaiter;
					if (num != 0)
					{
						WorkshopService.<>c__DisplayClass17_0 CS$<>8__locals1 = new WorkshopService.<>c__DisplayClass17_0();
						CS$<>8__locals1.repairId = this.repairId;
						awaiter = (from w in this.ctx.works
						where w.repair == (int?)CS$<>8__locals1.repairId
						select w.warranty).DefaultIfEmpty<int>().MaxAsync<int>().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, WorkshopService.<GetMaxWorksWarranty>d__17>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<int>);
						this.<>1__state = -1;
					}
					int result = awaiter.GetResult();
					result2 = new int?(result);
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

			// Token: 0x060037E5 RID: 14309 RVA: 0x000C3F88 File Offset: 0x000C2188
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040020DE RID: 8414
			public int <>1__state;

			// Token: 0x040020DF RID: 8415
			public AsyncTaskMethodBuilder<int?> <>t__builder;

			// Token: 0x040020E0 RID: 8416
			public int repairId;

			// Token: 0x040020E1 RID: 8417
			public auseceEntities ctx;

			// Token: 0x040020E2 RID: 8418
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x02000621 RID: 1569
		[CompilerGenerated]
		private sealed class <>c__DisplayClass18_0
		{
			// Token: 0x060037E6 RID: 14310 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass18_0()
			{
			}

			// Token: 0x040020E3 RID: 8419
			public int repairId;
		}

		// Token: 0x02000622 RID: 1570
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetMaxPartsWarranty>d__18 : IAsyncStateMachine
		{
			// Token: 0x060037E7 RID: 14311 RVA: 0x000C3FA4 File Offset: 0x000C21A4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				int? result2;
				try
				{
					TaskAwaiter<int> awaiter;
					if (num != 0)
					{
						WorkshopService.<>c__DisplayClass18_0 CS$<>8__locals1 = new WorkshopService.<>c__DisplayClass18_0();
						CS$<>8__locals1.repairId = this.repairId;
						awaiter = (from p in this.ctx.store_int_reserve
						where p.repair_id == (int?)CS$<>8__locals1.repairId && (p.state == 2 || p.state == 3)
						select p.warranty).DefaultIfEmpty<int>().MaxAsync<int>().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, WorkshopService.<GetMaxPartsWarranty>d__18>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<int>);
						this.<>1__state = -1;
					}
					int result = awaiter.GetResult();
					result2 = new int?(result);
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

			// Token: 0x060037E8 RID: 14312 RVA: 0x000C41AC File Offset: 0x000C23AC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040020E4 RID: 8420
			public int <>1__state;

			// Token: 0x040020E5 RID: 8421
			public AsyncTaskMethodBuilder<int?> <>t__builder;

			// Token: 0x040020E6 RID: 8422
			public int repairId;

			// Token: 0x040020E7 RID: 8423
			public auseceEntities ctx;

			// Token: 0x040020E8 RID: 8424
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x02000623 RID: 1571
		[CompilerGenerated]
		private sealed class <>c__DisplayClass19_0
		{
			// Token: 0x060037E9 RID: 14313 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass19_0()
			{
			}

			// Token: 0x040020E9 RID: 8425
			public int repairId;
		}

		// Token: 0x02000624 RID: 1572
		[CompilerGenerated]
		private sealed class <>c__DisplayClass20_0
		{
			// Token: 0x060037EA RID: 14314 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass20_0()
			{
			}

			// Token: 0x040020EA RID: 8426
			public int repairId;
		}

		// Token: 0x02000625 RID: 1573
		[CompilerGenerated]
		private sealed class <>c__DisplayClass21_0
		{
			// Token: 0x060037EB RID: 14315 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass21_0()
			{
			}

			// Token: 0x040020EB RID: 8427
			public int repairId;
		}

		// Token: 0x02000626 RID: 1574
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SaveBox>d__21 : IAsyncStateMachine
		{
			// Token: 0x060037EC RID: 14316 RVA: 0x000C41C8 File Offset: 0x000C23C8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopService workshopService = this.<>4__this;
				try
				{
					if (num > 3)
					{
						this.<>8__1 = new WorkshopService.<>c__DisplayClass21_0();
						this.<>8__1.repairId = this.repairId;
					}
					try
					{
						if (num > 3)
						{
							this.<history>5__2 = new HistoryV2();
							this.<ctx>5__3 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<workshop> awaiter;
							TaskAwaiter<int> awaiter2;
							TaskAwaiter awaiter3;
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
								this.<>u__2 = default(TaskAwaiter<int>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
								goto IL_1B4;
							}
							case 2:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<int>);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
								goto IL_26D;
							}
							case 3:
							{
								awaiter3 = this.<>u__3;
								this.<>u__3 = default(TaskAwaiter);
								int num5 = -1;
								num = -1;
								this.<>1__state = num5;
								goto IL_365;
							}
							default:
								awaiter = this.<ctx>5__3.workshop.SingleAsync((workshop i) => i.id == this.<>8__1.repairId).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num6 = 0;
									num = 0;
									this.<>1__state = num6;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop>, WorkshopService.<SaveBox>d__21>(ref awaiter, ref this);
									return;
								}
								break;
							}
							workshop result = awaiter.GetResult();
							this.<original>5__4 = result;
							if (this.boxId != null)
							{
								goto IL_1E1;
							}
							this.<original>5__4.box = null;
							awaiter2 = this.<ctx>5__3.SaveChangesAsync().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num7 = 1;
								num = 1;
								this.<>1__state = num7;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, WorkshopService.<SaveBox>d__21>(ref awaiter2, ref this);
								return;
							}
							IL_1B4:
							awaiter2.GetResult();
							this.<history>5__2.AddRepairLog("removedFromBox", this.<>8__1.repairId, "", "");
							IL_1E1:
							int? num8 = this.boxId;
							if (!(num8.GetValueOrDefault() > 0 & num8 != null))
							{
								goto IL_309;
							}
							this.<original>5__4.box = this.boxId;
							awaiter2 = this.<ctx>5__3.SaveChangesAsync().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num9 = 2;
								num = 2;
								this.<>1__state = num9;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, WorkshopService.<SaveBox>d__21>(ref awaiter2, ref this);
								return;
							}
							IL_26D:
							awaiter2.GetResult();
							this.<ctx>5__3.Entry<workshop>(this.<original>5__4).Reference<boxes>((workshop r) => r.boxes).Load();
							if (this.<original>5__4.boxes != null)
							{
								this.<history>5__2.AddRepairLog("putInBox", this.<>8__1.repairId, this.<original>5__4.boxes.name, "");
							}
							IL_309:
							awaiter3 = this.<history>5__2.SaveAsync().GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								int num10 = 3;
								num = 3;
								this.<>1__state = num10;
								this.<>u__3 = awaiter3;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopService.<SaveBox>d__21>(ref awaiter3, ref this);
								return;
							}
							IL_365:
							awaiter3.GetResult();
							this.<original>5__4 = null;
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
					catch (Exception ex)
					{
						workshopService._logger.Error(ex, ex.Message);
						throw;
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
				this.<>t__builder.SetResult();
			}

			// Token: 0x060037ED RID: 14317 RVA: 0x000C4614 File Offset: 0x000C2814
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040020EC RID: 8428
			public int <>1__state;

			// Token: 0x040020ED RID: 8429
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040020EE RID: 8430
			public int repairId;

			// Token: 0x040020EF RID: 8431
			public int? boxId;

			// Token: 0x040020F0 RID: 8432
			private WorkshopService.<>c__DisplayClass21_0 <>8__1;

			// Token: 0x040020F1 RID: 8433
			public WorkshopService <>4__this;

			// Token: 0x040020F2 RID: 8434
			private HistoryV2 <history>5__2;

			// Token: 0x040020F3 RID: 8435
			private auseceEntities <ctx>5__3;

			// Token: 0x040020F4 RID: 8436
			private workshop <original>5__4;

			// Token: 0x040020F5 RID: 8437
			private TaskAwaiter<workshop> <>u__1;

			// Token: 0x040020F6 RID: 8438
			private TaskAwaiter<int> <>u__2;

			// Token: 0x040020F7 RID: 8439
			private TaskAwaiter <>u__3;
		}

		// Token: 0x02000627 RID: 1575
		[CompilerGenerated]
		private sealed class <>c__DisplayClass22_0
		{
			// Token: 0x060037EE RID: 14318 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass22_0()
			{
			}

			// Token: 0x040020F8 RID: 8440
			public int repairId;
		}

		// Token: 0x02000628 RID: 1576
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SaveIssuingMessage>d__22 : IAsyncStateMachine
		{
			// Token: 0x060037EF RID: 14319 RVA: 0x000C4630 File Offset: 0x000C2830
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopService workshopService = this.<>4__this;
				try
				{
					if (num > 2)
					{
						this.<>8__1 = new WorkshopService.<>c__DisplayClass22_0();
						this.<>8__1.repairId = this.repairId;
					}
					try
					{
						if (num > 2)
						{
							this.<history>5__2 = new HistoryV2();
							this.<ctx>5__3 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<workshop> awaiter;
							TaskAwaiter<int> awaiter2;
							TaskAwaiter awaiter3;
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
								this.<>u__2 = default(TaskAwaiter<int>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
								goto IL_18B;
							}
							case 2:
							{
								awaiter3 = this.<>u__3;
								this.<>u__3 = default(TaskAwaiter);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
								goto IL_215;
							}
							default:
								awaiter = this.<ctx>5__3.workshop.SingleAsync((workshop i) => i.id == this.<>8__1.repairId).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num5 = 0;
									num = 0;
									this.<>1__state = num5;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop>, WorkshopService.<SaveIssuingMessage>d__22>(ref awaiter, ref this);
									return;
								}
								break;
							}
							awaiter.GetResult().issued_msg = this.msg;
							awaiter2 = this.<ctx>5__3.SaveChangesAsync().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num6 = 1;
								num = 1;
								this.<>1__state = num6;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, WorkshopService.<SaveIssuingMessage>d__22>(ref awaiter2, ref this);
								return;
							}
							IL_18B:
							awaiter2.GetResult();
							this.<history>5__2.AddRepairLog("IssueMsgChanged", this.<>8__1.repairId, this.msg, "");
							awaiter3 = this.<history>5__2.SaveAsync().GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								int num7 = 2;
								num = 2;
								this.<>1__state = num7;
								this.<>u__3 = awaiter3;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopService.<SaveIssuingMessage>d__22>(ref awaiter3, ref this);
								return;
							}
							IL_215:
							awaiter3.GetResult();
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
					catch (Exception ex)
					{
						workshopService._logger.Error(ex, ex.Message);
						throw;
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
				this.<>t__builder.SetResult();
			}

			// Token: 0x060037F0 RID: 14320 RVA: 0x000C4924 File Offset: 0x000C2B24
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040020F9 RID: 8441
			public int <>1__state;

			// Token: 0x040020FA RID: 8442
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040020FB RID: 8443
			public int repairId;

			// Token: 0x040020FC RID: 8444
			public string msg;

			// Token: 0x040020FD RID: 8445
			private WorkshopService.<>c__DisplayClass22_0 <>8__1;

			// Token: 0x040020FE RID: 8446
			public WorkshopService <>4__this;

			// Token: 0x040020FF RID: 8447
			private HistoryV2 <history>5__2;

			// Token: 0x04002100 RID: 8448
			private auseceEntities <ctx>5__3;

			// Token: 0x04002101 RID: 8449
			private TaskAwaiter<workshop> <>u__1;

			// Token: 0x04002102 RID: 8450
			private TaskAwaiter<int> <>u__2;

			// Token: 0x04002103 RID: 8451
			private TaskAwaiter <>u__3;
		}

		// Token: 0x02000629 RID: 1577
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SetRepairColor>d__23 : IAsyncStateMachine
		{
			// Token: 0x060037F1 RID: 14321 RVA: 0x000C4940 File Offset: 0x000C2B40
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopService workshopService = this.<>4__this;
				try
				{
					if (num > 1)
					{
						this.<history>5__2 = new HistoryV2();
					}
					try
					{
						if (num > 1)
						{
							this.<ctx>5__3 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter awaiter;
							TaskAwaiter<int> awaiter2;
							if (num != 0)
							{
								if (num == 1)
								{
									awaiter = this.<>u__2;
									this.<>u__2 = default(TaskAwaiter);
									int num2 = -1;
									num = -1;
									this.<>1__state = num2;
									goto IL_14D;
								}
								this.<ctx>5__3.Configuration.ValidateOnSaveEnabled = false;
								workshop workshop = new workshop
								{
									id = this.repairId
								};
								this.<ctx>5__3.workshop.Attach(workshop);
								workshop.color = this.color;
								awaiter2 = this.<ctx>5__3.SaveChangesAsync().GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									int num3 = 0;
									num = 0;
									this.<>1__state = num3;
									this.<>u__1 = awaiter2;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, WorkshopService.<SetRepairColor>d__23>(ref awaiter2, ref this);
									return;
								}
							}
							else
							{
								awaiter2 = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<int>);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
							}
							awaiter2.GetResult();
							this.<history>5__2.AddRepairLog(this.repairId, this.color);
							awaiter = this.<history>5__2.SaveAsync().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num5 = 1;
								num = 1;
								this.<>1__state = num5;
								this.<>u__2 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopService.<SetRepairColor>d__23>(ref awaiter, ref this);
								return;
							}
							IL_14D:
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
					}
					catch (Exception ex)
					{
						workshopService._logger.Error(ex, ex.Message);
						throw;
					}
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
				this.<>t__builder.SetResult();
			}

			// Token: 0x060037F2 RID: 14322 RVA: 0x000C4B64 File Offset: 0x000C2D64
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002104 RID: 8452
			public int <>1__state;

			// Token: 0x04002105 RID: 8453
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002106 RID: 8454
			public int repairId;

			// Token: 0x04002107 RID: 8455
			public string color;

			// Token: 0x04002108 RID: 8456
			public WorkshopService <>4__this;

			// Token: 0x04002109 RID: 8457
			private HistoryV2 <history>5__2;

			// Token: 0x0400210A RID: 8458
			private auseceEntities <ctx>5__3;

			// Token: 0x0400210B RID: 8459
			private TaskAwaiter<int> <>u__1;

			// Token: 0x0400210C RID: 8460
			private TaskAwaiter <>u__2;
		}

		// Token: 0x0200062A RID: 1578
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SaveWarrantyLabel>d__24 : IAsyncStateMachine
		{
			// Token: 0x060037F3 RID: 14323 RVA: 0x000C4B80 File Offset: 0x000C2D80
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopService workshopService = this.<>4__this;
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
							workshop workshop = new workshop
							{
								id = this.repairId
							};
							this.<ctx>5__2.workshop.Attach(workshop);
							workshop.warranty_label = this.warrantyLabel;
							awaiter = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, WorkshopService.<SaveWarrantyLabel>d__24>(ref awaiter, ref this);
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
					catch (Exception ex)
					{
						workshopService._logger.Error(ex, ex.Message);
						throw;
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

			// Token: 0x060037F4 RID: 14324 RVA: 0x000C4CE4 File Offset: 0x000C2EE4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400210D RID: 8461
			public int <>1__state;

			// Token: 0x0400210E RID: 8462
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400210F RID: 8463
			public int repairId;

			// Token: 0x04002110 RID: 8464
			public string warrantyLabel;

			// Token: 0x04002111 RID: 8465
			public WorkshopService <>4__this;

			// Token: 0x04002112 RID: 8466
			private auseceEntities <ctx>5__2;

			// Token: 0x04002113 RID: 8467
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x0200062B RID: 1579
		[CompilerGenerated]
		private sealed class <>c__DisplayClass25_0
		{
			// Token: 0x060037F5 RID: 14325 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass25_0()
			{
			}

			// Token: 0x04002114 RID: 8468
			public int repairId;
		}

		// Token: 0x0200062C RID: 1580
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateInformStatus>d__25 : IAsyncStateMachine
		{
			// Token: 0x060037F6 RID: 14326 RVA: 0x000C4D00 File Offset: 0x000C2F00
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopService workshopService = this.<>4__this;
				try
				{
					if (num > 2)
					{
						this.<>8__1 = new WorkshopService.<>c__DisplayClass25_0();
						this.<>8__1.repairId = this.repairId;
						this.<history>5__2 = new HistoryV2();
					}
					try
					{
						TaskAwaiter awaiter;
						if (num > 1)
						{
							if (num == 2)
							{
								awaiter = this.<>u__3;
								this.<>u__3 = default(TaskAwaiter);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								goto IL_210;
							}
							this.<ctx>5__3 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<int> awaiter2;
							TaskAwaiter<workshop> awaiter3;
							if (num != 0)
							{
								if (num == 1)
								{
									awaiter2 = this.<>u__2;
									this.<>u__2 = default(TaskAwaiter<int>);
									int num3 = -1;
									num = -1;
									this.<>1__state = num3;
									goto IL_18C;
								}
								awaiter3 = this.<ctx>5__3.workshop.SingleAsync((workshop i) => i.id == this.<>8__1.repairId).GetAwaiter();
								if (!awaiter3.IsCompleted)
								{
									int num4 = 0;
									num = 0;
									this.<>1__state = num4;
									this.<>u__1 = awaiter3;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop>, WorkshopService.<UpdateInformStatus>d__25>(ref awaiter3, ref this);
									return;
								}
							}
							else
							{
								awaiter3 = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<workshop>);
								int num5 = -1;
								num = -1;
								this.<>1__state = num5;
							}
							awaiter3.GetResult().informed_status = this.status;
							awaiter2 = this.<ctx>5__3.SaveChangesAsync().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num6 = 1;
								num = 1;
								this.<>1__state = num6;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, WorkshopService.<UpdateInformStatus>d__25>(ref awaiter2, ref this);
								return;
							}
							IL_18C:
							awaiter2.GetResult();
						}
						finally
						{
							if (num < 0 && this.<ctx>5__3 != null)
							{
								((IDisposable)this.<ctx>5__3).Dispose();
							}
						}
						this.<ctx>5__3 = null;
						this.<history>5__2.AddRepairLog(this.<>8__1.repairId, this.status);
						awaiter = this.<history>5__2.SaveAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num7 = 2;
							num = 2;
							this.<>1__state = num7;
							this.<>u__3 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopService.<UpdateInformStatus>d__25>(ref awaiter, ref this);
							return;
						}
						IL_210:
						awaiter.GetResult();
					}
					catch (Exception ex)
					{
						workshopService._logger.Error(ex, ex.Message);
						throw;
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<history>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<history>5__2 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060037F7 RID: 14327 RVA: 0x000C4FF8 File Offset: 0x000C31F8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002115 RID: 8469
			public int <>1__state;

			// Token: 0x04002116 RID: 8470
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002117 RID: 8471
			public int repairId;

			// Token: 0x04002118 RID: 8472
			public int status;

			// Token: 0x04002119 RID: 8473
			private WorkshopService.<>c__DisplayClass25_0 <>8__1;

			// Token: 0x0400211A RID: 8474
			public WorkshopService <>4__this;

			// Token: 0x0400211B RID: 8475
			private HistoryV2 <history>5__2;

			// Token: 0x0400211C RID: 8476
			private auseceEntities <ctx>5__3;

			// Token: 0x0400211D RID: 8477
			private TaskAwaiter<workshop> <>u__1;

			// Token: 0x0400211E RID: 8478
			private TaskAwaiter<int> <>u__2;

			// Token: 0x0400211F RID: 8479
			private TaskAwaiter <>u__3;
		}

		// Token: 0x0200062D RID: 1581
		[CompilerGenerated]
		private sealed class <>c__DisplayClass26_0
		{
			// Token: 0x060037F8 RID: 14328 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass26_0()
			{
			}

			// Token: 0x04002120 RID: 8480
			public int repairId;
		}

		// Token: 0x0200062E RID: 1582
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ChangeCustomer>d__26 : IAsyncStateMachine
		{
			// Token: 0x060037F9 RID: 14329 RVA: 0x000C5014 File Offset: 0x000C3214
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopService workshopService = this.<>4__this;
				try
				{
					if (num > 2)
					{
						this.<>8__1 = new WorkshopService.<>c__DisplayClass26_0();
						this.<>8__1.repairId = this.repairId;
					}
					try
					{
						if (num > 2)
						{
							this.<history>5__2 = new HistoryV2();
							this.<ctx>5__3 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<workshop> awaiter;
							TaskAwaiter<int> awaiter2;
							TaskAwaiter awaiter3;
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
								this.<>u__2 = default(TaskAwaiter<int>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
								goto IL_1E6;
							}
							case 2:
							{
								awaiter3 = this.<>u__3;
								this.<>u__3 = default(TaskAwaiter);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
								goto IL_271;
							}
							default:
								awaiter = this.<ctx>5__3.workshop.SingleAsync((workshop i) => i.id == this.<>8__1.repairId).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num5 = 0;
									num = 0;
									this.<>1__state = num5;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop>, WorkshopService.<ChangeCustomer>d__26>(ref awaiter, ref this);
									return;
								}
								break;
							}
							workshop result = awaiter.GetResult();
							this.<originalClient>5__4 = string.Format("{0} [{1:D6}]", result.clients.FioOrUrName, result.client);
							this.<newClientInfo>5__5 = string.Format("{0} [{1:D6}]", this.customer.FioOrUrName, this.customer.Id);
							result.client = this.customer.Id;
							awaiter2 = this.<ctx>5__3.SaveChangesAsync().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num6 = 1;
								num = 1;
								this.<>1__state = num6;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, WorkshopService.<ChangeCustomer>d__26>(ref awaiter2, ref this);
								return;
							}
							IL_1E6:
							awaiter2.GetResult();
							this.<history>5__2.AddRepairLog("ClientChanged", this.<>8__1.repairId, this.<originalClient>5__4, this.<newClientInfo>5__5);
							awaiter3 = this.<history>5__2.SaveAsync().GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								int num7 = 2;
								num = 2;
								this.<>1__state = num7;
								this.<>u__3 = awaiter3;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopService.<ChangeCustomer>d__26>(ref awaiter3, ref this);
								return;
							}
							IL_271:
							awaiter3.GetResult();
							this.<originalClient>5__4 = null;
							this.<newClientInfo>5__5 = null;
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
					catch (Exception ex)
					{
						workshopService._logger.Error(ex, ex.Message);
						throw;
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
				this.<>t__builder.SetResult();
			}

			// Token: 0x060037FA RID: 14330 RVA: 0x000C5374 File Offset: 0x000C3574
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002121 RID: 8481
			public int <>1__state;

			// Token: 0x04002122 RID: 8482
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002123 RID: 8483
			public int repairId;

			// Token: 0x04002124 RID: 8484
			public ICustomer customer;

			// Token: 0x04002125 RID: 8485
			private WorkshopService.<>c__DisplayClass26_0 <>8__1;

			// Token: 0x04002126 RID: 8486
			public WorkshopService <>4__this;

			// Token: 0x04002127 RID: 8487
			private HistoryV2 <history>5__2;

			// Token: 0x04002128 RID: 8488
			private auseceEntities <ctx>5__3;

			// Token: 0x04002129 RID: 8489
			private string <originalClient>5__4;

			// Token: 0x0400212A RID: 8490
			private string <newClientInfo>5__5;

			// Token: 0x0400212B RID: 8491
			private TaskAwaiter<workshop> <>u__1;

			// Token: 0x0400212C RID: 8492
			private TaskAwaiter<int> <>u__2;

			// Token: 0x0400212D RID: 8493
			private TaskAwaiter <>u__3;
		}

		// Token: 0x0200062F RID: 1583
		[CompilerGenerated]
		private sealed class <>c__DisplayClass27_0
		{
			// Token: 0x060037FB RID: 14331 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass27_0()
			{
			}

			// Token: 0x0400212E RID: 8494
			public int repairId;
		}

		// Token: 0x02000630 RID: 1584
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ChangeMaster>d__27 : IAsyncStateMachine
		{
			// Token: 0x060037FC RID: 14332 RVA: 0x000C5390 File Offset: 0x000C3590
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopService workshopService = this.<>4__this;
				try
				{
					if (num > 3)
					{
						this.<>8__1 = new WorkshopService.<>c__DisplayClass27_0();
						this.<>8__1.repairId = this.repairId;
					}
					try
					{
						if (num > 3)
						{
							this.<history>5__2 = new HistoryV2();
							this.<ctx>5__3 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<workshop> awaiter;
							TaskAwaiter<int> awaiter2;
							TaskAwaiter awaiter3;
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
								this.<>u__2 = default(TaskAwaiter<int>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
								goto IL_1A0;
							}
							case 2:
							{
								awaiter3 = this.<>u__3;
								this.<>u__3 = default(TaskAwaiter);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
								goto IL_250;
							}
							case 3:
							{
								awaiter3 = this.<>u__3;
								this.<>u__3 = default(TaskAwaiter);
								int num5 = -1;
								num = -1;
								this.<>1__state = num5;
								goto IL_2DE;
							}
							default:
								awaiter = this.<ctx>5__3.workshop.SingleAsync((workshop i) => i.id == this.<>8__1.repairId).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num6 = 0;
									num = 0;
									this.<>1__state = num6;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop>, WorkshopService.<ChangeMaster>d__27>(ref awaiter, ref this);
									return;
								}
								break;
							}
							workshop result = awaiter.GetResult();
							this.<original>5__4 = result;
							this.<original>5__4.master = this.master;
							awaiter2 = this.<ctx>5__3.SaveChangesAsync().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num7 = 1;
								num = 1;
								this.<>1__state = num7;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, WorkshopService.<ChangeMaster>d__27>(ref awaiter2, ref this);
								return;
							}
							IL_1A0:
							awaiter2.GetResult();
							awaiter3 = this.<ctx>5__3.Entry<workshop>(this.<original>5__4).Reference<users>((workshop u) => u.master_users).LoadAsync().GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								int num8 = 2;
								num = 2;
								this.<>1__state = num8;
								this.<>u__3 = awaiter3;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopService.<ChangeMaster>d__27>(ref awaiter3, ref this);
								return;
							}
							IL_250:
							awaiter3.GetResult();
							this.<history>5__2.AddRepairLog("masterChanged", this.<>8__1.repairId, this.<original>5__4.master_users, null, null, null, null, null);
							awaiter3 = this.<history>5__2.SaveAsync().GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								int num9 = 3;
								num = 3;
								this.<>1__state = num9;
								this.<>u__3 = awaiter3;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopService.<ChangeMaster>d__27>(ref awaiter3, ref this);
								return;
							}
							IL_2DE:
							awaiter3.GetResult();
							this.<original>5__4 = null;
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
					catch (Exception ex)
					{
						workshopService._logger.Error(ex, ex.Message);
						throw;
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
				this.<>t__builder.SetResult();
			}

			// Token: 0x060037FD RID: 14333 RVA: 0x000C5754 File Offset: 0x000C3954
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400212F RID: 8495
			public int <>1__state;

			// Token: 0x04002130 RID: 8496
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002131 RID: 8497
			public int repairId;

			// Token: 0x04002132 RID: 8498
			public int? master;

			// Token: 0x04002133 RID: 8499
			private WorkshopService.<>c__DisplayClass27_0 <>8__1;

			// Token: 0x04002134 RID: 8500
			public WorkshopService <>4__this;

			// Token: 0x04002135 RID: 8501
			private HistoryV2 <history>5__2;

			// Token: 0x04002136 RID: 8502
			private auseceEntities <ctx>5__3;

			// Token: 0x04002137 RID: 8503
			private workshop <original>5__4;

			// Token: 0x04002138 RID: 8504
			private TaskAwaiter<workshop> <>u__1;

			// Token: 0x04002139 RID: 8505
			private TaskAwaiter<int> <>u__2;

			// Token: 0x0400213A RID: 8506
			private TaskAwaiter <>u__3;
		}

		// Token: 0x02000631 RID: 1585
		[CompilerGenerated]
		private sealed class <>c__DisplayClass28_0
		{
			// Token: 0x060037FE RID: 14334 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass28_0()
			{
			}

			// Token: 0x0400213B RID: 8507
			public workshop repair;
		}

		// Token: 0x02000632 RID: 1586
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ChangeManager>d__28 : IAsyncStateMachine
		{
			// Token: 0x060037FF RID: 14335 RVA: 0x000C5770 File Offset: 0x000C3970
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopService workshopService = this.<>4__this;
				try
				{
					if (num > 3)
					{
						this.<>8__1 = new WorkshopService.<>c__DisplayClass28_0();
						this.<>8__1.repair = this.repair;
					}
					try
					{
						if (num > 3)
						{
							this.<history>5__2 = new HistoryV2();
							this.<ctx>5__3 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<workshop> awaiter;
							TaskAwaiter<int> awaiter2;
							TaskAwaiter awaiter3;
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
								this.<>u__2 = default(TaskAwaiter<int>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
								goto IL_1BE;
							}
							case 2:
							{
								awaiter3 = this.<>u__3;
								this.<>u__3 = default(TaskAwaiter);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
								goto IL_26E;
							}
							case 3:
							{
								awaiter3 = this.<>u__3;
								this.<>u__3 = default(TaskAwaiter);
								int num5 = -1;
								num = -1;
								this.<>1__state = num5;
								goto IL_301;
							}
							default:
								awaiter = this.<ctx>5__3.workshop.SingleAsync((workshop i) => i.id == this.<>8__1.repair.id).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num6 = 0;
									num = 0;
									this.<>1__state = num6;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop>, WorkshopService.<ChangeManager>d__28>(ref awaiter, ref this);
									return;
								}
								break;
							}
							workshop result = awaiter.GetResult();
							this.<original>5__4 = result;
							this.<original>5__4.current_manager = this.<>8__1.repair.current_manager;
							awaiter2 = this.<ctx>5__3.SaveChangesAsync().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num7 = 1;
								num = 1;
								this.<>1__state = num7;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, WorkshopService.<ChangeManager>d__28>(ref awaiter2, ref this);
								return;
							}
							IL_1BE:
							awaiter2.GetResult();
							awaiter3 = this.<ctx>5__3.Entry<workshop>(this.<original>5__4).Reference<users>((workshop u) => u.users3).LoadAsync().GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								int num8 = 2;
								num = 2;
								this.<>1__state = num8;
								this.<>u__3 = awaiter3;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopService.<ChangeManager>d__28>(ref awaiter3, ref this);
								return;
							}
							IL_26E:
							awaiter3.GetResult();
							this.<history>5__2.AddRepairLog("managerChanged", this.<>8__1.repair.id, this.<original>5__4.users3, null, null, null, null, null);
							awaiter3 = this.<history>5__2.SaveAsync().GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								int num9 = 3;
								num = 3;
								this.<>1__state = num9;
								this.<>u__3 = awaiter3;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopService.<ChangeManager>d__28>(ref awaiter3, ref this);
								return;
							}
							IL_301:
							awaiter3.GetResult();
							this.<original>5__4 = null;
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
					catch (Exception ex)
					{
						workshopService._logger.Error(ex, ex.Message);
						throw;
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
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003800 RID: 14336 RVA: 0x000C5B58 File Offset: 0x000C3D58
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400213C RID: 8508
			public int <>1__state;

			// Token: 0x0400213D RID: 8509
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400213E RID: 8510
			public workshop repair;

			// Token: 0x0400213F RID: 8511
			private WorkshopService.<>c__DisplayClass28_0 <>8__1;

			// Token: 0x04002140 RID: 8512
			public WorkshopService <>4__this;

			// Token: 0x04002141 RID: 8513
			private HistoryV2 <history>5__2;

			// Token: 0x04002142 RID: 8514
			private auseceEntities <ctx>5__3;

			// Token: 0x04002143 RID: 8515
			private workshop <original>5__4;

			// Token: 0x04002144 RID: 8516
			private TaskAwaiter<workshop> <>u__1;

			// Token: 0x04002145 RID: 8517
			private TaskAwaiter<int> <>u__2;

			// Token: 0x04002146 RID: 8518
			private TaskAwaiter <>u__3;
		}

		// Token: 0x02000633 RID: 1587
		[CompilerGenerated]
		private sealed class <>c__DisplayClass29_0
		{
			// Token: 0x06003801 RID: 14337 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass29_0()
			{
			}

			// Token: 0x04002147 RID: 8519
			public workshop repair;
		}

		// Token: 0x02000634 RID: 1588
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ChangeOffice>d__29 : IAsyncStateMachine
		{
			// Token: 0x06003802 RID: 14338 RVA: 0x000C5B74 File Offset: 0x000C3D74
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopService workshopService = this.<>4__this;
				try
				{
					if (num > 3)
					{
						this.<>8__1 = new WorkshopService.<>c__DisplayClass29_0();
						this.<>8__1.repair = this.repair;
					}
					try
					{
						if (num > 3)
						{
							this.<history>5__2 = new HistoryV2();
							this.<ctx>5__3 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<workshop> awaiter;
							TaskAwaiter<int> awaiter2;
							TaskAwaiter awaiter3;
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
								this.<>u__2 = default(TaskAwaiter<int>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
								goto IL_1E5;
							}
							case 2:
							{
								awaiter3 = this.<>u__3;
								this.<>u__3 = default(TaskAwaiter);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
								goto IL_295;
							}
							case 3:
							{
								awaiter3 = this.<>u__3;
								this.<>u__3 = default(TaskAwaiter);
								int num5 = -1;
								num = -1;
								this.<>1__state = num5;
								goto IL_328;
							}
							default:
								awaiter = this.<ctx>5__3.workshop.SingleAsync((workshop i) => i.id == this.<>8__1.repair.id).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num6 = 0;
									num = 0;
									this.<>1__state = num6;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop>, WorkshopService.<ChangeOffice>d__29>(ref awaiter, ref this);
									return;
								}
								break;
							}
							workshop result = awaiter.GetResult();
							this.<original>5__4 = result;
							this.<original>5__4.order_moving = workshopService.LogOrderMoving(this.<original>5__4, this.<>8__1.repair.office);
							this.<original>5__4.office = this.<>8__1.repair.office;
							awaiter2 = this.<ctx>5__3.SaveChangesAsync().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num7 = 1;
								num = 1;
								this.<>1__state = num7;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, WorkshopService.<ChangeOffice>d__29>(ref awaiter2, ref this);
								return;
							}
							IL_1E5:
							awaiter2.GetResult();
							awaiter3 = this.<ctx>5__3.Entry<workshop>(this.<original>5__4).Reference<offices>((workshop r) => r.offices).LoadAsync().GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								int num8 = 2;
								num = 2;
								this.<>1__state = num8;
								this.<>u__3 = awaiter3;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopService.<ChangeOffice>d__29>(ref awaiter3, ref this);
								return;
							}
							IL_295:
							awaiter3.GetResult();
							this.<history>5__2.AddRepairLog("officeChanged", this.<>8__1.repair.id, null, null, this.<original>5__4.offices, null, null, null);
							awaiter3 = this.<history>5__2.SaveAsync().GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								int num9 = 3;
								num = 3;
								this.<>1__state = num9;
								this.<>u__3 = awaiter3;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopService.<ChangeOffice>d__29>(ref awaiter3, ref this);
								return;
							}
							IL_328:
							awaiter3.GetResult();
							this.<original>5__4 = null;
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
					catch (Exception ex)
					{
						workshopService._logger.Error(ex, ex.Message);
						throw;
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
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003803 RID: 14339 RVA: 0x000C5F84 File Offset: 0x000C4184
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002148 RID: 8520
			public int <>1__state;

			// Token: 0x04002149 RID: 8521
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400214A RID: 8522
			public workshop repair;

			// Token: 0x0400214B RID: 8523
			public WorkshopService <>4__this;

			// Token: 0x0400214C RID: 8524
			private WorkshopService.<>c__DisplayClass29_0 <>8__1;

			// Token: 0x0400214D RID: 8525
			private HistoryV2 <history>5__2;

			// Token: 0x0400214E RID: 8526
			private auseceEntities <ctx>5__3;

			// Token: 0x0400214F RID: 8527
			private workshop <original>5__4;

			// Token: 0x04002150 RID: 8528
			private TaskAwaiter<workshop> <>u__1;

			// Token: 0x04002151 RID: 8529
			private TaskAwaiter<int> <>u__2;

			// Token: 0x04002152 RID: 8530
			private TaskAwaiter <>u__3;
		}

		// Token: 0x02000635 RID: 1589
		[CompilerGenerated]
		private sealed class <>c__DisplayClass31_0
		{
			// Token: 0x06003804 RID: 14340 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass31_0()
			{
			}

			// Token: 0x04002153 RID: 8531
			public int repairId;
		}

		// Token: 0x02000636 RID: 1590
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <DeleteAsync>d__31 : IAsyncStateMachine
		{
			// Token: 0x06003805 RID: 14341 RVA: 0x000C5FA0 File Offset: 0x000C41A0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopService workshopService = this.<>4__this;
				try
				{
					if (num > 3)
					{
						this.<>8__1 = new WorkshopService.<>c__DisplayClass31_0();
						this.<>8__1.repairId = this.repairId;
						this.<ctx>5__2 = workshopService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<workshop> awaiter;
						TaskAwaiter<int> awaiter2;
						TaskAwaiter awaiter3;
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
							this.<>u__2 = default(TaskAwaiter<int>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
							goto IL_190;
						}
						case 2:
						{
							awaiter3 = this.<>u__3;
							this.<>u__3 = default(TaskAwaiter);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
							goto IL_203;
						}
						case 3:
						{
							awaiter3 = this.<>u__3;
							this.<>u__3 = default(TaskAwaiter);
							int num5 = -1;
							num = -1;
							this.<>1__state = num5;
							goto IL_287;
						}
						default:
							awaiter = this.<ctx>5__2.workshop.SingleAsync((workshop i) => i.id == this.<>8__1.repairId).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num6 = 0;
								num = 0;
								this.<>1__state = num6;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop>, WorkshopService.<DeleteAsync>d__31>(ref awaiter, ref this);
								return;
							}
							break;
						}
						workshop result = awaiter.GetResult();
						this.<order>5__3 = result;
						this.<order>5__3.Hidden = true;
						awaiter2 = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num7 = 1;
							num = 1;
							this.<>1__state = num7;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, WorkshopService.<DeleteAsync>d__31>(ref awaiter2, ref this);
							return;
						}
						IL_190:
						awaiter2.GetResult();
						awaiter3 = Bootstrapper.Container.Resolve<ICustomerService>().UpdateRepairsCount(this.<order>5__3.client).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							int num8 = 2;
							num = 2;
							this.<>1__state = num8;
							this.<>u__3 = awaiter3;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopService.<DeleteAsync>d__31>(ref awaiter3, ref this);
							return;
						}
						IL_203:
						awaiter3.GetResult();
						workshopService._historyService.AddRepairLog("Deleted", this.<>8__1.repairId, null, null, null, null, null, null);
						awaiter3 = workshopService._historyService.SaveAsync().GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							int num9 = 3;
							num = 3;
							this.<>1__state = num9;
							this.<>u__3 = awaiter3;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopService.<DeleteAsync>d__31>(ref awaiter3, ref this);
							return;
						}
						IL_287:
						awaiter3.GetResult();
						this.<order>5__3 = null;
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
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003806 RID: 14342 RVA: 0x000C62D4 File Offset: 0x000C44D4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002154 RID: 8532
			public int <>1__state;

			// Token: 0x04002155 RID: 8533
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002156 RID: 8534
			public int repairId;

			// Token: 0x04002157 RID: 8535
			public WorkshopService <>4__this;

			// Token: 0x04002158 RID: 8536
			private WorkshopService.<>c__DisplayClass31_0 <>8__1;

			// Token: 0x04002159 RID: 8537
			private auseceEntities <ctx>5__2;

			// Token: 0x0400215A RID: 8538
			private workshop <order>5__3;

			// Token: 0x0400215B RID: 8539
			private TaskAwaiter<workshop> <>u__1;

			// Token: 0x0400215C RID: 8540
			private TaskAwaiter<int> <>u__2;

			// Token: 0x0400215D RID: 8541
			private TaskAwaiter <>u__3;
		}

		// Token: 0x02000637 RID: 1591
		[CompilerGenerated]
		private sealed class <>c__DisplayClass32_0
		{
			// Token: 0x06003807 RID: 14343 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass32_0()
			{
			}

			// Token: 0x0400215E RID: 8542
			public int repairId;
		}

		// Token: 0x02000638 RID: 1592
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <RestoreAsync>d__32 : IAsyncStateMachine
		{
			// Token: 0x06003808 RID: 14344 RVA: 0x000C62F0 File Offset: 0x000C44F0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopService workshopService = this.<>4__this;
				try
				{
					if (num > 3)
					{
						this.<>8__1 = new WorkshopService.<>c__DisplayClass32_0();
						this.<>8__1.repairId = this.repairId;
						this.<ctx>5__2 = workshopService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<workshop> awaiter;
						TaskAwaiter<int> awaiter2;
						TaskAwaiter awaiter3;
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
							this.<>u__2 = default(TaskAwaiter<int>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
							goto IL_190;
						}
						case 2:
						{
							awaiter3 = this.<>u__3;
							this.<>u__3 = default(TaskAwaiter);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
							goto IL_203;
						}
						case 3:
						{
							awaiter3 = this.<>u__3;
							this.<>u__3 = default(TaskAwaiter);
							int num5 = -1;
							num = -1;
							this.<>1__state = num5;
							goto IL_287;
						}
						default:
							awaiter = this.<ctx>5__2.workshop.SingleAsync((workshop i) => i.id == this.<>8__1.repairId).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num6 = 0;
								num = 0;
								this.<>1__state = num6;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop>, WorkshopService.<RestoreAsync>d__32>(ref awaiter, ref this);
								return;
							}
							break;
						}
						workshop result = awaiter.GetResult();
						this.<order>5__3 = result;
						this.<order>5__3.Hidden = false;
						awaiter2 = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num7 = 1;
							num = 1;
							this.<>1__state = num7;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, WorkshopService.<RestoreAsync>d__32>(ref awaiter2, ref this);
							return;
						}
						IL_190:
						awaiter2.GetResult();
						awaiter3 = Bootstrapper.Container.Resolve<ICustomerService>().UpdateRepairsCount(this.<order>5__3.client).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							int num8 = 2;
							num = 2;
							this.<>1__state = num8;
							this.<>u__3 = awaiter3;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopService.<RestoreAsync>d__32>(ref awaiter3, ref this);
							return;
						}
						IL_203:
						awaiter3.GetResult();
						workshopService._historyService.AddRepairLog("Restored", this.<>8__1.repairId, null, null, null, null, null, null);
						awaiter3 = workshopService._historyService.SaveAsync().GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							int num9 = 3;
							num = 3;
							this.<>1__state = num9;
							this.<>u__3 = awaiter3;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopService.<RestoreAsync>d__32>(ref awaiter3, ref this);
							return;
						}
						IL_287:
						awaiter3.GetResult();
						this.<order>5__3 = null;
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
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003809 RID: 14345 RVA: 0x000C6624 File Offset: 0x000C4824
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400215F RID: 8543
			public int <>1__state;

			// Token: 0x04002160 RID: 8544
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002161 RID: 8545
			public int repairId;

			// Token: 0x04002162 RID: 8546
			public WorkshopService <>4__this;

			// Token: 0x04002163 RID: 8547
			private WorkshopService.<>c__DisplayClass32_0 <>8__1;

			// Token: 0x04002164 RID: 8548
			private auseceEntities <ctx>5__2;

			// Token: 0x04002165 RID: 8549
			private workshop <order>5__3;

			// Token: 0x04002166 RID: 8550
			private TaskAwaiter<workshop> <>u__1;

			// Token: 0x04002167 RID: 8551
			private TaskAwaiter<int> <>u__2;

			// Token: 0x04002168 RID: 8552
			private TaskAwaiter <>u__3;
		}

		// Token: 0x02000639 RID: 1593
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateRepair>d__33 : IAsyncStateMachine
		{
			// Token: 0x0600380A RID: 14346 RVA: 0x000C6640 File Offset: 0x000C4840
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopService workshopService = this.<>4__this;
				int id;
				try
				{
					if (num > 7)
					{
						this.<history>5__2 = new HistoryV2();
					}
					try
					{
						if (num > 7)
						{
							this.<barcode>5__3 = new Barcode(Barcode.Types.Repair);
							this.<ctx>5__4 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<int> awaiter;
							TaskAwaiter awaiter2;
							switch (num)
							{
							case 0:
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<int>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								break;
							}
							case 1:
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<int>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
								goto IL_153;
							}
							case 2:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
								goto IL_224;
							}
							case 3:
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<int>);
								int num5 = -1;
								num = -1;
								this.<>1__state = num5;
								goto IL_2C1;
							}
							case 4:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter);
								int num6 = -1;
								num = -1;
								this.<>1__state = num6;
								goto IL_334;
							}
							case 5:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter);
								int num7 = -1;
								num = -1;
								this.<>1__state = num7;
								goto IL_39D;
							}
							case 6:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter);
								int num8 = -1;
								num = -1;
								this.<>1__state = num8;
								goto IL_400;
							}
							case 7:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter);
								int num9 = -1;
								num = -1;
								this.<>1__state = num9;
								goto IL_478;
							}
							default:
								this.<ctx>5__4.workshop.Add(this.repair);
								awaiter = this.<ctx>5__4.SaveChangesAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num10 = 0;
									num = 0;
									this.<>1__state = num10;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, WorkshopService.<CreateRepair>d__33>(ref awaiter, ref this);
									return;
								}
								break;
							}
							awaiter.GetResult();
							this.repair.barcode = this.<barcode>5__3.GenerateCode(this.repair.id);
							awaiter = this.<ctx>5__4.SaveChangesAsync().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num11 = 1;
								num = 1;
								this.<>1__state = num11;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, WorkshopService.<CreateRepair>d__33>(ref awaiter, ref this);
								return;
							}
							IL_153:
							awaiter.GetResult();
							this.<history>5__2.AddRepairLog("newRepairCreated", this.repair.id, null, null, null, null, null, null);
							awaiter2 = this.<ctx>5__4.Entry<workshop>(this.repair).Reference<boxes>((workshop r) => r.boxes).LoadAsync().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num12 = 2;
								num = 2;
								this.<>1__state = num12;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopService.<CreateRepair>d__33>(ref awaiter2, ref this);
								return;
							}
							IL_224:
							awaiter2.GetResult();
							if (this.repair.boxes != null)
							{
								this.<history>5__2.AddRepairLog("putInBox", this.repair.id, this.repair.boxes.name, "");
							}
							awaiter = this.<ctx>5__4.SaveChangesAsync().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num13 = 3;
								num = 3;
								this.<>1__state = num13;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, WorkshopService.<CreateRepair>d__33>(ref awaiter, ref this);
								return;
							}
							IL_2C1:
							awaiter.GetResult();
							awaiter2 = Bootstrapper.Container.Resolve<ICustomerService>().UpdateRepairsCount(this.repair.client).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num14 = 4;
								num = 4;
								this.<>1__state = num14;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopService.<CreateRepair>d__33>(ref awaiter2, ref this);
								return;
							}
							IL_334:
							awaiter2.GetResult();
							awaiter2 = WorkshopService.SetOrderTitle(this.repair, this.<ctx>5__4).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num15 = 5;
								num = 5;
								this.<>1__state = num15;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopService.<CreateRepair>d__33>(ref awaiter2, ref this);
								return;
							}
							IL_39D:
							awaiter2.GetResult();
							awaiter2 = this.<history>5__2.SaveAsync().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num16 = 6;
								num = 6;
								this.<>1__state = num16;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopService.<CreateRepair>d__33>(ref awaiter2, ref this);
								return;
							}
							IL_400:
							awaiter2.GetResult();
							awaiter2 = Bootstrapper.Container.Resolve<IWorkshopStatusService>().UpdateStatusLog(this.<ctx>5__4, new RepairStatusLogModel(this.repair)).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num17 = 7;
								num = 7;
								this.<>1__state = num17;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopService.<CreateRepair>d__33>(ref awaiter2, ref this);
								return;
							}
							IL_478:
							awaiter2.GetResult();
							id = this.repair.id;
						}
						finally
						{
							if (num < 0 && this.<ctx>5__4 != null)
							{
								((IDisposable)this.<ctx>5__4).Dispose();
							}
						}
					}
					catch (Exception ex)
					{
						workshopService._logger.Error(ex, ex.Message);
						throw;
					}
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
				this.<>t__builder.SetResult(id);
			}

			// Token: 0x0600380B RID: 14347 RVA: 0x000C6B94 File Offset: 0x000C4D94
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002169 RID: 8553
			public int <>1__state;

			// Token: 0x0400216A RID: 8554
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x0400216B RID: 8555
			public workshop repair;

			// Token: 0x0400216C RID: 8556
			public WorkshopService <>4__this;

			// Token: 0x0400216D RID: 8557
			private HistoryV2 <history>5__2;

			// Token: 0x0400216E RID: 8558
			private Barcode <barcode>5__3;

			// Token: 0x0400216F RID: 8559
			private auseceEntities <ctx>5__4;

			// Token: 0x04002170 RID: 8560
			private TaskAwaiter<int> <>u__1;

			// Token: 0x04002171 RID: 8561
			private TaskAwaiter <>u__2;
		}

		// Token: 0x0200063A RID: 1594
		[CompilerGenerated]
		private sealed class <>c__DisplayClass34_0
		{
			// Token: 0x0600380C RID: 14348 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass34_0()
			{
			}

			// Token: 0x04002172 RID: 8562
			public workshop repair;
		}

		// Token: 0x0200063B RID: 1595
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SetOrderTitle>d__34 : IAsyncStateMachine
		{
			// Token: 0x0600380D RID: 14349 RVA: 0x000C6BB0 File Offset: 0x000C4DB0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					TaskAwaiter<string> awaiter;
					TaskAwaiter<int> awaiter2;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<string>);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<string>);
						this.<>1__state = -1;
						goto IL_286;
					case 2:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<string>);
						this.<>1__state = -1;
						goto IL_3EF;
					case 3:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<string>);
						this.<>1__state = -1;
						goto IL_55F;
					case 4:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<int>);
						this.<>1__state = -1;
						goto IL_601;
					default:
						this.<>8__1 = new WorkshopService.<>c__DisplayClass34_0();
						this.<>8__1.repair = this.repair;
						awaiter = (from i in this.ctx.devices
						where i.id == this.<>8__1.repair.type
						select i.name).FirstOrDefaultAsync<string>().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, WorkshopService.<SetOrderTitle>d__34>(ref awaiter, ref this);
							return;
						}
						break;
					}
					string result = awaiter.GetResult();
					this.<type>5__2 = result;
					awaiter = (from i in this.ctx.device_makers
					where i.id == this.<>8__1.repair.maker
					select i.name).FirstOrDefaultAsync<string>().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, WorkshopService.<SetOrderTitle>d__34>(ref awaiter, ref this);
						return;
					}
					IL_286:
					result = awaiter.GetResult();
					this.<brand>5__3 = result;
					string text = "";
					if (this.<>8__1.repair.model == null)
					{
						goto IL_3F7;
					}
					awaiter = (from i in this.ctx.device_models
					where i.id == this.<>8__1.repair.model.Value
					select i.name).FirstOrDefaultAsync<string>().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, WorkshopService.<SetOrderTitle>d__34>(ref awaiter, ref this);
						return;
					}
					IL_3EF:
					text = awaiter.GetResult();
					IL_3F7:
					if (this.<>8__1.repair.cartridge == null)
					{
						goto IL_567;
					}
					awaiter = (from i in this.ctx.c_workshop
					where i.id == this.<>8__1.repair.cartridge.Value
					select i.cartridge_cards.name).FirstOrDefaultAsync<string>().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, WorkshopService.<SetOrderTitle>d__34>(ref awaiter, ref this);
						return;
					}
					IL_55F:
					text = awaiter.GetResult();
					IL_567:
					this.<>8__1.repair.Title = string.Concat(new string[]
					{
						this.<type>5__2,
						" ",
						this.<brand>5__3,
						" ",
						text
					});
					awaiter2 = this.ctx.SaveChangesAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 4;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, WorkshopService.<SetOrderTitle>d__34>(ref awaiter2, ref this);
						return;
					}
					IL_601:
					awaiter2.GetResult();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<type>5__2 = null;
					this.<brand>5__3 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<type>5__2 = null;
				this.<brand>5__3 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x0600380E RID: 14350 RVA: 0x000C723C File Offset: 0x000C543C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002173 RID: 8563
			public int <>1__state;

			// Token: 0x04002174 RID: 8564
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002175 RID: 8565
			public workshop repair;

			// Token: 0x04002176 RID: 8566
			public auseceEntities ctx;

			// Token: 0x04002177 RID: 8567
			private WorkshopService.<>c__DisplayClass34_0 <>8__1;

			// Token: 0x04002178 RID: 8568
			private string <type>5__2;

			// Token: 0x04002179 RID: 8569
			private string <brand>5__3;

			// Token: 0x0400217A RID: 8570
			private TaskAwaiter<string> <>u__1;

			// Token: 0x0400217B RID: 8571
			private TaskAwaiter<int> <>u__2;
		}

		// Token: 0x0200063C RID: 1596
		[CompilerGenerated]
		private sealed class <>c__DisplayClass35_0
		{
			// Token: 0x0600380F RID: 14351 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass35_0()
			{
			}

			// Token: 0x0400217C RID: 8572
			public int repairId;
		}

		// Token: 0x0200063D RID: 1597
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetRepair>d__35 : IAsyncStateMachine
		{
			// Token: 0x06003810 RID: 14352 RVA: 0x000C7258 File Offset: 0x000C5458
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopService workshopService = this.<>4__this;
				workshop result;
				try
				{
					WorkshopService.<>c__DisplayClass35_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new WorkshopService.<>c__DisplayClass35_0();
						CS$<>8__locals1.repairId = this.repairId;
					}
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2 = workshopService._contextFactory.Create();
						}
						try
						{
							TaskAwaiter<workshop> awaiter;
							if (num != 0)
							{
								awaiter = this.<ctx>5__2.workshop.Include((workshop r) => r.lock_users).Include((workshop r) => r.clients).Include((workshop r) => r.field_values).Include((workshop r) => r.invoice1).Include((workshop r) => r.c_workshop.cartridge_cards).Include((workshop r) => from f in r.field_values
								select f.fields).SingleAsync((workshop r) => r.id == CS$<>8__locals1.repairId).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop>, WorkshopService.<GetRepair>d__35>(ref awaiter, ref this);
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
					catch (Exception e)
					{
						workshopService._logger.Error(e, "Get repair failed");
						throw;
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

			// Token: 0x06003811 RID: 14353 RVA: 0x000C7610 File Offset: 0x000C5810
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400217D RID: 8573
			public int <>1__state;

			// Token: 0x0400217E RID: 8574
			public AsyncTaskMethodBuilder<workshop> <>t__builder;

			// Token: 0x0400217F RID: 8575
			public int repairId;

			// Token: 0x04002180 RID: 8576
			public WorkshopService <>4__this;

			// Token: 0x04002181 RID: 8577
			private auseceEntities <ctx>5__2;

			// Token: 0x04002182 RID: 8578
			private TaskAwaiter<workshop> <>u__1;
		}

		// Token: 0x0200063E RID: 1598
		[CompilerGenerated]
		private sealed class <>c__DisplayClass36_0
		{
			// Token: 0x06003812 RID: 14354 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass36_0()
			{
			}

			// Token: 0x04002183 RID: 8579
			public int repairId;
		}

		// Token: 0x0200063F RID: 1599
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetRepairInfo>d__36 : IAsyncStateMachine
		{
			// Token: 0x06003813 RID: 14355 RVA: 0x000C762C File Offset: 0x000C582C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopService workshopService = this.<>4__this;
				PreviousRepair result;
				try
				{
					WorkshopService.<>c__DisplayClass36_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new WorkshopService.<>c__DisplayClass36_0();
						CS$<>8__locals1.repairId = this.repairId;
						this.<ctx>5__2 = workshopService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<PreviousRepair> awaiter;
						if (num != 0)
						{
							ParameterExpression parameterExpression;
							awaiter = (from i in this.<ctx>5__2.workshop.Include((workshop r) => from f in r.field_values
							select f.fields)
							where i.id == CS$<>8__locals1.repairId
							select i).Select(Expression.Lambda<Func<workshop, PreviousRepair>>(Expression.MemberInit(Expression.New(typeof(PreviousRepair)), new MemberBinding[]
							{
								Expression.Bind(methodof(PreviousRepair.set_Id(int)), Expression.Property(parameterExpression, methodof(workshop.get_id()))),
								Expression.Bind(methodof(PreviousRepair.set_TypeId(int)), Expression.Property(parameterExpression, methodof(workshop.get_type()))),
								Expression.Bind(methodof(PreviousRepair.set_MakerId(int)), Expression.Property(parameterExpression, methodof(workshop.get_maker()))),
								Expression.Bind(methodof(PreviousRepair.set_ModelName(string)), Expression.Property(Expression.Property(parameterExpression, methodof(workshop.get_device_models())), methodof(device_models.get_name()))),
								Expression.Bind(methodof(PreviousRepair.set_CustomerId(int)), Expression.Property(parameterExpression, methodof(workshop.get_client()))),
								Expression.Bind(methodof(PreviousRepair.set_SerialNumber(string)), Expression.Property(parameterExpression, methodof(workshop.get_serial_number()))),
								Expression.Bind(methodof(PreviousRepair.set_AdditionalFields(ICollection<field_values>)), Expression.Property(parameterExpression, methodof(workshop.get_field_values())))
							}), new ParameterExpression[]
							{
								parameterExpression
							})).FirstOrDefaultAsync<PreviousRepair>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<PreviousRepair>, WorkshopService.<GetRepairInfo>d__36>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<PreviousRepair>);
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

			// Token: 0x06003814 RID: 14356 RVA: 0x000C79EC File Offset: 0x000C5BEC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002184 RID: 8580
			public int <>1__state;

			// Token: 0x04002185 RID: 8581
			public AsyncTaskMethodBuilder<PreviousRepair> <>t__builder;

			// Token: 0x04002186 RID: 8582
			public int repairId;

			// Token: 0x04002187 RID: 8583
			public WorkshopService <>4__this;

			// Token: 0x04002188 RID: 8584
			private auseceEntities <ctx>5__2;

			// Token: 0x04002189 RID: 8585
			private TaskAwaiter<PreviousRepair> <>u__1;
		}

		// Token: 0x02000640 RID: 1600
		[CompilerGenerated]
		private sealed class <>c__DisplayClass37_0
		{
			// Token: 0x06003815 RID: 14357 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass37_0()
			{
			}

			// Token: 0x0400218A RID: 8586
			public int repairId;
		}

		// Token: 0x02000641 RID: 1601
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetRepairCustomerId>d__37 : IAsyncStateMachine
		{
			// Token: 0x06003816 RID: 14358 RVA: 0x000C7A08 File Offset: 0x000C5C08
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopService workshopService = this.<>4__this;
				int result;
				try
				{
					WorkshopService.<>c__DisplayClass37_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new WorkshopService.<>c__DisplayClass37_0();
						CS$<>8__locals1.repairId = this.repairId;
						this.<ctx>5__2 = workshopService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<int> awaiter;
						if (num != 0)
						{
							awaiter = (from i in this.<ctx>5__2.workshop
							where i.id == CS$<>8__locals1.repairId
							select i.client).FirstOrDefaultAsync<int>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, WorkshopService.<GetRepairCustomerId>d__37>(ref awaiter, ref this);
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
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06003817 RID: 14359 RVA: 0x000C7BD8 File Offset: 0x000C5DD8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400218B RID: 8587
			public int <>1__state;

			// Token: 0x0400218C RID: 8588
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x0400218D RID: 8589
			public int repairId;

			// Token: 0x0400218E RID: 8590
			public WorkshopService <>4__this;

			// Token: 0x0400218F RID: 8591
			private auseceEntities <ctx>5__2;

			// Token: 0x04002190 RID: 8592
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x02000642 RID: 1602
		[CompilerGenerated]
		private sealed class <>c__DisplayClass38_0
		{
			// Token: 0x06003818 RID: 14360 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass38_0()
			{
			}

			// Token: 0x04002191 RID: 8593
			public int repairId;
		}

		// Token: 0x02000643 RID: 1603
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetRepairPaymentInfo>d__38 : IAsyncStateMachine
		{
			// Token: 0x06003819 RID: 14361 RVA: 0x000C7BF4 File Offset: 0x000C5DF4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopService workshopService = this.<>4__this;
				RepairPaymentInfo result;
				try
				{
					WorkshopService.<>c__DisplayClass38_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new WorkshopService.<>c__DisplayClass38_0();
						CS$<>8__locals1.repairId = this.repairId;
						this.<ctx>5__2 = workshopService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<RepairPaymentInfo> awaiter;
						if (num != 0)
						{
							ParameterExpression parameterExpression;
							awaiter = (from i in this.<ctx>5__2.workshop
							where i.id == CS$<>8__locals1.repairId
							select i).Select(Expression.Lambda<Func<workshop, RepairPaymentInfo>>(Expression.MemberInit(Expression.New(typeof(RepairPaymentInfo)), new MemberBinding[]
							{
								Expression.Bind(methodof(RepairPaymentInfo.set_CompanyId(int)), Expression.Property(parameterExpression, methodof(workshop.get_company()))),
								Expression.Bind(methodof(RepairPaymentInfo.set_CustomerId(int)), Expression.Property(parameterExpression, methodof(workshop.get_client()))),
								Expression.Bind(methodof(RepairPaymentInfo.set_PaymentSystemId(int)), Expression.Property(parameterExpression, methodof(workshop.get_payment_system()))),
								Expression.Bind(methodof(RepairPaymentInfo.set_PrepaidAmount(decimal)), Expression.Property(parameterExpression, methodof(workshop.get_prepaid_summ())))
							}), new ParameterExpression[]
							{
								parameterExpression
							})).FirstOrDefaultAsync<RepairPaymentInfo>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<RepairPaymentInfo>, WorkshopService.<GetRepairPaymentInfo>d__38>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<RepairPaymentInfo>);
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

			// Token: 0x0600381A RID: 14362 RVA: 0x000C7E7C File Offset: 0x000C607C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002192 RID: 8594
			public int <>1__state;

			// Token: 0x04002193 RID: 8595
			public AsyncTaskMethodBuilder<RepairPaymentInfo> <>t__builder;

			// Token: 0x04002194 RID: 8596
			public int repairId;

			// Token: 0x04002195 RID: 8597
			public WorkshopService <>4__this;

			// Token: 0x04002196 RID: 8598
			private auseceEntities <ctx>5__2;

			// Token: 0x04002197 RID: 8599
			private TaskAwaiter<RepairPaymentInfo> <>u__1;
		}

		// Token: 0x02000644 RID: 1604
		[CompilerGenerated]
		private sealed class <>c__DisplayClass39_0
		{
			// Token: 0x0600381B RID: 14363 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass39_0()
			{
			}

			// Token: 0x04002198 RID: 8600
			public int repairId;
		}

		// Token: 0x02000645 RID: 1605
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetRepairDeviceInfo>d__39 : IAsyncStateMachine
		{
			// Token: 0x0600381C RID: 14364 RVA: 0x000C7E98 File Offset: 0x000C6098
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopService workshopService = this.<>4__this;
				RepairDeviceInfo result;
				try
				{
					WorkshopService.<>c__DisplayClass39_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new WorkshopService.<>c__DisplayClass39_0();
						CS$<>8__locals1.repairId = this.repairId;
						this.<ctx>5__2 = workshopService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<RepairDeviceInfo> awaiter;
						if (num != 0)
						{
							ParameterExpression parameterExpression;
							awaiter = (from i in this.<ctx>5__2.workshop
							where i.id == CS$<>8__locals1.repairId
							select i).Select(Expression.Lambda<Func<workshop, RepairDeviceInfo>>(Expression.MemberInit(Expression.New(typeof(RepairDeviceInfo)), new MemberBinding[]
							{
								Expression.Bind(methodof(RepairDeviceInfo.set_Type(string)), Expression.Property(Expression.Property(parameterExpression, methodof(workshop.get_devices())), methodof(devices.get_name()))),
								Expression.Bind(methodof(RepairDeviceInfo.set_Brand(string)), Expression.Property(Expression.Property(parameterExpression, methodof(workshop.get_device_makers())), methodof(device_makers.get_name()))),
								Expression.Bind(methodof(RepairDeviceInfo.set_Model(string)), Expression.Condition(Expression.Property(Expression.Property(parameterExpression, methodof(workshop.get_model())), methodof(int?.get_HasValue())), Expression.Property(Expression.Property(parameterExpression, methodof(workshop.get_device_models())), methodof(device_models.get_name())), Expression.Constant("", typeof(string))))
							}), new ParameterExpression[]
							{
								parameterExpression
							})).FirstOrDefaultAsync<RepairDeviceInfo>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<RepairDeviceInfo>, WorkshopService.<GetRepairDeviceInfo>d__39>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<RepairDeviceInfo>);
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

			// Token: 0x0600381D RID: 14365 RVA: 0x000C8178 File Offset: 0x000C6378
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002199 RID: 8601
			public int <>1__state;

			// Token: 0x0400219A RID: 8602
			public AsyncTaskMethodBuilder<RepairDeviceInfo> <>t__builder;

			// Token: 0x0400219B RID: 8603
			public int repairId;

			// Token: 0x0400219C RID: 8604
			public WorkshopService <>4__this;

			// Token: 0x0400219D RID: 8605
			private auseceEntities <ctx>5__2;

			// Token: 0x0400219E RID: 8606
			private TaskAwaiter<RepairDeviceInfo> <>u__1;
		}

		// Token: 0x02000646 RID: 1606
		[CompilerGenerated]
		private sealed class <>c__DisplayClass40_0
		{
			// Token: 0x0600381E RID: 14366 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass40_0()
			{
			}

			// Token: 0x0400219F RID: 8607
			public int repairId;
		}

		// Token: 0x02000647 RID: 1607
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetMassEditModel>d__40 : IAsyncStateMachine
		{
			// Token: 0x0600381F RID: 14367 RVA: 0x000C8194 File Offset: 0x000C6394
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopService workshopService = this.<>4__this;
				RepairMassEditModel result;
				try
				{
					WorkshopService.<>c__DisplayClass40_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new WorkshopService.<>c__DisplayClass40_0();
						CS$<>8__locals1.repairId = this.repairId;
						this.<ctx>5__2 = workshopService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<RepairMassEditModel> awaiter;
						if (num != 0)
						{
							ParameterExpression parameterExpression;
							awaiter = (from i in this.<ctx>5__2.workshop
							where i.id == CS$<>8__locals1.repairId
							select i).Select(Expression.Lambda<Func<workshop, RepairMassEditModel>>(Expression.MemberInit(Expression.New(typeof(RepairMassEditModel)), new MemberBinding[]
							{
								Expression.Bind(methodof(RepairMassEditModel.set_Id(int)), Expression.Property(parameterExpression, methodof(workshop.get_id()))),
								Expression.Bind(methodof(RepairMassEditModel.set_Title(string)), Expression.Property(parameterExpression, methodof(workshop.get_Title()))),
								Expression.Bind(methodof(RepairMassEditModel.set_BoxId(int?)), Expression.Property(parameterExpression, methodof(workshop.get_box())))
							}), new ParameterExpression[]
							{
								parameterExpression
							})).SingleAsync<RepairMassEditModel>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<RepairMassEditModel>, WorkshopService.<GetMassEditModel>d__40>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<RepairMassEditModel>);
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

			// Token: 0x06003820 RID: 14368 RVA: 0x000C83F0 File Offset: 0x000C65F0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040021A0 RID: 8608
			public int <>1__state;

			// Token: 0x040021A1 RID: 8609
			public AsyncTaskMethodBuilder<RepairMassEditModel> <>t__builder;

			// Token: 0x040021A2 RID: 8610
			public int repairId;

			// Token: 0x040021A3 RID: 8611
			public WorkshopService <>4__this;

			// Token: 0x040021A4 RID: 8612
			private auseceEntities <ctx>5__2;

			// Token: 0x040021A5 RID: 8613
			private TaskAwaiter<RepairMassEditModel> <>u__1;
		}

		// Token: 0x02000648 RID: 1608
		[CompilerGenerated]
		private sealed class <>c__DisplayClass41_0
		{
			// Token: 0x06003821 RID: 14369 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass41_0()
			{
			}

			// Token: 0x040021A6 RID: 8614
			public RepairMassEditModel item;
		}

		// Token: 0x02000649 RID: 1609
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateRepairs>d__41 : IAsyncStateMachine
		{
			// Token: 0x06003822 RID: 14370 RVA: 0x000C840C File Offset: 0x000C660C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopService workshopService = this.<>4__this;
				try
				{
					if (num > 1)
					{
						this.<ctx>5__2 = workshopService._contextFactory.Create();
					}
					try
					{
						if (num > 1)
						{
							this.<>7__wrap2 = this.items.GetEnumerator();
						}
						try
						{
							TaskAwaiter<int?> awaiter;
							if (num == 0)
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<int?>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								goto IL_1DD;
							}
							if (num != 1)
							{
								goto IL_8D;
							}
							TaskAwaiter awaiter2 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
							goto IL_1D1;
							IL_86:
							this.<>8__1 = null;
							IL_8D:
							if (!this.<>7__wrap2.MoveNext())
							{
								goto IL_281;
							}
							this.<>8__1 = new WorkshopService.<>c__DisplayClass41_0();
							this.<>8__1.item = this.<>7__wrap2.Current;
							awaiter = (from i in this.<ctx>5__2.workshop
							where i.id == this.<>8__1.item.Id
							select i.box).SingleAsync<int?>().GetAwaiter();
							if (awaiter.IsCompleted)
							{
								goto IL_1DD;
							}
							int num4 = 0;
							num = 0;
							this.<>1__state = num4;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int?>, WorkshopService.<UpdateRepairs>d__41>(ref awaiter, ref this);
							return;
							IL_1D1:
							awaiter2.GetResult();
							goto IL_86;
							IL_1DD:
							int? result = awaiter.GetResult();
							int? boxId = this.<>8__1.item.BoxId;
							if (result.GetValueOrDefault() == boxId.GetValueOrDefault() & result != null == (boxId != null))
							{
								goto IL_86;
							}
							awaiter2 = workshopService.SaveBox(this.<>8__1.item.Id, this.<>8__1.item.BoxId).GetAwaiter();
							if (awaiter2.IsCompleted)
							{
								goto IL_1D1;
							}
							int num5 = 1;
							num = 1;
							this.<>1__state = num5;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopService.<UpdateRepairs>d__41>(ref awaiter2, ref this);
							return;
						}
						finally
						{
							if (num < 0 && this.<>7__wrap2 != null)
							{
								this.<>7__wrap2.Dispose();
							}
						}
						IL_281:
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
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003823 RID: 14371 RVA: 0x000C873C File Offset: 0x000C693C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040021A7 RID: 8615
			public int <>1__state;

			// Token: 0x040021A8 RID: 8616
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040021A9 RID: 8617
			public WorkshopService <>4__this;

			// Token: 0x040021AA RID: 8618
			public IList<RepairMassEditModel> items;

			// Token: 0x040021AB RID: 8619
			private WorkshopService.<>c__DisplayClass41_0 <>8__1;

			// Token: 0x040021AC RID: 8620
			private auseceEntities <ctx>5__2;

			// Token: 0x040021AD RID: 8621
			private IEnumerator<RepairMassEditModel> <>7__wrap2;

			// Token: 0x040021AE RID: 8622
			private TaskAwaiter<int?> <>u__1;

			// Token: 0x040021AF RID: 8623
			private TaskAwaiter <>u__2;
		}

		// Token: 0x0200064A RID: 1610
		[CompilerGenerated]
		private sealed class <>c__DisplayClass42_0
		{
			// Token: 0x06003824 RID: 14372 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass42_0()
			{
			}

			// Token: 0x040021B0 RID: 8624
			public workshop repair;
		}

		// Token: 0x0200064B RID: 1611
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateDiagnosticResult>d__42 : IAsyncStateMachine
		{
			// Token: 0x06003825 RID: 14373 RVA: 0x000C8758 File Offset: 0x000C6958
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					if (num > 2)
					{
						this.<>8__1 = new WorkshopService.<>c__DisplayClass42_0();
						this.<>8__1.repair = this.repair;
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
							goto IL_19A;
						}
						case 2:
						{
							awaiter3 = this.<>u__3;
							this.<>u__3 = default(TaskAwaiter<int>);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
							goto IL_233;
						}
						default:
							awaiter = this.<ctx>5__2.workshop.SingleAsync((workshop i) => i.id == this.<>8__1.repair.id).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num5 = 0;
								num = 0;
								this.<>1__state = num5;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop>, WorkshopService.<UpdateDiagnosticResult>d__42>(ref awaiter, ref this);
								return;
							}
							break;
						}
						workshop result = awaiter.GetResult();
						this.<original>5__3 = result;
						awaiter2 = Bootstrapper.Container.Resolve<IWorkshopHistoryService>().LogRepairChanges(this.<original>5__3, this.<>8__1.repair).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num6 = 1;
							num = 1;
							this.<>1__state = num6;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkshopService.<UpdateDiagnosticResult>d__42>(ref awaiter2, ref this);
							return;
						}
						IL_19A:
						awaiter2.GetResult();
						this.<original>5__3.diagnostic_result = this.<>8__1.repair.diagnostic_result;
						this.<original>5__3.repair_cost = this.<>8__1.repair.repair_cost;
						awaiter3 = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							int num7 = 2;
							num = 2;
							this.<>1__state = num7;
							this.<>u__3 = awaiter3;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, WorkshopService.<UpdateDiagnosticResult>d__42>(ref awaiter3, ref this);
							return;
						}
						IL_233:
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
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003826 RID: 14374 RVA: 0x000C8A38 File Offset: 0x000C6C38
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040021B1 RID: 8625
			public int <>1__state;

			// Token: 0x040021B2 RID: 8626
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040021B3 RID: 8627
			public workshop repair;

			// Token: 0x040021B4 RID: 8628
			private WorkshopService.<>c__DisplayClass42_0 <>8__1;

			// Token: 0x040021B5 RID: 8629
			private auseceEntities <ctx>5__2;

			// Token: 0x040021B6 RID: 8630
			private workshop <original>5__3;

			// Token: 0x040021B7 RID: 8631
			private TaskAwaiter<workshop> <>u__1;

			// Token: 0x040021B8 RID: 8632
			private TaskAwaiter <>u__2;

			// Token: 0x040021B9 RID: 8633
			private TaskAwaiter<int> <>u__3;
		}
	}
}
