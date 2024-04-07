using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ASC.Interfaces;
using ASC.Services;
using ASC.Services.Abstract;
using DevExpress.Mvvm.DataAnnotations;
using Poly;

namespace ASC.ViewModels.ACP
{
	// Token: 0x02000552 RID: 1362
	public class VendorWarrantyViewModel : PopupViewModel
	{
		// Token: 0x17000F90 RID: 3984
		// (get) Token: 0x060032A4 RID: 12964 RVA: 0x000AA2A8 File Offset: 0x000A84A8
		public ICustomerSearchViewModel WorksAgentViewModel
		{
			[CompilerGenerated]
			get
			{
				return this.<WorksAgentViewModel>k__BackingField;
			}
		}

		// Token: 0x17000F91 RID: 3985
		// (get) Token: 0x060032A5 RID: 12965 RVA: 0x000AA2BC File Offset: 0x000A84BC
		public ICustomerSearchViewModel PartsAgentViewModel
		{
			[CompilerGenerated]
			get
			{
				return this.<PartsAgentViewModel>k__BackingField;
			}
		}

		// Token: 0x17000F92 RID: 3986
		// (get) Token: 0x060032A6 RID: 12966 RVA: 0x000AA2D0 File Offset: 0x000A84D0
		// (set) Token: 0x060032A7 RID: 12967 RVA: 0x000AA2E4 File Offset: 0x000A84E4
		public vendors Item
		{
			[CompilerGenerated]
			get
			{
				return this.<Item>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Item>k__BackingField, value))
				{
					return;
				}
				this.<Item>k__BackingField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		// Token: 0x060032A8 RID: 12968 RVA: 0x000AA314 File Offset: 0x000A8514
		public VendorWarrantyViewModel(IVendorService vendorService, ICustomerSearchViewModel worksAgentViewModel, ICustomerSearchViewModel partsAgentViewModel, IToasterService toasterService)
		{
			this.vendorService = vendorService;
			this.WorksAgentViewModel = worksAgentViewModel;
			this.PartsAgentViewModel = partsAgentViewModel;
			this._toasterService = toasterService;
			this.Item = new vendors();
			base.SetTitle(Lang.t("CreateVendorTitle"));
		}

		// Token: 0x060032A9 RID: 12969 RVA: 0x000AA360 File Offset: 0x000A8560
		public void SetVendor(vendors data)
		{
			data.CopyProperties(this.Item);
			base.SetTitle(this.Item.name);
			this.WorksAgentViewModel.SetSelected(this.Item.works_agent);
			this.PartsAgentViewModel.SetSelected(this.Item.parts_agent);
			base.RaiseCanExecuteChanged(() => this.Create());
			base.RaiseCanExecuteChanged(() => this.Update());
		}

		// Token: 0x060032AA RID: 12970 RVA: 0x000AA42C File Offset: 0x000A862C
		private bool CheckFields()
		{
			if (string.IsNullOrEmpty(this.Item.name))
			{
				this._toasterService.Info(Lang.t("SelectDeviceMaker"));
				return false;
			}
			if (this.WorksAgentViewModel.GetSelected() == null)
			{
				this._toasterService.Info(Lang.t("SelectCustomer"));
				return false;
			}
			if (this.PartsAgentViewModel != null)
			{
				return true;
			}
			this._toasterService.Info(Lang.t("SelectCustomer"));
			return false;
		}

		// Token: 0x060032AB RID: 12971 RVA: 0x000AA4A8 File Offset: 0x000A86A8
		private void SetAgents()
		{
			this.Item.works_agent = this.WorksAgentViewModel.GetSelected().Id;
			this.Item.parts_agent = this.PartsAgentViewModel.GetSelected().Id;
		}

		// Token: 0x060032AC RID: 12972 RVA: 0x000AA4EC File Offset: 0x000A86EC
		[Command]
		public void Update()
		{
			VendorWarrantyViewModel.<Update>d__17 <Update>d__;
			<Update>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Update>d__.<>4__this = this;
			<Update>d__.<>1__state = -1;
			<Update>d__.<>t__builder.Start<VendorWarrantyViewModel.<Update>d__17>(ref <Update>d__);
		}

		// Token: 0x060032AD RID: 12973 RVA: 0x000AA524 File Offset: 0x000A8724
		public bool CanUpdate()
		{
			return this.Item.id > 0;
		}

		// Token: 0x060032AE RID: 12974 RVA: 0x000AA540 File Offset: 0x000A8740
		[Command]
		public void Create()
		{
			VendorWarrantyViewModel.<Create>d__19 <Create>d__;
			<Create>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Create>d__.<>4__this = this;
			<Create>d__.<>1__state = -1;
			<Create>d__.<>t__builder.Start<VendorWarrantyViewModel.<Create>d__19>(ref <Create>d__);
		}

		// Token: 0x060032AF RID: 12975 RVA: 0x000AA578 File Offset: 0x000A8778
		public bool CanCreate()
		{
			return this.Item.id == 0;
		}

		// Token: 0x060032B0 RID: 12976 RVA: 0x0007E5F4 File Offset: 0x0007C7F4
		public bool CanClose()
		{
			return true;
		}

