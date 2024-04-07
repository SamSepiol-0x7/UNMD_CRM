using System;
using System.IO;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using DevExpress.Xpf.Core.Native;
using DevExpress.Xpf.Editors;
using Microsoft.Win32;

namespace ASC.Extensions
{
	// Token: 0x02000B69 RID: 2921
	public class ImageEditEx : ImageEdit
	{
		// Token: 0x170014FD RID: 5373
		// (get) Token: 0x060051BA RID: 20922 RVA: 0x0015F3C8 File Offset: 0x0015D5C8
		// (set) Token: 0x060051BB RID: 20923 RVA: 0x0015F3E8 File Offset: 0x0015D5E8
		public int MaxFileSize
		{
			get
			{
				return (int)base.GetValue(ImageEditEx.MaxFileSizeProperty);
			}
			set
			{
				base.SetValue(ImageEditEx.MaxFileSizeProperty, value);
			}
		}

		// Token: 0x060051BC RID: 20924 RVA: 0x0015F408 File Offset: 0x0015D608
		protected override void LoadCore()
		{
			if (base.Image == null)
			{
				return;
			}
			ImageSource imageSource = this.LoadImage();
			if (imageSource != null)
			{
				base.EditStrategy.SetImage(imageSource);
			}
		}

		// Token: 0x060051BD RID: 20925 RVA: 0x0015F434 File Offset: 0x0015D634
		private ImageSource LoadImage()
		{
			if (BrowserInteropHelper.IsBrowserHosted)
			{
				return null;
			}
			ImageSource result;
			try
			{
				result = this.LoadImageCore();
			}
			catch (Exception ex)
			{
				if (ex is NotSupportedException)
				{
					MessageBoxHelper.ShowError(EditorLocalizer.GetString(EditorStringId.ImageEdit_InvalidFormatMessage), EditorLocalizer.GetString(EditorStringId.CaptionError), MessageBoxButton.OK);
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060051BE RID: 20926 RVA: 0x0015F484 File Offset: 0x0015D684
		private ImageSource LoadImageCore()
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = EditorLocalizer.GetString(EditorStringId.ImageEdit_OpenFileFilter)
			};
			bool? flag = openFileDialog.ShowDialog();
			if (!(flag.GetValueOrDefault() & flag != null))
			{
				return null;
			}
			FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
			if (this.MaxFileSize == 0)
			{
				this.MaxFileSize = 2097152;
			}
			if (fileInfo.Length <= (long)this.MaxFileSize)
			{
				ImageSource result;
				using (Stream stream = openFileDialog.OpenFile())
				{
					result = ImageHelper.CreateImageFromStream(new MemoryStream(stream.GetDataFromStream()));
				}
				return result;
			}
			MessageBoxHelper.ShowError(string.Format("Size is greater than {0} bytes", this.MaxFileSize), EditorLocalizer.GetString(EditorStringId.CaptionError), MessageBoxButton.OK);
			return null;
		}

		// Token: 0x060051BF RID: 20927 RVA: 0x0015F548 File Offset: 0x0015D748
		public ImageEditEx()
		{
		}

		// Token: 0x060051C0 RID: 20928 RVA: 0x0015F55C File Offset: 0x0015D75C
		// Note: this type is marked as 'beforefieldinit'.
		static ImageEditEx()
		{
		}

		// Token: 0x040035B7 RID: 13751
		public static readonly DependencyProperty MaxFileSizeProperty = DependencyProperty.Register("MaxFileSize", typeof(int), typeof(ImageEditEx), null);
	}
}
