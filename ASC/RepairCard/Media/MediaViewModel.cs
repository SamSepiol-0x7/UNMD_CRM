using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ASC.Interfaces;
using ASC.Services.Abstract;
using ASC.ViewModels;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Microsoft.Win32;

namespace ASC.RepairCard.Media
{
	// Token: 0x02000843 RID: 2115
	public class MediaViewModel : RepairCardCommonView, IImagesEdit
	{
		// Token: 0x170010D9 RID: 4313
		// (get) Token: 0x06003EC1 RID: 16065 RVA: 0x000FB184 File Offset: 0x000F9384
		// (set) Token: 0x06003EC2 RID: 16066 RVA: 0x000FB198 File Offset: 0x000F9398
		public List<images> Images
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

		// Token: 0x06003EC3 RID: 16067 RVA: 0x000FB1C8 File Offset: 0x000F93C8
		public MediaViewModel()
		{
			this.OrderService = Bootstrapper.Container.Resolve<IOrderService>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
		}

		// Token: 0x06003EC4 RID: 16068 RVA: 0x000FB20C File Offset: 0x000F940C
		public MediaViewModel(int repairId, workshop repair) : this()
		{
			base.SetViewName("Repair", "Media", repairId);
			base.RepairId = repairId;
			base.InitLockCard(repairId);
			base.Repair = repair;
			this.LoadData();
		}

		// Token: 0x06003EC5 RID: 16069 RVA: 0x000FB24C File Offset: 0x000F944C
		private void LoadData()
		{
			MediaViewModel.<LoadData>d__9 <LoadData>d__;
			<LoadData>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadData>d__.<>4__this = this;
			<LoadData>d__.<>1__state = -1;
			<LoadData>d__.<>t__builder.Start<MediaViewModel.<LoadData>d__9>(ref <LoadData>d__);
		}

		// Token: 0x06003EC6 RID: 16070 RVA: 0x000FB284 File Offset: 0x000F9484
		private Task LoadImages()
		{
			MediaViewModel.<LoadImages>d__10 <LoadImages>d__;
			<LoadImages>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadImages>d__.<>4__this = this;
			<LoadImages>d__.<>1__state = -1;
			<LoadImages>d__.<>t__builder.Start<MediaViewModel.<LoadImages>d__10>(ref <LoadImages>d__);
			return <LoadImages>d__.<>t__builder.Task;
		}

		// Token: 0x06003EC7 RID: 16071 RVA: 0x000FB2C8 File Offset: 0x000F94C8
		[Command]
		public void EditPhoto()
		{
			MediaViewModel.<EditPhoto>d__11 <EditPhoto>d__;
			<EditPhoto>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<EditPhoto>d__.<>4__this = this;
			<EditPhoto>d__.<>1__state = -1;
			<EditPhoto>d__.<>t__builder.Start<MediaViewModel.<EditPhoto>d__11>(ref <EditPhoto>d__);
		}

		// Token: 0x06003EC8 RID: 16072 RVA: 0x0007E5F4 File Offset: 0x0007C7F4
		public bool CanEditPhoto()
		{
			return true;
		}

		// Token: 0x06003EC9 RID: 16073 RVA: 0x000FB300 File Offset: 0x000F9500
		[Command]
		public void PrinImage(object obj)
		{
			BitmapImage bitmapImage = ConvertersStack.ByteArrayToImage((byte[])obj);
			DrawingVisual drawingVisual = new DrawingVisual();
			DrawingContext drawingContext = drawingVisual.RenderOpen();
			drawingContext.DrawImage(bitmapImage, new Rect
			{
				Width = bitmapImage.Width,
				Height = bitmapImage.Height
			});
			drawingContext.Close();
			PrintDialog printDialog = new PrintDialog();
			bool? flag = printDialog.ShowDialog();
			if (flag.GetValueOrDefault() & flag != null)
			{
				printDialog.PrintVisual(drawingVisual, "Image");
			}
		}

		// Token: 0x06003ECA RID: 16074 RVA: 0x000FB384 File Offset: 0x000F9584
		public bool CanPrinImage(object obj)
		{
			return obj is byte[];
		}

