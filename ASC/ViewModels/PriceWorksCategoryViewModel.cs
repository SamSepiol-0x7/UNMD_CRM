using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Objects;
using ASC.Services;
using ASC.Services.Abstract;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Grid.DragDrop;

namespace ASC.ViewModels
{
	// Token: 0x020003CA RID: 970
	public class PriceWorksCategoryViewModel : CollectionViewModel<ICategory>, ICategoryEdit
	{
		// Token: 0x17000DA0 RID: 3488
		// (get) Token: 0x0600282A RID: 10282 RVA: 0x0007C1D4 File Offset: 0x0007A3D4
		// (set) Token: 0x0600282B RID: 10283 RVA: 0x0007C1E8 File Offset: 0x0007A3E8
		public ICategory NewCategory
		{
			[CompilerGenerated]
			get
			{
				return this.<NewCategory>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<NewCategory>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1224474142;
				IL_13:
				switch ((num ^ -1752199648) % 4)
				{
				case 0:
					goto IL_0E;
				case 2:
					return;
				case 3:
					IL_32:
					this.<NewCategory>k__BackingField = value;
					this.RaisePropertyChanged("NewCategory");
					num = -16355203;
					goto IL_13;
				}
			}
		}

		// Token: 0x17000DA1 RID: 3489
		// (get) Token: 0x0600282C RID: 10284 RVA: 0x0007C244 File Offset: 0x0007A444
		// (set) Token: 0x0600282D RID: 10285 RVA: 0x0007C258 File Offset: 0x0007A458
		public Dictionary<int, string> Prices
		{
			[CompilerGenerated]
			get
			{
				return this.<Prices>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Prices>k__BackingField, value))
				{
					return;
				}
				this.<Prices>k__BackingField = value;
				this.RaisePropertyChanged("Prices");
			}
		}

		// Token: 0x17000DA2 RID: 3490
		// (get) Token: 0x0600282E RID: 10286 RVA: 0x0007C288 File Offset: 0x0007A488
		// (set) Token: 0x0600282F RID: 10287 RVA: 0x0007C2CC File Offset: 0x0007A4CC
		public int SelectedPrice
		{
			get
			{
				return base.GetProperty<int>(() => this.SelectedPrice);
			}
			set
			{
				if (this.SelectedPrice == value)
				{
					return;
				}
				base.SetProperty<int>(() => this.SelectedPrice, value, new Action(this.OnSelectedPriceChanged));
				this.RaisePropertyChanged("SelectedPrice");
			}
		}

		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x06002830 RID: 10288 RVA: 0x0007C334 File Offset: 0x0007A534
		// (set) Token: 0x06002831 RID: 10289 RVA: 0x0007C348 File Offset: 0x0007A548
		public bool ReadOnly
		{
			[CompilerGenerated]
			get
			{
				return this.<ReadOnly>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<ReadOnly>k__BackingField == value)
				{
					return;
				}
				this.<ReadOnly>k__BackingField = value;
				this.RaisePropertyChanged("ReadOnly");
			}
		}

		// Token: 0x06002832 RID: 10290 RVA: 0x0007C374 File Offset: 0x0007A574
		public PriceWorksCategoryViewModel(IWorkshopPriceService workshopPriceService, IVendorService vendorService, IToasterService toasterService, IWindowedDocumentService windowedDocumentService)
		{
			this._workshopPriceService = workshopPriceService;
			this._vendorService = vendorService;
			this._toasterService = toasterService;
			this._windowedDocumentService = windowedDocumentService;
			this.Prices = new Dictionary<int, string>();
			if (Auth.Config.vw_enable)
			{
				this.Prices.Add(0, this.GetCurrentOfficeCompanyName());
				this.SelectedPrice = 0;
				this.SetPrices();
			}
		}

		// Token: 0x06002833 RID: 10291 RVA: 0x0007C3DC File Offset: 0x0007A5DC
		public void SetIsReadOnly(bool value)
		{
			this.ReadOnly = value;
		}

		// Token: 0x06002834 RID: 10292 RVA: 0x0007C3F0 File Offset: 0x0007A5F0
		public override void OnSelectedItemChanged(ICategory obj)
		{
			base.OnSelectedItemChanged(obj);
			base.RaiseCanExecuteChanged(() => this.ShowEditCategory());
		}

		// Token: 0x06002835 RID: 10293 RVA: 0x0007C440 File Offset: 0x0007A640
		private string GetCurrentOfficeCompanyName()
		{
			Company company = OfflineData.Instance.Companies.FirstOrDefault((Company i) => i.Id == OfflineData.Instance.Employee.Office.DefaultCompanyId);
			if (company == null)
			{
				return null;
			}
			return company.Name;
		}

		// Token: 0x06002836 RID: 10294 RVA: 0x0007C488 File Offset: 0x0007A688
		private void SetPrices()
		{
			PriceWorksCategoryViewModel.<SetPrices>d__23 <SetPrices>d__;
			<SetPrices>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SetPrices>d__.<>4__this = this;
			<SetPrices>d__.<>1__state = -1;
			<SetPrices>d__.<>t__builder.Start<PriceWorksCategoryViewModel.<SetPrices>d__23>(ref <SetPrices>d__);
		}

		// Token: 0x06002837 RID: 10295 RVA: 0x0007C4C0 File Offset: 0x0007A6C0
		[Command]
		public void ShowAddCategory()
		{
			this.NewCategory = new Category();
			if (this.SelectedPrice > 0)
			{
				this.NewCategory.VendorId = new int?(this.SelectedPrice);
			}
			if (base.SelectedItem != null)
			{
				int? parent = (base.SelectedItem.Id > 0) ? new int?(base.SelectedItem.Id) : null;
				this.NewCategory.Parent = parent;
			}
			this._windowedDocumentService.ShowNewDocument("StoreCategoryEditView", this, null, null);
		}

		// Token: 0x06002838 RID: 10296 RVA: 0x0007C548 File Offset: 0x0007A748
		[Command]
		public void ShowEditCategory()
		{
			this.NewCategory = new Category
			{
				Id = base.SelectedItem.Id,
				Name = base.SelectedItem.Name,
				Parent = base.SelectedItem.Parent,
				Position = base.SelectedItem.Position,
				Archive = base.SelectedItem.Archive,
				Icon = base.SelectedItem.Icon,
				VendorId = base.SelectedItem.VendorId
			};
			this._windowedDocumentService.ShowNewDocument("StoreCategoryEditView", this, null, null);
		}

		// Token: 0x06002839 RID: 10297 RVA: 0x0007C5EC File Offset: 0x0007A7EC
		[Command]
		public void HideCategoryEditor()
		{
			this.EmptyNewCategory();
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x0600283A RID: 10298 RVA: 0x0007C60C File Offset: 0x0007A80C
		[Command]
		public void AddCategory()
		{
			PriceWorksCategoryViewModel.<AddCategory>d__27 <AddCategory>d__;
			<AddCategory>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<AddCategory>d__.<>4__this = this;
			<AddCategory>d__.<>1__state = -1;
			<AddCategory>d__.<>t__builder.Start<PriceWorksCategoryViewModel.<AddCategory>d__27>(ref <AddCategory>d__);
		}

		// Token: 0x0600283B RID: 10299 RVA: 0x0007C644 File Offset: 0x0007A844
		[Command]
		public void SaveCategory()
		{
			PriceWorksCategoryViewModel.<SaveCategory>d__28 <SaveCategory>d__;
			<SaveCategory>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SaveCategory>d__.<>4__this = this;
			<SaveCategory>d__.<>1__state = -1;
			<SaveCategory>d__.<>t__builder.Start<PriceWorksCategoryViewModel.<SaveCategory>d__28>(ref <SaveCategory>d__);
		}

		// Token: 0x0600283C RID: 10300 RVA: 0x0007C67C File Offset: 0x0007A87C
		public void EmptyNewCategory()
		{
			this.NewCategory = new Category();
		}

		// Token: 0x0600283D RID: 10301 RVA: 0x0007C694 File Offset: 0x0007A894
		[Command]
		public void CategoryDrag(object o)
		{
			TreeListDragOverEventArgs treeListDragOverEventArgs = o as TreeListDragOverEventArgs;
			if (treeListDragOverEventArgs != null)
			{
				if (treeListDragOverEventArgs.TargetNode == null)
				{
					return;
				}
				ICategory category = treeListDragOverEventArgs.TargetNode.Content as ICategory;
				if (category != null)
				{
					if (category.Id > 0)
					{
						return;
					}
					treeListDragOverEventArgs.AllowDrop = false;
					treeListDragOverEventArgs.Handled = true;
				}
			}
		}

		// Token: 0x0600283E RID: 10302 RVA: 0x0007C6E0 File Offset: 0x0007A8E0
		[Command]
		public void SavePosition(object o)
		{
			TreeListControl treeListControl = o as TreeListControl;
			if (treeListControl != null)
			{
				int totalNodesCount = treeListControl.View.TotalNodesCount;
				for (int i = 0; i < totalNodesCount; i++)
				{
					TreeListNode nodeByVisibleIndex = treeListControl.View.GetNodeByVisibleIndex(i);
					if (nodeByVisibleIndex != null)
					{
						int id = ((ICategory)nodeByVisibleIndex.Content).Id;
						ICategory category = base.Items.FirstOrDefault((ICategory ii) => ii.Id == id);
						if (category != null)
						{
							category.Position = new int?(nodeByVisibleIndex.RowHandle);
						}
					}
				}
				base.ShowWait();
				Task.Run<bool>(() => this._workshopPriceService.SaveCategoriesPosition(base.Items)).ContinueWith(delegate(Task<bool> t)
				{
					base.ShowActionResponse(t.Result, "");
					base.HideWait();
				}, TaskScheduler.FromCurrentSynchronizationContext());
			}
		}

		// Token: 0x0600283F RID: 10303 RVA: 0x0007C7A0 File Offset: 0x0007A9A0
		public bool CanShowAddCategory()
		{
			return !this.ReadOnly && OfflineData.Instance.Employee.Can(38, 0);
		}

		// Token: 0x06002840 RID: 10304 RVA: 0x0007C7CC File Offset: 0x0007A9CC
		public bool CanShowEditCategory()
		{
			return !this.ReadOnly && OfflineData.Instance.Employee.Can(38, 0) && base.SelectedItem != null && base.SelectedItem.Id > 0;
		}

		// Token: 0x06002841 RID: 10305 RVA: 0x0007C7A0 File Offset: 0x0007A9A0
		public bool CanSaveCategory()
		{
			return !this.ReadOnly && OfflineData.Instance.Employee.Can(38, 0);
		}

		// Token: 0x06002842 RID: 10306 RVA: 0x0007C810 File Offset: 0x0007AA10
		public bool CheckCategoryFields()
		{
			ICategory newCategory = this.NewCategory;
			if (string.IsNullOrEmpty((newCategory != null) ? newCategory.Name : null))
			{
				this._toasterService.Info(Lang.t("InputCategory"));
				return false;
			}
			return true;
		}

		// Token: 0x06002843 RID: 10307 RVA: 0x0007C850 File Offset: 0x0007AA50
		[Command]
		public void ShowArchive()
		{
			this.LoadCategories(true);
		}

		// Token: 0x06002844 RID: 10308 RVA: 0x0007C864 File Offset: 0x0007AA64
		public void LoadCategories(bool showArchive = false)
		{
			base.ShowWait();
			Task.Run<List<Category>>(() => this._workshopPriceService.GetCategoriesAsync(new int?(this.SelectedPrice), showArchive, true)).ContinueWith(delegate(Task<List<Category>> t)
			{
				this.SetItems(t.Result);
				this.SelectedItem = null;
				this.HideWait();
			}, TaskScheduler.FromCurrentSynchronizationContext());
		}

		// Token: 0x06002845 RID: 10309 RVA: 0x0007C8B4 File Offset: 0x0007AAB4
		private void OnSelectedPriceChanged()
		{
			this.LoadCategories(false);
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x0007C8C8 File Offset: 0x0007AAC8
		[Command]
		public void OnTreeListUnloaded()
		{
			this._workshopPriceService.UpdateCategoriesExpandState(base.Items);
		}

		// Token: 0x06002847 RID: 10311 RVA: 0x0007C8E8 File Offset: 0x0007AAE8
		[CompilerGenerated]
		private Task<bool> <SavePosition>b__31_0()
		{
			return this._workshopPriceService.SaveCategoriesPosition(base.Items);
		}

		// Token: 0x06002848 RID: 10312 RVA: 0x0007C908 File Offset: 0x0007AB08
		[CompilerGenerated]
		private void <SavePosition>b__31_1(Task<bool> t)
		{
			base.ShowActionResponse(t.Result, "");
			base.HideWait();
		}

		// Token: 0x040015FB RID: 5627
		private readonly IWorkshopPriceService _workshopPriceService;

		// Token: 0x040015FC RID: 5628
		private readonly IVendorService _vendorService;

		// Token: 0x040015FD RID: 5629
		private readonly IToasterService _toasterService;

		// Token: 0x040015FE RID: 5630
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x040015FF RID: 5631
		[CompilerGenerated]
		private ICategory <NewCategory>k__BackingField;

		// Token: 0x04001600 RID: 5632
		[CompilerGenerated]
		private Dictionary<int, string> <Prices>k__BackingField;

		// Token: 0x04001601 RID: 5633
		[CompilerGenerated]
		private bool <ReadOnly>k__BackingField;

		// Token: 0x020003CB RID: 971
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002849 RID: 10313 RVA: 0x0007C92C File Offset: 0x0007AB2C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600284A RID: 10314 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x0600284B RID: 10315 RVA: 0x0007C944 File Offset: 0x0007AB44
			internal bool <GetCurrentOfficeCompanyName>b__22_0(Company i)
			{
				return i.Id == OfflineData.Instance.Employee.Office.DefaultCompanyId;
			}

			// Token: 0x04001602 RID: 5634
			public static readonly PriceWorksCategoryViewModel.<>c <>9 = new PriceWorksCategoryViewModel.<>c();

			// Token: 0x04001603 RID: 5635
			public static Func<Company, bool> <>9__22_0;
		}

		// Token: 0x020003CC RID: 972
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SetPrices>d__23 : IAsyncStateMachine
		{
			// Token: 0x0600284C RID: 10316 RVA: 0x0007C970 File Offset: 0x0007AB70
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PriceWorksCategoryViewModel priceWorksCategoryViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<vendors>> awaiter;
					if (num != 0)
					{
						awaiter = priceWorksCategoryViewModel._vendorService.GetVendors().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.<>1__state = num2;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<vendors>>, PriceWorksCategoryViewModel.<SetPrices>d__23>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<vendors>>);
						int num3 = -1;
						num = -1;
						this.<>1__state = num3;
					}
					List<vendors>.Enumerator enumerator = awaiter.GetResult().GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							vendors vendors = enumerator.Current;
							priceWorksCategoryViewModel.Prices.Add(vendors.id, vendors.name);
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)enumerator).Dispose();
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

			// Token: 0x0600284D RID: 10317 RVA: 0x0007CA80 File Offset: 0x0007AC80
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001604 RID: 5636
			public int <>1__state;

			// Token: 0x04001605 RID: 5637
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001606 RID: 5638
			public PriceWorksCategoryViewModel <>4__this;

			// Token: 0x04001607 RID: 5639
			private TaskAwaiter<List<vendors>> <>u__1;
		}

		// Token: 0x020003CD RID: 973
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <AddCategory>d__27 : IAsyncStateMachine
		{
			// Token: 0x0600284E RID: 10318 RVA: 0x0007CA9C File Offset: 0x0007AC9C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PriceWorksCategoryViewModel priceWorksCategoryViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						if (!priceWorksCategoryViewModel.CheckCategoryFields())
						{
							goto IL_C4;
						}
						awaiter = priceWorksCategoryViewModel._workshopPriceService.CreatePriceCategory(priceWorksCategoryViewModel.NewCategory).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, PriceWorksCategoryViewModel.<AddCategory>d__27>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<bool>);
						this.<>1__state = -1;
					}
					bool result;
					if (result = awaiter.GetResult())
					{
						priceWorksCategoryViewModel.EmptyNewCategory();
						priceWorksCategoryViewModel._windowedDocumentService.CloseActiveDocument();
						priceWorksCategoryViewModel.LoadCategories(false);
					}
					priceWorksCategoryViewModel.ShowActionResponse(result, "");
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_C4:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x0600284F RID: 10319 RVA: 0x0007CB90 File Offset: 0x0007AD90
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001608 RID: 5640
			public int <>1__state;

			// Token: 0x04001609 RID: 5641
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400160A RID: 5642
			public PriceWorksCategoryViewModel <>4__this;

			// Token: 0x0400160B RID: 5643
			private TaskAwaiter<bool> <>u__1;
		}

		// Token: 0x020003CE RID: 974
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SaveCategory>d__28 : IAsyncStateMachine
		{
			// Token: 0x06002850 RID: 10320 RVA: 0x0007CBAC File Offset: 0x0007ADAC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PriceWorksCategoryViewModel priceWorksCategoryViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						if (!priceWorksCategoryViewModel.CheckCategoryFields())
						{
							goto IL_C4;
						}
						awaiter = priceWorksCategoryViewModel._workshopPriceService.UpdatePriceCategory(priceWorksCategoryViewModel.NewCategory).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, PriceWorksCategoryViewModel.<SaveCategory>d__28>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<bool>);
						this.<>1__state = -1;
					}
					bool result;
					if (result = awaiter.GetResult())
					{
						priceWorksCategoryViewModel.EmptyNewCategory();
						priceWorksCategoryViewModel._windowedDocumentService.CloseActiveDocument();
						priceWorksCategoryViewModel.LoadCategories(false);
					}
					priceWorksCategoryViewModel.ShowActionResponse(result, "");
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_C4:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002851 RID: 10321 RVA: 0x0007CCA0 File Offset: 0x0007AEA0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400160C RID: 5644
			public int <>1__state;

			// Token: 0x0400160D RID: 5645
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400160E RID: 5646
			public PriceWorksCategoryViewModel <>4__this;

			// Token: 0x0400160F RID: 5647
			private TaskAwaiter<bool> <>u__1;
		}

		// Token: 0x020003CF RID: 975
		[CompilerGenerated]
		private sealed class <>c__DisplayClass31_0
		{
			// Token: 0x06002852 RID: 10322 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass31_0()
			{
			}

			// Token: 0x06002853 RID: 10323 RVA: 0x0007CCBC File Offset: 0x0007AEBC
			internal bool <SavePosition>b__2(ICategory ii)
			{
				return ii.Id == this.id;
			}

			// Token: 0x04001610 RID: 5648
			public int id;
		}

		// Token: 0x020003D0 RID: 976
		[CompilerGenerated]
		private sealed class <>c__DisplayClass37_0
		{
			// Token: 0x06002854 RID: 10324 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass37_0()
			{
			}

			// Token: 0x06002855 RID: 10325 RVA: 0x0007CCD8 File Offset: 0x0007AED8
			internal Task<List<Category>> <LoadCategories>b__0()
			{
				return this.<>4__this._workshopPriceService.GetCategoriesAsync(new int?(this.<>4__this.SelectedPrice), this.showArchive, true);
			}

			// Token: 0x06002856 RID: 10326 RVA: 0x0007CD0C File Offset: 0x0007AF0C
			internal void <LoadCategories>b__1(Task<List<Category>> t)
			{
				this.<>4__this.SetItems(t.Result);
				this.<>4__this.SelectedItem = null;
				this.<>4__this.HideWait();
			}

			// Token: 0x04001611 RID: 5649
			public PriceWorksCategoryViewModel <>4__this;

			// Token: 0x04001612 RID: 5650
			public bool showArchive;
		}
	}
}
