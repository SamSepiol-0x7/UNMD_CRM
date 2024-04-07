using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Objects;
using ASC.Interfaces;
using ASC.Objects;
using ASC.Options;
using ASC.Services.Abstract;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Xpf.WindowsUI.Navigation;
using Microsoft.Win32;

namespace ASC.ViewModels.ItemCard
{
	// Token: 0x020004C7 RID: 1223
	public class ProductOverviewViewModel : BaseViewModel, INavigationAware, IIsDataLoading
	{
		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x06002F35 RID: 12085 RVA: 0x0009AC6C File Offset: 0x00098E6C
		// (set) Token: 0x06002F36 RID: 12086 RVA: 0x0009AC80 File Offset: 0x00098E80
		public store_items Item
		{
			[CompilerGenerated]
			get
			{
				return this.<Item>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Item>k__BackingField, value))
				{
					return;
				}
				this.<Item>k__BackingField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		// Token: 0x17000ED1 RID: 3793
		// (get) Token: 0x06002F37 RID: 12087 RVA: 0x0009ACB0 File Offset: 0x00098EB0
		// (set) Token: 0x06002F38 RID: 12088 RVA: 0x0009ACC4 File Offset: 0x00098EC4
		public ObservableCollection<images> Images
		{
			[CompilerGenerated]
			get
			{
				return this.<Images>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Images>k__BackingField, value))
				{
					return;
				}
				this.<Images>k__BackingField = value;
				this.RaisePropertyChanged("Images");
			}
		}

		// Token: 0x17000ED2 RID: 3794
		// (get) Token: 0x06002F39 RID: 12089 RVA: 0x0009ACF4 File Offset: 0x00098EF4
		// (set) Token: 0x06002F3A RID: 12090 RVA: 0x0009AD08 File Offset: 0x00098F08
		public List<store_cats> StoreCategories
		{
			[CompilerGenerated]
			get
			{
				return this.<StoreCategories>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<StoreCategories>k__BackingField, value))
				{
					return;
				}
				this.<StoreCategories>k__BackingField = value;
				this.RaisePropertyChanged("StoreCategories");
			}
		}

		// Token: 0x17000ED3 RID: 3795
		// (get) Token: 0x06002F3B RID: 12091 RVA: 0x0009AD38 File Offset: 0x00098F38
		// (set) Token: 0x06002F3C RID: 12092 RVA: 0x0009AD4C File Offset: 0x00098F4C
		public List<ItemUnits> Units
		{
			[CompilerGenerated]
			get
			{
				return this.<Units>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Units>k__BackingField, value))
				{
					return;
				}
				this.<Units>k__BackingField = value;
				this.RaisePropertyChanged("Units");
			}
		}

		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x06002F3D RID: 12093 RVA: 0x0009AD7C File Offset: 0x00098F7C
		// (set) Token: 0x06002F3E RID: 12094 RVA: 0x0009AD90 File Offset: 0x00098F90
		public IProductAttributesViewModel ProductAttributesVM
		{
			[CompilerGenerated]
			get
			{
				return this.<ProductAttributesVM>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ProductAttributesVM>k__BackingField, value))
				{
					return;
				}
				this.<ProductAttributesVM>k__BackingField = value;
				this.RaisePropertyChanged("ProductAttributesVM");
			}
		}

		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x06002F3F RID: 12095 RVA: 0x0009ADC0 File Offset: 0x00098FC0
		// (set) Token: 0x06002F40 RID: 12096 RVA: 0x0009ADD4 File Offset: 0x00098FD4
		public decimal CurrentRate
		{
			[CompilerGenerated]
			get
			{
				return this.<CurrentRate>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<CurrentRate>k__BackingField, value))
				{
					return;
				}
				this.<CurrentRate>k__BackingField = value;
				this.RaisePropertyChanged("CurrentRate");
			}
		}

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x06002F41 RID: 12097 RVA: 0x0009AE04 File Offset: 0x00099004
		// (set) Token: 0x06002F42 RID: 12098 RVA: 0x0009AE18 File Offset: 0x00099018
		public bool IsCurrencyBinding
		{
			[CompilerGenerated]
			get
			{
				return this.<IsCurrencyBinding>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IsCurrencyBinding>k__BackingField == value)
				{
					return;
				}
				this.<IsCurrencyBinding>k__BackingField = value;
				this.RaisePropertyChanged("IsCurrencyBinding");
			}
		}

		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x06002F43 RID: 12099 RVA: 0x000977AC File Offset: 0x000959AC
		public bool CanEdit
		{
			get
			{
				return OfflineData.Instance.Employee.Can(21, 0);
			}
		}

		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x06002F44 RID: 12100 RVA: 0x0009AE44 File Offset: 0x00099044
		// (set) Token: 0x06002F45 RID: 12101 RVA: 0x0009AE58 File Offset: 0x00099058
		public List<Warranty> WarrantyOptionses
		{
			[CompilerGenerated]
			get
			{
				return this.<WarrantyOptionses>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<WarrantyOptionses>k__BackingField, value))
				{
					return;
				}
				this.<WarrantyOptionses>k__BackingField = value;
				this.RaisePropertyChanged("WarrantyOptionses");
			}
		}

		// Token: 0x06002F46 RID: 12102 RVA: 0x0009AE88 File Offset: 0x00099088
		public ProductOverviewViewModel(IProductService productService, IStoreService storeService, IProductAttributesViewModel productAttributesViewModel, IToasterService toasterService)
		{
			this.ProductService = productService;
			this.StoreService = storeService;
			this._toasterService = toasterService;
			this.ProductAttributesVM = productAttributesViewModel;
			this.ProductAttributesVM.SetParentViewModel(this);
			this.WarrantyOptionses = WarrantyOptions.GetAll();
			this.Units = this.StoreService.GetUnits();
			this.Item = new store_items();
		}

		// Token: 0x06002F47 RID: 12103 RVA: 0x0009AF08 File Offset: 0x00099108
		public void LoadData()
		{
			ProductOverviewViewModel.<LoadData>d__39 <LoadData>d__;
			<LoadData>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadData>d__.<>4__this = this;
			<LoadData>d__.<>1__state = -1;
			<LoadData>d__.<>t__builder.Start<ProductOverviewViewModel.<LoadData>d__39>(ref <LoadData>d__);
		}

		// Token: 0x06002F48 RID: 12104 RVA: 0x0009AF40 File Offset: 0x00099140
		private Task LoadProduct()
		{
			ProductOverviewViewModel.<LoadProduct>d__40 <LoadProduct>d__;
			<LoadProduct>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadProduct>d__.<>4__this = this;
			<LoadProduct>d__.<>1__state = -1;
			<LoadProduct>d__.<>t__builder.Start<ProductOverviewViewModel.<LoadProduct>d__40>(ref <LoadProduct>d__);
			return <LoadProduct>d__.<>t__builder.Task;
		}

		// Token: 0x06002F49 RID: 12105 RVA: 0x0009AF84 File Offset: 0x00099184
		private void LoadImages()
		{
			ProductOverviewViewModel.<LoadImages>d__41 <LoadImages>d__;
			<LoadImages>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadImages>d__.<>4__this = this;
			<LoadImages>d__.<>1__state = -1;
			<LoadImages>d__.<>t__builder.Start<ProductOverviewViewModel.<LoadImages>d__41>(ref <LoadImages>d__);
		}

		// Token: 0x06002F4A RID: 12106 RVA: 0x0009AFBC File Offset: 0x000991BC
		[Command]
		public void SaveImage(int id)
		{
			images images = this.Images.FirstOrDefault((images i) => i.id == id);
			try
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog
				{
					Filter = "Images|*.png;",
					FileName = "Image"
				};
				bool? flag = saveFileDialog.ShowDialog();
				if (flag.GetValueOrDefault() & flag != null)
				{
					using (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
					{
						fileStream.Write(images.img, 0, images.img.Length);
					}
				}
			}
			catch (Exception ex)
			{
				this._toasterService.Error(ex.Message);
			}
		}

		// Token: 0x06002F4B RID: 12107 RVA: 0x0009B090 File Offset: 0x00099290
		[Command]
		public void ZoomImage(int imageId)
		{
			new PhotoView(imageId).Show();
		}

		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x06002F4C RID: 12108 RVA: 0x0009B0A8 File Offset: 0x000992A8
		// (set) Token: 0x06002F4D RID: 12109 RVA: 0x0009B0BC File Offset: 0x000992BC
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
				if (this.<IsLoadingData>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = 1273926564;
				IL_10:
				switch ((num ^ 1144206546) % 4)
				{
				case 0:
					goto IL_0B;
				case 1:
					IL_2F:
					num = 445433957;
					goto IL_10;
				case 2:
					return;
				}
				this.<IsLoadingData>k__BackingField = value;
				this.RaisePropertyChanged("IsLoadingData");
			}
		}

		// Token: 0x06002F4E RID: 12110 RVA: 0x0009B114 File Offset: 0x00099314
		public void SetIsDataLoading(bool value)
		{
			this.IsLoadingData = value;
		}

		// Token: 0x06002F4F RID: 12111 RVA: 0x0009B128 File Offset: 0x00099328
		public void NavigatedTo(NavigationEventArgs e)
		{
			this.ProductId = (int)e.Parameter;
			this.LoadData();
		}

		// Token: 0x06002F50 RID: 12112 RVA: 0x00023150 File Offset: 0x00021350
		public void NavigatingFrom(NavigatingEventArgs e)
		{
		}

		// Token: 0x06002F51 RID: 12113 RVA: 0x00023150 File Offset: 0x00021350
		public void NavigatedFrom(NavigationEventArgs e)
		{
		}

		// Token: 0x06002F52 RID: 12114 RVA: 0x0009B14C File Offset: 0x0009934C
		[CompilerGenerated]
		private Task<List<store_cats>> <LoadData>b__39_1()
		{
			return this.StoreService.GetCategoriesAsync(this.Item.store);
		}

		// Token: 0x06002F53 RID: 12115 RVA: 0x0009B170 File Offset: 0x00099370
		[CompilerGenerated]
		private void <LoadData>b__39_0()
		{
			this.ProductAttributesVM.LoadItems(this.ProductId, false);
		}

		// Token: 0x06002F54 RID: 12116 RVA: 0x0009B190 File Offset: 0x00099390
		[CompilerGenerated]
		private Task<store_items> <LoadProduct>b__40_0()
		{
			return this.StoreService.GetProduct(this.ProductId);
		}

		// Token: 0x04001AB3 RID: 6835
		protected int ProductId;

		// Token: 0x04001AB4 RID: 6836
		protected IProductService ProductService;

		// Token: 0x04001AB5 RID: 6837
		protected IStoreService StoreService;

		// Token: 0x04001AB6 RID: 6838
		private readonly IToasterService _toasterService;

		// Token: 0x04001AB7 RID: 6839
		[CompilerGenerated]
		private store_items <Item>k__BackingField;

		// Token: 0x04001AB8 RID: 6840
		[CompilerGenerated]
		private ObservableCollection<images> <Images>k__BackingField = new ObservableCollection<images>();

		// Token: 0x04001AB9 RID: 6841
		[CompilerGenerated]
		private List<store_cats> <StoreCategories>k__BackingField;

		// Token: 0x04001ABA RID: 6842
		[CompilerGenerated]
		private List<ItemUnits> <Units>k__BackingField;

		// Token: 0x04001ABB RID: 6843
		[CompilerGenerated]
		private IProductAttributesViewModel <ProductAttributesVM>k__BackingField;

		// Token: 0x04001ABC RID: 6844
		[CompilerGenerated]
		private decimal <CurrentRate>k__BackingField = Auth.CurrencyModel.Rate;

		// Token: 0x04001ABD RID: 6845
		[CompilerGenerated]
		private bool <IsCurrencyBinding>k__BackingField;

		// Token: 0x04001ABE RID: 6846
		[CompilerGenerated]
		private List<Warranty> <WarrantyOptionses>k__BackingField;

		// Token: 0x04001ABF RID: 6847
		[CompilerGenerated]
		private bool <IsLoadingData>k__BackingField;

		// Token: 0x020004C8 RID: 1224
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadData>d__39 : IAsyncStateMachine
		{
			// Token: 0x06002F55 RID: 12117 RVA: 0x0009B1B0 File Offset: 0x000993B0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ProductOverviewViewModel productOverviewViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter<List<store_cats>> awaiter2;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<List<store_cats>>);
						this.<>1__state = -1;
						goto IL_DD;
					case 2:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_148;
					default:
						awaiter = productOverviewViewModel.LoadProduct().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ProductOverviewViewModel.<LoadData>d__39>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					awaiter2 = Task.Run<List<store_cats>>(() => productOverviewViewModel.StoreService.GetCategoriesAsync(base.Item.store)).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_cats>>, ProductOverviewViewModel.<LoadData>d__39>(ref awaiter2, ref this);
						return;
					}
					IL_DD:
					List<store_cats> result = awaiter2.GetResult();
					productOverviewViewModel.StoreCategories = result;
					awaiter = Task.Run(delegate()
					{
						base.ProductAttributesVM.LoadItems(productOverviewViewModel.ProductId, false);
					}).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ProductOverviewViewModel.<LoadData>d__39>(ref awaiter, ref this);
						return;
					}
					IL_148:
					awaiter.GetResult();
					productOverviewViewModel.LoadImages();
					if (productOverviewViewModel.Item.price_option == 2)
					{
						productOverviewViewModel.IsCurrencyBinding = true;
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

			// Token: 0x06002F56 RID: 12118 RVA: 0x0009B374 File Offset: 0x00099574
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001AC0 RID: 6848
			public int <>1__state;

			// Token: 0x04001AC1 RID: 6849
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001AC2 RID: 6850
			public ProductOverviewViewModel <>4__this;

			// Token: 0x04001AC3 RID: 6851
			private TaskAwaiter <>u__1;

			// Token: 0x04001AC4 RID: 6852
			private TaskAwaiter<List<store_cats>> <>u__2;
		}

		// Token: 0x020004C9 RID: 1225
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadProduct>d__40 : IAsyncStateMachine
		{
			// Token: 0x06002F57 RID: 12119 RVA: 0x0009B390 File Offset: 0x00099590
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ProductOverviewViewModel productOverviewViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<store_items> awaiter;
					if (num != 0)
					{
						productOverviewViewModel.SetIsDataLoading(true);
						awaiter = Task.Run<store_items>(() => productOverviewViewModel.StoreService.GetProduct(productOverviewViewModel.ProductId)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<store_items>, ProductOverviewViewModel.<LoadProduct>d__40>(ref awaiter, ref this);
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
					productOverviewViewModel.Item = result;
					productOverviewViewModel.SetIsDataLoading(false);
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

			// Token: 0x06002F58 RID: 12120 RVA: 0x0009B468 File Offset: 0x00099668
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001AC5 RID: 6853
			public int <>1__state;

			// Token: 0x04001AC6 RID: 6854
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001AC7 RID: 6855
			public ProductOverviewViewModel <>4__this;

			// Token: 0x04001AC8 RID: 6856
			private TaskAwaiter<store_items> <>u__1;
		}

		// Token: 0x020004CA RID: 1226
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadImages>d__41 : IAsyncStateMachine
		{
			// Token: 0x06002F59 RID: 12121 RVA: 0x0009B484 File Offset: 0x00099684
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ProductOverviewViewModel productOverviewViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<images>> awaiter;
					if (num != 0)
					{
						awaiter = productOverviewViewModel.ProductService.GetImages(productOverviewViewModel.ProductId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<images>>, ProductOverviewViewModel.<LoadImages>d__41>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<images>>);
						this.<>1__state = -1;
					}
					IEnumerable<images> result = awaiter.GetResult();
					productOverviewViewModel.Images = new ObservableCollection<images>(result);
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

			// Token: 0x06002F5A RID: 12122 RVA: 0x0009B550 File Offset: 0x00099750
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001AC9 RID: 6857
			public int <>1__state;

			// Token: 0x04001ACA RID: 6858
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001ACB RID: 6859
			public ProductOverviewViewModel <>4__this;

			// Token: 0x04001ACC RID: 6860
			private TaskAwaiter<IEnumerable<images>> <>u__1;
		}

		// Token: 0x020004CB RID: 1227
		[CompilerGenerated]
		private sealed class <>c__DisplayClass42_0
		{
			// Token: 0x06002F5B RID: 12123 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass42_0()
			{
			}

			// Token: 0x06002F5C RID: 12124 RVA: 0x0009B56C File Offset: 0x0009976C
			internal bool <SaveImage>b__0(images i)
			{
				return i.id == this.id;
			}

			// Token: 0x04001ACD RID: 6861
			public int id;
		}
	}
}
