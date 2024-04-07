using System;
using System.Windows;
using System.Windows.Input;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.LayoutControl;

namespace ASC.RepairCard.Media
{
	// Token: 0x02000842 RID: 2114
	public class ImageContainer : ContentControlBase
	{
		// Token: 0x06003EBE RID: 16062 RVA: 0x000FB0B4 File Offset: 0x000F92B4
		protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonUp(e);
			if (base.Controller.IsMouseLeftButtonDown)
			{
				FlowLayoutControl flowLayoutControl = base.Parent as FlowLayoutControl;
				if (flowLayoutControl != null)
				{
					base.Controller.IsMouseEntered = false;
					flowLayoutControl.MaximizedElement = ((flowLayoutControl.MaximizedElement == this) ? null : this);
				}
			}
		}

		// Token: 0x06003EBF RID: 16063 RVA: 0x000FB104 File Offset: 0x000F9304
		protected override void OnSizeChanged(SizeChangedEventArgs e)
		{
			base.OnSizeChanged(e);
			if (!double.IsNaN(base.Width) && !double.IsNaN(base.Height))
			{
				if (e.NewSize.Width != e.PreviousSize.Width)
				{
					base.Height = double.NaN;
					return;
				}
				base.Width = double.NaN;
			}
		}

		// Token: 0x06003EC0 RID: 16064 RVA: 0x000FB170 File Offset: 0x000F9370
		public ImageContainer()
		{
		}
	}
}
