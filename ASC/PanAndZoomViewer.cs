using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace ASC
{
	// Token: 0x020000B8 RID: 184
	public class PanAndZoomViewer : ContentControl
	{
		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06001320 RID: 4896 RVA: 0x00029ED4 File Offset: 0x000280D4
		// (set) Token: 0x06001321 RID: 4897 RVA: 0x00029EE8 File Offset: 0x000280E8
		public double DefaultZoomFactor
		{
			[CompilerGenerated]
			get
			{
				return this.<DefaultZoomFactor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<DefaultZoomFactor>k__BackingField = value;
			}
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x00029EFC File Offset: 0x000280FC
		public PanAndZoomViewer()
		{
			this.DefaultZoomFactor = 1.4;
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x00029F3C File Offset: 0x0002813C
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this.Setup(this);
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x00029F58 File Offset: 0x00028158
		private void Setup(FrameworkElement control)
		{
			this.source = (VisualTreeHelper.GetChild(this, 0) as FrameworkElement);
			this.translateTransform = new TranslateTransform();
			this.zoomTransform = new ScaleTransform();
			this.transformGroup = new TransformGroup();
			this.transformGroup.Children.Add(this.zoomTransform);
			this.transformGroup.Children.Add(this.translateTransform);
			this.source.RenderTransform = this.transformGroup;
			base.Focusable = true;
			base.KeyDown += this.source_KeyDown;
			base.MouseMove += this.control_MouseMove;
			base.MouseDown += this.source_MouseDown;
			base.MouseUp += this.source_MouseUp;
			base.MouseWheel += this.source_MouseWheel;
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x0002A038 File Offset: 0x00028238
		private void source_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Escape)
			{
				this.Reset();
			}
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x0002A058 File Offset: 0x00028258
		private void source_MouseWheel(object sender, MouseWheelEventArgs e)
		{
			double deltaZoom = this.DefaultZoomFactor;
			if (e.Delta <= 0)
			{
				deltaZoom = 1.0 / this.DefaultZoomFactor;
			}
			Point position = e.GetPosition(this);
			this.DoZoom(deltaZoom, this.transformGroup.Inverse.Transform(position), position);
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x0002A0A8 File Offset: 0x000282A8
		private void source_MouseUp(object sender, MouseButtonEventArgs e)
		{
			if (base.IsMouseCaptured)
			{
				base.Cursor = Cursors.Arrow;
				base.ReleaseMouseCapture();
			}
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x0002A0D0 File Offset: 0x000282D0
		private void source_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.ScreenStartPoint = e.GetPosition(this);
			this.startOffset = new Point(this.translateTransform.X, this.translateTransform.Y);
			base.CaptureMouse();
			base.Cursor = Cursors.ScrollAll;
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x0002A120 File Offset: 0x00028320
		private void control_MouseMove(object sender, MouseEventArgs e)
		{
			if (base.IsMouseCaptured)
			{
				Point position = e.GetPosition(this);
				this.translateTransform.BeginAnimation(TranslateTransform.XProperty, this.CreatePanAnimation(position.X - this.ScreenStartPoint.X + this.startOffset.X), HandoffBehavior.Compose);
				this.translateTransform.BeginAnimation(TranslateTransform.YProperty, this.CreatePanAnimation(position.Y - this.ScreenStartPoint.Y + this.startOffset.Y), HandoffBehavior.Compose);
			}
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x0002A1AC File Offset: 0x000283AC
		private DoubleAnimation CreatePanAnimation(double toValue)
		{
			DoubleAnimation doubleAnimation = new DoubleAnimation(toValue, new Duration(TimeSpan.FromMilliseconds(300.0)));
			doubleAnimation.AccelerationRatio = 0.1;
			doubleAnimation.DecelerationRatio = 0.9;
			doubleAnimation.FillBehavior = FillBehavior.HoldEnd;
			doubleAnimation.Freeze();
			return doubleAnimation;
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x0002A200 File Offset: 0x00028400
		private DoubleAnimation CreateZoomAnimation(double toValue)
		{
			DoubleAnimation doubleAnimation = new DoubleAnimation(toValue, new Duration(TimeSpan.FromMilliseconds(500.0)));
			doubleAnimation.AccelerationRatio = 0.1;
			doubleAnimation.DecelerationRatio = 0.9;
			doubleAnimation.FillBehavior = FillBehavior.HoldEnd;
			doubleAnimation.Freeze();
			return doubleAnimation;
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x0002A254 File Offset: 0x00028454
		public void DoZoom(double deltaZoom, Point mousePosition, Point physicalPosition)
		{
			double num = this.zoomTransform.ScaleX;
			num *= deltaZoom;
			this.translateTransform.BeginAnimation(TranslateTransform.XProperty, this.CreateZoomAnimation(-1.0 * (mousePosition.X * num - physicalPosition.X)));
			this.translateTransform.BeginAnimation(TranslateTransform.YProperty, this.CreateZoomAnimation(-1.0 * (mousePosition.Y * num - physicalPosition.Y)));
			this.zoomTransform.BeginAnimation(ScaleTransform.ScaleXProperty, this.CreateZoomAnimation(num));
			this.zoomTransform.BeginAnimation(ScaleTransform.ScaleYProperty, this.CreateZoomAnimation(num));
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x0002A304 File Offset: 0x00028504
		public void DoZoomPercent(double percentZoom, Point mousePosition, Point physicalPosition)
		{
			this.translateTransform.BeginAnimation(TranslateTransform.XProperty, this.CreateZoomAnimation(-1.0 * (mousePosition.X * percentZoom - physicalPosition.X)));
			this.translateTransform.BeginAnimation(TranslateTransform.YProperty, this.CreateZoomAnimation(-1.0 * (mousePosition.Y * percentZoom - physicalPosition.Y)));
			this.zoomTransform.BeginAnimation(ScaleTransform.ScaleXProperty, this.CreateZoomAnimation(percentZoom));
			this.zoomTransform.BeginAnimation(ScaleTransform.ScaleYProperty, this.CreateZoomAnimation(percentZoom));
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x0002A3A4 File Offset: 0x000285A4
		public void Reset()
		{
			this.translateTransform.BeginAnimation(TranslateTransform.XProperty, this.CreateZoomAnimation(0.0));
			this.translateTransform.BeginAnimation(TranslateTransform.YProperty, this.CreateZoomAnimation(0.0));
			this.zoomTransform.BeginAnimation(ScaleTransform.ScaleXProperty, this.CreateZoomAnimation(1.0));
			this.zoomTransform.BeginAnimation(ScaleTransform.ScaleYProperty, this.CreateZoomAnimation(1.0));
		}

		// Token: 0x0400093A RID: 2362
		[CompilerGenerated]
		private double <DefaultZoomFactor>k__BackingField;

		// Token: 0x0400093B RID: 2363
		private FrameworkElement source;

		// Token: 0x0400093C RID: 2364
		private Point ScreenStartPoint = new Point(0.0, 0.0);

		// Token: 0x0400093D RID: 2365
		private TranslateTransform translateTransform;

		// Token: 0x0400093E RID: 2366
		private ScaleTransform zoomTransform;

		// Token: 0x0400093F RID: 2367
		private TransformGroup transformGroup;

		// Token: 0x04000940 RID: 2368
		private Point startOffset;
	}
}
