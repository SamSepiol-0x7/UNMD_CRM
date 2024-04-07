using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.ItemsCancellation;
using ASC.Objects;
using ASC.Services.Abstract;
using ASC.ViewModels;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.PartsRequest
{
	// Token: 0x02000189 RID: 393
	public class PartsRequestViewModel : BaseViewModel
	{
		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x060017B2 RID: 6066 RVA: 0x0003E954 File Offset: 0x0003CB54
		// (set) Token: 0x060017B3 RID: 6067 RVA: 0x0003E968 File Offset: 0x0003CB68
		public store_int_reserve Reserve
		{
			[CompilerGenerated]
			get
			{
				return this.<Reserve>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Reserve>k__BackingField, value))
				{
					return;
				}
				this.<Reserve>k__BackingField = value;
				this.RaisePropertyChanged("RequestPartVisible");
				this.RaisePropertyChanged("GivePartVisible");
				this.RaisePropertyChanged("Rejectable");
				this.RaisePropertyChanged("Reserve");
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x060017B4 RID: 6068 RVA: 0x0003E9B8 File Offset: 0x0003CBB8
		// (set) Token: 0x060017B5 RID: 6069 RVA: 0x0003E9CC File Offset: 0x0003CBCC
		public tasks Task
		{
			[CompilerGenerated]
			get
			{
				return this.<Task>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Task>k__BackingField, value))
				{
					return;
				}
				this.<Task>k__BackingField = value;
				this.RaisePropertyChanged("Task");
			}
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x060017B6 RID: 6070 RVA: 0x0003E9FC File Offset: 0x0003CBFC
		// (set) Token: 0x060017B7 RID: 6071 RVA: 0x0003EA10 File Offset: 0x0003CC10
		public bool IsRequest
		{
			[CompilerGenerated]
			get
			{
				return this.<IsRequest>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IsRequest>k__BackingField == value)
				{
					return;
				}
				this.<IsRequest>k__BackingField = value;
				this.RaisePropertyChanged("RequestPartVisible");
				this.RaisePropertyChanged("GivePartVisible");
				this.RaisePropertyChanged("IsRequest");
			}
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x060017B8 RID: 6072 RVA: 0x0003EA54 File Offset: 0x0003CC54
		public bool RequestPartVisible
		{
			get
			{
				return this.IsRequest && this.Reserve != null && this.Reserve.state == 0 && this.Reserve.id == 0;
			}
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x060017B9 RID: 6073 RVA: 0x0003EA90 File Offset: 0x0003CC90
		public bool GivePartVisible
		{
			get
			{
				return !this.IsRequest && this.Reserve != null && this.Reserve.state == 0;
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x060017BA RID: 6074 RVA: 0x0003EAC0 File Offset: 0x0003CCC0
		public bool Rejectable
		{
			get
			{
				return this.CanRejectRequest();
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x060017BB RID: 6075 RVA: 0x0003EAD4 File Offset: 0x0003CCD4
		// (set) Token: 0x060017BC RID: 6076 RVA: 0x0003EAE8 File Offset: 0x0003CCE8
		public int PriceCol
		{
			get
			{
				return this._priceCol;
			}
			set
			{
				if (this._priceCol == value)
				{
					return;
				}
				this._priceCol = value;
				this.RaisePropertyChanged("PriceCol");
				this.SetPrice();
			}
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x060017BD RID: 6077 RVA: 0x0003EB1C File Offset: 0x0003CD1C
		// (set) Token: 0x060017BE RID: 6078 RVA: 0x0003EB30 File Offset: 0x0003CD30
		public List<Employee> Employees
		{
			[CompilerGenerated]
			get
			{
				return this.<Employees>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Employees>k__BackingField, value))
				{
					return;
				}
				this.<Employees>k__BackingField = value;
				this.RaisePropertyChanged("Employees");
			}
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x0003EB60 File Offset: 0x0003CD60
		private void GetEmployees()
		{
			this.Employees = new List<Employee>(OfflineData.Instance.ActiveUsers);
			this.Employees.Insert(0, new Employee
			{
				Id = 0,
				LastName = Lang.t("SelectUser")
			});
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x0003EBAC File Offset: 0x0003CDAC
		private void IoC()
		{
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x0003EBEC File Offset: 0x0003CDEC
		public PartsRequestViewModel()
		{
			this.IoC();
			this.SetViewName("New", "Reserve");
			this.Reserve = new store_int_reserve();
			this.GetEmployees();
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x0003EC44 File Offset: 0x0003CE44
		public PartsRequestViewModel(int itemId, bool isRequest) : this()
		{
			this.IsRequest = isRequest;
			this.Reserve.item_id = itemId;
			this.Reserve.notes = string.Empty;
			this.Reserve = this._model.ReferenceReserve(this.Reserve);
			this.Reserve.price = this.Reserve.store_items.Price2Formatted;
			store_int_reserve reserve = this.Reserve;
			store_items store_items = this.Reserve.store_items;
			reserve.name = ((store_items != null) ? store_items.name : null);
			store_int_reserve reserve2 = this.Reserve;
			store_items store_items2 = this.Reserve.store_items;
			reserve2.warranty = ((store_items2 != null) ? store_items2.warranty : 0);
			this.Reserve.count = 1;
			if (isRequest)
			{
				this.Reserve.to_user = Auth.User.id;
				this.Autocomplete();
			}
			this.Task.item_id = new int?(itemId);
			this.SetPrice();
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x0003ED34 File Offset: 0x0003CF34
		public PartsRequestViewModel(int reserveId)
		{
			this.IoC();
			this.SetViewName("RequestItem2", reserveId);
			this.GetEmployees();
			this._reserveId = reserveId;
			this.LoadReserve();
		}

		// Token: 0x060017C4 RID: 6084 RVA: 0x0003ED8C File Offset: 0x0003CF8C
		public PartsRequestViewModel(int itemId, int repairId) : this(itemId, true)
		{
			this.Reserve.repair_id = new int?(repairId);
			this.Reserve.r_lock = true;
		}

		// Token: 0x060017C5 RID: 6085 RVA: 0x0003EDC0 File Offset: 0x0003CFC0
		private void LoadReserve()
		{
			PartsRequestViewModel.<LoadReserve>d__37 <LoadReserve>d__;
			<LoadReserve>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadReserve>d__.<>4__this = this;
			<LoadReserve>d__.<>1__state = -1;
			<LoadReserve>d__.<>t__builder.Start<PartsRequestViewModel.<LoadReserve>d__37>(ref <LoadReserve>d__);
		}

		// Token: 0x060017C6 RID: 6086 RVA: 0x0003EDF8 File Offset: 0x0003CFF8
		[Command]
		public void OpenRepairCard()
		{
			this._navigationService.NavigateRepairCard(this.Reserve.repair_id.Value);
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x0003EE24 File Offset: 0x0003D024
		public bool CanOpenRepairCard()
		{
			store_int_reserve reserve = this.Reserve;
			return reserve != null && reserve.repair_id != null && (this.Reserve.state == 0 || this.Reserve.state == 2 || this.Reserve.state == 3);
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x0003EE7C File Offset: 0x0003D07C
		[Command]
		public void OpenItemCard()
		{
			store_int_reserve reserve = this.Reserve;
			bool flag;
			if (reserve == null)
			{
				flag = true;
			}
			else
			{
				int item_id = reserve.item_id;
				flag = false;
			}
			if (!flag)
			{
				goto IL_3A;
			}
			IL_16:
			int num = 1561233986;
			IL_1B:
			switch ((num ^ 990477619) % 4)
			{
			case 0:
				goto IL_16;
			case 1:
				return;
			case 3:
				IL_3A:
				this._navigationService.NavigateToStoreItem(this.Reserve.item_id, 0);
				num = 1247748673;
				goto IL_1B;
			}
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x0003EEE4 File Offset: 0x0003D0E4
		[Command]
		public void RejectRequest()
		{
			this.ShowResult2User(this._model.SetReserveState(this.Reserve.id, PartsRequestModel.State.Rejected));
		}

		// Token: 0x060017CA RID: 6090 RVA: 0x0003EF10 File Offset: 0x0003D110
		[Command]
		public void Substract()
		{
			this._windowedDocumentService.ShowNewDocument("ItemsCancellationView", new ItemsCancellationViewModel(this.Reserve), null, null);
		}

		// Token: 0x060017CB RID: 6091 RVA: 0x0003EF3C File Offset: 0x0003D13C
		public bool CanSubstract()
		{
			if (this.Reserve != null && this.Reserve.id != 0)
			{
				if (this.Reserve.state == 1)
				{
					return OfflineData.Instance.Employee.Can(9, 0);
				}
			}
			return false;
		}

		// Token: 0x060017CC RID: 6092 RVA: 0x0003EF84 File Offset: 0x0003D184
		public bool CanRejectRequest()
		{
			return this.Reserve != null && this.Reserve.id != 0 && this.Reserve.state == 0;
		}

		// Token: 0x060017CD RID: 6093 RVA: 0x0003EFB8 File Offset: 0x0003D1B8
		[Command]
		public void Back2Store()
		{
			PartsRequestViewModel.<Back2Store>d__45 <Back2Store>d__;
			<Back2Store>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Back2Store>d__.<>4__this = this;
			<Back2Store>d__.<>1__state = -1;
			<Back2Store>d__.<>t__builder.Start<PartsRequestViewModel.<Back2Store>d__45>(ref <Back2Store>d__);
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x0003EFF0 File Offset: 0x0003D1F0
		public bool CanBack2Store()
		{
			if (!this.IsRequest && this.Reserve != null)
			{
				if (this.Reserve.state == 1)
				{
					return OfflineData.Instance.Employee.Can(45, 0) || OfflineData.Instance.Employee.Can(46, 0);
				}
			}
			return false;
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x0003F048 File Offset: 0x0003D248
		[AsyncCommand]
		public Task Back2Master()
		{
			PartsRequestViewModel.<Back2Master>d__47 <Back2Master>d__;
			<Back2Master>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Back2Master>d__.<>4__this = this;
			<Back2Master>d__.<>1__state = -1;
			<Back2Master>d__.<>t__builder.Start<PartsRequestViewModel.<Back2Master>d__47>(ref <Back2Master>d__);
			return <Back2Master>d__.<>t__builder.Task;
		}

		// Token: 0x060017D0 RID: 6096 RVA: 0x0003F08C File Offset: 0x0003D28C
		public bool CanBack2Master()
		{
			store_int_reserve reserve = this.Reserve;
			if (reserve != null && reserve.repair_id != null && this.Reserve.state > 0)
			{
				int repairState = this._model.GetRepairState(this.Reserve.repair_id.Value);
				return OfflineData.Instance.Employee.Can(47, 0) && repairState != 8 && repairState != 12;
			}
			return false;
		}

		// Token: 0x060017D1 RID: 6097 RVA: 0x0003F108 File Offset: 0x0003D308
		protected override void OnParentViewModelChanged(object parentViewModel)
		{
			base.OnParentViewModelChanged(parentViewModel);
			this._parentViewModel = (parentViewModel as IRefreshable);
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x0003F128 File Offset: 0x0003D328
		private void ShowResult2User(bool result)
		{
			base.ShowActionResponse(result, "");
			if (result)
			{
				this._navigationService.CloseCurrentTab();
			}
		}

		// Token: 0x060017D3 RID: 6099 RVA: 0x0003F150 File Offset: 0x0003D350
		[Command]
		public void GivePart()
		{
			PartsRequestViewModel.<GivePart>d__52 <GivePart>d__;
			<GivePart>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<GivePart>d__.<>4__this = this;
			<GivePart>d__.<>1__state = -1;
			<GivePart>d__.<>t__builder.Start<PartsRequestViewModel.<GivePart>d__52>(ref <GivePart>d__);
		}

		// Token: 0x060017D4 RID: 6100 RVA: 0x0003F188 File Offset: 0x0003D388
		[Command]
		public void RequestPart()
		{
			PartsRequestViewModel.<RequestPart>d__53 <RequestPart>d__;
			<RequestPart>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<RequestPart>d__.<>4__this = this;
			<RequestPart>d__.<>1__state = -1;
			<RequestPart>d__.<>t__builder.Start<PartsRequestViewModel.<RequestPart>d__53>(ref <RequestPart>d__);
		}

		// Token: 0x060017D5 RID: 6101 RVA: 0x0003F1C0 File Offset: 0x0003D3C0
		[Command]
		public void UserChanged()
		{
			if (this.Reserve.to_user != 0)
			{
				goto IL_31;
			}
			IL_0D:
			int num = -744270510;
			IL_12:
			switch ((num ^ -2085339973) % 4)
			{
			case 0:
				IL_31:
				this.Autocomplete();
				num = -666999796;
				goto IL_12;
			case 1:
				return;
			case 2:
				goto IL_0D;
			}
		}

		// Token: 0x060017D6 RID: 6102 RVA: 0x0003F20C File Offset: 0x0003D40C
		public bool CanUserChanged()
		{
			return this.Reserve != null;
		}

		// Token: 0x060017D7 RID: 6103 RVA: 0x0003F224 File Offset: 0x0003D424
		private void Autocomplete()
		{
			if (this.Reserve.id > 0)
			{
				return;
			}
			Employee employee = OfflineData.Instance.ActiveUsers.FirstOrDefault((Employee u) => u.Id == this.Reserve.to_user);
			if (employee == null)
			{
				return;
			}
			this.Reserve.notes = "Выдача товара \"" + this.Reserve.store_items.name + "\" сотруднику " + employee.FioShort;
		}

		// Token: 0x060017D8 RID: 6104 RVA: 0x0003F290 File Offset: 0x0003D490
		private void SetPrice()
		{
			if (this.Reserve.store_items != null)
			{
				for (;;)
				{
					IL_A0:
					int priceCol = this._priceCol;
					for (;;)
					{
						IL_7F:
						switch (priceCol)
						{
						case 1:
							goto IL_C6;
						case 2:
							goto IL_E2;
						case 3:
							goto IL_FE;
						case 4:
							goto IL_11A;
						case 5:
							goto IL_136;
						default:
						{
							uint num2;
							uint num = num2 * 4040237758U ^ 1932305592U;
							for (;;)
							{
								switch ((num2 = (num ^ 2580943532U)) % 15U)
								{
								case 0U:
								case 6U:
									return;
								case 1U:
									goto IL_E2;
								case 2U:
									goto IL_11A;
								case 3U:
									goto IL_A0;
								case 4U:
									goto IL_7F;
								case 5U:
									return;
								case 7U:
									goto IL_C6;
								case 8U:
									num = (num2 * 3890475556U ^ 4246496510U);
									continue;
								case 9U:
									return;
								case 10U:
									goto IL_136;
								case 11U:
									return;
								case 13U:
									return;
								case 14U:
									goto IL_FE;
								}
								goto Block_2;
							}
							break;
						}
						}
					}
				}
				Block_2:
				this.Reserve.price = this.Reserve.store_items.Price2Raw;
				return;
				IL_C6:
				this.Reserve.price = this.Reserve.store_items.Price1Raw;
				return;
				IL_E2:
				this.Reserve.price = this.Reserve.store_items.Price2Raw;
				return;
				IL_FE:
				this.Reserve.price = this.Reserve.store_items.Price3Raw;
				return;
				IL_11A:
				this.Reserve.price = this.Reserve.store_items.Price4Raw;
				return;
				IL_136:
				this.Reserve.price = this.Reserve.store_items.Price5Raw;
				return;
			}
		}

		// Token: 0x060017D9 RID: 6105 RVA: 0x0003F3F0 File Offset: 0x0003D5F0
		private bool CheckFields()
		{
			if (this.Reserve.to_user == 0)
			{
				goto IL_55;
			}
			goto IL_91;
			int num;
			for (;;)
			{
				IL_5A:
				switch ((num ^ -1339001286) % 7)
				{
				case 1:
					goto IL_91;
				case 2:
					goto IL_BA;
				case 3:
					goto IL_55;
				case 4:
					num = ((this.Reserve.count <= this.Reserve.store_items.Available) ? -1175010519 : -2002683247);
					continue;
				case 5:
					goto IL_D1;
				case 6:
					goto IL_E8;
				}
				break;
			}
			return true;
			IL_BA:
			this._toasterService.Info(Lang.t("SelectCoWorker"));
			return false;
			IL_D1:
			this._toasterService.Info(Lang.t("ItemCountErr"));
			return false;
			IL_E8:
			this._toasterService.Info(Lang.t("PriceTooLow"));
			return false;
			IL_55:
			num = -1021914278;
			goto IL_5A;
			IL_91:
			num = ((!(this.Reserve.price < this.Reserve.store_items.in_price)) ? -1651305551 : -849846648);
			goto IL_5A;
		}

		// Token: 0x060017DA RID: 6106 RVA: 0x0003F4FC File Offset: 0x0003D6FC
		[Command]
		public void UpdateSn()
		{
			PartsRequestViewModel.<UpdateSn>d__59 <UpdateSn>d__;
			<UpdateSn>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<UpdateSn>d__.<>4__this = this;
			<UpdateSn>d__.<>1__state = -1;
			<UpdateSn>d__.<>t__builder.Start<PartsRequestViewModel.<UpdateSn>d__59>(ref <UpdateSn>d__);
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x0003F534 File Offset: 0x0003D734
		public bool CanUpdateSn()
		{
			return this.Reserve != null && this.Reserve.id > 0;
		}

		// Token: 0x060017DC RID: 6108 RVA: 0x0003F55C File Offset: 0x0003D75C
		[CompilerGenerated]
		private Task<store_int_reserve> <LoadReserve>b__37_0()
		{
			return this._model.LoadReserve(this._reserveId);
		}

		// Token: 0x060017DD RID: 6109 RVA: 0x0003F57C File Offset: 0x0003D77C
		[CompilerGenerated]
		private bool <Back2Store>b__45_0()
		{
			return this._model.CancellReserve(this.Reserve, PartsRequestModel.State.Archive);
		}

		// Token: 0x060017DE RID: 6110 RVA: 0x0003F59C File Offset: 0x0003D79C
		[CompilerGenerated]
		private Task <Back2Master>b__47_0()
		{
			return this._model.RemoveItemFromRepair(this.Reserve);
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x0003F5BC File Offset: 0x0003D7BC
		[CompilerGenerated]
		private bool <GivePart>b__52_0()
		{
			return this._model.MakeReserve(this.Reserve);
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x0003F5DC File Offset: 0x0003D7DC
		[CompilerGenerated]
		private IAscResult <RequestPart>b__53_0()
		{
			return this._model.MakeRequest(this.Reserve);
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x0003F5FC File Offset: 0x0003D7FC
		[CompilerGenerated]
		private bool <Autocomplete>b__56_0(Employee u)
		{
			return u.Id == this.Reserve.to_user;
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x0003F61C File Offset: 0x0003D81C
		[CompilerGenerated]
		private Task<IAscResult> <UpdateSn>b__59_0()
		{
			return PartsRequestModel.UpdateSn(this.Reserve.id, this.Reserve.sn);
		}

		// Token: 0x04000BE4 RID: 3044
		private INavigationService _navigationService;

		// Token: 0x04000BE5 RID: 3045
		private IToasterService _toasterService;

		// Token: 0x04000BE6 RID: 3046
		private IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04000BE7 RID: 3047
		private PartsRequestModel _model = new PartsRequestModel();

		// Token: 0x04000BE8 RID: 3048
		[CompilerGenerated]
		private store_int_reserve <Reserve>k__BackingField;

		// Token: 0x04000BE9 RID: 3049
		[CompilerGenerated]
		private tasks <Task>k__BackingField = new tasks();

		// Token: 0x04000BEA RID: 3050
		private int _reserveId;

		// Token: 0x04000BEB RID: 3051
		[CompilerGenerated]
		private bool <IsRequest>k__BackingField;

		// Token: 0x04000BEC RID: 3052
		private int _priceCol = 1;

		// Token: 0x04000BED RID: 3053
		[CompilerGenerated]
		private List<Employee> <Employees>k__BackingField;

		// Token: 0x04000BEE RID: 3054
		private IRefreshable _parentViewModel;

		// Token: 0x0200018A RID: 394
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadReserve>d__37 : IAsyncStateMachine
		{
			// Token: 0x060017E3 RID: 6115 RVA: 0x0003F644 File Offset: 0x0003D844
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PartsRequestViewModel partsRequestViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<store_int_reserve> awaiter;
					if (num != 0)
					{
						partsRequestViewModel.ShowWait();
						awaiter = System.Threading.Tasks.Task.Run<store_int_reserve>(() => partsRequestViewModel._model.LoadReserve(partsRequestViewModel._reserveId)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<store_int_reserve>, PartsRequestViewModel.<LoadReserve>d__37>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<store_int_reserve>);
						this.<>1__state = -1;
					}
					store_int_reserve result = awaiter.GetResult();
					partsRequestViewModel.Reserve = result;
					partsRequestViewModel.HideWait();
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

			// Token: 0x060017E4 RID: 6116 RVA: 0x0003F718 File Offset: 0x0003D918
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000BEF RID: 3055
			public int <>1__state;

			// Token: 0x04000BF0 RID: 3056
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000BF1 RID: 3057
			public PartsRequestViewModel <>4__this;

			// Token: 0x04000BF2 RID: 3058
			private TaskAwaiter<store_int_reserve> <>u__1;
		}

		// Token: 0x0200018B RID: 395
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Back2Store>d__45 : IAsyncStateMachine
		{
			// Token: 0x060017E5 RID: 6117 RVA: 0x0003F734 File Offset: 0x0003D934
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PartsRequestViewModel partsRequestViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						partsRequestViewModel.ShowWait();
						awaiter = System.Threading.Tasks.Task.Run<bool>(() => partsRequestViewModel._model.CancellReserve(base.Reserve, PartsRequestModel.State.Archive)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, PartsRequestViewModel.<Back2Store>d__45>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<bool>);
						this.<>1__state = -1;
					}
					bool result = awaiter.GetResult();
					partsRequestViewModel.HideWait();
					if (result)
					{
						IRefreshable parentViewModel = partsRequestViewModel._parentViewModel;
						if (parentViewModel != null)
						{
							parentViewModel.DataRefresh();
						}
					}
					partsRequestViewModel.ShowResult2User(result);
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

			// Token: 0x060017E6 RID: 6118 RVA: 0x0003F81C File Offset: 0x0003DA1C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000BF3 RID: 3059
			public int <>1__state;

			// Token: 0x04000BF4 RID: 3060
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000BF5 RID: 3061
			public PartsRequestViewModel <>4__this;

			// Token: 0x04000BF6 RID: 3062
			private TaskAwaiter<bool> <>u__1;
		}

		// Token: 0x0200018C RID: 396
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Back2Master>d__47 : IAsyncStateMachine
		{
			// Token: 0x060017E7 RID: 6119 RVA: 0x0003F838 File Offset: 0x0003DA38
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PartsRequestViewModel partsRequestViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						partsRequestViewModel.ShowWait();
					}
					try
					{
						try
						{
							if (num != 0)
							{
								goto IL_85;
							}
							goto IL_B1;
							TaskAwaiter awaiter;
							for (;;)
							{
								IL_A5:
								awaiter.GetResult();
								for (;;)
								{
									IRefreshable parentViewModel = partsRequestViewModel._parentViewModel;
									if (parentViewModel != null)
									{
										parentViewModel.DataRefresh();
										uint num2;
										switch ((num2 = (num2 * 2092843589U ^ 4027072629U ^ 3268340658U)) % 12U)
										{
										case 0U:
											goto IL_B1;
										case 1U:
											goto IL_9C;
										case 3U:
											goto IL_A5;
										case 4U:
											goto IL_CF;
										case 5U:
											goto IL_F0;
										case 6U:
										case 8U:
											goto IL_85;
										case 7U:
											goto IL_ED;
										case 9U:
											goto IL_10D;
										case 10U:
											continue;
										case 11U:
											goto IL_D8;
										}
										goto Block_9;
									}
									goto IL_EF;
								}
							}
							Block_9:
							goto IL_118;
							IL_EF:
							IL_F0:
							partsRequestViewModel._toasterService.Success(Lang.t("Saved"));
							if (partsRequestViewModel._parentViewModel == null)
							{
								goto IL_118;
							}
							IL_10D:
							partsRequestViewModel._navigationService.CloseCurrentTab();
							IL_118:
							goto IL_12E;
							IL_85:
							awaiter = System.Threading.Tasks.Task.Run(() => partsRequestViewModel._model.RemoveItemFromRepair(base.Reserve)).GetAwaiter();
							IL_9C:
							if (awaiter.IsCompleted)
							{
								goto IL_A5;
							}
							goto IL_CF;
							IL_B1:
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
							goto IL_A5;
							IL_CF:
							int num4 = 0;
							num = 0;
							this.<>1__state = num4;
							IL_D8:
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, PartsRequestViewModel.<Back2Master>d__47>(ref awaiter, ref this);
							IL_ED:
							return;
						}
						catch (Exception ex)
						{
							partsRequestViewModel._toasterService.Error(ex.Message);
						}
						IL_12E:;
					}
					finally
					{
						if (num < 0)
						{
							partsRequestViewModel.HideWait();
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

			// Token: 0x060017E8 RID: 6120 RVA: 0x0003F9FC File Offset: 0x0003DBFC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000BF7 RID: 3063
			public int <>1__state;

			// Token: 0x04000BF8 RID: 3064
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000BF9 RID: 3065
			public PartsRequestViewModel <>4__this;

			// Token: 0x04000BFA RID: 3066
			private TaskAwaiter <>u__1;
		}

		// Token: 0x0200018D RID: 397
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GivePart>d__52 : IAsyncStateMachine
		{
			// Token: 0x060017E9 RID: 6121 RVA: 0x0003FA18 File Offset: 0x0003DC18
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PartsRequestViewModel partsRequestViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						if (!partsRequestViewModel.CheckFields())
						{
							goto IL_B0;
						}
						partsRequestViewModel.ShowWait();
						awaiter = System.Threading.Tasks.Task.Run<bool>(() => partsRequestViewModel._model.MakeReserve(base.Reserve)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, PartsRequestViewModel.<GivePart>d__52>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<bool>);
						this.<>1__state = -1;
					}
					bool result = awaiter.GetResult();
					partsRequestViewModel.HideWait();
					partsRequestViewModel.ShowResult2User(result);
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_B0:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060017EA RID: 6122 RVA: 0x0003FAF8 File Offset: 0x0003DCF8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000BFB RID: 3067
			public int <>1__state;

			// Token: 0x04000BFC RID: 3068
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000BFD RID: 3069
			public PartsRequestViewModel <>4__this;

			// Token: 0x04000BFE RID: 3070
			private TaskAwaiter<bool> <>u__1;
		}

		// Token: 0x0200018E RID: 398
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <RequestPart>d__53 : IAsyncStateMachine
		{
			// Token: 0x060017EB RID: 6123 RVA: 0x0003FB14 File Offset: 0x0003DD14
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PartsRequestViewModel partsRequestViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IAscResult> awaiter;
					if (num != 0)
					{
						partsRequestViewModel.ShowWait();
						awaiter = System.Threading.Tasks.Task.Run<IAscResult>(() => partsRequestViewModel._model.MakeRequest(base.Reserve)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IAscResult>, PartsRequestViewModel.<RequestPart>d__53>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IAscResult>);
						this.<>1__state = -1;
					}
					IAscResult result = awaiter.GetResult();
					partsRequestViewModel.HideWait();
					string msg = result.IsSucces ? Lang.t("Saved") : result.Message;
					partsRequestViewModel.ShowActionResponse(result.IsSucces, msg);
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

			// Token: 0x060017EC RID: 6124 RVA: 0x0003FC10 File Offset: 0x0003DE10
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000BFF RID: 3071
			public int <>1__state;

			// Token: 0x04000C00 RID: 3072
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000C01 RID: 3073
			public PartsRequestViewModel <>4__this;

			// Token: 0x04000C02 RID: 3074
			private TaskAwaiter<IAscResult> <>u__1;
		}

		// Token: 0x0200018F RID: 399
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateSn>d__59 : IAsyncStateMachine
		{
			// Token: 0x060017ED RID: 6125 RVA: 0x0003FC2C File Offset: 0x0003DE2C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PartsRequestViewModel partsRequestViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IAscResult> awaiter;
					if (num != 0)
					{
						partsRequestViewModel.ShowWait();
						awaiter = System.Threading.Tasks.Task.Run<IAscResult>(() => PartsRequestModel.UpdateSn(base.Reserve.id, base.Reserve.sn)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IAscResult>, PartsRequestViewModel.<UpdateSn>d__59>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IAscResult>);
						this.<>1__state = -1;
					}
					IAscResult result = awaiter.GetResult();
					partsRequestViewModel.HideWait();
					string msg = result.IsSucces ? Lang.t("SnUpdated") : "";
					partsRequestViewModel.ShowActionResponse(result.IsSucces, msg);
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

			// Token: 0x060017EE RID: 6126 RVA: 0x0003FD28 File Offset: 0x0003DF28
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000C03 RID: 3075
			public int <>1__state;

			// Token: 0x04000C04 RID: 3076
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000C05 RID: 3077
			public PartsRequestViewModel <>4__this;

			// Token: 0x04000C06 RID: 3078
			private TaskAwaiter<IAscResult> <>u__1;
		}
	}
}
