using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media.Animation;
using DevExpress.Xpf.Charts;
using DevExpress.Xpf.Grid;

namespace ASC.Charts.VisitSource
{
	// Token: 0x0200027B RID: 635
	public partial class VisitSourceView : UserControl
	{
		// Token: 0x060021CA RID: 8650 RVA: 0x00062690 File Offset: 0x00060890
		private bool IsClick(DateTime mouseUpTime)
		{
			return (mouseUpTime - this.mouseDownTime).TotalMilliseconds < 200.0;
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x000626BC File Offset: 0x000608BC
		public VisitSourceView()
		{
			this.InitializeComponent();
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x000626D8 File Offset: 0x000608D8
		private double CalcAngle(Point p1, Point p2)
		{
			Point point = new Point(this.chart.Diagram.ActualWidth / 2.0, this.chart.ActualHeight / 2.0);
			Point point2 = new Point(p1.X - point.X, p1.Y - point.Y);
			Point point3 = new Point(p2.X - point.X, p2.Y - point.Y);
			double num = Math.Atan2(point2.X, point2.Y);
			double num2 = (Math.Atan2(point3.X, point3.Y) - num) * 180.0 / 6.283185307179586;
			if (num2 > 90.0)
			{
				num2 = 180.0 - num2;
			}
			else if (num2 < -90.0)
			{
				num2 = 180.0 + num2;
			}
			return num2;
		}

		// Token: 0x060021CD RID: 8653 RVA: 0x000627E0 File Offset: 0x000609E0
		private void chart_MouseUp(object sender, MouseButtonEventArgs e)
		{
			ChartHitInfo chartHitInfo = this.chart.CalcHitInfo(e.GetPosition(this.chart));
			this.rotate = false;
			if (chartHitInfo != null && chartHitInfo.SeriesPoint != null && this.IsClick(DateTime.Now))
			{
				double explodedDistance = PieSeries.GetExplodedDistance(chartHitInfo.SeriesPoint);
				Storyboard storyboard = new Storyboard();
				DoubleAnimation doubleAnimation = new DoubleAnimation
				{
					Duration = new Duration(new TimeSpan(0, 0, 0, 0, 300)),
					To = new double?((explodedDistance > 0.0) ? 0.0 : 0.3)
				};
				storyboard.Children.Add(doubleAnimation);
				Storyboard.SetTarget(doubleAnimation, chartHitInfo.SeriesPoint);
				Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(PieSeries.ExplodedDistanceProperty));
				storyboard.Begin();
				return;
			}
		}

		// Token: 0x060021CE RID: 8654 RVA: 0x000628B8 File Offset: 0x00060AB8
		private void chart_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.mouseDownTime = DateTime.Now;
			Point position = e.GetPosition(this.chart);
			ChartHitInfo chartHitInfo = this.chart.CalcHitInfo(position);
			if (chartHitInfo != null && chartHitInfo.SeriesPoint != null)
			{
				this.rotate = true;
				this.startPosition = position;
			}
		}

		// Token: 0x060021CF RID: 8655 RVA: 0x00062904 File Offset: 0x00060B04
		private void chart_MouseMove(object sender, MouseEventArgs e)
		{
			Point position = e.GetPosition(this.chart);
			if (this.chart.CalcHitInfo(position) == null)
			{
				return;
			}
			if (this.rotate && !this.IsClick(DateTime.Now))
			{
				PieSeries2D pieSeries2D = this.chart.Diagram.Series[0] as PieSeries2D;
				double num = this.CalcAngle(this.startPosition, position);
				num *= ((pieSeries2D.SweepDirection == PieSweepDirection.Clockwise) ? -1.0 : 1.0);
				if (Math.Abs(this.slRotation + num) < 360.0)
				{
					this.slRotation += num;
				}
				else if (this.slRotation + num <= 360.0)
				{
					this.slRotation = 360.0;
				}
				else
				{
					this.slRotation = -360.0;
				}
				this.startPosition = position;
			}
		}

		// Token: 0x060021D0 RID: 8656 RVA: 0x000629F4 File Offset: 0x00060BF4
		private void ChartsDemoModule_ModuleAppear(object sender, RoutedEventArgs e)
		{
			this.chart.Animate();
		}

		// Token: 0x060021D1 RID: 8657 RVA: 0x00062A0C File Offset: 0x00060C0C
		private void rblSweepDirection_SelectedIndexChanged(object sender, RoutedEventArgs e)
		{
			if (this.chart != null)
			{
				this.chart.Animate();
			}
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x00062A2C File Offset: 0x00060C2C
		private void chart_QueryChartCursor(object sender, QueryChartCursorEventArgs e)
		{
			ChartHitInfo chartHitInfo = this.chart.CalcHitInfo(e.Position);
			if (chartHitInfo != null && chartHitInfo.SeriesPoint != null)
			{
				e.Cursor = Cursors.Hand;
			}
		}

		// Token: 0x04001148 RID: 4424
		private const int clickDelta = 200;

		// Token: 0x04001149 RID: 4425
		private bool rotate;

		// Token: 0x0400114A RID: 4426
		private Point startPosition;

		// Token: 0x0400114B RID: 4427
		private DateTime mouseDownTime;

		// Token: 0x0400114C RID: 4428
		private double slRotation;
	}
}
