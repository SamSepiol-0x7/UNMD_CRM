using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ASC.Extensions
{
	// Token: 0x02000B6C RID: 2924
	public static class CloseOnClickBehaviour
	{
		// Token: 0x060051C7 RID: 20935 RVA: 0x0015F73C File Offset: 0x0015D93C
		public static bool GetIsEnabled(DependencyObject obj)
		{
			return (bool)obj.GetValue(CloseOnClickBehaviour.IsEnabledProperty);
		}

		// Token: 0x060051C8 RID: 20936 RVA: 0x0015F75C File Offset: 0x0015D95C
		public static void SetIsEnabled(DependencyObject obj, bool value)
		{
			obj.SetValue(CloseOnClickBehaviour.IsEnabledProperty, value);
		}

		// Token: 0x060051C9 RID: 20937 RVA: 0x0015F77C File Offset: 0x0015D97C
		private static void OnIsEnabledPropertyChanged(DependencyObject dpo, DependencyPropertyChangedEventArgs args)
		{
			Button button = dpo as Button;
			if (button == null)
			{
				return;
			}
			bool flag = (bool)args.OldValue;
			bool flag2 = (bool)args.NewValue;
			if (flag || !flag2)
			{
				if (flag && !flag2)
				{
					button.PreviewMouseLeftButtonDown -= new MouseButtonEventHandler(CloseOnClickBehaviour.OnClick);
				}
				return;
			}
			button.Click += CloseOnClickBehaviour.OnClick;
		}

		// Token: 0x060051CA RID: 20938 RVA: 0x0015F7E4 File Offset: 0x0015D9E4
		private static void OnClick(object sender, RoutedEventArgs e)
		{
			Button button = sender as Button;
			if (button == null)
			{
				return;
			}
			Window window = Window.GetWindow(button);
			if (window == null)
			{
				return;
			}
			window.Close();
		}

		// Token: 0x060051CB RID: 20939 RVA: 0x0015F810 File Offset: 0x0015DA10
		// Note: this type is marked as 'beforefieldinit'.
		static CloseOnClickBehaviour()
		{
		}

		// Token: 0x040035B8 RID: 13752
		public static readonly DependencyProperty IsEnabledProperty = DependencyProperty.RegisterAttached("IsEnabled", typeof(bool), typeof(CloseOnClickBehaviour), new PropertyMetadata(false, new PropertyChangedCallback(CloseOnClickBehaviour.OnIsEnabledPropertyChanged)));
	}
}
