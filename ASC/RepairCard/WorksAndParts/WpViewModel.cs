using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ASC.Common.Enum;
using ASC.Common.Interfaces;
using ASC.Common.Objects;
using ASC.Common.SimpleClasses;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Options;
using ASC.PartsRequest;
using ASC.PriceWorks;
using ASC.RequestsManager;
using ASC.Services.Abstract;
using ASC.ViewModels;
using Autofac;
using DevExpress.Data.TreeList;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Grid.TreeList;

namespace ASC.RepairCard.WorksAndParts
{
	// Token: 0x02000829 RID: 2089
	public class WpViewModel : CollectionViewModel<WorkPartObject>, IRefreshable, IMyItemSelect, IWorksSelect
	{
		// Token: 0x170010CC RID: 4300
		// (get) Token: 0x06003E3C RID: 15932 RVA: 0x000F81F8 File Offset: 0x000F63F8
		// (set) Token: 0x06003E3D RID: 15933 RVA: 0x000F820C File Offset: 0x000F640C
		public workshop Repair
		{
			[CompilerGenerated]
			get
			{
				return this.<Repair>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Repair>k__BackingField, value))
				{
					return;
				}
				this.<Repair>k__BackingField = value;
				this.RaisePropertyChanged("AllowEdit");
				this.RaisePropertyChanged("Repair");
			}
		}

		// Token: 0x170010CD RID: 4301
		// (get) Token: 0x06003E3E RID: 15934 RVA: 0x000F8248 File Offset: 0x000F6448
		// (set) Token: 0x06003E3F RID: 15935 RVA: 0x000F825C File Offset: 0x000F645C
		public int RepairId
		{
			[CompilerGenerated]
			get
			{
				return this.<RepairId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<RepairId>k__BackingField == value)
				{
					return;
				}
				this.<RepairId>k__BackingField = value;
				this.RaisePropertyChanged("RepairId");
			}
		}

		// Token: 0x170010CE RID: 4302
		// (get) Token: 0x06003E40 RID: 15936 RVA: 0x000F8288 File Offset: 0x000F6488
		// (set) Token: 0x06003E41 RID: 15937 RVA: 0x000F829C File Offset: 0x000F649C
		public int RepairState
		{
			[CompilerGenerated]
			get
			{
				return this.<RepairState>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<RepairState>k__BackingField == value)
				{
					return;
				}
				this.<RepairState>k__BackingField = value;
				this.RaisePropertyChanged("AllowEdit");
				this.RaisePropertyChanged("RepairState");
			}
		}

		// Token: 0x170010CF RID: 4303
		// (get) Token: 0x06003E42 RID: 15938 RVA: 0x000F82D4 File Offset: 0x000F64D4
		// (set) Token: 0x06003E43 RID: 15939 RVA: 0x000F82E8 File Offset: 0x000F64E8
		public decimal TotalWorks
		{
			[CompilerGenerated]
			get
			{
				return this.<TotalWorks>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<TotalWorks>k__BackingField, value))
				{
					return;
				}
				this.<TotalWorks>k__BackingField = value;
				this.RaisePropertyChanged("TotalWorks");
			}
		}

		// Token: 0x170010D0 RID: 4304
		// (get) Token: 0x06003E44 RID: 15940 RVA: 0x000F8318 File Offset: 0x000F6518
		// (set) Token: 0x06003E45 RID: 15941 RVA: 0x000F832C File Offset: 0x000F652C
		public decimal TotalParts
		{
			[CompilerGenerated]
			get
			{
				return this.<TotalParts>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<TotalParts>k__BackingField, value))
				{
					return;
				}
				this.<TotalParts>k__BackingField = value;
				this.RaisePropertyChanged("TotalParts");
			}
		}

		// Token: 0x170010D1 RID: 4305
		// (get) Token: 0x06003E46 RID: 15942 RVA: 0x000F835C File Offset: 0x000F655C
		// (set) Token: 0x06003E47 RID: 15943 RVA: 0x000F8370 File Offset: 0x000F6570
		public decimal TotalRepairCost
		{
			[CompilerGenerated]
			get
			{
				return this.<TotalRepairCost>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<TotalRepairCost>k__BackingField, value))
				{
					return;
				}
				this.<TotalRepairCost>k__BackingField = value;
				this.RaisePropertyChanged("TotalRepairCost");
			}
		}

		// Token: 0x170010D2 RID: 4306
		// (get) Token: 0x06003E48 RID: 15944 RVA: 0x000F83A0 File Offset: 0x000F65A0
		// (set) Token: 0x06003E49 RID: 15945 RVA: 0x000F83B4 File Offset: 0x000F65B4
		public bool AddWorksWithoutPrice
		{
			[CompilerGenerated]
			get
			{
				return this.<AddWorksWithoutPrice>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<AddWorksWithoutPrice>k__BackingField == value)
				{
					return;
				}
				this.<AddWorksWithoutPrice>k__BackingField = value;
				this.RaisePropertyChanged("AddWorksWithoutPrice");
			}
		}

		// Token: 0x170010D3 RID: 4307
		// (get) Token: 0x06003E4A RID: 15946 RVA: 0x000F83E0 File Offset: 0x000F65E0
		// (set) Token: 0x06003E4B RID: 15947 RVA: 0x000F83F4 File Offset: 0x000F65F4
		public List<Warranty> WarrantyOptionses
		{
			[CompilerGenerated]
			get
			{
				return this.<WarrantyOptionses>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<WarrantyOptionses>k__BackingField, value))
				{
					return;
				}
				this.<WarrantyOptionses>k__BackingField = value;
				this.RaisePropertyChanged("WarrantyOptionses");
			}
		}

		// Token: 0x170010D4 RID: 4308
		// (get) Token: 0x06003E4C RID: 15948 RVA: 0x000F8424 File Offset: 0x000F6624
		// (set) Token: 0x06003E4D RID: 15949 RVA: 0x000F8438 File Offset: 0x000F6638
		public bool CanMasterChange
		{
			[CompilerGenerated]
			get
			{
				return this.<CanMasterChange>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CanMasterChange>k__BackingField == value)
				{
					return;
				}
				this.<CanMasterChange>k__BackingField = value;
				this.RaisePropertyChanged("CanMasterChange");
			}
		}

		// Token: 0x170010D5 RID: 4309
		// (get) Token: 0x06003E4E RID: 15950 RVA: 0x000F8464 File Offset: 0x000F6664
		public bool PartsIncludedVisibility
		{
			get
			{
				return Auth.Config.parts_included;
			}
		}

		// Token: 0x170010D6 RID: 4310
		// (get) Token: 0x06003E4F RID: 15951 RVA: 0x000F847C File Offset: 0x000F667C
		// (set) Token: 0x06003E50 RID: 15952 RVA: 0x000F8490 File Offset: 0x000F6690
		public string UidItem
		{
			[CompilerGenerated]
			get
			{
				return this.<UidItem>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<UidItem>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<UidItem>k__BackingField = value;
				this.RaisePropertyChanged("UidItem");
			}
		}

		// Token: 0x170010D7 RID: 4311
		// (get) Token: 0x06003E51 RID: 15953 RVA: 0x000F84C0 File Offset: 0x000F66C0
		// (set) Token: 0x06003E52 RID: 15954 RVA: 0x000F84D4 File Offset: 0x000F66D4
		public bool ExpressMode
		{
			[CompilerGenerated]
			get
			{
				return this.<ExpressMode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ExpressMode>k__BackingField == value)
				{
					return;
				}
				this.<ExpressMode>k__BackingField = value;
				this.RaisePropertyChanged("AllowEdit");
				this.RaisePropertyChanged("ExpressMode");
			}
		}

		// Token: 0x170010D8 RID: 4312
		// (get) Token: 0x06003E53 RID: 15955 RVA: 0x000F850C File Offset: 0x000F670C
		public bool AllowEdit
		{
			get
			{
				return this.ExpressMode || this.CanAddPriceWork();
			}
		}

		// Token: 0x06003E54 RID: 15956 RVA: 0x000F852C File Offset: 0x000F672C
		public WpViewModel()
		{
			this._internalReserveModel = Bootstrapper.Container.Resolve<IInternalReserveModel>();
			this._navigationService = Bootstrapper.Container.Resolve<ASC.Services.Abstract.INavigationService>();
			this._workshopWorkService = Bootstrapper.Container.Resolve<IWorkshopWorkService>();
			this._workshopPartService = Bootstrapper.Container.Resolve<IWorkshopPartService>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this.AddWorksWithoutPrice = OfflineData.Instance.Employee.Can(50, 0);
			this._wsOptions = new WorkshopOptions();
		}

		// Token: 0x06003E55 RID: 15957 RVA: 0x000F85B4 File Offset: 0x000F67B4
		public WpViewModel(workshop repair) : this()
		{
			this.Repair = repair;
			if (this.Repair != null)
			{
				this.RepairId = this.Repair.id;
				this.RepairState = this.Repair.state;
				this.WarrantyOptionses = WarrantyOptions.GetAll();
				this.LoadData();
				this.CanMasterChange = OfflineData.Instance.Employee.Can(25, 0);
				this.CountTotal();
				Messenger.Default.Register(this, new Action<Message>(this.OnMessage));
			}
		}

		// Token: 0x06003E56 RID: 15958 RVA: 0x000F8640 File Offset: 0x000F6840
		private void OnMessage(Message message)
		{
			if (message.MessageType == MessageType.OrderStatusChanged && this.Repair != null)
			{
				this.Repair.state = (int)message.RecordID;
				this.RepairState = this.Repair.state;
				Application.Current.Dispatcher.Invoke(delegate()
				{
					base.RaisePropertyChanged<bool>(() => this.AllowEdit);
				});
			}
		}

		// Token: 0x06003E57 RID: 15959 RVA: 0x000F86A0 File Offset: 0x000F68A0
		[Command]
		public void RequestItem()
		{
			this._navigationService.Navigate("RequestCardView", new RequestCardViewModel(this.Repair));
		}

		// Token: 0x06003E58 RID: 15960 RVA: 0x000F86C8 File Offset: 0x000F68C8
		private void LoadData()
		{
			WpViewModel.<LoadData>d__57 <LoadData>d__;
			<LoadData>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadData>d__.<>4__this = this;
			<LoadData>d__.<>1__state = -1;
			<LoadData>d__.<>t__builder.Start<WpViewModel.<LoadData>d__57>(ref <LoadData>d__);
		}

		// Token: 0x06003E59 RID: 15961 RVA: 0x000F8700 File Offset: 0x000F6900
		public virtual void WorkPartsOnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			this.CountTotal();
		}

		// Token: 0x06003E5A RID: 15962 RVA: 0x000F8714 File Offset: 0x000F6914
		[Command]
		public virtual void ItemDoubleClick()
		{
			this._navigationService.Navigate("PartsRequestView", new PartsRequestViewModel(-base.SelectedItem.Id), this);
		}

		// Token: 0x06003E5B RID: 15963 RVA: 0x000F8744 File Offset: 0x000F6944
		public bool CanItemDoubleClick()
		{
			return base.SelectedItem != null && base.SelectedItem.Type == 2;
		}

		// Token: 0x06003E5C RID: 15964 RVA: 0x000F876C File Offset: 0x000F696C
		[Command]
		public virtual void ShowingEditor(TreeListShowingEditorEventArgs e)
		{
			if (((WorkPartObject)e.Node.Content).Type == 2)
			{
				TreeListColumn treeListColumn = e.Column as TreeListColumn;
				if (treeListColumn == null)
				{
					e.Cancel = true;
					return;
				}
				if (treeListColumn.FieldName == "WarrantyCol")
				{
					return;
				}
				e.Cancel = true;
			}
		}

		// Token: 0x06003E5D RID: 15965 RVA: 0x000F87C4 File Offset: 0x000F69C4
		[Command]
		public void AddPart()
		{
			if (this.CheckBeforeAddProduct())
			{
				goto IL_4F;
			}
			IL_0D:
			int num = 1915399874;
			IL_12:
			bool flag;
			switch ((num ^ 286035673) % 5)
			{
			case 1:
				return;
			case 2:
				goto IL_0D;
			case 3:
				IL_4F:
				if (!this.Repair.is_warranty)
				{
					num = 1366629486;
					goto IL_12;
				}
				flag = true;
				goto IL_40;
			case 4:
				flag = this.Repair.is_repeat;
				goto IL_40;
			}
			bool warrantyRepair;
			this._navigationService.NavigateToStore(StoreViewModel.ReturnAction.InsertToRepair, this.RepairId, warrantyRepair, this);
			return;
			IL_40:
			warrantyRepair = flag;
			num = 899389625;
			goto IL_12;
		}

		// Token: 0x06003E5E RID: 15966 RVA: 0x000F8844 File Offset: 0x000F6A44
		public virtual bool CanAddPart()
		{
			return Auth.User.pay_4_sale_in_repair || this.CanAddPriceWork();
		}

		// Token: 0x06003E5F RID: 15967 RVA: 0x000F8868 File Offset: 0x000F6A68
		private bool CheckBeforeAddProduct()
		{
			if (base.SelectedItem != null)
			{
				if (base.SelectedItem.Type == 1)
				{
					return true;
				}
			}
			this._toasterService.Info(Lang.t("SelectWork"));
			return false;
		}

		// Token: 0x06003E60 RID: 15968 RVA: 0x000F88A8 File Offset: 0x000F6AA8
		public virtual void AddProductFromEmployeeCart(store_int_reserve reserve, int count = 1)
		{
			WpViewModel.<AddProductFromEmployeeCart>d__65 <AddProductFromEmployeeCart>d__;
			<AddProductFromEmployeeCart>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<AddProductFromEmployeeCart>d__.<>4__this = this;
			<AddProductFromEmployeeCart>d__.reserve = reserve;
			<AddProductFromEmployeeCart>d__.<>1__state = -1;
			<AddProductFromEmployeeCart>d__.<>t__builder.Start<WpViewModel.<AddProductFromEmployeeCart>d__65>(ref <AddProductFromEmployeeCart>d__);
		}

		// Token: 0x06003E61 RID: 15969 RVA: 0x000F88E8 File Offset: 0x000F6AE8
		public override void OnSelectedItemChanged(WorkPartObject o)
		{
			int lastWorkId;
			if (o != null)
			{
				if (o.Type == 1)
				{
					lastWorkId = o.Id;
					goto IL_18;
				}
			}
			lastWorkId = 0;
			IL_18:
			this._lastWorkId = lastWorkId;
		}

		// Token: 0x06003E62 RID: 15970 RVA: 0x000F8914 File Offset: 0x000F6B14
		private int GetSelectedWorkId()
		{
			WorkPartObject selectedItem = base.SelectedItem;
			if (selectedItem == null)
			{
				return this._lastWorkId;
			}
			return selectedItem.Id;
		}

		// Token: 0x06003E63 RID: 15971 RVA: 0x000F8938 File Offset: 0x000F6B38
		public virtual void AddProductDirectFromStore(store_items product, int count = 1, [Optional] decimal price = 0m)
		{
			WpViewModel.<AddProductDirectFromStore>d__70 <AddProductDirectFromStore>d__;
			<AddProductDirectFromStore>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<AddProductDirectFromStore>d__.<>4__this = this;
			<AddProductDirectFromStore>d__.product = product;
			<AddProductDirectFromStore>d__.count = count;
			<AddProductDirectFromStore>d__.price = price;
			<AddProductDirectFromStore>d__.<>1__state = -1;
			<AddProductDirectFromStore>d__.<>t__builder.Start<WpViewModel.<AddProductDirectFromStore>d__70>(ref <AddProductDirectFromStore>d__);
		}

		// Token: 0x06003E64 RID: 15972 RVA: 0x000F8988 File Offset: 0x000F6B88
		private Task AddItemDirectly(store_items directItem, int count, decimal price)
		{
			WpViewModel.<AddItemDirectly>d__71 <AddItemDirectly>d__;
			<AddItemDirectly>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<AddItemDirectly>d__.<>4__this = this;
			<AddItemDirectly>d__.directItem = directItem;
			<AddItemDirectly>d__.count = count;
			<AddItemDirectly>d__.price = price;
			<AddItemDirectly>d__.<>1__state = -1;
			<AddItemDirectly>d__.<>t__builder.Start<WpViewModel.<AddItemDirectly>d__71>(ref <AddItemDirectly>d__);
			return <AddItemDirectly>d__.<>t__builder.Task;
		}

		// Token: 0x06003E65 RID: 15973 RVA: 0x000F89E4 File Offset: 0x000F6BE4
		private void AddItemToList(WorkPartObject item)
		{
			WpViewModel.<AddItemToList>d__72 <AddItemToList>d__;
			<AddItemToList>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<AddItemToList>d__.<>4__this = this;
			<AddItemToList>d__.item = item;
			<AddItemToList>d__.<>1__state = -1;
			<AddItemToList>d__.<>t__builder.Start<WpViewModel.<AddItemToList>d__72>(ref <AddItemToList>d__);
		}

		// Token: 0x06003E66 RID: 15974 RVA: 0x000F8A24 File Offset: 0x000F6C24
		public WorkPartObject Reserve2Wpo(store_int_reserve reserve, int workId, int repairId, string itemName = "")
		{
			string name = string.IsNullOrEmpty(itemName) ? reserve.store_items.name : itemName;
			return new WorkPartObject(repairId, RepairItem.Types.Part, name, reserve.count, reserve.price)
			{
				Id = -reserve.id,
				Warranty = reserve.warranty,
				SerialNumber = reserve.sn,
				EmployeeId = reserve.to_user,
				ItemId = new int?(reserve.item_id),
				WorkId = new int?(workId)
			};
		}

		// Token: 0x06003E67 RID: 15975 RVA: 0x000F8AAC File Offset: 0x000F6CAC
		public store_int_reserve NewReserve(store_items item, int count, decimal price)
		{
			return new store_int_reserve
			{
				item_id = item.id,
				name = item.name,
				notes = "Выдача товара \"" + item.name + "\" сотруднику " + Auth.User.Fio,
				price = price,
				count = count,
				sn = item.SN,
				to_user = Auth.User.id,
				warranty = item.warranty
			};
		}

		// Token: 0x06003E68 RID: 15976 RVA: 0x000F8B34 File Offset: 0x000F6D34
		public bool ItemsCostBiggerWorkCost(decimal itemSumm)
		{
			if (!Auth.Config.parts_included)
			{
				return false;
			}
			if (itemSumm > base.SelectedItem.Price)
			{
				this._toasterService.Info(Lang.t("PartInsertWarning"));
				return true;
			}
			if (!((from p in base.Items.Where(delegate(WorkPartObject p)
			{
				if (p.Type == 2 && p.WorkId != null)
				{
					int? workId = p.WorkId;
					int id = base.SelectedItem.Id;
					return workId.GetValueOrDefault() == id & workId != null;
				}
				return false;
			})
			select p.Summ).DefaultIfEmpty<decimal>().Sum() + itemSumm > base.SelectedItem.Price))
			{
				return false;
			}
			this._toasterService.Info(Lang.t("InsertPartError"));
			return true;
		}

		// Token: 0x06003E69 RID: 15977 RVA: 0x000F8BF0 File Offset: 0x000F6DF0
		[Command]
		public void AddPriceWork()
		{
			PriceWorksViewModel priceWorksViewModel = Bootstrapper.Container.Resolve<PriceWorksViewModel>();
			priceWorksViewModel.SetReturnSelected(true);
			this._navigationService.Navigate("PriceWorksView", priceWorksViewModel, this);
		}

		// Token: 0x06003E6A RID: 15978 RVA: 0x000F8C24 File Offset: 0x000F6E24
		public virtual bool CanAddPriceWork()
		{
			if (this.Repair == null)
			{
				return false;
			}
			if (this.Repair.office != Auth.User.office && !OfflineData.Instance.Employee.Can(74, 0))
			{
				return false;
			}
			if (!OfflineData.Instance.Employee.Can(25, 0))
			{
				int? master = this.Repair.master;
				int id = Auth.User.id;
				if (!(master.GetValueOrDefault() == id & master != null))
				{
					if (this.Repair.current_manager != Auth.User.id)
					{
						return false;
					}
				}
				return this._wsOptions.CanWorksAndParts(this.RepairState) && OfflineData.Instance.Employee.Can(WorkshopStatus.PerformanceOfWorks);
			}
			return this._wsOptions.CanWorksAndParts(this.RepairState);
		}

		// Token: 0x06003E6B RID: 15979 RVA: 0x000F8CFC File Offset: 0x000F6EFC
		public virtual void AddWorksFromPrice(workshop_price selectedItem)
		{
			WpViewModel.<AddWorksFromPrice>d__78 <AddWorksFromPrice>d__;
			<AddWorksFromPrice>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<AddWorksFromPrice>d__.<>4__this = this;
			<AddWorksFromPrice>d__.selectedItem = selectedItem;
			<AddWorksFromPrice>d__.<>1__state = -1;
			<AddWorksFromPrice>d__.<>t__builder.Start<WpViewModel.<AddWorksFromPrice>d__78>(ref <AddWorksFromPrice>d__);
		}

		// Token: 0x06003E6C RID: 15980 RVA: 0x000F8D3C File Offset: 0x000F6F3C
		[AsyncCommand]
		public virtual Task AddWork(object obj)
		{
			WpViewModel.<AddWork>d__79 <AddWork>d__;
			<AddWork>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<AddWork>d__.<>4__this = this;
			<AddWork>d__.obj = obj;
			<AddWork>d__.<>1__state = -1;
			<AddWork>d__.<>t__builder.Start<WpViewModel.<AddWork>d__79>(ref <AddWork>d__);
			return <AddWork>d__.<>t__builder.Task;
		}

		// Token: 0x06003E6D RID: 15981 RVA: 0x000F8D88 File Offset: 0x000F6F88
		public virtual bool CanAddWork(object obj)
		{
			return this.CanAddPriceWork() && OfflineData.Instance.Employee.Can(50, 0);
		}

		// Token: 0x06003E6E RID: 15982 RVA: 0x000F8DB4 File Offset: 0x000F6FB4
		[AsyncCommand]
		public virtual Task ExpandAllNodes(TreeListNodeChangedEventArgs e)
		{
			WpViewModel.<ExpandAllNodes>d__81 <ExpandAllNodes>d__;
			<ExpandAllNodes>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExpandAllNodes>d__.<>4__this = this;
			<ExpandAllNodes>d__.e = e;
			<ExpandAllNodes>d__.<>1__state = -1;
			<ExpandAllNodes>d__.<>t__builder.Start<WpViewModel.<ExpandAllNodes>d__81>(ref <ExpandAllNodes>d__);
			return <ExpandAllNodes>d__.<>t__builder.Task;
		}

		// Token: 0x06003E6F RID: 15983 RVA: 0x000F8E00 File Offset: 0x000F7000
		public IEnumerable<WorkPartObject> GetWorkParts(int workId)
		{
			return base.Items.Where(delegate(WorkPartObject i)
			{
				if (i.Type == 2)
				{
					int? workId2 = i.WorkId;
					int id = base.SelectedItem.Id;
					return workId2.GetValueOrDefault() == id & workId2 != null;
				}
				return false;
			}).ToList<WorkPartObject>();
		}

		// Token: 0x06003E70 RID: 15984 RVA: 0x000F8E2C File Offset: 0x000F702C
		[AsyncCommand]
		public virtual Task RemoveItem()
		{
			WpViewModel.<RemoveItem>d__83 <RemoveItem>d__;
			<RemoveItem>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<RemoveItem>d__.<>4__this = this;
			<RemoveItem>d__.<>1__state = -1;
			<RemoveItem>d__.<>t__builder.Start<WpViewModel.<RemoveItem>d__83>(ref <RemoveItem>d__);
			return <RemoveItem>d__.<>t__builder.Task;
		}

		// Token: 0x06003E71 RID: 15985 RVA: 0x000F8E70 File Offset: 0x000F7070
		private Task RemovePart(IWorkPartObject part)
		{
			WpViewModel.<RemovePart>d__84 <RemovePart>d__;
			<RemovePart>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<RemovePart>d__.<>4__this = this;
			<RemovePart>d__.part = part;
			<RemovePart>d__.<>1__state = -1;
			<RemovePart>d__.<>t__builder.Start<WpViewModel.<RemovePart>d__84>(ref <RemovePart>d__);
			return <RemovePart>d__.<>t__builder.Task;
		}

		// Token: 0x06003E72 RID: 15986 RVA: 0x000F8EBC File Offset: 0x000F70BC
		private Task RemoveWork(IWorkPartObject work)
		{
			WpViewModel.<RemoveWork>d__85 <RemoveWork>d__;
			<RemoveWork>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<RemoveWork>d__.<>4__this = this;
			<RemoveWork>d__.work = work;
			<RemoveWork>d__.<>1__state = -1;
			<RemoveWork>d__.<>t__builder.Start<WpViewModel.<RemoveWork>d__85>(ref <RemoveWork>d__);
			return <RemoveWork>d__.<>t__builder.Task;
		}

		// Token: 0x06003E73 RID: 15987 RVA: 0x000F8F08 File Offset: 0x000F7108
		public virtual bool CanRemoveItem()
		{
			return this.CanAddPriceWork();
		}

		// Token: 0x06003E74 RID: 15988 RVA: 0x000F8F1C File Offset: 0x000F711C
		public decimal GetSummOf(RepairItem.Types type)
		{
			return (from w in base.Items
			where w.Type == (int)type
			select w.Summ).DefaultIfEmpty<decimal>().Sum();
		}

		// Token: 0x06003E75 RID: 15989 RVA: 0x000F8F7C File Offset: 0x000F717C
		public void CountTotal()
		{
			this.TotalWorks = this.GetSummOf(RepairItem.Types.Work);
			this.TotalParts = this.GetSummOf(RepairItem.Types.Part);
			this.SetTotalRepairCost(this.TotalWorks, this.TotalParts);
		}

		// Token: 0x06003E76 RID: 15990 RVA: 0x000F8FB8 File Offset: 0x000F71B8
		public void SetTotalRepairCost(decimal works, decimal parts)
		{
			this.TotalRepairCost = (Auth.Config.parts_included ? works : (works + parts));
		}

		// Token: 0x06003E77 RID: 15991 RVA: 0x000F8FE4 File Offset: 0x000F71E4
		[Command]
		public void UidGotFocus()
		{
			Messenger.Default.Send(new Message(null, MessageType.StopBarcodeListen));
		}

		// Token: 0x06003E78 RID: 15992 RVA: 0x00091608 File Offset: 0x0008F808
		[Command]
		public void UidLostFocus()
		{
			Messenger.Default.Send(new Message(null, MessageType.StartBarcodeListen));
		}

		// Token: 0x06003E79 RID: 15993 RVA: 0x000F9004 File Offset: 0x000F7204
		[Command]
		public void UidKeyUp(KeyEventArgs e)
		{
			WpViewModel.<UidKeyUp>d__92 <UidKeyUp>d__;
			<UidKeyUp>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<UidKeyUp>d__.<>4__this = this;
			<UidKeyUp>d__.e = e;
			<UidKeyUp>d__.<>1__state = -1;
			<UidKeyUp>d__.<>t__builder.Start<WpViewModel.<UidKeyUp>d__92>(ref <UidKeyUp>d__);
		}

		// Token: 0x06003E7A RID: 15994 RVA: 0x000F9044 File Offset: 0x000F7244
		public bool CanUidKeyUp(KeyEventArgs e)
		{
			return this.CanAddPart();
		}

		// Token: 0x06003E7B RID: 15995 RVA: 0x000F9058 File Offset: 0x000F7258
		[Command]
		public void AddItemByUid()
		{
			WpViewModel.<AddItemByUid>d__94 <AddItemByUid>d__;
			<AddItemByUid>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<AddItemByUid>d__.<>4__this = this;
			<AddItemByUid>d__.<>1__state = -1;
			<AddItemByUid>d__.<>t__builder.Start<WpViewModel.<AddItemByUid>d__94>(ref <AddItemByUid>d__);
		}

		// Token: 0x06003E7C RID: 15996 RVA: 0x000F9044 File Offset: 0x000F7244
		public bool CanAddItemByUid()
		{
			return this.CanAddPart();
		}

		// Token: 0x06003E7D RID: 15997 RVA: 0x000F9090 File Offset: 0x000F7290
		private bool CanItemDirectInsert()
		{
			if (!OfflineData.Instance.Employee.Can(69, 0))
			{
				this._toasterService.Info(Lang.t("CheckPermissions"));
				return false;
			}
			return true;
		}

		// Token: 0x06003E7E RID: 15998 RVA: 0x000F90CC File Offset: 0x000F72CC
		private bool CheckItemBeforeDirectAdd(store_items item)
		{
			if (item == null)
			{
				this._toasterService.Info(Lang.t("ItemNotFound"));
				return true;
			}
			if (item.Available >= 1)
			{
				return false;
			}
			this._toasterService.Info(Lang.t("ItemCountErr"));
			return true;
		}

		// Token: 0x06003E7F RID: 15999 RVA: 0x000F9114 File Offset: 0x000F7314
		[Command]
		public void CopyItemName()
		{
			if (base.SelectedItem == null)
			{
				return;
			}
			Clipboard.SetText(string.Format("{0} {1} {2:N0}", base.SelectedItem.Name, base.SelectedItem.Count, base.SelectedItem.Summ));
		}

		// Token: 0x06003E80 RID: 16000 RVA: 0x000F9164 File Offset: 0x000F7364
		public override void OnLoad()
		{
			base.OnLoad();
			base.RaiseCanExecuteChanged(() => this.RemoveItem());
		}

		// Token: 0x06003E81 RID: 16001 RVA: 0x000F91B4 File Offset: 0x000F73B4
		public void DataRefresh()
		{
			base.Items.CollectionChanged -= this.WorkPartsOnCollectionChanged;
			this.LoadData();
			this.CountTotal();
		}

		// Token: 0x06003E82 RID: 16002 RVA: 0x000F91E8 File Offset: 0x000F73E8
		[CompilerGenerated]
		private void <OnMessage>b__55_0()
		{
			base.RaisePropertyChanged<bool>(() => this.AllowEdit);
		}

		// Token: 0x06003E83 RID: 16003 RVA: 0x000F922C File Offset: 0x000F742C
		[CompilerGenerated]
		private bool <ItemsCostBiggerWorkCost>b__75_0(WorkPartObject p)
		{
			if (p.Type == 2 && p.WorkId != null)
			{
				int? workId = p.WorkId;
				int id = base.SelectedItem.Id;
				return workId.GetValueOrDefault() == id & workId != null;
			}
			return false;
		}

		// Token: 0x06003E84 RID: 16004 RVA: 0x000F927C File Offset: 0x000F747C
		[CompilerGenerated]
		private Task <ExpandAllNodes>b__81_0()
		{
			return this._workshopWorkService.UpdateWorks(base.SelectedItem);
		}

		// Token: 0x06003E85 RID: 16005 RVA: 0x000F929C File Offset: 0x000F749C
		[CompilerGenerated]
		private Task <ExpandAllNodes>b__81_1()
		{
			return this._workshopPartService.UpdatePart(base.SelectedItem);
		}

		// Token: 0x06003E86 RID: 16006 RVA: 0x000F92BC File Offset: 0x000F74BC
		[CompilerGenerated]
		private bool <GetWorkParts>b__82_0(WorkPartObject i)
		{
			if (i.Type == 2)
			{
				int? workId = i.WorkId;
				int id = base.SelectedItem.Id;
				return workId.GetValueOrDefault() == id & workId != null;
			}
			return false;
		}

		// Token: 0x040028BC RID: 10428
		private readonly IInternalReserveModel _internalReserveModel;

		// Token: 0x040028BD RID: 10429
		private readonly ASC.Services.Abstract.INavigationService _navigationService;

		// Token: 0x040028BE RID: 10430
		private readonly IWorkshopWorkService _workshopWorkService;

		// Token: 0x040028BF RID: 10431
		private readonly IWorkshopPartService _workshopPartService;

		// Token: 0x040028C0 RID: 10432
		[CompilerGenerated]
		private workshop <Repair>k__BackingField;

		// Token: 0x040028C1 RID: 10433
		[CompilerGenerated]
		private int <RepairId>k__BackingField;

		// Token: 0x040028C2 RID: 10434
		[CompilerGenerated]
		private int <RepairState>k__BackingField;

		// Token: 0x040028C3 RID: 10435
		[CompilerGenerated]
		private decimal <TotalWorks>k__BackingField;

		// Token: 0x040028C4 RID: 10436
		[CompilerGenerated]
		private decimal <TotalParts>k__BackingField;

		// Token: 0x040028C5 RID: 10437
		[CompilerGenerated]
		private decimal <TotalRepairCost>k__BackingField;

		// Token: 0x040028C6 RID: 10438
		[CompilerGenerated]
		private bool <AddWorksWithoutPrice>k__BackingField;

		// Token: 0x040028C7 RID: 10439
		[CompilerGenerated]
		private List<Warranty> <WarrantyOptionses>k__BackingField;

		// Token: 0x040028C8 RID: 10440
		private readonly WorkshopOptions _wsOptions;

		// Token: 0x040028C9 RID: 10441
		[CompilerGenerated]
		private bool <CanMasterChange>k__BackingField;

		// Token: 0x040028CA RID: 10442
		[CompilerGenerated]
		private string <UidItem>k__BackingField;

		// Token: 0x040028CB RID: 10443
		[CompilerGenerated]
		private bool <ExpressMode>k__BackingField;

		// Token: 0x040028CC RID: 10444
		private int _lastWorkId;

		// Token: 0x040028CD RID: 10445
		protected IToasterService _toasterService;

		// Token: 0x0200082A RID: 2090
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadData>d__57 : IAsyncStateMachine
		{
			// Token: 0x06003E87 RID: 16007 RVA: 0x000F92FC File Offset: 0x000F74FC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WpViewModel wpViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<WorkPartObject>> awaiter;
					List<WorkPartObject> result;
					if (num != 0)
					{
						if (num != 1)
						{
							if (!OfflineData.Instance.Employee.Can(77, 0))
							{
								awaiter = RepairModel.LoadWorkParts(wpViewModel.RepairId, OfflineData.Instance.Employee.Id).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									this.<>1__state = 1;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<WorkPartObject>>, WpViewModel.<LoadData>d__57>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = RepairModel.LoadWorkParts(wpViewModel.RepairId).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									this.<>1__state = 0;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<WorkPartObject>>, WpViewModel.<LoadData>d__57>(ref awaiter, ref this);
									return;
								}
								goto IL_101;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<WorkPartObject>>);
							this.<>1__state = -1;
						}
						result = awaiter.GetResult();
						wpViewModel.SetItems(result);
						goto IL_110;
					}
					awaiter = this.<>u__1;
					this.<>u__1 = default(TaskAwaiter<List<WorkPartObject>>);
					this.<>1__state = -1;
					IL_101:
					result = awaiter.GetResult();
					wpViewModel.SetItems(result);
					IL_110:
					wpViewModel.Items.CollectionChanged += wpViewModel.WorkPartsOnCollectionChanged;
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

			// Token: 0x06003E88 RID: 16008 RVA: 0x000F947C File Offset: 0x000F767C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040028CE RID: 10446
			public int <>1__state;

			// Token: 0x040028CF RID: 10447
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040028D0 RID: 10448
			public WpViewModel <>4__this;

			// Token: 0x040028D1 RID: 10449
			private TaskAwaiter<List<WorkPartObject>> <>u__1;
		}

		// Token: 0x0200082B RID: 2091
		[CompilerGenerated]
		private sealed class <>c__DisplayClass65_0
		{
			// Token: 0x06003E89 RID: 16009 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass65_0()
			{
			}

			// Token: 0x06003E8A RID: 16010 RVA: 0x000F9498 File Offset: 0x000F7698
			internal Task <AddProductFromEmployeeCart>b__0()
			{
				return this.<>4__this._workshopPartService.AddPart(this.i);
			}

			// Token: 0x040028D2 RID: 10450
			public WpViewModel <>4__this;

			// Token: 0x040028D3 RID: 10451
			public WorkPartObject i;
		}

		// Token: 0x0200082C RID: 2092
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <AddProductFromEmployeeCart>d__65 : IAsyncStateMachine
		{
			// Token: 0x06003E8B RID: 16011 RVA: 0x000F94BC File Offset: 0x000F76BC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WpViewModel wpViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						this.<>8__1 = new WpViewModel.<>c__DisplayClass65_0();
						this.<>8__1.<>4__this = this.<>4__this;
						if (this.reserve == null)
						{
							goto IL_166;
						}
						int selectedWorkId = wpViewModel.GetSelectedWorkId();
						if (wpViewModel.ItemsCostBiggerWorkCost(this.reserve.Summ))
						{
							goto IL_166;
						}
						this.<>8__1.i = wpViewModel.Reserve2Wpo(this.reserve, selectedWorkId, wpViewModel.RepairId, "");
						wpViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = Task.Run(new Func<Task>(this.<>8__1.<AddProductFromEmployeeCart>b__0)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WpViewModel.<AddProductFromEmployeeCart>d__65>(ref awaiter, ref this);
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
					catch (Exception ex)
					{
						wpViewModel.HideWait();
						wpViewModel._toasterService.Error(ex.Message);
						goto IL_166;
					}
					finally
					{
						if (num < 0)
						{
							wpViewModel.HideWait();
						}
					}
					wpViewModel._toasterService.Success(Lang.t("PartsUpdated"));
					wpViewModel.AddItemToList(this.<>8__1.i);
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_166:
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003E8C RID: 16012 RVA: 0x000F9698 File Offset: 0x000F7898
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040028D4 RID: 10452
			public int <>1__state;

			// Token: 0x040028D5 RID: 10453
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040028D6 RID: 10454
			public WpViewModel <>4__this;

			// Token: 0x040028D7 RID: 10455
			public store_int_reserve reserve;

			// Token: 0x040028D8 RID: 10456
			private WpViewModel.<>c__DisplayClass65_0 <>8__1;

			// Token: 0x040028D9 RID: 10457
			private TaskAwaiter <>u__1;
		}

		// Token: 0x0200082D RID: 2093
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <AddProductDirectFromStore>d__70 : IAsyncStateMachine
		{
			// Token: 0x06003E8D RID: 16013 RVA: 0x000F96B4 File Offset: 0x000F78B4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WpViewModel wpViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (this.product == null || !OfflineData.Instance.Employee.Can(69, 0))
						{
							goto IL_14D;
						}
						int? num2 = StoreModel.OfficeIdByStoreId(this.product.store);
						int office = Auth.User.office;
						if (!(num2.GetValueOrDefault() == office & num2 != null))
						{
							wpViewModel._toasterService.Error(Lang.t("ItemInForeignOffice"));
							goto IL_14D;
						}
						decimal itemSumm = this.product.price * this.count;
						if (!wpViewModel.Repair.is_warranty && !wpViewModel.Repair.is_repeat && wpViewModel.ItemsCostBiggerWorkCost(itemSumm))
						{
							goto IL_14D;
						}
						awaiter = wpViewModel.AddItemDirectly(this.product, this.count, this.price).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WpViewModel.<AddProductDirectFromStore>d__70>(ref awaiter, ref this);
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
				IL_14D:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003E8E RID: 16014 RVA: 0x000F9840 File Offset: 0x000F7A40
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040028DA RID: 10458
			public int <>1__state;

			// Token: 0x040028DB RID: 10459
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040028DC RID: 10460
			public store_items product;

			// Token: 0x040028DD RID: 10461
			public WpViewModel <>4__this;

			// Token: 0x040028DE RID: 10462
			public int count;

			// Token: 0x040028DF RID: 10463
			public decimal price;

			// Token: 0x040028E0 RID: 10464
			private TaskAwaiter <>u__1;
		}

		// Token: 0x0200082E RID: 2094
		[CompilerGenerated]
		private sealed class <>c__DisplayClass71_0
		{
			// Token: 0x06003E8F RID: 16015 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass71_0()
			{
			}

			// Token: 0x06003E90 RID: 16016 RVA: 0x000F985C File Offset: 0x000F7A5C
			internal store_int_reserve <AddItemDirectly>b__1()
			{
				return this.<>4__this._internalReserveModel.CreateReserve(this.directItem, this.count, this.price, new int?(this.<>4__this.RepairId), new int?(this.workId));
			}

			// Token: 0x06003E91 RID: 16017 RVA: 0x000F98A8 File Offset: 0x000F7AA8
			internal Task <AddItemDirectly>b__0()
			{
				return this.<>4__this._workshopPartService.AddPart(this.it);
			}

			// Token: 0x040028E1 RID: 10465
			public WpViewModel <>4__this;

			// Token: 0x040028E2 RID: 10466
			public store_items directItem;

			// Token: 0x040028E3 RID: 10467
			public int count;

			// Token: 0x040028E4 RID: 10468
			public decimal price;

			// Token: 0x040028E5 RID: 10469
			public int workId;

			// Token: 0x040028E6 RID: 10470
			public WorkPartObject it;
		}

		// Token: 0x0200082F RID: 2095
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <AddItemDirectly>d__71 : IAsyncStateMachine
		{
			// Token: 0x06003E92 RID: 16018 RVA: 0x000F98CC File Offset: 0x000F7ACC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WpViewModel wpViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<store_int_reserve> awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							goto IL_17B;
						}
						this.<>8__1 = new WpViewModel.<>c__DisplayClass71_0();
						this.<>8__1.<>4__this = this.<>4__this;
						this.<>8__1.directItem = this.directItem;
						this.<>8__1.count = this.count;
						this.<>8__1.price = this.price;
						if (this.<>8__1.price == 0m && !wpViewModel.Repair.is_warranty && !wpViewModel.Repair.is_repeat)
						{
							this.<>8__1.price = this.<>8__1.directItem.price;
						}
						if (wpViewModel.ItemsCostBiggerWorkCost(this.<>8__1.price))
						{
							goto IL_25B;
						}
						wpViewModel.ShowWait();
						this.<>8__1.workId = wpViewModel.GetSelectedWorkId();
						awaiter = Task.Run<store_int_reserve>(new Func<store_int_reserve>(this.<>8__1.<AddItemDirectly>b__1)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.<>1__state = num2;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<store_int_reserve>, WpViewModel.<AddItemDirectly>d__71>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<store_int_reserve>);
						int num3 = -1;
						num = -1;
						this.<>1__state = num3;
					}
					store_int_reserve result = awaiter.GetResult();
					this.<>8__1.it = wpViewModel.Reserve2Wpo(result, this.<>8__1.workId, wpViewModel.RepairId, "");
					IL_17B:
					try
					{
						TaskAwaiter awaiter2;
						if (num != 1)
						{
							awaiter2 = Task.Run(new Func<Task>(this.<>8__1.<AddItemDirectly>b__0)).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num4 = 1;
								num = 1;
								this.<>1__state = num4;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WpViewModel.<AddItemDirectly>d__71>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter);
							int num5 = -1;
							num = -1;
							this.<>1__state = num5;
						}
						awaiter2.GetResult();
						wpViewModel._toasterService.Success(Lang.t("PartsUpdated"));
						wpViewModel.AddItemToList(this.<>8__1.it);
					}
					catch (Exception ex)
					{
						wpViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							wpViewModel.HideWait();
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
				IL_25B:
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003E93 RID: 16019 RVA: 0x000F9B9C File Offset: 0x000F7D9C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040028E7 RID: 10471
			public int <>1__state;

			// Token: 0x040028E8 RID: 10472
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040028E9 RID: 10473
			public WpViewModel <>4__this;

			// Token: 0x040028EA RID: 10474
			public store_items directItem;

			// Token: 0x040028EB RID: 10475
			public int count;

			// Token: 0x040028EC RID: 10476
			public decimal price;

			// Token: 0x040028ED RID: 10477
			private WpViewModel.<>c__DisplayClass71_0 <>8__1;

			// Token: 0x040028EE RID: 10478
			private TaskAwaiter<store_int_reserve> <>u__1;

			// Token: 0x040028EF RID: 10479
			private TaskAwaiter <>u__2;
		}

		// Token: 0x02000830 RID: 2096
		[CompilerGenerated]
		private sealed class <>c__DisplayClass72_0
		{
			// Token: 0x06003E94 RID: 16020 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass72_0()
			{
			}

			// Token: 0x06003E95 RID: 16021 RVA: 0x000F9BB8 File Offset: 0x000F7DB8
			internal void <AddItemToList>b__0()
			{
				this.<>4__this.Items.Add(this.item);
			}

			// Token: 0x040028F0 RID: 10480
			public WpViewModel <>4__this;

			// Token: 0x040028F1 RID: 10481
			public WorkPartObject item;
		}

		// Token: 0x02000831 RID: 2097
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <AddItemToList>d__72 : IAsyncStateMachine
		{
			// Token: 0x06003E96 RID: 16022 RVA: 0x000F9BDC File Offset: 0x000F7DDC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						WpViewModel.<>c__DisplayClass72_0 CS$<>8__locals1 = new WpViewModel.<>c__DisplayClass72_0();
						CS$<>8__locals1.<>4__this = this.<>4__this;
						CS$<>8__locals1.item = this.item;
						awaiter = Application.Current.Dispatcher.BeginInvoke(new Action(CS$<>8__locals1.<AddItemToList>b__0), new object[0]).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WpViewModel.<AddItemToList>d__72>(ref awaiter, ref this);
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

			// Token: 0x06003E97 RID: 16023 RVA: 0x000F9CC0 File Offset: 0x000F7EC0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040028F2 RID: 10482
			public int <>1__state;

			// Token: 0x040028F3 RID: 10483
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040028F4 RID: 10484
			public WpViewModel <>4__this;

			// Token: 0x040028F5 RID: 10485
			public WorkPartObject item;

			// Token: 0x040028F6 RID: 10486
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000832 RID: 2098
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003E98 RID: 16024 RVA: 0x000F9CDC File Offset: 0x000F7EDC
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003E99 RID: 16025 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06003E9A RID: 16026 RVA: 0x000F9CF4 File Offset: 0x000F7EF4
			internal decimal <ItemsCostBiggerWorkCost>b__75_1(WorkPartObject p)
			{
				return p.Summ;
			}

			// Token: 0x06003E9B RID: 16027 RVA: 0x000F9D08 File Offset: 0x000F7F08
			internal bool <AddWork>b__79_1(WorkPartObject i)
			{
				return i.Type == 1;
			}

			// Token: 0x06003E9C RID: 16028 RVA: 0x000F9CF4 File Offset: 0x000F7EF4
			internal decimal <GetSummOf>b__87_1(WorkPartObject w)
			{
				return w.Summ;
			}

			// Token: 0x040028F7 RID: 10487
			public static readonly WpViewModel.<>c <>9 = new WpViewModel.<>c();

			// Token: 0x040028F8 RID: 10488
			public static Func<WorkPartObject, decimal> <>9__75_1;

			// Token: 0x040028F9 RID: 10489
			public static Func<WorkPartObject, bool> <>9__79_1;

			// Token: 0x040028FA RID: 10490
			public static Func<WorkPartObject, decimal> <>9__87_1;
		}

		// Token: 0x02000833 RID: 2099
		[CompilerGenerated]
		private sealed class <>c__DisplayClass78_0
		{
			// Token: 0x06003E9D RID: 16029 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass78_0()
			{
			}

			// Token: 0x06003E9E RID: 16030 RVA: 0x000F9D20 File Offset: 0x000F7F20
			internal Task<int> <AddWorksFromPrice>b__0()
			{
				return this.<>4__this._workshopWorkService.CreateWork(this.work);
			}

			// Token: 0x040028FB RID: 10491
			public WpViewModel <>4__this;

			// Token: 0x040028FC RID: 10492
			public WorkPartObject work;
		}

		// Token: 0x02000834 RID: 2100
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <AddWorksFromPrice>d__78 : IAsyncStateMachine
		{
			// Token: 0x06003E9F RID: 16031 RVA: 0x000F9D44 File Offset: 0x000F7F44
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WpViewModel wpViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						this.<>8__1 = new WpViewModel.<>c__DisplayClass78_0();
						this.<>8__1.<>4__this = this.<>4__this;
						if (this.selectedItem == null)
						{
							goto IL_186;
						}
						this.<>8__1.work = new WorkPartObject(wpViewModel.RepairId, RepairItem.Types.Work, this.selectedItem.name, 1, this.selectedItem.price1)
						{
							WorkPriceId = new int?(this.selectedItem.id),
							Warranty = this.selectedItem.warranty.GetValueOrDefault(),
							EmployeeId = OfflineData.Instance.Employee.Id
						};
					}
					try
					{
						TaskAwaiter<int> awaiter;
						if (num != 0)
						{
							awaiter = Task.Run<int>(new Func<Task<int>>(this.<>8__1.<AddWorksFromPrice>b__0)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, WpViewModel.<AddWorksFromPrice>d__78>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<int>);
							this.<>1__state = -1;
						}
						awaiter.GetResult();
						wpViewModel.Items.Add(this.<>8__1.work);
						wpViewModel._toasterService.Success(Lang.t("WorksUpdated"));
					}
					catch (Exception ex)
					{
						wpViewModel._toasterService.Error(ex.Message);
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_186:
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003EA0 RID: 16032 RVA: 0x000F9F28 File Offset: 0x000F8128
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040028FD RID: 10493
			public int <>1__state;

			// Token: 0x040028FE RID: 10494
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040028FF RID: 10495
			public WpViewModel <>4__this;

			// Token: 0x04002900 RID: 10496
			public workshop_price selectedItem;

			// Token: 0x04002901 RID: 10497
			private WpViewModel.<>c__DisplayClass78_0 <>8__1;

			// Token: 0x04002902 RID: 10498
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x02000835 RID: 2101
		[CompilerGenerated]
		private sealed class <>c__DisplayClass79_0
		{
			// Token: 0x06003EA1 RID: 16033 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass79_0()
			{
			}

			// Token: 0x06003EA2 RID: 16034 RVA: 0x000F9F44 File Offset: 0x000F8144
			internal Task<int> <AddWork>b__0()
			{
				return this.<>4__this._workshopWorkService.CreateWork(this.work);
			}

			// Token: 0x04002903 RID: 10499
			public WpViewModel <>4__this;

			// Token: 0x04002904 RID: 10500
			public WorkPartObject work;
		}

		// Token: 0x02000836 RID: 2102
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <AddWork>d__79 : IAsyncStateMachine
		{
			// Token: 0x06003EA3 RID: 16035 RVA: 0x000F9F68 File Offset: 0x000F8168
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WpViewModel wpViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						this.<>8__1 = new WpViewModel.<>c__DisplayClass79_0();
						this.<>8__1.<>4__this = this.<>4__this;
						wpViewModel.ShowWait();
						this.<>8__1.work = new WorkPartObject(wpViewModel.RepairId, RepairItem.Types.Work, "", 1, 0m)
						{
							Warranty = Auth.Config.default_works_warranty,
							EmployeeId = Auth.User.id
						};
						wpViewModel.Items.Add(this.<>8__1.work);
					}
					try
					{
						TaskAwaiter<int> awaiter;
						if (num != 0)
						{
							awaiter = Task.Run<int>(new Func<Task<int>>(this.<>8__1.<AddWork>b__0)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, WpViewModel.<AddWork>d__79>(ref awaiter, ref this);
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
						TreeListControl treeListControl = this.obj as TreeListControl;
						int num4 = wpViewModel.Items.Count(new Func<WorkPartObject, bool>(WpViewModel.<>c.<>9.<AddWork>b__79_1));
						if (treeListControl != null && num4 > 0)
						{
							treeListControl.CurrentColumn = treeListControl.Columns[1];
							treeListControl.View.FocusedNode = treeListControl.View.Nodes[num4 - 1];
							treeListControl.Focus();
							treeListControl.View.ShowEditor(true);
						}
						wpViewModel._toasterService.Success(Lang.t("WorksUpdated"));
					}
					catch (Exception ex)
					{
						if (this.<>8__1.work.Id == 0)
						{
							wpViewModel.Items.Remove(this.<>8__1.work);
						}
						wpViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							wpViewModel.HideWait();
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

			// Token: 0x06003EA4 RID: 16036 RVA: 0x000FA1E0 File Offset: 0x000F83E0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002905 RID: 10501
			public int <>1__state;

			// Token: 0x04002906 RID: 10502
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002907 RID: 10503
			public WpViewModel <>4__this;

			// Token: 0x04002908 RID: 10504
			public object obj;

			// Token: 0x04002909 RID: 10505
			private WpViewModel.<>c__DisplayClass79_0 <>8__1;

			// Token: 0x0400290A RID: 10506
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x02000837 RID: 2103
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ExpandAllNodes>d__81 : IAsyncStateMachine
		{
			// Token: 0x06003EA5 RID: 16037 RVA: 0x000FA1FC File Offset: 0x000F83FC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WpViewModel wpViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						IL_89:
						while (num != 1)
						{
							IL_7A:
							while (this.e.ChangeType == NodeChangeType.Add)
							{
								for (;;)
								{
									TreeListNode parentNode = this.e.Node.ParentNode;
									if (parentNode != null)
									{
										parentNode.ExpandAll();
										uint num2;
										switch ((num2 = (num2 * 887378949U ^ 1369651304U ^ 2319777055U)) % 10U)
										{
										case 0U:
										case 6U:
											goto IL_89;
										case 2U:
											goto IL_A9;
										case 3U:
											goto IL_B7;
										case 4U:
											goto IL_A1;
										case 5U:
											continue;
										case 7U:
											goto IL_7A;
										case 8U:
											goto IL_90;
										case 9U:
											goto IL_D5;
										}
										break;
									}
									goto IL_8F;
								}
								goto IL_177;
								IL_8F:
								break;
								IL_A1:
								if (wpViewModel.SelectedItem == null)
								{
									goto IL_D5;
								}
								IL_A9:
								if (wpViewModel.SelectedItem.Type != 1)
								{
									if (wpViewModel.SelectedItem.Type == 2)
									{
										goto IL_DA;
									}
									goto IL_172;
								}
								IL_B7:
								wpViewModel.ShowWait();
								goto IL_177;
								IL_D5:
								goto IL_23A;
							}
							IL_90:
							if (this.e.ChangeType == NodeChangeType.Content)
							{
								goto IL_A1;
							}
							IL_172:
							goto IL_23A;
						}
						IL_DA:
						try
						{
							TaskAwaiter awaiter;
							if (num != 1)
							{
								awaiter = Task.Run(() => wpViewModel._workshopPartService.UpdatePart(base.SelectedItem)).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num3 = 1;
									num = 1;
									this.<>1__state = num3;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WpViewModel.<ExpandAllNodes>d__81>(ref awaiter, ref this);
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
							wpViewModel._toasterService.Success(Lang.t("PartsUpdated"));
						}
						catch (Exception ex)
						{
							wpViewModel._toasterService.Error(ex.Message);
						}
						goto IL_172;
					}
					IL_177:
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = Task.Run(() => wpViewModel._workshopWorkService.UpdateWorks(base.SelectedItem)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num5 = 0;
								num = 0;
								this.<>1__state = num5;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WpViewModel.<ExpandAllNodes>d__81>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							int num6 = -1;
							num = -1;
							this.<>1__state = num6;
						}
						awaiter.GetResult();
						wpViewModel._toasterService.Success(Lang.t("WorksUpdated"));
						wpViewModel.CountTotal();
					}
					catch (Exception ex2)
					{
						wpViewModel._toasterService.Error(ex2.Message);
					}
					finally
					{
						if (num < 0)
						{
							wpViewModel.HideWait();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_23A:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003EA6 RID: 16038 RVA: 0x000FA4BC File Offset: 0x000F86BC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400290B RID: 10507
			public int <>1__state;

			// Token: 0x0400290C RID: 10508
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400290D RID: 10509
			public TreeListNodeChangedEventArgs e;

			// Token: 0x0400290E RID: 10510
			public WpViewModel <>4__this;

			// Token: 0x0400290F RID: 10511
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000838 RID: 2104
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <RemoveItem>d__83 : IAsyncStateMachine
		{
			// Token: 0x06003EA7 RID: 16039 RVA: 0x000FA4D8 File Offset: 0x000F86D8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WpViewModel wpViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (num != 1)
						{
							if (wpViewModel.SelectedItem == null)
							{
								goto IL_123;
							}
							if (wpViewModel.SelectedItem.Type != 1)
							{
								if (wpViewModel.SelectedItem.Type != 2)
								{
									goto IL_E5;
								}
								awaiter = wpViewModel.RemovePart(wpViewModel.SelectedItem).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									this.<>1__state = 1;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WpViewModel.<RemoveItem>d__83>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = wpViewModel.RemoveWork(wpViewModel.SelectedItem).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									this.<>1__state = 0;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WpViewModel.<RemoveItem>d__83>(ref awaiter, ref this);
									return;
								}
								goto IL_103;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							this.<>1__state = -1;
						}
						awaiter.GetResult();
						IL_E5:
						goto IL_123;
					}
					awaiter = this.<>u__1;
					this.<>u__1 = default(TaskAwaiter);
					this.<>1__state = -1;
					IL_103:
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_123:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003EA8 RID: 16040 RVA: 0x000FA62C File Offset: 0x000F882C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002910 RID: 10512
			public int <>1__state;

			// Token: 0x04002911 RID: 10513
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002912 RID: 10514
			public WpViewModel <>4__this;

			// Token: 0x04002913 RID: 10515
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000839 RID: 2105
		[CompilerGenerated]
		private sealed class <>c__DisplayClass84_0
		{
			// Token: 0x06003EA9 RID: 16041 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass84_0()
			{
			}

			// Token: 0x06003EAA RID: 16042 RVA: 0x000FA648 File Offset: 0x000F8848
			internal Task <RemovePart>b__0()
			{
				return this.<>4__this._workshopPartService.RemovePart(this.part);
			}

			// Token: 0x04002914 RID: 10516
			public WpViewModel <>4__this;

			// Token: 0x04002915 RID: 10517
			public IWorkPartObject part;
		}

		// Token: 0x0200083A RID: 2106
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <RemovePart>d__84 : IAsyncStateMachine
		{
			// Token: 0x06003EAB RID: 16043 RVA: 0x000FA66C File Offset: 0x000F886C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WpViewModel wpViewModel = this.<>4__this;
				try
				{
					WpViewModel.<>c__DisplayClass84_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new WpViewModel.<>c__DisplayClass84_0();
						CS$<>8__locals1.<>4__this = this.<>4__this;
						CS$<>8__locals1.part = this.part;
						if (CS$<>8__locals1.part.EmployeeId != Auth.User.id && !OfflineData.Instance.Employee.Can(25, 0))
						{
							wpViewModel._toasterService.Info(Lang.t("RemovePartError"));
							goto IL_158;
						}
						wpViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = Task.Run(new Func<Task>(CS$<>8__locals1.<RemovePart>b__0)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WpViewModel.<RemovePart>d__84>(ref awaiter, ref this);
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
						wpViewModel.Items.Remove(wpViewModel.SelectedItem);
						wpViewModel.SelectedItem = null;
						wpViewModel._toasterService.Success(Lang.t("PartsUpdated"));
					}
					catch (Exception ex)
					{
						wpViewModel.HideWait();
						wpViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							wpViewModel.HideWait();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_158:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003EAC RID: 16044 RVA: 0x000FA830 File Offset: 0x000F8A30
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002916 RID: 10518
			public int <>1__state;

			// Token: 0x04002917 RID: 10519
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002918 RID: 10520
			public WpViewModel <>4__this;

			// Token: 0x04002919 RID: 10521
			public IWorkPartObject part;

			// Token: 0x0400291A RID: 10522
			private TaskAwaiter <>u__1;
		}

		// Token: 0x0200083B RID: 2107
		[CompilerGenerated]
		private sealed class <>c__DisplayClass85_0
		{
			// Token: 0x06003EAD RID: 16045 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass85_0()
			{
			}

			// Token: 0x06003EAE RID: 16046 RVA: 0x000FA84C File Offset: 0x000F8A4C
			internal Task <RemoveWork>b__0()
			{
				return this.<>4__this._workshopWorkService.RemoveWork(this.work);
			}

			// Token: 0x0400291B RID: 10523
			public WpViewModel <>4__this;

			// Token: 0x0400291C RID: 10524
			public IWorkPartObject work;
		}

		// Token: 0x0200083C RID: 2108
		[CompilerGenerated]
		private sealed class <>c__DisplayClass85_1
		{
			// Token: 0x06003EAF RID: 16047 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass85_1()
			{
			}

			// Token: 0x06003EB0 RID: 16048 RVA: 0x000FA870 File Offset: 0x000F8A70
			internal Task <RemoveWork>b__1()
			{
				return this.CS$<>8__locals1.<>4__this._workshopPartService.RemovePart(this.part);
			}

			// Token: 0x0400291D RID: 10525
			public WorkPartObject part;

			// Token: 0x0400291E RID: 10526
			public WpViewModel.<>c__DisplayClass85_0 CS$<>8__locals1;
		}

		// Token: 0x0200083D RID: 2109
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <RemoveWork>d__85 : IAsyncStateMachine
		{
			// Token: 0x06003EB1 RID: 16049 RVA: 0x000FA898 File Offset: 0x000F8A98
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WpViewModel wpViewModel = this.<>4__this;
				try
				{
					IEnumerable<WorkPartObject> workParts;
					if (num > 1)
					{
						this.<>8__1 = new WpViewModel.<>c__DisplayClass85_0();
						this.<>8__1.<>4__this = this.<>4__this;
						this.<>8__1.work = this.work;
						wpViewModel.ShowWait();
						workParts = wpViewModel.GetWorkParts(this.<>8__1.work.Id);
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
								goto IL_1D2;
							}
							this.<>7__wrap1 = workParts.GetEnumerator();
						}
						try
						{
							if (num == 0)
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
								goto IL_11C;
							}
							IL_B5:
							if (!this.<>7__wrap1.MoveNext())
							{
								goto IL_183;
							}
							this.<>8__2 = new WpViewModel.<>c__DisplayClass85_1();
							this.<>8__2.CS$<>8__locals1 = this.<>8__1;
							this.<>8__2.part = this.<>7__wrap1.Current;
							awaiter = Task.Run(new Func<Task>(this.<>8__2.<RemoveWork>b__1)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num4 = 0;
								num = 0;
								this.<>1__state = num4;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WpViewModel.<RemoveWork>d__85>(ref awaiter, ref this);
								return;
							}
							IL_11C:
							awaiter.GetResult();
							wpViewModel.Items.Remove(this.<>8__2.part);
							this.<>8__2 = null;
							goto IL_B5;
						}
						finally
						{
							if (num < 0 && this.<>7__wrap1 != null)
							{
								this.<>7__wrap1.Dispose();
							}
						}
						IL_183:
						this.<>7__wrap1 = null;
						awaiter = Task.Run(new Func<Task>(this.<>8__1.<RemoveWork>b__0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num5 = 1;
							num = 1;
							this.<>1__state = num5;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WpViewModel.<RemoveWork>d__85>(ref awaiter, ref this);
							return;
						}
						IL_1D2:
						awaiter.GetResult();
						wpViewModel.Items.Remove(wpViewModel.SelectedItem);
						wpViewModel.SelectedItem = null;
						wpViewModel._toasterService.Success(Lang.t("WorksUpdated"));
					}
					catch (Exception ex)
					{
						wpViewModel.HideWait();
						wpViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							wpViewModel.HideWait();
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

			// Token: 0x06003EB2 RID: 16050 RVA: 0x000FAB78 File Offset: 0x000F8D78
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400291F RID: 10527
			public int <>1__state;

			// Token: 0x04002920 RID: 10528
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002921 RID: 10529
			public WpViewModel <>4__this;

			// Token: 0x04002922 RID: 10530
			public IWorkPartObject work;

			// Token: 0x04002923 RID: 10531
			private WpViewModel.<>c__DisplayClass85_0 <>8__1;

			// Token: 0x04002924 RID: 10532
			private WpViewModel.<>c__DisplayClass85_1 <>8__2;

			// Token: 0x04002925 RID: 10533
			private IEnumerator<WorkPartObject> <>7__wrap1;

			// Token: 0x04002926 RID: 10534
			private TaskAwaiter <>u__1;
		}

		// Token: 0x0200083E RID: 2110
		[CompilerGenerated]
		private sealed class <>c__DisplayClass87_0
		{
			// Token: 0x06003EB3 RID: 16051 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass87_0()
			{
			}

			// Token: 0x06003EB4 RID: 16052 RVA: 0x000FAB94 File Offset: 0x000F8D94
			internal bool <GetSummOf>b__0(WorkPartObject w)
			{
				return w.Type == (int)this.type;
			}

			// Token: 0x04002927 RID: 10535
			public RepairItem.Types type;
		}

		// Token: 0x0200083F RID: 2111
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UidKeyUp>d__92 : IAsyncStateMachine
		{
			// Token: 0x06003EB5 RID: 16053 RVA: 0x000FABB0 File Offset: 0x000F8DB0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WpViewModel wpViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter<store_items> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter);
							this.<>1__state = -1;
							goto IL_163;
						}
						if (string.IsNullOrEmpty(wpViewModel.UidItem))
						{
							goto IL_1AA;
						}
						if (wpViewModel.UidItem.Length != 12)
						{
							if (this.e.Key != Key.Return)
							{
								goto IL_16A;
							}
							wpViewModel.AddItemByUid();
							goto IL_16A;
						}
						else
						{
							if (!wpViewModel.CanItemDirectInsert())
							{
								goto IL_1AA;
							}
							if (!Barcode.IsAscCode(wpViewModel.UidItem))
							{
								goto IL_1AA;
							}
							if (Barcode.GetTypeFromCode(wpViewModel.UidItem) != 1)
							{
								goto IL_1AA;
							}
							int idFromCode = Barcode.GetIdFromCode(wpViewModel.UidItem);
							if (idFromCode == 0)
							{
								goto IL_1AA;
							}
							wpViewModel.UidItem = "";
							awaiter2 = new StoreModel().LoadItem(idFromCode).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<store_items>, WpViewModel.<UidKeyUp>d__92>(ref awaiter2, ref this);
								return;
							}
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<store_items>);
						this.<>1__state = -1;
					}
					store_items result = awaiter2.GetResult();
					if (!wpViewModel.CheckBeforeAddProduct())
					{
						goto IL_1AA;
					}
					if (wpViewModel.CheckItemBeforeDirectAdd(result))
					{
						goto IL_1AA;
					}
					awaiter = wpViewModel.AddItemDirectly(result, 1, result.price).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WpViewModel.<UidKeyUp>d__92>(ref awaiter, ref this);
						return;
					}
					IL_163:
					awaiter.GetResult();
					IL_16A:;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_1AA:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003EB6 RID: 16054 RVA: 0x000FAD98 File Offset: 0x000F8F98
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002928 RID: 10536
			public int <>1__state;

			// Token: 0x04002929 RID: 10537
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400292A RID: 10538
			public WpViewModel <>4__this;

			// Token: 0x0400292B RID: 10539
			public KeyEventArgs e;

			// Token: 0x0400292C RID: 10540
			private TaskAwaiter<store_items> <>u__1;

			// Token: 0x0400292D RID: 10541
			private TaskAwaiter <>u__2;
		}

		// Token: 0x02000840 RID: 2112
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <AddItemByUid>d__94 : IAsyncStateMachine
		{
			// Token: 0x06003EB7 RID: 16055 RVA: 0x000FADB4 File Offset: 0x000F8FB4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WpViewModel wpViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter<store_items> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter);
							this.<>1__state = -1;
							goto IL_157;
						}
						if (!wpViewModel.CheckBeforeAddProduct())
						{
							goto IL_184;
						}
						if (string.IsNullOrEmpty(wpViewModel.UidItem))
						{
							wpViewModel._toasterService.Info(Lang.t("InputID"));
							goto IL_184;
						}
						if (!wpViewModel.CanItemDirectInsert())
						{
							goto IL_184;
						}
						int num2;
						int.TryParse(wpViewModel.UidItem, out num2);
						if (num2 == 0)
						{
							wpViewModel._toasterService.Error(Lang.t("ItemError"));
							goto IL_184;
						}
						awaiter2 = new StoreModel().LoadItem(num2).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<store_items>, WpViewModel.<AddItemByUid>d__94>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<store_items>);
						this.<>1__state = -1;
					}
					store_items result = awaiter2.GetResult();
					if (wpViewModel.CheckItemBeforeDirectAdd(result))
					{
						goto IL_184;
					}
					awaiter = wpViewModel.AddItemDirectly(result, 1, result.price).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WpViewModel.<AddItemByUid>d__94>(ref awaiter, ref this);
						return;
					}
					IL_157:
					awaiter.GetResult();
					wpViewModel.UidItem = "";
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_184:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003EB8 RID: 16056 RVA: 0x000FAF74 File Offset: 0x000F9174
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400292E RID: 10542
			public int <>1__state;

			// Token: 0x0400292F RID: 10543
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04002930 RID: 10544
			public WpViewModel <>4__this;

			// Token: 0x04002931 RID: 10545
			private TaskAwaiter<store_items> <>u__1;

			// Token: 0x04002932 RID: 10546
			private TaskAwaiter <>u__2;
		}
	}
}
