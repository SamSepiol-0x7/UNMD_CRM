using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ASC.Services;
using ASC.Services.Abstract;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;

namespace ASC.ViewModels.ACP
{
	// Token: 0x02000550 RID: 1360
	public class VendorWarrantyListViewModel : BaseViewModel
	{
		// Token: 0x17000F8D RID: 3981
		// (get) Token: 0x06003293 RID: 12947 RVA: 0x000A9FE0 File Offset: 0x000A81E0
		// (set) Token: 0x06003294 RID: 12948 RVA: 0x000A9FF4 File Offset: 0x000A81F4
		public ObservableCollection<vendors> Items
		{
			[CompilerGenerated]
			get
			{
				return this.<Items>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Items>k__BackingField, value))
				{
					return;
				}
				this.<Items>k__BackingField = value;
				this.RaisePropertyChanged("Items");
			}
		}

		// Token: 0x17000F8E RID: 3982
		// (get) Token: 0x06003295 RID: 12949 RVA: 0x000AA024 File Offset: 0x000A8224
		// (set) Token: 0x06003296 RID: 12950 RVA: 0x000AA038 File Offset: 0x000A8238
		public vendors SelectedItem
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

		// Token: 0x17000F8F RID: 3983
		// (get) Token: 0x06003297 RID: 12951 RVA: 0x000AA068 File Offset: 0x000A8268
		// (set) Token: 0x06003298 RID: 12952 RVA: 0x000AA07C File Offset: 0x000A827C
		public bool ShowArchive
		{
			[CompilerGenerated]
			get
			{
				return this.<ShowArchive>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ShowArchive>k__BackingField == value)
				{
					return;
				}
				this.<ShowArchive>k__BackingField = value;
				this.RaisePropertyChanged("ShowArchive");
			}
		}

		// Token: 0x06003299 RID: 12953 RVA: 0x000AA0A8 File Offset: 0x000A82A8
		public VendorWarrantyListViewModel(IVendorService vendorService, IWindowedDocumentService windowedDocumentService)
		{
			this.vendorService = vendorService;
			this._windowedDocumentService = windowedDocumentService;
		}

		// Token: 0x0600329A RID: 12954 RVA: 0x000AA0CC File Offset: 0x000A82CC
		private void LoadData()
		{
			VendorWarrantyListViewModel.<LoadData>d__15 <LoadData>d__;
			<LoadData>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadData>d__.<>4__this = this;
			<LoadData>d__.<>1__state = -1;
			<LoadData>d__.<>t__builder.Start<VendorWarrantyListViewModel.<LoadData>d__15>(ref <LoadData>d__);
		}

		// Token: 0x0600329B RID: 12955 RVA: 0x000AA104 File Offset: 0x000A8304
		[Command]
		public void ShowCreateVendor()
		{
			VendorWarrantyViewModel viewModel = Bootstrapper.Container.Resolve<VendorWarrantyViewModel>();
			viewModel.SetParentViewModel(this);
			this._windowedDocumentService.ShowNewDocument("VendorWarrantyView", viewModel, null, null);
		}

		// Token: 0x0600329C RID: 12956 RVA: 0x0007E5F4 File Offset: 0x0007C7F4
		public bool CanShowCreateVendor()
		{
			return true;
		}

		// Token: 0x0600329D RID: 12957 RVA: 0x000AA138 File Offset: 0x000A8338
		[Command]
		public void EditVendor()
		{
			VendorWarrantyViewModel vendorWarrantyViewModel = Bootstrapper.Container.Resolve<VendorWarrantyViewModel>();
			vendorWarrantyViewModel.SetParentViewModel(this);
			vendorWarrantyViewModel.SetVendor(this.SelectedItem);
			this._windowedDocumentService.ShowNewDocument("VendorWarrantyView", vendorWarrantyViewModel, null, null);
		}

		// Token: 0x0600329E RID: 12958 RVA: 0x000AA178 File Offset: 0x000A8378
		public bool CanEditVendor()
		{
			return this.SelectedItem != null;
		}

		// Token: 0x0600329F RID: 12959 RVA: 0x000AA190 File Offset: 0x000A8390
		[Command]
		public void RefreshVendors()
		{
			this.LoadData();
		}

		// Token: 0x060032A0 RID: 12960 RVA: 0x0007E5F4 File Offset: 0x0007C7F4
		public bool CanRefreshVendors()
		{
			return true;
		}

		// Token: 0x060032A1 RID: 12961 RVA: 0x000AA190 File Offset: 0x000A8390
		[Command]
		public void OnLoaded()
		{
			this.LoadData();
		}

		// Token: 0x04001D12 RID: 7442
		private readonly IVendorService vendorService;

		// Token: 0x04001D13 RID: 7443
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04001D14 RID: 7444
		[CompilerGenerated]
		private ObservableCollection<vendors> <Items>k__BackingField;

		// Token: 0x04001D15 RID: 7445
		[CompilerGenerated]
		private vendors <SelectedItem>k__BackingField;

		// Token: 0x04001D16 RID: 7446
		[CompilerGenerated]
		private bool <ShowArchive>k__BackingField;

		// Token: 0x02000551 RID: 1361
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadData>d__15 : IAsyncStateMachine
		{
			// Token: 0x060032A2 RID: 12962 RVA: 0x000AA1A4 File Offset: 0x000A83A4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				VendorWarrantyListViewModel vendorWarrantyListViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<vendors>> awaiter;
					if (num != 0)
					{
						vendorWarrantyListViewModel.ShowWait();
						awaiter = (vendorWarrantyListViewModel.ShowArchive ? vendorWarrantyListViewModel.vendorService.GetAllVendors() : vendorWarrantyListViewModel.vendorService.GetVendors()).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<vendors>>, VendorWarrantyListViewModel.<LoadData>d__15>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<vendors>>);
						this.<>1__state = -1;
					}
					List<vendors> result = awaiter.GetResult();
					vendorWarrantyListViewModel.Items = new ObservableCollection<vendors>(result);
					vendorWarrantyListViewModel.HideWait();
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

			// Token: 0x060032A3 RID: 12963 RVA: 0x000AA28C File Offset: 0x000A848C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001D17 RID: 7447
			public int <>1__state;

			// Token: 0x04001D18 RID: 7448
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001D19 RID: 7449
			public VendorWarrantyListViewModel <>4__this;

			// Token: 0x04001D1A RID: 7450
			private TaskAwaiter<List<vendors>> <>u__1;
		}
	}
}
