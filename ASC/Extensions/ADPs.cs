using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace ASC.Extensions
{
	// Token: 0x02000B76 RID: 2934
	public class ADPs
	{
		// Token: 0x060051FA RID: 20986 RVA: 0x00160564 File Offset: 0x0015E764
		public static bool GetIsCellSelected(DependencyObject obj)
		{
			return (bool)obj.GetValue(ADPs.IsCellSelectedProperty);
		}

		// Token: 0x060051FB RID: 20987 RVA: 0x00160584 File Offset: 0x0015E784
		public static void SetIsCellSelected(DependencyObject obj, bool value)
		{
			obj.SetValue(ADPs.IsCellSelectedProperty, value);
		}

		// Token: 0x060051FC RID: 20988 RVA: 0x000046B4 File Offset: 0x000028B4
		public ADPs()
		{
		}

		// Token: 0x060051FD RID: 20989 RVA: 0x001605A4 File Offset: 0x0015E7A4
		// Note: this type is marked as 'beforefieldinit'.
		static ADPs()
		{
		}

		// Token: 0x040035CE RID: 13774
		public static readonly DependencyProperty IsCellSelectedProperty = DependencyProperty.RegisterAttached("IsCellSelected", typeof(bool), typeof(ADPs), new UIPropertyMetadata(false, delegate(DependencyObject o, DependencyPropertyChangedEventArgs e)
		{
			if (o is DataGridCell)
			{
				VisualTreeHelperEx.FindVisualParent<DataGridRow>(o as DataGridCell).SetValue(ADPs.IsCellSelectedProperty, e.NewValue);
			}
		}));

		// Token: 0x02000B77 RID: 2935
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060051FE RID: 20990 RVA: 0x001605F0 File Offset: 0x0015E7F0
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060051FF RID: 20991 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06005200 RID: 20992 RVA: 0x00160608 File Offset: 0x0015E808
			internal void <.cctor>b__4_0(DependencyObject o, DependencyPropertyChangedEventArgs e)
			{
				if (o is DataGridCell)
				{
					VisualTreeHelperEx.FindVisualParent<DataGridRow>(o as DataGridCell).SetValue(ADPs.IsCellSelectedProperty, e.NewValue);
				}
			}

			// Token: 0x040035CF RID: 13775
			public static readonly ADPs.<>c <>9 = new ADPs.<>c();
		}
	}
}
