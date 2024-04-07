using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ASC.Services;
using DevExpress.Mvvm;

namespace ASC.ViewModels
{
	// Token: 0x020003DB RID: 987
	public class VendorSelectViewModel : ViewModelBase
	{
		// Token: 0x17000DA6 RID: 3494
		// (get) Token: 0x0600287B RID: 10363 RVA: 0x0007D7D8 File Offset: 0x0007B9D8
		// (set) Token: 0x0600287C RID: 10364 RVA: 0x0007D81C File Offset: 0x0007BA1C
		public bool IsVendorWarranty
		{
			get
			{
				return base.GetProperty<bool>(() => this.IsVendorWarranty);
			}
			set
			{
				if (this.IsVendorWarranty == value)
				{
					return;
				}
				base.SetProperty<bool>(() => this.IsVendorWarranty, value, new Action(this.OnIsVendorWarrantyChanged));
				this.RaisePropertyChanged("IsVendorWarranty");
			}
		}

		// Token: 0x17000DA7 RID: 3495
		// (get) Token: 0x0600287D RID: 10365 RVA: 0x0007D884 File Offset: 0x0007BA84
		// (set) Token: 0x0600287E RID: 10366 RVA: 0x0007D898 File Offset: 0x0007BA98
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

		// Token: 0x17000DA8 RID: 3496
		// (get) Token: 0x0600287F RID: 10367 RVA: 0x0007D8C8 File Offset: 0x0007BAC8
		// (set) Token: 0x06002880 RID: 10368 RVA: 0x0007D90C File Offset: 0x0007BB0C
		public int? SelectedItemId
		{
			get
			{
				return base.GetProperty<int?>(() => this.SelectedItemId);
			}
			set
			{
				if (!Nullable.Equals<int>(this.SelectedItemId, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1604564748;
				IL_13:
				switch ((num ^ -493949019) % 4)
				{
				case 1:
					return;
				case 2:
					IL_32:
					base.SetProperty<int?>(() => this.SelectedItemId, value, new Action(this.OnSelectedItemIdChanged));
					this.RaisePropertyChanged("SelectedItemId");
					num = -1817940543;
					goto IL_13;
				case 3:
					goto IL_0E;
				}
			}
		}

		// Token: 0x06002881 RID: 10369 RVA: 0x0007D9A4 File Offset: 0x0007BBA4
		public VendorSelectViewModel(IVendorService vendorService)
		{
			this.vendorService = vendorService;
		}

		// Token: 0x06002882 RID: 10370 RVA: 0x0007D9C0 File Offset: 0x0007BBC0
		private void OnIsVendorWarrantyChanged()
		{
			VendorSelectViewModel.<OnIsVendorWarrantyChanged>d__13 <OnIsVendorWarrantyChanged>d__;
			<OnIsVendorWarrantyChanged>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnIsVendorWarrantyChanged>d__.<>4__this = this;
			<OnIsVendorWarrantyChanged>d__.<>1__state = -1;
			<OnIsVendorWarrantyChanged>d__.<>t__builder.Start<VendorSelectViewModel.<OnIsVendorWarrantyChanged>d__13>(ref <OnIsVendorWarrantyChanged>d__);
		}

		// Token: 0x06002883 RID: 10371 RVA: 0x0007D9F8 File Offset: 0x0007BBF8
		private void OnSelectedItemIdChanged()
		{
			IVendorSelect parentViewModel = this._parentViewModel;
			if (parentViewModel == null)
			{
				return;
			}
			parentViewModel.SetVendor(this.SelectedItemId);
		}

		// Token: 0x06002884 RID: 10372 RVA: 0x0007DA1C File Offset: 0x0007BC1C
		protected override void OnParentViewModelChanged(object obj)
		{
			base.OnParentViewModelChanged(obj);
			this._parentViewModel = (obj as IVendorSelect);
		}

		// Token: 0x06002885 RID: 10373 RVA: 0x0007DA3C File Offset: 0x0007BC3C
		protected override void OnParameterChanged(object prm)
		{
			base.OnParameterChanged(prm);
			int? num = prm as int?;
			int? num2 = num;
			this.IsVendorWarranty = (num2.GetValueOrDefault() > 0 & num2 != null);
			this.SelectedItemId = num;
		}

		// Token: 0x04001636 RID: 5686
		private readonly IVendorService vendorService;

		// Token: 0x04001637 RID: 5687
		private IVendorSelect _parentViewModel;

		// Token: 0x04001638 RID: 5688
		[CompilerGenerated]
		private ObservableCollection<vendors> <Items>k__BackingField;

		// Token: 0x020003DC RID: 988
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnIsVendorWarrantyChanged>d__13 : IAsyncStateMachine
		{
			// Token: 0x06002886 RID: 10374 RVA: 0x0007DA80 File Offset: 0x0007BC80
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				VendorSelectViewModel vendorSelectViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<vendors>> awaiter;
					if (num != 0)
					{
						if (!vendorSelectViewModel.IsVendorWarranty)
						{
							vendorSelectViewModel.SelectedItemId = null;
							goto IL_95;
						}
						awaiter = vendorSelectViewModel.vendorService.GetVendors().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<vendors>>, VendorSelectViewModel.<OnIsVendorWarrantyChanged>d__13>(ref awaiter, ref this);
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
					vendorSelectViewModel.Items = new ObservableCollection<vendors>(result);
					IL_95:;
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

			// Token: 0x06002887 RID: 10375 RVA: 0x0007DB60 File Offset: 0x0007BD60
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001639 RID: 5689
			public int <>1__state;

			// Token: 0x0400163A RID: 5690
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400163B RID: 5691
			public VendorSelectViewModel <>4__this;

			// Token: 0x0400163C RID: 5692
			private TaskAwaiter<List<vendors>> <>u__1;
		}
	}
}
