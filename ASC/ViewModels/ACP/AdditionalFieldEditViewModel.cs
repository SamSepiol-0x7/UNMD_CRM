using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Enum;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Objects;
using ASC.Objects.Converters;
using ASC.Services.Abstract;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Xpf.Editors;

namespace ASC.ViewModels.ACP
{
	// Token: 0x02000555 RID: 1365
	public class AdditionalFieldEditViewModel : PopupViewModel, IPopupViewModel
	{
		// Token: 0x17000F93 RID: 3987
		// (get) Token: 0x060032B9 RID: 12985 RVA: 0x000AA8BC File Offset: 0x000A8ABC
		// (set) Token: 0x060032BA RID: 12986 RVA: 0x000AA8D0 File Offset: 0x000A8AD0
		public List<KeyValuePair<int, string>> FieldTypes
		{
			[CompilerGenerated]
			get
			{
				return this.<FieldTypes>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<FieldTypes>k__BackingField, value))
				{
					return;
				}
				this.<FieldTypes>k__BackingField = value;
				this.RaisePropertyChanged("FieldTypes");
			}
		}

		// Token: 0x17000F94 RID: 3988
		// (get) Token: 0x060032BB RID: 12987 RVA: 0x000AA900 File Offset: 0x000A8B00
		// (set) Token: 0x060032BC RID: 12988 RVA: 0x000AA914 File Offset: 0x000A8B14
		public List<IDevice> Devices
		{
			[CompilerGenerated]
			get
			{
				return this.<Devices>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Devices>k__BackingField, value))
				{
					return;
				}
				this.<Devices>k__BackingField = value;
				this.RaisePropertyChanged("Devices");
			}
		}

		// Token: 0x17000F95 RID: 3989
		// (get) Token: 0x060032BD RID: 12989 RVA: 0x000AA944 File Offset: 0x000A8B44
		// (set) Token: 0x060032BE RID: 12990 RVA: 0x000AA958 File Offset: 0x000A8B58
		public List<ICategory> Categories
		{
			[CompilerGenerated]
			get
			{
				return this.<Categories>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(this.<Categories>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1426764714;
				IL_13:
				switch ((num ^ 2053016941) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					IL_32:
					num = 547727583;
					goto IL_13;
				case 3:
					return;
				}
				this.<Categories>k__BackingField = value;
				this.RaisePropertyChanged("Categories");
			}
		}

		// Token: 0x17000F96 RID: 3990
		// (get) Token: 0x060032BF RID: 12991 RVA: 0x000AA9B4 File Offset: 0x000A8BB4
		// (set) Token: 0x060032C0 RID: 12992 RVA: 0x000AA9C8 File Offset: 0x000A8BC8
		public fields Item
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
				this.RaisePropertyChanged("HasDefaultValue");
				this.RaisePropertyChanged("MultilineDefaultValue");
				this.RaisePropertyChanged("Item");
			}
		}

		// Token: 0x17000F97 RID: 3991
		// (get) Token: 0x060032C1 RID: 12993 RVA: 0x000AAA0C File Offset: 0x000A8C0C
		public bool HasDefaultValue
		{
			get
			{
				return this.Item != null && this.Item.type != 3;
			}
		}

		// Token: 0x17000F98 RID: 3992
		// (get) Token: 0x060032C2 RID: 12994 RVA: 0x000AAA34 File Offset: 0x000A8C34
		public bool MultilineDefaultValue
		{
			get
			{
				return this.Item != null && this.Item.type == 2;
			}
		}

		// Token: 0x17000F99 RID: 3993
		// (get) Token: 0x060032C3 RID: 12995 RVA: 0x000AAA5C File Offset: 0x000A8C5C
		// (set) Token: 0x060032C4 RID: 12996 RVA: 0x000AAA70 File Offset: 0x000A8C70
		public List<int> SelectedDevices
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedDevices>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<SelectedDevices>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1251222479;
				IL_13:
				switch ((num ^ -837130666) % 4)
				{
				case 0:
					IL_32:
					this.<SelectedDevices>k__BackingField = value;
					this.RaisePropertyChanged("SelectedDevices");
					num = -728992401;
					goto IL_13;
				case 2:
					goto IL_0E;
				case 3:
					return;
				}
			}
		}

		// Token: 0x17000F9A RID: 3994
		// (get) Token: 0x060032C5 RID: 12997 RVA: 0x000AAACC File Offset: 0x000A8CCC
		// (set) Token: 0x060032C6 RID: 12998 RVA: 0x000AAAE0 File Offset: 0x000A8CE0
		public List<int> SelectedCategories
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedCategories>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedCategories>k__BackingField, value))
				{
					return;
				}
				this.<SelectedCategories>k__BackingField = value;
				this.RaisePropertyChanged("SelectedCategories");
			}
		}

		// Token: 0x060032C7 RID: 12999 RVA: 0x000AAB10 File Offset: 0x000A8D10
		public AdditionalFieldEditViewModel(IStoreService storeService, IWorkshopService workshopService, IToasterService toasterService, IAdditionalFieldsService additionalFieldsService)
		{
			this._storeService = storeService;
			this._workshopService = workshopService;
			this._toasterService = toasterService;
			this._additionalFieldsService = additionalFieldsService;
			fields item = new fields
			{
				C_f = false,
				type = 1,
				def_values = ""
			};
			this.SetItem(item);
			this.LoadFieldTypes();
			this.LoadDevices();
			this.LoadCategories();
		}

		// Token: 0x060032C8 RID: 13000 RVA: 0x000AAB78 File Offset: 0x000A8D78
		private void SetTitle()
		{
			base.Title = ((this.Item.id > 0) ? this.Item.name : Lang.t("NewField"));
		}

		// Token: 0x060032C9 RID: 13001 RVA: 0x000AABB0 File Offset: 0x000A8DB0
		private void SetSelectedDevices(string values)
		{
			List<int> selectedDevices = values.Split(new char[]
			{
				','
			}).Select(new Func<string, int>(int.Parse)).ToList<int>();
			this.SetSelectedDevices(selectedDevices);
		}

		// Token: 0x060032CA RID: 13002 RVA: 0x000AABEC File Offset: 0x000A8DEC
		private void SetSelectedCategories(string values)
		{
			this.SelectedCategories = values.Split(new char[]
			{
				','
			}).Select(new Func<string, int>(int.Parse)).ToList<int>();
		}

		// Token: 0x060032CB RID: 13003 RVA: 0x000AAC28 File Offset: 0x000A8E28
		private void SetSelectedDevices(IEnumerable<int> values)
		{
			this.SelectedDevices = new List<int>(values);
		}

		// Token: 0x060032CC RID: 13004 RVA: 0x000AAC44 File Offset: 0x000A8E44
		private string GetSelectedDevices()
		{
			if (this.SelectedDevices != null && this.SelectedDevices.Any<int>())
			{
				return string.Join<int>(",", this.SelectedDevices);
			}
			return string.Empty;
		}

		// Token: 0x060032CD RID: 13005 RVA: 0x000AAC7C File Offset: 0x000A8E7C
		private string GetSelectedCategories()
		{
			if (this.SelectedCategories != null && this.SelectedCategories.Any<int>())
			{
				return string.Join<int>(",", this.SelectedCategories);
			}
			return string.Empty;
		}

		// Token: 0x060032CE RID: 13006 RVA: 0x000AACB4 File Offset: 0x000A8EB4
		public void SetItem(fields item)
		{
			this.Item = item;
			if (!string.IsNullOrEmpty(item.devices))
			{
				this.SetSelectedDevices(item.devices);
			}
			if (!string.IsNullOrEmpty(item.categories))
			{
				this.SetSelectedCategories(item.categories);
			}
			this.SetTitle();
		}

		// Token: 0x060032CF RID: 13007 RVA: 0x000AAD00 File Offset: 0x000A8F00
		private void LoadCategories()
		{
			AdditionalFieldEditViewModel.<LoadCategories>d__41 <LoadCategories>d__;
			<LoadCategories>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadCategories>d__.<>4__this = this;
			<LoadCategories>d__.<>1__state = -1;
			<LoadCategories>d__.<>t__builder.Start<AdditionalFieldEditViewModel.<LoadCategories>d__41>(ref <LoadCategories>d__);
		}

		// Token: 0x060032D0 RID: 13008 RVA: 0x000AAD38 File Offset: 0x000A8F38
		private void LoadDevices()
		{
			AdditionalFieldEditViewModel.<LoadDevices>d__42 <LoadDevices>d__;
			<LoadDevices>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadDevices>d__.<>4__this = this;
			<LoadDevices>d__.<>1__state = -1;
			<LoadDevices>d__.<>t__builder.Start<AdditionalFieldEditViewModel.<LoadDevices>d__42>(ref <LoadDevices>d__);
		}

		// Token: 0x060032D1 RID: 13009 RVA: 0x000AAD70 File Offset: 0x000A8F70
		private void LoadFieldTypes()
		{
			this.FieldTypes = new List<KeyValuePair<int, string>>
			{
				new KeyValuePair<int, string>(1, Lang.t("TextInput")),
				new KeyValuePair<int, string>(2, Lang.t("DropDownList")),
				new KeyValuePair<int, string>(3, Lang.t("DatePicker")),
				new KeyValuePair<int, string>(4, Lang.t("IntegerInput"))
			};
		}

		// Token: 0x060032D2 RID: 13010 RVA: 0x000AADE0 File Offset: 0x000A8FE0
		[AsyncCommand]
		public Task Save()
		{
			AdditionalFieldEditViewModel.<Save>d__44 <Save>d__;
			<Save>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Save>d__.<>4__this = this;
			<Save>d__.<>1__state = -1;
			<Save>d__.<>t__builder.Start<AdditionalFieldEditViewModel.<Save>d__44>(ref <Save>d__);
			return <Save>d__.<>t__builder.Task;
		}

		// Token: 0x060032D3 RID: 13011 RVA: 0x00023150 File Offset: 0x00021350
		public void OnUnloaded()
		{
		}

		// Token: 0x060032D4 RID: 13012 RVA: 0x000AAE24 File Offset: 0x000A9024
		public bool CanSave()
		{
			return this.Item != null && this.Item.id > 0;
		}

		// Token: 0x060032D5 RID: 13013 RVA: 0x000AAE4C File Offset: 0x000A904C
		[AsyncCommand]
		public Task Create()
		{
			AdditionalFieldEditViewModel.<Create>d__47 <Create>d__;
			<Create>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Create>d__.<>4__this = this;
			<Create>d__.<>1__state = -1;
			<Create>d__.<>t__builder.Start<AdditionalFieldEditViewModel.<Create>d__47>(ref <Create>d__);
			return <Create>d__.<>t__builder.Task;
		}

		// Token: 0x060032D6 RID: 13014 RVA: 0x000AAE90 File Offset: 0x000A9090
		public bool CanCreate()
		{
			return this.Item != null && this.Item.id == 0;
		}

		// Token: 0x060032D7 RID: 13015 RVA: 0x000AAEB8 File Offset: 0x000A90B8
		private bool CheckAdditionalField()
		{
			if (string.IsNullOrEmpty(this.Item.name))
			{
				this._toasterService.Info(Lang.t("InputFieldName"));
				return false;
			}
			return true;
		}

		// Token: 0x060032D8 RID: 13016 RVA: 0x00023150 File Offset: 0x00021350
		public void OnLoaded()
		{
		}

		// Token: 0x060032D9 RID: 13017 RVA: 0x000AAEF0 File Offset: 0x000A90F0
		private void RefreshParent()
		{
			AdditionalFieldsListViewModel parentViewModel = this._parentViewModel;
			if (parentViewModel == null)
			{
				return;
			}
			parentViewModel.RefreshItems();
		}

		// Token: 0x060032DA RID: 13018 RVA: 0x000AAF10 File Offset: 0x000A9110
		protected override void OnParentViewModelChanged(object obj)
		{
			base.OnParentViewModelChanged(obj);
			this._parentViewModel = (obj as AdditionalFieldsListViewModel);
		}

		// Token: 0x060032DB RID: 13019 RVA: 0x000AAF30 File Offset: 0x000A9130
		public void SetType(AttributeType t)
		{
			this.Item.C_f = (t == AttributeType.ProductAttribute);
		}

		// Token: 0x060032DC RID: 13020 RVA: 0x000AAF4C File Offset: 0x000A914C
		[Command]
		public void SelectedCategoriesEditValueChanging(EditValueChangingEventArgs e)
		{
			List<int> list = e.NewValue as List<int>;
			if (list != null)
			{
				if (list.Any((int i) => i < 0))
				{
					e.IsCancel = true;
					e.Handled = true;
				}
			}
		}

		// Token: 0x060032DD RID: 13021 RVA: 0x000AAFA0 File Offset: 0x000A91A0
		[Command]
		public void ItemTypeChanged()
		{
			base.RaisePropertyChanged<bool>(() => this.MultilineDefaultValue);
		}

		// Token: 0x04001D2A RID: 7466
		private readonly IStoreService _storeService;

		// Token: 0x04001D2B RID: 7467
		private readonly IWorkshopService _workshopService;

		// Token: 0x04001D2C RID: 7468
		private readonly IToasterService _toasterService;

		// Token: 0x04001D2D RID: 7469
		private readonly IAdditionalFieldsService _additionalFieldsService;

		// Token: 0x04001D2E RID: 7470
		private AdditionalFieldsListViewModel _parentViewModel;

		// Token: 0x04001D2F RID: 7471
		[CompilerGenerated]
		private List<KeyValuePair<int, string>> <FieldTypes>k__BackingField;

		// Token: 0x04001D30 RID: 7472
		[CompilerGenerated]
		private List<IDevice> <Devices>k__BackingField;

		// Token: 0x04001D31 RID: 7473
		[CompilerGenerated]
		private List<ICategory> <Categories>k__BackingField;

		// Token: 0x04001D32 RID: 7474
		[CompilerGenerated]
		private fields <Item>k__BackingField;

		// Token: 0x04001D33 RID: 7475
		[CompilerGenerated]
		private List<int> <SelectedDevices>k__BackingField;

		// Token: 0x04001D34 RID: 7476
		[CompilerGenerated]
		private List<int> <SelectedCategories>k__BackingField;

		// Token: 0x02000556 RID: 1366
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060032DE RID: 13022 RVA: 0x000AAFE4 File Offset: 0x000A91E4
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060032DF RID: 13023 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x060032E0 RID: 13024 RVA: 0x000AAFFC File Offset: 0x000A91FC
			internal stores <LoadCategories>b__41_0(store_cats i)
			{
				return i.stores;
			}

			// Token: 0x060032E1 RID: 13025 RVA: 0x00093000 File Offset: 0x00091200
			internal store_cats <LoadCategories>b__41_1(store_cats i)
			{
				return i;
			}

			// Token: 0x060032E2 RID: 13026 RVA: 0x000AB010 File Offset: 0x000A9210
			internal int? <LoadCategories>b__41_2(store_cats i)
			{
				return i.position;
			}

			// Token: 0x060032E3 RID: 13027 RVA: 0x00041A48 File Offset: 0x0003FC48
			internal bool <LoadDevices>b__42_0(IDevice d)
			{
				return !d.Refill;
			}

			// Token: 0x060032E4 RID: 13028 RVA: 0x000AB024 File Offset: 0x000A9224
			internal bool <SelectedCategoriesEditValueChanging>b__54_0(int i)
			{
				return i < 0;
			}

			// Token: 0x04001D35 RID: 7477
			public static readonly AdditionalFieldEditViewModel.<>c <>9 = new AdditionalFieldEditViewModel.<>c();

			// Token: 0x04001D36 RID: 7478
			public static Func<store_cats, stores> <>9__41_0;

			// Token: 0x04001D37 RID: 7479
			public static Func<store_cats, store_cats> <>9__41_1;

			// Token: 0x04001D38 RID: 7480
			public static Func<store_cats, int?> <>9__41_2;

			// Token: 0x04001D39 RID: 7481
			public static Func<IDevice, bool> <>9__42_0;

			// Token: 0x04001D3A RID: 7482
			public static Func<int, bool> <>9__54_0;
		}

		// Token: 0x02000557 RID: 1367
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadCategories>d__41 : IAsyncStateMachine
		{
			// Token: 0x060032E5 RID: 13029 RVA: 0x000AB038 File Offset: 0x000A9238
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AdditionalFieldEditViewModel additionalFieldEditViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<store_cats>> awaiter;
					if (num != 0)
					{
						this.<result>5__2 = new List<ICategory>();
						awaiter = additionalFieldEditViewModel._storeService.GetCategoriesAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.<>1__state = num2;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_cats>>, AdditionalFieldEditViewModel.<LoadCategories>d__41>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<store_cats>>);
						int num3 = -1;
						num = -1;
						this.<>1__state = num3;
					}
					List<IGrouping<stores, store_cats>> list = awaiter.GetResult().GroupBy(new Func<store_cats, stores>(AdditionalFieldEditViewModel.<>c.<>9.<LoadCategories>b__41_0)).ToList<IGrouping<stores, store_cats>>();
					int num4 = -1;
					List<IGrouping<stores, store_cats>>.Enumerator enumerator = list.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							IGrouping<stores, store_cats> grouping = enumerator.Current;
							this.<result>5__2.Add(new StoreCategory
							{
								Id = num4,
								Name = grouping.Key.name,
								IsExpand = true
							});
							List<store_cats>.Enumerator enumerator2 = grouping.Select(new Func<store_cats, store_cats>(AdditionalFieldEditViewModel.<>c.<>9.<LoadCategories>b__41_1)).OrderBy(new Func<store_cats, int?>(AdditionalFieldEditViewModel.<>c.<>9.<LoadCategories>b__41_2)).ToList<store_cats>().GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									store_cats store_cats = enumerator2.Current;
									if (store_cats.parent == null)
									{
										store_cats.parent = new int?(num4);
									}
									this.<result>5__2.Add(store_cats.ToStoreCategory());
								}
							}
							finally
							{
								if (num < 0)
								{
									((IDisposable)enumerator2).Dispose();
								}
							}
							num4--;
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)enumerator).Dispose();
						}
					}
					additionalFieldEditViewModel.Categories = this.<result>5__2;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<result>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<result>5__2 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060032E6 RID: 13030 RVA: 0x000AB29C File Offset: 0x000A949C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001D3B RID: 7483
			public int <>1__state;

			// Token: 0x04001D3C RID: 7484
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001D3D RID: 7485
			public AdditionalFieldEditViewModel <>4__this;

			// Token: 0x04001D3E RID: 7486
			private List<ICategory> <result>5__2;

			// Token: 0x04001D3F RID: 7487
			private TaskAwaiter<List<store_cats>> <>u__1;
		}

		// Token: 0x02000558 RID: 1368
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadDevices>d__42 : IAsyncStateMachine
		{
			// Token: 0x060032E7 RID: 13031 RVA: 0x000AB2B8 File Offset: 0x000A94B8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AdditionalFieldEditViewModel additionalFieldEditViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<IDevice>> awaiter;
					if (num != 0)
					{
						awaiter = additionalFieldEditViewModel._workshopService.GetActiveDevices().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<IDevice>>, AdditionalFieldEditViewModel.<LoadDevices>d__42>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<IDevice>>);
						this.<>1__state = -1;
					}
					IEnumerable<IDevice> result = awaiter.GetResult();
					additionalFieldEditViewModel.Devices = new List<IDevice>(result).Where(new Func<IDevice, bool>(AdditionalFieldEditViewModel.<>c.<>9.<LoadDevices>b__42_0)).ToList<IDevice>();
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

			// Token: 0x060032E8 RID: 13032 RVA: 0x000AB3AC File Offset: 0x000A95AC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001D40 RID: 7488
			public int <>1__state;

			// Token: 0x04001D41 RID: 7489
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001D42 RID: 7490
			public AdditionalFieldEditViewModel <>4__this;

			// Token: 0x04001D43 RID: 7491
			private TaskAwaiter<IEnumerable<IDevice>> <>u__1;
		}

		// Token: 0x02000559 RID: 1369
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Save>d__44 : IAsyncStateMachine
		{
			// Token: 0x060032E9 RID: 13033 RVA: 0x000AB3C8 File Offset: 0x000A95C8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AdditionalFieldEditViewModel additionalFieldEditViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						if (!additionalFieldEditViewModel.CheckAdditionalField())
						{
							goto IL_F0;
						}
						additionalFieldEditViewModel.Item.devices = additionalFieldEditViewModel.GetSelectedDevices();
						additionalFieldEditViewModel.Item.categories = additionalFieldEditViewModel.GetSelectedCategories();
					}
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = additionalFieldEditViewModel._additionalFieldsService.UpdateAdditionalField(additionalFieldEditViewModel.Item).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, AdditionalFieldEditViewModel.<Save>d__44>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							this.<>1__state = -1;
						}
						awaiter.GetResult();
					}
					catch (Exception ex)
					{
						additionalFieldEditViewModel._toasterService.Error(ex.Message);
						goto IL_F0;
					}
					additionalFieldEditViewModel.ClosePopup();
					additionalFieldEditViewModel.RefreshParent();
					additionalFieldEditViewModel.ShowActionResponse(true, "");
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_F0:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060032EA RID: 13034 RVA: 0x000AB4F4 File Offset: 0x000A96F4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001D44 RID: 7492
			public int <>1__state;

			// Token: 0x04001D45 RID: 7493
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001D46 RID: 7494
			public AdditionalFieldEditViewModel <>4__this;

			// Token: 0x04001D47 RID: 7495
			private TaskAwaiter <>u__1;
		}

		// Token: 0x0200055A RID: 1370
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Create>d__47 : IAsyncStateMachine
		{
			// Token: 0x060032EB RID: 13035 RVA: 0x000AB510 File Offset: 0x000A9710
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AdditionalFieldEditViewModel additionalFieldEditViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						if (!additionalFieldEditViewModel.CheckAdditionalField())
						{
							goto IL_115;
						}
						additionalFieldEditViewModel.Item.devices = additionalFieldEditViewModel.GetSelectedDevices();
						additionalFieldEditViewModel.Item.categories = additionalFieldEditViewModel.GetSelectedCategories();
					}
					try
					{
						TaskAwaiter<int> awaiter;
						if (num != 0)
						{
							this.<>7__wrap1 = additionalFieldEditViewModel.Item;
							awaiter = additionalFieldEditViewModel._additionalFieldsService.CreateAdditionalField(additionalFieldEditViewModel.Item).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, AdditionalFieldEditViewModel.<Create>d__47>(ref awaiter, ref this);
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
						this.<>7__wrap1.id = result;
						this.<>7__wrap1 = null;
					}
					catch (Exception ex)
					{
						additionalFieldEditViewModel._toasterService.Error(ex.Message);
						goto IL_115;
					}
					additionalFieldEditViewModel.ClosePopup();
					additionalFieldEditViewModel.RefreshParent();
					additionalFieldEditViewModel.ShowActionResponse(true, "");
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_115:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060032EC RID: 13036 RVA: 0x000AB664 File Offset: 0x000A9864
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001D48 RID: 7496
			public int <>1__state;

			// Token: 0x04001D49 RID: 7497
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001D4A RID: 7498
			public AdditionalFieldEditViewModel <>4__this;

			// Token: 0x04001D4B RID: 7499
			private fields <>7__wrap1;

			// Token: 0x04001D4C RID: 7500
			private TaskAwaiter<int> <>u__1;
		}
	}
}
