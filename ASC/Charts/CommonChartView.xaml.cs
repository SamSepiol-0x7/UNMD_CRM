using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media.Animation;
using DevExpress.Xpf.Charts;
using DevExpress.Xpf.Core;

namespace ASC.Charts
{
	// Token: 0x02000275 RID: 629
	public partial class CommonChartView : UserControl
	{
		// Token: 0x0600217B RID: 8571 RVA: 0x000612B4 File Offset: 0x0005F4B4
		private bool IsClick(DateTime mouseUpTime)
		{
			return (mouseUpTime - this.mouseDownTime).TotalMilliseconds < 200.0;
		}

		// Token: 0x0600217C RID: 8572 RVA: 0x000612E0 File Offset: 0x0005F4E0
		public CommonChartView()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600217D RID: 8573 RVA: 0x000612FC File Offset: 0x0005F4FC
		private double CalcAngle(Point p1, Point p2)
		{
			Point point = new Point(this.chart.Diagram.ActualWidth / 2.0, this.chart.ActualHeight / 2.0);
			Point point2 = new Point(p1.X - point.X, p1.Y - point.Y);
			Point point3 = new Point(p2.X - point.X, p2.Y - point.Y);
			double num = Math.Atan2(point2.X, point2.Y);
			double num2 = (Math.Atan2(point3.X, point3.Y) - num) * 180.0 / 6.283185307179586;
			if (num2 <= 90.0)
			{
				if (num2 < -90.0)
				{
					num2 = 180.0 + num2;
				}
			}
			else
			{
				num2 = 180.0 - num2;
			}
			return num2;
		}

		// Token: 0x0600217E RID: 8574 RVA: 0x00061404 File Offset: 0x0005F604
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

		// Token: 0x0600217F RID: 8575 RVA: 0x000614DC File Offset: 0x0005F6DC
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

		// Token: 0x06002180 RID: 8576 RVA: 0x00061528 File Offset: 0x0005F728
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

		// Token: 0x06002181 RID: 8577 RVA: 0x00061618 File Offset: 0x0005F818
		private void ChartsDemoModule_ModuleAppear(object sender, RoutedEventArgs e)
		{
			this.chart.Animate();
		}

		// Token: 0x06002182 RID: 8578 RVA: 0x00061630 File Offset: 0x0005F830
		private void rblSweepDirection_SelectedIndexChanged(object sender, RoutedEventArgs e)
		{
			if (this.chart != null)
			{
				this.chart.Animate();
			}
		}

		// Token: 0x06002183 RID: 8579 RVA: 0x00061650 File Offset: 0x0005F850
		private void chart_QueryChartCursor(object sender, QueryChartCursorEventArgs e)
		{
			ChartHitInfo chartHitInfo = this.chart.CalcHitInfo(e.Position);
			if (chartHitInfo != null && chartHitInfo.SeriesPoint != null)
			{
				e.Cursor = Cursors.Hand;
			}
		}

		// Token: 0x04001118 RID: 4376
		private const int clickDelta = 200;

		// Token: 0x04001119 RID: 4377
		private bool rotate;

		// Token: 0x0400111A RID: 4378
		private Point startPosition;

		// Token: 0x0400111B RID: 4379
		private DateTime mouseDownTime;

		// Token: 0x0400111C RID: 4380
		private double slRotation;
	}
}
