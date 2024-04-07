using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Interfaces;
using ASC.Invoice;
using ASC.Options;
using ASC.Services.Abstract;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels.CustomerCard
{
	// Token: 0x020004EB RID: 1259
	public class CustomerRepairsViewModel : CustomerCollectionViewModel<workshop>
	{
		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x0600300B RID: 12299 RVA: 0x0009E234 File Offset: 0x0009C434
		// (set) Token: 0x0600300C RID: 12300 RVA: 0x0009E248 File Offset: 0x0009C448
		public List<WorkshopOptions> WorkshopOptions
		{
			[CompilerGenerated]
			get
			{
				return this.<WorkshopOptions>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<WorkshopOptions>k__BackingField, value))
				{
					return;
				}
				this.<WorkshopOptions>k__BackingField = value;
				this.RaisePropertyChanged("WorkshopOptions");
			}
		}

		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x0600300D RID: 12301 RVA: 0x0009E278 File Offset: 0x0009C478
		// (set) Token: 0x0600300E RID: 12302 RVA: 0x0009E28C File Offset: 0x0009C48C
		public int SelectedWorkshopOption
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedWorkshopOption>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedWorkshopOption>k__BackingField == value)
				{
					return;
				}
				this.<SelectedWorkshopOption>k__BackingField = value;
				this.RaisePropertyChanged("SelectedWorkshopOption");
			}
		}

		// Token: 0x0600300F RID: 12303 RVA: 0x0009E2B8 File Offset: 0x0009C4B8
		public CustomerRepairsViewModel(ICustomerService customerService, INavigationService navigationService)
		{
			this._customerService = customerService;
			this._navigationService = navigationService;
			this.WorkshopOptions = new WorkshopOptions().GetAllOptionsWithDummy();
		}

		// Token: 0x06003010 RID: 12304 RVA: 0x0009E2F4 File Offset: 0x0009C4F4
		protected override void LoadData()
		{
			CustomerRepairsViewModel.<LoadData>d__11 <LoadData>d__;
			<LoadData>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadData>d__.<>4__this = this;
			<LoadData>d__.<>1__state = -1;
			<LoadData>d__.<>t__builder.Start<CustomerRepairsViewModel.<LoadData>d__11>(ref <LoadData>d__);
		}

		// Token: 0x06003011 RID: 12305 RVA: 0x0009E32C File Offset: 0x0009C52C
		[Command]
		public void Refresh()
		{
			this.LoadData();
		}

		// Token: 0x06003012 RID: 12306 RVA: 0x0009E340 File Offset: 0x0009C540
		[Command]
		public void RepairDoubleClick()
		{
			this._navigationService.NavigateRepairCard(base.SelectedItem.id);
		}

		// Token: 0x06003013 RID: 12307 RVA: 0x0009E364 File Offset: 0x0009C564
		public bool CanRepairDoubleClick()
		{
			return base.SelectedItem != null;
		}

		// Token: 0x06003014 RID: 12308 RVA: 0x0009E37C File Offset: 0x0009C57C
		[Command]
		public void CreateInvoice()
		{
			this._navigationService.Navigate("NewInvoiceView", new NewInvoiceViewModel(base.SelectedItems, this.Customer.Id));
		}

		// Token: 0x06003015 RID: 12309 RVA: 0x0009E3B0 File Offset: 0x0009C5B0
		public bool CanCreateInvoice()
		{
			return base.IsValid() && base.SelectedItems != null && base.SelectedItems.Any<workshop>();
		}

		// Token: 0x06003016 RID: 12310 RVA: 0x0009E3DC File Offset: 0x0009C5DC
		[CompilerGenerated]
		private Task<IEnumerable<workshop>> <LoadData>b__11_0()
		{
			return this._customerService.GetRepairs(this.Customer.Id, base.Period, this.SelectedWorkshopOption);
		}

		// Token: 0x06003017 RID: 12311 RVA: 0x0009E40C File Offset: 0x0009C60C
		[CompilerGenerated]
		[DebuggerHidden]
		private void <>n__0()
		{
			base.LoadData();
		}

		// Token: 0x04001B48 RID: 6984
		private readonly ICustomerService _customerService;

		// Token: 0x04001B49 RID: 6985
		private readonly INavigationService _navigationService;

		// Token: 0x04001B4A RID: 6986
		[CompilerGenerated]
		private List<WorkshopOptions> <WorkshopOptions>k__BackingField;

		// Token: 0x04001B4B RID: 6987
		[CompilerGenerated]
		private int <SelectedWorkshopOption>k__BackingField = 99;

		// Token: 0x020004EC RID: 1260
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadData>d__11 : IAsyncStateMachine
		{
			// Token: 0x06003018 RID: 12312 RVA: 0x0009E420 File Offset: 0x0009C620
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CustomerRepairsViewModel customerRepairsViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<workshop>> awaiter;
					if (num != 0)
					{
						customerRepairsViewModel.<>n__0();
						awaiter = Task.Run<IEnumerable<workshop>>(() => customerRepairsViewModel._customerService.GetRepairs(customerRepairsViewModel.Customer.Id, base.Period, base.SelectedWorkshopOption)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<workshop>>, CustomerRepairsViewModel.<LoadData>d__11>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<workshop>>);
						this.<>1__state = -1;
					}
					IEnumerable<workshop> result = awaiter.GetResult();
					customerRepairsViewModel.SetItems(result);
					customerRepairsViewModel.SetIsDataLoading(false);
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

			// Token: 0x06003019 RID: 12313 RVA: 0x0009E4F4 File Offset: 0x0009C6F4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001B4C RID: 6988
			public int <>1__state;

			// Token: 0x04001B4D RID: 6989
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001B4E RID: 6990
			public CustomerRepairsViewModel <>4__this;

			// Token: 0x04001B4F RID: 6991
			private TaskAwaiter<IEnumerable<workshop>> <>u__1;
		}
	}
}
