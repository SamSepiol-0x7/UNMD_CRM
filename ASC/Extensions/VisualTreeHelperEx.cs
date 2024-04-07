using System;
using System.Windows;
using System.Windows.Media;

namespace ASC.Extensions
{
	// Token: 0x02000B78 RID: 2936
	public class VisualTreeHelperEx
	{
		// Token: 0x06005201 RID: 20993 RVA: 0x0016063C File Offset: 0x0015E83C
		public static T FindVisualParent<T>(DependencyObject child) where T : DependencyObject
		{
			DependencyObject parent = VisualTreeHelper.GetParent(child);
			if (parent == null)
			{
				return default(T);
			}
			T t = parent as T;
			if (t == null)
			{
				return VisualTreeHelperEx.FindVisualParent<T>(parent);
			}
			return t;
		}

		// Token: 0x06005202 RID: 20994 RVA: 0x000046B4 File Offset: 0x000028B4
		public VisualTreeHelperEx()
		{
		}
	}
}
