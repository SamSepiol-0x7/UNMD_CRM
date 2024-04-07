using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Objects.Converters;
using ASC.Options;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using ASC.Workspace.Repairs;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Xpf.Editors;
using DevExpress.XtraReports.UI;

namespace ASC.ViewModels
{
	// Token: 0x020003B7 RID: 951
	internal sealed class ItemsBuyoutViewModel : AcceptNewViewModelBase, IRepairSelect, ICustomerSelect
	{
		// Token: 0x17000D8B RID: 3467
		// (get) Token: 0x060027B1 RID: 10161 RVA: 0x00079968 File Offset: 0x00077B68
		// (set) Token: 0x060027B2 RID: 10162 RVA: 0x0007997C File Offset: 0x00077B7C
		public store_items Item
		{
			[CompilerGenerated]
			get
			{
				return this.<Item>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Item>k__BackingField, value))
				{
					return;
				}
				this.<Item>k__BackingField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		// Token: 0x17000D8C RID: 3468
		// (get) Token: 0x060027B3 RID: 10163 RVA: 0x000799AC File Offset: 0x00077BAC
		// (set) Token: 0x060027B4 RID: 10164 RVA: 0x000799C0 File Offset: 0x00077BC0
		public docs Document
		{
			[CompilerGenerated]
			get
			{
				return this.<Document>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<Document>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1568898530;
				IL_13:
				switch ((num ^ 776668169) % 4)
				{
				case 0:
					goto IL_0E;
				case 2:
					IL_32:
					this.<Document>k__BackingField = value;
					this.RaisePropertyChanged("Document");
					num = 1144652380;
					goto IL_13;
				case 3:
					return;
				}
			}
		}

		// Token: 0x17000D8D RID: 3469
		// (get) Token: 0x060027B5 RID: 10165 RVA: 0x00079A1C File Offset: 0x00077C1C
		// (set) Token: 0x060027B6 RID: 10166 RVA: 0x00079A30 File Offset: 0x00077C30
		public List<PaymentOptions> PaymentOptionses
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentOptionses>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(this.<PaymentOptionses>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -313392372;
				IL_13:
				switch ((num ^ -1166521319) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					return;
				case 3:
					IL_32:
					this.<PaymentOptionses>k__BackingField = value;
					num = -1953383305;
					goto IL_13;
				}
				this.RaisePropertyChanged("PaymentOptionses");
			}
		}

