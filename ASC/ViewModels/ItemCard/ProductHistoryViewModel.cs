using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Interfaces;
using ASC.Services.Abstract;
using DevExpress.Xpf.WindowsUI.Navigation;

namespace ASC.ViewModels.ItemCard
{
	// Token: 0x020004C5 RID: 1221
	public class ProductHistoryViewModel : CollectionViewModel<logs>, INavigationAware, IIsDataLoading
	{
		// Token: 0x06002F2A RID: 12074 RVA: 0x0009AA8C File Offset: 0x00098C8C
		public ProductHistoryViewModel(IProductService productService)
		{
			this.ProductService = productService;
		}

		// Token: 0x06002F2B RID: 12075 RVA: 0x0009AAA8 File Offset: 0x00098CA8
		public void LoadData()
		{
			ProductHistoryViewModel.<LoadData>d__3 <LoadData>d__;
			<LoadData>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadData>d__.<>4__this = this;
			<LoadData>d__.<>1__state = -1;
			<LoadData>d__.<>t__builder.Start<ProductHistoryViewModel.<LoadData>d__3>(ref <LoadData>d__);
		}

		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x06002F2C RID: 12076 RVA: 0x0009AAE0 File Offset: 0x00098CE0
		// (set) Token: 0x06002F2D RID: 12077 RVA: 0x0009AAF4 File Offset: 0x00098CF4
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

		// Token: 0x06002F2E RID: 12078 RVA: 0x0009AB20 File Offset: 0x00098D20
		public void SetIsDataLoading(bool value)
		{
			this.IsLoadingData = value;
		}

		// Token: 0x06002F2F RID: 12079 RVA: 0x0009AB34 File Offset: 0x00098D34
		public void NavigatedTo(NavigationEventArgs e)
		{
			this.ProductId = (int)e.Parameter;
			this.LoadData();
		}

		// Token: 0x06002F30 RID: 12080 RVA: 0x00023150 File Offset: 0x00021350
		public void NavigatingFrom(NavigatingEventArgs e)
		{
		}

		// Token: 0x06002F31 RID: 12081 RVA: 0x00023150 File Offset: 0x00021350
		public void NavigatedFrom(NavigationEventArgs e)
		{
		}

		// Token: 0x06002F32 RID: 12082 RVA: 0x0009AB58 File Offset: 0x00098D58
		[CompilerGenerated]
		private Task<List<logs>> <LoadData>b__3_0()
		{
			return this.ProductService.GetHistory(this.ProductId);
		}

		// Token: 0x04001AAC RID: 6828
		protected int ProductId;

		// Token: 0x04001AAD RID: 6829
		protected IProductService ProductService;

		// Token: 0x04001AAE RID: 6830
		[CompilerGenerated]
		private bool <IsLoadingData>k__BackingField;

		// Token: 0x020004C6 RID: 1222
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadData>d__3 : IAsyncStateMachine
		{
			// Token: 0x06002F33 RID: 12083 RVA: 0x0009AB78 File Offset: 0x00098D78
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ProductHistoryViewModel productHistoryViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<logs>> awaiter;
					if (num != 0)
					{
						productHistoryViewModel.SetIsDataLoading(true);
						awaiter = Task.Run<List<logs>>(() => productHistoryViewModel.ProductService.GetHistory(productHistoryViewModel.ProductId)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<logs>>, ProductHistoryViewModel.<LoadData>d__3>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<logs>>);
						this.<>1__state = -1;
					}
					List<logs> result = awaiter.GetResult();
					productHistoryViewModel.SetItems(result);
					productHistoryViewModel.SetIsDataLoading(false);
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

			// Token: 0x06002F34 RID: 12084 RVA: 0x0009AC50 File Offset: 0x00098E50
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001AAF RID: 6831
			public int <>1__state;

			// Token: 0x04001AB0 RID: 6832
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001AB1 RID: 6833
			public ProductHistoryViewModel <>4__this;

			// Token: 0x04001AB2 RID: 6834
			private TaskAwaiter<List<logs>> <>u__1;
		}
	}
}
