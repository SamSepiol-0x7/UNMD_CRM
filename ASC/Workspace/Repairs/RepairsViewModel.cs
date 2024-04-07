using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Data.Entity.Core;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using ASC.Common.Enum;
using ASC.Common.Models;
using ASC.Common.Objects;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Options;
using ASC.Properties;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using ASC.ViewModels;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.Workspace.Repairs
{
	// Token: 0x0200011B RID: 283
	public class RepairsViewModel : CollectionViewModel<WorkshopLite>, IReturnOnSelect
	{
		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06001449 RID: 5193 RVA: 0x0002DD34 File Offset: 0x0002BF34
		// (set) Token: 0x0600144A RID: 5194 RVA: 0x0002DD48 File Offset: 0x0002BF48
		public List<WorkshopOptions> WorkshopOptions
		{
			[CompilerGenerated]
			get
			{
				return this.<WorkshopOptions>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<WorkshopOptions>k__BackingField, value))
				{
					return;
				}
				this.<WorkshopOptions>k__BackingField = value;
				this.RaisePropertyChanged("WorkshopOptions");
			}
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x0600144B RID: 5195 RVA: 0x0002DD78 File Offset: 0x0002BF78
		// (set) Token: 0x0600144C RID: 5196 RVA: 0x0002DD8C File Offset: 0x0002BF8C
		public new ObservableCollection<WorkshopLite> SelectedItems
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedItems>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedItems>k__BackingField, value))
				{
					return;
				}
				this.<SelectedItems>k__BackingField = value;
				this.RaisePropertyChanged("SelectedItems");
			}
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x0600144D RID: 5197 RVA: 0x0002DDBC File Offset: 0x0002BFBC
		// (set) Token: 0x0600144E RID: 5198 RVA: 0x0002DDD0 File Offset: 0x0002BFD0
		public ObservableCollection<ClientTypes> CustomerTypes
		{
			[CompilerGenerated]
			get
			{
				return this.<CustomerTypes>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				if (object.Equals(this.<CustomerTypes>k__BackingField, value))
				{
					return;
				}
				this.<CustomerTypes>k__BackingField = value;
				this.RaisePropertyChanged("CustomerTypes");
			}
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x0600144F RID: 5199 RVA: 0x0002DE00 File Offset: 0x0002C000
		// (set) Token: 0x06001450 RID: 5200 RVA: 0x0002DE14 File Offset: 0x0002C014
		public int FocusedRow
		{
			[CompilerGenerated]
			get
			{
				return this.<FocusedRow>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<FocusedRow>k__BackingField == value)
				{
					return;
				}
				this.<FocusedRow>k__BackingField = value;
				this.RaisePropertyChanged("FocusedRow");
			}
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06001451 RID: 5201 RVA: 0x0002DE40 File Offset: 0x0002C040
		// (set) Token: 0x06001452 RID: 5202 RVA: 0x0002DE84 File Offset: 0x0002C084
		public bool Mode
		{
			get
			{
				return base.GetProperty<bool>(() => this.Mode);
			}
			set
			{
				if (this.Mode == value)
				{
					return;
				}
				base.SetProperty<bool>(() => this.Mode, value, new Action(this.OnModeChanged));
				this.RaisePropertyChanged("Mode");
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06001453 RID: 5203 RVA: 0x0002DEEC File Offset: 0x0002C0EC
		// (set) Token: 0x06001454 RID: 5204 RVA: 0x0002DF00 File Offset: 0x0002C100
		public List<UserMaster> Users
		{
			[CompilerGenerated]
			get
			{
				return this.<Users>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				if (!object.Equals(this.<Users>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 687321324;
				IL_13:
				switch ((num ^ 329980545) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					return;
				case 2:
					IL_32:
					this.<Users>k__BackingField = value;
					this.RaisePropertyChanged("Users");
					num = 89592922;
					goto IL_13;
				}
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06001455 RID: 5205 RVA: 0x0002DF5C File Offset: 0x0002C15C
		// (set) Token: 0x06001456 RID: 5206 RVA: 0x0002DF70 File Offset: 0x0002C170
		public List<Warranty> WarrantyList
		{
			[CompilerGenerated]
			get
			{
				return this.<WarrantyList>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				if (object.Equals(this.<WarrantyList>k__BackingField, value))
				{
					return;
				}
				this.<WarrantyList>k__BackingField = value;
				this.RaisePropertyChanged("WarrantyList");
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06001457 RID: 5207 RVA: 0x0002DFA0 File Offset: 0x0002C1A0
		// (set) Token: 0x06001458 RID: 5208 RVA: 0x0002DFB4 File Offset: 0x0002C1B4
		public bool ReturnOnSelect
		{
			[CompilerGenerated]
			get
			{
				return this.<ReturnOnSelect>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ReturnOnSelect>k__BackingField == value)
				{
					return;
				}
				this.<ReturnOnSelect>k__BackingField = value;
				this.RaisePropertyChanged("ReturnOnSelect");
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06001459 RID: 5209 RVA: 0x0002DFE0 File Offset: 0x0002C1E0
		public bool CanOfficeSelect
		{
			get
			{
				return OfflineData.Instance.Employee.Can(23, 0);
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x0600145A RID: 5210 RVA: 0x0002DFE0 File Offset: 0x0002C1E0
		private bool OpenOtherUserCards
		{
			get
			{
				return OfflineData.Instance.Employee.Can(23, 0);
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x0600145B RID: 5211 RVA: 0x0002E000 File Offset: 0x0002C200
		public bool CanUserSelect
		{
			get
			{
				return this.OpenOtherUserCards && !this.OnlyMyOrders;
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x0600145C RID: 5212 RVA: 0x0002E020 File Offset: 0x0002C220
		// (set) Token: 0x0600145D RID: 5213 RVA: 0x0002E034 File Offset: 0x0002C234
		public bool OutDateVisibility
		{
			[CompilerGenerated]
			get
			{
				return this.<OutDateVisibility>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<OutDateVisibility>k__BackingField == value)
				{
					return;
				}
				this.<OutDateVisibility>k__BackingField = value;
				this.RaisePropertyChanged("OutDateVisibility");
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x0600145E RID: 5214 RVA: 0x0002E060 File Offset: 0x0002C260
		// (set) Token: 0x0600145F RID: 5215 RVA: 0x0002E078 File Offset: 0x0002C278
		public bool OnlyMyOrders
		{
			get
			{
				return Settings.Default.OnlyMyOrders;
			}
			set
			{
				if (this.OnlyMyOrders == value)
				{
					return;
				}
				Settings.Default.OnlyMyOrders = value;
				this.RaisePropertyChanged("CanUserSelect");
				this.RaisePropertyChanged("OnlyMyOrders");
			}
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06001460 RID: 5216 RVA: 0x0002E0B4 File Offset: 0x0002C2B4
		// (set) Token: 0x06001461 RID: 5217 RVA: 0x0002E0C8 File Offset: 0x0002C2C8
		public int SelectedStatus
		{
			get
			{
				return this._selectedStatus;
			}
			set
			{
				if (this._selectedStatus == value)
				{
					return;
				}
				this._selectedStatus = value;
				this.RaisePropertyChanged("SelectedStatus");
				if (this._selectedStatus != 8)
				{
					this.SelectedWarrantyOption = 0;
				}
				this.SelectedWarrantyOption = ((value == 8) ? 14 : 0);
			}
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06001462 RID: 5218 RVA: 0x0002E114 File Offset: 0x0002C314
		// (set) Token: 0x06001463 RID: 5219 RVA: 0x0002E128 File Offset: 0x0002C328
		public int SelectedOffice
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedOffice>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedOffice>k__BackingField == value)
				{
					return;
				}
				this.<SelectedOffice>k__BackingField = value;
				this.RaisePropertyChanged("SelectedOffice");
			}
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06001464 RID: 5220 RVA: 0x0002E154 File Offset: 0x0002C354
		// (set) Token: 0x06001465 RID: 5221 RVA: 0x0002E168 File Offset: 0x0002C368
		public int SelectedUserFilter
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedUserFilter>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedUserFilter>k__BackingField == value)
				{
					return;
				}
				this.<SelectedUserFilter>k__BackingField = value;
				this.RaisePropertyChanged("SelectedUserFilter");
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06001466 RID: 5222 RVA: 0x0002E194 File Offset: 0x0002C394
		// (set) Token: 0x06001467 RID: 5223 RVA: 0x0002E1A8 File Offset: 0x0002C3A8
		public int SelectedWarrantyOption
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedWarrantyOption>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedWarrantyOption>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -1909168050;
				IL_10:
				switch ((num ^ -305313893) % 4)
				{
				case 0:
					goto IL_0B;
				case 1:
					return;
				case 3:
					IL_2F:
					num = -1410932059;
					goto IL_10;
				}
				this.<SelectedWarrantyOption>k__BackingField = value;
				this.RaisePropertyChanged("SelectedWarrantyOption");
			}
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06001468 RID: 5224 RVA: 0x0002E200 File Offset: 0x0002C400
		// (set) Token: 0x06001469 RID: 5225 RVA: 0x0002E214 File Offset: 0x0002C414
		public int SelectedCustomerType
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedCustomerType>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedCustomerType>k__BackingField == value)
				{
					return;
				}
				this.<SelectedCustomerType>k__BackingField = value;
				this.RaisePropertyChanged("SelectedCustomerType");
			}
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x0002E240 File Offset: 0x0002C440
		public RepairsViewModel()
		{
			this.SetViewName("Repairs");
			this._customerService = Bootstrapper.Container.Resolve<ICustomerService>();
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._ascMessageBoxService = Bootstrapper.Container.Resolve<IAscMessageBoxService>();
			this.CustomerTypes = new ObservableCollection<ClientTypes>((List<ClientTypes>)this._customerService.GetCustomerTypes());
			this.SelectedCustomerType = 3;
			this.SelectedItems = new ObservableCollection<WorkshopLite>();
			this.SelectedItems.CollectionChanged += this.SelectedItemsOnCollectionChanged;
			this.WorkshopOptions = new WorkshopOptions().GetAllOptionsWithDummy();
			this.SetUserDefaults();
			this.BgInitDoWork();
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x0002E31C File Offset: 0x0002C51C
		public void MakeReturnOnSelect()
		{
			this.SetViewName("Select", "Repair");
			this.ReturnOnSelect = true;
			this.DisplayOnlyOutRepairs();
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x0002E348 File Offset: 0x0002C548
		public RepairsViewModel(WorkshopStatus status) : this()
		{
			this.SetViewName("Select", "Repair");
			this.ReturnOnSelect = true;
			this.SelectedStatus = (int)status;
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x0002E37C File Offset: 0x0002C57C
		private void SetUserDefaults()
		{
			this.SelectedOffice = (OfflineData.Instance.Employee.Can(23, 0) ? OfflineData.Instance.Employee.WorkshopDefaultOffice : OfflineData.Instance.Employee.OfficeId);
			this.SelectedStatus = ((OfflineData.Instance.Employee.WorkshopDefaultStatus == null) ? 99 : OfflineData.Instance.Employee.WorkshopDefaultStatus.Value);
			this.SelectedUserFilter = (OfflineData.Instance.Employee.Can(23, 0) ? OfflineData.Instance.Employee.WorkshopDefaultEmployee : OfflineData.Instance.Employee.Id);
			this.Mode = (OfflineData.Instance.Employee.WorkshopDefDevType == 2);
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x0002E450 File Offset: 0x0002C650
		private void SelectedItemsOnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			base.RaiseCanExecuteChanged(() => this.RefillItems());
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x0002E498 File Offset: 0x0002C698
		private void BgInitDoWork()
		{
			Task.Run<IEnumerable<UserMaster>>(() => UsersModel.LoadMasterManagers()).ContinueWith(delegate(Task<IEnumerable<UserMaster>> t)
			{
				this.Users = new List<UserMaster>(t.Result);
			});
			this.WarrantyList = WarrantyOptions.GetAll();
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x0002E4E8 File Offset: 0x0002C6E8
		private void InitRefreshTimer()
		{
			if (Auth.User.auto_refresh_workspace)
			{
				int period = (Auth.User.refresh_time > 8) ? (Auth.User.refresh_time * 1000) : 8000;
				this._refreshTimer = new Timer(new TimerCallback(this.RefreshTick), null, 0, period);
				return;
			}
			this.LoadRepairs(base.SearchString);
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x0002E550 File Offset: 0x0002C750
		public override void OnUnload()
		{
			base.OnUnload();
			base.SetViewLoaded(false);
			Timer refreshTimer = this._refreshTimer;
			if (refreshTimer != null)
			{
				refreshTimer.Dispose();
				return;
			}
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x0002E57C File Offset: 0x0002C77C
		public override void OnLoad()
		{
			base.OnLoad();
			base.SetViewLoaded(true);
			this.InitRefreshTimer();
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x0002E59C File Offset: 0x0002C79C
		public void DisplayOnlyOutRepairs()
		{
			this.SelectedStatus = 8;
			this.SelectedWarrantyOption = 124;
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x0002E5B8 File Offset: 0x0002C7B8
		private void RefreshTick(object state)
		{
			if (this.SelectedItems != null && this.SelectedItems.Any<WorkshopLite>())
			{
				return;
			}
			this.LoadRepairs(base.SearchString);
			this.OutDateVisibility_();
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x0002E5F0 File Offset: 0x0002C7F0
		protected override void OnSearchStringChanged(string oldValue)
		{
			base.ShowWait();
			this.LoadRepairs(base.SearchString);
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x0002E610 File Offset: 0x0002C810
		private void LoadRepairs(string filter)
		{
			RepairsViewModel.<LoadRepairs>d__84 <LoadRepairs>d__;
			<LoadRepairs>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadRepairs>d__.<>4__this = this;
			<LoadRepairs>d__.filter = filter;
			<LoadRepairs>d__.<>1__state = -1;
			<LoadRepairs>d__.<>t__builder.Start<RepairsViewModel.<LoadRepairs>d__84>(ref <LoadRepairs>d__);
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x0002E650 File Offset: 0x0002C850
		private void OutDateVisibility_()
		{
			if (Auth.User.display_out)
			{
				goto IL_51;
			}
			IL_0C:
			this.OutDateVisibility = (this.SelectedStatus == 8 && Auth.User.IsFieldVisible("ws_vis_date"));
			int num = 1467682629;
			IL_32:
			switch ((num ^ 1979836922) % 4)
			{
			case 0:
				IL_51:
				num = 695555772;
				goto IL_32;
			case 1:
				goto IL_0C;
			case 2:
				this.OutDateVisibility = true;
				return;
			}
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x0002E6C0 File Offset: 0x0002C8C0
		[Command]
		public void RepairDoubleClick()
		{
			if (base.SelectedItem == null)
			{
				return;
			}
			if (this.ReturnOnSelect)
			{
				IRepairSelect parentViewModel = this._parentViewModel;
				if (parentViewModel != null)
				{
					parentViewModel.SelectRepairFromList(base.SelectedItem);
				}
				this._navigationService.CloseCurrentTab();
				return;
			}
			if (base.SelectedItem.CartridgeId == null)
			{
				this._navigationService.NavigateRepairCard(base.SelectedItem.RepairId);
			}
			else
			{
				this._navigationService.NavigateRepairCartridge(base.SelectedItem.RepairId);
			}
			ObservableCollection<WorkshopLite> selectedItems = this.SelectedItems;
			if (selectedItems != null)
			{
				selectedItems.Clear();
				return;
			}
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x0002E754 File Offset: 0x0002C954
		private void OnModeChanged()
		{
			if (base.ViewLoaded)
			{
				base.ShowWait();
				this.LoadRepairs(base.SearchString);
			}
		}

		// Token: 0x0600147A RID: 5242 RVA: 0x0002E77C File Offset: 0x0002C97C
		[Command]
		public void RefreshOrders()
		{
			this.LoadRepairs(base.SearchString);
			this.OutDateVisibility_();
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x0002E79C File Offset: 0x0002C99C
		protected override void OnParentViewModelChanged(object parentViewModel)
		{
			base.OnParentViewModelChanged(parentViewModel);
			this._parentViewModel = (parentViewModel as IRepairSelect);
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x0002E7BC File Offset: 0x0002C9BC
		[Command]
		public void OpenCustomerCard()
		{
			this._navigationService.NavigateToCustomerCard(base.SelectedItem.ClientId, null);
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x0002E7E0 File Offset: 0x0002C9E0
		public bool CanOpenCustomerCard()
		{
			return base.SelectedItem != null && OfflineData.Instance.Employee.Can(7, 0);
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x0002E808 File Offset: 0x0002CA08
		[Command]
		public void CreateInvoice()
		{
			this._navigationService.NavigateCreateInvoice(base.SelectedItem);
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x0002E828 File Offset: 0x0002CA28
		public bool CanCreateInvoice()
		{
			return base.SelectedItem != null && OfflineData.Instance.Employee.Can(65, 0) && base.IsValid();
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x0002E85C File Offset: 0x0002CA5C
		[Command]
		public void RefillItems()
		{
			if (this.SelectedItems == null)
			{
				goto IL_A1;
			}
			IL_0B:
			List<int> list = (from i in this.SelectedItems
			where i.CartridgeId != null
			select i.RepairId).ToList<int>();
			int num = list.Any<int>() ? 866093980 : 19537887;
			IL_7E:
			switch ((num ^ 168692859) % 5)
			{
			case 0:
				return;
			case 1:
				goto IL_0B;
			case 2:
				return;
			case 4:
				IL_A1:
				num = 278309701;
				goto IL_7E;
			}
			this._navigationService.NavigateRepairCartridges(list);
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x0002E920 File Offset: 0x0002CB20
		public bool CanRefillItems()
		{
			if (this.SelectedItems != null)
			{
				return this.SelectedItems.Any((WorkshopLite i) => i.CartridgeId != null);
			}
			return false;
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x0002E964 File Offset: 0x0002CB64
		[Command]
		public void AcceptNew()
		{
			if (this.Mode)
			{
				this._navigationService.NavigateNewRepair();
				return;
			}
			this._navigationService.NavigateNewCartridge();
		}

		// Token: 0x06001483 RID: 5251 RVA: 0x0002E990 File Offset: 0x0002CB90
		public bool CanAcceptNew()
		{
			if (this.Mode)
			{
				return base.IsValid() && OfflineData.Instance.Employee.Can(2, 0);
			}
			return base.IsValid() && OfflineData.Instance.Employee.Can(2, 0) && Auth.Config.cartridge_enable;
		}

		// Token: 0x06001484 RID: 5252 RVA: 0x0002E9E8 File Offset: 0x0002CBE8
		[Command]
		public void Delete()
		{
			RepairsViewModel.<Delete>d__98 <Delete>d__;
			<Delete>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Delete>d__.<>4__this = this;
			<Delete>d__.<>1__state = -1;
			<Delete>d__.<>t__builder.Start<RepairsViewModel.<Delete>d__98>(ref <Delete>d__);
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x0002EA20 File Offset: 0x0002CC20
		public bool CanDelete()
		{
			return base.SelectedItem != null && !this.ReturnOnSelect && OfflineData.Instance.Employee.Can(1, 0);
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x0002EA50 File Offset: 0x0002CC50
		[CompilerGenerated]
		private void <BgInitDoWork>b__77_1(Task<IEnumerable<UserMaster>> t)
		{
			this.Users = new List<UserMaster>(t.Result);
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x0002EA70 File Offset: 0x0002CC70
		[CompilerGenerated]
		private void <LoadRepairs>b__84_2()
		{
			this._serverInfo.SetServerUnreachable();
			if (this._ascMessageBoxService.ShowMessageBox("Потеряно соединение с сервером.", "Server unreachable", MessageBoxButton.OK, MessageBoxImage.Hand) == MessageBoxResult.OK)
			{
				this._serverInfo.SetServerReachable();
			}
		}

		// Token: 0x040009DB RID: 2523
		private IRepairSelect _parentViewModel;

		// Token: 0x040009DC RID: 2524
		protected ICustomerService _customerService;

		// Token: 0x040009DD RID: 2525
		private readonly INavigationService _navigationService;

		// Token: 0x040009DE RID: 2526
		private readonly IToasterService _toasterService;

		// Token: 0x040009DF RID: 2527
		private readonly IAscMessageBoxService _ascMessageBoxService;

		// Token: 0x040009E0 RID: 2528
		private WorkspaceModel _WorkspaceModel = new WorkspaceModel();

		// Token: 0x040009E1 RID: 2529
		private ServerInfo _serverInfo = ServerInfo.Instance;

		// Token: 0x040009E2 RID: 2530
		[CompilerGenerated]
		private List<WorkshopOptions> <WorkshopOptions>k__BackingField;

		// Token: 0x040009E3 RID: 2531
		[CompilerGenerated]
		private ObservableCollection<WorkshopLite> <SelectedItems>k__BackingField;

		// Token: 0x040009E4 RID: 2532
		[CompilerGenerated]
		private ObservableCollection<ClientTypes> <CustomerTypes>k__BackingField;

		// Token: 0x040009E5 RID: 2533
		[CompilerGenerated]
		private int <FocusedRow>k__BackingField;

		// Token: 0x040009E6 RID: 2534
		[CompilerGenerated]
		private List<UserMaster> <Users>k__BackingField;

		// Token: 0x040009E7 RID: 2535
		[CompilerGenerated]
		private List<Warranty> <WarrantyList>k__BackingField;

		// Token: 0x040009E8 RID: 2536
		[CompilerGenerated]
		private bool <ReturnOnSelect>k__BackingField;

		// Token: 0x040009E9 RID: 2537
		private Timer _refreshTimer;

		// Token: 0x040009EA RID: 2538
		[CompilerGenerated]
		private bool <OutDateVisibility>k__BackingField;

		// Token: 0x040009EB RID: 2539
		private int _selectedStatus = 99;

		// Token: 0x040009EC RID: 2540
		[CompilerGenerated]
		private int <SelectedOffice>k__BackingField;

		// Token: 0x040009ED RID: 2541
		[CompilerGenerated]
		private int <SelectedUserFilter>k__BackingField;

		// Token: 0x040009EE RID: 2542
		[CompilerGenerated]
		private int <SelectedWarrantyOption>k__BackingField;

		// Token: 0x040009EF RID: 2543
		[CompilerGenerated]
		private int <SelectedCustomerType>k__BackingField;

		// Token: 0x0200011C RID: 284
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001488 RID: 5256 RVA: 0x0002EAB0 File Offset: 0x0002CCB0
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06001489 RID: 5257 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x0600148A RID: 5258 RVA: 0x0002EAC8 File Offset: 0x0002CCC8
			internal IEnumerable<UserMaster> <BgInitDoWork>b__77_0()
			{
				return UsersModel.LoadMasterManagers();
			}

			// Token: 0x0600148B RID: 5259 RVA: 0x0002EADC File Offset: 0x0002CCDC
			internal bool <RefillItems>b__94_0(WorkshopLite i)
			{
				return i.CartridgeId != null;
			}

			// Token: 0x0600148C RID: 5260 RVA: 0x0002EAF8 File Offset: 0x0002CCF8
			internal int <RefillItems>b__94_1(WorkshopLite i)
			{
				return i.RepairId;
			}

			// Token: 0x0600148D RID: 5261 RVA: 0x0002EADC File Offset: 0x0002CCDC
			internal bool <CanRefillItems>b__95_0(WorkshopLite i)
			{
				return i.CartridgeId != null;
			}

			// Token: 0x040009F0 RID: 2544
			public static readonly RepairsViewModel.<>c <>9 = new RepairsViewModel.<>c();

			// Token: 0x040009F1 RID: 2545
			public static Func<IEnumerable<UserMaster>> <>9__77_0;

			// Token: 0x040009F2 RID: 2546
			public static Func<WorkshopLite, bool> <>9__94_0;

			// Token: 0x040009F3 RID: 2547
			public static Func<WorkshopLite, int> <>9__94_1;

			// Token: 0x040009F4 RID: 2548
			public static Func<WorkshopLite, bool> <>9__95_0;
		}

		// Token: 0x0200011D RID: 285
		[CompilerGenerated]
		private sealed class <>c__DisplayClass84_0
		{
			// Token: 0x0600148E RID: 5262 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass84_0()
			{
			}

			// Token: 0x0600148F RID: 5263 RVA: 0x0002EB0C File Offset: 0x0002CD0C
			internal Task<List<WorkshopLite>> <LoadRepairs>b__1()
			{
				return this.<>4__this._WorkspaceModel.SelectOrders(this.o, new bool?(false));
			}

			// Token: 0x06001490 RID: 5264 RVA: 0x0002EB38 File Offset: 0x0002CD38
			internal void <LoadRepairs>b__0()
			{
				this.<>4__this.SetItems(this.items);
			}

			// Token: 0x040009F5 RID: 2549
			public RepairGridOptions o;

			// Token: 0x040009F6 RID: 2550
			public List<WorkshopLite> items;

			// Token: 0x040009F7 RID: 2551
			public RepairsViewModel <>4__this;
		}

		// Token: 0x0200011E RID: 286
		[CompilerGenerated]
		private sealed class <>c__DisplayClass84_1
		{
			// Token: 0x06001491 RID: 5265 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass84_1()
			{
			}

			// Token: 0x06001492 RID: 5266 RVA: 0x0002EB58 File Offset: 0x0002CD58
			internal void <LoadRepairs>b__3()
			{
				this.<>4__this._toasterService.Error(this.e.Message);
				this.<>4__this.Items.Clear();
			}

			// Token: 0x040009F8 RID: 2552
			public Exception e;

			// Token: 0x040009F9 RID: 2553
			public RepairsViewModel <>4__this;
		}

		// Token: 0x0200011F RID: 287
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadRepairs>d__84 : IAsyncStateMachine
		{
			// Token: 0x06001493 RID: 5267 RVA: 0x0002EB90 File Offset: 0x0002CD90
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairsViewModel repairsViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						if (!repairsViewModel._serverInfo.Connected)
						{
							goto IL_234;
						}
						this.<selectedRow>5__2 = repairsViewModel.FocusedRow;
					}
					try
					{
						TaskAwaiter<List<WorkshopLite>> awaiter;
						if (num != 0)
						{
							this.<>8__1 = new RepairsViewModel.<>c__DisplayClass84_0();
							this.<>8__1.<>4__this = repairsViewModel;
							int deviceType = repairsViewModel.Mode ? 2 : 1;
							this.<>8__1.o = new RepairGridOptions
							{
								Status = repairsViewModel.SelectedStatus,
								SelectedWarrantyOption = repairsViewModel.SelectedWarrantyOption,
								OfficeId = repairsViewModel.SelectedOffice,
								SearchString = this.filter,
								DeviceType = deviceType,
								CustomerType = repairsViewModel.SelectedCustomerType,
								OnlyMyOrders = repairsViewModel.OnlyMyOrders,
								OpenOtherUserCards = repairsViewModel.OpenOtherUserCards,
								Employee = repairsViewModel.SelectedUserFilter
							};
							awaiter = Task.Run<List<WorkshopLite>>(new Func<Task<List<WorkshopLite>>>(this.<>8__1.<LoadRepairs>b__1)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<WorkshopLite>>, RepairsViewModel.<LoadRepairs>d__84>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<WorkshopLite>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						List<WorkshopLite> result = awaiter.GetResult();
						this.<>8__1.items = result;
						if (this.filter == repairsViewModel.SearchString)
						{
							Dispatcher dispatcher = Application.Current.Dispatcher;
							if (dispatcher != null)
							{
								dispatcher.Invoke(new Action(this.<>8__1.<LoadRepairs>b__0));
							}
						}
						this.<>8__1 = null;
					}
					catch (EntityException ex)
					{
						if (ex.Message == "The underlying provider failed on Open.")
						{
							Dispatcher dispatcher2 = Application.Current.Dispatcher;
							if (dispatcher2 != null)
							{
								dispatcher2.Invoke(delegate()
								{
									repairsViewModel._serverInfo.SetServerUnreachable();
									if (repairsViewModel._ascMessageBoxService.ShowMessageBox("Потеряно соединение с сервером.", "Server unreachable", MessageBoxButton.OK, MessageBoxImage.Hand) == MessageBoxResult.OK)
									{
										repairsViewModel._serverInfo.SetServerReachable();
									}
								});
							}
						}
					}
					catch (Exception ex2)
					{
						RepairsViewModel.<>c__DisplayClass84_1 CS$<>8__locals1 = new RepairsViewModel.<>c__DisplayClass84_1();
						CS$<>8__locals1.<>4__this = repairsViewModel;
						Exception ex3 = ex2;
						CS$<>8__locals1.e = ex3;
						Dispatcher dispatcher3 = Application.Current.Dispatcher;
						if (dispatcher3 != null)
						{
							dispatcher3.Invoke(new Action(CS$<>8__locals1.<LoadRepairs>b__3));
						}
					}
					finally
					{
						if (num < 0)
						{
							repairsViewModel.FocusedRow = this.<selectedRow>5__2;
							repairsViewModel.HideWait();
						}
					}
				}
				catch (Exception ex3)
				{
					this.<>1__state = -2;
					Exception ex3;
					this.<>t__builder.SetException(ex3);
					return;
				}
				IL_234:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06001494 RID: 5268 RVA: 0x0002EE48 File Offset: 0x0002D048
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040009FA RID: 2554
			public int <>1__state;

			// Token: 0x040009FB RID: 2555
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040009FC RID: 2556
			public RepairsViewModel <>4__this;

			// Token: 0x040009FD RID: 2557
			public string filter;

			// Token: 0x040009FE RID: 2558
			private RepairsViewModel.<>c__DisplayClass84_0 <>8__1;

			// Token: 0x040009FF RID: 2559
			private int <selectedRow>5__2;

			// Token: 0x04000A00 RID: 2560
			private TaskAwaiter<List<WorkshopLite>> <>u__1;
		}

		// Token: 0x02000120 RID: 288
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Delete>d__98 : IAsyncStateMachine
		{
			// Token: 0x06001495 RID: 5269 RVA: 0x0002EE64 File Offset: 0x0002D064
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairsViewModel repairsViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						if (repairsViewModel._ascMessageBoxService.ShowMessageBox(Lang.t("ConfirmDelete") + "?", Lang.t("Attention"), MessageBoxButton.YesNo, MessageBoxImage.Exclamation) != MessageBoxResult.Yes)
						{
							goto IL_117;
						}
						repairsViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = Bootstrapper.Container.Resolve<IWorkshopService>().DeleteAsync(repairsViewModel.SelectedItem.RepairId).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RepairsViewModel.<Delete>d__98>(ref awaiter, ref this);
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
						repairsViewModel._toasterService.Info(Lang.t("Removed"));
						repairsViewModel.RefreshOrders();
					}
					catch (Exception ex)
					{
						repairsViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							repairsViewModel.HideWait();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_117:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06001496 RID: 5270 RVA: 0x0002EFC4 File Offset: 0x0002D1C4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000A01 RID: 2561
			public int <>1__state;

			// Token: 0x04000A02 RID: 2562
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000A03 RID: 2563
			public RepairsViewModel <>4__this;

			// Token: 0x04000A04 RID: 2564
			private TaskAwaiter <>u__1;
		}
	}
}
