using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ASC.Common.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Services.Abstract;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Grid.DragDrop;

namespace ASC.ViewModels
{
	// Token: 0x02000441 RID: 1089
	public class StoreCategoriesViewModel : CollectionViewModel<ICategory>, IStoreCategoryEdit
	{
		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x06002B1B RID: 11035 RVA: 0x00088E5C File Offset: 0x0008705C
		// (set) Token: 0x06002B1C RID: 11036 RVA: 0x00088E70 File Offset: 0x00087070
		public bool StoresEnable
		{
			[CompilerGenerated]
			get
			{
				return this.<StoresEnable>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<StoresEnable>k__BackingField == value)
				{
					return;
				}
				this.<StoresEnable>k__BackingField = value;
				this.RaisePropertyChanged("StoresEnable");
			}
		}

		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x06002B1D RID: 11037 RVA: 0x00088E9C File Offset: 0x0008709C
		// (set) Token: 0x06002B1E RID: 11038 RVA: 0x00088EB0 File Offset: 0x000870B0
		public List<stores> Stores
		{
			[CompilerGenerated]
			get
			{
				return this.<Stores>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Stores>k__BackingField, value))
				{
					return;
				}
				this.<Stores>k__BackingField = value;
				this.RaisePropertyChanged("Stores");
			}
		}

		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x06002B1F RID: 11039 RVA: 0x00088EE0 File Offset: 0x000870E0
		// (set) Token: 0x06002B20 RID: 11040 RVA: 0x00088EF4 File Offset: 0x000870F4
		public bool NoRootNodes
		{
			[CompilerGenerated]
			get
			{
				return this.<NoRootNodes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<NoRootNodes>k__BackingField == value)
				{
					return;
				}
				this.<NoRootNodes>k__BackingField = value;
				this.RaisePropertyChanged("NoRootNodes");
			}
		}

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x06002B21 RID: 11041 RVA: 0x00088F20 File Offset: 0x00087120
		// (set) Token: 0x06002B22 RID: 11042 RVA: 0x00088F64 File Offset: 0x00087164
		public int SelectedStore
		{
			get
			{
				return base.GetProperty<int>(() => this.SelectedStore);
			}
			set
			{
				if (this.SelectedStore != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -274862474;
				IL_10:
				switch ((num ^ -986705308) % 4)
				{
				case 0:
					goto IL_0B;
				case 2:
					return;
				case 3:
					IL_2F:
					base.SetProperty<int>(() => this.SelectedStore, value, new Action(this.StoreChanged));
					num = -1314730603;
					goto IL_10;
				}
				this.RaisePropertyChanged("SelectedStore");
			}
		}

		// Token: 0x06002B23 RID: 11043 RVA: 0x00088FF8 File Offset: 0x000871F8
		public StoreCategoriesViewModel()
		{
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
			this.SetMode(CategoriesMode.Store);
			this.StoresEnable = true;
		}

		// Token: 0x06002B24 RID: 11044 RVA: 0x0008903C File Offset: 0x0008723C
		public StoreCategoriesViewModel(StoreViewModel storeViewModel) : this()
		{
			this._storeViewModel = storeViewModel;
			this.Init();
		}

		// Token: 0x06002B25 RID: 11045 RVA: 0x0008905C File Offset: 0x0008725C
		public void ModeChanged(CategoriesMode mode)
		{
			this.SetMode(mode);
			this.LoadCategories(false);
		}

		// Token: 0x06002B26 RID: 11046 RVA: 0x00089078 File Offset: 0x00087278
		public void SetAllCategorySelected()
		{
			base.SelectedItem = base.Items.FirstOrDefault((ICategory i) => i.Id == 0);
		}

		// Token: 0x06002B27 RID: 11047 RVA: 0x000890B8 File Offset: 0x000872B8
		private void SetMode(CategoriesMode mode)
		{
			this._mode = mode;
			this.StoresEnable = (mode == CategoriesMode.Store);
		}

		// Token: 0x06002B28 RID: 11048 RVA: 0x000890D8 File Offset: 0x000872D8
		private void Init()
		{
			StoreCategoriesViewModel.<Init>d__24 <Init>d__;
			<Init>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<StoreCategoriesViewModel.<Init>d__24>(ref <Init>d__);
		}

		// Token: 0x06002B29 RID: 11049 RVA: 0x00089110 File Offset: 0x00087310
		public int GetSelectedCategory()
		{
			ICategory selectedItem = base.SelectedItem;
			if (selectedItem == null)
			{
				return 0;
			}
			return selectedItem.Id;
		}

		// Token: 0x06002B2A RID: 11050 RVA: 0x00089130 File Offset: 0x00087330
		private void StoreChanged()
		{
			this.LoadCategories(false);
		}

		// Token: 0x06002B2B RID: 11051 RVA: 0x00089144 File Offset: 0x00087344
		public void LoadCategories(bool showArchive = false)
		{
			StoreCategoriesViewModel.<LoadCategories>d__28 <LoadCategories>d__;
			<LoadCategories>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadCategories>d__.<>4__this = this;
			<LoadCategories>d__.showArchive = showArchive;
			<LoadCategories>d__.<>1__state = -1;
			<LoadCategories>d__.<>t__builder.Start<StoreCategoriesViewModel.<LoadCategories>d__28>(ref <LoadCategories>d__);
		}

		// Token: 0x06002B2C RID: 11052 RVA: 0x00089184 File Offset: 0x00087384
		private void DummyNode()
		{
			if (base.Items.Count == 0 && this._mode == CategoriesMode.Store)
			{
				Application.Current.Dispatcher.Invoke(delegate()
				{
					base.Items.Add(new Category
					{
						Name = Lang.t("CreateFirstCategory")
					});
					this.NoRootNodes = true;
				});
				return;
			}
			Application.Current.Dispatcher.Invoke(delegate()
			{
				base.Items.Insert(0, new Category
				{
					Id = 0,
					Name = Lang.t("AllCategories")
				});
				this.NoRootNodes = false;
			});
		}

		// Token: 0x06002B2D RID: 11053 RVA: 0x000891E0 File Offset: 0x000873E0
		public override void OnSelectedItemChanged(ICategory category)
		{
			if (!this._catsLoaded)
			{
				return;
			}
			if (this.SelectedItemChanged != null)
			{
				this.SelectedItemChanged.BeginInvoke(this, category, null, null);
			}
		}

		// Token: 0x06002B2E RID: 11054 RVA: 0x00089210 File Offset: 0x00087410
		public bool CheckCategoryFields()
		{
			if (!StoreModel.AnyStoreExist())
			{
				this._toasterService.Info(Lang.t("CreateStoreInACP"));
				return false;
			}
			if (string.IsNullOrEmpty(this.NewCategory.Name))
			{
				this._toasterService.Info(Lang.t("ItemErrorCategory"));
				return false;
			}
			if (this.NewCategory.Id != 0)
			{
				int id = this.NewCategory.Id;
				int? parent = this.NewCategory.Parent;
				if (id == parent.GetValueOrDefault() & parent != null)
				{
					this._toasterService.Info(Lang.t("InputCategory"));
					return false;
				}
			}
			if (this.SelectedStore != 0)
			{
				return true;
			}
			this._toasterService.Info(Lang.t("SelectStore2"));
			return false;
		}

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x06002B2F RID: 11055 RVA: 0x000892D4 File Offset: 0x000874D4
		// (set) Token: 0x06002B30 RID: 11056 RVA: 0x000892E8 File Offset: 0x000874E8
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
				if (object.Equals(this.<NewCategory>k__BackingField, value))
				{
					return;
				}
				this.<NewCategory>k__BackingField = value;
				this.RaisePropertyChanged("NewCategory");
			}
		}

		// Token: 0x06002B31 RID: 11057 RVA: 0x00089318 File Offset: 0x00087518
		[Command]
		public void OnKeyUp(KeyEventArgs e)
		{
			if (e.Key == Key.Escape)
			{
				this._windowedDocumentService.CloseActiveDocument();
			}
		}

		// Token: 0x06002B32 RID: 11058 RVA: 0x0008933C File Offset: 0x0008753C
		[Command]
		public void OnNewCategoryNameKeyDown(KeyEventArgs e)
		{
			if (e.Key == Key.Return || e.Key == Key.Return)
			{
				if (this.NewCategory.Id > 0)
				{
					this.SaveCategory();
					return;
				}
				this.AddCategory();
			}
		}

		// Token: 0x06002B33 RID: 11059 RVA: 0x00089378 File Offset: 0x00087578
		public bool CanOnNewCategoryNameKeyDown(KeyEventArgs e)
		{
			return this.NewCategory != null;
		}

		// Token: 0x06002B34 RID: 11060 RVA: 0x00089390 File Offset: 0x00087590
		[Command]
		public void ShowAddCategory()
		{
			this.NewCategory = new Category();
			if (base.SelectedItem != null)
			{
				int? parent = (base.SelectedItem.Id > 0) ? new int?(base.SelectedItem.Id) : null;
				this.NewCategory.Parent = parent;
			}
			this._windowedDocumentService.ShowNewDocument("StoreCategoryEditView", this, null, null);
		}

		// Token: 0x06002B35 RID: 11061 RVA: 0x000893FC File Offset: 0x000875FC
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
				Icon = base.SelectedItem.Icon
			};
			this._windowedDocumentService.ShowNewDocument("StoreCategoryEditView", this, null, null);
		}

		// Token: 0x06002B36 RID: 11062 RVA: 0x00089490 File Offset: 0x00087690
		public bool CanShowEditCategory()
		{
			return !this._storeViewModel.ReturnSelectedItems && OfflineData.Instance.Employee.Can(46, 0) && base.SelectedItem != null && base.SelectedItem.Id > 0 && this._mode == CategoriesMode.Store;
		}

		// Token: 0x06002B37 RID: 11063 RVA: 0x000894E0 File Offset: 0x000876E0
		[Command]
		public void HideCategoryEditor()
		{
			this.EmptyNewCategory();
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x06002B38 RID: 11064 RVA: 0x00089500 File Offset: 0x00087700
		[Command]
		public void ShowArchive()
		{
			this.LoadCategories(true);
		}

		// Token: 0x06002B39 RID: 11065 RVA: 0x00089514 File Offset: 0x00087714
		[Command]
		public void AddCategory()
		{
			StoreCategoriesViewModel.<AddCategory>d__44 <AddCategory>d__;
			<AddCategory>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<AddCategory>d__.<>4__this = this;
			<AddCategory>d__.<>1__state = -1;
			<AddCategory>d__.<>t__builder.Start<StoreCategoriesViewModel.<AddCategory>d__44>(ref <AddCategory>d__);
		}

		// Token: 0x06002B3A RID: 11066 RVA: 0x0008954C File Offset: 0x0008774C
		public bool CanAddCategory()
		{
			return OfflineData.Instance.Employee.Can(46, 0) && this._mode == CategoriesMode.Store;
		}

		// Token: 0x06002B3B RID: 11067 RVA: 0x00089578 File Offset: 0x00087778
		[Command]
		public void SaveCategory()
		{
			StoreCategoriesViewModel.<SaveCategory>d__46 <SaveCategory>d__;
			<SaveCategory>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SaveCategory>d__.<>4__this = this;
			<SaveCategory>d__.<>1__state = -1;
			<SaveCategory>d__.<>t__builder.Start<StoreCategoriesViewModel.<SaveCategory>d__46>(ref <SaveCategory>d__);
		}

		// Token: 0x06002B3C RID: 11068 RVA: 0x000895B0 File Offset: 0x000877B0
		public bool CanSaveCategory()
		{
			return OfflineData.Instance.Employee.Can(46, 0);
		}

		// Token: 0x06002B3D RID: 11069 RVA: 0x000895D0 File Offset: 0x000877D0
		public void EmptyNewCategory()
		{
			this.NewCategory = new Category();
		}

		// Token: 0x06002B3E RID: 11070 RVA: 0x000895E8 File Offset: 0x000877E8
		public bool CanShowAddCategory()
		{
			return !this._storeViewModel.ReturnSelectedItems && OfflineData.Instance.Employee.Can(46, 0) && this.SelectedStore > 0 && this._mode == CategoriesMode.Store;
		}

		// Token: 0x06002B3F RID: 11071 RVA: 0x0008962C File Offset: 0x0008782C
		[Command]
		public void SavePosition(object o)
		{
			StoreCategoriesViewModel.<SavePosition>d__50 <SavePosition>d__;
			<SavePosition>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SavePosition>d__.<>4__this = this;
			<SavePosition>d__.o = o;
			<SavePosition>d__.<>1__state = -1;
			<SavePosition>d__.<>t__builder.Start<StoreCategoriesViewModel.<SavePosition>d__50>(ref <SavePosition>d__);
		}

		// Token: 0x06002B40 RID: 11072 RVA: 0x000895E8 File Offset: 0x000877E8
		public bool CanSavePosition(object o)
		{
			return !this._storeViewModel.ReturnSelectedItems && OfflineData.Instance.Employee.Can(46, 0) && this.SelectedStore > 0 && this._mode == CategoriesMode.Store;
		}

		// Token: 0x06002B41 RID: 11073 RVA: 0x0008966C File Offset: 0x0008786C
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

		// Token: 0x06002B42 RID: 11074 RVA: 0x000896BC File Offset: 0x000878BC
		public bool CanCategoryDrag(object o)
		{
			return this._mode == CategoriesMode.Store;
		}

		// Token: 0x06002B43 RID: 11075 RVA: 0x000896D4 File Offset: 0x000878D4
		[CompilerGenerated]
		private void <DummyNode>b__29_0()
		{
			base.Items.Add(new Category
			{
				Name = Lang.t("CreateFirstCategory")
			});
			this.NoRootNodes = true;
		}

		// Token: 0x06002B44 RID: 11076 RVA: 0x00089708 File Offset: 0x00087908
		[CompilerGenerated]
		private void <DummyNode>b__29_1()
		{
			base.Items.Insert(0, new Category
			{
				Id = 0,
				Name = Lang.t("AllCategories")
			});
			this.NoRootNodes = false;
		}

		// Token: 0x06002B45 RID: 11077 RVA: 0x00089744 File Offset: 0x00087944
		[CompilerGenerated]
		private Task<bool> <SavePosition>b__50_1()
		{
			return StoreModel.SavePosition(base.Items, this.SelectedStore);
		}

		// Token: 0x04001809 RID: 6153
		private readonly IToasterService _toasterService;

		// Token: 0x0400180A RID: 6154
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x0400180B RID: 6155
		private readonly StoreViewModel _storeViewModel;

		// Token: 0x0400180C RID: 6156
		[CompilerGenerated]
		private bool <StoresEnable>k__BackingField;

		// Token: 0x0400180D RID: 6157
		[CompilerGenerated]
		private List<stores> <Stores>k__BackingField;

		// Token: 0x0400180E RID: 6158
		[CompilerGenerated]
		private bool <NoRootNodes>k__BackingField;

		// Token: 0x0400180F RID: 6159
		private CategoriesMode _mode;

		// Token: 0x04001810 RID: 6160
		private bool _catsLoaded;

		// Token: 0x04001811 RID: 6161
		[CompilerGenerated]
		private ICategory <NewCategory>k__BackingField;

		// Token: 0x02000442 RID: 1090
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002B46 RID: 11078 RVA: 0x00089764 File Offset: 0x00087964
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06002B47 RID: 11079 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06002B48 RID: 11080 RVA: 0x0008977C File Offset: 0x0008797C
			internal bool <SetAllCategorySelected>b__22_0(ICategory i)
			{
				return i.Id == 0;
			}

			// Token: 0x06002B49 RID: 11081 RVA: 0x00089794 File Offset: 0x00087994
			internal Task<List<stores>> <Init>b__24_0()
			{
				return StoreModel.LoadStores(false, true);
			}

			// Token: 0x06002B4A RID: 11082 RVA: 0x000897A8 File Offset: 0x000879A8
			internal List<StoreCategory> <LoadCategories>b__28_1()
			{
				return StoreModel.GetOnUserItemCategories();
			}

			// Token: 0x04001812 RID: 6162
			public static readonly StoreCategoriesViewModel.<>c <>9 = new StoreCategoriesViewModel.<>c();

			// Token: 0x04001813 RID: 6163
			public static Func<ICategory, bool> <>9__22_0;

			// Token: 0x04001814 RID: 6164
			public static Func<Task<List<stores>>> <>9__24_0;

			// Token: 0x04001815 RID: 6165
			public static Func<List<StoreCategory>> <>9__28_1;
		}

		// Token: 0x02000443 RID: 1091
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Init>d__24 : IAsyncStateMachine
		{
			// Token: 0x06002B4B RID: 11083 RVA: 0x000897BC File Offset: 0x000879BC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				StoreCategoriesViewModel storeCategoriesViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<stores>> awaiter;
					if (num != 0)
					{
						awaiter = Task.Run<List<stores>>(new Func<Task<List<stores>>>(StoreCategoriesViewModel.<>c.<>9.<Init>b__24_0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<stores>>, StoreCategoriesViewModel.<Init>d__24>(ref awaiter, ref this);
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
					storeCategoriesViewModel.SelectedStore = OfflineData.Instance.Employee.StoreDefault;
					storeCategoriesViewModel.Stores = result;
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

			// Token: 0x06002B4C RID: 11084 RVA: 0x000898AC File Offset: 0x00087AAC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001816 RID: 6166
			public int <>1__state;

			// Token: 0x04001817 RID: 6167
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001818 RID: 6168
			public StoreCategoriesViewModel <>4__this;

			// Token: 0x04001819 RID: 6169
			private TaskAwaiter<List<stores>> <>u__1;
		}

		// Token: 0x02000444 RID: 1092
		[CompilerGenerated]
		private sealed class <>c__DisplayClass28_0
		{
			// Token: 0x06002B4D RID: 11085 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass28_0()
			{
			}

			// Token: 0x06002B4E RID: 11086 RVA: 0x000898C8 File Offset: 0x00087AC8
			internal Task<List<StoreCategory>> <LoadCategories>b__0()
			{
				return StoreModel.GetCategories(this.<>4__this.SelectedStore, this.showArchive);
			}

			// Token: 0x0400181A RID: 6170
			public StoreCategoriesViewModel <>4__this;

			// Token: 0x0400181B RID: 6171
			public bool showArchive;
		}

		// Token: 0x02000445 RID: 1093
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadCategories>d__28 : IAsyncStateMachine
		{
			// Token: 0x06002B4F RID: 11087 RVA: 0x000898EC File Offset: 0x00087AEC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				StoreCategoriesViewModel storeCategoriesViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<StoreCategory>> awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<StoreCategory>>);
							this.<>1__state = -1;
							goto IL_14F;
						}
						StoreCategoriesViewModel.<>c__DisplayClass28_0 CS$<>8__locals1 = new StoreCategoriesViewModel.<>c__DisplayClass28_0();
						CS$<>8__locals1.<>4__this = this.<>4__this;
						CS$<>8__locals1.showArchive = this.showArchive;
						storeCategoriesViewModel._catsLoaded = false;
						if (storeCategoriesViewModel._mode != CategoriesMode.Store)
						{
							goto IL_F1;
						}
						if (storeCategoriesViewModel.SelectedStore == 0)
						{
							storeCategoriesViewModel.Items.Clear();
						}
						awaiter = Task.Run<List<StoreCategory>>(new Func<Task<List<StoreCategory>>>(CS$<>8__locals1.<LoadCategories>b__0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<StoreCategory>>, StoreCategoriesViewModel.<LoadCategories>d__28>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<StoreCategory>>);
						this.<>1__state = -1;
					}
					List<StoreCategory> result = awaiter.GetResult();
					storeCategoriesViewModel.SetItems(result);
					IL_F1:
					if (storeCategoriesViewModel._mode != CategoriesMode.Cart)
					{
						goto IL_15E;
					}
					awaiter = Task.Run<List<StoreCategory>>(new Func<List<StoreCategory>>(StoreCategoriesViewModel.<>c.<>9.<LoadCategories>b__28_1)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<StoreCategory>>, StoreCategoriesViewModel.<LoadCategories>d__28>(ref awaiter, ref this);
						return;
					}
					IL_14F:
					result = awaiter.GetResult();
					storeCategoriesViewModel.SetItems(result);
					IL_15E:
					storeCategoriesViewModel.DummyNode();
					storeCategoriesViewModel._catsLoaded = true;
					storeCategoriesViewModel.SetAllCategorySelected();
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

			// Token: 0x06002B50 RID: 11088 RVA: 0x00089AB4 File Offset: 0x00087CB4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400181C RID: 6172
			public int <>1__state;

			// Token: 0x0400181D RID: 6173
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400181E RID: 6174
			public StoreCategoriesViewModel <>4__this;

			// Token: 0x0400181F RID: 6175
			public bool showArchive;

			// Token: 0x04001820 RID: 6176
			private TaskAwaiter<List<StoreCategory>> <>u__1;
		}

		// Token: 0x02000446 RID: 1094
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <AddCategory>d__44 : IAsyncStateMachine
		{
			// Token: 0x06002B51 RID: 11089 RVA: 0x00089AD0 File Offset: 0x00087CD0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				StoreCategoriesViewModel storeCategoriesViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						if (!storeCategoriesViewModel.CheckCategoryFields())
						{
							goto IL_C4;
						}
						awaiter = StoreModel.AddCategory(storeCategoriesViewModel.NewCategory, storeCategoriesViewModel.SelectedStore).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, StoreCategoriesViewModel.<AddCategory>d__44>(ref awaiter, ref this);
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
						storeCategoriesViewModel.EmptyNewCategory();
						storeCategoriesViewModel._windowedDocumentService.CloseActiveDocument();
						storeCategoriesViewModel.LoadCategories(false);
					}
					storeCategoriesViewModel.ShowActionResponse(result, "");
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

			// Token: 0x06002B52 RID: 11090 RVA: 0x00089BC4 File Offset: 0x00087DC4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001821 RID: 6177
			public int <>1__state;

			// Token: 0x04001822 RID: 6178
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001823 RID: 6179
			public StoreCategoriesViewModel <>4__this;

			// Token: 0x04001824 RID: 6180
			private TaskAwaiter<bool> <>u__1;
		}

		// Token: 0x02000447 RID: 1095
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SaveCategory>d__46 : IAsyncStateMachine
		{
			// Token: 0x06002B53 RID: 11091 RVA: 0x00089BE0 File Offset: 0x00087DE0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				StoreCategoriesViewModel storeCategoriesViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						if (!storeCategoriesViewModel.CheckCategoryFields())
						{
							goto IL_BB;
						}
						awaiter = StoreModel.UpdateCategory(storeCategoriesViewModel.NewCategory).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, StoreCategoriesViewModel.<SaveCategory>d__46>(ref awaiter, ref this);
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
						storeCategoriesViewModel.EmptyNewCategory();
						storeCategoriesViewModel._windowedDocumentService.CloseActiveDocument();
						storeCategoriesViewModel.LoadCategories(false);
					}
					storeCategoriesViewModel.ShowActionResponse(result, "");
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_BB:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002B54 RID: 11092 RVA: 0x00089CCC File Offset: 0x00087ECC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001825 RID: 6181
			public int <>1__state;

			// Token: 0x04001826 RID: 6182
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001827 RID: 6183
			public StoreCategoriesViewModel <>4__this;

			// Token: 0x04001828 RID: 6184
			private TaskAwaiter<bool> <>u__1;
		}

		// Token: 0x02000448 RID: 1096
		[CompilerGenerated]
		private sealed class <>c__DisplayClass50_0
		{
			// Token: 0x06002B55 RID: 11093 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass50_0()
			{
			}

			// Token: 0x06002B56 RID: 11094 RVA: 0x00089CE8 File Offset: 0x00087EE8
			internal bool <SavePosition>b__0(ICategory ii)
			{
				return ii.Id == this.id;
			}

			// Token: 0x04001829 RID: 6185
			public int id;
		}

		// Token: 0x02000449 RID: 1097
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SavePosition>d__50 : IAsyncStateMachine
		{
			// Token: 0x06002B57 RID: 11095 RVA: 0x00089D04 File Offset: 0x00087F04
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				StoreCategoriesViewModel storeCategoriesViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						TreeListControl treeListControl = this.o as TreeListControl;
						if (treeListControl == null)
						{
							goto IL_126;
						}
						int totalNodesCount = treeListControl.View.TotalNodesCount;
						for (int i = 0; i < totalNodesCount; i++)
						{
							TreeListNode nodeByVisibleIndex = treeListControl.View.GetNodeByVisibleIndex(i);
							if (nodeByVisibleIndex != null)
							{
								StoreCategoriesViewModel.<>c__DisplayClass50_0 CS$<>8__locals1 = new StoreCategoriesViewModel.<>c__DisplayClass50_0();
								CS$<>8__locals1.id = ((ICategory)nodeByVisibleIndex.Content).Id;
								ICategory category = storeCategoriesViewModel.Items.FirstOrDefault(new Func<ICategory, bool>(CS$<>8__locals1.<SavePosition>b__0));
								if (category != null)
								{
									category.Position = new int?(nodeByVisibleIndex.RowHandle);
								}
							}
						}
						storeCategoriesViewModel.ShowWait();
						awaiter = Task.Run<bool>(() => StoreModel.SavePosition(base.Items, base.SelectedStore)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, StoreCategoriesViewModel.<SavePosition>d__50>(ref awaiter, ref this);
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
					storeCategoriesViewModel.HideWait();
					storeCategoriesViewModel.ShowActionResponse(result, "");
					IL_126:;
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

			// Token: 0x06002B58 RID: 11096 RVA: 0x00089E84 File Offset: 0x00088084
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400182A RID: 6186
			public int <>1__state;

			// Token: 0x0400182B RID: 6187
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400182C RID: 6188
			public object o;

			// Token: 0x0400182D RID: 6189
			public StoreCategoriesViewModel <>4__this;

			// Token: 0x0400182E RID: 6190
			private TaskAwaiter<bool> <>u__1;
		}
	}
}
