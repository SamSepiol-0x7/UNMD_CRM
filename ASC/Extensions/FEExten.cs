using System;
using System.Windows;
using System.Windows.Media;

namespace ASC.Extensions
{
	// Token: 0x02000B70 RID: 2928
	public static class FEExten
	{
		// Token: 0x060051E8 RID: 20968 RVA: 0x0015FF10 File Offset: 0x0015E110
		public static T TryFindParent<T>(this DependencyObject child) where T : DependencyObject
		{
			DependencyObject parentObject = child.GetParentObject();
			if (parentObject == null)
			{
				return default(T);
			}
			T t = parentObject as T;
			if (t == null)
			{
				return parentObject.TryFindParent<T>();
			}
			return t;
		}

		// Token: 0x060051E9 RID: 20969 RVA: 0x0015FF50 File Offset: 0x0015E150
		public static DependencyObject GetParentObject(this DependencyObject child)
		{
			if (child == null)
			{
				return null;
			}
			ContentElement contentElement = child as ContentElement;
			if (contentElement == null)
			{
				FrameworkElement frameworkElement = child as FrameworkElement;
				if (frameworkElement != null)
				{
					DependencyObject parent = frameworkElement.Parent;
					if (parent != null)
					{
						return parent;
					}
				}
				return VisualTreeHelper.GetParent(child);
			}
			DependencyObject parent2 = ContentOperations.GetParent(contentElement);
			if (parent2 != null)
			{
				return parent2;
			}
			FrameworkContentElement frameworkContentElement = contentElement as FrameworkContentElement;
			if (frameworkContentElement != null)
			{
				return frameworkContentElement.Parent;
			}
			return null;
		}
	}
}
