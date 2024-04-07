using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media.Imaging;
using ASC.Models;
using DevExpress.Xpf.Core;

namespace ASC
{
	// Token: 0x020000BC RID: 188
	public class PhotoView : ThemedWindow, IComponentConnector
	{
		// Token: 0x0600134D RID: 4941 RVA: 0x0002A920 File Offset: 0x00028B20
		public PhotoView(BitmapImage image)
		{
			this.InitializeComponent();
			this.cgsImageViewer.CurrentImage = image;
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x0002A948 File Offset: 0x00028B48
		public PhotoView(int imageId)
		{
			this.InitializeComponent();
			GenericModel genericModel = new GenericModel();
			try
			{
				byte[] imageData = (from i in genericModel._context.images
				where i.id == imageId
				select i.img).FirstOrDefault<byte[]>();
				this.cgsImageViewer.CurrentImage = ConvertersStack.ByteArrayToImage(imageData);
			}
			catch (Exception)
			{
				DXMessageBox.Show("Load image fail");
			}
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x0002AA58 File Offset: 0x00028C58
		private void PhotoView_OnKeyUp(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Escape)
			{
				base.Close();
			}
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x0002AA78 File Offset: 0x00028C78
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/ASC;component/photoview/photoview.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x0002AAA8 File Offset: 0x00028CA8
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				((PhotoView)target).KeyUp += this.PhotoView_OnKeyUp;
				return;
			}
			if (connectionId != 2)
			{
				this._contentLoaded = true;
				return;
			}
			this.cgsImageViewer = (CgsImageViewer)target;
		}

		// Token: 0x0400094E RID: 2382
		internal CgsImageViewer cgsImageViewer;

		// Token: 0x0400094F RID: 2383
		private bool _contentLoaded;

		// Token: 0x020000BD RID: 189
		[CompilerGenerated]
		private sealed class <>c__DisplayClass1_0
		{
			// Token: 0x06001352 RID: 4946 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass1_0()
			{
			}

			// Token: 0x04000950 RID: 2384
			public int imageId;
		}

		// Token: 0x020000BE RID: 190
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001353 RID: 4947 RVA: 0x0002AAEC File Offset: 0x00028CEC
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06001354 RID: 4948 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x04000951 RID: 2385
			public static readonly PhotoView.<>c <>9 = new PhotoView.<>c();
		}
	}
}