		// Token: 0x060032B1 RID: 12977 RVA: 0x00023150 File Offset: 0x00021350
		[Command]
		public void OnLoaded()
		{
		}

		// Token: 0x060032B2 RID: 12978 RVA: 0x00023150 File Offset: 0x00021350
		[Command]
		public void OnUnloaded()
		{
		}

		// Token: 0x060032B3 RID: 12979 RVA: 0x000AA594 File Offset: 0x000A8794
		private void RefreshParent()
		{
			VendorWarrantyListViewModel parentViewModel = this._parentViewModel;
			if (parentViewModel == null)
			{
				return;
			}
			parentViewModel.RefreshVendors();
		}

		// Token: 0x060032B4 RID: 12980 RVA: 0x000AA5B4 File Offset: 0x000A87B4
		protected override void OnParentViewModelChanged(object obj)
		{
			base.OnParentViewModelChanged(obj);
			this._parentViewModel = (obj as VendorWarrantyListViewModel);
		}

		// Token: 0x04001D1B RID: 7451
		private IVendorService vendorService;

		// Token: 0x04001D1C RID: 7452
		[CompilerGenerated]
		private readonly ICustomerSearchViewModel <WorksAgentViewModel>k__BackingField;

		// Token: 0x04001D1D RID: 7453
		[CompilerGenerated]
		private readonly ICustomerSearchViewModel <PartsAgentViewModel>k__BackingField;

		// Token: 0x04001D1E RID: 7454
		private readonly IToasterService _toasterService;

		// Token: 0x04001D1F RID: 7455
		[CompilerGenerated]
		private vendors <Item>k__BackingField;

		// Token: 0x04001D20 RID: 7456
		private VendorWarrantyListViewModel _parentViewModel;

		// Token: 0x02000553 RID: 1363
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Update>d__17 : IAsyncStateMachine
		{
			// Token: 0x060032B5 RID: 12981 RVA: 0x000AA5D4 File Offset: 0x000A87D4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				VendorWarrantyViewModel vendorWarrantyViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						if (!vendorWarrantyViewModel.CheckFields())
						{
							goto IL_109;
						}
						vendorWarrantyViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							vendorWarrantyViewModel.SetAgents();
							awaiter = vendorWarrantyViewModel.vendorService.UpdateVendor(vendorWarrantyViewModel.Item).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, VendorWarrantyViewModel.<Update>d__17>(ref awaiter, ref this);
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
						if (vendorWarrantyViewModel.Item.name != vendorWarrantyViewModel.Title)
						{
							vendorWarrantyViewModel.SetTitle(vendorWarrantyViewModel.Item.name);
						}
						vendorWarrantyViewModel.ShowActionResponse(true, "");
					}
					catch (Exception ex)
					{
						vendorWarrantyViewModel.ShowActionResponse(false, ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							vendorWarrantyViewModel.HideWait();
							vendorWarrantyViewModel.RefreshParent();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_109:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060032B6 RID: 12982 RVA: 0x000AA728 File Offset: 0x000A8928
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001D21 RID: 7457
			public int <>1__state;

			// Token: 0x04001D22 RID: 7458
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001D23 RID: 7459
			public VendorWarrantyViewModel <>4__this;

			// Token: 0x04001D24 RID: 7460
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000554 RID: 1364
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Create>d__19 : IAsyncStateMachine
		{
			// Token: 0x060032B7 RID: 12983 RVA: 0x000AA744 File Offset: 0x000A8944
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				VendorWarrantyViewModel vendorWarrantyViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						if (!vendorWarrantyViewModel.CheckFields())
						{
							goto IL_113;
						}
						vendorWarrantyViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter<int> awaiter;
						if (num != 0)
						{
							vendorWarrantyViewModel.SetAgents();
							this.<>7__wrap1 = vendorWarrantyViewModel.Item;
							awaiter = vendorWarrantyViewModel.vendorService.CreateVendor(vendorWarrantyViewModel.Item).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, VendorWarrantyViewModel.<Create>d__19>(ref awaiter, ref this);
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
						int result = awaiter.GetResult();
						this.<>7__wrap1.id = result;
						this.<>7__wrap1 = null;
						vendorWarrantyViewModel.SetTitle(vendorWarrantyViewModel.Item.name);
						vendorWarrantyViewModel.ShowActionResponse(true, "");
					}
					catch (Exception ex)
					{
						vendorWarrantyViewModel.ShowActionResponse(false, ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							vendorWarrantyViewModel.HideWait();
							vendorWarrantyViewModel.RefreshParent();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_113:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060032B8 RID: 12984 RVA: 0x000AA8A0 File Offset: 0x000A8AA0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001D25 RID: 7461
			public int <>1__state;

			// Token: 0x04001D26 RID: 7462
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001D27 RID: 7463
			public VendorWarrantyViewModel <>4__this;

			// Token: 0x04001D28 RID: 7464
			private vendors <>7__wrap1;

			// Token: 0x04001D29 RID: 7465
			private TaskAwaiter<int> <>u__1;
		}
	}
}
