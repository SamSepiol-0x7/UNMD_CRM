using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Clients;
using ASC.Common.Interfaces;
using ASC.Common.SimpleClasses;
using ASC.Interfaces;
using ASC.Invoice;
using ASC.Models;
using ASC.Objects;
using ASC.Options;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using ASC.ViewModel;
using ASC.ViewModels;
using ASC.Workspace.Repairs;
using Autofac;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Xpf.Editors;
using DevExpress.XtraReports.UI;

namespace ASC.RepairCard.Admin
{
	// Token: 0x02000852 RID: 2130
	public class AdminViewModel : RepairCardCommonView, IVendorSelect, IInvoiceSelect, IRefreshable, IRepairSelect, ICustomerSelect
	{
		// Token: 0x170010E1 RID: 4321
		// (get) Token: 0x06003F0A RID: 16138 RVA: 0x000FC690 File Offset: 0x000FA890
		// (set) Token: 0x06003F0B RID: 16139 RVA: 0x000FC6A4 File Offset: 0x000FA8A4
		public List<WorkshopOptions> AllWorkshopOptions
		{
			[CompilerGenerated]
			get
			{
				return this.<AllWorkshopOptions>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<AllWorkshopOptions>k__BackingField, value))
				{
					return;
				}
				this.<AllWorkshopOptions>k__BackingField = value;
				this.RaisePropertyChanged("AllWorkshopOptions");
			}
		}

		// Token: 0x170010E2 RID: 4322
		// (get) Token: 0x06003F0C RID: 16140 RVA: 0x000FC6D4 File Offset: 0x000FA8D4
		// (set) Token: 0x06003F0D RID: 16141 RVA: 0x000FC6E8 File Offset: 0x000FA8E8
		public List<PaymentOptions> PaymentOptionses
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentOptionses>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<PaymentOptionses>k__BackingField, value))
				{
					return;
				}
				this.<PaymentOptionses>k__BackingField = value;
				this.RaisePropertyChanged("PaymentOptionses");
			}
		}

		// Token: 0x170010E3 RID: 4323
		// (get) Token: 0x06003F0E RID: 16142 RVA: 0x000FC718 File Offset: 0x000FA918
		// (set) Token: 0x06003F0F RID: 16143 RVA: 0x000FC72C File Offset: 0x000FA92C
		public List<IDevice> Devices
		{
			[CompilerGenerated]
			get
			{
				return this.<Devices>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Devices>k__BackingField, value))
				{
					return;
				}
				this.<Devices>k__BackingField = value;
				this.RaisePropertyChanged("Devices");
			}
		}

		// Token: 0x170010E4 RID: 4324
		// (get) Token: 0x06003F10 RID: 16144 RVA: 0x000FC75C File Offset: 0x000FA95C
		// (set) Token: 0x06003F11 RID: 16145 RVA: 0x000FC770 File Offset: 0x000FA970
		public List<IManufacturer> Makers
		{
			[CompilerGenerated]
			get
			{
				return this.<Makers>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<Makers>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1709853755;
				IL_13:
				switch ((num ^ 1378591370) % 4)
				{
				case 1:
					return;
				case 2:
					IL_32:
					this.<Makers>k__BackingField = value;
					num = 1771580130;
					goto IL_13;
				case 3:
					goto IL_0E;
				}
				this.RaisePropertyChanged("Makers");
			}
		}

		// Token: 0x170010E5 RID: 4325
		// (get) Token: 0x06003F12 RID: 16146 RVA: 0x000FC7CC File Offset: 0x000FA9CC
		// (set) Token: 0x06003F13 RID: 16147 RVA: 0x000FC7E0 File Offset: 0x000FA9E0
		public ObservableCollection<IdNameClass> Models
		{
			[CompilerGenerated]
			get
			{
				return this.<Models>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Models>k__BackingField, value))
				{
					return;
				}
				this.<Models>k__BackingField = value;
				this.RaisePropertyChanged("Models");
			}
		}

		// Token: 0x170010E6 RID: 4326
		// (get) Token: 0x06003F14 RID: 16148 RVA: 0x000FC810 File Offset: 0x000FAA10
		// (set) Token: 0x06003F15 RID: 16149 RVA: 0x000FC824 File Offset: 0x000FAA24
		public bool ShowUserFields
		{
			[CompilerGenerated]
			get
			{
				return this.<ShowUserFields>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ShowUserFields>k__BackingField == value)
				{
					return;
				}
				this.<ShowUserFields>k__BackingField = value;
				this.RaisePropertyChanged("ShowUserFields");
			}
		}

		// Token: 0x170010E7 RID: 4327
		// (get) Token: 0x06003F16 RID: 16150 RVA: 0x000FC850 File Offset: 0x000FAA50
		// (set) Token: 0x06003F17 RID: 16151 RVA: 0x000FC864 File Offset: 0x000FAA64
		public int RejectType
		{
			get
			{
				return this._rejectType;
			}
			set
			{
				if (this._rejectType == value)
				{
					return;
				}
				this._rejectType = value;
				this.RaisePropertyChanged("RejectType");
				this.AutoCompleteRejectReason(value);
			}
		}

		// Token: 0x06003F18 RID: 16152 RVA: 0x000FC898 File Offset: 0x000FAA98
		private bool CanMakeChanges()
		{
			return base.Repair != null && (base.Repair.office == Auth.User.office || OfflineData.Instance.Employee.Can(74, 0));
		}

		// Token: 0x06003F19 RID: 16153 RVA: 0x000FC8E0 File Offset: 0x000FAAE0
		public AdminViewModel()
		{
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
			this._additionalFieldsService = Bootstrapper.Container.Resolve<IAdditionalFieldsService>();
			this._reportPrintService = Bootstrapper.Container.Resolve<IReportPrintService>();
			this._workshopStatusService = Bootstrapper.Container.Resolve<IWorkshopStatusService>();
		}

		// Token: 0x06003F1A RID: 16154 RVA: 0x000FC944 File Offset: 0x000FAB44
		public AdminViewModel(int repairId) : this()
		{
			base.SetViewName("Repair", "Admin", repairId);
			base.RepairId = repairId;
			base.InitLockCard(repairId);
			this.LoadWorkshopOptions();
			this.LoadPaymentOptions();
		}

		// Token: 0x06003F1B RID: 16155 RVA: 0x000FC984 File Offset: 0x000FAB84
		public override void OnLoad()
		{
			AdminViewModel.<OnLoad>d__36 <OnLoad>d__;
			<OnLoad>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnLoad>d__.<>4__this = this;
			<OnLoad>d__.<>1__state = -1;
			<OnLoad>d__.<>t__builder.Start<AdminViewModel.<OnLoad>d__36>(ref <OnLoad>d__);
		}

		// Token: 0x06003F1C RID: 16156 RVA: 0x000FC9BC File Offset: 0x000FABBC
		public virtual Task InitCard()
		{
			AdminViewModel.<InitCard>d__37 <InitCard>d__;
			<InitCard>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<InitCard>d__.<>4__this = this;
			<InitCard>d__.<>1__state = -1;
			<InitCard>d__.<>t__builder.Start<AdminViewModel.<InitCard>d__37>(ref <InitCard>d__);
			return <InitCard>d__.<>t__builder.Task;
		}

		// Token: 0x06003F1D RID: 16157 RVA: 0x000FCA00 File Offset: 0x000FAC00
		private void LoadWorkshopOptions()
		{
			this.AllWorkshopOptions = (from status in this._workshopStatusService.GetStatusList()
			where status.Id != 8
			select status).ToList<WorkshopOptions>();
		}

		// Token: 0x06003F1E RID: 16158 RVA: 0x000FCA48 File Offset: 0x000FAC48
		[AsyncCommand]
		public virtual Task AdminSaveChanges()
		{
			AdminViewModel.<AdminSaveChanges>d__39 <AdminSaveChanges>d__;
			<AdminSaveChanges>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<AdminSaveChanges>d__.<>4__this = this;
			<AdminSaveChanges>d__.<>1__state = -1;
			<AdminSaveChanges>d__.<>t__builder.Start<AdminViewModel.<AdminSaveChanges>d__39>(ref <AdminSaveChanges>d__);
			return <AdminSaveChanges>d__.<>t__builder.Task;
		}

		// Token: 0x06003F1F RID: 16159 RVA: 0x000FCA8C File Offset: 0x000FAC8C
		public bool CanAdminSaveChanges()
		{
			return this.CanMakeChanges();
		}

		// Token: 0x06003F20 RID: 16160 RVA: 0x000FCAA0 File Offset: 0x000FACA0
		[Command]
		public void StatusPopupClosed()
		{
			base.RaiseCanExecuteChanged(() => this.AdminChangeState());
		}

		// Token: 0x06003F21 RID: 16161 RVA: 0x000FCAE8 File Offset: 0x000FACE8
		[Command]
		public void AdminChangeState()
		{
			AdminViewModel.<AdminChangeState>d__42 <AdminChangeState>d__;
			<AdminChangeState>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<AdminChangeState>d__.<>4__this = this;
			<AdminChangeState>d__.<>1__state = -1;
			<AdminChangeState>d__.<>t__builder.Start<AdminViewModel.<AdminChangeState>d__42>(ref <AdminChangeState>d__);
		}

		// Token: 0x06003F22 RID: 16162 RVA: 0x000FCB20 File Offset: 0x000FAD20
		public bool CanAdminChangeState()
		{
			if (base.Repair == null)
			{
				return false;
			}
			if (base.Repair.state != 8)
			{
				if (base.Repair.state != 12)
				{
					return base.Repair.new_state != 8;
				}
			}
			return false;
		}

		// Token: 0x06003F23 RID: 16163 RVA: 0x000FCB6C File Offset: 0x000FAD6C
		[Command]
		public void ShowOrderCancellation()
		{
			OrderCancellationViewModel orderCancellationViewModel = Bootstrapper.Container.Resolve<OrderCancellationViewModel>();
			orderCancellationViewModel.SetRepairId(base.Repair.id);
			orderCancellationViewModel.SetCurrentStatus(base.Repair.state);
			this._windowedDocumentService.ShowNewDocument("OrderCancellationView", orderCancellationViewModel, this, null);
		}

		// Token: 0x06003F24 RID: 16164 RVA: 0x000FCBBC File Offset: 0x000FADBC
		public bool CanShowOrderCancellation()
		{
			if (base.Repair != null)
			{
				goto IL_4B;
			}
			IL_17:
			int num = 1224798659;
			IL_1C:
			switch ((num ^ 390193396) % 5)
			{
			case 0:
				return base.Repair.state == 12;
			case 1:
				return false;
			case 2:
				IL_4B:
				num = ((base.Repair.state == 8) ? 273852869 : 1294672932);
				goto IL_1C;
			case 4:
				goto IL_17;
			}
			return true;
		}

		// Token: 0x06003F25 RID: 16165 RVA: 0x000FCC38 File Offset: 0x000FAE38
		[Command]
		public void MakersChanged()
		{
			if (base.Repair != null && base.Repair.maker != 0)
			{
				this.LoadModels();
				return;
			}
		}

		// Token: 0x06003F26 RID: 16166 RVA: 0x000FCA8C File Offset: 0x000FAC8C
		public bool CanMakersChanged()
		{
			return this.CanMakeChanges();
		}

		// Token: 0x06003F27 RID: 16167 RVA: 0x000FCC64 File Offset: 0x000FAE64
		public virtual void LoadModels()
		{
			AdminViewModel.<LoadModels>d__48 <LoadModels>d__;
			<LoadModels>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadModels>d__.<>4__this = this;
			<LoadModels>d__.<>1__state = -1;
			<LoadModels>d__.<>t__builder.Start<AdminViewModel.<LoadModels>d__48>(ref <LoadModels>d__);
		}

		// Token: 0x06003F28 RID: 16168 RVA: 0x000FCC9C File Offset: 0x000FAE9C
		private void LoadUserFieldsAdmin()
		{
			AdminViewModel.<LoadUserFieldsAdmin>d__49 <LoadUserFieldsAdmin>d__;
			<LoadUserFieldsAdmin>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadUserFieldsAdmin>d__.<>4__this = this;
			<LoadUserFieldsAdmin>d__.<>1__state = -1;
			<LoadUserFieldsAdmin>d__.<>t__builder.Start<AdminViewModel.<LoadUserFieldsAdmin>d__49>(ref <LoadUserFieldsAdmin>d__);
		}

		// Token: 0x06003F29 RID: 16169 RVA: 0x000FCCD4 File Offset: 0x000FAED4
		[Command]
		public void DeviceTypeChanged()
		{
			AdminViewModel.<DeviceTypeChanged>d__50 <DeviceTypeChanged>d__;
			<DeviceTypeChanged>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<DeviceTypeChanged>d__.<>4__this = this;
			<DeviceTypeChanged>d__.<>1__state = -1;
			<DeviceTypeChanged>d__.<>t__builder.Start<AdminViewModel.<DeviceTypeChanged>d__50>(ref <DeviceTypeChanged>d__);
		}

		// Token: 0x06003F2A RID: 16170 RVA: 0x000FCA8C File Offset: 0x000FAC8C
		public bool CanDeviceTypeChanged()
		{
			return this.CanMakeChanges();
		}

		// Token: 0x06003F2B RID: 16171 RVA: 0x000FCD0C File Offset: 0x000FAF0C
		private void RefreshUserFields()
		{
			AdminViewModel.<RefreshUserFields>d__52 <RefreshUserFields>d__;
			<RefreshUserFields>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<RefreshUserFields>d__.<>4__this = this;
			<RefreshUserFields>d__.<>1__state = -1;
			<RefreshUserFields>d__.<>t__builder.Start<AdminViewModel.<RefreshUserFields>d__52>(ref <RefreshUserFields>d__);
		}

		// Token: 0x06003F2C RID: 16172 RVA: 0x000FCD44 File Offset: 0x000FAF44
		private void LoadPaymentOptions()
		{
			PaymentOptions paymentOptions = new PaymentOptions();
			this.PaymentOptionses = paymentOptions.GetAllOptions();
		}

		// Token: 0x06003F2D RID: 16173 RVA: 0x000FCD64 File Offset: 0x000FAF64
		[Command]
		public void OfficeChange()
		{
			this._windowedDocumentService.ShowNewDocument("OfficeChangeView", new OfficeChangeViewModel(base.Repair), this, null);
		}

		// Token: 0x06003F2E RID: 16174 RVA: 0x000FCA8C File Offset: 0x000FAC8C
		public bool CanOfficeChange()
		{
			return this.CanMakeChanges();
		}

		// Token: 0x06003F2F RID: 16175 RVA: 0x000FCD90 File Offset: 0x000FAF90
		public virtual void DataRefresh()
		{
			this.InitCard();
		}

		// Token: 0x06003F30 RID: 16176 RVA: 0x000FCDA4 File Offset: 0x000FAFA4
		[Command]
		public void ManagerChange()
		{
			this._windowedDocumentService.ShowNewDocument("ManagerChangeView", new ManagerChangeViewModel(base.Repair), this, null);
		}

		// Token: 0x06003F31 RID: 16177 RVA: 0x000FCDD0 File Offset: 0x000FAFD0
		[Command]
		public void MasterChange()
		{
			this._windowedDocumentService.ShowNewDocument("MasterChangeView", new MasterChangeViewModel(base.Repair), this, null);
		}

		// Token: 0x06003F32 RID: 16178 RVA: 0x000FCDFC File Offset: 0x000FAFFC
		public bool CanMasterChange()
		{
			return OfflineData.Instance.Employee.Can(25, 0) && OfflineData.Instance.Employee.Can(60, 0);
		}

		// Token: 0x06003F33 RID: 16179 RVA: 0x000FCE34 File Offset: 0x000FB034
		[Command]
		public virtual void PrintSticker()
		{
			AdminViewModel.<PrintSticker>d__60 <PrintSticker>d__;
			<PrintSticker>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<PrintSticker>d__.<>4__this = this;
			<PrintSticker>d__.<>1__state = -1;
			<PrintSticker>d__.<>t__builder.Start<AdminViewModel.<PrintSticker>d__60>(ref <PrintSticker>d__);
		}

		// Token: 0x06003F34 RID: 16180 RVA: 0x000FCA8C File Offset: 0x000FAC8C
		public bool CanPrintSticker()
		{
			return this.CanMakeChanges();
		}

		// Token: 0x06003F35 RID: 16181 RVA: 0x000FCE6C File Offset: 0x000FB06C
		private void AutoCompleteRejectReason(int reasonId)
		{
			if (reasonId == 0)
			{
				return;
			}
			if (reasonId == 1)
			{
				base.Repair.reject_reason = Lang.t("ClientRefused2Repair");
			}
			if (reasonId == 2)
			{
				base.Repair.reject_reason = Lang.t("RepairNotPossible");
			}
		}

		// Token: 0x06003F36 RID: 16182 RVA: 0x000FCEB4 File Offset: 0x000FB0B4
		[Command]
		public void NewModelInput(object obj)
		{
			ProcessNewValueEventArgs processNewValueEventArgs = obj as ProcessNewValueEventArgs;
			if (processNewValueEventArgs == null)
			{
				return;
			}
			if (this.Models == null)
			{
				this.Models = new ObservableCollection<IdNameClass>();
			}
			this.Models.Add(new IdNameClass(0, processNewValueEventArgs.DisplayText));
		}

		// Token: 0x06003F37 RID: 16183 RVA: 0x000FCEF8 File Offset: 0x000FB0F8
		[Command]
		public void ClientChange()
		{
			this._navigationService.Navigate("ClientsView", new ClientsViewModel("selectClient"), this);
		}

		// Token: 0x06003F38 RID: 16184 RVA: 0x000FCF20 File Offset: 0x000FB120
		public void SelectCustomerFromList(ICustomer customer)
		{
			AdminViewModel.<SelectCustomerFromList>d__65 <SelectCustomerFromList>d__;
			<SelectCustomerFromList>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SelectCustomerFromList>d__.<>4__this = this;
			<SelectCustomerFromList>d__.customer = customer;
			<SelectCustomerFromList>d__.<>1__state = -1;
			<SelectCustomerFromList>d__.<>t__builder.Start<AdminViewModel.<SelectCustomerFromList>d__65>(ref <SelectCustomerFromList>d__);
		}

		// Token: 0x06003F39 RID: 16185 RVA: 0x000FCF60 File Offset: 0x000FB160
		public bool CanKkmReprintCheck()
		{
			if (base.Repair.state == 8 || base.Repair.state == 6)
			{
				if (OfflineData.Instance.Employee.KktReady())
				{
					return OfflineData.Instance.Employee.Can(16, 0);
				}
			}
			return false;
		}

		// Token: 0x06003F3A RID: 16186 RVA: 0x000887F4 File Offset: 0x000869F4
		[Command]
		public virtual void ShowPrintDocuments()
		{
			this._windowedDocumentService.ShowNewDocument("RepairDocumentsPrintView", new RepairDocumentsPrintViewModel(base.RepairId, base.Repair.cartridge == null), null, null);
		}

		// Token: 0x06003F3B RID: 16187 RVA: 0x000FCFB0 File Offset: 0x000FB1B0
		[Command]
		public void ChangeInvoice()
		{
			this._navigationService.Navigate("InvoiceView", new InvoiceViewModel(true), this);
		}

		// Token: 0x06003F3C RID: 16188 RVA: 0x000FCFD4 File Offset: 0x000FB1D4
		public bool CanChangeInvoice()
		{
			if (OfflineData.Instance.Employee.Can(65, 0))
			{
				workshop repair = base.Repair;
				return repair != null && repair.invoice != null;
			}
			return false;
		}

		// Token: 0x06003F3D RID: 16189 RVA: 0x000FD010 File Offset: 0x000FB210
		public Task SelectInvoice(int invoiceId)
		{
			AdminViewModel.<SelectInvoice>d__70 <SelectInvoice>d__;
			<SelectInvoice>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<SelectInvoice>d__.<>4__this = this;
			<SelectInvoice>d__.invoiceId = invoiceId;
			<SelectInvoice>d__.<>1__state = -1;
			<SelectInvoice>d__.<>t__builder.Start<AdminViewModel.<SelectInvoice>d__70>(ref <SelectInvoice>d__);
			return <SelectInvoice>d__.<>t__builder.Task;
		}

		// Token: 0x06003F3E RID: 16190 RVA: 0x000FD05C File Offset: 0x000FB25C
		[Command]
		public void SelectEarlyRepair()
		{
			RepairsViewModel repairsViewModel = new RepairsViewModel();
			repairsViewModel.MakeReturnOnSelect();
			this._navigationService.Navigate("RepairsView", repairsViewModel, this);
		}

		// Token: 0x06003F3F RID: 16191 RVA: 0x000F65C4 File Offset: 0x000F47C4
		public bool CanSelectEarlyRepair()
		{
			return base.Repair != null;
		}

		// Token: 0x06003F40 RID: 16192 RVA: 0x000FD088 File Offset: 0x000FB288
		public void SelectRepairFromList(WorkshopLite _repair)
		{
			AdminViewModel.<SelectRepairFromList>d__73 <SelectRepairFromList>d__;
			<SelectRepairFromList>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SelectRepairFromList>d__.<>4__this = this;
			<SelectRepairFromList>d__._repair = _repair;
			<SelectRepairFromList>d__.<>1__state = -1;
			<SelectRepairFromList>d__.<>t__builder.Start<AdminViewModel.<SelectRepairFromList>d__73>(ref <SelectRepairFromList>d__);
		}

		// Token: 0x06003F41 RID: 16193 RVA: 0x000FD0C8 File Offset: 0x000FB2C8
		[Command]
		public void ResetEarlyRepair()
		{
			base.Repair.early = null;
		}

		// Token: 0x06003F42 RID: 16194 RVA: 0x000F65C4 File Offset: 0x000F47C4
		public bool CanResetEarlyRepair()
		{
			return base.Repair != null;
		}

		// Token: 0x06003F43 RID: 16195 RVA: 0x000FD0EC File Offset: 0x000FB2EC
		[Command]
		public void SendSms()
		{
			RepairSendSmsViewModel repairSendSmsViewModel = Bootstrapper.Container.Resolve<RepairSendSmsViewModel>();
			repairSendSmsViewModel.SetParentViewModel(this);
			repairSendSmsViewModel.SetOrder(base.Repair);
			this._windowedDocumentService.ShowNewDocument("RepairSendSmsView", repairSendSmsViewModel, null, null);
		}

		// Token: 0x06003F44 RID: 16196 RVA: 0x000FD12C File Offset: 0x000FB32C
		public bool CanSendSms()
		{
			return base.Repair != null && OfflineData.Instance.Employee.Can(63, 0);
		}

		// Token: 0x06003F45 RID: 16197 RVA: 0x000FD158 File Offset: 0x000FB358
		public void SetVendor(int? vendorId)
		{
			if (base.Repair != null)
			{
				goto IL_2C;
			}
			IL_08:
			int num = -541033807;
			IL_0D:
			switch ((num ^ -1489635117) % 4)
			{
			case 0:
				goto IL_08;
			case 2:
				return;
			case 3:
				IL_2C:
				base.Repair.vendor_id = vendorId;
				num = -1242542326;
				goto IL_0D;
			}
		}

		// Token: 0x06003F46 RID: 16198 RVA: 0x0003401C File Offset: 0x0003221C
		[CompilerGenerated]
		[DebuggerHidden]
		private void <>n__0()
		{
			base.OnLoad();
		}

		// Token: 0x06003F47 RID: 16199 RVA: 0x000FD1A8 File Offset: 0x000FB3A8
		[CompilerGenerated]
		private Task<workshop> <InitCard>b__37_0()
		{
			return this._workshopService.GetRepair(base.RepairId);
		}

		// Token: 0x06003F48 RID: 16200 RVA: 0x000FD1C8 File Offset: 0x000FB3C8
		[CompilerGenerated]
		private Task <AdminChangeState>b__42_0()
		{
			return this._workshopStatusService.AdminUpdateStatus(base.Repair.id, base.Repair.new_state);
		}

		// Token: 0x06003F49 RID: 16201 RVA: 0x000FD1F8 File Offset: 0x000FB3F8
		[CompilerGenerated]
		private bool <DeviceTypeChanged>b__50_0(IDevice d)
		{
			return d.Id == base.Repair.type;
		}

		// Token: 0x04002971 RID: 10609
		[CompilerGenerated]
		private List<WorkshopOptions> <AllWorkshopOptions>k__BackingField;

		// Token: 0x04002972 RID: 10610
		[CompilerGenerated]
		private List<PaymentOptions> <PaymentOptionses>k__BackingField;

		// Token: 0x04002973 RID: 10611
		[CompilerGenerated]
		private List<IDevice> <Devices>k__BackingField;

		// Token: 0x04002974 RID: 10612
		[CompilerGenerated]
		private List<IManufacturer> <Makers>k__BackingField;

		// Token: 0x04002975 RID: 10613
		[CompilerGenerated]
		private ObservableCollection<IdNameClass> <Models>k__BackingField;

		// Token: 0x04002976 RID: 10614
		[CompilerGenerated]
		private bool <ShowUserFields>k__BackingField;

		// Token: 0x04002977 RID: 10615
		private int _rejectType;

		// Token: 0x04002978 RID: 10616
		protected readonly IToasterService _toasterService;

		// Token: 0x04002979 RID: 10617
		protected readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x0400297A RID: 10618
		private readonly IAdditionalFieldsService _additionalFieldsService;

		// Token: 0x0400297B RID: 10619
		protected IReportPrintService _reportPrintService;

		// Token: 0x0400297C RID: 10620
		private readonly IWorkshopStatusService _workshopStatusService;

		// Token: 0x02000853 RID: 2131
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnLoad>d__36 : IAsyncStateMachine
		{
			// Token: 0x06003F4A RID: 16202 RVA: 0x000FD218 File Offset: 0x000FB418
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AdminViewModel adminViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						adminViewModel.SetViewLoaded(false);
						adminViewModel.<>n__0();
						awaiter = adminViewModel.InitCard().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, AdminViewModel.<OnLoad>d__36>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
					}
					awaiter.GetResult();
					adminViewModel.MakersChanged();
					adminViewModel.SetViewLoaded(true);
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

			// Token: 0x06003F4B RID: 16203 RVA: 0x000FD2E4 File Offset: 0x000FB4E4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400297D RID: 10621
			public int <>1__state;

			// Token: 0x0400297E RID: 10622
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400297F RID: 10623
			public AdminViewModel <>4__this;

			// Token: 0x04002980 RID: 10624
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000854 RID: 2132
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <InitCard>d__37 : IAsyncStateMachine
		{
			// Token: 0x06003F4C RID: 16204 RVA: 0x000FD300 File Offset: 0x000FB500
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AdminViewModel adminViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<workshop> awaiter;
					TaskAwaiter<IEnumerable<IDevice>> awaiter2;
					TaskAwaiter<IEnumerable<IManufacturer>> awaiter3;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<workshop>);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<IEnumerable<IDevice>>);
						this.<>1__state = -1;
						goto IL_11D;
					case 2:
						awaiter3 = this.<>u__3;
						this.<>u__3 = default(TaskAwaiter<IEnumerable<IManufacturer>>);
						this.<>1__state = -1;
						goto IL_197;
					default:
						awaiter = Task.Run<workshop>(() => adminViewModel._workshopService.GetRepair(base.RepairId)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop>, AdminViewModel.<InitCard>d__37>(ref awaiter, ref this);
							return;
						}
						break;
					}
					workshop result = awaiter.GetResult();
					adminViewModel.Repair = result;
					if (adminViewModel.Repair == null)
					{
						adminViewModel._toasterService.Error("Repair not loaded");
						goto IL_1CE;
					}
					adminViewModel.Repair.new_state = adminViewModel.Repair.state;
					awaiter2 = adminViewModel._workshopService.GetActiveDevices().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<IDevice>>, AdminViewModel.<InitCard>d__37>(ref awaiter2, ref this);
						return;
					}
					IL_11D:
					IEnumerable<IDevice> result2 = awaiter2.GetResult();
					adminViewModel.Devices = new List<IDevice>(result2);
					awaiter3 = adminViewModel._workshopService.GetManufacturers(adminViewModel.Repair.type).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__3 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<IManufacturer>>, AdminViewModel.<InitCard>d__37>(ref awaiter3, ref this);
						return;
					}
					IL_197:
					IEnumerable<IManufacturer> result3 = awaiter3.GetResult();
					adminViewModel.Makers = new List<IManufacturer>(result3);
					adminViewModel.LoadUserFieldsAdmin();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_1CE:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003F4D RID: 16205 RVA: 0x000FD50C File Offset: 0x000FB70C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002981 RID: 10625
			public int <>1__state;

			// Token: 0x04002982 RID: 10626
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002983 RID: 10627
			public AdminViewModel <>4__this;

			// Token: 0x04002984 RID: 10628
			private TaskAwaiter<workshop> <>u__1;

			// Token: 0x04002985 RID: 10629
			private TaskAwaiter<IEnumerable<IDevice>> <>u__2;

			// Token: 0x04002986 RID: 10630
			private TaskAwaiter<IEnumerable<IManufacturer>> <>u__3;
		}

		// Token: 0x02000855 RID: 2133
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003F4E RID: 16206 RVA: 0x000FD528 File Offset: 0x000FB728
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003F4F RID: 16207 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06003F50 RID: 16208 RVA: 0x000FD540 File Offset: 0x000FB740
			internal bool <LoadWorkshopOptions>b__38_0(WorkshopOptions status)
			{
				return status.Id != 8;
			}

			// Token: 0x04002987 RID: 10631
			public static readonly AdminViewModel.<>c <>9 = new AdminViewModel.<>c();

			// Token: 0x04002988 RID: 10632
			public static Func<WorkshopOptions, bool> <>9__38_0;
		}

		// Token: 0x02000856 RID: 2134
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <AdminSaveChanges>d__39 : IAsyncStateMachine
		{
			// Token: 0x06003F51 RID: 16209 RVA: 0x000FD55C File Offset: 0x000FB75C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AdminViewModel adminViewModel = this.<>4__this;
				try
				{
					if (num > 1)
					{
						adminViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								goto IL_F2;
							}
							awaiter = adminViewModel._RepairModel.AdminSaveCard(adminViewModel.Repair).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num3 = 0;
								num = 0;
								this.<>1__state = num3;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, AdminViewModel.<AdminSaveChanges>d__39>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
						}
						awaiter.GetResult();
						if (adminViewModel.Repair.AdditionalFieldsEdit == null || adminViewModel.Repair.AdditionalFieldsEdit.Count <= 0)
						{
							goto IL_11B;
						}
						awaiter = adminViewModel._additionalFieldsService.UpdateAdditionalFields(adminViewModel.RepairId, adminViewModel.Repair.AdditionalFieldsEdit).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num5 = 1;
							num = 1;
							this.<>1__state = num5;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, AdminViewModel.<AdminSaveChanges>d__39>(ref awaiter, ref this);
							return;
						}
						IL_F2:
						awaiter.GetResult();
						IL_11B:
						adminViewModel.DataRefresh();
						adminViewModel.MakersChanged();
						adminViewModel.RefreshUserFields();
						adminViewModel._toasterService.Success(Lang.t("Saved"));
					}
					catch (Exception ex)
					{
						adminViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							adminViewModel.HideWait();
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

			// Token: 0x06003F52 RID: 16210 RVA: 0x000FD748 File Offset: 0x000FB948
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002989 RID: 10633
			public int <>1__state;

			// Token: 0x0400298A RID: 10634
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400298B RID: 10635
			public AdminViewModel <>4__this;

			// Token: 0x0400298C RID: 10636
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000857 RID: 2135
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <AdminChangeState>d__42 : IAsyncStateMachine
		{
			// Token: 0x06003F53 RID: 16211 RVA: 0x000FD764 File Offset: 0x000FB964
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AdminViewModel adminViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						adminViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = Task.Run(() => adminViewModel._workshopStatusService.AdminUpdateStatus(base.Repair.id, base.Repair.new_state)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, AdminViewModel.<AdminChangeState>d__42>(ref awaiter, ref this);
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
						adminViewModel.Repair.state = adminViewModel.Repair.new_state;
						Messenger.Default.Send(new Message(adminViewModel.Repair.state, MessageType.OrderStatusChanged));
						adminViewModel._toasterService.Success(Lang.t("OrderStatusUpdated"));
					}
					catch (Exception ex)
					{
						adminViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							adminViewModel.HideWait();
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

			// Token: 0x06003F54 RID: 16212 RVA: 0x000FD8B8 File Offset: 0x000FBAB8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400298D RID: 10637
			public int <>1__state;

			// Token: 0x0400298E RID: 10638
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400298F RID: 10639
			public AdminViewModel <>4__this;

			// Token: 0x04002990 RID: 10640
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000858 RID: 2136
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadModels>d__48 : IAsyncStateMachine
		{
			// Token: 0x06003F55 RID: 16213 RVA: 0x000FD8D4 File Offset: 0x000FBAD4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AdminViewModel adminViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<IdNameClass>> awaiter;
					if (num != 0)
					{
						awaiter = adminViewModel._RepairModel.GetModels(adminViewModel.Repair.maker, adminViewModel.Repair.type).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<IdNameClass>>, AdminViewModel.<LoadModels>d__48>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<IdNameClass>>);
						this.<>1__state = -1;
					}
					List<IdNameClass> result = awaiter.GetResult();
					adminViewModel.Models = new ObservableCollection<IdNameClass>(result);
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

			// Token: 0x06003F56 RID: 16214 RVA: 0x000FD9B0 File Offset: 0x000FBBB0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002991 RID: 10641
			public int <>1__state;

			// Token: 0x04002992 RID: 10642
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04002993 RID: 10643
			public AdminViewModel <>4__this;

			// Token: 0x04002994 RID: 10644
			private TaskAwaiter<List<IdNameClass>> <>u__1;
		}

		// Token: 0x02000859 RID: 2137
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadUserFieldsAdmin>d__49 : IAsyncStateMachine
		{
			// Token: 0x06003F57 RID: 16215 RVA: 0x000FD9CC File Offset: 0x000FBBCC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AdminViewModel adminViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<IAttribute>> awaiter;
					TaskAwaiter<bool> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<List<IAttribute>>);
							this.<>1__state = -1;
							goto IL_E7;
						}
						awaiter2 = adminViewModel._additionalFieldsService.AdditionalFieldsExist(false).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, AdminViewModel.<LoadUserFieldsAdmin>d__49>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<bool>);
						this.<>1__state = -1;
					}
					bool result = awaiter2.GetResult();
					adminViewModel.ShowUserFields = result;
					if (!adminViewModel.ShowUserFields)
					{
						goto IL_145;
					}
					this.<>7__wrap1 = adminViewModel.Repair;
					awaiter = adminViewModel._additionalFieldsService.GetDeviceUiFields(adminViewModel.Repair.field_values, adminViewModel.Repair.type).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<IAttribute>>, AdminViewModel.<LoadUserFieldsAdmin>d__49>(ref awaiter, ref this);
						return;
					}
					IL_E7:
					List<IAttribute> result2 = awaiter.GetResult();
					this.<>7__wrap1.AdditionalFieldsEdit = new ObservableCollection<object>(result2);
					this.<>7__wrap1 = null;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_145:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003F58 RID: 16216 RVA: 0x000FDB50 File Offset: 0x000FBD50
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002995 RID: 10645
			public int <>1__state;

			// Token: 0x04002996 RID: 10646
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04002997 RID: 10647
			public AdminViewModel <>4__this;

			// Token: 0x04002998 RID: 10648
			private TaskAwaiter<bool> <>u__1;

			// Token: 0x04002999 RID: 10649
			private workshop <>7__wrap1;

			// Token: 0x0400299A RID: 10650
			private TaskAwaiter<List<IAttribute>> <>u__2;
		}

		// Token: 0x0200085A RID: 2138
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <DeviceTypeChanged>d__50 : IAsyncStateMachine
		{
			// Token: 0x06003F59 RID: 16217 RVA: 0x000FDB6C File Offset: 0x000FBD6C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AdminViewModel adminViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<IManufacturer>> awaiter;
					if (num != 0)
					{
						List<IDevice> devices = adminViewModel.Devices;
						IDevice device = (devices != null) ? devices.FirstOrDefault((IDevice d) => d.Id == base.Repair.type) : null;
						if (device == null)
						{
							goto IL_AA;
						}
						string companyList = device.CompanyList;
						awaiter = adminViewModel._workshopService.GetManufacturers(companyList).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<IManufacturer>>, AdminViewModel.<DeviceTypeChanged>d__50>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<IManufacturer>>);
						this.<>1__state = -1;
					}
					IEnumerable<IManufacturer> result = awaiter.GetResult();
					adminViewModel.Makers = new List<IManufacturer>(result);
					IL_AA:;
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

			// Token: 0x06003F5A RID: 16218 RVA: 0x000FDC64 File Offset: 0x000FBE64
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400299B RID: 10651
			public int <>1__state;

			// Token: 0x0400299C RID: 10652
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400299D RID: 10653
			public AdminViewModel <>4__this;

			// Token: 0x0400299E RID: 10654
			private TaskAwaiter<IEnumerable<IManufacturer>> <>u__1;
		}

		// Token: 0x0200085B RID: 2139
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <RefreshUserFields>d__52 : IAsyncStateMachine
		{
			// Token: 0x06003F5B RID: 16219 RVA: 0x000FDC80 File Offset: 0x000FBE80
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AdminViewModel adminViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = adminViewModel._RepairModel.ReloadFieldValues(adminViewModel.Repair).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, AdminViewModel.<RefreshUserFields>d__52>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
					}
					awaiter.GetResult();
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

			// Token: 0x06003F5C RID: 16220 RVA: 0x000FDD40 File Offset: 0x000FBF40
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400299F RID: 10655
			public int <>1__state;

			// Token: 0x040029A0 RID: 10656
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040029A1 RID: 10657
			public AdminViewModel <>4__this;

			// Token: 0x040029A2 RID: 10658
			private TaskAwaiter <>u__1;
		}

		// Token: 0x0200085C RID: 2140
		[CompilerGenerated]
		private sealed class <>c__DisplayClass60_0
		{
			// Token: 0x06003F5D RID: 16221 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass60_0()
			{
			}

			// Token: 0x06003F5E RID: 16222 RVA: 0x000FDD5C File Offset: 0x000FBF5C
			internal Task<IRepairCard> <PrintSticker>b__0()
			{
				return RepairModel.GetRepairCard(this.<>4__this.RepairId);
			}

			// Token: 0x06003F5F RID: 16223 RVA: 0x000FDD7C File Offset: 0x000FBF7C
			internal Task<XtraReport> <PrintSticker>b__1()
			{
				return ((RepairCard)this.card).CreateReport("rep_label", 1);
			}

			// Token: 0x040029A3 RID: 10659
			public AdminViewModel <>4__this;

			// Token: 0x040029A4 RID: 10660
			public IRepairCard card;
		}

		// Token: 0x0200085D RID: 2141
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <PrintSticker>d__60 : IAsyncStateMachine
		{
			// Token: 0x06003F60 RID: 16224 RVA: 0x000FDDA0 File Offset: 0x000FBFA0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AdminViewModel adminViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<XtraReport> awaiter;
					TaskAwaiter<IRepairCard> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<XtraReport>);
							this.<>1__state = -1;
							goto IL_11B;
						}
						this.<>8__1 = new AdminViewModel.<>c__DisplayClass60_0();
						this.<>8__1.<>4__this = this.<>4__this;
						adminViewModel.ShowWait();
						awaiter2 = Task.Run<IRepairCard>(new Func<Task<IRepairCard>>(this.<>8__1.<PrintSticker>b__0)).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IRepairCard>, AdminViewModel.<PrintSticker>d__60>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IRepairCard>);
						this.<>1__state = -1;
					}
					IRepairCard result = awaiter2.GetResult();
					this.<>8__1.card = result;
					awaiter = Task.Run<XtraReport>(new Func<Task<XtraReport>>(this.<>8__1.<PrintSticker>b__1)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XtraReport>, AdminViewModel.<PrintSticker>d__60>(ref awaiter, ref this);
						return;
					}
					IL_11B:
					XtraReport result2 = awaiter.GetResult();
					adminViewModel.HideWait();
					adminViewModel._reportPrintService.PrintPreview(result2, PrinterModel.Printer.Stickers);
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

			// Token: 0x06003F61 RID: 16225 RVA: 0x000FDF3C File Offset: 0x000FC13C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040029A5 RID: 10661
			public int <>1__state;

			// Token: 0x040029A6 RID: 10662
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040029A7 RID: 10663
			public AdminViewModel <>4__this;

			// Token: 0x040029A8 RID: 10664
			private AdminViewModel.<>c__DisplayClass60_0 <>8__1;

			// Token: 0x040029A9 RID: 10665
			private TaskAwaiter<IRepairCard> <>u__1;

			// Token: 0x040029AA RID: 10666
			private TaskAwaiter<XtraReport> <>u__2;
		}

		// Token: 0x0200085E RID: 2142
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SelectCustomerFromList>d__65 : IAsyncStateMachine
		{
			// Token: 0x06003F62 RID: 16226 RVA: 0x000FDF58 File Offset: 0x000FC158
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AdminViewModel adminViewModel = this.<>4__this;
				try
				{
					if (num == 0 || this.customer != null)
					{
						try
						{
							TaskAwaiter awaiter;
							if (num != 0)
							{
								awaiter = adminViewModel._workshopService.ChangeCustomer(adminViewModel.RepairId, this.customer).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									this.<>1__state = 0;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, AdminViewModel.<SelectCustomerFromList>d__65>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter);
								this.<>1__state = -1;
							}
							awaiter.GetResult();
							adminViewModel._toasterService.Success(Lang.t("Saved"));
							adminViewModel.DataRefresh();
						}
						catch (Exception ex)
						{
							adminViewModel._toasterService.Error(ex.Message);
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

			// Token: 0x06003F63 RID: 16227 RVA: 0x000FE070 File Offset: 0x000FC270
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040029AB RID: 10667
			public int <>1__state;

			// Token: 0x040029AC RID: 10668
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040029AD RID: 10669
			public ICustomer customer;

			// Token: 0x040029AE RID: 10670
			public AdminViewModel <>4__this;

			// Token: 0x040029AF RID: 10671
			private TaskAwaiter <>u__1;
		}

		// Token: 0x0200085F RID: 2143
		[CompilerGenerated]
		private sealed class <>c__DisplayClass70_0
		{
			// Token: 0x06003F64 RID: 16228 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass70_0()
			{
			}

			// Token: 0x06003F65 RID: 16229 RVA: 0x000FE08C File Offset: 0x000FC28C
			internal Task<bool> <SelectInvoice>b__0()
			{
				return RepairModel.ChangeRepairInvoice(this.<>4__this.RepairId, this.invoice);
			}

			// Token: 0x040029B0 RID: 10672
			public AdminViewModel <>4__this;

			// Token: 0x040029B1 RID: 10673
			public Invoice invoice;
		}

		// Token: 0x02000860 RID: 2144
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SelectInvoice>d__70 : IAsyncStateMachine
		{
			// Token: 0x06003F66 RID: 16230 RVA: 0x000FE0B0 File Offset: 0x000FC2B0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AdminViewModel adminViewModel = this.<>4__this;
				try
				{
					IInvoiceService invoiceService;
					if (num > 1)
					{
						this.<>8__1 = new AdminViewModel.<>c__DisplayClass70_0();
						this.<>8__1.<>4__this = this.<>4__this;
						invoiceService = Bootstrapper.Container.Resolve<IInvoiceService>();
						adminViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter<bool> awaiter;
						TaskAwaiter<Invoice> awaiter2;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<bool>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								goto IL_FD;
							}
							awaiter2 = invoiceService.GetInvoice(this.invoiceId).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num3 = 0;
								num = 0;
								this.<>1__state = num3;
								this.<>u__1 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Invoice>, AdminViewModel.<SelectInvoice>d__70>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<Invoice>);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
						}
						Invoice result = awaiter2.GetResult();
						this.<>8__1.invoice = result;
						awaiter = Task.Run<bool>(new Func<Task<bool>>(this.<>8__1.<SelectInvoice>b__0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num5 = 1;
							num = 1;
							this.<>1__state = num5;
							this.<>u__2 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, AdminViewModel.<SelectInvoice>d__70>(ref awaiter, ref this);
							return;
						}
						IL_FD:
						awaiter.GetResult();
						adminViewModel._toasterService.Success(Lang.t("Saved"));
						adminViewModel.DataRefresh();
					}
					catch (Exception ex)
					{
						adminViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							adminViewModel.HideWait();
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
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003F67 RID: 16231 RVA: 0x000FE2AC File Offset: 0x000FC4AC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040029B2 RID: 10674
			public int <>1__state;

			// Token: 0x040029B3 RID: 10675
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040029B4 RID: 10676
			public AdminViewModel <>4__this;

			// Token: 0x040029B5 RID: 10677
			public int invoiceId;

			// Token: 0x040029B6 RID: 10678
			private AdminViewModel.<>c__DisplayClass70_0 <>8__1;

			// Token: 0x040029B7 RID: 10679
			private TaskAwaiter<Invoice> <>u__1;

			// Token: 0x040029B8 RID: 10680
			private TaskAwaiter<bool> <>u__2;
		}

		// Token: 0x02000861 RID: 2145
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SelectRepairFromList>d__73 : IAsyncStateMachine
		{
			// Token: 0x06003F68 RID: 16232 RVA: 0x000FE2C8 File Offset: 0x000FC4C8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AdminViewModel adminViewModel = this.<>4__this;
				try
				{
					if (num == 0 || this._repair != null)
					{
						try
						{
							TaskAwaiter awaiter;
							if (num != 0)
							{
								adminViewModel.Repair.early = new int?(this._repair.RepairId);
								awaiter = adminViewModel._RepairModel.AdminSaveCard(adminViewModel.Repair).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									this.<>1__state = 0;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, AdminViewModel.<SelectRepairFromList>d__73>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter);
								this.<>1__state = -1;
							}
							awaiter.GetResult();
							adminViewModel._toasterService.Success(Lang.t("EarlyRepairUpdated"));
						}
						catch (Exception ex)
						{
							adminViewModel._toasterService.Error(ex.Message);
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

			// Token: 0x06003F69 RID: 16233 RVA: 0x000FE3EC File Offset: 0x000FC5EC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040029B9 RID: 10681
			public int <>1__state;

			// Token: 0x040029BA RID: 10682
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040029BB RID: 10683
			public WorkshopLite _repair;

			// Token: 0x040029BC RID: 10684
			public AdminViewModel <>4__this;

			// Token: 0x040029BD RID: 10685
			private TaskAwaiter <>u__1;
		}
	}
}