		// Token: 0x06003ECB RID: 16075 RVA: 0x000FB39C File Offset: 0x000F959C
		[Command]
		public void SaveImage(object obj)
		{
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
						fileStream.Write((byte[])obj, 0, ((byte[])obj).Length);
					}
				}
			}
			catch (Exception ex)
			{
				this._toasterService.Error(ex.Message);
			}
		}

		// Token: 0x06003ECC RID: 16076 RVA: 0x000FB384 File Offset: 0x000F9584
		public bool CanSaveImage(object obj)
		{
			return obj is byte[];
		}

		// Token: 0x06003ECD RID: 16077 RVA: 0x000FB444 File Offset: 0x000F9644
		public void ImagesCallBack(List<int> imageIds, int itemId)
		{
			MediaViewModel.<ImagesCallBack>d__17 <ImagesCallBack>d__;
			<ImagesCallBack>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<ImagesCallBack>d__.<>4__this = this;
			<ImagesCallBack>d__.imageIds = imageIds;
			<ImagesCallBack>d__.itemId = itemId;
			<ImagesCallBack>d__.<>1__state = -1;
			<ImagesCallBack>d__.<>t__builder.Start<MediaViewModel.<ImagesCallBack>d__17>(ref <ImagesCallBack>d__);
		}

		// Token: 0x04002936 RID: 10550
		protected IOrderService OrderService;

		// Token: 0x04002937 RID: 10551
		private readonly IToasterService _toasterService;

		// Token: 0x04002938 RID: 10552
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04002939 RID: 10553
		[CompilerGenerated]
		private List<images> <Images>k__BackingField;

		// Token: 0x02000844 RID: 2116
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadData>d__9 : IAsyncStateMachine
		{
			// Token: 0x06003ECE RID: 16078 RVA: 0x000FB48C File Offset: 0x000F968C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				MediaViewModel mediaViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = mediaViewModel.LoadImages().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, MediaViewModel.<LoadData>d__9>(ref awaiter, ref this);
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
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003ECF RID: 16079 RVA: 0x000FB540 File Offset: 0x000F9740
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400293A RID: 10554
			public int <>1__state;

			// Token: 0x0400293B RID: 10555
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400293C RID: 10556
			public MediaViewModel <>4__this;

			// Token: 0x0400293D RID: 10557
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000845 RID: 2117
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadImages>d__10 : IAsyncStateMachine
		{
			// Token: 0x06003ED0 RID: 16080 RVA: 0x000FB55C File Offset: 0x000F975C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				MediaViewModel mediaViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<images>> awaiter;
					if (num != 0)
					{
						mediaViewModel.ShowWait();
						awaiter = mediaViewModel.OrderService.GetImages(mediaViewModel.RepairId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<images>>, MediaViewModel.<LoadImages>d__10>(ref awaiter, ref this);
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
					mediaViewModel.Images = result;
					mediaViewModel.HideWait();
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

			// Token: 0x06003ED1 RID: 16081 RVA: 0x000FB630 File Offset: 0x000F9830
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400293E RID: 10558
			public int <>1__state;

			// Token: 0x0400293F RID: 10559
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002940 RID: 10560
			public MediaViewModel <>4__this;

			// Token: 0x04002941 RID: 10561
			private TaskAwaiter<List<images>> <>u__1;
		}

		// Token: 0x02000846 RID: 2118
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <EditPhoto>d__11 : IAsyncStateMachine
		{
			// Token: 0x06003ED2 RID: 16082 RVA: 0x000FB64C File Offset: 0x000F984C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				MediaViewModel mediaViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						mediaViewModel.ShowWait();
						this.<vm>5__2 = Bootstrapper.Container.Resolve<PhotoViewAddModel>();
						this.<vm>5__2.SetParentViewModel(mediaViewModel);
						this.<vm>5__2.SetLimit(Auth.Config.rep_img_limit);
						this.<vm>5__2.SetId(mediaViewModel.RepairId);
						awaiter = this.<vm>5__2.LoadData(mediaViewModel.RepairId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, MediaViewModel.<EditPhoto>d__11>(ref awaiter, ref this);
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
					mediaViewModel.HideWait();
					mediaViewModel._windowedDocumentService.ShowNewDocument("PhotoAddView", this.<vm>5__2, null, null);
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<vm>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<vm>5__2 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003ED3 RID: 16083 RVA: 0x000FB784 File Offset: 0x000F9984
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002942 RID: 10562
			public int <>1__state;

			// Token: 0x04002943 RID: 10563
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04002944 RID: 10564
			public MediaViewModel <>4__this;

			// Token: 0x04002945 RID: 10565
			private PhotoViewAddModel <vm>5__2;

			// Token: 0x04002946 RID: 10566
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000847 RID: 2119
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ImagesCallBack>d__17 : IAsyncStateMachine
		{
			// Token: 0x06003ED4 RID: 16084 RVA: 0x000FB7A0 File Offset: 0x000F99A0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				MediaViewModel mediaViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							this.<>1__state = -1;
							goto IL_E0;
						}
						mediaViewModel.ShowWait();
						awaiter = mediaViewModel.OrderService.UpdateImageIds(this.itemId, this.imageIds).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, MediaViewModel.<ImagesCallBack>d__17>(ref awaiter, ref this);
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
					mediaViewModel.HideWait();
					awaiter = mediaViewModel.LoadImages().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, MediaViewModel.<ImagesCallBack>d__17>(ref awaiter, ref this);
						return;
					}
					IL_E0:
					awaiter.GetResult();
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

			// Token: 0x06003ED5 RID: 16085 RVA: 0x000FB8D0 File Offset: 0x000F9AD0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002947 RID: 10567
			public int <>1__state;

			// Token: 0x04002948 RID: 10568
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04002949 RID: 10569
			public MediaViewModel <>4__this;

			// Token: 0x0400294A RID: 10570
			public int itemId;

			// Token: 0x0400294B RID: 10571
			public List<int> imageIds;

			// Token: 0x0400294C RID: 10572
			private TaskAwaiter <>u__1;
		}
	}
}
