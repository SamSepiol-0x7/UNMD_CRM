using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;
using ASC.Models;
using ASC.SimpleClasses;

namespace ASC.Objects.Converters
{
	// Token: 0x02000933 RID: 2355
	public static class WorkshopToRepairCardConverter
	{
		// Token: 0x06004857 RID: 18519 RVA: 0x0011C4F8 File Offset: 0x0011A6F8
		public static RepairCard ToRepairCard(this workshop r)
		{
			if (r == null)
			{
				return null;
			}
			RepairCard repairCard = new RepairCard();
			repairCard.Id = r.id;
			repairCard.CompanyId = r.company;
			repairCard.OfficeId = r.office;
			repairCard.InDateTime = r.in_date;
			repairCard.Status = r.state;
			repairCard.DeviceType = new int?(r.type);
			repairCard.DeviceMaker = new int?(r.maker);
			RepairCard repairCard2 = repairCard;
			device_models device_models = r.device_models;
			repairCard2.DeviceModel = ((device_models != null) ? device_models.name : null);
			RepairCard repairCard3 = repairCard;
			string[] array = new string[5];
			int num = 0;
			devices devices = r.devices;
			array[num] = ((devices != null) ? devices.name : null);
			array[1] = " ";
			int num2 = 2;
			device_makers device_makers = r.device_makers;
			array[num2] = ((device_makers != null) ? device_makers.name : null);
			array[3] = " ";
			int num3 = 4;
			device_models device_models2 = r.device_models;
			array[num3] = ((device_models2 != null) ? device_models2.name : null);
			repairCard3.FullDeviceName = string.Concat(array);
			repairCard.SerialNumber = r.serial_number;
			repairCard.BarCode = r.barcode;
			repairCard.ExtNotes = r.ext_notes;
			repairCard.PrepaidType = new int?(r.prepaid_type);
			repairCard.PrepaidSumm = new decimal?(r.prepaid_summ);
			repairCard.PreviousRepair = r.early;
			repairCard.IsPrepaid = r.is_prepaid;
			repairCard.IsPreAgreed = r.is_pre_agreed;
			repairCard.IsWarranty = r.is_warranty;
			repairCard.IsRepeat = r.is_repeat;
			repairCard.CanFormat = r.can_format;
			repairCard.ExpressRepair = r.express_repair.GetValueOrDefault();
			repairCard.ThirdPartySc = r.thirs_party_sc;
			repairCard.MasterId = r.master;
			repairCard.ManagerId = r.current_manager;
			repairCard.BoxId = r.box;
			repairCard.InformStatus = r.informed_status;
			repairCard.Fault = r.fault;
			repairCard.Complect = r.complect;
			repairCard.Look = r.look;
			repairCard.DiagnosticResult = r.diagnostic_result;
			repairCard.RejectReason = r.reject_reason;
			repairCard.RepairCost = r.repair_cost;
			repairCard.RealRepairCost = Fn.FormatSumm(r.real_repair_cost);
			repairCard.PreAgreedSumm = r.pre_agreed_amount;
			repairCard.OutDate = r.out_date;
			repairCard.WorksAndParts = new ObservableCollection<IWorkPartObject>(RepairModel.WorksAndPartsConvert(r.works.ToList<works>(), r.store_int_reserve.ToList<store_int_reserve>(), 0));
			RepairCard repairCard4 = repairCard;
			if (r.clients != null)
			{
				repairCard4.Customer = r.clients.Client2CustomerCard();
			}
			if (r.field_values != null)
			{
				repairCard4.UserFields = (from f in r.field_values
				select f.ToUserField()).ToList<IAttribute>();
			}
			repairCard4.SetStatusColor();
			return repairCard4;
		}

		// Token: 0x02000934 RID: 2356
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004858 RID: 18520 RVA: 0x0011C7BC File Offset: 0x0011A9BC
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004859 RID: 18521 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x0600485A RID: 18522 RVA: 0x001189F0 File Offset: 0x00116BF0
			internal IAttribute <ToRepairCard>b__0_0(field_values f)
			{
				return f.ToUserField();
			}

			// Token: 0x04002E27 RID: 11815
			public static readonly WorkshopToRepairCardConverter.<>c <>9 = new WorkshopToRepairCardConverter.<>c();

			// Token: 0x04002E28 RID: 11816
			public static Func<field_values, IAttribute> <>9__0_0;
		}
	}
}
