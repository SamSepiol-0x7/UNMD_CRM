using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;
using DevExpress.Xpf.Grid;

namespace ASC.Extensions
{
	// Token: 0x02000B4E RID: 2894
	public static class BindingHelper
	{
		// Token: 0x0600513B RID: 20795 RVA: 0x0015CFA8 File Offset: 0x0015B1A8
		public static string GetPath(GridColumn obj)
		{
			return (string)obj.GetValue(BindingHelper.PathProperty);
		}

		// Token: 0x0600513C RID: 20796 RVA: 0x0015CFC8 File Offset: 0x0015B1C8
		public static void SetPath(GridColumn obj, string value)
		{
			obj.SetValue(BindingHelper.PathProperty, value);
		}

		// Token: 0x0600513D RID: 20797 RVA: 0x0015CFE4 File Offset: 0x0015B1E4
		// Note: this type is marked as 'beforefieldinit'.
		static BindingHelper()
		{
		}

		// Token: 0x0400358B RID: 13707
		public static readonly DependencyProperty PathProperty = DependencyProperty.RegisterAttached("Path", typeof(string), typeof(BindingHelper), new PropertyMetadata(delegate(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(e.NewValue as string))
			{
				for (;;)
				{
					IL_69:
					int num = 2079981072;
					for (;;)
					{
						switch ((num ^ 1940601104) % 3)
						{
						case 0:
							goto IL_69;
						case 1:
						{
							ColumnBase columnBase = (GridColumn)d;
							string str = "RowData.Row.";
							object newValue = e.NewValue;
							columnBase.Binding = new Binding(str + ((newValue != null) ? newValue.ToString() : null))
							{
								Mode = BindingMode.TwoWay
							};
							num = 1087274069;
							continue;
						}
						}
						goto Block_3;
					}
				}
				Block_3:;
			}
		}));

		// Token: 0x02000B4F RID: 2895
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600513E RID: 20798 RVA: 0x0015D02C File Offset: 0x0015B22C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600513F RID: 20799 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06005140 RID: 20800 RVA: 0x0015D044 File Offset: 0x0015B244
			internal void <.cctor>b__3_0(DependencyObject d, DependencyPropertyChangedEventArgs e)
			{
				if (!string.IsNullOrWhiteSpace(e.NewValue as string))
				{
					for (;;)
					{
						IL_69:
						int num = 2079981072;
						for (;;)
						{
							switch ((num ^ 1940601104) % 3)
							{
							case 0:
								goto IL_69;
							case 1:
							{
								ColumnBase columnBase = (GridColumn)d;
								string str = "RowData.Row.";
								object newValue = e.NewValue;
								columnBase.Binding = new Binding(str + ((newValue != null) ? newValue.ToString() : null))
								{
									Mode = BindingMode.TwoWay
								};
								num = 1087274069;
								continue;
							}
							}
							goto Block_3;
						}
					}
					Block_3:;
				}
			}

			// Token: 0x0400358C RID: 13708
			public static readonly BindingHelper.<>c <>9 = new BindingHelper.<>c();
		}
	}
}
