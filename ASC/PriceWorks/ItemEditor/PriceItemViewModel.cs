using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Objects;
using ASC.Objects;
using ASC.Options;
using ASC.Services.Abstract;
using ASC.ViewModels;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.PriceWorks.ItemEditor
{
	// Token: 0x0200016D RID: 365
	public class PriceItemViewModel : BaseViewModel
	{
		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06001728 RID: 5928 RVA: 0x0003B71C File Offset: 0x0003991C
		// (set) Token: 0x06001729 RID: 5929 RVA: 0x0003B730 File Offset: 0x00039930
		public workshop_price Item
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
				this.RaisePropertyChanged("IsNewItem");
				this.RaisePropertyChanged("IsNewItemInvert");
				this.RaisePropertyChanged("Item");
			}
		}

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x0600172A RID: 5930 RVA: 0x0003B774 File Offset: 0x00039974
		// (set) Token: 0x0600172B RID: 5931 RVA: 0x0003B788 File Offset: 0x00039988
		public List<Warranty> WarrantyOptionses
		{
			[CompilerGenerated]
			get
			{
				return this.<WarrantyOptionses>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(this.<WarrantyOptionses>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1363769058;
				IL_13:
				switch ((num ^ -1744124967) % 4)
				{
				case 0:
					goto IL_0E;
				case 2:
					IL_32:
					this.<WarrantyOptionses>k__BackingField = value;
					this.RaisePropertyChanged("WarrantyOptionses");
					num = -1956379180;
					goto IL_13;
				case 3:
					return;
				}
			}
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x0600172C RID: 5932 RVA: 0x0003B7E4 File Offset: 0x000399E4
		// (set) Token: 0x0600172D RID: 5933 RVA: 0x0003B7F8 File Offset: 0x000399F8
		public List<workshop_cats> WorkshopCatses
		{
			[CompilerGenerated]
			get
			{
				return this.<WorkshopCatses>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<WorkshopCatses>k__BackingField, value))
				{
					return;
				}
				this.<WorkshopCatses>k__BackingField = value;
				this.RaisePropertyChanged("WorkshopCatses");
			}
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x0600172E RID: 5934 RVA: 0x0003B828 File Offset: 0x00039A28
		public bool IsNewItem
		{
			get
			{
				return this.Item != null && this.Item.id == 0;
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x0600172F RID: 5935 RVA: 0x0003B850 File Offset: 0x00039A50
		public bool IsNewItemInvert
		{
			get
			{
				return !this.IsNewItem;
			}
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x0003B868 File Offset: 0x00039A68
		public PriceItemViewModel()
		{
			this.IoC();
			this.WarrantyOptionses = WarrantyOptions.GetAll();
			this.Item = new workshop_price
			{
				enable = true,
				warranty = new int?(0)
			};
			this.LoadCats();
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x0003B8B0 File Offset: 0x00039AB0
		public PriceItemViewModel(int itemId)
		{
			this.IoC();
			this.WarrantyOptionses = WarrantyOptions.GetAll();
			this.LoadItem(itemId);
			this.LoadCats();
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x0003B8E4 File Offset: 0x00039AE4
		private void IoC()
		{
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._priceListService = Bootstrapper.Container.Resolve<IPriceListService>();
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x0003B924 File Offset: 0x00039B24
		private void RefreshFields()
		{
			base.RaisePropertyChanged<bool>(() => this.IsNewItem);
			base.RaisePropertyChanged<bool>(() => this.IsNewItemInvert);
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x0003B99C File Offset: 0x00039B9C
		public void SetCategory(int value)
		{
			if (value != 0)
			{
				this.Item.category = value;
			}
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x0003B9B8 File Offset: 0x00039BB8
		public void SetVendor(int? value)
		{
			this.Item.vendor_id = value;
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x0003B9D4 File Offset: 0x00039BD4
		private void LoadItem(int itemId)
		{
			PriceItemViewModel.<LoadItem>d__26 <LoadItem>d__;
			<LoadItem>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadItem>d__.<>4__this = this;
			<LoadItem>d__.itemId = itemId;
			<LoadItem>d__.<>1__state = -1;
			<LoadItem>d__.<>t__builder.Start<PriceItemViewModel.<LoadItem>d__26>(ref <LoadItem>d__);
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x0003BA14 File Offset: 0x00039C14
		private void LoadCats()
		{
			PriceItemViewModel.<LoadCats>d__27 <LoadCats>d__;
			<LoadCats>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadCats>d__.<>4__this = this;
			<LoadCats>d__.<>1__state = -1;
			<LoadCats>d__.<>t__builder.Start<PriceItemViewModel.<LoadCats>d__27>(ref <LoadCats>d__);
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x0003BA4C File Offset: 0x00039C4C
		[Command]
		public void Create()
		{
			PriceItemViewModel.<Create>d__28 <Create>d__;
			<Create>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Create>d__.<>4__this = this;
			<Create>d__.<>1__state = -1;
			<Create>d__.<>t__builder.Start<PriceItemViewModel.<Create>d__28>(ref <Create>d__);
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x0003BA84 File Offset: 0x00039C84
		public bool CanCreate()
		{
			return OfflineData.Instance.Employee.Can(38, 0);
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x0003BAA4 File Offset: 0x00039CA4
		[Command]
		public void Close()
		{
			this._windowedDocumentService.CloseActiveDocument();
			PriceWorksViewModel parentViewModel = this._parentViewModel;
			if (parentViewModel != null)
			{
				parentViewModel.Refresh();
				return;
			}
		}

		// Token: 0x0600173B RID: 5947 RVA: 0x0003BACC File Offset: 0x00039CCC
		[Command]
		public void Update()
		{
			PriceItemViewModel.<Update>d__31 <Update>d__;
			<Update>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Update>d__.<>4__this = this;
			<Update>d__.<>1__state = -1;
			<Update>d__.<>t__builder.Start<PriceItemViewModel.<Update>d__31>(ref <Update>d__);
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x0003BA84 File Offset: 0x00039C84
		public bool CanUpdate()
		{
			return OfflineData.Instance.Employee.Can(38, 0);
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x0003BB04 File Offset: 0x00039D04
		protected override void OnParentViewModelChanged(object parentViewModel)
		{
			this._parentViewModel = (parentViewModel as PriceWorksViewModel);
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x0003BB20 File Offset: 0x00039D20
		[CompilerGenerated]
		private Task<int> <Create>b__28_0()
		{
			return this._priceListService.CreateItem(this.Item);
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x0003BB40 File Offset: 0x00039D40
		[CompilerGenerated]
		private Task <Update>b__31_0()
		{
			return this._priceListService.UpdateItem(this.Item);
		}

		// Token: 0x04000B7B RID: 2939
		private PriceWorksViewModel _parentViewModel;

		// Token: 0x04000B7C RID: 2940
		private IPriceListService _priceListService;

		// Token: 0x04000B7D RID: 2941
		private IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04000B7E RID: 2942
		private IToasterService _toasterService;

		// Token: 0x04000B7F RID: 2943
		[CompilerGenerated]
		private workshop_price <Item>k__BackingField;

		// Token: 0x04000B80 RID: 2944
		[CompilerGenerated]
		private List<Warranty> <WarrantyOptionses>k__BackingField;

		// Token: 0x04000B81 RID: 2945
		[CompilerGenerated]
		private List<workshop_cats> <WorkshopCatses>k__BackingField;

		// Token: 0x0200016E RID: 366
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadItem>d__26 : IAsyncStateMachine
		{
			// Token: 0x06001740 RID: 5952 RVA: 0x0003BB60 File Offset: 0x00039D60
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PriceItemViewModel priceItemViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<workshop_price> awaiter;
					if (num != 0)
					{
						awaiter = priceItemViewModel._priceListService.GetItem(this.itemId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop_price>, PriceItemViewModel.<LoadItem>d__26>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<workshop_price>);
						this.<>1__state = -1;
					}
					workshop_price result = awaiter.GetResult();
					priceItemViewModel.Item = result;
					priceItemViewModel.RefreshFields();
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

			// Token: 0x06001741 RID: 5953 RVA: 0x0003BC30 File Offset: 0x00039E30
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000B82 RID: 2946
			public int <>1__state;

			// Token: 0x04000B83 RID: 2947
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000B84 RID: 2948
			public PriceItemViewModel <>4__this;

			// Token: 0x04000B85 RID: 2949
			public int itemId;

			// Token: 0x04000B86 RID: 2950
			private TaskAwaiter<workshop_price> <>u__1;
		}

		// Token: 0x0200016F RID: 367
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadCats>d__27 : IAsyncStateMachine
		{
			// Token: 0x06001742 RID: 5954 RVA: 0x0003BC4C File Offset: 0x00039E4C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PriceItemViewModel priceItemViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<workshop_cats>> awaiter;
					if (num != 0)
					{
						awaiter = priceItemViewModel._priceListService.GetPriceCategories().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<workshop_cats>>, PriceItemViewModel.<LoadCats>d__27>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<workshop_cats>>);
						this.<>1__state = -1;
					}
					List<workshop_cats> result = awaiter.GetResult();
					priceItemViewModel.WorkshopCatses = result;
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

			// Token: 0x06001743 RID: 5955 RVA: 0x0003BD10 File Offset: 0x00039F10
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000B87 RID: 2951
			public int <>1__state;

			// Token: 0x04000B88 RID: 2952
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000B89 RID: 2953
			public PriceItemViewModel <>4__this;

			// Token: 0x04000B8A RID: 2954
			private TaskAwaiter<List<workshop_cats>> <>u__1;
		}

		// Token: 0x02000170 RID: 368
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Create>d__28 : IAsyncStateMachine
		{
			// Token: 0x06001744 RID: 5956 RVA: 0x0003BD2C File Offset: 0x00039F2C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PriceItemViewModel priceItemViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						string text = priceItemViewModel._priceListService.CheckFields(priceItemViewModel.Item);
						if (!string.IsNullOrEmpty(text))
						{
							priceItemViewModel._toasterService.Info(text);
							goto IL_11B;
						}
						priceItemViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter<int> awaiter;
						if (num != 0)
						{
							awaiter = Task.Run<int>(() => priceItemViewModel._priceListService.CreateItem(base.Item)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, PriceItemViewModel.<Create>d__28>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<int>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						awaiter.GetResult();
						priceItemViewModel._toasterService.Success(Lang.t("Saved"));
						priceItemViewModel.Close();
						PriceWorksViewModel parentViewModel = priceItemViewModel._parentViewModel;
						if (parentViewModel != null)
						{
							parentViewModel.Refresh();
						}
					}
					catch (Exception ex)
					{
						priceItemViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							priceItemViewModel.HideWait();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_11B:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06001745 RID: 5957 RVA: 0x0003BE90 File Offset: 0x0003A090
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000B8B RID: 2955
			public int <>1__state;

			// Token: 0x04000B8C RID: 2956
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000B8D RID: 2957
			public PriceItemViewModel <>4__this;

			// Token: 0x04000B8E RID: 2958
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x02000171 RID: 369
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Update>d__31 : IAsyncStateMachine
		{
			// Token: 0x06001746 RID: 5958 RVA: 0x0003BEAC File Offset: 0x0003A0AC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PriceItemViewModel priceItemViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						string text = priceItemViewModel._priceListService.CheckFields(priceItemViewModel.Item);
						if (!string.IsNullOrEmpty(text))
						{
							priceItemViewModel._toasterService.Info(text);
							goto IL_112;
						}
						priceItemViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = Task.Run(() => priceItemViewModel._priceListService.UpdateItem(base.Item)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, PriceItemViewModel.<Update>d__31>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						awaiter.GetResult();
						priceItemViewModel._toasterService.Success(Lang.t("Saved"));
						PriceWorksViewModel parentViewModel = priceItemViewModel._parentViewModel;
						if (parentViewModel != null)
						{
							parentViewModel.Refresh();
						}
					}
					catch (Exception ex)
					{
						priceItemViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							priceItemViewModel.HideWait();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_112:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06001747 RID: 5959 RVA: 0x0003C008 File Offset: 0x0003A208
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000B8F RID: 2959
			public int <>1__state;

			// Token: 0x04000B90 RID: 2960
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000B91 RID: 2961
			public PriceItemViewModel <>4__this;

			// Token: 0x04000B92 RID: 2962
			private TaskAwaiter <>u__1;
		}
	}
}
