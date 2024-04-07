using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using ASC.Common.Interfaces;
using ASC.Common.SimpleClasses;
using ASC.Interfaces;
using ASC.Invoice;
using ASC.Models;
using ASC.Objects;
using ASC.Options;
using ASC.PKO;
using ASC.Properties;
using ASC.RepairCard.WorksAndParts;
using ASC.RequestsManager;
using ASC.Services.Abstract;
using ASC.TaskManager;
using ASC.View;
using ASC.ViewModel;
using ASC.ViewModels;
using Autofac;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;

namespace ASC.RepairCard
{
	// Token: 0x02000816 RID: 2070
	public class RepairCardViewModel : RepairCardCommonView, ICard, ICashOrderSelect, IRefreshable
	{
		// Token: 0x170010BA RID: 4282
		// (get) Token: 0x06003DB1 RID: 15793 RVA: 0x000F570C File Offset: 0x000F390C
		// (set) Token: 0x06003DB2 RID: 15794 RVA: 0x000F5720 File Offset: 0x000F3920
		public Dictionary<int, string> InformStatuses
		{
			[CompilerGenerated]
			get
			{
				return this.<InformStatuses>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<InformStatuses>k__BackingField, value))
				{
					return;
				}
				this.<InformStatuses>k__BackingField = value;
				this.RaisePropertyChanged("InformStatuses");
			}
		}

		// Token: 0x170010BB RID: 4283
		// (get) Token: 0x06003DB3 RID: 15795 RVA: 0x000F5750 File Offset: 0x000F3950
		// (set) Token: 0x06003DB4 RID: 15796 RVA: 0x000F5764 File Offset: 0x000F3964
		public List<KeyValuePair<string, string>> Info
		{
			[CompilerGenerated]
			get
			{
				return this.<Info>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Info>k__BackingField, value))
				{
					return;
				}
				this.<Info>k__BackingField = value;
				this.RaisePropertyChanged("Info");
			}
		}

		// Token: 0x170010BC RID: 4284
		// (get) Token: 0x06003DB5 RID: 15797 RVA: 0x000F5794 File Offset: 0x000F3994
		// (set) Token: 0x06003DB6 RID: 15798 RVA: 0x000F57D8 File Offset: 0x000F39D8
		public bool ShowBoxes
		{
			get
			{
				return base.GetProperty<bool>(() => this.ShowBoxes);
			}
			private set
			{
				if (this.ShowBoxes != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = 1516016391;
				IL_10:
				switch ((num ^ 1952949021) % 4)
				{
				case 1:
					IL_2F:
					base.SetProperty<bool>(() => this.ShowBoxes, value);
					this.RaisePropertyChanged("ShowBoxes");
					num = 827348161;
					goto IL_10;
				case 2:
					return;
				case 3:
					goto IL_0B;
				}
			}
		}

		// Token: 0x170010BD RID: 4285
		// (get) Token: 0x06003DB7 RID: 15799 RVA: 0x000F5860 File Offset: 0x000F3A60
		public bool ShowWarrantySn
		{
			get
			{
				return Auth.User.offices1.warranty_sn;
			}
		}

		// Token: 0x170010BE RID: 4286
		// (get) Token: 0x06003DB8 RID: 15800 RVA: 0x000F587C File Offset: 0x000F3A7C
		// (set) Token: 0x06003DB9 RID: 15801 RVA: 0x000F5890 File Offset: 0x000F3A90
		public decimal FinalAmount
		{
			[CompilerGenerated]
			get
			{
				return this.<FinalAmount>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!decimal.Equals(this.<FinalAmount>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1185794474;
				IL_13:
				switch ((num ^ 1376282285) % 4)
				{
				case 0:
					goto IL_0E;
				case 2:
					IL_32:
					this.<FinalAmount>k__BackingField = value;
					this.RaisePropertyChanged("FinalAmount");
					num = 1955159180;
					goto IL_13;
				case 3:
					return;
				}
			}
		}

		// Token: 0x170010BF RID: 4287
		// (get) Token: 0x06003DBA RID: 15802 RVA: 0x000F58EC File Offset: 0x000F3AEC
		// (set) Token: 0x06003DBB RID: 15803 RVA: 0x000F5900 File Offset: 0x000F3B00
		public double CloseCardProgress
		{
			[CompilerGenerated]
			get
			{
				return this.<CloseCardProgress>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!(this.<CloseCardProgress>k__BackingField == value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1022598088;
				IL_13:
				switch ((num ^ -1389920831) % 4)
				{
				case 1:
					return;
				case 2:
					IL_32:
					num = -590669395;
					goto IL_13;
				case 3:
					goto IL_0E;
				}
				this.<CloseCardProgress>k__BackingField = value;
				this.RaisePropertyChanged("CloseCardProgress");
			}
		}

		// Token: 0x170010C0 RID: 4288
		// (get) Token: 0x06003DBC RID: 15804 RVA: 0x000F595C File Offset: 0x000F3B5C
		// (set) Token: 0x06003DBD RID: 15805 RVA: 0x000F5970 File Offset: 0x000F3B70
		public WpViewModel WP
		{
			[CompilerGenerated]
			get
			{
				return this.<WP>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<WP>k__BackingField, value))
				{
					return;
				}
				this.<WP>k__BackingField = value;
				this.RaisePropertyChanged("WP");
			}
		}

		// Token: 0x170010C1 RID: 4289
		// (get) Token: 0x06003DBE RID: 15806 RVA: 0x000F59A0 File Offset: 0x000F3BA0
		// (set) Token: 0x06003DBF RID: 15807 RVA: 0x000F59B4 File Offset: 0x000F3BB4
		public ObservableCollection<parts_request> PartRequests
		{
			[CompilerGenerated]
			get
			{
				return this.<PartRequests>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<PartRequests>k__BackingField, value))
				{
					return;
				}
				this.<PartRequests>k__BackingField = value;
				this.RaisePropertyChanged("PartRequests");
			}
		}

		// Token: 0x170010C2 RID: 4290
		// (get) Token: 0x06003DC0 RID: 15808 RVA: 0x000F59E4 File Offset: 0x000F3BE4
		// (set) Token: 0x06003DC1 RID: 15809 RVA: 0x000F59F8 File Offset: 0x000F3BF8
		public parts_request SelectedPartRequest
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedPartRequest>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<SelectedPartRequest>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1224797497;
				IL_13:
				switch ((num ^ 1304649592) % 4)
				{
				case 1:
					return;
				case 2:
					IL_32:
					this.<SelectedPartRequest>k__BackingField = value;
					this.RaisePropertyChanged("SelectedPartRequest");
					num = 1316437784;
					goto IL_13;
				case 3:
					goto IL_0E;
				}
			}
		}

		// Token: 0x170010C3 RID: 4291
		// (get) Token: 0x06003DC2 RID: 15810 RVA: 0x000F5A54 File Offset: 0x000F3C54
		public Visibility CloseProgressVisibility
		{
			get
			{
				if (Auth.Config.card_close_time != 0)
				{
					return Visibility.Visible;
				}
				return Visibility.Collapsed;
			}
		}

		// Token: 0x06003DC3 RID: 15811 RVA: 0x000F5A70 File Offset: 0x000F3C70
		private bool EmployeeIsManager()
		{
			return Auth.User.id == base.Repair.current_manager;
		}

		// Token: 0x06003DC4 RID: 15812 RVA: 0x000F5A94 File Offset: 0x000F3C94
		private bool EmployeeIsMaster()
		{
			return base.Repair.master != null && Auth.User.id == base.Repair.master.Value;
		}

		// Token: 0x06003DC5 RID: 15813 RVA: 0x000F5AD8 File Offset: 0x000F3CD8
		public virtual void RefreshCommands()
		{
			base.RaiseCanExecuteChanged(() => this.SaveDiagResult());
			base.RaiseCanExecuteChanged(() => this.DiagnosticLostFocus());
			base.RaiseCanExecuteChanged(() => this.CloseDebt());
		}

		// Token: 0x170010C4 RID: 4292
		// (get) Token: 0x06003DC6 RID: 15814 RVA: 0x000F5B98 File Offset: 0x000F3D98
		// (set) Token: 0x06003DC7 RID: 15815 RVA: 0x000F5BAC File Offset: 0x000F3DAC
		public bool ActionSuccess
		{
			[CompilerGenerated]
			get
			{
				return this.<ActionSuccess>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ActionSuccess>k__BackingField == value)
				{
					return;
				}
				this.<ActionSuccess>k__BackingField = value;
				this.RaisePropertyChanged("ActionSuccess");
			}
		}

		// Token: 0x170010C5 RID: 4293
		// (get) Token: 0x06003DC8 RID: 15816 RVA: 0x000F5BD8 File Offset: 0x000F3DD8
		// (set) Token: 0x06003DC9 RID: 15817 RVA: 0x000F5BEC File Offset: 0x000F3DEC
		public bool UserIsManager
		{
			[CompilerGenerated]
			get
			{
				return this.<UserIsManager>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<UserIsManager>k__BackingField == value)
				{
					return;
				}
				this.<UserIsManager>k__BackingField = value;
				this.RaisePropertyChanged("UserIsManager");
			}
		}

		// Token: 0x170010C6 RID: 4294
		// (get) Token: 0x06003DCA RID: 15818 RVA: 0x000F5C18 File Offset: 0x000F3E18
		// (set) Token: 0x06003DCB RID: 15819 RVA: 0x000F5C2C File Offset: 0x000F3E2C
		public bool WorkPartsVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<WorkPartsVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<WorkPartsVisible>k__BackingField == value)
				{
					return;
				}
				this.<WorkPartsVisible>k__BackingField = value;
				this.RaisePropertyChanged("WorkPartsVisible");
			}
		}

		// Token: 0x170010C7 RID: 4295
		// (get) Token: 0x06003DCC RID: 15820 RVA: 0x000F5C58 File Offset: 0x000F3E58
		// (set) Token: 0x06003DCD RID: 15821 RVA: 0x000F5C6C File Offset: 0x000F3E6C
		public RepairCardLayoutVisibility LayoutVisibility
		{
			[CompilerGenerated]
			get
			{
				return this.<LayoutVisibility>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<LayoutVisibility>k__BackingField, value))
				{
					return;
				}
				this.<LayoutVisibility>k__BackingField = value;
				this.RaisePropertyChanged("LayoutVisibility");
			}
		}

		// Token: 0x06003DCE RID: 15822 RVA: 0x000F5C9C File Offset: 0x000F3E9C
		public RepairCardViewModel()
		{
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
			this._ascMessageBoxService = Bootstrapper.Container.Resolve<IAscMessageBoxService>();
			this._additionalFieldsService = Bootstrapper.Container.Resolve<IAdditionalFieldsService>();
			this._partsRequestService = Bootstrapper.Container.Resolve<IPartsRequestService>();
			this.StatusViewModel = new StatusViewModel(this, this._RepairModel);
			this.StatusViewModel.SetParentViewModel(this);
			this.LayoutVisibility = new RepairCardLayoutVisibility(this);
			this.InformStatuses = ClientInformOptions.GetAllOptions();
			Messenger.Default.Register(this, new Action<Message>(this.OnMessage));
		}

		// Token: 0x06003DCF RID: 15823 RVA: 0x000F5D64 File Offset: 0x000F3F64
		public RepairCardViewModel(int repairId) : this()
		{
			this.SetViewName("Repair", repairId);
			base.RepairId = repairId;
			base.InitLockCard(base.RepairId);
		}

		// Token: 0x06003DD0 RID: 15824 RVA: 0x000F5D98 File Offset: 0x000F3F98
		private void OnMessage(Message message)
		{
			if (message.MessageType == MessageType.OrderStatusChanged)
			{
				Application.Current.Dispatcher.BeginInvoke(new Action(delegate()
				{
					try
					{
						this.LayoutVisibility.DefaultLayoutVisibility(base.Repair.state);
						base.RaisePropertyChanged<workshop>(() => this.Repair);
						base.RaiseCanExecuteChanged(() => this.SetClientInformedStatus());
					}
					catch (Exception)
					{
					}
				}), new object[0]);
			}
		}

		// Token: 0x06003DD1 RID: 15825 RVA: 0x000F5DD0 File Offset: 0x000F3FD0
		public bool IsUnlockedAndSameOffice()
		{
			return base.Repair != null && (base.Repair.office == Auth.User.office || OfflineData.Instance.Employee.Can(74, 0)) && !this.LockCardModel.IsRepairCardLocked();
		}

		// Token: 0x06003DD2 RID: 15826 RVA: 0x000F5E24 File Offset: 0x000F4024
		[Command]
		public void SetClientInformedStatus()
		{
			RepairCardViewModel.<SetClientInformedStatus>d__63 <SetClientInformedStatus>d__;
			<SetClientInformedStatus>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SetClientInformedStatus>d__.<>4__this = this;
			<SetClientInformedStatus>d__.<>1__state = -1;
			<SetClientInformedStatus>d__.<>t__builder.Start<RepairCardViewModel.<SetClientInformedStatus>d__63>(ref <SetClientInformedStatus>d__);
		}

		// Token: 0x06003DD3 RID: 15827 RVA: 0x000F5E5C File Offset: 0x000F405C
		public bool CanSetClientInformedStatus()
		{
			return base.Repair != null && base.Repair.state > 0 && OfflineData.Instance.Employee.Can(55, 0) && this.IsUnlockedAndSameOffice();
		}

		// Token: 0x06003DD4 RID: 15828 RVA: 0x000F5EA0 File Offset: 0x000F40A0
		[Command]
		public void SaveWarrantyLabel()
		{
			RepairCardViewModel.<SaveWarrantyLabel>d__65 <SaveWarrantyLabel>d__;
			<SaveWarrantyLabel>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SaveWarrantyLabel>d__.<>4__this = this;
			<SaveWarrantyLabel>d__.<>1__state = -1;
			<SaveWarrantyLabel>d__.<>t__builder.Start<RepairCardViewModel.<SaveWarrantyLabel>d__65>(ref <SaveWarrantyLabel>d__);
		}

		// Token: 0x06003DD5 RID: 15829 RVA: 0x000F5ED8 File Offset: 0x000F40D8
		[Command]
		public void SaveDiagResult()
		{
			RepairCardViewModel.<SaveDiagResult>d__66 <SaveDiagResult>d__;
			<SaveDiagResult>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SaveDiagResult>d__.<>4__this = this;
			<SaveDiagResult>d__.<>1__state = -1;
			<SaveDiagResult>d__.<>t__builder.Start<RepairCardViewModel.<SaveDiagResult>d__66>(ref <SaveDiagResult>d__);
		}

		// Token: 0x06003DD6 RID: 15830 RVA: 0x000F5F10 File Offset: 0x000F4110
		public bool CanSaveDiagResult()
		{
			if (base.Repair == null || !this.IsUnlockedAndSameOffice())
			{
				return false;
			}
			if (OfflineData.Instance.Employee.Can(25, 0))
			{
				return true;
			}
			if (base.Repair.state == 1 && this.EmployeeIsMaster())
			{
				return true;
			}
			if (base.Repair.state == 13)
			{
				if (this.EmployeeIsManager())
				{
					return true;
				}
			}
			return this._workshopOptions.CanDiagnosticEdit(base.Repair.state);
		}

		// Token: 0x06003DD7 RID: 15831 RVA: 0x000F5F94 File Offset: 0x000F4194
		private void LoadUserFieldsCommonTab()
		{
			base.Repair.AdditionalFields = new ObservableCollection<object>(this._additionalFieldsService.GetDeviceAttributesReadonly(base.Repair.field_values));
		}

		// Token: 0x06003DD8 RID: 15832 RVA: 0x000F5FC8 File Offset: 0x000F41C8
		public Task CountRepairCost()
		{
			RepairCardViewModel.<CountRepairCost>d__69 <CountRepairCost>d__;
			<CountRepairCost>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<CountRepairCost>d__.<>4__this = this;
			<CountRepairCost>d__.<>1__state = -1;
			<CountRepairCost>d__.<>t__builder.Start<RepairCardViewModel.<CountRepairCost>d__69>(ref <CountRepairCost>d__);
			return <CountRepairCost>d__.<>t__builder.Task;
		}

		// Token: 0x06003DD9 RID: 15833 RVA: 0x000F600C File Offset: 0x000F420C
		private void UpdateBoxesVisibility(int repairCurrentOfficeId)
		{
			offices offices = OfflineData.Instance.Offices.FirstOrDefault((offices i) => i.id == repairCurrentOfficeId);
			if (offices != null)
			{
				this.ShowBoxes = offices.use_boxes;
			}
		}

		// Token: 0x06003DDA RID: 15834 RVA: 0x000F6054 File Offset: 0x000F4254
		private Task LoadRepair()
		{
			RepairCardViewModel.<LoadRepair>d__71 <LoadRepair>d__;
			<LoadRepair>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadRepair>d__.<>4__this = this;
			<LoadRepair>d__.<>1__state = -1;
			<LoadRepair>d__.<>t__builder.Start<RepairCardViewModel.<LoadRepair>d__71>(ref <LoadRepair>d__);
			return <LoadRepair>d__.<>t__builder.Task;
		}

		// Token: 0x06003DDB RID: 15835 RVA: 0x000F6098 File Offset: 0x000F4298
		public Task InitCard()
		{
			RepairCardViewModel.<InitCard>d__72 <InitCard>d__;
			<InitCard>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<InitCard>d__.<>4__this = this;
			<InitCard>d__.<>1__state = -1;
			<InitCard>d__.<>t__builder.Start<RepairCardViewModel.<InitCard>d__72>(ref <InitCard>d__);
			return <InitCard>d__.<>t__builder.Task;
		}

		// Token: 0x06003DDC RID: 15836 RVA: 0x000F60DC File Offset: 0x000F42DC
		[Command]
		public void MasterChange()
		{
			this._windowedDocumentService.ShowNewDocument("MasterChangeView", new MasterChangeViewModel(base.Repair), null, null);
		}

		// Token: 0x06003DDD RID: 15837 RVA: 0x000F6108 File Offset: 0x000F4308
		public bool CanMasterChange()
		{
			return OfflineData.Instance.Employee.Can(60, 0);
		}

		// Token: 0x06003DDE RID: 15838 RVA: 0x000F6128 File Offset: 0x000F4328
		[Command]
		public void ManagerChange()
		{
			this._windowedDocumentService.ShowNewDocument("ManagerChangeView", new ManagerChangeViewModel(base.Repair), null, null);
		}

		// Token: 0x06003DDF RID: 15839 RVA: 0x000F6154 File Offset: 0x000F4354
		public bool CanManagerChange()
		{
			return OfflineData.Instance.Employee.Can(76, 0);
		}

		// Token: 0x06003DE0 RID: 15840 RVA: 0x000F6174 File Offset: 0x000F4374
		[Command]
		public void OfficeChange()
		{
			this._windowedDocumentService.ShowNewDocument("OfficeChangeView", new OfficeChangeViewModel(base.Repair), null, null);
		}

		// Token: 0x06003DE1 RID: 15841 RVA: 0x000F61A0 File Offset: 0x000F43A0
		public bool CanOfficeChange()
		{
			return base.Repair != null && OfflineData.Instance.Employee.Can(72, 0);
		}

		// Token: 0x06003DE2 RID: 15842 RVA: 0x000F61CC File Offset: 0x000F43CC
		[Command]
		public void SaveColor()
		{
			RepairCardViewModel.<SaveColor>d__79 <SaveColor>d__;
			<SaveColor>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SaveColor>d__.<>4__this = this;
			<SaveColor>d__.<>1__state = -1;
			<SaveColor>d__.<>t__builder.Start<RepairCardViewModel.<SaveColor>d__79>(ref <SaveColor>d__);
		}

		// Token: 0x06003DE3 RID: 15843 RVA: 0x000F6204 File Offset: 0x000F4404
		public bool CanSaveColor()
		{
			return base.Repair != null && OfflineData.Instance.Employee.Can(61, 0);
		}

		// Token: 0x06003DE4 RID: 15844 RVA: 0x000F6230 File Offset: 0x000F4430
		[Command]
		public void CloseDebt()
		{
			RepairCardViewModel.<CloseDebt>d__81 <CloseDebt>d__;
			<CloseDebt>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<CloseDebt>d__.<>4__this = this;
			<CloseDebt>d__.<>1__state = -1;
			<CloseDebt>d__.<>t__builder.Start<RepairCardViewModel.<CloseDebt>d__81>(ref <CloseDebt>d__);
		}

		// Token: 0x06003DE5 RID: 15845 RVA: 0x000F6268 File Offset: 0x000F4468
		public bool CanCloseDebt()
		{
			if (base.Repair != null)
			{
				if (base.Repair.state == 16)
				{
					return OfflineData.Instance.Employee.Can(16, 0);
				}
			}
			return false;
		}

		// Token: 0x06003DE6 RID: 15846 RVA: 0x000F62A4 File Offset: 0x000F44A4
		[Command]
		public void OpenEarlyRepair()
		{
			this._navigationService.NavigateRepairCard(base.Repair.early.Value);
		}

		// Token: 0x06003DE7 RID: 15847 RVA: 0x000F62D0 File Offset: 0x000F44D0
		public bool CanOpenEarlyRepair()
		{
			workshop repair = base.Repair;
			return repair != null && repair.early != null;
		}

		// Token: 0x06003DE8 RID: 15848 RVA: 0x000F62F8 File Offset: 0x000F44F8
		public void RefreshFielsd()
		{
			if (base.Repair != null)
			{
				base.RaisePropertyChanged<int>(() => this.Repair.state);
			}
		}

		// Token: 0x06003DE9 RID: 15849 RVA: 0x000F6358 File Offset: 0x000F4558
		[Command]
		public void ShowIssuingMessage()
		{
			this._windowedDocumentService.ShowNewDocument("IssuingMessageView", this, null, null);
		}

		// Token: 0x06003DEA RID: 15850 RVA: 0x000F6378 File Offset: 0x000F4578
		[Command]
		public void SaveIssuingMessage(object obj)
		{
			RepairCardViewModel.<SaveIssuingMessage>d__87 <SaveIssuingMessage>d__;
			<SaveIssuingMessage>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SaveIssuingMessage>d__.<>4__this = this;
			<SaveIssuingMessage>d__.<>1__state = -1;
			<SaveIssuingMessage>d__.<>t__builder.Start<RepairCardViewModel.<SaveIssuingMessage>d__87>(ref <SaveIssuingMessage>d__);
		}

		// Token: 0x06003DEB RID: 15851 RVA: 0x000F63B0 File Offset: 0x000F45B0
		[Command]
		public void CloseIssuingMessage()
		{
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x06003DEC RID: 15852 RVA: 0x000F63C8 File Offset: 0x000F45C8
		[Command]
		public void Prepaid()
		{
			this._navigationService.Navigate("PkoView", new PkoViewModel(base.Repair, Kassa.Types.partsPrePayment, false, true));
		}

		// Token: 0x06003DED RID: 15853 RVA: 0x000F63F4 File Offset: 0x000F45F4
		public bool CanPrepaid()
		{
			return OfflineData.Instance.Employee.Can(16, 0) && base.Repair != null && base.Repair.state != 8 && base.Repair.state != 12;
		}

		// Token: 0x06003DEE RID: 15854 RVA: 0x000F6440 File Offset: 0x000F4640
		[Command]
		public void OpenInvoice()
		{
			this._navigationService.NavigateInvoice(base.Repair.invoice.Value);
		}

		// Token: 0x06003DEF RID: 15855 RVA: 0x000F646C File Offset: 0x000F466C
		public bool CanOpenInvoice()
		{
			return base.Repair != null && base.Repair.invoice != null && OfflineData.Instance.Employee.Can(65, 0);
		}

		// Token: 0x06003DF0 RID: 15856 RVA: 0x000F64AC File Offset: 0x000F46AC
		public override void OnLoad()
		{
			RepairCardViewModel.<OnLoad>d__93 <OnLoad>d__;
			<OnLoad>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnLoad>d__.<>4__this = this;
			<OnLoad>d__.<>1__state = -1;
			<OnLoad>d__.<>t__builder.Start<RepairCardViewModel.<OnLoad>d__93>(ref <OnLoad>d__);
		}

		// Token: 0x06003DF1 RID: 15857 RVA: 0x000F64E4 File Offset: 0x000F46E4
		public override void OnUnload()
		{
			base.OnUnload();
			if (this.DiagnosticResultChanged())
			{
				this.SaveDiagResult();
			}
			this.LockCardModel.Unlock();
			Settings.Default.Save();
		}

		// Token: 0x06003DF2 RID: 15858 RVA: 0x000F651C File Offset: 0x000F471C
		[Command]
		public void CreateInvoice()
		{
			this._navigationService.Navigate("NewInvoiceView", new NewInvoiceViewModel(new List<workshop>
			{
				base.Repair
			}, base.Repair.client));
		}

		// Token: 0x06003DF3 RID: 15859 RVA: 0x000F655C File Offset: 0x000F475C
		public bool CanCreateInvoice()
		{
			return base.Repair != null && base.Repair.invoice == null && OfflineData.Instance.Employee.Can(65, 0);
		}

		// Token: 0x06003DF4 RID: 15860 RVA: 0x000F659C File Offset: 0x000F479C
		[Command]
		public void NavigateTaskCreate()
		{
			this._navigationService.Navigate("EmployeeTaskView", new EmployeeTaskViewModel(base.Repair));
		}

		// Token: 0x06003DF5 RID: 15861 RVA: 0x000F65C4 File Offset: 0x000F47C4
		public bool CanNavigateTaskCreate()
		{
			return base.Repair != null;
		}

		// Token: 0x06003DF6 RID: 15862 RVA: 0x000F65DC File Offset: 0x000F47DC
		[Command]
		public void ShowIssue()
		{
			if (!base.IsValid())
			{
				this._toasterService.Error(Lang.t("LicenseNotValid"));
				return;
			}
			this._windowedDocumentService.ShowNewDocument("IssueRepairView", new IssueRepairViewModel(base.RepairId), this, null);
		}

		// Token: 0x06003DF7 RID: 15863 RVA: 0x000F6624 File Offset: 0x000F4824
		public bool CanShowIssue()
		{
			return base.Repair != null && (this.IsUnlockedAndSameOffice() && OfflineData.Instance.Employee.Can(4, 0)) && (base.Repair.state == 6 || base.Repair.state == 7);
		}

		// Token: 0x06003DF8 RID: 15864 RVA: 0x000F6678 File Offset: 0x000F4878
		public void DataRefresh()
		{
			RepairCardViewModel.<DataRefresh>d__101 <DataRefresh>d__;
			<DataRefresh>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<DataRefresh>d__.<>4__this = this;
			<DataRefresh>d__.<>1__state = -1;
			<DataRefresh>d__.<>t__builder.Start<RepairCardViewModel.<DataRefresh>d__101>(ref <DataRefresh>d__);
		}

		// Token: 0x170010C8 RID: 4296
		// (get) Token: 0x06003DF9 RID: 15865 RVA: 0x000F66B0 File Offset: 0x000F48B0
		// (set) Token: 0x06003DFA RID: 15866 RVA: 0x000F66C4 File Offset: 0x000F48C4
		public IStatusViewModel StatusViewModel
		{
			[CompilerGenerated]
			get
			{
				return this.<StatusViewModel>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<StatusViewModel>k__BackingField, value))
				{
					return;
				}
				this.<StatusViewModel>k__BackingField = value;
				this.RaisePropertyChanged("StatusViewModel");
			}
		}

		// Token: 0x06003DFB RID: 15867 RVA: 0x000F66F4 File Offset: 0x000F48F4
		public void SelectCashOrder(ICashOrder order)
		{
			this._cashOrderId = order.Id;
			if (this.CanShowIssue())
			{
				this.ShowIssue();
			}
		}

		// Token: 0x06003DFC RID: 15868 RVA: 0x000F671C File Offset: 0x000F491C
		[Command]
		public void DiagnosticLostFocus()
		{
			if (this.DiagnosticResultChanged())
			{
				this.SaveDiagResult();
			}
			this._diagnosticOriginal = base.Repair.diagnostic_result;
		}

		// Token: 0x06003DFD RID: 15869 RVA: 0x000F6748 File Offset: 0x000F4948
		private bool DiagnosticResultChanged()
		{
			return this._diagnosticOriginal != base.Repair.diagnostic_result;
		}

		// Token: 0x06003DFE RID: 15870 RVA: 0x000F676C File Offset: 0x000F496C
		public bool CanDiagnosticLostFocus()
		{
			return this.CanSaveDiagResult();
		}

		// Token: 0x06003DFF RID: 15871 RVA: 0x000F6780 File Offset: 0x000F4980
		[Command]
		public void AutoMasterAssign()
		{
			this._windowedDocumentService.ShowNewDocument(typeof(AutoMasterAssignView).FullName, new AutoMasterAssignViewModel(base.Repair.id), null, null);
		}

		// Token: 0x06003E00 RID: 15872 RVA: 0x000F67BC File Offset: 0x000F49BC
		public bool CanAutoMasterAssign()
		{
			return base.Repair != null && base.Repair.state == 0 && OfflineData.Instance.Settings.AutoMasterAssign && OfflineData.Instance.Employee.Can(25, 0);
		}

		// Token: 0x06003E01 RID: 15873 RVA: 0x000F6804 File Offset: 0x000F4A04
		[Command]
		public void RequestDoubleClick()
		{
			this._navigationService.Navigate(typeof(RequestCardView).FullName, new RequestCardViewModel(this.SelectedPartRequest.id));
		}

		// Token: 0x06003E02 RID: 15874 RVA: 0x000F683C File Offset: 0x000F4A3C
		public bool CanRequestDoubleClick()
		{
			return this.SelectedPartRequest != null;
		}

		// Token: 0x170010C9 RID: 4297
		// (get) Token: 0x06003E03 RID: 15875 RVA: 0x000F6854 File Offset: 0x000F4A54
		// (set) Token: 0x06003E04 RID: 15876 RVA: 0x000F6868 File Offset: 0x000F4A68
		public Dictionary<int, string> PartRequestStatuses
		{
			[CompilerGenerated]
			get
			{
				return this.<PartRequestStatuses>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<PartRequestStatuses>k__BackingField, value))
				{
					return;
				}
				this.<PartRequestStatuses>k__BackingField = value;
				this.RaisePropertyChanged("PartRequestStatuses");
			}
		}

		// Token: 0x06003E05 RID: 15877 RVA: 0x000F6898 File Offset: 0x000F4A98
		[CompilerGenerated]
		private void <OnMessage>b__61_0()
		{
			try
			{
				this.LayoutVisibility.DefaultLayoutVisibility(base.Repair.state);
				base.RaisePropertyChanged<workshop>(() => this.Repair);
				base.RaiseCanExecuteChanged(() => this.SetClientInformedStatus());
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06003E06 RID: 15878 RVA: 0x000F6940 File Offset: 0x000F4B40
		[CompilerGenerated]
		private Task <SetClientInformedStatus>b__63_0()
		{
			return this._workshopService.UpdateInformStatus(base.Repair.id, base.Repair.informed_status);
		}

		// Token: 0x06003E07 RID: 15879 RVA: 0x000F6970 File Offset: 0x000F4B70
		[CompilerGenerated]
		private Task <SaveWarrantyLabel>b__65_0()
		{
			return this._workshopService.SaveWarrantyLabel(base.RepairId, base.Repair.warranty_label);
		}

		// Token: 0x06003E08 RID: 15880 RVA: 0x000F699C File Offset: 0x000F4B9C
		[CompilerGenerated]
		private Task <SaveDiagResult>b__66_0()
		{
			return this._workshopService.UpdateDiagnosticResult(base.Repair);
		}

		// Token: 0x06003E09 RID: 15881 RVA: 0x000F69BC File Offset: 0x000F4BBC
		[CompilerGenerated]
		private Task <InitCard>b__72_0()
		{
			return this.LoadRepair();
		}

		// Token: 0x06003E0A RID: 15882 RVA: 0x000F69D0 File Offset: 0x000F4BD0
		[CompilerGenerated]
		private Task <SaveColor>b__79_0()
		{
			return this._workshopService.SetRepairColor(base.RepairId, base.Repair.color);
		}

		// Token: 0x06003E0B RID: 15883 RVA: 0x000F69FC File Offset: 0x000F4BFC
		[CompilerGenerated]
		private Task <SaveIssuingMessage>b__87_0()
		{
			return this._workshopService.SaveIssuingMessage(base.RepairId, base.Repair.issued_msg);
		}

		// Token: 0x06003E0C RID: 15884 RVA: 0x0003401C File Offset: 0x0003221C
		[CompilerGenerated]
		[DebuggerHidden]
		private void <>n__0()
		{
			base.OnLoad();
		}

		// Token: 0x04002858 RID: 10328
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04002859 RID: 10329
		private readonly IAscMessageBoxService _ascMessageBoxService;

		// Token: 0x0400285A RID: 10330
		private readonly IToasterService _toasterService;

		// Token: 0x0400285B RID: 10331
		private readonly IAdditionalFieldsService _additionalFieldsService;

		// Token: 0x0400285C RID: 10332
		public WorkshopOptions _workshopOptions = new WorkshopOptions();

		// Token: 0x0400285D RID: 10333
		[CompilerGenerated]
		private Dictionary<int, string> <InformStatuses>k__BackingField;

		// Token: 0x0400285E RID: 10334
		[CompilerGenerated]
		private List<KeyValuePair<string, string>> <Info>k__BackingField;

		// Token: 0x0400285F RID: 10335
		[CompilerGenerated]
		private decimal <FinalAmount>k__BackingField;

		// Token: 0x04002860 RID: 10336
		[CompilerGenerated]
		private double <CloseCardProgress>k__BackingField;

		// Token: 0x04002861 RID: 10337
		[CompilerGenerated]
		private WpViewModel <WP>k__BackingField;

		// Token: 0x04002862 RID: 10338
		[CompilerGenerated]
		private ObservableCollection<parts_request> <PartRequests>k__BackingField = new ObservableCollection<parts_request>();

		// Token: 0x04002863 RID: 10339
		[CompilerGenerated]
		private parts_request <SelectedPartRequest>k__BackingField;

		// Token: 0x04002864 RID: 10340
		[CompilerGenerated]
		private bool <ActionSuccess>k__BackingField;

		// Token: 0x04002865 RID: 10341
		[CompilerGenerated]
		private bool <UserIsManager>k__BackingField;

		// Token: 0x04002866 RID: 10342
		[CompilerGenerated]
		private bool <WorkPartsVisible>k__BackingField;

		// Token: 0x04002867 RID: 10343
		[CompilerGenerated]
		private RepairCardLayoutVisibility <LayoutVisibility>k__BackingField;

		// Token: 0x04002868 RID: 10344
		private int _cashOrderId;

		// Token: 0x04002869 RID: 10345
		[CompilerGenerated]
		private IStatusViewModel <StatusViewModel>k__BackingField;

		// Token: 0x0400286A RID: 10346
		private string _diagnosticOriginal;

		// Token: 0x0400286B RID: 10347
		private IPartsRequestService _partsRequestService;

		// Token: 0x0400286C RID: 10348
		[CompilerGenerated]
		private Dictionary<int, string> <PartRequestStatuses>k__BackingField;

		// Token: 0x02000817 RID: 2071
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SetClientInformedStatus>d__63 : IAsyncStateMachine
		{
			// Token: 0x06003E0D RID: 15885 RVA: 0x000F6A28 File Offset: 0x000F4C28
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairCardViewModel repairCardViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						repairCardViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = Task.Run(() => repairCardViewModel._workshopService.UpdateInformStatus(base.Repair.id, base.Repair.informed_status)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RepairCardViewModel.<SetClientInformedStatus>d__63>(ref awaiter, ref this);
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
						repairCardViewModel._toasterService.Success(Lang.t("InformStatusUpdated"));
					}
					catch (Exception ex)
					{
						repairCardViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							repairCardViewModel.HideWait();
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

			// Token: 0x06003E0E RID: 15886 RVA: 0x000F6B44 File Offset: 0x000F4D44
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400286D RID: 10349
			public int <>1__state;

			// Token: 0x0400286E RID: 10350
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400286F RID: 10351
			public RepairCardViewModel <>4__this;

			// Token: 0x04002870 RID: 10352
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000818 RID: 2072
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SaveWarrantyLabel>d__65 : IAsyncStateMachine
		{
			// Token: 0x06003E0F RID: 15887 RVA: 0x000F6B60 File Offset: 0x000F4D60
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairCardViewModel repairCardViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						repairCardViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = Task.Run(() => repairCardViewModel._workshopService.SaveWarrantyLabel(base.RepairId, base.Repair.warranty_label)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RepairCardViewModel.<SaveWarrantyLabel>d__65>(ref awaiter, ref this);
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
						repairCardViewModel._toasterService.Success(Lang.t("WarrantyLabelUpdated"));
					}
					catch (Exception ex)
					{
						repairCardViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							repairCardViewModel.HideWait();
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

			// Token: 0x06003E10 RID: 15888 RVA: 0x000F6C7C File Offset: 0x000F4E7C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002871 RID: 10353
			public int <>1__state;

			// Token: 0x04002872 RID: 10354
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04002873 RID: 10355
			public RepairCardViewModel <>4__this;

			// Token: 0x04002874 RID: 10356
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000819 RID: 2073
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SaveDiagResult>d__66 : IAsyncStateMachine
		{
			// Token: 0x06003E11 RID: 15889 RVA: 0x000F6C98 File Offset: 0x000F4E98
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairCardViewModel repairCardViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						string text = repairCardViewModel._RepairModel.CheckDiagFields(repairCardViewModel.Repair);
						if (!string.IsNullOrEmpty(text))
						{
							repairCardViewModel._toasterService.Info(text);
							goto IL_107;
						}
						repairCardViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = Task.Run(() => repairCardViewModel._workshopService.UpdateDiagnosticResult(base.Repair)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RepairCardViewModel.<SaveDiagResult>d__66>(ref awaiter, ref this);
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
						repairCardViewModel.RefreshCommands();
						repairCardViewModel._toasterService.Success(Lang.t("DiagSaved"));
					}
					catch (Exception ex)
					{
						repairCardViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							repairCardViewModel.HideWait();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_107:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003E12 RID: 15890 RVA: 0x000F6DE8 File Offset: 0x000F4FE8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002875 RID: 10357
			public int <>1__state;

			// Token: 0x04002876 RID: 10358
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04002877 RID: 10359
			public RepairCardViewModel <>4__this;

			// Token: 0x04002878 RID: 10360
			private TaskAwaiter <>u__1;
		}

		// Token: 0x0200081A RID: 2074
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CountRepairCost>d__69 : IAsyncStateMachine
		{
			// Token: 0x06003E13 RID: 15891 RVA: 0x000F6E04 File Offset: 0x000F5004
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairCardViewModel repairCardViewModel = this.<>4__this;
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
							goto IL_117;
						}
						if (repairCardViewModel.Repair.state != 6)
						{
							if (repairCardViewModel.Repair.state != 7)
							{
								if (repairCardViewModel.Repair.state != 16)
								{
									goto IL_132;
								}
							}
						}
						awaiter = RepairModel.GetRepairFinalAmount(repairCardViewModel.RepairId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, RepairCardViewModel.<CountRepairCost>d__69>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<decimal>);
						this.<>1__state = -1;
					}
					decimal result = awaiter.GetResult();
					repairCardViewModel.FinalAmount = result;
					this.<>7__wrap1 = repairCardViewModel.Repair;
					awaiter = RepairModel.GetRepairCostTotal(repairCardViewModel.RepairId).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, RepairCardViewModel.<CountRepairCost>d__69>(ref awaiter, ref this);
						return;
					}
					IL_117:
					result = awaiter.GetResult();
					this.<>7__wrap1.real_repair_cost = result;
					this.<>7__wrap1 = null;
					IL_132:;
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

			// Token: 0x06003E14 RID: 15892 RVA: 0x000F6F90 File Offset: 0x000F5190
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002879 RID: 10361
			public int <>1__state;

			// Token: 0x0400287A RID: 10362
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400287B RID: 10363
			public RepairCardViewModel <>4__this;

			// Token: 0x0400287C RID: 10364
			private TaskAwaiter<decimal> <>u__1;

			// Token: 0x0400287D RID: 10365
			private workshop <>7__wrap1;
		}

		// Token: 0x0200081B RID: 2075
		[CompilerGenerated]
		private sealed class <>c__DisplayClass70_0
		{
			// Token: 0x06003E15 RID: 15893 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass70_0()
			{
			}

			// Token: 0x06003E16 RID: 15894 RVA: 0x000F6FAC File Offset: 0x000F51AC
			internal bool <UpdateBoxesVisibility>b__0(offices i)
			{
				return i.id == this.repairCurrentOfficeId;
			}

			// Token: 0x0400287E RID: 10366
			public int repairCurrentOfficeId;
		}

		// Token: 0x0200081C RID: 2076
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadRepair>d__71 : IAsyncStateMachine
		{
			// Token: 0x06003E17 RID: 15895 RVA: 0x000F6FC8 File Offset: 0x000F51C8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairCardViewModel repairCardViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter<workshop> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter);
							this.<>1__state = -1;
							goto IL_15E;
						}
						awaiter2 = repairCardViewModel._workshopService.GetRepair(repairCardViewModel.RepairId).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop>, RepairCardViewModel.<LoadRepair>d__71>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<workshop>);
						this.<>1__state = -1;
					}
					workshop result = awaiter2.GetResult();
					repairCardViewModel.Repair = result;
					repairCardViewModel._diagnosticOriginal = repairCardViewModel.Repair.diagnostic_result;
					repairCardViewModel.UpdateBoxesVisibility(repairCardViewModel.Repair.office);
					repairCardViewModel.LayoutVisibility.DefaultLayoutVisibility(repairCardViewModel.Repair.state);
					repairCardViewModel.Info = RepairModel.GetRepairInfo(repairCardViewModel.Repair);
					repairCardViewModel.LayoutVisibility.SetCustomerInfoVisibility(repairCardViewModel.Info.Count > 0);
					if (Auth.User.id == repairCardViewModel.Repair.current_manager)
					{
						repairCardViewModel.UserIsManager = true;
					}
					awaiter = repairCardViewModel.CountRepairCost().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RepairCardViewModel.<LoadRepair>d__71>(ref awaiter, ref this);
						return;
					}
					IL_15E:
					awaiter.GetResult();
					repairCardViewModel.RefreshCommands();
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

			// Token: 0x06003E18 RID: 15896 RVA: 0x000F718C File Offset: 0x000F538C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400287F RID: 10367
			public int <>1__state;

			// Token: 0x04002880 RID: 10368
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002881 RID: 10369
			public RepairCardViewModel <>4__this;

			// Token: 0x04002882 RID: 10370
			private TaskAwaiter<workshop> <>u__1;

			// Token: 0x04002883 RID: 10371
			private TaskAwaiter <>u__2;
		}

		// Token: 0x0200081D RID: 2077
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <InitCard>d__72 : IAsyncStateMachine
		{
			// Token: 0x06003E19 RID: 15897 RVA: 0x000F71A8 File Offset: 0x000F53A8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairCardViewModel repairCardViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<parts_request>> awaiter;
					TaskAwaiter awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<List<parts_request>>);
							this.<>1__state = -1;
							goto IL_146;
						}
						awaiter2 = Task.Run(() => base.LoadRepair()).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RepairCardViewModel.<InitCard>d__72>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
					}
					awaiter2.GetResult();
					if (repairCardViewModel.Repair == null)
					{
						goto IL_175;
					}
					if (repairCardViewModel.WP == null)
					{
						repairCardViewModel.WP = new WpViewModel(repairCardViewModel.Repair);
					}
					repairCardViewModel.StatusViewModel.LoadRepairStates(repairCardViewModel.Repair.state);
					if (repairCardViewModel.Repair.field_values != null && repairCardViewModel.Repair.field_values.Count > 0)
					{
						repairCardViewModel.LoadUserFieldsCommonTab();
					}
					awaiter = repairCardViewModel._partsRequestService.GetRequests(repairCardViewModel.Repair.id).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<parts_request>>, RepairCardViewModel.<InitCard>d__72>(ref awaiter, ref this);
						return;
					}
					IL_146:
					List<parts_request> result = awaiter.GetResult();
					repairCardViewModel.PartRequests = new ObservableCollection<parts_request>(result);
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_175:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003E1A RID: 15898 RVA: 0x000F735C File Offset: 0x000F555C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002884 RID: 10372
			public int <>1__state;

			// Token: 0x04002885 RID: 10373
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002886 RID: 10374
			public RepairCardViewModel <>4__this;

			// Token: 0x04002887 RID: 10375
			private TaskAwaiter <>u__1;

			// Token: 0x04002888 RID: 10376
			private TaskAwaiter<List<parts_request>> <>u__2;
		}

		// Token: 0x0200081E RID: 2078
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SaveColor>d__79 : IAsyncStateMachine
		{
			// Token: 0x06003E1B RID: 15899 RVA: 0x000F7378 File Offset: 0x000F5578
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairCardViewModel repairCardViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						repairCardViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = Task.Run(() => repairCardViewModel._workshopService.SetRepairColor(base.RepairId, base.Repair.color)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RepairCardViewModel.<SaveColor>d__79>(ref awaiter, ref this);
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
						repairCardViewModel._toasterService.Success(Lang.t("Saved"));
					}
					catch (Exception ex)
					{
						repairCardViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							repairCardViewModel.HideWait();
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

			// Token: 0x06003E1C RID: 15900 RVA: 0x000F7494 File Offset: 0x000F5694
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002889 RID: 10377
			public int <>1__state;

			// Token: 0x0400288A RID: 10378
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400288B RID: 10379
			public RepairCardViewModel <>4__this;

			// Token: 0x0400288C RID: 10380
			private TaskAwaiter <>u__1;
		}

		// Token: 0x0200081F RID: 2079
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CloseDebt>d__81 : IAsyncStateMachine
		{
			// Token: 0x06003E1D RID: 15901 RVA: 0x000F74B0 File Offset: 0x000F56B0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairCardViewModel repairCardViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (repairCardViewModel._ascMessageBoxService.ShowMessageBox(Lang.t("CloseDebtConfirm"), Lang.t("InDebt"), MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes)
						{
							goto IL_BD;
						}
						KassaModel kassaModel = new KassaModel();
						kassaModel.NewCashOrder(repairCardViewModel.Repair, repairCardViewModel.FinalAmount);
						kassaModel.MakePko(false);
						repairCardViewModel.Repair.state = 8;
						awaiter = repairCardViewModel.LoadRepair().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RepairCardViewModel.<CloseDebt>d__81>(ref awaiter, ref this);
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
					IL_BD:;
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

			// Token: 0x06003E1E RID: 15902 RVA: 0x000F75B8 File Offset: 0x000F57B8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400288D RID: 10381
			public int <>1__state;

			// Token: 0x0400288E RID: 10382
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400288F RID: 10383
			public RepairCardViewModel <>4__this;

			// Token: 0x04002890 RID: 10384
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000820 RID: 2080
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SaveIssuingMessage>d__87 : IAsyncStateMachine
		{
			// Token: 0x06003E1F RID: 15903 RVA: 0x000F75D4 File Offset: 0x000F57D4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairCardViewModel repairCardViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						if (string.IsNullOrEmpty(repairCardViewModel.Repair.issued_msg))
						{
							repairCardViewModel._toasterService.Info(Lang.t("MessageTooShort"));
							goto IL_13C;
						}
						if (repairCardViewModel.Repair.issued_msg.Length > 253)
						{
							repairCardViewModel._toasterService.Info(Lang.t("MessageTooLong"));
							goto IL_13C;
						}
						repairCardViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = Task.Run(() => repairCardViewModel._workshopService.SaveIssuingMessage(base.RepairId, base.Repair.issued_msg)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RepairCardViewModel.<SaveIssuingMessage>d__87>(ref awaiter, ref this);
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
						repairCardViewModel._toasterService.Success(Lang.t("Saved"));
						repairCardViewModel._windowedDocumentService.CloseActiveDocument();
					}
					catch (Exception ex)
					{
						repairCardViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							repairCardViewModel.HideWait();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_13C:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003E20 RID: 15904 RVA: 0x000F777C File Offset: 0x000F597C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002891 RID: 10385
			public int <>1__state;

			// Token: 0x04002892 RID: 10386
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04002893 RID: 10387
			public RepairCardViewModel <>4__this;

			// Token: 0x04002894 RID: 10388
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000821 RID: 2081
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnLoad>d__93 : IAsyncStateMachine
		{
			// Token: 0x06003E21 RID: 15905 RVA: 0x000F7798 File Offset: 0x000F5998
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairCardViewModel repairCardViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						repairCardViewModel.<>n__0();
						repairCardViewModel.LockCardModel.Lock();
						awaiter = repairCardViewModel.InitCard().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RepairCardViewModel.<OnLoad>d__93>(ref awaiter, ref this);
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
					if (repairCardViewModel.PartRequestStatuses == null)
					{
						repairCardViewModel.PartRequestStatuses = repairCardViewModel._partsRequestService.GetPartsRequestStatuses(false);
					}
					repairCardViewModel.SetViewLoaded(true);
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

			// Token: 0x06003E22 RID: 15906 RVA: 0x000F787C File Offset: 0x000F5A7C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002895 RID: 10389
			public int <>1__state;

			// Token: 0x04002896 RID: 10390
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04002897 RID: 10391
			public RepairCardViewModel <>4__this;

			// Token: 0x04002898 RID: 10392
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000822 RID: 2082
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <DataRefresh>d__101 : IAsyncStateMachine
		{
			// Token: 0x06003E23 RID: 15907 RVA: 0x000F7898 File Offset: 0x000F5A98
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairCardViewModel repairCardViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						repairCardViewModel.SetViewLoaded(false);
						awaiter = repairCardViewModel.InitCard().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RepairCardViewModel.<DataRefresh>d__101>(ref awaiter, ref this);
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
					repairCardViewModel.SetViewLoaded(true);
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

			// Token: 0x06003E24 RID: 15908 RVA: 0x000F7958 File Offset: 0x000F5B58
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002899 RID: 10393
			public int <>1__state;

			// Token: 0x0400289A RID: 10394
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400289B RID: 10395
			public RepairCardViewModel <>4__this;

			// Token: 0x0400289C RID: 10396
			private TaskAwaiter <>u__1;
		}
	}
}
