using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using ASC.Interfaces;
using ASC.Services.Abstract;
using Autofac;
using DevExpress.DataProcessing;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Editors.Internal;
using Microsoft.Win32;

namespace ASC.ViewModels
{
	// Token: 0x020003F0 RID: 1008
	public class ImagesAddlViewModel : CollectionViewModel<images>
	{
		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x060028EE RID: 10478 RVA: 0x0007F1F8 File Offset: 0x0007D3F8
		// (set) Token: 0x060028EF RID: 10479 RVA: 0x0007F20C File Offset: 0x0007D40C
		public object Owner
		{
			[CompilerGenerated]
			get
			{
				return this.<Owner>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<Owner>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 615555015;
				IL_13:
				switch ((num ^ 1343367160) % 4)
				{
				case 0:
					goto IL_0E;
				case 2:
					IL_32:
					this.<Owner>k__BackingField = value;
					this.RaisePropertyChanged("Owner");
					num = 999941589;
					goto IL_13;
				case 3:
					return;
				}
			}
		}

		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x060028F0 RID: 10480 RVA: 0x0007F268 File Offset: 0x0007D468
		// (set) Token: 0x060028F1 RID: 10481 RVA: 0x0007F27C File Offset: 0x0007D47C
		public int CurrentImage
		{
			[CompilerGenerated]
			get
			{
				return this.<CurrentImage>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CurrentImage>k__BackingField == value)
				{
					return;
				}
				this.<CurrentImage>k__BackingField = value;
				this.RaisePropertyChanged("CurrentImage");
			}
		}

		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x060028F2 RID: 10482 RVA: 0x0007F2A8 File Offset: 0x0007D4A8
		// (set) Token: 0x060028F3 RID: 10483 RVA: 0x0007F2BC File Offset: 0x0007D4BC
		public string ImgNumInfo
		{
			[CompilerGenerated]
			get
			{
				return this.<ImgNumInfo>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<ImgNumInfo>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<ImgNumInfo>k__BackingField = value;
				this.RaisePropertyChanged("ImgNumInfo");
			}
		}

		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x060028F4 RID: 10484 RVA: 0x0007F2EC File Offset: 0x0007D4EC
		// (set) Token: 0x060028F5 RID: 10485 RVA: 0x0007F300 File Offset: 0x0007D500
		public images Image
		{
			[CompilerGenerated]
			get
			{
				return this.<Image>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Image>k__BackingField, value))
				{
					return;
				}
				this.<Image>k__BackingField = value;
				this.RaisePropertyChanged("Image");
			}
		}

		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x060028F6 RID: 10486 RVA: 0x0007F330 File Offset: 0x0007D530
		// (set) Token: 0x060028F7 RID: 10487 RVA: 0x0007F344 File Offset: 0x0007D544
		public int MaxImages
		{
			[CompilerGenerated]
			get
			{
				return this.<MaxImages>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<MaxImages>k__BackingField == value)
				{
					return;
				}
				this.<MaxImages>k__BackingField = value;
				this.RaisePropertyChanged("MaxImages");
			}
		}

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x060028F8 RID: 10488 RVA: 0x0007F370 File Offset: 0x0007D570
		// (set) Token: 0x060028F9 RID: 10489 RVA: 0x0007F384 File Offset: 0x0007D584
		public bool LoadingShown
		{
			[CompilerGenerated]
			get
			{
				return this.<LoadingShown>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<LoadingShown>k__BackingField == value)
				{
					return;
				}
				this.<LoadingShown>k__BackingField = value;
				this.RaisePropertyChanged("LoadingShown");
			}
		}

		// Token: 0x060028FA RID: 10490 RVA: 0x0007F3B0 File Offset: 0x0007D5B0
		public ImagesAddlViewModel()
		{
			this.ImageService = Bootstrapper.Container.Resolve<IImageService>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this.MaxImages = Auth.Config.item_img_limit;
			base.SetItems(new List<images>
			{
				new images
				{
					item_id = this._productId
				}
			});
			this.SetImgNumInfo();
		}

		// Token: 0x060028FB RID: 10491 RVA: 0x0007F424 File Offset: 0x0007D624
		public ImagesAddlViewModel(int itemId) : this()
		{
			this._productId = new int?(itemId);
		}

		// Token: 0x060028FC RID: 10492 RVA: 0x0007F444 File Offset: 0x0007D644
		private void RaiseWorking()
		{
			if (this.WorkingEventHandler != null)
			{
				this.WorkingEventHandler(this, EventArgs.Empty);
			}
		}

		// Token: 0x060028FD RID: 10493 RVA: 0x0007F46C File Offset: 0x0007D66C
		private void SetLoadingShown(bool value)
		{
			this.LoadingShown = value;
			base.RaiseCanExecuteChanged(() => this.PrevImage());
			base.RaiseCanExecuteChanged(() => this.NextImage());
			this.RaiseWorking();
		}

		// Token: 0x060028FE RID: 10494 RVA: 0x00023150 File Offset: 0x00021350
		public override void OnLoad()
		{
		}

		// Token: 0x060028FF RID: 10495 RVA: 0x00023150 File Offset: 0x00021350
		public override void OnUnload()
		{
		}

		// Token: 0x06002900 RID: 10496 RVA: 0x0007F4FC File Offset: 0x0007D6FC
		[Command]
		public void ImageValueChanged()
		{
			ImagesAddlViewModel.<ImageValueChanged>d__35 <ImageValueChanged>d__;
			<ImageValueChanged>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<ImageValueChanged>d__.<>4__this = this;
			<ImageValueChanged>d__.<>1__state = -1;
			<ImageValueChanged>d__.<>t__builder.Start<ImagesAddlViewModel.<ImageValueChanged>d__35>(ref <ImageValueChanged>d__);
		}

		// Token: 0x06002901 RID: 10497 RVA: 0x0007F534 File Offset: 0x0007D734
		public bool CanImageValueChanged()
		{
			return this.Image != null;
		}

		// Token: 0x06002902 RID: 10498 RVA: 0x0007F54C File Offset: 0x0007D74C
		private Task OnImageChange()
		{
			ImagesAddlViewModel.<OnImageChange>d__37 <OnImageChange>d__;
			<OnImageChange>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<OnImageChange>d__.<>4__this = this;
			<OnImageChange>d__.<>1__state = -1;
			<OnImageChange>d__.<>t__builder.Start<ImagesAddlViewModel.<OnImageChange>d__37>(ref <OnImageChange>d__);
			return <OnImageChange>d__.<>t__builder.Task;
		}

		// Token: 0x06002903 RID: 10499 RVA: 0x0007F590 File Offset: 0x0007D790
		[Command]
		public void PrevImage()
		{
			int currentImage = this.CurrentImage - 1;
			this.CurrentImage = currentImage;
			this.SetAllowSave(false);
			this.SetImage(this.CurrentImage);
			this.SetAllowSave(true);
		}

		// Token: 0x06002904 RID: 10500 RVA: 0x0007F5C8 File Offset: 0x0007D7C8
		public bool CanPrevImage()
		{
			return this.CurrentImage > 0 && !this.LoadingShown;
		}

		// Token: 0x06002905 RID: 10501 RVA: 0x0007F5EC File Offset: 0x0007D7EC
		[Command]
		public void NextImage()
		{
			int currentImage = this.CurrentImage + 1;
			this.CurrentImage = currentImage;
			this.SetAllowSave(false);
			this.SetImage(this.CurrentImage);
			this.SetAllowSave(true);
		}

		// Token: 0x06002906 RID: 10502 RVA: 0x0007F624 File Offset: 0x0007D824
		public bool CanNextImage()
		{
			return this.CurrentImage < this.MaxImages - 1 && !this.LoadingShown;
		}

		// Token: 0x06002907 RID: 10503 RVA: 0x0007F64C File Offset: 0x0007D84C
		private void SetImage(int index)
		{
			if (base.Items.ElementAtOrDefault(index) == null)
			{
				base.Items.Add(new images
				{
					item_id = this._productId
				});
			}
			this.Image = base.Items[index];
			this.SetImgNumInfo();
		}

		// Token: 0x06002908 RID: 10504 RVA: 0x0007F69C File Offset: 0x0007D89C
		private void SetImgNumInfo()
		{
			this.ImgNumInfo = string.Format("{0} из {1}", this.CurrentImage + 1, this.MaxImages);
		}

		// Token: 0x06002909 RID: 10505 RVA: 0x0007F6D4 File Offset: 0x0007D8D4
		public IEnumerable<int> GetImageIds()
		{
			return (from i in base.Items
			where i.id > 0
			select i.id).ToList<int>();
		}

		// Token: 0x0600290A RID: 10506 RVA: 0x0007F734 File Offset: 0x0007D934
		public void ClearItems()
		{
			ObservableCollection<images> items = base.Items;
			if (items == null)
			{
				return;
			}
			items.Clear();
		}

		// Token: 0x0600290B RID: 10507 RVA: 0x0007F754 File Offset: 0x0007D954
		private void SetAllowSave(bool value)
		{
			ImagesAddlViewModel.<SetAllowSave>d__46 <SetAllowSave>d__;
			<SetAllowSave>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SetAllowSave>d__.<>4__this = this;
			<SetAllowSave>d__.value = value;
			<SetAllowSave>d__.<>1__state = -1;
			<SetAllowSave>d__.<>t__builder.Start<ImagesAddlViewModel.<SetAllowSave>d__46>(ref <SetAllowSave>d__);
		}

		// Token: 0x0600290C RID: 10508 RVA: 0x0007F794 File Offset: 0x0007D994
		private Task UseDelay()
		{
			ImagesAddlViewModel.<UseDelay>d__47 <UseDelay>d__;
			<UseDelay>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<UseDelay>d__.<>1__state = -1;
			<UseDelay>d__.<>t__builder.Start<ImagesAddlViewModel.<UseDelay>d__47>(ref <UseDelay>d__);
			return <UseDelay>d__.<>t__builder.Task;
		}

		// Token: 0x0600290D RID: 10509 RVA: 0x0007F7D0 File Offset: 0x0007D9D0
		public void SetImages(List<int> imagesIds)
		{
			ImagesAddlViewModel.<SetImages>d__48 <SetImages>d__;
			<SetImages>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SetImages>d__.<>4__this = this;
			<SetImages>d__.imagesIds = imagesIds;
			<SetImages>d__.<>1__state = -1;
			<SetImages>d__.<>t__builder.Start<ImagesAddlViewModel.<SetImages>d__48>(ref <SetImages>d__);
		}

		// Token: 0x0600290E RID: 10510 RVA: 0x0007F810 File Offset: 0x0007DA10
		public void SetImages(IEnumerable<images> images)
		{
			this.SetAllowSave(false);
			this.ClearItems();
			if (!images.Any<images>())
			{
				base.Items.Add(new images
				{
					item_id = this._productId
				});
			}
			base.Items.AddRange(images);
			this.CurrentImage = 0;
			this.SetImage(this.CurrentImage);
			this.SetAllowSave(true);
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x0007F874 File Offset: 0x0007DA74
		public bool AnyImages()
		{
			if (base.Items != null)
			{
				return base.Items.Any((images i) => i.id > 0);
			}
			return false;
		}

		// Token: 0x06002910 RID: 10512 RVA: 0x0007F8B8 File Offset: 0x0007DAB8
		[Command]
		public void SelectImages()
		{
			ImagesAddlViewModel.<SelectImages>d__51 <SelectImages>d__;
			<SelectImages>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SelectImages>d__.<>4__this = this;
			<SelectImages>d__.<>1__state = -1;
			<SelectImages>d__.<>t__builder.Start<ImagesAddlViewModel.<SelectImages>d__51>(ref <SelectImages>d__);
		}

		// Token: 0x06002911 RID: 10513 RVA: 0x0007F8F0 File Offset: 0x0007DAF0
		[Command]
		public void TakePicture(ImageEdit control)
		{
			DXWindow dxwindow = new DXWindow();
			dxwindow.Width = (double)350f;
			dxwindow.Height = (double)350f;
			dxwindow.MinHeight = (double)350f;
			dxwindow.MinWidth = (double)350f;
			dxwindow.ShowIcon = false;
			dxwindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
			dxwindow.Title = EditorLocalizer.GetString(EditorStringId.CameraTakePictureCaption);
			TakePictureControl takePictureControl = new TakePictureControl();
			PopupBaseEdit popupOwnerEdit = PopupBaseEdit.GetPopupOwnerEdit(control);
			takePictureControl.SetEditor(control, popupOwnerEdit as PopupImageEdit);
			dxwindow.Content = takePictureControl;
			dxwindow.ShowDialog();
		}

		// Token: 0x06002912 RID: 10514 RVA: 0x0007F974 File Offset: 0x0007DB74
		[CompilerGenerated]
		private images <SelectImages>b__51_0(string s)
		{
			return new images
			{
				img = File.ReadAllBytes(s),
				item_id = this._productId
			};
		}

		// Token: 0x04001686 RID: 5766
		[CompilerGenerated]
		private object <Owner>k__BackingField;

		// Token: 0x04001687 RID: 5767
		protected IImageService ImageService;

		// Token: 0x04001688 RID: 5768
		private IToasterService _toasterService;

		// Token: 0x04001689 RID: 5769
		public EventHandler WorkingEventHandler;

		// Token: 0x0400168A RID: 5770
		[CompilerGenerated]
		private int <CurrentImage>k__BackingField;

		// Token: 0x0400168B RID: 5771
		[CompilerGenerated]
		private string <ImgNumInfo>k__BackingField;

		// Token: 0x0400168C RID: 5772
		[CompilerGenerated]
		private images <Image>k__BackingField;

		// Token: 0x0400168D RID: 5773
		[CompilerGenerated]
		private int <MaxImages>k__BackingField;

		// Token: 0x0400168E RID: 5774
		[CompilerGenerated]
		private bool <LoadingShown>k__BackingField;

		// Token: 0x0400168F RID: 5775
		private bool _allowSave = true;

		// Token: 0x04001690 RID: 5776
		private readonly int? _productId;

		// Token: 0x020003F1 RID: 1009
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ImageValueChanged>d__35 : IAsyncStateMachine
		{
			// Token: 0x06002913 RID: 10515 RVA: 0x0007F9A0 File Offset: 0x0007DBA0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ImagesAddlViewModel imagesAddlViewModel = this.<>4__this;
				try
				{
					ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						imagesAddlViewModel.SetLoadingShown(true);
						if (!imagesAddlViewModel._allowSave)
						{
							goto IL_8F;
						}
						imagesAddlViewModel.SetAllowSave(false);
						awaiter = imagesAddlViewModel.OnImageChange().ConfigureAwait(false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, ImagesAddlViewModel.<ImageValueChanged>d__35>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
						this.<>1__state = -1;
					}
					awaiter.GetResult();
					imagesAddlViewModel.SetAllowSave(true);
					IL_8F:
					imagesAddlViewModel.SetLoadingShown(false);
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

			// Token: 0x06002914 RID: 10516 RVA: 0x0007FA84 File Offset: 0x0007DC84
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001691 RID: 5777
			public int <>1__state;

			// Token: 0x04001692 RID: 5778
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001693 RID: 5779
			public ImagesAddlViewModel <>4__this;

			// Token: 0x04001694 RID: 5780
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x020003F2 RID: 1010
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnImageChange>d__37 : IAsyncStateMachine
		{
			// Token: 0x06002915 RID: 10517 RVA: 0x0007FAA0 File Offset: 0x0007DCA0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ImagesAddlViewModel imagesAddlViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<int> awaiter;
					TaskAwaiter awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<int>);
							this.<>1__state = -1;
							goto IL_145;
						}
						if (imagesAddlViewModel.Image.id <= 0 || imagesAddlViewModel.Image.img == null)
						{
							goto IL_C1;
						}
						awaiter2 = imagesAddlViewModel.ImageService.UpdateImageAsync(imagesAddlViewModel.Image).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ImagesAddlViewModel.<OnImageChange>d__37>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
					}
					awaiter2.GetResult();
					IL_C1:
					if (imagesAddlViewModel.Image.id > 0 && imagesAddlViewModel.Image.img == null)
					{
						imagesAddlViewModel.ImageService.DeleteImage(imagesAddlViewModel.Image.id);
						imagesAddlViewModel.Image.id = 0;
					}
					if (imagesAddlViewModel.Image.id != 0 || imagesAddlViewModel.Image.img == null)
					{
						goto IL_183;
					}
					this.<>7__wrap1 = imagesAddlViewModel.Image;
					awaiter = imagesAddlViewModel.ImageService.CreateImageAsync(imagesAddlViewModel.Image).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, ImagesAddlViewModel.<OnImageChange>d__37>(ref awaiter, ref this);
						return;
					}
					IL_145:
					int result = awaiter.GetResult();
					this.<>7__wrap1.id = result;
					this.<>7__wrap1 = null;
					IL_183:;
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

			// Token: 0x06002916 RID: 10518 RVA: 0x0007FC7C File Offset: 0x0007DE7C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001695 RID: 5781
			public int <>1__state;

			// Token: 0x04001696 RID: 5782
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001697 RID: 5783
			public ImagesAddlViewModel <>4__this;

			// Token: 0x04001698 RID: 5784
			private TaskAwaiter <>u__1;

			// Token: 0x04001699 RID: 5785
			private images <>7__wrap1;

			// Token: 0x0400169A RID: 5786
			private TaskAwaiter<int> <>u__2;
		}

		// Token: 0x020003F3 RID: 1011
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002917 RID: 10519 RVA: 0x0007FC98 File Offset: 0x0007DE98
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06002918 RID: 10520 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06002919 RID: 10521 RVA: 0x0007FCB0 File Offset: 0x0007DEB0
			internal bool <GetImageIds>b__44_0(images i)
			{
				return i.id > 0;
			}

			// Token: 0x0600291A RID: 10522 RVA: 0x0007FCC8 File Offset: 0x0007DEC8
			internal int <GetImageIds>b__44_1(images i)
			{
				return i.id;
			}

			// Token: 0x0600291B RID: 10523 RVA: 0x0007FCB0 File Offset: 0x0007DEB0
			internal bool <AnyImages>b__50_0(images i)
			{
				return i.id > 0;
			}

			// Token: 0x0400169B RID: 5787
			public static readonly ImagesAddlViewModel.<>c <>9 = new ImagesAddlViewModel.<>c();

			// Token: 0x0400169C RID: 5788
			public static Func<images, bool> <>9__44_0;

			// Token: 0x0400169D RID: 5789
			public static Func<images, int> <>9__44_1;

			// Token: 0x0400169E RID: 5790
			public static Func<images, bool> <>9__50_0;
		}

		// Token: 0x020003F4 RID: 1012
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SetAllowSave>d__46 : IAsyncStateMachine
		{
			// Token: 0x0600291C RID: 10524 RVA: 0x0007FCDC File Offset: 0x0007DEDC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ImagesAddlViewModel imagesAddlViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (!this.value)
						{
							imagesAddlViewModel._allowSave = false;
							goto IL_81;
						}
						awaiter = imagesAddlViewModel.UseDelay().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ImagesAddlViewModel.<SetAllowSave>d__46>(ref awaiter, ref this);
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
					imagesAddlViewModel._allowSave = true;
					IL_81:;
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

			// Token: 0x0600291D RID: 10525 RVA: 0x0007FDA8 File Offset: 0x0007DFA8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400169F RID: 5791
			public int <>1__state;

			// Token: 0x040016A0 RID: 5792
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040016A1 RID: 5793
			public bool value;

			// Token: 0x040016A2 RID: 5794
			public ImagesAddlViewModel <>4__this;

			// Token: 0x040016A3 RID: 5795
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020003F5 RID: 1013
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UseDelay>d__47 : IAsyncStateMachine
		{
			// Token: 0x0600291E RID: 10526 RVA: 0x0007FDC4 File Offset: 0x0007DFC4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Delay(300).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ImagesAddlViewModel.<UseDelay>d__47>(ref awaiter, ref this);
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

			// Token: 0x0600291F RID: 10527 RVA: 0x0007FE74 File Offset: 0x0007E074
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040016A4 RID: 5796
			public int <>1__state;

			// Token: 0x040016A5 RID: 5797
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040016A6 RID: 5798
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020003F6 RID: 1014
		[CompilerGenerated]
		private sealed class <>c__DisplayClass48_0
		{
			// Token: 0x06002920 RID: 10528 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass48_0()
			{
			}

			// Token: 0x06002921 RID: 10529 RVA: 0x0007FE90 File Offset: 0x0007E090
			internal Task<List<images>> <SetImages>b__0()
			{
				return this.<>4__this.ImageService.GetImages(this.imagesIds);
			}

			// Token: 0x040016A7 RID: 5799
			public ImagesAddlViewModel <>4__this;

			// Token: 0x040016A8 RID: 5800
			public List<int> imagesIds;
		}

		// Token: 0x020003F7 RID: 1015
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SetImages>d__48 : IAsyncStateMachine
		{
			// Token: 0x06002922 RID: 10530 RVA: 0x0007FEB4 File Offset: 0x0007E0B4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ImagesAddlViewModel imagesAddlViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<images>> awaiter;
					if (num != 0)
					{
						ImagesAddlViewModel.<>c__DisplayClass48_0 CS$<>8__locals1 = new ImagesAddlViewModel.<>c__DisplayClass48_0();
						CS$<>8__locals1.<>4__this = this.<>4__this;
						CS$<>8__locals1.imagesIds = this.imagesIds;
						imagesAddlViewModel.SetLoadingShown(true);
						imagesAddlViewModel.ClearItems();
						awaiter = Task.Run<List<images>>(new Func<Task<List<images>>>(CS$<>8__locals1.<SetImages>b__0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<images>>, ImagesAddlViewModel.<SetImages>d__48>(ref awaiter, ref this);
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
					imagesAddlViewModel.SetImages(result);
					imagesAddlViewModel.SetLoadingShown(false);
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

			// Token: 0x06002923 RID: 10531 RVA: 0x0007FFAC File Offset: 0x0007E1AC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040016A9 RID: 5801
			public int <>1__state;

			// Token: 0x040016AA RID: 5802
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040016AB RID: 5803
			public ImagesAddlViewModel <>4__this;

			// Token: 0x040016AC RID: 5804
			public List<int> imagesIds;

			// Token: 0x040016AD RID: 5805
			private TaskAwaiter<List<images>> <>u__1;
		}

		// Token: 0x020003F8 RID: 1016
		[CompilerGenerated]
		private sealed class <>c__DisplayClass51_0
		{
			// Token: 0x06002924 RID: 10532 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass51_0()
			{
			}

			// Token: 0x06002925 RID: 10533 RVA: 0x0007FFC8 File Offset: 0x0007E1C8
			internal Task<List<int>> <SelectImages>b__1()
			{
				return this.<>4__this.ImageService.CreateImages(this.result);
			}

			// Token: 0x040016AE RID: 5806
			public List<images> result;

			// Token: 0x040016AF RID: 5807
			public ImagesAddlViewModel <>4__this;
		}

		// Token: 0x020003F9 RID: 1017
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SelectImages>d__51 : IAsyncStateMachine
		{
			// Token: 0x06002926 RID: 10534 RVA: 0x0007FFEC File Offset: 0x0007E1EC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ImagesAddlViewModel imagesAddlViewModel = this.<>4__this;
				try
				{
					OpenFileDialog openFileDialog;
					if (num != 0)
					{
						openFileDialog = new OpenFileDialog
						{
							DefaultExt = ".png",
							Filter = "Image Files|*.jpeg; *.png; *.jpg; *.gif",
							Multiselect = true
						};
						bool? flag = openFileDialog.ShowDialog();
						if (!(flag.GetValueOrDefault() & flag != null))
						{
							goto IL_15A;
						}
						imagesAddlViewModel.SetLoadingShown(true);
					}
					try
					{
						TaskAwaiter<List<int>> awaiter;
						if (num != 0)
						{
							this.<>8__1 = new ImagesAddlViewModel.<>c__DisplayClass51_0();
							this.<>8__1.<>4__this = imagesAddlViewModel;
							this.<>8__1.result = (from s in openFileDialog.FileNames.Take(Auth.Config.item_img_limit)
							select new images
							{
								img = File.ReadAllBytes(s),
								item_id = imagesAddlViewModel._productId
							}).ToList<images>();
							awaiter = Task.Run<List<int>>(new Func<Task<List<int>>>(this.<>8__1.<SelectImages>b__1)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<int>>, ImagesAddlViewModel.<SelectImages>d__51>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<int>>);
							this.<>1__state = -1;
						}
						awaiter.GetResult();
						imagesAddlViewModel.SetImages(this.<>8__1.result);
						this.<>8__1 = null;
					}
					catch (Exception ex)
					{
						imagesAddlViewModel.SetLoadingShown(false);
						imagesAddlViewModel._toasterService.Error(ex.Message);
						goto IL_175;
					}
					imagesAddlViewModel.SetLoadingShown(false);
					IL_15A:;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_175:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002927 RID: 10535 RVA: 0x000801B8 File Offset: 0x0007E3B8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040016B0 RID: 5808
			public int <>1__state;

			// Token: 0x040016B1 RID: 5809
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040016B2 RID: 5810
			public ImagesAddlViewModel <>4__this;

			// Token: 0x040016B3 RID: 5811
			private ImagesAddlViewModel.<>c__DisplayClass51_0 <>8__1;

			// Token: 0x040016B4 RID: 5812
			private TaskAwaiter<List<int>> <>u__1;
		}
	}
}
