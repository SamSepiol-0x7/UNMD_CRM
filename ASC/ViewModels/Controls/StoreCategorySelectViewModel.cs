using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ASC.Interfaces;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels.Controls
{
	// Token: 0x020004EE RID: 1262
	public class StoreCategorySelectViewModel : ViewModelBase
	{
		// Token: 0x17000EF2 RID: 3826
		// (get) Token: 0x0600301B RID: 12315 RVA: 0x0009E510 File Offset: 0x0009C710
		// (set) Token: 0x0600301C RID: 12316 RVA: 0x0009E524 File Offset: 0x0009C724
		public List<store_cats> Items
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

		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x0600301D RID: 12317 RVA: 0x0009E554 File Offset: 0x0009C754
		// (set) Token: 0x0600301E RID: 12318 RVA: 0x0009E598 File Offset: 0x0009C798
		public int? SelectedItem
		{
			get
			{
				return base.GetProperty<int?>(() => this.SelectedItem);
			}
			set
			{
				if (Nullable.Equals<int>(this.SelectedItem, value))
				{
					return;
				}
				base.SetProperty<int?>(() => this.SelectedItem, value, new Action(this.OnSelectedItemChanged));
				this.RaisePropertyChanged("SelectedItem");
			}
		}

		// Token: 0x0600301F RID: 12319 RVA: 0x0009E604 File Offset: 0x0009C804
		public StoreCategorySelectViewModel(IStoreService storeService)
		{
			this._storeService = storeService;
		}

		// Token: 0x06003020 RID: 12320 RVA: 0x0009E620 File Offset: 0x0009C820
		private void OnSelectedItemChanged()
		{
			int? selectedItem = this.SelectedItem;
			if (selectedItem.GetValueOrDefault() > 0 & selectedItem != null)
			{
				this._parentViewModel.SetCategory(this.SelectedItem.Value);
			}
		}

		// Token: 0x06003021 RID: 12321 RVA: 0x0009E664 File Offset: 0x0009C864
		[Command]
		public void OnLoaded()
		{
			this.LoadCategories();
		}

		// Token: 0x06003022 RID: 12322 RVA: 0x0009E678 File Offset: 0x0009C878
		public void LoadCategories()
		{
			StoreCategorySelectViewModel.<LoadCategories>d__13 <LoadCategories>d__;
			<LoadCategories>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadCategories>d__.<>4__this = this;
			<LoadCategories>d__.<>1__state = -1;
			<LoadCategories>d__.<>t__builder.Start<StoreCategorySelectViewModel.<LoadCategories>d__13>(ref <LoadCategories>d__);
		}

		// Token: 0x06003023 RID: 12323 RVA: 0x0009E6B0 File Offset: 0x0009C8B0
		protected override void OnParentViewModelChanged(object obj)
		{
			base.OnParentViewModelChanged(obj);
			this._parentViewModel = (obj as IStoreCategorySelect);
		}

		// Token: 0x06003024 RID: 12324 RVA: 0x0009E6D0 File Offset: 0x0009C8D0
		protected override void OnParameterChanged(object obj)
		{
			base.OnParameterChanged(obj);
			if (obj is int)
			{
				int num = (int)obj;
				int? storeId = this._storeId;
				int num2 = num;
				if (!(storeId.GetValueOrDefault() == num2 & storeId != null))
				{
					this.SelectedItem = null;
				}
				List<store_cats> items = this.Items;
				if (items != null)
				{
					items.Clear();
				}
				if (num > 0)
				{
					this._storeId = new int?(num);
					this.LoadCategories();
				}
			}
		}

		// Token: 0x04001B50 RID: 6992
		private IStoreService _storeService;

		// Token: 0x04001B51 RID: 6993
		private IStoreCategorySelect _parentViewModel;

		// Token: 0x04001B52 RID: 6994
		private int? _storeId;

		// Token: 0x04001B53 RID: 6995
		[CompilerGenerated]
		private List<store_cats> <Items>k__BackingField;

		// Token: 0x020004EF RID: 1263
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadCategories>d__13 : IAsyncStateMachine
		{
			// Token: 0x06003025 RID: 12325 RVA: 0x0009E748 File Offset: 0x0009C948
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				StoreCategorySelectViewModel storeCategorySelectViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<store_cats>> awaiter;
					if (num != 0)
					{
						int? storeId = storeCategorySelectViewModel._storeId;
						if (!(storeId.GetValueOrDefault() > 0 & storeId != null))
						{
							goto IL_A1;
						}
						awaiter = storeCategorySelectViewModel._storeService.GetCategoriesAsync(storeCategorySelectViewModel._storeId.Value).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_cats>>, StoreCategorySelectViewModel.<LoadCategories>d__13>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<store_cats>>);
						this.<>1__state = -1;
					}
					List<store_cats> result = awaiter.GetResult();
					storeCategorySelectViewModel.Items = result;
					IL_A1:;
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

			// Token: 0x06003026 RID: 12326 RVA: 0x0009E834 File Offset: 0x0009CA34
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001B54 RID: 6996
			public int <>1__state;

			// Token: 0x04001B55 RID: 6997
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001B56 RID: 6998
			public StoreCategorySelectViewModel <>4__this;

			// Token: 0x04001B57 RID: 6999
			private TaskAwaiter<List<store_cats>> <>u__1;
		}
	}
}
