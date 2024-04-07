using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ASC
{
	// Token: 0x02000094 RID: 148
	public partial class CgsImageViewer : UserControl
	{
		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x0600124A RID: 4682 RVA: 0x00021FF8 File Offset: 0x000201F8
		// (set) Token: 0x0600124B RID: 4683 RVA: 0x0002200C File Offset: 0x0002020C
		public BitmapImage CurrentImage
		{
			get
			{
				return this._currentImage;
			}
			set
			{
				if (this._currentImage != value)
				{
					this._currentImage = value;
					this.imgCurrent.Source = this._currentImage;
				}
			}
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x0600124C RID: 4684 RVA: 0x0002203C File Offset: 0x0002023C
		// (set) Token: 0x0600124D RID: 4685 RVA: 0x00022050 File Offset: 0x00020250
		public string CurrentImagePath
		{
			get
			{
				return this._currentImagePath;
			}
			set
			{
				if (this._currentImagePath != value)
				{
					this._currentImagePath = value;
					this.CurrentImage = new BitmapImage(new Uri(this._currentImagePath));
				}
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x0600124E RID: 4686 RVA: 0x00022088 File Offset: 0x00020288
		// (set) Token: 0x0600124F RID: 4687 RVA: 0x0002209C File Offset: 0x0002029C
		public double ZoomLevel
		{
			get
			{
				return this._zoomLevel;
			}
			set
			{
				this._zoomLevel = value;
				this.IsFit = (this._zoomLevel == 1.0);
				if (this.panZoomViewer.IsLoaded)
				{
					Point point = new Point(base.ActualWidth / 2.0, base.ActualHeight / 2.0);
					this.panZoomViewer.DoZoomPercent(this._zoomLevel, point, point);
				}
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06001250 RID: 4688 RVA: 0x00022110 File Offset: 0x00020310
		public double ViewableWidth
		{
			get
			{
				if (!this.IsHeightWidthSwitched)
				{
					goto IL_A4;
				}
				double num = base.ActualWidth - (this.MainBorder.BorderThickness.Left + this.MainBorder.BorderThickness.Right);
				IL_61:
				double num2 = num;
				int num3 = (num2 >= 0.0) ? 901692145 : 1945942324;
				IL_85:
				switch ((num3 ^ 1047793236) % 4)
				{
				case 0:
					return 0.0;
				case 2:
					IL_A4:
					num3 = 2049452039;
					goto IL_85;
				case 3:
					num = base.ActualHeight - (this.spnlControlBar.ActualHeight + this.MainBorder.BorderThickness.Top);
					goto IL_61;
				}
				return num2;
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06001251 RID: 4689 RVA: 0x000221D4 File Offset: 0x000203D4
		public double ViewableHeight
		{
			get
			{
				if (!this.IsHeightWidthSwitched)
				{
					goto IL_A4;
				}
				double num = base.ActualHeight - (this.spnlControlBar.ActualHeight + this.MainBorder.BorderThickness.Top);
				IL_61:
				double num2 = num;
				int num3 = (num2 >= 0.0) ? 2015138504 : 1411643811;
				IL_85:
				switch ((num3 ^ 941747151) % 4)
				{
				case 0:
					return 0.0;
				case 1:
					num = base.ActualWidth - (this.MainBorder.BorderThickness.Left + this.MainBorder.BorderThickness.Right);
					goto IL_61;
				case 2:
					IL_A4:
					num3 = 1075068746;
					goto IL_85;
				}
				return num2;
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06001252 RID: 4690 RVA: 0x00022298 File Offset: 0x00020498
		private double ImageWidth
		{
			get
			{
				if (this.CurrentImage == null)
				{
					return 0.0;
				}
				if (this.IsHeightWidthSwitched)
				{
					return this.CurrentImage.Width;
				}
				return this.CurrentImage.Height;
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06001253 RID: 4691 RVA: 0x000222D8 File Offset: 0x000204D8
		private double ImageHeight
		{
			get
			{
				if (this.CurrentImage == null)
				{
					return 0.0;
				}
				if (!this.IsHeightWidthSwitched)
				{
					return this.CurrentImage.Width;
				}
				return this.CurrentImage.Height;
			}
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06001254 RID: 4692 RVA: 0x00022318 File Offset: 0x00020518
		private bool IsHeightWidthSwitched
		{
			get
			{
				return this._rotationAngle == 0.0 || Math.Abs(this._rotationAngle) / 90.0 % 2.0 != 1.0;
			}
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x00022368 File Offset: 0x00020568
		public CgsImageViewer()
		{
			this.InitializeComponent();
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x00022388 File Offset: 0x00020588
		private void UserControl_Loaded(object sender, RoutedEventArgs e)
		{
			this.ScaleToFit();
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x0002239C File Offset: 0x0002059C
		private void UserControl_SizeChanged(object sender, SizeChangedEventArgs e)
		{
			if (this.IsFit)
			{
				this.ScaleToFit();
			}
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x000223B8 File Offset: 0x000205B8
		private void btnFitSize_Click(object sender, RoutedEventArgs e)
		{
			this.sldZoomLevel.Value = 1.0;
			this.ScaleToFit();
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x000223E0 File Offset: 0x000205E0
		private void btnRotateLeft_Click(object sender, RoutedEventArgs e)
		{
			this.RotateLeft();
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x000223F4 File Offset: 0x000205F4
		private void btnRotateRight_Click(object sender, RoutedEventArgs e)
		{
			this.RotateRight();
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x00022408 File Offset: 0x00020608
		private void btnSelectZoom_Click(object sender, RoutedEventArgs e)
		{
			this.popupZoomLevel.VerticalOffset = -15.0;
			this.popupZoomLevel.HorizontalOffset = -8.0;
			this.popupZoomLevel.StaysOpen = false;
			this.popupZoomLevel.IsOpen = true;
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x00022458 File Offset: 0x00020658
		private void sldZoomLevel_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			this.ZoomLevel = this.sldZoomLevel.Value;
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x00022478 File Offset: 0x00020678
		public void ScaleToFit()
		{
			if (this.panZoomViewer.IsLoaded)
			{
				this.panZoomViewer.Reset();
			}
			this.imgCurrent.ClearValue(FrameworkElement.WidthProperty);
			this.imgCurrent.ClearValue(FrameworkElement.HeightProperty);
			if (this.ImageHeight > this.ViewableHeight)
			{
				this.imgCurrent.Height = this.ViewableHeight;
			}
			if (this.ImageWidth > this.ViewableWidth)
			{
				this.imgCurrent.Width = this.ViewableWidth;
			}
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x000224FC File Offset: 0x000206FC
		public void RotateLeft()
		{
			this._rotationAngle -= 90.0;
			this.imgCurrent.LayoutTransform = new RotateTransform(this._rotationAngle);
			this.ZoomLevel = 0.0;
			this.ScaleToFit();
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x0002254C File Offset: 0x0002074C
		public void RotateRight()
		{
			this._rotationAngle += 90.0;
			this.imgCurrent.LayoutTransform = new RotateTransform(this._rotationAngle);
			this.ZoomLevel = 0.0;
			this.ScaleToFit();
		}

		// Token: 0x040008A1 RID: 2209
		private BitmapImage _currentImage;

		// Token: 0x040008A2 RID: 2210
		private string _currentImagePath;

		// Token: 0x040008A3 RID: 2211
		private bool IsFit = true;

		// Token: 0x040008A4 RID: 2212
		private double _zoomLevel;

		// Token: 0x040008A5 RID: 2213
		private double _rotationAngle;
	}
}
