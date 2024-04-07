using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.ItemsArrival;
using ASC.ItemsCancellation;
using ASC.ItemsSale;
using ASC.Objects;
using ASC.PartsRequest;
using ASC.Services.Abstract;
using ASC.ViewModel;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Xpf.WindowsUI.Navigation;

namespace ASC.ViewModels.ItemCard
{
	// Token: 0x020004BD RID: 1213
	public class ProductDocumentsViewModel : CollectionViewModel<IItemOperation>, INavigationAware, IIsDataLoading
	{
		// Token: 0x06002EE4 RID: 12004 RVA: 0x0009967C File Offset: 0x0009787C
		public ProductDocumentsViewModel(IProductService productService, INavigationService navigationService, IWindowedDocumentService windowedDocumentService)
		{
			this.ProductService = productService;
			this._navigationService = navigationService;
			this._windowedDocumentService = windowedDocumentService;
		}

		// Token: 0x06002EE5 RID: 12005 RVA: 0x000996A4 File Offset: 0x000978A4
		protected virtual void LoadData()
		{
			ProductDocumentsViewModel.<LoadData>d__5 <LoadData>d__;
			<LoadData>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadData>d__.<>4__this = this;
			<LoadData>d__.<>1__state = -1;
			<LoadData>d__.<>t__builder.Start<ProductDocumentsViewModel.<LoadData>d__5>(ref <LoadData>d__);
		}

		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x06002EE6 RID: 12006 RVA: 0x000996DC File Offset: 0x000978DC
		// (set) Token: 0x06002EE7 RID: 12007 RVA: 0x000996F0 File Offset: 0x000978F0
		public bool IsLoadingData
		{
			[CompilerGenerated]
			get
			{
				return this.<IsLoadingData>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<IsLoadingData>k__BackingField == value)
				{
					return;
				}
				this.<IsLoadingData>k__BackingField = value;
				this.RaisePropertyChanged("IsLoadingData");
			}
		}

		// Token: 0x06002EE8 RID: 12008 RVA: 0x0009971C File Offset: 0x0009791C
		public void SetIsDataLoading(bool value)
		{
			this.IsLoadingData = value;
		}

		// Token: 0x06002EE9 RID: 12009 RVA: 0x00099730 File Offset: 0x00097930
		[Command]
		public void OpenReserve()
		{
			if (base.SelectedItem.Type == 0)
			{
				this._navigationService.Navigate("PartsRequestView", new PartsRequestViewModel(base.SelectedItem.Id));
			}
			if (base.SelectedItem.Type == 1)
			{
				this._navigationService.Navigate("ItemsSaleView", new ItemsSaleViewModel(base.SelectedItem.Id));
			}
			if (base.SelectedItem.Type == 2)
			{
				this._navigationService.Navigate("ItemsSaleView", new ItemsSaleViewModel(base.SelectedItem.Id));
			}
			if (base.SelectedItem.Type == 3)
			{
				this._navigationService.Navigate("InItems", new ItemsArrivalViewModel(base.SelectedItem.Id));
			}
			if (base.SelectedItem.Type == 4)
			{
				this._windowedDocumentService.ShowNewDocument("ItemsCancellationView", new ItemsCancellationViewModel(base.SelectedItem.Id), null, null);
			}
			if (base.SelectedItem.Type == 5)
			{
				ProductsMoveViewModel productsMoveViewModel = Bootstrapper.Container.Resolve<ProductsMoveViewModel>();
				productsMoveViewModel.SetDocumentId(base.SelectedItem.Id);
				this._navigationService.Navigate("ProductsMoveView", productsMoveViewModel);
			}
		}

		// Token: 0x06002EEA RID: 12010 RVA: 0x00099868 File Offset: 0x00097A68
		public bool CanOpenReserve()
		{
			return base.SelectedItem != null;
		}

		// Token: 0x06002EEB RID: 12011 RVA: 0x00099880 File Offset: 0x00097A80
		public void NavigatedTo(NavigationEventArgs e)
		{
			this.ProductId = (int)e.Parameter;
			this.LoadData();
		}

		// Token: 0x06002EEC RID: 12012 RVA: 0x00023150 File Offset: 0x00021350
		public void NavigatingFrom(NavigatingEventArgs e)
		{
		}

		// Token: 0x06002EED RID: 12013 RVA: 0x00023150 File Offset: 0x00021350
		public void NavigatedFrom(NavigationEventArgs e)
		{
		}

		// Token: 0x06002EEE RID: 12014 RVA: 0x000998A4 File Offset: 0x00097AA4
		[CompilerGenerated]
		private Task<List<ItemOperation>> <LoadData>b__5_0()
		{
			return this.ProductService.GetDocuments(this.ProductId);
		}

		// Token: 0x04001A70 RID: 6768
		protected int ProductId;

		// Token: 0x04001A71 RID: 6769
		protected IProductService ProductService;

		// Token: 0x04001A72 RID: 6770
		private readonly INavigationService _navigationService;

		// Token: 0x04001A73 RID: 6771
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04001A74 RID: 6772
		[CompilerGenerated]
		private bool <IsLoadingData>k__BackingField;

		// Token: 0x020004BE RID: 1214
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadData>d__5 : IAsyncStateMachine
		{
			// Token: 0x06002EEF RID: 12015 RVA: 0x000998C4 File Offset: 0x00097AC4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ProductDocumentsViewModel productDocumentsViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<ItemOperation>> awaiter;
					if (num != 0)
					{
						productDocumentsViewModel.SetIsDataLoading(true);
						awaiter = Task.Run<List<ItemOperation>>(() => productDocumentsViewModel.ProductService.GetDocuments(productDocumentsViewModel.ProductId)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<ItemOperation>>, ProductDocumentsViewModel.<LoadData>d__5>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<ItemOperation>>);
						this.<>1__state = -1;
					}
					List<ItemOperation> result = awaiter.GetResult();
					productDocumentsViewModel.SetItems(result);
					productDocumentsViewModel.SetIsDataLoading(false);
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

			// Token: 0x06002EF0 RID: 12016 RVA: 0x0009999C File Offset: 0x00097B9C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001A75 RID: 6773
			public int <>1__state;

			// Token: 0x04001A76 RID: 6774
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001A77 RID: 6775
			public ProductDocumentsViewModel <>4__this;

			// Token: 0x04001A78 RID: 6776
			private TaskAwaiter<List<ItemOperation>> <>u__1;
		}
	}
}
