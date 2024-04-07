using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Interfaces;
using ASC.Services.Abstract;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels
{
	// Token: 0x02000496 RID: 1174
	public class PhotoViewAddModel : CollectionViewModel<images>, IIsDataLoading
	{
		// Token: 0x17000E95 RID: 3733
		// (get) Token: 0x06002DC1 RID: 11713 RVA: 0x00094A28 File Offset: 0x00092C28
		// (set) Token: 0x06002DC2 RID: 11714 RVA: 0x00094A3C File Offset: 0x00092C3C
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

		// Token: 0x06002DC3 RID: 11715 RVA: 0x00094A68 File Offset: 0x00092C68
		public PhotoViewAddModel(IOrderService orderService, IImageService imageService, IWindowedDocumentService windowedDocumentService)
		{
			this.OrderService = orderService;
			this.ImageService = imageService;
			this._windowedDocumentService = windowedDocumentService;
		}

		// Token: 0x06002DC4 RID: 11716 RVA: 0x00094A90 File Offset: 0x00092C90
		public void SetLimit(int value)
		{
			this._limit = value;
			this.AddEmptyItems(value);
		}

		// Token: 0x06002DC5 RID: 11717 RVA: 0x00094AAC File Offset: 0x00092CAC
		public void SetId(int id)
		{
			this._repairId = id;
		}

		// Token: 0x06002DC6 RID: 11718 RVA: 0x00094AC0 File Offset: 0x00092CC0
		private void AddEmptyItems(int count)
		{
			for (int i = 0; i < count; i++)
			{
				base.Items.Add(new images());
			}
		}

		// Token: 0x06002DC7 RID: 11719 RVA: 0x00094AEC File Offset: 0x00092CEC
		public virtual Task LoadData(int orderId)
		{
			PhotoViewAddModel.<LoadData>d__14 <LoadData>d__;
			<LoadData>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadData>d__.<>4__this = this;
			<LoadData>d__.orderId = orderId;
			<LoadData>d__.<>1__state = -1;
			<LoadData>d__.<>t__builder.Start<PhotoViewAddModel.<LoadData>d__14>(ref <LoadData>d__);
			return <LoadData>d__.<>t__builder.Task;
		}

		// Token: 0x06002DC8 RID: 11720 RVA: 0x00094B38 File Offset: 0x00092D38
		public virtual Task LoadData(List<int> imageIds)
		{
			PhotoViewAddModel.<LoadData>d__15 <LoadData>d__;
			<LoadData>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadData>d__.<>4__this = this;
			<LoadData>d__.imageIds = imageIds;
			<LoadData>d__.<>1__state = -1;
			<LoadData>d__.<>t__builder.Start<PhotoViewAddModel.<LoadData>d__15>(ref <LoadData>d__);
			return <LoadData>d__.<>t__builder.Task;
		}

		// Token: 0x06002DC9 RID: 11721 RVA: 0x00094B84 File Offset: 0x00092D84
		private void SetItems(IReadOnlyList<images> images)
		{
			for (int i = 0; i < images.Count; i++)
			{
				base.Items[i] = images[i];
			}
		}

		// Token: 0x06002DCA RID: 11722 RVA: 0x00094BB8 File Offset: 0x00092DB8
		public void SetIsDataLoading(bool value)
		{
			this.IsLoadingData = value;
		}

		// Token: 0x06002DCB RID: 11723 RVA: 0x00094BCC File Offset: 0x00092DCC
		protected virtual List<int> GetImageIds()
		{
			return (from i in base.Items
			where i.id > 0
			select i.id).ToList<int>();
		}

		// Token: 0x06002DCC RID: 11724 RVA: 0x00094C2C File Offset: 0x00092E2C
		[Command]
		public void Close()
		{
			List<int> imageIds = this.GetImageIds();
			IImagesEdit parentViewModel = this._parentViewModel;
			if (parentViewModel != null)
			{
				parentViewModel.ImagesCallBack(imageIds, this._repairId);
				goto IL_4C;
			}
			IL_21:
			base.Items.Clear();
			int num = 933520651;
			IL_31:
			switch ((num ^ 772345749) % 3)
			{
			case 1:
				goto IL_21;
			case 2:
				IL_4C:
				num = 152691952;
				goto IL_31;
			}
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x06002DCD RID: 11725 RVA: 0x00094C98 File Offset: 0x00092E98
		[Command]
		public void Save()
		{
			PhotoViewAddModel.<Save>d__20 <Save>d__;
			<Save>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Save>d__.<>4__this = this;
			<Save>d__.<>1__state = -1;
			<Save>d__.<>t__builder.Start<PhotoViewAddModel.<Save>d__20>(ref <Save>d__);
		}

		// Token: 0x06002DCE RID: 11726 RVA: 0x00094CD0 File Offset: 0x00092ED0
		private void RemoveImagesFromItems(List<int> imageIds)
		{
			foreach (images item in (from i in base.Items
			where imageIds.Contains(i.id)
			select i).ToList<images>())
			{
				base.Items.Remove(item);
			}
		}

		// Token: 0x06002DCF RID: 11727 RVA: 0x00094D50 File Offset: 0x00092F50
		protected virtual List<int> GetItemsToDelete()
		{
			return (from i in base.Items
			where i.id > 0 && i.img == null
			select i.id).ToList<int>();
		}

		// Token: 0x06002DD0 RID: 11728 RVA: 0x00094DB0 File Offset: 0x00092FB0
		protected virtual List<images> GetItemsToCreate()
		{
			return (from i in base.Items
			where i.id == 0 && i.img != null
			select i).ToList<images>();
		}

		// Token: 0x06002DD1 RID: 11729 RVA: 0x00094DEC File Offset: 0x00092FEC
		protected virtual List<images> GetItemsToUpdate()
		{
			return (from i in base.Items
			where i.id > 0 && i.img != null
			select i).ToList<images>();
		}

		// Token: 0x06002DD2 RID: 11730 RVA: 0x00094E28 File Offset: 0x00093028
		protected override void OnParentViewModelChanged(object parentViewModel)
		{
			base.OnParentViewModelChanged(parentViewModel);
			this._parentViewModel = (parentViewModel as IImagesEdit);
		}

		// Token: 0x040019AF RID: 6575
		protected IOrderService OrderService;

		// Token: 0x040019B0 RID: 6576
		protected IImageService ImageService;

		// Token: 0x040019B1 RID: 6577
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x040019B2 RID: 6578
		private IImagesEdit _parentViewModel;

		// Token: 0x040019B3 RID: 6579
		[CompilerGenerated]
		private bool <IsLoadingData>k__BackingField;

		// Token: 0x040019B4 RID: 6580
		private int _limit;

		// Token: 0x040019B5 RID: 6581
		private int _repairId;

		// Token: 0x02000497 RID: 1175
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadData>d__14 : IAsyncStateMachine
		{
			// Token: 0x06002DD3 RID: 11731 RVA: 0x00094E48 File Offset: 0x00093048
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PhotoViewAddModel photoViewAddModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<images>> awaiter;
					if (num != 0)
					{
						photoViewAddModel.SetIsDataLoading(true);
						awaiter = photoViewAddModel.OrderService.GetImages(this.orderId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<images>>, PhotoViewAddModel.<LoadData>d__14>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<images>>);
						this.<>1__state = -1;
					}
					List<images> result = awaiter.GetResult();
					if (result.Count > photoViewAddModel.Items.Count)
					{
						throw new ArgumentOutOfRangeException();
					}
					photoViewAddModel.SetItems(result);
					photoViewAddModel.SetIsDataLoading(false);
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

			// Token: 0x06002DD4 RID: 11732 RVA: 0x00094F38 File Offset: 0x00093138
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040019B6 RID: 6582
			public int <>1__state;

			// Token: 0x040019B7 RID: 6583
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040019B8 RID: 6584
			public PhotoViewAddModel <>4__this;

			// Token: 0x040019B9 RID: 6585
			public int orderId;

			// Token: 0x040019BA RID: 6586
			private TaskAwaiter<List<images>> <>u__1;
		}

		// Token: 0x02000498 RID: 1176
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadData>d__15 : IAsyncStateMachine
		{
			// Token: 0x06002DD5 RID: 11733 RVA: 0x00094F54 File Offset: 0x00093154
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PhotoViewAddModel photoViewAddModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<images>> awaiter;
					if (num != 0)
					{
						if (this.imageIds.Count > photoViewAddModel.Items.Count)
						{
							throw new ArgumentOutOfRangeException();
						}
						photoViewAddModel.SetIsDataLoading(true);
						awaiter = photoViewAddModel.ImageService.GetImages(this.imageIds).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<images>>, PhotoViewAddModel.<LoadData>d__15>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<images>>);
						this.<>1__state = -1;
					}
					List<images> result = awaiter.GetResult();
					photoViewAddModel.SetItems(result);
					photoViewAddModel.SetIsDataLoading(false);
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

			// Token: 0x06002DD6 RID: 11734 RVA: 0x00095048 File Offset: 0x00093248
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040019BB RID: 6587
			public int <>1__state;

			// Token: 0x040019BC RID: 6588
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040019BD RID: 6589
			public List<int> imageIds;

			// Token: 0x040019BE RID: 6590
			public PhotoViewAddModel <>4__this;

			// Token: 0x040019BF RID: 6591
			private TaskAwaiter<List<images>> <>u__1;
		}

		// Token: 0x02000499 RID: 1177
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002DD7 RID: 11735 RVA: 0x00095064 File Offset: 0x00093264
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06002DD8 RID: 11736 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06002DD9 RID: 11737 RVA: 0x0007FCB0 File Offset: 0x0007DEB0
			internal bool <GetImageIds>b__18_0(images i)
			{
				return i.id > 0;
			}

			// Token: 0x06002DDA RID: 11738 RVA: 0x0007FCC8 File Offset: 0x0007DEC8
			internal int <GetImageIds>b__18_1(images i)
			{
				return i.id;
			}

			// Token: 0x06002DDB RID: 11739 RVA: 0x0009507C File Offset: 0x0009327C
			internal bool <GetItemsToDelete>b__22_0(images i)
			{
				return i.id > 0 && i.img == null;
			}

			// Token: 0x06002DDC RID: 11740 RVA: 0x0007FCC8 File Offset: 0x0007DEC8
			internal int <GetItemsToDelete>b__22_1(images i)
			{
				return i.id;
			}

			// Token: 0x06002DDD RID: 11741 RVA: 0x000950A0 File Offset: 0x000932A0
			internal bool <GetItemsToCreate>b__23_0(images i)
			{
				return i.id == 0 && i.img != null;
			}

			// Token: 0x06002DDE RID: 11742 RVA: 0x000950C0 File Offset: 0x000932C0
			internal bool <GetItemsToUpdate>b__24_0(images i)
			{
				return i.id > 0 && i.img != null;
			}

			// Token: 0x040019C0 RID: 6592
			public static readonly PhotoViewAddModel.<>c <>9 = new PhotoViewAddModel.<>c();

			// Token: 0x040019C1 RID: 6593
			public static Func<images, bool> <>9__18_0;

			// Token: 0x040019C2 RID: 6594
			public static Func<images, int> <>9__18_1;

			// Token: 0x040019C3 RID: 6595
			public static Func<images, bool> <>9__22_0;

			// Token: 0x040019C4 RID: 6596
			public static Func<images, int> <>9__22_1;

			// Token: 0x040019C5 RID: 6597
			public static Func<images, bool> <>9__23_0;

			// Token: 0x040019C6 RID: 6598
			public static Func<images, bool> <>9__24_0;
		}

		// Token: 0x0200049A RID: 1178
		[CompilerGenerated]
		private sealed class <>c__DisplayClass20_0
		{
			// Token: 0x06002DDF RID: 11743 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass20_0()
			{
			}

			// Token: 0x06002DE0 RID: 11744 RVA: 0x000950E4 File Offset: 0x000932E4
			internal Task<int> <Save>b__0()
			{
				return this.<>4__this.ImageService.CreateImageAsync(this.image);
			}

			// Token: 0x040019C7 RID: 6599
			public images image;

			// Token: 0x040019C8 RID: 6600
			public PhotoViewAddModel <>4__this;
		}

		// Token: 0x0200049B RID: 1179
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Save>d__20 : IAsyncStateMachine
		{
			// Token: 0x06002DE1 RID: 11745 RVA: 0x00095108 File Offset: 0x00093308
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PhotoViewAddModel photoViewAddModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						if (num == 1)
						{
							goto IL_145;
						}
						photoViewAddModel.SetIsDataLoading(true);
						List<int> itemsToDelete = photoViewAddModel.GetItemsToDelete();
						if (itemsToDelete.Any<int>())
						{
							photoViewAddModel.ImageService.DeleteImages(itemsToDelete);
							photoViewAddModel.RemoveImagesFromItems(itemsToDelete);
						}
						this.<>7__wrap1 = photoViewAddModel.GetItemsToCreate().GetEnumerator();
					}
					try
					{
						TaskAwaiter<int> awaiter;
						if (num == 0)
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<int>);
							int num2 = -1;
							num = -1;
							this.<>1__state = num2;
							goto IL_CD;
						}
						IL_75:
						if (!this.<>7__wrap1.MoveNext())
						{
							goto IL_128;
						}
						PhotoViewAddModel.<>c__DisplayClass20_0 CS$<>8__locals1 = new PhotoViewAddModel.<>c__DisplayClass20_0();
						CS$<>8__locals1.<>4__this = photoViewAddModel;
						CS$<>8__locals1.image = this.<>7__wrap1.Current;
						this.<>7__wrap2 = CS$<>8__locals1.image;
						awaiter = Task.Run<int>(new Func<Task<int>>(CS$<>8__locals1.<Save>b__0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num3 = 0;
							num = 0;
							this.<>1__state = num3;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, PhotoViewAddModel.<Save>d__20>(ref awaiter, ref this);
							return;
						}
						IL_CD:
						int result = awaiter.GetResult();
						this.<>7__wrap2.id = result;
						this.<>7__wrap2 = null;
						goto IL_75;
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)this.<>7__wrap1).Dispose();
						}
					}
					IL_128:
					this.<>7__wrap1 = default(List<images>.Enumerator);
					this.<>7__wrap1 = photoViewAddModel.GetItemsToUpdate().GetEnumerator();
					IL_145:
					try
					{
						TaskAwaiter awaiter2;
						if (num == 1)
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
							goto IL_1A2;
						}
						IL_16B:
						if (!this.<>7__wrap1.MoveNext())
						{
							goto IL_1E4;
						}
						images i = this.<>7__wrap1.Current;
						awaiter2 = photoViewAddModel.ImageService.UpdateImageAsync(i).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num5 = 1;
							num = 1;
							this.<>1__state = num5;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, PhotoViewAddModel.<Save>d__20>(ref awaiter2, ref this);
							return;
						}
						IL_1A2:
						awaiter2.GetResult();
						goto IL_16B;
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)this.<>7__wrap1).Dispose();
						}
					}
					IL_1E4:
					this.<>7__wrap1 = default(List<images>.Enumerator);
					photoViewAddModel.Close();
					photoViewAddModel.SetIsDataLoading(false);
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

			// Token: 0x06002DE2 RID: 11746 RVA: 0x0009538C File Offset: 0x0009358C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040019C9 RID: 6601
			public int <>1__state;

			// Token: 0x040019CA RID: 6602
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040019CB RID: 6603
			public PhotoViewAddModel <>4__this;

			// Token: 0x040019CC RID: 6604
			private List<images>.Enumerator <>7__wrap1;

			// Token: 0x040019CD RID: 6605
			private images <>7__wrap2;

			// Token: 0x040019CE RID: 6606
			private TaskAwaiter<int> <>u__1;

			// Token: 0x040019CF RID: 6607
			private TaskAwaiter <>u__2;
		}

		// Token: 0x0200049C RID: 1180
		[CompilerGenerated]
		private sealed class <>c__DisplayClass21_0
		{
			// Token: 0x06002DE3 RID: 11747 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass21_0()
			{
			}

			// Token: 0x06002DE4 RID: 11748 RVA: 0x000953A8 File Offset: 0x000935A8
			internal bool <RemoveImagesFromItems>b__0(images i)
			{
				return this.imageIds.Contains(i.id);
			}

			// Token: 0x040019D0 RID: 6608
			public List<int> imageIds;
		}
	}
}
