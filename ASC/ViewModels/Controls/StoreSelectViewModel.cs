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
	// Token: 0x020004F1 RID: 1265
	public class StoreSelectViewModel : ViewModelBase
	{
		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x06003028 RID: 12328 RVA: 0x0009E850 File Offset: 0x0009CA50
		// (set) Token: 0x06003029 RID: 12329 RVA: 0x0009E864 File Offset: 0x0009CA64
		public List<stores> Items
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

		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x0600302A RID: 12330 RVA: 0x0009E894 File Offset: 0x0009CA94
		// (set) Token: 0x0600302B RID: 12331 RVA: 0x0009E8D8 File Offset: 0x0009CAD8
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
				base.SetProperty<int?>(() => this.SelectedItem, value, new Action(this.OnStoreChanged));
				this.RaisePropertyChanged("SelectedItem");
			}
		}

		// Token: 0x0600302C RID: 12332 RVA: 0x0009E944 File Offset: 0x0009CB44
		public StoreSelectViewModel(IStoreService storeService)
		{
			this._storeService = storeService;
		}

		// Token: 0x0600302D RID: 12333 RVA: 0x0009E960 File Offset: 0x0009CB60
		[Command]
		public void OnLoaded()
		{
			StoreSelectViewModel.<OnLoaded>d__11 <OnLoaded>d__;
			<OnLoaded>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnLoaded>d__.<>4__this = this;
			<OnLoaded>d__.<>1__state = -1;
			<OnLoaded>d__.<>t__builder.Start<StoreSelectViewModel.<OnLoaded>d__11>(ref <OnLoaded>d__);
		}

		// Token: 0x0600302E RID: 12334 RVA: 0x0009E998 File Offset: 0x0009CB98
		private void OnStoreChanged()
		{
			int? selectedItem = this.SelectedItem;
			if ((selectedItem.GetValueOrDefault() > 0 & selectedItem != null) && this._parentViewModel != null)
			{
				int store = this._inverseSelectedId ? (-this.SelectedItem.Value) : this.SelectedItem.Value;
				this._parentViewModel.SetStore(store);
			}
		}

		// Token: 0x0600302F RID: 12335 RVA: 0x0009E9FC File Offset: 0x0009CBFC
		protected override void OnParentViewModelChanged(object obj)
		{
			base.OnParentViewModelChanged(obj);
			this._parentViewModel = (obj as IStoreSelect);
		}

		// Token: 0x06003030 RID: 12336 RVA: 0x0009EA1C File Offset: 0x0009CC1C
		protected override void OnParameterChanged(object obj)
		{
			base.OnParameterChanged(obj);
			if (obj is int)
			{
				int num = (int)obj;
				if (num <= 0)
				{
					this._inverseSelectedId = true;
				}
				this.SelectedItem = new int?(Math.Abs(num));
			}
		}

		// Token: 0x04001B58 RID: 7000
		private IStoreService _storeService;

		// Token: 0x04001B59 RID: 7001
		private IStoreSelect _parentViewModel;

		// Token: 0x04001B5A RID: 7002
		private bool _inverseSelectedId;

		// Token: 0x04001B5B RID: 7003
		[CompilerGenerated]
		private List<stores> <Items>k__BackingField;

		// Token: 0x020004F2 RID: 1266
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnLoaded>d__11 : IAsyncStateMachine
		{
			// Token: 0x06003031 RID: 12337 RVA: 0x0009EA5C File Offset: 0x0009CC5C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				StoreSelectViewModel storeSelectViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<stores>> awaiter;
					if (num != 0)
					{
						awaiter = storeSelectViewModel._storeService.GetStores().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<stores>>, StoreSelectViewModel.<OnLoaded>d__11>(ref awaiter, ref this);
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
					storeSelectViewModel.Items = result;
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

			// Token: 0x06003032 RID: 12338 RVA: 0x0009EB20 File Offset: 0x0009CD20
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001B5C RID: 7004
			public int <>1__state;

			// Token: 0x04001B5D RID: 7005
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001B5E RID: 7006
			public StoreSelectViewModel <>4__this;

			// Token: 0x04001B5F RID: 7007
			private TaskAwaiter<List<stores>> <>u__1;
		}
	}
}
