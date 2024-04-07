using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Extensions;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Options;
using ASC.Services.Abstract;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels
{
	// Token: 0x02000482 RID: 1154
	public class RepairCartridgeViewModel : BaseViewModel, IRefreshable
	{
		// Token: 0x17000E82 RID: 3714
		// (get) Token: 0x06002D3E RID: 11582 RVA: 0x000921CC File Offset: 0x000903CC
		// (set) Token: 0x06002D3F RID: 11583 RVA: 0x000921E0 File Offset: 0x000903E0
		public ObservableCollection<CartridgeEx> Cartridges
		{
			[CompilerGenerated]
			get
			{
				return this.<Cartridges>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Cartridges>k__BackingField, value))
				{
					return;
				}
				this.<Cartridges>k__BackingField = value;
				this.RaisePropertyChanged("Cartridges");
			}
		}

		// Token: 0x17000E83 RID: 3715
		// (get) Token: 0x06002D40 RID: 11584 RVA: 0x00092210 File Offset: 0x00090410
		// (set) Token: 0x06002D41 RID: 11585 RVA: 0x00092224 File Offset: 0x00090424
		public int CartridgesCount
		{
			[CompilerGenerated]
			get
			{
				return this.<CartridgesCount>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CartridgesCount>k__BackingField == value)
				{
					return;
				}
				this.<CartridgesCount>k__BackingField = value;
				this.RaisePropertyChanged("CartridgesCount");
			}
		}

		// Token: 0x17000E84 RID: 3716
		// (get) Token: 0x06002D42 RID: 11586 RVA: 0x00092250 File Offset: 0x00090450
		// (set) Token: 0x06002D43 RID: 11587 RVA: 0x00092264 File Offset: 0x00090464
		public CartridgeEx SelectedCartridge
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedCartridge>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedCartridge>k__BackingField, value))
				{
					return;
				}
				this.<SelectedCartridge>k__BackingField = value;
				this.RaisePropertyChanged("SelectedCartridge");
			}
		}

		// Token: 0x17000E85 RID: 3717
		// (get) Token: 0x06002D44 RID: 11588 RVA: 0x00092294 File Offset: 0x00090494
		// (set) Token: 0x06002D45 RID: 11589 RVA: 0x000922A8 File Offset: 0x000904A8
		public List<boxes> Boxes
		{
			[CompilerGenerated]
			get
			{
				return this.<Boxes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<Boxes>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -151293698;
				IL_13:
				switch ((num ^ -921254029) % 4)
				{
				case 0:
					IL_32:
					this.<Boxes>k__BackingField = value;
					num = -1415169740;
					goto IL_13;
				case 1:
					return;
				case 2:
					goto IL_0E;
				}
				this.RaisePropertyChanged("Boxes");
			}
		}

		// Token: 0x17000E86 RID: 3718
		// (get) Token: 0x06002D46 RID: 11590 RVA: 0x00092304 File Offset: 0x00090504
		// (set) Token: 0x06002D47 RID: 11591 RVA: 0x00092318 File Offset: 0x00090518
		public List<Employee> Employees
		{
			[CompilerGenerated]
			get
			{
				return this.<Employees>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<Employees>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -554689905;
				IL_13:
				switch ((num ^ -1520922027) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					IL_32:
					this.<Employees>k__BackingField = value;
					this.RaisePropertyChanged("Employees");
					num = -1818119442;
					goto IL_13;
				case 2:
					return;
				}
			}
		}

		// Token: 0x17000E87 RID: 3719
		// (get) Token: 0x06002D48 RID: 11592 RVA: 0x00092374 File Offset: 0x00090574
		// (set) Token: 0x06002D49 RID: 11593 RVA: 0x00092388 File Offset: 0x00090588
		public List<WorkshopOptions> StatesList
		{
			[CompilerGenerated]
			get
			{
				return this.<StatesList>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<StatesList>k__BackingField, value))
				{
					return;
				}
				this.<StatesList>k__BackingField = value;
				this.RaisePropertyChanged("StatesList");
			}
		}

		// Token: 0x17000E88 RID: 3720
		// (get) Token: 0x06002D4A RID: 11594 RVA: 0x000923B8 File Offset: 0x000905B8
		// (set) Token: 0x06002D4B RID: 11595 RVA: 0x000923CC File Offset: 0x000905CC
		public bool InitFinished
		{
			[CompilerGenerated]
			get
			{
				return this.<InitFinished>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<InitFinished>k__BackingField == value)
				{
					return;
				}
				this.<InitFinished>k__BackingField = value;
				this.RaisePropertyChanged("InitFinished");
			}
		}

		// Token: 0x17000E89 RID: 3721
		// (get) Token: 0x06002D4C RID: 11596 RVA: 0x000923F8 File Offset: 0x000905F8
		// (set) Token: 0x06002D4D RID: 11597 RVA: 0x0009240C File Offset: 0x0009060C
		public Dictionary<int, string> HistoryOptions
		{
			[CompilerGenerated]
			get
			{
				return this.<HistoryOptions>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<HistoryOptions>k__BackingField, value))
				{
					return;
				}
				this.<HistoryOptions>k__BackingField = value;
				this.RaisePropertyChanged("HistoryOptions");
			}
		}

		// Token: 0x06002D4E RID: 11598 RVA: 0x0009243C File Offset: 0x0009063C
		public RepairCartridgeViewModel(int repairId) : this(new List<int>
		{
			repairId
		})
		{
		}

		// Token: 0x06002D4F RID: 11599 RVA: 0x0009245C File Offset: 0x0009065C
		public RepairCartridgeViewModel(List<int> ids)
		{
			this._cartridgeService = Bootstrapper.Container.Resolve<ICartridgeService>();
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this.HistoryOptions = this._cartridgeService.GetHistoryOptions();
			this._ids = new List<int>(ids);
			this.SetViewName("RefillingCartridges");
			this.StatesList = WorkshopOptions.GetCartridgeStatuses();
			this.Cartridges = new ObservableCollection<CartridgeEx>();
			this.Cartridges.CollectionChanged += this.CartridgesOnCollectionChanged;
			this.Init();
		}

		// Token: 0x06002D50 RID: 11600 RVA: 0x0009250C File Offset: 0x0009070C
		private void Init()
		{
			RepairCartridgeViewModel.<Init>d__39 <Init>d__;
			<Init>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<RepairCartridgeViewModel.<Init>d__39>(ref <Init>d__);
		}

		// Token: 0x06002D51 RID: 11601 RVA: 0x00092544 File Offset: 0x00090744
		private Task LoadCartridges()
		{
			return Task.Run<List<CartridgeEx>>(() => this._cartridgeService.GetCartridgesEx(this._ids)).ContinueWith(delegate(Task<List<CartridgeEx>> t)
			{
				this.Cartridges.Clear();
				foreach (CartridgeEx item in t.Result)
				{
					this.Cartridges.Add(item);
				}
			}, TaskScheduler.FromCurrentSynchronizationContext());
		}

		// Token: 0x06002D52 RID: 11602 RVA: 0x00092578 File Offset: 0x00090778
		private void CartridgesOnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			this.CartridgesCount = this.Cartridges.Count;
			base.RaiseCanExecuteChanged(() => this.Issue());
			if (this.Cartridges != null)
			{
				this._ids = (from c in this.Cartridges
				select c.Id).ToList<int>();
			}
			if (e.OldItems != null)
			{
				foreach (object obj in e.OldItems)
				{
					((INotifyPropertyChanged)obj).PropertyChanged -= this.item_PropertyChanged;
				}
			}
			if (e.NewItems != null)
			{
				foreach (object obj2 in e.NewItems)
				{
					((INotifyPropertyChanged)obj2).PropertyChanged += this.item_PropertyChanged;
				}
			}
		}

		// Token: 0x06002D53 RID: 11603 RVA: 0x000926C8 File Offset: 0x000908C8
		private void AddOrRemoveWork(Material.MaterialType type)
		{
			RepairCartridgeViewModel.<AddOrRemoveWork>d__42 <AddOrRemoveWork>d__;
			<AddOrRemoveWork>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<AddOrRemoveWork>d__.<>4__this = this;
			<AddOrRemoveWork>d__.type = type;
			<AddOrRemoveWork>d__.<>1__state = -1;
			<AddOrRemoveWork>d__.<>t__builder.Start<RepairCartridgeViewModel.<AddOrRemoveWork>d__42>(ref <AddOrRemoveWork>d__);
		}

		// Token: 0x17000E8A RID: 3722
		// (get) Token: 0x06002D54 RID: 11604 RVA: 0x00092708 File Offset: 0x00090908
		// (set) Token: 0x06002D55 RID: 11605 RVA: 0x0009271C File Offset: 0x0009091C
		public List<IMaterial> Materials
		{
			[CompilerGenerated]
			get
			{
				return this.<Materials>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Materials>k__BackingField, value))
				{
					return;
				}
				this.<Materials>k__BackingField = value;
				this.RaisePropertyChanged("Materials");
			}
		}

		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x06002D56 RID: 11606 RVA: 0x0009274C File Offset: 0x0009094C
		// (set) Token: 0x06002D57 RID: 11607 RVA: 0x00092760 File Offset: 0x00090960
		public bool MaterialsVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<MaterialsVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<MaterialsVisible>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -2073853335;
				IL_10:
				switch ((num ^ -1812781016) % 4)
				{
				case 0:
					IL_2F:
					this.<MaterialsVisible>k__BackingField = value;
					num = -1785479398;
					goto IL_10;
				case 1:
					return;
				case 3:
					goto IL_0B;
				}
				this.RaisePropertyChanged("MaterialsVisible");
			}
		}

		// Token: 0x17000E8C RID: 3724
		// (get) Token: 0x06002D58 RID: 11608 RVA: 0x000927B8 File Offset: 0x000909B8
		// (set) Token: 0x06002D59 RID: 11609 RVA: 0x000927CC File Offset: 0x000909CC
		public IMaterial SelectedMaterial
		{
			get
			{
				return this._selectedMaterial;
			}
			set
			{
				if (object.Equals(this._selectedMaterial, value))
				{
					return;
				}
				this._selectedMaterial = value;
				this.RaisePropertyChanged("SelectedMaterial");
				this.LoadMaterialItems();
			}
		}

		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x06002D5A RID: 11610 RVA: 0x00092800 File Offset: 0x00090A00
		// (set) Token: 0x06002D5B RID: 11611 RVA: 0x00092814 File Offset: 0x00090A14
		public List<store_items> AvailableItems
		{
			[CompilerGenerated]
			get
			{
				return this.<AvailableItems>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<AvailableItems>k__BackingField, value))
				{
					return;
				}
				this.<AvailableItems>k__BackingField = value;
				this.RaisePropertyChanged("AvailableItems");
			}
		}

		// Token: 0x06002D5C RID: 11612 RVA: 0x00092844 File Offset: 0x00090A44
		private void LoadMaterialItems()
		{
			RepairCartridgeViewModel.<LoadMaterialItems>d__58 <LoadMaterialItems>d__;
			<LoadMaterialItems>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadMaterialItems>d__.<>4__this = this;
			<LoadMaterialItems>d__.<>1__state = -1;
			<LoadMaterialItems>d__.<>t__builder.Start<RepairCartridgeViewModel.<LoadMaterialItems>d__58>(ref <LoadMaterialItems>d__);
		}

		// Token: 0x06002D5D RID: 11613 RVA: 0x0009287C File Offset: 0x00090A7C
		private Task<IMaterial> SelectMaterial(Material.MaterialType materialType)
		{
			RepairCartridgeViewModel.<SelectMaterial>d__59 <SelectMaterial>d__;
			<SelectMaterial>d__.<>t__builder = AsyncTaskMethodBuilder<IMaterial>.Create();
			<SelectMaterial>d__.<>4__this = this;
			<SelectMaterial>d__.materialType = materialType;
			<SelectMaterial>d__.<>1__state = -1;
			<SelectMaterial>d__.<>t__builder.Start<RepairCartridgeViewModel.<SelectMaterial>d__59>(ref <SelectMaterial>d__);
			return <SelectMaterial>d__.<>t__builder.Task;
		}

		// Token: 0x06002D5E RID: 11614 RVA: 0x000928C8 File Offset: 0x00090AC8
		[Command]
		public void UseThisMaterial()
		{
			RepairCartridgeViewModel.<UseThisMaterial>d__60 <UseThisMaterial>d__;
			<UseThisMaterial>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<UseThisMaterial>d__.<>4__this = this;
			<UseThisMaterial>d__.<>1__state = -1;
			<UseThisMaterial>d__.<>t__builder.Start<RepairCartridgeViewModel.<UseThisMaterial>d__60>(ref <UseThisMaterial>d__);
		}

		// Token: 0x06002D5F RID: 11615 RVA: 0x00092900 File Offset: 0x00090B00
		private void RestorePreviousValues(Material.MaterialType materialType)
		{
			this.InitFinished = false;
			CartridgeEx selectedCartridge = this.SelectedCartridge;
			if (selectedCartridge != null)
			{
				selectedCartridge.RestorePreviousValues(materialType);
			}
			this.InitFinished = true;
		}

		// Token: 0x06002D60 RID: 11616 RVA: 0x00092930 File Offset: 0x00090B30
		[Command]
		public void CancelUseMaterial()
		{
			if (this.SelectedMaterial != null)
			{
				this.RestorePreviousValues((Material.MaterialType)this.SelectedMaterial.Type);
				this.SelectedMaterial = null;
			}
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x06002D61 RID: 11617 RVA: 0x00092968 File Offset: 0x00090B68
		private void item_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			if (this.SelectedCartridge == null || !this.InitFinished)
			{
				return;
			}
			this.InitFinished = false;
			string propertyName = e.PropertyName;
			if (propertyName == "MakeRefill")
			{
				this.AddOrRemoveWork(Material.MaterialType.Toner);
				return;
			}
			if (propertyName == "MakeChip")
			{
				this.AddOrRemoveWork(Material.MaterialType.Chip);
				return;
			}
			if (propertyName == "MakeOPCDrum")
			{
				this.AddOrRemoveWork(Material.MaterialType.OPCDrum);
				return;
			}
			if (propertyName == "MakeCleaningBlade")
			{
				this.AddOrRemoveWork(Material.MaterialType.CleaningBlade);
				return;
			}
			if (propertyName == "MasterId")
			{
				this.UpdateMaster();
				return;
			}
			if (propertyName == "Status")
			{
				this.UpdateStatus();
				return;
			}
			base.RaiseCanExecuteChanged(() => this.Issue());
			this.InitFinished = true;
		}

		// Token: 0x06002D62 RID: 11618 RVA: 0x00092A5C File Offset: 0x00090C5C
		private void UpdateMaster()
		{
			base.ShowWait();
			Task.Run<Result>(() => this.SelectedCartridge.MasterChanged()).ContinueWith(delegate(Task<Result> t)
			{
				base.HideWait();
				if (!t.Result.IsSucces)
				{
					goto IL_5D;
				}
				string text = Lang.t("MasterUpdated");
				IL_2A:
				string msg = text;
				base.ShowActionResponse(t.Result.IsSucces, msg);
				int num = 2099810714;
				IL_42:
				switch ((num ^ 584032195) % 3)
				{
				case 1:
					text = t.Result.Message;
					goto IL_2A;
				case 2:
					IL_5D:
					num = 1378182877;
					goto IL_42;
				}
				base.RaiseCanExecuteChanged(() => this.Issue());
				this.InitFinished = true;
			}, TaskScheduler.FromCurrentSynchronizationContext());
		}

		// Token: 0x06002D63 RID: 11619 RVA: 0x00092A98 File Offset: 0x00090C98
		private void UpdateStatus()
		{
			base.ShowWait();
			Task.Run<Result>(() => this.SelectedCartridge.StatusChanged()).ContinueWith(delegate(Task<Result> t)
			{
				base.HideWait();
				string msg = t.Result.IsSucces ? Lang.t("OrderStatusUpdated") : t.Result.Message;
				base.ShowActionResponse(t.Result.IsSucces, msg);
				base.RaiseCanExecuteChanged(() => this.Issue());
				this.InitFinished = true;
			}, TaskScheduler.FromCurrentSynchronizationContext());
		}

		// Token: 0x06002D64 RID: 11620 RVA: 0x00092AD4 File Offset: 0x00090CD4
		[Command]
		public void ShowCartridgeCard()
		{
			CartridgeCardViewModel cartridgeCardViewModel = Bootstrapper.Container.Resolve<CartridgeCardViewModel>();
			cartridgeCardViewModel.SetCardId(this.SelectedCartridge.CardId);
			cartridgeCardViewModel.SetRefreshOnClose(true);
			this._windowedDocumentService.ShowNewDocument("CartridgeCardView", cartridgeCardViewModel, this, null);
		}

		// Token: 0x06002D65 RID: 11621 RVA: 0x00092B18 File Offset: 0x00090D18
		public bool CanShowCartridgeCard()
		{
			return this.SelectedCartridge != null;
		}

		// Token: 0x06002D66 RID: 11622 RVA: 0x00092B30 File Offset: 0x00090D30
		[Command]
		public void RemoveCartridge()
		{
			if (this.SelectedCartridge == null)
			{
				goto IL_17;
			}
			goto IL_68;
			int num;
			for (;;)
			{
				IL_35:
				switch ((num ^ -428908037) % 6)
				{
				case 0:
					goto IL_68;
				case 1:
					this.Cartridges.Remove(this.SelectedCartridge);
					num = -1715012940;
					continue;
				case 2:
					goto IL_17;
				case 3:
					goto IL_78;
				case 4:
					return;
				}
				break;
			}
			return;
			IL_78:
			this._toasterService.Info(Lang.t("RemoveCartridgeError"));
			return;
			IL_17:
			num = -1914305281;
			goto IL_35;
			IL_68:
			num = ((this.Cartridges.Count != 1) ? -456674070 : -1034907316);
			goto IL_35;
		}

		// Token: 0x06002D67 RID: 11623 RVA: 0x00092BCC File Offset: 0x00090DCC
		[Command]
		public void NavigateCartridge()
		{
			if (this.SelectedCartridge != null)
			{
				goto IL_2C;
			}
			IL_08:
			int num = -849889165;
			IL_0D:
			switch ((num ^ -390359006) % 4)
			{
			case 1:
				return;
			case 2:
				IL_2C:
				this._navigationService.Navigate("RepairCartridgeFullView", new RepairCartridgeFullViewModel(this.SelectedCartridge.Id));
				num = -1041508666;
				goto IL_0D;
			case 3:
				goto IL_08;
			}
		}

		// Token: 0x06002D68 RID: 11624 RVA: 0x00092C30 File Offset: 0x00090E30
		public void DataRefresh()
		{
			this.LoadCartridges();
		}

		// Token: 0x06002D69 RID: 11625 RVA: 0x00092C44 File Offset: 0x00090E44
		[Command]
		public void Issue()
		{
			CartridgeIssueViewModel cartridgeIssueViewModel = Bootstrapper.Container.Resolve<CartridgeIssueViewModel>();
			cartridgeIssueViewModel.SetCartridges(this.Cartridges);
			this._windowedDocumentService.ShowNewDocument("CartridgeIssueView", cartridgeIssueViewModel, this, null);
		}

		// Token: 0x06002D6A RID: 11626 RVA: 0x00092C7C File Offset: 0x00090E7C
		public bool CanIssue()
		{
			List<int> customers = (from c in this.Cartridges
			select c.CustomerId).DistinctBy((int c) => c).ToList<int>();
			return this.Cartridges.All(delegate(CartridgeEx c)
			{
				if (c.Status != 6)
				{
					if (c.Status != 7)
					{
						return false;
					}
				}
				return customers.Count <= 1;
			});
		}

		// Token: 0x06002D6B RID: 11627 RVA: 0x00092D00 File Offset: 0x00090F00
		[Command]
		public void SaveBox()
		{
			RepairCartridgeViewModel.<SaveBox>d__73 <SaveBox>d__;
			<SaveBox>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SaveBox>d__.<>4__this = this;
			<SaveBox>d__.<>1__state = -1;
			<SaveBox>d__.<>t__builder.Start<RepairCartridgeViewModel.<SaveBox>d__73>(ref <SaveBox>d__);
		}

		// Token: 0x06002D6C RID: 11628 RVA: 0x00092D38 File Offset: 0x00090F38
		[Command]
		public void NavigateCustomer()
		{
			if (this.SelectedCartridge == null)
			{
				return;
			}
			this._navigationService.NavigateToCustomerCard(this.SelectedCartridge.CustomerId, null);
		}

		// Token: 0x06002D6D RID: 11629 RVA: 0x0001D588 File Offset: 0x0001B788
		public bool CanNavigateCustomer()
		{
			return OfflineData.Instance.Employee.Can(7, 0);
		}

		// Token: 0x06002D6E RID: 11630 RVA: 0x00092D68 File Offset: 0x00090F68
		[Command]
		public void Refresh()
		{
			this.DataRefresh();
		}

		// Token: 0x06002D6F RID: 11631 RVA: 0x00092D7C File Offset: 0x00090F7C
		public override void OnLoad()
		{
			base.OnLoad();
			if (this._views > 0)
			{
				this.DataRefresh();
				return;
			}
			this._views++;
		}

		// Token: 0x06002D70 RID: 11632 RVA: 0x00092DB0 File Offset: 0x00090FB0
		[CompilerGenerated]
		private void <Init>b__39_1(Task<List<boxes>> t)
		{
			this.Boxes = t.Result;
		}

		// Token: 0x06002D71 RID: 11633 RVA: 0x00092DCC File Offset: 0x00090FCC
		[CompilerGenerated]
		private Task<List<CartridgeEx>> <LoadCartridges>b__40_0()
		{
			return this._cartridgeService.GetCartridgesEx(this._ids);
		}

		// Token: 0x06002D72 RID: 11634 RVA: 0x00092DEC File Offset: 0x00090FEC
		[CompilerGenerated]
		private void <LoadCartridges>b__40_1(Task<List<CartridgeEx>> t)
		{
			this.Cartridges.Clear();
			foreach (CartridgeEx item in t.Result)
			{
				this.Cartridges.Add(item);
			}
		}

		// Token: 0x06002D73 RID: 11635 RVA: 0x00092E50 File Offset: 0x00091050
		[CompilerGenerated]
		private bool <LoadMaterialItems>b__58_0(store_items i)
		{
			return i.count - i.reserved > this.SelectedMaterial.Count;
		}

		// Token: 0x06002D74 RID: 11636 RVA: 0x00092E78 File Offset: 0x00091078
		[CompilerGenerated]
		private Task<Result> <UpdateMaster>b__64_0()
		{
			return this.SelectedCartridge.MasterChanged();
		}

		// Token: 0x06002D75 RID: 11637 RVA: 0x00092E90 File Offset: 0x00091090
		[CompilerGenerated]
		private void <UpdateMaster>b__64_1(Task<Result> t)
		{
			base.HideWait();
			if (!t.Result.IsSucces)
			{
				goto IL_5D;
			}
			string text = Lang.t("MasterUpdated");
			IL_2A:
			string msg = text;
			base.ShowActionResponse(t.Result.IsSucces, msg);
			int num = 2099810714;
			IL_42:
			switch ((num ^ 584032195) % 3)
			{
			case 1:
				text = t.Result.Message;
				goto IL_2A;
			case 2:
				IL_5D:
				num = 1378182877;
				goto IL_42;
			}
			base.RaiseCanExecuteChanged(() => this.Issue());
			this.InitFinished = true;
		}

		// Token: 0x06002D76 RID: 11638 RVA: 0x00092F44 File Offset: 0x00091144
		[CompilerGenerated]
		private Task<Result> <UpdateStatus>b__65_0()
		{
			return this.SelectedCartridge.StatusChanged();
		}

		// Token: 0x06002D77 RID: 11639 RVA: 0x00092F5C File Offset: 0x0009115C
		[CompilerGenerated]
		private void <UpdateStatus>b__65_1(Task<Result> t)
		{
			base.HideWait();
			string msg = t.Result.IsSucces ? Lang.t("OrderStatusUpdated") : t.Result.Message;
			base.ShowActionResponse(t.Result.IsSucces, msg);
			base.RaiseCanExecuteChanged(() => this.Issue());
			this.InitFinished = true;
		}

		// Token: 0x0400194C RID: 6476
		private readonly INavigationService _navigationService;

		// Token: 0x0400194D RID: 6477
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x0400194E RID: 6478
		private readonly IToasterService _toasterService;

		// Token: 0x0400194F RID: 6479
		private readonly ICartridgeService _cartridgeService;

		// Token: 0x04001950 RID: 6480
		[CompilerGenerated]
		private ObservableCollection<CartridgeEx> <Cartridges>k__BackingField;

		// Token: 0x04001951 RID: 6481
		[CompilerGenerated]
		private int <CartridgesCount>k__BackingField;

		// Token: 0x04001952 RID: 6482
		[CompilerGenerated]
		private CartridgeEx <SelectedCartridge>k__BackingField;

		// Token: 0x04001953 RID: 6483
		[CompilerGenerated]
		private List<boxes> <Boxes>k__BackingField;

		// Token: 0x04001954 RID: 6484
		[CompilerGenerated]
		private List<Employee> <Employees>k__BackingField;

		// Token: 0x04001955 RID: 6485
		[CompilerGenerated]
		private List<WorkshopOptions> <StatesList>k__BackingField;

		// Token: 0x04001956 RID: 6486
		[CompilerGenerated]
		private bool <InitFinished>k__BackingField;

		// Token: 0x04001957 RID: 6487
		private List<int> _ids;

		// Token: 0x04001958 RID: 6488
		[CompilerGenerated]
		private Dictionary<int, string> <HistoryOptions>k__BackingField;

		// Token: 0x04001959 RID: 6489
		[CompilerGenerated]
		private List<IMaterial> <Materials>k__BackingField;

		// Token: 0x0400195A RID: 6490
		[CompilerGenerated]
		private bool <MaterialsVisible>k__BackingField;

		// Token: 0x0400195B RID: 6491
		[CompilerGenerated]
		private List<store_items> <AvailableItems>k__BackingField;

		// Token: 0x0400195C RID: 6492
		private int _views;

		// Token: 0x0400195D RID: 6493
		private IMaterial _selectedMaterial;

		// Token: 0x02000483 RID: 1155
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002D78 RID: 11640 RVA: 0x00092FE8 File Offset: 0x000911E8
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06002D79 RID: 11641 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06002D7A RID: 11642 RVA: 0x0007D2E4 File Offset: 0x0007B4E4
			internal Task<List<boxes>> <Init>b__39_0()
			{
				return RepairModel.LoadNonItemBoxes(null, false);
			}

			// Token: 0x06002D7B RID: 11643 RVA: 0x0007933C File Offset: 0x0007753C
			internal int <CartridgesOnCollectionChanged>b__41_1(CartridgeEx c)
			{
				return c.Id;
			}

			// Token: 0x06002D7C RID: 11644 RVA: 0x00079350 File Offset: 0x00077550
			internal int <CanIssue>b__72_0(CartridgeEx c)
			{
				return c.CustomerId;
			}

			// Token: 0x06002D7D RID: 11645 RVA: 0x00093000 File Offset: 0x00091200
			internal int <CanIssue>b__72_1(int c)
			{
				return c;
			}

			// Token: 0x0400195E RID: 6494
			public static readonly RepairCartridgeViewModel.<>c <>9 = new RepairCartridgeViewModel.<>c();

			// Token: 0x0400195F RID: 6495
			public static Func<Task<List<boxes>>> <>9__39_0;

			// Token: 0x04001960 RID: 6496
			public static Func<CartridgeEx, int> <>9__41_1;

			// Token: 0x04001961 RID: 6497
			public static Func<CartridgeEx, int> <>9__72_0;

			// Token: 0x04001962 RID: 6498
			public static Func<int, int> <>9__72_1;
		}

		// Token: 0x02000484 RID: 1156
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Init>d__39 : IAsyncStateMachine
		{
			// Token: 0x06002D7E RID: 11646 RVA: 0x00093010 File Offset: 0x00091210
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairCartridgeViewModel repairCartridgeViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						repairCartridgeViewModel.ShowWait();
						List<Task> list = new List<Task>();
						Task item = Task.Run<List<boxes>>(new Func<Task<List<boxes>>>(RepairCartridgeViewModel.<>c.<>9.<Init>b__39_0)).ContinueWith(delegate(Task<List<boxes>> t)
						{
							base.Boxes = t.Result;
						}, TaskScheduler.FromCurrentSynchronizationContext());
						list.Add(item);
						repairCartridgeViewModel.Employees = OfflineData.Instance.GetCurrentOfficeEmployees();
						Task item2 = repairCartridgeViewModel.LoadCartridges();
						list.Add(item2);
						awaiter = Task.WhenAll(list).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RepairCartridgeViewModel.<Init>d__39>(ref awaiter, ref this);
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
					repairCartridgeViewModel.InitFinished = true;
					repairCartridgeViewModel.HideWait();
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

			// Token: 0x06002D7F RID: 11647 RVA: 0x00093144 File Offset: 0x00091344
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001963 RID: 6499
			public int <>1__state;

			// Token: 0x04001964 RID: 6500
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001965 RID: 6501
			public RepairCartridgeViewModel <>4__this;

			// Token: 0x04001966 RID: 6502
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000485 RID: 1157
		[CompilerGenerated]
		private sealed class <>c__DisplayClass42_0
		{
			// Token: 0x06002D80 RID: 11648 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass42_0()
			{
			}

			// Token: 0x06002D81 RID: 11649 RVA: 0x00093160 File Offset: 0x00091360
			internal Task<Result> <AddOrRemoveWork>b__2()
			{
				return this.<>4__this.SelectedCartridge.RemoveWorks(this.type);
			}

			// Token: 0x04001967 RID: 6503
			public RepairCartridgeViewModel <>4__this;

			// Token: 0x04001968 RID: 6504
			public Material.MaterialType type;
		}

		// Token: 0x02000486 RID: 1158
		[CompilerGenerated]
		private sealed class <>c__DisplayClass42_1
		{
			// Token: 0x06002D82 RID: 11650 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass42_1()
			{
			}

			// Token: 0x06002D83 RID: 11651 RVA: 0x00093184 File Offset: 0x00091384
			internal Task<Result> <AddOrRemoveWork>b__1()
			{
				return this.CS$<>8__locals1.<>4__this.SelectedCartridge.AddWorks(this.material);
			}

			// Token: 0x04001969 RID: 6505
			public IMaterial material;

			// Token: 0x0400196A RID: 6506
			public RepairCartridgeViewModel.<>c__DisplayClass42_0 CS$<>8__locals1;
		}

		// Token: 0x02000487 RID: 1159
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <AddOrRemoveWork>d__42 : IAsyncStateMachine
		{
			// Token: 0x06002D84 RID: 11652 RVA: 0x000931AC File Offset: 0x000913AC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairCartridgeViewModel repairCartridgeViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IMaterial> awaiter;
					TaskAwaiter<Result> awaiter2;
					Result result;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IMaterial>);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<Result>);
						this.<>1__state = -1;
						goto IL_1BB;
					case 2:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<Result>);
						this.<>1__state = -1;
						goto IL_1EF;
					default:
					{
						RepairCartridgeViewModel.<>c__DisplayClass42_0 CS$<>8__locals1 = new RepairCartridgeViewModel.<>c__DisplayClass42_0();
						CS$<>8__locals1.<>4__this = this.<>4__this;
						CS$<>8__locals1.type = this.type;
						result = new Result();
						if (repairCartridgeViewModel.SelectedCartridge.IsAddWorks(CS$<>8__locals1.type))
						{
							this.<>8__1 = new RepairCartridgeViewModel.<>c__DisplayClass42_1();
							this.<>8__1.CS$<>8__locals1 = CS$<>8__locals1;
							awaiter = repairCartridgeViewModel.SelectMaterial(this.<>8__1.CS$<>8__locals1.type).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IMaterial>, RepairCartridgeViewModel.<AddOrRemoveWork>d__42>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							repairCartridgeViewModel.ShowWait();
							awaiter2 = Task.Run<Result>(new Func<Task<Result>>(CS$<>8__locals1.<AddOrRemoveWork>b__2)).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								this.<>1__state = 2;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Result>, RepairCartridgeViewModel.<AddOrRemoveWork>d__42>(ref awaiter2, ref this);
								return;
							}
							goto IL_1EF;
						}
						break;
					}
					}
					IMaterial result2 = awaiter.GetResult();
					this.<>8__1.material = result2;
					if (this.<>8__1.material == null)
					{
						goto IL_28A;
					}
					repairCartridgeViewModel.ShowWait();
					awaiter2 = Task.Run<Result>(new Func<Task<Result>>(this.<>8__1.<AddOrRemoveWork>b__1)).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Result>, RepairCartridgeViewModel.<AddOrRemoveWork>d__42>(ref awaiter2, ref this);
						return;
					}
					IL_1BB:
					result = awaiter2.GetResult();
					repairCartridgeViewModel.HideWait();
					this.<>8__1 = null;
					goto IL_1FD;
					IL_1EF:
					result = awaiter2.GetResult();
					repairCartridgeViewModel.HideWait();
					IL_1FD:
					if (!result.IsSucces)
					{
						repairCartridgeViewModel._toasterService.Error(result.Message);
					}
					else
					{
						repairCartridgeViewModel._toasterService.Success(Lang.t("WorksUpdated"));
					}
					repairCartridgeViewModel.RaiseCanExecuteChanged(() => repairCartridgeViewModel.Issue());
					repairCartridgeViewModel.InitFinished = true;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_28A:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002D85 RID: 11653 RVA: 0x00093474 File Offset: 0x00091674
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400196B RID: 6507
			public int <>1__state;

			// Token: 0x0400196C RID: 6508
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400196D RID: 6509
			public RepairCartridgeViewModel <>4__this;

			// Token: 0x0400196E RID: 6510
			public Material.MaterialType type;

			// Token: 0x0400196F RID: 6511
			private RepairCartridgeViewModel.<>c__DisplayClass42_1 <>8__1;

			// Token: 0x04001970 RID: 6512
			private TaskAwaiter<IMaterial> <>u__1;

			// Token: 0x04001971 RID: 6513
			private TaskAwaiter<Result> <>u__2;
		}

		// Token: 0x02000488 RID: 1160
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadMaterialItems>d__58 : IAsyncStateMachine
		{
			// Token: 0x06002D86 RID: 11654 RVA: 0x00093490 File Offset: 0x00091690
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairCartridgeViewModel repairCartridgeViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<store_items>> awaiter;
					if (num != 0)
					{
						if (repairCartridgeViewModel.SelectedMaterial == null)
						{
							goto IL_F5;
						}
						awaiter = StoreModel.LoadItems(repairCartridgeViewModel.SelectedMaterial.Articul.GetValueOrDefault()).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<store_items>>, RepairCartridgeViewModel.<LoadMaterialItems>d__58>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<store_items>>);
						this.<>1__state = -1;
					}
					IEnumerable<store_items> result = awaiter.GetResult();
					repairCartridgeViewModel.AvailableItems = (from i in result
					where i.count - i.reserved > base.SelectedMaterial.Count
					select i).ToList<store_items>();
					if (repairCartridgeViewModel.AvailableItems.Any<store_items>())
					{
						store_items store_items = repairCartridgeViewModel.AvailableItems.FirstOrDefault<store_items>();
						if (store_items != null)
						{
							repairCartridgeViewModel.SelectedMaterial.UseItemId = store_items.id;
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_F5:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002D87 RID: 11655 RVA: 0x000935B8 File Offset: 0x000917B8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001972 RID: 6514
			public int <>1__state;

			// Token: 0x04001973 RID: 6515
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001974 RID: 6516
			public RepairCartridgeViewModel <>4__this;

			// Token: 0x04001975 RID: 6517
			private TaskAwaiter<IEnumerable<store_items>> <>u__1;
		}

		// Token: 0x02000489 RID: 1161
		[CompilerGenerated]
		private sealed class <>c__DisplayClass59_0
		{
			// Token: 0x06002D88 RID: 11656 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass59_0()
			{
			}

			// Token: 0x06002D89 RID: 11657 RVA: 0x000935D4 File Offset: 0x000917D4
			internal bool <SelectMaterial>b__1(store_items i)
			{
				return i.count - i.reserved >= this._materials[this.m].Count;
			}

			// Token: 0x04001976 RID: 6518
			public List<IMaterial> _materials;

			// Token: 0x04001977 RID: 6519
			public int m;

			// Token: 0x04001978 RID: 6520
			public Func<store_items, bool> <>9__1;
		}

		// Token: 0x0200048A RID: 1162
		[CompilerGenerated]
		private sealed class <>c__DisplayClass59_1
		{
			// Token: 0x06002D8A RID: 11658 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass59_1()
			{
			}

			// Token: 0x06002D8B RID: 11659 RVA: 0x0009360C File Offset: 0x0009180C
			internal bool <SelectMaterial>b__0(store_items i)
			{
				return i.count - i.reserved >= this.selectedMaterial.Count;
			}

			// Token: 0x04001979 RID: 6521
			public IMaterial selectedMaterial;
		}

		// Token: 0x0200048B RID: 1163
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SelectMaterial>d__59 : IAsyncStateMachine
		{
			// Token: 0x06002D8C RID: 11660 RVA: 0x00093638 File Offset: 0x00091838
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairCartridgeViewModel repairCartridgeViewModel = this.<>4__this;
				IMaterial result;
				try
				{
					TaskAwaiter<IEnumerable<store_items>> awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IEnumerable<store_items>>);
							this.<>1__state = -1;
							goto IL_2F5;
						}
						this.<>8__2 = new RepairCartridgeViewModel.<>c__DisplayClass59_0();
						this.<>8__2._materials = repairCartridgeViewModel.SelectedCartridge.GetMaterial(this.materialType);
						if (this.<>8__2._materials == null || !this.<>8__2._materials.Any<IMaterial>())
						{
							repairCartridgeViewModel._toasterService.Error(Lang.t("MaterialNotFound"));
							repairCartridgeViewModel.RestorePreviousValues(this.materialType);
							result = null;
							goto IL_4CB;
						}
						repairCartridgeViewModel.MaterialsVisible = (this.<>8__2._materials.Count > 1);
						if (this.<>8__2._materials.Count == 1)
						{
							this.<>8__1 = new RepairCartridgeViewModel.<>c__DisplayClass59_1();
							repairCartridgeViewModel.Materials = this.<>8__2._materials;
							this.<>8__1.selectedMaterial = this.<>8__2._materials.FirstOrDefault<IMaterial>();
							awaiter = StoreModel.LoadItems(this.<>8__1.selectedMaterial.Articul.GetValueOrDefault()).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<store_items>>, RepairCartridgeViewModel.<SelectMaterial>d__59>(ref awaiter, ref this);
								return;
							}
							goto IL_3AE;
						}
						else
						{
							repairCartridgeViewModel.Materials = new List<IMaterial>();
							this.<>8__2.m = 0;
						}
						IL_1A1:
						if (this.<>8__2.m >= this.<>8__2._materials.Count)
						{
							repairCartridgeViewModel._toasterService.Error(Lang.t("ItemSubstractWarning"));
							repairCartridgeViewModel.RestorePreviousValues(this.materialType);
							result = null;
							goto IL_4CB;
						}
						awaiter = StoreModel.LoadItems(this.<>8__2._materials[this.<>8__2.m].Articul.GetValueOrDefault()).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 1;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<store_items>>, RepairCartridgeViewModel.<SelectMaterial>d__59>(ref awaiter, ref this);
							return;
						}
						IL_2F5:
						IEnumerable<store_items> result2 = awaiter.GetResult();
						if (result2 != null && result2.Any<store_items>())
						{
							RepairCartridgeViewModel repairCartridgeViewModel2 = repairCartridgeViewModel;
							IEnumerable<store_items> source = result2;
							Func<store_items, bool> predicate;
							if ((predicate = this.<>8__2.<>9__1) == null)
							{
								predicate = (this.<>8__2.<>9__1 = new Func<store_items, bool>(this.<>8__2.<SelectMaterial>b__1));
							}
							repairCartridgeViewModel2.AvailableItems = source.Where(predicate).ToList<store_items>();
							if (repairCartridgeViewModel.AvailableItems.Any<store_items>())
							{
								repairCartridgeViewModel.Materials.Add(this.<>8__2._materials[this.<>8__2.m]);
								store_items store_items = repairCartridgeViewModel.AvailableItems.FirstOrDefault<store_items>();
								this.<>8__2._materials[this.<>8__2.m].UseItemId = store_items.id;
								if (this.<>8__2.m == this.<>8__2._materials.Count - 1)
								{
									if (repairCartridgeViewModel.Materials.Any<IMaterial>())
									{
										repairCartridgeViewModel.SelectedMaterial = this.<>8__2._materials[this.<>8__2.m];
										repairCartridgeViewModel._windowedDocumentService.ShowNewDocument("SelectCartridgeItemView", repairCartridgeViewModel, null, null);
										result = null;
										goto IL_4CB;
									}
								}
							}
						}
						int m = this.<>8__2.m;
						this.<>8__2.m = m + 1;
						goto IL_1A1;
					}
					awaiter = this.<>u__1;
					this.<>u__1 = default(TaskAwaiter<IEnumerable<store_items>>);
					this.<>1__state = -1;
					IL_3AE:
					IEnumerable<store_items> result3 = awaiter.GetResult();
					if (result3 != null && result3.Any<store_items>())
					{
						repairCartridgeViewModel.AvailableItems = result3.Where(new Func<store_items, bool>(this.<>8__1.<SelectMaterial>b__0)).ToList<store_items>();
						if (!repairCartridgeViewModel.AvailableItems.Any<store_items>())
						{
							repairCartridgeViewModel._toasterService.Error(Lang.t("ItemSubstractWarning"));
							repairCartridgeViewModel.RestorePreviousValues(this.materialType);
							result = null;
						}
						else
						{
							store_items store_items2 = repairCartridgeViewModel.AvailableItems.FirstOrDefault<store_items>();
							this.<>8__1.selectedMaterial.UseItemId = store_items2.id;
							if (repairCartridgeViewModel.AvailableItems.Count == 1)
							{
								result = this.<>8__1.selectedMaterial;
							}
							else
							{
								repairCartridgeViewModel.SelectedMaterial = this.<>8__1.selectedMaterial;
								repairCartridgeViewModel._windowedDocumentService.ShowNewDocument("SelectCartridgeItemView", repairCartridgeViewModel, null, null);
								result = null;
							}
						}
					}
					else
					{
						repairCartridgeViewModel._toasterService.Error(Lang.t("ItemNotFound"));
						repairCartridgeViewModel.RestorePreviousValues(this.materialType);
						result = null;
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_4CB:
				this.<>1__state = -2;
				this.<>8__2 = null;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06002D8D RID: 11661 RVA: 0x00093B48 File Offset: 0x00091D48
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400197A RID: 6522
			public int <>1__state;

			// Token: 0x0400197B RID: 6523
			public AsyncTaskMethodBuilder<IMaterial> <>t__builder;

			// Token: 0x0400197C RID: 6524
			public RepairCartridgeViewModel <>4__this;

			// Token: 0x0400197D RID: 6525
			public Material.MaterialType materialType;

			// Token: 0x0400197E RID: 6526
			private RepairCartridgeViewModel.<>c__DisplayClass59_1 <>8__1;

			// Token: 0x0400197F RID: 6527
			private RepairCartridgeViewModel.<>c__DisplayClass59_0 <>8__2;

			// Token: 0x04001980 RID: 6528
			private TaskAwaiter<IEnumerable<store_items>> <>u__1;
		}

		// Token: 0x0200048C RID: 1164
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UseThisMaterial>d__60 : IAsyncStateMachine
		{
			// Token: 0x06002D8E RID: 11662 RVA: 0x00093B64 File Offset: 0x00091D64
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairCartridgeViewModel repairCartridgeViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<Result> awaiter;
					if (num != 0)
					{
						if (repairCartridgeViewModel.SelectedMaterial == null)
						{
							goto IL_CF;
						}
						repairCartridgeViewModel.InitFinished = false;
						awaiter = repairCartridgeViewModel.SelectedCartridge.AddWorks(repairCartridgeViewModel.SelectedMaterial).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Result>, RepairCartridgeViewModel.<UseThisMaterial>d__60>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<Result>);
						this.<>1__state = -1;
					}
					Result result = awaiter.GetResult();
					repairCartridgeViewModel._windowedDocumentService.CloseActiveDocument();
					repairCartridgeViewModel.ShowActionResponse(result.IsSucces, result.Message);
					repairCartridgeViewModel.InitFinished = true;
					repairCartridgeViewModel.SelectedMaterial = null;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_CF:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002D8F RID: 11663 RVA: 0x00093C64 File Offset: 0x00091E64
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001981 RID: 6529
			public int <>1__state;

			// Token: 0x04001982 RID: 6530
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001983 RID: 6531
			public RepairCartridgeViewModel <>4__this;

			// Token: 0x04001984 RID: 6532
			private TaskAwaiter<Result> <>u__1;
		}

		// Token: 0x0200048D RID: 1165
		[CompilerGenerated]
		private sealed class <>c__DisplayClass72_0
		{
			// Token: 0x06002D90 RID: 11664 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass72_0()
			{
			}

			// Token: 0x06002D91 RID: 11665 RVA: 0x00093C80 File Offset: 0x00091E80
			internal bool <CanIssue>b__2(CartridgeEx c)
			{
				if (c.Status != 6)
				{
					if (c.Status != 7)
					{
						return false;
					}
				}
				return this.customers.Count <= 1;
			}

			// Token: 0x04001985 RID: 6533
			public List<int> customers;
		}

		// Token: 0x0200048E RID: 1166
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SaveBox>d__73 : IAsyncStateMachine
		{
			// Token: 0x06002D92 RID: 11666 RVA: 0x00093CB4 File Offset: 0x00091EB4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairCartridgeViewModel repairCartridgeViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						if (repairCartridgeViewModel.SelectedCartridge == null)
						{
							goto IL_F1;
						}
						repairCartridgeViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = repairCartridgeViewModel._cartridgeService.UpdateBox(repairCartridgeViewModel.SelectedCartridge.Id, repairCartridgeViewModel.SelectedCartridge.BoxId).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RepairCartridgeViewModel.<SaveBox>d__73>(ref awaiter, ref this);
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
						repairCartridgeViewModel._toasterService.Success(Lang.t("Saved"));
					}
					catch (Exception ex)
					{
						repairCartridgeViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							repairCartridgeViewModel.HideWait();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_F1:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002D93 RID: 11667 RVA: 0x00093DF0 File Offset: 0x00091FF0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001986 RID: 6534
			public int <>1__state;

			// Token: 0x04001987 RID: 6535
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001988 RID: 6536
			public RepairCartridgeViewModel <>4__this;

			// Token: 0x04001989 RID: 6537
			private TaskAwaiter <>u__1;
		}
	}
}
