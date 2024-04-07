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

namespace ASC.Charts.PartsChart
{
	// Token: 0x02000290 RID: 656
	public partial class PartsChartView : UserControl
	{
		// Token: 0x06002252 RID: 8786 RVA: 0x00064558 File Offset: 0x00062758
		private bool IsClick(DateTime mouseUpTime)
		{
			return (mouseUpTime - this.mouseDownTime).TotalMilliseconds < 200.0;
		}

		// Token: 0x06002253 RID: 8787 RVA: 0x00064584 File Offset: 0x00062784
		public PartsChartView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002254 RID: 8788 RVA: 0x000645A0 File Offset: 0x000627A0
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

		// Token: 0x06002255 RID: 8789 RVA: 0x000646A8 File Offset: 0x000628A8
		private void chart_MouseUp(object sender, MouseButtonEventArgs e)
		{
			ChartHitInfo chartHitInfo = this.chart.CalcHitInfo(e.GetPosition(this.chart));
			this.rotate = false;
			if (chartHitInfo != null && chartHitInfo.SeriesPoint != null && this.IsClick(DateTime.Now))
			{
				double explodedDistance = PieSeries.GetExplodedDistance(chartHitInfo.SeriesPoint);
				Storyboard storyboard = new Storyboard();
				DoubleAnimation doubleAnimation = new DoubleAnimation();
				doubleAnimation.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 300));
				doubleAnimation.To = new double?((explodedDistance > 0.0) ? 0.0 : 0.3);
				storyboard.Children.Add(doubleAnimation);
				Storyboard.SetTarget(doubleAnimation, chartHitInfo.SeriesPoint);
				Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(PieSeries.ExplodedDistanceProperty));
				storyboard.Begin();
				return;
			}
		}

		// Token: 0x06002256 RID: 8790 RVA: 0x00064780 File Offset: 0x00062980
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

		// Token: 0x06002257 RID: 8791 RVA: 0x000647CC File Offset: 0x000629CC
		private void chart_MouseMove(object sender, MouseEventArgs e)
		{
			Point position = e.GetPosition(this.chart);
			if (this.chart.CalcHitInfo(position) != null)
			{
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
				return;
			}
		}

		// Token: 0x06002258 RID: 8792 RVA: 0x000648C0 File Offset: 0x00062AC0
		private void ChartsDemoModule_ModuleAppear(object sender, RoutedEventArgs e)
		{
			this.chart.Animate();
		}

		// Token: 0x06002259 RID: 8793 RVA: 0x000648D8 File Offset: 0x00062AD8
		private void rblSweepDirection_SelectedIndexChanged(object sender, RoutedEventArgs e)
		{
			if (this.chart != null)
			{
				this.chart.Animate();
			}
		}

		// Token: 0x0600225A RID: 8794 RVA: 0x000648F8 File Offset: 0x00062AF8
		private void chart_QueryChartCursor(object sender, QueryChartCursorEventArgs e)
		{
			ChartHitInfo chartHitInfo = this.chart.CalcHitInfo(e.Position);
			if (chartHitInfo != null && chartHitInfo.SeriesPoint != null)
			{
				e.Cursor = Cursors.Hand;
			}
		}

		// Token: 0x040011A5 RID: 4517
		private const int clickDelta = 200;

		// Token: 0x040011A6 RID: 4518
		private bool rotate;

		// Token: 0x040011A7 RID: 4519
		private Point startPosition;

		// Token: 0x040011A8 RID: 4520
		private DateTime mouseDownTime;

		// Token: 0x040011A9 RID: 4521
		private double slRotation;

		// Token: 0x02000291 RID: 657
		public interface IDockLayoutService
		{
			// Token: 0x0600225D RID: 8797
			void Save(string path);

			// Token: 0x0600225E RID: 8798
			void Restore(string path);
		}
	}
}
