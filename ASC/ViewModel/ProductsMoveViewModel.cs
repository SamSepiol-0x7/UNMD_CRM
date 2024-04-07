using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Objects.Reports;
using ASC.Options;
using ASC.Services.Abstract;
using ASC.ViewModels;
using ASC.ViewModels.Controls;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.Native;
using DevExpress.XtraReports.UI;

namespace ASC.ViewModel
{
	// Token: 0x020002B2 RID: 690
	public class ProductsMoveViewModel : BaseViewModel, IIdCallback, IStoreSelect, IItemsSelect
	{
		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x06002331 RID: 9009 RVA: 0x00067A44 File Offset: 0x00065C44
		// (set) Token: 0x06002332 RID: 9010 RVA: 0x00067A58 File Offset: 0x00065C58
		public GoodsMoveDocument Document
		{
			[CompilerGenerated]
			get
			{
				return this.<Document>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Document>k__BackingField, value))
				{
					return;
				}
				this.<Document>k__BackingField = value;
				this.RaisePropertyChanged("Document");
			}
		}

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x06002333 RID: 9011 RVA: 0x00067A88 File Offset: 0x00065C88
		// (set) Token: 0x06002334 RID: 9012 RVA: 0x00067A9C File Offset: 0x00065C9C
		public store_items SelectedItem
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

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x06002335 RID: 9013 RVA: 0x00067ACC File Offset: 0x00065CCC
		// (set) Token: 0x06002336 RID: 9014 RVA: 0x00067AE0 File Offset: 0x00065CE0
		public List<store_cats> Categories
		{
			[CompilerGenerated]
			get
			{
				return this.<Categories>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Categories>k__BackingField, value))
				{
					return;
				}
				this.<Categories>k__BackingField = value;
				this.RaisePropertyChanged("Categories");
			}
		}

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x06002337 RID: 9015 RVA: 0x00067B10 File Offset: 0x00065D10
		// (set) Token: 0x06002338 RID: 9016 RVA: 0x00067B24 File Offset: 0x00065D24
		public bool PrintDocument
		{
			[CompilerGenerated]
			get
			{
				return this.<PrintDocument>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PrintDocument>k__BackingField == value)
				{
					return;
				}
				this.<PrintDocument>k__BackingField = value;
				this.RaisePropertyChanged("PrintDocument");
			}
		}

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x06002339 RID: 9017 RVA: 0x00067B50 File Offset: 0x00065D50
		// (set) Token: 0x0600233A RID: 9018 RVA: 0x00067B94 File Offset: 0x00065D94
		public int? CategoryForAll
		{
			get
			{
				return base.GetProperty<int?>(() => this.CategoryForAll);
			}
			set
			{
				if (Nullable.Equals<int>(this.CategoryForAll, value))
				{
					return;
				}
				base.SetProperty<int?>(() => this.CategoryForAll, value, new Action(this.OnCategoryForAllChanged));
				this.RaisePropertyChanged("CategoryForAll");
			}
		}

		// Token: 0x0600233B RID: 9019 RVA: 0x00067C00 File Offset: 0x00065E00
		public ProductsMoveViewModel(IStoreService storeService, INavigationService navigationService, IToasterService toasterService, IWindowedDocumentService windowedDocumentService, IReportPrintService reportPrintService)
		{
			this.SetViewName("ItemsMovement");
			this._storeService = storeService;
			this._navigationService = navigationService;
			this._toasterService = toasterService;
			this._windowedDocumentService = windowedDocumentService;
			this._reportPrintService = reportPrintService;
			this.Document = DocumentsModel.DefaultMoveDocument();
			this.Document.CompanyId = OfflineData.Instance.Employee.Office.DefaultCompanyId;
			this.PrintDocument = true;
		}

		// Token: 0x0600233C RID: 9020 RVA: 0x00067C74 File Offset: 0x00065E74
		private void LoadDocument(int documentId)
		{
			ProductsMoveViewModel.<LoadDocument>d__27 <LoadDocument>d__;
			<LoadDocument>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadDocument>d__.<>4__this = this;
			<LoadDocument>d__.documentId = documentId;
			<LoadDocument>d__.<>1__state = -1;
			<LoadDocument>d__.<>t__builder.Start<ProductsMoveViewModel.<LoadDocument>d__27>(ref <LoadDocument>d__);
		}

		// Token: 0x0600233D RID: 9021 RVA: 0x00067CB4 File Offset: 0x00065EB4
		protected override void OnParentViewModelChanged(object parentViewModel)
		{
			this._parentViewModel = (parentViewModel as IRefreshable);
		}

		// Token: 0x0600233E RID: 9022 RVA: 0x00067CD0 File Offset: 0x00065ED0
		public void SetStore(int storeId)
		{
			ProductsMoveViewModel.<SetStore>d__29 <SetStore>d__;
			<SetStore>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SetStore>d__.<>4__this = this;
			<SetStore>d__.storeId = storeId;
			<SetStore>d__.<>1__state = -1;
			<SetStore>d__.<>t__builder.Start<ProductsMoveViewModel.<SetStore>d__29>(ref <SetStore>d__);
		}

		// Token: 0x0600233F RID: 9023 RVA: 0x00067D10 File Offset: 0x00065F10
		private bool IsDuplicateItem(int itemId)
		{
			return this.Document.Items.Any((store_items i) => i.id == itemId);
		}

		// Token: 0x06002340 RID: 9024 RVA: 0x00067D48 File Offset: 0x00065F48
		public void LoadAndAddItem(int itemId)
		{
			ProductsMoveViewModel.<LoadAndAddItem>d__31 <LoadAndAddItem>d__;
			<LoadAndAddItem>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadAndAddItem>d__.<>4__this = this;
			<LoadAndAddItem>d__.itemId = itemId;
			<LoadAndAddItem>d__.<>1__state = -1;
			<LoadAndAddItem>d__.<>t__builder.Start<ProductsMoveViewModel.<LoadAndAddItem>d__31>(ref <LoadAndAddItem>d__);
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x00067D88 File Offset: 0x00065F88
		[Command]
		public void AddItem()
		{
			this._navigationService.NavigateToStore(true, ItemsOptions.opName.inStock4Sale, this);
		}

		// Token: 0x06002342 RID: 9026 RVA: 0x00067DA4 File Offset: 0x00065FA4
		public bool CanAddItem()
		{
			if (this.Document != null && this.Document.Id == 0)
			{
				int? storeId = this.Document.StoreId;
				return storeId.GetValueOrDefault() > 0 & storeId != null;
			}
			return false;
		}

		// Token: 0x06002343 RID: 9027 RVA: 0x00067DE8 File Offset: 0x00065FE8
		[Command]
		public void ItemsMoveDispatch()
		{
			ProductsMoveViewModel.<ItemsMoveDispatch>d__34 <ItemsMoveDispatch>d__;
			<ItemsMoveDispatch>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<ItemsMoveDispatch>d__.<>4__this = this;
			<ItemsMoveDispatch>d__.<>1__state = -1;
			<ItemsMoveDispatch>d__.<>t__builder.Start<ProductsMoveViewModel.<ItemsMoveDispatch>d__34>(ref <ItemsMoveDispatch>d__);
		}

		// Token: 0x06002344 RID: 9028 RVA: 0x00067E20 File Offset: 0x00066020
		public bool CanItemsMoveDispatch()
		{
			return this.Document != null && this.Document.Id == 0 && this.Document.Items.Any<store_items>();
		}

		// Token: 0x06002345 RID: 9029 RVA: 0x00067E54 File Offset: 0x00066054
		[Command]
		public void ItemsMoveArrived()
		{
			if (this.Document.DestinationPay && this.Document.CashOrderId == null)
			{
				MoneyMoveViewModel moneyMoveViewModel = Bootstrapper.Container.Resolve<MoneyMoveViewModel>();
				moneyMoveViewModel.Move.SourceCompany = this.Document.DestinationOffice.DefaultCompanyId;
				moneyMoveViewModel.Move.DestinationCompany = this.Document.CompanyId;
				moneyMoveViewModel.Move.DestinationOffice = this.Document.OfficeId;
				moneyMoveViewModel.Move.SourceOffice = this.Document.DestinationOffice.Id;
				moneyMoveViewModel.Move.Summ = this.Document.Total;
				this._windowedDocumentService.ShowNewDocument("MoneyMoveView", moneyMoveViewModel, null, null);
				return;
			}
			this.Arrived();
		}

		// Token: 0x06002346 RID: 9030 RVA: 0x00067F28 File Offset: 0x00066128
		public bool CanItemsMoveArrived()
		{
			if (this.Document != null && this.Document.Id > 0)
			{
				if (this.Document.Status == DocStates.Reserve)
				{
					if (this.Document.DestinationStore != null)
					{
						if (this.Document.DestinationStore.office != null)
						{
							int? office = this.Document.DestinationStore.office;
							int officeId = OfflineData.Instance.Employee.OfficeId;
							if (!(office.GetValueOrDefault() == officeId & office != null))
							{
								return OfflineData.Instance.Employee.Can(1, 0);
							}
						}
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06002347 RID: 9031 RVA: 0x00067FD4 File Offset: 0x000661D4
		private void Arrived()
		{
			ProductsMoveViewModel.<Arrived>d__38 <Arrived>d__;
			<Arrived>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Arrived>d__.<>4__this = this;
			<Arrived>d__.<>1__state = -1;
			<Arrived>d__.<>t__builder.Start<ProductsMoveViewModel.<Arrived>d__38>(ref <Arrived>d__);
		}

		// Token: 0x06002348 RID: 9032 RVA: 0x0006800C File Offset: 0x0006620C
		public void SetId(int value)
		{
			ProductsMoveViewModel.<SetId>d__39 <SetId>d__;
			<SetId>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SetId>d__.<>4__this = this;
			<SetId>d__.value = value;
			<SetId>d__.<>1__state = -1;
			<SetId>d__.<>t__builder.Start<ProductsMoveViewModel.<SetId>d__39>(ref <SetId>d__);
		}

		// Token: 0x06002349 RID: 9033 RVA: 0x0006804C File Offset: 0x0006624C
		[Command]
		public void RemoveItem()
		{
			this.Document.RemoveItem(this.SelectedItem);
		}

		// Token: 0x0600234A RID: 9034 RVA: 0x0006806C File Offset: 0x0006626C
		public bool CanRemoveItem()
		{
			return this.Document != null && this.Document.Id == 0 && this.SelectedItem != null;
		}

		// Token: 0x0600234B RID: 9035 RVA: 0x0006809C File Offset: 0x0006629C
		[Command]
		public void Print()
		{
			ProductsMoveViewModel.<Print>d__42 <Print>d__;
			<Print>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Print>d__.<>4__this = this;
			<Print>d__.<>1__state = -1;
			<Print>d__.<>t__builder.Start<ProductsMoveViewModel.<Print>d__42>(ref <Print>d__);
		}

		// Token: 0x0600234C RID: 9036 RVA: 0x000680D4 File Offset: 0x000662D4
		public bool CanPrint()
		{
			return this.Document != null && this.Document.Id > 0;
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x000680FC File Offset: 0x000662FC
		public void SetDocumentId(int value)
		{
			this._documentId = value;
		}

		// Token: 0x0600234E RID: 9038 RVA: 0x00068110 File Offset: 0x00066310
		public override void OnLoad()
		{
			base.OnLoad();
			if (this._documentId > 0)
			{
				this.SetViewName("MoveN", this._documentId);
				this.LoadDocument(this._documentId);
			}
		}

		// Token: 0x0600234F RID: 9039 RVA: 0x0006814C File Offset: 0x0006634C
		public void AddItemsFromStore(List<Product> items, Product selectedItem)
		{
			if (items.Count > 0)
			{
				foreach (Product product in items)
				{
					this.LoadAndAddItem(product.Id);
				}
				return;
			}
			if (selectedItem != null)
			{
				this.LoadAndAddItem(selectedItem.Id);
			}
		}

		// Token: 0x06002350 RID: 9040 RVA: 0x000681BC File Offset: 0x000663BC
		private void OnCategoryForAllChanged()
		{
			int? categoryForAll = this.CategoryForAll;
			if (categoryForAll.GetValueOrDefault() > 0 & categoryForAll != null)
			{
				this.Document.Items.ForEach(delegate(store_items p)
				{
					p.category = this.CategoryForAll.Value;
				});
			}
		}

		// Token: 0x06002351 RID: 9041 RVA: 0x00068200 File Offset: 0x00066400
		[Command]
		public void ItemDoubleClick()
		{
			ItemCardViewModel itemCardViewModel = Bootstrapper.Container.Resolve<ItemCardViewModel>();
			itemCardViewModel.SetProductId(this.SelectedItem.id);
			this._navigationService.Navigate("ItemCardView", itemCardViewModel);
		}

		// Token: 0x06002352 RID: 9042 RVA: 0x0006823C File Offset: 0x0006643C
		public bool CanItemDoubleClick()
		{
			GoodsMoveDocument document = this.Document;
			return document != null && document.Id > 0 && this.SelectedItem != null && this.SelectedItem.id > 0;
		}

		// Token: 0x06002353 RID: 9043 RVA: 0x00068278 File Offset: 0x00066478
		[CompilerGenerated]
		private XtraReport <Print>b__42_0()
		{
			return this.Document.CreateReport();
		}

		// Token: 0x06002354 RID: 9044 RVA: 0x00068290 File Offset: 0x00066490
		[CompilerGenerated]
		private void <OnCategoryForAllChanged>b__47_0(store_items p)
		{
			p.category = this.CategoryForAll.Value;
		}

		// Token: 0x0400123E RID: 4670
		private readonly IStoreService _storeService;

		// Token: 0x0400123F RID: 4671
		private IRefreshable _parentViewModel;

		// Token: 0x04001240 RID: 4672
		private readonly INavigationService _navigationService;

		// Token: 0x04001241 RID: 4673
		private readonly IToasterService _toasterService;

		// Token: 0x04001242 RID: 4674
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04001243 RID: 4675
		private readonly IReportPrintService _reportPrintService;

		// Token: 0x04001244 RID: 4676
		private int _documentId;

		// Token: 0x04001245 RID: 4677
		[CompilerGenerated]
		private GoodsMoveDocument <Document>k__BackingField;

		// Token: 0x04001246 RID: 4678
		[CompilerGenerated]
		private store_items <SelectedItem>k__BackingField;

		// Token: 0x04001247 RID: 4679
		[CompilerGenerated]
		private List<store_cats> <Categories>k__BackingField;

		// Token: 0x04001248 RID: 4680
		[CompilerGenerated]
		private bool <PrintDocument>k__BackingField;

		// Token: 0x020002B3 RID: 691
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadDocument>d__27 : IAsyncStateMachine
		{
			// Token: 0x06002355 RID: 9045 RVA: 0x000682B4 File Offset: 0x000664B4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ProductsMoveViewModel productsMoveViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<GoodsMoveDocument> awaiter;
					if (num != 0)
					{
						productsMoveViewModel.ShowWait();
						awaiter = productsMoveViewModel._storeService.GetProductsMoveDocument(this.documentId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<GoodsMoveDocument>, ProductsMoveViewModel.<LoadDocument>d__27>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<GoodsMoveDocument>);
						this.<>1__state = -1;
					}
					GoodsMoveDocument result = awaiter.GetResult();
					productsMoveViewModel.Document = result;
					productsMoveViewModel.RaiseCanExecuteChanged(() => productsMoveViewModel.ItemsMoveDispatch());
					productsMoveViewModel.RaiseCanExecuteChanged(() => productsMoveViewModel.AddItem());
					productsMoveViewModel.RaiseCanExecuteChanged(() => productsMoveViewModel.Print());
					productsMoveViewModel.HideWait();
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

			// Token: 0x06002356 RID: 9046 RVA: 0x00068448 File Offset: 0x00066648
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001249 RID: 4681
			public int <>1__state;

			// Token: 0x0400124A RID: 4682
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400124B RID: 4683
			public ProductsMoveViewModel <>4__this;

			// Token: 0x0400124C RID: 4684
			public int documentId;

			// Token: 0x0400124D RID: 4685
			private TaskAwaiter<GoodsMoveDocument> <>u__1;
		}

		// Token: 0x020002B4 RID: 692
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SetStore>d__29 : IAsyncStateMachine
		{
			// Token: 0x06002357 RID: 9047 RVA: 0x00068464 File Offset: 0x00066664
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ProductsMoveViewModel productsMoveViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<store_cats>> awaiter;
					if (num != 0)
					{
						if (this.storeId > 0)
						{
							productsMoveViewModel.Document.StoreId = new int?(this.storeId);
							goto IL_DF;
						}
						productsMoveViewModel.Document.ToStoreId = new int?(Math.Abs(this.storeId));
						awaiter = productsMoveViewModel._storeService.GetCategoriesAsync(productsMoveViewModel.Document.ToStoreId.Value).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_cats>>, ProductsMoveViewModel.<SetStore>d__29>(ref awaiter, ref this);
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
					productsMoveViewModel.Categories = result;
					productsMoveViewModel.CategoryForAll = null;
					IL_DF:
					int? toStoreId = productsMoveViewModel.Document.ToStoreId;
					if (toStoreId.GetValueOrDefault() > 0 & toStoreId != null)
					{
						productsMoveViewModel.Document.LoadToStore();
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

			// Token: 0x06002358 RID: 9048 RVA: 0x000685BC File Offset: 0x000667BC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400124E RID: 4686
			public int <>1__state;

			// Token: 0x0400124F RID: 4687
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001250 RID: 4688
			public int storeId;

			// Token: 0x04001251 RID: 4689
			public ProductsMoveViewModel <>4__this;

			// Token: 0x04001252 RID: 4690
			private TaskAwaiter<List<store_cats>> <>u__1;
		}

		// Token: 0x020002B5 RID: 693
		[CompilerGenerated]
		private sealed class <>c__DisplayClass30_0
		{
			// Token: 0x06002359 RID: 9049 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass30_0()
			{
			}

			// Token: 0x0600235A RID: 9050 RVA: 0x000685D8 File Offset: 0x000667D8
			internal bool <IsDuplicateItem>b__0(store_items i)
			{
				return i.id == this.itemId;
			}

			// Token: 0x04001253 RID: 4691
			public int itemId;
		}

		// Token: 0x020002B6 RID: 694
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadAndAddItem>d__31 : IAsyncStateMachine
		{
			// Token: 0x0600235B RID: 9051 RVA: 0x000685F4 File Offset: 0x000667F4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ProductsMoveViewModel productsMoveViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<store_items> awaiter;
					if (num != 0)
					{
						if (productsMoveViewModel.IsDuplicateItem(this.itemId))
						{
							productsMoveViewModel._toasterService.Info(Lang.t("ItemAlreadyInList"));
							goto IL_122;
						}
						productsMoveViewModel.ShowWait();
						awaiter = productsMoveViewModel._storeService.GetProduct(this.itemId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<store_items>, ProductsMoveViewModel.<LoadAndAddItem>d__31>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<store_items>);
						this.<>1__state = -1;
					}
					store_items result = awaiter.GetResult();
					result.BuyCost = result.price2;
					result.category = 0;
					productsMoveViewModel.Document.AddItem(result);
					int store = result.store;
					int? storeId = productsMoveViewModel.Document.StoreId;
					if (!(store == storeId.GetValueOrDefault() & storeId != null))
					{
						productsMoveViewModel.Document.StoreId = new int?(result.store);
					}
					productsMoveViewModel.HideWait();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_122:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x0600235C RID: 9052 RVA: 0x00068748 File Offset: 0x00066948
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001254 RID: 4692
			public int <>1__state;

			// Token: 0x04001255 RID: 4693
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001256 RID: 4694
			public ProductsMoveViewModel <>4__this;

			// Token: 0x04001257 RID: 4695
			public int itemId;

			// Token: 0x04001258 RID: 4696
			private TaskAwaiter<store_items> <>u__1;
		}

		// Token: 0x020002B7 RID: 695
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ItemsMoveDispatch>d__34 : IAsyncStateMachine
		{
			// Token: 0x0600235D RID: 9053 RVA: 0x00068764 File Offset: 0x00066964
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ProductsMoveViewModel productsMoveViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<int> awaiter;
					if (num != 0)
					{
						string text = productsMoveViewModel.Document.CheckFields();
						if (!string.IsNullOrEmpty(text))
						{
							productsMoveViewModel._toasterService.Error(Lang.t(text));
							goto IL_126;
						}
						productsMoveViewModel.ShowWait();
						this.<>7__wrap1 = productsMoveViewModel.Document;
						awaiter = productsMoveViewModel._storeService.ItemsMoveDispatch(productsMoveViewModel.Document).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, ProductsMoveViewModel.<ItemsMoveDispatch>d__34>(ref awaiter, ref this);
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
					this.<>7__wrap1.Id = result;
					this.<>7__wrap1 = null;
					productsMoveViewModel.HideWait();
					productsMoveViewModel.ShowActionResponse(productsMoveViewModel.Document.Id > 0, "");
					productsMoveViewModel.LoadDocument(productsMoveViewModel.Document.Id);
					if (productsMoveViewModel.PrintDocument)
					{
						productsMoveViewModel.Print();
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_126:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x0600235E RID: 9054 RVA: 0x000688BC File Offset: 0x00066ABC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001259 RID: 4697
			public int <>1__state;

			// Token: 0x0400125A RID: 4698
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400125B RID: 4699
			public ProductsMoveViewModel <>4__this;

			// Token: 0x0400125C RID: 4700
			private GoodsMoveDocument <>7__wrap1;

			// Token: 0x0400125D RID: 4701
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x020002B8 RID: 696
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Arrived>d__38 : IAsyncStateMachine
		{
			// Token: 0x0600235F RID: 9055 RVA: 0x000688D8 File Offset: 0x00066AD8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ProductsMoveViewModel productsMoveViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						productsMoveViewModel.ShowWait();
						awaiter = productsMoveViewModel._storeService.ItemsMoveArrived(productsMoveViewModel.Document.Id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, ProductsMoveViewModel.<Arrived>d__38>(ref awaiter, ref this);
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
					productsMoveViewModel.HideWait();
					productsMoveViewModel.ShowActionResponse(result, "");
					productsMoveViewModel.LoadDocument(productsMoveViewModel.Document.Id);
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

			// Token: 0x06002360 RID: 9056 RVA: 0x000689C8 File Offset: 0x00066BC8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400125E RID: 4702
			public int <>1__state;

			// Token: 0x0400125F RID: 4703
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001260 RID: 4704
			public ProductsMoveViewModel <>4__this;

			// Token: 0x04001261 RID: 4705
			private TaskAwaiter<bool> <>u__1;
		}

		// Token: 0x020002B9 RID: 697
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SetId>d__39 : IAsyncStateMachine
		{
			// Token: 0x06002361 RID: 9057 RVA: 0x000689E4 File Offset: 0x00066BE4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ProductsMoveViewModel productsMoveViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = productsMoveViewModel._storeService.SetDocumentCashOrder(productsMoveViewModel.Document.Id, this.value).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ProductsMoveViewModel.<SetId>d__39>(ref awaiter, ref this);
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
					productsMoveViewModel.Document.CashOrderId = new int?(this.value);
					productsMoveViewModel.Arrived();
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

			// Token: 0x06002362 RID: 9058 RVA: 0x00068AC8 File Offset: 0x00066CC8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001262 RID: 4706
			public int <>1__state;

			// Token: 0x04001263 RID: 4707
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001264 RID: 4708
			public ProductsMoveViewModel <>4__this;

			// Token: 0x04001265 RID: 4709
			public int value;

			// Token: 0x04001266 RID: 4710
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020002BA RID: 698
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Print>d__42 : IAsyncStateMachine
		{
			// Token: 0x06002363 RID: 9059 RVA: 0x00068AE4 File Offset: 0x00066CE4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ProductsMoveViewModel productsMoveViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<XtraReport> awaiter;
					if (num != 0)
					{
						productsMoveViewModel.ShowWait();
						awaiter = Task.Run<XtraReport>(() => base.Document.CreateReport()).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XtraReport>, ProductsMoveViewModel.<Print>d__42>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<XtraReport>);
						this.<>1__state = -1;
					}
					XtraReport result = awaiter.GetResult();
					productsMoveViewModel.HideWait();
					productsMoveViewModel._reportPrintService.PrintPreview(result, PrinterModel.Printer.Documents);
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

			// Token: 0x06002364 RID: 9060 RVA: 0x00068BC0 File Offset: 0x00066DC0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001267 RID: 4711
			public int <>1__state;

			// Token: 0x04001268 RID: 4712
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001269 RID: 4713
			public ProductsMoveViewModel <>4__this;

			// Token: 0x0400126A RID: 4714
			private TaskAwaiter<XtraReport> <>u__1;
		}
	}
}
