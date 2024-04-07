using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.LayoutControl;

namespace ASC.RepairCard.Media
{
	// Token: 0x02000841 RID: 2113
	public partial class MediaView : UserControl
	{
		// Token: 0x06003EB9 RID: 16057 RVA: 0x000FAF90 File Offset: 0x000F9190
		public MediaView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06003EBA RID: 16058 RVA: 0x000FAFAC File Offset: 0x000F91AC
		private void layoutImagesItemsSizeChanged(object sender, ValueChangedEventArgs<Size> e)
		{
			Size maximizedElementOriginalSize = this.layoutImages.MaximizedElementOriginalSize;
			if (double.IsInfinity(e.NewValue.Width))
			{
				maximizedElementOriginalSize.Width = double.NaN;
			}
			else
			{
				maximizedElementOriginalSize.Height = double.NaN;
			}
			this.layoutImages.MaximizedElementOriginalSize = maximizedElementOriginalSize;
		}
	}
}
