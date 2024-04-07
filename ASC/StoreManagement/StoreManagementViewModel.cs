using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Models;
using ASC.Objects;
using ASC.PartsRequest;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using ASC.ViewModels;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.StoreManagement
{
	// Token: 0x02000132 RID: 306
	public class StoreManagementViewModel : CollectionViewModel<StoreIntReserveLite>
	{
		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x0600156D RID: 5485 RVA: 0x000328B0 File Offset: 0x00030AB0
		// (set) Token: 0x0600156E RID: 5486 RVA: 0x000328C4 File Offset: 0x00030AC4
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

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x0600156F RID: 5487 RVA: 0x000328F4 File Offset: 0x00030AF4
		// (set) Token: 0x06001570 RID: 5488 RVA: 0x00032908 File Offset: 0x00030B08
		public Period Period
		{
			[CompilerGenerated]
			get
			{
				return this.<Period>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Period>k__BackingField, value))
				{
					return;
				}
				this.<Period>k__BackingField = value;
				this.RaisePropertyChanged("Period");
			}
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06001571 RID: 5489 RVA: 0x00032938 File Offset: 0x00030B38
		// (set) Token: 0x06001572 RID: 5490 RVA: 0x0003294C File Offset: 0x00030B4C
		public int SelectedStoreId
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedStoreId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedStoreId>k__BackingField == value)
				{
					return;
				}
				this.<SelectedStoreId>k__BackingField = value;
				this.RaisePropertyChanged("SelectedStoreId");
			}
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06001573 RID: 5491 RVA: 0x00032978 File Offset: 0x00030B78
		// (set) Token: 0x06001574 RID: 5492 RVA: 0x0003298C File Offset: 0x00030B8C
		public int SelectedUserId
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedUserId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedUserId>k__BackingField == value)
				{
					return;
				}
				this.<SelectedUserId>k__BackingField = value;
				this.RaisePropertyChanged("SelectedUserId");
			}
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06001575 RID: 5493 RVA: 0x000329B8 File Offset: 0x00030BB8
		// (set) Token: 0x06001576 RID: 5494 RVA: 0x000329FC File Offset: 0x00030BFC
		public string Query
		{
			get
			{
				return base.GetProperty<string>(() => this.Query);
			}
			set
			{
				if (!string.Equals(this.Query, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = 1431370079;
				IL_14:
				switch ((num ^ 1131106786) % 4)
				{
				case 1:
					return;
				case 2:
					IL_33:
					base.SetProperty<string>(() => this.Query, value, new Action(this.Loaded));
					num = 206751422;
					goto IL_14;
				case 3:
					goto IL_0F;
				}
				this.RaisePropertyChanged("Query");
			}
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x00032A94 File Offset: 0x00030C94
		public StoreManagementViewModel()
		{
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
			this.SetViewName("StoreManagement");
			this.Period = new Period();
			this.Statuses = new List<KeyValuePair<int, string>>
			{
				new KeyValuePair<int, string>(-1, Lang.t("All")),
				new KeyValuePair<int, string>(-2, Lang.t("OnlyActual")),
				new KeyValuePair<int, string>(0, Lang.t("Waiting")),
				new KeyValuePair<int, string>(1, Lang.t("ItemOnMaster")),
				new KeyValuePair<int, string>(2, Lang.t("ItemOnRepair")),
				new KeyValuePair<int, string>(3, Lang.t("ItemOnOutRepair")),
				new KeyValuePair<int, string>(4, Lang.t("Arhive")),
				new KeyValuePair<int, string>(5, Lang.t("Rejected"))
			};
			this.SelectedStatus = -2;
			this.BgInit();
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06001578 RID: 5496 RVA: 0x00032B98 File Offset: 0x00030D98
		// (set) Token: 0x06001579 RID: 5497 RVA: 0x00032BAC File Offset: 0x00030DAC
		public List<KeyValuePair<int, string>> Statuses
		{
			[CompilerGenerated]
			get
			{
				return this.<Statuses>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Statuses>k__BackingField, value))
				{
					return;
				}
				this.<Statuses>k__BackingField = value;
				this.RaisePropertyChanged("Statuses");
			}
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x0600157A RID: 5498 RVA: 0x00032BDC File Offset: 0x00030DDC
		// (set) Token: 0x0600157B RID: 5499 RVA: 0x00032BF0 File Offset: 0x00030DF0
		public bool PeriodVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<PeriodVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PeriodVisible>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -1991909614;
				IL_10:
				switch ((num ^ -1030808673) % 4)
				{
				case 0:
					IL_2F:
					this.<PeriodVisible>k__BackingField = value;
					this.RaisePropertyChanged("PeriodVisible");
					num = -1320687271;
					goto IL_10;
				case 1:
					return;
				case 3:
					goto IL_0B;
				}
			}
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x0600157C RID: 5500 RVA: 0x00032C48 File Offset: 0x00030E48
		// (set) Token: 0x0600157D RID: 5501 RVA: 0x00032C8C File Offset: 0x00030E8C
		public int SelectedStatus
		{
			get
			{
				return base.GetProperty<int>(() => this.SelectedStatus);
			}
			set
			{
				if (this.SelectedStatus == value)
				{
					return;
				}
				base.SetProperty<int>(() => this.SelectedStatus, value, new Action(this.TaskStatusChanged));
				this.RaisePropertyChanged("SelectedStatus");
			}
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x00032CF4 File Offset: 0x00030EF4
		private void TaskStatusChanged()
		{
			this.PeriodVisible = (this.SelectedStatus > -2);
			this.Loaded();
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x00032D18 File Offset: 0x00030F18
		[Command]
		public void ItemDoubleClick()
		{
			if (base.SelectedItem == null)
			{
				return;
			}
			this._navigationService.Navigate("PartsRequestView", new PartsRequestViewModel(base.SelectedItem.Id));
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x00032D50 File Offset: 0x00030F50
		private void BgInit()
		{
			StoreManagementViewModel.<BgInit>d__34 <BgInit>d__;
			<BgInit>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<BgInit>d__.<>4__this = this;
			<BgInit>d__.<>1__state = -1;
			<BgInit>d__.<>t__builder.Start<StoreManagementViewModel.<BgInit>d__34>(ref <BgInit>d__);
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x00032D88 File Offset: 0x00030F88
		[Command]
		public void Loaded()
		{
			StoreManagementViewModel.<Loaded>d__35 <Loaded>d__;
			<Loaded>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Loaded>d__.<>4__this = this;
			<Loaded>d__.<>1__state = -1;
			<Loaded>d__.<>t__builder.Start<StoreManagementViewModel.<Loaded>d__35>(ref <Loaded>d__);
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x00032DC0 File Offset: 0x00030FC0
		[Command]
		public void FilterChanged()
		{
			this.Loaded();
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x00032DC0 File Offset: 0x00030FC0
		[Command]
		public void Refresh()
		{
			this.Loaded();
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x00032DD4 File Offset: 0x00030FD4
		[Command]
		public void OpenRepairCard()
		{
			this._navigationService.NavigateRepairCard(base.SelectedItem.RepairId.Value);
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x00032E00 File Offset: 0x00031000
		public bool CanOpenRepairCard()
		{
			StoreIntReserveLite selectedItem = base.SelectedItem;
			return selectedItem != null && selectedItem.RepairId != null;
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x00032E28 File Offset: 0x00031028
		[Command]
		public void OpenItemCard()
		{
			this._navigationService.NavigateToStoreItem(base.SelectedItem.ItemId, 0);
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x00032E4C File Offset: 0x0003104C
		public bool CanOpenItemCard()
		{
			return base.SelectedItem != null;
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x00032E64 File Offset: 0x00031064
		[CompilerGenerated]
		private Task<List<StoreIntReserveLite>> <Loaded>b__35_0()
		{
			return StoreModel.LoadItems(this.Period, this.SelectedUserId, this.SelectedStatus, this.Query, this.SelectedStoreId);
		}

		// Token: 0x04000A70 RID: 2672
		private readonly INavigationService _navigationService;

		// Token: 0x04000A71 RID: 2673
		[CompilerGenerated]
		private List<stores> <Stores>k__BackingField;

		// Token: 0x04000A72 RID: 2674
		[CompilerGenerated]
		private Period <Period>k__BackingField;

		// Token: 0x04000A73 RID: 2675
		[CompilerGenerated]
		private int <SelectedStoreId>k__BackingField;

		// Token: 0x04000A74 RID: 2676
		[CompilerGenerated]
		private int <SelectedUserId>k__BackingField;

		// Token: 0x04000A75 RID: 2677
		[CompilerGenerated]
		private List<KeyValuePair<int, string>> <Statuses>k__BackingField;

		// Token: 0x04000A76 RID: 2678
		[CompilerGenerated]
		private bool <PeriodVisible>k__BackingField;

		// Token: 0x02000133 RID: 307
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <BgInit>d__34 : IAsyncStateMachine
		{
			// Token: 0x06001589 RID: 5513 RVA: 0x00032E94 File Offset: 0x00031094
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				StoreManagementViewModel storeManagementViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<stores>> awaiter;
					if (num != 0)
					{
						awaiter = StoreModel.LoadStores(false, true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<stores>>, StoreManagementViewModel.<BgInit>d__34>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<stores>>);
						this.<>1__state = -1;
					}
					List<stores> result = awaiter.GetResult();
					storeManagementViewModel.Stores = result;
					storeManagementViewModel.SelectedStoreId = OfflineData.Instance.Employee.StoreDefault;
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

			// Token: 0x0600158A RID: 5514 RVA: 0x00032F68 File Offset: 0x00031168
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000A77 RID: 2679
			public int <>1__state;

			// Token: 0x04000A78 RID: 2680
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000A79 RID: 2681
			public StoreManagementViewModel <>4__this;

			// Token: 0x04000A7A RID: 2682
			private TaskAwaiter<List<stores>> <>u__1;
		}

		// Token: 0x02000134 RID: 308
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Loaded>d__35 : IAsyncStateMachine
		{
			// Token: 0x0600158B RID: 5515 RVA: 0x00032F84 File Offset: 0x00031184
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				StoreManagementViewModel storeManagementViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<StoreIntReserveLite>> awaiter;
					if (num != 0)
					{
						storeManagementViewModel.ShowWait();
						awaiter = Task.Run<List<StoreIntReserveLite>>(() => StoreModel.LoadItems(base.Period, base.SelectedUserId, base.SelectedStatus, base.Query, base.SelectedStoreId)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<StoreIntReserveLite>>, StoreManagementViewModel.<Loaded>d__35>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<StoreIntReserveLite>>);
						this.<>1__state = -1;
					}
					List<StoreIntReserveLite> result = awaiter.GetResult();
					storeManagementViewModel.SetItems(result);
					storeManagementViewModel.HideWait();
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

			// Token: 0x0600158C RID: 5516 RVA: 0x00033058 File Offset: 0x00031258
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000A7B RID: 2683
			public int <>1__state;

			// Token: 0x04000A7C RID: 2684
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000A7D RID: 2685
			public StoreManagementViewModel <>4__this;

			// Token: 0x04000A7E RID: 2686
			private TaskAwaiter<List<StoreIntReserveLite>> <>u__1;
		}
	}
}