		// Token: 0x17000D8E RID: 3470
		// (get) Token: 0x060027B7 RID: 10167 RVA: 0x00079A8C File Offset: 0x00077C8C
		// (set) Token: 0x060027B8 RID: 10168 RVA: 0x00079AA0 File Offset: 0x00077CA0
		public List<string> Documents
		{
			[CompilerGenerated]
			get
			{
				return this.<Documents>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(this.<Documents>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -2141623171;
				IL_13:
				switch ((num ^ -1935765616) % 4)
				{
				case 1:
					return;
				case 2:
					IL_32:
					this.<Documents>k__BackingField = value;
					this.RaisePropertyChanged("Documents");
					num = -1998698876;
					goto IL_13;
				case 3:
					goto IL_0E;
				}
			}
		}

		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x060027B9 RID: 10169 RVA: 0x00079AFC File Offset: 0x00077CFC
		// (set) Token: 0x060027BA RID: 10170 RVA: 0x00079B10 File Offset: 0x00077D10
		public ObservableCollection<items_state> States
		{
			[CompilerGenerated]
			get
			{
				return this.<States>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<States>k__BackingField, value))
				{
					return;
				}
				this.<States>k__BackingField = value;
				this.RaisePropertyChanged("States");
			}
		}

		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x060027BB RID: 10171 RVA: 0x00079B40 File Offset: 0x00077D40
		// (set) Token: 0x060027BC RID: 10172 RVA: 0x00079B54 File Offset: 0x00077D54
		public List<stores> Stores
		{
			[CompilerGenerated]
			get
			{
				return this.<Stores>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Stores>k__BackingField, value))
				{
					return;
				}
				this.<Stores>k__BackingField = value;
				this.RaisePropertyChanged("Stores");
			}
		}

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x060027BD RID: 10173 RVA: 0x00079B84 File Offset: 0x00077D84
		// (set) Token: 0x060027BE RID: 10174 RVA: 0x00079B98 File Offset: 0x00077D98
		public List<store_cats> StoreCategories
		{
			[CompilerGenerated]
			get
			{
				return this.<StoreCategories>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<StoreCategories>k__BackingField, value))
				{
					return;
				}
				this.<StoreCategories>k__BackingField = value;
				this.RaisePropertyChanged("StoreCategories");
			}
		}

		// Token: 0x17000D92 RID: 3474
		// (get) Token: 0x060027BF RID: 10175 RVA: 0x00079BC8 File Offset: 0x00077DC8
		// (set) Token: 0x060027C0 RID: 10176 RVA: 0x00079BDC File Offset: 0x00077DDC
		public List<IDevice> Devices
		{
			[CompilerGenerated]
			get
			{
				return this.<Devices>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Devices>k__BackingField, value))
				{
					return;
				}
				this.<Devices>k__BackingField = value;
				this.RaisePropertyChanged("Devices");
			}
		}

		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x060027C1 RID: 10177 RVA: 0x00079C0C File Offset: 0x00077E0C
		// (set) Token: 0x060027C2 RID: 10178 RVA: 0x00079C20 File Offset: 0x00077E20
		public ObservableCollection<device_models> MakerModels
		{
			[CompilerGenerated]
			get
			{
				return this.<MakerModels>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<MakerModels>k__BackingField, value))
				{
					return;
				}
				this.<MakerModels>k__BackingField = value;
				this.RaisePropertyChanged("MakerModels");
			}
		}

		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x060027C3 RID: 10179 RVA: 0x00079C50 File Offset: 0x00077E50
		// (set) Token: 0x060027C4 RID: 10180 RVA: 0x00079C64 File Offset: 0x00077E64
		public IDevice SelectedType
		{
			get
			{
				return this._selectedType;
			}
			set
			{
				if (object.Equals(this._selectedType, value))
				{
					return;
				}
				this._selectedType = value;
				this.RaisePropertyChanged("SelectedType");
				if (value != null)
				{
					this.LoadMakers(value);
				}
			}
		}

		// Token: 0x060027C5 RID: 10181 RVA: 0x00079C9C File Offset: 0x00077E9C
		private void LoadMakers(IDevice device)
		{
			ItemsBuyoutViewModel.<LoadMakers>d__47 <LoadMakers>d__;
			<LoadMakers>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadMakers>d__.<>4__this = this;
			<LoadMakers>d__.device = device;
			<LoadMakers>d__.<>1__state = -1;
			<LoadMakers>d__.<>t__builder.Start<ItemsBuyoutViewModel.<LoadMakers>d__47>(ref <LoadMakers>d__);
		}

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x060027C6 RID: 10182 RVA: 0x00079CDC File Offset: 0x00077EDC
		// (set) Token: 0x060027C7 RID: 10183 RVA: 0x00079CF0 File Offset: 0x00077EF0
		public IManufacturer SelectedMaker
		{
			get
			{
				return this._selectedMaker;
			}
			set
			{
				if (object.Equals(this._selectedMaker, value))
				{
					return;
				}
				this._selectedMaker = value;
				this.RaisePropertyChanged("SelectedMaker");
				this.LoadModels();
			}
		}

		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x060027C8 RID: 10184 RVA: 0x00079D24 File Offset: 0x00077F24
		// (set) Token: 0x060027C9 RID: 10185 RVA: 0x00079D38 File Offset: 0x00077F38
		public device_models SelectedModel
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedModel>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedModel>k__BackingField, value))
				{
					return;
				}
				this.<SelectedModel>k__BackingField = value;
				this.RaisePropertyChanged("SelectedModel");
			}
		}

		// Token: 0x17000D97 RID: 3479
		// (get) Token: 0x060027CA RID: 10186 RVA: 0x00079D68 File Offset: 0x00077F68
		// (set) Token: 0x060027CB RID: 10187 RVA: 0x00079D7C File Offset: 0x00077F7C
		public buyout CustomerDocument
		{
			[CompilerGenerated]
			get
			{
				return this.<CustomerDocument>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<CustomerDocument>k__BackingField, value))
				{
					return;
				}
				this.<CustomerDocument>k__BackingField = value;
				this.RaisePropertyChanged("CustomerDocument");
			}
		}

		// Token: 0x17000D98 RID: 3480
		// (get) Token: 0x060027CC RID: 10188 RVA: 0x0003FF48 File Offset: 0x0003E148
		public bool ValidateMaker
		{
			get
			{
				return !Auth.Config.manual_maker;
			}
		}

		// Token: 0x060027CD RID: 10189 RVA: 0x00079DAC File Offset: 0x00077FAC
		public ItemsBuyoutViewModel(IStoreService storeService, IBuyoutService buyoutService, IToasterService toasterService, IDeviceModelService deviceModelService, IReportPrintService reportPrintService)
		{
			this._storeService = storeService;
			this._buyoutService = buyoutService;
			this._toasterService = toasterService;
			this._deviceModelService = deviceModelService;
			this._reportPrintService = reportPrintService;
			this.SetViewName("RedemptionOfEquipment");
			this.Item = ItemsModel.DefaultItem();
			this.Item.state = 2;
			this.CustomerDocument = new buyout
			{
				name = Lang.t("Passport")
			};
			this.Document = new docs(true);
		}

		// Token: 0x060027CE RID: 10190 RVA: 0x00079E30 File Offset: 0x00078030
		public void SetDocumentId(int documentId)
		{
			this._documentId = new int?(documentId);
		}

		// Token: 0x060027CF RID: 10191 RVA: 0x00079E4C File Offset: 0x0007804C
		private void Load(int documentId)
		{
			ItemsBuyoutViewModel.<Load>d__64 <Load>d__;
			<Load>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Load>d__.<>4__this = this;
			<Load>d__.documentId = documentId;
			<Load>d__.<>1__state = -1;
			<Load>d__.<>t__builder.Start<ItemsBuyoutViewModel.<Load>d__64>(ref <Load>d__);
		}

		// Token: 0x060027D0 RID: 10192 RVA: 0x00079E8C File Offset: 0x0007808C
		public override void OnLoad()
		{
			ItemsBuyoutViewModel.<OnLoad>d__65 <OnLoad>d__;
			<OnLoad>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnLoad>d__.<>4__this = this;
			<OnLoad>d__.<>1__state = -1;
			<OnLoad>d__.<>t__builder.Start<ItemsBuyoutViewModel.<OnLoad>d__65>(ref <OnLoad>d__);
		}

		// Token: 0x060027D1 RID: 10193 RVA: 0x00079EC4 File Offset: 0x000780C4
		private void LoadPaymentOptions()
		{
			PaymentOptions paymentOptions = new PaymentOptions();
			this.PaymentOptionses = paymentOptions.GetAllOptions();
		}

		// Token: 0x060027D2 RID: 10194 RVA: 0x00079EE4 File Offset: 0x000780E4
		private void LoadModels()
		{
			ItemsBuyoutViewModel.<LoadModels>d__67 <LoadModels>d__;
			<LoadModels>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadModels>d__.<>4__this = this;
			<LoadModels>d__.<>1__state = -1;
			<LoadModels>d__.<>t__builder.Start<ItemsBuyoutViewModel.<LoadModels>d__67>(ref <LoadModels>d__);
		}

		// Token: 0x060027D3 RID: 10195 RVA: 0x00079F1C File Offset: 0x0007811C
		[Command]
		public void SetNoSn()
		{
			this.Item.SN = Lang.t("NoSn");
		}

		// Token: 0x060027D4 RID: 10196 RVA: 0x00079F40 File Offset: 0x00078140
		public bool CanSetNoSn()
		{
			if (this.Item != null)
			{
				docs document = this.Document;
				return document != null && document.id == 0;
			}
			return false;
		}

		// Token: 0x060027D5 RID: 10197 RVA: 0x00079F6C File Offset: 0x0007816C
		public override bool CanSelectCustomer()
		{
			return this.Document != null && this.Document.id == 0;
		}

		// Token: 0x060027D6 RID: 10198 RVA: 0x00079F94 File Offset: 0x00078194
		public void SelectCustomerFromList(ICustomer customer)
		{
			ItemsBuyoutViewModel.<SelectCustomerFromList>d__71 <SelectCustomerFromList>d__;
			<SelectCustomerFromList>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SelectCustomerFromList>d__.<>4__this = this;
			<SelectCustomerFromList>d__.customer = customer;
			<SelectCustomerFromList>d__.<>1__state = -1;
			<SelectCustomerFromList>d__.<>t__builder.Start<ItemsBuyoutViewModel.<SelectCustomerFromList>d__71>(ref <SelectCustomerFromList>d__);
		}

		// Token: 0x060027D7 RID: 10199 RVA: 0x00079FD4 File Offset: 0x000781D4
		[Command]
		public void Print()
		{
			ItemsBuyoutViewModel.<Print>d__72 <Print>d__;
			<Print>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Print>d__.<>4__this = this;
			<Print>d__.<>1__state = -1;
			<Print>d__.<>t__builder.Start<ItemsBuyoutViewModel.<Print>d__72>(ref <Print>d__);
		}

		// Token: 0x060027D8 RID: 10200 RVA: 0x0007A00C File Offset: 0x0007820C
		public bool CanPrint()
		{
			docs document = this.Document;
			return document != null && document.id > 0;
		}

		// Token: 0x060027D9 RID: 10201 RVA: 0x0007A030 File Offset: 0x00078230
		[Command]
		public void MakeOrder()
		{
			ItemsBuyoutViewModel.<MakeOrder>d__74 <MakeOrder>d__;
			<MakeOrder>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<MakeOrder>d__.<>4__this = this;
			<MakeOrder>d__.<>1__state = -1;
			<MakeOrder>d__.<>t__builder.Start<ItemsBuyoutViewModel.<MakeOrder>d__74>(ref <MakeOrder>d__);
		}

		// Token: 0x060027DA RID: 10202 RVA: 0x0007A068 File Offset: 0x00078268
		public bool CanMakeOrder()
		{
			return this.Document != null && this.Document.id == 0 && !this._buzy;
		}

		// Token: 0x060027DB RID: 10203 RVA: 0x0007A098 File Offset: 0x00078298
		public bool CheckCustomerFields(CustomerCard customer)
		{
			clients clients = customer.Customer2Client();
			if (clients.type == 0 && string.IsNullOrEmpty(clients.name))
			{
				this._toasterService.Info(Lang.t("InputClientName"));
				return false;
			}
			if (Auth.Config.is_patronymic_required && clients.type == 0 && string.IsNullOrEmpty(clients.patronymic))
			{
				this._toasterService.Info(Lang.t("InputPatronymic"));
				return false;
			}
			if (clients.type == 1 && string.IsNullOrEmpty(clients.ur_name))
			{
				this._toasterService.Info(Lang.t("InputUrName"));
				return false;
			}
			return true;
		}

		// Token: 0x060027DC RID: 10204 RVA: 0x0007A140 File Offset: 0x00078340
		[Command]
		public void StoreChanged()
		{
			ItemsBuyoutViewModel.<StoreChanged>d__77 <StoreChanged>d__;
			<StoreChanged>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<StoreChanged>d__.<>4__this = this;
			<StoreChanged>d__.<>1__state = -1;
			<StoreChanged>d__.<>t__builder.Start<ItemsBuyoutViewModel.<StoreChanged>d__77>(ref <StoreChanged>d__);
		}

		// Token: 0x060027DD RID: 10205 RVA: 0x0007A178 File Offset: 0x00078378
		[Command]
		public void NewModelInput(object obj)
		{
			ProcessNewValueEventArgs processNewValueEventArgs = obj as ProcessNewValueEventArgs;
			if (processNewValueEventArgs == null)
			{
				return;
			}
			if (this.MakerModels == null)
			{
				this.MakerModels = new ObservableCollection<device_models>();
			}
			this.MakerModels.Add(new device_models
			{
				id = 0,
				name = processNewValueEventArgs.DisplayText
			});
		}

		// Token: 0x060027DE RID: 10206 RVA: 0x0007A1C8 File Offset: 0x000783C8
		[Command]
		public void MakersChanged()
		{
			ItemsBuyoutViewModel.<MakersChanged>d__79 <MakersChanged>d__;
			<MakersChanged>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<MakersChanged>d__.<>4__this = this;
			<MakersChanged>d__.<>1__state = -1;
			<MakersChanged>d__.<>t__builder.Start<ItemsBuyoutViewModel.<MakersChanged>d__79>(ref <MakersChanged>d__);
		}

		// Token: 0x060027DF RID: 10207 RVA: 0x0007A200 File Offset: 0x00078400
		public bool CanMakersChanged()
		{
			return this.SelectedType != null && this.SelectedMaker != null;
		}

		// Token: 0x060027E0 RID: 10208 RVA: 0x0007A220 File Offset: 0x00078420
		[Command]
		public void NewMakerInput(object obj)
		{
			if (!Auth.Config.manual_maker)
			{
				return;
			}
			ProcessNewValueEventArgs processNewValueEventArgs = obj as ProcessNewValueEventArgs;
			if (processNewValueEventArgs != null)
			{
				if (base.Makers == null)
				{
					base.Makers = new ObservableCollection<IManufacturer>();
				}
				base.Makers.Add(new Manufacturer(0, processNewValueEventArgs.DisplayText));
				this.MakerModels = new ObservableCollection<device_models>();
				return;
			}
		}

		// Token: 0x060027E1 RID: 10209 RVA: 0x0007A27C File Offset: 0x0007847C
		private bool CheckFields(docs document, store_items item, CustomerCard client)
		{
			if (this.SelectedType == null)
			{
				this._toasterService.Info(Lang.t("SelectDeviceType"));
				return false;
			}
			if (this.SelectedMaker == null)
			{
				this._toasterService.Info(Lang.t("SelectDeviceMaker"));
				return false;
			}
			if (this.SelectedModel == null)
			{
				this._toasterService.Info(Lang.t("SelectDeviceModel"));
				return false;
			}
			if (!(document.total <= 0m))
			{
				if (document.store != null)
				{
					int? store = document.store;
					if (!(store.GetValueOrDefault() == 0 & store != null))
					{
						if (item.category == 0)
						{
							this._toasterService.Info(Lang.t("InputCategory"));
							return false;
						}
						if (string.IsNullOrEmpty(base.Customer.FioOrUrName))
						{
							this._toasterService.Info(Lang.t("SelectCustomer"));
							return false;
						}
						if (Auth.Config.is_patronymic_required && client.Type == 0 && string.IsNullOrEmpty(client.Patronymic))
						{
							this._toasterService.Info(Lang.t("InputPatronymic"));
							return false;
						}
						if (Auth.Config.email_required && string.IsNullOrEmpty(client.Email))
						{
							this._toasterService.Info(Lang.t("EmailRequired"));
							return false;
						}
						if (Auth.Config.address_required && string.IsNullOrEmpty(client.Address))
						{
							this._toasterService.Info(Lang.t("AddressRequired"));
							return false;
						}
						if (!string.IsNullOrEmpty(this.CustomerDocument.number))
						{
							return true;
						}
						this._toasterService.Info(Lang.t("InputDocumentNumber"));
						return false;
					}
				}
				this._toasterService.Info(Lang.t("SelectStore"));
				return false;
			}
			this._toasterService.Info(Lang.t("InputSumm"));
			return false;
		}

		// Token: 0x060027E2 RID: 10210 RVA: 0x000414C4 File Offset: 0x0003F6C4
		[Command]
		public void SelectRepair()
		{
			RepairsViewModel repairsViewModel = new RepairsViewModel();
			repairsViewModel.MakeReturnOnSelect();
			this._navigationService.Navigate("RepairsView", repairsViewModel, this);
		}

		// Token: 0x060027E3 RID: 10211 RVA: 0x0007A464 File Offset: 0x00078664
		public bool CanSelectRepair()
		{
			docs document = this.Document;
			return document != null && document.id == 0;
		}

		// Token: 0x060027E4 RID: 10212 RVA: 0x0007A488 File Offset: 0x00078688
		public void SelectRepairFromList(WorkshopLite repair)
		{
			ItemsBuyoutViewModel.<SelectRepairFromList>d__85 <SelectRepairFromList>d__;
			<SelectRepairFromList>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SelectRepairFromList>d__.<>4__this = this;
			<SelectRepairFromList>d__.repair = repair;
			<SelectRepairFromList>d__.<>1__state = -1;
			<SelectRepairFromList>d__.<>t__builder.Start<ItemsBuyoutViewModel.<SelectRepairFromList>d__85>(ref <SelectRepairFromList>d__);
		}

		// Token: 0x060027E5 RID: 10213 RVA: 0x0007A4C8 File Offset: 0x000786C8
		[Command]
		public void OpenItemCard()
		{
			this._navigationService.NavigateToStoreItem(this.Item.id, 0);
		}

		// Token: 0x060027E6 RID: 10214 RVA: 0x0007A4EC File Offset: 0x000786EC
		public bool CanOpenItemCard()
		{
			docs document = this.Document;
			if (document != null && document.id > 0)
			{
				store_items item = this.Item;
				return item != null && item.id > 0;
			}
			return false;
		}

		// Token: 0x060027E7 RID: 10215 RVA: 0x0007A528 File Offset: 0x00078728
		[CompilerGenerated]
		private bool <Load>b__64_0(IDevice i)
		{
			return i.Id.Equals(this.CustomerDocument.device_id);
		}

		// Token: 0x060027E8 RID: 10216 RVA: 0x0007A550 File Offset: 0x00078750
		[CompilerGenerated]
		private bool <Load>b__64_1(IManufacturer i)
		{
			return i.Id.Equals(this.CustomerDocument.device_maker_id);
		}

		// Token: 0x060027E9 RID: 10217 RVA: 0x0007A578 File Offset: 0x00078778
		[CompilerGenerated]
		private bool <Load>b__64_2(device_models i)
		{
			return i.id.Equals(this.CustomerDocument.device_model_id);
		}

		// Token: 0x04001594 RID: 5524
		private readonly IStoreService _storeService;

		// Token: 0x04001595 RID: 5525
		private readonly IBuyoutService _buyoutService;

		// Token: 0x04001596 RID: 5526
		private readonly IToasterService _toasterService;

		// Token: 0x04001597 RID: 5527
		private readonly IDeviceModelService _deviceModelService;

		// Token: 0x04001598 RID: 5528
		private readonly IReportPrintService _reportPrintService;

		// Token: 0x04001599 RID: 5529
		private IDevice _selectedType;

		// Token: 0x0400159A RID: 5530
		private IManufacturer _selectedMaker;

		// Token: 0x0400159B RID: 5531
		[CompilerGenerated]
		private store_items <Item>k__BackingField;

		// Token: 0x0400159C RID: 5532
		[CompilerGenerated]
		private docs <Document>k__BackingField;

		// Token: 0x0400159D RID: 5533
		[CompilerGenerated]
		private List<PaymentOptions> <PaymentOptionses>k__BackingField;

		// Token: 0x0400159E RID: 5534
		[CompilerGenerated]
		private List<string> <Documents>k__BackingField;

		// Token: 0x0400159F RID: 5535
		[CompilerGenerated]
		private ObservableCollection<items_state> <States>k__BackingField;

		// Token: 0x040015A0 RID: 5536
		[CompilerGenerated]
		private List<stores> <Stores>k__BackingField;

		// Token: 0x040015A1 RID: 5537
		[CompilerGenerated]
		private List<store_cats> <StoreCategories>k__BackingField;

		// Token: 0x040015A2 RID: 5538
		[CompilerGenerated]
		private List<IDevice> <Devices>k__BackingField;

		// Token: 0x040015A3 RID: 5539
		[CompilerGenerated]
		private ObservableCollection<device_models> <MakerModels>k__BackingField;

		// Token: 0x040015A4 RID: 5540
		private bool _buzy;

		// Token: 0x040015A5 RID: 5541
		[CompilerGenerated]
		private device_models <SelectedModel>k__BackingField;

		// Token: 0x040015A6 RID: 5542
		[CompilerGenerated]
		private buyout <CustomerDocument>k__BackingField;

		// Token: 0x040015A7 RID: 5543
		private int? _documentId;

		// Token: 0x020003B8 RID: 952
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadMakers>d__47 : IAsyncStateMachine
		{
			// Token: 0x060027EA RID: 10218 RVA: 0x0007A5A0 File Offset: 0x000787A0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsBuyoutViewModel itemsBuyoutViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<IManufacturer>> awaiter;
					if (num != 0)
					{
						awaiter = itemsBuyoutViewModel._workshopService.GetManufacturers(this.device.CompanyList).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<IManufacturer>>, ItemsBuyoutViewModel.<LoadMakers>d__47>(ref awaiter, ref this);
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
					itemsBuyoutViewModel.Makers = new ObservableCollection<IManufacturer>(result);
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

			// Token: 0x060027EB RID: 10219 RVA: 0x0007A674 File Offset: 0x00078874
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040015A8 RID: 5544
			public int <>1__state;

			// Token: 0x040015A9 RID: 5545
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040015AA RID: 5546
			public ItemsBuyoutViewModel <>4__this;

			// Token: 0x040015AB RID: 5547
			public IDevice device;

			// Token: 0x040015AC RID: 5548
			private TaskAwaiter<IEnumerable<IManufacturer>> <>u__1;
		}

		// Token: 0x020003B9 RID: 953
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Load>d__64 : IAsyncStateMachine
		{
			// Token: 0x060027EC RID: 10220 RVA: 0x0007A690 File Offset: 0x00078890
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsBuyoutViewModel itemsBuyoutViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<docs> awaiter;
					TaskAwaiter<buyout> awaiter2;
					TaskAwaiter<clients> awaiter3;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<docs>);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<buyout>);
						this.<>1__state = -1;
						goto IL_114;
					case 2:
						awaiter3 = this.<>u__3;
						this.<>u__3 = default(TaskAwaiter<clients>);
						this.<>1__state = -1;
						goto IL_207;
					default:
						itemsBuyoutViewModel.SetViewName("RedemptionOfEquipment", this.documentId);
						awaiter = itemsBuyoutViewModel._buyoutService.GetBuyoutDocumentAsync(this.documentId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<docs>, ItemsBuyoutViewModel.<Load>d__64>(ref awaiter, ref this);
							return;
						}
						break;
					}
					docs result = awaiter.GetResult();
					itemsBuyoutViewModel.Document = result;
					this.<customerService>5__2 = Bootstrapper.Container.Resolve<ICustomerService>();
					awaiter2 = itemsBuyoutViewModel._buyoutService.GetByDocumentIdAsync(this.documentId).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<buyout>, ItemsBuyoutViewModel.<Load>d__64>(ref awaiter2, ref this);
						return;
					}
					IL_114:
					buyout result2 = awaiter2.GetResult();
					itemsBuyoutViewModel.CustomerDocument = result2;
					itemsBuyoutViewModel.Item = itemsBuyoutViewModel.Document.store_items.FirstOrDefault<store_items>();
					if (itemsBuyoutViewModel.CustomerDocument != null)
					{
						itemsBuyoutViewModel.SelectedType = itemsBuyoutViewModel.Devices.FirstOrDefault((IDevice i) => i.Id.Equals(base.CustomerDocument.device_id));
						itemsBuyoutViewModel.SelectedMaker = itemsBuyoutViewModel.Makers.FirstOrDefault((IManufacturer i) => i.Id.Equals(base.CustomerDocument.device_maker_id));
						itemsBuyoutViewModel.SelectedModel = itemsBuyoutViewModel.MakerModels.FirstOrDefault((device_models i) => i.id.Equals(base.CustomerDocument.device_model_id));
					}
					awaiter3 = this.<customerService>5__2.GetCustomerAsync(itemsBuyoutViewModel.Document.dealer.Value).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__3 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<clients>, ItemsBuyoutViewModel.<Load>d__64>(ref awaiter3, ref this);
						return;
					}
					IL_207:
					clients result3 = awaiter3.GetResult();
					itemsBuyoutViewModel.SetCustomer(result3.Client2CustomerCard());
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<customerService>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<customerService>5__2 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060027ED RID: 10221 RVA: 0x0007A910 File Offset: 0x00078B10
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040015AD RID: 5549
			public int <>1__state;

			// Token: 0x040015AE RID: 5550
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040015AF RID: 5551
			public ItemsBuyoutViewModel <>4__this;

			// Token: 0x040015B0 RID: 5552
			public int documentId;

			// Token: 0x040015B1 RID: 5553
			private ICustomerService <customerService>5__2;

			// Token: 0x040015B2 RID: 5554
			private TaskAwaiter<docs> <>u__1;

			// Token: 0x040015B3 RID: 5555
			private TaskAwaiter<buyout> <>u__2;

			// Token: 0x040015B4 RID: 5556
			private TaskAwaiter<clients> <>u__3;
		}

		// Token: 0x020003BA RID: 954
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnLoad>d__65 : IAsyncStateMachine
		{
			// Token: 0x060027EE RID: 10222 RVA: 0x0007A92C File Offset: 0x00078B2C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsBuyoutViewModel itemsBuyoutViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<IDevice>> awaiter;
					TaskAwaiter<List<stores>> awaiter2;
					TaskAwaiter<List<items_state>> awaiter3;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<IDevice>>);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<List<stores>>);
						this.<>1__state = -1;
						goto IL_137;
					case 2:
						awaiter3 = this.<>u__3;
						this.<>u__3 = default(TaskAwaiter<List<items_state>>);
						this.<>1__state = -1;
						goto IL_1E5;
					default:
						if (itemsBuyoutViewModel.ViewLoaded)
						{
							goto IL_247;
						}
						itemsBuyoutViewModel.ShowWait();
						itemsBuyoutViewModel.Documents = new List<string>
						{
							Lang.t("Passport"),
							Lang.t("DriversLicense")
						};
						itemsBuyoutViewModel.PhoneOptions = new PhoneOptions().GetAllOptions();
						awaiter = itemsBuyoutViewModel._workshopService.GetActiveDevices().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<IDevice>>, ItemsBuyoutViewModel.<OnLoad>d__65>(ref awaiter, ref this);
							return;
						}
						break;
					}
					IEnumerable<IDevice> result = awaiter.GetResult();
					itemsBuyoutViewModel.Devices = new List<IDevice>(result);
					awaiter2 = itemsBuyoutViewModel._storeService.GetStores().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<stores>>, ItemsBuyoutViewModel.<OnLoad>d__65>(ref awaiter2, ref this);
						return;
					}
					IL_137:
					List<stores> result2 = awaiter2.GetResult();
					itemsBuyoutViewModel.Stores = result2;
					if (itemsBuyoutViewModel.Stores != null)
					{
						if (itemsBuyoutViewModel.Stores.Count == 1)
						{
							stores stores = itemsBuyoutViewModel.Stores.FirstOrDefault<stores>();
							if (stores != null)
							{
								itemsBuyoutViewModel.Document.store = new int?(stores.id);
							}
							itemsBuyoutViewModel.StoreChanged();
						}
					}
					awaiter3 = ItemsModel.LoadItemStates(false).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__3 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<items_state>>, ItemsBuyoutViewModel.<OnLoad>d__65>(ref awaiter3, ref this);
						return;
					}
					IL_1E5:
					List<items_state> result3 = awaiter3.GetResult();
					itemsBuyoutViewModel.States = new ObservableCollection<items_state>(result3);
					itemsBuyoutViewModel.LoadPaymentOptions();
					if (itemsBuyoutViewModel._documentId != null)
					{
						itemsBuyoutViewModel.Load(itemsBuyoutViewModel._documentId.Value);
					}
					itemsBuyoutViewModel.HideWait();
					itemsBuyoutViewModel.SetViewLoaded(true);
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_247:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060027EF RID: 10223 RVA: 0x0007ABB0 File Offset: 0x00078DB0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040015B5 RID: 5557
			public int <>1__state;

			// Token: 0x040015B6 RID: 5558
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040015B7 RID: 5559
			public ItemsBuyoutViewModel <>4__this;

			// Token: 0x040015B8 RID: 5560
			private TaskAwaiter<IEnumerable<IDevice>> <>u__1;

			// Token: 0x040015B9 RID: 5561
			private TaskAwaiter<List<stores>> <>u__2;

			// Token: 0x040015BA RID: 5562
			private TaskAwaiter<List<items_state>> <>u__3;
		}

		// Token: 0x020003BB RID: 955
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadModels>d__67 : IAsyncStateMachine
		{
			// Token: 0x060027F0 RID: 10224 RVA: 0x0007ABCC File Offset: 0x00078DCC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsBuyoutViewModel itemsBuyoutViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<device_models>> awaiter;
					if (num != 0)
					{
						if (itemsBuyoutViewModel.SelectedMaker == null)
						{
							goto IL_B9;
						}
						awaiter = itemsBuyoutViewModel._workshopService.GetModels(itemsBuyoutViewModel.SelectedMaker.Id, itemsBuyoutViewModel.SelectedType.Id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<device_models>>, ItemsBuyoutViewModel.<LoadModels>d__67>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<device_models>>);
						this.<>1__state = -1;
					}
					List<device_models> result = awaiter.GetResult();
					itemsBuyoutViewModel.MakerModels = new ObservableCollection<device_models>(result);
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_B9:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060027F1 RID: 10225 RVA: 0x0007ACB8 File Offset: 0x00078EB8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040015BB RID: 5563
			public int <>1__state;

			// Token: 0x040015BC RID: 5564
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040015BD RID: 5565
			public ItemsBuyoutViewModel <>4__this;

			// Token: 0x040015BE RID: 5566
			private TaskAwaiter<List<device_models>> <>u__1;
		}

		// Token: 0x020003BC RID: 956
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SelectCustomerFromList>d__71 : IAsyncStateMachine
		{
			// Token: 0x060027F2 RID: 10226 RVA: 0x0007ACD4 File Offset: 0x00078ED4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsBuyoutViewModel itemsBuyoutViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						itemsBuyoutViewModel.SwithEnableSearch();
						awaiter = itemsBuyoutViewModel.SetCustomer(this.customer.Id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ItemsBuyoutViewModel.<SelectCustomerFromList>d__71>(ref awaiter, ref this);
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
					itemsBuyoutViewModel.UseClientData();
					itemsBuyoutViewModel.HideMatchShowOpenCard();
					itemsBuyoutViewModel.SwithEnableSearch();
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

			// Token: 0x060027F3 RID: 10227 RVA: 0x0007ADAC File Offset: 0x00078FAC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040015BF RID: 5567
			public int <>1__state;

			// Token: 0x040015C0 RID: 5568
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040015C1 RID: 5569
			public ItemsBuyoutViewModel <>4__this;

			// Token: 0x040015C2 RID: 5570
			public ICustomer customer;

			// Token: 0x040015C3 RID: 5571
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020003BD RID: 957
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Print>d__72 : IAsyncStateMachine
		{
			// Token: 0x060027F4 RID: 10228 RVA: 0x0007ADC8 File Offset: 0x00078FC8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsBuyoutViewModel itemsBuyoutViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<XtraReport> awaiter;
					if (num != 0)
					{
						itemsBuyoutViewModel.ShowWait();
						awaiter = itemsBuyoutViewModel._buyoutService.CreateReport(itemsBuyoutViewModel.Document.id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XtraReport>, ItemsBuyoutViewModel.<Print>d__72>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<XtraReport>);
						this.<>1__state = -1;
					}
					XtraReport result = awaiter.GetResult();
					itemsBuyoutViewModel.HideWait();
					itemsBuyoutViewModel._reportPrintService.PrintPreview(result, PrinterModel.Printer.Documents);
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

			// Token: 0x060027F5 RID: 10229 RVA: 0x0007AEA8 File Offset: 0x000790A8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040015C4 RID: 5572
			public int <>1__state;

			// Token: 0x040015C5 RID: 5573
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040015C6 RID: 5574
			public ItemsBuyoutViewModel <>4__this;

			// Token: 0x040015C7 RID: 5575
			private TaskAwaiter<XtraReport> <>u__1;
		}

		// Token: 0x020003BE RID: 958
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <MakeOrder>d__74 : IAsyncStateMachine
		{
			// Token: 0x060027F6 RID: 10230 RVA: 0x0007AEC4 File Offset: 0x000790C4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsBuyoutViewModel itemsBuyoutViewModel = this.<>4__this;
				try
				{
					if (num > 2)
					{
						if (!itemsBuyoutViewModel.CheckFields(itemsBuyoutViewModel.Document, itemsBuyoutViewModel.Item, itemsBuyoutViewModel.Customer))
						{
							goto IL_37E;
						}
						if (!itemsBuyoutViewModel.CheckCustomerFields(itemsBuyoutViewModel.Customer))
						{
							goto IL_37E;
						}
						if (itemsBuyoutViewModel.CustomerDocument.name == Lang.t("Passport"))
						{
							itemsBuyoutViewModel.Customer.PassportOrgan = itemsBuyoutViewModel.CustomerDocument.authority;
							itemsBuyoutViewModel.Customer.PassportNum = itemsBuyoutViewModel.CustomerDocument.number;
						}
						itemsBuyoutViewModel._buzy = true;
						itemsBuyoutViewModel.RaiseCanExecuteChanged(() => itemsBuyoutViewModel.MakeOrder());
						itemsBuyoutViewModel.Item.name = itemsBuyoutViewModel._buyoutService.ConstructName(itemsBuyoutViewModel.SelectedType.Name, itemsBuyoutViewModel.SelectedMaker.Name, itemsBuyoutViewModel.SelectedModel.name);
						itemsBuyoutViewModel.ShowWait();
						itemsBuyoutViewModel.CustomerDocument.device_id = itemsBuyoutViewModel.SelectedType.Id;
						itemsBuyoutViewModel.CustomerDocument.device_maker_id = itemsBuyoutViewModel.SelectedMaker.Id;
					}
					try
					{
						TaskAwaiter<int> awaiter;
						TaskAwaiter<XtraReport> awaiter2;
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
							goto IL_2A0;
						}
						case 2:
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<XtraReport>);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
							goto IL_322;
						}
						default:
							if (itemsBuyoutViewModel.SelectedModel.id != 0)
							{
								itemsBuyoutViewModel.CustomerDocument.device_model_id = itemsBuyoutViewModel.SelectedModel.id;
								goto IL_21B;
							}
							this.<>7__wrap1 = itemsBuyoutViewModel.CustomerDocument;
							awaiter = itemsBuyoutViewModel._deviceModelService.CreateDeviceModel(itemsBuyoutViewModel.CustomerDocument.device_id, itemsBuyoutViewModel.CustomerDocument.device_maker_id, itemsBuyoutViewModel.SelectedModel.name.Trim()).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num5 = 0;
								num = 0;
								this.<>1__state = num5;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, ItemsBuyoutViewModel.<MakeOrder>d__74>(ref awaiter, ref this);
								return;
							}
							break;
						}
						int result = awaiter.GetResult();
						this.<>7__wrap1.device_model_id = result;
						this.<>7__wrap1 = null;
						IL_21B:
						this.<>7__wrap2 = itemsBuyoutViewModel.Document;
						awaiter = itemsBuyoutViewModel._buyoutService.MakeBuyout(itemsBuyoutViewModel.Document, itemsBuyoutViewModel.Item, itemsBuyoutViewModel.Customer.Customer2Client(), itemsBuyoutViewModel.CustomerDocument).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num6 = 1;
							num = 1;
							this.<>1__state = num6;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, ItemsBuyoutViewModel.<MakeOrder>d__74>(ref awaiter, ref this);
							return;
						}
						IL_2A0:
						result = awaiter.GetResult();
						this.<>7__wrap2.id = result;
						this.<>7__wrap2 = null;
						awaiter2 = itemsBuyoutViewModel._buyoutService.CreateReport(itemsBuyoutViewModel.Document.id).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num7 = 2;
							num = 2;
							this.<>1__state = num7;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XtraReport>, ItemsBuyoutViewModel.<MakeOrder>d__74>(ref awaiter2, ref this);
							return;
						}
						IL_322:
						XtraReport result2 = awaiter2.GetResult();
						itemsBuyoutViewModel._reportPrintService.PrintPreview(result2, PrinterModel.Printer.Documents);
					}
					catch (Exception ex)
					{
						itemsBuyoutViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							itemsBuyoutViewModel.HideWait();
							itemsBuyoutViewModel._buzy = false;
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_37E:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060027F7 RID: 10231 RVA: 0x0007B2B0 File Offset: 0x000794B0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040015C8 RID: 5576
			public int <>1__state;

			// Token: 0x040015C9 RID: 5577
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040015CA RID: 5578
			public ItemsBuyoutViewModel <>4__this;

			// Token: 0x040015CB RID: 5579
			private buyout <>7__wrap1;

			// Token: 0x040015CC RID: 5580
			private TaskAwaiter<int> <>u__1;

			// Token: 0x040015CD RID: 5581
			private docs <>7__wrap2;

			// Token: 0x040015CE RID: 5582
			private TaskAwaiter<XtraReport> <>u__2;
		}

		// Token: 0x020003BF RID: 959
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <StoreChanged>d__77 : IAsyncStateMachine
		{
			// Token: 0x060027F8 RID: 10232 RVA: 0x0007B2CC File Offset: 0x000794CC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsBuyoutViewModel itemsBuyoutViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<boxes>> awaiter;
					TaskAwaiter<List<store_cats>> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<List<boxes>>);
							this.<>1__state = -1;
							goto IL_13E;
						}
						if (itemsBuyoutViewModel.Document.store != null)
						{
							int? store = itemsBuyoutViewModel.Document.store;
							if (!(store.GetValueOrDefault() == 0 & store != null))
							{
								awaiter2 = itemsBuyoutViewModel._storeService.GetCategoriesAsync(itemsBuyoutViewModel.Document.store.Value).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									this.<>1__state = 0;
									this.<>u__1 = awaiter2;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_cats>>, ItemsBuyoutViewModel.<StoreChanged>d__77>(ref awaiter2, ref this);
									return;
								}
								goto IL_E3;
							}
						}
						goto IL_16A;
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<store_cats>>);
						this.<>1__state = -1;
					}
					IL_E3:
					List<store_cats> result = awaiter2.GetResult();
					itemsBuyoutViewModel.StoreCategories = result;
					awaiter = StoreModel.LoadBoxes(itemsBuyoutViewModel.Document.store.Value, false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<boxes>>, ItemsBuyoutViewModel.<StoreChanged>d__77>(ref awaiter, ref this);
						return;
					}
					IL_13E:
					List<boxes> result2 = awaiter.GetResult();
					itemsBuyoutViewModel.Boxes = result2;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_16A:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060027F9 RID: 10233 RVA: 0x0007B474 File Offset: 0x00079674
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040015CF RID: 5583
			public int <>1__state;

			// Token: 0x040015D0 RID: 5584
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040015D1 RID: 5585
			public ItemsBuyoutViewModel <>4__this;

			// Token: 0x040015D2 RID: 5586
			private TaskAwaiter<List<store_cats>> <>u__1;

			// Token: 0x040015D3 RID: 5587
			private TaskAwaiter<List<boxes>> <>u__2;
		}

		// Token: 0x020003C0 RID: 960
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <MakersChanged>d__79 : IAsyncStateMachine
		{
			// Token: 0x060027FA RID: 10234 RVA: 0x0007B490 File Offset: 0x00079690
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsBuyoutViewModel itemsBuyoutViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<device_models>> awaiter;
					if (num != 0)
					{
						awaiter = itemsBuyoutViewModel._workshopService.GetModels(itemsBuyoutViewModel.SelectedMaker.Id, itemsBuyoutViewModel.SelectedType.Id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<device_models>>, ItemsBuyoutViewModel.<MakersChanged>d__79>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<device_models>>);
						this.<>1__state = -1;
					}
					List<device_models> result = awaiter.GetResult();
					itemsBuyoutViewModel.MakerModels = new ObservableCollection<device_models>(result);
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

			// Token: 0x060027FB RID: 10235 RVA: 0x0007B56C File Offset: 0x0007976C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040015D4 RID: 5588
			public int <>1__state;

			// Token: 0x040015D5 RID: 5589
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040015D6 RID: 5590
			public ItemsBuyoutViewModel <>4__this;

			// Token: 0x040015D7 RID: 5591
			private TaskAwaiter<List<device_models>> <>u__1;
		}

		// Token: 0x020003C1 RID: 961
		[CompilerGenerated]
		private sealed class <>c__DisplayClass85_0
		{
			// Token: 0x060027FC RID: 10236 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass85_0()
			{
			}

			// Token: 0x060027FD RID: 10237 RVA: 0x0007B588 File Offset: 0x00079788
			internal bool <SelectRepairFromList>b__0(IDevice d)
			{
				return d.Id == this.repairInfo.TypeId;
			}

			// Token: 0x060027FE RID: 10238 RVA: 0x0007B5A8 File Offset: 0x000797A8
			internal bool <SelectRepairFromList>b__1(IManufacturer m)
			{
				return m.Id == this.repairInfo.MakerId;
			}

			// Token: 0x060027FF RID: 10239 RVA: 0x0007B5C8 File Offset: 0x000797C8
			internal bool <SelectRepairFromList>b__2(device_models mm)
			{
				int id = mm.id;
				int? modelId = this.repairInfo.ModelId;
				return id == modelId.GetValueOrDefault() & modelId != null;
			}

			// Token: 0x040015D8 RID: 5592
			public PreviousRepair repairInfo;
		}

		// Token: 0x020003C2 RID: 962
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SelectRepairFromList>d__85 : IAsyncStateMachine
		{
			// Token: 0x06002800 RID: 10240 RVA: 0x0007B5F8 File Offset: 0x000797F8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsBuyoutViewModel itemsBuyoutViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter<PreviousRepair> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter);
							this.<>1__state = -1;
							goto IL_E3;
						}
						this.<>8__1 = new ItemsBuyoutViewModel.<>c__DisplayClass85_0();
						awaiter2 = itemsBuyoutViewModel._workshopService.GetRepairInfo(this.repair.RepairId).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<PreviousRepair>, ItemsBuyoutViewModel.<SelectRepairFromList>d__85>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<PreviousRepair>);
						this.<>1__state = -1;
					}
					PreviousRepair result = awaiter2.GetResult();
					this.<>8__1.repairInfo = result;
					awaiter = itemsBuyoutViewModel.SetCustomer(this.<>8__1.repairInfo.CustomerId).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ItemsBuyoutViewModel.<SelectRepairFromList>d__85>(ref awaiter, ref this);
						return;
					}
					IL_E3:
					awaiter.GetResult();
					itemsBuyoutViewModel.SelectedType = itemsBuyoutViewModel.Devices.FirstOrDefault(new Func<IDevice, bool>(this.<>8__1.<SelectRepairFromList>b__0));
					itemsBuyoutViewModel.SelectedMaker = itemsBuyoutViewModel.Makers.FirstOrDefault(new Func<IManufacturer, bool>(this.<>8__1.<SelectRepairFromList>b__1));
					itemsBuyoutViewModel.SelectedModel = itemsBuyoutViewModel.MakerModels.FirstOrDefault(new Func<device_models, bool>(this.<>8__1.<SelectRepairFromList>b__2));
					itemsBuyoutViewModel.Item.SN = this.<>8__1.repairInfo.SerialNumber;
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

			// Token: 0x06002801 RID: 10241 RVA: 0x0007B7EC File Offset: 0x000799EC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040015D9 RID: 5593
			public int <>1__state;

			// Token: 0x040015DA RID: 5594
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040015DB RID: 5595
			public ItemsBuyoutViewModel <>4__this;

			// Token: 0x040015DC RID: 5596
			public WorkshopLite repair;

			// Token: 0x040015DD RID: 5597
			private ItemsBuyoutViewModel.<>c__DisplayClass85_0 <>8__1;

			// Token: 0x040015DE RID: 5598
			private TaskAwaiter<PreviousRepair> <>u__1;

			// Token: 0x040015DF RID: 5599
			private TaskAwaiter <>u__2;
		}
	}
}
