using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Objects;
using ASC.Interfaces;
using ASC.Models;
using ASC.Services.Abstract;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels.Charts
{
	// Token: 0x02000537 RID: 1335
	public class StatusCheckViewModel : BaseViewModel
	{
		// Token: 0x17000F52 RID: 3922
		// (get) Token: 0x060031B2 RID: 12722 RVA: 0x000A6060 File Offset: 0x000A4260
		// (set) Token: 0x060031B3 RID: 12723 RVA: 0x000A6074 File Offset: 0x000A4274
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
				if (!object.Equals(this.<Period>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -39100088;
				IL_13:
				switch ((num ^ -1723334977) % 4)
				{
				case 0:
					goto IL_0E;
				case 2:
					IL_32:
					this.<Period>k__BackingField = value;
					num = -1826359706;
					goto IL_13;
				case 3:
					return;
				}
				this.RaisePropertyChanged("Period");
			}
		}

		// Token: 0x17000F53 RID: 3923
		// (get) Token: 0x060031B4 RID: 12724 RVA: 0x000A60D0 File Offset: 0x000A42D0
		// (set) Token: 0x060031B5 RID: 12725 RVA: 0x000A6114 File Offset: 0x000A4314
		public string Query
		{
			get
			{
				return base.GetProperty<string>(() => this.Query);
			}
			set
			{
				if (string.Equals(this.Query, value, StringComparison.Ordinal))
				{
					return;
				}
				base.SetProperty<string>(() => this.Query, value, new Action(this.OnQueryChanged));
				this.RaisePropertyChanged("Query");
			}
		}

		// Token: 0x17000F54 RID: 3924
		// (get) Token: 0x060031B6 RID: 12726 RVA: 0x000A6180 File Offset: 0x000A4380
		// (set) Token: 0x060031B7 RID: 12727 RVA: 0x000A6194 File Offset: 0x000A4394
		public ObservableCollection<ApiStatusCheck> Items
		{
			[CompilerGenerated]
			get
			{
				return this.<Items>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Items>k__BackingField, value))
				{
					return;
				}
				this.<Items>k__BackingField = value;
				this.RaisePropertyChanged("Items");
			}
		}

		// Token: 0x17000F55 RID: 3925
		// (get) Token: 0x060031B8 RID: 12728 RVA: 0x000A61C4 File Offset: 0x000A43C4
		// (set) Token: 0x060031B9 RID: 12729 RVA: 0x000A61D8 File Offset: 0x000A43D8
		public ApiStatusCheck SelectedItem
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedItem>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedItem>k__BackingField, value))
				{
					return;
				}
				this.<SelectedItem>k__BackingField = value;
				this.RaisePropertyChanged("SelectedItem");
			}
		}

		// Token: 0x060031BA RID: 12730 RVA: 0x000A6208 File Offset: 0x000A4408
		public StatusCheckViewModel(INavigationService navigationService, IWorkshopService workshopService)
		{
			this._navigationService = navigationService;
			this._workshopService = workshopService;
			this.SetViewName("StatusesWidget");
			this.Period = new Period();
			Period period = this.Period;
			period.RefreshEventHandler = (EventHandler)Delegate.Combine(period.RefreshEventHandler, new EventHandler(this.PeriodChanged));
			this.LoadData();
		}

		// Token: 0x060031BB RID: 12731 RVA: 0x000A626C File Offset: 0x000A446C
		private void PeriodChanged(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x060031BC RID: 12732 RVA: 0x000A6280 File Offset: 0x000A4480
		private void LoadData()
		{
			StatusCheckViewModel.<LoadData>d__19 <LoadData>d__;
			<LoadData>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadData>d__.<>4__this = this;
			<LoadData>d__.<>1__state = -1;
			<LoadData>d__.<>t__builder.Start<StatusCheckViewModel.<LoadData>d__19>(ref <LoadData>d__);
		}

		// Token: 0x060031BD RID: 12733 RVA: 0x000A626C File Offset: 0x000A446C
		private void OnQueryChanged()
		{
			this.LoadData();
		}

		// Token: 0x060031BE RID: 12734 RVA: 0x000A626C File Offset: 0x000A446C
		[Command]
		public void Refresh()
		{
			this.LoadData();
		}

		// Token: 0x060031BF RID: 12735 RVA: 0x000A62B8 File Offset: 0x000A44B8
		[Command]
		public void ItemRowDoubleClick()
		{
			if (this.SelectedItem != null)
			{
				goto IL_2C;
			}
			IL_08:
			int num = 1613823562;
			IL_0D:
			switch ((num ^ 1301390115) % 4)
			{
			case 0:
				goto IL_08;
			case 1:
				return;
			case 3:
				IL_2C:
				this._navigationService.NavigateRepairCard((int)this.SelectedItem.RepairId);
				num = 1929943021;
				goto IL_0D;
			}
		}

		// Token: 0x060031C0 RID: 12736 RVA: 0x000A6310 File Offset: 0x000A4510
		public bool CanItemRowDoubleClick()
		{
			return this.SelectedItem != null && this.SelectedItem.RepairId > 0L;
		}

		// Token: 0x060031C1 RID: 12737 RVA: 0x000A6340 File Offset: 0x000A4540
		[Command]
		public void NavigateCustomerCard()
		{
			StatusCheckViewModel.<NavigateCustomerCard>d__24 <NavigateCustomerCard>d__;
			<NavigateCustomerCard>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<NavigateCustomerCard>d__.<>4__this = this;
			<NavigateCustomerCard>d__.<>1__state = -1;
			<NavigateCustomerCard>d__.<>t__builder.Start<StatusCheckViewModel.<NavigateCustomerCard>d__24>(ref <NavigateCustomerCard>d__);
		}

		// Token: 0x060031C2 RID: 12738 RVA: 0x000A6310 File Offset: 0x000A4510
		public bool CanNavigateCustomerCard()
		{
			return this.SelectedItem != null && this.SelectedItem.RepairId > 0L;
		}

		// Token: 0x060031C3 RID: 12739 RVA: 0x000A6378 File Offset: 0x000A4578
		[Command]
		public void CopyIdAddress()
		{
			base.CopyToClipboard(this.SelectedItem.IpAddress);
		}

		// Token: 0x060031C4 RID: 12740 RVA: 0x000A6398 File Offset: 0x000A4598
		public bool CanCopyIdAddress()
		{
			return this.SelectedItem != null && !string.IsNullOrEmpty(this.SelectedItem.IpAddress);
		}

		// Token: 0x060031C5 RID: 12741 RVA: 0x000A63C4 File Offset: 0x000A45C4
		[CompilerGenerated]
		private IEnumerable<ApiStatusCheck> <LoadData>b__19_0()
		{
			return StatusCheckModel.GetApiStatusChecks(this.Period, this.Query);
		}

		// Token: 0x04001C81 RID: 7297
		private readonly INavigationService _navigationService;

		// Token: 0x04001C82 RID: 7298
		private readonly IWorkshopService _workshopService;

		// Token: 0x04001C83 RID: 7299
		[CompilerGenerated]
		private Period <Period>k__BackingField;

		// Token: 0x04001C84 RID: 7300
		[CompilerGenerated]
		private ObservableCollection<ApiStatusCheck> <Items>k__BackingField;

		// Token: 0x04001C85 RID: 7301
		[CompilerGenerated]
		private ApiStatusCheck <SelectedItem>k__BackingField;

		// Token: 0x02000538 RID: 1336
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadData>d__19 : IAsyncStateMachine
		{
			// Token: 0x060031C6 RID: 12742 RVA: 0x000A63E4 File Offset: 0x000A45E4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				StatusCheckViewModel statusCheckViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<ApiStatusCheck>> awaiter;
					if (num != 0)
					{
						statusCheckViewModel.ShowWait();
						awaiter = Task.Run<IEnumerable<ApiStatusCheck>>(() => StatusCheckModel.GetApiStatusChecks(base.Period, base.Query)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<ApiStatusCheck>>, StatusCheckViewModel.<LoadData>d__19>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<ApiStatusCheck>>);
						this.<>1__state = -1;
					}
					IEnumerable<ApiStatusCheck> result = awaiter.GetResult();
					statusCheckViewModel.Items = new ObservableCollection<ApiStatusCheck>(result);
					statusCheckViewModel.HideWait();
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

			// Token: 0x060031C7 RID: 12743 RVA: 0x000A64BC File Offset: 0x000A46BC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001C86 RID: 7302
			public int <>1__state;

			// Token: 0x04001C87 RID: 7303
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001C88 RID: 7304
			public StatusCheckViewModel <>4__this;

			// Token: 0x04001C89 RID: 7305
			private TaskAwaiter<IEnumerable<ApiStatusCheck>> <>u__1;
		}

		// Token: 0x02000539 RID: 1337
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <NavigateCustomerCard>d__24 : IAsyncStateMachine
		{
			// Token: 0x060031C8 RID: 12744 RVA: 0x000A64D8 File Offset: 0x000A46D8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				StatusCheckViewModel statusCheckViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<int> awaiter;
					if (num != 0)
					{
						this.<>7__wrap1 = statusCheckViewModel._navigationService;
						awaiter = statusCheckViewModel._workshopService.GetRepairCustomerId((int)statusCheckViewModel.SelectedItem.RepairId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, StatusCheckViewModel.<NavigateCustomerCard>d__24>(ref awaiter, ref this);
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
					this.<>7__wrap1.NavigateToCustomerCard(result, null);
					this.<>7__wrap1 = null;
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

			// Token: 0x060031C9 RID: 12745 RVA: 0x000A65C0 File Offset: 0x000A47C0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001C8A RID: 7306
			public int <>1__state;

			// Token: 0x04001C8B RID: 7307
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001C8C RID: 7308
			public StatusCheckViewModel <>4__this;

			// Token: 0x04001C8D RID: 7309
			private INavigationService <>7__wrap1;

			// Token: 0x04001C8E RID: 7310
			private TaskAwaiter<int> <>u__1;
		}
	}
}
